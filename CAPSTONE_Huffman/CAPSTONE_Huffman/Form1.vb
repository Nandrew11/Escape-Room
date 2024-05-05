Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form1
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Console.WriteLine("Button clicked - opening Form2")

        ' Create an instance of Form2
        Dim form2 As New EscapeRoom1()

        ' Show Form2
        form2.Show()

        'hide the current form
        Me.Hide()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'closes the screen
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'makes form center to screen
        Me.CenterToScreen()
    End Sub
End Class
