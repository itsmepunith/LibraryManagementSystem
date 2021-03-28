Imports MySql.Data.MySqlClient
Public Class Manage_admins
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Dim oldpass As String
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Me.Hide()
        addAdmin.Show()
    End Sub

    Private Sub Manage_admins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlPassword.Visible = False
        pnlDelete.Visible = False
        OkBtn.Enabled = False
        txtNewPass.Enabled = False
        txtRepass.Enabled = False
        changePassBtn.Enabled = False
        loaddvg()
    End Sub

    Private Sub Btnpassword_Click(sender As Object, e As EventArgs) Handles Btnpassword.Click
        pnlPassword.Visible = True
        pnlDelete.Visible = False
        txtoldpass.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        pnlDelete.Visible = True
        pnlPassword.Visible = False
    End Sub

    Private Sub deletBtn_Click(sender As Object, e As EventArgs) Handles deletBtn.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            query = "select * from librarydb.userdetails where username='" & txtadmnid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While datareader.Read
                count = count + 1
            End While
            If count = 1 Then
                deleter()
                loaddvg()
            Else
                MsgBox("User Not Found", MsgBoxStyle.Information)
                txtadmnid.Text = ""
                pnlDelete.Visible = False
            End If
            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub deleter()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim datareader As MySqlDataReader
            Dim deletequery As String
            deletequery = "delete from librarydb.userdetails where username='" & txtadmnid.Text & "'"
            MsgBox("Userdata deleted", MsgBoxStyle.Information, "Delete")
            command = New MySqlCommand(deletequery, sqlconnection)
            datareader = command.ExecuteReader
            txtadmnid.Text = ""
            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loaddvg()
        Dim dbd As New DataTable
        dbd.Clear()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=librarydb"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource


        Try
            sqlconnection.Open()
            dbd.Clear()
            Dim Query As String
            Query = "select name,address,phonenumber,email from librarydb.userdetails "

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

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try

            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            query = "select * from librarydb.userdetails where username='" & txtusern.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While datareader.Read
                count = count + 1
                oldpass = datareader.GetString("password")
            End While
            If count = 1 Then
                OkBtn.Enabled = True
            Else
                MsgBox("User not found", MsgBoxStyle.Critical, "User not found")
                txtusern.Text = ""
            End If
            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        If txtoldpass.Text = oldpass Then
            MsgBox("Password verified succesfully", MsgBoxStyle.Information, "Verify")
            txtNewPass.Enabled = True
            txtRepass.Enabled = True
            changePassBtn.Enabled = True
        Else
            MsgBox("Wrong password , try again", MsgBoxStyle.Critical, "Error")
            txtoldpass.Text = ""
        End If
    End Sub

    Private Sub changePassBtn_Click(sender As Object, e As EventArgs) Handles changePassBtn.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        If txtNewPass.Text = txtRepass.Text Then
            Try

                sqlconnection.Open()
                Dim query As String
                Dim datareader As MySqlDataReader
                query = "update librarydb.userdetails set password='" & txtRepass.Text & "'where username='" & txtusern.Text & "'"
                command = New MySqlCommand(query, sqlconnection)
                datareader = command.ExecuteReader
                MsgBox("Password Changed ", MsgBoxStyle.Information, "Password")
                txtNewPass.Text = ""
                txtRepass.Text = ""
                pnlPassword.Visible = False
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Passwords Are not matching", MsgBoxStyle.Critical, "Error")

        End If
    End Sub

    Private Sub pnlClose_Click(sender As Object, e As EventArgs) Handles pnlClose.Click
        pnlPassword.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        pnlDelete.Visible = False
    End Sub

    Private Sub Manage_admins_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class