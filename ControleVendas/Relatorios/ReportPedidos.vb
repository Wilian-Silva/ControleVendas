Imports Microsoft.Reporting.WinForms

Public Class ReportPedidos
    Private Sub BtnPesqPedido_Click(sender As Object, e As EventArgs) Handles BtnPesqPedido.Click
        Dim form = New FrmPedidoCabecalho
        form.ShowDialog()

    End Sub

    Private Sub ReportPedidos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TxtPesquisar.Text = numeroPedido
        TxtIdPedido.Text = IdPedido

    End Sub

    Private Sub ReportPedidos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        numeroPedido = ""
        IdPedido = ""
        StatusPedido = ""
        TxtPesquisar.Text = ""
        TxtIdPedido.Text = ""

    End Sub

    Private Sub ReportPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarRel()
    End Sub

    Sub CarregarRel()



        'TODO:   esta linha de código carrega dados na tabela 'controle_vendasDataSet6.consulta_pedidos'. Você pode movê-la ou removê-la conforme necessário.
        Me.consulta_pedidosTableAdapter.Fill(Me.controle_vendasDataSet6.consulta_pedidos, TxtIdPedido.Text)

        Dim paramIdPedido As ReportParameter
        Dim paramDataFin As ReportParameter

        paramIdPedido = New ReportParameter("idPedido", TxtIdPedido.Text)
        paramDataFin = New ReportParameter("idPedidoDesc", TxtPesquisar.Text)

        Me.ReportViewer1.LocalReport.SetParameters(paramIdPedido)
        Me.ReportViewer1.LocalReport.SetParameters(paramDataFin)


        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        CarregarRel()
    End Sub
End Class