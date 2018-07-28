Imports CurveFitter.CurveFunctions
Imports System.Windows.Forms.DataVisualization.Charting

Public Class CurveFitter

    Private MaxPoints As Integer = 20

    Private SelectedPoint As DataPoint = Nothing
    Private SelectedPointIndex As Integer = -1
    Private IsDraggingPoint As Boolean = False
    Private IsMultiDragging As Boolean = False
    Private _LiveFitting As Boolean = False
    Private MultiDragButton As MouseButtons = MouseButtons.Middle

    Public Property MultiDragFactor As Double = 0.3

    Private _MinX As Double = 0
    Private _MaxX As Double = 100
    Private _MinY As Double = 0
    Private _MaxY As Double = 25
    Public Property MinX As Double
        Get
            Return _MinX
        End Get
        Set(value As Double)
            _MinX = value
            CurveChart.ChartAreas(0).AxisX.Minimum = _MinX
        End Set
    End Property
    Public Property MaxX As Double
        Get
            Return _MaxX
        End Get
        Set(value As Double)
            _MaxX = value
            CurveChart.ChartAreas(0).AxisX.Maximum = _MaxX
        End Set
    End Property
    Public Property MinY As Double
        Get
            Return _MinY
        End Get
        Set(value As Double)
            _MinY = value
            CurveChart.ChartAreas(0).AxisY.Minimum = _MinY
        End Set
    End Property
    Public Property MaxY As Double
        Get
            Return _MaxY
        End Get
        Set(value As Double)
            _MaxY = value
            CurveChart.ChartAreas(0).AxisY.Maximum = _MaxY
        End Set
    End Property

    Private _CurveMarkerColor As Color = Color.Red
    Private _CurveLineColor As Color = Color.DodgerBlue
    Private _FittingLineColor As Color = Color.Orange
    Private _DotsOnly As Boolean = False
    Public Property CurveMarkerColor As Color
        Get
            Return _CurveMarkerColor
        End Get
        Set(value As Color)
            _CurveMarkerColor = value
            CurveChart.Series(0).MarkerColor = _CurveMarkerColor
        End Set
    End Property
    Public Property CurveLineColor As Color
        Get
            Return _CurveLineColor
        End Get
        Set(value As Color)
            _CurveLineColor = value
            CurveChart.Series(0).Color = _CurveLineColor
        End Set
    End Property
    Public Property FittingLineColor As Color
        Get
            Return _FittingLineColor
        End Get
        Set(value As Color)
            _FittingLineColor = value
            CurveChart.Series(1).Color = _FittingLineColor
        End Set
    End Property
    Public Property DotsOnly As Boolean
        Get
            Return _DotsOnly
        End Get
        Set(value As Boolean)
            _DotsOnly = value
            If _DotsOnly Then
                CurveChart.Series(0).BorderWidth = 0
            Else
                CurveChart.Series(0).BorderWidth = 5
            End If
        End Set
    End Property

    Private _CurveFittingDegrees As Integer = 10
    Public Property CurveFittingDegrees As Integer
        Get
            Return _CurveFittingDegrees
        End Get
        Set(value As Integer)
            _CurveFittingDegrees = value
            If LiveFitting Then
                FitCurve()
            End If
        End Set
    End Property
    Public Property PolynomialCoefficients As New List(Of Double)
    Public Property LiveFitting As Boolean
        Get
            Return _LiveFitting
        End Get
        Set(value As Boolean)
            _LiveFitting = value
            If _LiveFitting Then
                FitCurve()
            Else
                PolynomialCoefficients = New List(Of Double)
                CurveChart.Series(1).Points.Clear()
            End If
        End Set
    End Property

    Private Sub CurveChart_MouseDown(sender As Object, e As MouseEventArgs) Handles CurveChart.MouseDown
        If (e.Button.HasFlag(MouseButtons.Left) Or e.Button.HasFlag(MultiDragButton)) Then
            If e.Button.HasFlag(MultiDragButton) Then
                IsMultiDragging = True
            End If
            Dim HitResult As HitTestResult = CurveChart.HitTest(e.X, e.Y)
            If HitResult.PointIndex >= 0 Then
                SelectedPoint = HitResult.Series.Points(HitResult.PointIndex)
                SelectedPointIndex = HitResult.PointIndex
                IsDraggingPoint = True
            Else
                IsDraggingPoint = False
            End If
        End If
        If e.Button.HasFlag(MouseButtons.Right) Then

        End If
    End Sub

    Private Sub CurveChart_MouseUp(sender As Object, e As MouseEventArgs) Handles CurveChart.MouseUp
        SelectedPoint = Nothing
        SelectedPointIndex = -1
        IsDraggingPoint = False
        IsMultiDragging = False
    End Sub

    Private Sub CurveChart_MouseMove(sender As Object, e As MouseEventArgs) Handles CurveChart.MouseMove
        If IsDraggingPoint And SelectedPoint IsNot Nothing Then
            Dim NewY As Double = SelectedPoint.YValues(0)
            Try
                NewY = CurveChart.ChartAreas(0).AxisY.PixelPositionToValue(e.Y)
            Catch
            End Try
            Dim dY As Double = NewY - SelectedPoint.YValues(0)
            SelectedPoint.XValue = SelectedPoint.XValue
            If IsMultiDragging Then
                For Index As Integer = 0 To CurveChart.Series(0).Points.Count - 1
                    Dim TmpSelectedPoint = CurveChart.Series(0).Points(Index)
                    Dim Distance As Double = Math.Abs(Index - SelectedPointIndex)
                    Dim Factor As Double = MultiDragFactor ^ Distance
                    NewY = Factor * dY + TmpSelectedPoint.YValues(0)
                    If NewY >= MinY And NewY <= MaxY Then
                        TmpSelectedPoint.SetValueY(NewY)
                    End If
                Next
            Else
                If NewY >= MinY And NewY <= MaxY Then
                    SelectedPoint.SetValueY(NewY)
                End If
            End If
            If LiveFitting Then
                FitCurve()
            End If
        End If
    End Sub

    Public Sub FitCurve()
        Dim DataPoints As New List(Of PointF)
        For Each ChartPoint As DataPoint In CurveChart.Series(0).Points
            DataPoints.Add(New PointF(ChartPoint.XValue, ChartPoint.YValues(0)))
        Next
        PolynomialCoefficients.Clear()
        PolynomialCoefficients.AddRange(FindPolynomialLeastSquaresFit(DataPoints, CurveFittingDegrees))
        CurveChart.Series(1).Points.Clear()
        For Index As Integer = MinX To MaxX
            CurveChart.Series(1).Points.AddXY(Index, PolynomialFunction(PolynomialCoefficients, Index))
        Next
    End Sub

    Public Sub Reset()
        Clear()
        IsDraggingPoint = False
        IsMultiDragging = False
        SelectedPoint = Nothing
        SelectedPointIndex = -1
        _MinX = 0
        _MaxX = 100
        _MinY = 0
        _MaxY = 25
    End Sub

    Public Sub Clear()
        PolynomialCoefficients.Clear()
        CurveChart.Series(0).Points.Clear()
        CurveChart.Series(1).Points.Clear()
    End Sub

    Public Sub DoublePrecision()
        Dim Points As DataPointCollection = CurveChart.Series(0).Points
        Dim Count As Integer = Points.Count
        If Count < MaxPoints / 2 Then
            For Index As Integer = 1 To Count - 1
                Dim X = (Points(2 * Index - 2).XValue + Points(2 * Index - 1).XValue) / 2
                Dim Y As Double = (Points(2 * Index - 2).YValues(0) + Points(2 * Index - 1).YValues(0)) / 2
                CurveChart.Series(0).Points.InsertXY(2 * Index - 1, X, Y)
            Next
            If LiveFitting Then
                FitCurve()
            End If
        End If
    End Sub

    Public Sub HalfPrecision()
        Dim Points As DataPointCollection = CurveChart.Series(0).Points
        Dim Count As Integer = Points.Count
        If Count > 6 Then
            For Index As Integer = 1 To Math.Floor(Count / 2)
                CurveChart.Series(0).Points.RemoveAt(Index)
            Next
            If _LiveFitting Then
                FitCurve()
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem_IncreasePrecision_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_IncreasePrecision.Click
        DoublePrecision()
    End Sub

    Private Sub ToolStripMenuItem_DecreasePrecision_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_DecreasePrecision.Click
        HalfPrecision()
    End Sub

    Private Sub CurveFitter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LiveFitting = True
        DotsOnly = True
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class