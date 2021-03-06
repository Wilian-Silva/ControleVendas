Imports MySql.Data.MySqlClient

Public Class FrmPedido
    Private ReadOnly Table1 As New DataTable("MyTable")

    Dim proximo As Integer
    Dim anterior As Integer
    Dim maximo As Integer

    Private Sub FrmPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListarTudoUltimoPedido()
        LimparVariaveisGlobais()
        TxtNumPedido.Text = ""

    End Sub
    Private Sub HabilitarCampos()
        TxtPedido.Enabled = True
        DataPed.Enabled = True
        TxtQuantidade.Enabled = True
        TxtValorUnit.Enabled = True
        BtnPesqFornecedor.Enabled = True
        BtnPesqProduto.Enabled = True
        TxtProduto.ReadOnly = True
        TxtFornecedor.ReadOnly = True
        TxtProduto.Enabled = True
        TxtFornecedor.Enabled = True
        BtnEditar.Enabled = False

        BtnIncluir.Enabled = False
    End Sub

    Private Sub HabilitarCamposEdicao()

        TxtQuantidade.Enabled = True
        TxtValorUnit.Enabled = True
        BtnPesqProduto.Enabled = True


    End Sub

    Private Sub DesabilitarCampos()

        TxtPedido.Enabled = False
        DataPed.Enabled = False
        TxtQuantidade.Enabled = False
        TxtValorUnit.Enabled = False
        BtnPesqFornecedor.Enabled = False
        BtnPesqProduto.Enabled = False
        TxtProduto.Enabled = False
        BtnEditar.Enabled = True
        TxtProduto.ReadOnly = True
        TxtFornecedor.ReadOnly = True
        BtnIncluir.Enabled = True
    End Sub
    Private Sub LimparCampos()

        TxtIdRegistro.Text = ""
        TxtItem.Text = ""
        TxtPedido.Text = ""
        DataPed.Value = Now()
        TxtCodFornecedor.Text = ""
        TxtFornecedor.Text = ""
        TxtCodProduto.Text = ""
        TxtProduto.Text = ""
        TxtQuantidade.Text = ""
        TxtValorUnit.Text = ""
        TxtValorTotal.Text = ""
        TxtTotalPedido.Text = ""
        DataGrid.DataSource = Nothing
        Table1.Columns.Clear()
        Table1.Rows.Clear()
        IncluirPedido = ""
        editarpedido = ""
        TxtStatusPedido.Text = ""
    End Sub

    Private Sub LimparCampossemdg()

        TxtIdRegistro.Text = ""
        TxtItem.Text = ""
        TxtPedido.Text = ""
        DataPed.Value = Now()
        TxtCodFornecedor.Text = ""
        TxtFornecedor.Text = ""
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

    End Sub
    Sub Limpar_cores()

        TxtPedido.BackColor = Color.White
        TxtFornecedor.BackColor = Color.White
        TxtProduto.BackColor = Color.White
        TxtQuantidade.BackColor = Color.White
        TxtValorUnit.BackColor = Color.White

    End Sub
    Private Sub FormatarGrid()
        'DataGrid.Columns(0).Visible = False

        DataGrid.Columns(0).HeaderText = "Id Reg."
        DataGrid.Columns(1).HeaderText = "Pedido"
        DataGrid.Columns(2).HeaderText = "Item"
        DataGrid.Columns(3).HeaderText = "Desc."
        DataGrid.Columns(4).HeaderText = "Data"
        DataGrid.Columns(5).HeaderText = "Cód. Fornec."
        DataGrid.Columns(6).HeaderText = "Fornecedor"
        DataGrid.Columns(7).HeaderText = "Cód. Produto"
        DataGrid.Columns(8).HeaderText = "Produto"
        DataGrid.Columns(9).HeaderText = "Qtd."
        DataGrid.Columns(10).HeaderText = "Vlr. Unit."
        DataGrid.Columns(11).HeaderText = "Valor Total"
        DataGrid.Columns(12).HeaderText = "Status"

        DataGrid.Columns(0).Width = 1
        DataGrid.Columns(1).Width = 50
        DataGrid.Columns(2).Width = 40
        DataGrid.Columns(3).Width = 120
        DataGrid.Columns(4).Width = 90
        DataGrid.Columns(5).Width = 50
        DataGrid.Columns(6).Width = 120
        DataGrid.Columns(7).Width = 50
        DataGrid.Columns(8).Width = 250
        DataGrid.Columns(9).Width = 40
        DataGrid.Columns(12).Width = 60

        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(10).DefaultCellStyle.Format = "c"
        DataGrid.Columns(11).DefaultCellStyle.Format = "c"

    End Sub
    Sub DadosCabecalho()

        On Error Resume Next
        TxtIdRegistro.Text = DataGrid.CurrentRow.Cells(1).Value
        TxtItem.Text = DataGrid.CurrentRow.Cells(2).Value
        TxtPedido.Text = DataGrid.CurrentRow.Cells(3).Value
        DataPed.Value = DataGrid.CurrentRow.Cells(4).Value
        TxtCodFornecedor.Text = DataGrid.CurrentRow.Cells(5).Value
        TxtFornecedor.Text = DataGrid.CurrentRow.Cells(6).Value
        TxtCodProduto.Text = DataGrid.CurrentRow.Cells(7).Value
        TxtProduto.Text = DataGrid.CurrentRow.Cells(8).Value
        TxtQuantidade.Text = DataGrid.CurrentRow.Cells(9).Value
        TxtValorUnit.Text = DataGrid.CurrentRow.Cells(10).Value
        TxtValorTotal.Text = DataGrid.CurrentRow.Cells(11).Value
        TxtStatusPedido.Text = DataGrid.CurrentRow.Cells(12).Value
    End Sub
    Sub ListarTudoUltimoPedido()
        ' Stop
        Try
            Abrir()

            'VERIFICAR ULTIMO ID NO BANCO 
            Dim cmdp As MySqlCommand
            Dim sql1 As String
            Dim ultima As MySqlDataReader

            sql1 = "SELECT pedido FROM pedidos WHERE pedido=(SELECT MAX(pedido) FROM pedidos) "
            cmdp = New MySqlCommand(sql1, con)
            ultima = cmdp.ExecuteReader()

            If (ultima.Read()) Then
                maximo = ultima("pedido")
                ultima.Close()
            Else
                ultima.Close()
            End If

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try



        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT p.id, p.pedido, p.item, p.descricao, p.data_emissao, p.cod_fornecedor, p.fornecedor, p.cod_produto, p.produto, p.quantidade, p.valor_unitario, p.valor_total, c.status FROM pedidos as p INNER JOIN pedido_cabecalho as c ON p.pedido = c.id WHERE p.pedido= '" & maximo & "' order by p.item asc "
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


    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        If MsgBox("Deseja incluir novo pedido?", vbYesNo, " Novo Pedido") = vbYes Then

            HabilitarCampos()
            LimparCampos()
            GerarIdRegistro()

            TxtPedido.Focus()
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

            sql = "SELECT id FROM pedido_cabecalho WHERE id=(SELECT MAX(id) FROM pedido_cabecalho) "
            cmd = New MySqlCommand(sql, con)
            ultima = cmd.ExecuteReader()

            If (ultima.Read()) Then
                TxtIdRegistro.Text = ultima("id") + 1
            Else
                TxtIdRegistro.Text = 1

            End If

            ultima.Close()

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

        'VERIFICAR SE O PEDIDO JÁ EXISTE
        Dim cmdped As MySqlCommand
        Dim readerped As MySqlDataReader
        Dim sqlped As String

        sqlped = "SELECT * FROM pedido_cabecalho WHERE id = '" & TxtIdRegistro.Text & "' "
        cmdped = New MySqlCommand(sqlped, con)
        readerped = cmdped.ExecuteReader
        If readerped.Read = True Then
            readerped.Close()
            MsgBox("Este pedido " + TxtIdRegistro.Text + " já está cadastrado!!", MsgBoxStyle.Information, "Pedido Já Cadastrado")
            Exit Sub
        Else
            readerped.Close()
        End If
        'Stop

        Try
            'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
            Dim cmd As MySqlCommand
            Dim sqls As String
            Dim data As String

            data = DataPed.Value.ToString("yyyy-MM-dd")

            Dim i As Integer
            If MsgBox("Deseja salvar esse pedido?", vbYesNo + vbQuestion) = vbYes Then

                'ADIONANDO VARIAS LINHAS NO BANCO DE DADOS COM DATAGRID

                For i = 0 To DataGrid.RowCount - 1

                    sqls = "INSERT INTO pedidos (pedido, item, descricao, data_emissao, cod_fornecedor, fornecedor, cod_produto, produto, quantidade, valor_unitario, valor_total ) VALUES (@pedido, @item, @descricao, @data_emissao, @cod_fornecedor, @fornecedor, @cod_produto, @produto, @quantidade, @valor_unitario, @valor_total )"
                    cmd = New MySqlCommand(sqls, con)
                    With cmd
                        .Parameters.AddWithValue("@pedido", CInt(DataGrid.Rows(i).Cells(1).Value.ToString))
                        .Parameters.AddWithValue("@item", CInt(DataGrid.Rows(i).Cells(2).Value.ToString))
                        .Parameters.AddWithValue("@descricao", DataGrid.Rows(i).Cells(3).Value.ToString)
                        .Parameters.AddWithValue("@data_emissao", CDate(DataGrid.Rows(i).Cells(4).Value.ToString))
                        .Parameters.AddWithValue("@cod_fornecedor", CInt(DataGrid.Rows(i).Cells(5).Value.ToString))
                        .Parameters.AddWithValue("@fornecedor", DataGrid.Rows(i).Cells(6).Value.ToString)
                        .Parameters.AddWithValue("@cod_produto", CInt(DataGrid.Rows(i).Cells(7).Value.ToString))
                        .Parameters.AddWithValue("@produto", DataGrid.Rows(i).Cells(8).Value.ToString)
                        .Parameters.AddWithValue("@quantidade", CInt(DataGrid.Rows(i).Cells(9).Value.ToString))
                        .Parameters.AddWithValue("@valor_unitario", CDbl(DataGrid.Rows(i).Cells(10).Value.ToString))
                        .Parameters.AddWithValue("@valor_total", CDbl(DataGrid.Rows(i).Cells(11).Value.ToString))
                        cmd.ExecuteNonQuery()
                    End With

                Next

                'PROGRAMANDO A INSERÇÃO NA TABELA PEDIDO_CABEÇALHO

                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim statusPedido As String
                statusPedido = "Aberto"

                data = DataPed.Value.ToString("yyyy-MM-dd")
                sql = "INSERT INTO pedido_cabecalho (id, pedido, cod_fornecedor, fornecedor, data, total, status) VALUES ('" & TxtIdRegistro.Text & "','" & TxtPedido.Text & "','" & TxtCodFornecedor.Text & "','" & TxtFornecedor.Text & "', '" & data & "', '" & TxtTotalPedido.Text.Replace(",", ".") & "', '" & statusPedido & "')"
                cmdp = New MySqlCommand(sql, con)
                cmdp.ExecuteNonQuery()

                LimparCampos()

                ListarTudoUltimoPedido()

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
        If TxtStatusPedido.Text = "Fechado" Then
            MsgBox("Pedido fechado, não pode ser exluído!!", MsgBoxStyle.Information, "Excluir Pedido")
            Exit Sub
        End If

        If TxtIdRegistro.Text <> "" Then

            If MsgBox("Deseja excluir o pedido " + TxtIdRegistro.Text + "?", vbYesNo, "Pedido") = vbYes Then


                Try
                    Abrir()
                    'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    Dim codpedido As String
                    codpedido = TxtIdRegistro.Text

                    sql = "DELETE FROM pedidos where pedido = '" & codpedido & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()


                    Dim cmd1 As MySqlCommand
                    Dim sql1 As String
                    sql1 = "DELETE FROM pedido_cabecalho where id = '" & codpedido & "' "
                    cmd1 = New MySqlCommand(sql1, con)
                    cmd1.ExecuteNonQuery()

                    MsgBox("Pedido excluído com sucesso!!", MsgBoxStyle.Information, "Excluir")

                    ListarTudoUltimoPedido()

                Catch ex As Exception
                    MsgBox("Erro ao excluir!!" + ex.Message)
                End Try


            End If
        Else

            MsgBox("Selecione um pedido para excluir!!", MsgBoxStyle.Information, "Excluir")
        End If
    End Sub
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub
    Private Sub BtnPesqCliente_Click(sender As Object, e As EventArgs) Handles BtnPesqFornecedor.Click
        pesquisarFornecedor = "True"
        Dim form = New FrmFornecedor
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

        'TxtValorTotal.Text = TxtValorUnit.Text * TxtQuantidade.Text
        'TxtValorTotal.Text = Convert.ToDouble(TxtValorTotal.Text).ToString("C")

    End Sub
    Private Sub TxtValorUnit_TextChanged(sender As Object, e As EventArgs) Handles TxtValorUnit.TextChanged
        On Error Resume Next
        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Double.TryParse(TxtValorUnit.Text, dbl1)
        Double.TryParse(TxtQuantidade.Text, dbl2)

        TxtValorTotal.Text = (dbl1 * dbl2).ToString("n")

        'TxtValorTotal.Text = TxtValorUnit.Text * TxtQuantidade.Text
        'TxtValorTotal.Text = Convert.ToDouble(TxtValorTotal.Text).ToString("C")
    End Sub
    Private Sub BtndAdicionarItem_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        If editarpedido = "Editar" Then Exit Sub
        If IncluirPedido = "True" Then

            Limpar_cores()
            TxtFornecedor.BackColor = Color.White
            TxtPedido.BackColor = Color.White

            If TxtCodFornecedor.Text <> "" And TxtCodProduto.Text <> "" And TxtQuantidade.Text <> "" And TxtValorUnit.Text <> "" And TxtPedido.Text <> "" Then

                If DataGrid.Columns.Count < 1 Then

                    Table1.Columns.Add("Id Reg.")
                    Table1.Columns.Add("Pedido")
                    Table1.Columns.Add("Item")
                    Table1.Columns.Add("Desc.")
                    Table1.Columns.Add("Data")
                    Table1.Columns.Add("Cód. Fornec.")
                    Table1.Columns.Add("Fornecedor")
                    Table1.Columns.Add("Cód. Produto")
                    Table1.Columns.Add("Produto")
                    Table1.Columns.Add("Qtd.")
                    Table1.Columns.Add("Vlr. Unit.")
                    Table1.Columns.Add("Valor Total")

                    Dim bs As New BindingSource()
                    bs.DataSource = Table1
                    DataGrid.DataSource = bs

                    Table1.Rows.Add(TxtItem.Text, TxtIdRegistro.Text, TxtItem.Text, TxtPedido.Text, DataPed.Value.ToShortDateString, TxtCodFornecedor.Text, TxtFornecedor.Text, TxtCodProduto.Text, TxtProduto.Text, TxtQuantidade.Text, TxtValorUnit.Text, TxtValorTotal.Text)

                    TxtItem.Text = TxtItem.Text + 1

                    ''FORMATAR DATAGRI
                    DataGrid.Columns(0).Width = 1
                    DataGrid.Columns(1).Width = 50
                    DataGrid.Columns(2).Width = 40
                    DataGrid.Columns(3).Width = 80
                    DataGrid.Columns(4).Width = 90
                    DataGrid.Columns(5).Width = 50
                    DataGrid.Columns(6).Width = 120
                    DataGrid.Columns(7).Width = 50
                    DataGrid.Columns(8).Width = 250
                    DataGrid.Columns(9).Width = 40

                    DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                    DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    DataGrid.Columns(10).DefaultCellStyle.Format = "c"
                    DataGrid.Columns(11).DefaultCellStyle.Format = "c"

                    TotalDatagrid()

                    TxtPedido.Enabled = False
                    BtnPesqFornecedor.Enabled = False
                    TxtFornecedor.Enabled = False
                    DataPed.Enabled = False

                    LimparCamposAddItemPedido()


                Else

                    Table1.Rows.Add(TxtItem.Text, TxtIdRegistro.Text, TxtItem.Text, TxtPedido.Text, DataPed.Value.ToShortDateString, TxtCodFornecedor.Text, TxtFornecedor.Text, TxtCodProduto.Text, TxtProduto.Text, TxtQuantidade.Text, TxtValorUnit.Text, TxtValorTotal.Text)

                    TxtItem.Text = TxtItem.Text + 1

                    TotalDatagrid()
                    LimparCamposAddItemPedido()
                End If

            Else
                Editar_Cores()
                TxtFornecedor.BackColor = Color.Salmon
                TxtPedido.BackColor = Color.Salmon
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
            total += +DataGrid.Rows(i).Cells(11).Value
        Next
        TxtTotalPedido.Text = total
        'TxtTotalPedido.Text = Convert.ToDouble(TxtTotalPedido.Text).ToString("C")
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click

        If MsgBox("Deseja limpar registros?", vbYesNo, "Limpar registros") = vbYes Then
            LimparCampos()
        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtStatusPedido.Text = "Fechado" Then
            MsgBox("Pedido fechado, não pode ser editado!!", MsgBoxStyle.Information, "Editar Pedido")
            Exit Sub
        End If

        If TxtItem.Text <> "" Then

            If MsgBox("Deseja editar o item " & TxtItem.Text & " do pedido " & TxtIdRegistro.Text & "?", vbYesNo, "Editar") = vbYes Then

                Dim form = New FrmAddItemPedido

                form.TxtItem.Text = TxtItem.Text
                form.TxtIdRegistro.Text = TxtIdRegistro.Text
                form.TxtPedido.Text = TxtPedido.Text
                form.TxtCodFornecedor.Text = TxtCodFornecedor.Text
                form.TxtFornecedor.Text = TxtFornecedor.Text
                form.DataPed.Value = DataPed.Value
                form.TxtStatusPedido.Text = TxtStatusPedido.Text
                form.TxtCodFornecedor.Text = TxtCodFornecedor.Text
                form.TxtFornecedor.Text = TxtFornecedor.Text
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
            sql = "SELECT p.id, p.pedido, p.item, p.descricao, p.data_emissao, p.cod_fornecedor, p.fornecedor, p.cod_produto, p.produto, p.quantidade, p.valor_unitario, p.valor_total, c.status FROM pedidos as p INNER JOIN pedido_cabecalho as c ON p.pedido = c.id WHERE p.pedido= '" & TxtNumPedido.Text & "' order by p.item asc "
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
        ListarTudoUltimoPedido()
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
            TxtNumPedido.Text = numeroPedido

            pedidoPesquisar = ""
            pedidoPesquisar = ""
            nomePedido = ""
            StatusPedido = ""
            totalPedido = ""
            codFornecedor = ""
            nomeFornecedor = ""
        End If

        If pesquisarFornecedor = "True" Then
            TxtCodFornecedor.Text = codFornecedor
            TxtFornecedor.Text = nomeFornecedor
            pesquisarFornecedor = ""
        End If

        If pesquisarProduto = "True" Then
            TxtCodProduto.Text = codProduto
            TxtProduto.Text = nomeProduto
            TxtValorUnit.Text = ValorUntPedido
            pesquisarProduto = ""
        End If

        TotalDatagrid()
    End Sub

    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        ListarProximoPedido()
    End Sub



    Private Sub BtnExcluirItemPedido_Click(sender As Object, e As EventArgs) Handles BtnExcluirItemPedido.Click
        If TxtStatusPedido.Text = "Fechado" Then
            MsgBox("Pedido fechado, não pode ser exluído!!", MsgBoxStyle.Information, "Excluir Pedido")
            Exit Sub
        End If
        If IncluirPedido = "True" Then

            If DataGrid.Rows.Count < 1 Then
                Exit Sub

            Else
                DataGrid.Rows.Remove(DataGrid.CurrentRow)
            End If

        Else

            If TxtIdRegistro.Text <> "" And TxtItem.Text <> "" Then

                If MsgBox("Deseja excluir o item " + TxtItem.Text + " do pedido" + TxtIdRegistro.Text + "?", vbYesNo, "Pedido") = vbYes Then

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

                        ListarTudoUltimoPedido()

                    Catch ex As Exception
                        MsgBox("Erro ao excluir!!" + ex.Message)
                    End Try


                End If
            Else

                MsgBox("Selecione um item para excluir!!", MsgBoxStyle.Information, "Excluir")
            End If

        End If



    End Sub

    Private Sub TxtNumPedido_TextChanged(sender As Object, e As EventArgs) Handles TxtNumPedido.TextChanged
        PesquisarPedido()
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

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click

        If TxtStatusPedido.Text <> "" Then


            Dim linhaPed As Integer

            If TxtStatusPedido.Text = "Fechado" Then
                MsgBox("Pedido fechado, não pode ser alterado!!", MsgBoxStyle.Information, "Pedido Fechado")

                Exit Sub
            End If

            Try
                Abrir()
                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim ultima As MySqlDataReader


                sql = "SELECT MAX(item) AS Item FROM pedidos WHERE pedido = '" & TxtIdRegistro.Text & "' "

                cmdp = New MySqlCommand(sql, con)
                ultima = cmdp.ExecuteReader()

                If (ultima.Read()) Then
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
            form.TxtPedido.Text = TxtPedido.Text
            form.TxtCodFornecedor.Text = TxtCodFornecedor.Text
            form.TxtFornecedor.Text = TxtFornecedor.Text
            form.DataPed.Value = DataPed.Value
            form.TxtStatusPedido.Text = TxtStatusPedido.Text

            form.ShowDialog()
        Else
            Exit Sub

        End If
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

    Private Sub TxtPedido_Enter(sender As Object, e As EventArgs) Handles TxtPedido.Enter
        CorTxtBox(TxtPedido, "Am")
    End Sub

    Private Sub TxtPedido_Leave(sender As Object, e As EventArgs) Handles TxtPedido.Leave
        CorTxtBox(TxtPedido, "Br")
    End Sub

    Private Sub DataPed_Enter(sender As Object, e As EventArgs) Handles DataPed.Enter
        CorTxtBox(DataPed, "Am")
    End Sub

    Private Sub DataPed_Leave(sender As Object, e As EventArgs) Handles DataPed.Leave
        CorTxtBox(DataPed, "Br")
    End Sub

    Private Sub TxtFornecedor_Enter(sender As Object, e As EventArgs) Handles TxtFornecedor.Enter
        CorTxtBox(TxtFornecedor, "Am")
    End Sub

    Private Sub TxtFornecedor_Leave(sender As Object, e As EventArgs) Handles TxtFornecedor.Leave
        CorTxtBox(TxtFornecedor, "Br")
    End Sub

    Private Sub TxtProduto_Enter(sender As Object, e As EventArgs) Handles TxtProduto.Enter
        CorTxtBox(TxtProduto, "Am")
    End Sub

    Private Sub TxtProduto_Leave(sender As Object, e As EventArgs) Handles TxtProduto.Leave
        CorTxtBox(TxtProduto, "Br")
    End Sub

    Private Sub TxtQuantidade_Enter(sender As Object, e As EventArgs) Handles TxtQuantidade.Enter
        CorTxtBox(TxtQuantidade, "Am")
    End Sub

    Private Sub TxtQuantidade_Leave(sender As Object, e As EventArgs) Handles TxtQuantidade.Leave
        CorTxtBox(TxtQuantidade, "Br")
    End Sub

    Private Sub TxtValorUnit_Enter(sender As Object, e As EventArgs) Handles TxtValorUnit.Enter
        CorTxtBox(TxtValorUnit, "Am")
    End Sub

    Private Sub TxtValorUnit_Leave(sender As Object, e As EventArgs) Handles TxtValorUnit.Leave
        CorTxtBox(TxtValorUnit, "Br")
    End Sub
End Class