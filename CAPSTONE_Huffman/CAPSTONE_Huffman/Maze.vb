Public Class Maze

    Public Sub New()


        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FinishLabel_MouseEnter(sender As Object, e As EventArgs) Handles FinishLabel.MouseEnter
        'when yoyu get the mouse to the chest it shows this message box and enables the chest 
        MessageBox.Show("You hear a Key drop to the ground. It looks like you can unlock a chest")

        EscapeRoom2.ChestButton.Enabled = True

        Close()


    End Sub
    Private Sub MoveToStart()
        'shows where to start the mouse when it gets sent back
        Dim StartingPoint = Panel1.Location
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label18.MouseEnter, Panel1.MouseEnter, Label9.MouseEnter, Label89.MouseEnter, Label88.MouseEnter, Label87.MouseEnter, Label84.MouseEnter, Label83.MouseEnter, Label82.MouseEnter, Label81.MouseEnter, Label80.MouseEnter, Label8.MouseEnter, Label79.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label7.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        'hit the mouse hits a wall it gets sent to the start
        MoveToStart()


    End Sub

    Private Sub Maze_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when the form loads it makes these labels not visible ad not touchable
        FinishLabel.Visible = False
        FinishLabel.Enabled = False
    End Sub

    Private Sub KeyLabel_MouseEnter(sender As Object, e As EventArgs) Handles KeyLabel.MouseEnter

        'when you enter this label it unlockes the chest to see it as well as sends the mouse back to the start
        FinishLabel.Visible = True
        FinishLabel.Enabled = True

    End Sub

    Private Sub Maze_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'when closing it shows the Escape room 2
        EscapeRoom2.Show()
    End Sub
End Class