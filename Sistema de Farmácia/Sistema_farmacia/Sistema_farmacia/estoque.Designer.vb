<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(estoque))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnprodutos = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btntransportadoras = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnpedidosachegar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btncontagem = New System.Windows.Forms.Label()
        Me.btnperdas = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnpedidos = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(295, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Opções de Estoque"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(689, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Versão Demonstrativa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(728, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ver. 0.1"
        '
        'btnprodutos
        '
        Me.btnprodutos.BackColor = System.Drawing.Color.Firebrick
        Me.btnprodutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnprodutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprodutos.Image = CType(resources.GetObject("btnprodutos.Image"), System.Drawing.Image)
        Me.btnprodutos.Location = New System.Drawing.Point(158, 72)
        Me.btnprodutos.Name = "btnprodutos"
        Me.btnprodutos.Size = New System.Drawing.Size(130, 130)
        Me.btnprodutos.TabIndex = 16
        Me.btnprodutos.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Firebrick
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(162, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 17)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Cadastrar Produtos"
        '
        'btntransportadoras
        '
        Me.btntransportadoras.BackColor = System.Drawing.Color.Firebrick
        Me.btntransportadoras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btntransportadoras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntransportadoras.Image = CType(resources.GetObject("btntransportadoras.Image"), System.Drawing.Image)
        Me.btntransportadoras.Location = New System.Drawing.Point(348, 72)
        Me.btntransportadoras.Name = "btntransportadoras"
        Me.btntransportadoras.Size = New System.Drawing.Size(130, 130)
        Me.btntransportadoras.TabIndex = 35
        Me.btntransportadoras.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Firebrick
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(355, 173)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 19)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Transportadoras"
        '
        'btnpedidosachegar
        '
        Me.btnpedidosachegar.BackColor = System.Drawing.Color.Firebrick
        Me.btnpedidosachegar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnpedidosachegar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpedidosachegar.Image = CType(resources.GetObject("btnpedidosachegar.Image"), System.Drawing.Image)
        Me.btnpedidosachegar.Location = New System.Drawing.Point(541, 72)
        Me.btnpedidosachegar.Name = "btnpedidosachegar"
        Me.btnpedidosachegar.Size = New System.Drawing.Size(130, 130)
        Me.btnpedidosachegar.TabIndex = 37
        Me.btnpedidosachegar.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnpedidosachegar.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Firebrick
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(547, 174)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 19)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Pedidos a Chegar"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Firebrick
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(541, 235)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(130, 130)
        Me.Button9.TabIndex = 39
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btncontagem
        '
        Me.btncontagem.AutoSize = True
        Me.btncontagem.BackColor = System.Drawing.Color.Firebrick
        Me.btncontagem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontagem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncontagem.Location = New System.Drawing.Point(547, 336)
        Me.btncontagem.Name = "btncontagem"
        Me.btncontagem.Size = New System.Drawing.Size(71, 19)
        Me.btncontagem.TabIndex = 40
        Me.btncontagem.Text = "Contagem"
        '
        'btnperdas
        '
        Me.btnperdas.BackColor = System.Drawing.Color.Firebrick
        Me.btnperdas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnperdas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnperdas.Image = CType(resources.GetObject("btnperdas.Image"), System.Drawing.Image)
        Me.btnperdas.Location = New System.Drawing.Point(158, 235)
        Me.btnperdas.Name = "btnperdas"
        Me.btnperdas.Size = New System.Drawing.Size(130, 130)
        Me.btnperdas.TabIndex = 41
        Me.btnperdas.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Firebrick
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Location = New System.Drawing.Point(169, 336)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 19)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Perdas"
        '
        'btnpedidos
        '
        Me.btnpedidos.BackColor = System.Drawing.Color.Firebrick
        Me.btnpedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnpedidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpedidos.Image = CType(resources.GetObject("btnpedidos.Image"), System.Drawing.Image)
        Me.btnpedidos.Location = New System.Drawing.Point(348, 235)
        Me.btnpedidos.Name = "btnpedidos"
        Me.btnpedidos.Size = New System.Drawing.Size(130, 130)
        Me.btnpedidos.TabIndex = 47
        Me.btnpedidos.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Firebrick
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(362, 336)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 19)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Sugerir Pedidos"
        '
        'estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnpedidos)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.btnperdas)
        Me.Controls.Add(Me.btncontagem)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnpedidosachegar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btntransportadoras)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnprodutos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "estoque"
        Me.Text = "estoque"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnprodutos As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents btntransportadoras As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents btnpedidosachegar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents btncontagem As Label
    Friend WithEvents btnperdas As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents btnpedidos As Button
    Friend WithEvents Label16 As Label
End Class
