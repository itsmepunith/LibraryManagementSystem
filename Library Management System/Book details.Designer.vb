<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book_details))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.searchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtauthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtpublisher = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtYear = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCopies = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSHelf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.picPhoto = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.updateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.txtavail = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1138, 132)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(405, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 41)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Book Details"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(200, 844)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(206, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 29)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Book id"
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.Gainsboro
        Me.txtid.BorderRadius = 8
        Me.txtid.BorderThickness = 0
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.DefaultText = ""
        Me.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtid.DisabledState.Parent = Me.txtid
        Me.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.FocusedState.Parent = Me.txtid
        Me.txtid.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtid.ForeColor = System.Drawing.Color.Black
        Me.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.HoverState.Parent = Me.txtid
        Me.txtid.Location = New System.Drawing.Point(223, 186)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.PlaceholderText = ""
        Me.txtid.SelectedText = ""
        Me.txtid.ShadowDecoration.Parent = Me.txtid
        Me.txtid.Size = New System.Drawing.Size(200, 36)
        Me.txtid.TabIndex = 38
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
        Me.searchBtn.Location = New System.Drawing.Point(232, 251)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.ShadowDecoration.Parent = Me.searchBtn
        Me.searchBtn.Size = New System.Drawing.Size(180, 45)
        Me.searchBtn.TabIndex = 40
        Me.searchBtn.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Engravers MT", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(218, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 28)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Available"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(490, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 29)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Book id"
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
        Me.txtbid.Location = New System.Drawing.Point(759, 147)
        Me.txtbid.Name = "txtbid"
        Me.txtbid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbid.PlaceholderText = ""
        Me.txtbid.SelectedText = ""
        Me.txtbid.ShadowDecoration.Parent = Me.txtbid
        Me.txtbid.Size = New System.Drawing.Size(200, 36)
        Me.txtbid.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(489, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 29)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Book no."
        '
        'txtbno
        '
        Me.txtbno.BorderRadius = 8
        Me.txtbno.BorderThickness = 0
        Me.txtbno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbno.DefaultText = ""
        Me.txtbno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbno.DisabledState.Parent = Me.txtbno
        Me.txtbno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbno.FocusedState.Parent = Me.txtbno
        Me.txtbno.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtbno.ForeColor = System.Drawing.Color.Black
        Me.txtbno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbno.HoverState.Parent = Me.txtbno
        Me.txtbno.Location = New System.Drawing.Point(759, 209)
        Me.txtbno.Name = "txtbno"
        Me.txtbno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbno.PlaceholderText = ""
        Me.txtbno.SelectedText = ""
        Me.txtbno.ShadowDecoration.Parent = Me.txtbno
        Me.txtbno.Size = New System.Drawing.Size(200, 36)
        Me.txtbno.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(489, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 29)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Title"
        '
        'txttitle
        '
        Me.txttitle.BorderRadius = 8
        Me.txttitle.BorderThickness = 0
        Me.txttitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttitle.DefaultText = ""
        Me.txttitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttitle.DisabledState.Parent = Me.txttitle
        Me.txttitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttitle.FocusedState.Parent = Me.txttitle
        Me.txttitle.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txttitle.ForeColor = System.Drawing.Color.Black
        Me.txttitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttitle.HoverState.Parent = Me.txttitle
        Me.txttitle.Location = New System.Drawing.Point(759, 267)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttitle.PlaceholderText = ""
        Me.txttitle.SelectedText = ""
        Me.txttitle.ShadowDecoration.Parent = Me.txttitle
        Me.txttitle.Size = New System.Drawing.Size(200, 36)
        Me.txttitle.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(489, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 29)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Author"
        '
        'txtauthor
        '
        Me.txtauthor.BorderRadius = 8
        Me.txtauthor.BorderThickness = 0
        Me.txtauthor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtauthor.DefaultText = ""
        Me.txtauthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtauthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtauthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtauthor.DisabledState.Parent = Me.txtauthor
        Me.txtauthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtauthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtauthor.FocusedState.Parent = Me.txtauthor
        Me.txtauthor.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtauthor.ForeColor = System.Drawing.Color.Black
        Me.txtauthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtauthor.HoverState.Parent = Me.txtauthor
        Me.txtauthor.Location = New System.Drawing.Point(759, 318)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtauthor.PlaceholderText = ""
        Me.txtauthor.SelectedText = ""
        Me.txtauthor.ShadowDecoration.Parent = Me.txtauthor
        Me.txtauthor.Size = New System.Drawing.Size(200, 36)
        Me.txtauthor.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(489, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 29)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Description"
        '
        'txtdesc
        '
        Me.txtdesc.BorderRadius = 8
        Me.txtdesc.BorderThickness = 0
        Me.txtdesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdesc.DefaultText = ""
        Me.txtdesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdesc.DisabledState.Parent = Me.txtdesc
        Me.txtdesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdesc.FocusedState.Parent = Me.txtdesc
        Me.txtdesc.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtdesc.ForeColor = System.Drawing.Color.Black
        Me.txtdesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdesc.HoverState.Parent = Me.txtdesc
        Me.txtdesc.Location = New System.Drawing.Point(759, 383)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdesc.PlaceholderText = ""
        Me.txtdesc.SelectedText = ""
        Me.txtdesc.ShadowDecoration.Parent = Me.txtdesc
        Me.txtdesc.Size = New System.Drawing.Size(200, 36)
        Me.txtdesc.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(489, 456)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(206, 29)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Category"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(489, 520)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(215, 29)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Publisher"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(489, 583)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(206, 29)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Language"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(489, 638)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 29)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Price"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(489, 685)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 29)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Years"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(498, 738)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 29)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Copies"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(498, 789)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 29)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Shelf"
        '
        'txtpublisher
        '
        Me.txtpublisher.BorderRadius = 8
        Me.txtpublisher.BorderThickness = 0
        Me.txtpublisher.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpublisher.DefaultText = ""
        Me.txtpublisher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpublisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpublisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpublisher.DisabledState.Parent = Me.txtpublisher
        Me.txtpublisher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpublisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpublisher.FocusedState.Parent = Me.txtpublisher
        Me.txtpublisher.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtpublisher.ForeColor = System.Drawing.Color.Black
        Me.txtpublisher.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpublisher.HoverState.Parent = Me.txtpublisher
        Me.txtpublisher.Location = New System.Drawing.Point(759, 513)
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpublisher.PlaceholderText = ""
        Me.txtpublisher.SelectedText = ""
        Me.txtpublisher.ShadowDecoration.Parent = Me.txtpublisher
        Me.txtpublisher.Size = New System.Drawing.Size(200, 36)
        Me.txtpublisher.TabIndex = 60
        '
        'txtLang
        '
        Me.txtLang.BorderRadius = 8
        Me.txtLang.BorderThickness = 0
        Me.txtLang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLang.DefaultText = ""
        Me.txtLang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLang.DisabledState.Parent = Me.txtLang
        Me.txtLang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLang.FocusedState.Parent = Me.txtLang
        Me.txtLang.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtLang.ForeColor = System.Drawing.Color.Black
        Me.txtLang.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLang.HoverState.Parent = Me.txtLang
        Me.txtLang.Location = New System.Drawing.Point(759, 576)
        Me.txtLang.Name = "txtLang"
        Me.txtLang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLang.PlaceholderText = ""
        Me.txtLang.SelectedText = ""
        Me.txtLang.ShadowDecoration.Parent = Me.txtLang
        Me.txtLang.Size = New System.Drawing.Size(200, 36)
        Me.txtLang.TabIndex = 61
        '
        'txtPrice
        '
        Me.txtPrice.BorderRadius = 8
        Me.txtPrice.BorderThickness = 0
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.Parent = Me.txtPrice
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.FocusedState.Parent = Me.txtPrice
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.HoverState.Parent = Me.txtPrice
        Me.txtPrice.Location = New System.Drawing.Point(759, 631)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.ShadowDecoration.Parent = Me.txtPrice
        Me.txtPrice.Size = New System.Drawing.Size(200, 36)
        Me.txtPrice.TabIndex = 62
        '
        'txtYear
        '
        Me.txtYear.BorderRadius = 8
        Me.txtYear.BorderThickness = 0
        Me.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYear.DefaultText = ""
        Me.txtYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYear.DisabledState.Parent = Me.txtYear
        Me.txtYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYear.FocusedState.Parent = Me.txtYear
        Me.txtYear.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtYear.ForeColor = System.Drawing.Color.Black
        Me.txtYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYear.HoverState.Parent = Me.txtYear
        Me.txtYear.Location = New System.Drawing.Point(759, 678)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYear.PlaceholderText = ""
        Me.txtYear.SelectedText = ""
        Me.txtYear.ShadowDecoration.Parent = Me.txtYear
        Me.txtYear.Size = New System.Drawing.Size(200, 36)
        Me.txtYear.TabIndex = 63
        '
        'txtCopies
        '
        Me.txtCopies.BorderRadius = 8
        Me.txtCopies.BorderThickness = 0
        Me.txtCopies.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCopies.DefaultText = ""
        Me.txtCopies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCopies.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCopies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCopies.DisabledState.Parent = Me.txtCopies
        Me.txtCopies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCopies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCopies.FocusedState.Parent = Me.txtCopies
        Me.txtCopies.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtCopies.ForeColor = System.Drawing.Color.Black
        Me.txtCopies.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCopies.HoverState.Parent = Me.txtCopies
        Me.txtCopies.Location = New System.Drawing.Point(759, 731)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCopies.PlaceholderText = ""
        Me.txtCopies.SelectedText = ""
        Me.txtCopies.ShadowDecoration.Parent = Me.txtCopies
        Me.txtCopies.Size = New System.Drawing.Size(200, 36)
        Me.txtCopies.TabIndex = 64
        '
        'txtSHelf
        '
        Me.txtSHelf.BorderRadius = 8
        Me.txtSHelf.BorderThickness = 0
        Me.txtSHelf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSHelf.DefaultText = ""
        Me.txtSHelf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSHelf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSHelf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSHelf.DisabledState.Parent = Me.txtSHelf
        Me.txtSHelf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSHelf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSHelf.FocusedState.Parent = Me.txtSHelf
        Me.txtSHelf.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtSHelf.ForeColor = System.Drawing.Color.Black
        Me.txtSHelf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSHelf.HoverState.Parent = Me.txtSHelf
        Me.txtSHelf.Location = New System.Drawing.Point(759, 782)
        Me.txtSHelf.Name = "txtSHelf"
        Me.txtSHelf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSHelf.PlaceholderText = ""
        Me.txtSHelf.SelectedText = ""
        Me.txtSHelf.ShadowDecoration.Parent = Me.txtSHelf
        Me.txtSHelf.Size = New System.Drawing.Size(200, 36)
        Me.txtSHelf.TabIndex = 65
        '
        'picPhoto
        '
        Me.picPhoto.Image = CType(resources.GetObject("picPhoto.Image"), System.Drawing.Image)
        Me.picPhoto.Location = New System.Drawing.Point(1026, 154)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.ShadowDecoration.Parent = Me.picPhoto
        Me.picPhoto.Size = New System.Drawing.Size(300, 200)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPhoto.TabIndex = 66
        Me.picPhoto.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.AutoRoundedCorners = True
        Me.btnBrowse.BorderRadius = 21
        Me.btnBrowse.CheckedState.Parent = Me.btnBrowse
        Me.btnBrowse.CustomImages.Parent = Me.btnBrowse
        Me.btnBrowse.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.HoverState.Parent = Me.btnBrowse
        Me.btnBrowse.Location = New System.Drawing.Point(1100, 393)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.ShadowDecoration.Parent = Me.btnBrowse
        Me.btnBrowse.Size = New System.Drawing.Size(180, 45)
        Me.btnBrowse.TabIndex = 67
        Me.btnBrowse.Text = "Browse"
        '
        'updateBtn
        '
        Me.updateBtn.AutoRoundedCorners = True
        Me.updateBtn.BorderRadius = 21
        Me.updateBtn.CheckedState.Parent = Me.updateBtn
        Me.updateBtn.CustomImages.Parent = Me.updateBtn
        Me.updateBtn.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.updateBtn.ForeColor = System.Drawing.Color.Black
        Me.updateBtn.HoverState.Parent = Me.updateBtn
        Me.updateBtn.Location = New System.Drawing.Point(1100, 697)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.ShadowDecoration.Parent = Me.updateBtn
        Me.updateBtn.Size = New System.Drawing.Size(180, 45)
        Me.updateBtn.TabIndex = 68
        Me.updateBtn.Text = "Update"
        '
        'BtnDelete
        '
        Me.BtnDelete.AutoRoundedCorners = True
        Me.BtnDelete.BorderRadius = 21
        Me.BtnDelete.CheckedState.Parent = Me.BtnDelete
        Me.BtnDelete.CustomImages.Parent = Me.BtnDelete
        Me.BtnDelete.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.ForeColor = System.Drawing.Color.Black
        Me.BtnDelete.HoverState.Parent = Me.BtnDelete
        Me.BtnDelete.Location = New System.Drawing.Point(1100, 761)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.ShadowDecoration.Parent = Me.BtnDelete
        Me.BtnDelete.Size = New System.Drawing.Size(180, 45)
        Me.BtnDelete.TabIndex = 69
        Me.BtnDelete.Text = "Delete"
        '
        'txtavail
        '
        Me.txtavail.AutoSize = True
        Me.txtavail.Font = New System.Drawing.Font("Engravers MT", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtavail.Location = New System.Drawing.Point(218, 393)
        Me.txtavail.Name = "txtavail"
        Me.txtavail.Size = New System.Drawing.Size(0, 28)
        Me.txtavail.TabIndex = 70
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtCat
        '
        Me.txtCat.BorderRadius = 8
        Me.txtCat.BorderThickness = 0
        Me.txtCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCat.DefaultText = ""
        Me.txtCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCat.DisabledState.Parent = Me.txtCat
        Me.txtCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCat.FocusedState.Parent = Me.txtCat
        Me.txtCat.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtCat.ForeColor = System.Drawing.Color.Black
        Me.txtCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCat.HoverState.Parent = Me.txtCat
        Me.txtCat.Location = New System.Drawing.Point(759, 449)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCat.PlaceholderText = ""
        Me.txtCat.SelectedText = ""
        Me.txtCat.ShadowDecoration.Parent = Me.txtCat
        Me.txtCat.Size = New System.Drawing.Size(200, 36)
        Me.txtCat.TabIndex = 71
        '
        'Book_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1338, 844)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.txtavail)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.txtSHelf)
        Me.Controls.Add(Me.txtCopies)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtLang)
        Me.Controls.Add(Me.txtpublisher)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtauthor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Name = "Book_details"
        Me.Text = "Book_details"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents searchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtauthor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtpublisher As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLang As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtYear As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCopies As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSHelf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents picPhoto As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents updateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtavail As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtCat As Guna.UI2.WinForms.Guna2TextBox
End Class
