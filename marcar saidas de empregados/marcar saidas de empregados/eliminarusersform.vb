Public Class eliminarusersform
    Dim ticker As Integer
    Dim contaeliminada As Integer
    Dim atual, anterior As empregado
    Dim flag As Boolean
    Private Sub eliminarusersform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()

        For Each contasempregados As empregado In empregados
            Try
                ListBox1.Items.Add(contasempregados.nome)
            Catch

            End Try
        Next

        ReDim anterior.quandoentrouhoras(DateTime.Now.Month, quantosdiastemes)
        ReDim anterior.quandosaiominutos(DateTime.Now.Month, quantosdiastemes)
        ReDim anterior.quandoentrouminutos(DateTime.Now.Month, quantosdiastemes)
        ReDim anterior.quandosaiohoras(DateTime.Now.Month, quantosdiastemes)

        ReDim atual.quandoentrouhoras(DateTime.Now.Month, quantosdiastemes)
        ReDim atual.quandosaiominutos(DateTime.Now.Month, quantosdiastemes)
        ReDim atual.quandoentrouminutos(DateTime.Now.Month, quantosdiastemes)
        ReDim atual.quandosaiohoras(DateTime.Now.Month, quantosdiastemes)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        adminform.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        adicionarusersform.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ticker = 0
        For Each contasempregados As empregado In empregados
            If contasempregados.nome = ListBox1.SelectedItem Then
                If MessageBox.Show("tem a certeza que desaja eliminar a conta " & contasempregados.nome, "", MessageBoxButtons.YesNo) = DialogResult.No Then

                    Exit Sub
                End If

                contaeliminada = ticker

            End If
            ticker += 1

        Next
        flag = True
        For i = UBound(empregados) To contaeliminada Step -1


            ReDim Preserve empregados(i).quandoentrouhoras(DateTime.Now.Month, quantosdiastemes)

            ReDim Preserve empregados(i).quandosaiohoras(DateTime.Now.Month, quantosdiastemes)

            ReDim Preserve empregados(i).quandoentrouminutos(DateTime.Now.Month, quantosdiastemes)

            ReDim Preserve empregados(i).quandosaiominutos(DateTime.Now.Month, quantosdiastemes)

            anterior.nome = empregados(i).nome
            empregados(i).nome = atual.nome
            atual.nome = anterior.nome


            anterior.palavrapasse = empregados(i).palavrapasse
            empregados(i).palavrapasse = atual.palavrapasse
            atual.palavrapasse = anterior.palavrapasse


            anterior.tickermarcada = empregados(i).tickermarcada
            empregados(i).tickermarcada = atual.tickermarcada
            atual.tickermarcada = anterior.tickermarcada


            anterior.dianterior = empregados(i).dianterior
            empregados(i).dianterior = atual.dianterior
            atual.dianterior = anterior.dianterior

            anterior.flag = empregados(i).flag
            empregados(i).flag = atual.flag
            atual.flag = anterior.flag

            For diasdomes = 1 To quantosdiastemes

                anterior.quandoentrouhoras(DateTime.Now.Month, diasdomes) = empregados(i).quandoentrouhoras(DateTime.Now.Month, diasdomes)
                empregados(i).quandoentrouhoras(DateTime.Now.Month, diasdomes) = atual.quandoentrouhoras(DateTime.Now.Month, diasdomes)
                atual.quandoentrouhoras(DateTime.Now.Month, diasdomes) = anterior.quandoentrouhoras(DateTime.Now.Month, diasdomes)

                anterior.quandoentrouminutos(DateTime.Now.Month, diasdomes) = empregados(i).quandoentrouminutos(DateTime.Now.Month, diasdomes)
                empregados(i).quandoentrouminutos(DateTime.Now.Month, diasdomes) = atual.quandoentrouminutos(DateTime.Now.Month, diasdomes)
                atual.quandoentrouminutos(DateTime.Now.Month, diasdomes) = anterior.quandoentrouminutos(DateTime.Now.Month, diasdomes)

                anterior.quandosaiohoras(DateTime.Now.Month, diasdomes) = empregados(i).quandosaiohoras(DateTime.Now.Month, diasdomes)
                empregados(i).quandosaiohoras(DateTime.Now.Month, diasdomes) = atual.quandosaiohoras(DateTime.Now.Month, diasdomes)
                atual.quandosaiohoras(DateTime.Now.Month, diasdomes) = anterior.quandosaiohoras(DateTime.Now.Month, diasdomes)

                anterior.quandosaiominutos(DateTime.Now.Month, diasdomes) = empregados(i).quandosaiominutos(DateTime.Now.Month, diasdomes)
                empregados(i).quandosaiominutos(DateTime.Now.Month, diasdomes) = atual.quandosaiominutos(DateTime.Now.Month, diasdomes)
                atual.quandosaiominutos(DateTime.Now.Month, diasdomes) = anterior.quandosaiominutos(DateTime.Now.Month, diasdomes)
            Next






        Next
        If UBound(empregados) = 0 Then
            ReDim empregados(0)
        Else
            ReDim Preserve empregados(UBound(empregados) - 1)
        End If
        ListBox1.Items.Clear()
        For Each contasempregados As empregado In empregados

            Try
                ListBox1.Items.Add(contasempregados.nome)
            Catch

            End Try
        Next
    End Sub

End Class