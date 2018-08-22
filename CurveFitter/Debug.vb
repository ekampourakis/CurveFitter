Imports System.Windows.Forms.DataVisualization.Charting

Public Class Debug
    Private Sub Debug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_CurveType.SelectedIndex = 2
    End Sub

    Private Sub ComboBox_CurveType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_CurveType.SelectedIndexChanged
        Select Case ComboBox_CurveType.SelectedIndex
            Case 0
                Curve.CurveType = GraphType.Linear
            Case 1
                Curve.CurveType = GraphType.Exponential
            Case 2
                Curve.CurveType = GraphType.Logarithmic
        End Select
    End Sub

    Private Sub Curve_CurveUpdated(sender As Object, e As EventArgs) Handles Curve.CurveUpdated

    End Sub

    Private Sub Button_ExportCode_Click(sender As Object, e As EventArgs) Handles Button_ExportCode.Click
        Clipboard.SetText(Curve.ExportCCode(False))
        MsgBox("Code copied to clipboard.", MsgBoxStyle.Information, "Success")
    End Sub

    Private Sub Button_ExportEquation_Click(sender As Object, e As EventArgs) Handles Button_ExportEquation.Click
        Clipboard.SetText(Curve.GetEquation())
        MsgBox("Equation copied to clipboard.", MsgBoxStyle.Information, "Success")
    End Sub

    Private Sub Button_ExportCurve_Click(sender As Object, e As EventArgs) Handles Button_ExportCurve.Click
        SaveFileDialog.ShowDialog()
        If SaveFileDialog.FileName <> "" Then
            Dim Writer As New IO.StreamWriter(If(SaveFileDialog.FileName.EndsWith(".curve"), SaveFileDialog.FileName, SaveFileDialog.FileName & ".curve"))
            Dim Points As DataPointCollection
            Points = Curve.ExportPoints()
            For Each Point As DataPoint In Points
                Writer.WriteLine(Point.XValue.ToString & "|" & Point.YValues(0).ToString)
            Next
            Writer.Close()
            Writer.Dispose()
        End If
    End Sub

    Private Sub Button_LoadCurve_Click(sender As Object, e As EventArgs) Handles Button_LoadCurve.Click
        OpenFileDialog.ShowDialog()
        If OpenFileDialog.FileName <> "" Then
            Dim Reader As New IO.StreamReader(OpenFileDialog.FileName)
            Dim Line As String = ""
            Dim Points As New List(Of DataPoint)
            Do
                Line = Reader.ReadLine()
                If Line <> "" Then
                    Dim Tmp As String() = Line.Split("|")
                    Points.Add(New DataPoint(CDbl(Tmp(0)), CDbl(Tmp(1))))
                End If
            Loop Until Line Is Nothing
            Curve.LoadPoints(Points)
            Reader.Dispose()
        End If
    End Sub
End Class