Imports MySql.Data.MySqlClient

Public Class FrmEntrada
    Dim proximo As Integer
    Dim anterior As Integer
    Dim maximo As Integer
    Private Sub FrmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarUltimaNota()
    End Sub
    Private Sub BtnPesqPedido_Click(sender As Object, e As EventArgs) Handles BtnPesqPedido.Click

        pedidoPesquisar = "True"
        Dim form = New FrmPedidoCabecalho
        form.ShowDialog()

    End Sub
    Sub LimparCampos()

        DataGrid.DataSource = Nothing
        DataGridDuplicatas.DataSource = Nothing

        TxtCodPedido.Text = ""
        TxtDescPed.Text = ""
        TxtNotaFiscal.Text = ""
        DataEmissao.Value = Now()
        TxtFornecedor.Text = ""
        TxtNomeFornecedor.Text = ""
        TxtTotalNota.Text = 0
        TxtIdRegistro.Text = ""
        TxtPesquisar.Text = ""
        TxtTotalDuplicatas.Text = 0
        novaEntrada = ""
        editarDuplicata = ""
    End Sub
    Sub HabilitarCampos()

        TxtNotaFiscal.Enabled = True
        BtnPesqPedido.Enabled = True
        DataEmissao.Enabled = True

    End Sub

    Sub BloquearCampos()
        TxtNotaFiscal.Enabled = False
        BtnPesqPedido.Enabled = False
        DataEmissao.Enabled = False

        BtnEditar.Enabled = True
        BtnAtualizar.Enabled = True

    End Sub
    Sub BuscarPedido()
        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            If TxtCodPedido.Text <> "" Then
                Abrir()
                Dim sql As String
                Dim dt As New DataTable
                Dim da As MySqlDataAdapter
                sql = "SELECT  item, cod_produto, produto, quantidade, valor_unitario, valor_total FROM pedidos WHERE pedido = '" & TxtCodPedido.Text & "' "
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)
                DataGrid.DataSource = dt

                FormatarGrid()

            End If

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
            sql = "SELECT * FROM duplicatas WHERE id_entrada = '" & TxtIdRegistro.Text & "' "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridDuplicatas.DataSource = dt

            FormatarGridDuplicatas()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Sub ListarUltimaNota()
        'Stop
        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String


            sql = "SELECT * FROM entrada WHERE id=(SELECT MAX(id) FROM entrada) "

            'sql = "SELECT e.id, e.nota, e.cod_fornecedor, e.fornecedor, e.id_pedido, e.descricao, p.status, e.emissao, e.valor FROM entrada AS e INNER JOIN pedido_cabecalho AS p ON e.id_pedido = p.id "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then

                TxtIdRegistro.Text = reader(0)
                TxtNotaFiscal.Text = reader(1)
                TxtFornecedor.Text = reader(2)
                TxtNomeFornecedor.Text = reader(3)
                TxtCodPedido.Text = reader(4)
                TxtDescPed.Text = reader(5)
                'TxtStatusPedido.Text = reader(6)
                DataEmissao.Value = reader(7)
                TxtTotalNota.Text = reader(8)

                reader.Close()

            End If
            reader.Close()

            '..................................................................................
            'LISTAR ITEN DA NOTA FISCAL
            Dim sql1 As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql1 = "SELECT item, cod_produto, produto, quantidade, valor_unitario, valor_total  FROM estoque WHERE id_entrada = '" & TxtIdRegistro.Text & "' order by item asc "
            da = New MySqlDataAdapter(sql1, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            ListarDuplicatas()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Public Sub FormatarGridDuplicatas()

        DataGridDuplicatas.Columns(7).Visible = False
        DataGridDuplicatas.Columns(8).Visible = False
        DataGridDuplicatas.Columns(9).Visible = False

        DataGridDuplicatas.Columns(0).HeaderText = "Id. Dup."
        DataGridDuplicatas.Columns(1).HeaderText = "Parcela"
        DataGridDuplicatas.Columns(2).HeaderText = "Documento"
        DataGridDuplicatas.Columns(3).HeaderText = "Data Emissão"
        DataGridDuplicatas.Columns(4).HeaderText = "Data Vencimento"
        DataGridDuplicatas.Columns(5).HeaderText = "Valor Parcela"
        DataGridDuplicatas.Columns(6).HeaderText = "Observação"

        DataGridDuplicatas.Columns(5).DefaultCellStyle.Format = "c"

        TotalDatagridDuplicatas()

        TotalNfe_TotalDuplicatas()

    End Sub
    Public Sub TotalNfe_TotalDuplicatas()

        LblSaldo.Text = ""
        If TxtTotalNota.Text - TxtTotalDuplicatas.Text > 0 Or TxtTotalNota.Text - TxtTotalDuplicatas.Text < 0 Then
            LblSaldo.Text = "Valor total das duplicatas diferente do valor total da Nota!"
        End If

    End Sub


    Private Sub FormatarGrid()
        ' DataGrid.Columns(0).Visible = False

        DataGrid.Columns(0).HeaderText = "Item"
        DataGrid.Columns(1).HeaderText = "Cod. Produto"
        DataGrid.Columns(2).HeaderText = "Descrição Produto"
        DataGrid.Columns(3).HeaderText = "Qtd."
        DataGrid.Columns(4).HeaderText = "Valor Unitário"
        DataGrid.Columns(5).HeaderText = "Valor Total"

        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(1).Width = 60
        DataGrid.Columns(2).Width = 250
        DataGrid.Columns(3).Width = 60

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(4).DefaultCellStyle.Format = "c"
        DataGrid.Columns(5).DefaultCellStyle.Format = "c"

    End Sub


    Public Sub TotalDatagrid()

        'CALCULANDO SOMA TOTAL
        On Error Resume Next
        Dim total As Decimal = 0
        For i = 0 To DataGrid.Rows.Count - 1
            total = total + DataGrid.Rows(i).Cells(9).Value
        Next
        TxtTotalNota.Text = total
        'TxtTotalPedido.Text = Convert.ToDouble(TxtTotalPedido.Text).ToString("C")
    End Sub
    Public Sub TotalDatagridDuplicatas()

        'CALCULANDO SOMA TOTAL
        On Error Resume Next
        Dim total As Decimal = 0
        For i = 0 To DataGridDuplicatas.Rows.Count - 1
            total = total + DataGridDuplicatas.Rows(i).Cells(5).Value
        Next
        TxtTotalDuplicatas.Text = total
        'TxtTotalPedido.Text = Convert.ToDouble(TxtTotalPedido.Text).ToString("C")
    End Sub
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click

        LimparCampos()
        BloquearCampos()
        Limpar_cores()
        Me.Close()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        Abrir()
        'VERIFICAR SE O REGISTRO JÁ EXISTE
        Dim cmdUSU As MySqlCommand
        Dim readerUSU As MySqlDataReader
        Dim sqlUSU As String

        sqlUSU = "SELECT * FROM entrada WHERE id = '" & TxtIdRegistro.Text & "' "
        cmdUSU = New MySqlCommand(sqlUSU, con)
        readerUSU = cmdUSU.ExecuteReader

        If readerUSU.Read = True Then
            readerUSU.Close()
            MsgBox("Registro já está cadastrado!!", MsgBoxStyle.Information, "Entrada NFe")

            Exit Sub
        End If
        readerUSU.Close()
        '.............................................................................................

        TxtNotaFiscal.BackColor = Color.White
        TxtNomeFornecedor.BackColor = Color.White
        TxtDescPed.BackColor = Color.White

        If DataGrid.RowCount < 1 Then
            MsgBox("Adicione registros para salvar!!", MsgBoxStyle.Information, "Salvar")
            Exit Sub
        End If

        If TxtNotaFiscal.Text <> "" And TxtFornecedor.Text <> "" And TxtCodPedido.Text <> "" Then

            If TxtTotalNota.Text - TxtTotalDuplicatas.Text > 0 Or TxtTotalNota.Text - TxtTotalDuplicatas.Text < 0 Then

                If MsgBox("Total de duplicatas diferente do total da nota fiscal, deja salvar mesmo assim ?", vbYesNo, "Total duplicatas") = vbYes Then
                    SalvarEntradaNota()
                End If

            Else

                If MsgBox("Deseja salvar esse registro ?", vbYesNo, "Registro Entrada") = vbYes Then
                    SalvarEntradaNota()
                End If

            End If

        Else

            TxtNotaFiscal.BackColor = Color.Salmon
            TxtNomeFornecedor.BackColor = Color.Salmon
            TxtDescPed.BackColor = Color.Salmon

            MsgBox("Campos vazios ou inválidos!!", MsgBoxStyle.Information, "Campos obrigatórios")

        End If
    End Sub
    Sub SalvarEntradaNota()
        Try

            Abrir()

                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sqls As String
                Dim data1 As String

                Dim data3 As String
                data1 = DataEmissao.Value.ToString("yyyy-MM-dd")

                data3 = Now().ToString("yyyy-MM-dd")

                sqls = "INSERT INTO entrada ( id, nota, cod_fornecedor, fornecedor, id_pedido, descricao, data_registro, emissao, valor ) VALUES ('" & TxtIdRegistro.Text & "','" & TxtNotaFiscal.Text & "', '" & TxtFornecedor.Text & "', '" & TxtNomeFornecedor.Text & "', '" & TxtCodPedido.Text & "','" & TxtDescPed.Text & "' ,'" & data3 & "', '" & data1 & "', '" & TxtTotalNota.Text.Replace(",", ".") & "')"
                cmd = New MySqlCommand(sqls, con)
                cmd.ExecuteNonQuery()

                SalvarEstoque()

                SalvarStatusPedido()

                SalvarDuplicata()

                LimparCampos()

                BloquearCampos()

                MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                ListarUltimaNota()


        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try
    End Sub
    Sub SalvarDuplicata()

        Try

            For i = 0 To DataGridDuplicatas.RowCount - 1

                Dim cmd As MySqlCommand
                Dim sqls As String
                sqls = "INSERT INTO duplicatas (parcela, documento, data_emissao, data_vencimento, valor_parcela, observacao, id_entrada, cod_fornecedor, saldo_duplicata) VALUES (@parcela, @documento, @data_emissao, @data_vencimento, @valor_parcela, @observacao, '" & TxtIdRegistro.Text & "','" & TxtFornecedor.Text & "', @saldo_duplicata )"
                cmd = New MySqlCommand(sqls, con)
                With cmd

                    .Parameters.AddWithValue("@parcela", CInt(DataGridDuplicatas.Rows(i).Cells(1).Value.ToString))
                    .Parameters.AddWithValue("@documento", DataGridDuplicatas.Rows(i).Cells(2).Value.ToString)
                    .Parameters.AddWithValue("@data_emissao", CDate(DataGridDuplicatas.Rows(i).Cells(3).Value.ToString))
                    .Parameters.AddWithValue("@data_vencimento", CDate(DataGridDuplicatas.Rows(i).Cells(4).Value.ToString))
                    .Parameters.AddWithValue("@valor_parcela", CDbl(DataGridDuplicatas.Rows(i).Cells(5).Value.ToString))
                    .Parameters.AddWithValue("@observacao", DataGridDuplicatas.Rows(i).Cells(6).Value.ToString)
                    .Parameters.AddWithValue("@saldo_duplicata", CDbl(DataGridDuplicatas.Rows(i).Cells(5).Value.ToString))


                    cmd.ExecuteNonQuery()
                End With

            Next

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try

    End Sub

    Sub SalvarEstoque()
        Try
            Abrir()

            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            Dim data1 As String
            Dim IdNota As Integer
            Dim fornec As String
            Dim idPed As Integer

            data1 = Now().ToString("yyyy-MM-dd")
            IdNota = TxtIdRegistro.Text
            fornec = TxtFornecedor.Text
            idPed = TxtCodPedido.Text

            Dim tipomvto As String
            tipomvto = "Entrada"
            For i = 0 To DataGrid.RowCount - 1

                sql1 = "INSERT INTO estoque (data_registro, tipo, id_entrada, cod_produto, produto, quantidade, valor_unitario, valor_total, id_pedido, item ) VALUES ('" & data1 & "', '" & tipomvto & "', '" & IdNota & "', @cod_produto, @produto, @quantidade, @valor_unitario, @valor_total,'" & idPed & "', @item )"
                cmd1 = New MySqlCommand(sql1, con)
                With cmd1

                    .Parameters.AddWithValue("@cod_produto", CInt(DataGrid.Rows(i).Cells(1).Value.ToString))
                    .Parameters.AddWithValue("@produto", DataGrid.Rows(i).Cells(2).Value.ToString)
                    .Parameters.AddWithValue("@quantidade", CInt(DataGrid.Rows(i).Cells(3).Value.ToString))
                    .Parameters.AddWithValue("@valor_unitario", CDbl(DataGrid.Rows(i).Cells(4).Value.ToString))
                    .Parameters.AddWithValue("@valor_total", CDbl(DataGrid.Rows(i).Cells(5).Value.ToString))
                    .Parameters.AddWithValue("@item", CInt(DataGrid.Rows(i).Cells(0).Value.ToString))
                    cmd1.ExecuteNonQuery()
                End With

            Next

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try
    End Sub

    Sub GerarIdRegistro()

        Try
            Abrir()

            'VERIFICAR ULTIMO ID NO BANCO E GERAR PROXIMO
            Dim cmd As MySqlCommand
            Dim sql As String
            Dim ultima As MySqlDataReader

            sql = "SELECT id FROM entrada WHERE id=(SELECT MAX(id) FROM entrada) "
            cmd = New MySqlCommand(sql, con)
            ultima = cmd.ExecuteReader()

            If (ultima.Read()) Then
                TxtIdRegistro.Text = ultima("id") + 1
                ultima.Close()
            Else
                ultima.Close()
                TxtIdRegistro.Text = 1

            End If

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click

        LimparCampos()

        HabilitarCampos()

        GerarIdRegistro()

        novaEntrada = "True"
        BtnEditar.Enabled = False
        BtnAtualizar.Enabled = False

    End Sub
    Sub SalvarStatusPedido()
        Abrir()

        Dim cmd As MySqlCommand
        Dim sqls As String
        Dim statusPedido As String
        statusPedido = "Fechado"

        sqls = "UPDATE pedido_cabecalho SET status = '" & statusPedido & "' WHERE id = '" & TxtCodPedido.Text & "'"
        cmd = New MySqlCommand(sqls, con)
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub FrmEntrada_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click

        Dim form = New FrmDuplicatas()
        form.TxtNotaFiscal.Text = TxtNotaFiscal.Text
        form.DataEmissao.Value = DataEmissao.Value
        form.TxtIdREg.Text = TxtIdRegistro.Text
        form.TxtTotalDuplicata.Text = TxtTotalNota.Text - TxtTotalDuplicatas.Text
        form.TxtIdFornecedor.Text = TxtFornecedor.Text
        form.ShowDialog()

    End Sub

    Private Sub FrmEntrada_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If pedidoPesquisar = "True" Then
            TxtCodPedido.Text = numeroPedido
            TxtDescPed.Text = nomePedido
            TxtTotalNota.Text = totalPedido
            TxtFornecedor.Text = codFornecedor
            TxtNomeFornecedor.Text = nomeFornecedor

            pedidoPesquisar = ""
            nomePedido = ""
            totalPedido = ""
            codFornecedor = ""
            nomeFornecedor = ""
        End If

        If novaEntrada = "True" Then
            DataGridDuplicatas.DataSource = bs
            TotalDatagridDuplicatas()
            TotalNfe_TotalDuplicatas()
        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' Stop
        If MsgBox("Deseja editar parcela ?", vbYesNo, "Editar duplicatas") = vbYes Then

            editarDuplicata = "True"

            Dim form = New FrmDuplicatas()

            form.TxtIdREg.Text = DataGridDuplicatas.CurrentRow.Cells(0).Value.ToString()
            form.TxtParcela.Text = DataGridDuplicatas.CurrentRow.Cells(1).Value.ToString()
            form.TxtNotaFiscal.Text = DataGridDuplicatas.CurrentRow.Cells(2).Value.ToString()
            form.DataEmissao.Value = DataGridDuplicatas.CurrentRow.Cells(3).Value.ToString()
            form.DataVencimento.Value = DataGridDuplicatas.CurrentRow.Cells(4).Value.ToString()
            form.TxtTotalDuplicata.Text = DataGridDuplicatas.CurrentRow.Cells(5).Value.ToString()
            form.TxtObs.Text = DataGridDuplicatas.CurrentRow.Cells(6).Value.ToString()
            form.TxtIdFornecedor.Text = TxtFornecedor.Text

            form.TxtParcela.Enabled = False

            form.ShowDialog()

        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        If MsgBox("Deseja eliminar parcela ?", vbYesNo, "Eliminar duplicatas") = vbYes Then

            DeltarParcelaBanco()
            ListarDuplicatas()
            TotalDatagridDuplicatas()
            TotalNfe_TotalDuplicatas()

        End If

    End Sub
    Sub DeltarParcelaBanco()
        Try

            Abrir()

            'VERIFICAR ULTIMO ID NO BANCO 
            Dim cmdp As MySqlCommand
            Dim sql As String
            Dim reader As MySqlDataReader
            Dim idReg As String

            idReg = DataGridDuplicatas.CurrentRow.Cells(0).Value.ToString

            sql = "SELECT * FROM duplicatas WHERE id = '" & idReg & "' "
            cmdp = New MySqlCommand(sql, con)
            reader = cmdp.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                Dim cmd As MySqlCommand
                Dim sql1 As String
                sql1 = "DELETE FROM duplicatas where id = '" & idReg & "' "
                cmd = New MySqlCommand(sql1, con)
                cmd.ExecuteNonQuery()

                MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

            Else
                reader.Close()


                DataGridDuplicatas.Rows.Remove(DataGridDuplicatas.CurrentRow)
            End If
        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        LimparCampos()
        BloquearCampos()
        ListarUltimaNota()
        Limpar_cores()

    End Sub

    Private Sub Limpar_cores()

    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If MsgBox("Deseja limpar registros?", vbYesNo, "Limpar registros") = vbYes Then
            LimparCampos()
        End If
    End Sub
    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        ListarProximoPedido()
    End Sub
    Sub ListarProximoPedido()

        Try

            Try
                Abrir()

                'VERIFICAR ULTIMO ID NO BANCO 
                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim ultima As MySqlDataReader

                sql = "SELECT id FROM entrada WHERE id=(SELECT MAX(id) FROM entrada) "
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

            sqlp = "SELECT * FROM entrada WHERE id = '" & proximo & "' "
            cmd = New MySqlCommand(sqlp, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                ProximoRegistro()

                Exit Sub
            Else
                reader.Close()
                proximo = proximo + 1
                GoTo Line1
            End If
            reader.Close()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Sub ProximoRegistro()

        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String

            sql = "SELECT * FROM entrada where id = '" & proximo & "' "

            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then

                TxtIdRegistro.Text = reader(0)
                TxtNotaFiscal.Text = reader(1)
                TxtFornecedor.Text = reader(2)
                TxtNomeFornecedor.Text = reader(3)
                TxtCodPedido.Text = reader(4)
                TxtDescPed.Text = reader(5)
                'TxtStatusPedido.Text = reader(6)
                DataEmissao.Value = reader(7)
                TxtTotalNota.Text = reader(8)

                reader.Close()
            Else
                reader.Close()
            End If


            '..................................................................................
            'LISTAR ITEN DA NOTA FISCAL
            Dim sql1 As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql1 = "SELECT item, cod_produto, produto, quantidade, valor_unitario, valor_total  FROM estoque WHERE id_entrada = '" & proximo & "' order by item asc "
            da = New MySqlDataAdapter(sql1, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()
            '.................................................................................
            'LISTAR DUPLICATAS
            Try
                Dim sqldp As String
                Dim dtdp As New DataTable
                Dim dadp As MySqlDataAdapter
                sqldp = "SELECT * FROM duplicatas WHERE id_entrada = '" & proximo & "' "
                dadp = New MySqlDataAdapter(sqldp, con)
                dadp.Fill(dtdp)
                DataGridDuplicatas.DataSource = dtdp

                FormatarGridDuplicatas()

            Catch ex As Exception
                MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
            End Try
            '....................................................................................

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        ListarPedidoAnterior()
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

            sqlp = "SELECT * FROM entrada WHERE id = '" & anterior & "' "
            cmd = New MySqlCommand(sqlp, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                RegistroAnterior()

                Exit Sub
            Else
                reader.Close()
                anterior = anterior - 1
                GoTo Line1
            End If
            reader.Close()


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try



    End Sub

    Sub RegistroAnterior()

        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String

            sql = "SELECT * FROM entrada where id = '" & anterior & "' "

            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then

                TxtIdRegistro.Text = reader(0)
                TxtNotaFiscal.Text = reader(1)
                TxtFornecedor.Text = reader(2)
                TxtNomeFornecedor.Text = reader(3)
                TxtCodPedido.Text = reader(4)
                TxtDescPed.Text = reader(5)
                'TxtStatusPedido.Text = reader(6)
                DataEmissao.Value = reader(7)
                TxtTotalNota.Text = reader(8)

                reader.Close()

            End If
            reader.Close()

            '..................................................................................
            'LISTAR ITEN DA NOTA FISCAL
            Dim sql1 As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql1 = "SELECT item, cod_produto, produto, quantidade, valor_unitario, valor_total  FROM estoque WHERE id_entrada = '" & anterior & "' order by item asc "
            da = New MySqlDataAdapter(sql1, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()
            '.................................................................................
            'LISTAR DUPLICATAS
            Try
                Dim sqldp As String
                Dim dtdp As New DataTable
                Dim dadp As MySqlDataAdapter
                sqldp = "SELECT * FROM duplicatas WHERE id_entrada = '" & anterior & "' "
                dadp = New MySqlDataAdapter(sqldp, con)
                dadp.Fill(dtdp)
                DataGridDuplicatas.DataSource = dtdp

                FormatarGridDuplicatas()

            Catch ex As Exception
                MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
            End Try
            '....................................................................................

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged

        Dim IdRegistroNFe As Integer
        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String

            sql = "SELECT * FROM entrada where nota LIKE '" & TxtPesquisar.Text & "%' "

            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then

                TxtIdRegistro.Text = reader(0)
                TxtNotaFiscal.Text = reader(1)
                TxtFornecedor.Text = reader(2)
                TxtNomeFornecedor.Text = reader(3)
                TxtCodPedido.Text = reader(4)
                TxtDescPed.Text = reader(5)
                'TxtStatusPedido.Text = reader(6)
                DataEmissao.Value = reader(7)
                TxtTotalNota.Text = reader(8)

                IdRegistroNFe = reader(0)
                reader.Close()
            Else
                reader.Close()
            End If
            reader.Close()

            '..................................................................................
            'LISTAR ITEN DA NOTA FISCAL
            Dim sql1 As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql1 = "SELECT item, cod_produto, produto, quantidade, valor_unitario, valor_total  FROM estoque WHERE id_entrada = '" & IdRegistroNFe & "' order by item asc "
            da = New MySqlDataAdapter(sql1, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()
            '.................................................................................
            'LISTAR DUPLICATAS
            Try
                Dim sqldp As String
                Dim dtdp As New DataTable
                Dim dadp As MySqlDataAdapter
                sqldp = "SELECT * FROM duplicatas WHERE id_entrada = '" & IdRegistroNFe & "' "
                dadp = New MySqlDataAdapter(sqldp, con)
                dadp.Fill(dtdp)
                DataGridDuplicatas.DataSource = dtdp

                FormatarGridDuplicatas()

            Catch ex As Exception
                MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
            End Try
            '....................................................................................

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub


    Private Sub TxtCodPedido_TextChanged(sender As Object, e As EventArgs) Handles TxtCodPedido.TextChanged
        If novaEntrada = "True" Then
            BuscarPedido()
        End If

    End Sub

    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click
        ListarDuplicatas()
        TotalDatagridDuplicatas()
        TotalNfe_TotalDuplicatas()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox("Deseja exluir o registro da nota fiscal " + TxtNotaFiscal.Text + " ?", vbYesNo, "Exclusão") = vbYes Then

            Exluir_Entrada()

            Exluir_Estoque()

            Exluir_Duplicatas()

            Atualizar_PedidoStatus()

            MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

            ListarUltimaNota()

        End If
    End Sub

    Private Sub Exluir_Entrada()

        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            sql = "DELETE FROM entrada where id = '" & TxtIdRegistro.Text & "' "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try

    End Sub
    Private Sub Exluir_Estoque()

        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            sql = "DELETE FROM estoque where id_entrada = '" & TxtIdRegistro.Text & "' "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try

    End Sub
    Private Sub Exluir_Duplicatas()
        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            sql = "DELETE FROM duplicatas where id_entrada = '" & TxtIdRegistro.Text & "' "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try

    End Sub
    Private Sub Atualizar_PedidoStatus()

        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String
            Dim status As String
            status = "Aberto"

            sql = "UPDATE pedido_cabecalho SET status = '" & status & "' WHERE id = '" & TxtCodPedido.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try
    End Sub
End Class