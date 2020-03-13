<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class R_ETIQUETAS
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportE_ETIQUETA1 = New CARGA_LOCAL_BIOGENICA.REPORTE_ETIQUETA()
        Me.REPORTE_ETIQUETATableAdapter = New CARGA_LOCAL_BIOGENICA.REPORTE_ETIQUETATableAdapters.REPORTE_ETIQUETATableAdapter()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.ReportE_ETIQUETA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 100.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportE_ETIQUETA1
        '
        Me.ReportE_ETIQUETA1.DataSetName = "REPORTE_ETIQUETA"
        Me.ReportE_ETIQUETA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REPORTE_ETIQUETATableAdapter
        '
        Me.REPORTE_ETIQUETATableAdapter.ClearBeforeFill = True
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "REPORTE_ETIQUETA.NOMBRE")})
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 10.37501!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(212.0!, 23.0!)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "REPORTE_ETIQUETA.FECHA")})
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 53.08332!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(212.0!, 23.0!)
        Me.XrLabel2.Text = "XrLabel2"
        '
        'R_ETIQUETAS
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataAdapter = Me.REPORTE_ETIQUETATableAdapter
        Me.DataMember = "REPORTE_ETIQUETA"
        Me.DataSource = Me.ReportE_ETIQUETA1
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageWidth = 232
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.RollPaper = True
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.1"
        CType(Me.ReportE_ETIQUETA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportE_ETIQUETA1 As REPORTE_ETIQUETA
    Friend WithEvents REPORTE_ETIQUETATableAdapter As REPORTE_ETIQUETATableAdapters.REPORTE_ETIQUETATableAdapter
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
