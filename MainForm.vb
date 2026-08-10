
Imports System.Data.Common
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports SkyeTools.My

Partial Friend Class MainForm

#Region "MAIN"

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
	Private mMove As Boolean = False
	Private mOffset, mPosition As Point
	Private nonNumberEntered As Boolean
	Private ErrorWarning As Boolean = False
	Private ProcessList As Collections.Generic.List(Of ProcessListType)
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
							HideForm
#End If
					Case Else : MyBase.WndProc(m)
				End Select
			Case Skye.WinAPI.WM_HOTKEY
				HKPerformAction(m.WParam.ToInt32)
				MyBase.WndProc(m)
			Case Else : MyBase.WndProc(m)
		End Select
	End Sub
	Friend Sub New()

		'Initialize Locals
		InitializeComponent()
		TimerAC.Interval = 1000
		BackgroundworkerWL.WorkerSupportsCancellation = True
		BackgroundworkerAC.WorkerSupportsCancellation = True
		openfiledialogLoadOnOSStartup.DefaultExt = "exe"
		openfiledialogLoadOnOSStartup.Filter = "Executable Files|*.exe|Batch Files|*.bat"
		openfiledialogLoadOnOSStartup.InitialDirectory = "C:\Program Files"
		openfiledialogLoadOnOSStartup.Title = "Select An Application..."
		openfiledialogWST.DefaultExt = "exe"
		openfiledialogWST.Filter = "Executable Files|*.exe|Batch Files|*.bat"
		openfiledialogWST.InitialDirectory = "C:\Program Files"
		openfiledialogWST.Title = "Select An Application..."
		uiACOpenFile.DefaultExt = "wav"
		uiACOpenFile.Filter = "WAV Files|*.wav"
		uiACOpenFile.InitialDirectory = "C:\WINDOWS\Media"
		uiACOpenFile.Title = "Select a WAV File..."
		uiWLFolderBrowser.Description = "Select a Folder with ShortCuts or Programs..."
		uiWLFileBrowser.Title = "Select The YMFM App..."
		uiWLFileBrowser.DefaultExt = "exe"
		uiWLFileBrowser.Filter = "Executable Files|*.exe"
		uiWLFileBrowser.InitialDirectory = "C:\PROGRAM FILES"
		uiWLFolderBrowser.ShowNewFolderButton = False
		cmWLItem.Font = App.MenuFont
		cmWLItem.ShowItemToolTips = False
		Me.imagelisttabcontrolSettings = New ImageList(Me.components) With {
			.ColorDepth = ColorDepth.Depth32Bit,
			.ImageSize = New Size(16, 16),
			.TransparentColor = System.Drawing.Color.Transparent}
		Me.imagelisttabcontrolSettings.Images.Add("imageAC", My.Resources.Resources.imageAC)
		Me.imagelisttabcontrolSettings.Images.Add("imageHC", My.Resources.Resources.imageHC)
		Me.imagelisttabcontrolSettings.Images.Add("imageHK", My.Resources.Resources.imageHK)
		Me.imagelisttabcontrolSettings.Images.Add("imageWL", My.Resources.Resources.imageWL)
		Me.imagelisttabcontrolSettings.Images.Add("imageWST", My.Resources.Resources.imageWST)
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

		'Initialize Globals
		Dim ums As System.IO.UnmanagedMemoryStream = My.Resources.Resources.soundChime
		Dim audioBytes(CInt(ums.Length) - 1) As Byte
		ums.Read(audioBytes, 0, audioBytes.Length)
		My.App.ACChime = audioBytes
		audioBytes = Nothing
		ums.Dispose()

		'Initialize Form
		Me.Text = "Settings For " + My.Application.Info.ProductName + " v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
		Me.cmiWSTCloseAll.ToolTipText = My.App.CloseAllToolTipText
		Me.cmiScreenSaverCloseAll.ToolTipText = My.App.CloseAllToolTipText
		Me.notifyiconWST = New NotifyIcon(Me.components) With {
			.Tag = "notifyiconWST",
			.ContextMenuStrip = cmWST}
		Me.notifyiconWSTScreenSaver = New NotifyIcon(Me.components) With {
			.Tag = "notifyiconWSTScreenSaver",
			.ContextMenuStrip = cmWSTScreenSaver}
		Me.cmiWSTScreenSaverActivate.Image = My.Resources.Resources.iconWSTScreenSaverEnabled.ToBitmap 'DirectCast(My.App.AppResources.GetObject("iconWSTScreenSaverEnabled"), Icon).ToBitmap
		Me.cmiScreenSaverActivate.Image = My.Resources.Resources.iconWSTScreenSaverEnabled.ToBitmap 'DirectCast(My.App.AppResources.GetObject("iconWSTScreenSaverEnabled"), Icon).ToBitmap
#Disable Warning CA2263
		For Each s As String In [Enum].GetNames(GetType(My.App.WSTSSStartUpMode))
			Me.comboboxWSTSSStartUp.Items.Add(s)
		Next
#Enable Warning CA2263
		Me.TipInfoEX.SetText(Me.btnACAlarmCancel, "THE ALARM HAS SOUNDED")
		For Each thm As Skye.UI.SkyeTheme In Skye.UI.SkyeThemes.AllThemes
			CoBoxTheme.Items.Add(thm.Name)
		Next
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
		If sender Is Me.btnSettingsRestore Then My.App.WriteToLog(My.App.Tools.SkyeTools, "Settings Restored...") 'This must be here because it is called by btnRestoreSettings.
		WSTClockSet()
		UpdateACMute()
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
		cmlistviewWL.Renderer = New Skye.UI.SkyeMenuRenderer
	End Sub
	Private Sub FrmShown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
		Me.Hide()
		Me.Opacity = 1
		If Not My.Application.AlternateStart AndAlso ((My.App.WSTShowWLMenu Or My.App.WSTShowWLTray) And My.App.WLStartUpDelay > 0) Then WLStartUp = True
		If Not My.Application.AlternateStart AndAlso (My.App.WSTShowWLMenu And Not My.App.WSTShowWLTray) Then ShowWL()
		ShowTools()

		If Not My.Application.AlternateStart AndAlso ((My.App.WSTShowWLMenu Or My.App.WSTShowWLTray) And My.App.WLStartUpDelay > 0) Then
			TimerWLStartUp.Interval = My.App.WLStartUpDelay * 1000
			TimerWLStartUp.Start()
		End If
		If Not My.Application.AlternateStart AndAlso ((My.App.WSTShowWLMenu Or My.App.WSTShowWLTray) And My.App.WLStartUpDelay > 0) AndAlso sender IsNot Me.btnSettingsRestore Then
			Me.cmiWSTCancelStartUp.Visible = True
			Me.cmseparatorWSTCancel.Visible = True
		End If
		UpdateWST()
#If DEBUG Then
		Me.Left = 0
		Me.Top = CInt(My.Computer.Screen.Bounds.Height / 2 - Me.Height / 2)
		Me.btnErrorTest.Show()
		Me.btnClockTest.Show()
		Me.checkboxLoadOnOSStartup.Enabled = False
		Me.lblLoadOnOSStartupPath.Enabled = False
		Me.txbxLoadOnOSStartupArgs.Enabled = False
		Me.btnLoadOnOSStartupPath.Enabled = False
		Me.Show()
