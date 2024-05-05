Public Class EscapeRoom3
    Private Sub EscapeRoom3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Makes the form start at the center of the screen 
        Me.CenterToScreen()
        'Makes sure the buttons are not availible to click 
        DoorButton.Enabled = False
        DrawerButton.Enabled = False
        GroupBox1.Visible = False
        DrawerButton.Visible = False

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Close the form 
        Close()
    End Sub

    Private Sub EscapeRoom3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'When closing the Start screen showes up
        Form1.Show()
    End Sub

    Private Sub DrawerButton_Click(sender As Object, e As EventArgs) Handles DrawerButton.Click
        'Makes a Function to show the form last tictac
        Dim TicForm As New LastTicTac

        TicForm.Show()


    End Sub

    Private Sub TikTakToeButton_Click(sender As Object, e As EventArgs)
        'Making TacToe to show the form Last TicTac
        Dim TacToeCode As New LastTicTac


        TacToeCode.Show()


    End Sub


    Private Sub CheckBoxes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged, CheckBox12.CheckedChanged, CheckBox14.CheckedChanged, CheckBox17.CheckedChanged, CheckBox18.CheckedChanged
        ' Check if all required checkboxes are checked
        If CheckBox11.Checked AndAlso CheckBox12.Checked AndAlso CheckBox14.Checked AndAlso CheckBox17.Checked AndAlso CheckBox18.Checked Then
            ' If all are checked, enable GroupBox1
            GroupBox1.Enabled = True
            ' Enable the Drawer Button form

            DrawerButton.Enabled = True
            GroupBox1.Visible = True
            DrawerButton.Visible = True
            LockButton.Visible = False
        Else
            ' If any one of them is unchecked, disable GroupBox1
            GroupBox1.Enabled = False
            ' Disable the button from EscapeRoom3 form
            DrawerButton.Enabled = False

        End If

    End Sub
    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox6.CheckedChanged, CheckBox8.CheckedChanged, CheckBox9.CheckedChanged
        ' Check if checkboxes 4, 5, 6, 8, and 9 are checked
        If CheckBox4.Checked AndAlso CheckBox5.Checked AndAlso CheckBox6.Checked AndAlso CheckBox8.Checked AndAlso CheckBox9.Checked Then
            DoorButton.Enabled = True ' Enable the DoorButton
        Else
            DoorButton.Enabled = False ' Disable the DoorButton
        End If
    End Sub

    Private Sub DoorButton_Click(sender As Object, e As EventArgs) Handles DoorButton.Click
        'Making a Varible WinForm to show the win Screen

        Dim WinForm As New YouWin

        WinForm.Show()

        Me.Hide()
    End Sub

    Private Sub LockButton_Click(sender As Object, e As EventArgs) Handles LockButton.Click
        MsgBox("It appears this is locked")
    End Sub
End Class