
Public Class Form1

    Dim VaporPressure, Acoef, Bcoef, Ccoef, Temperature, Tmin, Tmax, Pmin, Pmax As Double

    Dim AntoineInfo1(1) As AntoineInfo




    Dim Form1IsInitialized As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Filling in default values
        AcoefBox.Text = 4.42448
        BcoefBox.Text = 1312.253
        CcoefBox.Text = -32.445
        TemperatureBox.Text = 25 '[°C]
        TminBox.Text = 10 '[°C]
        TmaxBox.Text = 70 '[°C]
        PminBox.Text = 0.5 '[bar]
        PmaxBox.Text = 2 '[bar]



        Acoef = AcoefBox.Text
        Bcoef = BcoefBox.Text
        Ccoef = CcoefBox.Text

        Temperature = TemperatureBox.Text + 273.15
        VaporPressure = AntoineVaporPressure(Temperature, Acoef, Bcoef, Ccoef) 'function returns vapor pressure [Pa]

        PressureBox.Text = VaporPressure / 10 ^ 5 '[bar]
        Form1IsInitialized = True

    End Sub

    Private Sub InputChange() Handles TemperatureBox.TextChanged, AcoefBox.TextChanged, BcoefBox.TextChanged, CcoefBox.TextChanged

        'Subroutine recalculates the vapor pressure when one of the inputs (Antoine coefficients or temperature) changes
        If Form1IsInitialized Then
            If AcoefBox.Text = "" Or BcoefBox.Text = "" Or CcoefBox.Text = "" Then
                MsgBox("At least one Antoine coefficient is missing. Please provide all three coefficients.")
            ElseIf TemperatureBox.Text = "" Then
                MsgBox("The temperature is missing. Please provide the temperature of your system.")
            Else
                If TemperatureBox.Text <> Temperature Then
                    Temperature = TemperatureBox.Text
                ElseIf AcoefBox.Text <> Acoef Then
                    Acoef = AcoefBox.Text
                ElseIf BcoefBox.Text <> Bcoef Then
                    Bcoef = BcoefBox.Text
                ElseIf CcoefBox.Text <> Ccoef Then
                    Ccoef = CcoefBox.Text
                End If
                VaporPressure = AntoineVaporPressure(Temperature + 273.15, Acoef, Bcoef, Ccoef) 'function returns vapor pressure [Pa]
                PressureBox.Text = VaporPressure / 10 ^ 5 '[bar]
            End If
        End If
    End Sub


    Private Sub ButtonVaporPressureCurve_Click(sender As Object, e As EventArgs) Handles ButtonVaporPressureCurve.Click
        'Button Click leads to calculation and plotting of vapor pressure curve of single compound

        'Check if all Antoine coefficients, as well as temperature range are provided
        If AcoefBox.Text = "" Or BcoefBox.Text = "" Or CcoefBox.Text = "" Then
            MsgBox("At least one Antoine coefficient is missing. Please provide all three coefficients.")
        ElseIf TminBox.Text = "" Or TmaxBox.Text = "" Then
            MsgBox("Maximal and/or minimal temperature are missing. Please provide both values.")
        Else

            Tmin = TminBox.Text + 273.15 'Reading textbox input
            Tmax = TmaxBox.Text + 273.15 'Reading textbox input

            'Computing vapor pressure curve
            Dim VaporPressureCurve(,) As Double
            Dim NPoints As Integer
            NPoints = 50
            Dim VaporPressurePlot() As Double = Array.CreateInstance(GetType(Double), NPoints)
            Dim TemperaturePlot() As Double = Array.CreateInstance(GetType(Double), NPoints)

            VaporPressureCurve = AntoineVaporPressureCurve(Acoef, Bcoef, Ccoef, Tmin, Tmax, NPoints) ' Function is in module Antoine Equation

            For k As Integer = 0 To NPoints - 1
                TemperaturePlot(k) = VaporPressureCurve(0, k) - 273.15
                VaporPressurePlot(k) = VaporPressureCurve(1, k) / 10 ^ 5
            Next


            'Displaying vapor pressure curve
            Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
            Chart1.Series(0).Points.DataBindXY(TemperaturePlot, VaporPressurePlot)

            Chart1.ChartAreas(0).AxisX.Title = ("Temperature [°C]")
            Chart1.ChartAreas(0).AxisY.Title = ("Vapor pressure [bar]")

            Chart1.ChartAreas(0).AxisX.Interval = 10
            Chart1.ChartAreas(0).AxisX.Minimum = TminBox.Text

        End If

    End Sub




    Private Sub ButtonBoilingPointCurve_Click(sender As Object, e As EventArgs) Handles ButtonBoilingPointCurve.Click
        'Button Click leads to calculation and plotting of vapor pressure curve of single compound

        'Check if all Antoine coefficients, as well as temperature range are provided
        If AcoefBox.Text = "" Or BcoefBox.Text = "" Or CcoefBox.Text = "" Then
            MsgBox("At least one Antoine coefficient is missing. Please provide all three coefficients.")
        ElseIf PminBox.Text = "" Or PmaxBox.Text = "" Then
            MsgBox("Maximal and/or minimal pressure are missing. Please provide both values.")
        Else

            Pmin = PminBox.Text * 10 ^ 5 'Reading pressure range
            Pmax = PmaxBox.Text * 10 ^ 5

            'Computing vapor pressure curve
            Dim BoilingPointCurve(,) As Double
            Dim NPoints As Integer
            NPoints = 50
            Dim PressurePlot() As Double = Array.CreateInstance(GetType(Double), NPoints)
            Dim BoilingPointPlot() As Double = Array.CreateInstance(GetType(Double), NPoints)

            BoilingPointCurve = AntoineBoilingCurve(Acoef, Bcoef, Ccoef, Pmin, Pmax, NPoints) ' Function is in module Antoine Equation

            For k As Integer = 0 To NPoints - 1
                PressurePlot(k) = BoilingPointCurve(0, k) / 10 ^ 5
                BoilingPointPlot(k) = BoilingPointCurve(1, k) - 273.15
            Next




            'Displaying vapor pressure curve
            Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Point
            Chart1.Series(0).Points.DataBindXY(PressurePlot, BoilingPointPlot)

            Chart1.ChartAreas(0).AxisX.Title = ("Pressure [bar]")
            Chart1.ChartAreas(0).AxisY.Title = ("Boiling point [°C]")

            Chart1.ChartAreas(0).AxisX.Interval = 0.2
            Chart1.ChartAreas(0).AxisX.Minimum = PminBox.Text

        End If

    End Sub




    Private Sub ReadAntoineData(sender As Object, e As EventArgs) Handles MyBase.Load

        Using MyReader As New Microsoft.VisualBasic.
                       FileIO.TextFieldParser(
                         "AntoinePar.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim RowNum As Integer
            RowNum = 0
            Dim currentRow As String()
            While Not MyReader.EndOfData


                Try
                    currentRow = MyReader.ReadFields()
                    DataGridView1.Rows.Add(currentRow)
                    AntoineInfo1(RowNum).Name = currentRow(0)
                    AntoineInfo1(RowNum).Acoef = currentRow(1)
                    AntoineInfo1(RowNum).Bcoef = currentRow(2)
                    AntoineInfo1(RowNum).Ccoef = currentRow(3)
                    AntoineInfo1(RowNum).Tmin = currentRow(4)
                    AntoineInfo1(RowNum).Tmax = currentRow(5)

                    RowNum = RowNum + 1
                    ReDim Preserve AntoineInfo1(UBound(AntoineInfo1) + 1) 'Resize the structure
                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using

        Dim I, K As Integer
        Dim Duplicate As Boolean
        Dim CompoundNames(1) As String

        'Adding Compound names as combobox items without duplicates
        For I = 0 To AntoineInfo1.Length - 1
            CompoundNames(I) = AntoineInfo1(I).Name
            ReDim Preserve CompoundNames(CompoundNames.Length + 1)
        Next

        For I = 0 To CompoundNames.Length - 2
            Duplicate = False
            For K = I + 1 To CompoundNames.Length - 1
                If CompoundNames(I) = CompoundNames(K) Then
                    Duplicate = True
                End If
            Next
            If Not Duplicate Then
                CompoundComboBox.Items.Add(CompoundNames(I))
            End If
        Next

        Duplicate = False
        For I = 0 To CompoundNames.Length - 2
            If CompoundNames(I) = CompoundNames(CompoundNames.Length - 1) Then
                Duplicate = True
            End If
        Next
        If Not Duplicate Then
            CompoundComboBox.Items.Add(CompoundNames(CompoundNames.Length - 1))
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        CompoundComboBox.SelectedIndex = 0 'Default selection upon loading the form
    End Sub





End Class