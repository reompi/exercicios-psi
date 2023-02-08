Module Module1
    Dim numeros(24), total As Integer

    Sub Main()
        For i = 0 To 25


            numeros(i) = Console.ReadLine
        Next
        For i = 0 To 25 Step 2
            total = +numeros(i)
        Next
        WriteLine(total)
    End Sub

End Module
