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
        PanelWST = New Panel()
        PanelSS = New Panel()
        PanelActions = New Panel()
        PanelPageSelector = New Panel()
        LVPageSelector = New Skye.UI.ListViewEX()
        ILPageSelector = New ImageList(components)
        TipInfoEX = New Skye.UI.ToolTipEX(components)
        PanelAC = New Panel()
        PanelWL = New Panel()
        PanelHC = New Panel()
        PanelHK = New Panel()
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
        PanelApp.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelApp, Nothing)
        PanelApp.Location = New Point(187, 0)
        PanelApp.Name = "PanelApp"
        PanelApp.Size = New Size(730, 534)
        PanelApp.TabIndex = 107
        TipInfoEX.SetText(PanelApp, Nothing)
        ' 
        ' PanelWST
        ' 
        PanelWST.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelWST, Nothing)
        PanelWST.Location = New Point(187, 0)
        PanelWST.Name = "PanelWST"
        PanelWST.Size = New Size(730, 534)
        PanelWST.TabIndex = 108
        TipInfoEX.SetText(PanelWST, Nothing)
        ' 
        ' PanelSS
        ' 
        PanelSS.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelSS, Nothing)
        PanelSS.Location = New Point(187, 0)
        PanelSS.Name = "PanelSS"
        PanelSS.Size = New Size(730, 534)
        PanelSS.TabIndex = 109
        TipInfoEX.SetText(PanelSS, Nothing)
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
        Controls.Add(PanelHK)
        Controls.Add(PanelHC)
        Controls.Add(PanelWL)
        Controls.Add(PanelAC)
        Controls.Add(PanelApp)
        Controls.Add(PanelSS)
        Controls.Add(PanelWST)
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
End Class