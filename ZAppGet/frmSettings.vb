Public Class frmSettings
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        frmAccountCreation.ShowDialog()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Darkmode Then
            Me.BackColor = Color.FromArgb(20, 33, 61)
        Else
            Me.BackColor = Color.FromArgb(0, 191, 255)
        End If
        gtsDarkMode.Checked = My.Settings.Darkmode
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.Darkmode = gtsDarkMode.Checked
        My.Settings.Save()
        Application.Restart()
    End Sub
End Class