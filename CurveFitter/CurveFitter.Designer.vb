<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CurveFitter
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 3.0R)
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(20.0R, 8.5R)
        Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(40.0R, 20.5R)
        Dim DataPoint4 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(60.0R, 22.7R)
        Dim DataPoint5 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(80.0R, 23.7R)
        Dim DataPoint6 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(100.0R, 25.0R)
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.CurveChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem_IncreasePrecision = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_DecreasePrecision = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.CurveChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CurveChart
        '
        Me.CurveChart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.Maximum = 100.0R
        ChartArea1.AxisX.Minimum = 0R
        ChartArea1.AxisX.Title = "RPM %"
        ChartArea1.AxisY.Maximum = 25.0R
        ChartArea1.AxisY.Minimum = 0R
        ChartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        ChartArea1.AxisY.Title = "A"
        ChartArea1.Name = "Main"
        Me.CurveChart.ChartAreas.Add(ChartArea1)
        Me.CurveChart.ContextMenuStrip = Me.MenuStrip
        Me.CurveChart.Location = New System.Drawing.Point(3, 3)
        Me.CurveChart.Name = "CurveChart"
        Series1.BorderWidth = 5
        Series1.ChartArea = "Main"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.CustomProperties = "IsXAxisQuantitative=False"
        Series1.Legend = "Legend1"
        Series1.MarkerBorderWidth = 0
        Series1.MarkerColor = System.Drawing.Color.Red
        Series1.MarkerSize = 20
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Curve"
        Series1.Points.Add(DataPoint1)
        Series1.Points.Add(DataPoint2)
        Series1.Points.Add(DataPoint3)
        Series1.Points.Add(DataPoint4)
        Series1.Points.Add(DataPoint5)
        Series1.Points.Add(DataPoint6)
        Series2.BorderColor = System.Drawing.Color.Red
        Series2.BorderWidth = 5
        Series2.ChartArea = "Main"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend1"
        Series2.Name = "Polynomial"
        Me.CurveChart.Series.Add(Series1)
        Me.CurveChart.Series.Add(Series2)
        Me.CurveChart.Size = New System.Drawing.Size(829, 487)
        Me.CurveChart.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_IncreasePrecision, Me.ToolStripMenuItem_DecreasePrecision})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(173, 48)
        '
        'ToolStripMenuItem_IncreasePrecision
        '
        Me.ToolStripMenuItem_IncreasePrecision.Name = "ToolStripMenuItem_IncreasePrecision"
        Me.ToolStripMenuItem_IncreasePrecision.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem_IncreasePrecision.Text = "Increase Precision"
        '
        'ToolStripMenuItem_DecreasePrecision
        '
        Me.ToolStripMenuItem_DecreasePrecision.Name = "ToolStripMenuItem_DecreasePrecision"
        Me.ToolStripMenuItem_DecreasePrecision.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem_DecreasePrecision.Text = "Decrease Precision"
        '
        'CurveFitter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CurveChart)
        Me.Name = "CurveFitter"
        Me.Size = New System.Drawing.Size(835, 493)
        CType(Me.CurveChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CurveChart As DataVisualization.Charting.Chart
    Friend WithEvents MenuStrip As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem_IncreasePrecision As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_DecreasePrecision As ToolStripMenuItem
End Class
