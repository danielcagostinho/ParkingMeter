<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Button()
        Me.modeTitle = New System.Windows.Forms.Label()
        Me.inputTime = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.expireTimeLabel = New System.Windows.Forms.Label()
        Me.amountDueLabel = New System.Windows.Forms.Label()
        Me.maxTimeButton = New System.Windows.Forms.Button()
        Me.timeLeftLabel = New System.Windows.Forms.Label()
        Me.amountEnteredLabel = New System.Windows.Forms.Label()
        Me.amountPaidLabel = New System.Windows.Forms.Label()
        Me.amountReturnedLabel = New System.Windows.Forms.Label()
        Me.bigBottomButton = New System.Windows.Forms.Button()
        Me.accNbrButton = New System.Windows.Forms.Button()
        Me.numPad7 = New System.Windows.Forms.Button()
        Me.numPad8 = New System.Windows.Forms.Button()
        Me.numPad9 = New System.Windows.Forms.Button()
        Me.numPad4 = New System.Windows.Forms.Button()
        Me.numPad5 = New System.Windows.Forms.Button()
        Me.numPad6 = New System.Windows.Forms.Button()
        Me.numPad1 = New System.Windows.Forms.Button()
        Me.numPad2 = New System.Windows.Forms.Button()
        Me.numPad3 = New System.Windows.Forms.Button()
        Me.numPad0 = New System.Windows.Forms.Button()
        Me.refundLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.coinsLabel = New System.Windows.Forms.Label()
        Me.ccLabel = New System.Windows.Forms.Label()
        Me.xpLabel = New System.Windows.Forms.Label()
        Me.newTicketLabel = New System.Windows.Forms.Label()
        Me.addTimeLabel = New System.Windows.Forms.Label()
        Me.refundTimeLabel = New System.Windows.Forms.Label()
        Me.toonieLabel = New System.Windows.Forms.Label()
        Me.loonieLabel = New System.Windows.Forms.Label()
        Me.quarterLabel = New System.Windows.Forms.Label()
        Me.stateNumber = New System.Windows.Forms.Label()
        Me.desiredTimeLabel = New System.Windows.Forms.Label()
        Me.accountNumberLabel = New System.Windows.Forms.Label()
        Me.desiredExpiryTime = New System.Windows.Forms.Label()
        Me.parkButton = New System.Windows.Forms.Button()
        Me.leaveButton = New System.Windows.Forms.Button()
        Me.xppDesc = New System.Windows.Forms.Label()
        Me.rateLabel1 = New System.Windows.Forms.Label()
        Me.rateLabel2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.editButton = New System.Windows.Forms.Button()
        Me.failButton = New System.Windows.Forms.Button()
        Me.submitDesc = New System.Windows.Forms.Label()
        Me.tapButton = New System.Windows.Forms.Button()
        Me.xppButton = New System.Windows.Forms.Button()
        Me.hourUpButton = New System.Windows.Forms.Button()
        Me.newTicketButton = New System.Windows.Forms.Button()
        Me.toonieButton = New System.Windows.Forms.Button()
        Me.backspButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.quarterButton = New System.Windows.Forms.Button()
        Me.hourDownButton = New System.Windows.Forms.Button()
        Me.selectCoinsButton = New System.Windows.Forms.Button()
        Me.selectCardButton = New System.Windows.Forms.Button()
        Me.addTimeButton = New System.Windows.Forms.Button()
        Me.refundButton = New System.Windows.Forms.Button()
        Me.ticket = New System.Windows.Forms.PictureBox()
        Me.tapPic = New System.Windows.Forms.PictureBox()
        Me.loonieButton = New System.Windows.Forms.Button()
        CType(Me.ticket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tapPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'timeLabel
        '
        Me.timeLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.ForeColor = System.Drawing.Color.White
        Me.timeLabel.Location = New System.Drawing.Point(0, 0)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(948, 55)
        Me.timeLabel.TabIndex = 0
        Me.timeLabel.Text = "CurrentTime"
        Me.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'backButton
        '
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.Location = New System.Drawing.Point(12, 12)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(113, 50)
        Me.backButton.TabIndex = 5
        Me.backButton.Text = "BACK"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'modeTitle
        '
        Me.modeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modeTitle.ForeColor = System.Drawing.Color.White
        Me.modeTitle.Location = New System.Drawing.Point(236, 50)
        Me.modeTitle.Name = "modeTitle"
        Me.modeTitle.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.modeTitle.Size = New System.Drawing.Size(485, 94)
        Me.modeTitle.TabIndex = 9
        Me.modeTitle.Text = "Main Menu"
        Me.modeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'inputTime
        '
        Me.inputTime.AutoSize = True
        Me.inputTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTime.ForeColor = System.Drawing.Color.White
        Me.inputTime.Location = New System.Drawing.Point(356, 221)
        Me.inputTime.Name = "inputTime"
        Me.inputTime.Size = New System.Drawing.Size(158, 37)
        Me.inputTime.TabIndex = 14
        Me.inputTime.Text = "inputTime"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.ForeColor = System.Drawing.Color.White
        Me.priceLabel.Location = New System.Drawing.Point(361, 363)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(79, 33)
        Me.priceLabel.TabIndex = 15
        Me.priceLabel.Text = "price"
        '
        'expireTimeLabel
        '
        Me.expireTimeLabel.AutoSize = True
        Me.expireTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expireTimeLabel.ForeColor = System.Drawing.Color.White
        Me.expireTimeLabel.Location = New System.Drawing.Point(362, 308)
        Me.expireTimeLabel.Name = "expireTimeLabel"
        Me.expireTimeLabel.Size = New System.Drawing.Size(106, 24)
        Me.expireTimeLabel.TabIndex = 16
        Me.expireTimeLabel.Text = "expireTime"
        '
        'amountDueLabel
        '
        Me.amountDueLabel.AutoSize = True
        Me.amountDueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountDueLabel.ForeColor = System.Drawing.Color.White
        Me.amountDueLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.amountDueLabel.Location = New System.Drawing.Point(312, 107)
        Me.amountDueLabel.Name = "amountDueLabel"
        Me.amountDueLabel.Size = New System.Drawing.Size(214, 37)
        Me.amountDueLabel.TabIndex = 22
        Me.amountDueLabel.Text = "Amount Due: "
        '
        'maxTimeButton
        '
        Me.maxTimeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxTimeButton.Location = New System.Drawing.Point(608, 175)
        Me.maxTimeButton.Name = "maxTimeButton"
        Me.maxTimeButton.Size = New System.Drawing.Size(151, 126)
        Me.maxTimeButton.TabIndex = 23
        Me.maxTimeButton.Text = "All Day Parking"
        Me.maxTimeButton.UseVisualStyleBackColor = True
        '
        'timeLeftLabel
        '
        Me.timeLeftLabel.AutoSize = True
        Me.timeLeftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLeftLabel.ForeColor = System.Drawing.Color.White
        Me.timeLeftLabel.Location = New System.Drawing.Point(376, 112)
        Me.timeLeftLabel.Name = "timeLeftLabel"
        Me.timeLeftLabel.Size = New System.Drawing.Size(97, 24)
        Me.timeLeftLabel.TabIndex = 25
        Me.timeLeftLabel.Text = "Time Left: "
        '
        'amountEnteredLabel
        '
        Me.amountEnteredLabel.AutoSize = True
        Me.amountEnteredLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountEnteredLabel.ForeColor = System.Drawing.Color.White
        Me.amountEnteredLabel.Location = New System.Drawing.Point(329, 363)
        Me.amountEnteredLabel.Name = "amountEnteredLabel"
        Me.amountEnteredLabel.Size = New System.Drawing.Size(269, 33)
        Me.amountEnteredLabel.TabIndex = 29
        Me.amountEnteredLabel.Text = "Amount entered: $0"
        '
        'amountPaidLabel
        '
        Me.amountPaidLabel.AutoSize = True
        Me.amountPaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountPaidLabel.ForeColor = System.Drawing.Color.White
        Me.amountPaidLabel.Location = New System.Drawing.Point(306, 145)
        Me.amountPaidLabel.Name = "amountPaidLabel"
        Me.amountPaidLabel.Size = New System.Drawing.Size(194, 33)
        Me.amountPaidLabel.TabIndex = 31
        Me.amountPaidLabel.Text = "Amount paid: "
        '
        'amountReturnedLabel
        '
        Me.amountReturnedLabel.AutoSize = True
        Me.amountReturnedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountReturnedLabel.ForeColor = System.Drawing.Color.White
        Me.amountReturnedLabel.Location = New System.Drawing.Point(303, 188)
        Me.amountReturnedLabel.Name = "amountReturnedLabel"
        Me.amountReturnedLabel.Size = New System.Drawing.Size(259, 33)
        Me.amountReturnedLabel.TabIndex = 32
        Me.amountReturnedLabel.Text = "Change Returned: "
        '
        'bigBottomButton
        '
        Me.bigBottomButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bigBottomButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bigBottomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bigBottomButton.ForeColor = System.Drawing.Color.White
        Me.bigBottomButton.Location = New System.Drawing.Point(379, 428)
        Me.bigBottomButton.Name = "bigBottomButton"
        Me.bigBottomButton.Size = New System.Drawing.Size(181, 135)
        Me.bigBottomButton.TabIndex = 33
        Me.bigBottomButton.Text = "Print Ticket"
        Me.bigBottomButton.UseVisualStyleBackColor = False
        '
        'accNbrButton
        '
        Me.accNbrButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accNbrButton.Location = New System.Drawing.Point(376, 233)
        Me.accNbrButton.Name = "accNbrButton"
        Me.accNbrButton.Size = New System.Drawing.Size(181, 135)
        Me.accNbrButton.TabIndex = 35
        Me.accNbrButton.Text = "Enter Account #"
        Me.accNbrButton.UseVisualStyleBackColor = True
        '
        'numPad7
        '
        Me.numPad7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!)
        Me.numPad7.Location = New System.Drawing.Point(350, 130)
        Me.numPad7.Name = "numPad7"
        Me.numPad7.Size = New System.Drawing.Size(75, 67)
        Me.numPad7.TabIndex = 36
        Me.numPad7.Text = "7"
        Me.numPad7.UseVisualStyleBackColor = True
        '
        'numPad8
        '
        Me.numPad8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!)
        Me.numPad8.Location = New System.Drawing.Point(431, 130)
        Me.numPad8.Name = "numPad8"
        Me.numPad8.Size = New System.Drawing.Size(75, 67)
        Me.numPad8.TabIndex = 37
        Me.numPad8.Text = "8"
        Me.numPad8.UseVisualStyleBackColor = True
        '
        'numPad9
        '
        Me.numPad9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!)
        Me.numPad9.Location = New System.Drawing.Point(512, 130)
        Me.numPad9.Name = "numPad9"
        Me.numPad9.Size = New System.Drawing.Size(75, 67)
        Me.numPad9.TabIndex = 38
        Me.numPad9.Text = "9"
        Me.numPad9.UseVisualStyleBackColor = True
        '
        'numPad4
        '
        Me.numPad4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!)
        Me.numPad4.Location = New System.Drawing.Point(350, 200)
        Me.numPad4.Name = "numPad4"
        Me.numPad4.Size = New System.Drawing.Size(75, 70)
        Me.numPad4.TabIndex = 39
        Me.numPad4.Text = "4"
        Me.numPad4.UseVisualStyleBackColor = True
        '
        'numPad5
        '
        Me.numPad5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!)
        Me.numPad5.Location = New System.Drawing.Point(431, 200)
        Me.numPad5.Name = "numPad5"
        Me.numPad5.Size = New System.Drawing.Size(75, 70)
        Me.numPad5.TabIndex = 40
        Me.numPad5.Text = "5"
        Me.numPad5.UseVisualStyleBackColor = True
        '
        'numPad6
        '
        Me.numPad6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!)
        Me.numPad6.Location = New System.Drawing.Point(512, 200)
        Me.numPad6.Name = "numPad6"
        Me.numPad6.Size = New System.Drawing.Size(75, 70)
        Me.numPad6.TabIndex = 41
        Me.numPad6.Text = "6"
        Me.numPad6.UseVisualStyleBackColor = True
        '
        'numPad1
        '
        Me.numPad1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!)
        Me.numPad1.Location = New System.Drawing.Point(350, 273)
        Me.numPad1.Name = "numPad1"
        Me.numPad1.Size = New System.Drawing.Size(75, 73)
        Me.numPad1.TabIndex = 42
        Me.numPad1.Text = "1"
        Me.numPad1.UseVisualStyleBackColor = True
        '
        'numPad2
        '
        Me.numPad2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!)
        Me.numPad2.Location = New System.Drawing.Point(431, 273)
        Me.numPad2.Name = "numPad2"
        Me.numPad2.Size = New System.Drawing.Size(75, 73)
        Me.numPad2.TabIndex = 43
        Me.numPad2.Text = "2"
        Me.numPad2.UseVisualStyleBackColor = True
        '
        'numPad3
        '
        Me.numPad3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!)
        Me.numPad3.Location = New System.Drawing.Point(512, 273)
        Me.numPad3.Name = "numPad3"
        Me.numPad3.Size = New System.Drawing.Size(75, 73)
        Me.numPad3.TabIndex = 44
        Me.numPad3.Text = "3"
        Me.numPad3.UseVisualStyleBackColor = True
        '
        'numPad0
        '
        Me.numPad0.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPad0.Location = New System.Drawing.Point(431, 350)
        Me.numPad0.Name = "numPad0"
        Me.numPad0.Size = New System.Drawing.Size(75, 72)
        Me.numPad0.TabIndex = 45
        Me.numPad0.Text = "0"
        Me.numPad0.UseVisualStyleBackColor = True
        '
        'refundLabel
        '
        Me.refundLabel.AutoSize = True
        Me.refundLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refundLabel.ForeColor = System.Drawing.Color.White
        Me.refundLabel.Location = New System.Drawing.Point(261, 248)
        Me.refundLabel.Name = "refundLabel"
        Me.refundLabel.Size = New System.Drawing.Size(193, 24)
        Me.refundLabel.TabIndex = 49
        Me.refundLabel.Text = "You will be refunded: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(263, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Label1"
        '
        'coinsLabel
        '
        Me.coinsLabel.AutoSize = True
        Me.coinsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coinsLabel.ForeColor = System.Drawing.Color.White
        Me.coinsLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.coinsLabel.Location = New System.Drawing.Point(331, 366)
        Me.coinsLabel.Name = "coinsLabel"
        Me.coinsLabel.Size = New System.Drawing.Size(58, 24)
        Me.coinsLabel.TabIndex = 53
        Me.coinsLabel.Text = "Coins"
        '
        'ccLabel
        '
        Me.ccLabel.AutoSize = True
        Me.ccLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccLabel.ForeColor = System.Drawing.Color.White
        Me.ccLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.ccLabel.Location = New System.Drawing.Point(524, 366)
        Me.ccLabel.Name = "ccLabel"
        Me.ccLabel.Size = New System.Drawing.Size(107, 24)
        Me.ccLabel.TabIndex = 54
        Me.ccLabel.Text = "Debit/Credit"
        '
        'xpLabel
        '
        Me.xpLabel.AutoSize = True
        Me.xpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xpLabel.ForeColor = System.Drawing.Color.White
        Me.xpLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.xpLabel.Location = New System.Drawing.Point(676, 383)
        Me.xpLabel.Name = "xpLabel"
        Me.xpLabel.Size = New System.Drawing.Size(160, 24)
        Me.xpLabel.TabIndex = 55
        Me.xpLabel.Text = "XpressPark Users"
        '
        'newTicketLabel
        '
        Me.newTicketLabel.AutoSize = True
        Me.newTicketLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTicketLabel.ForeColor = System.Drawing.Color.White
        Me.newTicketLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.newTicketLabel.Location = New System.Drawing.Point(127, 383)
        Me.newTicketLabel.Name = "newTicketLabel"
        Me.newTicketLabel.Size = New System.Drawing.Size(104, 24)
        Me.newTicketLabel.TabIndex = 56
        Me.newTicketLabel.Text = "New Ticket"
        '
        'addTimeLabel
        '
        Me.addTimeLabel.AutoSize = True
        Me.addTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTimeLabel.ForeColor = System.Drawing.Color.White
        Me.addTimeLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.addTimeLabel.Location = New System.Drawing.Point(325, 383)
        Me.addTimeLabel.Name = "addTimeLabel"
        Me.addTimeLabel.Size = New System.Drawing.Size(98, 24)
        Me.addTimeLabel.TabIndex = 57
        Me.addTimeLabel.Text = "Add Time "
        '
        'refundTimeLabel
        '
        Me.refundTimeLabel.AutoSize = True
        Me.refundTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refundTimeLabel.ForeColor = System.Drawing.Color.White
        Me.refundTimeLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.refundTimeLabel.Location = New System.Drawing.Point(485, 383)
        Me.refundTimeLabel.Name = "refundTimeLabel"
        Me.refundTimeLabel.Size = New System.Drawing.Size(167, 24)
        Me.refundTimeLabel.TabIndex = 58
        Me.refundTimeLabel.Text = "Refund Extra Time"
        '
        'toonieLabel
        '
        Me.toonieLabel.AutoSize = True
        Me.toonieLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toonieLabel.ForeColor = System.Drawing.Color.Pink
        Me.toonieLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.toonieLabel.Location = New System.Drawing.Point(246, 328)
        Me.toonieLabel.Name = "toonieLabel"
        Me.toonieLabel.Size = New System.Drawing.Size(70, 24)
        Me.toonieLabel.TabIndex = 60
        Me.toonieLabel.Text = "Add $2"
        '
        'loonieLabel
        '
        Me.loonieLabel.AutoSize = True
        Me.loonieLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loonieLabel.ForeColor = System.Drawing.Color.Pink
        Me.loonieLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.loonieLabel.Location = New System.Drawing.Point(427, 328)
        Me.loonieLabel.Name = "loonieLabel"
        Me.loonieLabel.Size = New System.Drawing.Size(70, 24)
        Me.loonieLabel.TabIndex = 61
        Me.loonieLabel.Text = "Add $1"
        '
        'quarterLabel
        '
        Me.quarterLabel.AutoSize = True
        Me.quarterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quarterLabel.ForeColor = System.Drawing.Color.Pink
        Me.quarterLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.quarterLabel.Location = New System.Drawing.Point(577, 329)
        Me.quarterLabel.Name = "quarterLabel"
        Me.quarterLabel.Size = New System.Drawing.Size(95, 24)
        Me.quarterLabel.TabIndex = 62
        Me.quarterLabel.Text = "Add $0.25"
        '
        'stateNumber
        '
        Me.stateNumber.AutoSize = True
        Me.stateNumber.Location = New System.Drawing.Point(27, 77)
        Me.stateNumber.Name = "stateNumber"
        Me.stateNumber.Size = New System.Drawing.Size(39, 13)
        Me.stateNumber.TabIndex = 63
        Me.stateNumber.Text = "Label3"
        '
        'desiredTimeLabel
        '
        Me.desiredTimeLabel.AutoSize = True
        Me.desiredTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desiredTimeLabel.ForeColor = System.Drawing.Color.White
        Me.desiredTimeLabel.Location = New System.Drawing.Point(362, 145)
        Me.desiredTimeLabel.Name = "desiredTimeLabel"
        Me.desiredTimeLabel.Size = New System.Drawing.Size(128, 24)
        Me.desiredTimeLabel.TabIndex = 64
        Me.desiredTimeLabel.Text = "Desired Time:"
        '
        'accountNumberLabel
        '
        Me.accountNumberLabel.AutoSize = True
        Me.accountNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountNumberLabel.ForeColor = System.Drawing.Color.White
        Me.accountNumberLabel.Location = New System.Drawing.Point(196, 92)
        Me.accountNumberLabel.Name = "accountNumberLabel"
        Me.accountNumberLabel.Size = New System.Drawing.Size(113, 37)
        Me.accountNumberLabel.TabIndex = 66
        Me.accountNumberLabel.Text = "Label3"
        '
        'desiredExpiryTime
        '
        Me.desiredExpiryTime.AutoSize = True
        Me.desiredExpiryTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desiredExpiryTime.ForeColor = System.Drawing.Color.White
        Me.desiredExpiryTime.Location = New System.Drawing.Point(312, 145)
        Me.desiredExpiryTime.Name = "desiredExpiryTime"
        Me.desiredExpiryTime.Size = New System.Drawing.Size(222, 37)
        Me.desiredExpiryTime.TabIndex = 67
        Me.desiredExpiryTime.Text = "Desired Expiry"
        '
        'parkButton
        '
        Me.parkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parkButton.Location = New System.Drawing.Point(265, 291)
        Me.parkButton.Name = "parkButton"
        Me.parkButton.Size = New System.Drawing.Size(154, 78)
        Me.parkButton.TabIndex = 69
        Me.parkButton.Text = "Park"
        Me.parkButton.UseVisualStyleBackColor = True
        '
        'leaveButton
        '
        Me.leaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leaveButton.Location = New System.Drawing.Point(503, 290)
        Me.leaveButton.Name = "leaveButton"
        Me.leaveButton.Size = New System.Drawing.Size(171, 78)
        Me.leaveButton.TabIndex = 70
        Me.leaveButton.Text = "Leave"
        Me.leaveButton.UseVisualStyleBackColor = True
        '
        'xppDesc
        '
        Me.xppDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xppDesc.ForeColor = System.Drawing.Color.White
        Me.xppDesc.Location = New System.Drawing.Point(284, 130)
        Me.xppDesc.Name = "xppDesc"
        Me.xppDesc.Size = New System.Drawing.Size(396, 140)
        Me.xppDesc.TabIndex = 71
        Me.xppDesc.Text = "XpressPark Users: Are you arriving or leaving?"
        Me.xppDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rateLabel1
        '
        Me.rateLabel1.AutoSize = True
        Me.rateLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateLabel1.ForeColor = System.Drawing.Color.White
        Me.rateLabel1.Location = New System.Drawing.Point(719, 12)
        Me.rateLabel1.Name = "rateLabel1"
        Me.rateLabel1.Size = New System.Drawing.Size(193, 31)
        Me.rateLabel1.TabIndex = 72
        Me.rateLabel1.Text = "Rates: $2/hour"
        '
        'rateLabel2
        '
        Me.rateLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateLabel2.ForeColor = System.Drawing.Color.White
        Me.rateLabel2.Location = New System.Drawing.Point(719, 44)
        Me.rateLabel2.Name = "rateLabel2"
        Me.rateLabel2.Size = New System.Drawing.Size(217, 50)
        Me.rateLabel2.TabIndex = 73
        Me.rateLabel2.Text = "All Day Parking: $12 (Until 6am next day)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(389, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Sample Ticket"
        '
        'editButton
        '
        Me.editButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(143, 117)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(113, 50)
        Me.editButton.TabIndex = 74
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'failButton
        '
        Me.failButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.failButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.failButton.ForeColor = System.Drawing.Color.White
        Me.failButton.Location = New System.Drawing.Point(619, 476)
        Me.failButton.Name = "failButton"
        Me.failButton.Size = New System.Drawing.Size(102, 54)
        Me.failButton.TabIndex = 75
        Me.failButton.Text = "Fail"
        Me.failButton.UseVisualStyleBackColor = False
        '
        'submitDesc
        '
        Me.submitDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitDesc.ForeColor = System.Drawing.Color.White
        Me.submitDesc.Location = New System.Drawing.Point(245, 204)
        Me.submitDesc.Name = "submitDesc"
        Me.submitDesc.Size = New System.Drawing.Size(447, 184)
        Me.submitDesc.TabIndex = 76
        Me.submitDesc.Text = "Submit the ticket you wish to add more time to."
        Me.submitDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tapButton
        '
        Me.tapButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tapButton.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tapButton.ForeColor = System.Drawing.Color.White
        Me.tapButton.Location = New System.Drawing.Point(617, 410)
        Me.tapButton.Name = "tapButton"
        Me.tapButton.Size = New System.Drawing.Size(93, 39)
        Me.tapButton.TabIndex = 78
        Me.tapButton.Text = "Tap"
        Me.tapButton.UseVisualStyleBackColor = False
        '
        'xppButton
        '
        Me.xppButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.xpp
        Me.xppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.xppButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.xppButton.Location = New System.Drawing.Point(680, 204)
        Me.xppButton.Name = "xppButton"
        Me.xppButton.Size = New System.Drawing.Size(167, 177)
        Me.xppButton.TabIndex = 68
        Me.xppButton.UseVisualStyleBackColor = True
        '
        'hourUpButton
        '
        Me.hourUpButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.up1
        Me.hourUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hourUpButton.Location = New System.Drawing.Point(245, 173)
        Me.hourUpButton.Name = "hourUpButton"
        Me.hourUpButton.Size = New System.Drawing.Size(55, 57)
        Me.hourUpButton.TabIndex = 10
        Me.hourUpButton.UseVisualStyleBackColor = True
        '
        'newTicketButton
        '
        Me.newTicketButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.newticket
        Me.newTicketButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.newTicketButton.Location = New System.Drawing.Point(104, 203)
        Me.newTicketButton.Name = "newTicketButton"
        Me.newTicketButton.Size = New System.Drawing.Size(167, 177)
        Me.newTicketButton.TabIndex = 1
        Me.newTicketButton.UseVisualStyleBackColor = True
        '
        'toonieButton
        '
        Me.toonieButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.toonie
        Me.toonieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.toonieButton.Location = New System.Drawing.Point(243, 219)
        Me.toonieButton.Name = "toonieButton"
        Me.toonieButton.Size = New System.Drawing.Size(93, 104)
        Me.toonieButton.TabIndex = 26
        Me.toonieButton.UseVisualStyleBackColor = True
        '
        'backspButton
        '
        Me.backspButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.backspace
        Me.backspButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backspButton.Location = New System.Drawing.Point(512, 349)
        Me.backspButton.Name = "backspButton"
        Me.backspButton.Size = New System.Drawing.Size(75, 73)
        Me.backspButton.TabIndex = 47
        Me.backspButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._47_512
        Me.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clearButton.Location = New System.Drawing.Point(350, 349)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 73)
        Me.clearButton.TabIndex = 46
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'quarterButton
        '
        Me.quarterButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.quarter
        Me.quarterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.quarterButton.Location = New System.Drawing.Point(581, 221)
        Me.quarterButton.Name = "quarterButton"
        Me.quarterButton.Size = New System.Drawing.Size(93, 102)
        Me.quarterButton.TabIndex = 28
        Me.quarterButton.UseVisualStyleBackColor = True
        '
        'hourDownButton
        '
        Me.hourDownButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.up__2_
        Me.hourDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hourDownButton.Location = New System.Drawing.Point(245, 245)
        Me.hourDownButton.Name = "hourDownButton"
        Me.hourDownButton.Size = New System.Drawing.Size(55, 56)
        Me.hourDownButton.TabIndex = 11
        Me.hourDownButton.UseVisualStyleBackColor = True
        '
        'selectCoinsButton
        '
        Me.selectCoinsButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.coins
        Me.selectCoinsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.selectCoinsButton.Location = New System.Drawing.Point(290, 204)
        Me.selectCoinsButton.Name = "selectCoinsButton"
        Me.selectCoinsButton.Size = New System.Drawing.Size(151, 160)
        Me.selectCoinsButton.TabIndex = 19
        Me.selectCoinsButton.UseVisualStyleBackColor = True
        '
        'selectCardButton
        '
        Me.selectCardButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.cc1
        Me.selectCardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.selectCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.selectCardButton.Location = New System.Drawing.Point(505, 204)
        Me.selectCardButton.Name = "selectCardButton"
        Me.selectCardButton.Size = New System.Drawing.Size(151, 159)
        Me.selectCardButton.TabIndex = 20
        Me.selectCardButton.UseVisualStyleBackColor = True
        '
        'addTimeButton
        '
        Me.addTimeButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.addtime2
        Me.addTimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addTimeButton.Location = New System.Drawing.Point(294, 203)
        Me.addTimeButton.Name = "addTimeButton"
        Me.addTimeButton.Size = New System.Drawing.Size(167, 177)
        Me.addTimeButton.TabIndex = 2
        Me.addTimeButton.UseVisualStyleBackColor = True
        '
        'refundButton
        '
        Me.refundButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.refund
        Me.refundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.refundButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.refundButton.Location = New System.Drawing.Point(489, 203)
        Me.refundButton.Name = "refundButton"
        Me.refundButton.Size = New System.Drawing.Size(167, 177)
        Me.refundButton.TabIndex = 4
        Me.refundButton.UseVisualStyleBackColor = True
        '
        'ticket
        '
        Me.ticket.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.ticket
        Me.ticket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ticket.Location = New System.Drawing.Point(327, 132)
        Me.ticket.Name = "ticket"
        Me.ticket.Size = New System.Drawing.Size(284, 273)
        Me.ticket.TabIndex = 65
        Me.ticket.TabStop = False
        '
        'tapPic
        '
        Me.tapPic.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.tap
        Me.tapPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tapPic.Location = New System.Drawing.Point(369, 225)
        Me.tapPic.Name = "tapPic"
        Me.tapPic.Size = New System.Drawing.Size(202, 144)
        Me.tapPic.TabIndex = 77
        Me.tapPic.TabStop = False
        '
        'loonieButton
        '
        Me.loonieButton.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.index
        Me.loonieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.loonieButton.Location = New System.Drawing.Point(418, 222)
        Me.loonieButton.Name = "loonieButton"
        Me.loonieButton.Size = New System.Drawing.Size(93, 102)
        Me.loonieButton.TabIndex = 27
        Me.loonieButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(948, 631)
        Me.Controls.Add(Me.tapPic)
        Me.Controls.Add(Me.tapButton)
        Me.Controls.Add(Me.failButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.rateLabel2)
        Me.Controls.Add(Me.rateLabel1)
        Me.Controls.Add(Me.xppButton)
        Me.Controls.Add(Me.accountNumberLabel)
        Me.Controls.Add(Me.xpLabel)
        Me.Controls.Add(Me.stateNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.timeLeftLabel)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.newTicketLabel)
        Me.Controls.Add(Me.bigBottomButton)
        Me.Controls.Add(Me.hourUpButton)
        Me.Controls.Add(Me.newTicketButton)
        Me.Controls.Add(Me.desiredTimeLabel)
        Me.Controls.Add(Me.quarterLabel)
        Me.Controls.Add(Me.toonieLabel)
        Me.Controls.Add(Me.toonieButton)
        Me.Controls.Add(Me.numPad5)
        Me.Controls.Add(Me.backspButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.numPad0)
        Me.Controls.Add(Me.numPad6)
        Me.Controls.Add(Me.numPad4)
        Me.Controls.Add(Me.numPad9)
        Me.Controls.Add(Me.numPad8)
        Me.Controls.Add(Me.numPad7)
        Me.Controls.Add(Me.numPad1)
        Me.Controls.Add(Me.quarterButton)
        Me.Controls.Add(Me.parkButton)
        Me.Controls.Add(Me.hourDownButton)
        Me.Controls.Add(Me.maxTimeButton)
        Me.Controls.Add(Me.amountDueLabel)
        Me.Controls.Add(Me.numPad3)
        Me.Controls.Add(Me.leaveButton)
        Me.Controls.Add(Me.selectCoinsButton)
        Me.Controls.Add(Me.selectCardButton)
        Me.Controls.Add(Me.inputTime)
        Me.Controls.Add(Me.amountReturnedLabel)
        Me.Controls.Add(Me.addTimeButton)
        Me.Controls.Add(Me.amountPaidLabel)
        Me.Controls.Add(Me.expireTimeLabel)
        Me.Controls.Add(Me.loonieLabel)
        Me.Controls.Add(Me.refundLabel)
        Me.Controls.Add(Me.refundButton)
        Me.Controls.Add(Me.refundTimeLabel)
        Me.Controls.Add(Me.amountEnteredLabel)
        Me.Controls.Add(Me.addTimeLabel)
        Me.Controls.Add(Me.coinsLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.ccLabel)
        Me.Controls.Add(Me.modeTitle)
        Me.Controls.Add(Me.xppDesc)
        Me.Controls.Add(Me.desiredExpiryTime)
        Me.Controls.Add(Me.submitDesc)
        Me.Controls.Add(Me.loonieButton)
        Me.Controls.Add(Me.accNbrButton)
        Me.Controls.Add(Me.numPad2)
        Me.Controls.Add(Me.ticket)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(964, 670)
        Me.MinimumSize = New System.Drawing.Size(964, 670)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ticket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tapPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeLabel As Label
    Friend WithEvents newTicketButton As Button
    Friend WithEvents addTimeButton As Button
    Friend WithEvents refundButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents modeTitle As Label
    Friend WithEvents hourUpButton As Button
    Friend WithEvents hourDownButton As Button
    Friend WithEvents inputTime As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents expireTimeLabel As Label
    Friend WithEvents selectCoinsButton As Button
    Friend WithEvents selectCardButton As Button
    Friend WithEvents amountDueLabel As Label
    Friend WithEvents maxTimeButton As Button
    Friend WithEvents timeLeftLabel As Label
    Friend WithEvents toonieButton As Button
    Friend WithEvents loonieButton As Button
    Friend WithEvents quarterButton As Button
    Friend WithEvents amountEnteredLabel As Label
    Friend WithEvents amountPaidLabel As Label
    Friend WithEvents amountReturnedLabel As Label
    Friend WithEvents bigBottomButton As Button
    Friend WithEvents accNbrButton As Button
    Friend WithEvents numPad7 As Button
    Friend WithEvents numPad8 As Button
    Friend WithEvents numPad9 As Button
    Friend WithEvents numPad4 As Button
    Friend WithEvents numPad5 As Button
    Friend WithEvents numPad6 As Button
    Friend WithEvents numPad1 As Button
    Friend WithEvents numPad2 As Button
    Friend WithEvents numPad3 As Button
    Friend WithEvents numPad0 As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents backspButton As Button
    Friend WithEvents refundLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents coinsLabel As Label
    Friend WithEvents ccLabel As Label
    Friend WithEvents xpLabel As Label
    Friend WithEvents newTicketLabel As Label
    Friend WithEvents addTimeLabel As Label
    Friend WithEvents refundTimeLabel As Label
    Friend WithEvents toonieLabel As Label
    Friend WithEvents loonieLabel As Label
    Friend WithEvents quarterLabel As Label
    Friend WithEvents stateNumber As Label
    Friend WithEvents desiredTimeLabel As Label
    Friend WithEvents ticket As PictureBox
    Friend WithEvents accountNumberLabel As Label
    Friend WithEvents desiredExpiryTime As Label
    Friend WithEvents xppButton As Button
    Friend WithEvents parkButton As Button
    Friend WithEvents leaveButton As Button
    Friend WithEvents xppDesc As Label
    Friend WithEvents rateLabel1 As Label
    Friend WithEvents rateLabel2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents editButton As Button
    Friend WithEvents failButton As Button
    Friend WithEvents submitDesc As Label
    Friend WithEvents tapPic As PictureBox
    Friend WithEvents tapButton As Button
End Class
