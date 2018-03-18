<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdoVisa = New System.Windows.Forms.RadioButton()
        Me.rdoMasterCard = New System.Windows.Forms.RadioButton()
        Me.rdoAmericanExpress = New System.Windows.Forms.RadioButton()
        Me.pbxAmericanExpress = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pbxVisa = New System.Windows.Forms.PictureBox()
        Me.pbxMasterCard = New System.Windows.Forms.PictureBox()
        Me.grpCardInformation = New System.Windows.Forms.GroupBox()
        Me.mtbExpiryDate = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSecurityCode = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCardHoldersName = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCardHoldersName = New System.Windows.Forms.Label()
        Me.lblOnlyTheBest = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pgrTransactionProgress = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxAmericanExpress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxVisa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMasterCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCardInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rdoVisa)
        Me.GroupBox1.Controls.Add(Me.rdoMasterCard)
        Me.GroupBox1.Controls.Add(Me.rdoAmericanExpress)
        Me.GroupBox1.Controls.Add(Me.pbxAmericanExpress)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.pbxVisa)
        Me.GroupBox1.Controls.Add(Me.pbxMasterCard)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Payment Method:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'rdoVisa
        '
        Me.rdoVisa.AutoSize = True
        Me.rdoVisa.Location = New System.Drawing.Point(380, 81)
        Me.rdoVisa.Name = "rdoVisa"
        Me.rdoVisa.Size = New System.Drawing.Size(14, 13)
        Me.rdoVisa.TabIndex = 5
        Me.rdoVisa.TabStop = True
        Me.rdoVisa.UseVisualStyleBackColor = True
        '
        'rdoMasterCard
        '
        Me.rdoMasterCard.AutoSize = True
        Me.rdoMasterCard.Location = New System.Drawing.Point(221, 81)
        Me.rdoMasterCard.Name = "rdoMasterCard"
        Me.rdoMasterCard.Size = New System.Drawing.Size(14, 13)
        Me.rdoMasterCard.TabIndex = 4
        Me.rdoMasterCard.TabStop = True
        Me.rdoMasterCard.UseVisualStyleBackColor = True
        '
        'rdoAmericanExpress
        '
        Me.rdoAmericanExpress.AutoSize = True
        Me.rdoAmericanExpress.Location = New System.Drawing.Point(75, 81)
        Me.rdoAmericanExpress.Name = "rdoAmericanExpress"
        Me.rdoAmericanExpress.Size = New System.Drawing.Size(14, 13)
        Me.rdoAmericanExpress.TabIndex = 3
        Me.rdoAmericanExpress.TabStop = True
        Me.rdoAmericanExpress.UseVisualStyleBackColor = True
        '
        'pbxAmericanExpress
        '
        Me.pbxAmericanExpress.Image = CType(resources.GetObject("pbxAmericanExpress.Image"), System.Drawing.Image)
        Me.pbxAmericanExpress.Location = New System.Drawing.Point(34, 25)
        Me.pbxAmericanExpress.Name = "pbxAmericanExpress"
        Me.pbxAmericanExpress.Size = New System.Drawing.Size(100, 50)
        Me.pbxAmericanExpress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAmericanExpress.TabIndex = 3
        Me.pbxAmericanExpress.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(326, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(0, 0)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'pbxVisa
        '
        Me.pbxVisa.Image = CType(resources.GetObject("pbxVisa.Image"), System.Drawing.Image)
        Me.pbxVisa.Location = New System.Drawing.Point(332, 25)
        Me.pbxVisa.Name = "pbxVisa"
        Me.pbxVisa.Size = New System.Drawing.Size(100, 50)
        Me.pbxVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxVisa.TabIndex = 1
        Me.pbxVisa.TabStop = False
        '
        'pbxMasterCard
        '
        Me.pbxMasterCard.Image = CType(resources.GetObject("pbxMasterCard.Image"), System.Drawing.Image)
        Me.pbxMasterCard.Location = New System.Drawing.Point(174, 25)
        Me.pbxMasterCard.Name = "pbxMasterCard"
        Me.pbxMasterCard.Size = New System.Drawing.Size(100, 50)
        Me.pbxMasterCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxMasterCard.TabIndex = 0
        Me.pbxMasterCard.TabStop = False
        '
        'grpCardInformation
        '
        Me.grpCardInformation.Controls.Add(Me.mtbExpiryDate)
        Me.grpCardInformation.Controls.Add(Me.mtbSecurityCode)
        Me.grpCardInformation.Controls.Add(Me.mtbCardHoldersName)
        Me.grpCardInformation.Controls.Add(Me.mtbCardNumber)
        Me.grpCardInformation.Controls.Add(Me.Label3)
        Me.grpCardInformation.Controls.Add(Me.Label2)
        Me.grpCardInformation.Controls.Add(Me.Label1)
        Me.grpCardInformation.Controls.Add(Me.lblCardHoldersName)
        Me.grpCardInformation.ForeColor = System.Drawing.SystemColors.Control
        Me.grpCardInformation.Location = New System.Drawing.Point(12, 205)
        Me.grpCardInformation.Name = "grpCardInformation"
        Me.grpCardInformation.Size = New System.Drawing.Size(460, 157)
        Me.grpCardInformation.TabIndex = 1
        Me.grpCardInformation.TabStop = False
        Me.grpCardInformation.Text = "CreditCard Information::"
        '
        'mtbExpiryDate
        '
        Me.mtbExpiryDate.Location = New System.Drawing.Point(287, 122)
        Me.mtbExpiryDate.Mask = "00/00"
        Me.mtbExpiryDate.Name = "mtbExpiryDate"
        Me.mtbExpiryDate.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbExpiryDate.Size = New System.Drawing.Size(167, 29)
        Me.mtbExpiryDate.TabIndex = 7
        '
        'mtbSecurityCode
        '
        Me.mtbSecurityCode.Location = New System.Drawing.Point(287, 87)
        Me.mtbSecurityCode.Mask = "000"
        Me.mtbSecurityCode.Name = "mtbSecurityCode"
        Me.mtbSecurityCode.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbSecurityCode.Size = New System.Drawing.Size(167, 29)
        Me.mtbSecurityCode.TabIndex = 6
        '
        'mtbCardHoldersName
        '
        Me.mtbCardHoldersName.Location = New System.Drawing.Point(287, 17)
        Me.mtbCardHoldersName.Mask = "LLLLLLLLLLLLLLLLLLLLL"
        Me.mtbCardHoldersName.Name = "mtbCardHoldersName"
        Me.mtbCardHoldersName.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCardHoldersName.Size = New System.Drawing.Size(167, 29)
        Me.mtbCardHoldersName.TabIndex = 5
        '
        'mtbCardNumber
        '
        Me.mtbCardNumber.Location = New System.Drawing.Point(287, 52)
        Me.mtbCardNumber.Mask = "00000000"
        Me.mtbCardNumber.Name = "mtbCardNumber"
        Me.mtbCardNumber.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCardNumber.Size = New System.Drawing.Size(167, 29)
        Me.mtbCardNumber.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(13, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Expiry Date: (MM/YY)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(13, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Security Code:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(13, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Card Number:"
        '
        'lblCardHoldersName
        '
        Me.lblCardHoldersName.AutoSize = True
        Me.lblCardHoldersName.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblCardHoldersName.Location = New System.Drawing.Point(13, 24)
        Me.lblCardHoldersName.Name = "lblCardHoldersName"
        Me.lblCardHoldersName.Size = New System.Drawing.Size(152, 16)
        Me.lblCardHoldersName.TabIndex = 0
        Me.lblCardHoldersName.Text = "Card-Holders Name:"
        '
        'lblOnlyTheBest
        '
        Me.lblOnlyTheBest.AutoSize = True
        Me.lblOnlyTheBest.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnlyTheBest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOnlyTheBest.Location = New System.Drawing.Point(78, 9)
        Me.lblOnlyTheBest.Name = "lblOnlyTheBest"
        Me.lblOnlyTheBest.Size = New System.Drawing.Size(321, 53)
        Me.lblOnlyTheBest.TabIndex = 9
        Me.lblOnlyTheBest.Text = "OnlyTheBest.Com"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(300, 368)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(172, 84)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "Next:"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'pgrTransactionProgress
        '
        Me.pgrTransactionProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgrTransactionProgress.ForeColor = System.Drawing.Color.Coral
        Me.pgrTransactionProgress.Location = New System.Drawing.Point(87, 65)
        Me.pgrTransactionProgress.Name = "pgrTransactionProgress"
        Me.pgrTransactionProgress.Size = New System.Drawing.Size(312, 23)
        Me.pgrTransactionProgress.TabIndex = 12
        Me.pgrTransactionProgress.Value = 70
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.pgrTransactionProgress)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblOnlyTheBest)
        Me.Controls.Add(Me.grpCardInformation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Courier New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbxAmericanExpress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxVisa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMasterCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCardInformation.ResumeLayout(False)
        Me.grpCardInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdoVisa As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMasterCard As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAmericanExpress As System.Windows.Forms.RadioButton
    Friend WithEvents pbxAmericanExpress As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxVisa As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMasterCard As System.Windows.Forms.PictureBox
    Friend WithEvents grpCardInformation As System.Windows.Forms.GroupBox
    Friend WithEvents mtbExpiryDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbSecurityCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCardHoldersName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCardNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCardHoldersName As System.Windows.Forms.Label
    Friend WithEvents lblOnlyTheBest As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents pgrTransactionProgress As ProgressBar
End Class
