Imports Microsoft.Reporting.WinForms

Public Class FrmReporteVencidos
    Private Sub FrmReporteVencidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarRel()
    End Sub
    Sub CarregarRel()
        'TODO: esta linha de código carrega dados na tabela 'controle_vendasDataSet4.venda_cabecalho_tituloVencido'. Você pode movê-la ou removê-la conforme necessário.


        Dim data As Date
        data = DataHoje.Value.ToShortDateString 'Data inicio digitada pelo cliente

        Me.venda_cabecalho_tituloVencidoTableAdapter.Fill(Me.controle_vendasDataSet4.venda_cabecalho_tituloVencido, data)

        Dim paramData As ReportParameter
        paramData = New ReportParameter("DataHoje", data)
        Me.ReportViewer1.LocalReport.SetParameters(paramData)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub DataHoje_ValueChanged(sender As Object, e As EventArgs) Handles DataHoje.ValueChanged
        CarregarRel()
    End Sub
End Class