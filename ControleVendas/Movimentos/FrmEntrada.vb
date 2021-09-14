Imports MySql.Data.MySqlClient

Public Class FrmEntrada


    Private Sub BtnPesqPedido_Click(sender As Object, e As EventArgs) Handles BtnPesqPedido.Click
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
        TxtTotalNota.Text = ""
        TxtIdRegistro.Text = ""
        TxtStatusPedido.Text = ""

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

                TotalDatagrid()

            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Sub ListarDuplicatas()
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

        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String

            sql = "SELECT * FROM entrada WHERE id=(SELECT MAX(id) FROM entrada) "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then

                TxtIdRegistro.Text = reader(0)
                TxtNotaFiscal.Text = reader(1)
                TxtFornecedor.Text = reader(2)
                TxtNomeFornecedor.Text = reader(3)
                TxtCodPedido.Text = reader(4)
                TxtDescPed.Text = reader(5)
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


    Sub FormatarGridDuplicatas()

        DataGridDuplicatas.Columns(7).Visible = False

        DataGridDuplicatas.Columns(0).HeaderText = "Id. Reg."
        DataGridDuplicatas.Columns(1).HeaderText = "Parcela"
        DataGridDuplicatas.Columns(2).HeaderText = "Documento"
        DataGridDuplicatas.Columns(3).HeaderText = "Data Emissão"
        DataGridDuplicatas.Columns(4).HeaderText = "Data Vencimento"
        DataGridDuplicatas.Columns(5).HeaderText = "Valor Parcela"
        DataGridDuplicatas.Columns(6).HeaderText = "Observação"

    End Sub
    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click

        If TxtStatusPedido.Text <> "Fechado" Then

            BuscarPedido()

        Else

            MsgBox("Pedido fechado, não pode ser utilizado!!", MsgBoxStyle.Information, "Pedido Fechado")

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
    Private Sub TotalDatagrid()

        'CALCULANDO SOMA TOTAL
        On Error Resume Next
        Dim total As Decimal = 0
        For i = 0 To DataGrid.Rows.Count - 1
            total = total + DataGrid.Rows(i).Cells(9).Value
        Next
        TxtTotalNota.Text = total
        'TxtTotalPedido.Text = Convert.ToDouble(TxtTotalPedido.Text).ToString("C")
    End Sub
    Private Sub TotalDatagridDuplicatas()

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

        Me.Close()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        TxtNotaFiscal.BackColor = Color.White
        TxtFornecedor.BackColor = Color.White
        TxtDescPed.BackColor = Color.White


        If DataGrid.RowCount < 1 Then
            MsgBox("Adicione registros para salvar!!", MsgBoxStyle.Information, "Salvar")
            Exit Sub
        End If

        If TxtNotaFiscal.Text <> "" And TxtFornecedor.Text <> "" And TxtCodPedido.Text <> "" Then

            '............................................................................................
            'VALIDAR TOTAL DUPLICATAS E TOTAL NOTA
            Dim soma As Double
            soma = TxtTotalNota.Text - TxtTotalDuplicatas.Text
            If soma >= 1 Then
                MsgBox("Total de duplicatas diferente do valor total da nota fiscal")
                Exit Sub
            End If
            '............................................................................................

            Try
                Abrir()

                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sqls As String
                Dim data1 As String

                Dim data3 As String
                data1 = DataEmissao.Value.ToString("yyyy-MM-dd")

                data3 = Now().ToString("yyyy-MM-dd")

                sqls = "INSERT INTO entrada (id, nota, fornecedor, id_pedido, data_registro, emissao, vencimento, valor, saldo ) VALUES ('" & TxtIdRegistro.Text & "','" & TxtNotaFiscal.Text & "', '" & TxtFornecedor.Text & "', '" & TxtCodPedido.Text & "','" & data3 & "', '" & data1 & "', '" & TxtTotalNota.Text.Replace(",", ".") & "', '" & TxtTotalNota.Text.Replace(",", ".") & "')"
                cmd = New MySqlCommand(sqls, con)
                cmd.ExecuteNonQuery()

                SalvarEstoque()

                SalvarStatusPedido()

                SalvarDuplicata()

                LimparCampos()

                BloquearCampos()


                MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")


            Catch ex As Exception
                MsgBox("Erro ao Salvar!!" + ex.Message)
            End Try
        Else

            TxtNotaFiscal.BackColor = Color.Salmon
            TxtFornecedor.BackColor = Color.Salmon
            TxtDescPed.BackColor = Color.Salmon

            MsgBox("Campos vazios ou inválidos!!", MsgBoxStyle.Information, "Campos obrigatórios")

        End If
    End Sub

    Sub SalvarDuplicata()

        Try

            For i = 0 To DataGridDuplicatas.RowCount - 1

                Dim cmd As MySqlCommand
                Dim sqls As String
                sqls = "INSERT INTO duplicatas (parcela, documento, data_emissao, data_vencimento, valor_parcela, observacao, id_entrada) VALUES (@parcela, @documento, @data_emissao, @data_vencimento, @valor_parcela, @observacao )"
                cmd = New MySqlCommand(sqls, con)
                With cmd
                    .Parameters.AddWithValue("@parcela", CInt(DataGridDuplicatas.Rows(i).Cells(1).Value.ToString))
                    .Parameters.AddWithValue("@documento", CInt(DataGridDuplicatas.Rows(i).Cells(2).Value.ToString))
                    .Parameters.AddWithValue("@data_emissao", CDate(DataGridDuplicatas.Rows(i).Cells(3).Value.ToString))
                    .Parameters.AddWithValue("@data_vencimento", CDate(DataGridDuplicatas.Rows(i).Cells(4).Value.ToString))
                    .Parameters.AddWithValue("@valor_parcela", CDbl(DataGridDuplicatas.Rows(i).Cells(5).Value.ToString))
                    .Parameters.AddWithValue("@observacao", DataGridDuplicatas.Rows(i).Cells(6).Value.ToString)
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


            data1 = Now().ToString("yyyy-MM-dd")
            IdNota = TxtIdRegistro.Text
            fornec = TxtFornecedor.Text
            Dim tipomvto As String
            tipomvto = "Entrada"
            For i = 0 To DataGrid.RowCount - 1

                sql1 = "INSERT INTO estoque (data_registro, tipo, id_nota, cod_produto, produto, quantidade, valor_unitario, valor_total ) VALUES ('" & data1 & "', '" & tipomvto & "', '" & IdNota & "', @cod_produto, @produto, @quantidade, @valor_unitario, @valor_total)"
                cmd1 = New MySqlCommand(sql1, con)
                With cmd1

                    .Parameters.AddWithValue("@cod_produto", CInt(DataGrid.Rows(i).Cells(2).Value.ToString))
                    .Parameters.AddWithValue("@produto", DataGrid.Rows(i).Cells(6).Value.ToString)
                    .Parameters.AddWithValue("@quantidade", CInt(DataGrid.Rows(i).Cells(7).Value.ToString))
                    .Parameters.AddWithValue("@valor_unitario", CDbl(DataGrid.Rows(i).Cells(8).Value.ToString))
                    .Parameters.AddWithValue("@valor_total", CDbl(DataGrid.Rows(i).Cells(9).Value.ToString))
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
            Else
                TxtIdRegistro.Text = 1

            End If

            ultima.Close()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click

        LimparCampos()

        HabilitarCampos()

        GerarIdRegistro()

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


        If DataGridDuplicatas.Rows.Count < 1 Then

            form.TxtTotalDuplicata.Text = TxtTotalNota.Text
            form.TxtNotaFiscal.Text = TxtNotaFiscal.Text
            form.DataEmissao.Value = DataEmissao.Value
        Else
            form.TxtTotalDuplicata.Text = TxtTotalNota.Text - TxtTotalDuplicatas.Text
            form.TxtNotaFiscal.Text = TxtNotaFiscal.Text
            form.DataEmissao.Value = DataEmissao.Value
        End If

        form.ShowDialog()
    End Sub

    Private Sub FrmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarUltimaNota()
    End Sub

    Private Sub FrmEntrada_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated



        If DataGridDuplicatas.Rows.Count >= 1 Then


            'Dim soma As Double

            'soma = TxtTotalNota.Text - CDbl(TxtTotalDuplicatas.Text)
            'If soma >= 1 Then

            '    LblSaldo.Text = "Valor total de duplicatas está diferente do valor total do documento!"

            'End If

            TotalDatagridDuplicatas()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

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

            form.TxtParcela.Enabled = False

            form.ShowDialog()

        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        If MsgBox("Deseja eliminar parcela ?", vbYesNo, "Eliminar duplicatas") = vbYes Then


            DeltarParcelaBanco()


                DataGridDuplicatas.Rows.Remove(DataGridDuplicatas.CurrentRow)

        End If

    End Sub
    Sub DeltarParcelaBanco()

        Abrir()
        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
        Dim cmd As MySqlCommand
        Dim sql As String
        Dim idReg As Integer
        idReg = DataGridDuplicatas.CurrentRow.Cells(0).Value.ToString()

        sql = "DELETE FROM duplicatas where id = '" & idReg & "' "
        cmd = New MySqlCommand(sql, con)
        cmd.ExecuteNonQuery()

        MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

    End Sub


End Class