Imports MySql.Data.MySqlClient

Public Class FrmPagarTitulo
    Dim proximo As Integer
    Dim anterior As Integer
    Dim maximo As Integer

    Private Sub BtnBaixarTitulo_Click(sender As Object, e As EventArgs) Handles BtnBaixarTitulo.Click
        If TxtStatusTitulo.Text = "Pgto. Total" Then

            MsgBox("Título totalmente baixado!!", MsgBoxStyle.Information, "Baixar Título")

            Exit Sub
        End If
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
            form.TxtValorOriginal.Text = TxtTotalTitulo.Text
            form.TxtSaldoAbertoParcela.Text = TxtSaldoTitulo.Text
            form.TxtRegPagamento.Text = TxtRegPagamento.Text
            form.TxtValorParcela.Text = TxtValorParcela.Text
            form.TxtRefEntrada.Text = TxtRefEntrada.Text
            form.TxtRegPagamento.Text = TxtRegPagamento.Text
            form.TxtStatusTitulo.Text = TxtStatusTitulo.Text

            form.TxtValorPago.Text = TxtSaldoTitulo.Text


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
        'Stop
        Dim idEntrada As Integer
        Dim idDuplicata As Integer
        Try
            Abrir()

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT * FROM duplicatas WHERE id=(SELECT MAX(id) FROM duplicatas) "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                TxtIdRegistro.Text = reader("id")
                TxtCodFornecedor.Text = reader("cod_fornecedor")
                TxtNotaFiscal.Text = reader("documento")
                TxtParcela.Text = reader("parcela")
                TxtValorParcela.Text = reader("valor_parcela")
                TxtSaldoTitulo.Text = reader("saldo_duplicata")
                DataEmissao.Text = reader("data_emissao")
                DataVencimento.Text = reader("data_vencimento")
                TxtRefEntrada.Text = reader("id_entrada")
                idEntrada = reader("id_entrada")
                idDuplicata = reader("id")
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

                TxtNomeFornecedor.Text = reader2("fornecedor")
                TxtCodPedido.Text = reader2("id_pedido")
                TxtDescPed.Text = reader2("descricao")
                TxtTotalTitulo.Text = reader2("valor")
                reader2.Close()
            Else
                reader2.Close()
            End If

            ' Stop
            '....................................................................................
            'BUSCANDO DADOS NA TBL MVTO_PAGAMENTOS
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            'sql3 = "SELECT sum(id) FROM mvto_pagamentos where id_duplicata =  '" & idDuplicata & "' "
            sql3 = "Select MAX(id) As id , SUM(valor_pago) As valor_pago , SUM(juros_multa) As juros_multa , SUM(descontos) As descontos, SUM(total_pago) As total_pago, data_pagamento, MAX(status_nota) As status_nota, id_entrada, portador FROM mvto_pagamentos WHERE id_duplicata = '" & idDuplicata & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader

            reader3.Read()

            If Not IsDBNull(reader3("id")) Then

                DataPagamento.Visible = True
                LblDataPagamento.Visible = True
                TxtRegPagamento.Visible = True
                LblRegPgto.Visible = True

                TxtRegPagamento.Text = reader3("id")
                TxtValorPago.Text = reader3("valor_pago")
                TxtJurosMultas.Text = reader3("juros_multa")
                TxtDescontos.Text = reader3("descontos")
                TxtTotalPago.Text = reader3("total_pago")
                DataPagamento.Text = reader3("data_pagamento")
                TxtRefEntrada.Text = reader3("id_entrada")
                TxtPortador.Text = reader3("portador")

                reader3.Close()
            Else


                reader3.Close()
                TxtValorPago.Text = 0
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0
                TxtPortador.Text = ""
                'TxtStatusTitulo.Text = "Aberto"
            End If


            If TxtValorPago.Text = "0" Then
                TxtStatusTitulo.Text = "Aberto"
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
            Else

                If TxtSaldoTitulo.Text = "0,00" Then
                    TxtStatusTitulo.Text = "Pgto. Total"
                Else

                    TxtStatusTitulo.Text = "Pgto. Parcial"
                End If
            End If


        Catch ex As Exception
            MsgBox("Erro ao carregar dados!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub CarregarDadosPesquisaDuplicata()
        Dim idEntrada As Integer
        Dim idDuplicata As Integer


        Try
            Abrir()

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT * FROM duplicatas WHERE id='" & TxtIdPesquisar.Text & "'"
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                TxtIdRegistro.Text = reader("id")
                TxtCodFornecedor.Text = reader("cod_fornecedor")
                TxtNotaFiscal.Text = reader("documento")
                TxtParcela.Text = reader("parcela")
                TxtValorParcela.Text = reader("valor_parcela")
                TxtSaldoTitulo.Text = reader("saldo_duplicata")
                DataEmissao.Text = reader("data_emissao")
                DataVencimento.Text = reader("data_vencimento")
                TxtRefEntrada.Text = reader("id_entrada")
                idEntrada = reader("id_entrada")
                idDuplicata = reader("id")
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

                TxtNomeFornecedor.Text = reader2("fornecedor")
                TxtCodPedido.Text = reader2("id_pedido")
                TxtDescPed.Text = reader2("descricao")
                TxtTotalTitulo.Text = reader2("valor")
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
            sql3 = "SELECT MAX(id) as id, SUM(valor_pago) as valor_pago, SUM(juros_multa) as juros_multa , SUM(descontos) as descontos, SUM(total_pago) as total_pago, data_pagamento, MAX(status_nota) as status_nota, id_entrada, portador FROM mvto_pagamentos WHERE id_duplicata= '" & idDuplicata & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            reader3.Read()

            If Not IsDBNull(reader3("id")) Then

                DataPagamento.Visible = True
                LblDataPagamento.Visible = True
                TxtRegPagamento.Visible = True
                LblRegPgto.Visible = True

                TxtRegPagamento.Text = reader3("id")
                TxtValorPago.Text = reader3("valor_pago")
                TxtJurosMultas.Text = reader3("juros_multa")
                TxtDescontos.Text = reader3("descontos")
                TxtTotalPago.Text = reader3("total_pago")
                DataPagamento.Text = reader3("data_pagamento")
                ' TxtStatusTitulo.Text = reader3("status_nota")
                TxtRefEntrada.Text = reader3("id_entrada")
                TxtPortador.Text = reader3("portador")

                reader3.Close()
            Else


                reader3.Close()
                TxtValorPago.Text = 0
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0
                TxtPortador.Text = ""
                'TxtStatusTitulo.Text = "Aberto"
            End If

            TxtIdPesquisar.Text = ""


            If TxtValorPago.Text = "0" Then
                TxtStatusTitulo.Text = "Aberto"
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
                TxtRegPagamento.Visible = False
                LblRegPgto.Visible = False
            Else

                If TxtSaldoTitulo.Text = "0,00" Then
                    TxtStatusTitulo.Text = "Pgto. Total"
                Else

                    TxtStatusTitulo.Text = "Pgto. Parcial"
                End If
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

            sqlp = "SELECT * FROM duplicatas WHERE id = '" & anterior & "' "
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
        Dim idDuplicata As Integer
        Dim idEntrada As Integer
        Try
            Abrir()

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT * FROM duplicatas WHERE id= '" & anterior & "' "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                TxtIdRegistro.Text = reader("id")
                TxtCodFornecedor.Text = reader("cod_fornecedor")
                TxtNotaFiscal.Text = reader("documento")
                TxtParcela.Text = reader("parcela")
                TxtValorParcela.Text = reader("valor_parcela")
                TxtSaldoTitulo.Text = reader("saldo_duplicata")
                DataEmissao.Text = reader("data_emissao")
                DataVencimento.Text = reader("data_vencimento")
                TxtRefEntrada.Text = reader("id_entrada")
                idEntrada = reader("id_entrada")
                idDuplicata = reader("id")

                reader.Close()
            Else
                reader.Close()
            End If
            '.....................................................................................
            'BUSCANDO DADOS NA TBL ENTRADA
            Dim cmd2 As MySqlCommand
            Dim reader2 As MySqlDataReader
            Dim sql2 As String
            sql2 = "Select * FROM entrada WHERE id= '" & idEntrada & "' "
            cmd2 = New MySqlCommand(sql2, con)
            reader2 = cmd2.ExecuteReader
            If reader2.Read = True Then

                TxtNomeFornecedor.Text = reader2("fornecedor")
                TxtCodPedido.Text = reader2("id_pedido")
                TxtDescPed.Text = reader2("descricao")
                TxtTotalTitulo.Text = reader2("valor")

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
            sql3 = "SELECT MAX(id) as id, SUM(valor_pago) as valor_pago , SUM(juros_multa) as juros_multa, SUM(descontos) as descontos, SUM(total_pago) as total_pago, data_pagamento, MAX(status_nota) as status_nota, id_entrada, portador FROM mvto_pagamentos WHERE id_duplicata= '" & idDuplicata & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            reader3.Read()

            If Not IsDBNull(reader3("id")) Then

                DataPagamento.Visible = True
                LblDataPagamento.Visible = True
                TxtRegPagamento.Visible = True
                LblRegPgto.Visible = True

                TxtRegPagamento.Text = reader3("id")
                TxtValorPago.Text = reader3("valor_pago")
                TxtJurosMultas.Text = reader3("juros_multa")
                TxtDescontos.Text = reader3("descontos")
                TxtTotalPago.Text = reader3("total_pago")
                DataPagamento.Text = reader3("data_pagamento")
                ' TxtStatusTitulo.Text = reader3("status_nota")
                TxtRefEntrada.Text = reader3("id_entrada")
                TxtPortador.Text = reader3("portador")

                reader3.Close()
            Else


                reader3.Close()
                TxtValorPago.Text = 0
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0
                TxtPortador.Text = ""
                ' TxtStatusTitulo.Text = "Aberto"
            End If


            If TxtValorPago.Text = "0" Then
                TxtStatusTitulo.Text = "Aberto"
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
                TxtRegPagamento.Visible = False
                LblRegPgto.Visible = False
            Else

                If TxtSaldoTitulo.Text = "0,00" Then
                    TxtStatusTitulo.Text = "Pgto. Total"
                Else

                    TxtStatusTitulo.Text = "Pgto. Parcial"
                End If
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

                sql = "SELECT * FROM duplicatas WHERE id =(SELECT MAX(id) FROM duplicatas) "
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

            sqlp = "SELECT * FROM duplicatas WHERE id  = '" & proximo & "' "
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

    Private Sub ProximoRegistro()
        Dim idEntrada As Integer
        Dim idDuplicata As Integer
        Try
            Abrir()

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT * FROM duplicatas WHERE id = '" & proximo & "' "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                TxtIdRegistro.Text = reader("id")
                TxtCodFornecedor.Text = reader("cod_fornecedor")
                TxtNotaFiscal.Text = reader("documento")
                TxtParcela.Text = reader("parcela")
                TxtValorParcela.Text = reader("valor_parcela")
                TxtSaldoTitulo.Text = reader("saldo_duplicata")
                DataEmissao.Text = reader("data_emissao")
                DataVencimento.Text = reader("data_vencimento")
                TxtRefEntrada.Text = reader("id_entrada")
                idEntrada = reader("id_entrada")
                idDuplicata = reader("id")
                reader.Close()
            Else
                reader.Close()
            End If
            '.....................................................................................
            'BUSCANDO DADOS NA TBL ENTRADA
            Dim cmd2 As MySqlCommand
            Dim reader2 As MySqlDataReader
            Dim sql2 As String
            sql2 = "Select * FROM entrada WHERE id = '" & idEntrada & "' "
            cmd2 = New MySqlCommand(sql2, con)
            reader2 = cmd2.ExecuteReader
            If reader2.Read = True Then

                TxtNomeFornecedor.Text = reader2("fornecedor")
                TxtCodPedido.Text = reader2("id_pedido")
                TxtDescPed.Text = reader2("descricao")
                TxtTotalTitulo.Text = reader2("valor")
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
            sql3 = "SELECT MAX(id)as id, SUM(valor_pago) as valor_pago, SUM(juros_multa) as juros_multa, SUM(descontos) as descontos, SUM(total_pago) as total_pago, data_pagamento, MAX(status_nota) as status_nota, id_entrada, portador FROM mvto_pagamentos WHERE id_duplicata= '" & idDuplicata & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader

            reader3.Read()

            If Not IsDBNull(reader3("id")) Then

                DataPagamento.Visible = True
                LblDataPagamento.Visible = True
                TxtRegPagamento.Visible = True
                LblRegPgto.Visible = True

                TxtRegPagamento.Text = reader3("id")
                TxtValorPago.Text = reader3("valor_pago")
                TxtJurosMultas.Text = reader3("juros_multa")
                TxtDescontos.Text = reader3("descontos")
                TxtTotalPago.Text = reader3("total_pago")
                DataPagamento.Text = reader3("data_pagamento")
                'TxtStatusTitulo.Text = reader3("status_nota")
                TxtRefEntrada.Text = reader3("id_entrada")
                TxtPortador.Text = reader3("portador")

                reader3.Close()
            Else


                reader3.Close()
                TxtValorPago.Text = 0
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0
                'TxtStatusTitulo.Text = "Aberto"
                TxtPortador.Text = ""
            End If


            If TxtValorPago.Text = "0" Then
                TxtStatusTitulo.Text = "Aberto"
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
                TxtRegPagamento.Visible = False
                LblRegPgto.Visible = False
            Else

                If TxtSaldoTitulo.Text = "0,00" Then
                    TxtStatusTitulo.Text = "Pgto. Total"
                Else

                    TxtStatusTitulo.Text = "Pgto. Parcial"
                End If
            End If


        Catch ex As Exception

            MsgBox("Erro ao carregar dados!! ---- " + ex.Message)
        End Try

    End Sub

    Sub Atualizar_Pagina()
        Try

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT * FROM duplicatas WHERE id = '" & TxtIdRegistro.Text & "' "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                TxtSaldoTitulo.Text = reader(9)

                reader.Close()
            Else
                reader.Close()
            End If

            'Stop
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String

            sql3 = "SELECT MAX(id) as id , SUM(valor_pago) as valor_pago, SUM(juros_multa) as juros_multa , SUM(descontos)as descontos , SUM(total_pago) as total_pago, data_pagamento, MAX(status_nota) as status_nota, id_entrada , portador FROM mvto_pagamentos WHERE id_duplicata= '" & TxtIdRegistro.Text & "'  "

            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader

            reader3.Read()

            If Not IsDBNull(reader3("id")) Then

                DataPagamento.Visible = True
                LblDataPagamento.Visible = True
                TxtRegPagamento.Visible = True
                LblRegPgto.Visible = True

                TxtRegPagamento.Text = reader3("id")
                TxtValorPago.Text = reader3("valor_pago")
                TxtJurosMultas.Text = reader3("juros_multa")
                TxtDescontos.Text = reader3("descontos")
                TxtTotalPago.Text = reader3("total_pago")
                DataPagamento.Text = reader3("data_pagamento")
                'TxtStatusTitulo.Text = reader3("status_nota")
                TxtRefEntrada.Text = reader3("id_entrada")
                TxtPortador.Text = reader3("portador")

                reader3.Close()
            Else


                reader3.Close()
                TxtValorPago.Text = 0
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0
                TxtPortador.Text = ""
                'TxtStatusTitulo.Text = "Aberto"
            End If


            If TxtValorPago.Text = "0" Then
                TxtStatusTitulo.Text = "Aberto"
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
                TxtRegPagamento.Visible = False
                LblRegPgto.Visible = False
            Else

                If TxtSaldoTitulo.Text = "0,00" Then
                    TxtStatusTitulo.Text = "Pgto. Total"
                Else

                    TxtStatusTitulo.Text = "Pgto. Parcial"
                End If
            End If




        Catch ex As Exception
            MsgBox("Erro ao carregar dados!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        Atualizar_Pagina()
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click

        pesquisarDuplicata = "True"

        Dim form = New FrmNotasEntrada
        form.ShowDialog()
    End Sub

    Private Sub FrmPagarTitulo_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If pesquisarDuplicata = "True" Then

            TxtIdPesquisar.Text = IdDuplicata

            If TxtIdPesquisar.Text <> "" Then

                CarregarDadosPesquisaDuplicata()
            Else

                Exit Sub
            End If
        Else
            Atualizar_Pagina()
        End If

    End Sub

    Private Sub FrmPagarTitulo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        pesquisarDuplicata = ""
    End Sub


End Class