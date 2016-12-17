'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
'       Name: Patrick Leonard
'       Assignment: Ampla Planet Management
'       Class: CS300 
'       File: Mine.vb 
'
'       This is the Mine class. It calculates the value, toxicity, and radius of pollution
'   of the mine. It draws itself on the map field, and it draws the circle of pollution
'   the mine creates from the toxicity in a gradient from red (high toxicity) to Forest green
'   (little to no toxicity).
'
'Import necessary packages
Imports System.Math
Imports Microsoft.VisualBasic.PowerPacks
Imports System.Drawing.Drawing2D


Public Class Mine

    'Create references to needed objects and types
    Protected income_value As Double
    Protected toxicity As Double
    Protected start_income_value As Integer
    Protected start_toxicity As Integer
    Protected Gr As Graphics
    Protected S_point As Point
    Protected Rect1 As Rectangle

    'Set and Get properties for the toxicity and income value
    Public Property tox() As Double
        Get
            Return toxicity
        End Get
        Set(ByVal value As Double)
            toxicity = value
        End Set
    End Property

    Public Property inc() As Integer
        Get
            Return income_value
        End Get
        Set(ByVal value As Integer)
            income_value = value
        End Set
    End Property

    'Overloaded constructor that creates the mine at start of the game
    'Uses a random point, reference to Graphics object from Main form
    Sub New(ByVal p1 As Point, ByRef g As System.Drawing.Graphics)
        'Starting mine value and toxicity
        start_income_value = 200
        start_toxicity = 100

        toxicity = start_toxicity
        income_value = start_income_value
        Gr = g
        S_point = p1
        Rect1 = New Rectangle(S_point.X, S_point.Y, 4, 4)
    End Sub

    'Overloaded constructor to create a mine object from parameters loaded from save file
    Sub New(ByVal p1 As Point, ByRef g As System.Drawing.Graphics, ByVal tox As Double, ByVal inc As Double)
        start_income_value = 200
        start_toxicity = 100

        toxicity = tox
        income_value = inc
        Gr = g
        S_point = p1
        Rect1 = New Rectangle(S_point.X, S_point.Y, 4, 4)
    End Sub

    'Calculate the toxicity of the mine based on the starting and Environment Indexes
    'Lower Environment index means higher toxicity
    Sub calc_toxicity(ByRef global_index As Index)
        toxicity = start_toxicity * (Math.Pow((global_index.Start / global_index.Enviro), 2.0))
    End Sub

    'Calculate the value of the mine from the starting and Mining indexes
    'Higher Mining Index means higher mine value
    Sub calc_income(ByRef global_index As Index)
        income_value = start_income_value * (Math.Pow((global_index.Inc / global_index.Start), 2.0))
    End Sub

    'Draw the mine on the map field, using Graphics object and toxicity
    Sub draw_mine()
        'Create a black brush to draw the mine
        Dim myBlackBrush As New System.Drawing.SolidBrush(System.Drawing.Color.Black)

        'Create a rectangle for a Path to place the toxic circle inside
        Dim toxic_rect As New Rectangle(Math.Round((S_point.X) - (toxicity / 2)), Math.Round((S_point.Y) - (toxicity / 2)), Math.Round(toxicity), Math.Round(toxicity))

        'Create a GraphicsPath using an Ellipse (circle) created with the toxic_rect
        Dim path As New GraphicsPath()
        path.AddEllipse(toxic_rect)

        'Create a PathGradientBrush to fill the toxic circle with a gradient of colors
        Dim path_brush As New PathGradientBrush(path)

        'Create an array of 3 colors for the gradient
        Dim colors As Color() = {System.Drawing.Color.ForestGreen, System.Drawing.Color.FromArgb(200, 100, 34),
                                 System.Drawing.Color.Red}

        'Create an array of position factors for where the gradients occur
        Dim positions As Single() = {0.0, 0.1, 1.0}

        'Create a ColorBlend object and assign the Color and Position arrays to the ColorBlend properties
        Dim colorBlend As New ColorBlend()

        colorBlend.Colors = colors
        colorBlend.Positions = positions

        'Assign the ColorBlend to the InterpolationColors parameter of the gradient brush
        path_brush.InterpolationColors = colorBlend

        'Fill the Ellipse with the gradient to represent the toxic circle, 
        'and fill the rectangle with the black brush to represent the mine
        Gr.FillEllipse(path_brush, toxic_rect)
        Gr.FillRectangle(myBlackBrush, Rect1)

        'dispose of both brushes
        path_brush.Dispose()
        myBlackBrush.Dispose()

    End Sub

    'Save the position, toxicity, and value of the mine to the file parameter passed by reference
    Sub Save(ByRef file As System.IO.StreamWriter)

        Dim tox, inc, p_x, p_y As String

        'Assign the member variables to strings
        tox = toxicity.ToString
        inc = income_value.ToString
        p_x = S_point.X.ToString
        p_y = S_point.Y.ToString

        'Write the strings to the file
        file.WriteLine(tox)
        file.WriteLine(inc)
        file.WriteLine(p_x)
        file.WriteLine(p_y)

    End Sub
End Class
