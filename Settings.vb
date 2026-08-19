
Imports System.ComponentModel
Imports System.IO
Imports Skye.UI
Imports SkyeTools.My

Partial Friend Class Settings

    ' DECLARATIONS
    Private mMove As Boolean = False
    Private mOffset As Point
    Private nonNumberEntered As Boolean
    Private suppressPageSelection As Boolean = False
    Private OFDLoadOnOSStartup As New OpenFileDialog
    Private OFDACSelectWAV As New OpenFileDialog
    Private FBDWLFolderBrowser As New FolderBrowserDialog

    ' FORM EVENTS
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case Skye.WinAPI.WM_SYSCOMMAND
                Select Case CInt(m.WParam)
                    Case Skye.WinAPI.SC_CLOSE
                        App.HideSettings()
                    Case Else
                        MyBase.WndProc(m)
                End Select
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub
    Friend Sub New()

        InitializeComponent()

        Text = "Settings For " + My.Application.Info.Title + "  v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
        ILPageSelector.Images.Add(My.Resources.Resources.ImageApp32)
        ILPageSelector.Images.Add(My.Resources.Resources.ImageWST48)
        ILPageSelector.Images.Add(My.Resources.Resources.ImageWSTSS48)
        ILPageSelector.Images.Add(My.Resources.Resources.ImageAC48)
        ILPageSelector.Images.Add(My.Resources.Resources.ImageWL48)
        ILPageSelector.Images.Add(My.Resources.Resources.ImageHC48)
        ILPageSelector.Images.Add(My.Resources.Resources.ImageHK48)
        LVPageSelector.Items.Add(New ListViewItem("App", 0) With {.Tag = "APP"})
        LVPageSelector.Items.Add(New ListViewItem("Workspace Tools", 1) With {.Tag = "WST"})
        LVPageSelector.Items.Add(New ListViewItem("Screen Saver", 2) With {.Tag = "SS"})
        LVPageSelector.Items.Add(New ListViewItem("Alarm & Chime", 3) With {.Tag = "AC"})
        LVPageSelector.Items.Add(New ListViewItem("WinLinks", 4) With {.Tag = "WL"})
        LVPageSelector.Items.Add(New ListViewItem("HotClicks", 5) With {.Tag = "HC"})
        LVPageSelector.Items.Add(New ListViewItem("HotKeys", 6) With {.Tag = "HK"})
        LVPageSelector.Items(0).Selected = True
        OFDLoadOnOSStartup.DefaultExt = "exe"
        OFDLoadOnOSStartup.Filter = "Executable Files|*.exe|Batch Files|*.bat"
        OFDLoadOnOSStartup.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        OFDLoadOnOSStartup.Title = "Select An Application..."
        OFDACSelectWAV.DefaultExt = "wav"
        OFDACSelectWAV.Filter = "WAV Files|*.wav"
        OFDACSelectWAV.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Windows) & "\Media"
        OFDACSelectWAV.Title = "Select a WAV File..."
        FBDWLFolderBrowser.Description = "Select a Folder with ShortCuts or Programs..."
        FBDWLFolderBrowser.ShowNewFolderButton = False
        For Each thm As Skye.UI.SkyeTheme In Skye.UI.SkyeThemes.AllThemes
            CoBoxTheme.Items.Add(thm.Name)
        Next
        For Each s As String In [Enum].GetNames(Of WSTSSStartUpMode)()
            Me.CoBoxSSStartUp.Items.Add(s)
        Next

    End Sub
    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ShowSettings()
        SetSS()
        SetAC()
        ACUpdateMute()
        SetWL()
        WLShowAutoRefreshState()
    End Sub
    Private Sub Settings_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
#If DEBUG Then
        BtnErrorTest.Visible = True
