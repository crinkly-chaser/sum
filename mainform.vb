' MainForm.vb
Public Class MainForm
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculateSum()
    End Sub

    Private Sub CalculateSum()
        Dim num1, num2, sum As Double

        If Double.TryParse(txtNum1.Text, num1) AndAlso Double.TryParse(txtNum2.Text, num2) Then
            sum = num1 + num2
            MessageBox.Show($"The sum of {num1} and {num2} is {sum}", "Sum Calculation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
