Imports System.Data.SqlClient

Public Class Recetas
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Dim connectionString As String = "Data Source='CSARPC\SQLEXPRESS';Initial Catalog=Restaurante;Integrated Security=True"
        Dim conn As New SqlConnection(connectionString)
        Dim query As String = "SELECT * FROM Recetas"
        Dim adapter As New SqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim connString As String = "Data Source='CSARPC\SQLEXPRESS';Initial Catalog=Restaurante;Integrated Security=True"
        Dim query As String = "SELECT * FROM Recetas WHERE Nombre LIKE '%" & TextBox1.Text & "%'"
        Dim conn As New SqlConnection(connString)
        Dim adapter As New SqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        BuscarRecetas()
    End Sub

    Private Sub BuscarRecetas()
        Dim connString As String = "Data Source='CSARPC\SQLEXPRESS';Initial Catalog=Restaurante;Integrated Security=True"
        Dim query As String = "SELECT * FROM Recetas WHERE Nombre LIKE '%" & TextBox1.Text & "%'"
        Dim conn As New SqlConnection(connString)
        Dim adapter As New SqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count = 0 Then
            MessageBox.Show("No se encontraron resultados para la búsqueda:(")
        Else
            DataGridView1.DataSource = table
        End If
    End Sub
    Private Function ObtenerIngredientesPorIdReceta(idReceta As Integer) As String
        Dim connectionString As String = "Data Source='CSARPC\SQLEXPRESS';Initial Catalog=Restaurante;Integrated Security=True"
        Dim query As String = "SELECT ingredientes FROM recetas WHERE idrecetas = @idReceta;"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idReceta", idReceta)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing Then
                    Return result.ToString()
                End If
            End Using
        End Using
        Return ""
    End Function

    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then ' Verifica si se ha hecho clic en una fila y no en el encabezado
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            lblIdReceta.Text = row.Cells("idrecetas").Value.ToString()
            lblNombre.Text = row.Cells("nombre").Value.ToString()
            lblCategoria.Text = row.Cells("Categoria").Value.ToString()
            lblTiempo.Text = row.Cells("Tiempo").Value.ToString()

        End If

        If e.RowIndex >= 0 Then ' Verifica si se ha hecho clic en una fila válida
            Dim idReceta As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("idrecetas").Value)
            Dim ingredientes As String = ObtenerIngredientesPorIdReceta(idReceta) ' Llamada a una función que obtiene los ingredientes de la receta a partir del idReceta
            ListBox1.Items.Clear()
            For Each ingrediente As String In ingredientes.Split(","c)
                ListBox1.Items.Add(ingrediente.Trim())
            Next
        End If
    End Sub

    Private Sub Recetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class