Imports MySql.Data.MySqlClient

Public Class FrmSaldoEstoque
    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        ListarTudo()
        FormatarGrid()
    End Sub

    Sub ListarTudo()

        Try
            Abrir()

            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim cmd As MySqlCommand
            Dim sql As String
            sql = "SELECT p.cod_produto, p.produto, v.fornecedor, SUM(p.quantidade) as Quantidade FROM estoque as p INNER JOIN produtos AS v ON p.cod_produto = v.id GROUP BY p.cod_produto "
            'sql = "SELECT cod_produto, produto, SUM(quantidade) as Quantidade FROM estoque GROUP BY cod_produto "
            cmd = New MySqlCommand(sql, con)
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Private Sub FormatarGrid()

        DataGrid.Columns(0).HeaderText = "Cód. Produto"
        DataGrid.Columns(1).HeaderText = "Descrição"
        DataGrid.Columns(2).HeaderText = "Fornecedor"

        DataGrid.Columns(1).Width = 270
        DataGrid.Columns(0).Width = 80

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Sub ListarPesquisar()

        Try
            Abrir()

            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim cmd As MySqlCommand
            Dim sql As String
            sql = "SELECT p.cod_produto, p.produto, v.fornecedor, SUM(p.quantidade) as Quantidade FROM estoque as p INNER JOIN produtos AS v ON p.cod_produto = v.id WHERE p.cod_produto = '" & TxtCodProduto.Text & "'"
            'sql = "SELECT cod_produto, produto, SUM(quantidade) as Quantidade FROM estoque GROUP BY cod_produto "
            cmd = New MySqlCommand(sql, con)
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub BtnPesqNota_Click(sender As Object, e As EventArgs) Handles BtnPesqNota.Click
        Dim form = New FrmProdutos
        form.ShowDialog()
    End Sub

    Private Sub FrmSaldoEstoque_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TxtCodProduto.Text = codProduto
        TxtProduto.Text = nomeProduto
    End Sub

    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        ListarPesquisar()
        FormatarGrid()
    End Sub

    Private Sub FrmSaldoEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class