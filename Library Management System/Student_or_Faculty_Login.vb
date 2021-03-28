Imports MySql.Data.MySqlClient
Public Class Student_or_Faculty_Login
    Dim conn As New MySqlConnection
    Dim command As New MySqlCommand
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If cmbtype.Text = "Student" Then
            student_login()
        ElseIf cmbtype.Text = "Faculty" Then
            faculty_login()
        End If
    End Sub

    Private Sub faculty_login()
        conn = New MySqlConnection
        conn.ConnectionString = ("server=localhost;user=root;password=punith123;database=librarydb")
        Try
            conn.Open()
            Dim query As String
            Dim reader As MySqlDataReader
            Dim count As Integer = 0
            query = "select * from librarydb.faculty_details where name='" & txtusername.Text & "' and password='" & txtpassword.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MsgBox("Login succesful", MsgBoxStyle.Information, "Login")
                Me.Hide()
                viewBooks.Show()
            Else
                MsgBox("Wrong username or password", MsgBoxStyle.Critical, "Wrong credentials")
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub student_login()
        conn = New MySqlConnection
        conn.ConnectionString = ("server=localhost;user=root;password=punith123;database=librarydb")
        Try
            conn.Open()
            Dim query As String
            Dim reader As MySqlDataReader
            Dim count As Integer = 0
            query = "select * from librarydb.memberdetails where rollno='" & txtusername.Text & "' and password='" & txtpassword.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MsgBox("Login succesful", MsgBoxStyle.Information, "Login")
                Me.Hide()
                viewBooks.Show()
            Else
                MsgBox("Wrong username or password", MsgBoxStyle.Critical, "Wrong credentials")
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtype.SelectedIndexChanged
        If cmbtype.Text = "Student" Then
            lblusrname.Text = "Roll No."
        ElseIf cmbtype.Text = "Faculty" Then
            lblusrname.Text = "Username"
        End If
    End Sub

    Private Sub Student_or_Faculty_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub
End Class