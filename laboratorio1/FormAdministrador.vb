Imports MySqlConnector

Public Class FormAdministrador
    Private conexion As New MySqlConnection("server=localhost;port=3309;user id=root;password=1234;database=laboratorio_analisis;")

    Private Sub FormAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Panel de Administración"
        ' Aquí puedes cargar datos iniciales si es necesario
    End Sub

    Private Sub btnGestionUsuarios_Click(sender As Object, e As EventArgs) Handles btnGestionUsuarios.Click
        ' Aquí iría el código para abrir un formulario de gestión de usuarios
        MessageBox.Show("Funcionalidad de gestión de usuarios")
    End Sub

    Private Sub btnGestionAnalisis_Click(sender As Object, e As EventArgs) Handles btnGestionAnalisis.Click
        ' Aquí iría el código para abrir un formulario de gestión de tipos de análisis
        MessageBox.Show("Funcionalidad de gestión de análisis")
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim frmLogin As New Form1()
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Async Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Me.Opacity = 0.7 ' Hace semitransparente el formulario actual
        Await Task.Delay(200) ' Pequeña pausa para efecto visual

        Dim frmClientes As New FormClientes()
        frmClientes.Show()
        Me.Close() ' Cierra completamente el formulario actual
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class