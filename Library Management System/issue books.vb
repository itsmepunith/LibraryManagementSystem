Imports MySql.Data.MySqlClient
Public Class issue_books
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Dim copies As String
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        usersearch()
        booksearch()
        txtmemname.Enabled = True
        txtbooktitle.Enabled = True
        dateBorrow.Enabled = True
        dateDue.Enabled = True
        BtnIssue.Enabled = True

    End Sub

    Private Sub booksearch()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "select * from librarydb.book_details where book_id = '" & txtbid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            Dim datareader As MySqlDataReader
            datareader = command.ExecuteReader
            Dim count As Integer = 0
            While datareader.Read
                count = count + 1
            End While
            If count = 1 Then
                txtbooktitle.Text = datareader.GetString("title")
            Else
                MsgBox("Book Not Found", MsgBoxStyle.Critical, "Error")
            End If
            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub usersearch()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "select * from librarydb.memberdetails where member_id = '" & txtmemberid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            Dim datareader As MySqlDataReader
            datareader = command.ExecuteReader
            Dim count As Integer = 0
            While datareader.Read
                count = count + 1
            End While
            If count = 1 Then
                txtmemname.Text = datareader.GetString("name")

            Else
                MsgBox("User Not Found", MsgBoxStyle.Critical, "Error")
            End If
            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub issue_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmemname.Enabled = False
        txtbooktitle.Enabled = False
        dateBorrow.Enabled = False
        dateDue.Enabled = False
        BtnIssue.Enabled = False
    End Sub

    Private Sub dateBorrow_ValueChanged(sender As Object, e As EventArgs) Handles dateBorrow.ValueChanged
        dateDue.Value = DateTime.Parse(dateBorrow.Value).AddDays(+10)

    End Sub

    Private Sub BtnIssue_Click(sender As Object, e As EventArgs) Handles BtnIssue.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "select * from librarydb.book_details where book_id='" & txtbid.Text & "'"
            Dim datareader As MySqlDataReader
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            While datareader.Read
                copies = datareader.GetString("copies").ToString
            End While
            If copies <= 0 Then
                set_availability()
                checkavailability()
            Else
                checkavailability()
            End If

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub book_issuer()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Dim return_status As String = "No"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "insert into librarydb.issue_details (book_id,member_id,book_title,member_name,issuedate,due_date,return_status) values ('" & txtbid.Text & "','" & txtmemberid.Text & "','" & txtbooktitle.Text & "','" & txtmemname.Text & "','" & dateBorrow.Text & "','" & dateDue.Text & "','" & return_status & "') "
            command = New MySqlCommand(query, sqlconnection)
            Dim datareader As MySqlDataReader
            datareader = command.ExecuteReader
            MsgBox("Issue data stored", MsgBoxStyle.Information, "Issue")
            minuscopies()
            txtbid.Text = ""
            txtmemberid.Text = ""
            txtmemname.Text = ""
            txtbooktitle.Text = ""
            dateBorrow.Text = ""
            dateDue.Text = ""

            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub checkavailability()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Dim return_status As String = "No"
        Try
            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            Dim count As Integer = 0
            Dim available As String = "Yes"
            query = "select * from librarydb.book_details where book_id='" & txtbid.Text & "' and available='" & available & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            While datareader.Read()
                count = count + 1

            End While

            If count = 1 Then
                book_issuer()
            Else
                MsgBox("Entered book is not available at the moment")
                txtbid.Text = ""
                txtmemberid.Text = ""
                txtmemname.Text = ""
                txtbooktitle.Text = ""
                dateBorrow.Text = ""
                dateDue.Text = ""
            End If


        Catch ex As MySqlException
            MsgBox(ex.Message,)
        End Try


    End Sub

    Private Sub set_availability()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            Dim available As String = "No"
            query = "update librarydb.book_details set available='" & available & "'where book_id='" & txtbid.Text & "'"
            Dim datareader As MySqlDataReader
            Dim count As Integer = 0
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub minuscopies()                                                  'minus 1 copy in database after issuing book
        Dim finalcopy = copies - 1
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            query = "update librarydb.book_details set  copies= '" & finalcopy & "'  where book_id='" & txtbid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub issue_books_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class