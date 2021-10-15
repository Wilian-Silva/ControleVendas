<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTituloVencidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTituloVencidos))
        Me.TitulosVencidosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportTitulosVencidos = New ControleVendas.ReportTitulosVencidos()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.titulosVencidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.titulosVencidosTableAdapter = New ControleVendas.ReportTitulosVencidosTableAdapters.titulosVencidosTableAdapter()
        CType(Me.TitulosVencidosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTitulosVencidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.titulosVencidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitulosVencidosBindingSource1
        '
        Me.TitulosVencidosBindingSource1.DataMember = "titulosVencidos"
        Me.TitulosVencidosBindingSource1.DataSource = Me.ReportTitulosVencidos
        '
        'ReportTitulosVencidos
        '
        Me.ReportTitulosVencidos.DataSetName = "ReportTitulosVencidos"
        Me.ReportTitulosVencidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetTitulosVencidos"
        ReportDataSource1.Value = Me.TitulosVencidosBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportTitulosVencidos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(815, 697)
        Me.ReportViewer1.TabIndex = 0
        '
        'titulosVencidosBindingSource
        '
        Me.titulosVencidosBindingSource.DataMember = "titulosVencidos"
        Me.titulosVencidosBindingSource.DataSource = Me.ReportTitulosVencidos
        '
        'titulosVencidosTableAdapter
        '
        Me.titulosVencidosTableAdapter.ClearBeforeFill = True
        '
        'FrmTituloVencidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 697)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTituloVencidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Títulos Vencidos"
        CType(Me.TitulosVencidosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTitulosVencidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.titulosVencidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents titulosVencidosBindingSource As BindingSource
    Friend WithEvents ReportTitulosVencidos As ReportTitulosVencidos
    Friend WithEvents titulosVencidosTableAdapter As ReportTitulosVencidosTableAdapters.titulosVencidosTableAdapter
    Friend WithEvents TitulosVencidosBindingSource1 As BindingSource
End Class
