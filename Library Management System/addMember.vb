Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class addMember
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand

    Private Sub cmbMember_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMember.SelectedIndexChanged
        If cmbMember.Text = "Student" Then
            lbladm.Visible = True
            lblcourse.Visible = True
            cmbCourse.Visible = True
            txtAdmyear.Visible = True

            rolllbl.Text = "Roll Number"
        ElseIf cmbmember.Text = "Faculty" Then
            lbladm.Visible = False
            lblcourse.Visible = False
            cmbCourse.Visible = False
            txtAdmyear.Visible = False
            rolllbl.Text = "Designation"

        End If
    End Sub


    Private Sub student()
        If txtName.Text = "" Or txtaddress.Text = "" Or txtEmail.Text = "" Or txtmemid.Text = "" Or txtPassword.Text = "" Or txtPhone.Text = "" Or txtRollno.Text = " " Then
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
                    Try
                        sqlconnection = New MySqlConnection("Server=localhost;user=root;password=punith123;database=librarydb")
                        Dim query As String
                        query = "insert into librarydb.memberdetails (member_id,name,address,phonenumber,email,course,dob,rollno,admissionyear,photo,password) values (@member_id,@name,@address,@phonenumber,@email,@course,@dob,@rollno,@admissionyear,@photo,@password)"
                        Dim ms As New MemoryStream
                        picPhoto.Image.Save(ms, picPhoto.Image.RawFormat)
                        sqlconnection.Open()
                        command = New MySqlCommand(query, sqlconnection)
                        command.Parameters.AddWithValue("@member_id", txtmemid.Text)
                        command.Parameters.AddWithValue("@Name", txtName.Text)
                        command.Parameters.AddWithValue("@Address", txtaddress.Text)
                        command.Parameters.AddWithValue("@Phonenumber", txtPhone.Text)
                        command.Parameters.AddWithValue("@email", txtEmail.Text)
                        command.Parameters.AddWithValue("@course", cmbCourse.Text)
                        command.Parameters.AddWithValue("@dob", datedob.Text)
                        command.Parameters.AddWithValue("@Rollno", txtRollno.Text)
                        command.Parameters.AddWithValue("@admissionyear", txtAdmyear.Text)
                        command.Parameters.AddWithValue("@Photo", ms.ToArray())
                        command.Parameters.AddWithValue("@password", txtPassword.Text)
                        command.ExecuteNonQuery()
                        sqlconnection.Close()
                        MsgBox("Student details stored succesfully", MsgBoxStyle.Information, "Add Member")

                    Catch ex As MySqlException
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub faculty()
        If txtName.Text = "" Or txtaddress.Text = "" Or txtEmail.Text = "" Or txtmemid.Text = "" Or txtPassword.Text = "" Or txtPhone.Text = "" Or txtRollno.Text = " " Then
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
                    Try
                        sqlconnection = New MySqlConnection("Server=localhost;user=root;password=punith123;database=librarydb")
                        Dim query As String
                        query = "insert into librarydb.faculty_details (member_id,name,address,phone_number,email,dob,photo,designation,password) values (@member_id,@name,@address,@phone_number,@email,@dob,@photo,@designation,@password)"
                        Dim ms As New MemoryStream
                        picPhoto.Image.Save(ms, picPhoto.Image.RawFormat)
                        sqlconnection.Open()
                        command = New MySqlCommand(query, sqlconnection)
                        command.Parameters.AddWithValue("@member_id", txtmemid.Text)
                        command.Parameters.AddWithValue("@Name", txtName.Text)
                        command.Parameters.AddWithValue("@Address", txtaddress.Text)
                        command.Parameters.AddWithValue("@Phone_number", txtPhone.Text)
                        command.Parameters.AddWithValue("@email", txtEmail.Text)
                        command.Parameters.AddWithValue("@dob", datedob.Text)
                        command.Parameters.AddWithValue("@designation", txtRollno.Text)
                        command.Parameters.AddWithValue("@Photo", ms.ToArray())
                        command.Parameters.AddWithValue("@password", txtPassword.Text)

                        command.ExecuteNonQuery()
                        sqlconnection.Close()
                        MsgBox("Faculty details stored succesfully", MsgBoxStyle.Information, "Add Member")

                    Catch ex As MySqlException
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "image file (*.jpg;*.bmp;*.gif;*.jpeg)|*.jpg;*.bmp;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            picPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub addMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboloader()
    End Sub

    Private Sub comboloader()
        Try
            sqlconnection = New MySqlConnection("Server=localhost;user=root;password=punith123;database=librarydb")
            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            query = "select * from librarydb.course_list  "
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            While datareader.Read
                Dim course = datareader.GetString("course")
                cmbCourse.Items.Add(course)
            End While
            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If cmbMember.Text = "Student" Then
            student()
        Else
            faculty()
        End If
    End Sub

    Private Sub addMember_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ASDFGHJKLZXCVBNMQWERTYUIOPqwertyuiopasdfghjklzxcvbnm"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
        If txtPhone.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtmemid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmemid.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class