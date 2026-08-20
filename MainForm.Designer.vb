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
        tabcontrolSettings = New TabControl()
        tabpageWST = New TabPage()
        tabpageAC = New TabPage()
        tabpageWL = New TabPage()
        tabpageHC = New TabPage()
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
        tabpageHK.SuspendLayout()
        cmWSTScreenSaver.SuspendLayout()
        SuspendLayout()
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
        cmiWSTClock.Image = My.Resources.Resources.ImageWSTClock16
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
        tabpageWST.Location = New Point(4, 24)
        tabpageWST.Name = "tabpageWST"
        tabpageWST.Padding = New Padding(3)
        tabpageWST.Size = New Size(618, 375)
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
        ' tabpageWL
        ' 
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
        ' tabpageHC
        ' 
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
        textboxHKWL.Size = New Size(143, 23)
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
        textboxHKWSTClock.Size = New Size(143, 23)
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
        textboxHKWSTLockWorkSpace.Size = New Size(143, 23)
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
        textboxHKWSTScreenSaver.Size = New Size(143, 23)
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
        ClientSize = New Size(638, 477)
        Controls.Add(BtnSettings)
        Controls.Add(btnSettingsSave)
        Controls.Add(btnClose)
        Controls.Add(tabcontrolSettings)
        TipHCEX.SetImage(Me, Nothing)
        TipInfoEX.SetImage(Me, Nothing)
        Location = New Point(0, 186)
        Name = "MainForm"
        Opacity = 0R
        StartPosition = FormStartPosition.Manual
        TipInfoEX.SetText(Me, Nothing)
        TipHCEX.SetText(Me, Nothing)
        cmWST.ResumeLayout(False)
        tabcontrolSettings.ResumeLayout(False)
        tabpageHK.ResumeLayout(False)
        tabpageHK.PerformLayout()
        cmWSTScreenSaver.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents cmiWSTClock As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmseparatorWSTWLBottom As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cmseparatorWSTWLTop As System.Windows.Forms.ToolStripSeparator
    Private cmseparatorWSTTopSpacer As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tabpageWL As System.Windows.Forms.TabPage
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
    Private WithEvents tabpageHC As System.Windows.Forms.TabPage
    Private WithEvents cmWST As System.Windows.Forms.ContextMenuStrip
    Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnHKWLDisable As System.Windows.Forms.Button
    Private WithEvents textboxHKWL As System.Windows.Forms.TextBox
    Private WithEvents lblHKWL As System.Windows.Forms.Label
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
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