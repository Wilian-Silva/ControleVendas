<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteVencidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteVencidos))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.VendacabecalhotituloVencidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.controle_vendasDataSet4 = New ControleVendas.controle_vendasDataSet4()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataHoje = New System.Windows.Forms.DateTimePicker()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.venda_cabecalho_tituloVencidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.venda_cabecalho_tituloVencidoTableAdapter = New ControleVendas.controle_vendasDataSet4TableAdapters.venda_cabecalho_tituloVencidoTableAdapter()
        CType(Me.VendacabecalhotituloVencidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.controle_vendasDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venda_cabecalho_tituloVencidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VendacabecalhotituloVencidoBindingSource
        '
        Me.VendacabecalhotituloVencidoBindingSource.DataMember = "venda_cabecalho_tituloVencido"
        Me.VendacabecalhotituloVencidoBindingSource.DataSource = Me.controle_vendasDataSet4
        '
        'controle_vendasDataSet4
        '
        Me.controle_vendasDataSet4.DataSetName = "controle_vendasDataSet4"
        Me.controle_vendasDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Data:"
        '
        'DataHoje
        '
        Me.DataHoje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataHoje.Location = New System.Drawing.Point(77, 15)
        Me.DataHoje.Name = "DataHoje"
        Me.DataHoje.Size = New System.Drawing.Size(105, 20)
        Me.DataHoje.TabIndex = 12
        '
        'BtnSair
        '
        Me.BtnSair.AccessibleDescription = ""
        Me.BtnSair.AccessibleName = "Adicionar"
        Me.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSair.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.Image = CType(resources.GetObject("BtnSair.Image"), System.Drawing.Image)
        Me.BtnSair.Location = New System.Drawing.Point(623, 7)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 61
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetVencidos"
        ReportDataSource1.Value = Me.VendacabecalhotituloVencidoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportTitulosVencidos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 52)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(669, 700)
        Me.ReportViewer1.TabIndex = 62
        '
        'venda_cabecalho_tituloVencidoBindingSource
        '
        Me.venda_cabecalho_tituloVencidoBindingSource.DataMember = "venda_cabecalho_tituloVencido"
        Me.venda_cabecalho_tituloVencidoBindingSource.DataSource = Me.controle_vendasDataSet4
        '
        'venda_cabecalho_tituloVencidoTableAdapter
        '
        Me.venda_cabecalho_tituloVencidoTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteVencidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 750)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataHoje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmReporteVencidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Títulos Vencidos"
        CType(Me.VendacabecalhotituloVencidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.controle_vendasDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venda_cabecalho_tituloVencidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataHoje As DateTimePicker
    Friend WithEvents BtnSair As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents venda_cabecalho_tituloVencidoBindingSource As BindingSource
    Friend WithEvents controle_vendasDataSet4 As controle_vendasDataSet4
    Friend WithEvents venda_cabecalho_tituloVencidoTableAdapter As controle_vendasDataSet4TableAdapters.venda_cabecalho_tituloVencidoTableAdapter
    Friend WithEvents VendacabecalhotituloVencidoBindingSource As BindingSource
End Class
