Imports MySql.Data.MySqlClient

Public Class Book_availability
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Private Sub Book_availability_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "select * from librarydb.book_details where book_id='" & txtBid.Text & "'"
            Dim datareader As MySqlDataReader
            Dim count As Integer = 0
            Command = New MySqlCommand(query, sqlconnection)
            datareader = Command.ExecuteReader
            While datareader.Read
                count = count + 1
            End While
            If count = 1 Then
                txtPieces.Text = datareader.GetString("copies")
                txtAvail.Text = datareader.GetString("available")
            Else
                MsgBox("Book data not found", MsgBoxStyle.Critical, "Error")
                sqlconnection.Close()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub setAvailable_Click(sender As Object, e As EventArgs) Handles setAvailable.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=manoj123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            Dim available As String = "Yes"
            query = "update librarydb.book_details set available='" & available & "'where book_id='" & txtBid.Text & "'"
            Dim datareader As MySqlDataReader
            Dim count As Integer = 0
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            MsgBox("Set availability to :-Yes , successfully")
            txtBid.Text = ""
            txtpieces.Text = ""
            txtavail.Text = ""
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub setUnavailable_Click(sender As Object, e As EventArgs) Handles setUnavailable.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=manoj123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            Dim available As String = "No"
            query = "update librarydb.book_details set available='" & available & "'where book_id='" & txtBid.Text & "'"
            Dim datareader As MySqlDataReader
            Dim count As Integer = 0
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            MsgBox("Set availability to :-No , successfully")
            txtBid.Text = ""
            txtpieces.Text = ""
            txtavail.Text = ""
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Book_availability_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class