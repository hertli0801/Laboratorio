Public Class FormRecpecion
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim frm As New FormClientes()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnNueSolicitud_Click(sender As Object, e As EventArgs) Handles btnNueSolicitud.Click
        Dim frm As New FormNuevaSolicitud
        frm.Show()
        Hide()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim frm As New Form1()
            frm.Show()
            Me.Close()
        End If

    End Sub
End Class