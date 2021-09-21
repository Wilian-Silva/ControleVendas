<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNotasEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotasEntrada))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GboxPesquisar = New System.Windows.Forms.GroupBox()
        Me.BtnCacelarConsulta = New System.Windows.Forms.Button()
        Me.BtnSelecionarItem = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.GboxExluir = New System.Windows.Forms.GroupBox()
        Me.TxtFornecedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIdPedido = New System.Windows.Forms.TextBox()
        Me.LblIdPedido = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GboxPesProd = New System.Windows.Forms.GroupBox()
        Me.TxtPesquisa = New System.Windows.Forms.TextBox()
        Me.RbNota = New System.Windows.Forms.RadioButton()
        Me.RbFornecedor = New System.Windows.Forms.RadioButton()
        Me.RbPedido = New System.Windows.Forms.RadioButton()
        Me.GboxPesquisar.SuspendLayout()
        Me.GboxExluir.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxPesProd.SuspendLayout()
        Me.SuspendLayout()
        '
        'GboxPesquisar
        '
        Me.GboxPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesquisar.Controls.Add(Me.BtnCacelarConsulta)
        Me.GboxPesquisar.Controls.Add(Me.BtnSelecionarItem)
        Me.GboxPesquisar.Location = New System.Drawing.Point(415, 9)
        Me.GboxPesquisar.Name = "GboxPesquisar"
        Me.GboxPesquisar.Size = New System.Drawing.Size(79, 50)
        Me.GboxPesquisar.TabIndex = 142
        Me.GboxPesquisar.TabStop = False
        Me.GboxPesquisar.Visible = False
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
        Me.BtnSair.Location = New System.Drawing.Point(502, 17)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 165
        Me.BtnSair.TabStop = False
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
        Me.BtnExcluir.Location = New System.Drawing.Point(476, 9)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 164
        Me.BtnExcluir.TabStop = False
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(76, 20)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(34, 20)
        Me.TxtId.TabIndex = 145
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.BackColor = System.Drawing.Color.Transparent
        Me.LblId.Location = New System.Drawing.Point(7, 23)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(70, 13)
        Me.LblId.TabIndex = 146
        Me.LblId.Text = "Reg. Entrada"
        '
        'GboxExluir
        '
        Me.GboxExluir.BackColor = System.Drawing.Color.Transparent
        Me.GboxExluir.Controls.Add(Me.TxtFornecedor)
        Me.GboxExluir.Controls.Add(Me.Label2)
        Me.GboxExluir.Controls.Add(Me.TxtNota)
        Me.GboxExluir.Controls.Add(Me.Label1)
        Me.GboxExluir.Controls.Add(Me.TxtIdPedido)
        Me.GboxExluir.Controls.Add(Me.BtnExcluir)
        Me.GboxExluir.Controls.Add(Me.LblIdPedido)
        Me.GboxExluir.Controls.Add(Me.TxtId)
        Me.GboxExluir.Controls.Add(Me.LblId)
        Me.GboxExluir.Location = New System.Drawing.Point(26, 59)
        Me.GboxExluir.Name = "GboxExluir"
        Me.GboxExluir.Size = New System.Drawing.Size(518, 50)
        Me.GboxExluir.TabIndex = 147
        Me.GboxExluir.TabStop = False
        Me.GboxExluir.Text = "Dados da Entrada"
        '
        'TxtFornecedor
        '
        Me.TxtFornecedor.Enabled = False
        Me.TxtFornecedor.Location = New System.Drawing.Point(260, 20)
        Me.TxtFornecedor.Name = "TxtFornecedor"
        Me.TxtFornecedor.Size = New System.Drawing.Size(110, 20)
        Me.TxtFornecedor.TabIndex = 167
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(219, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "Fornec."
        '
        'TxtNota
        '
        Me.TxtNota.Enabled = False
        Me.TxtNota.Location = New System.Drawing.Point(166, 20)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(41, 20)
        Me.TxtNota.TabIndex = 165
        Me.TxtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(119, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Nº Nota"
        '
        'TxtIdPedido
        '
        Me.TxtIdPedido.Enabled = False
        Me.TxtIdPedido.Location = New System.Drawing.Point(429, 20)
        Me.TxtIdPedido.Name = "TxtIdPedido"
        Me.TxtIdPedido.Size = New System.Drawing.Size(34, 20)
        Me.TxtIdPedido.TabIndex = 147
        Me.TxtIdPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblIdPedido
        '
        Me.LblIdPedido.AutoSize = True
        Me.LblIdPedido.BackColor = System.Drawing.Color.Transparent
        Me.LblIdPedido.Location = New System.Drawing.Point(390, 23)
        Me.LblIdPedido.Name = "LblIdPedido"
        Me.LblIdPedido.Size = New System.Drawing.Size(40, 13)
        Me.LblIdPedido.TabIndex = 148
        Me.LblIdPedido.Text = "Pedido"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(23, 121)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(521, 209)
        Me.DataGrid.TabIndex = 148
        '
        'GboxPesProd
        '
        Me.GboxPesProd.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesProd.Controls.Add(Me.TxtPesquisa)
        Me.GboxPesProd.Controls.Add(Me.RbNota)
        Me.GboxPesProd.Controls.Add(Me.RbFornecedor)
        Me.GboxPesProd.Controls.Add(Me.RbPedido)
        Me.GboxPesProd.Location = New System.Drawing.Point(23, 9)
        Me.GboxPesProd.Name = "GboxPesProd"
        Me.GboxPesProd.Size = New System.Drawing.Size(384, 50)
        Me.GboxPesProd.TabIndex = 160
        Me.GboxPesProd.TabStop = False
        Me.GboxPesProd.Text = "Pesquisar"
        '
        'TxtPesquisa
        '
        Me.TxtPesquisa.Location = New System.Drawing.Point(220, 18)
        Me.TxtPesquisa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisa.Name = "TxtPesquisa"
        Me.TxtPesquisa.Size = New System.Drawing.Size(142, 20)
        Me.TxtPesquisa.TabIndex = 160
        '
        'RbNota
        '
        Me.RbNota.AutoSize = True
        Me.RbNota.Location = New System.Drawing.Point(157, 20)
        Me.RbNota.Name = "RbNota"
        Me.RbNota.Size = New System.Drawing.Size(48, 17)
        Me.RbNota.TabIndex = 159
        Me.RbNota.Text = "Nota"
        Me.RbNota.UseVisualStyleBackColor = True
        '
        'RbFornecedor
        '
        Me.RbFornecedor.AutoSize = True
        Me.RbFornecedor.Location = New System.Drawing.Point(73, 20)
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
        Me.RbPedido.Location = New System.Drawing.Point(7, 20)
        Me.RbPedido.Name = "RbPedido"
        Me.RbPedido.Size = New System.Drawing.Size(58, 17)
        Me.RbPedido.TabIndex = 157
        Me.RbPedido.TabStop = True
        Me.RbPedido.Text = "Pedido"
        Me.RbPedido.UseVisualStyleBackColor = True
        '
        'FrmNotasEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(563, 357)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.GboxPesProd)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.GboxExluir)
        Me.Controls.Add(Me.GboxPesquisar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmNotasEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas de Entrada"
        Me.GboxPesquisar.ResumeLayout(False)
        Me.GboxExluir.ResumeLayout(False)
        Me.GboxExluir.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxPesProd.ResumeLayout(False)
        Me.GboxPesProd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents GboxPesquisar As GroupBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents LblId As Label
    Friend WithEvents GboxExluir As GroupBox
    Friend WithEvents TxtIdPedido As TextBox
    Friend WithEvents LblIdPedido As Label
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents GboxPesProd As GroupBox
    Friend WithEvents TxtPesquisa As TextBox
    Friend WithEvents RbNota As RadioButton
    Friend WithEvents RbFornecedor As RadioButton
    Friend WithEvents RbPedido As RadioButton
    Friend WithEvents BtnCacelarConsulta As Button
    Friend WithEvents BtnSelecionarItem As Button
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFornecedor As TextBox
    Friend WithEvents Label2 As Label
End Class
