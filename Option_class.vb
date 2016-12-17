'Name: Lou Saechao
'Team Name: Any Ideas
'Class: CS300
'Date: 8/21/2013
'Purpose: this class takes care of saving the money and number of mines 
''''''''''from what the user selects from the options. 


Public Class Option_class

    Dim Number_Mines As Integer 'holds number of mines(gets assigned by preset settings easy,normal,hard or from advsettings)
    Dim Amount_Money As Integer 'holds amount of starting money(gets assigned by preset settings easy,normal,hard, or from advsettings)

    Sub New()

    End Sub
    
    Sub New(ByVal SavedMoney As Integer) 'constructor used when loading saved game's last income or when user decides to select their own parameters
        Amount_Money = SavedMoney
    End Sub
    
    Public Property NumMine() As Integer 'sets and gets number of mines depending on users selection in options
        Get
            Return Me.Number_Mines
        End Get
        Set(ByVal value As Integer)
            Me.Number_Mines = value
        End Set
    End Property

    Public Property AmtMoney() As Integer 'sets and gets amount of money depending on users selection in options
        Get
            Return Me.Amount_Money
        End Get
        Set(ByVal value As Integer)
            Me.Amount_Money = value
        End Set
    End Property


End Class
