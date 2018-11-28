Public Class Form1

    Dim inputHours As Integer = 0
    Dim inputMinutes As Integer = 0
    Dim price As Double = 0
    Dim expireTime As DateTime
    Private currentTime As Object

    Dim currentState As Integer = 0
    Dim previousState As Integer = 0
    Dim currentTimeLeft As Integer = 0
    Dim amountEntered As Double = 0
    Dim amountPaid As Double = 0
    Dim accountNumber As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        MainMenu()
    End Sub

    Private Sub ResetValues()
        currentTimeLeft = 0
        amountEntered = 0
        amountPaid = 0
        accountNumber = ""
        inputHours = 0
        inputMinutes = 0
        price = 0
        modeTitle.Font = New Font("Arial Rounded MT Bold", 21.75, FontStyle.Bold)
        modeTitle.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub


    Private Sub hideAll()
        For Each objCtrl As Control In Me.Controls
            If TypeOf objCtrl Is Label Then
                Dim Lbl As Label = DirectCast(objCtrl, Label)
                Lbl.Hide()
            ElseIf TypeOf objCtrl Is Button Then
                Dim Btn As Button = DirectCast(objCtrl, Button)
                Btn.Hide()
            ElseIf TypeOf objCtrl Is PictureBox Then
                Dim Pic As PictureBox = DirectCast(objCtrl, PictureBox)
                Pic.Hide()

            End If
        Next
    End Sub

    'Modes
    Sub MainMenu()
        'STATE 0
        currentState = 0
        hideAll()
        'Hide
        ResetValues()
        'Show
        timeLabel.Show()
        modeTitle.Show()
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()

        newTicketButton.Show()
        newTicketLabel.Show()
        addTimeButton.Show()
        addTimeLabel.Show()
        refundButton.Show()
        refundTimeLabel.Show()
        xppButton.Show()
        xpLabel.Show()
        modeTitle.Text = "Main Menu"
    End Sub

    Sub NewTicket()
        'STATE 1
        currentState = 1
        hideAll()
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        'Hide
        'Show
        timeLabel.Show()
        modeTitle.Show()
        hourUpButton.Show()
        hourDownButton.Show()
        expireTimeLabel.Show()
        inputTime.Show()
        priceLabel.Show()
        desiredTimeLabel.Show()

        backButton.Show()
        maxTimeButton.Show()
        bigBottomButton.Show()
        bigBottomButton.BackColor = Color.FromArgb(0, 192, 0)
        bigBottomButton.Text = "Pay"

        currentTimeLeft = 0
        modeTitle.Text = "New Ticket"
        inputTime.Text = inputHours.ToString() + " hour(s)"
        UpdatePrice(inputHours)
        UpdateExpireTime(inputHours, 0)

    End Sub

    Sub AddSubmitTicket()
        currentState = 2
        hideAll()
        'STATE 4
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        modeTitle.Show()
        backButton.Show()
        timeLabel.Show()
        bigBottomButton.Show()
        failButton.Show()
        submitDesc.Show()
        submitDesc.Text = "Submit the ticket you wish to add time to:"

        bigBottomButton.Text = "Submit Ticket"
        bigBottomButton.BackColor = Color.FromArgb(255, 128, 255)
        modeTitle.Text = "Add More Time"
    End Sub

    Sub RefundSubmitTicket()
        currentState = 3
        hideAll()
        'STATE 3
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        modeTitle.Show()
        backButton.Show()
        timeLabel.Show()
        bigBottomButton.Show()
        submitDesc.Show()
        failButton.Show()

        submitDesc.Text = "Submit the ticket you wish to refund:"
        'ticket.Show()
        'Label2.Show()

        bigBottomButton.Text = "Submit Ticket"
        bigBottomButton.BackColor = Color.FromArgb(255, 128, 255)
        modeTitle.Text = "Refund Time"
    End Sub



    Sub selectPaymentType()
        'Hide
        hideAll()
        'STATE 4
        currentState = 4
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        editButton.Show()
        'Show
        backButton.Show()
        timeLabel.Show()
        selectCoinsButton.Show()
        selectCardButton.Show()
        'selectXPPButton.Show()
        amountDueLabel.Show()
        modeTitle.Show()
        coinsLabel.Show()
        ccLabel.Show()
        desiredExpiryTime.Show()

        modeTitle.Text = "Select Payment Method"
        amountDueLabel.Text = "Total Amount Due: $" + price.ToString
        If price < 12 Then
            desiredExpiryTime.Text = "Expires at: " + expireTime.ToString("h:mm tt")
        Else
            desiredExpiryTime.Text = "Expires at: 6:00 AM (tomorrow)"
        End If



    End Sub

    Sub AddTime()
        'STATE 5
        currentState = 5
        hideAll()
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        'Hide
        'Show
        backButton.Show()
        hourUpButton.Show()
        hourDownButton.Show()
        expireTimeLabel.Show()
        inputTime.Show()
        priceLabel.Show()
        'newTicketConfirmButton.Show()
        modeTitle.Show()
        timeLeftLabel.Show()
        timeLabel.Show()
        maxTimeButton.Show()
        bigBottomButton.Show()
        bigBottomButton.Text = "Pay"
        bigBottomButton.BackColor = Color.FromArgb(0, 192, 0)


        currentTimeLeft = 11
        modeTitle.ForeColor = Color.FromArgb(0, 192, 0)
        modeTitle.Text = "Ticket Read Successful!
