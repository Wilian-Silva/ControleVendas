<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportTitulosAbert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportTitulosAbert))
        Me.VendacabecalhotituloAbertoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.controle_vendasDataSet4 = New ControleVendas.controle_vendasDataSet4()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.venda_cabecalho_tituloAbertoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.venda_cabecalho_tituloAbertoTableAdapter = New ControleVendas.controle_vendasDataSet4TableAdapters.venda_cabecalho_tituloAbertoTableAdapter()
        CType(Me.VendacabecalhotituloAbertoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.controle_vendasDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venda_cabecalho_tituloAbertoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VendacabecalhotituloAbertoBindingSource
        '
        Me.VendacabecalhotituloAbertoBindingSource.DataMember = "venda_cabecalho_tituloAberto"
        Me.VendacabecalhotituloAbertoBindingSource.DataSource = Me.controle_vendasDataSet4
        '
        'controle_vendasDataSet4
        '
        Me.controle_vendasDataSet4.DataSetName = "controle_vendasDataSet4"
        Me.controle_vendasDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TitulosReceber"
        ReportDataSource1.Value = Me.VendacabecalhotituloAbertoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportTituloAberto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(780, 770)
        Me.ReportViewer1.TabIndex = 61
        '
        'venda_cabecalho_tituloAbertoBindingSource
        '
        Me.venda_cabecalho_tituloAbertoBindingSource.DataMember = "venda_cabecalho_tituloAberto"
        Me.venda_cabecalho_tituloAbertoBindingSource.DataSource = Me.controle_vendasDataSet4
        '
        'venda_cabecalho_tituloAbertoTableAdapter
        '
        Me.venda_cabecalho_tituloAbertoTableAdapter.ClearBeforeFill = True
        '
        'FrmReportTitulosAbert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 770)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmReportTitulosAbert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Títulos a Receber"
        CType(Me.VendacabecalhotituloAbertoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.controle_vendasDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venda_cabecalho_tituloAbertoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents venda_cabecalho_tituloAbertoBindingSource As BindingSource
    Friend WithEvents controle_vendasDataSet4 As controle_vendasDataSet4
    Friend WithEvents venda_cabecalho_tituloAbertoTableAdapter As controle_vendasDataSet4TableAdapters.venda_cabecalho_tituloAbertoTableAdapter
    Friend WithEvents VendacabecalhotituloAbertoBindingSource As BindingSource
End Class
