Imports MySql.Data.MySqlClient

Public Class FormNuevoCliente
    Private conexion As New MySqlConnection("server=localhost;user id=root;password=;database=laboratorio_analisis;")

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Obtiene los valores de los campos
        Dim nombre As String = txtNombre.Text.Trim()
        Dim apellido As String = txtApellido.Text.Trim()
        Dim dirigido As String = txtDirigido.Text.Trim()
        Dim domicilio As String = txtDomicilio.Text.Trim()
        Dim cargo As String = txtCargo.Text.Trim()
        Dim correo As String = txtCorreo.Text.Trim()
        Dim telefonoCliente As String = txtTelCliente.Text.Trim()
        Dim telefonoEmpresa As String = txtTelEmpresa.Text.Trim()
        Dim actividad As String = txtActEmpresa.Text.Trim()

        ' Validación obligatoria
        If nombre = "" Or apellido = "" Then
            MessageBox.Show("Nombre y apellido son obligatorios.")
            Return
        End If

        Try
            conexion.Open()
            Dim query As String = "INSERT INTO clientes 
            (nombre, apellido, dirigido, cargo, telefono_cliente, telefono_empresa, direccion, correo, actividad) 
            VALUES 
            (@nombre, @apellido, @dirigido, @cargo, @telCliente, @telEmpresa, @direccion, @correo, @actividad)"

            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@apellido", apellido)
            comando.Parameters.AddWithValue("@dirigido", dirigido)
            comando.Parameters.AddWithValue("@cargo", cargo)
            comando.Parameters.AddWithValue("@telCliente", telefonoCliente)
            comando.Parameters.AddWithValue("@telEmpresa", telefonoEmpresa)
            comando.Parameters.AddWithValue("@direccion", domicilio)
            comando.Parameters.AddWithValue("@correo", correo)
            comando.Parameters.AddWithValue("@actividad", actividad)
            comando.ExecuteNonQuery()

            MessageBox.Show("Cliente guardado correctamente.")
            conexion.Close()

            ' Regresar a la pantalla anterior (opcional)
            Dim frmClientes As New FormClientes()
            frmClientes.Show()
            frmClientes.CargarClientes()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al guardar cliente: " & ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnSolicitudes_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        Dim frm As New FormRecpecion()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim frm As New FormClientes()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnNueSolicitud_Click(sender As Object, e As EventArgs) Handles btnNueSolicitud.Click
        Dim frm As New FormNuevaSolicitud()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnCerraSesion_Click(sender As Object, e As EventArgs) Handles btnCerraSesion.Click
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim frm As New Form1()
            frm.Show()
            Me.Close()
        End If
    End Sub
End Class
