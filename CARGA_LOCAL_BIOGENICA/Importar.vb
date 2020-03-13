
Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class Importar
    Dim m As New Miselaneo
    Dim sql As New SQL

    Public Sub SimpleButton1_Click()
        DxErrorProvider1.SetError(LUEEstado, "")
        DxErrorProvider1.SetError(LUEMunicipio, "")
        If LUEEstado.EditValue = Nothing Then
            DxErrorProvider1.SetError(LUEEstado, "Seleccione Estado")
            Exit Sub
        End If
        If LUEMunicipio.EditValue = Nothing Then
            DxErrorProvider1.SetError(LUEMunicipio, "Seleccione Municipio")
            Exit Sub
        End If
        TEProcesando.Text = "Procesando"
        TEProcesando.BackColor = Color.Gray
        Dim op As New OpenFileDialog
        op.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
        Dim filepath As String
        Dim dt As New DataTable
        If op.ShowDialog = DialogResult.OK Then

            filepath = op.FileName

            Dim filestream = op.OpenFile()
            m.ExcelToCSV(op.FileName, Application.StartupPath & "\cvs.csv")
            dt = m.Read_CSV("cvs.csv", Application.StartupPath)
            dt.Columns.Add("CVE_ESTADO")
            dt.Columns.Add("CVE_MUNICIPIO")
            dt.Columns.Add("CARGA_CLAVE")

            For I As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(I).Item("CVE_ESTADO") = LUEEstado.EditValue
                dt.Rows(I).Item("CVE_MUNICIPIO") = LUEMunicipio.EditValue
                dt.Rows(I).Item("CARGA_CLAVE") = TECarga.Text
            Next

            ReDim sql.ParametersX_Global(1)
            sql.ParametersX_Global(0) = New SqlClient.SqlParameter("@CLAVE_MUESTRA", TECarga.Text)
            Dim sX = sql.fGuardar_O_EliminarXProcedure_DevuelveId("CAT_PACIENTE_E", "@Parametro", sql.ParametersX_Global)

            ReDim sql.ParametersX_Global(1)
            sql.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_MUESTRA", TECarga.Text)
            sql.ParametersX_Global(1) = New SqlClient.SqlParameter("@FECHA", DEFecha.EditValue)
            sql.datagrid(Me.CAT_PACIENTES_B, Me.CAT_PACIENTES_B._CAT_PACIENTES_B, "CAT_PACIENTES_B_MASIVA", sql.ParametersX_Global)

            For i As Integer = 0 To dt.Rows.Count - 1
                ReDim sql.ParametersX_Global(10)
                sql.ParametersX_Global(0) = New SqlClient.SqlParameter("@NOMBRE", dt.Rows(i).Item("Nombre"))
                sql.ParametersX_Global(1) = New SqlClient.SqlParameter("@AP", dt.Rows(i).Item("Paterno"))
                sql.ParametersX_Global(2) = New SqlClient.SqlParameter("@AM", dt.Rows(i).Item("Materno"))
                sql.ParametersX_Global(3) = New SqlClient.SqlParameter("@EDAD", dt.Rows(i).Item("edad"))
                sql.ParametersX_Global(4) = New SqlClient.SqlParameter("@CVE_ESTADO", dt.Rows(i).Item("CVE_ESTADO"))
                sql.ParametersX_Global(5) = New SqlClient.SqlParameter("@CVE_MUNICIPIO", dt.Rows(i).Item("CVE_MUNICIPIO"))
                sql.ParametersX_Global(6) = New SqlClient.SqlParameter("@SEXO", dt.Rows(i).Item("Sexo"))
                sql.ParametersX_Global(7) = New SqlClient.SqlParameter("@CLAVE_CARGA", dt.Rows(i).Item("CARGA_CLAVE"))
                sql.ParametersX_Global(8) = New SqlClient.SqlParameter("@FECHA", DEFecha.EditValue)
                Dim s = sql.fGuardar_O_EliminarXProcedure_DevuelveId("PACIENTES_CARGA_MASIVA_G", "@Parametro", sql.ParametersX_Global)
                If s <> Nothing Then
                    TEProcesando.Text = "Datos Cargados"
                    TEProcesando.BackColor = Color.DarkGreen
                End If

            Next
        End If
        ReDim sql.ParametersX_Global(1)
        sql.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_MUESTRA", TECarga.Text)
        sql.ParametersX_Global(1) = New SqlClient.SqlParameter("@FECHA", DEFecha.EditValue)
        sql.datagrid(Me.CAT_PACIENTES_B, Me.CAT_PACIENTES_B._CAT_PACIENTES_B, "CAT_PACIENTES_B_MASIVA", sql.ParametersX_Global)
        TECarga.Text = Now.ToString("ddMMyyyyHHMMss")

    End Sub

    Private Sub Importar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LUEEstado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        LUEMunicipio.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        TECarga.Text = Now.ToString("ddMMyyyyHHMMss")
        sql.dataset(Me.Cat_Estados.pCAT_ESTADOS_B, "pCAT_ESTADOS_B")
        DEFecha.EditValue = Now
        'sql.datagrid(Me.CAT_PACIENTES_B, Me.CAT_PACIENTES_B._CAT_PACIENTES_B, "CAT_PACIENTES_B_MASIVA")
    End Sub

    Private Sub LUEEstado_EditValueChanged(sender As Object, e As EventArgs) Handles LUEEstado.EditValueChanged
        ReDim sql.ParametersX_Global(1)
        sql.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_ESTADO", LUEEstado.EditValue)
        sql.dataset(Me.Cat_Municipios.pCAT_MUNICIPIOS_B, "pCAT_MUNICIPIOS_B", sql.ParametersX_Global)
    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        Dim elemento = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nombre")
        ID_REPORTE = elemento
        'Dim XTRA As XtraReport = New XtraReport(REPORTE_ETIQUETA)


        'XTRA.CreateDocument()
        'Dim printTool As New ReportPrintTool(XTRA)
        'printTool.PrintDialog()


    End Sub
End Class
