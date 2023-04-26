Imports System.Data.SqlClient

Module ConexionBD
    Public Function ObtenerConexion() As SqlConnection
        Dim connectionString As String = "Data Source='CSARPC\SQLEXPRESS';Initial Catalog=Restaurante;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)

        Try
            connection.Open()
            'MessageBox.Show("Conexión establecida correctamente")
        Catch ex As Exception
            MessageBox.Show("Error al establecer la conexión: " & ex.Message)
        End Try

        Return connection
    End Function

End Module

