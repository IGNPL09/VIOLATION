Imports System.Data.OleDb

Module Module1
    Public cn1 As New OleDbConnection
    Public cm1 As New OleDbCommand
    Public dr1 As OleDbDataReader

    Sub ConnectionToDatabase()
        Try
            cn1 = New OleDbConnection
            With cn1
                .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\StudentViolationAccess.accdb"
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub
End Module
