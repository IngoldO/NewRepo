<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TemperatureBox = New System.Windows.Forms.TextBox()
        Me.PressureBox = New System.Windows.Forms.TextBox()
        Me.AcoefBox = New System.Windows.Forms.TextBox()
        Me.BcoefBox = New System.Windows.Forms.TextBox()
        Me.CcoefBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonVaporPressureCurve = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TminBox = New System.Windows.Forms.TextBox()
        Me.TmaxBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PmaxBox = New System.Windows.Forms.TextBox()
        Me.PminBox = New System.Windows.Forms.TextBox()
        Me.ButtonBoilingPointCurve = New System.Windows.Forms.Button()
        Me.CompoundComboBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ReadAntoineButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TemperatureBox
        '
        Me.TemperatureBox.Location = New System.Drawing.Point(119, 44)
        Me.TemperatureBox.Name = "TemperatureBox"
        Me.TemperatureBox.Size = New System.Drawing.Size(100, 20)
        Me.TemperatureBox.TabIndex = 0
        '
        'PressureBox
        '
        Me.PressureBox.Location = New System.Drawing.Point(119, 87)
        Me.PressureBox.Name = "PressureBox"
        Me.PressureBox.Size = New System.Drawing.Size(100, 20)
        Me.PressureBox.TabIndex = 1
        '
        'AcoefBox
        '
        Me.AcoefBox.Location = New System.Drawing.Point(310, 70)
        Me.AcoefBox.Name = "AcoefBox"
        Me.AcoefBox.Size = New System.Drawing.Size(100, 20)
        Me.AcoefBox.TabIndex = 3
        '
        'BcoefBox
        '
        Me.BcoefBox.Location = New System.Drawing.Point(310, 113)
        Me.BcoefBox.Name = "BcoefBox"
        Me.BcoefBox.Size = New System.Drawing.Size(100, 20)
        Me.BcoefBox.TabIndex = 4
        '
        'CcoefBox
        '
        Me.CcoefBox.Location = New System.Drawing.Point(310, 152)
        Me.CcoefBox.Name = "CcoefBox"
        Me.CcoefBox.Size = New System.Drawing.Size(100, 20)
        Me.CcoefBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Temperature [°C]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pressure [bar]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "A coefficient"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "B coefficient"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "C coefficient"
        '
        'ButtonVaporPressureCurve
        '
        Me.ButtonVaporPressureCurve.Location = New System.Drawing.Point(143, 226)
        Me.ButtonVaporPressureCurve.Name = "ButtonVaporPressureCurve"
        Me.ButtonVaporPressureCurve.Size = New System.Drawing.Size(148, 23)
        Me.ButtonVaporPressureCurve.TabIndex = 11
        Me.ButtonVaporPressureCurve.Text = "Show vapor pressure curve"
        Me.ButtonVaporPressureCurve.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(507, 47)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 265)
        Me.Chart1.TabIndex = 12
        Me.Chart1.Text = "Chart1"
        '
        'TminBox
        '
        Me.TminBox.Location = New System.Drawing.Point(369, 210)
        Me.TminBox.Name = "TminBox"
        Me.TminBox.Size = New System.Drawing.Size(39, 20)
        Me.TminBox.TabIndex = 13
        '
        'TmaxBox
        '
        Me.TmaxBox.Location = New System.Drawing.Point(369, 246)
        Me.TmaxBox.Name = "TmaxBox"
        Me.TmaxBox.Size = New System.Drawing.Size(41, 20)
        Me.TmaxBox.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tmin [°C]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(297, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tmax [°C]"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Pmax [bar]"
        Me.Label8.UseMnemonic = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(300, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Pmin [bar]"
        '
        'PmaxBox
        '
        Me.PmaxBox.Location = New System.Drawing.Point(369, 330)
        Me.PmaxBox.Name = "PmaxBox"
        Me.PmaxBox.Size = New System.Drawing.Size(39, 20)
        Me.PmaxBox.TabIndex = 19
        '
        'PminBox
        '
        Me.PminBox.Location = New System.Drawing.Point(369, 291)
        Me.PminBox.Name = "PminBox"
        Me.PminBox.Size = New System.Drawing.Size(39, 20)
        Me.PminBox.TabIndex = 18
        '
        'ButtonBoilingPointCurve
        '
        Me.ButtonBoilingPointCurve.Location = New System.Drawing.Point(143, 307)
        Me.ButtonBoilingPointCurve.Name = "ButtonBoilingPointCurve"
        Me.ButtonBoilingPointCurve.Size = New System.Drawing.Size(148, 23)
        Me.ButtonBoilingPointCurve.TabIndex = 17
        Me.ButtonBoilingPointCurve.Text = "Show boiling curve"
        Me.ButtonBoilingPointCurve.UseVisualStyleBackColor = True
        '
        'CompoundComboBox
        '
        Me.CompoundComboBox.FormattingEnabled = True
        Me.CompoundComboBox.Location = New System.Drawing.Point(310, 23)
        Me.CompoundComboBox.Name = "CompoundComboBox"
        Me.CompoundComboBox.Size = New System.Drawing.Size(100, 21)
        Me.CompoundComboBox.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(244, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Compound"
        '
        'ReadAntoineButton
        '
        Me.ReadAntoineButton.Location = New System.Drawing.Point(143, 399)
        Me.ReadAntoineButton.Name = "ReadAntoineButton"
        Me.ReadAntoineButton.Size = New System.Drawing.Size(148, 23)
        Me.ReadAntoineButton.TabIndex = 24
        Me.ReadAntoineButton.Text = "Show Antoine parameters"
        Me.ReadAntoineButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(335, 399)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 172)
        Me.DataGridView1.TabIndex = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = "Compound"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "A"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "B"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "C"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "T_min [°C]"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "T_max [°C]"
        Me.Column6.Name = "Column6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 612)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ReadAntoineButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CompoundComboBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PmaxBox)
        Me.Controls.Add(Me.PminBox)
        Me.Controls.Add(Me.ButtonBoilingPointCurve)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TmaxBox)
        Me.Controls.Add(Me.TminBox)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.ButtonVaporPressureCurve)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CcoefBox)
        Me.Controls.Add(Me.BcoefBox)
        Me.Controls.Add(Me.AcoefBox)
        Me.Controls.Add(Me.PressureBox)
        Me.Controls.Add(Me.TemperatureBox)
        Me.Name = "Form1"
        Me.Text = "Single Compound"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TemperatureBox As TextBox
    Friend WithEvents PressureBox As TextBox
    Friend WithEvents AcoefBox As TextBox
    Friend WithEvents BcoefBox As TextBox
    Friend WithEvents CcoefBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonVaporPressureCurve As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents TminBox As TextBox
    Friend WithEvents TmaxBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PmaxBox As TextBox
    Friend WithEvents PminBox As TextBox
    Friend WithEvents ButtonBoilingPointCurve As Button
    Friend WithEvents CompoundComboBox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ReadAntoineButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
