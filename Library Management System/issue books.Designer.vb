<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class issue_books
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmemname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbooktitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dateDue = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dateBorrow = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnIssue = New Guna.UI2.WinForms.Guna2Button()
        Me.searchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmemberid = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(200, 732)
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
        Me.Guna2Panel2.Size = New System.Drawing.Size(820, 131)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(272, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 41)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Issue Book"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(241, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 29)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Book id"
        '
        'txtbid
        '
        Me.txtbid.BorderRadius = 8
        Me.txtbid.BorderThickness = 0
        Me.txtbid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbid.DefaultText = ""
        Me.txtbid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbid.DisabledState.Parent = Me.txtbid
        Me.txtbid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbid.FocusedState.Parent = Me.txtbid
        Me.txtbid.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtbid.ForeColor = System.Drawing.Color.Black
        Me.txtbid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbid.HoverState.Parent = Me.txtbid
        Me.txtbid.Location = New System.Drawing.Point(549, 155)
        Me.txtbid.Name = "txtbid"
        Me.txtbid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbid.PlaceholderText = ""
        Me.txtbid.SelectedText = ""
        Me.txtbid.ShadowDecoration.Parent = Me.txtbid
        Me.txtbid.Size = New System.Drawing.Size(200, 36)
        Me.txtbid.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(313, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 29)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Member Name"
        '
        'txtmemname
        '
        Me.txtmemname.BorderRadius = 8
        Me.txtmemname.BorderThickness = 0
        Me.txtmemname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmemname.DefaultText = ""
        Me.txtmemname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmemname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmemname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemname.DisabledState.Parent = Me.txtmemname
        Me.txtmemname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmemname.FocusedState.Parent = Me.txtmemname
        Me.txtmemname.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtmemname.ForeColor = System.Drawing.Color.Black
        Me.txtmemname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmemname.HoverState.Parent = Me.txtmemname
        Me.txtmemname.Location = New System.Drawing.Point(676, 325)
        Me.txtmemname.Name = "txtmemname"
        Me.txtmemname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmemname.PlaceholderText = ""
        Me.txtmemname.SelectedText = ""
        Me.txtmemname.ShadowDecoration.Parent = Me.txtmemname
        Me.txtmemname.Size = New System.Drawing.Size(200, 36)
        Me.txtmemname.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(313, 396)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 29)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Book Name"
        '
        'txtbooktitle
        '
        Me.txtbooktitle.BorderRadius = 8
        Me.txtbooktitle.BorderThickness = 0
        Me.txtbooktitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbooktitle.DefaultText = ""
        Me.txtbooktitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbooktitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbooktitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbooktitle.DisabledState.Parent = Me.txtbooktitle
        Me.txtbooktitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbooktitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbooktitle.FocusedState.Parent = Me.txtbooktitle
        Me.txtbooktitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtbooktitle.ForeColor = System.Drawing.Color.Black
        Me.txtbooktitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbooktitle.HoverState.Parent = Me.txtbooktitle
        Me.txtbooktitle.Location = New System.Drawing.Point(676, 389)
        Me.txtbooktitle.Name = "txtbooktitle"
        Me.txtbooktitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbooktitle.PlaceholderText = ""
        Me.txtbooktitle.SelectedText = ""
        Me.txtbooktitle.ShadowDecoration.Parent = Me.txtbooktitle
        Me.txtbooktitle.Size = New System.Drawing.Size(200, 36)
        Me.txtbooktitle.TabIndex = 58
        '
        'dateDue
        '
        Me.dateDue.CheckedState.Parent = Me.dateDue
        Me.dateDue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateDue.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateDue.HoverState.Parent = Me.dateDue
        Me.dateDue.Location = New System.Drawing.Point(676, 521)
        Me.dateDue.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateDue.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateDue.Name = "dateDue"
        Me.dateDue.ShadowDecoration.Parent = Me.dateDue
        Me.dateDue.Size = New System.Drawing.Size(200, 36)
        Me.dateDue.TabIndex = 61
        Me.dateDue.Value = New Date(2021, 1, 17, 9, 15, 5, 998)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(313, 528)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 29)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Due date"
        '
        'dateBorrow
        '
        Me.dateBorrow.CheckedState.Parent = Me.dateBorrow
        Me.dateBorrow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateBorrow.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateBorrow.HoverState.Parent = Me.dateBorrow
        Me.dateBorrow.Location = New System.Drawing.Point(676, 462)
        Me.dateBorrow.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateBorrow.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateBorrow.Name = "dateBorrow"
        Me.dateBorrow.ShadowDecoration.Parent = Me.dateBorrow
        Me.dateBorrow.Size = New System.Drawing.Size(200, 36)
        Me.dateBorrow.TabIndex = 63
        Me.dateBorrow.Value = New Date(2021, 1, 17, 9, 15, 5, 998)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(313, 462)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 29)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Due Borrow"
        '
        'BtnIssue
        '
        Me.BtnIssue.AutoRoundedCorners = True
        Me.BtnIssue.BorderRadius = 21
        Me.BtnIssue.CheckedState.Parent = Me.BtnIssue
        Me.BtnIssue.CustomImages.Parent = Me.BtnIssue
        Me.BtnIssue.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnIssue.ForeColor = System.Drawing.Color.Black
        Me.BtnIssue.HoverState.Parent = Me.BtnIssue
        Me.BtnIssue.Location = New System.Drawing.Point(449, 604)
        Me.BtnIssue.Name = "BtnIssue"
        Me.BtnIssue.ShadowDecoration.Parent = Me.BtnIssue
        Me.BtnIssue.Size = New System.Drawing.Size(180, 45)
        Me.BtnIssue.TabIndex = 64
        Me.BtnIssue.Text = "Issue"
        '
        'searchBtn
        '
        Me.searchBtn.AutoRoundedCorners = True
        Me.searchBtn.BorderRadius = 21
        Me.searchBtn.CheckedState.Parent = Me.searchBtn
        Me.searchBtn.CustomImages.Parent = Me.searchBtn
        Me.searchBtn.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.searchBtn.ForeColor = System.Drawing.Color.Black
        Me.searchBtn.HoverState.Parent = Me.searchBtn
        Me.searchBtn.Location = New System.Drawing.Point(828, 172)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.ShadowDecoration.Parent = Me.searchBtn
        Me.searchBtn.Size = New System.Drawing.Size(180, 45)
        Me.searchBtn.TabIndex = 67
        Me.searchBtn.Text = "Search"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(241, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 29)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Member id"
        '
        'txtmemberid
        '
        Me.txtmemberid.BorderRadius = 8
        Me.txtmemberid.BorderThickness = 0
        Me.txtmemberid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmemberid.DefaultText = ""
        Me.txtmemberid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmemberid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmemberid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemberid.DisabledState.Parent = Me.txtmemberid
        Me.txtmemberid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemberid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmemberid.FocusedState.Parent = Me.txtmemberid
        Me.txtmemberid.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtmemberid.ForeColor = System.Drawing.Color.Black
        Me.txtmemberid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmemberid.HoverState.Parent = Me.txtmemberid
        Me.txtmemberid.Location = New System.Drawing.Point(551, 210)
        Me.txtmemberid.Name = "txtmemberid"
        Me.txtmemberid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmemberid.PlaceholderText = ""
        Me.txtmemberid.SelectedText = ""
        Me.txtmemberid.ShadowDecoration.Parent = Me.txtmemberid
        Me.txtmemberid.Size = New System.Drawing.Size(200, 36)
        Me.txtmemberid.TabIndex = 65
        '
        'issue_books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1020, 732)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmemberid)
        Me.Controls.Add(Me.BtnIssue)
        Me.Controls.Add(Me.dateBorrow)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dateDue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbooktitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmemname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbid)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "issue_books"
        Me.Text = "issue_books"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmemname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbooktitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dateDue As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dateBorrow As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnIssue As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents searchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmemberid As Guna.UI2.WinForms.Guna2TextBox
End Class
