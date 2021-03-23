Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UserInputNumberValidTest

    <TestMethod()> Public Sub UserInputNumberValid()
        Dim input As InputNumber
        input = New InputNumber()
        input.Enter("7")
        Assert.IsTrue(input.Valid, "Input should be valid")
        Assert.AreEqual(7, input.Number, "Input number didn't contain the correct value")
    End Sub

End Class