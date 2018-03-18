Imports System.Timers
Module TransactionTimer


    Public tmrTransactionTime As System.Timers.Timer
    Public intTimeTaken As Integer = 0
    Private Sub SetTimer()
        ' Create a timer with a two second interval.
        tmrTransactionTime = New System.Timers.Timer(1000)
        ' Hook up the Elapsed event for the timer. 
        AddHandler tmrTransactionTime.Elapsed, AddressOf OnTimedEvent
        tmrTransactionTime.AutoReset = True
        tmrTransactionTime.Enabled = True
    End Sub

    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        intTimeTaken += 1

    End Sub





    Public strTransactionTIme As String
    Public Sub TransactionTimerGO()
        SetTimer()



    End Sub

    Public Sub TransactionTimeStop()
        tmrTransactionTime.Stop()
        strTransactionTIme = CStr(intTimeTaken)
    End Sub
End Module
