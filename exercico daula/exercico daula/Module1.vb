Imports System.Console
Module Module1

    Sub Main()

        For i = 0 To 127


            Write("                " & i & " " & Chr(i) & "  ")
            If i Mod 5 = 0 Then
                WriteLine()
            End If
        Next

        ReadLine()
    End Sub

End Module
