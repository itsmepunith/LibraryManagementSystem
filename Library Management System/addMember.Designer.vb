<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addMember))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lbladm = New System.Windows.Forms.Label()
        Me.rollLbl = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.picPhoto = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BtnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbMember = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtmemid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRollno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtAdmyear = New System.Windows.Forms.NumericUpDown()
        Me.datedob = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdmyear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(200, 939)
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
        Me.Guna2Panel2.Size = New System.Drawing.Size(852, 129)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(280, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 41)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ADD MEMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "MEMBER TYPE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(226, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "MEMBER ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(226, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(226, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(294, 29)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "DATE-OF-BIRTH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(226, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 29)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ADDRESS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(226, 498)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 29)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "EMAIL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(226, 574)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 29)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "PH. NO."
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(226, 652)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(155, 29)
        Me.lblCourse.TabIndex = 19
        Me.lblCourse.Text = "COURSE"
        '
        'lbladm
        '
        Me.lbladm.AutoSize = True
        Me.lbladm.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladm.Location = New System.Drawing.Point(226, 725)
        Me.lbladm.Name = "lbladm"
        Me.lbladm.Size = New System.Drawing.Size(317, 29)
        Me.lbladm.TabIndex = 20
        Me.lbladm.Text = "ADMISSION YEAR"
        '
        'rollLbl
        '
        Me.rollLbl.AutoSize = True
        Me.rollLbl.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollLbl.Location = New System.Drawing.Point(226, 789)
        Me.rollLbl.Name = "rollLbl"
        Me.rollLbl.Size = New System.Drawing.Size(178, 29)
        Me.rollLbl.TabIndex = 21
        Me.rollLbl.Text = "ROLL NO."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(226, 855)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(207, 29)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "PASSWORD"
        '
        'BtnAdd
        '
        Me.BtnAdd.AutoRoundedCorners = True
        Me.BtnAdd.BorderRadius = 21
        Me.BtnAdd.CheckedState.Parent = Me.BtnAdd
        Me.BtnAdd.CustomImages.Parent = Me.BtnAdd
        Me.BtnAdd.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnAdd.HoverState.Parent = Me.BtnAdd
        Me.BtnAdd.Location = New System.Drawing.Point(850, 482)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.ShadowDecoration.Parent = Me.BtnAdd
        Me.BtnAdd.Size = New System.Drawing.Size(180, 45)
        Me.BtnAdd.TabIndex = 24
        Me.BtnAdd.Text = "ADD"
        '
        'picPhoto
        '
        Me.picPhoto.Image = CType(resources.GetObject("picPhoto.Image"), System.Drawing.Image)
        Me.picPhoto.Location = New System.Drawing.Point(805, 142)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.ShadowDecoration.Parent = Me.picPhoto
        Me.picPhoto.Size = New System.Drawing.Size(247, 200)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPhoto.TabIndex = 25
        Me.picPhoto.TabStop = False
        '
        'BtnBrowse
        '
        Me.BtnBrowse.AutoRoundedCorners = True
        Me.BtnBrowse.BorderRadius = 21
        Me.BtnBrowse.CheckedState.Parent = Me.BtnBrowse
        Me.BtnBrowse.CustomImages.Parent = Me.BtnBrowse
        Me.BtnBrowse.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBrowse.ForeColor = System.Drawing.Color.Black
        Me.BtnBrowse.HoverState.Parent = Me.BtnBrowse
        Me.BtnBrowse.Location = New System.Drawing.Point(850, 385)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.ShadowDecoration.Parent = Me.BtnBrowse
        Me.BtnBrowse.Size = New System.Drawing.Size(180, 45)
        Me.BtnBrowse.TabIndex = 26
        Me.BtnBrowse.Text = "BROWSE"
        '
        'cmbMember
        '
        Me.cmbMember.BackColor = System.Drawing.Color.Transparent
        Me.cmbMember.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMember.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMember.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMember.FocusedState.Parent = Me.cmbMember
        Me.cmbMember.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmbMember.ForeColor = System.Drawing.Color.Black
        Me.cmbMember.HoverState.Parent = Me.cmbMember
        Me.cmbMember.ItemHeight = 30
        Me.cmbMember.Items.AddRange(New Object() {"Student", "Faculty"})
        Me.cmbMember.ItemsAppearance.Parent = Me.cmbMember
        Me.cmbMember.Location = New System.Drawing.Point(554, 142)
        Me.cmbMember.Name = "cmbMember"
        Me.cmbMember.ShadowDecoration.Parent = Me.cmbMember
        Me.cmbMember.Size = New System.Drawing.Size(200, 36)
        Me.cmbMember.TabIndex = 27
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
        Me.txtmemid.Location = New System.Drawing.Point(554, 213)
        Me.txtmemid.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtmemid.Name = "txtmemid"
        Me.txtmemid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmemid.PlaceholderText = ""
        Me.txtmemid.SelectedText = ""
        Me.txtmemid.ShadowDecoration.Parent = Me.txtmemid
        Me.txtmemid.Size = New System.Drawing.Size(200, 36)
        Me.txtmemid.TabIndex = 28
        '
        'txtName
        '
        Me.txtName.BorderRadius = 8
        Me.txtName.BorderThickness = 0
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.Parent = Me.txtName
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.FocusedState.Parent = Me.txtName
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.HoverState.Parent = Me.txtName
        Me.txtName.Location = New System.Drawing.Point(554, 280)
        Me.txtName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Parent = Me.txtName
        Me.txtName.Size = New System.Drawing.Size(200, 36)
        Me.txtName.TabIndex = 29
        '
        'txtaddress
        '
        Me.txtaddress.BorderRadius = 8
        Me.txtaddress.BorderThickness = 0
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.DefaultText = ""
        Me.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.DisabledState.Parent = Me.txtaddress
        Me.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.FocusedState.Parent = Me.txtaddress
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.HoverState.Parent = Me.txtaddress
        Me.txtaddress.Location = New System.Drawing.Point(554, 428)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.PlaceholderText = ""
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.ShadowDecoration.Parent = Me.txtaddress
        Me.txtaddress.Size = New System.Drawing.Size(200, 36)
        Me.txtaddress.TabIndex = 31
        '
        'txtEmail
        '
        Me.txtEmail.BorderRadius = 8
        Me.txtEmail.BorderThickness = 0
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(554, 498)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(200, 36)
        Me.txtEmail.TabIndex = 32
        '
        'txtPhone
        '
        Me.txtPhone.BorderRadius = 8
        Me.txtPhone.BorderThickness = 0
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.DefaultText = ""
        Me.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhone.DisabledState.Parent = Me.txtPhone
        Me.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhone.FocusedState.Parent = Me.txtPhone
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtPhone.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhone.HoverState.Parent = Me.txtPhone
        Me.txtPhone.Location = New System.Drawing.Point(554, 574)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.PlaceholderText = ""
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.ShadowDecoration.Parent = Me.txtPhone
        Me.txtPhone.Size = New System.Drawing.Size(200, 36)
        Me.txtPhone.TabIndex = 33
        '
        'txtRollno
        '
        Me.txtRollno.BorderRadius = 8
        Me.txtRollno.BorderThickness = 0
        Me.txtRollno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRollno.DefaultText = ""
        Me.txtRollno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRollno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRollno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRollno.DisabledState.Parent = Me.txtRollno
        Me.txtRollno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRollno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRollno.FocusedState.Parent = Me.txtRollno
        Me.txtRollno.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtRollno.ForeColor = System.Drawing.Color.Black
        Me.txtRollno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRollno.HoverState.Parent = Me.txtRollno
        Me.txtRollno.Location = New System.Drawing.Point(554, 782)
        Me.txtRollno.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtRollno.Name = "txtRollno"
        Me.txtRollno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRollno.PlaceholderText = ""
        Me.txtRollno.SelectedText = ""
        Me.txtRollno.ShadowDecoration.Parent = Me.txtRollno
        Me.txtRollno.Size = New System.Drawing.Size(200, 36)
        Me.txtRollno.TabIndex = 34
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 8
        Me.txtPassword.BorderThickness = 0
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(554, 855)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(200, 36)
        Me.txtPassword.TabIndex = 35
        '
        'cmbCourse
        '
        Me.cmbCourse.BackColor = System.Drawing.Color.Transparent
        Me.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCourse.FocusedState.Parent = Me.cmbCourse
        Me.cmbCourse.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmbCourse.ForeColor = System.Drawing.Color.Black
        Me.cmbCourse.HoverState.Parent = Me.cmbCourse
        Me.cmbCourse.ItemHeight = 30
        Me.cmbCourse.ItemsAppearance.Parent = Me.cmbCourse
        Me.cmbCourse.Location = New System.Drawing.Point(554, 645)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.ShadowDecoration.Parent = Me.cmbCourse
        Me.cmbCourse.Size = New System.Drawing.Size(200, 36)
        Me.cmbCourse.TabIndex = 36
        '
        'txtAdmyear
        '
        Me.txtAdmyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmyear.Location = New System.Drawing.Point(554, 725)
        Me.txtAdmyear.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtAdmyear.Name = "txtAdmyear"
        Me.txtAdmyear.Size = New System.Drawing.Size(200, 34)
        Me.txtAdmyear.TabIndex = 37
        Me.txtAdmyear.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'datedob
        '
        Me.datedob.CheckedState.Parent = Me.datedob
        Me.datedob.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.datedob.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.datedob.HoverState.Parent = Me.datedob
        Me.datedob.Location = New System.Drawing.Point(554, 353)
        Me.datedob.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datedob.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datedob.Name = "datedob"
        Me.datedob.ShadowDecoration.Parent = Me.datedob
        Me.datedob.Size = New System.Drawing.Size(200, 36)
        Me.datedob.TabIndex = 38
        Me.datedob.Value = New Date(2021, 1, 17, 13, 52, 35, 899)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'addMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1052, 939)
        Me.Controls.Add(Me.datedob)
        Me.Controls.Add(Me.txtAdmyear)
        Me.Controls.Add(Me.cmbCourse)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtRollno)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtmemid)
        Me.Controls.Add(Me.cmbMember)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.rollLbl)
        Me.Controls.Add(Me.lbladm)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "addMember"
        Me.Text = "addMember"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdmyear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lbladm As Label
    Friend WithEvents rollLbl As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents picPhoto As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BtnBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbMember As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtmemid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRollno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtAdmyear As NumericUpDown
    Friend WithEvents datedob As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
