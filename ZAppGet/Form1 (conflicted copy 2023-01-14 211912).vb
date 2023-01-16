Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows
Imports System.Windows.Threading
Public Class Form1
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2

    <DllImport("User32")> Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub pnlTitlebar_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlTitlebar.MouseDown
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub tmr30SecondRefresher_Tick(sender As Object, e As EventArgs) Handles tmr30SecondRefresher.Tick
        Second30Refresh()
    End Sub
    Private Sub Second30Refresh()
        lblTimeTtielbar.Text = Now.ToString("HH:mm - dd/MM/yyyy")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Second30Refresh()
    End Sub
End Class
