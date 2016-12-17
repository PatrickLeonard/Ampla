'Name: Lou Saechao
'Team Name: Any Ideas
'Class: CS300
'Date: 8/21/2013
'Purpose: This is the budget form that allows user to enter their budget allocation.
''''''''''allow user to either commit, reset, or exit.

Public Class Budget
    Protected Transaction As CalculateBudget_class

    Public ReadOnly Property trans() As CalculateBudget_class
        Get
            Return Transaction
        End Get
    End Property

    Public Sub New(ByVal money As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Transaction = New CalculateBudget_class(money)

    End Sub

    Public Sub New(ByVal prevA As Integer, ByVal prevM As Integer, ByVal prevP As Integer, ByVal prevE As Integer,
                   ByVal prevS As Integer, ByVal prevCycle As Integer, ByVal thisCycle As Integer, ByVal prevUn As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Transaction = New CalculateBudget_class(prevA, prevM, prevP, prevE, prevS, prevCycle, thisCycle, prevUn)

        Assign_Labels()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'on budget form load, unallocated funds is assigning the starting amount for allocation
        lblUnallocatedFunds.Text = Transaction.cycle_property
        lblCycleBudget.Text = Transaction.cycle_property

    End Sub

    Private Sub txtboxSci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxSci.TextChanged

        'as user is entering his or her allocation, it is calculating the math of how much unallocated funds are left
        'if user deletes whats in textbox, it would set it equal to 0 to give back what was allocated
        If String.IsNullOrEmpty(txtboxSci.Text) Then
            Transaction.sci_property = 0
        Else
            'Check for entry being a number, if not prompt user and clear the text box
            If IsNumeric(txtboxSci.Text) Then
                'Ensure the user isn't entering negative numbers into the budget
                If CInt(txtboxSci.Text) < 0 Then
                    MessageBox.Show("Please enter a number greater than 0.", "Invalid Entry!", MessageBoxButtons.OK)
                    txtboxSci.Text = 0
                Else
                    Transaction.sci_property = txtboxSci.Text
                End If
            Else
                MessageBox.Show("Please enter a number into the budget text box.", "Invalid Entry!", MessageBoxButtons.OK)
                txtboxSci.Text = 0
            End If
        End If

        Transaction.calculate()

        'during calculation, if it is less than 0 it will prompt user and will set that textbox equal to 0
        'will then allow user to re enter a different value.
        If Transaction.total < 0 Then
            MessageBox.Show("OVER THE LIMIT! - Science")
            txtboxSci.Text = Nothing
        End If

        lblUnallocatedFunds.Text = Transaction.total


    End Sub
    Private Sub txtboxAgri_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxAgri.TextChanged

        If String.IsNullOrEmpty(txtboxAgri.Text) Then
            Transaction.agri_property = 0
        Else
            'Check for entry being a number, if not prompt user and clear the text box
            If IsNumeric(txtboxAgri.Text) Then
                'Ensure the user isn't entering negative numbers into the budget
                If CInt(txtboxAgri.Text) < 0 Then
                    MessageBox.Show("Please enter a number greater than 0.", "Invalid Entry!", MessageBoxButtons.OK)
                    txtboxAgri.Text = 0
                Else
                    Transaction.agri_property = txtboxAgri.Text
                End If
            Else
                MessageBox.Show("Please enter a number into the budget text box.", "Invalid Entry!", MessageBoxButtons.OK)
                txtboxAgri.Text = 0
            End If
        End If

        Transaction.calculate()

        If Transaction.total < 0 Then
            MessageBox.Show("OVER THE LIMIT! - Agriculture")
            txtboxAgri.Text = Nothing
        End If

        lblUnallocatedFunds.Text = Transaction.total


    End Sub
    Private Sub txtboxPollution_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxPollution.TextChanged

        If String.IsNullOrEmpty(txtboxPollution.Text) Then
            Transaction.pollution_property = 0
        Else
            'Check for entry being a number, if not prompt user and clear the text box
            If IsNumeric(txtboxPollution.Text) Then
                'Ensure the user isn't entering negative numbers into the budget
                If CInt(txtboxPollution.Text) < 0 Then
                    MessageBox.Show("Please enter a number greater than 0.", "Invalid Entry!", MessageBoxButtons.OK)
                    txtboxPollution.Text = 0
                Else
                    Transaction.pollution_property = txtboxPollution.Text
                End If
            Else
                MessageBox.Show("Please enter a number into the budget text box.", "Invalid Entry!", MessageBoxButtons.OK)
                txtboxPollution.Text = 0
            End If
        End If

        Transaction.calculate()

        If Transaction.total < 0 Then
            MessageBox.Show("OVER THE LIMIT! - Pollution Control")
            txtboxPollution.Text = Nothing
        End If

        lblUnallocatedFunds.Text = Transaction.total

    End Sub
    Private Sub txtboxEdu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxEdu.TextChanged

        If String.IsNullOrEmpty(txtboxEdu.Text) Then
            Transaction.edu_property = 0
        Else
            'Check for entry being a number, if not prompt user and clear the text box
            If IsNumeric(txtboxEdu.Text) Then
                'Ensure the user isn't entering negative numbers into the budget
                If CInt(txtboxEdu.Text) < 0 Then
                    MessageBox.Show("Please enter a number greater than 0.", "Invalid Entry!", MessageBoxButtons.OK)
                    txtboxEdu.Text = 0
                Else
                    Transaction.edu_property = txtboxEdu.Text
                End If
            Else
                MessageBox.Show("Please enter a number into the budget text box.", "Invalid Entry!", MessageBoxButtons.OK)
                txtboxEdu.Text = 0
            End If
        End If

        Transaction.calculate()

        If Transaction.total < 0 Then
            MessageBox.Show("OVER THE LIMIT! - Education")
            txtboxEdu.Text = Nothing
        End If

        lblUnallocatedFunds.Text = Transaction.total


    End Sub

    Private Sub txtboxMine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxMine.TextChanged

        If String.IsNullOrEmpty(txtboxMine.Text) Then
            Transaction.mine_property = 0
        Else
            'Check for entry being a number, if not prompt user and clear the text box
            If IsNumeric(txtboxMine.Text) Then
                'Ensure the user isn't entering negative numbers into the budget
                If CInt(txtboxMine.Text) < 0 Then
                    MessageBox.Show("Please enter a number greater than 0.", "Invalid Entry!", MessageBoxButtons.OK)
                    txtboxMine.Text = 0
                Else
                    Transaction.mine_property = txtboxMine.Text
                End If
            Else
                MessageBox.Show("Please enter a number into the budget text box.", "Invalid Entry!", MessageBoxButtons.OK)
                txtboxMine.Text = 0
            End If
        End If

        Transaction.calculate()

        If Transaction.total < 0 Then
            MessageBox.Show("OVER THE LIMIT! - Mining")
            txtboxMine.Text = Nothing
        End If

        lblUnallocatedFunds.Text = Transaction.total


    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'sets all textbox to zero
        txtboxAgri.Text = 0
        txtboxEdu.Text = 0
        txtboxMine.Text = 0
        txtboxPollution.Text = 0
        txtboxSci.Text = 0

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Dim selection As DialogResult

        selection = MessageBox.Show("ARE YOU SURE?!", "Final Answer?", MessageBoxButtons.OKCancel)
        If selection = DialogResult.OK Then
            Transaction.commit()
            'assigns the last iteration's allocation to each label under last iteration
            Assign_Labels()
        
            'assigning 0 to all text box
            txtboxAgri.Text = 0
            txtboxEdu.Text = 0
            txtboxMine.Text = 0
            txtboxPollution.Text = 0
            txtboxSci.Text = 0

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If

    End Sub

    Public Sub Save(ByRef file As System.IO.StreamWriter)
        Transaction.save_budget(file)
    End Sub

    Private Sub Assign_Labels()
        lblAgri.Text = Transaction.GetAgri
        lblEdu.Text = Transaction.GetEdu
        lblMine.Text = Transaction.GetMine
        lblPoll.Text = Transaction.GetPoll
        lblSci.Text = Transaction.GetSci
        lblLastCyc.Text = Transaction.prev_cycle_property
        lblLastUnAll.Text = Transaction.unallocated_budget
    End Sub
End Class
