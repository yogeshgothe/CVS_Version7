
'Imports excel = Microsoft.Office.Interop.Excel
Imports FMValveApplication_standard.Declarations
Public Class frmAccessories
    Public TempStr() As String
    Private Sub Accessories_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        '    My.Forms.ValveSizing.Enabled = True
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub Accessories_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SaveAccessories()
    End Sub

    Private Sub Accessories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadAccessories()
        Call ReLoadAccessories()
    End Sub
    Public Function SaveAccessories()
        Try
            Positioner = cmbPositioner.SelectedValue
            Sov = cmbSOV.SelectedValue
            AFR = cmbAFR.SelectedValue
            ALR = cmbALR.SelectedValue
            LimitSwitch = cmbLimitSwitch.SelectedValue
            VolBooster = cmbVolBooster.SelectedValue
            PosnTrans = cmbPosnTrans.SelectedValue
            ItoP = cmbItoP.SelectedValue
            QEV = cmbQEV.SelectedValue
            Certification = cmbCertification.SelectedValue
            Tubing = cmbTubing.SelectedValue
            TubingMake = cmbTubingMake.SelectedValue
            TubingSize = cmbTubingSize.SelectedValue
            TubingMOC = cmbTubingMOC.SelectedValue
            VTank = cmbVtank.Text
            Roborter = cmbRobotor.SelectedValue

            PositionerMake = cmbPositionerMake.SelectedValue
            AFRMake = cmbAFRMake.SelectedValue
            ALRMake = cmbALRMake.SelectedValue
            SOVMake = cmbSOVMake.SelectedValue
            VBMake = cmbVBMake.SelectedValue
            LimitSwitchMake = cmbLimitSwitchMake.SelectedValue
            QEVMake = cmbQEVMake.SelectedValue
        Catch ex As Exception
            MsgBox("SaveAccessories:  " & ex.Message)
        End Try
        Return Nothing
    End Function

    Public Sub checkEmpty(name As ComboBox, value As Integer)
        If name.Items.Count > 0 Then
            name.SelectedValue = value
        End If
    End Sub

    Public Function ReLoadAccessories()
        '       Sov, AFR, Positioner, ALR, LimitSwitch, VolBooster, PosnTrans,ItoP, QEV
        Try
            Me.cmbPositionerMake.SelectedValue = PositionerMake
            Me.cmbAFRMake.SelectedValue = AFRMake
            Me.cmbALRMake.SelectedValue = ALRMake
            Me.cmbSOVMake.SelectedValue = SOVMake
            Me.cmbVBMake.SelectedValue = VBMake
            Me.cmbLimitSwitchMake.SelectedValue = LimitSwitchMake
            Me.cmbQEVMake.SelectedValue = QEVMake
            Me.cmbTubingMake.SelectedValue = TubingMake

            checkEmpty(cmbPositioner, Positioner)
            checkEmpty(cmbSOV, Sov)
            checkEmpty(cmbAFR, AFR)
            checkEmpty(cmbALR, ALR)
            checkEmpty(cmbLimitSwitch, LimitSwitch)
            checkEmpty(cmbVolBooster, VolBooster)
            checkEmpty(cmbPosnTrans, PosnTrans)
            checkEmpty(cmbItoP, ItoP)
            checkEmpty(cmbQEV, QEV)
            checkEmpty(cmbCertification, Certification)
            cmbTubing.SelectedValue = Tubing
            cmbTubingSize.SelectedValue = TubingSize
            cmbTubingMOC.SelectedValue = TubingMOC
            cmbVtank.Text = VTank
            cmbRobotor.SelectedValue = Roborter
            'Me.cmbItoP.SelectedValue = ItoP
            'Me.cmbQEV.SelectedValue = QEV
            'Me.cmbCertification.SelectedValue = Certification

            If frmValveSizing.cmbActuatorType.SelectedIndex = 1 Then
                cmbRobotor.SelectedIndex = -1
                cmbRobotor.Enabled = False
            Else
                cmbRobotor.Enabled = True
                cmbRobotor.SelectedValue = Roborter
            End If
        Catch ex As Exception
            MsgBox("ReLoadAccessories:  " & ex.Message)
        End Try
        Return Nothing
    End Function

    Public Sub LoadAccessories()
        'Dim rowno, columnno As Byte
        Dim str As String = ""

        Try
            Me.cmbAFR.SelectedValue = 0
            Me.cmbPositionerMake.SelectedIndex = -1
            Me.cmbSOV.SelectedValue = 0
            Me.cmbAFR.SelectedValue = 0
            Me.cmbAFR.SelectedValue = 0
            Me.cmbALR.SelectedValue = 0
            Me.cmbLimitSwitch.SelectedValue = 0
            Me.cmbVolBooster.SelectedValue = 0
            Me.cmbPosnTrans.SelectedValue = 0
            Me.cmbItoP.SelectedValue = 0
            Me.cmbQEV.SelectedValue = 0
            'Accessories_Materials_workbook = APP.Workbooks.Open(AppPath & "\Database\Accessories_Materials.xls")
            'Accessories_Materials_worksheet = Accessories_Materials_workbook.Worksheets("Sheet2")
            'Me.cmbPositioner.Items.Clear()
            'Me.cmbSOV.Items.Clear()
            'Me.cmbAFR.Items.Clear()
            'Me.cmbALR.Items.Clear()
            'Me.cmbLimitSwitch.Items.Clear()
            'Me.cmbVolBooster.Items.Clear()
            'Me.cmbPosnTrans.Items.Clear()
            'Me.cmbVtank.Items.Clear()
            'Me.cmbItoP.Items.Clear()
            'Me.cmbQEV.Items.Clear()
            'Me.cmbCertification.Items.Clear()
            'Me.cmbTubing.Items.Clear()
            'Me.cmbRobotor.Items.Clear()
            'Me.cmbPositionerMake.Items.Clear()
            'Me.cmbAFRMake.Items.Clear()
            'Me.cmbALRMake.Items.Clear()
            'Me.cmbSOVMake.Items.Clear()
            'Me.cmbVBMake.Items.Clear()
            'Me.cmbLimitSwitchMake.Items.Clear()
            'Me.cmbQEVMake.Items.Clear()

            'With DT_AccessoriesMat

            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 23)
            '    For rowno = 0 To LastRow
            '        If Not str = .Rows(rowno).Item(23) Then
            '            str = .Rows(rowno).Item(23)
            '            Me.cmbPositionerMake.Items.Add(str)
            '        End If
            '    Next
            '    ReDim TempStr(cmbPositionerMake.Items.Count - 1)
            '    cmbPositionerMake.Items.CopyTo(TempStr, 0)
            '    cmbPositionerMake.AutoCompleteCustomSource.AddRange(TempStr)

            '    If cmbPositionerMake.Items.Count > 0 Then
            '        cmbPositionerMake.Text = PositionerMake
            '    End If

            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 24)
            '    str = ""
            '    For rowno = 0 To LastRow
            '        If Not str = .Rows(rowno).Item(24) Then
            '            str = .Rows(rowno).Item(24)
            '            Me.cmbAFRMake.Items.Add(str)
            '        End If
            '    Next
            '    ReDim TempStr(cmbAFRMake.Items.Count - 1)
            '    cmbAFRMake.Items.CopyTo(TempStr, 0)
            '    cmbAFRMake.AutoCompleteCustomSource.AddRange(TempStr)
            '    If cmbAFRMake.Items.Count > 0 Then
            '        cmbAFRMake.Text = AFRMake
            '    End If


            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 9)
            '    str = ""
            '    For rowno = 0 To LastRow
            '        If Not str = .Rows(rowno).Item(26) Then
            '            str = .Rows(rowno).Item(26)
            '            Me.cmbSOVMake.Items.Add(str)
            '        End If
            '    Next
            '    ReDim TempStr(cmbSOVMake.Items.Count - 1)
            '    cmbSOVMake.Items.CopyTo(TempStr, 0)
            '    cmbSOVMake.AutoCompleteCustomSource.AddRange(TempStr)
            '    If cmbSOVMake.Items.Count > 0 Then
            '        cmbSOVMake.Text = SOVMake
            '    End If

            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 11)
            '    str = ""
            '    For rowno = 0 To LastRow
            '        If Not str = .Rows(rowno).Item(25) Then
            '            str = .Rows(rowno).Item(25)
            '            Me.cmbALRMake.Items.Add(str)
            '        End If
            '    Next
            '    ReDim TempStr(cmbALRMake.Items.Count - 1)
            '    cmbALRMake.Items.CopyTo(TempStr, 0)
            '    cmbALRMake.AutoCompleteCustomSource.AddRange(TempStr)
            '    If cmbALRMake.Items.Count > 0 Then
            '        cmbALRMake.Text = ALRMake
            '    End If

            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 12)
            '    str = ""
            '    For rowno = 0 To LastRow
            '        If Not str = .Rows(rowno).Item(28) Then
            '            str = .Rows(rowno).Item(28)
            '            Me.cmbLimitSwitchMake.Items.Add(str)

            '        End If
            '    Next
            '    ReDim TempStr(cmbLimitSwitchMake.Items.Count - 1)
            '    cmbLimitSwitchMake.Items.CopyTo(TempStr, 0)
            '    cmbLimitSwitchMake.AutoCompleteCustomSource.AddRange(TempStr)
            '    If cmbLimitSwitchMake.Items.Count > 0 Then
            '        cmbLimitSwitchMake.Text = LimitSwitchMake
            '    End If

            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 13)
            '    str = ""
            '    For rowno = 0 To LastRow
            '        If Not str = .Rows(rowno).Item(27) Then
            '            str = .Rows(rowno).Item(27)
            '            Me.cmbVBMake.Items.Add(str)
            '        End If
            '    Next
            '    ReDim TempStr(cmbVBMake.Items.Count - 1)
            '    cmbVBMake.Items.CopyTo(TempStr, 0)
            '    cmbVBMake.AutoCompleteCustomSource.AddRange(TempStr)
            '    If cmbVBMake.Items.Count > 0 Then
            '        cmbVBMake.Text = VBMake
            '    End If

            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 14)
            '    For rowno = 0 To LastRow
            '        cmbPosnTrans.Items.Add(.Rows(rowno).Item(14))
            '    Next
            '    ReDim TempStr(cmbPosnTrans.Items.Count - 1)
            '    cmbPosnTrans.Items.CopyTo(TempStr, 0)
            '    cmbPosnTrans.AutoCompleteCustomSource.AddRange(TempStr)

            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 15)
            '    For rowno = 0 To LastRow
            '        cmbVtank.Items.Add(.Rows(rowno).Item(15))
            '    Next
            '    ReDim TempStr(cmbVtank.Items.Count - 1)
            '    cmbVtank.Items.CopyTo(TempStr, 0)
            '    cmbVtank.AutoCompleteCustomSource.AddRange(TempStr)

            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 16)

            '    For rowno = 0 To LastRow
            '        cmbRobotor.Items.Add(.Rows(rowno).Item(16))
            '    Next
            '    ReDim TempStr(cmbRobotor.Items.Count - 1)
            '    cmbRobotor.Items.CopyTo(TempStr, 0)
            '    cmbRobotor.AutoCompleteCustomSource.AddRange(TempStr)

            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 17)
            '    For rowno = 0 To LastRow
            '        cmbItoP.Items.Add(.Rows(rowno).Item(17))
            '    Next
            '    ReDim TempStr(cmbItoP.Items.Count - 1)
            '    cmbItoP.Items.CopyTo(TempStr, 0)
            '    cmbItoP.AutoCompleteCustomSource.AddRange(TempStr)

            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 18)
            '    columnno = 19
            '    str = ""
            '    For rowno = 0 To LastRow
            '        If Not str = .Rows(rowno).Item(29) Then
            '            str = .Rows(rowno).Item(29)
            '            Me.cmbQEVMake.Items.Add(str)
            '        End If
            '    Next
            '    ReDim TempStr(cmbQEVMake.Items.Count - 1)
            '    cmbQEVMake.Items.CopyTo(TempStr, 0)
            '    cmbQEVMake.AutoCompleteCustomSource.AddRange(TempStr)
            '    If cmbQEVMake.Items.Count > 0 Then
            '        cmbQEVMake.Text = QEVMake
            '    End If

            '    columnno = 20
            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 19)
            '    For rowno = 0 To LastRow
            '        cmbCertification.Items.Add(.Rows(rowno).Item(19))
            '    Next
            '    ReDim TempStr(cmbCertification.Items.Count - 1)
            '    cmbCertification.Items.CopyTo(TempStr, 0)
            '    cmbCertification.AutoCompleteCustomSource.AddRange(TempStr)

            '    LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 21)
            '    For rowno = 0 To LastRow
            '        cmbTubing.Items.Add(.Rows(rowno).Item(21))
            '    Next
            '    ReDim TempStr(cmbTubing.Items.Count - 1)
            '    cmbTubing.Items.CopyTo(TempStr, 0)
            '    cmbTubing.AutoCompleteCustomSource.AddRange(TempStr)
            'End With

            ' Set Auto complete

        Catch ex As Exception
            MsgBox("LoadAccessories:  " & ex.Message)
        End Try
    End Sub

    Private Sub cmbRobotor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRobotor.SelectedIndexChanged
        Try
            If frmValveSizing.cmbActuatorType.SelectedIndex = 1 Then
                frmValveSizing.cmbActuatorType.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox("cmbRobotor_SelectedIndexChanged:  " & ex.Message)
        End Try
    End Sub

    Private Sub cmbPositionerMake_TextChanged(sender As Object, e As EventArgs) Handles cmbPositionerMake.TextChanged
        Try
            If Not cmbPositionerMake.SelectedIndex = -1 Then
                cmbPositioner.DisplayMember = "PARAMETER_VALUE"
                cmbPositioner.ValueMember = "Sr_No"
                cmbPositioner.DataSource = Nothing
                Dim dts As New DataTable
                'dts.Columns.Add("Sr_No", GetType(Integer))
                dts.Columns.Add("SR_NO", GetType(Integer))
                dts.Columns.Add("MODEL_CODE", GetType(String))
                dts.Columns.Add("CATEGORY_CODE", GetType(String))
                dts.Columns.Add("PARAMETER_CODE", GetType(String))
                dts.Columns.Add("PARAMETER_VALUE_CODE", GetType(String))
                dts.Columns.Add("PARAMETER_VALUE", GetType(String))
                dts.Columns.Add("PARAMETER_DESC", GetType(String))
                dts.Columns.Add("CREATION_DATE", GetType(String))
                dts.Columns.Add("CREATED_BY", GetType(String))
                dts.Columns.Add("UPDATED_DATE", GetType(String))
                dts.Columns.Add("UPDATED_BY", GetType(String))
                Dim name As String = cmbPositionerMake.Text
                If name = "FM" Then
                    For Each rows As DataRow In ds_AccessoriesMat.Tables(8).Rows
                        Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                        If ch = "82" Or ch = "83" Or ch = "84" Then
                            dts.Rows.Add(rows.ItemArray)
                            'dts.ImportRow(rows)
                        End If
                    Next
                    'DataGridView1.DataSource = dts
                    cmbPositioner.DisplayMember = "PARAMETER_VALUE"
                    cmbPositioner.ValueMember = "Sr_No"
                    cmbPositioner.DataSource = dts
                ElseIf name = "METSO" Then
                    For Each rows As DataRow In ds_AccessoriesMat.Tables(8).Rows
                        Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                        If ch = "ND" Then
                            dts.Rows.Add(rows.ItemArray)
                            'dts.ImportRow(rows)
                        End If
                    Next
                    'DataGridView1.DataSource = dts
                    cmbPositioner.DisplayMember = "PARAMETER_VALUE"
                    cmbPositioner.ValueMember = "Sr_No"
                    cmbPositioner.DataSource = dts
                ElseIf name = "SIEMENS" Then
                    For Each rows As DataRow In ds_AccessoriesMat.Tables(8).Rows
                        Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                        If ch = "6D" Then
                            dts.Rows.Add(rows.ItemArray)
                            'dts.ImportRow(rows)
                        End If
                    Next
                    'DataGridView1.DataSource = dts
                    cmbPositioner.DisplayMember = "PARAMETER_VALUE"
                    cmbPositioner.ValueMember = "Sr_No"
                    cmbPositioner.DataSource = dts
                ElseIf name = "YTC" Then
                    For Each rows As DataRow In ds_AccessoriesMat.Tables(8).Rows
                        Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                        If ch = "YT" Then
                            dts.Rows.Add(rows.ItemArray)
                            'dts.ImportRow(rows)
                        End If
                    Next
                    'DataGridView1.DataSource = dts
                    cmbPositioner.DisplayMember = "PARAMETER_VALUE"
                    cmbPositioner.ValueMember = "Sr_No"
                    cmbPositioner.DataSource = dts
                End If
            Else
                'DataGridView1.DataSource = dts
                cmbPositioner.DisplayMember = Nothing
                cmbPositioner.ValueMember = Nothing
                cmbPositioner.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.StackTrace)
        End Try
        'cmbPositioner.Items.Clear()
        'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 23)
        'For rowno = 0 To LastRow
        '    If DT_AccessoriesMat.Rows(rowno).Item(23) = cmbPositionerMake.Text Then
        '        cmbPositioner.Items.Add(DT_AccessoriesMat.Rows(rowno).Item(8))
        '    End If
        'Next
        'ReDim TempStr(cmbPositioner.Items.Count - 1)
        'cmbPositioner.Items.CopyTo(TempStr, 0)
        'cmbPositioner.AutoCompleteCustomSource.AddRange(TempStr)
        'If cmbPositioner.Items.Count > 0 Then
        '    cmbPositioner.SelectedIndex = 0
        'End If
    End Sub


    Private Sub cmbAFRMake_TextChanged(sender As Object, e As EventArgs) Handles cmbAFRMake.TextChanged
        If Not cmbAFRMake.SelectedIndex = -1 Then
            cmbAFR.DisplayMember = "PARAMETER_VALUE"
            cmbAFR.ValueMember = "Sr_No"
            cmbAFR.DataSource = Nothing
            Dim dts As New DataTable
            'dts.Columns.Add("Sr_No", GetType(Integer))
            dts.Columns.Add("SR_NO", GetType(Integer))
            dts.Columns.Add("MODEL_CODE", GetType(String))
            dts.Columns.Add("CATEGORY_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_VALUE_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_VALUE", GetType(String))
            dts.Columns.Add("PARAMETER_DESC", GetType(String))
            dts.Columns.Add("CREATION_DATE", GetType(String))
            dts.Columns.Add("CREATED_BY", GetType(String))
            dts.Columns.Add("UPDATED_DATE", GetType(String))
            dts.Columns.Add("UPDATED_BY", GetType(String))
            Dim name As String = cmbAFRMake.Text
            If name = "ASCO" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(10).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "67" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbAFR.DisplayMember = "PARAMETER_VALUE"
                cmbAFR.ValueMember = "Sr_No"
                cmbAFR.DataSource = dts
            ElseIf name = "NORGREN" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(10).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "B7" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbAFR.DisplayMember = "PARAMETER_VALUE"
                cmbAFR.ValueMember = "Sr_No"
                cmbAFR.DataSource = dts
            ElseIf name = "PLACKA" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(10).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 3)
                    If ch = "FPR" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbAFR.DisplayMember = "PARAMETER_VALUE"
                cmbAFR.ValueMember = "Sr_No"
                cmbAFR.DataSource = dts
            ElseIf name = "SHAVO" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(10).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "SB" Or ch = "11" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbAFR.DisplayMember = "PARAMETER_VALUE"
                cmbAFR.ValueMember = "Sr_No"
                cmbAFR.DataSource = dts
            ElseIf name = "YTC" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(10).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "YT" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbAFR.DisplayMember = "PARAMETER_VALUE"
                cmbAFR.ValueMember = "Sr_No"
                cmbAFR.DataSource = dts
            End If
        Else
            'DataGridView1.DataSource = dts
            cmbAFR.DisplayMember = Nothing
            cmbAFR.ValueMember = Nothing
            cmbAFR.DataSource = Nothing
        End If
        'cmbAFR.Items.Clear()
        'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 24)

        'For rowno = 0 To LastRow
        '    If DT_AccessoriesMat.Rows(rowno).Item(24) = cmbAFRMake.Text Then
        '        cmbAFR.Items.Add(DT_AccessoriesMat.Rows(rowno).Item(10))
        '    End If
        'Next
        'ReDim TempStr(cmbAFR.Items.Count - 1)
        'cmbAFR.Items.CopyTo(TempStr, 0)
        'cmbAFR.AutoCompleteCustomSource.AddRange(TempStr)
        'If cmbAFR.Items.Count > 0 Then
        '    cmbAFR.SelectedIndex = 0
        'End If
    End Sub



    Private Sub cmbALRMake_TextChanged(sender As Object, e As EventArgs) Handles cmbALRMake.TextChanged
        Try
            If Not cmbALRMake.SelectedIndex = -1 Then
                cmbALR.DisplayMember = "PARAMETER_VALUE"
                cmbALR.ValueMember = "Sr_No"
                cmbALR.DataSource = Nothing
                Dim dts As New DataTable
                'dts.Columns.Add("Sr_No", GetType(Integer))
                dts.Columns.Add("SR_NO", GetType(Integer))
                dts.Columns.Add("MODEL_CODE", GetType(String))
                dts.Columns.Add("CATEGORY_CODE", GetType(String))
                dts.Columns.Add("PARAMETER_CODE", GetType(String))
                dts.Columns.Add("PARAMETER_VALUE_CODE", GetType(String))
                dts.Columns.Add("PARAMETER_VALUE", GetType(String))
                dts.Columns.Add("PARAMETER_DESC", GetType(String))
                dts.Columns.Add("CREATION_DATE", GetType(String))
                dts.Columns.Add("CREATED_BY", GetType(String))
                dts.Columns.Add("UPDATED_DATE", GetType(String))
                dts.Columns.Add("UPDATED_BY", GetType(String))
                Dim name As String = cmbALRMake.Text
                If name = "PHILVIN" Then
                    For Each rows As DataRow In ds_AccessoriesMat.Tables(11).Rows
                        Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                        If ch = "PL" Then
                            dts.Rows.Add(rows.ItemArray)
                            'dts.ImportRow(rows)
                        End If
                    Next
                    'DataGridView1.DataSource = dts
                    cmbALR.DisplayMember = "PARAMETER_VALUE"
                    cmbALR.ValueMember = "Sr_No"
                    cmbALR.DataSource = dts
                ElseIf name = "YTC" Then
                    For Each rows As DataRow In ds_AccessoriesMat.Tables(11).Rows
                        Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                        If ch = "YT" Then
                            dts.Rows.Add(rows.ItemArray)
                            'dts.ImportRow(rows)
                        End If
                    Next
                    'DataGridView1.DataSource = dts
                    cmbALR.DisplayMember = "PARAMETER_VALUE"
                    cmbALR.ValueMember = "Sr_No"
                    cmbALR.DataSource = dts
                ElseIf name = "NELES" Then
                    For Each rows As DataRow In ds_AccessoriesMat.Tables(11).Rows
                        Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                        If ch = "SE" Then
                            dts.Rows.Add(rows.ItemArray)
                            'dts.ImportRow(rows)
                        End If
                    Next
                    'DataGridView1.DataSource = dts
                    cmbALR.DisplayMember = "PARAMETER_VALUE"
                    cmbALR.ValueMember = "Sr_No"
                    cmbALR.DataSource = dts
                End If
            Else
                'DataGridView1.DataSource = dts
                cmbALR.DisplayMember = Nothing
                cmbALR.ValueMember = Nothing
                cmbALR.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("cmbALRMake_TextChanged: ", ex.Message)
        End Try
        'cmbALR.Items.Clear()
        'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 25)
        'For rowno = 0 To LastRow
        '    If DT_AccessoriesMat.Rows(rowno).Item(25) = cmbALRMake.Text Then
        '        cmbALR.Items.Add(DT_AccessoriesMat.Rows(rowno).Item(11))
        '    End If
        'Next
        'ReDim TempStr(cmbALR.Items.Count - 1)
        'cmbALR.Items.CopyTo(TempStr, 0)
        'cmbALR.AutoCompleteCustomSource.AddRange(TempStr)
        'If cmbALR.Items.Count > 0 Then
        '    cmbALR.SelectedIndex = 0
        'End If
    End Sub


    Private Sub cmbSOVMake_TextChanged(sender As Object, e As EventArgs) Handles cmbSOVMake.TextChanged
        If Not cmbSOVMake.SelectedIndex = -1 Then
            cmbSOV.DisplayMember = "PARAMETER_VALUE"
            cmbSOV.ValueMember = "Sr_No"
            cmbSOV.DataSource = Nothing
            Dim dts As New DataTable
            'dts.Columns.Add("Sr_No", GetType(Integer))
            dts.Columns.Add("SR_NO", GetType(Integer))
            dts.Columns.Add("MODEL_CODE", GetType(String))
            dts.Columns.Add("CATEGORY_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_VALUE_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_VALUE", GetType(String))
            dts.Columns.Add("PARAMETER_DESC", GetType(String))
            dts.Columns.Add("CREATION_DATE", GetType(String))
            dts.Columns.Add("CREATED_BY", GetType(String))
            dts.Columns.Add("UPDATED_DATE", GetType(String))
            dts.Columns.Add("UPDATED_BY", GetType(String))
            Dim name As String = cmbSOVMake.Text
            If name = "ASCO" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(9).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "WP" Or ch = "WS" Or ch = "NF" Or ch = "IS" Or ch = "X8" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbSOV.DisplayMember = "PARAMETER_VALUE"
                cmbSOV.ValueMember = "Sr_No"
                cmbSOV.DataSource = dts
            ElseIf name = "ROTEX" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(9).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "30" Or ch = "P3" Or ch = "51" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbSOV.DisplayMember = "PARAMETER_VALUE"
                cmbSOV.ValueMember = "Sr_No"
                cmbSOV.DataSource = dts
            ElseIf name = "YTC" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(9).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "YT" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbSOV.DisplayMember = "PARAMETER_VALUE"
                cmbSOV.ValueMember = "Sr_No"
                cmbSOV.DataSource = dts
            End If
        Else
            'DataGridView1.DataSource = dts
            cmbSOV.DisplayMember = Nothing
            cmbSOV.ValueMember = Nothing
            cmbSOV.DataSource = Nothing
        End If
        'cmbSOV.Items.Clear()
        'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 26)
        'For rowno = 0 To LastRow
        '    If DT_AccessoriesMat.Rows(rowno).Item(26) = cmbSOVMake.Text Then
        '        cmbSOV.Items.Add(DT_AccessoriesMat.Rows(rowno).Item(9))
        '    End If
        'Next
        'ReDim TempStr(cmbSOV.Items.Count - 1)
        'cmbSOV.Items.CopyTo(TempStr, 0)
        'cmbSOV.AutoCompleteCustomSource.AddRange(TempStr)
        'If cmbSOV.Items.Count > 0 Then
        '    cmbSOV.SelectedIndex = 0
        'End If
    End Sub


    Private Sub cmbVBMake_TextChanged(sender As Object, e As EventArgs) Handles cmbVBMake.TextChanged
        If Not cmbVBMake.SelectedIndex = -1 Then
            cmbVolBooster.DisplayMember = "PARAMETER_VALUE"
            cmbVolBooster.ValueMember = "Sr_No"
            cmbVolBooster.DataSource = Nothing
            Dim dts As New DataTable
            'dts.Columns.Add("Sr_No", GetType(Integer))
            dts.Columns.Add("SR_NO", GetType(Integer))
            dts.Columns.Add("MODEL_CODE", GetType(String))
            dts.Columns.Add("CATEGORY_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_VALUE_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_VALUE", GetType(String))
            dts.Columns.Add("PARAMETER_DESC", GetType(String))
            dts.Columns.Add("CREATION_DATE", GetType(String))
            dts.Columns.Add("CREATED_BY", GetType(String))
            dts.Columns.Add("UPDATED_DATE", GetType(String))
            dts.Columns.Add("UPDATED_BY", GetType(String))
            Dim name As String = cmbVBMake.Text
            If name = "FORBES MARSHALL" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(13).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "FM" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbVolBooster.DisplayMember = "PARAMETER_VALUE"
                cmbVolBooster.ValueMember = "Sr_No"
                cmbVolBooster.DataSource = dts
            ElseIf name = "PHILVIN" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(13).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "PE" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbVolBooster.DisplayMember = "PARAMETER_VALUE"
                cmbVolBooster.ValueMember = "Sr_No"
                cmbVolBooster.DataSource = dts
            ElseIf name = "YTC" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(13).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "YT" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbVolBooster.DisplayMember = "PARAMETER_VALUE"
                cmbVolBooster.ValueMember = "Sr_No"
                cmbVolBooster.DataSource = dts
            End If
        Else
            'DataGridView1.DataSource = dts
            cmbVolBooster.DisplayMember = Nothing
            cmbVolBooster.ValueMember = Nothing
            cmbVolBooster.DataSource = Nothing
        End If
        'cmbVolBooster.Items.Clear()
        'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 27)
        'For rowno = 0 To LastRow
        '    If DT_AccessoriesMat.Rows(rowno).Item(27) = cmbVBMake.Text Then
        '        cmbVolBooster.Items.Add(DT_AccessoriesMat.Rows(rowno).Item(13))
        '    End If
        'Next
        'ReDim TempStr(cmbVolBooster.Items.Count - 1)
        'cmbVolBooster.Items.CopyTo(TempStr, 0)
        'cmbSOV.AutoCompleteCustomSource.AddRange(TempStr)
        'If cmbVolBooster.Items.Count > 0 Then
        '    cmbVolBooster.SelectedIndex = 0
        'End If
    End Sub

    Private Sub cmbLimitSwitchMake_TextChanged(sender As Object, e As EventArgs) Handles cmbLimitSwitchMake.TextChanged
        If Not cmbLimitSwitchMake.SelectedIndex = -1 Then
            cmbLimitSwitch.DisplayMember = "PARAMETER_VALUE"
            cmbLimitSwitch.ValueMember = "Sr_No"
            cmbLimitSwitch.DataSource = Nothing
            Dim dts As New DataTable
            'dts.Columns.Add("Sr_No", GetType(Integer))
            dts.Columns.Add("SR_NO", GetType(Integer))
            dts.Columns.Add("MODEL_CODE", GetType(String))
            dts.Columns.Add("CATEGORY_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_VALUE_CODE", GetType(String))
            dts.Columns.Add("PARAMETER_VALUE", GetType(String))
            dts.Columns.Add("PARAMETER_DESC", GetType(String))
            dts.Columns.Add("CREATION_DATE", GetType(String))
            dts.Columns.Add("CREATED_BY", GetType(String))
            dts.Columns.Add("UPDATED_DATE", GetType(String))
            dts.Columns.Add("UPDATED_BY", GetType(String))
            Dim name As String = cmbLimitSwitchMake.Text
            If name = "BCH" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(12).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "NL" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbLimitSwitch.DisplayMember = "PARAMETER_VALUE"
                cmbLimitSwitch.ValueMember = "Sr_No"
                cmbLimitSwitch.DataSource = dts
            ElseIf name = "JAI BALAJI" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(12).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "JL" Or ch = "EP" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbLimitSwitch.DisplayMember = "PARAMETER_VALUE"
                cmbLimitSwitch.ValueMember = "Sr_No"
                cmbLimitSwitch.DataSource = dts
            ElseIf name = "ROTEX" Then
                For Each rows As DataRow In ds_AccessoriesMat.Tables(12).Rows
                    Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                    If ch = "NB" Or ch = "DN" Or ch = "DX" Or ch = "NI" Then
                        dts.Rows.Add(rows.ItemArray)
                        'dts.ImportRow(rows)
                    End If
                Next
                'DataGridView1.DataSource = dts
                cmbLimitSwitch.DisplayMember = "PARAMETER_VALUE"
                cmbLimitSwitch.ValueMember = "Sr_No"
                cmbLimitSwitch.DataSource = dts
            End If
        Else
            'DataGridView1.DataSource = dts
            cmbLimitSwitch.DisplayMember = Nothing
            cmbLimitSwitch.ValueMember = Nothing
            cmbLimitSwitch.DataSource = Nothing
        End If
        'cmbLimitSwitch.Items.Clear()
        'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 28)
        'For rowno = 0 To LastRow
        '    If DT_AccessoriesMat.Rows(rowno).Item(28) = cmbLimitSwitchMake.Text Then
        '        cmbLimitSwitch.Items.Add(DT_AccessoriesMat.Rows(rowno).Item(12))
        '    End If
        'Next
        'ReDim TempStr(cmbLimitSwitch.Items.Count - 1)
        'cmbLimitSwitch.Items.CopyTo(TempStr, 0)
        'cmbLimitSwitch.AutoCompleteCustomSource.AddRange(TempStr)
        'If cmbLimitSwitch.Items.Count > 0 Then
        '    cmbLimitSwitch.SelectedIndex = 0
        'End If
    End Sub

    Private Sub cmbQEVMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQEVMake.SelectedIndexChanged
        Try
            If Not cmbQEVMake.SelectedIndex = -1 Then
                cmbQEV.DisplayMember = "PARAMETER_VALUE"
                cmbQEV.ValueMember = "Sr_No"
                cmbQEV.DataSource = Nothing
                Dim dts As New DataTable
                'dts.Columns.Add("Sr_No", GetType(Integer))
                dts.Columns.Add("SR_NO", GetType(Integer))
                dts.Columns.Add("MODEL_CODE", GetType(String))
                dts.Columns.Add("CATEGORY_CODE", GetType(String))
                dts.Columns.Add("PARAMETER_CODE", GetType(String))
                dts.Columns.Add("PARAMETER_VALUE_CODE", GetType(String))
                dts.Columns.Add("PARAMETER_VALUE", GetType(String))
                dts.Columns.Add("PARAMETER_DESC", GetType(String))
                dts.Columns.Add("CREATION_DATE", GetType(String))
                dts.Columns.Add("CREATED_BY", GetType(String))
                dts.Columns.Add("UPDATED_DATE", GetType(String))
                dts.Columns.Add("UPDATED_BY", GetType(String))
                Dim name As String = cmbQEVMake.Text
                If name = "PHILVIN" Then
                    For Each rows As DataRow In ds_AccessoriesMat.Tables(18).Rows
                        Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                        If ch = "PE" Then
                            dts.Rows.Add(rows.ItemArray)
                            'dts.ImportRow(rows)
                        End If
                    Next
                    'DataGridView1.DataSource = dts
                    cmbQEV.DisplayMember = "PARAMETER_VALUE"
                    cmbQEV.ValueMember = "Sr_No"
                    cmbQEV.DataSource = dts
                ElseIf name = "SHAVO" Then
                    For Each rows As DataRow In ds_AccessoriesMat.Tables(18).Rows
                        Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                        If ch = "SQ" Then
                            dts.Rows.Add(rows.ItemArray)
                            'dts.ImportRow(rows)
                        End If
                    Next
                    'DataGridView1.DataSource = dts
                    cmbQEV.DisplayMember = "PARAMETER_VALUE"
                    cmbQEV.ValueMember = "Sr_No"
                    cmbQEV.DataSource = dts
                ElseIf name = "MIDLAND" Then
                    For Each rows As DataRow In ds_AccessoriesMat.Tables(18).Rows
                        Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                        If ch = "2Q" Then
                            dts.Rows.Add(rows.ItemArray)
                            'dts.ImportRow(rows)
                        End If
                    Next
                    'DataGridView1.DataSource = dts
                    cmbQEV.DisplayMember = "PARAMETER_VALUE"
                    cmbQEV.ValueMember = "Sr_No"
                    cmbQEV.DataSource = dts
                ElseIf name = "SCHRADER DUNCAN" Then
                    For Each rows As DataRow In ds_AccessoriesMat.Tables(18).Rows
                        Dim ch = rows.Item("PARAMETER_VALUE").ToString.Substring(0, 2)
                        If ch = "33" Or ch = "A3" Then
                            dts.Rows.Add(rows.ItemArray)
                            'dts.ImportRow(rows)
                        End If
                    Next
                    'DataGridView1.DataSource = dts
                    cmbQEV.DisplayMember = "PARAMETER_VALUE"
                    cmbQEV.ValueMember = "Sr_No"
                    cmbQEV.DataSource = dts
                End If
            Else
                'DataGridView1.DataSource = dts
                cmbQEV.DisplayMember = Nothing
                cmbQEV.ValueMember = Nothing
                cmbQEV.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try
        'cmbQEV.Items.Clear()
        'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 29)
        'For rowno = 0 To LastRow
        '    If DT_AccessoriesMat.Rows(rowno).Item(29) = cmbQEVMake.Text Then
        '        cmbQEV.Items.Add(DT_AccessoriesMat.Rows(rowno).Item(18))
        '    End If
        'Next
        'ReDim TempStr(cmbQEV.Items.Count - 1)
        'cmbQEV.Items.CopyTo(TempStr, 0)
        'cmbQEV.AutoCompleteCustomSource.AddRange(TempStr)
        'If cmbQEV.Items.Count > 0 Then
        '    cmbQEV.SelectedIndex = 0
        'End If
    End Sub
End Class