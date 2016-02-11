'  NAME:
'  DATE:
'  PURPOSE:  To learn about modulo arithmetic
'            How to use INTEGER DIVISION and
'                       MODULO to solve problems


Public Class frmCoinConverter

    ' CONSTANTS
    Const QUARTER_VALUE As Integer = 25
    Const DIME_VALUE As Integer = 10
    Const NICKEL_VALUE As Integer = 5




    ' SETUP form at beginning of program
    Private Sub frmCoinConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' CLEAR TextBoxes
        txtAverageCoinValue.Clear()
        txtDimes.Clear()
        txtDollarAmount.Clear()
        txtEntry.Clear()
        txtNickels.Clear()
        txtQuarters.Clear()
        txtPennies.Clear()
        ' FOCUS to entry
        txtEntry.Focus()
    End Sub


    ' CLOSE the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    ' CLEAR all text boxes
    ' FOCUS to entry text box
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        frmCoinConverter_Load(sender, e)
    End Sub


    ' CALCULATE the answers and place into text boxes
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' LOCAL VARIABLES
        Dim quarters, dimes, nickels, pennies As Integer
        Dim numPennies As Integer
        Dim dollarAmount, avgCoinValue As Decimal


        ' GET data from the entry box
        numPennies = Val(txtEntry.Text)

        'DOLLAR amount
        dollarAmount = numPennies / 100

        ' USE Integer Division and Modulo
        '     to determine quarters, dimes, nickels
        quarters = numPennies \ QUARTER_VALUE
        numPennies = numPennies Mod QUARTER_VALUE
        dimes = numPennies \ DIME_VALUE
        numPennies = numPennies Mod DIME_VALUE
        nickels = numPennies \ NICKEL_VALUE
        numPennies = numPennies Mod NICKEL_VALUE
        pennies = numPennies




        ' PLACE answers into text boxes
        txtQuarters.Text = quarters.ToString("n0")
        txtDimes.Text = dimes.ToString("n0")
        txtNickels.Text = nickels.ToString("n0")
        txtPennies.Text = pennies.ToString("n0")
        txtDollarAmount.Text = dollarAmount.ToString("c")
    End Sub


End Class
