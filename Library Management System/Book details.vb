Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Book_details
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Private Sub Book_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "image file (*.jpg;*.bmp;*.gif;*.jpeg)|*.jpg;*.bmp;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            picphoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Dim datareader As MySqlDataReader
        Try
            sqlconnection.Open()
            Dim query As String
            query = "select * from librarydb.book_details where book_id='" & txtid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While datareader.Read
                count = count + 1
            End While
            If count = 1 Then
                txtbid.Text = datareader.GetString("book_id")
                txtbno.Text = datareader.GetString("book_no")
                txttitle.Text = datareader.GetString("title")
                txtauthor.Text = datareader.GetString("author")
                txtdesc.Text = datareader.GetString("description")
                txtCat.Text = datareader.GetString("category")
                txtpublisher.Text = datareader.GetString("publisher")
                txtLang.Text = datareader.GetString("language")
                txtPrice.Text = datareader.GetString("price")
                txtYear.Text = datareader.GetString("year")
                txtCopies.Text = datareader.GetString("copies")
                txtSHelf.Text = datareader.GetString("shelf")
                txtavail.Text = datareader.GetString("available")
                loadimg()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadimg()
        Dim myconn As New MySqlConnection
        Dim commandsql As New MySqlCommand
        myconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=librarydb")
        Dim query As String = "select * from librarydb.book_details where book_id=@book_id"
        myconn.Open()
        commandsql = New MySqlCommand(query, myconn)
        commandsql.Parameters.AddWithValue("@book_id", txtid.Text)
        Dim da As New MySqlDataAdapter(commandsql)
        Dim dt As New DataTable
        da.Fill(dt)
        txtid.Text = dt.Rows(0)("book_id").ToString
        Dim img() As Byte
        img = dt.Rows(0)("image")
        Dim ms As New MemoryStream(img)
        picPhoto.Image = Image.FromStream(ms)
        myconn.Close()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Try
            sqlconnection = New MySqlConnection("Server=localhost;user=root;password=punith123;database=librarydb")
            Dim query As String
            query = "update librarydb.book_details set book_id=@book_id,book_no=@book_no,title=@title,author=@author,category=@category,publisher=@publisher,language=@language,year=@year,description=@description,image=@image,price=@price,shelf=@shelf,copies=@copies where book_id= '" & txtid.Text & "'"
            Dim ms As New MemoryStream
            picPhoto.Image.Save(ms, picPhoto.Image.RawFormat)
            sqlconnection.Open()
            command = New MySqlCommand(query, sqlconnection)
            command.Parameters.AddWithValue("@book_id", txtbid.Text)
            command.Parameters.AddWithValue("@book_no", txtbno.Text)
            command.Parameters.AddWithValue("@title", txttitle.Text)
            command.Parameters.AddWithValue("@author", txtauthor.Text)
            command.Parameters.AddWithValue("@category", txtCat.Text)
            command.Parameters.AddWithValue("@publisher", txtpublisher.Text)
            command.Parameters.AddWithValue("@language", txtLang.Text)
            command.Parameters.AddWithValue("@year", txtYear.Text)
            command.Parameters.AddWithValue("@description", txtdesc.Text)
            command.Parameters.AddWithValue("@price", txtPrice.Text)
            command.Parameters.AddWithValue("@shelf", txtSHelf.Text)
            command.Parameters.AddWithValue("@copies", txtCopies.Text)
            command.Parameters.AddWithValue("@available", "Yes")
            command.Parameters.AddWithValue("@image", ms.ToArray())
            command.ExecuteNonQuery()
            sqlconnection.Close()
            MsgBox("Book Updated succesfully", MsgBoxStyle.Information, "Update Book")
            filedclear()
        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim datareader As MySqlDataReader
            Dim query As String
            query = "delete from librarydb.book_details where book_id='" & txtid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            MsgBox("Book details deleted", MsgBoxStyle.Information, "Delete")
            filedclear()
            Me.Close()
            Main_Form.Show()

            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub filedclear()
        txtbid.Text = ""
        txtauthor.Text = ""
        txtavail.Text = ""
        txtbno.Text = ""
        txtCat.Text = ""
        txtCopies.Text = ""
        txtdesc.Text = ""
        txtid.Text = ""
        txtLang.Text = ""
        txtPrice.Text = ""
        txtpublisher.Text = ""
        txtSHelf.Text = ""
        txttitle.Text = ""
        txtYear.Text = ""
        picPhoto.Image = Nothing

    End Sub

    Private Sub Book_details_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AddBooks.Show()
    End Sub
End Class