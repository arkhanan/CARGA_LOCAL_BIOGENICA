Public Class Exportar

    Dim FILEPATH As String
    Dim sql As New SQL
    Dim M As New Miselaneo
    Private Sub ButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles BEUbicacion.ButtonClick
        Dim SV As New FolderBrowserDialog
        If SV.ShowDialog = DialogResult.OK Then
            FILEPATH = SV.SelectedPath
            Me.BEUbicacion.Text = FILEPATH
        End If

    End Sub

    Private Sub Exportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILEPATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Me.BEUbicacion.Text = FILEPATH
        LUEEstado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        LUEMunicipio.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        SQL.dataset(Me.Cat_Estados.pCAT_ESTADOS_B, "pCAT_ESTADOS_B")
        DEFecha.EditValue = Now
    End Sub


    Private Sub LUEEstado_EditValueChanged(sender As Object, e As EventArgs) Handles LUEEstado.EditValueChanged
        ReDim SQL.ParametersX_Global(1)
        SQL.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_ESTADO", LUEEstado.EditValue)
        SQL.dataset(Me.Cat_Municipios.pCAT_MUNICIPIOS_B, "pCAT_MUNICIPIOS_B", SQL.ParametersX_Global)
    End Sub

    Private Sub DEFecha_EditValueChanged(sender As Object, e As EventArgs) Handles DEFecha.EditValueChanged
        ReDim sql.ParametersX_Global(2)
        If LUEEstado.EditValue = Nothing Then Exit Sub
        sql.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_ESTADO", LUEEstado.EditValue)
        sql.ParametersX_Global(1) = New SqlClient.SqlParameter("@CVE_MUNICIPIO", LUEMunicipio.EditValue)
        sql.ParametersX_Global(2) = New SqlClient.SqlParameter("@FECHA", DEFecha.EditValue)
        sql.datagrid(Me.CAT_PACIENTES_B, Me.CAT_PACIENTES_B._CAT_PACIENTES_B, "PACIENTES_EXPORTAR_B", sql.ParametersX_Global)

    End Sub

    Private Sub LUEMunicipio_EditValueChanged(sender As Object, e As EventArgs) Handles LUEMunicipio.EditValueChanged
        ReDim sql.ParametersX_Global(2)
        If LUEEstado.EditValue = Nothing Then Exit Sub
        sql.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_ESTADO", LUEEstado.EditValue)
        sql.ParametersX_Global(1) = New SqlClient.SqlParameter("@CVE_MUNICIPIO", LUEMunicipio.EditValue)
        sql.ParametersX_Global(2) = New SqlClient.SqlParameter("@FECHA", DEFecha.EditValue)
        sql.datagrid(Me.CAT_PACIENTES_B, Me.CAT_PACIENTES_B._CAT_PACIENTES_B, "PACIENTES_EXPORTAR_B", sql.ParametersX_Global)
    End Sub

    Public Sub PROCESAR()
        Dim dt As New DataTable
        ReDim sql.ParametersX_Global(2)
        If LUEEstado.EditValue = Nothing Then Exit Sub
        sql.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_ESTADO", LUEEstado.EditValue)
        sql.ParametersX_Global(1) = New SqlClient.SqlParameter("@CVE_MUNICIPIO", LUEMunicipio.EditValue)
        sql.ParametersX_Global(2) = New SqlClient.SqlParameter("@FECHA", DEFecha.EditValue)
        dt = sql.llenar_dt("pacientes_excel", sql.ParametersX_Global)

        M.DatatableToExcel(dt)
    End Sub



End Class
