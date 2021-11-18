<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTotalAdtos
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ConsultaadtoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTotalAdto = New ControleVendas.DataSetTotalAdto()
        Me.Consulta_adtoTableAdapter = New ControleVendas.DataSetTotalAdtoTableAdapters.consulta_adtoTableAdapter()
        CType(Me.ConsultaadtoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTotalAdto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetAdto"
        ReportDataSource1.Value = Me.ConsultaadtoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportTotalAdto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(736, 492)
        Me.ReportViewer1.TabIndex = 0
        '
        'ConsultaadtoBindingSource
        '
        Me.ConsultaadtoBindingSource.DataMember = "consulta_adto"
        Me.ConsultaadtoBindingSource.DataSource = Me.DataSetTotalAdto
        '
        'DataSetTotalAdto
        '
        Me.DataSetTotalAdto.DataSetName = "DataSetTotalAdto"
        Me.DataSetTotalAdto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Consulta_adtoTableAdapter
        '
        Me.Consulta_adtoTableAdapter.ClearBeforeFill = True
        '
        'FrmTotalAdtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 492)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmTotalAdtos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Total de Adiantamentos"
        CType(Me.ConsultaadtoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTotalAdto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSetTotalAdto As DataSetTotalAdto
    Friend WithEvents ConsultaadtoBindingSource As BindingSource
    Friend WithEvents Consulta_adtoTableAdapter As DataSetTotalAdtoTableAdapters.consulta_adtoTableAdapter
End Class
