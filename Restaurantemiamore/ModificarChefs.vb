Imports System.Data.SqlClient

Public Class ModificarChefs

    Private Sub modificar()
        Try
            ' Obtener el valor máximo de la columna "id" de la tabla "chefs"
            Dim queryMax As String = "SELECT MAX(idchef) FROM chefs"
            Dim commandMax As New SqlCommand(queryMax, ObtenerConexion)
            Dim maxId As Integer = commandMax.ExecuteScalar()

            ' Verificar que la ID introducida sea válida
            Dim id As Integer = Integer.Parse(TextBox1.Text)
            If id > maxId Then
                MessageBox.Show("La ID introducida no es válida")
                Return
            Else
                Try
                    Dim result As DialogResult = MessageBox.Show("¿Está seguro de modificar al siguiente usuario?", "Confirmar modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        Dim query As String = "update chefs set nombre=@valor2, apellidos=@valor3, puesto=@valor4, usuario=@valor5, contraseña=@valor6 where idchef=@id "
                        Dim command As New SqlCommand(query, ObtenerConexion)

                        command.Parameters.AddWithValue("@id", TextBox1.Text)
                        command.Parameters.AddWithValue("@valor2", TextBox2.Text)
                        command.Parameters.AddWithValue("@valor3", TextBox3.Text)
                        command.Parameters.AddWithValue("@valor4", ComboBox1.SelectedItem)
                        command.Parameters.AddWithValue("@valor5", TextBox4.Text)
                        command.Parameters.AddWithValue("@valor6", TextBox5.Text)

                        command.ExecuteNonQuery()

                        MessageBox.Show("Se han actualizado los cambios")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al modificar" & ex.Message)
                End Try
                ObtenerConexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub mostrar()
        Try
            Dim query As String = "select * from chefs"
            Dim adapter As New SqlDataAdapter(query, ObtenerConexion)

            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error al recuperar datos: " & ex.Message)
        End Try
        ObtenerConexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        modificar()
        mostrar()

    End Sub

    Private Sub ModificarChefs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mostrar()
    End Sub
End Class