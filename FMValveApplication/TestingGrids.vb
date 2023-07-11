Public Class frmTestingGrids
    Public PR11, PR12, PR13, PR21, PR22, PR23, PR31, PR32, PR33 As Single
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
    

    Private Sub frmTestingGrids_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Dt_DisplayBaffles As DataTable
        '   DGVPressures = New DataGridView

        Try


            Dt_DisplayBaffles = New System.Data.DataTable
            'Columns -  InletPressureCase1,2,3,OutletPressure Case 1,2,3
            Dt_DisplayBaffles.Columns.Add("Baffle", GetType(String))
            Dt_DisplayBaffles.Columns.Add("Kv", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("P1Case1", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("P2Case1", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("PrRatio1", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("Noise1", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("P1Case2", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("P2Case2", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("PrRatio2", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("Noise2", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("P1Case3", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("P2Case3", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("PrRatio3", GetType(Single))
            Dt_DisplayBaffles.Columns.Add("Noise3", GetType(Single))

            Dt_DisplayBaffles.Rows.Add(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
            Dt_DisplayBaffles.Rows.Add(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
            Dt_DisplayBaffles.Rows.Add(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)



            'AttneuatedNoiseLevelCase1 = 10 * Math.Log10((MFac_PR3 * Math.Pow(10, (DT_NoiseAttenuation.Rows(0).Item(0) / 10))) + (MFac_PR2 * Math.Pow(10, (DT_NoiseAttenuation.Rows(1).Item(0) / 10))) + (MFac_PR1 * Math.Pow(10, (DT_NoiseAttenuation.Rows(2).Item(0) / 10))) + (MFac_Cage * Math.Pow(10, ((DT_NoiseAttenuation.Rows(3).Item(0) - DeltaLPE_Resistance) / 10))))
            'AttneuatedNoiseLevelCase2 = 10 * Math.Log10((MFac_PR3 * Math.Pow(10, (DT_NoiseAttenuation.Rows(0).Item(1) / 10))) + (MFac_PR2 * Math.Pow(10, (DT_NoiseAttenuation.Rows(1).Item(1) / 10))) + (MFac_PR1 * Math.Pow(10, (DT_NoiseAttenuation.Rows(2).Item(1) / 10))) + (MFac_Cage * Math.Pow(10, ((DT_NoiseAttenuation.Rows(3).Item(1) - DeltaLPE_Resistance) / 10))))
            'AttneuatedNoiseLevelCase3 = 10 * Math.Log10((MFac_PR3 * Math.Pow(10, (DT_NoiseAttenuation.Rows(0).Item(2) / 10))) + (MFac_PR2 * Math.Pow(10, (DT_NoiseAttenuation.Rows(1).Item(2) / 10))) + (MFac_PR1 * Math.Pow(10, (DT_NoiseAttenuation.Rows(2).Item(2) / 10))) + (MFac_Cage * Math.Pow(10, ((DT_NoiseAttenuation.Rows(3).Item(2) - DeltaLPE_Resistance) / 10))))

            DGVPressures.Visible = True

            ' DGVPressures.DataSource = DT_Baffles
            Dt_DisplayBaffles.Rows(0).Item(0) = "1"
            Dt_DisplayBaffles.Rows(0).Item(1) = BaffleKVCase1
            Dt_DisplayBaffles.Rows(0).Item(2) = DT_Baffles(2).Item(0)
            Dt_DisplayBaffles.Rows(0).Item(3) = DT_Baffles(2).Item(3)
            Dt_DisplayBaffles.Rows(0).Item(4) = (DT_Baffles(2).Item(0) - DT_Baffles(2).Item(3)) / DT_Baffles(2).Item(0)
            PR11 = Dt_DisplayBaffles.Rows(0).Item(4)


            Dt_DisplayBaffles.Rows(0).Item(5) = DT_NoiseAttenuation(2).Item(0)
            Dt_DisplayBaffles.Rows(0).Item(6) = DT_Baffles(2).Item(1)
            Dt_DisplayBaffles.Rows(0).Item(7) = DT_Baffles(2).Item(4)
            Dt_DisplayBaffles.Rows(0).Item(8) = (DT_Baffles(2).Item(1) - DT_Baffles(2).Item(4)) / DT_Baffles(2).Item(1)
            PR12 = Dt_DisplayBaffles.Rows(0).Item(8)

            Dt_DisplayBaffles.Rows(0).Item(9) = DT_NoiseAttenuation(2).Item(1)
            Dt_DisplayBaffles.Rows(0).Item(10) = DT_Baffles(2).Item(2)
            Dt_DisplayBaffles.Rows(0).Item(11) = DT_Baffles(2).Item(5)
            Dt_DisplayBaffles.Rows(0).Item(12) = (DT_Baffles(2).Item(2) - DT_Baffles(2).Item(5)) / DT_Baffles(2).Item(2)
            Dt_DisplayBaffles.Rows(0).Item(13) = DT_NoiseAttenuation(2).Item(2)
            PR13 = Dt_DisplayBaffles.Rows(0).Item(12)


            Dt_DisplayBaffles.Rows(1).Item(0) = "2"
            Dt_DisplayBaffles.Rows(1).Item(1) = BaffleKVCase2
            Dt_DisplayBaffles.Rows(1).Item(2) = DT_Baffles(1).Item(0)
            Dt_DisplayBaffles.Rows(1).Item(3) = DT_Baffles(1).Item(3)
            Dt_DisplayBaffles.Rows(1).Item(4) = (DT_Baffles(1).Item(0) - DT_Baffles(1).Item(3)) / DT_Baffles(1).Item(0)
            PR21 = Dt_DisplayBaffles.Rows(1).Item(4)

            Dt_DisplayBaffles.Rows(1).Item(5) = DT_NoiseAttenuation(1).Item(0)
            Dt_DisplayBaffles.Rows(1).Item(6) = DT_Baffles(1).Item(1)
            Dt_DisplayBaffles.Rows(1).Item(7) = DT_Baffles(1).Item(4)
            Dt_DisplayBaffles.Rows(1).Item(8) = (DT_Baffles(1).Item(1) - DT_Baffles(1).Item(4)) / DT_Baffles(1).Item(1)
            PR22 = Dt_DisplayBaffles.Rows(1).Item(8)

            Dt_DisplayBaffles.Rows(1).Item(9) = DT_NoiseAttenuation(1).Item(1)
            Dt_DisplayBaffles.Rows(1).Item(10) = DT_Baffles(1).Item(2)
            Dt_DisplayBaffles.Rows(1).Item(11) = DT_Baffles(1).Item(5)
            Dt_DisplayBaffles.Rows(1).Item(12) = (DT_Baffles(1).Item(2) - DT_Baffles(1).Item(5)) / DT_Baffles(1).Item(2)
            PR23 = Dt_DisplayBaffles.Rows(1).Item(12)
            Dt_DisplayBaffles.Rows(1).Item(13) = DT_NoiseAttenuation(1).Item(2)



            Dt_DisplayBaffles.Rows(2).Item(0) = "3"
            Dt_DisplayBaffles.Rows(2).Item(1) = BaffleKVCase3
            Dt_DisplayBaffles.Rows(2).Item(2) = DT_Baffles(0).Item(0)
            Dt_DisplayBaffles.Rows(2).Item(3) = DT_Baffles(0).Item(3)
            Dt_DisplayBaffles.Rows(2).Item(4) = (DT_Baffles(0).Item(0) - DT_Baffles(0).Item(3)) / DT_Baffles(0).Item(0)
            PR31 = Dt_DisplayBaffles.Rows(2).Item(4)
            Dt_DisplayBaffles.Rows(2).Item(5) = DT_NoiseAttenuation(0).Item(0)
            Dt_DisplayBaffles.Rows(2).Item(6) = DT_Baffles(0).Item(1)
            Dt_DisplayBaffles.Rows(2).Item(7) = DT_Baffles(0).Item(4)
            Dt_DisplayBaffles.Rows(2).Item(8) = (DT_Baffles(0).Item(1) - DT_Baffles(0).Item(4)) / DT_Baffles(0).Item(1)
            PR32 = Dt_DisplayBaffles.Rows(2).Item(4)
            Dt_DisplayBaffles.Rows(2).Item(9) = DT_NoiseAttenuation(0).Item(1)
            Dt_DisplayBaffles.Rows(2).Item(10) = DT_Baffles(0).Item(2)
            Dt_DisplayBaffles.Rows(2).Item(11) = DT_Baffles(0).Item(5)
            Dt_DisplayBaffles.Rows(2).Item(12) = (DT_Baffles(0).Item(2) - DT_Baffles(0).Item(5)) / DT_Baffles(0).Item(2)
            PR33 = Dt_DisplayBaffles.Rows(2).Item(4)
            Dt_DisplayBaffles.Rows(2).Item(13) = DT_NoiseAttenuation(0).Item(2)


            'DT_ActuatorInfo.Rows(0).Item(1) = frmValveSizing.cmbModel.Text
            'DT_ActuatorInfo.Rows(1).Item(1) = frmValveSizing.lblFinalValveSize.Text
            'DT_ActuatorInfo.Rows(2).Item(1) = Travel
            'DT_ActuatorInfo.Rows(3).Item(1) = frmValveSizing.lblFinalRating.Text
            'DT_ActuatorInfo.Rows(4).Item(1) = frmValveSizing.cmbFlowDirection.Text
            'DT_ActuatorInfo.Rows(5).Item(1) = frmValveSizing.cmbSelectedTrim.Text
            'DT_ActuatorInfo.Rows(6).Item(1) = frmValveSizing.cmbSeatDia.Text
            'DT_ActuatorInfo.Rows(7).Item(1) = StemDia
            'DT_ActuatorInfo.Rows(8).Item(1) = frmValveSizing.cmbBalancing.Text
            'DT_ActuatorInfo.Rows(9).Item(1) = frmValveSizing.cmbAirFailure.Text
            ''DT_ActuatorInfo.Rows(7).Item(1) = Math.Round(FrictionForce * 0.101972, 2)
            ''DT_ActuatorInfo.Rows(8).Item(1) = SeatingForce
            ''DT_ActuatorInfo.Rows(9).Item(1) = Math.Round(Fluidforce * 0.101972, 2)


            DGVActuatorInfo.DataSource = DT_ActuatorInfo

            DGVFlowType.DataSource = DT_Flowtype
            DGVActuatorSelect.DataSource = DT_ActuatorSelect



            'DGVPressures.Columns(0).DefaultCellStyle.BackColor = Color.Aqua
            'DGVPressures.Columns(5).DefaultCellStyle.BackColor = Color.Yellow
            'DGVPressures.Columns(9).DefaultCellStyle.BackColor = Color.Yellow
            ''DGVPressures.Columns(13).DefaultCellStyle.BackColor = Color.Yellow
            'DGVPressures.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua
            DGVPressures.DataSource = Dt_DisplayBaffles

            '    DGVTrimSelection.Columns(6).DefaultCellStyle.BackColor = Color.Yellow
            '    DGVTrimSelection.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua
            '    DGVStageNoise.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua
            '    DGVBaffleNoise.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua

        Catch ex As Exception
            MsgBox("frmTestingGrids_Load : " & "  " & ex.Message)
        End Try


    End Sub

   




    Private Sub DGVPressures_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVPressures.CellFormatting
        Try
            If (e.Value IsNot DBNull.Value) And (e.Value IsNot Nothing) Then

                If e.ColumnIndex = 4 Or e.ColumnIndex = 8 Or e.ColumnIndex = 12 Then

                    Dim RATIO As Single = Convert.ToSingle(e.Value)

                    If RATIO < 0.4 Then
                        e.CellStyle.BackColor = Color.LawnGreen
                        e.CellStyle.ForeColor = Color.Black
                        e.CellStyle.Font = New Font(DGVPressures.Font, FontStyle.Bold)
                    ElseIf RATIO > 0.4 And RATIO <= 0.45 Then
                        e.CellStyle.BackColor = Color.LightYellow
                        e.CellStyle.ForeColor = Color.Black
                        e.CellStyle.Font = New Font(DGVPressures.Font, FontStyle.Bold)
                    ElseIf RATIO > 0.45 Then
                        e.CellStyle.BackColor = Color.Red
                        e.CellStyle.ForeColor = Color.Black
                        e.CellStyle.Font = New Font(DGVPressures.Font, FontStyle.Bold)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("DGVPressures_CellFormatting : " & "  " & ex.Message)
        End Try


    End Sub

    Private Sub DGVPressures_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGVPressures.KeyPress
        e.Handled = True
    End Sub


   
   
End Class