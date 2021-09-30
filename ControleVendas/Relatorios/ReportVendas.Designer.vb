<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportVendas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportVendas))
        Me.DataSetvendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_ReportVendas = New ControleVendas.DataSet_ReportVendas()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetReportVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_vendaTableAdapter = New ControleVendas.DataSet_ReportVendasTableAdapters.DataSet_vendaTableAdapter()
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataFim = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataInicio = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataSetvendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_ReportVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetReportVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetvendaBindingSource
        '
        Me.DataSetvendaBindingSource.DataMember = "DataSet_venda"
        Me.DataSetvendaBindingSource.DataSource = Me.DataSet_ReportVendas
        '
        'DataSet_ReportVendas
        '
        Me.DataSet_ReportVendas.DataSetName = "DataSet_ReportVendas"
        Me.DataSet_ReportVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet_Vendas"
        ReportDataSource1.Value = Me.DataSetvendaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportVendas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 46)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(753, 652)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetReportVendasBindingSource
        '
        Me.DataSetReportVendasBindingSource.DataSource = Me.DataSet_ReportVendas
        Me.DataSetReportVendasBindingSource.Position = 0
        '
        'DataSet_vendaTableAdapter
        '
        Me.DataSet_vendaTableAdapter.ClearBeforeFill = True
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
        Me.BtnCarregar.Location = New System.Drawing.Point(612, 4)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCarregar.TabIndex = 168
        Me.BtnCarregar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnCarregar, "Carregar Relatório")
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(193, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Data Final:"
        '
        'DataFim
        '
        Me.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFim.Location = New System.Drawing.Point(255, 12)
        Me.DataFim.Name = "DataFim"
        Me.DataFim.Size = New System.Drawing.Size(97, 20)
        Me.DataFim.TabIndex = 166
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Data Inicial:"
        '
        'DataInicio
        '
        Me.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicio.Location = New System.Drawing.Point(82, 12)
        Me.DataInicio.Name = "DataInicio"
        Me.DataInicio.Size = New System.Drawing.Size(97, 20)
        Me.DataInicio.TabIndex = 164
        '
        'ReportVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 695)
        Me.Controls.Add(Me.BtnCarregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataFim)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataInicio)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReportVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas"
        CType(Me.DataSetvendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_ReportVendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReportVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSetReportVendasBindingSource As BindingSource
    Friend WithEvents DataSet_ReportVendas As DataSet_ReportVendas
    Friend WithEvents DataSetvendaBindingSource As BindingSource
    Friend WithEvents DataSet_vendaTableAdapter As DataSet_ReportVendasTableAdapters.DataSet_vendaTableAdapter
    Friend WithEvents BtnCarregar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataFim As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents DataInicio As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
End Class
