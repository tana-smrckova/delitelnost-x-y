Imports System

Module Program
    Sub Main()
        Console.WriteLine("Zjisti, zda je èíslo x dìlitelné y beze zbytku.")
        Console.Write("Zadej promìnnou X: ")
        Dim x = Console.ReadLine()
        Console.Write("Zadej promìnnou Y: ")
        Dim y = Console.ReadLine()
        Dim vysledek = x Mod y

        If vysledek = 0 Then
            Console.WriteLine("Èíslo x je dìlitelné beze zbytku.")
        Else
            Console.WriteLine("Èíslo x není dìlitelné beze zbytku.")
        End If

        Main()

    End Sub
End Module
