<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.Paneltopo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnrest = New System.Windows.Forms.Button()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.btnmax = New System.Windows.Forms.Button()
        Me.btnfechar = New System.Windows.Forms.Button()
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.Label()
        Me.hora_atual = New System.Windows.Forms.Label()
        Me.btnsuporte = New System.Windows.Forms.Button()
        Me.btnajuda = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnpagamento = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnfarmaceutico = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnfinancas = New System.Windows.Forms.Button()
        Me.btnvendas = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnestoque = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncaixa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnmenu = New System.Windows.Forms.PictureBox()
        Me.Panelconteudo = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tempocultarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.tempomostrarmenu = New System.Windows.Forms.Timer(Me.components)
        Me.hora = New System.Windows.Forms.Timer(Me.components)
        Me.Paneltopo.SuspendLayout()
        Me.Panelmenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelconteudo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Paneltopo
        '
        Me.Paneltopo.BackColor = System.Drawing.Color.Red
        Me.Paneltopo.Controls.Add(Me.Label2)
        Me.Paneltopo.Controls.Add(Me.btnrest)
        Me.Paneltopo.Controls.Add(Me.btnmin)
        Me.Paneltopo.Controls.Add(Me.btnmax)
        Me.Paneltopo.Controls.Add(Me.btnfechar)
        Me.Paneltopo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Paneltopo.Location = New System.Drawing.Point(0, 0)
        Me.Paneltopo.Name = "Paneltopo"
        Me.Paneltopo.Size = New System.Drawing.Size(1100, 40)
        Me.Paneltopo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(453, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tela de Menu Irmãos Pharma"
        '
        'btnrest
        '
        Me.btnrest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnrest.BackgroundImage = CType(resources.GetObject("btnrest.BackgroundImage"), System.Drawing.Image)
        Me.btnrest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrest.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnrest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnrest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrest.Location = New System.Drawing.Point(1019, 0)
        Me.btnrest.Name = "btnrest"
        Me.btnrest.Size = New System.Drawing.Size(40, 40)
        Me.btnrest.TabIndex = 3
        Me.btnrest.UseVisualStyleBackColor = True
        Me.btnrest.Visible = False
        '
        'btnmin
        '
        Me.btnmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmin.BackgroundImage = CType(resources.GetObject("btnmin.BackgroundImage"), System.Drawing.Image)
        Me.btnmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmin.Location = New System.Drawing.Point(979, 0)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(40, 40)
        Me.btnmin.TabIndex = 2
        Me.btnmin.UseVisualStyleBackColor = True
        '
        'btnmax
        '
        Me.btnmax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmax.BackgroundImage = CType(resources.GetObject("btnmax.BackgroundImage"), System.Drawing.Image)
        Me.btnmax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmax.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmax.Location = New System.Drawing.Point(1019, 0)
        Me.btnmax.Name = "btnmax"
        Me.btnmax.Size = New System.Drawing.Size(40, 40)
        Me.btnmax.TabIndex = 1
        Me.btnmax.UseVisualStyleBackColor = True
        '
        'btnfechar
        '
        Me.btnfechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfechar.BackgroundImage = CType(resources.GetObject("btnfechar.BackgroundImage"), System.Drawing.Image)
        Me.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfechar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfechar.Location = New System.Drawing.Point(1059, 0)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Size = New System.Drawing.Size(40, 40)
        Me.btnfechar.TabIndex = 0
        Me.btnfechar.UseVisualStyleBackColor = True
        '
        'Panelmenu
        '
        Me.Panelmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panelmenu.Controls.Add(Me.Label3)
        Me.Panelmenu.Controls.Add(Me.data)
        Me.Panelmenu.Controls.Add(Me.hora_atual)
        Me.Panelmenu.Controls.Add(Me.btnsuporte)
        Me.Panelmenu.Controls.Add(Me.btnajuda)
        Me.Panelmenu.Controls.Add(Me.btnlogout)
        Me.Panelmenu.Controls.Add(Me.Panel6)
        Me.Panelmenu.Controls.Add(Me.Panel5)
        Me.Panelmenu.Controls.Add(Me.btnpagamento)
        Me.Panelmenu.Controls.Add(Me.Panel4)
        Me.Panelmenu.Controls.Add(Me.btnfarmaceutico)
        Me.Panelmenu.Controls.Add(Me.Panel3)
        Me.Panelmenu.Controls.Add(Me.btnfinancas)
        Me.Panelmenu.Controls.Add(Me.btnvendas)
        Me.Panelmenu.Controls.Add(Me.Panel2)
        Me.Panelmenu.Controls.Add(Me.btnestoque)
        Me.Panelmenu.Controls.Add(Me.Panel1)
        Me.Panelmenu.Controls.Add(Me.btncaixa)
        Me.Panelmenu.Controls.Add(Me.Label1)
        Me.Panelmenu.Controls.Add(Me.PictureBox1)
        Me.Panelmenu.Controls.Add(Me.btnmenu)
        Me.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelmenu.Location = New System.Drawing.Point(0, 40)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(220, 540)
        Me.Panelmenu.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(77, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Acesse os guias abaixo!"
        '
        'data
        '
        Me.data.AutoSize = True
        Me.data.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.ForeColor = System.Drawing.Color.White
        Me.data.Location = New System.Drawing.Point(79, 426)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(32, 15)
        Me.data.TabIndex = 0
        Me.data.Text = "Data"
        '
        'hora_atual
        '
        Me.hora_atual.AutoSize = True
        Me.hora_atual.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hora_atual.ForeColor = System.Drawing.Color.White
        Me.hora_atual.Location = New System.Drawing.Point(80, 447)
        Me.hora_atual.Name = "hora_atual"
        Me.hora_atual.Size = New System.Drawing.Size(39, 15)
        Me.hora_atual.TabIndex = 0
        Me.hora_atual.Text = "Horas"
        '
        'btnsuporte
        '
        Me.btnsuporte.BackgroundImage = CType(resources.GetObject("btnsuporte.BackgroundImage"), System.Drawing.Image)
        Me.btnsuporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsuporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsuporte.FlatAppearance.BorderSize = 0
        Me.btnsuporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnsuporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnsuporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsuporte.Location = New System.Drawing.Point(140, 468)
        Me.btnsuporte.Name = "btnsuporte"
        Me.btnsuporte.Size = New System.Drawing.Size(64, 69)
        Me.btnsuporte.TabIndex = 7
        Me.btnsuporte.UseVisualStyleBackColor = True
        '
        'btnajuda
        '
        Me.btnajuda.BackgroundImage = CType(resources.GetObject("btnajuda.BackgroundImage"), System.Drawing.Image)
        Me.btnajuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnajuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnajuda.FlatAppearance.BorderSize = 0
        Me.btnajuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnajuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnajuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnajuda.Location = New System.Drawing.Point(70, 468)
        Me.btnajuda.Name = "btnajuda"
        Me.btnajuda.Size = New System.Drawing.Size(64, 69)
        Me.btnajuda.TabIndex = 6
        Me.btnajuda.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.BackgroundImage = CType(resources.GetObject("btnlogout.BackgroundImage"), System.Drawing.Image)
        Me.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Location = New System.Drawing.Point(0, 470)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(64, 69)
        Me.btnlogout.TabIndex = 0
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(0, 368)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(0, 319)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 1
        '
        'btnpagamento
        '
        Me.btnpagamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpagamento.FlatAppearance.BorderSize = 0
        Me.btnpagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnpagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnpagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpagamento.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpagamento.ForeColor = System.Drawing.Color.White
        Me.btnpagamento.Image = CType(resources.GetObject("btnpagamento.Image"), System.Drawing.Image)
        Me.btnpagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpagamento.Location = New System.Drawing.Point(-1, 365)
        Me.btnpagamento.Name = "btnpagamento"
        Me.btnpagamento.Size = New System.Drawing.Size(220, 50)
        Me.btnpagamento.TabIndex = 2
        Me.btnpagamento.Text = "    Pagamentos"
        Me.btnpagamento.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 269)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 1
        '
        'btnfarmaceutico
        '
        Me.btnfarmaceutico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfarmaceutico.FlatAppearance.BorderSize = 0
        Me.btnfarmaceutico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnfarmaceutico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnfarmaceutico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfarmaceutico.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfarmaceutico.ForeColor = System.Drawing.Color.White
        Me.btnfarmaceutico.Image = CType(resources.GetObject("btnfarmaceutico.Image"), System.Drawing.Image)
        Me.btnfarmaceutico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfarmaceutico.Location = New System.Drawing.Point(0, 320)
        Me.btnfarmaceutico.Name = "btnfarmaceutico"
        Me.btnfarmaceutico.Size = New System.Drawing.Size(220, 50)
        Me.btnfarmaceutico.TabIndex = 2
        Me.btnfarmaceutico.Text = "      Farmacêutico"
        Me.btnfarmaceutico.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 219)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 4
        '
        'btnfinancas
        '
        Me.btnfinancas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfinancas.FlatAppearance.BorderSize = 0
        Me.btnfinancas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnfinancas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnfinancas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfinancas.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinancas.ForeColor = System.Drawing.Color.White
        Me.btnfinancas.Image = CType(resources.GetObject("btnfinancas.Image"), System.Drawing.Image)
        Me.btnfinancas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfinancas.Location = New System.Drawing.Point(0, 270)
        Me.btnfinancas.Name = "btnfinancas"
        Me.btnfinancas.Size = New System.Drawing.Size(220, 50)
        Me.btnfinancas.TabIndex = 2
        Me.btnfinancas.Text = "   Finanças"
        Me.btnfinancas.UseVisualStyleBackColor = True
        '
        'btnvendas
        '
        Me.btnvendas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnvendas.FlatAppearance.BorderSize = 0
        Me.btnvendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnvendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnvendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvendas.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvendas.ForeColor = System.Drawing.Color.White
        Me.btnvendas.Image = CType(resources.GetObject("btnvendas.Image"), System.Drawing.Image)
        Me.btnvendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnvendas.Location = New System.Drawing.Point(0, 219)
        Me.btnvendas.Name = "btnvendas"
        Me.btnvendas.Size = New System.Drawing.Size(220, 50)
        Me.btnvendas.TabIndex = 5
        Me.btnvendas.Text = "   Vendas"
        Me.btnvendas.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 174)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 2
        '
        'btnestoque
        '
        Me.btnestoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnestoque.FlatAppearance.BorderSize = 0
        Me.btnestoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnestoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnestoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnestoque.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnestoque.ForeColor = System.Drawing.Color.White
        Me.btnestoque.Image = CType(resources.GetObject("btnestoque.Image"), System.Drawing.Image)
        Me.btnestoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnestoque.Location = New System.Drawing.Point(0, 174)
        Me.btnestoque.Name = "btnestoque"
        Me.btnestoque.Size = New System.Drawing.Size(220, 50)
        Me.btnestoque.TabIndex = 3
        Me.btnestoque.Text = "   Estoque"
        Me.btnestoque.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 0
        '
        'btncaixa
        '
        Me.btncaixa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncaixa.FlatAppearance.BorderSize = 0
        Me.btncaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btncaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btncaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncaixa.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncaixa.ForeColor = System.Drawing.Color.White
        Me.btncaixa.Image = CType(resources.GetObject("btncaixa.Image"), System.Drawing.Image)
        Me.btncaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncaixa.Location = New System.Drawing.Point(0, 123)
        Me.btncaixa.Name = "btncaixa"
        Me.btncaixa.Size = New System.Drawing.Size(220, 50)
        Me.btncaixa.TabIndex = 0
        Me.btncaixa.Text = "  Caixa"
        Me.btncaixa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(70, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Irmãos Pharma"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnmenu
        '
        Me.btnmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmenu.Image = CType(resources.GetObject("btnmenu.Image"), System.Drawing.Image)
        Me.btnmenu.Location = New System.Drawing.Point(171, 2)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(45, 38)
        Me.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmenu.TabIndex = 0
        Me.btnmenu.TabStop = False
        '
        'Panelconteudo
        '
        Me.Panelconteudo.Controls.Add(Me.PictureBox2)
        Me.Panelconteudo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelconteudo.Location = New System.Drawing.Point(220, 40)
        Me.Panelconteudo.Name = "Panelconteudo"
        Me.Panelconteudo.Size = New System.Drawing.Size(880, 540)
        Me.Panelconteudo.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(120, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(594, 456)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'tempocultarmenu
        '
        '
        'tempomostrarmenu
        '
        '
        'hora
        '
        Me.hora.Enabled = True
        Me.hora.Interval = 1000
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.Panelconteudo)
        Me.Controls.Add(Me.Panelmenu)
        Me.Controls.Add(Me.Paneltopo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Paneltopo.ResumeLayout(False)
        Me.Paneltopo.PerformLayout()
        Me.Panelmenu.ResumeLayout(False)
        Me.Panelmenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelconteudo.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Paneltopo As Panel
    Friend WithEvents btnfechar As Button
    Friend WithEvents Panelmenu As Panel
    Friend WithEvents Panelconteudo As Panel
    Friend WithEvents btnmin As Button
    Friend WithEvents btnmax As Button
    Friend WithEvents btnrest As Button
    Friend WithEvents btnmenu As PictureBox
    Friend WithEvents tempocultarmenu As Timer
    Friend WithEvents tempomostrarmenu As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btncaixa As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnestoque As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnpagamento As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnfarmaceutico As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnfinancas As Button
    Friend WithEvents btnvendas As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnsuporte As Button
    Friend WithEvents btnajuda As Button
    Friend WithEvents hora_atual As Label
    Friend WithEvents hora As Timer
    Friend WithEvents data As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
