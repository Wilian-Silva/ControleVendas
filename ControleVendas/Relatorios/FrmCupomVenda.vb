Public Class FrmCupomVenda
    Private Sub BtnPesquisarNota_Click(sender As Object, e As EventArgs) Handles BtnPesquisarNota.Click
        pesquisarDuplicata = "True"
        Dim form = New FrmVendaCabecalho
        form.ShowDialog()
    End Sub

    Private Sub FrmCupomVenda_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If pesquisarDuplicata = "True" Then
            TxtIdVenda.Text = IdDuplicata
        End If
    End Sub

    Private Sub FrmCupomVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub Carregar_relatorio()
        If TxtIdVenda.Text <> "" Then
            'TODO: esta linha de código carrega dados na tabela 'DataSetCupomVenda.cumpoVenda'. Você pode movê-la ou removê-la conforme necessário.
            Me.cumpoVendaTableAdapter.Fill(Me.DataSetCupomVenda.cumpoVenda, TxtIdVenda.Text)
            'TODO: esta linha de código carrega dados na tabela 'DataSetCupomVenda.CupomCompraV2'. Você pode movê-la ou removê-la conforme necessário.
            Me.CupomCompraV2TableAdapter.Fill(Me.DataSetCupomVenda.CupomCompraV2, TxtIdVenda.Text)

            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        Carregar_relatorio()
    End Sub

    Private Sub FrmCupomVenda_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        TxtIdVenda.Text = ""
    End Sub
End Class