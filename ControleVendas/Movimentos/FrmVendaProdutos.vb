Imports MySql.Data.MySqlClient

Public Class FrmVendaProdutos

    Private ReadOnly Table1 As New DataTable("MyTable")
    Dim proximo As Integer
    Dim anterior As Integer
    Dim maximo As Integer
    Dim total As String

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

        BtnIncluirItem_venda.Enabled = False

        BtnEditar_duplicata.Enabled = False
        BtnAtualizar_duplicata.Enabled = False

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

        TxtProduto.ReadOnly = True
        TxtCliente.ReadOnly = True
        BtnIncluirItem_venda.Enabled = True

        BtnEditar_duplicata.Enabled = True
        BtnAtualizar_duplicata.Enabled = True
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
        Table1DuplicatasReceber.Columns.Clear()
        Table1DuplicatasReceber.Rows.Clear()
        novaVenda = ""

        editarDuplicata = ""
        saldoEstoque = Nothing
        TxtSaldoEstoque.Text = ""
        dgStatus = ""

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
        editarVenda = ""

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

        DataGrid.Columns(0).Width = 1
        DataGrid.Columns(1).Width = 50
        DataGrid.Columns(2).Width = 40
        DataGrid.Columns(4).Width = 50
        DataGrid.Columns(5).Width = 150
        DataGrid.Columns(6).Width = 50
        DataGrid.Columns(7).Width = 250
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

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If

            ListarDuplicatas()

            TotalDatagrid()

            TotalDatagridDuplicatas()
            TotalNfe_TotalDuplicatas()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Public Sub ListarDuplicatas()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            'Stop
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT * FROM duplicatas_receber WHERE id_venda = '" & TxtIdRegistro.Text & "' order by parcela asc"
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
        DataGridDuplicatas.Columns(10).HeaderText = "ID Portador"

        DataGrid.Columns(6).Width = 150

        DataGridDuplicatas.Columns(5).DefaultCellStyle.Format = "c"

        TotalDatagridDuplicatas()

        TotalNfe_TotalDuplicatas()

    End Sub


    Private Sub BtnNovo_Click(sender As Object, e As EventArgs)
        If MsgBox("Deseja incluir novo venda?", vbYesNo, " Novo Venda") = vbYes Then

            HabilitarCampos()
            LimparCampos()
            GerarIdRegistro()

            TxtItem.Text = 1
            novaVenda = "True"
        End If
    End Sub

    Sub GerarIdRegistro()
        'Stop
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
                TxtIdRegistro.Text = ultima("id_venda") + 1
                ultima.Close()
            Else
                TxtIdRegistro.Text = 1

                ultima.Close()
            End If

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try
    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        Abrir()
        'VERIFICAR SE O REGISTRO JÁ EXISTE
        Dim cmdUSU As MySqlCommand
        Dim readerUSU As MySqlDataReader
        Dim sqlUSU As String

        sqlUSU = "SELECT * FROM venda WHERE id_venda = '" & TxtIdRegistro.Text & "' "
        cmdUSU = New MySqlCommand(sqlUSU, con)
        readerUSU = cmdUSU.ExecuteReader

        If readerUSU.Read = True Then
            readerUSU.Close()
            MsgBox("Registro já está cadastrado!!", MsgBoxStyle.Information, "Venda")

            Exit Sub
        Else
            readerUSU.Close()
        End If

        If DataGrid.RowCount < 1 Then
            MsgBox("Adicione registro para salvar!!", MsgBoxStyle.Information, "Salvar")
            Exit Sub
        End If


        If LblSaldo.Text <> "" Then
            If MsgBox("Total de duplicatas diferente do total da venda, deja salvar mesmo assim ?", vbYesNo, "Total duplicatas") = vbYes Then

                Salvar_registro_nova_venda()

                MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

            End If
        Else

            If MsgBox("Deseja salvar essa venda?", vbYesNo + vbQuestion, "Salvar") = vbYes Then

                Salvar_registro_nova_venda()

                MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")
            End If
        End If

    End Sub

    Sub Salvar_registro_nova_venda()

        SalvarNovaVenda()

        SalvarDuplicata()

        'SalvarEstoque()

        SalvarEstoque_CustoItem()

        SalvarSaldoItem()

        LimparCampos()

        ListarUltimaVenda()

        DesabilitarCampos()

        DadosCabecalho()

        Limpar_cores()
    End Sub
    Sub SalvarEstoque() 'não esta sendo utilizado
        Try
            Abrir()

            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            Dim data1 As String
            Dim IdVenda As Integer

            data1 = Now().ToString("yyyy-MM-dd")
            IdVenda = TxtIdRegistro.Text

            Dim tipomvto As String
            tipomvto = "Saída"
            For i = 0 To DataGrid.RowCount - 1

                sql1 = "INSERT INTO estoque (data_registro, tipo, cod_produto, produto, quantidade, valor_unitario, valor_total, id_venda, item ) VALUES ('" & data1 & "', '" & tipomvto & "', @cod_produto, @produto, @quantidade, @valor_unitario, @valor_total,'" & IdVenda & "', @item )"
                cmd1 = New MySqlCommand(sql1, con)
                With cmd1
                    .Parameters.AddWithValue("@cod_produto", CInt(DataGrid.Rows(i).Cells(6).Value.ToString))
                    .Parameters.AddWithValue("@produto", DataGrid.Rows(i).Cells(7).Value.ToString)
                    .Parameters.AddWithValue("@quantidade", CInt(DataGrid.Rows(i).Cells(8).Value.ToString))
                    .Parameters.AddWithValue("@valor_unitario", CDbl(DataGrid.Rows(i).Cells(9).Value.ToString))
                    .Parameters.AddWithValue("@valor_total", CDbl(DataGrid.Rows(i).Cells(10).Value.ToString))
                    .Parameters.AddWithValue("@item", CInt(DataGrid.Rows(i).Cells(2).Value.ToString))
                    cmd1.ExecuteNonQuery()
                End With

            Next

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try
    End Sub

    Sub SalvarEstoque_CustoItem()
        'Stop
        Try
            Abrir()


            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            Dim data1 As String
            Dim IdVenda As Integer
            Dim CostUnit As String
            Dim CostTotal As String
            Dim Qtd As Integer
            Dim codProduto As Integer

            data1 = Now().ToString("yyyy-MM-dd")
            IdVenda = TxtIdRegistro.Text

            Dim tipomvto As String
            tipomvto = "Saída"

            For i = 0 To DataGrid.RowCount - 1

                codProduto = DataGrid.Rows(i).Cells(6).Value.ToString
                Qtd = DataGrid.Rows(i).Cells(8).Value.ToString

                'consultar custo unitario do item
                Dim cmd As MySqlCommand
                Dim reader As MySqlDataReader
                Dim sql As String
                sql = "SELECT * FROM produtos WHERE id= '" & codProduto & "'"
                cmd = New MySqlCommand(sql, con)
                reader = cmd.ExecuteReader
                If reader.Read = True Then
                    CostUnit = reader("preco_compra")
                    reader.Close()
                Else
                    reader.Close()
                End If