#Else
#End If
        Skye.WinAPI.SetListViewSpacing(LVPageSelector, 87, 105)
        LVPageSelector.Focus()
        Skye.UI.ThemeManager.RegisterComponent(TipInfoEX)
        Skye.UI.ThemeManager.ApplyTheme(Me)
        App.HookListViewForCMTooltip(listviewWL, TipInfoEX)
        ShowSave()
    End Sub
    Private Sub Settings_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, PanelApp.MouseDown, PanelWST.MouseDown, PanelSS.MouseDown, PanelAC.MouseDown, PanelWL.MouseDown, PanelHC.MouseDown, PanelHK.MouseDown, PanelActions.MouseDown
        If e.Button = MouseButtons.Left AndAlso WindowState = FormWindowState.Normal Then
            mMove = True
            ' Convert the click point inside the panel/control directly into Screen coordinates
            Dim ctrl As Control = DirectCast(sender, Control)
            Dim clickScreenPoint As Point = ctrl.PointToScreen(e.Location)

            ' Calculate how far the mouse is from the Form's top-left screen Location
            mOffset = New Point(clickScreenPoint.X - Me.Location.X, clickScreenPoint.Y - Me.Location.Y)
        End If
    End Sub
    Private Sub Settings_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, PanelApp.MouseMove, PanelWST.MouseMove, PanelSS.MouseMove, PanelAC.MouseMove, PanelWL.MouseMove, PanelHC.MouseMove, PanelHK.MouseMove, PanelActions.MouseMove
        If mMove Then
            Dim currentMouseScreenPoint As Point = Cursor.Position
            Dim newLocation As New Point(currentMouseScreenPoint.X - mOffset.X, currentMouseScreenPoint.Y - mOffset.Y)

            CheckMove(newLocation)

            Me.Location = newLocation
        End If
    End Sub
    Private Sub Settings_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, PanelApp.MouseUp, PanelWST.MouseUp, PanelSS.MouseUp, PanelAC.MouseUp, PanelWL.MouseUp, PanelHC.MouseUp, PanelHK.MouseUp, PanelActions.MouseUp
        mMove = False
    End Sub
    Private Sub Settings_Move(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Move
        If Not mMove AndAlso Me.WindowState = FormWindowState.Normal Then CheckMove(Me.Location)
    End Sub

    ' CONTROL EVENTS
    Private Sub PanelPage_Paint(sender As Object, e As PaintEventArgs) Handles PanelApp.Paint, PanelWST.Paint, PanelSS.Paint, PanelAC.Paint, PanelWL.Paint, PanelHC.Paint, PanelHK.Paint
        Dim pagePanel As Panel = DirectCast(sender, Panel)
        Using p As New Pen(Color.FromArgb(100, 100, 100))
            e.Graphics.DrawLine(p, 0, 0, 0, pagePanel.Height)
        End Using
        Using p As New Pen(Color.FromArgb(60, 60, 60))
            e.Graphics.DrawLine(p, 0, pagePanel.Height - 1, pagePanel.Width, pagePanel.Height - 1)
        End Using
    End Sub
    Private Sub PanelActions_Paint(sender As Object, e As PaintEventArgs) Handles PanelActions.Paint
        Using p As New Pen(Color.FromArgb(60, 60, 60), 2.0F)
            e.Graphics.DrawLine(p, 0, 0, PanelActions.Width, 0)
        End Using
    End Sub
    Private Sub LVPageSelector_MouseDown(sender As Object, e As MouseEventArgs) Handles LVPageSelector.MouseDown
        ' Find the item under the mouse
        suppressPageSelection = True
        Dim info As ListViewHitTestInfo = LVPageSelector.HitTest(e.Location)
        Dim item As ListViewItem = info.Item
        If item Is Nothing Then Return

        ' Ensure it becomes selected (for visual feedback)
        item.Selected = True
        Dim selectedSource As String = item.Tag.ToString

        Select Case e.Clicks
            Case 1
                SetPage(selectedSource)
            Case 2
        End Select
        suppressPageSelection = False
    End Sub
    Private Sub LVPageSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVPageSelector.SelectedIndexChanged
        If suppressPageSelection OrElse LVPageSelector.SelectedItems.Count = 0 Then Return
        Dim selectedSource As String = LVPageSelector.SelectedItems(0).Text
        SetPage(LVPageSelector.SelectedItems(0).Tag.ToString)
    End Sub
    Private Sub BtnHelp_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles BtnHelp.MouseUp
        If e.X >= 0 And e.X <= CType(sender, Button).Width And e.Y >= 0 And e.Y <= CType(sender, Button).Height Then
            Select Case e.Button
                Case MouseButtons.Left : My.App.ShowHelp(False)
                Case MouseButtons.Right : My.App.ShowHelp(True)
            End Select
        End If
    End Sub
    Private Sub BtnLog_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles BtnLog.MouseUp
        If e.X >= 0 And e.X <= CType(sender, Button).Width And e.Y >= 0 And e.Y <= CType(sender, Button).Height Then
            Select Case e.Button
                Case MouseButtons.Left : App.ShowLog(False)
                Case MouseButtons.Right : App.ShowLog(True)
            End Select
            If App.ErrorAlert Then App.ClearErrorAlert()
        End If
    End Sub
    Private Sub BtnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClose.Click
        App.HideSettings()
    End Sub
    Private Sub BtnErrorTest_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles BtnErrorTest.MouseUp
        If e.X >= 0 And e.X <= CType(sender, Button).Width And e.Y >= 0 And e.Y <= CType(sender, Button).Height Then
            Select Case e.Button
                Case MouseButtons.Left
                    App.SetErrorAlert()
                    MessageBox.Show(Me, "Just Checking, DO NOT PANIC!!", "Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    App.WriteToLog(App.Tools.SkyeTools, "Test Error - DO NOT PANIC!!")
                Case MouseButtons.Right
                    App.SetErrorAlert()
                    App.WriteToLog(App.Tools.SkyeTools, "Test Exception - DO NOT PANIC!!")
                    Throw New Exception("Test Exception - DO NOT PANIC!!")
            End Select
        End If
    End Sub
    Private Sub BtnSaveSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSaveSettings.Click
        App.SaveSettings()
        App.NeedsSaved = False
        ShowSave()
    End Sub
    Private Sub BtnRestoreSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRestoreSettings.Click
        RestoreSettings()
    End Sub
    ''' <summary>
    ''' Suppresses the system ding on Enter and forces the form to validate the control.
    ''' Call this from the TextBox KeyDown handler.
    ''' </summary>
    Private Shared Sub TextboxHandleEnterKey(sender As Object, e As KeyEventArgs) Handles TxtBoxLoadOnOSStartupArgs.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' 1. Silence the system ding
            e.SuppressKeyPress = True
            ' 2. Trigger validation on the form/control
            Dim tb As TextBox = TryCast(sender, TextBox)
            tb?.FindForm()?.ValidateChildren()
        End If
    End Sub
    Private Sub TextboxNumbersOnlyKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textboxWLStartUpDelay.KeyDown, textboxWLMaxLinksPerFolder.KeyDown, textboxWLAutoRefreshInterval.KeyDown, textboxWLAutoRefreshIdleInterval.KeyDown
        nonNumberEntered = False
        If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
            If e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Enter Then : nonNumberEntered = True
            ElseIf e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Validate()
            End If
        End If
    End Sub
    Private Sub TextboxNumbersOnlyKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles textboxACAlarmTime.KeyPress, textboxACAlarmTimer.KeyPress, textboxWLStartUpDelay.KeyPress, textboxWLMaxLinksPerFolder.KeyPress, textboxWLAutoRefreshInterval.KeyPress, textboxWLAutoRefreshIdleInterval.KeyPress
        If nonNumberEntered Then e.Handled = True
    End Sub

    ' App
    Private Sub ChkBoxThemeAuto_Click(sender As Object, e As EventArgs) Handles ChkBoxThemeAuto.Click
        App.ThemeAuto = ChkBoxThemeAuto.Checked
        SetThemesList()
        Dim selectedTheme As Skye.UI.SkyeTheme = If(App.ThemeAuto, Skye.UI.ThemeManager.DetectWindowsTheme(), App.Theme)
        Skye.UI.ThemeManager.SetTheme(selectedTheme)
        App.SetSave()
    End Sub
    Private Sub CoBxTheme_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CoBoxTheme.SelectionChangeCommitted
        Dim selectedName As String = CoBoxTheme.SelectedItem.ToString()
        If selectedName = App.Theme.Name Then Return
        Dim selected As Skye.UI.SkyeTheme = Skye.UI.SkyeThemes.GetTheme(selectedName)
        App.Theme = selected
        If Not App.ThemeAuto Then
            Skye.UI.ThemeManager.SetTheme(selected)
            ShowSettings()
        End If
        App.SetSave()
    End Sub
    Private Sub BtnLoadOnOSStartupPath_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLoadOnOSStartupPath.Click
        If Not String.IsNullOrEmpty(WSTLoadOnOSStartupPath.Path) Then OFDLoadOnOSStartup.InitialDirectory = WSTLoadOnOSStartupPath.Path
        Dim r = OFDLoadOnOSStartup.ShowDialog(Me)
        If r = System.Windows.Forms.DialogResult.OK And Not OFDLoadOnOSStartup.FileName = "" Then
            WSTLoadOnOSStartupPath.Path = OFDLoadOnOSStartup.FileName
            App.SetSave()
        ElseIf Not r = System.Windows.Forms.DialogResult.Cancel Then
            WSTLoadOnOSStartupPath = Nothing
        End If
        If Not r = System.Windows.Forms.DialogResult.Cancel Then ShowSettingsApp()
    End Sub
    Private Sub CheckboxLoadOnOSStartup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChkBoxLoadOnOSStartup.Click
        WSTLoadOnOSStartup = Not WSTLoadOnOSStartup
        ShowSettingsApp()
        App.SetSave()
    End Sub
    Private Sub TxbxLoadOnOSStartupArgs_Validated(sender As Object, e As EventArgs) Handles TxtBoxLoadOnOSStartupArgs.Validated
        If String.IsNullOrEmpty(Me.TxtBoxLoadOnOSStartupArgs.Text) Then
            App.WSTLoadOnOSStartupPath.Arguments = String.Empty
        Else
            App.WSTLoadOnOSStartupPath.Arguments = Me.TxtBoxLoadOnOSStartupArgs.Text
        End If
        ShowSettingsApp()
        App.SetSave()
        Me.TxtBoxLoadOnOSStartupArgs.SelectAll()
    End Sub
    Private Sub LoadOnOSStartupCopy_DoubleClick(sender As Object, e As EventArgs) Handles LblLoadOnOSStartupPath.DoubleClick, TxtBoxLoadOnOSStartupArgs.DoubleClick
        If sender Is LblLoadOnOSStartupPath Then
            If Not String.IsNullOrEmpty(WSTLoadOnOSStartupPath.Path) Then My.Computer.Clipboard.SetText(WSTLoadOnOSStartupPath.Path)
        ElseIf sender Is TxtBoxLoadOnOSStartupArgs Then
            If Not String.IsNullOrEmpty(WSTLoadOnOSStartupPath.Arguments) Then My.Computer.Clipboard.SetText(WSTLoadOnOSStartupPath.Arguments)
        End If
    End Sub

    ' Workspace Tools
    Private Sub CheckboxWSTEnabled_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChkBoxWSTEnabled.Click
        My.App.WSTEnabled = Not My.App.WSTEnabled
        App.FrmMain.ShowTools()
        App.SetSave()
    End Sub
    Private Sub CheckboxWSTShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChkBoxWSTSSToolEnabled.Click, ChkBoxWSTShowWLTray.Click, ChkBoxWSTShowWLMenu.Click, ChkBoxWSTShowSleep.Click, ChkBoxWSTShowShutDown.Click, ChkBoxWSTShowReStart.Click, ChkBoxWSTShowLogOff.Click, ChkBoxWSTShowLog.Click, ChkBoxWSTShowLockWorkSpace.Click, ChkBoxWSTShowHibernate.Click, ChkBoxWSTShowHelp.Click, ChkBoxWSTShowClock.Click, ChkBoxWSTShowAC.Click
        Select Case CType(sender, CheckBox).Name
            Case ChkBoxWSTSSToolEnabled.Name
                App.WSTSSToolEnabled = Not App.WSTSSToolEnabled
                SetSS()
                ShowSettingsSS()
            Case ChkBoxWSTShowAC.Name
                WSTShowAC = Not WSTShowAC
                SetAC()
            Case ChkBoxWSTShowClock.Name
                App.WSTShowClock = Not App.WSTShowClock
                App.HideClock()
            Case ChkBoxWSTShowWLMenu.Name
                WSTShowWLMenu = Not WSTShowWLMenu
                SetWL()
                If WSTShowWLMenu Then
                    For index = 0 To WLData.Count - 1
                        If WLData(index).ShowInMenu Then
                            Dim link = WLData(index)
                            link.RefreshMenu = True
                            WLData(index) = link
                        End If
                    Next
                    App.FrmMain.ShowWL()
                Else
                    App.FrmMain.WLClose()
                End If
            Case ChkBoxWSTShowWLTray.Name
                WSTShowWLTray = Not WSTShowWLTray
                For index = 0 To WLData.Count - 1
                    If WLData(index).ShowInTray Then
                        Dim link = WLData(index)
                        link.RefreshMenu = True
                        WLData(index) = link
                    End If
                Next
            Case ChkBoxWSTShowLockWorkSpace.Name : WSTShowLockWorkSpace = Not WSTShowLockWorkSpace
            Case ChkBoxWSTShowLogOff.Name : WSTShowLogOff = Not WSTShowLogOff
            Case ChkBoxWSTShowSleep.Name : WSTShowSleep = Not WSTShowSleep
            Case ChkBoxWSTShowHibernate.Name : WSTShowHibernate = Not WSTShowHibernate
            Case ChkBoxWSTShowReStart.Name : WSTShowReStart = Not WSTShowReStart
            Case ChkBoxWSTShowShutDown.Name : WSTShowShutDown = Not WSTShowShutDown
            Case ChkBoxWSTShowHelp.Name : WSTShowHelp = Not WSTShowHelp
            Case ChkBoxWSTShowLog.Name : WSTShowLog = Not WSTShowLog
        End Select
        App.FrmMain.ShowTools()
        App.FrmMain.ShowWST()
        App.SetSave()
    End Sub

    ' Screen Saver
    Private Sub BtnSSEnabled_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnSSEnabled.MouseUp
        Select Case e.Button
            Case MouseButtons.Left
                FrmMain.WSTSSEnabled = Not FrmMain.WSTSSEnabled
            Case MouseButtons.Right
                SSActivate()
        End Select
    End Sub
    Private Sub ChkBoxSSShowIcon_Click(sender As Object, e As EventArgs) Handles ChkBoxSSShowIcon.Click
        App.WSTShowSSIcon = Not App.WSTShowSSIcon
        App.FrmMain.ShowTools()
        App.SetSave()
    End Sub
    Private Sub ChkBoxSSShowActivate_Click(sender As Object, e As EventArgs) Handles ChkBoxSSShowActivate.Click
        App.WSTShowSSActivate = Not App.WSTShowSSActivate
        App.FrmMain.ShowWST()
        App.SetSave()
    End Sub
    Private Sub ChkBoxSSShowEnabled_Click(sender As Object, e As EventArgs) Handles ChkBoxSSShowEnabled.Click
        App.WSTShowSSEnabled = Not App.WSTShowSSEnabled
        App.FrmMain.ShowWST()
        App.SetSave()
    End Sub
    Private Sub ChkBoxSSEnableOnActivate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChkBoxSSEnableOnActivate.Click
        WSTSSEnableOnActivate = Not WSTSSEnableOnActivate
        App.SetSave()
    End Sub
    Private Sub CoBoxSSStartUp_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CoBoxSSStartUp.SelectionChangeCommitted
        If WSTSSStartUp = CType(CoBoxSSStartUp.SelectedIndex, WSTSSStartUpMode) Then Return
        WSTSSStartUp = CType(CoBoxSSStartUp.SelectedIndex, WSTSSStartUpMode)
        App.SetSave()
    End Sub

    ' Alarm & Chime
    Private Sub BtnACAlarmSetClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACAlarmSet.Click
        App.FrmMain.ACAlarmActive = Not App.FrmMain.ACAlarmActive
        App.FrmMain.ACSetTimer()
        App.FrmMain.UpdateWST()
        ShowSettingsAC()
    End Sub
    Private Sub BtnACAlarmCancelClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACAlarmCancel.Click
        App.FrmMain.ACAlarmCancel()
    End Sub
    Private Sub BtnACChimeDefaultClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACTopHourChimeDefault.Click, btnACOffHourChimeDefault.Click, btnACAlarmChimeDefault.Click
        If sender Is Me.btnACAlarmChimeDefault Then : My.App.ACAlarmChimePath = ""
        ElseIf sender Is Me.btnACTopHourChimeDefault Then : My.App.ACTopHourChimePath = ""
        ElseIf sender Is Me.btnACOffHourChimeDefault Then : My.App.ACOffHourChimePath = ""
        End If
        ShowSettingsAC()
        App.SetSave()
    End Sub
    Private Sub BtnACChimeManualClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACTopHourChimeManual.Click, btnACOffHourChimeManual.Click, btnACAlarmChimeManual.Click
        Dim r As DialogResult = Me.OFDACSelectWAV.ShowDialog(Me)
        If r = System.Windows.Forms.DialogResult.OK And Not Me.OFDACSelectWAV.FileName = "" Then
            If sender Is Me.btnACAlarmChimeManual Then : My.App.ACAlarmChimePath = Me.OFDACSelectWAV.FileName
            ElseIf sender Is Me.btnACTopHourChimeManual Then : My.App.ACTopHourChimePath = Me.OFDACSelectWAV.FileName
            ElseIf sender Is Me.btnACOffHourChimeManual Then : My.App.ACOffHourChimePath = Me.OFDACSelectWAV.FileName
            End If
        ElseIf Not r = System.Windows.Forms.DialogResult.Cancel Then
            If sender Is Me.btnACAlarmChimeManual Then : My.App.ACAlarmChimePath = ""
            ElseIf sender Is Me.btnACTopHourChimeManual Then : My.App.ACTopHourChimePath = ""
            ElseIf sender Is Me.btnACOffHourChimeManual Then : My.App.ACOffHourChimePath = ""
            End If
        End If
        ShowSettingsAC()
        App.SetSave()
    End Sub
    Private Sub BtnACChimePlayClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACTopHourChimePlay.Click, btnACOffHourChimePlay.Click, btnACAlarmChimePlay.Click
        Dim counter As Byte = 0
        Dim chime As String = ""
        Dim chimecount As Byte = 0
        If sender Is Me.btnACAlarmChimePlay Then
            Me.LblACAlarmChime.ForeColor = Color.Maroon
            Me.LblACAlarmChime.Font = New Font(Me.Font, Drawing.FontStyle.Bold)
            Me.LblACAlarmChime.Refresh()
            chime = My.App.ACAlarmChimePath
            Select Case My.App.ACAlarmChimeType
                Case My.App.ACChimeType.Simple : chimecount = 1
                Case Else : chimecount = 4
            End Select
        ElseIf sender Is Me.btnACTopHourChimePlay Then
            Me.LblACTopHourChime.ForeColor = Color.Maroon
            Me.LblACTopHourChime.Font = New Font(Me.Font, Drawing.FontStyle.Bold)
            Me.LblACTopHourChime.Refresh()
            chime = My.App.ACTopHourChimePath
            Select Case My.App.ACTopHourChimeType
                Case My.App.ACChimeType.Simple : chimecount = 1
                Case My.App.ACChimeType.Extended : chimecount = 4
                Case My.App.ACChimeType.HourTick
                    If My.Computer.Clock.LocalTime.Hour = 0 Then : chimecount = 12
                    ElseIf My.Computer.Clock.LocalTime.Hour >= 13 And My.Computer.Clock.LocalTime.Hour <= 23 Then : chimecount = CByte(My.Computer.Clock.LocalTime.Hour - 12)
                    Else : chimecount = CByte(My.Computer.Clock.LocalTime.Hour)
                    End If
            End Select
        ElseIf sender Is Me.btnACOffHourChimePlay Then
            Me.LblACOffHourChime.ForeColor = Color.Maroon
            Me.LblACOffHourChime.Font = New Font(Me.Font, Drawing.FontStyle.Bold)
            Me.LblACOffHourChime.Refresh()
            chime = My.App.ACOffHourChimePath
            chimecount = 1
        End If
        If chimecount > 0 And Not App.FrmMain.ACMute Then
            Do
                If chime = "" Then
                    Try : My.Computer.Audio.Play(My.App.ACChime, AudioPlayMode.WaitToComplete) : Catch : End Try
                Else
                    Try : My.Computer.Audio.Play(chime, AudioPlayMode.WaitToComplete)
                    Catch : Try : My.Computer.Audio.Play(My.App.ACChime, AudioPlayMode.WaitToComplete) : Catch : End Try
                    End Try
                End If
                counter += CByte(1)
            Loop While counter < chimecount
        Else
            If sender Is Me.btnACAlarmChimePlay And My.App.ACAlarmChimeType = My.App.ACChimeType.Forever Then chimecount = Byte.MaxValue
            App.ShowMessage(My.App.Tools.AlarmChime, "** CHIME IS SOUNDING **", Nothing)
        End If
        Me.LblACAlarmChime.ResetForeColor()
        Me.LblACAlarmChime.ResetFont()
        Me.LblACAlarmChime.Refresh()
        Me.LblACTopHourChime.ResetForeColor()
        Me.LblACTopHourChime.ResetFont()
        Me.LblACTopHourChime.Refresh()
        Me.LblACOffHourChime.ResetForeColor()
        Me.LblACOffHourChime.ResetFont()
        Me.LblACOffHourChime.Refresh()
        Me.BtnClose.Select()
    End Sub
    Private Sub BtnACMuteClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACMute.Click
        App.FrmMain.ACMute = Not App.FrmMain.ACMute
        App.FrmMain.CancelBackgroundworkerAC()
        ACUpdateMute()
    End Sub
    Private Sub CheckboxACAlarmRecurringClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxACAlarmRecurring.Click
        App.ACAlarmRecurring = Not App.ACAlarmRecurring
        If App.ACAlarmRecurring And Not App.FrmMain.ACAlarmActive Then
            App.FrmMain.ACAlarmActive = True
            App.FrmMain.ACSetTimer()
            ShowSettingsAC()
        End If
        SetSave()
    End Sub
    Private Sub CheckboxACChimeEnabledClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxACTopHourChimeEnabled.Click, checkboxACTopHourBeforeChimeEnabled.Click, checkboxACTopHourAfterChimeEnabled.Click, checkboxACThirdQuarterHourChimeEnabled.Click, checkboxACThirdQuarterHourBeforeChimeEnabled.Click, checkboxACThirdQuarterHourAfterChimeEnabled.Click, checkboxACFirstQuarterHourChimeEnabled.Click, checkboxACFirstQuarterHourBeforeChimeEnabled.Click, checkboxACFirstQuarterHourAfterChimeEnabled.Click, checkboxACBottomHourChimeEnabled.Click, checkboxACBottomHourBeforeChimeEnabled.Click, checkboxACBottomHourAfterChimeEnabled.Click
        Select Case CType(sender, System.Windows.Forms.CheckBox).Name
            Case Me.checkboxACTopHourChimeEnabled.Name : My.App.ACTopHourChimeEnabled = Not My.App.ACTopHourChimeEnabled
            Case Me.checkboxACTopHourBeforeChimeEnabled.Name : My.App.ACTopHourBeforeChimeEnabled = Not My.App.ACTopHourBeforeChimeEnabled
            Case Me.checkboxACTopHourAfterChimeEnabled.Name : My.App.ACTopHourAfterChimeEnabled = Not My.App.ACTopHourAfterChimeEnabled
            Case Me.checkboxACFirstQuarterHourChimeEnabled.Name : My.App.ACFirstQuarterHourChimeEnabled = Not My.App.ACFirstQuarterHourChimeEnabled
            Case Me.checkboxACFirstQuarterHourBeforeChimeEnabled.Name : My.App.ACFirstQuarterHourBeforeChimeEnabled = Not My.App.ACFirstQuarterHourBeforeChimeEnabled
            Case Me.checkboxACFirstQuarterHourAfterChimeEnabled.Name : My.App.ACFirstQuarterHourAfterChimeEnabled = Not My.App.ACFirstQuarterHourAfterChimeEnabled
            Case Me.checkboxACBottomHourChimeEnabled.Name : My.App.ACBottomHourChimeEnabled = Not My.App.ACBottomHourChimeEnabled
            Case Me.checkboxACBottomHourBeforeChimeEnabled.Name : My.App.ACBottomHourBeforeChimeEnabled = Not My.App.ACBottomHourBeforeChimeEnabled
            Case Me.checkboxACBottomHourAfterChimeEnabled.Name : My.App.ACBottomHourAfterChimeEnabled = Not My.App.ACBottomHourAfterChimeEnabled
            Case Me.checkboxACThirdQuarterHourChimeEnabled.Name : My.App.ACThirdQuarterHourChimeEnabled = Not My.App.ACThirdQuarterHourChimeEnabled
            Case Me.checkboxACThirdQuarterHourBeforeChimeEnabled.Name : My.App.ACThirdQuarterHourBeforeChimeEnabled = Not My.App.ACThirdQuarterHourBeforeChimeEnabled
            Case Me.checkboxACThirdQuarterHourAfterChimeEnabled.Name : My.App.ACThirdQuarterHourAfterChimeEnabled = Not My.App.ACThirdQuarterHourAfterChimeEnabled
        End Select
        App.SetSave()
    End Sub
    Private Sub RadiobtnACChimeTypeClick(ByVal sender As Object, ByVal e As EventArgs) Handles radiobtnACTopHourChimeSimple.Click, radiobtnACTopHourChimeHourTick.Click, radiobtnACTopHourChimeExtended.Click, radiobtnACAlarmChimeSimple.Click, radiobtnACAlarmChimeForever.Click, radiobtnACAlarmChimeExtended.Click
        If sender Is Me.radiobtnACAlarmChimeSimple Then : My.App.ACAlarmChimeType = My.App.ACChimeType.Simple
        ElseIf sender Is Me.radiobtnACAlarmChimeExtended Then : My.App.ACAlarmChimeType = My.App.ACChimeType.Extended
        ElseIf sender Is Me.radiobtnACAlarmChimeForever Then : My.App.ACAlarmChimeType = My.App.ACChimeType.Forever
        ElseIf sender Is Me.radiobtnACTopHourChimeSimple Then : My.App.ACTopHourChimeType = My.App.ACChimeType.Simple
        ElseIf sender Is Me.radiobtnACTopHourChimeExtended Then : My.App.ACTopHourChimeType = My.App.ACChimeType.Extended
        ElseIf sender Is Me.radiobtnACTopHourChimeHourTick Then : My.App.ACTopHourChimeType = My.App.ACChimeType.HourTick
        End If
        App.SetSave()
    End Sub
    Private Sub TextboxACAlarmTimeKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textboxACAlarmTime.KeyDown
        nonNumberEntered = False
        If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
            If e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Enter And Not (e.Shift And e.KeyCode = Keys.OemSemicolon And sender Is Me.textboxACAlarmTime) Then : nonNumberEntered = True
            ElseIf e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Dim h, m As Integer
                Try
                    Dim split As String() = Me.textboxACAlarmTime.Text.Split(CChar(":"))
                    If split.Length = 1 Then
                        Dim s As String = split(0)
                        If s.Length = 3 Then
                            h = CInt(Val(s.Substring(0, 1)))
                            m = CInt(Val(s.Substring(1, 2)))
                        ElseIf s.Length = 4 Then
                            h = CInt(Val(s.Substring(0, 2)))
                            m = CInt(Val(s.Substring(2, 2)))
                        Else : Throw New Exception
                        End If
                    ElseIf split.Length = 2 Then
                        h = CInt(Val(split(0)))
                        m = CInt(Val(split(1)))
                    Else : Throw New Exception
                    End If
                    If h < 0 Or h > 23 Or m < 0 Or m > 59 Then Throw New Exception
                    My.App.ACAlarmTime = New TimeSpan(h, m, 0)
                    App.FrmMain.ACAlarmActive = True
                    App.FrmMain.ACSetTimer()
                    ShowSettingsAC()
                    Me.textboxACAlarmTime.ResetBackColor()
                    Me.textboxACAlarmTime.ResetForeColor()
                    Me.textboxACAlarmTime.SelectAll()
                Catch
                    Me.textboxACAlarmTime.BackColor = Color.Red
                    Me.textboxACAlarmTime.ForeColor = Color.Yellow
                    Me.textboxACAlarmTime.SelectAll()
                End Try
                App.SetSave()
            End If
        End If
    End Sub
    Private Sub TextboxACTimerKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textboxACAlarmTimer.KeyDown
        nonNumberEntered = False
        If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
            If e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Enter Then : nonNumberEntered = True
            ElseIf e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                If Int(Val(Me.textboxACAlarmTimer.Text)) < 1 Then Me.textboxACAlarmTimer.Text = "1"
                If Int(Val(Me.textboxACAlarmTimer.Text)) > 720 Then Me.textboxACAlarmTimer.Text = "720"
                My.App.ACAlarmTime = New TimeSpan(My.Computer.Clock.LocalTime.AddMinutes(Int(Val(Me.textboxACAlarmTimer.Text))).Hour, My.Computer.Clock.LocalTime.AddMinutes(Int(Val(Me.textboxACAlarmTimer.Text))).Minute, 0)
                App.FrmMain.ACAlarmActive = True
                App.FrmMain.ACSetTimer()
                App.FrmMain.UpdateWST()
                ShowSettingsAC()
                Me.textboxACAlarmTime.Focus()
                Me.textboxACAlarmTime.SelectAll()
                App.SetSave()
            End If
        End If
    End Sub

    ' WinLinks
    Private Sub CMlistviewWLOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmlistviewWL.Opening
        If Me.listviewWL.SelectedIndices.Count > 0 Then
            If Me.listviewWL.SelectedIndices(0) = 0 Then : Me.cmiWLMoveUp.Enabled = False
            Else : Me.cmiWLMoveUp.Enabled = True
            End If
            If Me.listviewWL.SelectedIndices(0) = My.App.WLData.Count - 1 Then : Me.cmiWLMoveDown.Enabled = False
            Else : Me.cmiWLMoveDown.Enabled = True
            End If
            Me.cmiWLNew.Text = "New (Insert Above)"
            Me.cmiWLDelete.Enabled = True
        Else
            Me.cmiWLMoveUp.Enabled = False
            Me.cmiWLMoveDown.Enabled = False
            Me.cmiWLNew.Text = "New (Insert Last)"
            Me.cmiWLDelete.Enabled = False
        End If
    End Sub
    Private Sub CMIWLMoveMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWLMoveUp.MouseUp, cmiWLMoveDown.MouseUp
        If e.Button = MouseButtons.Left And Me.listviewWL.SelectedIndices.Count > 0 Then
            Dim link As My.App.WLItemType = My.App.WLData(Me.listviewWL.SelectedIndices(0))
            My.App.WLData.RemoveAt(Me.listviewWL.SelectedIndices(0))
            Select Case CType(sender, ToolStripItem).Name
                Case Me.cmiWLMoveUp.Name : My.App.WLData.Insert(Me.listviewWL.SelectedIndices(0) - 1, link)
                Case Me.cmiWLMoveDown.Name : My.App.WLData.Insert(Me.listviewWL.SelectedIndices(0) + 1, link)
            End Select
            App.FrmMain.WLSetManualRefresh()
            ShowSettingsWL()
            App.SetSave()
        End If
    End Sub
    Private Sub CMIWLNewMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWLNew.MouseUp
        If e.Button = MouseButtons.Left Then WLSetNew()
    End Sub
    Private Sub CMIWLDeleteMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWLDelete.MouseUp
        If e.Button = MouseButtons.Left And Me.listviewWL.SelectedIndices.Count > 0 Then
            App.FrmMain.WLSetAutoRefresh(True)
            My.App.WLData.RemoveAt(Me.listviewWL.SelectedIndices(0))
            App.FrmMain.WLSetManualRefresh()
            ShowSettingsWL()
            App.SetSave()
        End If
    End Sub
    Private Sub ListviewWLSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listviewWL.SelectedIndexChanged
        If Me.listviewWL.SelectedIndices.Count > 0 Then
            Dim link As My.App.WLItemType = My.App.WLData(Me.listviewWL.SelectedIndices(0))
            Me.lblWLRoot.Font = New Font(Me.Font, FontStyle.Regular)
            If Me.listviewWL.SelectedIndices(0) = My.App.WLData.Count - 1 And My.App.WLAutoRefresh Then : Me.lblWLRoot.Text = "Root Folder (AutoRefresh Enabled)"
            Else : Me.lblWLRoot.Text = "Root Folder"
            End If
            Me.textboxWLRoot.Text = link.Root
            Me.textboxWLName.Text = link.Name
            Me.comboboxWLSort.SelectedIndex = link.Sort - 1
            Me.comboboxWLFolderMode.SelectedIndex = link.FolderMode
            Me.comboboxWLFolderPlacement.SelectedIndex = link.FolderPlacement
            If link.UseDefaultIcon Then : Me.checkboxWLUseDefaultIcon.Checked = True
            Else : Me.checkboxWLUseDefaultIcon.Checked = False
            End If
            If link.ShowInMenu Then : Me.checkboxWLShowInMenu.Checked = True
            Else : Me.checkboxWLShowInMenu.Checked = False
            End If
            If link.ShowInTray Then : Me.checkboxWLShowInTray.Checked = True
            Else : Me.checkboxWLShowInTray.Checked = False
            End If
            If link.ShowNoMenu Then : Me.checkboxWLShowNoMenu.Checked = True
            Else : Me.checkboxWLShowNoMenu.Checked = False
            End If
            If link.ShowMenuIcons Then : Me.checkboxWLShowMenuIcons.Checked = True
            Else : Me.checkboxWLShowMenuIcons.Checked = False
            End If
            Me.PanelWLItem.Show()
        ElseIf Me.listviewWL.FocusedItem IsNot Nothing Then : ShowSettingsWL()
        End If
    End Sub
    Private Sub BtnWLRefreshClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnWLRefresh.Click
        If Me.btnWLRefresh.Text = "CANCEL" Then
            Me.btnWLRefresh.Enabled = False
            Me.btnWLRefresh.Text = "PENDING..."
            Me.TipInfoEX.SetText(Me.btnWLRefresh, "Stopping File Search, Please Wait...")
            App.FrmMain.CancelBackgroundworkerWL()
        Else
            App.FrmMain.WLClose(True)
            App.FrmMain.ShowWL()
        End If
    End Sub
    Private Sub BtnWLSelectFolderClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnWLSelectFolder.Click
        If Not String.IsNullOrEmpty(Me.textboxWLRoot.Text) Then Me.FBDWLFolderBrowser.SelectedPath = Me.textboxWLRoot.Text
        Dim r As DialogResult = Me.FBDWLFolderBrowser.ShowDialog(Me)
        If r = System.Windows.Forms.DialogResult.OK And Not Me.FBDWLFolderBrowser.SelectedPath = "" Then
            Me.textboxWLRoot.Text = Me.FBDWLFolderBrowser.SelectedPath
        ElseIf Not r = System.Windows.Forms.DialogResult.Cancel Then
            Me.textboxWLRoot.Text = ""
        End If
        App.SetSave()
        Me.textboxWLRoot.Select(Me.textboxWLRoot.Text.Length, 0)
        Me.textboxWLRoot.Focus()
    End Sub
    Private Sub BtnWLSelectFolderEnter(ByVal sender As Object, ByVal e As EventArgs) Handles btnWLSelectFolder.Enter
        Me.textboxWLRoot.Focus()
    End Sub
    Private Sub BtnWLSetClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnWLSet.Click
        If String.IsNullOrEmpty(Me.textboxWLRoot.Text) Or Me.textboxWLRoot.Text.Length < 4 Then
            Me.lblWLRoot.Font = New Font(Me.Font, FontStyle.Bold)
            Me.textboxWLRoot.Select()
        Else
            Dim link As New My.App.WLItemType With {
                .Root = Me.textboxWLRoot.Text,
                .Name = Me.textboxWLName.Text}
            'Edit
            If Me.listviewWL.SelectedIndices.Count > 0 Then
                If Me.comboboxWLSort.SelectedIndex = -1 Then Me.comboboxWLSort.SelectedIndex = 0
                link.Sort = CType(Me.comboboxWLSort.SelectedIndex + 1, SortOrder)
                If Me.comboboxWLFolderMode.SelectedIndex = -1 Then Me.comboboxWLFolderMode.SelectedIndex = 0
                link.FolderMode = CType(Me.comboboxWLFolderMode.SelectedIndex, My.App.WLFolderMode)
                If Me.comboboxWLFolderPlacement.SelectedIndex = -1 Then Me.comboboxWLFolderPlacement.SelectedIndex = 0
                link.FolderPlacement = CType(Me.comboboxWLFolderPlacement.SelectedIndex, My.App.WLFolderPlacement)
                link.UseDefaultIcon = Me.checkboxWLUseDefaultIcon.Checked
                link.ShowInMenu = Me.checkboxWLShowInMenu.Checked
                link.ShowInTray = Me.checkboxWLShowInTray.Checked
                link.ShowNoMenu = Me.checkboxWLShowNoMenu.Checked
                link.ShowMenuIcons = Me.checkboxWLShowMenuIcons.Checked
                link.RefreshData = True
                link.RefreshMenu = True
                If Not (link.ShowInMenu = My.App.WLData(Me.listviewWL.SelectedIndices(0)).ShowInMenu And link.ShowInTray = My.App.WLData(Me.listviewWL.SelectedIndices(0)).ShowInTray And link.Root = My.App.WLData(Me.listviewWL.SelectedIndices(0)).Root And link.Name = My.App.WLData(Me.listviewWL.SelectedIndices(0)).Name) Then App.FrmMain.WLClose(True)
                My.App.WLData.RemoveAt(Me.listviewWL.SelectedIndices(0))
                My.App.WLData.Insert(Me.listviewWL.SelectedIndices(0), link)
                If App.FrmMain.WLMenuDataCount = 0 Then
                    App.FrmMain.WLSetManualRefresh()
                Else
                    App.FrmMain.ShowWL()
                End If

                'New
            Else
                If Me.comboboxWLSort.SelectedIndex = -1 Then Me.comboboxWLSort.SelectedIndex = 0
                link.Sort = CType(Me.comboboxWLSort.SelectedIndex + 1, SortOrder)
                If Me.comboboxWLFolderMode.SelectedIndex = -1 Then Me.comboboxWLFolderMode.SelectedIndex = 0
                link.FolderMode = CType(Me.comboboxWLFolderMode.SelectedIndex, My.App.WLFolderMode)
                If Me.comboboxWLFolderPlacement.SelectedIndex = -1 Then Me.comboboxWLFolderPlacement.SelectedIndex = 0
                link.FolderPlacement = CType(Me.comboboxWLFolderPlacement.SelectedIndex, My.App.WLFolderPlacement)
                If App.FrmMain.WLInsertIndex = -1 Then App.FrmMain.WLInsertIndex = My.App.WLData.Count
                link.UseDefaultIcon = Me.checkboxWLUseDefaultIcon.Checked
                link.ShowInMenu = Me.checkboxWLShowInMenu.Checked
                link.ShowInTray = Me.checkboxWLShowInTray.Checked
                link.ShowNoMenu = Me.checkboxWLShowNoMenu.Checked
                link.ShowMenuIcons = Me.checkboxWLShowMenuIcons.Checked
                My.App.WLData.Insert(App.FrmMain.WLInsertIndex, link)
                App.FrmMain.WLSetManualRefresh()
            End If
            App.SetSave()
        End If
    End Sub
    Private Sub BtnWLCancelClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnWLCancel.Click
        ShowSettingsWL()
    End Sub
    Private Sub CheckboxWLShowFileInfoToolTipsClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWLShowFileInfoToolTips.Click
        My.App.WLShowFileInfoToolTips = Not My.App.WLShowFileInfoToolTips
        App.SetSave()
    End Sub
    Private Sub CheckboxWLShowFilePathToolTipsClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWLShowFilePathToolTips.Click
        My.App.WLShowFilePathToolTips = Not My.App.WLShowFilePathToolTips
        App.SetSave()
    End Sub
    Private Sub CheckboxWLShowFolderPathToolTipsClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWLShowFolderPathToolTips.Click
        My.App.WLShowFolderPathToolTips = Not My.App.WLShowFolderPathToolTips
        App.SetSave()
    End Sub
    Private Sub CheckboxWLAutoRefreshClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWLAutoRefresh.Click
        My.App.WLAutoRefresh = Not My.App.WLAutoRefresh
        App.FrmMain.WLSetAutoRefresh()
        ShowSettingsWL()
        App.SetSave()
    End Sub
    Private Sub TextboxWLStartUpDelayValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textboxWLStartUpDelay.Validating
        If Int(Val(Me.textboxWLStartUpDelay.Text)) < 5 And Int(Val(Me.textboxWLStartUpDelay.Text)) <> 0 Then Me.textboxWLStartUpDelay.Text = "5"
        If Int(Val(Me.textboxWLStartUpDelay.Text)) > 300 Then Me.textboxWLStartUpDelay.Text = "300"
    End Sub
    Private Sub TextboxWLStartUpDelayValidated(ByVal sender As Object, ByVal e As EventArgs) Handles textboxWLStartUpDelay.Validated
        My.App.WLStartUpDelay = CShort(Val(Me.textboxWLStartUpDelay.Text))
        Me.textboxWLStartUpDelay.SelectAll()
        App.SetSave()
    End Sub
    Private Sub TextboxWLMaxLinksPerFolderValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textboxWLMaxLinksPerFolder.Validating
        If Int(Val(Me.textboxWLMaxLinksPerFolder.Text)) < 1 Then Me.textboxWLMaxLinksPerFolder.Text = "1"
        If Int(Val(Me.textboxWLMaxLinksPerFolder.Text)) > 100 Then Me.textboxWLMaxLinksPerFolder.Text = "100"
    End Sub
    Private Sub TextboxWLMaxLinksPerFolderValidated(ByVal sender As Object, ByVal e As EventArgs) Handles textboxWLMaxLinksPerFolder.Validated
        My.App.WLMaxLinksPerFolder = CByte(Val(Me.textboxWLMaxLinksPerFolder.Text))
        Me.textboxWLMaxLinksPerFolder.SelectAll()
        App.SetSave()
    End Sub
    Private Sub TextboxWLAutoRefreshIntervalValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textboxWLAutoRefreshInterval.Validating
        If Int(Val(Me.textboxWLAutoRefreshInterval.Text)) < 1 Then Me.textboxWLAutoRefreshInterval.Text = "1"
        If Int(Val(Me.textboxWLAutoRefreshInterval.Text)) > 90 Then Me.textboxWLAutoRefreshInterval.Text = "90"
    End Sub
    Private Sub TextboxWLAutoRefreshIntervalValidated(ByVal sender As Object, ByVal e As EventArgs) Handles textboxWLAutoRefreshInterval.Validated
        If Not My.App.WLAutoRefreshInterval = Int(Val(Me.textboxWLAutoRefreshInterval.Text)) Then
            My.App.WLAutoRefreshInterval = CByte(Val(Me.textboxWLAutoRefreshInterval.Text))
            Me.textboxWLAutoRefreshInterval.SelectAll()
            App.FrmMain.WLSetAutoRefresh()
            App.SetSave()
        End If
    End Sub
    Private Sub TextboxWLAutoRefreshIdleIntervalValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textboxWLAutoRefreshIdleInterval.Validating
        If Int(Val(Me.textboxWLAutoRefreshIdleInterval.Text)) < 20 Then Me.textboxWLAutoRefreshIdleInterval.Text = "20"
        If Int(Val(Me.textboxWLAutoRefreshIdleInterval.Text)) > 240 Then Me.textboxWLAutoRefreshIdleInterval.Text = "240"
    End Sub
    Private Sub TextboxWLAutoRefreshIdleIntervalValidated(ByVal sender As Object, ByVal e As EventArgs) Handles textboxWLAutoRefreshIdleInterval.Validated
        If Not My.App.WLAutoRefreshIdleInterval = Int(Val(Me.textboxWLAutoRefreshIdleInterval.Text)) Then
            My.App.WLAutoRefreshIdleInterval = CByte(Val(Me.textboxWLAutoRefreshIdleInterval.Text))
            Me.textboxWLAutoRefreshIdleInterval.SelectAll()
            App.FrmMain.WLSetAutoRefresh()
            App.SetSave()
        End If
    End Sub

    ' HotClicks
    ' HotKeys

    ' METHODS
    Friend Sub SetPage(page As String)
        PanelApp.Visible = False
        PanelWST.Visible = False
        PanelSS.Visible = False
        PanelAC.Visible = False
        PanelWL.Visible = False
        PanelHC.Visible = False
        PanelHK.Visible = False
        Select Case page.ToUpper()
            Case "APP"
                PanelApp.Visible = True
                PanelApp.BringToFront()
            Case "WST"
                PanelWST.Visible = True
                PanelWST.BringToFront()
            Case "SS"
                PanelSS.Visible = True
                PanelSS.BringToFront()
            Case "AC"
                PanelAC.Visible = True
                PanelAC.BringToFront()
            Case "WL"
                PanelWL.Visible = True
                PanelWL.BringToFront()
            Case "HC"
                PanelHC.Visible = True
                PanelHC.BringToFront()
            Case "HK"
                PanelHK.Visible = True
                PanelHK.BringToFront()
        End Select
        SelectPage(page)
        App.LastSettingsPage = page
    End Sub
    Private Sub SelectPage(page As String)
        If LVPageSelector.Items.Count = 0 Then Exit Sub ' Guard against empty list

        suppressPageSelection = True
        LVPageSelector.BeginUpdate() ' Suspend UI layout redrawing briefly to avoid flicker
        For Each item As ListViewItem In LVPageSelector.Items
            Dim itemTag As String = TryCast(item.Tag, String)
            If String.Equals(itemTag, page, StringComparison.OrdinalIgnoreCase) Then
                item.Selected = True
                item.Focused = True
            Else
                item.Selected = False
            End If
        Next
        LVPageSelector.EndUpdate()
        suppressPageSelection = False

    End Sub
    Private Sub ShowSettings()

        ShowSettingsApp()
        ShowSettingsWST()
        ShowSettingsSS()
        ShowSettingsAC()
        ShowSettingsWL()
        ShowSettingsHC()
        ShowSettingsHK()

        SetThemesList()
        UpdateSettings()
    End Sub
    Friend Sub UpdateSettings() 'Settings that can change on other forms
        If My.App.WSTSSToolEnabled Then
            If App.FrmMain.WSTSSEnabled Then
                Me.BtnSSEnabled.Image = My.Resources.Resources.ImageWSTSS48
                Me.TipInfoEX.SetText(Me.BtnSSEnabled, "Screen Saver ENABLED")
            Else
                Me.BtnSSEnabled.Image = My.Resources.Resources.ImageWSTSSDisabled48
                Me.TipInfoEX.SetText(Me.BtnSSEnabled, "Screen Saver DISABLED")
            End If
            Me.TipInfoEX.SetText(Me.BtnSSEnabled, Me.TipInfoEX.GetText(Me.BtnSSEnabled) + vbCr + "RightClick = Activate")
        End If
        Me.ChkBoxSSShowIcon.Checked = App.WSTShowSSIcon
    End Sub
    Private Sub ShowSettingsApp()
        CoBoxTheme.SelectedItem = App.Theme.Name
        ChkBoxThemeAuto.Checked = App.ThemeAuto
        If My.App.WSTLoadOnOSStartup Then
            Me.ChkBoxLoadOnOSStartup.Checked = True
            Me.BtnLoadOnOSStartupPath.Enabled = True
            Me.LblLoadOnOSStartupPath.Enabled = True
            Me.TxtBoxLoadOnOSStartupArgs.Enabled = True
            Me.TipInfoEX.SetText(Me.LblLoadOnOSStartupPath, If(String.IsNullOrWhiteSpace(App.WSTLoadOnOSStartupPath.Path), "Path", App.WSTLoadOnOSStartupPath.Path + Chr(13) + "DoubleClick To Copy Full Path"))
            Me.TipInfoEX.SetText(Me.TxtBoxLoadOnOSStartupArgs, If(String.IsNullOrEmpty(App.WSTLoadOnOSStartupPath.Arguments), "Arguments", App.WSTLoadOnOSStartupPath.Arguments + Chr(13) + "DoubleClick To Copy Arguments").ToString)
        Else
            Me.ChkBoxLoadOnOSStartup.Checked = False
            Me.BtnLoadOnOSStartupPath.Enabled = False
            Me.LblLoadOnOSStartupPath.Enabled = False
            Me.TxtBoxLoadOnOSStartupArgs.Enabled = False
            Me.TipInfoEX.SetText(Me.LblLoadOnOSStartupPath, Nothing)
            Me.TipInfoEX.SetText(Me.TxtBoxLoadOnOSStartupArgs, Nothing)
        End If
        If String.IsNullOrEmpty(My.App.WSTLoadOnOSStartupPath.Path) Then : Me.LblLoadOnOSStartupPath.Text = String.Empty
        Else : Me.LblLoadOnOSStartupPath.Text = IIf(My.App.WSTLoadOnOSStartupPath.Path.Contains("\"c), "...\", Nothing).ToString + My.App.WSTLoadOnOSStartupPath.Path.Split(CChar("\")).GetValue(My.App.WSTLoadOnOSStartupPath.Path.Split(CChar("\")).Length - 1).ToString
        End If
        If String.IsNullOrEmpty(My.App.WSTLoadOnOSStartupPath.Arguments) Then : Me.TxtBoxLoadOnOSStartupArgs.Text = String.Empty
        Else : Me.TxtBoxLoadOnOSStartupArgs.Text = My.App.WSTLoadOnOSStartupPath.Arguments
        End If
    End Sub
    Private Sub ShowSettingsWST()
        If My.App.WSTEnabled Then : Me.ChkBoxWSTEnabled.Checked = True
        Else : Me.ChkBoxWSTEnabled.Checked = False
        End If
        If App.WSTSSToolEnabled Then : Me.ChkBoxWSTSSToolEnabled.Checked = True
        Else : Me.ChkBoxWSTSSToolEnabled.Checked = False
        End If
        If My.App.WSTShowAC Then : Me.ChkBoxWSTShowAC.Checked = True
        Else : Me.ChkBoxWSTShowAC.Checked = False
        End If
        If My.App.WSTShowClock Then : Me.ChkBoxWSTShowClock.Checked = True
        Else : Me.ChkBoxWSTShowClock.Checked = False
        End If
        If My.App.WSTShowWLMenu Then : Me.ChkBoxWSTShowWLMenu.Checked = True
        Else : Me.ChkBoxWSTShowWLMenu.Checked = False
        End If
        If My.App.WSTShowWLTray Then : Me.ChkBoxWSTShowWLTray.Checked = True
        Else : Me.ChkBoxWSTShowWLTray.Checked = False
        End If
        If My.App.WSTShowLockWorkSpace Then : Me.ChkBoxWSTShowLockWorkSpace.Checked = True
        Else : Me.ChkBoxWSTShowLockWorkSpace.Checked = False
        End If
        If My.App.WSTShowLogOff Then : Me.ChkBoxWSTShowLogOff.Checked = True
        Else : Me.ChkBoxWSTShowLogOff.Checked = False
        End If
        If My.App.WSTShowSleep Then : Me.ChkBoxWSTShowSleep.Checked = True
        Else : Me.ChkBoxWSTShowSleep.Checked = False
        End If
        If My.App.WSTShowHibernate Then : Me.ChkBoxWSTShowHibernate.Checked = True
        Else : Me.ChkBoxWSTShowHibernate.Checked = False
        End If
        If My.App.WSTShowReStart Then : Me.ChkBoxWSTShowReStart.Checked = True
        Else : Me.ChkBoxWSTShowReStart.Checked = False
        End If
        If My.App.WSTShowShutDown Then : Me.ChkBoxWSTShowShutDown.Checked = True
        Else : Me.ChkBoxWSTShowShutDown.Checked = False
        End If
        If My.App.WSTShowHelp Then : Me.ChkBoxWSTShowHelp.Checked = True
        Else : Me.ChkBoxWSTShowHelp.Checked = False
        End If
        If My.App.WSTShowLog Then : Me.ChkBoxWSTShowLog.Checked = True
        Else : Me.ChkBoxWSTShowLog.Checked = False
        End If
    End Sub
    Private Sub ShowSettingsSS()
        Me.ChkBoxSSShowActivate.Checked = App.WSTShowSSActivate
        Me.ChkBoxSSShowEnabled.Checked = App.WSTShowSSEnabled
        Me.ChkBoxSSEnableOnActivate.Checked = App.WSTSSEnableOnActivate
        Me.CoBoxSSStartUp.SelectedIndex = App.WSTSSStartUp
    End Sub
    Private Sub ShowSettingsAC()
        If App.FrmMain.ACAlarmActive Then
            Me.btnACAlarmSet.Text = "Alarm Active"
            Me.btnACAlarmSet.Font = New Font(Me.Font, FontStyle.Bold)
            Me.btnACAlarmSet.ForeColor = Color.Teal
            Dim alarmText As String = My.App.ACAlarmTime.ToString()
            Me.TipInfoEX.SetText(Me.btnACAlarmSet, String.Concat("Alarm Set for ", alarmText.AsSpan(0, alarmText.Length - 3)))
        Else
            Me.btnACAlarmSet.Text = "Alarm InActive"
            Me.btnACAlarmSet.Font = New Font(Me.Font, FontStyle.Regular)
            Me.btnACAlarmSet.ForeColor = Color.Maroon
            Dim alarmText As String = My.App.ACAlarmTime.ToString()
            Me.TipInfoEX.SetText(Me.btnACAlarmSet, String.Concat("Activate Alarm for ", alarmText.AsSpan(0, alarmText.Length - 3)))
        End If
        Me.textboxACAlarmTime.Text = My.App.ACAlarmTime.ToString().Substring(0, My.App.ACAlarmTime.ToString().Length - 3)
        If My.App.ACAlarmRecurring Then : Me.checkboxACAlarmRecurring.Checked = True
        Else : Me.checkboxACAlarmRecurring.Checked = False
        End If
        If My.App.ACAlarmChimePath = "" Then
            Me.lblACAlarmChimePath.Text = "Default Chime"
            Me.TipInfoEX.SetText(Me.lblACAlarmChimePath, "Use Built-In Chime")
        Else
            Me.lblACAlarmChimePath.Text = "...\" + My.App.ACAlarmChimePath.Split(CChar("\"))(My.App.ACAlarmChimePath.Split(CChar("\")).Length - 1)
            Me.TipInfoEX.SetText(Me.lblACAlarmChimePath, My.App.ACAlarmChimePath)
        End If
        Select Case My.App.ACAlarmChimeType
            Case My.App.ACChimeType.Simple : Me.radiobtnACAlarmChimeSimple.Checked = True
            Case My.App.ACChimeType.Extended : Me.radiobtnACAlarmChimeExtended.Checked = True
            Case My.App.ACChimeType.Forever : Me.radiobtnACAlarmChimeForever.Checked = True
        End Select
        If My.App.ACTopHourChimeEnabled Then : Me.checkboxACTopHourChimeEnabled.Checked = True
        Else : Me.checkboxACTopHourChimeEnabled.Checked = False
        End If
        If My.App.ACTopHourBeforeChimeEnabled Then : Me.checkboxACTopHourBeforeChimeEnabled.Checked = True
        Else : Me.checkboxACTopHourBeforeChimeEnabled.Checked = False
        End If
        If My.App.ACTopHourAfterChimeEnabled Then : Me.checkboxACTopHourAfterChimeEnabled.Checked = True
        Else : Me.checkboxACTopHourAfterChimeEnabled.Checked = False
        End If
        If My.App.ACFirstQuarterHourChimeEnabled Then : Me.checkboxACFirstQuarterHourChimeEnabled.Checked = True
        Else : Me.checkboxACFirstQuarterHourChimeEnabled.Checked = False
        End If
        If My.App.ACFirstQuarterHourBeforeChimeEnabled Then : Me.checkboxACFirstQuarterHourBeforeChimeEnabled.Checked = True
        Else : Me.checkboxACFirstQuarterHourBeforeChimeEnabled.Checked = False
        End If
        If My.App.ACFirstQuarterHourAfterChimeEnabled Then : Me.checkboxACFirstQuarterHourAfterChimeEnabled.Checked = True
        Else : Me.checkboxACFirstQuarterHourAfterChimeEnabled.Checked = False
        End If
        If My.App.ACBottomHourChimeEnabled Then : Me.checkboxACBottomHourChimeEnabled.Checked = True
        Else : Me.checkboxACBottomHourChimeEnabled.Checked = False
        End If
        If My.App.ACBottomHourBeforeChimeEnabled Then : Me.checkboxACBottomHourBeforeChimeEnabled.Checked = True
        Else : Me.checkboxACBottomHourBeforeChimeEnabled.Checked = False
        End If
        If My.App.ACBottomHourAfterChimeEnabled Then : Me.checkboxACBottomHourAfterChimeEnabled.Checked = True
        Else : Me.checkboxACBottomHourAfterChimeEnabled.Checked = False
        End If
        If My.App.ACThirdQuarterHourChimeEnabled Then : Me.checkboxACThirdQuarterHourChimeEnabled.Checked = True
        Else : Me.checkboxACThirdQuarterHourChimeEnabled.Checked = False
        End If
        If My.App.ACThirdQuarterHourBeforeChimeEnabled Then : Me.checkboxACThirdQuarterHourBeforeChimeEnabled.Checked = True
        Else : Me.checkboxACThirdQuarterHourBeforeChimeEnabled.Checked = False
        End If
        If My.App.ACThirdQuarterHourAfterChimeEnabled Then : Me.checkboxACThirdQuarterHourAfterChimeEnabled.Checked = True
        Else : Me.checkboxACThirdQuarterHourAfterChimeEnabled.Checked = False
        End If
        If My.App.ACTopHourChimePath = "" Then
            Me.lblACTopHourChimePath.Text = "Default Chime"
            Me.TipInfoEX.SetText(Me.lblACTopHourChimePath, "Use Built-In Chime")
        Else
            Me.lblACTopHourChimePath.Text = "...\" + My.App.ACTopHourChimePath.Split(CChar("\"))(My.App.ACTopHourChimePath.Split(CChar("\")).Length - 1)
            Me.TipInfoEX.SetText(Me.lblACTopHourChimePath, My.App.ACTopHourChimePath)
        End If
        Select Case My.App.ACTopHourChimeType
            Case My.App.ACChimeType.Simple : Me.radiobtnACTopHourChimeSimple.Checked = True
            Case My.App.ACChimeType.Extended : Me.radiobtnACTopHourChimeExtended.Checked = True
            Case My.App.ACChimeType.HourTick : Me.radiobtnACTopHourChimeHourTick.Checked = True
        End Select
        If My.App.ACOffHourChimePath = "" Then
            Me.lblACOffHourChimePath.Text = "Default Chime"
            Me.TipInfoEX.SetText(Me.lblACOffHourChimePath, "Use Built-In Chime")
        Else
            Me.lblACOffHourChimePath.Text = "...\" + My.App.ACOffHourChimePath.Split(CChar("\")).GetValue(My.App.ACOffHourChimePath.Split(CChar("\")).Length - 1).ToString
            Me.TipInfoEX.SetText(Me.lblACOffHourChimePath, My.App.ACOffHourChimePath)
        End If
    End Sub
    Private Sub ShowSettingsWL()
        Me.PanelWLItem.Hide()
        Me.listviewWL.Clear()
        Me.lblWLRoot.ResetFont()
        Me.textboxWLRoot.ResetText()
        Me.textboxWLRoot.Select()
        Me.textboxWLName.ResetText()
        Me.comboboxWLSort.SelectedIndex = -1
        Me.comboboxWLFolderMode.SelectedIndex = -1
        Me.comboboxWLFolderPlacement.SelectedIndex = -1
        Me.checkboxWLUseDefaultIcon.Checked = False
        Me.checkboxWLShowInMenu.Checked = False
        Me.checkboxWLShowInTray.Checked = False
        Me.checkboxWLShowFilePathToolTips.Checked = My.App.WLShowFilePathToolTips
        Me.checkboxWLShowFileInfoToolTips.Checked = My.App.WLShowFileInfoToolTips
        Me.checkboxWLShowFolderPathToolTips.Checked = My.App.WLShowFolderPathToolTips
        Me.textboxWLStartUpDelay.Text = My.App.WLStartUpDelay.ToString
        Me.textboxWLMaxLinksPerFolder.Text = My.App.WLMaxLinksPerFolder.ToString
        Me.checkboxWLAutoRefresh.Checked = My.App.WLAutoRefresh
        Me.textboxWLAutoRefreshInterval.Text = My.App.WLAutoRefreshInterval.ToString
        Me.textboxWLAutoRefreshIdleInterval.Text = My.App.WLAutoRefreshIdleInterval.ToString
        Me.listviewWL.Columns.Add("Path", 331) '354 = Full ListView Width
        For index As Integer = 0 To My.App.WLData.Count - 1
            Dim link As My.App.WLItemType = My.App.WLData(index)
            Dim split As String() = link.Root.Split(CChar("\"))
            Dim item As New ListViewItem With {.Font = App.MenuFont}
            If link.Root.Length > 60 Then
                item.Text = "...\" + split(split.Length - 1)
                item.ToolTipText = link.Root
            Else : item.Text = link.Root
            End If
            If index = My.App.WLData.Count - 1 And My.App.WLAutoRefresh And (link.ShowInMenu Or link.ShowInTray) Then
                item.Font = New Font(item.Font, FontStyle.Bold)
                If Not String.IsNullOrEmpty(item.ToolTipText) Then item.ToolTipText &= Environment.NewLine & Environment.NewLine
                item.ToolTipText &= "AutoRefresh Enabled"
            End If
            If Not link.ShowInMenu And Not link.ShowInTray Then
                item.ForeColor = SystemColors.GrayText
                If Not String.IsNullOrEmpty(item.ToolTipText) Then item.ToolTipText &= Environment.NewLine & Environment.NewLine
                item.ToolTipText &= "WinLink InActive on both Menu & Tray"
            End If
            Me.listviewWL.Items.Add(item)
        Next
    End Sub
    Private Sub ShowSettingsHC()
    End Sub
    Private Sub ShowSettingsHK()
    End Sub
    Private Sub RestoreSettings()
        My.App.GetSettings()
        ShowSettings()
        Dim selectedTheme As Skye.UI.SkyeTheme = If(App.ThemeAuto, Skye.UI.ThemeManager.DetectWindowsTheme(), App.Theme)
        Skye.UI.ThemeManager.SetTheme(selectedTheme)
        App.NeedsSaved = False
        ShowSave()
    End Sub
    Friend Sub ShowSave()
        If App.NeedsSaved Then
            BtnSaveSettings.BackColor = Color.Red
            TipInfoEX.SetText(BtnSaveSettings, "Settings Need Saved")
        Else
            BtnSaveSettings.BackColor = Skye.UI.ThemeManager.CurrentTheme.ButtonBack
            TipInfoEX.SetText(BtnSaveSettings, "Save All Settings")
        End If
    End Sub
    Private Sub SetThemesList()
        If App.ThemeAuto Then
            CoBoxTheme.Enabled = False
        Else
            CoBoxTheme.Enabled = True
        End If
    End Sub
    Private Sub SetSS()
        Me.PanelSS.Enabled = App.WSTSSToolEnabled
    End Sub
    Private Sub SetAC()
        Me.PanelAC.Enabled = My.App.WSTShowAC
        ShowSettingsAC()
        FrmMain.ACSet()
    End Sub
    Private Sub ACUpdateMute()
        If App.FrmMain.ACMute Then
            Me.btnACMute.Image = My.Resources.Resources.imageACMute
            Me.TipInfoEX.SetText(Me.btnACMute, "Sound All Chimes")
        Else
            Me.btnACMute.Image = My.Resources.Resources.imageACSound
            Me.TipInfoEX.SetText(Me.btnACMute, "Mute All Chimes")
        End If
    End Sub
    Friend Sub ACUpdateCancel(visible As Boolean)
        If visible Then
            Me.btnACAlarmCancel.Visible = True
        Else
            Me.btnACAlarmCancel.Visible = False
        End If
    End Sub
    Private Sub SetWL()
        If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then : Me.PanelWL.Enabled = True
        Else : Me.PanelWL.Enabled = False
        End If
    End Sub
    Friend Sub WLShowAutoRefreshState()
        Me.lblWLAutoRefresh.Visible = App.FrmMain.WLShowAutoRefresh
    End Sub
    Private Sub WLSetNew()
        If Me.listviewWL.SelectedIndices.Count = 0 Then : App.FrmMain.WLInsertIndex = -1
        Else : App.FrmMain.WLInsertIndex = Me.listviewWL.SelectedIndices(0)
        End If
        ShowSettingsWL()
        Me.PanelWLItem.Show()
        Me.checkboxWLShowInMenu.Checked = True
        Me.checkboxWLShowInTray.Checked = True
        Me.checkboxWLShowNoMenu.Checked = False
        Me.checkboxWLShowMenuIcons.Checked = True
        Me.lblWLRoot.ResetFont()
        Me.lblWLRoot.Text = "Root Folder"
        Me.textboxWLRoot.Select()
    End Sub
    Private Sub CheckMove(ByRef location As Point)
        Dim screen As Rectangle = System.Windows.Forms.Screen.FromControl(Me).WorkingArea
        If location.X + Width > screen.Right Then location.X = screen.Right - Width + App.AdjustScreenBoundsNormalWindow
        If location.Y + Height > screen.Bottom Then location.Y = screen.Bottom - Height + App.AdjustScreenBoundsNormalWindow
        If location.X < screen.Left Then location.X = screen.Left - App.AdjustScreenBoundsNormalWindow
        If location.Y < screen.Top Then location.Y = screen.Top
    End Sub

End Class
