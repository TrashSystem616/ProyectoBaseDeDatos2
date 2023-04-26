Imports System.Data.SqlClient

Public Class BuscarChef

    Private Sub buscar()
        Try
            Dim query As String = "SELECT * FROM chefs WHERE idchef = @id"
            Dim command As New SqlCommand(query, ObtenerConexion)
            command.Parameters.AddWithValue("@id", TextBox1.Text)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)


            If table.Rows.Count > 0 Then
                MessageBox.Show("Se encontró el registro")
                DataGridView1.DataSource = table
            Else
                MessageBox.Show("No se encontró ningún registro con ese ID")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar()
    End Sub
End Class