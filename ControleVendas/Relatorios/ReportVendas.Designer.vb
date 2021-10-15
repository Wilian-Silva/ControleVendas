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
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet_Vendas"
        ReportDataSource1.Value = Me.DataSetvendaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportVendas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(754, 695)
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
        'ReportVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 695)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas"
        CType(Me.DataSetvendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_ReportVendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReportVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSetReportVendasBindingSource As BindingSource
    Friend WithEvents DataSet_ReportVendas As DataSet_ReportVendas
    Friend WithEvents DataSetvendaBindingSource As BindingSource
    Friend WithEvents DataSet_vendaTableAdapter As DataSet_ReportVendasTableAdapters.DataSet_vendaTableAdapter
    Friend WithEvents ToolTip1 As ToolTip
End Class
