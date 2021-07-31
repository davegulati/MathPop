Public Class Results

    Private Sub Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fetches data from the Game Screen and displays it through label1, label2 and label 5.
        Label1.Text = Game_Screen.Label4.Text
        Label2.Text = Game_Screen.Label5.Text
        Label5.Text = Game_Screen.Label2.Text
        'Code ends here.
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        'Shows the Save form.
        Save.Show()
        'Code ends here.
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        'This is the code for displaying a red 'Save' button on mouse-hover.
        PictureBox5.Image = My.Resources.Save_red
        'Code ends here.
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        'This is the code for displaying a blue 'Save' button on mouse-leave.
        PictureBox5.Image = My.Resources.Save_blue
        'Code ends here.
    End Sub

    Private Sub PictureBox8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseHover
        'This is the code for displaying a red 'Play Again' button on mouse-hover.
        PictureBox8.Image = My.Resources.Play_again_red
        'Code ends here.
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        'This is the code for displaying a blue 'Play Again' button on mouse-leave.
        PictureBox8.Image = My.Resources.Play_again_blue
        'Code ends here.
    End Sub

    Private Sub PictureBox9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseHover
        'This is the code for displaying a red 'Menu' button on mouse-hover.
        PictureBox9.Image = My.Resources.Menu_red
        'Code ends here.
    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        'This is the code for displaying a blue 'Menu' button on mouse-leave.
        PictureBox9.Image = My.Resources.Menu_blue
        'Code ends here.
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        'Checks if the user has saved their score. If they have, it doesn't prompt them with a message box when they try to leave. If they haven't saved their score, it asks them if they want to save before leaving.
        If GlobalVariables.Save = 1 Then
            Select_Operation_Screen.Show()
            Me.Close()
        Else
            Dim PlayAgain_box As MsgBoxResult
            PlayAgain_box = MsgBox("Are you sure you want to start a new game without saving your current stats?", MsgBoxStyle.YesNo, "MathPop: Start new game?")
            If PlayAgain_box = MsgBoxResult.Yes Then
                Me.Close()
                Game_Screen.Close()
                Select_Operation_Screen.Show()
            Else

            End If
        End If
        'Code ends here.
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        'Checks if the user has saved their score. If they have, it doesn't prompt them with a message box when they try to leave. If they haven't saved their score, it asks them if they want to save before leaving.
        If GlobalVariables.Save = 1 Then
            Menu_Screen.Show()
            Me.Close()
        Else
            Dim PlayAgain_box As MsgBoxResult
            PlayAgain_box = MsgBox("Are you sure you want to exit to the main menu without saving your current stats?", MsgBoxStyle.YesNo, "MathPop: Exit to main menu?")
            If PlayAgain_box = MsgBoxResult.Yes Then
                Me.Close()
                Game_Screen.Close()
                Menu_Screen.Show()
            Else

            End If
        End If
    End Sub
    'Code ends here.
End Class