Imports MySql.Data.MySqlClient
Public Class book_categories
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Private Sub book_categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlEdit.Visible = False
        pnlAdd.Visible = False

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
            Query = "select category,shelf from librarydb.categories "
            Command = New MySqlCommand(Query, sqlconnection)
            SDA.SelectCommand = command
            SDA.Fill(dbd)
            bSource.DataSource = dbd
            datagridCateg.DataSource = bSource
            SDA.Update(dbd)


            sqlconnection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconnection.Dispose()
        End Try
    End Sub


    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        pnlEdit.Visible = False
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        pnlAdd.Visible = True
        pnlEdit.Visible = False
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        btnEditCat.Visible = True
        btnDeleteCat.Visible = False
        pnlEdit.Visible = True
        pnlAdd.Visible = False
        txtaddshelf.Visible = True
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        pnlEdit.Visible = True
        btnDeleteCat.Visible = True
        btnEditCat.Visible = False
        txtAddShelf.Visible = False
        Label2.Visible = False
        Label5.Visible = True
        txtaddcateg.Visible = True
    End Sub

    Private Sub BtnaddCat_Click(sender As Object, e As EventArgs) Handles BtnaddCat.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim datareader As MySqlDataReader
            Dim query As String
            query = "insert into librarydb.categories (shelf,category) values ('" & txtshelfadd.Text & "','" & txtCatadd.Text & "')"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader

            MsgBox("New Category Addded", MsgBoxStyle.Information, "Add Category")
            loaddvg()
            txtCatadd.Text = ""
            txtshelfadd.Text = ""
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
            Query = "select category,shelf from librarydb.categories "

            command = New MySqlCommand(Query, sqlconnection)
            SDA.SelectCommand = command
            SDA.Fill(dbd)
            bSource.DataSource = dbd
            datagridCateg.DataSource = bSource
            SDA.Update(dbd)


            sqlconnection.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconnection.Dispose()
        End Try
    End Sub

    Private Sub btnEditCat_Click(sender As Object, e As EventArgs) Handles btnEditCat.Click
        Try
            Dim sqlconnect As New MySqlConnection
            sqlconnect = New MySqlConnection
            sqlconnect.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
            sqlconnect.Open()

            Dim query As String
            Dim cmd As New MySqlCommand
            Dim dreader As MySqlDataReader
            query = "select * from librarydb.categories where category='" & txtAddCateg.Text & "'"
            cmd = New MySqlCommand(query, sqlconnect)
            dreader = cmd.ExecuteReader
            Dim count As Integer
            count = 0
            While dreader.Read
                count = count + 1
            End While
            If count = 1 Then
                updater()
            Else
                MsgBox("Category doesnt exists", MsgBoxStyle.Critical, "Error")
            End If
            sqlconnect.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub updater()
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim datareader As MySqlDataReader
            Dim query As String

            query = "update librarydb.categories set  shelf='" & txtaddshelf.Text & "' where category='" & txtaddcateg.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            MsgBox("Category Updated", MsgBoxStyle.Information, "Updated")
            loaddvg()
            txtaddcateg.Text = ""
            txtaddshelf.Text = ""
            sqlconnection.Close()


        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnDeleteCat_Click(sender As Object, e As EventArgs) Handles btnDeleteCat.Click
        Try
            Dim sqlconnect As New MySqlConnection
            sqlconnect = New MySqlConnection
            sqlconnect.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
            sqlconnect.Open()

            Dim query As String
            Dim cmd As New MySqlCommand
            Dim dreader As MySqlDataReader
            query = "delete  from librarydb.categories where category='" & txtaddcateg.Text & "'"
            cmd = New MySqlCommand(query, sqlconnect)
            dreader = cmd.ExecuteReader
            MsgBox("Category Deleted", MsgBoxStyle.Information, "Delete")
            loaddvg()
            sqlconnect.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pnlcloseAdd_Click(sender As Object, e As EventArgs) Handles pnlcloseAdd.Click
        pnlAdd.Visible = False
    End Sub

    Private Sub book_categories_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class