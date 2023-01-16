Imports System.Runtime.InteropServices
Public Class Form1
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Dim currForm As Form = frmHome
    Public Const HT_CAPTION As Integer = 2
    Friend SideMenuCollapsed As Boolean = False
    Dim MyUser As New User
    <DllImport("User32")> Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean
    End Function

    Public Sub ApplyColorMode()
        Select Case My.Settings.Darkmode
            Case True
                pnlTitlebar.BackColor = Color.FromArgb(4, 49, 120)
                pnlSidemenu.BackColor = Color.FromArgb(34, 79, 150)
                pnlWindow.BackColor = Color.FromArgb(20, 33, 61)
                pnlTitlebar.FillColor = Color.FromArgb(4, 49, 120)
                pnlSidemenu.FillColor = Color.FromArgb(34, 79, 150)
                pnlWindow.FillColor = Color.FromArgb(20, 33, 61)
                btnSideMenuMenu.BackColor = Color.FromArgb(94, 148, 255)
                btnSideMenuMenu.FillColor = Color.FromArgb(94, 148, 255)

            Case False
                pnlTitlebar.BackColor = Color.FromArgb(0, 0, 205)
                pnlSidemenu.BackColor = Color.FromArgb(30, 144, 255)
                pnlWindow.BackColor = Color.FromArgb(0, 191, 255)
                pnlTitlebar.FillColor = Color.FromArgb(0, 0, 205)
                pnlSidemenu.FillColor = Color.FromArgb(30, 144, 255)
                pnlWindow.FillColor = Color.FromArgb(0, 191, 255)
                btnSideMenuMenu.BackColor = Color.FromArgb(0, 0, 139)
                btnSideMenuMenu.FillColor = Color.FromArgb(0, 0, 139)
            Case Else
                My.Settings.Darkmode = True
                My.Settings.Save()
                ApplyColorMode()
        End Select

    End Sub

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
        ApplyColorMode()
        Second30Refresh()
        lblDestination.Text = "Home"
        Dim frmcurr = New frmHome()
        frmcurr.TopLevel = False
        frmcurr.FormBorderStyle = FormBorderStyle.None
        frmcurr.Dock = DockStyle.Fill
        frmcurr.TopMost = True
        pnlWindow.Controls.Add(frmcurr)
        frmcurr.Show()
        initPopUps()
    End Sub

    Private Sub initPopUps()
        mttBTNHOME.SetToolTip(btnHome, "The Homepage or so called, Dashboard")
        mttBTNSEARCH.SetToolTip(btnSearch, "Search for an App or View the most popular Games.")
        mttBTNMARKED.SetToolTip(btnMarked, "View all your marked Apps.")
        mttBTNINSTALLEDAPPS.SetToolTip(btnInstalledApps, "View all your installed Apps.")
        mttBTNMYAPPS.SetToolTip(btnMyApps, "View all your Released Apps." + vbNewLine + "This Button will only show if you have activated the Developer Setting.")
        mttBTNSETTINGS.SetToolTip(btnSettings, "Manage the Settings of AppGet or your Account Settings.")
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSideMenuMenu.Click
        If SideMenuCollapsed = False Then
            tmrAnimationSideMenuClose.Enabled = True
            SideMenuCollapsed = True
        Else
            tmrAnimationSideMenu.Enabled = True
            SideMenuCollapsed = False
        End If
    End Sub

    Private Sub tmrAnimationSideMenuClose_Tick(sender As Object, e As EventArgs) Handles tmrAnimationSideMenuClose.Tick
        If pnlSidemenu.Width <= 75 Then
            ' Close Procedure
            lblDestination.Hide()
            tmrAnimationSideMenuClose.Enabled = False
            Exit Sub
        Else
            pnlSidemenu.Width -= 16
        End If
    End Sub

    Private Sub tmrAnimationSideMenu_Tick(sender As Object, e As EventArgs) Handles tmrAnimationSideMenu.Tick
        If pnlSidemenu.Width >= 150 Then
            lblDestination.Show()
        End If
        If pnlSidemenu.Width >= 250 Then
            ' Open Procedure

            tmrAnimationSideMenu.Enabled = False
            Exit Sub
        Else
            pnlSidemenu.Width += 16
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        lblDestination.Text = "Home"
        Dim frmcurr = New frmHome()
        currForm.Close()
        pnlWindow.Controls.Clear()
        currForm = frmcurr
        frmcurr.TopLevel = False
        frmcurr.FormBorderStyle = FormBorderStyle.None
        frmcurr.Dock = DockStyle.Fill
        frmcurr.TopMost = True
        pnlWindow.Controls.Add(frmcurr)
        frmcurr.Show()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Resize the secondary form to match the size of the panel
        For Each c As Control In pnlWindow.Controls
            If TypeOf c Is Form Then
                c.Size = pnlWindow.Size
            End If
        Next
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lblDestination.Text = "Search"
        Dim frmcurr = New frmSearch()
        currForm.Close()
        pnlWindow.Controls.Clear()
        currForm = frmcurr
        frmcurr.TopLevel = False
        frmcurr.FormBorderStyle = FormBorderStyle.None
        frmcurr.Dock = DockStyle.Fill
        frmcurr.TopMost = True
        pnlWindow.Controls.Add(frmcurr)
        frmcurr.Show()
    End Sub

    Private Sub btnMarked_Click(sender As Object, e As EventArgs) Handles btnMarked.Click
        lblDestination.Text = "Marked"
        Dim frmcurr = New frmMarked()
        currForm.Close()
        pnlWindow.Controls.Clear()
        currForm = frmcurr
        frmcurr.TopLevel = False
        frmcurr.FormBorderStyle = FormBorderStyle.None
        frmcurr.Dock = DockStyle.Fill
        frmcurr.TopMost = True
        pnlWindow.Controls.Add(frmcurr)
        frmcurr.Show()
    End Sub

    Private Sub btnInstalled_Click(sender As Object, e As EventArgs) Handles btnInstalledApps.Click
        lblDestination.Text = "Installed"
        Dim frmcurr = New frmInstalled()
        currForm.Close()
        pnlWindow.Controls.Clear()
        currForm = frmcurr
        frmcurr.TopLevel = False
        frmcurr.FormBorderStyle = FormBorderStyle.None
        frmcurr.Dock = DockStyle.Fill
        frmcurr.TopMost = True
        pnlWindow.Controls.Add(frmcurr)
        frmcurr.Show()
    End Sub

    Private Sub btnMyApps_Click(sender As Object, e As EventArgs) Handles btnMyApps.Click
        lblDestination.Text = "My Apps"
        Dim frmcurr = New frmMyApps()
        frmcurr.TopLevel = False
        currForm.Close()
        pnlWindow.Controls.Clear()
        currForm = frmcurr
        frmcurr.FormBorderStyle = FormBorderStyle.None
        frmcurr.Dock = DockStyle.Fill
        frmcurr.TopMost = True
        pnlWindow.Controls.Add(frmcurr)
        frmcurr.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        lblDestination.Text = "Settings"
        Dim frmcurr = New frmSettings()
        currForm.Close()
        pnlWindow.Controls.Clear()
        currForm = frmcurr
        frmcurr.TopLevel = False
        frmcurr.FormBorderStyle = FormBorderStyle.None
        frmcurr.Dock = DockStyle.Fill
        frmcurr.TopMost = True
        pnlWindow.Controls.Add(frmcurr)
        frmcurr.Show()
    End Sub

    Private Sub cpbUserProfileImage_Click(sender As Object, e As EventArgs) Handles cpbUserProfileImage.Click
        MyUser.Name = "HanzDerWursti"
        MyUser.Admin = True
        MyUser.Developer = True
        MyUser.Blocked = False
        MyUser.Bio = "Administrator Test Account."
        MyUser.Email = "aro.yt.mail@gmail.com"
        Rest.CreateUser(MyUser)
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        frmWelcome.Close()
        Application.Exit()
    End Sub
End Class
