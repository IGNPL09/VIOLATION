Imports System.Data.OleDb

Public Class frmAylist
    Private Sub exitPic_Click(sender As Object, e As EventArgs) Handles exitPic.Click
        Me.Dispose()
    End Sub
    Sub ReloadRecord1()
        DataGridView1.Rows.Clear()
        Dim i As Integer

        cn.Open()
        cm = New OleDbCommand("select * from  tblAy", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("aycode").ToString, dr.Item("year1").ToString, dr.Item("year2").ToString, dr.Item("semester").ToString, dr.Item("status").ToString)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub addNew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addNew.LinkClicked
        With frmAy
            .ShowDialog()

        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "colOpen" Then
            If MsgBox("OPEN THIS ACADEMIC YEAR?" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then

                cn.Open()
                cm = New OleDbCommand("update tblAy set status = 'CLOSE'", cn)
                cm.ExecuteReader()
                cn.Close()

                cn.Open()
                cm = New OleDbCommand("update tblAy set status = 'OPEN' where aycode like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()

                MsgBox("ACADEMIC YEAR" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & " HAS BEEN SUCCESSFULLY OPENED.", vbInformation)
                ReloadRecord1()

            End If
        ElseIf colname = "colClose" Then
            If MsgBox("CLOSE THIS ACADEMIC YEAR?" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDbCommand("update tblAy set status = 'CLOSE' where aycode like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()

                MsgBox("ACADEMIC YEAR" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & " HAS BEEN SUCCESSFULLY CLOSED.", vbInformation)
                ReloadRecord1()

            End If
        End If
    End Sub
End Class