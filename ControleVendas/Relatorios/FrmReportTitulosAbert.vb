Imports Microsoft.Reporting.WinForms

Public Class FrmReportTitulosAbert
    Private Sub FrmReportTitulosAbert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'controle_vendasDataSet4.venda_cabecalho_tituloAberto'. Você pode movê-la ou removê-la conforme necessário.
        Me.Venda_cabecalho_tituloAbertoTableAdapter.Fill(Me.controle_vendasDataSet4.venda_cabecalho_tituloAberto)

        Me.ReportViewer1.RefreshReport()
    End Sub



End Class