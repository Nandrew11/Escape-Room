<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SimonSays
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RedLabel = New System.Windows.Forms.Label()
        Me.GreenLabel = New System.Windows.Forms.Label()
        Me.YellowLabel = New System.Windows.Forms.Label()
        Me.BlueLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.T1Color = New System.Windows.Forms.Timer(Me.components)
        Me.T2Beep = New System.Windows.Forms.Timer(Me.components)
        Me.T3Off = New System.Windows.Forms.Timer(Me.components)
        Me.TimBeep = New System.Windows.Forms.Timer(Me.components)
        Me.NextButton = New System.Windows.Forms.Button()
        Me.FinishButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RedLabel
        '
        Me.RedLabel.Location = New System.Drawing.Point(53, 121)
        Me.RedLabel.Name = "RedLabel"
        Me.RedLabel.Size = New System.Drawing.Size(100, 23)
        Me.RedLabel.TabIndex = 0
        Me.RedLabel.Text = "Label1"
        '
        'GreenLabel
        '
        Me.GreenLabel.Location = New System.Drawing.Point(53, 209)
        Me.GreenLabel.Name = "GreenLabel"
        Me.GreenLabel.Size = New System.Drawing.Size(100, 23)
        Me.GreenLabel.TabIndex = 1
        Me.GreenLabel.Text = "Label2"
        '
        'YellowLabel
        '
        Me.YellowLabel.Location = New System.Drawing.Point(260, 121)
        Me.YellowLabel.Name = "YellowLabel"
        Me.YellowLabel.Size = New System.Drawing.Size(100, 23)
        Me.YellowLabel.TabIndex = 2
        Me.YellowLabel.Text = "Label3"
        '
        'BlueLabel
        '
        Me.BlueLabel.Location = New System.Drawing.Point(260, 209)
        Me.BlueLabel.Name = "BlueLabel"
        Me.BlueLabel.Size = New System.Drawing.Size(100, 23)
        Me.BlueLabel.TabIndex = 3
        Me.BlueLabel.Text = "Label4"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(-2, 347)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 4
        Me.BackButton.Text = "<----Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Label5"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(155, 19)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(87, 20)
        Me.LabelTitle.TabIndex = 6
        Me.LabelTitle.Text = "Computer"
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(159, 257)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 7
        Me.Start.Text = "START"
        Me.Start.UseVisualStyleBackColor = True
        '
        'T1Color
        '
        '
        'T2Beep
        '
        '
        'T3Off
        '
        '
        'TimBeep
        '
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(159, 286)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 8
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'FinishButton
        '
        Me.FinishButton.Location = New System.Drawing.Point(159, 315)
        Me.FinishButton.Name = "FinishButton"
        Me.FinishButton.Size = New System.Drawing.Size(75, 23)
        Me.FinishButton.TabIndex = 9
        Me.FinishButton.Text = "Finish"
        Me.FinishButton.UseVisualStyleBackColor = True
        '
        'SimonSays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 371)
        Me.ControlBox = False
        Me.Controls.Add(Me.FinishButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.BlueLabel)
        Me.Controls.Add(Me.YellowLabel)
        Me.Controls.Add(Me.GreenLabel)
        Me.Controls.Add(Me.RedLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SimonSays"
        Me.Text = "SimonSays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RedLabel As Label
    Friend WithEvents GreenLabel As Label
    Friend WithEvents YellowLabel As Label
    Friend WithEvents BlueLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents Start As Button
    Friend WithEvents T1Color As Timer
    Friend WithEvents T2Beep As Timer
    Friend WithEvents T3Off As Timer
    Friend WithEvents TimBeep As Timer
    Friend WithEvents NextButton As Button
    Friend WithEvents FinishButton As Button
End Class
