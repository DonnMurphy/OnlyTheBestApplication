Public Class frmSelfDestruct
    Dim dblSongCounter As Double
    Dim dblPicCounter As Double
    Public Function RandomNumber(ByVal n As Integer) As Integer
        'initialize random number generator
        Dim r As New Random(System.DateTime.Now.Millisecond)
        Return r.Next(1, n)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '   PlayBackgroundSoundFile()
        tmrFunTime.Enabled = True

    End Sub

    'Sub PlayBackgroundSoundFile()
    '   My.Computer.Audio.Play("E:\116433164 VB Project\Project Files\Dogsong.wav",
    '      AudioPlayMode.WaitToComplete)
    'End Sub

    Private Sub tmrFunTime_Tick(sender As Object, e As EventArgs) Handles tmrFunTime.Tick
        dblSongCounter += 1
        dblPicCounter = CDbl(RandomNumber(10))
        If dblSongCounter > 38 Then
           ' StopBackgroundSound()
        End If

        If dblPicCounter = 1 Then
            pctAlertDoge.Visible = True
        End If

        If dblPicCounter = 2 Then
            pctHappyDoge.Visible = True
            pctAlertDoge.Visible = False

        End If

        If dblPicCounter = 3 Then
            pctHulkDoge.Visible = True
        End If

        If dblPicCounter = 4 Then
            pctHungoverDoge.Visible = True
            pctHappyDoge.Visible = False

        End If

        If dblPicCounter = 5 Then
            pctParanoidDoge.Visible = True
        End If

        If dblPicCounter = 6 Then
            pctRainbowDoge.Visible = True
            pctHulkDoge.Visible = False

        End If

        If dblPicCounter = 7 Then
            pctSpinDoge.Visible = True
            pctWeedDoge.Visible = False

        End If

        If dblPicCounter = 8 Then
            pctThugDoge.Visible = True
            pctParanoidDoge.Visible = False
            pctHungoverDoge.Visible = False

        End If

        If dblPicCounter = 9 Then
            pctWeedDoge.Visible = True
            pctRainbowDoge.Visible = False
            pctThugDoge.Visible = False

        End If


    End Sub

    Sub StopBackgroundSound()
        'My.Computer.Audio.Stop()
    End Sub

    Private Sub pctAlertDoge_Click(sender As Object, e As EventArgs) Handles pctAlertDoge.Click

    End Sub

    Private Sub pctWeedDoge_Click(sender As Object, e As EventArgs) Handles pctWeedDoge.Click

    End Sub
End Class