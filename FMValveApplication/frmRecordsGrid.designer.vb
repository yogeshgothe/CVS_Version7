<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecordsGrid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        System.Threading.Thread.Sleep(3000)
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecordsGrid))
        Me.DGV_Records = New System.Windows.Forms.DataGridView()
        Me.txtDeleteRecord = New System.Windows.Forms.TextBox()
        Me.btnDeleteRecord = New System.Windows.Forms.Button()
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.Dlg_OpenXML = New System.Windows.Forms.OpenFileDialog()
        Me.btnNewFile = New System.Windows.Forms.Button()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV_Records, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Records
        '
        Me.DGV_Records.AllowUserToOrderColumns = True
        Me.DGV_Records.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Records.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Records.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Records.Location = New System.Drawing.Point(5, 38)
        Me.DGV_Records.Name = "DGV_Records"
        Me.DGV_Records.Size = New System.Drawing.Size(1260, 500)
        Me.DGV_Records.TabIndex = 1
        '
        'txtDeleteRecord
        '
        Me.txtDeleteRecord.Location = New System.Drawing.Point(1136, 10)
        Me.txtDeleteRecord.Name = "txtDeleteRecord"
        Me.txtDeleteRecord.Size = New System.Drawing.Size(118, 20)
        Me.txtDeleteRecord.TabIndex = 2
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.BackColor = System.Drawing.Color.White
        Me.btnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteRecord.Location = New System.Drawing.Point(1024, 10)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(93, 23)
        Me.btnDeleteRecord.TabIndex = 3
        Me.btnDeleteRecord.Text = "Delete Record"
        Me.btnDeleteRecord.UseVisualStyleBackColor = False
        '
        'btnLoadFile
        '
        Me.btnLoadFile.BackColor = System.Drawing.Color.White
        Me.btnLoadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadFile.Location = New System.Drawing.Point(22, 8)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadFile.TabIndex = 4
        Me.btnLoadFile.Text = "Load File"
        Me.btnLoadFile.UseVisualStyleBackColor = False
        '
        'Dlg_OpenXML
        '
        Me.Dlg_OpenXML.FileName = "OpenFileDialog1"
        '
        'btnNewFile
        '
        Me.btnNewFile.BackColor = System.Drawing.Color.White
        Me.btnNewFile.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNewFile.FlatAppearance.BorderSize = 2
        Me.btnNewFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnNewFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewFile.Location = New System.Drawing.Point(134, 8)
        Me.btnNewFile.Name = "btnNewFile"
        Me.btnNewFile.Size = New System.Drawing.Size(75, 23)
        Me.btnNewFile.TabIndex = 5
        Me.btnNewFile.Text = "New File"
        Me.btnNewFile.UseVisualStyleBackColor = False
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.BackColor = System.Drawing.Color.Transparent
        Me.lblFilename.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilename.ForeColor = System.Drawing.Color.Black
        Me.lblFilename.Location = New System.Drawing.Point(370, 10)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(0, 21)
        Me.lblFilename.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(916, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Sync Database"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmRecordsGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1284, 611)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.btnNewFile)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Controls.Add(Me.btnDeleteRecord)
        Me.Controls.Add(Me.txtDeleteRecord)
        Me.Controls.Add(Me.DGV_Records)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecordsGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Records"
        CType(Me.DGV_Records, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Records As System.Windows.Forms.DataGridView
    Friend WithEvents txtDeleteRecord As TextBox
    Friend WithEvents btnDeleteRecord As Button
    Friend WithEvents btnLoadFile As System.Windows.Forms.Button
    Friend WithEvents Dlg_OpenXML As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnNewFile As System.Windows.Forms.Button
    Friend WithEvents lblFilename As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
