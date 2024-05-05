Imports System.IO
Imports System.Windows

Public Class EscapeRoom2


    ' List to store the button names in the desired order
    Private buttonOrder As New List(Of String) From {"Button2", "Button2", "Button1", "Button3"}
    ' Index to keep track of the current button in the sequence
    Private currentIndex As Integer = 0
    'make it able to play mp3 files
    Dim soundPlayer As New System.Media.SoundPlayer()

    Public Sub New()
        InitializeComponent()

        ChestButton.Enabled = False
    End Sub
    Private Sub EscapeRoom2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Stop playing the audio when the form is closing
        soundPlayer.Stop()
        Form1.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub EscapeRoom2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Makes the form Center to the screen
        Me.CenterToScreen()
        'Make the door not able to be touched yet
        DoorButton.Enabled = False

        'Will make sure the buttons are hit in the right order
        Dim firstButton As Button = Me.Controls.Find(buttonOrder(0), True).FirstOrDefault()
        If firstButton IsNot Nothing Then
            firstButton.Enabled = True
        End If


        'Sound
        Dim audioBytes() As Byte = New Byte(My.Resources.CaveNoise.Length - 1) {}
        My.Resources.CaveNoise.Read(audioBytes, 0, audioBytes.Length)
        Dim audioStream As New MemoryStream(audioBytes)
        PlayAudioLoop(audioStream)
    End Sub

    Private Sub PlayAudioLoop(audioStream As Stream)
        ' Create a SoundPlayer object and set the stream
        Dim player As New System.Media.SoundPlayer()

        ' Loop the sound continuously
        AddHandler player.LoadCompleted, Sub()
                                             player.PlayLooping()
                                         End Sub

        ' Start loading the sound asynchronously
        player.Stream = audioStream
        player.LoadAsync()
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Close form
        Close()

    End Sub

    Private Sub MazeButton_Click(sender As Object, e As EventArgs) Handles MazeButton.Click
        Dim MazeForm As New Maze()

        ' Show Maze form
        MazeForm.Show()

        ' hide the current form 
        Me.Hide()
    End Sub

    Private Sub ChestButton_Click(sender As Object, e As EventArgs) Handles ChestButton.Click
        'Tells you to listen to the water to get the code
        MessageBox.Show("Listin closely, the sound of watter will lead you to the right path. When you hear a squeek you hear the water repeat again")
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button2.Click, Button1.Click
        'Makes so if the buttons are clicked in the right order that it will enable the Door button. If wrong it will go back to the rist input 
        Dim clickedButton As Button = DirectCast(sender, Button)
        If clickedButton.Name = buttonOrder(currentIndex) Then
            currentIndex += 1
            If currentIndex < buttonOrder.Count Then
                Dim nextButton As Button = Me.Controls.Find(buttonOrder(currentIndex), True).FirstOrDefault()
                If nextButton IsNot Nothing Then
                    nextButton.Enabled = True
                End If
            End If
        End If
        ' Check if the entire sequence is completed before enabling DoorButton
        If currentIndex = buttonOrder.Count Then
            DoorButton.Enabled = True
        End If
    End Sub

    Private Sub DoorButton_Click(sender As Object, e As EventArgs) Handles DoorButton.Click
        Dim form5 As New EscapeRoom3()

        ' Show Form2
        form5.Show()


        ' Optionally, you can hide the current form if you don't want it to be visible
        Me.Hide()

        soundPlayer.Stop()
    End Sub
End Class