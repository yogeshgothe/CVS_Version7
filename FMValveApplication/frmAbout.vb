Imports System.Deployment.Application
Public Class frmAbout

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles Me.Load

        If My.Application.IsNetworkDeployed Then
            lblVersionNo.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString & " " & VersionDate
        Else
            lblVersionNo.Text = VersionNo & vbLf & "  " & VersionDate
        End If
    End Sub
End Class