
'Imports excel = Microsoft.Office.Interop.Excel
Imports FMValveApplication_standard.Declarations
Public Class frmMaterials
    Public TempStr() As String
    Dim flag As Integer

    Private Sub frmMaterials_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        '    My.Forms.ValveSizing.Enabled = True
        '  My.Forms.ValveSizing.lblMaterials.Focus()
    End Sub

    Private Sub frmMaterials_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SaveMaterials()
    End Sub

    Private Sub Materials_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If frmValveSizing.cmbModel.SelectedIndex = 1 Then
            Me.cmbBodyMaterial.DisplayMember = "PARAMETER_VALUE"
            Me.cmbBodyMaterial.ValueMember = "SR_NO"
            Me.cmbBodyMaterial.DataSource = ds_AccessoriesMat.Tables(2)
            Me.cmbBodyMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbBodyMaterial.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbPlug.DisplayMember = "PARAMETER_VALUE"
            Me.cmbPlug.ValueMember = "Sr_No"
            Me.cmbPlug.DataSource = ds_AccessoriesMat.Tables(3)
            Me.cmbPlug.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbPlug.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbSeat.DisplayMember = "PARAMETER_VALUE"
            Me.cmbSeat.ValueMember = "Sr_No"
            Me.cmbSeat.DataSource = ds_AccessoriesMat.Tables(4)
            Me.cmbSeat.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbSeat.AutoCompleteSource = AutoCompleteSource.ListItems


            Me.cmbTopMaterials.DisplayMember = "PARAMETER_VALUE"
            Me.cmbTopMaterials.ValueMember = "Sr_No"
            Me.cmbTopMaterials.DataSource = ds_AccessoriesMat.Tables(5)
            Me.cmbTopMaterials.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbTopMaterials.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbGasket.DisplayMember = "PARAMETER_VALUE"
            Me.cmbGasket.ValueMember = "Sr_No"
            Me.cmbGasket.DataSource = ds_AccessoriesMat.Tables(6)
            Me.cmbGasket.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbGasket.AutoCompleteSource = AutoCompleteSource.ListItems

        ElseIf frmValveSizing.cmbModel.SelectedIndex = 0 Then
            Me.cmbBodyMaterial.DisplayMember = "PARAMETER_VALUE"
            Me.cmbBodyMaterial.ValueMember = "SR_NO"
            Me.cmbBodyMaterial.DataSource = ds_AccessoriesMat.Tables(30)
            Me.cmbBodyMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbBodyMaterial.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbPlug.DisplayMember = "PARAMETER_VALUE"
            Me.cmbPlug.ValueMember = "Sr_No"
            Me.cmbPlug.DataSource = ds_AccessoriesMat.Tables(32)
            Me.cmbPlug.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbPlug.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbSeat.DisplayMember = "PARAMETER_VALUE"
            Me.cmbSeat.ValueMember = "Sr_No"
            Me.cmbSeat.DataSource = ds_AccessoriesMat.Tables(33)
            Me.cmbSeat.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbSeat.AutoCompleteSource = AutoCompleteSource.ListItems


            Me.cmbTopMaterials.DisplayMember = "PARAMETER_VALUE"
            Me.cmbTopMaterials.ValueMember = "Sr_No"
            Me.cmbTopMaterials.DataSource = ds_AccessoriesMat.Tables(31)
            Me.cmbTopMaterials.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbTopMaterials.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbGasket.DisplayMember = "PARAMETER_VALUE"
            Me.cmbGasket.ValueMember = "Sr_No"
            Me.cmbGasket.DataSource = ds_AccessoriesMat.Tables(34)
            Me.cmbGasket.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbGasket.AutoCompleteSource = AutoCompleteSource.ListItems

        ElseIf frmValveSizing.cmbModel.SelectedIndex = 2 Or frmValveSizing.cmbModel.SelectedIndex = 3 Then
            Me.cmbBodyMaterial.DisplayMember = "PARAMETER_VALUE"
            Me.cmbBodyMaterial.ValueMember = "SR_NO"
            Me.cmbBodyMaterial.DataSource = ds_AccessoriesMat.Tables(35)
            Me.cmbBodyMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbBodyMaterial.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbPlug.DisplayMember = "PARAMETER_VALUE"
            Me.cmbPlug.ValueMember = "Sr_No"
            Me.cmbPlug.DataSource = ds_AccessoriesMat.Tables(37)
            Me.cmbPlug.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbPlug.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbSeat.DisplayMember = "PARAMETER_VALUE"
            Me.cmbSeat.ValueMember = "Sr_No"
            Me.cmbSeat.DataSource = ds_AccessoriesMat.Tables(38)
            Me.cmbSeat.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbSeat.AutoCompleteSource = AutoCompleteSource.ListItems


            Me.cmbTopMaterials.DisplayMember = "PARAMETER_VALUE"
            Me.cmbTopMaterials.ValueMember = "Sr_No"
            Me.cmbTopMaterials.DataSource = ds_AccessoriesMat.Tables(36)
            Me.cmbTopMaterials.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbTopMaterials.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbGasket.DisplayMember = "PARAMETER_VALUE"
            Me.cmbGasket.ValueMember = "Sr_No"
            Me.cmbGasket.DataSource = ds_AccessoriesMat.Tables(39)
            Me.cmbGasket.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbGasket.AutoCompleteSource = AutoCompleteSource.ListItems

        ElseIf frmValveSizing.cmbModel.SelectedIndex = 4 Or frmValveSizing.cmbModel.SelectedIndex = 5 Or frmValveSizing.cmbModel.SelectedIndex = 6 Then
            Me.cmbBodyMaterial.DisplayMember = "PARAMETER_VALUE"
            Me.cmbBodyMaterial.ValueMember = "SR_NO"
            Me.cmbBodyMaterial.DataSource = ds_AccessoriesMat.Tables(40)
            Me.cmbBodyMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbBodyMaterial.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbPlug.DisplayMember = "PARAMETER_VALUE"
            Me.cmbPlug.ValueMember = "Sr_No"
            Me.cmbPlug.DataSource = ds_AccessoriesMat.Tables(42)
            Me.cmbPlug.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbPlug.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbSeat.DisplayMember = "PARAMETER_VALUE"
            Me.cmbSeat.ValueMember = "Sr_No"
            Me.cmbSeat.DataSource = ds_AccessoriesMat.Tables(43)
            Me.cmbSeat.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbSeat.AutoCompleteSource = AutoCompleteSource.ListItems


            Me.cmbTopMaterials.DisplayMember = "PARAMETER_VALUE"
            Me.cmbTopMaterials.ValueMember = "Sr_No"
            Me.cmbTopMaterials.DataSource = ds_AccessoriesMat.Tables(41)
            Me.cmbTopMaterials.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbTopMaterials.AutoCompleteSource = AutoCompleteSource.ListItems

            Me.cmbGasket.DisplayMember = "PARAMETER_VALUE"
            Me.cmbGasket.ValueMember = "Sr_No"
            Me.cmbGasket.DataSource = ds_AccessoriesMat.Tables(44)
            Me.cmbGasket.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cmbGasket.AutoCompleteSource = AutoCompleteSource.ListItems

        ElseIf frmValveSizing.cmbModel.SelectedIndex = -1 Then
            MessageBox.Show("Enter Model to Select Materials")
            Me.Close()
        End If

        cmbPainitng.DisplayMember = "PARAMETER_VALUE"
        cmbPainitng.ValueMember = "Sr_No"
        cmbPainitng.DataSource = ds_AccessoriesMat.Tables(7)
        cmbPainitng.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbPainitng.AutoCompleteSource = AutoCompleteSource.ListItems

        cmbPaintingACC.DisplayMember = "PARAMETER_VALUE"
        cmbPaintingACC.ValueMember = "Sr_No"
        cmbPaintingACC.DataSource = ds_AccessoriesMat.Tables(7)
        cmbPaintingACC.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbPaintingACC.AutoCompleteSource = AutoCompleteSource.ListItems

        Call LoadMaterials()
        Call ReLoadMaterials()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Public Function SaveMaterials()
        Try
            BodyMaterial = Me.cmbBodyMaterial.SelectedValue
            Plug = cmbPlug.SelectedValue
            Seat = cmbSeat.SelectedValue
            TopMaterials = cmbTopMaterials.SelectedValue
            Gasket = cmbGasket.SelectedValue
            Painting = cmbPainitng.SelectedValue
            Painting_ACC = cmbPaintingACC.SelectedValue
            Guiding = cmbGuiding.Text
            Return Nothing
        Catch ex As Exception
            MsgBox("SaveMaterials: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ReLoadMaterials()
        Try
            cmbBodyMaterial.SelectedValue = BodyMaterial
            cmbPlug.SelectedValue = Plug
            cmbSeat.SelectedValue = Seat
            cmbTopMaterials.SelectedValue = TopMaterials
            cmbGasket.SelectedValue = Gasket
            cmbPainitng.SelectedValue = Painting
            cmbPaintingACC.SelectedValue = Painting_ACC
            cmbGuiding.Text = Guiding
        Catch ex As Exception
            MsgBox("RELoadMaterial:  " & ex.Message)
        End Try

        Return Nothing
    End Function

    Public Sub LoadMaterials()

        'Dim rowno, columnno As Byte
        Try
            'Accessories_Materials_workbook = APP.Workbooks.Open(AppPath & "\Database\Accessories_Materials.xls")
            'Accessories_Materials_worksheet = Accessories_Materials_workbook.Worksheets("Sheet2")

            'flag = 0
            'cmbBodyMaterial.Items.Clear()
            'cmbPlug.Items.Clear()
            'cmbSeat.Items.Clear()
            'cmbTopMaterials.Items.Clear()
            'cmbGasket.Items.Clear()
            'cmbPainitng.Items.Clear()
            'cmbPaintingACC.Items.Clear()
            cmbGuiding.Items.Clear()

            cmbGuiding.Items.Add("Single")
            cmbGuiding.Items.Add("Double")

            With DT_AccessoriesMat

                'columnno = 3
                'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 2)
                'For rowno = 0 To LastRow
                '    cmbBodyMaterial.Items.Add(.Rows(rowno).Item(2))
                'Next
                'ReDim TempStr(cmbBodyMaterial.Items.Count - 1)
                'cmbBodyMaterial.Items.CopyTo(TempStr, 0)
                'cmbBodyMaterial.AutoCompleteCustomSource.AddRange(TempStr)

                'columnno = 4
                'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 3)
                'For rowno = 0 To LastRow
                '    cmbPlug.Items.Add(.Rows(rowno).Item(3))
                'Next
                'ReDim TempStr(cmbPlug.Items.Count - 1)
                'cmbPlug.Items.CopyTo(TempStr, 0)
                'cmbPlug.AutoCompleteCustomSource.AddRange(TempStr)

                'columnno = 5
                'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 4)
                'For rowno = 0 To LastRow
                '    cmbSeat.Items.Add(.Rows(rowno).Item(4))
                'Next
                'ReDim TempStr(cmbSeat.Items.Count - 1)
                'cmbSeat.Items.CopyTo(TempStr, 0)
                'cmbSeat.AutoCompleteCustomSource.AddRange(TempStr)

                'columnno = 6
                'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 5)
                'For rowno = 0 To LastRow
                '    cmbTopMaterials.Items.Add(.Rows(rowno).Item(5))
                'Next
                'ReDim TempStr(cmbTopMaterials.Items.Count - 1)
                'cmbTopMaterials.Items.CopyTo(TempStr, 0)
                'cmbTopMaterials.AutoCompleteCustomSource.AddRange(TempStr)

                'columnno = 7
                'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 6)
                'For rowno = 0 To LastRow
                '    cmbGasket.Items.Add(.Rows(rowno).Item(6))
                'Next
                'ReDim TempStr(cmbGasket.Items.Count - 1)
                'cmbGasket.Items.CopyTo(TempStr, 0)
                'cmbGasket.AutoCompleteCustomSource.AddRange(TempStr)

                'columnno = 8
                'LastRow = frmValveSizing.FindLastRow(DT_AccessoriesMat, 7)
                'For rowno = 0 To LastRow
                '    cmbPainitng.Items.Add(.Rows(rowno).Item(7))
                '    cmbPaintingACC.Items.Add(.Rows(rowno).Item(7))
                'Next
                'ReDim TempStr(cmbPainitng.Items.Count - 1)
                'cmbPainitng.Items.CopyTo(TempStr, 0)
                'cmbPainitng.AutoCompleteCustomSource.AddRange(TempStr)
                'cmbPaintingACC.AutoCompleteCustomSource.AddRange(TempStr)

                'flag = 1
            End With
        Catch ex As Exception
            MsgBox("LoadMaterials:  " & ex.Message)
        End Try
    End Sub

    'Private Sub cmbBodyMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBodyMaterial.KeyPress, cmbGasket.KeyPress, cmbGuiding.KeyPress, cmbPainitng.KeyPress, cmbPlug.KeyPress, cmbSeat.KeyPress, cmbTopMaterials.KeyPress
    '    e.Handled = True
    'End Sub


    Private Sub cmbBodyMaterial_TextChanged(sender As Object, e As EventArgs) Handles cmbBodyMaterial.TextChanged
        Try
            If Not cmbBodyMaterial.SelectedIndex = -1 Then
                If Not cmbBodyMaterial.SelectedValue > cmbTopMaterials.Items.Count Then
                    cmbTopMaterials.SelectedValue = cmbBodyMaterial.SelectedValue
                End If
                'cmbTopMaterials.SelectedValue = cmb
            End If
        Catch ex As Exception
            MsgBox("cmbBodyMaterial_TextChanged:  " & ex.Message)
        End Try
    End Sub

    Private Sub cmbPlug_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlug.SelectedIndexChanged
        Try
            If Not cmbPlug.SelectedIndex = -1 Then
                If Not cmbPlug.SelectedValue > cmbSeat.Items.Count Then
                    cmbSeat.SelectedValue = cmbPlug.SelectedValue
                End If
            End If
        Catch ex As Exception
            MsgBox("cmbPlug_SelectedIndexChanged:  " & ex.Message)
        End Try
    End Sub

End Class