﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPedidoCabecalho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedidoCabecalho))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCacelarConsulta = New System.Windows.Forms.Button()
        Me.BtnSelecionarItem = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.TxtIdPedido = New System.Windows.Forms.TextBox()
        Me.LblIdPedido = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GboxPesPed = New System.Windows.Forms.GroupBox()
        Me.GboxExcluir = New System.Windows.Forms.GroupBox()
        Me.GboxPesProd = New System.Windows.Forms.GroupBox()
        Me.TxtPesquisa = New System.Windows.Forms.TextBox()
        Me.RbStatus = New System.Windows.Forms.RadioButton()
        Me.RbFornecedor = New System.Windows.Forms.RadioButton()
        Me.RbPedido = New System.Windows.Forms.RadioButton()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxPesPed.SuspendLayout()
        Me.GboxExcluir.SuspendLayout()
        Me.GboxPesProd.SuspendLayout()
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
        Me.BtnCacelarConsulta.Location = New System.Drawing.Point(56, 9)
        Me.BtnCacelarConsulta.Name = "BtnCacelarConsulta"
        Me.BtnCacelarConsulta.Size = New System.Drawing.Size(35, 35)
        Me.BtnCacelarConsulta.TabIndex = 151
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
        Me.BtnSelecionarItem.Location = New System.Drawing.Point(13, 8)
        Me.BtnSelecionarItem.Name = "BtnSelecionarItem"
        Me.BtnSelecionarItem.Size = New System.Drawing.Size(35, 35)
        Me.BtnSelecionarItem.TabIndex = 150
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
        Me.BtnSair.Location = New System.Drawing.Point(615, 17)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 167
        Me.BtnSair.TabStop = False
        Me.BtnSair.UseVisualStyleBackColor = True
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
        Me.BtnExcluir.Location = New System.Drawing.Point(57, 10)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 166
        Me.BtnExcluir.TabStop = False
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'TxtIdPedido
        '
        Me.TxtIdPedido.Enabled = False
        Me.TxtIdPedido.Location = New System.Drawing.Point(13, 23)
        Me.TxtIdPedido.Name = "TxtIdPedido"
        Me.TxtIdPedido.Size = New System.Drawing.Size(36, 20)
        Me.TxtIdPedido.TabIndex = 147
        Me.TxtIdPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblIdPedido
        '
        Me.LblIdPedido.AutoSize = True
        Me.LblIdPedido.BackColor = System.Drawing.Color.Transparent
        Me.LblIdPedido.Location = New System.Drawing.Point(10, 11)
        Me.LblIdPedido.Name = "LblIdPedido"
        Me.LblIdPedido.Size = New System.Drawing.Size(44, 13)
        Me.LblIdPedido.TabIndex = 148
        Me.LblIdPedido.Text = "Nº Ped."
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
        Me.DataGrid.Location = New System.Drawing.Point(20, 69)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(630, 229)
        Me.DataGrid.TabIndex = 149
        '
        'GboxPesPed
        '
        Me.GboxPesPed.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesPed.Controls.Add(Me.BtnCacelarConsulta)
        Me.GboxPesPed.Controls.Add(Me.BtnSelecionarItem)
        Me.GboxPesPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GboxPesPed.Location = New System.Drawing.Point(396, 6)
        Me.GboxPesPed.Name = "GboxPesPed"
        Me.GboxPesPed.Size = New System.Drawing.Size(105, 50)
        Me.GboxPesPed.TabIndex = 151
        Me.GboxPesPed.TabStop = False
        Me.GboxPesPed.Visible = False
        '
        'GboxExcluir
        '
        Me.GboxExcluir.BackColor = System.Drawing.Color.Transparent
        Me.GboxExcluir.Controls.Add(Me.BtnExcluir)
        Me.GboxExcluir.Controls.Add(Me.TxtIdPedido)
        Me.GboxExcluir.Controls.Add(Me.LblIdPedido)
        Me.GboxExcluir.Location = New System.Drawing.Point(507, 6)
        Me.GboxExcluir.Name = "GboxExcluir"
        Me.GboxExcluir.Size = New System.Drawing.Size(102, 50)
        Me.GboxExcluir.TabIndex = 167
        Me.GboxExcluir.TabStop = False
        Me.GboxExcluir.Visible = False
        '
        'GboxPesProd
        '
        Me.GboxPesProd.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesProd.Controls.Add(Me.TxtPesquisa)
        Me.GboxPesProd.Controls.Add(Me.RbStatus)
        Me.GboxPesProd.Controls.Add(Me.RbFornecedor)
        Me.GboxPesProd.Controls.Add(Me.RbPedido)
        Me.GboxPesProd.Location = New System.Drawing.Point(20, 6)
        Me.GboxPesProd.Name = "GboxPesProd"
        Me.GboxPesProd.Size = New System.Drawing.Size(370, 50)
        Me.GboxPesProd.TabIndex = 168
        Me.GboxPesProd.TabStop = False
        Me.GboxPesProd.Text = "Pesquisar"
        '
        'TxtPesquisa
        '
        Me.TxtPesquisa.Location = New System.Drawing.Point(269, 18)
        Me.TxtPesquisa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisa.Name = "TxtPesquisa"
        Me.TxtPesquisa.Size = New System.Drawing.Size(87, 20)
        Me.TxtPesquisa.TabIndex = 160
        '
        'RbStatus
        '
        Me.RbStatus.AutoSize = True
        Me.RbStatus.Location = New System.Drawing.Point(199, 20)
        Me.RbStatus.Name = "RbStatus"
        Me.RbStatus.Size = New System.Drawing.Size(55, 17)
        Me.RbStatus.TabIndex = 159
        Me.RbStatus.Text = "Status"
        Me.RbStatus.UseVisualStyleBackColor = True
        '
        'RbFornecedor
        '
        Me.RbFornecedor.AutoSize = True
        Me.RbFornecedor.Location = New System.Drawing.Point(107, 20)
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
        Me.RbPedido.Size = New System.Drawing.Size(89, 17)
        Me.RbPedido.TabIndex = 157
        Me.RbPedido.TabStop = True
        Me.RbPedido.Text = "Desc. Pedido"
        Me.RbPedido.UseVisualStyleBackColor = True
        '
        'FrmPedidoCabecalho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(667, 325)
        Me.Controls.Add(Me.GboxPesProd)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.GboxExcluir)
        Me.Controls.Add(Me.GboxPesPed)
        Me.Controls.Add(Me.DataGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPedidoCabecalho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos de Compra"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxPesPed.ResumeLayout(False)
        Me.GboxExcluir.ResumeLayout(False)
        Me.GboxExcluir.PerformLayout()
        Me.GboxPesProd.ResumeLayout(False)
        Me.GboxPesProd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents TxtIdPedido As TextBox
    Friend WithEvents LblIdPedido As Label
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents GboxPesPed As GroupBox
    Friend WithEvents BtnCacelarConsulta As Button
    Friend WithEvents BtnSelecionarItem As Button
    Friend WithEvents GboxExcluir As GroupBox
    Friend WithEvents GboxPesProd As GroupBox
    Friend WithEvents TxtPesquisa As TextBox
    Friend WithEvents RbFornecedor As RadioButton
    Friend WithEvents RbPedido As RadioButton
    Friend WithEvents RbStatus As RadioButton
End Class
