Public Class Select_Operation_Screen

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        'This is the code for displaying a red 'Addition' button on mouse-hover.
        PictureBox3.Image = My.Resources.Addition_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        'This is the code for displaying a blue 'Addition' button on mouse-leave.
        PictureBox3.Image = My.Resources.Addition_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        'This is the code for displaying a red 'Subtraction' button on mouse-hover.
        PictureBox4.Image = My.Resources.Subtraction_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        'This is the code for displaying a blue 'Subtraction' button on mouse-leave.
        PictureBox4.Image = My.Resources.Subtraction_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        'This is the code for displaying a red 'Multiplication' button on mouse-hover.
        PictureBox5.Image = My.Resources.Multiplication_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        'This is the code for displaying a blue 'Multiplication' button on mouse-leave.
        PictureBox5.Image = My.Resources.Multiplication_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseHover
        'This is the code for displaying a red 'Division' button on mouse-hover.
        PictureBox6.Image = My.Resources.Division_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        'This is the code for displaying a blue 'Division' button on mouse-leave.
        PictureBox6.Image = My.Resources.Division_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        'The following code hides the 'Select operation' screen and shows the 'Menu Screen'
        Me.Close()
        Menu_Screen.Refresh()
        Menu_Screen.Show()
        'Code ends here.
    End Sub

    Private Sub PictureBox7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseHover
        'This is the code for displaying a red 'Back' button on mouse-hover.
        PictureBox7.Image = My.Resources.Back_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        'This is the code for displaying a blue 'Back' button on mouse-leave.
        PictureBox7.Image = My.Resources.Back_blue
        'Blue mouse-leave code ends here.
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
        'This is the code for displaying a red 'Back' button on mouse-hover.
        PictureBox8.Image = My.Resources.Quit_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        'This is the code for displaying a blue 'Back' button on mouse-leave.
        PictureBox8.Image = My.Resources.Quit_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'This code is to hide the 'Menu Screen' form and show the 'Select difficulty' form.
        Me.Close()
        Game_Screen.Label6.Text = "+"
        Results.Label3.Text = "Addition"
        GlobalVariables.GameMode = 1 'Sets gamemode to addition.
        Select_Difficulty_Screen.Show()
        'Code above ends here.
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'This code is to hide the 'Menu Screen' form and show the 'Select difficulty' form.
        Me.Close()
        Game_Screen.Label6.Text = "-"
        Results.Label3.Text = "Subtraction"
        GlobalVariables.GameMode = 2 'Sets Gamemode to subtraction.
        Select_Difficulty_Screen.Show()
        'Code above ends here.
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        'This code is to hide the 'Menu Screen' form and show the 'Select difficulty' form.
        Me.Close()
        Game_Screen.Label6.Text = "x"
        Results.Label3.Text = "Multiplication"
        GlobalVariables.GameMode = 3 'Sets Gamemode to multiplication.
        Select_Difficulty_Screen.Show()
        'Code above ends here.
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        'This code is to hide the 'Menu Screen' form and show the 'Select difficulty' form.
        Me.Close()
        Game_Screen.Label6.Text = "/"
        Results.Label3.Text = "Division"
        GlobalVariables.GameMode = 4 'Sets Gamemode to division.
        Select_Difficulty_Screen.Show()
        'Code above ends here.
    End Sub

    Private Sub Select_Operation_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This code sets GlobalVariables.Save to 0 so that it prompts the user with a message box if they haven't saved their score before exiting. 
        GlobalVariables.Save = 0
    End Sub
End Class