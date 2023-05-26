<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChart
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChrtFlowCharac = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ChrtFlowrate = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.ChrtFlowCharac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChrtFlowrate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChrtFlowCharac
        '
        ChartArea1.AxisX.Title = "% Opening / Stroke"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.Crossing = -1.7976931348623157E+308R
        ChartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270
        ChartArea1.AxisY.Title = "Calculated Cv / Design Cv (%)"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270
        ChartArea1.AxisY2.Title = "Flowrate"
        ChartArea1.Name = "ChartArea1"
        Me.ChrtFlowCharac.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Legend1.Title = "FLOW CHARACTERISTICS"
        Legend1.TitleAlignment = System.Drawing.StringAlignment.Near
        Legend1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChrtFlowCharac.Legends.Add(Legend1)
        Me.ChrtFlowCharac.Location = New System.Drawing.Point(-1, -41)
        Me.ChrtFlowCharac.Name = "ChrtFlowCharac"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "%Opening"
        Me.ChrtFlowCharac.Series.Add(Series1)
        Me.ChrtFlowCharac.Size = New System.Drawing.Size(498, 535)
        Me.ChrtFlowCharac.TabIndex = 0
        Me.ChrtFlowCharac.Text = "Flowcharacterstics"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Kv/Cv vs %Opening"
        Me.ChrtFlowCharac.Titles.Add(Title1)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(520, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChrtFlowrate
        '
        ChartArea2.AxisX.Title = "%Opening"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.Title = "Flowrate"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.Name = "ChartArea1"
        Me.ChrtFlowrate.ChartAreas.Add(ChartArea2)
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Name = "Legend1"
        Legend2.Title = "FLOW RATE CURVE CHARACTERISTICS"
        Legend2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChrtFlowrate.Legends.Add(Legend2)
        Me.ChrtFlowrate.Location = New System.Drawing.Point(-1, -2)
        Me.ChrtFlowrate.Name = "ChrtFlowrate"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.IsXValueIndexed = True
        Series2.Label = "#VALX , #VAL"
        Series2.Legend = "Legend1"
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series2.Name = "Flowrate"
        Me.ChrtFlowrate.Series.Add(Series2)
        Me.ChrtFlowrate.Size = New System.Drawing.Size(498, 496)
        Me.ChrtFlowrate.TabIndex = 3
        Me.ChrtFlowrate.Text = "Flowrate v/s %Opening"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Kv/Cv v/s %Opening ", "Flowrate v/s %Opening"})
        Me.ListBox1.Location = New System.Drawing.Point(503, 58)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(117, 30)
        Me.ListBox1.TabIndex = 2
        '
        'frmChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 541)
        Me.Controls.Add(Me.ChrtFlowrate)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChrtFlowCharac)
        Me.Name = "frmChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Flow Charachterstics"
        CType(Me.ChrtFlowCharac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChrtFlowrate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChrtFlowCharac As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ChrtFlowrate As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
