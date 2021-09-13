Imports MySql.Data.MySqlClient

Public Class FrmVendaCabecalho
    Sub Listar()
        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim data1 As String
            Dim data2 As String
            data1 = DataInicial.Value.ToString("yyyy-MM-dd")
            data2 = DataFinal.Value.ToString("yyyy-MM-dd")
            sql = "SELECT v.id_venda, v.data_venda, v.cliente, p.produto, p.quantidade, p.valor_unitario, v.valor_total, v.vencimento, v.valor_recebido, v.saldo_venda FROM venda_cabecalho as v INNER JOIN venda As p On v.id_venda = p.id_venda WHERE v.data_venda >= '" & data1 & "' AND v.data_venda <= '" & data2 & "'order by v.id_venda desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
    Sub ListarTudo()
        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()
            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            sql = "SELECT v.id_venda, v.data_venda, v.cliente, p.produto, p.quantidade, p.valor_unitario, v.valor_total, v.vencimento, v.valor_recebido, v.saldo_venda FROM venda_cabecalho as v INNER JOIN venda As p On v.id_venda = p.id_venda order by v.id_venda desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()
        'DataGrid.Columns(0).Visible = False

        DataGrid.Columns(0).HeaderText = "Nº Venda"
        DataGrid.Columns(1).HeaderText = "Data Venda"
        DataGrid.Columns(2).HeaderText = "Cliente"
        DataGrid.Columns(3).HeaderText = "Produto"
        DataGrid.Columns(4).HeaderText = "Qtd"
        DataGrid.Columns(5).HeaderText = "Vlr. Unit."
        DataGrid.Columns(6).HeaderText = "Total Venda"
        DataGrid.Columns(7).HeaderText = "Vencimento"
        DataGrid.Columns(8).HeaderText = "Total Recebido"
        DataGrid.Columns(9).HeaderText = "Saldo Venda"

        DataGrid.Columns(0).Width = 60
        DataGrid.Columns(2).Width = 120
        DataGrid.Columns(3).Width = 180
        DataGrid.Columns(4).Width = 60
        DataGrid.Columns(8).Width = 110

        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(5).DefaultCellStyle.Format = "c"
        DataGrid.Columns(6).DefaultCellStyle.Format = "c"
        DataGrid.Columns(8).DefaultCellStyle.Format = "c"
        DataGrid.Columns(9).DefaultCellStyle.Format = "c"

    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        Listar()
        FormatarGrid()
    End Sub

    Private Sub BtnListarTudo_Click(sender As Object, e As EventArgs) Handles BtnListarTudo.Click
        ListarTudo()
        FormatarGrid()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmVendaCabecalho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If statusBtn = "Visible" Then
            BtnExcluir.Visible = True
            TxtIdVenda.Visible = True
            LblIdPedido.Visible = True
        End If

    End Sub

    Private Sub FrmVendaCabecalho_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        BtnExcluir.Visible = False
        TxtIdVenda.Visible = False
        LblIdPedido.Visible = False
        statusBtn = ""
    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick

        If e.RowIndex > -1 Then
            On Error Resume Next
            TxtIdVenda.Text = DataGrid.CurrentRow.Cells(0).Value
        End If

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        If TxtIdVenda.Text <> "" Then

            'PESQUISAR SE A NOTA JA NÃO FOI PAGA
            Dim cmd1 As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql1 As String

            sql1 = "SELECT * FROM mvto_recebimentos where id_nota = '" & TxtIdVenda.Text & "' "
            cmd1 = New MySqlCommand(sql1, con)
            reader = cmd1.ExecuteReader

            If reader.Read = True Then

                MsgBox("Documento não pode ser excluido, já foi recebido!!", MsgBoxStyle.Information, "Excluir Documento")
                reader.Close()
                Exit Sub
            Else
                reader.Close()
            End If


            'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO VENDA_CABEÇALHO
            If MsgBox("Deseja excluir registro?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "DELETE FROM venda_cabecalho where id_venda = '" & TxtIdVenda.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    AtualizarExclusaoEstoque()

                    AtualizarExclusaoVenda()


                    MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                    TxtIdVenda.Text = ""

                Catch ex As Exception
                    MsgBox("Erro ao excluir!!" + ex.Message)
                End Try

            End If
        Else
            MsgBox("Selecione um registro para excluir!!", MsgBoxStyle.Information, "Registro Vazio")
        End If


    End Sub

    Sub AtualizarExclusaoEstoque()
        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            sql = "DELETE FROM estoque where id_venda = '" & TxtIdVenda.Text & "' "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao excluir!!" + ex.Message)
        End Try
    End Sub
    Sub AtualizarExclusaoVenda()
        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            sql = "DELETE FROM venda where id_venda = '" & TxtIdVenda.Text & "' "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao excluir!!" + ex.Message)
        End Try
    End Sub

    Private Sub DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellDoubleClick

        If e.RowIndex > -1 Then
            If statusBtn = "" Then
                On Error Resume Next
                numeroNota = DataGrid.CurrentRow.Cells(1).Value
                idNota = DataGrid.CurrentRow.Cells(0).Value
                Me.Close()
            End If

        End If

    End Sub
End Class