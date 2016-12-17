'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
'       Name: Patrick Leonard
'       Assignment: Ampla Planet Management
'       Class: CS300 
'       File: Game.vb 
'
'       This is the Game Class. This represents the bulk of the Model/Control portion
'   of this game. It is responsible for Saving and Loading, drawing the map field,
'   directing the flow of parameters from user inputs of the budget and options to calculations
'   made by the mines and index. 
'

Public Class Game

    'References to needed objects and types for the game
    Protected map_Width, map_Height, mine_num, iteration As Integer
    Protected global_index As Index
    Protected sector_array As Sector(,)
    Protected mine_list As List(Of Mine)
    Protected P1 As Point = New Point()
    Protected sect As Sector
    Protected SL As Integer
    Protected Main_Graphics As Graphics
    Protected mine_step As Integer
    Protected mine1 As Mine
    Protected clip_Rect As Rectangle
    Protected random As Random = New Random()
    Protected indicator As Indicator_class
    Protected budget_dialog As Budget
    Protected budget_class As CalculateBudget_class
    Protected iteration_income As Integer
    Protected corrupted As Boolean

    'Overloaded constructor, accepts Graphics object, the number of mines, and the starting money
    'of the game.
    Public Sub New(ByRef graphics As Graphics, ByVal mine As Integer, ByVal money As Integer)
        'No save file is loaded, so cannot be corrupt
        corrupted = False

        'Set the dimensions of the map field
        map_Width = 700
        map_Height = 500

        'Assign the number of mines selected in Options
        mine_num = mine

        'Create an array of Sector objects
        sector_array = New Sector(map_Width / 4, map_Height / 4) {}

        'Create a linked list of mines
        mine_list = New List(Of Mine)

        'Create an Index object
        global_index = New Index()

        'Assign parameter graphics reference to member reference
        Main_Graphics = graphics

        'Create a new indicator instance
        indicator = New Indicator_class(global_index)

        'Create a new budget_dialog instance
        budget_dialog = New Budget(money)

        SL = 4
        mine_step = 1

        'Set the rectangle to represent the clip drawing area of the map field
        clip_Rect.X = 0
        clip_Rect.Y = 0
        clip_Rect.Width = map_Width + SL
        clip_Rect.Height = map_Height + SL

        Main_Graphics.SetClip(clip_Rect)


        'Create the Sector objects and place them in the appropriate place in the array
        For X = 0 To map_Width Step SL
            For Y = 0 To map_Height Step SL
                P1.X = X
                P1.Y = Y
                sect = New Sector(P1, Main_Graphics)
                sector_array(X / SL, Y / SL) = sect
            Next
        Next

        'Create the mines in random position on the map field
        'and add them to the linked list of mines
        For X = 0 To (mine_num - 1) Step mine_step
            P1.X = random.Next(0, map_Width)
            P1.Y = random.Next(0, map_Height)
            mine1 = New Mine(P1, Main_Graphics)
            mine_list.Add(mine1)
        Next

    End Sub

    'Overloaded Constructor to create a Game object on Load with read_file StreamReader as parameter
    'to create objects with parameters loaded from the file
    Public Sub New(ByRef graphics As Graphics, ByRef read_file As System.IO.StreamReader)
        'Save file may be corrupted, but isn't found to be yet
        corrupted = False
        'Create string and double dims to check for corrupt save file
        Dim mine_num_string, tox_string, pop_string, fd_string, inc_string, env_string, mine_inc_string, p1_x, p1_y As String
        Dim tox, pop, fd, inc, env, mine_inc As Double

        'Create string and integer dims to check for corrupt save file
        Dim prevA_string, prevE_string, prevM_string, prevS_string, prevP_string, prevCycle_string, thisCycle_string, prevUn_string As String
        Dim prevA, prevE, prevM, prevS, prevP, prevCycle, thisCycle, prevUn As Integer

        map_Width = 700
        map_Height = 500
        sector_array = New Sector(map_Width / 4, map_Height / 4) {}
        mine_list = New List(Of Mine)
        Main_Graphics = graphics

        SL = 4
        mine_step = 1

        clip_Rect.X = 0
        clip_Rect.Y = 0
        clip_Rect.Width = map_Width + SL
        clip_Rect.Height = map_Height + SL

        Main_Graphics.SetClip(clip_Rect)

        For X = 0 To map_Width Step SL
            For Y = 0 To map_Height Step SL
                P1.X = X
                P1.Y = Y
                sect = New Sector(P1, Main_Graphics)
                sector_array(X / SL, Y / SL) = sect
            Next
        Next

        'Read from file and assign to string dims to check for corruption
        mine_num_string = read_file.ReadLine()

        'Mine_num must be greater than 0 and less than or equal to 20
        If IsNumeric(mine_num_string) Then
            mine_num = mine_num_string
            If mine_num < 0 Or mine_num > 20 Then
                corrupted = True
            End If
        Else
            corrupted = True
        End If

        pop_string = read_file.ReadLine()

        'Call Check_Corruption_Int with string to check for corruption and return the proper value
        pop = Check_Corruption_Dbl(pop_string)

        fd_string = read_file.ReadLine()

        fd = Check_Corruption_Dbl(fd_string)

        inc_string = read_file.ReadLine()

        inc = Check_Corruption_Dbl(inc_string)

        env_string = read_file.ReadLine()

        env = Check_Corruption_Dbl(env_string)

        'If the file is not considered corrupt yet
        If Not corrupted Then
            'Create objects with references read from file
            global_index = New Index(pop, inc, fd, env)

            indicator = New Indicator_class(global_index)

        End If

        For X = 0 To (mine_num - 1) Step mine_step

            tox_string = read_file.ReadLine()
            
            tox = Check_Corruption_Dbl(tox_string)

            mine_inc_string = read_file.ReadLine()

            mine_inc = Check_Corruption_Dbl(mine_inc_string)

            'The X and Y value of the points has a specific interval it must fall into
            'so there is no function to call
            p1_x = read_file.ReadLine()
            If IsNumeric(p1_x) Then
                P1.X = p1_x
                If P1.X < 0 Or P1.X > map_Width Then
                    corrupted = True
                End If
            Else
                corrupted = True
            End If

            p1_y = read_file.ReadLine()
            If IsNumeric(p1_y) Then
                P1.Y = p1_y
                If P1.Y < 0 Or P1.Y > map_Height Then
                    corrupted = True
                End If
            Else
                corrupted = True
            End If

            If Not corrupted Then
                mine1 = New Mine(P1, Main_Graphics, tox, mine_inc)
                mine_list.Add(mine1)
            End If

        Next


        prevA_string = read_file.ReadLine()

        prevA = Check_Corruption_Int(prevA_string)

        prevM_string = read_file.ReadLine()

        prevM = Check_Corruption_Int(prevM_string)

        prevP_string = read_file.ReadLine()

        prevP = Check_Corruption_Int(prevP_string)

        prevE_string = read_file.ReadLine()

        prevE = Check_Corruption_Int(prevE_string)

        prevS_string = read_file.ReadLine()

        prevS = Check_Corruption_Int(prevS_string)

        prevCycle_string = read_file.ReadLine()

        prevCycle = Check_Corruption_Int(prevCycle_string)

        thisCycle_string = read_file.ReadLine()

        thisCycle = Check_Corruption_Int(thisCycle_string)

        prevUn_string = read_file.ReadLine()

        prevUn = Check_Corruption_Int(prevUn_string)

        'If the file is not corrupted yet, then create the last game object
        If Not corrupted Then
            budget_dialog = New Budget(prevA, prevM, prevP, prevE, prevS, prevCycle, thisCycle, prevUn)
        End If

    End Sub

    'Return corrupted so Main will know if the save game file has been corrupted
    Public ReadOnly Property corrupt() As Boolean
        Get
            Return corrupted
        End Get
    End Property

    'Check for save file corruption, set corrupted to true as needed, and return an Integer
    Private Function Check_Corruption_Int(ByVal input_string As String) As Integer
        Dim input_int As Integer = 0

        If IsNumeric(input_string) Then
            input_int = input_string
            If input_int < 0 Then
                corrupted = True
                Return input_int
            End If
            Return input_int
        Else
            Return 0
            corrupted = True
        End If

    End Function

    'Check for save file corruption, set corrupted to true as needed, and return a Double
    Private Function Check_Corruption_Dbl(ByVal input_string As String) As Double
        Dim input_dbl As Double = 0

        If IsNumeric(input_string) Then
            input_dbl = input_string
            If input_dbl < 0 Then
                corrupted = True
                Return input_dbl
            End If
            Return input_dbl
        Else
            Return 0
            corrupted = True
        End If

    End Function

    'Draw_Field() draws the map field without creating new objects
    Public Sub Draw_Field()

        For x = 0 To map_Width Step SL
            For y = 0 To map_Height Step SL
                sector_array(x / SL, y / SL).Draw_Sector()
            Next
        Next


        For Each mine In mine_list
            mine.draw_mine()
        Next

    End Sub

    'Clear_Field clears the map field in preparation of a clean redraw 
    Public Sub Clear_Field()
        Main_Graphics.Clear(Color.White)
    End Sub

    'Save_Game() creates a SaveFileDialog object and allows the user to select where the save
    'file is saved and the name of the file. Then it calls the save function of subsystem objects
    'to write their parameters to the save file.
    Public Function Save_Game(ByVal iteration As Integer) As Boolean
        Dim file_save_dialog As SaveFileDialog = New SaveFileDialog()
        Dim file_result As DialogResult
        Dim file_name As String
        Dim file As System.IO.StreamWriter
        Dim overwrite As Boolean = False

        'Set the filter, title, and RestoreDirector of the SaveFileDialog
        file_save_dialog.Filter = "Ampla Save Games|*.sav"
        file_save_dialog.Title = "Ampla Save Game"
        file_save_dialog.RestoreDirectory = True

        file_result = file_save_dialog.ShowDialog()

        'If a file location and name have been selected
        If file_result = DialogResult.OK Then
            file_name = file_save_dialog.FileName

            'Check to see if the file exists, if it does delete it and then re-write the file
            If FileIO.FileSystem.FileExists(file_name) Then
                My.Computer.FileSystem.DeleteFile(file_name)
            End If

            'Create a OpenTextFileWriter to write to the file
            file = My.Computer.FileSystem.OpenTextFileWriter(file_name, True)

            'Write the iteration and number of mines to the file first
            file.WriteLine(iteration)
            file.WriteLine(mine_num)

            'Then call object Save functions with a reference to the OpenTextFileWriter
            global_index.Save(file)

            For Each Mine In mine_list
                Mine.Save(file)
            Next

            budget_dialog.Save(file)

        End If

        'If a file has been chosen, close the OpenTextFileWriter to finish writing to the file
        If Not IsNothing(file) Then
            file.Close()

            'Tell the user the game has been saved
            MessageBox.Show("Game Saved", "Game Saved",
                        System.Windows.Forms.MessageBoxButtons.OK)

            'Dispose the of SaveFileDialog box
            file_save_dialog.Dispose()

            'Return true that the game has been saved
            Return True
        End If

        'If cancel, dispose of SaveFileDialog and return false
        file_save_dialog.Dispose()
        Return False
    End Function

    'Wrapper function for displaying planetary indicators
    Sub Indicators_Display()
        indicator.Display_Indicators()
    End Sub

    'Display the budget dialog, and accept the budget_class reference to receive the decisions
    'of the user.
    Function Display_Budget() As DialogResult
        Dim budget_result As DialogResult

        budget_result = budget_dialog.ShowDialog()

        budget_class = budget_dialog.trans()

        'Return the dialog result of the user
        Return budget_result

    End Function

    'Calculate the global indexes, return true if game continues, and false if uninhabitable
    Function Calculate_Indexes() As Boolean


        Return global_index.Calculate_Indexes(budget_class.GetSci, budget_class.GetAgri,
                                              budget_class.GetEdu, budget_class.GetPoll,
                                              budget_class.GetMine, budget_class.cycle_property, mine_num)

    End Function

    'For each mine in the list calculate the mine toxicity
    Sub Calculate_Mine_Toxicity()

        For Each Mine In mine_list
            Mine.calc_toxicity(global_index)
        Next

    End Sub

    'For each mine in the list calculate the mine income value
    Sub Calculate_Mine_Income()

        For Each Mine In mine_list
            Mine.calc_income(global_index)

            iteration_income += Mine.inc()
        Next

        'Pass the income from the mines to the budget to be used in the next iteration
        budget_class.Receive_Income(iteration_income)
        budget_class.Calculate_New_Budget()

        iteration_income = 0

    End Sub

    'If the max iterations has been reached, display to the user the game is complete and will close
    'then display the final planet indicators
    Sub Game_Complete()

        MessageBox.Show("You have completed the necessary number of iterations. Click OK to see the" +
                        " final planetary indicators. The game is complete and will close 3 seconds after drawing the final map.", "Game Complete", System.Windows.Forms.MessageBoxButtons.OK)

        indicator.Display_Indicators()

        Draw_Field()

    End Sub

    'If the planet is uninhabitable, the game is over. Tell the user
    Sub Game_Failure()

        MessageBox.Show("The planet of Ampla has become uninhabitable due to your mismanagement. Game Over. This game will close 3 seconds after drawing the final map." +
                        " Thanks for playing (*^_^)y", "Management Failure", System.Windows.Forms.MessageBoxButtons.OK)

    End Sub

End Class
