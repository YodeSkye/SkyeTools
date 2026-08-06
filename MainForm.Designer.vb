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
        cmiWSTTaskManager = New ToolStripMenuItem()
        cmiWSTCommandPrompt = New ToolStripMenuItem()
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
        checkboxWSTShowSleep = New CheckBox()
        checkboxWSTSSToolEnabled = New CheckBox()
        checkboxWSTShowLog = New CheckBox()
        lblWSTTaskManagerPath = New Label()
        lblWSTCommandPromptPath = New Label()
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
        checkboxWSTShowTaskManager = New CheckBox()
        btnLoadOnOSStartupPath = New Button()
        checkboxWSTShowCommandPrompt = New CheckBox()
        txbxWSTTaskManagerArgs = New TextBox()
        txbxWSTCommandPromptArgs = New TextBox()
        checkboxLoadOnOSStartup = New CheckBox()
        txbxLoadOnOSStartupArgs = New TextBox()
        checkboxWSTEnabled = New CheckBox()
        btnWSTTaskManager = New Button()
        btnWSTCommandPrompt = New Button()
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
        textboxHKWSTCommandPrompt = New TextBox()
        textboxHKWSTTaskManager = New TextBox()
        textboxHKWL = New TextBox()
        textboxHKWSTClock = New TextBox()
        textboxHKWSTLockWorkSpace = New TextBox()
        btnHKSet = New Button()
        btnHKReset = New Button()
        textboxHKWSTScreenSaver = New TextBox()
        btnHKEnabled = New Button()
        lblHKWSTCommandPrompt = New Label()
        lblHKWSTTaskManager = New Label()
        lblHKWL = New Label()
        lblHKWSTClock = New Label()
        lblHKWSTStopWatch = New Label()
        lblHKWSTLockWorkSpace = New Label()
        lblHKWSTScreenSaver = New Label()
        btnHKWSTCommandPromptDisable = New Button()
        btnHKWSTTaskManagerDisable = New Button()
        btnHKWLDisable = New Button()
        btnHKWSTClockDisable = New Button()
        btnHKWSTLockWorkSpaceDisable = New Button()
        btnHKWSTScreenSaverDisable = New Button()
        tipInfo = New ToolTip(components)
        btnBalloonTest = New Button()
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
        tipHC = New ToolTip(components)
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
        lblWLAutoRefreshIdleInterval.Location = New Point(418, 36)
        lblWLAutoRefreshIdleInterval.Name = "lblWLAutoRefreshIdleInterval"
        lblWLAutoRefreshIdleInterval.RightToLeft = RightToLeft.No
        lblWLAutoRefreshIdleInterval.Size = New Size(153, 21)
        lblWLAutoRefreshIdleInterval.TabIndex = 104
        lblWLAutoRefreshIdleInterval.Text = "AutoRefresh Idle Interval"
        lblWLAutoRefreshIdleInterval.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(lblWLAutoRefreshIdleInterval, "Refresh Only When Folder Idle For 20-240 Seconds")
        ' 
        ' lblWLAutoRefreshInterval
        ' 
        lblWLAutoRefreshInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWLAutoRefreshInterval.CausesValidation = False
        lblWLAutoRefreshInterval.Location = New Point(445, 11)
        lblWLAutoRefreshInterval.Name = "lblWLAutoRefreshInterval"
        lblWLAutoRefreshInterval.RightToLeft = RightToLeft.No
        lblWLAutoRefreshInterval.Size = New Size(126, 21)
        lblWLAutoRefreshInterval.TabIndex = 102
        lblWLAutoRefreshInterval.Text = "AutoRefresh Interval"
        lblWLAutoRefreshInterval.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(lblWLAutoRefreshInterval, "Check For Changes Every 1-90 Minutes")
        ' 
        ' lblWLMaxLinksPerFolder
        ' 
        lblWLMaxLinksPerFolder.CausesValidation = False
        lblWLMaxLinksPerFolder.Location = New Point(47, 35)
        lblWLMaxLinksPerFolder.Name = "lblWLMaxLinksPerFolder"
        lblWLMaxLinksPerFolder.RightToLeft = RightToLeft.No
        lblWLMaxLinksPerFolder.Size = New Size(176, 21)
        lblWLMaxLinksPerFolder.TabIndex = 20
        lblWLMaxLinksPerFolder.Text = "Max Menu Items Per Folder"
        lblWLMaxLinksPerFolder.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(lblWLMaxLinksPerFolder, "1-100")
        ' 
        ' lblWLStartUpDelay
        ' 
        lblWLStartUpDelay.CausesValidation = False
        lblWLStartUpDelay.Location = New Point(47, 10)
        lblWLStartUpDelay.Name = "lblWLStartUpDelay"
        lblWLStartUpDelay.RightToLeft = RightToLeft.No
        lblWLStartUpDelay.Size = New Size(89, 21)
        lblWLStartUpDelay.TabIndex = 106
        lblWLStartUpDelay.Text = "StartUp Delay"
        lblWLStartUpDelay.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(lblWLStartUpDelay, "5-300, 0 = No Delay")
        ' 
        ' cmWST
        ' 
        cmWST.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmWST.Items.AddRange(New ToolStripItem() {cmiWSTCancelStartUp, cmiWSTACAlarmCancel, cmseparatorWSTCancel, cmseparatorWSTTopSpacer, cmiWSTTaskManager, cmiWSTCommandPrompt, cmiWSTScreenSaverActivate, cmiWSTScreenSaverEnabled, cmseparatorWSTWLTop, cmseparatorWSTWLBottom, cmiWSTClock, cmiWSTAC, cmseparatorWSTShutDownOptions, cmiWSTShutDown, cmiWSTHibernate, cmiWSTSleep, cmiWSTReStart, cmiWSTLogOff, cmiWSTLock, cmseparatorWSTSettings, cmiWSTHelp, cmiWSTLog, cmiWSTSettings, toolStripSeparator5, cmiWSTClose, cmiWSTCloseAll})
        cmWST.Name = "contextmenuWorkSpaceTools"
        cmWST.Size = New Size(213, 446)
        ' 
        ' cmiWSTCancelStartUp
        ' 
        cmiWSTCancelStartUp.Image = My.Resources.Resources.imageClose
        cmiWSTCancelStartUp.Name = "cmiWSTCancelStartUp"
        cmiWSTCancelStartUp.Size = New Size(212, 22)
        cmiWSTCancelStartUp.Text = "CANCEL STARTUP"
        cmiWSTCancelStartUp.Visible = False
        ' 
        ' cmiWSTACAlarmCancel
        ' 
        cmiWSTACAlarmCancel.Image = My.Resources.Resources.imageClose
        cmiWSTACAlarmCancel.Name = "cmiWSTACAlarmCancel"
        cmiWSTACAlarmCancel.Size = New Size(212, 22)
        cmiWSTACAlarmCancel.Text = "CANCEL ALARM"
        cmiWSTACAlarmCancel.Visible = False
        ' 
        ' cmseparatorWSTCancel
        ' 
        cmseparatorWSTCancel.AutoSize = False
        cmseparatorWSTCancel.Name = "cmseparatorWSTCancel"
        cmseparatorWSTCancel.Size = New Size(209, 6)
        cmseparatorWSTCancel.Visible = False
        ' 
        ' cmseparatorWSTTopSpacer
        ' 
        cmseparatorWSTTopSpacer.AutoSize = False
        cmseparatorWSTTopSpacer.Name = "cmseparatorWSTTopSpacer"
        cmseparatorWSTTopSpacer.Size = New Size(209, 0)
        ' 
        ' cmiWSTTaskManager
        ' 
        cmiWSTTaskManager.Image = My.Resources.Resources.imageTaskManager
        cmiWSTTaskManager.Name = "cmiWSTTaskManager"
        cmiWSTTaskManager.ShortcutKeyDisplayString = ""
        cmiWSTTaskManager.Size = New Size(212, 22)
        cmiWSTTaskManager.Text = "Task Manager"
        ' 
        ' cmiWSTCommandPrompt
        ' 
        cmiWSTCommandPrompt.Image = My.Resources.Resources.imageCommandPrompt
        cmiWSTCommandPrompt.Name = "cmiWSTCommandPrompt"
        cmiWSTCommandPrompt.Size = New Size(212, 22)
        cmiWSTCommandPrompt.Text = "Command Prompt"
        ' 
        ' cmiWSTScreenSaverActivate
        ' 
        cmiWSTScreenSaverActivate.Name = "cmiWSTScreenSaverActivate"
        cmiWSTScreenSaverActivate.Size = New Size(212, 22)
        cmiWSTScreenSaverActivate.Text = "Activate Screen Saver"
        ' 
        ' cmiWSTScreenSaverEnabled
        ' 
        cmiWSTScreenSaverEnabled.Name = "cmiWSTScreenSaverEnabled"
        cmiWSTScreenSaverEnabled.Size = New Size(212, 22)
        ' 
        ' cmseparatorWSTWLTop
        ' 
        cmseparatorWSTWLTop.AutoSize = False
        cmseparatorWSTWLTop.Name = "cmseparatorWSTWLTop"
        cmseparatorWSTWLTop.Size = New Size(209, 0)
        ' 
        ' cmseparatorWSTWLBottom
        ' 
        cmseparatorWSTWLBottom.AutoSize = False
        cmseparatorWSTWLBottom.Name = "cmseparatorWSTWLBottom"
        cmseparatorWSTWLBottom.Size = New Size(209, 0)
        ' 
        ' cmiWSTClock
        ' 
        cmiWSTClock.Image = My.Resources.Resources.imageWSTClock
        cmiWSTClock.Name = "cmiWSTClock"
        cmiWSTClock.Size = New Size(212, 22)
        cmiWSTClock.Text = "Clock"
        ' 
        ' cmiWSTAC
        ' 
        cmiWSTAC.Image = My.Resources.Resources.imageAC
        cmiWSTAC.Name = "cmiWSTAC"
        cmiWSTAC.ShortcutKeyDisplayString = ""
        cmiWSTAC.ShowShortcutKeys = False
        cmiWSTAC.Size = New Size(212, 22)
        cmiWSTAC.Text = "Alarm / Chime"
        ' 
        ' cmseparatorWSTShutDownOptions
        ' 
        cmseparatorWSTShutDownOptions.AutoSize = False
        cmseparatorWSTShutDownOptions.ForeColor = SystemColors.ControlText
        cmseparatorWSTShutDownOptions.Name = "cmseparatorWSTShutDownOptions"
        cmseparatorWSTShutDownOptions.Size = New Size(209, 6)
        ' 
        ' cmiWSTShutDown
        ' 
        cmiWSTShutDown.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTShutDown.ForeColor = Color.Firebrick
        cmiWSTShutDown.Image = My.Resources.Resources.imageClose
        cmiWSTShutDown.Name = "cmiWSTShutDown"
        cmiWSTShutDown.Size = New Size(212, 22)
        cmiWSTShutDown.Text = "Shut Down"
        cmiWSTShutDown.Visible = False
        ' 
        ' cmiWSTHibernate
        ' 
        cmiWSTHibernate.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTHibernate.ForeColor = Color.Firebrick
        cmiWSTHibernate.Image = My.Resources.Resources.imageWindowHide
        cmiWSTHibernate.Name = "cmiWSTHibernate"
        cmiWSTHibernate.Size = New Size(212, 22)
        cmiWSTHibernate.Text = "Hibernate"
        cmiWSTHibernate.Visible = False
        ' 
        ' cmiWSTSleep
        ' 
        cmiWSTSleep.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTSleep.ForeColor = Color.Firebrick
        cmiWSTSleep.Image = My.Resources.Resources.imageWindowHide
        cmiWSTSleep.Name = "cmiWSTSleep"
        cmiWSTSleep.Size = New Size(212, 22)
        cmiWSTSleep.Text = "Sleep"
        cmiWSTSleep.Visible = False
        ' 
        ' cmiWSTReStart
        ' 
        cmiWSTReStart.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTReStart.ForeColor = Color.DarkCyan
        cmiWSTReStart.Image = My.Resources.Resources.imageGoReStart
        cmiWSTReStart.Name = "cmiWSTReStart"
        cmiWSTReStart.Size = New Size(212, 22)
        cmiWSTReStart.Text = "ReStart"
        cmiWSTReStart.Visible = False
        ' 
        ' cmiWSTLogOff
        ' 
        cmiWSTLogOff.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTLogOff.ForeColor = Color.Goldenrod
        cmiWSTLogOff.Image = My.Resources.Resources.imageWSTSessionKey
        cmiWSTLogOff.Name = "cmiWSTLogOff"
        cmiWSTLogOff.Size = New Size(212, 22)
        cmiWSTLogOff.Text = "Log Off"
        cmiWSTLogOff.Visible = False
        ' 
        ' cmiWSTLock
        ' 
        cmiWSTLock.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmiWSTLock.ForeColor = Color.Goldenrod
        cmiWSTLock.Image = My.Resources.Resources.imageWSTSessionKey
        cmiWSTLock.Name = "cmiWSTLock"
        cmiWSTLock.Size = New Size(212, 22)
        cmiWSTLock.Text = "Lock WorkSpace"
        cmiWSTLock.Visible = False
        ' 
        ' cmseparatorWSTSettings
        ' 
        cmseparatorWSTSettings.AutoSize = False
        cmseparatorWSTSettings.Name = "cmseparatorWSTSettings"
        cmseparatorWSTSettings.Size = New Size(209, 6)
        ' 
        ' cmiWSTHelp
        ' 
        cmiWSTHelp.Image = My.Resources.Resources.imageInfo
        cmiWSTHelp.Name = "cmiWSTHelp"
        cmiWSTHelp.Size = New Size(212, 22)
        cmiWSTHelp.Text = "Help"
        cmiWSTHelp.ToolTipText = "RightClick = Show Maximized"
        ' 
        ' cmiWSTLog
        ' 
        cmiWSTLog.Image = My.Resources.Resources.imageLog
        cmiWSTLog.Name = "cmiWSTLog"
        cmiWSTLog.Size = New Size(212, 22)
        cmiWSTLog.Text = "Log"
        ' 
        ' cmiWSTSettings
        ' 
        cmiWSTSettings.Image = My.Resources.Resources.imageSettings
        cmiWSTSettings.Name = "cmiWSTSettings"
        cmiWSTSettings.Size = New Size(212, 22)
        cmiWSTSettings.Text = "Settings"
        ' 
        ' toolStripSeparator5
        ' 
        toolStripSeparator5.Name = "toolStripSeparator5"
        toolStripSeparator5.Size = New Size(209, 6)
        ' 
        ' cmiWSTClose
        ' 
        cmiWSTClose.Image = My.Resources.Resources.imageClose
        cmiWSTClose.Name = "cmiWSTClose"
        cmiWSTClose.Size = New Size(212, 22)
        cmiWSTClose.Text = "Close WorkSpace Tools"
        ' 
        ' cmiWSTCloseAll
        ' 
        cmiWSTCloseAll.Image = My.Resources.Resources.imageClose
        cmiWSTCloseAll.Name = "cmiWSTCloseAll"
        cmiWSTCloseAll.Size = New Size(212, 22)
        cmiWSTCloseAll.Text = "Exit SkyeTools"
        ' 
        ' btnSettingsSave
        ' 
        btnSettingsSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSettingsSave.Image = My.Resources.Resources.imageSave
        btnSettingsSave.ImageAlign = ContentAlignment.TopLeft
        btnSettingsSave.Location = New Point(11, 420)
        btnSettingsSave.Name = "btnSettingsSave"
        btnSettingsSave.Size = New Size(62, 46)
        btnSettingsSave.TabIndex = 5
        btnSettingsSave.TabStop = False
        btnSettingsSave.Text = "Save"
        btnSettingsSave.TextAlign = ContentAlignment.BottomRight
        tipInfo.SetToolTip(btnSettingsSave, "Save All Settings")
        btnSettingsSave.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Image = My.Resources.Resources.imageClose
        btnClose.ImageAlign = ContentAlignment.MiddleLeft
        btnClose.Location = New Point(428, 420)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(198, 46)
        btnClose.TabIndex = 10
        btnClose.Text = "Close"
        btnClose.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(btnClose, "Close Window")
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnSettingsRestore
        ' 
        btnSettingsRestore.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSettingsRestore.Image = My.Resources.Resources.imageRestore
        btnSettingsRestore.ImageAlign = ContentAlignment.TopLeft
        btnSettingsRestore.Location = New Point(72, 420)
        btnSettingsRestore.Name = "btnSettingsRestore"
        btnSettingsRestore.Size = New Size(62, 46)
        btnSettingsRestore.TabIndex = 5
        btnSettingsRestore.TabStop = False
        btnSettingsRestore.Text = "Restore"
        btnSettingsRestore.TextAlign = ContentAlignment.BottomRight
        tipInfo.SetToolTip(btnSettingsRestore, "Restore All Settings")
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
        tabcontrolSettings.Location = New Point(7, 6)
        tabcontrolSettings.Margin = New Padding(0)
        tabcontrolSettings.Multiline = True
        tabcontrolSettings.Name = "tabcontrolSettings"
        tabcontrolSettings.Padding = New Point(0, 0)
        tabcontrolSettings.SelectedIndex = 0
        tabcontrolSettings.Size = New Size(626, 403)
        tabcontrolSettings.SizeMode = TabSizeMode.FillToRight
        tabcontrolSettings.TabIndex = 0
        ' 
        ' tabpageWST
        ' 
        tabpageWST.Controls.Add(checkboxWSTShowSleep)
        tabpageWST.Controls.Add(checkboxWSTSSToolEnabled)
        tabpageWST.Controls.Add(checkboxWSTShowLog)
        tabpageWST.Controls.Add(lblWSTTaskManagerPath)
        tabpageWST.Controls.Add(lblWSTCommandPromptPath)
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
        tabpageWST.Controls.Add(checkboxWSTShowTaskManager)
        tabpageWST.Controls.Add(btnLoadOnOSStartupPath)
        tabpageWST.Controls.Add(checkboxWSTShowCommandPrompt)
        tabpageWST.Controls.Add(txbxWSTTaskManagerArgs)
        tabpageWST.Controls.Add(txbxWSTCommandPromptArgs)
        tabpageWST.Controls.Add(checkboxLoadOnOSStartup)
        tabpageWST.Controls.Add(txbxLoadOnOSStartupArgs)
        tabpageWST.Controls.Add(checkboxWSTEnabled)
        tabpageWST.Controls.Add(btnWSTTaskManager)
        tabpageWST.Controls.Add(btnWSTCommandPrompt)
        tabpageWST.Location = New Point(4, 26)
        tabpageWST.Name = "tabpageWST"
        tabpageWST.Padding = New Padding(3)
        tabpageWST.Size = New Size(618, 373)
        tabpageWST.TabIndex = 0
        tabpageWST.Text = "****WorkSpace Tools****"
        tabpageWST.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowSleep
        ' 
        checkboxWSTShowSleep.Location = New Point(5, 294)
        checkboxWSTShowSleep.Name = "checkboxWSTShowSleep"
        checkboxWSTShowSleep.Size = New Size(110, 21)
        checkboxWSTShowSleep.TabIndex = 53
        checkboxWSTShowSleep.Text = "Show 'Sleep'"
        checkboxWSTShowSleep.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTSSToolEnabled
        ' 
        checkboxWSTSSToolEnabled.Location = New Point(492, 179)
        checkboxWSTSSToolEnabled.Name = "checkboxWSTSSToolEnabled"
        checkboxWSTSSToolEnabled.RightToLeft = RightToLeft.Yes
        checkboxWSTSSToolEnabled.Size = New Size(104, 20)
        checkboxWSTSSToolEnabled.TabIndex = 135
        checkboxWSTSSToolEnabled.Text = "Screen Saver"
        checkboxWSTSSToolEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowLog
        ' 
        checkboxWSTShowLog.Location = New Point(148, 330)
        checkboxWSTShowLog.Name = "checkboxWSTShowLog"
        checkboxWSTShowLog.Size = New Size(95, 21)
        checkboxWSTShowLog.TabIndex = 68
        checkboxWSTShowLog.Text = "Show 'Log'"
        checkboxWSTShowLog.UseVisualStyleBackColor = True
        ' 
        ' lblWSTTaskManagerPath
        ' 
        lblWSTTaskManagerPath.BorderStyle = BorderStyle.FixedSingle
        lblWSTTaskManagerPath.Location = New Point(220, 22)
        lblWSTTaskManagerPath.Name = "lblWSTTaskManagerPath"
        lblWSTTaskManagerPath.Size = New Size(150, 20)
        lblWSTTaskManagerPath.TabIndex = 76
        ' 
        ' lblWSTCommandPromptPath
        ' 
        lblWSTCommandPromptPath.BorderStyle = BorderStyle.FixedSingle
        lblWSTCommandPromptPath.Location = New Point(220, 90)
        lblWSTCommandPromptPath.Name = "lblWSTCommandPromptPath"
        lblWSTCommandPromptPath.Size = New Size(150, 20)
        lblWSTCommandPromptPath.TabIndex = 81
        ' 
        ' checkboxWSTShowReStart
        ' 
        checkboxWSTShowReStart.Location = New Point(5, 276)
        checkboxWSTShowReStart.Name = "checkboxWSTShowReStart"
        checkboxWSTShowReStart.Size = New Size(110, 21)
        checkboxWSTShowReStart.TabIndex = 52
        checkboxWSTShowReStart.Text = "Show 'ReStart'"
        checkboxWSTShowReStart.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowShutDown
        ' 
        checkboxWSTShowShutDown.Location = New Point(5, 330)
        checkboxWSTShowShutDown.Name = "checkboxWSTShowShutDown"
        checkboxWSTShowShutDown.Size = New Size(130, 21)
        checkboxWSTShowShutDown.TabIndex = 55
        checkboxWSTShowShutDown.Text = "Show 'Shut Down'"
        checkboxWSTShowShutDown.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowHibernate
        ' 
        checkboxWSTShowHibernate.Location = New Point(5, 312)
        checkboxWSTShowHibernate.Name = "checkboxWSTShowHibernate"
        checkboxWSTShowHibernate.Size = New Size(125, 21)
        checkboxWSTShowHibernate.TabIndex = 54
        checkboxWSTShowHibernate.Text = "Show 'Hibernate'"
        checkboxWSTShowHibernate.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowLogOff
        ' 
        checkboxWSTShowLogOff.Location = New Point(5, 258)
        checkboxWSTShowLogOff.Name = "checkboxWSTShowLogOff"
        checkboxWSTShowLogOff.Size = New Size(114, 21)
        checkboxWSTShowLogOff.TabIndex = 51
        checkboxWSTShowLogOff.Text = "Show 'Log Off'"
        checkboxWSTShowLogOff.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowLockWorkSpace
        ' 
        checkboxWSTShowLockWorkSpace.Location = New Point(5, 240)
        checkboxWSTShowLockWorkSpace.Name = "checkboxWSTShowLockWorkSpace"
        checkboxWSTShowLockWorkSpace.Size = New Size(169, 21)
        checkboxWSTShowLockWorkSpace.TabIndex = 50
        checkboxWSTShowLockWorkSpace.Text = "Show 'Lock WorkSpace'"
        checkboxWSTShowLockWorkSpace.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowAC
        ' 
        checkboxWSTShowAC.Location = New Point(5, 200)
        checkboxWSTShowAC.Name = "checkboxWSTShowAC"
        checkboxWSTShowAC.Size = New Size(155, 21)
        checkboxWSTShowAC.TabIndex = 33
        checkboxWSTShowAC.Text = "Show 'Alarm / Chime'"
        checkboxWSTShowAC.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowHelp
        ' 
        checkboxWSTShowHelp.Location = New Point(148, 312)
        checkboxWSTShowHelp.Name = "checkboxWSTShowHelp"
        checkboxWSTShowHelp.Size = New Size(95, 21)
        checkboxWSTShowHelp.TabIndex = 65
        checkboxWSTShowHelp.Text = "Show 'Help'"
        checkboxWSTShowHelp.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowClock
        ' 
        checkboxWSTShowClock.Location = New Point(5, 182)
        checkboxWSTShowClock.Name = "checkboxWSTShowClock"
        checkboxWSTShowClock.Size = New Size(94, 21)
        checkboxWSTShowClock.TabIndex = 32
        checkboxWSTShowClock.Text = "Show Clock"
        checkboxWSTShowClock.UseVisualStyleBackColor = True
        ' 
        ' lblLoadOnOSStartupPath
        ' 
        lblLoadOnOSStartupPath.BorderStyle = BorderStyle.FixedSingle
        lblLoadOnOSStartupPath.Location = New Point(460, 22)
        lblLoadOnOSStartupPath.Name = "lblLoadOnOSStartupPath"
        lblLoadOnOSStartupPath.Size = New Size(150, 20)
        lblLoadOnOSStartupPath.TabIndex = 101
        lblLoadOnOSStartupPath.TextAlign = ContentAlignment.TopRight
        ' 
        ' checkboxWSTShowWLTray
        ' 
        checkboxWSTShowWLTray.Location = New Point(5, 160)
        checkboxWSTShowWLTray.Name = "checkboxWSTShowWLTray"
        checkboxWSTShowWLTray.Size = New Size(145, 21)
        checkboxWSTShowWLTray.TabIndex = 31
        checkboxWSTShowWLTray.Text = "Show WinLinks Tray Icon"
        checkboxWSTShowWLTray.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowWLMenu
        ' 
        checkboxWSTShowWLMenu.Location = New Point(5, 142)
        checkboxWSTShowWLMenu.Name = "checkboxWSTShowWLMenu"
        checkboxWSTShowWLMenu.Size = New Size(126, 21)
        checkboxWSTShowWLMenu.TabIndex = 30
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
        groupboxWSTSS.Location = New Point(403, 190)
        groupboxWSTSS.Name = "groupboxWSTSS"
        groupboxWSTSS.RightToLeft = RightToLeft.Yes
        groupboxWSTSS.Size = New Size(207, 155)
        groupboxWSTSS.TabIndex = 140
        groupboxWSTSS.TabStop = False
        ' 
        ' btnWSTScreenSaverEnabled
        ' 
        btnWSTScreenSaverEnabled.Appearance = Appearance.Button
        btnWSTScreenSaverEnabled.Location = New Point(14, 21)
        btnWSTScreenSaverEnabled.Name = "btnWSTScreenSaverEnabled"
        btnWSTScreenSaverEnabled.Size = New Size(24, 24)
        btnWSTScreenSaverEnabled.TabIndex = 30
        btnWSTScreenSaverEnabled.TabStop = True
        btnWSTScreenSaverEnabled.UseVisualStyleBackColor = True
        ' 
        ' comboboxWSTSSStartUp
        ' 
        comboboxWSTSSStartUp.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        comboboxWSTSSStartUp.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxWSTSSStartUp.FormattingEnabled = True
        comboboxWSTSSStartUp.Location = New Point(14, 120)
        comboboxWSTSSStartUp.Name = "comboboxWSTSSStartUp"
        comboboxWSTSSStartUp.RightToLeft = RightToLeft.No
        comboboxWSTSSStartUp.Size = New Size(179, 25)
        comboboxWSTSSStartUp.TabIndex = 25
        ' 
        ' label36
        ' 
        label36.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        label36.Location = New Point(14, 100)
        label36.Name = "label36"
        label36.RightToLeft = RightToLeft.No
        label36.Size = New Size(179, 21)
        label36.TabIndex = 25
        label36.Text = "StartUp Mode"
        label36.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' checkboxWSTScreenSaverEnableOnActivate
        ' 
        checkboxWSTScreenSaverEnableOnActivate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWSTScreenSaverEnableOnActivate.Location = New Point(55, 75)
        checkboxWSTScreenSaverEnableOnActivate.Name = "checkboxWSTScreenSaverEnableOnActivate"
        checkboxWSTScreenSaverEnableOnActivate.RightToLeft = RightToLeft.Yes
        checkboxWSTScreenSaverEnableOnActivate.Size = New Size(138, 21)
        checkboxWSTScreenSaverEnableOnActivate.TabIndex = 20
        checkboxWSTScreenSaverEnableOnActivate.Text = "Enable On Activate"
        checkboxWSTScreenSaverEnableOnActivate.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowScreenSaverEnabled
        ' 
        checkboxWSTShowScreenSaverEnabled.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWSTShowScreenSaverEnabled.Location = New Point(20, 57)
        checkboxWSTShowScreenSaverEnabled.Name = "checkboxWSTShowScreenSaverEnabled"
        checkboxWSTShowScreenSaverEnabled.RightToLeft = RightToLeft.Yes
        checkboxWSTShowScreenSaverEnabled.Size = New Size(173, 21)
        checkboxWSTShowScreenSaverEnabled.TabIndex = 15
        checkboxWSTShowScreenSaverEnabled.Text = "Show 'Enabled/Disabled'"
        checkboxWSTShowScreenSaverEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowScreenSaverActivate
        ' 
        checkboxWSTShowScreenSaverActivate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWSTShowScreenSaverActivate.Location = New Point(75, 39)
        checkboxWSTShowScreenSaverActivate.Name = "checkboxWSTShowScreenSaverActivate"
        checkboxWSTShowScreenSaverActivate.RightToLeft = RightToLeft.Yes
        checkboxWSTShowScreenSaverActivate.Size = New Size(118, 21)
        checkboxWSTShowScreenSaverActivate.TabIndex = 10
        checkboxWSTShowScreenSaverActivate.Text = "Show 'Activate'"
        checkboxWSTShowScreenSaverActivate.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowScreenSaverIcon
        ' 
        checkboxWSTShowScreenSaverIcon.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWSTShowScreenSaverIcon.Location = New Point(75, 21)
        checkboxWSTShowScreenSaverIcon.Name = "checkboxWSTShowScreenSaverIcon"
        checkboxWSTShowScreenSaverIcon.RightToLeft = RightToLeft.Yes
        checkboxWSTShowScreenSaverIcon.Size = New Size(118, 21)
        checkboxWSTShowScreenSaverIcon.TabIndex = 1
        checkboxWSTShowScreenSaverIcon.Text = "Show Tray Icon"
        checkboxWSTShowScreenSaverIcon.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowTaskManager
        ' 
        checkboxWSTShowTaskManager.Location = New Point(220, 5)
        checkboxWSTShowTaskManager.Name = "checkboxWSTShowTaskManager"
        checkboxWSTShowTaskManager.Size = New Size(169, 21)
        checkboxWSTShowTaskManager.TabIndex = 75
        checkboxWSTShowTaskManager.Text = "Show 'Task Manager'"
        checkboxWSTShowTaskManager.UseVisualStyleBackColor = True
        ' 
        ' btnLoadOnOSStartupPath
        ' 
        btnLoadOnOSStartupPath.FlatAppearance.BorderSize = 0
        btnLoadOnOSStartupPath.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnLoadOnOSStartupPath.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnLoadOnOSStartupPath.FlatStyle = FlatStyle.Flat
        btnLoadOnOSStartupPath.Image = My.Resources.Resources.ImageFolder
        btnLoadOnOSStartupPath.Location = New Point(440, 21)
        btnLoadOnOSStartupPath.Name = "btnLoadOnOSStartupPath"
        btnLoadOnOSStartupPath.Size = New Size(21, 21)
        btnLoadOnOSStartupPath.TabIndex = 101
        btnLoadOnOSStartupPath.TabStop = False
        btnLoadOnOSStartupPath.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnLoadOnOSStartupPath, "Select An Application")
        btnLoadOnOSStartupPath.UseVisualStyleBackColor = True
        ' 
        ' checkboxWSTShowCommandPrompt
        ' 
        checkboxWSTShowCommandPrompt.Location = New Point(220, 73)
        checkboxWSTShowCommandPrompt.Name = "checkboxWSTShowCommandPrompt"
        checkboxWSTShowCommandPrompt.Size = New Size(178, 21)
        checkboxWSTShowCommandPrompt.TabIndex = 80
        checkboxWSTShowCommandPrompt.Text = "Show 'Command Prompt'"
        checkboxWSTShowCommandPrompt.UseVisualStyleBackColor = True
        ' 
        ' txbxWSTTaskManagerArgs
        ' 
        txbxWSTTaskManagerArgs.Location = New Point(220, 41)
        txbxWSTTaskManagerArgs.Name = "txbxWSTTaskManagerArgs"
        txbxWSTTaskManagerArgs.Size = New Size(150, 25)
        txbxWSTTaskManagerArgs.TabIndex = 78
        txbxWSTTaskManagerArgs.WordWrap = False
        ' 
        ' txbxWSTCommandPromptArgs
        ' 
        txbxWSTCommandPromptArgs.Location = New Point(220, 109)
        txbxWSTCommandPromptArgs.Name = "txbxWSTCommandPromptArgs"
        txbxWSTCommandPromptArgs.Size = New Size(150, 25)
        txbxWSTCommandPromptArgs.TabIndex = 83
        txbxWSTCommandPromptArgs.WordWrap = False
        ' 
        ' checkboxLoadOnOSStartup
        ' 
        checkboxLoadOnOSStartup.Location = New Point(459, 5)
        checkboxLoadOnOSStartup.Name = "checkboxLoadOnOSStartup"
        checkboxLoadOnOSStartup.RightToLeft = RightToLeft.Yes
        checkboxLoadOnOSStartup.Size = New Size(152, 20)
        checkboxLoadOnOSStartup.TabIndex = 100
        checkboxLoadOnOSStartup.Text = "Load On Windows StartUp"
        checkboxLoadOnOSStartup.UseVisualStyleBackColor = True
        ' 
        ' txbxLoadOnOSStartupArgs
        ' 
        txbxLoadOnOSStartupArgs.Location = New Point(460, 41)
        txbxLoadOnOSStartupArgs.Name = "txbxLoadOnOSStartupArgs"
        txbxLoadOnOSStartupArgs.Size = New Size(150, 25)
        txbxLoadOnOSStartupArgs.TabIndex = 102
        txbxLoadOnOSStartupArgs.WordWrap = False
        ' 
        ' checkboxWSTEnabled
        ' 
        checkboxWSTEnabled.Location = New Point(5, 5)
        checkboxWSTEnabled.Name = "checkboxWSTEnabled"
        checkboxWSTEnabled.Size = New Size(115, 21)
        checkboxWSTEnabled.TabIndex = 10
        checkboxWSTEnabled.Text = "Show Tray Icon"
        checkboxWSTEnabled.UseVisualStyleBackColor = True
        ' 
        ' btnWSTTaskManager
        ' 
        btnWSTTaskManager.FlatAppearance.BorderSize = 0
        btnWSTTaskManager.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnWSTTaskManager.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnWSTTaskManager.FlatStyle = FlatStyle.Flat
        btnWSTTaskManager.Image = My.Resources.Resources.ImageFolder
        btnWSTTaskManager.Location = New Point(368, 21)
        btnWSTTaskManager.Name = "btnWSTTaskManager"
        btnWSTTaskManager.Size = New Size(21, 21)
        btnWSTTaskManager.TabIndex = 77
        btnWSTTaskManager.TabStop = False
        btnWSTTaskManager.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnWSTTaskManager, "LeftClick = Select An Application" & vbCrLf & "RightClick = Set To Defaults")
        btnWSTTaskManager.UseVisualStyleBackColor = True
        ' 
        ' btnWSTCommandPrompt
        ' 
        btnWSTCommandPrompt.FlatAppearance.BorderSize = 0
        btnWSTCommandPrompt.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnWSTCommandPrompt.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnWSTCommandPrompt.FlatStyle = FlatStyle.Flat
        btnWSTCommandPrompt.Image = My.Resources.Resources.ImageFolder
        btnWSTCommandPrompt.Location = New Point(368, 90)
        btnWSTCommandPrompt.Name = "btnWSTCommandPrompt"
        btnWSTCommandPrompt.Size = New Size(21, 21)
        btnWSTCommandPrompt.TabIndex = 82
        btnWSTCommandPrompt.TabStop = False
        btnWSTCommandPrompt.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnWSTCommandPrompt, "LeftClick = Select An Application" & vbCrLf & "RightClick = Set To Defaults")
        btnWSTCommandPrompt.UseVisualStyleBackColor = True
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
        tabpageAC.Location = New Point(4, 24)
        tabpageAC.Name = "tabpageAC"
        tabpageAC.Padding = New Padding(3)
        tabpageAC.Size = New Size(618, 375)
        tabpageAC.TabIndex = 3
        tabpageAC.Text = "****Alarm + Chime****"
        tabpageAC.UseVisualStyleBackColor = True
        ' 
        ' lblACAlarmChime
        ' 
        lblACAlarmChime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACAlarmChime.ForeColor = SystemColors.ControlText
        lblACAlarmChime.Location = New Point(530, 4)
        lblACAlarmChime.Name = "lblACAlarmChime"
        lblACAlarmChime.Size = New Size(85, 14)
        lblACAlarmChime.TabIndex = 28
        lblACAlarmChime.Text = "Alarm"
        lblACAlarmChime.TextAlign = ContentAlignment.BottomRight
        ' 
        ' lblACOffHourChimePath
        ' 
        lblACOffHourChimePath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACOffHourChimePath.AutoEllipsis = True
        lblACOffHourChimePath.BorderStyle = BorderStyle.FixedSingle
        lblACOffHourChimePath.Location = New Point(448, 325)
        lblACOffHourChimePath.Name = "lblACOffHourChimePath"
        lblACOffHourChimePath.Size = New Size(163, 20)
        lblACOffHourChimePath.TabIndex = 32
        lblACOffHourChimePath.TextAlign = ContentAlignment.TopRight
        lblACOffHourChimePath.UseMnemonic = False
        ' 
        ' lblACOffHourChime
        ' 
        lblACOffHourChime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACOffHourChime.ForeColor = SystemColors.ControlText
        lblACOffHourChime.Location = New Point(494, 292)
        lblACOffHourChime.Name = "lblACOffHourChime"
        lblACOffHourChime.Size = New Size(122, 16)
        lblACOffHourChime.TabIndex = 13
        lblACOffHourChime.Text = "Off-Hour Chimes"
        lblACOffHourChime.TextAlign = ContentAlignment.BottomRight
        ' 
        ' btnACOffHourChimeManual
        ' 
        btnACOffHourChimeManual.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACOffHourChimeManual.FlatAppearance.BorderSize = 0
        btnACOffHourChimeManual.FlatStyle = FlatStyle.Flat
        btnACOffHourChimeManual.Image = My.Resources.Resources.imageACFolder
        btnACOffHourChimeManual.Location = New Point(590, 305)
        btnACOffHourChimeManual.Name = "btnACOffHourChimeManual"
        btnACOffHourChimeManual.Size = New Size(21, 21)
        btnACOffHourChimeManual.TabIndex = 31
        btnACOffHourChimeManual.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnACOffHourChimeManual, "Select WAV File")
        btnACOffHourChimeManual.UseVisualStyleBackColor = True
        ' 
        ' lblACTopHourChime
        ' 
        lblACTopHourChime.ForeColor = SystemColors.ControlText
        lblACTopHourChime.Location = New Point(4, 235)
        lblACTopHourChime.Name = "lblACTopHourChime"
        lblACTopHourChime.Size = New Size(119, 16)
        lblACTopHourChime.TabIndex = 12
        lblACTopHourChime.Text = "Top-Hour Chime"
        lblACTopHourChime.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' btnACAlarmCancel
        ' 
        btnACAlarmCancel.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnACAlarmCancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnACAlarmCancel.ForeColor = Color.Maroon
        btnACAlarmCancel.Location = New Point(82, 45)
        btnACAlarmCancel.Name = "btnACAlarmCancel"
        btnACAlarmCancel.Size = New Size(72, 43)
        btnACAlarmCancel.TabIndex = 4
        btnACAlarmCancel.Text = " CANCEL  ALARM"
        btnACAlarmCancel.UseVisualStyleBackColor = True
        btnACAlarmCancel.Visible = False
        ' 
        ' lblACTopHourChimePath
        ' 
        lblACTopHourChimePath.AutoEllipsis = True
        lblACTopHourChimePath.BorderStyle = BorderStyle.FixedSingle
        lblACTopHourChimePath.Location = New Point(5, 325)
        lblACTopHourChimePath.Name = "lblACTopHourChimePath"
        lblACTopHourChimePath.Size = New Size(164, 20)
        lblACTopHourChimePath.TabIndex = 24
        lblACTopHourChimePath.UseMnemonic = False
        ' 
        ' lblACAlarmChimePath
        ' 
        lblACAlarmChimePath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblACAlarmChimePath.AutoEllipsis = True
        lblACAlarmChimePath.BorderStyle = BorderStyle.FixedSingle
        lblACAlarmChimePath.Location = New Point(446, 36)
        lblACAlarmChimePath.Name = "lblACAlarmChimePath"
        lblACAlarmChimePath.Size = New Size(165, 20)
        lblACAlarmChimePath.TabIndex = 9
        lblACAlarmChimePath.TextAlign = ContentAlignment.TopRight
        lblACAlarmChimePath.UseMnemonic = False
        ' 
        ' checkboxACBottomHourAfterChimeEnabled
        ' 
        checkboxACBottomHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACBottomHourAfterChimeEnabled.BackgroundImageLayout = ImageLayout.None
        checkboxACBottomHourAfterChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        checkboxACBottomHourAfterChimeEnabled.Location = New Point(250, 322)
        checkboxACBottomHourAfterChimeEnabled.Name = "checkboxACBottomHourAfterChimeEnabled"
        checkboxACBottomHourAfterChimeEnabled.Size = New Size(13, 13)
        checkboxACBottomHourAfterChimeEnabled.TabIndex = 28
        checkboxACBottomHourAfterChimeEnabled.TabStop = False
        checkboxACBottomHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACFirstQuarterHourAfterChimeEnabled
        ' 
        checkboxACFirstQuarterHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACFirstQuarterHourAfterChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        checkboxACFirstQuarterHourAfterChimeEnabled.Location = New Point(390, 289)
        checkboxACFirstQuarterHourAfterChimeEnabled.Name = "checkboxACFirstQuarterHourAfterChimeEnabled"
        checkboxACFirstQuarterHourAfterChimeEnabled.Size = New Size(13, 13)
        checkboxACFirstQuarterHourAfterChimeEnabled.TabIndex = 28
        checkboxACFirstQuarterHourAfterChimeEnabled.TabStop = False
        checkboxACFirstQuarterHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACThirdQuarterHourBeforeChimeEnabled
        ' 
        checkboxACThirdQuarterHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACThirdQuarterHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        checkboxACThirdQuarterHourBeforeChimeEnabled.Location = New Point(218, 288)
        checkboxACThirdQuarterHourBeforeChimeEnabled.Name = "checkboxACThirdQuarterHourBeforeChimeEnabled"
        checkboxACThirdQuarterHourBeforeChimeEnabled.Size = New Size(13, 13)
        checkboxACThirdQuarterHourBeforeChimeEnabled.TabIndex = 28
        checkboxACThirdQuarterHourBeforeChimeEnabled.TabStop = False
        checkboxACThirdQuarterHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACFirstQuarterHourBeforeChimeEnabled
        ' 
        checkboxACFirstQuarterHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACFirstQuarterHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        checkboxACFirstQuarterHourBeforeChimeEnabled.Location = New Point(389, 186)
        checkboxACFirstQuarterHourBeforeChimeEnabled.Name = "checkboxACFirstQuarterHourBeforeChimeEnabled"
        checkboxACFirstQuarterHourBeforeChimeEnabled.Size = New Size(13, 13)
        checkboxACFirstQuarterHourBeforeChimeEnabled.TabIndex = 28
        checkboxACFirstQuarterHourBeforeChimeEnabled.TabStop = False
        checkboxACFirstQuarterHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACThirdQuarterHourAfterChimeEnabled
        ' 
        checkboxACThirdQuarterHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACThirdQuarterHourAfterChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        checkboxACThirdQuarterHourAfterChimeEnabled.Location = New Point(218, 184)
        checkboxACThirdQuarterHourAfterChimeEnabled.Name = "checkboxACThirdQuarterHourAfterChimeEnabled"
        checkboxACThirdQuarterHourAfterChimeEnabled.Size = New Size(13, 13)
        checkboxACThirdQuarterHourAfterChimeEnabled.TabIndex = 28
        checkboxACThirdQuarterHourAfterChimeEnabled.TabStop = False
        checkboxACThirdQuarterHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACBottomHourBeforeChimeEnabled
        ' 
        checkboxACBottomHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACBottomHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        checkboxACBottomHourBeforeChimeEnabled.Location = New Point(355, 325)
        checkboxACBottomHourBeforeChimeEnabled.Name = "checkboxACBottomHourBeforeChimeEnabled"
        checkboxACBottomHourBeforeChimeEnabled.Size = New Size(13, 13)
        checkboxACBottomHourBeforeChimeEnabled.TabIndex = 28
        checkboxACBottomHourBeforeChimeEnabled.TabStop = False
        checkboxACBottomHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' btnACMute
        ' 
        btnACMute.Anchor = AnchorStyles.Top
        btnACMute.FlatAppearance.BorderSize = 0
        btnACMute.FlatStyle = FlatStyle.Flat
        btnACMute.Location = New Point(282, 35)
        btnACMute.Name = "btnACMute"
        btnACMute.Size = New Size(64, 64)
        btnACMute.TabIndex = 11
        btnACMute.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnACMute, "Mute All Chimes")
        btnACMute.UseVisualStyleBackColor = True
        ' 
        ' textboxACAlarmTimer
        ' 
        textboxACAlarmTimer.Location = New Point(5, 89)
        textboxACAlarmTimer.MaxLength = 3
        textboxACAlarmTimer.Name = "textboxACAlarmTimer"
        textboxACAlarmTimer.Size = New Size(70, 25)
        textboxACAlarmTimer.TabIndex = 5
        textboxACAlarmTimer.TextAlign = HorizontalAlignment.Center
        tipInfo.SetToolTip(textboxACAlarmTimer, "Enter Timer Value In Minutes")
        ' 
        ' groupboxACTopHourChimeType
        ' 
        groupboxACTopHourChimeType.Controls.Add(radiobtnACTopHourChimeSimple)
        groupboxACTopHourChimeType.Controls.Add(radiobtnACTopHourChimeExtended)
        groupboxACTopHourChimeType.Controls.Add(radiobtnACTopHourChimeHourTick)
        groupboxACTopHourChimeType.Location = New Point(5, 242)
        groupboxACTopHourChimeType.Name = "groupboxACTopHourChimeType"
        groupboxACTopHourChimeType.Size = New Size(85, 65)
        groupboxACTopHourChimeType.TabIndex = 20
        groupboxACTopHourChimeType.TabStop = False
        ' 
        ' radiobtnACTopHourChimeSimple
        ' 
        radiobtnACTopHourChimeSimple.Location = New Point(6, 11)
        radiobtnACTopHourChimeSimple.Name = "radiobtnACTopHourChimeSimple"
        radiobtnACTopHourChimeSimple.Size = New Size(73, 20)
        radiobtnACTopHourChimeSimple.TabIndex = 1
        radiobtnACTopHourChimeSimple.TabStop = True
        radiobtnACTopHourChimeSimple.Text = "Simple"
        tipInfo.SetToolTip(radiobtnACTopHourChimeSimple, "Chime Once")
        radiobtnACTopHourChimeSimple.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACTopHourChimeExtended
        ' 
        radiobtnACTopHourChimeExtended.Location = New Point(6, 27)
        radiobtnACTopHourChimeExtended.Name = "radiobtnACTopHourChimeExtended"
        radiobtnACTopHourChimeExtended.Size = New Size(80, 20)
        radiobtnACTopHourChimeExtended.TabIndex = 2
        radiobtnACTopHourChimeExtended.TabStop = True
        radiobtnACTopHourChimeExtended.Text = "Extended"
        tipInfo.SetToolTip(radiobtnACTopHourChimeExtended, "Chime Several Times")
        radiobtnACTopHourChimeExtended.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACTopHourChimeHourTick
        ' 
        radiobtnACTopHourChimeHourTick.Location = New Point(6, 43)
        radiobtnACTopHourChimeHourTick.Name = "radiobtnACTopHourChimeHourTick"
        radiobtnACTopHourChimeHourTick.Size = New Size(73, 20)
        radiobtnACTopHourChimeHourTick.TabIndex = 3
        radiobtnACTopHourChimeHourTick.TabStop = True
        radiobtnACTopHourChimeHourTick.Text = "Hour Tick"
        tipInfo.SetToolTip(radiobtnACTopHourChimeHourTick, "Chime Based On Hour")
        radiobtnACTopHourChimeHourTick.UseVisualStyleBackColor = True
        ' 
        ' btnACOffHourChimeDefault
        ' 
        btnACOffHourChimeDefault.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACOffHourChimeDefault.FlatAppearance.BorderSize = 0
        btnACOffHourChimeDefault.FlatStyle = FlatStyle.Flat
        btnACOffHourChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        btnACOffHourChimeDefault.Location = New Point(565, 305)
        btnACOffHourChimeDefault.Name = "btnACOffHourChimeDefault"
        btnACOffHourChimeDefault.Size = New Size(21, 21)
        btnACOffHourChimeDefault.TabIndex = 30
        btnACOffHourChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnACOffHourChimeDefault, "Use Default Chime")
        btnACOffHourChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' btnACTopHourChimeDefault
        ' 
        btnACTopHourChimeDefault.FlatAppearance.BorderSize = 0
        btnACTopHourChimeDefault.FlatStyle = FlatStyle.Flat
        btnACTopHourChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        btnACTopHourChimeDefault.Location = New Point(28, 305)
        btnACTopHourChimeDefault.Name = "btnACTopHourChimeDefault"
        btnACTopHourChimeDefault.Size = New Size(21, 21)
        btnACTopHourChimeDefault.TabIndex = 22
        btnACTopHourChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnACTopHourChimeDefault, "Use Default Chime")
        btnACTopHourChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' textboxACAlarmTime
        ' 
        textboxACAlarmTime.Location = New Point(5, 19)
        textboxACAlarmTime.MaxLength = 5
        textboxACAlarmTime.Name = "textboxACAlarmTime"
        textboxACAlarmTime.Size = New Size(70, 25)
        textboxACAlarmTime.TabIndex = 1
        textboxACAlarmTime.TextAlign = HorizontalAlignment.Center
        tipInfo.SetToolTip(textboxACAlarmTime, "Enter Alarm Time (24-Hour Format)")
        ' 
        ' btnACTopHourChimeManual
        ' 
        btnACTopHourChimeManual.FlatAppearance.BorderSize = 0
        btnACTopHourChimeManual.FlatStyle = FlatStyle.Flat
        btnACTopHourChimeManual.Image = My.Resources.Resources.imageACFolder
        btnACTopHourChimeManual.Location = New Point(4, 305)
        btnACTopHourChimeManual.Name = "btnACTopHourChimeManual"
        btnACTopHourChimeManual.Size = New Size(21, 21)
        btnACTopHourChimeManual.TabIndex = 21
        btnACTopHourChimeManual.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnACTopHourChimeManual, "Select WAV File")
        btnACTopHourChimeManual.UseVisualStyleBackColor = True
        ' 
        ' checkboxACThirdQuarterHourChimeEnabled
        ' 
        checkboxACThirdQuarterHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACThirdQuarterHourChimeEnabled.CheckAlign = ContentAlignment.TopRight
        checkboxACThirdQuarterHourChimeEnabled.Location = New Point(204, 234)
        checkboxACThirdQuarterHourChimeEnabled.Name = "checkboxACThirdQuarterHourChimeEnabled"
        checkboxACThirdQuarterHourChimeEnabled.Size = New Size(15, 15)
        checkboxACThirdQuarterHourChimeEnabled.TabIndex = 28
        checkboxACThirdQuarterHourChimeEnabled.TabStop = False
        checkboxACThirdQuarterHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACBottomHourChimeEnabled
        ' 
        checkboxACBottomHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACBottomHourChimeEnabled.CheckAlign = ContentAlignment.MiddleRight
        checkboxACBottomHourChimeEnabled.Location = New Point(303, 336)
        checkboxACBottomHourChimeEnabled.Name = "checkboxACBottomHourChimeEnabled"
        checkboxACBottomHourChimeEnabled.Size = New Size(15, 15)
        checkboxACBottomHourChimeEnabled.TabIndex = 28
        checkboxACBottomHourChimeEnabled.TabStop = False
        checkboxACBottomHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACFirstQuarterHourChimeEnabled
        ' 
        checkboxACFirstQuarterHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACFirstQuarterHourChimeEnabled.CheckAlign = ContentAlignment.TopLeft
        checkboxACFirstQuarterHourChimeEnabled.Location = New Point(402, 235)
        checkboxACFirstQuarterHourChimeEnabled.Name = "checkboxACFirstQuarterHourChimeEnabled"
        checkboxACFirstQuarterHourChimeEnabled.Size = New Size(15, 15)
        checkboxACFirstQuarterHourChimeEnabled.TabIndex = 28
        checkboxACFirstQuarterHourChimeEnabled.TabStop = False
        checkboxACFirstQuarterHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACTopHourAfterChimeEnabled
        ' 
        checkboxACTopHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACTopHourAfterChimeEnabled.CheckAlign = ContentAlignment.TopRight
        checkboxACTopHourAfterChimeEnabled.Location = New Point(354, 150)
        checkboxACTopHourAfterChimeEnabled.Name = "checkboxACTopHourAfterChimeEnabled"
        checkboxACTopHourAfterChimeEnabled.Size = New Size(15, 15)
        checkboxACTopHourAfterChimeEnabled.TabIndex = 28
        checkboxACTopHourAfterChimeEnabled.TabStop = False
        checkboxACTopHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACTopHourChimeEnabled
        ' 
        checkboxACTopHourChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACTopHourChimeEnabled.CheckAlign = ContentAlignment.TopRight
        checkboxACTopHourChimeEnabled.Location = New Point(303, 137)
        checkboxACTopHourChimeEnabled.Name = "checkboxACTopHourChimeEnabled"
        checkboxACTopHourChimeEnabled.Size = New Size(15, 15)
        checkboxACTopHourChimeEnabled.TabIndex = 12
        checkboxACTopHourChimeEnabled.TabStop = False
        checkboxACTopHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' checkboxACTopHourBeforeChimeEnabled
        ' 
        checkboxACTopHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        checkboxACTopHourBeforeChimeEnabled.CheckAlign = ContentAlignment.TopRight
        checkboxACTopHourBeforeChimeEnabled.Location = New Point(251, 149)
        checkboxACTopHourBeforeChimeEnabled.Name = "checkboxACTopHourBeforeChimeEnabled"
        checkboxACTopHourBeforeChimeEnabled.Size = New Size(15, 15)
        checkboxACTopHourBeforeChimeEnabled.TabIndex = 28
        checkboxACTopHourBeforeChimeEnabled.TabStop = False
        checkboxACTopHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' groupboxACAlarmChimeType
        ' 
        groupboxACAlarmChimeType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        groupboxACAlarmChimeType.BackColor = Color.Transparent
        groupboxACAlarmChimeType.Controls.Add(radiobtnACAlarmChimeSimple)
        groupboxACAlarmChimeType.Controls.Add(radiobtnACAlarmChimeForever)
        groupboxACAlarmChimeType.Controls.Add(radiobtnACAlarmChimeExtended)
        groupboxACAlarmChimeType.Location = New Point(526, 48)
        groupboxACAlarmChimeType.Name = "groupboxACAlarmChimeType"
        groupboxACAlarmChimeType.Size = New Size(85, 65)
        groupboxACAlarmChimeType.TabIndex = 10
        groupboxACAlarmChimeType.TabStop = False
        ' 
        ' radiobtnACAlarmChimeSimple
        ' 
        radiobtnACAlarmChimeSimple.Location = New Point(6, 11)
        radiobtnACAlarmChimeSimple.Name = "radiobtnACAlarmChimeSimple"
        radiobtnACAlarmChimeSimple.Size = New Size(80, 20)
        radiobtnACAlarmChimeSimple.TabIndex = 1
        radiobtnACAlarmChimeSimple.TabStop = True
        radiobtnACAlarmChimeSimple.Text = "Simple"
        tipInfo.SetToolTip(radiobtnACAlarmChimeSimple, "Chime Once")
        radiobtnACAlarmChimeSimple.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACAlarmChimeForever
        ' 
        radiobtnACAlarmChimeForever.Location = New Point(6, 43)
        radiobtnACAlarmChimeForever.Name = "radiobtnACAlarmChimeForever"
        radiobtnACAlarmChimeForever.Size = New Size(80, 20)
        radiobtnACAlarmChimeForever.TabIndex = 3
        radiobtnACAlarmChimeForever.TabStop = True
        radiobtnACAlarmChimeForever.Text = "Forever"
        tipInfo.SetToolTip(radiobtnACAlarmChimeForever, "Chime Until Cancelled")
        radiobtnACAlarmChimeForever.UseVisualStyleBackColor = True
        ' 
        ' radiobtnACAlarmChimeExtended
        ' 
        radiobtnACAlarmChimeExtended.Location = New Point(6, 27)
        radiobtnACAlarmChimeExtended.Name = "radiobtnACAlarmChimeExtended"
        radiobtnACAlarmChimeExtended.Size = New Size(80, 20)
        radiobtnACAlarmChimeExtended.TabIndex = 2
        radiobtnACAlarmChimeExtended.TabStop = True
        radiobtnACAlarmChimeExtended.Text = "Extended"
        tipInfo.SetToolTip(radiobtnACAlarmChimeExtended, "Chime Several Times")
        radiobtnACAlarmChimeExtended.UseVisualStyleBackColor = True
        ' 
        ' btnACAlarmSet
        ' 
        btnACAlarmSet.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnACAlarmSet.Location = New Point(4, 45)
        btnACAlarmSet.Name = "btnACAlarmSet"
        btnACAlarmSet.Size = New Size(72, 43)
        btnACAlarmSet.TabIndex = 3
        btnACAlarmSet.Text = "Alarm InActive"
        tipInfo.SetToolTip(btnACAlarmSet, "Activate / DeActivate Alarm")
        btnACAlarmSet.UseVisualStyleBackColor = True
        ' 
        ' checkboxACAlarmRecurring
        ' 
        checkboxACAlarmRecurring.Location = New Point(84, 20)
        checkboxACAlarmRecurring.Name = "checkboxACAlarmRecurring"
        checkboxACAlarmRecurring.Size = New Size(87, 24)
        checkboxACAlarmRecurring.TabIndex = 2
        checkboxACAlarmRecurring.Text = "Recurring"
        tipInfo.SetToolTip(checkboxACAlarmRecurring, "Alarm Repeats Every Day")
        checkboxACAlarmRecurring.UseVisualStyleBackColor = True
        ' 
        ' label13
        ' 
        label13.ForeColor = SystemColors.ControlText
        label13.Location = New Point(5, 108)
        label13.Name = "label13"
        label13.Size = New Size(70, 20)
        label13.TabIndex = 35
        label13.Text = "Timer"
        label13.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' btnACTopHourChimePlay
        ' 
        btnACTopHourChimePlay.FlatAppearance.BorderSize = 0
        btnACTopHourChimePlay.FlatStyle = FlatStyle.Flat
        btnACTopHourChimePlay.Image = My.Resources.Resources.imageACPlay
        btnACTopHourChimePlay.Location = New Point(54, 305)
        btnACTopHourChimePlay.Name = "btnACTopHourChimePlay"
        btnACTopHourChimePlay.Size = New Size(21, 21)
        btnACTopHourChimePlay.TabIndex = 23
        btnACTopHourChimePlay.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnACTopHourChimePlay, "Play Sound")
        btnACTopHourChimePlay.UseVisualStyleBackColor = True
        ' 
        ' btnACOffHourChimePlay
        ' 
        btnACOffHourChimePlay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACOffHourChimePlay.FlatAppearance.BorderSize = 0
        btnACOffHourChimePlay.FlatStyle = FlatStyle.Flat
        btnACOffHourChimePlay.Image = My.Resources.Resources.imageACPlay
        btnACOffHourChimePlay.Location = New Point(542, 305)
        btnACOffHourChimePlay.Name = "btnACOffHourChimePlay"
        btnACOffHourChimePlay.Size = New Size(21, 21)
        btnACOffHourChimePlay.TabIndex = 29
        btnACOffHourChimePlay.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnACOffHourChimePlay, "Play Sound")
        btnACOffHourChimePlay.UseVisualStyleBackColor = True
        ' 
        ' label32
        ' 
        label32.ForeColor = SystemColors.ControlText
        label32.Location = New Point(5, 4)
        label32.Name = "label32"
        label32.Size = New Size(70, 14)
        label32.TabIndex = 36
        label32.Text = "Time"
        label32.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' picboxACClock
        ' 
        picboxACClock.Anchor = AnchorStyles.Top
        picboxACClock.Image = My.Resources.Resources.imageACClock
        picboxACClock.Location = New Point(213, 147)
        picboxACClock.Name = "picboxACClock"
        picboxACClock.Size = New Size(192, 192)
        picboxACClock.SizeMode = PictureBoxSizeMode.Zoom
        picboxACClock.TabIndex = 0
        picboxACClock.TabStop = False
        tipInfo.SetToolTip(picboxACClock, "Select When To Sound Chime Each Hour")
        ' 
        ' btnACAlarmChimeDefault
        ' 
        btnACAlarmChimeDefault.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACAlarmChimeDefault.FlatAppearance.BorderSize = 0
        btnACAlarmChimeDefault.FlatStyle = FlatStyle.Flat
        btnACAlarmChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        btnACAlarmChimeDefault.Location = New Point(565, 16)
        btnACAlarmChimeDefault.Name = "btnACAlarmChimeDefault"
        btnACAlarmChimeDefault.Size = New Size(21, 21)
        btnACAlarmChimeDefault.TabIndex = 7
        btnACAlarmChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnACAlarmChimeDefault, "Use Default Chime")
        btnACAlarmChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' btnACAlarmChimePlay
        ' 
        btnACAlarmChimePlay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACAlarmChimePlay.FlatAppearance.BorderSize = 0
        btnACAlarmChimePlay.FlatStyle = FlatStyle.Flat
        btnACAlarmChimePlay.Image = My.Resources.Resources.imageACPlay
        btnACAlarmChimePlay.Location = New Point(542, 16)
        btnACAlarmChimePlay.Name = "btnACAlarmChimePlay"
        btnACAlarmChimePlay.Size = New Size(21, 21)
        btnACAlarmChimePlay.TabIndex = 6
        btnACAlarmChimePlay.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnACAlarmChimePlay, "Play Sound")
        btnACAlarmChimePlay.UseVisualStyleBackColor = True
        ' 
        ' btnACAlarmChimeManual
        ' 
        btnACAlarmChimeManual.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnACAlarmChimeManual.FlatAppearance.BorderSize = 0
        btnACAlarmChimeManual.FlatStyle = FlatStyle.Flat
        btnACAlarmChimeManual.Image = My.Resources.Resources.imageACFolder
        btnACAlarmChimeManual.Location = New Point(590, 16)
        btnACAlarmChimeManual.Name = "btnACAlarmChimeManual"
        btnACAlarmChimeManual.Size = New Size(21, 21)
        btnACAlarmChimeManual.TabIndex = 8
        btnACAlarmChimeManual.TextAlign = ContentAlignment.MiddleLeft
        tipInfo.SetToolTip(btnACAlarmChimeManual, "Select WAV File")
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
        tabpageWL.Location = New Point(4, 24)
        tabpageWL.Name = "tabpageWL"
        tabpageWL.Padding = New Padding(3)
        tabpageWL.Size = New Size(618, 375)
        tabpageWL.TabIndex = 8
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
        panelWL.Location = New Point(5, 215)
        panelWL.Name = "panelWL"
        panelWL.Size = New Size(606, 130)
        panelWL.TabIndex = 100
        panelWL.Visible = False
        ' 
        ' checkboxWLShowNoMenu
        ' 
        checkboxWLShowNoMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWLShowNoMenu.Location = New Point(479, 69)
        checkboxWLShowNoMenu.Name = "checkboxWLShowNoMenu"
        checkboxWLShowNoMenu.Size = New Size(124, 21)
        checkboxWLShowNoMenu.TabIndex = 66
        checkboxWLShowNoMenu.Text = "No Menu Items"
        checkboxWLShowNoMenu.UseVisualStyleBackColor = True
        ' 
        ' textboxWLName
        ' 
        textboxWLName.Location = New Point(7, 56)
        textboxWLName.Name = "textboxWLName"
        textboxWLName.Size = New Size(388, 25)
        textboxWLName.TabIndex = 15
        ' 
        ' checkboxWLShowMenuIcons
        ' 
        checkboxWLShowMenuIcons.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWLShowMenuIcons.Location = New Point(479, 53)
        checkboxWLShowMenuIcons.Name = "checkboxWLShowMenuIcons"
        checkboxWLShowMenuIcons.Size = New Size(129, 21)
        checkboxWLShowMenuIcons.TabIndex = 64
        checkboxWLShowMenuIcons.Text = "Show Menu Icons"
        checkboxWLShowMenuIcons.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowInTray
        ' 
        checkboxWLShowInTray.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWLShowInTray.Location = New Point(479, 37)
        checkboxWLShowInTray.Name = "checkboxWLShowInTray"
        checkboxWLShowInTray.Size = New Size(109, 21)
        checkboxWLShowInTray.TabIndex = 62
        checkboxWLShowInTray.Text = "Show In Tray"
        checkboxWLShowInTray.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowInMenu
        ' 
        checkboxWLShowInMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWLShowInMenu.Location = New Point(479, 21)
        checkboxWLShowInMenu.Name = "checkboxWLShowInMenu"
        checkboxWLShowInMenu.Size = New Size(109, 21)
        checkboxWLShowInMenu.TabIndex = 60
        checkboxWLShowInMenu.Text = "Show In Menu"
        checkboxWLShowInMenu.UseVisualStyleBackColor = True
        ' 
        ' comboboxWLFolderPlacement
        ' 
        comboboxWLFolderPlacement.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxWLFolderPlacement.FormattingEnabled = True
        comboboxWLFolderPlacement.Items.AddRange(New Object() {"Top", "Bottom", "Merged"})
        comboboxWLFolderPlacement.Location = New Point(253, 96)
        comboboxWLFolderPlacement.Name = "comboboxWLFolderPlacement"
        comboboxWLFolderPlacement.Size = New Size(85, 25)
        comboboxWLFolderPlacement.TabIndex = 40
        ' 
        ' comboboxWLFolderMode
        ' 
        comboboxWLFolderMode.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxWLFolderMode.FormattingEnabled = True
        comboboxWLFolderMode.Items.AddRange(New Object() {"No Folders", "Show As Link", "Show As Link Menu", "Show As Menu", "Folders Only"})
        comboboxWLFolderMode.Location = New Point(106, 96)
        comboboxWLFolderMode.Name = "comboboxWLFolderMode"
        comboboxWLFolderMode.Size = New Size(142, 25)
        comboboxWLFolderMode.TabIndex = 30
        ' 
        ' comboboxWLSort
        ' 
        comboboxWLSort.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxWLSort.FormattingEnabled = True
        comboboxWLSort.Items.AddRange(New Object() {"Ascending", "Descending"})
        comboboxWLSort.Location = New Point(7, 96)
        comboboxWLSort.Name = "comboboxWLSort"
        comboboxWLSort.Size = New Size(94, 25)
        comboboxWLSort.TabIndex = 20
        ' 
        ' textboxWLRoot
        ' 
        textboxWLRoot.Location = New Point(7, 19)
        textboxWLRoot.Name = "textboxWLRoot"
        textboxWLRoot.Size = New Size(388, 25)
        textboxWLRoot.TabIndex = 10
        ' 
        ' btnWLSelectFolder
        ' 
        btnWLSelectFolder.FlatAppearance.BorderSize = 0
        btnWLSelectFolder.FlatStyle = FlatStyle.Flat
        btnWLSelectFolder.Image = My.Resources.Resources.imageRestore
        btnWLSelectFolder.Location = New Point(393, 21)
        btnWLSelectFolder.Name = "btnWLSelectFolder"
        btnWLSelectFolder.Size = New Size(21, 21)
        btnWLSelectFolder.TabIndex = 10
        btnWLSelectFolder.TabStop = False
        btnWLSelectFolder.UseVisualStyleBackColor = True
        ' 
        ' btnWLCancel
        ' 
        btnWLCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnWLCancel.ForeColor = Color.Navy
        btnWLCancel.Image = My.Resources.Resources.imageRemove
        btnWLCancel.ImageAlign = ContentAlignment.MiddleLeft
        btnWLCancel.Location = New Point(401, 96)
        btnWLCancel.Name = "btnWLCancel"
        btnWLCancel.Size = New Size(132, 26)
        btnWLCancel.TabIndex = 156
        btnWLCancel.Text = "Cancel"
        btnWLCancel.TextAlign = ContentAlignment.MiddleRight
        btnWLCancel.UseVisualStyleBackColor = True
        ' 
        ' btnWLSet
        ' 
        btnWLSet.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnWLSet.ForeColor = Color.Navy
        btnWLSet.Image = My.Resources.Resources.imageGoStart
        btnWLSet.ImageAlign = ContentAlignment.MiddleLeft
        btnWLSet.Location = New Point(532, 96)
        btnWLSet.Name = "btnWLSet"
        btnWLSet.Size = New Size(66, 26)
        btnWLSet.TabIndex = 157
        btnWLSet.Text = "Set"
        btnWLSet.TextAlign = ContentAlignment.MiddleRight
        btnWLSet.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLUseDefaultIcon
        ' 
        checkboxWLUseDefaultIcon.Location = New Point(479, 5)
        checkboxWLUseDefaultIcon.Name = "checkboxWLUseDefaultIcon"
        checkboxWLUseDefaultIcon.Size = New Size(122, 21)
        checkboxWLUseDefaultIcon.TabIndex = 9
        checkboxWLUseDefaultIcon.Text = "Use Default Icon"
        checkboxWLUseDefaultIcon.UseVisualStyleBackColor = True
        ' 
        ' label28
        ' 
        label28.Location = New Point(5, 81)
        label28.Name = "label28"
        label28.Size = New Size(58, 21)
        label28.TabIndex = 165
        label28.Text = "Sort Order"
        ' 
        ' label29
        ' 
        label29.Location = New Point(104, 81)
        label29.Name = "label29"
        label29.Size = New Size(74, 21)
        label29.TabIndex = 161
        label29.Text = "Folder Mode"
        ' 
        ' label30
        ' 
        label30.Location = New Point(251, 81)
        label30.Name = "label30"
        label30.Size = New Size(89, 21)
        label30.TabIndex = 166
        label30.Text = "Folder Placement"
        ' 
        ' label2
        ' 
        label2.Location = New Point(5, 41)
        label2.Name = "label2"
        label2.Size = New Size(95, 21)
        label2.TabIndex = 168
        label2.Text = "Display Name"
        tipInfo.SetToolTip(label2, "Leave Blank To Use FolderName")
        ' 
        ' lblWLRoot
        ' 
        lblWLRoot.Location = New Point(5, 4)
        lblWLRoot.Name = "lblWLRoot"
        lblWLRoot.Size = New Size(322, 21)
        lblWLRoot.TabIndex = 160
        lblWLRoot.Text = "SAMPLE"
        ' 
        ' textboxWLMaxLinksPerFolder
        ' 
        textboxWLMaxLinksPerFolder.Location = New Point(5, 34)
        textboxWLMaxLinksPerFolder.MaxLength = 3
        textboxWLMaxLinksPerFolder.Name = "textboxWLMaxLinksPerFolder"
        textboxWLMaxLinksPerFolder.Size = New Size(44, 25)
        textboxWLMaxLinksPerFolder.TabIndex = 5
        textboxWLMaxLinksPerFolder.TextAlign = HorizontalAlignment.Center
        ' 
        ' textboxWLStartUpDelay
        ' 
        textboxWLStartUpDelay.Location = New Point(5, 8)
        textboxWLStartUpDelay.MaxLength = 3
        textboxWLStartUpDelay.Name = "textboxWLStartUpDelay"
        textboxWLStartUpDelay.Size = New Size(44, 25)
        textboxWLStartUpDelay.TabIndex = 4
        textboxWLStartUpDelay.TextAlign = HorizontalAlignment.Center
        ' 
        ' textboxWLAutoRefreshInterval
        ' 
        textboxWLAutoRefreshInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        textboxWLAutoRefreshInterval.Location = New Point(567, 8)
        textboxWLAutoRefreshInterval.MaxLength = 2
        textboxWLAutoRefreshInterval.Name = "textboxWLAutoRefreshInterval"
        textboxWLAutoRefreshInterval.Size = New Size(44, 25)
        textboxWLAutoRefreshInterval.TabIndex = 20
        textboxWLAutoRefreshInterval.TextAlign = HorizontalAlignment.Center
        ' 
        ' listviewWL
        ' 
        listviewWL.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        listviewWL.BorderStyle = BorderStyle.FixedSingle
        listviewWL.ContextMenuStrip = cmlistviewWL
        listviewWL.FullRowSelect = True
        listviewWL.HeaderStyle = ColumnHeaderStyle.None
        listviewWL.LabelWrap = False
        listviewWL.Location = New Point(5, 105)
        listviewWL.MultiSelect = False
        listviewWL.Name = "listviewWL"
        listviewWL.ShowGroups = False
        listviewWL.ShowItemToolTips = True
        listviewWL.Size = New Size(606, 111)
        listviewWL.TabIndex = 50
        tipInfo.SetToolTip(listviewWL, " ")
        listviewWL.UseCompatibleStateImageBehavior = False
        listviewWL.View = View.Details
        ' 
        ' cmlistviewWL
        ' 
        cmlistviewWL.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmlistviewWL.Items.AddRange(New ToolStripItem() {cmiWLMoveUp, cmiWLMoveDown, toolStripSeparator11, cmiWLNew, toolStripSeparator6, cmiWLDelete})
        cmlistviewWL.Name = "contextmenulistviewHotLinks"
        cmlistviewWL.Size = New Size(114, 104)
        ' 
        ' cmiWLMoveUp
        ' 
        cmiWLMoveUp.Image = My.Resources.Resources.imageMoveUp
        cmiWLMoveUp.Name = "cmiWLMoveUp"
        cmiWLMoveUp.Size = New Size(113, 22)
        cmiWLMoveUp.Text = "Up"
        ' 
        ' cmiWLMoveDown
        ' 
        cmiWLMoveDown.Image = My.Resources.Resources.imageMoveDown
        cmiWLMoveDown.Name = "cmiWLMoveDown"
        cmiWLMoveDown.Size = New Size(113, 22)
        cmiWLMoveDown.Text = "Down"
        ' 
        ' toolStripSeparator11
        ' 
        toolStripSeparator11.Name = "toolStripSeparator11"
        toolStripSeparator11.Size = New Size(110, 6)
        ' 
        ' cmiWLNew
        ' 
        cmiWLNew.Image = My.Resources.Resources.imageWLNew
        cmiWLNew.Name = "cmiWLNew"
        cmiWLNew.Size = New Size(113, 22)
        ' 
        ' toolStripSeparator6
        ' 
        toolStripSeparator6.Name = "toolStripSeparator6"
        toolStripSeparator6.Size = New Size(110, 6)
        ' 
        ' cmiWLDelete
        ' 
        cmiWLDelete.Image = My.Resources.Resources.imageRemove
        cmiWLDelete.Name = "cmiWLDelete"
        cmiWLDelete.Size = New Size(113, 22)
        cmiWLDelete.Text = "Delete"
        ' 
        ' textboxWLAutoRefreshIdleInterval
        ' 
        textboxWLAutoRefreshIdleInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        textboxWLAutoRefreshIdleInterval.Location = New Point(567, 34)
        textboxWLAutoRefreshIdleInterval.MaxLength = 3
        textboxWLAutoRefreshIdleInterval.Name = "textboxWLAutoRefreshIdleInterval"
        textboxWLAutoRefreshIdleInterval.Size = New Size(44, 25)
        textboxWLAutoRefreshIdleInterval.TabIndex = 22
        textboxWLAutoRefreshIdleInterval.TextAlign = HorizontalAlignment.Center
        ' 
        ' checkboxWLShowFilePathToolTips
        ' 
        checkboxWLShowFilePathToolTips.Location = New Point(5, 57)
        checkboxWLShowFilePathToolTips.Name = "checkboxWLShowFilePathToolTips"
        checkboxWLShowFilePathToolTips.Size = New Size(172, 21)
        checkboxWLShowFilePathToolTips.TabIndex = 11
        checkboxWLShowFilePathToolTips.Text = "Show File Path In ToolTip"
        tipInfo.SetToolTip(checkboxWLShowFilePathToolTips, "Show Full File Path In ToolTip")
        checkboxWLShowFilePathToolTips.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLAutoRefresh
        ' 
        checkboxWLAutoRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        checkboxWLAutoRefresh.CheckAlign = ContentAlignment.MiddleRight
        checkboxWLAutoRefresh.Location = New Point(471, 57)
        checkboxWLAutoRefresh.Name = "checkboxWLAutoRefresh"
        checkboxWLAutoRefresh.Size = New Size(141, 21)
        checkboxWLAutoRefresh.TabIndex = 24
        checkboxWLAutoRefresh.Text = "Enable AutoRefresh"
        checkboxWLAutoRefresh.TextAlign = ContentAlignment.MiddleRight
        tipInfo.SetToolTip(checkboxWLAutoRefresh, "Enable AutoRefresh For Last WinLink")
        checkboxWLAutoRefresh.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowFileInfoToolTips
        ' 
        checkboxWLShowFileInfoToolTips.Location = New Point(177, 57)
        checkboxWLShowFileInfoToolTips.Name = "checkboxWLShowFileInfoToolTips"
        checkboxWLShowFileInfoToolTips.Size = New Size(170, 21)
        checkboxWLShowFileInfoToolTips.TabIndex = 12
        checkboxWLShowFileInfoToolTips.Text = "Show File Info In ToolTip"
        tipInfo.SetToolTip(checkboxWLShowFileInfoToolTips, "Show File Details In ToolTip")
        checkboxWLShowFileInfoToolTips.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowFolderPathToolTips
        ' 
        checkboxWLShowFolderPathToolTips.Location = New Point(5, 75)
        checkboxWLShowFolderPathToolTips.Name = "checkboxWLShowFolderPathToolTips"
        checkboxWLShowFolderPathToolTips.Size = New Size(194, 21)
        checkboxWLShowFolderPathToolTips.TabIndex = 13
        checkboxWLShowFolderPathToolTips.Text = "Show Folder Path In ToolTip"
        tipInfo.SetToolTip(checkboxWLShowFolderPathToolTips, "Show Full Directory Path In ToolTip")
        checkboxWLShowFolderPathToolTips.UseVisualStyleBackColor = True
        ' 
        ' lblWLAutoRefresh
        ' 
        lblWLAutoRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblWLAutoRefresh.Enabled = False
        lblWLAutoRefresh.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWLAutoRefresh.Location = New Point(472, 71)
        lblWLAutoRefresh.Name = "lblWLAutoRefresh"
        lblWLAutoRefresh.Size = New Size(141, 21)
        lblWLAutoRefresh.TabIndex = 26
        lblWLAutoRefresh.Text = "AutoRefresh Engaged"
        lblWLAutoRefresh.TextAlign = ContentAlignment.MiddleLeft
        lblWLAutoRefresh.Visible = False
        ' 
        ' btnWLRefresh
        ' 
        btnWLRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnWLRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnWLRefresh.Location = New Point(232, 79)
        btnWLRefresh.Name = "btnWLRefresh"
        btnWLRefresh.Size = New Size(153, 26)
        btnWLRefresh.TabIndex = 1
        btnWLRefresh.TabStop = False
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
        tabpageHC.Location = New Point(4, 24)
        tabpageHC.Name = "tabpageHC"
        tabpageHC.Padding = New Padding(3)
        tabpageHC.Size = New Size(618, 375)
        tabpageHC.TabIndex = 6
        tabpageHC.Text = """HotClicks"""
        tabpageHC.UseVisualStyleBackColor = True
        ' 
        ' comboboxHCRight
        ' 
        comboboxHCRight.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxHCRight.FormattingEnabled = True
        comboboxHCRight.Location = New Point(210, 167)
        comboboxHCRight.Name = "comboboxHCRight"
        comboboxHCRight.Size = New Size(258, 25)
        comboboxHCRight.Sorted = True
        comboboxHCRight.TabIndex = 50
        ' 
        ' comboboxHCMiddle
        ' 
        comboboxHCMiddle.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxHCMiddle.FormattingEnabled = True
        comboboxHCMiddle.Location = New Point(210, 139)
        comboboxHCMiddle.Name = "comboboxHCMiddle"
        comboboxHCMiddle.Size = New Size(258, 25)
        comboboxHCMiddle.Sorted = True
        comboboxHCMiddle.TabIndex = 40
        ' 
        ' comboboxHCDouble
        ' 
        comboboxHCDouble.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxHCDouble.FormattingEnabled = True
        comboboxHCDouble.Location = New Point(210, 111)
        comboboxHCDouble.Name = "comboboxHCDouble"
        comboboxHCDouble.Size = New Size(258, 25)
        comboboxHCDouble.Sorted = True
        comboboxHCDouble.TabIndex = 30
        ' 
        ' comboboxHCLeft
        ' 
        comboboxHCLeft.DropDownStyle = ComboBoxStyle.DropDownList
        comboboxHCLeft.FormattingEnabled = True
        comboboxHCLeft.Location = New Point(210, 83)
        comboboxHCLeft.Name = "comboboxHCLeft"
        comboboxHCLeft.Size = New Size(258, 25)
        comboboxHCLeft.Sorted = True
        comboboxHCLeft.TabIndex = 20
        ' 
        ' groupBox2
        ' 
        groupBox2.Controls.Add(radiobtnHCWL)
        groupBox2.Controls.Add(radiobtnHCWSTSS)
        groupBox2.Controls.Add(radiobtnHCWST)
        groupBox2.Location = New Point(172, 28)
        groupBox2.Name = "groupBox2"
        groupBox2.Size = New Size(296, 38)
        groupBox2.TabIndex = 10
        groupBox2.TabStop = False
        ' 
        ' radiobtnHCWL
        ' 
        radiobtnHCWL.Image = My.Resources.Resources.imageWL
        radiobtnHCWL.ImageAlign = ContentAlignment.MiddleLeft
        radiobtnHCWL.Location = New Point(205, 11)
        radiobtnHCWL.Name = "radiobtnHCWL"
        radiobtnHCWL.Size = New Size(40, 24)
        radiobtnHCWL.TabIndex = 4
        radiobtnHCWL.TabStop = True
        radiobtnHCWL.TextAlign = ContentAlignment.MiddleCenter
        tipHC.SetToolTip(radiobtnHCWL, "WinLinks")
        radiobtnHCWL.UseVisualStyleBackColor = True
        ' 
        ' radiobtnHCWSTSS
        ' 
        radiobtnHCWSTSS.Image = My.Resources.Resources.imageWSTScreenSaverEnabled
        radiobtnHCWSTSS.ImageAlign = ContentAlignment.MiddleLeft
        radiobtnHCWSTSS.Location = New Point(107, 11)
        radiobtnHCWSTSS.Name = "radiobtnHCWSTSS"
        radiobtnHCWSTSS.Size = New Size(40, 24)
        radiobtnHCWSTSS.TabIndex = 1
        radiobtnHCWSTSS.TabStop = True
        radiobtnHCWSTSS.TextAlign = ContentAlignment.MiddleCenter
        tipHC.SetToolTip(radiobtnHCWSTSS, "Screen Saver")
        radiobtnHCWSTSS.UseVisualStyleBackColor = True
        ' 
        ' radiobtnHCWST
        ' 
        radiobtnHCWST.Image = My.Resources.Resources.imageWST
        radiobtnHCWST.ImageAlign = ContentAlignment.MiddleLeft
        radiobtnHCWST.Location = New Point(59, 11)
        radiobtnHCWST.Name = "radiobtnHCWST"
        radiobtnHCWST.Size = New Size(40, 24)
        radiobtnHCWST.TabIndex = 0
        radiobtnHCWST.TabStop = True
        radiobtnHCWST.TextAlign = ContentAlignment.MiddleCenter
        tipHC.SetToolTip(radiobtnHCWST, "WorkSpace Tools")
        radiobtnHCWST.UseMnemonic = False
        radiobtnHCWST.UseVisualStyleBackColor = False
        ' 
        ' label17
        ' 
        label17.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label17.ForeColor = Color.Navy
        label17.Location = New Point(142, 114)
        label17.Name = "label17"
        label17.Size = New Size(64, 18)
        label17.TabIndex = 29
        label17.Text = "DOUBLE"
        label17.TextAlign = ContentAlignment.MiddleRight
        tipHC.SetToolTip(label17, "DoubleClick On Tray Icon")
        ' 
        ' label12
        ' 
        label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label12.ForeColor = Color.Navy
        label12.Location = New Point(142, 86)
        label12.Name = "label12"
        label12.Size = New Size(64, 18)
        label12.TabIndex = 19
        label12.Text = "LEFT"
        label12.TextAlign = ContentAlignment.MiddleRight
        tipHC.SetToolTip(label12, "LeftClick On Tray Icon")
        ' 
        ' label16
        ' 
        label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label16.ForeColor = Color.Navy
        label16.Location = New Point(142, 142)
        label16.Name = "label16"
        label16.Size = New Size(64, 18)
        label16.TabIndex = 39
        label16.Text = "MIDDLE"
        label16.TextAlign = ContentAlignment.MiddleRight
        tipHC.SetToolTip(label16, "MiddleClick On Tray Icon")
        ' 
        ' label15
        ' 
        label15.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label15.ForeColor = Color.Navy
        label15.Location = New Point(142, 170)
        label15.Name = "label15"
        label15.Size = New Size(64, 18)
        label15.TabIndex = 49
        label15.Text = "RIGHT"
        label15.TextAlign = ContentAlignment.MiddleRight
        tipHC.SetToolTip(label15, "RightClick On Tray Icon")
        ' 
        ' tabpageHK
        ' 
        tabpageHK.Controls.Add(textboxHKWSTCommandPrompt)
        tabpageHK.Controls.Add(textboxHKWSTTaskManager)
        tabpageHK.Controls.Add(textboxHKWL)
        tabpageHK.Controls.Add(textboxHKWSTClock)
        tabpageHK.Controls.Add(textboxHKWSTLockWorkSpace)
        tabpageHK.Controls.Add(btnHKSet)
        tabpageHK.Controls.Add(btnHKReset)
        tabpageHK.Controls.Add(textboxHKWSTScreenSaver)
        tabpageHK.Controls.Add(btnHKEnabled)
        tabpageHK.Controls.Add(lblHKWSTCommandPrompt)
        tabpageHK.Controls.Add(lblHKWSTTaskManager)
        tabpageHK.Controls.Add(lblHKWL)
        tabpageHK.Controls.Add(lblHKWSTClock)
        tabpageHK.Controls.Add(lblHKWSTStopWatch)
        tabpageHK.Controls.Add(lblHKWSTLockWorkSpace)
        tabpageHK.Controls.Add(lblHKWSTScreenSaver)
        tabpageHK.Controls.Add(btnHKWSTCommandPromptDisable)
        tabpageHK.Controls.Add(btnHKWSTTaskManagerDisable)
        tabpageHK.Controls.Add(btnHKWLDisable)
        tabpageHK.Controls.Add(btnHKWSTClockDisable)
        tabpageHK.Controls.Add(btnHKWSTLockWorkSpaceDisable)
        tabpageHK.Controls.Add(btnHKWSTScreenSaverDisable)
        tabpageHK.Location = New Point(4, 24)
        tabpageHK.Name = "tabpageHK"
        tabpageHK.Padding = New Padding(3)
        tabpageHK.Size = New Size(618, 375)
        tabpageHK.TabIndex = 5
        tabpageHK.Text = """HotKeys"""
        tabpageHK.UseVisualStyleBackColor = True
        ' 
        ' textboxHKWSTCommandPrompt
        ' 
        textboxHKWSTCommandPrompt.Anchor = AnchorStyles.Top
        textboxHKWSTCommandPrompt.Location = New Point(449, 106)
        textboxHKWSTCommandPrompt.Name = "textboxHKWSTCommandPrompt"
        textboxHKWSTCommandPrompt.ShortcutsEnabled = False
        textboxHKWSTCommandPrompt.Size = New Size(143, 25)
        textboxHKWSTCommandPrompt.TabIndex = 127
        textboxHKWSTCommandPrompt.TabStop = False
        textboxHKWSTCommandPrompt.TextAlign = HorizontalAlignment.Center
        textboxHKWSTCommandPrompt.WordWrap = False
        ' 
        ' textboxHKWSTTaskManager
        ' 
        textboxHKWSTTaskManager.Anchor = AnchorStyles.Top
        textboxHKWSTTaskManager.Location = New Point(449, 65)
        textboxHKWSTTaskManager.Name = "textboxHKWSTTaskManager"
        textboxHKWSTTaskManager.ShortcutsEnabled = False
        textboxHKWSTTaskManager.Size = New Size(143, 25)
        textboxHKWSTTaskManager.TabIndex = 124
        textboxHKWSTTaskManager.TabStop = False
        textboxHKWSTTaskManager.TextAlign = HorizontalAlignment.Center
        textboxHKWSTTaskManager.WordWrap = False
        ' 
        ' textboxHKWL
        ' 
        textboxHKWL.Anchor = AnchorStyles.Top
        textboxHKWL.Location = New Point(449, 24)
        textboxHKWL.Name = "textboxHKWL"
        textboxHKWL.ShortcutsEnabled = False
        textboxHKWL.Size = New Size(143, 25)
        textboxHKWL.TabIndex = 118
        textboxHKWL.TabStop = False
        textboxHKWL.TextAlign = HorizontalAlignment.Center
        textboxHKWL.WordWrap = False
        ' 
        ' textboxHKWSTClock
        ' 
        textboxHKWSTClock.Location = New Point(9, 65)
        textboxHKWSTClock.Name = "textboxHKWSTClock"
        textboxHKWSTClock.ShortcutsEnabled = False
        textboxHKWSTClock.Size = New Size(143, 25)
        textboxHKWSTClock.TabIndex = 41
        textboxHKWSTClock.TabStop = False
        textboxHKWSTClock.TextAlign = HorizontalAlignment.Center
        textboxHKWSTClock.WordWrap = False
        ' 
        ' textboxHKWSTLockWorkSpace
        ' 
        textboxHKWSTLockWorkSpace.Location = New Point(9, 147)
        textboxHKWSTLockWorkSpace.Name = "textboxHKWSTLockWorkSpace"
        textboxHKWSTLockWorkSpace.ShortcutsEnabled = False
        textboxHKWSTLockWorkSpace.Size = New Size(143, 25)
        textboxHKWSTLockWorkSpace.TabIndex = 12
        textboxHKWSTLockWorkSpace.TabStop = False
        textboxHKWSTLockWorkSpace.TextAlign = HorizontalAlignment.Center
        textboxHKWSTLockWorkSpace.WordWrap = False
        ' 
        ' btnHKSet
        ' 
        btnHKSet.Anchor = AnchorStyles.Top
        btnHKSet.Enabled = False
        btnHKSet.ForeColor = Color.Navy
        btnHKSet.Image = My.Resources.Resources.imageGoStart
        btnHKSet.ImageAlign = ContentAlignment.MiddleLeft
        btnHKSet.Location = New Point(82, 315)
        btnHKSet.Name = "btnHKSet"
        btnHKSet.Size = New Size(72, 32)
        btnHKSet.TabIndex = 1010
        btnHKSet.Text = "Set"
        btnHKSet.TextAlign = ContentAlignment.MiddleRight
        btnHKSet.UseVisualStyleBackColor = True
        ' 
        ' btnHKReset
        ' 
        btnHKReset.Enabled = False
        btnHKReset.ForeColor = Color.Navy
        btnHKReset.Image = My.Resources.Resources.imageRemove
        btnHKReset.ImageAlign = ContentAlignment.MiddleLeft
        btnHKReset.Location = New Point(4, 315)
        btnHKReset.Name = "btnHKReset"
        btnHKReset.Size = New Size(72, 32)
        btnHKReset.TabIndex = 1000
        btnHKReset.Text = "Undo"
        btnHKReset.TextAlign = ContentAlignment.MiddleRight
        btnHKReset.UseVisualStyleBackColor = True
        ' 
        ' textboxHKWSTScreenSaver
        ' 
        textboxHKWSTScreenSaver.Location = New Point(9, 24)
        textboxHKWSTScreenSaver.Name = "textboxHKWSTScreenSaver"
        textboxHKWSTScreenSaver.ShortcutsEnabled = False
        textboxHKWSTScreenSaver.Size = New Size(143, 25)
        textboxHKWSTScreenSaver.TabIndex = 28
        textboxHKWSTScreenSaver.TabStop = False
        textboxHKWSTScreenSaver.TextAlign = HorizontalAlignment.Center
        textboxHKWSTScreenSaver.WordWrap = False
        ' 
        ' btnHKEnabled
        ' 
        btnHKEnabled.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnHKEnabled.ForeColor = Color.Navy
        btnHKEnabled.ImageAlign = ContentAlignment.MiddleLeft
        btnHKEnabled.Location = New Point(478, 315)
        btnHKEnabled.Name = "btnHKEnabled"
        btnHKEnabled.Size = New Size(134, 32)
        btnHKEnabled.TabIndex = 1020
        btnHKEnabled.TextAlign = ContentAlignment.MiddleRight
        btnHKEnabled.UseVisualStyleBackColor = True
        ' 
        ' lblHKWSTCommandPrompt
        ' 
        lblHKWSTCommandPrompt.Anchor = AnchorStyles.Top
        lblHKWSTCommandPrompt.ForeColor = SystemColors.ControlText
        lblHKWSTCommandPrompt.Location = New Point(449, 90)
        lblHKWSTCommandPrompt.Name = "lblHKWSTCommandPrompt"
        lblHKWSTCommandPrompt.Size = New Size(143, 14)
        lblHKWSTCommandPrompt.TabIndex = 126
        lblHKWSTCommandPrompt.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHKWSTTaskManager
        ' 
        lblHKWSTTaskManager.Anchor = AnchorStyles.Top
        lblHKWSTTaskManager.ForeColor = SystemColors.ControlText
        lblHKWSTTaskManager.Location = New Point(449, 49)
        lblHKWSTTaskManager.Name = "lblHKWSTTaskManager"
        lblHKWSTTaskManager.Size = New Size(143, 14)
        lblHKWSTTaskManager.TabIndex = 123
        lblHKWSTTaskManager.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHKWL
        ' 
        lblHKWL.Anchor = AnchorStyles.Top
        lblHKWL.ForeColor = SystemColors.ControlText
        lblHKWL.Location = New Point(449, 8)
        lblHKWL.Name = "lblHKWL"
        lblHKWL.Size = New Size(143, 14)
        lblHKWL.TabIndex = 117
        lblHKWL.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHKWSTClock
        ' 
        lblHKWSTClock.ForeColor = SystemColors.ControlText
        lblHKWSTClock.Location = New Point(9, 49)
        lblHKWSTClock.Name = "lblHKWSTClock"
        lblHKWSTClock.Size = New Size(143, 14)
        lblHKWSTClock.TabIndex = 40
        lblHKWSTClock.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHKWSTStopWatch
        ' 
        lblHKWSTStopWatch.ForeColor = SystemColors.ControlText
        lblHKWSTStopWatch.Location = New Point(9, 90)
        lblHKWSTStopWatch.Name = "lblHKWSTStopWatch"
        lblHKWSTStopWatch.Size = New Size(143, 14)
        lblHKWSTStopWatch.TabIndex = 23
        lblHKWSTStopWatch.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHKWSTLockWorkSpace
        ' 
        lblHKWSTLockWorkSpace.ForeColor = SystemColors.ControlText
        lblHKWSTLockWorkSpace.Location = New Point(9, 131)
        lblHKWSTLockWorkSpace.Name = "lblHKWSTLockWorkSpace"
        lblHKWSTLockWorkSpace.Size = New Size(143, 14)
        lblHKWSTLockWorkSpace.TabIndex = 10
        lblHKWSTLockWorkSpace.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblHKWSTScreenSaver
        ' 
        lblHKWSTScreenSaver.ForeColor = SystemColors.ControlText
        lblHKWSTScreenSaver.Location = New Point(9, 8)
        lblHKWSTScreenSaver.Name = "lblHKWSTScreenSaver"
        lblHKWSTScreenSaver.Size = New Size(143, 14)
        lblHKWSTScreenSaver.TabIndex = 27
        lblHKWSTScreenSaver.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' btnHKWSTCommandPromptDisable
        ' 
        btnHKWSTCommandPromptDisable.Anchor = AnchorStyles.Top
        btnHKWSTCommandPromptDisable.FlatStyle = FlatStyle.Flat
        btnHKWSTCommandPromptDisable.ForeColor = Color.Transparent
        btnHKWSTCommandPromptDisable.Image = My.Resources.Resources.imageRemove
        btnHKWSTCommandPromptDisable.Location = New Point(589, 108)
        btnHKWSTCommandPromptDisable.Name = "btnHKWSTCommandPromptDisable"
        btnHKWSTCommandPromptDisable.Size = New Size(20, 20)
        btnHKWSTCommandPromptDisable.TabIndex = 128
        btnHKWSTCommandPromptDisable.TabStop = False
        btnHKWSTCommandPromptDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHKWSTTaskManagerDisable
        ' 
        btnHKWSTTaskManagerDisable.Anchor = AnchorStyles.Top
        btnHKWSTTaskManagerDisable.FlatStyle = FlatStyle.Flat
        btnHKWSTTaskManagerDisable.ForeColor = Color.Transparent
        btnHKWSTTaskManagerDisable.Image = My.Resources.Resources.imageRemove
        btnHKWSTTaskManagerDisable.Location = New Point(589, 67)
        btnHKWSTTaskManagerDisable.Name = "btnHKWSTTaskManagerDisable"
        btnHKWSTTaskManagerDisable.Size = New Size(20, 20)
        btnHKWSTTaskManagerDisable.TabIndex = 125
        btnHKWSTTaskManagerDisable.TabStop = False
        btnHKWSTTaskManagerDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHKWLDisable
        ' 
        btnHKWLDisable.Anchor = AnchorStyles.Top
        btnHKWLDisable.FlatStyle = FlatStyle.Flat
        btnHKWLDisable.ForeColor = Color.Transparent
        btnHKWLDisable.Image = My.Resources.Resources.imageRemove
        btnHKWLDisable.Location = New Point(589, 26)
        btnHKWLDisable.Name = "btnHKWLDisable"
        btnHKWLDisable.Size = New Size(20, 20)
        btnHKWLDisable.TabIndex = 119
        btnHKWLDisable.TabStop = False
        btnHKWLDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHKWSTClockDisable
        ' 
        btnHKWSTClockDisable.FlatStyle = FlatStyle.Flat
        btnHKWSTClockDisable.ForeColor = Color.Transparent
        btnHKWSTClockDisable.Image = My.Resources.Resources.imageRemove
        btnHKWSTClockDisable.Location = New Point(149, 67)
        btnHKWSTClockDisable.Name = "btnHKWSTClockDisable"
        btnHKWSTClockDisable.Size = New Size(20, 20)
        btnHKWSTClockDisable.TabIndex = 42
        btnHKWSTClockDisable.TabStop = False
        btnHKWSTClockDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHKWSTLockWorkSpaceDisable
        ' 
        btnHKWSTLockWorkSpaceDisable.FlatStyle = FlatStyle.Flat
        btnHKWSTLockWorkSpaceDisable.ForeColor = Color.Transparent
        btnHKWSTLockWorkSpaceDisable.Image = My.Resources.Resources.imageRemove
        btnHKWSTLockWorkSpaceDisable.Location = New Point(149, 149)
        btnHKWSTLockWorkSpaceDisable.Name = "btnHKWSTLockWorkSpaceDisable"
        btnHKWSTLockWorkSpaceDisable.Size = New Size(20, 20)
        btnHKWSTLockWorkSpaceDisable.TabIndex = 14
        btnHKWSTLockWorkSpaceDisable.TabStop = False
        btnHKWSTLockWorkSpaceDisable.UseVisualStyleBackColor = True
        ' 
        ' btnHKWSTScreenSaverDisable
        ' 
        btnHKWSTScreenSaverDisable.FlatStyle = FlatStyle.Flat
        btnHKWSTScreenSaverDisable.ForeColor = Color.Transparent
        btnHKWSTScreenSaverDisable.Image = My.Resources.Resources.imageRemove
        btnHKWSTScreenSaverDisable.Location = New Point(149, 26)
        btnHKWSTScreenSaverDisable.Name = "btnHKWSTScreenSaverDisable"
        btnHKWSTScreenSaverDisable.Size = New Size(20, 20)
        btnHKWSTScreenSaverDisable.TabIndex = 29
        btnHKWSTScreenSaverDisable.TabStop = False
        btnHKWSTScreenSaverDisable.UseVisualStyleBackColor = True
        ' 
        ' tipInfo
        ' 
        tipInfo.AutomaticDelay = 250
        tipInfo.AutoPopDelay = 10000
        tipInfo.InitialDelay = 250
        tipInfo.ReshowDelay = 50
        tipInfo.UseAnimation = False
        tipInfo.UseFading = False
        ' 
        ' btnBalloonTest
        ' 
        btnBalloonTest.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnBalloonTest.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnBalloonTest.FlatAppearance.BorderSize = 0
        btnBalloonTest.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnBalloonTest.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnBalloonTest.Image = My.Resources.Resources.imageBalloon
        btnBalloonTest.Location = New Point(367, 432)
        btnBalloonTest.Name = "btnBalloonTest"
        btnBalloonTest.Size = New Size(25, 24)
        btnBalloonTest.TabIndex = 0
        btnBalloonTest.TabStop = False
        tipInfo.SetToolTip(btnBalloonTest, "LeftClick = Toggle Balloon" & vbCrLf & "CtrlLeftClick = Toggle Splash Screen" & vbCrLf & "RightClick = Test DebugForm")
        btnBalloonTest.Visible = False
        ' 
        ' btnErrorTest
        ' 
        btnErrorTest.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnErrorTest.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnErrorTest.FlatAppearance.BorderSize = 0
        btnErrorTest.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnErrorTest.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnErrorTest.Image = My.Resources.Resources.imageError
        btnErrorTest.Location = New Point(337, 432)
        btnErrorTest.Name = "btnErrorTest"
        btnErrorTest.Size = New Size(24, 24)
        btnErrorTest.TabIndex = 0
        btnErrorTest.TabStop = False
        tipInfo.SetToolTip(btnErrorTest, "LeftClick = Test Error" & vbCrLf & "RightClick = Cause Exception")
        btnErrorTest.Visible = False
        ' 
        ' btnClockTest
        ' 
        btnClockTest.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClockTest.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnClockTest.FlatAppearance.BorderSize = 0
        btnClockTest.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnClockTest.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnClockTest.Image = My.Resources.Resources.imageWSTClock
        btnClockTest.Location = New Point(398, 432)
        btnClockTest.Name = "btnClockTest"
        btnClockTest.Size = New Size(24, 24)
        btnClockTest.TabIndex = 0
        btnClockTest.TabStop = False
        tipInfo.SetToolTip(btnClockTest, "Toggle Clock")
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
        btnInfo.Image = My.Resources.Resources.imageInfo
        btnInfo.ImageAlign = ContentAlignment.TopLeft
        btnInfo.Location = New Point(140, 420)
        btnInfo.Name = "btnInfo"
        btnInfo.Size = New Size(62, 46)
        btnInfo.TabIndex = 0
        btnInfo.TabStop = False
        btnInfo.Text = "Help"
        btnInfo.TextAlign = ContentAlignment.BottomRight
        tipInfo.SetToolTip(btnInfo, "Help & About" & vbCrLf & "RightClick = Show Maximized")
        ' 
        ' btnLog
        ' 
        btnLog.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLog.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnLog.FlatAppearance.BorderSize = 0
        btnLog.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnLog.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnLog.Image = My.Resources.Resources.imageLog
        btnLog.ImageAlign = ContentAlignment.TopLeft
        btnLog.Location = New Point(201, 420)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(62, 46)
        btnLog.TabIndex = 0
        btnLog.TabStop = False
        btnLog.Text = "Log"
        btnLog.TextAlign = ContentAlignment.BottomRight
        ' 
        ' cmWSTScreenSaver
        ' 
        cmWSTScreenSaver.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmWSTScreenSaver.Items.AddRange(New ToolStripItem() {cmiScreenSaverActivate, cmiScreenSaverEnabled, toolStripSeparator1, cmiScreenSaverSettings, toolStripSeparator12, cmiScreenSaverClose, cmiScreenSaverCloseAll})
        cmWSTScreenSaver.Name = "contextmenuWorkSpaceTools"
        cmWSTScreenSaver.Size = New Size(217, 126)
        ' 
        ' cmiScreenSaverActivate
        ' 
        cmiScreenSaverActivate.Name = "cmiScreenSaverActivate"
        cmiScreenSaverActivate.Size = New Size(216, 22)
        cmiScreenSaverActivate.Text = "Activate Screen Saver"
        ' 
        ' cmiScreenSaverEnabled
        ' 
        cmiScreenSaverEnabled.Name = "cmiScreenSaverEnabled"
        cmiScreenSaverEnabled.Size = New Size(216, 22)
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(213, 6)
        ' 
        ' cmiScreenSaverSettings
        ' 
        cmiScreenSaverSettings.Image = My.Resources.Resources.imageSettings
        cmiScreenSaverSettings.Name = "cmiScreenSaverSettings"
        cmiScreenSaverSettings.Size = New Size(216, 22)
        cmiScreenSaverSettings.Text = "Settings"
        ' 
        ' toolStripSeparator12
        ' 
        toolStripSeparator12.Name = "toolStripSeparator12"
        toolStripSeparator12.Size = New Size(213, 6)
        ' 
        ' cmiScreenSaverClose
        ' 
        cmiScreenSaverClose.Image = My.Resources.Resources.imageClose
        cmiScreenSaverClose.Name = "cmiScreenSaverClose"
        cmiScreenSaverClose.Size = New Size(216, 22)
        cmiScreenSaverClose.Text = "Close Screen Saver Tool"
        ' 
        ' cmiScreenSaverCloseAll
        ' 
        cmiScreenSaverCloseAll.Image = My.Resources.Resources.imageClose
        cmiScreenSaverCloseAll.Name = "cmiScreenSaverCloseAll"
        cmiScreenSaverCloseAll.Size = New Size(216, 22)
        cmiScreenSaverCloseAll.Text = "Exit YMTools"
        ' 
        ' tableLayoutPanel2
        ' 
        tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        tableLayoutPanel2.ColumnCount = 2
        tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        tableLayoutPanel2.Location = New Point(0, 0)
        tableLayoutPanel2.Name = "tableLayoutPanel2"
        tableLayoutPanel2.RowCount = 4
        tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tableLayoutPanel2.Size = New Size(200, 100)
        tableLayoutPanel2.TabIndex = 0
        ' 
        ' tipHC
        ' 
        tipHC.AutomaticDelay = 250
        tipHC.AutoPopDelay = 10000
        tipHC.InitialDelay = 250
        tipHC.ReshowDelay = 50
        tipHC.UseAnimation = False
        tipHC.UseFading = False
        ' 
        ' MainForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        AutoValidate = AutoValidate.EnableAllowFocusChange
        ClientSize = New Size(638, 477)
        Controls.Add(btnInfo)
        Controls.Add(btnLog)
        Controls.Add(btnSettingsSave)
        Controls.Add(btnSettingsRestore)
        Controls.Add(btnClose)
        Controls.Add(tabcontrolSettings)
        Controls.Add(btnClockTest)
        Controls.Add(btnErrorTest)
        Controls.Add(btnBalloonTest)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = My.Resources.Resources.iconSettings
        Location = New Point(0, 186)
        MaximizeBox = False
        Name = "MainForm"
        Opacity = 0R
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
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
    Private WithEvents textboxHKWSTCommandPrompt As System.Windows.Forms.TextBox
    Private WithEvents lblHKWSTCommandPrompt As System.Windows.Forms.Label
    Private WithEvents btnHKWSTCommandPromptDisable As System.Windows.Forms.Button
    Private WithEvents textboxHKWSTTaskManager As System.Windows.Forms.TextBox
    Private WithEvents lblHKWSTTaskManager As System.Windows.Forms.Label
    Private WithEvents btnHKWSTTaskManagerDisable As System.Windows.Forms.Button
    Private WithEvents btnWSTTaskManager As System.Windows.Forms.Button
    Private WithEvents btnWSTCommandPrompt As System.Windows.Forms.Button
    Private WithEvents txbxWSTTaskManagerArgs As System.Windows.Forms.TextBox
    Private WithEvents txbxWSTCommandPromptArgs As System.Windows.Forms.TextBox
    Private WithEvents lblWSTTaskManagerPath As System.Windows.Forms.Label
    Private WithEvents lblWSTCommandPromptPath As System.Windows.Forms.Label
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
    Private WithEvents cmiWSTCommandPrompt As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmiWSTTaskManager As System.Windows.Forms.ToolStripMenuItem
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
    Private WithEvents checkboxWSTShowTaskManager As System.Windows.Forms.CheckBox
    Private WithEvents checkboxWSTShowCommandPrompt As System.Windows.Forms.CheckBox
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
    Private WithEvents tipHC As System.Windows.Forms.ToolTip
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
    Private WithEvents tipInfo As System.Windows.Forms.ToolTip
    Private label32 As System.Windows.Forms.Label
    Private WithEvents btnBalloonTest As System.Windows.Forms.Button
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
End Class