<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccountCreation
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.gtbUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblUsernameLength = New System.Windows.Forms.Label()
        Me.lblEmailLength = New System.Windows.Forms.Label()
        Me.gtbEMail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPasswordLength = New System.Windows.Forms.Label()
        Me.gtbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.gpiMain = New Guna.UI2.WinForms.Guna2ProgressIndicator()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Animated = True
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.BorderRadius = 4
        Me.btnCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnCreate.Font = New System.Drawing.Font("Lato Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(680, 378)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(88, 45)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Animated = True
        Me.btnCancel.BorderRadius = 4
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.Font = New System.Drawing.Font("Lato Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(12, 378)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 45)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'gtbUsername
        '
        Me.gtbUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbUsername.DefaultText = ""
        Me.gtbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gtbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbUsername.Location = New System.Drawing.Point(84, 13)
        Me.gtbUsername.Name = "gtbUsername"
        Me.gtbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbUsername.PlaceholderText = "Username"
        Me.gtbUsername.SelectedText = ""
        Me.gtbUsername.Size = New System.Drawing.Size(684, 36)
        Me.gtbUsername.TabIndex = 2
        '
        'lblUsernameLength
        '
        Me.lblUsernameLength.AutoSize = True
        Me.lblUsernameLength.Font = New System.Drawing.Font("Lato Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameLength.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblUsernameLength.Location = New System.Drawing.Point(84, 56)
        Me.lblUsernameLength.Name = "lblUsernameLength"
        Me.lblUsernameLength.Size = New System.Drawing.Size(42, 18)
        Me.lblUsernameLength.TabIndex = 4
        Me.lblUsernameLength.Text = "0/32"
        '
        'lblEmailLength
        '
        Me.lblEmailLength.AutoSize = True
        Me.lblEmailLength.Font = New System.Drawing.Font("Lato Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailLength.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblEmailLength.Location = New System.Drawing.Point(87, 131)
        Me.lblEmailLength.Name = "lblEmailLength"
        Me.lblEmailLength.Size = New System.Drawing.Size(51, 18)
        Me.lblEmailLength.TabIndex = 6
        Me.lblEmailLength.Text = "0/255"
        '
        'gtbEMail
        '
        Me.gtbEMail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbEMail.DefaultText = ""
        Me.gtbEMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbEMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbEMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbEMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbEMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbEMail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gtbEMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbEMail.Location = New System.Drawing.Point(87, 88)
        Me.gtbEMail.Name = "gtbEMail"
        Me.gtbEMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbEMail.PlaceholderText = "EMail"
        Me.gtbEMail.SelectedText = ""
        Me.gtbEMail.Size = New System.Drawing.Size(681, 36)
        Me.gtbEMail.TabIndex = 5
        '
        'lblPasswordLength
        '
        Me.lblPasswordLength.AutoSize = True
        Me.lblPasswordLength.Font = New System.Drawing.Font("Lato Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordLength.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPasswordLength.Location = New System.Drawing.Point(84, 206)
        Me.lblPasswordLength.Name = "lblPasswordLength"
        Me.lblPasswordLength.Size = New System.Drawing.Size(42, 18)
        Me.lblPasswordLength.TabIndex = 8
        Me.lblPasswordLength.Text = "0/64"
        '
        'gtbPassword
        '
        Me.gtbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbPassword.DefaultText = ""
        Me.gtbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gtbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbPassword.Location = New System.Drawing.Point(84, 163)
        Me.gtbPassword.Name = "gtbPassword"
        Me.gtbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.gtbPassword.PlaceholderText = "Password"
        Me.gtbPassword.SelectedText = ""
        Me.gtbPassword.Size = New System.Drawing.Size(684, 36)
        Me.gtbPassword.TabIndex = 7
        Me.gtbPassword.UseSystemPasswordChar = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BorderRadius = 4
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.ZAppGet.My.Resources.Resources.user_96px
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(66, 57)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 9
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.BorderRadius = 4
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.ZAppGet.My.Resources.Resources.mail_96px
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(12, 87)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(66, 57)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 10
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.BorderRadius = 4
        Me.Guna2PictureBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = Global.ZAppGet.My.Resources.Resources.Key_Security_96px
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(12, 163)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(66, 57)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 11
        Me.Guna2PictureBox3.TabStop = False
        '
        'gpiMain
        '
        Me.gpiMain.AutoStart = True
        Me.gpiMain.Location = New System.Drawing.Point(584, 333)
        Me.gpiMain.Name = "gpiMain"
        Me.gpiMain.Size = New System.Drawing.Size(90, 90)
        Me.gpiMain.TabIndex = 12
        Me.gpiMain.Visible = False
        '
        'frmAccountCreation
        '
        Me.AcceptButton = Me.btnCreate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(780, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.gpiMain)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.lblPasswordLength)
        Me.Controls.Add(Me.gtbPassword)
        Me.Controls.Add(Me.lblEmailLength)
        Me.Controls.Add(Me.gtbEMail)
        Me.Controls.Add(Me.lblUsernameLength)
        Me.Controls.Add(Me.gtbUsername)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAccountCreation"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAccountCreation"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblPasswordLength As Label
    Friend WithEvents gtbPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblEmailLength As Label
    Friend WithEvents gtbEMail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblUsernameLength As Label
    Friend WithEvents gtbUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gpiMain As Guna.UI2.WinForms.Guna2ProgressIndicator
End Class
