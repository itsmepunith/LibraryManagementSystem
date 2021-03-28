Imports MySql.Data.MySqlClient

Public Class Manage_Members
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Me.Hide()
        addMember.Show()
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        Me.Hide()
        EditMemberDetails.Show()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
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
            Query = "select name,rollno,address,phonenumber,course,admissionyear from librarydb.memberdetails  where rollno='" & txtrollno.Text & "' "
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

    Private Sub viewAllBtn_Click(sender As Object, e As EventArgs) Handles viewAllBtn.Click
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
            Query = "select name,rollno,address,phonenumber,course,admissionyear from librarydb.memberdetails   "

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

    Private Sub Manage_Members_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class