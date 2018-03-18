Public Class frmWelcome
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        frmCustomerInfo.Show()

    End Sub
End Class