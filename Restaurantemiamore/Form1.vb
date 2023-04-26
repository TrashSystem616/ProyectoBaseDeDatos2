Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Restaurantemiamore.ConexionBD

Public Class Form1
    Private Sub validarusuario()
        Try
            ObtenerConexion()
            Dim query As String = "select puesto from chefs where usuario = @usuario and contraseña = @contraseña"
            Dim command As New SqlCommand(query, ObtenerConexion)
            command.Parameters.AddWithValue("@usuario", TextBox1.Text)
            command.Parameters.AddWithValue("@contraseña", TextBox2.Text)

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim puesto As String = reader.GetString(0)
                If puesto = "Chef Ejecutivo" Then
                    ' Mostrar ventana con permisos de administrador
                    Dim formAdmin As New FormAdmin()
                    formAdmin.Show()
                    Me.Hide()
                ElseIf puesto = "Chef Asociado" Then
                    ' Mostrar ventana con permisos de usuario normal
                    Dim formUsuario As New FormUsuario()
                    formUsuario.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Error al inicio de seccion por favor revisa tu usuario u contraseña")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al establecer la conexión: " & ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        validarusuario()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
