Imports System.Data
'Imports Microsoft.Office
'Imports excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Public Module Declarations


    Public AppPath As String = Application.StartupPath
    Public XMLFilename As String
    Public FILETYPE As Boolean           'Loading or Saving option 
    Public AbandonSoftware As Boolean = False           'If error during Form Load then do not go through save feature
    Public CLoseSoftware As Boolean = False

    Public VersionDate As String = " 24 May 2023"
    Public VersionNo As String = "v6.3.0.16"

    'Branch, SalesEngg, CustomerRef, OfferNo, GSN, LSN, Customer, Project, Date
    Public cnt As Integer = 0
    Public val(7) As String
    Public col() As String = {"Branch", "SalesEngg", "CustomerRef", "OfferNo", "GSN", "LSN", "Customer", "Project"}
    'Variables added for SQL
    Public LSN As Integer = Nothing
    Public GSN As Integer = Nothing
    Public query, Branch As String


    'Datasets
    Public ods As New DataSet

    Public dtr As New DataTable

    Public ds_AccessoriesMat As New DataSet
    Public ds_AFOSingleSpring, ds_AFCSingleSpring, ds_AFOMultiSpring, ds_AFCMultiSpring, ds_FL, ds_FR, ds_PipeSchedule1, ds_PipeSchedule2, ds_RatingClass_150300, ds_RatingClass_600900 As DataSet
    Public ds_A216GrWCB, ds_A217GrWC6, ds_A351GrCF8M, ds_A216GrWCC, ds_A351GrCF3, ds_A351GrCF3M, ds_A217GrWC9, ds_A351GrCF8C, ds_A352GrLCB, ds_A217GrC5, ds_A351GrCD4MCu, ds_A217GrC12A, ds_A351GrCN7M, ds_A494GrCW12MW As DataSet
    Public ds_KvforCage150300, ds_KvforCage600900, ds_Water_Temp_Properties, ds_Travel150300, ds_Travel6001500, ds_SealingForce150300, ds_SealingForce6001500, ds_FrictionForce150300, ds_FrictionForce6001500, ds_SeatingForceLC6150300, ds_SeatingForceLC66001500 As DataSet

    Public DT_AccessoriesMat, DT_AFOSingleSpring, DT_AFCSingleSpring, DT_AFOMultiSpring, DT_AFCMultiSpring, DT_AFOSingleSpringE, DT_AFCSingleSpringE, DT_AFOMultiSpringE, DT_AFCMultiSpringE, DT_FL, DT_FR, DT_PipeSchedule1, DT_PipeSchedule2, DT_RatingClass_150300, DT_RatingClass_600900, DT_3WAY_300 As DataTable
    Public DT_A216GrWCB, DT_A217GrWC6, DT_A351GrCF8M, DT_A216GrWCC, DT_A351GrCF3, DT_A351GrCF3M, DT_A217GrWC9, DT_A351GrCF8C, DT_A352GrLCB, DT_A217GrC5, DT_A351GrCD4MCu, DT_A217GrC12A, DT_A351GrCN7M, DT_A494GrCW12MW As DataTable
    Public DT_KvforCage150300, DT_KvforCage600900, DT_Water_Temp_Properties, DT_Travel150300, DT_Travel6001500, DT_SealingForce150300, DT_SealingForce6001500, DT_FrictionForce150300, DT_FrictionForce6001500, DT_SeatingForceLC6150300, DT_SeatingForceLC66001500 As DataTable
    Public ds_Perforated As DataSet
    Public DT_PS3150300KV, DT_PS3600900KV, DT_PR1150300KV, DT_PR1600900KV, DT_PR2150300KV, DT_PR2600900KV, DT_PR3150300KV, DT_PR3600900KV, DT_PR12500KV, DT_PR22500KV, DT_PR32500KV, DT_PS32500KV As DataTable
    Public DT_TEPRDSL2150300, DT_TEPRDSL2600900, DT_TEPRDSL3150300, DT_TEPRDSPR3600900, DT_BEPRDSP1150300, DT_BEPRDSP1600900, DT_BEPRDSL2150300, DT_BEPRDSL2600900, DT_BEPRDSL3150300, DT_BEPRDSL3600900 As DataTable
    Public dv As DataView           'this is used for Sorting and filtering the datatable
    Public DT_FLtable As DataTable

    Public DT_KvforCage2500, DT_Travel2500, DT_SealingForce2500, DT_FrictionForce2500, DT_SeatingForceLC62500 As DataTable

    Public ScrollValue As Integer

    'open office '
    Public oSheet As Object
    Public osheet1 As Object
    Public oSm
    Public oDesk, oDoc As Object
    Public ds_OpenOfficePrint As DataSet
    Public ds_OpenOfficeCSV As DataSet
    Public dt_OpenOfficeCSV As DataTable
    Public Temp_TagName, TempTagName1 As String
    'Variable Declaration
    Public Maxdia As Single
    Public LoadingForm As Boolean
    Public VelocityRuleFlag As Boolean

    '  Public APP As New excel.Application
    ' Public worksheet As excel.Worksheet
    ' Public workbook As excel.Workbook
    Public LastColumn As Long
    Public LastRow As Long

    Public Case1Present, Case2Present, Case3Present As Boolean

    Public FinalInletPressureCase1 As Single
    Public FinalInletPressureCase2 As Single
    Public FinalInletPressureCase3 As Single

   Public FinalOutletPressureCase1, BaffleOutletPressureCase1 As Single
    Public FinalOutletPressureCase2, BaffleOutletPressureCase2 As Single
    Public FinaloutletPressureCase3, BaffleOutletPressureCase3 As Single

    Public FinalPressureDropCase1 As Single
    Public FinalPressureDropCase2 As Single
    Public FinalPressureDropCase3 As Single

    Public FinalChokedPressureCase1 As Single
    Public FinalChokedPressureCase2 As Single
    Public FinalChokedPressureCase3 As Single

    Public FinalInletTemperatureCase1 As Single
    Public FinalInletTemperatureCase2 As Single
    Public FinalInletTemperatureCase3 As Single

    Public FinalCriticalPressureCase1 As Single
    Public FinalCriticalPressureCase2 As Single
    Public FinalCriticalPressureCase3 As Single

    Public FinalVapourPressureCase1 As Single
    Public FinalVapourPressureCase2 As Single
    Public FinalVapourPressureCase3 As Single

    Public FinalDensityCase1, BaffleDensityCase1 As Single
    Public FinalDensityCase2, BaffleDensityCase2 As Single
    Public FinalDensityCase3, BaffleDensityCase3 As Single

    Public FinalViscosityCase1 As Single
    Public FinalViscosityCase2 As Single
    Public FinalViscosityCase3 As Single

    Public FinalFlowrateCase1 As Single
    Public FinalFlowrateCase2 As Single
    Public FinalFlowrateCase3 As Single


    Public FinalKVCase1 As Single
    Public FinalKVCase2 As Single
    Public FinalKVCase3 As Single

    Public InitialKVCase1 As Single
    Public InitialKVCase2 As Single
    Public InitialKVCase3 As Single


    Public FinalCVCase1 As Single
    Public FinalCVCase2 As Single
    Public FinalCVCase3 As Single

    'Stage 2
    Public FinalDesignPressureInlet As Single
    Public FinalDesignPressureOutlet As Single
    Public FinalDesignTemperatureInlet As Single
    Public FinalDesignTemperatureOutlet As Single

    Public DesiredRating As Single
    Public SuggestedRating, SuggestedRatingArray(6) As Single
    Public FinalRating As Single
    Public RatingFlag As Boolean = False
    Public PipediaFlag As Boolean = False
    Public ShowPipeFlag As Boolean = False
    Public Areaunitschange As Boolean = False
    Public Temp_Noise_OutletPipeDia As Single

    Public FinalKVmax_ValveSize, FinalValveSize, ID As Single

    Public FlowrateForPipeDiaCalcCase1, FlowrateForPipeDiaCalcCase2, FlowrateForPipeDiaCalcCase3 As Single
    Public BafflePipeVelCase1, BafflePipeVelCase2, BafflePipeVelCase3 As Single
    Public LinearKVruleFactors = New Single() {0.5, 0.6, 0.7, 0.8, 0.9, 0.95, 1}
    Public EQPercentKVruleFactors = New Single() {0.183, 0.257, 0.36, 0.506, 0.712, 0.844, 1}

    Public FinalPipeOutletSize, PipeOutletSize(100), ScheduleArray(25), InletScheduleArray(25), InletPipeSize, PipeInletSizeArray(100), PipeInletODArray(100), PipeInletOD As Single
    Public InletPipeID As Single
    Public ArrPointer_PipeOutletSize As Integer
    Public TrimName = New String() {"PS1", "PS3", "PR1", "PR2", "PR3", "P1", "P3", "L1", "L2", "L3"}

    'For Corrected KV calculations


    Public MaximumKV, MaxKVfromRatingClass, MaxKVfromRatingClass_old As Single
    Public FinalOverrideRatings, PercentageKVCase1, PercentageKVCase2, PercentageKVCase3 As Single
    Public FLCase1, FLCase2, FLCase3, FDCase1, FDCase2, FDCase3, FRCase1, FRCase2, FRCase3 As Single
    Public KVarray() As Single
    Public KvCase1, KvCase2, KvCase3, KVmax, TempKvCase1, TempKvCase2, TempKvCase3 As Single
    Public CorrectedKvCase1, CorrectedKvCase2, CorrectedKvCase3, KVforRenoyldNoCase1, KVforRenoyldNoCase2, KVforRenoyldNoCase3 As Single
    Public SeatDia, N1, N2, N4, RenoyldNoCase1, RenoyldNoCase2, RenoyldNoCase3, PrBl_SeatDia As Single
    Public Microtrim As String
    Public FinalKVCount, NextMaxKVcount As Byte
    Public FinalShowKVCase1(5), FinalShowKVCase2(5), FinalShowKVCase3(5), MaxKVsfromChart(5), MaxCvsfromChart(5) As Single
    Public FLCase1_array(5), FLCase2_array(5), FLCase3_array(5), FDCase1_array(5), FDCase2_array(5), FDCase3_array(5), SeatDia_array(5), PrBl_SeatDia_array(5) As Single
    Public MicroTrim_Array(5) As String
    Public FPKVCase1, FPKVCase2, FPKVCase3, KVAttenuatedCase1, KVAttenuatedCase2, KVAttenuatedCase3 As Single
    Public XF1Case1, XF1Case2, XF1Case3, XFzCase1, XFzCase2, XFzCase3 As Single     'For Severity
    Public SuggestedKVArray(5) As Single
    Public ValveSizeArray(20), FinalValveSizeforNoise(20) As Single
    Public ValveSizeFound As Boolean
    Public FinalVelocityRule As Single

    Public FlashingCase1, FlashingCase2, FlashingCase3, Hardnened_Cavitation_Choking As Boolean

    Public FP, StrokeCase1, StrokeCase2, StrokeCase3 As Single '

    Public NoFPCalc As Boolean = True

    Public FlowTypeCase1(5), FlowTypeCase2(5), FlowTypeCase3(5), TurbulentCase1, TurbulentCase2, TurbulentCase3 As Boolean
    Public KVMaxAcceptButton, ValveSizeAcceptButton As Boolean
    'Noise Variables
    Public Noise_FlowrateCase1, Noise_FlowrateCase2, Noise_FlowrateCase3, Noise_InletPressureCase1, Noise_InletPressureCase2, Noise_InletPressureCase3, Noise_OutletPressureCase1, Noise_OutletPressureCase2, Noise_OutletPressureCase3 As Single
    Public Noise_VapourPressureCase1, Noise_VapourPressureCase2, Noise_VapourPressureCase3, Noise_DensityCase1, Noise_DensityCase2, Noise_DensityCase3 As Single
    Public Noise_PipeThicknessCase1, Noise_PipeThicknessCase2, Noise_PipeThicknessCase3, Noise_DensityPipe, Noise_DensityAir, Noise_SoundVelocityLiquid, Noise_SoundVelocityAir As Single
    Public Noise_ValveID, Noise_Schedule, Noise_ID, Noise_OutletPipeDia As Single
    Public Stages As Byte
    Public Dt_NoisePrStages As DataTable

    Public N_LpiTurbCase1(33), N_LpiTurbCase2(33), N_LpiTurbCase3(33), N_LpiCavCase1(33), N_LpiCavCase2(33), N_LpiCavCase3(33), DeltaTL(33), TL(33) As Single
    Public N_LpeCase1(33), N_LpeCase2(33), N_LpeCase3(33), FinalNoiseLevelCase1, FinalNoiseLevelCase2, FinalNoiseLevelCase3, AttneuatedNoiseLevelCase1, AttneuatedNoiseLevelCase2, AttneuatedNoiseLevelCase3, TempLpCase1, TempLpCase2, TempLpCase3 As Single
    Public LpiofBaffleCase1(33), LpiofBaffleCase2(33), LpiofBaffleCase3(33)
    Public N_FlowTypeCAse1, N_FlowTypeCAse2, N_FlowTypeCase3 As Byte

    Public KvforCage, Cage_PressureCase1, Cage_PressureCase2, FinalInletPressureCase2Cage_PressureCase2, Cage_PressureCase3 As Single
    Public NoiseAttenuationFlag As Boolean
    Public FrequencyIndexBand() As Single = {12.5, 16, 20, 25, 31.5, 40, 50, 63, 80, 100, 125, 160, 200, 250, 315, 400, 500, 630, 800, 1000, 1250, 1600, 2000, 2500, 3150, 4000, 5000, 6300, 8000, 10000, 12500, 16000, 20000}
    Public N_DeltaLA() As Single = {-63.4, -56.7, -50.5, -44.7, -39.4, -34.6, -30.2, -26.2, -22.5, -19.1, -16.1, -13.4, -10.9, -8.6, -6.6, -4.8, -3.2, -1.9, -0.8, 0, 0.6, 1.0, 1.2, 1.3, 1.2, 1.0, 0.5, -0.1, -1.1, -2.5, -4.3, -6.6, -9.3}


    Public FluidType As Byte
    Public TsatCase1, TsatCase2, TsatCase3, ToutPressureCase1, ToutPressureCase2, ToutPressureCase3, ToutsatPressureCase1, ToutsatPressureCase2, ToutsatPressureCase3, Kcase1, Kcase2, Kcase3, Zcase1, Zcase2, Zcase3, Xcase1, Xcase2, Xcase3, XChokecase1, XChokecase2, XChokecase3 As Single
    Public SteamDensityCase1, SteamDensityCase2, SteamDensityCase3 As Single
    Public Temperatureflag As Boolean

    Public SelectP2orDP As Boolean = False
    Public MolecularWeight As Single

    Public FluidVelocityCase1, FluidVelocityCase2, FluidVelocityCase3 As Single
    Public ValveSize_MACNO, Xtcase1, Xtcase2, Xtcase3, Ycase1, Ycase2, Ycase3, YChokecase1, YChokecase2, YChokecase3, FL As Single

    Public OutletDensityCase1, OutletDensityCase2, OutletDensityCase3, SoundVelocityCase1, SoundVelocityCase2, SoundVelocityCase3 As Single
    Public BaffleSoundVelocityCase1, BaffleSoundVelocityCase2, BaffleSoundVelocityCase3 As Single

    Public PvcCase1, PvcCase2, PvcCase3, XvccCase1, XvccCase2, XvccCase3, XcCase1, XcCase2, XcCase3 As Single
    Public aCase1, aCase2, aCase3, XbCase1, XbCase2, XbCase3, XceCase1, XceCase2, XceCase3 As Single
    Public MvcCase1, R_NCase1, R_FpCase1, TvcCase1, R_CvCase1, WmCase1, DjCase1, WaCase1 As Single
    Public MvcCase2, R_NCase2, R_FpCase2, TvcCase2, R_CvCase2, WmCase2, DJcase2, WaCase2 As Single
    Public MvcCase3, R_NCase3, R_FpCase3, TvcCase3, R_CvCase3, WmCase3, DJcase3, WaCase3 As Single
    Public MachnoOutletCase1, MachnoOutletCase2, MachnoOutletCase3, MachPipeOutletCase1, MachPipeOutletCase2, MachPipeOutletCase3, LgCase1, LgCase2, LgCase3, LpiCase1, LpiCase2, LpiCase3, LpifiCase1(32), LpifiCase2(32), LpifiCase3(32) As Single
    Public UpCase1, UpCase2, UpCase3, UrCase1, UrCase2, UrCase3, WmRCase1, WmRCase2, WmRCase3, fpRcase1, fpRcase2, fpRcase3, Mrcase1, Mrcase2, Mrcase3, Nrcase1, Nrcase2, Nrcase3, WarCase1, WarCase2, WarCase3, LpiRCase1, LpiRCase2, LpiRCase3, LpiRfiCase1(32), LpiRfiCase2(32), LpiRfiCase3(32) As Single
    Public LpiSfiCase1(32), LpiSfiCase2(32), LpiSfiCase3(32), An, Stp As Single
    Public RingFrequency, InternalCoincidenceFrequencyCase1, InternalCoincidenceFrequencyCase2, InternalCoincidenceFrequencyCase3, ExternalCoincidenceFrequency As Single
    Public GxCase1(32), GxCase2(32), GxCase3(32), GyCase1(32), GyCase2(32), GyCase3(32), Ns(32), Compressible_DeltaTL, TLCase1(32), TLCase2(32), TLCase3(32), LpeCase1(32), LpeCase2(32), LpeCase3(32) As Single
    Public FinalNoiseCase1, FinalNoiseCase2, FinalNoiseCase3 As Single
    Public RegimeCase As Byte
    Public NoiseAttenuation_Compressible_CageAsInlet_Flag, NoiseAttenuation_Compressible_CageAsOutlet_Flag As Boolean
    Public Lpifi_CageOutletCase1(32), Lpifi_CageOutletCase2(32), Lpifi_CageOutletCase3(32), Lpifi_CageInletCase1(32), Lpifi_CageInletCase2(32), Lpifi_CageInletCase3(32) As Single
    Public Lpifi_TotalCase1(32), Lpifi_TotalCase2(32), Lpifi_TotalCase3(32) As Single

    'New Actuator Paramters
    Public PackingTypeFactor, PackingMaterialFactor, PackingHeight, PrBl_TrimFactor As Single

    Public Fluidforce, SeatingForce, FrictionForce, StemDia, SealingForce, FinalForceOpen, FinalForceClose, FinalForce, SleeveDia, Travel, SupplyAirPressure, DPShutoff, DiaphragmArea As Single
    Public Actuator, FinalActuator, MKSActuator As String
    Public InitialSpringRange, FinalSpringRange, MKSInitialSpringRange, MKSFinalSpringRange, Spring_Initial(70), Spring_Final(70), MKSSpring_Initial(70), MKSSpring_Final(70), F_SpringThrust(70), F_AirThrust(70) As Single
    Public DrynessFraction_LiquidCase1, DrynessFraction_LiquidCase2, DrynessFraction_LiquidCase3 As Single
    Public NoiseInsulation As Single
    Public NoofSprings, Spring_Numbers(70) As Byte
    Public FlowSeverityCase1, FlowSeverityCase2, FlowSeverityCase3 As String

    Public Const PipeVelocity As Single = 4
    Public DontgotoKvRuleEvent As Boolean
    Public Model As Byte
    Public ValveModel As String    ' For Final VAlve Model :  13102020 Changes

    Public MaxPressure, MaxTemperature As Single
    Public tempNoiseCase1, tempNoiseCase2, tempNoiseCase3, tempAttenuationNoiseCase1, tempAttenuationNoiseCase2, tempAttenuationNoiseCase3 As Single
    Public VelocityValveOutletCase1, VelocityValveOutletCase2, VelocityValveOutletCase3, VelocityPipeCase1, VelocityPipeCase2, VelocityPipeCase3 As Single
    Public Resetall, ChangingUnitsType, ResetFlowarateIndex As Boolean

    'Public PositionerMake As String
    'Public Positioner As Integer = -1
    Public BodyMaterial, Plug, Seat, TopMaterials, Roborter, Gasket, Certification, Painting, Painting_ACC As Integer
    Public BonnetType, EndConnection, VTank, Handwheel, Guiding As String
    Public AFRMake, ALRMake, SOVMake, VBMake, LimitSwitchMake, QEVMake, PositionerMake, Tubing, TubingMake, TubingSize, TubingMOC As Integer
    Public Sov, AFR, ALR, LimitSwitch, VolBooster, PosnTrans, ItoP, QEV, Positioner As Integer
    '   Public PipeSheet1_worksheet, PipeSheet2_worksheet, RatingClass_worksheet, FL_worksheet, FR_worksheet, Accessories_Materials_worksheet, Water_Temp_Properties_worksheet As excel.Worksheet
    '  Public PipeSchedule_workbook, RatingClass_workbook, FL_workbook, FR_workbook, Accessories_Materials_workbook, Water_Temp_Properties_workbook, RatingsMaterial_workbook As excel.Workbook

    'Public ORACLE_CSV_workbook, Datasheet_workbook As excel.Workbook 'KVforCAGE_workbook, Actuator_workbook,
    'Public ORACLE_CSV_worksheet, Datasheet_worksheet As excel.Worksheet '' KVforCAGE_worksheet, Actuator_worksheet
    Public CompressibleChocked_Case1, CompressibleChocked_Case2, CompressibleChocked_Case3 As Single

    'Database declarations
    'Public Database_workbook As excel.Workbook
    'Public Database_worksheet As excel.Worksheet
    Public CurrentProjectFileName As String
    Public Database_LastColumn, Database_LastRow, Database_Rowno, PrintFromRecordNo, PrintToRecordNo As Integer
    Public LoadingProjectFile, ConfirmedPrinting As Boolean
    Public DataSection1_Field, DataSection2_MOC, DataSection3_Actuator, DataSection4_Materials, DataSection5_Output1, DataSection6_Output2 As Byte
    Public DataSection7_CalcValues, LastColumn_Values As Integer
    Public SameFileRecords As Boolean

    'Array to store data from Excel sheet. This will reduce time to read from excel sheet. 
    Public FL_Column1array(43), FL_Column2array(43), FL_Column5array(43), FR_Column1array(38), FR_Column2array(38) As Single
    '    FL_array(43,43,43) as Single = {{0,1,2.5,5,7.5,10,12.5,15,17.5,20,22.5,25,27.5,30,32.5,35,37.5,40,42.5,45,47.5,50,52.5,55,57.5,60,62.5,65,67.5,70,72.5,75,77.5,80,82.5,85,87.5,90,92.5,95,97.5,100}}
    Public TW_MaxKV150_FromSheet(25), TW_SeatDia150_FromSheet(25), TW_Valve150_FromSheet(25), TW_PrBl_SeatDia150_FromSheet(25) As Single
    Public MaxKV150_FromSheet(64), MaxKV600_FromSheet(35), SeatDia150_FromSheet(64), SeatDia600_FromSheet(35), PrBl_SeatDia150_FromSheet(64), PrBl_SeatDia600_FromSheet(35), Valve150_FromSheet(64), Valve600_FromSheet(35) As Single
    Public PS3_MaxKV150_FromSheet(47), PS3_MaxKV600_FromSheet(34), PS3_SeatDia150_FromSheet(47), PS3_SeatDia600_FromSheet(34), PS3_Valve150_FromSheet(47), PS3_Valve600_FromSheet(34) As Single
    Public BEPRDS_MaxKV150_FromSheet(64), BEPRDS_SeatDia150_FromSheet(64), BEPRDS_Valve150_FromSheet(64), BEPRDS_PrBl_SeatDia150_FromSheet(64) As Single
    Public BEPRDS_MaxKV600_FromSheet(35), BEPRDS_SeatDia600_FromSheet(35), BEPRDS_Valve600_FromSheet(35), BEPRDS_PrBl_SeatDia600_FromSheet(35) As Single


    Public TrimType150_Sheet(64), TrimType600_Sheet(35), PS3_TrimType150_Sheet(47), PS3_TrimType600_Sheet(35), TW_TrimType150_FromSheet(25), BEPRDS_TrimType150_FromSheet(64), BEPRDS_TrimType600_FromSheet(35) As String
    Public SeatDiaNPB_FromSheet() As Single
    Public SeatDiaPB_FromSheet() As Single
    Public NB_PipeDIa(37), INCH_PipeDia(37) As Single
    Public InletPipeSelected As Boolean = False

    'For Open Office 
    Public Recordnumber As UInteger
    Public LoadFromDataGrid As Boolean = False
    Public ds_OpenOffice As DataSet
    Public dt_OpenOffice As DataTable
    Public dttemp As DataTable
    'Copy Record
    Public SourceRecord, DestinationRecord As Long

    ''Customer Details
    Public CustomerName, ProjectName, TagNo, UserNotes1, UserNotes2, UserNotes3, OfferNo, Revision, CustomerRef As String
    Public SheetNo, QTY, ItemNo As UInt32
    Public FileName, FilenameExt, DirectoryName, FullPath As String
    Public SalesEnggName As String

    ''Baffle and MultiStage
    Public BaffleKVCase1, BaffleKVCase2, BaffleKVCase3, SuggestedValveSize As Single
    Public DT_NoiseAttenuation, DT_Baffles, DT_StageWiseNoise As DataTable
    Public DT_ActuatorInfo, DT_Flowtype, DT_ActuatorSelect As DataTable
    Public SelectedTrimNo, MFac_PR1, MFac_PR2, MFac_PR3, MFac_Cage As Byte

    Public InletWaterPressure, OutletWaterPressureCase1, OutletWaterPressureCase2, OutletWaterPressureCase3 As Single
    Public InletWaterTemperature, WaterFlowRateCase1, WaterFlowRateCase2, WaterFlowRateCase3 As Single
    Public TempFlowrateCase1, TempFlowrateCase2, TempFlowrateCase3, PRDS_IP_FlowrateForPipeDiaCase1, PRDS_IP_FlowrateForPipeDiaCase2, PRDS_IP_FlowrateForPipeDiaCase3 As Single
    Public PRDS_OP_FlowrateForPipeDiaCase1, PRDS_OP_FlowrateForPipeDiaCase2, PRDS_OP_FlowrateForPipeDiaCase3, tempOutletPressureCase1, tempOutletPressureCase2, tempOutletPressureCase3 As Single
    Public PRDS_OutletTemperatureCase1, PRDS_OutletTemperatureCase2, PRDS_OutletTemperatureCase3 As Single
    'Compressible Multistage
    Public PressureRatio(3) As Single

    ' Cavitation Array
    Public Structure CavitationVelocity
        'For CV- 0 =  Not cavitation, 1 - Incp.Cavitaion 2 - Severe Cavitation 3 - Choked Cavitation 4 - Flashing
        Public CVCase1 As Byte
        Public CVCase2 As Byte
        Public CVCase3 As Byte
        Public CVFinal As Byte
        Public VelCase1 As Single
        Public VelCase2 As Single
        Public VelCase3 As Single
        Public VelFinal As Single
    End Structure

    Public PS1, PS3, PR1, PR2, PR3 As CavitationVelocity
    Public dtb As New System.Data.DataTable


