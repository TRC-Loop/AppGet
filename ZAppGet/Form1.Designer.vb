<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnlTitlebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTimeTtielbar = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.cpbUserProfileImage = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.tmr30SecondRefresher = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSidemenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMyApps = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInstalledApps = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMarked = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.btnSideMenuMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.tmrAnimationSideMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAnimationSideMenuClose = New System.Windows.Forms.Timer(Me.components)
        Me.mttBTNHOME = New MetroFramework.Components.MetroToolTip()
        Me.mttBTNSEARCH = New MetroFramework.Components.MetroToolTip()
        Me.mttBTNINSTALLEDAPPS = New MetroFramework.Components.MetroToolTip()
        Me.mttBTNMYAPPS = New MetroFramework.Components.MetroToolTip()
        Me.mttBTNMARKED = New MetroFramework.Components.MetroToolTip()
        Me.mttBTNSETTINGS = New MetroFramework.Components.MetroToolTip()
        Me.pnlWindow = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlTitlebar.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cpbUserProfileImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidemenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 8
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.HasFormShadow = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'pnlTitlebar
        '
        Me.pnlTitlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.pnlTitlebar.Controls.Add(Me.lblTimeTtielbar)
        Me.pnlTitlebar.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlTitlebar.Controls.Add(Me.cpbUserProfileImage)
        Me.pnlTitlebar.Controls.Add(Me.Guna2ControlBox3)
        Me.pnlTitlebar.Controls.Add(Me.Guna2ControlBox2)
        Me.pnlTitlebar.Controls.Add(Me.Guna2ControlBox1)
        Me.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitlebar.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.pnlTitlebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitlebar.Name = "pnlTitlebar"
        Me.pnlTitlebar.Size = New System.Drawing.Size(1335, 73)
        Me.pnlTitlebar.TabIndex = 0
        '
        'lblTimeTtielbar
        '
        Me.lblTimeTtielbar.AutoSize = True
        Me.lblTimeTtielbar.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeTtielbar.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeTtielbar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblTimeTtielbar.Location = New System.Drawing.Point(92, 54)
        Me.lblTimeTtielbar.Name = "lblTimeTtielbar"
        Me.lblTimeTtielbar.Size = New System.Drawing.Size(79, 18)
        Me.lblTimeTtielbar.TabIndex = 4
        Me.lblTimeTtielbar.Text = "DateTime"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.ZAppGet.My.Resources.Resources.logo_no_background
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-54, 6)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(202, 69)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 6
        Me.Guna2PictureBox1.TabStop = False
        '
        'cpbUserProfileImage
        '
        Me.cpbUserProfileImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cpbUserProfileImage.BackColor = System.Drawing.Color.Transparent
        Me.cpbUserProfileImage.FillColor = System.Drawing.Color.Transparent
        Me.cpbUserProfileImage.Image = Global.ZAppGet.My.Resources.Resources.user_96px
        Me.cpbUserProfileImage.ImageRotate = 0!
        Me.cpbUserProfileImage.Location = New System.Drawing.Point(1089, 0)
        Me.cpbUserProfileImage.Name = "cpbUserProfileImage"
        Me.cpbUserProfileImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cpbUserProfileImage.Size = New System.Drawing.Size(72, 72)
        Me.cpbUserProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cpbUserProfileImage.TabIndex = 5
        Me.cpbUserProfileImage.TabStop = False
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.Animated = True
        Me.Guna2ControlBox3.BorderRadius = 3
        Me.Guna2ControlBox3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(1176, 6)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(48, 32)
        Me.Guna2ControlBox3.TabIndex = 3
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.BorderRadius = 3
        Me.Guna2ControlBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1227, 6)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(48, 32)
        Me.Guna2ControlBox2.TabIndex = 2
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BorderRadius = 3
        Me.Guna2ControlBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2ControlBox1.CustomClick = True
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1278, 6)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(48, 32)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'tmr30SecondRefresher
        '
        Me.tmr30SecondRefresher.Enabled = True
        Me.tmr30SecondRefresher.Interval = 30000
        '
        'pnlSidemenu
        '
        Me.pnlSidemenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.pnlSidemenu.Controls.Add(Me.btnSettings)
        Me.pnlSidemenu.Controls.Add(Me.btnMyApps)
        Me.pnlSidemenu.Controls.Add(Me.btnInstalledApps)
        Me.pnlSidemenu.Controls.Add(Me.btnMarked)
        Me.pnlSidemenu.Controls.Add(Me.btnSearch)
        Me.pnlSidemenu.Controls.Add(Me.btnHome)
        Me.pnlSidemenu.Controls.Add(Me.lblDestination)
        Me.pnlSidemenu.Controls.Add(Me.btnSideMenuMenu)
        Me.pnlSidemenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidemenu.Location = New System.Drawing.Point(0, 73)
        Me.pnlSidemenu.Name = "pnlSidemenu"
        Me.pnlSidemenu.Size = New System.Drawing.Size(250, 530)
        Me.pnlSidemenu.TabIndex = 1
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.Animated = True
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BorderRadius = 5
        Me.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnSettings.Font = New System.Drawing.Font("Lato Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.HoverState.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Image = Global.ZAppGet.My.Resources.Resources.settings_96px
        Me.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSettings.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnSettings.Location = New System.Drawing.Point(3, 482)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnSettings.Size = New System.Drawing.Size(244, 45)
        Me.btnSettings.TabIndex = 10
        Me.btnSettings.Text = "Settings"
        '
        'btnMyApps
        '
        Me.btnMyApps.Animated = True
        Me.btnMyApps.BackColor = System.Drawing.Color.Transparent
        Me.btnMyApps.BorderRadius = 5
        Me.btnMyApps.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMyApps.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMyApps.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMyApps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMyApps.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMyApps.Font = New System.Drawing.Font("Lato Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyApps.ForeColor = System.Drawing.Color.White
        Me.btnMyApps.HoverState.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyApps.Image = Global.ZAppGet.My.Resources.Resources.source_code_96px
        Me.btnMyApps.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMyApps.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnMyApps.Location = New System.Drawing.Point(3, 280)
        Me.btnMyApps.Name = "btnMyApps"
        Me.btnMyApps.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnMyApps.Size = New System.Drawing.Size(244, 45)
        Me.btnMyApps.TabIndex = 9
        Me.btnMyApps.Text = "My Apps"
        '
        'btnInstalledApps
        '
        Me.btnInstalledApps.Animated = True
        Me.btnInstalledApps.BackColor = System.Drawing.Color.Transparent
        Me.btnInstalledApps.BorderRadius = 5
        Me.btnInstalledApps.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInstalledApps.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInstalledApps.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInstalledApps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInstalledApps.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnInstalledApps.Font = New System.Drawing.Font("Lato Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstalledApps.ForeColor = System.Drawing.Color.White
        Me.btnInstalledApps.HoverState.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstalledApps.Image = Global.ZAppGet.My.Resources.Resources.creations_96px
        Me.btnInstalledApps.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnInstalledApps.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnInstalledApps.Location = New System.Drawing.Point(3, 229)
        Me.btnInstalledApps.Name = "btnInstalledApps"
        Me.btnInstalledApps.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnInstalledApps.Size = New System.Drawing.Size(244, 45)
        Me.btnInstalledApps.TabIndex = 8
        Me.btnInstalledApps.Text = "Installed"
        '
        'btnMarked
        '
        Me.btnMarked.Animated = True
        Me.btnMarked.BackColor = System.Drawing.Color.Transparent
        Me.btnMarked.BorderRadius = 5
        Me.btnMarked.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMarked.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMarked.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMarked.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMarked.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMarked.Font = New System.Drawing.Font("Lato Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarked.ForeColor = System.Drawing.Color.White
        Me.btnMarked.HoverState.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarked.Image = Global.ZAppGet.My.Resources.Resources.star_96px
        Me.btnMarked.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMarked.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnMarked.Location = New System.Drawing.Point(3, 178)
        Me.btnMarked.Name = "btnMarked"
        Me.btnMarked.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnMarked.Size = New System.Drawing.Size(244, 45)
        Me.btnMarked.TabIndex = 7
        Me.btnMarked.Text = "Marked"
        '
        'btnSearch
        '
        Me.btnSearch.Animated = True
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BorderRadius = 5
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Lato Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.HoverState.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.ZAppGet.My.Resources.Resources.search_96px
        Me.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSearch.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnSearch.Location = New System.Drawing.Point(3, 127)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnSearch.Size = New System.Drawing.Size(244, 45)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        '
        'btnHome
        '
        Me.btnHome.Animated = True
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BorderRadius = 5
        Me.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnHome.Font = New System.Drawing.Font("Lato Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.HoverState.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Image = Global.ZAppGet.My.Resources.Resources.home_page_96px
        Me.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnHome.Location = New System.Drawing.Point(3, 76)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnHome.Size = New System.Drawing.Size(244, 45)
        Me.btnHome.TabIndex = 2
        Me.btnHome.Text = "Home"
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Font = New System.Drawing.Font("Noto Sans Cond", 27.75!, System.Drawing.FontStyle.Bold)
        Me.lblDestination.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblDestination.Location = New System.Drawing.Point(4, 6)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(114, 51)
        Me.lblDestination.TabIndex = 5
        Me.lblDestination.Text = "Home"
        '
        'btnSideMenuMenu
        '
        Me.btnSideMenuMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSideMenuMenu.Animated = True
        Me.btnSideMenuMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnSideMenuMenu.BorderRadius = 3
        Me.btnSideMenuMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSideMenuMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSideMenuMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSideMenuMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSideMenuMenu.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSideMenuMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSideMenuMenu.ForeColor = System.Drawing.Color.White
        Me.btnSideMenuMenu.Image = Global.ZAppGet.My.Resources.Resources.menu_96px
        Me.btnSideMenuMenu.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnSideMenuMenu.Location = New System.Drawing.Point(183, 6)
        Me.btnSideMenuMenu.Name = "btnSideMenuMenu"
        Me.btnSideMenuMenu.Size = New System.Drawing.Size(64, 64)
        Me.btnSideMenuMenu.TabIndex = 0
        Me.btnSideMenuMenu.UseTransparentBackground = True
        '
        'tmrAnimationSideMenu
        '
        Me.tmrAnimationSideMenu.Interval = 10
        '
        'tmrAnimationSideMenuClose
        '
        Me.tmrAnimationSideMenuClose.Interval = 10
        '
        'mttBTNHOME
        '
        Me.mttBTNHOME.AutoPopDelay = 10000
        Me.mttBTNHOME.InitialDelay = 500
        Me.mttBTNHOME.ReshowDelay = 100
        Me.mttBTNHOME.Style = MetroFramework.MetroColorStyle.Silver
        Me.mttBTNHOME.StyleManager = Nothing
        Me.mttBTNHOME.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'mttBTNSEARCH
        '
        Me.mttBTNSEARCH.AutoPopDelay = 10000
        Me.mttBTNSEARCH.InitialDelay = 500
        Me.mttBTNSEARCH.ReshowDelay = 100
        Me.mttBTNSEARCH.Style = MetroFramework.MetroColorStyle.Silver
        Me.mttBTNSEARCH.StyleManager = Nothing
        Me.mttBTNSEARCH.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'mttBTNINSTALLEDAPPS
        '
        Me.mttBTNINSTALLEDAPPS.AutoPopDelay = 10000
        Me.mttBTNINSTALLEDAPPS.InitialDelay = 500
        Me.mttBTNINSTALLEDAPPS.ReshowDelay = 100
        Me.mttBTNINSTALLEDAPPS.Style = MetroFramework.MetroColorStyle.Silver
        Me.mttBTNINSTALLEDAPPS.StyleManager = Nothing
        Me.mttBTNINSTALLEDAPPS.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'mttBTNMYAPPS
        '
        Me.mttBTNMYAPPS.AutoPopDelay = 10000
        Me.mttBTNMYAPPS.InitialDelay = 500
        Me.mttBTNMYAPPS.ReshowDelay = 100
        Me.mttBTNMYAPPS.Style = MetroFramework.MetroColorStyle.Silver
        Me.mttBTNMYAPPS.StyleManager = Nothing
        Me.mttBTNMYAPPS.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'mttBTNMARKED
        '
        Me.mttBTNMARKED.AutoPopDelay = 10000
        Me.mttBTNMARKED.InitialDelay = 500
        Me.mttBTNMARKED.ReshowDelay = 100
        Me.mttBTNMARKED.Style = MetroFramework.MetroColorStyle.Silver
        Me.mttBTNMARKED.StyleManager = Nothing
        Me.mttBTNMARKED.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'mttBTNSETTINGS
        '
        Me.mttBTNSETTINGS.AutoPopDelay = 10000
        Me.mttBTNSETTINGS.InitialDelay = 500
        Me.mttBTNSETTINGS.ReshowDelay = 100
        Me.mttBTNSETTINGS.Style = MetroFramework.MetroColorStyle.Silver
        Me.mttBTNSETTINGS.StyleManager = Nothing
        Me.mttBTNSETTINGS.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'pnlWindow
        '
        Me.pnlWindow.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWindow.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlWindow.Location = New System.Drawing.Point(250, 73)
        Me.pnlWindow.Name = "pnlWindow"
        Me.pnlWindow.Size = New System.Drawing.Size(1085, 530)
        Me.pnlWindow.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 603)
        Me.Controls.Add(Me.pnlWindow)
        Me.Controls.Add(Me.pnlSidemenu)
        Me.Controls.Add(Me.pnlTitlebar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppGet"
        Me.pnlTitlebar.ResumeLayout(False)
        Me.pnlTitlebar.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cpbUserProfileImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidemenu.ResumeLayout(False)
        Me.pnlSidemenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTitlebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblTimeTtielbar As Label
    Friend WithEvents tmr30SecondRefresher As Timer
    Friend WithEvents pnlSidemenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSideMenuMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tmrAnimationSideMenu As Timer
    Friend WithEvents tmrAnimationSideMenuClose As Timer
    Friend WithEvents lblDestination As Label
    Friend WithEvents cpbUserProfileImage As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMarked As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnInstalledApps As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mttBTNHOME As MetroFramework.Components.MetroToolTip
    Friend WithEvents mttBTNSEARCH As MetroFramework.Components.MetroToolTip
    Friend WithEvents mttBTNINSTALLEDAPPS As MetroFramework.Components.MetroToolTip
    Friend WithEvents mttBTNMYAPPS As MetroFramework.Components.MetroToolTip
    Friend WithEvents btnMyApps As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mttBTNMARKED As MetroFramework.Components.MetroToolTip
    Friend WithEvents btnSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mttBTNSETTINGS As MetroFramework.Components.MetroToolTip
    Friend WithEvents pnlWindow As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
