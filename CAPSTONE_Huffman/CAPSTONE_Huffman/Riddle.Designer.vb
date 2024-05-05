<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Riddle
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
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GuessTextbox = New System.Windows.Forms.TextBox()
        Me.GuessButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(218, 108)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(186, 64)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Answer my riddle and you shall earn what is kept secret..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "My life can be measured in hours, I only serve to be devoured." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Slim, I am quick." &
    "  Fat, I am slow. Wind is my foe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "What is the answer??"
        '
        'GuessTextbox
        '
        Me.GuessTextbox.Location = New System.Drawing.Point(240, 178)
        Me.GuessTextbox.Name = "GuessTextbox"
        Me.GuessTextbox.Size = New System.Drawing.Size(173, 20)
        Me.GuessTextbox.TabIndex = 8
        '
        'GuessButton
        '
        Me.GuessButton.Location = New System.Drawing.Point(270, 205)
        Me.GuessButton.Name = "GuessButton"
        Me.GuessButton.Size = New System.Drawing.Size(75, 23)
        Me.GuessButton.TabIndex = 9
        Me.GuessButton.Text = "Guess"
        Me.GuessButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(-1, 294)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.Text = "<----Back"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Riddle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.GuessButton)
        Me.Controls.Add(Me.GuessTextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Riddle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Riddle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GuessTextbox As TextBox
    Friend WithEvents GuessButton As Button
    Friend WithEvents CloseButton As Button
End Class
