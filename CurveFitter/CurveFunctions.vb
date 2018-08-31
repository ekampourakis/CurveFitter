Public Class CurveFunctions

    Public Shared Function PolynomialFunction(ByVal Coefficients As List(Of Double), ByVal X As Double) As Double
        Dim Total As Double = 0
        Dim X_Factor As Double = 1
        For Index As Integer = 0 To Coefficients.Count - 1
            Total += X_Factor * Coefficients(Index)
            X_Factor *= X
        Next
        Return Total
    End Function

    Public Shared Function ErrorSquared(ByVal DataPoints As List(Of PointF), ByVal Coefficients As List(Of Double)) As Double
        Dim Total As Double = 0
        For Each Point As PointF In DataPoints
            Dim dY As Double = Point.Y - PolynomialFunction(Coefficients, Point.X)
            Total += dY * dY
        Next
        Return Total
    End Function

    Private Shared Function GaussianElimination(ByVal Coefficients(,) As Double) As Double()
        Dim MaxEquation As Integer = Coefficients.GetUpperBound(0)
        Dim MaxCoefficient As Integer = Coefficients.GetUpperBound(1)
        For Index As Integer = 0 To MaxEquation
            ' Use equation_coeffs(i, i) to eliminate the ith
            '   coefficient in all of the other equations.
            ' Find a row with non-zero ith coefficient.
            If (Coefficients(Index, Index) = 0) Then
                For j As Integer = Index + 1 To MaxEquation
                    ' See if this one works.
                    If (Coefficients(j, Index) <> 0) Then
                        ' This one works. Swap equations i and j.
                        ' This starts at k = i because all
                        ' coefficients to the left are 0.
                        For k As Integer = Index To MaxCoefficient
                            Dim temp As Double = Coefficients(Index, k)
                            Coefficients(Index, k) = Coefficients(j, k)
                            Coefficients(j, k) = temp
                        Next
                        Exit For
                    End If
                Next
            End If
            ' Make sure we found an equation with
            ' a non-zero ith coefficient.
            Dim coeff_i_i As Double = Coefficients(Index, Index)
            If coeff_i_i = 0 Then
                Throw New ArithmeticException(String.Format(
                    "There is no unique solution for these points.",
                    Coefficients.GetUpperBound(0) - 1))
            End If
            ' Normalize the ith equation.
            For j As Integer = Index To MaxCoefficient
                Coefficients(Index, j) /= coeff_i_i
            Next
            ' Use this equation value to zero out
            ' the other equations' ith coefficients.
            For j As Integer = 0 To MaxEquation
                ' Skip the ith equation.
                If (j <> Index) Then
                    ' Zero the jth equation's ith coefficient.
                    Dim coef_j_i As Double = Coefficients(j, Index)
                    For d As Integer = 0 To MaxCoefficient
                        Coefficients(j, d) -= Coefficients(Index, d) * coef_j_i
                    Next
                End If
            Next
        Next
        ' At this point, the ith equation contains
        ' 2 non-zero entries:
        '      The ith entry which is 1
        '      The last entry coeffs(max_coeff)
        ' This means Ai = equation_coef(max_coeff).
        Dim solution(MaxEquation) As Double
        For i As Integer = 0 To MaxEquation
            solution(i) = Coefficients(i, MaxCoefficient)
        Next
        ' Return the solution values.
        Return solution
    End Function

    Public Shared Function FindPolynomialLeastSquaresFit(ByVal points As List(Of PointF), ByVal degree As Integer) As List(Of Double)
        ' Allocate space for (degree + 1) equations with 
        ' (degree + 2) terms each (including the constant term).
        Dim coeffs(degree, degree + 1) As Double
        ' Calculate the coefficients for the equations.
        For j As Integer = 0 To degree
            ' Calculate the coefficients for the jth equation.
            ' Calculate the constant term for this equation.
            coeffs(j, degree + 1) = 0
            For Each pt As PointF In points
                coeffs(j, degree + 1) -= Math.Pow(pt.X, j) *
                    pt.Y
            Next
            ' Calculate the other coefficients.
            For a_sub As Integer = 0 To degree
                ' Calculate the dth coefficient.
                coeffs(j, a_sub) = 0
                For Each pt As PointF In points
                    coeffs(j, a_sub) -= Math.Pow(pt.X, a_sub + j)
                Next
            Next
        Next

        Try
            ' Solve the equations.
            Dim answer() As Double = GaussianElimination(coeffs)
            ' Return the result converted into a List(Of Double).
            Return answer.ToList()
        Catch ex As Exception
            Return {0.0, 0.0}.ToList
        End Try
    End Function

End Class