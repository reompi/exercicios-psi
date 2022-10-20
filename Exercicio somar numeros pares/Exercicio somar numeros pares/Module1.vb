Imports System.Console

Module Module1
    Sub Main()

        Dim n1, n2, n3 As Decimal
        WriteLine("Insirar 3 números")
        n1 = ReadLine()
        n2 = ReadLine()
        n3 = ReadLine()
        If n1 Mod 2 <> 0 Or
                 n2 Mod 2 <> 0 Or
                 n3 Mod 2 <> 0 Then
            WriteLine("Um dos números não é par")
        Else WriteLine("A soma dos números pares é " & n1 + n2 + n3)
        End If
        ReadLine()
    End Sub

End Module
