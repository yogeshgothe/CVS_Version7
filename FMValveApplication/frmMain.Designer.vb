<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmValveSizing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValveSizing))
        Me.cmbMOC = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDesignPressureInlet = New System.Windows.Forms.TextBox()
        Me.txtDesignTemperatureInlet = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbSuggestedRating = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lblSuggestedRating = New System.Windows.Forms.Label()
        Me.lblFinalRating = New System.Windows.Forms.Label()
        Me.lblDesignPressure = New System.Windows.Forms.Label()
        Me.lblDesignTemperature = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbEndConnection = New System.Windows.Forms.ComboBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.cmbBonnetType = New System.Windows.Forms.ComboBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.lblCalculating = New System.Windows.Forms.Label()
        Me.lblCvSelected = New System.Windows.Forms.Label()
        Me.lblCVSugg = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblKvSelected = New System.Windows.Forms.Label()
        Me.lblKvSugg = New System.Windows.Forms.Label()
        Me.txtSuggestedKV = New System.Windows.Forms.TextBox()
        Me.cmbKVOverride = New System.Windows.Forms.ComboBox()
        Me.cmbValveSizeOverride = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtSuggestedValveSize = New System.Windows.Forms.TextBox()
        Me.lblSelectedCV = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lblKVMaxValue = New System.Windows.Forms.Label()
        Me.lblSelectedKV = New System.Windows.Forms.Label()
        Me.btnValveSizeAccept = New System.Windows.Forms.Button()
        Me.btnKVAccept = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbInletPipeSchedule = New System.Windows.Forms.ComboBox()
        Me.lblFinalOutletPipe = New System.Windows.Forms.Label()
        Me.lblSuggPipeSize = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbAreaunits = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_CustomerMain = New System.Windows.Forms.Label()
        Me.cmbPipeDia = New System.Windows.Forms.ComboBox()
        Me.cmbSchedule = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cmbInletPipeSize = New System.Windows.Forms.ComboBox()
        Me.btnAcceptVelocityRule = New System.Windows.Forms.Button()
        Me.lblFinalActuator = New System.Windows.Forms.Label()
        Me.lblSeatDiaUnits = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbAirPressureUnits = New System.Windows.Forms.ComboBox()
        Me.lblDPShutoffUnits = New System.Windows.Forms.Label()
        Me.txtSuggActuator = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cmbSelectActuator = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtAirPressure = New System.Windows.Forms.TextBox()
        Me.cmbActuatorType = New System.Windows.Forms.ComboBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.cmbSealing = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtDPShutoff = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cmbHandwheel = New System.Windows.Forms.ComboBox()
        Me.cmbPacking = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cmbBalancing = New System.Windows.Forms.ComboBox()
        Me.cmbLeakage = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cmbAirFailure = New System.Windows.Forms.ComboBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.lblKVCase1 = New System.Windows.Forms.Label()
        Me.lblKVCase2 = New System.Windows.Forms.Label()
        Me.lblKVCase3 = New System.Windows.Forms.Label()
        Me.lblApproxCVCase1 = New System.Windows.Forms.Label()
        Me.lblApproxCVCase2 = New System.Windows.Forms.Label()
        Me.lblApproxCVCase3 = New System.Windows.Forms.Label()
        Me.lblCalculatedKV = New System.Windows.Forms.Label()
        Me.lblCalculatedCV = New System.Windows.Forms.Label()
        Me.lblFinalKVCase1 = New System.Windows.Forms.Label()
        Me.lblFinalKvCase2 = New System.Windows.Forms.Label()
        Me.lblFinalKVcase3 = New System.Windows.Forms.Label()
        Me.lblFinalCVCase1 = New System.Windows.Forms.Label()
        Me.lblFinalCVCase2 = New System.Windows.Forms.Label()
        Me.lblFinalCVCase3 = New System.Windows.Forms.Label()
        Me.lblCorrectedKV = New System.Windows.Forms.Label()
        Me.lblCorrectedCV = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblStrokeCase1 = New System.Windows.Forms.Label()
        Me.lblStrokeCase2 = New System.Windows.Forms.Label()
        Me.lblStrokeCase3 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblFlowtypeCase1 = New System.Windows.Forms.Label()
        Me.lblFlowtypeCase2 = New System.Windows.Forms.Label()
        Me.lblFlowtypeCase3 = New System.Windows.Forms.Label()
        Me.lblFlowSeverity = New System.Windows.Forms.Label()
        Me.lblSeverityCase1 = New System.Windows.Forms.Label()
        Me.lblSeverityCase2 = New System.Windows.Forms.Label()
        Me.lblSeverityCase3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.lblFLCase3 = New System.Windows.Forms.Label()
        Me.lblFLCase2 = New System.Windows.Forms.Label()
        Me.lblFLCase1 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtFlashingPercentageCase3 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblNoiseCase2 = New System.Windows.Forms.Label()
        Me.lblMachnoValve = New System.Windows.Forms.Label()
        Me.lblNoiseCase3 = New System.Windows.Forms.Label()
        Me.lblMachnoPipe = New System.Windows.Forms.Label()
        Me.lblNoiseCase1 = New System.Windows.Forms.Label()
        Me.lblMachNoVavleOutCase1 = New System.Windows.Forms.Label()
        Me.chkNoiseAttenuation = New System.Windows.Forms.CheckBox()
        Me.lblMachNoVavleOutCase2 = New System.Windows.Forms.Label()
        Me.lblAttenuatedNoiseCase1 = New System.Windows.Forms.Label()
        Me.lblMachNoVavleOutCase3 = New System.Windows.Forms.Label()
        Me.lblAttenuatedNoiseCase2 = New System.Windows.Forms.Label()
        Me.lblMachNoPipeOutCase1 = New System.Windows.Forms.Label()
        Me.lblAttenuatedNoiseCase3 = New System.Windows.Forms.Label()
        Me.lblMachNoPipeOutCase2 = New System.Windows.Forms.Label()
        Me.chkInsulation = New System.Windows.Forms.CheckBox()
        Me.lblMachNoPipeOutCase3 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblAttnPressDropCase1 = New System.Windows.Forms.Label()
        Me.lblAttnPressDropCase2 = New System.Windows.Forms.Label()
        Me.lblAttnPressDropCase3 = New System.Windows.Forms.Label()
        Me.lblXT = New System.Windows.Forms.Label()
        Me.lblXTCase1 = New System.Windows.Forms.Label()
        Me.lblXTCase2 = New System.Windows.Forms.Label()
        Me.lblXTCase3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFlashingCaseNoAttenuation = New System.Windows.Forms.Label()
        Me.lblInsulationMessage = New System.Windows.Forms.Label()
        Me.lblFP = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblVelocityValveInletCase1 = New System.Windows.Forms.Label()
        Me.lblVelocityValveInletCase2 = New System.Windows.Forms.Label()
        Me.lblVelocityValveInletCase3 = New System.Windows.Forms.Label()
        Me.lblVelocityValveOutletCase1 = New System.Windows.Forms.Label()
        Me.lblVelocityValveOutletCase2 = New System.Windows.Forms.Label()
        Me.lblVelocityValveOutletCase3 = New System.Windows.Forms.Label()
        Me.lblVelocityOutletPipeCase1 = New System.Windows.Forms.Label()
        Me.lblVelocityOutletPipeCase2 = New System.Windows.Forms.Label()
        Me.lblVelocityOutletPipeCase3 = New System.Windows.Forms.Label()
        Me.lblVelocityunit = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblVelocityInletPipeCase3 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.lblVelocityInletPipeCase2 = New System.Windows.Forms.Label()
        Me.lblVelocityInletPipeCase1 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccessoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatasheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CRMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChartsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KvCvChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiagnosisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActuatorDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Dlg_SaveAs = New System.Windows.Forms.SaveFileDialog()
        Me.Dlg_OpenXML = New System.Windows.Forms.OpenFileDialog()
        Me.txtErrors = New System.Windows.Forms.TextBox()
        Me.lblDatabaseRowNo = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelPRDS = New System.Windows.Forms.Panel()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.txtP2OutWCase3 = New System.Windows.Forms.TextBox()
        Me.txtP2OutWCase2 = New System.Windows.Forms.TextBox()
        Me.txtP2OutWCase1 = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.lblPwUnits = New System.Windows.Forms.Label()
        Me.txtWaterPressure = New System.Windows.Forms.TextBox()
        Me.lblFlowWaterUnit = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.txtWaterFlowCase3 = New System.Windows.Forms.TextBox()
        Me.lblTwUnit = New System.Windows.Forms.Label()
        Me.txtWaterFlowCase2 = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.txtWaterTemperature = New System.Windows.Forms.TextBox()
        Me.txtWaterFlowCase1 = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtMedium = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTOutPressureCase3 = New System.Windows.Forms.TextBox()
        Me.txtTOutPressureCase2 = New System.Windows.Forms.TextBox()
        Me.txtTOutPressureCase1 = New System.Windows.Forms.TextBox()
        Me.lblToutPressure = New System.Windows.Forms.Label()
        Me.txtTsatInletCase3 = New System.Windows.Forms.TextBox()
        Me.txtTsatInletCase2 = New System.Windows.Forms.TextBox()
        Me.txtTsatInletCase1 = New System.Windows.Forms.TextBox()
        Me.lblTsatInletPress = New System.Windows.Forms.Label()
        Me.lblMolecularUnit = New System.Windows.Forms.Label()
        Me.chkViscosity = New System.Windows.Forms.CheckBox()
        Me.txtViscosityCase1 = New System.Windows.Forms.TextBox()
        Me.txtViscosityCase2 = New System.Windows.Forms.TextBox()
        Me.txtViscosityCase3 = New System.Windows.Forms.TextBox()
        Me.cmbViscosityUnits = New System.Windows.Forms.ComboBox()
        Me.txtTsatoutPressureCase3 = New System.Windows.Forms.TextBox()
        Me.txtTsatoutPressureCase2 = New System.Windows.Forms.TextBox()
        Me.txtTsatoutPressureCase1 = New System.Windows.Forms.TextBox()
        Me.lblTsatoutPressure = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.cmbQW = New System.Windows.Forms.ComboBox()
        Me.cmbFlowrate = New System.Windows.Forms.ComboBox()
        Me.txtFlowrateCase1 = New System.Windows.Forms.TextBox()
        Me.txtFlowrateCase2 = New System.Windows.Forms.TextBox()
        Me.txtFlowrateCase3 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFlashingPercentageCase2 = New System.Windows.Forms.TextBox()
        Me.txtK_Case2 = New System.Windows.Forms.TextBox()
        Me.txtFlashingPercentageCase1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFlashingPercentage = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPressureUnits = New System.Windows.Forms.ComboBox()
        Me.chkMolecularWeight = New System.Windows.Forms.CheckBox()
        Me.txtMolecularWeight = New System.Windows.Forms.TextBox()
        Me.txtInletPressureCase1 = New System.Windows.Forms.TextBox()
        Me.btnSelectP2DP = New System.Windows.Forms.Button()
        Me.txtInletPressureCase2 = New System.Windows.Forms.TextBox()
        Me.txtX_Case3 = New System.Windows.Forms.TextBox()
        Me.txtInletPressureCase3 = New System.Windows.Forms.TextBox()
        Me.txtX_Case1 = New System.Windows.Forms.TextBox()
        Me.txtOutletPressure1 = New System.Windows.Forms.TextBox()
        Me.txtX_Case2 = New System.Windows.Forms.TextBox()
        Me.txtOutletPressure2 = New System.Windows.Forms.TextBox()
        Me.lblX = New System.Windows.Forms.Label()
        Me.txtOutletPressure3 = New System.Windows.Forms.TextBox()
        Me.txtZ_Case3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtZ_Case2 = New System.Windows.Forms.TextBox()
        Me.txtPressureDropCase1 = New System.Windows.Forms.TextBox()
        Me.txtZ_Case1 = New System.Windows.Forms.TextBox()
        Me.txtPressureDropCase2 = New System.Windows.Forms.TextBox()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.txtPressureDropCase3 = New System.Windows.Forms.TextBox()
        Me.txtK_Case3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbTemperatureUnits = New System.Windows.Forms.ComboBox()
        Me.txtK_Case1 = New System.Windows.Forms.TextBox()
        Me.txtInletTemperatureCase1 = New System.Windows.Forms.TextBox()
        Me.txtInletTemperatureCase2 = New System.Windows.Forms.TextBox()
        Me.txtInletTemperatureCase3 = New System.Windows.Forms.TextBox()
        Me.lblDensity = New System.Windows.Forms.Label()
        Me.cmbDensityUnits = New System.Windows.Forms.ComboBox()
        Me.txtDensityCase1 = New System.Windows.Forms.TextBox()
        Me.txtDensityCase2 = New System.Windows.Forms.TextBox()
        Me.txtDensityCase3 = New System.Windows.Forms.TextBox()
        Me.lblCriticalPressure = New System.Windows.Forms.Label()
        Me.lblK = New System.Windows.Forms.Label()
        Me.lblVapourPressure = New System.Windows.Forms.Label()
        Me.txtCriticalPressureCase1 = New System.Windows.Forms.TextBox()
        Me.txtCriticalPressureCase2 = New System.Windows.Forms.TextBox()
        Me.txtCriticalPressureCase3 = New System.Windows.Forms.TextBox()
        Me.txtVapourPressureCase1 = New System.Windows.Forms.TextBox()
        Me.txtVapourPressureCase2 = New System.Windows.Forms.TextBox()
        Me.txtVapourPressureCase3 = New System.Windows.Forms.TextBox()
        Me.lblCriticalPressureUnit = New System.Windows.Forms.Label()
        Me.lblVapourPressureUnit = New System.Windows.Forms.Label()
        Me.cmbCriticalPressureUnits = New System.Windows.Forms.ComboBox()
        Me.cmbVapourPressureUnits = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.cmbUnitsType = New System.Windows.Forms.ComboBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.cmbFluidType = New System.Windows.Forms.ComboBox()
        Me.cmbFluid = New System.Windows.Forms.ComboBox()
        Me.lblViscosity = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblMicroTrim = New System.Windows.Forms.Label()
        Me.lblFinalValveSize = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmbSelectedTrim = New System.Windows.Forms.ComboBox()
        Me.txtSuggTrim = New System.Windows.Forms.TextBox()
        Me.cmbFlowDirection = New System.Windows.Forms.ComboBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbVelocityRule = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbKVseries = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbCharacterstics = New System.Windows.Forms.ComboBox()
        Me.lblValveModel = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.btnOverrideRating = New System.Windows.Forms.Button()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAcceptActuator = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.lblSel100PerF = New System.Windows.Forms.Label()
        Me.lblSel0PercF = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.lblForce100perc = New System.Windows.Forms.Label()
        Me.lblForce0perc = New System.Windows.Forms.Label()
        Me.lblForceUnits = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnChart = New System.Windows.Forms.Button()
        Me.cmbSeatDia = New System.Windows.Forms.ComboBox()
        Me.btnTables = New System.Windows.Forms.Button()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.LblCounter = New System.Windows.Forms.Label()
        Me.Percent3 = New System.Windows.Forms.Label()
        Me.Percent2 = New System.Windows.Forms.Label()
        Me.Percent1 = New System.Windows.Forms.Label()
        Me.ProgBarBaffle = New System.Windows.Forms.ProgressBar()
        Me.lblBaffleCv = New System.Windows.Forms.Label()
        Me.lblBaffleKV = New System.Windows.Forms.Label()
        Me.txtBaffleKVCase3 = New System.Windows.Forms.TextBox()
        Me.txtBaffleKVCase2 = New System.Windows.Forms.TextBox()
        Me.txtBaffleKVCase1 = New System.Windows.Forms.TextBox()
        Me.chkBaffleCase3 = New System.Windows.Forms.CheckBox()
        Me.chkBaffleCase2 = New System.Windows.Forms.CheckBox()
        Me.chkBaffleCase1 = New System.Windows.Forms.CheckBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.lblDatasheetPrinting = New System.Windows.Forms.Label()
        Me.lblPrintRecordNo = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.txtJumpToRecord = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtCustomerRefMain = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.txtRevisionNoMain = New System.Windows.Forms.TextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.txtSheetNo = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.txtItemNoMain = New System.Windows.Forms.TextBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.txtEnggNameMain = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.txtProjectMain = New System.Windows.Forms.TextBox()
        Me.txtTagNoMain = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtQTYMain = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOfferNoMain = New System.Windows.Forms.TextBox()
        Me.txtCustomerMain = New System.Windows.Forms.TextBox()
        Me.lblSalesEngg = New System.Windows.Forms.Label()
        Me.HScrollBar_Records = New System.Windows.Forms.HScrollBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelPRDS.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbMOC
        '
        Me.cmbMOC.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMOC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbMOC.FormattingEnabled = True
        Me.cmbMOC.Location = New System.Drawing.Point(124, 32)
        Me.cmbMOC.Name = "cmbMOC"
        Me.cmbMOC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbMOC.Size = New System.Drawing.Size(116, 21)
        Me.cmbMOC.TabIndex = 59
        Me.cmbMOC.Text = "--Select--"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(44, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Material "
        '
        'txtDesignPressureInlet
        '
        Me.txtDesignPressureInlet.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignPressureInlet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtDesignPressureInlet.Location = New System.Drawing.Point(124, 58)
        Me.txtDesignPressureInlet.Name = "txtDesignPressureInlet"
        Me.txtDesignPressureInlet.Size = New System.Drawing.Size(60, 22)
        Me.txtDesignPressureInlet.TabIndex = 60
        Me.txtDesignPressureInlet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesignTemperatureInlet
        '
        Me.txtDesignTemperatureInlet.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignTemperatureInlet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtDesignTemperatureInlet.Location = New System.Drawing.Point(124, 81)
        Me.txtDesignTemperatureInlet.Name = "txtDesignTemperatureInlet"
        Me.txtDesignTemperatureInlet.Size = New System.Drawing.Size(60, 22)
        Me.txtDesignTemperatureInlet.TabIndex = 61
        Me.txtDesignTemperatureInlet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(242, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 120
        Me.Label19.Text = "Suggested"
        '
        'cmbSuggestedRating
        '
        Me.cmbSuggestedRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSuggestedRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbSuggestedRating.FormattingEnabled = True
        Me.cmbSuggestedRating.Location = New System.Drawing.Point(315, 59)
        Me.cmbSuggestedRating.Name = "cmbSuggestedRating"
        Me.cmbSuggestedRating.Size = New System.Drawing.Size(75, 21)
        Me.cmbSuggestedRating.TabIndex = 62
        Me.cmbSuggestedRating.Text = "--Select--"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(240, 63)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(53, 13)
        Me.Label37.TabIndex = 189
        Me.Label37.Text = "Available"
        '
        'lblSuggestedRating
        '
        Me.lblSuggestedRating.AutoSize = True
        Me.lblSuggestedRating.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuggestedRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSuggestedRating.Location = New System.Drawing.Point(314, 36)
        Me.lblSuggestedRating.Name = "lblSuggestedRating"
        Me.lblSuggestedRating.Size = New System.Drawing.Size(0, 13)
        Me.lblSuggestedRating.TabIndex = 197
        '
        'lblFinalRating
        '
        Me.lblFinalRating.AutoSize = True
        Me.lblFinalRating.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblFinalRating.Location = New System.Drawing.Point(342, 86)
        Me.lblFinalRating.Name = "lblFinalRating"
        Me.lblFinalRating.Size = New System.Drawing.Size(0, 13)
        Me.lblFinalRating.TabIndex = 195
        '
        'lblDesignPressure
        '
        Me.lblDesignPressure.AutoSize = True
        Me.lblDesignPressure.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignPressure.Location = New System.Drawing.Point(189, 63)
        Me.lblDesignPressure.Name = "lblDesignPressure"
        Me.lblDesignPressure.Size = New System.Drawing.Size(0, 13)
        Me.lblDesignPressure.TabIndex = 193
        '
        'lblDesignTemperature
        '
        Me.lblDesignTemperature.AutoSize = True
        Me.lblDesignTemperature.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignTemperature.Location = New System.Drawing.Point(190, 86)
        Me.lblDesignTemperature.Name = "lblDesignTemperature"
        Me.lblDesignTemperature.Size = New System.Drawing.Size(0, 13)
        Me.lblDesignTemperature.TabIndex = 192
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(44, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "Design Press"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label16.Location = New System.Drawing.Point(44, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Temp."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbEndConnection
        '
        Me.cmbEndConnection.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEndConnection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbEndConnection.FormattingEnabled = True
        Me.cmbEndConnection.Location = New System.Drawing.Point(325, 388)
        Me.cmbEndConnection.Name = "cmbEndConnection"
        Me.cmbEndConnection.Size = New System.Drawing.Size(90, 21)
        Me.cmbEndConnection.TabIndex = 76
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label77.Location = New System.Drawing.Point(239, 392)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(61, 13)
        Me.Label77.TabIndex = 272
        Me.Label77.Text = "End Conn."
        '
        'cmbBonnetType
        '
        Me.cmbBonnetType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBonnetType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbBonnetType.FormattingEnabled = True
        Me.cmbBonnetType.Location = New System.Drawing.Point(118, 389)
        Me.cmbBonnetType.Name = "cmbBonnetType"
        Me.cmbBonnetType.Size = New System.Drawing.Size(80, 21)
        Me.cmbBonnetType.TabIndex = 75
        Me.cmbBonnetType.Text = "--Select--"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label78.Location = New System.Drawing.Point(44, 393)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(70, 13)
        Me.Label78.TabIndex = 270
        Me.Label78.Text = "Bonnet Type"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label63.Location = New System.Drawing.Point(25, 293)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(91, 13)
        Me.Label63.TabIndex = 266
        Me.Label63.Text = "Trim Style: Sugg."
        '
        'lblCalculating
        '
        Me.lblCalculating.AutoSize = True
        Me.lblCalculating.ForeColor = System.Drawing.Color.Red
        Me.lblCalculating.Location = New System.Drawing.Point(341, 223)
        Me.lblCalculating.Name = "lblCalculating"
        Me.lblCalculating.Size = New System.Drawing.Size(80, 13)
        Me.lblCalculating.TabIndex = 229
        Me.lblCalculating.Text = "Calculating ...."
        Me.lblCalculating.Visible = False
        '
        'lblCvSelected
        '
        Me.lblCvSelected.AutoSize = True
        Me.lblCvSelected.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCvSelected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCvSelected.Location = New System.Drawing.Point(44, 345)
        Me.lblCvSelected.Name = "lblCvSelected"
        Me.lblCvSelected.Size = New System.Drawing.Size(68, 13)
        Me.lblCvSelected.TabIndex = 264
        Me.lblCvSelected.Text = "Available Cv"
        '
        'lblCVSugg
        '
        Me.lblCVSugg.AutoSize = True
        Me.lblCVSugg.BackColor = System.Drawing.Color.Transparent
        Me.lblCVSugg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCVSugg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCVSugg.Location = New System.Drawing.Point(31, 321)
        Me.lblCVSugg.Name = "lblCVSugg"
        Me.lblCVSugg.Size = New System.Drawing.Size(52, 13)
        Me.lblCVSugg.TabIndex = 263
        Me.lblCVSugg.Text = "Sugg. Cv"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(228, 345)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 243
        Me.Label14.Text = "Available Valve"
        '
        'lblKvSelected
        '
        Me.lblKvSelected.AutoSize = True
        Me.lblKvSelected.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKvSelected.Location = New System.Drawing.Point(44, 345)
        Me.lblKvSelected.Name = "lblKvSelected"
        Me.lblKvSelected.Size = New System.Drawing.Size(67, 13)
        Me.lblKvSelected.TabIndex = 242
        Me.lblKvSelected.Text = "Available Kv"
        '
        'lblKvSugg
        '
        Me.lblKvSugg.AutoSize = True
        Me.lblKvSugg.BackColor = System.Drawing.Color.Transparent
        Me.lblKvSugg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKvSugg.Location = New System.Drawing.Point(44, 320)
        Me.lblKvSugg.Name = "lblKvSugg"
        Me.lblKvSugg.Size = New System.Drawing.Size(51, 13)
        Me.lblKvSugg.TabIndex = 238
        Me.lblKvSugg.Text = "Sugg. Kv"
        '
        'txtSuggestedKV
        '
        Me.txtSuggestedKV.BackColor = System.Drawing.Color.White
        Me.txtSuggestedKV.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuggestedKV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSuggestedKV.Location = New System.Drawing.Point(118, 315)
        Me.txtSuggestedKV.Name = "txtSuggestedKV"
        Me.txtSuggestedKV.ReadOnly = True
        Me.txtSuggestedKV.Size = New System.Drawing.Size(50, 22)
        Me.txtSuggestedKV.TabIndex = 72
        Me.txtSuggestedKV.TabStop = False
        '
        'cmbKVOverride
        '
        Me.cmbKVOverride.AllowDrop = True
        Me.cmbKVOverride.Enabled = False
        Me.cmbKVOverride.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKVOverride.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbKVOverride.FormattingEnabled = True
        Me.cmbKVOverride.Location = New System.Drawing.Point(118, 341)
        Me.cmbKVOverride.Name = "cmbKVOverride"
        Me.cmbKVOverride.Size = New System.Drawing.Size(80, 21)
        Me.cmbKVOverride.TabIndex = 73
        Me.cmbKVOverride.Text = "--Select--"
        '
        'cmbValveSizeOverride
        '
        Me.cmbValveSizeOverride.Enabled = False
        Me.cmbValveSizeOverride.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbValveSizeOverride.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbValveSizeOverride.FormattingEnabled = True
        Me.cmbValveSizeOverride.Location = New System.Drawing.Point(322, 341)
        Me.cmbValveSizeOverride.Name = "cmbValveSizeOverride"
        Me.cmbValveSizeOverride.Size = New System.Drawing.Size(71, 21)
        Me.cmbValveSizeOverride.TabIndex = 74
        Me.cmbValveSizeOverride.Text = "--Select--"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(239, 319)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(63, 13)
        Me.Label27.TabIndex = 240
        Me.Label27.Text = "Sugg,Valve"
        '
        'txtSuggestedValveSize
        '
        Me.txtSuggestedValveSize.BackColor = System.Drawing.Color.White
        Me.txtSuggestedValveSize.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuggestedValveSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSuggestedValveSize.Location = New System.Drawing.Point(322, 316)
        Me.txtSuggestedValveSize.Name = "txtSuggestedValveSize"
        Me.txtSuggestedValveSize.ReadOnly = True
        Me.txtSuggestedValveSize.Size = New System.Drawing.Size(41, 22)
        Me.txtSuggestedValveSize.TabIndex = 73
        Me.txtSuggestedValveSize.TabStop = False
        '
        'lblSelectedCV
        '
        Me.lblSelectedCV.AutoSize = True
        Me.lblSelectedCV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedCV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSelectedCV.Location = New System.Drawing.Point(13, 369)
        Me.lblSelectedCV.Name = "lblSelectedCV"
        Me.lblSelectedCV.Size = New System.Drawing.Size(68, 15)
        Me.lblSelectedCV.TabIndex = 277
        Me.lblSelectedCV.Text = "Selected Cv"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(228, 368)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(81, 15)
        Me.Label42.TabIndex = 275
        Me.Label42.Text = "Selected Valve"
        '
        'lblKVMaxValue
        '
        Me.lblKVMaxValue.AutoSize = True
        Me.lblKVMaxValue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKVMaxValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblKVMaxValue.Location = New System.Drawing.Point(124, 369)
        Me.lblKVMaxValue.Name = "lblKVMaxValue"
        Me.lblKVMaxValue.Size = New System.Drawing.Size(0, 13)
        Me.lblKVMaxValue.TabIndex = 274
        '
        'lblSelectedKV
        '
        Me.lblSelectedKV.AutoSize = True
        Me.lblSelectedKV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedKV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSelectedKV.Location = New System.Drawing.Point(44, 369)
        Me.lblSelectedKV.Name = "lblSelectedKV"
        Me.lblSelectedKV.Size = New System.Drawing.Size(70, 15)
        Me.lblSelectedKV.TabIndex = 273
        Me.lblSelectedKV.Text = "Selected  Kv"
        '
        'btnValveSizeAccept
        '
        Me.btnValveSizeAccept.Enabled = False
        Me.btnValveSizeAccept.FlatAppearance.BorderSize = 0
        Me.btnValveSizeAccept.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValveSizeAccept.Location = New System.Drawing.Point(369, 314)
        Me.btnValveSizeAccept.Name = "btnValveSizeAccept"
        Me.btnValveSizeAccept.Size = New System.Drawing.Size(40, 25)
        Me.btnValveSizeAccept.TabIndex = 93
        Me.btnValveSizeAccept.TabStop = False
        Me.btnValveSizeAccept.Text = "Accept"
        Me.btnValveSizeAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnValveSizeAccept.UseVisualStyleBackColor = False
        Me.btnValveSizeAccept.Visible = False
        '
        'btnKVAccept
        '
        Me.btnKVAccept.FlatAppearance.BorderSize = 0
        Me.btnKVAccept.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKVAccept.Location = New System.Drawing.Point(190, 313)
        Me.btnKVAccept.Name = "btnKVAccept"
        Me.btnKVAccept.Size = New System.Drawing.Size(40, 25)
        Me.btnKVAccept.TabIndex = 91
        Me.btnKVAccept.TabStop = False
        Me.btnKVAccept.Text = "Accept"
        Me.btnKVAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKVAccept.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(44, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 232
        Me.Label13.Text = "Inlet Sch."
        '
        'cmbInletPipeSchedule
        '
        Me.cmbInletPipeSchedule.Enabled = False
        Me.cmbInletPipeSchedule.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInletPipeSchedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbInletPipeSchedule.FormattingEnabled = True
        Me.cmbInletPipeSchedule.Location = New System.Drawing.Point(124, 176)
        Me.cmbInletPipeSchedule.Name = "cmbInletPipeSchedule"
        Me.cmbInletPipeSchedule.Size = New System.Drawing.Size(71, 21)
        Me.cmbInletPipeSchedule.TabIndex = 65
        Me.cmbInletPipeSchedule.Text = "--Select--"
        '
        'lblFinalOutletPipe
        '
        Me.lblFinalOutletPipe.AutoSize = True
        Me.lblFinalOutletPipe.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalOutletPipe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblFinalOutletPipe.Location = New System.Drawing.Point(332, 204)
        Me.lblFinalOutletPipe.Name = "lblFinalOutletPipe"
        Me.lblFinalOutletPipe.Size = New System.Drawing.Size(0, 13)
        Me.lblFinalOutletPipe.TabIndex = 230
        '
        'lblSuggPipeSize
        '
        Me.lblSuggPipeSize.AutoSize = True
        Me.lblSuggPipeSize.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuggPipeSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSuggPipeSize.Location = New System.Drawing.Point(317, 131)
        Me.lblSuggPipeSize.Name = "lblSuggPipeSize"
        Me.lblSuggPipeSize.Size = New System.Drawing.Size(0, 13)
        Me.lblSuggPipeSize.TabIndex = 7
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(44, 156)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 13)
        Me.Label25.TabIndex = 136
        Me.Label25.Text = "Inlet pipe"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(44, 132)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 126
        Me.Label21.Text = "Size units"
        '
        'cmbAreaunits
        '
        Me.cmbAreaunits.Enabled = False
        Me.cmbAreaunits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaunits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbAreaunits.FormattingEnabled = True
        Me.cmbAreaunits.Location = New System.Drawing.Point(124, 128)
        Me.cmbAreaunits.Name = "cmbAreaunits"
        Me.cmbAreaunits.Size = New System.Drawing.Size(68, 21)
        Me.cmbAreaunits.TabIndex = 63
        Me.cmbAreaunits.Text = "--Select--"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(240, 131)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(73, 13)
        Me.Label22.TabIndex = 128
        Me.Label22.Text = "Sugg. Outlet"
        '
        'txt_CustomerMain
        '
        Me.txt_CustomerMain.AutoSize = True
        Me.txt_CustomerMain.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CustomerMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_CustomerMain.Location = New System.Drawing.Point(240, 180)
        Me.txt_CustomerMain.Name = "txt_CustomerMain"
        Me.txt_CustomerMain.Size = New System.Drawing.Size(64, 13)
        Me.txt_CustomerMain.TabIndex = 225
        Me.txt_CustomerMain.Text = "Outlet Sch."
        '
        'cmbPipeDia
        '
        Me.cmbPipeDia.Enabled = False
        Me.cmbPipeDia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPipeDia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbPipeDia.FormattingEnabled = True
        Me.cmbPipeDia.Location = New System.Drawing.Point(314, 152)
        Me.cmbPipeDia.Name = "cmbPipeDia"
        Me.cmbPipeDia.Size = New System.Drawing.Size(75, 21)
        Me.cmbPipeDia.TabIndex = 666
        Me.cmbPipeDia.Text = "--Select--"
        '
        'cmbSchedule
        '
        Me.cmbSchedule.Enabled = False
        Me.cmbSchedule.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSchedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbSchedule.FormattingEnabled = True
        Me.cmbSchedule.Location = New System.Drawing.Point(314, 176)
        Me.cmbSchedule.Name = "cmbSchedule"
        Me.cmbSchedule.Size = New System.Drawing.Size(75, 21)
        Me.cmbSchedule.TabIndex = 67
        Me.cmbSchedule.Text = "--Select--"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(240, 156)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(65, 13)
        Me.Label38.TabIndex = 190
        Me.Label38.Text = "Outlet Pipe"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbInletPipeSize
        '
        Me.cmbInletPipeSize.Enabled = False
        Me.cmbInletPipeSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInletPipeSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbInletPipeSize.FormattingEnabled = True
        Me.cmbInletPipeSize.Location = New System.Drawing.Point(124, 152)
        Me.cmbInletPipeSize.Name = "cmbInletPipeSize"
        Me.cmbInletPipeSize.Size = New System.Drawing.Size(70, 21)
        Me.cmbInletPipeSize.TabIndex = 64
        Me.cmbInletPipeSize.Text = "--Select--"
        '
        'btnAcceptVelocityRule
        '
        Me.btnAcceptVelocityRule.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAcceptVelocityRule.Enabled = False
        Me.btnAcceptVelocityRule.FlatAppearance.BorderSize = 0
        Me.btnAcceptVelocityRule.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceptVelocityRule.Location = New System.Drawing.Point(362, 121)
        Me.btnAcceptVelocityRule.Name = "btnAcceptVelocityRule"
        Me.btnAcceptVelocityRule.Size = New System.Drawing.Size(40, 25)
        Me.btnAcceptVelocityRule.TabIndex = 83
        Me.btnAcceptVelocityRule.Text = "Accept"
        Me.btnAcceptVelocityRule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcceptVelocityRule.UseVisualStyleBackColor = False
        Me.btnAcceptVelocityRule.Visible = False
        '
        'lblFinalActuator
        '
        Me.lblFinalActuator.AutoSize = True
        Me.lblFinalActuator.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalActuator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.lblFinalActuator.Location = New System.Drawing.Point(135, 275)
        Me.lblFinalActuator.Name = "lblFinalActuator"
        Me.lblFinalActuator.Size = New System.Drawing.Size(0, 13)
        Me.lblFinalActuator.TabIndex = 315
        '
        'lblSeatDiaUnits
        '
        Me.lblSeatDiaUnits.AutoSize = True
        Me.lblSeatDiaUnits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatDiaUnits.Location = New System.Drawing.Point(182, 199)
        Me.lblSeatDiaUnits.Name = "lblSeatDiaUnits"
        Me.lblSeatDiaUnits.Size = New System.Drawing.Size(25, 13)
        Me.lblSeatDiaUnits.TabIndex = 243
        Me.lblSeatDiaUnits.Text = "mm"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(36, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 240
        Me.Label12.Text = "Seat Dia"
        '
        'cmbAirPressureUnits
        '
        Me.cmbAirPressureUnits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAirPressureUnits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbAirPressureUnits.FormattingEnabled = True
        Me.cmbAirPressureUnits.Location = New System.Drawing.Point(199, 146)
        Me.cmbAirPressureUnits.Name = "cmbAirPressureUnits"
        Me.cmbAirPressureUnits.Size = New System.Drawing.Size(88, 21)
        Me.cmbAirPressureUnits.TabIndex = 8
        Me.cmbAirPressureUnits.Text = "--Select--"
        '
        'lblDPShutoffUnits
        '
        Me.lblDPShutoffUnits.AutoSize = True
        Me.lblDPShutoffUnits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPShutoffUnits.Location = New System.Drawing.Point(225, 126)
        Me.lblDPShutoffUnits.Name = "lblDPShutoffUnits"
        Me.lblDPShutoffUnits.Size = New System.Drawing.Size(0, 13)
        Me.lblDPShutoffUnits.TabIndex = 238
        '
        'txtSuggActuator
        '
        Me.txtSuggActuator.BackColor = System.Drawing.Color.White
        Me.txtSuggActuator.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuggActuator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSuggActuator.Location = New System.Drawing.Point(132, 218)
        Me.txtSuggActuator.Name = "txtSuggActuator"
        Me.txtSuggActuator.Size = New System.Drawing.Size(194, 22)
        Me.txtSuggActuator.TabIndex = 11
        Me.txtSuggActuator.TabStop = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(35, 223)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(70, 13)
        Me.Label50.TabIndex = 234
        Me.Label50.Text = "Sugg.Model"
        '
        'cmbSelectActuator
        '
        Me.cmbSelectActuator.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectActuator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbSelectActuator.FormattingEnabled = True
        Me.cmbSelectActuator.Location = New System.Drawing.Point(132, 244)
        Me.cmbSelectActuator.Name = "cmbSelectActuator"
        Me.cmbSelectActuator.Size = New System.Drawing.Size(192, 21)
        Me.cmbSelectActuator.TabIndex = 12
        Me.cmbSelectActuator.Text = "--Select--"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label52.Location = New System.Drawing.Point(35, 247)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(89, 13)
        Me.Label52.TabIndex = 233
        Me.Label52.Text = "Available Model"
        '
        'txtAirPressure
        '
        Me.txtAirPressure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtAirPressure.Location = New System.Drawing.Point(131, 146)
        Me.txtAirPressure.Name = "txtAirPressure"
        Me.txtAirPressure.Size = New System.Drawing.Size(62, 22)
        Me.txtAirPressure.TabIndex = 7
        '
        'cmbActuatorType
        '
        Me.cmbActuatorType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbActuatorType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbActuatorType.FormattingEnabled = True
        Me.cmbActuatorType.Location = New System.Drawing.Point(131, 31)
        Me.cmbActuatorType.Name = "cmbActuatorType"
        Me.cmbActuatorType.Size = New System.Drawing.Size(93, 21)
        Me.cmbActuatorType.TabIndex = 0
        Me.cmbActuatorType.Text = "Single Spring "
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label71.Location = New System.Drawing.Point(35, 31)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(30, 13)
        Me.Label71.TabIndex = 228
        Me.Label71.Text = "Type"
        '
        'cmbSealing
        '
        Me.cmbSealing.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSealing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbSealing.FormattingEnabled = True
        Me.cmbSealing.Location = New System.Drawing.Point(131, 99)
        Me.cmbSealing.Name = "cmbSealing"
        Me.cmbSealing.Size = New System.Drawing.Size(156, 21)
        Me.cmbSealing.TabIndex = 5
        Me.cmbSealing.Text = "--Select--"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(35, 103)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(45, 13)
        Me.Label47.TabIndex = 227
        Me.Label47.Text = "Sealing"
        '
        'txtDPShutoff
        '
        Me.txtDPShutoff.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPShutoff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtDPShutoff.Location = New System.Drawing.Point(131, 122)
        Me.txtDPShutoff.Name = "txtDPShutoff"
        Me.txtDPShutoff.Size = New System.Drawing.Size(62, 22)
        Me.txtDPShutoff.TabIndex = 6
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label54.Location = New System.Drawing.Point(35, 151)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(67, 13)
        Me.Label54.TabIndex = 226
        Me.Label54.Text = "Air Pressure"
        '
        'cmbHandwheel
        '
        Me.cmbHandwheel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHandwheel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbHandwheel.FormattingEnabled = True
        Me.cmbHandwheel.Location = New System.Drawing.Point(131, 175)
        Me.cmbHandwheel.Name = "cmbHandwheel"
        Me.cmbHandwheel.Size = New System.Drawing.Size(156, 21)
        Me.cmbHandwheel.TabIndex = 9
        Me.cmbHandwheel.Text = "--Select--"
        '
        'cmbPacking
        '
        Me.cmbPacking.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPacking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbPacking.FormattingEnabled = True
        Me.cmbPacking.Location = New System.Drawing.Point(131, 75)
        Me.cmbPacking.Name = "cmbPacking"
        Me.cmbPacking.Size = New System.Drawing.Size(157, 21)
        Me.cmbPacking.TabIndex = 4
        Me.cmbPacking.Text = "--Select--"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label51.Location = New System.Drawing.Point(37, 175)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(68, 13)
        Me.Label51.TabIndex = 19
        Me.Label51.Text = "HandWheel"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(35, 79)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(47, 13)
        Me.Label43.TabIndex = 225
        Me.Label43.Text = "Packing"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(35, 127)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(63, 13)
        Me.Label44.TabIndex = 224
        Me.Label44.Text = "DP Shutoff"
        '
        'cmbBalancing
        '
        Me.cmbBalancing.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBalancing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbBalancing.FormattingEnabled = True
        Me.cmbBalancing.Location = New System.Drawing.Point(302, 31)
        Me.cmbBalancing.Name = "cmbBalancing"
        Me.cmbBalancing.Size = New System.Drawing.Size(80, 21)
        Me.cmbBalancing.TabIndex = 1
        Me.cmbBalancing.Text = "--Select--"
        '
        'cmbLeakage
        '
        Me.cmbLeakage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLeakage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbLeakage.FormattingEnabled = True
        Me.cmbLeakage.Location = New System.Drawing.Point(302, 50)
        Me.cmbLeakage.Name = "cmbLeakage"
        Me.cmbLeakage.Size = New System.Drawing.Size(80, 21)
        Me.cmbLeakage.TabIndex = 3
        Me.cmbLeakage.Text = "--Select--"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(229, 31)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(57, 13)
        Me.Label45.TabIndex = 223
        Me.Label45.Text = "Balancing"
        '
        'cmbAirFailure
        '
        Me.cmbAirFailure.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAirFailure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbAirFailure.FormattingEnabled = True
        Me.cmbAirFailure.Location = New System.Drawing.Point(131, 51)
        Me.cmbAirFailure.Name = "cmbAirFailure"
        Me.cmbAirFailure.Size = New System.Drawing.Size(80, 21)
        Me.cmbAirFailure.TabIndex = 2
        Me.cmbAirFailure.Text = "--Select--"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(229, 54)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(49, 13)
        Me.Label46.TabIndex = 220
        Me.Label46.Text = "Leakage"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(35, 55)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(87, 13)
        Me.Label48.TabIndex = 217
        Me.Label48.Text = "Actuator Action"
        '
        'lblKVCase1
        '
        Me.lblKVCase1.AutoSize = True
        Me.lblKVCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblKVCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKVCase1.ForeColor = System.Drawing.Color.Black
        Me.lblKVCase1.Location = New System.Drawing.Point(211, 33)
        Me.lblKVCase1.Name = "lblKVCase1"
        Me.lblKVCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblKVCase1.TabIndex = 73
        '
        'lblKVCase2
        '
        Me.lblKVCase2.AutoSize = True
        Me.lblKVCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblKVCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKVCase2.ForeColor = System.Drawing.Color.Black
        Me.lblKVCase2.Location = New System.Drawing.Point(282, 32)
        Me.lblKVCase2.Name = "lblKVCase2"
        Me.lblKVCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblKVCase2.TabIndex = 74
        '
        'lblKVCase3
        '
        Me.lblKVCase3.AutoSize = True
        Me.lblKVCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblKVCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKVCase3.ForeColor = System.Drawing.Color.Black
        Me.lblKVCase3.Location = New System.Drawing.Point(354, 32)
        Me.lblKVCase3.Name = "lblKVCase3"
        Me.lblKVCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblKVCase3.TabIndex = 75
        '
        'lblApproxCVCase1
        '
        Me.lblApproxCVCase1.AutoSize = True
        Me.lblApproxCVCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblApproxCVCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApproxCVCase1.ForeColor = System.Drawing.Color.Black
        Me.lblApproxCVCase1.Location = New System.Drawing.Point(211, 32)
        Me.lblApproxCVCase1.Name = "lblApproxCVCase1"
        Me.lblApproxCVCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblApproxCVCase1.TabIndex = 77
        '
        'lblApproxCVCase2
        '
        Me.lblApproxCVCase2.AutoSize = True
        Me.lblApproxCVCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblApproxCVCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApproxCVCase2.ForeColor = System.Drawing.Color.Black
        Me.lblApproxCVCase2.Location = New System.Drawing.Point(282, 32)
        Me.lblApproxCVCase2.Name = "lblApproxCVCase2"
        Me.lblApproxCVCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblApproxCVCase2.TabIndex = 78
        '
        'lblApproxCVCase3
        '
        Me.lblApproxCVCase3.AutoSize = True
        Me.lblApproxCVCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblApproxCVCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApproxCVCase3.ForeColor = System.Drawing.Color.Black
        Me.lblApproxCVCase3.Location = New System.Drawing.Point(354, 32)
        Me.lblApproxCVCase3.Name = "lblApproxCVCase3"
        Me.lblApproxCVCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblApproxCVCase3.TabIndex = 79
        '
        'lblCalculatedKV
        '
        Me.lblCalculatedKV.AutoSize = True
        Me.lblCalculatedKV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculatedKV.ForeColor = System.Drawing.Color.Black
        Me.lblCalculatedKV.Location = New System.Drawing.Point(37, 31)
        Me.lblCalculatedKV.Name = "lblCalculatedKV"
        Me.lblCalculatedKV.Size = New System.Drawing.Size(78, 15)
        Me.lblCalculatedKV.TabIndex = 80
        Me.lblCalculatedKV.Text = "Initial Calc Kv"
        '
        'lblCalculatedCV
        '
        Me.lblCalculatedCV.AutoSize = True
        Me.lblCalculatedCV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculatedCV.ForeColor = System.Drawing.Color.Black
        Me.lblCalculatedCV.Location = New System.Drawing.Point(36, 32)
        Me.lblCalculatedCV.Name = "lblCalculatedCV"
        Me.lblCalculatedCV.Size = New System.Drawing.Size(79, 15)
        Me.lblCalculatedCV.TabIndex = 81
        Me.lblCalculatedCV.Text = "Initial Calc Cv"
        '
        'lblFinalKVCase1
        '
        Me.lblFinalKVCase1.AutoSize = True
        Me.lblFinalKVCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblFinalKVCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalKVCase1.ForeColor = System.Drawing.Color.Black
        Me.lblFinalKVCase1.Location = New System.Drawing.Point(211, 52)
        Me.lblFinalKVCase1.Name = "lblFinalKVCase1"
        Me.lblFinalKVCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblFinalKVCase1.TabIndex = 163
        '
        'lblFinalKvCase2
        '
        Me.lblFinalKvCase2.AutoSize = True
        Me.lblFinalKvCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblFinalKvCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalKvCase2.ForeColor = System.Drawing.Color.Black
        Me.lblFinalKvCase2.Location = New System.Drawing.Point(282, 52)
        Me.lblFinalKvCase2.Name = "lblFinalKvCase2"
        Me.lblFinalKvCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblFinalKvCase2.TabIndex = 164
        '
        'lblFinalKVcase3
        '
        Me.lblFinalKVcase3.AutoSize = True
        Me.lblFinalKVcase3.BackColor = System.Drawing.Color.Transparent
        Me.lblFinalKVcase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalKVcase3.ForeColor = System.Drawing.Color.Black
        Me.lblFinalKVcase3.Location = New System.Drawing.Point(354, 52)
        Me.lblFinalKVcase3.Name = "lblFinalKVcase3"
        Me.lblFinalKVcase3.Size = New System.Drawing.Size(0, 15)
        Me.lblFinalKVcase3.TabIndex = 165
        '
        'lblFinalCVCase1
        '
        Me.lblFinalCVCase1.AutoSize = True
        Me.lblFinalCVCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblFinalCVCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCVCase1.ForeColor = System.Drawing.Color.Black
        Me.lblFinalCVCase1.Location = New System.Drawing.Point(211, 54)
        Me.lblFinalCVCase1.Name = "lblFinalCVCase1"
        Me.lblFinalCVCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblFinalCVCase1.TabIndex = 166
        '
        'lblFinalCVCase2
        '
        Me.lblFinalCVCase2.AutoSize = True
        Me.lblFinalCVCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblFinalCVCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCVCase2.ForeColor = System.Drawing.Color.Black
        Me.lblFinalCVCase2.Location = New System.Drawing.Point(282, 52)
        Me.lblFinalCVCase2.Name = "lblFinalCVCase2"
        Me.lblFinalCVCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblFinalCVCase2.TabIndex = 167
        '
        'lblFinalCVCase3
        '
        Me.lblFinalCVCase3.AutoSize = True
        Me.lblFinalCVCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblFinalCVCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCVCase3.ForeColor = System.Drawing.Color.Black
        Me.lblFinalCVCase3.Location = New System.Drawing.Point(354, 52)
        Me.lblFinalCVCase3.Name = "lblFinalCVCase3"
        Me.lblFinalCVCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblFinalCVCase3.TabIndex = 168
        '
        'lblCorrectedKV
        '
        Me.lblCorrectedKV.AutoSize = True
        Me.lblCorrectedKV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectedKV.ForeColor = System.Drawing.Color.Black
        Me.lblCorrectedKV.Location = New System.Drawing.Point(37, 52)
        Me.lblCorrectedKV.Name = "lblCorrectedKV"
        Me.lblCorrectedKV.Size = New System.Drawing.Size(74, 15)
        Me.lblCorrectedKV.TabIndex = 169
        Me.lblCorrectedKV.Text = "Final Calc Kv"
        '
        'lblCorrectedCV
        '
        Me.lblCorrectedCV.AutoSize = True
        Me.lblCorrectedCV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectedCV.ForeColor = System.Drawing.Color.Black
        Me.lblCorrectedCV.Location = New System.Drawing.Point(36, 52)
        Me.lblCorrectedCV.Name = "lblCorrectedCV"
        Me.lblCorrectedCV.Size = New System.Drawing.Size(75, 15)
        Me.lblCorrectedCV.TabIndex = 170
        Me.lblCorrectedCV.Text = "Final Calc Cv"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(36, 72)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 15)
        Me.Label30.TabIndex = 257
        Me.Label30.Text = "%Stroke"
        '
        'lblStrokeCase1
        '
        Me.lblStrokeCase1.AutoSize = True
        Me.lblStrokeCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblStrokeCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrokeCase1.ForeColor = System.Drawing.Color.Black
        Me.lblStrokeCase1.Location = New System.Drawing.Point(211, 72)
        Me.lblStrokeCase1.Name = "lblStrokeCase1"
        Me.lblStrokeCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblStrokeCase1.TabIndex = 258
        '
        'lblStrokeCase2
        '
        Me.lblStrokeCase2.AutoSize = True
        Me.lblStrokeCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblStrokeCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrokeCase2.ForeColor = System.Drawing.Color.Black
        Me.lblStrokeCase2.Location = New System.Drawing.Point(282, 72)
        Me.lblStrokeCase2.Name = "lblStrokeCase2"
        Me.lblStrokeCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblStrokeCase2.TabIndex = 259
        '
        'lblStrokeCase3
        '
        Me.lblStrokeCase3.AutoSize = True
        Me.lblStrokeCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblStrokeCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrokeCase3.ForeColor = System.Drawing.Color.Black
        Me.lblStrokeCase3.Location = New System.Drawing.Point(354, 72)
        Me.lblStrokeCase3.Name = "lblStrokeCase3"
        Me.lblStrokeCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblStrokeCase3.TabIndex = 260
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(36, 92)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(59, 15)
        Me.Label40.TabIndex = 261
        Me.Label40.Text = "Flow Type"
        '
        'lblFlowtypeCase1
        '
        Me.lblFlowtypeCase1.AutoSize = True
        Me.lblFlowtypeCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblFlowtypeCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowtypeCase1.ForeColor = System.Drawing.Color.Black
        Me.lblFlowtypeCase1.Location = New System.Drawing.Point(201, 92)
        Me.lblFlowtypeCase1.Name = "lblFlowtypeCase1"
        Me.lblFlowtypeCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblFlowtypeCase1.TabIndex = 262
        '
        'lblFlowtypeCase2
        '
        Me.lblFlowtypeCase2.AutoSize = True
        Me.lblFlowtypeCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblFlowtypeCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowtypeCase2.ForeColor = System.Drawing.Color.Black
        Me.lblFlowtypeCase2.Location = New System.Drawing.Point(272, 92)
        Me.lblFlowtypeCase2.Name = "lblFlowtypeCase2"
        Me.lblFlowtypeCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblFlowtypeCase2.TabIndex = 263
        '
        'lblFlowtypeCase3
        '
        Me.lblFlowtypeCase3.AutoSize = True
        Me.lblFlowtypeCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblFlowtypeCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowtypeCase3.ForeColor = System.Drawing.Color.Black
        Me.lblFlowtypeCase3.Location = New System.Drawing.Point(344, 92)
        Me.lblFlowtypeCase3.Name = "lblFlowtypeCase3"
        Me.lblFlowtypeCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblFlowtypeCase3.TabIndex = 264
        '
        'lblFlowSeverity
        '
        Me.lblFlowSeverity.AutoSize = True
        Me.lblFlowSeverity.BackColor = System.Drawing.Color.Transparent
        Me.lblFlowSeverity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowSeverity.ForeColor = System.Drawing.Color.Black
        Me.lblFlowSeverity.Location = New System.Drawing.Point(36, 112)
        Me.lblFlowSeverity.Name = "lblFlowSeverity"
        Me.lblFlowSeverity.Size = New System.Drawing.Size(76, 15)
        Me.lblFlowSeverity.TabIndex = 265
        Me.lblFlowSeverity.Text = "Flow Severity"
        '
        'lblSeverityCase1
        '
        Me.lblSeverityCase1.AutoSize = True
        Me.lblSeverityCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblSeverityCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeverityCase1.ForeColor = System.Drawing.Color.Black
        Me.lblSeverityCase1.Location = New System.Drawing.Point(201, 112)
        Me.lblSeverityCase1.Name = "lblSeverityCase1"
        Me.lblSeverityCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblSeverityCase1.TabIndex = 266
        '
        'lblSeverityCase2
        '
        Me.lblSeverityCase2.AutoSize = True
        Me.lblSeverityCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblSeverityCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeverityCase2.ForeColor = System.Drawing.Color.Black
        Me.lblSeverityCase2.Location = New System.Drawing.Point(272, 112)
        Me.lblSeverityCase2.Name = "lblSeverityCase2"
        Me.lblSeverityCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblSeverityCase2.TabIndex = 267
        '
        'lblSeverityCase3
        '
        Me.lblSeverityCase3.AutoSize = True
        Me.lblSeverityCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblSeverityCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeverityCase3.ForeColor = System.Drawing.Color.Black
        Me.lblSeverityCase3.Location = New System.Drawing.Point(344, 112)
        Me.lblSeverityCase3.Name = "lblSeverityCase3"
        Me.lblSeverityCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblSeverityCase3.TabIndex = 268
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.Label58)
        Me.GroupBox1.Controls.Add(Me.Label59)
        Me.GroupBox1.Controls.Add(Me.Label56)
        Me.GroupBox1.Controls.Add(Me.lblSeverityCase3)
        Me.GroupBox1.Controls.Add(Me.lblSeverityCase2)
        Me.GroupBox1.Controls.Add(Me.lblSeverityCase1)
        Me.GroupBox1.Controls.Add(Me.lblFlowSeverity)
        Me.GroupBox1.Controls.Add(Me.lblFlowtypeCase3)
        Me.GroupBox1.Controls.Add(Me.lblFlowtypeCase2)
        Me.GroupBox1.Controls.Add(Me.lblFlowtypeCase1)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.lblFLCase3)
        Me.GroupBox1.Controls.Add(Me.lblStrokeCase3)
        Me.GroupBox1.Controls.Add(Me.lblFLCase2)
        Me.GroupBox1.Controls.Add(Me.lblStrokeCase2)
        Me.GroupBox1.Controls.Add(Me.lblFLCase1)
        Me.GroupBox1.Controls.Add(Me.lblStrokeCase1)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.lblCorrectedCV)
        Me.GroupBox1.Controls.Add(Me.lblCorrectedKV)
        Me.GroupBox1.Controls.Add(Me.lblFinalCVCase3)
        Me.GroupBox1.Controls.Add(Me.lblFinalCVCase2)
        Me.GroupBox1.Controls.Add(Me.lblFinalCVCase1)
        Me.GroupBox1.Controls.Add(Me.lblFinalKVcase3)
        Me.GroupBox1.Controls.Add(Me.lblFinalKvCase2)
        Me.GroupBox1.Controls.Add(Me.lblFinalKVCase1)
        Me.GroupBox1.Controls.Add(Me.lblCalculatedCV)
        Me.GroupBox1.Controls.Add(Me.lblCalculatedKV)
        Me.GroupBox1.Controls.Add(Me.lblApproxCVCase3)
        Me.GroupBox1.Controls.Add(Me.lblApproxCVCase2)
        Me.GroupBox1.Controls.Add(Me.lblApproxCVCase1)
        Me.GroupBox1.Controls.Add(Me.lblKVCase3)
        Me.GroupBox1.Controls.Add(Me.lblKVCase2)
        Me.GroupBox1.Controls.Add(Me.lblKVCase1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(93, 510)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 153)
        Me.GroupBox1.TabIndex = 249
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Results"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(354, 14)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(44, 15)
        Me.Label58.TabIndex = 270
        Me.Label58.Text = "Case III"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(211, 14)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(38, 15)
        Me.Label59.TabIndex = 271
        Me.Label59.Text = "Case I"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(282, 14)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(41, 15)
        Me.Label56.TabIndex = 269
        Me.Label56.Text = "Case II"
        '
        'lblFLCase3
        '
        Me.lblFLCase3.AutoSize = True
        Me.lblFLCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblFLCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFLCase3.ForeColor = System.Drawing.Color.Black
        Me.lblFLCase3.Location = New System.Drawing.Point(353, 132)
        Me.lblFLCase3.Name = "lblFLCase3"
        Me.lblFLCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblFLCase3.TabIndex = 305
        '
        'lblFLCase2
        '
        Me.lblFLCase2.AutoSize = True
        Me.lblFLCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblFLCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFLCase2.ForeColor = System.Drawing.Color.Black
        Me.lblFLCase2.Location = New System.Drawing.Point(282, 132)
        Me.lblFLCase2.Name = "lblFLCase2"
        Me.lblFLCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblFLCase2.TabIndex = 304
        '
        'lblFLCase1
        '
        Me.lblFLCase1.AutoSize = True
        Me.lblFLCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblFLCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFLCase1.ForeColor = System.Drawing.Color.Black
        Me.lblFLCase1.Location = New System.Drawing.Point(211, 132)
        Me.lblFLCase1.Name = "lblFLCase1"
        Me.lblFLCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblFLCase1.TabIndex = 303
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(36, 132)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(19, 15)
        Me.Label39.TabIndex = 302
        Me.Label39.Text = "FL"
        '
        'txtFlashingPercentageCase3
        '
        Me.txtFlashingPercentageCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlashingPercentageCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtFlashingPercentageCase3.Location = New System.Drawing.Point(351, 398)
        Me.txtFlashingPercentageCase3.Name = "txtFlashingPercentageCase3"
        Me.txtFlashingPercentageCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtFlashingPercentageCase3.TabIndex = 55
        Me.txtFlashingPercentageCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFlashingPercentageCase3.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(17, 32)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(99, 15)
        Me.Label34.TabIndex = 290
        Me.Label34.Text = "Calculated Noise "
        '
        'lblNoiseCase2
        '
        Me.lblNoiseCase2.AutoSize = True
        Me.lblNoiseCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblNoiseCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoiseCase2.ForeColor = System.Drawing.Color.Black
        Me.lblNoiseCase2.Location = New System.Drawing.Point(250, 32)
        Me.lblNoiseCase2.Name = "lblNoiseCase2"
        Me.lblNoiseCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblNoiseCase2.TabIndex = 291
        '
        'lblMachnoValve
        '
        Me.lblMachnoValve.AutoSize = True
        Me.lblMachnoValve.BackColor = System.Drawing.Color.Transparent
        Me.lblMachnoValve.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachnoValve.ForeColor = System.Drawing.Color.Black
        Me.lblMachnoValve.Location = New System.Drawing.Point(35, 109)
        Me.lblMachnoValve.Name = "lblMachnoValve"
        Me.lblMachnoValve.Size = New System.Drawing.Size(106, 15)
        Me.lblMachnoValve.TabIndex = 287
        Me.lblMachnoValve.Text = "MachNo Valve Out"
        '
        'lblNoiseCase3
        '
        Me.lblNoiseCase3.AutoSize = True
        Me.lblNoiseCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblNoiseCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoiseCase3.ForeColor = System.Drawing.Color.Black
        Me.lblNoiseCase3.Location = New System.Drawing.Point(325, 32)
        Me.lblNoiseCase3.Name = "lblNoiseCase3"
        Me.lblNoiseCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblNoiseCase3.TabIndex = 292
        '
        'lblMachnoPipe
        '
        Me.lblMachnoPipe.AutoSize = True
        Me.lblMachnoPipe.BackColor = System.Drawing.Color.Transparent
        Me.lblMachnoPipe.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachnoPipe.ForeColor = System.Drawing.Color.Black
        Me.lblMachnoPipe.Location = New System.Drawing.Point(35, 128)
        Me.lblMachnoPipe.Name = "lblMachnoPipe"
        Me.lblMachnoPipe.Size = New System.Drawing.Size(102, 15)
        Me.lblMachnoPipe.TabIndex = 288
        Me.lblMachnoPipe.Text = "MachNo Pipe Out"
        '
        'lblNoiseCase1
        '
        Me.lblNoiseCase1.AutoSize = True
        Me.lblNoiseCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblNoiseCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoiseCase1.ForeColor = System.Drawing.Color.Black
        Me.lblNoiseCase1.Location = New System.Drawing.Point(175, 32)
        Me.lblNoiseCase1.Name = "lblNoiseCase1"
        Me.lblNoiseCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblNoiseCase1.TabIndex = 293
        '
        'lblMachNoVavleOutCase1
        '
        Me.lblMachNoVavleOutCase1.AutoSize = True
        Me.lblMachNoVavleOutCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblMachNoVavleOutCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachNoVavleOutCase1.ForeColor = System.Drawing.Color.Black
        Me.lblMachNoVavleOutCase1.Location = New System.Drawing.Point(189, 112)
        Me.lblMachNoVavleOutCase1.Name = "lblMachNoVavleOutCase1"
        Me.lblMachNoVavleOutCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblMachNoVavleOutCase1.TabIndex = 289
        '
        'chkNoiseAttenuation
        '
        Me.chkNoiseAttenuation.AutoSize = True
        Me.chkNoiseAttenuation.BackColor = System.Drawing.Color.Transparent
        Me.chkNoiseAttenuation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoiseAttenuation.ForeColor = System.Drawing.Color.Black
        Me.chkNoiseAttenuation.Location = New System.Drawing.Point(17, 52)
        Me.chkNoiseAttenuation.Name = "chkNoiseAttenuation"
        Me.chkNoiseAttenuation.Size = New System.Drawing.Size(89, 19)
        Me.chkNoiseAttenuation.TabIndex = 91
        Me.chkNoiseAttenuation.Text = "Attenuation"
        Me.chkNoiseAttenuation.UseVisualStyleBackColor = False
        '
        'lblMachNoVavleOutCase2
        '
        Me.lblMachNoVavleOutCase2.AutoSize = True
        Me.lblMachNoVavleOutCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblMachNoVavleOutCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachNoVavleOutCase2.ForeColor = System.Drawing.Color.Black
        Me.lblMachNoVavleOutCase2.Location = New System.Drawing.Point(257, 112)
        Me.lblMachNoVavleOutCase2.Name = "lblMachNoVavleOutCase2"
        Me.lblMachNoVavleOutCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblMachNoVavleOutCase2.TabIndex = 290
        '
        'lblAttenuatedNoiseCase1
        '
        Me.lblAttenuatedNoiseCase1.AutoSize = True
        Me.lblAttenuatedNoiseCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblAttenuatedNoiseCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttenuatedNoiseCase1.ForeColor = System.Drawing.Color.Black
        Me.lblAttenuatedNoiseCase1.Location = New System.Drawing.Point(175, 52)
        Me.lblAttenuatedNoiseCase1.Name = "lblAttenuatedNoiseCase1"
        Me.lblAttenuatedNoiseCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblAttenuatedNoiseCase1.TabIndex = 294
        '
        'lblMachNoVavleOutCase3
        '
        Me.lblMachNoVavleOutCase3.AutoSize = True
        Me.lblMachNoVavleOutCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblMachNoVavleOutCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachNoVavleOutCase3.ForeColor = System.Drawing.Color.Black
        Me.lblMachNoVavleOutCase3.Location = New System.Drawing.Point(325, 112)
        Me.lblMachNoVavleOutCase3.Name = "lblMachNoVavleOutCase3"
        Me.lblMachNoVavleOutCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblMachNoVavleOutCase3.TabIndex = 291
        '
        'lblAttenuatedNoiseCase2
        '
        Me.lblAttenuatedNoiseCase2.AutoSize = True
        Me.lblAttenuatedNoiseCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblAttenuatedNoiseCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttenuatedNoiseCase2.ForeColor = System.Drawing.Color.Black
        Me.lblAttenuatedNoiseCase2.Location = New System.Drawing.Point(250, 52)
        Me.lblAttenuatedNoiseCase2.Name = "lblAttenuatedNoiseCase2"
        Me.lblAttenuatedNoiseCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblAttenuatedNoiseCase2.TabIndex = 295
        '
        'lblMachNoPipeOutCase1
        '
        Me.lblMachNoPipeOutCase1.AutoSize = True
        Me.lblMachNoPipeOutCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblMachNoPipeOutCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachNoPipeOutCase1.ForeColor = System.Drawing.Color.Black
        Me.lblMachNoPipeOutCase1.Location = New System.Drawing.Point(189, 132)
        Me.lblMachNoPipeOutCase1.Name = "lblMachNoPipeOutCase1"
        Me.lblMachNoPipeOutCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblMachNoPipeOutCase1.TabIndex = 292
        '
        'lblAttenuatedNoiseCase3
        '
        Me.lblAttenuatedNoiseCase3.AutoSize = True
        Me.lblAttenuatedNoiseCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblAttenuatedNoiseCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttenuatedNoiseCase3.ForeColor = System.Drawing.Color.Black
        Me.lblAttenuatedNoiseCase3.Location = New System.Drawing.Point(325, 52)
        Me.lblAttenuatedNoiseCase3.Name = "lblAttenuatedNoiseCase3"
        Me.lblAttenuatedNoiseCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblAttenuatedNoiseCase3.TabIndex = 296
        '
        'lblMachNoPipeOutCase2
        '
        Me.lblMachNoPipeOutCase2.AutoSize = True
        Me.lblMachNoPipeOutCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblMachNoPipeOutCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachNoPipeOutCase2.ForeColor = System.Drawing.Color.Black
        Me.lblMachNoPipeOutCase2.Location = New System.Drawing.Point(257, 132)
        Me.lblMachNoPipeOutCase2.Name = "lblMachNoPipeOutCase2"
        Me.lblMachNoPipeOutCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblMachNoPipeOutCase2.TabIndex = 293
        '
        'chkInsulation
        '
        Me.chkInsulation.AutoSize = True
        Me.chkInsulation.BackColor = System.Drawing.Color.Transparent
        Me.chkInsulation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInsulation.ForeColor = System.Drawing.Color.Black
        Me.chkInsulation.Location = New System.Drawing.Point(17, 112)
        Me.chkInsulation.Name = "chkInsulation"
        Me.chkInsulation.Size = New System.Drawing.Size(78, 19)
        Me.chkInsulation.TabIndex = 92
        Me.chkInsulation.Text = "Insulation"
        Me.chkInsulation.UseVisualStyleBackColor = False
        '
        'lblMachNoPipeOutCase3
        '
        Me.lblMachNoPipeOutCase3.AutoSize = True
        Me.lblMachNoPipeOutCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblMachNoPipeOutCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachNoPipeOutCase3.ForeColor = System.Drawing.Color.Black
        Me.lblMachNoPipeOutCase3.Location = New System.Drawing.Point(325, 132)
        Me.lblMachNoPipeOutCase3.Name = "lblMachNoPipeOutCase3"
        Me.lblMachNoPipeOutCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblMachNoPipeOutCase3.TabIndex = 294
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(17, 72)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(103, 15)
        Me.Label35.TabIndex = 298
        Me.Label35.Text = "Cage Drop in barg"
        '
        'lblAttnPressDropCase1
        '
        Me.lblAttnPressDropCase1.AutoSize = True
        Me.lblAttnPressDropCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblAttnPressDropCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttnPressDropCase1.ForeColor = System.Drawing.Color.Black
        Me.lblAttnPressDropCase1.Location = New System.Drawing.Point(175, 72)
        Me.lblAttnPressDropCase1.Name = "lblAttnPressDropCase1"
        Me.lblAttnPressDropCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblAttnPressDropCase1.TabIndex = 299
        '
        'lblAttnPressDropCase2
        '
        Me.lblAttnPressDropCase2.AutoSize = True
        Me.lblAttnPressDropCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblAttnPressDropCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttnPressDropCase2.ForeColor = System.Drawing.Color.Black
        Me.lblAttnPressDropCase2.Location = New System.Drawing.Point(250, 72)
        Me.lblAttnPressDropCase2.Name = "lblAttnPressDropCase2"
        Me.lblAttnPressDropCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblAttnPressDropCase2.TabIndex = 300
        '
        'lblAttnPressDropCase3
        '
        Me.lblAttnPressDropCase3.AutoSize = True
        Me.lblAttnPressDropCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblAttnPressDropCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttnPressDropCase3.ForeColor = System.Drawing.Color.Black
        Me.lblAttnPressDropCase3.Location = New System.Drawing.Point(325, 72)
        Me.lblAttnPressDropCase3.Name = "lblAttnPressDropCase3"
        Me.lblAttnPressDropCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblAttnPressDropCase3.TabIndex = 301
        '
        'lblXT
        '
        Me.lblXT.AutoSize = True
        Me.lblXT.BackColor = System.Drawing.Color.Transparent
        Me.lblXT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXT.ForeColor = System.Drawing.Color.Black
        Me.lblXT.Location = New System.Drawing.Point(17, 92)
        Me.lblXT.Name = "lblXT"
        Me.lblXT.Size = New System.Drawing.Size(20, 15)
        Me.lblXT.TabIndex = 306
        Me.lblXT.Text = "XT"
        '
        'lblXTCase1
        '
        Me.lblXTCase1.AutoSize = True
        Me.lblXTCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblXTCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXTCase1.ForeColor = System.Drawing.Color.Black
        Me.lblXTCase1.Location = New System.Drawing.Point(175, 92)
        Me.lblXTCase1.Name = "lblXTCase1"
        Me.lblXTCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblXTCase1.TabIndex = 307
        '
        'lblXTCase2
        '
        Me.lblXTCase2.AutoSize = True
        Me.lblXTCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblXTCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXTCase2.ForeColor = System.Drawing.Color.Black
        Me.lblXTCase2.Location = New System.Drawing.Point(250, 92)
        Me.lblXTCase2.Name = "lblXTCase2"
        Me.lblXTCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblXTCase2.TabIndex = 308
        '
        'lblXTCase3
        '
        Me.lblXTCase3.AutoSize = True
        Me.lblXTCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblXTCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXTCase3.ForeColor = System.Drawing.Color.Black
        Me.lblXTCase3.Location = New System.Drawing.Point(325, 92)
        Me.lblXTCase3.Name = "lblXTCase3"
        Me.lblXTCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblXTCase3.TabIndex = 309
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox2.Controls.Add(Me.lblFlashingCaseNoAttenuation)
        Me.GroupBox2.Controls.Add(Me.lblInsulationMessage)
        Me.GroupBox2.Controls.Add(Me.lblFP)
        Me.GroupBox2.Controls.Add(Me.Label61)
        Me.GroupBox2.Controls.Add(Me.Label62)
        Me.GroupBox2.Controls.Add(Me.Label74)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.lblXTCase3)
        Me.GroupBox2.Controls.Add(Me.lblAttnPressDropCase3)
        Me.GroupBox2.Controls.Add(Me.lblAttnPressDropCase2)
        Me.GroupBox2.Controls.Add(Me.lblXTCase2)
        Me.GroupBox2.Controls.Add(Me.lblAttnPressDropCase1)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.lblXTCase1)
        Me.GroupBox2.Controls.Add(Me.chkInsulation)
        Me.GroupBox2.Controls.Add(Me.lblAttenuatedNoiseCase3)
        Me.GroupBox2.Controls.Add(Me.lblXT)
        Me.GroupBox2.Controls.Add(Me.lblAttenuatedNoiseCase2)
        Me.GroupBox2.Controls.Add(Me.lblAttenuatedNoiseCase1)
        Me.GroupBox2.Controls.Add(Me.chkNoiseAttenuation)
        Me.GroupBox2.Controls.Add(Me.lblNoiseCase1)
        Me.GroupBox2.Controls.Add(Me.lblNoiseCase3)
        Me.GroupBox2.Controls.Add(Me.lblNoiseCase2)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(935, 510)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 153)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Noise in db"
        '
        'lblFlashingCaseNoAttenuation
        '
        Me.lblFlashingCaseNoAttenuation.AutoSize = True
        Me.lblFlashingCaseNoAttenuation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlashingCaseNoAttenuation.ForeColor = System.Drawing.Color.Black
        Me.lblFlashingCaseNoAttenuation.Location = New System.Drawing.Point(143, 50)
        Me.lblFlashingCaseNoAttenuation.Name = "lblFlashingCaseNoAttenuation"
        Me.lblFlashingCaseNoAttenuation.Size = New System.Drawing.Size(0, 15)
        Me.lblFlashingCaseNoAttenuation.TabIndex = 315
        '
        'lblInsulationMessage
        '
        Me.lblInsulationMessage.AutoSize = True
        Me.lblInsulationMessage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsulationMessage.ForeColor = System.Drawing.Color.Black
        Me.lblInsulationMessage.Location = New System.Drawing.Point(175, 112)
        Me.lblInsulationMessage.Name = "lblInsulationMessage"
        Me.lblInsulationMessage.Size = New System.Drawing.Size(0, 15)
        Me.lblInsulationMessage.TabIndex = 314
        '
        'lblFP
        '
        Me.lblFP.AutoSize = True
        Me.lblFP.BackColor = System.Drawing.Color.Transparent
        Me.lblFP.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFP.ForeColor = System.Drawing.Color.Black
        Me.lblFP.Location = New System.Drawing.Point(131, 132)
        Me.lblFP.Name = "lblFP"
        Me.lblFP.Size = New System.Drawing.Size(0, 15)
        Me.lblFP.TabIndex = 313
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(174, 13)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(38, 15)
        Me.Label61.TabIndex = 274
        Me.Label61.Text = "Case I"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.Black
        Me.Label62.Location = New System.Drawing.Point(323, 13)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(44, 15)
        Me.Label62.TabIndex = 273
        Me.Label62.Text = "Case III"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.Black
        Me.Label74.Location = New System.Drawing.Point(244, 13)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(41, 15)
        Me.Label74.TabIndex = 272
        Me.Label74.Text = "Case II"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(17, 132)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(20, 15)
        Me.Label41.TabIndex = 312
        Me.Label41.Text = "FP"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(35, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 15)
        Me.Label15.TabIndex = 274
        Me.Label15.Text = "Valve Inlet"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(35, 52)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 15)
        Me.Label28.TabIndex = 275
        Me.Label28.Text = "Valve Outlet"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(35, 90)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(66, 15)
        Me.Label29.TabIndex = 276
        Me.Label29.Text = "Pipe Outlet"
        '
        'lblVelocityValveInletCase1
        '
        Me.lblVelocityValveInletCase1.AutoSize = True
        Me.lblVelocityValveInletCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityValveInletCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityValveInletCase1.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityValveInletCase1.Location = New System.Drawing.Point(189, 32)
        Me.lblVelocityValveInletCase1.Name = "lblVelocityValveInletCase1"
        Me.lblVelocityValveInletCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityValveInletCase1.TabIndex = 277
        '
        'lblVelocityValveInletCase2
        '
        Me.lblVelocityValveInletCase2.AutoSize = True
        Me.lblVelocityValveInletCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityValveInletCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityValveInletCase2.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityValveInletCase2.Location = New System.Drawing.Point(257, 32)
        Me.lblVelocityValveInletCase2.Name = "lblVelocityValveInletCase2"
        Me.lblVelocityValveInletCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityValveInletCase2.TabIndex = 278
        '
        'lblVelocityValveInletCase3
        '
        Me.lblVelocityValveInletCase3.AutoSize = True
        Me.lblVelocityValveInletCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityValveInletCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityValveInletCase3.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityValveInletCase3.Location = New System.Drawing.Point(325, 32)
        Me.lblVelocityValveInletCase3.Name = "lblVelocityValveInletCase3"
        Me.lblVelocityValveInletCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityValveInletCase3.TabIndex = 279
        '
        'lblVelocityValveOutletCase1
        '
        Me.lblVelocityValveOutletCase1.AutoSize = True
        Me.lblVelocityValveOutletCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityValveOutletCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityValveOutletCase1.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityValveOutletCase1.Location = New System.Drawing.Point(189, 52)
        Me.lblVelocityValveOutletCase1.Name = "lblVelocityValveOutletCase1"
        Me.lblVelocityValveOutletCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityValveOutletCase1.TabIndex = 280
        '
        'lblVelocityValveOutletCase2
        '
        Me.lblVelocityValveOutletCase2.AutoSize = True
        Me.lblVelocityValveOutletCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityValveOutletCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityValveOutletCase2.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityValveOutletCase2.Location = New System.Drawing.Point(257, 52)
        Me.lblVelocityValveOutletCase2.Name = "lblVelocityValveOutletCase2"
        Me.lblVelocityValveOutletCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityValveOutletCase2.TabIndex = 281
        '
        'lblVelocityValveOutletCase3
        '
        Me.lblVelocityValveOutletCase3.AutoSize = True
        Me.lblVelocityValveOutletCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityValveOutletCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityValveOutletCase3.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityValveOutletCase3.Location = New System.Drawing.Point(325, 52)
        Me.lblVelocityValveOutletCase3.Name = "lblVelocityValveOutletCase3"
        Me.lblVelocityValveOutletCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityValveOutletCase3.TabIndex = 282
        '
        'lblVelocityOutletPipeCase1
        '
        Me.lblVelocityOutletPipeCase1.AutoSize = True
        Me.lblVelocityOutletPipeCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityOutletPipeCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityOutletPipeCase1.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityOutletPipeCase1.Location = New System.Drawing.Point(189, 92)
        Me.lblVelocityOutletPipeCase1.Name = "lblVelocityOutletPipeCase1"
        Me.lblVelocityOutletPipeCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityOutletPipeCase1.TabIndex = 283
        '
        'lblVelocityOutletPipeCase2
        '
        Me.lblVelocityOutletPipeCase2.AutoSize = True
        Me.lblVelocityOutletPipeCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityOutletPipeCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityOutletPipeCase2.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityOutletPipeCase2.Location = New System.Drawing.Point(257, 92)
        Me.lblVelocityOutletPipeCase2.Name = "lblVelocityOutletPipeCase2"
        Me.lblVelocityOutletPipeCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityOutletPipeCase2.TabIndex = 284
        '
        'lblVelocityOutletPipeCase3
        '
        Me.lblVelocityOutletPipeCase3.AutoSize = True
        Me.lblVelocityOutletPipeCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityOutletPipeCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityOutletPipeCase3.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityOutletPipeCase3.Location = New System.Drawing.Point(325, 92)
        Me.lblVelocityOutletPipeCase3.Name = "lblVelocityOutletPipeCase3"
        Me.lblVelocityOutletPipeCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityOutletPipeCase3.TabIndex = 285
        '
        'lblVelocityunit
        '
        Me.lblVelocityunit.AutoSize = True
        Me.lblVelocityunit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityunit.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityunit.Location = New System.Drawing.Point(83, 1)
        Me.lblVelocityunit.Name = "lblVelocityunit"
        Me.lblVelocityunit.Size = New System.Drawing.Size(36, 17)
        Me.lblVelocityunit.TabIndex = 286
        Me.lblVelocityunit.Text = "m/s "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox3.Controls.Add(Me.lblVelocityunit)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.lblVelocityInletPipeCase3)
        Me.GroupBox3.Controls.Add(Me.Label49)
        Me.GroupBox3.Controls.Add(Me.lblVelocityInletPipeCase2)
        Me.GroupBox3.Controls.Add(Me.lblVelocityInletPipeCase1)
        Me.GroupBox3.Controls.Add(Me.Label60)
        Me.GroupBox3.Controls.Add(Me.lblVelocityOutletPipeCase3)
        Me.GroupBox3.Controls.Add(Me.lblVelocityOutletPipeCase2)
        Me.GroupBox3.Controls.Add(Me.lblVelocityOutletPipeCase1)
        Me.GroupBox3.Controls.Add(Me.lblVelocityValveOutletCase3)
        Me.GroupBox3.Controls.Add(Me.lblVelocityValveOutletCase2)
        Me.GroupBox3.Controls.Add(Me.lblVelocityValveOutletCase1)
        Me.GroupBox3.Controls.Add(Me.lblVelocityValveInletCase3)
        Me.GroupBox3.Controls.Add(Me.lblVelocityValveInletCase2)
        Me.GroupBox3.Controls.Add(Me.lblVelocityValveInletCase1)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.lblMachNoPipeOutCase3)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.lblMachnoValve)
        Me.GroupBox3.Controls.Add(Me.lblMachNoPipeOutCase2)
        Me.GroupBox3.Controls.Add(Me.lblMachnoPipe)
        Me.GroupBox3.Controls.Add(Me.lblMachNoVavleOutCase1)
        Me.GroupBox3.Controls.Add(Me.lblMachNoPipeOutCase1)
        Me.GroupBox3.Controls.Add(Me.lblMachNoVavleOutCase2)
        Me.GroupBox3.Controls.Add(Me.lblMachNoVavleOutCase3)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(514, 510)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(421, 153)
        Me.GroupBox3.TabIndex = 297
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Velocity in             "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(187, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 318
        Me.Label4.Text = "Case I"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(326, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 15)
        Me.Label17.TabIndex = 317
        Me.Label17.Text = "Case III"
        '
        'lblVelocityInletPipeCase3
        '
        Me.lblVelocityInletPipeCase3.AutoSize = True
        Me.lblVelocityInletPipeCase3.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityInletPipeCase3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityInletPipeCase3.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityInletPipeCase3.Location = New System.Drawing.Point(325, 72)
        Me.lblVelocityInletPipeCase3.Name = "lblVelocityInletPipeCase3"
        Me.lblVelocityInletPipeCase3.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityInletPipeCase3.TabIndex = 290
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(252, 13)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(41, 15)
        Me.Label49.TabIndex = 316
        Me.Label49.Text = "Case II"
        '
        'lblVelocityInletPipeCase2
        '
        Me.lblVelocityInletPipeCase2.AutoSize = True
        Me.lblVelocityInletPipeCase2.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityInletPipeCase2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityInletPipeCase2.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityInletPipeCase2.Location = New System.Drawing.Point(257, 72)
        Me.lblVelocityInletPipeCase2.Name = "lblVelocityInletPipeCase2"
        Me.lblVelocityInletPipeCase2.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityInletPipeCase2.TabIndex = 289
        '
        'lblVelocityInletPipeCase1
        '
        Me.lblVelocityInletPipeCase1.AutoSize = True
        Me.lblVelocityInletPipeCase1.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityInletPipeCase1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityInletPipeCase1.ForeColor = System.Drawing.Color.Black
        Me.lblVelocityInletPipeCase1.Location = New System.Drawing.Point(189, 72)
        Me.lblVelocityInletPipeCase1.Name = "lblVelocityInletPipeCase1"
        Me.lblVelocityInletPipeCase1.Size = New System.Drawing.Size(0, 15)
        Me.lblVelocityInletPipeCase1.TabIndex = 288
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(35, 71)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(56, 15)
        Me.Label60.TabIndex = 287
        Me.Label60.Text = "Pipe Inlet"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomerDetailsToolStripMenuItem, Me.MaterialsToolStripMenuItem, Me.AccessoriesToolStripMenuItem, Me.UserNotesToolStripMenuItem, Me.PrintToolStripMenuItem, Me.AboutToolStripMenuItem, Me.NewTagToolStripMenuItem, Me.CopyTagToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 45)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(602, 24)
        Me.MenuStrip1.TabIndex = 298
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.CustomerDetailsToolStripMenuItem.Text = "Customer &Details"
        '
        'MaterialsToolStripMenuItem
        '
        Me.MaterialsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaterialsToolStripMenuItem.Name = "MaterialsToolStripMenuItem"
        Me.MaterialsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MaterialsToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.MaterialsToolStripMenuItem.Text = "&Materials"
        '
        'AccessoriesToolStripMenuItem
        '
        Me.AccessoriesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AccessoriesToolStripMenuItem.Name = "AccessoriesToolStripMenuItem"
        Me.AccessoriesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AccessoriesToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AccessoriesToolStripMenuItem.Text = "&Accessories"
        '
        'UserNotesToolStripMenuItem
        '
        Me.UserNotesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNotesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UserNotesToolStripMenuItem.Name = "UserNotesToolStripMenuItem"
        Me.UserNotesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UserNotesToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.UserNotesToolStripMenuItem.Text = "&User Notes"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordsToolStripMenuItem, Me.DatasheetToolStripMenuItem, Me.ConfiguratorToolStripMenuItem})
        Me.PrintToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'DatasheetToolStripMenuItem
        '
        Me.DatasheetToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DatasheetToolStripMenuItem.Name = "DatasheetToolStripMenuItem"
        Me.DatasheetToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.DatasheetToolStripMenuItem.Text = "Datasheet"
        '
        'ConfiguratorToolStripMenuItem
        '
        Me.ConfiguratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CRMToolStripMenuItem, Me.CSVToolStripMenuItem})
        Me.ConfiguratorToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ConfiguratorToolStripMenuItem.Name = "ConfiguratorToolStripMenuItem"
        Me.ConfiguratorToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ConfiguratorToolStripMenuItem.Text = "Configurator"
        '
        'CRMToolStripMenuItem
        '
        Me.CRMToolStripMenuItem.Name = "CRMToolStripMenuItem"
        Me.CRMToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.CRMToolStripMenuItem.Text = "CRM"
        '
        'CSVToolStripMenuItem
        '
        Me.CSVToolStripMenuItem.Name = "CSVToolStripMenuItem"
        Me.CSVToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.CSVToolStripMenuItem.Text = "CSV"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChartsToolStripMenuItem, Me.KvCvChartToolStripMenuItem, Me.DiagnosisToolStripMenuItem, Me.ActuatorDetailsToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "&Help"
        '
        'ChartsToolStripMenuItem
        '
        Me.ChartsToolStripMenuItem.Name = "ChartsToolStripMenuItem"
        Me.ChartsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ChartsToolStripMenuItem.Text = "Charts"
        '
        'KvCvChartToolStripMenuItem
        '
        Me.KvCvChartToolStripMenuItem.Name = "KvCvChartToolStripMenuItem"
        Me.KvCvChartToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.KvCvChartToolStripMenuItem.Text = "Kv/Cv Guide"
        '
        'DiagnosisToolStripMenuItem
        '
        Me.DiagnosisToolStripMenuItem.Name = "DiagnosisToolStripMenuItem"
        Me.DiagnosisToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.DiagnosisToolStripMenuItem.Text = "Diagnosis"
        '
        'ActuatorDetailsToolStripMenuItem
        '
        Me.ActuatorDetailsToolStripMenuItem.Name = "ActuatorDetailsToolStripMenuItem"
        Me.ActuatorDetailsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ActuatorDetailsToolStripMenuItem.Text = "Actuator Details"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'NewTagToolStripMenuItem
        '
        Me.NewTagToolStripMenuItem.Name = "NewTagToolStripMenuItem"
        Me.NewTagToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.NewTagToolStripMenuItem.Text = "New Tag"
        '
        'CopyTagToolStripMenuItem
        '
        Me.CopyTagToolStripMenuItem.Name = "CopyTagToolStripMenuItem"
        Me.CopyTagToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.CopyTagToolStripMenuItem.Text = "Copy Tag"
        '
        'Dlg_OpenXML
        '
        Me.Dlg_OpenXML.FileName = "OpenFileDialog1"
        '
        'txtErrors
        '
        Me.txtErrors.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtErrors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtErrors.Location = New System.Drawing.Point(25, 663)
        Me.txtErrors.Multiline = True
        Me.txtErrors.Name = "txtErrors"
        Me.txtErrors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtErrors.Size = New System.Drawing.Size(550, 31)
        Me.txtErrors.TabIndex = 0
        '
        'lblDatabaseRowNo
        '
        Me.lblDatabaseRowNo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatabaseRowNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.lblDatabaseRowNo.Location = New System.Drawing.Point(614, 47)
        Me.lblDatabaseRowNo.Name = "lblDatabaseRowNo"
        Me.lblDatabaseRowNo.Size = New System.Drawing.Size(89, 21)
        Me.lblDatabaseRowNo.TabIndex = 302
        Me.lblDatabaseRowNo.Text = "65535/65535"
        Me.lblDatabaseRowNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.ForeColor = System.Drawing.Color.Gray
        Me.Label109.Location = New System.Drawing.Point(49, 51)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(7, 10)
        Me.Label109.TabIndex = 305
        Me.Label109.Text = "|"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.ForeColor = System.Drawing.Color.Gray
        Me.Label110.Location = New System.Drawing.Point(157, 51)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(7, 10)
        Me.Label110.TabIndex = 306
        Me.Label110.Text = "|"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.ForeColor = System.Drawing.Color.Gray
        Me.Label111.Location = New System.Drawing.Point(226, 51)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(7, 10)
        Me.Label111.TabIndex = 307
        Me.Label111.Text = "|"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.ForeColor = System.Drawing.Color.Gray
        Me.Label112.Location = New System.Drawing.Point(384, 51)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(7, 10)
        Me.Label112.TabIndex = 308
        Me.Label112.Text = "|"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.ForeColor = System.Drawing.Color.Gray
        Me.Label113.Location = New System.Drawing.Point(426, 51)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(7, 10)
        Me.Label113.TabIndex = 309
        Me.Label113.Text = "|"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(306, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(7, 10)
        Me.Label2.TabIndex = 317
        Me.Label2.Text = "|"
        '
        'lblHelp
        '
        Me.lblHelp.BackColor = System.Drawing.Color.Transparent
        Me.lblHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHelp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.DimGray
        Me.lblHelp.Location = New System.Drawing.Point(581, 666)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(514, 18)
        Me.lblHelp.TabIndex = 318
        Me.lblHelp.Text = "HELP: "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.FMValveApplication_standard.My.Resources.Resources.Base_frame3
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.PanelPRDS)
        Me.Panel1.Controls.Add(Me.Label57)
        Me.Panel1.Controls.Add(Me.txtMedium)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.txtTOutPressureCase3)
        Me.Panel1.Controls.Add(Me.txtTOutPressureCase2)
        Me.Panel1.Controls.Add(Me.txtTOutPressureCase1)
        Me.Panel1.Controls.Add(Me.lblToutPressure)
        Me.Panel1.Controls.Add(Me.txtTsatInletCase3)
        Me.Panel1.Controls.Add(Me.txtTsatInletCase2)
        Me.Panel1.Controls.Add(Me.txtTsatInletCase1)
        Me.Panel1.Controls.Add(Me.lblTsatInletPress)
        Me.Panel1.Controls.Add(Me.lblMolecularUnit)
        Me.Panel1.Controls.Add(Me.chkViscosity)
        Me.Panel1.Controls.Add(Me.txtViscosityCase1)
        Me.Panel1.Controls.Add(Me.txtViscosityCase2)
        Me.Panel1.Controls.Add(Me.txtViscosityCase3)
        Me.Panel1.Controls.Add(Me.cmbViscosityUnits)
        Me.Panel1.Controls.Add(Me.txtTsatoutPressureCase3)
        Me.Panel1.Controls.Add(Me.txtTsatoutPressureCase2)
        Me.Panel1.Controls.Add(Me.txtTsatoutPressureCase1)
        Me.Panel1.Controls.Add(Me.lblTsatoutPressure)
        Me.Panel1.Controls.Add(Me.Label64)
        Me.Panel1.Controls.Add(Me.cmbQW)
        Me.Panel1.Controls.Add(Me.cmbFlowrate)
        Me.Panel1.Controls.Add(Me.txtFlowrateCase1)
        Me.Panel1.Controls.Add(Me.txtFlowrateCase2)
        Me.Panel1.Controls.Add(Me.txtFlowrateCase3)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtFlashingPercentageCase3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtFlashingPercentageCase2)
        Me.Panel1.Controls.Add(Me.txtK_Case2)
        Me.Panel1.Controls.Add(Me.txtFlashingPercentageCase1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblFlashingPercentage)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbPressureUnits)
        Me.Panel1.Controls.Add(Me.chkMolecularWeight)
        Me.Panel1.Controls.Add(Me.txtMolecularWeight)
        Me.Panel1.Controls.Add(Me.txtInletPressureCase1)
        Me.Panel1.Controls.Add(Me.btnSelectP2DP)
        Me.Panel1.Controls.Add(Me.txtInletPressureCase2)
        Me.Panel1.Controls.Add(Me.txtX_Case3)
        Me.Panel1.Controls.Add(Me.txtInletPressureCase3)
        Me.Panel1.Controls.Add(Me.txtX_Case1)
        Me.Panel1.Controls.Add(Me.txtOutletPressure1)
        Me.Panel1.Controls.Add(Me.txtX_Case2)
        Me.Panel1.Controls.Add(Me.txtOutletPressure2)
        Me.Panel1.Controls.Add(Me.lblX)
        Me.Panel1.Controls.Add(Me.txtOutletPressure3)
        Me.Panel1.Controls.Add(Me.txtZ_Case3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtZ_Case2)
        Me.Panel1.Controls.Add(Me.txtPressureDropCase1)
        Me.Panel1.Controls.Add(Me.txtZ_Case1)
        Me.Panel1.Controls.Add(Me.txtPressureDropCase2)
        Me.Panel1.Controls.Add(Me.lblZ)
        Me.Panel1.Controls.Add(Me.txtPressureDropCase3)
        Me.Panel1.Controls.Add(Me.txtK_Case3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmbTemperatureUnits)
        Me.Panel1.Controls.Add(Me.txtK_Case1)
        Me.Panel1.Controls.Add(Me.txtInletTemperatureCase1)
        Me.Panel1.Controls.Add(Me.txtInletTemperatureCase2)
        Me.Panel1.Controls.Add(Me.txtInletTemperatureCase3)
        Me.Panel1.Controls.Add(Me.lblDensity)
        Me.Panel1.Controls.Add(Me.cmbDensityUnits)
        Me.Panel1.Controls.Add(Me.txtDensityCase1)
        Me.Panel1.Controls.Add(Me.txtDensityCase2)
        Me.Panel1.Controls.Add(Me.txtDensityCase3)
        Me.Panel1.Controls.Add(Me.lblCriticalPressure)
        Me.Panel1.Controls.Add(Me.lblK)
        Me.Panel1.Controls.Add(Me.lblVapourPressure)
        Me.Panel1.Controls.Add(Me.txtCriticalPressureCase1)
        Me.Panel1.Controls.Add(Me.txtCriticalPressureCase2)
        Me.Panel1.Controls.Add(Me.txtCriticalPressureCase3)
        Me.Panel1.Controls.Add(Me.txtVapourPressureCase1)
        Me.Panel1.Controls.Add(Me.txtVapourPressureCase2)
        Me.Panel1.Controls.Add(Me.txtVapourPressureCase3)
        Me.Panel1.Controls.Add(Me.lblCriticalPressureUnit)
        Me.Panel1.Controls.Add(Me.lblVapourPressureUnit)
        Me.Panel1.Controls.Add(Me.cmbCriticalPressureUnits)
        Me.Panel1.Controls.Add(Me.cmbVapourPressureUnits)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.lblViscosity)
        Me.Panel1.Location = New System.Drawing.Point(93, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 426)
        Me.Panel1.TabIndex = 1
        '
        'PanelPRDS
        '
        Me.PanelPRDS.BackColor = System.Drawing.Color.Transparent
        Me.PanelPRDS.Controls.Add(Me.Label94)
        Me.PanelPRDS.Controls.Add(Me.txtP2OutWCase3)
        Me.PanelPRDS.Controls.Add(Me.txtP2OutWCase2)
        Me.PanelPRDS.Controls.Add(Me.txtP2OutWCase1)
        Me.PanelPRDS.Controls.Add(Me.Label76)
        Me.PanelPRDS.Controls.Add(Me.lblPwUnits)
        Me.PanelPRDS.Controls.Add(Me.txtWaterPressure)
        Me.PanelPRDS.Controls.Add(Me.lblFlowWaterUnit)
        Me.PanelPRDS.Controls.Add(Me.Label93)
        Me.PanelPRDS.Controls.Add(Me.txtWaterFlowCase3)
        Me.PanelPRDS.Controls.Add(Me.lblTwUnit)
        Me.PanelPRDS.Controls.Add(Me.txtWaterFlowCase2)
        Me.PanelPRDS.Controls.Add(Me.Label91)
        Me.PanelPRDS.Controls.Add(Me.txtWaterTemperature)
        Me.PanelPRDS.Controls.Add(Me.txtWaterFlowCase1)
        Me.PanelPRDS.Location = New System.Drawing.Point(13, 370)
        Me.PanelPRDS.Name = "PanelPRDS"
        Me.PanelPRDS.Size = New System.Drawing.Size(388, 50)
        Me.PanelPRDS.TabIndex = 47
        Me.PanelPRDS.Visible = False
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(155, 31)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(40, 13)
        Me.Label94.TabIndex = 394
        Me.Label94.Text = "Poutw"
        '
        'txtP2OutWCase3
        '
        Me.txtP2OutWCase3.BackColor = System.Drawing.SystemColors.Control
        Me.txtP2OutWCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP2OutWCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtP2OutWCase3.Location = New System.Drawing.Point(339, 26)
        Me.txtP2OutWCase3.Name = "txtP2OutWCase3"
        Me.txtP2OutWCase3.ReadOnly = True
        Me.txtP2OutWCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtP2OutWCase3.TabIndex = 7
        Me.txtP2OutWCase3.TabStop = False
        Me.txtP2OutWCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtP2OutWCase2
        '
        Me.txtP2OutWCase2.BackColor = System.Drawing.SystemColors.Control
        Me.txtP2OutWCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP2OutWCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtP2OutWCase2.Location = New System.Drawing.Point(270, 26)
        Me.txtP2OutWCase2.Name = "txtP2OutWCase2"
        Me.txtP2OutWCase2.ReadOnly = True
        Me.txtP2OutWCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtP2OutWCase2.TabIndex = 6
        Me.txtP2OutWCase2.TabStop = False
        Me.txtP2OutWCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtP2OutWCase1
        '
        Me.txtP2OutWCase1.BackColor = System.Drawing.SystemColors.Control
        Me.txtP2OutWCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP2OutWCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtP2OutWCase1.Location = New System.Drawing.Point(202, 27)
        Me.txtP2OutWCase1.Name = "txtP2OutWCase1"
        Me.txtP2OutWCase1.ReadOnly = True
        Me.txtP2OutWCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtP2OutWCase1.TabIndex = 5
        Me.txtP2OutWCase1.TabStop = False
        Me.txtP2OutWCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(1, 31)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(22, 13)
        Me.Label76.TabIndex = 1
        Me.Label76.Text = "Pw"
        '
        'lblPwUnits
        '
        Me.lblPwUnits.AutoSize = True
        Me.lblPwUnits.Location = New System.Drawing.Point(99, 31)
        Me.lblPwUnits.Name = "lblPwUnits"
        Me.lblPwUnits.Size = New System.Drawing.Size(31, 13)
        Me.lblPwUnits.TabIndex = 390
        Me.lblPwUnits.Text = "barA"
        Me.lblPwUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtWaterPressure
        '
        Me.txtWaterPressure.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterPressure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtWaterPressure.Location = New System.Drawing.Point(23, 26)
        Me.txtWaterPressure.Name = "txtWaterPressure"
        Me.txtWaterPressure.Size = New System.Drawing.Size(50, 22)
        Me.txtWaterPressure.TabIndex = 1
        Me.txtWaterPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFlowWaterUnit
        '
        Me.lblFlowWaterUnit.AutoSize = True
        Me.lblFlowWaterUnit.Location = New System.Drawing.Point(164, 6)
        Me.lblFlowWaterUnit.Name = "lblFlowWaterUnit"
        Me.lblFlowWaterUnit.Size = New System.Drawing.Size(35, 13)
        Me.lblFlowWaterUnit.TabIndex = 387
        Me.lblFlowWaterUnit.Text = "kg/hr"
        Me.lblFlowWaterUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Location = New System.Drawing.Point(101, 6)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(43, 13)
        Me.Label93.TabIndex = 4
        Me.Label93.Text = "FlowW"
        '
        'txtWaterFlowCase3
        '
        Me.txtWaterFlowCase3.BackColor = System.Drawing.SystemColors.Control
        Me.txtWaterFlowCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterFlowCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtWaterFlowCase3.Location = New System.Drawing.Point(338, 2)
        Me.txtWaterFlowCase3.Name = "txtWaterFlowCase3"
        Me.txtWaterFlowCase3.ReadOnly = True
        Me.txtWaterFlowCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtWaterFlowCase3.TabIndex = 4
        Me.txtWaterFlowCase3.TabStop = False
        Me.txtWaterFlowCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTwUnit
        '
        Me.lblTwUnit.AutoSize = True
        Me.lblTwUnit.Location = New System.Drawing.Point(75, 6)
        Me.lblTwUnit.Name = "lblTwUnit"
        Me.lblTwUnit.Size = New System.Drawing.Size(18, 13)
        Me.lblTwUnit.TabIndex = 378
        Me.lblTwUnit.Text = "°C"
        Me.lblTwUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtWaterFlowCase2
        '
        Me.txtWaterFlowCase2.BackColor = System.Drawing.SystemColors.Control
        Me.txtWaterFlowCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterFlowCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtWaterFlowCase2.Location = New System.Drawing.Point(269, 2)
        Me.txtWaterFlowCase2.Name = "txtWaterFlowCase2"
        Me.txtWaterFlowCase2.ReadOnly = True
        Me.txtWaterFlowCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtWaterFlowCase2.TabIndex = 3
        Me.txtWaterFlowCase2.TabStop = False
        Me.txtWaterFlowCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Location = New System.Drawing.Point(1, 6)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(21, 13)
        Me.Label91.TabIndex = 375
        Me.Label91.Text = "Tw"
        '
        'txtWaterTemperature
        '
        Me.txtWaterTemperature.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterTemperature.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtWaterTemperature.Location = New System.Drawing.Point(23, 1)
        Me.txtWaterTemperature.Name = "txtWaterTemperature"
        Me.txtWaterTemperature.Size = New System.Drawing.Size(50, 22)
        Me.txtWaterTemperature.TabIndex = 0
        Me.txtWaterTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWaterFlowCase1
        '
        Me.txtWaterFlowCase1.BackColor = System.Drawing.SystemColors.Control
        Me.txtWaterFlowCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterFlowCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtWaterFlowCase1.Location = New System.Drawing.Point(202, 3)
        Me.txtWaterFlowCase1.Name = "txtWaterFlowCase1"
        Me.txtWaterFlowCase1.ReadOnly = True
        Me.txtWaterFlowCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtWaterFlowCase1.TabIndex = 0
        Me.txtWaterFlowCase1.TabStop = False
        Me.txtWaterFlowCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label57.Location = New System.Drawing.Point(11, 5)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(370, 15)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "Field Parameters______________________________________________________"
        '
        'txtMedium
        '
        Me.txtMedium.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedium.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtMedium.Location = New System.Drawing.Point(65, 81)
        Me.txtMedium.Name = "txtMedium"
        Me.txtMedium.Size = New System.Drawing.Size(107, 22)
        Me.txtMedium.TabIndex = 1
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(14, 84)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(49, 13)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Medium"
        '
        'txtTOutPressureCase3
        '
        Me.txtTOutPressureCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTOutPressureCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtTOutPressureCase3.Location = New System.Drawing.Point(351, 371)
        Me.txtTOutPressureCase3.Name = "txtTOutPressureCase3"
        Me.txtTOutPressureCase3.ReadOnly = True
        Me.txtTOutPressureCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtTOutPressureCase3.TabIndex = 50
        Me.txtTOutPressureCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTOutPressureCase2
        '
        Me.txtTOutPressureCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTOutPressureCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtTOutPressureCase2.Location = New System.Drawing.Point(283, 373)
        Me.txtTOutPressureCase2.Name = "txtTOutPressureCase2"
        Me.txtTOutPressureCase2.ReadOnly = True
        Me.txtTOutPressureCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtTOutPressureCase2.TabIndex = 49
        Me.txtTOutPressureCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTOutPressureCase1
        '
        Me.txtTOutPressureCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTOutPressureCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtTOutPressureCase1.Location = New System.Drawing.Point(215, 373)
        Me.txtTOutPressureCase1.Name = "txtTOutPressureCase1"
        Me.txtTOutPressureCase1.ReadOnly = True
        Me.txtTOutPressureCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtTOutPressureCase1.TabIndex = 48
        Me.txtTOutPressureCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblToutPressure
        '
        Me.lblToutPressure.AutoSize = True
        Me.lblToutPressure.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToutPressure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblToutPressure.Location = New System.Drawing.Point(14, 375)
        Me.lblToutPressure.Name = "lblToutPressure"
        Me.lblToutPressure.Size = New System.Drawing.Size(109, 13)
        Me.lblToutPressure.TabIndex = 368
        Me.lblToutPressure.Text = "T at OutletPress.(T2)"
        '
        'txtTsatInletCase3
        '
        Me.txtTsatInletCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTsatInletCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtTsatInletCase3.Location = New System.Drawing.Point(351, 324)
        Me.txtTsatInletCase3.Name = "txtTsatInletCase3"
        Me.txtTsatInletCase3.ReadOnly = True
        Me.txtTsatInletCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtTsatInletCase3.TabIndex = 43
        Me.txtTsatInletCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTsatInletCase2
        '
        Me.txtTsatInletCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTsatInletCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtTsatInletCase2.Location = New System.Drawing.Point(282, 324)
        Me.txtTsatInletCase2.Name = "txtTsatInletCase2"
        Me.txtTsatInletCase2.ReadOnly = True
        Me.txtTsatInletCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtTsatInletCase2.TabIndex = 42
        Me.txtTsatInletCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTsatInletCase1
        '
        Me.txtTsatInletCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTsatInletCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtTsatInletCase1.Location = New System.Drawing.Point(215, 325)
        Me.txtTsatInletCase1.Name = "txtTsatInletCase1"
        Me.txtTsatInletCase1.ReadOnly = True
        Me.txtTsatInletCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtTsatInletCase1.TabIndex = 41
        Me.txtTsatInletCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTsatInletPress
        '
        Me.lblTsatInletPress.AutoSize = True
        Me.lblTsatInletPress.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTsatInletPress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTsatInletPress.Location = New System.Drawing.Point(16, 325)
        Me.lblTsatInletPress.Name = "lblTsatInletPress"
        Me.lblTsatInletPress.Size = New System.Drawing.Size(79, 13)
        Me.lblTsatInletPress.TabIndex = 41
        Me.lblTsatInletPress.Text = "Tsat at InletPr."
        '
        'lblMolecularUnit
        '
        Me.lblMolecularUnit.AutoSize = True
        Me.lblMolecularUnit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMolecularUnit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMolecularUnit.Location = New System.Drawing.Point(118, 322)
        Me.lblMolecularUnit.Name = "lblMolecularUnit"
        Me.lblMolecularUnit.Size = New System.Drawing.Size(37, 13)
        Me.lblMolecularUnit.TabIndex = 42
        Me.lblMolecularUnit.Text = "g/mol"
        '
        'chkViscosity
        '
        Me.chkViscosity.AutoSize = True
        Me.chkViscosity.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkViscosity.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViscosity.Location = New System.Drawing.Point(17, 299)
        Me.chkViscosity.Name = "chkViscosity"
        Me.chkViscosity.Size = New System.Drawing.Size(82, 17)
        Me.chkViscosity.TabIndex = 34
        Me.chkViscosity.Text = "Viscosity    "
        Me.chkViscosity.UseVisualStyleBackColor = True
        Me.chkViscosity.Visible = False
        '
        'txtViscosityCase1
        '
        Me.txtViscosityCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViscosityCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtViscosityCase1.Location = New System.Drawing.Point(215, 301)
        Me.txtViscosityCase1.Name = "txtViscosityCase1"
        Me.txtViscosityCase1.ReadOnly = True
        Me.txtViscosityCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtViscosityCase1.TabIndex = 36
        Me.txtViscosityCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtViscosityCase2
        '
        Me.txtViscosityCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViscosityCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtViscosityCase2.Location = New System.Drawing.Point(283, 300)
        Me.txtViscosityCase2.Name = "txtViscosityCase2"
        Me.txtViscosityCase2.ReadOnly = True
        Me.txtViscosityCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtViscosityCase2.TabIndex = 37
        Me.txtViscosityCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtViscosityCase3
        '
        Me.txtViscosityCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViscosityCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtViscosityCase3.Location = New System.Drawing.Point(351, 300)
        Me.txtViscosityCase3.Name = "txtViscosityCase3"
        Me.txtViscosityCase3.ReadOnly = True
        Me.txtViscosityCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtViscosityCase3.TabIndex = 38
        Me.txtViscosityCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbViscosityUnits
        '
        Me.cmbViscosityUnits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbViscosityUnits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cmbViscosityUnits.FormattingEnabled = True
        Me.cmbViscosityUnits.Location = New System.Drawing.Point(118, 298)
        Me.cmbViscosityUnits.Name = "cmbViscosityUnits"
        Me.cmbViscosityUnits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbViscosityUnits.Size = New System.Drawing.Size(80, 21)
        Me.cmbViscosityUnits.TabIndex = 35
        Me.cmbViscosityUnits.Text = "--Select--"
        '
        'txtTsatoutPressureCase3
        '
        Me.txtTsatoutPressureCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTsatoutPressureCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtTsatoutPressureCase3.Location = New System.Drawing.Point(351, 348)
        Me.txtTsatoutPressureCase3.Name = "txtTsatoutPressureCase3"
        Me.txtTsatoutPressureCase3.ReadOnly = True
        Me.txtTsatoutPressureCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtTsatoutPressureCase3.TabIndex = 46
        Me.txtTsatoutPressureCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTsatoutPressureCase3.Visible = False
        '
        'txtTsatoutPressureCase2
        '
        Me.txtTsatoutPressureCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTsatoutPressureCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtTsatoutPressureCase2.Location = New System.Drawing.Point(283, 348)
        Me.txtTsatoutPressureCase2.Name = "txtTsatoutPressureCase2"
        Me.txtTsatoutPressureCase2.ReadOnly = True
        Me.txtTsatoutPressureCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtTsatoutPressureCase2.TabIndex = 45
        Me.txtTsatoutPressureCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTsatoutPressureCase2.Visible = False
        '
        'txtTsatoutPressureCase1
        '
        Me.txtTsatoutPressureCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTsatoutPressureCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtTsatoutPressureCase1.Location = New System.Drawing.Point(215, 349)
        Me.txtTsatoutPressureCase1.Name = "txtTsatoutPressureCase1"
        Me.txtTsatoutPressureCase1.ReadOnly = True
        Me.txtTsatoutPressureCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtTsatoutPressureCase1.TabIndex = 44
        Me.txtTsatoutPressureCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTsatoutPressureCase1.Visible = False
        '
        'lblTsatoutPressure
        '
        Me.lblTsatoutPressure.AutoSize = True
        Me.lblTsatoutPressure.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTsatoutPressure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTsatoutPressure.Location = New System.Drawing.Point(18, 349)
        Me.lblTsatoutPressure.Name = "lblTsatoutPressure"
        Me.lblTsatoutPressure.Size = New System.Drawing.Size(105, 13)
        Me.lblTsatoutPressure.TabIndex = 359
        Me.lblTsatoutPressure.Text = "Tsat at OutletPress."
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label64.Location = New System.Drawing.Point(14, 109)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(32, 15)
        Me.Label64.TabIndex = 355
        Me.Label64.Text = "Flow"
        '
        'cmbQW
        '
        Me.cmbQW.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbQW.FormattingEnabled = True
        Me.cmbQW.Location = New System.Drawing.Point(53, 109)
        Me.cmbQW.Name = "cmbQW"
        Me.cmbQW.Size = New System.Drawing.Size(50, 21)
        Me.cmbQW.TabIndex = 2
        Me.cmbQW.Text = "Q"
        '
        'cmbFlowrate
        '
        Me.cmbFlowrate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFlowrate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cmbFlowrate.FormattingEnabled = True
        Me.cmbFlowrate.Location = New System.Drawing.Point(115, 109)
        Me.cmbFlowrate.Name = "cmbFlowrate"
        Me.cmbFlowrate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbFlowrate.Size = New System.Drawing.Size(80, 21)
        Me.cmbFlowrate.TabIndex = 3
        Me.cmbFlowrate.Text = "--Select--"
        '
        'txtFlowrateCase1
        '
        Me.txtFlowrateCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlowrateCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtFlowrateCase1.Location = New System.Drawing.Point(215, 109)
        Me.txtFlowrateCase1.Name = "txtFlowrateCase1"
        Me.txtFlowrateCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtFlowrateCase1.TabIndex = 4
        Me.txtFlowrateCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFlowrateCase2
        '
        Me.txtFlowrateCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlowrateCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtFlowrateCase2.Location = New System.Drawing.Point(283, 109)
        Me.txtFlowrateCase2.Name = "txtFlowrateCase2"
        Me.txtFlowrateCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtFlowrateCase2.TabIndex = 5
        Me.txtFlowrateCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFlowrateCase3
        '
        Me.txtFlowrateCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlowrateCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtFlowrateCase3.Location = New System.Drawing.Point(351, 109)
        Me.txtFlowrateCase3.Name = "txtFlowrateCase3"
        Me.txtFlowrateCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtFlowrateCase3.TabIndex = 6
        Me.txtFlowrateCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(354, 91)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(43, 13)
        Me.Label36.TabIndex = 352
        Me.Label36.Text = "Case III"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(285, 91)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 13)
        Me.Label31.TabIndex = 351
        Me.Label31.Text = "Case II"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(220, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 350
        Me.Label18.Text = "Case I"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 280
        Me.Label1.Text = "Select Fluid Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 285
        Me.Label3.Text = "Fluid "
        '
        'txtFlashingPercentageCase2
        '
        Me.txtFlashingPercentageCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlashingPercentageCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtFlashingPercentageCase2.Location = New System.Drawing.Point(283, 399)
        Me.txtFlashingPercentageCase2.Name = "txtFlashingPercentageCase2"
        Me.txtFlashingPercentageCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtFlashingPercentageCase2.TabIndex = 53
        Me.txtFlashingPercentageCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFlashingPercentageCase2.Visible = False
        '
        'txtK_Case2
        '
        Me.txtK_Case2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtK_Case2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtK_Case2.Location = New System.Drawing.Point(282, 398)
        Me.txtK_Case2.Name = "txtK_Case2"
        Me.txtK_Case2.Size = New System.Drawing.Size(50, 22)
        Me.txtK_Case2.TabIndex = 54
        Me.txtK_Case2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFlashingPercentageCase1
        '
        Me.txtFlashingPercentageCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlashingPercentageCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtFlashingPercentageCase1.Location = New System.Drawing.Point(215, 398)
        Me.txtFlashingPercentageCase1.Name = "txtFlashingPercentageCase1"
        Me.txtFlashingPercentageCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtFlashingPercentageCase1.TabIndex = 51
        Me.txtFlashingPercentageCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFlashingPercentageCase1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 290
        Me.Label5.Text = "Inlet Press.(P1)"
        '
        'lblFlashingPercentage
        '
        Me.lblFlashingPercentage.AutoSize = True
        Me.lblFlashingPercentage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlashingPercentage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFlashingPercentage.Location = New System.Drawing.Point(14, 399)
        Me.lblFlashingPercentage.Name = "lblFlashingPercentage"
        Me.lblFlashingPercentage.Size = New System.Drawing.Size(43, 13)
        Me.lblFlashingPercentage.TabIndex = 349
        Me.lblFlashingPercentage.Text = "%Flash"
        Me.lblFlashingPercentage.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(14, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 292
        Me.Label6.Text = "Outlet Press.(P2)"
        '
        'cmbPressureUnits
        '
        Me.cmbPressureUnits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPressureUnits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cmbPressureUnits.FormattingEnabled = True
        Me.cmbPressureUnits.ItemHeight = 13
        Me.cmbPressureUnits.Location = New System.Drawing.Point(115, 132)
        Me.cmbPressureUnits.Name = "cmbPressureUnits"
        Me.cmbPressureUnits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbPressureUnits.Size = New System.Drawing.Size(80, 21)
        Me.cmbPressureUnits.TabIndex = 7
        Me.cmbPressureUnits.Text = "--Select--"
        '
        'chkMolecularWeight
        '
        Me.chkMolecularWeight.AutoSize = True
        Me.chkMolecularWeight.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMolecularWeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMolecularWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkMolecularWeight.Location = New System.Drawing.Point(14, 324)
        Me.chkMolecularWeight.Name = "chkMolecularWeight"
        Me.chkMolecularWeight.Size = New System.Drawing.Size(90, 17)
        Me.chkMolecularWeight.TabIndex = 40
        Me.chkMolecularWeight.Text = "Mol. Weight"
        Me.chkMolecularWeight.UseVisualStyleBackColor = True
        Me.chkMolecularWeight.Visible = False
        '
        'txtMolecularWeight
        '
        Me.txtMolecularWeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMolecularWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtMolecularWeight.Location = New System.Drawing.Point(215, 325)
        Me.txtMolecularWeight.Name = "txtMolecularWeight"
        Me.txtMolecularWeight.Size = New System.Drawing.Size(50, 22)
        Me.txtMolecularWeight.TabIndex = 43
        Me.txtMolecularWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMolecularWeight.Visible = False
        '
        'txtInletPressureCase1
        '
        Me.txtInletPressureCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInletPressureCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtInletPressureCase1.Location = New System.Drawing.Point(215, 132)
        Me.txtInletPressureCase1.Name = "txtInletPressureCase1"
        Me.txtInletPressureCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtInletPressureCase1.TabIndex = 8
        Me.txtInletPressureCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSelectP2DP
        '
        Me.btnSelectP2DP.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectP2DP.Location = New System.Drawing.Point(115, 153)
        Me.btnSelectP2DP.Name = "btnSelectP2DP"
        Me.btnSelectP2DP.Size = New System.Drawing.Size(50, 25)
        Me.btnSelectP2DP.TabIndex = 11
        Me.btnSelectP2DP.Text = "Select DP"
        Me.btnSelectP2DP.UseVisualStyleBackColor = False
        '
        'txtInletPressureCase2
        '
        Me.txtInletPressureCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInletPressureCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtInletPressureCase2.Location = New System.Drawing.Point(283, 132)
        Me.txtInletPressureCase2.Name = "txtInletPressureCase2"
        Me.txtInletPressureCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtInletPressureCase2.TabIndex = 9
        Me.txtInletPressureCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtX_Case3
        '
        Me.txtX_Case3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX_Case3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtX_Case3.Location = New System.Drawing.Point(351, 276)
        Me.txtX_Case3.Name = "txtX_Case3"
        Me.txtX_Case3.Size = New System.Drawing.Size(50, 22)
        Me.txtX_Case3.TabIndex = 33
        Me.txtX_Case3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInletPressureCase3
        '
        Me.txtInletPressureCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInletPressureCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtInletPressureCase3.Location = New System.Drawing.Point(351, 132)
        Me.txtInletPressureCase3.Name = "txtInletPressureCase3"
        Me.txtInletPressureCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtInletPressureCase3.TabIndex = 10
        Me.txtInletPressureCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtX_Case1
        '
        Me.txtX_Case1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX_Case1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtX_Case1.Location = New System.Drawing.Point(215, 278)
        Me.txtX_Case1.Name = "txtX_Case1"
        Me.txtX_Case1.Size = New System.Drawing.Size(50, 22)
        Me.txtX_Case1.TabIndex = 31
        Me.txtX_Case1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOutletPressure1
        '
        Me.txtOutletPressure1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutletPressure1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtOutletPressure1.Location = New System.Drawing.Point(215, 153)
        Me.txtOutletPressure1.Name = "txtOutletPressure1"
        Me.txtOutletPressure1.Size = New System.Drawing.Size(50, 22)
        Me.txtOutletPressure1.TabIndex = 12
        Me.txtOutletPressure1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtX_Case2
        '
        Me.txtX_Case2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX_Case2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtX_Case2.Location = New System.Drawing.Point(283, 276)
        Me.txtX_Case2.Name = "txtX_Case2"
        Me.txtX_Case2.Size = New System.Drawing.Size(50, 22)
        Me.txtX_Case2.TabIndex = 32
        Me.txtX_Case2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOutletPressure2
        '
        Me.txtOutletPressure2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutletPressure2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtOutletPressure2.Location = New System.Drawing.Point(283, 153)
        Me.txtOutletPressure2.Name = "txtOutletPressure2"
        Me.txtOutletPressure2.Size = New System.Drawing.Size(50, 22)
        Me.txtOutletPressure2.TabIndex = 13
        Me.txtOutletPressure2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblX.Location = New System.Drawing.Point(14, 279)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(89, 13)
        Me.lblX.TabIndex = 348
        Me.lblX.Text = "Pressure Ratio X"
        '
        'txtOutletPressure3
        '
        Me.txtOutletPressure3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutletPressure3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtOutletPressure3.Location = New System.Drawing.Point(351, 153)
        Me.txtOutletPressure3.Name = "txtOutletPressure3"
        Me.txtOutletPressure3.Size = New System.Drawing.Size(50, 22)
        Me.txtOutletPressure3.TabIndex = 14
        Me.txtOutletPressure3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtZ_Case3
        '
        Me.txtZ_Case3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZ_Case3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtZ_Case3.Location = New System.Drawing.Point(351, 250)
        Me.txtZ_Case3.Name = "txtZ_Case3"
        Me.txtZ_Case3.Size = New System.Drawing.Size(50, 22)
        Me.txtZ_Case3.TabIndex = 29
        Me.txtZ_Case3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 307
        Me.Label7.Text = "Press. Drop"
        '
        'txtZ_Case2
        '
        Me.txtZ_Case2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZ_Case2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtZ_Case2.Location = New System.Drawing.Point(282, 251)
        Me.txtZ_Case2.Name = "txtZ_Case2"
        Me.txtZ_Case2.Size = New System.Drawing.Size(50, 22)
        Me.txtZ_Case2.TabIndex = 28
        Me.txtZ_Case2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPressureDropCase1
        '
        Me.txtPressureDropCase1.BackColor = System.Drawing.SystemColors.Control
        Me.txtPressureDropCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPressureDropCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtPressureDropCase1.Location = New System.Drawing.Point(215, 175)
        Me.txtPressureDropCase1.Name = "txtPressureDropCase1"
        Me.txtPressureDropCase1.ReadOnly = True
        Me.txtPressureDropCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtPressureDropCase1.TabIndex = 15
        Me.txtPressureDropCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtZ_Case1
        '
        Me.txtZ_Case1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZ_Case1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtZ_Case1.Location = New System.Drawing.Point(215, 251)
        Me.txtZ_Case1.Name = "txtZ_Case1"
        Me.txtZ_Case1.Size = New System.Drawing.Size(50, 22)
        Me.txtZ_Case1.TabIndex = 27
        Me.txtZ_Case1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPressureDropCase2
        '
        Me.txtPressureDropCase2.BackColor = System.Drawing.SystemColors.Control
        Me.txtPressureDropCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPressureDropCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtPressureDropCase2.Location = New System.Drawing.Point(283, 175)
        Me.txtPressureDropCase2.Name = "txtPressureDropCase2"
        Me.txtPressureDropCase2.ReadOnly = True
        Me.txtPressureDropCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtPressureDropCase2.TabIndex = 16
        Me.txtPressureDropCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblZ
        '
        Me.lblZ.AutoSize = True
        Me.lblZ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblZ.Location = New System.Drawing.Point(14, 256)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(94, 13)
        Me.lblZ.TabIndex = 347
        Me.lblZ.Text = "Compressibility Z"
        '
        'txtPressureDropCase3
        '
        Me.txtPressureDropCase3.BackColor = System.Drawing.SystemColors.Control
        Me.txtPressureDropCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPressureDropCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtPressureDropCase3.Location = New System.Drawing.Point(351, 175)
        Me.txtPressureDropCase3.Name = "txtPressureDropCase3"
        Me.txtPressureDropCase3.ReadOnly = True
        Me.txtPressureDropCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtPressureDropCase3.TabIndex = 17
        Me.txtPressureDropCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtK_Case3
        '
        Me.txtK_Case3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtK_Case3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtK_Case3.Location = New System.Drawing.Point(351, 397)
        Me.txtK_Case3.Name = "txtK_Case3"
        Me.txtK_Case3.Size = New System.Drawing.Size(50, 22)
        Me.txtK_Case3.TabIndex = 56
        Me.txtK_Case3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 313
        Me.Label8.Text = "Inlet Temp.(T1)"
        '
        'cmbTemperatureUnits
        '
        Me.cmbTemperatureUnits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTemperatureUnits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cmbTemperatureUnits.FormattingEnabled = True
        Me.cmbTemperatureUnits.ItemHeight = 13
        Me.cmbTemperatureUnits.Location = New System.Drawing.Point(118, 199)
        Me.cmbTemperatureUnits.Name = "cmbTemperatureUnits"
        Me.cmbTemperatureUnits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTemperatureUnits.Size = New System.Drawing.Size(80, 21)
        Me.cmbTemperatureUnits.TabIndex = 18
        Me.cmbTemperatureUnits.Text = "--Select--"
        '
        'txtK_Case1
        '
        Me.txtK_Case1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtK_Case1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtK_Case1.Location = New System.Drawing.Point(216, 399)
        Me.txtK_Case1.Name = "txtK_Case1"
        Me.txtK_Case1.Size = New System.Drawing.Size(50, 22)
        Me.txtK_Case1.TabIndex = 52
        Me.txtK_Case1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInletTemperatureCase1
        '
        Me.txtInletTemperatureCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInletTemperatureCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtInletTemperatureCase1.Location = New System.Drawing.Point(215, 198)
        Me.txtInletTemperatureCase1.Name = "txtInletTemperatureCase1"
        Me.txtInletTemperatureCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtInletTemperatureCase1.TabIndex = 19
        Me.txtInletTemperatureCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInletTemperatureCase2
        '
        Me.txtInletTemperatureCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInletTemperatureCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtInletTemperatureCase2.Location = New System.Drawing.Point(283, 198)
        Me.txtInletTemperatureCase2.Name = "txtInletTemperatureCase2"
        Me.txtInletTemperatureCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtInletTemperatureCase2.TabIndex = 20
        Me.txtInletTemperatureCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInletTemperatureCase3
        '
        Me.txtInletTemperatureCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInletTemperatureCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtInletTemperatureCase3.Location = New System.Drawing.Point(351, 198)
        Me.txtInletTemperatureCase3.Name = "txtInletTemperatureCase3"
        Me.txtInletTemperatureCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtInletTemperatureCase3.TabIndex = 21
        Me.txtInletTemperatureCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDensity
        '
        Me.lblDensity.AutoSize = True
        Me.lblDensity.BackColor = System.Drawing.Color.Transparent
        Me.lblDensity.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDensity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDensity.Location = New System.Drawing.Point(14, 227)
        Me.lblDensity.Name = "lblDensity"
        Me.lblDensity.Size = New System.Drawing.Size(45, 13)
        Me.lblDensity.TabIndex = 318
        Me.lblDensity.Text = "Density"
        '
        'cmbDensityUnits
        '
        Me.cmbDensityUnits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDensityUnits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cmbDensityUnits.FormattingEnabled = True
        Me.cmbDensityUnits.Location = New System.Drawing.Point(118, 223)
        Me.cmbDensityUnits.Name = "cmbDensityUnits"
        Me.cmbDensityUnits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDensityUnits.Size = New System.Drawing.Size(80, 21)
        Me.cmbDensityUnits.TabIndex = 22
        Me.cmbDensityUnits.Text = "--Select--"
        '
        'txtDensityCase1
        '
        Me.txtDensityCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDensityCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtDensityCase1.Location = New System.Drawing.Point(215, 223)
        Me.txtDensityCase1.Name = "txtDensityCase1"
        Me.txtDensityCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtDensityCase1.TabIndex = 23
        Me.txtDensityCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDensityCase2
        '
        Me.txtDensityCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDensityCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtDensityCase2.Location = New System.Drawing.Point(283, 223)
        Me.txtDensityCase2.Name = "txtDensityCase2"
        Me.txtDensityCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtDensityCase2.TabIndex = 24
        Me.txtDensityCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDensityCase3
        '
        Me.txtDensityCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDensityCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtDensityCase3.Location = New System.Drawing.Point(351, 223)
        Me.txtDensityCase3.Name = "txtDensityCase3"
        Me.txtDensityCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtDensityCase3.TabIndex = 25
        Me.txtDensityCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCriticalPressure
        '
        Me.lblCriticalPressure.AutoSize = True
        Me.lblCriticalPressure.BackColor = System.Drawing.Color.Transparent
        Me.lblCriticalPressure.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriticalPressure.Location = New System.Drawing.Point(15, 254)
        Me.lblCriticalPressure.Name = "lblCriticalPressure"
        Me.lblCriticalPressure.Size = New System.Drawing.Size(74, 13)
        Me.lblCriticalPressure.TabIndex = 331
        Me.lblCriticalPressure.Text = "Critical Press."
        '
        'lblK
        '
        Me.lblK.AutoSize = True
        Me.lblK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblK.Location = New System.Drawing.Point(14, 399)
        Me.lblK.Name = "lblK"
        Me.lblK.Size = New System.Drawing.Size(123, 13)
        Me.lblK.TabIndex = 346
        Me.lblK.Text = "Isentropic Expansion K"
        '
        'lblVapourPressure
        '
        Me.lblVapourPressure.AutoSize = True
        Me.lblVapourPressure.BackColor = System.Drawing.Color.Transparent
        Me.lblVapourPressure.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVapourPressure.Location = New System.Drawing.Point(14, 278)
        Me.lblVapourPressure.Name = "lblVapourPressure"
        Me.lblVapourPressure.Size = New System.Drawing.Size(76, 13)
        Me.lblVapourPressure.TabIndex = 332
        Me.lblVapourPressure.Text = "Vapour Press."
        '
        'txtCriticalPressureCase1
        '
        Me.txtCriticalPressureCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriticalPressureCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtCriticalPressureCase1.Location = New System.Drawing.Point(215, 251)
        Me.txtCriticalPressureCase1.Name = "txtCriticalPressureCase1"
        Me.txtCriticalPressureCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtCriticalPressureCase1.TabIndex = 26
        Me.txtCriticalPressureCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCriticalPressureCase2
        '
        Me.txtCriticalPressureCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriticalPressureCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtCriticalPressureCase2.Location = New System.Drawing.Point(282, 251)
        Me.txtCriticalPressureCase2.Name = "txtCriticalPressureCase2"
        Me.txtCriticalPressureCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtCriticalPressureCase2.TabIndex = 28
        Me.txtCriticalPressureCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCriticalPressureCase3
        '
        Me.txtCriticalPressureCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriticalPressureCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtCriticalPressureCase3.Location = New System.Drawing.Point(351, 251)
        Me.txtCriticalPressureCase3.Name = "txtCriticalPressureCase3"
        Me.txtCriticalPressureCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtCriticalPressureCase3.TabIndex = 30
        Me.txtCriticalPressureCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVapourPressureCase1
        '
        Me.txtVapourPressureCase1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVapourPressureCase1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtVapourPressureCase1.Location = New System.Drawing.Point(215, 278)
        Me.txtVapourPressureCase1.Name = "txtVapourPressureCase1"
        Me.txtVapourPressureCase1.Size = New System.Drawing.Size(50, 22)
        Me.txtVapourPressureCase1.TabIndex = 32
        Me.txtVapourPressureCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVapourPressureCase2
        '
        Me.txtVapourPressureCase2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVapourPressureCase2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtVapourPressureCase2.Location = New System.Drawing.Point(282, 276)
        Me.txtVapourPressureCase2.Name = "txtVapourPressureCase2"
        Me.txtVapourPressureCase2.Size = New System.Drawing.Size(50, 22)
        Me.txtVapourPressureCase2.TabIndex = 34
        Me.txtVapourPressureCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVapourPressureCase3
        '
        Me.txtVapourPressureCase3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVapourPressureCase3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtVapourPressureCase3.Location = New System.Drawing.Point(351, 275)
        Me.txtVapourPressureCase3.Name = "txtVapourPressureCase3"
        Me.txtVapourPressureCase3.Size = New System.Drawing.Size(50, 22)
        Me.txtVapourPressureCase3.TabIndex = 36
        Me.txtVapourPressureCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCriticalPressureUnit
        '
        Me.lblCriticalPressureUnit.AutoSize = True
        Me.lblCriticalPressureUnit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriticalPressureUnit.Location = New System.Drawing.Point(109, 255)
        Me.lblCriticalPressureUnit.Name = "lblCriticalPressureUnit"
        Me.lblCriticalPressureUnit.Size = New System.Drawing.Size(0, 13)
        Me.lblCriticalPressureUnit.TabIndex = 25
        '
        'lblVapourPressureUnit
        '
        Me.lblVapourPressureUnit.AutoSize = True
        Me.lblVapourPressureUnit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVapourPressureUnit.Location = New System.Drawing.Point(108, 275)
        Me.lblVapourPressureUnit.Name = "lblVapourPressureUnit"
        Me.lblVapourPressureUnit.Size = New System.Drawing.Size(0, 13)
        Me.lblVapourPressureUnit.TabIndex = 30
        '
        'cmbCriticalPressureUnits
        '
        Me.cmbCriticalPressureUnits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCriticalPressureUnits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cmbCriticalPressureUnits.FormattingEnabled = True
        Me.cmbCriticalPressureUnits.Location = New System.Drawing.Point(118, 250)
        Me.cmbCriticalPressureUnits.Name = "cmbCriticalPressureUnits"
        Me.cmbCriticalPressureUnits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCriticalPressureUnits.Size = New System.Drawing.Size(80, 21)
        Me.cmbCriticalPressureUnits.TabIndex = 26
        Me.cmbCriticalPressureUnits.Text = "--Select--"
        '
        'cmbVapourPressureUnits
        '
        Me.cmbVapourPressureUnits.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVapourPressureUnits.FormattingEnabled = True
        Me.cmbVapourPressureUnits.Location = New System.Drawing.Point(118, 274)
        Me.cmbVapourPressureUnits.Name = "cmbVapourPressureUnits"
        Me.cmbVapourPressureUnits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbVapourPressureUnits.Size = New System.Drawing.Size(80, 21)
        Me.cmbVapourPressureUnits.TabIndex = 30
        Me.cmbVapourPressureUnits.Text = "--Select--"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label72)
        Me.Panel5.Controls.Add(Me.cmbModel)
        Me.Panel5.Controls.Add(Me.cmbUnitsType)
        Me.Panel5.Controls.Add(Me.Label69)
        Me.Panel5.Controls.Add(Me.cmbFluidType)
        Me.Panel5.Controls.Add(Me.cmbFluid)
        Me.Panel5.Location = New System.Drawing.Point(13, 20)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(391, 59)
        Me.Panel5.TabIndex = 0
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.White
        Me.Label72.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Black
        Me.Label72.Location = New System.Drawing.Point(234, 37)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(40, 13)
        Me.Label72.TabIndex = 354
        Me.Label72.Text = "Model"
        '
        'cmbModel
        '
        Me.cmbModel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(279, 34)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(106, 21)
        Me.cmbModel.TabIndex = 3
        Me.cmbModel.Text = "--Select--"
        '
        'cmbUnitsType
        '
        Me.cmbUnitsType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitsType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbUnitsType.FormattingEnabled = True
        Me.cmbUnitsType.Location = New System.Drawing.Point(279, 11)
        Me.cmbUnitsType.Name = "cmbUnitsType"
        Me.cmbUnitsType.Size = New System.Drawing.Size(106, 21)
        Me.cmbUnitsType.TabIndex = 1
        Me.cmbUnitsType.Text = "--Select--"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.White
        Me.Label69.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Black
        Me.Label69.Location = New System.Drawing.Point(220, 14)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(59, 13)
        Me.Label69.TabIndex = 353
        Me.Label69.Text = "Units type"
        '
        'cmbFluidType
        '
        Me.cmbFluidType.BackColor = System.Drawing.Color.White
        Me.cmbFluidType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFluidType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbFluidType.FormattingEnabled = True
        Me.cmbFluidType.Location = New System.Drawing.Point(99, 11)
        Me.cmbFluidType.Name = "cmbFluidType"
        Me.cmbFluidType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbFluidType.Size = New System.Drawing.Size(121, 21)
        Me.cmbFluidType.TabIndex = 0
        Me.cmbFluidType.Text = "--Select--"
        '
        'cmbFluid
        '
        Me.cmbFluid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFluid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbFluid.FormattingEnabled = True
        Me.cmbFluid.Location = New System.Drawing.Point(99, 32)
        Me.cmbFluid.Name = "cmbFluid"
        Me.cmbFluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbFluid.Size = New System.Drawing.Size(121, 21)
        Me.cmbFluid.TabIndex = 2
        Me.cmbFluid.Text = "--Select--"
        '
        'lblViscosity
        '
        Me.lblViscosity.AutoSize = True
        Me.lblViscosity.BackColor = System.Drawing.Color.Transparent
        Me.lblViscosity.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViscosity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblViscosity.Location = New System.Drawing.Point(21, 301)
        Me.lblViscosity.Name = "lblViscosity"
        Me.lblViscosity.Size = New System.Drawing.Size(51, 13)
        Me.lblViscosity.TabIndex = 371
        Me.lblViscosity.Text = "Viscosity"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = Global.FMValveApplication_standard.My.Resources.Resources.Base_frame1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.lblMicroTrim)
        Me.Panel2.Controls.Add(Me.lblFinalValveSize)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.cmbSelectedTrim)
        Me.Panel2.Controls.Add(Me.txtSuggTrim)
        Me.Panel2.Controls.Add(Me.cmbFlowDirection)
        Me.Panel2.Controls.Add(Me.Label73)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.cmbVelocityRule)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.cmbKVseries)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.cmbCharacterstics)
        Me.Panel2.Controls.Add(Me.lblValveModel)
        Me.Panel2.Controls.Add(Me.Label83)
        Me.Panel2.Controls.Add(Me.Label80)
        Me.Panel2.Controls.Add(Me.Label79)
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.Label66)
        Me.Panel2.Controls.Add(Me.Label65)
        Me.Panel2.Controls.Add(Me.lblSuggestedRating)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.cmbEndConnection)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label77)
        Me.Panel2.Controls.Add(Me.cmbInletPipeSchedule)
        Me.Panel2.Controls.Add(Me.cmbBonnetType)
        Me.Panel2.Controls.Add(Me.lblKVMaxValue)
        Me.Panel2.Controls.Add(Me.Label78)
        Me.Panel2.Controls.Add(Me.lblFinalOutletPipe)
        Me.Panel2.Controls.Add(Me.btnAcceptVelocityRule)
        Me.Panel2.Controls.Add(Me.btnKVAccept)
        Me.Panel2.Controls.Add(Me.btnOverrideRating)
        Me.Panel2.Controls.Add(Me.btnValveSizeAccept)
        Me.Panel2.Controls.Add(Me.lblSelectedCV)
        Me.Panel2.Controls.Add(Me.lblSelectedKV)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Controls.Add(Me.lblSuggPipeSize)
        Me.Panel2.Controls.Add(Me.Label63)
        Me.Panel2.Controls.Add(Me.lblCalculating)
        Me.Panel2.Controls.Add(Me.lblFinalRating)
        Me.Panel2.Controls.Add(Me.lblCvSelected)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.lblCVSugg)
        Me.Panel2.Controls.Add(Me.cmbSuggestedRating)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.cmbAreaunits)
        Me.Panel2.Controls.Add(Me.lblDesignPressure)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.lblKvSelected)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txt_CustomerMain)
        Me.Panel2.Controls.Add(Me.lblDesignTemperature)
        Me.Panel2.Controls.Add(Me.cmbPipeDia)
        Me.Panel2.Controls.Add(Me.txtDesignTemperatureInlet)
        Me.Panel2.Controls.Add(Me.lblKvSugg)
        Me.Panel2.Controls.Add(Me.cmbSchedule)
        Me.Panel2.Controls.Add(Me.txtSuggestedKV)
        Me.Panel2.Controls.Add(Me.cmbMOC)
        Me.Panel2.Controls.Add(Me.cmbKVOverride)
        Me.Panel2.Controls.Add(Me.Label38)
        Me.Panel2.Controls.Add(Me.cmbValveSizeOverride)
        Me.Panel2.Controls.Add(Me.txtDesignPressureInlet)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.cmbInletPipeSize)
        Me.Panel2.Controls.Add(Me.txtSuggestedValveSize)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label67)
        Me.Panel2.Location = New System.Drawing.Point(514, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 426)
        Me.Panel2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(188, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 25)
        Me.Button2.TabIndex = 394
        Me.Button2.Text = "Accept"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'lblMicroTrim
        '
        Me.lblMicroTrim.AutoSize = True
        Me.lblMicroTrim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMicroTrim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMicroTrim.Location = New System.Drawing.Point(198, 293)
        Me.lblMicroTrim.Name = "lblMicroTrim"
        Me.lblMicroTrim.Size = New System.Drawing.Size(10, 13)
        Me.lblMicroTrim.TabIndex = 393
        Me.lblMicroTrim.Text = "."
        '
        'lblFinalValveSize
        '
        Me.lblFinalValveSize.AutoSize = True
        Me.lblFinalValveSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalValveSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblFinalValveSize.Location = New System.Drawing.Point(326, 368)
        Me.lblFinalValveSize.Name = "lblFinalValveSize"
        Me.lblFinalValveSize.Size = New System.Drawing.Size(19, 13)
        Me.lblFinalValveSize.TabIndex = 392
        Me.lblFinalValveSize.Text = "99"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(240, 293)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 13)
        Me.Label26.TabIndex = 391
        Me.Label26.Text = "Selected"
        '
        'cmbSelectedTrim
        '
        Me.cmbSelectedTrim.FormattingEnabled = True
        Me.cmbSelectedTrim.Location = New System.Drawing.Point(322, 289)
        Me.cmbSelectedTrim.Name = "cmbSelectedTrim"
        Me.cmbSelectedTrim.Size = New System.Drawing.Size(80, 21)
        Me.cmbSelectedTrim.TabIndex = 72
        '
        'txtSuggTrim
        '
        Me.txtSuggTrim.Location = New System.Drawing.Point(118, 288)
        Me.txtSuggTrim.Name = "txtSuggTrim"
        Me.txtSuggTrim.ReadOnly = True
        Me.txtSuggTrim.Size = New System.Drawing.Size(53, 22)
        Me.txtSuggTrim.TabIndex = 389
        Me.txtSuggTrim.TabStop = False
        '
        'cmbFlowDirection
        '
        Me.cmbFlowDirection.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFlowDirection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbFlowDirection.FormattingEnabled = True
        Me.cmbFlowDirection.Location = New System.Drawing.Point(322, 240)
        Me.cmbFlowDirection.Name = "cmbFlowDirection"
        Me.cmbFlowDirection.Size = New System.Drawing.Size(77, 21)
        Me.cmbFlowDirection.TabIndex = 69
        Me.cmbFlowDirection.Tag = ""
        Me.cmbFlowDirection.Text = "FTO"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label73.Location = New System.Drawing.Point(244, 240)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(53, 13)
        Me.Label73.TabIndex = 388
        Me.Label73.Text = "Flow Dir."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(38, 244)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 13)
        Me.Label20.TabIndex = 387
        Me.Label20.Text = "Vel. /Mach #"
        '
        'cmbVelocityRule
        '
        Me.cmbVelocityRule.Enabled = False
        Me.cmbVelocityRule.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVelocityRule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbVelocityRule.FormattingEnabled = True
        Me.cmbVelocityRule.Location = New System.Drawing.Point(118, 240)
        Me.cmbVelocityRule.Name = "cmbVelocityRule"
        Me.cmbVelocityRule.Size = New System.Drawing.Size(80, 21)
        Me.cmbVelocityRule.TabIndex = 68
        Me.cmbVelocityRule.Text = "--Select--"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(233, 267)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 385
        Me.Label23.Text = "Stroke Limit"
        '
        'cmbKVseries
        '
        Me.cmbKVseries.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbKVseries.Enabled = False
        Me.cmbKVseries.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKVseries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbKVseries.FormattingEnabled = True
        Me.cmbKVseries.Location = New System.Drawing.Point(322, 264)
        Me.cmbKVseries.Name = "cmbKVseries"
        Me.cmbKVseries.Size = New System.Drawing.Size(77, 21)
        Me.cmbKVseries.TabIndex = 71
        Me.cmbKVseries.Text = "--Select--"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(38, 268)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 13)
        Me.Label24.TabIndex = 386
        Me.Label24.Text = "Characterstics"
        '
        'cmbCharacterstics
        '
        Me.cmbCharacterstics.Enabled = False
        Me.cmbCharacterstics.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCharacterstics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cmbCharacterstics.FormattingEnabled = True
        Me.cmbCharacterstics.Location = New System.Drawing.Point(118, 264)
        Me.cmbCharacterstics.Name = "cmbCharacterstics"
        Me.cmbCharacterstics.Size = New System.Drawing.Size(80, 21)
        Me.cmbCharacterstics.TabIndex = 70
        Me.cmbCharacterstics.Text = "--Select--"
        '
        'lblValveModel
        '
        Me.lblValveModel.AutoSize = True
        Me.lblValveModel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValveModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.lblValveModel.Location = New System.Drawing.Point(124, 202)
        Me.lblValveModel.Name = "lblValveModel"
        Me.lblValveModel.Size = New System.Drawing.Size(31, 13)
        Me.lblValveModel.TabIndex = 380
        Me.lblValveModel.Text = "1100"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label83.Location = New System.Drawing.Point(48, 201)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(40, 13)
        Me.Label83.TabIndex = 379
        Me.Label83.Text = "Model"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label80.Location = New System.Drawing.Point(247, 203)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(50, 13)
        Me.Label80.TabIndex = 378
        Me.Label80.Text = "Selected"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label79.Location = New System.Drawing.Point(242, 85)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(50, 13)
        Me.Label79.TabIndex = 377
        Me.Label79.Text = "Selected"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(325, 84)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(14, 13)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "#"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label66.Location = New System.Drawing.Point(15, 103)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(356, 15)
        Me.Label66.TabIndex = 374
        Me.Label66.Text = "Pipe_________________________________________________________________"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label65.Location = New System.Drawing.Point(4, 7)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(367, 15)
        Me.Label65.TabIndex = 4
        Me.Label65.Text = "Rating Class___________________________________________________________"
        '
        'btnOverrideRating
        '
        Me.btnOverrideRating.FlatAppearance.BorderSize = 0
        Me.btnOverrideRating.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnOverrideRating.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverrideRating.Location = New System.Drawing.Point(362, 26)
        Me.btnOverrideRating.Name = "btnOverrideRating"
        Me.btnOverrideRating.Size = New System.Drawing.Size(40, 25)
        Me.btnOverrideRating.TabIndex = 78
        Me.btnOverrideRating.Text = "Accept"
        Me.btnOverrideRating.UseVisualStyleBackColor = False
        Me.btnOverrideRating.Visible = False
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label67.Location = New System.Drawing.Point(13, 219)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(358, 15)
        Me.Label67.TabIndex = 375
        Me.Label67.Text = "Valve Size___________________________________________________________"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImage = Global.FMValveApplication_standard.My.Resources.Resources.Base_frame1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Controls.Add(Me.btnAcceptActuator)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnChart)
        Me.Panel3.Controls.Add(Me.cmbSeatDia)
        Me.Panel3.Controls.Add(Me.btnTables)
        Me.Panel3.Controls.Add(Me.Label55)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label81)
        Me.Panel3.Controls.Add(Me.Label68)
        Me.Panel3.Controls.Add(Me.Label71)
        Me.Panel3.Controls.Add(Me.lblFinalActuator)
        Me.Panel3.Controls.Add(Me.Label48)
        Me.Panel3.Controls.Add(Me.Label46)
        Me.Panel3.Controls.Add(Me.lblSeatDiaUnits)
        Me.Panel3.Controls.Add(Me.cmbAirFailure)
        Me.Panel3.Controls.Add(Me.Label45)
        Me.Panel3.Controls.Add(Me.cmbLeakage)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.cmbBalancing)
        Me.Panel3.Controls.Add(Me.cmbAirPressureUnits)
        Me.Panel3.Controls.Add(Me.Label44)
        Me.Panel3.Controls.Add(Me.lblDPShutoffUnits)
        Me.Panel3.Controls.Add(Me.Label43)
        Me.Panel3.Controls.Add(Me.Label51)
        Me.Panel3.Controls.Add(Me.cmbPacking)
        Me.Panel3.Controls.Add(Me.txtSuggActuator)
        Me.Panel3.Controls.Add(Me.cmbHandwheel)
        Me.Panel3.Controls.Add(Me.Label50)
        Me.Panel3.Controls.Add(Me.Label54)
        Me.Panel3.Controls.Add(Me.cmbSelectActuator)
        Me.Panel3.Controls.Add(Me.txtDPShutoff)
        Me.Panel3.Controls.Add(Me.Label52)
        Me.Panel3.Controls.Add(Me.Label47)
        Me.Panel3.Controls.Add(Me.txtAirPressure)
        Me.Panel3.Controls.Add(Me.cmbSealing)
        Me.Panel3.Controls.Add(Me.cmbActuatorType)
        Me.Panel3.Location = New System.Drawing.Point(935, 83)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(418, 426)
        Me.Panel3.TabIndex = 3
        '
        'btnAcceptActuator
        '
        Me.btnAcceptActuator.FlatAppearance.BorderSize = 0
        Me.btnAcceptActuator.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceptActuator.Location = New System.Drawing.Point(332, 239)
        Me.btnAcceptActuator.Name = "btnAcceptActuator"
        Me.btnAcceptActuator.Size = New System.Drawing.Size(40, 25)
        Me.btnAcceptActuator.TabIndex = 667
        Me.btnAcceptActuator.TabStop = False
        Me.btnAcceptActuator.Text = "Accept"
        Me.btnAcceptActuator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcceptActuator.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = Global.FMValveApplication_standard.My.Resources.Resources.Base_frame
        Me.Panel7.Controls.Add(Me.Label101)
        Me.Panel7.Controls.Add(Me.Label100)
        Me.Panel7.Controls.Add(Me.Label99)
        Me.Panel7.Controls.Add(Me.Label98)
        Me.Panel7.Controls.Add(Me.lblSel100PerF)
        Me.Panel7.Controls.Add(Me.lblSel0PercF)
        Me.Panel7.Controls.Add(Me.Label70)
        Me.Panel7.Controls.Add(Me.lblForce100perc)
        Me.Panel7.Controls.Add(Me.lblForce0perc)
        Me.Panel7.Controls.Add(Me.lblForceUnits)
        Me.Panel7.Location = New System.Drawing.Point(293, 96)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(122, 100)
        Me.Panel7.TabIndex = 392
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.BackColor = System.Drawing.Color.Transparent
        Me.Label101.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label101.Location = New System.Drawing.Point(71, 33)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(44, 14)
        Me.Label101.TabIndex = 397
        Me.Label101.Text = "Selected"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.BackColor = System.Drawing.Color.Transparent
        Me.Label100.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label100.Location = New System.Drawing.Point(36, 33)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(27, 14)
        Me.Label100.TabIndex = 396
        Me.Label100.Text = "Req."
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.BackColor = System.Drawing.Color.Transparent
        Me.Label99.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label99.Location = New System.Drawing.Point(-3, 75)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(44, 14)
        Me.Label99.TabIndex = 395
        Me.Label99.Text = "@100%"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.BackColor = System.Drawing.Color.Transparent
        Me.Label98.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label98.Location = New System.Drawing.Point(-1, 52)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(32, 14)
        Me.Label98.TabIndex = 394
        Me.Label98.Text = "@0%"
        '
        'lblSel100PerF
        '
        Me.lblSel100PerF.AutoSize = True
        Me.lblSel100PerF.BackColor = System.Drawing.Color.Transparent
        Me.lblSel100PerF.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSel100PerF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblSel100PerF.Location = New System.Drawing.Point(81, 76)
        Me.lblSel100PerF.Name = "lblSel100PerF"
        Me.lblSel100PerF.Size = New System.Drawing.Size(37, 13)
        Me.lblSel100PerF.TabIndex = 393
        Me.lblSel100PerF.Text = "99999"
        '
        'lblSel0PercF
        '
        Me.lblSel0PercF.AutoSize = True
        Me.lblSel0PercF.BackColor = System.Drawing.Color.Transparent
        Me.lblSel0PercF.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSel0PercF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblSel0PercF.Location = New System.Drawing.Point(81, 53)
        Me.lblSel0PercF.Name = "lblSel0PercF"
        Me.lblSel0PercF.Size = New System.Drawing.Size(37, 13)
        Me.lblSel0PercF.TabIndex = 392
        Me.lblSel0PercF.Text = "99999"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label70.Location = New System.Drawing.Point(32, 2)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(47, 17)
        Me.Label70.TabIndex = 236
        Me.Label70.Text = "Forces"
        '
        'lblForce100perc
        '
        Me.lblForce100perc.AutoSize = True
        Me.lblForce100perc.BackColor = System.Drawing.Color.Transparent
        Me.lblForce100perc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForce100perc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblForce100perc.Location = New System.Drawing.Point(40, 76)
        Me.lblForce100perc.Name = "lblForce100perc"
        Me.lblForce100perc.Size = New System.Drawing.Size(37, 13)
        Me.lblForce100perc.TabIndex = 391
        Me.lblForce100perc.Text = "99999"
        '
        'lblForce0perc
        '
        Me.lblForce0perc.AutoSize = True
        Me.lblForce0perc.BackColor = System.Drawing.Color.Transparent
        Me.lblForce0perc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForce0perc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblForce0perc.Location = New System.Drawing.Point(40, 53)
        Me.lblForce0perc.Name = "lblForce0perc"
        Me.lblForce0perc.Size = New System.Drawing.Size(37, 13)
        Me.lblForce0perc.TabIndex = 237
        Me.lblForce0perc.Text = "99999"
        '
        'lblForceUnits
        '
        Me.lblForceUnits.AutoSize = True
        Me.lblForceUnits.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForceUnits.Location = New System.Drawing.Point(83, 5)
        Me.lblForceUnits.Name = "lblForceUnits"
        Me.lblForceUnits.Size = New System.Drawing.Size(25, 14)
        Me.lblForceUnits.TabIndex = 242
        Me.lblForceUnits.Text = "unit"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 26)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "ActuatorSelect"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btnChart
        '
        Me.btnChart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChart.Location = New System.Drawing.Point(143, 293)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnChart.Size = New System.Drawing.Size(88, 26)
        Me.btnChart.TabIndex = 14
        Me.btnChart.Text = "Charts"
        Me.btnChart.UseVisualStyleBackColor = True
        '
        'cmbSeatDia
        '
        Me.cmbSeatDia.FormattingEnabled = True
        Me.cmbSeatDia.Location = New System.Drawing.Point(132, 197)
        Me.cmbSeatDia.Name = "cmbSeatDia"
        Me.cmbSeatDia.Size = New System.Drawing.Size(44, 21)
        Me.cmbSeatDia.TabIndex = 10
        '
        'btnTables
        '
        Me.btnTables.Location = New System.Drawing.Point(35, 293)
        Me.btnTables.Name = "btnTables"
        Me.btnTables.Size = New System.Drawing.Size(88, 26)
        Me.btnTables.TabIndex = 13
        Me.btnTables.Text = "Diagnosis"
        Me.btnTables.UseVisualStyleBackColor = True
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label55.Location = New System.Drawing.Point(20, 321)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(336, 15)
        Me.Label55.TabIndex = 12
        Me.Label55.Text = "Baffle___________________________________________________________"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnStop)
        Me.Panel4.Controls.Add(Me.LblCounter)
        Me.Panel4.Controls.Add(Me.Percent3)
        Me.Panel4.Controls.Add(Me.Percent2)
        Me.Panel4.Controls.Add(Me.Percent1)
        Me.Panel4.Controls.Add(Me.ProgBarBaffle)
        Me.Panel4.Controls.Add(Me.lblBaffleCv)
        Me.Panel4.Controls.Add(Me.lblBaffleKV)
        Me.Panel4.Controls.Add(Me.txtBaffleKVCase3)
        Me.Panel4.Controls.Add(Me.txtBaffleKVCase2)
        Me.Panel4.Controls.Add(Me.txtBaffleKVCase1)
        Me.Panel4.Controls.Add(Me.chkBaffleCase3)
        Me.Panel4.Controls.Add(Me.chkBaffleCase2)
        Me.Panel4.Controls.Add(Me.chkBaffleCase1)
        Me.Panel4.Location = New System.Drawing.Point(18, 339)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(367, 79)
        Me.Panel4.TabIndex = 13
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStop.ForeColor = System.Drawing.Color.Black
        Me.btnStop.Location = New System.Drawing.Point(323, 25)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(41, 22)
        Me.btnStop.TabIndex = 121
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'LblCounter
        '
        Me.LblCounter.AutoSize = True
        Me.LblCounter.Location = New System.Drawing.Point(20, 19)
        Me.LblCounter.Name = "LblCounter"
        Me.LblCounter.Size = New System.Drawing.Size(10, 13)
        Me.LblCounter.TabIndex = 120
        Me.LblCounter.Text = "i"
        Me.LblCounter.Visible = False
        '
        'Percent3
        '
        Me.Percent3.AutoSize = True
        Me.Percent3.Location = New System.Drawing.Point(273, 18)
        Me.Percent3.Name = "Percent3"
        Me.Percent3.Size = New System.Drawing.Size(13, 13)
        Me.Percent3.TabIndex = 119
        Me.Percent3.Text = "3"
        Me.Percent3.Visible = False
        '
        'Percent2
        '
        Me.Percent2.AutoSize = True
        Me.Percent2.Location = New System.Drawing.Point(187, 20)
        Me.Percent2.Name = "Percent2"
        Me.Percent2.Size = New System.Drawing.Size(13, 13)
        Me.Percent2.TabIndex = 118
        Me.Percent2.Text = "2"
        Me.Percent2.Visible = False
        '
        'Percent1
        '
        Me.Percent1.AutoSize = True
        Me.Percent1.Location = New System.Drawing.Point(97, 20)
        Me.Percent1.Name = "Percent1"
        Me.Percent1.Size = New System.Drawing.Size(13, 13)
        Me.Percent1.TabIndex = 117
        Me.Percent1.Text = "1"
        Me.Percent1.Visible = False
        '
        'ProgBarBaffle
        '
        Me.ProgBarBaffle.Location = New System.Drawing.Point(4, 62)
        Me.ProgBarBaffle.Name = "ProgBarBaffle"
        Me.ProgBarBaffle.Size = New System.Drawing.Size(334, 13)
        Me.ProgBarBaffle.Step = 500
        Me.ProgBarBaffle.TabIndex = 116
        Me.ProgBarBaffle.Visible = False
        '
        'lblBaffleCv
        '
        Me.lblBaffleCv.AutoSize = True
        Me.lblBaffleCv.Location = New System.Drawing.Point(14, 38)
        Me.lblBaffleCv.Name = "lblBaffleCv"
        Me.lblBaffleCv.Size = New System.Drawing.Size(19, 13)
        Me.lblBaffleCv.TabIndex = 10
        Me.lblBaffleCv.Text = "Cv"
        Me.lblBaffleCv.Visible = False
        '
        'lblBaffleKV
        '
        Me.lblBaffleKV.AutoSize = True
        Me.lblBaffleKV.Location = New System.Drawing.Point(14, 38)
        Me.lblBaffleKV.Name = "lblBaffleKV"
        Me.lblBaffleKV.Size = New System.Drawing.Size(18, 13)
        Me.lblBaffleKV.TabIndex = 9
        Me.lblBaffleKV.Text = "Kv"
        Me.lblBaffleKV.Visible = False
        '
        'txtBaffleKVCase3
        '
        Me.txtBaffleKVCase3.Location = New System.Drawing.Point(229, 34)
        Me.txtBaffleKVCase3.Name = "txtBaffleKVCase3"
        Me.txtBaffleKVCase3.Size = New System.Drawing.Size(44, 22)
        Me.txtBaffleKVCase3.TabIndex = 5
        Me.txtBaffleKVCase3.Visible = False
        '
        'txtBaffleKVCase2
        '
        Me.txtBaffleKVCase2.Location = New System.Drawing.Point(139, 34)
        Me.txtBaffleKVCase2.Name = "txtBaffleKVCase2"
        Me.txtBaffleKVCase2.Size = New System.Drawing.Size(44, 22)
        Me.txtBaffleKVCase2.TabIndex = 4
        Me.txtBaffleKVCase2.Visible = False
        '
        'txtBaffleKVCase1
        '
        Me.txtBaffleKVCase1.Location = New System.Drawing.Point(54, 34)
        Me.txtBaffleKVCase1.Name = "txtBaffleKVCase1"
        Me.txtBaffleKVCase1.Size = New System.Drawing.Size(44, 22)
        Me.txtBaffleKVCase1.TabIndex = 3
        Me.txtBaffleKVCase1.Visible = False
        '
        'chkBaffleCase3
        '
        Me.chkBaffleCase3.AutoSize = True
        Me.chkBaffleCase3.Location = New System.Drawing.Point(231, 6)
        Me.chkBaffleCase3.Name = "chkBaffleCase3"
        Me.chkBaffleCase3.Size = New System.Drawing.Size(38, 17)
        Me.chkBaffleCase3.TabIndex = 2
        Me.chkBaffleCase3.Text = "S3"
        Me.chkBaffleCase3.UseVisualStyleBackColor = True
        '
        'chkBaffleCase2
        '
        Me.chkBaffleCase2.AutoSize = True
        Me.chkBaffleCase2.Location = New System.Drawing.Point(145, 6)
        Me.chkBaffleCase2.Name = "chkBaffleCase2"
        Me.chkBaffleCase2.Size = New System.Drawing.Size(38, 17)
        Me.chkBaffleCase2.TabIndex = 1
        Me.chkBaffleCase2.Text = "S2"
        Me.chkBaffleCase2.UseVisualStyleBackColor = True
        '
        'chkBaffleCase1
        '
        Me.chkBaffleCase1.AutoSize = True
        Me.chkBaffleCase1.Location = New System.Drawing.Point(58, 6)
        Me.chkBaffleCase1.Name = "chkBaffleCase1"
        Me.chkBaffleCase1.Size = New System.Drawing.Size(38, 17)
        Me.chkBaffleCase1.TabIndex = 0
        Me.chkBaffleCase1.Text = "S1"
        Me.chkBaffleCase1.UseVisualStyleBackColor = True
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label81.Location = New System.Drawing.Point(36, 275)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(86, 13)
        Me.Label81.TabIndex = 379
        Me.Label81.Text = "Selected Model"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label68.Location = New System.Drawing.Point(15, 6)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(351, 15)
        Me.Label68.TabIndex = 0
        Me.Label68.Text = "Actuator___________________________________________________________"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label75.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.White
        Me.Label75.Location = New System.Drawing.Point(42, 7)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(28, 15)
        Me.Label75.TabIndex = 322
        Me.Label75.Text = "QTY"
        '
        'lblDatasheetPrinting
        '
        Me.lblDatasheetPrinting.AutoSize = True
        Me.lblDatasheetPrinting.BackColor = System.Drawing.Color.Transparent
        Me.lblDatasheetPrinting.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatasheetPrinting.ForeColor = System.Drawing.Color.Red
        Me.lblDatasheetPrinting.Location = New System.Drawing.Point(781, 67)
        Me.lblDatasheetPrinting.Name = "lblDatasheetPrinting"
        Me.lblDatasheetPrinting.Size = New System.Drawing.Size(78, 17)
        Me.lblDatasheetPrinting.TabIndex = 324
        Me.lblDatasheetPrinting.Text = "Printing ...."
        Me.lblDatasheetPrinting.Visible = False
        '
        'lblPrintRecordNo
        '
        Me.lblPrintRecordNo.AutoSize = True
        Me.lblPrintRecordNo.BackColor = System.Drawing.Color.Transparent
        Me.lblPrintRecordNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintRecordNo.ForeColor = System.Drawing.Color.Red
        Me.lblPrintRecordNo.Location = New System.Drawing.Point(866, 66)
        Me.lblPrintRecordNo.Name = "lblPrintRecordNo"
        Me.lblPrintRecordNo.Size = New System.Drawing.Size(18, 17)
        Me.lblPrintRecordNo.TabIndex = 325
        Me.lblPrintRecordNo.Text = "--"
        Me.lblPrintRecordNo.Visible = False
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.BackColor = System.Drawing.Color.Transparent
        Me.lblFileName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.Location = New System.Drawing.Point(478, 12)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(64, 17)
        Me.lblFileName.TabIndex = 326
        Me.lblFileName.Text = "FileName"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(1105, 65)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(70, 13)
        Me.lblDate.TabIndex = 327
        Me.lblDate.Text = "Created on: "
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(233, 19)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(0, 13)
        Me.lblVersion.TabIndex = 328
        '
        'txtJumpToRecord
        '
        Me.txtJumpToRecord.Location = New System.Drawing.Point(1036, 45)
        Me.txtJumpToRecord.Name = "txtJumpToRecord"
        Me.txtJumpToRecord.Size = New System.Drawing.Size(53, 22)
        Me.txtJumpToRecord.TabIndex = 329
        Me.txtJumpToRecord.TabStop = False
        Me.txtJumpToRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1174, 62)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 22)
        Me.DateTimePicker1.TabIndex = 330
        Me.DateTimePicker1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel6.BackgroundImage = Global.FMValveApplication_standard.My.Resources.Resources.Base_frame
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.txtCustomerRefMain)
        Me.Panel6.Controls.Add(Me.Label90)
        Me.Panel6.Controls.Add(Me.txtRevisionNoMain)
        Me.Panel6.Controls.Add(Me.Label89)
        Me.Panel6.Controls.Add(Me.txtSheetNo)
        Me.Panel6.Controls.Add(Me.Label87)
        Me.Panel6.Controls.Add(Me.txtItemNoMain)
        Me.Panel6.Controls.Add(Me.Label88)
        Me.Panel6.Controls.Add(Me.txtEnggNameMain)
        Me.Panel6.Controls.Add(Me.Label86)
        Me.Panel6.Controls.Add(Me.Label85)
        Me.Panel6.Controls.Add(Me.txtProjectMain)
        Me.Panel6.Controls.Add(Me.txtTagNoMain)
        Me.Panel6.Controls.Add(Me.Label82)
        Me.Panel6.Controls.Add(Me.Label53)
        Me.Panel6.Controls.Add(Me.txtQTYMain)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.txtOfferNoMain)
        Me.Panel6.Controls.Add(Me.txtCustomerMain)
        Me.Panel6.Controls.Add(Me.Label75)
        Me.Panel6.Location = New System.Drawing.Point(12, 86)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(81, 581)
        Me.Panel6.TabIndex = 0
        '
        'txtCustomerRefMain
        '
        Me.txtCustomerRefMain.Location = New System.Drawing.Point(2, 382)
        Me.txtCustomerRefMain.Name = "txtCustomerRefMain"
        Me.txtCustomerRefMain.Size = New System.Drawing.Size(77, 22)
        Me.txtCustomerRefMain.TabIndex = 108
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.ForeColor = System.Drawing.Color.White
        Me.Label90.Location = New System.Drawing.Point(2, 363)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(79, 13)
        Me.Label90.TabIndex = 335
        Me.Label90.Text = "Customer Ref."
        '
        'txtRevisionNoMain
        '
        Me.txtRevisionNoMain.Location = New System.Drawing.Point(19, 331)
        Me.txtRevisionNoMain.Name = "txtRevisionNoMain"
        Me.txtRevisionNoMain.Size = New System.Drawing.Size(39, 22)
        Me.txtRevisionNoMain.TabIndex = 107
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.ForeColor = System.Drawing.Color.White
        Me.Label89.Location = New System.Drawing.Point(6, 313)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(71, 13)
        Me.Label89.TabIndex = 333
        Me.Label89.Text = "Revision No."
        '
        'txtSheetNo
        '
        Me.txtSheetNo.Location = New System.Drawing.Point(43, 101)
        Me.txtSheetNo.Name = "txtSheetNo"
        Me.txtSheetNo.Size = New System.Drawing.Size(27, 22)
        Me.txtSheetNo.TabIndex = 102
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.ForeColor = System.Drawing.Color.White
        Me.Label87.Location = New System.Drawing.Point(3, 70)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(29, 26)
        Me.Label87.TabIndex = 330
        Me.Label87.Text = "Item" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " No."
        '
        'txtItemNoMain
        '
        Me.txtItemNoMain.Location = New System.Drawing.Point(4, 101)
        Me.txtItemNoMain.Name = "txtItemNoMain"
        Me.txtItemNoMain.Size = New System.Drawing.Size(27, 22)
        Me.txtItemNoMain.TabIndex = 101
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label88.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.Color.White
        Me.Label88.Location = New System.Drawing.Point(42, 70)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(39, 30)
        Me.Label88.TabIndex = 332
        Me.Label88.Text = "Sheet " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No."
        '
        'txtEnggNameMain
        '
        Me.txtEnggNameMain.Location = New System.Drawing.Point(2, 286)
        Me.txtEnggNameMain.Name = "txtEnggNameMain"
        Me.txtEnggNameMain.Size = New System.Drawing.Size(77, 22)
        Me.txtEnggNameMain.TabIndex = 106
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.ForeColor = System.Drawing.Color.White
        Me.Label86.Location = New System.Drawing.Point(7, 264)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(66, 13)
        Me.Label86.TabIndex = 327
        Me.Label86.Text = "Engg Name"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.ForeColor = System.Drawing.Color.White
        Me.Label85.Location = New System.Drawing.Point(9, 172)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(42, 13)
        Me.Label85.TabIndex = 326
        Me.Label85.Text = "Project"
        '
        'txtProjectMain
        '
        Me.txtProjectMain.Location = New System.Drawing.Point(5, 191)
        Me.txtProjectMain.Name = "txtProjectMain"
        Me.txtProjectMain.Size = New System.Drawing.Size(66, 22)
        Me.txtProjectMain.TabIndex = 104
        '
        'txtTagNoMain
        '
        Me.txtTagNoMain.Location = New System.Drawing.Point(2, 236)
        Me.txtTagNoMain.Name = "txtTagNoMain"
        Me.txtTagNoMain.Size = New System.Drawing.Size(77, 22)
        Me.txtTagNoMain.TabIndex = 105
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.ForeColor = System.Drawing.Color.White
        Me.Label82.Location = New System.Drawing.Point(9, 217)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(43, 13)
        Me.Label82.TabIndex = 323
        Me.Label82.Text = "Tag No"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(9, 128)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(56, 13)
        Me.Label53.TabIndex = 321
        Me.Label53.Text = "Customer"
        '
        'txtQTYMain
        '
        Me.txtQTYMain.Location = New System.Drawing.Point(43, 38)
        Me.txtQTYMain.Name = "txtQTYMain"
        Me.txtQTYMain.Size = New System.Drawing.Size(27, 22)
        Me.txtQTYMain.TabIndex = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 26)
        Me.Label9.TabIndex = 319
        Me.Label9.Text = "Offer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No."
        '
        'txtOfferNoMain
        '
        Me.txtOfferNoMain.Location = New System.Drawing.Point(4, 38)
        Me.txtOfferNoMain.Name = "txtOfferNoMain"
        Me.txtOfferNoMain.Size = New System.Drawing.Size(27, 22)
        Me.txtOfferNoMain.TabIndex = 99
        '
        'txtCustomerMain
        '
        Me.txtCustomerMain.Location = New System.Drawing.Point(4, 147)
        Me.txtCustomerMain.Name = "txtCustomerMain"
        Me.txtCustomerMain.Size = New System.Drawing.Size(72, 22)
        Me.txtCustomerMain.TabIndex = 103
        '
        'lblSalesEngg
        '
        Me.lblSalesEngg.AutoSize = True
        Me.lblSalesEngg.BackColor = System.Drawing.Color.Transparent
        Me.lblSalesEngg.Location = New System.Drawing.Point(743, 14)
        Me.lblSalesEngg.Name = "lblSalesEngg"
        Me.lblSalesEngg.Size = New System.Drawing.Size(60, 13)
        Me.lblSalesEngg.TabIndex = 337
        Me.lblSalesEngg.Text = "SalesEngg"
        Me.lblSalesEngg.UseMnemonic = False
        '
        'HScrollBar_Records
        '
        Me.HScrollBar_Records.LargeChange = 4
        Me.HScrollBar_Records.Location = New System.Drawing.Point(716, 47)
        Me.HScrollBar_Records.Maximum = 3
        Me.HScrollBar_Records.Name = "HScrollBar_Records"
        Me.HScrollBar_Records.Size = New System.Drawing.Size(317, 20)
        Me.HScrollBar_Records.TabIndex = 338
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.Gray
        Me.Label92.Location = New System.Drawing.Point(537, 51)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(7, 10)
        Me.Label92.TabIndex = 339
        Me.Label92.Text = "|"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.Color.Gray
        Me.Label95.Location = New System.Drawing.Point(606, 51)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(7, 10)
        Me.Label95.TabIndex = 340
        Me.Label95.Text = "|"
        '
        'frmValveSizing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label95)
        Me.Controls.Add(Me.Label92)
        Me.Controls.Add(Me.lblSalesEngg)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtJumpToRecord)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.lblPrintRecordNo)
        Me.Controls.Add(Me.lblDatasheetPrinting)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtErrors)
        Me.Controls.Add(Me.Label113)
        Me.Controls.Add(Me.Label112)
        Me.Controls.Add(Me.Label111)
        Me.Controls.Add(Me.Label110)
        Me.Controls.Add(Me.Label109)
        Me.Controls.Add(Me.lblDatabaseRowNo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.HScrollBar_Records)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmValveSizing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelPRDS.ResumeLayout(False)
        Me.PanelPRDS.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents cmbMOC As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDesignPressureInlet As System.Windows.Forms.TextBox
    Friend WithEvents txtDesignTemperatureInlet As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbSuggestedRating As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblKvSelected As System.Windows.Forms.Label
    Friend WithEvents btnValveSizeAccept As System.Windows.Forms.Button
    Friend WithEvents lblKvSugg As System.Windows.Forms.Label
    Friend WithEvents txtSuggestedKV As System.Windows.Forms.TextBox
    Friend WithEvents btnKVAccept As System.Windows.Forms.Button
    Friend WithEvents cmbKVOverride As System.Windows.Forms.ComboBox
    Friend WithEvents cmbValveSizeOverride As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtSuggestedValveSize As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblDesignPressure As System.Windows.Forms.Label
    Friend WithEvents lblDesignTemperature As System.Windows.Forms.Label
    Friend WithEvents lblSuggPipeSize As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbAreaunits As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_CustomerMain As System.Windows.Forms.Label
    Friend WithEvents cmbPipeDia As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSchedule As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents btnAcceptVelocityRule As System.Windows.Forms.Button
    Friend WithEvents cmbInletPipeSize As System.Windows.Forms.ComboBox
    Friend WithEvents txtSuggActuator As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents cmbSelectActuator As System.Windows.Forms.ComboBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtAirPressure As System.Windows.Forms.TextBox
    Friend WithEvents cmbActuatorType As System.Windows.Forms.ComboBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents cmbSealing As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtDPShutoff As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents cmbPacking As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cmbBalancing As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLeakage As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cmbAirFailure As System.Windows.Forms.ComboBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents cmbHandwheel As System.Windows.Forms.ComboBox
    Friend WithEvents lblCVSugg As System.Windows.Forms.Label
    Friend WithEvents lblCvSelected As System.Windows.Forms.Label
    Friend WithEvents lblCalculating As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents cmbEndConnection As System.Windows.Forms.ComboBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents cmbBonnetType As System.Windows.Forms.ComboBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents cmbAirPressureUnits As System.Windows.Forms.ComboBox
    Friend WithEvents lblDPShutoffUnits As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblSeatDiaUnits As System.Windows.Forms.Label
    Friend WithEvents lblFinalActuator As System.Windows.Forms.Label
    Friend WithEvents lblSelectedKV As System.Windows.Forms.Label
    Friend WithEvents lblKVMaxValue As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents lblFinalRating As System.Windows.Forms.Label
    Friend WithEvents lblFinalOutletPipe As System.Windows.Forms.Label
    Friend WithEvents lblSelectedCV As System.Windows.Forms.Label
    Friend WithEvents lblKVCase1 As System.Windows.Forms.Label
    Friend WithEvents lblKVCase2 As System.Windows.Forms.Label
    Friend WithEvents lblKVCase3 As System.Windows.Forms.Label
    Friend WithEvents lblApproxCVCase1 As System.Windows.Forms.Label
    Friend WithEvents lblApproxCVCase2 As System.Windows.Forms.Label
    Friend WithEvents lblApproxCVCase3 As System.Windows.Forms.Label
    Friend WithEvents lblCalculatedKV As System.Windows.Forms.Label
    Friend WithEvents lblCalculatedCV As System.Windows.Forms.Label
    Friend WithEvents lblFinalKVCase1 As System.Windows.Forms.Label
    Friend WithEvents lblFinalKvCase2 As System.Windows.Forms.Label
    Friend WithEvents lblFinalKVcase3 As System.Windows.Forms.Label
    Friend WithEvents lblFinalCVCase1 As System.Windows.Forms.Label
    Friend WithEvents lblFinalCVCase2 As System.Windows.Forms.Label
    Friend WithEvents lblFinalCVCase3 As System.Windows.Forms.Label
    Friend WithEvents lblCorrectedKV As System.Windows.Forms.Label
    Friend WithEvents lblCorrectedCV As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblStrokeCase1 As System.Windows.Forms.Label
    Friend WithEvents lblStrokeCase2 As System.Windows.Forms.Label
    Friend WithEvents lblStrokeCase3 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents lblFlowtypeCase1 As System.Windows.Forms.Label
    Friend WithEvents lblFlowtypeCase2 As System.Windows.Forms.Label
    Friend WithEvents lblFlowtypeCase3 As System.Windows.Forms.Label
    Friend WithEvents lblFlowSeverity As System.Windows.Forms.Label
    Friend WithEvents lblSeverityCase1 As System.Windows.Forms.Label
    Friend WithEvents lblSeverityCase2 As System.Windows.Forms.Label
    Friend WithEvents lblSeverityCase3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents lblNoiseCase2 As System.Windows.Forms.Label
    Friend WithEvents lblMachnoValve As System.Windows.Forms.Label
    Friend WithEvents lblNoiseCase3 As System.Windows.Forms.Label
    Friend WithEvents lblMachnoPipe As System.Windows.Forms.Label
    Friend WithEvents lblNoiseCase1 As System.Windows.Forms.Label
    Friend WithEvents lblMachNoVavleOutCase1 As System.Windows.Forms.Label
    Friend WithEvents chkNoiseAttenuation As System.Windows.Forms.CheckBox
    Friend WithEvents lblMachNoVavleOutCase2 As System.Windows.Forms.Label
    Friend WithEvents lblAttenuatedNoiseCase1 As System.Windows.Forms.Label
    Friend WithEvents lblMachNoVavleOutCase3 As System.Windows.Forms.Label
    Friend WithEvents lblAttenuatedNoiseCase2 As System.Windows.Forms.Label
    Friend WithEvents lblMachNoPipeOutCase1 As System.Windows.Forms.Label
    Friend WithEvents lblAttenuatedNoiseCase3 As System.Windows.Forms.Label
    Friend WithEvents lblMachNoPipeOutCase2 As System.Windows.Forms.Label
    Friend WithEvents chkInsulation As System.Windows.Forms.CheckBox
    Friend WithEvents lblMachNoPipeOutCase3 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblAttnPressDropCase1 As System.Windows.Forms.Label
    Friend WithEvents lblAttnPressDropCase2 As System.Windows.Forms.Label
    Friend WithEvents lblAttnPressDropCase3 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lblFLCase1 As System.Windows.Forms.Label
    Friend WithEvents lblFLCase2 As System.Windows.Forms.Label
    Friend WithEvents lblFLCase3 As System.Windows.Forms.Label
    Friend WithEvents lblXT As System.Windows.Forms.Label
    Friend WithEvents lblXTCase1 As System.Windows.Forms.Label
    Friend WithEvents lblXTCase2 As System.Windows.Forms.Label
    Friend WithEvents lblXTCase3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityValveInletCase1 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityValveInletCase2 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityValveInletCase3 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityValveOutletCase1 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityValveOutletCase2 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityValveOutletCase3 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityOutletPipeCase1 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityOutletPipeCase2 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityOutletPipeCase3 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityunit As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatasheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Dlg_SaveAs As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Dlg_OpenXML As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MaterialsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccessoriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbInletPipeSchedule As System.Windows.Forms.ComboBox
    Friend WithEvents lblVelocityInletPipeCase3 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityInletPipeCase2 As System.Windows.Forms.Label
    Friend WithEvents lblVelocityInletPipeCase1 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtErrors As System.Windows.Forms.TextBox
    Friend WithEvents lblDatabaseRowNo As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents lblFP As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents lblInsulationMessage As System.Windows.Forms.Label
    Friend WithEvents lblFlashingCaseNoAttenuation As System.Windows.Forms.Label
    Friend WithEvents lblSuggestedRating As System.Windows.Forms.Label
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents CustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserNotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblViscosity As System.Windows.Forms.Label
    Friend WithEvents txtMedium As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtTOutPressureCase3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTOutPressureCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTOutPressureCase1 As System.Windows.Forms.TextBox
    Friend WithEvents lblToutPressure As System.Windows.Forms.Label
    Friend WithEvents txtTsatInletCase3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTsatInletCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTsatInletCase1 As System.Windows.Forms.TextBox
    Friend WithEvents lblTsatInletPress As System.Windows.Forms.Label
    Friend WithEvents lblMolecularUnit As System.Windows.Forms.Label
    Friend WithEvents chkViscosity As System.Windows.Forms.CheckBox
    Friend WithEvents txtViscosityCase1 As System.Windows.Forms.TextBox
    Friend WithEvents txtViscosityCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtViscosityCase3 As System.Windows.Forms.TextBox
    Friend WithEvents cmbViscosityUnits As System.Windows.Forms.ComboBox
    Friend WithEvents txtTsatoutPressureCase3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTsatoutPressureCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTsatoutPressureCase1 As System.Windows.Forms.TextBox
    Friend WithEvents lblTsatoutPressure As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents cmbQW As System.Windows.Forms.ComboBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUnitsType As System.Windows.Forms.ComboBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents cmbFlowrate As System.Windows.Forms.ComboBox
    Friend WithEvents txtFlowrateCase1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFlowrateCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFlowrateCase3 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFluidType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbFluid As System.Windows.Forms.ComboBox
    Friend WithEvents txtFlashingPercentageCase3 As System.Windows.Forms.TextBox
    Friend WithEvents txtFlashingPercentageCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFlashingPercentageCase1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFlashingPercentage As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbPressureUnits As System.Windows.Forms.ComboBox
    Friend WithEvents chkMolecularWeight As System.Windows.Forms.CheckBox
    Friend WithEvents txtMolecularWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtInletPressureCase1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectP2DP As System.Windows.Forms.Button
    Friend WithEvents txtInletPressureCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtX_Case3 As System.Windows.Forms.TextBox
    Friend WithEvents txtInletPressureCase3 As System.Windows.Forms.TextBox
    Friend WithEvents txtX_Case1 As System.Windows.Forms.TextBox
    Friend WithEvents txtOutletPressure1 As System.Windows.Forms.TextBox
    Friend WithEvents txtX_Case2 As System.Windows.Forms.TextBox
    Friend WithEvents txtOutletPressure2 As System.Windows.Forms.TextBox
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents txtOutletPressure3 As System.Windows.Forms.TextBox
    Friend WithEvents txtZ_Case3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtZ_Case2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPressureDropCase1 As System.Windows.Forms.TextBox
    Friend WithEvents txtZ_Case1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPressureDropCase2 As System.Windows.Forms.TextBox
    Friend WithEvents lblZ As System.Windows.Forms.Label
    Friend WithEvents txtPressureDropCase3 As System.Windows.Forms.TextBox
    Friend WithEvents txtK_Case3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtK_Case2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbTemperatureUnits As System.Windows.Forms.ComboBox
    Friend WithEvents txtInletTemperatureCase1 As System.Windows.Forms.TextBox
    Friend WithEvents txtInletTemperatureCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtInletTemperatureCase3 As System.Windows.Forms.TextBox
    Friend WithEvents lblDensity As System.Windows.Forms.Label
    Friend WithEvents cmbDensityUnits As System.Windows.Forms.ComboBox
    Friend WithEvents txtDensityCase1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDensityCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDensityCase3 As System.Windows.Forms.TextBox
    Friend WithEvents lblCriticalPressure As System.Windows.Forms.Label
    Friend WithEvents lblVapourPressure As System.Windows.Forms.Label
    Friend WithEvents txtCriticalPressureCase1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCriticalPressureCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCriticalPressureCase3 As System.Windows.Forms.TextBox
    Friend WithEvents txtVapourPressureCase1 As System.Windows.Forms.TextBox
    Friend WithEvents txtVapourPressureCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtVapourPressureCase3 As System.Windows.Forms.TextBox
    Friend WithEvents lblCriticalPressureUnit As System.Windows.Forms.Label
    Friend WithEvents lblVapourPressureUnit As System.Windows.Forms.Label
    Friend WithEvents cmbCriticalPressureUnits As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVapourPressureUnits As System.Windows.Forms.ComboBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents lblValveModel As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents lblDatasheetPrinting As System.Windows.Forms.Label
    Friend WithEvents lblPrintRecordNo As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents txtJumpToRecord As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnOverrideRating As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmbSelectedTrim As System.Windows.Forms.ComboBox
    Friend WithEvents txtSuggTrim As System.Windows.Forms.TextBox
    Friend WithEvents cmbFlowDirection As System.Windows.Forms.ComboBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbVelocityRule As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbKVseries As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmbCharacterstics As System.Windows.Forms.ComboBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblBaffleCv As System.Windows.Forms.Label
    Friend WithEvents lblBaffleKV As System.Windows.Forms.Label
    Friend WithEvents txtBaffleKVCase3 As System.Windows.Forms.TextBox
    Friend WithEvents txtBaffleKVCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBaffleKVCase1 As System.Windows.Forms.TextBox
    Friend WithEvents chkBaffleCase3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBaffleCase2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBaffleCase1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents btnTables As System.Windows.Forms.Button
    Friend WithEvents cmbSeatDia As System.Windows.Forms.ComboBox
    Friend WithEvents RecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblFinalValveSize As System.Windows.Forms.Label
    Friend WithEvents lblSalesEngg As System.Windows.Forms.Label
    Friend WithEvents lblMicroTrim As System.Windows.Forms.Label
    Friend WithEvents HScrollBar_Records As System.Windows.Forms.HScrollBar
    Friend WithEvents btnChart As System.Windows.Forms.Button
    Friend WithEvents KvCvChartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCustomerMain As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtOfferNoMain As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtQTYMain As System.Windows.Forms.TextBox
    Friend WithEvents txtTagNoMain As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents txtProjectMain As System.Windows.Forms.TextBox
    Friend WithEvents txtEnggNameMain As System.Windows.Forms.TextBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents txtSheetNo As System.Windows.Forms.TextBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents txtItemNoMain As System.Windows.Forms.TextBox
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents txtRevisionNoMain As System.Windows.Forms.TextBox
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerRefMain As System.Windows.Forms.TextBox
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents lblK As System.Windows.Forms.Label
    Friend WithEvents txtK_Case1 As System.Windows.Forms.TextBox
    Friend WithEvents lblTwUnit As System.Windows.Forms.Label
    Friend WithEvents txtWaterTemperature As System.Windows.Forms.TextBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents txtWaterFlowCase1 As System.Windows.Forms.TextBox
    Friend WithEvents PanelPRDS As System.Windows.Forms.Panel
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents txtWaterFlowCase3 As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterFlowCase2 As System.Windows.Forms.TextBox
    Friend WithEvents lblFlowWaterUnit As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents txtP2OutWCase3 As System.Windows.Forms.TextBox
    Friend WithEvents txtP2OutWCase2 As System.Windows.Forms.TextBox
    Friend WithEvents txtP2OutWCase1 As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents lblPwUnits As System.Windows.Forms.Label
    Friend WithEvents txtWaterPressure As System.Windows.Forms.TextBox
    Friend WithEvents ProgBarBaffle As System.Windows.Forms.ProgressBar
    Friend WithEvents Percent3 As System.Windows.Forms.Label
    Friend WithEvents Percent2 As System.Windows.Forms.Label
    Friend WithEvents Percent1 As System.Windows.Forms.Label
    Friend WithEvents LblCounter As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents lblForceUnits As System.Windows.Forms.Label
    Friend WithEvents lblForce0perc As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents lblForce100perc As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ChartsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiagnosisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActuatorDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CRMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyTagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents lblSel100PerF As System.Windows.Forms.Label
    Friend WithEvents lblSel0PercF As System.Windows.Forms.Label
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnAcceptActuator As System.Windows.Forms.Button
End Class
