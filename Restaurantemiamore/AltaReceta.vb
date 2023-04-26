Imports System.Data.SqlClient

Public Class AltaReceta

    Private Sub mostrar()
        Try
            Dim query As String = "select * from recetas2"
            Dim adapter As New SqlDataAdapter(query, ObtenerConexion)

            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error al recuperar datos: " & ex.Message)
        End Try
        ObtenerConexion.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mostrar()

    End Sub
End Class