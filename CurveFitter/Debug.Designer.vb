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
        Me.Label_PresetProperties = New System.Windows.Forms.Label()
        Me.Label_CurveType = New System.Windows.Forms.Label()
        Me.ComboBox_CurveType = New System.Windows.Forms.ComboBox()
        Me.ListBox_Properties = New System.Windows.Forms.ListBox()
        Me.TextBox_About = New System.Windows.Forms.TextBox()
        Me.Curve = New CurveFitter()
        Me.GroupBox_Output.SuspendLayout()
        Me.GroupBox_Properties.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Output
        '
        Me.GroupBox_Output.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Output.Controls.Add(Me.Button_ExportEquation)
        Me.GroupBox_Output.Controls.Add(Me.Button_ExportCode)
        Me.GroupBox_Output.Location = New System.Drawing.Point(941, 244)
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
        Me.GroupBox_Properties.Controls.Add(Me.Label_PresetProperties)
        Me.GroupBox_Properties.Controls.Add(Me.Label_CurveType)
        Me.GroupBox_Properties.Controls.Add(Me.ComboBox_CurveType)
        Me.GroupBox_Properties.Controls.Add(Me.ListBox_Properties)
        Me.GroupBox_Properties.Location = New System.Drawing.Point(941, 12)
        Me.GroupBox_Properties.Name = "GroupBox_Properties"
        Me.GroupBox_Properties.Size = New System.Drawing.Size(257, 225)
        Me.GroupBox_Properties.TabIndex = 2
        Me.GroupBox_Properties.TabStop = False
        Me.GroupBox_Properties.Text = "Properties"
        '
        'Label_PresetProperties
        '
        Me.Label_PresetProperties.AutoSize = True
        Me.Label_PresetProperties.Location = New System.Drawing.Point(3, 16)
        Me.Label_PresetProperties.Name = "Label_PresetProperties"
        Me.Label_PresetProperties.Size = New System.Drawing.Size(90, 13)
        Me.Label_PresetProperties.TabIndex = 5
        Me.Label_PresetProperties.Text = "Preset Properties:"
        '
        'Label_CurveType
        '
        Me.Label_CurveType.AutoSize = True
        Me.Label_CurveType.Location = New System.Drawing.Point(3, 182)
        Me.Label_CurveType.Name = "Label_CurveType"
        Me.Label_CurveType.Size = New System.Drawing.Size(65, 13)
        Me.Label_CurveType.TabIndex = 4
        Me.Label_CurveType.Text = "Curve Type:"
        '
        'ComboBox_CurveType
        '
        Me.ComboBox_CurveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_CurveType.FormattingEnabled = True
        Me.ComboBox_CurveType.Items.AddRange(New Object() {"Linear", "Exponential", "Logarithmic"})
        Me.ComboBox_CurveType.Location = New System.Drawing.Point(6, 198)
        Me.ComboBox_CurveType.Name = "ComboBox_CurveType"
        Me.ComboBox_CurveType.Size = New System.Drawing.Size(245, 21)
        Me.ComboBox_CurveType.TabIndex = 3
        '
        'ListBox_Properties
        '
        Me.ListBox_Properties.Enabled = False
        Me.ListBox_Properties.FormattingEnabled = True
        Me.ListBox_Properties.Items.AddRange(New Object() {"AutoSelectDegrees" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "True", "BorderBackColor" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "White", "CurveColor" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Orange", "DotColor" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Red", "LiveCurve" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "True", "MaxDegrees" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "10", "MinDegrees" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "3", "MultiDragFactor" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "0.3", "UseSinglePrecision" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "True", "XAxisTitle" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "RPM %", "YAxisTitle" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Amperes %"})
        Me.ListBox_Properties.Location = New System.Drawing.Point(6, 32)
        Me.ListBox_Properties.Name = "ListBox_Properties"
        Me.ListBox_Properties.Size = New System.Drawing.Size(245, 147)
        Me.ListBox_Properties.TabIndex = 0
        '
        'TextBox_About
        '
        Me.TextBox_About.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_About.Location = New System.Drawing.Point(941, 298)
        Me.TextBox_About.Multiline = True
        Me.TextBox_About.Name = "TextBox_About"
        Me.TextBox_About.ReadOnly = True
        Me.TextBox_About.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_About.Size = New System.Drawing.Size(257, 332)
        Me.TextBox_About.TabIndex = 3
        Me.TextBox_About.Text = resources.GetString("TextBox_About.Text")
        '
        'Curve
        '
        Me.Curve.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Curve.AutoSelectDegrees = True
        Me.Curve.BorderBackColor = System.Drawing.Color.White
        Me.Curve.CurveColor = System.Drawing.Color.Orange
        Me.Curve.CurveType = GraphType.Logarithmic
        Me.Curve.DotColor = System.Drawing.Color.Red
        Me.Curve.LiveCurve = True
        Me.Curve.Location = New System.Drawing.Point(12, 12)
        Me.Curve.MaxDegrees = 10
        Me.Curve.MinDegrees = 5
        Me.Curve.MultiDragFactor = 0.3R
        Me.Curve.Name = "Curve"
        Me.Curve.PolynomialCoefficients = CType(resources.GetObject("Curve.PolynomialCoefficients"), System.Collections.Generic.List(Of Double))
        Me.Curve.PolynomialDegrees = 6
        Me.Curve.Size = New System.Drawing.Size(923, 618)
        Me.Curve.TabIndex = 0
        Me.Curve.UseSinglePrecision = True
        Me.Curve.XAxisTitle = "RPM %"
        Me.Curve.YAxisTitle = "Amperes %"
        '
        'Debug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 642)
        Me.Controls.Add(Me.TextBox_About)
        Me.Controls.Add(Me.GroupBox_Properties)
        Me.Controls.Add(Me.GroupBox_Output)
        Me.Controls.Add(Me.Curve)
        Me.MinimumSize = New System.Drawing.Size(1166, 576)
        Me.Name = "Debug"
        Me.ShowIcon = False
        Me.Text = "CurveFitter - Debug"
        Me.GroupBox_Output.ResumeLayout(False)
        Me.GroupBox_Properties.ResumeLayout(False)
        Me.GroupBox_Properties.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Curve As CurveFitter
    Friend WithEvents GroupBox_Output As GroupBox
    Friend WithEvents GroupBox_Properties As GroupBox
    Friend WithEvents Label_PresetProperties As Label
    Friend WithEvents Label_CurveType As Label
    Friend WithEvents ComboBox_CurveType As ComboBox
    Friend WithEvents ListBox_Properties As ListBox
    Friend WithEvents Button_ExportCode As Button
    Friend WithEvents Button_ExportEquation As Button
    Friend WithEvents TextBox_About As TextBox
End Class
