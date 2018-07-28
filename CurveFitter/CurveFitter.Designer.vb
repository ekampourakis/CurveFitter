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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint7 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 3.0R)
        Dim DataPoint8 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(20.0R, 8.5R)
        Dim DataPoint9 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(40.0R, 20.5R)
        Dim DataPoint10 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(60.0R, 22.7R)
        Dim DataPoint11 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(80.0R, 23.7R)
        Dim DataPoint12 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(100.0R, 25.0R)
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        ChartArea2.AxisX.Maximum = 100.0R
        ChartArea2.AxisX.Minimum = 0R
        ChartArea2.AxisY.Maximum = 25.0R
        ChartArea2.AxisY.Minimum = 0R
        ChartArea2.Name = "Main"
        Me.CurveChart.ChartAreas.Add(ChartArea2)
        Me.CurveChart.ContextMenuStrip = Me.MenuStrip
        Me.CurveChart.Location = New System.Drawing.Point(3, 3)
        Me.CurveChart.Name = "CurveChart"
        Series3.BorderWidth = 5
        Series3.ChartArea = "Main"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.CustomProperties = "IsXAxisQuantitative=False"
        Series3.MarkerBorderWidth = 0
        Series3.MarkerColor = System.Drawing.Color.Red
        Series3.MarkerSize = 20
        Series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series3.Name = "Curve"
        Series3.Points.Add(DataPoint7)
        Series3.Points.Add(DataPoint8)
        Series3.Points.Add(DataPoint9)
        Series3.Points.Add(DataPoint10)
        Series3.Points.Add(DataPoint11)
        Series3.Points.Add(DataPoint12)
        Series4.BorderColor = System.Drawing.Color.Red
        Series4.BorderWidth = 5
        Series4.ChartArea = "Main"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Name = "Polynomial"
        Me.CurveChart.Series.Add(Series3)
        Me.CurveChart.Series.Add(Series4)
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
        Me.ToolStripMenuItem_IncreasePrecision.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem_IncreasePrecision.Text = "Increase Precision"
        '
        'ToolStripMenuItem_DecreasePrecision
        '
        Me.ToolStripMenuItem_DecreasePrecision.Name = "ToolStripMenuItem_DecreasePrecision"
        Me.ToolStripMenuItem_DecreasePrecision.Size = New System.Drawing.Size(180, 22)
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
