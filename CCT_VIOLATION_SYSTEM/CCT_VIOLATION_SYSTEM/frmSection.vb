Imports System.Data.OleDb

Public Class frmSection
    Sub loadPcode()
        cn.Open()
        cm = New OleDbCommand("select * from  tblProgram", cn)
        dr = cm.ExecuteReader
        While dr.Read
            cbPcode.Items.Add(dr.Item("pcode").ToString)
        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtSection.Text = String.Empty Then
                MsgBox("Empy field must be fill")
                Return

            End If
            If cbPcode.Text = String.Empty Then
                MsgBox("Empy field must be fill")
                Return

            End If
            If MsgBox("SAVE THIS RECORD? ", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDbCommand("insert into tblSection ([section],pcode)values(@section,@pcode)", cn)
                With cm
                    .Parameters.AddWithValue("@section", txtSection.Text)
                    .Parameters.AddWithValue("@pcode", cbPcode.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("RECORD HAS SUCCESSFULLY SAVED", vbInformation)
                With FrmSectionlist
                    .ReloadRecord1()
                End With
                Clear()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Sub Clear()
        txtSection.Clear()
        txtsectionId.Text = "(Auto)"
        cbPcode.Text = ""
        btnSave.Enabled = True
        btnUpdate.Enabled = False

    End Sub

    Sub Clear1()
        txtSection.Clear()
        txtsectionId.Text = "(Auto)"
        cbPcode.Text = ""
        btnSave.Enabled = False
        btnUpdate.Enabled = True

    End Sub

    Private Sub frmSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        Try

            If txtSection.Text = String.Empty Then
                MsgBox("Empy field must be fill")
                Return

            End If
            If cbPcode.Text = String.Empty Then
                MsgBox("Empy field must be fill")
                Return

            End If
            If MsgBox("UPDATE THIS RECORD? ", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDbCommand("UPDATE  tblSection set [section] =@section,  pcode = @pcode where sectionId = @id", cn)
                With cm
                    .Parameters.AddWithValue("@section", txtSection.Text)
                    .Parameters.AddWithValue("@pcode", cbPcode.Text)
                    .Parameters.AddWithValue("@id", txtsectionId.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("RECORD HAS SUCCESSFULLY UPDATED ", vbInformation)
                With FrmSectionlist
                    .ReloadRecord1()
                End With
                Clear1()

            End If
        Catch ex As Exception
            cn1.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub txtSection_TextChanged(sender As Object, e As EventArgs) Handles txtSection.TextChanged

    End Sub

    Private Sub cbPcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPcode.SelectedIndexChanged

    End Sub

    Private Sub cbPcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbPcode.KeyPress
        e.Handled = True
    End Sub
End Class