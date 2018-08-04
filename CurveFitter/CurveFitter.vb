Imports CurveFitter.CurveFunctions
Imports System.Windows.Forms.DataVisualization.Charting

Public Enum GraphType
    Linear
    Exponential
    Logarithmic
End Enum

Public Class CurveFitter

    Private MaxPoints As Integer = 20

    'Public Property Equation As String
    '    Get
    '        Return GetEquation()
    '    End Get
    '    Set(value As String)

    '    End Set
    'End Property

#Region "Properties"
    Private _LiveFitting As Boolean = False
    Private _CurveType As GraphType = GraphType.Logarithmic
    Private _MaxX As Double = 100
    Private _MaxY As Double = 25
    Private _CurveMarkerColor As Color = Color.Red
    Private _CurveLineColor As Color = Color.DodgerBlue
    Private _FittingLineColor As Color = Color.Orange
    Private _DotsOnly As Boolean = False
    Private _CurveFittingDegrees As Integer = 10
    Private _PolynomialCoefficients As New List(Of Double)
    Private _AutoSelectedDegrees As Integer = 7

    Public Property MultiDragFactor As Double = 0.3
    Public Property UseSinglePrecision As Boolean = False
    Public Property AutoSelectDegrees As Boolean = True
    Public Property MinDegrees As Integer = 5
    Public Property MaxDegrees As Integer = 15

    Public Property CurveType As GraphType
        Get
            Return _CurveType
        End Get
        Set(value As GraphType)
            _CurveType = value
            AddInitialDots(_CurveType)
        End Set
    End Property
    Public Property MaxX As Double
        Get
            Return _MaxX
        End Get
        Set(value As Double)
            _MaxX = value
            CurveChart.ChartAreas(0).AxisX.Maximum = _MaxX
            AddInitialDots(GraphType.Logarithmic)
        End Set
    End Property
    Public Property MaxY As Double
        Get
            Return _MaxY
        End Get
        Set(value As Double)
            _MaxY = value
            CurveChart.ChartAreas(0).AxisY.Maximum = _MaxY
            AddInitialDots(GraphType.Logarithmic)
        End Set
    End Property
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
    Public Property XAxisTitle As String
        Get
            Return CurveChart.ChartAreas(0).AxisX.Title
        End Get
        Set(value As String)
            CurveChart.ChartAreas(0).AxisX.Title = value
        End Set
    End Property
    Public Property YAxisTitle As String
        Get
            Return CurveChart.ChartAreas(0).AxisY.Title
        End Get
        Set(value As String)
            CurveChart.ChartAreas(0).AxisY.Title = value
        End Set
    End Property
    Public Property CurveFittingDegrees As Integer
        Get
            Return _CurveFittingDegrees
        End Get
        Set(value As Integer)
            _CurveFittingDegrees = value
            If LiveFitting Then
                FitCurve(_CurveFittingDegrees)
            End If
        End Set
    End Property
    Public Property PolynomialCoefficients As List(Of Double)
        Get
            If UseSinglePrecision Then
                Return SingleToDoubleList(DoubleToSingleList(_PolynomialCoefficients))
            Else
                Return _PolynomialCoefficients
            End If
        End Get
        Set(value As List(Of Double))
            _PolynomialCoefficients = value
        End Set
    End Property
    Public Property LiveFitting As Boolean
        Get
            Return _LiveFitting
        End Get
        Set(value As Boolean)
            _LiveFitting = value
            If _LiveFitting Then
                FitCurve(If(AutoSelectDegrees, AutoTuneDegrees(), _CurveFittingDegrees))
            Else
                _PolynomialCoefficients = New List(Of Double)
                CurveChart.Series(1).Points.Clear()
            End If
        End Set
    End Property
#End Region

