<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintDatasheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintDatasheet))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrintRecords = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFromDatasheet = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtToDatasheet = New System.Windows.Forms.TextBox()
        Me.btnPrintDatasheet = New System.Windows.Forms.Button()
        Me.btnDatasheetClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Records:"
        '
        'lblPrintRecords
        '
        Me.lblPrintRecords.AutoSize = True
        Me.lblPrintRecords.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintRecords.Location = New System.Drawing.Point(98, 10)
        Me.lblPrintRecords.Name = "lblPrintRecords"
        Me.lblPrintRecords.Size = New System.Drawing.Size(24, 15)
        Me.lblPrintRecords.TabIndex = 1
        Me.lblPrintRecords.Text = "1/1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Print Datasheets:"
        '
        'txtFromDatasheet
        '
        Me.txtFromDatasheet.Location = New System.Drawing.Point(57, 68)
        Me.txtFromDatasheet.Name = "txtFromDatasheet"
        Me.txtFromDatasheet.Size = New System.Drawing.Size(52, 23)
        Me.txtFromDatasheet.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "From:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "To:"
        '
        'txtToDatasheet
        '
        Me.txtToDatasheet.Location = New System.Drawing.Point(159, 68)
        Me.txtToDatasheet.Name = "txtToDatasheet"
        Me.txtToDatasheet.Size = New System.Drawing.Size(52, 23)
        Me.txtToDatasheet.TabIndex = 5
        '
        'btnPrintDatasheet
        '
        Me.btnPrintDatasheet.BackColor = System.Drawing.Color.Transparent
        Me.btnPrintDatasheet.Location = New System.Drawing.Point(83, 97)
        Me.btnPrintDatasheet.Name = "btnPrintDatasheet"
        Me.btnPrintDatasheet.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintDatasheet.TabIndex = 7
        Me.btnPrintDatasheet.Text = "Print"
        Me.btnPrintDatasheet.UseVisualStyleBackColor = False
        '
        'btnDatasheetClose
        '
        Me.btnDatasheetClose.BackColor = System.Drawing.Color.Transparent
        Me.btnDatasheetClose.Location = New System.Drawing.Point(185, 145)
        Me.btnDatasheetClose.Name = "btnDatasheetClose"
        Me.btnDatasheetClose.Size = New System.Drawing.Size(75, 23)
        Me.btnDatasheetClose.TabIndex = 8
        Me.btnDatasheetClose.Text = "Close"
        Me.btnDatasheetClose.UseVisualStyleBackColor = True
        '
        'frmPrintDatasheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 180)
        Me.Controls.Add(Me.btnDatasheetClose)
        Me.Controls.Add(Me.btnPrintDatasheet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtToDatasheet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFromDatasheet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPrintRecords)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrintDatasheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Datasheets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPrintRecords As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFromDatasheet As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtToDatasheet As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintDatasheet As System.Windows.Forms.Button
    Friend WithEvents btnDatasheetClose As System.Windows.Forms.Button
End Class
