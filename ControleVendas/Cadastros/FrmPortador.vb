Imports MySql.Data.MySqlClient

Public Class FrmPortador
    Dim editarCliente As String

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BtnSelecionarItem.Visible = False

        If PesquisarPortador = "True" Then
            BtnSelecionarItem.Visible = True
        End If

        Listar()

    End Sub

    Private Sub HabilitarCampos()
        TxtNome.Enabled = True
        TxtCodPortador.Enabled = True

    End Sub

    Private Sub DesabilitarCampos()
        TxtNome.Enabled = False
        TxtCodPortador.Enabled = False
    End Sub
    Private Sub LimparCampos()
        TxtNome.Text = ""
        TxtId.Text = ""
        TxtCodPortador.Text = ""
        editarCliente = ""
        IdPortador = ""
    End Sub
    Sub DadosCabecalho()

        On Error Resume Next
        TxtId.Text = DataGrid.CurrentRow.Cells(0).Value
        TxtCodPortador.Text = DataGrid.CurrentRow.Cells(1).Value
        TxtNome.Text = DataGrid.CurrentRow.Cells(2).Value


    End Sub
    Sub Editar_Cores()
        TxtNome.BackColor = Color.Salmon
        TxtCodPortador.BackColor = Color.Salmon

    End Sub
    Sub Limpar_cores()
        TxtNome.BackColor = Color.White
        TxtCodPortador.BackColor = Color.White
    End Sub
    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM portador order by id asc"
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
        DataGrid.Columns(0).HeaderText = "Cód. Portador"
        DataGrid.Columns(1).HeaderText = "Nome"
        DataGrid.Columns(2).HeaderText = "Descrição"

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).Width = 70
        DataGrid.Columns(1).Width = 150
        DataGrid.Columns(2).Width = 219


    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick

        If e.RowIndex > -1 Then

            DadosCabecalho()

        End If

    End Sub
    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click

        HabilitarCampos()
        LimparCampos()
        TxtCodPortador.Focus()

    End Sub


    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        If editarCliente = "Editar" And TxtCodPortador.Text <> "" Then

            SalvarEdicao()

            LimparCampos()

            Listar()

            DesabilitarCampos()

            Limpar_cores()

            DadosCabecalho()

        Else

            Try
                Abrir()
                Limpar_cores()
                If TxtNome.Text <> "" And TxtCodPortador.Text <> "" Then
                    'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO

                    Dim cmd As MySqlCommand
                    Dim sqls As String

                    Dim data As String
                    data = Now().ToString("yyyy-MM-dd")

                    sqls = "INSERT INTO portador (nome, descricao) VALUES ('" & TxtCodPortador.Text & "', '" & TxtNome.Text & "')"
                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    Listar()

                    DesabilitarCampos()

                    DadosCabecalho()

                    MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")


                Else
                    Editar_Cores()

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

            sql = "UPDATE portador SET nome = '" & TxtCodPortador.Text & "', descricao = '" & TxtNome.Text & "' where id = '" & TxtId.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

            DesabilitarCampos()

            MsgBox("Registro editado com Sucesso!!", MsgBoxStyle.Information, "Editar")

        Catch ex As Exception
            MsgBox("Erro ao editar!!" + ex.Message)
        End Try
    End Sub
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click



        Abrir()

        Dim cmd1 As MySqlCommand
        Dim reader As MySqlDataReader
        Dim sql1 As String

        sql1 = "SELECT * FROM mvto_pagamentos where portador = '" & TxtCodPortador.Text & "' "
        cmd1 = New MySqlCommand(sql1, con)
        reader = cmd1.ExecuteReader

        If reader.Read = True Then

            MsgBox("Cadastro não pode ser excluido, portador já possui movimentação!!", MsgBoxStyle.Information, "Exclusão")
            reader.Close()
            Exit Sub
        Else
            reader.Close()
        End If



        Dim cmd2 As MySqlCommand
        Dim reader2 As MySqlDataReader
        Dim sql2 As String

        sql2 = "SELECT * FROM mvto_recebimentos where portador = '" & TxtCodPortador.Text & "' "
        cmd2 = New MySqlCommand(sql2, con)
        reader2 = cmd2.ExecuteReader

        If reader2.Read = True Then
            MsgBox("Cadastro não pode ser excluido, portador já possui movimentação!!", MsgBoxStyle.Information, "Exclusão")
            reader2.Close()
            Exit Sub
        Else
            reader2.Close()
        End If




        If TxtCodPortador.Text <> "" Then


            If MsgBox("Deseja excluir cadastro " & TxtCodPortador.Text & ": " & TxtNome.Text & "?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "DELETE FROM portador where id = '" & TxtId.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                    LimparCampos()

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
        LimparCampos()
        Me.Close()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimparCampos()
        DesabilitarCampos()
        Listar()
        Limpar_cores()
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

    Private Sub BtnSelecionarItem_Click(sender As Object, e As EventArgs) Handles BtnSelecionarItem.Click
        IdPortador = TxtId.Text
        Me.Close()
    End Sub
End Class