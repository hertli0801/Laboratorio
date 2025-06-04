<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
        lblBienvenido = New Label()
        panelAdmin = New Panel()
        btnCerrarSesion = New Button()
        btnSolicitudes = New Button()
        btnNueSolictud = New Button()
        btnClientes = New Button()
        btnMin = New Button()
        btnMax = New Button()
        btnCerrar = New Button()
        btnBuscar = New Button()
        dgvClientes = New DataGridView()
        colId = New DataGridViewTextBoxColumn()
        colNombre = New DataGridViewTextBoxColumn()
        colApellido = New DataGridViewTextBoxColumn()
        colDirigido = New DataGridViewTextBoxColumn()
        colDireccion = New DataGridViewTextBoxColumn()
        colCargo = New DataGridViewTextBoxColumn()
        colCorreo = New DataGridViewTextBoxColumn()
        colTelCliente = New DataGridViewTextBoxColumn()
        colTelEmpresa = New DataGridViewTextBoxColumn()
        colActividad = New DataGridViewTextBoxColumn()
        TextBox1 = New TextBox()
        btnAgreCliente = New Button()
        Label1 = New Label()
        panelAdmin.SuspendLayout()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblBienvenido
        ' 
        lblBienvenido.Anchor = AnchorStyles.Top
        lblBienvenido.Font = New Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBienvenido.ForeColor = Color.White
        lblBienvenido.Location = New Point(804, 28)
        lblBienvenido.Name = "lblBienvenido"
        lblBienvenido.Size = New Size(139, 39)
        lblBienvenido.TabIndex = 33
        lblBienvenido.Text = "Clientes"
        ' 
        ' panelAdmin
        ' 
        panelAdmin.Anchor = AnchorStyles.Left
        panelAdmin.AutoSizeMode = AutoSizeMode.GrowAndShrink
        panelAdmin.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        panelAdmin.BorderStyle = BorderStyle.FixedSingle
        panelAdmin.Controls.Add(btnCerrarSesion)
        panelAdmin.Controls.Add(btnSolicitudes)
        panelAdmin.Controls.Add(btnNueSolictud)
        panelAdmin.Controls.Add(btnClientes)
        panelAdmin.Controls.Add(btnMin)
        panelAdmin.Controls.Add(btnMax)
        panelAdmin.Controls.Add(btnCerrar)
        panelAdmin.Cursor = Cursors.Hand
        panelAdmin.Location = New Point(0, 0)
        panelAdmin.Name = "panelAdmin"
        panelAdmin.Size = New Size(197, 580)
        panelAdmin.TabIndex = 32
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.Anchor = AnchorStyles.Left
        btnCerrarSesion.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnCerrarSesion.Cursor = Cursors.Hand
        btnCerrarSesion.FlatAppearance.BorderSize = 0
        btnCerrarSesion.FlatStyle = FlatStyle.Flat
        btnCerrarSesion.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrarSesion.ForeColor = Color.White
        btnCerrarSesion.Location = New Point(21, 513)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(155, 29)
        btnCerrarSesion.TabIndex = 14
        btnCerrarSesion.Text = "Cerrar Sesión"
        btnCerrarSesion.UseVisualStyleBackColor = False
        ' 
        ' btnSolicitudes
        ' 
        btnSolicitudes.Anchor = AnchorStyles.Left
        btnSolicitudes.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnSolicitudes.Cursor = Cursors.Hand
        btnSolicitudes.FlatAppearance.BorderSize = 0
        btnSolicitudes.FlatStyle = FlatStyle.Flat
        btnSolicitudes.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSolicitudes.ForeColor = Color.White
        btnSolicitudes.Location = New Point(12, 165)
        btnSolicitudes.Name = "btnSolicitudes"
        btnSolicitudes.Size = New Size(180, 29)
        btnSolicitudes.TabIndex = 13
        btnSolicitudes.Text = "Solicitudes"
        btnSolicitudes.UseVisualStyleBackColor = False
        ' 
        ' btnNueSolictud
        ' 
        btnNueSolictud.Anchor = AnchorStyles.Left
        btnNueSolictud.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnNueSolictud.Cursor = Cursors.Hand
        btnNueSolictud.FlatAppearance.BorderSize = 0
        btnNueSolictud.FlatStyle = FlatStyle.Flat
        btnNueSolictud.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNueSolictud.ForeColor = Color.White
        btnNueSolictud.Location = New Point(21, 373)
        btnNueSolictud.Name = "btnNueSolictud"
        btnNueSolictud.Size = New Size(155, 29)
        btnNueSolictud.TabIndex = 12
        btnNueSolictud.Text = "Nueva Solicitud"
        btnNueSolictud.UseVisualStyleBackColor = False
        ' 
        ' btnClientes
        ' 
        btnClientes.Anchor = AnchorStyles.Left
        btnClientes.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnClientes.Cursor = Cursors.Hand
        btnClientes.FlatAppearance.BorderSize = 0
        btnClientes.FlatStyle = FlatStyle.Flat
        btnClientes.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClientes.ForeColor = Color.White
        btnClientes.Location = New Point(11, 270)
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
        btnMin.Location = New Point(1063, 0)
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
        btnMax.Location = New Point(1100, 0)
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
        btnCerrar.Location = New Point(1137, 0)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(40, 40)
        btnCerrar.TabIndex = 1
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.FromArgb(CByte(29), CByte(87), CByte(107))
        btnBuscar.Cursor = Cursors.Hand
        btnBuscar.FlatAppearance.BorderSize = 0
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = Color.White
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.Location = New Point(218, 78)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(116, 77)
        btnBuscar.TabIndex = 50
        btnBuscar.Text = "Buscar"
        btnBuscar.TextAlign = ContentAlignment.BottomCenter
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' dgvClientes
        ' 
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClientes.Columns.AddRange(New DataGridViewColumn() {colId, colNombre, colApellido, colDirigido, colDireccion, colCargo, colCorreo, colTelCliente, colTelEmpresa, colActividad})
        dgvClientes.Location = New Point(218, 184)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.RowHeadersWidth = 51
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvClientes.Size = New Size(1307, 295)
        dgvClientes.TabIndex = 53
        ' 
        ' colId
        ' 
        colId.DataPropertyName = "id"
        colId.HeaderText = "ID"
        colId.MinimumWidth = 6
        colId.Name = "colId"
        colId.Width = 125
        ' 
        ' colNombre
        ' 
        colNombre.DataPropertyName = "nombre"
        colNombre.HeaderText = "Nombre"
        colNombre.MinimumWidth = 6
        colNombre.Name = "colNombre"
        colNombre.Width = 125
        ' 
        ' colApellido
        ' 
        colApellido.DataPropertyName = "apellido"
        colApellido.HeaderText = "Apellidos"
        colApellido.MinimumWidth = 6
        colApellido.Name = "colApellido"
        colApellido.Width = 125
        ' 
        ' colDirigido
        ' 
        colDirigido.DataPropertyName = "dirigido"
        colDirigido.HeaderText = "Dirigido a"
        colDirigido.MinimumWidth = 6
        colDirigido.Name = "colDirigido"
        colDirigido.Width = 125
        ' 
        ' colDireccion
        ' 
        colDireccion.DataPropertyName = "direccion"
        colDireccion.HeaderText = "Dirección"
        colDireccion.MinimumWidth = 6
        colDireccion.Name = "colDireccion"
        colDireccion.Width = 125
        ' 
        ' colCargo
        ' 
        colCargo.DataPropertyName = "cargo"
        colCargo.HeaderText = "Cargo"
        colCargo.MinimumWidth = 6
        colCargo.Name = "colCargo"
        colCargo.Width = 125
        ' 
        ' colCorreo
        ' 
        colCorreo.DataPropertyName = "correo"
        colCorreo.HeaderText = "Correo Electrónico"
        colCorreo.MinimumWidth = 6
        colCorreo.Name = "colCorreo"
        colCorreo.Width = 125
        ' 
        ' colTelCliente
        ' 
        colTelCliente.DataPropertyName = "telefono_cliente"
        colTelCliente.HeaderText = "Tel. Cliente"
        colTelCliente.MinimumWidth = 6
        colTelCliente.Name = "colTelCliente"
        colTelCliente.Width = 125
        ' 
        ' colTelEmpresa
        ' 
        colTelEmpresa.DataPropertyName = "telefono_empresa"
        colTelEmpresa.HeaderText = "Tel. Empresa"
        colTelEmpresa.MinimumWidth = 6
        colTelEmpresa.Name = "colTelEmpresa"
        colTelEmpresa.Width = 125
        ' 
        ' colActividad
        ' 
        colActividad.DataPropertyName = "actividad"
        colActividad.HeaderText = "Actividad de la Empresa"
        colActividad.MinimumWidth = 6
        colActividad.Name = "colActividad"
        colActividad.Width = 125
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(309, 110)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(270, 27)
        TextBox1.TabIndex = 54
        ' 
        ' btnAgreCliente
        ' 
        btnAgreCliente.BackColor = Color.FromArgb(CByte(29), CByte(87), CByte(107))
        btnAgreCliente.Cursor = Cursors.Hand
        btnAgreCliente.FlatAppearance.BorderSize = 0
        btnAgreCliente.FlatStyle = FlatStyle.Flat
        btnAgreCliente.Font = New Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgreCliente.ForeColor = Color.White
        btnAgreCliente.Image = CType(resources.GetObject("btnAgreCliente.Image"), Image)
        btnAgreCliente.Location = New Point(1064, 82)
        btnAgreCliente.Name = "btnAgreCliente"
        btnAgreCliente.Size = New Size(138, 73)
        btnAgreCliente.TabIndex = 55
        btnAgreCliente.Text = "Agregar Cliente"
        btnAgreCliente.TextAlign = ContentAlignment.BottomCenter
        btnAgreCliente.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(1114, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 56
        ' 
        ' FormClientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(87), CByte(107))
        ClientSize = New Size(1582, 580)
        Controls.Add(Label1)
        Controls.Add(btnAgreCliente)
        Controls.Add(TextBox1)
        Controls.Add(dgvClientes)
        Controls.Add(btnBuscar)
        Controls.Add(lblBienvenido)
        Controls.Add(panelAdmin)
        Name = "FormClientes"
        Text = "FormClientes"
        panelAdmin.ResumeLayout(False)
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents panelAdmin As Panel
    Friend WithEvents btnNueSolictud As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnSolicitudes As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnAgreCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colApellido As DataGridViewTextBoxColumn
    Friend WithEvents colDirigido As DataGridViewTextBoxColumn
    Friend WithEvents colDireccion As DataGridViewTextBoxColumn
    Friend WithEvents colCargo As DataGridViewTextBoxColumn
    Friend WithEvents colCorreo As DataGridViewTextBoxColumn
    Friend WithEvents colTelCliente As DataGridViewTextBoxColumn
    Friend WithEvents colTelEmpresa As DataGridViewTextBoxColumn
    Friend WithEvents colActividad As DataGridViewTextBoxColumn
End Class
