'Author: Julie Rapson
'Date: 4/13/2023
'Program Name: Smart Home Electric Savings
'Program Dscription: The program allows you to choose a month from the dropdown and it will tell you how much
'savings were in that month selected.  If you click Display statistics button, it will give you the 
'Average monthly savings as well as tell you the month with the MAX monthly savings. 

Option Strict On
Public Class frmSmartHome
    'Declare private variables which includes the array
    'The array is broken down by the size of it (0 starting and 12 months so 11)
    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal
    Private Sub frmSmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declare variables needed to read file as well as variables for the savings amount
        'and a conter to increment through the array.
        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer
        'Reset all labels to no text
        lblSavingsMonth.Text = ""
        lblSavingsMax.Text = ""
        lblSavingsAvg.Text = ""

        'If IO.File.Exists("C:\Users\myram\OneDrive\classes\GUID2023\Weeklyassignment8\text.txt") Then
        'objReader = IO.File.OpenText("C:\Users\myram\OneDrive\classes\GUID2023\Weeklyassignment8\text.txt")

        'I tried the Try/Catch but was not able to get it to work properly so I backed it out :( 

        'I moved the text file into the debug folder so I could call it with no path.  Hoping this works outside of testing in my
        'environment :) 
        If IO.File.Exists("text.txt") Then
            objReader = IO.File.OpenText("text.txt")
            'read line by line
            Do While objReader.Peek <> -1
                _strSavings(intCount) = objReader.ReadLine()
                strSavingsAmount = objReader.ReadLine()
                _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                intCount += 1
            Loop
            objReader.Close()
            'Fill combo box
            For intFill = 0 To (_strSavings.Length - 1)
                cboMonth.Items.Add(_strSavings(intFill))
            Next
        Else
            MsgBox("The file is not available or the path is incorrect.", , "Error")
            Close()
        End If
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        ' When a selection is made on drop down, it will print out the savings amount for that selection.
        'Also have to make the label visible and the button visible
        Dim intSelectMonth As Integer
        intSelectMonth = cboMonth.SelectedIndex
        lblSavingsMonth.Visible = True
        lblSavingsMonth.Text = "The electric savings for " & _strSavings(intSelectMonth) & " is $" & _decBill(intSelectMonth).ToString()
        btnDisplayStats.Visible = True

    End Sub

    Private Sub btnDisplayStats_Click(sender As Object, e As EventArgs) Handles btnDisplayStats.Click
        'Calling the subs to do the calculations and results display
        CalcAvg()
        CalcMax()
    End Sub

    Private Sub CalcAvg()
        'This sub is to calculate the average month.
        'Must iterate through the months to get the average
        Dim decTotal As Decimal = 0D
        Dim decAvg As Decimal = 0D
        Dim intYr As Integer
        Dim intNumYr As Integer

        For Each intNumYr In _decBill
            decTotal += _decBill(intYr)
            intYr += 1
        Next
        decAvg = decTotal / Convert.ToDecimal(_decBill.Length())
        'Make the lable visible here and set the text message for label
        lblSavingsAvg.Visible = True
        lblSavingsAvg.Text = "The average monthly savings: " & decAvg.ToString("C2")
    End Sub
    Private Sub CalcMax()
        'This sub is to calculate the highest savings month.
        '
        Dim IntMonth As Integer
        Dim IntMaxNum As Integer = 0
        Dim IntSelection As Integer = 0
        Dim strMaxMonth As String = ""

        For Each IntMonth In _decBill
            IntMaxNum = Math.Max(IntMaxNum, IntMonth)
            If (IntMonth >= IntMaxNum) Then
                strMaxMonth = _strSavings(IntSelection)
            End If
            IntSelection += 1
        Next
        'Make the lable visible here and set the text message for label
        lblSavingsMax.Visible = True
        lblSavingsMax.Text = strMaxMonth & " had the most significant monthly savings."
    End Sub


End Class
