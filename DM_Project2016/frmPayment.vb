Public Class frmPayment

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Error Handleing
        If mtbCardHoldersName.Text = "" Then
            MessageBox.Show("Please enter a value for the Cardholders Name: ", "Blank Space Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            mtbCardHoldersName.Focus()
            ErrorCount()
        ElseIf mtbCardNumber.Text.Length <> 8 Then
            MessageBox.Show("Incorrect input for Creditcard number:", "Incorrect Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            mtbCardNumber.Focus()
            ErrorCount()
        ElseIf mtbSecurityCode.Text.Length <> 3 Then
            MessageBox.Show("Incorrect input for Security Code:", " Incorrect Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()

        ElseIf mtbExpiryDate.Text = "  /  " Then
            MessageBox.Show("Please enter a value for Expiry Date of Creditcard", " Blank Space Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            mtbExpiryDate.Focus()
            ErrorCount()
        Else
            Me.Hide()
            frmInvoice.Show()

        End If
    End Sub
    'THese Subs Will auto-Select The first space in the text boxes
    Private Sub mtbCardHoldersName_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbCardHoldersName.Click
        If mtbCardHoldersName.Text = "" Then
            mtbCardHoldersName.Select(0, 0)
        End If

    End Sub

    Private Sub mtbCardNumber_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbCardNumber.Click
        If mtbCardNumber.Text = "" Then
            mtbCardNumber.Select(0, 0)
        End If

    End Sub

    Private Sub mtbSecurityCode_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbSecurityCode.Click
        If mtbSecurityCode.Text = "" Then
            mtbSecurityCode.Select(0, 0)
        End If

    End Sub

    Private Sub mtbExpiryDate_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbExpiryDate.Click
        If mtbExpiryDate.Text = "" Then
            mtbExpiryDate.Select(0, 0)
        End If

    End Sub
End Class