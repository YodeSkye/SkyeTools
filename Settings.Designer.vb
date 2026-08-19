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
        TxtBoxWLStartUpDelay = New TextBox()
        TxtBoxWLAutoRefreshInterval = New TextBox()
        LVWL = New ListView()
        CMLVWL = New ContextMenuStrip(components)
        cmiWLMoveUp = New ToolStripMenuItem()
        cmiWLMoveDown = New ToolStripMenuItem()
        toolStripSeparator11 = New ToolStripSeparator()
        cmiWLNew = New ToolStripMenuItem()
        toolStripSeparator6 = New ToolStripSeparator()
        cmiWLDelete = New ToolStripMenuItem()
        TxtBoxWLAutoRefreshIdleInterval = New TextBox()
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
        Label1 = New Skye.UI.Label()
        Label2 = New Skye.UI.Label()
        Label3 = New Skye.UI.Label()
        Label4 = New Skye.UI.Label()
        Label5 = New Skye.UI.Label()
        Label6 = New Skye.UI.Label()
        Label7 = New Skye.UI.Label()
        Label8 = New Skye.UI.Label()
        Label9 = New Skye.UI.Label()
        Label10 = New Skye.UI.Label()
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
        PanelWL.Controls.Add(Label5)
        PanelWL.Controls.Add(Label4)
        PanelWL.Controls.Add(Label3)
        PanelWL.Controls.Add(Label2)
        PanelWL.Controls.Add(Label1)
        PanelWL.Controls.Add(TxtBoxWLMaxLinksPerFolder)
        PanelWL.Controls.Add(PanelWLItem)
        PanelWL.Controls.Add(TxtBoxWLStartUpDelay)
        PanelWL.Controls.Add(TxtBoxWLAutoRefreshInterval)
        PanelWL.Controls.Add(LVWL)
        PanelWL.Controls.Add(TxtBoxWLAutoRefreshIdleInterval)
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
        PanelWLItem.Controls.Add(Label10)
        PanelWLItem.Controls.Add(Label9)
        PanelWLItem.Controls.Add(Label8)
        PanelWLItem.Controls.Add(Label7)
        PanelWLItem.Controls.Add(Label6)
        PanelWLItem.Controls.Add(checkboxWLShowNoMenu)
        PanelWLItem.Controls.Add(textboxWLName)
        PanelWLItem.Controls.Add(checkboxWLShowMenuIcons)
        PanelWLItem.Controls.Add(checkboxWLShowInTray)
        PanelWLItem.Controls.Add(checkboxWLShowInMenu)
        PanelWLItem.Controls.Add(comboboxWLFolderPlacement)
        PanelWLItem.Controls.Add(comboboxWLFolderMode)
        PanelWLItem.Controls.Add(comboboxWLSort)
        PanelWLItem.Controls.Add(textboxWLRoot)
        PanelWLItem.Controls.Add(btnWLSelectFolder)
        PanelWLItem.Controls.Add(btnWLCancel)
        PanelWLItem.Controls.Add(btnWLSet)
        PanelWLItem.Controls.Add(checkboxWLUseDefaultIcon)
        PanelWLItem.Controls.Add(LblWLSortOrder)
        PanelWLItem.Controls.Add(LblWLFolderMode)
        PanelWLItem.Controls.Add(LblWLFolderPlacement)
        PanelWLItem.Controls.Add(LblWLDisplayName)
        PanelWLItem.Controls.Add(lblWLRoot)
        TipInfoEX.SetImage(PanelWLItem, Nothing)
        PanelWLItem.Location = New Point(13, 318)
        PanelWLItem.Name = "PanelWLItem"
        PanelWLItem.Size = New Size(706, 205)
        PanelWLItem.TabIndex = 200
        TipInfoEX.SetText(PanelWLItem, Nothing)
        PanelWLItem.Visible = False
        ' 
        ' checkboxWLShowNoMenu
        ' 
        checkboxWLShowNoMenu.AutoSize = True
        TipInfoEX.SetImage(checkboxWLShowNoMenu, Nothing)
        checkboxWLShowNoMenu.Location = New Point(546, 107)
        checkboxWLShowNoMenu.Name = "checkboxWLShowNoMenu"
        checkboxWLShowNoMenu.Size = New Size(136, 25)
        checkboxWLShowNoMenu.TabIndex = 50
        TipInfoEX.SetText(checkboxWLShowNoMenu, Nothing)
        checkboxWLShowNoMenu.Text = "No Menu Items"
        checkboxWLShowNoMenu.UseVisualStyleBackColor = True
        ' 
        ' textboxWLName
        ' 
        textboxWLName.ContextMenuStrip = CMBlankForTextBoxes
        TipInfoEX.SetImage(textboxWLName, Nothing)
        textboxWLName.Location = New Point(8, 79)
        textboxWLName.Name = "textboxWLName"
        textboxWLName.Size = New Size(463, 29)
        textboxWLName.TabIndex = 15
        TipInfoEX.SetText(textboxWLName, Nothing)
        ' 
        ' checkboxWLShowMenuIcons
        ' 
        checkboxWLShowMenuIcons.AutoSize = True
        TipInfoEX.SetImage(checkboxWLShowMenuIcons, Nothing)
        checkboxWLShowMenuIcons.Location = New Point(546, 88)
        checkboxWLShowMenuIcons.Name = "checkboxWLShowMenuIcons"
        checkboxWLShowMenuIcons.Size = New Size(152, 25)
        checkboxWLShowMenuIcons.TabIndex = 40
        TipInfoEX.SetText(checkboxWLShowMenuIcons, Nothing)
        checkboxWLShowMenuIcons.Text = "Show Menu Icons"
        checkboxWLShowMenuIcons.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowInTray
        ' 
        checkboxWLShowInTray.AutoSize = True
        TipInfoEX.SetImage(checkboxWLShowInTray, Nothing)
        checkboxWLShowInTray.Location = New Point(546, 57)
        checkboxWLShowInTray.Name = "checkboxWLShowInTray"
        checkboxWLShowInTray.Size = New Size(118, 25)
        checkboxWLShowInTray.TabIndex = 30
        TipInfoEX.SetText(checkboxWLShowInTray, Nothing)
        checkboxWLShowInTray.Text = "Show In Tray"
        checkboxWLShowInTray.UseVisualStyleBackColor = True
        ' 
        ' checkboxWLShowInMenu
        ' 
        checkboxWLShowInMenu.AutoSize = True
        TipInfoEX.SetImage(checkboxWLShowInMenu, Nothing)
        checkboxWLShowInMenu.Location = New Point(546, 37)
        checkboxWLShowInMenu.Name = "checkboxWLShowInMenu"
        checkboxWLShowInMenu.Size = New Size(129, 25)
        checkboxWLShowInMenu.TabIndex = 25
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
        comboboxWLFolderPlacement.TabIndex = 80
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
        comboboxWLFolderMode.TabIndex = 70
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
        comboboxWLSort.TabIndex = 60
        TipInfoEX.SetText(comboboxWLSort, Nothing)
        ' 
        ' textboxWLRoot
        ' 
        textboxWLRoot.ContextMenuStrip = CMBlankForTextBoxes
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
        btnWLCancel.ForeColor = Color.Navy
        btnWLCancel.Image = My.Resources.Resources.imageRemove
        TipInfoEX.SetImage(btnWLCancel, Nothing)
        btnWLCancel.ImageAlign = ContentAlignment.MiddleLeft
        btnWLCancel.Location = New Point(522, 162)
        btnWLCancel.Name = "btnWLCancel"
        btnWLCancel.Size = New Size(100, 32)
        btnWLCancel.TabIndex = 100
        TipInfoEX.SetText(btnWLCancel, Nothing)
        btnWLCancel.Text = "Cancel"
        btnWLCancel.TextAlign = ContentAlignment.MiddleRight
        btnWLCancel.UseVisualStyleBackColor = True
        ' 
        ' btnWLSet
        ' 
        btnWLSet.ForeColor = Color.Navy
        btnWLSet.Image = My.Resources.Resources.imageGoStart
        TipInfoEX.SetImage(btnWLSet, Nothing)
        btnWLSet.ImageAlign = ContentAlignment.MiddleLeft
        btnWLSet.Location = New Point(628, 162)
        btnWLSet.Name = "btnWLSet"
        btnWLSet.Size = New Size(66, 32)
        btnWLSet.TabIndex = 110
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
        checkboxWLUseDefaultIcon.TabIndex = 20
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
        CMLVWL.Items.AddRange(New ToolStripItem() {cmiWLMoveUp, cmiWLMoveDown, toolStripSeparator11, cmiWLNew, toolStripSeparator6, cmiWLDelete})
        CMLVWL.Name = "contextmenulistviewHotLinks"
        CMLVWL.Size = New Size(125, 120)
        TipInfoEX.SetText(CMLVWL, Nothing)
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
        checkboxWLShowFilePathToolTips.TabIndex = 30
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
        checkboxWLAutoRefresh.TabIndex = 80
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
        checkboxWLShowFileInfoToolTips.TabIndex = 50
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
        checkboxWLShowFolderPathToolTips.TabIndex = 40
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
        btnWLRefresh.TabIndex = 100
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
        ' Label1
        ' 
        Label1.AutoSize = True
        TipInfoEX.SetImage(Label1, Nothing)
        Label1.Location = New Point(228, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 21)
        Label1.TabIndex = 201
        Label1.Text = "StartUp Delay"
        TipInfoEX.SetText(Label1, "5-300, 0 = No Delay")
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        TipInfoEX.SetImage(Label2, Nothing)
        Label2.Location = New Point(204, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(199, 21)
        Label2.TabIndex = 202
        Label2.Text = "Max Menu Items Per Folder"
        TipInfoEX.SetText(Label2, "1-100")
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        TipInfoEX.SetImage(Label3, Nothing)
        Label3.Location = New Point(348, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 21)
        Label3.TabIndex = 203
        Label3.Text = "AutoRefresh Interval"
        TipInfoEX.SetText(Label3, "Check For Changes Every 1-90 Minutes")
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        TipInfoEX.SetImage(Label4, Nothing)
        Label4.Location = New Point(282, 53)
        Label4.Name = "Label4"
        Label4.Size = New Size(181, 21)
        Label4.TabIndex = 204
        Label4.Text = "AutoRefresh Idle Interval"
        TipInfoEX.SetText(Label4, "Refresh Only When Folder Idle For 20-240 Seconds")
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        TipInfoEX.SetImage(Label5, Nothing)
        Label5.Location = New Point(472, 143)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 21)
        Label5.TabIndex = 205
        Label5.Text = "AutoRefresh Engaged"
        TipInfoEX.SetText(Label5, Nothing)
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        TipInfoEX.SetImage(Label6, Nothing)
        Label6.Location = New Point(209, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 169
        Label6.Text = "Label6"
        TipInfoEX.SetText(Label6, Nothing)
        ' 
        ' Label7
        ' 
        TipInfoEX.SetImage(Label7, Nothing)
        Label7.Location = New Point(187, 56)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 23)
        Label7.TabIndex = 170
        Label7.Text = "Label7"
        TipInfoEX.SetText(Label7, Nothing)
        ' 
        ' Label8
        ' 
        TipInfoEX.SetImage(Label8, Nothing)
        Label8.Location = New Point(14, 123)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 171
        Label8.Text = "Label8"
        TipInfoEX.SetText(Label8, Nothing)
        ' 
        ' Label9
        ' 
        TipInfoEX.SetImage(Label9, Nothing)
        Label9.Location = New Point(155, 121)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 172
        Label9.Text = "Label9"
        TipInfoEX.SetText(Label9, Nothing)
        ' 
        ' Label10
        ' 
        TipInfoEX.SetImage(Label10, Nothing)
        Label10.Location = New Point(304, 118)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 23)
        Label10.TabIndex = 173
        Label10.Text = "Label10"
        TipInfoEX.SetText(Label10, Nothing)
        ' 
        ' Settings
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        AutoValidate = AutoValidate.EnableAllowFocusChange
        ClientSize = New Size(917, 630)
        Controls.Add(PanelWL)
        Controls.Add(PanelAC)
        Controls.Add(PanelSS)
        Controls.Add(PanelApp)
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
    Private WithEvents TxtBoxWLStartUpDelay As TextBox
    Private WithEvents TxtBoxWLAutoRefreshInterval As TextBox
    Private WithEvents LVWL As ListView
    Private WithEvents TxtBoxWLAutoRefreshIdleInterval As TextBox
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
    Private WithEvents cmiWLMoveUp As ToolStripMenuItem
    Private WithEvents cmiWLMoveDown As ToolStripMenuItem
    Private WithEvents toolStripSeparator11 As ToolStripSeparator
    Private WithEvents cmiWLNew As ToolStripMenuItem
    Private WithEvents toolStripSeparator6 As ToolStripSeparator
    Private WithEvents cmiWLDelete As ToolStripMenuItem
    Friend WithEvents Label5 As Skye.UI.Label
    Friend WithEvents Label4 As Skye.UI.Label
    Friend WithEvents Label3 As Skye.UI.Label
    Friend WithEvents Label2 As Skye.UI.Label
    Friend WithEvents Label1 As Skye.UI.Label
    Friend WithEvents Label10 As Skye.UI.Label
    Friend WithEvents Label9 As Skye.UI.Label
    Friend WithEvents Label8 As Skye.UI.Label
    Friend WithEvents Label7 As Skye.UI.Label
    Friend WithEvents Label6 As Skye.UI.Label
End Class