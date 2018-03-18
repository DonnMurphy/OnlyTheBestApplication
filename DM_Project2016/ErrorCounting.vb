Module ErrorCounting
    Public gErrorCount As Integer
    Public Sub ErrorCount()
        ' Public SubProcedure Named Error count
        If gErrorCount = 0 Or (gErrorCount < 4 And gErrorCount > 0) Then
            'incresesa the value off the error count by 1
            gErrorCount += 1

            MessageBox.Show("You Have made " & gErrorCount & " error(s).")
        Else
            MessageBox.Show("You Have Exceeded your Error Limit")
            'The Error count Is reset 
            gErrorCount = 0
            'If you have global variables in your projct you  will need to reset here too eg dblTotal = 0

            frmLogin.Show()
            'Hide all forms but the Login One 


        End If
    End Sub
End Module
