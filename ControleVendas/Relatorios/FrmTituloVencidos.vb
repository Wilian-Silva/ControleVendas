Public Class FrmTituloVencidos
    Private Sub FrmTituloVencidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ReportTitulosVencidos.titulosVencidos'. Você pode movê-la ou removê-la conforme necessário.
        CarregarRelatorio()
    End Sub

    Sub CarregarRelatorio()
        Me.titulosVencidosTableAdapter.Fill(Me.ReportTitulosVencidos.titulosVencidos, DataFim.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DataFim_ValueChanged(sender As Object, e As EventArgs) Handles DataFim.ValueChanged
        CarregarRelatorio()
    End Sub
End Class