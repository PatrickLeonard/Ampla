'Name: Lou Saechao
'Team Name: Any Ideas
'Class: CS300
'Date: 8/21/2013
'Purpose: purpose of this form is to setting and getting the values for the 
''''''''' different projects. it also does the calculations of the total after project allocation

Public Class CalculateBudget_class
    Private sci As Integer 'variable holding science allocation
    Private pollution As Integer 'variable holding pollution allocation
    Private edu As Integer 'variable holding education allocation
    Private agri As Integer 'variable holding agriculture allocation
    Private mine As Integer 'variable holding mine allocation
    Public start As Integer 'variable holding starting amount 
    Public total As Integer 'variable holding total before/after allocation/interation
    Protected science_prev As Integer 'holds prev allocation for science
    Private pollution_prev As Integer 'holds prev allocation for pollution control
    Private education_prev As Integer 'holds prev allocation for education
    Private mine_prev As Integer 'holds prev allocation for mining
    Private agri_prev As Integer 'holds prev allocation for agriculture
    Private cycle As Integer 'holds cycle budget
    Private cycle_prev As Integer 'holds prev allocation for cycle budget
    Protected unallocated As Integer
    Protected income As Integer

    Public Sub New(ByVal money As Integer)
        cycle = money
        total = money
        cycle_prev = 0
    End Sub
    Public Sub New(ByVal prevA As Integer, ByVal prevM As Integer, ByVal prevP As Integer, ByVal prevE As Integer,
                   ByVal prevS As Integer, ByVal prevCycle As Integer, ByVal thisCycle As Integer, ByVal prevUn As Integer)
        'every NEW object of calculate budget, you can assign a starting amount
        'when loading saved game, it will create a new object with these parameters that will assign to the variables.
        agri_prev = prevA
        mine_prev = prevM
        pollution_prev = prevP
        education_prev = prevE
        science_prev = prevS
        cycle_prev = prevCycle
        cycle = thisCycle
        unallocated = prevUn
        total = cycle

    End Sub
    Public Sub save_budget(ByRef file As System.IO.StreamWriter) 'saves users budget info
        Dim A, M, E, P, S, C, PC, U As String

        A = agri_prev.ToString 'agriculture
        M = mine_prev.ToString 'mines
        P = pollution_prev.ToString 'Pollution control
        E = education_prev.ToString 'education
        S = science_prev.ToString 'science
        C = cycle.ToString 'Cycle budget
        PC = cycle_prev.ToString  'Previous Cycle budget
        U = unallocated.ToString 'Unallocated budget

        file.WriteLine(A)
        file.WriteLine(M)
        file.WriteLine(P)
        file.WriteLine(E)
        file.WriteLine(S)
        file.WriteLine(PC)
        file.WriteLine(C)
        file.WriteLine(U)
    End Sub

    Public Property sci_property() As Integer 'science property that SETS and GETS the sci value
        Get
            Return Me.sci
        End Get
        Set(ByVal value As Integer)
            Me.sci = value
        End Set
    End Property

    Public Property agri_property() As Integer 'agriculture property that SETS and GETS the agri value
        Get
            Return Me.agri
        End Get
        Set(ByVal value As Integer)
            Me.agri = value
        End Set
    End Property

    Public Property pollution_property() As Integer 'pollution property that SETS and GETS the pollution value
        Get
            Return Me.pollution
        End Get
        Set(ByVal value As Integer)
            Me.pollution = value
        End Set
    End Property

    Public Property edu_property() As Integer 'education property that SETS and GETS the edu value
        Get
            Return Me.edu
        End Get
        Set(ByVal value As Integer)
            Me.edu = value
        End Set
    End Property

    Public Property mine_property() As Integer 'mining property that SETS and GETS the mine value
        Get
            Return Me.mine
        End Get
        Set(ByVal value As Integer)
            Me.mine = value
        End Set
    End Property
    Public Property cycle_property() As Integer 'cycle property that sets and gets the money for the cycle.
        Get
            Return Me.cycle
        End Get
        Set(ByVal value As Integer)
            Me.cycle = value
        End Set
    End Property
    Public Property prev_cycle_property() As Integer 'this property sets and gets the prev cycle budget
        Get
            Return cycle_prev
        End Get
        Set(ByVal value As Integer)
            cycle_prev = value
        End Set
    End Property
    Public Property unallocated_budget() As Integer 'this sets and gets the unallocated budget
        Get
            Return unallocated
        End Get
        Set(ByVal value As Integer)
            unallocated = value
        End Set
    End Property

    Public Sub calculate() 'calculates the unallocated money 

        total = cycle - (sci + pollution + edu + agri + mine)

    End Sub


    Public Sub commit() 'stores users allocation to variables.

        agri_prev = agri_property()
        mine_prev = mine_property()
        education_prev = edu_property()
        pollution_prev = pollution_property()
        science_prev = sci_property()
        cycle_prev = cycle_property()

        unallocated = total

        sci = 0
        pollution = 0
        edu = 0
        agri = 0
        mine = 0
    End Sub

    Public ReadOnly Property GetAgri() As Integer 'returns only the agriculture's value
        Get
            Return Me.agri_prev
        End Get
    End Property

    Public ReadOnly Property GetSci() As Integer 'returns only the science's value
        Get
            Return Me.science_prev
        End Get
    End Property

    Public ReadOnly Property GetPoll() As Integer 'returns only the pollution control's value
        Get
            Return Me.pollution_prev
        End Get
    End Property

    Public ReadOnly Property GetEdu() As Integer 'returns only the educations's value
        Get
            Return Me.education_prev
        End Get
    End Property

    Public ReadOnly Property GetMine() As Integer 'returns only the mining's value
        Get
            Return Me.mine_prev
        End Get
    End Property

    Sub Receive_Income(ByVal cash As Integer) 'receives what the user has made from mining
        income = cash
    End Sub

    Sub Calculate_New_Budget() 'adds money from mining to the unallocated funds.
        cycle = unallocated + income
        total = cycle
    End Sub
End Class

