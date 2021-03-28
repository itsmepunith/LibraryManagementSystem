Imports MySql.Data.MySqlClient
Public Class Course
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand

    Private Sub Course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        courseloader()
    End Sub

    Private Sub courseloader()
        listCourse.Items.Clear()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim datareader As MySqlDataReader
            Dim Query As String
            Query = "select course from librarydb.course_list   "
            command = New MySqlCommand(Query, sqlconnection)
            datareader = command.ExecuteReader
            While datareader.Read
                Dim course = datareader.GetString("course")
                listCourse.Items.Add(course)
            End While
            sqlconnection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconnection.Dispose()
        End Try
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb;"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "insert  into librarydb.course_list (course) values ('" & txtcoursename.Text & "')  "
            Dim datareader As MySqlDataReader
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            MsgBox("Inserted " & lblcourse.Text & "", MsgBoxStyle.Information, "Insert")
            txtcoursename.Text = ""
            courseloader()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        sqlconnection.Close()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb;"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "delete from librarydb.course_list where course='" & lblcourse.Text & "'  "
            command = New MySqlCommand(query, sqlconnection)
            Dim datareader As MySqlDataReader
            datareader = command.ExecuteReader
            MsgBox("Deleted " & lblcourse.Text & " ", MsgBoxStyle.Information, "Delete")
            courseloader()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        sqlconnection.Close()
    End Sub

    Private Sub listCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listCourse.SelectedIndexChanged
        txtcoursename.Text = listCourse.Text
    End Sub

    Private Sub Course_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class