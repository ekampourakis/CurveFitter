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
End Class