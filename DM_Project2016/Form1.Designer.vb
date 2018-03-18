<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.mtbPassword = New System.Windows.Forms.MaskedTextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblOnlyTheBest = New System.Windows.Forms.Label()
        Me.grpLoginDetails = New System.Windows.Forms.GroupBox()
        Me.lblUsernameError = New System.Windows.Forms.Label()
        Me.lblIncorrectPassword = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.grpLoginDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(187, 26)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(141, 26)
        Me.txtUsername.TabIndex = 0
        '
        'mtbPassword
        '
        Me.mtbPassword.Location = New System.Drawing.Point(187, 74)
        Me.mtbPassword.Name = "mtbPassword"
        Me.mtbPassword.Size = New System.Drawing.Size(141, 26)
        Me.mtbPassword.TabIndex = 2
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUserName.Location = New System.Drawing.Point(6, 31)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(109, 21)
        Me.lblUserName.TabIndex = 3
        Me.lblUserName.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPassword.Location = New System.Drawing.Point(6, 76)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(109, 21)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password:"
        '
        'lblOnlyTheBest
        '
        Me.lblOnlyTheBest.AutoSize = True
        Me.lblOnlyTheBest.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnlyTheBest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOnlyTheBest.Location = New System.Drawing.Point(74, 27)
        Me.lblOnlyTheBest.Name = "lblOnlyTheBest"
        Me.lblOnlyTheBest.Size = New System.Drawing.Size(321, 53)
        Me.lblOnlyTheBest.TabIndex = 5
        Me.lblOnlyTheBest.Text = "OnlyTheBest.Com"
        '
        'grpLoginDetails
        '
        Me.grpLoginDetails.Controls.Add(Me.lblUsernameError)
        Me.grpLoginDetails.Controls.Add(Me.lblIncorrectPassword)
        Me.grpLoginDetails.Controls.Add(Me.btnLogin)
        Me.grpLoginDetails.Controls.Add(Me.lblPassword)
        Me.grpLoginDetails.Controls.Add(Me.lblUserName)
        Me.grpLoginDetails.Controls.Add(Me.mtbPassword)
        Me.grpLoginDetails.Controls.Add(Me.txtUsername)
        Me.grpLoginDetails.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLoginDetails.ForeColor = System.Drawing.SystemColors.Control
        Me.grpLoginDetails.Location = New System.Drawing.Point(34, 92)
        Me.grpLoginDetails.Name = "grpLoginDetails"
        Me.grpLoginDetails.Size = New System.Drawing.Size(438, 179)
        Me.grpLoginDetails.TabIndex = 6
        Me.grpLoginDetails.TabStop = False
        Me.grpLoginDetails.Text = "Login Details:"
        '
        'lblUsernameError
        '
        Me.lblUsernameError.AutoSize = True
        Me.lblUsernameError.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameError.ForeColor = System.Drawing.Color.Red
        Me.lblUsernameError.Location = New System.Drawing.Point(334, 30)
        Me.lblUsernameError.Name = "lblUsernameError"
        Me.lblUsernameError.Size = New System.Drawing.Size(97, 15)
        Me.lblUsernameError.TabIndex = 9
        Me.lblUsernameError.Text = "Incorrect Username"
        Me.lblUsernameError.Visible = False
        '
        'lblIncorrectPassword
        '
        Me.lblIncorrectPassword.AutoSize = True
        Me.lblIncorrectPassword.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrectPassword.ForeColor = System.Drawing.Color.Red
        Me.lblIncorrectPassword.Location = New System.Drawing.Point(334, 78)
        Me.lblIncorrectPassword.Name = "lblIncorrectPassword"
        Me.lblIncorrectPassword.Size = New System.Drawing.Size(95, 15)
        Me.lblIncorrectPassword.TabIndex = 8
        Me.lblIncorrectPassword.Text = "Incorrect Password"
        Me.lblIncorrectPassword.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogin.Location = New System.Drawing.Point(10, 121)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(334, 34)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login:"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.grpLoginDetails)
        Me.Controls.Add(Me.lblOnlyTheBest)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.grpLoginDetails.ResumeLayout(False)
        Me.grpLoginDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents mtbPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblOnlyTheBest As System.Windows.Forms.Label
    Friend WithEvents grpLoginDetails As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblUsernameError As System.Windows.Forms.Label
    Friend WithEvents lblIncorrectPassword As System.Windows.Forms.Label
End Class
