<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.btnAcadYear = New System.Windows.Forms.Button()
        Me.btnSection = New System.Windows.Forms.Button()
        Me.btnProgram = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnViolation = New System.Windows.Forms.Button()
        Me.btnStudentEntry = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.admin = New System.Windows.Forms.Label()
        Me.usernamelbl = New System.Windows.Forms.Label()
        Me.SchoolLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SchoolLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Location = New System.Drawing.Point(245, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1067, 726)
        Me.Panel3.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnOut)
        Me.Panel1.Controls.Add(Me.btnAcadYear)
        Me.Panel1.Controls.Add(Me.btnSection)
        Me.Panel1.Controls.Add(Me.btnProgram)
        Me.Panel1.Controls.Add(Me.btnRecords)
        Me.Panel1.Controls.Add(Me.btnViolation)
        Me.Panel1.Controls.Add(Me.btnStudentEntry)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 726)
        Me.Panel1.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 691)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(252, 35)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "           LOGOUT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnOut
        '
        Me.btnOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOut.FlatAppearance.BorderSize = 0
        Me.btnOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOut.Image = CType(resources.GetObject("btnOut.Image"), System.Drawing.Image)
        Me.btnOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOut.Location = New System.Drawing.Point(0, 504)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnOut.Size = New System.Drawing.Size(252, 35)
        Me.btnOut.TabIndex = 12
        Me.btnOut.Text = "           USER ACCOUNT"
        Me.btnOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOut.UseVisualStyleBackColor = True
        '
        'btnAcadYear
        '
        Me.btnAcadYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcadYear.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAcadYear.FlatAppearance.BorderSize = 0
        Me.btnAcadYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnAcadYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnAcadYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcadYear.Image = CType(resources.GetObject("btnAcadYear.Image"), System.Drawing.Image)
        Me.btnAcadYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcadYear.Location = New System.Drawing.Point(0, 469)
        Me.btnAcadYear.Name = "btnAcadYear"
        Me.btnAcadYear.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnAcadYear.Size = New System.Drawing.Size(252, 35)
        Me.btnAcadYear.TabIndex = 11
        Me.btnAcadYear.Text = "           ACADEMIC YEAR"
        Me.btnAcadYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcadYear.UseVisualStyleBackColor = True
        '
        'btnSection
        '
        Me.btnSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSection.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSection.FlatAppearance.BorderSize = 0
        Me.btnSection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSection.Image = CType(resources.GetObject("btnSection.Image"), System.Drawing.Image)
        Me.btnSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSection.Location = New System.Drawing.Point(0, 434)
        Me.btnSection.Name = "btnSection"
        Me.btnSection.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnSection.Size = New System.Drawing.Size(252, 35)
        Me.btnSection.TabIndex = 10
        Me.btnSection.Text = "           SECTION"
        Me.btnSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSection.UseVisualStyleBackColor = True
        '
        'btnProgram
        '
        Me.btnProgram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProgram.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProgram.FlatAppearance.BorderSize = 0
        Me.btnProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgram.Image = CType(resources.GetObject("btnProgram.Image"), System.Drawing.Image)
        Me.btnProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgram.Location = New System.Drawing.Point(0, 399)
        Me.btnProgram.Name = "btnProgram"
        Me.btnProgram.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnProgram.Size = New System.Drawing.Size(252, 35)
        Me.btnProgram.TabIndex = 9
        Me.btnProgram.Text = "           PROGRAM"
        Me.btnProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgram.UseVisualStyleBackColor = True
        '
        'btnRecords
        '
        Me.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecords.FlatAppearance.BorderSize = 0
        Me.btnRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Image = CType(resources.GetObject("btnRecords.Image"), System.Drawing.Image)
        Me.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecords.Location = New System.Drawing.Point(0, 364)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnRecords.Size = New System.Drawing.Size(252, 35)
        Me.btnRecords.TabIndex = 8
        Me.btnRecords.Text = "           RECORDS"
        Me.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecords.UseVisualStyleBackColor = True
        '
        'btnViolation
        '
        Me.btnViolation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViolation.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnViolation.FlatAppearance.BorderSize = 0
        Me.btnViolation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnViolation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnViolation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViolation.Image = CType(resources.GetObject("btnViolation.Image"), System.Drawing.Image)
        Me.btnViolation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViolation.Location = New System.Drawing.Point(0, 329)
        Me.btnViolation.Name = "btnViolation"
        Me.btnViolation.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnViolation.Size = New System.Drawing.Size(252, 35)
        Me.btnViolation.TabIndex = 7
        Me.btnViolation.Text = "           VIOLATION ENTRY"
        Me.btnViolation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViolation.UseVisualStyleBackColor = True
        '
        'btnStudentEntry
        '
        Me.btnStudentEntry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentEntry.FlatAppearance.BorderSize = 0
        Me.btnStudentEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnStudentEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnStudentEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentEntry.Image = CType(resources.GetObject("btnStudentEntry.Image"), System.Drawing.Image)
        Me.btnStudentEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentEntry.Location = New System.Drawing.Point(0, 294)
        Me.btnStudentEntry.Name = "btnStudentEntry"
        Me.btnStudentEntry.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnStudentEntry.Size = New System.Drawing.Size(252, 35)
        Me.btnStudentEntry.TabIndex = 6
        Me.btnStudentEntry.Text = "           STUDENT ENTRY"
        Me.btnStudentEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentEntry.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(252, 35)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "           DASHBOARD"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.admin)
        Me.Panel2.Controls.Add(Me.usernamelbl)
        Me.Panel2.Controls.Add(Me.SchoolLogo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(252, 259)
        Me.Panel2.TabIndex = 0
        '
        'admin
        '
        Me.admin.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin.ForeColor = System.Drawing.Color.White
        Me.admin.Location = New System.Drawing.Point(0, 231)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(257, 23)
        Me.admin.TabIndex = 3
        Me.admin.Text = "Administrator"
        Me.admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usernamelbl
        '
        Me.usernamelbl.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelbl.ForeColor = System.Drawing.Color.White
        Me.usernamelbl.Location = New System.Drawing.Point(0, 208)
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Size = New System.Drawing.Size(257, 23)
        Me.usernamelbl.TabIndex = 2
        Me.usernamelbl.Text = "CCT"
        Me.usernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SchoolLogo
        '
        Me.SchoolLogo.Image = CType(resources.GetObject("SchoolLogo.Image"), System.Drawing.Image)
        Me.SchoolLogo.Location = New System.Drawing.Point(3, 1)
        Me.SchoolLogo.Name = "SchoolLogo"
        Me.SchoolLogo.Size = New System.Drawing.Size(236, 206)
        Me.SchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SchoolLogo.TabIndex = 1
        Me.SchoolLogo.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 726)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.SchoolLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents btnAcadYear As Button
    Friend WithEvents btnSection As Button
    Friend WithEvents btnProgram As Button
    Friend WithEvents btnRecords As Button
    Friend WithEvents btnViolation As Button
    Friend WithEvents btnStudentEntry As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents admin As Label
    Friend WithEvents usernamelbl As Label
    Friend WithEvents SchoolLogo As PictureBox
End Class
