<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Debug))
        Me.CurveFitter1 = New CurveFitter()
        Me.SuspendLayout()
        '
        'CurveFitter1
        '
        Me.CurveFitter1.CurveFittingDegrees = 10
        Me.CurveFitter1.CurveLineColor = System.Drawing.Color.DodgerBlue
        Me.CurveFitter1.CurveMarkerColor = System.Drawing.Color.Red
        Me.CurveFitter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurveFitter1.DotsOnly = False
        Me.CurveFitter1.FittingLineColor = System.Drawing.Color.Orange
        Me.CurveFitter1.LiveFitting = True
        Me.CurveFitter1.Location = New System.Drawing.Point(0, 0)
        Me.CurveFitter1.MaxX = 100.0R
        Me.CurveFitter1.MaxY = 25.0R
        Me.CurveFitter1.MinX = 0R
        Me.CurveFitter1.MinY = 0R
        Me.CurveFitter1.MultiDragFactor = 0.3R
        Me.CurveFitter1.Name = "CurveFitter1"
        Me.CurveFitter1.PolynomialCoefficients = CType(resources.GetObject("CurveFitter1.PolynomialCoefficients"), System.Collections.Generic.List(Of Double))
        Me.CurveFitter1.Size = New System.Drawing.Size(873, 450)
        Me.CurveFitter1.TabIndex = 0
        '
        'Debug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 450)
        Me.Controls.Add(Me.CurveFitter1)
        Me.Name = "Debug"
        Me.Text = "Debug"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CurveFitter1 As CurveFitter
End Class
