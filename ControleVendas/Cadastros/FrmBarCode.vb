Imports BarcodeLib

Public Class FrmBarCode

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If picBarcode.Image Is Nothing Then
            Return
        End If

        Dim saveFiledialog As New SaveFileDialog()
        saveFiledialog.Filter = "PNG|*.png"
        If saveFiledialog.ShowDialog() = DialogResult.OK Then
            picBarcode.Image.Save(saveFiledialog.FileName)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim codBarras As String
        codBarras = TxtCodPais.Text & TxtCodFab.Text & TxtCodProd.Text & TxtCodDig.Text
        TextBox1.Text = codBarras

        Dim barcode As New Barcode()
        Dim forecolor As Color = Color.Black
        Dim backcolor As Color = Color.Transparent
        '//SELECIONAR O TIPO PADRÃO DE CODIGO DE BARRAS A SER UTILIZADO
        Dim image As Image = barcode.Encode(TYPE.EAN13, codBarras, forecolor, backcolor, CInt(picBarcode.Width * 0.95), CInt(picBarcode.Height * 0.95))
        picBarcode.Image = image

        Label1.Text = TextBox1.Text
    End Sub
End Class