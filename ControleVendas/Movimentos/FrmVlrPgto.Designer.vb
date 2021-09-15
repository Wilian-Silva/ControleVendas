<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVlrPgto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVlrPgto))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataPgto = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTotalPago = New System.Windows.Forms.TextBox()
        Me.TxtSaldoTitulo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtDescontos = New System.Windows.Forms.TextBox()
        Me.TxtValorPago = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMultasJuros = New System.Windows.Forms.TextBox()
        Me.TxtValorOriginal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 22)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 16)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Data Pagamento:"
        '
        'DataPgto
        '
        Me.DataPgto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPgto.Location = New System.Drawing.Point(120, 20)
        Me.DataPgto.Name = "DataPgto"
        Me.DataPgto.Size = New System.Drawing.Size(95, 20)
        Me.DataPgto.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.DataPgto)
        Me.GroupBox2.Controls.Add(Me.TxtTotalPago)
        Me.GroupBox2.Controls.Add(Me.TxtSaldoTitulo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtDescontos)
        Me.GroupBox2.Controls.Add(Me.TxtValorPago)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtMultasJuros)
        Me.GroupBox2.Controls.Add(Me.TxtValorOriginal)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 253)
        Me.GroupBox2.TabIndex = 143
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Total Pago:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 111)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "Valor Saldo:"
        '
        'TxtTotalPago
        '
        Me.TxtTotalPago.Enabled = False
        Me.TxtTotalPago.Location = New System.Drawing.Point(120, 200)
        Me.TxtTotalPago.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalPago.Name = "TxtTotalPago"
        Me.TxtTotalPago.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalPago.TabIndex = 7
        '
        'TxtSaldoTitulo
        '
        Me.TxtSaldoTitulo.Enabled = False
        Me.TxtSaldoTitulo.Location = New System.Drawing.Point(120, 110)
        Me.TxtSaldoTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSaldoTitulo.Name = "TxtSaldoTitulo"
        Me.TxtSaldoTitulo.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldoTitulo.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(46, 171)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 16)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "Descontos:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(42, 82)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Valor Pago:"
        '
        'TxtDescontos
        '
        Me.TxtDescontos.Location = New System.Drawing.Point(120, 170)
        Me.TxtDescontos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescontos.Name = "TxtDescontos"
        Me.TxtDescontos.Size = New System.Drawing.Size(100, 20)
        Me.TxtDescontos.TabIndex = 6
        '
        'TxtValorPago
        '
        Me.TxtValorPago.Location = New System.Drawing.Point(120, 80)
        Me.TxtValorPago.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorPago.Name = "TxtValorPago"
        Me.TxtValorPago.Size = New System.Drawing.Size(100, 20)
        Me.TxtValorPago.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(37, 142)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "Multas/Juros"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 51)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "Valor Orginal:"
        '
        'TxtMultasJuros
        '
        Me.TxtMultasJuros.Location = New System.Drawing.Point(120, 140)
        Me.TxtMultasJuros.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMultasJuros.Name = "TxtMultasJuros"
        Me.TxtMultasJuros.Size = New System.Drawing.Size(100, 20)
        Me.TxtMultasJuros.TabIndex = 5
        '
        'TxtValorOriginal
        '
        Me.TxtValorOriginal.Enabled = False
        Me.TxtValorOriginal.Location = New System.Drawing.Point(120, 50)
        Me.TxtValorOriginal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorOriginal.Name = "TxtValorOriginal"
        Me.TxtValorOriginal.Size = New System.Drawing.Size(100, 20)
        Me.TxtValorOriginal.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.BtnOk)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(19, 266)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 52)
        Me.GroupBox1.TabIndex = 172
        Me.GroupBox1.TabStop = False
        '
        'BtnOk
        '
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnOk.Location = New System.Drawing.Point(46, 14)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(70, 30)
        Me.BtnOk.TabIndex = 168
        Me.BtnOk.TabStop = False
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCancelar.Location = New System.Drawing.Point(150, 14)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(70, 30)
        Me.BtnCancelar.TabIndex = 167
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmVlrPgto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(300, 335)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmVlrPgto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label13 As Label
    Friend WithEvents DataPgto As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtSaldoTitulo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtValorPago As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtValorOriginal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotalPago As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtDescontos As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtMultasJuros As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnCancelar As Button
End Class
