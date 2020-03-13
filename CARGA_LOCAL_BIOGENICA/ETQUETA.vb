Public Class ETQUETA
    Dim SQL As New SQL
    Private Sub ETQUETA_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        ReDim SQL.ParametersX_Global(1)
        SQL.ParametersX_Global(0) = New SqlClient.SqlParameter("@ID", ID_REPORTE)
        SQL.datagrid(Me.ReportE_ETIQUETA1, Me.ReportE_ETIQUETA1._REPORTE_ETIQUETA, "REPORTE_ETIQUETA", SQL.ParametersX_Global)
    End Sub
End Class