Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UserInputNumberInvalidTest

    <TestMethod()> Public Sub UserInputNumberInvalid()
        Dim input As InputNumber
        input = New InputNumber()
        input.Enter("A7")
        Assert.IsFalse(input.Valid, "Input shouldn't be valid")
    End Sub

End Class