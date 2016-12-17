'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
'       Name: Patrick Leonard
'       Assignment: Ampla Planet Management
'       Class: CS300 
'       File: Main.vb
'
'      This is the main game form. Contains buttons to control game flow
'   and the display of the game field. Also handles loading and saving
'   dialogs. 
'
'

'Import needed system packages
Imports System.Drawing
Imports Microsoft.VisualBasic.PowerPacks

Public Class Main

    'Member references to needed game classes and types
    Protected game As Game
    Protected saved, corrupted As Boolean
    Protected iteration As Integer
    Protected max_turns As Integer
    Protected count As Integer
    Protected WithEvents timer As Timer
    Protected options As Options
    Protected option_class As Option_class

    'On form closing, check for if the game has been saved, and prompt the user to save 
    'if the game hasn't been saved.
    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Dialog result to catch results of save prompt
        Dim confirm_save_on_exit As DialogResult

        'If the game hasn't been saved prompt the user
        If saved = False Then
            confirm_save_on_exit = MessageBox.Show("Current game not saved. Would you like to save?", "Save Game?",
                                    System.Windows.Forms.MessageBoxButtons.YesNoCancel)

            'If the user wants to save, call Save_Game()
            If confirm_save_on_exit = DialogResult.Yes Then
                game.Save_Game(iteration)

                'If the user selects cancel, then cancel the exit
            ElseIf  confirm_save_on_exit = DialogResult.Cancel Then
                    e.Cancel = True
            End If
        End If
    End Sub

    'Upon loading the Main Form, set some basic parameters, and disable buttons that 
    'shouldn't be used until the game begins
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        saved = True   'Presume that the user can exit without having to save since the 
        'game hasn't began

        'Corrupted file hasn't been loaded yet
        corrupted = False

        'Start game with no iterations complete
        iteration = 0
        'Set the max number of iterations to 10
        max_turns = 10

        'Timer and count to exit the game automatically after play
        count = 5
        timer = New Timer()

        'Disable buttons that shouldn't be used unti the game actually begins
        Me.Indicator.Enabled = False
        Me.Draw.Enabled = False
        Me.Budget.Enabled = False
        Me.Save.Enabled = False

    End Sub

    'Begin form close event on Exit button click
    Private Sub Quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quit.Click
        Me.Close()
    End Sub

    'Allow the player to draw the game map/field on click of the button
    Private Sub Draw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Draw.Click
        game.Draw_Field()
    End Sub

    'Upon clicking the save button call the Save_Game()
    'Then clear the game field and redraw the game field
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        saved = game.Save_Game(iteration)

        game.Clear_Field()

        game.Draw_Field()
    End Sub

    'Upon New/Load button click, bring up the New_Load_Game form and let the user decide 
    'to start a new game or load a previously saved game
    Private Sub loadGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadGame.Click
        'Create an instance of a New_Load_Game form, references to different 
        'dialog results, an instance of an OpenFileDialog object, and an IO StreamReader 
        'to load parameters from a save file
        Dim new_load As New_Load_Game = New New_Load_Game()
        Dim new_load_result, confirm_new, load_dialog_result As DialogResult
        Dim load_dialog As OpenFileDialog = New OpenFileDialog()
        Dim read_stream As System.IO.StreamReader
        Dim iteration_string As String

        'Set the OpenFileDialog filter, title, and catch the result of the 
        'New_Load_Game form dialog
        load_dialog.Filter = "Ampla Save Files|*.sav"

        load_dialog.Title = "Ampla Load Game"

        new_load_result = new_load.ShowDialog()

        'If the user chooses to start a new game, ask to save the current game 
        'if a game has been started and not saved
        If new_load_result = DialogResult.No Then
            If saved = True Then
                'If the game has been saved (or one not started)
                'then open the Options form to begin selecting game settings
                options = New Options()

                options.ShowDialog()

                option_class = options.opt()

                'Begin a new game with the selected options settings
                game = New Game(Me.CreateGraphics(), option_class.NumMine, option_class.AmtMoney)

                'Ensure that iteration starts at 0 for a new game
                iteration = 0

                'Alert the user that a New game has been loaded
                MessageBox.Show("New Game Loaded", "New Game Loaded",
                                        System.Windows.Forms.MessageBoxButtons.OK)
            Else

                'If the game hasn't been saved, ask the user if they want to save it
                confirm_new = MessageBox.Show("Current game not saved. Would you like to save?", "Save Game?",
                                                    System.Windows.Forms.MessageBoxButtons.YesNo)

                'If they choose to save call Save_Game(), and then being Options
                'and start a new game
                If confirm_new = DialogResult.Yes Then
                    game.Save_Game(iteration)

                    options = New Options()

                    options.ShowDialog()

                    option_class = options.opt()

                    game = New Game(Me.CreateGraphics(), option_class.NumMine, option_class.AmtMoney)

                    iteration = 0

                    MessageBox.Show("New Game Loaded", "New Game Loaded",
                                            System.Windows.Forms.MessageBoxButtons.OK)
                Else
                    'If they choose not to save, begin Options setting, and start a new game
                    options = New Options()

                    options.ShowDialog()

                    option_class = options.opt()

                    game = New Game(Me.CreateGraphics(), option_class.NumMine, option_class.AmtMoney)

                    iteration = 0

                    MessageBox.Show("New Game Loaded", "New Game Loaded",
                            System.Windows.Forms.MessageBoxButtons.OK)
                End If

            End If
        End If
        'If the user chooses to load a previously played game
        'then activate the OpenFileDialog
        If new_load_result = DialogResult.Yes Then
            'If the game has been saved (or hasn't been started) then allow the user
            'to load a previous game
            If saved = True Then
                load_dialog_result = load_dialog.ShowDialog()

                If load_dialog_result = DialogResult.OK Then
                    'If they save file has been selected, ensure the file exists
                    If FileIO.FileSystem.FileExists(load_dialog.FileName) Then
                        read_stream = New System.IO.StreamReader(load_dialog.FileName)

                        'Load the iteration from the file and assign to iteration_string variable
                        iteration_string = read_stream.ReadLine()

                        If IsNumeric(iteration_string) Then
                            iteration = CInt(iteration_string)
                            'If iteration is out of the proper range then the game file is corrupted
                            If iteration < 0 Or iteration > 9 Then
                                MessageBox.Show("Save file is corrupted! Please choose another file.", "Corrupted Save File!", System.Windows.Forms.MessageBoxButtons.OK)
                                corrupted = True
                            End If
                        Else
                            MessageBox.Show("Save file is corrupted! Please choose another file.", "Corrupted Save File!", System.Windows.Forms.MessageBoxButtons.OK)
                            corrupted = True
                        End If

                        If Not corrupted Then
                            'Create a new game using overloaded contructor to load game objects
                            'with parameters loaded from file.
                            game = New Game(Me.CreateGraphics, read_stream)

                            'If the game is corrupt, tell the user and set the game to Nothing, else tell them the game has been loaded
                            If game.corrupt Then
                                MessageBox.Show("Save file is corrupted! Please choose another file.", "Corrupted Save File!", System.Windows.Forms.MessageBoxButtons.OK)
                                game = Nothing
                            Else
                                'Let the user know a new game has been loaded
                                MessageBox.Show("Previous Game Loaded", "Previous Game Loaded",
                                            System.Windows.Forms.MessageBoxButtons.OK)
                            End If

                        End If
                    End If
                End If
            Else
                'The game hasn't been saved, so ask the user if they want to save it
                confirm_new = MessageBox.Show("Current game not saved. Would you like to save?", "Save Game?",
                                                    System.Windows.Forms.MessageBoxButtons.YesNo)

                'If they choose to save call Save_Game()
                If confirm_new = DialogResult.Yes Then
                    game.Save_Game(iteration)

                    load_dialog_result = load_dialog.ShowDialog()

                    'Load the file if it exists, and then begin a new game with overloaded 
                    'constructor
                    If load_dialog_result = DialogResult.OK Then
                        If FileIO.FileSystem.FileExists(load_dialog.FileName) Then
                            read_stream = New System.IO.StreamReader(load_dialog.FileName)

                            'Load the iteration from the file and assign to iteration_string variable
                            iteration_string = read_stream.ReadLine()

                            If IsNumeric(iteration_string) Then
                                iteration = CInt(iteration_string)
                                'If iteration is out of the proper range then the game file is corrupted
                                If iteration < 0 Or iteration > 9 Then
                                    MessageBox.Show("Save file is corrupted! Please choose another file.", "Corrupted Save File!", System.Windows.Forms.MessageBoxButtons.OK)
                                    corrupted = True
                                End If
                            Else
                                MessageBox.Show("Save file is corrupted! Please choose another file.", "Corrupted Save File!", System.Windows.Forms.MessageBoxButtons.OK)
                                corrupted = True
                            End If

                            If Not corrupted Then
                                'Create a new game using overloaded contructor to load game objects
                                'with parameters loaded from file.
                                game = New Game(Me.CreateGraphics, read_stream)

                                'If the game is corrupt, tell the user and set the game to Nothing, else tell them the game has been loaded
                                If game.corrupt Then
                                    MessageBox.Show("Save file is corrupted! Please choose another file.", "Corrupted Save File!", System.Windows.Forms.MessageBoxButtons.OK)
                                    game = Nothing
                                Else
                                    'Let the user know a new game has been loaded
                                    MessageBox.Show("Previous Game Loaded", "Previous Game Loaded",
                                                System.Windows.Forms.MessageBoxButtons.OK)
                                End If
                            End If
                        End If

                    End If
                Else
                    'If the game has been saved, then load the game without save prompt
                    load_dialog_result = load_dialog.ShowDialog()

                    If load_dialog_result = DialogResult.OK Then
                        If FileIO.FileSystem.FileExists(load_dialog.FileName) Then
                            read_stream = New System.IO.StreamReader(load_dialog.FileName)

                            'Load the iteration from the file and assign to iteration_string variable
                            iteration_string = read_stream.ReadLine()

                            If IsNumeric(iteration_string) Then
                                iteration = CInt(iteration_string)
                                'If iteration is out of the proper range then the game file is corrupted
                                If iteration < 0 Or iteration > 9 Then
                                    MessageBox.Show("Save file is corrupted! Please choose another file.", "Corrupted Save File!", System.Windows.Forms.MessageBoxButtons.OK)
                                    corrupted = True
                                End If
                            Else
                                MessageBox.Show("Save file is corrupted! Please choose another file.", "Corrupted Save File!", System.Windows.Forms.MessageBoxButtons.OK)
                                corrupted = True
                            End If

                            If Not corrupted Then
                                'Create a new game using overloaded contructor to load game objects
                                'with parameters loaded from file.
                                game = New Game(Me.CreateGraphics, read_stream)

                                'If the game is corrupt, tell the user and set the game to Nothing, else tell them the game has been loaded
                                If game.corrupt Then
                                    MessageBox.Show("Save file is corrupted! Please choose another file.", "Corrupted Save File!", System.Windows.Forms.MessageBoxButtons.OK)
                                    game = Nothing
                                Else
                                    'Let the user know a new game has been loaded
                                    MessageBox.Show("Previous Game Loaded", "Previous Game Loaded",
                                                System.Windows.Forms.MessageBoxButtons.OK)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        'Close the read_stream if it exists
        If Not IsNothing(read_stream) Then
            read_stream.Close()
        End If

        'If a game object has been created.
        If Not IsNothing(game) Then
            'If a new game or loaded game has been started
            'Draw the game field, and set iteration lable
            If new_load_result <> DialogResult.Cancel Then
                Me.IterationNum.Text = iteration
                load_dialog.Dispose()
                game.Clear_Field()
                game.Draw_Field()

                Me.Indicator.Enabled = True
                Me.Draw.Enabled = True
                Me.Budget.Enabled = True
                Me.Save.Enabled = True
            Else
                'If full cancel, redraw the game field
                game.Draw_Field()
            End If
        End If

        'reset corrupted after load attempt
        corrupted = False

    End Sub

    'Upon clicking Show Indicators button, display the current planetary indicators
    Private Sub Indicator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Indicator.Click
        game.Indicators_Display()

        game.Clear_Field()
        game.Draw_Field()

    End Sub

    'Upon clicking on the Budget button, display the Budget form, and allow the user to make
    'Budget decisions that affect the planet
    Private Sub Budget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Budget.Click
        Dim budget_result = DialogResult.OK

        budget_result = game.Display_Budget()

        'If the budget has been confirmed then advance the iteration,
        'and call Calculate_Indexes()
        If budget_result = DialogResult.OK Then

            iteration += 1
            Me.IterationNum.Text = iteration

            If game.Calculate_Indexes() Then

                'If the game has reached the max turns
                'then finish the game, disable the buttons, call Game_Complete()
                'Show the final planet state, and exit the game automatically
                If iteration = max_turns Then
                    saved = True
                    Me.Indicator.Enabled = False
                    Me.Draw.Enabled = False
                    Me.Budget.Enabled = False
                    Me.Save.Enabled = False
                    game.Calculate_Mine_Toxicity()
                    game.Game_Complete()
                    timer.Interval = 3000
                    timer.Start()
                End If
            Else
                'If the planet has become uninhabitable then end the game and 
                'call Game_Failure()
                game.Game_Failure()
                saved = True
                Me.Indicator.Enabled = False
                Me.Draw.Enabled = False
                Me.Budget.Enabled = False
                Me.Save.Enabled = False
                game.Calculate_Mine_Toxicity()
                game.Draw_Field()
                timer.Interval = 3000
                timer.Start()
            End If

            'If the game hasn't ended, calculate the effects of the budget decisions
            'on mining toxicity and income
            game.Calculate_Mine_Toxicity()

            game.Calculate_Mine_Income()


            'If the game hasn't ended redraw the game field
            If timer.Enabled = False Then

                'Reset saved after an iteration has occured
                saved = False

                game.Draw_Field()
            End If
        Else
            'Draw the game field after dialog boxes have messed it up
            game.Draw_Field()

        End If
    End Sub

    'When the timer object ticks, then close the form
    Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        Me.Close()
    End Sub


End Class
