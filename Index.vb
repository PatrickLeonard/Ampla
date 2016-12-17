'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
'       Name: Patrick Leonard
'       Assignment: Ampla Planet Management
'       Class: CS300 
'       File: Index.vb
'
'      This is the planetary indexes class. It calculates the planetary indexes from 
'   the given budget decided by the user. 
'
'
'


Public Class Index

    'References to Doubles for the planet indexes
    Protected Population As Double
    Protected Income As Double
    Protected Food As Double
    Protected Environment As Double
    Protected starting_index As Double

    'Constructor assigning the indexes to their starting values
    Sub New()
        starting_index = 100

        Population = starting_index
        Income = starting_index
        Food = starting_index
        Environment = starting_index
    End Sub

    'Overloaded constructor to create an Index object from a saved game file
    Sub New(ByVal pop As Integer, ByVal inc As Integer, ByVal fd As Integer, ByVal env As Integer)
        starting_index = 100

        Population = pop
        Income = inc
        Food = fd
        Environment = env

    End Sub

    'Properties to get the individual indexes as needed
    Public Property Start() As Integer
        Get
            Return starting_index
        End Get
        Set(ByVal value As Integer)
            starting_index = value
        End Set
    End Property

    Public Property Pop() As Integer
        Get
            Return Population
        End Get
        Set(ByVal value As Integer)
            Population = value
        End Set
    End Property

    Public Property Inc() As Integer
        Get
            Return Income
        End Get
        Set(ByVal value As Integer)
            Income = value
        End Set
    End Property

    Public Property Fd() As Integer
        Get
            Return Food
        End Get
        Set(ByVal value As Integer)
            Food = value
        End Set
    End Property

    Public Property Enviro() As Integer
        Get
            Return Environment
        End Get
        Set(ByVal value As Integer)
            Environment = value
        End Set
    End Property

    'Calculates the indexes based on budget input parameters from the user's decisions
    Function Calculate_Indexes(ByVal sci As Integer, ByVal agr As Integer, ByVal edu As Integer,
                          ByVal pollute As Integer, ByVal min As Integer, ByVal total As Integer, ByVal mine_num As Integer) As Boolean

        'From normal play settings, the normal impact of mines is based on 5 on the field
        Dim norm_mine_imp As Integer = 5

        Dim mine_impact As Double = (mine_num / norm_mine_imp)

        Dim mining_investment As Double = (-0.02 * (agr / total)) + (-0.03 * (min / total))

        'There should be some negative impact for just having mines, not based on what is invested
        'So if mining_investment is 0, then he base impact will be -.01
        If mining_investment = 0 Then
            mining_investment = -0.01
        End If

        Environment = Environment * (Math.Pow((1 + (mining_investment * mine_impact) + (0.01 * (edu / total)) + (0.01 * (pollute / total))), 3.0))

        Food = (Environment / Food) * (Food * (Math.Pow((1 + (0.03 * (agr / total)) + (0.03 * (sci / total))), 3.0)))

        Population = (Food / Population) * (Population * (Math.Pow((1 + (0.03 * (agr / total)) + (0.01 * (sci / total)) + (-0.012 * (edu / total))), 3.0)))

        Income = Income * (Math.Pow((1 + (0.01 * (sci / total)) + (0.01 * (min / total)) + (0.01 * (edu / total))), 3.0))

        'If the environment drops below 50, the planet is uninhabitable, return false and game is over
        'If above 50, return true, and the planet is still inhabitable
        If Environment > 50 Then
            Return True
        Else
            Return False
        End If

    End Function

    'Save function to write the index member variables to the save file
    Sub Save(ByRef file As System.IO.StreamWriter)

        Dim pop, inc, fd, env As String

        'Assign the member variables to strings
        pop = Population.ToString
        inc = Income.ToString
        fd = Food.ToString
        env = Environment.ToString

        'Write the strings to the save file
        file.WriteLine(pop)
        file.WriteLine(inc)
        file.WriteLine(fd)
        file.WriteLine(env)


    End Sub

End Class

