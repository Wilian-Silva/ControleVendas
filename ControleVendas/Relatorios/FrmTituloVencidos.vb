Public Class FrmTituloVencidos
    Private Sub FrmTituloVencidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ReportTitulosVencidos.titulosVencidos'. Você pode movê-la ou removê-la conforme necessário.
        CarregarRelatorio()
    End Sub

    Sub CarregarRelatorio()
        Dim database As Date
        database = Now
        Me.titulosVencidosTableAdapter.Fill(Me.ReportTitulosVencidos.titulosVencidos, database)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class