
Imports System.ComponentModel
Imports System.Data.Common
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports Microsoft.VisualBasic.Devices
Imports SkyeTools.My

Partial Friend Class MainForm

#Region "Settings"

    ' Declarations
    Private imagelisttabcontrolSettings As ImageList

    ' Control Events
    Private Sub TabcontrolSettingsSelected(ByVal sender As Object, ByVal e As TabControlEventArgs) Handles tabcontrolSettings.Selected
        If Me.tabcontrolSettings.SelectedTab Is Me.tabpageHK Then ShowSettings(My.App.Tools.HotKeys)
    End Sub
    Private Sub BtnSettingsSaveClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnSettingsSave.Click
        My.App.SaveSettings()
        Me.Hide()
    End Sub

    ' Methods
    Private Overloads Sub ShowSettings()
        UpdateWST()
        Me.SuspendLayout()
        ShowSettingsHC()
        ShowSettingsHK()
        Me.ResumeLayout()
        Me.btnClose.Select()
    End Sub
    Private Overloads Sub ShowSettings(tool As My.App.Tools)
        If tool = My.App.Tools.SkyeTools Then : ShowSettings()
        Else
            UpdateWST()
            Me.SuspendLayout()

            Select Case tool
                Case My.App.Tools.HotClicks : ShowSettingsHC()
                Case My.App.Tools.HotKeys : ShowSettingsHK()
            End Select
            Me.ResumeLayout()
            Me.btnClose.Select()
        End If
    End Sub
    Private Sub ShowSettingsHC()
        Me.comboboxHCLeft.Items.Clear()
        Me.comboboxHCDouble.Items.Clear()
        Me.comboboxHCMiddle.Items.Clear()
        Me.comboboxHCRight.Items.Clear()

        For Each action As My.App.HCActionType In My.App.HCActions
            If Not action.Name = My.App.HCAction.Menu Then Me.comboboxHCLeft.Items.Add(action.Description)
            If Not action.Name = My.App.HCAction.Menu Then Me.comboboxHCDouble.Items.Add(action.Description)
            If Not action.Name = My.App.HCAction.Menu Then Me.comboboxHCMiddle.Items.Add(action.Description)
            Me.comboboxHCRight.Items.Add(action.Description)
        Next
        Me.radiobtnHCWST.Checked = True
        HCShowActions(My.App.TrayTools.WorkSpaceTools)
    End Sub
    Private Sub ShowSettingsHK()
        Me.lblHKWSTLockWorkSpace.Text = My.App.HKWSTLockWorkSpace.Description
        Me.textboxHKWSTLockWorkSpace.Text = My.App.HKWSTLockWorkSpace.Key.ToString
        Me.textboxHKWSTLockWorkSpace.Tag = My.App.HKWSTLockWorkSpace
        Me.textboxHKWSTLockWorkSpace.Font = New Font(Me.Font, FontStyle.Bold)
        Me.textboxHKWSTLockWorkSpace.ForeColor = Color.Teal
        Me.lblHKWSTScreenSaver.Text = My.App.HKWSTScreenSaver.Description
        Me.textboxHKWSTScreenSaver.Text = My.App.HKWSTScreenSaver.Key.ToString
        Me.textboxHKWSTScreenSaver.Tag = My.App.HKWSTScreenSaver
        Me.textboxHKWSTScreenSaver.Font = New Font(Me.Font, FontStyle.Bold)
        Me.textboxHKWSTScreenSaver.ForeColor = Color.Teal
        Me.lblHKWSTClock.Text = My.App.HKWSTClock.Description
        Me.textboxHKWSTClock.Text = My.App.HKWSTClock.Key.ToString
        Me.textboxHKWSTClock.Tag = My.App.HKWSTClock
        Me.textboxHKWSTClock.Font = New Font(Me.Font, FontStyle.Bold)
        Me.textboxHKWSTClock.ForeColor = Color.Teal
        Me.lblHKWL.Text = My.App.HKWL.Description
        Me.textboxHKWL.Text = My.App.HKWL.Key.ToString
        Me.textboxHKWL.Tag = My.App.HKWL
        Me.textboxHKWL.Font = New Font(Me.Font, FontStyle.Bold)
        Me.textboxHKWL.ForeColor = Color.Teal
        Me.btnHKReset.Enabled = False
        Me.btnHKSet.Enabled = False
        If My.App.HKEnabled Then
            If My.App.WSTShowLockWorkSpace Then : Me.lblHKWSTLockWorkSpace.Enabled = True
            Else : Me.lblHKWSTLockWorkSpace.Enabled = False
            End If
            Me.textboxHKWSTLockWorkSpace.Enabled = True
            Me.btnHKWSTLockWorkSpaceDisable.Enabled = True
            If My.App.WSTShowSSActivate Or My.App.WSTShowSSEnabled Or My.App.WSTShowSSIcon Then : Me.lblHKWSTScreenSaver.Enabled = True
            Else : Me.lblHKWSTScreenSaver.Enabled = False
            End If
            Me.textboxHKWSTScreenSaver.Enabled = True
            Me.btnHKWSTScreenSaverDisable.Enabled = True
            If My.App.WSTShowClock Then : Me.lblHKWSTClock.Enabled = True
            Else : Me.lblHKWSTClock.Enabled = False
            End If
            Me.textboxHKWSTClock.Enabled = True
            Me.btnHKWSTClockDisable.Enabled = True
            If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then : Me.lblHKWL.Enabled = True
            Else : Me.lblHKWL.Enabled = False
            End If
            Me.textboxHKWL.Enabled = True
            Me.btnHKWLDisable.Enabled = True
            Me.btnHKEnabled.Text = "Disable"
            Me.btnHKEnabled.Image = My.Resources.Resources.imageHKDisable 'DirectCast(My.App.AppResources.GetObject("imageHKDisable"), Image)
        Else
            Me.lblHKWSTLockWorkSpace.Enabled = False
            Me.textboxHKWSTLockWorkSpace.Enabled = False
            Me.btnHKWSTLockWorkSpaceDisable.Enabled = False
            Me.lblHKWSTScreenSaver.Enabled = False
            Me.textboxHKWSTScreenSaver.Enabled = False
            Me.btnHKWSTScreenSaverDisable.Enabled = False
            Me.lblHKWSTStopWatch.Enabled = False
            Me.lblHKWSTClock.Enabled = False
            Me.textboxHKWSTClock.Enabled = False
            Me.btnHKWSTClockDisable.Enabled = False
            Me.lblHKWL.Enabled = False
            Me.textboxHKWL.Enabled = False
            Me.btnHKWLDisable.Enabled = False
            Me.btnHKEnabled.Text = "Enable"
            Me.btnHKEnabled.Image = My.Resources.Resources.imageHKEnable 'DirectCast(My.App.AppResources.GetObject("imageHKEnable"), Image)
        End If
    End Sub
    Private Sub SelectTab(ByRef tabpage As System.Windows.Forms.TabPage, Optional forcevisible As Boolean = False)
        If tabpage Is Nothing Then
            If Me.Visible Then
                If Me.WindowState = FormWindowState.Minimized Then : Me.WindowState = FormWindowState.Normal
                Else : If Not forcevisible Then Me.Hide()
                End If
            Else : Me.Show()
            End If
        Else
            If Me.Visible Then
                If Me.tabcontrolSettings.SelectedTab.Equals(tabpage) AndAlso Me.WindowState = FormWindowState.Normal AndAlso Not forcevisible Then : Me.Hide()
                Else
                    If Not Me.WindowState = FormWindowState.Normal Then Me.WindowState = FormWindowState.Normal
                    UpdateWST()

                    Try : Me.tabcontrolSettings.SelectTab(tabpage) : Catch : End Try
                End If
            Else
                Try : Me.tabcontrolSettings.SelectTab(tabpage) : Catch : End Try
                Me.Show()
            End If
        End If
        If Me.Visible Then
            Me.Activate()
            Me.btnClose.Focus()
        End If
    End Sub

#End Region
#Region "WorkSpace Tools (WST)"

    ' Declarations
    Private notifyiconWST As NotifyIcon
    Private notifyiconWSTScreenSaver As NotifyIcon

    ' Control Events
    Private Sub CMIWSTCancelStartUpMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTCancelStartUp.MouseUp
        If e.Button = MouseButtons.Left Then
            If Me.TimerWLStartUp.Enabled Then
                Me.TimerWLStartUp.Stop()
                WLStartUp = False
                WLClose(True)
                WLSetSettingsState(True)
            End If
            UpdateWSTCancelState()
        End If
    End Sub
    Private Sub CMIWSTClockMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTClock.MouseUp
        If e.Button = MouseButtons.Left Then App.ShowClock()
    End Sub
    Private Sub CMIWSTLockMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTLock.MouseUp
        If e.Button = MouseButtons.Left Then WSTLockWorkSpace()
    End Sub
    Private Sub CMIWSTLogOffMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTLogOff.MouseUp
        If e.Button = MouseButtons.Left Then
            My.App.WriteToLog(App.Tools.WorkSpaceTools, "System Log Off Initiated")
            My.App.ShowMessage(App.Tools.WorkSpaceTools, "Logging Off...", Nothing)
            System.Diagnostics.Process.Start("ShutDown", "/l")
        End If
    End Sub
    Private Sub CMIWSTSleepMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTSleep.MouseUp
        If e.Button = MouseButtons.Left Then
            App.ShowMessage(App.Tools.WorkSpaceTools, "Standing By...", Nothing)
            System.Windows.Forms.Application.SetSuspendState(System.Windows.Forms.PowerState.Suspend, False, False)
        End If
    End Sub
    Private Sub CMIWSTHibernateMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTHibernate.MouseUp
        If e.Button = MouseButtons.Left Then
            App.ShowMessage(App.Tools.WorkSpaceTools, "Hibernating...", Nothing)
            System.Windows.Forms.Application.SetSuspendState(System.Windows.Forms.PowerState.Hibernate, False, False)
        End If
    End Sub
    Private Sub CMIWSTReStartMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTReStart.MouseUp
        If e.Button = MouseButtons.Left Then
            App.WriteToLog(App.Tools.WorkSpaceTools, "System ReStart Initiated")
            App.ShowMessage(App.Tools.WorkSpaceTools, "ReStarting...", Nothing)
            System.Diagnostics.Process.Start("ShutDown", "/r /t 0")
        End If
    End Sub
    Private Sub CMIWSTShutDownMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTShutDown.MouseUp
        If e.Button = MouseButtons.Left Then
            App.WriteToLog(App.Tools.WorkSpaceTools, "System Shut Down Initiated")
            App.ShowMessage(App.Tools.WorkSpaceTools, "Shutting Down...", Nothing)
            System.Diagnostics.Process.Start("ShutDown", "/s /t 0")
        End If
    End Sub
    Private Sub CMIWSTHelp_MouseUp(sender As Object, e As MouseEventArgs) Handles cmiWSTHelp.MouseUp
        Select Case e.Button
            Case MouseButtons.Left : My.App.ShowHelp(False)
            Case MouseButtons.Right : My.App.ShowHelp(True)
        End Select
    End Sub
    Private Sub CMIWSTLog_MouseUp(sender As Object, e As MouseEventArgs) Handles cmiWSTLog.MouseUp
        Select Case e.Button
            Case MouseButtons.Left : App.ShowLog(False)
            Case MouseButtons.Right : App.ShowLog(True)
        End Select
        If App.ErrorAlert Then App.ClearErrorAlert()
    End Sub

    Private Sub CMIWSTSettingsMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTSettings.MouseUp, cmiScreenSaverSettings.MouseUp
        If e.Button = MouseButtons.Left Then SelectTab(Me.tabpageWST, True)
    End Sub
    Private Sub CMIWSTCloseMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTClose.MouseUp
        If e.Button = MouseButtons.Left Then
            My.App.WSTEnabled = False
            ShowTools()
            ShowSettings()
        End If
    End Sub

    ' Methods
    Friend Sub UpdateWST()
        If My.App.WSTEnabled Then
            Me.notifyiconWST.Icon = My.Resources.Resources.IconWST
            Me.notifyiconWST.Text = My.App.WSTName
            Me.cmiWSTLog.ToolTipText = "RightClick = Show Maximized"
            Me.cmiWSTLog.ResetFont()
            Me.cmiWSTLog.ResetForeColor()
            If App.ErrorAlert Then
                Me.notifyiconWST.Text += Chr(13) + "** ERROR **"
                Me.notifyiconWST.Icon = My.Resources.Resources.IconWSTAlert
                Me.cmiWSTLog.Font = App.MenuFontBold
                Me.cmiWSTLog.ForeColor = Color.Firebrick
                Me.cmiWSTLog.ToolTipText += Chr(13) + "An Application Error Has Occured. View Log For Details."
            End If
            If My.App.WSTSSToolEnabled Then
                If WSTSSEnabled Then
                    If My.App.WSTShowSSEnabled Then Me.notifyiconWST.Text += Chr(13) + "Screen Saver ENABLED"
                Else
                    If My.App.WSTShowSSEnabled Then Me.notifyiconWST.Text += Chr(13) + "Screen Saver DISABLED"
                End If
            End If
            If ACAlarmTripped And ACChimeCount = Byte.MaxValue Then
                Me.notifyiconWST.Text &= Environment.NewLine & "** ALARM **"
                Me.notifyiconWST.Icon = My.Resources.Resources.IconWSTAlert
                Me.cmiWSTAC.ToolTipText = "THE ALARM HAS SOUNDED"
                Me.cmiWSTAC.Checked = True
                Me.cmiWSTAC.Font = App.MenuFontBold
            ElseIf ACAlarmActive Then
                Dim alarmText As String = My.App.ACAlarmTime.ToString()
                Dim prefix As String = String.Concat(Me.notifyiconWST.Text, Environment.NewLine, "Alarm Set for ")
                Me.notifyiconWST.Text = String.Concat(prefix, alarmText.AsSpan(0, alarmText.Length - 3))
                Me.cmiWSTAC.ToolTipText = String.Concat("Alarm Set for ", alarmText.AsSpan(0, alarmText.Length - 3))
                Me.cmiWSTAC.Checked = True
                Me.cmiWSTAC.Font = App.MenuFont
            Else
                Me.cmiWSTAC.ToolTipText = Nothing
                Me.cmiWSTAC.Checked = False
                Me.cmiWSTAC.Font = App.MenuFont
            End If
            If App.FrmClock?.IsVisible Then
                Me.cmiWSTClock.Checked = True
            Else
                Me.cmiWSTClock.Checked = False
            End If
        End If
    End Sub
    Private Sub UpdateWSTCancelState()
        If Not WLStartUp Then Me.cmiWSTCancelStartUp.Visible = False
        If Not WLStartUp And Not BackgroundworkerAC.IsBusy Then Me.cmseparatorWSTCancel.Visible = False
        If Not BackgroundworkerAC.IsBusy Then Me.cmiWSTACAlarmCancel.Visible = False
        UpdateWST()
    End Sub
    Friend Sub ShowWST()
        'Main Section
        If My.App.WSTSSToolEnabled And My.App.WSTShowSSEnabled Then : Me.cmiWSTScreenSaverEnabled.Visible = True
        Else : Me.cmiWSTScreenSaverEnabled.Visible = False
        End If
        If My.App.WSTSSToolEnabled And My.App.WSTShowSSActivate Then : Me.cmiWSTScreenSaverActivate.Visible = True
        Else : Me.cmiWSTScreenSaverActivate.Visible = False
        End If
        If My.App.WSTShowWLMenu Then
            If (My.App.WSTSSToolEnabled And My.App.WSTShowSSEnabled) OrElse (My.App.WSTSSToolEnabled And My.App.WSTShowSSActivate) Then : Me.cmseparatorWSTWLTop.Visible = True
            Else : Me.cmseparatorWSTWLTop.Visible = False
            End If
            If My.App.WSTShowClock OrElse My.App.WSTShowAC Then : Me.cmseparatorWSTWLBottom.Visible = True
            Else : Me.cmseparatorWSTWLBottom.Visible = False
            End If
        Else
            Me.cmseparatorWSTWLTop.Visible = False
            Me.cmseparatorWSTWLBottom.Visible = False
        End If
        If My.App.WSTShowClock Then : Me.cmiWSTClock.Visible = True
        Else : Me.cmiWSTClock.Visible = False
        End If
        If My.App.WSTShowAC Then : Me.cmiWSTAC.Visible = True
        Else : Me.cmiWSTAC.Visible = False
        End If
        'ShutDown Options Section
        If My.App.WSTShowLockWorkSpace Then : Me.cmiWSTLock.Visible = True
        Else : Me.cmiWSTLock.Visible = False
        End If
        If My.App.WSTShowLogOff Then : Me.cmiWSTLogOff.Visible = True
        Else : Me.cmiWSTLogOff.Visible = False
        End If
        If My.App.WSTShowSleep Then : Me.cmiWSTSleep.Visible = True
        Else : Me.cmiWSTSleep.Visible = False
        End If
        If My.App.WSTShowHibernate Then : Me.cmiWSTHibernate.Visible = True
        Else : Me.cmiWSTHibernate.Visible = False
        End If
        If My.App.WSTShowReStart Then : Me.cmiWSTReStart.Visible = True
        Else : Me.cmiWSTReStart.Visible = False
        End If
        If My.App.WSTShowShutDown Then : Me.cmiWSTShutDown.Visible = True
        Else : Me.cmiWSTShutDown.Visible = False
        End If
        If My.App.WSTShowLockWorkSpace OrElse My.App.WSTShowLogOff OrElse My.App.WSTShowSleep OrElse My.App.WSTShowHibernate OrElse My.App.WSTShowReStart OrElse My.App.WSTShowShutDown Then
            If (My.App.WSTSSToolEnabled And My.App.WSTShowSSEnabled) OrElse (My.App.WSTSSToolEnabled And My.App.WSTShowSSActivate) OrElse My.App.WSTShowClock OrElse My.App.WSTShowAC Then
                Me.cmseparatorWSTShutDownOptions.Visible = True
            Else
                Me.cmseparatorWSTShutDownOptions.Visible = False
            End If
        Else : Me.cmseparatorWSTShutDownOptions.Visible = False
        End If
        'Settings Section
        If My.App.WSTShowHelp Then : Me.cmiWSTHelp.Visible = True
        Else : Me.cmiWSTHelp.Visible = False
        End If
        If My.App.WSTShowLog Then : Me.cmiWSTLog.Visible = True
        Else : Me.cmiWSTLog.Visible = False
        End If
        If (My.App.WSTSSToolEnabled And My.App.WSTShowSSEnabled) OrElse (My.App.WSTSSToolEnabled And My.App.WSTShowSSActivate) _
            OrElse My.App.WSTShowClock OrElse My.App.WSTShowAC _
            OrElse My.App.WSTShowLockWorkSpace OrElse My.App.WSTShowLogOff OrElse My.App.WSTShowSleep OrElse My.App.WSTShowHibernate OrElse My.App.WSTShowReStart OrElse My.App.WSTShowShutDown _
            Then : Me.cmseparatorWSTSettings.Visible = True
        Else : Me.cmseparatorWSTSettings.Visible = False
        End If
    End Sub
    Private Sub WSTLockWorkSpace(Optional hcmode As Boolean = False)
        If My.App.WSTShowLockWorkSpace Then
            If hcmode AndAlso My.App.WSTSSEnableOnActivate Then
                WSTSSEnabled = True
            End If
            Skye.WinAPI.LockWorkStation()
        End If
    End Sub

