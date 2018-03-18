Public Class frmExtras
    Const decOtherItemsPrice As Decimal = 11.25
    Const decSuitsPrice As Decimal = 19.5
    Const decShirtsPrice As Decimal = 9.25
    Const decLaundryPrice As Decimal = 15.5
    Dim decExtraPrice As Decimal = 0
    Dim dblContinentalNo, dblFullIrishNo, dblEveningMealNo As Double
    Dim dblLaundryBagNo As Double = 0
    Dim decOtherItemsTotal, decDryCleaningTotal, decLaundryTotal, decMealTotal As Decimal
    Dim decContinentalTotal, decFullIrishTotal, decEveningMealTotal As Decimal
    Dim decPeakWeekEndPrice As Decimal = frmRoomChoice.decPeakWeekEndPrice
    Dim decPeakWeekDayPrice As Decimal = frmRoomChoice.decPeakWeekDayPrice
    Dim decOffPeakWeekEndPrice As Decimal = frmRoomChoice.decOffPeakWeekEndPrice
    Dim decOffPeakWeekDayPrice As Decimal = frmRoomChoice.decOffPeakWeekDayPrice
    Dim gdecEveningMealPrice As Decimal = (decPeakWeekEndPrice * 0.25)
    Dim gdecFullIrishPrice As Decimal = (decPeakWeekDayPrice * 0.1)
    Dim gdecContinentalPrice As Decimal = (decOffPeakWeekEndPrice * 0.075)
    Public decGrandTotal As Decimal



    Sub frmExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dblExtraGuestsNumber As Double = CDbl(frmCustomerInfo.cmbOtherGuests.Text)
        'This If Statement Sets The Number Of Items In Continental Combo Box
        lstSubtotal.Items.Add("Room Cost: " & gdecRoomSubtotal)
        lstSubtotal.Items.Add("********************")
        If dblExtraGuestsNumber = 1 Then
            cmbContinental.Items.Clear()
            cmbContinental.Items.Add("0")
            cmbContinental.Items.Add("1")
            cmbContinental.Items.Add("2")

        ElseIf dblExtraGuestsNumber = 2 Then
            cmbContinental.Items.Clear()
            cmbContinental.Items.Add("0")
            cmbContinental.Items.Add("1")
            cmbContinental.Items.Add("2")
            cmbContinental.Items.Add("3")
        ElseIf dblExtraGuestsNumber = 3 Then
            cmbContinental.Items.Clear()
            cmbContinental.Items.Add("0")
            cmbContinental.Items.Add("1")
            cmbContinental.Items.Add("2")
            cmbContinental.Items.Add("3")
            cmbContinental.Items.Add("4")
        Else
            cmbContinental.Items.Clear()
            cmbContinental.Items.Add("0")
            cmbContinental.Items.Add("1")

        End If

        'This If Statement Sets The Number Of Items In Full Irish
        If dblExtraGuestsNumber = 1 Then
            cmbFullIrish.Items.Clear()
            cmbFullIrish.Items.Add("0")
            cmbFullIrish.Items.Add("1")
            cmbFullIrish.Items.Add("2")

        ElseIf dblExtraGuestsNumber = 2 Then
            cmbFullIrish.Items.Clear()
            cmbFullIrish.Items.Add("0")
            cmbFullIrish.Items.Add("1")
            cmbFullIrish.Items.Add("2")
            cmbFullIrish.Items.Add("3")
        ElseIf dblExtraGuestsNumber = 3 Then
            cmbFullIrish.Items.Clear()
            cmbFullIrish.Items.Add("0")
            cmbFullIrish.Items.Add("1")
            cmbFullIrish.Items.Add("2")
            cmbFullIrish.Items.Add("3")
            cmbFullIrish.Items.Add("4")
        Else
            cmbFullIrish.Items.Clear()
            cmbFullIrish.Items.Add("0")
            cmbFullIrish.Items.Add("1")

        End If

        'This If Statement Sets The Number Of Items In EveningMeal
        If dblExtraGuestsNumber = 1 Then
            cmbEveningMeal.Items.Clear()
            cmbEveningMeal.Items.Add("0")
            cmbEveningMeal.Items.Add("1")
            cmbEveningMeal.Items.Add("2")

        ElseIf dblExtraGuestsNumber = 2 Then
            cmbEveningMeal.Items.Clear()
            cmbEveningMeal.Items.Add("0")
            cmbEveningMeal.Items.Add("1")
            cmbEveningMeal.Items.Add("2")
            cmbEveningMeal.Items.Add("3")

        ElseIf dblExtraGuestsNumber = 3 Then
            cmbEveningMeal.Items.Clear()
            cmbEveningMeal.Items.Add("0")
            cmbEveningMeal.Items.Add("1")
            cmbEveningMeal.Items.Add("2")
            cmbEveningMeal.Items.Add("3")
            cmbEveningMeal.Items.Add("4")

        Else
            cmbEveningMeal.Items.Clear()
            cmbEveningMeal.Items.Add("0")
            cmbEveningMeal.Items.Add("1")
        End If
    End Sub
    Private Sub mtbLaundry_TextChanged(sender As Object, e As EventArgs) Handles mtbLaundry.TextChanged
       
            dblLaundryBagNo = CDbl(mtbLaundry.Text)
        decLaundryTotal = (dblLaundryBagNo * decLaundryPrice)
        decExtraPrice += decLaundryTotal
        lstSubtotal.Items.Add("Laundry Services: " & decLaundryTotal)

    End Sub
    Private Sub chkSuits_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuits.CheckedChanged
        'Suits 
        If chkSuits.Checked Then
            decExtraPrice += decSuitsPrice
        End If
        lstSubtotal.Items.Add("Suits : " & decSuitsPrice)
    End Sub
    Private Sub chkShirts_CheckedChanged(sender As Object, e As EventArgs) Handles chkShirts.CheckedChanged
        'Shirts
        If chkShirts.Checked Then
            decExtraPrice += decShirtsPrice
        End If
        lstSubtotal.Items.Add("Shirts : " & decShirtsPrice)
    End Sub

    Private Sub cmbContinental_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbContinental.SelectedValueChanged

        dblContinentalNo = CDbl(cmbContinental.Text)
        decContinentalTotal = (dblContinentalNo * gdecContinentalPrice)
        decExtraPrice += decContinentalTotal
        lstSubtotal.Items.Add("Continental Breakfast:  " & decContinentalTotal)
    End Sub

    Private Sub cmbFullIrish_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFullIrish.SelectedValueChanged

        dblFullIrishNo = CDbl(cmbFullIrish.Text)
        decFullIrishTotal = (dblFullIrishNo * gdecFullIrishPrice)
        decExtraPrice += decFullIrishTotal
        lstSubtotal.Items.Add("Full- Irish Breakfast: " & decFullIrishTotal)
    End Sub

    Private Sub cmbEveningMeal_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbEveningMeal.SelectedValueChanged
 

        dblEveningMealNo = CDbl(cmbEveningMeal.Text)
        decEveningMealTotal = (dblEveningMealNo * gdecEveningMealPrice)
        decExtraPrice += decEveningMealTotal
        lstSubtotal.Items.Add("Evening Meal: " & decEveningMealTotal)

    End Sub

    Private Sub chkOther_CheckedChanged(sender As Object, e As EventArgs) Handles chkOther.CheckedChanged

        'This If Statement Says that if Other Items Is Selected Then Enable mtbOthers
        If chkOther.Checked Then
            mtbOtherItems.Enabled = True
        End If
    End Sub
    Private Sub mtbOther_TextChanged(sender As Object, e As EventArgs) Handles mtbOtherItems.TextChanged
        'This If Statement Calculates the Cost Of the Other Items
        If mtbOtherItems.Enabled = True Then

            Dim decOtherItemsNo As Decimal = (CDec(mtbOtherItems.Text))

            decOtherItemsTotal = (decOtherItemsNo * decOtherItemsPrice)
            decExtraPrice += decOtherItemsTotal
            lstSubtotal.Items.Add(" Other Drycleaning: " & decOtherItemsTotal)
        End If

    End Sub

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        'Error checking:
        If chkOther.Checked And mtbOtherItems.Text = "" Then
            MessageBox.Show("Please enter the number of other items to be drycleaned:", "Blank Space Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            mtbOtherItems.Focus()
            ErrorCount()

        ElseIf cmbContinental.Text = "" Then
            MessageBox.Show("Please select a value for the number of Continental Breakfasts:", "Blank Space Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            cmbContinental.Focus()
            ErrorCount()

        ElseIf cmbFullIrish.Text = "" Then
            MessageBox.Show("Please select a value for the number of Full-Irish Breakfasts:", "Blank Space Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            cmbFullIrish.Focus()
            ErrorCount()

        ElseIf cmbEveningMeal.Text = "" Then
            MessageBox.Show("Please select a value for the number of Evening Meals:", "Blank Space Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            cmbEveningMeal.Focus()
            ErrorCount()
        ElseIf mtbLaundry.Text = "" Then
            MessageBox.Show("Please type a value for the number of laundry bags", "Blank Space Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            mtbLaundry.Focus()
            ErrorCount()
        Else
            lstSubtotal.Items.Add("Total Cost Of Extras " & decExtraPrice)
            decGrandTotal = (gdecRoomSubtotal + decExtraPrice)
            lstSubtotal.Items.Add("********************")
            lstSubtotal.Items.Add(" Grand Total: " & decGrandTotal)
        End If

        
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If decGrandTotal = 0 Then
            MessageBox.Show("Please calculate the grand total", "Eager Beaver Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Hide()
            frmPayment.Show()
        End If

    End Sub
End Class