Imports MySql.Data.MySqlClient

Public Class FrmVlrPgto
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub TxtValorPago_TextChanged(sender As Object, e As EventArgs) Handles TxtValorPago.TextChanged

        SomarValores()

    End Sub
    Sub SomarValores()

        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Double.TryParse(TxtValorOriginal.Text, dbl1)
        Double.TryParse(TxtValorPago.Text, dbl2)

        TxtSaldoTitulo.Text = (dbl1 - dbl2).ToString("n")

        Dim dbl4 As Double = 0
        Dim dbl5 As Double = 0
        Dim dbl6 As Double = 0
        Double.TryParse(TxtValorPago.Text, dbl4)
        Double.TryParse(TxtMultasJuros.Text, dbl5)
        Double.TryParse(TxtDescontos.Text, dbl6)

        TxtTotalPago.Text = (dbl4 + dbl5 - dbl6).ToString("n")
    End Sub

    Private Sub TxtMultasJuros_TextChanged(sender As Object, e As EventArgs) Handles TxtMultasJuros.TextChanged
        SomarValores()
    End Sub

    Private Sub TxtDescontos_TextChanged(sender As Object, e As EventArgs) Handles TxtDescontos.TextChanged
        SomarValores()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        If MsgBox("Deseja salvar a baixa do título " & TxtNotaFiscal.Text & " Parcela " & TxtParcela.Text & "?", vbYesNo, "Salvar Baixa") = vbYes Then

            Me.Close()
        End If
    End Sub
End Class

