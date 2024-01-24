Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class WaitingPBox


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private WithEvents AnimationTimer As New Timer()

    Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the maximum value for the ProgressBar (adjust as needed)
        WaitingPBar.Maximum = 100

        ' Set the Timer interval (adjust as needed)
        AnimationTimer.Interval = 100

        ' Start the animation
        AnimationTimer.Start()
    End Sub

    ' Timer Tick event handler
    Private Sub AnimationTimer_Tick(sender As Object, e As EventArgs) Handles AnimationTimer.Tick
        ' Increment the ProgressBar value
        WaitingPBar.Value += 1

        ' Check if the ProgressBar reaches the maximum value
        If WaitingPBar.Value >= WaitingPBar.Maximum Then
            ' Reset the ProgressBar value to simulate continuous animation
            WaitingPBar.Value = WaitingPBar.Minimum
        End If
    End Sub



End Class
