Imports MySql.Data.MySqlClient
Public Class Form1
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Dim datareader As MySqlDataReader

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Student_or_Faculty_Login.Show()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"

        Try
            sqlconnection.Open()
            Dim query As String
            query = "select * from librarydb.userdetails where username= '" & txtuser.Text & "' and password='" & txtpass.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader

            Dim count As Integer
            count = 0
            While datareader.Read
                count = count + 1
            End While

            If count = 1 Then
                Dim username = datareader.GetString("name")
                MsgBox("Welcome " & username & "  ")
                Me.Hide()
                Main_Form.Show()
                txtuser.Text = ""
                txtpass.Text = ""


            Else
                MsgBox(“Wrong Username or Password!”)
                txtuser.Text = ""
                txtpass.Text = ""
            End If

            sqlconnection.Close()



        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class
