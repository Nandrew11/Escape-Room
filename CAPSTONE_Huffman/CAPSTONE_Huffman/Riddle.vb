Public Class Riddle
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        'Makes sure that all of these Buttons are visible and working when you hut the start button and turns off the start button
        StartButton.Visible = False
        StartButton.Enabled = False

        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        GuessButton.Visible = True
        GuessTextbox.Visible = True
    End Sub

    Private Sub Riddle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when you load the form it makes these tools not visible
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        GuessButton.Visible = False
        GuessTextbox.Visible = False


    End Sub

    Private Sub Riddle_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'when closed it will load the esacpe room 1
        EscapeRoom1.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'will close the form
        Close()
    End Sub

    Private Sub GuessButton_Click(sender As Object, e As EventArgs) Handles GuessButton.Click
        'if the guess that you make is candle the it shows a messagebox that says you did it here is a part of the code
        If GuessTextbox.Text.ToLower() = "candle" Then
            MessageBox.Show("It was a lucky guess! But still good job, Traveler. Here, this will help you out in your travels.")
            'makes a form that shows a orange 6
            Dim YellowLabel As New Label()
            YellowLabel.Name = "YellowLabel"
            YellowLabel.Text = "6"
            YellowLabel.ForeColor = Color.Orange
            YellowLabel.Font = New Font("Arial", 12, FontStyle.Bold)
            YellowLabel.AutoSize = True



            Dim frm As New Form()
            frm.Text = ""
            frm.Size = New Size(150, 150)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Controls.Add(YellowLabel)
            frm.ShowDialog()


        Else
            'shows if you are wrong
            MessageBox.Show("WRONG!! Try again!!")
        End If
    End Sub
End Class