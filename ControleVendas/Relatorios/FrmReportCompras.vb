Imports Microsoft.Reporting.WinForms

Public Class FrmReportCompras
    Private Sub FrmReportCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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


        CarregarRel()


    End Sub

    Sub CarregarRel()
        'TODO: esta linha de código carrega dados na tabela 'controle_vendasDataSet5.entradas'. Você pode movê-la ou removê-la conforme necessário.
        Me.entradasTableAdapter.Fill(Me.controle_vendasDataSet5.entradas, DataInicio.Text, DataFim.Text)


        Dim paramDataIni As ReportParameter
        Dim paramDataFin As ReportParameter

        paramDataIni = New ReportParameter("DataIncial", DataInicio.Text)
        paramDataFin = New ReportParameter("DataFinal", DataFim.Text)

        Me.ReportViewer1.LocalReport.SetParameters(paramDataIni)
        Me.ReportViewer1.LocalReport.SetParameters(paramDataFin)

        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub DataInicio_ValueChanged(sender As Object, e As EventArgs) Handles DataInicio.ValueChanged
        CarregarRel()
    End Sub

    Private Sub DataFim_ValueChanged(sender As Object, e As EventArgs) Handles DataFim.ValueChanged
        CarregarRel()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub
End Class