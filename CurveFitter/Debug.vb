Imports System.Windows.Forms.DataVisualization.Charting
Imports CurveFitter.CurveFitter

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
            Case 3
                Curve.CurveType = GraphType.Empty
        End Select
    End Sub

    Private Sub Curve_CurveUpdated(sender As Object, e As EventArgs) Handles Curve.CurveUpdated

    End Sub

    Private Sub Button_ExportCode_Click(sender As Object, e As EventArgs) Handles Button_ExportCode.Click
        Clipboard.SetText(Curve.ExportCCode())
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

    Private Function IsDecimal(ByVal Data As Char, ByVal Text As String) As Boolean
        Return Not (Char.IsDigit(Data) Or Asc(Data) = 8 Or ((Data = "." Or Data = ",") And (Text.IndexOf(".") = -1 And Text.IndexOf(",") = -1)))
    End Function

    Private Sub TextBox_X_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_X.KeyPress
        e.Handled = IsDecimal(e.KeyChar, sender.Text)
    End Sub

    Private Sub TextBox_Y_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Y.KeyPress
        e.Handled = IsDecimal(e.KeyChar, sender.Text)
    End Sub

    Private Sub Button_Insert_Click(sender As Object, e As EventArgs) Handles Button_Insert.Click
        If TextBox_X.Text <> Nothing And TextBox_Y.Text <> Nothing Then
            Curve.InsertPoint(New DataPoint(Convert.ToDouble(TextBox_X.Text), Convert.ToDouble(TextBox_Y.Text)))
        End If
    End Sub

    Private Sub Button_RemoveX_Click(sender As Object, e As EventArgs) Handles Button_RemoveX.Click
        If TextBox_X.Text <> Nothing Then
            Curve.RemovePointAt(Convert.ToDouble(TextBox_X.Text))
        End If
    End Sub

    Private Sub TextBox_YMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_YMax.KeyPress
        e.Handled = IsDecimal(e.KeyChar, sender.Text)
    End Sub

    Private Sub TextBox_XMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_XMax.KeyPress
        e.Handled = IsDecimal(e.KeyChar, sender.Text)
    End Sub

    Private Sub TextBox_DesiredX_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DesiredX.TextChanged
        TextBox_XPercent.Text = CDbl(TextBox_DesiredX.Text) * 100.0 / CDbl(TextBox_XMax.Text)
    End Sub

    Private Sub TextBox_DesiredY_TextChanged(sender As Object, e As EventArgs) Handles TextBox_DesiredY.TextChanged
        TextBox_YPercent.Text = CDbl(TextBox_DesiredY.Text) * 100.0 / CDbl(TextBox_YMax.Text)
    End Sub

    Private Sub TextBox_DesiredX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_DesiredX.KeyPress
        e.Handled = IsDecimal(e.KeyChar, sender.Text)
    End Sub

    Private Sub TextBox_DesiredY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_DesiredY.KeyPress
        e.Handled = IsDecimal(e.KeyChar, sender.Text)
    End Sub
End Class