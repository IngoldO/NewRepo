Module AntoineEquation

    Public Structure AntoineInfo
        Dim Name As String
        Dim Acoef As Double
        Dim Bcoef As Double
        Dim Ccoef As Double
        Dim Tmin As Double
        Dim Tmax As Double
    End Structure

    Function AntoineVaporPressure(T As Double, Acoef As Double, Bcoef As Double, Ccoef As Double) As Double
        'In: Temperature [K], Antoine coefficients
        'Out: Vapor pressure [Pa]

        Dim Log10P As Double
        Log10P = Acoef - Bcoef / (T + Ccoef)
        AntoineVaporPressure = 10 ^ Log10P * 10 ^ 5 'Vapor pressure [Pa]
        'This is a change. And another change.
    End Function

    Function AntoineBoilingPoint(P As Double, Acoef As Double, Bcoef As Double, Ccoef As Double) As Double
        'In: Pressure [Pa], Antoine coefficients
        'Out: Boiling temperature [K]

        Dim Log10P As Double
        P = P / 10 ^ 5 'Unit conversion from [Pa] to [bar]
        Log10P = Math.Log10(P)

        AntoineBoilingPoint = Bcoef / (Acoef - Log10P) - Ccoef 'Boiling Point [Pa]

    End Function


    Function AntoineVaporPressureCurve(Acoef As Double, Bcoef As Double, Ccoef As Double, Tmin As Double, Tmax As Double, NPoints As Integer) As Double(,)
        'In: Antoine coefficients, minimal and maximal temperature [K], number of points
        'Out: temperatures [K] and vapor pressures [Pa]

        Dim FunVal(1, NPoints - 1), Tstep As Double
        Tstep = (Tmax - Tmin) / (NPoints - 1)
        FunVal(0, 0) = Tmin
        FunVal(1, 0) = AntoineVaporPressure(Tmin, Acoef, Bcoef, Ccoef)

        For k As Integer = 1 To NPoints - 1
            FunVal(0, k) = FunVal(0, k - 1) + Tstep
            FunVal(1, k) = AntoineVaporPressure(FunVal(0, k), Acoef, Bcoef, Ccoef)
        Next

        AntoineVaporPressureCurve = FunVal
    End Function



    Function AntoineBoilingCurve(Acoef As Double, Bcoef As Double, Ccoef As Double, Pmin As Double, Pmax As Double, NPoints As Integer)
        'In: Antoine coefficients, minimal and maximal vapor pressures [Pa], number of points
        'Out: vapor pressures [Pa] boiling temperatures [K]

        Dim FunVal(1, NPoints - 1), Pstep As Double
        Pstep = (Pmax - Pmin) / (NPoints - 1)
        FunVal(0, 0) = Pmin
        FunVal(1, 0) = AntoineBoilingPoint(Pmin, Acoef, Bcoef, Ccoef)

        For k As Integer = 1 To NPoints - 1
            FunVal(0, k) = FunVal(0, k - 1) + Pstep
            FunVal(1, k) = AntoineBoilingPoint(FunVal(0, k), Acoef, Bcoef, Ccoef)
        Next

        AntoineBoilingCurve = FunVal
    End Function

    'Function AntoineCoefSelect(Temperature As Double, Tmin() As Double, Tmax() As Double, Acoefs() As Double, Bcoefs() As Double, Ccoefs() As Double) As Double()
    Function AntoineCoefSelect(Temperature As Double, AntoineData() As AntoineInfo, CompoundName As String) As Double()
        'Function returning the best Antoine parameters based on temperature range

        Dim K, Best As Integer 'Looping over the temperature vectors
        Dim FunVal(3), SmallestTdiff As Double
        SmallestTdiff = 1000 'Huge initial value
        Best = AntoineData.Length 'If no match is found, no Antoine coefficients will be selected.
        For K = 0 To AntoineData.Length - 1
            System.Diagnostics.Debug.Print(AntoineData(K).Name)
            ' System.Diagnostics.Debug.Print(CompoundName)
            If AntoineData(K).Name = CompoundName Then


                If AntoineData(K).Tmin < Temperature And AntoineData(K).Tmax > Temperature Then
                    Best = K
                    Exit For
                End If

                If AntoineData(K).Tmax < Temperature And Temperature - AntoineData(K).Tmax < SmallestTdiff Then
                    SmallestTdiff = Temperature - AntoineData(K).Tmax
                    Best = K
                End If

                If AntoineData(K).Tmin > Temperature And AntoineData(K).Tmin - Temperature < SmallestTdiff Then
                    SmallestTdiff = AntoineData(K).Tmin - Temperature
                    Best = K
                End If

            End If

        Next


        FunVal(0) = AntoineData(Best).Acoef
        FunVal(1) = AntoineData(Best).Bcoef
        FunVal(2) = AntoineData(Best).Ccoef

        AntoineCoefSelect = FunVal
    End Function

End Module
