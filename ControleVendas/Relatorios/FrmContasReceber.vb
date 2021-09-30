Public Class FrmContasReceber
    Private Sub FrmContasReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ReportTitulosVencidos.contas_receber'. Você pode movê-la ou removê-la conforme necessário.
        Me.contas_receberTableAdapter.Fill(Me.ReportTitulosVencidos.contas_receber)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class