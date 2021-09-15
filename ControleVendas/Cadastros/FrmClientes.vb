Imports MySql.Data.MySqlClient

Public Class FrmClientes
    Dim editarCliente As String
    Dim proximo As Integer
    Dim anterior As Integer
    Dim maximo As Integer
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If pesquisarCliente = "True" Then

            GBoxCliente.Visible = False
            BtnSelecionarItem.Visible = True
            BtnCacelarConsulta.Visible = True
            Listar()
        Else
            Listar()
        End If

    End Sub

    Private Sub HabilitarCampos()
        TxtNome.Enabled = True
        TxtCPF.Enabled = True
        TxtEndereco.Enabled = True
        TxtTelefone.Enabled = True
    End Sub

    Private Sub DesabilitarCampos()
        TxtNome.Enabled = False
        TxtCPF.Enabled = False
        TxtEndereco.Enabled = False
        TxtTelefone.Enabled = False
    End Sub
    Private Sub LimparCampos()
        TxtNome.Text = ""
        TxtCPF.Text = ""
        TxtEndereco.Text = ""
        TxtTelefone.Text = ""
        TxtId.Text = ""
        TxtPesquisar.Text = ""
    End Sub
    Sub DadosCabecalho()

        On Error Resume Next
        TxtId.Text = DataGrid.CurrentRow.Cells(0).Value
        TxtNome.Text = DataGrid.CurrentRow.Cells(1).Value
        TxtCPF.Text = DataGrid.CurrentRow.Cells(2).Value
        TxtEndereco.Text = DataGrid.CurrentRow.Cells(3).Value
        TxtTelefone.Text = DataGrid.CurrentRow.Cells(4).Value

    End Sub
    Sub Editar_Cores()
        TxtNome.BackColor = Color.Salmon
        TxtCPF.BackColor = Color.Salmon
        TxtEndereco.BackColor = Color.Salmon
        TxtTelefone.BackColor = Color.Salmon
    End Sub
    Sub Limpar_cores()
        TxtNome.BackColor = Color.White
        TxtCPF.BackColor = Color.White
        TxtEndereco.BackColor = Color.White
        TxtTelefone.BackColor = Color.White
    End Sub
    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM clientes order by id desc"
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
        DataGrid.Columns(0).HeaderText = "Cód."
        DataGrid.Columns(1).HeaderText = "Nome Cliente"
        DataGrid.Columns(2).HeaderText = "CPF"
        DataGrid.Columns(3).HeaderText = "Endereço"
        DataGrid.Columns(4).HeaderText = "Telefone"
        DataGrid.Columns(5).HeaderText = "Data Cadastro"


        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).Width = 40
        DataGrid.Columns(1).Width = 112
        DataGrid.Columns(3).Width = 140
        DataGrid.Columns(5).Width = 75

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

            sql = "SELECT * FROM clientes where nome LIKE '" & TxtPesquisar.Text & "%' order by id desc"
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

        HabilitarCampos()
        LimparCampos()
        TxtNome.Focus()

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtId.Text <> "" Then

            If MsgBox("Deseja editar o cliente " & TxtId.Text & ": " & TxtNome.Text & "?", vbYesNo, "Editar") = vbYes Then

                HabilitarCampos()

                Editar_Cores()

                editarCliente = "Editar"

            End If
        Else

            MsgBox("Selecione um registro para editar!!", MsgBoxStyle.Information, "Editar")
            TxtNome.Focus()
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        If editarCliente = "Editar" And TxtId.Text <> "" Then

            SalvarEdicao()

            LimparCampos()

            Listar()

            DesabilitarCampos()

            Limpar_cores()

            DadosCabecalho()

        Else

            Try
                Abrir()

                'VERIFICAR SE O CLIENTE JÁ EXISTE
                Dim cmdUSU As MySqlCommand
                Dim readerUSU As MySqlDataReader
                Dim sqlUSU As String

                sqlUSU = "SELECT * FROM clientes WHERE id = '" & TxtId.Text & "' "
                cmdUSU = New MySqlCommand(sqlUSU, con)
                readerUSU = cmdUSU.ExecuteReader
                If readerUSU.Read = True Then
                    readerUSU.Close()
                    MsgBox("Este Cliente " + TxtNome.Text + " já está cadastrado!!", MsgBoxStyle.Information, "Cliente Já Cadastrado")
                    TxtNome.Focus()
                    Exit Sub
                End If
                readerUSU.Close()

                If TxtNome.Text <> "" Then
                    'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO

                    TxtNome.BackColor = Color.White
                    Dim cmd As MySqlCommand
                    Dim sqls As String

                    Dim data As String
                    data = Now().ToString("yyyy-MM-dd")

                    sqls = "INSERT INTO clientes (nome, cpf, endereco, telefone, data ) VALUES ('" & TxtNome.Text & "', '" & TxtCPF.Text & "', '" & TxtEndereco.Text & "', '" & TxtTelefone.Text & "', '" & data & "')"
                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    Listar()

                    DesabilitarCampos()

                    DadosCabecalho()

                    MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")


                Else
                    TxtNome.BackColor = Color.Salmon

                    MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Dados inválidos")
                    TxtNome.Focus()
                End If

            Catch ex As Exception
                MsgBox("Erro ao Salvar!!" + ex.Message)
            End Try

        End If

    End Sub

    Sub SalvarEdicao()
        Try

            'ABRINDO A CONEXÃO
            Abrir()

            'PROGRAMANDO EDIÇÃO DE REGISTRO NO BANCO
            Dim cmd As MySqlCommand
            Dim sql As String

            sql = "UPDATE clientes SET nome = '" & TxtNome.Text & "', cpf = '" & TxtCPF.Text & "', endereco = '" & TxtEndereco.Text & "', telefone = '" & TxtTelefone.Text & "' where id = '" & TxtId.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

            DesabilitarCampos()

            MsgBox("Registro editado com Sucesso!!", MsgBoxStyle.Information, "Editar")

        Catch ex As Exception
            MsgBox("Erro ao editar!!" + ex.Message)
        End Try
    End Sub
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click


        'PESQUISAR SE O CLIENTE JA FOI MOVIMENTADO
        Abrir()

        Dim cmd1 As MySqlCommand
        Dim reader As MySqlDataReader
        Dim sql1 As String

        sql1 = "SELECT * FROM venda where cod_cliente = '" & TxtId.Text & "' "
        cmd1 = New MySqlCommand(sql1, con)
        reader = cmd1.ExecuteReader

        If reader.Read = True Then

            MsgBox("Cadastro não pode ser excluido,cliente já possui movimentação!!", MsgBoxStyle.Information, "Exclusão")
            reader.Close()
            Exit Sub
        Else
            reader.Close()
        End If

        If TxtId.Text <> "" Then


            If MsgBox("Deseja excluir cadastro " & TxtId.Text & ": " & TxtNome.Text & "?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "DELETE FROM clientes where id = '" & TxtId.Text & "' "
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

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimparCampos()
        DesabilitarCampos()
        Listar()
        Limpar_cores()
    End Sub

    Private Sub BtnCacelarConsulta_Click(sender As Object, e As EventArgs) Handles BtnCacelarConsulta.Click
        pesquisarCliente = ""
        Me.Close()
    End Sub

    Private Sub BtnSelecionarItem_Click(sender As Object, e As EventArgs) Handles BtnSelecionarItem.Click
        If DataGrid.RowCount > 0 Then

            codCliente = DataGrid.CurrentRow.Cells(0).Value
            nomeCliente = DataGrid.CurrentRow.Cells(1).Value

            Me.Close()
        Else
            MsgBox("Selecione um registro!!", MsgBoxStyle.Information, "Registro não selecionado")
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If MsgBox("Deseja limpar registros?", vbYesNo, "Limpar registros") = vbYes Then
            LimparCampos()
        End If
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        ListarPedidoAnterior()

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

                sql = "SELECT id FROM clientes WHERE id=(SELECT MAX(id) FROM clientes) "
                cmdp = New MySqlCommand(sql, con)
                ultima = cmdp.ExecuteReader()

                If (ultima.Read()) Then
                    maximo = ultima("id")
                    ultima.Close()
                End If
                ultima.Close()

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

            sqlp = "SELECT * FROM clientes WHERE id = '" & proximo & "' "
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
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT * FROM clientes WHERE id = '" & proximo & "' "
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

    Sub ListarPedidoAnterior()

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

            sqlp = "SELECT * FROM clientes WHERE id = '" & anterior & "' "
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
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT * FROM clientes WHERE id = '" & anterior & "' "
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