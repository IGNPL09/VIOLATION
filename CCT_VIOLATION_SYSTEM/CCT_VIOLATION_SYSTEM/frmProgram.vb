Imports System.Data.OleDb

Public Class frmProgram

    Private Sub txtPcode_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtPcode.Text = String.Empty Then
                MsgBox("THIS IS PCODE IS REQUIRED", vbInformation)
                Return
            End If
            If cbDesription.Text = String.Empty Then
                MsgBox("THIS IS description IS REQUIRED", vbInformation)
                Return

            End If

            If MsgBox("SAVE RECORD?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDbCommand("Insert into tblProgram(pcode, description,type)values(@pcode, @desription,@type)", cn)
                With cm
                    .Parameters.AddWithValue("@pcode", txtPcode.Text)
                    .Parameters.AddWithValue("@description", cbDesription.Text)
                    .Parameters.AddWithValue("@type", cbType.Text)
                    .ExecuteNonQuery()


                End With
                cn.Close()
                MsgBox("RECORD ADDED SUCCESSFULLY", vbInformation)
                Clear()
                With frmProgramlist
                    .ReloadRecord1()

                End With
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Sub Clear()
        txtPcode.Enabled = True
        btnSave.Enabled = True
        btnUpdate.Enabled = False

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub cbDesription_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDesription.SelectedIndexChanged

    End Sub

    Private Sub cbDesription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbDesription.KeyPress
        e.Handled = True

    End Sub

    Private Sub cbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType.SelectedIndexChanged

    End Sub

    Private Sub cbType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbType.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If MsgBox("UPDATE RECORD?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New OleDbCommand("update tblProgram set description=@description,type=@type where pcode = @pcode", cn1)
                With cm

                    .Parameters.AddWithValue("@description", cbDesription.Text)
                    .Parameters.AddWithValue("@type", cbType.Text)
                    .Parameters.AddWithValue("@pcode", txtPcode.Text)
                    btnUpdate.Enabled = True
                    btnSave.Enabled = False


                    .ExecuteNonQuery()


                End With
                cn.Close()
                MsgBox("RECORD HAS UPDATED SUCCESSFULLY", vbInformation)

                With FrmProgramlist
                    .ReloadRecord1()

                End With
                Me.Dispose()
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub frmProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtPcode.SelectedIndexChanged

    End Sub

    Private Sub txtPcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPcode.KeyPress
        e.Handled = True
    End Sub
End Class