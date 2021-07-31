Public Class Loading_screen

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'The following code is for the loading bar.
        Timer1.Start()
        'Loading bar code ends here.
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'The following code is for the loading bar. When the loading bar is finished loading, timer1 stops, loading screen is hidden and menu screen is shown to the user.
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Menu_Screen.Show()
            Me.Hide()
            Timer1.Stop()
        End If
        'Loading bar code ends here.
    End Sub
End Class