#Region "PointDragging"
    Private MultiDragButton As MouseButtons = MouseButtons.Middle
    Private SelectedPoint As DataPoint = Nothing
    Private SelectedPointIndex As Integer = -1
    Private IsDraggingPoint As Boolean = False
    Private IsMultiDragging As Boolean = False

    Private Sub CurveChart_MouseDown(sender As Object, e As MouseEventArgs) Handles CurveChart.MouseDown
        Try
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
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CurveChart_MouseUp(sender As Object, e As MouseEventArgs) Handles CurveChart.MouseUp
        SelectedPoint = Nothing
        SelectedPointIndex = -1
        IsDraggingPoint = False
        IsMultiDragging = False
        If AutoSelectDegrees Then
            FitCurve(AutoTuneDegrees())
        End If
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
                    If NewY >= 0 And NewY <= MaxY Then
                        TmpSelectedPoint.SetValueY(NewY)
                    End If
                Next
            Else
                If NewY >= 0 And NewY <= MaxY Then
                    SelectedPoint.SetValueY(NewY)
                End If
            End If
            If LiveFitting Then
                FitCurve(_CurveFittingDegrees)
            End If
        End If
    End Sub
#End Region


    Public Sub FitCurve(ByVal Degrees As Integer)
        _CurveFittingDegrees = Degrees
        Dim DataPoints As New List(Of PointF)
        For Each ChartPoint As DataPoint In CurveChart.Series(0).Points
            DataPoints.Add(New PointF(ChartPoint.XValue, ChartPoint.YValues(0)))
        Next
        _PolynomialCoefficients.Clear()
        _PolynomialCoefficients.AddRange(FindPolynomialLeastSquaresFit(DataPoints, Degrees))
        CurveChart.Series(1).Points.Clear()
        For Index As Integer = 0 To MaxX
            CurveChart.Series(1).Points.AddXY(Index, PolynomialFunction(_PolynomialCoefficients, Index))
        Next
    End Sub

    Public Sub Reset()
        Clear()
        IsDraggingPoint = False
        IsMultiDragging = False
        SelectedPoint = Nothing
        SelectedPointIndex = -1
        _MaxX = 100
        _MaxY = 25
    End Sub

    Public Sub Clear()
        _PolynomialCoefficients.Clear()
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
                FitCurve(_CurveFittingDegrees)
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
                FitCurve(_CurveFittingDegrees)
            End If
        End If
    End Sub

    Public Function AutoTuneDegrees() As Integer
        Dim BestDegree As Integer = -1
        Dim MinError As Double = Math.Pow(10, 35)
        Dim DataPoints As New List(Of PointF)
        For Each ChartPoint As DataPoint In CurveChart.Series(0).Points
            DataPoints.Add(New PointF(ChartPoint.XValue, ChartPoint.YValues(0)))
        Next
        Dim LinearError As Double = ErrorSquared(DataPoints, FindPolynomialLeastSquaresFit(DataPoints, 1))
        For Degree As Integer = MinDegrees To MaxDegrees
            Dim ErrorValue As Double = Math.Abs(LinearError - ErrorSquared(DataPoints, FindPolynomialLeastSquaresFit(DataPoints, Degree)) * Math.Pow(10, 28))
            If ErrorValue < MinError Then
                BestDegree = Degree
                MinError = ErrorValue
            End If
        Next
        If BestDegree = -1 Then
            Throw New Exception("Error too big. Please evaluate.")
        End If
        Return BestDegree
    End Function

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

    Private Sub AddInitialDots(ByVal Optional Type As GraphType = GraphType.Linear, ByVal Optional Dots As Integer = 5)
        CurveChart.Series(0).Points.Clear()
        Select Case Type
            Case GraphType.Linear
                For Index As Integer = 0 To Dots
                    CurveChart.Series(0).Points.AddXY(CurveChart.ChartAreas(0).AxisX.Maximum * Index / Dots, CurveChart.ChartAreas(0).AxisY.Maximum * Index / Dots)
                Next
            Case GraphType.Exponential
                CurveChart.Series(0).Points.AddXY(0, 0)
                Dim l As Double = Math.Log(CurveChart.ChartAreas(0).AxisY.Maximum + 1) / Dots
                For Index As Integer = 1 To Dots
                    CurveChart.Series(0).Points.AddXY(CurveChart.ChartAreas(0).AxisX.Maximum * Index / Dots, Math.Pow(Math.E, l * Index) - 1)
                Next
            Case GraphType.Logarithmic
                CurveChart.Series(0).Points.AddXY(0, 0)
                Dim n As Double = 1.18
                Dim l As Double = Dots / (Math.Pow(n, CurveChart.ChartAreas(0).AxisY.Maximum) - 1)
                Dim d As Double = -1 * Math.Log(l, n)
                CurveChart.Series(0).Points.AddXY(CurveChart.ChartAreas(0).AxisX.Maximum * 1 / Dots, (Math.Log(1 + l, n) + d) * 0.915)
                For Index As Integer = 2 To Dots
                    CurveChart.Series(0).Points.AddXY(CurveChart.ChartAreas(0).AxisX.Maximum * Index / Dots, Math.Log(Index + l, n) + d)
                Next
        End Select
        FitCurve(If(AutoTuneDegrees(), AutoTuneDegrees(), _CurveFittingDegrees))
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        AddInitialDots(GraphType.Logarithmic)
    End Sub

