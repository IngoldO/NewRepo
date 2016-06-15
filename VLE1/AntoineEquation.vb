﻿Module AntoineEquation

    Function AntoineVaporPressure(T As Double, Acoef As Double, Bcoef As Double, Ccoef As Double) As Double
        'In: Temperature [K], Antoine coefficients
        'Out: Vapor pressure [Pa]

        Dim Log10P As Double
        Log10P = Acoef - Bcoef / (T + Ccoef)
        AntoineVaporPressure = 10 ^ Log10P * 10 ^ 5 'Vapor pressure [Pa]

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

End Module