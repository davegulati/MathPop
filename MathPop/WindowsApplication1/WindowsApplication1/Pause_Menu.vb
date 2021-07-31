Public Class Pause_Menu

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        'This is the code for displaying a red 'Quit' button on mouse-hover.
        PictureBox2.Image = My.Resources.Resume_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        'This is the code for displaying a blue 'Quit' button on mouse-leave.
        PictureBox2.Image = My.Resources.Resume_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        'This is the code for displaying a red 'Quit' button on mouse-hover.
        PictureBox3.Image = My.Resources.Menu_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        'This is the code for displaying a blue 'Quit' button on mouse-leave.
        PictureBox3.Image = My.Resources.Menu_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        'This is the code for displaying a red 'Quit' button on mouse-hover.
        PictureBox4.Image = My.Resources.Quit_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        'This is the code for displaying a blue 'Quit' button on mouse-leave.
        PictureBox4.Image = My.Resources.Quit_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'The following code makes 'Timer2' continue counting down and it hides the 'Pause_Menu'.
        If Game_Screen.Label3.Visible = True Then
            Game_Screen.Timer1.Start()
        Else
            Game_Screen.Timer2.Start()
        End If
        Me.Close()
        'Code ends here.
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'Asks the user if they really want to quit through a message box. If the user picks yes, the game ends.
        Dim Quitbox As MsgBoxResult
        Quitbox = MsgBox("Are you sure you want to quit?" & vbCrLf & "Your current progress will be lost!", MsgBoxStyle.YesNo, "Quit MathPop?")
        If Quitbox = MsgBoxResult.Yes Then
            End
        Else
        End If
        'Code ends here.
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ''Asks the user if they really want to exit to the main menu through a message box. If the user picks yes, the game is stopped and the main menu is shown..
        Dim MenuBox As MsgBoxResult
        MenuBox = MsgBox("Are you sure you want to return to the main menu?" & vbCrLf & "Your current progress will be lost!", MsgBoxStyle.YesNo, "Return to main menu?")
        If MenuBox = MsgBoxResult.Yes Then
            Game_Screen.Close()
            Me.Close()
            Menu_Screen.Refresh()
            Menu_Screen.Show()
        Else
        End If
        'Code ends here.
    End Sub
End Class
