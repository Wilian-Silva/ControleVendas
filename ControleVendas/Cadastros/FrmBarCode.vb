Imports BarcodeLib
Imports GenCode128
Public Class FrmBarCode

    Public altura As Integer = 2 'ALTURA DO CODIGO DE BARRAS

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim pasta = "c:\dados\"
        'picBarcode.Image.Save(pasta + TxtCodBarras.Text + ".jpg")

        'If picBarcode.Image Is Nothing Then
        '    Return
        'End If

        'Dim saveFiledialog As New SaveFileDialog()
        'saveFiledialog.Filter = "PNG|*.png"
        'If saveFiledialog.ShowDialog() = DialogResult.OK Then
        '    picBarcode.Image.Save(saveFiledialog.FileName)

        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonGerar.Click

        Try

            Dim codBarras As String
            codBarras = TxtCodPais.Text & TxtCodFab.Text & TxtCodProd.Text & TxtCodDig.Text
            TxtCodBarras.Text = codBarras

            Dim coddigoBarras = Code128Rendering.MakeBarcodeImage(TxtCodBarras.Text, altura, True) 'TRUE INSERI ESPAÇO APOS OS CODIGOS DE BARRAS
            picBarcode.Image = coddigoBarras
            Label1.Text = TxtCodBarras.Text

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        'TextBox1.Text = codBarras

        'Dim barcode As New Barcode()
        'Dim forecolor As Color = Color.Black
        'Dim backcolor As Color = Color.Transparent
        ''//SELECIONAR O TIPO PADRÃO DE CODIGO DE BARRAS A SER UTILIZADO
        'Dim image As Image = barcode.Encode(TYPE.EAN13, codBarras, forecolor, backcolor, CInt(picBarcode.Width * 0.95), CInt(picBarcode.Height * 0.95))
        'picBarcode.Image = image


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Using g = e.Graphics
            Using fnt = New Font("Courier New", 16)
                g.DrawImage(picBarcode.Image, 20, 50) '20 E 50 SÃO AS MARGENS DE IMPRESSÃO

                Dim caption = TxtCodBarras.Text
                g.DrawString(caption, fnt, Brushes.Black, 130, 110)

            End Using
        End Using

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        PrintDocument1.Print()
    End Sub
End Class