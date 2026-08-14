Partial Friend Class MainForm
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then components.Dispose
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblWLAutoRefreshIdleInterval = New Label()
        lblWLAutoRefreshInterval = New Label()
        lblWLMaxLinksPerFolder = New Label()
        lblWLStartUpDelay = New Label()
        cmWST = New ContextMenuStrip(components)
        cmiWSTCancelStartUp = New ToolStripMenuItem()
        cmiWSTACAlarmCancel = New ToolStripMenuItem()
        cmseparatorWSTCancel = New ToolStripSeparator()
        cmseparatorWSTTopSpacer = New ToolStripSeparator()
        cmiWSTScreenSaverActivate = New ToolStripMenuItem()
        cmiWSTScreenSaverEnabled = New ToolStripMenuItem()
        cmseparatorWSTWLTop = New ToolStripSeparator()
        cmseparatorWSTWLBottom = New ToolStripSeparator()
        cmiWSTClock = New ToolStripMenuItem()
        cmiWSTAC = New ToolStripMenuItem()
        cmseparatorWSTShutDownOptions = New ToolStripSeparator()
        cmiWSTShutDown = New ToolStripMenuItem()
        cmiWSTHibernate = New ToolStripMenuItem()
        cmiWSTSleep = New ToolStripMenuItem()
        cmiWSTReStart = New ToolStripMenuItem()
        cmiWSTLogOff = New ToolStripMenuItem()
        cmiWSTLock = New ToolStripMenuItem()
        cmseparatorWSTSettings = New ToolStripSeparator()
        cmiWSTHelp = New ToolStripMenuItem()
        cmiWSTLog = New ToolStripMenuItem()
        cmiWSTSettings = New ToolStripMenuItem()
        toolStripSeparator5 = New ToolStripSeparator()
        cmiWSTClose = New ToolStripMenuItem()
        cmiWSTCloseAll = New ToolStripMenuItem()
        btnSettingsSave = New Button()
        btnClose = New Button()
        btnSettingsRestore = New Button()
        tabcontrolSettings = New TabControl()
        tabpageWST = New TabPage()
        LblTheme = New Skye.UI.Label()
        CoBoxTheme = New Skye.UI.ComboBox()
        checkboxWSTShowSleep = New CheckBox()
        checkboxWSTSSToolEnabled = New CheckBox()
        checkboxWSTShowLog = New CheckBox()
        checkboxWSTShowReStart = New CheckBox()
        checkboxWSTShowShutDown = New CheckBox()
        checkboxWSTShowHibernate = New CheckBox()
        checkboxWSTShowLogOff = New CheckBox()
        checkboxWSTShowLockWorkSpace = New CheckBox()
        checkboxWSTShowAC = New CheckBox()
        checkboxWSTShowHelp = New CheckBox()
        checkboxWSTShowClock = New CheckBox()
        lblLoadOnOSStartupPath = New Label()
        checkboxWSTShowWLTray = New CheckBox()
        checkboxWSTShowWLMenu = New CheckBox()
        groupboxWSTSS = New GroupBox()
        btnWSTScreenSaverEnabled = New RadioButton()
        comboboxWSTSSStartUp = New ComboBox()
        label36 = New Label()
        checkboxWSTScreenSaverEnableOnActivate = New CheckBox()
        checkboxWSTShowScreenSaverEnabled = New CheckBox()
        checkboxWSTShowScreenSaverActivate = New CheckBox()
        checkboxWSTShowScreenSaverIcon = New CheckBox()
        btnLoadOnOSStartupPath = New Button()
        checkboxLoadOnOSStartup = New CheckBox()
        txbxLoadOnOSStartupArgs = New TextBox()
        checkboxWSTEnabled = New CheckBox()
        ChkBoxThemeAuto = New CheckBox()
        tabpageAC = New TabPage()
        lblACAlarmChime = New Label()
        lblACOffHourChimePath = New Label()
        lblACOffHourChime = New Label()
        btnACOffHourChimeManual = New Button()
        lblACTopHourChime = New Label()
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
        radiobtnACTopHourChimeSimple = New RadioButton()
        radiobtnACTopHourChimeExtended = New RadioButton()
        radiobtnACTopHourChimeHourTick = New RadioButton()
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
        label13 = New Label()
        btnACTopHourChimePlay = New Button()
        btnACOffHourChimePlay = New Button()
        label32 = New Label()
        picboxACClock = New PictureBox()
        btnACAlarmChimeDefault = New Button()
        btnACAlarmChimePlay = New Button()
        btnACAlarmChimeManual = New Button()
        tabpageWL = New TabPage()
        panelWL = New Panel()
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
        label28 = New Label()
        label29 = New Label()
        label30 = New Label()
        label2 = New Label()
        lblWLRoot = New Label()
        textboxWLMaxLinksPerFolder = New TextBox()
        textboxWLStartUpDelay = New TextBox()
        textboxWLAutoRefreshInterval = New TextBox()
        listviewWL = New ListView()
        cmlistviewWL = New ContextMenuStrip(components)
        cmiWLMoveUp = New ToolStripMenuItem()
        cmiWLMoveDown = New ToolStripMenuItem()
        toolStripSeparator11 = New ToolStripSeparator()
        cmiWLNew = New ToolStripMenuItem()
        toolStripSeparator6 = New ToolStripSeparator()
        cmiWLDelete = New ToolStripMenuItem()
        textboxWLAutoRefreshIdleInterval = New TextBox()
        checkboxWLShowFilePathToolTips = New CheckBox()
        checkboxWLAutoRefresh = New CheckBox()
        checkboxWLShowFileInfoToolTips = New CheckBox()
        checkboxWLShowFolderPathToolTips = New CheckBox()
        lblWLAutoRefresh = New Label()
        btnWLRefresh = New Button()
        tabpageHC = New TabPage()
        comboboxHCRight = New ComboBox()
        comboboxHCMiddle = New ComboBox()
        comboboxHCDouble = New ComboBox()
        comboboxHCLeft = New ComboBox()
        groupBox2 = New GroupBox()
        radiobtnHCWL = New RadioButton()
        radiobtnHCWSTSS = New RadioButton()
        radiobtnHCWST = New RadioButton()
        label17 = New Label()
        label12 = New Label()
        label16 = New Label()
        label15 = New Label()
        tabpageHK = New TabPage()
        textboxHKWL = New TextBox()
        textboxHKWSTClock = New TextBox()
        textboxHKWSTLockWorkSpace = New TextBox()
        btnHKSet = New Button()
        btnHKReset = New Button()
        textboxHKWSTScreenSaver = New TextBox()
        btnHKEnabled = New Button()
        lblHKWL = New Label()
        lblHKWSTClock = New Label()
        lblHKWSTStopWatch = New Label()
        lblHKWSTLockWorkSpace = New Label()
        lblHKWSTScreenSaver = New Label()
        btnHKWLDisable = New Button()
        btnHKWSTClockDisable = New Button()
        btnHKWSTLockWorkSpaceDisable = New Button()
        btnHKWSTScreenSaverDisable = New Button()
        btnErrorTest = New Button()
        btnClockTest = New Button()
        btnInfo = New Button()
        btnLog = New Button()
        cmWSTScreenSaver = New ContextMenuStrip(components)
        cmiScreenSaverActivate = New ToolStripMenuItem()
        cmiScreenSaverEnabled = New ToolStripMenuItem()
        toolStripSeparator1 = New ToolStripSeparator()
        cmiScreenSaverSettings = New ToolStripMenuItem()
        toolStripSeparator12 = New ToolStripSeparator()
        cmiScreenSaverClose = New ToolStripMenuItem()
        cmiScreenSaverCloseAll = New ToolStripMenuItem()
        tableLayoutPanel2 = New TableLayoutPanel()
        TipInfoEX = New Skye.UI.ToolTipEX(components)
        BtnSettings = New Button()
        TipHCEX = New Skye.UI.ToolTipEX(components)
        cmWST.SuspendLayout()
        tabcontrolSettings.SuspendLayout()
        tabpageWST.SuspendLayout()
        groupboxWSTSS.SuspendLayout()
        tabpageAC.SuspendLayout()
        groupboxACTopHourChimeType.SuspendLayout()
        groupboxACAlarmChimeType.SuspendLayout()
        CType(picboxACClock, ComponentModel.ISupportInitialize).BeginInit()
        tabpageWL.SuspendLayout()
        panelWL.SuspendLayout()
        cmlistviewWL.SuspendLayout()
        tabpageHC.SuspendLayout()
        groupBox2.SuspendLayout()
        tabpageHK.SuspendLayout()
        cmWSTScreenSaver.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblWLAutoRefreshIdleInterval
        ' 
        lblWLAutoRefreshIdleInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWLAutoRefreshIdleInterval.CausesValidation = False
        TipHCEX.SetImage(lblWLAutoRefreshIdleInterval, Nothing)
        TipInfoEX.SetImage(lblWLAutoRefreshIdleInterval, Nothing)
        lblWLAutoRefreshIdleInterval.Location = New Point(418, 36)
        lblWLAutoRefreshIdleInterval.Name = "lblWLAutoRefreshIdleInterval"
        lblWLAutoRefreshIdleInterval.RightToLeft = RightToLeft.No
        lblWLAutoRefreshIdleInterval.Size = New Size(153, 21)
        lblWLAutoRefreshIdleInterval.TabIndex = 104
        TipHCEX.SetText(lblWLAutoRefreshIdleInterval, Nothing)
        lblWLAutoRefreshIdleInterval.Text = "AutoRefresh Idle Interval"
        TipInfoEX.SetText(lblWLAutoRefreshIdleInterval, "Refresh Only When Folder Idle For 20-240 Seconds")
        lblWLAutoRefreshIdleInterval.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblWLAutoRefreshInterval
        ' 
        lblWLAutoRefreshInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWLAutoRefreshInterval.CausesValidation = False
        TipHCEX.SetImage(lblWLAutoRefreshInterval, Nothing)
        TipInfoEX.SetImage(lblWLAutoRefreshInterval, Nothing)
        lblWLAutoRefreshInterval.Location = New Point(445, 11)
        lblWLAutoRefreshInterval.Name = "lblWLAutoRefreshInterval"
        lblWLAutoRefreshInterval.RightToLeft = RightToLeft.No
        lblWLAutoRefreshInterval.Size = New Size(126, 21)
        lblWLAutoRefreshInterval.TabIndex = 102
        TipHCEX.SetText(lblWLAutoRefreshInterval, Nothing)
        lblWLAutoRefreshInterval.Text = "AutoRefresh Interval"
        TipInfoEX.SetText(lblWLAutoRefreshInterval, "Check For Changes Every 1-90 Minutes")
        lblWLAutoRefreshInterval.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblWLMaxLinksPerFolder
        ' 
        lblWLMaxLinksPerFolder.CausesValidation = False
        TipHCEX.SetImage(lblWLMaxLinksPerFolder, Nothing)
        TipInfoEX.SetImage(lblWLMaxLinksPerFolder, Nothing)
        lblWLMaxLinksPerFolder.Location = New Point(47, 35)
        lblWLMaxLinksPerFolder.Name = "lblWLMaxLinksPerFolder"
        lblWLMaxLinksPerFolder.RightToLeft = RightToLeft.No
        lblWLMaxLinksPerFolder.Size = New Size(176, 21)
        lblWLMaxLinksPerFolder.TabIndex = 20
        TipHCEX.SetText(lblWLMaxLinksPerFolder, Nothing)
        lblWLMaxLinksPerFolder.Text = "Max Menu Items Per Folder"
        TipInfoEX.SetText(lblWLMaxLinksPerFolder, "1-100")
        lblWLMaxLinksPerFolder.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblWLStartUpDelay
        ' 
        lblWLStartUpDelay.CausesValidation = False
        TipHCEX.SetImage(lblWLStartUpDelay, Nothing)
        TipInfoEX.SetImage(lblWLStartUpDelay, Nothing)
        lblWLStartUpDelay.Location = New Point(47, 10)
        lblWLStartUpDelay.Name = "lblWLStartUpDelay"
        lblWLStartUpDelay.RightToLeft = RightToLeft.No
        lblWLStartUpDelay.Size = New Size(89, 21)
        lblWLStartUpDelay.TabIndex = 106
        TipHCEX.SetText(lblWLStartUpDelay, Nothing)
        lblWLStartUpDelay.Text = "StartUp Delay"
        TipInfoEX.SetText(lblWLStartUpDelay, "5-300, 0 = No Delay")
        lblWLStartUpDelay.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmWST
        ' 
        cmWST.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TipInfoEX.SetImage(cmWST, Nothing)
        TipHCEX.SetImage(cmWST, Nothing)
        cmWST.Items.AddRange(New ToolStripItem() {cmiWSTCancelStartUp, cmiWSTACAlarmCancel, cmseparatorWSTCancel, cmseparatorWSTTopSpacer, cmiWSTScreenSaverActivate, cmiWSTScreenSaverEnabled, cmseparatorWSTWLTop, cmseparatorWSTWLBottom, cmiWSTClock, cmiWSTAC, cmseparatorWSTShutDownOptions, cmiWSTShutDown, cmiWSTHibernate, cmiWSTSleep, cmiWSTReStart, cmiWSTLogOff, cmiWSTLock, cmseparatorWSTSettings, cmiWSTHelp, cmiWSTLog, cmiWSTSettings, toolStripSeparator5, cmiWSTClose, cmiWSTCloseAll})
        cmWST.Name = "contextmenuWorkSpaceTools"
        cmWST.ShowItemToolTips = False
        cmWST.Size = New Size(240, 492)
        TipInfoEX.SetText(cmWST, Nothing)
        TipHCEX.SetText(cmWST, Nothing)
        ' 
        ' cmiWSTCancelStartUp
        ' 
        cmiWSTCancelStartUp.Image = My.Resources.Resources.imageClose
        cmiWSTCancelStartUp.Name = "cmiWSTCancelStartUp"
        cmiWSTCancelStartUp.Size = New Size(239, 26)
        cmiWSTCancelStartUp.Text = "CANCEL STARTUP"
        cmiWSTCancelStartUp.Visible = False
        ' 
        ' cmiWSTACAlarmCancel
        ' 
        cmiWSTACAlarmCancel.Image = My.Resources.Resources.imageClose
        cmiWSTACAlarmCancel.Name = "cmiWSTACAlarmCancel"
        cmiWSTACAlarmCancel.Size = New Size(239, 26)
        cmiWSTACAlarmCancel.Text = "CANCEL ALARM"
        cmiWSTACAlarmCancel.Visible = False
        ' 
        ' cmseparatorWSTCancel
        ' 
        cmseparatorWSTCancel.AutoSize = False
        cmseparatorWSTCancel.Name = "cmseparatorWSTCancel"
        cmseparatorWSTCancel.Size = New Size(236, 6)
        cmseparatorWSTCancel.Visible = False
        ' 
        ' cmseparatorWSTTopSpacer
        ' 
        cmseparatorWSTTopSpacer.AutoSize = False
        cmseparatorWSTTopSpacer.Name = "cmseparatorWSTTopSpacer"
        cmseparatorWSTTopSpacer.Size = New Size(236, 0)
        ' 
        ' cmiWSTScreenSaverActivate
        ' 
        cmiWSTScreenSaverActivate.Name = "cmiWSTScreenSaverActivate"
        cmiWSTScreenSaverActivate.Size = New Size(239, 26)
        cmiWSTScreenSaverActivate.Text = "Activate Screen Saver"
        ' 
        ' cmiWSTScreenSaverEnabled
        ' 
        cmiWSTScreenSaverEnabled.Name = "cmiWSTScreenSaverEnabled"
        cmiWSTScreenSaverEnabled.Size = New Size(239, 26)
        ' 
        ' cmseparatorWSTWLTop
        ' 
        cmseparatorWSTWLTop.AutoSize = False
        cmseparatorWSTWLTop.Name = "cmseparatorWSTWLTop"
        cmseparatorWSTWLTop.Size = New Size(236, 0)
        ' 
        ' cmseparatorWSTWLBottom
        ' 
        cmseparatorWSTWLBottom.AutoSize = False
        cmseparatorWSTWLBottom.Name = "cmseparatorWSTWLBottom"
        cmseparatorWSTWLBottom.Size = New Size(236, 0)
        ' 
        ' cmiWSTClock
        ' 
        cmiWSTClock.Image = My.Resources.Resources.imageWSTClock
        cmiWSTClock.Name = "cmiWSTClock"
        cmiWSTClock.Size = New Size(239, 26)
        cmiWSTClock.Text = "Clock"
        ' 
        ' cmiWSTAC
        ' 
        cmiWSTAC.Image = My.Resources.Resources.imageAC
        cmiWSTAC.Name = "cmiWSTAC"
        cmiWSTAC.ShortcutKeyDisplayString = ""
        cmiWSTAC.ShowShortcutKeys = False
        cmiWSTAC.Size = New Size(239, 26)
        cmiWSTAC.Text = "Alarm / Chime"
        ' 
        ' cmseparatorWSTShutDownOptions
        ' 
        cmseparatorWSTShutDownOptions.AutoSize = False
        cmseparatorWSTShutDownOptions.ForeColor = SystemColors.ControlText
        cmseparatorWSTShutDownOptions.Name = "cmseparatorWSTShutDownOptions"
        cmseparatorWSTShutDownOptions.Size = New Size(236, 6)
        ' 
        ' cmiWSTShutDown
        ' 
        cmiWSTShutDown.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTShutDown.ForeColor = Color.Firebrick
        cmiWSTShutDown.Image = My.Resources.Resources.imageClose
        cmiWSTShutDown.Name = "cmiWSTShutDown"
        cmiWSTShutDown.Size = New Size(239, 26)
        cmiWSTShutDown.Text = "Shut Down"
        cmiWSTShutDown.Visible = False
        ' 
        ' cmiWSTHibernate
        ' 
        cmiWSTHibernate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTHibernate.ForeColor = Color.Firebrick
        cmiWSTHibernate.Image = My.Resources.Resources.imageWindowHide
        cmiWSTHibernate.Name = "cmiWSTHibernate"
        cmiWSTHibernate.Size = New Size(239, 26)
        cmiWSTHibernate.Text = "Hibernate"
        cmiWSTHibernate.Visible = False
        ' 
        ' cmiWSTSleep
        ' 
        cmiWSTSleep.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTSleep.ForeColor = Color.Firebrick
        cmiWSTSleep.Image = My.Resources.Resources.imageWindowHide
        cmiWSTSleep.Name = "cmiWSTSleep"
        cmiWSTSleep.Size = New Size(239, 26)
        cmiWSTSleep.Text = "Sleep"
        cmiWSTSleep.Visible = False
        ' 
        ' cmiWSTReStart
        ' 
        cmiWSTReStart.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTReStart.ForeColor = Color.DarkCyan
        cmiWSTReStart.Image = My.Resources.Resources.imageGoReStart
        cmiWSTReStart.Name = "cmiWSTReStart"
        cmiWSTReStart.Size = New Size(239, 26)
        cmiWSTReStart.Text = "ReStart"
        cmiWSTReStart.Visible = False
        ' 
        ' cmiWSTLogOff
        ' 
        cmiWSTLogOff.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTLogOff.ForeColor = Color.Goldenrod
        cmiWSTLogOff.Image = My.Resources.Resources.imageWSTSessionKey
        cmiWSTLogOff.Name = "cmiWSTLogOff"
        cmiWSTLogOff.Size = New Size(239, 26)
        cmiWSTLogOff.Text = "Log Off"
        cmiWSTLogOff.Visible = False
        ' 
        ' cmiWSTLock
        ' 
        cmiWSTLock.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTLock.ForeColor = Color.Goldenrod
        cmiWSTLock.Image = My.Resources.Resources.imageWSTSessionKey
        cmiWSTLock.Name = "cmiWSTLock"
        cmiWSTLock.Size = New Size(239, 26)
        cmiWSTLock.Text = "Lock WorkSpace"
        cmiWSTLock.Visible = False
        ' 
        ' cmseparatorWSTSettings
        ' 
        cmseparatorWSTSettings.AutoSize = False
        cmseparatorWSTSettings.Name = "cmseparatorWSTSettings"
        cmseparatorWSTSettings.Size = New Size(236, 6)
        ' 
        ' cmiWSTHelp
        ' 
        cmiWSTHelp.Image = My.Resources.Resources.ImageInfo16
        cmiWSTHelp.Name = "cmiWSTHelp"
        cmiWSTHelp.Size = New Size(239, 26)
        cmiWSTHelp.Text = "Help"
        cmiWSTHelp.ToolTipText = "RightClick = Show Maximized"
        ' 
        ' cmiWSTLog
        ' 
        cmiWSTLog.Image = My.Resources.Resources.imageLog
        cmiWSTLog.Name = "cmiWSTLog"
        cmiWSTLog.Size = New Size(239, 26)
        cmiWSTLog.Text = "Log"
        ' 
        ' cmiWSTSettings
        ' 
        cmiWSTSettings.Image = My.Resources.Resources.imageSettings
        cmiWSTSettings.Name = "cmiWSTSettings"
        cmiWSTSettings.Size = New Size(239, 26)
        cmiWSTSettings.Text = "Settings"
        ' 
        ' toolStripSeparator5
        ' 
        toolStripSeparator5.Name = "toolStripSeparator5"
        toolStripSeparator5.Size = New Size(236, 6)
        ' 
        ' cmiWSTClose
        ' 
        cmiWSTClose.Image = My.Resources.Resources.imageClose
        cmiWSTClose.Name = "cmiWSTClose"
        cmiWSTClose.Size = New Size(239, 26)
        cmiWSTClose.Text = "Close WorkSpace Tools"
        ' 
        ' cmiWSTCloseAll
        ' 
        cmiWSTCloseAll.Image = My.Resources.Resources.imageClose
        cmiWSTCloseAll.Name = "cmiWSTCloseAll"
        cmiWSTCloseAll.Size = New Size(239, 26)
        cmiWSTCloseAll.Text = "Exit SkyeTools"
        ' 
        ' btnSettingsSave
        ' 
        btnSettingsSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TipHCEX.SetImage(btnSettingsSave, Nothing)
        btnSettingsSave.Image = My.Resources.Resources.imageSave
        TipInfoEX.SetImage(btnSettingsSave, Nothing)
        btnSettingsSave.ImageAlign = ContentAlignment.TopLeft
        btnSettingsSave.Location = New Point(11, 420)
        btnSettingsSave.Name = "btnSettingsSave"
        btnSettingsSave.Size = New Size(62, 46)
        btnSettingsSave.TabIndex = 5
        btnSettingsSave.TabStop = False
        TipInfoEX.SetText(btnSettingsSave, "Save All Settings")
        TipHCEX.SetText(btnSettingsSave, Nothing)
        btnSettingsSave.Text = "Save"
        btnSettingsSave.TextAlign = ContentAlignment.BottomRight
        btnSettingsSave.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TipHCEX.SetImage(btnClose, Nothing)
        btnClose.Image = My.Resources.Resources.imageClose
        TipInfoEX.SetImage(btnClose, Nothing)
        btnClose.ImageAlign = ContentAlignment.MiddleLeft
        btnClose.Location = New Point(428, 420)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(198, 46)
        btnClose.TabIndex = 10
        TipInfoEX.SetText(btnClose, "Close Window")
        TipHCEX.SetText(btnClose, Nothing)
        btnClose.Text = "Close"
        btnClose.TextAlign = ContentAlignment.MiddleRight
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnSettingsRestore
        ' 
        btnSettingsRestore.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TipHCEX.SetImage(btnSettingsRestore, Nothing)
        btnSettingsRestore.Image = My.Resources.Resources.imageRestore
        TipInfoEX.SetImage(btnSettingsRestore, Nothing)
        btnSettingsRestore.ImageAlign = ContentAlignment.TopLeft
        btnSettingsRestore.Location = New Point(72, 420)
        btnSettingsRestore.Name = "btnSettingsRestore"
        btnSettingsRestore.Size = New Size(62, 46)
        btnSettingsRestore.TabIndex = 5
        btnSettingsRestore.TabStop = False
        TipInfoEX.SetText(btnSettingsRestore, "Restore All Settings")
        TipHCEX.SetText(btnSettingsRestore, Nothing)
        btnSettingsRestore.Text = "Restore"
        btnSettingsRestore.TextAlign = ContentAlignment.BottomRight
        btnSettingsRestore.UseVisualStyleBackColor = True
        ' 
        ' tabcontrolSettings
        ' 
        tabcontrolSettings.Controls.Add(tabpageWST)
        tabcontrolSettings.Controls.Add(tabpageAC)
        tabcontrolSettings.Controls.Add(tabpageWL)
        tabcontrolSettings.Controls.Add(tabpageHC)
        tabcontrolSettings.Controls.Add(tabpageHK)
        tabcontrolSettings.HotTrack = True
        TipInfoEX.SetImage(tabcontrolSettings, Nothing)
        TipHCEX.SetImage(tabcontrolSettings, Nothing)
        tabcontrolSettings.Location = New Point(7, 6)
        tabcontrolSettings.Margin = New Padding(0)
        tabcontrolSettings.Multiline = True
        tabcontrolSettings.Name = "tabcontrolSettings"
        tabcontrolSettings.Padding = New Point(0, 0)
        tabcontrolSettings.SelectedIndex = 0
        tabcontrolSettings.Size = New Size(626, 403)
        tabcontrolSettings.SizeMode = TabSizeMode.FillToRight
        tabcontrolSettings.TabIndex = 0
        TipInfoEX.SetText(tabcontrolSettings, Nothing)
        TipHCEX.SetText(tabcontrolSettings, Nothing)
        ' 
        ' tabpageWST
        ' 
        tabpageWST.Controls.Add(LblTheme)
        tabpageWST.Controls.Add(CoBoxTheme)
        tabpageWST.Controls.Add(checkboxWSTShowSleep)
        tabpageWST.Controls.Add(checkboxWSTSSToolEnabled)
        tabpageWST.Controls.Add(checkboxWSTShowLog)
        tabpageWST.Controls.Add(checkboxWSTShowReStart)
        tabpageWST.Controls.Add(checkboxWSTShowShutDown)
        tabpageWST.Controls.Add(checkboxWSTShowHibernate)
        tabpageWST.Controls.Add(checkboxWSTShowLogOff)
        tabpageWST.Controls.Add(checkboxWSTShowLockWorkSpace)
        tabpageWST.Controls.Add(checkboxWSTShowAC)
        tabpageWST.Controls.Add(checkboxWSTShowHelp)
        tabpageWST.Controls.Add(checkboxWSTShowClock)
        tabpageWST.Controls.Add(lblLoadOnOSStartupPath)
        tabpageWST.Controls.Add(checkboxWSTShowWLTray)
        tabpageWST.Controls.Add(checkboxWSTShowWLMenu)
        tabpageWST.Controls.Add(groupboxWSTSS)
        tabpageWST.Controls.Add(btnLoadOnOSStartupPath)
        tabpageWST.Controls.Add(checkboxLoadOnOSStartup)
        tabpageWST.Controls.Add(txbxLoadOnOSStartupArgs)
        tabpageWST.Controls.Add(checkboxWSTEnabled)
        tabpageWST.Controls.Add(ChkBoxThemeAuto)
        TipHCEX.SetImage(tabpageWST, Nothing)
        TipInfoEX.SetImage(tabpageWST, Nothing)
        tabpageWST.Location = New Point(4, 26)
        tabpageWST.Name = "tabpageWST"
        tabpageWST.Padding = New Padding(3)
        tabpageWST.Size = New Size(618, 373)
        tabpageWST.TabIndex = 0
        TipHCEX.SetText(tabpageWST, Nothing)
        TipInfoEX.SetText(tabpageWST, Nothing)
        tabpageWST.Text = "****WorkSpace Tools****"
        tabpageWST.UseVisualStyleBackColor = True
        ' 
        ' LblTheme
        ' 
        LblTheme.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        TipHCEX.SetImage(LblTheme, Nothing)
        TipInfoEX.SetImage(LblTheme, Nothing)
        LblTheme.Location = New Point(209, 3)
        LblTheme.Name = "LblTheme"
        LblTheme.Size = New Size(100, 23)
        LblTheme.TabIndex = 143
        TipInfoEX.SetText(LblTheme, Nothing)
        LblTheme.Text = "Theme"
        TipHCEX.SetText(LblTheme, Nothing)
        LblTheme.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CoBoxTheme
        ' 
        CoBoxTheme.FormattingEnabled = True
        TipInfoEX.SetImage(CoBoxTheme, Nothing)
        TipHCEX.SetImage(CoBoxTheme, Nothing)
        CoBoxTheme.Location = New Point(209, 43)
        CoBoxTheme.Name = "CoBoxTheme"
        CoBoxTheme.Size = New Size(166, 26)
        CoBoxTheme.TabIndex = 141
        TipInfoEX.SetText(CoBoxTheme, Nothing)
        TipHCEX.SetText(CoBoxTheme, Nothing)
        ' 
        ' checkboxWSTShowSleep
        ' 
        TipInfoEX.SetImage(checkboxWSTShowSleep, Nothing)
        TipHCEX.SetImage(checkboxWSTShowSleep, Nothing)
        checkboxWSTShowSleep.Location = New Point(5, 294)
        checkboxWSTShowSleep.Name = "checkboxWSTShowSleep"
        checkboxWSTShowSleep.Size = New Size(110, 21)
        checkboxWSTShowSleep.TabIndex = 53
        TipHCEX.SetText(checkboxWSTShowSleep, Nothing)
        TipInfoEX.SetText(checkboxWSTShowSleep, Nothing)
        checkboxWSTShowSleep.Text = "Show 'Sleep'"
        checkboxWSTShowSleep.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTSSToolEnabled
        ' 
        TipInfoEX.SetImage(checkboxWSTSSToolEnabled, Nothing)
        TipHCEX.SetImage(checkboxWSTSSToolEnabled, Nothing)
        checkboxWSTSSToolEnabled.Location = New Point(492, 179)
        checkboxWSTSSToolEnabled.Name = "checkboxWSTSSToolEnabled"
        checkboxWSTSSToolEnabled.RightToLeft = RightToLeft.Yes
        checkboxWSTSSToolEnabled.Size = New Size(104, 20)
        checkboxWSTSSToolEnabled.TabIndex = 135
        TipHCEX.SetText(checkboxWSTSSToolEnabled, Nothing)
        TipInfoEX.SetText(checkboxWSTSSToolEnabled, Nothing)
        checkboxWSTSSToolEnabled.Text = "Screen Saver"
        checkboxWSTSSToolEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowLog
        ' 
        TipInfoEX.SetImage(checkboxWSTShowLog, Nothing)
        TipHCEX.SetImage(checkboxWSTShowLog, Nothing)
        checkboxWSTShowLog.Location = New Point(148, 330)
        checkboxWSTShowLog.Name = "checkboxWSTShowLog"
        checkboxWSTShowLog.Size = New Size(95, 21)
        checkboxWSTShowLog.TabIndex = 68
        TipHCEX.SetText(checkboxWSTShowLog, Nothing)
        TipInfoEX.SetText(checkboxWSTShowLog, Nothing)
        checkboxWSTShowLog.Text = "Show 'Log'"
        checkboxWSTShowLog.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowReStart
        ' 
        TipInfoEX.SetImage(checkboxWSTShowReStart, Nothing)
        TipHCEX.SetImage(checkboxWSTShowReStart, Nothing)
        checkboxWSTShowReStart.Location = New Point(5, 276)
        checkboxWSTShowReStart.Name = "checkboxWSTShowReStart"
        checkboxWSTShowReStart.Size = New Size(110, 21)
        checkboxWSTShowReStart.TabIndex = 52
        TipHCEX.SetText(checkboxWSTShowReStart, Nothing)
        TipInfoEX.SetText(checkboxWSTShowReStart, Nothing)
        checkboxWSTShowReStart.Text = "Show 'ReStart'"
        checkboxWSTShowReStart.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowShutDown
        ' 
        TipInfoEX.SetImage(checkboxWSTShowShutDown, Nothing)
        TipHCEX.SetImage(checkboxWSTShowShutDown, Nothing)
        checkboxWSTShowShutDown.Location = New Point(5, 330)
        checkboxWSTShowShutDown.Name = "checkboxWSTShowShutDown"
        checkboxWSTShowShutDown.Size = New Size(130, 21)
        checkboxWSTShowShutDown.TabIndex = 55
        TipHCEX.SetText(checkboxWSTShowShutDown, Nothing)
        TipInfoEX.SetText(checkboxWSTShowShutDown, Nothing)
        checkboxWSTShowShutDown.Text = "Show 'Shut Down'"
        checkboxWSTShowShutDown.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowHibernate
        ' 
        TipInfoEX.SetImage(checkboxWSTShowHibernate, Nothing)
        TipHCEX.SetImage(checkboxWSTShowHibernate, Nothing)
        checkboxWSTShowHibernate.Location = New Point(5, 312)
        checkboxWSTShowHibernate.Name = "checkboxWSTShowHibernate"
        checkboxWSTShowHibernate.Size = New Size(125, 21)
        checkboxWSTShowHibernate.TabIndex = 54
        TipHCEX.SetText(checkboxWSTShowHibernate, Nothing)
        TipInfoEX.SetText(checkboxWSTShowHibernate, Nothing)
        checkboxWSTShowHibernate.Text = "Show 'Hibernate'"
        checkboxWSTShowHibernate.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowLogOff
        ' 
        TipInfoEX.SetImage(checkboxWSTShowLogOff, Nothing)
        TipHCEX.SetImage(checkboxWSTShowLogOff, Nothing)
        checkboxWSTShowLogOff.Location = New Point(5, 258)
        checkboxWSTShowLogOff.Name = "checkboxWSTShowLogOff"
        checkboxWSTShowLogOff.Size = New Size(114, 21)
        checkboxWSTShowLogOff.TabIndex = 51
        TipHCEX.SetText(checkboxWSTShowLogOff, Nothing)
        TipInfoEX.SetText(checkboxWSTShowLogOff, Nothing)
        checkboxWSTShowLogOff.Text = "Show 'Log Off'"
        checkboxWSTShowLogOff.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowLockWorkSpace
        ' 
        TipInfoEX.SetImage(checkboxWSTShowLockWorkSpace, Nothing)
        TipHCEX.SetImage(checkboxWSTShowLockWorkSpace, Nothing)
        checkboxWSTShowLockWorkSpace.Location = New Point(5, 240)
        checkboxWSTShowLockWorkSpace.Name = "checkboxWSTShowLockWorkSpace"
        checkboxWSTShowLockWorkSpace.Size = New Size(169, 21)
        checkboxWSTShowLockWorkSpace.TabIndex = 50
        TipHCEX.SetText(checkboxWSTShowLockWorkSpace, Nothing)
        TipInfoEX.SetText(checkboxWSTShowLockWorkSpace, Nothing)
        checkboxWSTShowLockWorkSpace.Text = "Show 'Lock WorkSpace'"
        checkboxWSTShowLockWorkSpace.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowAC
        ' 
        TipInfoEX.SetImage(checkboxWSTShowAC, Nothing)
        TipHCEX.SetImage(checkboxWSTShowAC, Nothing)
        checkboxWSTShowAC.Location = New Point(5, 200)
        checkboxWSTShowAC.Name = "checkboxWSTShowAC"
        checkboxWSTShowAC.Size = New Size(155, 21)
        checkboxWSTShowAC.TabIndex = 33
        TipHCEX.SetText(checkboxWSTShowAC, Nothing)
        TipInfoEX.SetText(checkboxWSTShowAC, Nothing)
        checkboxWSTShowAC.Text = "Show 'Alarm / Chime'"
        checkboxWSTShowAC.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowHelp
        ' 
        TipInfoEX.SetImage(checkboxWSTShowHelp, Nothing)
        TipHCEX.SetImage(checkboxWSTShowHelp, Nothing)
        checkboxWSTShowHelp.Location = New Point(148, 312)
        checkboxWSTShowHelp.Name = "checkboxWSTShowHelp"
        checkboxWSTShowHelp.Size = New Size(95, 21)
        checkboxWSTShowHelp.TabIndex = 65
        TipHCEX.SetText(checkboxWSTShowHelp, Nothing)
        TipInfoEX.SetText(checkboxWSTShowHelp, Nothing)
        checkboxWSTShowHelp.Text = "Show 'Help'"
        checkboxWSTShowHelp.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowClock
        ' 
        TipInfoEX.SetImage(checkboxWSTShowClock, Nothing)
        TipHCEX.SetImage(checkboxWSTShowClock, Nothing)
        checkboxWSTShowClock.Location = New Point(5, 182)
        checkboxWSTShowClock.Name = "checkboxWSTShowClock"
        checkboxWSTShowClock.Size = New Size(94, 21)
        checkboxWSTShowClock.TabIndex = 32
        TipHCEX.SetText(checkboxWSTShowClock, Nothing)
        TipInfoEX.SetText(checkboxWSTShowClock, Nothing)
        checkboxWSTShowClock.Text = "Show Clock"
        checkboxWSTShowClock.UseVisualStyleBackColor = True
        ' 
        ' lblLoadOnOSStartupPath
        ' 
        lblLoadOnOSStartupPath.BorderStyle = BorderStyle.FixedSingle
        TipHCEX.SetImage(lblLoadOnOSStartupPath, Nothing)
        TipInfoEX.SetImage(lblLoadOnOSStartupPath, Nothing)
        lblLoadOnOSStartupPath.Location = New Point(460, 22)
        lblLoadOnOSStartupPath.Name = "lblLoadOnOSStartupPath"
        lblLoadOnOSStartupPath.Size = New Size(150, 20)
        lblLoadOnOSStartupPath.TabIndex = 101
        TipHCEX.SetText(lblLoadOnOSStartupPath, Nothing)
        TipInfoEX.SetText(lblLoadOnOSStartupPath, "Path")
        lblLoadOnOSStartupPath.TextAlign = ContentAlignment.TopRight
        ' 
        ' checkboxWSTShowWLTray
        ' 
        TipInfoEX.SetImage(checkboxWSTShowWLTray, Nothing)
        TipHCEX.SetImage(checkboxWSTShowWLTray, Nothing)
        checkboxWSTShowWLTray.Location = New Point(5, 160)
        checkboxWSTShowWLTray.Name = "checkboxWSTShowWLTray"
        checkboxWSTShowWLTray.Size = New Size(145, 21)
        checkboxWSTShowWLTray.TabIndex = 31
        TipHCEX.SetText(checkboxWSTShowWLTray, Nothing)
        TipInfoEX.SetText(checkboxWSTShowWLTray, Nothing)
        checkboxWSTShowWLTray.Text = "Show WinLinks Tray Icon"
        checkboxWSTShowWLTray.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowWLMenu
        ' 
        TipInfoEX.SetImage(checkboxWSTShowWLMenu, Nothing)
        TipHCEX.SetImage(checkboxWSTShowWLMenu, Nothing)
        checkboxWSTShowWLMenu.Location = New Point(5, 143)
        checkboxWSTShowWLMenu.Name = "checkboxWSTShowWLMenu"
        checkboxWSTShowWLMenu.Size = New Size(126, 21)
        checkboxWSTShowWLMenu.TabIndex = 30
        TipHCEX.SetText(checkboxWSTShowWLMenu, Nothing)
        TipInfoEX.SetText(checkboxWSTShowWLMenu, Nothing)
        checkboxWSTShowWLMenu.Text = "Show 'WinLinks'"
        checkboxWSTShowWLMenu.UseVisualStyleBackColor = True
        ' 
        ' groupboxWSTSS
        ' 
        groupboxWSTSS.Controls.Add(btnWSTScreenSaverEnabled)
        groupboxWSTSS.Controls.Add(comboboxWSTSSStartUp)
        groupboxWSTSS.Controls.Add(label36)
        groupboxWSTSS.Controls.Add(checkboxWSTScreenSaverEnableOnActivate)
        groupboxWSTSS.Controls.Add(checkboxWSTShowScreenSaverEnabled)
        groupboxWSTSS.Controls.Add(checkboxWSTShowScreenSaverActivate)
        groupboxWSTSS.Controls.Add(checkboxWSTShowScreenSaverIcon)
        groupboxWSTSS.ForeColor = SystemColors.ControlText
        TipHCEX.SetImage(groupboxWSTSS, Nothing)
        TipInfoEX.SetImage(groupboxWSTSS, Nothing)
        groupboxWSTSS.Location = New Point(403, 190)
        groupboxWSTSS.Name = "groupboxWSTSS"
        groupboxWSTSS.RightToLeft = RightToLeft.Yes
        groupboxWSTSS.Size = New Size(207, 155)
        groupboxWSTSS.TabIndex = 140
        groupboxWSTSS.TabStop = False
        TipHCEX.SetText(groupboxWSTSS, Nothing)
        TipInfoEX.SetText(groupboxWSTSS, Nothing)
        ' 
        ' btnWSTScreenSaverEnabled
        ' 
        btnWSTScreenSaverEnabled.Appearance = Appearance.Button
        TipInfoEX.SetImage(btnWSTScreenSaverEnabled, Nothing)
        TipHCEX.SetImage(btnWSTScreenSaverEnabled, Nothing)
        btnWSTScreenSaverEnabled.Location = New Point(14, 21)
        btnWSTScreenSaverEnabled.Name = "btnWSTScreenSaverEnabled"
        btnWSTScreenSaverEnabled.Size = New Size(24, 24)
        btnWSTScreenSaverEnabled.TabIndex = 30
        btnWSTScreenSaverEnabled.TabStop = True
        TipHCEX.SetText(btnWSTScreenSaverEnabled, Nothing)
        TipInfoEX.SetText(btnWSTScreenSaverEnabled, "SS")
        btnWSTScreenSaverEnabled.UseVisualStyleBackColor = True
        ' 
        ' comboboxWSTSSStartUp
        ' 
        comboboxWSTSSStartUp.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        comboboxWSTSSStartUp.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxWSTSSStartUp.FormattingEnabled = True
        TipInfoEX.SetImage(comboboxWSTSSStartUp, Nothing)
        TipHCEX.SetImage(comboboxWSTSSStartUp, Nothing)
        comboboxWSTSSStartUp.Location = New Point(14, 120)
        comboboxWSTSSStartUp.Name = "comboboxWSTSSStartUp"
        comboboxWSTSSStartUp.RightToLeft = RightToLeft.No
        comboboxWSTSSStartUp.Size = New Size(179, 25)
        comboboxWSTSSStartUp.TabIndex = 25
        TipInfoEX.SetText(comboboxWSTSSStartUp, Nothing)
        TipHCEX.SetText(comboboxWSTSSStartUp, Nothing)
        ' 
        ' label36
        ' 
        label36.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TipHCEX.SetImage(label36, Nothing)
        TipInfoEX.SetImage(label36, Nothing)
        label36.Location = New Point(14, 100)
        label36.Name = "label36"
        label36.RightToLeft = RightToLeft.No
        label36.Size = New Size(179, 21)
        label36.TabIndex = 25
        TipHCEX.SetText(label36, Nothing)
        label36.Text = "StartUp Mode"
        TipInfoEX.SetText(label36, Nothing)
        label36.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' checkboxWSTScreenSaverEnableOnActivate
        ' 
        checkboxWSTScreenSaverEnableOnActivate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(checkboxWSTScreenSaverEnableOnActivate, Nothing)
        TipHCEX.SetImage(checkboxWSTScreenSaverEnableOnActivate, Nothing)
        checkboxWSTScreenSaverEnableOnActivate.Location = New Point(55, 75)
        checkboxWSTScreenSaverEnableOnActivate.Name = "checkboxWSTScreenSaverEnableOnActivate"
        checkboxWSTScreenSaverEnableOnActivate.RightToLeft = RightToLeft.Yes
        checkboxWSTScreenSaverEnableOnActivate.Size = New Size(138, 21)
        checkboxWSTScreenSaverEnableOnActivate.TabIndex = 20
        TipHCEX.SetText(checkboxWSTScreenSaverEnableOnActivate, Nothing)
        TipInfoEX.SetText(checkboxWSTScreenSaverEnableOnActivate, Nothing)
        checkboxWSTScreenSaverEnableOnActivate.Text = "Enable On Activate"
        checkboxWSTScreenSaverEnableOnActivate.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowScreenSaverEnabled
        ' 
        checkboxWSTShowScreenSaverEnabled.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(checkboxWSTShowScreenSaverEnabled, Nothing)
        TipHCEX.SetImage(checkboxWSTShowScreenSaverEnabled, Nothing)
        checkboxWSTShowScreenSaverEnabled.Location = New Point(20, 57)
        checkboxWSTShowScreenSaverEnabled.Name = "checkboxWSTShowScreenSaverEnabled"
        checkboxWSTShowScreenSaverEnabled.RightToLeft = RightToLeft.Yes
        checkboxWSTShowScreenSaverEnabled.Size = New Size(173, 21)
        checkboxWSTShowScreenSaverEnabled.TabIndex = 15
        TipHCEX.SetText(checkboxWSTShowScreenSaverEnabled, Nothing)
        TipInfoEX.SetText(checkboxWSTShowScreenSaverEnabled, Nothing)
        checkboxWSTShowScreenSaverEnabled.Text = "Show 'Enabled/Disabled'"
        checkboxWSTShowScreenSaverEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowScreenSaverActivate
        ' 
        checkboxWSTShowScreenSaverActivate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(checkboxWSTShowScreenSaverActivate, Nothing)
        TipHCEX.SetImage(checkboxWSTShowScreenSaverActivate, Nothing)
        checkboxWSTShowScreenSaverActivate.Location = New Point(75, 39)
        checkboxWSTShowScreenSaverActivate.Name = "checkboxWSTShowScreenSaverActivate"
        checkboxWSTShowScreenSaverActivate.RightToLeft = RightToLeft.Yes
        checkboxWSTShowScreenSaverActivate.Size = New Size(118, 21)
        checkboxWSTShowScreenSaverActivate.TabIndex = 10
        TipHCEX.SetText(checkboxWSTShowScreenSaverActivate, Nothing)
        TipInfoEX.SetText(checkboxWSTShowScreenSaverActivate, Nothing)
        checkboxWSTShowScreenSaverActivate.Text = "Show 'Activate'"
        checkboxWSTShowScreenSaverActivate.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowScreenSaverIcon
        ' 
        checkboxWSTShowScreenSaverIcon.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(checkboxWSTShowScreenSaverIcon, Nothing)
        TipHCEX.SetImage(checkboxWSTShowScreenSaverIcon, Nothing)
        checkboxWSTShowScreenSaverIcon.Location = New Point(75, 21)
        checkboxWSTShowScreenSaverIcon.Name = "checkboxWSTShowScreenSaverIcon"
        checkboxWSTShowScreenSaverIcon.RightToLeft = RightToLeft.Yes
        checkboxWSTShowScreenSaverIcon.Size = New Size(118, 21)
        checkboxWSTShowScreenSaverIcon.TabIndex = 1
        TipHCEX.SetText(checkboxWSTShowScreenSaverIcon, Nothing)
        TipInfoEX.SetText(checkboxWSTShowScreenSaverIcon, Nothing)
        checkboxWSTShowScreenSaverIcon.Text = "Show Tray Icon"
        checkboxWSTShowScreenSaverIcon.UseVisualStyleBackColor = True
        ' 
        ' btnLoadOnOSStartupPath
        ' 
        btnLoadOnOSStartupPath.FlatAppearance.BorderSize = 0
        btnLoadOnOSStartupPath.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnLoadOnOSStartupPath.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnLoadOnOSStartupPath.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnLoadOnOSStartupPath, Nothing)
        btnLoadOnOSStartupPath.Image = My.Resources.Resources.ImageFolder
        TipInfoEX.SetImage(btnLoadOnOSStartupPath, Nothing)
        btnLoadOnOSStartupPath.Location = New Point(440, 21)
        btnLoadOnOSStartupPath.Name = "btnLoadOnOSStartupPath"
        btnLoadOnOSStartupPath.Size = New Size(21, 21)
        btnLoadOnOSStartupPath.TabIndex = 101
        btnLoadOnOSStartupPath.TabStop = False
        TipInfoEX.SetText(btnLoadOnOSStartupPath, "Select An Application")
        TipHCEX.SetText(btnLoadOnOSStartupPath, Nothing)
        btnLoadOnOSStartupPath.TextAlign = ContentAlignment.MiddleLeft
        btnLoadOnOSStartupPath.UseVisualStyleBackColor = True
        ' 
        ' checkboxLoadOnOSStartup
        ' 
        TipInfoEX.SetImage(checkboxLoadOnOSStartup, Nothing)
        TipHCEX.SetImage(checkboxLoadOnOSStartup, Nothing)
        checkboxLoadOnOSStartup.Location = New Point(459, 5)
        checkboxLoadOnOSStartup.Name = "checkboxLoadOnOSStartup"
        checkboxLoadOnOSStartup.RightToLeft = RightToLeft.Yes
        checkboxLoadOnOSStartup.Size = New Size(152, 20)
        checkboxLoadOnOSStartup.TabIndex = 100
        TipHCEX.SetText(checkboxLoadOnOSStartup, Nothing)
        TipInfoEX.SetText(checkboxLoadOnOSStartup, Nothing)
        checkboxLoadOnOSStartup.Text = "Load On Windows StartUp"
        checkboxLoadOnOSStartup.UseVisualStyleBackColor = True
        ' 
        ' txbxLoadOnOSStartupArgs
        ' 
        TipHCEX.SetImage(txbxLoadOnOSStartupArgs, Nothing)
        TipInfoEX.SetImage(txbxLoadOnOSStartupArgs, Nothing)
        txbxLoadOnOSStartupArgs.Location = New Point(460, 41)
        txbxLoadOnOSStartupArgs.Name = "txbxLoadOnOSStartupArgs"
        txbxLoadOnOSStartupArgs.Size = New Size(150, 25)
        txbxLoadOnOSStartupArgs.TabIndex = 102
        TipInfoEX.SetText(txbxLoadOnOSStartupArgs, "Args")
        TipHCEX.SetText(txbxLoadOnOSStartupArgs, Nothing)
        txbxLoadOnOSStartupArgs.WordWrap = False
        ' 
        ' checkboxWSTEnabled
        ' 
        TipInfoEX.SetImage(checkboxWSTEnabled, Nothing)
        TipHCEX.SetImage(checkboxWSTEnabled, Nothing)
        checkboxWSTEnabled.Location = New Point(5, 5)
        checkboxWSTEnabled.Name = "checkboxWSTEnabled"
        checkboxWSTEnabled.Size = New Size(115, 21)
        checkboxWSTEnabled.TabIndex = 10
        TipHCEX.SetText(checkboxWSTEnabled, Nothing)
        TipInfoEX.SetText(checkboxWSTEnabled, Nothing)
        checkboxWSTEnabled.Text = "Show Tray Icon"
        checkboxWSTEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxThemeAuto
        ' 
        ChkBoxThemeAuto.AutoSize = True
        TipInfoEX.SetImage(ChkBoxThemeAuto, Nothing)
        TipHCEX.SetImage(ChkBoxThemeAuto, Nothing)
        ChkBoxThemeAuto.Location = New Point(209, 23)
        ChkBoxThemeAuto.Name = "ChkBoxThemeAuto"
        ChkBoxThemeAuto.Size = New Size(137, 21)
        ChkBoxThemeAuto.TabIndex = 142
        TipHCEX.SetText(ChkBoxThemeAuto, Nothing)
        TipInfoEX.SetText(ChkBoxThemeAuto, Nothing)
        ChkBoxThemeAuto.Text = "Use System Theme"
        ChkBoxThemeAuto.UseVisualStyleBackColor = True
        ' 
        ' tabpageAC
        ' 
        tabpageAC.Controls.Add(lblACAlarmChime)
        tabpageAC.Controls.Add(lblACOffHourChimePath)
        tabpageAC.Controls.Add(lblACOffHourChime)
        tabpageAC.Controls.Add(btnACOffHourChimeManual)
        tabpageAC.Controls.Add(lblACTopHourChime)
        tabpageAC.Controls.Add(btnACAlarmCancel)
        tabpageAC.Controls.Add(lblACTopHourChimePath)
        tabpageAC.Controls.Add(lblACAlarmChimePath)
        tabpageAC.Controls.Add(checkboxACBottomHourAfterChimeEnabled)
        tabpageAC.Controls.Add(checkboxACFirstQuarterHourAfterChimeEnabled)
        tabpageAC.Controls.Add(checkboxACThirdQuarterHourBeforeChimeEnabled)
        tabpageAC.Controls.Add(checkboxACFirstQuarterHourBeforeChimeEnabled)
        tabpageAC.Controls.Add(checkboxACThirdQuarterHourAfterChimeEnabled)
        tabpageAC.Controls.Add(checkboxACBottomHourBeforeChimeEnabled)
        tabpageAC.Controls.Add(btnACMute)
        tabpageAC.Controls.Add(textboxACAlarmTimer)
        tabpageAC.Controls.Add(groupboxACTopHourChimeType)
        tabpageAC.Controls.Add(btnACOffHourChimeDefault)
        tabpageAC.Controls.Add(btnACTopHourChimeDefault)
        tabpageAC.Controls.Add(textboxACAlarmTime)
        tabpageAC.Controls.Add(btnACTopHourChimeManual)
        tabpageAC.Controls.Add(checkboxACThirdQuarterHourChimeEnabled)
        tabpageAC.Controls.Add(checkboxACBottomHourChimeEnabled)
        tabpageAC.Controls.Add(checkboxACFirstQuarterHourChimeEnabled)
        tabpageAC.Controls.Add(checkboxACTopHourAfterChimeEnabled)
        tabpageAC.Controls.Add(checkboxACTopHourChimeEnabled)
        tabpageAC.Controls.Add(checkboxACTopHourBeforeChimeEnabled)
        tabpageAC.Controls.Add(groupboxACAlarmChimeType)
        tabpageAC.Controls.Add(btnACAlarmSet)
        tabpageAC.Controls.Add(checkboxACAlarmRecurring)
        tabpageAC.Controls.Add(label13)
        tabpageAC.Controls.Add(btnACTopHourChimePlay)
        tabpageAC.Controls.Add(btnACOffHourChimePlay)
        tabpageAC.Controls.Add(label32)
        tabpageAC.Controls.Add(picboxACClock)
        tabpageAC.Controls.Add(btnACAlarmChimeDefault)
        tabpageAC.Controls.Add(btnACAlarmChimePlay)
        tabpageAC.Controls.Add(btnACAlarmChimeManual)
        TipHCEX.SetImage(tabpageAC, Nothing)
        TipInfoEX.SetImage(tabpageAC, Nothing)
        tabpageAC.Location = New Point(4, 24)
        tabpageAC.Name = "tabpageAC"
        tabpageAC.Padding = New Padding(3)
        tabpageAC.Size = New Size(618, 375)
        tabpageAC.TabIndex = 3
        TipHCEX.SetText(tabpageAC, Nothing)
        TipInfoEX.SetText(tabpageAC, Nothing)
        tabpageAC.Text = "****Alarm + Chime****"
        tabpageAC.UseVisualStyleBackColor = True
        ' 
        ' lblACAlarmChime
        ' 
        lblACAlarmChime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACAlarmChime.ForeColor = SystemColors.ControlText
        TipHCEX.SetImage(lblACAlarmChime, Nothing)
        TipInfoEX.SetImage(lblACAlarmChime, Nothing)
        lblACAlarmChime.Location = New Point(530, 4)
        lblACAlarmChime.Name = "lblACAlarmChime"
        lblACAlarmChime.Size = New Size(85, 14)
        lblACAlarmChime.TabIndex = 28
        TipHCEX.SetText(lblACAlarmChime, Nothing)
        lblACAlarmChime.Text = "Alarm"
        TipInfoEX.SetText(lblACAlarmChime, Nothing)
        lblACAlarmChime.TextAlign = ContentAlignment.BottomRight
        ' 
        ' lblACOffHourChimePath
        ' 
        lblACOffHourChimePath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACOffHourChimePath.AutoEllipsis = True
        lblACOffHourChimePath.BorderStyle = BorderStyle.FixedSingle
        TipHCEX.SetImage(lblACOffHourChimePath, Nothing)
        TipInfoEX.SetImage(lblACOffHourChimePath, Nothing)
        lblACOffHourChimePath.Location = New Point(448, 325)
        lblACOffHourChimePath.Name = "lblACOffHourChimePath"
        lblACOffHourChimePath.Size = New Size(163, 20)
        lblACOffHourChimePath.TabIndex = 32
        TipHCEX.SetText(lblACOffHourChimePath, Nothing)
        TipInfoEX.SetText(lblACOffHourChimePath, "Path")
        lblACOffHourChimePath.TextAlign = ContentAlignment.TopRight
        lblACOffHourChimePath.UseMnemonic = False
        ' 
        ' lblACOffHourChime
        ' 
        lblACOffHourChime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACOffHourChime.ForeColor = SystemColors.ControlText
        TipHCEX.SetImage(lblACOffHourChime, Nothing)
        TipInfoEX.SetImage(lblACOffHourChime, Nothing)
        lblACOffHourChime.Location = New Point(494, 292)
        lblACOffHourChime.Name = "lblACOffHourChime"
        lblACOffHourChime.Size = New Size(122, 16)
        lblACOffHourChime.TabIndex = 13
        TipHCEX.SetText(lblACOffHourChime, Nothing)
        lblACOffHourChime.Text = "Off-Hour Chimes"
        TipInfoEX.SetText(lblACOffHourChime, Nothing)
        lblACOffHourChime.TextAlign = ContentAlignment.BottomRight
        ' 
        ' btnACOffHourChimeManual
        ' 
        btnACOffHourChimeManual.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACOffHourChimeManual.FlatAppearance.BorderSize = 0
        btnACOffHourChimeManual.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnACOffHourChimeManual, Nothing)
        btnACOffHourChimeManual.Image = My.Resources.Resources.imageACFolder
        TipInfoEX.SetImage(btnACOffHourChimeManual, Nothing)
        btnACOffHourChimeManual.Location = New Point(590, 305)
        btnACOffHourChimeManual.Name = "btnACOffHourChimeManual"
        btnACOffHourChimeManual.Size = New Size(21, 21)
        btnACOffHourChimeManual.TabIndex = 31
        TipInfoEX.SetText(btnACOffHourChimeManual, "Select WAV File")
        TipHCEX.SetText(btnACOffHourChimeManual, Nothing)
        btnACOffHourChimeManual.TextAlign = ContentAlignment.MiddleLeft
        btnACOffHourChimeManual.UseVisualStyleBackColor = True
        ' 
        ' lblACTopHourChime
        ' 
        lblACTopHourChime.ForeColor = SystemColors.ControlText
        TipHCEX.SetImage(lblACTopHourChime, Nothing)
        TipInfoEX.SetImage(lblACTopHourChime, Nothing)
        lblACTopHourChime.Location = New Point(4, 235)
        lblACTopHourChime.Name = "lblACTopHourChime"
        lblACTopHourChime.Size = New Size(119, 16)
        lblACTopHourChime.TabIndex = 12
        TipHCEX.SetText(lblACTopHourChime, Nothing)
        lblACTopHourChime.Text = "Top-Hour Chime"
        TipInfoEX.SetText(lblACTopHourChime, Nothing)
        lblACTopHourChime.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' btnACAlarmCancel
        ' 
        btnACAlarmCancel.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnACAlarmCancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnACAlarmCancel.ForeColor = Color.Maroon
        TipHCEX.SetImage(btnACAlarmCancel, Nothing)
        TipInfoEX.SetImage(btnACAlarmCancel, Nothing)
        btnACAlarmCancel.Location = New Point(82, 45)
        btnACAlarmCancel.Name = "btnACAlarmCancel"
        btnACAlarmCancel.Size = New Size(72, 43)
        btnACAlarmCancel.TabIndex = 4
        TipInfoEX.SetText(btnACAlarmCancel, "Cancel")
        TipHCEX.SetText(btnACAlarmCancel, Nothing)
        btnACAlarmCancel.Text = " CANCEL  ALARM"
        btnACAlarmCancel.UseVisualStyleBackColor = True
        btnACAlarmCancel.Visible = False
        ' 
        ' lblACTopHourChimePath
        ' 
        lblACTopHourChimePath.AutoEllipsis = True
        lblACTopHourChimePath.BorderStyle = BorderStyle.FixedSingle
        TipHCEX.SetImage(lblACTopHourChimePath, Nothing)
        TipInfoEX.SetImage(lblACTopHourChimePath, Nothing)
        lblACTopHourChimePath.Location = New Point(5, 325)
        lblACTopHourChimePath.Name = "lblACTopHourChimePath"
        lblACTopHourChimePath.Size = New Size(164, 20)
        lblACTopHourChimePath.TabIndex = 24
        TipHCEX.SetText(lblACTopHourChimePath, Nothing)
        TipInfoEX.SetText(lblACTopHourChimePath, "Path")
        lblACTopHourChimePath.UseMnemonic = False
        ' 
        ' lblACAlarmChimePath
        ' 
        lblACAlarmChimePath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACAlarmChimePath.AutoEllipsis = True
        lblACAlarmChimePath.BorderStyle = BorderStyle.FixedSingle
        TipHCEX.SetImage(lblACAlarmChimePath, Nothing)
        TipInfoEX.SetImage(lblACAlarmChimePath, Nothing)
        lblACAlarmChimePath.Location = New Point(446, 36)
        lblACAlarmChimePath.Name = "lblACAlarmChimePath"
        lblACAlarmChimePath.Size = New Size(165, 20)
        lblACAlarmChimePath.TabIndex = 9
        TipHCEX.SetText(lblACAlarmChimePath, Nothing)
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
        TipHCEX.SetImage(checkboxACBottomHourAfterChimeEnabled, Nothing)
        checkboxACBottomHourAfterChimeEnabled.Location = New Point(250, 322)
        checkboxACBottomHourAfterChimeEnabled.Name = "checkboxACBottomHourAfterChimeEnabled"
        checkboxACBottomHourAfterChimeEnabled.Size = New Size(13, 13)
        checkboxACBottomHourAfterChimeEnabled.TabIndex = 28
        checkboxACBottomHourAfterChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACBottomHourAfterChimeEnabled, Nothing)
        TipInfoEX.SetText(checkboxACBottomHourAfterChimeEnabled, Nothing)
        checkboxACBottomHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACFirstQuarterHourAfterChimeEnabled
        ' 
        checkboxACFirstQuarterHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACFirstQuarterHourAfterChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(checkboxACFirstQuarterHourAfterChimeEnabled, Nothing)
        TipHCEX.SetImage(checkboxACFirstQuarterHourAfterChimeEnabled, Nothing)
        checkboxACFirstQuarterHourAfterChimeEnabled.Location = New Point(390, 289)
        checkboxACFirstQuarterHourAfterChimeEnabled.Name = "checkboxACFirstQuarterHourAfterChimeEnabled"
        checkboxACFirstQuarterHourAfterChimeEnabled.Size = New Size(13, 13)
        checkboxACFirstQuarterHourAfterChimeEnabled.TabIndex = 28
        checkboxACFirstQuarterHourAfterChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACFirstQuarterHourAfterChimeEnabled, Nothing)
        TipInfoEX.SetText(checkboxACFirstQuarterHourAfterChimeEnabled, Nothing)
        checkboxACFirstQuarterHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACThirdQuarterHourBeforeChimeEnabled
        ' 
        checkboxACThirdQuarterHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACThirdQuarterHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(checkboxACThirdQuarterHourBeforeChimeEnabled, Nothing)
        TipHCEX.SetImage(checkboxACThirdQuarterHourBeforeChimeEnabled, Nothing)
        checkboxACThirdQuarterHourBeforeChimeEnabled.Location = New Point(218, 288)
        checkboxACThirdQuarterHourBeforeChimeEnabled.Name = "checkboxACThirdQuarterHourBeforeChimeEnabled"
        checkboxACThirdQuarterHourBeforeChimeEnabled.Size = New Size(13, 13)
        checkboxACThirdQuarterHourBeforeChimeEnabled.TabIndex = 28
        checkboxACThirdQuarterHourBeforeChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACThirdQuarterHourBeforeChimeEnabled, Nothing)
        TipInfoEX.SetText(checkboxACThirdQuarterHourBeforeChimeEnabled, Nothing)
        checkboxACThirdQuarterHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACFirstQuarterHourBeforeChimeEnabled
        ' 
        checkboxACFirstQuarterHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACFirstQuarterHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(checkboxACFirstQuarterHourBeforeChimeEnabled, Nothing)
        TipHCEX.SetImage(checkboxACFirstQuarterHourBeforeChimeEnabled, Nothing)
        checkboxACFirstQuarterHourBeforeChimeEnabled.Location = New Point(389, 186)
        checkboxACFirstQuarterHourBeforeChimeEnabled.Name = "checkboxACFirstQuarterHourBeforeChimeEnabled"
        checkboxACFirstQuarterHourBeforeChimeEnabled.Size = New Size(13, 13)
        checkboxACFirstQuarterHourBeforeChimeEnabled.TabIndex = 28
        checkboxACFirstQuarterHourBeforeChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACFirstQuarterHourBeforeChimeEnabled, Nothing)
        TipInfoEX.SetText(checkboxACFirstQuarterHourBeforeChimeEnabled, Nothing)
        checkboxACFirstQuarterHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACThirdQuarterHourAfterChimeEnabled
        ' 
        checkboxACThirdQuarterHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACThirdQuarterHourAfterChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(checkboxACThirdQuarterHourAfterChimeEnabled, Nothing)
        TipHCEX.SetImage(checkboxACThirdQuarterHourAfterChimeEnabled, Nothing)
        checkboxACThirdQuarterHourAfterChimeEnabled.Location = New Point(218, 184)
        checkboxACThirdQuarterHourAfterChimeEnabled.Name = "checkboxACThirdQuarterHourAfterChimeEnabled"
        checkboxACThirdQuarterHourAfterChimeEnabled.Size = New Size(13, 13)
        checkboxACThirdQuarterHourAfterChimeEnabled.TabIndex = 28
        checkboxACThirdQuarterHourAfterChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACThirdQuarterHourAfterChimeEnabled, Nothing)
        TipInfoEX.SetText(checkboxACThirdQuarterHourAfterChimeEnabled, Nothing)
        checkboxACThirdQuarterHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACBottomHourBeforeChimeEnabled
        ' 
        checkboxACBottomHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACBottomHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(checkboxACBottomHourBeforeChimeEnabled, Nothing)
        TipHCEX.SetImage(checkboxACBottomHourBeforeChimeEnabled, Nothing)
        checkboxACBottomHourBeforeChimeEnabled.Location = New Point(355, 325)
        checkboxACBottomHourBeforeChimeEnabled.Name = "checkboxACBottomHourBeforeChimeEnabled"
        checkboxACBottomHourBeforeChimeEnabled.Size = New Size(13, 13)
        checkboxACBottomHourBeforeChimeEnabled.TabIndex = 28
        checkboxACBottomHourBeforeChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACBottomHourBeforeChimeEnabled, Nothing)
        TipInfoEX.SetText(checkboxACBottomHourBeforeChimeEnabled, Nothing)
        checkboxACBottomHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' btnACMute
        ' 
        btnACMute.Anchor = AnchorStyles.Top
        btnACMute.FlatAppearance.BorderSize = 0
        btnACMute.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnACMute, Nothing)
        TipInfoEX.SetImage(btnACMute, Nothing)
        btnACMute.Location = New Point(282, 35)
        btnACMute.Name = "btnACMute"
        btnACMute.Size = New Size(64, 64)
        btnACMute.TabIndex = 11
        TipInfoEX.SetText(btnACMute, "Mute All Chimes")
        TipHCEX.SetText(btnACMute, Nothing)
        btnACMute.TextAlign = ContentAlignment.MiddleLeft
        btnACMute.UseVisualStyleBackColor = True
        ' 
        ' textboxACAlarmTimer
        ' 
        TipHCEX.SetImage(textboxACAlarmTimer, Nothing)
        TipInfoEX.SetImage(textboxACAlarmTimer, Nothing)
        textboxACAlarmTimer.Location = New Point(5, 89)
        textboxACAlarmTimer.MaxLength = 3
        textboxACAlarmTimer.Name = "textboxACAlarmTimer"
        textboxACAlarmTimer.Size = New Size(70, 25)
        textboxACAlarmTimer.TabIndex = 5
        TipInfoEX.SetText(textboxACAlarmTimer, "Enter Timer Value In Minutes")
        TipHCEX.SetText(textboxACAlarmTimer, Nothing)
        textboxACAlarmTimer.TextAlign = HorizontalAlignment.Center
        ' 
        ' groupboxACTopHourChimeType
        ' 
        groupboxACTopHourChimeType.Controls.Add(radiobtnACTopHourChimeSimple)
        groupboxACTopHourChimeType.Controls.Add(radiobtnACTopHourChimeExtended)
        groupboxACTopHourChimeType.Controls.Add(radiobtnACTopHourChimeHourTick)
        TipHCEX.SetImage(groupboxACTopHourChimeType, Nothing)
        TipInfoEX.SetImage(groupboxACTopHourChimeType, Nothing)
        groupboxACTopHourChimeType.Location = New Point(5, 242)
        groupboxACTopHourChimeType.Name = "groupboxACTopHourChimeType"
        groupboxACTopHourChimeType.Size = New Size(85, 65)
        groupboxACTopHourChimeType.TabIndex = 20
        groupboxACTopHourChimeType.TabStop = False
        TipHCEX.SetText(groupboxACTopHourChimeType, Nothing)
        TipInfoEX.SetText(groupboxACTopHourChimeType, Nothing)
        ' 
        ' radiobtnACTopHourChimeSimple
        ' 
        TipInfoEX.SetImage(radiobtnACTopHourChimeSimple, Nothing)
        TipHCEX.SetImage(radiobtnACTopHourChimeSimple, Nothing)
        radiobtnACTopHourChimeSimple.Location = New Point(6, 11)
        radiobtnACTopHourChimeSimple.Name = "radiobtnACTopHourChimeSimple"
        radiobtnACTopHourChimeSimple.Size = New Size(73, 20)
        radiobtnACTopHourChimeSimple.TabIndex = 1
        radiobtnACTopHourChimeSimple.TabStop = True
        TipHCEX.SetText(radiobtnACTopHourChimeSimple, Nothing)
        TipInfoEX.SetText(radiobtnACTopHourChimeSimple, "Chime Once")
        radiobtnACTopHourChimeSimple.Text = "Simple"
        radiobtnACTopHourChimeSimple.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACTopHourChimeExtended
        ' 
        TipInfoEX.SetImage(radiobtnACTopHourChimeExtended, Nothing)
        TipHCEX.SetImage(radiobtnACTopHourChimeExtended, Nothing)
        radiobtnACTopHourChimeExtended.Location = New Point(6, 27)
        radiobtnACTopHourChimeExtended.Name = "radiobtnACTopHourChimeExtended"
        radiobtnACTopHourChimeExtended.Size = New Size(80, 20)
        radiobtnACTopHourChimeExtended.TabIndex = 2
        radiobtnACTopHourChimeExtended.TabStop = True
        TipHCEX.SetText(radiobtnACTopHourChimeExtended, Nothing)
        TipInfoEX.SetText(radiobtnACTopHourChimeExtended, "Chime Several Times")
        radiobtnACTopHourChimeExtended.Text = "Extended"
        radiobtnACTopHourChimeExtended.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACTopHourChimeHourTick
        ' 
        TipInfoEX.SetImage(radiobtnACTopHourChimeHourTick, Nothing)
        TipHCEX.SetImage(radiobtnACTopHourChimeHourTick, Nothing)
        radiobtnACTopHourChimeHourTick.Location = New Point(6, 43)
        radiobtnACTopHourChimeHourTick.Name = "radiobtnACTopHourChimeHourTick"
        radiobtnACTopHourChimeHourTick.Size = New Size(73, 20)
        radiobtnACTopHourChimeHourTick.TabIndex = 3
        radiobtnACTopHourChimeHourTick.TabStop = True
        TipHCEX.SetText(radiobtnACTopHourChimeHourTick, Nothing)
        TipInfoEX.SetText(radiobtnACTopHourChimeHourTick, "Chime Based On Hour")
        radiobtnACTopHourChimeHourTick.Text = "Hour Tick"
        radiobtnACTopHourChimeHourTick.UseVisualStyleBackColor = True
        ' 
        ' btnACOffHourChimeDefault
        ' 
        btnACOffHourChimeDefault.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACOffHourChimeDefault.FlatAppearance.BorderSize = 0
        btnACOffHourChimeDefault.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnACOffHourChimeDefault, Nothing)
        btnACOffHourChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        TipInfoEX.SetImage(btnACOffHourChimeDefault, Nothing)
        btnACOffHourChimeDefault.Location = New Point(565, 305)
        btnACOffHourChimeDefault.Name = "btnACOffHourChimeDefault"
        btnACOffHourChimeDefault.Size = New Size(21, 21)
        btnACOffHourChimeDefault.TabIndex = 30
        TipInfoEX.SetText(btnACOffHourChimeDefault, "Use Default Chime")
        TipHCEX.SetText(btnACOffHourChimeDefault, Nothing)
        btnACOffHourChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        btnACOffHourChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' btnACTopHourChimeDefault
        ' 
        btnACTopHourChimeDefault.FlatAppearance.BorderSize = 0
        btnACTopHourChimeDefault.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnACTopHourChimeDefault, Nothing)
        btnACTopHourChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        TipInfoEX.SetImage(btnACTopHourChimeDefault, Nothing)
        btnACTopHourChimeDefault.Location = New Point(28, 305)
        btnACTopHourChimeDefault.Name = "btnACTopHourChimeDefault"
        btnACTopHourChimeDefault.Size = New Size(21, 21)
        btnACTopHourChimeDefault.TabIndex = 22
        TipInfoEX.SetText(btnACTopHourChimeDefault, "Use Default Chime")
        TipHCEX.SetText(btnACTopHourChimeDefault, Nothing)
        btnACTopHourChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        btnACTopHourChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' textboxACAlarmTime
        ' 
        TipHCEX.SetImage(textboxACAlarmTime, Nothing)
        TipInfoEX.SetImage(textboxACAlarmTime, Nothing)
        textboxACAlarmTime.Location = New Point(5, 19)
        textboxACAlarmTime.MaxLength = 5
        textboxACAlarmTime.Name = "textboxACAlarmTime"
        textboxACAlarmTime.Size = New Size(70, 25)
        textboxACAlarmTime.TabIndex = 1
        TipInfoEX.SetText(textboxACAlarmTime, "Enter Alarm Time (24-Hour Format)")
        TipHCEX.SetText(textboxACAlarmTime, Nothing)
        textboxACAlarmTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnACTopHourChimeManual
        ' 
        btnACTopHourChimeManual.FlatAppearance.BorderSize = 0
        btnACTopHourChimeManual.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnACTopHourChimeManual, Nothing)
        btnACTopHourChimeManual.Image = My.Resources.Resources.imageACFolder
        TipInfoEX.SetImage(btnACTopHourChimeManual, Nothing)
        btnACTopHourChimeManual.Location = New Point(4, 305)
        btnACTopHourChimeManual.Name = "btnACTopHourChimeManual"
        btnACTopHourChimeManual.Size = New Size(21, 21)
        btnACTopHourChimeManual.TabIndex = 21
        TipInfoEX.SetText(btnACTopHourChimeManual, "Select WAV File")
        TipHCEX.SetText(btnACTopHourChimeManual, Nothing)
        btnACTopHourChimeManual.TextAlign = ContentAlignment.MiddleLeft
        btnACTopHourChimeManual.UseVisualStyleBackColor = True
        ' 
        ' checkboxACThirdQuarterHourChimeEnabled
        ' 
        checkboxACThirdQuarterHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACThirdQuarterHourChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(checkboxACThirdQuarterHourChimeEnabled, Nothing)
        TipHCEX.SetImage(checkboxACThirdQuarterHourChimeEnabled, Nothing)
        checkboxACThirdQuarterHourChimeEnabled.Location = New Point(204, 234)
        checkboxACThirdQuarterHourChimeEnabled.Name = "checkboxACThirdQuarterHourChimeEnabled"
        checkboxACThirdQuarterHourChimeEnabled.Size = New Size(15, 15)
        checkboxACThirdQuarterHourChimeEnabled.TabIndex = 28
        checkboxACThirdQuarterHourChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACThirdQuarterHourChimeEnabled, Nothing)
        TipInfoEX.SetText(checkboxACThirdQuarterHourChimeEnabled, Nothing)
        checkboxACThirdQuarterHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACBottomHourChimeEnabled
        ' 
        checkboxACBottomHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACBottomHourChimeEnabled.CheckAlign = ContentAlignment.MiddleRight
        TipInfoEX.SetImage(checkboxACBottomHourChimeEnabled, Nothing)
        TipHCEX.SetImage(checkboxACBottomHourChimeEnabled, Nothing)
        checkboxACBottomHourChimeEnabled.Location = New Point(303, 336)
        checkboxACBottomHourChimeEnabled.Name = "checkboxACBottomHourChimeEnabled"
        checkboxACBottomHourChimeEnabled.Size = New Size(15, 15)
        checkboxACBottomHourChimeEnabled.TabIndex = 28
        checkboxACBottomHourChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACBottomHourChimeEnabled, Nothing)
        TipInfoEX.SetText(checkboxACBottomHourChimeEnabled, Nothing)
        checkboxACBottomHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACFirstQuarterHourChimeEnabled
        ' 
        checkboxACFirstQuarterHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACFirstQuarterHourChimeEnabled.CheckAlign = ContentAlignment.TopLeft
        TipInfoEX.SetImage(checkboxACFirstQuarterHourChimeEnabled, Nothing)
        TipHCEX.SetImage(checkboxACFirstQuarterHourChimeEnabled, Nothing)
        checkboxACFirstQuarterHourChimeEnabled.Location = New Point(402, 235)
        checkboxACFirstQuarterHourChimeEnabled.Name = "checkboxACFirstQuarterHourChimeEnabled"
        checkboxACFirstQuarterHourChimeEnabled.Size = New Size(15, 15)
        checkboxACFirstQuarterHourChimeEnabled.TabIndex = 28
        checkboxACFirstQuarterHourChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACFirstQuarterHourChimeEnabled, Nothing)
        TipInfoEX.SetText(checkboxACFirstQuarterHourChimeEnabled, Nothing)
        checkboxACFirstQuarterHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACTopHourAfterChimeEnabled
        ' 
        checkboxACTopHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACTopHourAfterChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(checkboxACTopHourAfterChimeEnabled, Nothing)
        TipHCEX.SetImage(checkboxACTopHourAfterChimeEnabled, Nothing)
        checkboxACTopHourAfterChimeEnabled.Location = New Point(354, 150)
        checkboxACTopHourAfterChimeEnabled.Name = "checkboxACTopHourAfterChimeEnabled"
        checkboxACTopHourAfterChimeEnabled.Size = New Size(15, 15)
        checkboxACTopHourAfterChimeEnabled.TabIndex = 28
        checkboxACTopHourAfterChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACTopHourAfterChimeEnabled, Nothing)
        TipInfoEX.SetText(checkboxACTopHourAfterChimeEnabled, Nothing)
        checkboxACTopHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACTopHourChimeEnabled
        ' 
        checkboxACTopHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACTopHourChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(checkboxACTopHourChimeEnabled, Nothing)
        TipHCEX.SetImage(checkboxACTopHourChimeEnabled, Nothing)
        checkboxACTopHourChimeEnabled.Location = New Point(303, 137)
        checkboxACTopHourChimeEnabled.Name = "checkboxACTopHourChimeEnabled"
        checkboxACTopHourChimeEnabled.Size = New Size(15, 15)
        checkboxACTopHourChimeEnabled.TabIndex = 12
        checkboxACTopHourChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACTopHourChimeEnabled, Nothing)
        TipInfoEX.SetText(checkboxACTopHourChimeEnabled, Nothing)
        checkboxACTopHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACTopHourBeforeChimeEnabled
        ' 
        checkboxACTopHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACTopHourBeforeChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(checkboxACTopHourBeforeChimeEnabled, Nothing)
        TipHCEX.SetImage(checkboxACTopHourBeforeChimeEnabled, Nothing)
        checkboxACTopHourBeforeChimeEnabled.Location = New Point(251, 149)
        checkboxACTopHourBeforeChimeEnabled.Name = "checkboxACTopHourBeforeChimeEnabled"
        checkboxACTopHourBeforeChimeEnabled.Size = New Size(15, 15)
        checkboxACTopHourBeforeChimeEnabled.TabIndex = 28
        checkboxACTopHourBeforeChimeEnabled.TabStop = False
        TipHCEX.SetText(checkboxACTopHourBeforeChimeEnabled, Nothing)
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
        TipHCEX.SetImage(groupboxACAlarmChimeType, Nothing)
        TipInfoEX.SetImage(groupboxACAlarmChimeType, Nothing)
        groupboxACAlarmChimeType.Location = New Point(526, 48)
        groupboxACAlarmChimeType.Name = "groupboxACAlarmChimeType"
        groupboxACAlarmChimeType.Size = New Size(85, 65)
        groupboxACAlarmChimeType.TabIndex = 10
        groupboxACAlarmChimeType.TabStop = False
        TipHCEX.SetText(groupboxACAlarmChimeType, Nothing)
        TipInfoEX.SetText(groupboxACAlarmChimeType, Nothing)
        ' 
        ' radiobtnACAlarmChimeSimple
        ' 
        TipInfoEX.SetImage(radiobtnACAlarmChimeSimple, Nothing)
        TipHCEX.SetImage(radiobtnACAlarmChimeSimple, Nothing)
        radiobtnACAlarmChimeSimple.Location = New Point(6, 11)
        radiobtnACAlarmChimeSimple.Name = "radiobtnACAlarmChimeSimple"
        radiobtnACAlarmChimeSimple.Size = New Size(80, 20)
        radiobtnACAlarmChimeSimple.TabIndex = 1
        radiobtnACAlarmChimeSimple.TabStop = True
        TipHCEX.SetText(radiobtnACAlarmChimeSimple, Nothing)
        TipInfoEX.SetText(radiobtnACAlarmChimeSimple, "Chime Once")
        radiobtnACAlarmChimeSimple.Text = "Simple"
        radiobtnACAlarmChimeSimple.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACAlarmChimeForever
        ' 
        TipInfoEX.SetImage(radiobtnACAlarmChimeForever, Nothing)
        TipHCEX.SetImage(radiobtnACAlarmChimeForever, Nothing)
        radiobtnACAlarmChimeForever.Location = New Point(6, 43)
        radiobtnACAlarmChimeForever.Name = "radiobtnACAlarmChimeForever"
        radiobtnACAlarmChimeForever.Size = New Size(80, 20)
        radiobtnACAlarmChimeForever.TabIndex = 3
        radiobtnACAlarmChimeForever.TabStop = True
        TipHCEX.SetText(radiobtnACAlarmChimeForever, Nothing)
        TipInfoEX.SetText(radiobtnACAlarmChimeForever, "Chime Until Cancelled")
        radiobtnACAlarmChimeForever.Text = "Forever"
        radiobtnACAlarmChimeForever.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACAlarmChimeExtended
        ' 
        TipInfoEX.SetImage(radiobtnACAlarmChimeExtended, Nothing)
        TipHCEX.SetImage(radiobtnACAlarmChimeExtended, Nothing)
        radiobtnACAlarmChimeExtended.Location = New Point(6, 27)
        radiobtnACAlarmChimeExtended.Name = "radiobtnACAlarmChimeExtended"
        radiobtnACAlarmChimeExtended.Size = New Size(80, 20)
        radiobtnACAlarmChimeExtended.TabIndex = 2
        radiobtnACAlarmChimeExtended.TabStop = True
        TipHCEX.SetText(radiobtnACAlarmChimeExtended, Nothing)
        TipInfoEX.SetText(radiobtnACAlarmChimeExtended, "Chime Several Times")
        radiobtnACAlarmChimeExtended.Text = "Extended"
        radiobtnACAlarmChimeExtended.UseVisualStyleBackColor = True
        ' 
        ' btnACAlarmSet
        ' 
        btnACAlarmSet.FlatAppearance.BorderColor = SystemColors.ControlDark
        TipHCEX.SetImage(btnACAlarmSet, Nothing)
        TipInfoEX.SetImage(btnACAlarmSet, Nothing)
        btnACAlarmSet.Location = New Point(4, 45)
        btnACAlarmSet.Name = "btnACAlarmSet"
        btnACAlarmSet.Size = New Size(72, 43)
        btnACAlarmSet.TabIndex = 3
        TipInfoEX.SetText(btnACAlarmSet, "Activate / DeActivate Alarm")
        TipHCEX.SetText(btnACAlarmSet, Nothing)
        btnACAlarmSet.Text = "Alarm InActive"
        btnACAlarmSet.UseVisualStyleBackColor = True
        ' 
        ' checkboxACAlarmRecurring
        ' 
        TipInfoEX.SetImage(checkboxACAlarmRecurring, Nothing)
        TipHCEX.SetImage(checkboxACAlarmRecurring, Nothing)
        checkboxACAlarmRecurring.Location = New Point(84, 20)
        checkboxACAlarmRecurring.Name = "checkboxACAlarmRecurring"
        checkboxACAlarmRecurring.Size = New Size(87, 24)
        checkboxACAlarmRecurring.TabIndex = 2
        TipHCEX.SetText(checkboxACAlarmRecurring, Nothing)
        TipInfoEX.SetText(checkboxACAlarmRecurring, "Alarm Repeats Every Day")
        checkboxACAlarmRecurring.Text = "Recurring"
        checkboxACAlarmRecurring.UseVisualStyleBackColor = True
        ' 
        ' label13
        ' 
        label13.ForeColor = SystemColors.ControlText
        TipHCEX.SetImage(label13, Nothing)
        TipInfoEX.SetImage(label13, Nothing)
        label13.Location = New Point(5, 108)
        label13.Name = "label13"
        label13.Size = New Size(70, 20)
        label13.TabIndex = 35
        TipHCEX.SetText(label13, Nothing)
        label13.Text = "Timer"
        TipInfoEX.SetText(label13, Nothing)
        label13.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' btnACTopHourChimePlay
        ' 
        btnACTopHourChimePlay.FlatAppearance.BorderSize = 0
        btnACTopHourChimePlay.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnACTopHourChimePlay, Nothing)
        btnACTopHourChimePlay.Image = My.Resources.Resources.imageACPlay
        TipInfoEX.SetImage(btnACTopHourChimePlay, Nothing)
        btnACTopHourChimePlay.Location = New Point(54, 305)
        btnACTopHourChimePlay.Name = "btnACTopHourChimePlay"
        btnACTopHourChimePlay.Size = New Size(21, 21)
        btnACTopHourChimePlay.TabIndex = 23
        TipInfoEX.SetText(btnACTopHourChimePlay, "Play Sound")
        TipHCEX.SetText(btnACTopHourChimePlay, Nothing)
        btnACTopHourChimePlay.TextAlign = ContentAlignment.MiddleLeft
        btnACTopHourChimePlay.UseVisualStyleBackColor = True
        ' 
        ' btnACOffHourChimePlay
        ' 
        btnACOffHourChimePlay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACOffHourChimePlay.FlatAppearance.BorderSize = 0
        btnACOffHourChimePlay.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnACOffHourChimePlay, Nothing)
        btnACOffHourChimePlay.Image = My.Resources.Resources.imageACPlay
        TipInfoEX.SetImage(btnACOffHourChimePlay, Nothing)
        btnACOffHourChimePlay.Location = New Point(542, 305)
        btnACOffHourChimePlay.Name = "btnACOffHourChimePlay"
        btnACOffHourChimePlay.Size = New Size(21, 21)
        btnACOffHourChimePlay.TabIndex = 29
        TipInfoEX.SetText(btnACOffHourChimePlay, "Play Sound")
        TipHCEX.SetText(btnACOffHourChimePlay, Nothing)
        btnACOffHourChimePlay.TextAlign = ContentAlignment.MiddleLeft
        btnACOffHourChimePlay.UseVisualStyleBackColor = True
        ' 
        ' label32
        ' 
        label32.ForeColor = SystemColors.ControlText
        TipHCEX.SetImage(label32, Nothing)
        TipInfoEX.SetImage(label32, Nothing)
        label32.Location = New Point(5, 4)
        label32.Name = "label32"
        label32.Size = New Size(70, 14)
        label32.TabIndex = 36
        TipHCEX.SetText(label32, Nothing)
        label32.Text = "Time"
        TipInfoEX.SetText(label32, Nothing)
        label32.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' picboxACClock
        ' 
        picboxACClock.Anchor = AnchorStyles.Top
        TipHCEX.SetImage(picboxACClock, Nothing)
        TipInfoEX.SetImage(picboxACClock, Nothing)
        picboxACClock.Image = My.Resources.Resources.imageACClock
        picboxACClock.Location = New Point(213, 147)
        picboxACClock.Name = "picboxACClock"
        picboxACClock.Size = New Size(192, 192)
        picboxACClock.SizeMode = PictureBoxSizeMode.Zoom
        picboxACClock.TabIndex = 0
        picboxACClock.TabStop = False
        TipHCEX.SetText(picboxACClock, Nothing)
        TipInfoEX.SetText(picboxACClock, "Select When To Sound Chime Each Hour")
        ' 
        ' btnACAlarmChimeDefault
        ' 
        btnACAlarmChimeDefault.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACAlarmChimeDefault.FlatAppearance.BorderSize = 0
        btnACAlarmChimeDefault.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnACAlarmChimeDefault, Nothing)
        btnACAlarmChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        TipInfoEX.SetImage(btnACAlarmChimeDefault, Nothing)
        btnACAlarmChimeDefault.Location = New Point(565, 16)
        btnACAlarmChimeDefault.Name = "btnACAlarmChimeDefault"
        btnACAlarmChimeDefault.Size = New Size(21, 21)
        btnACAlarmChimeDefault.TabIndex = 7
        TipInfoEX.SetText(btnACAlarmChimeDefault, "Use Default Chime")
        TipHCEX.SetText(btnACAlarmChimeDefault, Nothing)
        btnACAlarmChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        btnACAlarmChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' btnACAlarmChimePlay
        ' 
        btnACAlarmChimePlay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACAlarmChimePlay.FlatAppearance.BorderSize = 0
        btnACAlarmChimePlay.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnACAlarmChimePlay, Nothing)
        btnACAlarmChimePlay.Image = My.Resources.Resources.imageACPlay
        TipInfoEX.SetImage(btnACAlarmChimePlay, Nothing)
        btnACAlarmChimePlay.Location = New Point(542, 16)
        btnACAlarmChimePlay.Name = "btnACAlarmChimePlay"
        btnACAlarmChimePlay.Size = New Size(21, 21)
        btnACAlarmChimePlay.TabIndex = 6
        TipInfoEX.SetText(btnACAlarmChimePlay, "Play Sound")
        TipHCEX.SetText(btnACAlarmChimePlay, Nothing)
        btnACAlarmChimePlay.TextAlign = ContentAlignment.MiddleLeft
        btnACAlarmChimePlay.UseVisualStyleBackColor = True
        ' 
        ' btnACAlarmChimeManual
        ' 
        btnACAlarmChimeManual.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACAlarmChimeManual.FlatAppearance.BorderSize = 0
        btnACAlarmChimeManual.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnACAlarmChimeManual, Nothing)
        btnACAlarmChimeManual.Image = My.Resources.Resources.imageACFolder
        TipInfoEX.SetImage(btnACAlarmChimeManual, Nothing)
        btnACAlarmChimeManual.Location = New Point(590, 16)
        btnACAlarmChimeManual.Name = "btnACAlarmChimeManual"
        btnACAlarmChimeManual.Size = New Size(21, 21)
        btnACAlarmChimeManual.TabIndex = 8
        TipInfoEX.SetText(btnACAlarmChimeManual, "Select WAV File")
        TipHCEX.SetText(btnACAlarmChimeManual, Nothing)
        btnACAlarmChimeManual.TextAlign = ContentAlignment.MiddleLeft
        btnACAlarmChimeManual.UseVisualStyleBackColor = True
        ' 
        ' tabpageWL
        ' 
        tabpageWL.Controls.Add(panelWL)
        tabpageWL.Controls.Add(textboxWLMaxLinksPerFolder)
        tabpageWL.Controls.Add(textboxWLStartUpDelay)
        tabpageWL.Controls.Add(textboxWLAutoRefreshInterval)
        tabpageWL.Controls.Add(listviewWL)
        tabpageWL.Controls.Add(textboxWLAutoRefreshIdleInterval)
        tabpageWL.Controls.Add(lblWLAutoRefreshIdleInterval)
        tabpageWL.Controls.Add(lblWLAutoRefreshInterval)
        tabpageWL.Controls.Add(checkboxWLShowFilePathToolTips)
        tabpageWL.Controls.Add(lblWLMaxLinksPerFolder)
        tabpageWL.Controls.Add(lblWLStartUpDelay)
        tabpageWL.Controls.Add(checkboxWLAutoRefresh)
        tabpageWL.Controls.Add(checkboxWLShowFileInfoToolTips)
        tabpageWL.Controls.Add(checkboxWLShowFolderPathToolTips)
        tabpageWL.Controls.Add(lblWLAutoRefresh)
        tabpageWL.Controls.Add(btnWLRefresh)
        TipHCEX.SetImage(tabpageWL, Nothing)
        TipInfoEX.SetImage(tabpageWL, Nothing)
        tabpageWL.Location = New Point(4, 24)
        tabpageWL.Name = "tabpageWL"
        tabpageWL.Padding = New Padding(3)
        tabpageWL.Size = New Size(618, 375)
        tabpageWL.TabIndex = 8
        TipHCEX.SetText(tabpageWL, Nothing)
        TipInfoEX.SetText(tabpageWL, Nothing)
        tabpageWL.Text = """WinLinks"""
        tabpageWL.UseVisualStyleBackColor = True
        ' 
        ' panelWL
        ' 
        panelWL.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        panelWL.BorderStyle = BorderStyle.FixedSingle
        panelWL.Controls.Add(checkboxWLShowNoMenu)
        panelWL.Controls.Add(textboxWLName)
        panelWL.Controls.Add(checkboxWLShowMenuIcons)
        panelWL.Controls.Add(checkboxWLShowInTray)
        panelWL.Controls.Add(checkboxWLShowInMenu)
        panelWL.Controls.Add(comboboxWLFolderPlacement)
        panelWL.Controls.Add(comboboxWLFolderMode)
        panelWL.Controls.Add(comboboxWLSort)
        panelWL.Controls.Add(textboxWLRoot)
        panelWL.Controls.Add(btnWLSelectFolder)
        panelWL.Controls.Add(btnWLCancel)
        panelWL.Controls.Add(btnWLSet)
        panelWL.Controls.Add(checkboxWLUseDefaultIcon)
        panelWL.Controls.Add(label28)
        panelWL.Controls.Add(label29)
        panelWL.Controls.Add(label30)
        panelWL.Controls.Add(label2)
        panelWL.Controls.Add(lblWLRoot)
        TipInfoEX.SetImage(panelWL, Nothing)
        TipHCEX.SetImage(panelWL, Nothing)
        panelWL.Location = New Point(5, 215)
        panelWL.Name = "panelWL"
        panelWL.Size = New Size(606, 130)
        panelWL.TabIndex = 100
        TipHCEX.SetText(panelWL, Nothing)
        TipInfoEX.SetText(panelWL, Nothing)
        panelWL.Visible = False
        ' 
        ' checkboxWLShowNoMenu
        ' 
        checkboxWLShowNoMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(checkboxWLShowNoMenu, Nothing)
        TipHCEX.SetImage(checkboxWLShowNoMenu, Nothing)
        checkboxWLShowNoMenu.Location = New Point(479, 69)
        checkboxWLShowNoMenu.Name = "checkboxWLShowNoMenu"
        checkboxWLShowNoMenu.Size = New Size(124, 21)
        checkboxWLShowNoMenu.TabIndex = 66
        TipHCEX.SetText(checkboxWLShowNoMenu, Nothing)
        TipInfoEX.SetText(checkboxWLShowNoMenu, Nothing)
        checkboxWLShowNoMenu.Text = "No Menu Items"
        checkboxWLShowNoMenu.UseVisualStyleBackColor = True
        ' 
        ' textboxWLName
        ' 
        TipHCEX.SetImage(textboxWLName, Nothing)
        TipInfoEX.SetImage(textboxWLName, Nothing)
        textboxWLName.Location = New Point(7, 56)
        textboxWLName.Name = "textboxWLName"
        textboxWLName.Size = New Size(388, 25)
        textboxWLName.TabIndex = 15
        TipInfoEX.SetText(textboxWLName, Nothing)
        TipHCEX.SetText(textboxWLName, Nothing)
        ' 
        ' checkboxWLShowMenuIcons
        ' 
        checkboxWLShowMenuIcons.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(checkboxWLShowMenuIcons, Nothing)
        TipHCEX.SetImage(checkboxWLShowMenuIcons, Nothing)
        checkboxWLShowMenuIcons.Location = New Point(479, 53)
        checkboxWLShowMenuIcons.Name = "checkboxWLShowMenuIcons"
        checkboxWLShowMenuIcons.Size = New Size(129, 21)
        checkboxWLShowMenuIcons.TabIndex = 64
        TipHCEX.SetText(checkboxWLShowMenuIcons, Nothing)
        TipInfoEX.SetText(checkboxWLShowMenuIcons, Nothing)
        checkboxWLShowMenuIcons.Text = "Show Menu Icons"
        checkboxWLShowMenuIcons.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowInTray
        ' 
        checkboxWLShowInTray.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(checkboxWLShowInTray, Nothing)
        TipHCEX.SetImage(checkboxWLShowInTray, Nothing)
        checkboxWLShowInTray.Location = New Point(479, 37)
        checkboxWLShowInTray.Name = "checkboxWLShowInTray"
        checkboxWLShowInTray.Size = New Size(109, 21)
        checkboxWLShowInTray.TabIndex = 62
        TipHCEX.SetText(checkboxWLShowInTray, Nothing)
        TipInfoEX.SetText(checkboxWLShowInTray, Nothing)
        checkboxWLShowInTray.Text = "Show In Tray"
        checkboxWLShowInTray.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowInMenu
        ' 
        checkboxWLShowInMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(checkboxWLShowInMenu, Nothing)
        TipHCEX.SetImage(checkboxWLShowInMenu, Nothing)
        checkboxWLShowInMenu.Location = New Point(479, 21)
        checkboxWLShowInMenu.Name = "checkboxWLShowInMenu"
        checkboxWLShowInMenu.Size = New Size(109, 21)
        checkboxWLShowInMenu.TabIndex = 60
        TipHCEX.SetText(checkboxWLShowInMenu, Nothing)
        TipInfoEX.SetText(checkboxWLShowInMenu, Nothing)
        checkboxWLShowInMenu.Text = "Show In Menu"
        checkboxWLShowInMenu.UseVisualStyleBackColor = True
        ' 
        ' comboboxWLFolderPlacement
        ' 
        comboboxWLFolderPlacement.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxWLFolderPlacement.FormattingEnabled = True
        TipInfoEX.SetImage(comboboxWLFolderPlacement, Nothing)
        TipHCEX.SetImage(comboboxWLFolderPlacement, Nothing)
        comboboxWLFolderPlacement.Items.AddRange(New Object() {"Top", "Bottom", "Merged"})
        comboboxWLFolderPlacement.Location = New Point(253, 96)
        comboboxWLFolderPlacement.Name = "comboboxWLFolderPlacement"
        comboboxWLFolderPlacement.Size = New Size(85, 25)
        comboboxWLFolderPlacement.TabIndex = 40
        TipInfoEX.SetText(comboboxWLFolderPlacement, Nothing)
        TipHCEX.SetText(comboboxWLFolderPlacement, Nothing)
        ' 
        ' comboboxWLFolderMode
        ' 
        comboboxWLFolderMode.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxWLFolderMode.FormattingEnabled = True
        TipInfoEX.SetImage(comboboxWLFolderMode, Nothing)
        TipHCEX.SetImage(comboboxWLFolderMode, Nothing)
        comboboxWLFolderMode.Items.AddRange(New Object() {"No Folders", "Show As Link", "Show As Link Menu", "Show As Menu", "Folders Only"})
        comboboxWLFolderMode.Location = New Point(106, 96)
        comboboxWLFolderMode.Name = "comboboxWLFolderMode"
        comboboxWLFolderMode.Size = New Size(142, 25)
        comboboxWLFolderMode.TabIndex = 30
        TipInfoEX.SetText(comboboxWLFolderMode, Nothing)
        TipHCEX.SetText(comboboxWLFolderMode, Nothing)
        ' 
        ' comboboxWLSort
        ' 
        comboboxWLSort.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxWLSort.FormattingEnabled = True
        TipInfoEX.SetImage(comboboxWLSort, Nothing)
        TipHCEX.SetImage(comboboxWLSort, Nothing)
        comboboxWLSort.Items.AddRange(New Object() {"Ascending", "Descending"})
        comboboxWLSort.Location = New Point(7, 96)
        comboboxWLSort.Name = "comboboxWLSort"
        comboboxWLSort.Size = New Size(94, 25)
        comboboxWLSort.TabIndex = 20
        TipInfoEX.SetText(comboboxWLSort, Nothing)
        TipHCEX.SetText(comboboxWLSort, Nothing)
        ' 
        ' textboxWLRoot
        ' 
        TipHCEX.SetImage(textboxWLRoot, Nothing)
        TipInfoEX.SetImage(textboxWLRoot, Nothing)
        textboxWLRoot.Location = New Point(7, 19)
        textboxWLRoot.Name = "textboxWLRoot"
        textboxWLRoot.Size = New Size(388, 25)
        textboxWLRoot.TabIndex = 10
        TipInfoEX.SetText(textboxWLRoot, Nothing)
        TipHCEX.SetText(textboxWLRoot, Nothing)
        ' 
        ' btnWLSelectFolder
        ' 
        btnWLSelectFolder.FlatAppearance.BorderSize = 0
        btnWLSelectFolder.FlatStyle = FlatStyle.Flat
        TipHCEX.SetImage(btnWLSelectFolder, Nothing)
        btnWLSelectFolder.Image = My.Resources.Resources.imageRestore
        TipInfoEX.SetImage(btnWLSelectFolder, Nothing)
        btnWLSelectFolder.Location = New Point(393, 21)
        btnWLSelectFolder.Name = "btnWLSelectFolder"
        btnWLSelectFolder.Size = New Size(21, 21)
        btnWLSelectFolder.TabIndex = 10
        btnWLSelectFolder.TabStop = False
        TipInfoEX.SetText(btnWLSelectFolder, Nothing)
        TipHCEX.SetText(btnWLSelectFolder, Nothing)
        btnWLSelectFolder.UseVisualStyleBackColor = True
        ' 
        ' btnWLCancel
        ' 
        btnWLCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnWLCancel.ForeColor = Color.Navy
        TipHCEX.SetImage(btnWLCancel, Nothing)
        btnWLCancel.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnWLCancel, Nothing)
        btnWLCancel.ImageAlign = ContentAlignment.MiddleLeft
        btnWLCancel.Location = New Point(401, 96)
        btnWLCancel.Name = "btnWLCancel"
        btnWLCancel.Size = New Size(132, 26)
        btnWLCancel.TabIndex = 156
        TipInfoEX.SetText(btnWLCancel, Nothing)
        TipHCEX.SetText(btnWLCancel, Nothing)
        btnWLCancel.Text = "Cancel"
        btnWLCancel.TextAlign = ContentAlignment.MiddleRight
        btnWLCancel.UseVisualStyleBackColor = True
        ' 
        ' btnWLSet
        ' 
        btnWLSet.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnWLSet.ForeColor = Color.Navy
        TipHCEX.SetImage(btnWLSet, Nothing)
        btnWLSet.Image = My.Resources.Resources.imageGoStart
        TipInfoEX.SetImage(btnWLSet, Nothing)
        btnWLSet.ImageAlign = ContentAlignment.MiddleLeft
        btnWLSet.Location = New Point(532, 96)
        btnWLSet.Name = "btnWLSet"
        btnWLSet.Size = New Size(66, 26)
        btnWLSet.TabIndex = 157
        TipInfoEX.SetText(btnWLSet, Nothing)
        TipHCEX.SetText(btnWLSet, Nothing)
        btnWLSet.Text = "Set"
        btnWLSet.TextAlign = ContentAlignment.MiddleRight
        btnWLSet.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLUseDefaultIcon
        ' 
        TipInfoEX.SetImage(checkboxWLUseDefaultIcon, Nothing)
        TipHCEX.SetImage(checkboxWLUseDefaultIcon, Nothing)
        checkboxWLUseDefaultIcon.Location = New Point(479, 5)
        checkboxWLUseDefaultIcon.Name = "checkboxWLUseDefaultIcon"
        checkboxWLUseDefaultIcon.Size = New Size(122, 21)
        checkboxWLUseDefaultIcon.TabIndex = 9
        TipHCEX.SetText(checkboxWLUseDefaultIcon, Nothing)
        TipInfoEX.SetText(checkboxWLUseDefaultIcon, Nothing)
        checkboxWLUseDefaultIcon.Text = "Use Default Icon"
        checkboxWLUseDefaultIcon.UseVisualStyleBackColor = True
        ' 
        ' label28
        ' 
        TipHCEX.SetImage(label28, Nothing)
        TipInfoEX.SetImage(label28, Nothing)
        label28.Location = New Point(5, 81)
        label28.Name = "label28"
        label28.Size = New Size(58, 21)
        label28.TabIndex = 165
        TipHCEX.SetText(label28, Nothing)
        label28.Text = "Sort Order"
        TipInfoEX.SetText(label28, Nothing)
        ' 
        ' label29
        ' 
        TipHCEX.SetImage(label29, Nothing)
        TipInfoEX.SetImage(label29, Nothing)
        label29.Location = New Point(104, 81)
        label29.Name = "label29"
        label29.Size = New Size(74, 21)
        label29.TabIndex = 161
        TipHCEX.SetText(label29, Nothing)
        label29.Text = "Folder Mode"
        TipInfoEX.SetText(label29, Nothing)
        ' 
        ' label30
        ' 
        TipHCEX.SetImage(label30, Nothing)
        TipInfoEX.SetImage(label30, Nothing)
        label30.Location = New Point(251, 81)
        label30.Name = "label30"
        label30.Size = New Size(89, 21)
        label30.TabIndex = 166
        TipHCEX.SetText(label30, Nothing)
        label30.Text = "Folder Placement"
        TipInfoEX.SetText(label30, Nothing)
        ' 
        ' label2
        ' 
        TipHCEX.SetImage(label2, Nothing)
        TipInfoEX.SetImage(label2, Nothing)
        label2.Location = New Point(5, 41)
        label2.Name = "label2"
        label2.Size = New Size(95, 21)
        label2.TabIndex = 168
        TipHCEX.SetText(label2, Nothing)
        label2.Text = "Display Name"
        TipInfoEX.SetText(label2, "Leave Blank To Use FolderName")
        ' 
        ' lblWLRoot
        ' 
        TipHCEX.SetImage(lblWLRoot, Nothing)
        TipInfoEX.SetImage(lblWLRoot, Nothing)
        lblWLRoot.Location = New Point(5, 4)
        lblWLRoot.Name = "lblWLRoot"
        lblWLRoot.Size = New Size(322, 21)
        lblWLRoot.TabIndex = 160
        TipHCEX.SetText(lblWLRoot, Nothing)
        lblWLRoot.Text = "SAMPLE"
        TipInfoEX.SetText(lblWLRoot, Nothing)
        ' 
        ' textboxWLMaxLinksPerFolder
        ' 
        TipHCEX.SetImage(textboxWLMaxLinksPerFolder, Nothing)
        TipInfoEX.SetImage(textboxWLMaxLinksPerFolder, Nothing)
        textboxWLMaxLinksPerFolder.Location = New Point(5, 34)
        textboxWLMaxLinksPerFolder.MaxLength = 3
        textboxWLMaxLinksPerFolder.Name = "textboxWLMaxLinksPerFolder"
        textboxWLMaxLinksPerFolder.Size = New Size(44, 25)
        textboxWLMaxLinksPerFolder.TabIndex = 5
        TipInfoEX.SetText(textboxWLMaxLinksPerFolder, Nothing)
        TipHCEX.SetText(textboxWLMaxLinksPerFolder, Nothing)
        textboxWLMaxLinksPerFolder.TextAlign = HorizontalAlignment.Center
        ' 
        ' textboxWLStartUpDelay
        ' 
        TipHCEX.SetImage(textboxWLStartUpDelay, Nothing)
        TipInfoEX.SetImage(textboxWLStartUpDelay, Nothing)
        textboxWLStartUpDelay.Location = New Point(5, 8)
        textboxWLStartUpDelay.MaxLength = 3
        textboxWLStartUpDelay.Name = "textboxWLStartUpDelay"
        textboxWLStartUpDelay.Size = New Size(44, 25)
        textboxWLStartUpDelay.TabIndex = 4
        TipInfoEX.SetText(textboxWLStartUpDelay, Nothing)
        TipHCEX.SetText(textboxWLStartUpDelay, Nothing)
        textboxWLStartUpDelay.TextAlign = HorizontalAlignment.Center
        ' 
        ' textboxWLAutoRefreshInterval
        ' 
        textboxWLAutoRefreshInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipHCEX.SetImage(textboxWLAutoRefreshInterval, Nothing)
        TipInfoEX.SetImage(textboxWLAutoRefreshInterval, Nothing)
        textboxWLAutoRefreshInterval.Location = New Point(567, 8)
        textboxWLAutoRefreshInterval.MaxLength = 2
        textboxWLAutoRefreshInterval.Name = "textboxWLAutoRefreshInterval"
        textboxWLAutoRefreshInterval.Size = New Size(44, 25)
        textboxWLAutoRefreshInterval.TabIndex = 20
        TipInfoEX.SetText(textboxWLAutoRefreshInterval, Nothing)
        TipHCEX.SetText(textboxWLAutoRefreshInterval, Nothing)
        textboxWLAutoRefreshInterval.TextAlign = HorizontalAlignment.Center
        ' 
        ' listviewWL
        ' 
        listviewWL.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        listviewWL.BorderStyle = BorderStyle.FixedSingle
        listviewWL.ContextMenuStrip = cmlistviewWL
        listviewWL.FullRowSelect = True
        listviewWL.HeaderStyle = ColumnHeaderStyle.None
        TipHCEX.SetImage(listviewWL, Nothing)
        TipInfoEX.SetImage(listviewWL, Nothing)
        listviewWL.LabelWrap = False
        listviewWL.Location = New Point(5, 105)
        listviewWL.MultiSelect = False
        listviewWL.Name = "listviewWL"
        listviewWL.ShowGroups = False
        listviewWL.ShowItemToolTips = True
        listviewWL.Size = New Size(606, 111)
        listviewWL.TabIndex = 50
        TipHCEX.SetText(listviewWL, Nothing)
        TipInfoEX.SetText(listviewWL, Nothing)
        listviewWL.UseCompatibleStateImageBehavior = False
        listviewWL.View = View.Details
        ' 
        ' cmlistviewWL
        ' 
        cmlistviewWL.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TipInfoEX.SetImage(cmlistviewWL, Nothing)
        TipHCEX.SetImage(cmlistviewWL, Nothing)
        cmlistviewWL.Items.AddRange(New ToolStripItem() {cmiWLMoveUp, cmiWLMoveDown, toolStripSeparator11, cmiWLNew, toolStripSeparator6, cmiWLDelete})
        cmlistviewWL.Name = "contextmenulistviewHotLinks"
        cmlistviewWL.Size = New Size(125, 120)
        TipInfoEX.SetText(cmlistviewWL, Nothing)
        TipHCEX.SetText(cmlistviewWL, Nothing)
        ' 
        ' cmiWLMoveUp
        ' 
        cmiWLMoveUp.Image = My.Resources.Resources.imageMoveUp
        cmiWLMoveUp.Name = "cmiWLMoveUp"
        cmiWLMoveUp.Size = New Size(124, 26)
        cmiWLMoveUp.Text = "Up"
        ' 
        ' cmiWLMoveDown
        ' 
        cmiWLMoveDown.Image = My.Resources.Resources.imageMoveDown
        cmiWLMoveDown.Name = "cmiWLMoveDown"
        cmiWLMoveDown.Size = New Size(124, 26)
        cmiWLMoveDown.Text = "Down"
        ' 
        ' toolStripSeparator11
        ' 
        toolStripSeparator11.Name = "toolStripSeparator11"
        toolStripSeparator11.Size = New Size(121, 6)
        ' 
        ' cmiWLNew
        ' 
        cmiWLNew.Image = My.Resources.Resources.imageWLNew
        cmiWLNew.Name = "cmiWLNew"
        cmiWLNew.Size = New Size(124, 26)
        ' 
        ' toolStripSeparator6
        ' 
        toolStripSeparator6.Name = "toolStripSeparator6"
        toolStripSeparator6.Size = New Size(121, 6)
        ' 
        ' cmiWLDelete
        ' 
        cmiWLDelete.Image = My.Resources.Resources.imageRemove
        cmiWLDelete.Name = "cmiWLDelete"
        cmiWLDelete.Size = New Size(124, 26)
        cmiWLDelete.Text = "Delete"
        ' 
        ' textboxWLAutoRefreshIdleInterval
        ' 
        textboxWLAutoRefreshIdleInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipHCEX.SetImage(textboxWLAutoRefreshIdleInterval, Nothing)
        TipInfoEX.SetImage(textboxWLAutoRefreshIdleInterval, Nothing)
        textboxWLAutoRefreshIdleInterval.Location = New Point(567, 34)
        textboxWLAutoRefreshIdleInterval.MaxLength = 3
        textboxWLAutoRefreshIdleInterval.Name = "textboxWLAutoRefreshIdleInterval"
        textboxWLAutoRefreshIdleInterval.Size = New Size(44, 25)
        textboxWLAutoRefreshIdleInterval.TabIndex = 22
        TipInfoEX.SetText(textboxWLAutoRefreshIdleInterval, Nothing)
        TipHCEX.SetText(textboxWLAutoRefreshIdleInterval, Nothing)
        textboxWLAutoRefreshIdleInterval.TextAlign = HorizontalAlignment.Center
        ' 
        ' checkboxWLShowFilePathToolTips
        ' 
        TipInfoEX.SetImage(checkboxWLShowFilePathToolTips, Nothing)
        TipHCEX.SetImage(checkboxWLShowFilePathToolTips, Nothing)
        checkboxWLShowFilePathToolTips.Location = New Point(5, 57)
        checkboxWLShowFilePathToolTips.Name = "checkboxWLShowFilePathToolTips"
        checkboxWLShowFilePathToolTips.Size = New Size(172, 21)
        checkboxWLShowFilePathToolTips.TabIndex = 11
        TipHCEX.SetText(checkboxWLShowFilePathToolTips, Nothing)
        TipInfoEX.SetText(checkboxWLShowFilePathToolTips, "Show Full File Path In ToolTip")
        checkboxWLShowFilePathToolTips.Text = "Show File Path In ToolTip"
        checkboxWLShowFilePathToolTips.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLAutoRefresh
        ' 
        checkboxWLAutoRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWLAutoRefresh.CheckAlign = ContentAlignment.MiddleRight
        TipInfoEX.SetImage(checkboxWLAutoRefresh, Nothing)
        TipHCEX.SetImage(checkboxWLAutoRefresh, Nothing)
        checkboxWLAutoRefresh.Location = New Point(471, 57)
        checkboxWLAutoRefresh.Name = "checkboxWLAutoRefresh"
        checkboxWLAutoRefresh.Size = New Size(141, 21)
        checkboxWLAutoRefresh.TabIndex = 24
        TipHCEX.SetText(checkboxWLAutoRefresh, Nothing)
        TipInfoEX.SetText(checkboxWLAutoRefresh, "Enable AutoRefresh For Last WinLink")
        checkboxWLAutoRefresh.Text = "Enable AutoRefresh"
        checkboxWLAutoRefresh.TextAlign = ContentAlignment.MiddleRight
        checkboxWLAutoRefresh.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowFileInfoToolTips
        ' 
        TipInfoEX.SetImage(checkboxWLShowFileInfoToolTips, Nothing)
        TipHCEX.SetImage(checkboxWLShowFileInfoToolTips, Nothing)
        checkboxWLShowFileInfoToolTips.Location = New Point(177, 57)
        checkboxWLShowFileInfoToolTips.Name = "checkboxWLShowFileInfoToolTips"
        checkboxWLShowFileInfoToolTips.Size = New Size(170, 21)
        checkboxWLShowFileInfoToolTips.TabIndex = 12
        TipHCEX.SetText(checkboxWLShowFileInfoToolTips, Nothing)
        TipInfoEX.SetText(checkboxWLShowFileInfoToolTips, "Show File Details In ToolTip")
        checkboxWLShowFileInfoToolTips.Text = "Show File Info In ToolTip"
        checkboxWLShowFileInfoToolTips.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowFolderPathToolTips
        ' 
        TipInfoEX.SetImage(checkboxWLShowFolderPathToolTips, Nothing)
        TipHCEX.SetImage(checkboxWLShowFolderPathToolTips, Nothing)
        checkboxWLShowFolderPathToolTips.Location = New Point(5, 75)
        checkboxWLShowFolderPathToolTips.Name = "checkboxWLShowFolderPathToolTips"
        checkboxWLShowFolderPathToolTips.Size = New Size(194, 21)
        checkboxWLShowFolderPathToolTips.TabIndex = 13
        TipHCEX.SetText(checkboxWLShowFolderPathToolTips, Nothing)
        TipInfoEX.SetText(checkboxWLShowFolderPathToolTips, "Show Full Directory Path In ToolTip")
        checkboxWLShowFolderPathToolTips.Text = "Show Folder Path In ToolTip"
        checkboxWLShowFolderPathToolTips.UseVisualStyleBackColor = True
        ' 
        ' lblWLAutoRefresh
        ' 
        lblWLAutoRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWLAutoRefresh.Enabled = False
        lblWLAutoRefresh.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TipHCEX.SetImage(lblWLAutoRefresh, Nothing)
        TipInfoEX.SetImage(lblWLAutoRefresh, Nothing)
        lblWLAutoRefresh.Location = New Point(472, 71)
        lblWLAutoRefresh.Name = "lblWLAutoRefresh"
        lblWLAutoRefresh.Size = New Size(141, 21)
        lblWLAutoRefresh.TabIndex = 26
        TipHCEX.SetText(lblWLAutoRefresh, Nothing)
        lblWLAutoRefresh.Text = "AutoRefresh Engaged"
        TipInfoEX.SetText(lblWLAutoRefresh, Nothing)
        lblWLAutoRefresh.TextAlign = ContentAlignment.MiddleLeft
        lblWLAutoRefresh.Visible = False
        ' 
        ' btnWLRefresh
        ' 
        btnWLRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipHCEX.SetImage(btnWLRefresh, Nothing)
        TipInfoEX.SetImage(btnWLRefresh, Nothing)
        btnWLRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnWLRefresh.Location = New Point(232, 79)
        btnWLRefresh.Name = "btnWLRefresh"
        btnWLRefresh.Size = New Size(153, 26)
        btnWLRefresh.TabIndex = 1
        btnWLRefresh.TabStop = False
        TipInfoEX.SetText(btnWLRefresh, "Refresh")
        TipHCEX.SetText(btnWLRefresh, Nothing)
        btnWLRefresh.Text = "FULL REFRESH"
        btnWLRefresh.TextAlign = ContentAlignment.MiddleRight
        btnWLRefresh.UseVisualStyleBackColor = True
        ' 
        ' tabpageHC
        ' 
        tabpageHC.Controls.Add(comboboxHCRight)
        tabpageHC.Controls.Add(comboboxHCMiddle)
        tabpageHC.Controls.Add(comboboxHCDouble)
        tabpageHC.Controls.Add(comboboxHCLeft)
        tabpageHC.Controls.Add(groupBox2)
        tabpageHC.Controls.Add(label17)
        tabpageHC.Controls.Add(label12)
        tabpageHC.Controls.Add(label16)
        tabpageHC.Controls.Add(label15)
        TipHCEX.SetImage(tabpageHC, Nothing)
        TipInfoEX.SetImage(tabpageHC, Nothing)
        tabpageHC.Location = New Point(4, 24)
        tabpageHC.Name = "tabpageHC"
        tabpageHC.Padding = New Padding(3)
        tabpageHC.Size = New Size(618, 375)
        tabpageHC.TabIndex = 6
        TipHCEX.SetText(tabpageHC, Nothing)
        TipInfoEX.SetText(tabpageHC, Nothing)
        tabpageHC.Text = """HotClicks"""
        tabpageHC.UseVisualStyleBackColor = True
        ' 
        ' comboboxHCRight
        ' 
        comboboxHCRight.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxHCRight.FormattingEnabled = True
        TipInfoEX.SetImage(comboboxHCRight, Nothing)
        TipHCEX.SetImage(comboboxHCRight, Nothing)
        comboboxHCRight.Location = New Point(210, 167)
        comboboxHCRight.Name = "comboboxHCRight"
        comboboxHCRight.Size = New Size(258, 25)
        comboboxHCRight.Sorted = True
        comboboxHCRight.TabIndex = 50
        TipInfoEX.SetText(comboboxHCRight, Nothing)
        TipHCEX.SetText(comboboxHCRight, Nothing)
        ' 
        ' comboboxHCMiddle
        ' 
        comboboxHCMiddle.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxHCMiddle.FormattingEnabled = True
        TipInfoEX.SetImage(comboboxHCMiddle, Nothing)
        TipHCEX.SetImage(comboboxHCMiddle, Nothing)
        comboboxHCMiddle.Location = New Point(210, 139)
        comboboxHCMiddle.Name = "comboboxHCMiddle"
        comboboxHCMiddle.Size = New Size(258, 25)
        comboboxHCMiddle.Sorted = True
        comboboxHCMiddle.TabIndex = 40
        TipInfoEX.SetText(comboboxHCMiddle, Nothing)
        TipHCEX.SetText(comboboxHCMiddle, Nothing)
        ' 
        ' comboboxHCDouble
        ' 
        comboboxHCDouble.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxHCDouble.FormattingEnabled = True
        TipInfoEX.SetImage(comboboxHCDouble, Nothing)
        TipHCEX.SetImage(comboboxHCDouble, Nothing)
        comboboxHCDouble.Location = New Point(210, 111)
        comboboxHCDouble.Name = "comboboxHCDouble"
        comboboxHCDouble.Size = New Size(258, 25)
        comboboxHCDouble.Sorted = True
        comboboxHCDouble.TabIndex = 30
        TipInfoEX.SetText(comboboxHCDouble, Nothing)
        TipHCEX.SetText(comboboxHCDouble, Nothing)
        ' 
        ' comboboxHCLeft
        ' 
        comboboxHCLeft.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxHCLeft.FormattingEnabled = True
        TipInfoEX.SetImage(comboboxHCLeft, Nothing)
        TipHCEX.SetImage(comboboxHCLeft, Nothing)
        comboboxHCLeft.Location = New Point(210, 83)
        comboboxHCLeft.Name = "comboboxHCLeft"
        comboboxHCLeft.Size = New Size(258, 25)
        comboboxHCLeft.Sorted = True
        comboboxHCLeft.TabIndex = 20
        TipInfoEX.SetText(comboboxHCLeft, Nothing)
        TipHCEX.SetText(comboboxHCLeft, Nothing)
        ' 
        ' groupBox2
        ' 
        groupBox2.Controls.Add(radiobtnHCWL)
        groupBox2.Controls.Add(radiobtnHCWSTSS)
        groupBox2.Controls.Add(radiobtnHCWST)
        TipHCEX.SetImage(groupBox2, Nothing)
        TipInfoEX.SetImage(groupBox2, Nothing)
        groupBox2.Location = New Point(172, 28)
        groupBox2.Name = "groupBox2"
        groupBox2.Size = New Size(296, 38)
        groupBox2.TabIndex = 10
        groupBox2.TabStop = False
        TipHCEX.SetText(groupBox2, Nothing)
        TipInfoEX.SetText(groupBox2, Nothing)
        ' 
        ' radiobtnHCWL
        ' 
        TipInfoEX.SetImage(radiobtnHCWL, Nothing)
        radiobtnHCWL.Image = My.Resources.Resources.imageWL
        TipHCEX.SetImage(radiobtnHCWL, Nothing)
        radiobtnHCWL.ImageAlign = ContentAlignment.MiddleLeft
        radiobtnHCWL.Location = New Point(205, 11)
        radiobtnHCWL.Name = "radiobtnHCWL"
        radiobtnHCWL.Size = New Size(40, 24)
        radiobtnHCWL.TabIndex = 4
        radiobtnHCWL.TabStop = True
        TipHCEX.SetText(radiobtnHCWL, "WinLinks")
        TipInfoEX.SetText(radiobtnHCWL, Nothing)
        radiobtnHCWL.TextAlign = ContentAlignment.MiddleCenter
        radiobtnHCWL.UseVisualStyleBackColor = True
        ' 
        ' radiobtnHCWSTSS
        ' 
        TipInfoEX.SetImage(radiobtnHCWSTSS, Nothing)
        radiobtnHCWSTSS.Image = My.Resources.Resources.imageWSTScreenSaverEnabled
        TipHCEX.SetImage(radiobtnHCWSTSS, Nothing)
        radiobtnHCWSTSS.ImageAlign = ContentAlignment.MiddleLeft
        radiobtnHCWSTSS.Location = New Point(107, 11)
        radiobtnHCWSTSS.Name = "radiobtnHCWSTSS"
        radiobtnHCWSTSS.Size = New Size(40, 24)
        radiobtnHCWSTSS.TabIndex = 1
        radiobtnHCWSTSS.TabStop = True
        TipHCEX.SetText(radiobtnHCWSTSS, "Screen Saver")
        TipInfoEX.SetText(radiobtnHCWSTSS, Nothing)
        radiobtnHCWSTSS.TextAlign = ContentAlignment.MiddleCenter
        radiobtnHCWSTSS.UseVisualStyleBackColor = True
        ' 
        ' radiobtnHCWST
        ' 
        TipInfoEX.SetImage(radiobtnHCWST, Nothing)
        radiobtnHCWST.Image = My.Resources.Resources.imageWST
        TipHCEX.SetImage(radiobtnHCWST, Nothing)
        radiobtnHCWST.ImageAlign = ContentAlignment.MiddleLeft
        radiobtnHCWST.Location = New Point(59, 11)
        radiobtnHCWST.Name = "radiobtnHCWST"
        radiobtnHCWST.Size = New Size(40, 24)
        radiobtnHCWST.TabIndex = 0
        radiobtnHCWST.TabStop = True
        TipHCEX.SetText(radiobtnHCWST, "WorkSpace Tools")
        TipInfoEX.SetText(radiobtnHCWST, Nothing)
        radiobtnHCWST.TextAlign = ContentAlignment.MiddleCenter
        radiobtnHCWST.UseMnemonic = False
        radiobtnHCWST.UseVisualStyleBackColor = False
        ' 
        ' label17
        ' 
        label17.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label17.ForeColor = Color.Navy
        TipHCEX.SetImage(label17, Nothing)
        TipInfoEX.SetImage(label17, Nothing)
        label17.Location = New Point(142, 114)
        label17.Name = "label17"
        label17.Size = New Size(64, 18)
        label17.TabIndex = 29
        TipHCEX.SetText(label17, Nothing)
        label17.Text = "DOUBLE"
        TipInfoEX.SetText(label17, Nothing)
        label17.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' label12
        ' 
        label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label12.ForeColor = Color.Navy
        TipHCEX.SetImage(label12, Nothing)
        TipInfoEX.SetImage(label12, Nothing)
        label12.Location = New Point(142, 86)
        label12.Name = "label12"
        label12.Size = New Size(64, 18)
        label12.TabIndex = 19
        TipHCEX.SetText(label12, Nothing)
        label12.Text = "LEFT"
        TipInfoEX.SetText(label12, Nothing)
        label12.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' label16
        ' 
        label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label16.ForeColor = Color.Navy
        TipHCEX.SetImage(label16, Nothing)
        TipInfoEX.SetImage(label16, Nothing)
        label16.Location = New Point(142, 142)
        label16.Name = "label16"
        label16.Size = New Size(64, 18)
        label16.TabIndex = 39
        TipHCEX.SetText(label16, Nothing)
        label16.Text = "MIDDLE"
        TipInfoEX.SetText(label16, Nothing)
        label16.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' label15
        ' 
        label15.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label15.ForeColor = Color.Navy
        TipHCEX.SetImage(label15, Nothing)
        TipInfoEX.SetImage(label15, Nothing)
        label15.Location = New Point(142, 170)
        label15.Name = "label15"
        label15.Size = New Size(64, 18)
        label15.TabIndex = 49
        TipHCEX.SetText(label15, Nothing)
        label15.Text = "RIGHT"
        TipInfoEX.SetText(label15, Nothing)
        label15.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' tabpageHK
        ' 
        tabpageHK.Controls.Add(textboxHKWL)
        tabpageHK.Controls.Add(textboxHKWSTClock)
        tabpageHK.Controls.Add(textboxHKWSTLockWorkSpace)
        tabpageHK.Controls.Add(btnHKSet)
        tabpageHK.Controls.Add(btnHKReset)
        tabpageHK.Controls.Add(textboxHKWSTScreenSaver)
        tabpageHK.Controls.Add(btnHKEnabled)
        tabpageHK.Controls.Add(lblHKWL)
        tabpageHK.Controls.Add(lblHKWSTClock)
        tabpageHK.Controls.Add(lblHKWSTStopWatch)
        tabpageHK.Controls.Add(lblHKWSTLockWorkSpace)
        tabpageHK.Controls.Add(lblHKWSTScreenSaver)
        tabpageHK.Controls.Add(btnHKWLDisable)
        tabpageHK.Controls.Add(btnHKWSTClockDisable)
        tabpageHK.Controls.Add(btnHKWSTLockWorkSpaceDisable)
        tabpageHK.Controls.Add(btnHKWSTScreenSaverDisable)
        TipHCEX.SetImage(tabpageHK, Nothing)
        TipInfoEX.SetImage(tabpageHK, Nothing)
        tabpageHK.Location = New Point(4, 24)
        tabpageHK.Name = "tabpageHK"
        tabpageHK.Padding = New Padding(3)
        tabpageHK.Size = New Size(618, 375)
        tabpageHK.TabIndex = 5
        TipHCEX.SetText(tabpageHK, Nothing)
        TipInfoEX.SetText(tabpageHK, Nothing)
        tabpageHK.Text = """HotKeys"""
        tabpageHK.UseVisualStyleBackColor = True
        ' 
        ' textboxHKWL
        ' 
        textboxHKWL.Anchor = AnchorStyles.Top
        TipHCEX.SetImage(textboxHKWL, Nothing)
        TipInfoEX.SetImage(textboxHKWL, Nothing)
        textboxHKWL.Location = New Point(449, 24)
        textboxHKWL.Name = "textboxHKWL"
        textboxHKWL.ShortcutsEnabled = False
        textboxHKWL.Size = New Size(143, 25)
        textboxHKWL.TabIndex = 118
        textboxHKWL.TabStop = False
        TipInfoEX.SetText(textboxHKWL, Nothing)
        TipHCEX.SetText(textboxHKWL, Nothing)
        textboxHKWL.TextAlign = HorizontalAlignment.Center
        textboxHKWL.WordWrap = False
        ' 
        ' textboxHKWSTClock
        ' 
        TipHCEX.SetImage(textboxHKWSTClock, Nothing)
        TipInfoEX.SetImage(textboxHKWSTClock, Nothing)
        textboxHKWSTClock.Location = New Point(9, 65)
        textboxHKWSTClock.Name = "textboxHKWSTClock"
        textboxHKWSTClock.ShortcutsEnabled = False
        textboxHKWSTClock.Size = New Size(143, 25)
        textboxHKWSTClock.TabIndex = 41
        textboxHKWSTClock.TabStop = False
        TipInfoEX.SetText(textboxHKWSTClock, Nothing)
        TipHCEX.SetText(textboxHKWSTClock, Nothing)
        textboxHKWSTClock.TextAlign = HorizontalAlignment.Center
        textboxHKWSTClock.WordWrap = False
        ' 
        ' textboxHKWSTLockWorkSpace
        ' 
        TipHCEX.SetImage(textboxHKWSTLockWorkSpace, Nothing)
        TipInfoEX.SetImage(textboxHKWSTLockWorkSpace, Nothing)
        textboxHKWSTLockWorkSpace.Location = New Point(9, 147)
        textboxHKWSTLockWorkSpace.Name = "textboxHKWSTLockWorkSpace"
        textboxHKWSTLockWorkSpace.ShortcutsEnabled = False
        textboxHKWSTLockWorkSpace.Size = New Size(143, 25)
        textboxHKWSTLockWorkSpace.TabIndex = 12
        textboxHKWSTLockWorkSpace.TabStop = False
        TipInfoEX.SetText(textboxHKWSTLockWorkSpace, Nothing)
        TipHCEX.SetText(textboxHKWSTLockWorkSpace, Nothing)
        textboxHKWSTLockWorkSpace.TextAlign = HorizontalAlignment.Center
        textboxHKWSTLockWorkSpace.WordWrap = False
        ' 
        ' btnHKSet
        ' 
        btnHKSet.Anchor = AnchorStyles.Top
        btnHKSet.Enabled = False
        btnHKSet.ForeColor = Color.Navy
        TipHCEX.SetImage(btnHKSet, Nothing)
        btnHKSet.Image = My.Resources.Resources.imageGoStart
        TipInfoEX.SetImage(btnHKSet, Nothing)
        btnHKSet.ImageAlign = ContentAlignment.MiddleLeft
        btnHKSet.Location = New Point(82, 315)
        btnHKSet.Name = "btnHKSet"
        btnHKSet.Size = New Size(72, 32)
        btnHKSet.TabIndex = 1010
        TipInfoEX.SetText(btnHKSet, Nothing)
        TipHCEX.SetText(btnHKSet, Nothing)
        btnHKSet.Text = "Set"
        btnHKSet.TextAlign = ContentAlignment.MiddleRight
        btnHKSet.UseVisualStyleBackColor = True
        ' 
        ' btnHKReset
        ' 
        btnHKReset.Enabled = False
        btnHKReset.ForeColor = Color.Navy
        TipHCEX.SetImage(btnHKReset, Nothing)
        btnHKReset.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnHKReset, Nothing)
        btnHKReset.ImageAlign = ContentAlignment.MiddleLeft
        btnHKReset.Location = New Point(4, 315)
        btnHKReset.Name = "btnHKReset"
        btnHKReset.Size = New Size(72, 32)
        btnHKReset.TabIndex = 1000
        TipInfoEX.SetText(btnHKReset, Nothing)
        TipHCEX.SetText(btnHKReset, Nothing)
        btnHKReset.Text = "Undo"
        btnHKReset.TextAlign = ContentAlignment.MiddleRight
        btnHKReset.UseVisualStyleBackColor = True
        ' 
        ' textboxHKWSTScreenSaver
        ' 
        TipHCEX.SetImage(textboxHKWSTScreenSaver, Nothing)
        TipInfoEX.SetImage(textboxHKWSTScreenSaver, Nothing)
        textboxHKWSTScreenSaver.Location = New Point(9, 24)
        textboxHKWSTScreenSaver.Name = "textboxHKWSTScreenSaver"
        textboxHKWSTScreenSaver.ShortcutsEnabled = False
        textboxHKWSTScreenSaver.Size = New Size(143, 25)
        textboxHKWSTScreenSaver.TabIndex = 28
        textboxHKWSTScreenSaver.TabStop = False
        TipInfoEX.SetText(textboxHKWSTScreenSaver, Nothing)
        TipHCEX.SetText(textboxHKWSTScreenSaver, Nothing)
        textboxHKWSTScreenSaver.TextAlign = HorizontalAlignment.Center
        textboxHKWSTScreenSaver.WordWrap = False
        ' 
        ' btnHKEnabled
        ' 
        btnHKEnabled.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnHKEnabled.ForeColor = Color.Navy
        TipHCEX.SetImage(btnHKEnabled, Nothing)
        TipInfoEX.SetImage(btnHKEnabled, Nothing)
        btnHKEnabled.ImageAlign = ContentAlignment.MiddleLeft
        btnHKEnabled.Location = New Point(478, 315)
        btnHKEnabled.Name = "btnHKEnabled"
        btnHKEnabled.Size = New Size(134, 32)
        btnHKEnabled.TabIndex = 1020
        TipInfoEX.SetText(btnHKEnabled, Nothing)
        TipHCEX.SetText(btnHKEnabled, Nothing)
        btnHKEnabled.TextAlign = ContentAlignment.MiddleRight
        btnHKEnabled.UseVisualStyleBackColor = True
        ' 
        ' lblHKWL
        ' 
        lblHKWL.Anchor = AnchorStyles.Top
        lblHKWL.ForeColor = SystemColors.ControlText
        TipHCEX.SetImage(lblHKWL, Nothing)
        TipInfoEX.SetImage(lblHKWL, Nothing)
        lblHKWL.Location = New Point(449, 8)
        lblHKWL.Name = "lblHKWL"
        lblHKWL.Size = New Size(143, 14)
        lblHKWL.TabIndex = 117
        TipHCEX.SetText(lblHKWL, Nothing)
        TipInfoEX.SetText(lblHKWL, Nothing)
        lblHKWL.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHKWSTClock
        ' 
        lblHKWSTClock.ForeColor = SystemColors.ControlText
        TipHCEX.SetImage(lblHKWSTClock, Nothing)
        TipInfoEX.SetImage(lblHKWSTClock, Nothing)
        lblHKWSTClock.Location = New Point(9, 49)
        lblHKWSTClock.Name = "lblHKWSTClock"
        lblHKWSTClock.Size = New Size(143, 14)
        lblHKWSTClock.TabIndex = 40
        TipHCEX.SetText(lblHKWSTClock, Nothing)
        TipInfoEX.SetText(lblHKWSTClock, Nothing)
        lblHKWSTClock.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHKWSTStopWatch
        ' 
        lblHKWSTStopWatch.ForeColor = SystemColors.ControlText
        TipHCEX.SetImage(lblHKWSTStopWatch, Nothing)
        TipInfoEX.SetImage(lblHKWSTStopWatch, Nothing)
        lblHKWSTStopWatch.Location = New Point(9, 90)
        lblHKWSTStopWatch.Name = "lblHKWSTStopWatch"
        lblHKWSTStopWatch.Size = New Size(143, 14)
        lblHKWSTStopWatch.TabIndex = 23
        TipHCEX.SetText(lblHKWSTStopWatch, Nothing)
        TipInfoEX.SetText(lblHKWSTStopWatch, Nothing)
        lblHKWSTStopWatch.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHKWSTLockWorkSpace
        ' 
        lblHKWSTLockWorkSpace.ForeColor = SystemColors.ControlText
        TipHCEX.SetImage(lblHKWSTLockWorkSpace, Nothing)
        TipInfoEX.SetImage(lblHKWSTLockWorkSpace, Nothing)
        lblHKWSTLockWorkSpace.Location = New Point(9, 131)
        lblHKWSTLockWorkSpace.Name = "lblHKWSTLockWorkSpace"
        lblHKWSTLockWorkSpace.Size = New Size(143, 14)
        lblHKWSTLockWorkSpace.TabIndex = 10
        TipHCEX.SetText(lblHKWSTLockWorkSpace, Nothing)
        TipInfoEX.SetText(lblHKWSTLockWorkSpace, Nothing)
        lblHKWSTLockWorkSpace.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHKWSTScreenSaver
        ' 
        lblHKWSTScreenSaver.ForeColor = SystemColors.ControlText
        TipHCEX.SetImage(lblHKWSTScreenSaver, Nothing)
        TipInfoEX.SetImage(lblHKWSTScreenSaver, Nothing)
        lblHKWSTScreenSaver.Location = New Point(9, 8)
        lblHKWSTScreenSaver.Name = "lblHKWSTScreenSaver"
        lblHKWSTScreenSaver.Size = New Size(143, 14)
        lblHKWSTScreenSaver.TabIndex = 27
        TipHCEX.SetText(lblHKWSTScreenSaver, Nothing)
        TipInfoEX.SetText(lblHKWSTScreenSaver, Nothing)
        lblHKWSTScreenSaver.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' btnHKWLDisable
        ' 
        btnHKWLDisable.Anchor = AnchorStyles.Top
        btnHKWLDisable.FlatStyle = FlatStyle.Flat
        btnHKWLDisable.ForeColor = Color.Transparent
        TipHCEX.SetImage(btnHKWLDisable, Nothing)
        btnHKWLDisable.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnHKWLDisable, Nothing)
        btnHKWLDisable.Location = New Point(589, 26)
        btnHKWLDisable.Name = "btnHKWLDisable"
        btnHKWLDisable.Size = New Size(20, 20)
        btnHKWLDisable.TabIndex = 119
        btnHKWLDisable.TabStop = False
        TipInfoEX.SetText(btnHKWLDisable, Nothing)
        TipHCEX.SetText(btnHKWLDisable, Nothing)
        btnHKWLDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHKWSTClockDisable
        ' 
        btnHKWSTClockDisable.FlatStyle = FlatStyle.Flat
        btnHKWSTClockDisable.ForeColor = Color.Transparent
        TipHCEX.SetImage(btnHKWSTClockDisable, Nothing)
        btnHKWSTClockDisable.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnHKWSTClockDisable, Nothing)
        btnHKWSTClockDisable.Location = New Point(149, 67)
        btnHKWSTClockDisable.Name = "btnHKWSTClockDisable"
        btnHKWSTClockDisable.Size = New Size(20, 20)
        btnHKWSTClockDisable.TabIndex = 42
        btnHKWSTClockDisable.TabStop = False
        TipInfoEX.SetText(btnHKWSTClockDisable, Nothing)
        TipHCEX.SetText(btnHKWSTClockDisable, Nothing)
        btnHKWSTClockDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHKWSTLockWorkSpaceDisable
        ' 
        btnHKWSTLockWorkSpaceDisable.FlatStyle = FlatStyle.Flat
        btnHKWSTLockWorkSpaceDisable.ForeColor = Color.Transparent
        TipHCEX.SetImage(btnHKWSTLockWorkSpaceDisable, Nothing)
        btnHKWSTLockWorkSpaceDisable.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnHKWSTLockWorkSpaceDisable, Nothing)
        btnHKWSTLockWorkSpaceDisable.Location = New Point(149, 149)
        btnHKWSTLockWorkSpaceDisable.Name = "btnHKWSTLockWorkSpaceDisable"
        btnHKWSTLockWorkSpaceDisable.Size = New Size(20, 20)
        btnHKWSTLockWorkSpaceDisable.TabIndex = 14
        btnHKWSTLockWorkSpaceDisable.TabStop = False
        TipInfoEX.SetText(btnHKWSTLockWorkSpaceDisable, Nothing)
        TipHCEX.SetText(btnHKWSTLockWorkSpaceDisable, Nothing)
        btnHKWSTLockWorkSpaceDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHKWSTScreenSaverDisable
        ' 
        btnHKWSTScreenSaverDisable.FlatStyle = FlatStyle.Flat
        btnHKWSTScreenSaverDisable.ForeColor = Color.Transparent
        TipHCEX.SetImage(btnHKWSTScreenSaverDisable, Nothing)
        btnHKWSTScreenSaverDisable.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnHKWSTScreenSaverDisable, Nothing)
        btnHKWSTScreenSaverDisable.Location = New Point(149, 26)
        btnHKWSTScreenSaverDisable.Name = "btnHKWSTScreenSaverDisable"
        btnHKWSTScreenSaverDisable.Size = New Size(20, 20)
        btnHKWSTScreenSaverDisable.TabIndex = 29
        btnHKWSTScreenSaverDisable.TabStop = False
        TipInfoEX.SetText(btnHKWSTScreenSaverDisable, Nothing)
        TipHCEX.SetText(btnHKWSTScreenSaverDisable, Nothing)
        btnHKWSTScreenSaverDisable.UseVisualStyleBackColor = True
        ' 
        ' btnErrorTest
        ' 
        btnErrorTest.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnErrorTest.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnErrorTest.FlatAppearance.BorderSize = 0
        btnErrorTest.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnErrorTest.FlatAppearance.MouseOverBackColor = Color.Transparent
        TipHCEX.SetImage(btnErrorTest, Nothing)
        btnErrorTest.Image = My.Resources.Resources.imageError
        TipInfoEX.SetImage(btnErrorTest, Nothing)
        btnErrorTest.Location = New Point(368, 432)
        btnErrorTest.Name = "btnErrorTest"
        btnErrorTest.Size = New Size(24, 24)
        btnErrorTest.TabIndex = 0
        btnErrorTest.TabStop = False
        TipInfoEX.SetText(btnErrorTest, Nothing)
        TipHCEX.SetText(btnErrorTest, Nothing)
        btnErrorTest.Visible = False
        ' 
        ' btnClockTest
        ' 
        btnClockTest.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClockTest.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnClockTest.FlatAppearance.BorderSize = 0
        btnClockTest.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnClockTest.FlatAppearance.MouseOverBackColor = Color.Transparent
        TipHCEX.SetImage(btnClockTest, Nothing)
        btnClockTest.Image = My.Resources.Resources.imageWSTClock
        TipInfoEX.SetImage(btnClockTest, Nothing)
        btnClockTest.Location = New Point(398, 432)
        btnClockTest.Name = "btnClockTest"
        btnClockTest.Size = New Size(24, 24)
        btnClockTest.TabIndex = 0
        btnClockTest.TabStop = False
        TipInfoEX.SetText(btnClockTest, Nothing)
        TipHCEX.SetText(btnClockTest, Nothing)
        btnClockTest.Visible = False
        ' 
        ' btnInfo
        ' 
        btnInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnInfo.CausesValidation = False
        btnInfo.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnInfo.FlatAppearance.BorderSize = 0
        btnInfo.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnInfo.FlatAppearance.MouseOverBackColor = Color.Transparent
        TipHCEX.SetImage(btnInfo, Nothing)
        btnInfo.Image = My.Resources.Resources.imageInfo
        TipInfoEX.SetImage(btnInfo, Nothing)
        btnInfo.ImageAlign = ContentAlignment.TopLeft
        btnInfo.Location = New Point(140, 420)
        btnInfo.Name = "btnInfo"
        btnInfo.Size = New Size(62, 46)
        btnInfo.TabIndex = 0
        btnInfo.TabStop = False
        TipInfoEX.SetText(btnInfo, "Help & About" & vbCrLf & "RightClick = Show Maximized")
        TipHCEX.SetText(btnInfo, Nothing)
        btnInfo.Text = "Help"
        btnInfo.TextAlign = ContentAlignment.BottomRight
        ' 
        ' btnLog
        ' 
        btnLog.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLog.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnLog.FlatAppearance.BorderSize = 0
        btnLog.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnLog.FlatAppearance.MouseOverBackColor = Color.Transparent
        TipHCEX.SetImage(btnLog, Nothing)
        btnLog.Image = My.Resources.Resources.imageLog
        TipInfoEX.SetImage(btnLog, Nothing)
        btnLog.ImageAlign = ContentAlignment.TopLeft
        btnLog.Location = New Point(201, 420)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(62, 46)
        btnLog.TabIndex = 0
        btnLog.TabStop = False
        TipInfoEX.SetText(btnLog, "Show Log")
        TipHCEX.SetText(btnLog, Nothing)
        btnLog.Text = "Log"
        btnLog.TextAlign = ContentAlignment.BottomRight
        ' 
        ' cmWSTScreenSaver
        ' 
        cmWSTScreenSaver.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TipInfoEX.SetImage(cmWSTScreenSaver, Nothing)
        TipHCEX.SetImage(cmWSTScreenSaver, Nothing)
        cmWSTScreenSaver.Items.AddRange(New ToolStripItem() {cmiScreenSaverActivate, cmiScreenSaverEnabled, toolStripSeparator1, cmiScreenSaverSettings, toolStripSeparator12, cmiScreenSaverClose, cmiScreenSaverCloseAll})
        cmWSTScreenSaver.Name = "contextmenuWorkSpaceTools"
        cmWSTScreenSaver.ShowItemToolTips = False
        cmWSTScreenSaver.Size = New Size(245, 146)
        TipInfoEX.SetText(cmWSTScreenSaver, Nothing)
        TipHCEX.SetText(cmWSTScreenSaver, Nothing)
        ' 
        ' cmiScreenSaverActivate
        ' 
        cmiScreenSaverActivate.Name = "cmiScreenSaverActivate"
        cmiScreenSaverActivate.Size = New Size(244, 26)
        cmiScreenSaverActivate.Text = "Activate Screen Saver"
        ' 
        ' cmiScreenSaverEnabled
        ' 
        cmiScreenSaverEnabled.Name = "cmiScreenSaverEnabled"
        cmiScreenSaverEnabled.Size = New Size(244, 26)
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(241, 6)
        ' 
        ' cmiScreenSaverSettings
        ' 
        cmiScreenSaverSettings.Image = My.Resources.Resources.imageSettings
        cmiScreenSaverSettings.Name = "cmiScreenSaverSettings"
        cmiScreenSaverSettings.Size = New Size(244, 26)
        cmiScreenSaverSettings.Text = "Settings"
        ' 
        ' toolStripSeparator12
        ' 
        toolStripSeparator12.Name = "toolStripSeparator12"
        toolStripSeparator12.Size = New Size(241, 6)
        ' 
        ' cmiScreenSaverClose
        ' 
        cmiScreenSaverClose.Image = My.Resources.Resources.imageClose
        cmiScreenSaverClose.Name = "cmiScreenSaverClose"
        cmiScreenSaverClose.Size = New Size(244, 26)
        cmiScreenSaverClose.Text = "Close Screen Saver Tool"
        ' 
        ' cmiScreenSaverCloseAll
        ' 
        cmiScreenSaverCloseAll.Image = My.Resources.Resources.imageClose
        cmiScreenSaverCloseAll.Name = "cmiScreenSaverCloseAll"
        cmiScreenSaverCloseAll.Size = New Size(244, 26)
        cmiScreenSaverCloseAll.Text = "Exit YMTools"
        ' 
        ' tableLayoutPanel2
        ' 
        tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        tableLayoutPanel2.ColumnCount = 2
        tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TipInfoEX.SetImage(tableLayoutPanel2, Nothing)
        TipHCEX.SetImage(tableLayoutPanel2, Nothing)
        tableLayoutPanel2.Location = New Point(0, 0)
        tableLayoutPanel2.Name = "tableLayoutPanel2"
        tableLayoutPanel2.RowCount = 4
        tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tableLayoutPanel2.Size = New Size(200, 100)
        tableLayoutPanel2.TabIndex = 0
        TipInfoEX.SetText(tableLayoutPanel2, Nothing)
        TipHCEX.SetText(tableLayoutPanel2, Nothing)
        ' 
        ' TipInfoEX
        ' 
        TipInfoEX.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TipInfoEX.ShadowAlpha = 0
        TipInfoEX.ShadowThickness = 0
        ' 
        ' BtnSettings
        ' 
        BtnSettings.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnSettings.FlatAppearance.BorderColor = SystemColors.ControlDark
        BtnSettings.FlatAppearance.BorderSize = 0
        BtnSettings.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnSettings.FlatAppearance.MouseOverBackColor = Color.Transparent
        TipHCEX.SetImage(BtnSettings, Nothing)
        BtnSettings.Image = My.Resources.Resources.imageSettings
        TipInfoEX.SetImage(BtnSettings, Nothing)
        BtnSettings.ImageAlign = ContentAlignment.TopLeft
        BtnSettings.Location = New Point(286, 420)
        BtnSettings.Name = "BtnSettings"
        BtnSettings.Size = New Size(62, 46)
        BtnSettings.TabIndex = 11
        BtnSettings.TabStop = False
        TipInfoEX.SetText(BtnSettings, "Show Log")
        TipHCEX.SetText(BtnSettings, Nothing)
        BtnSettings.Text = "Settings"
        BtnSettings.TextAlign = ContentAlignment.BottomRight
        ' 
        ' TipHCEX
        ' 
        TipHCEX.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TipHCEX.ShadowAlpha = 0
        TipHCEX.ShadowThickness = 0
        ' 
        ' MainForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        AutoValidate = AutoValidate.EnableAllowFocusChange
        ClientSize = New Size(638, 477)
        Controls.Add(BtnSettings)
        Controls.Add(btnInfo)
        Controls.Add(btnLog)
        Controls.Add(btnSettingsSave)
        Controls.Add(btnSettingsRestore)
        Controls.Add(btnClose)
        Controls.Add(tabcontrolSettings)
        Controls.Add(btnClockTest)
        Controls.Add(btnErrorTest)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = My.Resources.Resources.iconSettings
        TipHCEX.SetImage(Me, Nothing)
        TipInfoEX.SetImage(Me, Nothing)
        Location = New Point(0, 186)
        MaximizeBox = False
        Name = "MainForm"
        Opacity = 0R
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        TipInfoEX.SetText(Me, Nothing)
        TipHCEX.SetText(Me, Nothing)
        cmWST.ResumeLayout(False)
        tabcontrolSettings.ResumeLayout(False)
        tabpageWST.ResumeLayout(False)
        tabpageWST.PerformLayout()
        groupboxWSTSS.ResumeLayout(False)
        tabpageAC.ResumeLayout(False)
        tabpageAC.PerformLayout()
        groupboxACTopHourChimeType.ResumeLayout(False)
        groupboxACAlarmChimeType.ResumeLayout(False)
        CType(picboxACClock, ComponentModel.ISupportInitialize).EndInit()
        tabpageWL.ResumeLayout(False)
        tabpageWL.PerformLayout()
        panelWL.ResumeLayout(False)
        panelWL.PerformLayout()
        cmlistviewWL.ResumeLayout(False)
        tabpageHC.ResumeLayout(False)
        groupBox2.ResumeLayout(False)
        tabpageHK.ResumeLayout(False)
        tabpageHK.PerformLayout()
        cmWSTScreenSaver.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents txbxLoadOnOSStartupArgs As System.Windows.Forms.TextBox
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnClockTest As System.Windows.Forms.Button
    Private WithEvents cmiWSTClock As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents checkboxWSTShowClock As System.Windows.Forms.CheckBox
    Private WithEvents btnWSTScreenSaverEnabled As System.Windows.Forms.RadioButton
    Private WithEvents cmseparatorWSTWLBottom As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cmseparatorWSTWLTop As System.Windows.Forms.ToolStripSeparator
    Private WithEvents lblWLStartUpDelay As System.Windows.Forms.Label
    Private WithEvents lblWLMaxLinksPerFolder As System.Windows.Forms.Label
    Private WithEvents lblWLAutoRefreshInterval As System.Windows.Forms.Label
    Private WithEvents lblWLAutoRefreshIdleInterval As System.Windows.Forms.Label
    Private label36 As System.Windows.Forms.Label
    Private WithEvents comboboxWSTSSStartUp As System.Windows.Forms.ComboBox
    Private WithEvents checkboxWSTSSToolEnabled As System.Windows.Forms.CheckBox
    Private WithEvents groupboxWSTSS As System.Windows.Forms.GroupBox
    Private cmseparatorWSTTopSpacer As System.Windows.Forms.ToolStripSeparator
    Private WithEvents panelWL As System.Windows.Forms.Panel
    Private WithEvents cmiWLMoveUp As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWLMoveDown As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWLNew As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWLDelete As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnWLCancel As System.Windows.Forms.Button
    Private WithEvents btnWLSet As System.Windows.Forms.Button
    Private WithEvents textboxWLRoot As System.Windows.Forms.TextBox
    Private WithEvents btnWLSelectFolder As System.Windows.Forms.Button
    Private WithEvents checkboxWLUseDefaultIcon As System.Windows.Forms.CheckBox
    Private WithEvents comboboxWLSort As System.Windows.Forms.ComboBox
    Private WithEvents comboboxWLFolderMode As System.Windows.Forms.ComboBox
    Private WithEvents comboboxWLFolderPlacement As System.Windows.Forms.ComboBox
    Private WithEvents checkboxWLShowInTray As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWLShowInMenu As System.Windows.Forms.CheckBox
    Private WithEvents lblWLRoot As System.Windows.Forms.Label
    Private WithEvents listviewWL As System.Windows.Forms.ListView
    Private WithEvents checkboxWLShowMenuIcons As System.Windows.Forms.CheckBox
    Private WithEvents textboxWLName As System.Windows.Forms.TextBox
    Private WithEvents checkboxWLShowNoMenu As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWLShowFolderPathToolTips As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWLShowFilePathToolTips As System.Windows.Forms.CheckBox
    Private WithEvents tabpageWL As System.Windows.Forms.TabPage
    Private WithEvents btnWLRefresh As System.Windows.Forms.Button
    Private WithEvents textboxWLMaxLinksPerFolder As System.Windows.Forms.TextBox
    Private WithEvents checkboxWLShowFileInfoToolTips As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWLAutoRefresh As System.Windows.Forms.CheckBox
    Private WithEvents textboxWLAutoRefreshInterval As System.Windows.Forms.TextBox
    Private WithEvents textboxWLAutoRefreshIdleInterval As System.Windows.Forms.TextBox
    Private WithEvents lblWLAutoRefresh As System.Windows.Forms.Label
    Private WithEvents textboxWLStartUpDelay As System.Windows.Forms.TextBox
    Private WithEvents tabpageWST As System.Windows.Forms.TabPage
    Private WithEvents cmiWSTACAlarmCancel As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents textboxACAlarmTimer As System.Windows.Forms.TextBox
    Private WithEvents checkboxACBottomHourAfterChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxACFirstQuarterHourAfterChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxACThirdQuarterHourBeforeChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxACFirstQuarterHourBeforeChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxACThirdQuarterHourAfterChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxACBottomHourBeforeChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxACFirstQuarterHourChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxACBottomHourChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxACThirdQuarterHourChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxACTopHourChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxACTopHourAfterChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxACTopHourBeforeChimeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents picboxACClock As System.Windows.Forms.PictureBox
    Private WithEvents btnACAlarmCancel As System.Windows.Forms.Button
    Private WithEvents checkboxWSTScreenSaverEnableOnActivate As System.Windows.Forms.CheckBox
    Private WithEvents cmiWSTScreenSaverEnabled As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTScreenSaverActivate As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiScreenSaverCloseAll As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiScreenSaverClose As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiScreenSaverSettings As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiScreenSaverActivate As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiScreenSaverEnabled As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTSettings As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTClose As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTCloseAll As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTLock As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTLogOff As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTSleep As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTHibernate As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTShutDown As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmseparatorWSTShutDownOptions As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cmiWSTReStart As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTAC As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTLog As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTHelp As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTCancelStartUp As System.Windows.Forms.ToolStripMenuItem
    Private cmseparatorWSTSettings As System.Windows.Forms.ToolStripSeparator
    Private cmseparatorWSTCancel As System.Windows.Forms.ToolStripSeparator
    Private WithEvents checkboxWSTEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowLockWorkSpace As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowLogOff As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowSleep As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowHibernate As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowShutDown As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowReStart As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowAC As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowWLTray As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowWLMenu As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowLog As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowHelp As System.Windows.Forms.CheckBox
    Private WithEvents cmWSTScreenSaver As System.Windows.Forms.ContextMenuStrip
    Private WithEvents checkboxWSTShowScreenSaverIcon As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowScreenSaverEnabled As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowScreenSaverActivate As System.Windows.Forms.CheckBox
    Private WithEvents textboxHKWSTLockWorkSpace As System.Windows.Forms.TextBox
    Private WithEvents lblHKWSTLockWorkSpace As System.Windows.Forms.Label
    Private WithEvents textboxHKWSTScreenSaver As System.Windows.Forms.TextBox
    Private WithEvents lblHKWSTScreenSaver As System.Windows.Forms.Label
    Private WithEvents lblHKWSTStopWatch As System.Windows.Forms.Label
    Private WithEvents btnHKWSTLockWorkSpaceDisable As System.Windows.Forms.Button
    Private WithEvents btnHKWSTScreenSaverDisable As System.Windows.Forms.Button
    Private WithEvents textboxHKWSTClock As System.Windows.Forms.TextBox
    Private WithEvents lblHKWSTClock As System.Windows.Forms.Label
    Private WithEvents btnHKWSTClockDisable As System.Windows.Forms.Button
    Private WithEvents btnSettingsSave As System.Windows.Forms.Button
    Private WithEvents btnSettingsRestore As System.Windows.Forms.Button
    Private WithEvents tabpageHC As System.Windows.Forms.TabPage
    Private WithEvents comboboxHCLeft As System.Windows.Forms.ComboBox
    Private WithEvents comboboxHCDouble As System.Windows.Forms.ComboBox
    Private WithEvents comboboxHCMiddle As System.Windows.Forms.ComboBox
    Private WithEvents comboboxHCRight As System.Windows.Forms.ComboBox
    Private WithEvents radiobtnHCWST As System.Windows.Forms.RadioButton
    Private WithEvents radiobtnHCWSTSS As System.Windows.Forms.RadioButton
    Private WithEvents radiobtnHCWL As System.Windows.Forms.RadioButton
    Private WithEvents cmlistviewWL As System.Windows.Forms.ContextMenuStrip
    Private WithEvents cmWST As System.Windows.Forms.ContextMenuStrip
    Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnHKWLDisable As System.Windows.Forms.Button
    Private WithEvents textboxHKWL As System.Windows.Forms.TextBox
    Private WithEvents lblHKWL As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private WithEvents lblACOffHourChimePath As System.Windows.Forms.Label
    Private WithEvents lblACTopHourChimePath As System.Windows.Forms.Label
    Private WithEvents lblACAlarmChimePath As System.Windows.Forms.Label
    Private WithEvents lblLoadOnOSStartupPath As System.Windows.Forms.Label
    Private WithEvents btnLoadOnOSStartupPath As System.Windows.Forms.Button
    Private WithEvents checkboxLoadOnOSStartup As System.Windows.Forms.CheckBox
    Private WithEvents btnErrorTest As System.Windows.Forms.Button
    Private label32 As System.Windows.Forms.Label
    Private WithEvents btnInfo As System.Windows.Forms.Button
    Private WithEvents btnLog As System.Windows.Forms.Button
    Private label30 As System.Windows.Forms.Label
    Private label29 As System.Windows.Forms.Label
    Private label28 As System.Windows.Forms.Label
    Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents radiobtnACAlarmChimeForever As System.Windows.Forms.RadioButton
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private label12 As System.Windows.Forms.Label
    Private label15 As System.Windows.Forms.Label
    Private label16 As System.Windows.Forms.Label
    Private label17 As System.Windows.Forms.Label
    Private WithEvents btnHKEnabled As System.Windows.Forms.Button
    Private WithEvents btnHKReset As System.Windows.Forms.Button
    Private WithEvents btnHKSet As System.Windows.Forms.Button
    Private WithEvents tabpageHK As System.Windows.Forms.TabPage
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents lblACOffHourChime As System.Windows.Forms.Label
    Private WithEvents lblACTopHourChime As System.Windows.Forms.Label
    Private WithEvents lblACAlarmChime As System.Windows.Forms.Label
    Private WithEvents btnACMute As System.Windows.Forms.Button
    Private WithEvents btnACOffHourChimePlay As System.Windows.Forms.Button
    Private WithEvents btnACTopHourChimePlay As System.Windows.Forms.Button
    Private WithEvents btnACAlarmChimePlay As System.Windows.Forms.Button
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents btnACAlarmSet As System.Windows.Forms.Button
    Private WithEvents radiobtnACAlarmChimeSimple As System.Windows.Forms.RadioButton
    Private WithEvents radiobtnACAlarmChimeExtended As System.Windows.Forms.RadioButton
    Private WithEvents groupboxACAlarmChimeType As System.Windows.Forms.GroupBox
    Private WithEvents tabpageAC As System.Windows.Forms.TabPage
    Private WithEvents radiobtnACTopHourChimeSimple As System.Windows.Forms.RadioButton
    Private WithEvents radiobtnACTopHourChimeHourTick As System.Windows.Forms.RadioButton
    Private WithEvents textboxACAlarmTime As System.Windows.Forms.TextBox
    Private WithEvents checkboxACAlarmRecurring As System.Windows.Forms.CheckBox
    Private WithEvents btnACTopHourChimeManual As System.Windows.Forms.Button
    Private WithEvents btnACTopHourChimeDefault As System.Windows.Forms.Button
    Private WithEvents btnACOffHourChimeManual As System.Windows.Forms.Button
    Private WithEvents btnACOffHourChimeDefault As System.Windows.Forms.Button
    Private WithEvents btnACAlarmChimeDefault As System.Windows.Forms.Button
    Private WithEvents btnACAlarmChimeManual As System.Windows.Forms.Button
    Private WithEvents groupboxACTopHourChimeType As System.Windows.Forms.GroupBox
    Private WithEvents radiobtnACTopHourChimeExtended As System.Windows.Forms.RadioButton
    Private WithEvents tabcontrolSettings As System.Windows.Forms.TabControl
    Friend WithEvents LblTheme As Skye.UI.Label
    Friend WithEvents ChkBoxThemeAuto As CheckBox
    Friend WithEvents CoBoxTheme As Skye.UI.ComboBox
    Friend WithEvents TipHCEX As Skye.UI.ToolTipEX
    Friend WithEvents TipInfoEX As Skye.UI.ToolTipEX
    Private WithEvents BtnSettings As Button
End Class