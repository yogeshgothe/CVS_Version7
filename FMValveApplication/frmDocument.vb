Public Class frmDocument

    Private Sub frmDocument_Load(sender As Object, e As EventArgs) Handles Me.Load
        AxAcroPDF1.src = AppPath & "\Database\Kv chart L1,L2,L3 &P3 Trim.pdf"
    End Sub
End Class