<TestClass>
Public Class StudentCalculationEnteredCorrectlyExpectedResultWrongTest

    <TestMethod>
    Public Sub StudentCalculationEnteredCorrectlyExpectedResultWrong()
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
        inputNumber2.Enter("3")

        calc.Number2 = inputNumber2

        calc.Operation = "+"

        Dim userResult As InputNumber
        userResult = New InputNumber
        userResult.Enter("13")

        calc.ExpectedResult = userResult

        currentFile.CheckCalculation(calc)

        Assert.IsFalse(calc.IsCorrect, "Calculation should not have been correct")

        Dim studentHistory As Calculation
        studentHistory = currentFile.Calculations(0)
        Assert.IsNotNull(studentHistory, "The calculation wasn't stored")
        Assert.AreEqual(studentHistory.Number1, calc.Number1)
        Assert.AreEqual(studentHistory.Number2, calc.Number2)
        Assert.AreEqual(studentHistory.ExpectedResult, calc.ExpectedResult)
        Assert.AreEqual(studentHistory.IsCorrect, calc.IsCorrect)
    End Sub
End Class
