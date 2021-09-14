Imports MySql.Data.MySqlClient

Public Class FrmEntrada


    Private Sub BtnPesqPedido_Click(sender As Object, e As EventArgs) Handles BtnPesqPedido.Click
        Dim form = New FrmPedidoCabecalho
        form.ShowDialog()

    End Sub

    Sub BuscarNome()
        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            If TxtPesquisar.Text <> "" Then
                Abrir()
                Dim sql As String
                Dim dt As New DataTable
                Dim da As MySqlDataAdapter
                sql = "SELECT * FROM pedidos WHERE pedido = '" & TxtPesquisar.Text & "' "
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)
                DataGrid.DataSource = dt

                FormatarGridPesq()
                TotalDatagrid()

            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        If TxtStatusPedido.Text <> "Fechado" Then
            BuscarNome()
        Else
            MsgBox("Pedido fechado, não pode ser utilizado!!", MsgBoxStyle.Information, "Pedido Fechado")
        End If

    End Sub

    Private Sub FormatarGridPesq()
        DataGrid.Columns(0).Visible = False
        'DataGrid.Columns(4).Visible = False
        DataGrid.Columns(10).Visible = False

        DataGrid.Columns(1).HeaderText = "Data Pedido"
        DataGrid.Columns(2).HeaderText = "Cod. Produto"
        DataGrid.Columns(3).HeaderText = "Pedido"
        DataGrid.Columns(4).HeaderText = "Fornecedor"
        DataGrid.Columns(5).HeaderText = "Cliente"
        DataGrid.Columns(6).HeaderText = "Produto"
        DataGrid.Columns(7).HeaderText = "Qtd."
        DataGrid.Columns(8).HeaderText = "Valor Unitário"
        DataGrid.Columns(9).HeaderText = "Valor Total"

        DataGrid.Columns(1).Width = 80
        DataGrid.Columns(2).Width = 60
        DataGrid.Columns(4).Width = 75
        DataGrid.Columns(5).Width = 80
        DataGrid.Columns(6).Width = 170
        DataGrid.Columns(7).Width = 49

        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(8).DefaultCellStyle.Format = "c"
        DataGrid.Columns(9).DefaultCellStyle.Format = "c"

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

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click

        Me.Close()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        TxtNotaFiscal.BackColor = Color.White
        TxtFornecedor.BackColor = Color.White
        TxtPesquisar.BackColor = Color.White

        If DataGrid.RowCount < 1 Then
            MsgBox("Adicione registros para salvar!!", MsgBoxStyle.Information, "Salvar")
            Exit Sub
        End If

        If TxtNotaFiscal.Text <> "" And TxtFornecedor.Text <> "" And TxtPesquisar.Text <> "" Then


            Try
                Abrir()

                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sqls As String
                Dim data1 As String

                Dim data3 As String
                data1 = DataEmissao.Value.ToString("yyyy-MM-dd")

                data3 = Now().ToString("yyyy-MM-dd")

                sqls = "INSERT INTO entrada (id, nota, fornecedor, id_pedido, data_registro, emissao, vencimento, valor, saldo ) VALUES ('" & TxtIdRegistro.Text & "','" & TxtNotaFiscal.Text & "', '" & TxtFornecedor.Text & "', '" & TxtIdPedido.Text & "','" & data3 & "', '" & data1 & "', '" & TxtTotalNota.Text.Replace(",", ".") & "', '" & TxtTotalNota.Text.Replace(",", ".") & "')"
                cmd = New MySqlCommand(sqls, con)
                cmd.ExecuteNonQuery()

                SalvarEstoque()

                SalvarStatusPedido()

                LimparCampos()

                BloquearCampos()

                MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")


            Catch ex As Exception
                MsgBox("Erro ao Salvar!!" + ex.Message)
            End Try
        Else

            TxtNotaFiscal.BackColor = Color.Salmon
            TxtFornecedor.BackColor = Color.Salmon
            TxtPesquisar.BackColor = Color.Salmon

            MsgBox("Campos vazios ou inválidos!!", MsgBoxStyle.Information, "Campos obrigatórios")

        End If
    End Sub
    Sub LimparCampos()

        DataGrid.DataSource = Nothing
        TxtNotaFiscal.Text = ""
        TxtPesquisar.Text = ""
        TxtFornecedor.Text = ""
        TxtIdRegistro.Text = ""
        TxtIdPedido.Text = ""
        IdPedido = ""
        numeroPedido = ""
        StatusPedido = ""
        TxtTotalNota.Text = ""

        codCliente = ""
        codCliente = ""
        nomeCliente = ""
        codProduto = ""
        nomeProduto = ""
        valorUnit = ""

    End Sub
    Sub HabilitarCampos()
        TxtPesquisar.Enabled = True
        BtnPesqPedido.Enabled = True
        BtnPesquisar.Enabled = True
        TxtNotaFiscal.Enabled = True
        BtnSalvar.Enabled = True


    End Sub

    Sub BloquearCampos()
        TxtPesquisar.Enabled = False
        BtnPesqPedido.Enabled = False
        BtnPesquisar.Enabled = False
        TxtNotaFiscal.Enabled = False
        BtnSalvar.Enabled = False
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

        HabilitarCampos()
        GerarIdRegistro()

    End Sub
    Sub SalvarStatusPedido()
        Abrir()

        Dim cmd As MySqlCommand
        Dim sqls As String
        Dim statusPedido As String
        statusPedido = "Fechado"

        sqls = "UPDATE pedido_cabecalho SET status = '" & statusPedido & "' WHERE id = '" & TxtIdPedido.Text & "'"
        cmd = New MySqlCommand(sqls, con)
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub FrmEntrada_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click

        Dim form = New FrmDuplicatas()

        form.TxtNotaFiscal.Text = TxtNotaFiscal.Text
        form.DataEmissao.Value = DataEmissao.Value
        form.TxtTotalDuplicata.Text = TxtTotalNota.Text


        form.ShowDialog()
    End Sub
End Class