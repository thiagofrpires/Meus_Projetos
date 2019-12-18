Imports System.Runtime.InteropServices
Imports WMPLib

Public Class frmmenu
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub

    Private Sub btnfechar_Click(sender As Object, e As EventArgs) Handles btnfechar.Click
        If MsgBox("Tem certeza que irá sair do Alpha Tech Solutions System?", vbQuestion + vbYesNo, "Está de Saída?") = vbYes Then
            Application.Exit()
        End If


    End Sub




    Private Sub btnmin_Click_1(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnrest_Click(sender As Object, e As EventArgs) Handles btnrest.Click
        btnrest.Visible = False
        btnmax.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnmax_Click(sender As Object, e As EventArgs) Handles btnmax.Click
        btnmax.Visible = False
        btnrest.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Paneltopo_MouseMove(sender As Object, e As MouseEventArgs) Handles Paneltopo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tempocultarmenu_Tick(sender As Object, e As EventArgs) Handles tempocultarmenu.Tick
        If Panelmenu.Width <= 60 Then
            Me.tempocultarmenu.Enabled = False
        Else
            Me.Panelmenu.Width = Panelmenu.Width - 20

        End If
    End Sub

    Private Sub tempomostrarmenu_Tick(sender As Object, e As EventArgs) Handles tempomostrarmenu.Tick
        If Panelmenu.Width >= 220 Then
            Me.tempocultarmenu.Enabled = False
        Else
            Me.Panelmenu.Width = Panelmenu.Width + 20
        End If
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If Panelmenu.Width = 220 Then
            tempocultarmenu.Enabled = True
        ElseIf Panelmenu.Width = 60 Then
            tempomostrarmenu.Enabled = True
        End If
    End Sub

    Private Sub AbrirFormEmPanel(ByVal FormDentro As Object)
        If Me.Panelconteudo.Controls.Count > 0 Then
            Me.Panelconteudo.Controls.RemoveAt(0)
        End If
        Dim fd As Form = TryCast(FormDentro, Form)
            fd.TopLevel = False
            fd.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            fd.Dock = DockStyle.Fill
            Me.Panelconteudo.Controls.Add(fd)
            Me.Panelconteudo.Tag = fd
            fd.Show()

    End Sub

    Private Sub btnajuda_Click(sender As Object, e As EventArgs) Handles btnajuda.Click
        AbrirFormEmPanel(New ajuda)
        If MsgBox("Dúvidas sobre o Sistema? Confira o nosso manual em PDF!", vbInformation + vbOK, "Suporte Alpha Tech Solutions") = vbOK Then

        End If
    End Sub

    Private Sub btncaixa_Click(sender As Object, e As EventArgs) Handles btncaixa.Click
        AbrirFormEmPanel(New caixa)
    End Sub

    Private Sub btnestoque_Click(sender As Object, e As EventArgs) Handles btnestoque.Click
        AbrirFormEmPanel(New estoque)
    End Sub

    Private Sub btnvendas_Click(sender As Object, e As EventArgs) Handles btnvendas.Click
        AbrirFormEmPanel(New vendas)
    End Sub

    Private Sub btnfinancas_Click(sender As Object, e As EventArgs) Handles btnfinancas.Click
        AbrirFormEmPanel(New financas)
    End Sub

    Private Sub btnfarmaceutico_Click(sender As Object, e As EventArgs) Handles btnfarmaceutico.Click
        AbrirFormEmPanel(New farmaceutico)
    End Sub

    Private Sub btnpagamento_Click(sender As Object, e As EventArgs) Handles btnpagamento.Click
        AbrirFormEmPanel(New pagamentos)
    End Sub

    Private Sub btnsuporte_Click(sender As Object, e As EventArgs) Handles btnsuporte.Click
        AbrirFormEmPanel(New suporte)
        If MsgBox("Telefone: (21)3876-7508 Marque uma reunião conosco!", vbInformation + vbOK, "Suporte Alpha Tech Solutions") = vbOK Then

        End If
    End Sub

    Private Sub data_Tick(sender As Object, e As EventArgs) Handles hora.Tick
        hora_atual.Text = TimeString
    End Sub

    Private Sub frmmenu_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data.Text = Today
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If MsgBox("Deseja sair do Alpha Tech Solutions System?", vbQuestion + vbYesNo, "Está de Saída?") = vbYes Then
            Application.Exit()

        End If
    End Sub
End Class

