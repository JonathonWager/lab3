'Jonathon Wager 100698641
'2/25/2020
'Netd2202
'Average Units Shipped Program

'Enabling Option Strict
Option Strict On
Public Class Form1
    'Varible Declerations

    'Const Vars
    Private Const maxUnits As Int32 = 5000
    Private Const minUnits As Int32 = 0
    Private Const maxDays As Int32 = 7

    'Arrays storing dailey Units shiped and one for storing employee week totals
    Private unitsArray(2, 6) As String
    Private empTotals(2) As Double

    'Counters one for the day And the current employee
    Private dayCounter As Int32 = 0
    Private currentEmp As Int32 = 0

    'Final total of units shiped bar and two Vars that just get used for testing
    Private finalTotal As Double = 0
    Private holdVar As Int32
    Private userInVal As Integer

    'Validation Function
    Private Function Validate(ByVal userIn1 As String, ByRef userInVal As Integer) As Boolean
        'New boolean Varible set to true
        Dim returnValidation As Boolean = True
        Dim userIn2 As Integer

        'Testing to see if input was an Integer
        If (Integer.TryParse(userIn1, userIn2)) Then
            'if it is an int check to see if its in range
            If userIn2 >= minUnits AndAlso userIn2 <= maxUnits Then
                userInVal = userIn2
                returnValidation = True
                'if it is return true if not return false
            Else
                returnValidation = False


            End If
        Else
            returnValidation = False

        End If
        Return returnValidation

    End Function

    'This function calculates the final average units sold between all three employees
    Private Sub getfTotal()
        For index As Int32 = 0 To 2

            finalTotal = finalTotal + Convert.ToInt32(empTotals(index))
        Next
        'Rounds average and displays it
        lblTotalUnits.Text = "Average per Day: " & Math.Round((finalTotal / 3), 2)
    End Sub


    Private Sub updateDay(curDay As Int32)
        If curDay = 99 Then
            lblDayCount.Text = String.Concat("Done")
        Else
            lblDayCount.Text = String.Concat("Day: ", Convert.ToString(curDay + 1))
        End If

    End Sub

    'This calculates the average for each employees week
    Private Sub calcTotal(curEmp As Int32)
        'for loop going through each day and adding them to emp totals
        For index As Int32 = 0 To 6
            holdVar = Integer.Parse(unitsArray(curEmp, index))
            empTotals(curEmp) = holdVar + empTotals(curEmp)
        Next
        'getting avg
        empTotals(curEmp) = empTotals(curEmp) / 7
        'depending on what employee is being eneterd set corisponding lbl
        If curEmp = 0 Then
            lblEmp1Total.Text = "Average: " & Math.Round(empTotals(curEmp), 2)
        ElseIf curEmp = 1 Then
            MessageBox.Show("hi")
            lblEmp2Total.Text = "Average: " & Math.Round(empTotals(curEmp), 2)
        Else
            lblEmp3Total.Text = "Average: " & Math.Round(empTotals(curEmp), 2)
        End If
    End Sub
    'updates the employee txt boxes that show the daily units
    Private Sub updateTxt(curEmp As Int32)
        'if statements to determine what employee is current
        If currentEmp = 0 Then
            txtEmp1.Text = ""
            For index As Int32 = 0 To 6
                txtEmp1.Text = String.Concat(txtEmp1.Text, unitsArray(curEmp, index))
                txtEmp1.Text = String.Concat(txtEmp1.Text, Environment.NewLine)
            Next
        End If
        If currentEmp = 1 Then
            txtEmp2.Text = ""
            For index As Int32 = 0 To 6
                txtEmp2.Text = String.Concat(txtEmp2.Text, unitsArray(curEmp, index))
                txtEmp2.Text = String.Concat(txtEmp2.Text, Environment.NewLine)
            Next
        End If
        If currentEmp = 2 Then
            txtEmp3.Text = ""
            For index As Int32 = 0 To 6
                txtEmp3.Text = String.Concat(txtEmp3.Text, unitsArray(curEmp, index))
                txtEmp3.Text = String.Concat(txtEmp3.Text, Environment.NewLine)
            Next
        End If


    End Sub
    'On enter Click
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'Check to see if employee Labels need bolding
        If dayCounter = (maxDays - 1) Then
            If currentEmp = 0 Then
                lblEmp2.Font = New Font(lblEmp2.Font, FontStyle.Bold)
                lblEmp1.Font = New Font(lblEmp1.Font, FontStyle.Regular)
            End If
            If currentEmp = 1 Then
                lblEmp3.Font = New Font(lblEmp3.Font, FontStyle.Bold)
                lblEmp2.Font = New Font(lblEmp2.Font, FontStyle.Regular)
            End If
        End If
        'calling validation function
        If Validate(txtUnitBox.Text, userInVal) = False Then
            'if val falied
            MessageBox.Show("Please only Enter whole numbers withen in the Range of 0 and 5000", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtUnitBox.Text = ""
            txtUnitBox.Focus()

        Else
            'if val passed
            unitsArray(currentEmp, dayCounter) = txtUnitBox.Text
            updateTxt(currentEmp)
            'increment dayCounter
            dayCounter = dayCounter + 1

            'if week is over
            If dayCounter = maxDays Then
                'get the avg for current emp
                calcTotal(currentEmp)
                updateDay(0)
                currentEmp = currentEmp + 1

                dayCounter = 0
            Else
                updateDay(dayCounter)
            End If

            'reset unitBox
            txtUnitBox.Text = ""
            txtUnitBox.Focus()
        End If
        'if week has ended and all employees units entered
        If currentEmp = 3 And dayCounter = (maxDays - 7) Then
            'get final avg
            getfTotal()
            'set day to done
            updateDay(99)
            'reset focus
            btnReset.Focus()
            'rebold
            lblEmp1.Font = New Font(lblEmp1.Font, FontStyle.Bold)
            lblEmp3.Font = New Font(lblEmp3.Font, FontStyle.Regular)
            'disable controls
            btnEnter.Enabled = False
            txtUnitBox.Enabled = False
        End If


    End Sub
    'on load setting tooltips
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttEnter.SetToolTip(btnEnter, "This Button submits Todays Units(You may also press Enter)")
        ttReset.SetToolTip(btnReset, "This Resets the Form to Original State")
        ttExit.SetToolTip(btnExit, "This Exits the form You can also just press Escape Key")
        ttUnits.SetToolTip(txtUnitBox, "Please Enter Units for Current day(Whole Numbers from 0-5000 are accepted) ")
    End Sub
    'on reset setting the form back to default
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ReDim unitsArray(2, 6)
        ReDim empTotals(2)
        btnEnter.Enabled = True
        txtUnitBox.Enabled = True

        txtEmp1.Text = ""
        txtEmp2.Text = ""
        txtEmp3.Text = ""

        lblEmp1Total.Text = ""
        lblEmp2Total.Text = ""
        lblEmp3Total.Text = ""
        lblTotalUnits.Text = ""

        currentEmp = 0
        dayCounter = 0
        finalTotal = 0


        txtUnitBox.Focus()

        updateDay(dayCounter)

    End Sub
    'On exit close program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
