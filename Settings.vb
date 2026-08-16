
Imports System.ComponentModel
Imports System.IO
Imports Skye.UI
Imports SkyeTools.My

Partial Friend Class Settings

    ' DECLARATIONS
    Private mMove As Boolean = False
    Private mOffset, mPosition As Point
    Private nonNumberEntered As Boolean
    Private suppressPageSelection As Boolean = False
    Private OFDLoadOnOSStartup As New OpenFileDialog

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
        LVPageSelector.Items.Add(New ListViewItem("App", 0))
        LVPageSelector.Items.Add(New ListViewItem("Workspace Tools", 1))
        LVPageSelector.Items.Add(New ListViewItem("Screen Saver", 2))
        LVPageSelector.Items.Add(New ListViewItem("Alarm & Chime", 3))
        LVPageSelector.Items.Add(New ListViewItem("WinLinks", 4))
        LVPageSelector.Items.Add(New ListViewItem("HotClicks", 5))
        LVPageSelector.Items.Add(New ListViewItem("HotKeys", 6))
        LVPageSelector.Items(0).Selected = True
        OFDLoadOnOSStartup.DefaultExt = "exe"
        OFDLoadOnOSStartup.Filter = "Executable Files|*.exe|Batch Files|*.bat"
        OFDLoadOnOSStartup.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        OFDLoadOnOSStartup.Title = "Select An Application..."
        For Each thm As Skye.UI.SkyeTheme In Skye.UI.SkyeThemes.AllThemes
            CoBoxTheme.Items.Add(thm.Name)
        Next
        For Each s As String In [Enum].GetNames(Of WSTSSStartUpMode)()
            Me.CoBoxSSStartUp.Items.Add(s)
        Next

    End Sub
    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ShowSettings()
        ShowSave()
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
    End Sub
    Private Sub Settings_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, PanelApp.MouseDown, PanelWST.MouseDown, PanelSS.MouseDown, PanelActions.MouseDown
        If e.Button = MouseButtons.Left AndAlso WindowState = FormWindowState.Normal Then
            mMove = True
            Dim ctrl As Control = DirectCast(sender, Control)
            If TypeOf ctrl Is Panel Then
                mOffset = New Point(-e.X - 4 - ctrl.Left - SystemInformation.FrameBorderSize.Width, -e.Y - 4 - ctrl.Top - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight)
            Else
                mOffset = New Point(-e.X - SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight)
            End If
        End If
    End Sub
    Private Sub Settings_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, PanelApp.MouseMove, PanelWST.MouseMove, PanelSS.MouseMove, PanelActions.MouseMove
        If mMove Then
            mPosition = MousePosition
            mPosition.Offset(mOffset.X, mOffset.Y)
            CheckMove(mPosition)
            Location = mPosition
        End If
    End Sub
    Private Sub Settings_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, PanelApp.MouseUp, PanelWST.MouseUp, PanelSS.MouseUp, PanelActions.MouseUp
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
        Dim selectedSource As String = item.Text

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
        SetPage(LVPageSelector.SelectedItems(0).Text)
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
    Public Shared Sub HandleEnterKey(sender As Object, e As KeyEventArgs) Handles TxtBoxLoadOnOSStartupArgs.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' 1. Silence the system ding
            e.SuppressKeyPress = True

            ' 2. Trigger validation on the form/control
            Dim tb As TextBox = TryCast(sender, TextBox)
            tb?.FindForm()?.ValidateChildren()
        End If
    End Sub

    ' App
    Private Sub ChkBoxThemeAuto_Click(sender As Object, e As EventArgs) Handles ChkBoxThemeAuto.Click
        App.ThemeAuto = ChkBoxThemeAuto.Checked
        SetThemesList()
        Dim selectedTheme As Skye.UI.SkyeTheme = If(App.ThemeAuto, Skye.UI.ThemeManager.DetectWindowsTheme(), App.Theme)
        Skye.UI.ThemeManager.SetTheme(selectedTheme)
        App.SetSave()
    End Sub
    Private Sub CoBxTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoBoxTheme.SelectedIndexChanged
        Dim selectedName As String = CoBoxTheme.SelectedItem.ToString()
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
                SetWLSettingsTab()
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
                App.FrmMain.WSTSSEnabled = Not App.FrmMain.WSTSSEnabled
            Case MouseButtons.Right
                App.SSActivate()
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
    Private Sub CoBoxSSStartUp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoBoxSSStartUp.SelectedIndexChanged
        WSTSSStartUp = CType(CoBoxSSStartUp.SelectedIndex, WSTSSStartUpMode)
        App.SetSave()
    End Sub

    ' Alarm & Chime
    ' WinLinks
    ' HotClicks
    ' HotKeys

    ' METHODS
    Private Sub SetPage(page As String)
        Select Case page
            Case "App"
                PanelApp.BringToFront()
            Case "Workspace Tools"
                PanelWST.BringToFront()
            Case "Screen Saver"
                PanelSS.BringToFront()
            Case "Alarm & Chime"
                PanelAC.BringToFront()
            Case "WinLinks"
                PanelWL.BringToFront()
            Case "HotClicks"
                PanelHC.BringToFront()
            Case "HotKeys"
                PanelHK.BringToFront()
        End Select
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
                Me.BtnSSEnabled.Image = My.Resources.Resources.ImageWSTSS16
                Me.TipInfoEX.SetText(Me.BtnSSEnabled, "Screen Saver ENABLED")
            Else
                Me.BtnSSEnabled.Image = My.Resources.Resources.ImageWSTSSDisabled16
                Me.TipInfoEX.SetText(Me.BtnSSEnabled, "Screen Saver DISABLED")
            End If
            Me.TipInfoEX.SetText(Me.BtnSSEnabled, Me.TipInfoEX.GetText(Me.BtnSSEnabled) + vbCr + "RightClick = Activate")
        End If
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
    Friend Sub ShowSettingsSS()
        If App.WSTShowSSIcon Then : Me.ChkBoxSSShowIcon.Checked = True
        Else : Me.ChkBoxSSShowIcon.Checked = False
        End If
        If App.WSTShowSSActivate Then : Me.ChkBoxSSShowActivate.Checked = True
        Else : Me.ChkBoxSSShowActivate.Checked = False
        End If
        If App.WSTShowSSEnabled Then : Me.ChkBoxSSShowEnabled.Checked = True
        Else : Me.ChkBoxSSShowEnabled.Checked = False
        End If
        If App.WSTSSEnableOnActivate Then : Me.ChkBoxSSEnableOnActivate.Checked = True
        Else : Me.ChkBoxSSEnableOnActivate.Checked = False
        End If
        Me.CoBoxSSStartUp.SelectedIndex = App.WSTSSStartUp
    End Sub
    Private Sub ShowSettingsAC()
    End Sub
    Private Sub ShowSettingsWL()
    End Sub
    Private Sub ShowSettingsHC()
    End Sub
    Private Sub ShowSettingsHK()
    End Sub
    Friend Sub RestoreSettings()
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
    Friend Sub SetAC()
        Me.PanelAC.Enabled = My.App.WSTShowAC
        ShowSettingsAC()
        FrmMain.ACSet()
    End Sub
    Private Sub SetWLSettingsTab()
        If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then : Me.PanelWL.Enabled = True
        Else : Me.PanelWL.Enabled = False
        End If
    End Sub
    Private Sub CheckMove(ByRef location As Point)
        Dim screen As Rectangle = System.Windows.Forms.Screen.FromControl(Me).WorkingArea
        If location.X + Width > screen.Right Then location.X = screen.Right - Width + App.AdjustScreenBoundsNormalWindow
        If location.Y + Height > screen.Bottom Then location.Y = screen.Bottom - Height + App.AdjustScreenBoundsNormalWindow
        If location.X < screen.Left Then location.X = screen.Left - App.AdjustScreenBoundsNormalWindow
        If location.Y < screen.Top Then location.Y = screen.Top
    End Sub

End Class
