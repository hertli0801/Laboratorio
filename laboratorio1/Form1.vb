
Imports MySqlConnector

Public Class Form1

    ' Cadena de conexión (cambia la contraseña)
    Private conexion As New MySqlConnection("server=localhost;port=3309;user id=root;password=1234;database=laboratorio_analisis;")

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim usuario As String = txtUsuario.Text.Trim()
        Dim contraseña As String = txtContrasena.Text.Trim()

        If usuario = "" Or contraseña = "" Then
            lblMensaje.Text = "Por favor, ingresa usuario y contraseña"
            Return
        End If

        Try
            conexion.Open()
            Dim consulta As String = "SELECT * FROM usuarios WHERE nombre_usuario=@usuario AND contrasena=@clave AND estatus='activo'"
            Dim cmd As New MySqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@clave", contraseña)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim rol As String = reader("rol").ToString().ToLower()

                Select Case rol
                    Case "recepcionista"
                        ' formulario para recepcionista
                        Dim frm As New FormRecpecion()
                        frm.Show()
                        Me.Hide()
                    Case "tecnico"
                        ' formulario para técnico
                    Case "gerente"
                        ' formulario para gerente
                    Case "administrador"
                        Dim frmAdmin As New FormAdministrador()
                        frmAdmin.Show()
                        Me.Hide()
                    Case Else
                        MessageBox.Show("Usuario no encontrado")
                End Select
                lblMensaje.Text = ""
            Else
                lblMensaje.Text = "Usuario o contraseña incorrectos o usuario inactivo"
            End If

            reader.Close()
            conexion.Close()

        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        End Try
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class
