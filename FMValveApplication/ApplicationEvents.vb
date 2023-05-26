Imports System.Deployment.ApplicationNamespace My    ' The following events are available for MyApplication:

    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    Partial Friend Class MyApplication
        
        Private Sub splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
            Try
                My.Application.MinimumSplashScreenDisplayTime = 3000
               
                frmRecordsGrid.LoadEssentials()
            Catch ex As Exception
                MessageBox.Show(ex.Message + Environment.NewLine)
            End Try
        End Sub
    End Class
End Namespace

