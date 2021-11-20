<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendaCabecalho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendaCabecalho))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCacelarConsulta = New System.Windows.Forms.Button()
        Me.BtnSelecionarItem = New System.Windows.Forms.Button()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GboxExluir = New System.Windows.Forms.GroupBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSaldo_venda = New System.Windows.Forms.TextBox()
        Me.TxtParcela = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRegVenda = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.GboxPesProd = New System.Windows.Forms.GroupBox()
        Me.RbVenda = New System.Windows.Forms.RadioButton()
        Me.TxtPesquisa = New System.Windows.Forms.TextBox()
        Me.RbFornecedor = New System.Windows.Forms.RadioButton()
        Me.RbPedido = New System.Windows.Forms.RadioButton()
        Me.GboxPesquisar = New System.Windows.Forms.GroupBox()
        Me.BtnSair = New System.Windows.Forms.Button()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxExluir.SuspendLayout()
        Me.GboxPesProd.SuspendLayout()
        Me.GboxPesquisar.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCacelarConsulta
        '
        Me.BtnCacelarConsulta.AccessibleDescription = ""
        Me.BtnCacelarConsulta.AccessibleName = "Adicionar"
        Me.BtnCacelarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCacelarConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCacelarConsulta.FlatAppearance.BorderSize = 0
        Me.BtnCacelarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCacelarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCacelarConsulta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCacelarConsulta.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCacelarConsulta.Image = CType(resources.GetObject("BtnCacelarConsulta.Image"), System.Drawing.Image)
        Me.BtnCacelarConsulta.Location = New System.Drawing.Point(40, 9)
        Me.BtnCacelarConsulta.Name = "BtnCacelarConsulta"
        Me.BtnCacelarConsulta.Size = New System.Drawing.Size(35, 35)
        Me.BtnCacelarConsulta.TabIndex = 153
        Me.BtnCacelarConsulta.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnCacelarConsulta, "Cancelar")
        Me.BtnCacelarConsulta.UseVisualStyleBackColor = True
        '
        'BtnSelecionarItem
        '
        Me.BtnSelecionarItem.AccessibleDescription = ""
        Me.BtnSelecionarItem.AccessibleName = "Adicionar"
        Me.BtnSelecionarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSelecionarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSelecionarItem.FlatAppearance.BorderSize = 0
        Me.BtnSelecionarItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSelecionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelecionarItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelecionarItem.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSelecionarItem.Image = CType(resources.GetObject("BtnSelecionarItem.Image"), System.Drawing.Image)
        Me.BtnSelecionarItem.Location = New System.Drawing.Point(4, 8)
        Me.BtnSelecionarItem.Name = "BtnSelecionarItem"
        Me.BtnSelecionarItem.Size = New System.Drawing.Size(35, 35)
        Me.BtnSelecionarItem.TabIndex = 152
        Me.BtnSelecionarItem.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSelecionarItem, "Selecionar ")
        Me.BtnSelecionarItem.UseVisualStyleBackColor = True
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        Me.DataGrid.Location = New System.Drawing.Point(22, 111)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(833, 296)
        Me.DataGrid.TabIndex = 153
        '
        'GboxExluir
        '
        Me.GboxExluir.BackColor = System.Drawing.Color.Transparent
        Me.GboxExluir.Controls.Add(Me.TxtCliente)
        Me.GboxExluir.Controls.Add(Me.Label3)
        Me.GboxExluir.Controls.Add(Me.TxtSaldo_venda)
        Me.GboxExluir.Controls.Add(Me.TxtParcela)
        Me.GboxExluir.Controls.Add(Me.Label4)
        Me.GboxExluir.Controls.Add(Me.Label5)
        Me.GboxExluir.Controls.Add(Me.TxtRegVenda)
        Me.GboxExluir.Controls.Add(Me.LblId)
        Me.GboxExluir.Location = New System.Drawing.Point(22, 55)
        Me.GboxExluir.Name = "GboxExluir"
        Me.GboxExluir.Size = New System.Drawing.Size(833, 50)
        Me.GboxExluir.TabIndex = 154
        Me.GboxExluir.TabStop = False
        Me.GboxExluir.Text = "Dados da Venda"
        '
        'TxtCliente
        '
        Me.TxtCliente.Enabled = False
        Me.TxtCliente.Location = New System.Drawing.Point(402, 19)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(181, 20)
        Me.TxtCliente.TabIndex = 167
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(359, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "Cliente"
        '
        'TxtSaldo_venda
        '
        Me.TxtSaldo_venda.Enabled = False
        Me.TxtSaldo_venda.Location = New System.Drawing.Point(719, 16)
        Me.TxtSaldo_venda.Name = "TxtSaldo_venda"
        Me.TxtSaldo_venda.Size = New System.Drawing.Size(76, 20)
        Me.TxtSaldo_venda.TabIndex = 165
        '
        'TxtParcela
        '
        Me.TxtParcela.Enabled = False
        Me.TxtParcela.Location = New System.Drawing.Point(240, 19)
        Me.TxtParcela.Name = "TxtParcela"
        Me.TxtParcela.Size = New System.Drawing.Size(77, 20)
        Me.TxtParcela.TabIndex = 147
        Me.TxtParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(682, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Saldo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(194, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Parcela"
        '
        'TxtRegVenda
        '
        Me.TxtRegVenda.Enabled = False
        Me.TxtRegVenda.Location = New System.Drawing.Point(66, 20)
        Me.TxtRegVenda.Name = "TxtRegVenda"
        Me.TxtRegVenda.Size = New System.Drawing.Size(80, 20)
        Me.TxtRegVenda.TabIndex = 145
        Me.TxtRegVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.BackColor = System.Drawing.Color.Transparent
        Me.LblId.Location = New System.Drawing.Point(11, 23)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(53, 13)
        Me.LblId.TabIndex = 146
        Me.LblId.Text = "Nº Venda"
        '
        'GboxPesProd
        '
        Me.GboxPesProd.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesProd.Controls.Add(Me.RbVenda)
        Me.GboxPesProd.Controls.Add(Me.TxtPesquisa)
        Me.GboxPesProd.Controls.Add(Me.RbFornecedor)
        Me.GboxPesProd.Controls.Add(Me.RbPedido)
        Me.GboxPesProd.Location = New System.Drawing.Point(22, 4)
        Me.GboxPesProd.Name = "GboxPesProd"
        Me.GboxPesProd.Size = New System.Drawing.Size(517, 50)
        Me.GboxPesProd.TabIndex = 167
        Me.GboxPesProd.TabStop = False
        Me.GboxPesProd.Text = "Pesquisar"
        '
        'RbVenda
        '
        Me.RbVenda.AutoSize = True
        Me.RbVenda.Location = New System.Drawing.Point(221, 19)
        Me.RbVenda.Name = "RbVenda"
        Me.RbVenda.Size = New System.Drawing.Size(71, 17)
        Me.RbVenda.TabIndex = 161
        Me.RbVenda.Text = "Nº Venda"
        Me.RbVenda.UseVisualStyleBackColor = True
        '
        'TxtPesquisa
        '
        Me.TxtPesquisa.Location = New System.Drawing.Point(325, 18)
        Me.TxtPesquisa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisa.Name = "TxtPesquisa"
        Me.TxtPesquisa.Size = New System.Drawing.Size(177, 20)
        Me.TxtPesquisa.TabIndex = 160
        '
        'RbFornecedor
        '
        Me.RbFornecedor.AutoSize = True
        Me.RbFornecedor.Checked = True
        Me.RbFornecedor.Location = New System.Drawing.Point(114, 20)
        Me.RbFornecedor.Name = "RbFornecedor"
        Me.RbFornecedor.Size = New System.Drawing.Size(88, 17)
        Me.RbFornecedor.TabIndex = 158
        Me.RbFornecedor.TabStop = True
        Me.RbFornecedor.Text = "Nome Cliente"
        Me.RbFornecedor.UseVisualStyleBackColor = True
        '
        'RbPedido
        '
        Me.RbPedido.AutoSize = True
        Me.RbPedido.Location = New System.Drawing.Point(7, 20)
        Me.RbPedido.Name = "RbPedido"
        Me.RbPedido.Size = New System.Drawing.Size(82, 17)
        Me.RbPedido.TabIndex = 157
        Me.RbPedido.Text = "Cód. Cliente"
        Me.RbPedido.UseVisualStyleBackColor = True
        '
        'GboxPesquisar
        '
        Me.GboxPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesquisar.Controls.Add(Me.BtnCacelarConsulta)
        Me.GboxPesquisar.Controls.Add(Me.BtnSelecionarItem)
        Me.GboxPesquisar.Location = New System.Drawing.Point(545, 4)
        Me.GboxPesquisar.Name = "GboxPesquisar"
        Me.GboxPesquisar.Size = New System.Drawing.Size(79, 50)
        Me.GboxPesquisar.TabIndex = 166
        Me.GboxPesquisar.TabStop = False
        Me.GboxPesquisar.Visible = False
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
        Me.BtnSair.Location = New System.Drawing.Point(820, 19)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 166
        Me.BtnSair.TabStop = False
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'FrmVendaCabecalho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(878, 419)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.GboxPesProd)
        Me.Controls.Add(Me.GboxPesquisar)
        Me.Controls.Add(Me.GboxExluir)
        Me.Controls.Add(Me.DataGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmVendaCabecalho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas Efetuadas"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxExluir.ResumeLayout(False)
        Me.GboxExluir.PerformLayout()
        Me.GboxPesProd.ResumeLayout(False)
        Me.GboxPesProd.PerformLayout()
        Me.GboxPesquisar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents GboxExluir As GroupBox
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSaldo_venda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtParcela As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRegVenda As TextBox
    Friend WithEvents LblId As Label
    Friend WithEvents GboxPesProd As GroupBox
    Friend WithEvents TxtPesquisa As TextBox
    Friend WithEvents RbFornecedor As RadioButton
    Friend WithEvents RbPedido As RadioButton
    Friend WithEvents GboxPesquisar As GroupBox
    Friend WithEvents BtnCacelarConsulta As Button
    Friend WithEvents BtnSelecionarItem As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents RbVenda As RadioButton
End Class
