<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Course
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcourse = New System.Windows.Forms.Label()
        Me.txtcoursename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.addBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.listCourse = New System.Windows.Forms.ListBox()
        Me.deleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(200, 729)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(730, 132)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(279, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 41)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "COURSE"
        '
        'lblcourse
        '
        Me.lblcourse.AutoSize = True
        Me.lblcourse.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourse.Location = New System.Drawing.Point(239, 189)
        Me.lblcourse.Name = "lblcourse"
        Me.lblcourse.Size = New System.Drawing.Size(263, 29)
        Me.lblcourse.TabIndex = 45
        Me.lblcourse.Text = "Course name"
        '
        'txtcoursename
        '
        Me.txtcoursename.BorderRadius = 8
        Me.txtcoursename.BorderThickness = 0
        Me.txtcoursename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcoursename.DefaultText = ""
        Me.txtcoursename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcoursename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcoursename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcoursename.DisabledState.Parent = Me.txtcoursename
        Me.txtcoursename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcoursename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcoursename.FocusedState.Parent = Me.txtcoursename
        Me.txtcoursename.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtcoursename.ForeColor = System.Drawing.Color.Black
        Me.txtcoursename.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcoursename.HoverState.Parent = Me.txtcoursename
        Me.txtcoursename.Location = New System.Drawing.Point(526, 182)
        Me.txtcoursename.Name = "txtcoursename"
        Me.txtcoursename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcoursename.PlaceholderText = ""
        Me.txtcoursename.SelectedText = ""
        Me.txtcoursename.ShadowDecoration.Parent = Me.txtcoursename
        Me.txtcoursename.Size = New System.Drawing.Size(200, 36)
        Me.txtcoursename.TabIndex = 44
        '
        'addBtn
        '
        Me.addBtn.AutoRoundedCorners = True
        Me.addBtn.BorderRadius = 21
        Me.addBtn.CheckedState.Parent = Me.addBtn
        Me.addBtn.CustomImages.Parent = Me.addBtn
        Me.addBtn.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.addBtn.ForeColor = System.Drawing.Color.Black
        Me.addBtn.HoverState.Parent = Me.addBtn
        Me.addBtn.Location = New System.Drawing.Point(452, 252)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.ShadowDecoration.Parent = Me.addBtn
        Me.addBtn.Size = New System.Drawing.Size(180, 45)
        Me.addBtn.TabIndex = 46
        Me.addBtn.Text = "Add"
        '
        'listCourse
        '
        Me.listCourse.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listCourse.FormattingEnabled = True
        Me.listCourse.ItemHeight = 28
        Me.listCourse.Location = New System.Drawing.Point(359, 304)
        Me.listCourse.Margin = New System.Windows.Forms.Padding(4)
        Me.listCourse.Name = "listCourse"
        Me.listCourse.Size = New System.Drawing.Size(385, 312)
        Me.listCourse.TabIndex = 214
        '
        'deleteBtn
        '
        Me.deleteBtn.AutoRoundedCorners = True
        Me.deleteBtn.BorderRadius = 21
        Me.deleteBtn.CheckedState.Parent = Me.deleteBtn
        Me.deleteBtn.CustomImages.Parent = Me.deleteBtn
        Me.deleteBtn.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.deleteBtn.ForeColor = System.Drawing.Color.Black
        Me.deleteBtn.HoverState.Parent = Me.deleteBtn
        Me.deleteBtn.Location = New System.Drawing.Point(452, 659)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.ShadowDecoration.Parent = Me.deleteBtn
        Me.deleteBtn.Size = New System.Drawing.Size(180, 45)
        Me.deleteBtn.TabIndex = 215
        Me.deleteBtn.Text = "Delete"
        '
        'Course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(930, 729)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.listCourse)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.lblcourse)
        Me.Controls.Add(Me.txtcoursename)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Course"
        Me.Text = "Course"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcourse As Label
    Friend WithEvents txtcoursename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents addBtn As Guna.UI2.WinForms.Guna2Button
    Private WithEvents listCourse As ListBox
    Friend WithEvents deleteBtn As Guna.UI2.WinForms.Guna2Button
End Class
