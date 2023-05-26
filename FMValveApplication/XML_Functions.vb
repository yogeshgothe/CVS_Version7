Imports System.Xml
Imports System.IO
Public Module XML_Functions

    Public Sub SaveInXML(XMLFilename As String)
        Try
            Dim XMLDataset As New DataSet
            Dim StatusDT, CommDT, ModuleDT, MaterialsDT, AccessoriesDT As New DataTable
            Dim StatusDRow, CommDRow, MaterialsDRow, AccesoriesDRow As DataRow


            '------------------------ Add Overall Status Data in XML File ----------------
            With StatusDT.Columns
                .Add(New DataColumn("Customer"))
                .Add(New DataColumn("Project"))
                .Add(New DataColumn("OfferNo"))
                .Add(New DataColumn("Rev"))
                .Add(New DataColumn("Tag"))
                .Add(New DataColumn("Qty"))

                .Add(New DataColumn("Date"))
                .Add(New DataColumn("Time"))

                ' ***********************SERVICE CONDITIONS******************************
                .Add(New DataColumn("FluidType"))
                .Add(New DataColumn("Fluid"))
                .Add(New DataColumn("UnitsType"))
                .Add(New DataColumn("Model"))
                .Add(New DataColumn("Medium"))


                'Flowrate
                .Add(New DataColumn("FlowUnit"))
                .Add(New DataColumn("MinFlow"))
                .Add(New DataColumn("AvgFlow"))
                .Add(New DataColumn("MaxFlow"))
                'Temperature
                .Add(New DataColumn("TempUnit"))
                .Add(New DataColumn("MinTemp"))
                .Add(New DataColumn("AvgTemp"))
                .Add(New DataColumn("MaxTemp"))
                .Add(New DataColumn("PressUnit"))
                .Add(New DataColumn("MinInletPressure"))
                .Add(New DataColumn("AvgInletPressure"))
                .Add(New DataColumn("MaxInletPressure"))
                .Add(New DataColumn("MinOutletPressure"))
                .Add(New DataColumn("AvgOutletPressure"))
                .Add(New DataColumn("MaxOutletPressure"))
                .Add(New DataColumn("MinDiffPressure"))
                .Add(New DataColumn("AvgDiffPressure"))
                .Add(New DataColumn("MaxDiffPressure"))
                .Add(New DataColumn("MolecularWeightCHK"))
                .Add(New DataColumn("DensityUnit"))
                .Add(New DataColumn("MolecularWeight"))
                .Add(New DataColumn("MinDensity"))
                .Add(New DataColumn("AvgDensity"))
                .Add(New DataColumn("MaxDensity"))
                .Add(New DataColumn("ViscosityChk"))
                .Add(New DataColumn("ViscosityUnit"))
                .Add(New DataColumn("MinViscosity"))
                .Add(New DataColumn("AvgViscosity"))
                .Add(New DataColumn("MaxViscosity"))
                .Add(New DataColumn("MinToutPress"))
                .Add(New DataColumn("AvgToutPress"))
                .Add(New DataColumn("MaxToutPress"))
                .Add(New DataColumn("MinToutSatPress"))
                .Add(New DataColumn("AvgToutSatPress"))
                .Add(New DataColumn("MaxToutSatPress"))
                .Add(New DataColumn("MinCriticalPress"))
                .Add(New DataColumn("AvgCriticalPress"))
                .Add(New DataColumn("MaxCriticalPress"))
                .Add(New DataColumn("MinVapourPress"))
                .Add(New DataColumn("AvgVapourPress"))
                .Add(New DataColumn("MaxVapourPress"))
                .Add(New DataColumn("MinCompressibility"))
                .Add(New DataColumn("AvgCompressibility"))
                .Add(New DataColumn("MaxCompressibility"))
                .Add(New DataColumn("MinPressRatio"))
                .Add(New DataColumn("AvgPressRatio"))
                .Add(New DataColumn("MaxPressRatio"))
                .Add(New DataColumn("MinSpecificHeat"))
                .Add(New DataColumn("AvgSpecificHeat"))
                .Add(New DataColumn("MaxSpecificHeat"))
                .Add(New DataColumn("MinFlash%"))
                .Add(New DataColumn("AvgFlash%"))
                .Add(New DataColumn("MaxFlash%"))
            End With

            StatusDRow = StatusDT.NewRow
            Call WriteSystemData(StatusDRow)
            StatusDT.Rows.Add(StatusDRow)


            '----------Add Ratings Pipe Size and Valve Size Parameters  ------------
            With CommDT.Columns
                .Add(New DataColumn("Material"))
                .Add(New DataColumn("DesignPressure"))
                .Add(New DataColumn("DesignTemperature"))
                .Add(New DataColumn("SuggRating"))
                .Add(New DataColumn("AVlRating"))
                .Add(New DataColumn("SelRating"))
                .Add(New DataColumn("SizeUnits"))
                .Add(New DataColumn("InletPipe"))
                .Add(New DataColumn("SuggOutletPipe"))
                .Add(New DataColumn("AvlOutletPipe"))
                .Add(New DataColumn("AvlSchedule"))
                .Add(New DataColumn("SelOultetPipe"))

                .Add(New DataColumn("TrimStyle"))
                .Add(New DataColumn("Vel_MachNo"))
                .Add(New DataColumn("FlowDir"))
                .Add(New DataColumn("Charachterstics"))                    ' JAN-16 : Add Sensor OK Relay parameters
                .Add(New DataColumn("Trim%"))
                .Add(New DataColumn("SuggKV"))
                .Add(New DataColumn("SuggValveSize"))
                .Add(New DataColumn("AvlKV"))
                .Add(New DataColumn("AvlValveSize"))
                .Add(New DataColumn("SelKV"))
                .Add(New DataColumn("SelValveSize"))

                '----------Add Ratings Pipe Size and Valve Size Parameters  ------------
                .Add(New DataColumn("BonnetType"))
                .Add(New DataColumn("EndConn"))
                .Add(New DataColumn("ActType"))
                .Add(New DataColumn("Balancing"))
                .Add(New DataColumn("AirFailure"))
                .Add(New DataColumn("Leakage"))
                .Add(New DataColumn("Packing"))
                .Add(New DataColumn("Sealing"))
                .Add(New DataColumn("DPShutoff"))
                .Add(New DataColumn("AirPressUnits"))
                .Add(New DataColumn("AirPressure"))
                .Add(New DataColumn("SeatDiameter"))
                .Add(New DataColumn("Force"))
                .Add(New DataColumn("HandWheel"))

                .Add(New DataColumn("SuggActuator"))
                .Add(New DataColumn("AvlActuator"))
                .Add(New DataColumn("SelActuator"))
                
            End With
            CommDRow = CommDT.NewRow
            Call WriteCommData(CommDRow)
            CommDT.Rows.Add(CommDRow)


            With MaterialsDT.Columns
                .Add(New DataColumn("Body"))
                .Add(New DataColumn("Plug"))
                .Add(New DataColumn("Seat"))
                .Add(New DataColumn("Top"))
                .Add(New DataColumn("Gasket"))
                .Add(New DataColumn("Painting"))
               

            End With
            MaterialsDRow = MaterialsDT.NewRow
            Call WriteMaterialsData(MaterialsDRow)
            MaterialsDT.Rows.Add(MaterialsDRow)


            With AccessoriesDT.Columns
                .Add(New DataColumn("Positioner"))
                .Add(New DataColumn("SOV"))
                .Add(New DataColumn("AFR"))
                .Add(New DataColumn("ALR"))
                .Add(New DataColumn("LimitSwitch"))
                .Add(New DataColumn("VolBooster"))
                .Add(New DataColumn("PosnTransmitter"))
                .Add(New DataColumn("VTank"))
                .Add(New DataColumn("Roboter"))
                .Add(New DataColumn("ItoP"))
                .Add(New DataColumn("QuickEx"))
                .Add(New DataColumn("Certification"))

            
            End With
            AccesoriesDRow = AccessoriesDT.NewRow
            Call WriteAccessoriesData(AccesoriesDRow)
            AccessoriesDT.Rows.Add(AccesoriesDRow)

            XMLDataset.Tables.Add(StatusDT)
            XMLDataset.Tables.Add(CommDT)
            XMLDataset.Tables.Add(MaterialsDT)
            XMLDataset.Tables.Add(AccessoriesDT)

            XMLDataset.Tables(0).TableName = "FIELD_PARAMETERS"
            XMLDataset.Tables(1).TableName = "CALCULATION_PARAMETERS"
            XMLDataset.Tables(2).TableName = "Materials_Parameters"
            XMLDataset.Tables(3).TableName = "Accessories_Parameters"

            XMLDataset.DataSetName = "SIZEValv"

            '-------Save in XML File ------------
            XMLDataset.WriteXml(XMLFilename)

            MsgBox("Successfully saved data into XML file", MsgBoxStyle.Information, "Save in XML ..")

        Catch ex As Exception
            MsgBox("Exception occurred at (" & Reflection.MethodInfo.GetCurrentMethod.Name & ") : " & ex.Message, MsgBoxStyle.Critical, "SIZEValv Config Software")
        End Try
    End Sub

    Private Sub WriteSystemData(ByVal DRow As DataRow)
        Try

            DRow("Customer") = frmCustomerDetails.txtCustomer.Text
            DRow("Project") = frmCustomerDetails.txtProject.Text
            DRow("OfferNo") = frmCustomerDetails.txtOffferNo.Text
            DRow("Rev") = frmCustomerDetails.txtRevNo.Text
            DRow("Tag") = frmCustomerDetails.txtTagNo.Text
            DRow("Qty") = frmCustomerDetails.txtQty.Text
            DRow("Date") = Now.Date
            DRow("Time") = Now.Hour & ":" & Now.Minute
            DRow("FluidType") = frmValveSizing.cmbFluidType.Text
            DRow("Fluid") = frmValveSizing.cmbFluid.Text
            DRow("UnitsType") = frmValveSizing.cmbUnitsType.Text
            DRow("Model") = frmValveSizing.cmbModel.Text
            DRow("Medium") = frmValveSizing.txtMedium.Text
            DRow("FlowUnit") = frmValveSizing.cmbFlowrate.Text
            DRow("MinFlow") = frmValveSizing.txtFlowrateCase1.Text
            DRow("AvgFlow") = frmValveSizing.txtFlowrateCase2.Text
            DRow("MaxFlow") = frmValveSizing.txtFlowrateCase3.Text
            DRow("TempUnit") = frmValveSizing.cmbTemperatureUnits.Text
            DRow("MinTemp") = frmValveSizing.txtInletTemperatureCase1.Text
            DRow("AvgTemp") = frmValveSizing.txtInletTemperatureCase2.Text
            DRow("MaxTemp") = frmValveSizing.txtInletTemperatureCase3.Text
            DRow("PressUnit") = frmValveSizing.cmbPressureUnits.Text

            DRow("MinInletPressure") = frmValveSizing.txtInletPressureCase1.Text
            DRow("AvgInletPressure") = frmValveSizing.txtInletPressureCase2.Text
            DRow("MaxInletPressure") = frmValveSizing.txtInletPressureCase3.Text
            DRow("MinOutletPressure") = frmValveSizing.txtOutletPressure1.Text
            DRow("AvgOutletPressure") = frmValveSizing.txtOutletPressure2.Text
            DRow("MaxOutletPressure") = frmValveSizing.txtOutletPressure3.Text
            DRow("MinDiffPressure") = frmValveSizing.txtPressureDropCase1.Text
            DRow("AvgDiffPressure") = frmValveSizing.txtPressureDropCase2.Text
            DRow("MaxDiffPressure") = frmValveSizing.txtPressureDropCase3.Text
            DRow("MolecularWeightCHK") = frmValveSizing.chkMolecularWeight.Checked
            DRow("DensityUnit") = frmValveSizing.cmbDensityUnits.Text

            DRow("MolecularWeight") = frmValveSizing.txtMolecularWeight.Text
            DRow("MinDensity") = FinalDensityCase1

            DRow("AvgDensity") = FinalDensityCase2
            DRow("MaxDensity") = FinalDensityCase3
            DRow("ViscosityChk") = frmValveSizing.chkViscosity.Checked
            DRow("ViscosityUnit") = frmValveSizing.cmbViscosityUnits.Text
            DRow("MinViscosity") = FinalViscosityCase1
            DRow("AvgViscosity") = FinalViscosityCase2
            DRow("MaxViscosity") = FinalViscosityCase3
            DRow("MinToutPress") = ToutPressureCase1
            DRow("AvgToutPress") = ToutPressureCase2
            DRow("MaxToutPress") = ToutPressureCase3

            DRow("MinToutSatPress") = ToutsatPressureCase1
            DRow("AvgToutSatPress") = ToutsatPressureCase2
            DRow("MaxToutSatPress") = ToutsatPressureCase3
            DRow("MinCriticalPress") = frmValveSizing.txtCriticalPressureCase1.Text
            DRow("AvgCriticalPress") = frmValveSizing.txtCriticalPressureCase2.Text
            DRow("MaxCriticalPress") = frmValveSizing.txtCriticalPressureCase3.Text
            DRow("MinVapourPress") = frmValveSizing.txtVapourPressureCase1.Text
            DRow("AvgVapourPress") = frmValveSizing.txtVapourPressureCase2.Text
            DRow("MaxVapourPress") = frmValveSizing.txtVapourPressureCase3.Text

            DRow("MinCompressibility") = Zcase1
            DRow("AvgCompressibility") = Zcase2
            DRow("MaxCompressibility") = Zcase3
            DRow("MinPressRatio") = Xcase1
            DRow("AvgPressRatio") = Xcase2
            DRow("MaxPressRatio") = Xcase3

            DRow("MinSpecificHeat") = Kcase1
            DRow("AvgSpecificHeat") = Kcase2
            DRow("MaxSpecificHeat") = Kcase3
            DRow("MinFlash%") = DrynessFraction_LiquidCase1

            DRow("AvgFlash%") = DrynessFraction_LiquidCase2
            DRow("MaxFlash%") = DrynessFraction_LiquidCase3



        Catch ex As Exception
            MsgBox("Exception occurred at (" & Reflection.MethodInfo.GetCurrentMethod.Name & ") : " & ex.Message, MsgBoxStyle.Critical, "Vibtrans Config Software")
        End Try
    End Sub

    Private Sub WriteCommData(ByVal DRow As DataRow)
        Try

            DRow("Material") = frmValveSizing.cmbMOC.Text
            DRow("DesignPressure") = frmValveSizing.txtDesignPressureInlet.Text
            DRow("DesignTemperature") = frmValveSizing.txtDesignTemperatureInlet.Text
            DRow("SuggRating") = frmValveSizing.lblSuggestedRating.Text
            DRow("AVlRating") = frmValveSizing.cmbSuggestedRating.Text
            DRow("SelRating") = frmValveSizing.lblFinalRating.Text
            DRow("SizeUnits") = frmValveSizing.cmbAreaunits.Text
            DRow("InletPipe") = frmValveSizing.cmbInletPipeSize.Text
            DRow("SuggOutletPipe") = frmValveSizing.lblSuggPipeSize.Text
            DRow("AvlOutletPipe") = frmValveSizing.cmbPipeDia.Text
            DRow("AvlSchedule") = frmValveSizing.lblFinalOutletPipe.Text
            DRow("SelOultetPipe") = frmValveSizing.cmbSchedule.Text
            DRow("TrimStyle") = frmValveSizing.Label26.Text
            DRow("Vel_MachNo") = frmValveSizing.cmbVelocityRule.Text
            DRow("FlowDir") = frmValveSizing.cmbFlowDirection.Text

            DRow("Charachterstics") = frmValveSizing.cmbCharacterstics.Text
            DRow("Trim%") = frmValveSizing.cmbKVseries.Text
            DRow("SuggKV") = frmValveSizing.txtSuggestedKV.Text
            DRow("SuggValveSize") = frmValveSizing.txtSuggestedValveSize.Text
            DRow("AvlKV") = frmValveSizing.cmbKVOverride.Text


            DRow("AvlValveSize") = frmValveSizing.cmbValveSizeOverride.Text
            DRow("SelKV") = frmValveSizing.lblKVMaxValue.Text
            DRow("SelValveSize") = frmValveSizing.lblFinalValveSize.Text
            DRow("BonnetType") = frmValveSizing.cmbBonnetType.Text
            DRow("EndConn") = frmValveSizing.cmbEndConnection.Text
            DRow("ActType") = frmValveSizing.cmbActuatorType.Text

            'COM Module RTC Data
            DRow("Balancing") = frmValveSizing.cmbBalancing.Text
            DRow("AirFailure") = frmValveSizing.cmbAirFailure.Text
            DRow("Leakage") = frmValveSizing.cmbLeakage.Text
            DRow("Packing") = frmValveSizing.cmbPacking.Text
            DRow("Sealing") = frmValveSizing.cmbSealing.Text
            DRow("DPShutoff") = frmValveSizing.txtDPShutoff.Text

            DRow("AirPressUnits") = frmValveSizing.cmbAirPressureUnits.Text
            DRow("AirPressure") = frmValveSizing.txtAirPressure.Text
            DRow("SeatDiameter") = frmValveSizing.lblSeatDia.Text
            DRow("Force") = frmValveSizing.lblFinalForce.Text
            DRow("HandWheel") = frmValveSizing.cmbHandwheel.Text
            DRow("SuggActuator") = frmValveSizing.txtSuggActuator.Text
            DRow("AvlActuator") = frmValveSizing.cmbSelectActuator.Text
            DRow("SelActuator") = frmValveSizing.lblFinalActuator.Text


        Catch ex As Exception
            MsgBox("Exception occurred at (" & Reflection.MethodInfo.GetCurrentMethod.Name & ") : " & ex.Message, MsgBoxStyle.Critical, "SIZEValv Config Software")
        End Try
    End Sub
    Private Sub WriteMaterialsData(ByVal DRow As DataRow)
        Try

            DRow("Body") = BodyMaterial
            DRow("Plug") = Plug
            DRow("Seat") = Seat
            DRow("Top") = TopMaterials
            DRow("Gasket") = Gasket
            DRow("Painting") = Painting



        Catch ex As Exception
            MsgBox("Exception occurred at (" & Reflection.MethodInfo.GetCurrentMethod.Name & ") : " & ex.Message, MsgBoxStyle.Critical, "Vibtrans Config Software")
        End Try
    End Sub
    Private Sub WriteAccessoriesData(ByVal DRow As DataRow)
        Try

            DRow("Positioner") = Positioner
            DRow("SOV") = Sov
            DRow("AFR") = AFR
            DRow("ALR") = ALR
            DRow("LimitSwitch") = LimitSwitch
            DRow("VolBooster") = VolBooster
            DRow("PosnTransmitter") = PosnTrans
            DRow("VTank") = VTank
            DRow("Roboter") = Roborter
            DRow("ItoP") = ItoP
            DRow("QuickEx") = QEV
            DRow("Certification") = Certification

        Catch ex As Exception
            MsgBox("Exception occurred at (" & Reflection.MethodInfo.GetCurrentMethod.Name & ") : " & ex.Message, MsgBoxStyle.Critical, "SIZEValv Config Software")
        End Try
    End Sub


    Public Sub ReadXML(XMLFileName As String)
        Try
            Dim xmlFile As XmlReader
            xmlFile = XmlReader.Create(XMLFileName, New XmlReaderSettings())
            Dim ReadDS As New DataSet
            Dim ReadRow As DataRow
            ReadDS.ReadXml(xmlFile)

            If ReadDS.Tables(0).TableName = "FIELD_PARAMETERS" Then ' And ReadDS.Tables.Count = 3 Then
                ReadRow = ReadDS.Tables("FIELD_PARAMETERS").Rows(0)
                ReadFieldData(ReadRow)

                ReadRow = ReadDS.Tables("CALCULATION_PARAMETERS").Rows(0)
                ReadValveSizeData(ReadRow)
                ReadRow = ReadDS.Tables("Materials_Parameters").Rows(0)
                ReadMaterialsData(ReadRow)
                ReadRow = ReadDS.Tables("Accessories_Parameters").Rows(0)
                ReadAccesoriesData(ReadRow)
                xmlFile.Close()
                MsgBox("Successfully read data from XML file.", MsgBoxStyle.Information, "Read from XML ..")            ' Temporary Blocked
            Else
                MsgBox("The file you are trying to open is not the SIZEValv Configuration file or is corrupted.", MsgBoxStyle.Exclamation, "Open Configuration File..")
                XMLFileName = ""
            End If

        Catch ex As Exception
            MsgBox("Exception occurred at (" & Reflection.MethodInfo.GetCurrentMethod.Name & ") : " & ex.Message, MsgBoxStyle.Critical, "SIZEValv Config Software")
        End Try
    End Sub

    Private Sub ReadValveSizeData(ByVal DRow As DataRow)
        Try

            Dim send As Object
            Dim e As EventArgs
            frmValveSizing.cmbMOC.Text = DRow("Material")
            frmValveSizing.txtDesignPressureInlet.Text = DRow("DesignPressure")
            FinalDesignPressureInlet = DRow("DesignPressure")
            frmValveSizing.txtDesignTemperatureInlet.Text = DRow("DesignTemperature")
            FinalDesignTemperatureInlet = DRow("DesignTemperature")

            frmValveSizing.lblSuggestedRating.Text = DRow("SuggRating")
            SuggestedRating = DRow("SuggRating")

            frmValveSizing.cmbSuggestedRating.Text = DRow("AVlRating")
            frmValveSizing.lblFinalRating.Text = DRow("SelRating")
            frmValveSizing.cmbAreaunits.Text = DRow("SizeUnits")
            frmValveSizing.cmbInletPipeSize.Text = DRow("InletPipe")
            frmValveSizing.lblSuggPipeSize.Text = DRow("SuggOutletPipe")
            frmValveSizing.cmbPipeDia.Text = DRow("AvlOutletPipe")
            frmValveSizing.lblFinalOutletPipe.Text = DRow("AvlSchedule")
            frmValveSizing.cmbSchedule.Text = DRow("SelOultetPipe")
            frmValveSizing.Label26.Text = DRow("TrimStyle")
            frmValveSizing.cmbVelocityRule.Text = DRow("Vel_MachNo")
            frmValveSizing.cmbFlowDirection.Text = DRow("FlowDir")
            frmValveSizing.cmbCharacterstics.Text = DRow("Charachterstics")
            frmValveSizing.cmbKVseries.Text = DRow("Trim%")
            frmValveSizing.txtSuggestedKV.Text = DRow("SuggKV")
            frmValveSizing.txtSuggestedValveSize.Text = DRow("SuggValveSize")
            frmValveSizing.cmbKVOverride.Text = DRow("AvlKV")


            frmValveSizing.cmbValveSizeOverride.Text = DRow("AvlValveSize")
            frmValveSizing.lblKVMaxValue.Text = DRow("SelKV")
            frmValveSizing.lblFinalValveSize.Text = DRow("SelValveSize")
            frmValveSizing.cmbBonnetType.Text = DRow("BonnetType")
            frmValveSizing.cmbEndConnection.Text = DRow("EndConn")
            frmValveSizing.cmbActuatorType.Text = DRow("ActType")


            frmValveSizing.cmbBalancing.Text = DRow("Balancing")
            frmValveSizing.cmbAirFailure.Text = DRow("AirFailure")
            frmValveSizing.cmbLeakage.Text = DRow("Leakage")
            frmValveSizing.cmbPacking.Text = DRow("Packing")
            frmValveSizing.cmbSealing.Text = DRow("Sealing")
            frmValveSizing.txtDPShutoff.Text = DRow("DPShutoff")

            frmValveSizing.cmbAirPressureUnits.Text = DRow("AirPressUnits")
            frmValveSizing.txtAirPressure.Text = DRow("AirPressure")
            frmValveSizing.lblSeatDia.Text = DRow("SeatDiameter")
            frmValveSizing.lblFinalForce.Text = DRow("Force")
            frmValveSizing.cmbHandwheel.Text = DRow("HandWheel")
            frmValveSizing.txtSuggActuator.Text = DRow("SuggActuator")
            frmValveSizing.cmbSelectActuator.Text = DRow("AvlActuator")
            frmValveSizing.lblFinalActuator.Text = DRow("SelActuator")




        Catch ex As Exception
            MsgBox("Exception occurred at (" & Reflection.MethodInfo.GetCurrentMethod.Name & ") : " & ex.Message, MsgBoxStyle.Critical, "SIZEValv Config Software")
        End Try
    End Sub

    Private Sub ReadFieldData(ByVal DRow As DataRow)
        '   Try


        frmValveSizing.cmbFluidType.Text = DRow("FluidType")
        frmValveSizing.cmbFluid.Text = DRow("Fluid")
        frmValveSizing.cmbUnitsType.Text = DRow("UnitsType")
        frmValveSizing.cmbModel.Text = DRow("Model")
        frmValveSizing.txtMedium.Text = DRow("Medium")

        'taken later because values reset when Fluid Type Changes 
        frmCustomerDetails.txtCustomer.Text = DRow("Customer")

        frmCustomerDetails.txtProject.Text = DRow("Project")
        frmCustomerDetails.txtOffferNo.Text = DRow("OfferNo")

        frmCustomerDetails.txtRevNo.Text = DRow("Rev")
        frmCustomerDetails.txtTagNo.Text = DRow("Tag")
        frmCustomerDetails.txtQty.Text = DRow("Qty")

        frmValveSizing.cmbFlowrate.Text = DRow("FlowUnit")
        frmValveSizing.txtFlowrateCase1.Text = DRow("MinFlow")
        frmValveSizing.txtFlowrateCase2.Text = DRow("AvgFlow")
        frmValveSizing.txtFlowrateCase3.Text = DRow("MaxFlow")


        'FinalFlowrateCase1 = DRow("MinFlow")
        'FinalFlowrateCase2 = DRow("AvgFlow")
        'FinalFlowrateCase3 = DRow("MaxFlow")



        frmValveSizing.cmbPressureUnits.Text = DRow("PressUnit")

        FinalInletPressureCase1 = CSng(DRow("MinInletPressure"))
        FinalInletPressureCase2 = CSng(DRow("AvgInletPressure"))
        FinalInletPressureCase3 = CSng(DRow("MaxInletPressure"))
        frmValveSizing.txtInletPressureCase1.Text = DRow("MinInletPressure")
        frmValveSizing.txtInletPressureCase2.Text = DRow("AvgInletPressure")
        frmValveSizing.txtInletPressureCase3.Text = DRow("MaxInletPressure")


        FinalOutletPressureCase1 = CSng(DRow("MinOutletPressure"))
        FinalOutletPressureCase2 = CSng(DRow("AvgOutletPressure"))
        FinaloutletPressureCase3 = CSng(DRow("MaxOutletPressure"))
        frmValveSizing.txtOutletPressure1.Text = DRow("MinOutletPressure")
        frmValveSizing.txtOutletPressure2.Text = DRow("AvgOutletPressure")
        frmValveSizing.txtOutletPressure3.Text = DRow("MaxOutletPressure")

        FinalPressureDropCase1 = CSng(DRow("MinDiffPressure"))
        FinalPressureDropCase2 = CSng(DRow("AvgDiffPressure"))
        FinalPressureDropCase3 = CSng(DRow("MaxDiffPressure"))
        frmValveSizing.txtPressureDropCase1.Text = DRow("MinDiffPressure")
        frmValveSizing.txtPressureDropCase2.Text = DRow("AvgDiffPressure")
        frmValveSizing.txtPressureDropCase3.Text = DRow("MaxDiffPressure")

        frmValveSizing.cmbTemperatureUnits.Text = DRow("TempUnit")
        FinalInletTemperatureCase1 = CSng(DRow("MinTemp"))
        FinalInletTemperatureCase2 = CSng(DRow("AvgTemp"))
        FinalInletTemperatureCase3 = CSng(DRow("MaxTemp"))
        frmValveSizing.txtInletTemperatureCase1.Text = DRow("MinTemp")
        frmValveSizing.txtInletTemperatureCase2.Text = DRow("AvgTemp")
        frmValveSizing.txtInletTemperatureCase3.Text = DRow("MaxTemp")

        frmValveSizing.chkMolecularWeight.Checked = DRow("MolecularWeightCHK")
        frmValveSizing.cmbDensityUnits.Text = DRow("DensityUnit")

        frmValveSizing.txtMolecularWeight.Text = DRow("MolecularWeight")

        FinalDensityCase1 = CSng(DRow("MinDensity"))
        FinalDensityCase2 = CSng(DRow("AvgDensity"))
        FinalDensityCase3 = CSng(DRow("MaxDensity"))
        frmValveSizing.txtDensityCase1.Text = DRow("MinDensity")
        frmValveSizing.txtDensityCase2.Text = DRow("AvgDensity")
        frmValveSizing.txtDensityCase3.Text = DRow("MaxDensity")


        frmValveSizing.chkViscosity.Checked = DRow("ViscosityChk")
        frmValveSizing.cmbViscosityUnits.Text = DRow("ViscosityUnit")
        FinalViscosityCase1 = CSng(DRow("MinViscosity"))
        FinalViscosityCase2 = CSng(DRow("AvgViscosity"))
        FinalViscosityCase3 = CSng(DRow("MaxViscosity"))

        frmValveSizing.txtViscosityCase1.Text = DRow("MinViscosity")
        frmValveSizing.txtViscosityCase2.Text = DRow("AvgViscosity")
        frmValveSizing.txtViscosityCase3.Text = DRow("MaxViscosity")

        ToutPressureCase1 = CSng(DRow("MinToutPress"))
        frmValveSizing.txtTOutPressureCase1.Text = ToutPressureCase1
        ToutPressureCase2 = CSng(DRow("AvgToutPress"))

        ToutPressureCase3 = CSng(DRow("MaxToutPress"))

        frmValveSizing.txtTsatoutPressureCase1.Text = DRow("MinToutSatPress")
        frmValveSizing.txtTsatoutPressureCase2.Text = DRow("AvgToutSatPress")
        frmValveSizing.txtTsatoutPressureCase3.Text = DRow("MaxToutSatPress")

        FinalCriticalPressureCase1 = CSng(DRow("MinCriticalPress"))
        FinalCriticalPressureCase2 = CSng(DRow("AvgCriticalPress"))
        FinalCriticalPressureCase3 = CSng(DRow("MaxCriticalPress"))
        frmValveSizing.txtCriticalPressureCase1.Text = FinalCriticalPressureCase1
        frmValveSizing.txtCriticalPressureCase2.Text = FinalCriticalPressureCase2
        frmValveSizing.txtCriticalPressureCase3.Text = FinalCriticalPressureCase3


        FinalVapourPressureCase1 = CSng(DRow("MinVapourPress"))
        FinalVapourPressureCase2 = CSng(DRow("AvgVapourPress"))
        FinalVapourPressureCase3 = CSng(DRow("MaxVapourPress"))
        frmValveSizing.txtVapourPressureCase1.Text = FinalVapourPressureCase1
        frmValveSizing.txtVapourPressureCase2.Text = FinalVapourPressureCase2
        frmValveSizing.txtVapourPressureCase3.Text = FinalVapourPressureCase3


        Zcase1 = CSng(DRow("MinCompressibility"))
        Zcase2 = CSng(DRow("AvgCompressibility"))
        Zcase3 = CSng(DRow("MaxCompressibility"))
        frmValveSizing.txtZ_Case1.Text = Zcase1
        frmValveSizing.txtZ_Case2.Text = Zcase2
        frmValveSizing.txtZ_Case3.Text = Zcase3

        Xcase1 = CSng(DRow("MinPressRatio"))
        Xcase2 = CSng(DRow("AvgPressRatio"))
        Xcase3 = CSng(DRow("MaxPressRatio"))
        frmValveSizing.txtX_Case1.Text = Xcase1
        frmValveSizing.txtX_Case2.Text = Xcase2
        frmValveSizing.txtX_Case3.Text = Xcase3


        Kcase1 = CSng(DRow("MinSpecificHeat"))
        Kcase2 = CSng(DRow("AvgSpecificHeat"))
        Kcase3 = CSng(DRow("MaxSpecificHeat"))
        frmValveSizing.txtK_Case1.Text = Kcase1
        frmValveSizing.txtK_Case2.Text = Kcase2
        frmValveSizing.txtK_Case3.Text = Kcase3


        FlashingCase1 = CSng(DRow("MinFlash%"))
        FlashingCase2 = CSng(DRow("AvgFlash%"))
        FlashingCase3 = CSng(DRow("MaxFlash%"))
        frmValveSizing.txtFlashingPercentageCase1.Text = DRow("MinFlash%")
        frmValveSizing.txtFlashingPercentageCase2.Text = DRow("AvgFlash%")
        frmValveSizing.txtFlashingPercentageCase3.Text = DRow("MaxFlash%")

        If frmValveSizing.cmbFluidType.Text = "InCompressible" Then
            FL = 0.64
        Else
            FL = 0.7
        End If
        frmValveSizing.CalculateDensity()
        Call frmValveSizing.Chokedflow(FL, FL, FL)
        Call frmValveSizing.CalculateKVCV()
        frmValveSizing.lblApproxCVCase1.Text = Math.Round((FinalKVCase1 * 1.17), 2)
        frmValveSizing.lblApproxCVCase2.Text = Math.Round((FinalKVCase2 * 1.17), 2)
        frmValveSizing.lblApproxCVCase3.Text = Math.Round((FinalKVCase3 * 1.17), 2)
        frmValveSizing.lblKVCase1.Text = Math.Round(FinalKVCase1, 2)
        frmValveSizing.lblKVCase2.Text = Math.Round(FinalKVCase2, 2)
        frmValveSizing.lblKVCase3.Text = Math.Round(FinalKVCase3, 2)

        '**********************************************************************************
        '' Now.Date =  DRow("Date") 
        ''DRow("Time") = Now.Hour & ":" & Now.Minute



        ' Catch ex As Exception
        '   MsgBox("Exception occurred at (" & Reflection.MethodInfo.GetCurrentMethod.Name & ") : " & ex.Message, MsgBoxStyle.Critical, "Vibtrans Config Software")
        '  End Try
    End Sub

    Private Sub ReadMaterialsData(ByVal DRow As DataRow)
        Try
            BodyMaterial = DRow("Body")
            Plug = DRow("Plug")
            Seat = DRow("Seat")
            TopMaterials = DRow("Top")
            Gasket = DRow("Gasket")
            Painting = DRow("Painting")

            frmMaterials.cmbBodyMaterial.Text = BodyMaterial
            frmMaterials.cmbPlug.Text = Plug
            frmMaterials.cmbSeat.Text = Seat
            frmMaterials.cmbTopMaterials.Text = TopMaterials
            frmMaterials.cmbGasket.Text = Gasket
            frmMaterials.cmbPainitng.Text = Painting


        Catch ex As Exception
            MsgBox("Exception occurred at (" & Reflection.MethodInfo.GetCurrentMethod.Name & ") : " & ex.Message, MsgBoxStyle.Critical, "SIZEValv Config Software")
        End Try
    End Sub
    Private Sub ReadAccesoriesData(ByVal DRow As DataRow)
        Try

            Positioner = DRow("Positioner")
            Sov = DRow("SOV")
            AFR = DRow("AFR")
            ALR = DRow("ALR")
            LimitSwitch = DRow("LimitSwitch")
            VolBooster = DRow("VolBooster")
            PosnTrans = DRow("PosnTransmitter")
            VTank = DRow("VTank")
            Roborter = DRow("Roboter")
            ItoP = DRow("ItoP")
            QEV = DRow("QuickEx")
            Certification = DRow("Certification")

            frmAccessories.cmbPositioner.Text = Positioner
            frmAccessories.cmbSOV.Text = Sov
            frmAccessories.cmbAFR.Text = AFR
            frmAccessories.cmbALR.Text = ALR
            frmAccessories.cmbLimitSwitch.Text = LimitSwitch
            frmAccessories.cmbVolBooster.Text = VolBooster
            frmAccessories.cmbPosnTrans.Text = PosnTrans
            frmAccessories.cmbVtank.Text = VTank
            frmAccessories.cmbRobotor.Text = Roborter
            frmAccessories.cmbItoP.Text = ItoP
            frmAccessories.cmbQEV.Text = QEV
            frmAccessories.cmbCertification.Text = Certification

        Catch ex As Exception
            MsgBox("Exception occurred at (" & Reflection.MethodInfo.GetCurrentMethod.Name & ") : " & ex.Message, MsgBoxStyle.Critical, "SIZEValv Config Software")
        End Try
    End Sub
