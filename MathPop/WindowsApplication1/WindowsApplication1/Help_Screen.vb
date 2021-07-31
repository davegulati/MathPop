Public Class Help_Screen

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'Closes the Help screen and shows the menu screen.
        Me.Close()
        Menu_Screen.Show()
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        'This is the code for displaying a red 'Back' button on mouse-hover.
        PictureBox4.Image = My.Resources.Back_red
        'Code ends here.
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        'This is the code for displaying a blue 'Back' button on mouse-leave.
        PictureBox4.Image = My.Resources.Back_blue
        'Code ends here.
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        'Asks the user if they really want to quit through a message box. If the user picks yes, the game ends.
        Dim Quitbox As MsgBoxResult
        Quitbox = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Quit MathPop?")
        If Quitbox = MsgBoxResult.Yes Then
            End
        Else
        End If
        'Code ends here.
    End Sub

    Private Sub PictureBox8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseHover
        'This is the code for displaying a red 'Quit' button on mouse-hover.
        PictureBox8.Image = My.Resources.Quit_red
        'Code ends here.
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        'This is the code for displaying a blue 'Quit' button on mouse-leave.
        PictureBox8.Image = My.Resources.Quit_blue
        'Code ends here.
    End Sub
End Class