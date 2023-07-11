﻿Public Class frmUserNotes

    Private Sub frmUserNotes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            UserNotes1 = txtUserNotes1.Text
            UserNotes2 = txtUserNotes2.Text
            UserNotes3 = txtUserNotes3.Text
        Catch ex As Exception
            MsgBox("frmUserNotes_FormClosing: " & ex.Message)
        End Try

    End Sub

    Private Sub frmUserNotes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            txtUserNotes1.Text = UserNotes1
            txtUserNotes2.Text = UserNotes2
            txtUserNotes3.Text = UserNotes3


        Catch ex As Exception
            MsgBox("frmUserNotes_Load: " & ex.Message)
        End Try


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub txtUserNotes1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserNotes1.KeyPress, txtUserNotes2.KeyPress, txtUserNotes3.KeyPress
       Try
                If e.KeyChar = ChrW(Keys.Enter) Then
                    e.Handled = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
    End Sub

End Class