#Region "Text"
    Public Function NumberToSuperScript(ByVal Number As Char) As String
        Select Case Number
            Case "0"
                Return "⁰"
            Case "1"
                Return "¹"
            Case "2"
                Return "²"
            Case "3"
                Return "³"
            Case "4"
                Return "⁴"
            Case "5"
                Return "⁵"
            Case "6"
                Return "⁶"
            Case "7"
                Return "⁷"
            Case "8"
                Return "⁸"
            Case "9"
                Return "⁹"
        End Select
        Return ""
    End Function

    Public Function PowerToText(ByVal Power As Integer) As String
        Dim Result As String = ""
        For Each Number As Char In Power.ToString
            Result &= NumberToSuperScript(Number)
        Next
        Return Result
    End Function

    'Public Property Equation As String
    '    Get
    '        Return GetEquation()
    '    End Get
    '    Set(value As String)

    '    End Set
    'End Property

    Public Function GetEquation() As String
        Dim Result As String = ""
        For Index As Integer = 0 To _PolynomialCoefficients.Count - 3
            Result &= "x" & PowerToText(Index) & " + "
        Next
        Result &= _PolynomialCoefficients(_PolynomialCoefficients.Count - 2).ToString & " + "
        Result &= _PolynomialCoefficients(_PolynomialCoefficients.Count - 1).ToString
        Return Result
    End Function
#End Region

    Private Function DoubleToSingleList(ByVal List As List(Of Double)) As List(Of Single)
        Dim Result As New List(Of Single)
        For Each Item As Double In List
            Result.Add(Item)
        Next
        Return Result
    End Function

    Private Function SingleToDoubleList(ByVal List As List(Of Single)) As List(Of Double)
        Dim Result As New List(Of Double)
        For Each Item As Single In List
            Result.Add(Item)
        Next
        Return Result
    End Function

    Public Function ExportCCode()
        Dim Result As String = "const double PolynomialCoefficients[" & _PolynomialCoefficients.Count & "] = {"
        Dim Row As Integer = 0
        Dim SingleList As List(Of Single) = DoubleToSingleList(_PolynomialCoefficients)
        For Each Item As Single In SingleList
            Result &= Item.ToString & ", "
            Row += 1
            If Row = 3 Then
                Result &= vbNewLine & vbTab & vbTab & vbTab & vbTab & vbTab
                Row = 0
            End If
        Next
        Result = Result.Substring(0, Result.Length - 2)
        Result &= "}" & vbNewLine & vbNewLine
        Result &= "double Polynomial(double x) {" & vbNewLine
        Result &= vbTab & "double total = 0;" & vbNewLine
        Result &= vbTab & "double x_factor = 1;" & vbNewLine
        Result &= vbTab & "for (int i = 0; i < sizeof(PolynomialCoefficients)/sizeof(double) - 1; i++) {" & vbNewLine
        Result &= vbTab & vbTab & "total += x_factor * PolynomialCoefficients[i];" & vbNewLine
        Result &= vbTab & vbTab & "x_factor *= x;" & vbNewLine
        Result &= vbTab & "}" & vbNewLine
        Dim MaxY As Double = CurveChart.ChartAreas(0).AxisY.Maximum
        Dim MinY As Double = CurveChart.ChartAreas(0).AxisY.Minimum
        Result &= vbTab & "if (total > " & MaxX.ToString & ") { total = " & MaxX.ToString & "; }" & vbNewLine
        Result &= vbTab & "if (total < 0) { total = 0; }" & vbNewLine
        Result &= vbTab & "return total;" & vbNewLine
        Result &= "}"
        Return Result
    End Function

End Class