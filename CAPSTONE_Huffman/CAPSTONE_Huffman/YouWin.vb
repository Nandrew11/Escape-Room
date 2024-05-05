Public Class YouWin
    Private Sub YouWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'closing all of the forms that may have been left open
        Close()
        EscapeRoom1.Close()
        EscapeRoom2.Close()
        EscapeRoom3.Close()
        Form1.Close()
    End Sub
End Class