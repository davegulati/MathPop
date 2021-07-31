Public Class Game_Screen

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'Pauses both timers and displays the pause menu.
        Timer2.Stop()
        Timer1.Stop()
        Pause_Menu.Show()
        'Code ends here.
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        'This is the code for displaying a red 'Pause' button on mouse-hover.
        PictureBox4.Image = My.Resources.Pause_red
        'Red mouse-hover code ends here.
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        'This is the code for displaying a blue 'Pause' button on mouse-leave.
        PictureBox4.Image = My.Resources.Pause_blue
        'Blue mouse-leave code ends here.
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'The following code will subtract 1 from 'Label3.text' each second. 
        'Once 'Label3.text' is equal to or less than 0, 'PictureBox5' and 'Label3' are hidden and 'Timer2' begins counting down from 60 seconds. This is how the game begins!
        'The questions, button and text field are displayed to the user.
        If Label3.Text >= 1 Then
            Label3.Text = Val(Label3.Text) - 1
        Else
            PictureBox5.Hide()
            Label3.Hide()
            Timer1.Stop()
            Timer1.Enabled = False
            Timer2.Enabled = True
            Timer2.Start()
            Label9.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            TextBox1.Visible = True
            Button1.Visible = True
            'Code ends here.
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label1.Text = Val(Label1.Text) - 1
        If Label1.Text < 0 Then
            Timer2.Stop()
            Timer2.Enabled = False
            Me.Hide()
            Results.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Game_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Refresh() 'Refreshes the Game Screen before loading it.
        Timer1.Enabled = True 'Enables timer1 (the timer that counts backwards from 5).
        Timer2.Enabled = False 'Disables timer2 (the timer that counts backwards from 60).
        Label1.Text = 60 'This is the label that timer2 is displayed on. Once this reaches 0, the game ends.
        Label2.Text = 0 'This is the score counter.
        Label3.Text = 5 'This is the label that timer1 is displayed on. Once this reaches 0, the game begins.
        Label4.Text = 0 'This is the correct questions counter.
        Label5.Text = 0 'This is the correct questions counter.
        PictureBox5.Visible = True
        Label3.Visible = True
        AcceptButton = Button1

        'The following code aligns the equation labels so they fit properly within the window when the game starts.
        Label9.Location = New Point(799, 224)
        Label6.Location = New Point(703, 318)
        Label7.Location = New Point(799, 318)
        Label8.Location = New Point(716, 332)
        TextBox1.Location = New Point(734, 446)
        Button1.Location = New Point(955, 443)
        PictureBox5.Location = New Point(621, 313)
        Label3.Location = New Point(822, 366)
        PictureBox5.Location = New Point(621, 313)
        Label3.Location = New Point(822, 366)
        'Code ends here.
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Rand1 As Integer 'Declares Randomly generated number 1 as Integer.
        Dim Rand2 As Integer 'Declares Randomly generated number 2 as Integer.
        Dim sysans As Integer 'Declares System's Answer as Integer.
        Dim usrans As Integer 'Declares User's answer as Integer.

        'The following code converts the numbers to decimal.
        Rand1 = Convert.ToDecimal(Label9.Text)
        Rand2 = Convert.ToDecimal(Label7.Text)
        'Code ends here.

        'Randomly generated numbers are displayed through label9 and label7. User's answer is converted to a decimal number.
        Label9.Text = Rand1
        Label7.Text = Rand2
        usrans = Convert.ToDecimal(TextBox1.Text)
        'Code ends here.

        'System checks GlobalVariables.Gamemode to see what operation the user selected prior to the game. 1 is addition, 2 is subtraction, 3 is multiplication and 4 is division.
        'After checking, the system adds/subtracts/multiplies/divides the 2 randomly generated numbers and compares it with the user's answer.
        If GlobalVariables.GameMode = 1 Then
            sysans = Rand1 + Rand2
        ElseIf GlobalVariables.GameMode = 2 Then
            sysans = Rand1 - Rand2
        ElseIf GlobalVariables.GameMode = 3 Then
            sysans = Rand1 * Rand2
        ElseIf GlobalVariables.GameMode = 4 Then
            sysans = Rand1 / Rand2
        End If
        'Code ends here.

        'Checks the user's answer and compares it with the system's answer.
        If sysans = usrans Then
            Button1.Text = "Correct!"
            Label2.Text = Label2.Text + 2   'Adds 2 to 'Score'.
            Label4.Text = Label4.Text + 1   'Adds 1 to 'Correct'.
        Else
            Button1.Text = "Incorrect!"
            Label2.Text = Label2.Text - 2   'Subtracts 2 from 'Score'.
            Label5.Text = Label5.Text + 1   'Adds 1 to 'Incorrect'.
        End If

        'If GlobalVariables.Difficulty = 1 (easy), then it generates numbers between 1 and 9.
        If GlobalVariables.GameDifficulty = 1 Then
            Dim rn As New Random
            Label9.Text = (rn.Next(1, 9))
            Label7.Text = (rn.Next(1, 9))
            TextBox1.Text = "" 'Clears the textbox.
            'Code ends here.

            'If GlobalVariables.Difficulty = 2 (medium), then it generates numbers between 10 and 98.
        ElseIf GlobalVariables.GameDifficulty = 2 Then
            Dim rn As New Random
            Label9.Text = (rn.Next(10, 98))
            Label7.Text = (rn.Next(10, 98))
            TextBox1.Text = "" 'Clears the textbox.
            'Code ends here.

            'If GlobalVariables.Difficulty = 3 (hard), then it generates numbers between 99 and 900.
        ElseIf GlobalVariables.GameDifficulty = 3 Then
            Dim rn As New Random
            Label9.Text = (rn.Next(99, 900))
            Label7.Text = (rn.Next(99, 900))
            TextBox1.Text = "" 'Clears the textbox.
            'Code ends here.
        End If
    End Sub
End Class