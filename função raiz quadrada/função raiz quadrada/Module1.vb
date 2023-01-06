Imports System.Console
Module Module1
    Dim numero As Integer
    Sub Main()
        WriteLine("Introduza um número")
        numero = ReadLine()
        operação(numero)
        ReadLine()
    End Sub
    Sub operação(n As Integer)
        n = Math.Sqrt(n)
        WriteLine(n)

    End Sub
End Module
