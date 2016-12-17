'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
'       Name: Patrick Leonard
'       Assignment: Ampla Planet Management
'       Class: CS300 
'       File: New_Load_Game.vb
'
'      This is the form to allows the user to choose to start a new game, 
'   load a game, or cancel choosing to load or create new.
'   Cancel = Cancel     New = No     Load = Yes
'
'


Public Class New_Load_Game

    'Return the appropriate dialog result that corresponds to the respective button 
    'Cancel = Cancel     New = No     Load = Yes
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub New_Game_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_Game.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub

    Private Sub Load_Game_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Load_Game.Click
        Me.DialogResult = DialogResult.Yes
        Me.Close()
    End Sub

End Class