Add more time"
        timeLeftLabel.Text = "Time Left: " + currentTimeLeft.ToString + " minutes"
        inputTime.Text = inputHours.ToString() + " hour"
        UpdatePrice(inputHours)
        UpdateExpireTime(inputHours, currentTimeLeft)
    End Sub

    Sub RefundTicket()
        'Hide
        hideAll()
        'STATE 6
        currentState = 6
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        'Show
        backButton.Show()
        timeLabel.Show()
        modeTitle.Show()
        refundLabel.Show()
        bigBottomButton.Show()
        bigBottomButton.Text = "OK"
        bigBottomButton.BackColor = Color.FromArgb(0, 192, 0)
        Label1.Show()
        currentTimeLeft = 230
        modeTitle.ForeColor = Color.FromArgb(0, 192, 0)
        modeTitle.Text = "Ticket Read Successful!"
        Dim intTime As Integer = currentTimeLeft
        Label1.Text = "You had " + Math.Floor(intTime / 60).ToString + " hours and " + (intTime Mod 60).ToString + " minutes remaining."
        refundLabel.Text = "You will be refunded: $" + Math.Round((currentTimeLeft / 60 * 2), 2).ToString
        bigBottomButton.Text = "Return to Main Menu"
    End Sub

    Sub PayCoin()
        'Hide
        hideAll()
        'STATE 7
        currentState = 7
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        editButton.Show()

        'Show
        amountDueLabel.Show()
        desiredExpiryTime.Show()
        amountEnteredLabel.Show()
        backButton.Show()
        timeLabel.Show()
        toonieButton.Show()
        toonieLabel.Show()
        loonieButton.Show()
        loonieLabel.Show()
        quarterButton.Show()
        quarterLabel.Show()
        modeTitle.Show()
        bigBottomButton.Show()

        bigBottomButton.BackColor = Color.FromArgb(0, 192, 0)
        bigBottomButton.Text = "Pay"
    End Sub

    Sub PayCard()
        'Hide
        hideAll()
        'STATE 8
        currentState = 8
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        editButton.Show()
        tapButton.Show()

        'Show
        backButton.Show()
        timeLabel.Show()
        accNbrButton.Show()
        'orLabel.Show()
        amountDueLabel.Show()
        desiredExpiryTime.Show()
        modeTitle.Show()
        bigBottomButton.Show()

        bigBottomButton.BackColor = Color.FromArgb(255, 128, 255)
        bigBottomButton.Text = "Sim Pay Credit/Debit"
        modeTitle.Text = "Pay By Card"
    End Sub

    Sub ConfirmPayment(amountPaid, price)
        'Hide
        hideAll()
        'State 10
        currentState = 10
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()


        backButton.Show()
        timeLabel.Show()
        modeTitle.Show()
        amountPaidLabel.Show()
        If previousState = 7 Then
            amountReturnedLabel.Show()
        Else
            amountReturnedLabel.Hide()
        End If


        bigBottomButton.Show()
        bigBottomButton.BackColor = Color.FromArgb(0, 192, 0)
        bigBottomButton.Text = "Print Ticket"
        modeTitle.ForeColor = Color.FromArgb(0, 192, 0)
        modeTitle.Text = "Payment Successful!"
        amountPaidLabel.Text = "Amount Paid: $" + amountPaid.ToString
        Dim amountReturned As Integer
        amountReturned = amountPaid - price
        amountReturnedLabel.Text = "Change Returned: $" + amountReturned.ToString


    End Sub

    Sub PrintTicket()
        hideAll()
        'STATE 11
        currentState = 11
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        ticket.Show()
        backButton.Show()
        timeLabel.Show()
        modeTitle.Show()
        bigBottomButton.Show()
        bigBottomButton.BackColor = Color.FromArgb(255, 128, 255)
        modeTitle.Font = New Font("Arial Rounded MT Bold", 14, FontStyle.Bold)
        modeTitle.Text = "Ticket has been printed. Please leave this ticket on your dashboard"
        bigBottomButton.Text = "Take Ticket"
    End Sub

    Sub EnterAccountNbr()
        'Hide
        hideAll()
        'STATE 12
        currentState = 12
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        backButton.Show()
        timeLabel.Show()
        numPad0.Show()
        numPad1.Show()
        numPad2.Show()
        numPad3.Show()
        numPad4.Show()
        numPad5.Show()
        numPad6.Show()
        numPad7.Show()
        numPad8.Show()
        numPad9.Show()
        clearButton.Show()
        backspButton.Show()
        bigBottomButton.Show()
        accountNumberLabel.Show()
        failButton.Show()

        bigBottomButton.BackColor = Color.FromArgb(0, 192, 0)
        accountNumberLabel.Text = "Account #: " + accountNumber
        bigBottomButton.Text = "Enter"
    End Sub

    Sub XPPUsers()
        'Hide
        hideAll()
        'STATE 13
        currentState = 13
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        backButton.Show()
        timeLabel.Show()
        failButton.Show()
        tapPic.Show()
        xppDesc.Show()
        bigBottomButton.Show()
        bigBottomButton.BackColor = Color.FromArgb(255, 128, 255)
        bigBottomButton.Text = "Tap Card"
        xppDesc.Text = "Tap your XpressPark card below to sign in."


    End Sub
    Sub XPPark()
        'Hide
        hideAll()
        'STATE 14
        currentState = 14
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        backButton.Show()
        timeLabel.Show()
        xppDesc.Show()
        xppDesc.Text = "Please take your ticket and place it on your dashboard. Have a great day!"
        bigBottomButton.Show()
        bigBottomButton.BackColor = Color.FromArgb(255, 128, 255)
        bigBottomButton.Text = "Take Ticket & Sign Out"


    End Sub
    Sub XPLeave()
        'Hide
        hideAll()
        'STATE 15
        currentState = 15
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        'backButton.Show()
        timeLabel.Show()
        xppDesc.Show()

        bigBottomButton.Show()
        bigBottomButton.BackColor = Color.FromArgb(255, 128, 255)
        bigBottomButton.Text = "Sign Out"

        xppDesc.Text = "Total time parked: 4 hour(s) 
