<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBarCode
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCodPais = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCodFab = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCodProd = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCodDig = New System.Windows.Forms.MaskedTextBox()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBarcode
        '
        Me.picBarcode.BackColor = System.Drawing.Color.White
        Me.picBarcode.Location = New System.Drawing.Point(121, 47)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(398, 103)
        Me.picBarcode.TabIndex = 0
        Me.picBarcode.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(293, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(415, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Criar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = " - "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(121, 12)
        Me.TextBox1.Mask = "000000000000"
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 29)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "789 - Codigo Pais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "1024 - Codigo Fabricante"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "11760 -  Codigo Produto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "6 - Digito de Controle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "EAN-13"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "7891024117606"
        '
        'TxtCodPais
        '
        Me.TxtCodPais.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodPais.Location = New System.Drawing.Point(576, 12)
        Me.TxtCodPais.Mask = "000"
        Me.TxtCodPais.Name = "TxtCodPais"
        Me.TxtCodPais.Size = New System.Drawing.Size(84, 29)
        Me.TxtCodPais.TabIndex = 12
        Me.TxtCodPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(666, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Código País"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(666, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 24)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Código Fabricante"
        '
        'TxtCodFab
        '
        Me.TxtCodFab.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodFab.Location = New System.Drawing.Point(576, 58)
        Me.TxtCodFab.Mask = "0000"
        Me.TxtCodFab.Name = "TxtCodFab"
        Me.TxtCodFab.Size = New System.Drawing.Size(84, 29)
        Me.TxtCodFab.TabIndex = 14
        Me.TxtCodFab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(666, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 24)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Código Produto"
        '
        'TxtCodProd
        '
        Me.TxtCodProd.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodProd.Location = New System.Drawing.Point(576, 101)
        Me.TxtCodProd.Mask = "00000"
        Me.TxtCodProd.Name = "TxtCodProd"
        Me.TxtCodProd.Size = New System.Drawing.Size(84, 29)
        Me.TxtCodProd.TabIndex = 16
        Me.TxtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(666, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 24)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Dígito Controle"
        '
        'TxtCodDig
        '
        Me.TxtCodDig.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodDig.Location = New System.Drawing.Point(576, 147)
        Me.TxtCodDig.Mask = "0"
        Me.TxtCodDig.Name = "TxtCodDig"
        Me.TxtCodDig.Size = New System.Drawing.Size(84, 29)
        Me.TxtCodDig.TabIndex = 18
        Me.TxtCodDig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmBarCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 472)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtCodDig)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtCodProd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtCodFab)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCodPais)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picBarcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmBarCode"
        Me.Text = "FrmBarCode"
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents picBarcode As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCodPais As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCodFab As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCodProd As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtCodDig As MaskedTextBox
End Class
