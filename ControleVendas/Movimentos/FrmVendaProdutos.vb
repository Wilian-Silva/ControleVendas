Imports MySql.Data.MySqlClient

Public Class FrmVendaProdutos

    Private ReadOnly Table1 As New DataTable("MyTable")
    Dim proximo As Integer
    Dim anterior As Integer
    Dim maximo As Integer

    Private Sub FrmPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListarUltimaVenda()
        LimparVariaveisGlobais()


    End Sub
    Private Sub HabilitarCampos()

        DataVenda.Enabled = True
        TxtQuantidade.Enabled = True
        TxtValorUnit.Enabled = True
        BtnPesqCliente.Enabled = True
        BtnPesqProduto.Enabled = True
        TxtProduto.ReadOnly = True
        TxtCliente.ReadOnly = True
        TxtProduto.Enabled = True
        TxtCliente.Enabled = True
        BtnEditar_venda.Enabled = False
        BtnIncluirItem_venda.Enabled = False

    End Sub

    Private Sub HabilitarCamposEdicao()

        TxtQuantidade.Enabled = True
        TxtValorUnit.Enabled = True
        BtnPesqProduto.Enabled = True


    End Sub

    Private Sub DesabilitarCampos()

        DataVenda.Enabled = False
        TxtQuantidade.Enabled = False
        TxtValorUnit.Enabled = False
        BtnPesqCliente.Enabled = False
        BtnPesqProduto.Enabled = False
        TxtProduto.Enabled = False
        BtnEditar_venda.Enabled = True
        TxtProduto.ReadOnly = True
        TxtCliente.ReadOnly = True
        BtnIncluirItem_venda.Enabled = True
    End Sub
    Private Sub LimparCampos()

        TxtIdRegistro.Text = ""
        TxtItem.Text = ""
        DataVenda.Value = Now()
        TxtCodCliente.Text = ""
        TxtCliente.Text = ""
        TxtCodProduto.Text = ""
        TxtProduto.Text = ""
        TxtQuantidade.Text = ""
        TxtValorUnit.Text = ""
        TxtValorTotal.Text = ""
        TxtTotalVenda.Text = ""
        DataGrid.DataSource = Nothing
        Table1.Columns.Clear()
        Table1.Rows.Clear()
        IncluirPedido = ""
        editarpedido = ""

    End Sub

    Private Sub LimparCampossemdg()

        TxtIdRegistro.Text = ""
        TxtItem.Text = ""
        DataVenda.Value = Now()
        TxtCodCliente.Text = ""
        TxtCliente.Text = ""
        TxtCodProduto.Text = ""
        TxtProduto.Text = ""
        TxtQuantidade.Text = ""
        TxtValorUnit.Text = ""
        TxtValorTotal.Text = ""
        editarpedido = ""

    End Sub
    Sub Editar_Cores()

        TxtProduto.BackColor = Color.Salmon
        TxtQuantidade.BackColor = Color.Salmon
        TxtValorUnit.BackColor = Color.Salmon
        TxtCliente.BackColor = Color.Salmon

    End Sub
    Sub Limpar_cores()
        TxtCliente.BackColor = Color.White
        TxtProduto.BackColor = Color.White
        TxtQuantidade.BackColor = Color.White
        TxtValorUnit.BackColor = Color.White

    End Sub
    Private Sub FormatarGrid()
        'DataGrid.Columns(0).Visible = False

        DataGrid.Columns(0).HeaderText = "Id Reg."
        DataGrid.Columns(1).HeaderText = "Nº Venda"
        DataGrid.Columns(2).HeaderText = "Item"
        DataGrid.Columns(3).HeaderText = "Data Venda"
        DataGrid.Columns(4).HeaderText = "Cód. Cliente"
        DataGrid.Columns(5).HeaderText = "Cliente"
        DataGrid.Columns(6).HeaderText = "Cód. Produto"
        DataGrid.Columns(7).HeaderText = "Produto"
        DataGrid.Columns(8).HeaderText = "Qtd."
        DataGrid.Columns(9).HeaderText = "Vlr. Unit."
        DataGrid.Columns(10).HeaderText = "Valor Total"
        DataGrid.Columns(11).HeaderText = "Custo Total"

        DataGrid.Columns(0).Width = 1
        DataGrid.Columns(1).Width = 50
        DataGrid.Columns(2).Width = 40
        DataGrid.Columns(4).Width = 50
        DataGrid.Columns(5).Width = 150
        DataGrid.Columns(6).Width = 50
        DataGrid.Columns(7).Width = 200
        DataGrid.Columns(8).Width = 40
        DataGrid.Columns(9).Width = 80

        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(9).DefaultCellStyle.Format = "c"
        DataGrid.Columns(10).DefaultCellStyle.Format = "c"
        DataGrid.Columns(11).DefaultCellStyle.Format = "c"

    End Sub
    Sub DadosCabecalho()
        On Error Resume Next
        TxtIdRegistro.Text = DataGrid.CurrentRow.Cells(1).Value
        TxtItem.Text = DataGrid.CurrentRow.Cells(2).Value
        DataVenda.Value = DataGrid.CurrentRow.Cells(3).Value
        TxtCodCliente.Text = DataGrid.CurrentRow.Cells(4).Value
        TxtCliente.Text = DataGrid.CurrentRow.Cells(5).Value
        TxtCodProduto.Text = DataGrid.CurrentRow.Cells(6).Value
        TxtProduto.Text = DataGrid.CurrentRow.Cells(7).Value
        TxtQuantidade.Text = DataGrid.CurrentRow.Cells(8).Value
        TxtValorUnit.Text = DataGrid.CurrentRow.Cells(9).Value
        TxtValorTotal.Text = DataGrid.CurrentRow.Cells(10).Value
    End Sub
    Sub ListarUltimaVenda()
        ' Stop
        Try

            Abrir()
            'VERIFICAR ULTIMO ID NO BANCO 
            Dim cmdp As MySqlCommand
            Dim sql1 As String
            Dim ultima As MySqlDataReader

            sql1 = "SELECT id_venda FROM venda WHERE id_venda=(SELECT MAX(id_venda) FROM venda) "
            cmdp = New MySqlCommand(sql1, con)
            ultima = cmdp.ExecuteReader()

            If (ultima.Read()) Then
                maximo = ultima("id_venda")
                ultima.Close()
            Else
                ultima.Close()
            End If

        Catch ex As Exception
            MsgBox("Erro ao consultar ultimo id_venda!! " + ex.Message)
        End Try

        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT * FROM venda WHERE id_venda= '" & maximo & "' order by item asc "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            ListarDuplicatas()

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If

            TotalDatagrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Public Sub ListarDuplicatas()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT * FROM duplicatas_receber WHERE id_venda = '" & TxtIdRegistro.Text & "' "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridDuplicatas.DataSource = dt

            FormatarGridDuplicatas()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Public Sub FormatarGridDuplicatas()
        ' Stop
        DataGridDuplicatas.Columns(7).Visible = False
        DataGridDuplicatas.Columns(8).Visible = False
        DataGridDuplicatas.Columns(9).Visible = False

        DataGridDuplicatas.Columns(0).HeaderText = "Id. Dup."
        DataGridDuplicatas.Columns(1).HeaderText = "Parcela"
        DataGridDuplicatas.Columns(2).HeaderText = "Nº Venda"
        DataGridDuplicatas.Columns(3).HeaderText = "Data Venda"
        DataGridDuplicatas.Columns(4).HeaderText = "Data Vencimento"
        DataGridDuplicatas.Columns(5).HeaderText = "Valor Parcela"
        DataGridDuplicatas.Columns(6).HeaderText = "Observação"



        DataGridDuplicatas.Columns(5).DefaultCellStyle.Format = "c"

        TotalDatagridDuplicatas()

        TotalNfe_TotalDuplicatas()

    End Sub


    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNova_venda.Click
        If MsgBox("Deseja incluir novo venda?", vbYesNo, " Novo Venda") = vbYes Then

            HabilitarCampos()
            LimparCampos()
            GerarIdRegistro()

            TxtItem.Text = 1
            IncluirPedido = "True"
        End If
    End Sub

    Sub GerarIdRegistro()

        Try
            Abrir()

            'VERIFICAR ULTIMO ID NO BANCO E GERAR PROXIMO
            Dim cmd As MySqlCommand
            Dim sql As String
            Dim ultima As MySqlDataReader

            sql = "SELECT id_venda FROM venda_cabecalho WHERE id_venda=(SELECT MAX(id_venda) FROM venda_cabecalho) "
            cmd = New MySqlCommand(sql, con)
            ultima = cmd.ExecuteReader()

            If (ultima.Read()) Then
                TxtIdRegistro.Text = ultima("id") + 1
            Else
                TxtIdRegistro.Text = 1

                ultima.Close()
            End If

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try
    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        If DataGrid.RowCount < 1 Then
            MsgBox("Adicione registro para salvar!!", MsgBoxStyle.Information, "Salvar")
            Exit Sub
        End If

        Abrir()

        Try
            'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
            Dim cmd As MySqlCommand
            Dim sqls As String
            Dim data As String

            data = DataVenda.Value.ToString("yyyy-MM-dd")

            Dim i As Integer
            If MsgBox("Deseja salvar esse pedido?", vbYesNo + vbQuestion) = vbYes Then

                'ADIONANDO VARIAS LINHAS NO BANCO DE DADOS COM DATAGRID

                For i = 0 To DataGrid.RowCount - 1

                    sqls = "INSERT INTO venda (id_venda, item, data_venda, cod_cliente, cliente, cod_produto, produto, quantidade, valor_unitario, valor_total, custo_total ) VALUES (@id_venda, @item, '" & data & "', @cod_cliente, @cliente, @cod_produto, @produto, @quantidade, @valor_unitario, @valor_total, @custo_total)"
                    cmd = New MySqlCommand(sqls, con)
                    With cmd
                        .Parameters.AddWithValue("@id_venda", CInt(DataGrid.Rows(i).Cells(1).Value.ToString))
                        .Parameters.AddWithValue("@item", CInt(DataGrid.Rows(i).Cells(2).Value.ToString))
                        .Parameters.AddWithValue("@cod_cliente", CInt(DataGrid.Rows(i).Cells(3).Value.ToString))
                        .Parameters.AddWithValue("@cliente", DataGrid.Rows(i).Cells(4).Value.ToString)
                        .Parameters.AddWithValue("@cod_produto", CInt(DataGrid.Rows(i).Cells(5).Value.ToString))
                        .Parameters.AddWithValue("@produto", DataGrid.Rows(i).Cells(6).Value.ToString)
                        .Parameters.AddWithValue("@quantidade", CInt(DataGrid.Rows(i).Cells(7).Value.ToString))
                        .Parameters.AddWithValue("@valor_unitario", CDbl(DataGrid.Rows(i).Cells(8).Value.ToString))
                        .Parameters.AddWithValue("@valor_total", CDbl(DataGrid.Rows(i).Cells(9).Value.ToString))
                        .Parameters.AddWithValue("@custo_total", CDbl(DataGrid.Rows(i).Cells(10).Value.ToString))
                        cmd.ExecuteNonQuery()
                    End With

                Next

                'PROGRAMANDO A INSERÇÃO NA TABELA PEDIDO_CABEÇALHO

                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim statusPedido As String
                statusPedido = "Aberto"

                data = DataVenda.Value.ToString("yyyy-MM-dd")
                sql = "INSERT INTO venda_cabecalho (id_venda, data_venda, cod_cliente, cliente, valor_total, saldo_venda VALUES ('" & TxtIdRegistro.Text & "', '" & data & "', '" & TxtCodCliente.Text & "','" & TxtCliente.Text & "', '" & TxtTotalVenda.Text.Replace(",", ".") & "', '" & TxtTotalVenda.Text.Replace(",", ".") & "' )"
                cmdp = New MySqlCommand(sql, con)
                cmdp.ExecuteNonQuery()

                LimparCampos()

                ListarUltimaVenda()

                DesabilitarCampos()

                DadosCabecalho()

                Limpar_cores()

                MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

            End If
        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try

    End Sub

    Private Sub BtnExluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        If TxtIdRegistro.Text <> "" Then

            If MsgBox("Deseja excluir a venda de " + TxtCliente.Text + "?", vbYesNo, "Pedido") = vbYes Then


                Try
                    Abrir()
                    'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    Dim codvenda As String
                    codvenda = TxtIdRegistro.Text

                    sql = "DELETE FROM vendas where pedido = '" & codvenda & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()


                    Dim cmd1 As MySqlCommand
                    Dim sql1 As String
                    sql1 = "DELETE FROM venda_cabecalho where id_venda = '" & codvenda & "' "
                    cmd1 = New MySqlCommand(sql1, con)
                    cmd1.ExecuteNonQuery()

                    Atualizar_Saldo_Estoque()

                    MsgBox("Venda excluída com sucesso!!", MsgBoxStyle.Information, "Excluir")

                    ListarUltimaVenda()

                Catch ex As Exception
                    MsgBox("Erro ao excluir!!" + ex.Message)
                End Try


            End If
        Else

            MsgBox("Selecione um pedido para excluir!!", MsgBoxStyle.Information, "Excluir")
        End If
    End Sub

    Private Sub Atualizar_Saldo_Estoque()
        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            Dim saldoItem As Integer
            Dim codItem As Integer
            Dim qtd As Integer
            Dim saldoEstoque As Integer


            For i = 0 To DataGrid.RowCount - 1

                codItem = CInt(DataGrid.Rows(i).Cells(1).Value.ToString)
                qtd = CInt(DataGrid.Rows(i).Cells(3).Value.ToString)

                Dim cmdp As MySqlCommand
                Dim sqlp As String
                Dim ultima As MySqlDataReader

                sqlp = "SELECT saldo_estoque FROM produtos WHERE id= '" & codItem & "'"
                cmdp = New MySqlCommand(sqlp, con)
                ultima = cmdp.ExecuteReader()

                If (ultima.Read()) Then
                    saldoEstoque = ultima("saldo_estoque")
                    ultima.Close()
                Else
                    ultima.Close()
                End If

                saldoItem = saldoEstoque + qtd

                sql = "UPDATE produtos SET saldo_estoque = '" & saldoItem & "' WHERE id = '" & codItem & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

            Next

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try

    End Sub
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub
    Private Sub BtnPesqCliente_Click(sender As Object, e As EventArgs) Handles BtnPesqCliente.Click
        pesquisarCliente = "True"
        Dim form = New FrmClientes
        form.ShowDialog()
    End Sub
    Private Sub BtnPesqProduto_Click(sender As Object, e As EventArgs) Handles BtnPesqProduto.Click
        pesquisarProduto = "True"
        Dim form = New FrmProdutos
        form.ShowDialog()
    End Sub
    Private Sub TxtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantidade.TextChanged

        On Error Resume Next
        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Double.TryParse(TxtValorUnit.Text, dbl1)
        Double.TryParse(TxtQuantidade.Text, dbl2)

        TxtValorTotal.Text = (dbl1 * dbl2).ToString("n")

    End Sub
    Private Sub TxtValorUnit_TextChanged(sender As Object, e As EventArgs) Handles TxtValorUnit.TextChanged
        On Error Resume Next
        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Double.TryParse(TxtValorUnit.Text, dbl1)
        Double.TryParse(TxtQuantidade.Text, dbl2)

        TxtValorTotal.Text = (dbl1 * dbl2).ToString("n")

    End Sub
    Private Sub BtndAdicionarItem_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        ' Stop
        If editarpedido = "Editar" Then Exit Sub
        If IncluirPedido = "True" Then

            Limpar_cores()

            If TxtCodCliente.Text <> "" And TxtCodProduto.Text <> "" And TxtQuantidade.Text <> "" And TxtValorUnit.Text <> "" Then

                If DataGrid.Columns.Count < 1 Then

                    Table1.Columns.Add("Id Reg.")
                    Table1.Columns.Add("Nº Venda")
                    Table1.Columns.Add("Item")
                    Table1.Columns.Add("Data Venda")
                    Table1.Columns.Add("Cód. Cliente")
                    Table1.Columns.Add("Cliente")
                    Table1.Columns.Add("Cód. Produto")
                    Table1.Columns.Add("Produto")
                    Table1.Columns.Add("Qtd.")
                    Table1.Columns.Add("Vlr. Unit.")
                    Table1.Columns.Add("Valor Total")

                    Dim bs As New BindingSource()
                    bs.DataSource = Table1
                    DataGrid.DataSource = bs

                    Table1.Rows.Add("", TxtIdRegistro.Text, TxtItem.Text, DataVenda.Value.ToShortDateString, TxtCodCliente.Text, TxtCliente.Text, TxtCodProduto.Text, TxtProduto.Text, TxtQuantidade.Text, TxtValorUnit.Text, TxtValorTotal.Text)

                    TxtItem.Text = TxtItem.Text + 1

                    ''FORMATAR DATAGRI

                    DataGrid.Columns(0).Width = 1
                    DataGrid.Columns(1).Width = 50
                    DataGrid.Columns(2).Width = 40
                    DataGrid.Columns(4).Width = 50
                    DataGrid.Columns(5).Width = 150
                    DataGrid.Columns(6).Width = 50
                    DataGrid.Columns(7).Width = 200
                    DataGrid.Columns(8).Width = 40
                    DataGrid.Columns(9).Width = 80

                    DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    DataGrid.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    DataGrid.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                    DataGrid.Columns(9).DefaultCellStyle.Format = "c"
                    DataGrid.Columns(10).DefaultCellStyle.Format = "c"


                    BtnPesqCliente.Enabled = False
                    TxtCliente.Enabled = False
                    DataVenda.Enabled = False

                    LimparCamposAddItemPedido()

                    TotalDatagrid()
                    TotalNfe_TotalDuplicatas()

                Else

                    Table1.Rows.Add(TxtItem.Text, TxtIdRegistro.Text, TxtItem.Text, DataVenda.Value.ToShortDateString, TxtCodCliente.Text, TxtCliente.Text, TxtCodProduto.Text, TxtProduto.Text, TxtQuantidade.Text, TxtValorUnit.Text, TxtValorTotal.Text)

                    TxtItem.Text = TxtItem.Text + 1

                    TotalDatagrid()
                    TotalNfe_TotalDuplicatas()
                    LimparCamposAddItemPedido()
                End If

            Else
                Editar_Cores()


                MsgBox("Campos em branco ou vazios", MsgBoxStyle.Information, "Adicionar item")
            End If
        End If
    End Sub
    Sub LimparCamposAddItemPedido()
        TxtCodProduto.Text = ""
        TxtProduto.Text = ""
        TxtQuantidade.Text = ""
        TxtValorUnit.Text = ""
        TxtValorTotal.Text = ""
    End Sub
    Private Sub TotalDatagrid()

        'CALCULANDO SOMA TOTAL
        On Error Resume Next
        Dim total As Decimal = 0
        For i = 0 To DataGrid.Rows.Count - 1
            total += +DataGrid.Rows(i).Cells(10).Value
        Next
        TxtTotalVenda.Text = total

    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click

        If MsgBox("Deseja limpar registros?", vbYesNo, "Limpar registros") = vbYes Then
            LimparCampos()
        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar_venda.Click


        If TxtItem.Text <> "" Then

            If MsgBox("Deseja editar o item " & TxtItem.Text & " do pedido " & TxtIdRegistro.Text & "?", vbYesNo, "Editar") = vbYes Then

                Dim form = New FrmAddItemPedido

                form.TxtItem.Text = TxtItem.Text
                form.TxtIdRegistro.Text = TxtIdRegistro.Text

                form.TxtCodFornecedor.Text = TxtCodCliente.Text
                form.TxtFornecedor.Text = TxtCliente.Text
                form.DataPed.Value = DataVenda.Value

                form.TxtCodFornecedor.Text = TxtCodCliente.Text
                form.TxtFornecedor.Text = TxtCliente.Text
                form.TxtQuantidade.Text = TxtQuantidade.Text
                form.TxtValorUnit.Text = TxtValorUnit.Text
                form.TxtCodProduto.Text = TxtCodProduto.Text
                form.TxtProduto.Text = TxtProduto.Text

                editarpedido = "Editar"

                form.ShowDialog()


            End If
        Else

            MsgBox("Selecione um registro para editar!!", MsgBoxStyle.Information, "Editar")

        End If


    End Sub



    Private Sub FrmPedido_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        LimparCampos()
        LimparVariaveisGlobais()

    End Sub

    Private Sub BtnPesqPedido_Click(sender As Object, e As EventArgs) Handles BtnPesqPedido.Click

        pedidoPesquisar = "True"
        Dim form = New FrmPedidoCabecalho
        form.ShowDialog()

    End Sub

    Sub PesquisarPedido()


        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT p.id, p.pedido, p.item, p.descricao, p.data_emissao, p.cod_fornecedor, p.fornecedor, p.cod_produto, p.produto, p.quantidade, p.valor_unitario, p.valor_total, c.status FROM pedidos as p INNER JOIN pedido_cabecalho as c ON p.pedido = c.id WHERE p.pedido= '" & TxtIdRegistro.Text & "' order by p.item asc "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If

            TotalDatagrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Private Sub BtnCacelar_Click(sender As Object, e As EventArgs) Handles BtnCacelar.Click
        LimparCampos()
        DesabilitarCampos()
        ListarUltimaVenda()
        Limpar_cores()
    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick

        If e.RowIndex > -1 Then

            If IncluirPedido = "True" Then
                Exit Sub

            Else
                DadosCabecalho()
            End If

        End If
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        ListarPedidoAnterior()
    End Sub

    Private Sub FrmPedido_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If pedidoPesquisar = "True" Then
            pedidoPesquisar = ""
            pedidoPesquisar = ""
            nomePedido = ""
            StatusPedido = ""
            totalPedido = ""
            codFornecedor = ""
            nomeFornecedor = ""
        End If

        If pesquisarCliente = "True" Then
            TxtCodCliente.Text = codCliente
            TxtCliente.Text = nomeCliente
            pesquisarCliente = ""
        End If

        If pesquisarProduto = "True" Then
            TxtCodProduto.Text = codProduto
            TxtProduto.Text = nomeProduto
            TxtValorUnit.Text = valorUnit
            pesquisarProduto = ""
        End If

        If IncluirPedido = "True" Then
            DataGridDuplicatas.DataSource = bs
            TotalDatagridDuplicatas()
            TotalNfe_TotalDuplicatas()
        End If

    End Sub
    Public Sub TotalNfe_TotalDuplicatas()

        Dim soma As Double
        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Double.TryParse(TxtTotalVenda.Text, dbl1)
        Double.TryParse(TxtTotalDuplicatas.Text, dbl2)

        soma = (dbl1 - dbl2).ToString("n")

        LblSaldo.Text = ""
        If soma > 0 Or soma < 0 Then
            LblSaldo.Text = "Valor total das duplicatas diferente do valor total da venda!"
        End If

    End Sub
    Public Sub TotalDatagridDuplicatas()

        'CALCULANDO SOMA TOTAL
        On Error Resume Next
        Dim total As Decimal = 0
        For i = 0 To DataGridDuplicatas.Rows.Count - 1
            total += DataGridDuplicatas.Rows(i).Cells(5).Value
        Next
        TxtTotalDuplicatas.Text = total

    End Sub

    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        ListarProximoPedido()
    End Sub
    Private Sub BtnExcluirItemPedido_Click(sender As Object, e As EventArgs) Handles BtnExcluirItem_venda.Click

        If IncluirPedido = "True" Then

            If DataGrid.Rows.Count < 1 Then
                Exit Sub

            Else
                DataGrid.Rows.Remove(DataGrid.CurrentRow)
            End If

        Else

            If TxtIdRegistro.Text <> "" And TxtItem.Text <> "" Then

                If MsgBox("Deseja excluir o item " + TxtItem.Text + " da venda" + TxtIdRegistro.Text + "?", vbYesNo, "Pedido") = vbYes Then

                    Try
                        Abrir()
                        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                        Dim cmd As MySqlCommand
                        Dim sql As String

                        sql = "DELETE FROM pedidos where pedido = '" & TxtIdRegistro.Text & "' AND item = '" & TxtItem.Text & "' "
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        '.....................................................................................
                        'CONSULTAR TOTAL NA TABELA PEDIDOS
                        Dim dg As New DataGridView
                        Dim da As MySqlDataAdapter
                        Dim sql2 As String
                        Dim dt As New DataTable
                        Dim total As String

                        sql2 = "SELECT SUM(valor_total) as TOTAL FROM pedidos WHERE pedido =  '" & TxtIdRegistro.Text & "' "
                        da = New MySqlDataAdapter(sql2, con)
                        da.Fill(dt)
                        total = dt.Rows(0)("TOTAL").ToString()

                        '............................................................................
                        'ATUALIZAR TOTAL PEDIDO
                        If DataGrid.Rows.Count > 1 Then
                            Dim cmd1 As MySqlCommand
                            Dim sql1 As String
                            sql1 = "UPDATE pedido_cabecalho SET total= '" & total & "' WHERE id =  '" & TxtIdRegistro.Text & "' "
                            cmd1 = New MySqlCommand(sql1, con)
                            cmd1.ExecuteNonQuery()

                        Else

                            Dim cmd3 As MySqlCommand
                            Dim sql3 As String
                            sql3 = "DELETE FROM pedido_cabecalho WHERE id =  '" & TxtIdRegistro.Text & "' "
                            cmd3 = New MySqlCommand(sql3, con)
                            cmd3.ExecuteNonQuery()

                        End If

                        MsgBox("Item excluído com sucesso!!", MsgBoxStyle.Information, "Excluir")

                        ListarUltimaVenda()

                    Catch ex As Exception
                        MsgBox("Erro ao excluir!!" + ex.Message)
                    End Try


                End If
            Else

                MsgBox("Selecione um item para excluir!!", MsgBoxStyle.Information, "Excluir")
            End If

        End If



    End Sub

    Sub ListarProximoPedido()

        Try

            Try
                Abrir()

                'VERIFICAR ULTIMO ID NO BANCO 
                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim ultima As MySqlDataReader

                sql = "SELECT id FROM pedido_cabecalho WHERE id=(SELECT MAX(id) FROM pedido_cabecalho) "
                cmdp = New MySqlCommand(sql, con)
                ultima = cmdp.ExecuteReader()

                If (ultima.Read()) Then
                    maximo = ultima("id")
                    ultima.Close()
                Else
                    ultima.Close()
                End If

            Catch ex As Exception
                MsgBox("Erro ao Salvar!! " + ex.Message)
            End Try
            '.........................................................................................................

            If TxtIdRegistro.Text <> "" Then
                proximo = TxtIdRegistro.Text + 1
            Else
                proximo = 1
            End If

            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sqlp As String

