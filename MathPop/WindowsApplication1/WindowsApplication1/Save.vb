Public Class Save

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'Closes the Save form.
        Me.Close()
        'Code ends here.
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'Saves the name, score, correct answers, incorrect answers, operation and difficulty that the user played the game on to a text file.
        'The text file is stored in /WindowsApplication1/bin/debug/MathPop Highscores.txt
        If TextBox1.Text = "" Then
            MsgBox("Please enter a name!", MsgBoxStyle.Critical, "MathPop: Save")
        Else
            GlobalVariables.Save = 1
            Game_Screen.Close()
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("MathPop Highscores.txt", True)
            file.Write("Name: ")
            file.WriteLine(TextBox1.Text)
            file.Write("Score: ")
            file.WriteLine(Results.Label5.Text)
            file.Write("Correct: ")
            file.WriteLine(Results.Label1.Text)
            file.Write("Incorrect: ")
            file.WriteLine(Results.Label2.Text)
            file.Write("Operation: ")
            file.WriteLine(Results.Label3.Text)
            file.Write("Difficulty: ")
            file.WriteLine(Results.Label4.Text)
            file.WriteLine("")
            file.WriteLine("")
            file.Close()
            MsgBox("Highscore has been saved!", MsgBoxStyle.OkOnly, "MathPop: Save")
            Me.Close()
        End If
        'Code ends here.
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        'This is the code for displaying a red 'Save' button on mouse-hover.
        PictureBox1.Image = My.Resources.Save_red
        'Code ends here.
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        'This is the code for displaying a blue 'Save' button on mouse-hover.
        PictureBox1.Image = My.Resources.Save_blue
        'Code ends here.
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        'This is the code for displaying a red 'Cancel' button on mouse-hover.
        PictureBox3.Image = My.Resources.Cancel_red
        'Code ends here.
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        'This is the code for displaying a red 'Cancel' button on mouse-hover.
        PictureBox3.Image = My.Resources.Cancel_blue
        'Code ends here.
    End Sub
End Class