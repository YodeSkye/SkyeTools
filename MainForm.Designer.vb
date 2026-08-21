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
        TipHCEX = New Skye.UI.ToolTipEX(components)
        cmWST.SuspendLayout()
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
        ' TipHCEX
        ' 
        TipHCEX.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TipHCEX.ShadowAlpha = 0
        TipHCEX.ShadowThickness = 0
        ' 
        ' MainForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(284, 261)
        TipHCEX.SetImage(Me, Nothing)
        TipInfoEX.SetImage(Me, Nothing)
        Name = "MainForm"
        Opacity = 0R
        StartPosition = FormStartPosition.Manual
        TipInfoEX.SetText(Me, Nothing)
        TipHCEX.SetText(Me, Nothing)
        cmWST.ResumeLayout(False)
        cmWSTScreenSaver.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cmiWSTClock As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmseparatorWSTWLBottom As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cmseparatorWSTWLTop As System.Windows.Forms.ToolStripSeparator
    Private cmseparatorWSTTopSpacer As System.Windows.Forms.ToolStripSeparator
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
    Private WithEvents cmWST As System.Windows.Forms.ContextMenuStrip
    Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TipHCEX As Skye.UI.ToolTipEX
    Friend WithEvents TipInfoEX As Skye.UI.ToolTipEX
End Class