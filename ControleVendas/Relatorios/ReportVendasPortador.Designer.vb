<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportVendasPortador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportVendasPortador))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataFim = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnPesquisarPortador = New System.Windows.Forms.Button()
        Me.TxtIdPortador = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.controle_vendasDataSet_Portador = New ControleVendas.controle_vendasDataSet_Portador()
        Me.duplicatas_receber_portadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.duplicatas_receber_portadorTableAdapter = New ControleVendas.controle_vendasDataSet_PortadorTableAdapters.duplicatas_receber_portadorTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.controle_vendasDataSet_Portador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duplicatas_receber_portadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCarregar
        '
        Me.BtnCarregar.AccessibleDescription = ""
        Me.BtnCarregar.AccessibleName = "Adicionar"
        Me.BtnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCarregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCarregar.FlatAppearance.BorderSize = 0
        Me.BtnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCarregar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCarregar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCarregar.Image = CType(resources.GetObject("BtnCarregar.Image"), System.Drawing.Image)
        Me.BtnCarregar.Location = New System.Drawing.Point(623, 12)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCarregar.TabIndex = 183
        Me.BtnCarregar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnCarregar, "Carregar Relatório")
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(436, 24)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "Data Final:"
        '
        'DataFim
        '
        Me.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFim.Location = New System.Drawing.Point(498, 20)
        Me.DataFim.Name = "DataFim"
        Me.DataFim.Size = New System.Drawing.Size(97, 20)
        Me.DataFim.TabIndex = 181
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(258, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 180
        Me.Label10.Text = "Data Inicial:"
        '
        'DataInicio
        '
        Me.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicio.Location = New System.Drawing.Point(325, 20)
        Me.DataInicio.Name = "DataInicio"
        Me.DataInicio.Size = New System.Drawing.Size(97, 20)
        Me.DataInicio.TabIndex = 179
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisarPortador)
        Me.GroupBox1.Controls.Add(Me.TxtIdPortador)
        Me.GroupBox1.Controls.Add(Me.DataInicio)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.BtnCarregar)
        Me.GroupBox1.Controls.Add(Me.DataFim)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(977, 59)
        Me.GroupBox1.TabIndex = 186
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "Pesq. Portador"
        '
        'BtnPesquisarPortador
        '
        Me.BtnPesquisarPortador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesquisarPortador.FlatAppearance.BorderSize = 0
        Me.BtnPesquisarPortador.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesquisarPortador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisarPortador.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesquisarPortador.Image = CType(resources.GetObject("BtnPesquisarPortador.Image"), System.Drawing.Image)
        Me.BtnPesquisarPortador.Location = New System.Drawing.Point(177, 17)
        Me.BtnPesquisarPortador.Name = "BtnPesquisarPortador"
        Me.BtnPesquisarPortador.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesquisarPortador.TabIndex = 184
        Me.BtnPesquisarPortador.UseVisualStyleBackColor = True
        '
        'TxtIdPortador
        '
        Me.TxtIdPortador.BackColor = System.Drawing.Color.White
        Me.TxtIdPortador.Location = New System.Drawing.Point(122, 20)
        Me.TxtIdPortador.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdPortador.Name = "TxtIdPortador"
        Me.TxtIdPortador.Size = New System.Drawing.Size(48, 20)
        Me.TxtIdPortador.TabIndex = 185
        Me.TxtIdPortador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetArPortador"
        ReportDataSource1.Value = Me.duplicatas_receber_portadorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportArPortador.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 70)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(977, 422)
        Me.ReportViewer1.TabIndex = 187
        '
        'controle_vendasDataSet_Portador
        '
        Me.controle_vendasDataSet_Portador.DataSetName = "controle_vendasDataSet_Portador"
        Me.controle_vendasDataSet_Portador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'duplicatas_receber_portadorBindingSource
        '
        Me.duplicatas_receber_portadorBindingSource.DataMember = "duplicatas_receber_portador"
        Me.duplicatas_receber_portadorBindingSource.DataSource = Me.controle_vendasDataSet_Portador
        '
        'duplicatas_receber_portadorTableAdapter
        '
        Me.duplicatas_receber_portadorTableAdapter.ClearBeforeFill = True
        '
        'ReportVendasPortador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 504)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReportVendasPortador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas por Portador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.controle_vendasDataSet_Portador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duplicatas_receber_portadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCarregar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataFim As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents DataInicio As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnPesquisarPortador As Button
    Friend WithEvents TxtIdPortador As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents duplicatas_receber_portadorBindingSource As BindingSource
    Friend WithEvents controle_vendasDataSet_Portador As controle_vendasDataSet_Portador
    Friend WithEvents duplicatas_receber_portadorTableAdapter As controle_vendasDataSet_PortadorTableAdapters.duplicatas_receber_portadorTableAdapter
End Class
