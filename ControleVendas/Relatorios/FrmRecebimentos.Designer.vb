<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecebimentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecebimentos))
        Me.mvto_recebimentos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetRecebimentos = New ControleVendas.DataSetRecebimentos()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mvto_recebimentos1TableAdapter = New ControleVendas.DataSetRecebimentosTableAdapters.mvto_recebimentos1TableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.mvto_recebimentos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetRecebimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mvto_recebimentos1BindingSource
        '
        Me.mvto_recebimentos1BindingSource.DataMember = "mvto_recebimentos1"
        Me.mvto_recebimentos1BindingSource.DataSource = Me.DataSetRecebimentos
        '
        'DataSetRecebimentos
        '
        Me.DataSetRecebimentos.DataSetName = "DataSetRecebimentos"
        Me.DataSetRecebimentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetRecebimentos"
        ReportDataSource1.Value = Me.mvto_recebimentos1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportRecebimentos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1003, 633)
        Me.ReportViewer1.TabIndex = 174
        '
        'mvto_recebimentos1TableAdapter
        '
        Me.mvto_recebimentos1TableAdapter.ClearBeforeFill = True
        '
        'FrmRecebimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 633)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRecebimentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Recebimentos "
        CType(Me.mvto_recebimentos1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetRecebimentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mvto_recebimentos1BindingSource As BindingSource
    Friend WithEvents DataSetRecebimentos As DataSetRecebimentos
    Friend WithEvents mvto_recebimentos1TableAdapter As DataSetRecebimentosTableAdapters.mvto_recebimentos1TableAdapter
    Friend WithEvents ToolTip1 As ToolTip
End Class
