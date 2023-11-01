
Public Class frmMain
    Private Sub btnProgram_Click(sender As Object, e As EventArgs) Handles btnProgram.Click
        With frmProgramlist
            .TopLevel = False

            Panel3.Controls.Add(frmProgramlist)
            .BringToFront()
            .ReloadRecord1()
            .Show()

        End With
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionToDatabase1()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Dispose()
    End Sub

    Private Sub btnSection_Click(sender As Object, e As EventArgs) Handles btnSection.Click
        With FrmSectionlist
            .TopLevel = False

            Panel3.Controls.Add(FrmSectionlist)
            .BringToFront()
            .ReloadRecord1()
            .Show()
        End With
    End Sub

    Private Sub btnAcadYear_Click(sender As Object, e As EventArgs) Handles btnAcadYear.Click
        With frmAylist
            .TopLevel = False

            Panel3.Controls.Add(frmAylist)
            .BringToFront()
            .ReloadRecord1()
            .Show()
        End With
    End Sub

    Private Sub btnStudentEntry_Click(sender As Object, e As EventArgs) Handles btnStudentEntry.Click
        With frmStudentList
            .TopLevel = False
            Panel3.Controls.Add(frmStudentList)
            .BringToFront()
            .ReloadRecord1()
            .Show()
        End With
    End Sub

    Private Sub btnViolation_Click(sender As Object, e As EventArgs) Handles btnViolation.Click
        With frmViolation
            .TopLevel = False
            Panel3.Controls.Add(frmViolation)
            .BringToFront()
            .AutoSuggestStudent()
            .txtAy.Text = GetAy()
            .Show()
        End With
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        With frmRecords
            .LoadAy()
            .ShowDialog()
            .LOADRECORDS()
            .LOADVIOLATION()
        End With
    End Sub
End Class
