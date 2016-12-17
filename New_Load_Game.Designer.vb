<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Load_Game
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
        Me.New_Game = New System.Windows.Forms.Button()
        Me.Load_Game = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Load_Prev_New = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'New_Game
        '
        Me.New_Game.Location = New System.Drawing.Point(71, 124)
        Me.New_Game.Name = "New_Game"
        Me.New_Game.Size = New System.Drawing.Size(75, 23)
        Me.New_Game.TabIndex = 0
        Me.New_Game.Text = "New Game"
        Me.New_Game.UseVisualStyleBackColor = True
        '
        'Load_Game
        '
        Me.Load_Game.Location = New System.Drawing.Point(164, 124)
        Me.Load_Game.Name = "Load_Game"
        Me.Load_Game.Size = New System.Drawing.Size(75, 23)
        Me.Load_Game.TabIndex = 1
        Me.Load_Game.Text = "Load Game"
        Me.Load_Game.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(256, 124)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Load_Prev_New
        '
        Me.Load_Prev_New.AutoSize = True
        Me.Load_Prev_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Load_Prev_New.Location = New System.Drawing.Point(32, 49)
        Me.Load_Prev_New.Name = "Load_Prev_New"
        Me.Load_Prev_New.Size = New System.Drawing.Size(338, 20)
        Me.Load_Prev_New.TabIndex = 3
        Me.Load_Prev_New.Text = "Load a Previous Game or Begin a New Game?"
        '
        'New_Load_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 197)
        Me.Controls.Add(Me.Load_Prev_New)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Load_Game)
        Me.Controls.Add(Me.New_Game)
        Me.Name = "New_Load_Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New/Load Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents New_Game As System.Windows.Forms.Button
    Friend WithEvents Load_Game As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Load_Prev_New As System.Windows.Forms.Label
End Class
