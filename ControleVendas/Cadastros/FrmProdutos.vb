Imports MySql.Data.MySqlClient

Public Class FrmProdutos
    Dim editarProduto As String
    Private Sub HabilitarCampos()

        TxtNome.Enabled = True
        TxtCodAuxiliar.Enabled = True
        TxtPrecoVenda.Enabled = True
        TxtMargemVenda.Enabled = True

    End Sub

    Private Sub DesabilitarCampos()

        TxtNome.Enabled = False
        TxtCodAuxiliar.Enabled = False
        TxtPrecoVenda.Enabled = False
        TxtMargemVenda.Enabled = False

    End Sub
    Private Sub LimparCampos()

        TxtPesquisar.Text = ""
        TxtNome.Text = ""
        TxtCodAuxiliar.Text = ""
        TxtSaldoEstoque.Text = ""
        TxtPrecoVenda.Text = Nothing
        TxtMargemVenda.Text = Nothing
        TxtLucro.Text = Nothing
        TxtId.Text = ""
        editarProduto = ""
        TxtNome.BackColor = Color.White


    End Sub
    Sub Editar_Cores()
        TxtNome.BackColor = Color.Salmon
        TxtCodAuxiliar.BackColor = Color.Salmon
        TxtPrecoVenda.BackColor = Color.Salmon
        TxtMargemVenda.BackColor = Color.Salmon
    End Sub
    Sub Limpar_cores()
        TxtNome.BackColor = Color.White
        TxtCodAuxiliar.BackColor = Color.White
        TxtPrecoVenda.BackColor = Color.White
        TxtMargemVenda.BackColor = Color.White
    End Sub
    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "Select * FROM produtos order by id desc"
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

    Private Sub FormatarGrid()
        'DataGrid.Columns(0).Visible = False

        DataGrid.Columns(0).HeaderText = "Cod. Produto"
        DataGrid.Columns(1).HeaderText = "Produto"
        DataGrid.Columns(2).HeaderText = "Cód. Auxiliar"
        DataGrid.Columns(3).HeaderText = "Preço Compra"
        DataGrid.Columns(4).HeaderText = "Margem Lucro"
        DataGrid.Columns(5).HeaderText = "Preço Venda"
        DataGrid.Columns(6).HeaderText = "Saldo Estoque"

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).Width = 58
        DataGrid.Columns(1).Width = 250
        DataGrid.Columns(2).Width = 90
        DataGrid.Columns(3).Width = 85
        DataGrid.Columns(5).Width = 85
        DataGrid.Columns(4).Width = 60
        DataGrid.Columns(6).Width = 80
        DataGrid.Columns(3).DefaultCellStyle.Format = "c"
        DataGrid.Columns(5).DefaultCellStyle.Format = "c"

    End Sub
    Sub DadosCabecalho()

        On Error Resume Next
        TxtId.Text = DataGrid.CurrentRow.Cells(0).Value
        TxtNome.Text = DataGrid.CurrentRow.Cells(1).Value
        TxtCodAuxiliar.Text = DataGrid.CurrentRow.Cells(2).Value
        TxtPrecoVenda.Text = DataGrid.CurrentRow.Cells(3).Value
        TxtMargemVenda.Text = DataGrid.CurrentRow.Cells(4).Value
        TxtLucro.Text = DataGrid.CurrentRow.Cells(5).Value
        TxtSaldoEstoque.Text = DataGrid.CurrentRow.Cells(6).Value

    End Sub
    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick

        If e.RowIndex > -1 Then
            DadosCabecalho()
        End If

    End Sub
    Sub BuscarNome()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "Select * FROM produtos where nome Like '%" & TxtPesquisar.Text & "%' order by nome asc"
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
    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click

        LimparCampos()
        HabilitarCampos()
        TxtNome.Focus()


    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If TxtId.Text <> "" Then

            If MsgBox("Deseja editar o item " & TxtId.Text & ": " & TxtNome.Text & "?", vbYesNo, "Editar") = vbYes Then

                HabilitarCampos()

                Editar_Cores()

                editarProduto = "Editar"

            End If
        Else
            MsgBox("Selecione um registro para editar!!", MsgBoxStyle.Information, "Editar")
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        If editarProduto = "Editar" And TxtId.Text <> "" Then

            SalvarEdicao()

            LimparCampos()

            Listar()

            DesabilitarCampos()

            Limpar_cores()

        Else

            Abrir()

            'VERIFICAR SE O CLIENTE JÁ EXISTE
            Dim cmdUSU As MySqlCommand
            Dim readerUSU As MySqlDataReader
            Dim sqlUSU As String

            sqlUSU = "SELECT * FROM produtos WHERE id = '" & TxtId.Text & "' "
            cmdUSU = New MySqlCommand(sqlUSU, con)
            readerUSU = cmdUSU.ExecuteReader

            'VERIFICAR SE ALGO FOI ENCONTRADO A PARTIR DA CONSULTA
            If readerUSU.Read = True Then
                readerUSU.Close()
                MsgBox("Este produto " + TxtId.Text + " já está cadastrado!!", MsgBoxStyle.Information, "Cliente Já Cadastrado")
                TxtNome.Focus()
                Exit Sub
            End If
            readerUSU.Close()

            'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
            TxtNome.BackColor = Color.White

            If TxtNome.Text <> "" Then
                Try
                    Abrir()

                    Dim cmd As MySqlCommand
                    Dim sqls As String

                    sqls = "INSERT INTO produtos (nome, cod_auxiliar, preco_compra, margem_venda, preco_venda) VALUES ('" & TxtNome.Text & "', '" & TxtCodAuxiliar.Text & "', '" & TxtPrecoVenda.Text.Replace(",", ".") & "', '" & TxtMargemVenda.Text.Replace(",", ".") & "', '" & TxtLucro.Text.Replace(",", ".") & "')"
                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    LimparCampos()

                    Listar()

                    DesabilitarCampos()

                    MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                Catch ex As Exception
                    MsgBox("Erro ao Salvar!!" + ex.Message)
                End Try

            Else
                TxtNome.BackColor = Color.Salmon

                MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Dados inválidos")
                TxtNome.Focus()

                Exit Sub
            End If


        End If

    End Sub
    Sub SalvarEdicao()
        Try

            Abrir()
            Dim cmd As MySqlCommand
            Dim sql As String

            sql = "UPDATE produtos SET nome = '" & TxtNome.Text & "', cod_auxiliar = '" & TxtCodAuxiliar.Text & "', preco_compra = '" & TxtPrecoVenda.Text.Replace(",", ".") & "', margem_venda = '" & TxtMargemVenda.Text.Replace(",", ".") & "', preco_venda = '" & TxtLucro.Text.Replace(",", ".") & "' where id = '" & TxtId.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

            DesabilitarCampos()

            MsgBox("Registro editado com Sucesso!!", MsgBoxStyle.Information, "Editar")

        Catch ex As Exception
            MsgBox("Erro ao editar!!" + ex.Message)
        End Try
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        'PESQUISAR SE PRODUTO JA FOI MOVIMENTADO
        Abrir()

        Dim cmd1 As MySqlCommand
        Dim reader As MySqlDataReader
        Dim sql1 As String

        sql1 = "SELECT * FROM estoque where cod_produto = '" & TxtId.Text & "' "
        cmd1 = New MySqlCommand(sql1, con)
        reader = cmd1.ExecuteReader

        If reader.Read = True Then

            MsgBox("Cadastro não pode ser excluido, item já possui movimentação!!", MsgBoxStyle.Information, "Exclusão")
            reader.Close()
            Exit Sub
        Else
            reader.Close()
        End If


        'PROGRAMANDO EXCLUSÃO DO RESGISTRO
        If TxtId.Text <> "" Then
            If MsgBox("Deseja excluir o item " & TxtId.Text & ": " & TxtNome.Text & "?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "DELETE FROM produtos where id = '" & TxtId.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                    Listar()

                Catch ex As Exception
                    MsgBox("Erro ao excluir!!" + ex.Message)
                End Try


            End If
        Else
            MsgBox("Selecione um registro para excluir!!", MsgBoxStyle.Information, "Exlusão")
        End If
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        BuscarNome()
    End Sub

    Private Sub TxtMargemVenda_TextChanged(sender As Object, e As EventArgs) Handles TxtMargemVenda.TextChanged

        On Error Resume Next
        Dim preco_venda As Integer
        preco_venda = TxtMargemVenda.Text
        TxtLucro.Text = (TxtPrecoVenda.Text / (1 - (preco_venda / 100)))

    End Sub

    Private Sub TxtPrecoVenda_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecoVenda.TextChanged

        On Error Resume Next
        Dim preco_venda As Integer
        preco_venda = TxtMargemVenda.Text
        TxtLucro.Text = (TxtPrecoVenda.Text / (1 - (preco_venda / 100)))

    End Sub



    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click

        If MsgBox("Deseja limpar registros?", vbYesNo, "Limpar registros") = vbYes Then
            LimparCampos()
        End If
    End Sub

    Private Sub FrmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If pesquisarProduto = "True" Then

            GboxProduto.Visible = False
            BtnSelecionarItem.Visible = True
            BtnCacelarConsulta.Visible = True
            Listar()
        Else
            Listar()
        End If

    End Sub

    Private Sub BtnSelecionarItem_Click(sender As Object, e As EventArgs) Handles BtnSelecionarItem.Click
        If DataGrid.RowCount > 0 Then
            codProduto = DataGrid.CurrentRow.Cells(0).Value
            nomeProduto = DataGrid.CurrentRow.Cells(1).Value
            valorUnit = DataGrid.CurrentRow.Cells(3).Value
            saldoEstoque = DataGrid.CurrentRow.Cells(6).Value
            Me.Close()
        Else
            MsgBox("Selecione um registro!!", MsgBoxStyle.Information, "Registro não selecionado")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimparCampos()
        DesabilitarCampos()
        Listar()
        Limpar_cores()
    End Sub

    Private Sub BtnCacelarConsulta_Click(sender As Object, e As EventArgs) Handles BtnCacelarConsulta.Click
        pesquisarProduto = ""
        Me.Close()
    End Sub


End Class