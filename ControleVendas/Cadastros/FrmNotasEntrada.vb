Imports MySql.Data.MySqlClient

Public Class FrmNotasEntrada

    Sub ListarTudo()
        Try
            'Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT d.id_entrada,  d.documento, d.data_emissao, f.nome_fantasia, d.parcela, d.data_vencimento, d.valor_parcela, d.saldo_duplicata, e.id_pedido, e.descricao, d.observacao, d.id FROM duplicatas as d INNER JOIN fornecedor as f ON d.cod_fornecedor = f.id INNER JOIN entrada as e ON d.id_entrada = e.id  order by d.documento desc"
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

            sql = "SELECT d.id_entrada,  d.documento, d.data_emissao, f.nome_fantasia, d.parcela, d.data_vencimento, d.valor_parcela, d.saldo_duplicata, e.id_pedido, e.descricao, d.observacao, d.id FROM duplicatas as d INNER JOIN fornecedor as f ON d.cod_fornecedor = f.id INNER JOIN entrada as e ON d.id_entrada = e.id  order by d.documento desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If RbPedido.Checked = True Then

                dt.DefaultView.RowFilter = "descricao LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbFornecedor.Checked = True Then
                dt.DefaultView.RowFilter = "nome_fantasia LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbNota.Checked = True Then
                'dt.DefaultView.RowFilter = "documento =" & TxtPesquisa.Text
                dt.DefaultView.RowFilter = "documento LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Private Sub FormatarGrid()
        DataGrid.Columns(11).Visible = False

        DataGrid.Columns(0).HeaderText = "Reg. Entrada"
        DataGrid.Columns(1).HeaderText = "Nota Fiscal"
        DataGrid.Columns(2).HeaderText = "Data Emissão"
        DataGrid.Columns(3).HeaderText = "Fornecedor"
        DataGrid.Columns(4).HeaderText = "Parcela"
        DataGrid.Columns(5).HeaderText = "Vencimento"
        DataGrid.Columns(6).HeaderText = "Valor Parcela"
        DataGrid.Columns(7).HeaderText = "Saldo"
        DataGrid.Columns(8).HeaderText = "Pedido"
        DataGrid.Columns(9).HeaderText = "Descrição"
        DataGrid.Columns(10).HeaderText = "Observação"
        ' DataGrid.Columns(11).HeaderText = "Reg. Duplicata"


        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(1).Width = 60
        DataGrid.Columns(2).Width = 90
        DataGrid.Columns(3).Width = 150
        DataGrid.Columns(4).Width = 50
        DataGrid.Columns(5).Width = 90
        DataGrid.Columns(8).Width = 50
        DataGrid.Columns(9).Width = 150
        DataGrid.Columns(10).Width = 150
        'DataGrid.Columns(11).Width = 50

        'DataGrid.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ' DataGrid.Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).DefaultCellStyle.Format = "c"
        DataGrid.Columns(7).DefaultCellStyle.Format = "c"

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        pesquisarDuplicata = ""
        Me.Close()
    End Sub

    Private Sub FrmNotasEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If pesquisarDuplicata = "True" Then
            GboxPesquisar.Visible = True
        End If
        ListarTudo()
    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex > -1 Then
            On Error Resume Next

            TxtId.Text = DataGrid.CurrentRow.Cells(0).Value
            TxtNota.Text = DataGrid.CurrentRow.Cells(1).Value
            TxtFornecedor.Text = DataGrid.CurrentRow.Cells(3).Value
            TxtIdPedido.Text = DataGrid.CurrentRow.Cells(8).Value

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
            PedidoRelCompra = DataGrid.CurrentRow.Cells(9).Value

            Me.Close()
        Else
            MsgBox("Selecione um registro!!", MsgBoxStyle.Information, "Registro não selecionado")
        End If
    End Sub


End Class