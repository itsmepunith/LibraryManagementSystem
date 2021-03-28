Imports MySql.Data.MySqlClient

Public Class Return_Books
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Dim copies As String

    Private Sub Return_Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmemname.Enabled = False
        txtbooktitle.Enabled = False
        dateBorrow.Enabled = False
        dateDue.Enabled = False
        btnReturn.Enabled = False
        SubmitDate.Enabled = False

    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        searchsub()

    End Sub

    Private Sub searchsub()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            Dim count As Integer = 0
            query = "select * from librarydb.issue_details where (book_id='" & txtBid.Text & "' and member_id='" & txtmemberid.Text & "') and return_status='No'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            While datareader.Read
                count = count + 1
            End While
            If count = 1 Then
                txtbooktitle.Text = datareader.GetString("book_title")
                txtmemname.Text = datareader.GetString("member_name")
                dateBorrow.Value = datareader.GetString("issuedate")
                dateDue.Value = datareader.GetString("due_date")
                txtmemname.Enabled = True
                txtbooktitle.Enabled = True
                dateBorrow.Enabled = True
                dateDue.Enabled = True
                btnReturn.Enabled = True
                SubmitDate.Enabled = True
                SubmitDate.Text = dateDue.Value
                SubmitDate.MinDate = dateDue.Value

            Else

                MsgBox("Either book id or member id is wrong , try again", MsgBoxStyle.Critical, "error")
                txtBid.Text = ""
                txtmemberid.Text = ""
            End If
            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub difference()
        Dim dateone = dateDue.Value
        Dim datetwo = SubmitDate.Value
        Dim diff As TimeSpan = datetwo.Subtract(dateone)
        Dim finaldate As Double
        finaldate = diff.Days
        txtfine.Text = finaldate * 2
    End Sub



    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Dim ret_status As String = "Yes"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "insert into librarydb.submittedbooks (bookid,memberid,booktitle,membername,issuedate,duedate,submitdate,fine,return_status) values ('" & txtBid.Text & "','" & txtmemberid.Text & "','" & txtbooktitle.Text & "','" & txtmemname.Text & "','" & dateBorrow.Text & "','" & dateDue.Text & "','" & SubmitDate.Text & "','" & txtfine.Text & "','" & ret_status & "')"
            command = New MySqlCommand(query, sqlconnection)
            Dim datareader As MySqlDataReader
            datareader = command.ExecuteReader

            MsgBox("Return data stored succesfully", MsgBoxStyle.Information, "Return")
            returnedstatus()
            addcopies()
            setavailability()
            updater()
            Me.Hide()
            Main_Form.Show()
            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub returnedstatus()
        Dim returnstatus As String = "Yes"
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "update librarydb.issue_details set return_status='" & returnstatus & "'where book_id='" & txtBid.Text & "' and member_id='" & txtmemberid.Text & "'"
            Dim datareader As MySqlDataReader
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub addcopies()                                                  'adds 1 copy in database after returning book

        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            query = "select * from librarydb.book_Details where book_id='" & txtBid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            While datareader.Read
                copies = datareader.GetString("copies")
            End While


        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub setavailability()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            query = "update librarydb.book_Details set available='Yes' where book_id='" & txtBid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub updater()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            query = "update librarydb.book_Details set copies=copies+1 where book_id='" & txtBid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SubmitDate_ValueChanged_1(sender As Object, e As EventArgs) Handles SubmitDate.ValueChanged
        difference()
    End Sub

    Private Sub Return_Books_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class