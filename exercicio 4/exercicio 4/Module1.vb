Imports System.Console
Module Module1
    Dim cateto1, cateto2 As Decimal

    Sub Main()
        WriteLine("insira o valor do cateto")
        cateto1 = ReadLine()
        WriteLine("insira o valor do outro cateto")
        cateto2 = ReadLine()
        WriteLine("o valor da hipotenusa é " & Math.Sqrt(cateto1 ^ 2 + cateto2 ^ 2))
        ReadLine()





    End Sub

End Module
