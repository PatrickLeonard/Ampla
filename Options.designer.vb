<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.txtboxMines = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveQuit = New System.Windows.Forms.Button()
        Me.lblSetting = New System.Windows.Forms.Label()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.DifficultBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxMoney = New System.Windows.Forms.TextBox()
        Me.btnAdvSet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtboxMines
        '
        Me.txtboxMines.Location = New System.Drawing.Point(335, 223)
        Me.txtboxMines.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtboxMines.Name = "txtboxMines"
        Me.txtboxMines.Size = New System.Drawing.Size(51, 20)
        Me.txtboxMines.TabIndex = 18
        Me.txtboxMines.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 226)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Number of Mines"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 176)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 37)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Advance Settings"
        Me.Label1.Visible = False
        '
        'btnSaveQuit
        '
        Me.btnSaveQuit.Location = New System.Drawing.Point(207, 353)
        Me.btnSaveQuit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSaveQuit.Name = "btnSaveQuit"
        Me.btnSaveQuit.Size = New System.Drawing.Size(140, 22)
        Me.btnSaveQuit.TabIndex = 14
        Me.btnSaveQuit.Text = "Save and Quit"
        Me.btnSaveQuit.UseVisualStyleBackColor = True
        Me.btnSaveQuit.Visible = False
        '
        'lblSetting
        '
        Me.lblSetting.AutoSize = True
        Me.lblSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetting.Location = New System.Drawing.Point(22, 15)
        Me.lblSetting.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSetting.Name = "lblSetting"
        Me.lblSetting.Size = New System.Drawing.Size(247, 37)
        Me.lblSetting.TabIndex = 13
        Me.lblSetting.Text = "Preset Settings"
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.Location = New System.Drawing.Point(25, 58)
        Me.lblDifficulty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(61, 17)
        Me.lblDifficulty.TabIndex = 12
        Me.lblDifficulty.Text = "Difficulty"
        '
        'DifficultBox
        '
        Me.DifficultBox.FormattingEnabled = True
        Me.DifficultBox.Items.AddRange(New Object() {"Easy: $1000 and 3 Mines", "Normal: $1000 and 5 Mines", "Hard: $1000 and 10 Mines"})
        Me.DifficultBox.Location = New System.Drawing.Point(117, 58)
        Me.DifficultBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DifficultBox.MaxDropDownItems = 3
        Me.DifficultBox.Name = "DifficultBox"
        Me.DifficultBox.Size = New System.Drawing.Size(126, 21)
        Me.DifficultBox.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 254)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Starting Amount"
        Me.Label3.Visible = False
        '
        'txtboxMoney
        '
        Me.txtboxMoney.Location = New System.Drawing.Point(335, 254)
        Me.txtboxMoney.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtboxMoney.Name = "txtboxMoney"
        Me.txtboxMoney.Size = New System.Drawing.Size(51, 20)
        Me.txtboxMoney.TabIndex = 20
        Me.txtboxMoney.Visible = False
        '
        'btnAdvSet
        '
        Me.btnAdvSet.Location = New System.Drawing.Point(68, 133)
        Me.btnAdvSet.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdvSet.Name = "btnAdvSet"
        Me.btnAdvSet.Size = New System.Drawing.Size(124, 32)
        Me.btnAdvSet.TabIndex = 21
        Me.btnAdvSet.Text = "Advance Settings"
        Me.btnAdvSet.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 175)
        Me.Controls.Add(Me.btnAdvSet)
        Me.Controls.Add(Me.txtboxMoney)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxMines)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveQuit)
        Me.Controls.Add(Me.lblSetting)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.DifficultBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxMines As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSetting As System.Windows.Forms.Label
    Friend WithEvents lblDifficulty As System.Windows.Forms.Label
    Friend WithEvents DifficultBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtboxMoney As System.Windows.Forms.TextBox
    Public WithEvents btnSaveQuit As System.Windows.Forms.Button
    Friend WithEvents btnAdvSet As System.Windows.Forms.Button
End Class
