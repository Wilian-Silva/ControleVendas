Imports MySql.Data.MySqlClient

Public Class FrmVenda
    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        novavenda = "Nova Venda"
        Limpar()
        Dim form = New FrmNovaVenda(Me)
        form.ShowDialog()

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub
    Sub Limpar()
        DataGrid.DataSource = Nothing
        TxtPesquisar.Text = ""
        TxtIdPesquisar.Text = ""
        TxtIdExcluir.Text = ""
        editarVenda = ""
    End Sub
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Limpar()
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click

        ListarTudo()

    End Sub
    Sub ListarTudo()
        'Stop
        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM venda order by id_venda desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            DataGrid.DataSource = dt
            TxtIdPesquisar.Text = "Pesquisar"

            FormatarGrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Private Sub FormatarGrid()
        'Stop

        DataGrid.Columns(1).HeaderText = "Nº Venda"
        DataGrid.Columns(2).HeaderText = "Data Venda"
        DataGrid.Columns(3).HeaderText = "Cód. Cliente"
        DataGrid.Columns(4).HeaderText = "Cliente"
        DataGrid.Columns(5).HeaderText = "Fornecedor"
        DataGrid.Columns(6).HeaderText = "Cód. Produto"
        DataGrid.Columns(7).HeaderText = "Produto"
        DataGrid.Columns(8).HeaderText = "Qtd."
        DataGrid.Columns(9).HeaderText = "Valor Unitário"
        DataGrid.Columns(10).HeaderText = "Valor Total"
        DataGrid.Columns(11).HeaderText = "Forma Pgto."
        DataGrid.Columns(12).HeaderText = "Vencimento"

        'FORMATAR DATAGRID
        DataGrid.Columns(0).Visible = False
        DataGrid.Columns(13).Visible = False

        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).Width = 60

        DataGrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(3).Width = 60

        DataGrid.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).Width = 60

        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).Width = 60

        DataGrid.Columns(7).Width = 140

        DataGrid.Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(9).DefaultCellStyle.Format = "c"
        DataGrid.Columns(10).DefaultCellStyle.Format = "c"

    End Sub
    Sub Pesquisar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM venda WHERE cliente LIKE '" & TxtPesquisar.Text & "%' order by id_venda desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            TxtIdPesquisar.Text = "Pesquisar"

            If DataGrid.Rows.Count > 0 Then
                FormatarGrid()
            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        Pesquisar()
    End Sub



    Private Sub DataGridVenda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick

        If e.RowIndex > -1 Then
            If TxtIdPesquisar.Text <> "" Then
                On Error Resume Next
                TxtIdExcluir.Text = DataGrid.CurrentRow.Cells(1).Value
                BtnEditar.Enabled = True
                index = e.RowIndex

            End If

        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        'If MsgBox("Deseja editar esse registro?", vbYesNo + vbQuestion) = vbYes Then

        '    editarVenda = "Editar Venda"
        '    Dim form = New FrmNovaVenda(Me)

        '    form.TxtIdVenda.Text = DataGridVenda.CurrentRow.Cells(1).Value.ToString()
        '    form.DataVenda.Value = DataGridVenda.CurrentRow.Cells(2).Value.ToString()
        '    form.TxtCodCliente.Text = DataGridVenda.CurrentRow.Cells(3).Value.ToString()
        '    form.TxtCliente.Text = DataGridVenda.CurrentRow.Cells(4).Value.ToString()
        '    form.CbFornecedor.Text = DataGridVenda.CurrentRow.Cells(5).Value.ToString()
        '    form.TxtCodProduto.Text = DataGridVenda.CurrentRow.Cells(6).Value.ToString()
        '    form.TxtProduto.Text = DataGridVenda.CurrentRow.Cells(7).Value.ToString()
        '    'form.TxtQuantidade.Text = DataGridVenda.CurrentRow.Cells(7).Value.ToString()
        '    form.TxtValorUnit.Text = DataGridVenda.CurrentRow.Cells(9).Value.ToString()
        '    form.TxtValorTotal.Text = DataGridVenda.CurrentRow.Cells(10).Value.ToString()
        '    form.CbFormaPgto.Text = DataGridVenda.CurrentRow.Cells(11).Value.ToString()
        '    form.DataVencimento.Value = DataGridVenda.CurrentRow.Cells(12).Value.ToString()

        '    form.ShowDialog()


        'End If

    End Sub

    Private Sub FrmVenda_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        editarVenda = ""
    End Sub


End Class