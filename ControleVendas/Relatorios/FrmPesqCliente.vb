Public Class FrmPesqCliente
    Private Sub BtnGerar_Click(sender As Object, e As EventArgs) Handles BtnGerar.Click

        dataInicial = Nothing
        dataFinal = Nothing
        dataInicial = DataInicio.Value
        dataFinal = DataFim.Value

        Dim form = New FrmRelVendaCliente
        form.ShowDialog()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnPesquisarNota_Click(sender As Object, e As EventArgs) Handles BtnPesquisarNota.Click
        pesquisarCliente = "True"

        Dim form = New FrmClientes
        form.ShowDialog()
    End Sub

    Private Sub FrmPesqCliente_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If pesquisarCliente = "True" Then
            TxtCliente.Text = nomeCliente
            TxtIdVenda.Text = codCliente
            pesquisarCliente = ""

        End If
    End Sub

    Private Sub FrmPesqCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class