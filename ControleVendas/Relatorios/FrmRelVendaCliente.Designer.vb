<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelVendaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRelVendaCliente))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnPesquisarCliente = New System.Windows.Forms.Button()
        Me.TxtIdPortador = New System.Windows.Forms.TextBox()
        Me.DataInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.DataFim = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.controle_vendasPorCliente = New ControleVendas.controle_vendasPorCliente()
        Me.venda_cliente_dataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.venda_cliente_dataTableAdapter = New ControleVendas.controle_vendasPorClienteTableAdapters.venda_cliente_dataTableAdapter()
        Me.duplicatas_cliente_dataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.duplicatas_cliente_dataTableAdapter = New ControleVendas.controle_vendasPorClienteTableAdapters.duplicatas_cliente_dataTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.controle_vendasPorCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venda_cliente_dataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duplicatas_cliente_dataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisarCliente)
        Me.GroupBox1.Controls.Add(Me.TxtIdPortador)
        Me.GroupBox1.Controls.Add(Me.DataInicio)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.BtnCarregar)
        Me.GroupBox1.Controls.Add(Me.DataFim)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(930, 59)
        Me.GroupBox1.TabIndex = 187
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
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "Pesq. Cliente"
        '
        'BtnPesquisarCliente
        '
        Me.BtnPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesquisarCliente.FlatAppearance.BorderSize = 0
        Me.BtnPesquisarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisarCliente.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesquisarCliente.Image = CType(resources.GetObject("BtnPesquisarCliente.Image"), System.Drawing.Image)
        Me.BtnPesquisarCliente.Location = New System.Drawing.Point(177, 17)
        Me.BtnPesquisarCliente.Name = "BtnPesquisarCliente"
        Me.BtnPesquisarCliente.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesquisarCliente.TabIndex = 184
        Me.BtnPesquisarCliente.UseVisualStyleBackColor = True
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
        'DataInicio
        '
        Me.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicio.Location = New System.Drawing.Point(325, 20)
        Me.DataInicio.Name = "DataInicio"
        Me.DataInicio.Size = New System.Drawing.Size(97, 20)
        Me.DataInicio.TabIndex = 179
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
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'DataFim
        '
        Me.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFim.Location = New System.Drawing.Point(498, 20)
        Me.DataFim.Name = "DataFim"
        Me.DataFim.Size = New System.Drawing.Size(97, 20)
        Me.DataFim.TabIndex = 181
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetVendasCliente"
        ReportDataSource1.Value = Me.venda_cliente_dataBindingSource
        ReportDataSource2.Name = "DataSetDuplicatasCliente"
        ReportDataSource2.Value = Me.duplicatas_cliente_dataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportVendaCliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 89)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(930, 486)
        Me.ReportViewer1.TabIndex = 188
        '
        'controle_vendasPorCliente
        '
        Me.controle_vendasPorCliente.DataSetName = "controle_vendasPorCliente"
        Me.controle_vendasPorCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'venda_cliente_dataBindingSource
        '
        Me.venda_cliente_dataBindingSource.DataMember = "venda_cliente_data"
        Me.venda_cliente_dataBindingSource.DataSource = Me.controle_vendasPorCliente
        '
        'venda_cliente_dataTableAdapter
        '
        Me.venda_cliente_dataTableAdapter.ClearBeforeFill = True
        '
        'duplicatas_cliente_dataBindingSource
        '
        Me.duplicatas_cliente_dataBindingSource.DataMember = "duplicatas_cliente_data"
        Me.duplicatas_cliente_dataBindingSource.DataSource = Me.controle_vendasPorCliente
        '
        'duplicatas_cliente_dataTableAdapter
        '
        Me.duplicatas_cliente_dataTableAdapter.ClearBeforeFill = True
        '
        'FrmRelVendaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 594)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmRelVendaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas por Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.controle_vendasPorCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venda_cliente_dataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duplicatas_cliente_dataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnPesquisarCliente As Button
    Friend WithEvents TxtIdPortador As TextBox
    Friend WithEvents DataInicio As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnCarregar As Button
    Friend WithEvents DataFim As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents venda_cliente_dataBindingSource As BindingSource
    Friend WithEvents controle_vendasPorCliente As controle_vendasPorCliente
    Friend WithEvents duplicatas_cliente_dataBindingSource As BindingSource
    Friend WithEvents venda_cliente_dataTableAdapter As controle_vendasPorClienteTableAdapters.venda_cliente_dataTableAdapter
    Friend WithEvents duplicatas_cliente_dataTableAdapter As controle_vendasPorClienteTableAdapters.duplicatas_cliente_dataTableAdapter
End Class
