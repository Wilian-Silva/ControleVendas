Imports MySql.Data.MySqlClient

Public Class BotoesControle
    Dim Table1 As New DataTable("MyTable")
    Private Sub BotoesControle_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Table1.Columns.Add("ID", GetType(System.String))
        'Table1.Columns.Add("NOME", GetType(System.String))
        'Table1.Columns.Add("ENDEREÇO", GetType(System.String))


        'GERAR Nª PEDIDO A PARTIR DO BANCO

        '-----------------'


    End Sub

    Private Sub BtndAdicionarItem_Click(sender As Object, e As EventArgs) Handles BtndAdicionarItem.Click
        ' Stop
        If DataGrid.RowCount < 1 Then
            Table1.Columns.Add("ID")
            Table1.Columns.Add("SEQUENCIA")
            Table1.Columns.Add("NOME")
            Table1.Columns.Add("ENDEREÇO")

            TxtSequencia.Text = 1

            Dim bs As New BindingSource()
            bs.DataSource = Table1
            DataGrid.DataSource = bs

            Table1.Rows.Add(TxtId.Text, TxtSequencia.Text, TxtNome.Text, TxtEndereco.Text)

            TxtSequencia.Text = TxtSequencia.Text + 1

        Else

            Table1.Rows.Add(TxtId.Text, TxtSequencia.Text, TxtNome.Text, TxtEndereco.Text)

            TxtSequencia.Text = TxtSequencia.Text + 1

        End If

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        Abrir()
        Dim dg As New DataGridView
        Dim da As MySqlDataAdapter
        Dim sql2 As String
        Dim dt As New DataTable

        sql2 = "SELECT SUM(valor_total) as TOTAL FROM pedidos WHERE pedido =  '" & TxtId.Text & "' "
        da = New MySqlDataAdapter(sql2, con)
        da.Fill(dt)

        TxtNome.Text = dt.Rows(0)("TOTAL").ToString()

        'dg.DataSource = dt
        ' DataGrid.DataSource = dt

        'TxtNome.Text = DataGrid.CurrentCell.Value



        'TxtNome.Text = dt
    End Sub
End Class