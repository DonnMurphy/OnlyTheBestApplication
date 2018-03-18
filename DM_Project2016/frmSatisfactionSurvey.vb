Public Class frmSatisfactionSurvey



    Private Sub frmSatisfactionSurvey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TransactionTimeStop()
        lblTimer.Text = strTransactionTIme
        lblErrors.Text = gErrorCount.ToString
    End Sub

    Private Sub mtbCustomerRating_Click(sender As Object, e As MouseEventArgs) Handles mtbCustomerRating.Click
        Dim message, title, defaultValue As String
        Dim myValue As Object
        ' Set prompt.
        message = "Ask the customer to rate thr transaction between 1 - 5 (1 being the lowest and 5 being the highest) "

        ' Set title.
        title = "Customer Satisfaction Survey"
        defaultValue = "1"   ' Set default value.

        ' Display message, title, and default value.
        ' myValue = InputBox(message, title, defaultValue)
        ' If user has clicked Cancel, set myValue to defaultValue 


        ' Display dialog box at position 100, 100.
        myValue = InputBox(message, title, defaultValue, 200, 200)
        If myValue Is "" Then myValue = defaultValue
        ' If user has clicked Cancel, set myValue to defaultValue 
        If myValue Is "" Then myValue = defaultValue
        mtbCustomerRating.Text = myValue
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        Me.Hide()
        frmCustomerInfo.Show()
        gdecRoomSubtotal = 0

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim response = MessageBox.Show("Do you Wish to Logout?", "Logout Confirmation:", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            Me.Close()
            frmCustomerInfo.show
        End If

    End Sub
End Class