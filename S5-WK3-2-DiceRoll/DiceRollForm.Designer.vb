<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiceRollForm
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
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.SelectedIndexLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(12, 12)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(150, 91)
        Me.GenerateButton.TabIndex = 0
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 20
        Me.DisplayListBox.Location = New System.Drawing.Point(168, 12)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(130, 344)
        Me.DisplayListBox.TabIndex = 1
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(12, 109)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(150, 91)
        Me.QuitButton.TabIndex = 2
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'SelectedIndexLabel
        '
        Me.SelectedIndexLabel.AutoSize = True
        Me.SelectedIndexLabel.Location = New System.Drawing.Point(12, 203)
        Me.SelectedIndexLabel.Name = "SelectedIndexLabel"
        Me.SelectedIndexLabel.Size = New System.Drawing.Size(141, 20)
        Me.SelectedIndexLabel.TabIndex = 3
        Me.SelectedIndexLabel.Text = "DisplayListBoxIndex"
        '
        'DiceRollForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 373)
        Me.Controls.Add(Me.SelectedIndexLabel)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.GenerateButton)
        Me.Name = "DiceRollForm"
        Me.Text = "DiceRollForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GenerateButton As Button
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents QuitButton As Button
    Friend WithEvents SelectedIndexLabel As Label
End Class
