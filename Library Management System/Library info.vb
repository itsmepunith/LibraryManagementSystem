Imports MySql.Data.MySqlClient
Public Class Library_info
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Private Sub Library_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        queryloader()
    End Sub

    Private Sub queryloader()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String

            query = "select sum(copies) from librarydb.book_details"
            command = New MySqlCommand(query, sqlconnection)
            txtTotalBooks.Text = command.ExecuteScalar.ToString

            query = "select sum(price) from librarydb.book_details"
            command = New MySqlCommand(query, sqlconnection)
            txtCostBooks.Text = command.ExecuteScalar.ToString

            query = "select count(book_id) from librarydb.issue_details"
            command = New MySqlCommand(query, sqlconnection)
            txtIssuedBooks.Text = command.ExecuteScalar.ToString


            query = "select count(book_id) from librarydb.book_details where available='Yes'"
            command = New MySqlCommand(query, sqlconnection)
            txtAvailableBooks.Text = command.ExecuteScalar.ToString


            query = "select count(member_id) from librarydb.memberdetails "
            command = New MySqlCommand(query, sqlconnection)
            txtTotalMembers.Text = command.ExecuteScalar.ToString

            query = "select sum(price) from librarydb.book_details "
            command = New MySqlCommand(query, sqlconnection)
            Dim totalcost As String = command.ExecuteScalar.ToString
            txtCostBooks.Text = totalcost + " Rupees"

            query = "select sum(fine) from librarydb.submittedbooks "
            command = New MySqlCommand(query, sqlconnection)
            Dim totalfine As String = command.ExecuteScalar.ToString
            txtTotalFine.Text = totalfine + " Rupees"



        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Library_info_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub


End Class