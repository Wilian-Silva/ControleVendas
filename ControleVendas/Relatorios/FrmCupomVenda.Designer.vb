﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCupomVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCupomVenda))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.cumpoVendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCupomVenda = New ControleVendas.DataSetCupomVenda()
        Me.CupomCompraV2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdVenda = New System.Windows.Forms.TextBox()
        Me.BtnPesquisarNota = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CumpoVendaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cumpoVendaTableAdapter = New ControleVendas.DataSetCupomVendaTableAdapters.cumpoVendaTableAdapter()
        Me.CupomCompraV2TableAdapter = New ControleVendas.DataSetCupomVendaTableAdapters.CupomCompraV2TableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.cumpoVendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCupomVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CupomCompraV2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CumpoVendaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cumpoVendaBindingSource
        '
        Me.cumpoVendaBindingSource.DataMember = "cumpoVenda"
        Me.cumpoVendaBindingSource.DataSource = Me.DataSetCupomVenda
        '
        'DataSetCupomVenda
        '
        Me.DataSetCupomVenda.DataSetName = "DataSetCupomVenda"
        Me.DataSetCupomVenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CupomCompraV2BindingSource
        '
        Me.CupomCompraV2BindingSource.DataMember = "CupomCompraV2"
        Me.CupomCompraV2BindingSource.DataSource = Me.DataSetCupomVenda
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
        Me.BtnCarregar.Location = New System.Drawing.Point(245, 13)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCarregar.TabIndex = 173
        Me.BtnCarregar.TabStop = False
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Pesq. Compra:"
        '
        'TxtIdVenda
        '
        Me.TxtIdVenda.BackColor = System.Drawing.Color.White
        Me.TxtIdVenda.Location = New System.Drawing.Point(115, 20)
        Me.TxtIdVenda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdVenda.Name = "TxtIdVenda"
        Me.TxtIdVenda.Size = New System.Drawing.Size(77, 20)
        Me.TxtIdVenda.TabIndex = 171
        '
        'BtnPesquisarNota
        '
        Me.BtnPesquisarNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesquisarNota.FlatAppearance.BorderSize = 0
        Me.BtnPesquisarNota.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesquisarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisarNota.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesquisarNota.Image = CType(resources.GetObject("BtnPesquisarNota.Image"), System.Drawing.Image)
        Me.BtnPesquisarNota.Location = New System.Drawing.Point(202, 18)
        Me.BtnPesquisarNota.Name = "BtnPesquisarNota"
        Me.BtnPesquisarNota.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesquisarNota.TabIndex = 170
        Me.BtnPesquisarNota.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetVenda"
        ReportDataSource1.Value = Me.cumpoVendaBindingSource
        ReportDataSource2.Name = "DataSetTeste"
        ReportDataSource2.Value = Me.CupomCompraV2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportCupomVenda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(17, 64)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(760, 672)
        Me.ReportViewer1.TabIndex = 174
        '
        'CumpoVendaBindingSource1
        '
        Me.CumpoVendaBindingSource1.DataMember = "cumpoVenda"
        Me.CumpoVendaBindingSource1.DataSource = Me.DataSetCupomVenda
        '
        'cumpoVendaTableAdapter
        '
        Me.cumpoVendaTableAdapter.ClearBeforeFill = True
        '
        'CupomCompraV2TableAdapter
        '
        Me.CupomCompraV2TableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisarNota)
        Me.GroupBox1.Controls.Add(Me.BtnCarregar)
        Me.GroupBox1.Controls.Add(Me.TxtIdVenda)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 56)
        Me.GroupBox1.TabIndex = 175
        Me.GroupBox1.TabStop = False
        '
        'FrmCupomVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 748)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCupomVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emissão Cupom Venda"
        CType(Me.cumpoVendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCupomVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CupomCompraV2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CumpoVendaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCarregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdVenda As TextBox
    Friend WithEvents BtnPesquisarNota As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cumpoVendaBindingSource As BindingSource
    Friend WithEvents DataSetCupomVenda As DataSetCupomVenda
    Friend WithEvents cumpoVendaTableAdapter As DataSetCupomVendaTableAdapters.cumpoVendaTableAdapter
    Friend WithEvents CumpoVendaBindingSource1 As BindingSource
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CupomCompraV2BindingSource As BindingSource
    Friend WithEvents CupomCompraV2TableAdapter As DataSetCupomVendaTableAdapters.CupomCompraV2TableAdapter
    Friend WithEvents GroupBox1 As GroupBox
End Class
