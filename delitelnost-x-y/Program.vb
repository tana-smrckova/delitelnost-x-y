Imports System

Module Program
    Sub Main()
        Console.WriteLine("Zjisti, zda je ��slo x d�liteln� y beze zbytku.")
        Console.Write("Zadej prom�nnou X: ")
        Dim x = Console.ReadLine()
        Console.Write("Zadej prom�nnou Y: ")
        Dim y = Console.ReadLine()
        Dim vysledek = x Mod y

        If vysledek = 0 Then
            Console.WriteLine("��slo x je d�liteln� beze zbytku.")
        Else
            Console.WriteLine("��slo x nen� d�liteln� beze zbytku.")
        End If

        Main()

    End Sub
End Module
