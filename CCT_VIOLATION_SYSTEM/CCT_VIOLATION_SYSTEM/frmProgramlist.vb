Imports System.Data.OleDb

Public Class frmProgramlist
    Private Sub addNew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addNew.LinkClicked
        With frmProgram
            .btnSave.Enabled = True
            .btnUpdate.Enabled = False
            .ShowDialog()

        End With


    End Sub

    Sub ReloadRecord1()
        DataGridView1.Rows.Clear()
        Dim i As Integer
        cn.Open()
        cm = New OleDbCommand("select * from tblProgram", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("pcode").ToString, dr.Item("description").ToString, dr.Item("type").ToString)

        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "ColEdit" Then
            With frmProgram
                .txtPcode.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .cbDesription.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .cbType.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString

                .txtPcode.Enabled = False
                .btnSave.Enabled = False
                .btnUpdate.Enabled = True
                .ShowDialog()
            End With
        ElseIf colname = "Coldelete" Then
            If (MsgBox("DDELETE THIS RECORD?", vbYesNo + vbQuestion) = vbYes) Then
                cn.Open()
                cm = New OleDbCommand("delete from tblProgram where pcode like  '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()

                MsgBox("RECORD HAS BEEN SUCCESSFULLY DELETED.", vbInformation)
                ReloadRecord1()
            End If

        End If
    End Sub

    Private Sub exitPic_Click(sender As Object, e As EventArgs) Handles exitPic.Click
        Me.Dispose()
    End Sub
End Class