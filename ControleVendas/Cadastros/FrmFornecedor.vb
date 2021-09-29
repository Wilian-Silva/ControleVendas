Imports MySql.Data.MySqlClient

Public Class FrmFornecedor
    Dim proximo As Integer
    Dim anterior As Integer
    Dim maximo As Integer
    Private Sub FrmFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If pesquisarFornecedor = "True" Then
            GBoxFornecedor.Visible = False
            BtnSelecionarItem.Visible = True
            BtnCacelarConsulta.Visible = True
            Listar()
        Else
            Listar()

        End If
    End Sub

    Private Sub HabilitarCampos()
        TxtNome.Enabled = True
        TxtEndereco.Enabled = True
        TxtTelefone.Enabled = True
        RbPessoaFisica.Enabled = True
        RbPessoaJuridica.Enabled = True
        TxtNomeFantasia.Enabled = True
    End Sub
    Sub HabilitarCamposEdicao()
        TxtNome.Enabled = True
        TxtEndereco.Enabled = True
        TxtTelefone.Enabled = True
        TxtNomeFantasia.Enabled = True

        TxtNome.BackColor = Color.Salmon
        TxtNomeFantasia.BackColor = Color.Salmon
        TxtEndereco.BackColor = Color.Salmon
        TxtTelefone.BackColor = Color.Salmon
    End Sub
    Private Sub DesabilitarCampos()
        TxtNome.Enabled = False
        TxtEndereco.Enabled = False
        TxtTelefone.Enabled = False
        RbPessoaFisica.Enabled = False
        RbPessoaJuridica.Enabled = False
        TxtNomeFantasia.Enabled = False
        TxtCNPJ.Enabled = False
        TxtCPF.Enabled = False
    End Sub
    Private Sub LimparCampos()
        TxtNome.Text = ""
        TxtCPF.Text = ""
        TxtEndereco.Text = ""
        TxtTelefone.Text = ""
        TxtId.Text = ""
        TxtPesquisar.Text = ""
        TxtCNPJ.Text = ""
        TxtNomeFantasia.Text = ""
        novoFonecedor = ""
        RbPessoaJuridica.Checked = False
        RbPessoaFisica.Checked = False
    End Sub
    Sub DadosCabecalho()

        On Error Resume Next
        TxtId.Text = DataGrid.CurrentRow.Cells(0).Value
        TxtNome.Text = DataGrid.CurrentRow.Cells(1).Value
        TxtNomeFantasia.Text = DataGrid.CurrentRow.Cells(2).Value
        TxtEndereco.Text = DataGrid.CurrentRow.Cells(3).Value
        TxtTelefone.Text = DataGrid.CurrentRow.Cells(4).Value


        If DataGrid.CurrentRow.Cells(5).Value = "Pessoa Jurídica" Then
            RbPessoaJuridica.Checked = True
            TxtCNPJ.Text = DataGrid.CurrentRow.Cells(6).Value
            TxtCPF.Text = ""
        Else
            If DataGrid.CurrentRow.Cells(5).Value = "Pessoa Física" Then
                RbPessoaFisica.Checked = True
                TxtCPF.Text = DataGrid.CurrentRow.Cells(6).Value
                TxtCNPJ.Text = ""
            End If

        End If

    End Sub
    Sub Editar_Cores()
        TxtNome.BackColor = Color.Salmon
        TxtNomeFantasia.BackColor = Color.Salmon
        TxtCNPJ.BackColor = Color.Salmon
        TxtCPF.BackColor = Color.Salmon
        TxtEndereco.BackColor = Color.Salmon

    End Sub
    Sub Limpar_cores()
        TxtNome.BackColor = Color.White
        TxtNomeFantasia.BackColor = Color.White
        TxtCNPJ.BackColor = Color.White
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

            sql = "SELECT * FROM fornecedor order by id desc"
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
        DataGrid.Columns(1).HeaderText = "Razão Social"
        DataGrid.Columns(2).HeaderText = "Nome Fantasia"
        DataGrid.Columns(3).HeaderText = "Endereço"
        DataGrid.Columns(4).HeaderText = "Telefone"
        DataGrid.Columns(5).HeaderText = "Tipo"
        DataGrid.Columns(6).HeaderText = "CPF/CNPJ"
        DataGrid.Columns(7).HeaderText = "Data Cadastro"


        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        DataGrid.Columns(0).Width = 40
        DataGrid.Columns(1).Width = 200
        DataGrid.Columns(2).Width = 120
        DataGrid.Columns(3).Width = 180
        DataGrid.Columns(6).Width = 120

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

            sql = "SELECT * FROM fornecedor where nome_fantasia LIKE '" & TxtPesquisar.Text & "%' order by id desc"
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
        novoFonecedor = "True"
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtId.Text <> "" Then

            If MsgBox("Deseja editar o fornecedor " & TxtId.Text & ": " & TxtNome.Text & "?", vbYesNo, "Editar") = vbYes Then

                HabilitarCamposEdicao()

                editarFornecedor = "Editar"

            End If
        Else

            MsgBox("Selecione um registro para editar!!", MsgBoxStyle.Information, "Editar")
            TxtNome.Focus()
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'Stop
        If editarFornecedor = "Editar" And TxtId.Text <> "" Then

            SalvarEdicao()

            LimparCampos()

            Listar()

            DesabilitarCampos()

            Limpar_cores()

            DadosCabecalho()

        Else

            Try
                'Stop

                If TxtNome.Text <> "" And TxtNomeFantasia.Text <> "" And TxtEndereco.Text <> "" Then

                    If TxtCPF.Text <> "   .   .   -" Or TxtCNPJ.Text <> "  .   .   /    -" Then


                        Abrir()

                        'VERIFICAR SE O CLIENTE JÁ EXISTE
                        Dim cmdUSU As MySqlCommand
                        Dim readerUSU As MySqlDataReader
                        Dim sqlUSU As String

                        sqlUSU = "SELECT * FROM fornecedor WHERE cpf_cnpj = '" & TxtCNPJ.Text & "' or cpf_cnpj = '" & TxtCPF.Text & "'"
                        cmdUSU = New MySqlCommand(sqlUSU, con)
                        readerUSU = cmdUSU.ExecuteReader
                        If readerUSU.Read = True Then
                            readerUSU.Close()
                            MsgBox("Este CFP/CNPJ " + TxtCPF.Text + "/" + TxtCNPJ.Text + " já está cadastrado!!", MsgBoxStyle.Information, "CFP/CNPJ Já Cadastrado")
                            TxtNome.Focus()
                            Exit Sub
                        Else
                            readerUSU.Close()
                        End If




                        Dim cmd As MySqlCommand
                        Dim sqls As String
                        Dim data As String
                        data = Now().ToString("yyyy-MM-dd")

                        Dim tipo As String
                        Dim codcad As String

                        tipo = ""
                        codcad = ""

                        If RbPessoaFisica.Checked = True Then
                            tipo = "Pessoa Física"
                            codcad = TxtCPF.Text
                        End If
                        If RbPessoaJuridica.Checked = True Then
                            tipo = "Pessoa Jurídica"
                            codcad = TxtCNPJ.Text
                        End If

                        sqls = "INSERT INTO fornecedor (razao_social, nome_fantasia, endereco, telefone, tipo, cpf_cnpj, data_cadastro ) VALUES ('" & TxtNome.Text & "', '" & TxtNomeFantasia.Text & "', '" & TxtEndereco.Text & "','" & TxtTelefone.Text & "', '" & tipo & "','" & codcad & "', '" & data & "')"
                        cmd = New MySqlCommand(sqls, con)
                        cmd.ExecuteNonQuery()

                        Limpar_cores()
                        LimparCampos()
                        DesabilitarCampos()
                        Listar()
                        DadosCabecalho()

                        MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                    Else
                        TxtCNPJ.BackColor = Color.Salmon
                        TxtCPF.BackColor = Color.Salmon
                        MsgBox("CNPJ/CFP vazios!!", MsgBoxStyle.Information, "Dados inválidos")

                    End If
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

            sql = "UPDATE fornecedor SET razao_social = '" & TxtNome.Text & "', nome_fantasia = '" & TxtNomeFantasia.Text & "', endereco = '" & TxtEndereco.Text & "', telefone = '" & TxtTelefone.Text & "' where id = '" & TxtId.Text & "'"
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

        sql1 = "SELECT * FROM entrada where cod_fornecedor = '" & TxtId.Text & "' "
        cmd1 = New MySqlCommand(sql1, con)
        reader = cmd1.ExecuteReader

        If reader.Read = True Then

            MsgBox("Cadastro não pode ser excluido, fornecedor já possui movimentação!!", MsgBoxStyle.Information, "Exclusão")
            reader.Close()
            Exit Sub
        Else
            reader.Close()
        End If

        If TxtId.Text <> "" Then


            If MsgBox("Deseja excluir fornecedor " & TxtId.Text & ": " & TxtNome.Text & "?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "DELETE FROM fornecedor where id = '" & TxtId.Text & "' "
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

            codFornecedor = DataGrid.CurrentRow.Cells(0).Value
            nomeFornecedor = DataGrid.CurrentRow.Cells(2).Value

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

    Private Sub RbPessoaFisica_CheckedChanged(sender As Object, e As EventArgs) Handles RbPessoaFisica.CheckedChanged

        If novoFonecedor = "True" Then
            If RbPessoaFisica.Checked = True Then
                RbPessoaJuridica.Enabled = False
                TxtCPF.Enabled = True
                TxtCNPJ.Enabled = False
            End If
        End If

    End Sub

    Private Sub RbPessoaJuridica_CheckedChanged(sender As Object, e As EventArgs) Handles RbPessoaJuridica.CheckedChanged
        If novoFonecedor = "True" Then
            If RbPessoaJuridica.Checked = True Then
                TxtCPF.Enabled = False
                RbPessoaFisica.Enabled = False
                TxtCNPJ.Enabled = True
            End If
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

                sql = "SELECT id FROM fornecedor WHERE id=(SELECT MAX(id) FROM fornecedor) "
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

            sqlp = "SELECT * FROM fornecedor WHERE id = '" & proximo & "' "
            cmd = New MySqlCommand(sqlp, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                ProximoRegistro()

                Exit Sub
            Else
                reader.Close()
                proximo += 1
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
            sql = "SELECT * FROM fornecedor WHERE id = '" & proximo & "' "
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

            sqlp = "SELECT * FROM fornecedor WHERE id = '" & anterior & "' "
            cmd = New MySqlCommand(sqlp, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                RegistroAnterior()

                Exit Sub
            Else
                reader.Close()
                anterior -= 1
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
            sql = "SELECT * FROM fornecedor WHERE id = '" & anterior & "' "
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