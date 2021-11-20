Imports MySql.Data.MySqlClient

Public Class FrmVlrReceb
    Dim IdMvtoReceb As Integer
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub TxtValorPago_TextChanged(sender As Object, e As EventArgs) Handles TxtValorPago.TextChanged

        SomarValores()

    End Sub
    Sub SomarValores()

        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Dim dbl3 As Double = 0
        Double.TryParse(TxtSaldoAbertoParcela.Text, dbl1)
        Double.TryParse(TxtValorPago.Text, dbl2)
        Double.TryParse(TxtCompAdto.Text, dbl3)

        TxtSaldoTitulo.Text = (dbl1 - dbl2 - dbl3).ToString("n")

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

        Dim dbl1 As Double = 0
        Double.TryParse(TxtSaldoTitulo.Text, dbl1)


        If dbl1 < 0 Then


            If MsgBox("Valor recebido esta maior que o valor da parcela, deseja criar um adiantamento?", vbYesNo, "Valor Recebido a maior") = vbYes Then

                TxtAdto.text = TxtSaldoTitulo.Text
                TxtSaldoTitulo.Text = 0
                TxtStatusTitulo.Text = "Pgto. Total"
            Else
                Exit Sub
            End If

        End If


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
                Dim CompAdto As String
                data1 = DataEmissao.Value.ToString("yyyy-MM-dd")
                data2 = DataVencimento.Value.ToString("yyyy-MM-dd")
                data3 = DataPgto.Value.ToString("yyyy-MM-dd")

                CompAdto = CDbl(TxtCompAdto.Text) + CDbl(TxtAdto.Text)

                sql = "INSERT INTO mvto_recebimentos (id_duplicata, cod_cliente, cliente, id_venda, valor_total, parcela, " _
                & "valor_parcela, valor_pago, valor_saldo, juros_multa, descontos, total_pago, data_emissao," _
                & "data_vencimento, data_pagamento, status_nota, portador, id_portador, adto, id_nfe, nfe) VALUES ( '" & TxtIdDuplicata.Text & "','" & TxtCodCliente.Text & "', " _
                & " '" & TxtNomeCliente.Text & "','" & TxtNotaFiscal.Text & "','" & TxtValorOriginal.Text.Replace(",", ".") & "', " _
                & "  '" & TxtParcela.Text & "','" & TxtValorParcela.Text.Replace(",", ".") & "', '" & TxtValorPago.Text.Replace(",", ".") & "', " _
                & " '" & TxtSaldoTitulo.Text.Replace(",", ".") & "','" & TxtMultasJuros.Text.Replace(",", ".") & "', '" & TxtDescontos.Text.Replace(",", ".") & "', " _
                & " '" & TxtTotalPago.Text.Replace(",", ".") & "', '" & data1 & "', '" & data2 & "',  '" & data3 & "', '" & TxtStatusTitulo.Text & "', '" & CbPortador.Text & "', '" & TxtIdportador.Text & "', '" & CompAdto.Replace(",", ".") & "', '" & TxtIdNfeEntrada.Text & "', '" & TxtNfeEntrada.Text & "') "


                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                'ATUALIZAR SALDO NA TABELA DUPLICATAS
                Dim cmd1 As MySqlCommand
                Dim sql1 As String
                sql1 = "UPDATE duplicatas_receber SET saldo_duplicata = '" & TxtSaldoTitulo.Text.Replace(",", ".") & "' WHERE id = '" & TxtIdDuplicata.Text & "' "
                cmd1 = New MySqlCommand(sql1, con)
                cmd1.ExecuteNonQuery()

                Consultar_Id_mvto_recebimentos()

                Salvar_mvto_portador()


                If TxtAdto.Text < 0 Or TxtCompAdto.Text > 0 Then
                    Salvar_adto()
                End If

                MsgBox("Registro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar Pagamento")

                Me.Close()

            Catch ex As Exception
                MsgBox("Erro ao editar!!" + ex.Message)
            End Try

        End If
    End Sub

    Sub Consultar_Id_mvto_recebimentos()

        Try
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            sql3 = "Select MAX(id) as id FROM mvto_recebimentos "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            reader3.Read()
            If Not IsDBNull(reader3("id")) Then

                IdMvtoReceb = reader3("id")
                reader3.Close()

            Else
                reader3.Close()

            End If
        Catch ex As Exception
            MsgBox("Erro ao Consultar_Id_mvto_recebimentos!!" + ex.Message)
        End Try


    End Sub
    Sub Salvar_adto()
        Try

            Dim cmd As MySqlCommand
            Dim sql As String
            Dim data3 As String
            data3 = DataPgto.Value.ToString("yyyy-MM-dd")

            sql = "INSERT INTO tbl_adto ( id_duplicata, cod_cliente, id_venda, data_pagamento, id_portador, valor_adto, valor_comp_adto, id_mvto_recebimentos) " _
            & " VALUES ( '" & TxtIdDuplicata.Text & "','" & TxtCodCliente.Text & "' ,'" & TxtNotaFiscal.Text & "' ,'" & data3 & "', '" & TxtIdportador.Text & "', '" & TxtAdto.Text.Replace(",", ".") & "','" & TxtCompAdto.Text.Replace(",", ".") & "', '" & IdMvtoReceb & "' )"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao Salvar_adto!!" + ex.Message)
        End Try


    End Sub
    Sub Salvar_mvto_portador()

        Try
            Abrir()

            'ATUALIZAR MVTO PORTADOR
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            Dim tipoMov As String
            Dim data3 As String

            data3 = DataPgto.Value.ToString("yyyy-MM-dd")
            tipoMov = "Entrada"

            sql1 = "INSERT INTO mvto_portador (id_portador, nome, tipo, data, valor, id_duplicata, pagador_recebedor, id_mvto_recebimentos) VALUES ( '" & TxtIdportador.Text & "','" & CbPortador.Text & "','" & tipoMov & "', '" & data3 & "','" & TxtTotalPago.Text.Replace(",", ".") & "','" & TxtIdDuplicata.Text & "', '" & TxtNomeCliente.Text & "', '" & IdMvtoReceb & "'  )"
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao salvar mvto portador!!" + ex.Message)
        End Try
    End Sub



    Private Sub TxtValorPago_Enter(sender As Object, e As EventArgs) Handles TxtValorPago.Enter
        CorTxtBox(TxtValorPago, "Am")
    End Sub

    Private Sub TxtValorPago_Leave(sender As Object, e As EventArgs) Handles TxtValorPago.Leave
        CorTxtBox(TxtValorPago, "Br")
    End Sub

    Private Sub TxtMultasJuros_Enter(sender As Object, e As EventArgs) Handles TxtMultasJuros.Enter
        CorTxtBox(TxtMultasJuros, "Am")
    End Sub

    Private Sub TxtMultasJuros_Leave(sender As Object, e As EventArgs) Handles TxtMultasJuros.Leave
        CorTxtBox(TxtMultasJuros, "Br")
    End Sub

    Private Sub TxtDescontos_Enter(sender As Object, e As EventArgs) Handles TxtDescontos.Enter
        CorTxtBox(TxtDescontos, "Am")
    End Sub

    Private Sub TxtDescontos_Leave(sender As Object, e As EventArgs) Handles TxtDescontos.Leave
        CorTxtBox(TxtDescontos, "Br")
    End Sub

    Private Sub CbPortador_Enter(sender As Object, e As EventArgs)
        CorTxtBox(CbPortador, "Am")
    End Sub

    Private Sub CbPortador_Leave(sender As Object, e As EventArgs)
        CorTxtBox(CbPortador, "Br")
    End Sub

    Private Sub BtnPortador_Click(sender As Object, e As EventArgs) Handles BtnPortador.Click

        PesquisarPortador = "True"
        Dim frm As New FrmPortador
        frm.ShowDialog()
    End Sub

    Private Sub FrmVlrReceb_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If PesquisarPortador = "True" Then
            TxtIdportador.Text = IdPortador
            CbPortador.Text = CodPortador
        End If
    End Sub
End Class