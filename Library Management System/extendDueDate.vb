Imports MySql.Data.MySqlClient
Public Class extendDueDate
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Dim d As String

    Private Sub extendDueDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dayscmb.Enabled = False
        dtpDue.Enabled = False
        extendBtn.Enabled = False
        dtpDue.Format = DateTimePickerFormat.Custom
        dtpDue.CustomFormat = "dd-MM-yyyy"

    End Sub

    Private Sub dayscmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dayscmb.SelectedIndexChanged
        dtpDue.ResetText()
        dtpDue.Value = DateTime.Parse(d).AddDays(dayscmb.Text)
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim datareader As MySqlDataReader
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "SELECT * FROM librarydb.issue_details where ( Book_id='" & txtbid.Text & "' and  member_id=" & txtmemid.Text & " ) and return_status='No' "
            command = New MySqlCommand(query, sqlconnection)
            Dim count As Integer
            datareader = command.ExecuteReader
            While datareader.Read
                count = count + 1
            End While
            If count = 1 Then
                dtpDue.Value = datareader.GetString("due_date")

                dayscmb.Enabled = True
                d = dtpDue.Text.ToString
                extendBtn.Enabled = True
                txtbid.Enabled = False
                txtmemid.Enabled = False

            Else
                MsgBox("Entered data doesnt exists ", MsgBoxStyle.Critical, "Error")
                txtbid.Text = ""
                txtmemid.Text = ""
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub extendBtn_Click(sender As Object, e As EventArgs) Handles extendBtn.Click
        saver()
    End Sub

    Private Sub saver()
        Dim datareader As MySqlDataReader
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            query = " update librarydb.issue_details set due_date='" & dtpDue.Value & "' where book_id ='" & txtbid.Text & "' and member_id='" & txtmemid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            MsgBox("Duedate updated", MsgBoxStyle.Information, "Update")
            Me.Close()
            Main_Form.Show()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub extendDueDate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class