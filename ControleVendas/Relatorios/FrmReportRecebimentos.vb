Imports Microsoft.Reporting.WinForms

Public Class FrmReportRecebimentos
    Private Sub FrmReportRecebimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


        CaregarRel()

    End Sub
    'Função que retorna o ultimo dia do mes


    Sub CaregarRel()
        'TODO: esta linha de código carrega dados na tabela 'controle_vendasDataSet1.mvto_recebimentosPorData'. Você pode movê-la ou removê-la conforme necessário.
        Me.mvto_recebimentosPorDataTableAdapter.Fill(Me.controle_vendasDataSet1.mvto_recebimentosPorData, DataInicio.Text, DataFim.Text)


        Dim paramDataIni As ReportParameter
        Dim paramDataFin As ReportParameter

        paramDataIni = New ReportParameter("DataInicial", DataInicio.Text)
        paramDataFin = New ReportParameter("DataFinal", DataFim.Text)

        Me.ReportViewer1.LocalReport.SetParameters(paramDataIni)
        Me.ReportViewer1.LocalReport.SetParameters(paramDataFin)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DataInicio_ValueChanged(sender As Object, e As EventArgs) Handles DataInicio.ValueChanged
        CaregarRel()
    End Sub

    Private Sub DataFim_ValueChanged(sender As Object, e As EventArgs) Handles DataFim.ValueChanged
        CaregarRel()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub
End Class