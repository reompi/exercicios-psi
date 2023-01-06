Imports System.Console
Module Module1
    Dim numerodehoras As Decimal
    Dim valor, valor2, valortotal, troco, trocorestante As Decimal
    Sub Main()
        WriteLine("Insira o tempo que esteve no estacionamento em horas")
        numerodehoras = ReadLine()
        If numerodehoras <= 0 Then
            Do
                WriteLine("Número inválido, introduza outro valor")
                numerodehoras = ReadLine()
            Loop While numerodehoras <= 0
        End If
        valorparque()
        WriteLine("O Montate a pagar é " & valor & " euro introduza o pagamento")
        valor2 = ReadLine()
        valortotal = valortotal + valor2
        troco = valortotal - valor
        trocorestante = troco * -1

        If valor2 < valor And valor2 > 0 Then
            Do
                If valor2 < 0 Then
                    WriteLine("Valor inválido introduza outro valor")
                    valor2 = ReadLine()
                Else


                    troco = valortotal - valor
                    trocorestante = troco * -1
                    WriteLine("inire o restante ...  Restante a pagar = " & trocorestante)
                    valor2 = ReadLine()
                    valortotal = valortotal + valor2
                End If

            Loop While valortotal < valor



        End If
        WriteLine("Valor pago com sucesso    TROCO = " & troco)
        ReadLine()

    End Sub
    Sub valorparque()

        Select Case numerodehoras
            Case 1
                valor = "0.8"
            Case 2 To 3
                valor = 0.6 * numerodehoras
            Case 4 To 5
                valor = 0.5 * numerodehoras
            Case 6 To 7
                valor = 0.4 * numerodehoras
            Case Else
                valor = 0.3 * numerodehoras
        End Select

    End Sub
End Module
