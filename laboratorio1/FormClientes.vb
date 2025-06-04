Imports MySql.Data.MySqlClient

Public Class FormClientes
    Private conexion As New MySqlConnection("server=localhost;user id=root;password=;database=laboratorio_analisis;")

    Public Sub CargarClientes()
        Try
            conexion.Open()

            Dim query As String = "SELECT id, nombre, apellido, dirigido, cargo, telefono_cliente, telefono_empresa, direccion, correo, actividad FROM clientes"

            Dim comando As New MySqlCommand(query, conexion)
            Dim adapter As New MySqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adapter.Fill(tabla)

            ' Desactiva la autogeneración para usar tus propias columnas
            dgvClientes.AutoGenerateColumns = False
            dgvClientes.DataSource = tabla

            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar clientes: " & ex.Message)
            conexion.Close()
        End Try
    End Sub


    ' Puedes llamar a este método cuando se cargue el formulario
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarClientes()
    End Sub

    Private Sub btnSolicitudes_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        Dim frm As New FormRecpecion()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnNueSolictud_Click(sender As Object, e As EventArgs) Handles btnNueSolictud.Click
        Dim frm As New FormNuevaSolicitud()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim frm As New Form1()
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAgreCliente_Click(sender As Object, e As EventArgs) Handles btnAgreCliente.Click
        Dim frm As New FormNuevoCliente()
        frm.Show()
        Me.Hide()
    End Sub


End Class