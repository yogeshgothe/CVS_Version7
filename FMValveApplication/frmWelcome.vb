Imports System.Deployment.Application
Public Class frmWelcome




    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Timer1.Stop()
    '    Me.Close()

    'End Sub

    'Private Sub frmWelcome_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    '    ' Me.Hide()
    '    Try
    '        frmRecordsGrid.ShowDialog()
    '    Catch ex As Exception
    '        MsgBox("Records Grid : ", ex.Message)
    '    End Try



    'End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Timer1.Interval = 3
        'Timer1.Start()
        ' lblVersionNo.Text = "Version No: V6.1.0" & vbLf & "     16 March 2023"
        If My.Application.IsNetworkDeployed Then
            lblVersionNo.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString & vbLf & "  " & VersionDate
        Else
            lblVersionNo.Text = VersionNo & vbLf & VersionDate

        End If


    End Sub
End Class