Charge of $8 to your account"


    End Sub
    Sub XPSignedIn()
        'Hide
        hideAll()
        'STATE 16
        currentState = 16
        'stateNumber.Show()
        'stateNumber.Text = currentState
        rateLabel1.Show()
        rateLabel2.Show()
        backButton.Show()
        timeLabel.Show()
        parkButton.Show()
        leaveButton.Show()
        xppDesc.Show()
        xppDesc.Text = "Signed in as User: 12394234.
Are you parking or leaving?"


    End Sub


    'UPDATE FUNCTIONS

    Sub UpdatePrice(hours As Integer)
        price = 2 * hours
        priceLabel.Text = "Price: $" + price.ToString

    End Sub

    Sub UpdateExpireTime(hours, currentTimeLeft)
        If hours = 6 Then
            expireTimeLabel.Text = "Parking Ticket Valid until: 6:00 AM"

        Else
            currentTime = TimeOfDay
            expireTime = TimeOfDay.AddHours(hours)
            expireTime = expireTime.AddMinutes(currentTimeLeft)
            expireTimeLabel.Text = "Parking Ticket Valid until: " + expireTime.ToString("h:mm tt")
        End If
    End Sub

    Sub UpdateAccountNumber()
        accountNumberLabel.Text = "Account #: " + accountNumber
    End Sub



    Sub UpdateAmountEntered(amount)
        amountEntered += amount
        amountEnteredLabel.Text = "Amount entered: $" + amountEntered.ToString

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timeLabel.Text = TimeOfDay.ToString("h:mm tt")
    End Sub


    ' MAIN MENU BUTTONS
    '-----------------------------------------------------------------------
    Private Sub newTicketButton_Click(sender As Object, e As EventArgs) Handles newTicketButton.Click
        previousState = currentState 'STATE 0
        NewTicket()
    End Sub
    Private Sub addTimeButton_Click(sender As Object, e As EventArgs) Handles addTimeButton.Click
        previousState = currentState 'STATE 0
        AddSubmitTicket()
    End Sub
    Private Sub refundButton_Click(sender As Object, e As EventArgs) Handles refundButton.Click
        previousState = currentState 'STATE 0
        RefundSubmitTicket()
    End Sub
    Private Sub xppButton_Click(sender As Object, e As EventArgs) Handles xppButton.Click
        previousState = currentState
        XPPUsers()

    End Sub

    ' BACK BUTTON
    '-----------------------------------------------------------------------

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Select Case currentState
            Case 1 To 3
                previousState = currentState
                MainMenu()
            Case 4
                If previousState = 5 Then
                    previousState = currentState
                    AddTime()
                Else
                    previousState = currentState
                    NewTicket()
                End If
            Case 5
                previousState = currentState
                AddSubmitTicket()
            Case 6
                previousState = currentState
                RefundSubmitTicket()
            Case 7 To 9
                previousState = currentState
                selectPaymentType()
            Case 10
                previousState = currentState
                PayCoin()
            Case 11
                previousState = currentState
                MainMenu()
            Case 12
                previousState = currentState
                PayCard()
            Case 14
                previousState = currentState
                XPSignedIn()
            Case 13
                previousState = currentState
                MainMenu()
            Case 16
                previousState = currentState
                MainMenu()
        End Select
    End Sub
    ' BIG BOTTOM BUTTON
    '-----------------------------------------------------------------------
    Private Sub bigBottomButton_Click(sender As Object, e As EventArgs) Handles bigBottomButton.Click
        modeTitle.ForeColor = Color.FromArgb(255, 255, 255)
        If currentState = 1 Then
            If inputHours > 0 Then
                previousState = currentState
                selectPaymentType()
            Else
                MsgBox("Enter a value greater than 0")
            End If

        ElseIf currentState = 2 Then
            previousState = currentState
            AddTime()
        ElseIf currentState = 3 Then
            previousState = currentState
            RefundTicket()
        ElseIf currentState = 5 Then
            previousState = currentState
            selectPaymentType()
        ElseIf currentState = 6 Then
            modeTitle.ForeColor = Color.FromArgb(255, 255, 255)
            previousState = currentState
            MainMenu()
        ElseIf currentState = 7 Then
            If amountEntered >= price Then
                previousState = currentState
                ConfirmPayment(amountEntered, price)
            Else
                MsgBox("Not enough funds")
            End If
        ElseIf currentState = 11 Then
            MsgBox("Expiry Time: " + expireTime.ToString("h:mm tt") + " Transaction #: 65465168764")
            MainMenu()
        ElseIf currentState = 12 Then
            ConfirmPayment(price, price)
        ElseIf currentState = 13 Then
            XPSignedIn()
        ElseIf currentState = 14 Then
            MsgBox("XPPark User: 12343452345  Sign In Time: " + expireTime.ToString("h:mm tt") + " Transaction #: 65465168764")
            MainMenu()
        ElseIf currentState = 15 Then
            MainMenu()
        Else
            PrintTicket()
        End If
    End Sub

    Private Sub HourUpButton_Click(sender As Object, e As EventArgs) Handles hourUpButton.Click
        If inputHours <= 5 Then
            inputHours += 1
            inputTime.Text = inputHours.ToString() + " hour(s)"
        Else
            inputTime.Text = "All Day Parking"
            MsgBox("6 hours is the max that can be paid")

        End If
        UpdatePrice(inputHours)
        UpdateExpireTime(inputHours, currentTimeLeft)
    End Sub

    Private Sub HourDownButton_Click(sender As Object, e As EventArgs) Handles hourDownButton.Click
        If inputHours > 0 Then
            inputHours -= 1
        End If
        inputTime.Text = inputHours.ToString() + " hour(s)"
        UpdatePrice(inputHours)
        UpdateExpireTime(inputHours, currentTimeLeft)
    End Sub


    Private Sub maxTimeButton_Click(sender As Object, e As EventArgs) Handles maxTimeButton.Click
        inputHours = 6 'change to const
        inputTime.Text = inputHours.ToString() + " hour(s)"
        UpdatePrice(inputHours)
        UpdateExpireTime(inputHours, currentTimeLeft)
    End Sub


    Private Sub toonieButton_Click(sender As Object, e As EventArgs) Handles toonieButton.Click
        UpdateAmountEntered(2)

    End Sub

    Private Sub selectCoinsButton_Click(sender As Object, e As EventArgs) Handles selectCoinsButton.Click
        PayCoin()
    End Sub

    Private Sub loonieButton_Click(sender As Object, e As EventArgs) Handles loonieButton.Click
        UpdateAmountEntered(1)

    End Sub

    Private Sub quarterButton_Click(sender As Object, e As EventArgs) Handles quarterButton.Click
        UpdateAmountEntered(0.25)

    End Sub

    Private Sub payButton_Click(sender As Object, e As EventArgs)
        If amountEntered >= price Then
            ConfirmPayment(amountEntered, price)
        Else
            MsgBox("Not enough funds")
        End If

    End Sub

    Private Sub parkButton_Click(sender As Object, e As EventArgs) Handles parkButton.Click
        XPPark()
    End Sub
    Private Sub leaveButton_Click(sender As Object, e As EventArgs) Handles leaveButton.Click
        XPLeave()
    End Sub

    Private Sub selectCardButton_Click(sender As Object, e As EventArgs) Handles selectCardButton.Click
        PayCard()
    End Sub

    Private Sub insertCardButton_Click(sender As Object, e As EventArgs)
        ConfirmPayment(amountPaid, price)
    End Sub

    Private Sub accNbrButton_Click(sender As Object, e As EventArgs) Handles accNbrButton.Click
        EnterAccountNbr()

    End Sub

    Private Sub numPad8_Click(sender As Object, e As EventArgs) Handles numPad8.Click
        accountNumber += "8"
        UpdateAccountNumber()
    End Sub

    Private Sub numPad1_Click(sender As Object, e As EventArgs) Handles numPad1.Click
        accountNumber += "1"
        UpdateAccountNumber()
    End Sub

    Private Sub numPad2_Click(sender As Object, e As EventArgs) Handles numPad2.Click
        accountNumber += "2"
        UpdateAccountNumber()
    End Sub

    Private Sub numPad3_Click(sender As Object, e As EventArgs) Handles numPad3.Click
        accountNumber += "3"
        UpdateAccountNumber()
    End Sub

    Private Sub numPad6_Click(sender As Object, e As EventArgs) Handles numPad6.Click
        accountNumber += "6"
        UpdateAccountNumber()
    End Sub

    Private Sub numPad5_Click(sender As Object, e As EventArgs) Handles numPad5.Click
        accountNumber += "5"
        UpdateAccountNumber()
    End Sub

    Private Sub numPad4_Click(sender As Object, e As EventArgs) Handles numPad4.Click
        accountNumber += "4"
        UpdateAccountNumber()
    End Sub

    Private Sub numPad7_Click(sender As Object, e As EventArgs) Handles numPad7.Click
        accountNumber += "7"
        UpdateAccountNumber()
    End Sub

    Private Sub numPad0_Click(sender As Object, e As EventArgs) Handles numPad0.Click
        accountNumber += "0"
        UpdateAccountNumber()
    End Sub

    Private Sub numPad9_Click(sender As Object, e As EventArgs) Handles numPad9.Click
        accountNumber += "9"
        UpdateAccountNumber()
    End Sub

    Private Sub backspButton_Click(sender As Object, e As EventArgs) Handles backspButton.Click
        If accountNumber.Length > 0 Then
            accountNumber = accountNumber.Substring(0, accountNumber.Length - 1)
            UpdateAccountNumber()
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        accountNumber = ""
        UpdateAccountNumber()
    End Sub

    Private Sub confirmNumButton_Click(sender As Object, e As EventArgs)
        ConfirmPayment(price, price)
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click

        If previousState = 5 Then
            AddTime()
        Else
            NewTicket()
        End If
    End Sub

    Private Sub failButton_Click(sender As Object, e As EventArgs) Handles failButton.Click
        If currentState = 12 Then
            MsgBox("Failed to Authenticate. Retry entering the account number.")
        ElseIf currentState = 13 Then
            MsgBox("Failed to Authenticate. Card not recognized. Please try again.")
        ElseIf currentState = 2 Or 3 Then
            MsgBox("Failed to read ticket. Try submitting ticket again.")
        End If

    End Sub

    Private Sub tapButton_Click(sender As Object, e As EventArgs) Handles tapButton.Click
        ConfirmPayment(price, price)
    End Sub
End Class
