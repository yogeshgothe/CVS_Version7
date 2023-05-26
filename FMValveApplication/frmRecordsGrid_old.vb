Imports System.IO
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
Imports System.Data.SqlClient

Public Class frmRecordsGrid
    Dim pk As Integer
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


            frmValveSizing.WindowState = FormWindowState.Normal
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
        frmValveSizing.WindowState = FormWindowState.Minimized
        DGV_Records.AllowUserToAddRows = False
        'LoadDGV()
        'DGV_Records.Columns(8).ReadOnly = True
        'DGV_Records.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        frmValveSizing.Show()
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
            frmValveSizing.WindowState = FormWindowState.Normal
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