#Disable Warning BC42104 ' A variável é usada antes de receber um valor
                CostTotal = CostUnit * Qtd
#Enable Warning BC42104 ' A variável é usada antes de receber um valor

                'inserindo dados no banco
                sql1 = "INSERT INTO estoque (data_registro, tipo, cod_produto, produto, quantidade, valor_unitario, valor_total, id_venda, item ) VALUES ('" & data1 & "', '" & tipomvto & "', @cod_produto, @produto, @quantidade, '" & CostUnit.Replace(",", ".") & "', '" & CostTotal.Replace(",", ".") & "','" & IdVenda & "', @item )"
                cmd1 = New MySqlCommand(sql1, con)
                With cmd1
                    .Parameters.AddWithValue("@cod_produto", CInt(DataGrid.Rows(i).Cells(6).Value.ToString))
                    .Parameters.AddWithValue("@produto", DataGrid.Rows(i).Cells(7).Value.ToString)
                    .Parameters.AddWithValue("@quantidade", CInt(DataGrid.Rows(i).Cells(8).Value.ToString))
                    .Parameters.AddWithValue("@item", CInt(DataGrid.Rows(i).Cells(2).Value.ToString))
                    cmd1.ExecuteNonQuery()
                End With

            Next

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try
    End Sub
    Private Sub SalvarSaldoItem()

        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            Dim saldoItem As Integer
            Dim codItem As Integer
            Dim qtd As Integer
            Dim saldoEstoque As Integer


            For i = 0 To DataGrid.RowCount - 1

                codItem = CInt(DataGrid.Rows(i).Cells(6).Value.ToString)
                qtd = CInt(DataGrid.Rows(i).Cells(8).Value.ToString)

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


                saldoItem = saldoEstoque - qtd

                sql = "UPDATE produtos SET saldo_estoque = '" & saldoItem & "' WHERE id = '" & codItem & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

            Next

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try


    End Sub

    Private Sub AtualizarSaldoItem_Exlusao_venda()

        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            Dim saldoItem As Integer
            Dim codItem As Integer
            Dim qtd As Integer
            Dim saldoEstoque As Integer


            For i = 0 To DataGrid.RowCount - 1

                codItem = CInt(DataGrid.Rows(i).Cells(6).Value.ToString)
                qtd = CInt(DataGrid.Rows(i).Cells(8).Value.ToString)

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
    Sub SalvarNovaVenda()
        'Stop
        Try
            Abrir()
            'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
            Dim cmd As MySqlCommand
            Dim sqls As String
            Dim data As String

            data = DataVenda.Value.ToString("yyyy-MM-dd")

            Dim i As Integer


            'ADIONANDO VARIAS LINHAS NO BANCO DE DADOS COM DATAGRID

            For i = 0 To DataGrid.RowCount - 1

                sqls = "INSERT INTO venda (id_venda, item, data_venda, cod_cliente, cliente, cod_produto, produto, quantidade, valor_unitario, valor_total ) VALUES (@id_venda, @item, '" & data & "', @cod_cliente, @cliente, @cod_produto, @produto, @quantidade, @valor_unitario, @valor_total)"
                cmd = New MySqlCommand(sqls, con)
                With cmd
                    .Parameters.AddWithValue("@id_venda", CInt(DataGrid.Rows(i).Cells(1).Value.ToString))
                    .Parameters.AddWithValue("@item", CInt(DataGrid.Rows(i).Cells(2).Value.ToString))
                    .Parameters.AddWithValue("@cod_cliente", CInt(DataGrid.Rows(i).Cells(4).Value.ToString))
                    .Parameters.AddWithValue("@cliente", DataGrid.Rows(i).Cells(5).Value.ToString)
                    .Parameters.AddWithValue("@cod_produto", CInt(DataGrid.Rows(i).Cells(6).Value.ToString))
                    .Parameters.AddWithValue("@produto", DataGrid.Rows(i).Cells(7).Value.ToString)
                    .Parameters.AddWithValue("@quantidade", CInt(DataGrid.Rows(i).Cells(8).Value.ToString))
                    .Parameters.AddWithValue("@valor_unitario", CDbl(DataGrid.Rows(i).Cells(9).Value.ToString))
                    .Parameters.AddWithValue("@valor_total", CDbl(DataGrid.Rows(i).Cells(10).Value.ToString))

                    cmd.ExecuteNonQuery()
                End With

            Next

            'PROGRAMANDO A INSERÇÃO NA TABELA PEDIDO_CABEÇALHO

            Dim cmdp As MySqlCommand
            Dim sql As String


            data = DataVenda.Value.ToString("yyyy-MM-dd")
            sql = "INSERT INTO venda_cabecalho (id_venda, data_venda, cod_cliente, cliente, valor_total, saldo_venda) VALUES ('" & TxtIdRegistro.Text & "', '" & data & "', '" & TxtCodCliente.Text & "','" & TxtCliente.Text & "', '" & TxtTotalVenda.Text.Replace(",", ".") & "', '" & TxtTotalVenda.Text.Replace(",", ".") & "' )"
            cmdp = New MySqlCommand(sql, con)
            cmdp.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try


    End Sub

    Sub SalvarDuplicata()
        'Stop
        Try
            For i = 0 To DataGridDuplicatas.RowCount - 1

                Dim cmd As MySqlCommand
                Dim sqls As String
                sqls = "INSERT INTO duplicatas_receber (parcela, id_venda, data_venda, data_vencimento, valor_parcela, observacao, cod_cliente, cliente, saldo_duplicata, id_portador) VALUES (@parcela, @id_venda, @data_venda, @data_vencimento, @valor_parcela, @observacao, '" & TxtCodCliente.Text & "','" & TxtCliente.Text & "', @saldo_duplicata, @id_portador )"
                cmd = New MySqlCommand(sqls, con)
                With cmd
                    .Parameters.AddWithValue("@parcela", CInt(DataGridDuplicatas.Rows(i).Cells(1).Value.ToString))
                    .Parameters.AddWithValue("@id_venda", DataGridDuplicatas.Rows(i).Cells(2).Value.ToString)
                    .Parameters.AddWithValue("@data_venda", CDate(DataGridDuplicatas.Rows(i).Cells(3).Value.ToString))
                    .Parameters.AddWithValue("@data_vencimento", CDate(DataGridDuplicatas.Rows(i).Cells(4).Value.ToString))
                    .Parameters.AddWithValue("@valor_parcela", CDbl(DataGridDuplicatas.Rows(i).Cells(5).Value.ToString))
                    .Parameters.AddWithValue("@observacao", DataGridDuplicatas.Rows(i).Cells(6).Value.ToString)
                    .Parameters.AddWithValue("@saldo_duplicata", CDbl(DataGridDuplicatas.Rows(i).Cells(5).Value.ToString))
                    .Parameters.AddWithValue("@id_portador", CInt(DataGridDuplicatas.Rows(i).Cells(7).Value.ToString))
                    cmd.ExecuteNonQuery()
                End With

            Next

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try

    End Sub
    Private Sub BtnExluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click



        'PESQUISAR SE A NOTA JA NÃO FOI PAGA
        Dim cmd1 As MySqlCommand
        Dim reader As MySqlDataReader
        Dim sql1 As String

        sql1 = "SELECT * FROM mvto_recebimentos where id_venda = '" & TxtIdRegistro.Text & "' "
        cmd1 = New MySqlCommand(sql1, con)
        reader = cmd1.ExecuteReader

        If reader.Read = True Then

            MsgBox("Documento não pode ser excluido, já foi pago!!", MsgBoxStyle.Information, "Excluir Documento")
            reader.Close()
            Exit Sub
        Else
            reader.Close()
        End If


        If TxtIdRegistro.Text <> "" Then

            If MsgBox("Deseja excluir a venda do cliente " + TxtCliente.Text + "?", vbYesNo, "Venda") = vbYes Then

                Excluir_Venda_Estoque()

                Excluir_venda_total()

                Excluir_venda_cabecalho()

                Excluir_duplicata_receber()

                AtualizarSaldoItem_Exlusao_venda()

                MsgBox("Registro escluído com Sucesso!!", MsgBoxStyle.Information, "Exclusão")

                LimparCampos()

                ListarUltimaVenda()
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
        'Stop
        Dim total As Integer
        If dgStatus = "True" Then

            For i = 0 To DataGrid.Rows.Count - 1

                If DataGrid.Rows(i).Cells(6).Value = TxtCodProduto.Text Then

                    total += +DataGrid.Rows(i).Cells(8).Value

                End If

            Next

        End If


        If editarVenda = "Editar" Then Exit Sub
        If novaVenda = "True" Then

            Limpar_cores()

            If TxtCodCliente.Text <> "" And TxtCodProduto.Text <> "" And TxtQuantidade.Text <> "" And TxtValorUnit.Text <> "" Then


                Dim totalUsado As Integer
                totalUsado = total + TxtQuantidade.Text

                If TxtSaldoEstoque.Text <= 0 Or totalUsado > TxtSaldoEstoque.Text Then

                    MsgBox("Saldo em estoque insuficiente!", MsgBoxStyle.Information, "Saldo estoque")

                    Exit Sub
                End If



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

