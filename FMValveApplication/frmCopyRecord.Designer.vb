<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCopyRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCopyRecord))
        Me.lblLastRecord = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSourceRecord = New System.Windows.Forms.TextBox()
        Me.txtDestinationRecord = New System.Windows.Forms.TextBox()
        Me.lblCopy = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLastRecord
        '
        Me.lblLastRecord.AutoSize = True
        Me.lblLastRecord.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastRecord.Location = New System.Drawing.Point(38, 21)
        Me.lblLastRecord.Name = "lblLastRecord"
        Me.lblLastRecord.Size = New System.Drawing.Size(69, 13)
        Me.lblLastRecord.TabIndex = 0
        Me.lblLastRecord.Text = "Last Record:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Source Record:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Destination Record:"
        '
        'txtSourceRecord
        '
        Me.txtSourceRecord.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSourceRecord.Location = New System.Drawing.Point(171, 47)
        Me.txtSourceRecord.Name = "txtSourceRecord"
        Me.txtSourceRecord.Size = New System.Drawing.Size(77, 22)
        Me.txtSourceRecord.TabIndex = 1
        '
        'txtDestinationRecord
        '
        Me.txtDestinationRecord.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestinationRecord.Location = New System.Drawing.Point(171, 82)
        Me.txtDestinationRecord.Name = "txtDestinationRecord"
        Me.txtDestinationRecord.Size = New System.Drawing.Size(77, 22)
        Me.txtDestinationRecord.TabIndex = 2
        '
        'lblCopy
        '
        Me.lblCopy.AutoSize = True
        Me.lblCopy.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopy.Location = New System.Drawing.Point(168, 138)
        Me.lblCopy.Name = "lblCopy"
        Me.lblCopy.Size = New System.Drawing.Size(39, 17)
        Me.lblCopy.TabIndex = 3
        Me.lblCopy.Text = "&Copy"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.Location = New System.Drawing.Point(169, 172)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(40, 17)
        Me.lblClose.TabIndex = 4
        Me.lblClose.Text = "Close"
        '
        'frmCopyRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblCopy)
        Me.Controls.Add(Me.txtDestinationRecord)
        Me.Controls.Add(Me.txtSourceRecord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLastRecord)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCopyRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCopyRecord"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLastRecord As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSourceRecord As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinationRecord As System.Windows.Forms.TextBox
    Friend WithEvents lblCopy As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
End Class
