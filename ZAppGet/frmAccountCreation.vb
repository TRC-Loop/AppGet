Public Class frmAccountCreation
    Dim fault As String = ""
    Private Sub gtbPassword_TextChanged(sender As Object, e As EventArgs) Handles gtbPassword.TextChanged
        lblPasswordLength.Text = gtbPassword.Text.Length.ToString() + "/64"
        If gtbPassword.Text.Length >= 64 Then
            lblPasswordLength.ForeColor = Color.Red
            btnCreate.Enabled = False
        Else
            lblPasswordLength.ForeColor = Color.Gainsboro
            btnCreate.Enabled = True
        End If


    End Sub

    Private Sub gtbEMail_TextChanged(sender As Object, e As EventArgs) Handles gtbEMail.TextChanged
        lblEmailLength.Text = gtbEMail.Text.Length.ToString() + "/255"
        If gtbEMail.Text.Length >= 255 Then
            lblEmailLength.ForeColor = Color.Red
            btnCreate.Enabled = False
        Else
            lblEmailLength.ForeColor = Color.Gainsboro
            btnCreate.Enabled = True
        End If
    End Sub

    Private Sub gtbUsername_TextChanged(sender As Object, e As EventArgs) Handles gtbUsername.TextChanged
        lblUsernameLength.Text = gtbUsername.Text.Length.ToString() + "/32"
        If gtbUsername.Text.Length >= 32 Then
            lblUsernameLength.ForeColor = Color.Red
            btnCreate.Enabled = False
        Else
            lblUsernameLength.ForeColor = Color.Gainsboro
            btnCreate.Enabled = True
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        gtbPassword.Text = ""
        gtbEMail.Text = ""
        CancelLoading()
        Me.Close()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ShowLoading()
        CreateAccount()
    End Sub

    Private Sub ShowFault()
        CancelLoading()
        Dim errorbox As New Guna.UI2.WinForms.Guna2MessageDialog
        If My.Settings.Darkmode = True Then
            errorbox.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        Else
            errorbox.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        End If
        errorbox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        errorbox.Caption = "Error while creating Account."
        errorbox.Text = fault
        errorbox.Show()
    End Sub
    Private Sub CreateAccount()
        If gtbUsername.Text.Length >= 32 Then
            CancelLoading()
            fault = "Username too long"
            ShowFault()
            Exit Sub
        End If
        If gtbUsername.Text.Length <= 4 Then
            CancelLoading()
            fault = "Username too short"
            ShowFault()
            Exit Sub
        End If
        If gtbEMail.Text.Length >= 255 Then
            CancelLoading()
            fault = "EMail too long"
            ShowFault()
            Exit Sub
        End If
        If Not ValidateEmail(gtbEMail.Text) Then
            CancelLoading()
            fault = "EMail does not exist"
            ShowFault()
            Exit Sub
        End If
        If gtbPassword.Text.Length >= 64 Then
            CancelLoading()
            fault = "Password too long"
            ShowFault()
            Exit Sub
        End If
        If gtbPassword.Text.Length <= 4 Then
            CancelLoading()
            fault = "Password too short"
            ShowFault()
            Exit Sub
        End If

    End Sub
    Public Function ValidateEmail(ByVal strCheck As String) As Boolean
        Try
            Dim vEmailAddress As New System.Net.Mail.MailAddress(strCheck)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Function ContainsSpecialChars(s As String) As Boolean
        Return s.IndexOfAny("[~`!@#$%^&*()+=|{}':;,<>/?]/\´` ".ToCharArray) <> -1
    End Function

    Private Sub ShowLoading()
        Guna2PictureBox1.Hide()
        Guna2PictureBox2.Hide()
        Guna2PictureBox3.Hide()
        gtbUsername.Hide()
        btnCancel.Hide()
        btnCreate.Hide()
        gtbEMail.Hide()
        gtbPassword.Hide()
        lblUsernameLength.Hide()
        lblEmailLength.Hide()
        lblPasswordLength.Hide()
        gpiMain.Location = New Point((Me.Width / 2) - (gpiMain.Width / 2), (Me.Height / 2) - (gpiMain.Height / 2))
        gpiMain.Show()
    End Sub

    Private Sub CancelLoading()
        Guna2PictureBox1.Show()
        Guna2PictureBox2.Show()
        Guna2PictureBox3.Show()
        gtbUsername.Show()
        btnCancel.Show()
        btnCreate.Show()
        gtbEMail.Show()
        gtbPassword.Show()
        lblUsernameLength.Show()
        lblEmailLength.Show()
        lblPasswordLength.Show()
        gpiMain.Location = New Point((Me.Width / 2) - (gpiMain.Width / 2), (Me.Height / 2) - (gpiMain.Height / 2))
        gpiMain.Hide()
    End Sub

    Private Sub frmAccountCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CancelLoading()
    End Sub
End Class