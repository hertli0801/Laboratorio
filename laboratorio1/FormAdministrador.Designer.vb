<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        BtnGestionUsuarios = New Button()
        BtnGestionAnalisis = New Button()
        BtnRegresar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        BtnClientes = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(314, 93)
        Button1.Name = "Button1"
        Button1.Size = New Size(8, 8)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnGestionUsuarios
        ' 
        BtnGestionUsuarios.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        BtnGestionUsuarios.Cursor = Cursors.Hand
        BtnGestionUsuarios.FlatStyle = FlatStyle.Flat
        BtnGestionUsuarios.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold)
        BtnGestionUsuarios.ForeColor = Color.White
        BtnGestionUsuarios.Location = New Point(344, 62)
        BtnGestionUsuarios.Name = "BtnGestionUsuarios"
        BtnGestionUsuarios.Size = New Size(116, 29)
        BtnGestionUsuarios.TabIndex = 50
        BtnGestionUsuarios.Text = "Entrar"
        BtnGestionUsuarios.UseVisualStyleBackColor = False
        ' 
        ' BtnGestionAnalisis
        ' 
        BtnGestionAnalisis.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        BtnGestionAnalisis.Cursor = Cursors.Hand
        BtnGestionAnalisis.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold)
        BtnGestionAnalisis.ForeColor = Color.White
        BtnGestionAnalisis.Location = New Point(344, 165)
        BtnGestionAnalisis.Name = "BtnGestionAnalisis"
        BtnGestionAnalisis.Size = New Size(116, 29)
        BtnGestionAnalisis.TabIndex = 2
        BtnGestionAnalisis.Text = "Entrar"
        BtnGestionAnalisis.UseVisualStyleBackColor = False
        ' 
        ' BtnRegresar
        ' 
        BtnRegresar.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        BtnRegresar.Cursor = Cursors.Hand
        BtnRegresar.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold)
        BtnRegresar.ForeColor = Color.White
        BtnRegresar.Location = New Point(60, 407)
        BtnRegresar.Name = "BtnRegresar"
        BtnRegresar.Size = New Size(116, 29)
        BtnRegresar.TabIndex = 3
        BtnRegresar.Text = "Volver"
        BtnRegresar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(130, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 26)
        Label1.TabIndex = 4
        Label1.Text = "Gestion de usuarios"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(193, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 26)
        Label2.TabIndex = 5
        Label2.Text = "Ver análisis"
        ' 
        ' BtnClientes
        ' 
        BtnClientes.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        BtnClientes.Cursor = Cursors.Hand
        BtnClientes.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold)
        BtnClientes.ForeColor = Color.White
        BtnClientes.Location = New Point(344, 117)
        BtnClientes.Name = "BtnClientes"
        BtnClientes.Size = New Size(116, 29)
        BtnClientes.TabIndex = 6
        BtnClientes.Text = "Entrar"
        BtnClientes.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(152, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 26)
        Label3.TabIndex = 7
        Label3.Text = "Revisar clientes"
        ' 
        ' FormAdministrador
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(87), CByte(107))
        ClientSize = New Size(1100, 703)
        Controls.Add(Label3)
        Controls.Add(BtnClientes)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnRegresar)
        Controls.Add(BtnGestionAnalisis)
        Controls.Add(BtnGestionUsuarios)
        Controls.Add(Button1)
        Name = "FormAdministrador"
        Text = "FormAdministrador"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BtnGestionUsuarios As Button
    Friend WithEvents BtnGestionAnalisis As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnClientes As Button
    Friend WithEvents Label3 As Label
End Class
