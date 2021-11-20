Imports MySql.Data.MySqlClient

Public Class FrmLucroNfe

    Dim Apagar As Double
    Dim Recebidos As Double
    Dim Retirar As Double
    Dim Retiradas As Double
    Sub Listar_DpApagar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT D.ID_ENTRADA, D.DOCUMENTO,  D.COD_FORNECEDOR, F.NOME_FANTASIA, D.PARCELA, D.DATA_VENCIMENTO, D.VALOR_PARCELA, D.SALDO_DUPLICATA" _
                & " From DUPLICATAS As d " _
                & "INNER Join FORNECEDOR As F On D.COD_FORNECEDOR = F.ID " _
                & " WHERE d.ID_ENTRADA =  '" & TxtIdNfeEntrada.Text & "' " _
                & " ORDER BY D.ID_ENTRADA, d.PARCELA "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridApagar.DataSource = dt

            FormatarGrid_DpApagar()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub FormatarGrid_DpApagar()
        DataGridApagar.Columns(2).Visible = False
        DataGridApagar.Columns(0).Visible = False

        'DataGridApagar.Columns(0).HeaderText = "Id Nfe"
        DataGridApagar.Columns(1).HeaderText = "Documento"
        ' DataGridApagar.Columns(2).HeaderText = "Cod. Fornec."
        DataGridApagar.Columns(3).HeaderText = "Fornecedor"
        DataGridApagar.Columns(4).HeaderText = "Parc."
        DataGridApagar.Columns(5).HeaderText = "Vencimento"
        DataGridApagar.Columns(6).HeaderText = "Valor"
        DataGridApagar.Columns(7).HeaderText = "Saldo"

        ' DataGridApagar.Columns(0).Width = 60
        DataGridApagar.Columns(1).Width = 100
        'DataGridApagar.Columns(2).Width = 60
        DataGridApagar.Columns(3).Width = 180
        DataGridApagar.Columns(4).Width = 40
        DataGridApagar.Columns(5).Width = 80
        DataGridApagar.Columns(6).Width = 90
        DataGridApagar.Columns(7).Width = 90

        'DataGridApagar.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridApagar.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridApagar.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridApagar.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridApagar.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridApagar.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridApagar.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridApagar.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridApagar.Columns(6).DefaultCellStyle.Format = "c"
        DataGridApagar.Columns(7).DefaultCellStyle.Format = "c"

    End Sub

    Private Sub FormatarGrid_Recebimentos()
        DataGridRecebidos.Columns(2).Visible = False
        DataGridRecebidos.Columns(0).Visible = False
        DataGridRecebidos.Columns(5).Visible = False

        'DataGridRecebidos.Columns(0).HeaderText = "Id Nfe"
        DataGridRecebidos.Columns(1).HeaderText = "Documento"
        ' DataGridRecebidos.Columns(2).HeaderText = "Cod. Cliente."
        DataGridRecebidos.Columns(3).HeaderText = "Cliente"
        DataGridRecebidos.Columns(4).HeaderText = "Venda"
        ' DataGridRecebidos.Columns(5).HeaderText = "Id Duplicata"
        DataGridRecebidos.Columns(6).HeaderText = "Parc."
        DataGridRecebidos.Columns(7).HeaderText = "Vencimento"
        DataGridRecebidos.Columns(8).HeaderText = "Valor"
        DataGridRecebidos.Columns(9).HeaderText = "Recebido"

        DataGridRecebidos.Columns(1).Width = 82
        DataGridRecebidos.Columns(3).Width = 150
        DataGridRecebidos.Columns(4).Width = 60
        DataGridRecebidos.Columns(6).Width = 40
        DataGridRecebidos.Columns(7).Width = 80
        DataGridRecebidos.Columns(8).Width = 85
        DataGridRecebidos.Columns(9).Width = 85

        DataGridRecebidos.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRecebidos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRecebidos.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRecebidos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridRecebidos.Columns(8).DefaultCellStyle.Format = "c"
        DataGridRecebidos.Columns(9).DefaultCellStyle.Format = "c"

    End Sub
    Sub Listar_Recebimentos()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT ID_NFE, NFE, COD_CLIENTE, CLIENTE, ID_VENDA, ID_DUPLICATA, PARCELA, DATA_VENCIMENTO, VALOR_PARCELA, VALOR_PAGO " _
                & " FROM MVTO_RECEBIMENTOS " _
                & " WHERE ID_nfe =  '" & TxtIdNfeEntrada.Text & "' " _
                & " ORDER BY ID_NFE, PARCELA "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridRecebidos.DataSource = dt

            FormatarGrid_Recebimentos()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Sub Listar_Retiradas()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM TBL_RETIRADAS " _
                & " WHERE ID_ENTRADA_NFE =  '" & TxtIdNfeEntrada.Text & "' " _
                & " ORDER BY ID "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridRetiradas.DataSource = dt

            FormatarGrid_Retiradas()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub FormatarGrid_Retiradas()
        DataGridRetiradas.Columns(1).Visible = False
        'DataGridRetiradas.Columns(0).Visible = False
        ' DataGridRetiradas.Columns(5).Visible = False

        DataGridRetiradas.Columns(0).HeaderText = "Cod. Retirada"
        'DataGridRetiradas.Columns(1).HeaderText = "Id Nfe"
        DataGridRetiradas.Columns(2).HeaderText = "Documento"
        DataGridRetiradas.Columns(3).HeaderText = "Movimento"
        DataGridRetiradas.Columns(4).HeaderText = "Cód Portador"
        DataGridRetiradas.Columns(5).HeaderText = "Portador"
        DataGridRetiradas.Columns(6).HeaderText = "Valor"
        DataGridRetiradas.Columns(7).HeaderText = "Data"

        DataGridRetiradas.Columns(0).Width = 50
        ' DataGridRetiradas.Columns(1).Width = 50
        DataGridRetiradas.Columns(2).Width = 90
        DataGridRetiradas.Columns(3).Width = 125
        DataGridRetiradas.Columns(4).Width = 50
        DataGridRetiradas.Columns(5).Width = 100
        DataGridRetiradas.Columns(6).Width = 90
        DataGridRetiradas.Columns(7).Width = 80

        DataGridRetiradas.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRetiradas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRetiradas.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRetiradas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRetiradas.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRetiradas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridRetiradas.Columns(6).DefaultCellStyle.Format = "c"

    End Sub

    Sub Total_Pagar()
        On Error Resume Next
        Dim total As Decimal = 0
        For i = 0 To DataGridApagar.Rows.Count - 1
            total += DataGridApagar.Rows(i).Cells(6).Value
        Next

        TxtApagar.Text = Format(total, "R$ #,###0.00")
        Apagar = total
    End Sub
    Sub Total_Retiradas()

        On Error Resume Next
        Dim total As Decimal = 0
        For i = 0 To DataGridRetiradas.Rows.Count - 1

            total += DataGridRetiradas.Rows(i).Cells(6).Value
        Next

        TxtRetiradas.Text = Format(total, "R$ #,###0.00")
        Retiradas = total
    End Sub
    Sub Total_Recebido()
        On Error Resume Next
        Dim total As Decimal = 0
        For i = 0 To DataGridRecebidos.Rows.Count - 1
            total += DataGridRecebidos.Rows(i).Cells(9).Value
        Next
        TxtRecebidos.Text = Format(total, "R$ #,###0.00")
        Recebidos = total
    End Sub

    Sub Total_Aretirar()

        Retirar = Recebidos - Apagar - Retiradas
        TxtRetirar.Text = Format(Retirar, "R$ #,###0.00")
        If Retirar < 0 Then
            TxtRetirar.BackColor = Color.Red
            TxtRetirar.ForeColor = Color.White
        End If
        If Retirar > 0 Then
            TxtRetirar.BackColor = Color.LimeGreen
            TxtRetirar.ForeColor = Color.White
        End If

        If TxtRetirar.Text = "R$ 0,00" Then
            TxtRetirar.BackColor = Color.OrangeRed
            TxtRetirar.ForeColor = Color.White
        End If


    End Sub

    Private Sub BtnPortador_Click(sender As Object, e As EventArgs) Handles BtnPortador.Click
        pesquisarNotaEntrada = "True"
        Dim frm As New FrmEntradas
        frm.ShowDialog()
    End Sub

    Private Sub FrmLucroNfe_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If pesquisarNotaEntrada = "True" Then
            TxtIdNfeEntrada.Text = nfeIdNotaEntrada
            TxtNfeEntrada.Text = nfeNotaEntrada
        End If

        If TxtIdNfeEntrada.Text <> "" Then
            Listar_DpApagar()
            Listar_Recebimentos()
            Listar_Retiradas()
            Total_Pagar()
            Total_Recebido()
            Total_Retiradas()
            Total_Aretirar()
        End If
    End Sub

    Private Sub FrmLucroNfe_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        pesquisarNotaEntrada = ""
        nfeIdNotaEntrada = ""
        nfeNotaEntrada = ""
        TxtIdNfeEntrada.Text = ""
        TxtNfeEntrada.Text = ""
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmLucroNfe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class