<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNivelAcesso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNivelAcesso))
        Me.BtnNivel1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnNivel2 = New System.Windows.Forms.Button()
        Me.BtnNivel3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNivel1
        '
        Me.BtnNivel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnNivel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNivel1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnNivel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnNivel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNivel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNivel1.Image = CType(resources.GetObject("BtnNivel1.Image"), System.Drawing.Image)
        Me.BtnNivel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnNivel1.Location = New System.Drawing.Point(27, 41)
        Me.BtnNivel1.Name = "BtnNivel1"
        Me.BtnNivel1.Size = New System.Drawing.Size(173, 55)
        Me.BtnNivel1.TabIndex = 7
        Me.BtnNivel1.Text = "          ACESSO NÍVEL 1"
        Me.BtnNivel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNivel1.UseCompatibleTextRendering = True
        Me.BtnNivel1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnNivel3)
        Me.GroupBox1.Controls.Add(Me.BtnNivel2)
        Me.GroupBox1.Controls.Add(Me.BtnNivel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 141)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configurar níveis de Acesso dos Usuários"
        '
        'BtnNivel2
        '
        Me.BtnNivel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnNivel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNivel2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnNivel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnNivel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNivel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNivel2.Image = CType(resources.GetObject("BtnNivel2.Image"), System.Drawing.Image)
        Me.BtnNivel2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnNivel2.Location = New System.Drawing.Point(206, 41)
        Me.BtnNivel2.Name = "BtnNivel2"
        Me.BtnNivel2.Size = New System.Drawing.Size(173, 55)
        Me.BtnNivel2.TabIndex = 8
        Me.BtnNivel2.Text = "          ACESSO NÍVEL 2"
        Me.BtnNivel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNivel2.UseCompatibleTextRendering = True
        Me.BtnNivel2.UseVisualStyleBackColor = False
        '
        'BtnNivel3
        '
        Me.BtnNivel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnNivel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNivel3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnNivel3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnNivel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNivel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNivel3.Image = CType(resources.GetObject("BtnNivel3.Image"), System.Drawing.Image)
        Me.BtnNivel3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnNivel3.Location = New System.Drawing.Point(385, 41)
        Me.BtnNivel3.Name = "BtnNivel3"
        Me.BtnNivel3.Size = New System.Drawing.Size(173, 55)
        Me.BtnNivel3.TabIndex = 9
        Me.BtnNivel3.Text = "          ACESSO NÍVEL 3"
        Me.BtnNivel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNivel3.UseCompatibleTextRendering = True
        Me.BtnNivel3.UseVisualStyleBackColor = False
        '
        'FrmNivelAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(616, 190)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmNivelAcesso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle Nivel de Acesso"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNivel1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnNivel3 As Button
    Friend WithEvents BtnNivel2 As Button
End Class
