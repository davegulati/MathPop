Public Class Menu_Screen

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        'This is the code for displaying a red 'Start' button on mouse-hover.
        PictureBox2.Image = My.Resources.Start_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        'This is the code for displaying a blue 'Start' button on mouse-leave.
        PictureBox2.Image = My.Resources.Start_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        'This is the code for displaying a red 'Recent Games' button on mouse-hover.
        PictureBox3.Image = My.Resources.Recent_games_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        'This is the code for displaying a blue 'Recent Games' button on mouse-leave.
        PictureBox3.Image = My.Resources.Recent_games_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        'This is the code for displaying a red 'Help' button on mouse-hover.
        PictureBox4.Image = My.Resources.Help_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        'This is the code for displaying a blue 'Help' button on mouse-leave.
        PictureBox4.Image = My.Resources.Help_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        'This is the code for displaying a red 'Quit' button on mouse-hover.
        PictureBox5.Image = My.Resources.Quit_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        'This is the code for displaying a blue 'Quit' button on mouse-leave.
        PictureBox5.Image = My.Resources.Quit_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'This code is to hide the 'Menu Screen' form and show the 'Select difficulty' form.
        Me.Close()
        Select_Operation_Screen.Show()
        'Code above ends here.
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        'Asks the user if they really want to quit through a message box. If the user picks yes, the game ends.
        Dim Quitbox As MsgBoxResult
        Quitbox = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Quit MathPop?")
        If Quitbox = MsgBoxResult.Yes Then
            End
        Else
        End If
        'Code ends here.
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'The following code hides the Menu screen and shows the Recent Games screen.
        Me.Close()
        Recent_games.Show()
        'Code ends here.
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'This code is to hide the 'Menu Screen' form and show the 'Help' form.
        Me.Close()
        Help_Screen.Show()
        'Code above ends here.
    End Sub
End Class
