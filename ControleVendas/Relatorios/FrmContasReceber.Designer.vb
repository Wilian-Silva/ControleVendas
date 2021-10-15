<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContasReceber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContasReceber))
        Me.ContasreceberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportTitulosVencidos = New ControleVendas.ReportTitulosVencidos()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.contas_receberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.contas_receberTableAdapter = New ControleVendas.ReportTitulosVencidosTableAdapters.contas_receberTableAdapter()
        CType(Me.ContasreceberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTitulosVencidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contas_receberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContasreceberBindingSource
        '
        Me.ContasreceberBindingSource.DataMember = "contas_receber"
        Me.ContasreceberBindingSource.DataSource = Me.ReportTitulosVencidos
        '
        'ReportTitulosVencidos
        '
        Me.ReportTitulosVencidos.DataSetName = "ReportTitulosVencidos"
        Me.ReportTitulosVencidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetContasReber"
        ReportDataSource1.Value = Me.ContasreceberBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportContasReceber.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(829, 678)
        Me.ReportViewer1.TabIndex = 0
        '
        'contas_receberBindingSource
        '
        Me.contas_receberBindingSource.DataMember = "contas_receber"
        Me.contas_receberBindingSource.DataSource = Me.ReportTitulosVencidos
        '
        'contas_receberTableAdapter
        '
        Me.contas_receberTableAdapter.ClearBeforeFill = True
        '
        'FrmContasReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 678)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmContasReceber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Título em Aberto a Receber"
        CType(Me.ContasreceberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTitulosVencidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contas_receberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents contas_receberBindingSource As BindingSource
    Friend WithEvents ReportTitulosVencidos As ReportTitulosVencidos
    Friend WithEvents contas_receberTableAdapter As ReportTitulosVencidosTableAdapters.contas_receberTableAdapter
    Friend WithEvents ContasreceberBindingSource As BindingSource
End Class
