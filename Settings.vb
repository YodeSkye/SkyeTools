
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
        WLSetSettingsState(Not App.FrmMain.IsWLBackgroundWorkerBusy)
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
    Private Shared Sub TxtBoxHandleEnterKey(sender As Object, e As KeyEventArgs) Handles TxtBoxLoadOnOSStartupArgs.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' 1. Silence the system ding
            e.SuppressKeyPress = True
            ' 2. Trigger validation on the form/control
            Dim tb As TextBox = TryCast(sender, TextBox)
            tb?.FindForm()?.ValidateChildren()
        End If
    End Sub
    Private Sub TxtBoxNumbersOnly_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtBoxWLStartUpDelay.KeyDown, TxtBoxWLMaxLinksPerFolder.KeyDown, TxtBoxWLAutoRefreshInterval.KeyDown, TxtBoxWLAutoRefreshIdleInterval.KeyDown
        nonNumberEntered = False
        If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
            If e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Enter Then : nonNumberEntered = True
            ElseIf e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Validate()
            End If
        End If
    End Sub
    Private Sub TxtBoxNumbersOnly_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtBoxACAlarmTime.KeyPress, TxtBoxACAlarmTimer.KeyPress, TxtBoxWLStartUpDelay.KeyPress, TxtBoxWLMaxLinksPerFolder.KeyPress, TxtBoxWLAutoRefreshInterval.KeyPress, TxtBoxWLAutoRefreshIdleInterval.KeyPress
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
                SetWL()
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
    Private Sub BtnACAlarmSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnACAlarmSet.Click
        App.FrmMain.ACAlarmActive = Not App.FrmMain.ACAlarmActive
        App.FrmMain.ACSetTimer()
        App.FrmMain.UpdateWST()
        ShowSettingsAC()
    End Sub
    Private Sub BtnACAlarmCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnACAlarmCancel.Click
        App.FrmMain.ACAlarmCancel()
    End Sub
    Private Sub BtnACChimeDefault_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnACTopHourChimeDefault.Click, BtnACOffHourChimeDefault.Click, BtnACAlarmChimeDefault.Click
        If sender Is Me.BtnACAlarmChimeDefault Then : My.App.ACAlarmChimePath = ""
        ElseIf sender Is Me.BtnACTopHourChimeDefault Then : My.App.ACTopHourChimePath = ""
        ElseIf sender Is Me.BtnACOffHourChimeDefault Then : My.App.ACOffHourChimePath = ""
        End If
        ShowSettingsAC()
        App.SetSave()
    End Sub
    Private Sub BtnACChimeManual_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnACTopHourChimeManual.Click, BtnACOffHourChimeManual.Click, BtnACAlarmChimeManual.Click
        Dim r As DialogResult = Me.OFDACSelectWAV.ShowDialog(Me)
        If r = System.Windows.Forms.DialogResult.OK And Not Me.OFDACSelectWAV.FileName = "" Then
            If sender Is Me.BtnACAlarmChimeManual Then : My.App.ACAlarmChimePath = Me.OFDACSelectWAV.FileName
            ElseIf sender Is Me.BtnACTopHourChimeManual Then : My.App.ACTopHourChimePath = Me.OFDACSelectWAV.FileName
            ElseIf sender Is Me.BtnACOffHourChimeManual Then : My.App.ACOffHourChimePath = Me.OFDACSelectWAV.FileName
            End If
        ElseIf Not r = System.Windows.Forms.DialogResult.Cancel Then
            If sender Is Me.BtnACAlarmChimeManual Then : My.App.ACAlarmChimePath = ""
            ElseIf sender Is Me.BtnACTopHourChimeManual Then : My.App.ACTopHourChimePath = ""
            ElseIf sender Is Me.BtnACOffHourChimeManual Then : My.App.ACOffHourChimePath = ""
            End If
        End If
        ShowSettingsAC()
        App.SetSave()
    End Sub
    Private Sub BtnACChimePlay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnACTopHourChimePlay.Click, BtnACOffHourChimePlay.Click, BtnACAlarmChimePlay.Click
        Dim counter As Byte = 0
        Dim chime As String = ""
        Dim chimecount As Byte = 0
        If sender Is Me.BtnACAlarmChimePlay Then
            Me.LblACAlarmChime.ForeColor = Color.Maroon
            Me.LblACAlarmChime.Font = New Font(Me.Font, Drawing.FontStyle.Bold)
            Me.LblACAlarmChime.Refresh()
            chime = My.App.ACAlarmChimePath
            Select Case My.App.ACAlarmChimeType
                Case My.App.ACChimeType.Simple : chimecount = 1
                Case Else : chimecount = 4
            End Select
        ElseIf sender Is Me.BtnACTopHourChimePlay Then
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
        ElseIf sender Is Me.BtnACOffHourChimePlay Then
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
            If sender Is Me.BtnACAlarmChimePlay And My.App.ACAlarmChimeType = My.App.ACChimeType.Forever Then chimecount = Byte.MaxValue
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
    Private Sub BtnACMute_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnACMute.Click
        App.FrmMain.ACMute = Not App.FrmMain.ACMute
        App.FrmMain.CancelBackgroundworkerAC()
        ACUpdateMute()
    End Sub
    Private Sub ChkBoxACAlarmRecurring_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChkBoxACAlarmRecurring.Click
        App.ACAlarmRecurring = Not App.ACAlarmRecurring
        If App.ACAlarmRecurring And Not App.FrmMain.ACAlarmActive Then
            App.FrmMain.ACAlarmActive = True
            App.FrmMain.ACSetTimer()
            ShowSettingsAC()
        End If
        SetSave()
    End Sub
    Private Sub ChkBoxACChimeEnabled_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChkBoxACTopHourChimeEnabled.Click, ChkBoxACTopHourBeforeChimeEnabled.Click, ChkBoxACTopHourAfterChimeEnabled.Click, ChkBoxACThirdQuarterHourChimeEnabled.Click, ChkBoxACThirdQuarterHourBeforeChimeEnabled.Click, ChkBoxACThirdQuarterHourAfterChimeEnabled.Click, ChkBoxACFirstQuarterHourChimeEnabled.Click, ChkBoxACFirstQuarterHourBeforeChimeEnabled.Click, ChkBoxACFirstQuarterHourAfterChimeEnabled.Click, ChkBoxACBottomHourChimeEnabled.Click, ChkBoxACBottomHourBeforeChimeEnabled.Click, ChkBoxACBottomHourAfterChimeEnabled.Click
        Select Case CType(sender, System.Windows.Forms.CheckBox).Name
            Case Me.ChkBoxACTopHourChimeEnabled.Name : My.App.ACTopHourChimeEnabled = Not My.App.ACTopHourChimeEnabled
            Case Me.ChkBoxACTopHourBeforeChimeEnabled.Name : My.App.ACTopHourBeforeChimeEnabled = Not My.App.ACTopHourBeforeChimeEnabled
            Case Me.ChkBoxACTopHourAfterChimeEnabled.Name : My.App.ACTopHourAfterChimeEnabled = Not My.App.ACTopHourAfterChimeEnabled
            Case Me.ChkBoxACFirstQuarterHourChimeEnabled.Name : My.App.ACFirstQuarterHourChimeEnabled = Not My.App.ACFirstQuarterHourChimeEnabled
            Case Me.ChkBoxACFirstQuarterHourBeforeChimeEnabled.Name : My.App.ACFirstQuarterHourBeforeChimeEnabled = Not My.App.ACFirstQuarterHourBeforeChimeEnabled
            Case Me.ChkBoxACFirstQuarterHourAfterChimeEnabled.Name : My.App.ACFirstQuarterHourAfterChimeEnabled = Not My.App.ACFirstQuarterHourAfterChimeEnabled
            Case Me.ChkBoxACBottomHourChimeEnabled.Name : My.App.ACBottomHourChimeEnabled = Not My.App.ACBottomHourChimeEnabled
            Case Me.ChkBoxACBottomHourBeforeChimeEnabled.Name : My.App.ACBottomHourBeforeChimeEnabled = Not My.App.ACBottomHourBeforeChimeEnabled
            Case Me.ChkBoxACBottomHourAfterChimeEnabled.Name : My.App.ACBottomHourAfterChimeEnabled = Not My.App.ACBottomHourAfterChimeEnabled
            Case Me.ChkBoxACThirdQuarterHourChimeEnabled.Name : My.App.ACThirdQuarterHourChimeEnabled = Not My.App.ACThirdQuarterHourChimeEnabled
            Case Me.ChkBoxACThirdQuarterHourBeforeChimeEnabled.Name : My.App.ACThirdQuarterHourBeforeChimeEnabled = Not My.App.ACThirdQuarterHourBeforeChimeEnabled
            Case Me.ChkBoxACThirdQuarterHourAfterChimeEnabled.Name : My.App.ACThirdQuarterHourAfterChimeEnabled = Not My.App.ACThirdQuarterHourAfterChimeEnabled
        End Select
        App.SetSave()
    End Sub
    Private Sub RadBtnACChimeType_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadBtnACTopHourChimeSimple.Click, RadBtnACTopHourChimeHourTick.Click, RadBtnACTopHourChimeExtended.Click, RadBtnACAlarmChimeSimple.Click, RadBtnACAlarmChimeForever.Click, RadBtnACAlarmChimeExtended.Click
        If sender Is Me.RadBtnACAlarmChimeSimple Then : My.App.ACAlarmChimeType = My.App.ACChimeType.Simple
        ElseIf sender Is Me.RadBtnACAlarmChimeExtended Then : My.App.ACAlarmChimeType = My.App.ACChimeType.Extended
        ElseIf sender Is Me.RadBtnACAlarmChimeForever Then : My.App.ACAlarmChimeType = My.App.ACChimeType.Forever
        ElseIf sender Is Me.RadBtnACTopHourChimeSimple Then : My.App.ACTopHourChimeType = My.App.ACChimeType.Simple
        ElseIf sender Is Me.RadBtnACTopHourChimeExtended Then : My.App.ACTopHourChimeType = My.App.ACChimeType.Extended
        ElseIf sender Is Me.RadBtnACTopHourChimeHourTick Then : My.App.ACTopHourChimeType = My.App.ACChimeType.HourTick
        End If
        App.SetSave()
    End Sub
    Private Sub TxtBoxACAlarmTime_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtBoxACAlarmTime.KeyDown
        nonNumberEntered = False
        If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
            If e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Enter And Not (e.Shift And e.KeyCode = Keys.OemSemicolon And sender Is Me.TxtBoxACAlarmTime) Then : nonNumberEntered = True
            ElseIf e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Dim h, m As Integer
                Try
                    Dim split As String() = Me.TxtBoxACAlarmTime.Text.Split(CChar(":"))
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
                    Me.TxtBoxACAlarmTime.ResetBackColor()
                    Me.TxtBoxACAlarmTime.ResetForeColor()
                    Me.TxtBoxACAlarmTime.SelectAll()
                Catch
                    Me.TxtBoxACAlarmTime.BackColor = Color.Red
                    Me.TxtBoxACAlarmTime.ForeColor = Color.Yellow
                    Me.TxtBoxACAlarmTime.SelectAll()
                End Try
                App.SetSave()
            End If
        End If
    End Sub
    Private Sub TxtBoxACTimer_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtBoxACAlarmTimer.KeyDown
        nonNumberEntered = False
        If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
            If e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Enter Then : nonNumberEntered = True
            ElseIf e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                If Int(Val(Me.TxtBoxACAlarmTimer.Text)) < 1 Then Me.TxtBoxACAlarmTimer.Text = "1"
                If Int(Val(Me.TxtBoxACAlarmTimer.Text)) > 720 Then Me.TxtBoxACAlarmTimer.Text = "720"
                My.App.ACAlarmTime = New TimeSpan(My.Computer.Clock.LocalTime.AddMinutes(Int(Val(Me.TxtBoxACAlarmTimer.Text))).Hour, My.Computer.Clock.LocalTime.AddMinutes(Int(Val(Me.TxtBoxACAlarmTimer.Text))).Minute, 0)
                App.FrmMain.ACAlarmActive = True
                App.FrmMain.ACSetTimer()
                App.FrmMain.UpdateWST()
                ShowSettingsAC()
                Me.TxtBoxACAlarmTime.Focus()
                Me.TxtBoxACAlarmTime.SelectAll()
                App.SetSave()
            End If
        End If
    End Sub

    ' WinLinks
    Private Sub CMLVWL_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMLVWL.Opening
        If Me.LVWL.SelectedIndices.Count > 0 Then
            If Me.LVWL.SelectedIndices(0) = 0 Then : Me.CMIWLMoveUp.Enabled = False
            Else : Me.CMIWLMoveUp.Enabled = True
            End If
            If Me.LVWL.SelectedIndices(0) = My.App.WLData.Count - 1 Then : Me.CMIWLMoveDown.Enabled = False
            Else : Me.CMIWLMoveDown.Enabled = True
            End If
            Me.CMIWLNew.Text = "New (Insert Above)"
            Me.CMIWLDelete.Enabled = True
        Else
            Me.CMIWLMoveUp.Enabled = False
            Me.CMIWLMoveDown.Enabled = False
            Me.CMIWLNew.Text = "New (Insert Last)"
            Me.CMIWLDelete.Enabled = False
        End If
    End Sub
    Private Sub CMIWLMove_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles CMIWLMoveUp.MouseUp, CMIWLMoveDown.MouseUp
        If e.Button = MouseButtons.Left And Me.LVWL.SelectedIndices.Count > 0 Then
            Dim link As My.App.WLItemType = My.App.WLData(Me.LVWL.SelectedIndices(0))
            My.App.WLData.RemoveAt(Me.LVWL.SelectedIndices(0))
            Select Case CType(sender, ToolStripItem).Name
                Case Me.CMIWLMoveUp.Name : My.App.WLData.Insert(Me.LVWL.SelectedIndices(0) - 1, link)
                Case Me.CMIWLMoveDown.Name : My.App.WLData.Insert(Me.LVWL.SelectedIndices(0) + 1, link)
            End Select
            App.FrmMain.WLSetManualRefresh()
            App.SetSave()
        End If
    End Sub
    Private Sub CMIWLNew_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles CMIWLNew.MouseUp
        If e.Button = MouseButtons.Left Then WLSetNew()
    End Sub
    Private Sub CMIWLDelete_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles CMIWLDelete.MouseUp
        If e.Button = MouseButtons.Left And Me.LVWL.SelectedIndices.Count > 0 Then
            App.FrmMain.WLSetAutoRefresh(True)
            My.App.WLData.RemoveAt(Me.LVWL.SelectedIndices(0))
            App.FrmMain.WLSetManualRefresh()
            App.SetSave()
        End If
    End Sub
    Private Sub LVWL_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LVWL.SelectedIndexChanged
        If Me.LVWL.SelectedIndices.Count > 0 Then
            Dim link As My.App.WLItemType = My.App.WLData(Me.LVWL.SelectedIndices(0))
            Me.LblWLRoot.Font = New Font(Me.Font, FontStyle.Regular)
            If Me.LVWL.SelectedIndices(0) = My.App.WLData.Count - 1 And My.App.WLAutoRefresh Then : Me.LblWLRoot.Text = "Root Folder (AutoRefresh Enabled)"
            Else : Me.LblWLRoot.Text = "Root Folder"
            End If
            Me.TxtBoxWLRoot.Text = link.Root
            Me.TxtBoxWLName.Text = link.Name
            Me.CoBoxWLSort.SelectedIndex = link.Sort - 1
            Me.CoBoxWLFolderMode.SelectedIndex = link.FolderMode
            Me.CoBoxWLFolderPlacement.SelectedIndex = link.FolderPlacement
            If link.UseDefaultIcon Then : Me.ChkBoxWLUseDefaultIcon.Checked = True
            Else : Me.ChkBoxWLUseDefaultIcon.Checked = False
            End If
            If link.ShowInMenu Then : Me.ChkBoxWLShowInMenu.Checked = True
            Else : Me.ChkBoxWLShowInMenu.Checked = False
            End If
            If link.ShowInTray Then : Me.ChkBoxWLShowInTray.Checked = True
            Else : Me.ChkBoxWLShowInTray.Checked = False
            End If
            If link.ShowNoMenu Then : Me.ChkBoxWLShowNoMenu.Checked = True
            Else : Me.ChkBoxWLShowNoMenu.Checked = False
            End If
            If link.ShowMenuIcons Then : Me.ChkBoxWLShowMenuIcons.Checked = True
            Else : Me.ChkBoxWLShowMenuIcons.Checked = False
            End If
            Me.PanelWLItem.Show()
        ElseIf Me.LVWL.FocusedItem IsNot Nothing Then : ShowSettingsWL()
        End If
    End Sub
    Private Sub BtnWLRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnWLRefresh.Click
        If Me.BtnWLRefresh.Text = "CANCEL" Then
            Me.BtnWLRefresh.Enabled = False
            Me.BtnWLRefresh.Text = "PENDING..."
            Me.TipInfoEX.SetText(Me.BtnWLRefresh, "Stopping File Search, Please Wait...")
            App.FrmMain.CancelBackgroundworkerWL()
        Else
            App.FrmMain.WLClose(True)
            App.FrmMain.ShowWL()
        End If
    End Sub
    Private Sub BtnWLSelectFolder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnWLSelectFolder.Click
        If Not String.IsNullOrEmpty(Me.TxtBoxWLRoot.Text) Then Me.FBDWLFolderBrowser.SelectedPath = Me.TxtBoxWLRoot.Text
        Dim r As DialogResult = Me.FBDWLFolderBrowser.ShowDialog(Me)
        If r = System.Windows.Forms.DialogResult.OK And Not Me.FBDWLFolderBrowser.SelectedPath = "" Then
            Me.TxtBoxWLRoot.Text = Me.FBDWLFolderBrowser.SelectedPath
        ElseIf Not r = System.Windows.Forms.DialogResult.Cancel Then
            Me.TxtBoxWLRoot.Text = ""
        End If
        App.SetSave()
        Me.TxtBoxWLRoot.Select(Me.TxtBoxWLRoot.Text.Length, 0)
        Me.TxtBoxWLRoot.Focus()
    End Sub
    Private Sub BtnWLSelectFolder_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles BtnWLSelectFolder.Enter
        Me.TxtBoxWLRoot.Focus()
    End Sub
    Private Sub BtnWLSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnWLSet.Click
        If String.IsNullOrEmpty(Me.TxtBoxWLRoot.Text) Or Me.TxtBoxWLRoot.Text.Length < 4 Then
            Me.LblWLRoot.Font = New Font(Me.Font, FontStyle.Bold)
            Me.TxtBoxWLRoot.Select()
        Else
            Dim link As New My.App.WLItemType With {
                .Root = Me.TxtBoxWLRoot.Text,
                .Name = Me.TxtBoxWLName.Text}
            'Edit
            If Me.LVWL.SelectedIndices.Count > 0 Then
                If Me.CoBoxWLSort.SelectedIndex = -1 Then Me.CoBoxWLSort.SelectedIndex = 0
                link.Sort = CType(Me.CoBoxWLSort.SelectedIndex + 1, SortOrder)
                If Me.CoBoxWLFolderMode.SelectedIndex = -1 Then Me.CoBoxWLFolderMode.SelectedIndex = 0
                link.FolderMode = CType(Me.CoBoxWLFolderMode.SelectedIndex, My.App.WLFolderMode)
                If Me.CoBoxWLFolderPlacement.SelectedIndex = -1 Then Me.CoBoxWLFolderPlacement.SelectedIndex = 0
                link.FolderPlacement = CType(Me.CoBoxWLFolderPlacement.SelectedIndex, My.App.WLFolderPlacement)
                link.UseDefaultIcon = Me.ChkBoxWLUseDefaultIcon.Checked
                link.ShowInMenu = Me.ChkBoxWLShowInMenu.Checked
                link.ShowInTray = Me.ChkBoxWLShowInTray.Checked
                link.ShowNoMenu = Me.ChkBoxWLShowNoMenu.Checked
                link.ShowMenuIcons = Me.ChkBoxWLShowMenuIcons.Checked
                link.RefreshData = True
                link.RefreshMenu = True
                If Not (link.ShowInMenu = My.App.WLData(Me.LVWL.SelectedIndices(0)).ShowInMenu And link.ShowInTray = My.App.WLData(Me.LVWL.SelectedIndices(0)).ShowInTray And link.Root = My.App.WLData(Me.LVWL.SelectedIndices(0)).Root And link.Name = My.App.WLData(Me.LVWL.SelectedIndices(0)).Name) Then App.FrmMain.WLClose(True)
                My.App.WLData.RemoveAt(Me.LVWL.SelectedIndices(0))
                My.App.WLData.Insert(Me.LVWL.SelectedIndices(0), link)
                If App.FrmMain.WLMenuDataCount = 0 Then
                    App.FrmMain.WLSetManualRefresh()
                Else
                    App.FrmMain.ShowWL()
                End If

                'New
            Else
                If Me.CoBoxWLSort.SelectedIndex = -1 Then Me.CoBoxWLSort.SelectedIndex = 0
                link.Sort = CType(Me.CoBoxWLSort.SelectedIndex + 1, SortOrder)
                If Me.CoBoxWLFolderMode.SelectedIndex = -1 Then Me.CoBoxWLFolderMode.SelectedIndex = 0
                link.FolderMode = CType(Me.CoBoxWLFolderMode.SelectedIndex, My.App.WLFolderMode)
                If Me.CoBoxWLFolderPlacement.SelectedIndex = -1 Then Me.CoBoxWLFolderPlacement.SelectedIndex = 0
                link.FolderPlacement = CType(Me.CoBoxWLFolderPlacement.SelectedIndex, My.App.WLFolderPlacement)
                If App.FrmMain.WLInsertIndex = -1 Then App.FrmMain.WLInsertIndex = My.App.WLData.Count
                link.UseDefaultIcon = Me.ChkBoxWLUseDefaultIcon.Checked
                link.ShowInMenu = Me.ChkBoxWLShowInMenu.Checked
                link.ShowInTray = Me.ChkBoxWLShowInTray.Checked
                link.ShowNoMenu = Me.ChkBoxWLShowNoMenu.Checked
                link.ShowMenuIcons = Me.ChkBoxWLShowMenuIcons.Checked
                My.App.WLData.Insert(App.FrmMain.WLInsertIndex, link)
                App.FrmMain.WLSetManualRefresh()
            End If
            App.SetSave()
        End If
    End Sub
    Private Sub BtnWLCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnWLCancel.Click
        ShowSettingsWL()
    End Sub
    Private Sub ChkBoxWLShowFileInfoToolTips_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChkBoxWLShowFileInfoToolTips.Click
        My.App.WLShowFileInfoToolTips = Not My.App.WLShowFileInfoToolTips
        App.SetSave()
    End Sub
    Private Sub ChkBoxWLShowFilePathToolTips_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChkBoxWLShowFilePathToolTips.Click
        My.App.WLShowFilePathToolTips = Not My.App.WLShowFilePathToolTips
        App.SetSave()
    End Sub
    Private Sub ChkBoxWLShowFolderPathToolTips_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChkBoxWLShowFolderPathToolTips.Click
        My.App.WLShowFolderPathToolTips = Not My.App.WLShowFolderPathToolTips
        App.SetSave()
    End Sub
    Private Sub ChkBoxWLAutoRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChkBoxWLAutoRefresh.Click
        My.App.WLAutoRefresh = Not My.App.WLAutoRefresh
        App.FrmMain.WLSetAutoRefresh()
        ShowSettingsWL()
        App.SetSave()
    End Sub
    Private Sub TxtBoxWLStartUpDelay_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtBoxWLStartUpDelay.Validating
        If Int(Val(Me.TxtBoxWLStartUpDelay.Text)) < 5 And Int(Val(Me.TxtBoxWLStartUpDelay.Text)) <> 0 Then Me.TxtBoxWLStartUpDelay.Text = "5"
        If Int(Val(Me.TxtBoxWLStartUpDelay.Text)) > 300 Then Me.TxtBoxWLStartUpDelay.Text = "300"
    End Sub
    Private Sub TxtBoxWLStartUpDelay_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles TxtBoxWLStartUpDelay.Validated
        My.App.WLStartUpDelay = CShort(Val(Me.TxtBoxWLStartUpDelay.Text))
        Me.TxtBoxWLStartUpDelay.SelectAll()
        App.SetSave()
    End Sub
    Private Sub TxtBoxWLMaxLinksPerFolder_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtBoxWLMaxLinksPerFolder.Validating
        If Int(Val(Me.TxtBoxWLMaxLinksPerFolder.Text)) < 1 Then Me.TxtBoxWLMaxLinksPerFolder.Text = "1"
        If Int(Val(Me.TxtBoxWLMaxLinksPerFolder.Text)) > 100 Then Me.TxtBoxWLMaxLinksPerFolder.Text = "100"
    End Sub
    Private Sub TxtBoxWLMaxLinksPerFolder_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles TxtBoxWLMaxLinksPerFolder.Validated
        My.App.WLMaxLinksPerFolder = CByte(Val(Me.TxtBoxWLMaxLinksPerFolder.Text))
        Me.TxtBoxWLMaxLinksPerFolder.SelectAll()
        App.SetSave()
    End Sub
    Private Sub TxtBoxWLAutoRefreshInterval_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtBoxWLAutoRefreshInterval.Validating
        If Int(Val(Me.TxtBoxWLAutoRefreshInterval.Text)) < 1 Then Me.TxtBoxWLAutoRefreshInterval.Text = "1"
        If Int(Val(Me.TxtBoxWLAutoRefreshInterval.Text)) > 90 Then Me.TxtBoxWLAutoRefreshInterval.Text = "90"
    End Sub
    Private Sub TxtBoxWLAutoRefreshInterval_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles TxtBoxWLAutoRefreshInterval.Validated
        If Not My.App.WLAutoRefreshInterval = Int(Val(Me.TxtBoxWLAutoRefreshInterval.Text)) Then
            My.App.WLAutoRefreshInterval = CByte(Val(Me.TxtBoxWLAutoRefreshInterval.Text))
            Me.TxtBoxWLAutoRefreshInterval.SelectAll()
            App.FrmMain.WLSetAutoRefresh()
            App.SetSave()
        End If
    End Sub
    Private Sub TxtBoxWLAutoRefreshIdleInterval_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtBoxWLAutoRefreshIdleInterval.Validating
        If Int(Val(Me.TxtBoxWLAutoRefreshIdleInterval.Text)) < 20 Then Me.TxtBoxWLAutoRefreshIdleInterval.Text = "20"
        If Int(Val(Me.TxtBoxWLAutoRefreshIdleInterval.Text)) > 240 Then Me.TxtBoxWLAutoRefreshIdleInterval.Text = "240"
    End Sub
    Private Sub TxtBoxWLAutoRefreshIdleInterval_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles TxtBoxWLAutoRefreshIdleInterval.Validated
        If Not My.App.WLAutoRefreshIdleInterval = Int(Val(Me.TxtBoxWLAutoRefreshIdleInterval.Text)) Then
            My.App.WLAutoRefreshIdleInterval = CByte(Val(Me.TxtBoxWLAutoRefreshIdleInterval.Text))
            Me.TxtBoxWLAutoRefreshIdleInterval.SelectAll()
            App.FrmMain.WLSetAutoRefresh()
            App.SetSave()
        End If
    End Sub

    ' HotClicks
    Private Sub RadBtnHCSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadBtnHCWSTSS.Click, RadBtnHCWST.Click, RadBtnHCWL.Click
        If RadBtnHCWST.Checked Then : HCShowActions(TrayTools.WorkSpaceTools)
        ElseIf RadBtnHCWL.Checked Then : HCShowActions(TrayTools.WinLinks)
        ElseIf RadBtnHCWSTSS.Checked Then : HCShowActions(TrayTools.ScreenSaver)
        End If
    End Sub
    Private Sub CoBoxHCSettings_SelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs) Handles CoBoxHCRight.SelectionChangeCommitted, CoBoxHCMiddle.SelectionChangeCommitted, CoBoxHCLeft.SelectionChangeCommitted, CoBoxHCDouble.SelectionChangeCommitted
        Select Case CType(sender, System.Windows.Forms.ComboBox).Name
            Case Me.CoBoxHCLeft.Name
                If Me.RadBtnHCWST.Checked Then : My.App.HCWSTLeft = CType(HCFindActionIndex(Me.CoBoxHCLeft.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.RadBtnHCWL.Checked Then : My.App.HCWLLeft = CType(HCFindActionIndex(Me.CoBoxHCLeft.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.RadBtnHCWSTSS.Checked Then : My.App.HCWSTScreenSaverLeft = CType(HCFindActionIndex(Me.CoBoxHCLeft.SelectedItem.ToString), My.App.HCAction)
                End If
            Case Me.CoBoxHCDouble.Name
                If Me.RadBtnHCWST.Checked Then : My.App.HCWSTDouble = CType(HCFindActionIndex(Me.CoBoxHCDouble.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.RadBtnHCWL.Checked Then : My.App.HCWLDouble = CType(HCFindActionIndex(Me.CoBoxHCDouble.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.RadBtnHCWSTSS.Checked Then : My.App.HCWSTScreenSaverDouble = CType(HCFindActionIndex(Me.CoBoxHCDouble.SelectedItem.ToString), My.App.HCAction)
                End If
            Case Me.CoBoxHCMiddle.Name
                If Me.RadBtnHCWST.Checked Then : My.App.HCWSTMiddle = CType(HCFindActionIndex(Me.CoBoxHCMiddle.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.RadBtnHCWL.Checked Then : My.App.HCWLMiddle = CType(HCFindActionIndex(Me.CoBoxHCMiddle.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.RadBtnHCWSTSS.Checked Then : My.App.HCWSTScreenSaverMiddle = CType(HCFindActionIndex(Me.CoBoxHCMiddle.SelectedItem.ToString), My.App.HCAction)
                End If
            Case Me.CoBoxHCRight.Name
                If Me.RadBtnHCWST.Checked Then : My.App.HCWSTRight = CType(HCFindActionIndex(Me.CoBoxHCRight.SelectedItem.ToString), My.App.HCAction)
                ElseIf Me.RadBtnHCWSTSS.Checked Then : My.App.HCWSTScreenSaverRight = CType(HCFindActionIndex(Me.CoBoxHCRight.SelectedItem.ToString), My.App.HCAction)
                End If
        End Select
        App.SetSave()
    End Sub

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
            Me.BtnACAlarmSet.Text = "Alarm Active"
            Me.BtnACAlarmSet.Font = New Font(Me.Font, FontStyle.Bold)
            Me.BtnACAlarmSet.ForeColor = Color.Teal
            Dim alarmText As String = My.App.ACAlarmTime.ToString()
            Me.TipInfoEX.SetText(Me.BtnACAlarmSet, String.Concat("Alarm Set for ", alarmText.AsSpan(0, alarmText.Length - 3)))
        Else
            Me.BtnACAlarmSet.Text = "Alarm InActive"
            Me.BtnACAlarmSet.Font = New Font(Me.Font, FontStyle.Regular)
            Me.BtnACAlarmSet.ForeColor = Color.Maroon
            Dim alarmText As String = My.App.ACAlarmTime.ToString()
            Me.TipInfoEX.SetText(Me.BtnACAlarmSet, String.Concat("Activate Alarm for ", alarmText.AsSpan(0, alarmText.Length - 3)))
        End If
        Me.TxtBoxACAlarmTime.Text = My.App.ACAlarmTime.ToString().Substring(0, My.App.ACAlarmTime.ToString().Length - 3)
        If My.App.ACAlarmRecurring Then : Me.ChkBoxACAlarmRecurring.Checked = True
        Else : Me.ChkBoxACAlarmRecurring.Checked = False
        End If
        If My.App.ACAlarmChimePath = "" Then
            Me.LblACAlarmChimePath.Text = "Default Chime"
            Me.TipInfoEX.SetText(Me.LblACAlarmChimePath, "Use Built-In Chime")
        Else
            Me.LblACAlarmChimePath.Text = "...\" + My.App.ACAlarmChimePath.Split(CChar("\"))(My.App.ACAlarmChimePath.Split(CChar("\")).Length - 1)
            Me.TipInfoEX.SetText(Me.LblACAlarmChimePath, My.App.ACAlarmChimePath)
        End If
        Select Case My.App.ACAlarmChimeType
            Case My.App.ACChimeType.Simple : Me.RadBtnACAlarmChimeSimple.Checked = True
            Case My.App.ACChimeType.Extended : Me.RadBtnACAlarmChimeExtended.Checked = True
            Case My.App.ACChimeType.Forever : Me.RadBtnACAlarmChimeForever.Checked = True
        End Select
        If My.App.ACTopHourChimeEnabled Then : Me.ChkBoxACTopHourChimeEnabled.Checked = True
        Else : Me.ChkBoxACTopHourChimeEnabled.Checked = False
        End If
        If My.App.ACTopHourBeforeChimeEnabled Then : Me.ChkBoxACTopHourBeforeChimeEnabled.Checked = True
        Else : Me.ChkBoxACTopHourBeforeChimeEnabled.Checked = False
        End If
        If My.App.ACTopHourAfterChimeEnabled Then : Me.ChkBoxACTopHourAfterChimeEnabled.Checked = True
        Else : Me.ChkBoxACTopHourAfterChimeEnabled.Checked = False
        End If
        If My.App.ACFirstQuarterHourChimeEnabled Then : Me.ChkBoxACFirstQuarterHourChimeEnabled.Checked = True
        Else : Me.ChkBoxACFirstQuarterHourChimeEnabled.Checked = False
        End If
        If My.App.ACFirstQuarterHourBeforeChimeEnabled Then : Me.ChkBoxACFirstQuarterHourBeforeChimeEnabled.Checked = True
        Else : Me.ChkBoxACFirstQuarterHourBeforeChimeEnabled.Checked = False
        End If
        If My.App.ACFirstQuarterHourAfterChimeEnabled Then : Me.ChkBoxACFirstQuarterHourAfterChimeEnabled.Checked = True
        Else : Me.ChkBoxACFirstQuarterHourAfterChimeEnabled.Checked = False
        End If
        If My.App.ACBottomHourChimeEnabled Then : Me.ChkBoxACBottomHourChimeEnabled.Checked = True
        Else : Me.ChkBoxACBottomHourChimeEnabled.Checked = False
        End If
        If My.App.ACBottomHourBeforeChimeEnabled Then : Me.ChkBoxACBottomHourBeforeChimeEnabled.Checked = True
        Else : Me.ChkBoxACBottomHourBeforeChimeEnabled.Checked = False
        End If
        If My.App.ACBottomHourAfterChimeEnabled Then : Me.ChkBoxACBottomHourAfterChimeEnabled.Checked = True
        Else : Me.ChkBoxACBottomHourAfterChimeEnabled.Checked = False
        End If
        If My.App.ACThirdQuarterHourChimeEnabled Then : Me.ChkBoxACThirdQuarterHourChimeEnabled.Checked = True
        Else : Me.ChkBoxACThirdQuarterHourChimeEnabled.Checked = False
        End If
        If My.App.ACThirdQuarterHourBeforeChimeEnabled Then : Me.ChkBoxACThirdQuarterHourBeforeChimeEnabled.Checked = True
        Else : Me.ChkBoxACThirdQuarterHourBeforeChimeEnabled.Checked = False
        End If
        If My.App.ACThirdQuarterHourAfterChimeEnabled Then : Me.ChkBoxACThirdQuarterHourAfterChimeEnabled.Checked = True
        Else : Me.ChkBoxACThirdQuarterHourAfterChimeEnabled.Checked = False
        End If
        If My.App.ACTopHourChimePath = "" Then
            Me.LblACTopHourChimePath.Text = "Default Chime"
            Me.TipInfoEX.SetText(Me.LblACTopHourChimePath, "Use Built-In Chime")
        Else
            Me.LblACTopHourChimePath.Text = "...\" + My.App.ACTopHourChimePath.Split(CChar("\"))(My.App.ACTopHourChimePath.Split(CChar("\")).Length - 1)
            Me.TipInfoEX.SetText(Me.LblACTopHourChimePath, My.App.ACTopHourChimePath)
        End If
        Select Case My.App.ACTopHourChimeType
            Case My.App.ACChimeType.Simple : Me.RadBtnACTopHourChimeSimple.Checked = True
            Case My.App.ACChimeType.Extended : Me.RadBtnACTopHourChimeExtended.Checked = True
            Case My.App.ACChimeType.HourTick : Me.RadBtnACTopHourChimeHourTick.Checked = True
        End Select
        If My.App.ACOffHourChimePath = "" Then
            Me.LblACOffHourChimePath.Text = "Default Chime"
            Me.TipInfoEX.SetText(Me.LblACOffHourChimePath, "Use Built-In Chime")
        Else
            Me.LblACOffHourChimePath.Text = "...\" + My.App.ACOffHourChimePath.Split(CChar("\")).GetValue(My.App.ACOffHourChimePath.Split(CChar("\")).Length - 1).ToString
            Me.TipInfoEX.SetText(Me.LblACOffHourChimePath, My.App.ACOffHourChimePath)
        End If
    End Sub
    Private Sub ShowSettingsWL()
        Me.PanelWLItem.Hide()
        Me.LVWL.Clear()
        Me.LblWLRoot.ResetFont()
        Me.TxtBoxWLRoot.ResetText()
        Me.TxtBoxWLRoot.Select()
        Me.TxtBoxWLName.ResetText()
        Me.CoBoxWLSort.SelectedIndex = -1
        Me.CoBoxWLFolderMode.SelectedIndex = -1
        Me.CoBoxWLFolderPlacement.SelectedIndex = -1
        Me.ChkBoxWLUseDefaultIcon.Checked = False
        Me.ChkBoxWLShowInMenu.Checked = False
        Me.ChkBoxWLShowInTray.Checked = False
        Me.ChkBoxWLShowFilePathToolTips.Checked = My.App.WLShowFilePathToolTips
        Me.ChkBoxWLShowFileInfoToolTips.Checked = My.App.WLShowFileInfoToolTips
        Me.ChkBoxWLShowFolderPathToolTips.Checked = My.App.WLShowFolderPathToolTips
        Me.TxtBoxWLStartUpDelay.Text = My.App.WLStartUpDelay.ToString
        Me.TxtBoxWLMaxLinksPerFolder.Text = My.App.WLMaxLinksPerFolder.ToString
        Me.ChkBoxWLAutoRefresh.Checked = My.App.WLAutoRefresh
        Me.TxtBoxWLAutoRefreshInterval.Text = My.App.WLAutoRefreshInterval.ToString
        Me.TxtBoxWLAutoRefreshIdleInterval.Text = My.App.WLAutoRefreshIdleInterval.ToString
        Me.LVWL.Columns.Add("Path", 331) '354 = Full ListView Width
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
                item.Text &= " (AutoRefresh Enabled)"
                'If Not String.IsNullOrEmpty(item.ToolTipText) Then item.ToolTipText &= Environment.NewLine & Environment.NewLine
                'item.ToolTipText &= "AutoRefresh Enabled"
            End If
            If Not link.ShowInMenu And Not link.ShowInTray Then
                item.ForeColor = SystemColors.GrayText
                item.Text &= " (InActive)"
                'If Not String.IsNullOrEmpty(item.ToolTipText) Then item.ToolTipText &= Environment.NewLine & Environment.NewLine
                'item.ToolTipText &= "WinLink InActive on both Menu & Tray"
            End If
            Me.LVWL.Items.Add(item)
        Next
        App.AutoFitLVColumn(LVWL)
    End Sub
    Private Sub ShowSettingsHC()
        Me.CoBoxHCLeft.Items.Clear()
        Me.CoBoxHCDouble.Items.Clear()
        Me.CoBoxHCMiddle.Items.Clear()
        Me.CoBoxHCRight.Items.Clear()

        For Each action As My.App.HCActionType In My.App.HCActions
            If Not action.Name = My.App.HCAction.Menu Then Me.CoBoxHCLeft.Items.Add(action.Description)
            If Not action.Name = My.App.HCAction.Menu Then Me.CoBoxHCDouble.Items.Add(action.Description)
            If Not action.Name = My.App.HCAction.Menu Then Me.CoBoxHCMiddle.Items.Add(action.Description)
            Me.CoBoxHCRight.Items.Add(action.Description)
        Next
        Me.RadBtnHCWST.Checked = True
        HCShowActions(My.App.TrayTools.WorkSpaceTools)

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
            Me.BtnACMute.Image = My.Resources.Resources.imageACMute
            Me.TipInfoEX.SetText(Me.BtnACMute, "Sound All Chimes")
        Else
            Me.BtnACMute.Image = My.Resources.Resources.imageACSound
            Me.TipInfoEX.SetText(Me.BtnACMute, "Mute All Chimes")
        End If
    End Sub
    Friend Sub ACUpdateCancel(visible As Boolean)
        If visible Then
            Me.BtnACAlarmCancel.Visible = True
        Else
            Me.BtnACAlarmCancel.Visible = False
        End If
    End Sub
    Private Sub SetWL()
        If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then
            Me.PanelWL.Enabled = True
        Else
            Me.PanelWL.Enabled = False
        End If
    End Sub
    Friend Sub WLShowAutoRefreshState()
        Me.LblWLAutoRefresh.Visible = App.FrmMain.WLShowAutoRefresh
    End Sub
    Friend Sub WLSetSettingsState(state As Boolean)
        Me.LVWL.Enabled = state
        If App.FrmMain.WLStartUp Then : Me.BtnWLRefresh.Enabled = False
        Else : Me.BtnWLRefresh.Enabled = True
        End If
        If state Then
            Me.BtnRestoreSettings.Enabled = True
            Me.BtnWLRefresh.Text = "Full Refresh"
            Me.TipInfoEX.SetText(Me.BtnWLRefresh, "Refresh ALL Data & Menus")
            Me.BtnWLRefresh.Image = My.Resources.Resources.imageSwap
            Me.BtnWLRefresh.Font = New Font(Me.BtnWLRefresh.Font, FontStyle.Regular)
        Else
            Me.BtnRestoreSettings.Enabled = False
            Me.BtnWLRefresh.Text = "CANCEL"
            Me.TipInfoEX.SetText(Me.BtnWLRefresh, "Cancel File Search")
            Me.BtnWLRefresh.Image = My.Resources.Resources.imageClose
            Me.BtnWLRefresh.Font = New Font(Me.BtnWLRefresh.Font, FontStyle.Bold)
        End If
    End Sub
    Friend Sub WLSetManualRefresh()
        ShowSettingsWL()
        If App.WLData.Count > 0 Then
            Me.BtnWLRefresh.Font = New Font(Me.BtnWLRefresh.Font, FontStyle.Bold)
            Me.BtnWLRefresh.Enabled = True
        Else
            Me.BtnWLRefresh.Enabled = False
            Me.BtnWLRefresh.Font = New Font(Me.BtnWLRefresh.Font, FontStyle.Regular)
        End If
    End Sub
    Friend Sub WLSetNew()
        If Me.LVWL.SelectedIndices.Count = 0 Then : App.FrmMain.WLInsertIndex = -1
        Else : App.FrmMain.WLInsertIndex = Me.LVWL.SelectedIndices(0)
        End If
        Me.LVWL.SelectedIndices.Clear()
        ShowSettingsWL()
        Me.PanelWLItem.Show()
        Me.ChkBoxWLShowInMenu.Checked = True
        Me.ChkBoxWLShowInTray.Checked = True
        Me.ChkBoxWLShowNoMenu.Checked = False
        Me.ChkBoxWLShowMenuIcons.Checked = True
        Me.LblWLRoot.ResetFont()
        Me.LblWLRoot.Text = "Root Folder"
        Me.TxtBoxWLRoot.Select()
    End Sub
    Friend Sub WLEdit(index As Integer)
        Me.LVWL.SelectedIndices.Clear()
        Me.LVWL.Items(index).Selected = True
        Me.TxtBoxWLRoot.Select()
    End Sub
    Private Sub HCShowActions(tool As App.TrayTools)
        Me.CoBoxHCRight.Enabled = True
        Select Case tool
            Case App.TrayTools.WorkSpaceTools
                Me.CoBoxHCLeft.SelectedIndex = Me.CoBoxHCLeft.FindStringExact(My.App.HCActions(My.App.HCWSTLeft).Description)
                Me.CoBoxHCDouble.SelectedIndex = Me.CoBoxHCDouble.FindStringExact(My.App.HCActions(My.App.HCWSTDouble).Description)
                Me.CoBoxHCMiddle.SelectedIndex = Me.CoBoxHCMiddle.FindStringExact(My.App.HCActions(My.App.HCWSTMiddle).Description)
                Me.CoBoxHCRight.SelectedIndex = Me.CoBoxHCRight.FindStringExact(My.App.HCActions(My.App.HCWSTRight).Description)
            Case App.TrayTools.WinLinks
                Me.CoBoxHCLeft.SelectedIndex = Me.CoBoxHCLeft.FindStringExact(My.App.HCActions(My.App.HCWLLeft).Description)
                Me.CoBoxHCDouble.SelectedIndex = Me.CoBoxHCDouble.FindStringExact(My.App.HCActions(My.App.HCWLDouble).Description)
                Me.CoBoxHCMiddle.SelectedIndex = Me.CoBoxHCMiddle.FindStringExact(My.App.HCActions(My.App.HCWLMiddle).Description)
                Me.CoBoxHCRight.SelectedIndex = Me.CoBoxHCRight.FindStringExact(My.App.HCActions(My.App.HCWLRight).Description)
                Me.CoBoxHCRight.Enabled = False
            Case App.TrayTools.ScreenSaver
                Me.CoBoxHCLeft.SelectedIndex = Me.CoBoxHCLeft.FindStringExact(My.App.HCActions(My.App.HCWSTScreenSaverLeft).Description)
                Me.CoBoxHCDouble.SelectedIndex = Me.CoBoxHCDouble.FindStringExact(My.App.HCActions(My.App.HCWSTScreenSaverDouble).Description)
                Me.CoBoxHCMiddle.SelectedIndex = Me.CoBoxHCMiddle.FindStringExact(My.App.HCActions(My.App.HCWSTScreenSaverMiddle).Description)
                Me.CoBoxHCRight.SelectedIndex = Me.CoBoxHCRight.FindStringExact(My.App.HCActions(My.App.HCWSTScreenSaverRight).Description)
        End Select
    End Sub
    Private Function HCFindActionIndex(description As String) As Integer
        For index As Integer = 0 To App.HCActions.Count - 1
            If App.HCActions(index).Description = description Then Return index
        Next
        Return 0
    End Function

    Private Sub CheckMove(ByRef location As Point)
        Dim screen As Rectangle = System.Windows.Forms.Screen.FromControl(Me).WorkingArea
        If location.X + Width > screen.Right Then location.X = screen.Right - Width + App.AdjustScreenBoundsNormalWindow
        If location.Y + Height > screen.Bottom Then location.Y = screen.Bottom - Height + App.AdjustScreenBoundsNormalWindow
        If location.X < screen.Left Then location.X = screen.Left - App.AdjustScreenBoundsNormalWindow
        If location.Y < screen.Top Then location.Y = screen.Top
    End Sub

End Class
