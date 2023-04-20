Imports System.Data.SqlClient
Public Class Login
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        'Crear la conexión a la base de datos'
        Dim connectionString As String = "Data Source='CSARPC\SQLEXPRESS';Initial Catalog=Restaurante;Integrated Security=True"
        Dim conn As New SqlConnection(connectionString)

        'Ejecutar la consulta SQL'
        ' Crear una consulta SQL para verificar las credenciales del usuario
        Dim consulta As String = "SELECT COUNT(*) FROM CHEFS WHERE usuario = @usuario AND contraseña = @contraseña"
        conn.Open()

        ' Crear un objeto de comando y asignar la consulta y la conexión
        Dim cmd As New SqlCommand(consulta, conn)

        ' Asignar los parámetros de la consulta
        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text)
        cmd.Parameters.AddWithValue("@contraseña", txtContraseña.Text)

        ' Ejecutar la consulta y obtener el número de filas afectadas
        Dim filas As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        ' Cerrar la conexión a la base de datos
        conn.Close()

        ' Verificar si se encontró una fila con las credenciales del usuario
        If filas > 0 Then
            ' Mostrar el formulario principal (Form1)
            Dim frm As New Form1()
            frm.Show()
            MessageBox.Show("Bienvenido.!!!:)")
        Else
            MessageBox.Show("Usuario o contraseña incorrectos:(")
        End If

    End Sub
End Class
