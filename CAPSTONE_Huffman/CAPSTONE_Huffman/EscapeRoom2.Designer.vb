<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EscapeRoom2
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.MazeButton = New System.Windows.Forms.Button()
        Me.ChestButton = New System.Windows.Forms.Button()
        Me.DoorButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(990, 1)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Exit"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(851, -1)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 3
        Me.BackButton.Text = "Close"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'MazeButton
        '
        Me.MazeButton.BackColor = System.Drawing.Color.Transparent
        Me.MazeButton.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources.Maze_simple_svg
        Me.MazeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MazeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MazeButton.Location = New System.Drawing.Point(106, 427)
        Me.MazeButton.Name = "MazeButton"
        Me.MazeButton.Size = New System.Drawing.Size(96, 95)
        Me.MazeButton.TabIndex = 4
        Me.MazeButton.UseVisualStyleBackColor = False
        '
        'ChestButton
        '
        Me.ChestButton.BackColor = System.Drawing.Color.Transparent
        Me.ChestButton.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources.Closed_Treasure_Chest_PNG_Clipart
        Me.ChestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChestButton.Location = New System.Drawing.Point(739, 392)
        Me.ChestButton.Name = "ChestButton"
        Me.ChestButton.Size = New System.Drawing.Size(102, 80)
        Me.ChestButton.TabIndex = 5
        Me.ChestButton.UseVisualStyleBackColor = False
        '
        'DoorButton
        '
        Me.DoorButton.BackColor = System.Drawing.Color.Transparent
        Me.DoorButton.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources._1513342_200
        Me.DoorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DoorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DoorButton.Location = New System.Drawing.Point(127, 250)
        Me.DoorButton.Name = "DoorButton"
        Me.DoorButton.Size = New System.Drawing.Size(75, 53)
        Me.DoorButton.TabIndex = 6
        Me.DoorButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(295, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(376, 265)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'EscapeRoom2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources.d3kpvx8_b5b3fe3f_ea8c_4fe0_a26f_20ba52385a01
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(926, 534)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DoorButton)
        Me.Controls.Add(Me.ChestButton)
        Me.Controls.Add(Me.MazeButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EscapeRoom2"
        Me.Text = "EscapeRoom2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents MazeButton As Button
    Friend WithEvents ChestButton As Button
    Friend WithEvents DoorButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
