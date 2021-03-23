
''' <summary>
''' Student File
''' </summary>
''' <remarks></remarks>
Public Class Student
    Private _calculation(20) As Calculation

    Public Property Calculations As Calculation()
        Get
            Return _calculation
        End Get
        Set(value As Calculation())
            _calculation = value
        End Set
    End Property

    Private _currentPosition As Integer = 0

    Public Sub CheckCalculation(ByVal calculation As Calculation)
        Dim validCalculation As Boolean
        validCalculation = calculation.Calculate()
        If validCalculation Then
            _calculation(_currentPosition) = calculation
            _currentPosition = _currentPosition + 1
        End If
    End Sub
End Class
