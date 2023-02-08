Module Module1

    Sub Main()

        Dim valores(19), media As Integer
        For i = 0 To 20
            valores(i) = Console.ReadLine()
            media += valores(i)
        Next
        media = media / 20
    End Sub

End Module
