Public Class ReportVendas
    Private Sub ReportVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

        Abrir_Relatorio()

    End Sub

    Sub Abrir_Relatorio()


        'TODO: esta linha de código carrega dados na tabela 'DataSet_ReportVendas.DataSet_venda'. Você pode movê-la ou removê-la conforme necessário.
        Me.DataSet_vendaTableAdapter.Fill(Me.DataSet_ReportVendas.DataSet_venda, DataInicio.Text, DataFim.Text)



        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        Abrir_Relatorio()
    End Sub
End Class