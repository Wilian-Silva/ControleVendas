<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRetiradas
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataMvto = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtTipoMvto = New System.Windows.Forms.TextBox()
        Me.TxtPortador = New System.Windows.Forms.TextBox()
        Me.TxtIdportador = New System.Windows.Forms.TextBox()
        Me.BtnPortador = New System.Windows.Forms.Button()
        Me.TxtIdNfeEntrada = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNfeEntrada = New System.Windows.Forms.TextBox()
        Me.BtnNfe = New System.Windows.Forms.Button()
        Me.TxtFornecedor = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtFornecedor)
        Me.GroupBox3.Controls.Add(Me.BtnNfe)
        Me.GroupBox3.Controls.Add(Me.TxtIdNfeEntrada)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtNfeEntrada)
        Me.GroupBox3.Controls.Add(Me.TxtPortador)
        Me.GroupBox3.Controls.Add(Me.TxtIdportador)
        Me.GroupBox3.Controls.Add(Me.TxtTipoMvto)
        Me.GroupBox3.Controls.Add(Me.BtnPortador)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtValor)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.DataMvto)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(325, 201)
        Me.GroupBox3.TabIndex = 182
        Me.GroupBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 159)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 160
        Me.Label6.Text = "Valor:"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(95, 159)
        Me.TxtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(195, 20)
        Me.TxtValor.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(53, 23)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "Data:"
        '
        'DataMvto
        '
        Me.DataMvto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataMvto.Location = New System.Drawing.Point(96, 21)
        Me.DataMvto.Name = "DataMvto"
        Me.DataMvto.Size = New System.Drawing.Size(97, 20)
        Me.DataMvto.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.BtnSalvar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(15, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 52)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(72, 14)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(87, 30)
        Me.BtnSalvar.TabIndex = 168
        Me.BtnSalvar.TabStop = False
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCancelar.Location = New System.Drawing.Point(189, 14)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(95, 30)
        Me.BtnCancelar.TabIndex = 167
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TxtTipoMvto
        '
        Me.TxtTipoMvto.BackColor = System.Drawing.Color.White
        Me.TxtTipoMvto.Location = New System.Drawing.Point(197, 21)
        Me.TxtTipoMvto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTipoMvto.Multiline = True
        Me.TxtTipoMvto.Name = "TxtTipoMvto"
        Me.TxtTipoMvto.ReadOnly = True
        Me.TxtTipoMvto.Size = New System.Drawing.Size(95, 21)
        Me.TxtTipoMvto.TabIndex = 183
        Me.TxtTipoMvto.Text = "Retirada"
        Me.TxtTipoMvto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPortador
        '
        Me.TxtPortador.BackColor = System.Drawing.Color.White
        Me.TxtPortador.Enabled = False
        Me.TxtPortador.Location = New System.Drawing.Point(131, 124)
        Me.TxtPortador.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPortador.Multiline = True
        Me.TxtPortador.Name = "TxtPortador"
        Me.TxtPortador.Size = New System.Drawing.Size(134, 21)
        Me.TxtPortador.TabIndex = 189
        '
        'TxtIdportador
        '
        Me.TxtIdportador.BackColor = System.Drawing.Color.White
        Me.TxtIdportador.Enabled = False
        Me.TxtIdportador.Location = New System.Drawing.Point(95, 124)
        Me.TxtIdportador.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdportador.Multiline = True
        Me.TxtIdportador.Name = "TxtIdportador"
        Me.TxtIdportador.Size = New System.Drawing.Size(35, 21)
        Me.TxtIdportador.TabIndex = 188
        Me.TxtIdportador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPortador
        '
        Me.BtnPortador.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnPortador.Location = New System.Drawing.Point(265, 123)
        Me.BtnPortador.Name = "BtnPortador"
        Me.BtnPortador.Size = New System.Drawing.Size(25, 23)
        Me.BtnPortador.TabIndex = 187
        Me.BtnPortador.Text = "..."
        Me.BtnPortador.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPortador.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnPortador.UseVisualStyleBackColor = True
        '
        'TxtIdNfeEntrada
        '
        Me.TxtIdNfeEntrada.BackColor = System.Drawing.Color.White
        Me.TxtIdNfeEntrada.Enabled = False
        Me.TxtIdNfeEntrada.Location = New System.Drawing.Point(96, 54)
        Me.TxtIdNfeEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdNfeEntrada.Multiline = True
        Me.TxtIdNfeEntrada.Name = "TxtIdNfeEntrada"
        Me.TxtIdNfeEntrada.Size = New System.Drawing.Size(34, 21)
        Me.TxtIdNfeEntrada.TabIndex = 193
        Me.TxtIdNfeEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 56)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 192
        Me.Label9.Text = "Nfe Entrada:"
        '
        'TxtNfeEntrada
        '
        Me.TxtNfeEntrada.BackColor = System.Drawing.Color.White
        Me.TxtNfeEntrada.Enabled = False
        Me.TxtNfeEntrada.Location = New System.Drawing.Point(131, 54)
        Me.TxtNfeEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNfeEntrada.Multiline = True
        Me.TxtNfeEntrada.Name = "TxtNfeEntrada"
        Me.TxtNfeEntrada.Size = New System.Drawing.Size(134, 21)
        Me.TxtNfeEntrada.TabIndex = 190
        '
        'BtnNfe
        '
        Me.BtnNfe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnNfe.Location = New System.Drawing.Point(265, 53)
        Me.BtnNfe.Name = "BtnNfe"
        Me.BtnNfe.Size = New System.Drawing.Size(25, 23)
        Me.BtnNfe.TabIndex = 194
        Me.BtnNfe.Text = "..."
        Me.BtnNfe.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNfe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnNfe.UseVisualStyleBackColor = True
        '
        'TxtFornecedor
        '
        Me.TxtFornecedor.BackColor = System.Drawing.Color.White
        Me.TxtFornecedor.Enabled = False
        Me.TxtFornecedor.Location = New System.Drawing.Point(95, 87)
        Me.TxtFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFornecedor.Multiline = True
        Me.TxtFornecedor.Name = "TxtFornecedor"
        Me.TxtFornecedor.Size = New System.Drawing.Size(195, 21)
        Me.TxtFornecedor.TabIndex = 195
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(30, 126)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 16)
        Me.Label19.TabIndex = 186
        Me.Label19.Text = "Portador:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 196
        Me.Label1.Text = "Fornecedor:"
        '
        'FrmRetiradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 286)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRetiradas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiradas de Lucro"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataMvto As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtTipoMvto As TextBox
    Friend WithEvents TxtPortador As TextBox
    Friend WithEvents TxtIdportador As TextBox
    Friend WithEvents BtnPortador As Button
    Friend WithEvents BtnNfe As Button
    Friend WithEvents TxtIdNfeEntrada As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNfeEntrada As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFornecedor As TextBox
    Friend WithEvents Label19 As Label
End Class
