<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        txtUsuario = New TextBox()
        txtContrasena = New TextBox()
        btnEntrar = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        lblMensaje = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        Panel1.Cursor = Cursors.Hand
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1100, 40)
        Panel1.TabIndex = 0
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Anchor = AnchorStyles.None
        txtUsuario.Location = New Point(472, 185)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(251, 27)
        txtUsuario.TabIndex = 1
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Anchor = AnchorStyles.None
        txtContrasena.Location = New Point(472, 282)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.PasswordChar = "*"c
        txtContrasena.Size = New Size(251, 27)
        txtContrasena.TabIndex = 2
        ' 
        ' btnEntrar
        ' 
        btnEntrar.BackColor = Color.FromArgb(CByte(10), CByte(174), CByte(140))
        btnEntrar.Cursor = Cursors.Hand
        btnEntrar.FlatAppearance.BorderSize = 0
        btnEntrar.FlatStyle = FlatStyle.Flat
        btnEntrar.Font = New Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEntrar.ForeColor = Color.White
        btnEntrar.Location = New Point(515, 395)
        btnEntrar.Name = "btnEntrar"
        btnEntrar.Size = New Size(116, 29)
        btnEntrar.TabIndex = 3
        btnEntrar.Text = "ENTRAR"
        btnEntrar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(472, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 39)
        Label1.TabIndex = 4
        Label1.Text = "Iniciar Sesión"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(367, 171)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 60)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(364, 261)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(60, 60)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' lblMensaje
        ' 
        lblMensaje.Anchor = AnchorStyles.None
        lblMensaje.AutoSize = True
        lblMensaje.Font = New Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMensaje.ForeColor = Color.White
        lblMensaje.Location = New Point(452, 453)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(0, 39)
        lblMensaje.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(87), CByte(107))
        ClientSize = New Size(1100, 580)
        Controls.Add(lblMensaje)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnEntrar)
        Controls.Add(txtContrasena)
        Controls.Add(txtUsuario)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblMensaje As Label

End Class
