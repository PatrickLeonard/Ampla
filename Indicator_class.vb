'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
'       Name: Patrick Leonard
'       Assignment: Ampla Planet Management
'       Class: CS300 
'       File: Indicator_class.vb 
'
'       This is the Indicator_class class. It rounds the Indexes to the nearest integer, and 
'   then assigns them to the corresponding labels.
'   
'   
'

Public Class Indicator_class

    'Create a reference to an Index, and a new instance of Indicator form
    Protected index As Index
    Protected ind_dialog As New Indicators()

    'Overloaded constructor with the game Index by reference
    Sub New(ByRef ind As Index)
        index = ind
    End Sub

    'Assign the indexes to the label (rounded) and then show the dialog box 
    'displaying the indicators to the user
    Sub Display_Indicators()

        ind_dialog.Pop_Display.Text = Math.Round(index.Pop)
        ind_dialog.Inc_Display.Text = Math.Round(index.Inc)
        ind_dialog.Fd_Display.Text = Math.Round(index.Fd)
        ind_dialog.Pol_Display.Text = Math.Round(index.Enviro)

        ind_dialog.ShowDialog()

    End Sub

End Class
