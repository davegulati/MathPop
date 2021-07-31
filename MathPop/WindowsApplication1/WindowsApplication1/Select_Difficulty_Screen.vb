Public Class Select_Difficulty_Screen

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        'This is the code for displaying a red 'Easy' button on mouse-hover.
        PictureBox3.Image = My.Resources.Easy_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        'This is the code for displaying a blue 'Easy' button on mouse-leave.
        PictureBox3.Image = My.Resources.Easy_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        'This is the code for displaying a red 'Medium' button on mouse-hover.
        PictureBox4.Image = My.Resources.Medium_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        'This is the code for displaying a blue 'Medium' button on mouse-leave.
        PictureBox4.Image = My.Resources.Medium_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        'This is the code for displaying a red 'Hard' button on mouse-hover.
        PictureBox5.Image = My.Resources.Hard_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        'This is the code for displaying a blue 'Hard' button on mouse-leave.
        PictureBox5.Image = My.Resources.Hard_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseHover
        'This is the code for displaying a red 'Back' button on mouse-hover.
        PictureBox6.Image = My.Resources.Back_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        'This is the code for displaying a blue 'Back' button on mouse-leave.
        PictureBox6.Image = My.Resources.Back_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Dim Quitbox As MsgBoxResult
        Quitbox = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Quit MathPop?")
        If Quitbox = MsgBoxResult.Yes Then
            End
        Else
        End If
    End Sub

    Private Sub PictureBox7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseHover
        'This is the code for displaying a red 'Quit' button on mouse-hover.
        PictureBox7.Image = My.Resources.Quit_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        'This is the code for displaying a blue 'Quit' button on mouse-leave.
        PictureBox7.Image = My.Resources.Quit_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        'The following code hides the 'Select difficulty' screen and shows the 'Menu Screen'
        Me.Close()
        Select_Operation_Screen.Refresh()
        Select_Operation_Screen.Show()
        'Code ends here.
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'The following code hides the 'Select_Difficulty' and shows the 'Game' screen
        Me.Close()
        Game_Screen.Refresh()
        Game_Screen.Show()
        'Code ends here.

        GlobalVariables.GameDifficulty = 1 'Sets difficulty to easy
        Results.Label4.Text = "Easy"

        'If GlobalVariables.Difficulty = 1 (easy), then it generates numbers between 1 and 9.
        If GlobalVariables.GameDifficulty = 1 Then
            Dim rn As New Random
            Game_Screen.Label9.Text = (rn.Next(1, 9))
            Game_Screen.Label7.Text = (rn.Next(1, 9))
            'Code ends here.

            'If GlobalVariables.Difficulty = 2 (medium), then it generates numbers between 10 and 98.
        ElseIf GlobalVariables.GameDifficulty = 2 Then
            Dim rn As New Random
            Game_Screen.Label9.Text = (rn.Next(10, 98))
            Game_Screen.Label7.Text = (rn.Next(10, 98))
            'Code ends here.

            'If GlobalVariables.Difficulty = 3 (hard), then it generates numbers between 99 and 900.
        ElseIf GlobalVariables.GameDifficulty = 3 Then
            Dim rn As New Random
            Game_Screen.Label9.Text = (rn.Next(99, 900))
            Game_Screen.Label7.Text = (rn.Next(99, 900))
            'Code ends here.
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'The following code hides the 'Select_Difficulty' and shows the 'Game' screen
        Me.Close()
        Game_Screen.Refresh()
        Game_Screen.Show()
        'Code ends here.
        GlobalVariables.GameDifficulty = 2 'Sets difficulty to medium
        Results.Label4.Text = "Medium"

        'If GlobalVariables.Difficulty = 1 (easy), then it generates numbers between 1 and 9.
        If GlobalVariables.GameDifficulty = 1 Then
            Dim rn As New Random
            Game_Screen.Label9.Text = (rn.Next(1, 9))
            Game_Screen.Label7.Text = (rn.Next(1, 9))
            'Code ends here.

            'If GlobalVariables.Difficulty = 2 (medium), then it generates numbers between 10 and 98.
        ElseIf GlobalVariables.GameDifficulty = 2 Then
            Dim rn As New Random
            Game_Screen.Label9.Text = (rn.Next(10, 98))
            Game_Screen.Label7.Text = (rn.Next(10, 98))
            'Code ends here.

            'If GlobalVariables.Difficulty = 3 (hard), then it generates numbers between 99 and 900.
        ElseIf GlobalVariables.GameDifficulty = 3 Then
            Dim rn As New Random
            Game_Screen.Label9.Text = (rn.Next(99, 900))
            Game_Screen.Label7.Text = (rn.Next(99, 900))
            'Code ends here.
        End If
    End Sub

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        'The following code hides the 'Select_Difficulty' and shows the 'Game' screen
        Me.Close()
        Game_Screen.Refresh()
        Game_Screen.Show()
        'Code ends here.
        GlobalVariables.GameDifficulty = 1 'Sets difficulty to hard
        Results.Label4.Text = "Hard"

        'If GlobalVariables.Difficulty = 1 (easy), then it generates numbers between 1 and 9.
        If GlobalVariables.GameDifficulty = 1 Then
            Dim rn As New Random
            Game_Screen.Label9.Text = (rn.Next(1, 9))
            Game_Screen.Label7.Text = (rn.Next(1, 9))
            'Code ends here.

            'If GlobalVariables.Difficulty = 2 (medium), then it generates numbers between 10 and 98.
        ElseIf GlobalVariables.GameDifficulty = 2 Then
            Dim rn As New Random
            Game_Screen.Label9.Text = (rn.Next(10, 98))
            Game_Screen.Label7.Text = (rn.Next(10, 98))
            'Code ends here.

            'If GlobalVariables.Difficulty = 3 (hard), then it generates numbers between 99 and 900.
        ElseIf GlobalVariables.GameDifficulty = 3 Then
            Dim rn As New Random
            Game_Screen.Label9.Text = (rn.Next(99, 900))
            Game_Screen.Label7.Text = (rn.Next(99, 900))
            'Code ends here.
        End If
    End Sub
End Class