End Module

'Me.cmbFluid.Items.Add("Methyl bromide DegC")
'Me.cmbFluid.Items.Add("Methyl choride DegC")
'Me.cmbFluid.Items.Add("Methyl ethyl ketone DegC")
'Me.cmbFluid.Items.Add("Methyl isobutyl ketone DegC")
'Me.cmbFluid.Items.Add("Methyl methacrylate DegC")
'Me.cmbFluid.Items.Add("Methylamine DegC")
'Me.cmbFluid.Items.Add("Methylcyclohexane DegC")
'Me.cmbFluid.Items.Add("Naphthalene DegC")
'Me.cmbFluid.Items.Add("Nitrobenzene DegC")
'Me.cmbFluid.Items.Add("Nitromethane DegC")
'Me.cmbFluid.Items.Add("n-Nonane DegC")
'Me.cmbFluid.Items.Add("1-Nonane DegC")
'Me.cmbFluid.Items.Add("n-Octane DegC")
'Me.cmbFluid.Items.Add("i-Octane DegC")
'Me.cmbFluid.Items.Add("1-Octene DegC")
'Me.cmbFluid.Items.Add("n-Pentane DegC")
'Me.cmbFluid.Items.Add("i-Pentane DegC")
'Me.cmbFluid.Items.Add("1-Pentanol DegC")
'Me.cmbFluid.Items.Add("1-Pentene DegC")
'Me.cmbFluid.Items.Add("Phenol DegC")
'Me.cmbFluid.Items.Add("1-Propanol DegC")
'Me.cmbFluid.Items.Add("2-Propanol DegC")
'Me.cmbFluid.Items.Add("Propionic acid DegC")
'Me.cmbFluid.Items.Add("Propylene oxide DegC")
'Me.cmbFluid.Items.Add("Pyridine DegC")
'Me.cmbFluid.Items.Add("Styrene DegC")
'Me.cmbFluid.Items.Add("Toluene DegC")
'Me.cmbFluid.Items.Add("1,1,1-Trichloroethane DegC")
'Me.cmbFluid.Items.Add("1,1,2-Trichloroethane DegC")
'Me.cmbFluid.Items.Add("Trichloroethylene DegC")
'Me.cmbFluid.Items.Add("Vinyl acetate DegC")
'Me.cmbFluid.Items.Add("Water 0 to 60DegC")
'Me.cmbFluid.Items.Add("Water 60 to 150DegC")
'Me.cmbFluid.Items.Add("m-Xylene DegC")
'Me.cmbFluid.Items.Add("o-Xylene DegC")
'Me.cmbFluid.Items.Add("p-Xylene DegC")
'Me.cmbFluid.Items.Add("Acetaldehyde -0.2 to 34.4DegC")
'Me.cmbFluid.Items.Add("Acetic Acid 29.8 to 126.5DegC")
'Me.cmbFluid.Items.Add("Acetic Acid 0 to 36DegC")
'Me.cmbFluid.Items.Add("Acetic Anhydride 62.8 to 139.4DegC")
'Me.cmbFluid.Items.Add("Acetone -12.9 to 55.3DegC")
'Me.cmbFluid.Items.Add("Acrylic Acid DegC")
'Me.cmbFluid.Items.Add("Ammonia DegC")
'Me.cmbFluid.Items.Add("Aniline DegC")
'Me.cmbFluid.Items.Add("Benzene DegC")
'Me.cmbFluid.Items.Add("n-Butane DegC")
'Me.cmbFluid.Items.Add("i-Butane DegC")
'Me.cmbFluid.Items.Add("1-Butanol DegC")
'Me.cmbFluid.Items.Add("2-Butanol DegC")
'Me.cmbFluid.Items.Add("1-Butene DegC")
'Me.cmbFluid.Items.Add("Butyric Acid DegC")
'Me.cmbFluid.Items.Add("Carbon disulfide DegC")
'Me.cmbFluid.Items.Add("Carbon tetrachloride DegC")
'Me.cmbFluid.Items.Add("Cholorobenzene 0 to 42DegC")
'Me.cmbFluid.Items.Add("Cholorobenzene 42 to 230DegC")
'Me.cmbFluid.Items.Add("Chloroform -30 to 150DegC")
'Me.cmbFluid.Items.Add("Cyclohexane DegC")
'Me.cmbFluid.Items.Add("Cyclohexanol DegC")
'Me.cmbFluid.Items.Add("n-Decane DegC")
'Me.cmbFluid.Items.Add("1-Decene DegC")
'Me.cmbFluid.Items.Add("1,1-Dicholoroethane DegC")
'Me.cmbFluid.Items.Add("1,2-Dicholoroethane DegC")
'Me.cmbFluid.Items.Add("Dicholoromethane DegC")
'Me.cmbFluid.Items.Add("Diethyl ether DegC")
'Me.cmbFluid.Items.Add("Diethyl ketone DegC")
'Me.cmbFluid.Items.Add("Dimethylamine DegC")
'Me.cmbFluid.Items.Add("N,N-Dimethylformamide DegC")
'Me.cmbFluid.Items.Add("1,4-Dioxane DegC")
'Me.cmbFluid.Items.Add("Ethanol 19.6 to 93.4DegC")
'Me.cmbFluid.Items.Add("Ethanolamine DegC")
'Me.cmbFluid.Items.Add("Ethyl acetate -20 to 150DegC")
'Me.cmbFluid.Items.Add("Ethyl chloride DegC")
'Me.cmbFluid.Items.Add("Ethylbenzene 56.5 to 137.1DegC")
'Me.cmbFluid.Items.Add("Ethylene glycol DegC")
'Me.cmbFluid.Items.Add("Ethylene oxide DegC")
'Me.cmbFluid.Items.Add("1,2-Ethylenediamine DegC")
'Me.cmbFluid.Items.Add("Formaldehyde DegC")
'Me.cmbFluid.Items.Add("Formic Acid DegC")
'Me.cmbFluid.Items.Add("Glycerol DegC")
'Me.cmbFluid.Items.Add("n-Heptane DegC")
'Me.cmbFluid.Items.Add("i-Heptane DegC")
'Me.cmbFluid.Items.Add("n-Hexane DegC")
'Me.cmbFluid.Items.Add("i-Hexane DegC")
'Me.cmbFluid.Items.Add("Hydrogen Cyanide DegC")
'Me.cmbFluid.Items.Add("Methanol -20 to 140DegC")
'Me.cmbFluid.Items.Add("Methyl acetate DegC")
