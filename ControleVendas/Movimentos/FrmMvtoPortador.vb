Imports MySql.Data.MySqlClient

Public Class FrmMvtoPortador
    Private Sub FrmMvtoPortador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarPortador()
        CbPortador.Focus()
    End Sub

    Private Sub CarregarPortador()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM portador order by nome asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                CbPortador.ValueMember = "id"
                CbPortador.DisplayMember = "nome"
                CbPortador.DataSource = dt
            Else
                CbPortador.Text = ""

            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click


        'Stop
        CbTipoMvto.BackColor = Color.White
        TxtValor.BackColor = Color.White
        If CbTipoMvto.Text <> "" And TxtValor.Text <> "" Then


            If editarMvtoPortador = "True" Then


                If MsgBox("Deseja salvar edição desse registro?", vbYesNo, "Editar") = vbYes Then

                    Dim data1 As String
                    Dim portador As String
                    Dim Codportador As String
                    Dim tipoMvto As String

                    data1 = DataMvto.Value.ToString("yyyy-MM-dd")
                    tipoMvto = CbTipoMvto.Text
                    Codportador = CbPortador.SelectedValue
                    portador = CbPortador.Text

                    'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
                    Try
                        Abrir()

                        Dim sql1 As String
                        Dim cmd1 As MySqlCommand

                        sql1 = "UPDATE mvto_portador SET id_portador =  '" & Codportador & "', nome ='" & portador & "' , tipo ='" & tipoMvto & "' , data ='" & data1 & "' , valor = '" & TxtValor.Text.Replace(",", ".") & "', pagador_recebedor = '" & TxtMvto.Text & "' WHERE id = '" & TxtIdRegistro.Text & "'  "
                        cmd1 = New MySqlCommand(sql1, con)
                        cmd1.ExecuteNonQuery()


                        MsgBox("Registro editado com Sucesso!!", MsgBoxStyle.Information, "Editar")

                        editarMvtoPortador = ""
                        Me.Close()

                    Catch ex As Exception
                        MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
                    End Try
                End If




            Else

                If MsgBox("Deseja salvar esse registro?", vbYesNo, "Salvar") = vbYes Then

                    Dim data1 As String
                    Dim portador As String
                    Dim Codportador As String
                    Dim tipoMvto As String

                    data1 = DataMvto.Value.ToString("yyyy-MM-dd")
                    tipoMvto = CbTipoMvto.Text
                    Codportador = CbPortador.SelectedValue
                    portador = CbPortador.Text

                    'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
                    Try
                        Abrir()

                        Dim sql As String
                        Dim cmd As MySqlCommand

                        sql = "INSERT INTO  mvto_portador (id_portador, nome, tipo, data, valor, pagador_recebedor) VALUES ( '" & Codportador & "', '" & portador & "', '" & tipoMvto & "' , '" & data1 & "', '" & TxtValor.Text.Replace(",", ".") & "', '" & TxtMvto.Text & "') "
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        MsgBox("Registro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                        Me.Close()

                    Catch ex As Exception
                        MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
                    End Try
                End If

            End If

        Else

            CbTipoMvto.BackColor = Color.Salmon
            TxtValor.BackColor = Color.Salmon

            MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Salvar")
        End If


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub CbTipoMvto_TextChanged(sender As Object, e As EventArgs) Handles CbTipoMvto.TextChanged
        If CbTipoMvto.Text = "Entrada" Then
            TxtMvto.Text = "Outras Entradas"
        Else

            If CbTipoMvto.Text = "Saída" Then
            TxtMvto.Text = "Outras Saídas"
        End If
        End If

    End Sub

    Private Sub CbPortador_Enter(sender As Object, e As EventArgs) Handles CbPortador.Enter
        CorTxtBox(CbPortador, "Am")
    End Sub

    Private Sub CbPortador_Leave(sender As Object, e As EventArgs) Handles CbPortador.Leave
        CorTxtBox(CbPortador, "Br")
    End Sub

    Private Sub CbTipoMvto_Enter(sender As Object, e As EventArgs) Handles CbTipoMvto.Enter
        CorTxtBox(CbTipoMvto, "Am")
    End Sub

    Private Sub CbTipoMvto_Leave(sender As Object, e As EventArgs) Handles CbTipoMvto.Leave
        CorTxtBox(CbTipoMvto, "Br")
    End Sub

    Private Sub TxtValor_Enter(sender As Object, e As EventArgs) Handles TxtValor.Enter
        CorTxtBox(TxtValor, "Am")
    End Sub

    Private Sub TxtValor_Leave(sender As Object, e As EventArgs) Handles TxtValor.Leave
        CorTxtBox(TxtValor, "Br")
    End Sub
End Class