Public Class FrmContasPagar
    Private Sub FrmContasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'controle_vendasDataSet2.duplicatasReceber'. Você pode movê-la ou removê-la conforme necessário.
        Me.duplicatasReceberTableAdapter.Fill(Me.controle_vendasDataSet2.duplicatasReceber)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class