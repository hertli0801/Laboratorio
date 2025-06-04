<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNuevoCliente))
        Label10 = New Label()
        Label9 = New Label()
        btnGuardar = New Button()
        txtActEmpresa = New TextBox()
        Label8 = New Label()
        txtTelCliente = New TextBox()
        Label7 = New Label()
        txtCorreo = New TextBox()
        Label6 = New Label()
        txtCargo = New TextBox()
        Label5 = New Label()
        txtNombre = New TextBox()
        Label4 = New Label()
        txtDomicilio = New TextBox()
        Label3 = New Label()
        txtDirigido = New TextBox()
        Label2 = New Label()
        txtTelEmpresa = New TextBox()
        Label1 = New Label()
        lblBienvenido = New Label()
        panelAdmin = New Panel()
        btnCerraSesion = New Button()
        btnSolicitudes = New Button()
        btnNueSolicitud = New Button()
        btnClientes = New Button()
        btnMin = New Button()
        btnMax = New Button()
        btnCerrar = New Button()
        txtApellido = New TextBox()
        Label11 = New Label()
        panelAdmin.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Silver
        Label10.Location = New Point(639, 140)
        Label10.Name = "Label10"
        Label10.Size = New Size(55, 26)
        Label10.TabIndex = 52
        Label10.Text = "Folio"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(363, 140)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 26)
        Label9.TabIndex = 51
        Label9.Text = "Folio:"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnGuardar.Cursor = Cursors.Hand
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(622, 671)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(116, 29)
        btnGuardar.TabIndex = 50
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' txtActEmpresa
        ' 
        txtActEmpresa.Location = New Point(750, 560)
        txtActEmpresa.Name = "txtActEmpresa"
        txtActEmpresa.Size = New Size(324, 27)
        txtActEmpresa.TabIndex = 49
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(365, 561)
        Label8.Name = "Label8"
        Label8.Size = New Size(364, 26)
        Label8.TabIndex = 48
        Label8.Text = "Actividad de la empresa del cliente:"
        ' 
        ' txtTelCliente
        ' 
        txtTelCliente.Location = New Point(648, 462)
        txtTelCliente.Name = "txtTelCliente"
        txtTelCliente.Size = New Size(324, 27)
        txtTelCliente.TabIndex = 47
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(362, 508)
        Label7.Name = "Label7"
        Label7.Size = New Size(248, 26)
        Label7.TabIndex = 46
        Label7.Text = "Telefono de la empresa:"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(648, 414)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(324, 27)
        txtCorreo.TabIndex = 45
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(362, 463)
        Label6.Name = "Label6"
        Label6.Size = New Size(212, 26)
        Label6.TabIndex = 44
        Label6.Text = "Telefono del cliente:"
        ' 
        ' txtCargo
        ' 
        txtCargo.Location = New Point(648, 369)
        txtCargo.Name = "txtCargo"
        txtCargo.Size = New Size(324, 27)
        txtCargo.TabIndex = 43
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(363, 415)
        Label5.Name = "Label5"
        Label5.Size = New Size(201, 26)
        Label5.TabIndex = 42
        Label5.Text = "Correo Electrónico:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(648, 189)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(324, 27)
        txtNombre.TabIndex = 41
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(365, 277)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 26)
        Label4.TabIndex = 40
        Label4.Text = "Dirigido a:"
        ' 
        ' txtDomicilio
        ' 
        txtDomicilio.Location = New Point(648, 322)
        txtDomicilio.Name = "txtDomicilio"
        txtDomicilio.Size = New Size(324, 27)
        txtDomicilio.TabIndex = 39
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(362, 370)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 26)
        Label3.TabIndex = 38
        Label3.Text = "Cargo:"
        ' 
        ' txtDirigido
        ' 
        txtDirigido.Location = New Point(648, 278)
        txtDirigido.Name = "txtDirigido"
        txtDirigido.Size = New Size(324, 27)
        txtDirigido.TabIndex = 37
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(362, 323)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 26)
        Label2.TabIndex = 36
        Label2.Text = "Domicilio:"
        ' 
        ' txtTelEmpresa
        ' 
        txtTelEmpresa.Location = New Point(648, 507)
        txtTelEmpresa.Name = "txtTelEmpresa"
        txtTelEmpresa.Size = New Size(324, 27)
        txtTelEmpresa.TabIndex = 35
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(365, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 26)
        Label1.TabIndex = 34
        Label1.Text = "Nombre (s):"
        ' 
        ' lblBienvenido
        ' 
        lblBienvenido.Anchor = AnchorStyles.None
        lblBienvenido.AutoSize = True
        lblBienvenido.Font = New Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBienvenido.ForeColor = Color.White
        lblBienvenido.Location = New Point(563, 89)
        lblBienvenido.Name = "lblBienvenido"
        lblBienvenido.Size = New Size(226, 39)
        lblBienvenido.TabIndex = 33
        lblBienvenido.Text = "Nuevo Cliente"
        ' 
        ' panelAdmin
        ' 
        panelAdmin.AutoSizeMode = AutoSizeMode.GrowAndShrink
        panelAdmin.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        panelAdmin.BorderStyle = BorderStyle.FixedSingle
        panelAdmin.Controls.Add(btnCerraSesion)
        panelAdmin.Controls.Add(btnSolicitudes)
        panelAdmin.Controls.Add(btnNueSolicitud)
        panelAdmin.Controls.Add(btnClientes)
        panelAdmin.Controls.Add(btnMin)
        panelAdmin.Controls.Add(btnMax)
        panelAdmin.Controls.Add(btnCerrar)
        panelAdmin.Cursor = Cursors.Hand
        panelAdmin.Dock = DockStyle.Left
        panelAdmin.Location = New Point(0, 0)
        panelAdmin.Name = "panelAdmin"
        panelAdmin.Size = New Size(243, 703)
        panelAdmin.TabIndex = 32
        ' 
        ' btnCerraSesion
        ' 
        btnCerraSesion.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnCerraSesion.Cursor = Cursors.Hand
        btnCerraSesion.FlatAppearance.BorderSize = 0
        btnCerraSesion.FlatStyle = FlatStyle.Flat
        btnCerraSesion.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerraSesion.ForeColor = Color.White
        btnCerraSesion.Location = New Point(36, 604)
        btnCerraSesion.Name = "btnCerraSesion"
        btnCerraSesion.Size = New Size(155, 29)
        btnCerraSesion.TabIndex = 14
        btnCerraSesion.Text = "Cerrar Sesión"
        btnCerraSesion.UseVisualStyleBackColor = False
        ' 
        ' btnSolicitudes
        ' 
        btnSolicitudes.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnSolicitudes.Cursor = Cursors.Hand
        btnSolicitudes.FlatAppearance.BorderSize = 0
        btnSolicitudes.FlatStyle = FlatStyle.Flat
        btnSolicitudes.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSolicitudes.ForeColor = Color.White
        btnSolicitudes.Location = New Point(36, 149)
        btnSolicitudes.Name = "btnSolicitudes"
        btnSolicitudes.Size = New Size(180, 29)
        btnSolicitudes.TabIndex = 13
        btnSolicitudes.Text = "Solicitudes"
        btnSolicitudes.UseVisualStyleBackColor = False
        ' 
        ' btnNueSolicitud
        ' 
        btnNueSolicitud.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnNueSolicitud.Cursor = Cursors.Hand
        btnNueSolicitud.FlatAppearance.BorderSize = 0
        btnNueSolicitud.FlatStyle = FlatStyle.Flat
        btnNueSolicitud.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNueSolicitud.ForeColor = Color.White
        btnNueSolicitud.Location = New Point(36, 434)
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
        btnMin.Location = New Point(1109, 0)
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
        btnMax.Location = New Point(1146, 0)
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
        btnCerrar.Location = New Point(1183, 0)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(40, 40)
        btnCerrar.TabIndex = 1
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(648, 234)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(324, 27)
        txtApellido.TabIndex = 54
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(362, 235)
        Label11.Name = "Label11"
        Label11.Size = New Size(103, 26)
        Label11.TabIndex = 53
        Label11.Text = "Apellidos"
        ' 
        ' FormNuevoCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(87), CByte(107))
        ClientSize = New Size(1100, 703)
        Controls.Add(txtApellido)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(btnGuardar)
        Controls.Add(txtActEmpresa)
        Controls.Add(Label8)
        Controls.Add(txtTelCliente)
        Controls.Add(Label7)
        Controls.Add(txtTelEmpresa)
        Controls.Add(txtCorreo)
        Controls.Add(Label6)
        Controls.Add(txtCargo)
        Controls.Add(Label5)
        Controls.Add(txtNombre)
        Controls.Add(Label4)
        Controls.Add(txtDomicilio)
        Controls.Add(Label3)
        Controls.Add(txtDirigido)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblBienvenido)
        Controls.Add(panelAdmin)
        Name = "FormNuevoCliente"
        Text = "FormNuevoCliente"
        panelAdmin.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtActEmpresa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDirigido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelEmpresa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents panelAdmin As Panel
    Friend WithEvents btnNueSolicitud As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnSolicitudes As Button
    Friend WithEvents btnCerraSesion As Button
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label11 As Label
End Class
