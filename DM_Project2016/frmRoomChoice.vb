Public Class frmRoomChoice
    'declaring my public variables
    Public decOffPeakWeekDayPrice, decOffPeakWeekEndPrice, decPeakWeekDayPrice, decPeakWeekEndPrice As Decimal

    'Below Is a set of functions that will determine the number peak & off Peak WeekDays/weekEnds
    'Off Peak
    'Weekdays
    Public Shared Function OffPeakWeekDaysBetweenDates(ByVal StartDate As Date, ByVal EndDate As Date) As Integer
        Dim wkday, wkend As Integer
        For i As Integer = 0 To DateDiff(DateInterval.Day, StartDate, EndDate)

            If DateAdd(DateInterval.Day, i, StartDate).DayOfWeek = DayOfWeek.Saturday Or DateAdd(DateInterval.Day, i, StartDate).DayOfWeek = DayOfWeek.Sunday Then
                wkend += 1
            Else
                wkday += 1
            End If
        Next
        wkday = wkday
        Return wkday
    End Function
    'Weekends
    Public Shared Function OffPeakWeekEndsBetweenDates(ByVal StartDate As Date, ByVal EndDate As Date) As Integer
        Dim wkday, wkend As Integer
        For i As Integer = 0 To DateDiff(DateInterval.Day, StartDate, EndDate)

            If DateAdd(DateInterval.Day, i, StartDate).DayOfWeek = DayOfWeek.Saturday Or DateAdd(DateInterval.Day, i, StartDate).DayOfWeek = DayOfWeek.Sunday Then
                wkend += 1
            Else
                wkday += 1
            End If
        Next
        wkend = wkend
        Return wkend
    End Function

    'Peak
    'Weekdays
    Public Shared Function PeakWeekDaysBetweenDates(ByVal StartDate As Date, ByVal EndDate As Date) As Integer
        Dim wkday, wkend As Integer

        For i As Integer = 0 To DateDiff(DateInterval.Day, StartDate, EndDate)

            If DateAdd(DateInterval.Day, i, StartDate).DayOfWeek = DayOfWeek.Saturday Or DateAdd(DateInterval.Day, i, StartDate).DayOfWeek = DayOfWeek.Sunday Then
                wkend += 1
            Else
                wkday += 1
            End If
        Next
        wkday = wkday
        Return wkday
    End Function
    'Weekends
    Public Shared Function PeakWeekEndsBetweenDates(ByVal StartDate As Date, ByVal EndDate As Date) As Integer
        Dim wkday, wkend As Integer
        For i As Integer = 0 To DateDiff(DateInterval.Day, StartDate, EndDate)

            If DateAdd(DateInterval.Day, i, StartDate).DayOfWeek = DayOfWeek.Saturday Or DateAdd(DateInterval.Day, i, StartDate).DayOfWeek = DayOfWeek.Sunday Then
                wkend += 1
            Else
                wkday += 1
            End If
        Next
        wkday = wkday

        Return wkend
    End Function

    Private Sub CheckedChanged() Handles rdoCork.CheckedChanged, rdoDublin.CheckedChanged, rdoKerry.CheckedChanged, rdoLimerick.CheckedChanged
        'This decides what items appear in the hotel choice combo box when a radio buttojn is selected
        If rdoCork.Checked Then
            cmbHotelChoice.Items.Clear()
            cmbHotelChoice.Items.Add("Langher Lodge(2*)")
            cmbHotelChoice.Items.Add("Pana Palace(3*)")
            cmbHotelChoice.Items.Add("Coal-Quay Hotel(3*)")
        End If

        If rdoKerry.Checked Then
            cmbHotelChoice.Items.Clear()
            cmbHotelChoice.Items.Add("Simply The Best(4*)")
            cmbHotelChoice.Items.Add("BallyRocks Hotel(5*)")

        End If

        If rdoDublin.Checked Then
            cmbHotelChoice.Items.Clear()
            cmbHotelChoice.Items.Add("Jackeen Ville(1*)")
            cmbHotelChoice.Items.Add("Blue Cow Inn(2*)")
            cmbHotelChoice.Items.Add("Stellabourne Hotel(4*)")
        End If

        If rdoLimerick.Checked Then
            cmbHotelChoice.Items.Clear()
            cmbHotelChoice.Items.Add("The Docks Motel(1*)")
            cmbHotelChoice.Items.Add("Shannon Lodge(3*)")
            cmbHotelChoice.Items.Add("Clohessy Court Hotel(4*)")
        End If


    End Sub
    Sub HotelChoice() Handles rdoRoomSingle.CheckedChanged, rdoRoomTwin.CheckedChanged
        'Declaring Variables 
        Dim decSubtotal As Decimal = 0
        Dim decPrice As Decimal = 0
        Dim intPeakWeekDays As Integer = 0
        Dim intPeakWeekEndDays As Integer = 0
        Dim intOffPeakWeekDays As Integer = 0
        Dim intOffPeakWeekEndDays As Integer = 0
        Dim blnPeak As Boolean
        Dim dteCheckIn As Date = dtpCheckIn.Value
        Dim dteCheckOut As Date = dtpCheckOut.Value
        Dim strDuration As String = CStr(DateDiff(DateInterval.Day, dteCheckIn, dteCheckOut))
        Dim dteTodaysDate As Date = Today
        Dim intAdvanceDays As Integer = CInt(DateDiff(DateInterval.Day, dteTodaysDate, dteCheckIn))
        Dim blnAdvanceBooking As Boolean
        Dim decAdvancedBookingReduction As Decimal
        Dim intCustomerAge As Integer = CInt(frmCustomerInfo.mtbGuest1Age.Text)
        Dim dblExtraGuestsNumber As Double = (frmCustomerInfo.cmbOtherGuests.Text)
        Dim intGuest2Age, intGuest3Age, intGuest4Age As Integer
        Dim decUnderAgeReduction As Decimal


        'This statement sets the various guest ages for the reduction
        If dblExtraGuestsNumber = 1 Then
            intGuest2Age = CInt(frmExtraGuests.mtbGuest2Age.Text)
            intGuest3Age = 0
            intGuest4Age = 0

        ElseIf dblExtraGuestsNumber = 2 Then
            intGuest2Age = CInt(frmExtraGuests.mtbGuest2Age.Text)
            intGuest3Age = CInt(frmExtraGuests.mtbGuest3Age.Text)
            intGuest4Age = 0

        ElseIf dblExtraGuestsNumber = 3 Then
            intGuest2Age = CInt(frmExtraGuests.mtbGuest2Age.Text)
            intGuest3Age = CInt(frmExtraGuests.mtbGuest3Age.Text)
            intGuest4Age = CInt(frmExtraGuests.mtbGuest4Age.Text)

        Else
            intGuest2Age = 0
            intGuest3Age = 0
            intGuest4Age = 0
        End If






        'the following ifs checkif booking is peak or off peak
        If (dteCheckIn.Month > 2) And (dteCheckIn.Month < 9) Then
            blnPeak = True
        Else
            blnPeak = False
        End If

        lstSubtotal.Items.Clear()


        If blnPeak = True Then
            intPeakWeekEndDays = CInt(PeakWeekEndsBetweenDates(dteCheckIn, dteCheckOut))
            intPeakWeekDays = CInt(PeakWeekDaysBetweenDates(dteCheckIn, dteCheckOut))
            intOffPeakWeekDays = 0
            intOffPeakWeekEndDays = 0

        End If

        If blnPeak = False Then
            intOffPeakWeekEndDays = CInt(OffPeakWeekEndsBetweenDates(dteCheckIn, dteCheckOut))
            intOffPeakWeekDays = CInt(OffPeakWeekDaysBetweenDates(dteCheckIn, dteCheckOut))
            intPeakWeekDays = 0
            intPeakWeekEndDays = 0
        End If


        'This should show a running total/ do the relevant calculations

        'case Select for cork Hotels



        If cmbHotelChoice.SelectedItem = "Langher Lodge(2*)" And rdoRoomSingle.Checked Then
            decOffPeakWeekDayPrice = 33
            decOffPeakWeekEndPrice = 43
            decPeakWeekDayPrice = 53
            decPeakWeekEndPrice = 63

            decPrice = ((intPeakWeekEndDays * 63) + (intPeakWeekDays * 53) _
            + (intOffPeakWeekEndDays * 43) + (intOffPeakWeekDays * 33))
            lstSubtotal.Items.Add("Langher Lodge - " & " Single Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Langher Lodge(2*)" And rdoRoomTwin.Checked Then
            decOffPeakWeekDayPrice = 63
            decOffPeakWeekEndPrice = 83
            decPeakWeekDayPrice = 103
            decPeakWeekEndPrice = 123

            decPrice = ((intPeakWeekEndDays * 123) + (intPeakWeekDays * 103) _
            + (intOffPeakWeekEndDays * 83) + (intOffPeakWeekDays * 63))
            lstSubtotal.Items.Add("Langher Lodge - " & " Twin Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Pana Palace(3*)" And rdoRoomSingle.Checked Then
            decOffPeakWeekDayPrice = 45
            decOffPeakWeekEndPrice = 55
            decPeakWeekDayPrice = 65
            decPeakWeekEndPrice = 75

            decPrice = ((intPeakWeekEndDays * 75) + (intPeakWeekDays * 65) _
            + (intOffPeakWeekEndDays * 55) + (intOffPeakWeekDays * 45))
            lstSubtotal.Items.Add("Pana Palace - " & " Single Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Pana Palace(3*)" And rdoRoomTwin.Checked Then
            decOffPeakWeekDayPrice = 85
            decOffPeakWeekEndPrice = 105
            decPeakWeekDayPrice = 145
            decPeakWeekEndPrice = 125

            decPrice = ((intPeakWeekEndDays * 125) + (intPeakWeekDays * 145) _
            + (intOffPeakWeekEndDays * 105) + (intOffPeakWeekDays * 85))
            lstSubtotal.Items.Add("Pana Palace - " & " Twin Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Coal-Quay Hotel(3*)" And rdoRoomSingle.Checked Then
            decOffPeakWeekDayPrice = 48
            decOffPeakWeekEndPrice = 60
            decPeakWeekDayPrice = 68
            decPeakWeekEndPrice = 80

            decPrice = ((intPeakWeekEndDays * 80) + (intPeakWeekDays * 68) _
            + (intOffPeakWeekEndDays * 60) + (intOffPeakWeekDays * 48))
            lstSubtotal.Items.Add("Coal Quay Hotel - " & " Single Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Coal-Quay Hotel(3*)" And rdoRoomTwin.Checked Then
            decOffPeakWeekDayPrice = 88
            decOffPeakWeekEndPrice = 120
            decPeakWeekDayPrice = 128
            decPeakWeekEndPrice = 160
            decPrice = ((intPeakWeekEndDays * 160) + (intPeakWeekDays * 128) _
            + (intOffPeakWeekEndDays * 120) + (intOffPeakWeekDays * 88))
            lstSubtotal.Items.Add("Coal-Quay Hotel - " & " Twin Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

            'case select for Kerry Hotels

        ElseIf cmbHotelChoice.Text = "Simply The Best(4*)" And rdoRoomSingle.Checked Then
            decOffPeakWeekDayPrice = 47
            decOffPeakWeekEndPrice = 57
            decPeakWeekDayPrice = 67
            decPeakWeekEndPrice = 77
            decPrice = ((intPeakWeekEndDays * 77) + (intPeakWeekDays * 67) _
            + (intOffPeakWeekEndDays * 57) + (intOffPeakWeekDays * 47))
            lstSubtotal.Items.Add("Simply the Best Hotel - " & " Single Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Simply The Best(4*)" And rdoRoomTwin.Checked Then
            decOffPeakWeekDayPrice = 87
            decOffPeakWeekEndPrice = 107
            decPeakWeekDayPrice = 127
            decPeakWeekEndPrice = 147
            decPrice = ((intPeakWeekEndDays * 147) + (intPeakWeekDays * 127) _
            + (intOffPeakWeekEndDays * 107) + (intOffPeakWeekDays * 87))
            lstSubtotal.Items.Add("Simply The Best hotel - " & " Twin Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "BallyRocks Hotel(5*)" And rdoRoomSingle.Checked Then
            decOffPeakWeekDayPrice = 95
            decOffPeakWeekEndPrice = 110
            decPeakWeekDayPrice = 125
            decPeakWeekEndPrice = 160
            decPrice = ((intPeakWeekEndDays * 160) + (intPeakWeekDays * 125) _
            + (intOffPeakWeekEndDays * 110) + (intOffPeakWeekDays * 95))
            lstSubtotal.Items.Add(" BallyRocks Hotel- " & " Single Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "BallyRocks Hotel(5*)" And rdoRoomTwin.Checked Then
            decOffPeakWeekDayPrice = 200
            decOffPeakWeekEndPrice = 250
            decPeakWeekDayPrice = 275
            decPeakWeekEndPrice = 300
            decPrice = ((intPeakWeekEndDays * 300) + (intPeakWeekDays * 275) _
            + (intOffPeakWeekEndDays * 250) + (intOffPeakWeekDays * 200))
            lstSubtotal.Items.Add("BallyRocks Hotel - " & " Twin Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

            'case select for Dublin Hotels
        ElseIf cmbHotelChoice.Text = "Jackeen Ville(1*)" And rdoRoomSingle.Checked Then
            decOffPeakWeekDayPrice = 29
            decOffPeakWeekEndPrice = 36
            decPeakWeekDayPrice = 39
            decPeakWeekEndPrice = 46
            decPrice = ((intPeakWeekEndDays * 46) + (intPeakWeekDays * 39) _
            + (intOffPeakWeekEndDays * 36) + (intOffPeakWeekDays * 29))
            lstSubtotal.Items.Add("Jackeen Ville - " & " Single Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Jackeen Ville(1*)" And rdoRoomTwin.Checked Then
            decOffPeakWeekDayPrice = 49
            decOffPeakWeekEndPrice = 66
            decPeakWeekDayPrice = 69
            decPeakWeekEndPrice = 86
            decPrice = ((intPeakWeekEndDays * 86) + (intPeakWeekDays * 69) _
            + (intOffPeakWeekEndDays * 66) + (intOffPeakWeekDays * 49))
            lstSubtotal.Items.Add("Jackeen Ville - " & " Twin Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Blue Cow Inn(2*)" And rdoRoomSingle.Checked Then
            decOffPeakWeekDayPrice = 65
            decOffPeakWeekEndPrice = 72
            decPeakWeekDayPrice = 75
            decPeakWeekEndPrice = 82
            decPrice = ((intPeakWeekEndDays * 82) + (intPeakWeekDays * 75) _
            + (intOffPeakWeekEndDays * 72) + (intOffPeakWeekDays * 65))
            lstSubtotal.Items.Add("Blue Cow Inn - " & " Single Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Blue Cow Inn(2*)" And rdoRoomTwin.Checked Then
            decOffPeakWeekDayPrice = 125
            decOffPeakWeekEndPrice = 142
            decPeakWeekDayPrice = 145
            decPeakWeekEndPrice = 162
            decPrice = ((intPeakWeekEndDays * 162) + (intPeakWeekDays * 145) _
            + (intOffPeakWeekEndDays * 142) + (intOffPeakWeekDays * 125))
            lstSubtotal.Items.Add("Blue Cow In - " & " Twin Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Stellabourne Hotel(4*)" And rdoRoomSingle.Checked Then
            decOffPeakWeekDayPrice = 90
            decOffPeakWeekEndPrice = 100
            decPeakWeekDayPrice = 110
            decPeakWeekEndPrice = 130
            decPrice = ((intPeakWeekEndDays * 130) + (intPeakWeekDays * 110) _
            + (intOffPeakWeekEndDays * 100) + (intOffPeakWeekDays * 90))
            lstSubtotal.Items.Add("Stellabourne Hotel - " & " Single Room " & vbNewLine & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Stellabourne Hotel(4*)" And rdoRoomTwin.Checked Then
            decOffPeakWeekDayPrice = 180
            decOffPeakWeekEndPrice = 200
            decPeakWeekDayPrice = 220
            decPeakWeekEndPrice = 260
            decPrice = ((intPeakWeekEndDays * 260) + (intPeakWeekDays * 220) _
            + (intOffPeakWeekEndDays * 200) + (intOffPeakWeekDays * 180))
            lstSubtotal.Items.Add("Stelllabourne Hotel - " & " Twin Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

            'Case select for Limerick Hotels 
        ElseIf cmbHotelChoice.Text = "The Docks Motel(1*)" And rdoRoomSingle.Checked Then
            decOffPeakWeekDayPrice = 25
            decOffPeakWeekEndPrice = 30
            decPeakWeekDayPrice = 35
            decPeakWeekEndPrice = 40
            decPrice = ((intPeakWeekEndDays * 40) + (intPeakWeekDays * 35) _
            + (intOffPeakWeekEndDays * 30) + (intOffPeakWeekDays * 25))
            lstSubtotal.Items.Add("The Docks Motel - " & " Single Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "The Docks Motel(1*)" And rdoRoomTwin.Checked Then
            decOffPeakWeekDayPrice = 45
            decOffPeakWeekEndPrice = 60
            decPeakWeekDayPrice = 65
            decPeakWeekEndPrice = 80
            decPrice = ((intPeakWeekEndDays * 80) + (intPeakWeekDays * 65) _
            + (intOffPeakWeekEndDays * 60) + (intOffPeakWeekDays * 45))
            lstSubtotal.Items.Add("The Docks Motel - " & " Twin Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Shannon Lodge(3*)" And rdoRoomSingle.Checked Then
            decOffPeakWeekDayPrice = 56
            decOffPeakWeekEndPrice = 66
            decPeakWeekDayPrice = 70
            decPeakWeekEndPrice = 80
            decPrice = ((intPeakWeekEndDays * 80) + (intPeakWeekDays * 70) _
            + (intOffPeakWeekEndDays * 66) + (intOffPeakWeekDays * 56))
            lstSubtotal.Items.Add("Shannon Lodge - " & " Single Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Shannon Lodge(3*)" And rdoRoomTwin.Checked Then
            decOffPeakWeekDayPrice = 106
            decOffPeakWeekEndPrice = 126
            decPeakWeekDayPrice = 140
            decPeakWeekEndPrice = 160
            decPrice = ((intPeakWeekEndDays * 160) + (intPeakWeekDays * 140) _
            + (intOffPeakWeekEndDays * 126) + (intOffPeakWeekDays * 106))
            lstSubtotal.Items.Add("Shannon Lodge - " & " Twin Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Clohessy Court Hotel(4*)" And rdoRoomSingle.Checked Then
            decOffPeakWeekDayPrice = 72
            decOffPeakWeekEndPrice = 82
            decPeakWeekDayPrice = 89
            decPeakWeekEndPrice = 99
            decPrice = ((intPeakWeekEndDays * 99) + (intPeakWeekDays * 89) _
            + (intOffPeakWeekEndDays * 82) + (intOffPeakWeekDays * 72))
            lstSubtotal.Items.Add("Clohessy Court Hotel - " & " Single Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)

        ElseIf cmbHotelChoice.Text = "Clohessy Court Hotel(4*)" And rdoRoomTwin.Checked Then
            decOffPeakWeekDayPrice = 142
            decOffPeakWeekEndPrice = 162
            decPeakWeekDayPrice = 169
            decPeakWeekEndPrice = 189
            decPrice = ((intPeakWeekEndDays * 189) + (intPeakWeekDays * 169) _
            + (intOffPeakWeekEndDays * 162) + (intOffPeakWeekDays * 142))
            lstSubtotal.Items.Add("Clohessy Court Hotel - " & " Twin Room " & strDuration & " Day(s) Booked " & vbNewLine & "Subtotal:" & decPrice)
        Else
            decPrice = 0
        End If
        'this determines the ages of the guests and applies the relevant discounts
        If intCustomerAge < 16 Or (intGuest2Age < 16 And frmExtraGuests.grpGuest2Details.Visible = True) Or (intGuest3Age < 16 And frmExtraGuests.grpGuest3Details.Visible = True) Or (intGuest4Age < 16 And frmExtraGuests.grpGuest2Details.Visible = True) And rdoRoomSingle.Checked Then
            decUnderAgeReduction = (decPrice * 0.1)
        ElseIf intCustomerAge < 16 Or (intGuest2Age < 16 And frmExtraGuests.grpGuest2Details.Visible = True) Or (intGuest3Age < 16 And frmExtraGuests.grpGuest3Details.Visible = True) Or (intGuest4Age < 16 And frmExtraGuests.grpGuest2Details.Visible = True) And rdoRoomTwin.Checked Then
            decUnderAgeReduction = (decPrice * 0.25)
        End If
        'These If Statements determine if the customer recieves a Advance Booking Discount:
        If intAdvanceDays > 30 Then
            blnAdvanceBooking = True
        Else
            blnAdvanceBooking = False
        End If
        If blnAdvanceBooking = True Then
            decAdvancedBookingReduction = (decPrice * 0.1)
        Else
            decAdvancedBookingReduction = 0
        End If
        'this adds the values to the subtotal listbox
        lstSubtotal.Items.Add("Advance booking discount: " & decAdvancedBookingReduction)
        decPrice = decPrice - decAdvancedBookingReduction
        lstSubtotal.Items.Add("Under 16's discount: " & decUnderAgeReduction)
        decPrice = decPrice - decUnderAgeReduction
        decSubtotal = decPrice
        lstSubtotal.Items.Add("SubTotal : " & decSubtotal)
        gdecRoomSubtotal = decSubtotal

    End Sub


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'error checking
        If cmbHotelChoice.Text = "" Then
            MessageBox.Show("Please Choose A hotel:", "Blank Space Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            cmbHotelChoice.Focus()
        ElseIf dtpCheckOut.Value < dtpCheckIn.Value Then
            MessageBox.Show(" Checkout date can not be before the Check In date", "Incorrect Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            ErrorCount()
            dtpCheckOut.Focus()
        Else
            Me.Visible = False
            frmExtras.Show()

        End If

    End Sub

    Private Sub frmRoomChoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this sets the minimum dates for both date time pickers
        dtpCheckIn.MinDate = Today
        dtpCheckIn.MinDate = Today
    End Sub
End Class