Imports System

' This is a class of rectangle
Public Class Rectangle

    ' These are 2 instance variable
    Private length As Double
    Private width As Double

    '
    Public Sub AcceptDetails(l As Double, w As Double)
        length = l
        width = w
    End Sub

    ' Function to calculate area of rectangle
    Public Function GetArea() As Double
        GetArea = length * width
    End Function

    ' Function to display properties of rectangle
    Public Sub Display()
        Console.WriteLine("Length: {0}", length)
        Console.WriteLine("Width: {0}", width)
        Console.WriteLine("Area: {0}", GetArea())

    End Sub

    ' Main function
    Shared Sub Main()
        Dim r As New Rectangle()
        Dim l = Console.ReadLine()
        Dim w = Console.ReadLine()

        r.AcceptDetails(l, w)
        r.Display()
        Console.ReadLine()
    End Sub

End Class



