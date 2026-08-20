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
        BtnSSEnabled = New Button()
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
        LblACOffHourChimePath = New Label()
        BtnACOffHourChimeManual = New Button()
        BtnACAlarmCancel = New Button()
        LblACTopHourChimePath = New Label()
        LblACAlarmChimePath = New Label()
        ChkBoxACBottomHourAfterChimeEnabled = New CheckBox()
        ChkBoxACFirstQuarterHourAfterChimeEnabled = New CheckBox()
        ChkBoxACThirdQuarterHourBeforeChimeEnabled = New CheckBox()
        ChkBoxACFirstQuarterHourBeforeChimeEnabled = New CheckBox()
        ChkBoxACThirdQuarterHourAfterChimeEnabled = New CheckBox()
        ChkBoxACBottomHourBeforeChimeEnabled = New CheckBox()
        BtnACMute = New Button()
        TxtBoxACAlarmTimer = New TextBox()
        GrpBoxACTopHourChimeType = New GroupBox()
        RadBtnACTopHourChimeHourTick = New RadioButton()
        RadBtnACTopHourChimeSimple = New RadioButton()
        RadBtnACTopHourChimeExtended = New RadioButton()
        BtnACOffHourChimeDefault = New Button()
        BtnACTopHourChimeDefault = New Button()
        TxtBoxACAlarmTime = New TextBox()
        BtnACTopHourChimeManual = New Button()
        ChkBoxACThirdQuarterHourChimeEnabled = New CheckBox()
        ChkBoxACBottomHourChimeEnabled = New CheckBox()
        ChkBoxACFirstQuarterHourChimeEnabled = New CheckBox()
        ChkBoxACTopHourAfterChimeEnabled = New CheckBox()
        ChkBoxACTopHourChimeEnabled = New CheckBox()
        ChkBoxACTopHourBeforeChimeEnabled = New CheckBox()
        GrpBoxACAlarmChimeType = New GroupBox()
        RadBtnACAlarmChimeSimple = New RadioButton()
        RadBtnACAlarmChimeForever = New RadioButton()
        RadBtnACAlarmChimeExtended = New RadioButton()
        BtnACAlarmSet = New Button()
        ChkBoxACAlarmRecurring = New CheckBox()
        BtnACTopHourChimePlay = New Button()
        BtnACOffHourChimePlay = New Button()
        PicBoxACClock = New PictureBox()
        BtnACAlarmChimeDefault = New Button()
        BtnACAlarmChimePlay = New Button()
        BtnACAlarmChimeManual = New Button()
        LblACTime = New Skye.UI.Label()
        LblACTimer = New Skye.UI.Label()
        LblACAlarmChime = New Skye.UI.Label()
        LblACTopHourChime = New Skye.UI.Label()
        LblACOffHourChime = New Skye.UI.Label()
        PanelWL = New Panel()
        TxtBoxWLMaxLinksPerFolder = New TextBox()
        PanelWLItem = New Panel()
        ChkBoxWLShowNoMenu = New CheckBox()
        TxtBoxWLName = New TextBox()
        ChkBoxWLShowMenuIcons = New CheckBox()
        ChkBoxWLShowInTray = New CheckBox()
        ChkBoxWLShowInMenu = New CheckBox()
        CoBoxWLFolderPlacement = New ComboBox()
        CoBoxWLFolderMode = New ComboBox()
        CoBoxWLSort = New ComboBox()
        TxtBoxWLRoot = New TextBox()
        BtnWLSelectFolder = New Button()
        BtnWLCancel = New Button()
        BtnWLSet = New Button()
        ChkBoxWLUseDefaultIcon = New CheckBox()
        LblWLFolderPlacement = New Skye.UI.Label()
        LblWLFolderMode = New Skye.UI.Label()
        LblWLSortOrder = New Skye.UI.Label()
        LblWLDisplayName = New Skye.UI.Label()
        LblWLRoot = New Skye.UI.Label()
        TxtBoxWLStartUpDelay = New TextBox()
        TxtBoxWLAutoRefreshInterval = New TextBox()
        LVWL = New ListView()
        CMLVWL = New ContextMenuStrip(components)
        CMIWLMoveUp = New ToolStripMenuItem()
        CMIWLMoveDown = New ToolStripMenuItem()
        TSSWL1 = New ToolStripSeparator()
        CMIWLNew = New ToolStripMenuItem()
        TSSWL2 = New ToolStripSeparator()
        CMIWLDelete = New ToolStripMenuItem()
        TxtBoxWLAutoRefreshIdleInterval = New TextBox()
        ChkBoxWLShowFilePathToolTips = New CheckBox()
        ChkBoxWLAutoRefresh = New CheckBox()
        ChkBoxWLShowFileInfoToolTips = New CheckBox()
        ChkBoxWLShowFolderPathToolTips = New CheckBox()
        BtnWLRefresh = New Button()
        LblWLStartUpDelay = New Skye.UI.Label()
        LblWLAutoRefresh = New Skye.UI.Label()
        LblWLAutoRefreshIdleInterval = New Skye.UI.Label()
        LblWLAutoRefreshInterval = New Skye.UI.Label()
        LblWLMaxLinksPerFolder = New Skye.UI.Label()
        PanelHC = New Panel()
        CoBoxHCRight = New ComboBox()
        CoBoxHCMiddle = New ComboBox()
        CoBoxHCDouble = New ComboBox()
        CoBoxHCLeft = New ComboBox()
        GrpBoxHC = New GroupBox()
        RadBtnHCWL = New RadioButton()
        RadBtnHCWSTSS = New RadioButton()
        RadBtnHCWST = New RadioButton()
        LblHCDouble = New Label()
        LblHCLeft = New Label()
        LblHCMiddle = New Label()
        LblHCRight = New Label()
        PanelHK = New Panel()
        PanelApp.SuspendLayout()
        PanelWST.SuspendLayout()
        PanelSS.SuspendLayout()
        PanelActions.SuspendLayout()
        PanelPageSelector.SuspendLayout()
        PanelAC.SuspendLayout()
        GrpBoxACTopHourChimeType.SuspendLayout()
        GrpBoxACAlarmChimeType.SuspendLayout()
        CType(PicBoxACClock, ComponentModel.ISupportInitialize).BeginInit()
        PanelWL.SuspendLayout()
        PanelWLItem.SuspendLayout()
        CMLVWL.SuspendLayout()
        PanelHC.SuspendLayout()
        GrpBoxHC.SuspendLayout()
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
        TipInfoEX.SetImage(BtnSSEnabled, Nothing)
        BtnSSEnabled.Location = New Point(21, 20)
        BtnSSEnabled.Name = "BtnSSEnabled"
        BtnSSEnabled.Size = New Size(128, 128)
        BtnSSEnabled.TabIndex = 141
        TipInfoEX.SetText(BtnSSEnabled, "Screen Saver")
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
        PanelAC.Controls.Add(LblACOffHourChimePath)
        PanelAC.Controls.Add(BtnACOffHourChimeManual)
        PanelAC.Controls.Add(BtnACAlarmCancel)
        PanelAC.Controls.Add(LblACTopHourChimePath)
        PanelAC.Controls.Add(LblACAlarmChimePath)
        PanelAC.Controls.Add(ChkBoxACBottomHourAfterChimeEnabled)
        PanelAC.Controls.Add(ChkBoxACFirstQuarterHourAfterChimeEnabled)
        PanelAC.Controls.Add(ChkBoxACThirdQuarterHourBeforeChimeEnabled)
        PanelAC.Controls.Add(ChkBoxACFirstQuarterHourBeforeChimeEnabled)
        PanelAC.Controls.Add(ChkBoxACThirdQuarterHourAfterChimeEnabled)
        PanelAC.Controls.Add(ChkBoxACBottomHourBeforeChimeEnabled)
        PanelAC.Controls.Add(BtnACMute)
        PanelAC.Controls.Add(TxtBoxACAlarmTimer)
        PanelAC.Controls.Add(GrpBoxACTopHourChimeType)
        PanelAC.Controls.Add(BtnACOffHourChimeDefault)
        PanelAC.Controls.Add(BtnACTopHourChimeDefault)
        PanelAC.Controls.Add(TxtBoxACAlarmTime)
        PanelAC.Controls.Add(BtnACTopHourChimeManual)
        PanelAC.Controls.Add(ChkBoxACThirdQuarterHourChimeEnabled)
        PanelAC.Controls.Add(ChkBoxACBottomHourChimeEnabled)
        PanelAC.Controls.Add(ChkBoxACFirstQuarterHourChimeEnabled)
        PanelAC.Controls.Add(ChkBoxACTopHourAfterChimeEnabled)
        PanelAC.Controls.Add(ChkBoxACTopHourChimeEnabled)
        PanelAC.Controls.Add(ChkBoxACTopHourBeforeChimeEnabled)
        PanelAC.Controls.Add(GrpBoxACAlarmChimeType)
        PanelAC.Controls.Add(BtnACAlarmSet)
        PanelAC.Controls.Add(ChkBoxACAlarmRecurring)
        PanelAC.Controls.Add(BtnACTopHourChimePlay)
        PanelAC.Controls.Add(BtnACOffHourChimePlay)
        PanelAC.Controls.Add(PicBoxACClock)
        PanelAC.Controls.Add(BtnACAlarmChimeDefault)
        PanelAC.Controls.Add(BtnACAlarmChimePlay)
        PanelAC.Controls.Add(BtnACAlarmChimeManual)
        PanelAC.Controls.Add(LblACTime)
        PanelAC.Controls.Add(LblACTimer)
        PanelAC.Controls.Add(LblACAlarmChime)
        PanelAC.Controls.Add(LblACTopHourChime)
        PanelAC.Controls.Add(LblACOffHourChime)
        PanelAC.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelAC, Nothing)
        PanelAC.Location = New Point(187, 0)
        PanelAC.Name = "PanelAC"
        PanelAC.Size = New Size(730, 534)
        PanelAC.TabIndex = 108
        TipInfoEX.SetText(PanelAC, Nothing)
        ' 
        ' LblACOffHourChimePath
        ' 
        LblACOffHourChimePath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LblACOffHourChimePath.AutoEllipsis = True
        LblACOffHourChimePath.BorderStyle = BorderStyle.FixedSingle
        TipInfoEX.SetImage(LblACOffHourChimePath, Nothing)
        LblACOffHourChimePath.Location = New Point(555, 499)
        LblACOffHourChimePath.Name = "LblACOffHourChimePath"
        LblACOffHourChimePath.Size = New Size(163, 24)
        LblACOffHourChimePath.TabIndex = 72
        TipInfoEX.SetText(LblACOffHourChimePath, "Path")
        LblACOffHourChimePath.TextAlign = ContentAlignment.TopRight
        LblACOffHourChimePath.UseMnemonic = False
        ' 
        ' BtnACOffHourChimeManual
        ' 
        BtnACOffHourChimeManual.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnACOffHourChimeManual.FlatAppearance.BorderSize = 0
        BtnACOffHourChimeManual.Image = My.Resources.Resources.imageACFolder
        TipInfoEX.SetImage(BtnACOffHourChimeManual, Nothing)
        BtnACOffHourChimeManual.Location = New Point(687, 467)
        BtnACOffHourChimeManual.Name = "BtnACOffHourChimeManual"
        BtnACOffHourChimeManual.Size = New Size(32, 32)
        BtnACOffHourChimeManual.TabIndex = 204
        TipInfoEX.SetText(BtnACOffHourChimeManual, "Select WAV File")
        BtnACOffHourChimeManual.TextAlign = ContentAlignment.MiddleLeft
        BtnACOffHourChimeManual.UseVisualStyleBackColor = True
        ' 
        ' BtnACAlarmCancel
        ' 
        BtnACAlarmCancel.FlatAppearance.BorderColor = SystemColors.ControlDark
        BtnACAlarmCancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnACAlarmCancel.ForeColor = Color.Maroon
        TipInfoEX.SetImage(BtnACAlarmCancel, Nothing)
        BtnACAlarmCancel.Location = New Point(101, 69)
        BtnACAlarmCancel.Name = "BtnACAlarmCancel"
        BtnACAlarmCancel.Size = New Size(72, 64)
        BtnACAlarmCancel.TabIndex = 17
        TipInfoEX.SetText(BtnACAlarmCancel, "Cancel Alarm")
        BtnACAlarmCancel.Text = " CANCEL  ALARM"
        BtnACAlarmCancel.UseVisualStyleBackColor = True
        BtnACAlarmCancel.Visible = False
        ' 
        ' LblACTopHourChimePath
        ' 
        LblACTopHourChimePath.AutoEllipsis = True
        LblACTopHourChimePath.BorderStyle = BorderStyle.FixedSingle
        TipInfoEX.SetImage(LblACTopHourChimePath, Nothing)
        LblACTopHourChimePath.Location = New Point(12, 430)
        LblACTopHourChimePath.Name = "LblACTopHourChimePath"
        LblACTopHourChimePath.Size = New Size(164, 24)
        LblACTopHourChimePath.TabIndex = 56
        TipInfoEX.SetText(LblACTopHourChimePath, "Path")
        LblACTopHourChimePath.UseMnemonic = False
        ' 
        ' LblACAlarmChimePath
        ' 
        LblACAlarmChimePath.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LblACAlarmChimePath.AutoEllipsis = True
        LblACAlarmChimePath.BorderStyle = BorderStyle.FixedSingle
        TipInfoEX.SetImage(LblACAlarmChimePath, Nothing)
        LblACAlarmChimePath.Location = New Point(552, 65)
        LblACAlarmChimePath.Name = "LblACAlarmChimePath"
        LblACAlarmChimePath.Size = New Size(165, 24)
        LblACAlarmChimePath.TabIndex = 46
        TipInfoEX.SetText(LblACAlarmChimePath, "Path")
        LblACAlarmChimePath.TextAlign = ContentAlignment.TopRight
        LblACAlarmChimePath.UseMnemonic = False
        ' 
        ' ChkBoxACBottomHourAfterChimeEnabled
        ' 
        ChkBoxACBottomHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACBottomHourAfterChimeEnabled.BackgroundImageLayout = ImageLayout.None
        ChkBoxACBottomHourAfterChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(ChkBoxACBottomHourAfterChimeEnabled, Nothing)
        ChkBoxACBottomHourAfterChimeEnabled.Location = New Point(305, 412)
        ChkBoxACBottomHourAfterChimeEnabled.Name = "ChkBoxACBottomHourAfterChimeEnabled"
        ChkBoxACBottomHourAfterChimeEnabled.Size = New Size(13, 13)
        ChkBoxACBottomHourAfterChimeEnabled.TabIndex = 58
        ChkBoxACBottomHourAfterChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACBottomHourAfterChimeEnabled, Nothing)
        ChkBoxACBottomHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACFirstQuarterHourAfterChimeEnabled
        ' 
        ChkBoxACFirstQuarterHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACFirstQuarterHourAfterChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(ChkBoxACFirstQuarterHourAfterChimeEnabled, Nothing)
        ChkBoxACFirstQuarterHourAfterChimeEnabled.Location = New Point(445, 379)
        ChkBoxACFirstQuarterHourAfterChimeEnabled.Name = "ChkBoxACFirstQuarterHourAfterChimeEnabled"
        ChkBoxACFirstQuarterHourAfterChimeEnabled.Size = New Size(13, 13)
        ChkBoxACFirstQuarterHourAfterChimeEnabled.TabIndex = 61
        ChkBoxACFirstQuarterHourAfterChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACFirstQuarterHourAfterChimeEnabled, Nothing)
        ChkBoxACFirstQuarterHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACThirdQuarterHourBeforeChimeEnabled
        ' 
        ChkBoxACThirdQuarterHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACThirdQuarterHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(ChkBoxACThirdQuarterHourBeforeChimeEnabled, Nothing)
        ChkBoxACThirdQuarterHourBeforeChimeEnabled.Location = New Point(273, 378)
        ChkBoxACThirdQuarterHourBeforeChimeEnabled.Name = "ChkBoxACThirdQuarterHourBeforeChimeEnabled"
        ChkBoxACThirdQuarterHourBeforeChimeEnabled.Size = New Size(13, 13)
        ChkBoxACThirdQuarterHourBeforeChimeEnabled.TabIndex = 60
        ChkBoxACThirdQuarterHourBeforeChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACThirdQuarterHourBeforeChimeEnabled, Nothing)
        ChkBoxACThirdQuarterHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACFirstQuarterHourBeforeChimeEnabled
        ' 
        ChkBoxACFirstQuarterHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACFirstQuarterHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(ChkBoxACFirstQuarterHourBeforeChimeEnabled, Nothing)
        ChkBoxACFirstQuarterHourBeforeChimeEnabled.Location = New Point(444, 276)
        ChkBoxACFirstQuarterHourBeforeChimeEnabled.Name = "ChkBoxACFirstQuarterHourBeforeChimeEnabled"
        ChkBoxACFirstQuarterHourBeforeChimeEnabled.Size = New Size(13, 13)
        ChkBoxACFirstQuarterHourBeforeChimeEnabled.TabIndex = 65
        ChkBoxACFirstQuarterHourBeforeChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACFirstQuarterHourBeforeChimeEnabled, Nothing)
        ChkBoxACFirstQuarterHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACThirdQuarterHourAfterChimeEnabled
        ' 
        ChkBoxACThirdQuarterHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACThirdQuarterHourAfterChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(ChkBoxACThirdQuarterHourAfterChimeEnabled, Nothing)
        ChkBoxACThirdQuarterHourAfterChimeEnabled.Location = New Point(273, 274)
        ChkBoxACThirdQuarterHourAfterChimeEnabled.Name = "ChkBoxACThirdQuarterHourAfterChimeEnabled"
        ChkBoxACThirdQuarterHourAfterChimeEnabled.Size = New Size(13, 13)
        ChkBoxACThirdQuarterHourAfterChimeEnabled.TabIndex = 66
        ChkBoxACThirdQuarterHourAfterChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACThirdQuarterHourAfterChimeEnabled, Nothing)
        ChkBoxACThirdQuarterHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACBottomHourBeforeChimeEnabled
        ' 
        ChkBoxACBottomHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACBottomHourBeforeChimeEnabled.CheckAlign = ContentAlignment.MiddleCenter
        TipInfoEX.SetImage(ChkBoxACBottomHourBeforeChimeEnabled, Nothing)
        ChkBoxACBottomHourBeforeChimeEnabled.Location = New Point(410, 415)
        ChkBoxACBottomHourBeforeChimeEnabled.Name = "ChkBoxACBottomHourBeforeChimeEnabled"
        ChkBoxACBottomHourBeforeChimeEnabled.Size = New Size(13, 13)
        ChkBoxACBottomHourBeforeChimeEnabled.TabIndex = 57
        ChkBoxACBottomHourBeforeChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACBottomHourBeforeChimeEnabled, Nothing)
        ChkBoxACBottomHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' BtnACMute
        ' 
        BtnACMute.Anchor = AnchorStyles.Top
        BtnACMute.FlatAppearance.BorderSize = 0
        TipInfoEX.SetImage(BtnACMute, Nothing)
        BtnACMute.Location = New Point(301, 12)
        BtnACMute.Name = "BtnACMute"
        BtnACMute.Size = New Size(128, 128)
        BtnACMute.TabIndex = 50
        TipInfoEX.SetText(BtnACMute, "Mute All Chimes")
        BtnACMute.TextAlign = ContentAlignment.MiddleLeft
        BtnACMute.UseVisualStyleBackColor = True
        ' 
        ' TxtBoxACAlarmTimer
        ' 
        TipInfoEX.SetImage(TxtBoxACAlarmTimer, Nothing)
        TxtBoxACAlarmTimer.Location = New Point(13, 139)
        TxtBoxACAlarmTimer.MaxLength = 3
        TxtBoxACAlarmTimer.Name = "TxtBoxACAlarmTimer"
        TxtBoxACAlarmTimer.Size = New Size(89, 29)
        TxtBoxACAlarmTimer.TabIndex = 20
        TipInfoEX.SetText(TxtBoxACAlarmTimer, "Enter Timer Value In Minutes")
        TxtBoxACAlarmTimer.TextAlign = HorizontalAlignment.Center
        ' 
        ' GrpBoxACTopHourChimeType
        ' 
        GrpBoxACTopHourChimeType.Controls.Add(RadBtnACTopHourChimeHourTick)
        GrpBoxACTopHourChimeType.Controls.Add(RadBtnACTopHourChimeSimple)
        GrpBoxACTopHourChimeType.Controls.Add(RadBtnACTopHourChimeExtended)
        TipInfoEX.SetImage(GrpBoxACTopHourChimeType, Nothing)
        GrpBoxACTopHourChimeType.Location = New Point(12, 444)
        GrpBoxACTopHourChimeType.Name = "GrpBoxACTopHourChimeType"
        GrpBoxACTopHourChimeType.Size = New Size(110, 80)
        GrpBoxACTopHourChimeType.TabIndex = 160
        GrpBoxACTopHourChimeType.TabStop = False
        TipInfoEX.SetText(GrpBoxACTopHourChimeType, Nothing)
        ' 
        ' RadBtnACTopHourChimeHourTick
        ' 
        RadBtnACTopHourChimeHourTick.AutoSize = True
        TipInfoEX.SetImage(RadBtnACTopHourChimeHourTick, Nothing)
        RadBtnACTopHourChimeHourTick.Location = New Point(11, 53)
        RadBtnACTopHourChimeHourTick.Name = "RadBtnACTopHourChimeHourTick"
        RadBtnACTopHourChimeHourTick.Size = New Size(94, 25)
        RadBtnACTopHourChimeHourTick.TabIndex = 3
        RadBtnACTopHourChimeHourTick.TabStop = True
        TipInfoEX.SetText(RadBtnACTopHourChimeHourTick, "Chime Based On Hour")
        RadBtnACTopHourChimeHourTick.Text = "Hour Tick"
        RadBtnACTopHourChimeHourTick.UseVisualStyleBackColor = True
        ' 
        ' RadBtnACTopHourChimeSimple
        ' 
        RadBtnACTopHourChimeSimple.AutoSize = True
        TipInfoEX.SetImage(RadBtnACTopHourChimeSimple, Nothing)
        RadBtnACTopHourChimeSimple.Location = New Point(11, 15)
        RadBtnACTopHourChimeSimple.Name = "RadBtnACTopHourChimeSimple"
        RadBtnACTopHourChimeSimple.Size = New Size(76, 25)
        RadBtnACTopHourChimeSimple.TabIndex = 1
        RadBtnACTopHourChimeSimple.TabStop = True
        TipInfoEX.SetText(RadBtnACTopHourChimeSimple, "Chime Once")
        RadBtnACTopHourChimeSimple.Text = "Simple"
        RadBtnACTopHourChimeSimple.UseVisualStyleBackColor = True
        ' 
        ' RadBtnACTopHourChimeExtended
        ' 
        RadBtnACTopHourChimeExtended.AutoSize = True
        TipInfoEX.SetImage(RadBtnACTopHourChimeExtended, Nothing)
        RadBtnACTopHourChimeExtended.Location = New Point(11, 34)
        RadBtnACTopHourChimeExtended.Name = "RadBtnACTopHourChimeExtended"
        RadBtnACTopHourChimeExtended.Size = New Size(91, 25)
        RadBtnACTopHourChimeExtended.TabIndex = 2
        RadBtnACTopHourChimeExtended.TabStop = True
        TipInfoEX.SetText(RadBtnACTopHourChimeExtended, "Chime Several Times")
        RadBtnACTopHourChimeExtended.Text = "Extended"
        RadBtnACTopHourChimeExtended.UseVisualStyleBackColor = True
        ' 
        ' BtnACOffHourChimeDefault
        ' 
        BtnACOffHourChimeDefault.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnACOffHourChimeDefault.FlatAppearance.BorderSize = 0
        BtnACOffHourChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        TipInfoEX.SetImage(BtnACOffHourChimeDefault, Nothing)
        BtnACOffHourChimeDefault.Location = New Point(656, 467)
        BtnACOffHourChimeDefault.Name = "BtnACOffHourChimeDefault"
        BtnACOffHourChimeDefault.Size = New Size(32, 32)
        BtnACOffHourChimeDefault.TabIndex = 202
        TipInfoEX.SetText(BtnACOffHourChimeDefault, "Use Default Chime")
        BtnACOffHourChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        BtnACOffHourChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' BtnACTopHourChimeDefault
        ' 
        BtnACTopHourChimeDefault.FlatAppearance.BorderSize = 0
        BtnACTopHourChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        TipInfoEX.SetImage(BtnACTopHourChimeDefault, Nothing)
        BtnACTopHourChimeDefault.Location = New Point(42, 398)
        BtnACTopHourChimeDefault.Name = "BtnACTopHourChimeDefault"
        BtnACTopHourChimeDefault.Size = New Size(32, 32)
        BtnACTopHourChimeDefault.TabIndex = 152
        TipInfoEX.SetText(BtnACTopHourChimeDefault, "Use Default Chime")
        BtnACTopHourChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        BtnACTopHourChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' TxtBoxACAlarmTime
        ' 
        TipInfoEX.SetImage(TxtBoxACAlarmTime, Nothing)
        TxtBoxACAlarmTime.Location = New Point(13, 35)
        TxtBoxACAlarmTime.MaxLength = 5
        TxtBoxACAlarmTime.Name = "TxtBoxACAlarmTime"
        TxtBoxACAlarmTime.Size = New Size(89, 29)
        TxtBoxACAlarmTime.TabIndex = 10
        TipInfoEX.SetText(TxtBoxACAlarmTime, "Enter Alarm Time (24-Hour Format)")
        TxtBoxACAlarmTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnACTopHourChimeManual
        ' 
        BtnACTopHourChimeManual.FlatAppearance.BorderSize = 0
        BtnACTopHourChimeManual.Image = My.Resources.Resources.imageACFolder
        TipInfoEX.SetImage(BtnACTopHourChimeManual, Nothing)
        BtnACTopHourChimeManual.Location = New Point(11, 398)
        BtnACTopHourChimeManual.Name = "BtnACTopHourChimeManual"
        BtnACTopHourChimeManual.Size = New Size(32, 32)
        BtnACTopHourChimeManual.TabIndex = 150
        TipInfoEX.SetText(BtnACTopHourChimeManual, "Select WAV File")
        BtnACTopHourChimeManual.TextAlign = ContentAlignment.MiddleLeft
        BtnACTopHourChimeManual.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACThirdQuarterHourChimeEnabled
        ' 
        ChkBoxACThirdQuarterHourChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACThirdQuarterHourChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(ChkBoxACThirdQuarterHourChimeEnabled, Nothing)
        ChkBoxACThirdQuarterHourChimeEnabled.Location = New Point(259, 324)
        ChkBoxACThirdQuarterHourChimeEnabled.Name = "ChkBoxACThirdQuarterHourChimeEnabled"
        ChkBoxACThirdQuarterHourChimeEnabled.Size = New Size(15, 15)
        ChkBoxACThirdQuarterHourChimeEnabled.TabIndex = 64
        ChkBoxACThirdQuarterHourChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACThirdQuarterHourChimeEnabled, Nothing)
        ChkBoxACThirdQuarterHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACBottomHourChimeEnabled
        ' 
        ChkBoxACBottomHourChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACBottomHourChimeEnabled.CheckAlign = ContentAlignment.MiddleRight
        TipInfoEX.SetImage(ChkBoxACBottomHourChimeEnabled, Nothing)
        ChkBoxACBottomHourChimeEnabled.Location = New Point(358, 426)
        ChkBoxACBottomHourChimeEnabled.Name = "ChkBoxACBottomHourChimeEnabled"
        ChkBoxACBottomHourChimeEnabled.Size = New Size(15, 15)
        ChkBoxACBottomHourChimeEnabled.TabIndex = 63
        ChkBoxACBottomHourChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACBottomHourChimeEnabled, Nothing)
        ChkBoxACBottomHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACFirstQuarterHourChimeEnabled
        ' 
        ChkBoxACFirstQuarterHourChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACFirstQuarterHourChimeEnabled.CheckAlign = ContentAlignment.TopLeft
        TipInfoEX.SetImage(ChkBoxACFirstQuarterHourChimeEnabled, Nothing)
        ChkBoxACFirstQuarterHourChimeEnabled.Location = New Point(457, 325)
        ChkBoxACFirstQuarterHourChimeEnabled.Name = "ChkBoxACFirstQuarterHourChimeEnabled"
        ChkBoxACFirstQuarterHourChimeEnabled.Size = New Size(15, 15)
        ChkBoxACFirstQuarterHourChimeEnabled.TabIndex = 62
        ChkBoxACFirstQuarterHourChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACFirstQuarterHourChimeEnabled, Nothing)
        ChkBoxACFirstQuarterHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACTopHourAfterChimeEnabled
        ' 
        ChkBoxACTopHourAfterChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACTopHourAfterChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(ChkBoxACTopHourAfterChimeEnabled, Nothing)
        ChkBoxACTopHourAfterChimeEnabled.Location = New Point(409, 240)
        ChkBoxACTopHourAfterChimeEnabled.Name = "ChkBoxACTopHourAfterChimeEnabled"
        ChkBoxACTopHourAfterChimeEnabled.Size = New Size(15, 15)
        ChkBoxACTopHourAfterChimeEnabled.TabIndex = 67
        ChkBoxACTopHourAfterChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACTopHourAfterChimeEnabled, Nothing)
        ChkBoxACTopHourAfterChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACTopHourChimeEnabled
        ' 
        ChkBoxACTopHourChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACTopHourChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(ChkBoxACTopHourChimeEnabled, Nothing)
        ChkBoxACTopHourChimeEnabled.Location = New Point(358, 227)
        ChkBoxACTopHourChimeEnabled.Name = "ChkBoxACTopHourChimeEnabled"
        ChkBoxACTopHourChimeEnabled.Size = New Size(15, 15)
        ChkBoxACTopHourChimeEnabled.TabIndex = 0
        ChkBoxACTopHourChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACTopHourChimeEnabled, Nothing)
        ChkBoxACTopHourChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACTopHourBeforeChimeEnabled
        ' 
        ChkBoxACTopHourBeforeChimeEnabled.Anchor = AnchorStyles.Top
        ChkBoxACTopHourBeforeChimeEnabled.CheckAlign = ContentAlignment.TopRight
        TipInfoEX.SetImage(ChkBoxACTopHourBeforeChimeEnabled, Nothing)
        ChkBoxACTopHourBeforeChimeEnabled.Location = New Point(306, 239)
        ChkBoxACTopHourBeforeChimeEnabled.Name = "ChkBoxACTopHourBeforeChimeEnabled"
        ChkBoxACTopHourBeforeChimeEnabled.Size = New Size(15, 15)
        ChkBoxACTopHourBeforeChimeEnabled.TabIndex = 59
        ChkBoxACTopHourBeforeChimeEnabled.TabStop = False
        TipInfoEX.SetText(ChkBoxACTopHourBeforeChimeEnabled, Nothing)
        ChkBoxACTopHourBeforeChimeEnabled.UseVisualStyleBackColor = True
        ' 
        ' GrpBoxACAlarmChimeType
        ' 
        GrpBoxACAlarmChimeType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GrpBoxACAlarmChimeType.BackColor = Color.Transparent
        GrpBoxACAlarmChimeType.Controls.Add(RadBtnACAlarmChimeSimple)
        GrpBoxACAlarmChimeType.Controls.Add(RadBtnACAlarmChimeForever)
        GrpBoxACAlarmChimeType.Controls.Add(RadBtnACAlarmChimeExtended)
        TipInfoEX.SetImage(GrpBoxACAlarmChimeType, Nothing)
        GrpBoxACAlarmChimeType.Location = New Point(607, 80)
        GrpBoxACAlarmChimeType.Name = "GrpBoxACAlarmChimeType"
        GrpBoxACAlarmChimeType.Size = New Size(110, 80)
        GrpBoxACAlarmChimeType.TabIndex = 120
        GrpBoxACAlarmChimeType.TabStop = False
        TipInfoEX.SetText(GrpBoxACAlarmChimeType, Nothing)
        ' 
        ' RadBtnACAlarmChimeSimple
        ' 
        RadBtnACAlarmChimeSimple.AutoSize = True
        TipInfoEX.SetImage(RadBtnACAlarmChimeSimple, Nothing)
        RadBtnACAlarmChimeSimple.Location = New Point(13, 13)
        RadBtnACAlarmChimeSimple.Name = "RadBtnACAlarmChimeSimple"
        RadBtnACAlarmChimeSimple.Size = New Size(76, 25)
        RadBtnACAlarmChimeSimple.TabIndex = 1
        RadBtnACAlarmChimeSimple.TabStop = True
        TipInfoEX.SetText(RadBtnACAlarmChimeSimple, "Chime Once")
        RadBtnACAlarmChimeSimple.Text = "Simple"
        RadBtnACAlarmChimeSimple.UseVisualStyleBackColor = True
        ' 
        ' RadBtnACAlarmChimeForever
        ' 
        RadBtnACAlarmChimeForever.AutoSize = True
        TipInfoEX.SetImage(RadBtnACAlarmChimeForever, Nothing)
        RadBtnACAlarmChimeForever.Location = New Point(13, 51)
        RadBtnACAlarmChimeForever.Name = "RadBtnACAlarmChimeForever"
        RadBtnACAlarmChimeForever.Size = New Size(81, 25)
        RadBtnACAlarmChimeForever.TabIndex = 3
        RadBtnACAlarmChimeForever.TabStop = True
        TipInfoEX.SetText(RadBtnACAlarmChimeForever, "Chime Until Cancelled")
        RadBtnACAlarmChimeForever.Text = "Forever"
        RadBtnACAlarmChimeForever.UseVisualStyleBackColor = True
        ' 
        ' RadBtnACAlarmChimeExtended
        ' 
        RadBtnACAlarmChimeExtended.AutoSize = True
        TipInfoEX.SetImage(RadBtnACAlarmChimeExtended, Nothing)
        RadBtnACAlarmChimeExtended.Location = New Point(13, 32)
        RadBtnACAlarmChimeExtended.Name = "RadBtnACAlarmChimeExtended"
        RadBtnACAlarmChimeExtended.Size = New Size(91, 25)
        RadBtnACAlarmChimeExtended.TabIndex = 2
        RadBtnACAlarmChimeExtended.TabStop = True
        TipInfoEX.SetText(RadBtnACAlarmChimeExtended, "Chime Several Times")
        RadBtnACAlarmChimeExtended.Text = "Extended"
        RadBtnACAlarmChimeExtended.UseVisualStyleBackColor = True
        ' 
        ' BtnACAlarmSet
        ' 
        BtnACAlarmSet.FlatAppearance.BorderColor = SystemColors.ControlDark
        TipInfoEX.SetImage(BtnACAlarmSet, Nothing)
        BtnACAlarmSet.Location = New Point(12, 69)
        BtnACAlarmSet.Name = "BtnACAlarmSet"
        BtnACAlarmSet.Size = New Size(90, 64)
        BtnACAlarmSet.TabIndex = 15
        TipInfoEX.SetText(BtnACAlarmSet, "Activate / DeActivate Alarm")
        BtnACAlarmSet.Text = "Alarm InActive"
        BtnACAlarmSet.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxACAlarmRecurring
        ' 
        ChkBoxACAlarmRecurring.AutoSize = True
        TipInfoEX.SetImage(ChkBoxACAlarmRecurring, Nothing)
        ChkBoxACAlarmRecurring.Location = New Point(110, 39)
        ChkBoxACAlarmRecurring.Name = "ChkBoxACAlarmRecurring"
        ChkBoxACAlarmRecurring.Size = New Size(97, 25)
        ChkBoxACAlarmRecurring.TabIndex = 12
        TipInfoEX.SetText(ChkBoxACAlarmRecurring, "Alarm Repeats Every Day")
        ChkBoxACAlarmRecurring.Text = "Recurring"
        ChkBoxACAlarmRecurring.UseVisualStyleBackColor = True
        ' 
        ' BtnACTopHourChimePlay
        ' 
        BtnACTopHourChimePlay.FlatAppearance.BorderSize = 0
        BtnACTopHourChimePlay.Image = My.Resources.Resources.imageACPlay
        TipInfoEX.SetImage(BtnACTopHourChimePlay, Nothing)
        BtnACTopHourChimePlay.Location = New Point(73, 398)
        BtnACTopHourChimePlay.Name = "BtnACTopHourChimePlay"
        BtnACTopHourChimePlay.Size = New Size(32, 32)
        BtnACTopHourChimePlay.TabIndex = 154
        TipInfoEX.SetText(BtnACTopHourChimePlay, "Play Sound")
        BtnACTopHourChimePlay.TextAlign = ContentAlignment.MiddleLeft
        BtnACTopHourChimePlay.UseVisualStyleBackColor = True
        ' 
        ' BtnACOffHourChimePlay
        ' 
        BtnACOffHourChimePlay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnACOffHourChimePlay.FlatAppearance.BorderSize = 0
        BtnACOffHourChimePlay.Image = My.Resources.Resources.imageACPlay
        TipInfoEX.SetImage(BtnACOffHourChimePlay, Nothing)
        BtnACOffHourChimePlay.Location = New Point(625, 467)
        BtnACOffHourChimePlay.Name = "BtnACOffHourChimePlay"
        BtnACOffHourChimePlay.Size = New Size(32, 32)
        BtnACOffHourChimePlay.TabIndex = 200
        TipInfoEX.SetText(BtnACOffHourChimePlay, "Play Sound")
        BtnACOffHourChimePlay.TextAlign = ContentAlignment.MiddleLeft
        BtnACOffHourChimePlay.UseVisualStyleBackColor = True
        ' 
        ' PicBoxACClock
        ' 
        PicBoxACClock.Anchor = AnchorStyles.Top
        PicBoxACClock.Image = My.Resources.Resources.imageACClock
        TipInfoEX.SetImage(PicBoxACClock, Nothing)
        PicBoxACClock.Location = New Point(268, 237)
        PicBoxACClock.Name = "PicBoxACClock"
        PicBoxACClock.Size = New Size(192, 192)
        PicBoxACClock.SizeMode = PictureBoxSizeMode.Zoom
        PicBoxACClock.TabIndex = 37
        PicBoxACClock.TabStop = False
        TipInfoEX.SetText(PicBoxACClock, "Select When To Sound Chime Each Hour")
        ' 
        ' BtnACAlarmChimeDefault
        ' 
        BtnACAlarmChimeDefault.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnACAlarmChimeDefault.FlatAppearance.BorderSize = 0
        BtnACAlarmChimeDefault.Image = My.Resources.Resources.imageACDefaultChime
        TipInfoEX.SetImage(BtnACAlarmChimeDefault, Nothing)
        BtnACAlarmChimeDefault.Location = New Point(655, 33)
        BtnACAlarmChimeDefault.Name = "BtnACAlarmChimeDefault"
        BtnACAlarmChimeDefault.Size = New Size(32, 32)
        BtnACAlarmChimeDefault.TabIndex = 105
        TipInfoEX.SetText(BtnACAlarmChimeDefault, "Use Default Chime")
        BtnACAlarmChimeDefault.TextAlign = ContentAlignment.MiddleLeft
        BtnACAlarmChimeDefault.UseVisualStyleBackColor = True
        ' 
        ' BtnACAlarmChimePlay
        ' 
        BtnACAlarmChimePlay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnACAlarmChimePlay.FlatAppearance.BorderSize = 0
        BtnACAlarmChimePlay.Image = My.Resources.Resources.imageACPlay
        TipInfoEX.SetImage(BtnACAlarmChimePlay, Nothing)
        BtnACAlarmChimePlay.Location = New Point(624, 33)
        BtnACAlarmChimePlay.Name = "BtnACAlarmChimePlay"
        BtnACAlarmChimePlay.Size = New Size(32, 32)
        BtnACAlarmChimePlay.TabIndex = 100
        TipInfoEX.SetText(BtnACAlarmChimePlay, "Play Sound")
        BtnACAlarmChimePlay.TextAlign = ContentAlignment.MiddleLeft
        BtnACAlarmChimePlay.UseVisualStyleBackColor = True
        ' 
        ' BtnACAlarmChimeManual
        ' 
        BtnACAlarmChimeManual.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnACAlarmChimeManual.FlatAppearance.BorderSize = 0
        BtnACAlarmChimeManual.Image = My.Resources.Resources.imageACFolder
        TipInfoEX.SetImage(BtnACAlarmChimeManual, Nothing)
        BtnACAlarmChimeManual.Location = New Point(686, 33)
        BtnACAlarmChimeManual.Name = "BtnACAlarmChimeManual"
        BtnACAlarmChimeManual.Size = New Size(32, 32)
        BtnACAlarmChimeManual.TabIndex = 110
        TipInfoEX.SetText(BtnACAlarmChimeManual, "Select WAV File")
        BtnACAlarmChimeManual.TextAlign = ContentAlignment.MiddleLeft
        BtnACAlarmChimeManual.UseVisualStyleBackColor = True
        ' 
        ' LblACTime
        ' 
        TipInfoEX.SetImage(LblACTime, Nothing)
        LblACTime.Location = New Point(13, 15)
        LblACTime.Name = "LblACTime"
        LblACTime.Size = New Size(89, 23)
        LblACTime.TabIndex = 205
        LblACTime.Text = "Time"
        TipInfoEX.SetText(LblACTime, Nothing)
        LblACTime.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' LblACTimer
        ' 
        TipInfoEX.SetImage(LblACTimer, Nothing)
        LblACTimer.Location = New Point(13, 164)
        LblACTimer.Name = "LblACTimer"
        LblACTimer.Size = New Size(89, 23)
        LblACTimer.TabIndex = 206
        LblACTimer.Text = "Timer"
        TipInfoEX.SetText(LblACTimer, Nothing)
        LblACTimer.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LblACAlarmChime
        ' 
        TipInfoEX.SetImage(LblACAlarmChime, Nothing)
        LblACAlarmChime.Location = New Point(619, 13)
        LblACAlarmChime.Name = "LblACAlarmChime"
        LblACAlarmChime.Size = New Size(100, 23)
        LblACAlarmChime.TabIndex = 207
        LblACAlarmChime.Text = "Alarm"
        TipInfoEX.SetText(LblACAlarmChime, Nothing)
        LblACAlarmChime.TextAlign = ContentAlignment.BottomRight
        ' 
        ' LblACTopHourChime
        ' 
        TipInfoEX.SetImage(LblACTopHourChime, Nothing)
        LblACTopHourChime.Location = New Point(11, 376)
        LblACTopHourChime.Name = "LblACTopHourChime"
        LblACTopHourChime.Size = New Size(161, 23)
        LblACTopHourChime.TabIndex = 208
        LblACTopHourChime.Text = "Top-Hour Chime"
        TipInfoEX.SetText(LblACTopHourChime, Nothing)
        LblACTopHourChime.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' LblACOffHourChime
        ' 
        TipInfoEX.SetImage(LblACOffHourChime, Nothing)
        LblACOffHourChime.Location = New Point(558, 447)
        LblACOffHourChime.Name = "LblACOffHourChime"
        LblACOffHourChime.Size = New Size(163, 23)
        LblACOffHourChime.TabIndex = 209
        LblACOffHourChime.Text = "Off-Hour Chimes"
        TipInfoEX.SetText(LblACOffHourChime, Nothing)
        LblACOffHourChime.TextAlign = ContentAlignment.BottomRight
        ' 
        ' PanelWL
        ' 
        PanelWL.Controls.Add(TxtBoxWLMaxLinksPerFolder)
        PanelWL.Controls.Add(PanelWLItem)
        PanelWL.Controls.Add(TxtBoxWLStartUpDelay)
        PanelWL.Controls.Add(TxtBoxWLAutoRefreshInterval)
        PanelWL.Controls.Add(LVWL)
        PanelWL.Controls.Add(TxtBoxWLAutoRefreshIdleInterval)
        PanelWL.Controls.Add(ChkBoxWLShowFilePathToolTips)
        PanelWL.Controls.Add(ChkBoxWLAutoRefresh)
        PanelWL.Controls.Add(ChkBoxWLShowFileInfoToolTips)
        PanelWL.Controls.Add(ChkBoxWLShowFolderPathToolTips)
        PanelWL.Controls.Add(BtnWLRefresh)
        PanelWL.Controls.Add(LblWLStartUpDelay)
        PanelWL.Controls.Add(LblWLAutoRefresh)
        PanelWL.Controls.Add(LblWLAutoRefreshIdleInterval)
        PanelWL.Controls.Add(LblWLAutoRefreshInterval)
        PanelWL.Controls.Add(LblWLMaxLinksPerFolder)
        PanelWL.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelWL, Nothing)
        PanelWL.Location = New Point(187, 0)
        PanelWL.Name = "PanelWL"
        PanelWL.Size = New Size(730, 534)
        PanelWL.TabIndex = 112
        TipInfoEX.SetText(PanelWL, Nothing)
        ' 
        ' TxtBoxWLMaxLinksPerFolder
        ' 
        TxtBoxWLMaxLinksPerFolder.ContextMenuStrip = CMBlankForTextBoxes
        TipInfoEX.SetImage(TxtBoxWLMaxLinksPerFolder, Nothing)
        TxtBoxWLMaxLinksPerFolder.Location = New Point(13, 47)
        TxtBoxWLMaxLinksPerFolder.MaxLength = 3
        TxtBoxWLMaxLinksPerFolder.Name = "TxtBoxWLMaxLinksPerFolder"
        TxtBoxWLMaxLinksPerFolder.Size = New Size(44, 29)
        TxtBoxWLMaxLinksPerFolder.TabIndex = 20
        TipInfoEX.SetText(TxtBoxWLMaxLinksPerFolder, Nothing)
        TxtBoxWLMaxLinksPerFolder.TextAlign = HorizontalAlignment.Center
        ' 
        ' PanelWLItem
        ' 
        PanelWLItem.AutoSize = True
        PanelWLItem.BorderStyle = BorderStyle.FixedSingle
        PanelWLItem.Controls.Add(ChkBoxWLShowNoMenu)
        PanelWLItem.Controls.Add(TxtBoxWLName)
        PanelWLItem.Controls.Add(ChkBoxWLShowMenuIcons)
        PanelWLItem.Controls.Add(ChkBoxWLShowInTray)
        PanelWLItem.Controls.Add(ChkBoxWLShowInMenu)
        PanelWLItem.Controls.Add(CoBoxWLFolderPlacement)
        PanelWLItem.Controls.Add(CoBoxWLFolderMode)
        PanelWLItem.Controls.Add(CoBoxWLSort)
        PanelWLItem.Controls.Add(TxtBoxWLRoot)
        PanelWLItem.Controls.Add(BtnWLSelectFolder)
        PanelWLItem.Controls.Add(BtnWLCancel)
        PanelWLItem.Controls.Add(BtnWLSet)
        PanelWLItem.Controls.Add(ChkBoxWLUseDefaultIcon)
        PanelWLItem.Controls.Add(LblWLFolderPlacement)
        PanelWLItem.Controls.Add(LblWLFolderMode)
        PanelWLItem.Controls.Add(LblWLSortOrder)
        PanelWLItem.Controls.Add(LblWLDisplayName)
        PanelWLItem.Controls.Add(LblWLRoot)
        TipInfoEX.SetImage(PanelWLItem, Nothing)
        PanelWLItem.Location = New Point(13, 318)
        PanelWLItem.Name = "PanelWLItem"
        PanelWLItem.Size = New Size(706, 205)
        PanelWLItem.TabIndex = 200
        TipInfoEX.SetText(PanelWLItem, Nothing)
        PanelWLItem.Visible = False
        ' 
        ' ChkBoxWLShowNoMenu
        ' 
        ChkBoxWLShowNoMenu.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWLShowNoMenu, Nothing)
        ChkBoxWLShowNoMenu.Location = New Point(546, 107)
        ChkBoxWLShowNoMenu.Name = "ChkBoxWLShowNoMenu"
        ChkBoxWLShowNoMenu.Size = New Size(136, 25)
        ChkBoxWLShowNoMenu.TabIndex = 50
        TipInfoEX.SetText(ChkBoxWLShowNoMenu, Nothing)
        ChkBoxWLShowNoMenu.Text = "No Menu Items"
        ChkBoxWLShowNoMenu.UseVisualStyleBackColor = True
        ' 
        ' TxtBoxWLName
        ' 
        TxtBoxWLName.ContextMenuStrip = CMBlankForTextBoxes
        TipInfoEX.SetImage(TxtBoxWLName, Nothing)
        TxtBoxWLName.Location = New Point(8, 79)
        TxtBoxWLName.Name = "TxtBoxWLName"
        TxtBoxWLName.Size = New Size(463, 29)
        TxtBoxWLName.TabIndex = 15
        TipInfoEX.SetText(TxtBoxWLName, Nothing)
        ' 
        ' ChkBoxWLShowMenuIcons
        ' 
        ChkBoxWLShowMenuIcons.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWLShowMenuIcons, Nothing)
        ChkBoxWLShowMenuIcons.Location = New Point(546, 88)
        ChkBoxWLShowMenuIcons.Name = "ChkBoxWLShowMenuIcons"
        ChkBoxWLShowMenuIcons.Size = New Size(152, 25)
        ChkBoxWLShowMenuIcons.TabIndex = 40
        TipInfoEX.SetText(ChkBoxWLShowMenuIcons, Nothing)
        ChkBoxWLShowMenuIcons.Text = "Show Menu Icons"
        ChkBoxWLShowMenuIcons.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWLShowInTray
        ' 
        ChkBoxWLShowInTray.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWLShowInTray, Nothing)
        ChkBoxWLShowInTray.Location = New Point(546, 57)
        ChkBoxWLShowInTray.Name = "ChkBoxWLShowInTray"
        ChkBoxWLShowInTray.Size = New Size(118, 25)
        ChkBoxWLShowInTray.TabIndex = 30
        TipInfoEX.SetText(ChkBoxWLShowInTray, Nothing)
        ChkBoxWLShowInTray.Text = "Show In Tray"
        ChkBoxWLShowInTray.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWLShowInMenu
        ' 
        ChkBoxWLShowInMenu.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWLShowInMenu, Nothing)
        ChkBoxWLShowInMenu.Location = New Point(546, 37)
        ChkBoxWLShowInMenu.Name = "ChkBoxWLShowInMenu"
        ChkBoxWLShowInMenu.Size = New Size(129, 25)
        ChkBoxWLShowInMenu.TabIndex = 25
        TipInfoEX.SetText(ChkBoxWLShowInMenu, Nothing)
        ChkBoxWLShowInMenu.Text = "Show In Menu"
        ChkBoxWLShowInMenu.UseVisualStyleBackColor = True
        ' 
        ' CoBoxWLFolderPlacement
        ' 
        CoBoxWLFolderPlacement.DropDownStyle = ComboBoxStyle.DropDownList
        CoBoxWLFolderPlacement.FormattingEnabled = True
        TipInfoEX.SetImage(CoBoxWLFolderPlacement, Nothing)
        CoBoxWLFolderPlacement.Items.AddRange(New Object() {"Top", "Bottom", "Merged"})
        CoBoxWLFolderPlacement.Location = New Point(296, 165)
        CoBoxWLFolderPlacement.Name = "CoBoxWLFolderPlacement"
        CoBoxWLFolderPlacement.Size = New Size(139, 29)
        CoBoxWLFolderPlacement.TabIndex = 80
        TipInfoEX.SetText(CoBoxWLFolderPlacement, Nothing)
        ' 
        ' CoBoxWLFolderMode
        ' 
        CoBoxWLFolderMode.DropDownStyle = ComboBoxStyle.DropDownList
        CoBoxWLFolderMode.FormattingEnabled = True
        TipInfoEX.SetImage(CoBoxWLFolderMode, Nothing)
        CoBoxWLFolderMode.Items.AddRange(New Object() {"No Folders", "Show As Link", "Show As Link Menu", "Show As Menu", "Folders Only"})
        CoBoxWLFolderMode.Location = New Point(123, 165)
        CoBoxWLFolderMode.Name = "CoBoxWLFolderMode"
        CoBoxWLFolderMode.Size = New Size(167, 29)
        CoBoxWLFolderMode.TabIndex = 70
        TipInfoEX.SetText(CoBoxWLFolderMode, Nothing)
        ' 
        ' CoBoxWLSort
        ' 
        CoBoxWLSort.DropDownStyle = ComboBoxStyle.DropDownList
        CoBoxWLSort.FormattingEnabled = True
        TipInfoEX.SetImage(CoBoxWLSort, Nothing)
        CoBoxWLSort.Items.AddRange(New Object() {"Ascending", "Descending"})
        CoBoxWLSort.Location = New Point(8, 166)
        CoBoxWLSort.Name = "CoBoxWLSort"
        CoBoxWLSort.Size = New Size(109, 29)
        CoBoxWLSort.TabIndex = 60
        TipInfoEX.SetText(CoBoxWLSort, Nothing)
        ' 
        ' TxtBoxWLRoot
        ' 
        TxtBoxWLRoot.ContextMenuStrip = CMBlankForTextBoxes
        TipInfoEX.SetImage(TxtBoxWLRoot, Nothing)
        TxtBoxWLRoot.Location = New Point(8, 25)
        TxtBoxWLRoot.Name = "TxtBoxWLRoot"
        TxtBoxWLRoot.Size = New Size(463, 29)
        TxtBoxWLRoot.TabIndex = 10
        TipInfoEX.SetText(TxtBoxWLRoot, Nothing)
        ' 
        ' BtnWLSelectFolder
        ' 
        BtnWLSelectFolder.FlatAppearance.BorderSize = 0
        BtnWLSelectFolder.Image = My.Resources.Resources.imageRestore
        TipInfoEX.SetImage(BtnWLSelectFolder, Nothing)
        BtnWLSelectFolder.Location = New Point(472, 24)
        BtnWLSelectFolder.Name = "BtnWLSelectFolder"
        BtnWLSelectFolder.Size = New Size(32, 32)
        BtnWLSelectFolder.TabIndex = 10
        TipInfoEX.SetText(BtnWLSelectFolder, Nothing)
        BtnWLSelectFolder.UseVisualStyleBackColor = True
        ' 
        ' BtnWLCancel
        ' 
        BtnWLCancel.ForeColor = Color.Navy
        BtnWLCancel.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(BtnWLCancel, Nothing)
        BtnWLCancel.ImageAlign = ContentAlignment.MiddleLeft
        BtnWLCancel.Location = New Point(522, 162)
        BtnWLCancel.Name = "BtnWLCancel"
        BtnWLCancel.Size = New Size(100, 32)
        BtnWLCancel.TabIndex = 100
        TipInfoEX.SetText(BtnWLCancel, Nothing)
        BtnWLCancel.Text = "Cancel"
        BtnWLCancel.TextAlign = ContentAlignment.MiddleRight
        BtnWLCancel.UseVisualStyleBackColor = True
        ' 
        ' BtnWLSet
        ' 
        BtnWLSet.ForeColor = Color.Navy
        BtnWLSet.Image = My.Resources.Resources.imageGoStart
        TipInfoEX.SetImage(BtnWLSet, Nothing)
        BtnWLSet.ImageAlign = ContentAlignment.MiddleLeft
        BtnWLSet.Location = New Point(628, 162)
        BtnWLSet.Name = "BtnWLSet"
        BtnWLSet.Size = New Size(66, 32)
        BtnWLSet.TabIndex = 110
        TipInfoEX.SetText(BtnWLSet, Nothing)
        BtnWLSet.Text = "Set"
        BtnWLSet.TextAlign = ContentAlignment.MiddleRight
        BtnWLSet.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWLUseDefaultIcon
        ' 
        ChkBoxWLUseDefaultIcon.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWLUseDefaultIcon, Nothing)
        ChkBoxWLUseDefaultIcon.Location = New Point(546, 6)
        ChkBoxWLUseDefaultIcon.Name = "ChkBoxWLUseDefaultIcon"
        ChkBoxWLUseDefaultIcon.Size = New Size(142, 25)
        ChkBoxWLUseDefaultIcon.TabIndex = 20
        TipInfoEX.SetText(ChkBoxWLUseDefaultIcon, Nothing)
        ChkBoxWLUseDefaultIcon.Text = "Use Default Icon"
        ChkBoxWLUseDefaultIcon.UseVisualStyleBackColor = True
        ' 
        ' LblWLFolderPlacement
        ' 
        LblWLFolderPlacement.AutoSize = True
        TipInfoEX.SetImage(LblWLFolderPlacement, Nothing)
        LblWLFolderPlacement.Location = New Point(296, 147)
        LblWLFolderPlacement.Name = "LblWLFolderPlacement"
        LblWLFolderPlacement.Size = New Size(130, 21)
        LblWLFolderPlacement.TabIndex = 173
        LblWLFolderPlacement.Text = "Folder Placement"
        TipInfoEX.SetText(LblWLFolderPlacement, Nothing)
        ' 
        ' LblWLFolderMode
        ' 
        LblWLFolderMode.AutoSize = True
        TipInfoEX.SetImage(LblWLFolderMode, Nothing)
        LblWLFolderMode.Location = New Point(123, 147)
        LblWLFolderMode.Name = "LblWLFolderMode"
        LblWLFolderMode.Size = New Size(98, 21)
        LblWLFolderMode.TabIndex = 172
        LblWLFolderMode.Text = "Folder Mode"
        TipInfoEX.SetText(LblWLFolderMode, Nothing)
        ' 
        ' LblWLSortOrder
        ' 
        LblWLSortOrder.AutoSize = True
        TipInfoEX.SetImage(LblWLSortOrder, Nothing)
        LblWLSortOrder.Location = New Point(8, 148)
        LblWLSortOrder.Name = "LblWLSortOrder"
        LblWLSortOrder.Size = New Size(84, 21)
        LblWLSortOrder.TabIndex = 171
        LblWLSortOrder.Text = "Sort Order"
        TipInfoEX.SetText(LblWLSortOrder, Nothing)
        ' 
        ' LblWLDisplayName
        ' 
        LblWLDisplayName.AutoSize = True
        TipInfoEX.SetImage(LblWLDisplayName, Nothing)
        LblWLDisplayName.Location = New Point(8, 58)
        LblWLDisplayName.Name = "LblWLDisplayName"
        LblWLDisplayName.Size = New Size(107, 21)
        LblWLDisplayName.TabIndex = 170
        LblWLDisplayName.Text = "Display Name"
        TipInfoEX.SetText(LblWLDisplayName, "Leave Blank To Use FolderName")
        ' 
        ' LblWLRoot
        ' 
        LblWLRoot.AutoSize = True
        TipInfoEX.SetImage(LblWLRoot, Nothing)
        LblWLRoot.Location = New Point(7, 4)
        LblWLRoot.Name = "LblWLRoot"
        LblWLRoot.Size = New Size(68, 21)
        LblWLRoot.TabIndex = 169
        LblWLRoot.Text = "SAMPLE"
        TipInfoEX.SetText(LblWLRoot, Nothing)
        ' 
        ' TxtBoxWLStartUpDelay
        ' 
        TxtBoxWLStartUpDelay.ContextMenuStrip = CMBlankForTextBoxes
        TipInfoEX.SetImage(TxtBoxWLStartUpDelay, Nothing)
        TxtBoxWLStartUpDelay.Location = New Point(13, 12)
        TxtBoxWLStartUpDelay.MaxLength = 3
        TxtBoxWLStartUpDelay.Name = "TxtBoxWLStartUpDelay"
        TxtBoxWLStartUpDelay.Size = New Size(44, 29)
        TxtBoxWLStartUpDelay.TabIndex = 10
        TipInfoEX.SetText(TxtBoxWLStartUpDelay, Nothing)
        TxtBoxWLStartUpDelay.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtBoxWLAutoRefreshInterval
        ' 
        TxtBoxWLAutoRefreshInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TxtBoxWLAutoRefreshInterval.ContextMenuStrip = CMBlankForTextBoxes
        TipInfoEX.SetImage(TxtBoxWLAutoRefreshInterval, Nothing)
        TxtBoxWLAutoRefreshInterval.Location = New Point(675, 12)
        TxtBoxWLAutoRefreshInterval.MaxLength = 2
        TxtBoxWLAutoRefreshInterval.Name = "TxtBoxWLAutoRefreshInterval"
        TxtBoxWLAutoRefreshInterval.Size = New Size(44, 29)
        TxtBoxWLAutoRefreshInterval.TabIndex = 60
        TipInfoEX.SetText(TxtBoxWLAutoRefreshInterval, Nothing)
        TxtBoxWLAutoRefreshInterval.TextAlign = HorizontalAlignment.Center
        ' 
        ' LVWL
        ' 
        LVWL.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LVWL.BorderStyle = BorderStyle.FixedSingle
        LVWL.ContextMenuStrip = CMLVWL
        LVWL.FullRowSelect = True
        LVWL.HeaderStyle = ColumnHeaderStyle.None
        TipInfoEX.SetImage(LVWL, Nothing)
        LVWL.LabelWrap = False
        LVWL.Location = New Point(13, 208)
        LVWL.MultiSelect = False
        LVWL.Name = "LVWL"
        LVWL.ShowGroups = False
        LVWL.Size = New Size(706, 111)
        LVWL.TabIndex = 150
        TipInfoEX.SetText(LVWL, Nothing)
        LVWL.UseCompatibleStateImageBehavior = False
        LVWL.View = View.Details
        ' 
        ' CMLVWL
        ' 
        CMLVWL.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TipInfoEX.SetImage(CMLVWL, Nothing)
        CMLVWL.Items.AddRange(New ToolStripItem() {CMIWLMoveUp, CMIWLMoveDown, TSSWL1, CMIWLNew, TSSWL2, CMIWLDelete})
        CMLVWL.Name = "contextmenulistviewHotLinks"
        CMLVWL.Size = New Size(125, 120)
        TipInfoEX.SetText(CMLVWL, Nothing)
        ' 
        ' CMIWLMoveUp
        ' 
        CMIWLMoveUp.Image = My.Resources.Resources.imageMoveUp
        CMIWLMoveUp.Name = "CMIWLMoveUp"
        CMIWLMoveUp.Size = New Size(124, 26)
        CMIWLMoveUp.Text = "Up"
        ' 
        ' CMIWLMoveDown
        ' 
        CMIWLMoveDown.Image = My.Resources.Resources.imageMoveDown
        CMIWLMoveDown.Name = "CMIWLMoveDown"
        CMIWLMoveDown.Size = New Size(124, 26)
        CMIWLMoveDown.Text = "Down"
        ' 
        ' TSSWL1
        ' 
        TSSWL1.Name = "TSSWL1"
        TSSWL1.Size = New Size(121, 6)
        ' 
        ' CMIWLNew
        ' 
        CMIWLNew.Image = My.Resources.Resources.imageWLNew
        CMIWLNew.Name = "CMIWLNew"
        CMIWLNew.Size = New Size(124, 26)
        ' 
        ' TSSWL2
        ' 
        TSSWL2.Name = "TSSWL2"
        TSSWL2.Size = New Size(121, 6)
        ' 
        ' CMIWLDelete
        ' 
        CMIWLDelete.Image = My.Resources.Resources.imageRemove
        CMIWLDelete.Name = "CMIWLDelete"
        CMIWLDelete.Size = New Size(124, 26)
        CMIWLDelete.Text = "Delete"
        ' 
        ' TxtBoxWLAutoRefreshIdleInterval
        ' 
        TxtBoxWLAutoRefreshIdleInterval.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TxtBoxWLAutoRefreshIdleInterval.ContextMenuStrip = CMBlankForTextBoxes
        TipInfoEX.SetImage(TxtBoxWLAutoRefreshIdleInterval, Nothing)
        TxtBoxWLAutoRefreshIdleInterval.Location = New Point(675, 47)
        TxtBoxWLAutoRefreshIdleInterval.MaxLength = 3
        TxtBoxWLAutoRefreshIdleInterval.Name = "TxtBoxWLAutoRefreshIdleInterval"
        TxtBoxWLAutoRefreshIdleInterval.Size = New Size(44, 29)
        TxtBoxWLAutoRefreshIdleInterval.TabIndex = 70
        TipInfoEX.SetText(TxtBoxWLAutoRefreshIdleInterval, Nothing)
        TxtBoxWLAutoRefreshIdleInterval.TextAlign = HorizontalAlignment.Center
        ' 
        ' ChkBoxWLShowFilePathToolTips
        ' 
        ChkBoxWLShowFilePathToolTips.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWLShowFilePathToolTips, Nothing)
        ChkBoxWLShowFilePathToolTips.Location = New Point(13, 95)
        ChkBoxWLShowFilePathToolTips.Name = "ChkBoxWLShowFilePathToolTips"
        ChkBoxWLShowFilePathToolTips.Size = New Size(200, 25)
        ChkBoxWLShowFilePathToolTips.TabIndex = 30
        TipInfoEX.SetText(ChkBoxWLShowFilePathToolTips, "Show Full File Path In ToolTip")
        ChkBoxWLShowFilePathToolTips.Text = "Show File Path In ToolTip"
        ChkBoxWLShowFilePathToolTips.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWLAutoRefresh
        ' 
        ChkBoxWLAutoRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkBoxWLAutoRefresh.AutoSize = True
        ChkBoxWLAutoRefresh.CheckAlign = ContentAlignment.MiddleRight
        TipInfoEX.SetImage(ChkBoxWLAutoRefresh, Nothing)
        ChkBoxWLAutoRefresh.Location = New Point(554, 95)
        ChkBoxWLAutoRefresh.Name = "ChkBoxWLAutoRefresh"
        ChkBoxWLAutoRefresh.Size = New Size(165, 25)
        ChkBoxWLAutoRefresh.TabIndex = 80
        TipInfoEX.SetText(ChkBoxWLAutoRefresh, "Enable AutoRefresh For Last WinLink")
        ChkBoxWLAutoRefresh.Text = "Enable AutoRefresh"
        ChkBoxWLAutoRefresh.TextAlign = ContentAlignment.MiddleRight
        ChkBoxWLAutoRefresh.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWLShowFileInfoToolTips
        ' 
        ChkBoxWLShowFileInfoToolTips.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWLShowFileInfoToolTips, Nothing)
        ChkBoxWLShowFileInfoToolTips.Location = New Point(13, 135)
        ChkBoxWLShowFileInfoToolTips.Name = "ChkBoxWLShowFileInfoToolTips"
        ChkBoxWLShowFileInfoToolTips.Size = New Size(197, 25)
        ChkBoxWLShowFileInfoToolTips.TabIndex = 50
        TipInfoEX.SetText(ChkBoxWLShowFileInfoToolTips, "Show File Details In ToolTip")
        ChkBoxWLShowFileInfoToolTips.Text = "Show File Info In ToolTip"
        ChkBoxWLShowFileInfoToolTips.UseVisualStyleBackColor = True
        ' 
        ' ChkBoxWLShowFolderPathToolTips
        ' 
        ChkBoxWLShowFolderPathToolTips.AutoSize = True
        TipInfoEX.SetImage(ChkBoxWLShowFolderPathToolTips, Nothing)
        ChkBoxWLShowFolderPathToolTips.Location = New Point(13, 115)
        ChkBoxWLShowFolderPathToolTips.Name = "ChkBoxWLShowFolderPathToolTips"
        ChkBoxWLShowFolderPathToolTips.Size = New Size(220, 25)
        ChkBoxWLShowFolderPathToolTips.TabIndex = 40
        TipInfoEX.SetText(ChkBoxWLShowFolderPathToolTips, "Show Full Directory Path In ToolTip")
        ChkBoxWLShowFolderPathToolTips.Text = "Show Folder Path In ToolTip"
        ChkBoxWLShowFolderPathToolTips.UseVisualStyleBackColor = True
        ' 
        ' BtnWLRefresh
        ' 
        BtnWLRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TipInfoEX.SetImage(BtnWLRefresh, Nothing)
        BtnWLRefresh.ImageAlign = ContentAlignment.MiddleLeft
        BtnWLRefresh.Location = New Point(11, 174)
        BtnWLRefresh.Name = "BtnWLRefresh"
        BtnWLRefresh.Size = New Size(709, 32)
        BtnWLRefresh.TabIndex = 100
        TipInfoEX.SetText(BtnWLRefresh, "Refresh")
        BtnWLRefresh.Text = "FULL REFRESH"
        BtnWLRefresh.UseVisualStyleBackColor = True
        ' 
        ' LblWLStartUpDelay
        ' 
        LblWLStartUpDelay.AutoSize = True
        TipInfoEX.SetImage(LblWLStartUpDelay, Nothing)
        LblWLStartUpDelay.Location = New Point(54, 16)
        LblWLStartUpDelay.Name = "LblWLStartUpDelay"
        LblWLStartUpDelay.Size = New Size(105, 21)
        LblWLStartUpDelay.TabIndex = 201
        LblWLStartUpDelay.Text = "StartUp Delay"
        TipInfoEX.SetText(LblWLStartUpDelay, "5-300, 0 = No Delay")
        LblWLStartUpDelay.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblWLAutoRefresh
        ' 
        LblWLAutoRefresh.AutoSize = True
        LblWLAutoRefresh.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TipInfoEX.SetImage(LblWLAutoRefresh, Nothing)
        LblWLAutoRefresh.Location = New Point(552, 114)
        LblWLAutoRefresh.Name = "LblWLAutoRefresh"
        LblWLAutoRefresh.Size = New Size(175, 21)
        LblWLAutoRefresh.TabIndex = 205
        LblWLAutoRefresh.Text = "AutoRefresh Engaged"
        TipInfoEX.SetText(LblWLAutoRefresh, Nothing)
        LblWLAutoRefresh.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblWLAutoRefreshIdleInterval
        ' 
        LblWLAutoRefreshIdleInterval.AutoSize = True
        TipInfoEX.SetImage(LblWLAutoRefreshIdleInterval, Nothing)
        LblWLAutoRefreshIdleInterval.Location = New Point(500, 52)
        LblWLAutoRefreshIdleInterval.Name = "LblWLAutoRefreshIdleInterval"
        LblWLAutoRefreshIdleInterval.Size = New Size(181, 21)
        LblWLAutoRefreshIdleInterval.TabIndex = 204
        LblWLAutoRefreshIdleInterval.Text = "AutoRefresh Idle Interval"
        TipInfoEX.SetText(LblWLAutoRefreshIdleInterval, "Refresh Only When Folder Idle For 20-240 Seconds")
        LblWLAutoRefreshIdleInterval.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblWLAutoRefreshInterval
        ' 
        LblWLAutoRefreshInterval.AutoSize = True
        TipInfoEX.SetImage(LblWLAutoRefreshInterval, Nothing)
        LblWLAutoRefreshInterval.Location = New Point(529, 17)
        LblWLAutoRefreshInterval.Name = "LblWLAutoRefreshInterval"
        LblWLAutoRefreshInterval.Size = New Size(152, 21)
        LblWLAutoRefreshInterval.TabIndex = 203
        LblWLAutoRefreshInterval.Text = "AutoRefresh Interval"
        TipInfoEX.SetText(LblWLAutoRefreshInterval, "Check For Changes Every 1-90 Minutes")
        LblWLAutoRefreshInterval.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblWLMaxLinksPerFolder
        ' 
        LblWLMaxLinksPerFolder.AutoSize = True
        TipInfoEX.SetImage(LblWLMaxLinksPerFolder, Nothing)
        LblWLMaxLinksPerFolder.Location = New Point(54, 51)
        LblWLMaxLinksPerFolder.Name = "LblWLMaxLinksPerFolder"
        LblWLMaxLinksPerFolder.Size = New Size(199, 21)
        LblWLMaxLinksPerFolder.TabIndex = 202
        LblWLMaxLinksPerFolder.Text = "Max Menu Items Per Folder"
        TipInfoEX.SetText(LblWLMaxLinksPerFolder, "1-100")
        LblWLMaxLinksPerFolder.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelHC
        ' 
        PanelHC.Controls.Add(CoBoxHCRight)
        PanelHC.Controls.Add(CoBoxHCMiddle)
        PanelHC.Controls.Add(CoBoxHCDouble)
        PanelHC.Controls.Add(CoBoxHCLeft)
        PanelHC.Controls.Add(GrpBoxHC)
        PanelHC.Controls.Add(LblHCDouble)
        PanelHC.Controls.Add(LblHCLeft)
        PanelHC.Controls.Add(LblHCMiddle)
        PanelHC.Controls.Add(LblHCRight)
        PanelHC.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelHC, Nothing)
        PanelHC.Location = New Point(187, 0)
        PanelHC.Name = "PanelHC"
        PanelHC.Size = New Size(730, 534)
        PanelHC.TabIndex = 113
        TipInfoEX.SetText(PanelHC, Nothing)
        ' 
        ' CoBoxHCRight
        ' 
        CoBoxHCRight.DropDownStyle = ComboBoxStyle.DropDownList
        CoBoxHCRight.FormattingEnabled = True
        TipInfoEX.SetImage(CoBoxHCRight, Nothing)
        CoBoxHCRight.Location = New Point(236, 232)
        CoBoxHCRight.Name = "CoBoxHCRight"
        CoBoxHCRight.Size = New Size(258, 29)
        CoBoxHCRight.Sorted = True
        CoBoxHCRight.TabIndex = 59
        TipInfoEX.SetText(CoBoxHCRight, Nothing)
        ' 
        ' CoBoxHCMiddle
        ' 
        CoBoxHCMiddle.DropDownStyle = ComboBoxStyle.DropDownList
        CoBoxHCMiddle.FormattingEnabled = True
        TipInfoEX.SetImage(CoBoxHCMiddle, Nothing)
        CoBoxHCMiddle.Location = New Point(236, 204)
        CoBoxHCMiddle.Name = "CoBoxHCMiddle"
        CoBoxHCMiddle.Size = New Size(258, 29)
        CoBoxHCMiddle.Sorted = True
        CoBoxHCMiddle.TabIndex = 57
        TipInfoEX.SetText(CoBoxHCMiddle, Nothing)
        ' 
        ' CoBoxHCDouble
        ' 
        CoBoxHCDouble.DropDownStyle = ComboBoxStyle.DropDownList
        CoBoxHCDouble.FormattingEnabled = True
        TipInfoEX.SetImage(CoBoxHCDouble, Nothing)
        CoBoxHCDouble.Location = New Point(236, 176)
        CoBoxHCDouble.Name = "CoBoxHCDouble"
        CoBoxHCDouble.Size = New Size(258, 29)
        CoBoxHCDouble.Sorted = True
        CoBoxHCDouble.TabIndex = 55
        TipInfoEX.SetText(CoBoxHCDouble, Nothing)
        ' 
        ' CoBoxHCLeft
        ' 
        CoBoxHCLeft.DropDownStyle = ComboBoxStyle.DropDownList
        CoBoxHCLeft.FormattingEnabled = True
        TipInfoEX.SetImage(CoBoxHCLeft, Nothing)
        CoBoxHCLeft.Location = New Point(236, 148)
        CoBoxHCLeft.Name = "CoBoxHCLeft"
        CoBoxHCLeft.Size = New Size(258, 29)
        CoBoxHCLeft.Sorted = True
        CoBoxHCLeft.TabIndex = 53
        TipInfoEX.SetText(CoBoxHCLeft, Nothing)
        ' 
        ' GrpBoxHC
        ' 
        GrpBoxHC.Controls.Add(RadBtnHCWL)
        GrpBoxHC.Controls.Add(RadBtnHCWSTSS)
        GrpBoxHC.Controls.Add(RadBtnHCWST)
        TipInfoEX.SetImage(GrpBoxHC, Nothing)
        GrpBoxHC.Location = New Point(236, 52)
        GrpBoxHC.Name = "GrpBoxHC"
        GrpBoxHC.Size = New Size(258, 86)
        GrpBoxHC.TabIndex = 51
        GrpBoxHC.TabStop = False
        TipInfoEX.SetText(GrpBoxHC, Nothing)
        ' 
        ' RadBtnHCWL
        ' 
        RadBtnHCWL.Image = My.Resources.Resources.ImageWL48
        TipInfoEX.SetImage(RadBtnHCWL, Nothing)
        RadBtnHCWL.ImageAlign = ContentAlignment.MiddleLeft
        RadBtnHCWL.Location = New Point(186, 16)
        RadBtnHCWL.Name = "RadBtnHCWL"
        RadBtnHCWL.Size = New Size(70, 64)
        RadBtnHCWL.TabIndex = 4
        RadBtnHCWL.TabStop = True
        TipInfoEX.SetText(RadBtnHCWL, Nothing)
        RadBtnHCWL.TextAlign = ContentAlignment.MiddleCenter
        RadBtnHCWL.UseVisualStyleBackColor = True
        ' 
        ' RadBtnHCWSTSS
        ' 
        RadBtnHCWSTSS.Image = My.Resources.Resources.ImageWSTSS48
        TipInfoEX.SetImage(RadBtnHCWSTSS, Nothing)
        RadBtnHCWSTSS.ImageAlign = ContentAlignment.MiddleLeft
        RadBtnHCWSTSS.Location = New Point(99, 16)
        RadBtnHCWSTSS.Name = "RadBtnHCWSTSS"
        RadBtnHCWSTSS.Size = New Size(70, 64)
        RadBtnHCWSTSS.TabIndex = 1
        RadBtnHCWSTSS.TabStop = True
        TipInfoEX.SetText(RadBtnHCWSTSS, Nothing)
        RadBtnHCWSTSS.TextAlign = ContentAlignment.MiddleCenter
        RadBtnHCWSTSS.UseVisualStyleBackColor = True
        ' 
        ' RadBtnHCWST
        ' 
        RadBtnHCWST.Image = My.Resources.Resources.ImageWST48
        TipInfoEX.SetImage(RadBtnHCWST, Nothing)
        RadBtnHCWST.ImageAlign = ContentAlignment.MiddleLeft
        RadBtnHCWST.Location = New Point(12, 16)
        RadBtnHCWST.Name = "RadBtnHCWST"
        RadBtnHCWST.Size = New Size(70, 64)
        RadBtnHCWST.TabIndex = 0
        RadBtnHCWST.TabStop = True
        TipInfoEX.SetText(RadBtnHCWST, Nothing)
        RadBtnHCWST.TextAlign = ContentAlignment.MiddleCenter
        RadBtnHCWST.UseMnemonic = False
        RadBtnHCWST.UseVisualStyleBackColor = False
        ' 
        ' LblHCDouble
        ' 
        LblHCDouble.AutoSize = True
        LblHCDouble.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        TipInfoEX.SetImage(LblHCDouble, Nothing)
        LblHCDouble.Location = New Point(163, 179)
        LblHCDouble.Name = "LblHCDouble"
        LblHCDouble.Size = New Size(73, 21)
        LblHCDouble.TabIndex = 54
        LblHCDouble.Text = "DOUBLE"
        TipInfoEX.SetText(LblHCDouble, Nothing)
        LblHCDouble.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblHCLeft
        ' 
        LblHCLeft.AutoSize = True
        LblHCLeft.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        TipInfoEX.SetImage(LblHCLeft, Nothing)
        LblHCLeft.Location = New Point(192, 152)
        LblHCLeft.Name = "LblHCLeft"
        LblHCLeft.Size = New Size(44, 21)
        LblHCLeft.TabIndex = 52
        LblHCLeft.Text = "LEFT"
        TipInfoEX.SetText(LblHCLeft, Nothing)
        LblHCLeft.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblHCMiddle
        ' 
        LblHCMiddle.AutoSize = True
        LblHCMiddle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        TipInfoEX.SetImage(LblHCMiddle, Nothing)
        LblHCMiddle.Location = New Point(165, 208)
        LblHCMiddle.Name = "LblHCMiddle"
        LblHCMiddle.Size = New Size(71, 21)
        LblHCMiddle.TabIndex = 56
        LblHCMiddle.Text = "MIDDLE"
        TipInfoEX.SetText(LblHCMiddle, Nothing)
        LblHCMiddle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblHCRight
        ' 
        LblHCRight.AutoSize = True
        LblHCRight.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        TipInfoEX.SetImage(LblHCRight, Nothing)
        LblHCRight.Location = New Point(179, 235)
        LblHCRight.Name = "LblHCRight"
        LblHCRight.Size = New Size(57, 21)
        LblHCRight.TabIndex = 58
        LblHCRight.Text = "RIGHT"
        TipInfoEX.SetText(LblHCRight, Nothing)
        LblHCRight.TextAlign = ContentAlignment.MiddleRight
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
        Controls.Add(PanelHC)
        Controls.Add(PanelWL)
        Controls.Add(PanelAC)
        Controls.Add(PanelSS)
        Controls.Add(PanelApp)
        Controls.Add(PanelWST)
        Controls.Add(PanelHK)
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
        GrpBoxACTopHourChimeType.ResumeLayout(False)
        GrpBoxACTopHourChimeType.PerformLayout()
        GrpBoxACAlarmChimeType.ResumeLayout(False)
        GrpBoxACAlarmChimeType.PerformLayout()
        CType(PicBoxACClock, ComponentModel.ISupportInitialize).EndInit()
        PanelWL.ResumeLayout(False)
        PanelWL.PerformLayout()
        PanelWLItem.ResumeLayout(False)
        PanelWLItem.PerformLayout()
        CMLVWL.ResumeLayout(False)
        PanelHC.ResumeLayout(False)
        PanelHC.PerformLayout()
        GrpBoxHC.ResumeLayout(False)
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
    Private WithEvents CoBoxSSStartUp As ComboBox
    Private WithEvents LblSSStartupMode As Label
    Private WithEvents ChkBoxSSEnableOnActivate As CheckBox
    Private WithEvents ChkBoxSSShowEnabled As CheckBox
    Private WithEvents ChkBoxSSShowActivate As CheckBox
    Private WithEvents ChkBoxSSShowIcon As CheckBox
    Friend WithEvents CMBlankForTextBoxes As ContextMenuStrip
    Private WithEvents TxtBoxWLMaxLinksPerFolder As TextBox
    Private WithEvents PanelWLItem As Panel
    Private WithEvents ChkBoxWLShowNoMenu As CheckBox
    Private WithEvents TxtBoxWLName As TextBox
    Private WithEvents ChkBoxWLShowMenuIcons As CheckBox
    Private WithEvents ChkBoxWLShowInTray As CheckBox
    Private WithEvents ChkBoxWLShowInMenu As CheckBox
    Private WithEvents CoBoxWLFolderPlacement As ComboBox
    Private WithEvents CoBoxWLFolderMode As ComboBox
    Private WithEvents CoBoxWLSort As ComboBox
    Private WithEvents TxtBoxWLRoot As TextBox
    Private WithEvents BtnWLSelectFolder As Button
    Private WithEvents BtnWLCancel As Button
    Private WithEvents BtnWLSet As Button
    Private WithEvents ChkBoxWLUseDefaultIcon As CheckBox
    Private WithEvents TxtBoxWLStartUpDelay As TextBox
    Private WithEvents TxtBoxWLAutoRefreshInterval As TextBox
    Private WithEvents LVWL As ListView
    Private WithEvents TxtBoxWLAutoRefreshIdleInterval As TextBox
    Private WithEvents ChkBoxWLShowFilePathToolTips As CheckBox
    Private WithEvents ChkBoxWLAutoRefresh As CheckBox
    Private WithEvents ChkBoxWLShowFileInfoToolTips As CheckBox
    Private WithEvents ChkBoxWLShowFolderPathToolTips As CheckBox
    Private WithEvents BtnWLRefresh As Button
    Private WithEvents LblACOffHourChimePath As Label
    Private WithEvents BtnACOffHourChimeManual As Button
    Private WithEvents BtnACAlarmCancel As Button
    Private WithEvents LblACTopHourChimePath As Label
    Private WithEvents LblACAlarmChimePath As Label
    Private WithEvents ChkBoxACBottomHourAfterChimeEnabled As CheckBox
    Private WithEvents ChkBoxACFirstQuarterHourAfterChimeEnabled As CheckBox
    Private WithEvents ChkBoxACThirdQuarterHourBeforeChimeEnabled As CheckBox
    Private WithEvents ChkBoxACFirstQuarterHourBeforeChimeEnabled As CheckBox
    Private WithEvents ChkBoxACThirdQuarterHourAfterChimeEnabled As CheckBox
    Private WithEvents ChkBoxACBottomHourBeforeChimeEnabled As CheckBox
    Private WithEvents BtnACMute As Button
    Private WithEvents TxtBoxACAlarmTimer As TextBox
    Private WithEvents GrpBoxACTopHourChimeType As GroupBox
    Private WithEvents RadBtnACTopHourChimeSimple As RadioButton
    Private WithEvents RadBtnACTopHourChimeExtended As RadioButton
    Private WithEvents RadBtnACTopHourChimeHourTick As RadioButton
    Private WithEvents BtnACOffHourChimeDefault As Button
    Private WithEvents BtnACTopHourChimeDefault As Button
    Private WithEvents TxtBoxACAlarmTime As TextBox
    Private WithEvents BtnACTopHourChimeManual As Button
    Private WithEvents ChkBoxACThirdQuarterHourChimeEnabled As CheckBox
    Private WithEvents ChkBoxACBottomHourChimeEnabled As CheckBox
    Private WithEvents ChkBoxACFirstQuarterHourChimeEnabled As CheckBox
    Private WithEvents ChkBoxACTopHourAfterChimeEnabled As CheckBox
    Private WithEvents ChkBoxACTopHourChimeEnabled As CheckBox
    Private WithEvents ChkBoxACTopHourBeforeChimeEnabled As CheckBox
    Private WithEvents GrpBoxACAlarmChimeType As GroupBox
    Private WithEvents RadBtnACAlarmChimeSimple As RadioButton
    Private WithEvents RadBtnACAlarmChimeForever As RadioButton
    Private WithEvents RadBtnACAlarmChimeExtended As RadioButton
    Private WithEvents BtnACAlarmSet As Button
    Private WithEvents ChkBoxACAlarmRecurring As CheckBox
    Private WithEvents BtnACTopHourChimePlay As Button
    Private WithEvents BtnACOffHourChimePlay As Button
    Private WithEvents PicBoxACClock As PictureBox
    Private WithEvents BtnACAlarmChimeDefault As Button
    Private WithEvents BtnACAlarmChimePlay As Button
    Private WithEvents BtnACAlarmChimeManual As Button
    Friend WithEvents BtnSSEnabled As Button
    Friend WithEvents LblACOffHourChime As Skye.UI.Label
    Friend WithEvents LblACTopHourChime As Skye.UI.Label
    Friend WithEvents LblACAlarmChime As Skye.UI.Label
    Friend WithEvents LblACTimer As Skye.UI.Label
    Friend WithEvents LblACTime As Skye.UI.Label
    Private WithEvents CMLVWL As ContextMenuStrip
    Private WithEvents CMIWLMoveUp As ToolStripMenuItem
    Private WithEvents CMIWLMoveDown As ToolStripMenuItem
    Private WithEvents TSSWL1 As ToolStripSeparator
    Private WithEvents CMIWLNew As ToolStripMenuItem
    Private WithEvents TSSWL2 As ToolStripSeparator
    Private WithEvents CMIWLDelete As ToolStripMenuItem
    Friend WithEvents LblWLAutoRefresh As Skye.UI.Label
    Friend WithEvents LblWLAutoRefreshIdleInterval As Skye.UI.Label
    Friend WithEvents LblWLAutoRefreshInterval As Skye.UI.Label
    Friend WithEvents LblWLMaxLinksPerFolder As Skye.UI.Label
    Friend WithEvents LblWLStartUpDelay As Skye.UI.Label
    Friend WithEvents LblWLFolderPlacement As Skye.UI.Label
    Friend WithEvents LblWLFolderMode As Skye.UI.Label
    Friend WithEvents LblWLSortOrder As Skye.UI.Label
    Friend WithEvents LblWLDisplayName As Skye.UI.Label
    Friend WithEvents LblWLRoot As Skye.UI.Label
    Private WithEvents CoBoxHCRight As ComboBox
    Private WithEvents CoBoxHCMiddle As ComboBox
    Private WithEvents CoBoxHCDouble As ComboBox
    Private WithEvents CoBoxHCLeft As ComboBox
    Private WithEvents GrpBoxHC As GroupBox
    Private WithEvents RadBtnHCWL As RadioButton
    Private WithEvents RadBtnHCWSTSS As RadioButton
    Private WithEvents RadBtnHCWST As RadioButton
    Private WithEvents LblHCDouble As Label
    Private WithEvents LblHCLeft As Label
    Private WithEvents LblHCMiddle As Label
    Private WithEvents LblHCRight As Label
End Class