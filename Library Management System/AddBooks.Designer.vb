<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBooks))
        Me.Btnadd = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.picPhoto = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtShelf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCopies = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtyear = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtlanguage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpublisher = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbcategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAuthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnadd
        '
        Me.Btnadd.AutoRoundedCorners = True
        Me.Btnadd.BorderRadius = 21
        Me.Btnadd.CheckedState.Parent = Me.Btnadd
        Me.Btnadd.CustomImages.Parent = Me.Btnadd
        Me.Btnadd.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Btnadd.ForeColor = System.Drawing.Color.Black
        Me.Btnadd.HoverState.Parent = Me.Btnadd
        Me.Btnadd.Location = New System.Drawing.Point(1080, 504)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.ShadowDecoration.Parent = Me.Btnadd
        Me.Btnadd.Size = New System.Drawing.Size(180, 45)
        Me.Btnadd.TabIndex = 102
        Me.Btnadd.Text = "Add book"
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
        Me.BtnBrowse.Location = New System.Drawing.Point(1080, 393)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.ShadowDecoration.Parent = Me.BtnBrowse
        Me.BtnBrowse.Size = New System.Drawing.Size(180, 45)
        Me.BtnBrowse.TabIndex = 101
        Me.BtnBrowse.Text = "Browse"
        '
        'picPhoto
        '
        Me.picPhoto.Image = CType(resources.GetObject("picPhoto.Image"), System.Drawing.Image)
        Me.picPhoto.Location = New System.Drawing.Point(987, 147)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.ShadowDecoration.Parent = Me.picPhoto
        Me.picPhoto.Size = New System.Drawing.Size(300, 200)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPhoto.TabIndex = 100
        Me.picPhoto.TabStop = False
        '
        'txtShelf
        '
        Me.txtShelf.BorderRadius = 8
        Me.txtShelf.BorderThickness = 0
        Me.txtShelf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShelf.DefaultText = ""
        Me.txtShelf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtShelf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtShelf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtShelf.DisabledState.Parent = Me.txtShelf
        Me.txtShelf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtShelf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtShelf.FocusedState.Parent = Me.txtShelf
        Me.txtShelf.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtShelf.ForeColor = System.Drawing.Color.Black
        Me.txtShelf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtShelf.HoverState.Parent = Me.txtShelf
        Me.txtShelf.Location = New System.Drawing.Point(739, 782)
        Me.txtShelf.Name = "txtShelf"
        Me.txtShelf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtShelf.PlaceholderText = ""
        Me.txtShelf.SelectedText = ""
        Me.txtShelf.ShadowDecoration.Parent = Me.txtShelf
        Me.txtShelf.Size = New System.Drawing.Size(200, 36)
        Me.txtShelf.TabIndex = 99
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
        Me.txtCopies.Location = New System.Drawing.Point(739, 731)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCopies.PlaceholderText = ""
        Me.txtCopies.SelectedText = ""
        Me.txtCopies.ShadowDecoration.Parent = Me.txtCopies
        Me.txtCopies.Size = New System.Drawing.Size(200, 36)
        Me.txtCopies.TabIndex = 98
        '
        'txtyear
        '
        Me.txtyear.BorderRadius = 8
        Me.txtyear.BorderThickness = 0
        Me.txtyear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtyear.DefaultText = ""
        Me.txtyear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtyear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtyear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtyear.DisabledState.Parent = Me.txtyear
        Me.txtyear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtyear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtyear.FocusedState.Parent = Me.txtyear
        Me.txtyear.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtyear.ForeColor = System.Drawing.Color.Black
        Me.txtyear.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtyear.HoverState.Parent = Me.txtyear
        Me.txtyear.Location = New System.Drawing.Point(739, 678)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtyear.PlaceholderText = ""
        Me.txtyear.SelectedText = ""
        Me.txtyear.ShadowDecoration.Parent = Me.txtyear
        Me.txtyear.Size = New System.Drawing.Size(200, 36)
        Me.txtyear.TabIndex = 97
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
        Me.txtPrice.Location = New System.Drawing.Point(739, 631)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.ShadowDecoration.Parent = Me.txtPrice
        Me.txtPrice.Size = New System.Drawing.Size(200, 36)
        Me.txtPrice.TabIndex = 96
        '
        'txtlanguage
        '
        Me.txtlanguage.BorderRadius = 8
        Me.txtlanguage.BorderThickness = 0
        Me.txtlanguage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlanguage.DefaultText = ""
        Me.txtlanguage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlanguage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlanguage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlanguage.DisabledState.Parent = Me.txtlanguage
        Me.txtlanguage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlanguage.FocusedState.Parent = Me.txtlanguage
        Me.txtlanguage.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtlanguage.ForeColor = System.Drawing.Color.Black
        Me.txtlanguage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlanguage.HoverState.Parent = Me.txtlanguage
        Me.txtlanguage.Location = New System.Drawing.Point(739, 576)
        Me.txtlanguage.Name = "txtlanguage"
        Me.txtlanguage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlanguage.PlaceholderText = ""
        Me.txtlanguage.SelectedText = ""
        Me.txtlanguage.ShadowDecoration.Parent = Me.txtlanguage
        Me.txtlanguage.Size = New System.Drawing.Size(200, 36)
        Me.txtlanguage.TabIndex = 95
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
        Me.txtpublisher.Location = New System.Drawing.Point(739, 513)
        Me.txtpublisher.Name = "txtpublisher"
        Me.txtpublisher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpublisher.PlaceholderText = ""
        Me.txtpublisher.SelectedText = ""
        Me.txtpublisher.ShadowDecoration.Parent = Me.txtpublisher
        Me.txtpublisher.Size = New System.Drawing.Size(200, 36)
        Me.txtpublisher.TabIndex = 94
        '
        'cmbcategory
        '
        Me.cmbcategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcategory.FocusedState.Parent = Me.cmbcategory
        Me.cmbcategory.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmbcategory.ForeColor = System.Drawing.Color.Black
        Me.cmbcategory.HoverState.Parent = Me.cmbcategory
        Me.cmbcategory.ItemHeight = 30
        Me.cmbcategory.ItemsAppearance.Parent = Me.cmbcategory
        Me.cmbcategory.Location = New System.Drawing.Point(739, 449)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.ShadowDecoration.Parent = Me.cmbcategory
        Me.cmbcategory.Size = New System.Drawing.Size(200, 36)
        Me.cmbcategory.TabIndex = 93
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(478, 789)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 29)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "Shelf"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(478, 738)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 29)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Copies"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(469, 685)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 29)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Years"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(469, 638)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 29)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(469, 583)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(206, 29)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Language"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(469, 520)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(215, 29)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Publisher"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(469, 456)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(206, 29)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Category"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(469, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 29)
        Me.Label8.TabIndex = 85
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
        Me.txtdesc.Location = New System.Drawing.Point(739, 383)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdesc.PlaceholderText = ""
        Me.txtdesc.SelectedText = ""
        Me.txtdesc.ShadowDecoration.Parent = Me.txtdesc
        Me.txtdesc.Size = New System.Drawing.Size(200, 36)
        Me.txtdesc.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(405, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 41)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Add books"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(469, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 29)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Author"
        '
        'txtAuthor
        '
        Me.txtAuthor.BorderRadius = 8
        Me.txtAuthor.BorderThickness = 0
        Me.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAuthor.DefaultText = ""
        Me.txtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAuthor.DisabledState.Parent = Me.txtAuthor
        Me.txtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAuthor.FocusedState.Parent = Me.txtAuthor
        Me.txtAuthor.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtAuthor.ForeColor = System.Drawing.Color.Black
        Me.txtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAuthor.HoverState.Parent = Me.txtAuthor
        Me.txtAuthor.Location = New System.Drawing.Point(739, 318)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAuthor.PlaceholderText = ""
        Me.txtAuthor.SelectedText = ""
        Me.txtAuthor.ShadowDecoration.Parent = Me.txtAuthor
        Me.txtAuthor.Size = New System.Drawing.Size(200, 36)
        Me.txtAuthor.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(469, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 29)
        Me.Label6.TabIndex = 81
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
        Me.txttitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txttitle.ForeColor = System.Drawing.Color.Black
        Me.txttitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttitle.HoverState.Parent = Me.txttitle
        Me.txttitle.Location = New System.Drawing.Point(739, 267)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttitle.PlaceholderText = ""
        Me.txttitle.SelectedText = ""
        Me.txttitle.ShadowDecoration.Parent = Me.txttitle
        Me.txttitle.Size = New System.Drawing.Size(200, 36)
        Me.txttitle.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(469, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 29)
        Me.Label5.TabIndex = 79
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
        Me.txtbno.Location = New System.Drawing.Point(739, 209)
        Me.txtbno.Name = "txtbno"
        Me.txtbno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbno.PlaceholderText = ""
        Me.txtbno.SelectedText = ""
        Me.txtbno.ShadowDecoration.Parent = Me.txtbno
        Me.txtbno.Size = New System.Drawing.Size(200, 36)
        Me.txtbno.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(470, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 29)
        Me.Label3.TabIndex = 77
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
        Me.txtbid.Location = New System.Drawing.Point(739, 147)
        Me.txtbid.Name = "txtbid"
        Me.txtbid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbid.PlaceholderText = ""
        Me.txtbid.SelectedText = ""
        Me.txtbid.ShadowDecoration.Parent = Me.txtbid
        Me.txtbid.Size = New System.Drawing.Size(200, 36)
        Me.txtbid.TabIndex = 76
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1118, 132)
        Me.Guna2Panel1.TabIndex = 71
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(200, 846)
        Me.Guna2Panel2.TabIndex = 70
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(1075, 793)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(241, 25)
        Me.LinkLabel1.TabIndex = 103
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Edit books ?? click here"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AddBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1318, 846)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.txtShelf)
        Me.Controls.Add(Me.txtCopies)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtlanguage)
        Me.Controls.Add(Me.txtpublisher)
        Me.Controls.Add(Me.cmbcategory)
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
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbid)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Name = "AddBooks"
        Me.Text = "Add Books"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnadd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents picPhoto As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtShelf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCopies As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtyear As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtlanguage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpublisher As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbcategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAuthor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
