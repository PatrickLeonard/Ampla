'Name: Lou Saechao
'Team Name: Any Ideas
'Class: CS300
'Date: 8/21/2013
'Purpose: prompts users options where they get to select form preset parameters or 
''''''''''allow users to set up their own parameters in advance settings


Public Class Options

    Protected option_class As Option_class
    Protected advanced As AdvSet 'pointer/reference to advance settings 
    Protected settings As Boolean 'variable used to check if user closed options form without selecting settings

    Public ReadOnly Property opt() As Option_class
        Get
            Return option_class
        End Get
    End Property

	'dropdown menu that allows user to select preset settings of easy,normal, and hard
    Private Sub DifficultBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DifficultBox.SelectedIndexChanged
        Dim selection As DialogResult

        'if user selects Easy, user will be given 1000 bux and 3 mines
        If DifficultBox.SelectedItem = "Easy: $1000 and 3 Mines" Then
            selection = MessageBox.Show("You selected Easy with a starting amount of $1000 and 3 mines!", "Easy", MessageBoxButtons.OKCancel)
            If selection = DialogResult.OK Then
                option_class.NumMine = 3 'number of mines for easy is set at 3
                settings = True 'true means that user did select a setting
                Me.Close()
            End If 'if user selects normal, user will be given 1000 bux and 5 mines
        ElseIf DifficultBox.SelectedItem = "Normal: $1000 and 5 Mines" Then
            selection = MessageBox.Show("You selected Normal with a starting amount of $1000 and 5 mines!", "Normal", MessageBoxButtons.OKCancel)
            If selection = DialogResult.OK Then
                option_class.NumMine = 5 'number of mines for normal is set at 5
                settings = True
                Me.Close()
            End If 'if user selects hard, user will be given 1000 bux and 10 mines
        ElseIf DifficultBox.SelectedItem = "Hard: $1000 and 10 Mines" Then
            selection = MessageBox.Show("You selected Hard with a starting amount of $1000 and 10 mines!", "Hard", MessageBoxButtons.OKCancel)
            If selection = DialogResult.OK Then
                option_class.NumMine = 10 'number of mines for hard is set at 10
                settings = True
                Me.Close()
            End If
        End If
    End Sub

	'if user decides to set their own parameters
    Private Sub btnAdvSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvSet.Click
        Dim advanced_results As DialogResult

        advanced_results = advanced.ShowDialog()

	'if user clicks OK to selecting their own parameters
        If advanced_results = DialogResult.OK Then
            option_class = New Option_class(advanced.money()) 'creates new option_class and starting amount gets set by GETTING the value from advset

            option_class.NumMine = advanced.mines() 'number of mines gets set by GETTING the value from advset
            settings = True
            Me.Close()
        End If

    End Sub

	'if user tries to close option form, it will prompt letting them know they have to select preset settings or advset
    Private Sub Options_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If settings = False Then
            e.Cancel = True
            MessageBox.Show("You MUST select game settings to proceed.", "Please Select Settings", System.Windows.Forms.MessageBoxButtons.OK)
        End If
    End Sub

	'when option form loads, it will assign the preset starting budget 1000
    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim start_budget As Integer = 1000

        option_class = New Option_class(start_budget)

        advanced = New AdvSet()

        settings = False
    End Sub

End Class