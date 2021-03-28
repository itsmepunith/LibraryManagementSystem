Public Class Main_Form
    Private Sub BtnCategories_Click(sender As Object, e As EventArgs) Handles BtnCategories.Click
        Me.Hide()
        book_categories.Show()
    End Sub

    Private Sub BtnCourse_Click(sender As Object, e As EventArgs) Handles BtnCourse.Click
        Me.Hide()
        Course.Show()
    End Sub

    Private Sub BtnAdmins_Click(sender As Object, e As EventArgs) Handles BtnAdmins.Click
        Me.Hide()
        Manage_admins.Show()
    End Sub



    Private Sub LibraryBtn_Click(sender As Object, e As EventArgs) Handles LibraryBtn.Click
        Me.Hide()
        Library_info.Show()
    End Sub

    Private Sub issueBtn_Click(sender As Object, e As EventArgs) Handles issueBtn.Click
        Me.Hide()
        issue_books.Show()
    End Sub

    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Me.Hide()
        Return_Books.Show()
    End Sub

    Private Sub ManageBtn_Click(sender As Object, e As EventArgs) Handles ManageBtn.Click
        Me.Hide()
        AddBooks.Show()
    End Sub

    Private Sub ManageMembersBtn_Click(sender As Object, e As EventArgs) Handles ManageMembersBtn.Click
        Me.Hide()
        Manage_Members.Show()
    End Sub

    Private Sub ExtendBtn_Click(sender As Object, e As EventArgs) Handles ExtendBtn.Click
        Me.Hide()
        extendDueDate.Show()
    End Sub

    Private Sub IssuedBtn_Click(sender As Object, e As EventArgs) Handles IssuedBtn.Click
        Me.Hide()
        Issued_book_details.Show()
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Me.Hide()
        About.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BookAvailabilityBtn_Click(sender As Object, e As EventArgs) Handles BookAvailabilityBtn.Click
        Me.Hide()
        Book_availability.Show()
    End Sub

    Private Sub Main_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub
End Class