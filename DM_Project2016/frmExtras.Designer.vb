<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpDryCleaning = New System.Windows.Forms.GroupBox()
        Me.chkOther = New System.Windows.Forms.CheckBox()
        Me.chkShirts = New System.Windows.Forms.CheckBox()
        Me.chkSuits = New System.Windows.Forms.CheckBox()
        Me.lblOtherItemsN0 = New System.Windows.Forms.Label()
        Me.mtbOtherItems = New System.Windows.Forms.MaskedTextBox()
        Me.grpLaundryService = New System.Windows.Forms.GroupBox()
        Me.mtbLaundry = New System.Windows.Forms.MaskedTextBox()
        Me.lblLaundryService = New System.Windows.Forms.Label()
        Me.grpBreakfast = New System.Windows.Forms.GroupBox()
        Me.cmbEveningMeal = New System.Windows.Forms.ComboBox()
        Me.cmbFullIrish = New System.Windows.Forms.ComboBox()
        Me.cmbContinental = New System.Windows.Forms.ComboBox()
        Me.lblEveningMeal = New System.Windows.Forms.Label()
        Me.lblFullIrish = New System.Windows.Forms.Label()
        Me.lblContinentalBreakfast = New System.Windows.Forms.Label()
        Me.rpSubTotal = New System.Windows.Forms.GroupBox()
        Me.lstSubtotal = New System.Windows.Forms.ListBox()
        Me.lblOnlyTheBest = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.pgrTransactionProgress = New System.Windows.Forms.ProgressBar()
        Me.grpDryCleaning.SuspendLayout()
        Me.grpLaundryService.SuspendLayout()
        Me.grpBreakfast.SuspendLayout()
        Me.rpSubTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDryCleaning
        '
        Me.grpDryCleaning.Controls.Add(Me.chkOther)
        Me.grpDryCleaning.Controls.Add(Me.chkShirts)
        Me.grpDryCleaning.Controls.Add(Me.chkSuits)
        Me.grpDryCleaning.Controls.Add(Me.lblOtherItemsN0)
        Me.grpDryCleaning.Controls.Add(Me.mtbOtherItems)
        Me.grpDryCleaning.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDryCleaning.ForeColor = System.Drawing.SystemColors.Control
        Me.grpDryCleaning.Location = New System.Drawing.Point(12, 93)
        Me.grpDryCleaning.Name = "grpDryCleaning"
        Me.grpDryCleaning.Size = New System.Drawing.Size(219, 146)
        Me.grpDryCleaning.TabIndex = 0
        Me.grpDryCleaning.TabStop = False
        Me.grpDryCleaning.Text = "DryCleaning:"
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.chkOther.Location = New System.Drawing.Point(6, 44)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(171, 20)
        Me.chkOther.TabIndex = 21
        Me.chkOther.Text = "Other (11.25/Item)"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'chkShirts
        '
        Me.chkShirts.AutoSize = True
        Me.chkShirts.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.chkShirts.Location = New System.Drawing.Point(6, 70)
        Me.chkShirts.Name = "chkShirts"
        Me.chkShirts.Size = New System.Drawing.Size(131, 20)
        Me.chkShirts.TabIndex = 22
        Me.chkShirts.Text = "Shirts (9.25)"
        Me.chkShirts.UseVisualStyleBackColor = True
        '
        'chkSuits
        '
        Me.chkSuits.AutoSize = True
        Me.chkSuits.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.chkSuits.Location = New System.Drawing.Point(6, 18)
        Me.chkSuits.Name = "chkSuits"
        Me.chkSuits.Size = New System.Drawing.Size(131, 20)
        Me.chkSuits.TabIndex = 23
        Me.chkSuits.Text = "Suits (19.50)"
        Me.chkSuits.UseVisualStyleBackColor = True
        '
        'lblOtherItemsN0
        '
        Me.lblOtherItemsN0.AutoSize = True
        Me.lblOtherItemsN0.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblOtherItemsN0.Location = New System.Drawing.Point(6, 84)
        Me.lblOtherItemsN0.Name = "lblOtherItemsN0"
        Me.lblOtherItemsN0.Size = New System.Drawing.Size(136, 16)
        Me.lblOtherItemsN0.TabIndex = 2
        Me.lblOtherItemsN0.Text = "No. Other Items:"
        '
        'mtbOtherItems
        '
        Me.mtbOtherItems.Location = New System.Drawing.Point(6, 103)
        Me.mtbOtherItems.Mask = "00"
        Me.mtbOtherItems.Name = "mtbOtherItems"
        Me.mtbOtherItems.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbOtherItems.Size = New System.Drawing.Size(132, 29)
        Me.mtbOtherItems.TabIndex = 1
        '
        'grpLaundryService
        '
        Me.grpLaundryService.Controls.Add(Me.mtbLaundry)
        Me.grpLaundryService.Controls.Add(Me.lblLaundryService)
        Me.grpLaundryService.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLaundryService.ForeColor = System.Drawing.SystemColors.Control
        Me.grpLaundryService.Location = New System.Drawing.Point(238, 302)
        Me.grpLaundryService.Name = "grpLaundryService"
        Me.grpLaundryService.Size = New System.Drawing.Size(235, 66)
        Me.grpLaundryService.TabIndex = 1
        Me.grpLaundryService.TabStop = False
        Me.grpLaundryService.Text = "Laundry Service:"
        '
        'mtbLaundry
        '
        Me.mtbLaundry.Location = New System.Drawing.Point(121, 28)
        Me.mtbLaundry.Mask = "00"
        Me.mtbLaundry.Name = "mtbLaundry"
        Me.mtbLaundry.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbLaundry.Size = New System.Drawing.Size(81, 29)
        Me.mtbLaundry.TabIndex = 1
        '
        'lblLaundryService
        '
        Me.lblLaundryService.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.lblLaundryService.Location = New System.Drawing.Point(6, 25)
        Me.lblLaundryService.Name = "lblLaundryService"
        Me.lblLaundryService.Size = New System.Drawing.Size(90, 38)
        Me.lblLaundryService.TabIndex = 0
        Me.lblLaundryService.Text = "No. of Bags (15.50/bag)"
        '
        'grpBreakfast
        '
        Me.grpBreakfast.Controls.Add(Me.cmbEveningMeal)
        Me.grpBreakfast.Controls.Add(Me.cmbFullIrish)
        Me.grpBreakfast.Controls.Add(Me.cmbContinental)
        Me.grpBreakfast.Controls.Add(Me.lblEveningMeal)
        Me.grpBreakfast.Controls.Add(Me.lblFullIrish)
        Me.grpBreakfast.Controls.Add(Me.lblContinentalBreakfast)
        Me.grpBreakfast.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBreakfast.ForeColor = System.Drawing.SystemColors.Control
        Me.grpBreakfast.Location = New System.Drawing.Point(12, 245)
        Me.grpBreakfast.Name = "grpBreakfast"
        Me.grpBreakfast.Size = New System.Drawing.Size(219, 182)
        Me.grpBreakfast.TabIndex = 2
        Me.grpBreakfast.TabStop = False
        Me.grpBreakfast.Text = "Meals:"
        '
        'cmbEveningMeal
        '
        Me.cmbEveningMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEveningMeal.FormattingEnabled = True
        Me.cmbEveningMeal.Location = New System.Drawing.Point(102, 135)
        Me.cmbEveningMeal.Name = "cmbEveningMeal"
        Me.cmbEveningMeal.Size = New System.Drawing.Size(111, 30)
        Me.cmbEveningMeal.TabIndex = 5
        '
        'cmbFullIrish
        '
        Me.cmbFullIrish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFullIrish.FormattingEnabled = True
        Me.cmbFullIrish.Location = New System.Drawing.Point(102, 84)
        Me.cmbFullIrish.Name = "cmbFullIrish"
        Me.cmbFullIrish.Size = New System.Drawing.Size(111, 30)
        Me.cmbFullIrish.TabIndex = 4
        '
        'cmbContinental
        '
        Me.cmbContinental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContinental.FormattingEnabled = True
        Me.cmbContinental.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cmbContinental.Location = New System.Drawing.Point(102, 28)
        Me.cmbContinental.Name = "cmbContinental"
        Me.cmbContinental.Size = New System.Drawing.Size(111, 30)
        Me.cmbContinental.TabIndex = 3
        '
        'lblEveningMeal
        '
        Me.lblEveningMeal.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblEveningMeal.Location = New System.Drawing.Point(11, 131)
        Me.lblEveningMeal.Name = "lblEveningMeal"
        Me.lblEveningMeal.Size = New System.Drawing.Size(96, 34)
        Me.lblEveningMeal.TabIndex = 2
        Me.lblEveningMeal.Text = "Evening Meal:"
        '
        'lblFullIrish
        '
        Me.lblFullIrish.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblFullIrish.Location = New System.Drawing.Point(11, 84)
        Me.lblFullIrish.Name = "lblFullIrish"
        Me.lblFullIrish.Size = New System.Drawing.Size(96, 36)
        Me.lblFullIrish.TabIndex = 1
        Me.lblFullIrish.Text = "Full-Irish Breakfast:"
        '
        'lblContinentalBreakfast
        '
        Me.lblContinentalBreakfast.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblContinentalBreakfast.Location = New System.Drawing.Point(11, 28)
        Me.lblContinentalBreakfast.Name = "lblContinentalBreakfast"
        Me.lblContinentalBreakfast.Size = New System.Drawing.Size(96, 32)
        Me.lblContinentalBreakfast.TabIndex = 0
        Me.lblContinentalBreakfast.Text = "Continental Breakfast:"
        '
        'rpSubTotal
        '
        Me.rpSubTotal.Controls.Add(Me.lstSubtotal)
        Me.rpSubTotal.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rpSubTotal.ForeColor = System.Drawing.SystemColors.Control
        Me.rpSubTotal.Location = New System.Drawing.Point(237, 93)
        Me.rpSubTotal.Name = "rpSubTotal"
        Me.rpSubTotal.Size = New System.Drawing.Size(236, 203)
        Me.rpSubTotal.TabIndex = 5
        Me.rpSubTotal.TabStop = False
        Me.rpSubTotal.Text = "SubTotal:"
        '
        'lstSubtotal
        '
        Me.lstSubtotal.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.lstSubtotal.FormattingEnabled = True
        Me.lstSubtotal.ItemHeight = 14
        Me.lstSubtotal.Location = New System.Drawing.Point(6, 13)
        Me.lstSubtotal.Name = "lstSubtotal"
        Me.lstSubtotal.Size = New System.Drawing.Size(221, 172)
        Me.lstSubtotal.TabIndex = 0
        '
        'lblOnlyTheBest
        '
        Me.lblOnlyTheBest.AutoSize = True
        Me.lblOnlyTheBest.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnlyTheBest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOnlyTheBest.Location = New System.Drawing.Point(81, 9)
        Me.lblOnlyTheBest.Name = "lblOnlyTheBest"
        Me.lblOnlyTheBest.Size = New System.Drawing.Size(321, 53)
        Me.lblOnlyTheBest.TabIndex = 7
        Me.lblOnlyTheBest.Text = "OnlyTheBest.Com"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(359, 379)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(114, 48)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next:"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Location = New System.Drawing.Point(243, 379)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(114, 48)
        Me.btnCalculateTotal.TabIndex = 11
        Me.btnCalculateTotal.Text = "Calculate Total:"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'pgrTransactionProgress
        '
        Me.pgrTransactionProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgrTransactionProgress.ForeColor = System.Drawing.Color.Coral
        Me.pgrTransactionProgress.Location = New System.Drawing.Point(90, 55)
        Me.pgrTransactionProgress.Name = "pgrTransactionProgress"
        Me.pgrTransactionProgress.Size = New System.Drawing.Size(312, 23)
        Me.pgrTransactionProgress.TabIndex = 12
        Me.pgrTransactionProgress.Value = 56
        '
        'frmExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.pgrTransactionProgress)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblOnlyTheBest)
        Me.Controls.Add(Me.rpSubTotal)
        Me.Controls.Add(Me.grpBreakfast)
        Me.Controls.Add(Me.grpLaundryService)
        Me.Controls.Add(Me.grpDryCleaning)
        Me.Name = "frmExtras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExtras"
        Me.grpDryCleaning.ResumeLayout(False)
        Me.grpDryCleaning.PerformLayout()
        Me.grpLaundryService.ResumeLayout(False)
        Me.grpLaundryService.PerformLayout()
        Me.grpBreakfast.ResumeLayout(False)
        Me.rpSubTotal.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpDryCleaning As System.Windows.Forms.GroupBox
    Friend WithEvents lblOtherItemsN0 As System.Windows.Forms.Label
    Friend WithEvents mtbOtherItems As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grpLaundryService As System.Windows.Forms.GroupBox
    Friend WithEvents mtbLaundry As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblLaundryService As System.Windows.Forms.Label
    Friend WithEvents grpBreakfast As System.Windows.Forms.GroupBox
    Friend WithEvents lblEveningMeal As System.Windows.Forms.Label
    Friend WithEvents lblFullIrish As System.Windows.Forms.Label
    Friend WithEvents lblContinentalBreakfast As System.Windows.Forms.Label
    Friend WithEvents rpSubTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lstSubtotal As System.Windows.Forms.ListBox
    Friend WithEvents lblOnlyTheBest As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents cmbEveningMeal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFullIrish As System.Windows.Forms.ComboBox
    Friend WithEvents cmbContinental As System.Windows.Forms.ComboBox
    Friend WithEvents chkOther As System.Windows.Forms.CheckBox
    Friend WithEvents chkShirts As System.Windows.Forms.CheckBox
    Friend WithEvents chkSuits As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalculateTotal As System.Windows.Forms.Button
    Friend WithEvents pgrTransactionProgress As ProgressBar
End Class
