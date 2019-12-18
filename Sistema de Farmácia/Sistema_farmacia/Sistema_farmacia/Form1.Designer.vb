<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmlogin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmlogin))
        Me.titulo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btfechar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btminimizar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textusuario = New System.Windows.Forms.TextBox()
        Me.textsenha = New System.Windows.Forms.TextBox()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.titulo.SuspendLayout()
        CType(Me.btfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titulo
        '
        Me.titulo.BackColor = System.Drawing.Color.LavenderBlush
        Me.titulo.Controls.Add(Me.Label1)
        Me.titulo.Controls.Add(Me.btfechar)
        Me.titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.titulo.Location = New System.Drawing.Point(0, 0)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(273, 32)
        Me.titulo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tela de Login Irmãos Pharma"
        '
        'btfechar
        '
        Me.btfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btfechar.Image = CType(resources.GetObject("btfechar.Image"), System.Drawing.Image)
        Me.btfechar.Location = New System.Drawing.Point(250, 8)
        Me.btfechar.Name = "btfechar"
        Me.btfechar.Size = New System.Drawing.Size(16, 17)
        Me.btfechar.TabIndex = 1
        Me.btfechar.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LavenderBlush
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 452)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(273, 11)
        Me.Panel2.TabIndex = 0
        '
        'btminimizar
        '
        Me.btminimizar.BackColor = System.Drawing.Color.White
        Me.btminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btminimizar.Image = CType(resources.GetObject("btminimizar.Image"), System.Drawing.Image)
        Me.btminimizar.Location = New System.Drawing.Point(227, 8)
        Me.btminimizar.Name = "btminimizar"
        Me.btminimizar.Size = New System.Drawing.Size(16, 17)
        Me.btminimizar.TabIndex = 1
        Me.btminimizar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(76, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 136)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuário"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(57, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Senha"
        '
        'textusuario
        '
        Me.textusuario.BackColor = System.Drawing.Color.Maroon
        Me.textusuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textusuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textusuario.ForeColor = System.Drawing.Color.White
        Me.textusuario.Location = New System.Drawing.Point(60, 224)
        Me.textusuario.Name = "textusuario"
        Me.textusuario.Size = New System.Drawing.Size(167, 19)
        Me.textusuario.TabIndex = 5
        '
        'textsenha
        '
        Me.textsenha.BackColor = System.Drawing.Color.Maroon
        Me.textsenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textsenha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textsenha.ForeColor = System.Drawing.Color.White
        Me.textsenha.Location = New System.Drawing.Point(60, 282)
        Me.textsenha.Name = "textsenha"
        Me.textsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.textsenha.Size = New System.Drawing.Size(167, 19)
        Me.textsenha.TabIndex = 6
        '
        'btlogin
        '
        Me.btlogin.BackColor = System.Drawing.Color.Maroon
        Me.btlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btlogin.ForeColor = System.Drawing.Color.White
        Me.btlogin.Location = New System.Drawing.Point(95, 318)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(97, 30)
        Me.btlogin.TabIndex = 7
        Me.btlogin.Text = "Login"
        Me.btlogin.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(125, 436)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Alpha Tech Solutions System"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(80, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Problemas?"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(140, 381)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(66, 14)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Contate-nos"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Silver
        '
        'Frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(273, 463)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.textsenha)
        Me.Controls.Add(Me.textusuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btminimizar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.titulo)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frmlogin"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "telalogin"
        Me.titulo.ResumeLayout(False)
        Me.titulo.PerformLayout()
        CType(Me.btfechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titulo As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btfechar As PictureBox
    Friend WithEvents btminimizar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textusuario As TextBox
    Friend WithEvents textsenha As TextBox
    Friend WithEvents btlogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
