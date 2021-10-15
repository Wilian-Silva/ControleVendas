<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResultadoPeriodo
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResultadoPeriodo))
        Me.ResultadoPeriodoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasetResultadoPeriodo = New ControleVendas.DatasetResultadoPeriodo()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ResultadoPeriodoTableAdapter = New ControleVendas.DatasetResultadoPeriodoTableAdapters.ResultadoPeriodoTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ResultadoPeriodoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetResultadoPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResultadoPeriodoBindingSource
        '
        Me.ResultadoPeriodoBindingSource.DataMember = "ResultadoPeriodo"
        Me.ResultadoPeriodoBindingSource.DataSource = Me.DatasetResultadoPeriodo
        '
        'DatasetResultadoPeriodo
        '
        Me.DatasetResultadoPeriodo.DataSetName = "DatasetResultadoPeriodo"
        Me.DatasetResultadoPeriodo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetResultadoPeriodo"
        ReportDataSource1.Value = Me.ResultadoPeriodoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportResultadoPeriod.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(796, 611)
        Me.ReportViewer1.TabIndex = 0
        '
        'ResultadoPeriodoTableAdapter
        '
        Me.ResultadoPeriodoTableAdapter.ClearBeforeFill = True
        '
        'FrmResultadoPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 611)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmResultadoPeriodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultado do Período"
        CType(Me.ResultadoPeriodoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetResultadoPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ResultadoPeriodoBindingSource As BindingSource
    Friend WithEvents DatasetResultadoPeriodo As DatasetResultadoPeriodo
    Friend WithEvents ResultadoPeriodoTableAdapter As DatasetResultadoPeriodoTableAdapters.ResultadoPeriodoTableAdapter
    Friend WithEvents ToolTip1 As ToolTip
End Class
