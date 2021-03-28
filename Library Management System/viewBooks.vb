Imports MySql.Data.MySqlClient
Imports System.IO
Public Class viewBooks
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
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
                txtTitle.Text = datareader.GetString("title")
                txtAuthor.Text = datareader.GetString("author")
                txtDesc.Text = datareader.GetString("description")
                txtcat.Text = datareader.GetString("category")
                txtPublisher.Text = datareader.GetString("publisher")
                txtLang.Text = datareader.GetString("language")
                txtPrice.Text = datareader.GetString("price")
                txtYear.Text = datareader.GetString("year")
                txtCopies.Text = datareader.GetString("copies")
                txtShelf.Text = datareader.GetString("shelf")
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
        picphoto.Image = Image.FromStream(ms)
        myconn.Close()
    End Sub

    Private Sub viewBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub
End Class