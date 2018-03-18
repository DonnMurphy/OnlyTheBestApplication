Public Class frmCustomerInfo
    Private Sub mtbGuest1Name_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest1Name.MouseClick
        If mtbGuest1Name.Text = "" Then
            mtbGuest1Name.Select(0, 0)
        End If
    End Sub
    Private Sub mtbGuest1Age_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest1Age.MouseClick
        If mtbGuest1Age.Text = "" Then
            mtbGuest1Age.Select(0, 0)
        End If
    End Sub
    Private Sub mtbGuest1PassportNumber_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest1PassportNumber.MouseClick
        If mtbGuest1PassportNumber.Text = "" Then
            mtbGuest1PassportNumber.Select(0, 0)
        End If
    End Sub

    Private Sub txtStreetAddress_MouseClick(sender As Object, e As MouseEventArgs)
        If txtStreetAddress.Text = "" Then
            txtStreetAddress.Select(0, 0)
        End If
    End Sub
    Private Sub mtbCity_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbCity.MouseClick
        If mtbCity.Text = "" Then
            mtbCity.Select(0, 0)
        End If
    End Sub
    Private Sub mtbTelephoneNumber_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbTelephoneNumber.MouseClick

        mtbTelephoneNumber.Select(0, 0)

    End Sub

    Private Sub bnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'Error Handeling Checks

        'Guest Name
        If mtbGuest1Name.Text = "" Then

            MessageBox.Show("Please enter a value for the Customers Name:  ", "Blank  Space Error",
                             MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbGuest1Age.Focus()
            'Guest Age
        ElseIf mtbGuest1Age.Text = "" Then

            MessageBox.Show("Please enter a value for the age of the Customer:  ", "Blank  Space Error",
                             MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            mtbGuest1Age.Focus()
            ErrorCount()
            ' Guest 1 Passport Number
        ElseIf mtbGuest1PassportNumber.Text.Length <> 8 Then

            MessageBox.Show("Incorrect Passport Number:" & vbNewLine & "Passport Number Format = LL000000", "Blank  Space Error",
                             MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            mtbGuest1PassportNumber.Focus()
            ErrorCount()
            ' cmbOtherGuests
        ElseIf cmbOtherGuests.Text = "" Then

            MessageBox.Show("Please enter a value for any other guests staying with the customer:  ", "Blank  Space Error",
                             MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            cmbOtherGuests.Focus()
            ' Street Address
        ElseIf txtStreetAddress.Text = "" Then
            MessageBox.Show("Please enter a value for the Customers Address:  ", "Blank  Space Error",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            txtStreetAddress.Focus()
        ElseIf mtbCity.Text = "" Then
            MessageBox.Show("Please enter a value for the Customers City Of Residence:  ", "Blank  Space Error",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbCity.Focus()
        ElseIf cmbCounty.Text = "" Then
            MessageBox.Show("Please enter a value for the Customers County Of Residence:  ", "Blank  Space Error",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            cmbOtherGuests.Focus()
        ElseIf mtbTelephoneNumber.Text = "" Then
            MessageBox.Show("Please enter a value for the Customers Contact Number:  ", "Blank  Space Error",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbTelephoneNumber.Focus()
        Else
            If cmbOtherGuests.Text = 0 Then
                Me.Hide()
                frmExtras.Show()

            Else
                Me.Visible = False
                frmExtraGuests.Show()
            End If
        End If


    End Sub



    Private Sub frmCustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TransactionTimerGO()

    End Sub
End Class