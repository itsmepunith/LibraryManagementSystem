<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Members
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.editBtn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.addBtn = New Guna.UI2.WinForms.Guna2TileButton()
        Me.BtnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtrollno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.viewAllBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.dgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(872, 131)
        Me.Guna2Panel2.TabIndex = 257
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(146, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 41)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Manage Members"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(200, 763)
        Me.Guna2Panel1.TabIndex = 258
        '
        'editBtn
        '
        Me.editBtn.CheckedState.Parent = Me.editBtn
        Me.editBtn.CustomImages.Parent = Me.editBtn
        Me.editBtn.Font = New System.Drawing.Font("Matura MT Script Capitals", 21.0!)
        Me.editBtn.ForeColor = System.Drawing.Color.Black
        Me.editBtn.HoverState.Parent = Me.editBtn
        Me.editBtn.Location = New System.Drawing.Point(559, 147)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.ShadowDecoration.Parent = Me.editBtn
        Me.editBtn.Size = New System.Drawing.Size(188, 180)
        Me.editBtn.TabIndex = 260
        Me.editBtn.Text = "Edit member details"
        '
        'addBtn
        '
        Me.addBtn.CheckedState.Parent = Me.addBtn
        Me.addBtn.CustomImages.Parent = Me.addBtn
        Me.addBtn.Font = New System.Drawing.Font("Matura MT Script Capitals", 21.0!)
        Me.addBtn.ForeColor = System.Drawing.Color.Black
        Me.addBtn.HoverState.Parent = Me.addBtn
        Me.addBtn.Location = New System.Drawing.Point(278, 147)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.ShadowDecoration.Parent = Me.addBtn
        Me.addBtn.Size = New System.Drawing.Size(194, 180)
        Me.addBtn.TabIndex = 259
        Me.addBtn.Text = "Add new members"
        '
        'BtnSearch
        '
        Me.BtnSearch.AutoRoundedCorners = True
        Me.BtnSearch.BorderRadius = 21
        Me.BtnSearch.CheckedState.Parent = Me.BtnSearch
        Me.BtnSearch.CustomImages.Parent = Me.BtnSearch
        Me.BtnSearch.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSearch.ForeColor = System.Drawing.Color.Black
        Me.BtnSearch.HoverState.Parent = Me.BtnSearch
        Me.BtnSearch.Location = New System.Drawing.Point(729, 386)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.ShadowDecoration.Parent = Me.BtnSearch
        Me.BtnSearch.Size = New System.Drawing.Size(180, 45)
        Me.BtnSearch.TabIndex = 263
        Me.BtnSearch.Text = "Search"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(227, 393)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 29)
        Me.Label7.TabIndex = 262
        Me.Label7.Text = "Roll no."
        '
        'txtrollno
        '
        Me.txtrollno.BorderRadius = 8
        Me.txtrollno.BorderThickness = 0
        Me.txtrollno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrollno.DefaultText = ""
        Me.txtrollno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtrollno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtrollno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtrollno.DisabledState.Parent = Me.txtrollno
        Me.txtrollno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtrollno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrollno.FocusedState.Parent = Me.txtrollno
        Me.txtrollno.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtrollno.ForeColor = System.Drawing.Color.Black
        Me.txtrollno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrollno.HoverState.Parent = Me.txtrollno
        Me.txtrollno.Location = New System.Drawing.Point(473, 386)
        Me.txtrollno.Name = "txtrollno"
        Me.txtrollno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrollno.PlaceholderText = ""
        Me.txtrollno.SelectedText = ""
        Me.txtrollno.ShadowDecoration.Parent = Me.txtrollno
        Me.txtrollno.Size = New System.Drawing.Size(200, 36)
        Me.txtrollno.TabIndex = 261
        '
        'viewAllBtn
        '
        Me.viewAllBtn.AutoRoundedCorners = True
        Me.viewAllBtn.BorderRadius = 21
        Me.viewAllBtn.CheckedState.Parent = Me.viewAllBtn
        Me.viewAllBtn.CustomImages.Parent = Me.viewAllBtn
        Me.viewAllBtn.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.viewAllBtn.ForeColor = System.Drawing.Color.Black
        Me.viewAllBtn.HoverState.Parent = Me.viewAllBtn
        Me.viewAllBtn.Location = New System.Drawing.Point(766, 495)
        Me.viewAllBtn.Name = "viewAllBtn"
        Me.viewAllBtn.ShadowDecoration.Parent = Me.viewAllBtn
        Me.viewAllBtn.Size = New System.Drawing.Size(180, 45)
        Me.viewAllBtn.TabIndex = 264
        Me.viewAllBtn.Text = "View all"
        '
        'dgv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeight = 38
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(232, 495)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(503, 234)
        Me.dgv.TabIndex = 265
        Me.dgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
        Me.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv.ThemeStyle.HeaderStyle.Height = 38
        Me.dgv.ThemeStyle.ReadOnly = False
        Me.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv.ThemeStyle.RowsStyle.Height = 24
        Me.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Manage_Members
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1072, 763)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.viewAllBtn)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtrollno)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Manage_Members"
        Me.Text = "Manage_Members"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents editBtn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents addBtn As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents BtnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtrollno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents viewAllBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgv As Guna.UI2.WinForms.Guna2DataGridView
End Class
