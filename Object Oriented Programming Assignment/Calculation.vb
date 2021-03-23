
Public Class Calculation
    Private _number1 As InputNumber
    Public Property Number1 As InputNumber
        Get
            Return _number1
        End Get
        Set(value As InputNumber)
            _number1 = value
        End Set
    End Property

    Private _number2 As InputNumber
    Public Property Number2 As InputNumber
        Get
            Return _number2
        End Get
        Set(value As InputNumber)
            _number2 = value
        End Set
    End Property

    Private _operation As String
    Public Property Operation As String
        Get
            Return _operation
        End Get
        Set(value As String)
            _operation = value
        End Set
    End Property

    Private _expectedResult As InputNumber
    Public Property ExpectedResult As InputNumber
        Get
            Return _expectedResult
        End Get
        Set(value As InputNumber)
            _expectedResult = value
        End Set
    End Property

    Private _isCorrect As Boolean
    Public Property IsCorrect As Boolean
        Get
            Return _isCorrect
        End Get
        Set(value As Boolean)
            _isCorrect = value
        End Set
    End Property

    Public Function Calculate() As Boolean
        Dim validCalculation As Boolean = False
        If _number1.Valid AndAlso _number2.Valid AndAlso ExpectedResult.Valid Then
            validCalculation = True
            If Operation = "+" Then
                _isCorrect = (_number1.Number + _number2.Number = _expectedResult.Number)
            Else
                validCalculation = False
            End If
        End If
        Return validCalculation
    End Function

End Class
