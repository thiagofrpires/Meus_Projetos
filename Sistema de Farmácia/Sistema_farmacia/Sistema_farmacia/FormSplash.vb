Public Class FormSplash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        porctxt.Text = ProgressBar1.Value.ToString()
        If Me.Opacity < 1 Then
            Me.Opacity += 0.1
        End If

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub FormSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
            frmmenu.Show()
        End If
    End Sub

    Private Sub porctxt_Click(sender As Object, e As EventArgs) Handles porctxt.Click

    End Sub

    Private Sub btnfechar_Click(sender As Object, e As EventArgs) Handles btnfechar.Click
        Me.Close()

    End Sub

End Class