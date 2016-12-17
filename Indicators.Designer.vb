<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Indicators
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
        Me.Pop_Label = New System.Windows.Forms.Label()
        Me.Inc_Label = New System.Windows.Forms.Label()
        Me.Fd_Label = New System.Windows.Forms.Label()
        Me.Pol_Label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pop_Display = New System.Windows.Forms.Label()
        Me.Inc_Display = New System.Windows.Forms.Label()
        Me.Fd_Display = New System.Windows.Forms.Label()
        Me.Pol_Display = New System.Windows.Forms.Label()
        Me.Return_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Pop_Label
        '
        Me.Pop_Label.AutoSize = True
        Me.Pop_Label.Location = New System.Drawing.Point(23, 53)
        Me.Pop_Label.Name = "Pop_Label"
        Me.Pop_Label.Size = New System.Drawing.Size(60, 13)
        Me.Pop_Label.TabIndex = 0
        Me.Pop_Label.Text = "Population:"
        '
        'Inc_Label
        '
        Me.Inc_Label.AutoSize = True
        Me.Inc_Label.Location = New System.Drawing.Point(38, 101)
        Me.Inc_Label.Name = "Inc_Label"
        Me.Inc_Label.Size = New System.Drawing.Size(45, 13)
        Me.Inc_Label.TabIndex = 1
        Me.Inc_Label.Text = "Income:"
        '
        'Fd_Label
        '
        Me.Fd_Label.AutoSize = True
        Me.Fd_Label.Location = New System.Drawing.Point(49, 149)
        Me.Fd_Label.Name = "Fd_Label"
        Me.Fd_Label.Size = New System.Drawing.Size(34, 13)
        Me.Fd_Label.TabIndex = 2
        Me.Fd_Label.Text = "Food:"
        '
        'Pol_Label
        '
        Me.Pol_Label.AutoSize = True
        Me.Pol_Label.Location = New System.Drawing.Point(33, 197)
        Me.Pol_Label.Name = "Pol_Label"
        Me.Pol_Label.Size = New System.Drawing.Size(69, 13)
        Me.Pol_Label.TabIndex = 3
        Me.Pol_Label.Text = "Environment:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Planetary Indicators"
        '
        'Pop_Display
        '
        Me.Pop_Display.AutoSize = True
        Me.Pop_Display.Location = New System.Drawing.Point(216, 53)
        Me.Pop_Display.Name = "Pop_Display"
        Me.Pop_Display.Size = New System.Drawing.Size(25, 13)
        Me.Pop_Display.TabIndex = 5
        Me.Pop_Display.Text = "pop"
        '
        'Inc_Display
        '
        Me.Inc_Display.AutoSize = True
        Me.Inc_Display.Location = New System.Drawing.Point(216, 101)
        Me.Inc_Display.Name = "Inc_Display"
        Me.Inc_Display.Size = New System.Drawing.Size(21, 13)
        Me.Inc_Display.TabIndex = 6
        Me.Inc_Display.Text = "inc"
        '
        'Fd_Display
        '
        Me.Fd_Display.AutoSize = True
        Me.Fd_Display.Location = New System.Drawing.Point(216, 149)
        Me.Fd_Display.Name = "Fd_Display"
        Me.Fd_Display.Size = New System.Drawing.Size(16, 13)
        Me.Fd_Display.TabIndex = 7
        Me.Fd_Display.Text = "fd"
        '
        'Pol_Display
        '
        Me.Pol_Display.AutoSize = True
        Me.Pol_Display.Location = New System.Drawing.Point(216, 197)
        Me.Pol_Display.Name = "Pol_Display"
        Me.Pol_Display.Size = New System.Drawing.Size(21, 13)
        Me.Pol_Display.TabIndex = 8
        Me.Pol_Display.Text = "pol"
        '
        'Return_Button
        '
        Me.Return_Button.Location = New System.Drawing.Point(105, 234)
        Me.Return_Button.Name = "Return_Button"
        Me.Return_Button.Size = New System.Drawing.Size(75, 23)
        Me.Return_Button.TabIndex = 9
        Me.Return_Button.Text = "Return"
        Me.Return_Button.UseVisualStyleBackColor = True
        '
        'Indicators
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 281)
        Me.Controls.Add(Me.Return_Button)
        Me.Controls.Add(Me.Pol_Display)
        Me.Controls.Add(Me.Fd_Display)
        Me.Controls.Add(Me.Inc_Display)
        Me.Controls.Add(Me.Pop_Display)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Pol_Label)
        Me.Controls.Add(Me.Fd_Label)
        Me.Controls.Add(Me.Inc_Label)
        Me.Controls.Add(Me.Pop_Label)
        Me.Name = "Indicators"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planetary Indicators"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pop_Label As System.Windows.Forms.Label
    Friend WithEvents Inc_Label As System.Windows.Forms.Label
    Friend WithEvents Fd_Label As System.Windows.Forms.Label
    Friend WithEvents Pol_Label As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Pop_Display As System.Windows.Forms.Label
    Friend WithEvents Inc_Display As System.Windows.Forms.Label
    Friend WithEvents Fd_Display As System.Windows.Forms.Label
    Friend WithEvents Pol_Display As System.Windows.Forms.Label
    Friend WithEvents Return_Button As System.Windows.Forms.Button
End Class
