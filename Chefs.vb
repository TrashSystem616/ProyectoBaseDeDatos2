Imports System.Data.SqlClient
Public Class Chefs
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim connectionString As String = "Data Source='CSARPC\SQLEXPRESS';Initial Catalog=Restaurante;Integrated Security=True"
            Dim connection As New SqlConnection(connectionString)
            Dim sql As String = "SELECT IdChef, Nombre, Apellidos, Puesto FROM Chefs WHERE IdChef = @IdChef"
            Dim command As New SqlCommand(sql, connection)
            command.Parameters.AddWithValue("@IdChef", TextBox1.Text)

            connection.Open()

            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim dataTable As New DataTable()
            dataTable.Load(reader)

            If dataTable.Rows.Count > 0 Then
                Dim row As DataRow = dataTable.Rows(0)
                lblNombre.Text = row("Nombre").ToString()
                lblApellidos.Text = row("Apellidos").ToString()
                lblPuesto.Text = row("Puesto").ToString()

                DataGridView1.DataSource = dataTable
            Else
                MessageBox.Show("No se ha encontrado ningún chef con esa ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            connection.Close()
        End If
    End Sub
End Class