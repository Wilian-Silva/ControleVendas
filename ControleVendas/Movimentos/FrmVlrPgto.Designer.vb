<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVlrPgto
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
        Me.TxtMultasJuros = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtValorOriginal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtParcela = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSaldoAbertoParcela = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataVencimento = New System.Windows.Forms.DateTimePicker()
        Me.TxtValorParcela = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataEmissao = New System.Windows.Forms.DateTimePicker()
        Me.TxtDescPed = New System.Windows.Forms.TextBox()
        Me.TxtCodPedido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtIdRegistro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNomeFornecedor = New System.Windows.Forms.TextBox()
        Me.TxtCodFornecedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNotaFiscal = New System.Windows.Forms.TextBox()
        Me.TxtRegPagamento = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtRefEntrada = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtStatusTitulo = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 21)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Data Pagto."
        '
        'DataPgto
        '
        Me.DataPgto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPgto.Location = New System.Drawing.Point(101, 20)
        Me.DataPgto.Name = "DataPgto"
        Me.DataPgto.Size = New System.Drawing.Size(100, 20)
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
        Me.GroupBox2.Controls.Add(Me.TxtMultasJuros)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 216)
        Me.GroupBox2.TabIndex = 143
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 173)
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
        Me.Label12.Location = New System.Drawing.Point(18, 82)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "Valor Saldo:"
        '
        'TxtTotalPago
        '
        Me.TxtTotalPago.Enabled = False
        Me.TxtTotalPago.Location = New System.Drawing.Point(101, 171)
        Me.TxtTotalPago.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalPago.Name = "TxtTotalPago"
        Me.TxtTotalPago.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalPago.TabIndex = 7
        '
        'TxtSaldoTitulo
        '
        Me.TxtSaldoTitulo.Enabled = False
        Me.TxtSaldoTitulo.Location = New System.Drawing.Point(101, 81)
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
        Me.Label14.Location = New System.Drawing.Point(27, 142)
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
        Me.Label11.Location = New System.Drawing.Point(23, 53)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Valor Pago:"
        '
        'TxtDescontos
        '
        Me.TxtDescontos.Location = New System.Drawing.Point(101, 141)
        Me.TxtDescontos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescontos.Name = "TxtDescontos"
        Me.TxtDescontos.Size = New System.Drawing.Size(100, 20)
        Me.TxtDescontos.TabIndex = 6
        '
        'TxtValorPago
        '
        Me.TxtValorPago.Location = New System.Drawing.Point(101, 51)
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
        Me.Label15.Location = New System.Drawing.Point(18, 113)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "Multas/Juros"
        '
        'TxtMultasJuros
        '
        Me.TxtMultasJuros.Location = New System.Drawing.Point(101, 111)
        Me.TxtMultasJuros.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMultasJuros.Name = "TxtMultasJuros"
        Me.TxtMultasJuros.Size = New System.Drawing.Size(100, 20)
        Me.TxtMultasJuros.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(271, 17)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "Valor Orginal:"
        '
        'TxtValorOriginal
        '
        Me.TxtValorOriginal.Enabled = False
        Me.TxtValorOriginal.Location = New System.Drawing.Point(360, 16)
        Me.TxtValorOriginal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorOriginal.Name = "TxtValorOriginal"
        Me.TxtValorOriginal.Size = New System.Drawing.Size(82, 20)
        Me.TxtValorOriginal.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.BtnOk)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(252, 344)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 52)
        Me.GroupBox1.TabIndex = 172
        Me.GroupBox1.TabStop = False
        '
        'BtnOk
        '
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnOk.Location = New System.Drawing.Point(28, 14)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(70, 30)
        Me.BtnOk.TabIndex = 168
        Me.BtnOk.TabStop = False
        Me.BtnOk.Text = "Salvar"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCancelar.Location = New System.Drawing.Point(115, 14)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(70, 30)
        Me.BtnCancelar.TabIndex = 167
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.TxtParcela)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtSaldoAbertoParcela)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.DataVencimento)
        Me.GroupBox3.Controls.Add(Me.TxtValorParcela)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.DataEmissao)
        Me.GroupBox3.Controls.Add(Me.TxtDescPed)
        Me.GroupBox3.Controls.Add(Me.TxtCodPedido)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtIdRegistro)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtNomeFornecedor)
        Me.GroupBox3.Controls.Add(Me.TxtCodFornecedor)
        Me.GroupBox3.Controls.Add(Me.TxtValorOriginal)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtNotaFiscal)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(460, 163)
        Me.GroupBox3.TabIndex = 173
        Me.GroupBox3.TabStop = False
        '
        'TxtParcela
        '
        Me.TxtParcela.Enabled = False
        Me.TxtParcela.Location = New System.Drawing.Point(85, 130)
        Me.TxtParcela.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtParcela.Name = "TxtParcela"
        Me.TxtParcela.Size = New System.Drawing.Size(43, 20)
        Me.TxtParcela.TabIndex = 163
        Me.TxtParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(250, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 160
        Me.Label6.Text = "Saldo Parcela:"
        '
        'TxtSaldoAbertoParcela
        '
        Me.TxtSaldoAbertoParcela.Enabled = False
        Me.TxtSaldoAbertoParcela.Location = New System.Drawing.Point(345, 130)
        Me.TxtSaldoAbertoParcela.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSaldoAbertoParcela.Name = "TxtSaldoAbertoParcela"
        Me.TxtSaldoAbertoParcela.Size = New System.Drawing.Size(97, 20)
        Me.TxtSaldoAbertoParcela.TabIndex = 159
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 132)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 162
        Me.Label7.Text = "Parc./Valor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(264, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "Vencimento:"
        '
        'DataVencimento
        '
        Me.DataVencimento.Enabled = False
        Me.DataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataVencimento.Location = New System.Drawing.Point(345, 100)
        Me.DataVencimento.Name = "DataVencimento"
        Me.DataVencimento.Size = New System.Drawing.Size(97, 20)
        Me.DataVencimento.TabIndex = 155
        '
        'TxtValorParcela
        '
        Me.TxtValorParcela.Enabled = False
        Me.TxtValorParcela.Location = New System.Drawing.Point(130, 130)
        Me.TxtValorParcela.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorParcela.Name = "TxtValorParcela"
        Me.TxtValorParcela.Size = New System.Drawing.Size(80, 20)
        Me.TxtValorParcela.TabIndex = 161
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 102)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "Emisão:"
        '
        'DataEmissao
        '
        Me.DataEmissao.Enabled = False
        Me.DataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataEmissao.Location = New System.Drawing.Point(85, 100)
        Me.DataEmissao.Name = "DataEmissao"
        Me.DataEmissao.Size = New System.Drawing.Size(97, 20)
        Me.DataEmissao.TabIndex = 153
        '
        'TxtDescPed
        '
        Me.TxtDescPed.Enabled = False
        Me.TxtDescPed.Location = New System.Drawing.Point(131, 71)
        Me.TxtDescPed.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescPed.Name = "TxtDescPed"
        Me.TxtDescPed.Size = New System.Drawing.Size(174, 20)
        Me.TxtDescPed.TabIndex = 150
        '
        'TxtCodPedido
        '
        Me.TxtCodPedido.Enabled = False
        Me.TxtCodPedido.Location = New System.Drawing.Point(85, 71)
        Me.TxtCodPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodPedido.Name = "TxtCodPedido"
        Me.TxtCodPedido.Size = New System.Drawing.Size(44, 20)
        Me.TxtCodPedido.TabIndex = 149
        Me.TxtCodPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 72)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 148
        Me.Label8.Text = "Pedido:"
        '
        'TxtIdRegistro
        '
        Me.TxtIdRegistro.Enabled = False
        Me.TxtIdRegistro.Location = New System.Drawing.Point(84, 15)
        Me.TxtIdRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdRegistro.Name = "TxtIdRegistro"
        Me.TxtIdRegistro.Size = New System.Drawing.Size(44, 20)
        Me.TxtIdRegistro.TabIndex = 129
        Me.TxtIdRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Refer:"
        '
        'TxtNomeFornecedor
        '
        Me.TxtNomeFornecedor.Enabled = False
        Me.TxtNomeFornecedor.Location = New System.Drawing.Point(131, 43)
        Me.TxtNomeFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNomeFornecedor.Name = "TxtNomeFornecedor"
        Me.TxtNomeFornecedor.Size = New System.Drawing.Size(175, 20)
        Me.TxtNomeFornecedor.TabIndex = 130
        '
        'TxtCodFornecedor
        '
        Me.TxtCodFornecedor.Enabled = False
        Me.TxtCodFornecedor.Location = New System.Drawing.Point(85, 43)
        Me.TxtCodFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodFornecedor.Name = "TxtCodFornecedor"
        Me.TxtCodFornecedor.Size = New System.Drawing.Size(44, 20)
        Me.TxtCodFornecedor.TabIndex = 129
        Me.TxtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Fornec."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Título:"
        '
        'TxtNotaFiscal
        '
        Me.TxtNotaFiscal.Enabled = False
        Me.TxtNotaFiscal.Location = New System.Drawing.Point(185, 15)
        Me.TxtNotaFiscal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNotaFiscal.Name = "TxtNotaFiscal"
        Me.TxtNotaFiscal.Size = New System.Drawing.Size(67, 20)
        Me.TxtNotaFiscal.TabIndex = 97
        Me.TxtNotaFiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRegPagamento
        '
        Me.TxtRegPagamento.Enabled = False
        Me.TxtRegPagamento.Location = New System.Drawing.Point(120, 64)
        Me.TxtRegPagamento.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRegPagamento.Name = "TxtRegPagamento"
        Me.TxtRegPagamento.Size = New System.Drawing.Size(44, 20)
        Me.TxtRegPagamento.TabIndex = 158
        Me.TxtRegPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(2, 65)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(117, 16)
        Me.Label18.TabIndex = 157
        Me.Label18.Text = "Refer. Último Pgto:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 32)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 16)
        Me.Label17.TabIndex = 175
        Me.Label17.Text = "Refer Entrada:"
        '
        'TxtRefEntrada
        '
        Me.TxtRefEntrada.Enabled = False
        Me.TxtRefEntrada.Location = New System.Drawing.Point(121, 31)
        Me.TxtRefEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRefEntrada.Name = "TxtRefEntrada"
        Me.TxtRefEntrada.Size = New System.Drawing.Size(43, 20)
        Me.TxtRefEntrada.TabIndex = 174
        Me.TxtRefEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.TxtStatusTitulo)
        Me.GroupBox4.Controls.Add(Me.TxtRefEntrada)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.TxtRegPagamento)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(252, 180)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(220, 147)
        Me.GroupBox4.TabIndex = 176
        Me.GroupBox4.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(53, 104)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 16)
        Me.Label16.TabIndex = 177
        Me.Label16.Text = "Situação:"
        '
        'TxtStatusTitulo
        '
        Me.TxtStatusTitulo.Enabled = False
        Me.TxtStatusTitulo.Location = New System.Drawing.Point(120, 100)
        Me.TxtStatusTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStatusTitulo.Name = "TxtStatusTitulo"
        Me.TxtStatusTitulo.Size = New System.Drawing.Size(82, 20)
        Me.TxtStatusTitulo.TabIndex = 176
        '
        'FrmVlrPgto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 413)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmVlrPgto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas a Pagar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtDescPed As TextBox
    Friend WithEvents TxtCodPedido As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtIdRegistro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNomeFornecedor As TextBox
    Friend WithEvents TxtCodFornecedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNotaFiscal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataVencimento As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents DataEmissao As DateTimePicker
    Friend WithEvents TxtRegPagamento As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSaldoAbertoParcela As TextBox
    Friend WithEvents TxtParcela As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtValorParcela As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtRefEntrada As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtStatusTitulo As TextBox
End Class