End Module

'Private Sub CreateSimulationValues()
'    With Overall_Status
'        .System_OK = True
'        .Alarm_Multiplier_ON = True
'        .Module_Bypass_ON = True
'        .Test_Mode_ON = True
'        .Sensor_Failed = True
'        .Sensor_Excitation_OFF = True
'        .Alert_Bypass_ON = True
'        .Danger_Bypass_On = True
'        .UpperCommModulePresent = True
'        .LowerCommModulePresent = True
'        .ModuleRATypePresent = True
'        .ConfigurationLocked = True
'        .LockbyEthernet = True
'        .LockbyUSB = True
'        .UpperPowerSupplyPresent = True
'        .LowerPowerSupplyPresent = True
'        .UpperPowerSupplyFail = True
'        .LowerPowerSupplyFail = True
'        .Spare_11019 = True
'        .Spare_11020 = True
'    End With

'With CommData_UInt
'    '.DeviceName = DRow("DeviceName")
'    '.StaticIP = DRow("StaticIP")
'    '.SubnetMask = DRow("SubnetMask")
'    '.Gateway = DRow("Gateway")
'    .Port1_StationID_FD = DRow("Port1_StationID_FD")
'    .Port1_BaudRate_FD = DRow("Port1_BaudRate_FD")
'    .Port1_Databits_FD = DRow("Port1_Databits_FD")
'    .Port1_Parity_FD = DRow("Port1_Parity_FD")
'    .Port1_Stopbits_FD = DRow("Port1_Stopbits_FD")
'    .Port2_StationID_HD = DRow("Port2_StationID_HD")
'    .Port2_BaudRate_HD = DRow("Port2_BaudRate_HD")
'    .Port2_Databits_HD = DRow("Port2_Databits_HD")
'    .Port2_Parity_HD = DRow("Port2_Parity_HD")
'    .Port2_Stopbits_HD = DRow("Port2_Stopbits_HD")
'    .AlarmMultiplier_Type = DRow("AlarmMultiplier_Type")
'End With

