
Imports MySql.Data.MySqlClient

Public Class FrmInventario
    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Listar()
        If TxtCodInventario.Text <> "" Then

            'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
            Try
                Abrir()

                Dim sql As String
                Dim dt As New DataTable
                Dim da As MySqlDataAdapter

                sql = "Select * FROM tbl_inventario  WHERE id_inventario = '" & TxtCodInventario.Text & "' order by descricao_produto asc"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)
                DataGrid.DataSource = dt

                FormatarGrid()

            Catch ex As Exception
                MsgBox("Erro ao Listar dados no grid!! ---- " + ex.Message)
            End Try


        Else
            MsgBox("Selecione uma lista para carregar!", MsgBoxStyle.Information, "Inventário")
            Exit Sub
        End If



    End Sub

    Private Sub FormatarGrid()

        DataGrid.Columns(0).Visible = False
        DataGrid.Columns(1).Visible = False
        DataGrid.Columns(2).Visible = False
        DataGrid.Columns(3).Visible = False

        DataGrid.Columns(4).HeaderText = "Cod. Produto"
        DataGrid.Columns(5).HeaderText = "Produto"
        DataGrid.Columns(6).HeaderText = "Custo Unitario"
        DataGrid.Columns(7).HeaderText = "Saldo Estoque"
        DataGrid.Columns(8).HeaderText = "Contagem"
        DataGrid.Columns(9).HeaderText = "Variacao"

        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(8).DefaultCellStyle.ForeColor = Color.Salmon
        DataGrid.Columns(8).DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)

        DataGrid.Columns(4).ReadOnly = True
        DataGrid.Columns(5).ReadOnly = True
        DataGrid.Columns(6).ReadOnly = True
        DataGrid.Columns(7).ReadOnly = True
        DataGrid.Columns(9).ReadOnly = True

    End Sub

    Sub Validar_contagem()
        Dim saldo As Integer
        Dim saldoEstoque As Integer
        Dim contagem As Integer
        For i = 0 To DataGrid.Rows.Count - 1

            saldoEstoque = Convert.ToDouble(DataGrid.Rows(i).Cells(7).Value)

            contagem = Convert.ToDouble(DataGrid.Rows(i).Cells(8).Value)

            saldo = contagem - saldoEstoque

            DataGrid.Rows(i).Cells(9).Value = saldo

            If saldo > 0 Then
                DataGrid.Rows(i).Cells(9).Style.ForeColor = Color.White
                DataGrid.Rows(i).Cells(9).Style.BackColor = Color.FromArgb(0, 101, 250)
                DataGrid.Rows(i).Cells(9).Style.Font = New Font("Arial", 10, FontStyle.Bold)
            End If

            If saldo < 0 Then
                DataGrid.Rows(i).Cells(9).Style.ForeColor = Color.White
                DataGrid.Rows(i).Cells(9).Style.BackColor = Color.FromArgb(250, 0, 0)
                DataGrid.Rows(i).Cells(9).Style.Font = New Font("Arial", 10, FontStyle.Bold)
            End If
            If saldo = 0 Then
                DataGrid.Rows(i).Cells(9).Style.ForeColor = Color.White
                DataGrid.Rows(i).Cells(9).Style.BackColor = Color.FromArgb(51, 203, 51)
                DataGrid.Rows(i).Cells(9).Style.Font = New Font("Arial", 10, FontStyle.Bold)
            End If
        Next
    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        GerarIdRegistro()

        TxtDescricao.Text = "Inventário Nº: " & TxtCodInventario.Text & " - Data: " & DataInventario.Text

        Copiar_Produtos()
        Listar()

    End Sub
    Sub GerarIdRegistro()
        'Stop
        Try
            Abrir()

            'VERIFICAR ULTIMO ID NO BANCO E GERAR PROXIMO
            Dim cmd As MySqlCommand
            Dim sql As String
            Dim reader As MySqlDataReader

            sql = "SELECT MAX(id_inventario) AS id_inventario FROM tbl_inventario "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            reader.Read()
            If Not IsDBNull(reader("id_inventario")) Then
                TxtCodInventario.Text = reader("id_inventario") + 1
                reader.Close()
            Else

                reader.Close()
                TxtCodInventario.Text = 1
            End If

        Catch ex As Exception
            MsgBox("Erro GerarIdRegistro! " + ex.Message)
        End Try
    End Sub

    Sub Copiar_Produtos()
        Dim dt As New DataTable
        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String

            Dim da As MySqlDataAdapter
            sql = "Select id, nome, preco_compra, saldo_estoque FROM produtos "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridCopy.DataSource = dt

            'Stop
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            Dim data1 As String
            Dim vazio As Integer = 0
            data1 = DataInventario.Value.ToString("yyyy-MM-dd")

            For i = 0 To DataGridCopy.Rows.Count - 1
                sql1 = "INSERT INTO tbl_inventario (id_inventario, data_inventario, descricao, id_produto, descricao_produto, custo_unitario, qtd_estoque) " _
                    & " VALUES ('" & TxtCodInventario.Text & "', '" & data1 & "', '" & TxtDescricao.Text & "', @id_produto , @descricao_produto , @custo_unitario, @qtd_estoque)"
                cmd1 = New MySqlCommand(sql1, con)

                With cmd1
                    .Parameters.AddWithValue("@id_produto", CInt(DataGridCopy.Rows(i).Cells(0).Value.ToString))
                    .Parameters.AddWithValue("@descricao_produto", DataGridCopy.Rows(i).Cells(1).Value.ToString)
                    .Parameters.AddWithValue("@custo_unitario", CDbl(DataGridCopy.Rows(i).Cells(2).Value.ToString))
                    .Parameters.AddWithValue("@qtd_estoque", CInt(DataGridCopy.Rows(i).Cells(3).Value.ToString))

                    cmd1.ExecuteNonQuery()
                End With

            Next

            'limpando dagrid de passagem
            DataGridCopy.DataSource = Nothing
        Catch ex As Exception
            MsgBox("Erro ao Copiar_Produtos-- " + ex.Message)
        End Try

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Validar_contagem()
    End Sub



    Private Sub FrmInventario_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If pesqListaInvetario = "True" Then
            TxtCodInventario.Text = listaInvet
            TxtDescricao.Text = nomeLista
            DataInventario.Text = dataInvent
            Listar()
            pesqListaInvetario = ""
        End If

    End Sub

    Private Sub BtnExcluirLista_Click(sender As Object, e As EventArgs) Handles BtnExcluirLista.Click

        If MsgBox("Deseja excluir lista " & TxtDescricao.Text & "?", vbYesNo, "Exclusão") = vbYes Then

            Try
                Abrir()

                'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "DELETE FROM tbl_inventario where id_inventario = '" & TxtCodInventario.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                Limpar()
                MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

            Catch ex As Exception
                MsgBox("Erro ao excluir!!" + ex.Message)
            End Try
        End If
    End Sub

    Sub Limpar()
        TxtCodInventario.Text = ""
        TxtDescricao.Text = ""
        DataGrid.DataSource = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pesqListaInvetario = "True"

        Dim frm As New FrmListasInventario
        frm.ShowDialog()
    End Sub

    Private Sub BtnAtualizarestqoue_Click(sender As Object, e As EventArgs) Handles BtnAtualizarestqoue.Click

        If MsgBox("ATENÇÃO: essa rotina irá atualizar os saldos dos itens com a contagem realizada, deseja continuar?", vbYesNo, "Atualizar estoque") = vbYes Then
            'Stop
            Try
                Abrir()


                Dim cmd1 As MySqlCommand
                Dim sql1 As String
                Dim produto As Integer

                For i = 0 To DataGrid.Rows.Count - 1
                    produto = DataGrid.Rows(i).Cells(4).Value

                    sql1 = " UPDATE PRODUTOS SET saldo_estoque = @saldo_estoque WHERE id = '" & produto & "' "
                    cmd1 = New MySqlCommand(sql1, con)

                    With cmd1
                        .Parameters.AddWithValue("@saldo_estoque", CInt(DataGrid.Rows(i).Cells(8).Value.ToString))
                        cmd1.ExecuteNonQuery()
                    End With

                Next
                MsgBox("Estoque atualizado com Sucesso!!", MsgBoxStyle.Information, "Inventário")

            Catch ex As Exception
                MsgBox("Erro ao atualizar!!" + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Btnconferncia_Click(sender As Object, e As EventArgs) Handles Btnconferncia.Click
        Try
            'Stop
            Abrir()
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql1 As String
            Dim produto As Integer

            For i = 0 To DataGrid.Rows.Count - 1
                produto = DataGrid.Rows(i).Cells(4).Value

                sql1 = "SELECT saldo_estoque from produtos WHERE id = '" & produto & "' "
                cmd = New MySqlCommand(sql1, con)
                reader = cmd.ExecuteReader
                reader.Read()

                If Not IsDBNull(reader("saldo_estoque")) Then
                    DataGrid.Rows(i).Cells(7).Value = reader("saldo_estoque")
                    reader.Close()
                Else
                    reader.Close()

                End If

            Next

            Validar_contagem()
            MsgBox("Conferencia realizada atualizado com Sucesso!!", MsgBoxStyle.Information, "Inventário")

        Catch ex As Exception
            MsgBox("Erro ao atualizar!!" + ex.Message)
        End Try
    End Sub

    Private Sub BtnSalvarContagem_Click(sender As Object, e As EventArgs) Handles BtnSalvarContagem.Click

        If MsgBox("Deseja salvar lista?", vbYesNo, "Lista Inventário") = vbYes Then
            Try
                Abrir()

                Dim cmd1 As MySqlCommand
                Dim sql1 As String
                Dim produto As Integer

                For i = 0 To DataGrid.Rows.Count - 1
                    produto = DataGrid.Rows(i).Cells(0).Value

                    sql1 = "UPDATE tbl_inventario SET contagem = @contagem WHERE id = '" & produto & "' "
                    cmd1 = New MySqlCommand(sql1, con)

                    With cmd1
                        .Parameters.AddWithValue("@contagem", CInt(DataGrid.Rows(i).Cells(8).Value.ToString))
                        cmd1.ExecuteNonQuery()
                    End With

                Next
                Limpar()
                MsgBox("Lista salva com com Sucesso!!", MsgBoxStyle.Information, "Lista Inventário")

            Catch ex As Exception
                MsgBox("Erro ao salvar lista!!" + ex.Message)
            End Try
        End If

    End Sub
End Class