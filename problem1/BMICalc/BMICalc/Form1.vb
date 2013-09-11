Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click



        Dim Hst As String
        Dim wSt As String

        Hst = txtHeight.Text
        wSt = txtWeight.Text

        Dim h As Double
        Dim w As Double

        h = CDbl(Hst)
        w = CDbl(wSt)

        Dim BMI As Double

        BMI = (w * 703) / (h ^ 2)

        TextBox1.Text = CStr(BMI)

    End Sub

    Private Sub txtWeight_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtWeight.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
       




    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
