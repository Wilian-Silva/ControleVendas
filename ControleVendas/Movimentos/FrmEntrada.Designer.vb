<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEntrada
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntrada))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.BtnPesqPedido = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtStatusPedido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIdPedido = New System.Windows.Forms.TextBox()
        Me.TxtPesquisar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTotalPedido = New System.Windows.Forms.TextBox()
        Me.TxtNotaFiscal = New System.Windows.Forms.TextBox()
        Me.DataVecimento = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CbFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataEmissao = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtIdRegistro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 518)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 19)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Total da Compra:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnNovo)
        Me.GroupBox2.Controls.Add(Me.BtnSair)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Location = New System.Drawing.Point(625, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 50)
        Me.GroupBox2.TabIndex = 124
        Me.GroupBox2.TabStop = False
        '
        'BtnNovo
        '
        Me.BtnNovo.AccessibleDescription = ""
        Me.BtnNovo.AccessibleName = ""
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnNovo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.Image = CType(resources.GetObject("BtnNovo.Image"), System.Drawing.Image)
        Me.BtnNovo.Location = New System.Drawing.Point(95, 10)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(35, 35)
        Me.BtnNovo.TabIndex = 58
        Me.ToolTip.SetToolTip(Me.BtnNovo, "Incluir novo registro")
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.AccessibleDescription = ""
        Me.BtnSair.AccessibleName = "Adicionar"
        Me.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSair.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.Image = CType(resources.GetObject("BtnSair.Image"), System.Drawing.Image)
        Me.BtnSair.Location = New System.Drawing.Point(176, 10)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 57
        Me.ToolTip.SetToolTip(Me.BtnSair, "Sair")
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Enabled = False
        Me.BtnSalvar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(134, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(35, 35)
        Me.BtnSalvar.TabIndex = 54
        Me.ToolTip.SetToolTip(Me.BtnSalvar, "Salvar registro")
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.AccessibleDescription = ""
        Me.BtnPesquisar.AccessibleName = "Adicionar"
        Me.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPesquisar.Enabled = False
        Me.BtnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnPesquisar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPesquisar.Image = CType(resources.GetObject("BtnPesquisar.Image"), System.Drawing.Image)
        Me.BtnPesquisar.Location = New System.Drawing.Point(234, 17)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesquisar.TabIndex = 139
        Me.ToolTip.SetToolTip(Me.BtnPesquisar, "Carregar dados do pedido")
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'BtnPesqPedido
        '
        Me.BtnPesqPedido.Enabled = False
        Me.BtnPesqPedido.Image = CType(resources.GetObject("BtnPesqPedido.Image"), System.Drawing.Image)
        Me.BtnPesqPedido.Location = New System.Drawing.Point(210, 17)
        Me.BtnPesqPedido.Name = "BtnPesqPedido"
        Me.BtnPesqPedido.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesqPedido.TabIndex = 136
        Me.ToolTip.SetToolTip(Me.BtnPesqPedido, "Consultar Pedido")
        Me.BtnPesqPedido.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtStatusPedido)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtIdPedido)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisar)
        Me.GroupBox1.Controls.Add(Me.TxtPesquisar)
        Me.GroupBox1.Controls.Add(Me.BtnPesqPedido)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(178, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 50)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar"
        '
        'TxtStatusPedido
        '
        Me.TxtStatusPedido.Enabled = False
        Me.TxtStatusPedido.Location = New System.Drawing.Point(315, 18)
        Me.TxtStatusPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStatusPedido.Name = "TxtStatusPedido"
        Me.TxtStatusPedido.Size = New System.Drawing.Size(57, 20)
        Me.TxtStatusPedido.TabIndex = 142
        Me.TxtStatusPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "Status:"
        '
        'TxtIdPedido
        '
        Me.TxtIdPedido.Enabled = False
        Me.TxtIdPedido.Location = New System.Drawing.Point(81, 18)
        Me.TxtIdPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdPedido.Name = "TxtIdPedido"
        Me.TxtIdPedido.Size = New System.Drawing.Size(29, 20)
        Me.TxtIdPedido.TabIndex = 140
        Me.TxtIdPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.Enabled = False
        Me.TxtPesquisar.Location = New System.Drawing.Point(111, 18)
        Me.TxtPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(97, 20)
        Me.TxtPesquisar.TabIndex = 111
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Id/Pedido:"
        '
        'TxtTotalPedido
        '
        Me.TxtTotalPedido.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTotalPedido.Enabled = False
        Me.TxtTotalPedido.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPedido.ForeColor = System.Drawing.Color.Blue
        Me.TxtTotalPedido.Location = New System.Drawing.Point(178, 519)
        Me.TxtTotalPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalPedido.Multiline = True
        Me.TxtTotalPedido.Name = "TxtTotalPedido"
        Me.TxtTotalPedido.Size = New System.Drawing.Size(143, 20)
        Me.TxtTotalPedido.TabIndex = 138
        '
        'TxtNotaFiscal
        '
        Me.TxtNotaFiscal.Enabled = False
        Me.TxtNotaFiscal.Location = New System.Drawing.Point(109, 17)
        Me.TxtNotaFiscal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNotaFiscal.Name = "TxtNotaFiscal"
        Me.TxtNotaFiscal.Size = New System.Drawing.Size(83, 20)
        Me.TxtNotaFiscal.TabIndex = 97
        '
        'DataVecimento
        '
        Me.DataVecimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataVecimento.Location = New System.Drawing.Point(691, 17)
        Me.DataVecimento.Name = "DataVecimento"
        Me.DataVecimento.Size = New System.Drawing.Size(97, 20)
        Me.DataVecimento.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Nº Nota Fiscal:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(606, 18)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "Vencimento:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CbFornecedor)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.DataEmissao)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DataVecimento)
        Me.GroupBox3.Controls.Add(Me.TxtNotaFiscal)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(817, 50)
        Me.GroupBox3.TabIndex = 126
        Me.GroupBox3.TabStop = False
        '
        'CbFornecedor
        '
        Me.CbFornecedor.BackColor = System.Drawing.Color.White
        Me.CbFornecedor.Enabled = False
        Me.CbFornecedor.FormattingEnabled = True
        Me.CbFornecedor.Items.AddRange(New Object() {"Natura", "Boticário"})
        Me.CbFornecedor.Location = New System.Drawing.Point(315, 16)
        Me.CbFornecedor.Name = "CbFornecedor"
        Me.CbFornecedor.Size = New System.Drawing.Size(111, 21)
        Me.CbFornecedor.TabIndex = 128
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(230, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Fornecedor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(431, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Emisão:"
        '
        'DataEmissao
        '
        Me.DataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataEmissao.Location = New System.Drawing.Point(492, 17)
        Me.DataEmissao.Name = "DataEmissao"
        Me.DataEmissao.Size = New System.Drawing.Size(97, 20)
        Me.DataEmissao.TabIndex = 124
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TxtIdRegistro)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(143, 50)
        Me.GroupBox4.TabIndex = 139
        Me.GroupBox4.TabStop = False
        '
        'TxtIdRegistro
        '
        Me.TxtIdRegistro.Enabled = False
        Me.TxtIdRegistro.Location = New System.Drawing.Point(92, 17)
        Me.TxtIdRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdRegistro.Name = "TxtIdRegistro"
        Me.TxtIdRegistro.Size = New System.Drawing.Size(37, 20)
        Me.TxtIdRegistro.TabIndex = 129
        Me.TxtIdRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Id Registro:"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(29, 141)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(817, 356)
        Me.DataGrid.TabIndex = 154
        '
        'FrmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(872, 565)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TxtTotalPedido)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de Produtos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents TxtPesquisar As TextBox
    Friend WithEvents BtnPesqPedido As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTotalPedido As TextBox
    Friend WithEvents TxtNotaFiscal As TextBox
    Friend WithEvents DataVecimento As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataEmissao As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents CbFornecedor As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtIdRegistro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnNovo As Button
    Friend WithEvents TxtIdPedido As TextBox
    Friend WithEvents TxtStatusPedido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGrid As DataGridView
End Class
