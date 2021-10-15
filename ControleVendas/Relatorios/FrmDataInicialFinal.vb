Public Class FrmDataInicialFinal
    Private Sub FrmDataInicialFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnGerar_Click(sender As Object, e As EventArgs) Handles BtnGerar.Click

        dataInicial = Nothing
        dataFinal = Nothing
        dataInicial = DataInicio.Value
        dataFinal = DataFim.Value

        If relatorio = "Rel.Vendas" Then
            Dim form = New ReportVendas
            form.ShowDialog()
            relatorio = ""
        End If

        If relatorio = "Rel.Recebimentos" Then
            Dim form1 = New FrmRecebimentos
            form1.ShowDialog()
            relatorio = ""
        End If

        If relatorio = "Rel.Resultado Periodo" Then
            Dim form2 = New FrmResultadoPeriodo '
            form2.ShowDialog()
            relatorio = ""
        End If

        If relatorio = "Rel.Mvto Estoque" Then
            Dim form3 = New FrmMvtoEstoque
            form3.ShowDialog()
            relatorio = ""
        End If
    End Sub
End Class