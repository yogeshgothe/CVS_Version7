Imports System.IO
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Imports System.Data.SqlClient
Imports System.Deployment.Application
Public Class frmRecordsGrid
    Dim pk As Integer
    Public Sub LoadEssentials()
        LoadingForm = False
        'Dim rowno As Byte
        'Dim RemoveLineFeed As String
        Try
            '  frmWelcome.ShowDialog()
            'Call UpdateTables()
            '  lblVersion.Text = "Version No: V6.2.0 04 April 2023"
            If My.Application.IsNetworkDeployed Then
                frmValveSizing.lblVersion.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString & VersionDate
            Else
                frmValveSizing.lblVersion.Text = VersionNo & "  " & VersionDate
            End If

            If Database_Rowno > 0 Then
                frmValveSizing.lblDatabaseRowNo.Text = Database_Rowno - 1 & "/" & Database_LastRow - 1
                frmValveSizing.txtJumpToRecord.Text = Database_Rowno - 1
            Else

                frmValveSizing.lblDatabaseRowNo.Text = 1 & "/ 1"
                frmValveSizing.txtJumpToRecord.Text = 1
            End If

            'For Database and Datasheet change column nos indexing here.
            DataSection1_Field = 10
            DataSection2_MOC = 91
            DataSection3_Actuator = 133
            DataSection4_Materials = 160
            DataSection5_Output1 = 188
            DataSection6_Output2 = 231          ' Till 60 
            DataSection7_CalcValues = 301
            LastColumn_Values = 400

            '-------------------------------


            ChangingUnitsType = False

            frmValveSizing.lblToutPressure.Visible = False
            frmValveSizing.txtTOutPressureCase1.Visible = False
            frmValveSizing.txtTOutPressureCase2.Visible = False
            frmValveSizing.txtTOutPressureCase3.Visible = False

            frmValveSizing.lblTsatoutPressure.Visible = False
            frmValveSizing.txtTsatoutPressureCase1.Visible = False
            frmValveSizing.txtTsatoutPressureCase2.Visible = False
            frmValveSizing.txtTsatoutPressureCase3.Visible = False

            ToutsatPressureCase1 = 0
            ToutsatPressureCase2 = 0
            ToutsatPressureCase3 = 0


            frmValveSizing.lblK.Visible = False
            frmValveSizing.txtK_Case1.Visible = False
            frmValveSizing.txtK_Case2.Visible = False
            frmValveSizing.txtK_Case3.Visible = False

            frmValveSizing.lblZ.Visible = False
            frmValveSizing.txtZ_Case1.Visible = False
            frmValveSizing.txtZ_Case2.Visible = False
            frmValveSizing.txtZ_Case3.Visible = False

            frmValveSizing.lblX.Visible = False
            frmValveSizing.txtX_Case1.Visible = False
            frmValveSizing.txtX_Case2.Visible = False
            frmValveSizing.txtX_Case3.Visible = False

            '   lblKVerrordueToValve.Visible = False

            frmValveSizing.cmbFluidType.Items.Add("InCompressible")
            frmValveSizing.cmbFluidType.Items.Add("Compressible")


            frmValveSizing.cmbFluid.Items.Add("Standard Water")
            frmValveSizing.cmbFluid.Items.Add("Other Liquid")

            frmValveSizing.cmbUnitsType.Items.Add("MKS&SI")
            frmValveSizing.cmbUnitsType.Items.Add("FPS")
            frmValveSizing.cmbUnitsType.Items.Add("ALL")

            'GLOBE
            '   3-WAY MIX
            '   3-WAY SEP
            ' GLOBE -FORBES

            frmValveSizing.cmbModel.Items.Add("GLOBE-FORBES")
            frmValveSizing.cmbModel.Items.Add("GLOBE")
            frmValveSizing.cmbModel.Items.Add("3-WAY MIX ")
            frmValveSizing.cmbModel.Items.Add("3-WAY SEP")
            frmValveSizing.cmbModel.Items.Add("T.E. PRDS Perforated")
            frmValveSizing.cmbModel.Items.Add("B.E. PRDS Perforated")
            frmValveSizing.cmbModel.Items.Add("B.E. PRDS Parabolic")

            frmValveSizing.cmbQW.Items.Add("Q")
            frmValveSizing.cmbQW.Items.Add("W")

            'Flow Units 

            frmValveSizing.cmbFlowrate.Items.Add("m3/h")
            frmValveSizing.cmbFlowrate.Items.Add("l/h")
            frmValveSizing.cmbFlowrate.Items.Add("l/m")




            frmValveSizing.cmbPressureUnits.Items.Add("barA")
            frmValveSizing.cmbPressureUnits.Items.Add("barg")
            frmValveSizing.cmbPressureUnits.Items.Add("kg/cm2A")
            frmValveSizing.cmbPressureUnits.Items.Add("kg/cm2g")
            frmValveSizing.cmbPressureUnits.Items.Add("Pascal")



            frmValveSizing.cmbAirPressureUnits.Items.Add("barg")
            frmValveSizing.cmbAirPressureUnits.Items.Add("barA")
            frmValveSizing.cmbAirPressureUnits.Items.Add("kg/cm2A")
            frmValveSizing.cmbAirPressureUnits.Items.Add("kg/cm2g")
            frmValveSizing.cmbAirPressureUnits.Items.Add("Pascal")

            frmValveSizing.cmbCriticalPressureUnits.Items.Add("barA")
            frmValveSizing.cmbCriticalPressureUnits.Items.Add("barg")
            frmValveSizing.cmbCriticalPressureUnits.Items.Add("kg/cm2A")
            frmValveSizing.cmbCriticalPressureUnits.Items.Add("kg/cm2g")
            frmValveSizing.cmbCriticalPressureUnits.Items.Add("Pascal")



            frmValveSizing.cmbVapourPressureUnits.Items.Add("barA")
            frmValveSizing.cmbVapourPressureUnits.Items.Add("barg")
            frmValveSizing.cmbVapourPressureUnits.Items.Add("kg/cm2A")
            frmValveSizing.cmbVapourPressureUnits.Items.Add("kg/cm2g")
            frmValveSizing.cmbVapourPressureUnits.Items.Add("Pascal")

            frmValveSizing.cmbTemperatureUnits.Items.Add("°K")
            frmValveSizing.cmbTemperatureUnits.Items.Add("°C")

            frmValveSizing.cmbDensityUnits.Items.Add("Sp.Gravity")
            frmValveSizing.cmbDensityUnits.Items.Add("kg/m3")
            frmValveSizing.cmbDensityUnits.Items.Add("kg/l")

            frmValveSizing.cmbViscosityUnits.Items.Add("m2/s")
            frmValveSizing.cmbViscosityUnits.Items.Add("mPa s")
            frmValveSizing.cmbViscosityUnits.Items.Add("cP")
            frmValveSizing.cmbViscosityUnits.Items.Add("cSt")


            frmValveSizing.cmbMOC.Items.Add("A216WCB")
            frmValveSizing.cmbMOC.Items.Add("A217WC6")
            frmValveSizing.cmbMOC.Items.Add("A351CF8M")
            frmValveSizing.cmbMOC.Items.Add("A216WCC")
            frmValveSizing.cmbMOC.Items.Add("A351 CF3")
            frmValveSizing.cmbMOC.Items.Add("A351CF3M")
            frmValveSizing.cmbMOC.Items.Add("A217WC9")
            frmValveSizing.cmbMOC.Items.Add("A351 CF8")
            frmValveSizing.cmbMOC.Items.Add("A352LCB")
            frmValveSizing.cmbMOC.Items.Add("A217 C5")
            frmValveSizing.cmbMOC.Items.Add("A351 Gr.CD4MCu")
            frmValveSizing.cmbMOC.Items.Add("A217 C12A")
            frmValveSizing.cmbMOC.Items.Add("A351 CN7M")
            frmValveSizing.cmbMOC.Items.Add("A494 Gr.CW-12MW")
            frmValveSizing.cmbMOC.Items.Add("A105")
            frmValveSizing.cmbMOC.Items.Add("A350 Gr.LF2")



            frmValveSizing.cmbInletPipeSize.Text = "--Select--"
            frmValveSizing.cmbInletPipeSchedule.Text = "-Select-"

            'Me.cmbDesignPressure.Items.Add("barA")
            'Me.cmbDesignPressure.Items.Add("barG")
            'Me.cmbDesignPressure.Items.Add("psiA")
            'Me.cmbDesignPressure.Items.Add("psiG")
            'Me.cmbDesignPressure.Items.Add("kg/cm2A")
            'Me.cmbDesignPressure.Items.Add("kg/cm2G")
            'Me.cmbDesignPressure.Items.Add("kPaA")
            'Me.cmbDesignPressure.Items.Add("kPaG")
            'Me.cmbDesignPressure.Items.Add("MPaA")
            'Me.cmbDesignPressure.Items.Add("MPaG")


            'Me.cmbDesignTemperature.Items.Add("°C")
            'Me.cmbDesignTemperature.Items.Add("°K")
            'Me.cmbDesignTemperature.Items.Add("°R")
            'Me.cmbDesignTemperature.Items.Add("°F")

            frmValveSizing.cmbVelocityRule.Items.Add("6 m/s")
            frmValveSizing.cmbVelocityRule.Items.Add("8 m/s")

            frmValveSizing.cmbAreaunits.Items.Add("NB")
            frmValveSizing.cmbAreaunits.Items.Add("inch")

            frmValveSizing.cmbKVseries.Items.Add("50% S")
            frmValveSizing.cmbKVseries.Items.Add("60% S")
            frmValveSizing.cmbKVseries.Items.Add("70% S")
            frmValveSizing.cmbKVseries.Items.Add("80% S")
            frmValveSizing.cmbKVseries.Items.Add("90% S")
            frmValveSizing.cmbKVseries.Items.Add("95% S")
            frmValveSizing.cmbKVseries.Items.Add("100% S")

            frmValveSizing.cmbCharacterstics.Items.Add("LINEAR")
            frmValveSizing.cmbCharacterstics.Items.Add("EQUAL %")
            frmValveSizing.cmbCharacterstics.Items.Add("ON-OFF")

            'cmbSelectedTrim.Items.Add("PS1")
            'cmbSelectedTrim.Items.Add("PS3")
            'cmbSelectedTrim.Items.Add("PR1")
            'cmbSelectedTrim.Items.Add("PR2")
            'cmbSelectedTrim.Items.Add("PR3")
            frmValveSizing.cmbSelectedTrim.Items.Add("P1")             'changes 20102020
            frmValveSizing.cmbSelectedTrim.Items.Add("P3")
            frmValveSizing.cmbSelectedTrim.Items.Add("L1")
            frmValveSizing.cmbSelectedTrim.Items.Add("L2")
            frmValveSizing.cmbSelectedTrim.Items.Add("L3")

            frmValveSizing.cmbFlowDirection.Items.Add("FTO")
            frmValveSizing.cmbFlowDirection.Items.Add("FTC")

            'Actuator
            frmValveSizing.cmbActuatorType.Items.Add("SINGLE SPRING")
            frmValveSizing.cmbActuatorType.Items.Add("MULTI SPRING")
            frmValveSizing.cmbActuatorType.Items.Add("NA")
            frmValveSizing.cmbActuatorType.Items.Add("Manual")
            frmValveSizing.cmbActuatorType.Items.Add("Electrical")
            frmValveSizing.cmbActuatorType.Items.Add("PNEUMATIC")
            frmValveSizing.cmbActuatorType.Items.Add("811PNEUMATIC")

            frmValveSizing.cmbActuatorType.SelectedIndex = 0

            'cmbAirFailure.Items.Add("Open")
            'cmbAirFailure.Items.Add("Close")
            'cmbAirFailure.SelectedIndex = 1


            'cmbLeakage.Items.Add("Class 1")
            'cmbLeakage.Items.Add("Class 2")
            'cmbLeakage.Items.Add("Class 3")
            frmValveSizing.cmbLeakage.Items.Add("CLASS IV")
            frmValveSizing.cmbLeakage.Items.Add("CLASS V")
            frmValveSizing.cmbLeakage.Items.Add("CLASS VI")
            'cmbLeakage.Items.Add("Class 7")
            '    cmbLeakage.SelectedIndex = 0

            frmValveSizing.cmbBalancing.Items.Add("Non Pr.Bal")
            frmValveSizing.cmbBalancing.Items.Add("Q-Ring EPDM")
            frmValveSizing.cmbBalancing.Items.Add("Q-Ring VITON")
            frmValveSizing.cmbBalancing.Items.Add("Piston-Ring")
            'cmbBalancing.Items.Add("PTFE VARI")
            'cmbBalancing.Items.Add("Graphite")
            frmValveSizing.cmbBalancing.SelectedIndex = 0


            '  cmbSealing.Items.Add("Metal")
            'cmbSealing.Items.Add("PTFE/EPDM 140Grd")
            'cmbSealing.Items.Add("PTFE/VITON 180Grd")
            'cmbSealing.Items.Add("PTFE-Trapez 200Grd")
            'cmbSealing.Items.Add("PEEK 250Grd")
            'cmbSealing.Items.Add("PEEK/plug")
            '  cmbSealing.SelectedIndex = 0

            frmValveSizing.cmbPacking.Items.Add("PTFE V-Ring+EPDM")
            frmValveSizing.cmbPacking.Items.Add("PTFE V-Ring+VITON")
            frmValveSizing.cmbPacking.Items.Add("PTFE braided")
            frmValveSizing.cmbPacking.Items.Add("Pure Graphite")

            'cmbPacking.Items.Add("Carbon/INCONEL")
            'cmbPacking.Items.Add("PureGraphite+EPDM")
            'cmbPacking.Items.Add("PureGraphite+VITON")
            'cmbPacking.Items.Add("TA-Luft")
            'cmbPacking.Items.Add("Chesterton477")
            'cmbPacking.Items.Add("Chesterton324")
            'cmbPacking.Items.Add("ChesteronLL")
            'cmbPacking.Items.Add("T-L")
            'cmbPacking.Items.Add("T-GP")
            'cmbPacking.Items.Add("QV")
            'cmbPacking.Items.Add("QE")
            frmValveSizing.cmbPacking.SelectedIndex = 0

            frmValveSizing.cmbSuggestedRating.Items.Add("150")
            frmValveSizing.cmbSuggestedRating.Items.Add("300")
            frmValveSizing.cmbSuggestedRating.Items.Add("600")
            frmValveSizing.cmbSuggestedRating.Items.Add("900")
            frmValveSizing.cmbSuggestedRating.Items.Add("1500")
            frmValveSizing.cmbSuggestedRating.Items.Add("2500")
            'cmbSuggestedRating.Items.Add("4500")

            Call frmValveSizing.SQL_DATALOAD()
            'Reading Database files into Datasets 
            'ds_AccessoriesMat = ConvertCSV(AppPath & "\Database\Accessories_Materials.csv", "Accessories_Materials", ",")
            ds_AFOSingleSpring = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\AFOSingleSpringModel.csv", "AFOSingleSpringModel", ",")
            ds_AFCSingleSpring = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\AFCSingleSpringModel.csv", "AFCSingleSpringModel", ",")
            ds_AFOMultiSpring = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\AFOMultiSpringModel.csv", "AFOMultiSpringModel", ",")
            ds_AFCMultiSpring = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\AFCMultiSpringModel.csv", "AFCMultiSpringModel", ",")
            ds_SealingForce150300 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\SealingForce150300.csv", "SealingForce150300", ",")
            ds_SealingForce6001500 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\SealingForce6001500.csv", "SealingForce6001500", ",")
            ds_SeatingForceLC6150300 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\SeatingForceLC6150300.csv", "SeatingForceLC6150300 ", ",")
            ds_SeatingForceLC66001500 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\SeatingForceLC66001500.csv", "SeatingForceLC66001500 ", ",")
            ds_FrictionForce150300 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\FrictionForce150300.csv", "FrictionForce150300 ", ",")
            ds_FrictionForce6001500 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\FrictionForce6001500.csv", "FrictionForce6001500 ", ",")
            ds_Travel150300 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\Travel150300.csv", "Travel150300 ", ",")
            ds_Travel6001500 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\Travel6001500.csv", "Travel6001500 ", ",")

            ds_FL = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\FL.csv", "FL", ",")
            ds_FR = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\FR.csv", "FR", ",")
            ds_PipeSchedule1 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PipeSchedule1.csv", "PipeSchedule1", ",")
            ds_PipeSchedule2 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PipeSchedule2.csv", "PipeSchedule2", ",")
            ds_RatingClass_150300 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\RatingClass_150300.csv", "RatingClass_150300", ",")
            ds_RatingClass_600900 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\RatingClass_600900.csv", "RatingClass_600900", ",")
            ds_KvforCage150300 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\KVforCAGE150300.csv", "KVforCAGE150300", ",")
            ds_KvforCage600900 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\KVforCAGE600900.csv", "KVforCAGE600900", ",")
            ds_Water_Temp_Properties = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\Water_Temp_Properties.csv", "Water_Temp_Properties", ",")


            ds_A216GrWCB = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A216 Gr.WCB.csv", "A216 Gr.WCB", ",")
            ds_A217GrWC6 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A217 Gr.WC6.csv", "A217 Gr.WC6", ",")
            ds_A351GrCF8M = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A351 Gr.CF8M.csv", "A351 Gr.CF8M", ",")
            ds_A216GrWCC = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A216 Gr.WCC.csv", "A216 Gr.WCC", ",")
            ds_A351GrCF3 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A351 Gr.CF3.csv", "A351 Gr.CF3", ",")
            ds_A351GrCF3M = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A351 Gr.CF3M.csv", "A351 Gr.CF3M", ",")
            ds_A217GrWC9 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A217 Gr.WC9.csv", "A217 Gr.WC9", ",")
            ds_A351GrCF8C = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A351 Gr.CF8C.csv", "A351 Gr.CF8C", ",")
            ds_A352GrLCB = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A352 Gr.LCB.csv", "A352 Gr.LCB", ",")
            ds_A217GrC5 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A217 Gr.C5.csv", "A217 Gr.C5", ",")
            ds_A351GrCD4MCu = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A351 Gr.CD4MCu.csv", "A351 Gr.CD4MCu", ",")
            ds_A217GrC12A = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A217 Gr.C12A.csv", "A217 Gr.C12A", ",")
            ds_A351GrCN7M = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A351 Gr.CN7M.csv", "A351 Gr.CN7M", ",")
            ds_A494GrCW12MW = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\A494 Gr.CW-12MW.csv", "A494 Gr.CW-12MW", ",")



            DT_AccessoriesMat = New System.Data.DataTable
            DT_AFOSingleSpring = New System.Data.DataTable
            DT_AFCSingleSpring = New System.Data.DataTable
            DT_AFOMultiSpring = New System.Data.DataTable
            DT_AFCMultiSpring = New System.Data.DataTable
            DT_SealingForce150300 = New System.Data.DataTable
            DT_SealingForce6001500 = New System.Data.DataTable
            DT_SeatingForceLC6150300 = New System.Data.DataTable
            DT_SeatingForceLC66001500 = New System.Data.DataTable
            DT_FrictionForce150300 = New System.Data.DataTable
            DT_FrictionForce6001500 = New System.Data.DataTable
            DT_Travel150300 = New System.Data.DataTable
            DT_Travel6001500 = New System.Data.DataTable
            DT_Travel2500 = New System.Data.DataTable
            DT_FL = New System.Data.DataTable
            DT_FR = New System.Data.DataTable
            DT_PipeSchedule1 = New System.Data.DataTable
            DT_PipeSchedule2 = New System.Data.DataTable
            DT_RatingClass_150300 = New System.Data.DataTable
            DT_RatingClass_600900 = New System.Data.DataTable

            DT_A216GrWCB = New System.Data.DataTable
            DT_A217GrWC6 = New System.Data.DataTable
            DT_A351GrCF8M = New System.Data.DataTable
            DT_A216GrWCC = New System.Data.DataTable
            DT_A351GrCF3 = New System.Data.DataTable
            DT_A351GrCF3M = New System.Data.DataTable
            DT_A217GrWC9 = New System.Data.DataTable
            DT_A351GrCF8C = New System.Data.DataTable
            DT_A352GrLCB = New System.Data.DataTable
            DT_A217GrC5 = New System.Data.DataTable
            DT_A351GrCD4MCu = New System.Data.DataTable
            DT_A217GrC12A = New System.Data.DataTable
            DT_A351GrCN7M = New System.Data.DataTable
            DT_A494GrCW12MW = New System.Data.DataTable


            'PERFORATION
            ds_Perforated = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PR1150300KV.csv", "PR1150300KV", ",")
            DT_PR1150300KV = New System.Data.DataTable
            DT_PR1150300KV = ds_Perforated.Tables(0)
            ds_Perforated = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PR2150300KV.csv", "PR2150300KV", ",")
            DT_PR2150300KV = New System.Data.DataTable
            DT_PR2150300KV = ds_Perforated.Tables(0)
            ds_Perforated = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PR3150300KV.csv", "PR3150300KV", ",")
            DT_PR3150300KV = New System.Data.DataTable
            DT_PR3150300KV = ds_Perforated.Tables(0)
            ds_Perforated = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PR1600900KV.csv", "PR1600900KV", ",")
            DT_PR1600900KV = New System.Data.DataTable
            DT_PR1600900KV = ds_Perforated.Tables(0)
            ds_Perforated = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PR2600900KV.csv", "PR2600900KV", ",")
            DT_PR2600900KV = New System.Data.DataTable
            DT_PR2600900KV = ds_Perforated.Tables(0)
            ds_Perforated = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PR3600900KV.csv", "PR3600900KV", ",")
            DT_PR3600900KV = New System.Data.DataTable
            DT_PR3600900KV = ds_Perforated.Tables(0)

            ds_Perforated = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PR12500KV.csv", "PR12500KV", ",")
            DT_PR12500KV = New System.Data.DataTable
            DT_PR12500KV = ds_Perforated.Tables(0)
            ds_Perforated = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PR22500KV.csv", "PR22500KV", ",")
            DT_PR22500KV = New System.Data.DataTable
            DT_PR22500KV = ds_Perforated.Tables(0)
            ds_Perforated = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PR32500KV.csv", "PR32500KV", ",")
            DT_PR32500KV = New System.Data.DataTable
            DT_PR32500KV = ds_Perforated.Tables(0)



            ds_Perforated = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PS3_RatingClass_150300.csv", "PS3_RatingClass_150300", ",")
            DT_PS3150300KV = New System.Data.DataTable
            DT_PS3150300KV = ds_Perforated.Tables(0)
            ds_Perforated = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\PS3_RatingClass_600900.csv", "PS3_RatingClass_600900", ",")
            DT_PS3600900KV = New System.Data.DataTable
            DT_PS3600900KV = ds_Perforated.Tables(0)


            DT_KvforCage150300 = New System.Data.DataTable
            DT_KvforCage600900 = New System.Data.DataTable
            DT_Water_Temp_Properties = New System.Data.DataTable

            DT_AccessoriesMat = ds_AccessoriesMat.Tables(0)
            DT_AFOSingleSpring = ds_AFOSingleSpring.Tables(0)
            DT_AFCSingleSpring = ds_AFCSingleSpring.Tables(0)
            DT_AFOMultiSpring = ds_AFOMultiSpring.Tables(0)
            DT_AFCMultiSpring = ds_AFCMultiSpring.Tables(0)
            DT_SealingForce150300 = ds_SealingForce150300.Tables(0)
            DT_SealingForce6001500 = ds_SealingForce6001500.Tables(0)
            DT_SeatingForceLC6150300 = ds_SeatingForceLC6150300.Tables(0)
            DT_SeatingForceLC66001500 = ds_SeatingForceLC66001500.Tables(0)
            DT_FrictionForce150300 = ds_FrictionForce150300.Tables(0)
            DT_FrictionForce6001500 = ds_FrictionForce6001500.Tables(0)
            DT_Travel150300 = ds_Travel150300.Tables(0)
            DT_Travel6001500 = ds_Travel6001500.Tables(0)
            ds_Travel6001500 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\Travel2500.csv", "Travel2500", ",")
            DT_Travel2500 = ds_Travel6001500.Tables(0)

            DT_FL = ds_FL.Tables(0)
            DT_FR = ds_FR.Tables(0)
            DT_PipeSchedule1 = ds_PipeSchedule1.Tables(0)
            DT_PipeSchedule2 = ds_PipeSchedule2.Tables(0)
            DT_RatingClass_150300 = ds_RatingClass_150300.Tables(0)
            DT_RatingClass_600900 = ds_RatingClass_600900.Tables(0)
            ds_RatingClass_600900 = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\3-WAY_300.csv", "3-WAY_300", ",")
            DT_3WAY_300 = ds_RatingClass_600900.Tables(0)

            DT_A216GrWCB = ds_A216GrWCB.Tables(0)
            DT_A217GrWC6 = ds_A217GrWC6.Tables(0)
            DT_A351GrCF8M = ds_A351GrCF8M.Tables(0)
            DT_A216GrWCC = ds_A216GrWCC.Tables(0)
            DT_A351GrCF3 = ds_A351GrCF3.Tables(0)
            DT_A351GrCF3M = ds_A351GrCF3M.Tables(0)
            DT_A217GrWC9 = ds_A217GrWC9.Tables(0)
            DT_A351GrCF8C = ds_A351GrCF8C.Tables(0)
            DT_A352GrLCB = ds_A352GrLCB.Tables(0)
            DT_A217GrC5 = ds_A217GrC5.Tables(0)
            DT_A351GrCD4MCu = ds_A351GrCD4MCu.Tables(0)
            DT_A217GrC12A = ds_A217GrC12A.Tables(0)
            DT_A351GrCN7M = ds_A351GrCN7M.Tables(0)
            DT_A494GrCW12MW = ds_A494GrCW12MW.Tables(0)
            DT_KvforCage150300 = ds_KvforCage150300.Tables(0)
            DT_KvforCage600900 = ds_KvforCage600900.Tables(0)
            DT_Water_Temp_Properties = ds_Water_Temp_Properties.Tables(0)

            'ACtuator List for Ecotrol
            ds_AFOSingleSpring = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\AFOSingleSpringModelE.csv", "AFOSingleSpringModelE", ",")
            DT_AFOSingleSpringE = New System.Data.DataTable
            DT_AFOSingleSpringE = ds_AFOSingleSpring.Tables(0)
            ds_AFOSingleSpring = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\AFCSingleSpringModelE.csv", "AFCSingleSpringModelE", ",")
            DT_AFCSingleSpringE = New System.Data.DataTable
            DT_AFCSingleSpringE = ds_AFOSingleSpring.Tables(0)
            ds_AFOSingleSpring = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\AFOMultiSpringModelE.csv", "AFOMultiSpringModelE", ",")
            DT_AFOMultiSpringE = New System.Data.DataTable
            DT_AFOMultiSpringE = ds_AFOSingleSpring.Tables(0)
            ds_AFOSingleSpring = frmValveSizing.ConvertCSV(AppPath & "\bin\Debug\Database\AFCMultiSpringModelE.csv", "AFCMultiSpringModelE", ",")
            DT_AFCMultiSpringE = New System.Data.DataTable
            DT_AFCMultiSpringE = ds_AFOSingleSpring.Tables(0)

            'With DT_AccessoriesMat
            '    LastRow = FindLastRow(DT_AccessoriesMat, 0)
            '    For rowno = 0 To LastRow
            '        RemoveLineFeed = .Rows(rowno).Item(0)
            '        RemoveLineFeed = RemoveLineFeed.Replace(vbLf, "")
            '        cmbBonnetType.Items.Add(.Rows(rowno).Item(0))
            '    Next
            '    LastRow = FindLastRow(DT_AccessoriesMat, 1)
            '    For rowno = 0 To LastRow
            '        cmbEndConnection.Items.Add(.Rows(rowno).Item(1))
            '    Next
            '    LastRow = FindLastRow(DT_AccessoriesMat, 20)
            '    For rowno = 0 To LastRow
            '        cmbHandwheel.Items.Add(.Rows(rowno).Item(20))
            '    Next
            'End With

            frmValveSizing.txtPressureDropCase1.ReadOnly = True
            frmValveSizing.txtPressureDropCase2.ReadOnly = True
            frmValveSizing.txtPressureDropCase3.ReadOnly = True
            frmValveSizing.chkViscosity.Checked = False

            frmMaterials.cmbGuiding.Items.Add("Single")
            frmMaterials.cmbGuiding.Items.Add("Double")




            Noise_DensityAir = 1.293  'kg/m3
            Noise_DensityPipe = 7.8 'kg/m3  
            Noise_SoundVelocityLiquid = 1400  'm/s
            Noise_SoundVelocityAir = 343  'm/s  

            frmValveSizing.cmbFluidType.SelectedIndex = 0
            frmValveSizing.cmbFluid.SelectedIndex = 0

            frmValveSizing.cmbUnitsType.SelectedIndex = 0  'Default MKS
            frmValveSizing.cmbModel.SelectedIndex = 1  'Default Ecotrol  
            frmValveSizing.cmbQW.SelectedIndex = 1 'Default  W
            frmValveSizing.cmbFlowrate.SelectedIndex = 0 'Default m3/hr
            frmValveSizing.cmbTemperatureUnits.SelectedIndex = 0 'deg c
            frmValveSizing.cmbPressureUnits.SelectedIndex = 1  ' bar g
            frmValveSizing.cmbAirPressureUnits.SelectedIndex = 1 'bar g
            frmValveSizing.lblDesignPressure.Text = frmValveSizing.cmbPressureUnits.SelectedItem
            frmValveSizing.cmbCriticalPressureUnits.SelectedIndex = 0 ' bar A
            frmValveSizing.cmbVapourPressureUnits.SelectedIndex = 0 ' bar A
            frmValveSizing.lblTwUnit.Text = frmValveSizing.cmbPressureUnits.SelectedItem
            frmValveSizing.cmbPressureUnits.Text = frmValveSizing.cmbPressureUnits.SelectedItem

            'Call DefaultFormloads()


            NoiseAttenuationFlag = False

            ' PipeSchedule_workbook = APP.Workbooks.Open(AppPath & "\Database\PipeSchedule.xlsx", , True)

            ' APP.Windows(1).Visible = False


            ' RatingClass_workbook = APP.Workbooks.Open(AppPath & "\Database\RatingClass.xlsx", , True)
            ' RatingClass_worksheet = RatingClass_workbook.Worksheets("Class150300")
            With DT_RatingClass_150300
                For i = 0 To .Rows.Count - 2
                    MaxKV150_FromSheet(i) = .Rows(i).Item(4)
                    SeatDia150_FromSheet(i) = .Rows(i).Item(2)
                    PrBl_SeatDia150_FromSheet(i) = .Rows(i).Item(3)
                    Valve150_FromSheet(i) = .Rows(i).Item(0)
                    TrimType150_Sheet(i) = CStr(.Rows(i).Item(7))
                Next
            End With

            'RatingClass_worksheet = RatingClass_workbook.Worksheets("Class600900")
            With DT_RatingClass_600900
                For i = 0 To .Rows.Count - 2
                    MaxKV600_FromSheet(i) = CSng(.Rows(i).Item(4))
                    SeatDia600_FromSheet(i) = CSng(.Rows(i).Item(2))
                    PrBl_SeatDia600_FromSheet(i) = CSng(.Rows(i).Item(3))
                    Valve600_FromSheet(i) = CSng(.Rows(i).Item(0))
                    TrimType600_Sheet(i) = CStr(.Rows(i).Item(7))
                Next
            End With

            '''''''''''''''''''FOR PS3''''''''''''''''''''''''''''''''
            With DT_PS3150300KV
                For i = 0 To .Rows.Count - 2
                    PS3_MaxKV150_FromSheet(i) = CSng(.Rows(i).Item(4))
                    PS3_SeatDia150_FromSheet(i) = CSng(.Rows(i).Item(2))
                    PS3_Valve150_FromSheet(i) = CSng(.Rows(i).Item(0))
                    PS3_TrimType150_Sheet(i) = CStr(.Rows(i).Item(6))
                Next
            End With

            'RatingClass_worksheet = RatingClass_workbook.Worksheets("Class600900")
            With DT_PS3600900KV
                For i = 0 To .Rows.Count - 2
                    PS3_MaxKV600_FromSheet(i) = CSng(.Rows(i).Item(4))
                    PS3_SeatDia600_FromSheet(i) = CSng(.Rows(i).Item(2))
                    PS3_Valve600_FromSheet(i) = CSng(.Rows(i).Item(0))
                    PS3_TrimType600_Sheet(i) = CStr(.Rows(i).Item(6))
                Next
            End With

            With DT_3WAY_300
                For i = 0 To .Rows.Count - 2
                    TW_MaxKV150_FromSheet(i) = CSng(.Rows(i).Item(4))
                    TW_PrBl_SeatDia150_FromSheet(i) = CSng(.Rows(i).Item(3))
                    TW_SeatDia150_FromSheet(i) = CSng(.Rows(i).Item(2))
                    TW_Valve150_FromSheet(i) = CSng(.Rows(i).Item(0))
                    TW_TrimType150_FromSheet(i) = CStr(.Rows(i).Item(7))

                Next
            End With



            'APP.Windows(1).Visible = False

            '  FL_workbook = APP.Workbooks.Open(AppPath & "\Database\FL.xlsx")
            ' FL_worksheet = FL_workbook.Worksheets("SHEET1")
            'Fill array for FL
            With DT_FL
                '   LastRow = .Cells(.Rows.Count, 1).End(excel.XlDirection.xlUp).Row

                For i = 0 To .Rows.Count - 2
                    FL_Column1array(i) = .Rows(i).Item(0)
                    FL_Column2array(i) = .Rows(i).Item(1)
                    FL_Column5array(i) = .Rows(i).Item(4)

                Next
            End With

            'FR_workbook = APP.Workbooks.Open(AppPath & "\Database\FR.xlsx")
            'FR_worksheet = FR_workbook.Worksheets("SHEET1")


            With DT_FR
                For i = 0 To .Rows.Count - 2
                    FR_Column1array(i) = .Rows(i).Item(0)
                    FR_Column2array(i) = .Rows(i).Item(1)
                Next
            End With

            'PipeSheet1_worksheet = PipeSchedule_workbook.Worksheets("sheet1")
            '   If cmbAreaunits.SelectedIndex = 0 Then
            With DT_PipeSchedule1
                'LastRow = .Cells(.Rows.Count, 1).End(excel.XlDirection.xlUp).Row
                For i = 0 To .Rows.Count - 2
                    NB_PipeDIa(i) = .Rows(i).Item(1)  ' in mm
                    INCH_PipeDia(i) = .Rows(i).Item(3)   ' in inch 
                    PipeOutletSize(i) = CSng(.Rows(i).Item(2))          'Changes 20201028
                    PipeInletSizeArray(i) = .Rows(i).Item(3) '.Cells(i, 4).Value
                    PipeInletODArray(i) = .Rows(i).Item(2) '.Cells(i, 3).Value
                Next
            End With

            '  PipeSheet2_worksheet = PipeSchedule_workbook.Worksheets("sheet2")
            dtb.Columns.Add("TrimType", GetType(Byte))
            dtb.Columns.Add("TrimVelocity", GetType(Single))
            dtb.Columns.Add("Cavitation", GetType(Byte))

            dtb.Columns.Add("KvCase1", GetType(Single))
            dtb.Columns.Add("KvCase2", GetType(Single))
            dtb.Columns.Add("KvCase3", GetType(Single))
            dtb.Columns.Add("TrimName", GetType(String))

            DT_FLtable = New DataTable
            DT_FLtable.Columns.Add("PS1", GetType(Single))
            DT_FLtable.Columns.Add("PS3", GetType(Single))
            DT_FLtable.Columns.Add("PR1", GetType(Single))
            DT_FLtable.Columns.Add("PR2", GetType(Single))
            DT_FLtable.Columns.Add("PR3", GetType(Single))

            DT_FLtable.Rows.Add(0.9374, 0.96, 0.93, 0.95, 0.975)    'Case1
            DT_FLtable.Rows.Add(0.9374, 0.96, 0.93, 0.95, 0.975)    'Case2
            DT_FLtable.Rows.Add(0.9374, 0.96, 0.93, 0.95, 0.975)    'Case3

            Dt_NoisePrStages = New DataTable
            Dt_NoisePrStages.Columns.Add("Case1", GetType(Single))
            Dt_NoisePrStages.Columns.Add("Case2", GetType(Single))
            Dt_NoisePrStages.Columns.Add("Case3", GetType(Single))

            Dt_NoisePrStages.Rows.Add(0, 0, 0)
            Dt_NoisePrStages.Rows.Add(0, 0, 0)
            Dt_NoisePrStages.Rows.Add(0, 0, 0)
            Dt_NoisePrStages.Rows.Add(0, 0, 0)
            Dt_NoisePrStages.Rows.Add(0, 0, 0)
            Dt_NoisePrStages.Rows.Add(0, 0, 0)

            DT_NoiseAttenuation = New System.Data.DataTable
            ' Columns - NoiseCase1,NoiseCase2,NoiseCase3,
            DT_NoiseAttenuation.Columns.Add("Case1", GetType(Single))
            DT_NoiseAttenuation.Columns.Add("Case2", GetType(Single))
            DT_NoiseAttenuation.Columns.Add("Case3", GetType(Single))
            DT_NoiseAttenuation.Columns.Add("Name", GetType(String))
            DT_NoiseAttenuation.Rows.Add(0, 0, 0, "Baffle3")       'for BaffleKVCase3
            DT_NoiseAttenuation.Rows.Add(0, 0, 0, "Baffle2")        'for BaffleKVCase2
            DT_NoiseAttenuation.Rows.Add(0, 0, 0, "Baffle1")         'for BaffleKVCase1
            DT_NoiseAttenuation.Rows.Add(0, 0, 0, "LN")          'for NoiseAttenuation
            DT_NoiseAttenuation.Rows.Add(0, 0, 0, "Normal")       'for Normal Noise

            'For Inlet and Outlet Pressure Storage  
            DT_Baffles = New System.Data.DataTable
            'Columns -  InletPressureCase1,2,3,OutletPressure Case 1,2,3
            DT_Baffles.Columns.Add("InletPressCase1", GetType(Single))
            DT_Baffles.Columns.Add("InletPressCase2", GetType(Single))
            DT_Baffles.Columns.Add("InletPressCase3", GetType(Single))
            DT_Baffles.Columns.Add("OutletPressCase1", GetType(Single))
            DT_Baffles.Columns.Add("OutletPressCase2", GetType(Single))
            DT_Baffles.Columns.Add("OutletPressCase3", GetType(Single))

            DT_Baffles.Rows.Add(0, 0, 0, 0, 0, 0)       'Baffle 3
            DT_Baffles.Rows.Add(0, 0, 0, 0, 0, 0)       'Baffle 2    
            DT_Baffles.Rows.Add(0, 0, 0, 0, 0, 0)       'Baffle 1


            DT_StageWiseNoise = New System.Data.DataTable
            DT_StageWiseNoise.Columns.Add("Case1", GetType(Single))
            DT_StageWiseNoise.Columns.Add("Case2", GetType(Single))
            DT_StageWiseNoise.Columns.Add("Case3", GetType(Single))
            DT_StageWiseNoise.Columns.Add("Name", GetType(String))

            DT_StageWiseNoise.Rows.Add(0, 0, 0, "Stage1")
            DT_StageWiseNoise.Rows.Add(0, 0, 0, "Stage2")
            DT_StageWiseNoise.Rows.Add(0, 0, 0, "Stage3")

            DT_ActuatorInfo = New System.Data.DataTable

            ' Columns - Data,Value,Unit,
            DT_ActuatorInfo.Columns.Add("Name", GetType(String))
            DT_ActuatorInfo.Columns.Add("Value", GetType(String))
            DT_ActuatorInfo.Columns.Add("Unit", GetType(String))

            DT_ActuatorInfo.Rows.Add("ValveSize", 0, " ")
            DT_ActuatorInfo.Rows.Add("Rating", 0, " ")
            DT_ActuatorInfo.Rows.Add("Balancing", 0, " ")
            DT_ActuatorInfo.Rows.Add("Seat Dia", 0, " ")
            DT_ActuatorInfo.Rows.Add("Stem Dia", 0, " ")
            DT_ActuatorInfo.Rows.Add("FlowDir", 0, " ")
            DT_ActuatorInfo.Rows.Add("AirFail", 0, " ")
            DT_ActuatorInfo.Rows.Add("PackingFricForce", 0, "kgf")
            DT_ActuatorInfo.Rows.Add("SeatingForce", 0, "kgf ")
            DT_ActuatorInfo.Rows.Add("FluidForce", 0, "kgf")
            DT_ActuatorInfo.Rows.Add("TotalForce", 0, "kgf")
            DT_ActuatorInfo.Rows.Add("SelectedActuator", 0, " ")
            DT_ActuatorInfo.Rows.Add("Initial Spring Thrust", 0, "kgf")
            DT_ActuatorInfo.Rows.Add("Final Spring Thrust", 0, "kgf")
            DT_ActuatorInfo.Rows.Add("Air Ending Thrust", 0, "kgf")

            DT_Flowtype = New System.Data.DataTable
            DT_Flowtype.Columns.Add("Name", GetType(String))
            DT_Flowtype.Columns.Add("Case1", GetType(String))
            DT_Flowtype.Columns.Add("Case2", GetType(String))
            DT_Flowtype.Columns.Add("Case3", GetType(String))
            DT_Flowtype.Rows.Add("Ln", "", "", "")
            DT_Flowtype.Rows.Add("Stage1", "", "", "")
            DT_Flowtype.Rows.Add("Stage2", "", "", "")
            DT_Flowtype.Rows.Add("Stage3", "", "", "")
            DT_Flowtype.Rows.Add("Baffle1", "", "", "")
            DT_Flowtype.Rows.Add("Baffle2", "", "", "")
            DT_Flowtype.Rows.Add("Baffle3", "", "", "")

            DT_ActuatorSelect = New System.Data.DataTable
            DT_ActuatorSelect.Columns.Add("", GetType(String))                  '0
            DT_ActuatorSelect.Columns.Add("Act. Model No", GetType(String))     '1   
            DT_ActuatorSelect.Columns.Add("Force @ 0% Open", GetType(Single))   '2
            DT_ActuatorSelect.Columns.Add("Force @ 100% Open", GetType(Single)) '3

            DT_ActuatorSelect.Rows.Add("Required", "", 0, 0)                '0
            DT_ActuatorSelect.Rows.Add("Suggested Actuator", "", 0, 0)      '1
            DT_ActuatorSelect.Rows.Add("Selected Actuator", "", 0, 0)      '2


            LoadingForm = True
            frmValveSizing.HScrollBar_Records.LargeChange = 1
            frmValveSizing.HScrollBar_Records.SmallChange = 1
        Catch ex As Exception
            MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace)
        End Try
    End Sub
    Private Sub DGV_Records_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Records.CellDoubleClick
        Try
            If e.RowIndex = 0 Then Exit Sub
            Me.Cursor = Cursors.WaitCursor


            'pk = DGV_Records.Rows(e.RowIndex).Cells(0).Value
            'CustomerName = DGV_Records.Rows(e.RowIndex).Cells(2).Value
            'TagNo = DGV_Records.Rows(e.RowIndex).Cells(3).Value
            'CustomerRef = DGV_Records.Rows(e.RowIndex).Cells(4).Value
            'frmValveSizing.ReadSQL()

            Database_Rowno = e.RowIndex
            frmValveSizing.HScrollBar_Records.Value = Database_Rowno
            frmValveSizing.ReadXLS(XMLFilename)
            Database_LastRow = dt_OpenOffice.Rows.Count - 1
            'frmValveSizing.HScrollBar_Records.Maximum = Database_LastRow
            frmValveSizing.lblDatabaseRowNo.Text = Database_Rowno & "/" & Database_LastRow
            frmValveSizing.txtJumpToRecord.Text = Database_Rowno
            lblFilename.Text = FileName

            frmValveSizing.ShowDialog()
            frmValveSizing.HScrollBar_Records.Maximum = Database_LastRow
            ' frmValveSizing.WindowState = FormWindowState.Normal
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("DGV_Records_CellDoubleClick: " & ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmRecordsGrid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CLoseSoftware = True
        frmValveSizing.Close()
        ' frmWelcome.Close()
    End Sub

    Public dt As DataTable
    Public Sub LoadDGV()
        Dim constr As String = "Data Source=.\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=true"
        Dim cmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim query As String = "Select Sr_No, OfferNo, Customer, TagNo, CustomerRef, Project, SalesEngg, Qty, Date from Storage_Table"
        dt = New DataTable

        Using con As New SqlConnection(constr)
            cmd = New SqlCommand(query, con)
            adapter.SelectCommand = cmd
            adapter.Fill(dt)
            DGV_Records.DataSource = dt
        End Using
    End Sub

    Private Sub frmRecordsGrid_Load(sender As Object, e As EventArgs) Handles Me.Load
        '   frmValveSizing.WindowState = FormWindowState.Minimized
        DGV_Records.AllowUserToAddRows = False
        'LoadDGV()
        'DGV_Records.Columns(8).ReadOnly = True
        'DGV_Records.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' frmValveSizing.Show()
        'frmValveSizing.Visible = False
        'DGV_Records.DataSource = ods.Tables(0)
    End Sub

    Private Sub BtnDeleteRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click

        dt_OpenOffice.PrimaryKey = New DataColumn() {dt_OpenOffice.Columns("Column2")} 'setting primary key'

        Dim rowCollection As DataRowCollection = dt_OpenOffice.Rows
        If rowCollection.Contains(txtDeleteRecord.Text) Then
            Dim foundrow As DataRow = rowCollection.Find(txtDeleteRecord.Text)
            rowCollection.Remove(foundrow)
            MsgBox("Record deleted")
            dt_OpenOffice.AcceptChanges()
        Else
            MsgBox("No record found to be deleted")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click

        Dim FileisOpen As Boolean
        Try

            Dlg_OpenXML.Title = "Load  Project File.."               ' Open Dialog box title.
            Dlg_OpenXML.DefaultExt = "ods"                                                ' Set default type of file being displayed.
            Dlg_OpenXML.Filter = "Open Office files|*.ods*|All files|*.*"                   ' Apply Xls filter. Only xls files will be seen.
            Dlg_OpenXML.FileName = Dlg_OpenXML.SafeFileName   ' The Filename entry should show only name of file & not the complete path.
            If Dlg_OpenXML.ShowDialog = Windows.Forms.DialogResult.OK Then
                XMLFilename = Dlg_OpenXML.FileName              ' Get the name of selected filename.
                FileName = System.IO.Path.GetFileNameWithoutExtension(XMLFilename)
                DirectoryName = System.IO.Path.GetDirectoryName(XMLFilename)
                FilenameExt = System.IO.Path.GetFileName(XMLFilename)
                FullPath = System.IO.Path.GetFullPath(XMLFilename)
                Database_Rowno = 1

                FileisOpen = frmValveSizing.CheckForFileOpen(XMLFilename)
                If FileisOpen = True Then
                    MsgBox("File already open outside the software. Kindly close it.File Will not be updated.")
                    Exit Sub
                End If
                Me.Cursor = Cursors.WaitCursor
                ds_OpenOffice = New ODCWORK.OdsReaderWriter().ReadOdsFile(XMLFilename)
                dt_OpenOffice = New DataTable()
                lblFilename.Text = FileName

                dt_OpenOffice = ds_OpenOffice.Tables(0)

                DGV_Records.DataSource = dt_OpenOffice
                Database_LastRow = dt_OpenOffice.Rows.Count - 1
                Database_LastRow = dt_OpenOffice.Rows.Count - 1
                frmValveSizing.HScrollBar_Records.Maximum = Database_LastRow
                'Added later
                ' DGV_Records.DataSource = dt_OpenOffice
                DGV_Records.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue
                DGV_Records.Rows(0).DefaultCellStyle.BackColor = Color.Aqua
                DGV_Records.Rows(0).DefaultCellStyle.Font = New Font(DGV_Records.Font, FontStyle.Bold)
                DGV_Records.Columns(15).DefaultCellStyle.BackColor = Color.Yellow   '  Tag No   
                'Added later

                'HScrollBar_Records.Maximum = Database_LastRow
                'HScrollBar_Records.Minimum = 1
                '   Call ReadXLS(XMLFilename)
                'lblDatabaseRowNo.Text = Database_Rowno & "/" & Database_LastRow
                'HScrollBar_Records.Value = Database_Rowno
                'txtJumpToRecord.Text = Database_Rowno
                'lblFileName.Text = "FileName: " & FileName
                'frmRecordsGrid.ShowDialog()

                'dt_OpenOffice = Nothing
                'ds_OpenOffice = Nothing
                Me.Cursor = Cursors.Default
            End If


        Catch ex As Exception
            MsgBox("Exception occurred at (" & Reflection.MethodInfo.GetCurrentMethod.Name & ") : " & ex.Message, MsgBoxStyle.Critical, "")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNewFile.Click
        If MsgBox("DO you want to create a new file?", MsgBoxStyle.YesNoCancel, "Valve Sizing - Alert!") = MsgBoxResult.Yes Then

            XMLFilename = ""
            lblFilename.Text = FileName

            Database_Rowno = 0
            frmValveSizing.HScrollBar_Records.Minimum = 0
            Database_LastRow = 0
            frmValveSizing.HScrollBar_Records.Maximum = 0
            frmValveSizing.lblDatabaseRowNo.Text = Database_Rowno & "/" & Database_LastRow   'New Row


            Resetall = True
            frmValveSizing.cmbFluidType.SelectedIndex = -1
            frmValveSizing.cmbFluidType.Text = "--Select--"
            Call frmValveSizing.Reset_All()
            frmValveSizing.lblFileName.Text = ""
            frmValveSizing.txtJumpToRecord.Text = 0
            Resetall = False
            frmValveSizing.ShowDialog()
        End If

    End Sub

    Public Function InternetConnection() As Integer
        Try
            My.Computer.Network.Ping("www.google.com")
            'MessageBox.Show("Connected")
            Return 1
        Catch ex As Exception
            MessageBox.Show("Please connect to the Internet to Sync Local Database...")
            Return 0
        End Try
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim result As Integer = InternetConnection()
            If result = 1 Then
                Cursor = Cursors.WaitCursor

                Dim oconstr As String = "DATA SOURCE=sizing.forbesmarshall.com:1521/XE;PERSIST SECURITY INFO=True;USER ID=FMSIZE;Password=fmsize@456;"
                Dim commands As OracleCommand
                Dim adapters As New OracleDataAdapter

                'Ecotrol --> Materials
                Dim ones As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '10' ORDER BY PPVM_PARAMETER_VALUE"
                Dim twos As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '11' ORDER BY PPVM_PARAMETER_VALUE"
                Dim three As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '12' ORDER BY PPVM_PARAMETER_VALUE"
                Dim four As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '12' ORDER BY PPVM_PARAMETER_VALUE"
                Dim five As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '13' ORDER BY PPVM_PARAMETER_VALUE"

                'FMCV --> Materials
                Dim six As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '01' AND PPVM_PARAMETER_CODE = '11' ORDER BY PPVM_PARAMETER_VALUE"
                Dim seven As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '01' AND PPVM_PARAMETER_CODE = '12' ORDER BY PPVM_PARAMETER_VALUE"
                Dim eight As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '01' AND PPVM_PARAMETER_CODE = '13' ORDER BY PPVM_PARAMETER_VALUE"
                Dim nine As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '01' AND PPVM_PARAMETER_CODE = '13' ORDER BY PPVM_PARAMETER_VALUE"
                Dim ten As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '01' AND PPVM_PARAMETER_CODE = '14' ORDER BY PPVM_PARAMETER_VALUE"

                '3-WAY --> Materials
                Dim eleven As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '31' AND PPVM_PARAMETER_CODE = '10' ORDER BY PPVM_PARAMETER_VALUE"
                Dim twelve As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '31' AND PPVM_PARAMETER_CODE = '11' ORDER BY PPVM_PARAMETER_VALUE"
                Dim thirteen As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '31' AND PPVM_PARAMETER_CODE = '12' ORDER BY PPVM_PARAMETER_VALUE"
                Dim fourteen As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '31' AND PPVM_PARAMETER_CODE = '12' ORDER BY PPVM_PARAMETER_VALUE"
                Dim fifteen As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '31' AND PPVM_PARAMETER_CODE = '13' ORDER BY PPVM_PARAMETER_VALUE"

                'PRDS --> Materials
                Dim sixteen As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '51' AND PPVM_PARAMETER_CODE = '11' ORDER BY PPVM_PARAMETER_VALUE"
                Dim seventeen As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '51' AND PPVM_PARAMETER_CODE = '12' ORDER BY PPVM_PARAMETER_VALUE"
                Dim eighteen As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '51' AND PPVM_PARAMETER_CODE = '13' ORDER BY PPVM_PARAMETER_VALUE"
                Dim nineteen As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '51' AND PPVM_PARAMETER_CODE = '13' ORDER BY PPVM_PARAMETER_VALUE"
                Dim twenty As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '51' AND PPVM_PARAMETER_CODE = '14' ORDER BY PPVM_PARAMETER_VALUE"

                'Accessories
                Dim twentyone As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '03' AND PPVM_PARAMETER_CODE = '02' ORDER BY PPVM_PARAMETER_VALUE"      'Positioner
                Dim twentytwo As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '06' AND PPVM_PARAMETER_CODE = '02' ORDER BY PPVM_PARAMETER_VALUE"      'SOV
                Dim twentythree As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '04' AND PPVM_PARAMETER_CODE = '02' ORDER BY PPVM_PARAMETER_VALUE"    'AFR
                Dim twentyfour As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '05' AND PPVM_PARAMETER_CODE = '02' ORDER BY PPVM_PARAMETER_VALUE"     'ALR
                Dim twentyfive As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '07' AND PPVM_PARAMETER_CODE = '02' ORDER BY PPVM_PARAMETER_VALUE"     'Limit Switch
                Dim twentysix As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '13' AND PPVM_PARAMETER_CODE = '02' ORDER BY PPVM_PARAMETER_VALUE"      'Vol Booster
                Dim twentyseven As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '08' AND PPVM_PARAMETER_CODE = '02' ORDER BY PPVM_PARAMETER_VALUE"    'Pos Trans
                Dim twentyeight As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '12' AND PPVM_PARAMETER_CODE = '02' ORDER BY PPVM_PARAMETER_VALUE"    'Pressure Regulator / Robotor
                Dim twentynine As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '11' AND PPVM_PARAMETER_CODE = '02' ORDER BY PPVM_PARAMETER_VALUE"     'ItoP
                Dim thirty As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '10' AND PPVM_PARAMETER_CODE = '02' ORDER BY PPVM_PARAMETER_VALUE"         'Qev
                Dim thirtyone As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '03' AND PPVM_PARAMETER_CODE = '03' ORDER BY PPVM_PARAMETER_VALUE"      'Same as above but makes
                Dim thirtytwo As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '06' AND PPVM_PARAMETER_CODE = '03' ORDER BY PPVM_PARAMETER_VALUE"
                Dim thirtythree As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '04' AND PPVM_PARAMETER_CODE = '03' ORDER BY PPVM_PARAMETER_VALUE"
                Dim thirtyfour As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '05' AND PPVM_PARAMETER_CODE = '03' ORDER BY PPVM_PARAMETER_VALUE"
                Dim thirtyfive As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '07' AND PPVM_PARAMETER_CODE = '03' ORDER BY PPVM_PARAMETER_VALUE"
                Dim thirtysix As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '13' AND PPVM_PARAMETER_CODE = '03' ORDER BY PPVM_PARAMETER_VALUE"
                Dim thirtyseven As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '08' AND PPVM_PARAMETER_CODE = '03' ORDER BY PPVM_PARAMETER_VALUE"
                Dim thirtyeight As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '12' AND PPVM_PARAMETER_CODE = '03' ORDER BY PPVM_PARAMETER_VALUE"
                Dim thirtynine As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '11' AND PPVM_PARAMETER_CODE = '03' ORDER BY PPVM_PARAMETER_VALUE"
                Dim forty As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '10' AND PPVM_PARAMETER_CODE = '03' ORDER BY PPVM_PARAMETER_VALUE"
                Dim fortyone As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '20' AND PPVM_PARAMETER_CODE = '03' ORDER BY PPVM_PARAMETER_VALUE"      'Tubing
                Dim fortytwo As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '20' AND PPVM_PARAMETER_CODE = '02' ORDER BY PPVM_PARAMETER_VALUE"      'Tubing Make
                Dim fortythree As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '15' ORDER BY PPVM_PARAMETER_VALUE"       'Certification
                Dim fortyfour As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '20' AND PPVM_PARAMETER_CODE = '04' ORDER BY PPVM_PARAMETER_VALUE"     'Tubing Size
                Dim fortyfive As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '20' AND PPVM_PARAMETER_CODE = '05' ORDER BY PPVM_PARAMETER_VALUE"     'Tubing MOC
                Dim fortysix As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '16' AND PPVM_PARAMETER_CODE = '12' ORDER BY PPVM_PARAMETER_VALUE"     'Painting Body
                Dim fortyseven As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '02' AND PPVM_PARAMETER_CODE = '14' ORDER BY PPVM_PARAMETER_VALUE"    'Handwheel
                Dim fortyeight As String = "select PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM XXFMPC_PARA_VALUE_MASTER_VW WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '02' AND PPVM_PARAMETER_CODE = '06' ORDER BY PPVM_PARAMETER_VALUE"     'Air Fail Mode

                Using conn As New OracleConnection(oconstr)
                    'ECOTROL --> MATERIALS
                    commands = New OracleCommand(ones, conn)
                    adapters.SelectCommand = commands
                    adapters.Fill(ods, "AABODYMAT")
                    adapters.SelectCommand.CommandText = twos
                    adapters.Fill(ods, "AATOPMAT")
                    adapters.SelectCommand.CommandText = three
                    adapters.Fill(ods, "AAPLUG")
                    adapters.SelectCommand.CommandText = four
                    adapters.Fill(ods, "AASEAT")
                    adapters.SelectCommand.CommandText = five
                    adapters.Fill(ods, "AAGASKETMAT")

                    'FMCV --> MATERIALS
                    adapters.SelectCommand.CommandText = six
                    adapters.Fill(ods, "AABODYMAT_FMCV")
                    adapters.SelectCommand.CommandText = seven
                    adapters.Fill(ods, "AATOPMAT_FMCV")
                    adapters.SelectCommand.CommandText = eight
                    adapters.Fill(ods, "AAPLUG_FMCV")
                    adapters.SelectCommand.CommandText = nine
                    adapters.Fill(ods, "AASEAT_FMCV")
                    adapters.SelectCommand.CommandText = ten
                    adapters.Fill(ods, "AAGASKETMAT_FMCV")

                    '3-WAY --> MATERIALS
                    adapters.SelectCommand.CommandText = eleven
                    adapters.Fill(ods, "AABODYMAT_3WAY")
                    adapters.SelectCommand.CommandText = twelve
                    adapters.Fill(ods, "AATOPMAT_3WAY")
                    adapters.SelectCommand.CommandText = thirteen
                    adapters.Fill(ods, "AAPLUG_3WAY")
                    adapters.SelectCommand.CommandText = fourteen
                    adapters.Fill(ods, "AASEAT_3WAY")
                    adapters.SelectCommand.CommandText = fifteen
                    adapters.Fill(ods, "AAGASKETMAT_3WAY")

                    'PRDS --> MATERIALS
                    adapters.SelectCommand.CommandText = sixteen
                    adapters.Fill(ods, "AABODYMAT_PRDS")
                    adapters.SelectCommand.CommandText = seventeen
                    adapters.Fill(ods, "AATOPMAT_PRDS")
                    adapters.SelectCommand.CommandText = eighteen
                    adapters.Fill(ods, "AAPLUG_PRDS")
                    adapters.SelectCommand.CommandText = nineteen
                    adapters.Fill(ods, "AASEAT_PRDS")
                    adapters.SelectCommand.CommandText = twenty
                    adapters.Fill(ods, "AAGASKETMAT_PRDS")

                    'ACCESSORIES
                    adapters.SelectCommand.CommandText = twentyone
                    adapters.Fill(ods, "AAPOSITIONERMAKE")
                    adapters.SelectCommand.CommandText = twentytwo
                    adapters.Fill(ods, "AASOVMAKE")
                    adapters.SelectCommand.CommandText = twentythree
                    adapters.Fill(ods, "AAFRMAKE")
                    adapters.SelectCommand.CommandText = twentyfour
                    adapters.Fill(ods, "AALRMAKE")
                    adapters.SelectCommand.CommandText = twentyfive
                    adapters.Fill(ods, "AALIMITSWITCHMAKE")
                    adapters.SelectCommand.CommandText = twentysix
                    adapters.Fill(ods, "AAVOLBOOSTERMAKE")
                    adapters.SelectCommand.CommandText = twentyseven
                    adapters.Fill(ods, "AAPOSTRANSMAKE")
                    adapters.SelectCommand.CommandText = twentyeight
                    adapters.Fill(ods, "AAROBOTORMAKE")
                    adapters.SelectCommand.CommandText = twentynine
                    adapters.Fill(ods, "AAITOPMAKE")
                    adapters.SelectCommand.CommandText = thirty
                    adapters.Fill(ods, "AAQEVMAKE")
                    adapters.SelectCommand.CommandText = thirtyone
                    adapters.Fill(ods, "AAPOSITIONER")
                    adapters.SelectCommand.CommandText = thirtytwo
                    adapters.Fill(ods, "AASOV")
                    adapters.SelectCommand.CommandText = thirtythree
                    adapters.Fill(ods, "AAFR")
                    adapters.SelectCommand.CommandText = thirtyfour
                    adapters.Fill(ods, "AALR")
                    adapters.SelectCommand.CommandText = thirtyfive
                    adapters.Fill(ods, "AALIMITSWITCH")
                    adapters.SelectCommand.CommandText = thirtysix
                    adapters.Fill(ods, "AAVOLBOOSTER")
                    adapters.SelectCommand.CommandText = thirtyseven
                    adapters.Fill(ods, "AAPOSTRANS")
                    adapters.SelectCommand.CommandText = thirtyeight
                    adapters.Fill(ods, "AAROBOTOR")
                    adapters.SelectCommand.CommandText = thirtynine
                    adapters.Fill(ods, "AAITOP")
                    adapters.SelectCommand.CommandText = forty
                    adapters.Fill(ods, "AAQEV")
                    adapters.SelectCommand.CommandText = fortyone
                    adapters.Fill(ods, "AATUBING")
                    adapters.SelectCommand.CommandText = fortytwo
                    adapters.Fill(ods, "AATUBINGMAKE")
                    adapters.SelectCommand.CommandText = fortythree
                    adapters.Fill(ods, "AACERTIFICATION")
                    adapters.SelectCommand.CommandText = fortyfour
                    adapters.Fill(ods, "AATUBING_SIZE")
                    adapters.SelectCommand.CommandText = fortyfive
                    adapters.Fill(ods, "AATUBING_MOC")
                    adapters.SelectCommand.CommandText = fortysix
                    adapters.Fill(ods, "AAPAINT_BODY")
                    adapters.SelectCommand.CommandText = fortyseven
                    adapters.Fill(ods, "AAHANDWHEEL")
                    adapters.SelectCommand.CommandText = fortyeight
                    adapters.Fill(ods, "AAIRFAIL")
                End Using

                Dim s As Integer = 0
                For Each table As DataTable In ods.Tables
                    table.Columns.Add("SR_NOS")
                    Dim j As Integer = 1
                    For Each row As DataRow In ods.Tables(s).Rows
                        row.Item("SR_NOS") = j
                        j += 1
                    Next
                    s += 1
                Next

                'Connecting to SQL Server to upload the data
                Dim constrr As String = "Data Source=.\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=true;"
                Dim i As Integer
                For i = 0 To ods.Tables.Count - 1

                    'If table is not empty then update
                    If ods.Tables(i).Rows.Count > 0 Then

                        'First Delete existing Records:
                        Dim connect As New SqlConnection
                        Dim cmd As New SqlCommand
                        Try
                            connect.ConnectionString = constrr
                            connect.Open()
                            cmd.Connection = connect
                            cmd.CommandText = "delete from " + ods.Tables(i).ToString() '+ " where model_code is not null"
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            connect.Dispose()
                        Catch ex As Exception
                            MsgBox("CONNETION TO DELETE" & ex.Message)
                            WriteToFile(ex.Message.ToString() + Environment.NewLine + ex.StackTrace)
                            'Me.ScheduleService()
                        End Try

                        'Put new records in the same table
                        Using con As New SqlConnection(constrr)

                            Using copy As New SqlBulkCopy(con)
                                copy.DestinationTableName = "dbo." + ods.Tables(i).ToString()

                                copy.ColumnMappings.Add("SR_NOS", "SR_NO")
                                copy.ColumnMappings.Add("PPVM_MODEL_NO", "MODEL_CODE")
                                copy.ColumnMappings.Add("PPVM_CATEGORY_CODE", "CATEGORY_CODE")
                                copy.ColumnMappings.Add("PPVM_PARAMETER_CODE", "PARAMETER_CODE")
                                copy.ColumnMappings.Add("PPVM_PARAMETER_VALUE_CODE", "PARAMETER_VALUE_CODE")
                                copy.ColumnMappings.Add("PPVM_PARAMETER_VALUE", "PARAMETER_VALUE")
                                copy.ColumnMappings.Add("PPVM_SHORT_DESC", "PARAMETER_DESC")
                                copy.ColumnMappings.Add("CREATION_DATE", "CREATION_DATE")
                                copy.ColumnMappings.Add("CREATED_BY", "CREATED_BY")
                                copy.ColumnMappings.Add("LAST_UPDATED_DATE", "UPDATED_DATE")
                                copy.ColumnMappings.Add("LAST_UPDATED_BY", "UPDATED_BY")

                                con.Open()
                                copy.WriteToServer(ods.Tables(i))
                                con.Close()
                            End Using
                        End Using
                    End If
                Next
                WriteToFile("UPDATED " + ods.Tables.Count.ToString() + " TABLES TO SQL.")
                Cursor = Cursors.Default
                MessageBox.Show("Updated " + ods.Tables.Count.ToString() + " TABLES TO SQL DB.")
            End If
        Catch ex As Exception
            WriteToFile(ex.Message + Environment.NewLine + ex.StackTrace)
            MessageBox.Show("Error while updating local SQL Tables." + Environment.NewLine + "Please restart the application and try again." + Environment.NewLine + "If the problem still continues, please inform the developer.")
        End Try
    End Sub

    'Function To Write to Notepad File
    Private Sub WriteToFile(text As String)
        Dim path As String = "D:\ServiceLog.txt"
        Using writer As New StreamWriter(path, True)
            writer.WriteLine(String.Format(text + " at: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
            writer.Close()
        End Using
    End Sub

    Private Sub DGV_Records_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Records.CellMouseClick
        DGV_Records.CurrentRow.Selected = True
    End Sub
End Class