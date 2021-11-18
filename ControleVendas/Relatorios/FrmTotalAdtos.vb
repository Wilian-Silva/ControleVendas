Public Class FrmTotalAdtos
    Private Sub FrmTotalAdtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSetTotalAdto.consulta_adto'. Você pode movê-la ou removê-la conforme necessário.
        Me.Consulta_adtoTableAdapter.Fill(Me.DataSetTotalAdto.consulta_adto)
        'TODO: esta linha de código carrega dados na tabela 'DataSetTotalAdto.consulta_adto'. Você pode movê-la ou removê-la conforme necessário.
        Me.consulta_adtoTableAdapter.Fill(Me.DataSetTotalAdto.consulta_adto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class