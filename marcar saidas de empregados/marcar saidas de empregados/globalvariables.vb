Module globalvariables
    Public Structure empregado
        Dim nome As String
        Dim palavrapasse As String

        Dim quandoentrouhoras(,) As Integer
        Dim quandoentrouminutos(,) As Integer


        Dim quandosaiohoras(,) As Integer
        Dim quandosaiominutos(,) As Integer

        Dim tickermarcada As Integer

        Dim flag As Boolean
    End Structure

        Public Structure admins
        Dim nome As String
        Dim palavrapasse As String
    End Structure

    Public empregados() As empregado
    Public admin() As admins
    Public usernumero As Integer




End Module
