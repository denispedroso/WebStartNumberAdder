<TestClass()>
Public Class CalculateHandlesInvalidTest

    <TestMethod>
    Public Sub CalculateHandlesInvalid()
        Dim calc As Calculation
        calc = New Calculation()

        Dim inputNumber1 As InputNumber
        inputNumber1 = New InputNumber()
        inputNumber1.Enter("a")

        calc.Number1 = inputNumber1

        Dim inputNumber2 As InputNumber
        inputNumber2 = New InputNumber()
        inputNumber2.Enter("3")

        calc.Number2 = inputNumber2

        calc.Operation = "+"

        Dim userResult As InputNumber
        userResult = New InputNumber
        userResult.Enter("10")

        calc.ExpectedResult = userResult

        Dim result As Boolean
        result = calc.Calculate()

        Assert.IsFalse(result, "The calculation should not be able to process due to invalid entry")
        Assert.IsFalse(calc.IsCorrect, "Calculation should not be marked correct")
    End Sub
End Class