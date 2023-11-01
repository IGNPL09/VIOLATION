Imports System.Data.OleDb

Public Class frmAy
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub txtYearFrom_TextChanged(sender As Object, e As EventArgs) Handles txtYearFrom.TextChanged
        Try
            txtYearto.Text = CLng(txtYearFrom.Text) + 1
            txtAycode.Text = txtYearFrom.Text & "-" & txtYearto.Text & " " & cbSem.Text


        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbSem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSem.SelectedIndexChanged
        Try
            txtYearto.Text = CLng(txtYearFrom.Text) + 1
            txtAycode.Text = txtYearFrom.Text & "-" & txtYearto.Text & " " & cbSem.Text


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtYearFrom.Text = String.Empty Then
                MsgBox("Please Enter the year of your Academic School year")
                Return
            End If
            If cbSem.Text = String.Empty Then
                MsgBox("Semestral field is undefined")
                Return

            End If

            If MsgBox("SAVED THIS ACADEMIC RECORD?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDbCommand("update tblAy set status = 'CLOSE'", cn)
                cm.ExecuteNonQuery()
                cn.Close()



                cn.Open()
                cm = New OleDbCommand("insert into tblAy (aycode, year1, year2, semester)values(@aycode, @year1, @year2, @semester)", cn)
                With cm
                    .Parameters.AddWithValue("@aycode", txtAycode.Text)
                    .Parameters.AddWithValue("@year1", txtYearFrom.Text)
                    .Parameters.AddWithValue("@year2", txtYearto.Text)
                    .Parameters.AddWithValue("@semester", cbSem.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("NEW ACADEMIC YEAR HAS BEEN SUCCESSFULLY ADDED!", vbInformation)
                With frmAylist
                    .ReloadRecord1()

                End With
                Clear()
            End If
        Catch ex As Exception
            cn1.Close()
            MsgBox("THIS IS THE SAME SEMESTRAL OR ACADEMIC YEAR PLEASE ENTER THE VALID REQUIREMENT(S)")
        End Try
    End Sub
    Sub Clear()
        cbSem.Text = ""
        txtYearFrom.Clear()
        txtYearto.Clear()
        txtAycode.Clear()
    End Sub

    Private Sub cbSem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSem.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtYearFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYearFrom.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class