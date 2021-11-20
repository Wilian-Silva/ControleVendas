<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntradas
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntradas))
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.GboxPesProd = New System.Windows.Forms.GroupBox()
        Me.TxtPesquisa = New System.Windows.Forms.TextBox()
        Me.RbNota = New System.Windows.Forms.RadioButton()
        Me.RbFornecedor = New System.Windows.Forms.RadioButton()
        Me.RbPedido = New System.Windows.Forms.RadioButton()
        Me.GboxPesquisar = New System.Windows.Forms.GroupBox()
        Me.BtnCacelarConsulta = New System.Windows.Forms.Button()
        Me.BtnSelecionarItem = New System.Windows.Forms.Button()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxPesProd.SuspendLayout()
        Me.GboxPesquisar.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(12, 78)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(600, 251)
        Me.DataGrid.TabIndex = 149
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
        Me.BtnSair.Location = New System.Drawing.Point(565, 22)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 168
        Me.BtnSair.TabStop = False
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'GboxPesProd
        '
        Me.GboxPesProd.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesProd.Controls.Add(Me.TxtPesquisa)
        Me.GboxPesProd.Controls.Add(Me.RbNota)
        Me.GboxPesProd.Controls.Add(Me.RbFornecedor)
        Me.GboxPesProd.Controls.Add(Me.RbPedido)
        Me.GboxPesProd.Location = New System.Drawing.Point(12, 12)
        Me.GboxPesProd.Name = "GboxPesProd"
        Me.GboxPesProd.Size = New System.Drawing.Size(410, 50)
        Me.GboxPesProd.TabIndex = 167
        Me.GboxPesProd.TabStop = False
        Me.GboxPesProd.Text = "Pesquisar"
        '
        'TxtPesquisa
        '
        Me.TxtPesquisa.Location = New System.Drawing.Point(241, 18)
        Me.TxtPesquisa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisa.Name = "TxtPesquisa"
        Me.TxtPesquisa.Size = New System.Drawing.Size(142, 20)
        Me.TxtPesquisa.TabIndex = 160
        '
        'RbNota
        '
        Me.RbNota.AutoSize = True
        Me.RbNota.Location = New System.Drawing.Point(178, 20)
        Me.RbNota.Name = "RbNota"
        Me.RbNota.Size = New System.Drawing.Size(48, 17)
        Me.RbNota.TabIndex = 159
        Me.RbNota.Text = "Nota"
        Me.RbNota.UseVisualStyleBackColor = True
        '
        'RbFornecedor
        '
        Me.RbFornecedor.AutoSize = True
        Me.RbFornecedor.Location = New System.Drawing.Point(94, 20)
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
        Me.RbPedido.Location = New System.Drawing.Point(28, 20)
        Me.RbPedido.Name = "RbPedido"
        Me.RbPedido.Size = New System.Drawing.Size(58, 17)
        Me.RbPedido.TabIndex = 157
        Me.RbPedido.TabStop = True
        Me.RbPedido.Text = "Pedido"
        Me.RbPedido.UseVisualStyleBackColor = True
        '
        'GboxPesquisar
        '
        Me.GboxPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesquisar.Controls.Add(Me.BtnCacelarConsulta)
        Me.GboxPesquisar.Controls.Add(Me.BtnSelecionarItem)
        Me.GboxPesquisar.Location = New System.Drawing.Point(434, 12)
        Me.GboxPesquisar.Name = "GboxPesquisar"
        Me.GboxPesquisar.Size = New System.Drawing.Size(110, 50)
        Me.GboxPesquisar.TabIndex = 166
        Me.GboxPesquisar.TabStop = False
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
        Me.BtnCacelarConsulta.Location = New System.Drawing.Point(64, 9)
        Me.BtnCacelarConsulta.Name = "BtnCacelarConsulta"
        Me.BtnCacelarConsulta.Size = New System.Drawing.Size(35, 35)
        Me.BtnCacelarConsulta.TabIndex = 153
        Me.BtnCacelarConsulta.TabStop = False
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
        Me.BtnSelecionarItem.Location = New System.Drawing.Point(18, 8)
        Me.BtnSelecionarItem.Name = "BtnSelecionarItem"
        Me.BtnSelecionarItem.Size = New System.Drawing.Size(35, 35)
        Me.BtnSelecionarItem.TabIndex = 152
        Me.BtnSelecionarItem.TabStop = False
        Me.BtnSelecionarItem.UseVisualStyleBackColor = True
        '
        'FrmEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 357)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.GboxPesProd)
        Me.Controls.Add(Me.GboxPesquisar)
        Me.Controls.Add(Me.DataGrid)
        Me.Name = "FrmEntradas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas Entrada"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxPesProd.ResumeLayout(False)
        Me.GboxPesProd.PerformLayout()
        Me.GboxPesquisar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents BtnSair As Button
    Friend WithEvents GboxPesProd As GroupBox
    Friend WithEvents TxtPesquisa As TextBox
    Friend WithEvents RbNota As RadioButton
    Friend WithEvents RbFornecedor As RadioButton
    Friend WithEvents RbPedido As RadioButton
    Friend WithEvents GboxPesquisar As GroupBox
    Friend WithEvents BtnCacelarConsulta As Button
    Friend WithEvents BtnSelecionarItem As Button
End Class
