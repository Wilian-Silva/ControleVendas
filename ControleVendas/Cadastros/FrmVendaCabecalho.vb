Imports MySql.Data.MySqlClient

Public Class FrmVendaCabecalho
    Sub ListarTudo()
        Try
            'Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT id, id_venda, parcela , valor_parcela, data_venda, data_vencimento, cod_cliente, cliente, saldo_duplicata, observacao  FROM duplicatas_receber order by id_venda desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Sub FiltroDataGrid()


        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            'Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT id, id_venda, parcela , valor_parcela, data_venda, data_vencimento, cod_cliente, cliente, saldo_duplicata, observacao  FROM duplicatas_receber order by id_venda desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If RbPedido.Checked = True Then

                dt.DefaultView.RowFilter = "cod_cliente = " & TxtPesquisa.Text
                DataGrid.DataSource = dt
            End If

            If RbFornecedor.Checked = True Then
                dt.DefaultView.RowFilter = "cliente LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbVenda.Checked = True Then
                dt.DefaultView.RowFilter = "id_venda = " & TxtPesquisa.Text
                DataGrid.DataSource = dt
            End If


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Private Sub FormatarGrid()
        ' DataGrid.Columns(11).Visible = False

        DataGrid.Columns(0).HeaderText = "Nº Dupl."
        DataGrid.Columns(1).HeaderText = "Nº Venda"
        DataGrid.Columns(2).HeaderText = "Parcela"
        DataGrid.Columns(3).HeaderText = "Valor"
        DataGrid.Columns(4).HeaderText = "Data Venda"
        DataGrid.Columns(5).HeaderText = "Data Vencimento"
        DataGrid.Columns(6).HeaderText = "Cód. Cliente"
        DataGrid.Columns(7).HeaderText = "Cliente"
        DataGrid.Columns(8).HeaderText = "Saldo"
        DataGrid.Columns(9).HeaderText = "Observação"

        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(1).Width = 50
        DataGrid.Columns(2).Width = 50
        DataGrid.Columns(6).Width = 50
        DataGrid.Columns(7).Width = 150

        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(3).DefaultCellStyle.Format = "c"
        DataGrid.Columns(8).DefaultCellStyle.Format = "c"


    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        pesquisarDuplicata = ""
        Me.Close()
    End Sub

    Private Sub FrmNotasEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If statusBtn = "Visible" Then
            BtnExcluir.Enabled = True
        End If
        If pesquisarDuplicata = "True" Then
            GboxPesquisar.Visible = True
        End If
        ListarTudo()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        If TxtRegVenda.Text <> "" Then

            'PESQUISAR SE A NOTA JA NÃO FOI PAGA
            Dim cmd1 As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql1 As String

            sql1 = "SELECT * FROM mvto_recebimentos where id_venda = '" & TxtRegVenda.Text & "' "
            cmd1 = New MySqlCommand(sql1, con)
            reader = cmd1.ExecuteReader

            If reader.Read = True Then

                MsgBox("Documento não pode ser excluido, já foi pago!!", MsgBoxStyle.Information, "Excluir Documento")
                reader.Close()
                Exit Sub
            Else
                reader.Close()
            End If


            If TxtRegVenda.Text <> "" Then

                If MsgBox("Deseja excluir a venda do cliente " + TxtCliente.Text + "?", vbYesNo, "Venda") = vbYes Then

                    Excluir_Saida_Estoque()

                    Excluir_venda()

                    Excluir_venda_cabecalho()

                    Excluir_duplicata_receber()

                    AtualizarSaldoItem_Exlusao_venda()

                    MsgBox("Registro escluído com Sucesso!!", MsgBoxStyle.Information, "Exclusão")

                    ListarTudo()

                End If
            Else

                MsgBox("Selecione um pedido para excluir!!", MsgBoxStyle.Information, "Excluir")
            End If

        End If

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
    Sub Excluir_duplicata_receber()
        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim sql1 As String
            sql1 = "DELETE FROM duplicatas_receber where id_venda = '" & TxtRegVenda.Text & "' "
            cmd = New MySqlCommand(sql1, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try
    End Sub
    Sub Excluir_venda_cabecalho()
        Try

            'CONSULTAR TOTAL NA TABELA VENDA
            Abrir()
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            sql1 = "DELETE FROM venda_cabecalho WHERE id_venda =  '" & TxtRegVenda.Text & "' "
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao editar!!" + ex.Message)
        End Try

    End Sub
    Sub Excluir_venda()
        ' Stop
        Try

            Abrir()
            Dim cmd As MySqlCommand
            Dim sql As String
            sql = "DELETE FROM venda WHERE id_venda =  '" & TxtRegVenda.Text & "' '"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

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
            sql1 = "DELETE FROM estoque WHERE id_venda =  '" & TxtRegVenda.Text & "' and tipo = '" & tipomov & "'"
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try
    End Sub
    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex > -1 Then
            On Error Resume Next

            TxtRegVenda.Text = DataGrid.CurrentRow.Cells(1).Value
            TxtCliente.Text = DataGrid.CurrentRow.Cells(7).Value
            TxtValor_Venda.Text = DataGrid.CurrentRow.Cells(3).Value
            TxtSaldo_venda.Text = DataGrid.CurrentRow.Cells(8).Value
        End If

    End Sub

    Private Sub TxtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisa.TextChanged
        FiltroDataGrid()
    End Sub

    Private Sub BtnCacelarConsulta_Click(sender As Object, e As EventArgs) Handles BtnCacelarConsulta.Click
        pesquisarDuplicata = ""
        Me.Close()
    End Sub

    Private Sub BtnSelecionarItem_Click(sender As Object, e As EventArgs) Handles BtnSelecionarItem.Click
        'Stop
        If DataGrid.RowCount > 0 Then

            IdDuplicata = DataGrid.CurrentRow.Cells(11).Value
            IdDuplicata2 = DataGrid.CurrentRow.Cells(0).Value

            Me.Close()
        Else
            MsgBox("Selecione um registro!!", MsgBoxStyle.Information, "Registro não selecionado")
        End If
    End Sub

End Class