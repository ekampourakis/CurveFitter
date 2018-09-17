<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Debug
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Debug))
        Me.GroupBox_Output = New System.Windows.Forms.GroupBox()
        Me.Button_ExportEquation = New System.Windows.Forms.Button()
        Me.Button_ExportCode = New System.Windows.Forms.Button()
        Me.GroupBox_Properties = New System.Windows.Forms.GroupBox()
        Me.Button_RemoveX = New System.Windows.Forms.Button()
        Me.Button_Insert = New System.Windows.Forms.Button()
        Me.TextBox_Y = New System.Windows.Forms.TextBox()
        Me.TextBox_X = New System.Windows.Forms.TextBox()
        Me.Label_InsertPoint = New System.Windows.Forms.Label()
        Me.Label_Y = New System.Windows.Forms.Label()
        Me.Label_X = New System.Windows.Forms.Label()
        Me.Label_CurveType = New System.Windows.Forms.Label()
        Me.ComboBox_CurveType = New System.Windows.Forms.ComboBox()
        Me.TextBox_About = New System.Windows.Forms.TextBox()
        Me.GroupBox_Curve = New System.Windows.Forms.GroupBox()
        Me.Button_ExportCurve = New System.Windows.Forms.Button()
        Me.Button_LoadCurve = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Curve = New CurveFitter()
        Me.GroupBox_Tools = New System.Windows.Forms.GroupBox()
        Me.Label_XMax = New System.Windows.Forms.Label()
        Me.TextBox_XMax = New System.Windows.Forms.TextBox()
        Me.Label_YMax = New System.Windows.Forms.Label()
        Me.TextBox_YMax = New System.Windows.Forms.TextBox()
        Me.Label_XPercent = New System.Windows.Forms.Label()
        Me.Label_YPercent = New System.Windows.Forms.Label()
        Me.TextBox_XPercent = New System.Windows.Forms.TextBox()
        Me.TextBox_YPercent = New System.Windows.Forms.TextBox()
        Me.Label_DesiredX = New System.Windows.Forms.Label()
        Me.Label_DesiredY = New System.Windows.Forms.Label()
        Me.TextBox_DesiredX = New System.Windows.Forms.TextBox()
        Me.TextBox_DesiredY = New System.Windows.Forms.TextBox()
        Me.GroupBox_Output.SuspendLayout()
        Me.GroupBox_Properties.SuspendLayout()
        Me.GroupBox_Curve.SuspendLayout()
        Me.GroupBox_Tools.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Output
        '
        Me.GroupBox_Output.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Output.Controls.Add(Me.Button_ExportEquation)
        Me.GroupBox_Output.Controls.Add(Me.Button_ExportCode)
        Me.GroupBox_Output.Location = New System.Drawing.Point(941, 324)
        Me.GroupBox_Output.Name = "GroupBox_Output"
        Me.GroupBox_Output.Size = New System.Drawing.Size(257, 48)
        Me.GroupBox_Output.TabIndex = 1
        Me.GroupBox_Output.TabStop = False
        Me.GroupBox_Output.Text = "Output"
        '
        'Button_ExportEquation
        '
        Me.Button_ExportEquation.Location = New System.Drawing.Point(157, 19)
        Me.Button_ExportEquation.Name = "Button_ExportEquation"
        Me.Button_ExportEquation.Size = New System.Drawing.Size(94, 23)
        Me.Button_ExportEquation.TabIndex = 1
        Me.Button_ExportEquation.Text = "Export Equation"
        Me.Button_ExportEquation.UseVisualStyleBackColor = True
        '
        'Button_ExportCode
        '
        Me.Button_ExportCode.Location = New System.Drawing.Point(6, 19)
        Me.Button_ExportCode.Name = "Button_ExportCode"
        Me.Button_ExportCode.Size = New System.Drawing.Size(102, 23)
        Me.Button_ExportCode.TabIndex = 0
        Me.Button_ExportCode.Text = "Export Code"
        Me.Button_ExportCode.UseVisualStyleBackColor = True
        '
        'GroupBox_Properties
        '
        Me.GroupBox_Properties.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Properties.Controls.Add(Me.Button_RemoveX)
        Me.GroupBox_Properties.Controls.Add(Me.Button_Insert)
        Me.GroupBox_Properties.Controls.Add(Me.TextBox_Y)
        Me.GroupBox_Properties.Controls.Add(Me.TextBox_X)
        Me.GroupBox_Properties.Controls.Add(Me.Label_InsertPoint)
        Me.GroupBox_Properties.Controls.Add(Me.Label_Y)
        Me.GroupBox_Properties.Controls.Add(Me.Label_X)
        Me.GroupBox_Properties.Controls.Add(Me.Label_CurveType)
        Me.GroupBox_Properties.Controls.Add(Me.ComboBox_CurveType)
        Me.GroupBox_Properties.Location = New System.Drawing.Point(941, 12)
        Me.GroupBox_Properties.Name = "GroupBox_Properties"
        Me.GroupBox_Properties.Size = New System.Drawing.Size(257, 140)
        Me.GroupBox_Properties.TabIndex = 2
        Me.GroupBox_Properties.TabStop = False
        Me.GroupBox_Properties.Text = "Properties"
        '
        'Button_RemoveX
        '
        Me.Button_RemoveX.Location = New System.Drawing.Point(6, 111)
        Me.Button_RemoveX.Name = "Button_RemoveX"
        Me.Button_RemoveX.Size = New System.Drawing.Size(75, 23)
        Me.Button_RemoveX.TabIndex = 11
        Me.Button_RemoveX.Text = "Remove X"
        Me.Button_RemoveX.UseVisualStyleBackColor = True
        '
        'Button_Insert
        '
        Me.Button_Insert.Location = New System.Drawing.Point(176, 111)
        Me.Button_Insert.Name = "Button_Insert"
        Me.Button_Insert.Size = New System.Drawing.Size(75, 23)
        Me.Button_Insert.TabIndex = 10
        Me.Button_Insert.Text = "Insert"
        Me.Button_Insert.UseVisualStyleBackColor = True
        '
        'TextBox_Y
        '
        Me.TextBox_Y.Location = New System.Drawing.Point(130, 85)
        Me.TextBox_Y.MaxLength = 20
        Me.TextBox_Y.Name = "TextBox_Y"
        Me.TextBox_Y.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Y.TabIndex = 9
        '
        'TextBox_X
        '
        Me.TextBox_X.Location = New System.Drawing.Point(6, 85)
        Me.TextBox_X.MaxLength = 20
        Me.TextBox_X.Name = "TextBox_X"
        Me.TextBox_X.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_X.TabIndex = 8
        '
        'Label_InsertPoint
        '
        Me.Label_InsertPoint.AutoSize = True
        Me.Label_InsertPoint.Location = New System.Drawing.Point(3, 56)
        Me.Label_InsertPoint.Name = "Label_InsertPoint"
        Me.Label_InsertPoint.Size = New System.Drawing.Size(63, 13)
        Me.Label_InsertPoint.TabIndex = 7
        Me.Label_InsertPoint.Text = "Insert Point:"
        '
        'Label_Y
        '
        Me.Label_Y.AutoSize = True
        Me.Label_Y.Location = New System.Drawing.Point(127, 69)
        Me.Label_Y.Name = "Label_Y"
        Me.Label_Y.Size = New System.Drawing.Size(17, 13)
        Me.Label_Y.TabIndex = 6
        Me.Label_Y.Text = "Y:"
        '
        'Label_X
        '
        Me.Label_X.AutoSize = True
        Me.Label_X.Location = New System.Drawing.Point(3, 69)
        Me.Label_X.Name = "Label_X"
        Me.Label_X.Size = New System.Drawing.Size(17, 13)
        Me.Label_X.TabIndex = 5
        Me.Label_X.Text = "X:"
        '
        'Label_CurveType
        '
        Me.Label_CurveType.AutoSize = True
        Me.Label_CurveType.Location = New System.Drawing.Point(3, 16)
        Me.Label_CurveType.Name = "Label_CurveType"
        Me.Label_CurveType.Size = New System.Drawing.Size(65, 13)
        Me.Label_CurveType.TabIndex = 4
        Me.Label_CurveType.Text = "Curve Type:"
        '
        'ComboBox_CurveType
        '
        Me.ComboBox_CurveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_CurveType.FormattingEnabled = True
        Me.ComboBox_CurveType.Items.AddRange(New Object() {"Linear", "Exponential", "Logarithmic", "Empty"})
        Me.ComboBox_CurveType.Location = New System.Drawing.Point(6, 32)
        Me.ComboBox_CurveType.Name = "ComboBox_CurveType"
        Me.ComboBox_CurveType.Size = New System.Drawing.Size(245, 21)
        Me.ComboBox_CurveType.TabIndex = 3
        '
        'TextBox_About
        '
        Me.TextBox_About.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_About.Location = New System.Drawing.Point(941, 432)
        Me.TextBox_About.Multiline = True
        Me.TextBox_About.Name = "TextBox_About"
        Me.TextBox_About.ReadOnly = True
        Me.TextBox_About.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_About.Size = New System.Drawing.Size(257, 117)
        Me.TextBox_About.TabIndex = 3
        Me.TextBox_About.Text = resources.GetString("TextBox_About.Text")
        '
        'GroupBox_Curve
        '
        Me.GroupBox_Curve.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Curve.Controls.Add(Me.Button_ExportCurve)
        Me.GroupBox_Curve.Controls.Add(Me.Button_LoadCurve)
        Me.GroupBox_Curve.Location = New System.Drawing.Point(941, 378)
        Me.GroupBox_Curve.Name = "GroupBox_Curve"
        Me.GroupBox_Curve.Size = New System.Drawing.Size(257, 48)
        Me.GroupBox_Curve.TabIndex = 2
        Me.GroupBox_Curve.TabStop = False
        Me.GroupBox_Curve.Text = "Curve"
        '
        'Button_ExportCurve
        '
        Me.Button_ExportCurve.Location = New System.Drawing.Point(157, 19)
        Me.Button_ExportCurve.Name = "Button_ExportCurve"
        Me.Button_ExportCurve.Size = New System.Drawing.Size(94, 23)
        Me.Button_ExportCurve.TabIndex = 1
        Me.Button_ExportCurve.Text = "Export Curve"
        Me.Button_ExportCurve.UseVisualStyleBackColor = True
        '
        'Button_LoadCurve
        '
        Me.Button_LoadCurve.Location = New System.Drawing.Point(6, 19)
        Me.Button_LoadCurve.Name = "Button_LoadCurve"
        Me.Button_LoadCurve.Size = New System.Drawing.Size(102, 23)
        Me.Button_LoadCurve.TabIndex = 0
        Me.Button_LoadCurve.Text = "Load Curve"
        Me.Button_LoadCurve.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Curve File|*.curve"
        Me.OpenFileDialog.Title = "Load curve..."
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "Curve File|*.curve"
        Me.SaveFileDialog.Title = "Export curve..."
        '
        'Curve
        '
        Me.Curve.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Curve.AutoSelectDegrees = True
        Me.Curve.BorderBackColor = System.Drawing.Color.White
        Me.Curve.CurveColor = System.Drawing.Color.Orange
        Me.Curve.CurveType = CurveFitter.GraphType.Logarithmic
        Me.Curve.DotColor = System.Drawing.Color.Red
        Me.Curve.LiveCurve = True
        Me.Curve.Location = New System.Drawing.Point(12, 12)
        Me.Curve.MaxDegrees = 10
        Me.Curve.MinDegrees = 5
        Me.Curve.MultiDragFactor = 0.3R
        Me.Curve.Name = "Curve"
        Me.Curve.PolynomialCoefficients = CType(resources.GetObject("Curve.PolynomialCoefficients"), System.Collections.Generic.List(Of Double))
        Me.Curve.PolynomialDegrees = 6
        Me.Curve.Size = New System.Drawing.Size(923, 537)
        Me.Curve.TabIndex = 0
        Me.Curve.UseSinglePrecision = True
        Me.Curve.XAxisTitle = "Input %"
        Me.Curve.YAxisTitle = "Output %"
        '
        'GroupBox_Tools
        '
        Me.GroupBox_Tools.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Tools.Controls.Add(Me.TextBox_DesiredX)
        Me.GroupBox_Tools.Controls.Add(Me.TextBox_DesiredY)
        Me.GroupBox_Tools.Controls.Add(Me.Label_DesiredY)
        Me.GroupBox_Tools.Controls.Add(Me.Label_DesiredX)
        Me.GroupBox_Tools.Controls.Add(Me.TextBox_YPercent)
        Me.GroupBox_Tools.Controls.Add(Me.TextBox_XPercent)
        Me.GroupBox_Tools.Controls.Add(Me.Label_YPercent)
        Me.GroupBox_Tools.Controls.Add(Me.Label_XPercent)
        Me.GroupBox_Tools.Controls.Add(Me.Label_XMax)
        Me.GroupBox_Tools.Controls.Add(Me.TextBox_XMax)
        Me.GroupBox_Tools.Controls.Add(Me.Label_YMax)
        Me.GroupBox_Tools.Controls.Add(Me.TextBox_YMax)
        Me.GroupBox_Tools.Location = New System.Drawing.Point(941, 158)
        Me.GroupBox_Tools.Name = "GroupBox_Tools"
        Me.GroupBox_Tools.Size = New System.Drawing.Size(257, 160)
        Me.GroupBox_Tools.TabIndex = 4
        Me.GroupBox_Tools.TabStop = False
        Me.GroupBox_Tools.Text = "Tools"
        '
        'Label_XMax
        '
        Me.Label_XMax.AutoSize = True
        Me.Label_XMax.Location = New System.Drawing.Point(3, 16)
        Me.Label_XMax.Name = "Label_XMax"
        Me.Label_XMax.Size = New System.Drawing.Size(64, 13)
        Me.Label_XMax.TabIndex = 3
        Me.Label_XMax.Text = "Maximum X:"
        '
        'TextBox_XMax
        '
        Me.TextBox_XMax.Location = New System.Drawing.Point(6, 32)
        Me.TextBox_XMax.Name = "TextBox_XMax"
        Me.TextBox_XMax.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_XMax.TabIndex = 2
        Me.TextBox_XMax.Text = "37000"
        '
        'Label_YMax
        '
        Me.Label_YMax.AutoSize = True
        Me.Label_YMax.Location = New System.Drawing.Point(127, 16)
        Me.Label_YMax.Name = "Label_YMax"
        Me.Label_YMax.Size = New System.Drawing.Size(64, 13)
        Me.Label_YMax.TabIndex = 1
        Me.Label_YMax.Text = "Maximum Y:"
        '
        'TextBox_YMax
        '
        Me.TextBox_YMax.Location = New System.Drawing.Point(130, 32)
        Me.TextBox_YMax.Name = "TextBox_YMax"
        Me.TextBox_YMax.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_YMax.TabIndex = 0
        Me.TextBox_YMax.Text = "40"
        '
        'Label_XPercent
        '
        Me.Label_XPercent.AutoSize = True
        Me.Label_XPercent.Location = New System.Drawing.Point(3, 118)
        Me.Label_XPercent.Name = "Label_XPercent"
        Me.Label_XPercent.Size = New System.Drawing.Size(25, 13)
        Me.Label_XPercent.TabIndex = 4
        Me.Label_XPercent.Text = "X%:"
        '
        'Label_YPercent
        '
        Me.Label_YPercent.AutoSize = True
        Me.Label_YPercent.Location = New System.Drawing.Point(127, 118)
        Me.Label_YPercent.Name = "Label_YPercent"
        Me.Label_YPercent.Size = New System.Drawing.Size(25, 13)
        Me.Label_YPercent.TabIndex = 5
        Me.Label_YPercent.Text = "Y%:"
        '
        'TextBox_XPercent
        '
        Me.TextBox_XPercent.Location = New System.Drawing.Point(6, 134)
        Me.TextBox_XPercent.Name = "TextBox_XPercent"
        Me.TextBox_XPercent.ReadOnly = True
        Me.TextBox_XPercent.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_XPercent.TabIndex = 6
        '
        'TextBox_YPercent
        '
        Me.TextBox_YPercent.Location = New System.Drawing.Point(130, 134)
        Me.TextBox_YPercent.Name = "TextBox_YPercent"
        Me.TextBox_YPercent.ReadOnly = True
        Me.TextBox_YPercent.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_YPercent.TabIndex = 7
        '
        'Label_DesiredX
        '
        Me.Label_DesiredX.AutoSize = True
        Me.Label_DesiredX.Location = New System.Drawing.Point(3, 55)
        Me.Label_DesiredX.Name = "Label_DesiredX"
        Me.Label_DesiredX.Size = New System.Drawing.Size(56, 13)
        Me.Label_DesiredX.TabIndex = 8
        Me.Label_DesiredX.Text = "Desired X:"
        '
        'Label_DesiredY
        '
        Me.Label_DesiredY.AutoSize = True
        Me.Label_DesiredY.Location = New System.Drawing.Point(127, 55)
        Me.Label_DesiredY.Name = "Label_DesiredY"
        Me.Label_DesiredY.Size = New System.Drawing.Size(56, 13)
        Me.Label_DesiredY.TabIndex = 9
        Me.Label_DesiredY.Text = "Desired Y:"
        '
        'TextBox_DesiredX
        '
        Me.TextBox_DesiredX.Location = New System.Drawing.Point(6, 71)
        Me.TextBox_DesiredX.Name = "TextBox_DesiredX"
        Me.TextBox_DesiredX.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_DesiredX.TabIndex = 11
        '
        'TextBox_DesiredY
        '
        Me.TextBox_DesiredY.Location = New System.Drawing.Point(130, 71)
        Me.TextBox_DesiredY.Name = "TextBox_DesiredY"
        Me.TextBox_DesiredY.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_DesiredY.TabIndex = 10
        '
        'Debug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 561)
        Me.Controls.Add(Me.GroupBox_Tools)
        Me.Controls.Add(Me.GroupBox_Curve)
        Me.Controls.Add(Me.TextBox_About)
        Me.Controls.Add(Me.GroupBox_Properties)
        Me.Controls.Add(Me.GroupBox_Output)
        Me.Controls.Add(Me.Curve)
        Me.MinimumSize = New System.Drawing.Size(1226, 600)
        Me.Name = "Debug"
        Me.ShowIcon = False
        Me.Text = "CurveFitter - Debug"
        Me.GroupBox_Output.ResumeLayout(False)
        Me.GroupBox_Properties.ResumeLayout(False)
        Me.GroupBox_Properties.PerformLayout()
        Me.GroupBox_Curve.ResumeLayout(False)
        Me.GroupBox_Tools.ResumeLayout(False)
        Me.GroupBox_Tools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Curve As CurveFitter
    Friend WithEvents GroupBox_Output As GroupBox
    Friend WithEvents GroupBox_Properties As GroupBox
    Friend WithEvents Label_CurveType As Label
    Friend WithEvents ComboBox_CurveType As ComboBox
    Friend WithEvents Button_ExportCode As Button
    Friend WithEvents Button_ExportEquation As Button
    Friend WithEvents TextBox_About As TextBox
    Friend WithEvents GroupBox_Curve As GroupBox
    Friend WithEvents Button_ExportCurve As Button
    Friend WithEvents Button_LoadCurve As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents Label_Y As Label
    Friend WithEvents Label_X As Label
    Friend WithEvents Button_Insert As Button
    Friend WithEvents TextBox_Y As TextBox
    Friend WithEvents TextBox_X As TextBox
    Friend WithEvents Label_InsertPoint As Label
    Friend WithEvents Button_RemoveX As Button
    Friend WithEvents GroupBox_Tools As GroupBox
    Friend WithEvents Label_YMax As Label
    Friend WithEvents TextBox_YMax As TextBox
    Friend WithEvents Label_XMax As Label
    Friend WithEvents TextBox_XMax As TextBox
    Friend WithEvents TextBox_DesiredX As TextBox
    Friend WithEvents TextBox_DesiredY As TextBox
    Friend WithEvents Label_DesiredY As Label
    Friend WithEvents Label_DesiredX As Label
    Friend WithEvents TextBox_YPercent As TextBox
    Friend WithEvents TextBox_XPercent As TextBox
    Friend WithEvents Label_YPercent As Label
    Friend WithEvents Label_XPercent As Label
End Class
