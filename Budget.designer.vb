<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Budget
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
        Me.lblUnallocatedFunds = New System.Windows.Forms.Label()
        Me.txtboxSci = New System.Windows.Forms.TextBox()
        Me.txtboxAgri = New System.Windows.Forms.TextBox()
        Me.txtboxPollution = New System.Windows.Forms.TextBox()
        Me.txtboxEdu = New System.Windows.Forms.TextBox()
        Me.txtboxMine = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCycleBudget = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMine = New System.Windows.Forms.Label()
        Me.lblEdu = New System.Windows.Forms.Label()
        Me.lblPoll = New System.Windows.Forms.Label()
        Me.lblAgri = New System.Windows.Forms.Label()
        Me.lblSci = New System.Windows.Forms.Label()
        Me.lblLastUnAll = New System.Windows.Forms.Label()
        Me.lblLastCyc = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUnallocatedFunds
        '
        Me.lblUnallocatedFunds.AutoSize = True
        Me.lblUnallocatedFunds.Location = New System.Drawing.Point(371, 121)
        Me.lblUnallocatedFunds.Name = "lblUnallocatedFunds"
        Me.lblUnallocatedFunds.Size = New System.Drawing.Size(69, 17)
        Me.lblUnallocatedFunds.TabIndex = 0
        Me.lblUnallocatedFunds.Text = "Starting $"
        '
        'txtboxSci
        '
        Me.txtboxSci.Location = New System.Drawing.Point(340, 190)
        Me.txtboxSci.Name = "txtboxSci"
        Me.txtboxSci.Size = New System.Drawing.Size(100, 22)
        Me.txtboxSci.TabIndex = 1
        Me.txtboxSci.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtboxAgri
        '
        Me.txtboxAgri.Location = New System.Drawing.Point(340, 225)
        Me.txtboxAgri.Name = "txtboxAgri"
        Me.txtboxAgri.Size = New System.Drawing.Size(100, 22)
        Me.txtboxAgri.TabIndex = 2
        Me.txtboxAgri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtboxPollution
        '
        Me.txtboxPollution.Location = New System.Drawing.Point(340, 260)
        Me.txtboxPollution.Name = "txtboxPollution"
        Me.txtboxPollution.Size = New System.Drawing.Size(100, 22)
        Me.txtboxPollution.TabIndex = 3
        Me.txtboxPollution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtboxEdu
        '
        Me.txtboxEdu.Location = New System.Drawing.Point(340, 297)
        Me.txtboxEdu.Name = "txtboxEdu"
        Me.txtboxEdu.Size = New System.Drawing.Size(100, 22)
        Me.txtboxEdu.TabIndex = 4
        Me.txtboxEdu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtboxMine
        '
        Me.txtboxMine.Location = New System.Drawing.Point(340, 331)
        Me.txtboxMine.Name = "txtboxMine"
        Me.txtboxMine.Size = New System.Drawing.Size(100, 22)
        Me.txtboxMine.TabIndex = 5
        Me.txtboxMine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Projects Allocation"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(105, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 17)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Agriculture"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(105, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Education"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(105, 263)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 17)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Pollution Control"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(105, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Mining"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(105, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Science Research"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Unallocated Funds"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Total Cycle Budget"
        '
        'lblCycleBudget
        '
        Me.lblCycleBudget.AutoSize = True
        Me.lblCycleBudget.Location = New System.Drawing.Point(371, 74)
        Me.lblCycleBudget.Name = "lblCycleBudget"
        Me.lblCycleBudget.Size = New System.Drawing.Size(16, 17)
        Me.lblCycleBudget.TabIndex = 21
        Me.lblCycleBudget.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Budget"
        '
        'lblMine
        '
        Me.lblMine.AutoSize = True
        Me.lblMine.Location = New System.Drawing.Point(619, 339)
        Me.lblMine.Name = "lblMine"
        Me.lblMine.Size = New System.Drawing.Size(16, 17)
        Me.lblMine.TabIndex = 31
        Me.lblMine.Text = "0"
        '
        'lblEdu
        '
        Me.lblEdu.AutoSize = True
        Me.lblEdu.Location = New System.Drawing.Point(619, 305)
        Me.lblEdu.Name = "lblEdu"
        Me.lblEdu.Size = New System.Drawing.Size(16, 17)
        Me.lblEdu.TabIndex = 30
        Me.lblEdu.Text = "0"
        '
        'lblPoll
        '
        Me.lblPoll.AutoSize = True
        Me.lblPoll.Location = New System.Drawing.Point(619, 270)
        Me.lblPoll.Name = "lblPoll"
        Me.lblPoll.Size = New System.Drawing.Size(16, 17)
        Me.lblPoll.TabIndex = 29
        Me.lblPoll.Text = "0"
        '
        'lblAgri
        '
        Me.lblAgri.AutoSize = True
        Me.lblAgri.Location = New System.Drawing.Point(619, 233)
        Me.lblAgri.Name = "lblAgri"
        Me.lblAgri.Size = New System.Drawing.Size(16, 17)
        Me.lblAgri.TabIndex = 28
        Me.lblAgri.Text = "0"
        '
        'lblSci
        '
        Me.lblSci.AutoSize = True
        Me.lblSci.Location = New System.Drawing.Point(619, 198)
        Me.lblSci.Name = "lblSci"
        Me.lblSci.Size = New System.Drawing.Size(16, 17)
        Me.lblSci.TabIndex = 27
        Me.lblSci.Text = "0"
        '
        'lblLastUnAll
        '
        Me.lblLastUnAll.AutoSize = True
        Me.lblLastUnAll.Location = New System.Drawing.Point(619, 115)
        Me.lblLastUnAll.Name = "lblLastUnAll"
        Me.lblLastUnAll.Size = New System.Drawing.Size(16, 17)
        Me.lblLastUnAll.TabIndex = 26
        Me.lblLastUnAll.Text = "0"
        '
        'lblLastCyc
        '
        Me.lblLastCyc.AutoSize = True
        Me.lblLastCyc.Location = New System.Drawing.Point(619, 70)
        Me.lblLastCyc.Name = "lblLastCyc"
        Me.lblLastCyc.Size = New System.Drawing.Size(16, 17)
        Me.lblLastCyc.TabIndex = 25
        Me.lblLastCyc.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(587, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Last Iteration"
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(84, 387)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(132, 62)
        Me.btnCommit.TabIndex = 32
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(325, 387)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(132, 62)
        Me.btnReset.TabIndex = 33
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(558, 387)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 62)
        Me.btnExit.TabIndex = 34
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Budget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 470)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.lblMine)
        Me.Controls.Add(Me.lblEdu)
        Me.Controls.Add(Me.lblPoll)
        Me.Controls.Add(Me.lblAgri)
        Me.Controls.Add(Me.lblSci)
        Me.Controls.Add(Me.lblLastUnAll)
        Me.Controls.Add(Me.lblLastCyc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCycleBudget)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtboxMine)
        Me.Controls.Add(Me.txtboxEdu)
        Me.Controls.Add(Me.txtboxPollution)
        Me.Controls.Add(Me.txtboxAgri)
        Me.Controls.Add(Me.txtboxSci)
        Me.Controls.Add(Me.lblUnallocatedFunds)
        Me.Name = "Budget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUnallocatedFunds As System.Windows.Forms.Label
    Friend WithEvents txtboxSci As System.Windows.Forms.TextBox
    Friend WithEvents txtboxAgri As System.Windows.Forms.TextBox
    Friend WithEvents txtboxPollution As System.Windows.Forms.TextBox
    Friend WithEvents txtboxEdu As System.Windows.Forms.TextBox
    Friend WithEvents txtboxMine As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCycleBudget As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMine As System.Windows.Forms.Label
    Friend WithEvents lblEdu As System.Windows.Forms.Label
    Friend WithEvents lblPoll As System.Windows.Forms.Label
    Friend WithEvents lblAgri As System.Windows.Forms.Label
    Friend WithEvents lblSci As System.Windows.Forms.Label
    Friend WithEvents lblLastUnAll As System.Windows.Forms.Label
    Friend WithEvents lblLastCyc As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