'CommData_Float.AlarmMult_AlertSP_AllCh = DRow("AlarmMult_AlertSP_AllCh")
'CommData_Float.AlarmMult_DangerSP_AllCh = DRow("AlarmMult_DangerSP_AllCh")
'' Comm_MACID = DRow("Comm_MACID")
'Comm_DeviceConnIdentifier = DRow("Comm_DeviceConnIdentifier")
'Comm_DeviceSerialNo = DRow("Comm_DeviceSerialNo")
'Comm_FirmwareVer_Major = DRow("Comm_FirmwareVer_Major")
'Comm_FirmwareVer_Minor = DRow("Comm_FirmwareVer_Minor")

''COM Module RTC Data
'ComModule_Day = DRow("ComModule_Day")
'ComModule_Month = DRow("ComModule_Month")
'ComModule_Year = DRow("ComModule_Year")
'ComModule_Hour = DRow("ComModule_Hour")
'ComModule_Minute = DRow("ComModule_Minute")
'ComModule_Second = DRow("ComModule_Second")

'For p As Int16 = 0 To 20
'    With ModuleData_Bits(ArryNo)
'        .Ch1_Alert_ON = DRow("Ch1_Alert_ON")
'        .Ch1_Danger_ON = DRow("Ch1_Danger_ON")
'        .Ch2_Alert_ON = DRow("Ch2_Alert_ON")
'        .Ch2_Danger_ON = DRow("Ch2_Danger_ON")
'        .Ch1_Sensor_Failed = DRow("Ch1_Sensor_Failed")
'        .Ch2_Sensor_Failed = DRow("Ch2_Sensor_Failed")
'        .ModulePresent = DRow("ModulePresent")
'        .ModuleAVTypePresent = DRow("ModuleAVTypePresent")
'        .ModulePMTypePresent = DRow("ModulePMTypePresent")
'        .Module_Run_Mode = DRow("Module_Run_Mode")
'        .Module_Bypass_Mode = DRow("Module_Bypass_Mode")
'        .Module_Test_Mode = DRow("Module_Test_Mode")
'        .Ch1_SensorExcitationOFF = DRow("Ch1_SensorExcitationOFF")
'        .Ch2_SensorExcitationOFF = DRow("Ch2_SensorExcitationOFF")
'        .Ch1_Enabled = DRow("Ch1_Enabled")
'        .Ch2_Enabled = DRow("Ch2_Enabled")
'        .Ch1_AlertBypassON = DRow("Ch1_AlertBypassON")
'        .Ch2_AlertBypassON = DRow("Ch2_AlertBypassON")
'        .Ch1_DangerBypassON = DRow("Ch1_DangerBypassON")
'        .Ch2_DangerBypassON = DRow("Ch2_DangerBypassON")
'    End With

