
Imports System.IO



Public Class Importar
    Dim m As New Miselaneo
    Dim sql As New SQL

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Dim op As New OpenFileDialog
        Dim filepath As String
        Dim dt As New DataTable
        If op.ShowDialog = DialogResult.OK Then
            filepath = op.FileName
            Dim filestream = op.OpenFile()
            m.ExcelToCSV(op.FileName, Application.StartupPath & "\cvs.csv")
            dt = m.Read_CSV("cvs.csv", Application.StartupPath)

            For I As Integer = 0 To dt.Rows.Count - 1

            Next






        End If

    End Sub

    Private Sub Importar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LUEEstado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        LUEMunicipio.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        TECarga.Text = Now.ToString("ddMMyyyyHHMMss")
        sql.dataset(Me.Cat_Estados.pCAT_ESTADOS_B, "pCAT_ESTADOS_B")
    End Sub

    Private Sub LUEEstado_EditValueChanged(sender As Object, e As EventArgs) Handles LUEEstado.EditValueChanged
        ReDim sql.ParametersX_Global(1)
        sql.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_ESTADO", LUEEstado.EditValue)
        sql.dataset(Me.Cat_Municipios.pCAT_MUNICIPIOS_B, "pCAT_MUNICIPIOS_B", sql.ParametersX_Global)
    End Sub


End Class
