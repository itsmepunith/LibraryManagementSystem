Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions



Public Class addAdmin
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Dim user As String = "User"
        Try
            sqlconnection.Open()
            Dim datareader As MySqlDataReader
            Dim query As String
            If txtusrname.Text = "" Or txtphone.Text = "" Or txtpass.Text = "" Or txtemail.Text = "" Or txtname.Text = "" Or txtaddr.Text = "" Then
                MsgBox("Few fields are empty", MsgBoxStyle.Critical, "Error")

            Else
                Dim regex As Regex = New Regex("([A-Z]){0}([0-9]){10}([A-Z]){0}$")
                If Not regex.IsMatch(txtphone.Text.Trim()) Then
                    MsgBox("Incorrect Phone number format", MsgBoxStyle.Information, "Phone number error")
                Else
                    Dim p As Regex = New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{3})$")
                    If Not p.IsMatch(txtemail.Text.Trim()) Then
                        MsgBox("Incorrect Email address")

                    Else
                        query = "insert into librarydb.userdetails (username,password,name,address,phonenumber,email,type) values ('" & txtusrname.Text & "','" & txtpass.Text & "','" & txtname.Text & "','" & txtaddr.Text & "','" & txtphone.Text & "','" & txtemail.Text & "', '" & user & "')"
                        command = New MySqlCommand(query, sqlconnection)
                        datareader = command.ExecuteReader
                        MsgBox("User data inserted", MsgBoxStyle.Information, "Insert")
                        sqlconnection.Close()
                    End If
                End If
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtaddr.Text = ""
        txtemail.Text = ""
        txtname.Text = ""
        txtpass.Text = ""
        txtphone.Text = ""
        txtusrname.Text = ""

    End Sub

    Private Sub addAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Manage_admins.Show()
    End Sub

    Private Sub txtphone_TextChanged(sender As Object, e As EventArgs) Handles txtphone.TextChanged

    End Sub

    Private Sub txtphone_KeyUp(sender As Object, e As KeyEventArgs) Handles txtphone.KeyUp

    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
        If txtphone.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtusrname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusrname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ASDFGHJKLZXCVBNMQWERTYUIOPqwertyuiopasdfghjklzxcvbnm"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ASDFGHJKLZXCVBNMQWERTYUIOPqwertyuiopasdfghjklzxcvbnm"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtaddr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtaddr.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ASDFGHJKLZXCVBNMQWERTYUIOPqwertyuiopasdfghjklzxcvbnm"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub
End Class


