Imports MySql.Data.MySqlClient

Public Class FrmVlrReceb

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub TxtValorPago_TextChanged(sender As Object, e As EventArgs) Handles TxtValorPago.TextChanged

        SomarValores()

    End Sub
    Sub SomarValores()

        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Double.TryParse(TxtSaldoAbertoParcela.Text, dbl1)
        Double.TryParse(TxtValorPago.Text, dbl2)

        TxtSaldoTitulo.Text = (dbl1 - dbl2).ToString("n")

        Dim dbl4 As Double = 0
        Dim dbl5 As Double = 0
        Dim dbl6 As Double = 0
        Double.TryParse(TxtValorPago.Text, dbl4)
        Double.TryParse(TxtMultasJuros.Text, dbl5)
        Double.TryParse(TxtDescontos.Text, dbl6)

        TxtTotalPago.Text = (dbl4 + dbl5 - dbl6).ToString("n")

        If TxtSaldoTitulo.Text <> "0,00" Then
            TxtStatusTitulo.Text = "Pgto. Parcial"
        Else
            TxtStatusTitulo.Text = "Pgto. Total"
        End If

    End Sub

    Private Sub TxtMultasJuros_TextChanged(sender As Object, e As EventArgs) Handles TxtMultasJuros.TextChanged
        SomarValores()
    End Sub

    Private Sub TxtDescontos_TextChanged(sender As Object, e As EventArgs) Handles TxtDescontos.TextChanged
        SomarValores()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If CbPortador.Text = "" Then
            MsgBox("Portador inválido!!", MsgBoxStyle.Information, "Portador")
            Exit Sub
        End If

        If MsgBox("Deseja salvar a baixa do título " & TxtNotaFiscal.Text & " Parcela " & TxtParcela.Text & "?", vbYesNo, "Salvar Baixa") = vbYes Then



            Try

                Abrir()
                'PROGRAMANDO EDIÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String
                Dim data1 As String
                Dim data2 As String
                Dim data3 As String
                data1 = DataEmissao.Value.ToString("yyyy-MM-dd")
                data2 = DataVencimento.Value.ToString("yyyy-MM-dd")
                data3 = DataPgto.Value.ToString("yyyy-MM-dd")

                sql = "INSERT INTO mvto_recebimentos (id_duplicata, cod_cliente, cliente, id_venda, valor_total, parcela, " _
                & "valor_parcela, valor_pago, valor_saldo, juros_multa, descontos, total_pago, data_emissao," _
                & "data_vencimento, data_pagamento, status_nota, portador) VALUES ( '" & TxtIdDuplicata.Text & "','" & TxtCodCliente.Text & "', " _
                & " '" & TxtNomeCliente.Text & "','" & TxtNotaFiscal.Text & "','" & TxtValorOriginal.Text.Replace(",", ".") & "', " _
                & "  '" & TxtParcela.Text & "','" & TxtValorParcela.Text.Replace(",", ".") & "', '" & TxtValorPago.Text.Replace(",", ".") & "', " _
                & " '" & TxtSaldoTitulo.Text.Replace(",", ".") & "','" & TxtMultasJuros.Text.Replace(",", ".") & "', '" & TxtDescontos.Text.Replace(",", ".") & "', " _
                & " '" & TxtTotalPago.Text.Replace(",", ".") & "', '" & data1 & "', '" & data2 & "',  '" & data3 & "', '" & TxtStatusTitulo.Text & "', '" & CbPortador.Text & "') "


                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                'ATUALIZAR SALDO NA TABELA DUPLICATAS
                Dim cmd1 As MySqlCommand
                Dim sql1 As String
                sql1 = "UPDATE duplicatas_receber SET saldo_duplicata = '" & TxtSaldoTitulo.Text & "' WHERE id = '" & TxtIdDuplicata.Text & "' "
                cmd1 = New MySqlCommand(sql1, con)
                cmd1.ExecuteNonQuery()

                MsgBox("Registro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar Pagamento")

                Me.Close()

            Catch ex As Exception
                MsgBox("Erro ao editar!!" + ex.Message)
            End Try



        End If
    End Sub


End Class