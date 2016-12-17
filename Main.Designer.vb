<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Indicator = New System.Windows.Forms.Button()
        Me.Budget = New System.Windows.Forms.Button()
        Me.Draw = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.loadGame = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.IterationLabel = New System.Windows.Forms.Label()
        Me.IterationNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Indicator
        '
        Me.Indicator.Location = New System.Drawing.Point(763, 24)
        Me.Indicator.Name = "Indicator"
        Me.Indicator.Size = New System.Drawing.Size(100, 30)
        Me.Indicator.TabIndex = 0
        Me.Indicator.Text = "Show Indicators"
        Me.Indicator.UseVisualStyleBackColor = True
        '
        'Budget
        '
        Me.Budget.Location = New System.Drawing.Point(763, 78)
        Me.Budget.Name = "Budget"
        Me.Budget.Size = New System.Drawing.Size(100, 30)
        Me.Budget.TabIndex = 1
        Me.Budget.Text = "Budget"
        Me.Budget.UseVisualStyleBackColor = True
        '
        'Draw
        '
        Me.Draw.Location = New System.Drawing.Point(763, 137)
        Me.Draw.Name = "Draw"
        Me.Draw.Size = New System.Drawing.Size(100, 30)
        Me.Draw.TabIndex = 2
        Me.Draw.Text = "Draw Map"
        Me.Draw.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(763, 283)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(100, 30)
        Me.Save.TabIndex = 3
        Me.Save.Text = "Save Game"
        Me.Save.UseVisualStyleBackColor = True
        '
        'loadGame
        '
        Me.loadGame.Location = New System.Drawing.Point(763, 340)
        Me.loadGame.Name = "loadGame"
        Me.loadGame.Size = New System.Drawing.Size(100, 30)
        Me.loadGame.TabIndex = 4
        Me.loadGame.Text = "New/Load Game"
        Me.loadGame.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(763, 487)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(100, 30)
        Me.Quit.TabIndex = 5
        Me.Quit.Text = "Exit Game"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'IterationLabel
        '
        Me.IterationLabel.AutoSize = True
        Me.IterationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IterationLabel.Location = New System.Drawing.Point(67, 515)
        Me.IterationLabel.Name = "IterationLabel"
        Me.IterationLabel.Size = New System.Drawing.Size(81, 20)
        Me.IterationLabel.TabIndex = 6
        Me.IterationLabel.Text = "Interation:"
        '
        'IterationNum
        '
        Me.IterationNum.AutoSize = True
        Me.IterationNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IterationNum.Location = New System.Drawing.Point(165, 515)
        Me.IterationNum.Name = "IterationNum"
        Me.IterationNum.Size = New System.Drawing.Size(0, 20)
        Me.IterationNum.TabIndex = 7
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 562)
        Me.Controls.Add(Me.IterationNum)
        Me.Controls.Add(Me.IterationLabel)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.loadGame)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Draw)
        Me.Controls.Add(Me.Budget)
        Me.Controls.Add(Me.Indicator)
        Me.Name = "Main"
        Me.Text = "Ampla Planetary Management Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Indicator As System.Windows.Forms.Button
    Friend WithEvents Budget As System.Windows.Forms.Button
    Friend WithEvents Draw As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents loadGame As System.Windows.Forms.Button
    Friend WithEvents Quit As System.Windows.Forms.Button
    Friend WithEvents IterationLabel As System.Windows.Forms.Label
    Friend WithEvents IterationNum As System.Windows.Forms.Label

End Class
