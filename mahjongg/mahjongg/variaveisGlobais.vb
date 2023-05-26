Module variaveisGlobais
    Public tilesLayer(14, 7) As tiles
    Public tilesLayer1(14, 7) As tiles
    Public tilesLayer2(14, 7) As tiles
    Public tilesLayer3(14, 7) As tiles
    Public tilesLayer4(14, 7) As tiles
    Public tilesLayerAssimetricas(14, 7) As tiles
    Public tilesList As New ArrayList
    Public meioX As Integer
    Public meioY As Integer
    Enum tilesVisbilidade
        hidden = 0
        shown = 1
        removed = 2
    End Enum
    Public Structure tiles
        Dim visibilidade As tilesVisbilidade
        Dim picturebox As PictureBox
        Dim naoAssinalado As Boolean
    End Structure
    Sub appload()

        For Each tile As tiles In tilesLayer

            Next

    End Sub

End Module
