Public Class SimonSays

    ' Declare variables
    Dim Simon As String
    Dim Stry As String
    Dim iNote As Integer
    Dim iPLay As Integer
    Dim iTry As Integer
    Dim bComputer As Boolean
    Dim ibeep As Integer

    ' Check if the player lost the game
    Private Sub CheckIfYouLost()
        ' Check if the player's input doesn't match the Simon sequence
        If Stry <> Mid(Simon, 1, Len(Stry)) Then
            Label5.Text = "You Lost The Game Try Again"
            Start.Visible = True
            Start.Enabled = True
            bComputer = True
            NextButton.Visible = False
            NextButton.Enabled = False
            Exit Sub
        End If

        ' Check if the player's input matches the Simon sequence length
        If iTry = iNote Then
            LabelTitle.Text = "Computer"
            bComputer = True
            NextButton.Visible = True
            NextButton.Enabled = True
            NextButton.Focus()
        End If
    End Sub

    ' Initialize the game
    Public Sub Game()
        ' Generate Simon's sequence
        Dim i As Integer
        Dim k As Integer
        Simon = ""
        Stry = ""
        For i = 1 To 50
            k = 4000 * Rnd()
            k = (k Mod 16) + 1
            Select Case k
                Case 1, 5, 9, 13
                    Simon = Simon & Int(1)
                Case 2, 6, 10, 14
                    Simon = Simon & Int(2)
                Case 3, 7, 11, 15
                    Simon = Simon & Int(3)
                Case 4, 8, 12, 16
                    Simon = Simon & Int(4)
            End Select
        Next

        ' Initialize game variables
        bComputer = True
        iNote = 1
        iPLay = 0
        iTry = 0
    End Sub

    ' Load the form
    Private Sub SimonSays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the form on the screen
        Me.CenterToScreen()

        ' Hide the FinishButton
        FinishButton.Visible = False

        ' Set colors and text for labels representing Simon's sequence
        RedLabel.BackColor = Color.Red
        YellowLabel.BackColor = Color.LightYellow
        GreenLabel.BackColor = Color.Green
        BlueLabel.BackColor = Color.Blue

        RedLabel.Text = "RED"
        YellowLabel.Text = "YELLOW"
        GreenLabel.Text = "GREEN"
        BlueLabel.Text = "BLUE"

        RedLabel.Size = New Size(70, 70)
        YellowLabel.Size = New Size(70, 70)
        GreenLabel.Size = New Size(70, 70)
        BlueLabel.Size = New Size(70, 70)

        ' Initialize random number generator
        Randomize()

        ' Set initial label texts and visibility for buttons
        Label5.Text = "Notes = 0"
        LabelTitle.Text = "Computer"
        NextButton.Visible = False
        NextButton.Enabled = False
    End Sub

    ' Handle BackButton click event
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        MyBase.Close()
    End Sub

    ' Handle form closed event
    Private Sub SimonSays_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        EscapeRoom1.Show()
    End Sub

    ' Handle Start button click event
    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        ' Start the game
        bComputer = True
        Game()
        T1Color.Enabled = True
        Label5.Text = "Notes= " & iNote
        Start.Visible = False
        Start.Enabled = False
    End Sub

    ' Handle Timer T1Color tick event
    Private Sub T1Color_Tick(sender As Object, e As EventArgs) Handles T1Color.Tick
        ' Display Simon's sequence colors
        Dim k As Integer
        iPLay = iPLay + 1
        k = Mid(Simon, iPLay, 1)
        Select Case k
            Case 1
                RedLabel.BackColor = Color.DarkRed
            Case 2
                YellowLabel.BackColor = Color.Yellow
            Case 3
                GreenLabel.BackColor = Color.DarkGreen
            Case 4
                BlueLabel.BackColor = Color.DarkBlue
        End Select

        ' Enable next step
        T2Beep.Enabled = True
        T1Color.Enabled = False
    End Sub

    ' Handle Timer T2Beep tick event
    Private Sub T2Beep_Tick(sender As Object, e As EventArgs) Handles T2Beep.Tick
        ' Play sound according to Simon's sequence
        Dim k As Integer
        k = Mid(Simon, iPLay, 1)
        Select Case k
            Case 1
                Console.Beep(500, 300)
            Case 2
                Console.Beep(600, 300)
            Case 3
                Console.Beep(700, 300)
            Case 4
                Console.Beep(800, 300)
        End Select
        T2Beep.Enabled = False
        T3Off.Enabled = True
    End Sub

    ' Handle Timer T3Off tick event
    Private Sub T3Off_Tick(sender As Object, e As EventArgs) Handles T3Off.Tick
        ' Reset colors after displaying Simon's sequence
        RedLabel.BackColor = Color.Red
        YellowLabel.BackColor = Color.LightYellow
        GreenLabel.BackColor = Color.Green
        BlueLabel.BackColor = Color.Blue
        T3Off.Enabled = False

        ' If it's computer's turn, continue displaying sequence; otherwise, check if player lost
        If bComputer Then
            If iPLay < iNote Then
                T1Color.Enabled = True
            Else
                bComputer = False
                LabelTitle.Text = "Player"
                Stry = ""
            End If
        Else
            CheckIfYouLost()
        End If
    End Sub

    ' Handle RedLabel click event
    Private Sub RedLabel_Click(sender As Object, e As EventArgs) Handles RedLabel.Click
        ' Handle player's input for the Red button
        If bComputer Then Exit Sub
        RedLabel.BackColor = Color.Red

        ' Play sound for player's input
        ibeep = 500
        TimBeep.Enabled = True

        ' Update player's input sequence and enable next step
        iTry = iTry + 1
        Stry = Stry & "1"
        T3Off.Enabled = True
    End Sub

    ' Handle GreenLabel click event
    Private Sub GreenLabel_Click(sender As Object, e As EventArgs) Handles GreenLabel.Click
        ' Handle player's input for the Green button
        If bComputer Then Exit Sub
        GreenLabel.BackColor = Color.Green

        ' Play sound for player's input
        ibeep = 700
        TimBeep.Enabled = True

        ' Update player's input sequence and enable next step
        iTry = iTry + 1
        Stry = Stry & "3"
        T3Off.Enabled = True
    End Sub

    ' Handle YellowLabel click event
    Private Sub YellowLabel_Click(sender As Object, e As EventArgs) Handles YellowLabel.Click
        ' Handle player's input for the Yellow button
        If bComputer Then Exit Sub
        YellowLabel.BackColor = Color.LightYellow

        ' Play sound for player's input
        ibeep = 600
        TimBeep.Enabled = True

        ' Update player's input sequence and enable next step
        iTry = iTry + 1
        Stry = Stry & "2"
        T3Off.Enabled = True
    End Sub

    ' Handle BlueLabel click event
    Private Sub BlueLabel_Click(sender As Object, e As EventArgs) Handles BlueLabel.Click
        ' Handle player's input for the Blue button
        If bComputer Then Exit Sub
        BlueLabel.BackColor = Color.Blue

        ' Play sound for player's input
        ibeep = 800
        TimBeep.Enabled = True

        ' Update player's input sequence and enable next step
        iTry = iTry + 1
        Stry = Stry & "4"
        T3Off.Enabled = True
    End Sub

    ' Handle Timer TimBeep tick event
    Private Sub TimBeep_Tick(sender As Object, e As EventArgs) Handles TimBeep.Tick
        ' Play beep sound
        Console.Beep(ibeep, 300)
        TimBeep.Enabled = False
    End Sub

    ' Handle NextButton click event
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        ' Move to the next step of the game
        iPLay = 0
        iTry = 0
        iNote += 1
        bComputer = True
        T1Color.Enabled = True
        NextButton.Visible = False
        NextButton.Enabled = False
        Label5.Text = "Notes = " & iNote

        ' If the last step reached, show FinishButton
        If iNote = 5 Then
            FinishButton.Visible = True
            FinishButton.Enabled = True
        End If
    End Sub

    ' Handle FinishButton click event
    Private Sub FinishButton_Click(sender As Object, e As EventArgs) Handles FinishButton.Click
        ' Show a clue label and close the form
        Dim ClueLabel As New Label()
        ClueLabel.Name = "ClueLabel"
        ClueLabel.Text = "8"
        ClueLabel.ForeColor = Color.Blue
        ClueLabel.Font = New Font("Arial", 12, FontStyle.Bold)
        ClueLabel.AutoSize = True

        Dim frm As New Form()
        frm.Text = ""
        frm.Size = New Size(150, 150)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Controls.Add(ClueLabel)
        frm.ShowDialog()

        Close()
    End Sub
End Class
