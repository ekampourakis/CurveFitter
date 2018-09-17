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
        Dim StripLine1 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.CurveChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem_IncreasePrecision = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_DecreasePrecision = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CurveColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DotColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.LiveCurveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.CurveChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CurveChart
        '
        ChartArea1.AxisX.Interval = 10.0R
        ChartArea1.AxisX.IntervalOffset = 5.0R
        ChartArea1.AxisX.MajorGrid.Interval = 20.0R
        ChartArea1.AxisX.MajorTickMark.Interval = 10.0R
        ChartArea1.AxisX.MajorTickMark.Size = 2.0!
        ChartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea1.AxisX.Maximum = 105.0R
        ChartArea1.AxisX.Minimum = -5.0R
        ChartArea1.AxisX.MinorGrid.Enabled = True
        ChartArea1.AxisX.MinorGrid.Interval = 5.0R
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisX.MinorTickMark.Enabled = True
        ChartArea1.AxisX.MinorTickMark.Interval = 5.0R
        ChartArea1.AxisX.Title = "Input %"
        ChartArea1.AxisY.Interval = 10.0R
        ChartArea1.AxisY.IntervalOffset = 10.0R
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.MajorGrid.Interval = 20.0R
        ChartArea1.AxisY.MajorTickMark.Interval = 10.0R
        ChartArea1.AxisY.MajorTickMark.Size = 2.0!
        ChartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea
        ChartArea1.AxisY.Maximum = 120.0R
        ChartArea1.AxisY.Minimum = -10.0R
        ChartArea1.AxisY.MinorGrid.Enabled = True
        ChartArea1.AxisY.MinorGrid.Interval = 5.0R
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisY.MinorTickMark.Enabled = True
        ChartArea1.AxisY.MinorTickMark.Interval = 5.0R
        StripLine1.Interval = 10.0R
        ChartArea1.AxisY.StripLines.Add(StripLine1)
        ChartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea1.AxisY.Title = "Output %"
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.Name = "Main"
        Me.CurveChart.ChartAreas.Add(ChartArea1)
        Me.CurveChart.ContextMenuStrip = Me.MenuStrip
        Me.CurveChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurveChart.Location = New System.Drawing.Point(0, 0)
        Me.CurveChart.Name = "CurveChart"
        Series1.BorderColor = System.Drawing.Color.Red
        Series1.BorderWidth = 5
        Series1.ChartArea = "Main"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.Orange
        Series1.Legend = "Legend1"
        Series1.Name = "Polynomial"
        Series1.ToolTip = "X=#VALX{N5}, Y=#VAL{N5}"
        Series2.BorderWidth = 6
        Series2.ChartArea = "Main"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint
        Series2.CustomProperties = "IsXAxisQuantitative=False"
        Series2.Legend = "Legend1"
        Series2.MarkerBorderWidth = 0
        Series2.MarkerColor = System.Drawing.Color.Red
        Series2.MarkerSize = 20
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series2.Name = "Curve"
        Series2.ToolTip = "X=#VALX{N5}, Y=#VAL{N5}"
        Me.CurveChart.Series.Add(Series1)
        Me.CurveChart.Series.Add(Series2)
        Me.CurveChart.Size = New System.Drawing.Size(835, 493)
        Me.CurveChart.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_IncreasePrecision, Me.ToolStripMenuItem_DecreasePrecision, Me.ToolStripSeparator1, Me.CurveColorToolStripMenuItem, Me.DotColorToolStripMenuItem, Me.BackColorToolStripMenuItem, Me.ToolStripSeparator2, Me.LiveCurveToolStripMenuItem})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(181, 170)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'CurveColorToolStripMenuItem
        '
        Me.CurveColorToolStripMenuItem.Name = "CurveColorToolStripMenuItem"
        Me.CurveColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CurveColorToolStripMenuItem.Text = "Curve Color"
        '
        'DotColorToolStripMenuItem
        '
        Me.DotColorToolStripMenuItem.Name = "DotColorToolStripMenuItem"
        Me.DotColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DotColorToolStripMenuItem.Text = "Dot Color"
        '
        'BackColorToolStripMenuItem
        '
        Me.BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem"
        Me.BackColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BackColorToolStripMenuItem.Text = "Back Color"
        '
        'ColorDialog
        '
        Me.ColorDialog.AnyColor = True
        Me.ColorDialog.FullOpen = True
        '
        'LiveCurveToolStripMenuItem
        '
        Me.LiveCurveToolStripMenuItem.Name = "LiveCurveToolStripMenuItem"
        Me.LiveCurveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LiveCurveToolStripMenuItem.Text = "Live Curve"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
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
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CurveColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DotColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents BackColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents LiveCurveToolStripMenuItem As ToolStripMenuItem
End Class
