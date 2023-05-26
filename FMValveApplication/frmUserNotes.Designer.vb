<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserNotes))
        Me.txtUserNotes1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserNotes2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUserNotes3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtUserNotes1
        '
        Me.txtUserNotes1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUserNotes1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserNotes1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtUserNotes1.Location = New System.Drawing.Point(12, 29)
        Me.txtUserNotes1.Multiline = True
        Me.txtUserNotes1.Name = "txtUserNotes1"
        Me.txtUserNotes1.Size = New System.Drawing.Size(512, 71)
        Me.txtUserNotes1.TabIndex = 5
        Me.txtUserNotes1.Text = "User Notes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(459, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 265
        Me.Label1.Text = "Save && Close"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 266
        Me.Label2.Text = "User Notes 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 268
        Me.Label3.Text = "User Notes 2"
        '
        'txtUserNotes2
        '
        Me.txtUserNotes2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUserNotes2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserNotes2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtUserNotes2.Location = New System.Drawing.Point(12, 127)
        Me.txtUserNotes2.Multiline = True
        Me.txtUserNotes2.Name = "txtUserNotes2"
        Me.txtUserNotes2.Size = New System.Drawing.Size(512, 71)
        Me.txtUserNotes2.TabIndex = 267
        Me.txtUserNotes2.Text = "User Notes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 270
        Me.Label4.Text = "User Notes 3"
        '
        'txtUserNotes3
        '
        Me.txtUserNotes3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUserNotes3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserNotes3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtUserNotes3.Location = New System.Drawing.Point(12, 219)
        Me.txtUserNotes3.Multiline = True
        Me.txtUserNotes3.Name = "txtUserNotes3"
        Me.txtUserNotes3.Size = New System.Drawing.Size(512, 71)
        Me.txtUserNotes3.TabIndex = 269
        Me.txtUserNotes3.Text = "User Notes"
        '
        'frmUserNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 330)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUserNotes3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUserNotes2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUserNotes1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUserNotes"
        Me.Text = "User Notes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserNotes1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserNotes2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUserNotes3 As System.Windows.Forms.TextBox
End Class
