Imports System.Configuration
Imports System.Data.OleDb
Imports System.Reflection.Emit

Public Class FrmSectionlist



    Private Sub addNew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addNew.LinkClicked
        With frmSection

            .txtsectionId.Text = "(Auto)"
            .btnSave.Enabled = True
            .btnUpdate.Enabled = False
            .loadPcode()
            .ShowDialog()

        End With
    End Sub

    Private Sub exitPic_Click(sender As Object, e As EventArgs) Handles exitPic.Click
        Me.Dispose()


    End Sub
    Sub ReloadRecord1()
        DataGridView1.Rows.Clear()
        Dim i As Integer
        cn.Open()
        cm = New OleDbCommand("select * from tblSection", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("sectionId").ToString, dr.Item("section").ToString, dr.Item("pcode").ToString)

        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "ColEdit" Then
            With frmSection
                .btnSave.Enabled = False
                .txtsectionId.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .txtSection.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .cbPcode.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .loadPcode()
                .ShowDialog()

            End With
        ElseIf colname = "Coldelete" Then
            If (MsgBox("DELETE THIS RECORD?", vbYesNo + vbQuestion) = vbYes) Then
                cn.Open()
                cm = New OleDbCommand("delete from tblSection where sectionId like  '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()

                MsgBox("RECORD HAS BEEN SUCCESSFULLY DELETED.", vbInformation)
                ReloadRecord1()
            End If

        End If
    End Sub
End Class