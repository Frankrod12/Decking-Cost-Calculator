Public Class frmDecking
    Private Const Prompt As String = "Enter the Square Footage of Decking:, , "

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'The btnCalculate event handlet calculates the estimated cost of
        'decking based on the square footage and the decking type.

        'Declaration Section
        Dim decFootage As Decimal
        Dim decCostPerSquareFoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decLumberCost As Decimal = 2.35D
        Dim decRedwoodCost As Decimal = 7.75D
        Dim decCompositeCost As Decimal = 8.5D

        'Did user enter a numeric value?
        If IsNumeric(txtFootage.Text) Then
            decFootage = Convert.ToDecimal(txtFootage.Text)
            'is square footage greater than zero
            If decFootage > 0 Then
                'Determine the cost per square foot
                If radLumber.Checked Then
                    decCostPerSquareFoot = decLumberCost
                ElseIf radRedwood.Checked Then
                    decCostPerSquareFoot = decRedwoodCost
                ElseIf radComposite.Checked Then
                    decCostPerSquareFoot = decCompositeCost
                End If
                'Calculate and display the cost estimate
                decCostEstimate = decFootage * decCostPerSquareFoot
                lblCostEstimate.Text = decCostEstimate.ToString("C")
            Else
                'Display error message if user entered a negative value
                MsgBox("You entered" & decFootage.ToString() & ". Enter a Positive Number", , "Input Error")
                txtFootage.Text = ""
                txtFootage.Focus()
            End If
        Else
            If IsNumeric(txtFootage.Text) = False Then
                'Display error message if user entered a nonnumeric value
                MsgBox("Enter the Square Footage of Decking", , "Input Error")
                txtFootage.Text = ""
                txtFootage.Focus()
            End If
        End If

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFootage.Clear()
        lblCostEstimate.Text = ""
        radLumber.Checked = True
        radRedwood.Checked = False
        radComposite.Checked = False
        txtFootage.Focus()
    End Sub

    Private Sub FrmDecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtFootage.Focus()
        lblCostEstimate.Text = ""
    End Sub
End Class
