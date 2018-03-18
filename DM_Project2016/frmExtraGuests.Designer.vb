<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtraGuests
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
        Me.grpGuest2Details = New System.Windows.Forms.GroupBox()
        Me.mtbGuest2Age = New System.Windows.Forms.MaskedTextBox()
        Me.lblGuest2Age = New System.Windows.Forms.Label()
        Me.mtbGuest2PassportNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblGuest2Passport = New System.Windows.Forms.Label()
        Me.lblGuest2Name = New System.Windows.Forms.Label()
        Me.mtbGuest2Name = New System.Windows.Forms.MaskedTextBox()
        Me.grpGuest3Details = New System.Windows.Forms.GroupBox()
        Me.mtbGuest3Age = New System.Windows.Forms.MaskedTextBox()
        Me.lblGuest3Age = New System.Windows.Forms.Label()
        Me.mtbGuest3PassportNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblGuest3PassportNo = New System.Windows.Forms.Label()
        Me.lblGuest3Name = New System.Windows.Forms.Label()
        Me.mtbGuest3Name = New System.Windows.Forms.MaskedTextBox()
        Me.grpGuest4Details = New System.Windows.Forms.GroupBox()
        Me.mtbGuest4Age = New System.Windows.Forms.MaskedTextBox()
        Me.lblGuest4Age = New System.Windows.Forms.Label()
        Me.mtbGuest4PassportNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblGuest4PassportNo = New System.Windows.Forms.Label()
        Me.lblGuest4Name = New System.Windows.Forms.Label()
        Me.mtbGuest4Name = New System.Windows.Forms.MaskedTextBox()
        Me.lblOnlyTheBest = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pgrTransactionProgress = New System.Windows.Forms.ProgressBar()
        Me.grpGuest2Details.SuspendLayout()
        Me.grpGuest3Details.SuspendLayout()
        Me.grpGuest4Details.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpGuest2Details
        '
        Me.grpGuest2Details.Controls.Add(Me.mtbGuest2Age)
        Me.grpGuest2Details.Controls.Add(Me.lblGuest2Age)
        Me.grpGuest2Details.Controls.Add(Me.mtbGuest2PassportNo)
        Me.grpGuest2Details.Controls.Add(Me.lblGuest2Passport)
        Me.grpGuest2Details.Controls.Add(Me.lblGuest2Name)
        Me.grpGuest2Details.Controls.Add(Me.mtbGuest2Name)
        Me.grpGuest2Details.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGuest2Details.ForeColor = System.Drawing.SystemColors.Control
        Me.grpGuest2Details.Location = New System.Drawing.Point(27, 94)
        Me.grpGuest2Details.Name = "grpGuest2Details"
        Me.grpGuest2Details.Size = New System.Drawing.Size(299, 130)
        Me.grpGuest2Details.TabIndex = 6
        Me.grpGuest2Details.TabStop = False
        Me.grpGuest2Details.Text = "Guest 2"
        Me.grpGuest2Details.Visible = False
        '
        'mtbGuest2Age
        '
        Me.mtbGuest2Age.Location = New System.Drawing.Point(161, 85)
        Me.mtbGuest2Age.Mask = "00"
        Me.mtbGuest2Age.Name = "mtbGuest2Age"
        Me.mtbGuest2Age.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest2Age.Size = New System.Drawing.Size(132, 26)
        Me.mtbGuest2Age.TabIndex = 16
        '
        'lblGuest2Age
        '
        Me.lblGuest2Age.AutoSize = True
        Me.lblGuest2Age.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblGuest2Age.Location = New System.Drawing.Point(6, 88)
        Me.lblGuest2Age.Name = "lblGuest2Age"
        Me.lblGuest2Age.Size = New System.Drawing.Size(88, 16)
        Me.lblGuest2Age.TabIndex = 15
        Me.lblGuest2Age.Text = "Guest Age:"
        '
        'mtbGuest2PassportNo
        '
        Me.mtbGuest2PassportNo.Location = New System.Drawing.Point(161, 53)
        Me.mtbGuest2PassportNo.Mask = "LL000000"
        Me.mtbGuest2PassportNo.Name = "mtbGuest2PassportNo"
        Me.mtbGuest2PassportNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest2PassportNo.Size = New System.Drawing.Size(132, 26)
        Me.mtbGuest2PassportNo.TabIndex = 5
        '
        'lblGuest2Passport
        '
        Me.lblGuest2Passport.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblGuest2Passport.Location = New System.Drawing.Point(6, 46)
        Me.lblGuest2Passport.Name = "lblGuest2Passport"
        Me.lblGuest2Passport.Size = New System.Drawing.Size(96, 36)
        Me.lblGuest2Passport.TabIndex = 1
        Me.lblGuest2Passport.Text = "Passport details:"
        '
        'lblGuest2Name
        '
        Me.lblGuest2Name.AutoSize = True
        Me.lblGuest2Name.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblGuest2Name.Location = New System.Drawing.Point(6, 21)
        Me.lblGuest2Name.Name = "lblGuest2Name"
        Me.lblGuest2Name.Size = New System.Drawing.Size(96, 16)
        Me.lblGuest2Name.TabIndex = 0
        Me.lblGuest2Name.Text = "Guest Name:"
        '
        'mtbGuest2Name
        '
        Me.mtbGuest2Name.Location = New System.Drawing.Point(161, 21)
        Me.mtbGuest2Name.Mask = "LLLLLLLLLLLLLLLLLLLL"
        Me.mtbGuest2Name.Name = "mtbGuest2Name"
        Me.mtbGuest2Name.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest2Name.Size = New System.Drawing.Size(132, 26)
        Me.mtbGuest2Name.TabIndex = 4
        '
        'grpGuest3Details
        '
        Me.grpGuest3Details.Controls.Add(Me.mtbGuest3Age)
        Me.grpGuest3Details.Controls.Add(Me.lblGuest3Age)
        Me.grpGuest3Details.Controls.Add(Me.mtbGuest3PassportNo)
        Me.grpGuest3Details.Controls.Add(Me.lblGuest3PassportNo)
        Me.grpGuest3Details.Controls.Add(Me.lblGuest3Name)
        Me.grpGuest3Details.Controls.Add(Me.mtbGuest3Name)
        Me.grpGuest3Details.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGuest3Details.ForeColor = System.Drawing.SystemColors.Control
        Me.grpGuest3Details.Location = New System.Drawing.Point(335, 94)
        Me.grpGuest3Details.Name = "grpGuest3Details"
        Me.grpGuest3Details.Size = New System.Drawing.Size(299, 130)
        Me.grpGuest3Details.TabIndex = 7
        Me.grpGuest3Details.TabStop = False
        Me.grpGuest3Details.Text = "Guest 3"
        Me.grpGuest3Details.Visible = False
        '
        'mtbGuest3Age
        '
        Me.mtbGuest3Age.Location = New System.Drawing.Point(161, 85)
        Me.mtbGuest3Age.Mask = "00"
        Me.mtbGuest3Age.Name = "mtbGuest3Age"
        Me.mtbGuest3Age.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest3Age.Size = New System.Drawing.Size(132, 26)
        Me.mtbGuest3Age.TabIndex = 16
        '
        'lblGuest3Age
        '
        Me.lblGuest3Age.AutoSize = True
        Me.lblGuest3Age.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblGuest3Age.Location = New System.Drawing.Point(6, 88)
        Me.lblGuest3Age.Name = "lblGuest3Age"
        Me.lblGuest3Age.Size = New System.Drawing.Size(88, 16)
        Me.lblGuest3Age.TabIndex = 15
        Me.lblGuest3Age.Text = "Guest Age:"
        '
        'mtbGuest3PassportNo
        '
        Me.mtbGuest3PassportNo.Location = New System.Drawing.Point(161, 53)
        Me.mtbGuest3PassportNo.Mask = "LL000000"
        Me.mtbGuest3PassportNo.Name = "mtbGuest3PassportNo"
        Me.mtbGuest3PassportNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest3PassportNo.Size = New System.Drawing.Size(132, 26)
        Me.mtbGuest3PassportNo.TabIndex = 5
        '
        'lblGuest3PassportNo
        '
        Me.lblGuest3PassportNo.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblGuest3PassportNo.Location = New System.Drawing.Point(6, 46)
        Me.lblGuest3PassportNo.Name = "lblGuest3PassportNo"
        Me.lblGuest3PassportNo.Size = New System.Drawing.Size(96, 36)
        Me.lblGuest3PassportNo.TabIndex = 1
        Me.lblGuest3PassportNo.Text = "Passport details:"
        '
        'lblGuest3Name
        '
        Me.lblGuest3Name.AutoSize = True
        Me.lblGuest3Name.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblGuest3Name.Location = New System.Drawing.Point(6, 21)
        Me.lblGuest3Name.Name = "lblGuest3Name"
        Me.lblGuest3Name.Size = New System.Drawing.Size(96, 16)
        Me.lblGuest3Name.TabIndex = 0
        Me.lblGuest3Name.Text = "Guest Name:"
        '
        'mtbGuest3Name
        '
        Me.mtbGuest3Name.Location = New System.Drawing.Point(161, 21)
        Me.mtbGuest3Name.Mask = "LLLLLLLLLLLLLLLLLLLL"
        Me.mtbGuest3Name.Name = "mtbGuest3Name"
        Me.mtbGuest3Name.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest3Name.Size = New System.Drawing.Size(132, 26)
        Me.mtbGuest3Name.TabIndex = 4
        '
        'grpGuest4Details
        '
        Me.grpGuest4Details.Controls.Add(Me.mtbGuest4Age)
        Me.grpGuest4Details.Controls.Add(Me.lblGuest4Age)
        Me.grpGuest4Details.Controls.Add(Me.mtbGuest4PassportNo)
        Me.grpGuest4Details.Controls.Add(Me.lblGuest4PassportNo)
        Me.grpGuest4Details.Controls.Add(Me.lblGuest4Name)
        Me.grpGuest4Details.Controls.Add(Me.mtbGuest4Name)
        Me.grpGuest4Details.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGuest4Details.ForeColor = System.Drawing.SystemColors.Control
        Me.grpGuest4Details.Location = New System.Drawing.Point(27, 229)
        Me.grpGuest4Details.Name = "grpGuest4Details"
        Me.grpGuest4Details.Size = New System.Drawing.Size(299, 130)
        Me.grpGuest4Details.TabIndex = 8
        Me.grpGuest4Details.TabStop = False
        Me.grpGuest4Details.Text = "Guest 4"
        Me.grpGuest4Details.Visible = False
        '
        'mtbGuest4Age
        '
        Me.mtbGuest4Age.Location = New System.Drawing.Point(161, 85)
        Me.mtbGuest4Age.Mask = "00"
        Me.mtbGuest4Age.Name = "mtbGuest4Age"
        Me.mtbGuest4Age.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest4Age.Size = New System.Drawing.Size(132, 26)
        Me.mtbGuest4Age.TabIndex = 14
        '
        'lblGuest4Age
        '
        Me.lblGuest4Age.AutoSize = True
        Me.lblGuest4Age.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblGuest4Age.Location = New System.Drawing.Point(6, 88)
        Me.lblGuest4Age.Name = "lblGuest4Age"
        Me.lblGuest4Age.Size = New System.Drawing.Size(88, 16)
        Me.lblGuest4Age.TabIndex = 13
        Me.lblGuest4Age.Text = "Guest Age:"
        '
        'mtbGuest4PassportNo
        '
        Me.mtbGuest4PassportNo.Location = New System.Drawing.Point(161, 53)
        Me.mtbGuest4PassportNo.Mask = "LL000000"
        Me.mtbGuest4PassportNo.Name = "mtbGuest4PassportNo"
        Me.mtbGuest4PassportNo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest4PassportNo.Size = New System.Drawing.Size(132, 26)
        Me.mtbGuest4PassportNo.TabIndex = 12
        '
        'lblGuest4PassportNo
        '
        Me.lblGuest4PassportNo.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblGuest4PassportNo.Location = New System.Drawing.Point(6, 46)
        Me.lblGuest4PassportNo.Name = "lblGuest4PassportNo"
        Me.lblGuest4PassportNo.Size = New System.Drawing.Size(96, 36)
        Me.lblGuest4PassportNo.TabIndex = 1
        Me.lblGuest4PassportNo.Text = "Passport details:"
        '
        'lblGuest4Name
        '
        Me.lblGuest4Name.AutoSize = True
        Me.lblGuest4Name.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblGuest4Name.Location = New System.Drawing.Point(6, 21)
        Me.lblGuest4Name.Name = "lblGuest4Name"
        Me.lblGuest4Name.Size = New System.Drawing.Size(96, 16)
        Me.lblGuest4Name.TabIndex = 0
        Me.lblGuest4Name.Text = "Guest Name:"
        '
        'mtbGuest4Name
        '
        Me.mtbGuest4Name.Location = New System.Drawing.Point(161, 21)
        Me.mtbGuest4Name.Mask = "LLLLLLLLLLLLLLLLLLLL"
        Me.mtbGuest4Name.Name = "mtbGuest4Name"
        Me.mtbGuest4Name.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbGuest4Name.Size = New System.Drawing.Size(132, 26)
        Me.mtbGuest4Name.TabIndex = 4
        '
        'lblOnlyTheBest
        '
        Me.lblOnlyTheBest.AutoSize = True
        Me.lblOnlyTheBest.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnlyTheBest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOnlyTheBest.Location = New System.Drawing.Point(157, 9)
        Me.lblOnlyTheBest.Name = "lblOnlyTheBest"
        Me.lblOnlyTheBest.Size = New System.Drawing.Size(321, 53)
        Me.lblOnlyTheBest.TabIndex = 9
        Me.lblOnlyTheBest.Text = "OnlyTheBest.Com"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(398, 401)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(209, 85)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "Next ->"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'pgrTransactionProgress
        '
        Me.pgrTransactionProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgrTransactionProgress.ForeColor = System.Drawing.Color.Coral
        Me.pgrTransactionProgress.Location = New System.Drawing.Point(166, 65)
        Me.pgrTransactionProgress.Name = "pgrTransactionProgress"
        Me.pgrTransactionProgress.Size = New System.Drawing.Size(312, 23)
        Me.pgrTransactionProgress.TabIndex = 12
        Me.pgrTransactionProgress.Value = 28
        '
        'frmExtraGuests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(646, 567)
        Me.Controls.Add(Me.pgrTransactionProgress)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblOnlyTheBest)
        Me.Controls.Add(Me.grpGuest4Details)
        Me.Controls.Add(Me.grpGuest3Details)
        Me.Controls.Add(Me.grpGuest2Details)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.Name = "frmExtraGuests"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExtraGuests"
        Me.grpGuest2Details.ResumeLayout(False)
        Me.grpGuest2Details.PerformLayout()
        Me.grpGuest3Details.ResumeLayout(False)
        Me.grpGuest3Details.PerformLayout()
        Me.grpGuest4Details.ResumeLayout(False)
        Me.grpGuest4Details.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpGuest2Details As System.Windows.Forms.GroupBox
    Friend WithEvents lblGuest2Passport As System.Windows.Forms.Label
    Friend WithEvents lblGuest2Name As System.Windows.Forms.Label
    Friend WithEvents mtbGuest2Name As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grpGuest3Details As System.Windows.Forms.GroupBox
    Friend WithEvents lblGuest3PassportNo As System.Windows.Forms.Label
    Friend WithEvents lblGuest3Name As System.Windows.Forms.Label
    Friend WithEvents mtbGuest3Name As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grpGuest4Details As System.Windows.Forms.GroupBox
    Friend WithEvents lblGuest4PassportNo As System.Windows.Forms.Label
    Friend WithEvents lblGuest4Name As System.Windows.Forms.Label
    Friend WithEvents mtbGuest4Name As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblOnlyTheBest As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents mtbGuest2PassportNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbGuest3PassportNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbGuest4PassportNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbGuest2Age As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblGuest2Age As System.Windows.Forms.Label
    Friend WithEvents mtbGuest3Age As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblGuest3Age As System.Windows.Forms.Label
    Friend WithEvents mtbGuest4Age As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblGuest4Age As System.Windows.Forms.Label
    Friend WithEvents pgrTransactionProgress As ProgressBar
End Class
