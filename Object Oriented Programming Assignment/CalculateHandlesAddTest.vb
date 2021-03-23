<TestClass()>
Public Class CalculateHandlesAddTest

    <TestMethod>
    Public Sub CalculateHandlesAdd()
        Dim calc As Calculation
        calc = New Calculation()

        Dim inputNumber1 As InputNumber
        inputNumber1 = New InputNumber()
        inputNumber1.Enter("7")

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

        calc.Calculate()

        Assert.IsTrue(calc.IsCorrect, "Calculation should have been correct")
    End Sub
End Class