Imports WMPLib

Public Class Frmlogin



    Private x, y As Integer
    Private newpoint As Point



    Private Sub btfechar_Click(sender As Object, e As EventArgs) Handles btfechar.Click
        Application.Exit()
    End Sub

    Private Sub btminimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btminimizar_Click_1(sender As Object, e As EventArgs) Handles btminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textusuario.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click

        Me.Hide()
        Dim FormSplash As New FormSplash()
        FormSplash.ShowDialog()

        Dim Play As New WindowsMediaPlayer
        Play.URL = "C:\Users\Thiago Pires\Desktop\Documentos Thiago\Trabalho de Engenharia de Software\Sistema de Farmácia\icone\longhorn.mp3"
        Play.controls.play()

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class
