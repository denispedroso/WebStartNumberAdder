<TestClass>
Public Class StudentCalculationEnteredIncorrectlyTest

    <TestMethod>
    Public Sub StudentCalculationEnteredIncorrectly()
        Dim currentFile As Student
        currentFile = New Student()

        Dim calc As Calculation
        calc = New Calculation()

        Dim inputNumber1 As InputNumber
        inputNumber1 = New InputNumber()
        inputNumber1.Enter("7")

        calc.Number1 = inputNumber1

        Dim inputNumber2 As InputNumber
        inputNumber2 = New InputNumber()
        inputNumber2.Enter("3B")

        calc.Number2 = inputNumber2

        calc.Operation = "+"

        Dim userResult As InputNumber
        userResult = New InputNumber
        userResult.Enter("10")

        calc.ExpectedResult = userResult

        currentFile.CheckCalculation(calc)

        Assert.IsFalse(calc.IsCorrect, "Calculation should not be marked correct")

        Dim studentHistory As Calculation
        studentHistory = currentFile.Calculations(0)
        Assert.IsNull(studentHistory, "The calculation shouldn't be stored")
    End Sub
End Class
