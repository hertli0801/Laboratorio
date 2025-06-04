<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevaSolicitud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNuevaSolicitud))
        Label10 = New Label()
        Label9 = New Label()
        btnEntrar = New Button()
        Label4 = New Label()
        Label1 = New Label()
        lblBienvenido = New Label()
        panelAdmin = New Panel()
        btnSolicitudes = New Button()
        btnCerrarSesion = New Button()
        btnSolicitud = New Button()
        btnClientes = New Button()
        btnMin = New Button()
        btnMax = New Button()
        btnCerrar = New Button()
        cbxCategoria = New ComboBox()
        CheckedListBox1 = New CheckedListBox()
        CheckedListBox2 = New CheckedListBox()
        CheckedListBox3 = New CheckedListBox()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        panelAdmin.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Silver
        Label10.Location = New Point(666, 117)
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
        Label9.Location = New Point(474, 117)
        Label9.Name = "Label9"
        Label9.Size = New Size(186, 26)
        Label9.TabIndex = 51
        Label9.Text = "Folio de solicitud:"
        ' 
        ' btnEntrar
        ' 
        btnEntrar.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnEntrar.Cursor = Cursors.Hand
        btnEntrar.FlatAppearance.BorderSize = 0
        btnEntrar.FlatStyle = FlatStyle.Flat
        btnEntrar.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEntrar.ForeColor = Color.White
        btnEntrar.Location = New Point(717, 983)
        btnEntrar.Name = "btnEntrar"
        btnEntrar.Size = New Size(116, 29)
        btnEntrar.TabIndex = 50
        btnEntrar.Text = "Generar"
        btnEntrar.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(513, 535)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 26)
        Label4.TabIndex = 40
        Label4.Text = "Tipo de analísis:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(474, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 26)
        Label1.TabIndex = 34
        Label1.Text = "Nombre del cliente:"
        ' 
        ' lblBienvenido
        ' 
        lblBienvenido.Anchor = AnchorStyles.None
        lblBienvenido.AutoSize = True
        lblBienvenido.Font = New Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBienvenido.ForeColor = Color.White
        lblBienvenido.Location = New Point(730, 20)
        lblBienvenido.Name = "lblBienvenido"
        lblBienvenido.Size = New Size(249, 39)
        lblBienvenido.TabIndex = 33
        lblBienvenido.Text = "Nueva Solicitud"
        ' 
        ' panelAdmin
        ' 
        panelAdmin.AutoSizeMode = AutoSizeMode.GrowAndShrink
        panelAdmin.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        panelAdmin.BorderStyle = BorderStyle.FixedSingle
        panelAdmin.Controls.Add(btnSolicitudes)
        panelAdmin.Controls.Add(btnCerrarSesion)
        panelAdmin.Controls.Add(btnSolicitud)
        panelAdmin.Controls.Add(btnClientes)
        panelAdmin.Controls.Add(btnMin)
        panelAdmin.Controls.Add(btnMax)
        panelAdmin.Controls.Add(btnCerrar)
        panelAdmin.Cursor = Cursors.Hand
        panelAdmin.Dock = DockStyle.Left
        panelAdmin.Location = New Point(0, 0)
        panelAdmin.Name = "panelAdmin"
        panelAdmin.Size = New Size(243, 1043)
        panelAdmin.TabIndex = 32
        ' 
        ' btnSolicitudes
        ' 
        btnSolicitudes.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnSolicitudes.Cursor = Cursors.Hand
        btnSolicitudes.FlatAppearance.BorderSize = 0
        btnSolicitudes.FlatStyle = FlatStyle.Flat
        btnSolicitudes.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSolicitudes.ForeColor = Color.White
        btnSolicitudes.Location = New Point(62, 142)
        btnSolicitudes.Name = "btnSolicitudes"
        btnSolicitudes.Size = New Size(155, 29)
        btnSolicitudes.TabIndex = 14
        btnSolicitudes.Text = "Solicitudes"
        btnSolicitudes.UseVisualStyleBackColor = False
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnCerrarSesion.Cursor = Cursors.Hand
        btnCerrarSesion.FlatAppearance.BorderSize = 0
        btnCerrarSesion.FlatStyle = FlatStyle.Flat
        btnCerrarSesion.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrarSesion.ForeColor = Color.White
        btnCerrarSesion.Location = New Point(48, 497)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(155, 29)
        btnCerrarSesion.TabIndex = 13
        btnCerrarSesion.Text = "Cerrar Sesión"
        btnCerrarSesion.UseVisualStyleBackColor = False
        ' 
        ' btnSolicitud
        ' 
        btnSolicitud.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnSolicitud.Cursor = Cursors.Hand
        btnSolicitud.FlatAppearance.BorderSize = 0
        btnSolicitud.FlatStyle = FlatStyle.Flat
        btnSolicitud.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSolicitud.ForeColor = Color.White
        btnSolicitud.Location = New Point(48, 379)
        btnSolicitud.Name = "btnSolicitud"
        btnSolicitud.Size = New Size(155, 29)
        btnSolicitud.TabIndex = 12
        btnSolicitud.Text = "Nueva Solicitud"
        btnSolicitud.UseVisualStyleBackColor = False
        ' 
        ' btnClientes
        ' 
        btnClientes.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnClientes.Cursor = Cursors.Hand
        btnClientes.FlatAppearance.BorderSize = 0
        btnClientes.FlatStyle = FlatStyle.Flat
        btnClientes.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClientes.ForeColor = Color.White
        btnClientes.Location = New Point(48, 266)
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
        ' cbxCategoria
        ' 
        cbxCategoria.FormattingEnabled = True
        cbxCategoria.Location = New Point(699, 171)
        cbxCategoria.Name = "cbxCategoria"
        cbxCategoria.Size = New Size(217, 28)
        cbxCategoria.TabIndex = 53
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.BackColor = Color.FromArgb(CByte(29), CByte(87), CByte(107))
        CheckedListBox1.BorderStyle = BorderStyle.None
        CheckedListBox1.Font = New Font("Yu Gothic", 10.2F)
        CheckedListBox1.ForeColor = Color.White
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Humedad (alimentos)", "Proteína (alimentos) ", "Cenizas (alimentos) ", "Grasa (alimentos) ", "PH (alimentos) "})
        CheckedListBox1.Location = New Point(379, 602)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(233, 150)
        CheckedListBox1.TabIndex = 57
        ' 
        ' CheckedListBox2
        ' 
        CheckedListBox2.BackColor = Color.FromArgb(CByte(29), CByte(87), CByte(107))
        CheckedListBox2.BorderStyle = BorderStyle.None
        CheckedListBox2.Font = New Font("Yu Gothic", 10.2F)
        CheckedListBox2.ForeColor = Color.White
        CheckedListBox2.FormattingEnabled = True
        CheckedListBox2.Items.AddRange(New Object() {"Dureza (agua potable y purificada) ", "Turbidez (agua potable y purificada)", "Acidez (agua potable y purificada)", "Alcalinidad (agua potable y purificada)", "PH (agua)", "Cloruros (agua potable y purificada)", "Cloro (agua potable y purificada)", "Conductividad (agua potable y purificada)"})
        CheckedListBox2.Location = New Point(654, 602)
        CheckedListBox2.Name = "CheckedListBox2"
        CheckedListBox2.RightToLeft = RightToLeft.No
        CheckedListBox2.Size = New Size(348, 240)
        CheckedListBox2.TabIndex = 58
        ' 
        ' CheckedListBox3
        ' 
        CheckedListBox3.BackColor = Color.FromArgb(CByte(29), CByte(87), CByte(107))
        CheckedListBox3.BorderStyle = BorderStyle.None
        CheckedListBox3.Font = New Font("Yu Gothic", 10.2F)
        CheckedListBox3.ForeColor = Color.White
        CheckedListBox3.FormattingEnabled = True
        CheckedListBox3.Items.AddRange(New Object() {"Determinación de Coliformes en Placa", "Determinación de Coliformes Totales", "Cuenta de Bacterias Aerobias en Placa", "Retencion de Agua (Carne)"})
        CheckedListBox3.Location = New Point(1039, 602)
        CheckedListBox3.Name = "CheckedListBox3"
        CheckedListBox3.Size = New Size(328, 120)
        CheckedListBox3.TabIndex = 59
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(951, 117)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(273, 27)
        DateTimePicker1.TabIndex = 60
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(861, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 26)
        Label2.TabIndex = 61
        Label2.Text = "Fecha:"
        ' 
        ' FormNuevaSolicitud
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(87), CByte(107))
        ClientSize = New Size(1470, 1043)
        Controls.Add(Label2)
        Controls.Add(DateTimePicker1)
        Controls.Add(CheckedListBox3)
        Controls.Add(CheckedListBox2)
        Controls.Add(CheckedListBox1)
        Controls.Add(cbxCategoria)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(btnEntrar)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(lblBienvenido)
        Controls.Add(panelAdmin)
        Name = "FormNuevaSolicitud"
        Text = "FormNuevaSolicitud"
        panelAdmin.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEntrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents panelAdmin As Panel
    Friend WithEvents btnSolicitud As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents cbxCategoria As ComboBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents CheckedListBox3 As CheckedListBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnSolicitudes As Button
End Class
