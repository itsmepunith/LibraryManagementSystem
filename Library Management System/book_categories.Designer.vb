<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class book_categories
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.editBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.addBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.datagridCateg = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcatadd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnaddCat = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlcloseAdd = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlAdd = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtshelfadd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlEdit = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnDeleteCat = New Guna.UI2.WinForms.Guna2Button()
        Me.txtaddshelf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.closeBtn = New FontAwesome.Sharp.IconPictureBox()
        Me.btnEditCat = New Guna.UI2.WinForms.Guna2Button()
        Me.txtaddcateg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.datagridCateg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlcloseAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdd.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(225, 655)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(225, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(862, 108)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(262, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Book Categories"
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
        Me.deleteBtn.Location = New System.Drawing.Point(761, 134)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.ShadowDecoration.Parent = Me.deleteBtn
        Me.deleteBtn.Size = New System.Drawing.Size(180, 45)
        Me.deleteBtn.TabIndex = 27
        Me.deleteBtn.Text = "Delete"
        '
        'editBtn
        '
        Me.editBtn.AutoRoundedCorners = True
        Me.editBtn.BorderRadius = 21
        Me.editBtn.CheckedState.Parent = Me.editBtn
        Me.editBtn.CustomImages.Parent = Me.editBtn
        Me.editBtn.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.editBtn.ForeColor = System.Drawing.Color.Black
        Me.editBtn.HoverState.Parent = Me.editBtn
        Me.editBtn.Location = New System.Drawing.Point(496, 134)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.ShadowDecoration.Parent = Me.editBtn
        Me.editBtn.Size = New System.Drawing.Size(180, 45)
        Me.editBtn.TabIndex = 28
        Me.editBtn.Text = "Edit"
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
        Me.addBtn.Location = New System.Drawing.Point(257, 134)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.ShadowDecoration.Parent = Me.addBtn
        Me.addBtn.Size = New System.Drawing.Size(180, 45)
        Me.addBtn.TabIndex = 29
        Me.addBtn.Text = "Add"
        '
        'datagridCateg
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.datagridCateg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridCateg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridCateg.BackgroundColor = System.Drawing.Color.White
        Me.datagridCateg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridCateg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagridCateg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridCateg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridCateg.ColumnHeadersHeight = 38
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridCateg.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagridCateg.EnableHeadersVisualStyles = False
        Me.datagridCateg.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.datagridCateg.Location = New System.Drawing.Point(247, 223)
        Me.datagridCateg.Name = "datagridCateg"
        Me.datagridCateg.RowHeadersVisible = False
        Me.datagridCateg.RowHeadersWidth = 51
        Me.datagridCateg.RowTemplate.Height = 24
        Me.datagridCateg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridCateg.Size = New System.Drawing.Size(558, 252)
        Me.datagridCateg.TabIndex = 30
        Me.datagridCateg.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
        Me.datagridCateg.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.datagridCateg.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagridCateg.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagridCateg.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagridCateg.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagridCateg.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagridCateg.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.datagridCateg.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.datagridCateg.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagridCateg.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.datagridCateg.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagridCateg.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagridCateg.ThemeStyle.HeaderStyle.Height = 38
        Me.datagridCateg.ThemeStyle.ReadOnly = False
        Me.datagridCateg.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.datagridCateg.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagridCateg.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.datagridCateg.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.datagridCateg.ThemeStyle.RowsStyle.Height = 24
        Me.datagridCateg.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.datagridCateg.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 58)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Category " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'txtcatadd
        '
        Me.txtcatadd.BorderRadius = 8
        Me.txtcatadd.BorderThickness = 0
        Me.txtcatadd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcatadd.DefaultText = ""
        Me.txtcatadd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcatadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcatadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcatadd.DisabledState.Parent = Me.txtcatadd
        Me.txtcatadd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcatadd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcatadd.FocusedState.Parent = Me.txtcatadd
        Me.txtcatadd.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtcatadd.ForeColor = System.Drawing.Color.Black
        Me.txtcatadd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcatadd.HoverState.Parent = Me.txtcatadd
        Me.txtcatadd.Location = New System.Drawing.Point(45, 124)
        Me.txtcatadd.Name = "txtcatadd"
        Me.txtcatadd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcatadd.PlaceholderText = ""
        Me.txtcatadd.SelectedText = ""
        Me.txtcatadd.ShadowDecoration.Parent = Me.txtcatadd
        Me.txtcatadd.Size = New System.Drawing.Size(200, 36)
        Me.txtcatadd.TabIndex = 29
        '
        'BtnaddCat
        '
        Me.BtnaddCat.BackColor = System.Drawing.Color.Black
        Me.BtnaddCat.CheckedState.Parent = Me.BtnaddCat
        Me.BtnaddCat.CustomImages.Parent = Me.BtnaddCat
        Me.BtnaddCat.FillColor = System.Drawing.Color.White
        Me.BtnaddCat.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnaddCat.ForeColor = System.Drawing.Color.Black
        Me.BtnaddCat.HoverState.Parent = Me.BtnaddCat
        Me.BtnaddCat.Location = New System.Drawing.Point(45, 324)
        Me.BtnaddCat.Name = "BtnaddCat"
        Me.BtnaddCat.ShadowDecoration.Parent = Me.BtnaddCat
        Me.BtnaddCat.Size = New System.Drawing.Size(200, 45)
        Me.BtnaddCat.TabIndex = 35
        Me.BtnaddCat.Text = "Add"
        '
        'pnlcloseAdd
        '
        Me.pnlcloseAdd.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.pnlcloseAdd.IconColor = System.Drawing.Color.White
        Me.pnlcloseAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pnlcloseAdd.Location = New System.Drawing.Point(302, 6)
        Me.pnlcloseAdd.Name = "pnlcloseAdd"
        Me.pnlcloseAdd.Size = New System.Drawing.Size(32, 32)
        Me.pnlcloseAdd.TabIndex = 36
        Me.pnlcloseAdd.TabStop = False
        '
        'pnlAdd
        '
        Me.pnlAdd.BackColor = System.Drawing.Color.Black
        Me.pnlAdd.Controls.Add(Me.txtshelfadd)
        Me.pnlAdd.Controls.Add(Me.Label4)
        Me.pnlAdd.Controls.Add(Me.pnlcloseAdd)
        Me.pnlAdd.Controls.Add(Me.BtnaddCat)
        Me.pnlAdd.Controls.Add(Me.txtcatadd)
        Me.pnlAdd.Controls.Add(Me.Label3)
        Me.pnlAdd.Location = New System.Drawing.Point(372, 241)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.ShadowDecoration.Parent = Me.pnlAdd
        Me.pnlAdd.Size = New System.Drawing.Size(334, 392)
        Me.pnlAdd.TabIndex = 31
        '
        'txtshelfadd
        '
        Me.txtshelfadd.BorderRadius = 8
        Me.txtshelfadd.BorderThickness = 0
        Me.txtshelfadd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtshelfadd.DefaultText = ""
        Me.txtshelfadd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtshelfadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtshelfadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtshelfadd.DisabledState.Parent = Me.txtshelfadd
        Me.txtshelfadd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtshelfadd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtshelfadd.FocusedState.Parent = Me.txtshelfadd
        Me.txtshelfadd.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtshelfadd.ForeColor = System.Drawing.Color.Black
        Me.txtshelfadd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtshelfadd.HoverState.Parent = Me.txtshelfadd
        Me.txtshelfadd.Location = New System.Drawing.Point(45, 250)
        Me.txtshelfadd.Name = "txtshelfadd"
        Me.txtshelfadd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtshelfadd.PlaceholderText = ""
        Me.txtshelfadd.SelectedText = ""
        Me.txtshelfadd.ShadowDecoration.Parent = Me.txtshelfadd
        Me.txtshelfadd.Size = New System.Drawing.Size(200, 36)
        Me.txtshelfadd.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 29)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Shelf"
        '
        'pnlEdit
        '
        Me.pnlEdit.BackColor = System.Drawing.Color.Black
        Me.pnlEdit.Controls.Add(Me.btnDeleteCat)
        Me.pnlEdit.Controls.Add(Me.txtaddshelf)
        Me.pnlEdit.Controls.Add(Me.Label2)
        Me.pnlEdit.Controls.Add(Me.closeBtn)
        Me.pnlEdit.Controls.Add(Me.btnEditCat)
        Me.pnlEdit.Controls.Add(Me.txtaddcateg)
        Me.pnlEdit.Controls.Add(Me.Label5)
        Me.pnlEdit.Location = New System.Drawing.Point(761, 244)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.ShadowDecoration.Parent = Me.pnlEdit
        Me.pnlEdit.Size = New System.Drawing.Size(326, 379)
        Me.pnlEdit.TabIndex = 39
        '
        'btnDeleteCat
        '
        Me.btnDeleteCat.BackColor = System.Drawing.Color.Black
        Me.btnDeleteCat.CheckedState.Parent = Me.btnDeleteCat
        Me.btnDeleteCat.CustomImages.Parent = Me.btnDeleteCat
        Me.btnDeleteCat.FillColor = System.Drawing.Color.White
        Me.btnDeleteCat.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteCat.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteCat.HoverState.Parent = Me.btnDeleteCat
        Me.btnDeleteCat.Location = New System.Drawing.Point(64, 321)
        Me.btnDeleteCat.Name = "btnDeleteCat"
        Me.btnDeleteCat.ShadowDecoration.Parent = Me.btnDeleteCat
        Me.btnDeleteCat.Size = New System.Drawing.Size(200, 45)
        Me.btnDeleteCat.TabIndex = 39
        Me.btnDeleteCat.Text = "Delete"
        '
        'txtaddshelf
        '
        Me.txtaddshelf.BorderRadius = 8
        Me.txtaddshelf.BorderThickness = 0
        Me.txtaddshelf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddshelf.DefaultText = ""
        Me.txtaddshelf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtaddshelf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtaddshelf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddshelf.DisabledState.Parent = Me.txtaddshelf
        Me.txtaddshelf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddshelf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddshelf.FocusedState.Parent = Me.txtaddshelf
        Me.txtaddshelf.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtaddshelf.ForeColor = System.Drawing.Color.Black
        Me.txtaddshelf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddshelf.HoverState.Parent = Me.txtaddshelf
        Me.txtaddshelf.Location = New System.Drawing.Point(55, 195)
        Me.txtaddshelf.Name = "txtaddshelf"
        Me.txtaddshelf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddshelf.PlaceholderText = ""
        Me.txtaddshelf.SelectedText = ""
        Me.txtaddshelf.ShadowDecoration.Parent = Me.txtaddshelf
        Me.txtaddshelf.Size = New System.Drawing.Size(200, 36)
        Me.txtaddshelf.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 29)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Shelf"
        '
        'closeBtn
        '
        Me.closeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.closeBtn.IconColor = System.Drawing.Color.White
        Me.closeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closeBtn.Location = New System.Drawing.Point(291, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(32, 32)
        Me.closeBtn.TabIndex = 36
        Me.closeBtn.TabStop = False
        '
        'btnEditCat
        '
        Me.btnEditCat.BackColor = System.Drawing.Color.White
        Me.btnEditCat.CheckedState.Parent = Me.btnEditCat
        Me.btnEditCat.CustomImages.Parent = Me.btnEditCat
        Me.btnEditCat.FillColor = System.Drawing.Color.White
        Me.btnEditCat.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditCat.ForeColor = System.Drawing.Color.Black
        Me.btnEditCat.HoverState.Parent = Me.btnEditCat
        Me.btnEditCat.Location = New System.Drawing.Point(64, 258)
        Me.btnEditCat.Name = "btnEditCat"
        Me.btnEditCat.ShadowDecoration.Parent = Me.btnEditCat
        Me.btnEditCat.Size = New System.Drawing.Size(200, 45)
        Me.btnEditCat.TabIndex = 35
        Me.btnEditCat.Text = "Edit"
        '
        'txtaddcateg
        '
        Me.txtaddcateg.BorderRadius = 8
        Me.txtaddcateg.BorderThickness = 0
        Me.txtaddcateg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddcateg.DefaultText = ""
        Me.txtaddcateg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtaddcateg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtaddcateg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddcateg.DisabledState.Parent = Me.txtaddcateg
        Me.txtaddcateg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddcateg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddcateg.FocusedState.Parent = Me.txtaddcateg
        Me.txtaddcateg.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtaddcateg.ForeColor = System.Drawing.Color.Black
        Me.txtaddcateg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddcateg.HoverState.Parent = Me.txtaddcateg
        Me.txtaddcateg.Location = New System.Drawing.Point(50, 91)
        Me.txtaddcateg.Name = "txtaddcateg"
        Me.txtaddcateg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddcateg.PlaceholderText = ""
        Me.txtaddcateg.SelectedText = ""
        Me.txtaddcateg.ShadowDecoration.Parent = Me.txtaddcateg
        Me.txtaddcateg.Size = New System.Drawing.Size(200, 36)
        Me.txtaddcateg.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(30, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 58)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Category " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'book_categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1087, 655)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.pnlAdd)
        Me.Controls.Add(Me.datagridCateg)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Name = "book_categories"
        Me.Text = "book_categories"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.datagridCateg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlcloseAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlAdd.PerformLayout()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents deleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents editBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents datagridCateg As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcatadd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnaddCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlcloseAdd As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pnlAdd As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtshelfadd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlEdit As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnDeleteCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents closeBtn As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnEditCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtaddcateg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtaddshelf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
End Class
