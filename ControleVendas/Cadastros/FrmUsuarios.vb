
Imports MySql.Data.MySqlClient

Public Class FrmUsuarios
    Dim NivelAcesso As Integer
    Dim editarUsuario As String
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub HabilitarCampos()
        TxtNome.Enabled = True
        TxtCPF.Enabled = True
        TxtEndereco.Enabled = True
        TxtTelefone.Enabled = True
        TxtUsuario.Enabled = True
        TxtSenha.Enabled = True
        TxtEmail.Enabled = True
        RbNivel1.Enabled = True
        RbNivel2.Enabled = True
        RbNivel3.Enabled = True
    End Sub

    Private Sub DesabilitarCampos()
        TxtNome.Enabled = False
        TxtCPF.Enabled = False
        TxtEndereco.Enabled = False
        TxtTelefone.Enabled = False
        TxtUsuario.Enabled = False
        TxtSenha.Enabled = False
        TxtEmail.Enabled = False
        RbNivel1.Enabled = False
        RbNivel2.Enabled = False
        RbNivel3.Enabled = False
    End Sub
    Private Sub LimparCampos()
        TxtId.Text = ""
        TxtNome.Text = ""
        TxtCPF.Text = ""
        TxtEndereco.Text = ""
        TxtTelefone.Text = ""
        TxtUsuario.Text = ""
        TxtSenha.Text = ""
        editarUsuario = ""
        TxtEmail.Text = ""
    End Sub
    Sub Editar_Cores()
        TxtNome.BackColor = Color.Salmon
        TxtCPF.BackColor = Color.Salmon
        TxtUsuario.BackColor = Color.Salmon
        TxtSenha.BackColor = Color.Salmon
        TxtEmail.BackColor = Color.Salmon
        TxtEndereco.BackColor = Color.Salmon
    End Sub
    Sub Limpar_cores()
        TxtNome.BackColor = Color.White
        TxtCPF.BackColor = Color.White
        TxtUsuario.BackColor = Color.White
        TxtSenha.BackColor = Color.White
        TxtEmail.BackColor = Color.White
        TxtEndereco.BackColor = Color.White
    End Sub
    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM usuarios order by id desc"
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
        DataGrid.Columns(7).Visible = False

        DataGrid.Columns(0).HeaderText = "Nº Usuário"
        DataGrid.Columns(1).HeaderText = "Nome"
        DataGrid.Columns(2).HeaderText = "CPF"
        DataGrid.Columns(3).HeaderText = "Endereço"
        DataGrid.Columns(4).HeaderText = "Telefone"
        DataGrid.Columns(5).HeaderText = "Email"
        DataGrid.Columns(6).HeaderText = "Usuário"
        DataGrid.Columns(7).HeaderText = "Senha"
        DataGrid.Columns(8).HeaderText = "Nível Acesso"

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(1).Width = 150
        DataGrid.Columns(3).Width = 150
        DataGrid.Columns(5).Width = 150
        DataGrid.Columns(8).Width = 50
        DataGrid.Columns(6).Width = 90

    End Sub
    Sub DadosCabecalho()

        On Error Resume Next
        TxtId.Text = DataGrid.CurrentRow.Cells(0).Value
        TxtNome.Text = DataGrid.CurrentRow.Cells(1).Value
        TxtCPF.Text = DataGrid.CurrentRow.Cells(2).Value
        TxtEndereco.Text = DataGrid.CurrentRow.Cells(3).Value
        TxtTelefone.Text = DataGrid.CurrentRow.Cells(4).Value
        TxtEmail.Text = DataGrid.CurrentRow.Cells(5).Value
        TxtUsuario.Text = DataGrid.CurrentRow.Cells(6).Value
        TxtSenha.Text = DataGrid.CurrentRow.Cells(7).Value

        If DataGrid.CurrentRow.Cells(8).Value = 1 Then
            RbNivel1.Checked = True
        End If
        If DataGrid.CurrentRow.Cells(8).Value = 2 Then
            RbNivel2.Checked = True
        End If
        If DataGrid.CurrentRow.Cells(8).Value = 3 Then
            RbNivel3.Checked = True
        End If

    End Sub
    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick

        If e.RowIndex > -1 Then
            DadosCabecalho()
        End If

    End Sub

    Sub BuscarNome()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM usuarios where nome Like '" & TxtPesquisar.Text & "%' order by id desc"
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
        RbNivel1.Checked = True

    End Sub


    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If TxtId.Text <> "" Then

            If MsgBox("Deseja editar o usuário " & TxtId.Text & ": " & TxtNome.Text & "?", vbYesNo, "Editar Usuário") = vbYes Then

                HabilitarCampos()

                Editar_Cores()

                editarUsuario = "Editar"

            End If
        Else
            MsgBox("Selecione um usuário para editar!!", MsgBoxStyle.Information, "Editar Usuário")
        End If

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        If editarUsuario = "Editar" And TxtId.Text <> "" Then


            SalvarEdicao()

            LimparCampos()

            Listar()

            DesabilitarCampos()

            Limpar_cores()

        Else
            If TxtNome.Text <> "" And TxtCPF.Text <> "   .   .   -" And TxtUsuario.Text <> "" And TxtSenha.Text <> "" Then
                Try

                    'INSERINDO NIVEL DE ACESSO
                    If RbNivel1.Checked = True Then
                        NivelAcesso = 1
                    Else

                        If RbNivel2.Checked = True Then
                            NivelAcesso = 2
                        Else

                            If RbNivel3.Checked = True Then
                                NivelAcesso = 3
                            End If
                        End If
                    End If

                    Abrir()
                    'VERIFICAR SE O CPF  JÁ EXISTE
                    Dim cmdCPF As MySqlCommand
                    Dim readerCPF As MySqlDataReader
                    Dim sqlCPF As String

                    sqlCPF = "SELECT * FROM usuarios WHERE cpf = '" & TxtCPF.Text & "' "
                    cmdCPF = New MySqlCommand(sqlCPF, con)
                    readerCPF = cmdCPF.ExecuteReader

                    'VERIFICAR SE ALGO FOI ENCONTRADO A PARTIR DA CONSULTA
                    If readerCPF.Read = True Then
                        readerCPF.Close()
                        MsgBox("Este CPF " + TxtCPF.Text + " já está cadastrado!!", MsgBoxStyle.Information, "CPF Já Cadastrado")
                        TxtCPF.Focus()
                        Exit Sub
                    End If
                    readerCPF.Close()

                    'VERIFICAR SE O USUARIO JÁ EXISTE
                    Dim cmdUSU As MySqlCommand
                    Dim readerUSU As MySqlDataReader
                    Dim sqlUSU As String

                    sqlUSU = "SELECT * FROM usuarios WHERE usuario = '" & TxtUsuario.Text & "' "
                    cmdUSU = New MySqlCommand(sqlUSU, con)
                    readerUSU = cmdUSU.ExecuteReader

                    'VERIFICAR SE ALGO FOI ENCONTRADO A PARTIR DA CONSULTA
                    If readerUSU.Read = True Then
                        readerUSU.Close()
                        MsgBox("Este Usuário " + TxtUsuario.Text + " já está cadastrado!!", MsgBoxStyle.Information, "Usuário Já Cadastrado")
                        TxtCPF.Focus()
                        Exit Sub
                    End If
                    readerUSU.Close()

                    'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                    Dim cmd As MySqlCommand
                    Dim sqls As String

                    sqls = "INSERT INTO usuarios (nome, cpf, endereco, telefone, email, usuario, senha, nivel_acesso) VALUES ('" & TxtNome.Text & "', '" & TxtCPF.Text & "', '" & TxtEndereco.Text & "', '" & TxtTelefone.Text & "', '" & TxtEmail.Text & "', '" & TxtUsuario.Text & "', '" & TxtSenha.Text & "', '" & NivelAcesso & "')"
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
                Editar_Cores()

                MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Dados inválidos")
                TxtNome.Focus()
            End If

        End If


    End Sub
    Sub SalvarEdicao()

        Try
            If RbNivel1.Checked = True Then
                NivelAcesso = 1
            Else
                If RbNivel2.Checked = True Then
                    NivelAcesso = 2
                Else
                    If RbNivel3.Checked = True Then
                        NivelAcesso = 3
                    End If
                End If
            End If

            Abrir()

            'PROGRAMANDO EDIÇÃO DE REGISTRO NO BANCO
            Dim cmd As MySqlCommand
            Dim sql As String

            sql = "UPDATE usuarios SET nome = '" & TxtNome.Text & "', cpf = '" & TxtCPF.Text & "', endereco = '" & TxtEndereco.Text & "', telefone = '" & TxtTelefone.Text & "', email = '" & TxtEmail.Text & "', usuario = '" & TxtUsuario.Text & "', senha = '" & TxtSenha.Text & "', nivel_acesso = '" & NivelAcesso & "' where id = '" & TxtId.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

            DesabilitarCampos()

            MsgBox("Registro editado com Sucesso!!", MsgBoxStyle.Information, "Editar")

        Catch ex As Exception
            MsgBox("Erro ao editar!!" + ex.Message)
        End Try

    End Sub
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox("Deseja excluir o usuário: " & TxtNome.Text & "?", vbYesNo, "Exclusão") = vbYes Then

            Try
                Abrir()

                'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "DELETE FROM usuarios where id = '" & TxtId.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Usuário excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                Listar()

            Catch ex As Exception
                MsgBox("Erro ao excluir!!" + ex.Message)
            End Try

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

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparCampos()
    End Sub
End Class