#Else
#End If
	End Sub
	Private Sub FrmVisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.VisibleChanged
		UpdateWST()
	End Sub
	Private Sub FrmClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
		My.App.AppIsClosing = True
		FrmClosingTasks()
		My.App.Finalize()
	End Sub
	Private Sub FrmClosingTasks()
		HKRegister(True)
		WLClose(True)
	End Sub
	Private Sub FrmMouseDown(sender As Object, e As MouseEventArgs) Handles tabpageWST.MouseDown, tabpageWL.MouseDown, tabpageHK.MouseDown, tabpageHC.MouseDown, tabpageAC.MouseDown, MyBase.MouseDown
		If e.Button = MouseButtons.Left AndAlso WindowState = FormWindowState.Normal Then
			mMove = True
			Dim ctrl As Control = DirectCast(sender, Control)
			If TypeOf ctrl Is TabPage Then
				mOffset = New Point(-e.X - 4 - tabcontrolSettings.Left - ctrl.Left - SystemInformation.FrameBorderSize.Width, -e.Y - 4 - tabcontrolSettings.Top - ctrl.Top - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight)
			Else
				mOffset = New Point(-e.X - 4 - SystemInformation.FrameBorderSize.Width, -e.Y - 4 - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight)
			End If
		End If
	End Sub
	Private Sub FrmMouseMove(sender As Object, e As MouseEventArgs) Handles tabpageWST.MouseMove, tabpageWL.MouseMove, tabpageHK.MouseMove, tabpageHC.MouseMove, tabpageAC.MouseMove, MyBase.MouseMove
		If mMove Then
			mPosition = MousePosition
			mPosition.Offset(mOffset.X, mOffset.Y)
			CheckMove(mPosition)
			Location = mPosition
		End If
	End Sub
	Private Sub FrmMouseUp(sender As Object, e As MouseEventArgs) Handles tabpageWST.MouseUp, tabpageWL.MouseUp, tabpageHK.MouseUp, tabpageHC.MouseUp, tabpageAC.MouseUp, MyBase.MouseUp
		mMove = False
	End Sub
	Private Sub FrmMove(sender As Object, e As EventArgs) Handles MyBase.Move
		If Not mMove AndAlso WindowState = FormWindowState.Normal Then CheckMove(Me.Location)
	End Sub

	' Control Events
	Private Sub CMICloseAllMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTCloseAll.MouseUp, cmiScreenSaverCloseAll.MouseUp
		Me.Close()
		'If e.Button = MouseButtons.Right Then Application.Restart 'This function restarts the app with the same commandline parameters originally passed to it.
		If e.Button = MouseButtons.Right Then
			Select Case My.Computer.Keyboard.CtrlKeyDown
				Case True : System.Windows.Forms.Application.Restart()
				Case False : Diagnostics.Process.Start(My.Computer.FileSystem.CombinePath(My.Application.Info.DirectoryPath, My.Application.Info.AssemblyName + ".exe"))
			End Select

		End If
	End Sub
	Private Sub BtnEnter(ByVal sender As Object, ByVal e As EventArgs) Handles btnWSTScreenSaverEnabled.Enter, btnWLRefresh.Enter, btnSettingsSave.Enter, btnSettingsRestore.Enter, btnLog.Enter, btnLoadOnOSStartupPath.Enter, btnInfo.Enter, btnErrorTest.Enter, btnClockTest.Enter, btnACTopHourChimePlay.Enter, btnACTopHourChimeManual.Enter, btnACTopHourChimeDefault.Enter, btnACOffHourChimePlay.Enter, btnACOffHourChimeManual.Enter, btnACOffHourChimeDefault.Enter, btnACMute.Enter, btnACAlarmSet.Enter, btnACAlarmChimePlay.Enter, btnACAlarmChimeManual.Enter, btnACAlarmChimeDefault.Enter, btnACAlarmCancel.Enter
		btnClose.Focus()
	End Sub
	Private Sub BtnInfoMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTHelp.MouseUp, btnInfo.MouseUp
		If sender Is Me.cmiWSTHelp Or (sender Is Me.btnInfo AndAlso (e.X >= 0 And e.X <= Me.btnInfo.Width And e.Y >= 0 And e.Y <= Me.btnInfo.Height)) Then
			Select Case e.Button
				Case MouseButtons.Left : My.App.ShowHelp(False)
				Case MouseButtons.Right : My.App.ShowHelp(True)
			End Select
		End If
	End Sub
	Private Sub BtnLogMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTLog.MouseUp, btnLog.MouseUp
		If sender Is Me.cmiWSTLog Or (sender Is Me.btnLog AndAlso (e.X >= 0 And e.X <= Me.btnLog.Width And e.Y >= 0 And e.Y <= Me.btnLog.Height)) Then
			Select Case e.Button
				Case MouseButtons.Left : My.App.ShowLog(False)
				Case MouseButtons.Right : My.App.ShowLog(True)
			End Select
		End If
		ErrorWarning = False
		UpdateWST()
	End Sub
	Private Sub BtnCloseClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
		HideForm()
	End Sub
	Private Sub BtnErrorTestMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnErrorTest.MouseUp
		If e.X >= 0 And e.X <= btnErrorTest.Width And e.Y >= 0 And e.Y <= btnErrorTest.Height Then
			Select Case e.Button
				Case MouseButtons.Left
					ErrorNotification()
					App.ShowMessage(My.App.Tools.SkyeTools, "ERROR!", "Test Error - DO NOT PANIC!!", SystemIcons.Error, True)
				Case MouseButtons.Right
					Throw New Exception("Test Exception - DO NOT PANIC!!")
			End Select
		End If
	End Sub
	Private Sub BtnClockTestMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnClockTest.MouseUp
		If e.X >= 0 And e.X <= Me.btnClockTest.Width And e.Y >= 0 And e.Y <= Me.btnClockTest.Height Then
			Select Case e.Button
				Case MouseButtons.Left : WSTShowClock()
				Case MouseButtons.Right
			End Select
		End If
	End Sub

	' Methods
	Friend Sub ErrorNotification()
		ErrorWarning = True
		UpdateWST()
	End Sub
	Friend Function InUseApp() As Boolean
		If Me.cmWST.Visible Or Me.cmWSTScreenSaver.Visible Then Return True
		If InUseWL() Then Return True
		If InUseSettings() Then Return True
		Return False
	End Function
	Private Sub ShowTools()
		If Not (My.App.WSTEnabled Or My.App.WSTShowSSIcon Or My.App.WSTShowWLTray) Then : Me.Close() 'No Tools Running(That Have A Tray Icon), So Close Application
		Else 'Any One or More Tools Running(That Have A Tray Icon)
			If My.App.WSTEnabled Then
				UpdateWST()
				ShowWST()
				Me.notifyiconWST.Visible = True
			Else : Me.notifyiconWST.Visible = False
			End If
			If My.App.WSTSSToolEnabled Then
				Select Case My.App.WSTSSStartUp
					Case My.App.WSTSSStartUpMode.Enabled : WSTSSEnabled = True
					Case My.App.WSTSSStartUpMode.Disabled : WSTSSEnabled = False
				End Select
				WSTSSSet()

				If My.App.WSTShowSSIcon Then : Me.notifyiconWSTScreenSaver.Visible = True
				Else : Me.notifyiconWSTScreenSaver.Visible = False
				End If
			Else : If Me.notifyiconWSTScreenSaver.Visible Then Me.notifyiconWSTScreenSaver.Visible = False
			End If

			WLSetSettingsTab()

			If Not My.Application.AlternateStart AndAlso My.App.WSTShowWLTray Then : If WLTrayIcons.Count = 0 Then ShowWL()
			Else : If WLTrayIcons.Count > 0 Then WLClose()
			End If
		End If
	End Sub
	Private Sub ProcessListGenerate()
		ProcessList = New Collections.Generic.List(Of ProcessListType)
		Dim plist As Diagnostics.Process() = Diagnostics.Process.GetProcesses
		For Each p As Diagnostics.Process In plist
			'Debug.Print(p.MainWindowTitle)
			Try
				Dim cpl As New ProcessListType With {
					.ProcessName = p.ProcessName}
				Dim match As Boolean = False
				For Each cplmatch As ProcessListType In ProcessList
					If cpl.ProcessName = cplmatch.ProcessName Then
						match = True
						Exit For
					End If
				Next
				If Not match Then
					'Debug.Print(p.MainModule.FileName)
					cpl.FileName = p.MainModule.FileName.TrimStart(New Char() {CChar("\"), CChar("?"), CChar("?"), CChar("\")}) 'This string,"\??\", gets inserted sometimes for some unknown reason.
					cpl.Icon = Skye.WinAPI.GetApplicationIcon(cpl.FileName)
					If cpl.Icon.Equals(Nothing) Then cpl.Icon = My.Resources.Resources.iconProcess 'DirectCast(My.App.AppResources.GetObject("iconProcess"), Icon)
					ProcessList.Add(cpl)
				End If
			Catch
			End Try
		Next
		ProcessList.Sort(New ProcessListComparer)
	End Sub
	Private Function IconToHighQualityImage(ic As Icon) As Image
		Dim bmp As Bitmap = ic.ToBitmap()
		Return CType(bmp.Clone(), Image)
	End Function
	Private Sub HideForm()
		Me.Hide()
		If Me.listviewWL.SelectedIndices.Count > 0 Then ShowSettings(My.App.Tools.WinLinks)
	End Sub
	Private Sub CheckMove(ByRef location As Point)
		Dim screen As Rectangle = System.Windows.Forms.Screen.FromControl(Me).WorkingArea
		If location.X + Me.Width > screen.Right Then location.X = screen.Right - Me.Width + App.AdjustScreenBoundsNormalWindow
		If location.Y + Me.Height > screen.Bottom Then location.Y = screen.Bottom - Me.Height + App.AdjustScreenBoundsNormalWindow
		If location.X < screen.Left Then location.X = screen.Left - App.AdjustScreenBoundsNormalWindow
		If location.Y < screen.Top Then location.Y = screen.Top
	End Sub
	Private Function InUseWL() As Boolean
		If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then
			If Me.cmWLItem.Visible Then Return True
			For Each cmi As ToolStripMenuItem In WLMenus : If cmi.DropDown.Visible Then Return True
			Next
			For Each trayicon As NotifyIcon In WLTrayIcons : If trayicon.ContextMenuStrip.Visible Then Return True
			Next
		End If
		Return False
	End Function
	Private Function InUseSettings() As Boolean '
		If Me.Visible Then Return True
		Return False
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

#End Region
#Region "Settings"

	' Declarations
	Private imagelisttabcontrolSettings As ImageList
	Private openfiledialogLoadOnOSStartup As New OpenFileDialog

	' Control Events
	Private Sub TabcontrolSettingsSelected(ByVal sender As Object, ByVal e As TabControlEventArgs) Handles tabcontrolSettings.Selected
		If Me.tabcontrolSettings.SelectedTab Is Me.tabpageHK Then ShowSettings(My.App.Tools.HotKeys)
	End Sub
	Private Sub BtnSettingsSaveClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnSettingsSave.Click
		My.App.SaveSettings()
		HideForm()
	End Sub
	Private Sub BtnSettingsRestoreClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnSettingsRestore.Click
		FrmClosingTasks()
		ACMute = False
		My.App.GetSettings()
		FrmLoad(btnSettingsRestore, New EventArgs)
		FrmShown(btnSettingsRestore, New EventArgs)
	End Sub
	Private Sub TextboxShortcutKeysPreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
		If e.KeyData = Keys.A + Keys.Control Then CType(sender, TextBox).SelectAll()
	End Sub
	Private Sub TextboxNumbersOnlyKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textboxWLStartUpDelay.KeyDown, textboxWLMaxLinksPerFolder.KeyDown, textboxWLAutoRefreshInterval.KeyDown, textboxWLAutoRefreshIdleInterval.KeyDown
		nonNumberEntered = False
		If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
			If e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Enter Then : nonNumberEntered = True
			ElseIf e.KeyCode = Keys.Enter Then : Validate()
			End If
		End If
	End Sub
	Private Sub TextboxNumbersOnlyKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles textboxWLStartUpDelay.KeyPress, textboxWLMaxLinksPerFolder.KeyPress, textboxWLAutoRefreshInterval.KeyPress, textboxWLAutoRefreshIdleInterval.KeyPress, textboxACAlarmTimer.KeyPress, textboxACAlarmTime.KeyPress
		If nonNumberEntered Then e.Handled = True
	End Sub
	Private Sub TxbxKeyDown(sender As Object, e As KeyEventArgs) Handles txbxLoadOnOSStartupArgs.KeyDown
		If e.KeyCode = Keys.Enter Then Validate()
	End Sub

	' Methods
	Private Overloads Sub ShowSettings()
		UpdateWST()
		Me.SuspendLayout()
		ShowSettingsHC()
		ShowSettingsHK()
		ShowSettingsWST()
		ShowSettingsSS()
		ShowSettingsAC()
		ShowSettingsWL()
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
				Case My.App.Tools.WorkSpaceTools : ShowSettingsWST()
				Case My.App.Tools.ScreenSaver : ShowSettingsSS()
				Case My.App.Tools.AlarmChime : ShowSettingsAC()
				Case My.App.Tools.WinLinks : ShowSettingsWL()
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
	Private Sub ShowSettingsWST()
		If My.App.WSTLoadOnOSStartup Then
			Me.checkboxLoadOnOSStartup.Checked = True
			Me.btnLoadOnOSStartupPath.Enabled = True
			Me.lblLoadOnOSStartupPath.Enabled = True
			Me.txbxLoadOnOSStartupArgs.Enabled = True
			Me.TipInfoEX.SetText(Me.lblLoadOnOSStartupPath, My.App.WSTLoadOnOSStartupPath.Path + Chr(13) + "DoubleClick To Copy Full Path")
			Me.TipInfoEX.SetText(Me.txbxLoadOnOSStartupArgs, IIf(String.IsNullOrEmpty(My.App.WSTLoadOnOSStartupPath.Arguments), "Arguments", My.App.WSTLoadOnOSStartupPath.Arguments + Chr(13) + "DoubleClick To Copy Arguments").ToString)
		Else
			Me.checkboxLoadOnOSStartup.Checked = False
			Me.btnLoadOnOSStartupPath.Enabled = False
			Me.lblLoadOnOSStartupPath.Enabled = False
			Me.txbxLoadOnOSStartupArgs.Enabled = False
			Me.TipInfoEX.SetText(Me.lblLoadOnOSStartupPath, Nothing)
			Me.TipInfoEX.SetText(Me.txbxLoadOnOSStartupArgs, Nothing)
		End If
		If String.IsNullOrEmpty(My.App.WSTLoadOnOSStartupPath.Path) Then : Me.lblLoadOnOSStartupPath.Text = String.Empty
		Else : Me.lblLoadOnOSStartupPath.Text = IIf(My.App.WSTLoadOnOSStartupPath.Path.Contains("\"c), "...\", Nothing).ToString + My.App.WSTLoadOnOSStartupPath.Path.Split(CChar("\")).GetValue(My.App.WSTLoadOnOSStartupPath.Path.Split(CChar("\")).Length - 1).ToString
		End If
		If String.IsNullOrEmpty(My.App.WSTLoadOnOSStartupPath.Arguments) Then : Me.txbxLoadOnOSStartupArgs.Text = String.Empty
		Else : Me.txbxLoadOnOSStartupArgs.Text = My.App.WSTLoadOnOSStartupPath.Arguments
		End If
		If My.App.WSTEnabled Then : Me.checkboxWSTEnabled.Checked = True
		Else : Me.checkboxWSTEnabled.Checked = False
		End If
		If My.App.WSTShowWLMenu Then : Me.checkboxWSTShowWLMenu.Checked = True
		Else : Me.checkboxWSTShowWLMenu.Checked = False
		End If
		If My.App.WSTShowWLTray Then : Me.checkboxWSTShowWLTray.Checked = True
		Else : Me.checkboxWSTShowWLTray.Checked = False
		End If
		If My.App.WSTShowAC Then : Me.checkboxWSTShowAC.Checked = True
		Else : Me.checkboxWSTShowAC.Checked = False
		End If
		If My.App.WSTShowClock Then : Me.checkboxWSTShowClock.Checked = True
		Else : Me.checkboxWSTShowClock.Checked = False
		End If
		If My.App.WSTShowLockWorkSpace Then : Me.checkboxWSTShowLockWorkSpace.Checked = True
		Else : Me.checkboxWSTShowLockWorkSpace.Checked = False
		End If
		If My.App.WSTShowLogOff Then : Me.checkboxWSTShowLogOff.Checked = True
		Else : Me.checkboxWSTShowLogOff.Checked = False
		End If
		If My.App.WSTShowSleep Then : Me.checkboxWSTShowSleep.Checked = True
		Else : Me.checkboxWSTShowSleep.Checked = False
		End If
		If My.App.WSTShowHibernate Then : Me.checkboxWSTShowHibernate.Checked = True
		Else : Me.checkboxWSTShowHibernate.Checked = False
		End If
		If My.App.WSTShowReStart Then : Me.checkboxWSTShowReStart.Checked = True
		Else : Me.checkboxWSTShowReStart.Checked = False
		End If
		If My.App.WSTShowShutDown Then : Me.checkboxWSTShowShutDown.Checked = True
		Else : Me.checkboxWSTShowShutDown.Checked = False
		End If
		If My.App.WSTShowHelp Then : Me.checkboxWSTShowHelp.Checked = True
		Else : Me.checkboxWSTShowHelp.Checked = False
		End If
		If My.App.WSTShowLog Then : Me.checkboxWSTShowLog.Checked = True
		Else : Me.checkboxWSTShowLog.Checked = False
		End If
		CoBoxTheme.SelectedItem = App.Theme.Name
		ChkBoxThemeAuto.Checked = App.ThemeAuto
		SetThemesList()
	End Sub
	Private Sub ShowSettingsSS()
		If My.App.WSTSSToolEnabled Then
			Me.checkboxWSTSSToolEnabled.Checked = True
			Me.groupboxWSTSS.Enabled = True
		Else
			Me.checkboxWSTSSToolEnabled.Checked = False
			Me.groupboxWSTSS.Enabled = False
		End If
		Me.comboboxWSTSSStartUp.SelectedIndex = My.App.WSTSSStartUp
		If My.App.WSTSSEnableOnActivate Then : Me.checkboxWSTScreenSaverEnableOnActivate.Checked = True
		Else : Me.checkboxWSTScreenSaverEnableOnActivate.Checked = False
		End If
		If My.App.WSTShowSSIcon Then : Me.checkboxWSTShowScreenSaverIcon.Checked = True
		Else : Me.checkboxWSTShowScreenSaverIcon.Checked = False
		End If
		If My.App.WSTShowSSActivate Then : Me.checkboxWSTShowScreenSaverActivate.Checked = True
		Else : Me.checkboxWSTShowScreenSaverActivate.Checked = False
		End If
		If My.App.WSTShowSSEnabled Then : Me.checkboxWSTShowScreenSaverEnabled.Checked = True
		Else : Me.checkboxWSTShowScreenSaverEnabled.Checked = False
		End If
	End Sub
	Private Sub ShowSettingsAC()
		If ACAlarmActive Then
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
		Me.panelWL.Hide()
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
			Dim item As New ListViewItem
			If link.Root.Length > 60 Then
				item.Text = "...\" + split(split.Length - 1)
				item.ToolTipText = link.Root
			Else : item.Text = link.Root
			End If
			If index = My.App.WLData.Count - 1 And My.App.WLAutoRefresh And (link.ShowInMenu Or link.ShowInTray) Then
				item.Font = New Font(item.Font, FontStyle.Bold)
				If Not String.IsNullOrEmpty(item.ToolTipText) Then item.ToolTipText += Chr(13) + Chr(13)
				item.ToolTipText += "AutoRefresh Enabled"
			End If
			If Not link.ShowInMenu And Not link.ShowInTray Then
				item.ForeColor = SystemColors.GrayText
				If Not String.IsNullOrEmpty(item.ToolTipText) Then item.ToolTipText += Chr(13) + Chr(13)
				item.ToolTipText += "WinLink InActive on both Menu & Tray"
			End If
			Me.listviewWL.Items.Add(item)
		Next
	End Sub
	Private Sub SelectTab(ByRef tabpage As System.Windows.Forms.TabPage, Optional forcevisible As Boolean = False)
		If tabpage Is Nothing Then
			If Me.Visible Then
				If Me.WindowState = FormWindowState.Minimized Then : Me.WindowState = FormWindowState.Normal
				Else : If Not forcevisible Then HideForm()
				End If
			Else : Me.Show()
			End If
		Else
			If Me.Visible Then
				If Me.tabcontrolSettings.SelectedTab.Equals(tabpage) AndAlso Me.WindowState = FormWindowState.Normal AndAlso Not forcevisible Then : HideForm()
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
					Me.listviewWL.SelectedIndices.Clear()
					WLSetNew()
					Me.SelectTab(Me.tabpageWL, True)
				End If
			Case My.App.HCAction.WLEdit
				If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then
					Me.SelectTab(Me.tabpageWL, True)
					If argument Is Nothing Then argument = 0
					Me.listviewWL.SelectedIndices.Clear()
					Me.listviewWL.SelectedIndices.Add(CInt(argument))
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
			Case My.App.HCAction.WSTLockWorkSpace : WSTLockWorkSpace(True)
			Case My.App.HCAction.WSTScreenSaverActivate : WSTSSActivate()
			Case My.App.HCAction.WSTScreenSaverDisable
				WSTSSEnabled = Not WSTSSEnabled
				WSTSSSet()
			Case My.App.HCAction.WSTClock : WSTShowClock()
			Case My.App.HCAction.ShowSettings : SelectTab(Nothing)
			Case My.App.HCAction.ShowSettingsWST : SelectTab(Me.tabpageWST)
			Case My.App.HCAction.ShowSettingsWL : SelectTab(Me.tabpageWL)
			Case My.App.HCAction.ShowSettingsWSTSS : SelectTab(Me.tabpageWST)
			Case My.App.HCAction.ShowSettingsAC : ACActivateTimer()
			Case My.App.HCAction.ShowSettingsHC : SelectTab(Me.tabpageHC)
			Case My.App.HCAction.ShowSettingsHK : SelectTab(Me.tabpageHK)
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
			Case My.App.HKWSTScreenSaver.WinID : WSTSSActivate(True)
			Case My.App.HKWSTClock.WinID : WSTShowClock()
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

#Region "WorkSpace Tools (WST)"

	' Declarations
	Private notifyiconWST As NotifyIcon
	Private notifyiconWSTScreenSaver As NotifyIcon
	Private frmWSTClock As WSTClock
	Private openfiledialogWST As New OpenFileDialog

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
		If e.Button = MouseButtons.Left Then WSTShowClock()
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
	Private Sub CheckboxWSTEnabledClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWSTEnabled.Click
		My.App.WSTEnabled = Not My.App.WSTEnabled
		ShowTools()
	End Sub
	Private Sub CheckboxWSTShowClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWSTShowWLMenu.Click, checkboxWSTShowSleep.Click, checkboxWSTShowShutDown.Click, checkboxWSTShowScreenSaverEnabled.Click, checkboxWSTShowScreenSaverActivate.Click, checkboxWSTShowReStart.Click, checkboxWSTShowLogOff.Click, checkboxWSTShowLog.Click, checkboxWSTShowLockWorkSpace.Click, checkboxWSTShowHibernate.Click, checkboxWSTShowHelp.Click, checkboxWSTShowClock.Click, checkboxWSTShowAC.Click
		Select Case CType(sender, CheckBox).Name
			Case checkboxWSTShowWLMenu.Name
				WSTShowWLMenu = Not WSTShowWLMenu
				WLSetSettingsTab()

				If WSTShowWLMenu Then
					For index = 0 To WLData.Count - 1
						If WLData(index).ShowInMenu Then
							Dim link = WLData(index)
							link.RefreshMenu = True
							WLData(index) = link
						End If
					Next
					ShowWL()
				Else : WLClose()
				End If
			Case checkboxWSTShowScreenSaverActivate.Name : WSTShowSSActivate = Not WSTShowSSActivate
			Case checkboxWSTShowScreenSaverEnabled.Name : WSTShowSSEnabled = Not WSTShowSSEnabled
			Case checkboxWSTShowClock.Name
				App.WSTShowClock = Not App.WSTShowClock
				WSTClockSet()
			Case checkboxWSTShowAC.Name
				WSTShowAC = Not WSTShowAC
				ACSet()
			Case checkboxWSTShowLockWorkSpace.Name : WSTShowLockWorkSpace = Not WSTShowLockWorkSpace
			Case checkboxWSTShowLogOff.Name : WSTShowLogOff = Not WSTShowLogOff
			Case checkboxWSTShowSleep.Name : WSTShowSleep = Not WSTShowSleep
			Case checkboxWSTShowHibernate.Name : WSTShowHibernate = Not WSTShowHibernate
			Case checkboxWSTShowReStart.Name : WSTShowReStart = Not WSTShowReStart
			Case checkboxWSTShowShutDown.Name : WSTShowShutDown = Not WSTShowShutDown
			Case checkboxWSTShowHelp.Name : WSTShowHelp = Not WSTShowHelp
			Case checkboxWSTShowLog.Name : WSTShowLog = Not WSTShowLog
		End Select
		ShowWST()
	End Sub
	Private Sub CheckboxWSTShowIconClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWSTSSToolEnabled.Click, checkboxWSTShowWLTray.Click, checkboxWSTShowScreenSaverIcon.Click
		Select Case CType(sender, CheckBox).Name
			Case checkboxWSTShowWLTray.Name
				WSTShowWLTray = Not WSTShowWLTray
				For index = 0 To WLData.Count - 1
					If WLData(index).ShowInTray Then
						Dim link = WLData(index)
						link.RefreshMenu = True
						WLData(index) = link
					End If
				Next
			Case checkboxWSTShowScreenSaverIcon.Name : WSTShowSSIcon = Not WSTShowSSIcon
			Case checkboxWSTSSToolEnabled.Name
				If WSTSSToolEnabled AndAlso Not WSTSSEnabled Then
					WSTSSEnabled = True
					WSTSSSet()
				End If
				WSTSSToolEnabled = Not WSTSSToolEnabled
				ShowSettingsSS()
		End Select
		ShowTools()
	End Sub
	Private Sub BtnLoadOnOSStartupPathClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadOnOSStartupPath.Click
		If Not String.IsNullOrEmpty(My.App.WSTLoadOnOSStartupPath.Path) Then Me.openfiledialogLoadOnOSStartup.InitialDirectory = My.App.WSTLoadOnOSStartupPath.Path
		Dim r As DialogResult = Me.openfiledialogLoadOnOSStartup.ShowDialog(Me)
		If r = System.Windows.Forms.DialogResult.OK And Not Me.openfiledialogLoadOnOSStartup.FileName = "" Then : My.App.WSTLoadOnOSStartupPath.Path = Me.openfiledialogLoadOnOSStartup.FileName
		ElseIf Not r = System.Windows.Forms.DialogResult.Cancel Then : My.App.WSTLoadOnOSStartupPath = Nothing
		End If
		If Not r = System.Windows.Forms.DialogResult.Cancel Then
			ShowSettings(My.App.Tools.WorkSpaceTools)
			My.App.SetLoadOnOSStartup()
			'DebugLog.ShowMessage(My.SkyeTools.Tools.SkyeTools, "btnLoadOnOSStartupPathClick", My.SkyeTools.LoadOnOSStartupPath)
		End If
	End Sub
	Private Sub CheckboxLoadOnOSStartupClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxLoadOnOSStartup.Click
		My.App.WSTLoadOnOSStartup = Not My.App.WSTLoadOnOSStartup
		My.App.SetLoadOnOSStartup()
		ShowSettings(My.App.Tools.WorkSpaceTools)
	End Sub
	Private Sub TxbxLoadOnOSStartupArgsValidated(sender As Object, e As EventArgs) Handles txbxLoadOnOSStartupArgs.Validated
		If String.IsNullOrEmpty(Me.txbxLoadOnOSStartupArgs.Text) Then : My.App.WSTLoadOnOSStartupPath.Arguments = String.Empty
		Else : My.App.WSTLoadOnOSStartupPath.Arguments = Me.txbxLoadOnOSStartupArgs.Text
		End If
		My.App.SetLoadOnOSStartup()
		ShowSettingsWST()
		Me.txbxLoadOnOSStartupArgs.SelectAll()
	End Sub
	Private Sub TxbxWSTCopyDoubleClick(sender As Object, e As EventArgs) Handles txbxLoadOnOSStartupArgs.DoubleClick, lblLoadOnOSStartupPath.DoubleClick
		If sender Is lblLoadOnOSStartupPath Then : If Not String.IsNullOrEmpty(WSTLoadOnOSStartupPath.Path) Then Computer.Clipboard.SetText(WSTLoadOnOSStartupPath.Path)
		ElseIf sender Is txbxLoadOnOSStartupArgs Then : If Not String.IsNullOrEmpty(WSTLoadOnOSStartupPath.Arguments) Then Computer.Clipboard.SetText(WSTLoadOnOSStartupPath.Arguments)
		End If
	End Sub
	Private Sub CoBxTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoBoxTheme.SelectedIndexChanged
		Dim selectedName As String = CoBoxTheme.SelectedItem.ToString()
		Dim selected As Skye.UI.SkyeTheme = Skye.UI.SkyeThemes.GetTheme(selectedName)
		App.Theme = selected
		If Not App.ThemeAuto Then
			Skye.UI.ThemeManager.SetTheme(selected)
			ShowSettings()
		End If
	End Sub
	Private Sub ChkBoxThemeAuto_Click(sender As Object, e As EventArgs) Handles ChkBoxThemeAuto.Click
		App.ThemeAuto = ChkBoxThemeAuto.Checked
		SetThemesList()
		Dim selectedTheme As Skye.UI.SkyeTheme = If(App.ThemeAuto, Skye.UI.ThemeManager.DetectWindowsTheme(), App.Theme)
		Skye.UI.ThemeManager.SetTheme(selectedTheme)
	End Sub

	' Methods
	Friend Sub WSTShowClock()
		If My.App.WSTShowClock Then
			If frmWSTClock?.Visible Then
				frmWSTClock.Hide()
			Else
				SizeClock()
				frmWSTClock.Show()
			End If
			UpdateWST()
		End If
	End Sub
	Friend Sub SizeClock()
		Select Case App.WSTClockSize
			Case ClockSize.Small
				frmWSTClock.lblClock.Font = New Font(frmWSTClock.lblClock.Font.FontFamily, 18, FontStyle.Bold)
				frmWSTClock.Size = New Size(110, 28)
			Case ClockSize.Medium
				frmWSTClock.lblClock.Font = New Font(frmWSTClock.lblClock.Font.FontFamily, 24, FontStyle.Bold)
				frmWSTClock.Size = New Size(146, 40)
				frmWSTClock.CheckMove()
			Case ClockSize.Large
				frmWSTClock.lblClock.Font = New Font(frmWSTClock.lblClock.Font.FontFamily, 40, FontStyle.Bold)
				frmWSTClock.Size = New Size(244, 67)
				frmWSTClock.CheckMove()
		End Select
	End Sub
	Friend Sub UpdateWST()
		'Settings Window
		Me.TipInfoEX.SetText(Me.btnLog, "Log" + Chr(13) + "RightClick = Show Maximized")
		If ErrorWarning Then Me.TipInfoEX.SetText(Me.btnLog, Me.TipInfoEX.GetText(Me.btnLog) + Chr(13) + "An Application Error Has Occured. View Log For Details.")
		'WorkSpace Tools
		If My.App.WSTEnabled Then
			Me.notifyiconWST.Icon = My.Resources.Resources.iconWST 'CType(My.App.AppResources.GetObject("iconWST"), Icon)
			Me.notifyiconWST.Text = My.App.WSTName
			Me.cmiWSTLog.ToolTipText = "RightClick = Show Maximized"
			Me.cmiWSTLog.ResetFont()
			Me.cmiWSTLog.ResetForeColor()
			If ErrorWarning Then
				Me.notifyiconWST.Text += Chr(13) + "** ERROR **"
				Me.notifyiconWST.Icon = My.Resources.Resources.iconWSTAlert 'CType(My.App.AppResources.GetObject("iconWSTAlert"), Icon)
				Me.cmiWSTLog.Font = App.MenuFontBold
				Me.cmiWSTLog.ForeColor = Color.Firebrick
				Me.cmiWSTLog.ToolTipText += Chr(13) + "An Application Error Has Occured. View Log For Details."
			End If
			If My.App.WSTSSToolEnabled Then
				If WSTSSEnabled Then : If My.App.WSTShowSSEnabled Then Me.notifyiconWST.Text += Chr(13) + "Screen Saver ENABLED"
				Else : If My.App.WSTShowSSEnabled Then Me.notifyiconWST.Text += Chr(13) + "Screen Saver DISABLED"
				End If
			End If
			If ACAlarmTripped And ACChimeCount = Byte.MaxValue Then
				Me.notifyiconWST.Text += Chr(13) + "** ALARM **"
				Me.notifyiconWST.Icon = My.Resources.Resources.iconWSTAlert 'CType(My.App.AppResources.GetObject("iconWSTAlert"), Icon)
				Me.cmiWSTAC.ToolTipText = Me.TipInfoEX.GetText(Me.btnACAlarmCancel) '"THE ALARM HAS SOUNDED"
				Me.cmiWSTAC.Checked = True
				Me.cmiWSTAC.Font = App.MenuFontBold
			ElseIf ACAlarmActive Then
				Dim alarmText As String = My.App.ACAlarmTime.ToString()
				Dim prefix As String = String.Concat(Me.notifyiconWST.Text, ChrW(13), "Alarm Set for ")
				Me.notifyiconWST.Text = String.Concat(prefix, alarmText.AsSpan(0, alarmText.Length - 3))
				Me.cmiWSTAC.ToolTipText = String.Concat("Alarm Set for ", alarmText.AsSpan(0, alarmText.Length - 3))
				Me.cmiWSTAC.Checked = True
				Me.cmiWSTAC.Font = App.MenuFont
			Else
				Me.cmiWSTAC.ToolTipText = Nothing
				Me.cmiWSTAC.Checked = False
				Me.cmiWSTAC.Font = App.MenuFont
			End If
			If Me.frmWSTClock?.Visible Then : Me.cmiWSTClock.Checked = True
			Else : Me.cmiWSTClock.Checked = False
			End If
		End If
	End Sub
	Private Sub UpdateWSTCancelState()
		If Not WLStartUp Then Me.cmiWSTCancelStartUp.Visible = False
		If Not WLStartUp And Not BackgroundworkerAC.IsBusy Then Me.cmseparatorWSTCancel.Visible = False
		If Not BackgroundworkerAC.IsBusy Then Me.cmiWSTACAlarmCancel.Visible = False
		UpdateWST()
	End Sub
	Private Sub ShowWST()
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
	Private Sub WSTClockSet()
		frmWSTClock?.Close()
		frmWSTClock?.Dispose()
		frmWSTClock = Nothing
		UpdateWST()
		If My.App.WSTShowClock Then frmWSTClock = New WSTClock
	End Sub
	Private Sub WSTLockWorkSpace(Optional hcmode As Boolean = False)
		If My.App.WSTShowLockWorkSpace Then
			If hcmode AndAlso My.App.WSTSSEnableOnActivate Then
				WSTSSEnabled = True
				WSTSSSet()
			End If
			Skye.WinAPI.LockWorkStation()
		End If
	End Sub
	Private Sub SetThemesList()
		If App.ThemeAuto Then
			CoBoxTheme.Enabled = False
		Else
			CoBoxTheme.Enabled = True
		End If
	End Sub

#End Region
#Region "ScreenSaver (SS)"

	'Declarations
	Private WSTSSEnabled As Boolean

	'Control Events
	Private Sub CMIWSTScreenSaverActivateMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTScreenSaverActivate.MouseUp, cmiScreenSaverActivate.MouseUp
		If e.Button = MouseButtons.Left Then WSTSSActivate()
	End Sub
	Private Sub CMIWSTScreenSaverEnabledMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTScreenSaverEnabled.MouseUp, cmiScreenSaverEnabled.MouseUp
		If e.Button = MouseButtons.Left Then
			WSTSSEnabled = Not WSTSSEnabled
			WSTSSSet()
		End If
	End Sub
	Private Sub CMIScreenSaverCloseMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiScreenSaverClose.MouseUp
		If e.Button = MouseButtons.Left Then
			My.App.WSTShowSSIcon = False
			ShowTools()
			ShowSettingsSS()
		End If
	End Sub
	Private Sub BtnWSTScreenSaverEnabledMouseUp(sender As Object, e As MouseEventArgs) Handles btnWSTScreenSaverEnabled.MouseUp
		If My.App.MouseInBounds(CType(sender, Control), New Point(e.X, e.Y)) Then
			Select Case e.Button
				Case MouseButtons.Left
					WSTSSEnabled = Not WSTSSEnabled
					WSTSSSet()
				Case MouseButtons.Right : WSTSSActivate()
			End Select
		End If
	End Sub
	Private Sub CheckboxWSTScreenSaverEnableOnActivateClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWSTScreenSaverEnableOnActivate.Click
		My.App.WSTSSEnableOnActivate = Not My.App.WSTSSEnableOnActivate
	End Sub
	Private Sub ComboboxWSTSSStartUpSelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxWSTSSStartUp.SelectedIndexChanged
		My.App.WSTSSStartUp = CType(Me.comboboxWSTSSStartUp.SelectedIndex, My.App.WSTSSStartUpMode)
	End Sub

	'Procedures
	Private Sub WSTSSSet()
		Debug.Print("WSTSSSet: SS Enabled = " + WSTSSEnabled.ToString)
		If My.App.WSTSSToolEnabled Then
			If WSTSSEnabled Then
				Skye.WinAPI.SetThreadExecutionState(Skye.WinAPI.EXECUTION_STATE.ES_CONTINUOUS)
				Me.cmiWSTScreenSaverEnabled.Image = My.Resources.Resources.iconWSTScreenSaverEnabled.ToBitmap '(My.App.AppResources.GetObject("iconWSTScreenSaverEnabled"), Icon).ToBitmap
				Me.cmiWSTScreenSaverEnabled.ForeColor = Color.Teal
				Me.cmiWSTScreenSaverEnabled.Text = "Screen Saver ENABLED"
				Me.notifyiconWSTScreenSaver.Icon = My.Resources.Resources.iconWSTScreenSaverEnabled 'CType(My.App.AppResources.GetObject("iconWSTScreenSaverEnabled"), Icon)
				Me.notifyiconWSTScreenSaver.Text = "Screen Saver ENABLED"
				Me.cmiScreenSaverEnabled.Image = My.Resources.Resources.iconWSTScreenSaverEnabled.ToBitmap 'CType(My.App.AppResources.GetObject("iconWSTScreenSaverEnabled"), Icon).ToBitmap
				Me.cmiScreenSaverEnabled.ForeColor = Color.Teal
				Me.cmiScreenSaverEnabled.Text = "Screen Saver ENABLED"
				Me.btnWSTScreenSaverEnabled.Image = My.Resources.Resources.iconWSTScreenSaverEnabled.ToBitmap 'CType(My.App.AppResources.GetObject("iconWSTScreenSaverEnabled"), Icon).ToBitmap
				Me.btnWSTScreenSaverEnabled.Checked = True
				Me.TipInfoEX.SetText(Me.btnWSTScreenSaverEnabled, "Screen Saver ENABLED")
			Else
				Skye.WinAPI.SetThreadExecutionState(Skye.WinAPI.EXECUTION_STATE.ES_DISPLAY_REQUIRED Or Skye.WinAPI.EXECUTION_STATE.ES_CONTINUOUS)
				Me.cmiWSTScreenSaverEnabled.Image = My.Resources.Resources.iconWSTScreenSaverDisabled.ToBitmap 'CType(My.App.AppResources.GetObject("iconWSTScreenSaverDisabled"), Icon).ToBitmap
				Me.cmiWSTScreenSaverEnabled.ForeColor = Color.Maroon
				Me.cmiWSTScreenSaverEnabled.Text = "Screen Saver DISABLED"
				Me.notifyiconWSTScreenSaver.Icon = My.Resources.Resources.iconWSTScreenSaverDisabled 'CType(My.App.AppResources.GetObject("iconWSTScreenSaverDisabled"), Icon)
				Me.notifyiconWSTScreenSaver.Text = "Screen Saver DISABLED"
				Me.cmiScreenSaverEnabled.Image = My.Resources.Resources.iconWSTScreenSaverDisabled.ToBitmap 'CType(My.App.AppResources.GetObject("iconWSTScreenSaverDisabled"), Icon).ToBitmap
				Me.cmiScreenSaverEnabled.ForeColor = Color.Maroon
				Me.cmiScreenSaverEnabled.Text = "Screen Saver DISABLED"
				Me.btnWSTScreenSaverEnabled.Image = My.Resources.Resources.iconWSTScreenSaverDisabled.ToBitmap 'CType(My.App.AppResources.GetObject("iconWSTScreenSaverDisabled"), Icon).ToBitmap
				Me.btnWSTScreenSaverEnabled.Checked = False
				Me.TipInfoEX.SetText(Me.btnWSTScreenSaverEnabled, "Screen Saver DISABLED")
			End If
			Me.TipInfoEX.SetText(Me.btnWSTScreenSaverEnabled, Me.TipInfoEX.GetText(Me.btnWSTScreenSaverEnabled) + vbCr + "RightClick = Activate")
			UpdateWST()
		End If
	End Sub
	Private Sub WSTSSActivate(Optional hotkeymode As Boolean = False)
		If My.App.WSTSSToolEnabled And (My.App.WSTShowSSActivate Or My.App.WSTShowSSEnabled Or My.App.WSTShowSSIcon) Then
			Dim SSActive As Boolean
			Skye.WinAPI.SystemParametersInfo(Skye.WinAPI.SPI_GETSCREENSAVERRUNNING, 0, SSActive, 0)
			If Not SSActive Then
				If My.App.WSTSSEnableOnActivate And Not hotkeymode Then
					WSTSSEnabled = True
					WSTSSSet()
				End If
				'				My.WinAPI.SendMessage(CType(My.WinAPI.HWND_BROADCAST, IntPtr), CUInt(My.WinAPI.WM_SYSCOMMAND), CType(My.WinAPI.SC_SCREENSAVE, IntPtr), CType(0, IntPtr))
				Skye.WinAPI.PostMessage(CType(Skye.WinAPI.HWND_BROADCAST, IntPtr), CUInt(Skye.WinAPI.WM_SYSCOMMAND), CType(Skye.WinAPI.SC_SCREENSAVE, IntPtr), CType(0, IntPtr))
			End If
		End If
	End Sub

#End Region
#Region "Alarm & Chime (AC)"

	'Declarations
	Private WithEvents TimerAC As New Timer
	Private WithEvents BackgroundworkerAC As New System.ComponentModel.BackgroundWorker
	Private uiACOpenFile As New OpenFileDialog
	Private ACAlarmActive As Boolean
	Private ACAlarmTripped As Boolean = False
	Private ACMute As Boolean = False
	Private ACChimePath As String
	Private ACChimeCount As Byte
	Private ACLastMinute As Integer = My.Computer.Clock.LocalTime.Minute

	'Control Events
	Private Sub CMIWSTACMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTAC.MouseUp
		If e.Button = MouseButtons.Left Then
			If ACAlarmTripped And ACChimeCount = Byte.MaxValue Then : ACAlarmCancel()
			Else
				SelectTab(Me.tabpageAC)
				Me.textboxACAlarmTime.Focus()
				Me.textboxACAlarmTime.SelectAll()
			End If
		End If
	End Sub
	Private Sub CMIWSTACAlarmCancelMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTACAlarmCancel.MouseUp
		If e.Button = MouseButtons.Left Then ACAlarmCancel()
	End Sub
	Private Sub BtnACAlarmSetClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACAlarmSet.Click
		ACAlarmActive = Not ACAlarmActive
		ACSetTimer()
		ShowSettings(My.App.Tools.AlarmChime)
	End Sub
	Private Sub BtnACAlarmCancelClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACAlarmCancel.Click
		ACAlarmCancel()
	End Sub
	Private Sub BtnACChimeDefaultClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACTopHourChimeDefault.Click, btnACOffHourChimeDefault.Click, btnACAlarmChimeDefault.Click
		If sender Is Me.btnACAlarmChimeDefault Then : My.App.ACAlarmChimePath = ""
		ElseIf sender Is Me.btnACTopHourChimeDefault Then : My.App.ACTopHourChimePath = ""
		ElseIf sender Is Me.btnACOffHourChimeDefault Then : My.App.ACOffHourChimePath = ""
		End If
		ShowSettings()
	End Sub
	Private Sub BtnACChimeManualClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACTopHourChimeManual.Click, btnACOffHourChimeManual.Click, btnACAlarmChimeManual.Click
		Dim r As DialogResult = Me.uiACOpenFile.ShowDialog(Me)
		If r = System.Windows.Forms.DialogResult.OK And Not Me.uiACOpenFile.FileName = "" Then
			If sender Is Me.btnACAlarmChimeManual Then : My.App.ACAlarmChimePath = Me.uiACOpenFile.FileName
			ElseIf sender Is Me.btnACTopHourChimeManual Then : My.App.ACTopHourChimePath = Me.uiACOpenFile.FileName
			ElseIf sender Is Me.btnACOffHourChimeManual Then : My.App.ACOffHourChimePath = Me.uiACOpenFile.FileName
			End If
		ElseIf Not r = System.Windows.Forms.DialogResult.Cancel Then

			If sender Is Me.btnACAlarmChimeManual Then : My.App.ACAlarmChimePath = ""
			ElseIf sender Is Me.btnACTopHourChimeManual Then : My.App.ACTopHourChimePath = ""
			ElseIf sender Is Me.btnACOffHourChimeManual Then : My.App.ACOffHourChimePath = ""
			End If
		End If
		ShowSettings()
	End Sub
	Private Sub BtnACChimePlayClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACTopHourChimePlay.Click, btnACOffHourChimePlay.Click, btnACAlarmChimePlay.Click
		Dim counter As Byte = 0
		Dim chime As String = ""
		Dim chimecount As Byte = 0
		If sender Is Me.btnACAlarmChimePlay Then
			Me.lblACAlarmChime.ForeColor = Color.Maroon
			Me.lblACAlarmChime.Font = New Font(Me.Font, Drawing.FontStyle.Bold)
			Me.lblACAlarmChime.Refresh()
			chime = My.App.ACAlarmChimePath
			Select Case My.App.ACAlarmChimeType
				Case My.App.ACChimeType.Simple : chimecount = 1
				Case Else : chimecount = 4
			End Select
		ElseIf sender Is Me.btnACTopHourChimePlay Then
			Me.lblACTopHourChime.ForeColor = Color.Maroon
			Me.lblACTopHourChime.Font = New Font(Me.Font, Drawing.FontStyle.Bold)
			Me.lblACTopHourChime.Refresh()
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
			Me.lblACOffHourChime.ForeColor = Color.Maroon
			Me.lblACOffHourChime.Font = New Font(Me.Font, Drawing.FontStyle.Bold)
			Me.lblACOffHourChime.Refresh()
			chime = My.App.ACOffHourChimePath
			chimecount = 1
		End If
		If chimecount > 0 And Not ACMute Then
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
		Me.lblACAlarmChime.ResetForeColor()
		Me.lblACAlarmChime.ResetFont()
		Me.lblACAlarmChime.Refresh()
		Me.lblACTopHourChime.ResetForeColor()
		Me.lblACTopHourChime.ResetFont()
		Me.lblACTopHourChime.Refresh()
		Me.lblACOffHourChime.ResetForeColor()
		Me.lblACOffHourChime.ResetFont()
		Me.lblACOffHourChime.Refresh()
		Me.btnClose.Select()
	End Sub
	Private Sub BtnACMuteClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnACMute.Click
		ACMute = Not ACMute
		If Me.BackgroundworkerAC.IsBusy Then Me.BackgroundworkerAC.CancelAsync()
		UpdateACMute()
	End Sub
	Private Sub CheckboxACAlarmRecurringClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxACAlarmRecurring.Click
		My.App.ACAlarmRecurring = Not My.App.ACAlarmRecurring
		If My.App.ACAlarmRecurring And Not ACAlarmActive Then
			ACAlarmActive = True
			ACSetTimer()
			ShowSettings()
		End If
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
	End Sub
	Private Sub RadiobtnACChimeTypeClick(ByVal sender As Object, ByVal e As EventArgs) Handles radiobtnACTopHourChimeSimple.Click, radiobtnACTopHourChimeHourTick.Click, radiobtnACTopHourChimeExtended.Click, radiobtnACAlarmChimeSimple.Click, radiobtnACAlarmChimeForever.Click, radiobtnACAlarmChimeExtended.Click
		If sender Is Me.radiobtnACAlarmChimeSimple Then : My.App.ACAlarmChimeType = My.App.ACChimeType.Simple
		ElseIf sender Is Me.radiobtnACAlarmChimeExtended Then : My.App.ACAlarmChimeType = My.App.ACChimeType.Extended
		ElseIf sender Is Me.radiobtnACAlarmChimeForever Then : My.App.ACAlarmChimeType = My.App.ACChimeType.Forever
		ElseIf sender Is Me.radiobtnACTopHourChimeSimple Then : My.App.ACTopHourChimeType = My.App.ACChimeType.Simple
		ElseIf sender Is Me.radiobtnACTopHourChimeExtended Then : My.App.ACTopHourChimeType = My.App.ACChimeType.Extended
		ElseIf sender Is Me.radiobtnACTopHourChimeHourTick Then : My.App.ACTopHourChimeType = My.App.ACChimeType.HourTick
		End If
	End Sub
	Private Sub TextboxACAlarmTimeKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textboxACAlarmTime.KeyDown
		nonNumberEntered = False
		If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
			If e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Enter And Not (e.Shift And e.KeyCode = Keys.OemSemicolon And sender Is Me.textboxACAlarmTime) Then : nonNumberEntered = True
			ElseIf e.KeyCode = Keys.Enter Then
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
					ACAlarmActive = True
					ACSetTimer()
					ShowSettings(My.App.Tools.AlarmChime)
					Me.textboxACAlarmTime.ResetBackColor()
					Me.textboxACAlarmTime.ResetForeColor()
					Me.textboxACAlarmTime.SelectAll()
				Catch
					Me.textboxACAlarmTime.BackColor = Color.Red
					Me.textboxACAlarmTime.ForeColor = Color.Yellow
					Me.textboxACAlarmTime.SelectAll()
				End Try
			End If
		End If
	End Sub
	Private Sub TextboxACTimerKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textboxACAlarmTimer.KeyDown
		nonNumberEntered = False
		If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
			If e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Enter Then : nonNumberEntered = True
			ElseIf e.KeyCode = Keys.Enter Then
				If Int(Val(Me.textboxACAlarmTimer.Text)) < 1 Then Me.textboxACAlarmTimer.Text = "1"
				If Int(Val(Me.textboxACAlarmTimer.Text)) > 720 Then Me.textboxACAlarmTimer.Text = "720"
				My.App.ACAlarmTime = New TimeSpan(My.Computer.Clock.LocalTime.AddMinutes(Int(Val(Me.textboxACAlarmTimer.Text))).Hour, My.Computer.Clock.LocalTime.AddMinutes(Int(Val(Me.textboxACAlarmTimer.Text))).Minute, 0)
				ACAlarmActive = True
				ACSetTimer()
				ShowSettings()
				Me.textboxACAlarmTime.Focus()
				Me.textboxACAlarmTime.SelectAll()
			End If
		End If
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
					UpdateACAlarmCancel(True)
				End If
			End If
			If ACMute Then App.ShowMessage(My.App.Tools.AlarmChime, "** " + If(ACAlarmTripped, "ALARM", "CHIME") + " IS SOUNDING **", Nothing)
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
			UpdateACAlarmCancel(False)
		End If
	End Sub

	'Procedures
	Friend Sub ACAlarmCancel()
		If Me.BackgroundworkerAC.IsBusy Then : Me.BackgroundworkerAC.CancelAsync()
		Else
			ACAlarmTripped = False
			ACSet()
			UpdateACAlarmCancel(False)
		End If
		Me.btnACAlarmCancel.Visible = False
	End Sub
	Private Sub UpdateACAlarmCancel(visible As Boolean)
		If visible Then
			Me.cmiWSTACAlarmCancel.Visible = True
			Me.cmseparatorWSTCancel.Visible = True
			Me.btnACAlarmCancel.Visible = True
		Else
			UpdateWSTCancelState()
			Me.btnACAlarmCancel.Visible = False
		End If
	End Sub
	Private Sub UpdateACMute()
		If ACMute Then
			Me.btnACMute.Image = My.Resources.Resources.imageACMute 'CType(My.App.AppResources.GetObject("imageACMute"), Image)
			Me.TipInfoEX.SetText(Me.btnACMute, "Sound All Chimes")
		Else
			Me.btnACMute.Image = My.Resources.Resources.imageACSound 'CType(My.App.AppResources.GetObject("imageACSound"), Image)
			Me.TipInfoEX.SetText(Me.btnACMute, "Mute All Chimes")
		End If
	End Sub
	Private Sub ACSet()
		Me.tabpageAC.Enabled = My.App.WSTShowAC
		If My.App.WSTShowAC Then : ACAlarmActive = My.App.ACAlarmRecurring
		Else : ACAlarmActive = False
		End If
		ShowSettings(My.App.Tools.AlarmChime)
		ACSetTimer()
	End Sub
	Private Sub ACSetTimer()
		If (ACAlarmActive Or My.App.ACTopHourChimeEnabled Or My.App.ACTopHourBeforeChimeEnabled Or My.App.ACTopHourAfterChimeEnabled Or My.App.ACThirdQuarterHourChimeEnabled Or My.App.ACFirstQuarterHourChimeEnabled Or My.App.ACBottomHourChimeEnabled) And My.App.WSTShowAC Then : Me.TimerAC.Start()
		Else : Me.TimerAC.Stop()
		End If
	End Sub
	Private Sub ACActivateTimer()
		If My.App.WSTShowAC Then
			SelectTab(Me.tabpageAC, True)
			Me.textboxACAlarmTimer.Focus()
			Me.textboxACAlarmTimer.SelectAll()
		End If
	End Sub

#End Region
#Region "WinLinks(WL)"

	' Declarations
	Private WithEvents TimerWLStartUp As New Timer
	Private WithEvents TimerWLAutoRefresh As New Timer
	Private WithEvents TimerWLAutoRefreshIdle As New Timer
	Private WithEvents WatcherWLAutoRefresh As New IO.FileSystemWatcher
	Private WithEvents BackgroundworkerWL As New System.ComponentModel.BackgroundWorker
	Private Const WLMaxItems As Integer = 2000
	Private Structure WLMenuDataItem
		Dim Text As String
		Dim File As String
		Dim Icon As Image
		Dim IsFolder As Boolean
		Dim SubMenu As Collections.Generic.List(Of WLMenuDataItem)
	End Structure
	Private WLMenuData As New Collections.Generic.List(Of Collections.Generic.List(Of WLMenuDataItem))
	Private WLMenus As New Collections.Generic.List(Of ToolStripMenuItem)
	Private WLTrayIcons As New Collections.Generic.List(Of NotifyIcon)
	Private WLStartUp As Boolean = False
	Private WLAutoRefreshUpdate As Boolean = False
	Private WLLoadStartTime As TimeSpan
	Private WLInsertIndex As Integer
	Private WLMenuItemCount As Integer
	Private cmWLItem As New ContextMenuStrip
	Private uiWLFileBrowser As New OpenFileDialog
	Private uiWLFolderBrowser As New FolderBrowserDialog

	' Control Events
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
			Me.panelWL.Show()
		ElseIf Me.listviewWL.FocusedItem IsNot Nothing Then : ShowSettings(My.App.Tools.WinLinks)
		End If
	End Sub
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
	Private Sub CMIWLMoveMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWLMoveUp.MouseUp, cmiWLMoveDown.MouseUp
		If e.Button = MouseButtons.Left And Me.listviewWL.SelectedIndices.Count > 0 Then
			Debug.Print("cmiWinLinksMoveClick: " + Me.listviewWL.SelectedIndices(0).ToString)
			Dim link As My.App.WLItemType = My.App.WLData(Me.listviewWL.SelectedIndices(0))
			My.App.WLData.RemoveAt(Me.listviewWL.SelectedIndices(0))
			Select Case CType(sender, ToolStripItem).Name
				Case Me.cmiWLMoveUp.Name : My.App.WLData.Insert(Me.listviewWL.SelectedIndices(0) - 1, link)
				Case Me.cmiWLMoveDown.Name : My.App.WLData.Insert(Me.listviewWL.SelectedIndices(0) + 1, link)
			End Select
			WLSetManualRefresh()
		End If
	End Sub
	Private Sub CMIWLNewMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWLNew.MouseUp
		If e.Button = MouseButtons.Left Then WLSetNew()
	End Sub
	Private Sub CMIWLDeleteMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWLDelete.MouseUp
		If e.Button = MouseButtons.Left And Me.listviewWL.SelectedIndices.Count > 0 Then
			WLSetAutoRefresh(True)
			My.App.WLData.RemoveAt(Me.listviewWL.SelectedIndices(0))
			ShowSettings(My.App.Tools.WinLinks)
			WLSetManualRefresh()
		End If
	End Sub
	Private Sub BtnWLRefreshClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnWLRefresh.Click
		If Me.btnWLRefresh.Text = "CANCEL" Then
			Me.btnWLRefresh.Enabled = False
			Me.btnWLRefresh.Text = "PENDING..."
			Me.TipInfoEX.SetText(Me.btnWLRefresh, "Stopping File Search, Please Wait...")
			BackgroundworkerWL.CancelAsync()
		Else
			WLClose(True)
			ShowWL()
		End If
	End Sub
	Private Sub BtnWLSelectFolderClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnWLSelectFolder.Click
		If Not String.IsNullOrEmpty(Me.textboxWLRoot.Text) Then Me.uiWLFolderBrowser.SelectedPath = Me.textboxWLRoot.Text
		Dim r As DialogResult = Me.uiWLFolderBrowser.ShowDialog(Me)
		If r = System.Windows.Forms.DialogResult.OK And Not Me.uiWLFolderBrowser.SelectedPath = "" Then : Me.textboxWLRoot.Text = Me.uiWLFolderBrowser.SelectedPath
		ElseIf Not r = System.Windows.Forms.DialogResult.Cancel Then : Me.textboxWLRoot.Text = ""
		End If
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
				If Not (link.ShowInMenu = My.App.WLData(Me.listviewWL.SelectedIndices(0)).ShowInMenu And link.ShowInTray = My.App.WLData(Me.listviewWL.SelectedIndices(0)).ShowInTray And link.Root = My.App.WLData(Me.listviewWL.SelectedIndices(0)).Root And link.Name = My.App.WLData(Me.listviewWL.SelectedIndices(0)).Name) Then WLClose(True)
				My.App.WLData.RemoveAt(Me.listviewWL.SelectedIndices(0))
				My.App.WLData.Insert(Me.listviewWL.SelectedIndices(0), link)
				If WLMenuData.Count = 0 Then : WLSetManualRefresh()
				Else : ShowWL()
				End If

				'New
			Else
				If Me.comboboxWLSort.SelectedIndex = -1 Then Me.comboboxWLSort.SelectedIndex = 0
				link.Sort = CType(Me.comboboxWLSort.SelectedIndex + 1, SortOrder)
				If Me.comboboxWLFolderMode.SelectedIndex = -1 Then Me.comboboxWLFolderMode.SelectedIndex = 0
				link.FolderMode = CType(Me.comboboxWLFolderMode.SelectedIndex, My.App.WLFolderMode)
				If Me.comboboxWLFolderPlacement.SelectedIndex = -1 Then Me.comboboxWLFolderPlacement.SelectedIndex = 0
				link.FolderPlacement = CType(Me.comboboxWLFolderPlacement.SelectedIndex, My.App.WLFolderPlacement)
				If WLInsertIndex = -1 Then WLInsertIndex = My.App.WLData.Count
				link.UseDefaultIcon = Me.checkboxWLUseDefaultIcon.Checked
				link.ShowInMenu = Me.checkboxWLShowInMenu.Checked
				link.ShowInTray = Me.checkboxWLShowInTray.Checked
				link.ShowNoMenu = Me.checkboxWLShowNoMenu.Checked
				link.ShowMenuIcons = Me.checkboxWLShowMenuIcons.Checked
				My.App.WLData.Insert(WLInsertIndex, link)
				WLSetManualRefresh()
			End If
		End If
	End Sub
	Private Sub BtnWLCancelClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnWLCancel.Click
		ShowSettings(My.App.Tools.WinLinks)
	End Sub
	Private Sub CheckboxWLShowFileInfoToolTipsClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWLShowFileInfoToolTips.Click
		My.App.WLShowFileInfoToolTips = Not My.App.WLShowFileInfoToolTips
	End Sub
	Private Sub CheckboxWLShowFilePathToolTipsClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWLShowFilePathToolTips.Click
		My.App.WLShowFilePathToolTips = Not My.App.WLShowFilePathToolTips
	End Sub
	Private Sub CheckboxWLShowFolderPathToolTipsClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWLShowFolderPathToolTips.Click
		My.App.WLShowFolderPathToolTips = Not My.App.WLShowFolderPathToolTips
	End Sub
	Private Sub CheckboxWLAutoRefreshClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWLAutoRefresh.Click
		My.App.WLAutoRefresh = Not My.App.WLAutoRefresh
		WLSetAutoRefresh()
		ShowSettings(My.App.Tools.WinLinks)
	End Sub
	Private Sub TextboxWLStartUpDelayValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textboxWLStartUpDelay.Validating
		If Int(Val(Me.textboxWLStartUpDelay.Text)) < 5 And Int(Val(Me.textboxWLStartUpDelay.Text)) <> 0 Then Me.textboxWLStartUpDelay.Text = "5"
		If Int(Val(Me.textboxWLStartUpDelay.Text)) > 300 Then Me.textboxWLStartUpDelay.Text = "300"
	End Sub
	Private Sub TextboxWLStartUpDelayValidated(ByVal sender As Object, ByVal e As EventArgs) Handles textboxWLStartUpDelay.Validated
		My.App.WLStartUpDelay = CShort(Val(Me.textboxWLStartUpDelay.Text))
		Me.textboxWLStartUpDelay.SelectAll()
	End Sub
	Private Sub TextboxWLMaxLinksPerFolderValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textboxWLMaxLinksPerFolder.Validating
		If Int(Val(Me.textboxWLMaxLinksPerFolder.Text)) < 1 Then Me.textboxWLMaxLinksPerFolder.Text = "1"
		If Int(Val(Me.textboxWLMaxLinksPerFolder.Text)) > 100 Then Me.textboxWLMaxLinksPerFolder.Text = "100"
	End Sub
	Private Sub TextboxWLMaxLinksPerFolderValidated(ByVal sender As Object, ByVal e As EventArgs) Handles textboxWLMaxLinksPerFolder.Validated
		My.App.WLMaxLinksPerFolder = CByte(Val(Me.textboxWLMaxLinksPerFolder.Text))
		Me.textboxWLMaxLinksPerFolder.SelectAll()
	End Sub
	Private Sub TextboxWLAutoRefreshIntervalValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textboxWLAutoRefreshInterval.Validating
		If Int(Val(Me.textboxWLAutoRefreshInterval.Text)) < 1 Then Me.textboxWLAutoRefreshInterval.Text = "1"
		If Int(Val(Me.textboxWLAutoRefreshInterval.Text)) > 90 Then Me.textboxWLAutoRefreshInterval.Text = "90"
	End Sub
	Private Sub TextboxWLAutoRefreshIntervalValidated(ByVal sender As Object, ByVal e As EventArgs) Handles textboxWLAutoRefreshInterval.Validated
		If Not My.App.WLAutoRefreshInterval = Int(Val(Me.textboxWLAutoRefreshInterval.Text)) Then
			My.App.WLAutoRefreshInterval = CByte(Val(Me.textboxWLAutoRefreshInterval.Text))
			Me.textboxWLAutoRefreshInterval.SelectAll()
			WLSetAutoRefresh()
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
			WLSetAutoRefresh()
		End If
	End Sub

	' Handlers
	Private Sub TimerWLStartUpTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerWLStartUp.Tick
		If Not InUseSettings() And Not InUseWL() Then
			Me.TimerWLStartUp.Stop()
			WLStartUp = False
			UpdateWSTCancelState()
			ShowWL()
		End If
		If Me.TimerWLStartUp.Enabled Then Me.TimerWLStartUp.Interval = My.App.WLStartUpDelay * 1000
	End Sub
	Private Sub TimerWLAutoRefreshTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerWLAutoRefresh.Tick
		If WLAutoRefreshUpdate Then TimerWLAutoRefreshIdle.Start()
	End Sub
	Private Sub TimerWLAutoRefreshIdleTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerWLAutoRefreshIdle.Tick
		If Not InUseSettings() Then ShowWL()
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
					WLMenuData(index) = WLGenerateMenuData(link.Root, link)
					WLMenuData(index).TrimExcess()
					link.RefreshData = False
					My.App.WLData(index) = link
				End If
			Next
		Catch ex As Exception : My.App.WriteToLog(My.App.Tools.WinLinks, "Fatal Error Loading WinLinks!" + Chr(13) + "Location : backgroundworkerWinLinksDoWork" + Chr(13) + "Error : " + ex.ToString)
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
            If e.Cancelled Then Me.btnWLRefresh.Font = New Font(Me.btnWLRefresh.Font, FontStyle.Bold)
            WLLoadStartTime = TimeSpan.Zero
			If Not WLAutoRefreshUpdate Then App.ShowMessage(My.App.Tools.WinLinks, "WinLinks Loaded", Nothing)
			WLAutoRefreshUpdate = False
		Catch ex As Exception : My.App.WriteToLog(My.App.Tools.WinLinks, "Fatal Error Loading WinLinks!" + Chr(13) + "Location : backgroundworkerWinLinksRunWorkerCompleted" + Chr(13) + "Error : " + ex.ToString)
        End Try
    End Sub

    ' Methods
    Private Sub ShowWL()
		Try
			ShowSettings(My.App.Tools.WinLinks)
			If (My.App.WSTShowWLMenu Or My.App.WSTShowWLTray) And My.App.WLData.Count > 0 And Not BackgroundworkerWL.IsBusy Then
				If Not InUseWL() Then
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
			End If
		Catch ex As Exception : My.App.WriteToLog(My.App.Tools.WinLinks, "Error In ShowWinLinks" + Chr(13) + ex.ToString)
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
	Private Sub WLClose(Optional ByRef forcecloseall As Boolean = False)
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
					trayicon.Visible = False
					trayicon.Dispose()
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
	Private Sub WLSetAutoRefresh(Optional forceterminate As Boolean = False)
		If Not BackgroundworkerWL.IsBusy Then
			'Turn Off Watcher
			If WatcherWLAutoRefresh.EnableRaisingEvents Then
				Try
					WatcherWLAutoRefresh.EnableRaisingEvents = False
					TimerWLAutoRefresh.Stop()
					TimerWLAutoRefreshIdle.Stop()
					Me.lblWLAutoRefresh.Visible = False
					Debug.Print("SetWinLinksAutoRefresh :Watcher Terminated")
				Catch ex As Exception
					My.App.WriteToLog(My.App.Tools.WinLinks, "AutoRefresh could not be DeActivated." + Chr(13) + ex.ToString)
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
						Me.lblWLAutoRefresh.Visible = True
						Debug.Print("SetWinLinksAutoRefresh: Watcher Activated")
					Catch ex As Exception : My.App.WriteToLog(My.App.Tools.WinLinks, "AutoRefresh could not be Activated." + Chr(13) + ex.ToString)
					End Try
				End If
			End If
		End If
	End Sub
	Private Sub WLSetManualRefresh()
		WLClose(True)
		ShowSettings(My.App.Tools.WinLinks)
		If My.App.WLData.Count > 0 Then
			Me.btnWLRefresh.Font = New Font(Me.btnWLRefresh.Font, FontStyle.Bold)
			Me.btnWLRefresh.Enabled = True
		Else
			Me.btnWLRefresh.Enabled = False
			Me.btnWLRefresh.Font = New Font(Me.btnWLRefresh.Font, FontStyle.Regular)
		End If
	End Sub
	Private Sub WLSetNew()
		If Me.listviewWL.SelectedIndices.Count = 0 Then : WLInsertIndex = -1
		Else : WLInsertIndex = Me.listviewWL.SelectedIndices(0)
		End If
		ShowSettings(My.App.Tools.WinLinks)
		Me.panelWL.Show()
		Me.checkboxWLShowInMenu.Checked = True
		Me.checkboxWLShowInTray.Checked = True
		Me.checkboxWLShowNoMenu.Checked = False
		Me.checkboxWLShowMenuIcons.Checked = True
		Me.lblWLRoot.ResetFont()
		Me.lblWLRoot.Text = "Root Folder"
		Me.textboxWLRoot.Select()
	End Sub
	Private Sub WLSetSettingsTab()
		If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then : Me.tabpageWL.Enabled = True
		Else : Me.tabpageWL.Enabled = False
		End If
	End Sub
	Private Sub WLSetSettingsState(state As Boolean)
		'On Error Resume Next
		Me.listviewWL.Enabled = state
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
		Me.checkboxWSTShowWLMenu.Enabled = state
		Me.checkboxWSTShowWLTray.Enabled = state
		If WLStartUp Then : Me.btnWLRefresh.Enabled = False
		Else : Me.btnWLRefresh.Enabled = True
		End If
		If state Then
			Me.btnSettingsRestore.Enabled = True
			Me.btnWLRefresh.Text = "Full Refresh"
			Me.TipInfoEX.SetText(Me.btnWLRefresh, "Refresh ALL Data & Menus")
			Me.btnWLRefresh.Image = My.Resources.Resources.imageSwap 'DirectCast(My.App.AppResources.GetObject("imageSwap"), Image)
			Me.btnWLRefresh.Font = New Font(Me.btnWLRefresh.Font, FontStyle.Regular)
		Else
			Me.btnSettingsRestore.Enabled = False
			Me.btnWLRefresh.Text = "CANCEL"
			Me.TipInfoEX.SetText(Me.btnWLRefresh, "Cancel File Search")
			Me.btnWLRefresh.Image = My.Resources.Resources.imageClose 'DirectCast(My.App.AppResources.GetObject("imageClose"), Image)
			Me.btnWLRefresh.Font = New Font(Me.btnWLRefresh.Font, FontStyle.Bold)
		End If
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

End Class
