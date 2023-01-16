Public Class frmWelcome
    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVer.Text = Application.ProductVersion.ToString()
    End Sub

    Private Sub frmWelcome_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Form1.Show()
        Me.Hide()
    End Sub
End Class