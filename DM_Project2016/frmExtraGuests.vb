Public Class frmExtraGuests

    Private Sub frmExtraGuests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dblExtraGuestsNumber As Double = CDbl(frmCustomerInfo.cmbOtherGuests.Text)

            If dblExtraGuestsNumber = 1 Then
                grpGuest2Details.Visible = True
            ElseIf dblExtraGuestsNumber = 2 Then
                grpGuest2Details.Visible = True
                grpGuest3Details.Visible = True
            ElseIf dblExtraGuestsNumber = 3 Then
                grpGuest2Details.Visible = True
                grpGuest3Details.Visible = True
                grpGuest4Details.Visible = True
            Else
                Me.Visible = False
                frmRoomChoice.Show()

            End If
        Catch
            MessageBox.Show("Please Enter A Value:")
            frmCustomerInfo.Show()
            frmCustomerInfo.cmbOtherGuests.Focus()
            Me.Hide()

        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Error handling 
        'guest 2 Details
        If grpGuest2Details.Visible = True And mtbGuest2Name.Text = "" Then
            MessageBox.Show("Please enter a value for Guest 2's Name:  ", "Blank  Space Error",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbGuest2Name.Focus()
        ElseIf grpGuest2Details.Visible = True And mtbGuest2Age.Text = "" Then
            MessageBox.Show("Please enter a value for Guest 2's Age:  ", "Blank  Space Error",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbGuest2Age.Focus()
        ElseIf grpGuest2Details.Visible = True And mtbGuest2PassportNo.Text.Length <> 8 Then
            MessageBox.Show("Invalid Entry: Please enter correct information for Guest 2's Passport Details " & vbNewLine &
                            "Correct Format: LL000000", "Blank  Space Error",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbGuest2PassportNo.Focus()

            'Guest 3 Details
        ElseIf grpGuest3Details.Visible = True And mtbGuest3Name.Text = "" Then
            MessageBox.Show("Please enter a value for Guest 3's Name:  ", "Blank  Space Error",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbGuest3Name.Focus()
        ElseIf grpGuest3Details.Visible = True And mtbGuest3Age.Text = "" Then
            MessageBox.Show("Please enter a value for Guest 3's Age:  ", "Blank  Space Error",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbGuest3Age.Focus()
        ElseIf grpGuest3Details.Visible = True And mtbGuest3PassportNo.Text = "" Then
            MessageBox.Show("Invalid Entry: Please enter correct information for Guest 3's Passport Details " & vbNewLine &
                            "Correct Format: LL000000", "Blank  Space Error",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbGuest3PassportNo.Focus()
            'Guest 4 Details
        ElseIf grpGuest4Details.Visible = True And mtbGuest4Name.Text = "" Then
            MessageBox.Show("Please enter a value for Guest 4's Name:  ", "Blank  Space Error",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbGuest4Name.Focus()
        ElseIf grpGuest4Details.Visible = True And mtbGuest4Age.Text = "" Then
            MessageBox.Show("Please enter a value for Guest 4's Age:  ", "Blank  Space Error",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbGuest4Age.Focus()
        ElseIf grpGuest4Details.Visible = True And mtbGuest4PassportNo.Text = "" Then
            MessageBox.Show("Invalid Entry: Please enter correct information for Guest 2's Passport Details " & vbNewLine &
                            "Correct Format: LL000000", "Blank  Space Error",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            mtbGuest4PassportNo.Focus()
        Else
            Me.Visible = False
            frmRoomChoice.Show()
        End If


    End Sub
    'These Sub- Procedures Set the curser at the beginning of each textbox whrn clicked on

    Private Sub mtbGuest2Name_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest2Name.MouseClick
        If mtbGuest2Name.Text = "" Then
            mtbGuest2Name.Select(0, 0)
        End If

    End Sub

    Private Sub mtbGuest2PassportNo_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest2PassportNo.MouseClick
        If mtbGuest2PassportNo.Text = "" Then
            mtbGuest2PassportNo.Select(0, 0)
        End If
    End Sub


    Private Sub mtbGuest2Age_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest2Age.MouseClick
        If mtbGuest2Age.Text = "" Then
            mtbGuest2Age.Select(0, 0)
        End If

    End Sub
    Private Sub mtbGuest3Name_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest3Name.MouseClick
        If mtbGuest3Name.Text = "" Then
            mtbGuest3Name.Select(0, 0)
        End If
    End Sub

    Private Sub mtbGuest3PassportNo_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest3PassportNo.MouseClick
        If mtbGuest3PassportNo.Text = "" Then
            mtbGuest3PassportNo.Select(0, 0)
        End If
    End Sub


    Private Sub mtbGuest3Age_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest3Age.MouseClick
        If mtbGuest3Age.Text = "" Then
            mtbGuest3Age.Select(0, 0)
        End If

    End Sub
    Private Sub mtbGuest4Name_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest4Name.MouseClick
        If mtbGuest4Name.Text = "" Then
            mtbGuest4Name.Select(0, 0)
        End If

    End Sub

    Private Sub mtbGuest4PassportNo_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest4PassportNo.MouseClick
        If mtbGuest4PassportNo.Text = "" Then
            mtbGuest4PassportNo.Select(0, 0)
        End If
    End Sub


    Private Sub mtbGuest4Age_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbGuest4Age.MouseClick
        If mtbGuest4Age.Text = "" Then
            mtbGuest4Age.Select(0, 0)
        End If
    End Sub
End Class