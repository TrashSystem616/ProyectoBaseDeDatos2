Imports System.Data.SqlClient

Public Class AltasChefs
    Private Sub mostrardatosgird()
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

    Private Sub altachef()
        Try
            Dim query As String = "INSERT INTO chefs (idchef, nombre, apellidos, puesto, usuario, contraseña) VALUES (@valor1, @valor2, @valor3, @valor4, @valor5, @valor6)"
            Dim command As New SqlCommand(query, ObtenerConexion)

            command.Parameters.AddWithValue("@valor1", TextBox1.Text)
            command.Parameters.AddWithValue("@valor2", TextBox2.Text)
            command.Parameters.AddWithValue("@valor3", TextBox3.Text)
            command.Parameters.AddWithValue("@valor4", ComboBox1.SelectedItem)
            command.Parameters.AddWithValue("@valor5", TextBox4.Text)
            command.Parameters.AddWithValue("@valor6", TextBox5.Text)

            command.ExecuteNonQuery()


            MessageBox.Show("Registro agregado correctamente")
        Catch ex As Exception
            MessageBox.Show("Error al agregar , verifica que hayas llenado todos los datos")

        End Try

        ObtenerConexion.Close()

    End Sub

    Private Sub AltasChefs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerConexion()
        mostrardatosgird()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mostrardatosgird()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        altachef()
    End Sub
End Class