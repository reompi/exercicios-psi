Imports System.Console
Module Module1

    Sub Main()
        Dim utilizador, palavrapasse As String
        While LCase(utilizador) <> "olio" And LCase(palavrapasse) <> "moi"
            WriteLine("indique o seu utilizador")
        utilizador = ReadLine()
        WriteLine("indique a palavrapasse")
            palavrapasse = ReadLine()


            If LCase(utilizador) <> "olio" And LCase(palavrapasse) <> "moi" Then
                WriteLine("utilizador e palavra passe inválidas")
                System.Threading.Thread.Sleep(500)
                Clear()
            End If


        End While
        WriteLine("utilizador e palavra passe válidas")
        ReadLine()




    End Sub

End Module
