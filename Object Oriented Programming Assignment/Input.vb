Public MustInherit Class Input
    Private _valid As Boolean

    Public Property Valid As Boolean
        Get
            Return _valid
        End Get
        Set(value As Boolean)
            _valid = value
        End Set
    End Property

    Public Sub Enter(input As String)
        _valid = Validate(input)
    End Sub

    Protected MustOverride Function Validate(ByVal s As String) As Boolean
End Class
