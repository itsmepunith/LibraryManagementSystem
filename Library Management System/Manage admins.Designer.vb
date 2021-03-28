<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_admins
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
        Me.txtoldpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlClose = New FontAwesome.Sharp.IconPictureBox()
        Me.txtusern = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlPassword = New Guna.UI2.WinForms.Guna2Panel()
        Me.SearchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.changePassBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.txtRepass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNewPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OkBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlDelete = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New FontAwesome.Sharp.IconPictureBox()
        Me.deletBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.txtadmnid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Btnpassword = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgv = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.pnlClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPassword.SuspendLayout()
        Me.pnlDelete.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtoldpass
        '
        Me.txtoldpass.BorderRadius = 8
        Me.txtoldpass.BorderThickness = 0
        Me.txtoldpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtoldpass.DefaultText = ""
        Me.txtoldpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtoldpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtoldpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtoldpass.DisabledState.Parent = Me.txtoldpass
        Me.txtoldpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtoldpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoldpass.FocusedState.Parent = Me.txtoldpass
        Me.txtoldpass.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtoldpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoldpass.HoverState.Parent = Me.txtoldpass
        Me.txtoldpass.Location = New System.Drawing.Point(132, 199)
        Me.txtoldpass.Name = "txtoldpass"
        Me.txtoldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtoldpass.PlaceholderText = ""
        Me.txtoldpass.SelectedText = ""
        Me.txtoldpass.ShadowDecoration.Parent = Me.txtoldpass
        Me.txtoldpass.Size = New System.Drawing.Size(200, 36)
        Me.txtoldpass.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 48)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    password"
        '
        'pnlClose
        '
        Me.pnlClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pnlClose.ForeColor = System.Drawing.Color.Black
        Me.pnlClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.pnlClose.IconColor = System.Drawing.Color.Black
        Me.pnlClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pnlClose.Location = New System.Drawing.Point(351, 0)
        Me.pnlClose.Name = "pnlClose"
        Me.pnlClose.Size = New System.Drawing.Size(32, 32)
        Me.pnlClose.TabIndex = 36
        Me.pnlClose.TabStop = False
        '
        'txtusern
        '
        Me.txtusern.BorderRadius = 8
        Me.txtusern.BorderThickness = 0
        Me.txtusern.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusern.DefaultText = ""
        Me.txtusern.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtusern.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtusern.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusern.DisabledState.Parent = Me.txtusern
        Me.txtusern.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusern.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusern.FocusedState.Parent = Me.txtusern
        Me.txtusern.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtusern.ForeColor = System.Drawing.Color.Black
        Me.txtusern.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusern.HoverState.Parent = Me.txtusern
        Me.txtusern.Location = New System.Drawing.Point(132, 50)
        Me.txtusern.Name = "txtusern"
        Me.txtusern.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusern.PlaceholderText = ""
        Me.txtusern.SelectedText = ""
        Me.txtusern.ShadowDecoration.Parent = Me.txtusern
        Me.txtusern.Size = New System.Drawing.Size(200, 36)
        Me.txtusern.TabIndex = 29
        '
        'pnlPassword
        '
        Me.pnlPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pnlPassword.Controls.Add(Me.SearchBtn)
        Me.pnlPassword.Controls.Add(Me.changePassBtn)
        Me.pnlPassword.Controls.Add(Me.txtRepass)
        Me.pnlPassword.Controls.Add(Me.Label6)
        Me.pnlPassword.Controls.Add(Me.txtNewPass)
        Me.pnlPassword.Controls.Add(Me.Label4)
        Me.pnlPassword.Controls.Add(Me.OkBtn)
        Me.pnlPassword.Controls.Add(Me.txtoldpass)
        Me.pnlPassword.Controls.Add(Me.Label2)
        Me.pnlPassword.Controls.Add(Me.pnlClose)
        Me.pnlPassword.Controls.Add(Me.txtusern)
        Me.pnlPassword.Controls.Add(Me.Label5)
        Me.pnlPassword.Location = New System.Drawing.Point(722, 196)
        Me.pnlPassword.Name = "pnlPassword"
        Me.pnlPassword.ShadowDecoration.Parent = Me.pnlPassword
        Me.pnlPassword.Size = New System.Drawing.Size(386, 574)
        Me.pnlPassword.TabIndex = 47
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.Black
        Me.SearchBtn.CheckedState.Parent = Me.SearchBtn
        Me.SearchBtn.CustomImages.Parent = Me.SearchBtn
        Me.SearchBtn.FillColor = System.Drawing.Color.Black
        Me.SearchBtn.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.HoverState.Parent = Me.SearchBtn
        Me.SearchBtn.Location = New System.Drawing.Point(203, 100)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.ShadowDecoration.Parent = Me.SearchBtn
        Me.SearchBtn.Size = New System.Drawing.Size(180, 45)
        Me.SearchBtn.TabIndex = 46
        Me.SearchBtn.Text = "Search"
        '
        'changePassBtn
        '
        Me.changePassBtn.BackColor = System.Drawing.Color.Black
        Me.changePassBtn.CheckedState.Parent = Me.changePassBtn
        Me.changePassBtn.CustomImages.Parent = Me.changePassBtn
        Me.changePassBtn.FillColor = System.Drawing.Color.Black
        Me.changePassBtn.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.changePassBtn.ForeColor = System.Drawing.Color.White
        Me.changePassBtn.HoverState.Parent = Me.changePassBtn
        Me.changePassBtn.Location = New System.Drawing.Point(76, 508)
        Me.changePassBtn.Name = "changePassBtn"
        Me.changePassBtn.ShadowDecoration.Parent = Me.changePassBtn
        Me.changePassBtn.Size = New System.Drawing.Size(200, 45)
        Me.changePassBtn.TabIndex = 45
        Me.changePassBtn.Text = "Change"
        '
        'txtRepass
        '
        Me.txtRepass.BorderRadius = 8
        Me.txtRepass.BorderThickness = 0
        Me.txtRepass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRepass.DefaultText = ""
        Me.txtRepass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRepass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRepass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRepass.DisabledState.Parent = Me.txtRepass
        Me.txtRepass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRepass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRepass.FocusedState.Parent = Me.txtRepass
        Me.txtRepass.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtRepass.ForeColor = System.Drawing.Color.Black
        Me.txtRepass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRepass.HoverState.Parent = Me.txtRepass
        Me.txtRepass.Location = New System.Drawing.Point(132, 445)
        Me.txtRepass.Name = "txtRepass"
        Me.txtRepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRepass.PlaceholderText = ""
        Me.txtRepass.SelectedText = ""
        Me.txtRepass.ShadowDecoration.Parent = Me.txtRepass
        Me.txtRepass.Size = New System.Drawing.Size(200, 36)
        Me.txtRepass.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Engravers MT", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 401)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 26)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Re-enter "
        '
        'txtNewPass
        '
        Me.txtNewPass.BorderRadius = 8
        Me.txtNewPass.BorderThickness = 0
        Me.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPass.DefaultText = ""
        Me.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPass.DisabledState.Parent = Me.txtNewPass
        Me.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPass.FocusedState.Parent = Me.txtNewPass
        Me.txtNewPass.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtNewPass.ForeColor = System.Drawing.Color.Black
        Me.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPass.HoverState.Parent = Me.txtNewPass
        Me.txtNewPass.Location = New System.Drawing.Point(132, 347)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPass.PlaceholderText = ""
        Me.txtNewPass.SelectedText = ""
        Me.txtNewPass.ShadowDecoration.Parent = Me.txtNewPass
        Me.txtNewPass.Size = New System.Drawing.Size(200, 36)
        Me.txtNewPass.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Engravers MT", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 26)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "New password"
        '
        'OkBtn
        '
        Me.OkBtn.BackColor = System.Drawing.Color.Black
        Me.OkBtn.CheckedState.Parent = Me.OkBtn
        Me.OkBtn.CustomImages.Parent = Me.OkBtn
        Me.OkBtn.FillColor = System.Drawing.Color.Black
        Me.OkBtn.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.OkBtn.ForeColor = System.Drawing.Color.White
        Me.OkBtn.HoverState.Parent = Me.OkBtn
        Me.OkBtn.Location = New System.Drawing.Point(102, 249)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.ShadowDecoration.Parent = Me.OkBtn
        Me.OkBtn.Size = New System.Drawing.Size(200, 45)
        Me.OkBtn.TabIndex = 40
        Me.OkBtn.Text = "Verify"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Engravers MT", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 26)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Username"
        '
        'pnlDelete
        '
        Me.pnlDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pnlDelete.Controls.Add(Me.btnClose)
        Me.pnlDelete.Controls.Add(Me.deletBtn)
        Me.pnlDelete.Controls.Add(Me.txtadmnid)
        Me.pnlDelete.Controls.Add(Me.Label3)
        Me.pnlDelete.Location = New System.Drawing.Point(372, 241)
        Me.pnlDelete.Name = "pnlDelete"
        Me.pnlDelete.ShadowDecoration.Parent = Me.pnlDelete
        Me.pnlDelete.Size = New System.Drawing.Size(304, 249)
        Me.pnlDelete.TabIndex = 46
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.Location = New System.Drawing.Point(272, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 32)
        Me.btnClose.TabIndex = 36
        Me.btnClose.TabStop = False
        '
        'deletBtn
        '
        Me.deletBtn.BackColor = System.Drawing.Color.Black
        Me.deletBtn.CheckedState.Parent = Me.deletBtn
        Me.deletBtn.CustomImages.Parent = Me.deletBtn
        Me.deletBtn.FillColor = System.Drawing.Color.Black
        Me.deletBtn.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.deletBtn.ForeColor = System.Drawing.Color.White
        Me.deletBtn.HoverState.Parent = Me.deletBtn
        Me.deletBtn.Location = New System.Drawing.Point(55, 154)
        Me.deletBtn.Name = "deletBtn"
        Me.deletBtn.ShadowDecoration.Parent = Me.deletBtn
        Me.deletBtn.Size = New System.Drawing.Size(200, 45)
        Me.deletBtn.TabIndex = 35
        Me.deletBtn.Text = "Delete"
        '
        'txtadmnid
        '
        Me.txtadmnid.BorderRadius = 8
        Me.txtadmnid.BorderThickness = 0
        Me.txtadmnid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtadmnid.DefaultText = ""
        Me.txtadmnid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtadmnid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtadmnid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtadmnid.DisabledState.Parent = Me.txtadmnid
        Me.txtadmnid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtadmnid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtadmnid.FocusedState.Parent = Me.txtadmnid
        Me.txtadmnid.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtadmnid.ForeColor = System.Drawing.Color.Black
        Me.txtadmnid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtadmnid.HoverState.Parent = Me.txtadmnid
        Me.txtadmnid.Location = New System.Drawing.Point(45, 82)
        Me.txtadmnid.Name = "txtadmnid"
        Me.txtadmnid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtadmnid.PlaceholderText = ""
        Me.txtadmnid.SelectedText = ""
        Me.txtadmnid.ShadowDecoration.Parent = Me.txtadmnid
        Me.txtadmnid.Size = New System.Drawing.Size(200, 36)
        Me.txtadmnid.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 29)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Username"
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
        Me.addBtn.Location = New System.Drawing.Point(231, 134)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.ShadowDecoration.Parent = Me.addBtn
        Me.addBtn.Size = New System.Drawing.Size(194, 45)
        Me.addBtn.TabIndex = 44
        Me.addBtn.Text = "Add admin"
        '
        'Btnpassword
        '
        Me.Btnpassword.AutoRoundedCorners = True
        Me.Btnpassword.BorderRadius = 21
        Me.Btnpassword.CheckedState.Parent = Me.Btnpassword
        Me.Btnpassword.CustomImages.Parent = Me.Btnpassword
        Me.Btnpassword.Font = New System.Drawing.Font("Forte", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Btnpassword.ForeColor = System.Drawing.Color.Black
        Me.Btnpassword.HoverState.Parent = Me.Btnpassword
        Me.Btnpassword.Location = New System.Drawing.Point(460, 134)
        Me.Btnpassword.Name = "Btnpassword"
        Me.Btnpassword.ShadowDecoration.Parent = Me.Btnpassword
        Me.Btnpassword.Size = New System.Drawing.Size(247, 45)
        Me.Btnpassword.TabIndex = 43
        Me.Btnpassword.Text = "Change password"
        '
        'btnDelete
        '
        Me.btnDelete.AutoRoundedCorners = True
        Me.btnDelete.BorderRadius = 21
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.Font = New System.Drawing.Font("Forte", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(744, 134)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(192, 45)
        Me.btnDelete.TabIndex = 42
        Me.btnDelete.Text = "Delete admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(262, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Manage Admins"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(977, 108)
        Me.Guna2Panel1.TabIndex = 41
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(200, 795)
        Me.Guna2Panel2.TabIndex = 40
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
        Me.dgv.ColumnHeadersHeight = 36
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
        Me.dgv.Location = New System.Drawing.Point(215, 365)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(558, 327)
        Me.dgv.TabIndex = 45
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
        Me.dgv.ThemeStyle.HeaderStyle.Height = 36
        Me.dgv.ThemeStyle.ReadOnly = False
        Me.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv.ThemeStyle.RowsStyle.Height = 24
        Me.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Manage_admins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1177, 795)
        Me.Controls.Add(Me.pnlPassword)
        Me.Controls.Add(Me.pnlDelete)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.Btnpassword)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Manage_admins"
        Me.Text = "Manage_admins"
        CType(Me.pnlClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPassword.ResumeLayout(False)
        Me.pnlPassword.PerformLayout()
        Me.pnlDelete.ResumeLayout(False)
        Me.pnlDelete.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtoldpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlClose As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents txtusern As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pnlPassword As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlDelete As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents deletBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtadmnid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents addBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btnpassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents OkBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtRepass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNewPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents changePassBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SearchBtn As Guna.UI2.WinForms.Guna2Button
End Class
