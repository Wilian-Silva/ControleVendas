Public Class ReportVendasPortador
    Private Sub BtnPesquisarPortador_Click(sender As Object, e As EventArgs) Handles BtnPesquisarPortador.Click
        PesquisarPortador = "True"
        Dim form = New FrmPortador
        form.ShowDialog()
    End Sub

    Private Sub ReportVendasPortador_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If PesquisarPortador = "True" Then
            TxtIdPortador.Text = IdPortador
            IdPortador = ""
        End If
    End Sub

    Private Sub ReportVendasPortador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data1 As Date
        Dim data2 As Date

        data1 = Now.ToShortDateString 'Data inicio digitada pelo cliente
        data2 = Now.ToShortDateString  'Data fim digitada pelo cliente

        Dim Primeiro_Dia_Mes As Date
        Dim Ultimo_Dia_Mes As Date

        Primeiro_Dia_Mes = "01/" & Month(data1) & "/" & Year(data1)
        Ultimo_Dia_Mes = Func_Ultimo_Dia_Mes(data2)

        DataInicio.Value = Primeiro_Dia_Mes
        DataFim.Value = Ultimo_Dia_Mes


    End Sub

    Sub Abrir_Relatorio()

        If TxtIdPortador.Text <> "" Then
            'TODO: esta linha de código carrega dados na tabela 'controle_vendasDataSet_Portador.duplicatas_receber_portador'. Você pode movê-la ou removê-la conforme necessário.
            Me.duplicatas_receber_portadorTableAdapter.Fill(Me.controle_vendasDataSet_Portador.duplicatas_receber_portador, DataInicio.Text, DataFim.Text, TxtIdPortador.Text)

            Me.ReportViewer1.RefreshReport()
        Else
            MsgBox("Selecione um portador!!!")
        End If
    End Sub

    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        Abrir_Relatorio()
    End Sub
End Class