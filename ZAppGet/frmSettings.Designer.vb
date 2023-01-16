<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCreateAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.gtsDarkMode = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.lblDarkMode = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Animated = True
        Me.btnCreateAccount.BorderRadius = 6
        Me.btnCreateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreateAccount.FillColor = System.Drawing.Color.CadetBlue
        Me.btnCreateAccount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.White
        Me.btnCreateAccount.Location = New System.Drawing.Point(13, 295)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(180, 45)
        Me.btnCreateAccount.TabIndex = 0
        Me.btnCreateAccount.Text = "Create Account"
        '
        'gtsDarkMode
        '
        Me.gtsDarkMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gtsDarkMode.Animated = True
        Me.gtsDarkMode.AutoRoundedCorners = True
        Me.gtsDarkMode.Checked = True
        Me.gtsDarkMode.CheckedState.BorderColor = System.Drawing.Color.Lime
        Me.gtsDarkMode.CheckedState.BorderRadius = 12
        Me.gtsDarkMode.CheckedState.BorderThickness = 1
        Me.gtsDarkMode.CheckedState.FillColor = System.Drawing.Color.SpringGreen
        Me.gtsDarkMode.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.gtsDarkMode.CheckedState.InnerBorderRadius = 8
        Me.gtsDarkMode.CheckedState.InnerColor = System.Drawing.Color.White
        Me.gtsDarkMode.CheckedState.InnerOffset = 1
        Me.gtsDarkMode.Location = New System.Drawing.Point(656, 12)
        Me.gtsDarkMode.Name = "gtsDarkMode"
        Me.gtsDarkMode.Size = New System.Drawing.Size(67, 27)
        Me.gtsDarkMode.TabIndex = 1
        Me.gtsDarkMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.gtsDarkMode.UncheckedState.BorderRadius = 12
        Me.gtsDarkMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.gtsDarkMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.gtsDarkMode.UncheckedState.InnerBorderRadius = 8
        Me.gtsDarkMode.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'lblDarkMode
        '
        Me.lblDarkMode.AutoSize = True
        Me.lblDarkMode.Font = New System.Drawing.Font("Lato Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDarkMode.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblDarkMode.Location = New System.Drawing.Point(13, 12)
        Me.lblDarkMode.Name = "lblDarkMode"
        Me.lblDarkMode.Size = New System.Drawing.Size(97, 19)
        Me.lblDarkMode.TabIndex = 2
        Me.lblDarkMode.Text = "Dark Mode"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Animated = True
        Me.btnSave.BorderRadius = 6
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.Teal
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(543, 295)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(180, 45)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save and Restart Appget"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(735, 352)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblDarkMode)
        Me.Controls.Add(Me.gtsDarkMode)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettings"
        Me.Text = "frmSettings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gtsDarkMode As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents lblDarkMode As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
End Class
