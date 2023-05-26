Public Class frmPrintDatasheet
    Public PrintFormLoad As Boolean
    Private Sub btnPrintDatasheet_Click(sender As Object, e As EventArgs) Handles btnPrintDatasheet.Click
        If MsgBox("Do you want to print Datasheet", MsgBoxStyle.OkCancel, "Confirm") = MsgBoxResult.Ok Then
            MsgBox("Please close the datasheet file before returning to software!", , "Alert!")
            ConfirmedPrinting = True
            Me.Close()
        End If
    End Sub

    Private Sub txtFromDatasheet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFromDatasheet.KeyPress
        Try
            If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789").IndexOf(e.KeyChar) = -1) Then
                MsgBox("Please enter integers only")
                e.Handled = True

            End If
        Catch ex As Exception
            MsgBox("FromText KeyPress:    " & ex.Message)
        End Try
    End Sub

    Private Sub txtFromDatasheet_TextChanged(sender As Object, e As EventArgs) Handles txtFromDatasheet.TextChanged
        Try
            If PrintFormLoad = True Then
                If Not txtFromDatasheet.Text = "" Then
                    If txtFromDatasheet.Text > 0 And txtFromDatasheet.Text <= (Database_LastRow - 1) Then
                        PrintFromRecordNo = txtFromDatasheet.Text
                    Else
                        MsgBox("Invalid record No", , "Alert!")
                    End If
                Else
                    MsgBox("From record number not entered")
                End If
            End If
        Catch ex As Exception
            MsgBox("txtFromDatasheet_TextChanged:    " & ex.Message)
        End Try
    End Sub


    Private Sub txtToDatasheet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtToDatasheet.KeyPress
        Try

            If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789").IndexOf(e.KeyChar) = -1) Then
                MsgBox("Please enter integers only")
                e.Handled = True

            End If

        Catch ex As Exception
            MsgBox("ToText KeyPress:    " & ex.Message)
        End Try
    End Sub

    Private Sub txtToDatasheet_TextChanged(sender As Object, e As EventArgs) Handles txtToDatasheet.TextChanged
        Try
            If PrintFormLoad = True Then
                If txtFromDatasheet.Text = "" Then
                    MsgBox("Enter From record number first! ", , "Alert!")
                Else
                    If Not txtToDatasheet.Text = "" Then
                        If txtToDatasheet.Text <= (Database_LastRow - 1) And txtToDatasheet.Text > 0 Then
                            PrintToRecordNo = txtToDatasheet.Text
                        Else
                            MsgBox("Invalid record No", , "Alert!")
                        End If
                    Else
                        MsgBox("To Record number not entered", , "Alert!")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("txtToDatasheet_TextChanged:    " & ex.Message)
        End Try


    End Sub

    Private Sub frmPrintDatasheet_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PrintFromRecordNo = txtFromDatasheet.Text
        PrintToRecordNo = txtToDatasheet.Text
    End Sub

    Private Sub frmPrintDatasheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        PrintFormLoad = False
        ConfirmedPrinting = False
        txtFromDatasheet.Text = 1
        txtToDatasheet.Text = Database_LastRow - 1
        lblPrintRecords.Text = Database_Rowno - 1 & "/" & Database_LastRow - 1
        PrintFormLoad = True

    End Sub

    Private Sub btnDatasheetClose_Click(sender As Object, e As EventArgs) Handles btnDatasheetClose.Click
        Me.Close()

    End Sub
End Class