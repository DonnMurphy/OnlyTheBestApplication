Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text.ToUpper = "YVONNE OCONNOR" And mtbPassword.Text.ToUpper = "TEABOXES" Then

            'This code will run if login is successful
            'it will make current controls invisible while displaying a welcome message

            frmWelcome.Show()
            Me.Hide()

        ElseIf txtUsername.Text.ToUpper = "YVONNE OCONNOR" And mtbPassword.Text.ToUpper <> "TEABOXES" Then

            'This code runs if the username is correct but the password isnt.
            'it will display a label beside mtbpassword
            lblIncorrectPassword.Show()
            mtbPassword.Focus()
        ElseIf txtUsername.Text.ToUpper <> "YVONNE OCONNOR" And mtbPassword.Text.ToUpper = "TEABOXES" Then
            'This code runs if password is correct but username is not.
            'it will draw focus on txtusername and display the warning label 
            '{note: add instance for error counter}
            lblUsernameError.Show()
            txtUsername.Focus()
        Else
            lblUsernameError.Show()
            lblIncorrectPassword.Show()
            txtUsername.Focus()

        End If

        If txtUsername.Text.ToUpper = "SELF DESTRUCT" And mtbPassword.Text.ToUpper = "WHATTHEFIDDLESTHICKS" Then
            frmSelfDestruct.Show()
            Me.Hide()

        End If
    End Sub



End Class
