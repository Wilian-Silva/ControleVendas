Imports MySql.Data.MySqlClient

Public Class FrmSaldoEstoque
    Dim maximo As Integer
    Dim proximo As Integer
    Dim anterior As Integer
    Private Sub FormatarGrid()

        DataGrid.Columns(4).Visible = False
        DataGrid.Columns(5).Visible = False

        DataGrid.Columns(0).HeaderText = "Cód. Produto"
        DataGrid.Columns(1).HeaderText = "Descrição"
        DataGrid.Columns(2).HeaderText = "Cód. Auxiliar"
        DataGrid.Columns(3).HeaderText = "Preço Compra"
        'DataGrid.Columns(4).HeaderText = "Margem"
        ' DataGrid.Columns(5).HeaderText = "Preço Venda"
        DataGrid.Columns(6).HeaderText = "Saldo Estoque"

        DataGrid.Columns(0).Width = 60
        DataGrid.Columns(1).Width = 270
        DataGrid.Columns(2).Width = 85
        DataGrid.Columns(3).Width = 90
        DataGrid.Columns(6).Width = 60

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(3).DefaultCellStyle.Format = "c"
        'DataGrid.Columns(5).DefaultCellStyle.Format = "c"

    End Sub

    Sub ListarTudo()

        Try

            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM produtos order by nome desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

        'sql = "SELECT p.cod_produto, p.produto, v.fornecedor, SUM(p.quantidade) as Quantidade FROM estoque as p INNER JOIN produtos AS v ON p.cod_produto = v.id WHERE p.cod_produto = '" & TxtCodProduto.Text & "'"

    End Sub

    Sub FiltroDataGrid()
        'Stop
        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM produtos order by nome desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If RbCodAux.Checked = True Then
                dt.DefaultView.RowFilter = "cod_auxiliar LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbDescricao.Checked = True Then

                dt.DefaultView.RowFilter = "nome LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub DadosCabecalho()

        On Error Resume Next
        TxtId.Text = DataGrid.CurrentRow.Cells(0).Value
        TxtNome.Text = DataGrid.CurrentRow.Cells(1).Value
        TxtCodAuxiliar.Text = DataGrid.CurrentRow.Cells(2).Value
        TxtPrecoVenda.Text = DataGrid.CurrentRow.Cells(3).Value
        TxtMargemVenda.Text = DataGrid.CurrentRow.Cells(4).Value
        TxtLucro.Text = DataGrid.CurrentRow.Cells(5).Value
        TxtSaldoEstoque.Text = DataGrid.CurrentRow.Cells(6).Value

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub BtnPesqNota_Click(sender As Object, e As EventArgs)
        Dim form = New FrmProdutos
        form.ShowDialog()
    End Sub


    Private Sub FrmSaldoEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarTudo()
    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        DadosCabecalho()
    End Sub

    Private Sub TxtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisa.TextChanged
        FiltroDataGrid()
    End Sub

    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        ListarProximo()
    End Sub

    Sub ListarProximo()

        Try

            Try
                Abrir()

                'VERIFICAR ULTIMO ID NO BANCO 
                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim ultima As MySqlDataReader

                sql = "SELECT id FROM produtos WHERE id=(SELECT MAX(id) FROM produtos) "
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
            '...................................................................................

            If TxtId.Text <> "" Then
                proximo = TxtId.Text + 1
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

            sqlp = "SELECT * FROM produtos WHERE id = '" & proximo & "' "
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
            sql = "SELECT * FROM produtos WHERE id = '" & proximo & "' "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        ListarAnterior()
    End Sub
    Sub ListarAnterior()

        Try

            If TxtId.Text <> "" Then
                anterior = TxtId.Text - 1
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

            sqlp = "SELECT * FROM produtos WHERE id = '" & anterior & "' "
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
            sql = "SELECT * FROM produtos WHERE id = '" & anterior & "' "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If DataGrid.Rows.Count > 0 Then
                DadosCabecalho()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
End Class