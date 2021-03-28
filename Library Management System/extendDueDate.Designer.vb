<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class extendDueDate
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dayscmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDue = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.extendBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.txtbid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtmemid = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(200, 589)
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
        Me.Guna2Panel2.Size = New System.Drawing.Size(698, 134)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(174, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 41)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Extend due date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 29)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Book id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 29)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Member id"
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
        Me.searchBtn.Location = New System.Drawing.Point(414, 297)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.ShadowDecoration.Parent = Me.searchBtn
        Me.searchBtn.Size = New System.Drawing.Size(180, 45)
        Me.searchBtn.TabIndex = 50
        Me.searchBtn.Text = "Search"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(240, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(319, 29)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Days to extend"
        '
        'dayscmb
        '
        Me.dayscmb.BackColor = System.Drawing.Color.Transparent
        Me.dayscmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.dayscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dayscmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dayscmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dayscmb.FocusedState.Parent = Me.dayscmb
        Me.dayscmb.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.dayscmb.ForeColor = System.Drawing.Color.Black
        Me.dayscmb.HoverState.Parent = Me.dayscmb
        Me.dayscmb.ItemHeight = 30
        Me.dayscmb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.dayscmb.ItemsAppearance.Parent = Me.dayscmb
        Me.dayscmb.Location = New System.Drawing.Point(591, 386)
        Me.dayscmb.Name = "dayscmb"
        Me.dayscmb.ShadowDecoration.Parent = Me.dayscmb
        Me.dayscmb.Size = New System.Drawing.Size(200, 36)
        Me.dayscmb.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(263, 451)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 29)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Due date"
        '
        'dtpDue
        '
        Me.dtpDue.CheckedState.Parent = Me.dtpDue
        Me.dtpDue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDue.HoverState.Parent = Me.dtpDue
        Me.dtpDue.Location = New System.Drawing.Point(591, 451)
        Me.dtpDue.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDue.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDue.Name = "dtpDue"
        Me.dtpDue.ShadowDecoration.Parent = Me.dtpDue
        Me.dtpDue.Size = New System.Drawing.Size(200, 36)
        Me.dtpDue.TabIndex = 54
        Me.dtpDue.Value = New Date(2021, 1, 17, 9, 15, 5, 998)
        '
        'extendBtn
        '
        Me.extendBtn.AutoRoundedCorners = True
        Me.extendBtn.BorderRadius = 21
        Me.extendBtn.CheckedState.Parent = Me.extendBtn
        Me.extendBtn.CustomImages.Parent = Me.extendBtn
        Me.extendBtn.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.extendBtn.ForeColor = System.Drawing.Color.Black
        Me.extendBtn.HoverState.Parent = Me.extendBtn
        Me.extendBtn.Location = New System.Drawing.Point(414, 522)
        Me.extendBtn.Name = "extendBtn"
        Me.extendBtn.ShadowDecoration.Parent = Me.extendBtn
        Me.extendBtn.Size = New System.Drawing.Size(180, 45)
        Me.extendBtn.TabIndex = 55
        Me.extendBtn.Text = "Extend"
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
        Me.txtbid.Location = New System.Drawing.Point(525, 160)
        Me.txtbid.Name = "txtbid"
        Me.txtbid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbid.PlaceholderText = ""
        Me.txtbid.SelectedText = ""
        Me.txtbid.ShadowDecoration.Parent = Me.txtbid
        Me.txtbid.Size = New System.Drawing.Size(200, 36)
        Me.txtbid.TabIndex = 46
        '
        'txtmemid
        '
        Me.txtmemid.BorderRadius = 8
        Me.txtmemid.BorderThickness = 0
        Me.txtmemid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmemid.DefaultText = ""
        Me.txtmemid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmemid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmemid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemid.DisabledState.Parent = Me.txtmemid
        Me.txtmemid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmemid.FocusedState.Parent = Me.txtmemid
        Me.txtmemid.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtmemid.ForeColor = System.Drawing.Color.Black
        Me.txtmemid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmemid.HoverState.Parent = Me.txtmemid
        Me.txtmemid.Location = New System.Drawing.Point(525, 234)
        Me.txtmemid.Name = "txtmemid"
        Me.txtmemid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmemid.PlaceholderText = ""
        Me.txtmemid.SelectedText = ""
        Me.txtmemid.ShadowDecoration.Parent = Me.txtmemid
        Me.txtmemid.Size = New System.Drawing.Size(200, 36)
        Me.txtmemid.TabIndex = 48
        '
        'extendDueDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(898, 589)
        Me.Controls.Add(Me.extendBtn)
        Me.Controls.Add(Me.dtpDue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dayscmb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmemid)
        Me.Controls.Add(Me.txtbid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "extendDueDate"
        Me.Text = "extendDueDate"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents searchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dayscmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpDue As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents extendBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtbid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtmemid As Guna.UI2.WinForms.Guna2TextBox
End Class
