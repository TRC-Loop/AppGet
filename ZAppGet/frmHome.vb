Public Class frmHome
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Darkmode Then
            Me.BackColor = Color.FromArgb(20, 33, 61)
        Else
            Me.BackColor = Color.FromArgb(0, 191, 255)
        End If
    End Sub
End Class