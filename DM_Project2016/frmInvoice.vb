Imports System.Drawing.Printing
Public Class frmInvoice

    'Declarations 
    Dim strCustomerName As String = frmCustomerInfo.mtbGuest1Name.Text
    Dim strCustomerAge As String = frmCustomerInfo.mtbGuest1Age.Text
    Dim strCustomerPassportDetails As String = frmCustomerInfo.mtbGuest1PassportNumber.Text
    Dim strCustomerContactNumber As String = frmCustomerInfo.mtbTelephoneNumber.Text
    Dim dblExtraGuestsNumber As Double = frmCustomerInfo.cmbOtherGuests.Text
    Dim strGuest2Name As String = frmExtraGuests.mtbGuest2Name.Text
    Dim strGuest2Age As String = frmExtraGuests.mtbGuest2Age.Text
    Dim strGuest2PassportDetails As String = frmExtraGuests.mtbGuest2PassportNo.Text
    Dim strGuest3Name As String = frmExtraGuests.mtbGuest3Name.Text
    Dim strGuest3Age As String = frmExtraGuests.mtbGuest3Age.Text
    Dim strGuest3PassportDetails As String = frmExtraGuests.mtbGuest3PassportNo.Text
    Dim strGuest4Name As String = frmExtraGuests.mtbGuest4Name.Text
    Dim strGuest4Age As String = frmExtraGuests.mtbGuest4Age.Text
    Dim strGuest4PassportDetails As String = frmExtraGuests.mtbGuest4PassportNo.Text
    Dim strCreditCardNumber As String = frmPayment.mtbCardNumber.Text
    Dim strCardHoldersName As String = frmPayment.mtbCardHoldersName.Text
    Dim strCardSecurityCode As String = frmPayment.mtbSecurityCode.Text
    Dim strExpiryDate As String = frmPayment.mtbExpiryDate.Text
    Dim strCheckInDate As String = CStr(frmRoomChoice.dtpCheckIn.Value)
    Dim strcheckOutDate As String = CStr(frmRoomChoice.dtpCheckOut.Value)
    Dim blnPrintCheck As Boolean

    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Statement To determine the Number of Other guests details:

        'Adding Items to The Listbox
        'Customer Details
        lstInvoice.Items.Add("Customer Details:")
        lstInvoice.Items.Add("****************")
        lstInvoice.Items.Add("Customer Name: " & strCustomerName)
        lstInvoice.Items.Add("Customer Age:" & strCustomerAge)
        lstInvoice.Items.Add("Passport Details: " & strCustomerPassportDetails)
        lstInvoice.Items.Add("Contact Details: " & strCustomerContactNumber)
        lstInvoice.Items.Add("")
        'Other guest Details
        lstInvoice.Items.Add("Other Guest Details: ")
        lstInvoice.Items.Add("***************")
        If dblExtraGuestsNumber = 1 Then
            lstInvoice.Items.Add("Second Guest Details")
            lstInvoice.Items.Add("***")
            lstInvoice.Items.Add("Name: " & strGuest2Name)
            lstInvoice.Items.Add("Age: " & strGuest2Age)
            lstInvoice.Items.Add("Passport Details: " & strGuest2PassportDetails)
        ElseIf dblExtraGuestsNumber = 2 Then
            lstInvoice.Items.Add("Second Guest Details")
            lstInvoice.Items.Add("***")
            lstInvoice.Items.Add("Name: " & strGuest2Name)
            lstInvoice.Items.Add("Age: " & strGuest2Age)
            lstInvoice.Items.Add("Passport Details: " & strGuest2PassportDetails)
            lstInvoice.Items.Add("")
            lstInvoice.Items.Add("Third Guest Details")
            lstInvoice.Items.Add("***")
            lstInvoice.Items.Add("Name: " & strGuest3Name)
            lstInvoice.Items.Add("Age: " & strGuest3Age)
            lstInvoice.Items.Add("Passport Details: " & strGuest3PassportDetails)
        ElseIf dblExtraGuestsNumber = 3 Then
            lstInvoice.Items.Add("Second Guest Details")
            lstInvoice.Items.Add("***")
            lstInvoice.Items.Add("Name: " & strGuest2Name)
            lstInvoice.Items.Add("Age: " & strGuest2Age)
            lstInvoice.Items.Add("Passport Details: " & strGuest2PassportDetails)
            lstInvoice.Items.Add("")
            lstInvoice.Items.Add("Third Guest Details")
            lstInvoice.Items.Add("***")
            lstInvoice.Items.Add("Name: " & strGuest3Name)
            lstInvoice.Items.Add("Age: " & strGuest3Age)
            lstInvoice.Items.Add("Passport Details: " & strGuest3PassportDetails)
            lstInvoice.Items.Add("Fourth Guest Details")
            lstInvoice.Items.Add("***")
            lstInvoice.Items.Add("Name: " & strGuest4Name)
            lstInvoice.Items.Add("Age: " & strGuest4Age)
            lstInvoice.Items.Add("Passport Details: " & strGuest4PassportDetails)
        Else
            lstInvoice.Items.Add("No Other guests.")
        End If
        lstInvoice.Items.Add("")

        'Costs Details
        lstInvoice.Items.Add("Cost Breakdown")
        lstInvoice.Items.Add("*****************")
        lstInvoice.Items.Add("Check In Date: " & strCheckInDate)
        lstInvoice.Items.Add("Check Out Date: " & strcheckOutDate)
        lstInvoice.Items.AddRange(frmRoomChoice.lstSubtotal.Items)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add(" + Extras:")
        lstInvoice.Items.Add("***")
        lstInvoice.Items.AddRange(frmExtras.lstSubtotal.Items)
        lstInvoice.Items.Add("")

        'Payment details
        lstInvoice.Items.Add("Payment Details:")
        lstInvoice.Items.Add("*****************")
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Payment Method: ")
        If frmPayment.rdoAmericanExpress.Checked Then
            lstInvoice.Items.Add("American Express")
        ElseIf frmPayment.rdoMasterCard.Checked Then
            lstInvoice.Items.Add("MasterCard")
        ElseIf frmPayment.rdoVisa.Checked Then
            lstInvoice.Items.Add("Visa Card")
        End If
        lstInvoice.Items.Add("Cardholders Name : " & strCardHoldersName)
        lstInvoice.Items.Add("CreditCard Number: " & strCreditCardNumber)
        lstInvoice.Items.Add("Security Code: " & strCardSecurityCode)
        lstInvoice.Items.Add("Expiry Date : " & strExpiryDate)

        'Summary
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Grand Total:")
        lstInvoice.Items.Add("*****************")
        lstInvoice.Items.Add(CStr(frmExtras.decGrandTotal))
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Thank You For Booking With OnlyTheBest.Com")


    End Sub



    ' Declare the PrintDocument object.
    Private WithEvents docToPrint As New Printing.PrintDocument

    Private Sub document_PrintPage(ByVal sender As Object,
        ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
            Handles docToPrint.PrintPage

        Dim TitleFont As New Font("Courier New", 20, System.Drawing.FontStyle.Bold)
        Dim TitleText As String = "OnlyTheBest.Com"
        e.Graphics.DrawString(TitleText, TitleFont, System.Drawing.Brushes.Red, 250, 40)
        Dim printFont As New Font("Arial", 8, System.Drawing.FontStyle.Regular)
        Dim YPosition As Integer = 80

        For Each hotel As String In lstInvoice.Items
            e.Graphics.DrawString(hotel, printFont, System.Drawing.Brushes.Black, 25, YPosition)
            YPosition += 15
        Next
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object,
     ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim PrintDialog1 As New PrintDialog
        Dim result As DialogResult = PrintDialog1.ShowDialog()
        If result = DialogResult.OK Then docToPrint.Print()
        blnPrintCheck = True
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If blnPrintCheck = True Then
            frmSatisfactionSurvey.Show()
            Me.Hide()


        Else
            MessageBox.Show("Please Print the invoice to continue:", "Eager Beaver Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)


        End If
    End Sub

    Private Sub pgrTransactionProgress_Click(sender As Object, e As EventArgs) Handles pgrTransactionProgress.Click

    End Sub

    Private Sub lstInvoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstInvoice.SelectedIndexChanged

    End Sub
End Class