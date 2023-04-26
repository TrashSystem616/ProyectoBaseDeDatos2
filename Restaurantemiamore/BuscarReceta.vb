Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class BuscarReceta
    Private Sub buscar()
        Try
            Dim query As String = "SELECT * FROM recetas2 WHERE idreceta = @id"
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

    Private Sub filtrar()
        Dim busqueda As String = "%" & TextBox2.Text & "%" ' Agregar comodines a la cadena de búsqueda

        Dim query As String = "SELECT * FROM recetas2 WHERE nombre LIKE @busqueda"
        Dim command As New SqlCommand(query, ObtenerConexion)
        command.Parameters.AddWithValue("@busqueda", busqueda)

        Dim adapter As New SqlDataAdapter(command)
        Dim dataset As New DataSet()
        adapter.Fill(dataset, "Recetas2")

        If dataset.Tables("Recetas2").Rows.Count > 0 Then ' Verificar si se encontró alguna coincidencia
            DataGridView1.DataSource = dataset.Tables("Recetas2")
            MessageBox.Show("Se encontraron " & dataset.Tables("Recetas2").Rows.Count & " resultados.")
        Else
            MessageBox.Show("No se encontraron resultados.")
        End If

        ObtenerConexion.Close()

    End Sub

    Private Sub tipo()
        Try
            Dim campo As String = ComboBox1.SelectedItem.ToString()
            Dim query As String = "SELECT * FROM Recetas2 WHERE tipo = @valor"

            Dim command As New SqlCommand(query, ObtenerConexion())
            command.Parameters.AddWithValue("@valor", campo)

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table

            If table.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron resultados para la búsqueda")
            End If

        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filtrar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tipo()
    End Sub
End Class