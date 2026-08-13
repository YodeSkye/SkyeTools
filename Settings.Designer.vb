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
        btnClose = New Button()
        btnSaveSettings = New Button()
        btnRestoreSettings = New Button()
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
        btnErrorTest = New Button()
        btnHelp = New Button()
        btnLog = New Button()
        PanelApp = New Panel()
        PanelPics = New Panel()
        PanelVids = New Panel()
        PanelActions = New Panel()
        PanelPageSelector = New Panel()
        LVPageSelector = New Skye.UI.ListViewEX()
        ILPageSelector = New ImageList(components)
        TipInfoEX = New Skye.UI.ToolTipEX(components)
        PanelActions.SuspendLayout()
        PanelPageSelector.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnClose.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Image = My.Resources.Resources.ImageOK
        TipInfoEX.SetImage(btnClose, Nothing)
        btnClose.Location = New Point(426, 16)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(64, 64)
        btnClose.TabIndex = 0
        TipInfoEX.SetText(btnClose, "Close Window")
        btnClose.TextAlign = ContentAlignment.MiddleRight
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnSaveSettings
        ' 
        btnSaveSettings.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSaveSettings.Image = My.Resources.Resources.ImageSave32
        TipInfoEX.SetImage(btnSaveSettings, My.Resources.Resources.ImageSave16)
        btnSaveSettings.Location = New Point(12, 24)
        btnSaveSettings.Name = "btnSaveSettings"
        btnSaveSettings.Size = New Size(48, 48)
        btnSaveSettings.TabIndex = 100
        TipInfoEX.SetText(btnSaveSettings, "Save All Settings")
        btnSaveSettings.TextAlign = ContentAlignment.BottomRight
        btnSaveSettings.UseVisualStyleBackColor = True
        ' 
        ' btnRestoreSettings
        ' 
        btnRestoreSettings.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnRestoreSettings.Image = My.Resources.Resources.ImageUndo32
        TipInfoEX.SetImage(btnRestoreSettings, My.Resources.Resources.ImageUndo16)
        btnRestoreSettings.Location = New Point(73, 24)
        btnRestoreSettings.Name = "btnRestoreSettings"
        btnRestoreSettings.Size = New Size(48, 48)
        btnRestoreSettings.TabIndex = 101
        TipInfoEX.SetText(btnRestoreSettings, "Restore All Settings")
        btnRestoreSettings.TextAlign = ContentAlignment.BottomRight
        btnRestoreSettings.UseVisualStyleBackColor = True
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
        ' btnErrorTest
        ' 
        btnErrorTest.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnErrorTest.FlatAppearance.BorderColor = SystemColors.ControlDark
        btnErrorTest.FlatAppearance.BorderSize = 0
        btnErrorTest.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnErrorTest.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnErrorTest.Image = My.Resources.Resources.ImageError32
        TipInfoEX.SetImage(btnErrorTest, My.Resources.Resources.ImageError16)
        btnErrorTest.Location = New Point(216, 24)
        btnErrorTest.Name = "btnErrorTest"
        btnErrorTest.Size = New Size(48, 48)
        btnErrorTest.TabIndex = 0
        btnErrorTest.TabStop = False
        TipInfoEX.SetText(btnErrorTest, "LeftClick = Test Error" & vbCrLf & "RightClick = Cause Exception")
        btnErrorTest.Visible = False
        ' 
        ' btnHelp
        ' 
        btnHelp.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnHelp.Image = My.Resources.Resources.imageInfo32
        TipInfoEX.SetImage(btnHelp, My.Resources.Resources.ImageInfo16)
        btnHelp.Location = New Point(796, 24)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(48, 48)
        btnHelp.TabIndex = 105
        TipInfoEX.SetText(btnHelp, "Show Help & About")
        btnHelp.TextAlign = ContentAlignment.BottomRight
        btnHelp.UseVisualStyleBackColor = True
        ' 
        ' btnLog
        ' 
        btnLog.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLog.Image = My.Resources.Resources.ImageLog32
        TipInfoEX.SetImage(btnLog, My.Resources.Resources.imageLog)
        btnLog.Location = New Point(857, 24)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(48, 48)
        btnLog.TabIndex = 106
        TipInfoEX.SetText(btnLog, "Show Log")
        btnLog.TextAlign = ContentAlignment.BottomRight
        btnLog.UseVisualStyleBackColor = True
        ' 
        ' PanelApp
        ' 
        PanelApp.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelApp, Nothing)
        PanelApp.Location = New Point(91, 0)
        PanelApp.Name = "PanelApp"
        PanelApp.Size = New Size(826, 534)
        PanelApp.TabIndex = 107
        TipInfoEX.SetText(PanelApp, Nothing)
        ' 
        ' PanelPics
        ' 
        PanelPics.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelPics, Nothing)
        PanelPics.Location = New Point(91, 0)
        PanelPics.Name = "PanelPics"
        PanelPics.Size = New Size(826, 534)
        PanelPics.TabIndex = 108
        TipInfoEX.SetText(PanelPics, Nothing)
        ' 
        ' PanelVids
        ' 
        PanelVids.Dock = DockStyle.Fill
        TipInfoEX.SetImage(PanelVids, Nothing)
        PanelVids.Location = New Point(91, 0)
        PanelVids.Name = "PanelVids"
        PanelVids.Size = New Size(826, 534)
        PanelVids.TabIndex = 109
        TipInfoEX.SetText(PanelVids, Nothing)
        ' 
        ' PanelActions
        ' 
        PanelActions.Controls.Add(btnClose)
        PanelActions.Controls.Add(btnRestoreSettings)
        PanelActions.Controls.Add(btnSaveSettings)
        PanelActions.Controls.Add(btnErrorTest)
        PanelActions.Controls.Add(btnHelp)
        PanelActions.Controls.Add(btnLog)
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
        PanelPageSelector.Size = New Size(91, 534)
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
        LVPageSelector.Size = New Size(91, 534)
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
        ' Settings
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        AutoValidate = AutoValidate.EnableAllowFocusChange
        ClientSize = New Size(917, 630)
        Controls.Add(PanelApp)
        Controls.Add(PanelVids)
        Controls.Add(PanelPics)
        Controls.Add(PanelPageSelector)
        Controls.Add(PanelActions)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = My.Resources.Resources.iconApp
        TipInfoEX.SetImage(Me, Nothing)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Settings"
        Opacity = 0R
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        TipInfoEX.SetText(Me, Nothing)
        PanelActions.ResumeLayout(False)
        PanelPageSelector.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnLog As System.Windows.Forms.Button
    Private WithEvents btnHelp As System.Windows.Forms.Button
    Private WithEvents btnErrorTest As System.Windows.Forms.Button
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
    Private WithEvents btnRestoreSettings As System.Windows.Forms.Button
    Private WithEvents btnSaveSettings As System.Windows.Forms.Button
    Friend WithEvents PanelApp As Panel
    Friend WithEvents PanelPics As Panel
    Friend WithEvents PanelVids As Panel
    Friend WithEvents PanelActions As Panel
    Friend WithEvents PanelPageSelector As Panel
    Friend WithEvents LVPageSelector As Skye.UI.ListViewEX
    Friend WithEvents ILPageSelector As ImageList
    Friend WithEvents TipInfoEX As Skye.UI.ToolTipEX
End Class