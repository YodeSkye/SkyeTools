Partial Friend Class Settings
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        BtnClose = New Button()
        BtnSaveSettings = New Button()
        BtnRestoreSettings = New Button()
        radioButton16 = New RadioButton()
        radioButton17 = New RadioButton()
        radioButton18 = New RadioButton()
        radioButton19 = New RadioButton()
        radioButton20 = New RadioButton()
        radioButton21 = New RadioButton()
        radioButton22 = New RadioButton()
        radioButton23 = New RadioButton()
        radioButton24 = New RadioButton()
        radioButton25 = New RadioButton()
        radioButton26 = New RadioButton()
        radioButton27 = New RadioButton()
        radioButton28 = New RadioButton()
        radioButton29 = New RadioButton()
        radioButton30 = New RadioButton()
        radioButton31 = New RadioButton()
        radioButton32 = New RadioButton()
        BtnErrorTest = New Button()
        BtnHelp = New Button()
        BtnLog = New Button()
        PanelApp = New Panel()
        LblTheme = New Skye.UI.Label()
        CoBoxTheme = New Skye.UI.ComboBox()
        LblLoadOnOSStartupPath = New Label()
        BtnLoadOnOSStartupPath = New Button()
        TxtBoxLoadOnOSStartupArgs = New TextBox()
        ChkBoxThemeAuto = New CheckBox()
        ChkBoxLoadOnOSStartup = New CheckBox()
        PanelWST = New Panel()
        ChkBoxWSTShowSleep = New CheckBox()
        ChkBoxWSTSSToolEnabled = New CheckBox()
        ChkBoxWSTShowLog = New CheckBox()
        ChkBoxWSTShowReStart = New CheckBox()
        ChkBoxWSTShowShutDown = New CheckBox()
        ChkBoxWSTShowHibernate = New CheckBox()
        ChkBoxWSTShowLogOff = New CheckBox()
        ChkBoxWSTShowLockWorkSpace = New CheckBox()
        ChkBoxWSTShowAC = New CheckBox()
        ChkBoxWSTShowHelp = New CheckBox()
        ChkBoxWSTShowClock = New CheckBox()
        ChkBoxWSTShowWLTray = New CheckBox()
        ChkBoxWSTShowWLMenu = New CheckBox()
        ChkBoxWSTEnabled = New CheckBox()
        PanelSS = New Panel()
        BtnSSEnabled = New RadioButton()
        CoBoxSSStartUp = New ComboBox()
        LblSSStartupMode = New Label()
        ChkBoxSSShowIcon = New CheckBox()
        ChkBoxSSEnableOnActivate = New CheckBox()
        ChkBoxSSShowActivate = New CheckBox()
        ChkBoxSSShowEnabled = New CheckBox()
        PanelActions = New Panel()
        PanelPageSelector = New Panel()
        LVPageSelector = New Skye.UI.ListViewEX()
        ILPageSelector = New ImageList(components)
        TipInfoEX = New Skye.UI.ToolTipEX(components)
        PanelAC = New Panel()
        PanelWL = New Panel()
        PanelHC = New Panel()
        PanelHK = New Panel()
        PanelApp.SuspendLayout()
        PanelWST.SuspendLayout()
        PanelSS.SuspendLayout()
        PanelActions.SuspendLayout()
        PanelPageSelector.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnClose.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnClose.Image = My.Resources.Resources.ImageOK
        TipInfoEX.SetImage(BtnClose, Nothing)
        BtnClose.Location = New Point(426, 16)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(64, 64)
        BtnClose.TabIndex = 0
        TipInfoEX.SetText(BtnClose, "Close Window")
        BtnClose.TextAlign = ContentAlignment.MiddleRight
        BtnClose.UseVisualStyleBackColor = True
        ' 
        ' BtnSaveSettings
        ' 
        BtnSaveSettings.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnSaveSettings.Image = My.Resources.Resources.ImageSave32
        TipInfoEX.SetImage(BtnSaveSettings, My.Resources.Resources.ImageSave16)
        BtnSaveSettings.Location = New Point(12, 24)
        BtnSaveSettings.Name = "BtnSaveSettings"
        BtnSaveSettings.Size = New Size(48, 48)
        BtnSaveSettings.TabIndex = 100
        TipInfoEX.SetText(BtnSaveSettings, "Save All Settings")
        BtnSaveSettings.TextAlign = ContentAlignment.BottomRight
        BtnSaveSettings.UseVisualStyleBackColor = True
        ' 
        ' BtnRestoreSettings
        ' 
        BtnRestoreSettings.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnRestoreSettings.Image = My.Resources.Resources.ImageUndo32
        TipInfoEX.SetImage(BtnRestoreSettings, My.Resources.Resources.ImageUndo16)
        BtnRestoreSettings.Location = New Point(73, 24)
        BtnRestoreSettings.Name = "BtnRestoreSettings"
        BtnRestoreSettings.Size = New Size(48, 48)
        BtnRestoreSettings.TabIndex = 101
        TipInfoEX.SetText(BtnRestoreSettings, "Restore All Settings")
        BtnRestoreSettings.TextAlign = ContentAlignment.BottomRight
        BtnRestoreSettings.UseVisualStyleBackColor = True
        ' 
        ' radioButton16
        ' 
        radioButton16.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton16, Nothing)
        radioButton16.Location = New Point(0, 42)
        radioButton16.Name = "radioButton16"
        radioButton16.Size = New Size(21, 24)
        radioButton16.TabIndex = 16
        TipInfoEX.SetText(radioButton16, Nothing)
        radioButton16.UseVisualStyleBackColor = True
        ' 
        ' radioButton17
        ' 
        radioButton17.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton17, Nothing)
        radioButton17.Location = New Point(0, 135)
        radioButton17.Name = "radioButton17"
        radioButton17.Size = New Size(21, 24)
        radioButton17.TabIndex = 13
        TipInfoEX.SetText(radioButton17, Nothing)
        radioButton17.UseVisualStyleBackColor = True
        ' 
        ' radioButton18
        ' 
        radioButton18.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton18, Nothing)
        radioButton18.Location = New Point(140, 42)
        radioButton18.Name = "radioButton18"
        radioButton18.Size = New Size(21, 24)
        radioButton18.TabIndex = 6
        TipInfoEX.SetText(radioButton18, Nothing)
        radioButton18.UseVisualStyleBackColor = True
        ' 
        ' radioButton19
        ' 
        radioButton19.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton19, Nothing)
        radioButton19.Location = New Point(140, 104)
        radioButton19.Name = "radioButton19"
        radioButton19.Size = New Size(21, 24)
        radioButton19.TabIndex = 8
        TipInfoEX.SetText(radioButton19, Nothing)
        radioButton19.UseVisualStyleBackColor = True
        ' 
        ' radioButton20
        ' 
        radioButton20.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton20, Nothing)
        radioButton20.Location = New Point(105, 135)
        radioButton20.Name = "radioButton20"
        radioButton20.Size = New Size(21, 24)
        radioButton20.TabIndex = 10
        TipInfoEX.SetText(radioButton20, Nothing)
        radioButton20.UseVisualStyleBackColor = True
        ' 
        ' radioButton21
        ' 
        radioButton21.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton21, Nothing)
        radioButton21.Location = New Point(35, 135)
        radioButton21.Name = "radioButton21"
        radioButton21.Size = New Size(21, 24)
        radioButton21.TabIndex = 12
        TipInfoEX.SetText(radioButton21, Nothing)
        radioButton21.UseVisualStyleBackColor = True
        ' 
        ' radioButton22
        ' 
        radioButton22.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton22, Nothing)
        radioButton22.Location = New Point(140, 135)
        radioButton22.Name = "radioButton22"
        radioButton22.Size = New Size(21, 24)
        radioButton22.TabIndex = 8
        TipInfoEX.SetText(radioButton22, Nothing)
        radioButton22.UseVisualStyleBackColor = True
        ' 
        ' radioButton23
        ' 
        radioButton23.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton23, Nothing)
        radioButton23.Location = New Point(0, 104)
        radioButton23.Name = "radioButton23"
        radioButton23.Size = New Size(21, 24)
        radioButton23.TabIndex = 14
        TipInfoEX.SetText(radioButton23, Nothing)
        radioButton23.UseVisualStyleBackColor = True
        ' 
        ' radioButton24
        ' 
        radioButton24.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton24, Nothing)
        radioButton24.Location = New Point(70, 135)
        radioButton24.Name = "radioButton24"
        radioButton24.Size = New Size(21, 24)
        radioButton24.TabIndex = 11
        TipInfoEX.SetText(radioButton24, Nothing)
        radioButton24.UseVisualStyleBackColor = True
        ' 
        ' radioButton25
        ' 
        radioButton25.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton25, Nothing)
        radioButton25.Location = New Point(0, 73)
        radioButton25.Name = "radioButton25"
        radioButton25.Size = New Size(21, 24)
        radioButton25.TabIndex = 15
        TipInfoEX.SetText(radioButton25, Nothing)
        radioButton25.UseVisualStyleBackColor = True
        ' 
        ' radioButton26
        ' 
        radioButton26.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton26, Nothing)
        radioButton26.Location = New Point(35, 11)
        radioButton26.Name = "radioButton26"
        radioButton26.Size = New Size(21, 24)
        radioButton26.TabIndex = 2
        TipInfoEX.SetText(radioButton26, Nothing)
        radioButton26.UseVisualStyleBackColor = True
        ' 
        ' radioButton27
        ' 
        radioButton27.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton27, Nothing)
        radioButton27.Location = New Point(70, 11)
        radioButton27.Name = "radioButton27"
        radioButton27.Size = New Size(21, 24)
        radioButton27.TabIndex = 3
        TipInfoEX.SetText(radioButton27, Nothing)
        radioButton27.UseVisualStyleBackColor = True
        ' 
        ' radioButton28
        ' 
        radioButton28.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton28, Nothing)
        radioButton28.Location = New Point(140, 11)
        radioButton28.Name = "radioButton28"
        radioButton28.Size = New Size(21, 24)
        radioButton28.TabIndex = 5
        TipInfoEX.SetText(radioButton28, Nothing)
        radioButton28.UseVisualStyleBackColor = True
        ' 
        ' radioButton29
        ' 
        radioButton29.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton29, Nothing)
        radioButton29.Location = New Point(105, 11)
        radioButton29.Name = "radioButton29"
        radioButton29.Size = New Size(21, 24)
        radioButton29.TabIndex = 4
        TipInfoEX.SetText(radioButton29, Nothing)
        radioButton29.UseVisualStyleBackColor = True
        ' 
        ' radioButton30
        ' 
        radioButton30.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton30, Nothing)
        radioButton30.Location = New Point(140, 73)
        radioButton30.Name = "radioButton30"
        radioButton30.Size = New Size(21, 24)
        radioButton30.TabIndex = 7
        TipInfoEX.SetText(radioButton30, Nothing)
        radioButton30.UseVisualStyleBackColor = True
        ' 
        ' radioButton31
        ' 
        radioButton31.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(radioButton31, Nothing)
        radioButton31.Location = New Point(0, 11)
        radioButton31.Name = "radioButton31"
        radioButton31.Size = New Size(21, 24)
        radioButton31.TabIndex = 1
        TipInfoEX.SetText(radioButton31, Nothing)
        radioButton31.UseVisualStyleBackColor = True
        ' 
        ' radioButton32
        ' 
        radioButton32.CheckAlign = ContentAlignment.MiddleCenter
        radioButton32.Cursor = Cursors.Hand
        TipInfoEX.SetImage(radioButton32, Nothing)
        radioButton32.Location = New Point(57, 59)
        radioButton32.Name = "radioButton32"
        radioButton32.Size = New Size(48, 51)
        radioButton32.TabIndex = 0
        TipInfoEX.SetText(radioButton32, Nothing)
        radioButton32.Text = "Manual"
        radioButton32.TextAlign = ContentAlignment.TopCenter
        radioButton32.UseVisualStyleBackColor = True
        ' 
        ' BtnErrorTest
        ' 
        BtnErrorTest.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnErrorTest.FlatAppearance.BorderColor = SystemColors.ControlDark
        BtnErrorTest.FlatAppearance.BorderSize = 0
        BtnErrorTest.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnErrorTest.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnErrorTest.Image = My.Resources.Resources.ImageError32
        TipInfoEX.SetImage(BtnErrorTest, My.Resources.Resources.ImageError16)
        BtnErrorTest.Location = New Point(241, 24)
        BtnErrorTest.Name = "BtnErrorTest"
        BtnErrorTest.Size = New Size(48, 48)
        BtnErrorTest.TabIndex = 0
        BtnErrorTest.TabStop = False
        TipInfoEX.SetText(BtnErrorTest, "LeftClick = Test Error" & vbCrLf & "RightClick = Cause Exception")
        BtnErrorTest.Visible = False
        ' 
        ' BtnHelp
        ' 
        BtnHelp.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnHelp.Image = My.Resources.Resources.imageInfo32
        TipInfoEX.SetImage(BtnHelp, My.Resources.Resources.ImageInfo16)
        BtnHelp.Location = New Point(796, 24)
        BtnHelp.Name = "BtnHelp"
        BtnHelp.Size = New Size(48, 48)
        BtnHelp.TabIndex = 105
        TipInfoEX.SetText(BtnHelp, "Show Help & About")
        BtnHelp.TextAlign = ContentAlignment.BottomRight
        BtnHelp.UseVisualStyleBackColor = True
        ' 
        ' BtnLog
        ' 
        BtnLog.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnLog.Image = My.Resources.Resources.ImageLog32
        TipInfoEX.SetImage(BtnLog, My.Resources.Resources.imageLog)
        BtnLog.Location = New Point(857, 24)
        BtnLog.Name = "BtnLog"
        BtnLog.Size = New Size(48, 48)
        BtnLog.TabIndex = 106
        TipInfoEX.SetText(BtnLog, "Show Log")
        BtnLog.TextAlign = ContentAlignment.BottomRight
        BtnLog.UseVisualStyleBackColor = True
        ' 
        ' PanelApp
        ' 
        PanelApp.Controls.Add(LblTheme)
        PanelApp.Controls.Add(CoBoxTheme)
        PanelApp.Controls.Add(LblLoadOnOSStartupPath)
        PanelApp.Controls.Add(BtnLoadOnOSStartupPath)
        PanelApp.Controls.Add(TxtBoxLoadOnOSStartupArgs)
        PanelApp.Controls.Add(ChkBoxThemeAuto)
        PanelApp.Controls.Add(ChkBoxLoadOnOSStartup)
        PanelApp.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelApp, Nothing)
        PanelApp.Location = New Point(187, 0)
        PanelApp.Name = "PanelApp"
        PanelApp.Size = New Size(730, 534)
        PanelApp.TabIndex = 107
        TipInfoEX.SetText(PanelApp, Nothing)
        ' 
        ' LblTheme
        ' 
        LblTheme.Font = New Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        TipInfoEX.SetImage(LblTheme, Nothing)
        LblTheme.Location = New Point(282, 70)
        LblTheme.Name = "LblTheme"
        LblTheme.Size = New Size(166, 23)
        LblTheme.TabIndex = 150
        LblTheme.Text = "Theme"
        TipInfoEX.SetText(LblTheme, Nothing)
        LblTheme.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CoBoxTheme
        ' 
        CoBoxTheme.FormattingEnabled = True
        TipInfoEX.SetImage(CoBoxTheme, Nothing)
        CoBoxTheme.Location = New Point(282, 118)
        CoBoxTheme.Name = "CoBoxTheme"
        CoBoxTheme.Size = New Size(166, 30)
        CoBoxTheme.TabIndex = 110
        TipInfoEX.SetText(CoBoxTheme, Nothing)
        ' 
        ' LblLoadOnOSStartupPath
        ' 
        LblLoadOnOSStartupPath.BorderStyle = BorderStyle.FixedSingle
        TipInfoEX.SetImage(LblLoadOnOSStartupPath, Nothing)
        LblLoadOnOSStartupPath.Location = New Point(255, 263)
        LblLoadOnOSStartupPath.Name = "LblLoadOnOSStartupPath"
        LblLoadOnOSStartupPath.Size = New Size(214, 27)
        LblLoadOnOSStartupPath.TabIndex = 210
        LblLoadOnOSStartupPath.Text = "Sample Text"
        TipInfoEX.SetText(LblLoadOnOSStartupPath, "Path")
        LblLoadOnOSStartupPath.TextAlign = ContentAlignment.TopRight
        ' 
        ' BtnLoadOnOSStartupPath
        ' 
        BtnLoadOnOSStartupPath.FlatAppearance.BorderSize = 0
        BtnLoadOnOSStartupPath.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnLoadOnOSStartupPath.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnLoadOnOSStartupPath.Image = My.Resources.Resources.ImageFolder
        TipInfoEX.SetImage(BtnLoadOnOSStartupPath, Nothing)
        BtnLoadOnOSStartupPath.Location = New Point(223, 262)
        BtnLoadOnOSStartupPath.Name = "BtnLoadOnOSStartupPath"
        BtnLoadOnOSStartupPath.Size = New Size(32, 29)
        BtnLoadOnOSStartupPath.TabIndex = 205
        TipInfoEX.SetText(BtnLoadOnOSStartupPath, "Select An Application")
        BtnLoadOnOSStartupPath.TextAlign = ContentAlignment.MiddleLeft
        BtnLoadOnOSStartupPath.UseVisualStyleBackColor = True
        ' 
        ' TxtBoxLoadOnOSStartupArgs
        ' 
        TipInfoEX.SetImage(TxtBoxLoadOnOSStartupArgs, Nothing)
        TxtBoxLoadOnOSStartupArgs.Location = New Point(255, 290)
        TxtBoxLoadOnOSStartupArgs.Name = "TxtBoxLoadOnOSStartupArgs"
        TxtBoxLoadOnOSStartupArgs.Size = New Size(215, 29)
        TxtBoxLoadOnOSStartupArgs.TabIndex = 220
        TipInfoEX.SetText(TxtBoxLoadOnOSStartupArgs, "Args")
        TxtBoxLoadOnOSStartupArgs.Text = "Sample Text"
        TxtBoxLoadOnOSStartupArgs.WordWrap = False
        ' 
        ' ChkBoxThemeAuto
        ' 
        ChkBoxThemeAuto.AutoSize = True
        TipInfoEX.SetImage(ChkBoxThemeAuto, Nothing)
        ChkBoxThemeAuto.Location = New Point(282, 96)
        ChkBoxThemeAuto.Name = "ChkBoxThemeAuto"
        ChkBoxThemeAuto.Size = New Size(161, 25)
        ChkBoxThemeAuto.TabIndex = 100
        TipInfoEX.SetText(ChkBoxThemeAuto, Nothing)
        ChkBoxThemeAuto.Text = "Use System Theme"
        ChkBoxThemeAuto.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxLoadOnOSStartup
        ' 
        TipInfoEX.SetImage(ChkBoxLoadOnOSStartup, Nothing)
        ChkBoxLoadOnOSStartup.Location = New Point(236, 238)
        ChkBoxLoadOnOSStartup.Name = "ChkBoxLoadOnOSStartup"
        ChkBoxLoadOnOSStartup.RightToLeft = RightToLeft.Yes
        ChkBoxLoadOnOSStartup.Size = New Size(234, 29)
        ChkBoxLoadOnOSStartup.TabIndex = 200
        TipInfoEX.SetText(ChkBoxLoadOnOSStartup, Nothing)
        ChkBoxLoadOnOSStartup.Text = "Load On Windows StartUp"
        ChkBoxLoadOnOSStartup.UseVisualStyleBackColor = True
        ' 
        ' PanelWST
        ' 
        PanelWST.Controls.Add(ChkBoxWSTShowSleep)
        PanelWST.Controls.Add(ChkBoxWSTSSToolEnabled)
        PanelWST.Controls.Add(ChkBoxWSTShowLog)
        PanelWST.Controls.Add(ChkBoxWSTShowReStart)
        PanelWST.Controls.Add(ChkBoxWSTShowShutDown)
        PanelWST.Controls.Add(ChkBoxWSTShowHibernate)
        PanelWST.Controls.Add(ChkBoxWSTShowLogOff)
        PanelWST.Controls.Add(ChkBoxWSTShowLockWorkSpace)
        PanelWST.Controls.Add(ChkBoxWSTShowAC)
        PanelWST.Controls.Add(ChkBoxWSTShowHelp)
        PanelWST.Controls.Add(ChkBoxWSTShowClock)
        PanelWST.Controls.Add(ChkBoxWSTShowWLTray)
        PanelWST.Controls.Add(ChkBoxWSTShowWLMenu)
        PanelWST.Controls.Add(ChkBoxWSTEnabled)
        PanelWST.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelWST, Nothing)
        PanelWST.Location = New Point(187, 0)
        PanelWST.Name = "PanelWST"
        PanelWST.Size = New Size(730, 534)
        PanelWST.TabIndex = 108
        TipInfoEX.SetText(PanelWST, Nothing)
        ' 
        ' ChkBoxWSTShowSleep
        ' 
        ChkBoxWSTShowSleep.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowSleep, Nothing)
        ChkBoxWSTShowSleep.Location = New Point(404, 126)
        ChkBoxWSTShowSleep.Name = "ChkBoxWSTShowSleep"
        ChkBoxWSTShowSleep.Size = New Size(118, 25)
        ChkBoxWSTShowSleep.TabIndex = 130
        TipInfoEX.SetText(ChkBoxWSTShowSleep, Nothing)
        ChkBoxWSTShowSleep.Text = "Show 'Sleep'"
        ChkBoxWSTShowSleep.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTSSToolEnabled
        ' 
        ChkBoxWSTSSToolEnabled.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTSSToolEnabled, Nothing)
        ChkBoxWSTSSToolEnabled.Location = New Point(46, 79)
        ChkBoxWSTSSToolEnabled.Name = "ChkBoxWSTSSToolEnabled"
        ChkBoxWSTSSToolEnabled.Size = New Size(119, 25)
        ChkBoxWSTSSToolEnabled.TabIndex = 20
        TipInfoEX.SetText(ChkBoxWSTSSToolEnabled, Nothing)
        ChkBoxWSTSSToolEnabled.Text = "Screen Saver"
        ChkBoxWSTSSToolEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTShowLog
        ' 
        ChkBoxWSTShowLog.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowLog, Nothing)
        ChkBoxWSTShowLog.Location = New Point(404, 265)
        ChkBoxWSTShowLog.Name = "ChkBoxWSTShowLog"
        ChkBoxWSTShowLog.Size = New Size(106, 25)
        ChkBoxWSTShowLog.TabIndex = 170
        TipInfoEX.SetText(ChkBoxWSTShowLog, Nothing)
        ChkBoxWSTShowLog.Text = "Show 'Log'"
        ChkBoxWSTShowLog.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTShowReStart
        ' 
        ChkBoxWSTShowReStart.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowReStart, Nothing)
        ChkBoxWSTShowReStart.Location = New Point(404, 95)
        ChkBoxWSTShowReStart.Name = "ChkBoxWSTShowReStart"
        ChkBoxWSTShowReStart.Size = New Size(130, 25)
        ChkBoxWSTShowReStart.TabIndex = 120
        TipInfoEX.SetText(ChkBoxWSTShowReStart, Nothing)
        ChkBoxWSTShowReStart.Text = "Show 'ReStart'"
        ChkBoxWSTShowReStart.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTShowShutDown
        ' 
        ChkBoxWSTShowShutDown.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowShutDown, Nothing)
        ChkBoxWSTShowShutDown.Location = New Point(404, 188)
        ChkBoxWSTShowShutDown.Name = "ChkBoxWSTShowShutDown"
        ChkBoxWSTShowShutDown.Size = New Size(157, 25)
        ChkBoxWSTShowShutDown.TabIndex = 150
        TipInfoEX.SetText(ChkBoxWSTShowShutDown, Nothing)
        ChkBoxWSTShowShutDown.Text = "Show 'Shut Down'"
        ChkBoxWSTShowShutDown.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTShowHibernate
        ' 
        ChkBoxWSTShowHibernate.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowHibernate, Nothing)
        ChkBoxWSTShowHibernate.Location = New Point(404, 157)
        ChkBoxWSTShowHibernate.Name = "ChkBoxWSTShowHibernate"
        ChkBoxWSTShowHibernate.Size = New Size(148, 25)
        ChkBoxWSTShowHibernate.TabIndex = 140
        TipInfoEX.SetText(ChkBoxWSTShowHibernate, Nothing)
        ChkBoxWSTShowHibernate.Text = "Show 'Hibernate'"
        ChkBoxWSTShowHibernate.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTShowLogOff
        ' 
        ChkBoxWSTShowLogOff.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowLogOff, Nothing)
        ChkBoxWSTShowLogOff.Location = New Point(404, 64)
        ChkBoxWSTShowLogOff.Name = "ChkBoxWSTShowLogOff"
        ChkBoxWSTShowLogOff.Size = New Size(132, 25)
        ChkBoxWSTShowLogOff.TabIndex = 110
        TipInfoEX.SetText(ChkBoxWSTShowLogOff, Nothing)
        ChkBoxWSTShowLogOff.Text = "Show 'Log Off'"
        ChkBoxWSTShowLogOff.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTShowLockWorkSpace
        ' 
        ChkBoxWSTShowLockWorkSpace.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowLockWorkSpace, Nothing)
        ChkBoxWSTShowLockWorkSpace.Location = New Point(404, 33)
        ChkBoxWSTShowLockWorkSpace.Name = "ChkBoxWSTShowLockWorkSpace"
        ChkBoxWSTShowLockWorkSpace.Size = New Size(194, 25)
        ChkBoxWSTShowLockWorkSpace.TabIndex = 100
        TipInfoEX.SetText(ChkBoxWSTShowLockWorkSpace, Nothing)
        ChkBoxWSTShowLockWorkSpace.Text = "Show 'Lock WorkSpace'"
        ChkBoxWSTShowLockWorkSpace.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTShowAC
        ' 
        ChkBoxWSTShowAC.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowAC, Nothing)
        ChkBoxWSTShowAC.Location = New Point(46, 110)
        ChkBoxWSTShowAC.Name = "ChkBoxWSTShowAC"
        ChkBoxWSTShowAC.Size = New Size(181, 25)
        ChkBoxWSTShowAC.TabIndex = 30
        TipInfoEX.SetText(ChkBoxWSTShowAC, Nothing)
        ChkBoxWSTShowAC.Text = "Show 'Alarm / Chime'"
        ChkBoxWSTShowAC.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTShowHelp
        ' 
        ChkBoxWSTShowHelp.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowHelp, Nothing)
        ChkBoxWSTShowHelp.Location = New Point(404, 234)
        ChkBoxWSTShowHelp.Name = "ChkBoxWSTShowHelp"
        ChkBoxWSTShowHelp.Size = New Size(112, 25)
        ChkBoxWSTShowHelp.TabIndex = 160
        TipInfoEX.SetText(ChkBoxWSTShowHelp, Nothing)
        ChkBoxWSTShowHelp.Text = "Show 'Help'"
        ChkBoxWSTShowHelp.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTShowClock
        ' 
        ChkBoxWSTShowClock.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowClock, Nothing)
        ChkBoxWSTShowClock.Location = New Point(46, 141)
        ChkBoxWSTShowClock.Name = "ChkBoxWSTShowClock"
        ChkBoxWSTShowClock.Size = New Size(110, 25)
        ChkBoxWSTShowClock.TabIndex = 40
        TipInfoEX.SetText(ChkBoxWSTShowClock, Nothing)
        ChkBoxWSTShowClock.Text = "Show Clock"
        ChkBoxWSTShowClock.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTShowWLTray
        ' 
        ChkBoxWSTShowWLTray.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowWLTray, Nothing)
        ChkBoxWSTShowWLTray.Location = New Point(46, 219)
        ChkBoxWSTShowWLTray.Name = "ChkBoxWSTShowWLTray"
        ChkBoxWSTShowWLTray.Size = New Size(202, 25)
        ChkBoxWSTShowWLTray.TabIndex = 60
        TipInfoEX.SetText(ChkBoxWSTShowWLTray, Nothing)
        ChkBoxWSTShowWLTray.Text = "Show WinLinks Tray Icon"
        ChkBoxWSTShowWLTray.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTShowWLMenu
        ' 
        ChkBoxWSTShowWLMenu.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTShowWLMenu, Nothing)
        ChkBoxWSTShowWLMenu.Location = New Point(46, 188)
        ChkBoxWSTShowWLMenu.Name = "ChkBoxWSTShowWLMenu"
        ChkBoxWSTShowWLMenu.Size = New Size(144, 25)
        ChkBoxWSTShowWLMenu.TabIndex = 50
        TipInfoEX.SetText(ChkBoxWSTShowWLMenu, Nothing)
        ChkBoxWSTShowWLMenu.Text = "Show 'WinLinks'"
        ChkBoxWSTShowWLMenu.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWSTEnabled
        ' 
        ChkBoxWSTEnabled.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWSTEnabled, Nothing)
        ChkBoxWSTEnabled.Location = New Point(46, 33)
        ChkBoxWSTEnabled.Name = "ChkBoxWSTEnabled"
        ChkBoxWSTEnabled.Size = New Size(134, 25)
        ChkBoxWSTEnabled.TabIndex = 10
        TipInfoEX.SetText(ChkBoxWSTEnabled, Nothing)
        ChkBoxWSTEnabled.Text = "Show Tray Icon"
        ChkBoxWSTEnabled.UseVisualStyleBackColor = True
        ' 
        ' PanelSS
        ' 
        PanelSS.Controls.Add(BtnSSEnabled)
        PanelSS.Controls.Add(CoBoxSSStartUp)
        PanelSS.Controls.Add(LblSSStartupMode)
        PanelSS.Controls.Add(ChkBoxSSShowIcon)
        PanelSS.Controls.Add(ChkBoxSSEnableOnActivate)
        PanelSS.Controls.Add(ChkBoxSSShowActivate)
        PanelSS.Controls.Add(ChkBoxSSShowEnabled)
        PanelSS.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelSS, Nothing)
        PanelSS.Location = New Point(187, 0)
        PanelSS.Name = "PanelSS"
        PanelSS.Size = New Size(730, 534)
        PanelSS.TabIndex = 109
        TipInfoEX.SetText(PanelSS, Nothing)
        ' 
        ' BtnSSEnabled
        ' 
        BtnSSEnabled.Appearance = Appearance.Button
        TipInfoEX.SetImage(BtnSSEnabled, Nothing)
        BtnSSEnabled.Location = New Point(19, 18)
        BtnSSEnabled.Name = "BtnSSEnabled"
        BtnSSEnabled.Size = New Size(32, 32)
        BtnSSEnabled.TabIndex = 10
        BtnSSEnabled.TabStop = True
        TipInfoEX.SetText(BtnSSEnabled, "SS")
        BtnSSEnabled.UseVisualStyleBackColor = True
        ' 
        ' CoBoxSSStartUp
        ' 
        CoBoxSSStartUp.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CoBoxSSStartUp.DropDownStyle = ComboBoxStyle.DropDownList
        CoBoxSSStartUp.FormattingEnabled = True
        TipInfoEX.SetImage(CoBoxSSStartUp, Nothing)
        CoBoxSSStartUp.Location = New Point(264, 261)
        CoBoxSSStartUp.Name = "CoBoxSSStartUp"
        CoBoxSSStartUp.RightToLeft = RightToLeft.No
        CoBoxSSStartUp.Size = New Size(170, 29)
        CoBoxSSStartUp.TabIndex = 140
        TipInfoEX.SetText(CoBoxSSStartUp, Nothing)
        ' 
        ' LblSSStartupMode
        ' 
        LblSSStartupMode.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TipInfoEX.SetImage(LblSSStartupMode, Nothing)
        LblSSStartupMode.Location = New Point(264, 238)
        LblSSStartupMode.Name = "LblSSStartupMode"
        LblSSStartupMode.Size = New Size(170, 21)
        LblSSStartupMode.TabIndex = 25
        LblSSStartupMode.Text = "StartUp Mode"
        TipInfoEX.SetText(LblSSStartupMode, Nothing)
        LblSSStartupMode.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ChkBoxSSShowIcon
        ' 
        ChkBoxSSShowIcon.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkBoxSSShowIcon.AutoSize = True
        TipInfoEX.SetImage(ChkBoxSSShowIcon, Nothing)
        ChkBoxSSShowIcon.Location = New Point(265, 79)
        ChkBoxSSShowIcon.Name = "ChkBoxSSShowIcon"
        ChkBoxSSShowIcon.Size = New Size(134, 25)
        ChkBoxSSShowIcon.TabIndex = 100
        TipInfoEX.SetText(ChkBoxSSShowIcon, Nothing)
        ChkBoxSSShowIcon.Text = "Show Tray Icon"
        ChkBoxSSShowIcon.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxSSEnableOnActivate
        ' 
        ChkBoxSSEnableOnActivate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkBoxSSEnableOnActivate.AutoSize = True
        TipInfoEX.SetImage(ChkBoxSSEnableOnActivate, Nothing)
        ChkBoxSSEnableOnActivate.Location = New Point(265, 188)
        ChkBoxSSEnableOnActivate.Name = "ChkBoxSSEnableOnActivate"
        ChkBoxSSEnableOnActivate.Size = New Size(159, 25)
        ChkBoxSSEnableOnActivate.TabIndex = 130
        TipInfoEX.SetText(ChkBoxSSEnableOnActivate, Nothing)
        ChkBoxSSEnableOnActivate.Text = "Enable On Activate"
        ChkBoxSSEnableOnActivate.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxSSShowActivate
        ' 
        ChkBoxSSShowActivate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkBoxSSShowActivate.AutoSize = True
        TipInfoEX.SetImage(ChkBoxSSShowActivate, Nothing)
        ChkBoxSSShowActivate.Location = New Point(265, 110)
        ChkBoxSSShowActivate.Name = "ChkBoxSSShowActivate"
        ChkBoxSSShowActivate.Size = New Size(135, 25)
        ChkBoxSSShowActivate.TabIndex = 110
        TipInfoEX.SetText(ChkBoxSSShowActivate, Nothing)
        ChkBoxSSShowActivate.Text = "Show 'Activate'"
        ChkBoxSSShowActivate.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxSSShowEnabled
        ' 
        ChkBoxSSShowEnabled.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkBoxSSShowEnabled.AutoSize = True
        TipInfoEX.SetImage(ChkBoxSSShowEnabled, Nothing)
        ChkBoxSSShowEnabled.Location = New Point(265, 141)
        ChkBoxSSShowEnabled.Name = "ChkBoxSSShowEnabled"
        ChkBoxSSShowEnabled.Size = New Size(201, 25)
        ChkBoxSSShowEnabled.TabIndex = 120
        TipInfoEX.SetText(ChkBoxSSShowEnabled, Nothing)
        ChkBoxSSShowEnabled.Text = "Show 'Enabled/Disabled'"
        ChkBoxSSShowEnabled.UseVisualStyleBackColor = True
        ' 
        ' PanelActions
        ' 
        PanelActions.Controls.Add(BtnClose)
        PanelActions.Controls.Add(BtnRestoreSettings)
        PanelActions.Controls.Add(BtnSaveSettings)
        PanelActions.Controls.Add(BtnErrorTest)
        PanelActions.Controls.Add(BtnHelp)
        PanelActions.Controls.Add(BtnLog)
        PanelActions.Dock = DockStyle.Bottom
        TipInfoEX.SetImage(PanelActions, My.Resources.Resources.imageLog)
        PanelActions.Location = New Point(0, 534)
        PanelActions.Name = "PanelActions"
        PanelActions.Size = New Size(917, 96)
        PanelActions.TabIndex = 110
        TipInfoEX.SetText(PanelActions, "Show Log")
        ' 
        ' PanelPageSelector
        ' 
        PanelPageSelector.Controls.Add(LVPageSelector)
        PanelPageSelector.Dock = DockStyle.Left
        TipInfoEX.SetImage(PanelPageSelector, Nothing)
        PanelPageSelector.Location = New Point(0, 0)
        PanelPageSelector.Name = "PanelPageSelector"
        PanelPageSelector.Size = New Size(187, 534)
        PanelPageSelector.TabIndex = 111
        TipInfoEX.SetText(PanelPageSelector, Nothing)
        ' 
        ' LVPageSelector
        ' 
        LVPageSelector.AutoArrange = False
        LVPageSelector.BackColor = SystemColors.Control
        LVPageSelector.BorderStyle = BorderStyle.None
        LVPageSelector.Dock = DockStyle.Fill
        LVPageSelector.EditableColumns = CType(resources.GetObject("LVPageSelector.EditableColumns"), List(Of Boolean))
        LVPageSelector.FullRowSelect = True
        LVPageSelector.HeaderStyle = ColumnHeaderStyle.None
        TipInfoEX.SetImage(LVPageSelector, Nothing)
        LVPageSelector.InsertionLineColor = Color.Teal
        LVPageSelector.LargeImageList = ILPageSelector
        LVPageSelector.Location = New Point(0, 0)
        LVPageSelector.MultiSelect = False
        LVPageSelector.Name = "LVPageSelector"
        LVPageSelector.Scrollable = False
        LVPageSelector.ShowGroups = False
        LVPageSelector.Size = New Size(187, 534)
        LVPageSelector.TabIndex = 0
        LVPageSelector.TabStop = False
        TipInfoEX.SetText(LVPageSelector, Nothing)
        LVPageSelector.UseCompatibleStateImageBehavior = False
        ' 
        ' ILPageSelector
        ' 
        ILPageSelector.ColorDepth = ColorDepth.Depth32Bit
        ILPageSelector.ImageSize = New Size(48, 48)
        ILPageSelector.TransparentColor = Color.Transparent
        ' 
        ' TipInfoEX
        ' 
        TipInfoEX.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TipInfoEX.ShadowAlpha = 0
        TipInfoEX.ShadowThickness = 0
        ' 
        ' PanelAC
        ' 
        PanelAC.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelAC, Nothing)
        PanelAC.Location = New Point(187, 0)
        PanelAC.Name = "PanelAC"
        PanelAC.Size = New Size(730, 534)
        PanelAC.TabIndex = 108
        TipInfoEX.SetText(PanelAC, Nothing)
        ' 
        ' PanelWL
        ' 
        PanelWL.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelWL, Nothing)
        PanelWL.Location = New Point(187, 0)
        PanelWL.Name = "PanelWL"
        PanelWL.Size = New Size(730, 534)
        PanelWL.TabIndex = 112
        TipInfoEX.SetText(PanelWL, Nothing)
        ' 
        ' PanelHC
        ' 
        PanelHC.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelHC, Nothing)
        PanelHC.Location = New Point(187, 0)
        PanelHC.Name = "PanelHC"
        PanelHC.Size = New Size(730, 534)
        PanelHC.TabIndex = 113
        TipInfoEX.SetText(PanelHC, Nothing)
        ' 
        ' PanelHK
        ' 
        PanelHK.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelHK, Nothing)
        PanelHK.Location = New Point(187, 0)
        PanelHK.Name = "PanelHK"
        PanelHK.Size = New Size(730, 534)
        PanelHK.TabIndex = 114
        TipInfoEX.SetText(PanelHK, Nothing)
        ' 
        ' Settings
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        AutoValidate = AutoValidate.EnableAllowFocusChange
        ClientSize = New Size(917, 630)
        Controls.Add(PanelSS)
        Controls.Add(PanelWST)
        Controls.Add(PanelApp)
        Controls.Add(PanelHK)
        Controls.Add(PanelHC)
        Controls.Add(PanelWL)
        Controls.Add(PanelAC)
        Controls.Add(PanelPageSelector)
        Controls.Add(PanelActions)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        TipInfoEX.SetImage(Me, Nothing)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Settings"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        TipInfoEX.SetText(Me, Nothing)
        PanelApp.ResumeLayout(False)
        PanelApp.PerformLayout()
        PanelWST.ResumeLayout(False)
        PanelWST.PerformLayout()
        PanelSS.ResumeLayout(False)
        PanelSS.PerformLayout()
        PanelActions.ResumeLayout(False)
        PanelPageSelector.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Private WithEvents BtnClose As System.Windows.Forms.Button
    Private WithEvents BtnLog As System.Windows.Forms.Button
    Private WithEvents BtnHelp As System.Windows.Forms.Button
    Private WithEvents BtnErrorTest As System.Windows.Forms.Button
    Private radioButton32 As System.Windows.Forms.RadioButton
    Private radioButton31 As System.Windows.Forms.RadioButton
    Private radioButton30 As System.Windows.Forms.RadioButton
    Private radioButton29 As System.Windows.Forms.RadioButton
    Private radioButton28 As System.Windows.Forms.RadioButton
    Private radioButton27 As System.Windows.Forms.RadioButton
    Private radioButton26 As System.Windows.Forms.RadioButton
    Private radioButton25 As System.Windows.Forms.RadioButton
    Private radioButton24 As System.Windows.Forms.RadioButton
    Private radioButton23 As System.Windows.Forms.RadioButton
    Private radioButton22 As System.Windows.Forms.RadioButton
    Private radioButton21 As System.Windows.Forms.RadioButton
    Private radioButton20 As System.Windows.Forms.RadioButton
    Private radioButton19 As System.Windows.Forms.RadioButton
    Private radioButton18 As System.Windows.Forms.RadioButton
    Private radioButton17 As System.Windows.Forms.RadioButton
    Private radioButton16 As System.Windows.Forms.RadioButton
    Private WithEvents BtnRestoreSettings As System.Windows.Forms.Button
    Private WithEvents BtnSaveSettings As System.Windows.Forms.Button
    Friend WithEvents PanelApp As Panel
    Friend WithEvents PanelWST As Panel
    Friend WithEvents PanelSS As Panel
    Friend WithEvents PanelActions As Panel
    Friend WithEvents PanelPageSelector As Panel
    Friend WithEvents LVPageSelector As Skye.UI.ListViewEX
    Friend WithEvents ILPageSelector As ImageList
    Friend WithEvents TipInfoEX As Skye.UI.ToolTipEX
    Friend WithEvents PanelAC As Panel
    Friend WithEvents PanelWL As Panel
    Friend WithEvents PanelHC As Panel
    Friend WithEvents PanelHK As Panel
    Friend WithEvents LblTheme As Skye.UI.Label
    Friend WithEvents CoBoxTheme As Skye.UI.ComboBox
    Private WithEvents LblLoadOnOSStartupPath As Label
    Private WithEvents BtnLoadOnOSStartupPath As Button
    Private WithEvents ChkBoxLoadOnOSStartup As CheckBox
    Private WithEvents TxtBoxLoadOnOSStartupArgs As TextBox
    Friend WithEvents ChkBoxThemeAuto As CheckBox
    Private WithEvents ChkBoxWSTShowSleep As CheckBox
    Private WithEvents ChkBoxWSTSSToolEnabled As CheckBox
    Private WithEvents ChkBoxWSTShowLog As CheckBox
    Private WithEvents ChkBoxWSTShowReStart As CheckBox
    Private WithEvents ChkBoxWSTShowShutDown As CheckBox
    Private WithEvents ChkBoxWSTShowHibernate As CheckBox
    Private WithEvents ChkBoxWSTShowLogOff As CheckBox
    Private WithEvents ChkBoxWSTShowLockWorkSpace As CheckBox
    Private WithEvents ChkBoxWSTShowAC As CheckBox
    Private WithEvents ChkBoxWSTShowHelp As CheckBox
    Private WithEvents ChkBoxWSTShowClock As CheckBox
    Private WithEvents ChkBoxWSTShowWLTray As CheckBox
    Private WithEvents ChkBoxWSTShowWLMenu As CheckBox
    Private WithEvents ChkBoxWSTEnabled As CheckBox
    Private WithEvents BtnSSEnabled As RadioButton
    Private WithEvents CoBoxSSStartUp As ComboBox
    Private WithEvents LblSSStartupMode As Label
    Private WithEvents ChkBoxSSEnableOnActivate As CheckBox
    Private WithEvents ChkBoxSSShowEnabled As CheckBox
    Private WithEvents ChkBoxSSShowActivate As CheckBox
    Private WithEvents ChkBoxSSShowIcon As CheckBox
End Class