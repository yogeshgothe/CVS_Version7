'Imports excel = Microsoft.Office.Interop.Excel
Imports FMValveApplication_standard.Declarations
Imports System.Data
Imports System.IO
Public Class frmCopyRecord

    Private Sub frmCopyRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLastRecord.Text = "Last Record: " & Database_LastRow
        txtSourceRecord.Text = Database_Rowno
        txtDestinationRecord.Text = Database_Rowno
        SourceRecord = Database_Rowno
        DestinationRecord = Database_Rowno
    End Sub


    Private Sub txtSourceRecord_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSourceRecord.KeyPress
        Try
            If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And CType(sender, TextBox).Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
                MsgBox("Please enter integers only")
                e.Handled = True

            End If
        Catch ex As Exception
            MsgBox("txtSoureRecord_KeyPress :    " & ex.Message, , "SIZEVALV")
        End Try
    End Sub

    Private Sub txtDestinationRecord_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDestinationRecord.KeyPress
        Try
            If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And CType(sender, TextBox).Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
                MsgBox("Please enter integers only")
                e.Handled = True

            End If
        Catch ex As Exception
            MsgBox("txtDestinationRecord_KeyPress :    " & ex.Message, , "SIZEVALV")
        End Try
    End Sub


    Private Sub lblCopy_Click(sender As Object, e As EventArgs) Handles lblCopy.Click
        'Dim xlWorkbook As excel.Workbook
        'Dim xlWorkSheet As excel.Worksheet

        Try
            'With dt_OpenOffice
            '    dt_OpenOffice.Rows.Add(dt_OpenOffice.NewRow())

            If txtSourceRecord.Text = "" Then
                    MsgBox("Source Record is blank.", , "SIZEVALV - ALERT!")
                    Exit Sub
                ElseIf txtSourceRecord.Text < 1 Then
                    MsgBox("Enter higher Source record", , "SIZEVALV - ALERT!")
                    Exit Sub
                Else
                SourceRecord = (CInt(txtSourceRecord.Text))
            End If

            If txtDestinationRecord.Text = "" Then
                MsgBox("Destination Record is blank.", , "SIZEVALV - ALERT!")
                Exit Sub
            ElseIf txtDestinationRecord.Text < 2 Then
                MsgBox("Enter  higher Destination record", , "SIZEVALV - ALERT!")
                Exit Sub
            Else
                DestinationRecord = (CInt(txtDestinationRecord.Text))
            End If

            If DestinationRecord > dt_OpenOffice.Rows.Count - 1 Then
                dt_OpenOffice.Rows.Add(dt_OpenOffice.NewRow())
            End If


            If Not SourceRecord < 1 And Not DestinationRecord < 1 Then

                With dt_OpenOffice


                    For i = 0 To dt_OpenOffice.Columns.Count - 1
                        dt_OpenOffice.Rows(DestinationRecord)(i) = dt_OpenOffice.Rows(SourceRecord)(i)
                    Next

                End With
                    frmValveSizing.lblDatabaseRowNo.Text = 1 & "/" & Database_LastRow - 1
                    lblLastRecord.Text = Database_LastRow - 1
                MsgBox("Record Copied to " & (DestinationRecord))
                'xlWorkbook.Save()
                'xlWorkbook.Close()


            Else
                    MsgBox("Invalid Record Number", , "SIZEVALV - ALERT!")
                    End If
            'End With

        Catch ex As Exception
            MsgBox("lblCopy_Click : " & ex.Message, , "SIZEVALV")
        End Try

    End Sub

  
    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub
End Class