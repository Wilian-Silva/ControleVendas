<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagarTitulo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagarTitulo))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtTotalTitulo = New System.Windows.Forms.TextBox()
        Me.TxtDescPed = New System.Windows.Forms.TextBox()
        Me.TxtCodPedido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtIdRegistro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNomeFornecedor = New System.Windows.Forms.TextBox()
        Me.TxtCodFornecedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNotaFiscal = New System.Windows.Forms.TextBox()
        Me.TxtParcela = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblDataPagamento = New System.Windows.Forms.Label()
        Me.DataPagamento = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataVencimento = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataEmissao = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSaldoTitulo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtValorPago = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtValorParcela = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTotalPago = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtDescontos = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtJurosMultas = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtRegPagamento = New System.Windows.Forms.TextBox()
        Me.LblRegPgto = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtStatusTitulo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtRefEntrada = New System.Windows.Forms.TextBox()
        Me.GBoxFornecedor = New System.Windows.Forms.GroupBox()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnBaixarTitulo = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.GboxPesProd = New System.Windows.Forms.GroupBox()
        Me.BtnProximo = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPesquisar = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GBoxFornecedor.SuspendLayout()
        Me.GboxPesProd.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.TxtTotalTitulo)
        Me.GroupBox3.Controls.Add(Me.TxtDescPed)
        Me.GroupBox3.Controls.Add(Me.TxtCodPedido)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtIdRegistro)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtNomeFornecedor)
        Me.GroupBox3.Controls.Add(Me.TxtCodFornecedor)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtNotaFiscal)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 60)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(497, 86)
        Me.GroupBox3.TabIndex = 127
        Me.GroupBox3.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(141, 51)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 16)
        Me.Label19.TabIndex = 152
        Me.Label19.Text = "Total:"
        '
        'TxtTotalTitulo
        '
        Me.TxtTotalTitulo.Enabled = False
        Me.TxtTotalTitulo.Location = New System.Drawing.Point(187, 49)
        Me.TxtTotalTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalTitulo.Name = "TxtTotalTitulo"
        Me.TxtTotalTitulo.Size = New System.Drawing.Size(80, 20)
        Me.TxtTotalTitulo.TabIndex = 151
        '
        'TxtDescPed
        '
        Me.TxtDescPed.Enabled = False
        Me.TxtDescPed.Location = New System.Drawing.Point(366, 50)
        Me.TxtDescPed.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescPed.Name = "TxtDescPed"
        Me.TxtDescPed.Size = New System.Drawing.Size(119, 20)
        Me.TxtDescPed.TabIndex = 150
        '
        'TxtCodPedido
        '
        Me.TxtCodPedido.Enabled = False
        Me.TxtCodPedido.Location = New System.Drawing.Point(333, 50)
        Me.TxtCodPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodPedido.Name = "TxtCodPedido"
        Me.TxtCodPedido.Size = New System.Drawing.Size(32, 20)
        Me.TxtCodPedido.TabIndex = 149
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(278, 51)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 148
        Me.Label8.Text = "Pedido:"
        '
        'TxtIdRegistro
        '
        Me.TxtIdRegistro.Enabled = False
        Me.TxtIdRegistro.Location = New System.Drawing.Point(62, 19)
        Me.TxtIdRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdRegistro.Name = "TxtIdRegistro"
        Me.TxtIdRegistro.Size = New System.Drawing.Size(44, 20)
        Me.TxtIdRegistro.TabIndex = 129
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Refer:"
        '
        'TxtNomeFornecedor
        '
        Me.TxtNomeFornecedor.Enabled = False
        Me.TxtNomeFornecedor.Location = New System.Drawing.Point(280, 17)
        Me.TxtNomeFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNomeFornecedor.Name = "TxtNomeFornecedor"
        Me.TxtNomeFornecedor.Size = New System.Drawing.Size(197, 20)
        Me.TxtNomeFornecedor.TabIndex = 130
        '
        'TxtCodFornecedor
        '
        Me.TxtCodFornecedor.Enabled = False
        Me.TxtCodFornecedor.Location = New System.Drawing.Point(234, 17)
        Me.TxtCodFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodFornecedor.Name = "TxtCodFornecedor"
        Me.TxtCodFornecedor.Size = New System.Drawing.Size(44, 20)
        Me.TxtCodFornecedor.TabIndex = 129
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Fornecedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Título:"
        '
        'TxtNotaFiscal
        '
        Me.TxtNotaFiscal.Enabled = False
        Me.TxtNotaFiscal.Location = New System.Drawing.Point(62, 49)
        Me.TxtNotaFiscal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNotaFiscal.Name = "TxtNotaFiscal"
        Me.TxtNotaFiscal.Size = New System.Drawing.Size(70, 20)
        Me.TxtNotaFiscal.TabIndex = 97
        '
        'TxtParcela
        '
        Me.TxtParcela.Enabled = False
        Me.TxtParcela.Location = New System.Drawing.Point(107, 24)
        Me.TxtParcela.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtParcela.Name = "TxtParcela"
        Me.TxtParcela.Size = New System.Drawing.Size(25, 20)
        Me.TxtParcela.TabIndex = 152
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LblDataPagamento)
        Me.GroupBox1.Controls.Add(Me.DataPagamento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataVencimento)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DataEmissao)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 123)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datas"
        '
        'LblDataPagamento
        '
        Me.LblDataPagamento.AutoSize = True
        Me.LblDataPagamento.BackColor = System.Drawing.Color.Transparent
        Me.LblDataPagamento.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDataPagamento.Location = New System.Drawing.Point(12, 87)
        Me.LblDataPagamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataPagamento.Name = "LblDataPagamento"
        Me.LblDataPagamento.Size = New System.Drawing.Size(85, 16)
        Me.LblDataPagamento.TabIndex = 147
        Me.LblDataPagamento.Text = "Último Pagto:"
        Me.LblDataPagamento.Visible = False
        '
        'DataPagamento
        '
        Me.DataPagamento.Enabled = False
        Me.DataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPagamento.Location = New System.Drawing.Point(100, 86)
        Me.DataPagamento.Name = "DataPagamento"
        Me.DataPagamento.Size = New System.Drawing.Size(97, 20)
        Me.DataPagamento.TabIndex = 146
        Me.DataPagamento.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Vencimento:"
        '
        'DataVencimento
        '
        Me.DataVencimento.Enabled = False
        Me.DataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataVencimento.Location = New System.Drawing.Point(100, 53)
        Me.DataVencimento.Name = "DataVencimento"
        Me.DataVencimento.Size = New System.Drawing.Size(97, 20)
        Me.DataVencimento.TabIndex = 144
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "Emisão:"
        '
        'DataEmissao
        '
        Me.DataEmissao.Enabled = False
        Me.DataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataEmissao.Location = New System.Drawing.Point(100, 22)
        Me.DataEmissao.Name = "DataEmissao"
        Me.DataEmissao.Size = New System.Drawing.Size(97, 20)
        Me.DataEmissao.TabIndex = 124
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtParcela)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtSaldoTitulo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtValorPago)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtValorParcela)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 123)
        Me.GroupBox2.TabIndex = 129
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valores"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 86)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "Valor Saldo:"
        '
        'TxtSaldoTitulo
        '
        Me.TxtSaldoTitulo.Enabled = False
        Me.TxtSaldoTitulo.Location = New System.Drawing.Point(108, 84)
        Me.TxtSaldoTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSaldoTitulo.Name = "TxtSaldoTitulo"
        Me.TxtSaldoTitulo.Size = New System.Drawing.Size(105, 20)
        Me.TxtSaldoTitulo.TabIndex = 148
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 55)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Valor Pago:"
        '
        'TxtValorPago
        '
        Me.TxtValorPago.Enabled = False
        Me.TxtValorPago.Location = New System.Drawing.Point(108, 53)
        Me.TxtValorPago.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorPago.Name = "TxtValorPago"
        Me.TxtValorPago.Size = New System.Drawing.Size(105, 20)
        Me.TxtValorPago.TabIndex = 146
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "Parc./Valor:"
        '
        'TxtValorParcela
        '
        Me.TxtValorParcela.Enabled = False
        Me.TxtValorParcela.Location = New System.Drawing.Point(133, 24)
        Me.TxtValorParcela.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorParcela.Name = "TxtValorParcela"
        Me.TxtValorParcela.Size = New System.Drawing.Size(80, 20)
        Me.TxtValorParcela.TabIndex = 144
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.TxtTotalPago)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TxtDescontos)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.TxtJurosMultas)
        Me.GroupBox4.Location = New System.Drawing.Point(275, 149)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(237, 123)
        Me.GroupBox4.TabIndex = 130
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Despesas Financeiras"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(33, 86)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "Total Pago:"
        '
        'TxtTotalPago
        '
        Me.TxtTotalPago.Enabled = False
        Me.TxtTotalPago.Location = New System.Drawing.Point(108, 84)
        Me.TxtTotalPago.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalPago.Name = "TxtTotalPago"
        Me.TxtTotalPago.Size = New System.Drawing.Size(97, 20)
        Me.TxtTotalPago.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(35, 55)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 16)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "Descontos:"
        '
        'TxtDescontos
        '
        Me.TxtDescontos.Enabled = False
        Me.TxtDescontos.Location = New System.Drawing.Point(108, 53)
        Me.TxtDescontos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescontos.Name = "TxtDescontos"
        Me.TxtDescontos.Size = New System.Drawing.Size(97, 20)
        Me.TxtDescontos.TabIndex = 146
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 26)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "Multas/Juros"
        '
        'TxtJurosMultas
        '
        Me.TxtJurosMultas.Enabled = False
        Me.TxtJurosMultas.Location = New System.Drawing.Point(108, 24)
        Me.TxtJurosMultas.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtJurosMultas.Name = "TxtJurosMultas"
        Me.TxtJurosMultas.Size = New System.Drawing.Size(97, 20)
        Me.TxtJurosMultas.TabIndex = 144
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.TxtRegPagamento)
        Me.GroupBox5.Controls.Add(Me.LblRegPgto)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.TxtStatusTitulo)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.TxtRefEntrada)
        Me.GroupBox5.Location = New System.Drawing.Point(275, 275)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(237, 123)
        Me.GroupBox5.TabIndex = 131
        Me.GroupBox5.TabStop = False
        '
        'TxtRegPagamento
        '
        Me.TxtRegPagamento.Enabled = False
        Me.TxtRegPagamento.Location = New System.Drawing.Point(111, 85)
        Me.TxtRegPagamento.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRegPagamento.Name = "TxtRegPagamento"
        Me.TxtRegPagamento.Size = New System.Drawing.Size(44, 20)
        Me.TxtRegPagamento.TabIndex = 149
        Me.TxtRegPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtRegPagamento.Visible = False
        '
        'LblRegPgto
        '
        Me.LblRegPgto.AutoSize = True
        Me.LblRegPgto.BackColor = System.Drawing.Color.Transparent
        Me.LblRegPgto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegPgto.Location = New System.Drawing.Point(34, 87)
        Me.LblRegPgto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRegPgto.Name = "LblRegPgto"
        Me.LblRegPgto.Size = New System.Drawing.Size(73, 16)
        Me.LblRegPgto.TabIndex = 148
        Me.LblRegPgto.Text = "Refer Pgto:"
        Me.LblRegPgto.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(44, 21)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 16)
        Me.Label16.TabIndex = 147
        Me.Label16.Text = "Situação:"
        '
        'TxtStatusTitulo
        '
        Me.TxtStatusTitulo.Enabled = False
        Me.TxtStatusTitulo.Location = New System.Drawing.Point(110, 19)
        Me.TxtStatusTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStatusTitulo.Name = "TxtStatusTitulo"
        Me.TxtStatusTitulo.Size = New System.Drawing.Size(97, 20)
        Me.TxtStatusTitulo.TabIndex = 146
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 52)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 16)
        Me.Label17.TabIndex = 145
        Me.Label17.Text = "Refer Entrada:"
        '
        'TxtRefEntrada
        '
        Me.TxtRefEntrada.Enabled = False
        Me.TxtRefEntrada.Location = New System.Drawing.Point(111, 51)
        Me.TxtRefEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRefEntrada.Name = "TxtRefEntrada"
        Me.TxtRefEntrada.Size = New System.Drawing.Size(43, 20)
        Me.TxtRefEntrada.TabIndex = 144
        Me.TxtRefEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GBoxFornecedor
        '
        Me.GBoxFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.GBoxFornecedor.Controls.Add(Me.BtnCarregar)
        Me.GBoxFornecedor.Controls.Add(Me.BtnSalvar)
        Me.GBoxFornecedor.Controls.Add(Me.BtnBaixarTitulo)
        Me.GBoxFornecedor.Controls.Add(Me.BtnSair)
        Me.GBoxFornecedor.Controls.Add(Me.BtnExcluir)
        Me.GBoxFornecedor.Location = New System.Drawing.Point(259, 8)
        Me.GBoxFornecedor.Name = "GBoxFornecedor"
        Me.GBoxFornecedor.Size = New System.Drawing.Size(252, 50)
        Me.GBoxFornecedor.TabIndex = 160
        Me.GBoxFornecedor.TabStop = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.AccessibleDescription = ""
        Me.BtnSalvar.AccessibleName = "Adicionar"
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(135, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(35, 35)
        Me.BtnSalvar.TabIndex = 158
        Me.BtnSalvar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSalvar, "Salvar")
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'BtnBaixarTitulo
        '
        Me.BtnBaixarTitulo.AccessibleDescription = ""
        Me.BtnBaixarTitulo.AccessibleName = "Adicionar"
        Me.BtnBaixarTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBaixarTitulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBaixarTitulo.FlatAppearance.BorderSize = 0
        Me.BtnBaixarTitulo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBaixarTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBaixarTitulo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBaixarTitulo.ForeColor = System.Drawing.Color.Transparent
        Me.BtnBaixarTitulo.Image = CType(resources.GetObject("BtnBaixarTitulo.Image"), System.Drawing.Image)
        Me.BtnBaixarTitulo.Location = New System.Drawing.Point(90, 10)
        Me.BtnBaixarTitulo.Name = "BtnBaixarTitulo"
        Me.BtnBaixarTitulo.Size = New System.Drawing.Size(35, 35)
        Me.BtnBaixarTitulo.TabIndex = 157
        Me.BtnBaixarTitulo.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnBaixarTitulo, "Baixar título")
        Me.BtnBaixarTitulo.UseVisualStyleBackColor = False
        '
        'BtnSair
        '
        Me.BtnSair.AccessibleDescription = ""
        Me.BtnSair.AccessibleName = "Adicionar"
        Me.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSair.FlatAppearance.BorderSize = 0
        Me.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSair.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSair.Image = CType(resources.GetObject("BtnSair.Image"), System.Drawing.Image)
        Me.BtnSair.Location = New System.Drawing.Point(210, 10)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 161
        Me.BtnSair.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSair, "Sair")
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'BtnExcluir
        '
        Me.BtnExcluir.AccessibleDescription = ""
        Me.BtnExcluir.AccessibleName = "Adicionar"
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.FlatAppearance.BorderSize = 0
        Me.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(175, 10)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 160
        Me.BtnExcluir.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnExcluir, "Excluir")
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'GboxPesProd
        '
        Me.GboxPesProd.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesProd.Controls.Add(Me.BtnProximo)
        Me.GboxPesProd.Controls.Add(Me.BtnAnterior)
        Me.GboxPesProd.Controls.Add(Me.Label6)
        Me.GboxPesProd.Controls.Add(Me.TxtPesquisar)
        Me.GboxPesProd.Location = New System.Drawing.Point(16, 8)
        Me.GboxPesProd.Name = "GboxPesProd"
        Me.GboxPesProd.Size = New System.Drawing.Size(235, 50)
        Me.GboxPesProd.TabIndex = 159
        Me.GboxPesProd.TabStop = False
        '
        'BtnProximo
        '
        Me.BtnProximo.AccessibleDescription = ""
        Me.BtnProximo.AccessibleName = "Adicionar"
        Me.BtnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnProximo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProximo.FlatAppearance.BorderSize = 0
        Me.BtnProximo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProximo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProximo.Image = CType(resources.GetObject("BtnProximo.Image"), System.Drawing.Image)
        Me.BtnProximo.Location = New System.Drawing.Point(193, 15)
        Me.BtnProximo.Name = "BtnProximo"
        Me.BtnProximo.Size = New System.Drawing.Size(25, 25)
        Me.BtnProximo.TabIndex = 156
        Me.ToolTip.SetToolTip(Me.BtnProximo, "Próximo")
        Me.BtnProximo.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.AccessibleDescription = ""
        Me.BtnAnterior.AccessibleName = "Adicionar"
        Me.BtnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnterior.FlatAppearance.BorderSize = 0
        Me.BtnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnterior.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.Location = New System.Drawing.Point(164, 15)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(25, 25)
        Me.BtnAnterior.TabIndex = 155
        Me.ToolTip.SetToolTip(Me.BtnAnterior, "Anterior")
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 19)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "Pesq. NFe"
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.BackColor = System.Drawing.Color.White
        Me.TxtPesquisar.Location = New System.Drawing.Point(87, 18)
        Me.TxtPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(71, 20)
        Me.TxtPesquisar.TabIndex = 152
        '
        'BtnCarregar
        '
        Me.BtnCarregar.AccessibleDescription = ""
        Me.BtnCarregar.AccessibleName = "Adicionar"
        Me.BtnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCarregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCarregar.FlatAppearance.BorderSize = 0
        Me.BtnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCarregar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCarregar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCarregar.Image = CType(resources.GetObject("BtnCarregar.Image"), System.Drawing.Image)
        Me.BtnCarregar.Location = New System.Drawing.Point(6, 11)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCarregar.TabIndex = 162
        Me.BtnCarregar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnCarregar, "Atualizar")
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'FrmPagarTitulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(531, 417)
        Me.Controls.Add(Me.GBoxFornecedor)
        Me.Controls.Add(Me.GboxPesProd)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPagarTitulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Título do Contas a Pagar"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GBoxFornecedor.ResumeLayout(False)
        Me.GboxPesProd.ResumeLayout(False)
        Me.GboxPesProd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtIdRegistro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNomeFornecedor As TextBox
    Friend WithEvents TxtCodFornecedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNotaFiscal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataEmissao As DateTimePicker
    Friend WithEvents TxtDescPed As TextBox
    Friend WithEvents TxtCodPedido As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataVencimento As DateTimePicker
    Friend WithEvents TxtParcela As TextBox
    Friend WithEvents LblDataPagamento As Label
    Friend WithEvents DataPagamento As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtSaldoTitulo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtValorPago As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtValorParcela As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtTotalPago As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtDescontos As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtJurosMultas As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtStatusTitulo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtRefEntrada As TextBox
    Friend WithEvents GBoxFornecedor As GroupBox
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnBaixarTitulo As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents GboxPesProd As GroupBox
    Friend WithEvents BtnProximo As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPesquisar As TextBox
    Friend WithEvents TxtRegPagamento As TextBox
    Friend WithEvents LblRegPgto As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtTotalTitulo As TextBox
    Friend WithEvents BtnCarregar As Button
End Class
