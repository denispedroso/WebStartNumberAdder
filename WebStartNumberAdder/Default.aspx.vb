Imports Object_Oriented_Programming_Assignment

Public Class _Default
    Inherits System.Web.UI.Page

    Dim currentFile As Student = New Student()
    Dim calc As Calculation = New Calculation()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Button_New_Calculation.Visible = False
    End Sub

    Protected Sub input_number1_TextChanged(sender As Object, e As EventArgs) Handles input_number1.TextChanged
        Dim inputNumber1 As InputNumber

        inputNumber1 = GetInput(input_number1.Text, input_number1, output_number1)
        If inputNumber1.Valid Then
            input_number2.Focus()
        End If
    End Sub

    Protected Sub input_number2_TextChanged(sender As Object, e As EventArgs) Handles input_number2.TextChanged
        Dim inputNumber2 As InputNumber
        inputNumber2 = GetInput(input_number2.Text, input_number2, output_number2)
        If inputNumber2.Valid Then
            input_operation.Focus()
        End If

    End Sub

    Protected Sub input_expected_result_TextChanged(sender As Object, e As EventArgs) Handles input_expected_result.TextChanged
        Dim expectedResult As InputNumber
        expectedResult = GetInput(input_expected_result.Text, input_expected_result, output_expected_result)
        If expectedResult.Valid Then
            Button_Calculate.Focus()
        End If
    End Sub

    Private Function GetInput(text As String, inputTextBox As TextBox, outputLabel As Label) As InputNumber
        Dim input As InputNumber = New InputNumber()
        input.Enter(text)
        If Not input.Valid Then
            outputLabel.Text = "You should enter a valid Integer!"
            inputTextBox.Focus()
        Else
            Session(inputTextBox.ID) = input
            outputLabel.Text = Nothing
        End If
        GetInput = input
    End Function

    Protected Sub Button_Calculate_Click(sender As Object, e As EventArgs) Handles Button_Calculate.Click
        Dim inputNumber1 As InputNumber = CType(Session("input_number1"), InputNumber)
        calc.Number1 = inputNumber1

        If IsNothing(inputNumber1) Then
            input_number1.Focus()
            Return
        End If

        Dim inputNumber2 As InputNumber = CType(Session("input_number2"), InputNumber)
        calc.Number2 = inputNumber2

        If IsNothing(inputNumber2) Then
            input_number2.Focus()
            Return
        End If

        Dim expectedResult As InputNumber = CType(Session("input_expected_result"), InputNumber)
        calc.ExpectedResult = expectedResult

        If IsNothing(expectedResult) Then
            output_expected_result.Focus()
            Return
        End If

        calc.Operation = input_operation.Text

        currentFile.CheckCalculation(calc)
        If calc.IsCorrect Then
            output_result.ForeColor = Drawing.Color.Green
            output_result.Text = "Correct."
        Else
            output_result.ForeColor = Drawing.Color.Red
            output_result.Text = "Not Correct."
        End If
        EnableInputs(False)
        output_new_calculation.Text = "Do you want to enter a new Calculation?"
        Button_New_Calculation.Visible = True
        Button_New_Calculation.Focus()
    End Sub

    Private Sub EnableInputs(status As Boolean)
        input_number1.Enabled = status
        input_number2.Enabled = status
        input_expected_result.Enabled = status
        input_operation.Enabled = status
        Button_Calculate.Enabled = status
    End Sub

    Protected Sub Button_New_Calculation_Click(sender As Object, e As EventArgs) Handles Button_New_Calculation.Click
        ResetForm()
        input_number1.Focus()
    End Sub

    Private Sub ResetForm()
        input_number1.Text = Nothing
        input_number2.Text = Nothing
        input_expected_result.Text = Nothing
        input_operation.Text = Nothing
        output_number1.Text = Nothing
        output_number2.Text = Nothing
        output_expected_result.Text = Nothing
        output_result.Text = Nothing
        output_new_calculation.Text = Nothing
        Session.Clear()
        EnableInputs(True)
    End Sub
End Class