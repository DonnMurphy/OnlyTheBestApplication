<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerInfo
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
        Me.grpCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.mtbGuest1PassportNumber = New System.Windows.Forms.MaskedTextBox()
        Me.mtbGuest1Age = New System.Windows.Forms.MaskedTextBox()
        Me.mtbGuest1Name = New System.Windows.Forms.MaskedTextBox()
        Me.lblGuest1PassportNumber = New System.Windows.Forms.Label()
        Me.lblGuest1Age = New System.Windows.Forms.Label()
        Me.lblGuest1Name = New System.Windows.Forms.Label()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.cmbCounty = New System.Windows.Forms.ComboBox()
        Me.mtbCity = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelephoneNumber = New System.Windows.Forms.Label()
        Me.mtbTelephoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.lblOnlyTheBest = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOtherGuestsNo = New System.Windows.Forms.Label()
        Me.cmbOtherGuests = New System.Windows.Forms.ComboBox()
        Me.pgrTransactionProgress = New System.Windows.Forms.ProgressBar()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpCustomerDetails.SuspendLayout()
        Me.grpDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustomerDetails
        '
        Me.grpCustomerDetails.Controls.Add(Me.mtbGuest1PassportNumber)
        Me.grpCustomerDetails.Controls.Add(Me.mtbGuest1Age)
        Me.grpCustomerDetails.Controls.Add(Me.mtbGuest1Name)
        Me.grpCustomerDetails.Controls.Add(Me.lblGuest1PassportNumber)
        Me.grpCustomerDetails.Controls.Add(Me.lblGuest1Age)
        Me.grpCustomerDetails.Controls.Add(Me.lblGuest1Name)
        Me.grpCustomerDetails.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomerDetails.ForeColor = System.Drawing.SystemColors.Control
        Me.grpCustomerDetails.Location = New System.Drawing.Point(43, 86)
        Me.grpCustomerDetails.Name = "grpCustomerDetails"
        Me.grpCustomerDetails.Size = New System.Drawing.Size(409, 119)
        Me.grpCustomerDetails.TabIndex = 0
        Me.grpCustomerDetails.TabStop = False
        Me.grpCustomerDetails.Text = "Customer Details:"
        '
        'mtbGuest1PassportNumber
        '
        Me.mtbGuest1PassportNumber.Location = New System.Drawing.Point(234, 74)
        Me.mtbGuest1PassportNumber.Mask = "LL000000"
        Me.mtbGuest1PassportNumber.Name = "mtbGuest1PassportNumber"
        Me.mtbGuest1PassportNumber.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest1PassportNumber.Size = New System.Drawing.Size(169, 26)
        Me.mtbGuest1PassportNumber.TabIndex = 7
        '
        'mtbGuest1Age
        '
        Me.mtbGuest1Age.Location = New System.Drawing.Point(336, 42)
        Me.mtbGuest1Age.Mask = "00"
        Me.mtbGuest1Age.Name = "mtbGuest1Age"
        Me.mtbGuest1Age.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest1Age.Size = New System.Drawing.Size(67, 26)
        Me.mtbGuest1Age.TabIndex = 6
        Me.mtbGuest1Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mtbGuest1Name
        '
        Me.mtbGuest1Name.Location = New System.Drawing.Point(234, 10)
        Me.mtbGuest1Name.Mask = "LLLLLLLLLLLLLLLLLLLL"
        Me.mtbGuest1Name.Name = "mtbGuest1Name"
        Me.mtbGuest1Name.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest1Name.Size = New System.Drawing.Size(169, 26)
        Me.mtbGuest1Name.TabIndex = 5
        Me.mtbGuest1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGuest1PassportNumber
        '
        Me.lblGuest1PassportNumber.AutoSize = True
        Me.lblGuest1PassportNumber.Location = New System.Drawing.Point(11, 82)
        Me.lblGuest1PassportNumber.Name = "lblGuest1PassportNumber"
        Me.lblGuest1PassportNumber.Size = New System.Drawing.Size(168, 18)
        Me.lblGuest1PassportNumber.TabIndex = 2
        Me.lblGuest1PassportNumber.Text = "Passport Number:"
        '
        'lblGuest1Age
        '
        Me.lblGuest1Age.AutoSize = True
        Me.lblGuest1Age.Location = New System.Drawing.Point(11, 50)
        Me.lblGuest1Age.Name = "lblGuest1Age"
        Me.lblGuest1Age.Size = New System.Drawing.Size(48, 18)
        Me.lblGuest1Age.TabIndex = 3
        Me.lblGuest1Age.Text = "Age:"
        '
        'lblGuest1Name
        '
        Me.lblGuest1Name.AutoSize = True
        Me.lblGuest1Name.Location = New System.Drawing.Point(11, 22)
        Me.lblGuest1Name.Name = "lblGuest1Name"
        Me.lblGuest1Name.Size = New System.Drawing.Size(58, 18)
        Me.lblGuest1Name.TabIndex = 4
        Me.lblGuest1Name.Text = "Name:"
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.txtStreetAddress)
        Me.grpDetails.Controls.Add(Me.cmbCounty)
        Me.grpDetails.Controls.Add(Me.mtbCity)
        Me.grpDetails.Controls.Add(Me.lblTelephoneNumber)
        Me.grpDetails.Controls.Add(Me.mtbTelephoneNumber)
        Me.grpDetails.Controls.Add(Me.lblCounty)
        Me.grpDetails.Controls.Add(Me.lblCity)
        Me.grpDetails.Controls.Add(Me.lblStreetAddress)
        Me.grpDetails.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetails.ForeColor = System.Drawing.SystemColors.Control
        Me.grpDetails.Location = New System.Drawing.Point(43, 211)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(409, 148)
        Me.grpDetails.TabIndex = 1
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Address:"
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(234, 14)
        Me.txtStreetAddress.MaxLength = 50
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(169, 26)
        Me.txtStreetAddress.TabIndex = 11
        '
        'cmbCounty
        '
        Me.cmbCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCounty.FormattingEnabled = True
        Me.cmbCounty.Items.AddRange(New Object() {"Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Derry", "Donegal", "Down", "Dublin", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow"})
        Me.cmbCounty.Location = New System.Drawing.Point(234, 78)
        Me.cmbCounty.Name = "cmbCounty"
        Me.cmbCounty.Size = New System.Drawing.Size(169, 26)
        Me.cmbCounty.TabIndex = 8
        '
        'mtbCity
        '
        Me.mtbCity.Location = New System.Drawing.Point(234, 46)
        Me.mtbCity.Mask = "LLLLLLLLLLLLLLL"
        Me.mtbCity.Name = "mtbCity"
        Me.mtbCity.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCity.Size = New System.Drawing.Size(169, 26)
        Me.mtbCity.TabIndex = 10
        '
        'lblTelephoneNumber
        '
        Me.lblTelephoneNumber.AutoSize = True
        Me.lblTelephoneNumber.Location = New System.Drawing.Point(6, 118)
        Me.lblTelephoneNumber.Name = "lblTelephoneNumber"
        Me.lblTelephoneNumber.Size = New System.Drawing.Size(178, 18)
        Me.lblTelephoneNumber.TabIndex = 3
        Me.lblTelephoneNumber.Text = "Telephone Number:"
        '
        'mtbTelephoneNumber
        '
        Me.mtbTelephoneNumber.Location = New System.Drawing.Point(234, 110)
        Me.mtbTelephoneNumber.Mask = "(999) 000-0000"
        Me.mtbTelephoneNumber.Name = "mtbTelephoneNumber"
        Me.mtbTelephoneNumber.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbTelephoneNumber.Size = New System.Drawing.Size(169, 26)
        Me.mtbTelephoneNumber.SkipLiterals = False
        Me.mtbTelephoneNumber.TabIndex = 9
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(6, 86)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(78, 18)
        Me.lblCounty.TabIndex = 2
        Me.lblCounty.Text = "County:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(6, 54)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(58, 18)
        Me.lblCity.TabIndex = 1
        Me.lblCity.Text = "City:"
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Location = New System.Drawing.Point(6, 22)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(158, 18)
        Me.lblStreetAddress.TabIndex = 0
        Me.lblStreetAddress.Text = "Street Address:"
        '
        'lblOnlyTheBest
        '
        Me.lblOnlyTheBest.AutoSize = True
        Me.lblOnlyTheBest.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnlyTheBest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOnlyTheBest.Location = New System.Drawing.Point(87, 1)
        Me.lblOnlyTheBest.Name = "lblOnlyTheBest"
        Me.lblOnlyTheBest.Size = New System.Drawing.Size(321, 53)
        Me.lblOnlyTheBest.TabIndex = 6
        Me.lblOnlyTheBest.Text = "OnlyTheBest.Com"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOtherGuestsNo)
        Me.GroupBox1.Controls.Add(Me.cmbOtherGuests)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(43, 365)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 84)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Other Guests:"
        '
        'lblOtherGuestsNo
        '
        Me.lblOtherGuestsNo.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblOtherGuestsNo.Location = New System.Drawing.Point(3, 22)
        Me.lblOtherGuestsNo.Name = "lblOtherGuestsNo"
        Me.lblOtherGuestsNo.Size = New System.Drawing.Size(101, 50)
        Me.lblOtherGuestsNo.TabIndex = 1
        Me.lblOtherGuestsNo.Text = "No. of Other Guests:"
        '
        'cmbOtherGuests
        '
        Me.cmbOtherGuests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOtherGuests.FormattingEnabled = True
        Me.cmbOtherGuests.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.cmbOtherGuests.Location = New System.Drawing.Point(110, 25)
        Me.cmbOtherGuests.Name = "cmbOtherGuests"
        Me.cmbOtherGuests.Size = New System.Drawing.Size(121, 26)
        Me.cmbOtherGuests.TabIndex = 0
        '
        'pgrTransactionProgress
        '
        Me.pgrTransactionProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgrTransactionProgress.ForeColor = System.Drawing.Color.Coral
        Me.pgrTransactionProgress.Location = New System.Drawing.Point(96, 57)
        Me.pgrTransactionProgress.Name = "pgrTransactionProgress"
        Me.pgrTransactionProgress.Size = New System.Drawing.Size(312, 23)
        Me.pgrTransactionProgress.TabIndex = 8
        Me.pgrTransactionProgress.Value = 14
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(280, 365)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(172, 84)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next:"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'frmCustomerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.pgrTransactionProgress)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblOnlyTheBest)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.grpCustomerDetails)
        Me.Name = "frmCustomerInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCustomerInfo"
        Me.grpCustomerDetails.ResumeLayout(False)
        Me.grpCustomerDetails.PerformLayout()
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCustomerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblGuest1PassportNumber As System.Windows.Forms.Label
    Friend WithEvents lblGuest1Age As System.Windows.Forms.Label
    Friend WithEvents lblGuest1Name As System.Windows.Forms.Label
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblTelephoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblStreetAddress As System.Windows.Forms.Label
    Friend WithEvents mtbGuest1PassportNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbGuest1Age As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbGuest1Name As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbCounty As System.Windows.Forms.ComboBox
    Friend WithEvents mtbCity As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbTelephoneNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblOnlyTheBest As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbOtherGuests As System.Windows.Forms.ComboBox
    Friend WithEvents lblOtherGuestsNo As System.Windows.Forms.Label
    Friend WithEvents pgrTransactionProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents txtStreetAddress As System.Windows.Forms.TextBox
End Class