Line1:
            If proximo > maximo Then
                Exit Sub
            End If

            sqlp = "SELECT * FROM pedido_cabecalho WHERE id = '" & proximo & "' "
            cmd = New MySqlCommand(sqlp, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                ProximoRegistro()

                Exit Sub
            Else
                reader.Close()
                proximo += +1
                GoTo Line1
            End If


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Sub ProximoRegistro()
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT p.id, p.pedido, p.item, p.descricao, p.data_emissao, p.cod_fornecedor, p.fornecedor, p.cod_produto, p.produto, p.quantidade, p.valor_unitario, p.valor_total, c.status FROM pedidos as p INNER JOIN pedido_cabecalho as c ON p.pedido = c.id WHERE p.pedido= '" & proximo & "' order by p.item asc "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If

            TotalDatagrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Sub ListarPedidoAnterior()

        Try
            If TxtIdRegistro.Text <> "" Then
                anterior = TxtIdRegistro.Text - 1
            Else
                anterior = 1
            End If
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sqlp As String
Line1:
            If anterior = 0 Then
                Exit Sub
            End If

            sqlp = "SELECT * FROM pedido_cabecalho WHERE id = '" & anterior & "' "
            cmd = New MySqlCommand(sqlp, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                RegistroAnterior()

                Exit Sub
            Else
                reader.Close()
                anterior += -1
                GoTo Line1
            End If



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try



    End Sub

    Sub RegistroAnterior()


        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT p.id, p.pedido, p.item, p.descricao, p.data_emissao, p.cod_fornecedor, p.fornecedor, p.cod_produto, p.produto, p.quantidade, p.valor_unitario, p.valor_total, c.status FROM pedidos as p INNER JOIN pedido_cabecalho as c ON p.pedido = c.id WHERE p.pedido= '" & anterior & "' order by p.item asc "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If

            TotalDatagrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluirItem_venda.Click

        Dim linhaPed As Integer


        Try
            Abrir()
            Dim cmdp As MySqlCommand
            Dim sql As String
            Dim ultima As MySqlDataReader


            sql = "SELECT MAX(item) AS Item FROM pedidos WHERE pedido = '" & TxtIdRegistro.Text & "' "

            cmdp = New MySqlCommand(sql, con)
            ultima = cmdp.ExecuteReader()

            ultima.Read()

            If Not IsDBNull(ultima("item")) Then
                linhaPed = ultima("item")
                ultima.Close()
            Else
                ultima.Close()
            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


        Dim form = New FrmAddItemPedido

        form.TxtItem.Text = linhaPed + 1
        form.TxtIdRegistro.Text = TxtIdRegistro.Text
        form.TxtCodFornecedor.Text = TxtCodCliente.Text
        form.TxtFornecedor.Text = TxtCliente.Text
        form.DataPed.Value = DataVenda.Value


        form.ShowDialog()

    End Sub

    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        AtualizarForm()
    End Sub
    Sub AtualizarForm()

        Try

            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT p.id, p.pedido, p.item, p.descricao, p.data_emissao, p.cod_fornecedor, p.fornecedor, p.cod_produto, p.produto, p.quantidade, p.valor_unitario, p.valor_total, c.status FROM pedidos as p INNER JOIN pedido_cabecalho as c ON p.pedido = c.id WHERE p.pedido= '" & TxtIdRegistro.Text & "' order by p.item asc "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If

            TotalDatagrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Private Sub BtnIncluirDuplicata_Click(sender As Object, e As EventArgs) Handles BtnIncluir_duplicata.Click

        Dim form = New FrmDuplicatas()
        form.TxtNotaFiscal.Text = TxtIdRegistro.Text
        form.TxtNotaFiscal.Text = TxtItem.Text
        form.DataEmissao.Value = DataVenda.Value
        form.TxtIdREg.Text = TxtCodCliente.Text
        form.TxtIdREg.Text = TxtCliente.Text

        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Double.TryParse(TxtTotalVenda.Text, dbl1)
        Double.TryParse(TxtTotalDuplicatas.Text, dbl2)

        form.TxtTotalDuplicata.Text = (dbl1 - dbl2).ToString("n")

        form.ShowDialog()

    End Sub
End Class