Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class frmViolation
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub exitPic_Click(sender As Object, e As EventArgs) Handles exitPic.Click
        Me.Dispose()
    End Sub
    Sub AutoSuggestStudent()

        cn.Open()
        cm = New OleDbCommand("select * from qStudent ", cn)
        Using ds As New DataSet
            Dim da As New OleDbDataAdapter(cm)
            da.Fill(ds, "Student")
            cn.Close()
            Dim col As New AutoCompleteStringCollection

            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("fullname").ToString)
            Next
            cn.Close()
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtSearch.AutoCompleteCustomSource = col
        End Using

        txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub
    Sub Clear()
        txtname.Clear()
        txtprogram.Clear()
        txtNo.Clear()
        txtSanction.Clear()

        txtviolation.Clear()
        txtsection.Clear()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            cn.Open()
            cm = New OleDbCommand("select * from qStudent where fullname = @fullname", cn)
            cm.Parameters.AddWithValue("@fullname", txtSearch.Text)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtNo.Text = dr.Item("StudentNo").ToString
                txtname.Text = dr.Item("fullname").ToString
                txtprogram.Text = dr.Item("pcode").ToString
                txtsection.Text = dr.Item("section").ToString

                dr.Close()
                cn.Close()
                loadRecords()

            Else
                Clear()


            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()

            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType.SelectedIndexChanged

    End Sub

    Private Sub cbType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbType.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If MsgBox("Save this VIOLATION?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDbCommand("insert into  tblViolation (StudentNo,aycode,sdate,violation,sanction,type,[user])values(@studentNo,@aycode,@sdate,@violation,@sanction,@type,@user)", cn)
                With cm
                    .Parameters.AddWithValue("@StudentNo", txtNo.Text)
                    .Parameters.AddWithValue("@aycode", txtAy.Text)
                    .Parameters.AddWithValue("@sdate", Now.Date)
                    .Parameters.AddWithValue("@violation", txtviolation.Text)
                    .Parameters.AddWithValue("@sanction", txtSanction.Text)
                    .Parameters.AddWithValue("@type", cbType.Text)
                    .Parameters.AddWithValue("@user", _USER)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("Record has Saved Successfully", vbInformation)
                loadRecords()

            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Sub loadRecords()

        Try
            Dim i As Integer
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New OleDbCommand("Select v.ID, v.StudentNo,s.fullname, s.pcode, s.[section], v.aycode, v.violation, v.sanction, v.type, v.[user] from tblViolation as v inner join qStudent as s on s.StudentNo = v.StudentNo where v.StudentNo like '" & txtNo.Text & "' and aycode like '" & txtAy.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("StudentNo").ToString, dr.Item("fullname").ToString, dr.Item("pcode").ToString, dr.Item("section").ToString, dr.Item("aycode").ToString, dr.Item("violation").ToString, dr.Item("sanction").ToString, dr.Item("type").ToString, dr.Item("user").ToString)
            End While

            dr.Close()

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
        txtSearch.Clear()
        loadRecords()
    End Sub
End Class