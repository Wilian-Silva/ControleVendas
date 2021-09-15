Imports MySql.Data.MySqlClient

Public Class FrmTelaInicial


    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCad1_01.Click
        Dim form = New FrmProdutos
        form.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCad1_02.Click
        Dim form = New FrmClientes
        form.ShowDialog()
    End Sub

    Private Sub EntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxMvto1_01.Click
        Dim form = New FrmPedido
        form.ShowDialog()
    End Sub

    Private Sub SaidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxMvto1_02.Click
        Dim form = New FrmEntrada
        form.ShowDialog()
    End Sub

    Private Sub RecebimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxMvto1_04.Click
        Dim form = New FrmRecebimento
        form.ShowDialog()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCad1_04.Click

        Dim form = New FrmUsuarios
        form.ShowDialog()

    End Sub



    Private Sub BtnCadProduto_Click(sender As Object, e As EventArgs) Handles BtnCadProduto.Click
        Dim form = New FrmProdutos
        form.ShowDialog()

    End Sub

    Private Sub BtnCadCliente_Click(sender As Object, e As EventArgs) Handles BtnCadCliente.Click
        Dim form = New FrmClientes
        form.ShowDialog()

    End Sub

    Private Sub BtnPedido_Click(sender As Object, e As EventArgs) Handles BtnPedido.Click
        Dim form = New FrmPedido
        form.ShowDialog()

    End Sub

    Private Sub BtnEntrada_Click(sender As Object, e As EventArgs) Handles BtnEntrada.Click
        Dim form = New FrmEntrada
        form.ShowDialog()

    End Sub

    Private Sub BtnVenda_Click(sender As Object, e As EventArgs) Handles BtnVenda.Click

        Dim form = New FrmVenda
        form.ShowDialog()
    End Sub

    Private Sub BtnSaisSistema_Click(sender As Object, e As EventArgs) Handles BtnSaisSistema.Click

        If MsgBox("Deseja sair do sistema?", vbYesNo, "Logout") = vbYes Then
            Application.Exit()

        End If

    End Sub

    Private Sub TimerData_Tick(sender As Object, e As EventArgs) Handles TimerData.Tick

        LblData.Text = Now().ToShortDateString
        LblHora.Text = Now().ToLongTimeString

    End Sub

    Sub FormatarGridTelaIncial()
        DataGrid_AVencer.Columns(0).HeaderText = "Cliente"
        DataGrid_AVencer.Columns(1).HeaderText = "Produto"
        DataGrid_AVencer.Columns(2).HeaderText = "Qtd."
        DataGrid_AVencer.Columns(3).HeaderText = "Valor Total"
        DataGrid_AVencer.Columns(4).HeaderText = "Saldo Venda"
        DataGrid_AVencer.Columns(5).HeaderText = "Data Vencimento"
        DataGrid_AVencer.Columns(3).DefaultCellStyle.Format = "c"
        DataGrid_AVencer.Columns(4).DefaultCellStyle.Format = "c"
        DataGrid_AVencer.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_AVencer.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_AVencer.Columns(0).Width = 90
        DataGrid_AVencer.Columns(2).Width = 50
        DataGrid_AVencer.Columns(1).Width = 120
        DataGrid_AVencer.Columns(3).Width = 90
        DataGrid_AVencer.Columns(4).Width = 90


        DataGrid_Vencidos.Columns(0).HeaderText = "Cliente"
        DataGrid_Vencidos.Columns(1).HeaderText = "Produto"
        DataGrid_Vencidos.Columns(2).HeaderText = "Qtd."
        DataGrid_Vencidos.Columns(3).HeaderText = "Valor Total"
        DataGrid_Vencidos.Columns(4).HeaderText = "Saldo Venda"
        DataGrid_Vencidos.Columns(5).HeaderText = "Data Vencimento"
        DataGrid_Vencidos.Columns(3).DefaultCellStyle.Format = "c"
        DataGrid_Vencidos.Columns(4).DefaultCellStyle.Format = "c"
        DataGrid_Vencidos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_Vencidos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_Vencidos.Columns(0).Width = 90
        DataGrid_Vencidos.Columns(2).Width = 50
        DataGrid_Vencidos.Columns(1).Width = 120
        DataGrid_Vencidos.Columns(3).Width = 90
        DataGrid_Vencidos.Columns(4).Width = 90
    End Sub
    Private Sub FrmTelaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TotalTitulos()

        FormatarGridTelaIncial()

        'CarregarAcessos()

        LblUsuario.Text = nomeFuncionario

    End Sub

    Sub CarregarAcessos()
        Dim tool As ToolStripMenuItem
        Dim nome As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim sql As String
        Dim status As String
        Dim menu As ToolStripMenuItem

        Abrir()
        Try
            For Each menu In MenuStrip1.Items

                For Each tool In menu.DropDownItems

                    nome = tool.Name

                    sql = "SELECT *FROM controle_acesso where rotina =  '" & nome & "' "

                    cmd = New MySqlCommand(sql, con)
                    reader = cmd.ExecuteReader
                    If reader.Read = True Then

                        If nivelAcesso = 1 Then
                            status = reader(3)
                        Else
                            If nivelAcesso = 2 Then
                                status = reader(4)
                            Else
                                If nivelAcesso = 3 Then
                                    status = reader(5)
                                End If
                            End If
                        End If

                        status = ""

                        If status = 1 Then
                            tool.Enabled = True
                        Else
                            tool.Enabled = False
                        End If
                        reader.Close()
                    Else
                        reader.Close()
                    End If

                Next tool

            Next menu
        Catch ex As Exception
            MsgBox("Erro ao carregar acessos! ", +ex.Message)
        End Try
    End Sub
    Sub TotalTitulos()

        Abrir()
        Try
            Dim data As Date
            Dim data0 As Date
            Dim data2 As String
            Dim dataFormatada As String

            data = Date.Now().AddDays(30)
            dataFormatada = data.ToString("yyyy-MM-dd")
            data2 = Now.ToString("yyyy-MM-dd")

            'CONSULTA DE TITULOS A VENCER EM 30 DIAS
            Dim cmd As MySqlCommand
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable


            sql = "SELECT v.cliente, v.produto, v.quantidade,  v.valor_total, c.saldo_venda, v.data_vencimento FROM venda as v INNER JOIN venda_cabecalho as c ON v.id_venda = c.id_venda WHERE v.data_vencimento  >= '" & data2 & "' and v.data_vencimento <= '" & dataFormatada & "' and c.saldo_venda >0 "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid_AVencer.DataSource = dt

            'CONSULTA DE TITULOS A VENCER EM -30 DIAS
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            Dim da1 As MySqlDataAdapter
            Dim dt1 As New DataTable

            Dim dataFormatada2 As String
            data0 = Date.Now().AddDays(-30)
            dataFormatada2 = data0.ToString("yyyy-MM-dd")

            sql1 = "SELECT v.cliente, v.produto, v.quantidade, v.valor_total, c.saldo_venda, v.data_vencimento FROM venda as v INNER JOIN venda_cabecalho as c ON v.id_venda = c.id_venda WHERE v.data_vencimento  <= '" & data2 & "' and c.saldo_venda >0 "
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()
            da1 = New MySqlDataAdapter(sql1, con)
            da1.Fill(dt1)
            DataGrid_Vencidos.DataSource = dt1


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Sub TOTAL()
        Dim linha As DataGridViewRow
        Dim linha2 As DataGridViewRow
        Dim valor As Decimal
        Dim valor2 As Decimal
        For Each linha In DataGrid_AVencer.Rows
            valor = valor + linha.Cells(4).Value
        Next
        LblAVencer.Text = valor
        LblAVencer.Text = Format(valor, "R$ 00.00")
        ' MsgBox(valor)
        For Each linha2 In DataGrid_Vencidos.Rows
            valor2 = valor2 + linha2.Cells(4).Value
        Next

        LblVencidos.Text = valor2
        LblVencidos.Text = Format(valor2, "R$ 00.00")
    End Sub
    Private Sub BtnContasPagar_Click(sender As Object, e As EventArgs) Handles BtnContasPagar.Click
        Dim form = New FrmPagamento
        form.ShowDialog()

    End Sub

    Private Sub PagamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxMvto1_05.Click
        Dim form = New FrmPagarTitulo
        form.ShowDialog()

    End Sub

    Private Sub NotasEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCons1_01.Click
        Dim form = New FrmNotasEntrada
        form.ShowDialog()
    End Sub

    Private Sub PagamentosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CboxCons1_02.Click
        Dim form = New FrmPagamentoEfetuado
        form.ShowDialog()

    End Sub

    Private Sub SaidaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CboxMvto1_03.Click
        Dim form = New FrmVenda
        form.ShowDialog()
    End Sub

    Private Sub PedidoDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCons1_04.Click
        Dim form = New FrmPedidoCabecalho
        form.ShowDialog()
    End Sub


    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxExcluir1_02.Click
        statusBtn = "Visible"
        Dim form = New FrmNotasEntrada
        form.ShowDialog()

    End Sub

    Private Sub ExcluirPagamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CboxExcluir1_03.Click
        statusBtn = "Visible"
        Dim form = New FrmPagamentoEfetuado
        form.ShowDialog()
    End Sub

    Private Sub ExcluirPedidoDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxExcluir1_01.Click
        statusBtn = "Visible"
        Dim form = New FrmPedidoCabecalho
        form.ShowDialog()
    End Sub

    Private Sub VendasRegistradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCons1_05.Click
        Dim form = New FrmVendaCabecalho
        form.ShowDialog()
    End Sub

    Private Sub ExcluirVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxExcluir1_04.Click
        statusBtn = "Visible"
        Dim form = New FrmVendaCabecalho
        form.ShowDialog()
    End Sub

    Private Sub BtnContasReceber_Click(sender As Object, e As EventArgs) Handles BtnContasReceber.Click
        Dim form = New FrmRecebimento
        form.ShowDialog()
    End Sub

    Private Sub RecebimentosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CboxCons1_03.Click
        Dim form = New FrmRecebimentosEfetuados
        form.ShowDialog()
    End Sub

    Private Sub ExcluirRecebimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxExcluir1_05.Click
        statusBtn = "Visible"
        Dim form = New FrmRecebimentosEfetuados
        form.ShowDialog()
    End Sub

    Private Sub BtnEstoque_Click(sender As Object, e As EventArgs) Handles BtnEstoque.Click
        Dim form = New FrmSaldoEstoque
        form.ShowDialog()
    End Sub

    Private Sub SaldoEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCons1_06.Click
        Dim form = New FrmSaldoEstoque
        form.ShowDialog()
    End Sub

    Private Sub EstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxRel1_06.Click
        Dim form = New FrmReportEstoque
        form.ShowDialog()
    End Sub

    Private Sub BtnRelVendas_Click(sender As Object, e As EventArgs) Handles BtnRelVendas.Click
        Dim form = New FrmReportVendas
        form.ShowDialog()

    End Sub

    Private Sub VendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxRel1_01.Click
        Dim form = New FrmReportVendas
        form.ShowDialog()

    End Sub

    Private Sub RecebimentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxRel1_02.Click
        Dim form = New FrmReportRecebimentos
        form.ShowDialog()
    End Sub

    Private Sub ContasAReceberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxRel1_03.Click
        Dim form = New FrmReportTitulosAbert
        form.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxRel1_05.Click
        Dim form = New FrmReportCompras
        form.ShowDialog()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxRel1_07.Click
        Dim form = New ReportPedidos
        form.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New FrmReportRecebimentos
        form.ShowDialog()
    End Sub

    Private Sub FrmTelaInicial_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TotalTitulos()
        TOTAL()
    End Sub

    Private Sub TítulosVencidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxRel1_04.Click
        Dim form = New FrmReporteVencidos
        form.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLogoff.Click
        Dim form = New BotoesControle
        form.ShowDialog()
    End Sub

    Private Sub NivelDeAcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxConfig_01.Click
        Dim form = New FrmNivelAcesso
        form.ShowDialog()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCad1_03.Click
        Dim form = New FrmFornecedor
        form.ShowDialog()
    End Sub
End Class