#End Region
#Region "ScreenSaver (SS)"

    ' Declarations
    Private _wSTSSEnabled As Boolean? = Nothing
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Friend Property WSTSSEnabled As Boolean
        Get
            Return _wSTSSEnabled.GetValueOrDefault(False)
        End Get
        Set(value As Boolean)
            If Not _wSTSSEnabled.HasValue OrElse _wSTSSEnabled.Value <> value Then
                _wSTSSEnabled = value
                WSTSSSet()
            End If
        End Set
    End Property

    ' Control Events
    Private Sub CMIWSTScreenSaverActivateMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTScreenSaverActivate.MouseUp, cmiScreenSaverActivate.MouseUp
        If e.Button = MouseButtons.Left Then App.SSActivate()
    End Sub
    Private Sub CMIWSTScreenSaverEnabledMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTScreenSaverEnabled.MouseUp, cmiScreenSaverEnabled.MouseUp
        If e.Button = MouseButtons.Left Then WSTSSEnabled = Not WSTSSEnabled
    End Sub
    Private Sub CMIScreenSaverCloseMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiScreenSaverClose.MouseUp
        If e.Button = MouseButtons.Left Then
            My.App.WSTShowSSIcon = False
            ShowTools()
            App.FrmSettings?.UpdateSettings()
        End If
    End Sub

    ' Methods
    Friend Sub WSTSSSet()
        Debug.Print("WSTSSSet: SS Enabled = " + WSTSSEnabled.ToString)
        If My.App.WSTSSToolEnabled Then
            If WSTSSEnabled Then
                Skye.WinAPI.SetThreadExecutionState(Skye.WinAPI.EXECUTION_STATE.ES_CONTINUOUS)
                Me.cmiWSTScreenSaverEnabled.Image = My.Resources.Resources.ImageWSTSS16
                Me.cmiWSTScreenSaverEnabled.ForeColor = Color.Teal
                Me.cmiWSTScreenSaverEnabled.Text = "Screen Saver ENABLED"
                Me.notifyiconWSTScreenSaver.Icon = My.Resources.Resources.IconWSTSS
                Me.notifyiconWSTScreenSaver.Text = "Screen Saver ENABLED"
                Me.cmiScreenSaverEnabled.Image = My.Resources.Resources.ImageWSTSS16
                Me.cmiScreenSaverEnabled.ForeColor = Color.Teal
                Me.cmiScreenSaverEnabled.Text = "Screen Saver ENABLED"
            Else
                Skye.WinAPI.SetThreadExecutionState(Skye.WinAPI.EXECUTION_STATE.ES_DISPLAY_REQUIRED Or Skye.WinAPI.EXECUTION_STATE.ES_CONTINUOUS)
                Me.cmiWSTScreenSaverEnabled.Image = My.Resources.Resources.ImageWSTSSDisabled16
                Me.cmiWSTScreenSaverEnabled.ForeColor = Color.Maroon
                Me.cmiWSTScreenSaverEnabled.Text = "Screen Saver DISABLED"
                Me.notifyiconWSTScreenSaver.Icon = My.Resources.Resources.IconWSTSSDisabled
                Me.notifyiconWSTScreenSaver.Text = "Screen Saver DISABLED"
                Me.cmiScreenSaverEnabled.Image = My.Resources.Resources.ImageWSTSSDisabled16
                Me.cmiScreenSaverEnabled.ForeColor = Color.Maroon
                Me.cmiScreenSaverEnabled.Text = "Screen Saver DISABLED"
            End If
            FrmSettings?.UpdateSettings()
            UpdateWST()
        End If
    End Sub

#End Region
#Region "Alarm & Chime (AC)"

    'Declarations
    Private WithEvents TimerAC As New Timer
    Private WithEvents BackgroundworkerAC As New System.ComponentModel.BackgroundWorker
    Private _ACAlarmActive As Boolean
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Friend Property ACAlarmActive As Boolean
        Get
            Return _ACAlarmActive
        End Get
        Set(value As Boolean)
            If _ACAlarmActive <> value Then
                _ACAlarmActive = value
            End If
        End Set
    End Property
    Private _ACMute As Boolean
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Friend Property ACMute As Boolean
        Get
            Return _ACMute
        End Get
        Set(value As Boolean)
            If _ACMute <> value Then
                _ACMute = value
            End If
        End Set
    End Property
    Private ACAlarmTripped As Boolean
    Private ACChimePath As String
    Private ACChimeCount As Byte
    Private ACLastMinute As Integer = My.Computer.Clock.LocalTime.Minute

    'Control Events
    Private Sub CMIWSTACMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTAC.MouseUp
        If e.Button = MouseButtons.Left Then
            If ACAlarmTripped And ACChimeCount = Byte.MaxValue Then
                ACAlarmCancel()
            Else
                App.ShowSettings("AC")
            End If
        End If
    End Sub
    Private Sub CMIWSTACAlarmCancelMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTACAlarmCancel.MouseUp
        If e.Button = MouseButtons.Left Then ACAlarmCancel()
    End Sub

    'Handlers
    Private Sub TimerACTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerAC.Tick
        If ACLastMinute <> My.Computer.Clock.LocalTime.Minute And Not ACAlarmTripped Then
            ACLastMinute = My.Computer.Clock.LocalTime.Minute
            ACChimePath = ""
            ACChimeCount = 0
            If My.App.ACTopHourChimeEnabled And My.Computer.Clock.LocalTime.Minute = 0 Then
                ACChimePath = My.App.ACTopHourChimePath
                Select Case My.App.ACTopHourChimeType
                    Case My.App.ACChimeType.Simple : ACChimeCount = 1
                    Case My.App.ACChimeType.Extended : ACChimeCount = 4
                    Case My.App.ACChimeType.HourTick
                        If My.Computer.Clock.LocalTime.Hour = 0 Then : ACChimeCount = 12
                        ElseIf My.Computer.Clock.LocalTime.Hour >= 13 And My.Computer.Clock.LocalTime.Hour <= 23 Then : ACChimeCount = CByte(My.Computer.Clock.LocalTime.Hour - 12)
                        Else : ACChimeCount = CByte(My.Computer.Clock.LocalTime.Hour)
                        End If
                End Select
            End If
            If My.App.ACTopHourBeforeChimeEnabled And My.Computer.Clock.LocalTime.Minute = 55 Then
                ACChimePath = My.App.ACOffHourChimePath
                ACChimeCount = 1
            End If
            If My.App.ACTopHourAfterChimeEnabled And My.Computer.Clock.LocalTime.Minute = 5 Then
                ACChimePath = My.App.ACOffHourChimePath
                ACChimeCount = 1
            End If
            If My.App.ACFirstQuarterHourChimeEnabled And My.Computer.Clock.LocalTime.Minute = 15 Then
                ACChimePath = My.App.ACOffHourChimePath
                ACChimeCount = 1
            End If
            If My.App.ACFirstQuarterHourBeforeChimeEnabled And My.Computer.Clock.LocalTime.Minute = 10 Then
                ACChimePath = My.App.ACOffHourChimePath
                ACChimeCount = 1
            End If
            If My.App.ACFirstQuarterHourAfterChimeEnabled And My.Computer.Clock.LocalTime.Minute = 20 Then
                ACChimePath = My.App.ACOffHourChimePath
                ACChimeCount = 1
            End If
            If My.App.ACBottomHourChimeEnabled And My.Computer.Clock.LocalTime.Minute = 30 Then
                ACChimePath = My.App.ACOffHourChimePath
                ACChimeCount = 1
            End If
            If My.App.ACBottomHourBeforeChimeEnabled And My.Computer.Clock.LocalTime.Minute = 25 Then
                ACChimePath = My.App.ACOffHourChimePath
                ACChimeCount = 1
            End If
            If My.App.ACBottomHourAfterChimeEnabled And My.Computer.Clock.LocalTime.Minute = 35 Then
                ACChimePath = My.App.ACOffHourChimePath
                ACChimeCount = 1
            End If
            If My.App.ACThirdQuarterHourChimeEnabled And My.Computer.Clock.LocalTime.Minute = 45 Then
                ACChimePath = My.App.ACOffHourChimePath
                ACChimeCount = 1
            End If
            If My.App.ACThirdQuarterHourBeforeChimeEnabled And My.Computer.Clock.LocalTime.Minute = 40 Then
                ACChimePath = My.App.ACOffHourChimePath
                ACChimeCount = 1
            End If
            If My.App.ACThirdQuarterHourAfterChimeEnabled And My.Computer.Clock.LocalTime.Minute = 50 Then
                ACChimePath = My.App.ACOffHourChimePath
                ACChimeCount = 1
            End If
            If ACAlarmActive And My.Computer.Clock.LocalTime.Hour = My.App.ACAlarmTime.Hours And My.Computer.Clock.LocalTime.Minute = My.App.ACAlarmTime.Minutes Then
                ACAlarmTripped = True
                ACChimePath = My.App.ACAlarmChimePath
                Select Case My.App.ACAlarmChimeType
                    Case My.App.ACChimeType.Simple : ACChimeCount = 1
                    Case My.App.ACChimeType.Forever : ACChimeCount = Byte.MaxValue
                    Case Else : ACChimeCount = 4
                End Select
            End If
            If Not Me.BackgroundworkerAC.IsBusy And Not ACMute And ACChimeCount > 0 Then
                Me.BackgroundworkerAC.RunWorkerAsync()

                If ACChimeCount = Byte.MaxValue Then
                    UpdateWST()
                    App.FrmSettings?.ACUpdateCancel(True)
                End If
            End If
            If ACMute Then
                App.ShowMessage(My.App.Tools.AlarmChime, "** " + If(ACAlarmTripped, "ALARM", "CHIME") + " IS SOUNDING **", Nothing)
                ACAlarmTripped = False
            End If
        End If
    End Sub
    Private Sub BackgroundworkerACDoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundworkerAC.DoWork
        Dim counter As Byte = 0
        Do
            If ACChimePath = "" Then
                Try : My.Computer.Audio.Play(My.App.ACChime, AudioPlayMode.WaitToComplete)
                Catch : Me.BackgroundworkerAC.CancelAsync()
                End Try
            Else
                Try : My.Computer.Audio.Play(ACChimePath, AudioPlayMode.WaitToComplete)
                Catch
                    Try : My.Computer.Audio.Play(My.App.ACChime, AudioPlayMode.WaitToComplete)
                    Catch : Me.BackgroundworkerAC.CancelAsync()
                    End Try
                End Try
            End If
            counter += CByte(1)
        Loop While counter < ACChimeCount And Not Me.BackgroundworkerAC.CancellationPending
        e.Result = counter
    End Sub
    Private Sub BackgroundworkerACRunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundworkerAC.RunWorkerCompleted
        If ACAlarmTripped And Not CByte(e.Result) = Byte.MaxValue Then
            ACAlarmTripped = False
            ACSet()
            App.FrmSettings?.ACUpdateCancel(False)
        End If
    End Sub

    'Procedures
    Friend Sub ACAlarmCancel()
        ACAlarmTripped = False
        If Me.BackgroundworkerAC.IsBusy Then
            Me.BackgroundworkerAC.CancelAsync()
        Else
            ACSet()
        End If
        UpdateWST()
        App.FrmSettings?.ACUpdateCancel(False)
    End Sub
    Friend Sub ACSet()
        If My.App.WSTShowAC Then : ACAlarmActive = My.App.ACAlarmRecurring
        Else : ACAlarmActive = False
        End If
        ACSetTimer()
    End Sub
    Friend Sub ACSetTimer()
        If (ACAlarmActive Or My.App.ACTopHourChimeEnabled Or My.App.ACTopHourBeforeChimeEnabled Or My.App.ACTopHourAfterChimeEnabled Or My.App.ACThirdQuarterHourChimeEnabled Or My.App.ACFirstQuarterHourChimeEnabled Or My.App.ACBottomHourChimeEnabled) And My.App.WSTShowAC Then
            Me.TimerAC.Start()
        Else
            Me.TimerAC.Stop()
        End If
    End Sub
    Friend Sub CancelBackgroundworkerAC()
        If Me.BackgroundworkerAC.IsBusy Then Me.BackgroundworkerAC.CancelAsync()
    End Sub

