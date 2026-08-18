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
        tabpageAC = New TabPage()
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
        cmWST.Size = New Size(240, 470)
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
        ' tabpageAC
        ' 
        TipHCEX.SetImage(tabpageAC, Nothing)
        TipInfoEX.SetImage(tabpageAC, Nothing)
        tabpageAC.Location = New Point(4, 26)
        tabpageAC.Name = "tabpageAC"
        tabpageAC.Padding = New Padding(3)
        tabpageAC.Size = New Size(618, 373)
        tabpageAC.TabIndex = 3
        TipHCEX.SetText(tabpageAC, Nothing)
        TipInfoEX.SetText(tabpageAC, Nothing)
        tabpageAC.Text = "****Alarm + Chime****"
        tabpageAC.UseVisualStyleBackColor = True
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
        radiobtnHCWSTSS.Image = My.Resources.Resources.ImageWSTSS16
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
        btnErrorTest.Image = My.Resources.Resources.ImageError16
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
        btnInfo.Image = My.Resources.Resources.ImageInfo16
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
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnClockTest As System.Windows.Forms.Button
    Private WithEvents cmiWSTClock As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmseparatorWSTWLBottom As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cmseparatorWSTWLTop As System.Windows.Forms.ToolStripSeparator
    Private WithEvents lblWLStartUpDelay As System.Windows.Forms.Label
    Private WithEvents lblWLMaxLinksPerFolder As System.Windows.Forms.Label
    Private WithEvents lblWLAutoRefreshInterval As System.Windows.Forms.Label
    Private WithEvents lblWLAutoRefreshIdleInterval As System.Windows.Forms.Label
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
    Private WithEvents cmWSTScreenSaver As System.Windows.Forms.ContextMenuStrip
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
    Private WithEvents btnErrorTest As System.Windows.Forms.Button
    Private WithEvents btnInfo As System.Windows.Forms.Button
    Private WithEvents btnLog As System.Windows.Forms.Button
    Private label30 As System.Windows.Forms.Label
    Private label29 As System.Windows.Forms.Label
    Private label28 As System.Windows.Forms.Label
    Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
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
    Private WithEvents tabpageAC As System.Windows.Forms.TabPage
    Private WithEvents tabcontrolSettings As System.Windows.Forms.TabControl
    Friend WithEvents TipHCEX As Skye.UI.ToolTipEX
    Friend WithEvents TipInfoEX As Skye.UI.ToolTipEX
    Private WithEvents BtnSettings As Button
End Class