<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YouWin
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
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Red
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(261, 247)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(276, 84)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'YouWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CAPSTONE_Huffman.My.Resources.Resources.Congrats
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.CloseButton)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "YouWin"
        Me.Text = "YouWin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CloseButton As Button
End Class
