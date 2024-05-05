<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources.Start
        Me.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.ForeColor = System.Drawing.Color.Transparent
        Me.StartButton.Location = New System.Drawing.Point(194, 223)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(378, 170)
        Me.StartButton.TabIndex = 0
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.Control
        Me.CloseButton.Location = New System.Drawing.Point(725, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources.Welcome
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.StartButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents CloseButton As Button
End Class
