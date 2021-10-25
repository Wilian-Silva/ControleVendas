<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelMvtoEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRelMvtoEstoque))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnPesqProduto = New System.Windows.Forms.Button()
        Me.CbTipoMvto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCodProduto = New System.Windows.Forms.TextBox()
        Me.TxtProduto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.BtnPesqProduto)
        Me.GroupBox3.Controls.Add(Me.CbTipoMvto)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtQuantidade)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtCodProduto)
        Me.GroupBox3.Controls.Add(Me.TxtProduto)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 91)
        Me.GroupBox3.TabIndex = 148
        Me.GroupBox3.TabStop = False
        '
        'BtnPesqProduto
        '
        Me.BtnPesqProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesqProduto.FlatAppearance.BorderSize = 0
        Me.BtnPesqProduto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesqProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesqProduto.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesqProduto.Image = CType(resources.GetObject("BtnPesqProduto.Image"), System.Drawing.Image)
        Me.BtnPesqProduto.Location = New System.Drawing.Point(310, 16)
        Me.BtnPesqProduto.Name = "BtnPesqProduto"
        Me.BtnPesqProduto.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesqProduto.TabIndex = 3
        Me.BtnPesqProduto.UseVisualStyleBackColor = True
        '
        'CbTipoMvto
        '
        Me.CbTipoMvto.FormattingEnabled = True
        Me.CbTipoMvto.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.CbTipoMvto.Location = New System.Drawing.Point(95, 55)
        Me.CbTipoMvto.Name = "CbTipoMvto"
        Me.CbTipoMvto.Size = New System.Drawing.Size(108, 21)
        Me.CbTipoMvto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "Tipo Mvto."
        '
        'TxtQuantidade
        '
        Me.TxtQuantidade.BackColor = System.Drawing.Color.White
        Me.TxtQuantidade.Location = New System.Drawing.Point(270, 55)
        Me.TxtQuantidade.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtQuantidade.Name = "TxtQuantidade"
        Me.TxtQuantidade.Size = New System.Drawing.Size(43, 20)
        Me.TxtQuantidade.TabIndex = 5
        Me.TxtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(232, 57)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Qtd."
        '
        'TxtCodProduto
        '
        Me.TxtCodProduto.BackColor = System.Drawing.Color.White
        Me.TxtCodProduto.Enabled = False
        Me.TxtCodProduto.Location = New System.Drawing.Point(64, 18)
        Me.TxtCodProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodProduto.Name = "TxtCodProduto"
        Me.TxtCodProduto.Size = New System.Drawing.Size(30, 20)
        Me.TxtCodProduto.TabIndex = 1
        Me.TxtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtProduto
        '
        Me.TxtProduto.BackColor = System.Drawing.Color.White
        Me.TxtProduto.HideSelection = False
        Me.TxtProduto.Location = New System.Drawing.Point(95, 18)
        Me.TxtProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtProduto.Name = "TxtProduto"
        Me.TxtProduto.Size = New System.Drawing.Size(208, 20)
        Me.TxtProduto.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Produto:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.BtnSalvar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(14, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 52)
        Me.GroupBox1.TabIndex = 180
        Me.GroupBox1.TabStop = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnSalvar.Location = New System.Drawing.Point(193, 12)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(70, 30)
        Me.BtnSalvar.TabIndex = 168
        Me.BtnSalvar.TabStop = False
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCancelar.Location = New System.Drawing.Point(268, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(70, 30)
        Me.BtnCancelar.TabIndex = 167
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmRelMvtoEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(391, 180)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRelMvtoEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimentos no Estoque"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtQuantidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCodProduto As TextBox
    Friend WithEvents TxtProduto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbTipoMvto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnPesqProduto As Button
End Class
