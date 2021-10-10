Imports MySql.Data.MySqlClient

Public Class FrmRelMvtoEstoque
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
        TxtProduto.BackColor = Color.White

        If CbTipoMvto.Text <> "" And TxtQuantidade.Text <> "" And TxtCodProduto.Text <> "" Then

            If MsgBox("Deseja salvar esse ajuste manual no estoque?", vbYesNo, "Ajuste Saldo") = vbYes Then

                SalvarAjusteEstoque()


                Me.Close()
            End If

        Else
            CbTipoMvto.BackColor = Color.Salmon
            TxtQuantidade.BackColor = Color.Salmon
            TxtProduto.BackColor = Color.Salmon
            MsgBox("Campos em vazios!!", MsgBoxStyle.Information, "Salar")
        End If
    End Sub

    Sub SalvarAjusteEstoque()
        'Stop
        Try

            Abrir()

            'PESQUISAR O SALDO PARA O ITEM
            Dim saldoEstoque As Integer
            Dim cmd1 As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql1 As String
            sql1 = "SELECT * from produtos WHERE id = '" & TxtCodProduto.Text & "'"
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
            Dim novoSaldo As Integer

            QtdAjuste = TxtQuantidade.Text

            If CbTipoMvto.Text = "Entrada" Then
                novoSaldo = saldoEstoque + QtdAjuste
            Else
                If CbTipoMvto.Text = "Saída" Then
                    novoSaldo = saldoEstoque - QtdAjuste
                End If
            End If


            If novoSaldo < 0 Then

                If MsgBox("ATENÇÃO: saldo do item irá ficar negativo, confirmar ajuste?", vbYesNo, "SALDO NEGATIVO") = vbYes Then
                Else
                    Exit Sub
                End If
            End If

            Dim cmd As MySqlCommand
            Dim sql As String
            sql = "UPDATE produtos SET saldo_estoque = '" & novoSaldo & "' where id = '" & TxtCodProduto.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

            MsgBox("Registro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

        Catch ex As Exception
            MsgBox("Erro ao salvar ajuste no estoque!!" + ex.Message)
        End Try
    End Sub

    Private Sub FrmMvtoEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnPesqProduto.Focus()
    End Sub
End Class