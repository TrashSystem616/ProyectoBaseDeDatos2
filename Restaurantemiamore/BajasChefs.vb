Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BajasChefs
    Private Sub mostrardatos()
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

    Private Sub verificarid()
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
                    Dim result As DialogResult = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        Dim query As String = "DELETE FROM chefs WHERE idchef = @id"
                        Dim command As New SqlCommand(query, ObtenerConexion)

                        command.Parameters.AddWithValue("@id", TextBox1.Text)

                        command.ExecuteNonQuery()

                        MessageBox.Show("Registro eliminado correctamente")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar, verifica que la id sea correcta" & ex.Message)
                End Try
                ObtenerConexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
    Private Sub bajaschefs()
        verificarid()
    End Sub

    Private Sub BajasChefs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrardatos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mostrardatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bajaschefs()
        mostrardatos()
    End Sub
End Class