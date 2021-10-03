Imports MySql.Data.MySqlClient

Public Class FrmMvtoEstoque
    Private Sub BtnPesqProduto_Click(sender As Object, e As EventArgs) Handles BtnPesqProduto.Click
        pesquisarProduto = "True"
        Dim form = New FrmProdutos
        form.ShowDialog()
    End Sub

    Private Sub FrmMvtoEstoque_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If pesquisarProduto = "True" Then
                TxtCodProduto.Text = codProduto
                TxtProduto.Text = nomeProduto

                pesquisarProduto = ""
            End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        CbTipoMvto.BackColor = Color.White
        TxtQuantidade.BackColor = Color.White
        If CbTipoMvto.Text <> "" And TxtQuantidade.Text <> "'" Then

            If MsgBox("Deseja salvar esse ajuste manual no estoque?", vbYesNo, "Ajuste Saldo") = vbYes Then

                SalvarEdicao()

                MsgBox("Registro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")
                Me.Close()
            End If

        Else
            CbTipoMvto.BackColor = Color.Salmon
        TxtQuantidade.BackColor = Color.Salmon
        MsgBox("Campos em vazios!!", MsgBoxStyle.Information, "Salar")
        End If
    End Sub

    Sub SalvarEdicao()
        Try

            Abrir()

            'PESQUISAR O SALDO PARA O ITEM
            Dim saldoEstoque As Integer
            Dim cmd1 As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql1 As String
            sql1 = "SELECT * from produtos WHERE where id = '" & TxtCodProduto.Text & "'"
            cmd1 = New MySqlCommand(sql1, con)
            reader = cmd1.ExecuteReader
            If reader.Read = True Then
                saldoEstoque = reader("saldo_estoque")
                reader.Close()
            Else
                reader.Close()
            End If

            'QUANTIDADE A SER AJUSTADA
            Dim QtdAjuste As Integer
            If CbTipoMvto.Text = "Entrada" Then
                QtdAjuste = TxtQuantidade.Text
                If CbTipoMvto.Text = "Saída" Then
                    QtdAjuste = -TxtQuantidade.Text
                End If
            End If

            Dim novoSaldo As Integer
            novoSaldo = saldoEstoque + QtdAjuste

            Dim cmd As MySqlCommand
            Dim sql As String
            sql = "UPDATE produtos SET saldo_estoque = '" & novoSaldo & "' where id = '" & TxtCodProduto.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao salvar ajuste no estoque!!" + ex.Message)
        End Try
    End Sub
End Class