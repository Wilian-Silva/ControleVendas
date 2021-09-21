<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPagamentoEfetuado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagamentoEfetuado))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.TxtIdReg = New System.Windows.Forms.TextBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GboxPesProd = New System.Windows.Forms.GroupBox()
        Me.TxtPesquisar = New System.Windows.Forms.TextBox()
        Me.RbNota = New System.Windows.Forms.RadioButton()
        Me.RbFornecedor = New System.Windows.Forms.RadioButton()
        Me.RbPedido = New System.Windows.Forms.RadioButton()
        Me.GBoxExluir = New System.Windows.Forms.GroupBox()
        Me.TxtValorParcela = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtValorPago = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtParcela = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdRegDup = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxPesProd.SuspendLayout()
        Me.GBoxExluir.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BtnSair.Location = New System.Drawing.Point(22, 9)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 167
        Me.BtnSair.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSair, "Sair")
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.AccessibleDescription = ""
        Me.BtnExcluir.AccessibleName = "Adicionar"
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.Enabled = False
        Me.BtnExcluir.FlatAppearance.BorderSize = 0
        Me.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(586, 9)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 166
        Me.BtnExcluir.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnExcluir, "Excluir")
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BtnSair)
        Me.GroupBox3.Location = New System.Drawing.Point(584, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(71, 50)
        Me.GroupBox3.TabIndex = 148
        Me.GroupBox3.TabStop = False
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.BackColor = System.Drawing.Color.Transparent
        Me.LblId.Location = New System.Drawing.Point(8, 22)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(47, 13)
        Me.LblId.TabIndex = 150
        Me.LblId.Text = "Id. Pgto."
        '
        'TxtIdReg
        '
        Me.TxtIdReg.Enabled = False
        Me.TxtIdReg.Location = New System.Drawing.Point(54, 19)
        Me.TxtIdReg.Name = "TxtIdReg"
        Me.TxtIdReg.Size = New System.Drawing.Size(30, 20)
        Me.TxtIdReg.TabIndex = 149
        Me.TxtIdReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.DataGrid.Location = New System.Drawing.Point(21, 116)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(634, 295)
        Me.DataGrid.TabIndex = 151
        '
        'GboxPesProd
        '
        Me.GboxPesProd.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesProd.Controls.Add(Me.TxtPesquisar)
        Me.GboxPesProd.Controls.Add(Me.RbNota)
        Me.GboxPesProd.Controls.Add(Me.RbFornecedor)
        Me.GboxPesProd.Controls.Add(Me.RbPedido)
        Me.GboxPesProd.Location = New System.Drawing.Point(24, 6)
        Me.GboxPesProd.Name = "GboxPesProd"
        Me.GboxPesProd.Size = New System.Drawing.Size(554, 50)
        Me.GboxPesProd.TabIndex = 161
        Me.GboxPesProd.TabStop = False
        Me.GboxPesProd.Text = "Pesquisar"
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.Location = New System.Drawing.Point(253, 17)
        Me.TxtPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(266, 20)
        Me.TxtPesquisar.TabIndex = 160
        '
        'RbNota
        '
        Me.RbNota.AutoSize = True
        Me.RbNota.Location = New System.Drawing.Point(172, 20)
        Me.RbNota.Name = "RbNota"
        Me.RbNota.Size = New System.Drawing.Size(63, 17)
        Me.RbNota.TabIndex = 159
        Me.RbNota.Text = "Nº Nota"
        Me.RbNota.UseVisualStyleBackColor = True
        '
        'RbFornecedor
        '
        Me.RbFornecedor.AutoSize = True
        Me.RbFornecedor.Location = New System.Drawing.Point(81, 20)
        Me.RbFornecedor.Name = "RbFornecedor"
        Me.RbFornecedor.Size = New System.Drawing.Size(79, 17)
        Me.RbFornecedor.TabIndex = 158
        Me.RbFornecedor.Text = "Fornecedor"
        Me.RbFornecedor.UseVisualStyleBackColor = True
        '
        'RbPedido
        '
        Me.RbPedido.AutoSize = True
        Me.RbPedido.Checked = True
        Me.RbPedido.Location = New System.Drawing.Point(14, 20)
        Me.RbPedido.Name = "RbPedido"
        Me.RbPedido.Size = New System.Drawing.Size(58, 17)
        Me.RbPedido.TabIndex = 157
        Me.RbPedido.TabStop = True
        Me.RbPedido.Text = "Pedido"
        Me.RbPedido.UseVisualStyleBackColor = True
        '
        'GBoxExluir
        '
        Me.GBoxExluir.BackColor = System.Drawing.Color.Transparent
        Me.GBoxExluir.Controls.Add(Me.TxtValorParcela)
        Me.GBoxExluir.Controls.Add(Me.Label5)
        Me.GBoxExluir.Controls.Add(Me.TxtValorPago)
        Me.GBoxExluir.Controls.Add(Me.Label4)
        Me.GBoxExluir.Controls.Add(Me.TxtParcela)
        Me.GBoxExluir.Controls.Add(Me.Label3)
        Me.GBoxExluir.Controls.Add(Me.TxtNota)
        Me.GBoxExluir.Controls.Add(Me.Label2)
        Me.GBoxExluir.Controls.Add(Me.TxtIdRegDup)
        Me.GBoxExluir.Controls.Add(Me.Label1)
        Me.GBoxExluir.Controls.Add(Me.TxtIdReg)
        Me.GBoxExluir.Controls.Add(Me.BtnExcluir)
        Me.GBoxExluir.Controls.Add(Me.LblId)
        Me.GBoxExluir.Location = New System.Drawing.Point(24, 55)
        Me.GBoxExluir.Name = "GBoxExluir"
        Me.GBoxExluir.Size = New System.Drawing.Size(631, 50)
        Me.GBoxExluir.TabIndex = 162
        Me.GBoxExluir.TabStop = False
        Me.GBoxExluir.Text = "Dados do Pagamento"
        '
        'TxtValorParcela
        '
        Me.TxtValorParcela.Enabled = False
        Me.TxtValorParcela.Location = New System.Drawing.Point(411, 19)
        Me.TxtValorParcela.Name = "TxtValorParcela"
        Me.TxtValorParcela.Size = New System.Drawing.Size(54, 20)
        Me.TxtValorParcela.TabIndex = 175
        Me.TxtValorParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(349, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 176
        Me.Label5.Text = "Vlr. Parcela"
        '
        'TxtValorPago
        '
        Me.TxtValorPago.Enabled = False
        Me.TxtValorPago.Location = New System.Drawing.Point(522, 19)
        Me.TxtValorPago.Name = "TxtValorPago"
        Me.TxtValorPago.Size = New System.Drawing.Size(54, 20)
        Me.TxtValorPago.TabIndex = 173
        Me.TxtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(473, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Vlr. Pago"
        '
        'TxtParcela
        '
        Me.TxtParcela.Enabled = False
        Me.TxtParcela.Location = New System.Drawing.Point(308, 19)
        Me.TxtParcela.Name = "TxtParcela"
        Me.TxtParcela.Size = New System.Drawing.Size(30, 20)
        Me.TxtParcela.TabIndex = 171
        Me.TxtParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(265, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Parcela"
        '
        'TxtNota
        '
        Me.TxtNota.Enabled = False
        Me.TxtNota.Location = New System.Drawing.Point(215, 19)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(44, 20)
        Me.TxtNota.TabIndex = 169
        Me.TxtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(169, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "Nº Nota"
        '
        'TxtIdRegDup
        '
        Me.TxtIdRegDup.Enabled = False
        Me.TxtIdRegDup.Location = New System.Drawing.Point(132, 19)
        Me.TxtIdRegDup.Name = "TxtIdRegDup"
        Me.TxtIdRegDup.Size = New System.Drawing.Size(30, 20)
        Me.TxtIdRegDup.TabIndex = 167
        Me.TxtIdRegDup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(89, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Id.Dupl."
        '
        'FrmPagamentoEfetuado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(677, 431)
        Me.Controls.Add(Me.GBoxExluir)
        Me.Controls.Add(Me.GboxPesProd)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPagamentoEfetuado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagamentos Efetuados"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxPesProd.ResumeLayout(False)
        Me.GboxPesProd.PerformLayout()
        Me.GBoxExluir.ResumeLayout(False)
        Me.GBoxExluir.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LblId As Label
    Friend WithEvents TxtIdReg As TextBox
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents GboxPesProd As GroupBox
    Friend WithEvents TxtPesquisar As TextBox
    Friend WithEvents RbNota As RadioButton
    Friend WithEvents RbFornecedor As RadioButton
    Friend WithEvents RbPedido As RadioButton
    Friend WithEvents GBoxExluir As GroupBox
    Friend WithEvents TxtIdRegDup As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtValorPago As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtParcela As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtValorParcela As TextBox
    Friend WithEvents Label5 As Label
End Class
