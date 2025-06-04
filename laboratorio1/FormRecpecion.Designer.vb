<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecpecion
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
        Dim btnSolicitudes As Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRecpecion))
        panelAdmin = New Panel()
        btnCerrarSesion = New Button()
        btnNueSolicitud = New Button()
        btnClientes = New Button()
        btnMin = New Button()
        btnMax = New Button()
        btnCerrar = New Button()
        lblBienvenido = New Label()
        Label9 = New Label()
        Label10 = New Label()
        btnSolicitudes = New Button()
        panelAdmin.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSolicitudes
        ' 
        btnSolicitudes.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnSolicitudes.Cursor = Cursors.Hand
        btnSolicitudes.FlatAppearance.BorderSize = 0
        btnSolicitudes.FlatStyle = FlatStyle.Flat
        btnSolicitudes.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSolicitudes.ForeColor = Color.White
        btnSolicitudes.Location = New Point(52, 170)
        btnSolicitudes.Name = "btnSolicitudes"
        btnSolicitudes.Size = New Size(116, 29)
        btnSolicitudes.TabIndex = 10
        btnSolicitudes.Text = "Solicitudes"
        btnSolicitudes.UseVisualStyleBackColor = False
        ' 
        ' panelAdmin
        ' 
        panelAdmin.AutoSizeMode = AutoSizeMode.GrowAndShrink
        panelAdmin.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        panelAdmin.BorderStyle = BorderStyle.FixedSingle
        panelAdmin.Controls.Add(btnCerrarSesion)
        panelAdmin.Controls.Add(btnNueSolicitud)
        panelAdmin.Controls.Add(btnClientes)
        panelAdmin.Controls.Add(btnMin)
        panelAdmin.Controls.Add(btnSolicitudes)
        panelAdmin.Controls.Add(btnMax)
        panelAdmin.Controls.Add(btnCerrar)
        panelAdmin.Cursor = Cursors.Hand
        panelAdmin.Dock = DockStyle.Left
        panelAdmin.Location = New Point(0, 0)
        panelAdmin.Name = "panelAdmin"
        panelAdmin.Size = New Size(243, 580)
        panelAdmin.TabIndex = 8
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnCerrarSesion.Cursor = Cursors.Hand
        btnCerrarSesion.FlatAppearance.BorderSize = 0
        btnCerrarSesion.FlatStyle = FlatStyle.Flat
        btnCerrarSesion.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrarSesion.ForeColor = Color.White
        btnCerrarSesion.Location = New Point(36, 507)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(155, 29)
        btnCerrarSesion.TabIndex = 13
        btnCerrarSesion.Text = "Cerrar Sesión"
        btnCerrarSesion.UseVisualStyleBackColor = False
        ' 
        ' btnNueSolicitud
        ' 
        btnNueSolicitud.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnNueSolicitud.Cursor = Cursors.Hand
        btnNueSolicitud.FlatAppearance.BorderSize = 0
        btnNueSolicitud.FlatStyle = FlatStyle.Flat
        btnNueSolicitud.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNueSolicitud.ForeColor = Color.White
        btnNueSolicitud.Location = New Point(36, 395)
        btnNueSolicitud.Name = "btnNueSolicitud"
        btnNueSolicitud.Size = New Size(155, 29)
        btnNueSolicitud.TabIndex = 12
        btnNueSolicitud.Text = "Nueva Solicitud"
        btnNueSolicitud.UseVisualStyleBackColor = False
        ' 
        ' btnClientes
        ' 
        btnClientes.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnClientes.Cursor = Cursors.Hand
        btnClientes.FlatAppearance.BorderSize = 0
        btnClientes.FlatStyle = FlatStyle.Flat
        btnClientes.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClientes.ForeColor = Color.White
        btnClientes.Location = New Point(27, 278)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(180, 29)
        btnClientes.TabIndex = 11
        btnClientes.Text = "Clientes"
        btnClientes.UseVisualStyleBackColor = False
        ' 
        ' btnMin
        ' 
        btnMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMin.Cursor = Cursors.Hand
        btnMin.FlatAppearance.BorderSize = 0
        btnMin.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark
        btnMin.FlatStyle = FlatStyle.Flat
        btnMin.Image = CType(resources.GetObject("btnMin.Image"), Image)
        btnMin.Location = New Point(1068, 0)
        btnMin.Name = "btnMin"
        btnMin.Size = New Size(40, 40)
        btnMin.TabIndex = 3
        btnMin.UseVisualStyleBackColor = True
        ' 
        ' btnMax
        ' 
        btnMax.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMax.Cursor = Cursors.Hand
        btnMax.FlatAppearance.BorderSize = 0
        btnMax.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark
        btnMax.FlatStyle = FlatStyle.Flat
        btnMax.Image = CType(resources.GetObject("btnMax.Image"), Image)
        btnMax.Location = New Point(1105, 0)
        btnMax.Name = "btnMax"
        btnMax.Size = New Size(40, 40)
        btnMax.TabIndex = 2
        btnMax.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatAppearance.MouseDownBackColor = Color.Silver
        btnCerrar.FlatAppearance.MouseOverBackColor = Color.Red
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(1142, 0)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(40, 40)
        btnCerrar.TabIndex = 1
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' lblBienvenido
        ' 
        lblBienvenido.Anchor = AnchorStyles.None
        lblBienvenido.AutoSize = True
        lblBienvenido.Font = New Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBienvenido.ForeColor = Color.White
        lblBienvenido.Location = New Point(501, 28)
        lblBienvenido.Name = "lblBienvenido"
        lblBienvenido.Size = New Size(181, 39)
        lblBienvenido.TabIndex = 12
        lblBienvenido.Text = "Solicitudes"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(351, 125)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 26)
        Label9.TabIndex = 30
        Label9.Text = "Folio:"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Silver
        Label10.Location = New Point(577, 125)
        Label10.Name = "Label10"
        Label10.Size = New Size(55, 26)
        Label10.TabIndex = 31
        Label10.Text = "Folio"
        ' 
        ' FormRecpecion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(87), CByte(107))
        ClientSize = New Size(1100, 580)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(lblBienvenido)
        Controls.Add(panelAdmin)
        Name = "FormRecpecion"
        Text = "FormRecpecion"
        panelAdmin.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents panelAdmin As Panel
    Friend WithEvents btnNueSolicitud As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCerrarSesion As Button
End Class
