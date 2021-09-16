Imports MySql.Data.MySqlClient

Public Class FrmPagarTitulo
    Dim proximo As Integer
    Dim anterior As Integer
    Dim maximo As Integer
    Private Sub BtnBaixarTitulo_Click(sender As Object, e As EventArgs) Handles BtnBaixarTitulo.Click

        If MsgBox("Deseja baixar do título " & TxtNotaFiscal.Text & " Parcela " & TxtParcela.Text & "?", vbYesNo, "Pagamento") = vbYes Then

            Dim form = New FrmVlrPgto()

            form.TxtIdRegistro.Text = TxtIdRegistro.Text
            form.TxtNotaFiscal.Text = TxtNotaFiscal.Text
            form.TxtParcela.Text = TxtParcela.Text
            form.TxtCodFornecedor.Text = TxtCodFornecedor.Text
            form.TxtNomeFornecedor.Text = TxtNomeFornecedor.Text
            form.TxtCodPedido.Text = TxtCodPedido.Text
            form.TxtDescPed.Text = TxtDescPed.Text
            form.DataEmissao.Text = DataEmissao.Text
            form.DataVencimento.Text = DataVencimento.Text
            form.TxtValorOriginal.Text = TxtValorOriginal.Text
            form.TxtSaldoAberto.Text = TxtSaldoTitulo.Text
            form.TxtRegPagamento.Text = TxtRegPagamento.Text


            form.ShowDialog()
        End If

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmPagarTitulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDadosTitulo()

    End Sub

    Private Sub CarregarDadosTitulo()
        Dim idEntrada As Integer
        Try
            Abrir()

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT * FROM duplicatas WHERE id_entrada=(SELECT MAX(id_entrada) FROM duplicatas) "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                TxtIdRegistro.Text = reader(7)
                TxtCodFornecedor.Text = reader(8)
                TxtNotaFiscal.Text = reader(2)
                TxtParcela.Text = reader(1)
                TxtValorOriginal.Text = reader(5)
                TxtSaldoTitulo.Text = reader(9)
                DataEmissao.Text = reader(3)
                DataVencimento.Text = reader(4)
                idEntrada = reader(7)
                reader.Close()
            Else
                reader.Close()
            End If
            '.....................................................................................
            'BUSCANDO DADOS NA TBL ENTRADA
            Dim cmd2 As MySqlCommand
            Dim reader2 As MySqlDataReader
            Dim sql2 As String
            sql2 = "SELECT * FROM entrada WHERE id= '" & idEntrada & "' "
            cmd2 = New MySqlCommand(sql2, con)
            reader2 = cmd2.ExecuteReader
            If reader2.Read = True Then

                TxtNomeFornecedor.Text = reader2(3)
                TxtCodPedido.Text = reader2(4)
                TxtDescPed.Text = reader2(5)
                reader2.Close()
            Else
                reader2.Close()
            End If

            'Stop
            '....................................................................................
            'BUSCANDO DADOS NA TBL MVTO_PAGAMENTOS
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            sql3 = "SELECT * FROM mvto_pagamentos WHERE id_entrada= '" & idEntrada & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            If reader3.Read = True Then

                TxtValorPago.Text = reader3(10)
                DataPagamento.Text = reader3(9)
                TxtJurosMultas.Text = reader3(11)
                TxtDescontos.Text = reader3(12)
                TxtTotalPago.Text = reader3(13)
                TxtRegPagamento.Text = reader3(0)
                TxtStatusTitulo.Text = "Baixado"
                TxtDiasAtraso.Text = 0

                reader3.Close()
            Else
                reader3.Close()
                TxtValorPago.Text = 0
                DataPagamento.Text = ""
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0
                TxtRegPagamento.Text = ""
                TxtStatusTitulo.Text = "Aberto"
                TxtDiasAtraso.Text = ""
            End If


        Catch ex As Exception
            MsgBox("Erro ao carregar dados!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        ListarPedidoAnterior()
    End Sub

    Sub ListarPedidoAnterior()

        Try
            If TxtIdRegistro.Text <> "" Then
                anterior = TxtIdRegistro.Text - 1
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

            sqlp = "SELECT * FROM duplicatas WHERE id_entrada = '" & anterior & "' "
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

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT * FROM duplicatas WHERE id_entrada= '" & anterior & "' "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                TxtIdRegistro.Text = reader(7)
                TxtCodFornecedor.Text = reader(8)
                TxtNotaFiscal.Text = reader(2)
                TxtParcela.Text = reader(1)
                TxtValorOriginal.Text = reader(5)
                TxtSaldoTitulo.Text = reader(9)
                DataEmissao.Text = reader(3)
                DataVencimento.Text = reader(4)

                reader.Close()
            Else
                reader.Close()
            End If
            '.....................................................................................
            'BUSCANDO DADOS NA TBL ENTRADA
            Dim cmd2 As MySqlCommand
            Dim reader2 As MySqlDataReader
            Dim sql2 As String
            sql2 = "Select * FROM entrada WHERE id= '" & anterior & "' "
            cmd2 = New MySqlCommand(sql2, con)
            reader2 = cmd2.ExecuteReader
            If reader2.Read = True Then

                TxtNomeFornecedor.Text = reader2(3)
                TxtCodPedido.Text = reader2(4)
                TxtDescPed.Text = reader2(5)
                reader2.Close()
            Else
                reader2.Close()
            End If

            'Stop
            '....................................................................................
            'BUSCANDO DADOS NA TBL MVTO_PAGAMENTOS
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            sql3 = "SELECT * FROM mvto_pagamentos WHERE id_entrada= '" & anterior & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            If reader3.Read = True Then

                TxtValorPago.Text = reader3(10)
                DataPagamento.Text = reader3(9)
                TxtJurosMultas.Text = reader3(11)
                TxtDescontos.Text = reader3(12)
                TxtTotalPago.Text = reader3(13)
                TxtRegPagamento.Text = reader3(0)
                TxtStatusTitulo.Text = "Baixado"
                TxtDiasAtraso.Text = 0

                reader3.Close()
            Else
                reader3.Close()
                TxtValorPago.Text = 0
                DataPagamento.Text = ""
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0
                TxtRegPagamento.Text = ""
                TxtStatusTitulo.Text = "Aberto"
                TxtDiasAtraso.Text = ""
            End If


        Catch ex As Exception
            MsgBox("Erro ao carregar dados!! ---- " + ex.Message)
        End Try
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

                sql = "SELECT * FROM duplicatas WHERE id_entrada=(SELECT MAX(id_entrada) FROM duplicatas) "
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
            '.........................................................................................................

            If TxtIdRegistro.Text <> "" Then
                proximo = TxtIdRegistro.Text + 1
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

            sqlp = "SELECT * FROM duplicatas WHERE id_entrada  = '" & proximo & "' "
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

    Private Sub ProximoRegistro()

        Try
            Abrir()

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT * FROM duplicatas WHERE id_entrada= '" & proximo & "' "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                TxtIdRegistro.Text = reader(7)
                TxtCodFornecedor.Text = reader(8)
                TxtNotaFiscal.Text = reader(2)
                TxtParcela.Text = reader(1)
                TxtValorOriginal.Text = reader(5)
                TxtSaldoTitulo.Text = reader(9)
                DataEmissao.Text = reader(3)
                DataVencimento.Text = reader(4)

                reader.Close()
            Else
                reader.Close()
            End If
            '.....................................................................................
            'BUSCANDO DADOS NA TBL ENTRADA
            Dim cmd2 As MySqlCommand
            Dim reader2 As MySqlDataReader
            Dim sql2 As String
            sql2 = "Select * FROM entrada WHERE id= '" & proximo & "' "
            cmd2 = New MySqlCommand(sql2, con)
            reader2 = cmd2.ExecuteReader
            If reader2.Read = True Then

                TxtNomeFornecedor.Text = reader2(3)
                TxtCodPedido.Text = reader2(4)
                TxtDescPed.Text = reader2(5)
                reader2.Close()
            Else
                reader2.Close()
            End If

            'Stop
            '....................................................................................
            'BUSCANDO DADOS NA TBL MVTO_PAGAMENTOS
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            sql3 = "SELECT * FROM mvto_pagamentos WHERE id_entrada= '" & proximo & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            If reader3.Read = True Then

                TxtValorPago.Text = reader3(10)
                DataPagamento.Text = reader3(9)
                TxtJurosMultas.Text = reader3(11)
                TxtDescontos.Text = reader3(12)
                TxtTotalPago.Text = reader3(13)
                TxtRegPagamento.Text = reader3(0)
                TxtStatusTitulo.Text = "Baixado"
                TxtDiasAtraso.Text = 0

                reader3.Close()
            Else
                reader3.Close()
                TxtValorPago.Text = 0
                DataPagamento.Text = ""
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0
                TxtRegPagamento.Text = ""
                TxtStatusTitulo.Text = "Aberto"
                TxtDiasAtraso.Text = ""
            End If


        Catch ex As Exception
            MsgBox("Erro ao carregar dados!! ---- " + ex.Message)
        End Try

    End Sub
End Class