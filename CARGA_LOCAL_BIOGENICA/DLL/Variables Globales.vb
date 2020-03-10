Imports System.IO.Ports
Imports System.Net.Sockets

Module Variables_Globales
    Public Conexion_SQL As String
    Public Serialsport As New Dictionary(Of String, IO.Ports.SerialPort)
    Public DATASET_EQUIPO As New DataSet
    Public Scokets As New Dictionary(Of String, Socket)
    Public DLL_METODO As New Dictionary(Of String, Reflection.MethodInfo)
    Public DLL_INSTANCIA As New Dictionary(Of String, Object)
    Public equipo_id As String
    Public id_HDD As String
    Public sucursal As String
    Public POSICION As String
    Public ss As New Dictionary(Of String, TcpListener)
    Public cs As New Dictionary(Of String, TcpClient)
End Module
