Public Class eliminarusersform
    Dim ticker As Integer
    Dim contaeliminada As Integer
    Dim atual, anterior As empregado
    Dim flag As Boolean
    Private Sub eliminarusersform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each contasempregados As empregado In empregados
            ListBox1.Items.Add(contasempregados.nome)
        Next


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ticker = 0
        For Each contasempregados As empregado In empregados
            If contasempregados.nome = ListBox1.SelectedItem Then
                If MessageBox.Show("palavras passes diferentes", "", MessageBoxButtons.YesNo) = DialogResult.No Then

                    Exit Sub

                End If
                contaeliminada = ticker

                End If
                ticker += 1

        Next
        flag = True
        For i = UBound(empregados) To contaeliminada



            If flag = False Then

                anterior.nome = empregados(i).nome
                empregados(i).nome = atual.nome
                atual.nome = anterior.nome


                anterior.palavrapasse = empregados(i).palavrapasse
                empregados(i).palavrapasse = atual.palavrapasse
                atual.palavrapasse = anterior.palavrapasse

                anterior.quandoentrouhoras(DateTime.Now.Month, i) = empregados(i).quandoentrouhoras(DateTime.Now.Month, i)
                empregados(i).quandoentrouhoras(DateTime.Now.Month, i) = atual.quandoentrouhoras(DateTime.Now.Month, i)
                atual.quandoentrouhoras(DateTime.Now.Month, i) = anterior.quandoentrouhoras(DateTime.Now.Month, i)

                anterior.quandoentrouminutos(DateTime.Now.Month, i) = empregados(i).quandoentrouminutos(DateTime.Now.Month, i)
                empregados(i).quandoentrouminutos(DateTime.Now.Month, i) = atual.quandoentrouminutos(DateTime.Now.Month, i)
                atual.quandoentrouminutos(DateTime.Now.Month, i) = anterior.quandoentrouminutos(DateTime.Now.Month, i)

                anterior.quandosaiohoras(DateTime.Now.Month, i) = empregados(i).quandosaiohoras(DateTime.Now.Month, i)
                empregados(i).quandosaiohoras(DateTime.Now.Month, i) = atual.quandosaiohoras(DateTime.Now.Month, i)
                atual.quandosaiohoras(DateTime.Now.Month, i) = anterior.quandosaiohoras(DateTime.Now.Month, i)

                anterior.quandosaiominutos(DateTime.Now.Month, i) = empregados(i).quandosaiominutos(DateTime.Now.Month, i)
                empregados(i).quandosaiominutos(DateTime.Now.Month, i) = atual.quandosaiominutos(DateTime.Now.Month, i)
                atual.quandosaiominutos(DateTime.Now.Month, i) = anterior.quandosaiominutos(DateTime.Now.Month, i)

            End If
            flag = False

        Next
    End Sub

End Class