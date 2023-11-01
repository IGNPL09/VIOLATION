Imports System.Data.OleDb
Imports System.IO
Public Class frmStudentList


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colEdit" Then
            Dim _program, _section As String

            cn.Open()
            cm = New OleDbCommand("Select pic, studentno, lname,fname,mname, address, contact, pcode, [section] from qStudent where StudentNo like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                With frmStudent
                    Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                    Dim array(CInt(len)) As Byte
                    dr.GetBytes(0, 0, array, 0, CInt(len))

                    Dim ms As New MemoryStream(array)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    .txtStudentNo.Enabled = False

                    .txtStudentNo.Text = dr.Item("StudentNo").ToString
                    .txtLname.Text = dr.Item("lname").ToString
                    .txtFname.Text = dr.Item("fname").ToString
                    .txtMname.Text = dr.Item("mname").ToString
                    .txtAddress.Text = dr.Item("address").ToString
                    .txtContact.Text = dr.Item("contact").ToString
                    _program = dr.Item("pcode").ToString
                    _section = dr.Item("section").ToString
                    .userProfile.BackgroundImage = bitmap
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    dr.Close()
                    cn.Close()

                    .LoadProgramLevel()
                    .cbProgramLevel.Text = _program
                    .cbSection.Text = _section
                    .ShowDialog()
                End With
            Else
                dr.Close()
                cn.Close()
            End If
        ElseIf colname = "colDelete" Then
            If (MsgBox("DELETE THIS RECORD?", vbYesNo + vbQuestion) = vbYes) Then
                cn.Open()
                cm = New OleDbCommand("Delete from tblStudent where StudentNo like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("RECORD HAS DELETED SUCCESSFULLY", vbInformation)
                ReloadRecord1()
            End If
        End If
    End Sub

    Private Sub exitPic_Click(sender As Object, e As EventArgs) Handles exitPic.Click
        Me.Dispose()
    End Sub

    Private Sub addNew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addNew.LinkClicked
        With frmStudent
            .Clear()
            .LoadProgramLevel()
            .ShowDialog()

        End With
    End Sub
    Sub ReloadRecord1()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        cn.Open()
        cm = New OleDbCommand("select * from qStudent", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("StudentNo").ToString, dr.Item("lname").ToString, dr.Item("fname").ToString, dr.Item("mname").ToString, dr.Item("sectionId").ToString, dr.Item("pcode").ToString, dr.Item("section").ToString, dr.Item("address").ToString, dr.Item("contact").ToString)
        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub frmStudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class