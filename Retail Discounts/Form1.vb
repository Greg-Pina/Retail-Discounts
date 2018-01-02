'*********************************
'Greg Pina
'Midterm Early Submission for Review
'.Net Programming IT 101-401
'10/17/2017
'**********************************

Option Strict On
Public Class Form1
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        'This Closes the Program
        Close()

    End Sub

    'This keeps our variables outside of any private classes
    Dim mdblTotalBefore As Double
    Dim mdblTotalAfter As Double
    Dim dblPreviousDiscount As Double
    Dim MaxDiscount As Double
    Dim mdblTodaysPurchase As Double
    Dim dblTodaysDiscount As Double
    Dim dblDiscountPercent As Double
    Dim mdblTodaysTotal As Double

    'This sets management and employee variables
    Dim dblManager As Double
    Dim dblEmployee As Double

    'Variables for Input (left side)
    Dim dblStatus As Double
    Dim dblYears As Double
    Dim dblPreviousPurchases As Double
    Dim dblDiscount As Double
    Dim dblYTDDiscount As Double


    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        'This keeps the text boxes looking neat
        txtName.BackColor = Color.White
        txtPreviousPurchases.BackColor = Color.White
        txtTodaysPurchases.BackColor = Color.White
        txtYearsEmployed.BackColor = Color.White

        Try
            'This validates the user inputs on the left and makes sure they are correct

            'Correct Name?

            If IsNumeric(txtName.Text) Then
                MessageBox.Show("Please make sure to enter your name correctly.")
                txtName.Focus()
                txtName.BackColor = Color.Yellow
                Exit Sub
            End If

            Dim strName = CStr(txtName.Text)

            'Correct Number of Years Employed?

            If IsNumeric(txtYearsEmployed.Text) Then
                dblYears = CDbl(txtYearsEmployed.Text)
            Else
                MessageBox.Show("Please make sure to enter the number of years you've been with us correctly.")
                txtYearsEmployed.Focus()
                txtYearsEmployed.BackColor = Color.Yellow
                Exit Sub
            End If


            'Correct Total Amount of Previous Purchases?

            If IsNumeric(txtPreviousPurchases.Text) Then
                dblPreviousPurchases = CDbl(txtPreviousPurchases.Text)
            Else
                MessageBox.Show("Please make sure to enter amount of previous purchases you've had with us correctly.")
                txtPreviousPurchases.Focus()
                txtPreviousPurchases.BackColor = Color.Yellow
                Exit Sub
            End If


            'This checks employee status and discounts
            If radEmployee.Checked And
                 dblYears < 4 Then
                dblEmployee = 0.1
            ElseIf radEmployee.Checked And
                dblYears < 7 Then
                dblEmployee = 0.14
            ElseIf radEmployee.Checked And
                dblYears < 11 Then
                dblEmployee = 0.2
            ElseIf radEmployee.Checked And
                dblYears < 16 Then
                dblEmployee = 0.25
            ElseIf radEmployee.Checked And
                dblYears > 15 Then
                dblEmployee = 0.3
            End If

            'This checks manager status and discounts
            If radManager.Checked And
                 dblYears < 4 Then
                dblManager = 0.2
            ElseIf radManager.Checked And
                dblYears < 7 Then
                dblManager = 0.24
            ElseIf radManager.Checked And
                dblYears < 11 Then
                dblManager = 0.3
            ElseIf radManager.Checked And
                dblYears < 16 Then
                dblManager = 0.35
            ElseIf radManager.Checked And
                dblYears > 15 Then
                dblManager = 0.4
            End If

            'Gets the discount
            If radEmployee.Checked Then
                dblDiscount = dblEmployee
            ElseIf radManager.Checked Then
                dblDiscount = dblManager
            End If

            'To display this discount correctly
            If radManager.Checked Then
                dblStatus = (dblDiscount * 100)
            ElseIf radEmployee.Checked Then
                dblStatus = (dblDiscount * 100)
            End If
            'Correct Total of Today's Purchases?

            If IsNumeric(txtTodaysPurchases.Text) Then
                mdblTodaysPurchase = CDbl(txtTodaysPurchases.Text)
            Else
                MessageBox.Show("Please make sure to enter the total of today's purchases with us correctly.")
                txtYearsEmployed.Focus()
                txtYearsEmployed.BackColor = Color.Yellow
                Exit Sub
            End If


            '****************************This is where the actual calculations are done ***********

            'Gets YTD purchase discount

            If (dblPreviousPurchases * dblDiscount) > 200 Then
                dblYTDDiscount = 200
            Else
                dblYTDDiscount = (dblPreviousPurchases * dblDiscount)
            End If
            'Gets current purchase discount

            dblTodaysDiscount = (mdblTodaysPurchase * dblDiscount)

            'Todays Total
            mdblTodaysTotal = mdblTodaysPurchase - dblTodaysDiscount

            mdblTodaysTotal = mdblTodaysPurchase - dblTodaysDiscount


            If dblYTDDiscount > 200 Then
                dblTodaysDiscount = 0
            Else
                If dblYTDDiscount + (mdblTodaysPurchase * dblDiscount) > 200 Then
                    dblTodaysDiscount = 200 - dblYTDDiscount
                Else
                    dblTodaysDiscount = (mdblTodaysPurchase * dblDiscount)
                    Exit Sub
                End If
                Exit Sub
            End If

            '**********************************************************

            'This is the first output box


            lblOutput.Text = "Name: " & strName & vbNewLine & vbNewLine & "Employee Discount (%): " & dblStatus & vbNewLine & vbNewLine &
                "YTD Amount of Discount: " & dblYTDDiscount.ToString("c") & vbNewLine & vbNewLine & "Total Purchase Today Before Discount: " & mdblTodaysPurchase.ToString("c") &
                vbNewLine & vbNewLine & "Employee Discount This Purchase: " & dblTodaysDiscount.ToString("c") & vbNewLine & vbNewLine & "Total With Discount: " & mdblTodaysTotal.ToString("c")





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click

        'This Moves On to the Next Employee

        'This clears the text boxes on the left
        txtName.Clear()
        txtPreviousPurchases.Clear()
        txtTodaysPurchases.Clear()
        txtYearsEmployed.Clear()

        'This clears the label on the right
        lblOutput.Text = String.Empty

        'This puts focus back on the name text box
        txtName.Focus()
        Exit Sub

    End Sub

    Private Sub BtnSummary_Click(sender As Object, e As EventArgs)

        'This keeps a running total
        mdblTotalBefore += mdblTodaysTotal
        mdblTotalAfter += mdblTodaysPurchase

        'This Displays the Discount Summary
        lblSummary.Text = "Total before discount for the day: " & mdblTotalBefore.ToString("c") & vbNewLine & "Total after discounts applied: " &
                mdblTotalAfter.ToString("c")
    End Sub


End Class
