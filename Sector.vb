'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
'       Name: Patrick Leonard
'       Assignment: Ampla Planet Management
'       Class: CS300 
'       File: Sector.vb 
'
'       This is the Sector Class. It is to be drawn as the game field.
'   
'
'
'

Imports System.Drawing


Public Class Sector

    'Reference to a point, graphics object, and rectangle
    Protected Gr As Graphics
    Protected S_point As Point
    Protected Rect1 As Rectangle

    'Constructor to create a Sector
    Sub New(ByVal p1 As Point, ByRef g As System.Drawing.Graphics)
        Gr = g
        S_point = p1
        Rect1 = New Rectangle(S_point.X, S_point.Y, 4, 4)
    End Sub

    'Draw the Sector on the game field with the Rectangle
    'and Graphics object of the Main form
    Sub Draw_Sector()

        'Forest green color
        Dim sect_color As Color = Color.ForestGreen

        'Draw the filled rectangle, and dispose of the brush
        Dim myBrush As New System.Drawing.SolidBrush(sect_color)
        Gr.FillRectangle(myBrush, Rect1)
        myBrush.Dispose()

    End Sub

End Class

