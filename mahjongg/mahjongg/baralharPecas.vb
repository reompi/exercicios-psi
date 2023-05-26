Class baralharPecas
    Dim random As New Random
    Dim pecaAtual As Bitmap
    Dim posicaoParXAleatorio As Integer
    Dim posicaoParYAleatorio As Integer
    Dim ticker As Integer = 0
    Dim meioX As Integer = 6
    Dim meioY As Integer = 3
    Sub baralharInicio()
        'layer 0


        For x As Integer = meioX To 3 Step -1

            ''''
            pecaAtual = getPecaAleatoria()
            tilesLayer(x, x - 3).picturebox.Image = pecaAtual
            tilesLayer(x, x - 3).naoAssinalado = False
            getPosicaoParAleatorio(x).Image = pecaAtual


        Next

    End Sub
    Private Function getPosicaoParAleatorio(x As Integer) As PictureBox
        Dim _random As Integer


        _random = random.Next(3)
        Select Case _random
            Case 0
                posicaoParYAleatorio = x - 3
                posicaoParXAleatorio = ticker + meioX
            Case 1
                posicaoParYAleatorio = ticker + meioY
                posicaoParXAleatorio = x
            Case 2
                posicaoParYAleatorio = ticker + meioY
                posicaoParXAleatorio = ticker + meioX
        End Select
        Return tilesLayer(posicaoParXAleatorio, posicaoParYAleatorio).picturebox
    End Function
    Private Function getPecaAleatoria()

        Dim _random As Integer = random.Next(12)
        Select Case _random
            Case 0
                Return My.Resources.bolas__1_
            Case 1
                Return My.Resources.bolas__2_
            Case 2
                Return My.Resources.bolas__3_
            Case 3
                Return My.Resources.paus__1_
            Case 4
                Return My.Resources.paus__2_
            Case 5
                Return My.Resources.paus__3_
            Case 6
                Return My.Resources.s__1_
            Case 7
                Return My.Resources.s__2_
            Case 8
                Return My.Resources.s__3_
            Case 9
                Return My.Resources.x__1_
            Case 10
                Return My.Resources.x__2_
            Case 11
                Return My.Resources.x__3_
        End Select

    End Function
End Class