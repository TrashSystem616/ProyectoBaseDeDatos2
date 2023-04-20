Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class AltasChefs
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim connectionString As String = "Data Source='CSARPC\SQLEXPRESS';Initial Catalog=Restaurante;Integrated Security=True"
            Dim conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Recetas"


        Catch ex As Exception

        End Try
    End Sub
End Class