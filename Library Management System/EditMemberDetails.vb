Imports MySql.Data.MySqlClient
Imports System.IO
Public Class EditMemberDetails
    Dim sqlconnection As New MySqlConnection
    Dim command As New MySqlCommand
    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        If cmbType.Text = "Student" Then
            search_student()
        ElseIf cmbType.Text = "Faculty" Then
            search_faculty()
        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.Text = "Student" Then
            lbladm.Visible = True
            lblcourse.Visible = True
            cmbCourse.Visible = True
            txtAdmyear.Visible = True
            rollLbl.Text = "Roll Number"
        ElseIf cmbtype.Text = "Faculty" Then
            lbladm.Visible = False
            lblcourse.Visible = False
            cmbCourse.Visible = False
            txtAdmyear.Visible = False
            rolllbl.Text = "Designation"
        End If
    End Sub

    Private Sub search_student()
        Dim datareader As MySqlDataReader
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "select * from librarydb.memberdetails where member_id='" & txtmemid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While datareader.Read
                count = count + 1
            End While

            If count = 1 Then
                txtmemid.Text = datareader.GetString("member_id")
                txtName.Text = datareader.GetString("name")
                dateDob.Text = datareader.GetString("dob")
                txtAddress.Text = datareader.GetString("address")
                txtEmail.Text = datareader.GetString("email")
                txtPhone.Text = datareader.GetString("phonenumber")
                cmbCourse.Text = datareader.GetString("course")
                txtadmyear.Text = datareader.GetString("admissionyear")
                txtRollno.Text = datareader.GetString("rollno")
                loadimg_student()
            Else
                MsgBox("Member not found")
            End If

            sqlconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub search_faculty()
        Dim datareader As MySqlDataReader
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim query As String
            query = "select * from librarydb.faculty_details where member_id='" & txtmemid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While datareader.Read
                count = count + 1
            End While

            If count = 1 Then
                txtmemid.Text = datareader.GetString("member_id")
                txtname.Text = datareader.GetString("name")
                dateDob.Text = datareader.GetString("dob")
                txtAddress.Text = datareader.GetString("address")
                txtEmail.Text = datareader.GetString("email")
                txtPhone.Text = datareader.GetString("phone_number")
                txtRollno.Text = datareader.GetString("designation")
                loadimg_faculty()
            Else
                MsgBox("Member not found")
            End If

            sqlconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub loadimg_student()
        Dim myconn As New MySqlConnection
        Dim commandsql As New MySqlCommand
        myconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=librarydb")
        Dim query As String = "select * from librarydb.memberdetails where member_id=@member_id"
        myconn.Open()
        commandsql = New MySqlCommand(query, myconn)
        commandsql.Parameters.AddWithValue("@member_id", txtmemid.Text)
        Dim da As New MySqlDataAdapter(commandsql)
        Dim dt As New DataTable
        da.Fill(dt)
        txtmemid.Text = dt.Rows(0)("member_id").ToString
        Dim img() As Byte
        img = dt.Rows(0)("Photo")
        Dim ms As New MemoryStream(img)
        picPhoto.Image = Image.FromStream(ms)
        myconn.Close()
    End Sub

    Public Sub loadimg_faculty()
        Dim myconn As New MySqlConnection
        Dim commandsql As New MySqlCommand
        myconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=librarydb")
        Dim query As String = "select * from librarydb.Faculty_details where member_id=@member_id"
        myconn.Open()
        commandsql = New MySqlCommand(query, myconn)
        commandsql.Parameters.AddWithValue("@member_id", txtmemid.Text)
        Dim da As New MySqlDataAdapter(commandsql)
        Dim dt As New DataTable
        da.Fill(dt)
        txtmemid.Text = dt.Rows(0)("member_id").ToString
        Dim img() As Byte
        img = dt.Rows(0)("Photo")
        Dim ms As New MemoryStream(img)
        picPhoto.Image = Image.FromStream(ms)
        myconn.Close()
    End Sub

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "image file (*.jpg;*.bmp;*.gif;*.jpeg)|*.jpg;*.bmp;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            picPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        sqlconnection = New MySqlConnection
        sqlconnection.ConnectionString = "server=localhost;user=root;password=manoj123;database=librarydb"
        Try
            sqlconnection.Open()
            Dim datareader As MySqlDataReader
            Dim query As String
            query = "delete from librarydb.memberdetails where member_id='" & txtmemid.Text & "'"
            command = New MySqlCommand(query, sqlconnection)
            datareader = command.ExecuteReader
            MsgBox("Member details deleted", MsgBoxStyle.Information, "Delete")
            txtmemid.Text = ""
            txtname.Text = ""
            txtAddress.Text = ""
            txtEmail.Text = ""
            txtPhone.Text = ""
            txtRollno.Text = ""
            picPhoto.Image = Nothing
            cmbCourse.Text = ""
            txtadmyear.Text = ""
            dateDob.Text = ""

            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If cmbType.Text = "Student" Then
            student_updater()
        ElseIf cmbType.Text = "Faculty" Then
            faculty_updater()
        End If
    End Sub

    Private Sub EditMemberDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboloader()
    End Sub

    Private Sub comboloader()
        Try
            sqlconnection = New MySqlConnection("Server=localhost;user=root;password=punith123;database=librarydb")
            sqlconnection.Open()
            Dim query As String
            Dim datareader As MySqlDataReader
            query = "select * from librarydb.course_list "
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

    Private Sub student_updater()
        Try

            sqlconnection = New MySqlConnection
            sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
            Dim query As String
            query = "update librarydb.memberdetails set name=@name,dob=@dob,address=@address,email=@email,phonenumber=@phonenumber,course=@course,admissionyear=@admissionyear,rollno=@rollno,photo=@photo where member_id='" & txtmemid.Text & "'"
            Dim ms As New MemoryStream
            picPhoto.Image.Save(ms, picPhoto.Image.RawFormat)
            sqlconnection.Open()
            command = New MySqlCommand(query, sqlconnection)
            command.Parameters.AddWithValue("@Name", txtname.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)
            command.Parameters.AddWithValue("@Phonenumber", txtPhone.Text)
            command.Parameters.AddWithValue("@email", txtEmail.Text)
            command.Parameters.AddWithValue("@course", cmbCourse.Text)
            command.Parameters.AddWithValue("@dob", dateDob.Text)
            command.Parameters.AddWithValue("@Rollno", txtRollno.Text)
            command.Parameters.AddWithValue("@admissionyear", txtadmyear.Text)
            command.Parameters.AddWithValue("@Photo", ms.ToArray())
            command.ExecuteNonQuery()
            sqlconnection.Close()
            MsgBox("Member Account has been Updated sucessfully")

            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub faculty_updater()
        Try

            sqlconnection = New MySqlConnection
            sqlconnection.ConnectionString = "server=localhost;user=root;password=punith123;database=librarydb"
            Dim query As String
            query = "update librarydb.faculty_details set name=@name,dob=@dob,address=@address,email=@email,phone_number=@phone_number,designation=@designation,photo=@photo where member_id='" & txtmemid.Text & "'"
            Dim ms As New MemoryStream
            picPhoto.Image.Save(ms, picPhoto.Image.RawFormat)
            sqlconnection.Open()
            command = New MySqlCommand(query, sqlconnection)
            command.Parameters.AddWithValue("@Name", txtname.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)
            command.Parameters.AddWithValue("@Phone_number", txtPhone.Text)
            command.Parameters.AddWithValue("@email", txtEmail.Text)
            command.Parameters.AddWithValue("@dob", dateDob.Text)
            command.Parameters.AddWithValue("@designation", txtRollno.Text)
            command.Parameters.AddWithValue("@Photo", ms.ToArray())
            command.ExecuteNonQuery()
            sqlconnection.Close()
            MsgBox("Faculty Account has been Updated sucessfully")

            sqlconnection.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub EditMemberDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Form.Show()
    End Sub
End Class