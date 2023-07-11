Public Class frmChart

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

   

    Private Sub frmChart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ChrtFlowrate.Hide()
            ChrtFlowCharac.Show()

            ChrtFlowCharac.ChartAreas(0).AxisX.Minimum = 0
            ChrtFlowCharac.ChartAreas(0).AxisX.Maximum = 100
            ChrtFlowCharac.ChartAreas(0).AxisY.Minimum = 0
            ChrtFlowCharac.ChartAreas(0).AxisY.Maximum = 100

            ChrtFlowCharac.Series(0).IsValueShownAsLabel = False

            ChrtFlowCharac.Series(0).Points.Clear()
            If frmValveSizing.cmbCharacterstics.SelectedIndex = 0 Or frmValveSizing.cmbCharacterstics.SelectedIndex = 2 Then       'Linear or On-off
                ChrtFlowCharac.Series(0).Points.AddXY(10, 10)
                ChrtFlowCharac.Series(0).Points.AddXY(20, 20)
                ChrtFlowCharac.Series(0).Points.AddXY(30, 30)
                ChrtFlowCharac.Series(0).Points.AddXY(40, 40)
                ChrtFlowCharac.Series(0).Points.AddXY(50, 50)
                ChrtFlowCharac.Series(0).Points.AddXY(60, 60)
                ChrtFlowCharac.Series(0).Points.AddXY(70, 70)
                ChrtFlowCharac.Series(0).Points.AddXY(80, 80)
                ChrtFlowCharac.Series(0).Points.AddXY(90, 90)
                ChrtFlowCharac.Series(0).Points.AddXY(100, 100)

            End If
            If frmValveSizing.cmbCharacterstics.SelectedIndex = 1 Then       'Equal Percentage
                ChrtFlowCharac.Series(0).Points.AddXY(10, 3.6)
                ChrtFlowCharac.Series(0).Points.AddXY(20, 5.2)
                ChrtFlowCharac.Series(0).Points.AddXY(30, 7.6)
                ChrtFlowCharac.Series(0).Points.AddXY(40, 10.9)
                ChrtFlowCharac.Series(0).Points.AddXY(50, 15.8)
                ChrtFlowCharac.Series(0).Points.AddXY(60, 22.9)
                ChrtFlowCharac.Series(0).Points.AddXY(70, 33.1)
                ChrtFlowCharac.Series(0).Points.AddXY(80, 47.8)
                ChrtFlowCharac.Series(0).Points.AddXY(90, 69.2)
                ChrtFlowCharac.Series(0).Points.AddXY(100, 100)

            End If
            ' ChrtFlowCharac.Series(0).IsValueShownAsLabel = True
            If frmValveSizing.cmbUnitsType.SelectedIndex = 0 And frmValveSizing.cmbUnitsType.SelectedIndex = 2 Then     ' Fpr MKS and ALL
                ChrtFlowCharac.Series(0).Points.AddXY(Math.Round(StrokeCase1, 0), Math.Round((FinalKVCase1 / FinalKVmax_ValveSize) * 100, 1))
                ChrtFlowCharac.Series(0).Points(10).Label = CStr(Math.Round(StrokeCase1, 0)) & " , " & Math.Round((FinalKVCase1 / FinalKVmax_ValveSize) * 100, 1)
                ChrtFlowCharac.Series(0).Points.AddXY(Math.Round(StrokeCase2, 0), Math.Round((FinalKVCase2 / FinalKVmax_ValveSize) * 100, 1))
                ChrtFlowCharac.Series(0).Points(11).Label = CStr(Math.Round(StrokeCase2, 0)) & " , " & Math.Round((FinalKVCase2 / FinalKVmax_ValveSize) * 100, 1)
                ChrtFlowCharac.Series(0).Points.AddXY(Math.Round(StrokeCase3, 0), Math.Round((FinalKVCase3 / FinalKVmax_ValveSize) * 100, 1))
                ChrtFlowCharac.Series(0).Points(12).Label = CStr(Math.Round(StrokeCase3, 0)) & " , " & Math.Round((FinalKVCase3 / FinalKVmax_ValveSize) * 100, 1)
            Else                                                                                                        ' For FPS
                ChrtFlowCharac.Series(0).Points.AddXY(Math.Round(StrokeCase1, 0), Math.Round((FinalKVCase1 * 1.17 / FinalKVmax_ValveSize) * 100, 1))
                ChrtFlowCharac.Series(0).Points(10).Label = CStr(Math.Round(StrokeCase1, 0)) & " , " & Math.Round((FinalKVCase1 / FinalKVmax_ValveSize) * 100, 1)
                ChrtFlowCharac.Series(0).Points.AddXY(Math.Round(StrokeCase2, 0), Math.Round((FinalKVCase2 * 1.17 / FinalKVmax_ValveSize) * 100, 1))
                ChrtFlowCharac.Series(0).Points(11).Label = CStr(Math.Round(StrokeCase2, 0)) & " , " & Math.Round((FinalKVCase2 / FinalKVmax_ValveSize) * 100, 1)
                ChrtFlowCharac.Series(0).Points.AddXY(Math.Round(StrokeCase3, 0), Math.Round((FinalKVCase3 * 1.17 / FinalKVmax_ValveSize) * 100, 1))
                ChrtFlowCharac.Series(0).Points(12).Label = CStr(Math.Round(StrokeCase3, 0)) & " , " & Math.Round((FinalKVCase3 / FinalKVmax_ValveSize) * 100, 1)
            End If





            ChrtFlowrate.Series(0).Points.Clear()

            ChrtFlowrate.Series(0).Points.AddXY(Math.Round(StrokeCase1, 0), Math.Round(FinalFlowrateCase1, 1))
            ChrtFlowrate.Series(0).Points.AddXY(Math.Round(StrokeCase2, 0), Math.Round(FinalFlowrateCase2, 1))
            ChrtFlowrate.Series(0).Points.AddXY(Math.Round(StrokeCase3, 0), Math.Round(FinalFlowrateCase3, 1))

        Catch ex As Exception
            MsgBox("DATA Incomplete, Closing Chart!!" & Chr(13) & "Chart Load : " & ex.Message)
            Me.Close()

        End Try


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try

      
        If ListBox1.SelectedIndex = 0 Then
            ChrtFlowrate.Hide()
            ChrtFlowCharac.Show()
        ElseIf ListBox1.SelectedIndex = 1 Then
            ChrtFlowCharac.Hide()
            ChrtFlowrate.Show()
        End If
        Catch ex As Exception
            MsgBox("Chart Component : " & ex.Message)
        End Try
    End Sub
End Class