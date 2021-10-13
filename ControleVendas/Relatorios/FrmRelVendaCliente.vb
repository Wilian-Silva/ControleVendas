Public Class FrmRelVendaCliente
    Private Sub BtnPesquisarCliente_Click(sender As Object, e As EventArgs) Handles BtnPesquisarCliente.Click

        pesquisarCliente = "True"
        Dim form = New FrmClientes
        form.ShowDialog()
    End Sub

    Private Sub FrmRelVendaCliente_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If pesquisarCliente = "True" Then
            TxtIdPortador.Text = codCliente
            pesquisarCliente = ""
        End If
    End Sub

    Private Sub FrmRelVendaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Sub CarregarRelatorio()
        If TxtIdPortador.Text <> "" Then
            'TODO: esta linha de código carrega dados na tabela 'controle_vendasPorCliente.venda_cliente_data'. Você pode movê-la ou removê-la conforme necessário.
            Me.venda_cliente_dataTableAdapter.Fill(Me.controle_vendasPorCliente.venda_cliente_data, TxtIdPortador.Text, DataInicio.Text, DataFim.Text)
            'TODO: esta linha de código carrega dados na tabela 'controle_vendasPorCliente.duplicatas_cliente_data'. Você pode movê-la ou removê-la conforme necessário.
            Me.duplicatas_cliente_dataTableAdapter.Fill(Me.controle_vendasPorCliente.duplicatas_cliente_data, TxtIdPortador.Text, DataInicio.Text, DataFim.Text)

            Me.ReportViewer1.RefreshReport()
        Else
            MsgBox("Selecione um cliente!!!")
        End If
    End Sub

    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        CarregarRelatorio()
    End Sub
End Class