'    With ModuleData_Float(ArryNo)
'        .Slot1_Ch1_VibrationValue = DRow("Slot1_Ch1_VibrationValue")
'        .Slot1_Ch2_VibrationValue = DRow("Slot1_Ch2_VibrationValue")
'        .Slot2_Ch1_VibrationValue = DRow("Slot2_Ch1_VibrationValue")
'        .Slot2_Ch2_VibrationValue = DRow("Slot2_Ch2_VibrationValue")
'    End With
'Next

'For q As Int16 = 

'End Sub



'Sub test()


'    'first let's check if there is a file MyXML.xml into our application folder
'    'if there wasn't a file something like that, then let's create a new one.

'    If IO.File.Exists("MyXML.xml") = False Then

'        'declare our xmlwritersettings object
'        Dim settings As New XmlWriterSettings()

'        'lets tell to our xmlwritersettings that it must use indention for our xml
'        settings.Indent = True

'        'lets create the MyXML.xml document, the first parameter was the Path/filename of xml file
'        ' the second parameter was our xml settings
'        Dim XmlWrt As XmlWriter = XmlWriter.Create("MyXML.xml", settings)

'        With XmlWrt

'            ' Write the Xml declaration.
'            .WriteStartDocument()

'            ' Write a comment.
'            .WriteComment("XML Database.")

'            ' Write the root element.
'            .WriteStartElement("Data")

'            ' Start our first person.
'            .WriteStartElement("Person")

'            ' The person nodes.

'            .WriteStartElement("FirstName")
'            .WriteString("Alleo")
'            .WriteEndElement()

'            .WriteStartElement("LastName")
'            .WriteString("Indong")
'            .WriteEndElement()


'            ' The end of this person.
'            .WriteEndElement()

'            ' Close the XmlTextWriter.
'            .WriteEndDocument()
'            .Close()

'        End With

'        MessageBox.Show("XML file saved.")
'    End If

'End Sub

