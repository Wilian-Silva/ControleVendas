Public Class FrmResultadoPeriodo
    Private Sub FrmResultadoPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Abrir_Relatorio()
    End Sub

    Sub Abrir_Relatorio()
        'TODO: esta linha de código carrega dados na tabela 'DatasetResultadoPeriodo.ResultadoPeriodo'. Você pode movê-la ou removê-la conforme necessário.
        Me.ResultadoPeriodoTableAdapter.Fill(Me.DatasetResultadoPeriodo.ResultadoPeriodo, dataInicial, dataFinal)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class