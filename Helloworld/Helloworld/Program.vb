Imports System

Module Program
    ' This program will display Hello World
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.ReadKey()
        Console.WriteLine()
        Welcome.welcome()
        Console.ReadKey()

    End Sub
End Module

Module Welcome
    Sub welcome()
        Console.WriteLine("Welcome to VB world!")

    End Sub
End Module