#End Region
#Region "WinLinks(WL)"

    ' Declarations
    Private WithEvents TimerWLStartUp As New Timer
    Private WithEvents TimerWLAutoRefresh As New Timer
    Private WithEvents TimerWLAutoRefreshIdle As New Timer
    Private WithEvents WatcherWLAutoRefresh As New IO.FileSystemWatcher
    Private WithEvents BackgroundworkerWL As New System.ComponentModel.BackgroundWorker
    Friend ReadOnly Property IsWLBackgroundWorkerBusy As Boolean
        Get
            Return BackgroundworkerWL.IsBusy
        End Get
    End Property
    Private Const WLMaxItems As Integer = 2000
    Private Structure WLMenuDataItem
        Public Text As String
        Public File As String
        Public Icon As Image
        Public IsFolder As Boolean
        Public SubMenu As Collections.Generic.List(Of WLMenuDataItem)
    End Structure
    Private WLMenuData As New Collections.Generic.List(Of Collections.Generic.List(Of WLMenuDataItem))
    Friend ReadOnly Property WLMenuDataCount As Integer
        Get
            Return WLMenuData.Count
        End Get
    End Property
    Private WLMenus As New Collections.Generic.List(Of ToolStripMenuItem)
    Private WLTrayIcons As New Collections.Generic.List(Of NotifyIcon)
    Private WLAutoRefreshUpdate As Boolean = False
    Private WLLoadStartTime As TimeSpan
    Private WLMenuItemCount As Integer
    Private cmWLItem As New ContextMenuStrip
    Private _WLStartUp As Boolean
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Friend Property WLStartUp As Boolean
        Get
            Return _WLStartUp
        End Get
        Set(value As Boolean)
            If _WLStartUp <> value Then
                _WLStartUp = value
            End If
        End Set
    End Property
    Private _WLInsertIndex As Integer
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Friend Property WLInsertIndex As Integer
        Get
            Return _WLInsertIndex
        End Get
        Set(value As Integer)
            If _WLInsertIndex <> value Then
                _WLInsertIndex = value
            End If
        End Set
    End Property
    Private _WLShowAutoRefresh As Boolean
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Friend ReadOnly Property WLShowAutoRefresh As Boolean
        Get
            Return _WLShowAutoRefresh
        End Get
    End Property

    ' Control Events
    Private Sub CMIWLMenusMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim senderCMI As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Select Case e.Button
            Case MouseButtons.Left : HCPerformAction(My.App.HCWLLeft, senderCMI.Tag)
            Case MouseButtons.Right : WLShowItemSubMenu(senderCMI.Text, My.App.WLData(CInt(senderCMI.Tag)).Root)
        End Select
    End Sub
    Private Sub CMIWLRootMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then WLStartLink(My.App.WLData(CInt(CType(sender, ToolStripMenuItem).Tag)).Root)
    End Sub
    Private Sub CMIWLMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim senderCMI As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Select Case e.Button
            Case MouseButtons.Left
                WLStartLink(senderCMI.Tag.ToString)
            Case MouseButtons.Right : WLShowItemSubMenu(senderCMI.Text, senderCMI.Tag.ToString)
        End Select
    End Sub
    Private Sub CMIWLRefreshMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim senderCMI As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            Dim link As My.App.WLItemType = My.App.WLData(CInt(senderCMI.Tag))
            link.RefreshData = True
            link.RefreshMenu = True
            My.App.WLData(CInt(senderCMI.Tag)) = link
            ShowWL()
        End If
    End Sub
    Private Sub CMIWLRemoveFromTrayMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim senderCMI As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            Dim link As My.App.WLItemType = My.App.WLData(CInt(senderCMI.Tag))
            link.ShowInTray = False
            My.App.WLData(CInt(senderCMI.Tag)) = link
            For index As Integer = 0 To WLTrayIcons.Count - 1
                Dim trayicon As NotifyIcon = WLTrayIcons(index)
                If CInt(trayicon.Tag) = CInt(senderCMI.Tag) Then
                    trayicon.Visible = False
                    trayicon.Dispose()
                    WLTrayIcons.RemoveAt(index)
                    Exit For
                End If
            Next
            ShowSettings(My.App.Tools.WinLinks)
        End If
    End Sub
    Private Sub CMIWLSettingsMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then SelectTab(Me.tabpageWL, True)
    End Sub
    Private Sub CMIWLCloseMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            My.App.WSTShowWLTray = False
            ShowTools()
            ShowSettings(My.App.Tools.WorkSpaceTools)
        End If
    End Sub
    Private Sub CMIWLCopyPathMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Try : My.Computer.Clipboard.SetText(CType(sender, ToolStripMenuItem).Tag.ToString) : Catch : End Try
        End If
    End Sub
    Private Sub CMIWLDeleteItemMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left AndAlso Not BackgroundworkerWL.IsBusy Then
            Dim senderCMI As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            If My.Computer.FileSystem.FileExists(senderCMI.Tag.ToString) Then : My.Computer.FileSystem.DeleteFile(senderCMI.Tag.ToString, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
            ElseIf My.Computer.FileSystem.DirectoryExists(senderCMI.Tag.ToString) Then : My.Computer.FileSystem.DeleteDirectory(senderCMI.Tag.ToString, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
            End If
            Dim DataIndicesThatNeedUpdated As New Collections.Generic.List(Of Integer)
            For index As Integer = 0 To WLMenuData.Count - 1
                Dim dataset As Collections.Generic.List(Of WLMenuDataItem) = WLMenuData(index)
                WLFindMenuDataItem(dataset, senderCMI.Tag.ToString, index, DataIndicesThatNeedUpdated)
            Next
            For index As Integer = 0 To My.App.WLData.Count - 1
                If DataIndicesThatNeedUpdated.Contains(index) Then
                    Dim link As My.App.WLItemType = My.App.WLData(index)
                    link.RefreshData = True
                    link.RefreshMenu = True
                    My.App.WLData(index) = link
                End If
            Next
            ShowWL()
            senderCMI = Nothing
        End If
    End Sub

    ' Handlers
    Private Sub TimerWLStartUpTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerWLStartUp.Tick
        Me.TimerWLStartUp.Stop()
        WLStartUp = False
        UpdateWSTCancelState()
        ShowWL()
        If Me.TimerWLStartUp.Enabled Then Me.TimerWLStartUp.Interval = My.App.WLStartUpDelay * 1000
    End Sub
    Private Sub TimerWLAutoRefreshTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerWLAutoRefresh.Tick
        If WLAutoRefreshUpdate Then TimerWLAutoRefreshIdle.Start()
    End Sub
    Private Sub TimerWLAutoRefreshIdleTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerWLAutoRefreshIdle.Tick
        ShowWL()
    End Sub
    Private Sub WatcherWLAutoRefreshOnCreated(source As Object, e As IO.FileSystemEventArgs) Handles WatcherWLAutoRefresh.Created
        On Error Resume Next
        WLWatcher(CType(source, IO.FileSystemWatcher).Path, True)
    End Sub
    Private Sub WatcherWLAutoRefreshOnRenamed(source As Object, e As IO.RenamedEventArgs) Handles WatcherWLAutoRefresh.Renamed
        On Error Resume Next
        WLWatcher(CType(source, IO.FileSystemWatcher).Path, True)
    End Sub
    Private Sub WatcherWLAutoRefreshOnChanged(source As Object, e As IO.FileSystemEventArgs) Handles WatcherWLAutoRefresh.Changed
        On Error Resume Next
        WLWatcher(CType(source, IO.FileSystemWatcher).Path, False)
    End Sub
    Private Sub WatcherWLAutoRefreshOnDeleted(source As Object, e As IO.FileSystemEventArgs) Handles WatcherWLAutoRefresh.Deleted
        On Error Resume Next
        WLWatcher(CType(source, IO.FileSystemWatcher).Path, True)
    End Sub
    Private Sub BackgroundworkerWLDoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundworkerWL.DoWork
        Try
            For index As Integer = 0 To My.App.WLData.Count - 1
                If BackgroundworkerWL.CancellationPending Then
                    e.Cancel = True
                    Exit For
                End If
                Dim link As My.App.WLItemType = My.App.WLData(index)
                If link.RefreshData And ((My.App.WSTShowWLMenu And link.ShowInMenu) Or (My.App.WSTShowWLTray And link.ShowInTray)) Then
#If DEBUG Then
                    BackgroundworkerWL.ReportProgress(0, index)
#End If
                    WLMenuItemCount = 0
                    WLMenuData(index).Clear()

                    ' If process/I/O cancels mid-execution inside WLGenerateMenuData, 
                    ' it will throw OperationCanceledException
                    WLMenuData(index) = WLGenerateMenuData(link.Root, link)

                    ' Check cancellation again before mutating state
                    If BackgroundworkerWL.CancellationPending Then
                        e.Cancel = True
                        Exit For
                    End If

                    WLMenuData(index).TrimExcess()
                    link.RefreshData = False
                    My.App.WLData(index) = link
                End If
            Next
        Catch ex As OperationCanceledException
            e.Cancel = True
        Catch ex As Exception
            My.App.WriteToLog(My.App.Tools.WinLinks, "Fatal Error Loading WinLinks!" + Chr(13) + "Location : backgroundworkerWinLinksDoWork" + Chr(13) + "Error : " + ex.ToString)
        End Try
    End Sub
    <Diagnostics.ConditionalAttribute("DEBUG")> Private Sub BackgroundworkerWLProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundworkerWL.ProgressChanged
        Debug.Print("backgroundworkerWinLinksProgressChanged: Processing WinLink Index = " + e.UserState.ToString)
    End Sub
    Private Sub BackgroundworkerWLRunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundworkerWL.RunWorkerCompleted
        Try
            If e.Cancelled Then
                Debug.Print("backgroundworkerWinLinksRunWorkerCompleted: WinLinks File System Search CANCELLED")
                WLClose(True)
            Else
                For wlindex As Integer = 0 To My.App.WLData.Count - 1
                    Dim link As My.App.WLItemType = My.App.WLData(wlindex)
                    If link.RefreshMenu Then
                        If My.App.WSTShowWLMenu Then
                            For Each cmi As ToolStripMenuItem In WLMenus
                                If CInt(cmi.Tag) = wlindex Then
                                    cmi.DropDown.Dispose()
                                    Dim menu As ContextMenuStrip = WLGenerateMenu(WLMenuData(CInt(cmi.Tag)), My.App.WLData(CInt(cmi.Tag)).ShowMenuIcons)
                                    menu.Font = App.MenuFont
                                    menu.Renderer = New Skye.UI.SkyeMenuRenderer
                                    Dim cmitem As ToolStripItem
                                    cmi.DropDown = menu
                                    If Not link.ShowNoMenu Then
                                        If menu.Items.Count = 0 Then
                                            cmitem = New ToolStripMenuItem(My.App.WLEmptyText)
                                            If My.App.WLData(CInt(cmi.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.iconWL.ToBitmap 'DirectCast(My.App.AppResources.GetObject("iconWL"), Icon).ToBitmap
                                            AddHandler cmitem.MouseUp, AddressOf CMIWLMenusMouseUp
                                            menu.Items.Add(cmitem)
                                        End If
                                        cmi.DropDown.Items.Add(New ToolStripSeparator)
                                    End If
                                    'SubMenu Options
                                    If Not link.ShowNoMenu Then
                                        'Initialize
                                        Dim cm As New ContextMenuStrip With {
                                            .Font = App.MenuFont,
                                            .Renderer = New Skye.UI.SkyeMenuRenderer,
                                            .ShowItemToolTips = False
                                        }
                                        If Not My.App.WLData(CInt(cmi.Tag)).ShowMenuIcons Then cm.ShowImageMargin = False
                                        'Open Root
                                        cmitem = New ToolStripMenuItem("Open Root Folder")
                                        If My.App.WLData(CInt(cmi.Tag)).ShowMenuIcons Then cmitem.Image = cmi.Image
                                        cmitem.Tag = cmi.Tag
                                        AddHandler cmitem.MouseUp, AddressOf CMIWLRootMouseUp
                                        cm.Items.Add(cmitem)
                                        'Copy Root FolderName
                                        cm.Items.Add(New ToolStripSeparator)
                                        cmitem = New ToolStripMenuItem("Copy Root FolderName")
                                        If My.App.WLData(CInt(cmi.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageCopy 'DirectCast(My.App.AppResources.GetObject("imageCopy"), Image)
                                        Dim split As String() = My.App.WLData(CInt(cmi.Tag)).Root.Split(CChar("\"))
                                        cmitem.Tag = split(split.Length - 1)
                                        cmitem.ToolTipText = cmitem.Tag.ToString
                                        AddHandler cmitem.MouseUp, AddressOf CMIWLCopyPathMouseUp
                                        cm.Items.Add(cmitem)
                                        'Copy Full Root Path
                                        cmitem = New ToolStripMenuItem("Copy Full Root Path")
                                        If My.App.WLData(CInt(cmi.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageCopy 'DirectCast(My.App.AppResources.GetObject("imageCopy"), Image)
                                        cmitem.Tag = My.App.WLData(CInt(cmi.Tag)).Root
                                        cmitem.ToolTipText = cmitem.Tag.ToString
                                        AddHandler cmitem.MouseUp, AddressOf CMIWLCopyPathMouseUp
                                        cm.Items.Add(cmitem)
                                        'Refresh
                                        If Not link.ShowNoMenu Then
                                            cm.Items.Add(New ToolStripSeparator)
                                            cmitem = New ToolStripMenuItem("Refresh")
                                            If My.App.WLData(CInt(cmi.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageSwap 'DirectCast(My.App.AppResources.GetObject("imageSwap"), Image)
                                            cmitem.Tag = cmi.Tag
                                            AddHandler cmitem.MouseUp, AddressOf CMIWLRefreshMouseUp
                                            cm.Items.Add(cmitem)
                                        End If
                                        'Delete
                                        If My.Computer.FileSystem.DirectoryExists(My.App.WLData(CInt(cmi.Tag)).Root) Then
                                            cm.Items.Add(New ToolStripSeparator)
                                            cmitem = New ToolStripMenuItem("Delete", My.Resources.Resources.imageRemove) With {.Tag = My.App.WLData(CInt(cmi.Tag)).Root}
                                            AddHandler cmitem.MouseUp, AddressOf CMIWLDeleteItemMouseUp
                                            cm.Items.Add(cmitem)
                                        End If
                                        'Finalize
                                        Dim mi As New ToolStripMenuItem(cmi.Text + " Menu")
                                        If My.App.WLData(CInt(cmi.Tag)).ShowMenuIcons Then mi.Image = cmi.Image
                                        mi.Tag = cmi.Tag
                                        App.HookTSItemsForCMTooltip(cm, TipCM)
                                        mi.DropDown = cm
                                        AddHandler mi.MouseUp, AddressOf CMIWLMenusMouseUp
                                        cmi.DropDown.Items.Add(mi)
                                    End If
                                End If
                            Next
                        End If
                        If My.App.WSTShowWLTray Then
                            For index As Integer = 0 To WLTrayIcons.Count - 1
                                Dim trayicon As NotifyIcon = WLTrayIcons(index)
                                If CInt(trayicon.Tag) = wlindex Then
                                    trayicon.ContextMenuStrip.Dispose()
                                    trayicon.Text = trayicon.Text.Split(Chr(13))(0)
                                    Dim traymenu As ContextMenuStrip = WLGenerateMenu(WLMenuData(CInt(trayicon.Tag)), My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons)
                                    traymenu.Font = App.MenuFont
                                    traymenu.Renderer = New Skye.UI.SkyeMenuRenderer
                                    traymenu.ShowItemToolTips = False
                                    Dim cmitem As ToolStripItem
                                    If Not link.ShowNoMenu Then
                                        If traymenu.Items.Count = 0 Then
                                            cmitem = New ToolStripMenuItem(My.App.WLEmptyText)
                                            If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.iconWL.ToBitmap 'DirectCast(My.App.AppResources.GetObject("iconWL"), Icon).ToBitmap
                                            AddHandler cmitem.MouseUp, AddressOf CMIWLMenusMouseUp
                                            traymenu.Items.Add(cmitem)
                                        End If
                                        traymenu.Items.Add(New ToolStripSeparator)
                                    End If
                                    'SubMenu Options
                                    'Initialize
                                    Dim cm As New ContextMenuStrip With {
                                        .Font = App.MenuFont,
                                        .Renderer = New Skye.UI.SkyeMenuRenderer,
                                        .ShowItemToolTips = False
                                    }
                                    If Not My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cm.ShowImageMargin = False
                                    'Open Root
                                    cmitem = New ToolStripMenuItem("Open Root Folder")
                                    If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = trayicon.Icon.ToBitmap
                                    cmitem.Tag = trayicon.Tag
                                    AddHandler cmitem.MouseUp, AddressOf CMIWLRootMouseUp
                                    cm.Items.Add(cmitem)
                                    'Copy Root FolderName
                                    cm.Items.Add(New ToolStripSeparator)
                                    cmitem = New ToolStripMenuItem("Copy Root FolderName")
                                    If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageCopy 'DirectCast(My.App.AppResources.GetObject("imageCopy"), Image)
                                    Dim split As String() = My.App.WLData(CInt(trayicon.Tag)).Root.Split(CChar("\"))
                                    cmitem.Tag = split(split.Length - 1)
                                    cmitem.ToolTipText = cmitem.Tag.ToString
                                    AddHandler cmitem.MouseUp, AddressOf CMIWLCopyPathMouseUp
                                    cm.Items.Add(cmitem)
                                    'Copy Full Root Path
                                    cmitem = New ToolStripMenuItem("Copy Full Root Path")
                                    If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageCopy 'DirectCast(My.App.AppResources.GetObject("imageCopy"), Image)
                                    cmitem.Tag = My.App.WLData(CInt(trayicon.Tag)).Root
                                    cmitem.ToolTipText = cmitem.Tag.ToString
                                    AddHandler cmitem.MouseUp, AddressOf CMIWLCopyPathMouseUp
                                    cm.Items.Add(cmitem)
                                    'Refresh
                                    If Not link.ShowNoMenu Then
                                        cm.Items.Add(New ToolStripSeparator)
                                        cmitem = New ToolStripMenuItem("Refresh")
                                        If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageSwap 'DirectCast(My.App.AppResources.GetObject("imageSwap"), Image)
                                        cmitem.Tag = trayicon.Tag
                                        AddHandler cmitem.MouseUp, AddressOf CMIWLRefreshMouseUp
                                        cm.Items.Add(cmitem)
                                    End If
                                    cm.Items.Add(New ToolStripSeparator)
                                    cmitem = New ToolStripMenuItem("Remove From Tray")
                                    If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageClose
                                    cmitem.Tag = trayicon.Tag
                                    AddHandler cmitem.MouseUp, AddressOf CMIWLRemoveFromTrayMouseUp
                                    cm.Items.Add(cmitem)
                                    'Delete
                                    If My.Computer.FileSystem.DirectoryExists(My.App.WLData(CInt(trayicon.Tag)).Root) Then
                                        cm.Items.Add(New ToolStripSeparator)
                                        cmitem = New ToolStripMenuItem("Delete", My.Resources.Resources.imageRemove) With {.Tag = My.App.WLData(CInt(trayicon.Tag)).Root}
                                        AddHandler cmitem.MouseUp, AddressOf CMIWLDeleteItemMouseUp
                                        cm.Items.Add(cmitem)
                                    End If
                                    'Finalize
                                    Dim mi As New ToolStripMenuItem(trayicon.Text + " Menu")
                                    If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then mi.Image = trayicon.Icon.ToBitmap
                                    mi.Tag = trayicon.Tag
                                    App.HookTSItemsForCMTooltip(cm, TipCM)
                                    mi.DropDown = cm
                                    AddHandler mi.MouseUp, AddressOf CMIWLMenusMouseUp
                                    traymenu.Items.Add(mi)
                                    'Menu Options
                                    cmitem = New ToolStripMenuItem("Settings")
                                    If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageSettings
                                    AddHandler cmitem.MouseUp, AddressOf CMIWLSettingsMouseUp
                                    traymenu.Items.Add(cmitem)
                                    traymenu.Items.Add(New ToolStripSeparator)
                                    cmitem = New ToolStripMenuItem("Close WinLinks Tray")
                                    If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageClose
                                    AddHandler cmitem.MouseUp, AddressOf CMIWLCloseMouseUp
                                    traymenu.Items.Add(cmitem)
                                    cmitem = New ToolStripMenuItem("Exit SkyeTools")
                                    If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageClose
                                    cmitem.ToolTipText = My.App.CloseAllToolTipText
                                    AddHandler cmitem.MouseUp, AddressOf CMICloseAllMouseUp
                                    traymenu.Items.Add(cmitem)
                                    traymenu.Tag = trayicon.Tag
                                    App.HookTSItemsForCMTooltip(traymenu, TipCM)
                                    trayicon.ContextMenuStrip = traymenu
                                End If
                            Next
                        End If
                        link.RefreshMenu = False
                        My.App.WLData(wlindex) = link
                    End If
                Next
            End If
            My.Application.CurrentProcess.PriorityClass = Diagnostics.ProcessPriorityClass.AboveNormal
            My.App.WriteToLog(My.App.Tools.WinLinks, IIf(WLAutoRefreshUpdate, "WinLinks AutoRefreshed (", "WinLinks Loaded (").ToString + Skye.Common.GenerateLogTime(WLLoadStartTime, My.Computer.Clock.LocalTime.TimeOfDay) + ")")
            If Not e.Cancelled Then WLSetAutoRefresh()
            WLSetSettingsState(True)
            WLLoadStartTime = TimeSpan.Zero
            If Not WLAutoRefreshUpdate Then App.ShowMessage(My.App.Tools.WinLinks, App.ToolToString(App.Tools.WinLinks), "All WinLinks Loaded")
            WLAutoRefreshUpdate = False
        Catch ex As Exception : My.App.WriteToLog(My.App.Tools.WinLinks, "Fatal Error Loading WinLinks!" + Chr(13) + "Location : backgroundworkerWinLinksRunWorkerCompleted" + Chr(13) + "Error : " + ex.ToString)
        End Try
    End Sub

    ' Methods
    Friend Sub ShowWL()
        Try
            If (My.App.WSTShowWLMenu Or My.App.WSTShowWLTray) And My.App.WLData.Count > 0 And Not BackgroundworkerWL.IsBusy Then
                WLLoadStartTime = My.Computer.Clock.LocalTime.TimeOfDay
                WLSetAutoRefresh(True)
                WLSetSettingsState(False)
                If WLMenuData.Count = 0 And (My.App.WSTShowWLMenu Or My.App.WSTShowWLTray) Then
                    Do Until WLMenuData.Count = My.App.WLData.Count : WLMenuData.Add(New Collections.Generic.List(Of WLMenuDataItem)) : Loop
                End If
                If WLMenus.Count = 0 And My.App.WSTShowWLMenu Then
                    Dim cmindex As Integer
                    For index As Integer = 0 To My.App.WLData.Count - 1
                        Dim link As My.App.WLItemType = My.App.WLData(index)
                        If link.ShowInMenu Then
                            Dim cmi As New ToolStripMenuItem
                            If String.IsNullOrEmpty(link.Name) Then
                                Dim split As String() = link.Root.Split(CChar("\"))
                                cmi.Text = split(split.Length - 1)
                            Else : cmi.Text = link.Name
                            End If
                            If My.App.WLShowFolderPathToolTips Then cmi.ToolTipText = link.Root
                            cmi.ForeColor = Color.DarkBlue
                            cmi.Tag = index
                            AddHandler cmi.MouseUp, AddressOf CMIWLMenusMouseUp
                            For cmindex = 0 To Me.cmWST.Items.Count - 1 : If Me.cmWST.Items(cmindex) Is Me.cmseparatorWSTWLBottom Then Exit For
                            Next
                            Me.cmWST.Items.Insert(cmindex, cmi)
                            WLMenus.Add(cmi)
                        End If
                    Next
                End If
                If WLTrayIcons.Count = 0 And My.App.WSTShowWLTray Then
                    For index As Integer = My.App.WLData.Count - 1 To 0 Step -1 'order is reversed here so that tray icons will show up in proper order
                        Dim link As My.App.WLItemType = My.App.WLData(index)
                        If link.ShowInTray Then
                            Dim trayicon As New NotifyIcon
                            If String.IsNullOrEmpty(link.Name) Then
                                Dim split As String() = My.App.FixAmpersand(link.Root, 3).Split(CChar("\"))
                                trayicon.Text = split(split.Length - 1)
                            Else : trayicon.Text = My.App.FixAmpersand(link.Name, 3)
                            End If
                            trayicon.Tag = index
                            AddHandler trayicon.MouseDown, AddressOf NotifyiconMouseDown
                            trayicon.ContextMenuStrip = New ContextMenuStrip With {
                                    .Font = App.MenuFont,
                                    .Renderer = New Skye.UI.SkyeMenuRenderer
                                }
                            trayicon.Visible = True
                            WLTrayIcons.Add(trayicon)
                        End If
                    Next
                End If
                For Each cmi As ToolStripMenuItem In WLMenus
                    If My.App.WLData(CInt(cmi.Tag)).RefreshMenu Then
                        cmi.DropDown.Dispose()

                        If Not My.App.WLData(CInt(cmi.Tag)).ShowNoMenu Then
                            Dim cm As New ContextMenuStrip With {.Font = New Font(Me.Font, FontStyle.Regular)}
                            Dim mi As New ToolStripMenuItem("Loading...")
                            If My.App.WLData(CInt(cmi.Tag)).ShowMenuIcons Then : mi.Image = My.Resources.Resources.iconWL.ToBitmap 'DirectCast(My.App.AppResources.GetObject("iconWL"), Icon).ToBitmap
                            Else : cm.ShowImageMargin = False
                            End If
                            mi.Tag = cmi.Tag
                            AddHandler mi.MouseUp, AddressOf CMIWLMenusMouseUp
                            cm.Items.Add(mi)
                            cmi.DropDown = cm
                        End If
                        If My.App.WLData(CInt(cmi.Tag)).UseDefaultIcon Then : cmi.Image = My.Resources.Resources.iconWL.ToBitmap 'DirectCast(My.App.AppResources.GetObject("iconWL"), Icon).ToBitmap
                        Else
                            Try : cmi.Image = Skye.WinAPI.GetApplicationIcon(My.App.WLData(CInt(cmi.Tag)).Root).ToBitmap
                            Catch : cmi.Image = My.Resources.Resources.iconWL.ToBitmap
                            End Try
                        End If
                    End If
                Next
                For Each trayicon As NotifyIcon In WLTrayIcons
                    If My.App.WLData(CInt(trayicon.Tag)).RefreshMenu Then
                        trayicon.ContextMenuStrip.Dispose()
                        Dim traymenu As New ContextMenuStrip With {
                                .Font = App.MenuFont,
                                .Renderer = New Skye.UI.SkyeMenuRenderer
                            }
                        If Not My.App.WLData(CInt(trayicon.Tag)).ShowNoMenu Then
                            If Not trayicon.Text.EndsWith("Loading...") Then trayicon.Text += Chr(13) + "Loading..."
                            Dim mi As New ToolStripMenuItem("Loading...")
                            If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then : mi.Image = My.Resources.Resources.iconWL.ToBitmap 'DirectCast(My.App.AppResources.GetObject("iconWL"), Icon).ToBitmap
                            Else : traymenu.ShowImageMargin = False
                            End If
                            mi.Tag = trayicon.Tag
                            AddHandler mi.MouseUp, AddressOf CMIWLMenusMouseUp
                            traymenu.Items.Add(mi)
                            traymenu.Items.Add(New ToolStripSeparator)
                        End If
                        Dim cmi As New ToolStripMenuItem("Settings")
                        If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmi.Image = My.Resources.Resources.imageSettings
                        AddHandler cmi.MouseUp, AddressOf CMIWLSettingsMouseUp
                        traymenu.Items.Add(cmi)
                        traymenu.Items.Add(New ToolStripSeparator)
                        cmi = New ToolStripMenuItem("Exit SkyeTools")
                        If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmi.Image = My.Resources.Resources.imageClose
                        cmi.ToolTipText = My.App.CloseAllToolTipText
                        AddHandler cmi.MouseUp, AddressOf CMICloseAllMouseUp
                        traymenu.Items.Add(cmi)
                        If My.App.WLData(CInt(trayicon.Tag)).UseDefaultIcon Then : trayicon.Icon = My.Resources.Resources.iconWL
                        Else
                            trayicon.Icon = Skye.WinAPI.GetApplicationIcon(My.App.WLData(CInt(trayicon.Tag)).Root)
                            If trayicon.Icon Is Nothing Then trayicon.Icon = My.Resources.Resources.iconWL
                        End If
                        trayicon.ContextMenuStrip = traymenu
                    End If
                Next
                If Not WLStartUp Then
                    My.Application.CurrentProcess.PriorityClass = Diagnostics.ProcessPriorityClass.Normal
                    If Not BackgroundworkerWL.IsBusy Then BackgroundworkerWL.RunWorkerAsync()
                End If
            End If
        Catch ex As Exception : App.WriteToLog(App.Tools.WinLinks, "Error In ShowWL" & Environment.NewLine & ex.ToString)
        End Try
    End Sub
    Private Sub WLShowItemSubMenu(text As String, tag As String)
        'Initialize
        cmWLItem.Items.Clear()
        Dim cmi As New ToolStripMenuItem(text)
        Try : cmi.Image = Skye.WinAPI.GetApplicationIcon(tag).ToBitmap
        Catch : cmi.Image = My.Resources.Resources.iconWL.ToBitmap
        End Try
        cmi.Tag = tag
        AddHandler cmi.MouseUp, AddressOf CMIWLMouseUp
        cmWLItem.Items.Add(cmi)
        'Copy Name
        cmWLItem.Items.Add(New ToolStripSeparator)
        Dim splitpath As String() = tag.Split(CChar("\"))
        If IO.File.Exists(tag) Then
            Dim splitname As String() = splitpath(splitpath.Length - 1).Split(CChar("."))
            If splitname.Length > 1 Then
                cmi = New ToolStripMenuItem With {
                    .Image = My.Resources.Resources.imageCopy,
                    .Text = "Copy FileName"}
                Dim s As String = splitname(0)
                For index As Integer = 1 To splitname.Length - 2 : s += "." + splitname(index) : Next
                cmi.Tag = s
                cmi.ToolTipText = cmi.Tag.ToString
                AddHandler cmi.MouseUp, AddressOf CMIWLCopyPathMouseUp
                cmWLItem.Items.Add(cmi)
            End If

            cmi = New ToolStripMenuItem With {
                .Image = My.Resources.Resources.imageCopy,
                .Text = "Copy Full FileName",
                .Tag = splitpath(splitpath.Length - 1)}
            cmi.ToolTipText = cmi.Tag.ToString
            AddHandler cmi.MouseUp, AddressOf CMIWLCopyPathMouseUp
            cmWLItem.Items.Add(cmi)
            splitname = Nothing
        ElseIf IO.Directory.Exists(tag) Then
            cmi = New ToolStripMenuItem With {
                .Image = My.Resources.Resources.imageCopy,
                .Text = "Copy FolderName",
                .Tag = splitpath(splitpath.Length - 1)}
            cmi.ToolTipText = cmi.Tag.ToString
            AddHandler cmi.MouseUp, AddressOf CMIWLCopyPathMouseUp
            cmWLItem.Items.Add(cmi)
        End If
        splitpath = Nothing
        'Copy Full Path
        cmi = New ToolStripMenuItem("Copy Full Path", My.Resources.Resources.imageCopy) With {.Tag = tag, .ToolTipText = tag}
        AddHandler cmi.MouseUp, AddressOf CMIWLCopyPathMouseUp
        cmWLItem.Items.Add(cmi)
        'Delete
        cmWLItem.Items.Add(New ToolStripSeparator)
        cmi = New ToolStripMenuItem("Delete", My.Resources.Resources.imageRemove) With {.Tag = tag}
        AddHandler cmi.MouseUp, AddressOf CMIWLDeleteItemMouseUp
        If BackgroundworkerWL.IsBusy Then cmi.Enabled = False
        cmWLItem.Items.Add(cmi)
        'Finalize
        App.HookTSItemsForCMTooltip(cmWLItem, TipCM)
        cmWLItem.Show(MousePosition)
    End Sub
    Friend Sub CancelBackgroundworkerWL()
        If Me.BackgroundworkerWL.IsBusy Then Me.BackgroundworkerWL.CancelAsync()
    End Sub
    Friend Sub WLClose(Optional ByRef forcecloseall As Boolean = False)
        Try
            If Not My.App.WSTShowWLMenu Or forcecloseall Then
                For Each cmi As ToolStripMenuItem In WLMenus
                    For index As Integer = 0 To Me.cmWST.Items.Count - 1
                        If cmi.Text = Me.cmWST.Items(index).Text Then
                            Me.cmWST.Items.RemoveAt(index)
                            Exit For
                        End If
                    Next
                Next
                WLMenus.Clear()
            End If
            If Not My.App.WSTShowWLTray Or forcecloseall Then
                For Each trayicon As NotifyIcon In WLTrayIcons
                    Try
                        trayicon.Visible = False
                        ' Allow OS to process tray icon removal
                        Application.DoEvents()
                        trayicon.Dispose()
                    Catch ex As Exception
                        ' Ignore shell notification teardown exceptions
                    End Try
                Next
                WLTrayIcons.Clear()
            End If
        Catch ex As Exception : My.App.WriteToLog(My.App.Tools.WinLinks, "WinLinks could not be closed properly." + Chr(13) + ex.ToString)
        Finally
            If forcecloseall Or (Not My.App.WSTShowWLMenu And Not My.App.WSTShowWLTray) Then
                WLMenuData.Clear()
                For index As Integer = 0 To My.App.WLData.Count - 1
                    Dim link As My.App.WLItemType = My.App.WLData(index)
                    link.RefreshData = True
                    link.RefreshMenu = True
                    My.App.WLData(index) = link
                Next
                WLSetAutoRefresh(True)
            Else : WLSetAutoRefresh()
            End If
        End Try
    End Sub
    Private Sub WLStartLink(ByRef link As String)
        If App.WSTShowWLMenu Or App.WSTShowWLTray Then
            Try
                Dim p As Diagnostics.Process
                Dim pi As New Diagnostics.ProcessStartInfo
                If IO.Directory.Exists(link) Then
                    pi.UseShellExecute = True
                    pi.FileName = "EXPLORER.EXE"
                    pi.Arguments = "/ROOT," + """" + link + """"
                    p = Diagnostics.Process.Start(pi)
                Else
                    pi.UseShellExecute = True
                    pi.FileName = link
                    p = Diagnostics.Process.Start(pi)
                End If
                p?.Dispose()
                p = Nothing
                pi = Nothing
            Catch ex As Exception
                App.ShowMessage(App.Tools.WinLinks, Nothing, "Cannot Start " & link.ToUpper & ", Please Check Your Settings And Try Again.")
                App.WriteToLog(App.Tools.WinLinks, "Unable to start " + link.ToUpper + Environment.NewLine + ex.ToString)
            End Try
        End If
    End Sub
    Private Sub WLWatcher(root As String, refreshdata As Boolean)
        Try
            TimerWLAutoRefreshIdle.Stop()
            For index As Integer = 0 To My.App.WLData.Count - 1
                Dim link As My.App.WLItemType = My.App.WLData(index)
                If link.Root = root Then
                    If refreshdata Then link.RefreshData = True
                    link.RefreshMenu = True
                    My.App.WLData(index) = link
                    WLAutoRefreshUpdate = True
                End If
            Next
        Catch ex As Exception : My.App.WriteToLog(My.App.Tools.WinLinks, "Error In WinLinks Watcher" + Chr(13) + ex.ToString)
        End Try
    End Sub
    Friend Sub WLSetAutoRefresh(Optional forceterminate As Boolean = False)
        If Not BackgroundworkerWL.IsBusy Then
            'Turn Off Watcher
            If WatcherWLAutoRefresh.EnableRaisingEvents Then
                Try
                    WatcherWLAutoRefresh.EnableRaisingEvents = False
                    TimerWLAutoRefresh.Stop()
                    TimerWLAutoRefreshIdle.Stop()
                    _WLShowAutoRefresh = False
                    Debug.Print("SetWinLinksAutoRefresh :Watcher Terminated")
                Catch ex As Exception
                    My.App.WriteToLog(My.App.Tools.WinLinks, "AutoRefresh could not be DeActivated." & Environment.NewLine & ex.ToString)
                    forceterminate = True
                End Try
            End If
            'Enable Watcher
            If My.App.WLData.Count > 0 Then
                If Not forceterminate And My.App.WLAutoRefresh And Not My.App.WLData(My.App.WLData.Count - 1).ShowNoMenu And ((My.App.WLData(My.App.WLData.Count - 1).ShowInMenu And My.App.WSTShowWLMenu) Or (My.App.WLData(My.App.WLData.Count - 1).ShowInTray And My.App.WSTShowWLTray)) Then
                    Try
                        WatcherWLAutoRefresh.Path = My.App.WLData(My.App.WLData.Count - 1).Root
                        If My.App.WLData(My.App.WLData.Count - 1).FolderMode = My.App.WLFolderMode.NoFolders Or My.App.WLData(My.App.WLData.Count - 1).FolderMode = My.App.WLFolderMode.ShowAsLink Then : WatcherWLAutoRefresh.IncludeSubdirectories = False
                        Else : WatcherWLAutoRefresh.IncludeSubdirectories = True
                        End If
                        If My.App.WLData(My.App.WLData.Count - 1).FolderMode = My.App.WLFolderMode.FoldersOnly Then : WatcherWLAutoRefresh.NotifyFilter = IO.NotifyFilters.DirectoryName
                        Else : WatcherWLAutoRefresh.NotifyFilter = (IO.NotifyFilters.LastWrite Or IO.NotifyFilters.FileName Or IO.NotifyFilters.DirectoryName)
                        End If
                        TimerWLAutoRefresh.Interval = My.App.WLAutoRefreshInterval * 60 * 1000
                        TimerWLAutoRefreshIdle.Interval = My.App.WLAutoRefreshIdleInterval * 1000
                        WatcherWLAutoRefresh.EnableRaisingEvents = True
                        TimerWLAutoRefresh.Start()
                        _WLShowAutoRefresh = True
                        Debug.Print("SetWinLinksAutoRefresh: Watcher Activated")
                    Catch ex As Exception : My.App.WriteToLog(My.App.Tools.WinLinks, "AutoRefresh could not be Activated." & Environment.NewLine & ex.ToString)
                    End Try
                End If
            End If
            App.FrmSettings?.WLShowAutoRefreshState()
        End If
    End Sub
    Friend Sub WLSetManualRefresh()
        WLClose(True)
        App.FrmSettings?.WLSetManualRefresh()
    End Sub
    Private Sub WLSetSettingsState(state As Boolean)
        For Each cmi As ToolStripMenuItem In WLMenus
            For Each mi As ToolStripItem In cmi.DropDown.Items
                If mi.Text = cmi.Text + " Menu" Then
                    Dim smi As ToolStripMenuItem = CType(mi, ToolStripMenuItem)
                    For Each mi2 As ToolStripItem In smi.DropDown.Items : If mi2.Text = "Refresh" Then mi2.Enabled = state
                    Next
                End If
            Next
        Next
        For Each trayicon As NotifyIcon In WLTrayIcons
            For Each mi As ToolStripItem In trayicon.ContextMenuStrip.Items
                If mi.Text = trayicon.Text + " Menu" Then
                    Dim smi As ToolStripMenuItem = CType(mi, ToolStripMenuItem)
                    For Each mi2 As ToolStripItem In smi.DropDown.Items : If mi2.Text = "Refresh" Then mi2.Enabled = state
                    Next
                End If
            Next
        Next
        App.FrmSettings?.WLSetSettingsState(state)
    End Sub
    Private Sub WLFindMenuDataItem(dataset As Collections.Generic.List(Of WLMenuDataItem), file As String, WinLinkIndex As Integer, FoundWinLinkIndices As Collections.Generic.List(Of Integer))
        For Each dataitem As WLMenuDataItem In dataset
            If dataitem.File.StartsWith(file) Then If Not FoundWinLinkIndices.Contains(WinLinkIndex) Then FoundWinLinkIndices.Add(WinLinkIndex)
            If dataitem.SubMenu.Count > 0 Then WLFindMenuDataItem(dataitem.SubMenu, file, WinLinkIndex, FoundWinLinkIndices)
        Next
    End Sub
    Private Function WLGenerateMenuData(ByRef folder As String, ByRef link As My.App.WLItemType) As Collections.Generic.List(Of WLMenuDataItem) '
        Dim md As New Collections.Generic.List(Of WLMenuDataItem)
        If Not link.ShowNoMenu Then
            Try
                Dim folders As String() = Nothing
                Dim filelist As New Collections.Generic.List(Of String)
                If WLMenuItemCount > WLMaxItems Or (link.FolderMode = My.App.WLFolderMode.ShowAsLinkMenu And Not folder = link.Root) Or link.FolderMode = My.App.WLFolderMode.FoldersOnly Then
                    folders = IO.Directory.GetDirectories(folder)
                    If link.Sort = SortOrder.Descending Then Array.Reverse(folders)
                    For Each item As String In folders : filelist.Add(item) : Next
                Else
                    Dim files As String()
                    If link.FolderMode = My.App.WLFolderMode.NoFolders Or (Not link.FolderMode = My.App.WLFolderMode.NoFolders And Not link.FolderPlacement = My.App.WLFolderPlacement.Merged) Then : files = IO.Directory.GetFiles(folder, "*", IO.SearchOption.TopDirectoryOnly)
                    Else : link.FolderPlacement = My.App.WLFolderPlacement.Merged : files = IO.Directory.GetFileSystemEntries(folder)
                    End If
                    If link.Sort = SortOrder.Descending Then Array.Reverse(files)
                    If files.Length > My.App.WLMaxLinksPerFolder Then Array.Resize(Of String)(files, My.App.WLMaxLinksPerFolder)
                    If (Not link.FolderMode = My.App.WLFolderMode.NoFolders And Not link.FolderPlacement = My.App.WLFolderPlacement.Merged) Or WLMenuItemCount > WLMaxItems Then
                        folders = IO.Directory.GetDirectories(folder)
                        If link.Sort = SortOrder.Descending Then Array.Reverse(folders)
                        If folders.Length > My.App.WLMaxLinksPerFolder Then Array.Resize(Of String)(folders, My.App.WLMaxLinksPerFolder)
                    End If
                    If Not link.FolderMode = My.App.WLFolderMode.NoFolders And link.FolderPlacement = My.App.WLFolderPlacement.Top Then For Each item As String In folders : filelist.Add(item) : Next
                    If Not WLMenuItemCount > WLMaxItems Then For Each item As String In files : filelist.Add(item) : Next
                    If Not link.FolderMode = My.App.WLFolderMode.NoFolders And link.FolderPlacement = My.App.WLFolderPlacement.Bottom Then For Each item As String In folders : filelist.Add(item) : Next
                    files = Nothing
                End If
                folders = Nothing
                If filelist.Count > My.App.WLMaxLinksPerFolder Then filelist.RemoveRange(My.App.WLMaxLinksPerFolder, filelist.Count - My.App.WLMaxLinksPerFolder)
                WLMenuItemCount += filelist.Count
                Dim split1 As String()
                Dim menuname As String
                Dim mi As WLMenuDataItem
                For Each file As String In filelist
                    If Not (IO.File.GetAttributes(file) And IO.FileAttributes.Hidden) = IO.FileAttributes.Hidden Then
                        split1 = file.Split(CChar("\"))
                        If IO.Directory.Exists(file) Then : menuname = split1.GetValue(split1.Length - 1).ToString
                        Else
                            Dim split2 As String() = split1.GetValue(split1.Length - 1).ToString.Split(CChar("."))
                            menuname = split2.GetValue(0).ToString
                            If split2.Length > 2 Then : For index As Integer = 1 To split2.Length - 2 : menuname += "." + split2(index) : Next : End If
                            If String.IsNullOrEmpty(menuname) Then menuname = split1.GetValue(split1.Length - 1).ToString
                            split2 = Nothing
                        End If

                        mi = New WLMenuDataItem With {.Text = menuname, .File = file}
                        If link.ShowMenuIcons Then
                            If IO.Directory.Exists(file) Then
                                mi.Icon = CType(My.Resources.Resources.ImageFolder.Clone(), Image)
                            Else
                                Dim ico As Icon = Skye.WinAPI.GetApplicationIcon(file)
                                If ico IsNot Nothing Then
                                    mi.Icon = IconToHighQualityImage(ico)
                                Else
                                    mi.Icon = CType(My.Resources.Resources.iconWL.Clone(), Icon).ToBitmap()
                                End If
                            End If
                        End If
                        mi.SubMenu = New Collections.Generic.List(Of WLMenuDataItem)
                        If IO.Directory.Exists(file) Then
                            mi.IsFolder = True
                            If link.FolderMode = My.App.WLFolderMode.ShowAsLinkMenu Or link.FolderMode = My.App.WLFolderMode.ShowAsMenu Or link.FolderMode = My.App.WLFolderMode.FoldersOnly Then mi.SubMenu = WLGenerateMenuData(file, link)
                        Else : mi.IsFolder = False
                        End If
                        md.Add(mi)
                        split1 = Nothing
                        mi = Nothing
                    End If
                Next
                filelist.Clear()
                filelist.TrimExcess()
                filelist = Nothing
            Catch
            End Try
            md.TrimExcess()
        End If
        WLGenerateMenuData = md
    End Function
    Private Function WLGenerateMenu(ByRef md As Collections.Generic.List(Of WLMenuDataItem), includeicons As Boolean) As ContextMenuStrip '
        Dim cm As New ContextMenuStrip With {
            .Font = App.MenuFont,
            .Renderer = New Skye.UI.SkyeMenuRenderer
        }
        Dim cmi As ToolStripMenuItem
        If Not includeicons Then cm.ShowImageMargin = False
        For Each mi As WLMenuDataItem In md
            cmi = New ToolStripMenuItem
            If includeicons Then cmi.Image = mi.Icon
            If mi.Text.Length > 50 Then
                cmi.Text = My.App.FixAmpersand(mi.Text, 2).Substring(0, 50)
                cmi.ToolTipText = mi.Text
            Else : cmi.Text = My.App.FixAmpersand(mi.Text, 2)
            End If
            If My.App.WLShowFilePathToolTips And Not mi.IsFolder Then cmi.ToolTipText = mi.File
            If My.App.WLShowFileInfoToolTips And Not mi.IsFolder Then
                Try
                    Dim fileinfo As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(mi.File)
                    If Not String.IsNullOrEmpty(fileinfo.Extension) Then cmi.ToolTipText = IIf(String.IsNullOrEmpty(cmi.ToolTipText), Nothing, cmi.ToolTipText + Chr(13)).ToString + fileinfo.Extension.TrimStart(CChar(".")).ToUpper
                    cmi.ToolTipText = IIf(String.IsNullOrEmpty(cmi.ToolTipText), Nothing, cmi.ToolTipText + Chr(13)).ToString + Skye.Common.FormatFileSize(fileinfo.Length, Skye.Common.FormatFileSizeUnits.Auto)
                    cmi.ToolTipText += Chr(13) + "Last Accessed " + fileinfo.LastAccessTime.ToLocalTime.ToString
                    If fileinfo.IsReadOnly Then cmi.ToolTipText += Chr(13) + "READ-ONLY"
                Catch
                End Try
            End If
            If My.App.WLShowFolderPathToolTips And mi.IsFolder Then cmi.ToolTipText = mi.File
            cmi.Tag = mi.File
            AddHandler cmi.MouseUp, AddressOf Me.cmiWLMouseUp
            If mi.SubMenu.Count > 0 Then cmi.DropDown = WLGenerateMenu(mi.SubMenu, includeicons)
            cm.Items.Add(cmi)
        Next
        WLGenerateMenu = cm
    End Function

#End Region
#Region "HotClicks(HC)"

    'Declarations
    Private WithEvents TimerHC As New Timer
    Private HCSender As String = ""
    Private HCInterval As Integer = 0
    Private HCFirstClick As Boolean = True
    Private HCDoubleClick As Boolean = False

    'Control Events
    Private Sub NotifyiconMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim senderName As String = CType(sender, NotifyIcon).Tag.ToString
        Select Case e.Button
            Case MouseButtons.Left
                If Not senderName = HCSender And Not HCFirstClick Then HCResetTimer()
                HCSender = senderName
                If HCFirstClick Then
                    HCFirstClick = False
                    TimerHC.Start()
                ElseIf HCInterval < SystemInformation.DoubleClickTime Then : HCDoubleClick = True
                End If
            Case MouseButtons.Middle
                Select Case senderName
                    Case Me.notifyiconWST.Tag.ToString : HCPerformAction(My.App.HCWSTMiddle)
                    Case Me.notifyiconWSTScreenSaver.Tag.ToString : HCPerformAction(My.App.HCWSTScreenSaverMiddle)
                    Case Else : HCPerformAction(My.App.HCWLMiddle, CType(sender, NotifyIcon).Tag)
                End Select
            Case MouseButtons.Right
                Select Case senderName
                    Case Me.notifyiconWST.Tag.ToString : HCPerformAction(My.App.HCWSTRight)
                    Case Me.notifyiconWSTScreenSaver.Tag.ToString : HCPerformAction(My.App.HCWSTScreenSaverRight)
                    Case Else : HCPerformAction(My.App.HCWLRight)
                End Select
        End Select
    End Sub
    Private Sub CMWSTOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmWST.Opening
        If Not My.App.HCWSTRight = My.App.HCAction.Menu Then e.Cancel = True
    End Sub
    Private Sub CMWSTSSOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmWSTScreenSaver.Opening
        If Not My.App.HCWSTScreenSaverRight = My.App.HCAction.Menu Then e.Cancel = True
    End Sub
    Private Sub RadiobtnHCSettingsClick(ByVal sender As Object, ByVal e As EventArgs) Handles radiobtnHCWSTSS.Click, radiobtnHCWST.Click, radiobtnHCWL.Click
        If radiobtnHCWST.Checked Then : HCShowActions(TrayTools.WorkSpaceTools)
        ElseIf radiobtnHCWL.Checked Then : HCShowActions(TrayTools.WinLinks)
        ElseIf radiobtnHCWSTSS.Checked Then : HCShowActions(TrayTools.ScreenSaver)
        End If
    End Sub
    Private Sub ComboboxHCSettingsSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboboxHCRight.SelectedIndexChanged, comboboxHCMiddle.SelectedIndexChanged, comboboxHCLeft.SelectedIndexChanged, comboboxHCDouble.SelectedIndexChanged
        Select Case CType(sender, ComboBox).Name
            Case Me.comboboxHCLeft.Name
                If Me.radiobtnHCWST.Checked Then : My.App.HCWSTLeft = CType(HCFindActionIndex(Me.comboboxHCLeft.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.radiobtnHCWL.Checked Then : My.App.HCWLLeft = CType(HCFindActionIndex(Me.comboboxHCLeft.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.radiobtnHCWSTSS.Checked Then : My.App.HCWSTScreenSaverLeft = CType(HCFindActionIndex(Me.comboboxHCLeft.SelectedItem.ToString), My.App.HCAction)
                End If
            Case Me.comboboxHCDouble.Name
                If Me.radiobtnHCWST.Checked Then : My.App.HCWSTDouble = CType(HCFindActionIndex(Me.comboboxHCDouble.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.radiobtnHCWL.Checked Then : My.App.HCWLDouble = CType(HCFindActionIndex(Me.comboboxHCDouble.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.radiobtnHCWSTSS.Checked Then : My.App.HCWSTScreenSaverDouble = CType(HCFindActionIndex(Me.comboboxHCDouble.SelectedItem.ToString), My.App.HCAction)
                End If
            Case Me.comboboxHCMiddle.Name
                If Me.radiobtnHCWST.Checked Then : My.App.HCWSTMiddle = CType(HCFindActionIndex(Me.comboboxHCMiddle.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.radiobtnHCWL.Checked Then : My.App.HCWLMiddle = CType(HCFindActionIndex(Me.comboboxHCMiddle.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.radiobtnHCWSTSS.Checked Then : My.App.HCWSTScreenSaverMiddle = CType(HCFindActionIndex(Me.comboboxHCMiddle.SelectedItem.ToString), My.App.HCAction)
                End If
            Case Me.comboboxHCRight.Name
                If Me.radiobtnHCWST.Checked Then : My.App.HCWSTRight = CType(HCFindActionIndex(Me.comboboxHCRight.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.radiobtnHCWSTSS.Checked Then : My.App.HCWSTScreenSaverRight = CType(HCFindActionIndex(Me.comboboxHCRight.SelectedItem.ToString), My.App.HCAction)
                End If
        End Select
    End Sub

    'Handlers
    Private Sub TimerHCTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerHC.Tick
        HCInterval += 100
        If HCInterval >= SystemInformation.DoubleClickTime Then
            TimerHC.Stop()

            If HCDoubleClick Then
                Select Case HCSender
                    Case Me.notifyiconWST.Tag.ToString : HCPerformAction(My.App.HCWSTDouble)
                    Case Me.notifyiconWSTScreenSaver.Tag.ToString : HCPerformAction(My.App.HCWSTScreenSaverDouble)
                    Case Else : Try : HCPerformAction(My.App.HCWLDouble, CType(HCSender, Integer)) : Catch : End Try
                End Select
            Else
                Select Case HCSender
                    Case Me.notifyiconWST.Tag.ToString : HCPerformAction(My.App.HCWSTLeft)
                    Case Me.notifyiconWSTScreenSaver.Tag.ToString : HCPerformAction(My.App.HCWSTScreenSaverLeft)
                    Case Else : Try : HCPerformAction(My.App.HCWLLeft, CType(HCSender, Integer)) : Catch : End Try
                End Select
            End If
            HCResetTimer()
        End If
    End Sub

    'Procedures
    Private Sub HCPerformAction(action As My.App.HCAction, Optional argument As Object = Nothing)
        Select Case action
            Case My.App.HCAction.WLNew
                If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then
                    App.ShowSettings("WL")
                    App.FrmSettings.WLSetNew()
                End If
            Case My.App.HCAction.WLEdit
                If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then
                    If argument Is Nothing Then argument = 0
                    App.ShowSettings("WL")
                    App.FrmSettings.WLEdit(CInt(argument))
                End If
            Case My.App.HCAction.WLOpenRoot
                If argument Is Nothing Then argument = 0
                WLStartLink(My.App.WLData(CInt(argument)).Root)
            Case My.App.HCAction.WLRefresh
                If argument Is Nothing Then argument = My.App.WLData.Count - 1
                Dim link As My.App.WLItemType = My.App.WLData(CInt(argument))
                link.RefreshData = True
                link.RefreshMenu = True
                My.App.WLData(CInt(argument)) = link
                ShowWL()
            Case My.App.HCAction.WSTLockWorkSpace
                WSTLockWorkSpace(True)
            Case My.App.HCAction.WSTScreenSaverActivate
                App.SSActivate()
            Case My.App.HCAction.WSTScreenSaverDisable
                WSTSSEnabled = Not WSTSSEnabled
            Case My.App.HCAction.WSTClock
                App.ShowClock()
            Case My.App.HCAction.ShowSettings
                App.ShowSettings()
            Case My.App.HCAction.ShowSettingsWST
                App.ShowSettings("WST")
            Case My.App.HCAction.ShowSettingsWSTSS
                App.ShowSettings("SS")
            Case My.App.HCAction.ShowSettingsWL
                App.ShowSettings("WL")
            Case My.App.HCAction.ShowSettingsAC
                App.ShowSettings("AC")
            Case My.App.HCAction.ShowSettingsHC
                App.ShowSettings("HC")
            Case My.App.HCAction.ShowSettingsHK
                App.ShowSettings("HK")
        End Select
    End Sub
    Private Sub HCShowActions(tool As My.App.TrayTools)
        Me.comboboxHCRight.Enabled = True
        Select Case tool
            Case My.App.TrayTools.WorkSpaceTools
                Me.comboboxHCLeft.SelectedIndex = Me.comboboxHCLeft.FindStringExact(My.App.HCActions(My.App.HCWSTLeft).Description)
                Me.comboboxHCDouble.SelectedIndex = Me.comboboxHCDouble.FindStringExact(My.App.HCActions(My.App.HCWSTDouble).Description)
                Me.comboboxHCMiddle.SelectedIndex = Me.comboboxHCMiddle.FindStringExact(My.App.HCActions(My.App.HCWSTMiddle).Description)
                Me.comboboxHCRight.SelectedIndex = Me.comboboxHCRight.FindStringExact(My.App.HCActions(My.App.HCWSTRight).Description)
            Case My.App.TrayTools.WinLinks
                Me.comboboxHCLeft.SelectedIndex = Me.comboboxHCLeft.FindStringExact(My.App.HCActions(My.App.HCWLLeft).Description)
                Me.comboboxHCDouble.SelectedIndex = Me.comboboxHCDouble.FindStringExact(My.App.HCActions(My.App.HCWLDouble).Description)
                Me.comboboxHCMiddle.SelectedIndex = Me.comboboxHCMiddle.FindStringExact(My.App.HCActions(My.App.HCWLMiddle).Description)
                Me.comboboxHCRight.SelectedIndex = Me.comboboxHCRight.FindStringExact(My.App.HCActions(My.App.HCWLRight).Description)
                Me.comboboxHCRight.Enabled = False
            Case My.App.TrayTools.ScreenSaver
                Me.comboboxHCLeft.SelectedIndex = Me.comboboxHCLeft.FindStringExact(My.App.HCActions(My.App.HCWSTScreenSaverLeft).Description)
                Me.comboboxHCDouble.SelectedIndex = Me.comboboxHCDouble.FindStringExact(My.App.HCActions(My.App.HCWSTScreenSaverDouble).Description)
                Me.comboboxHCMiddle.SelectedIndex = Me.comboboxHCMiddle.FindStringExact(My.App.HCActions(My.App.HCWSTScreenSaverMiddle).Description)
                Me.comboboxHCRight.SelectedIndex = Me.comboboxHCRight.FindStringExact(My.App.HCActions(My.App.HCWSTScreenSaverRight).Description)
        End Select
    End Sub
    Private Sub HCResetTimer()
        HCSender = ""
        HCInterval = 0
        HCFirstClick = True
        HCDoubleClick = False
    End Sub
    Private Function HCFindActionIndex(description As String) As Integer
        For index As Integer = 0 To My.App.HCActions.Count - 1 : If My.App.HCActions(index).Description = description Then Return index
        Next
        Return 0
    End Function

#End Region
#Region "HotKeys(HK)"

    'Declarations
    Private HKInUse As New Collections.Generic.List(Of Keys)

    'Control Events
    Private Sub TextboxHKPreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs) Handles textboxHKWSTScreenSaver.PreviewKeyDown, textboxHKWSTLockWorkSpace.PreviewKeyDown, textboxHKWSTClock.PreviewKeyDown, textboxHKWL.PreviewKeyDown
        Dim senderTextBox = CType(sender, TextBox)
        Dim senderTag = CType(senderTextBox.Tag, HKType)
        If e.KeyData <> senderTag.Key Then

            'Setup New HotKey
            Dim newhotkey As New HKType
            Dim modifiers = 0
            Dim match = False
            If e.Shift Then modifiers += Skye.WinAPI.MOD_SHIFT
            If e.Control Then modifiers += Skye.WinAPI.MOD_CONTROL
            If e.Alt Then modifiers += Skye.WinAPI.MOD_ALT
            newhotkey.Description = senderTag.Description
            newhotkey.WinID = senderTag.WinID
            newhotkey.Key = e.KeyData
            newhotkey.KeyCode = CByte(e.KeyValue)
            newhotkey.KeyMod = CByte(modifiers)

            'Check If Already In-Use
            HKGenerateUsedKeyList()
            If Not CType(textboxHKWSTLockWorkSpace.Tag, HKType).Key = HKWSTLockWorkSpace.Key Then HKInUse.Add(CType(textboxHKWSTLockWorkSpace.Tag, HKType).Key)
            If Not CType(textboxHKWSTScreenSaver.Tag, HKType).Key = HKWSTScreenSaver.Key Then HKInUse.Add(CType(textboxHKWSTScreenSaver.Tag, HKType).Key)
            If Not CType(textboxHKWSTClock.Tag, HKType).Key = HKWSTClock.Key Then HKInUse.Add(CType(textboxHKWSTClock.Tag, HKType).Key)
            If Not CType(textboxHKWL.Tag, HKType).Key = HKWL.Key Then HKInUse.Add(CType(textboxHKWL.Tag, HKType).Key)
            For Each usedkey In HKInUse : If usedkey = newhotkey.Key Then match = True
            Next

            'Display New HotKey If Not Already In-Use
            If Not match Then
                senderTextBox.Font = New Font(Font, FontStyle.Regular)
                senderTextBox.ForeColor = Color.Maroon
                senderTextBox.Text = e.KeyData.ToString
                senderTextBox.Tag = newhotkey
                btnHKReset.Enabled = True
                btnHKSet.Enabled = True
            End If
        End If
    End Sub
    Private Sub TextboxHKKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles textboxHKWSTScreenSaver.KeyPress, textboxHKWSTLockWorkSpace.KeyPress, textboxHKWSTClock.KeyPress, textboxHKWL.KeyPress
        e.Handled = True
    End Sub
    Private Sub BtnHKDisableClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHKWSTScreenSaverDisable.Click, btnHKWSTLockWorkSpaceDisable.Click, btnHKWSTClockDisable.Click, btnHKWLDisable.Click
        Dim senderTextBox As New TextBox
        Dim senderTag As New HKType
        Select Case CType(sender, Button).Name
            Case btnHKWSTLockWorkSpaceDisable.Name
                senderTextBox = textboxHKWSTLockWorkSpace
                senderTag = CType(textboxHKWSTLockWorkSpace.Tag, HKType)
            Case btnHKWSTScreenSaverDisable.Name
                senderTextBox = textboxHKWSTScreenSaver
                senderTag = CType(textboxHKWSTScreenSaver.Tag, HKType)
            Case btnHKWSTClockDisable.Name
                senderTextBox = textboxHKWSTClock
                senderTag = CType(textboxHKWSTClock.Tag, HKType)
            Case btnHKWLDisable.Name
                senderTextBox = textboxHKWL
                senderTag = CType(textboxHKWL.Tag, HKType)
        End Select

        Dim newhotkey As New HKType With {
            .Description = senderTag.Description,
            .WinID = senderTag.WinID,
            .Key = Keys.None,
            .KeyCode = 0,
            .KeyMod = 0}
        senderTextBox.Font = New Font(Font, FontStyle.Regular)
        senderTextBox.ForeColor = Color.Maroon
        senderTextBox.Text = newhotkey.Key.ToString
        senderTextBox.Tag = newhotkey
        btnHKReset.Enabled = True
        btnHKSet.Enabled = True
        btnHKSet.Focus()
    End Sub
    Private Sub BtnHKDisableEnter(ByVal sender As Object, ByVal e As EventArgs) Handles btnHKWSTScreenSaverDisable.Enter, btnHKWSTLockWorkSpaceDisable.Enter, btnHKWSTClockDisable.Enter, btnHKWLDisable.Enter
        If btnHKSet.Enabled Then : btnHKSet.Focus()
        Else : btnClose.Focus()
        End If
    End Sub
    Private Sub BtnHKEnabledClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHKEnabled.Click
        My.App.HKEnabled = Not My.App.HKEnabled
        HKRegister()
        ShowSettings(My.App.Tools.HotKeys)
    End Sub
    Private Sub BtnHKSetClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHKSet.Click
        If Not CType(Me.textboxHKWSTLockWorkSpace.Tag, My.App.HKType).Key = My.App.HKWSTLockWorkSpace.Key Then My.App.HKWSTLockWorkSpace = CType(Me.textboxHKWSTLockWorkSpace.Tag, My.App.HKType)
        If Not CType(Me.textboxHKWSTScreenSaver.Tag, My.App.HKType).Key = My.App.HKWSTScreenSaver.Key Then My.App.HKWSTScreenSaver = CType(Me.textboxHKWSTScreenSaver.Tag, My.App.HKType)
        If Not CType(Me.textboxHKWSTClock.Tag, My.App.HKType).Key = My.App.HKWSTClock.Key Then My.App.HKWSTClock = CType(Me.textboxHKWSTClock.Tag, My.App.HKType)
        If Not CType(Me.textboxHKWL.Tag, My.App.HKType).Key = My.App.HKWL.Key Then My.App.HKWL = CType(Me.textboxHKWL.Tag, My.App.HKType)
        My.App.HKGenerateKeyList()
        HKRegister()
        ShowSettings(My.App.Tools.HotKeys)
    End Sub
    Private Sub BtnHKResetClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHKReset.Click
        ShowSettings(My.App.Tools.HotKeys)
    End Sub

    'Procedures
    Private Sub HKRegister(Optional UnRegisterONLY As Boolean = False)

        'UnRegister All HotKeys First
        For Each key As My.App.HKType In My.App.HKKeys : Skye.WinAPI.UnregisterHotKey(Me.Handle, key.WinID) : Next

        'Register All HotKeys Where Key Is Not 'NONE'
        If My.App.HKEnabled And Not UnRegisterONLY Then
            Dim status As Boolean
            For Each key As My.App.HKType In My.App.HKKeys
                If Not key.Key = Keys.None Then
                    status = Skye.WinAPI.RegisterHotKey(Me.Handle, key.WinID, key.KeyMod, key.KeyCode)
                    If Not status Then My.App.WriteToLog(My.App.Tools.HotKeys, "RegisterHotKey : " + key.Description + " (" + key.WinID.ToString + ") (" + key.Key.ToString + ") (" + key.KeyCode.ToString + " mod " + key.KeyMod.ToString + ") : " + IIf(status, "Succeeded", "Failed").ToString)
                End If
            Next
        End If

    End Sub
    Private Sub HKPerformAction(hotkey As Integer)
        Select Case hotkey
            Case My.App.HKWSTLockWorkSpace.WinID : WSTLockWorkSpace()
            Case My.App.HKWSTScreenSaver.WinID : App.SSActivate(True)
            Case My.App.HKWSTClock.WinID : App.ShowClock()
            Case My.App.HKWL.WinID : If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then WLStartLink(My.App.WLData(My.App.WLData.Count - 1).Root)
        End Select
    End Sub
    Private Sub HKGenerateUsedKeyList()
        HKInUse.Clear()
        HKInUse.Add(CType(131137, Keys)) ' A, Control ' Select All
        HKInUse.Add(CType(131139, Keys)) ' C, Control ' Copy
        HKInUse.Add(CType(131160, Keys)) ' X, Control ' Cut / Clear
        HKInUse.Add(CType(131158, Keys)) ' V, Control ' Paste
        HKInUse.Add(CType(131155, Keys)) ' S, Control ' Save As
        For Each key As My.App.HKType In My.App.HKKeys : HKInUse.Add(key.Key)
        Next
    End Sub

#End Region

    ' Declarations
    Private Structure ProcessListType
        Dim ProcessName As String
        Dim FileName As String
        Dim Icon As Icon
    End Structure
    Private Class ProcessListComparer
        Implements Collections.Generic.IComparer(Of ProcessListType)
        Private Function Compare(ByVal x As ProcessListType, ByVal y As ProcessListType) As Integer Implements Collections.Generic.IComparer(Of ProcessListType).Compare '
            If x.ProcessName Is Nothing Then
                If y.ProcessName Is Nothing Then : Return 0
                Else : Return -1
                End If
            Else
                If y.ProcessName Is Nothing Then : Return 1
                Else : Return x.ProcessName.CompareTo(y.ProcessName)
                End If
            End If
        End Function
    End Class
    Private TipCM As Skye.UI.ToolTipEX ' Tooltip for Context Menu Items

    ' Form Events
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case Skye.WinAPI.WM_SYSCOMMAND
                Select Case CInt(m.WParam)
                    Case Skye.WinAPI.SC_CLOSE
#If DEBUG Then
                        Me.Close()
#Else
                        Me.Hide()
#End If
                    Case Else : MyBase.WndProc(m)
                End Select
            Case Skye.WinAPI.WM_HOTKEY
                Try
                    HKPerformAction(m.WParam.ToInt32)
                Catch ex As Exception
                    App.WriteToLog(App.Tools.SkyeTools, "HotKey Failed --> " + ex.Message)
                Finally
                    MyBase.WndProc(m)
                End Try
            Case Else : MyBase.WndProc(m)
        End Select
    End Sub
    Friend Sub New()

        'Initialize Locals
        InitializeComponent()
        TimerAC.Interval = 1000
        BackgroundworkerWL.WorkerSupportsCancellation = True
        BackgroundworkerAC.WorkerSupportsCancellation = True
        cmWLItem.Font = App.MenuFont
        cmWLItem.ShowItemToolTips = False
        Me.imagelisttabcontrolSettings = New ImageList(Me.components) With {
            .ColorDepth = ColorDepth.Depth32Bit,
            .ImageSize = New Size(16, 16),
            .TransparentColor = System.Drawing.Color.Transparent}
        Me.imagelisttabcontrolSettings.Images.Add("imageHC", My.Resources.Resources.ImageHC16)
        Me.imagelisttabcontrolSettings.Images.Add("imageHK", My.Resources.Resources.imageHK)
        Me.tabcontrolSettings.ImageList = Me.imagelisttabcontrolSettings
        Me.tabpageAC.Text = My.App.ToolToString(My.App.Tools.AlarmChime)
        Me.tabpageAC.ImageKey = "imageAC"
        Me.tabpageHC.Text = My.App.ToolToString(My.App.Tools.HotClicks)
        Me.tabpageHC.ImageKey = "imageHC"
        Me.tabpageHK.Text = My.App.ToolToString(My.App.Tools.HotKeys)
        Me.tabpageHK.ImageKey = "imageHK"
        Me.tabpageWL.Text = My.App.ToolToString(My.App.Tools.WinLinks)
        Me.tabpageWL.ImageKey = "imageWL"
        Me.tabpageWST.Text = My.App.ToolToString(My.App.Tools.WorkSpaceTools)
        Me.tabpageWST.ImageKey = "imageWST"

        'Initialize Form
        Me.cmiWSTCloseAll.ToolTipText = My.App.CloseAllToolTipText
        Me.cmiScreenSaverCloseAll.ToolTipText = My.App.CloseAllToolTipText
        Me.notifyiconWST = New NotifyIcon(Me.components) With {
            .Tag = "notifyiconWST",
            .ContextMenuStrip = cmWST}
        Me.notifyiconWSTScreenSaver = New NotifyIcon(Me.components) With {
            .Tag = "notifyiconWSTScreenSaver",
            .ContextMenuStrip = cmWSTScreenSaver}
        Me.cmiWSTScreenSaverActivate.Image = My.Resources.Resources.ImageWSTSS16
        Me.cmiScreenSaverActivate.Image = My.Resources.Resources.ImageWSTSS16
        AddHandler Me.notifyiconWST.MouseDown, AddressOf NotifyiconMouseDown
        AddHandler Me.notifyiconWSTScreenSaver.MouseDown, AddressOf NotifyiconMouseDown
        WLSetSettingsState(True)
#If DEBUG Then
        BackgroundworkerWL.WorkerReportsProgress = True
#End If

    End Sub
    Private Sub FrmLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
#If DEBUG Then
#Else
		My.App.SetLoadOnOSStartup()
#End If
        ShowSettings()
        ACSet()
        HKRegister()
        TipCM = New Skye.UI.ToolTipEX() With {
            .Font = App.MenuFont,
            .ShadowAlpha = 0,
            .ShadowThickness = 0,
            .FadeInRate = 25,
            .FadeOutRate = 25,
            .HideDelay = 5000,
            .ShowDelay = 250
        }
        App.HookTSItemsForCMTooltip(cmWST, TipCM)
        App.HookTSItemsForCMTooltip(cmWSTScreenSaver, TipCM)
        Skye.UI.ThemeManager.RegisterComponent(TipInfoEX)
        Skye.UI.ThemeManager.RegisterComponent(TipHCEX)
        Skye.UI.ThemeManager.RegisterComponent(TipCM)
        Skye.UI.ThemeManager.ApplyTheme(Me)
        cmWST.Renderer = New Skye.UI.SkyeMenuRenderer
        cmWSTScreenSaver.Renderer = New Skye.UI.SkyeMenuRenderer
        cmWLItem.Renderer = New Skye.UI.SkyeMenuRenderer
    End Sub
    Private Sub FrmShown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
        Me.Hide()
        Me.Opacity = 1
        If Not My.Application.AlternateStart AndAlso ((My.App.WSTShowWLMenu Or My.App.WSTShowWLTray) And My.App.WLStartUpDelay > 0) Then WLStartUp = True
        If Not My.Application.AlternateStart AndAlso (My.App.WSTShowWLMenu And Not My.App.WSTShowWLTray) Then ShowWL()
        Select Case My.App.WSTSSStartUp
            Case My.App.WSTSSStartUpMode.Enabled
                WSTSSEnabled = True
            Case My.App.WSTSSStartUpMode.Disabled
                WSTSSEnabled = False
        End Select
        ShowTools()
        If Not My.Application.AlternateStart AndAlso ((My.App.WSTShowWLMenu Or My.App.WSTShowWLTray) And My.App.WLStartUpDelay > 0) Then
            TimerWLStartUp.Interval = My.App.WLStartUpDelay * 1000
            TimerWLStartUp.Start()
            Me.cmseparatorWSTCancel.Visible = True
        End If
        UpdateWST()
#If DEBUG Then
        Me.Left = 0
        Me.Top = CInt(My.Computer.Screen.Bounds.Height / 2 - Me.Height / 2)
        Me.Show()
#Else
#End If
    End Sub
    Private Sub FrmClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Dispose of the clock so the form closes
        If App.FrmClock IsNot Nothing Then
            App.FrmClock.Hide()
            App.FrmClock.Dispose()
        End If
        ' Unregister hotkeys so they don't trigger after the form closes
        HKRegister(True)
        ' Disposing timers purges queued callbacks from the Windows message queue
        Try
            TimerWLAutoRefresh?.Stop()
            TimerWLAutoRefresh?.Dispose()
            TimerWLAutoRefreshIdle?.Stop()
            TimerWLAutoRefreshIdle?.Dispose()
        Catch
        End Try
        ' Disable the FileSystemWatcher explicitly before disposing UI components
        Try
            WatcherWLAutoRefresh.EnableRaisingEvents = False
            WatcherWLAutoRefresh.Dispose()
        Catch
            ' Suppress teardown exceptions
        End Try
        ' If the worker is running during shutdown/refresh, cancel it cleanly
        If BackgroundworkerWL.IsBusy Then
            If BackgroundworkerWL.WorkerSupportsCancellation Then
                BackgroundworkerWL.CancelAsync()
            End If
        End If
        ' Close WinLinks
        WLClose(True)
        ' Finalize
        My.App.Finalize()
    End Sub

    ' Control Events
    Private Sub CMICloseAllMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTCloseAll.MouseUp, cmiScreenSaverCloseAll.MouseUp
        Me.Close()
        If e.Button = MouseButtons.Right Then
            Select Case My.Computer.Keyboard.CtrlKeyDown
                Case True : System.Windows.Forms.Application.Restart()
                Case False : Diagnostics.Process.Start(My.Computer.FileSystem.CombinePath(My.Application.Info.DirectoryPath, My.Application.Info.AssemblyName + ".exe"))
            End Select
        End If
    End Sub
    Private Sub BtnCloseClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        App.ShowSettings()
    End Sub

    ' Methods
    Friend Sub ShowTools()
        If Not (My.App.WSTEnabled Or My.App.WSTShowSSIcon Or My.App.WSTShowWLTray) Then
            Me.Close() 'No Tools Running(That Have A Tray Icon), So Close Application
        Else 'Any One or More Tools Running(That Have A Tray Icon)
            If My.App.WSTEnabled Then
                UpdateWST()
                ShowWST()
                Me.notifyiconWST.Visible = True
            Else
                Me.notifyiconWST.Visible = False
            End If
            If App.WSTSSToolEnabled Then
                If App.WSTSSToolEnabled AndAlso App.WSTShowSSIcon Then
                    Me.notifyiconWSTScreenSaver.Visible = True
                Else
                    Me.notifyiconWSTScreenSaver.Visible = False
                End If
            Else
                Me.notifyiconWSTScreenSaver.Visible = False
            End If
            If Not My.Application.AlternateStart AndAlso My.App.WSTShowWLTray Then
                If WLTrayIcons.Count = 0 Then ShowWL()
            Else
                If WLTrayIcons.Count > 0 Then WLClose()
            End If
        End If
    End Sub
    Private Function IconToHighQualityImage(ic As Icon) As Image
        Dim bmp As Bitmap = ic.ToBitmap()
        Return CType(bmp.Clone(), Image)
    End Function
    Private Function CloseApplications(tool As My.App.Tools, closelist As Collections.Generic.List(Of String), Optional timeout As Byte = 60, Optional generateOArestartlist As Boolean = False) As Boolean '
        Try
            For Each i As String In closelist
                App.ShowMessage(tool, "Closing " + i.ToUpper, Nothing)
                Dim plist As Diagnostics.Process() = Diagnostics.Process.GetProcessesByName(i)
                For Each p As Diagnostics.Process In plist
                    If p.CloseMainWindow Then
                        If Not p.WaitForExit(timeout * 1000) Then p.Kill()
                    Else
                        p.Kill()
                    End If
                    'If usealt Then
                    '	If p.CloseMainWindow Then : If Not p.WaitForExit(timeout * 1000) Then p.Kill()
                    '	Else : p.Kill()
                    '	End If
                    'Else
                    '	Dim pcloseappinfo As New Diagnostics.ProcessStartInfo
                    '	pcloseappinfo.FileName = "PROCESS.EXE"
                    '	pcloseappinfo.Arguments = "-q " + p.Id.ToString + " " + timeout.ToString
                    '	pcloseappinfo.WindowStyle = Diagnostics.ProcessWindowStyle.Hidden
                    '	Dim pcloseapp As Diagnostics.Process = Diagnostics.Process.Start(pcloseappinfo)
                    '	pcloseapp.WaitForExit()
                    '	pcloseapp.Dispose()
                    'End If
                Next
            Next
            If closelist.Count > 0 Then My.App.WriteToLog(tool, "Application Closure Completed")
            CloseApplications = True 'DO NOT use RETURN here because SMStandByEnd will not execute if you do!!
        Catch ex As Exception
            My.App.WriteToLog(tool, "Application Closure FAILED! " + ex.Message)
            CloseApplications = False 'DO NOT use RETURN here because SMStandByEnd will not execute if you do!!
        End Try
    End Function

End Class
