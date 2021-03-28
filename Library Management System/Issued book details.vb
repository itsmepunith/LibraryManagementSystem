Imports MySql.Data.MySqlClient

Public Class Issued_book_details
    Dim sqlconnection As MySqlConnection
    Dim command As New MySqlCommand
    Dim sda As MySqlDataAdapter
    Dim dbd As DataTable
    Dim bsource As BindingSource
    Private Sub issueBtn_Click(sender As Object, e As EventArgs) Handles issueBtn.Click
        Dim dbd As New DataTable
        dbd.Clear()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=librarydb"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Dim retstat As String = "No"


        Try
            sqlconnection.Open()
            dbd.Clear()
            Dim Query As String
            Query = "select book_id as 'Book id',member_id as 'Member id',Book_title as 'Book title',Member_name as 'Member name',issuedate as 'Issue date',due_date as 'Due date' from librarydb.issue_details where return_status='" & retstat & "'"
            command = New MySqlCommand(Query, sqlconnection)
            SDA.SelectCommand = command
            SDA.Fill(dbd)
            bSource.DataSource = dbd
            dgv.DataSource = bSource
            SDA.Update(dbd)


            sqlconnection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconnection.Dispose()
        End Try
    End Sub

    Private Sub returnBtn_Click(sender As Object, e As EventArgs) Handles returnBtn.Click
        Dim dbd As New DataTable
        dbd.Clear()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=librarydb"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Dim retstat As String = "Yes"


        Try
            sqlconnection.Open()
            dbd.Clear()
            Dim Query As String
            Query = "select bookid as 'Book id',memberid as 'Member id',Booktitle as 'Book title',Membername as 'Member name',issuedate as 'Issue date',duedate as 'Due date' from librarydb.submittedbooks where return_status='" & retstat & "'"
            command = New MySqlCommand(Query, sqlconnection)
            SDA.SelectCommand = command
            SDA.Fill(dbd)
            bSource.DataSource = dbd
            dgv.DataSource = bSource
            SDA.Update(dbd)


            sqlconnection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconnection.Dispose()
        End Try
    End Sub

    Private Sub Issued_book_details_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class