#Disable Warning IDE0017 ' Simplificar a inicialização de objeto
                    Dim bs As New BindingSource()
#Enable Warning IDE0017 ' Simplificar a inicialização de objeto
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

                    dgStatus = "True"
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



    Private Sub FrmPedido_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        LimparCampos()

    End Sub

    Private Sub BtnPesqPedido_Click(sender As Object, e As EventArgs) Handles BtnPesqPedido.Click

        pesquisarDuplicata = "True"
        Dim form = New FrmVendaCabecalho
        form.ShowDialog()

    End Sub
    Private Sub BtnCacelar_Click(sender As Object, e As EventArgs) Handles BtnCacelar.Click
        LimparCampos()
        DesabilitarCampos()
        ListarUltimaVenda()
        Limpar_cores()
    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick

        If e.RowIndex > -1 Then

            If novaVenda = "True" Then
                Exit Sub

            Else
                DadosCabecalho()
            End If

        End If
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        ListarPedidoAnterior()
        ListarDuplicatas()
        TotalDatagrid()
        TotalDatagridDuplicatas()
        TotalNfe_TotalDuplicatas()

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
            TxtSaldoEstoque.Text = saldoEstoque
            pesquisarProduto = ""
            saldoEstoque = Nothing
        End If

        If novaVenda = "True" Then
            DataGridDuplicatas.DataSource = bsd
            TotalDatagridDuplicatas()
            TotalNfe_TotalDuplicatas()
        End If

        If pesquisarDuplicata = "True" Then
            TxtPesquisar.Text = IdDuplicata
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
        ListarDuplicatas()
        TotalDatagrid()
        TotalDatagridDuplicatas()
        TotalNfe_TotalDuplicatas()

    End Sub
    Private Sub BtnExcluirItemPedido_Click(sender As Object, e As EventArgs) Handles BtnExcluirItem_venda.Click

        If novaVenda = "True" Then

            If DataGrid.Rows.Count < 1 Then
                Exit Sub

            Else
                DataGrid.Rows.Remove(DataGrid.CurrentRow)
            End If

        Else

            If TxtIdRegistro.Text <> "" And TxtItem.Text <> "" Then

                If MsgBox("Deseja excluir o item " + TxtItem.Text + " da venda " + TxtIdRegistro.Text + "?", vbYesNo, "Venda") = vbYes Then


                    If DataGrid.Rows.Count = 1 Then

                        MsgBox("Item não pode ser excluído, venda com apenas um item. Exclua a venda se desejar!!", MsgBoxStyle.Information, "Excluir item")

                        Exit Sub
                    End If

                    Excluir_venda()

                    Atualizar_venda_cabecalho()

                    Excluir_Saida_Estoque()

                    SalvarSaldoItem_ExclusaoItem()

                    MsgBox("Item excluído com sucesso!!", MsgBoxStyle.Information, "Excluir")

                    ListarUltimaVenda()

                End If
            Else

                MsgBox("Selecione um item para excluir!!", MsgBoxStyle.Information, "Excluir")
            End If

        End If

    End Sub
    Private Sub SalvarSaldoItem_ExclusaoItem()

        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            Dim saldoItem As Integer
            Dim codItem As Integer
            Dim qtd As Integer
            Dim saldoEstoque As Integer

            codItem = TxtCodProduto.Text
            qtd = TxtQuantidade.Text

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

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try


    End Sub

    Sub Excluir_Venda_Estoque()
        'Stop
        Try
            Abrir()
            Dim tipomov As String
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            tipomov = "Saída"
            sql1 = "DELETE FROM estoque WHERE id_venda =  '" & TxtIdRegistro.Text & "' and tipo = '" & tipomov & "'"
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try
    End Sub
    Sub Excluir_Saida_Estoque()
        'Stop
        Try
            Abrir()
            Dim tipomov As String
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            tipomov = "Saída"
            sql1 = "DELETE FROM estoque WHERE id_venda =  '" & TxtIdRegistro.Text & "' AND item =  '" & TxtItem.Text & "' and tipo = '" & tipomov & "'"
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try
    End Sub
    Sub Atualizar_venda_cabecalho()
        ' Stop
        Try
            '.....................................................................................                   
            'CONSULTAR TOTAL NA TABELA VENDA
            Abrir()
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String

            sql3 = "SELECT SUM(valor_total) as valor_tota FROM venda WHERE id_venda =  '" & TxtIdRegistro.Text & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            reader3.Read()

            If Not IsDBNull(reader3("valor_tota")) Then
                total = reader3("valor_tota")
                reader3.Close()
            Else
                reader3.Close()
            End If

            'ATUALIZAR TOTAL VENDA_CABECALHO
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            sql1 = "UPDATE venda_cabecalho SET valor_total= '" & total.Replace(",", ".") & "', saldo_venda = '" & total.Replace(",", ".") & "' WHERE id_venda =  '" & TxtIdRegistro.Text & "' "
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao editar!!" + ex.Message)
        End Try

    End Sub
    Sub Excluir_venda_cabecalho()
        Try

            'CONSULTAR TOTAL NA TABELA VENDA
            Abrir()
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            sql1 = "DELETE FROM venda_cabecalho WHERE id_venda =  '" & TxtIdRegistro.Text & "' "
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao editar!!" + ex.Message)
        End Try

    End Sub

    Sub Excluir_venda_total()
        ' Stop
        Try

            Abrir()
            Dim cmd As MySqlCommand
            Dim sql As String
            sql = "DELETE FROM venda WHERE id_venda =  '" & TxtIdRegistro.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try
    End Sub

    Sub Excluir_venda()
        ' Stop
        Try

            Abrir()
            Dim cmd As MySqlCommand
            Dim sql As String
            sql = "DELETE FROM venda WHERE id_venda =  '" & TxtIdRegistro.Text & "' AND item =  '" & TxtItem.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try
    End Sub
    Sub ListarProximoPedido()

        Try

            Try
                Abrir()

                'VERIFICAR ULTIMO ID NO BANCO 
                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim ultima As MySqlDataReader

                sql = "SELECT id_venda FROM venda_cabecalho WHERE id_venda=(SELECT MAX(id_venda) FROM venda_cabecalho) "
                cmdp = New MySqlCommand(sql, con)
                ultima = cmdp.ExecuteReader()

                If (ultima.Read()) Then
                    maximo = ultima("id_venda")
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

            sqlp = "SELECT * FROM venda_cabecalho WHERE id_venda = '" & proximo & "' "
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
            sql = "SELECT * FROM venda WHERE id_venda= '" & proximo & "' order by item asc "
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
        'Stop
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

            sqlp = "SELECT * FROM venda_cabecalho WHERE id_venda = '" & anterior & "' "
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
        ' Stop
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT * FROM venda WHERE id_venda= '" & anterior & "' order by item asc "
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

        If MsgBox("Deseja excluir novo item  na venda " + TxtIdRegistro.Text + "?", vbYesNo, "Venda") = vbYes Then
            Try
                Abrir()
                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim ultima As MySqlDataReader


                sql = "SELECT MAX(item) AS Item FROM venda WHERE id_venda = '" & TxtIdRegistro.Text & "' "

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


            Dim form = New FrmAddItemVenda

            form.TxtItem.Text = linhaPed + 1
            form.TxtIdRegistro.Text = TxtIdRegistro.Text
            form.TxtCodCliente.Text = TxtCodCliente.Text
            form.TxtCliente.Text = TxtCliente.Text
            form.DataVenda.Value = DataVenda.Value


            form.ShowDialog()
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
            sql = "SELECT * FROM venda WHERE id_venda= '" & TxtIdRegistro.Text & "' order by item asc "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If

            ListarDuplicatas()

            TotalDatagrid()
            TotalDatagridDuplicatas()
            TotalNfe_TotalDuplicatas()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Sub Pesquisar_venda()

        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT * FROM venda WHERE id_venda= '" & TxtPesquisar.Text & "' order by item asc "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If

            ListarDuplicatas()

            TotalDatagrid()
            TotalDatagridDuplicatas()
            TotalNfe_TotalDuplicatas()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Private Sub BtnIncluirDuplicata_Click(sender As Object, e As EventArgs) Handles BtnIncluir_duplicata.Click


        Dim form = New FrmDuplReceber()
        form.TxtNum_venda.Text = TxtIdRegistro.Text
        form.DataEmissao.Value = DataVenda.Value
        form.TxtIdCliente.Text = TxtCodCliente.Text
        form.TxtCliente.Text = TxtCliente.Text

        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Double.TryParse(TxtTotalVenda.Text, dbl1)
        Double.TryParse(TxtTotalDuplicatas.Text, dbl2)

        form.TxtTotalDuplicata.Text = (dbl1 - dbl2).ToString("n")

        form.ShowDialog()

    End Sub

    Private Sub BtnEliminar_duplicata_Click(sender As Object, e As EventArgs) Handles BtnEliminar_duplicata.Click
        'Stop
        If novaVenda = "True" Then

            If DataGridDuplicatas.Rows.Count < 1 Then Exit Sub

            DataGridDuplicatas.Rows.Remove(DataGridDuplicatas.CurrentRow)
            TotalDatagridDuplicatas()
            TotalNfe_TotalDuplicatas()

        Else
            If DataGridDuplicatas.Rows.Count < 1 Then Exit Sub

            If MsgBox("Deseja eliminar parcela ?", vbYesNo, "Eliminar duplicatas") = vbYes Then

                DeletarParcelaBanco()
                ListarDuplicatas()
                TotalDatagridDuplicatas()
                TotalNfe_TotalDuplicatas()

            End If

        End If


    End Sub

    Sub Excluir_duplicata_receber()
        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim sql1 As String
            sql1 = "DELETE FROM duplicatas_receber where id_venda = '" & TxtIdRegistro.Text & "' "
            cmd = New MySqlCommand(sql1, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try
    End Sub

    Sub DeletarParcelaBanco()
        Try

            Abrir()

            'VERIFICAR ULTIMO ID NO BANCO 
            Dim cmdp As MySqlCommand
            Dim sql As String
            Dim reader As MySqlDataReader
            Dim idReg As String

            idReg = DataGridDuplicatas.CurrentRow.Cells(0).Value.ToString

            sql = "SELECT * FROM duplicatas_receber WHERE id = '" & idReg & "' "
            cmdp = New MySqlCommand(sql, con)
            reader = cmdp.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                Dim cmd As MySqlCommand
                Dim sql1 As String
                sql1 = "DELETE FROM duplicatas_receber where id = '" & idReg & "' "
                cmd = New MySqlCommand(sql1, con)
                cmd.ExecuteNonQuery()

                MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

            Else
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try

    End Sub

    Private Sub BtnAtualizar_duplicata_Click(sender As Object, e As EventArgs) Handles BtnAtualizar_duplicata.Click
        ListarDuplicatas()
    End Sub

    Private Sub BtnEditar_duplicata_Click(sender As Object, e As EventArgs) Handles BtnEditar_duplicata.Click

        If MsgBox("Deseja editar parcela ?", vbYesNo, "Editar duplicatas") = vbYes Then

            editarDuplicata = "True"

            Dim form = New FrmDuplReceber()
            form.TxtId_Reg.Text = DataGridDuplicatas.CurrentRow.Cells(0).Value.ToString()
            form.TxtNum_venda.Text = DataGridDuplicatas.CurrentRow.Cells(1).Value.ToString()
            form.TxtParcela.Text = DataGridDuplicatas.CurrentRow.Cells(2).Value.ToString()
            form.DataEmissao.Value = DataGridDuplicatas.CurrentRow.Cells(3).Value.ToString()
            form.DataVencimento.Value = DataGridDuplicatas.CurrentRow.Cells(4).Value.ToString()
            form.TxtTotalDuplicata.Text = DataGridDuplicatas.CurrentRow.Cells(5).Value.ToString()
            form.TxtObs.Text = DataGridDuplicatas.CurrentRow.Cells(6).Value.ToString()
            form.TxtIdCliente.Text = DataGridDuplicatas.CurrentRow.Cells(7).Value.ToString()
            form.TxtCliente.Text = DataGridDuplicatas.CurrentRow.Cells(8).Value.ToString()

            form.TxtParcela.Enabled = False

            form.ShowDialog()

        End If

    End Sub

    Private Sub BtnNovo_Click_1(sender As Object, e As EventArgs) Handles BtnNova_venda.Click
        If MsgBox("Deseja incluir novo venda?", vbYesNo, " Novo Venda") = vbYes Then

            HabilitarCampos()
            LimparCampos()
            GerarIdRegistro()

            TxtItem.Text = 1
            novaVenda = "True"
        End If
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        If TxtPesquisar.Text <> "" Then
            Pesquisar_venda()
        End If

    End Sub
End Class