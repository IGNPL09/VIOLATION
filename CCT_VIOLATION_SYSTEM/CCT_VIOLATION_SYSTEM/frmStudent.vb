Imports System.Data.OleDb

Public Class frmStudent
    Private Sub cbProgramLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgramLevel.SelectedIndexChanged
        cbSection.Items.Clear()
        cn.Open()
        cm = New OleDbCommand("select * from tblSection where pcode = @pcode", cn)
        cm.Parameters.AddWithValue("@pcode", cbProgramLevel.Text)

        dr = cm.ExecuteReader
        While dr.Read
            cbSection.Items.Add(dr.Item("section").ToString)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub cbProgramLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbProgramLevel.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSection.SelectedIndexChanged

    End Sub

    Private Sub cbSection_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSection.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If MsgBox("SAVE THIS RECORD?", vbYesNo + vbQuestion) = vbYes Then
                Dim sectionId1 As String
                cn.Open()
                cm = New OleDbCommand("select * from tblSection where [section] Like '" & cbSection.Text & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then sectionId1 = dr.Item("sectionId").ToString Else sectionId1 = ""
                dr.Close()
                cn.Close()

                Dim imagestring As New System.IO.MemoryStream
                userProfile.BackgroundImage.Save(imagestring, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = imagestring.GetBuffer


                cn.Open()
                cm = New OleDbCommand("insert into tblStudent(StudentNo,lname,fname,mname,sectionid,address,contact,pic)values(@StudentNo,@lname,@fname,@mname,@sectionid,@address,@contact,@pic)", cn)
                With cm
                    If txtStudentNo.Text = String.Empty Then
                        MsgBox("YOUR STUDENT NUMBER?", vbInformation)
                    Else
                        .Parameters.AddWithValue("@studentNo", txtStudentNo.Text)
                    End If


                    .Parameters.AddWithValue("@lname", txtLname.Text)
                    .Parameters.AddWithValue("@fname", txtFname.Text)
                    .Parameters.AddWithValue("@mname", txtMname.Text)
                    .Parameters.AddWithValue("@sectionId", sectionId1)
                    .Parameters.AddWithValue("@address", txtAddress.Text)
                    .Parameters.AddWithValue("@contact", txtContact.Text)
                    .Parameters.AddWithValue("@pic", arrImage)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("RECORDS HAS BEEN SUCCESSFULLY SAVED", vbInformation)
                Clear()
                frmStudentList.ReloadRecord1()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox("YOU NEED TO FILL UP THE REQUIREMENTS")
        End Try
    End Sub

    Private Sub btnUploadProfile_Click(sender As Object, e As EventArgs) Handles btnUploadProfile.Click
        Using ofd As New OpenFileDialog With {.Filter = "(Image Files)|*.jpg;*.png;|Jpg,|*.png", .Multiselect = False, .Title = "Select Image"}
            If ofd.ShowDialog = 1 Then
                userProfile.BackgroundImage = Image.FromFile(ofd.FileName)
                OpenFileDialog1.FileName = ofd.FileName

            End If
        End Using
    End Sub
    Sub LoadProgramLevel()
        cbProgramLevel.Items.Clear()

        cn.Open()
        cm = New OleDbCommand("select * from tblProgram", cn)
        dr = cm.ExecuteReader
        While dr.Read
            cbProgramLevel.Items.Add(dr.Item("pcode").ToString())
        End While
        dr.Close()
        cn.Close()



    End Sub

    Sub Clear()
        txtAddress.Clear()
        txtContact.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtContact.Enabled = True
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        userProfile.BackgroundImage = Image.FromFile(Application.StartupPath & "\pr1.png")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub txtStudentNo_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNo.TextChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If MsgBox("UPDATE THIS RECORD?", vbYesNo + vbQuestion) = vbYes Then
                Dim sectionId1 As String
                cn.Open()
                cm = New OleDbCommand("select * from tblSection where [section] Like '" & cbSection.Text & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then sectionId1 = dr.Item("sectionId").ToString Else sectionId1 = ""
                dr.Close()
                cn.Close()

                Dim imagestring As New System.IO.MemoryStream
                userProfile.BackgroundImage.Save(imagestring, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = imagestring.GetBuffer


                cn.Open()
                If OpenFileDialog1.FileName <> "OpenFileDialog1" Then
                    cm = New OleDbCommand("update tblStudent set lname=@lanme ,fname=@fanme ,mname=@mname, sectionid=@sectionid ,address=@address ,contact=@contact ,pic=@pic where StudentNo = @StudentNo", cn)
                Else
                    cm = New OleDbCommand("update tblStudent set lname=@lanme ,fname=@fanme ,mname=@mname, sectionid=@sectionid ,address=@address ,contact=@contact where StudentNo = @StudentNo", cn)

                End If

                With cm

                    .Parameters.AddWithValue("@lname", txtLname.Text)
                    .Parameters.AddWithValue("@fname", txtFname.Text)
                    .Parameters.AddWithValue("@mname", txtMname.Text)
                    .Parameters.AddWithValue("@sectionId", sectionId1)
                    .Parameters.AddWithValue("@address", txtAddress.Text)
                    .Parameters.AddWithValue("@contact", txtContact.Text)
                    If OpenFileDialog1.FileName <> "OpenFileDialog1" Then .Parameters.AddWithValue("@pic", arrImage)
                    .Parameters.AddWithValue("@studentNo", txtStudentNo.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("RECORDS HAS BEEN SUCCESSFULLY updated", vbInformation)
                Clear()
                frmStudentList.ReloadRecord1()
                Me.Dispose()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged

    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtStudentNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentNo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class