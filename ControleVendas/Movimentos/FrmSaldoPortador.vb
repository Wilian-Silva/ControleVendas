Imports MySql.Data.MySqlClient

Public Class FrmSaldoPortador
    Private Sub FrmSaldoPortador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data1 As Date
        Dim data2 As Date

        data1 = Now.ToShortDateString 'Data inicio digitada pelo cliente
        data2 = Now.ToShortDateString  'Data fim digitada pelo cliente

        Dim Primeiro_Dia_Mes As Date
        Dim Ultimo_Dia_Mes As Date

        Primeiro_Dia_Mes = "01/" & Month(data1) & "/" & Year(data1)
        Ultimo_Dia_Mes = Func_Ultimo_Dia_Mes(data2)

        DataInicio.Value = Primeiro_Dia_Mes
        DataFim.Value = Ultimo_Dia_Mes

        CarregarPortador()

        If statusBtn = "Visible" Then
            BtnNovo.Enabled = True
            BtnEditar.Enabled = True
            BtnExcluir.Enabled = True
        Else
            BtnNovo.Enabled = False
            BtnEditar.Enabled = False
            BtnExcluir.Enabled = False

        End If

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
    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click

        Listar()

        SaldoAnterior()

        TotalEntrada()

        TotalSaida()

        SaldoFinal()

    End Sub

    Sub SaldoFinal()

        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Dim dbl3 As Double = 0

        Double.TryParse(TxtSaldoAnterior.Text, dbl1)
        Double.TryParse(TxtTotalEntradas.Text, dbl2)
        Double.TryParse(TxtTotalSaidas.Text, dbl3)

        TxtSaldoFinal.Text = (dbl1 + dbl2 - dbl3).ToString("n")

    End Sub
    Sub TotalEntrada()

        On Error Resume Next
        Dim total As Decimal = 0
        For i = 0 To DataGrid.Rows.Count - 1

            If DataGrid.Rows(i).Cells(3).Value = "Entrada" Then

                total += DataGrid.Rows(i).Cells(5).Value
            End If
        Next
        TxtTotalEntradas.Text = total

    End Sub

    Sub TotalSaida()

        On Error Resume Next
        Dim total As Decimal = 0
        For i = 0 To DataGrid.Rows.Count - 1

            If DataGrid.Rows(i).Cells(3).Value = "Saída" Then

                total += DataGrid.Rows(i).Cells(5).Value
            End If
        Next
        TxtTotalSaidas.Text = total

    End Sub
    Sub SaldoAnterior()
        'Stop
        Dim data1 As String
        Dim tipoEnt As String
        Dim portador As String

        data1 = DataInicio.Value.ToString("yyyy-MM-dd")
        tipoEnt = "Entrada"
        portador = CbPortador.SelectedValue

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader

            sql = "SELECT SUM(valor) as valor  FROM mvto_portador  WHERE id_portador =  '" & portador & "' AND data < '" & data1 & "' AND tipo= '" & tipoEnt & "' "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            reader.Read()

            If Not IsDBNull(reader("valor")) Then
                TxtSaldoAnterior.Text = reader("Valor")
                reader.Close()
            Else
                reader.Close()
                TxtSaldoAnterior.Text = 0
            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub


    Sub Listar()
        'Stop
        Dim data1 As String
        Dim data2 As String
        Dim portador As String

        data1 = DataInicio.Value.ToString("yyyy-MM-dd")
        data2 = DataFim.Value.ToString("yyyy-MM-dd")
        portador = CbPortador.SelectedValue

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM mvto_portador  WHERE id_portador =  '" & portador & "' AND data <= '" & data2 & "' AND data >= '" & data1 & "' "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Private Sub FormatarGrid()
        'DataGrid.Columns(6).Visible = False

        DataGrid.Columns(0).HeaderText = "Reg"
        DataGrid.Columns(1).HeaderText = "Cód. Portador"
        DataGrid.Columns(2).HeaderText = "Portador"
        DataGrid.Columns(3).HeaderText = "Tipo Movimento"
        DataGrid.Columns(4).HeaderText = "Data"
        DataGrid.Columns(5).HeaderText = "Valor"
        DataGrid.Columns(6).HeaderText = "Nº Duplicata"
        DataGrid.Columns(7).HeaderText = "Descrição"


        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).Width = 45
        DataGrid.Columns(1).Width = 50
        DataGrid.Columns(3).Width = 80
        'DataGrid.Columns(2).Width = 135
        DataGrid.Columns(6).Width = 50

        DataGrid.Columns(5).DefaultCellStyle.Format = "c"

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmSaldoPortador_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        statusBtn = ""
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Dim form = New FrmMvtoPortador
        form.ShowDialog()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxtIdRegistro.Text <> "" Then

            If MsgBox("Deseja excluir esse registro?", vbYesNo, "Excluir") = vbYes Then

                Try
                    Abrir()

                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE FROM mvto_portador WHERE id = '" & TxtIdRegistro.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()


                    MsgBox("Registro exlcuído com sucesso!!!", MsgBoxStyle.Information, "Excluir")

                Catch ex As Exception
                    MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
                End Try


            End If

        Else
            MsgBox("Selecione um registro para excluir!!", MsgBoxStyle.Information, "Excluir")
            Exit Sub
        End If


    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex > -1 Then

            TxtIdRegistro.Text = DataGrid.CurrentRow.Cells(0).Value

        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdRegistro.Text <> "" Then

            If MsgBox("Deseja editar esse registro?", vbYesNo, "Editar") = vbYes Then

                editarMvtoPortador = "True"
                Dim form = New FrmMvtoPortador()


                form.TxtIdRegistro.Text = DataGrid.CurrentRow.Cells(0).Value
                form.CbPortador.ValueMember = DataGrid.CurrentRow.Cells(1).Value
                form.CbPortador.Text = DataGrid.CurrentRow.Cells(2).Value
                form.CbTipoMvto.Text = DataGrid.CurrentRow.Cells(3).Value
                form.DataMvto.Value = DataGrid.CurrentRow.Cells(4).Value
                form.TxtValor.Text = DataGrid.CurrentRow.Cells(5).Value
                form.TxtMvto.Text = DataGrid.CurrentRow.Cells(7).Value

                form.TxtMvto.Enabled = False

                form.ShowDialog()

            End If

        Else
            MsgBox("Selecione um registro para editar!!", MsgBoxStyle.Information, "Excluir")
            Exit Sub
        End If

    End Sub
End Class