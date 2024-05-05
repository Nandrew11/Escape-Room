Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class EscapeRoom1

    Private Sub EscapeRoom_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'When closing it shows the first form 
        Form1.Show()
    End Sub

    Private Sub EscapeRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Starts at the center of the screen as well as Hide the door button
        Me.CenterToScreen()
        DoorButton.Hide()


    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Closes the form that it is on right now 
        Close()
    End Sub

    Private Sub LockButton_Click(sender As Object, e As EventArgs) Handles LockButton.Click
        ' Make the Code to be 867
        Dim correctCode As String = "867"

        ' Check if the entered code is correct
        If CodeTextBox.Text = correctCode Then
            ' Code is correct, unlock the "door"
            MessageBox.Show("Code correct! The door is unlocked.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Hide the Lock button
            LockButton.Hide()

            ' Show the DoorButton button
            DoorButton.Show()

            CodeTextBox.Hide()
        Else
            ' Code is incorrect, inform the user
            MessageBox.Show("Incorrect code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DoorButton_Click(sender As Object, e As EventArgs) Handles DoorButton.Click
        ' Create an instance of Form2
        Dim form3 As New EscapeRoom2()

        ' Show Form2
        form3.Show()

        ' Optionally, you can hide the current form if you don't want it to be visible
        Me.Hide()
    End Sub



    Private Sub PuzzleOne_Click(sender As Object, e As EventArgs) Handles PuzzleOne.Click
        'Makes the number as Functions 
        Dim num1 As Integer = 3
        Dim num2 As Integer = 2
        Dim num3 As Integer = 3
        'Makes the riddle function that will show up the first box then two lines down it will give the riddle 
        Dim riddle As String = " If you tell how many goblins you beat you will be one step closer to great Fortune " & vbCrLf & vbCrLf &
                   "In a cave you pass by 2 goblins. You beat them. After you travel a but more you see 4 more of those goblins. you beat 3 of them and run from one. again you travel deeper into the cave you see 4 more goblins. You beat 3 and one drops a riddle."
        'in the Textbox in the message box will be the answer you put
        Dim answer As String = InputBox(riddle)
        'Makes aother varible as if you get the riddle right.
        Dim result As Integer
        If Integer.TryParse(answer, result) AndAlso result = num1 + num2 + num3 Then
            'Makes a form that will have the red number 7
            MsgBox("Correct! You are a master of Slaying Goblins!")
            Dim RedLabel As New Label()
            RedLabel.Name = "RedLabel"
            RedLabel.Text = "7"
            RedLabel.ForeColor = Color.Red
            RedLabel.Font = New Font("Arial", 12, FontStyle.Bold)
            RedLabel.AutoSize = True
            'shows this if you get the answer right
            Dim msgBoxResult As MsgBoxResult = MsgBox("But wait, You find something glow on the riddle when you solved it", MsgBoxStyle.Information, )
            'if right then the form with a the red 7 shows 
            If msgBoxResult = MsgBoxResult.Ok Then
                Dim frm As New Form()
                frm.Text = ""
                frm.Size = New Size(150, 150)
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.Controls.Add(RedLabel)
                frm.ShowDialog()

            End If
            'if wrong it shows this 
        Else
            MsgBox("Sorry, that's not quite right. Try Again")
        End If
    End Sub

    Private Sub PuzzleTwo_Click(sender As Object, e As EventArgs) Handles PuzzleTwo.Click
        'shows simonsays form 
        Dim form4 As New SimonSays()

        form4.Show()
        'hides the Escape room 1 form 
        Me.Hide()
    End Sub

    Private Sub CodeOrder_Click(sender As Object, e As EventArgs) Handles CodeOrder.Click
        'a riddle to get the code right 
        MsgBox("In order to pass you must put the rainbow in reverse")
    End Sub

    Private Sub PuzzelThree_Click(sender As Object, e As EventArgs) Handles PuzzelThree.Click
        'pulls up the form of a riddle to get the last number of the code 
        Dim Form5 As New Riddle

        Form5.Show()

        Me.Hide()
    End Sub

    Private Sub CodeTextBox_MouseEnter(sender As Object, e As EventArgs) Handles CodeTextBox.MouseEnter
        'if mouse enters it shows a placement message that says enter a code
        If CodeTextBox.Text = ("Enter a Code") Then
            CodeTextBox.Text = ""
            CodeTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CodeTextBox_MouseLeave(sender As Object, e As EventArgs) Handles CodeTextBox.MouseLeave
        'if mouse Leaves it shows a placement message that says enter a code
        If CodeTextBox.Text = ("") Then
            CodeTextBox.Text = "Enter a Code"
            CodeTextBox.ForeColor = Color.Gray
        End If

    End Sub
End Class