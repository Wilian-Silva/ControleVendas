<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddItemPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddItemPedido))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtStatusPedido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCodFornecedor = New System.Windows.Forms.TextBox()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtIdRegistro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtFornecedor = New System.Windows.Forms.TextBox()
        Me.TxtCodProduto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnPesqProduto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPedido = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataPed = New System.Windows.Forms.DateTimePicker()
        Me.TxtProduto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtValorTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtQuantidade = New System.Windows.Forms.TextBox()
        Me.TxtValorUnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TxtStatusPedido)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtCodFornecedor)
        Me.GroupBox3.Controls.Add(Me.TxtItem)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtIdRegistro)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtFornecedor)
        Me.GroupBox3.Controls.Add(Me.TxtCodProduto)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.BtnPesqProduto)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtPedido)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.DataPed)
        Me.GroupBox3.Controls.Add(Me.TxtProduto)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtValorTotal)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtQuantidade)
        Me.GroupBox3.Controls.Add(Me.TxtValorUnit)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(513, 195)
        Me.GroupBox3.TabIndex = 135
        Me.GroupBox3.TabStop = False
        '
        'TxtStatusPedido
        '
        Me.TxtStatusPedido.BackColor = System.Drawing.Color.White
        Me.TxtStatusPedido.Enabled = False
        Me.TxtStatusPedido.Location = New System.Drawing.Point(429, 145)
        Me.TxtStatusPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStatusPedido.Name = "TxtStatusPedido"
        Me.TxtStatusPedido.Size = New System.Drawing.Size(55, 20)
        Me.TxtStatusPedido.TabIndex = 144
        Me.TxtStatusPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 147)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Status:"
        '
        'TxtCodFornecedor
        '
        Me.TxtCodFornecedor.BackColor = System.Drawing.Color.White
        Me.TxtCodFornecedor.Enabled = False
        Me.TxtCodFornecedor.Location = New System.Drawing.Point(102, 62)
        Me.TxtCodFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodFornecedor.Name = "TxtCodFornecedor"
        Me.TxtCodFornecedor.Size = New System.Drawing.Size(41, 20)
        Me.TxtCodFornecedor.TabIndex = 141
        Me.TxtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtItem
        '
        Me.TxtItem.Enabled = False
        Me.TxtItem.Location = New System.Drawing.Point(189, 23)
        Me.TxtItem.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.Size = New System.Drawing.Size(40, 20)
        Me.TxtItem.TabIndex = 139
        Me.TxtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(152, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 16)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "Item"
        '
        'TxtIdRegistro
        '
        Me.TxtIdRegistro.Enabled = False
        Me.TxtIdRegistro.Location = New System.Drawing.Point(101, 23)
        Me.TxtIdRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdRegistro.Name = "TxtIdRegistro"
        Me.TxtIdRegistro.Size = New System.Drawing.Size(45, 20)
        Me.TxtIdRegistro.TabIndex = 129
        Me.TxtIdRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Nº Pedido:"
        '
        'TxtFornecedor
        '
        Me.TxtFornecedor.BackColor = System.Drawing.Color.White
        Me.TxtFornecedor.Enabled = False
        Me.TxtFornecedor.Location = New System.Drawing.Point(144, 62)
        Me.TxtFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFornecedor.Name = "TxtFornecedor"
        Me.TxtFornecedor.Size = New System.Drawing.Size(135, 20)
        Me.TxtFornecedor.TabIndex = 4
        '
        'TxtCodProduto
        '
        Me.TxtCodProduto.BackColor = System.Drawing.Color.White
        Me.TxtCodProduto.Enabled = False
        Me.TxtCodProduto.Location = New System.Drawing.Point(102, 103)
        Me.TxtCodProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodProduto.Name = "TxtCodProduto"
        Me.TxtCodProduto.Size = New System.Drawing.Size(41, 20)
        Me.TxtCodProduto.TabIndex = 137
        Me.TxtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Fornecedor:"
        '
        'BtnPesqProduto
        '
        Me.BtnPesqProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesqProduto.FlatAppearance.BorderSize = 0
        Me.BtnPesqProduto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesqProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesqProduto.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesqProduto.Image = CType(resources.GetObject("BtnPesqProduto.Image"), System.Drawing.Image)
        Me.BtnPesqProduto.Location = New System.Drawing.Point(358, 102)
        Me.BtnPesqProduto.Name = "BtnPesqProduto"
        Me.BtnPesqProduto.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesqProduto.TabIndex = 2
        Me.BtnPesqProduto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(241, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Desc. Pedido:"
        '
        'TxtPedido
        '
        Me.TxtPedido.BackColor = System.Drawing.Color.White
        Me.TxtPedido.Enabled = False
        Me.TxtPedido.Location = New System.Drawing.Point(329, 23)
        Me.TxtPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPedido.Name = "TxtPedido"
        Me.TxtPedido.Size = New System.Drawing.Size(155, 20)
        Me.TxtPedido.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(289, 62)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 16)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Data Emissão:"
        '
        'DataPed
        '
        Me.DataPed.Enabled = False
        Me.DataPed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPed.Location = New System.Drawing.Point(381, 60)
        Me.DataPed.Name = "DataPed"
        Me.DataPed.Size = New System.Drawing.Size(103, 20)
        Me.DataPed.TabIndex = 1
        '
        'TxtProduto
        '
        Me.TxtProduto.BackColor = System.Drawing.Color.White
        Me.TxtProduto.Location = New System.Drawing.Point(144, 103)
        Me.TxtProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtProduto.Name = "TxtProduto"
        Me.TxtProduto.Size = New System.Drawing.Size(207, 20)
        Me.TxtProduto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Cód./Produto:"
        '
        'TxtValorTotal
        '
        Me.TxtValorTotal.BackColor = System.Drawing.Color.White
        Me.TxtValorTotal.Enabled = False
        Me.TxtValorTotal.Location = New System.Drawing.Point(247, 147)
        Me.TxtValorTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorTotal.Name = "TxtValorTotal"
        Me.TxtValorTotal.Size = New System.Drawing.Size(83, 20)
        Me.TxtValorTotal.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(407, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Qtd."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(167, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Valor Total:"
        '
        'TxtQuantidade
        '
        Me.TxtQuantidade.BackColor = System.Drawing.Color.White
        Me.TxtQuantidade.Location = New System.Drawing.Point(442, 102)
        Me.TxtQuantidade.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtQuantidade.Name = "TxtQuantidade"
        Me.TxtQuantidade.Size = New System.Drawing.Size(42, 20)
        Me.TxtQuantidade.TabIndex = 3
        Me.TxtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtValorUnit
        '
        Me.TxtValorUnit.BackColor = System.Drawing.Color.White
        Me.TxtValorUnit.Location = New System.Drawing.Point(102, 147)
        Me.TxtValorUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorUnit.Name = "TxtValorUnit"
        Me.TxtValorUnit.Size = New System.Drawing.Size(59, 20)
        Me.TxtValorUnit.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Vlr. Unit."
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 19)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(100, 30)
        Me.BtnSalvar.TabIndex = 161
        Me.BtnSalvar.Text = "Salvar"
        Me.ToolTip.SetToolTip(Me.BtnSalvar, "Salvar")
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCancelar.Location = New System.Drawing.Point(105, 19)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BtnCancelar.TabIndex = 160
        Me.BtnCancelar.Text = "Cancelar"
        Me.ToolTip.SetToolTip(Me.BtnCancelar, "Cancelar")
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnSalvar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 63)
        Me.GroupBox1.TabIndex = 162
        Me.GroupBox1.TabStop = False
        '
        'FrmAddItemPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(550, 287)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmAddItemPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar item ao Pedido"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtStatusPedido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCodFornecedor As TextBox
    Friend WithEvents TxtItem As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtIdRegistro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtFornecedor As TextBox
    Friend WithEvents TxtCodProduto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnPesqProduto As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPedido As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DataPed As DateTimePicker
    Friend WithEvents TxtProduto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtValorTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtQuantidade As TextBox
    Friend WithEvents TxtValorUnit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolTip As ToolTip
End Class
