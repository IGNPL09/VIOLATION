Imports System.Data.OleDb

Public Class frmRecords
    Dim _id As String

    Private Sub cbAycode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAycode.SelectedIndexChanged
        LOADRECORDS()
    End Sub

    Private Sub cbAycode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbAycode.KeyPress
        e.Handled = True
    End Sub
    Sub LoadAy()
        cbAycode.Items.Clear()
        cn.Open()
        cm = New OleDbCommand("select * from tblAy", cn)
        dr = cm.ExecuteReader
        While dr.Read
            cbAycode.Items.Add(dr.Item("aycode").ToString)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub frmRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub LOADRECORDS()
        Dim i As Integer
        DataGridView1.Rows.Clear()

        cn.Open()
        cm = New OleDbCommand("select * from qViolation  where aycode like '" & cbAycode.Text & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("StudentNo").ToString, dr.Item("fullname").ToString, dr.Item("pcode").ToString, dr.Item("section").ToString, dr.Item("totalviolation").ToString)
        End While
        dr.Close()
        cn.Close()

    End Sub

    Sub LOADVIOLATION()
        Dim i As Integer
        DataGridView2.Rows.Clear()
        cn.Open()
        cm = New OleDbCommand("SELECT * FROM tblViolation WHERE aycode LIKE @aycode AND (StudentNo = @studentNo OR @studentNo = '')", cn)
        cm.Parameters.AddWithValue("@aycode", cbAycode.Text)

        Dim studentNo As String = If(String.IsNullOrEmpty(_id), "", _id)
        cm.Parameters.AddWithValue("@studentNo", studentNo)

        dr = cm.ExecuteReader()

        While dr.Read
            i += 1
            DataGridView2.Rows.Add(i, FormatDate(dr.Item("sdate").ToString), dr.Item("violation").ToString, dr.Item("sanction").ToString, dr.Item("type").ToString, dr.Item("user").ToString)
        End While

        dr.Close()
        cn.Close()
    End Sub


    Function FormatDate(dateString As String) As String
        Dim parsedDate As Date
        If Date.TryParse(dateString, parsedDate) Then
            Return parsedDate.ToString("MMM-dd-yyyy")
        Else
            Return dateString
        End If
    End Function




    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colDisplay" Then
            _id = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            LOADVIOLATION()
        End If
    End Sub


    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub exitPic_Click(sender As Object, e As EventArgs) Handles exitPic.Click
        Me.Dispose()
    End Sub
End Class