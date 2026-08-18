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
        CMBlankForTextBoxes = New ContextMenuStrip(components)
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
        lblACOffHourChimePath = New Label()
        btnACOffHourChimeManual = New Button()
        btnACAlarmCancel = New Button()
        lblACTopHourChimePath = New Label()
        lblACAlarmChimePath = New Label()
        checkboxACBottomHourAfterChimeEnabled = New CheckBox()
        checkboxACFirstQuarterHourAfterChimeEnabled = New CheckBox()
        checkboxACThirdQuarterHourBeforeChimeEnabled = New CheckBox()
        checkboxACFirstQuarterHourBeforeChimeEnabled = New CheckBox()
        checkboxACThirdQuarterHourAfterChimeEnabled = New CheckBox()
        checkboxACBottomHourBeforeChimeEnabled = New CheckBox()
        btnACMute = New Button()
        textboxACAlarmTimer = New TextBox()
        groupboxACTopHourChimeType = New GroupBox()
        radiobtnACTopHourChimeHourTick = New RadioButton()
        radiobtnACTopHourChimeSimple = New RadioButton()
        radiobtnACTopHourChimeExtended = New RadioButton()
        btnACOffHourChimeDefault = New Button()
        btnACTopHourChimeDefault = New Button()
        textboxACAlarmTime = New TextBox()
        btnACTopHourChimeManual = New Button()
        checkboxACThirdQuarterHourChimeEnabled = New CheckBox()
        checkboxACBottomHourChimeEnabled = New CheckBox()
        checkboxACFirstQuarterHourChimeEnabled = New CheckBox()
        checkboxACTopHourAfterChimeEnabled = New CheckBox()
        checkboxACTopHourChimeEnabled = New CheckBox()
        checkboxACTopHourBeforeChimeEnabled = New CheckBox()
        groupboxACAlarmChimeType = New GroupBox()
        radiobtnACAlarmChimeSimple = New RadioButton()
        radiobtnACAlarmChimeForever = New RadioButton()
        radiobtnACAlarmChimeExtended = New RadioButton()
        btnACAlarmSet = New Button()
        checkboxACAlarmRecurring = New CheckBox()
        LblACTimer = New Label()
        btnACTopHourChimePlay = New Button()
        btnACOffHourChimePlay = New Button()
        LblACTime = New Label()
        picboxACClock = New PictureBox()
        btnACAlarmChimeDefault = New Button()
        btnACAlarmChimePlay = New Button()
        btnACAlarmChimeManual = New Button()
        lblACAlarmChime = New Label()
        lblACOffHourChime = New Label()
        lblACTopHourChime = New Label()
        PanelWL = New Panel()
        textboxWLMaxLinksPerFolder = New TextBox()
        Panel1 = New Panel()
        checkboxWLShowNoMenu = New CheckBox()
        textboxWLName = New TextBox()
        checkboxWLShowMenuIcons = New CheckBox()
        checkboxWLShowInTray = New CheckBox()
        checkboxWLShowInMenu = New CheckBox()
        comboboxWLFolderPlacement = New ComboBox()
        comboboxWLFolderMode = New ComboBox()
        comboboxWLSort = New ComboBox()
        textboxWLRoot = New TextBox()
        btnWLSelectFolder = New Button()
        btnWLCancel = New Button()
        btnWLSet = New Button()
        checkboxWLUseDefaultIcon = New CheckBox()
        LblWLSortOrder = New Label()
        LblWLFolderMode = New Label()
        LblWLFolderPlacement = New Label()
        LblWLDisplayName = New Label()
        lblWLRoot = New Label()
        textboxWLStartUpDelay = New TextBox()
        textboxWLAutoRefreshInterval = New TextBox()
        listviewWL = New ListView()
        textboxWLAutoRefreshIdleInterval = New TextBox()
        lblWLAutoRefreshIdleInterval = New Label()
        lblWLAutoRefreshInterval = New Label()
        checkboxWLShowFilePathToolTips = New CheckBox()
        lblWLMaxLinksPerFolder = New Label()
        lblWLStartUpDelay = New Label()
        checkboxWLAutoRefresh = New CheckBox()
        checkboxWLShowFileInfoToolTips = New CheckBox()
        checkboxWLShowFolderPathToolTips = New CheckBox()
        lblWLAutoRefresh = New Label()
        btnWLRefresh = New Button()
        PanelHC = New Panel()
        PanelHK = New Panel()
        PanelApp.SuspendLayout()
        PanelWST.SuspendLayout()
        PanelSS.SuspendLayout()
        PanelActions.SuspendLayout()
        PanelPageSelector.SuspendLayout()
        PanelAC.SuspendLayout()
        groupboxACTopHourChimeType.SuspendLayout()
        groupboxACAlarmChimeType.SuspendLayout()
        CType(picboxACClock, ComponentModel.ISupportInitialize).BeginInit()
        PanelWL.SuspendLayout()
        Panel1.SuspendLayout()
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
        CoBoxTheme.DropDownStyle = ComboBoxStyle.DropDownList
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
        TxtBoxLoadOnOSStartupArgs.ContextMenuStrip = CMBlankForTextBoxes
        TipInfoEX.SetImage(TxtBoxLoadOnOSStartupArgs, Nothing)
        TxtBoxLoadOnOSStartupArgs.Location = New Point(255, 290)
        TxtBoxLoadOnOSStartupArgs.Name = "TxtBoxLoadOnOSStartupArgs"
        TxtBoxLoadOnOSStartupArgs.Size = New Size(215, 29)
        TxtBoxLoadOnOSStartupArgs.TabIndex = 220
        TipInfoEX.SetText(TxtBoxLoadOnOSStartupArgs, "Args")
        TxtBoxLoadOnOSStartupArgs.Text = "Sample Text"
        TxtBoxLoadOnOSStartupArgs.WordWrap = False
        ' 
        ' CMBlankForTextBoxes
        ' 
        TipInfoEX.SetImage(CMBlankForTextBoxes, Nothing)
        CMBlankForTextBoxes.Name = "CMBlankForTextBoxes"
        CMBlankForTextBoxes.Size = New Size(61, 4)
        TipInfoEX.SetText(CMBlankForTextBoxes, Nothing)
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
        PanelAC.Controls.Add(lblACOffHourChimePath)
        PanelAC.Controls.Add(btnACOffHourChimeManual)
        PanelAC.Controls.Add(btnACAlarmCancel)
        PanelAC.Controls.Add(lblACTopHourChimePath)
        PanelAC.Controls.Add(lblACAlarmChimePath)
        PanelAC.Controls.Add(checkboxACBottomHourAfterChimeEnabled)
        PanelAC.Controls.Add(checkboxACFirstQuarterHourAfterChimeEnabled)
        PanelAC.Controls.Add(checkboxACThirdQuarterHourBeforeChimeEnabled)
        PanelAC.Controls.Add(checkboxACFirstQuarterHourBeforeChimeEnabled)
        PanelAC.Controls.Add(checkboxACThirdQuarterHourAfterChimeEnabled)
        PanelAC.Controls.Add(checkboxACBottomHourBeforeChimeEnabled)
        PanelAC.Controls.Add(btnACMute)
        PanelAC.Controls.Add(textboxACAlarmTimer)
        PanelAC.Controls.Add(groupboxACTopHourChimeType)
        PanelAC.Controls.Add(btnACOffHourChimeDefault)
        PanelAC.Controls.Add(btnACTopHourChimeDefault)
        PanelAC.Controls.Add(textboxACAlarmTime)
        PanelAC.Controls.Add(btnACTopHourChimeManual)
        PanelAC.Controls.Add(checkboxACThirdQuarterHourChimeEnabled)
        PanelAC.Controls.Add(checkboxACBottomHourChimeEnabled)
        PanelAC.Controls.Add(checkboxACFirstQuarterHourChimeEnabled)
        PanelAC.Controls.Add(checkboxACTopHourAfterChimeEnabled)
        PanelAC.Controls.Add(checkboxACTopHourChimeEnabled)
        PanelAC.Controls.Add(checkboxACTopHourBeforeChimeEnabled)
        PanelAC.Controls.Add(groupboxACAlarmChimeType)
        PanelAC.Controls.Add(btnACAlarmSet)
        PanelAC.Controls.Add(checkboxACAlarmRecurring)
        PanelAC.Controls.Add(LblACTimer)
        PanelAC.Controls.Add(btnACTopHourChimePlay)
        PanelAC.Controls.Add(btnACOffHourChimePlay)
        PanelAC.Controls.Add(LblACTime)
        PanelAC.Controls.Add(picboxACClock)
        PanelAC.Controls.Add(btnACAlarmChimeDefault)
        PanelAC.Controls.Add(btnACAlarmChimePlay)
        PanelAC.Controls.Add(btnACAlarmChimeManual)
        PanelAC.Controls.Add(lblACAlarmChime)
        PanelAC.Controls.Add(lblACOffHourChime)
        PanelAC.Controls.Add(lblACTopHourChime)
        PanelAC.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelAC, Nothing)
        PanelAC.Location = New Point(187, 0)
        PanelAC.Name = "PanelAC"
        PanelAC.Size = New Size(730, 534)
        PanelAC.TabIndex = 108
        TipInfoEX.SetText(PanelAC, Nothing)
        ' 
        ' lblACOffHourChimePath
        ' 
        lblACOffHourChimePath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACOffHourChimePath.AutoEllipsis = True
        lblACOffHourChimePath.BorderStyle = BorderStyle.FixedSingle
        TipInfoEX.SetImage(lblACOffHourChimePath, Nothing)
        lblACOffHourChimePath.Location = New Point(555, 503)
        lblACOffHourChimePath.Name = "lblACOffHourChimePath"
        lblACOffHourChimePath.Size = New Size(163, 20)
        lblACOffHourChimePath.TabIndex = 72
        TipInfoEX.SetText(lblACOffHourChimePath, "Path")
        lblACOffHourChimePath.TextAlign = ContentAlignment.TopRight
        lblACOffHourChimePath.UseMnemonic = False
        ' 
        ' btnACOffHourChimeManual
        ' 
        btnACOffHourChimeManual.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACOffHourChimeManual.FlatAppearance.BorderSize = 0
        btnACOffHourChimeManual.Image = My.Resources.Resources.imageACFolder
        TipInfoEX.SetImage(btnACOffHourChimeManual, Nothing)
        btnACOffHourChimeManual.Location = New Point(687, 471)
        btnACOffHourChimeManual.Name = "btnACOffHourChimeManual"
        btnACOffHourChimeManual.Size = New Size(32, 32)
        btnACOffHourChimeManual.TabIndex = 204
        TipInfoEX.SetText(btnACOffHourChimeManual, "Select WAV File")
        btnACOffHourChimeManual.TextAlign = ContentAlignment.MiddleLeft
        btnACOffHourChimeManual.UseVisualStyleBackColor = True
        ' 
        ' btnACAlarmCancel
        ' 
        btnACAlarmCancel.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnACAlarmCancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnACAlarmCancel.ForeColor = Color.Maroon
        TipInfoEX.SetImage(btnACAlarmCancel, Nothing)
        btnACAlarmCancel.Location = New Point(101, 69)
        btnACAlarmCancel.Name = "btnACAlarmCancel"
        btnACAlarmCancel.Size = New Size(72, 64)
        btnACAlarmCancel.TabIndex = 17
        TipInfoEX.SetText(btnACAlarmCancel, "Cancel")
        btnACAlarmCancel.Text = " CANCEL  ALARM"
        btnACAlarmCancel.UseVisualStyleBackColor = True
        btnACAlarmCancel.Visible = False
        ' 
        ' lblACTopHourChimePath
        ' 
        lblACTopHourChimePath.AutoEllipsis = True
        lblACTopHourChimePath.BorderStyle = BorderStyle.FixedSingle
        TipInfoEX.SetImage(lblACTopHourChimePath, Nothing)
        lblACTopHourChimePath.Location = New Point(12, 434)
        lblACTopHourChimePath.Name = "lblACTopHourChimePath"
        lblACTopHourChimePath.Size = New Size(164, 20)
        lblACTopHourChimePath.TabIndex = 56
        TipInfoEX.SetText(lblACTopHourChimePath, "Path")
        lblACTopHourChimePath.UseMnemonic = False
        ' 
        ' lblACAlarmChimePath
        ' 
        lblACAlarmChimePath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACAlarmChimePath.AutoEllipsis = True
        lblACAlarmChimePath.BorderStyle = BorderStyle.FixedSingle
        TipInfoEX.SetImage(lblACAlarmChimePath, Nothing)
        lblACAlarmChimePath.Location = New Point(552, 65)
        lblACAlarmChimePath.Name = "lblACAlarmChimePath"
        lblACAlarmChimePath.Size = New Size(165, 20)
        lblACAlarmChimePath.TabIndex = 46
        TipInfoEX.SetText(lblACAlarmChimePath, "Path")
        lblACAlarmChimePath.TextAlign = ContentAlignment.TopRight
        lblACAlarmChimePath.UseMnemonic = False
        ' 
        ' checkboxACBottomHourAfterChimeEnabled
        ' 
        checkboxACBottomHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACBottomHourAfterChimeEnabled.BackgroundImageLayout = ImageLayout.None
        checkboxACBottomHourAfterChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(checkboxACBottomHourAfterChimeEnabled, Nothing)
        checkboxACBottomHourAfterChimeEnabled.Location = New Point(305, 412)
        checkboxACBottomHourAfterChimeEnabled.Name = "checkboxACBottomHourAfterChimeEnabled"
        checkboxACBottomHourAfterChimeEnabled.Size = New Size(13, 13)
        checkboxACBottomHourAfterChimeEnabled.TabIndex = 58
        checkboxACBottomHourAfterChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACBottomHourAfterChimeEnabled, Nothing)
        checkboxACBottomHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACFirstQuarterHourAfterChimeEnabled
        ' 
        checkboxACFirstQuarterHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACFirstQuarterHourAfterChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(checkboxACFirstQuarterHourAfterChimeEnabled, Nothing)
        checkboxACFirstQuarterHourAfterChimeEnabled.Location = New Point(445, 379)
        checkboxACFirstQuarterHourAfterChimeEnabled.Name = "checkboxACFirstQuarterHourAfterChimeEnabled"
        checkboxACFirstQuarterHourAfterChimeEnabled.Size = New Size(13, 13)
        checkboxACFirstQuarterHourAfterChimeEnabled.TabIndex = 61
        checkboxACFirstQuarterHourAfterChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACFirstQuarterHourAfterChimeEnabled, Nothing)
        checkboxACFirstQuarterHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACThirdQuarterHourBeforeChimeEnabled
        ' 
        checkboxACThirdQuarterHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACThirdQuarterHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(checkboxACThirdQuarterHourBeforeChimeEnabled, Nothing)
        checkboxACThirdQuarterHourBeforeChimeEnabled.Location = New Point(273, 378)
        checkboxACThirdQuarterHourBeforeChimeEnabled.Name = "checkboxACThirdQuarterHourBeforeChimeEnabled"
        checkboxACThirdQuarterHourBeforeChimeEnabled.Size = New Size(13, 13)
        checkboxACThirdQuarterHourBeforeChimeEnabled.TabIndex = 60
        checkboxACThirdQuarterHourBeforeChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACThirdQuarterHourBeforeChimeEnabled, Nothing)
        checkboxACThirdQuarterHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACFirstQuarterHourBeforeChimeEnabled
        ' 
        checkboxACFirstQuarterHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACFirstQuarterHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(checkboxACFirstQuarterHourBeforeChimeEnabled, Nothing)
        checkboxACFirstQuarterHourBeforeChimeEnabled.Location = New Point(444, 276)
        checkboxACFirstQuarterHourBeforeChimeEnabled.Name = "checkboxACFirstQuarterHourBeforeChimeEnabled"
        checkboxACFirstQuarterHourBeforeChimeEnabled.Size = New Size(13, 13)
        checkboxACFirstQuarterHourBeforeChimeEnabled.TabIndex = 65
        checkboxACFirstQuarterHourBeforeChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACFirstQuarterHourBeforeChimeEnabled, Nothing)
        checkboxACFirstQuarterHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACThirdQuarterHourAfterChimeEnabled
        ' 
        checkboxACThirdQuarterHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACThirdQuarterHourAfterChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(checkboxACThirdQuarterHourAfterChimeEnabled, Nothing)
        checkboxACThirdQuarterHourAfterChimeEnabled.Location = New Point(273, 274)
        checkboxACThirdQuarterHourAfterChimeEnabled.Name = "checkboxACThirdQuarterHourAfterChimeEnabled"
        checkboxACThirdQuarterHourAfterChimeEnabled.Size = New Size(13, 13)
        checkboxACThirdQuarterHourAfterChimeEnabled.TabIndex = 66
        checkboxACThirdQuarterHourAfterChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACThirdQuarterHourAfterChimeEnabled, Nothing)
        checkboxACThirdQuarterHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACBottomHourBeforeChimeEnabled
        ' 
        checkboxACBottomHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACBottomHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(checkboxACBottomHourBeforeChimeEnabled, Nothing)
        checkboxACBottomHourBeforeChimeEnabled.Location = New Point(410, 415)
        checkboxACBottomHourBeforeChimeEnabled.Name = "checkboxACBottomHourBeforeChimeEnabled"
        checkboxACBottomHourBeforeChimeEnabled.Size = New Size(13, 13)
        checkboxACBottomHourBeforeChimeEnabled.TabIndex = 57
        checkboxACBottomHourBeforeChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACBottomHourBeforeChimeEnabled, Nothing)
        checkboxACBottomHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' btnACMute
        ' 
        btnACMute.Anchor = AnchorStyles.Top
        btnACMute.FlatAppearance.BorderSize = 0
        TipInfoEX.SetImage(btnACMute, Nothing)
        btnACMute.Location = New Point(301, 12)
        btnACMute.Name = "btnACMute"
        btnACMute.Size = New Size(128, 128)
        btnACMute.TabIndex = 50
        TipInfoEX.SetText(btnACMute, "Mute All Chimes")
        btnACMute.TextAlign = ContentAlignment.MiddleLeft
        btnACMute.UseVisualStyleBackColor = True
        ' 
        ' textboxACAlarmTimer
        ' 
        TipInfoEX.SetImage(textboxACAlarmTimer, Nothing)
        textboxACAlarmTimer.Location = New Point(13, 139)
        textboxACAlarmTimer.MaxLength = 3
        textboxACAlarmTimer.Name = "textboxACAlarmTimer"
        textboxACAlarmTimer.Size = New Size(89, 29)
        textboxACAlarmTimer.TabIndex = 20
        TipInfoEX.SetText(textboxACAlarmTimer, "Enter Timer Value In Minutes")
        textboxACAlarmTimer.TextAlign = HorizontalAlignment.Center
        ' 
        ' groupboxACTopHourChimeType
        ' 
        groupboxACTopHourChimeType.Controls.Add(radiobtnACTopHourChimeHourTick)
        groupboxACTopHourChimeType.Controls.Add(radiobtnACTopHourChimeSimple)
        groupboxACTopHourChimeType.Controls.Add(radiobtnACTopHourChimeExtended)
        TipInfoEX.SetImage(groupboxACTopHourChimeType, Nothing)
        groupboxACTopHourChimeType.Location = New Point(12, 444)
        groupboxACTopHourChimeType.Name = "groupboxACTopHourChimeType"
        groupboxACTopHourChimeType.Size = New Size(110, 80)
        groupboxACTopHourChimeType.TabIndex = 160
        groupboxACTopHourChimeType.TabStop = False
        TipInfoEX.SetText(groupboxACTopHourChimeType, Nothing)
        ' 
        ' radiobtnACTopHourChimeHourTick
        ' 
        radiobtnACTopHourChimeHourTick.AutoSize = True
        TipInfoEX.SetImage(radiobtnACTopHourChimeHourTick, Nothing)
        radiobtnACTopHourChimeHourTick.Location = New Point(11, 53)
        radiobtnACTopHourChimeHourTick.Name = "radiobtnACTopHourChimeHourTick"
        radiobtnACTopHourChimeHourTick.Size = New Size(94, 25)
        radiobtnACTopHourChimeHourTick.TabIndex = 3
        radiobtnACTopHourChimeHourTick.TabStop = True
        TipInfoEX.SetText(radiobtnACTopHourChimeHourTick, "Chime Based On Hour")
        radiobtnACTopHourChimeHourTick.Text = "Hour Tick"
        radiobtnACTopHourChimeHourTick.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACTopHourChimeSimple
        ' 
        radiobtnACTopHourChimeSimple.AutoSize = True
        TipInfoEX.SetImage(radiobtnACTopHourChimeSimple, Nothing)
        radiobtnACTopHourChimeSimple.Location = New Point(11, 15)
        radiobtnACTopHourChimeSimple.Name = "radiobtnACTopHourChimeSimple"
        radiobtnACTopHourChimeSimple.Size = New Size(76, 25)
        radiobtnACTopHourChimeSimple.TabIndex = 1
        radiobtnACTopHourChimeSimple.TabStop = True
        TipInfoEX.SetText(radiobtnACTopHourChimeSimple, "Chime Once")
        radiobtnACTopHourChimeSimple.Text = "Simple"
        radiobtnACTopHourChimeSimple.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACTopHourChimeExtended
        ' 
        radiobtnACTopHourChimeExtended.AutoSize = True
        TipInfoEX.SetImage(radiobtnACTopHourChimeExtended, Nothing)
        radiobtnACTopHourChimeExtended.Location = New Point(11, 34)
        radiobtnACTopHourChimeExtended.Name = "radiobtnACTopHourChimeExtended"
        radiobtnACTopHourChimeExtended.Size = New Size(91, 25)
        radiobtnACTopHourChimeExtended.TabIndex = 2
        radiobtnACTopHourChimeExtended.TabStop = True
        TipInfoEX.SetText(radiobtnACTopHourChimeExtended, "Chime Several Times")
        radiobtnACTopHourChimeExtended.Text = "Extended"
        radiobtnACTopHourChimeExtended.UseVisualStyleBackColor = True
        ' 
        ' btnACOffHourChimeDefault
        ' 
        btnACOffHourChimeDefault.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACOffHourChimeDefault.FlatAppearance.BorderSize = 0
        btnACOffHourChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        TipInfoEX.SetImage(btnACOffHourChimeDefault, Nothing)
        btnACOffHourChimeDefault.Location = New Point(656, 471)
        btnACOffHourChimeDefault.Name = "btnACOffHourChimeDefault"
        btnACOffHourChimeDefault.Size = New Size(32, 32)
        btnACOffHourChimeDefault.TabIndex = 202
        TipInfoEX.SetText(btnACOffHourChimeDefault, "Use Default Chime")
        btnACOffHourChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        btnACOffHourChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' btnACTopHourChimeDefault
        ' 
        btnACTopHourChimeDefault.FlatAppearance.BorderSize = 0
        btnACTopHourChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        TipInfoEX.SetImage(btnACTopHourChimeDefault, Nothing)
        btnACTopHourChimeDefault.Location = New Point(42, 402)
        btnACTopHourChimeDefault.Name = "btnACTopHourChimeDefault"
        btnACTopHourChimeDefault.Size = New Size(32, 32)
        btnACTopHourChimeDefault.TabIndex = 152
        TipInfoEX.SetText(btnACTopHourChimeDefault, "Use Default Chime")
        btnACTopHourChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        btnACTopHourChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' textboxACAlarmTime
        ' 
        TipInfoEX.SetImage(textboxACAlarmTime, Nothing)
        textboxACAlarmTime.Location = New Point(13, 35)
        textboxACAlarmTime.MaxLength = 5
        textboxACAlarmTime.Name = "textboxACAlarmTime"
        textboxACAlarmTime.Size = New Size(89, 29)
        textboxACAlarmTime.TabIndex = 10
        TipInfoEX.SetText(textboxACAlarmTime, "Enter Alarm Time (24-Hour Format)")
        textboxACAlarmTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnACTopHourChimeManual
        ' 
        btnACTopHourChimeManual.FlatAppearance.BorderSize = 0
        btnACTopHourChimeManual.Image = My.Resources.Resources.imageACFolder
        TipInfoEX.SetImage(btnACTopHourChimeManual, Nothing)
        btnACTopHourChimeManual.Location = New Point(11, 402)
        btnACTopHourChimeManual.Name = "btnACTopHourChimeManual"
        btnACTopHourChimeManual.Size = New Size(32, 32)
        btnACTopHourChimeManual.TabIndex = 150
        TipInfoEX.SetText(btnACTopHourChimeManual, "Select WAV File")
        btnACTopHourChimeManual.TextAlign = ContentAlignment.MiddleLeft
        btnACTopHourChimeManual.UseVisualStyleBackColor = True
        ' 
        ' checkboxACThirdQuarterHourChimeEnabled
        ' 
        checkboxACThirdQuarterHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACThirdQuarterHourChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(checkboxACThirdQuarterHourChimeEnabled, Nothing)
        checkboxACThirdQuarterHourChimeEnabled.Location = New Point(259, 324)
        checkboxACThirdQuarterHourChimeEnabled.Name = "checkboxACThirdQuarterHourChimeEnabled"
        checkboxACThirdQuarterHourChimeEnabled.Size = New Size(15, 15)
        checkboxACThirdQuarterHourChimeEnabled.TabIndex = 64
        checkboxACThirdQuarterHourChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACThirdQuarterHourChimeEnabled, Nothing)
        checkboxACThirdQuarterHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACBottomHourChimeEnabled
        ' 
        checkboxACBottomHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACBottomHourChimeEnabled.CheckAlign = ContentAlignment.MiddleRight
        TipInfoEX.SetImage(checkboxACBottomHourChimeEnabled, Nothing)
        checkboxACBottomHourChimeEnabled.Location = New Point(358, 426)
        checkboxACBottomHourChimeEnabled.Name = "checkboxACBottomHourChimeEnabled"
        checkboxACBottomHourChimeEnabled.Size = New Size(15, 15)
        checkboxACBottomHourChimeEnabled.TabIndex = 63
        checkboxACBottomHourChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACBottomHourChimeEnabled, Nothing)
        checkboxACBottomHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACFirstQuarterHourChimeEnabled
        ' 
        checkboxACFirstQuarterHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACFirstQuarterHourChimeEnabled.CheckAlign = ContentAlignment.TopLeft
        TipInfoEX.SetImage(checkboxACFirstQuarterHourChimeEnabled, Nothing)
        checkboxACFirstQuarterHourChimeEnabled.Location = New Point(457, 325)
        checkboxACFirstQuarterHourChimeEnabled.Name = "checkboxACFirstQuarterHourChimeEnabled"
        checkboxACFirstQuarterHourChimeEnabled.Size = New Size(15, 15)
        checkboxACFirstQuarterHourChimeEnabled.TabIndex = 62
        checkboxACFirstQuarterHourChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACFirstQuarterHourChimeEnabled, Nothing)
        checkboxACFirstQuarterHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACTopHourAfterChimeEnabled
        ' 
        checkboxACTopHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACTopHourAfterChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(checkboxACTopHourAfterChimeEnabled, Nothing)
        checkboxACTopHourAfterChimeEnabled.Location = New Point(409, 240)
        checkboxACTopHourAfterChimeEnabled.Name = "checkboxACTopHourAfterChimeEnabled"
        checkboxACTopHourAfterChimeEnabled.Size = New Size(15, 15)
        checkboxACTopHourAfterChimeEnabled.TabIndex = 67
        checkboxACTopHourAfterChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACTopHourAfterChimeEnabled, Nothing)
        checkboxACTopHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACTopHourChimeEnabled
        ' 
        checkboxACTopHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACTopHourChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(checkboxACTopHourChimeEnabled, Nothing)
        checkboxACTopHourChimeEnabled.Location = New Point(358, 227)
        checkboxACTopHourChimeEnabled.Name = "checkboxACTopHourChimeEnabled"
        checkboxACTopHourChimeEnabled.Size = New Size(15, 15)
        checkboxACTopHourChimeEnabled.TabIndex = 0
        checkboxACTopHourChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACTopHourChimeEnabled, Nothing)
        checkboxACTopHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACTopHourBeforeChimeEnabled
        ' 
        checkboxACTopHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACTopHourBeforeChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(checkboxACTopHourBeforeChimeEnabled, Nothing)
        checkboxACTopHourBeforeChimeEnabled.Location = New Point(306, 239)
        checkboxACTopHourBeforeChimeEnabled.Name = "checkboxACTopHourBeforeChimeEnabled"
        checkboxACTopHourBeforeChimeEnabled.Size = New Size(15, 15)
        checkboxACTopHourBeforeChimeEnabled.TabIndex = 59
        checkboxACTopHourBeforeChimeEnabled.TabStop = False
        TipInfoEX.SetText(checkboxACTopHourBeforeChimeEnabled, Nothing)
        checkboxACTopHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' groupboxACAlarmChimeType
        ' 
        groupboxACAlarmChimeType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        groupboxACAlarmChimeType.BackColor = Color.Transparent
        groupboxACAlarmChimeType.Controls.Add(radiobtnACAlarmChimeSimple)
        groupboxACAlarmChimeType.Controls.Add(radiobtnACAlarmChimeForever)
        groupboxACAlarmChimeType.Controls.Add(radiobtnACAlarmChimeExtended)
        TipInfoEX.SetImage(groupboxACAlarmChimeType, Nothing)
        groupboxACAlarmChimeType.Location = New Point(607, 76)
        groupboxACAlarmChimeType.Name = "groupboxACAlarmChimeType"
        groupboxACAlarmChimeType.Size = New Size(110, 80)
        groupboxACAlarmChimeType.TabIndex = 120
        groupboxACAlarmChimeType.TabStop = False
        TipInfoEX.SetText(groupboxACAlarmChimeType, Nothing)
        ' 
        ' radiobtnACAlarmChimeSimple
        ' 
        radiobtnACAlarmChimeSimple.AutoSize = True
        TipInfoEX.SetImage(radiobtnACAlarmChimeSimple, Nothing)
        radiobtnACAlarmChimeSimple.Location = New Point(13, 13)
        radiobtnACAlarmChimeSimple.Name = "radiobtnACAlarmChimeSimple"
        radiobtnACAlarmChimeSimple.Size = New Size(76, 25)
        radiobtnACAlarmChimeSimple.TabIndex = 1
        radiobtnACAlarmChimeSimple.TabStop = True
        TipInfoEX.SetText(radiobtnACAlarmChimeSimple, "Chime Once")
        radiobtnACAlarmChimeSimple.Text = "Simple"
        radiobtnACAlarmChimeSimple.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACAlarmChimeForever
        ' 
        radiobtnACAlarmChimeForever.AutoSize = True
        TipInfoEX.SetImage(radiobtnACAlarmChimeForever, Nothing)
        radiobtnACAlarmChimeForever.Location = New Point(13, 51)
        radiobtnACAlarmChimeForever.Name = "radiobtnACAlarmChimeForever"
        radiobtnACAlarmChimeForever.Size = New Size(81, 25)
        radiobtnACAlarmChimeForever.TabIndex = 3
        radiobtnACAlarmChimeForever.TabStop = True
        TipInfoEX.SetText(radiobtnACAlarmChimeForever, "Chime Until Cancelled")
        radiobtnACAlarmChimeForever.Text = "Forever"
        radiobtnACAlarmChimeForever.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACAlarmChimeExtended
        ' 
        radiobtnACAlarmChimeExtended.AutoSize = True
        TipInfoEX.SetImage(radiobtnACAlarmChimeExtended, Nothing)
        radiobtnACAlarmChimeExtended.Location = New Point(13, 32)
        radiobtnACAlarmChimeExtended.Name = "radiobtnACAlarmChimeExtended"
        radiobtnACAlarmChimeExtended.Size = New Size(91, 25)
        radiobtnACAlarmChimeExtended.TabIndex = 2
        radiobtnACAlarmChimeExtended.TabStop = True
        TipInfoEX.SetText(radiobtnACAlarmChimeExtended, "Chime Several Times")
        radiobtnACAlarmChimeExtended.Text = "Extended"
        radiobtnACAlarmChimeExtended.UseVisualStyleBackColor = True
        ' 
        ' btnACAlarmSet
        ' 
        btnACAlarmSet.FlatAppearance.BorderColor = SystemColors.ControlDark
        TipInfoEX.SetImage(btnACAlarmSet, Nothing)
        btnACAlarmSet.Location = New Point(12, 69)
        btnACAlarmSet.Name = "btnACAlarmSet"
        btnACAlarmSet.Size = New Size(90, 64)
        btnACAlarmSet.TabIndex = 15
        TipInfoEX.SetText(btnACAlarmSet, "Activate / DeActivate Alarm")
        btnACAlarmSet.Text = "Alarm InActive"
        btnACAlarmSet.UseVisualStyleBackColor = True
        ' 
        ' checkboxACAlarmRecurring
        ' 
        checkboxACAlarmRecurring.AutoSize = True
        TipInfoEX.SetImage(checkboxACAlarmRecurring, Nothing)
        checkboxACAlarmRecurring.Location = New Point(110, 39)
        checkboxACAlarmRecurring.Name = "checkboxACAlarmRecurring"
        checkboxACAlarmRecurring.Size = New Size(97, 25)
        checkboxACAlarmRecurring.TabIndex = 12
        TipInfoEX.SetText(checkboxACAlarmRecurring, "Alarm Repeats Every Day")
        checkboxACAlarmRecurring.Text = "Recurring"
        checkboxACAlarmRecurring.UseVisualStyleBackColor = True
        ' 
        ' LblACTimer
        ' 
        LblACTimer.ForeColor = SystemColors.ControlText
        TipInfoEX.SetImage(LblACTimer, Nothing)
        LblACTimer.Location = New Point(13, 164)
        LblACTimer.Name = "LblACTimer"
        LblACTimer.Size = New Size(89, 20)
        LblACTimer.TabIndex = 73
        LblACTimer.Text = "Timer"
        TipInfoEX.SetText(LblACTimer, Nothing)
        LblACTimer.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' btnACTopHourChimePlay
        ' 
        btnACTopHourChimePlay.FlatAppearance.BorderSize = 0
        btnACTopHourChimePlay.Image = My.Resources.Resources.imageACPlay
        TipInfoEX.SetImage(btnACTopHourChimePlay, Nothing)
        btnACTopHourChimePlay.Location = New Point(73, 402)
        btnACTopHourChimePlay.Name = "btnACTopHourChimePlay"
        btnACTopHourChimePlay.Size = New Size(32, 32)
        btnACTopHourChimePlay.TabIndex = 154
        TipInfoEX.SetText(btnACTopHourChimePlay, "Play Sound")
        btnACTopHourChimePlay.TextAlign = ContentAlignment.MiddleLeft
        btnACTopHourChimePlay.UseVisualStyleBackColor = True
        ' 
        ' btnACOffHourChimePlay
        ' 
        btnACOffHourChimePlay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACOffHourChimePlay.FlatAppearance.BorderSize = 0
        btnACOffHourChimePlay.Image = My.Resources.Resources.imageACPlay
        TipInfoEX.SetImage(btnACOffHourChimePlay, Nothing)
        btnACOffHourChimePlay.Location = New Point(625, 471)
        btnACOffHourChimePlay.Name = "btnACOffHourChimePlay"
        btnACOffHourChimePlay.Size = New Size(32, 32)
        btnACOffHourChimePlay.TabIndex = 200
        TipInfoEX.SetText(btnACOffHourChimePlay, "Play Sound")
        btnACOffHourChimePlay.TextAlign = ContentAlignment.MiddleLeft
        btnACOffHourChimePlay.UseVisualStyleBackColor = True
        ' 
        ' LblACTime
        ' 
        LblACTime.ForeColor = SystemColors.ControlText
        TipInfoEX.SetImage(LblACTime, Nothing)
        LblACTime.Location = New Point(13, 14)
        LblACTime.Name = "LblACTime"
        LblACTime.Size = New Size(89, 24)
        LblACTime.TabIndex = 74
        LblACTime.Text = "Time"
        TipInfoEX.SetText(LblACTime, Nothing)
        LblACTime.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' picboxACClock
        ' 
        picboxACClock.Anchor = AnchorStyles.Top
        picboxACClock.Image = My.Resources.Resources.imageACClock
        TipInfoEX.SetImage(picboxACClock, Nothing)
        picboxACClock.Location = New Point(268, 237)
        picboxACClock.Name = "picboxACClock"
        picboxACClock.Size = New Size(192, 192)
        picboxACClock.SizeMode = PictureBoxSizeMode.Zoom
        picboxACClock.TabIndex = 37
        picboxACClock.TabStop = False
        TipInfoEX.SetText(picboxACClock, "Select When To Sound Chime Each Hour")
        ' 
        ' btnACAlarmChimeDefault
        ' 
        btnACAlarmChimeDefault.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACAlarmChimeDefault.FlatAppearance.BorderSize = 0
        btnACAlarmChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        TipInfoEX.SetImage(btnACAlarmChimeDefault, Nothing)
        btnACAlarmChimeDefault.Location = New Point(655, 33)
        btnACAlarmChimeDefault.Name = "btnACAlarmChimeDefault"
        btnACAlarmChimeDefault.Size = New Size(32, 32)
        btnACAlarmChimeDefault.TabIndex = 105
        TipInfoEX.SetText(btnACAlarmChimeDefault, "Use Default Chime")
        btnACAlarmChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        btnACAlarmChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' btnACAlarmChimePlay
        ' 
        btnACAlarmChimePlay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACAlarmChimePlay.FlatAppearance.BorderSize = 0
        btnACAlarmChimePlay.Image = My.Resources.Resources.imageACPlay
        TipInfoEX.SetImage(btnACAlarmChimePlay, Nothing)
        btnACAlarmChimePlay.Location = New Point(624, 33)
        btnACAlarmChimePlay.Name = "btnACAlarmChimePlay"
        btnACAlarmChimePlay.Size = New Size(32, 32)
        btnACAlarmChimePlay.TabIndex = 100
        TipInfoEX.SetText(btnACAlarmChimePlay, "Play Sound")
        btnACAlarmChimePlay.TextAlign = ContentAlignment.MiddleLeft
        btnACAlarmChimePlay.UseVisualStyleBackColor = True
        ' 
        ' btnACAlarmChimeManual
        ' 
        btnACAlarmChimeManual.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACAlarmChimeManual.FlatAppearance.BorderSize = 0
        btnACAlarmChimeManual.Image = My.Resources.Resources.imageACFolder
        TipInfoEX.SetImage(btnACAlarmChimeManual, Nothing)
        btnACAlarmChimeManual.Location = New Point(686, 33)
        btnACAlarmChimeManual.Name = "btnACAlarmChimeManual"
        btnACAlarmChimeManual.Size = New Size(32, 32)
        btnACAlarmChimeManual.TabIndex = 110
        TipInfoEX.SetText(btnACAlarmChimeManual, "Select WAV File")
        btnACAlarmChimeManual.TextAlign = ContentAlignment.MiddleLeft
        btnACAlarmChimeManual.UseVisualStyleBackColor = True
        ' 
        ' lblACAlarmChime
        ' 
        lblACAlarmChime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACAlarmChime.ForeColor = SystemColors.ControlText
        TipInfoEX.SetImage(lblACAlarmChime, Nothing)
        lblACAlarmChime.Location = New Point(615, 11)
        lblACAlarmChime.Name = "lblACAlarmChime"
        lblACAlarmChime.Size = New Size(104, 24)
        lblACAlarmChime.TabIndex = 68
        lblACAlarmChime.Text = "Alarm"
        TipInfoEX.SetText(lblACAlarmChime, Nothing)
        lblACAlarmChime.TextAlign = ContentAlignment.BottomRight
        ' 
        ' lblACOffHourChime
        ' 
        lblACOffHourChime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACOffHourChime.AutoSize = True
        lblACOffHourChime.ForeColor = SystemColors.ControlText
        TipInfoEX.SetImage(lblACOffHourChime, Nothing)
        lblACOffHourChime.Location = New Point(592, 452)
        lblACOffHourChime.Name = "lblACOffHourChime"
        lblACOffHourChime.Size = New Size(129, 21)
        lblACOffHourChime.TabIndex = 51
        lblACOffHourChime.Text = "Off-Hour Chimes"
        TipInfoEX.SetText(lblACOffHourChime, Nothing)
        lblACOffHourChime.TextAlign = ContentAlignment.BottomRight
        ' 
        ' lblACTopHourChime
        ' 
        lblACTopHourChime.AutoSize = True
        lblACTopHourChime.ForeColor = SystemColors.ControlText
        TipInfoEX.SetImage(lblACTopHourChime, Nothing)
        lblACTopHourChime.Location = New Point(11, 381)
        lblACTopHourChime.Name = "lblACTopHourChime"
        lblACTopHourChime.Size = New Size(124, 21)
        lblACTopHourChime.TabIndex = 50
        lblACTopHourChime.Text = "Top-Hour Chime"
        TipInfoEX.SetText(lblACTopHourChime, Nothing)
        lblACTopHourChime.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PanelWL
        ' 
        PanelWL.Controls.Add(textboxWLMaxLinksPerFolder)
        PanelWL.Controls.Add(Panel1)
        PanelWL.Controls.Add(textboxWLStartUpDelay)
        PanelWL.Controls.Add(textboxWLAutoRefreshInterval)
        PanelWL.Controls.Add(listviewWL)
        PanelWL.Controls.Add(textboxWLAutoRefreshIdleInterval)
        PanelWL.Controls.Add(lblWLAutoRefreshIdleInterval)
        PanelWL.Controls.Add(lblWLAutoRefreshInterval)
        PanelWL.Controls.Add(checkboxWLShowFilePathToolTips)
        PanelWL.Controls.Add(lblWLMaxLinksPerFolder)
        PanelWL.Controls.Add(lblWLStartUpDelay)
        PanelWL.Controls.Add(checkboxWLAutoRefresh)
        PanelWL.Controls.Add(checkboxWLShowFileInfoToolTips)
        PanelWL.Controls.Add(checkboxWLShowFolderPathToolTips)
        PanelWL.Controls.Add(lblWLAutoRefresh)
        PanelWL.Controls.Add(btnWLRefresh)
        PanelWL.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelWL, Nothing)
        PanelWL.Location = New Point(187, 0)
        PanelWL.Name = "PanelWL"
        PanelWL.Size = New Size(730, 534)
        PanelWL.TabIndex = 112
        TipInfoEX.SetText(PanelWL, Nothing)
        ' 
        ' textboxWLMaxLinksPerFolder
        ' 
        TipInfoEX.SetImage(textboxWLMaxLinksPerFolder, Nothing)
        textboxWLMaxLinksPerFolder.Location = New Point(13, 47)
        textboxWLMaxLinksPerFolder.MaxLength = 3
        textboxWLMaxLinksPerFolder.Name = "textboxWLMaxLinksPerFolder"
        textboxWLMaxLinksPerFolder.Size = New Size(44, 29)
        textboxWLMaxLinksPerFolder.TabIndex = 186
        TipInfoEX.SetText(textboxWLMaxLinksPerFolder, Nothing)
        textboxWLMaxLinksPerFolder.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoSize = True
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(checkboxWLShowNoMenu)
        Panel1.Controls.Add(textboxWLName)
        Panel1.Controls.Add(checkboxWLShowMenuIcons)
        Panel1.Controls.Add(checkboxWLShowInTray)
        Panel1.Controls.Add(checkboxWLShowInMenu)
        Panel1.Controls.Add(comboboxWLFolderPlacement)
        Panel1.Controls.Add(comboboxWLFolderMode)
        Panel1.Controls.Add(comboboxWLSort)
        Panel1.Controls.Add(textboxWLRoot)
        Panel1.Controls.Add(btnWLSelectFolder)
        Panel1.Controls.Add(btnWLCancel)
        Panel1.Controls.Add(btnWLSet)
        Panel1.Controls.Add(checkboxWLUseDefaultIcon)
        Panel1.Controls.Add(LblWLSortOrder)
        Panel1.Controls.Add(LblWLFolderMode)
        Panel1.Controls.Add(LblWLFolderPlacement)
        Panel1.Controls.Add(LblWLDisplayName)
        Panel1.Controls.Add(lblWLRoot)
        TipInfoEX.SetImage(Panel1, Nothing)
        Panel1.Location = New Point(13, 318)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(706, 205)
        Panel1.TabIndex = 181
        TipInfoEX.SetText(Panel1, Nothing)
        Panel1.Visible = False
        ' 
        ' checkboxWLShowNoMenu
        ' 
        checkboxWLShowNoMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWLShowNoMenu.AutoSize = True
        TipInfoEX.SetImage(checkboxWLShowNoMenu, Nothing)
        checkboxWLShowNoMenu.Location = New Point(1050, 105)
        checkboxWLShowNoMenu.Name = "checkboxWLShowNoMenu"
        checkboxWLShowNoMenu.Size = New Size(136, 25)
        checkboxWLShowNoMenu.TabIndex = 66
        TipInfoEX.SetText(checkboxWLShowNoMenu, Nothing)
        checkboxWLShowNoMenu.Text = "No Menu Items"
        checkboxWLShowNoMenu.UseVisualStyleBackColor = True
        ' 
        ' textboxWLName
        ' 
        TipInfoEX.SetImage(textboxWLName, Nothing)
        textboxWLName.Location = New Point(8, 79)
        textboxWLName.Name = "textboxWLName"
        textboxWLName.Size = New Size(463, 29)
        textboxWLName.TabIndex = 15
        TipInfoEX.SetText(textboxWLName, Nothing)
        ' 
        ' checkboxWLShowMenuIcons
        ' 
        checkboxWLShowMenuIcons.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWLShowMenuIcons.AutoSize = True
        TipInfoEX.SetImage(checkboxWLShowMenuIcons, Nothing)
        checkboxWLShowMenuIcons.Location = New Point(1050, 86)
        checkboxWLShowMenuIcons.Name = "checkboxWLShowMenuIcons"
        checkboxWLShowMenuIcons.Size = New Size(152, 25)
        checkboxWLShowMenuIcons.TabIndex = 64
        TipInfoEX.SetText(checkboxWLShowMenuIcons, Nothing)
        checkboxWLShowMenuIcons.Text = "Show Menu Icons"
        checkboxWLShowMenuIcons.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowInTray
        ' 
        checkboxWLShowInTray.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWLShowInTray.AutoSize = True
        TipInfoEX.SetImage(checkboxWLShowInTray, Nothing)
        checkboxWLShowInTray.Location = New Point(1050, 56)
        checkboxWLShowInTray.Name = "checkboxWLShowInTray"
        checkboxWLShowInTray.Size = New Size(118, 25)
        checkboxWLShowInTray.TabIndex = 62
        TipInfoEX.SetText(checkboxWLShowInTray, Nothing)
        checkboxWLShowInTray.Text = "Show In Tray"
        checkboxWLShowInTray.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowInMenu
        ' 
        checkboxWLShowInMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWLShowInMenu.AutoSize = True
        TipInfoEX.SetImage(checkboxWLShowInMenu, Nothing)
        checkboxWLShowInMenu.Location = New Point(1050, 37)
        checkboxWLShowInMenu.Name = "checkboxWLShowInMenu"
        checkboxWLShowInMenu.Size = New Size(129, 25)
        checkboxWLShowInMenu.TabIndex = 60
        TipInfoEX.SetText(checkboxWLShowInMenu, Nothing)
        checkboxWLShowInMenu.Text = "Show In Menu"
        checkboxWLShowInMenu.UseVisualStyleBackColor = True
        ' 
        ' comboboxWLFolderPlacement
        ' 
        comboboxWLFolderPlacement.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxWLFolderPlacement.FormattingEnabled = True
        TipInfoEX.SetImage(comboboxWLFolderPlacement, Nothing)
        comboboxWLFolderPlacement.Items.AddRange(New Object() {"Top", "Bottom", "Merged"})
        comboboxWLFolderPlacement.Location = New Point(296, 165)
        comboboxWLFolderPlacement.Name = "comboboxWLFolderPlacement"
        comboboxWLFolderPlacement.Size = New Size(139, 29)
        comboboxWLFolderPlacement.TabIndex = 40
        TipInfoEX.SetText(comboboxWLFolderPlacement, Nothing)
        ' 
        ' comboboxWLFolderMode
        ' 
        comboboxWLFolderMode.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxWLFolderMode.FormattingEnabled = True
        TipInfoEX.SetImage(comboboxWLFolderMode, Nothing)
        comboboxWLFolderMode.Items.AddRange(New Object() {"No Folders", "Show As Link", "Show As Link Menu", "Show As Menu", "Folders Only"})
        comboboxWLFolderMode.Location = New Point(123, 165)
        comboboxWLFolderMode.Name = "comboboxWLFolderMode"
        comboboxWLFolderMode.Size = New Size(167, 29)
        comboboxWLFolderMode.TabIndex = 30
        TipInfoEX.SetText(comboboxWLFolderMode, Nothing)
        ' 
        ' comboboxWLSort
        ' 
        comboboxWLSort.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxWLSort.FormattingEnabled = True
        TipInfoEX.SetImage(comboboxWLSort, Nothing)
        comboboxWLSort.Items.AddRange(New Object() {"Ascending", "Descending"})
        comboboxWLSort.Location = New Point(8, 166)
        comboboxWLSort.Name = "comboboxWLSort"
        comboboxWLSort.Size = New Size(109, 29)
        comboboxWLSort.TabIndex = 20
        TipInfoEX.SetText(comboboxWLSort, Nothing)
        ' 
        ' textboxWLRoot
        ' 
        TipInfoEX.SetImage(textboxWLRoot, Nothing)
        textboxWLRoot.Location = New Point(8, 25)
        textboxWLRoot.Name = "textboxWLRoot"
        textboxWLRoot.Size = New Size(463, 29)
        textboxWLRoot.TabIndex = 10
        TipInfoEX.SetText(textboxWLRoot, Nothing)
        ' 
        ' btnWLSelectFolder
        ' 
        btnWLSelectFolder.FlatAppearance.BorderSize = 0
        btnWLSelectFolder.Image = My.Resources.Resources.imageRestore
        TipInfoEX.SetImage(btnWLSelectFolder, Nothing)
        btnWLSelectFolder.Location = New Point(472, 24)
        btnWLSelectFolder.Name = "btnWLSelectFolder"
        btnWLSelectFolder.Size = New Size(32, 32)
        btnWLSelectFolder.TabIndex = 10
        btnWLSelectFolder.TabStop = False
        TipInfoEX.SetText(btnWLSelectFolder, Nothing)
        btnWLSelectFolder.UseVisualStyleBackColor = True
        ' 
        ' btnWLCancel
        ' 
        btnWLCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnWLCancel.ForeColor = Color.Navy
        btnWLCancel.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnWLCancel, Nothing)
        btnWLCancel.ImageAlign = ContentAlignment.MiddleLeft
        btnWLCancel.Location = New Point(1029, 267)
        btnWLCancel.Name = "btnWLCancel"
        btnWLCancel.Size = New Size(100, 32)
        btnWLCancel.TabIndex = 156
        TipInfoEX.SetText(btnWLCancel, Nothing)
        btnWLCancel.Text = "Cancel"
        btnWLCancel.TextAlign = ContentAlignment.MiddleRight
        btnWLCancel.UseVisualStyleBackColor = True
        ' 
        ' btnWLSet
        ' 
        btnWLSet.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnWLSet.ForeColor = Color.Navy
        btnWLSet.Image = My.Resources.Resources.imageGoStart
        TipInfoEX.SetImage(btnWLSet, Nothing)
        btnWLSet.ImageAlign = ContentAlignment.MiddleLeft
        btnWLSet.Location = New Point(1134, 267)
        btnWLSet.Name = "btnWLSet"
        btnWLSet.Size = New Size(66, 32)
        btnWLSet.TabIndex = 157
        TipInfoEX.SetText(btnWLSet, Nothing)
        btnWLSet.Text = "Set"
        btnWLSet.TextAlign = ContentAlignment.MiddleRight
        btnWLSet.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLUseDefaultIcon
        ' 
        checkboxWLUseDefaultIcon.AutoSize = True
        TipInfoEX.SetImage(checkboxWLUseDefaultIcon, Nothing)
        checkboxWLUseDefaultIcon.Location = New Point(546, 6)
        checkboxWLUseDefaultIcon.Name = "checkboxWLUseDefaultIcon"
        checkboxWLUseDefaultIcon.Size = New Size(142, 25)
        checkboxWLUseDefaultIcon.TabIndex = 9
        TipInfoEX.SetText(checkboxWLUseDefaultIcon, Nothing)
        checkboxWLUseDefaultIcon.Text = "Use Default Icon"
        checkboxWLUseDefaultIcon.UseVisualStyleBackColor = True
        ' 
        ' LblWLSortOrder
        ' 
        LblWLSortOrder.AutoSize = True
        TipInfoEX.SetImage(LblWLSortOrder, Nothing)
        LblWLSortOrder.Location = New Point(8, 148)
        LblWLSortOrder.Name = "LblWLSortOrder"
        LblWLSortOrder.Size = New Size(84, 21)
        LblWLSortOrder.TabIndex = 165
        LblWLSortOrder.Text = "Sort Order"
        TipInfoEX.SetText(LblWLSortOrder, Nothing)
        ' 
        ' LblWLFolderMode
        ' 
        LblWLFolderMode.AutoSize = True
        TipInfoEX.SetImage(LblWLFolderMode, Nothing)
        LblWLFolderMode.Location = New Point(123, 147)
        LblWLFolderMode.Name = "LblWLFolderMode"
        LblWLFolderMode.Size = New Size(98, 21)
        LblWLFolderMode.TabIndex = 161
        LblWLFolderMode.Text = "Folder Mode"
        TipInfoEX.SetText(LblWLFolderMode, Nothing)
        ' 
        ' LblWLFolderPlacement
        ' 
        LblWLFolderPlacement.AutoSize = True
        TipInfoEX.SetImage(LblWLFolderPlacement, Nothing)
        LblWLFolderPlacement.Location = New Point(296, 147)
        LblWLFolderPlacement.Name = "LblWLFolderPlacement"
        LblWLFolderPlacement.Size = New Size(130, 21)
        LblWLFolderPlacement.TabIndex = 166
        LblWLFolderPlacement.Text = "Folder Placement"
        TipInfoEX.SetText(LblWLFolderPlacement, Nothing)
        ' 
        ' LblWLDisplayName
        ' 
        LblWLDisplayName.AutoSize = True
        TipInfoEX.SetImage(LblWLDisplayName, Nothing)
        LblWLDisplayName.Location = New Point(8, 58)
        LblWLDisplayName.Name = "LblWLDisplayName"
        LblWLDisplayName.Size = New Size(107, 21)
        LblWLDisplayName.TabIndex = 168
        LblWLDisplayName.Text = "Display Name"
        TipInfoEX.SetText(LblWLDisplayName, "Leave Blank To Use FolderName")
        ' 
        ' lblWLRoot
        ' 
        lblWLRoot.AutoSize = True
        TipInfoEX.SetImage(lblWLRoot, Nothing)
        lblWLRoot.Location = New Point(7, 4)
        lblWLRoot.Name = "lblWLRoot"
        lblWLRoot.Size = New Size(68, 21)
        lblWLRoot.TabIndex = 160
        lblWLRoot.Text = "SAMPLE"
        TipInfoEX.SetText(lblWLRoot, Nothing)
        ' 
        ' textboxWLStartUpDelay
        ' 
        TipInfoEX.SetImage(textboxWLStartUpDelay, Nothing)
        textboxWLStartUpDelay.Location = New Point(13, 12)
        textboxWLStartUpDelay.MaxLength = 3
        textboxWLStartUpDelay.Name = "textboxWLStartUpDelay"
        textboxWLStartUpDelay.Size = New Size(44, 29)
        textboxWLStartUpDelay.TabIndex = 185
        TipInfoEX.SetText(textboxWLStartUpDelay, Nothing)
        textboxWLStartUpDelay.TextAlign = HorizontalAlignment.Center
        ' 
        ' textboxWLAutoRefreshInterval
        ' 
        textboxWLAutoRefreshInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(textboxWLAutoRefreshInterval, Nothing)
        textboxWLAutoRefreshInterval.Location = New Point(675, 12)
        textboxWLAutoRefreshInterval.MaxLength = 2
        textboxWLAutoRefreshInterval.Name = "textboxWLAutoRefreshInterval"
        textboxWLAutoRefreshInterval.Size = New Size(44, 29)
        textboxWLAutoRefreshInterval.TabIndex = 175
        TipInfoEX.SetText(textboxWLAutoRefreshInterval, Nothing)
        textboxWLAutoRefreshInterval.TextAlign = HorizontalAlignment.Center
        ' 
        ' listviewWL
        ' 
        listviewWL.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        listviewWL.BorderStyle = BorderStyle.FixedSingle
        listviewWL.FullRowSelect = True
        listviewWL.HeaderStyle = ColumnHeaderStyle.None
        TipInfoEX.SetImage(listviewWL, Nothing)
        listviewWL.LabelWrap = False
        listviewWL.Location = New Point(13, 208)
        listviewWL.MultiSelect = False
        listviewWL.Name = "listviewWL"
        listviewWL.ShowGroups = False
        listviewWL.ShowItemToolTips = True
        listviewWL.Size = New Size(706, 111)
        listviewWL.TabIndex = 180
        TipInfoEX.SetText(listviewWL, Nothing)
        listviewWL.UseCompatibleStateImageBehavior = False
        listviewWL.View = View.Details
        ' 
        ' textboxWLAutoRefreshIdleInterval
        ' 
        textboxWLAutoRefreshIdleInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(textboxWLAutoRefreshIdleInterval, Nothing)
        textboxWLAutoRefreshIdleInterval.Location = New Point(675, 47)
        textboxWLAutoRefreshIdleInterval.MaxLength = 3
        textboxWLAutoRefreshIdleInterval.Name = "textboxWLAutoRefreshIdleInterval"
        textboxWLAutoRefreshIdleInterval.Size = New Size(44, 29)
        textboxWLAutoRefreshIdleInterval.TabIndex = 177
        TipInfoEX.SetText(textboxWLAutoRefreshIdleInterval, Nothing)
        textboxWLAutoRefreshIdleInterval.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblWLAutoRefreshIdleInterval
        ' 
        lblWLAutoRefreshIdleInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWLAutoRefreshIdleInterval.AutoSize = True
        lblWLAutoRefreshIdleInterval.CausesValidation = False
        TipInfoEX.SetImage(lblWLAutoRefreshIdleInterval, Nothing)
        lblWLAutoRefreshIdleInterval.Location = New Point(500, 52)
        lblWLAutoRefreshIdleInterval.Name = "lblWLAutoRefreshIdleInterval"
        lblWLAutoRefreshIdleInterval.RightToLeft = RightToLeft.No
        lblWLAutoRefreshIdleInterval.Size = New Size(181, 21)
        lblWLAutoRefreshIdleInterval.TabIndex = 183
        lblWLAutoRefreshIdleInterval.Text = "AutoRefresh Idle Interval"
        TipInfoEX.SetText(lblWLAutoRefreshIdleInterval, "Refresh Only When Folder Idle For 20-240 Seconds")
        lblWLAutoRefreshIdleInterval.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblWLAutoRefreshInterval
        ' 
        lblWLAutoRefreshInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWLAutoRefreshInterval.AutoSize = True
        lblWLAutoRefreshInterval.CausesValidation = False
        TipInfoEX.SetImage(lblWLAutoRefreshInterval, Nothing)
        lblWLAutoRefreshInterval.Location = New Point(529, 17)
        lblWLAutoRefreshInterval.Name = "lblWLAutoRefreshInterval"
        lblWLAutoRefreshInterval.RightToLeft = RightToLeft.No
        lblWLAutoRefreshInterval.Size = New Size(152, 21)
        lblWLAutoRefreshInterval.TabIndex = 182
        lblWLAutoRefreshInterval.Text = "AutoRefresh Interval"
        TipInfoEX.SetText(lblWLAutoRefreshInterval, "Check For Changes Every 1-90 Minutes")
        lblWLAutoRefreshInterval.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' checkboxWLShowFilePathToolTips
        ' 
        checkboxWLShowFilePathToolTips.AutoSize = True
        TipInfoEX.SetImage(checkboxWLShowFilePathToolTips, Nothing)
        checkboxWLShowFilePathToolTips.Location = New Point(13, 95)
        checkboxWLShowFilePathToolTips.Name = "checkboxWLShowFilePathToolTips"
        checkboxWLShowFilePathToolTips.Size = New Size(200, 25)
        checkboxWLShowFilePathToolTips.TabIndex = 172
        TipInfoEX.SetText(checkboxWLShowFilePathToolTips, "Show Full File Path In ToolTip")
        checkboxWLShowFilePathToolTips.Text = "Show File Path In ToolTip"
        checkboxWLShowFilePathToolTips.UseVisualStyleBackColor = True
        ' 
        ' lblWLMaxLinksPerFolder
        ' 
        lblWLMaxLinksPerFolder.AutoSize = True
        lblWLMaxLinksPerFolder.CausesValidation = False
        TipInfoEX.SetImage(lblWLMaxLinksPerFolder, Nothing)
        lblWLMaxLinksPerFolder.Location = New Point(54, 51)
        lblWLMaxLinksPerFolder.Name = "lblWLMaxLinksPerFolder"
        lblWLMaxLinksPerFolder.RightToLeft = RightToLeft.No
        lblWLMaxLinksPerFolder.Size = New Size(199, 21)
        lblWLMaxLinksPerFolder.TabIndex = 176
        lblWLMaxLinksPerFolder.Text = "Max Menu Items Per Folder"
        TipInfoEX.SetText(lblWLMaxLinksPerFolder, "1-100")
        lblWLMaxLinksPerFolder.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblWLStartUpDelay
        ' 
        lblWLStartUpDelay.AutoSize = True
        lblWLStartUpDelay.CausesValidation = False
        TipInfoEX.SetImage(lblWLStartUpDelay, Nothing)
        lblWLStartUpDelay.Location = New Point(54, 16)
        lblWLStartUpDelay.Name = "lblWLStartUpDelay"
        lblWLStartUpDelay.RightToLeft = RightToLeft.No
        lblWLStartUpDelay.Size = New Size(105, 21)
        lblWLStartUpDelay.TabIndex = 184
        lblWLStartUpDelay.Text = "StartUp Delay"
        TipInfoEX.SetText(lblWLStartUpDelay, "5-300, 0 = No Delay")
        lblWLStartUpDelay.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' checkboxWLAutoRefresh
        ' 
        checkboxWLAutoRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWLAutoRefresh.AutoSize = True
        checkboxWLAutoRefresh.CheckAlign = ContentAlignment.MiddleRight
        TipInfoEX.SetImage(checkboxWLAutoRefresh, Nothing)
        checkboxWLAutoRefresh.Location = New Point(554, 95)
        checkboxWLAutoRefresh.Name = "checkboxWLAutoRefresh"
        checkboxWLAutoRefresh.Size = New Size(165, 25)
        checkboxWLAutoRefresh.TabIndex = 178
        TipInfoEX.SetText(checkboxWLAutoRefresh, "Enable AutoRefresh For Last WinLink")
        checkboxWLAutoRefresh.Text = "Enable AutoRefresh"
        checkboxWLAutoRefresh.TextAlign = ContentAlignment.MiddleRight
        checkboxWLAutoRefresh.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowFileInfoToolTips
        ' 
        checkboxWLShowFileInfoToolTips.AutoSize = True
        TipInfoEX.SetImage(checkboxWLShowFileInfoToolTips, Nothing)
        checkboxWLShowFileInfoToolTips.Location = New Point(13, 135)
        checkboxWLShowFileInfoToolTips.Name = "checkboxWLShowFileInfoToolTips"
        checkboxWLShowFileInfoToolTips.Size = New Size(197, 25)
        checkboxWLShowFileInfoToolTips.TabIndex = 173
        TipInfoEX.SetText(checkboxWLShowFileInfoToolTips, "Show File Details In ToolTip")
        checkboxWLShowFileInfoToolTips.Text = "Show File Info In ToolTip"
        checkboxWLShowFileInfoToolTips.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowFolderPathToolTips
        ' 
        checkboxWLShowFolderPathToolTips.AutoSize = True
        TipInfoEX.SetImage(checkboxWLShowFolderPathToolTips, Nothing)
        checkboxWLShowFolderPathToolTips.Location = New Point(13, 115)
        checkboxWLShowFolderPathToolTips.Name = "checkboxWLShowFolderPathToolTips"
        checkboxWLShowFolderPathToolTips.Size = New Size(220, 25)
        checkboxWLShowFolderPathToolTips.TabIndex = 174
        TipInfoEX.SetText(checkboxWLShowFolderPathToolTips, "Show Full Directory Path In ToolTip")
        checkboxWLShowFolderPathToolTips.Text = "Show Folder Path In ToolTip"
        checkboxWLShowFolderPathToolTips.UseVisualStyleBackColor = True
        ' 
        ' lblWLAutoRefresh
        ' 
        lblWLAutoRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWLAutoRefresh.AutoSize = True
        lblWLAutoRefresh.Enabled = False
        lblWLAutoRefresh.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TipInfoEX.SetImage(lblWLAutoRefresh, Nothing)
        lblWLAutoRefresh.Location = New Point(560, 114)
        lblWLAutoRefresh.Name = "lblWLAutoRefresh"
        lblWLAutoRefresh.Size = New Size(159, 21)
        lblWLAutoRefresh.TabIndex = 179
        lblWLAutoRefresh.Text = "AutoRefresh Engaged"
        TipInfoEX.SetText(lblWLAutoRefresh, Nothing)
        lblWLAutoRefresh.TextAlign = ContentAlignment.MiddleLeft
        lblWLAutoRefresh.Visible = False
        ' 
        ' btnWLRefresh
        ' 
        btnWLRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(btnWLRefresh, Nothing)
        btnWLRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnWLRefresh.Location = New Point(11, 174)
        btnWLRefresh.Name = "btnWLRefresh"
        btnWLRefresh.Size = New Size(709, 32)
        btnWLRefresh.TabIndex = 171
        btnWLRefresh.TabStop = False
        TipInfoEX.SetText(btnWLRefresh, "Refresh")
        btnWLRefresh.Text = "FULL REFRESH"
        btnWLRefresh.UseVisualStyleBackColor = True
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
        Controls.Add(PanelAC)
        Controls.Add(PanelWL)
        Controls.Add(PanelApp)
        Controls.Add(PanelSS)
        Controls.Add(PanelWST)
        Controls.Add(PanelHK)
        Controls.Add(PanelHC)
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
        PanelAC.ResumeLayout(False)
        PanelAC.PerformLayout()
        groupboxACTopHourChimeType.ResumeLayout(False)
        groupboxACTopHourChimeType.PerformLayout()
        groupboxACAlarmChimeType.ResumeLayout(False)
        groupboxACAlarmChimeType.PerformLayout()
        CType(picboxACClock, ComponentModel.ISupportInitialize).EndInit()
        PanelWL.ResumeLayout(False)
        PanelWL.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents CMBlankForTextBoxes As ContextMenuStrip
    Private WithEvents textboxWLMaxLinksPerFolder As TextBox
    Private WithEvents Panel1 As Panel
    Private WithEvents checkboxWLShowNoMenu As CheckBox
    Private WithEvents textboxWLName As TextBox
    Private WithEvents checkboxWLShowMenuIcons As CheckBox
    Private WithEvents checkboxWLShowInTray As CheckBox
    Private WithEvents checkboxWLShowInMenu As CheckBox
    Private WithEvents comboboxWLFolderPlacement As ComboBox
    Private WithEvents comboboxWLFolderMode As ComboBox
    Private WithEvents comboboxWLSort As ComboBox
    Private WithEvents textboxWLRoot As TextBox
    Private WithEvents btnWLSelectFolder As Button
    Private WithEvents btnWLCancel As Button
    Private WithEvents btnWLSet As Button
    Private WithEvents checkboxWLUseDefaultIcon As CheckBox
    Private WithEvents LblWLSortOrder As Label
    Private WithEvents LblWLFolderMode As Label
    Private WithEvents LblWLFolderPlacement As Label
    Private WithEvents LblWLDisplayName As Label
    Private WithEvents lblWLRoot As Label
    Private WithEvents textboxWLStartUpDelay As TextBox
    Private WithEvents textboxWLAutoRefreshInterval As TextBox
    Private WithEvents listviewWL As ListView
    Private WithEvents textboxWLAutoRefreshIdleInterval As TextBox
    Private WithEvents lblWLAutoRefreshIdleInterval As Label
    Private WithEvents lblWLAutoRefreshInterval As Label
    Private WithEvents checkboxWLShowFilePathToolTips As CheckBox
    Private WithEvents lblWLMaxLinksPerFolder As Label
    Private WithEvents lblWLStartUpDelay As Label
    Private WithEvents checkboxWLAutoRefresh As CheckBox
    Private WithEvents checkboxWLShowFileInfoToolTips As CheckBox
    Private WithEvents checkboxWLShowFolderPathToolTips As CheckBox
    Private WithEvents lblWLAutoRefresh As Label
    Private WithEvents btnWLRefresh As Button
    Private WithEvents lblACAlarmChime As Label
    Private WithEvents lblACOffHourChimePath As Label
    Private WithEvents lblACOffHourChime As Label
    Private WithEvents btnACOffHourChimeManual As Button
    Private WithEvents lblACTopHourChime As Label
    Private WithEvents btnACAlarmCancel As Button
    Private WithEvents lblACTopHourChimePath As Label
    Private WithEvents lblACAlarmChimePath As Label
    Private WithEvents checkboxACBottomHourAfterChimeEnabled As CheckBox
    Private WithEvents checkboxACFirstQuarterHourAfterChimeEnabled As CheckBox
    Private WithEvents checkboxACThirdQuarterHourBeforeChimeEnabled As CheckBox
    Private WithEvents checkboxACFirstQuarterHourBeforeChimeEnabled As CheckBox
    Private WithEvents checkboxACThirdQuarterHourAfterChimeEnabled As CheckBox
    Private WithEvents checkboxACBottomHourBeforeChimeEnabled As CheckBox
    Private WithEvents btnACMute As Button
    Private WithEvents textboxACAlarmTimer As TextBox
    Private WithEvents groupboxACTopHourChimeType As GroupBox
    Private WithEvents radiobtnACTopHourChimeSimple As RadioButton
    Private WithEvents radiobtnACTopHourChimeExtended As RadioButton
    Private WithEvents radiobtnACTopHourChimeHourTick As RadioButton
    Private WithEvents btnACOffHourChimeDefault As Button
    Private WithEvents btnACTopHourChimeDefault As Button
    Private WithEvents textboxACAlarmTime As TextBox
    Private WithEvents btnACTopHourChimeManual As Button
    Private WithEvents checkboxACThirdQuarterHourChimeEnabled As CheckBox
    Private WithEvents checkboxACBottomHourChimeEnabled As CheckBox
    Private WithEvents checkboxACFirstQuarterHourChimeEnabled As CheckBox
    Private WithEvents checkboxACTopHourAfterChimeEnabled As CheckBox
    Private WithEvents checkboxACTopHourChimeEnabled As CheckBox
    Private WithEvents checkboxACTopHourBeforeChimeEnabled As CheckBox
    Private WithEvents groupboxACAlarmChimeType As GroupBox
    Private WithEvents radiobtnACAlarmChimeSimple As RadioButton
    Private WithEvents radiobtnACAlarmChimeForever As RadioButton
    Private WithEvents radiobtnACAlarmChimeExtended As RadioButton
    Private WithEvents btnACAlarmSet As Button
    Private WithEvents checkboxACAlarmRecurring As CheckBox
    Private WithEvents LblACTimer As Label
    Private WithEvents btnACTopHourChimePlay As Button
    Private WithEvents btnACOffHourChimePlay As Button
    Private WithEvents LblACTime As Label
    Private WithEvents picboxACClock As PictureBox
    Private WithEvents btnACAlarmChimeDefault As Button
    Private WithEvents btnACAlarmChimePlay As Button
    Private WithEvents btnACAlarmChimeManual As Button
End Class