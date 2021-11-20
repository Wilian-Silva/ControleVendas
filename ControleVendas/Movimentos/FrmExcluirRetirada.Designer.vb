<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExcluirRetirada
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExcluirRetirada))
        Me.DataGridRetiradas = New System.Windows.Forms.DataGridView()
        Me.GboxEditar = New System.Windows.Forms.GroupBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.GboxPesProd = New System.Windows.Forms.GroupBox()
        Me.TxtPesquisa = New System.Windows.Forms.TextBox()
        Me.RbPortador = New System.Windows.Forms.RadioButton()
        Me.RbNfe = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridRetiradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxEditar.SuspendLayout()
        Me.GboxPesProd.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridRetiradas
        '
        Me.DataGridRetiradas.AllowUserToAddRows = False
        Me.DataGridRetiradas.AllowUserToDeleteRows = False
        Me.DataGridRetiradas.AllowUserToResizeColumns = False
        Me.DataGridRetiradas.AllowUserToResizeRows = False
        Me.DataGridRetiradas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridRetiradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRetiradas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridRetiradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridRetiradas.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridRetiradas.EnableHeadersVisualStyles = False
        Me.DataGridRetiradas.Location = New System.Drawing.Point(22, 61)
        Me.DataGridRetiradas.MultiSelect = False
        Me.DataGridRetiradas.Name = "DataGridRetiradas"
        Me.DataGridRetiradas.ReadOnly = True
        Me.DataGridRetiradas.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGridRetiradas.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridRetiradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridRetiradas.Size = New System.Drawing.Size(642, 277)
        Me.DataGridRetiradas.TabIndex = 154
        '
        'GboxEditar
        '
        Me.GboxEditar.BackColor = System.Drawing.Color.Transparent
        Me.GboxEditar.Controls.Add(Me.TxtId)
        Me.GboxEditar.Controls.Add(Me.BtnSair)
        Me.GboxEditar.Controls.Add(Me.BtnExcluir)
        Me.GboxEditar.Location = New System.Drawing.Point(501, 5)
        Me.GboxEditar.Name = "GboxEditar"
        Me.GboxEditar.Size = New System.Drawing.Size(163, 50)
        Me.GboxEditar.TabIndex = 155
        Me.GboxEditar.TabStop = False
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(10, 20)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(44, 20)
        Me.TxtId.TabIndex = 158
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtId.Visible = False
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
        Me.BtnSair.Location = New System.Drawing.Point(110, 10)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 154
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
        Me.BtnExcluir.Location = New System.Drawing.Point(69, 9)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 153
        Me.BtnExcluir.TabStop = False
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'GboxPesProd
        '
        Me.GboxPesProd.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesProd.Controls.Add(Me.TxtPesquisa)
        Me.GboxPesProd.Controls.Add(Me.RbPortador)
        Me.GboxPesProd.Controls.Add(Me.RbNfe)
        Me.GboxPesProd.Location = New System.Drawing.Point(22, 5)
        Me.GboxPesProd.Name = "GboxPesProd"
        Me.GboxPesProd.Size = New System.Drawing.Size(451, 50)
        Me.GboxPesProd.TabIndex = 169
        Me.GboxPesProd.TabStop = False
        Me.GboxPesProd.Text = "Pesquisar"
        '
        'TxtPesquisa
        '
        Me.TxtPesquisa.Location = New System.Drawing.Point(232, 17)
        Me.TxtPesquisa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisa.Name = "TxtPesquisa"
        Me.TxtPesquisa.Size = New System.Drawing.Size(166, 20)
        Me.TxtPesquisa.TabIndex = 160
        '
        'RbPortador
        '
        Me.RbPortador.AutoSize = True
        Me.RbPortador.Location = New System.Drawing.Point(145, 20)
        Me.RbPortador.Name = "RbPortador"
        Me.RbPortador.Size = New System.Drawing.Size(65, 17)
        Me.RbPortador.TabIndex = 158
        Me.RbPortador.Text = "Portador"
        Me.RbPortador.UseVisualStyleBackColor = True
        '
        'RbNfe
        '
        Me.RbNfe.AutoSize = True
        Me.RbNfe.Checked = True
        Me.RbNfe.Location = New System.Drawing.Point(39, 20)
        Me.RbNfe.Name = "RbNfe"
        Me.RbNfe.Size = New System.Drawing.Size(78, 17)
        Me.RbNfe.TabIndex = 157
        Me.RbNfe.TabStop = True
        Me.RbNfe.Text = "Nota Fiscal"
        Me.RbNfe.UseVisualStyleBackColor = True
        '
        'FrmExcluirRetirada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 358)
        Me.Controls.Add(Me.GboxPesProd)
        Me.Controls.Add(Me.GboxEditar)
        Me.Controls.Add(Me.DataGridRetiradas)
        Me.Name = "FrmExcluirRetirada"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Excluir Retiradas"
        CType(Me.DataGridRetiradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxEditar.ResumeLayout(False)
        Me.GboxEditar.PerformLayout()
        Me.GboxPesProd.ResumeLayout(False)
        Me.GboxPesProd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridRetiradas As DataGridView
    Friend WithEvents GboxEditar As GroupBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents GboxPesProd As GroupBox
    Friend WithEvents TxtPesquisa As TextBox
    Friend WithEvents RbPortador As RadioButton
    Friend WithEvents RbNfe As RadioButton
End Class
