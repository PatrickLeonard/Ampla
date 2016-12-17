'Name: Lou Saechao
'Team Name: Any Ideas
'Class: CS300
'Date: 8/21/2013
'Purpose: this is the advance settings form that allows use to select their own parameters. money and mines.

Public Class AdvSet

    Protected moneychosen As Integer 'will hold the amount of money the user decides to give themself.
    Protected num_mine As Integer 'will hold the number of mines the user decides to give themself.

    Public ReadOnly Property money() As Integer 'returns value stored in moneychosen
        Get
            Return moneychosen
        End Get
    End Property

    Public ReadOnly Property mines() As Integer 'returns value stored in num_mine
        Get
            Return num_mine 
        End Get
    End Property

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim selection_confirm As DialogResult

        'if the textbox is empty when save button is clicked, it will let user know and allow user to enter value
        If String.IsNullOrEmpty(txtboxMoney.Text) Then
            MessageBox.Show("You entered NOTHING in amount of money")
        ElseIf String.IsNullOrEmpty(txtboxMines.Text) Then
            MessageBox.Show("You entered NOTHING in number of mines")
        Else
            moneychosen = CInt(txtboxMoney.Text) 'money entered in textbox would be assigned to moneychosen variable

            num_mine = CInt(txtboxMines.Text) 'mine entered in textbox would be assigned to num_mine variable

            'Make sure user isn't entering negative numbers and the number of mines is max at 20 
            If moneychosen <= 0 Or num_mine <= 0 Or num_mine > 20 Then
                MessageBox.Show("Please enter a value between 0 and 20 for the number of mines, or a postive amount of money.", "Invalid Entry!", MessageBoxButtons.OK)

                moneychosen = 0
                num_mine = 0

                txtboxMoney.Text = moneychosen

                txtboxMines.Text = num_mine
            Else

                'if textbox is not empty and >0, it prompts user if they are sure they want those values
                selection_confirm = MessageBox.Show("ARE YOU SURE?!", "FINAL ANSWER?", MessageBoxButtons.OKCancel)
                If selection_confirm = DialogResult.OK Then 'if user selects OK


                    Me.DialogResult = DialogResult.OK

                    Me.Close()

                End If
            End If
        End If

    End Sub

	'if user selects exit it would close advance settings form without saving and go back to options form
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtboxMines_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxMines.TextChanged
        'Check for entry being a number, if not prompt user and clear the text box
        If Not IsNumeric(txtboxMines.Text) Then
            MessageBox.Show("Please enter a number into the mines text box.", "Invalid Entry!", MessageBoxButtons.OK)
            txtboxMines.Text = 0
        End If
    End Sub

    Private Sub txtboxMoney_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxMoney.TextChanged
        'Check for entry being a number, if not prompt user and clear the text box
        If Not IsNumeric(txtboxMoney.Text) Then
            MessageBox.Show("Please enter a number into the money text box.", "Invalid Entry!", MessageBoxButtons.OK)
            txtboxMoney.Text = 0
        End If
    End Sub
End Class