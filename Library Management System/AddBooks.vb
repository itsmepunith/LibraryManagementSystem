Imports MySql.Data.MySqlClient
Imports System.IO
Public Class AddBooks
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Book_details.Show()
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "image file (*.jpg;*.bmp;*.gif;*.jpeg)|*.jpg;*.bmp;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            picPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        Try
            sqlconnection = New MySqlConnection("Server=localhost;user=root;password=punith123;database=librarydb")
            Dim query As String
            query = "insert into librarydb.book_details (book_id,book_no,title,author,category,publisher,language,year,description,image,price,shelf,available,copies) values (@book_id,@book_no,@title,@author,@category,@publisher,@language,@year,@description,@image,@price,@shelf,@available,@copies) "
            Dim ms As New MemoryStream
            picPhoto.Image.Save(ms, picPhoto.Image.RawFormat)
            sqlconnection.Open()
            command = New MySqlCommand(query, sqlconnection)
            command.Parameters.AddWithValue("@book_id", txtBid.Text)
            command.Parameters.AddWithValue("@book_no", txtBno.Text)
            command.Parameters.AddWithValue("@title", txtTitle.Text)
            command.Parameters.AddWithValue("@author", txtAuthor.Text)
            command.Parameters.AddWithValue("@category", cmbCategory.Text)
            command.Parameters.AddWithValue("@publisher", txtPublisher.Text)
            command.Parameters.AddWithValue("@language", txtLanguage.Text)
            command.Parameters.AddWithValue("@year", txtYear.Text)
            command.Parameters.AddWithValue("@description", txtDesc.Text)
            command.Parameters.AddWithValue("@price", txtPrice.Text)
            command.Parameters.AddWithValue("@shelf", txtshelf.Text)
            command.Parameters.AddWithValue("@copies", txtcopies.Text)
            command.Parameters.AddWithValue("@available", "Yes")
            command.Parameters.AddWithValue("@image", ms.ToArray())
            command.ExecuteNonQuery()
            sqlconnection.Close()
            MsgBox("Book added succesfully", MsgBoxStyle.Information, "Add Book")
            Me.Close()
            Main_Form.Show()
            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub comboload()
        Try
            sqlconnection = New MySqlConnection("Server=localhost;user=root;password=punith123;database=librarydb")
            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            query = "select * from librarydb.categories"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            While datareader.Read
                Dim cmbvalue = datareader.GetString("category")
                cmbCategory.Items.Add(cmbvalue)
            End While
            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub shelfload()
        Try
            sqlconnection = New MySqlConnection("Server=localhost;user=root;password=punith123;database=librarydb")
            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            query = "select * from librarydb.categories where category='" & cmbCategory.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            While datareader.Read
                Dim shelf = datareader.GetString("shelf")
                txtshelf.Text = shelf
            End While
            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboload()
    End Sub

    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged
        shelfload()
    End Sub

    Private Sub AddBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class