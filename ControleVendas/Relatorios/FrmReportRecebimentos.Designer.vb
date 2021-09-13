<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReportRecebimentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportRecebimentos))
        Me.mvto_recebimentosPorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.controle_vendasDataSet1 = New ControleVendas.controle_vendasDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataFim = New System.Windows.Forms.DateTimePicker()
        Me.DataInicio = New System.Windows.Forms.DateTimePicker()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.mvto_recebimentosPorDataTableAdapter = New ControleVendas.controle_vendasDataSet1TableAdapters.mvto_recebimentosPorDataTableAdapter()
        CType(Me.mvto_recebimentosPorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.controle_vendasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mvto_recebimentosPorDataBindingSource
        '
        Me.mvto_recebimentosPorDataBindingSource.DataMember = "mvto_recebimentosPorData"
        Me.mvto_recebimentosPorDataBindingSource.DataSource = Me.controle_vendasDataSet1
        '
        'controle_vendasDataSet1
        '
        Me.controle_vendasDataSet1.DataSetName = "controle_vendasDataSet1"
        Me.controle_vendasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Recebimentos"
        ReportDataSource1.Value = Me.mvto_recebimentosPorDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportRecebimentos2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-3, 53)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1076, 654)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Data Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data Incial:"
        '
        'DataFim
        '
        Me.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFim.Location = New System.Drawing.Point(311, 12)
        Me.DataFim.Name = "DataFim"
        Me.DataFim.Size = New System.Drawing.Size(105, 20)
        Me.DataFim.TabIndex = 6
        '
        'DataInicio
        '
        Me.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicio.Location = New System.Drawing.Point(106, 12)
        Me.DataInicio.Name = "DataInicio"
        Me.DataInicio.Size = New System.Drawing.Size(105, 20)
        Me.DataInicio.TabIndex = 5
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
        Me.BtnSair.Location = New System.Drawing.Point(1008, 12)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 59
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'mvto_recebimentosPorDataTableAdapter
        '
        Me.mvto_recebimentosPorDataTableAdapter.ClearBeforeFill = True
        '
        'FrmReportRecebimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 704)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataFim)
        Me.Controls.Add(Me.DataInicio)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReportRecebimentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Recebimentos"
        CType(Me.mvto_recebimentosPorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.controle_vendasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mvto_recebimentosPorDataBindingSource As BindingSource
    Friend WithEvents controle_vendasDataSet1 As controle_vendasDataSet1
    Friend WithEvents mvto_recebimentosPorDataTableAdapter As controle_vendasDataSet1TableAdapters.mvto_recebimentosPorDataTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataFim As DateTimePicker
    Friend WithEvents DataInicio As DateTimePicker
    Friend WithEvents BtnSair As Button
End Class
