Public Class R_ETIQUETAS
    Dim SQL As SQL
    Private Sub R_ETIQUETAS_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        ReDim SQL.ParametersX_Global(1)
        SQL.ParametersX_Global(0) = New SqlClient.SqlParameter("@ID", ID_REPORTE)
        SQL.dataset(Me.ReportE_ETIQUETA1, "REPORTE_ETIQUETA", SQL.ParametersX_Global)
    End Sub
End Class