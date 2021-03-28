<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_availability
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
        Me.setUnavailable = New Guna.UI2.WinForms.Guna2Button()
        Me.setAvailable = New Guna.UI2.WinForms.Guna2Button()
        Me.txtavail = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpieces = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'setUnavailable
        '
        Me.setUnavailable.BackColor = System.Drawing.Color.Black
        Me.setUnavailable.CheckedState.Parent = Me.setUnavailable
        Me.setUnavailable.CustomImages.Parent = Me.setUnavailable
        Me.setUnavailable.FillColor = System.Drawing.Color.Black
        Me.setUnavailable.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.setUnavailable.ForeColor = System.Drawing.Color.White
        Me.setUnavailable.HoverState.Parent = Me.setUnavailable
        Me.setUnavailable.Location = New System.Drawing.Point(158, 343)
        Me.setUnavailable.Name = "setUnavailable"
        Me.setUnavailable.ShadowDecoration.Parent = Me.setUnavailable
        Me.setUnavailable.Size = New System.Drawing.Size(200, 45)
        Me.setUnavailable.TabIndex = 43
        Me.setUnavailable.Text = "Set Unavailable"
        '
        'setAvailable
        '
        Me.setAvailable.BackColor = System.Drawing.Color.Black
        Me.setAvailable.CheckedState.Parent = Me.setAvailable
        Me.setAvailable.CustomImages.Parent = Me.setAvailable
        Me.setAvailable.FillColor = System.Drawing.Color.Black
        Me.setAvailable.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.setAvailable.ForeColor = System.Drawing.Color.White
        Me.setAvailable.HoverState.Parent = Me.setAvailable
        Me.setAvailable.Location = New System.Drawing.Point(158, 281)
        Me.setAvailable.Name = "setAvailable"
        Me.setAvailable.ShadowDecoration.Parent = Me.setAvailable
        Me.setAvailable.Size = New System.Drawing.Size(200, 45)
        Me.setAvailable.TabIndex = 42
        Me.setAvailable.Text = "Set Available"
        '
        'txtavail
        '
        Me.txtavail.AutoSize = True
        Me.txtavail.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtavail.Location = New System.Drawing.Point(269, 229)
        Me.txtavail.Name = "txtavail"
        Me.txtavail.Size = New System.Drawing.Size(60, 24)
        Me.txtavail.TabIndex = 41
        Me.txtavail.Text = "No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 24)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "available"
        '
        'txtpieces
        '
        Me.txtpieces.AutoSize = True
        Me.txtpieces.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpieces.Location = New System.Drawing.Point(254, 190)
        Me.txtpieces.Name = "txtpieces"
        Me.txtpieces.Size = New System.Drawing.Size(60, 24)
        Me.txtpieces.TabIndex = 39
        Me.txtpieces.Text = "No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 24)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Pieces"
        '
        'txtBid
        '
        Me.txtBid.BorderRadius = 8
        Me.txtBid.BorderThickness = 0
        Me.txtBid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBid.DefaultText = ""
        Me.txtBid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBid.DisabledState.Parent = Me.txtBid
        Me.txtBid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBid.FocusedState.Parent = Me.txtBid
        Me.txtBid.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtBid.ForeColor = System.Drawing.Color.Black
        Me.txtBid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBid.HoverState.Parent = Me.txtBid
        Me.txtBid.Location = New System.Drawing.Point(158, 78)
        Me.txtBid.Name = "txtBid"
        Me.txtBid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBid.PlaceholderText = ""
        Me.txtBid.SelectedText = ""
        Me.txtBid.ShadowDecoration.Parent = Me.txtBid
        Me.txtBid.Size = New System.Drawing.Size(200, 36)
        Me.txtBid.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Engravers MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 29)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Book id"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Black
        Me.btnSearch.CheckedState.Parent = Me.btnSearch
        Me.btnSearch.CustomImages.Parent = Me.btnSearch
        Me.btnSearch.FillColor = System.Drawing.Color.Black
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.HoverState.Parent = Me.btnSearch
        Me.btnSearch.Location = New System.Drawing.Point(242, 132)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.Parent = Me.btnSearch
        Me.btnSearch.Size = New System.Drawing.Size(147, 42)
        Me.btnSearch.TabIndex = 44
        Me.btnSearch.Text = "Search"
        '
        'Book_availability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(454, 450)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.setUnavailable)
        Me.Controls.Add(Me.setAvailable)
        Me.Controls.Add(Me.txtavail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpieces)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBid)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Book_availability"
        Me.Text = "Book_availability"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents setUnavailable As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents setAvailable As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtavail As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpieces As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
End Class
