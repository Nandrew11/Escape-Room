<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EscapeRoom1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.LockButton = New System.Windows.Forms.Button()
        Me.PuzzleOne = New System.Windows.Forms.Button()
        Me.PuzzleTwo = New System.Windows.Forms.Button()
        Me.PuzzelThree = New System.Windows.Forms.Button()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.DoorButton = New System.Windows.Forms.Button()
        Me.CodeOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(988, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "Close"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'LockButton
        '
        Me.LockButton.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources.lock_icon_11
        Me.LockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LockButton.Location = New System.Drawing.Point(492, 326)
        Me.LockButton.Name = "LockButton"
        Me.LockButton.Size = New System.Drawing.Size(75, 63)
        Me.LockButton.TabIndex = 2
        Me.LockButton.UseVisualStyleBackColor = True
        '
        'PuzzleOne
        '
        Me.PuzzleOne.BackColor = System.Drawing.Color.Transparent
        Me.PuzzleOne.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources.Scroll_PNG_File
        Me.PuzzleOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PuzzleOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PuzzleOne.Location = New System.Drawing.Point(169, 404)
        Me.PuzzleOne.Name = "PuzzleOne"
        Me.PuzzleOne.Size = New System.Drawing.Size(146, 57)
        Me.PuzzleOne.TabIndex = 3
        Me.PuzzleOne.UseVisualStyleBackColor = False
        '
        'PuzzleTwo
        '
        Me.PuzzleTwo.BackColor = System.Drawing.Color.Transparent
        Me.PuzzleTwo.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources._1_15108_red_button_circle_image_pixabay_transparent_background_red
        Me.PuzzleTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PuzzleTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PuzzleTwo.Location = New System.Drawing.Point(749, 395)
        Me.PuzzleTwo.Name = "PuzzleTwo"
        Me.PuzzleTwo.Size = New System.Drawing.Size(58, 53)
        Me.PuzzleTwo.TabIndex = 4
        Me.PuzzleTwo.UseVisualStyleBackColor = False
        '
        'PuzzelThree
        '
        Me.PuzzelThree.BackColor = System.Drawing.Color.Transparent
        Me.PuzzelThree.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources.pngimg_com___goblin_PNG1
        Me.PuzzelThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PuzzelThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PuzzelThree.Location = New System.Drawing.Point(890, 434)
        Me.PuzzelThree.Name = "PuzzelThree"
        Me.PuzzelThree.Size = New System.Drawing.Size(162, 205)
        Me.PuzzelThree.TabIndex = 5
        Me.PuzzelThree.UseVisualStyleBackColor = False
        '
        'CodeTextBox
        '
        Me.CodeTextBox.Location = New System.Drawing.Point(483, 395)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodeTextBox.TabIndex = 6
        Me.CodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DoorButton
        '
        Me.DoorButton.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources._1513342_200
        Me.DoorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DoorButton.Location = New System.Drawing.Point(492, 349)
        Me.DoorButton.Name = "DoorButton"
        Me.DoorButton.Size = New System.Drawing.Size(75, 57)
        Me.DoorButton.TabIndex = 7
        Me.DoorButton.UseVisualStyleBackColor = True
        '
        'CodeOrder
        '
        Me.CodeOrder.Location = New System.Drawing.Point(483, 421)
        Me.CodeOrder.Name = "CodeOrder"
        Me.CodeOrder.Size = New System.Drawing.Size(95, 23)
        Me.CodeOrder.TabIndex = 9
        Me.CodeOrder.Text = "Code Order"
        Me.CodeOrder.UseVisualStyleBackColor = True
        '
        'EscapeRoom1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources._360_F_305952154_96qiEvv5kwpdDQ6EVNGSpcNt8IkQWh6W
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.CodeOrder)
        Me.Controls.Add(Me.DoorButton)
        Me.Controls.Add(Me.CodeTextBox)
        Me.Controls.Add(Me.PuzzelThree)
        Me.Controls.Add(Me.PuzzleTwo)
        Me.Controls.Add(Me.PuzzleOne)
        Me.Controls.Add(Me.LockButton)
        Me.Controls.Add(Me.BackButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1080, 720)
        Me.MinimizeBox = False
        Me.Name = "EscapeRoom1"
        Me.Text = "EscapeRoom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents LockButton As Button
    Friend WithEvents PuzzleOne As Button
    Friend WithEvents PuzzleTwo As Button
    Friend WithEvents PuzzelThree As Button
    Friend WithEvents CodeTextBox As TextBox
    Friend WithEvents DoorButton As Button
    Friend WithEvents CodeOrder As Button
End Class
