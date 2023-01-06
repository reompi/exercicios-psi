Imports System.Console

Module Module1
    Dim valor As Decimal
    Dim n As String
    Sub Main()
        WriteLine("Insira um valor para indicar o troco mais próximo")
        valor = ReadLine()

        If valor = 0.02 Or valor = 0.05 Or valor = 0.1 Or valor = 0.2 Or valor = 0.5 Or valor = 1 Or valor = 2 Or valor = 5 Or valor = 10 Or valor = 20 Or valor = 50 Or valor = 100 Or valor = 200 Or valor = 500 Then
            trocoproximo()
            WriteLine("O troco mais próxima é/são " & n & " | presse ENTER para recomeçar o progama")
            ReadLine()
            Clear()
            Main()

        Else WriteLine(valor & " é um valor inválido | presse ENTER para recomeçar o progama")
            ReadLine()
            Clear()
            Main()

        End If

    End Sub

    Sub trocoproximo()
        Select Case valor
            Case 0.02
                n = "2 moedas de 1 cêntimO"
            Case 0.05
                n = "2 moedas de 2 centimos e 1 moeda de 1 cêntimo"
            Case 0.1
                n = "2 moedas de 5 cêntimos"
            Case 0.2
                n = "2 moedas de 10 cêntimos"
            Case 0.5
                n = "2 moedas de 20 cêntimos e 1 moeda de 10 cêntimos"
            Case 1
                n = "2 moedas de 50 cêntimos"
            Case 2
                n = "2 moedas de 1 euro"
            Case 5
                n = "2 moedas de 2 euros e 1 de 1 euro"
            Case 10
                n = "2 notas de 5 euros"
            Case 20
                n = "2 notas de 10 euros"
            Case 50
                n = "2 notas de 20 euros e 1 nota de 10 eurps"
            Case 100
                n = "2 notas de 50 euros"
            Case 200
                n = "2 notas de 100 euros"
            Case 500
                n = "2 notas de 200 euros e 1 de 100 euros"
        End Select

    End Sub
End Module


