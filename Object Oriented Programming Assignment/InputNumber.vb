
Public Class InputNumber
    Inherits Input
    
    Private _number As Integer

    Public Property Number As Integer
        Get
            Return _number
        End Get
        Set(value As Integer)
            _number = value
        End Set
    End Property

    Protected Overrides Function Validate(s As String) As Boolean
        Dim isValid As Boolean = Integer.TryParse(s, _number)
        Return isValid
    End Function
End Class
