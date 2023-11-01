Imports System.Data.OleDb

Module Module2
    Public cn As New OleDbConnection
    Public cm As New OleDbCommand
    Public dr As OleDbDataReader
    Public _USER As String = "admin"
    Sub ConnectionToDatabase1()
        Try
            cn = New OleDbConnection
            With cn
                .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\VIOLATIOLATIONSYSTEM_ACCESS.accdb"
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Function GetAy() As String
        Dim _ay As String
        cn.Open()
        cm = New OleDbCommand("Select aycode from tblAy where status like 'OPEN'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then

            _ay = dr.Item(0).ToString
        Else
            _ay = ""

        End If
        dr.Close()
        cn.Close()
        Return _ay
    End Function
End Module
