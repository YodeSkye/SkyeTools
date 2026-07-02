
Imports System.Data.Common
Imports System.IO
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
	Private nonNumberEntered As Boolean
	Private ErrorWarning As Boolean = False
	Private ProcessList As Collections.Generic.List(Of ProcessListType)
	Private mMove As Boolean = False
	Private mOffset, mPosition As Point

	' Form Events
	Friend Sub New()

		'Initialize Locals
		InitializeComponent()
		TimerWSTStopWatchReset.Interval = 5400000
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
		uiHLOpenFile.Title = "Select a File..."
		uiHLFolderBrowser.Description = "Select a StartUp Folder for your Program..."
		uiHLFolderBrowser.ShowNewFolderButton = False
		Me.cmHLMenu.Font = New Font(Me.Font, FontStyle.Regular)
		Me.cmHLTray.Font = New Font(Me.Font, FontStyle.Regular)
		Me.cmHLItem.Font = New Font(Me.Font, FontStyle.Regular)
		uiWLFolderBrowser.Description = "Select a Folder with ShortCuts or Programs..."
		uiWLFileBrowser.Title = "Select The YMFM App..."
		uiWLFileBrowser.DefaultExt = "exe"
		uiWLFileBrowser.Filter = "Executable Files|*.exe"
		uiWLFileBrowser.InitialDirectory = "C:\PROGRAM FILES"
		uiWLFolderBrowser.ShowNewFolderButton = False
		Me.cmWLItem.Font = New Font(Me.Font, FontStyle.Regular)
		Me.imagelisttabcontrolSettings = New ImageList(Me.components) With {
			.ColorDepth = ColorDepth.Depth32Bit,
			.ImageSize = New Size(16, 16),
			.TransparentColor = System.Drawing.Color.Transparent}
		Me.imagelisttabcontrolSettings.Images.Add("imageAC", My.Resources.Resources.imageAC) 'DirectCast(My.App.AppResources.GetObject("imageAC"), Image))
		Me.imagelisttabcontrolSettings.Images.Add("imageCB", My.Resources.Resources.imageCB) 'DirectCast(My.App.AppResources.GetObject("imageCB"), Image))
		Me.imagelisttabcontrolSettings.Images.Add("imageHC", My.Resources.Resources.imageHC) 'DirectCast(My.App.AppResources.GetObject("imageHC"), Image))
		Me.imagelisttabcontrolSettings.Images.Add("imageHK", My.Resources.Resources.imageHK) 'DirectCast(My.App.AppResources.GetObject("imageHK"), Image))
		Me.imagelisttabcontrolSettings.Images.Add("imageHL", My.Resources.Resources.imageHL) 'DirectCast(My.App.AppResources.GetObject("imageHL"), Image))
		Me.imagelisttabcontrolSettings.Images.Add("imageWL", My.Resources.Resources.imageWL) 'DirectCast(My.App.AppResources.GetObject("imageWL"), Image))
		Me.imagelisttabcontrolSettings.Images.Add("imageWST", My.Resources.Resources.imageWST) 'DirectCast(My.App.AppResources.GetObject("imageWST"), Image))
		Me.tabcontrolSettings.ImageList = Me.imagelisttabcontrolSettings
		Me.tabpageAC.Text = My.App.ToolToString(My.App.Tools.AlarmChime)
		Me.tabpageAC.ImageKey = "imageAC"
		Me.tabpageHC.Text = My.App.ToolToString(My.App.Tools.HotClicks)
		Me.tabpageHC.ImageKey = "imageHC"
		Me.tabpageHK.Text = My.App.ToolToString(My.App.Tools.HotKeys)
		Me.tabpageHK.ImageKey = "imageHK"
		Me.tabpageHL.Text = My.App.ToolToString(My.App.Tools.HotLinks)
		Me.tabpageHL.ImageKey = "imageHL"
		Me.tabpageWL.Text = My.App.ToolToString(My.App.Tools.WinLinks)
		Me.tabpageWL.ImageKey = "imageWL"
		Me.tabpageWST.Text = My.App.ToolToString(My.App.Tools.WorkSpaceTools)
		Me.tabpageWST.ImageKey = "imageWST"
		Me.imagelistlistviewHL = New ImageList(Me.components) With {
			.ColorDepth = ColorDepth.Depth32Bit,
			.ImageSize = New Size(16, 16),
			.TransparentColor = System.Drawing.Color.Transparent}
		Me.imagelistlistviewHL.Images.Add("imageHLApp", My.Resources.Resources.imageHLApp) '(My.App.AppResources.GetObject("imageHLApp"), Image))
		Me.imagelistlistviewHL.Images.Add("imageHLDoc", My.Resources.Resources.imageHLDoc) 'DirectCast(My.App.AppResources.GetObject("imageHLDoc"), Image))
		Me.imagelistlistviewHL.Images.Add("imageHLGroup", My.Resources.Resources.imageHLGroup) 'DirectCast(My.App.AppResources.GetObject("imageHLGroup"), Image))
		Me.imagelistlistviewHL.Images.Add("imageHLScript", My.Resources.Resources.imageHLScript) 'DirectCast(My.App.AppResources.GetObject("imageHLScript"), Image))
		Me.imagelistlistviewHL.Images.Add("imageHLSeparator", My.Resources.Resources.imageHLSeparator) 'DirectCast(My.App.AppResources.GetObject("imageHLSeparator"), Image))
		Me.imagelistlistviewHL.Images.Add("imageHLWeb", My.Resources.Resources.imageHLWeb) 'DirectCast(My.App.AppResources.GetObject("imageHLWeb"), Image))
		Me.lvHL.SmallImageList = Me.imagelistlistviewHL

		'Initialize Globals
		My.App.ToolToImage(My.App.Tools.SkyeTools) = My.Resources.Resources.imageApp 'DirectCast(My.App.AppResources.GetObject("imageApp"), Image)
		My.App.ToolToImage(My.App.Tools.HotClicks) = My.Resources.Resources.imageHC 'DirectCast(My.App.AppResources.GetObject("imageHC"), Image)
		My.App.ToolToImage(My.App.Tools.HotKeys) = My.Resources.Resources.imageHK 'DirectCast(My.App.AppResources.GetObject("imageHK"), Image)
		My.App.ToolToImage(My.App.Tools.WorkSpaceTools) = My.Resources.Resources.iconWST.ToBitmap 'DirectCast(My.App.AppResources.GetObject("iconWST"), Icon).ToBitmap
		My.App.ToolToImage(My.App.Tools.HotLinks) = My.Resources.Resources.iconHL.ToBitmap 'DirectCast(My.App.AppResources.GetObject("iconHL"), Icon).ToBitmap
		My.App.ToolToImage(My.App.Tools.WinLinks) = My.Resources.Resources.iconWL.ToBitmap 'DirectCast(My.App.AppResources.GetObject("iconWL"), Icon).ToBitmap
		My.App.ToolToImage(My.App.Tools.ScreenSaver) = My.Resources.Resources.iconWSTScreenSaverEnabled.ToBitmap 'DirectCast(My.App.AppResources.GetObject("iconWSTScreenSaverEnabled"), Icon).ToBitmap
		My.App.ToolToImage(My.App.Tools.AlarmChime) = Me.cmiWSTAC.Image
		My.App.ToolToImage(My.App.Tools.StopWatch) = My.Resources.Resources.imageWSTStopWatch 'DirectCast(My.App.AppResources.GetObject("imageWSTStopWatch"), Image)
		My.App.ToolToImage(My.App.Tools.Clock) = My.Resources.Resources.imageWSTClock 'DirectCast(My.App.AppResources.GetObject("imageWSTClock"), Image)
		'My.App.ACChime = CType(My.Resources.Resources.soundChime, MemoryStream) 'DirectCast(My.App.AppResources.GetObject("Chime"), Byte())
		Dim ums As System.IO.UnmanagedMemoryStream = My.Resources.Resources.soundChime
		Dim audioBytes(CInt(ums.Length) - 1) As Byte
		ums.Read(audioBytes, 0, audioBytes.Length)
		My.App.ACChime = audioBytes
		audioBytes = Nothing
		ums.Dispose()
		My.App.SetBalloon()

		'Initialize Form
		Me.Text = "Settings For " + My.Application.Info.ProductName + " v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
		'Me.cmiAppListUseAlt.ToolTipText = My.App.UseAlternateCloseMethodToolTipText
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
		Me.tipInfo.SetToolTip(Me.btnACAlarmCancel, "THE ALARM HAS SOUNDED")
		Me.notifyiconHL = New NotifyIcon(Me.components) With {
			.Tag = "notifyiconHL",
			.Icon = My.Resources.Resources.iconHL,
			.ContextMenuStrip = Me.cmHLTray}
		Me.cmiWSTHLMenu.DropDown = Me.cmHLMenu
		Me.tipInfo.SetToolTip(Me.checkboxHLUseAlternateStartMethod, My.App.UseAlternateStartMethodToolTipText)
		AddHandler Me.notifyiconWST.MouseDown, AddressOf NotifyiconMouseDown
		AddHandler Me.notifyiconWSTScreenSaver.MouseDown, AddressOf NotifyiconMouseDown
		AddHandler Me.notifyiconHL.MouseDown, AddressOf NotifyiconMouseDown
		AddHandler Me.cmHLTray.Opening, AddressOf CMHLTrayOpening
		WLSetSettingsState(True)
#If DEBUG Then
		BackgroundworkerWL.WorkerReportsProgress = True
#End If

	End Sub
	Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
		'Try
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
			'Case Skye.WinAPI.WM_CHANGECBCHAIN
			'	CBOSChain = m.LParam
			'	If Not CBOSChain.ToInt32 = 0 Then Skye.WinAPI.SendMessage(CBOSChain, CUInt(m.Msg), m.WParam, m.LParam)
			'	MyBase.WndProc(m)
			'Case Skye.WinAPI.WM_DRAWCLIPBOARD
			'	Dim seqno As UInteger = Skye.WinAPI.GetClipboardSequenceNumber
			'	If seqno - CBOSSequenceNumber <= 2 Then : CBOSSequenceNumber = CInt(seqno) 'This attempts to check for duplicates.
			'	Else
			'		CBOSSequenceNumber = CInt(seqno)
			'		If CBSet Then : CBSet = False 'Windows clipboard was just set by this program, so ignore this message, for it is just the same data.
			'		Else : CBSetData(m.WParam)
			'		End If
			'	End If
			'	If Not CBOSChain.ToInt32 = 0 Then Skye.WinAPI.SendMessage(CBOSChain, CUInt(m.Msg), m.WParam, m.LParam)
			'	MyBase.WndProc(m)
			Case Skye.WinAPI.WM_HOTKEY
				HKPerformAction(m.WParam.ToInt32)
				MyBase.WndProc(m)
			Case Else : MyBase.WndProc(m)
		End Select
		'Catch ex As Exception : My.App.WriteToLog(My.App.Tools.SkyeTools, "MainForm WndProc Handler Error" + Chr(13) + ex.ToString)
		'End Try
	End Sub
	Private Sub FrmLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
#If DEBUG Then
#Else
		My.App.SetLoadOnOSStartup()
#End If
		If sender Is Me.btnSettingsRestore Then My.App.WriteToLog(My.App.Tools.SkyeTools, "Settings Restored...") 'This must be here because it is called by btnRestoreSettings.
		WSTClockSet()
		UpdateACMute()
		WSTStopWatchSet()
		ShowSettings()
		ACSet()
		HKRegister()
	End Sub
	Private Sub FrmShown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
		Me.Hide()
		Me.Opacity = 1
		If Not My.Application.AlternateStart AndAlso ((My.App.WSTShowWLMenu Or My.App.WSTShowWLTray) And My.App.WLStartUpDelay > 0) Then WLStartUp = True
		If Not My.Application.AlternateStart AndAlso (My.App.WSTShowWLMenu And Not My.App.WSTShowWLTray) Then ShowWL()
		ShowTools()
		ShowHL()

		If Not My.Application.AlternateStart AndAlso My.App.HLStartUp AndAlso sender IsNot Me.btnSettingsRestore Then
			TimerHLStartUp.Interval = My.App.HLStartUpDelay * 1000
			TimerHLStartUp.Start()
		End If
		If Not My.Application.AlternateStart AndAlso ((My.App.WSTShowWLMenu Or My.App.WSTShowWLTray) And My.App.WLStartUpDelay > 0) Then
			TimerWLStartUp.Interval = My.App.WLStartUpDelay * 1000
			TimerWLStartUp.Start()
		End If
		If Not My.Application.AlternateStart AndAlso (My.App.HLStartUp Or ((My.App.WSTShowWLMenu Or My.App.WSTShowWLTray) And My.App.WLStartUpDelay > 0)) AndAlso sender IsNot Me.btnSettingsRestore Then
			Me.cmiWSTCancelStartUp.Visible = True
			Me.cmseparatorWSTCancel.Visible = True
		End If
		UpdateWST()
#If DEBUG Then
		Me.Left = 0
		Me.Top = CInt(My.Computer.Screen.Bounds.Height / 2 - Me.Height / 2)
		Me.btnErrorTest.Show()
		Me.btnClockTest.Show()
		Me.btnBalloonTest.Show()
		Me.checkboxLoadOnOSStartup.Enabled = False
		Me.lblLoadOnOSStartupPath.Enabled = False
		Me.txbxLoadOnOSStartupArgs.Enabled = False
		Me.btnLoadOnOSStartupPath.Enabled = False

		'Me.tabcontrolSettings.SelectTab(Me.tabpageAC)
		'Me.tabcontrolSettings.SelectTab(Me.tabpageCB)
		'Me.tabcontrolSettings.SelectTab(Me.tabpageHL)
		'Me.tabcontrolSettings.SelectTab(Me.tabpageWL)
		'Me.tabcontrolSettings.SelectTab(Me.tabpageOA)

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
		TimerHLStartUp.Stop()
		HKRegister(True)
		WLClose(True)
	End Sub
	Private Sub FrmMouseDown(sender As Object, e As MouseEventArgs) Handles tabpageWST.MouseDown, tabpageWL.MouseDown, tabpageHL.MouseDown, tabpageHK.MouseDown, tabpageHC.MouseDown, tabpageAC.MouseDown, panelHLEdit.MouseDown, MyBase.MouseDown
		Static senderTB As Control
		If e.Button = MouseButtons.Left And WindowState = FormWindowState.Normal Then
			mMove = True
			If sender.GetType = GetType(TabPage) Then
				senderTB = DirectCast(sender, Control)
				mOffset = New Point(-e.X - SystemInformation.FrameBorderSize.Width - tabcontrolSettings.Left - senderTB.Left, -e.Y - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight - tabcontrolSettings.Top - senderTB.Top)
				senderTB = Nothing
			ElseIf sender Is panelHLEdit Then
				mOffset = New Point(-e.X - panelHLEdit.Left - tabpageHL.Left - tabcontrolSettings.Left - SystemInformation.FrameBorderSize.Width, -e.Y - panelHLEdit.Top - tabpageHL.Top - tabcontrolSettings.Top - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight)
			Else : mOffset = New Point(-e.X - SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight)
			End If
		End If
	End Sub
	Private Sub FrmMouseMove(sender As Object, e As MouseEventArgs) Handles tabpageWST.MouseMove, tabpageWL.MouseMove, tabpageHL.MouseMove, tabpageHK.MouseMove, tabpageHC.MouseMove, tabpageAC.MouseMove, panelHLEdit.MouseMove, MyBase.MouseMove
		If mMove Then
			mPosition = MousePosition
			mPosition.Offset(mOffset.X, mOffset.Y)
			CheckMove(mPosition)
			Location = mPosition
		End If
	End Sub
	Private Sub FrmMouseUp(sender As Object, e As MouseEventArgs) Handles tabpageWST.MouseUp, tabpageWL.MouseUp, tabpageHL.MouseUp, tabpageHK.MouseUp, tabpageHC.MouseUp, tabpageAC.MouseUp, panelHLEdit.MouseUp, MyBase.MouseUp
		mMove = False
	End Sub
	Private Sub FrmMove(sender As Object, e As EventArgs) Handles MyBase.Move
		If Not mMove AndAlso Me.WindowState = FormWindowState.Normal Then CheckMove(Me.Location)
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
	Private Sub BtnEnter(ByVal sender As Object, ByVal e As EventArgs) Handles btnWSTTaskManager.Enter, btnWSTScreenSaverEnabled.Enter, btnWSTCommandPrompt.Enter, btnWLRefresh.Enter, btnSettingsSave.Enter, btnSettingsRestore.Enter, btnLog.Enter, btnLoadOnOSStartupPath.Enter, btnInfo.Enter, btnErrorTest.Enter, btnClockTest.Enter, btnBalloonTest.Enter, btnACTopHourChimePlay.Enter, btnACTopHourChimeManual.Enter, btnACTopHourChimeDefault.Enter, btnACOffHourChimePlay.Enter, btnACOffHourChimeManual.Enter, btnACOffHourChimeDefault.Enter, btnACMute.Enter, btnACAlarmSet.Enter, btnACAlarmChimePlay.Enter, btnACAlarmChimeManual.Enter, btnACAlarmChimeDefault.Enter, btnACAlarmCancel.Enter
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
		If e.X >= 0 And e.X <= Me.btnErrorTest.Width And e.Y >= 0 And e.Y <= Me.btnErrorTest.Height Then
			Select Case e.Button
				Case MouseButtons.Left
					ErrorNotification()
					My.App.WriteToLog(My.App.Tools.SkyeTools, "Test Error - DO NOT PANIC!!")
					'My.SkyeTools.ShowMessage(My.SkyeTools.Tools.SkyeTools, "ERROR!", "Test Error - DO NOT PANIC!!", "Error Noted In Log")
					My.App.ShowMessage(My.App.Tools.SkyeTools, "ERROR!", "Test Error - DO NOT PANIC!!", "Error Noted In Log", SystemIcons.Error)
				Case MouseButtons.Right
					Throw New Exception("Test Exception - DO NOT PANIC!!")
			End Select
		End If
	End Sub
	Private Sub BtnBalloonTestMouseUp(sender As Object, e As MouseEventArgs) Handles btnBalloonTest.MouseUp
		Select Case e.Button
			Case MouseButtons.Left
				If My.Computer.Keyboard.CtrlKeyDown Then
					If My.Application.SplashScreen Is Nothing Then My.Application.SplashScreen = New SplashForm
					If My.Application.SplashScreen.Visible Then : My.Application.SplashScreen.Hide()
					Else : My.Application.SplashScreen.Show()
					End If
				Else
					If My.App.FrmBalloon.Visible Then : My.App.HideBalloon()
					Else : My.App.ShowBalloon(My.App.Tools.SkyeTools, "TEST BALLOON" + Chr(13) + "This is a test Balloon Window. Click anywhere to close.", My.App.BalloonDelay.WaitForUser)
					End If
				End If
		End Select
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
		If Me.cmWST.Visible Or Me.cmWSTScreenSaver.Visible Or Me.cmHLMenu.Visible Or Me.cmHLTray.Visible Or Me.cmHLItem.Visible Then Return True
		If InUseWL() Then Return True
		If InUseForms() Then Return True
		If InUseSettings() Then Return True
		Return False
	End Function
	Private Sub ShowTools()
		If Not (My.App.WSTEnabled Or My.App.WSTShowSSIcon Or My.App.WSTShowHLTray Or My.App.WSTShowWLTray) Then : Me.Close() 'No Tools Running(That Have A Tray Icon), So Close Application
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

			HLSetSettingsTab()

			If My.App.WSTShowHLTray Then : Me.notifyiconHL.Visible = True
			Else : Me.notifyiconHL.Visible = False
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
		If Not Me.lvHL.Visible Then ShowSettings(My.App.Tools.HotLinks)
		If Me.listviewWL.SelectedIndices.Count > 0 Then ShowSettings(My.App.Tools.WinLinks)
	End Sub
	Private Sub CheckMove(ByRef location As Point)
		If location.X + Me.Width > My.Computer.Screen.WorkingArea.Right Then location.X = My.Computer.Screen.WorkingArea.Right - Me.Width
		If location.Y + Me.Height > My.Computer.Screen.WorkingArea.Bottom Then location.Y = My.Computer.Screen.WorkingArea.Bottom - Me.Height
		If location.X < My.Computer.Screen.WorkingArea.Left Then location.X = My.Computer.Screen.WorkingArea.Left
		If location.Y < My.Computer.Screen.WorkingArea.Top Then location.Y = My.Computer.Screen.WorkingArea.Top
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
	Private Function InUseForms() As Boolean
		If My.App.FrmBalloon IsNot Nothing Then If My.App.FrmBalloon.Visible Then Return True
		If My.App.FrmInfoVisible Then Return True
		If My.App.FrmMessageVisible Then Return True
		Return False
	End Function
	Private Function InUseSettings() As Boolean '
		If Me.Visible Then Return True
		Return False
	End Function
	Private Function CloseApplications(tool As My.App.Tools, closelist As Collections.Generic.List(Of String), Optional timeout As Byte = 60, Optional generateOArestartlist As Boolean = False) As Boolean '
		Try
			For Each i As String In closelist
				'Dim usealt As Boolean = False
				'If i.Substring(0, 1) = "*" Then
				'	usealt = True
				'	i = i.TrimStart(CChar("*"))
				'End If
				My.App.ShowBalloon(tool, "Closing " + i.ToUpper, My.App.BalloonDelay.WaitForUser)
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
				My.App.HideBalloon()
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
	Private Sub TextboxShortcutKeysPreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs) Handles textboxHLWorkingDirectory.PreviewKeyDown, textboxHLName.PreviewKeyDown, textboxHLLink.PreviewKeyDown, textboxHLDescription.PreviewKeyDown, textboxHLArguments.PreviewKeyDown
		If e.KeyData = Keys.A + Keys.Control Then CType(sender, TextBox).SelectAll()
	End Sub
	Private Sub TextboxNumbersOnlyKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles textboxWLStartUpDelay.KeyDown, textboxWLMaxLinksPerFolder.KeyDown, textboxWLAutoRefreshInterval.KeyDown, textboxWLAutoRefreshIdleInterval.KeyDown, textboxHLUseAlternateStartTimeOut.KeyDown, textboxHLStartUpDelay.KeyDown, textboxHLLoadTimeOut.KeyDown, textboxHLCloseTimeOut.KeyDown
		nonNumberEntered = False
		If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
			If e.KeyCode <> Keys.Delete And e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Enter Then : nonNumberEntered = True
			ElseIf e.KeyCode = Keys.Enter Then : Validate()
			End If
		End If
	End Sub
	Private Sub TextboxNumbersOnlyKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles textboxWLStartUpDelay.KeyPress, textboxWLMaxLinksPerFolder.KeyPress, textboxWLAutoRefreshInterval.KeyPress, textboxWLAutoRefreshIdleInterval.KeyPress, textboxHLUseAlternateStartTimeOut.KeyPress, textboxHLStartUpDelay.KeyPress, textboxHLLoadTimeOut.KeyPress, textboxHLCloseTimeOut.KeyPress, textboxACAlarmTimer.KeyPress, textboxACAlarmTime.KeyPress
		If nonNumberEntered Then e.Handled = True
	End Sub
	Private Sub TxbxKeyDown(sender As Object, e As KeyEventArgs) Handles txbxWSTTaskManagerArgs.KeyDown, txbxWSTCommandPromptArgs.KeyDown, txbxLoadOnOSStartupArgs.KeyDown
		If e.KeyCode = Keys.Enter Then Me.Validate()
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
		ShowSettingsHL()
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
				Case My.App.Tools.HotLinks : ShowSettingsHL()
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
		Me.lblHKWSTStopWatch.Text = My.App.HKWSTStopWatch.Description
		Me.textboxHKWSTStopWatch.Text = My.App.HKWSTStopWatch.Key.ToString
		Me.textboxHKWSTStopWatch.Tag = My.App.HKWSTStopWatch
		Me.textboxHKWSTStopWatch.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKWSTStopWatch.ForeColor = Color.Teal
		Me.lblHKWSTClock.Text = My.App.HKWSTClock.Description
		Me.textboxHKWSTClock.Text = My.App.HKWSTClock.Key.ToString
		Me.textboxHKWSTClock.Tag = My.App.HKWSTClock
		Me.textboxHKWSTClock.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKWSTClock.ForeColor = Color.Teal
		Me.lblHKHLA.Text = My.App.HKHLA.Description
		Me.tipInfo.SetToolTip(Me.lblHKHLA, My.App.GenerateHKHLTip(My.App.HLHotKey.A))
		Me.tipInfo.SetToolTip(Me.textboxHKHLA, Me.tipInfo.GetToolTip(Me.lblHKHLA))
		Me.textboxHKHLA.Text = My.App.HKHLA.Key.ToString
		Me.textboxHKHLA.Tag = My.App.HKHLA
		Me.textboxHKHLA.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKHLA.ForeColor = Color.Teal
		Me.lblHKHLB.Text = My.App.HKHLB.Description
		Me.tipInfo.SetToolTip(Me.lblHKHLB, My.App.GenerateHKHLTip(My.App.HLHotKey.B))
		Me.tipInfo.SetToolTip(Me.textboxHKHLB, Me.tipInfo.GetToolTip(Me.lblHKHLB))
		Me.textboxHKHLB.Text = My.App.HKHLB.Key.ToString
		Me.textboxHKHLB.Tag = My.App.HKHLB
		Me.textboxHKHLB.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKHLB.ForeColor = Color.Teal
		Me.lblHKHLC.Text = My.App.HKHLC.Description
		Me.tipInfo.SetToolTip(Me.lblHKHLC, My.App.GenerateHKHLTip(My.App.HLHotKey.C))
		Me.tipInfo.SetToolTip(Me.textboxHKHLC, Me.tipInfo.GetToolTip(Me.lblHKHLC))
		Me.textboxHKHLC.Text = My.App.HKHLC.Key.ToString
		Me.textboxHKHLC.Tag = My.App.HKHLC
		Me.textboxHKHLC.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKHLC.ForeColor = Color.Teal
		Me.lblHKHLD.Text = My.App.HKHLD.Description
		Me.tipInfo.SetToolTip(Me.lblHKHLD, My.App.GenerateHKHLTip(My.App.HLHotKey.D))
		Me.tipInfo.SetToolTip(Me.textboxHKHLD, Me.tipInfo.GetToolTip(Me.lblHKHLD))
		Me.textboxHKHLD.Text = My.App.HKHLD.Key.ToString
		Me.textboxHKHLD.Tag = My.App.HKHLD
		Me.textboxHKHLD.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKHLD.ForeColor = Color.Teal
		Me.lblHKHLE.Text = My.App.HKHLE.Description
		Me.tipInfo.SetToolTip(Me.lblHKHLE, My.App.GenerateHKHLTip(My.App.HLHotKey.E))
		Me.tipInfo.SetToolTip(Me.textboxHKHLE, Me.tipInfo.GetToolTip(Me.lblHKHLE))
		Me.textboxHKHLE.Text = My.App.HKHLE.Key.ToString
		Me.textboxHKHLE.Tag = My.App.HKHLE
		Me.textboxHKHLE.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKHLE.ForeColor = Color.Teal
		Me.lblHKHLF.Text = My.App.HKHLF.Description
		Me.tipInfo.SetToolTip(Me.lblHKHLF, My.App.GenerateHKHLTip(My.App.HLHotKey.F))
		Me.tipInfo.SetToolTip(Me.textboxHKHLF, Me.tipInfo.GetToolTip(Me.lblHKHLF))
		Me.textboxHKHLF.Text = My.App.HKHLF.Key.ToString
		Me.textboxHKHLF.Tag = My.App.HKHLF
		Me.textboxHKHLF.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKHLF.ForeColor = Color.Teal
		Me.lblHKHLG.Text = My.App.HKHLG.Description
		Me.tipInfo.SetToolTip(Me.lblHKHLG, My.App.GenerateHKHLTip(My.App.HLHotKey.G))
		Me.tipInfo.SetToolTip(Me.textboxHKHLG, Me.tipInfo.GetToolTip(Me.lblHKHLG))
		Me.textboxHKHLG.Text = My.App.HKHLG.Key.ToString
		Me.textboxHKHLG.Tag = My.App.HKHLG
		Me.textboxHKHLG.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKHLG.ForeColor = Color.Teal
		Me.lblHKHLH.Text = My.App.HKHLH.Description
		Me.tipInfo.SetToolTip(Me.lblHKHLH, My.App.GenerateHKHLTip(My.App.HLHotKey.H))
		Me.tipInfo.SetToolTip(Me.textboxHKHLH, Me.tipInfo.GetToolTip(Me.lblHKHLH))
		Me.textboxHKHLH.Text = My.App.HKHLH.Key.ToString
		Me.textboxHKHLH.Tag = My.App.HKHLH
		Me.textboxHKHLH.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKHLH.ForeColor = Color.Teal
		Me.lblHKWL.Text = My.App.HKWL.Description
		Me.textboxHKWL.Text = My.App.HKWL.Key.ToString
		Me.textboxHKWL.Tag = My.App.HKWL
		Me.textboxHKWL.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKWL.ForeColor = Color.Teal
		Me.lblHKWSTTaskManager.Text = My.App.HKWSTTaskManager.Description
		Me.textboxHKWSTTaskManager.Text = My.App.HKWSTTaskManager.Key.ToString
		Me.textboxHKWSTTaskManager.Tag = My.App.HKWSTTaskManager
		Me.textboxHKWSTTaskManager.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKWSTTaskManager.ForeColor = Color.Teal
		Me.lblHKWSTCommandPrompt.Text = My.App.HKWSTCommandPrompt.Description
		Me.textboxHKWSTCommandPrompt.Text = My.App.HKWSTCommandPrompt.Key.ToString
		Me.textboxHKWSTCommandPrompt.Tag = My.App.HKWSTCommandPrompt
		Me.textboxHKWSTCommandPrompt.Font = New Font(Me.Font, FontStyle.Bold)
		Me.textboxHKWSTCommandPrompt.ForeColor = Color.Teal
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
			If My.App.WSTShowStopWatch Then : Me.lblHKWSTStopWatch.Enabled = True
			Else : Me.lblHKWSTStopWatch.Enabled = False
			End If
			Me.textboxHKWSTStopWatch.Enabled = True
			Me.btnHKWSTStopWatchDisable.Enabled = True
			If My.App.WSTShowClock Then : Me.lblHKWSTClock.Enabled = True
			Else : Me.lblHKWSTClock.Enabled = False
			End If
			Me.textboxHKWSTClock.Enabled = True
			Me.btnHKWSTClockDisable.Enabled = True
			If My.App.WSTShowHLMenu Or My.App.WSTShowHLTray Then
				Me.lblHKHLA.Enabled = True
				Me.lblHKHLB.Enabled = True
				Me.lblHKHLC.Enabled = True
				Me.lblHKHLD.Enabled = True
				Me.lblHKHLE.Enabled = True
				Me.lblHKHLF.Enabled = True
				Me.lblHKHLG.Enabled = True
				Me.lblHKHLH.Enabled = True
			Else
				Me.lblHKHLA.Enabled = False
				Me.lblHKHLB.Enabled = False
				Me.lblHKHLC.Enabled = False
				Me.lblHKHLD.Enabled = False
				Me.lblHKHLE.Enabled = False
				Me.lblHKHLF.Enabled = False
				Me.lblHKHLG.Enabled = False
				Me.lblHKHLH.Enabled = False
			End If
			Me.textboxHKHLA.Enabled = True
			Me.btnHKHLADisable.Enabled = True
			Me.textboxHKHLB.Enabled = True
			Me.btnHKHLBDisable.Enabled = True
			Me.textboxHKHLC.Enabled = True
			Me.btnHKHLCDisable.Enabled = True
			Me.textboxHKHLD.Enabled = True
			Me.btnHKHLDDisable.Enabled = True
			Me.textboxHKHLE.Enabled = True
			Me.btnHKHLEDisable.Enabled = True
			Me.textboxHKHLF.Enabled = True
			Me.btnHKHLFDisable.Enabled = True
			Me.textboxHKHLG.Enabled = True
			Me.btnHKHLGDisable.Enabled = True
			Me.textboxHKHLH.Enabled = True
			Me.btnHKHLHDisable.Enabled = True
			If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then : Me.lblHKWL.Enabled = True
			Else : Me.lblHKWL.Enabled = False
			End If
			Me.textboxHKWL.Enabled = True
			Me.btnHKWLDisable.Enabled = True
			If My.App.WSTShowTaskManager Then : Me.lblHKWSTTaskManager.Enabled = True
			Else : Me.lblHKWSTTaskManager.Enabled = False
			End If
			Me.textboxHKWSTTaskManager.Enabled = True
			Me.btnHKWSTTaskManagerDisable.Enabled = True
			If My.App.WSTShowCommandPrompt Then : Me.lblHKWSTCommandPrompt.Enabled = True
			Else : Me.lblHKWSTCommandPrompt.Enabled = False
			End If
			Me.textboxHKWSTCommandPrompt.Enabled = True
			Me.btnHKWSTCommandPromptDisable.Enabled = True
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
			Me.textboxHKWSTStopWatch.Enabled = False
			Me.btnHKWSTStopWatchDisable.Enabled = False
			Me.lblHKWSTClock.Enabled = False
			Me.textboxHKWSTClock.Enabled = False
			Me.btnHKWSTClockDisable.Enabled = False
			Me.lblHKHLA.Enabled = False
			Me.textboxHKHLA.Enabled = False
			Me.btnHKHLADisable.Enabled = False
			Me.lblHKHLB.Enabled = False
			Me.textboxHKHLB.Enabled = False
			Me.btnHKHLBDisable.Enabled = False
			Me.lblHKHLC.Enabled = False
			Me.textboxHKHLC.Enabled = False
			Me.btnHKHLCDisable.Enabled = False
			Me.lblHKHLD.Enabled = False
			Me.textboxHKHLD.Enabled = False
			Me.btnHKHLDDisable.Enabled = False
			Me.lblHKHLE.Enabled = False
			Me.textboxHKHLE.Enabled = False
			Me.btnHKHLEDisable.Enabled = False
			Me.lblHKHLF.Enabled = False
			Me.textboxHKHLF.Enabled = False
			Me.btnHKHLFDisable.Enabled = False
			Me.lblHKHLG.Enabled = False
			Me.textboxHKHLG.Enabled = False
			Me.btnHKHLGDisable.Enabled = False
			Me.lblHKHLH.Enabled = False
			Me.textboxHKHLH.Enabled = False
			Me.btnHKHLHDisable.Enabled = False
			Me.lblHKWL.Enabled = False
			Me.textboxHKWL.Enabled = False
			Me.btnHKWLDisable.Enabled = False
			Me.lblHKWSTTaskManager.Enabled = False
			Me.textboxHKWSTTaskManager.Enabled = False
			Me.btnHKWSTTaskManagerDisable.Enabled = False
			Me.lblHKWSTCommandPrompt.Enabled = False
			Me.textboxHKWSTCommandPrompt.Enabled = False
			Me.btnHKWSTCommandPromptDisable.Enabled = False
			Me.btnHKEnabled.Text = "Enable"
			Me.btnHKEnabled.Image = My.Resources.Resources.imageHKEnable 'DirectCast(My.App.AppResources.GetObject("imageHKEnable"), Image)
		End If
		WSTSetHKToolTipText()
	End Sub
	Private Sub ShowSettingsWST()
		If My.App.WSTLoadOnOSStartup Then
			Me.checkboxLoadOnOSStartup.Checked = True
			Me.btnLoadOnOSStartupPath.Enabled = True
			Me.lblLoadOnOSStartupPath.Enabled = True
			Me.txbxLoadOnOSStartupArgs.Enabled = True
			Me.tipInfo.SetToolTip(Me.lblLoadOnOSStartupPath, My.App.WSTLoadOnOSStartupPath.Path + Chr(13) + "DoubleClick To Copy Full Path")
			Me.tipInfo.SetToolTip(Me.txbxLoadOnOSStartupArgs, IIf(String.IsNullOrEmpty(My.App.WSTLoadOnOSStartupPath.Arguments), "Arguments", My.App.WSTLoadOnOSStartupPath.Arguments + Chr(13) + "DoubleClick To Copy Arguments").ToString)
		Else
			Me.checkboxLoadOnOSStartup.Checked = False
			Me.btnLoadOnOSStartupPath.Enabled = False
			Me.lblLoadOnOSStartupPath.Enabled = False
			Me.txbxLoadOnOSStartupArgs.Enabled = False
			Me.tipInfo.SetToolTip(Me.lblLoadOnOSStartupPath, Nothing)
			Me.tipInfo.SetToolTip(Me.txbxLoadOnOSStartupArgs, Nothing)
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
		If My.App.WSTShowTaskManager Then
			Me.checkboxWSTShowTaskManager.Checked = True
			Me.btnWSTTaskManager.Enabled = True
			Me.lblWSTTaskManagerPath.Enabled = True
			Me.txbxWSTTaskManagerArgs.Enabled = True
			Me.tipInfo.SetToolTip(Me.lblWSTTaskManagerPath, My.App.WSTTaskManager.Path + Chr(13) + "DoubleClick To Copy Full Path")
			Me.tipInfo.SetToolTip(Me.txbxWSTTaskManagerArgs, IIf(String.IsNullOrEmpty(My.App.WSTTaskManager.Arguments), "Arguments", My.App.WSTTaskManager.Arguments + Chr(13) + "DoubleClick To Copy Arguments").ToString)
		Else
			Me.checkboxWSTShowTaskManager.Checked = False
			Me.btnWSTTaskManager.Enabled = False
			Me.lblWSTTaskManagerPath.Enabled = False
			Me.txbxWSTTaskManagerArgs.Enabled = False
			Me.tipInfo.SetToolTip(Me.lblWSTTaskManagerPath, Nothing)
			Me.tipInfo.SetToolTip(Me.txbxWSTTaskManagerArgs, Nothing)
		End If
		Me.lblWSTTaskManagerPath.Text = IIf(My.App.WSTTaskManager.Path.Contains("\"c), "...\", String.Empty).ToString + My.App.WSTTaskManager.Path.Split(CChar("\")).GetValue(My.App.WSTTaskManager.Path.Split(CChar("\")).Length - 1).ToString
		Me.txbxWSTTaskManagerArgs.Text = My.App.WSTTaskManager.Arguments
		Me.txbxWSTTaskManagerArgs.SelectionLength = 0
		Me.txbxWSTTaskManagerArgs.SelectionStart = Me.txbxWSTTaskManagerArgs.Text.Length
		If My.App.WSTShowCommandPrompt Then
			Me.checkboxWSTShowCommandPrompt.Checked = True
			Me.btnWSTCommandPrompt.Enabled = True
			Me.lblWSTCommandPromptPath.Enabled = True
			Me.txbxWSTCommandPromptArgs.Enabled = True
			Me.tipInfo.SetToolTip(Me.lblWSTCommandPromptPath, My.App.WSTCommandPrompt.Path + Chr(13) + "DoubleClick To Copy Full Path")
			Me.tipInfo.SetToolTip(Me.txbxWSTCommandPromptArgs, IIf(String.IsNullOrEmpty(My.App.WSTCommandPrompt.Arguments), "Arguments", My.App.WSTCommandPrompt.Arguments + Chr(13) + "DoubleClick To Copy Arguments").ToString)
		Else
			Me.checkboxWSTShowCommandPrompt.Checked = False
			Me.btnWSTCommandPrompt.Enabled = False
			Me.lblWSTCommandPromptPath.Enabled = False
			Me.txbxWSTCommandPromptArgs.Enabled = False
			Me.tipInfo.SetToolTip(Me.lblWSTCommandPromptPath, Nothing)
			Me.tipInfo.SetToolTip(Me.txbxWSTCommandPromptArgs, Nothing)
		End If
		Me.lblWSTCommandPromptPath.Text = IIf(My.App.WSTCommandPrompt.Path.Contains("\"c), "...\", String.Empty).ToString + My.App.WSTCommandPrompt.Path.Split(CChar("\")).GetValue(My.App.WSTCommandPrompt.Path.Split(CChar("\")).Length - 1).ToString
		Me.txbxWSTCommandPromptArgs.Text = My.App.WSTCommandPrompt.Arguments
		Me.txbxWSTCommandPromptArgs.SelectionLength = 0
		Me.txbxWSTCommandPromptArgs.SelectionStart = Me.txbxWSTCommandPromptArgs.Text.Length
		If My.App.WSTShowHLMenu Then : Me.checkboxWSTShowHLMenu.Checked = True
		Else : Me.checkboxWSTShowHLMenu.Checked = False
		End If
		If My.App.WSTShowHLTray Then : Me.checkboxWSTShowHLTray.Checked = True
		Else : Me.checkboxWSTShowHLTray.Checked = False
		End If
		If My.App.HLStartUp Then : Me.checkboxWSTHLStartUp.Checked = True
		Else : Me.checkboxWSTHLStartUp.Checked = False
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
		If My.App.WSTShowStopWatch Then : Me.checkboxWSTShowStopWatch.Checked = True
		Else : Me.checkboxWSTShowStopWatch.Checked = False
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
		WSTSetHKToolTipText()
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
			'Me.tipInfo.SetToolTip(Me.btnACAlarmSet, "Alarm Set for " + My.App.ACAlarmTime.ToString.Substring(0, My.App.ACAlarmTime.ToString.Length - 3))
			Dim alarmText As String = My.App.ACAlarmTime.ToString()
			Me.tipInfo.SetToolTip(Me.btnACAlarmSet, String.Concat("Alarm Set for ", alarmText.AsSpan(0, alarmText.Length - 3)))
		Else
			Me.btnACAlarmSet.Text = "Alarm InActive"
			Me.btnACAlarmSet.Font = New Font(Me.Font, FontStyle.Regular)
			Me.btnACAlarmSet.ForeColor = Color.Maroon
			'Me.tipInfo.SetToolTip(Me.btnACAlarmSet, "Activate Alarm for " + My.App.ACAlarmTime.ToString.Substring(0, My.App.ACAlarmTime.ToString.Length - 3))
			Dim alarmText As String = My.App.ACAlarmTime.ToString()
			Me.tipInfo.SetToolTip(Me.btnACAlarmSet, String.Concat("Activate Alarm for ", alarmText.AsSpan(0, alarmText.Length - 3)))
		End If
		Me.textboxACAlarmTime.Text = My.App.ACAlarmTime.ToString().Substring(0, My.App.ACAlarmTime.ToString().Length - 3)
		If My.App.ACAlarmRecurring Then : Me.checkboxACAlarmRecurring.Checked = True
		Else : Me.checkboxACAlarmRecurring.Checked = False
		End If
		If My.App.ACAlarmChimePath = "" Then
			Me.lblACAlarmChimePath.Text = "Default Chime"
			Me.tipInfo.SetToolTip(Me.lblACAlarmChimePath, "Use Built-In Chime")
		Else
			Me.lblACAlarmChimePath.Text = "...\" + My.App.ACAlarmChimePath.Split(CChar("\"))(My.App.ACAlarmChimePath.Split(CChar("\")).Length - 1)
			Me.tipInfo.SetToolTip(Me.lblACAlarmChimePath, My.App.ACAlarmChimePath)
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
			Me.tipInfo.SetToolTip(Me.lblACTopHourChimePath, "Use Built-In Chime")
		Else
			Me.lblACTopHourChimePath.Text = "...\" + My.App.ACTopHourChimePath.Split(CChar("\"))(My.App.ACTopHourChimePath.Split(CChar("\")).Length - 1)
			Me.tipInfo.SetToolTip(Me.lblACTopHourChimePath, My.App.ACTopHourChimePath)
		End If
		Select Case My.App.ACTopHourChimeType
			Case My.App.ACChimeType.Simple : Me.radiobtnACTopHourChimeSimple.Checked = True
			Case My.App.ACChimeType.Extended : Me.radiobtnACTopHourChimeExtended.Checked = True
			Case My.App.ACChimeType.HourTick : Me.radiobtnACTopHourChimeHourTick.Checked = True
		End Select
		If My.App.ACOffHourChimePath = "" Then
			Me.lblACOffHourChimePath.Text = "Default Chime"
			Me.tipInfo.SetToolTip(Me.lblACOffHourChimePath, "Use Built-In Chime")
		Else
			Me.lblACOffHourChimePath.Text = "...\" + My.App.ACOffHourChimePath.Split(CChar("\")).GetValue(My.App.ACOffHourChimePath.Split(CChar("\")).Length - 1).ToString
			Me.tipInfo.SetToolTip(Me.lblACOffHourChimePath, My.App.ACOffHourChimePath)
		End If
	End Sub
	Private Sub ShowSettingsHL()
		HLUpdateEditType()
		Me.lvHL.Clear()
		Me.lvHL.Groups.Clear()
		Me.panelHLEdit.Visible = False
		Me.lvHL.Visible = True
		Me.checkboxHLShowMenuIcons.Checked = My.App.HLShowMenuIcons
		Me.checkboxHLShowToolTips.Checked = My.App.HLShowToolTips
		Me.comboboxHLStartUpMode.SelectedIndex = My.App.HLStartUpMode
		Me.comboboxHLGroupMode.SelectedIndex = My.App.HLGroupMode
		Me.comboboxHLHotKeyMode.SelectedIndex = My.App.HLHotKeyMode
		Me.textboxHLLoadTimeOut.Text = My.App.HLLoadTimeOut.ToString
		Me.textboxHLCloseTimeOut.Text = My.App.HLCloseTimeOut.ToString
		Me.textboxHLStartUpDelay.Text = My.App.HLStartUpDelay.ToString
		Me.textboxHLName.ResetText()
		Me.textboxHLDescription.ResetText()
		Me.textboxHLLink.ResetText()
		Me.textboxHLArguments.ResetText()
		Me.textboxHLWorkingDirectory.ResetText()
		Me.checkboxHLSingleInstance.Checked = False
		Me.checkboxHLUseAlternateStartMethod.Checked = False
		Me.textboxHLUseAlternateStartTimeOut.Text = "0"
		'Me.checkboxHLUseAlternateCloseMethod.Checked = False
		Me.checkboxHLHideInMenu.Checked = False
		Me.checkboxHLDisabled.Checked = False
		Me.comboboxHLGroup.Items.Clear()
		Me.comboboxHLType.Items.Clear()
		Me.comboboxHLWindowState.SelectedIndex = -1
		Me.comboboxHLPriority.SelectedIndex = -1
		Me.comboboxHLHotKey.SelectedIndex = -1
		'Me.comboboxHLCloseAppProcessList.Items.Clear()
		'Me.listboxHLCloseAppList.Items.Clear()
		Dim groups As New Collections.Generic.List(Of String) From {
			""}
		Me.lvHL.Groups.Add("", "Main Menu")
		Me.comboboxHLGroup.Items.Add("Main Menu")
		For Each link As My.App.HLItemType In My.App.HLData
			If link.Type = My.App.HLType.Group Then
				groups.Add(link.Name)
				Me.lvHL.Groups.Add(link.Name, link.Name)
				Me.comboboxHLGroup.Items.Add(link.Name)
			End If
		Next
		For Each item As String In My.App.GetEnumMembers(My.App.HLType.Auto) : Me.comboboxHLType.Items.Add(item)
		Next
		For index As Integer = 0 To My.App.HLData.Count - 1
			Dim link As My.App.HLItemType = My.App.HLData.Item(index)
			Dim item As New ListViewItem With {
				.Group = Me.lvHL.Groups.Item(groups.IndexOf(link.Group)),
				.Font = New Font(Me.Font, FontStyle.Regular)}
			If link.HideInMenu Then : item.ForeColor = Color.LightGray
			ElseIf Not link.Type = My.App.HLType.Separator Then : item.ForeColor = Color.Teal
			End If
			If link.Disabled Then : item.Font = New Font(item.Font, FontStyle.Strikeout)
			ElseIf Not link.Type = My.App.HLType.Separator Then : item.Font = New Font(item.Font, FontStyle.Bold)
			End If
			'			If link.Name.Length > 17 Then
			'				item.Text = link.Name.Substring(0, 17)
			'				item.ToolTipText = link.Name
			'			Else : item.Text = link.Name
			'			End If
			item.Text = link.Name
			If Not String.IsNullOrEmpty(item.ToolTipText) And Not String.IsNullOrEmpty(link.Description) Then item.ToolTipText += Chr(13)
			item.ToolTipText += link.Description
			Select Case link.Type
				Case My.App.HLType.Auto, My.App.HLType.Application : item.ImageKey = "imageHLApp"
				Case My.App.HLType.Script : item.ImageKey = "imageHLScript"
				Case My.App.HLType.Document : item.ImageKey = "imageHLDoc"
				Case My.App.HLType.WebLink : item.ImageKey = "imageHLWeb"
				Case My.App.HLType.Group : item.ImageKey = "imageHLGroup"
				Case My.App.HLType.Separator
					item.ImageKey = "imageHLSeparator"
					item.Text = "Separator"
			End Select
			item.Tag = index
			Me.lvHL.Items.Add(item)
		Next
		If HLScrollIndex > Me.lvHL.Items.Count - 1 Then HLScrollIndex = Me.lvHL.Items.Count - 1
		If Me.lvHL.Items.Count > 0 Then Try : Me.lvHL.EnsureVisible(HLScrollIndex + 1) : Catch : Me.lvHL.EnsureVisible(HLScrollIndex) : End Try
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
					Case Me.notifyiconHL.Tag.ToString : HCPerformAction(My.App.HCHLMiddle)
					Case Else : HCPerformAction(My.App.HCWLMiddle, CType(sender, NotifyIcon).Tag)
				End Select
			Case MouseButtons.Right
				Select Case senderName
					Case Me.notifyiconWST.Tag.ToString : HCPerformAction(My.App.HCWSTRight)
					Case Me.notifyiconWSTScreenSaver.Tag.ToString : HCPerformAction(My.App.HCWSTScreenSaverRight)
					Case Me.notifyiconHL.Tag.ToString : HCPerformAction(My.App.HCHLRight)
					Case Else : HCPerformAction(My.App.HCWLRight)
				End Select
		End Select
	End Sub
	Private Sub CMWSTOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmWST.Opening
		If Not My.App.HCWSTRight = My.App.HCAction.Menu Then e.Cancel = True
	End Sub
	Private Sub CMHLTrayOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
		If Not My.App.HCHLRight = My.App.HCAction.Menu Then e.Cancel = True
	End Sub
	Private Sub CMCBTrayOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
		If Not My.App.HCCBRight = My.App.HCAction.Menu Then e.Cancel = True
	End Sub
	Private Sub CMWSTSSOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmWSTScreenSaver.Opening
		If Not My.App.HCWSTScreenSaverRight = My.App.HCAction.Menu Then e.Cancel = True
	End Sub
	Private Sub RadiobtnHCSettingsClick(ByVal sender As Object, ByVal e As EventArgs) Handles radiobtnHCWSTSS.Click, radiobtnHCWST.Click, radiobtnHCWL.Click, radiobtnHCHL.Click
		If radiobtnHCWST.Checked Then : HCShowActions(TrayTools.WorkSpaceTools)
		ElseIf radiobtnHCHL.Checked Then : HCShowActions(TrayTools.HotLinks)
		ElseIf radiobtnHCWL.Checked Then : HCShowActions(TrayTools.WinLinks)
		ElseIf radiobtnHCWSTSS.Checked Then : HCShowActions(TrayTools.ScreenSaver)
		End If
	End Sub
	Private Sub ComboboxHCSettingsSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboboxHCRight.SelectedIndexChanged, comboboxHCMiddle.SelectedIndexChanged, comboboxHCLeft.SelectedIndexChanged, comboboxHCDouble.SelectedIndexChanged
		Select Case CType(sender, ComboBox).Name
			Case Me.comboboxHCLeft.Name
				If Me.radiobtnHCWST.Checked Then : My.App.HCWSTLeft = CType(HCFindActionIndex(Me.comboboxHCLeft.SelectedItem.ToString), My.App.HCAction)
				ElseIf Me.radiobtnHCHL.Checked Then : My.App.HCHLLeft = CType(HCFindActionIndex(Me.comboboxHCLeft.SelectedItem.ToString), My.App.HCAction)
				ElseIf Me.radiobtnHCWL.Checked Then : My.App.HCWLLeft = CType(HCFindActionIndex(Me.comboboxHCLeft.SelectedItem.ToString), My.App.HCAction)
				ElseIf Me.radiobtnHCWSTSS.Checked Then : My.App.HCWSTScreenSaverLeft = CType(HCFindActionIndex(Me.comboboxHCLeft.SelectedItem.ToString), My.App.HCAction)
				End If
			Case Me.comboboxHCDouble.Name
				If Me.radiobtnHCWST.Checked Then : My.App.HCWSTDouble = CType(HCFindActionIndex(Me.comboboxHCDouble.SelectedItem.ToString), My.App.HCAction)
				ElseIf Me.radiobtnHCHL.Checked Then : My.App.HCHLDouble = CType(HCFindActionIndex(Me.comboboxHCDouble.SelectedItem.ToString), My.App.HCAction)
				ElseIf Me.radiobtnHCWL.Checked Then : My.App.HCWLDouble = CType(HCFindActionIndex(Me.comboboxHCDouble.SelectedItem.ToString), My.App.HCAction)
				ElseIf Me.radiobtnHCWSTSS.Checked Then : My.App.HCWSTScreenSaverDouble = CType(HCFindActionIndex(Me.comboboxHCDouble.SelectedItem.ToString), My.App.HCAction)
				End If
			Case Me.comboboxHCMiddle.Name
				If Me.radiobtnHCWST.Checked Then : My.App.HCWSTMiddle = CType(HCFindActionIndex(Me.comboboxHCMiddle.SelectedItem.ToString), My.App.HCAction)
				ElseIf Me.radiobtnHCHL.Checked Then : My.App.HCHLMiddle = CType(HCFindActionIndex(Me.comboboxHCMiddle.SelectedItem.ToString), My.App.HCAction)
				ElseIf Me.radiobtnHCWL.Checked Then : My.App.HCWLMiddle = CType(HCFindActionIndex(Me.comboboxHCMiddle.SelectedItem.ToString), My.App.HCAction)
				ElseIf Me.radiobtnHCWSTSS.Checked Then : My.App.HCWSTScreenSaverMiddle = CType(HCFindActionIndex(Me.comboboxHCMiddle.SelectedItem.ToString), My.App.HCAction)
				End If
			Case Me.comboboxHCRight.Name
				If Me.radiobtnHCWST.Checked Then : My.App.HCWSTRight = CType(HCFindActionIndex(Me.comboboxHCRight.SelectedItem.ToString), My.App.HCAction)
				ElseIf Me.radiobtnHCHL.Checked Then : My.App.HCHLRight = CType(HCFindActionIndex(Me.comboboxHCRight.SelectedItem.ToString), My.App.HCAction)
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
					Case Me.notifyiconHL.Tag.ToString : HCPerformAction(My.App.HCHLDouble)
					Case Else : Try : HCPerformAction(My.App.HCWLDouble, CType(HCSender, Integer)) : Catch : End Try
				End Select
			Else
				Select Case HCSender
					Case Me.notifyiconWST.Tag.ToString : HCPerformAction(My.App.HCWSTLeft)
					Case Me.notifyiconWSTScreenSaver.Tag.ToString : HCPerformAction(My.App.HCWSTScreenSaverLeft)
					Case Me.notifyiconHL.Tag.ToString : HCPerformAction(My.App.HCHLLeft)
					Case Else : Try : HCPerformAction(My.App.HCWLLeft, CType(HCSender, Integer)) : Catch : End Try
				End Select
			End If
			HCResetTimer()
		End If
	End Sub

	'Procedures
	Private Sub HCPerformAction(action As My.App.HCAction, Optional argument As Object = Nothing)
		Select Case action
			Case My.App.HCAction.HLNew
				If My.App.WSTShowHLMenu Or My.App.WSTShowHLTray Then
					Me.lvHL.SelectedItems.Clear()
					HLNew()
					Me.SelectTab(Me.tabpageHL, True)
				End If
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
			Case My.App.HCAction.WSTStopWatch : WSTStopWatchToggleWindow()
			Case My.App.HCAction.ShowSettings : SelectTab(Nothing)
			Case My.App.HCAction.ShowSettingsWST : SelectTab(Me.tabpageWST)
			Case My.App.HCAction.ShowSettingsHL : SelectTab(Me.tabpageHL)
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
			Case My.App.TrayTools.HotLinks
				Me.comboboxHCLeft.SelectedIndex = Me.comboboxHCLeft.FindStringExact(My.App.HCActions(My.App.HCHLLeft).Description)
				Me.comboboxHCDouble.SelectedIndex = Me.comboboxHCDouble.FindStringExact(My.App.HCActions(My.App.HCHLDouble).Description)
				Me.comboboxHCMiddle.SelectedIndex = Me.comboboxHCMiddle.FindStringExact(My.App.HCActions(My.App.HCHLMiddle).Description)
				Me.comboboxHCRight.SelectedIndex = Me.comboboxHCRight.FindStringExact(My.App.HCActions(My.App.HCHLRight).Description)
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
			Case My.App.TrayTools.OnlineAlerter
				Me.comboboxHCLeft.SelectedIndex = Me.comboboxHCLeft.FindStringExact(My.App.HCActions(My.App.HCOALeft).Description)
				Me.comboboxHCDouble.SelectedIndex = Me.comboboxHCDouble.FindStringExact(My.App.HCActions(My.App.HCOADouble).Description)
				Me.comboboxHCMiddle.SelectedIndex = Me.comboboxHCMiddle.FindStringExact(My.App.HCActions(My.App.HCOAMiddle).Description)
				Me.comboboxHCRight.SelectedIndex = Me.comboboxHCRight.FindStringExact(My.App.HCActions(My.App.HCOARight).Description)
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
	Private Sub TextboxHKPreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs) Handles textboxHKWSTTaskManager.PreviewKeyDown, textboxHKWSTStopWatch.PreviewKeyDown, textboxHKWSTScreenSaver.PreviewKeyDown, textboxHKWSTLockWorkSpace.PreviewKeyDown, textboxHKWSTCommandPrompt.PreviewKeyDown, textboxHKWSTClock.PreviewKeyDown, textboxHKWL.PreviewKeyDown, textboxHKHLH.PreviewKeyDown, textboxHKHLG.PreviewKeyDown, textboxHKHLF.PreviewKeyDown, textboxHKHLE.PreviewKeyDown, textboxHKHLD.PreviewKeyDown, textboxHKHLC.PreviewKeyDown, textboxHKHLB.PreviewKeyDown, textboxHKHLA.PreviewKeyDown
		Dim senderTextBox As TextBox = CType(sender, TextBox)
		Dim senderTag As My.App.HKType = CType(senderTextBox.Tag, My.App.HKType)
		If e.KeyData <> senderTag.Key Then

			'Setup New HotKey
			Dim newhotkey As New My.App.HKType
			Dim modifiers As Integer = 0
			Dim match As Boolean = False
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
			If Not CType(Me.textboxHKWSTLockWorkSpace.Tag, My.App.HKType).Key = My.App.HKWSTLockWorkSpace.Key Then HKInUse.Add(CType(Me.textboxHKWSTLockWorkSpace.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKWSTScreenSaver.Tag, My.App.HKType).Key = My.App.HKWSTScreenSaver.Key Then HKInUse.Add(CType(Me.textboxHKWSTScreenSaver.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKWSTStopWatch.Tag, My.App.HKType).Key = My.App.HKWSTStopWatch.Key Then HKInUse.Add(CType(Me.textboxHKWSTStopWatch.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKWSTClock.Tag, My.App.HKType).Key = My.App.HKWSTClock.Key Then HKInUse.Add(CType(Me.textboxHKWSTClock.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKWSTTaskManager.Tag, My.App.HKType).Key = My.App.HKWSTTaskManager.Key Then HKInUse.Add(CType(Me.textboxHKWSTTaskManager.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKWSTCommandPrompt.Tag, My.App.HKType).Key = My.App.HKWSTCommandPrompt.Key Then HKInUse.Add(CType(Me.textboxHKWSTCommandPrompt.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKHLA.Tag, My.App.HKType).Key = My.App.HKHLA.Key Then HKInUse.Add(CType(Me.textboxHKHLA.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKHLB.Tag, My.App.HKType).Key = My.App.HKHLB.Key Then HKInUse.Add(CType(Me.textboxHKHLB.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKHLC.Tag, My.App.HKType).Key = My.App.HKHLC.Key Then HKInUse.Add(CType(Me.textboxHKHLC.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKHLD.Tag, My.App.HKType).Key = My.App.HKHLD.Key Then HKInUse.Add(CType(Me.textboxHKHLD.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKHLE.Tag, My.App.HKType).Key = My.App.HKHLE.Key Then HKInUse.Add(CType(Me.textboxHKHLE.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKHLF.Tag, My.App.HKType).Key = My.App.HKHLF.Key Then HKInUse.Add(CType(Me.textboxHKHLF.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKHLG.Tag, My.App.HKType).Key = My.App.HKHLG.Key Then HKInUse.Add(CType(Me.textboxHKHLG.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKHLH.Tag, My.App.HKType).Key = My.App.HKHLH.Key Then HKInUse.Add(CType(Me.textboxHKHLH.Tag, My.App.HKType).Key)
			If Not CType(Me.textboxHKWL.Tag, My.App.HKType).Key = My.App.HKWL.Key Then HKInUse.Add(CType(Me.textboxHKWL.Tag, My.App.HKType).Key)
			For Each usedkey As Keys In HKInUse : If usedkey = newhotkey.Key Then match = True
			Next

			'Display New HotKey If Not Already In-Use
			If Not match Then
				senderTextBox.Font = New Font(Me.Font, FontStyle.Regular)
				senderTextBox.ForeColor = Color.Maroon
				senderTextBox.Text = e.KeyData.ToString
				senderTextBox.Tag = newhotkey
				Me.btnHKReset.Enabled = True
				Me.btnHKSet.Enabled = True
			End If
		End If
	End Sub
	Private Sub TextboxHKKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles textboxHKWSTTaskManager.KeyPress, textboxHKWSTStopWatch.KeyPress, textboxHKWSTScreenSaver.KeyPress, textboxHKWSTLockWorkSpace.KeyPress, textboxHKWSTCommandPrompt.KeyPress, textboxHKWSTClock.KeyPress, textboxHKWL.KeyPress, textboxHKHLH.KeyPress, textboxHKHLG.KeyPress, textboxHKHLF.KeyPress, textboxHKHLE.KeyPress, textboxHKHLD.KeyPress, textboxHKHLC.KeyPress, textboxHKHLB.KeyPress, textboxHKHLA.KeyPress
		e.Handled = True
	End Sub
	Private Sub BtnHKDisableClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHKWSTTaskManagerDisable.Click, btnHKWSTStopWatchDisable.Click, btnHKWSTScreenSaverDisable.Click, btnHKWSTLockWorkSpaceDisable.Click, btnHKWSTCommandPromptDisable.Click, btnHKWSTClockDisable.Click, btnHKWLDisable.Click, btnHKHLHDisable.Click, btnHKHLGDisable.Click, btnHKHLFDisable.Click, btnHKHLEDisable.Click, btnHKHLDDisable.Click, btnHKHLCDisable.Click, btnHKHLBDisable.Click, btnHKHLADisable.Click
		Dim senderTextBox As New TextBox
		Dim senderTag As New My.App.HKType
		Select Case CType(sender, Button).Name
			Case Me.btnHKWSTLockWorkSpaceDisable.Name
				senderTextBox = Me.textboxHKWSTLockWorkSpace
				senderTag = CType(Me.textboxHKWSTLockWorkSpace.Tag, My.App.HKType)
			Case Me.btnHKWSTScreenSaverDisable.Name
				senderTextBox = Me.textboxHKWSTScreenSaver
				senderTag = CType(Me.textboxHKWSTScreenSaver.Tag, My.App.HKType)
			Case Me.btnHKWSTStopWatchDisable.Name
				senderTextBox = Me.textboxHKWSTStopWatch
				senderTag = CType(Me.textboxHKWSTStopWatch.Tag, My.App.HKType)
			Case Me.btnHKWSTClockDisable.Name
				senderTextBox = Me.textboxHKWSTClock
				senderTag = CType(Me.textboxHKWSTClock.Tag, My.App.HKType)
			Case Me.btnHKWSTTaskManagerDisable.Name
				senderTextBox = Me.textboxHKWSTTaskManager
				senderTag = CType(Me.textboxHKWSTTaskManager.Tag, My.App.HKType)
			Case Me.btnHKWSTCommandPromptDisable.Name
				senderTextBox = Me.textboxHKWSTCommandPrompt
				senderTag = CType(Me.textboxHKWSTCommandPrompt.Tag, My.App.HKType)
			Case Me.btnHKHLADisable.Name
				senderTextBox = Me.textboxHKHLA
				senderTag = CType(Me.textboxHKHLA.Tag, My.App.HKType)
			Case Me.btnHKHLBDisable.Name
				senderTextBox = Me.textboxHKHLB
				senderTag = CType(Me.textboxHKHLB.Tag, My.App.HKType)
			Case Me.btnHKHLCDisable.Name
				senderTextBox = Me.textboxHKHLC
				senderTag = CType(Me.textboxHKHLC.Tag, My.App.HKType)
			Case Me.btnHKHLDDisable.Name
				senderTextBox = Me.textboxHKHLD
				senderTag = CType(Me.textboxHKHLD.Tag, My.App.HKType)
			Case Me.btnHKHLEDisable.Name
				senderTextBox = Me.textboxHKHLE
				senderTag = CType(Me.textboxHKHLE.Tag, My.App.HKType)
			Case Me.btnHKHLFDisable.Name
				senderTextBox = Me.textboxHKHLF
				senderTag = CType(Me.textboxHKHLF.Tag, My.App.HKType)
			Case Me.btnHKHLGDisable.Name
				senderTextBox = Me.textboxHKHLG
				senderTag = CType(Me.textboxHKHLG.Tag, My.App.HKType)
			Case Me.btnHKHLHDisable.Name
				senderTextBox = Me.textboxHKHLH
				senderTag = CType(Me.textboxHKHLH.Tag, My.App.HKType)
			Case Me.btnHKWLDisable.Name
				senderTextBox = Me.textboxHKWL
				senderTag = CType(Me.textboxHKWL.Tag, My.App.HKType)
		End Select

		Dim newhotkey As New My.App.HKType With {
			.Description = senderTag.Description,
			.WinID = senderTag.WinID,
			.Key = Keys.None,
			.KeyCode = 0,
			.KeyMod = 0}
		senderTextBox.Font = New Font(Me.Font, FontStyle.Regular)
		senderTextBox.ForeColor = Color.Maroon
		senderTextBox.Text = newhotkey.Key.ToString
		senderTextBox.Tag = newhotkey
		Me.btnHKReset.Enabled = True
		Me.btnHKSet.Enabled = True
		Me.btnHKSet.Focus()
	End Sub
	Private Sub BtnHKDisableEnter(ByVal sender As Object, ByVal e As EventArgs) Handles btnHKWSTTaskManagerDisable.Enter, btnHKWSTStopWatchDisable.Enter, btnHKWSTScreenSaverDisable.Enter, btnHKWSTLockWorkSpaceDisable.Enter, btnHKWSTCommandPromptDisable.Enter, btnHKWSTClockDisable.Enter, btnHKWLDisable.Enter, btnHKHLHDisable.Enter, btnHKHLGDisable.Enter, btnHKHLFDisable.Enter, btnHKHLEDisable.Enter, btnHKHLDDisable.Enter, btnHKHLCDisable.Enter, btnHKHLBDisable.Enter, btnHKHLADisable.Enter
		If Me.btnHKSet.Enabled Then : Me.btnHKSet.Focus()
		Else : Me.btnClose.Focus()
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
		If Not CType(Me.textboxHKWSTStopWatch.Tag, My.App.HKType).Key = My.App.HKWSTStopWatch.Key Then My.App.HKWSTStopWatch = CType(Me.textboxHKWSTStopWatch.Tag, My.App.HKType)
		If Not CType(Me.textboxHKWSTClock.Tag, My.App.HKType).Key = My.App.HKWSTClock.Key Then My.App.HKWSTClock = CType(Me.textboxHKWSTClock.Tag, My.App.HKType)
		If Not CType(Me.textboxHKWSTTaskManager.Tag, My.App.HKType).Key = My.App.HKWSTTaskManager.Key Then My.App.HKWSTTaskManager = CType(Me.textboxHKWSTTaskManager.Tag, My.App.HKType)
		If Not CType(Me.textboxHKWSTCommandPrompt.Tag, My.App.HKType).Key = My.App.HKWSTCommandPrompt.Key Then My.App.HKWSTCommandPrompt = CType(Me.textboxHKWSTCommandPrompt.Tag, My.App.HKType)
		If Not CType(Me.textboxHKHLA.Tag, My.App.HKType).Key = My.App.HKHLA.Key Then My.App.HKHLA = CType(Me.textboxHKHLA.Tag, My.App.HKType)
		If Not CType(Me.textboxHKHLB.Tag, My.App.HKType).Key = My.App.HKHLB.Key Then My.App.HKHLB = CType(Me.textboxHKHLB.Tag, My.App.HKType)
		If Not CType(Me.textboxHKHLC.Tag, My.App.HKType).Key = My.App.HKHLC.Key Then My.App.HKHLC = CType(Me.textboxHKHLC.Tag, My.App.HKType)
		If Not CType(Me.textboxHKHLD.Tag, My.App.HKType).Key = My.App.HKHLD.Key Then My.App.HKHLD = CType(Me.textboxHKHLD.Tag, My.App.HKType)
		If Not CType(Me.textboxHKHLE.Tag, My.App.HKType).Key = My.App.HKHLE.Key Then My.App.HKHLE = CType(Me.textboxHKHLE.Tag, My.App.HKType)
		If Not CType(Me.textboxHKHLF.Tag, My.App.HKType).Key = My.App.HKHLF.Key Then My.App.HKHLF = CType(Me.textboxHKHLF.Tag, My.App.HKType)
		If Not CType(Me.textboxHKHLG.Tag, My.App.HKType).Key = My.App.HKHLG.Key Then My.App.HKHLG = CType(Me.textboxHKHLG.Tag, My.App.HKType)
		If Not CType(Me.textboxHKHLH.Tag, My.App.HKType).Key = My.App.HKHLH.Key Then My.App.HKHLH = CType(Me.textboxHKHLH.Tag, My.App.HKType)
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
			Case My.App.HKWSTStopWatch.WinID
				If My.App.WSTShowStopWatch Then
					If Me.frmWSTStopWatch.Visible Then WSTToggleStopWatch(True)
					WSTStopWatchToggleWindow()
				End If
			Case My.App.HKWSTClock.WinID : WSTShowClock()
			Case My.App.HKWSTTaskManager.WinID : WSTTaskManagerToggle()
			Case My.App.HKWSTCommandPrompt.WinID : My.App.StartFile(My.App.WSTCommandPrompt)
			Case My.App.HKHLA.WinID : HLStartLinksByHotKey(My.App.HLHotKey.A)
			Case My.App.HKHLB.WinID : HLStartLinksByHotKey(My.App.HLHotKey.B)
			Case My.App.HKHLC.WinID : HLStartLinksByHotKey(My.App.HLHotKey.C)
			Case My.App.HKHLD.WinID : HLStartLinksByHotKey(My.App.HLHotKey.D)
			Case My.App.HKHLE.WinID : HLStartLinksByHotKey(My.App.HLHotKey.E)
			Case My.App.HKHLF.WinID : HLStartLinksByHotKey(My.App.HLHotKey.F)
			Case My.App.HKHLG.WinID : HLStartLinksByHotKey(My.App.HLHotKey.G)
			Case My.App.HKHLH.WinID : HLStartLinksByHotKey(My.App.HLHotKey.H)
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

	'Declarations
	Private notifyiconWST As NotifyIcon
	Private notifyiconWSTScreenSaver As NotifyIcon
	Private WithEvents TimerWSTStopWatch As New Timer
	Private WithEvents TimerWSTStopWatchReset As New Timer
	Private frmWSTClock As WSTClock
	Private frmWSTStopWatch As WSTStopWatch
	Private WSTStopWatch As DateTime
	Private openfiledialogWST As New OpenFileDialog

	'Control Events
	Private Sub CMIWSTCancelStartUpMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTCancelStartUp.MouseUp
		If e.Button = MouseButtons.Left Then
			If Me.TimerHLStartUp.Enabled Then Me.TimerHLStartUp.Stop()

			If Me.TimerWLStartUp.Enabled Then
				Me.TimerWLStartUp.Stop()
				WLStartUp = False
				WLClose(True)
				WLSetSettingsState(True)
			End If
			UpdateWSTCancelState()
		End If
	End Sub
	Private Sub CMIWSTTaskManagerMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTTaskManager.MouseUp
		Select Case e.Button
			Case MouseButtons.Left : My.App.StartFile(My.App.WSTTaskManager)
			Case MouseButtons.Right : WSTTaskManagerToggle()
		End Select
	End Sub
	Private Sub CMIWSTCommandPromptMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTCommandPrompt.MouseUp
		If e.Button = MouseButtons.Left Then My.App.StartFile(My.App.WSTCommandPrompt)
	End Sub
	Private Sub CMIWSTClockMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTClock.MouseUp
		If e.Button = MouseButtons.Left Then WSTShowClock()
	End Sub
	Private Sub CMIWSTStopWatchMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTStopWatch.MouseUp
		Select Case e.Button
			Case MouseButtons.Left : WSTToggleStopWatch()
			Case MouseButtons.Right : WSTStopWatchToggleWindow()
		End Select
	End Sub
	Private Sub CMIWSTLockMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTLock.MouseUp
		If e.Button = MouseButtons.Left Then WSTLockWorkSpace()
	End Sub
	Private Sub CMIWSTLogOffMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTLogOff.MouseUp
		If e.Button = MouseButtons.Left Then
			My.App.WriteToLog(My.App.Tools.WorkSpaceTools, "System Log Off Initiated")
			My.App.ShowBalloon(My.App.Tools.WorkSpaceTools, "Logging Off...", My.App.BalloonDelay.WaitForEver)
			'Mentalis.Utilities.WindowsController.ExitWindows(Mentalis.Utilities.RestartOptions.LogOff, False)
			System.Diagnostics.Process.Start("ShutDown", "/l")
		End If
	End Sub
	Private Sub CMIWSTSleepMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTSleep.MouseUp
		If e.Button = MouseButtons.Left Then
			My.App.ShowBalloon(My.App.Tools.WorkSpaceTools, "Standing By...", My.App.BalloonDelay.Medium)
			System.Windows.Forms.Application.SetSuspendState(System.Windows.Forms.PowerState.Suspend, False, False)
		End If
	End Sub
	Private Sub CMIWSTHibernateMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTHibernate.MouseUp
		If e.Button = MouseButtons.Left Then
			My.App.ShowBalloon(My.App.Tools.WorkSpaceTools, "Hibernating...", My.App.BalloonDelay.Medium)
			System.Windows.Forms.Application.SetSuspendState(System.Windows.Forms.PowerState.Hibernate, False, False)
		End If
	End Sub
	Private Sub CMIWSTReStartMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTReStart.MouseUp
		If e.Button = MouseButtons.Left Then
			My.App.WriteToLog(My.App.Tools.WorkSpaceTools, "System ReStart Initiated")
			My.App.ShowBalloon(My.App.Tools.WorkSpaceTools, "ReStarting...", My.App.BalloonDelay.WaitForEver)
			'Mentalis.Utilities.WindowsController.ExitWindows(Mentalis.Utilities.RestartOptions.Reboot, False)
			System.Diagnostics.Process.Start("ShutDown", "/r /t 0")
		End If
	End Sub
	Private Sub CMIWSTShutDownMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiWSTShutDown.MouseUp
		If e.Button = MouseButtons.Left Then
			My.App.WriteToLog(My.App.Tools.WorkSpaceTools, "System Shut Down Initiated")
			My.App.ShowBalloon(My.App.Tools.WorkSpaceTools, "Shutting Down...", My.App.BalloonDelay.WaitForEver)
			'Mentalis.Utilities.WindowsController.ExitWindows(Mentalis.Utilities.RestartOptions.ShutDown, False)
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
	Private Sub BtnWSTTaskManagerMouseUp(sender As Object, e As MouseEventArgs) Handles btnWSTTaskManager.MouseUp
		Select Case e.Button
			Case MouseButtons.Left
				Me.openfiledialogWST.InitialDirectory = My.App.WSTTaskManager.Path
				If Me.openfiledialogWST.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK AndAlso Not String.IsNullOrEmpty(Me.openfiledialogWST.FileName) Then
					My.App.WSTTaskManager.Path = Me.openfiledialogWST.FileName
					ShowSettings(My.App.Tools.WorkSpaceTools)
				End If
			Case MouseButtons.Right
				My.App.WSTTaskManager = New My.App.FileType(My.App.WSTTaskManagerDefault.Path, My.App.WSTTaskManagerDefault.Arguments)
				ShowSettingsWST()
		End Select
	End Sub
	Private Sub BtnWSTCommandPromptMouseUp(sender As Object, e As MouseEventArgs) Handles btnWSTCommandPrompt.MouseUp
		Select Case e.Button
			Case MouseButtons.Left
				Me.openfiledialogWST.InitialDirectory = My.App.WSTCommandPrompt.Path
				If Me.openfiledialogWST.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK AndAlso Not String.IsNullOrEmpty(Me.openfiledialogWST.FileName) Then
					My.App.WSTCommandPrompt.Path = Me.openfiledialogWST.FileName
					ShowSettings(My.App.Tools.WorkSpaceTools)
				End If
			Case MouseButtons.Right
				My.App.WSTCommandPrompt = New My.App.FileType(My.App.WSTCommandPromptDefault.Path, My.App.WSTCommandPromptDefault.Arguments)
				ShowSettingsWST()
		End Select
	End Sub
	Private Sub CheckboxWSTEnabledClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWSTEnabled.Click
		My.App.WSTEnabled = Not My.App.WSTEnabled
		ShowTools()
	End Sub
	Private Sub CheckboxWSTShowClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWSTShowWLMenu.Click, checkboxWSTShowTaskManager.Click, checkboxWSTShowStopWatch.Click, checkboxWSTShowSleep.Click, checkboxWSTShowShutDown.Click, checkboxWSTShowScreenSaverEnabled.Click, checkboxWSTShowScreenSaverActivate.Click, checkboxWSTShowReStart.Click, checkboxWSTShowLogOff.Click, checkboxWSTShowLog.Click, checkboxWSTShowLockWorkSpace.Click, checkboxWSTShowHLMenu.Click, checkboxWSTShowHibernate.Click, checkboxWSTShowHelp.Click, checkboxWSTShowCommandPrompt.Click, checkboxWSTShowClock.Click, checkboxWSTShowAC.Click
		Select Case CType(sender, CheckBox).Name
			Case checkboxWSTShowHLMenu.Name
				WSTShowHLMenu = Not WSTShowHLMenu
				If WSTShowHLMenu Then ShowHL()
				HLSetSettingsTab()
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
			Case checkboxWSTShowTaskManager.Name
				WSTShowTaskManager = Not WSTShowTaskManager
				ShowSettingsWST()
			Case checkboxWSTShowCommandPrompt.Name
				WSTShowCommandPrompt = Not WSTShowCommandPrompt
				ShowSettingsWST()
			Case checkboxWSTShowScreenSaverActivate.Name : WSTShowSSActivate = Not WSTShowSSActivate
			Case checkboxWSTShowScreenSaverEnabled.Name : WSTShowSSEnabled = Not WSTShowSSEnabled
			Case checkboxWSTShowClock.Name
				App.WSTShowClock = Not App.WSTShowClock
				WSTClockSet()
			Case checkboxWSTShowAC.Name
				WSTShowAC = Not WSTShowAC
				ACSet()
			Case checkboxWSTShowStopWatch.Name
				If WSTShowStopWatch Then
					WSTShowStopWatch = False
					WSTStopWatchToggleWindow()
					WSTToggleStopWatch()
					WSTStopWatchReSet()
				Else : WSTShowStopWatch = True
				End If
				WSTStopWatchSet()
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
	Private Sub CheckboxWSTShowIconClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWSTSSToolEnabled.Click, checkboxWSTShowWLTray.Click, checkboxWSTShowScreenSaverIcon.Click, checkboxWSTShowHLTray.Click
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
			Case checkboxWSTShowHLTray.Name
				WSTShowHLTray = Not WSTShowHLTray
				If WSTShowHLTray Then ShowHL()
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
	Private Sub CheckboxWSTHLStartUpClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxWSTHLStartUp.Click
		My.App.HLStartUp = Not My.App.HLStartUp
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
	Private Sub TxbxWSTTaskManagerArgsValidated(sender As Object, e As EventArgs) Handles txbxWSTTaskManagerArgs.Validated
		If String.IsNullOrEmpty(Me.txbxWSTTaskManagerArgs.Text) Then : My.App.WSTTaskManager.Arguments = String.Empty
		Else : My.App.WSTTaskManager.Arguments = Me.txbxWSTTaskManagerArgs.Text
		End If
		ShowSettingsWST()
		Me.txbxWSTTaskManagerArgs.SelectAll()
	End Sub
	Private Sub TxbxWSTCommandPromptArgsValidated(sender As Object, e As EventArgs) Handles txbxWSTCommandPromptArgs.Validated
		If String.IsNullOrEmpty(Me.txbxWSTCommandPromptArgs.Text) Then : My.App.WSTCommandPrompt.Arguments = String.Empty
		Else : My.App.WSTCommandPrompt.Arguments = Me.txbxWSTCommandPromptArgs.Text
		End If
		ShowSettingsWST()
		Me.txbxWSTCommandPromptArgs.SelectAll()
	End Sub
	Private Sub TxbxWSTCopyDoubleClick(sender As Object, e As EventArgs) Handles txbxWSTTaskManagerArgs.DoubleClick, txbxWSTCommandPromptArgs.DoubleClick, txbxLoadOnOSStartupArgs.DoubleClick, lblWSTTaskManagerPath.DoubleClick, lblWSTCommandPromptPath.DoubleClick, lblLoadOnOSStartupPath.DoubleClick
		If sender Is Me.lblWSTTaskManagerPath Then : If Not String.IsNullOrEmpty(My.App.WSTTaskManager.Path) Then My.Computer.Clipboard.SetText(My.App.WSTTaskManager.Path)
		ElseIf sender Is Me.txbxWSTTaskManagerArgs Then : If Not String.IsNullOrEmpty(My.App.WSTTaskManager.Arguments) Then My.Computer.Clipboard.SetText(My.App.WSTTaskManager.Arguments)
		ElseIf sender Is Me.lblWSTCommandPromptPath Then : If Not String.IsNullOrEmpty(My.App.WSTCommandPrompt.Path) Then My.Computer.Clipboard.SetText(My.App.WSTCommandPrompt.Path)
		ElseIf sender Is Me.txbxWSTCommandPromptArgs Then : If Not String.IsNullOrEmpty(My.App.WSTCommandPrompt.Arguments) Then My.Computer.Clipboard.SetText(My.App.WSTCommandPrompt.Arguments)
		ElseIf sender Is Me.lblLoadOnOSStartupPath Then : If Not String.IsNullOrEmpty(My.App.WSTLoadOnOSStartupPath.Path) Then My.Computer.Clipboard.SetText(My.App.WSTLoadOnOSStartupPath.Path)
		ElseIf sender Is Me.txbxLoadOnOSStartupArgs Then : If Not String.IsNullOrEmpty(My.App.WSTLoadOnOSStartupPath.Arguments) Then My.Computer.Clipboard.SetText(My.App.WSTLoadOnOSStartupPath.Arguments)
		End If
	End Sub

	'Handlers
	Private Sub TimerWSTStopWatchTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerWSTStopWatch.Tick
		Dim t As TimeSpan = My.Computer.Clock.LocalTime.Subtract(WSTStopWatch)
		Dim h As String = Int(t.TotalHours).ToString
		If h.Length = 1 Then h = "0" + h
		Dim m As String = t.Minutes.ToString
		If m.Length = 1 Then m = "0" + m
		Dim s As String = t.Seconds.ToString
		If s.Length = 1 Then s = "0" + s
		Dim ms As String = t.Milliseconds.ToString
		Select Case ms.Length
			Case 1 : ms = "00" + ms
			Case 2 : ms = "0" + ms
		End Select
		Me.cmiWSTStopWatch.Text = h + ":" + m + ":" + s + "." + ms
		If frmWSTStopWatch.Visible Then frmWSTStopWatch.labelStopWatch.Text = h + ":" + m + ":" + s + "." + ms
		If Int(t.TotalHours) = 36 Then WSTToggleStopWatch()
	End Sub
	Private Sub TimerWSTStopWatchResetTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerWSTStopWatchReset.Tick
		WSTStopWatchReSet()
	End Sub

	'Procedures
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
	Friend Sub WSTStopWatchToggleWindow()
		If My.App.WSTShowStopWatch Then
			If frmWSTStopWatch.Visible Then : frmWSTStopWatch.Hide()
			Else
				If Not Me.TimerWSTStopWatch.Enabled Then WSTToggleStopWatch()
				frmWSTStopWatch.Show()
			End If
			UpdateWST()
		Else : If frmWSTStopWatch.Visible Then frmWSTStopWatch.Hide()
		End If
	End Sub
	Friend Sub WSTToggleStopWatch(Optional forcestop As Boolean = False)
		If My.App.WSTShowStopWatch Then
			If Me.TimerWSTStopWatch.Enabled Then
				Me.TimerWSTStopWatch.Stop()
				Me.cmiWSTStopWatch.ResetForeColor()
				frmWSTStopWatch.labelStopWatch.ResetForeColor()

				If Not Me.TimerWSTStopWatchReset.Enabled Then
					Me.TimerWSTStopWatchReset.Start()
					Debug.Print("WSTStopWatchToggle: timerStopWatchReset Started")
				End If
			ElseIf Not forcestop Then
				Me.TimerWSTStopWatchReset.Stop()
				WSTStopWatch = My.Computer.Clock.LocalTime
				Me.cmiWSTStopWatch.Font = New Font(Me.Font, FontStyle.Bold)
				Me.cmiWSTStopWatch.ForeColor = Color.Maroon
				frmWSTStopWatch.labelStopWatch.ForeColor = Color.Maroon
				Me.TimerWSTStopWatch.Start()
			End If
			UpdateWST()
		Else
			If Me.TimerWSTStopWatch.Enabled Then
				Me.TimerWSTStopWatch.Stop()
				Me.cmiWSTStopWatch.ResetForeColor()
			End If
		End If
	End Sub
	Friend Sub UpdateWST()
		'Settings Window
		Me.tipInfo.SetToolTip(Me.btnLog, "Log" + Chr(13) + "RightClick = Show Maximized")
		If ErrorWarning Then Me.tipInfo.SetToolTip(Me.btnLog, Me.tipInfo.GetToolTip(Me.btnLog) + Chr(13) + "An Application Error Has Occured. View Log For Details.")
		'WorkSpace Tools
		If My.App.WSTEnabled Then
			Me.notifyiconWST.Icon = My.Resources.Resources.iconWST 'CType(My.App.AppResources.GetObject("iconWST"), Icon)
			Me.notifyiconWST.Text = My.App.WSTName
			Me.cmiWSTLog.ToolTipText = "RightClick = Show Maximized"
			Me.cmiWSTLog.ResetFont()
			Me.cmiWSTLog.ResetForeColor()
			Me.notifyiconHL.Text = My.App.HLName
			If ErrorWarning Then
				Me.notifyiconWST.Text += Chr(13) + "** ERROR **"
				Me.notifyiconWST.Icon = My.Resources.Resources.iconWSTAlert 'CType(My.App.AppResources.GetObject("iconWSTAlert"), Icon)
				Me.cmiWSTLog.Font = New Font(Me.Font, FontStyle.Bold)
				Me.cmiWSTLog.ForeColor = Color.Firebrick
				Me.cmiWSTLog.ToolTipText += Chr(13) + "An Application Error Has Occured. View Log For Details."
			End If
			If TimerHLStartUp.Enabled Or WLStartUp Then Me.notifyiconWST.Text += Chr(13) + "StartUp Pending..."
			If My.App.WSTSSToolEnabled Then
				If WSTSSEnabled Then : If My.App.WSTShowSSEnabled Then Me.notifyiconWST.Text += Chr(13) + "Screen Saver ENABLED"
				Else : If My.App.WSTShowSSEnabled Then Me.notifyiconWST.Text += Chr(13) + "Screen Saver DISABLED"
				End If
			End If
			If ACAlarmTripped And ACChimeCount = Byte.MaxValue Then
				Me.notifyiconWST.Text += Chr(13) + "** ALARM **"
				Me.notifyiconWST.Icon = My.Resources.Resources.iconWSTAlert 'CType(My.App.AppResources.GetObject("iconWSTAlert"), Icon)
				Me.cmiWSTAC.ToolTipText = Me.tipInfo.GetToolTip(Me.btnACAlarmCancel) '"THE ALARM HAS SOUNDED"
				Me.cmiWSTAC.Checked = True
				Me.cmiWSTAC.Font = New Font(Me.Font, FontStyle.Bold)
			ElseIf ACAlarmActive Then
				'Me.notifyiconWST.Text += Chr(13) + "Alarm Set for " + My.App.ACAlarmTime.ToString.Substring(0, My.App.ACAlarmTime.ToString.Length - 3)
				'Me.cmiWSTAC.ToolTipText = "Alarm Set for " + My.App.ACAlarmTime.ToString.Substring(0, My.App.ACAlarmTime.ToString.Length - 3)
				Dim alarmText As String = My.App.ACAlarmTime.ToString()
				Dim prefix As String = String.Concat(Me.notifyiconWST.Text, ChrW(13), "Alarm Set for ")
				Me.notifyiconWST.Text = String.Concat(prefix, alarmText.AsSpan(0, alarmText.Length - 3))
				Me.cmiWSTAC.ToolTipText = String.Concat("Alarm Set for ", alarmText.AsSpan(0, alarmText.Length - 3))
				Me.cmiWSTAC.Checked = True
				Me.cmiWSTAC.Font = New Font(Me.Font, FontStyle.Regular)
			Else
				Me.cmiWSTAC.ToolTipText = Nothing
				Me.cmiWSTAC.Checked = False
				Me.cmiWSTAC.Font = New Font(Me.Font, FontStyle.Regular)
			End If
			If Me.frmWSTClock?.Visible Then : Me.cmiWSTClock.Checked = True
			Else : Me.cmiWSTClock.Checked = False
			End If
			If My.App.WSTShowStopWatch Then
				If Me.TimerWSTStopWatch.Enabled OrElse Me.frmWSTStopWatch?.Visible Then : Me.cmiWSTStopWatch.Checked = True
				Else : Me.cmiWSTStopWatch.Checked = False
				End If
				If Me.TimerWSTStopWatch.Enabled Then : Me.notifyiconWST.Text += Chr(13) + "StopWatch Running..."
				ElseIf WSTStopWatch <> DateTime.MinValue Then : Me.notifyiconWST.Text += Chr(13) + "StopWatch - " + Me.cmiWSTStopWatch.Text
				End If
			Else : Me.cmiWSTStopWatch.Checked = False
			End If
		End If
	End Sub
	Private Sub UpdateWSTCancelState()
		If Not TimerHLStartUp.Enabled And Not WLStartUp Then Me.cmiWSTCancelStartUp.Visible = False
		If Not BackgroundworkerAC.IsBusy Then Me.cmiWSTACAlarmCancel.Visible = False
		If Not TimerHLStartUp.Enabled And Not WLStartUp And Not BackgroundworkerAC.IsBusy Then Me.cmseparatorWSTCancel.Visible = False
		UpdateWST()
	End Sub
	Private Sub ShowWST()
		'Main Section
		If My.App.WSTShowTaskManager Then : Me.cmiWSTTaskManager.Visible = True
		Else : Me.cmiWSTTaskManager.Visible = False
		End If
		If My.App.WSTShowCommandPrompt Then : Me.cmiWSTCommandPrompt.Visible = True
		Else : Me.cmiWSTCommandPrompt.Visible = False
		End If
		If My.App.WSTSSToolEnabled And My.App.WSTShowSSEnabled Then : Me.cmiWSTScreenSaverEnabled.Visible = True
		Else : Me.cmiWSTScreenSaverEnabled.Visible = False
		End If
		If My.App.WSTSSToolEnabled And My.App.WSTShowSSActivate Then : Me.cmiWSTScreenSaverActivate.Visible = True
		Else : Me.cmiWSTScreenSaverActivate.Visible = False
		End If
		If My.App.WSTShowHLMenu Then : Me.cmiWSTHLMenu.Visible = True
		Else : Me.cmiWSTHLMenu.Visible = False
		End If
		If My.App.WSTShowWLMenu Then
			If My.App.WSTShowTaskManager OrElse My.App.WSTShowCommandPrompt OrElse (My.App.WSTSSToolEnabled And My.App.WSTShowSSEnabled) OrElse (My.App.WSTSSToolEnabled And My.App.WSTShowSSActivate) OrElse My.App.WSTShowHLMenu Then : Me.cmseparatorWSTWLTop.Visible = True
			Else : Me.cmseparatorWSTWLTop.Visible = False
			End If
			If My.App.WSTShowClock OrElse My.App.WSTShowAC OrElse My.App.WSTShowStopWatch Then : Me.cmseparatorWSTWLBottom.Visible = True
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
		If My.App.WSTShowStopWatch Then : Me.cmiWSTStopWatch.Visible = True
		Else : Me.cmiWSTStopWatch.Visible = False
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
			If My.App.WSTShowTaskManager OrElse My.App.WSTShowCommandPrompt OrElse (My.App.WSTSSToolEnabled And My.App.WSTShowSSEnabled) OrElse (My.App.WSTSSToolEnabled And My.App.WSTShowSSActivate) OrElse My.App.WSTShowHLMenu _
				OrElse My.App.WSTShowClock OrElse My.App.WSTShowAC OrElse My.App.WSTShowStopWatch _
				Then : Me.cmseparatorWSTShutDownOptions.Visible = True
			Else : Me.cmseparatorWSTShutDownOptions.Visible = False
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
		If My.App.WSTShowTaskManager OrElse My.App.WSTShowCommandPrompt OrElse (My.App.WSTSSToolEnabled And My.App.WSTShowSSEnabled) OrElse (My.App.WSTSSToolEnabled And My.App.WSTShowSSActivate) OrElse My.App.WSTShowHLMenu _
			OrElse My.App.WSTShowClock OrElse My.App.WSTShowAC OrElse My.App.WSTShowStopWatch _
			OrElse My.App.WSTShowLockWorkSpace OrElse My.App.WSTShowLogOff OrElse My.App.WSTShowSleep OrElse My.App.WSTShowHibernate OrElse My.App.WSTShowReStart OrElse My.App.WSTShowShutDown _
			Then : Me.cmseparatorWSTSettings.Visible = True
		Else : Me.cmseparatorWSTSettings.Visible = False
		End If
	End Sub
	Private Sub WSTSetHKToolTipText()
		Me.cmiWSTTaskManager.ToolTipText = "LeftClick = Start/Show" + Chr(13) + "RightClick = Toggle"
		If My.App.HKEnabled Then
			Dim kc As New System.Windows.Forms.KeysConverter
			Me.cmiWSTTaskManager.ToolTipText += Chr(13) + "HotKey(Toggle) = " + kc.ConvertToString(My.App.HKWSTTaskManager.Key)
			Me.cmiWSTCommandPrompt.ToolTipText = "HotKey = " + kc.ConvertToString(My.App.HKWSTCommandPrompt.Key)
		End If
	End Sub
	Private Sub WSTTaskManagerToggle()
		Dim closelist As New System.Collections.Generic.List(Of String)
		ProcessListGenerate()

		For Each p As ProcessListType In ProcessList
			If p.FileName.Equals(My.App.WSTTaskManager.Path, StringComparison.CurrentCultureIgnoreCase) Then
				closelist.Add(p.ProcessName)
				Me.CloseApplications(My.App.Tools.WorkSpaceTools, closelist)
				Exit For
			End If
		Next
		If Not closelist.Count > 0 Then My.App.StartFile(My.App.WSTTaskManager)
		closelist.Clear()
	End Sub
	Private Sub WSTClockSet()
		frmWSTClock?.Close()
		frmWSTClock?.Dispose()
		frmWSTClock = Nothing
		UpdateWST()
		If My.App.WSTShowClock Then frmWSTClock = New WSTClock
	End Sub
	Private Sub WSTStopWatchSet()
		Debug.Print("WSTStopWatchSet: " + My.App.WSTShowStopWatch.ToString)
		If frmWSTStopWatch IsNot Nothing Then
			frmWSTStopWatch.Close()
			frmWSTStopWatch = Nothing
		End If
		If My.App.WSTShowStopWatch Then frmWSTStopWatch = New WSTStopWatch
	End Sub
	Private Sub WSTStopWatchReSet()
		Me.TimerWSTStopWatchReset.Stop()
		Me.cmiWSTStopWatch.ResetFont()
		Me.cmiWSTStopWatch.Text = "StopWatch"
		WSTStopWatch = DateTime.MinValue
		UpdateWST()
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
				Me.tipInfo.SetToolTip(Me.btnWSTScreenSaverEnabled, "Screen Saver ENABLED")
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
				Me.tipInfo.SetToolTip(Me.btnWSTScreenSaverEnabled, "Screen Saver DISABLED")
			End If
			Me.tipInfo.SetToolTip(Me.btnWSTScreenSaverEnabled, Me.tipInfo.GetToolTip(Me.btnWSTScreenSaverEnabled) + vbCr + "RightClick = Activate")
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
			Select Case chimecount
				Case > 12 : My.App.ShowBalloon(My.App.Tools.AlarmChime, "** CHIME IS SOUNDING **", My.App.BalloonDelay.WaitForUser)
				Case > 1 : My.App.ShowBalloon(My.App.Tools.AlarmChime, "** CHIME IS SOUNDING **", My.App.BalloonDelay.Long)
				Case > 0 : My.App.ShowBalloon(My.App.Tools.AlarmChime, "** CHIME IS SOUNDING **", My.App.BalloonDelay.Medium)
			End Select
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
			If ACMute Then
				Select Case ACChimeCount
					Case > 12 : My.App.ShowBalloon(My.App.Tools.AlarmChime, "** " + IIf(ACAlarmTripped, "ALARM", "CHIME").ToString + " IS SOUNDING **", My.App.BalloonDelay.WaitForUser)
					Case > 1 : My.App.ShowBalloon(My.App.Tools.AlarmChime, "** " + IIf(ACAlarmTripped, "ALARM", "CHIME").ToString + " IS SOUNDING **", My.App.BalloonDelay.Long)
					Case > 0 : My.App.ShowBalloon(My.App.Tools.AlarmChime, "** " + IIf(ACAlarmTripped, "ALARM", "CHIME").ToString + " IS SOUNDING **", My.App.BalloonDelay.Medium)
				End Select
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
		My.App.HideBalloon()
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
			Me.tipInfo.SetToolTip(Me.btnACMute, "Sound All Chimes")
		Else
			Me.btnACMute.Image = My.Resources.Resources.imageACSound 'CType(My.App.AppResources.GetObject("imageACSound"), Image)
			Me.tipInfo.SetToolTip(Me.btnACMute, "Mute All Chimes")
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
#Region "HotLinks(HL)"

	'Declarations
	Private notifyiconHL As NotifyIcon
	Private WithEvents TimerHLStartUp As New Timer
	Private cmHLMenu As New ContextMenuStrip
	Private cmHLTray As New ContextMenuStrip
	Private cmHLItem As New ContextMenuStrip
	Private imagelistlistviewHL As ImageList
	Private Enum HLEditModes
		NewAtIndex
		NewInGroup
		Edit
	End Enum
	Private HLEditIndex As Integer
	Private HLEditGroupIndex As Integer
	Private HLEditMode As HLEditModes
	Private HLEditName As String
	Private HLScrollIndex As Integer = 0
	Private uiHLOpenFile As New OpenFileDialog
	Private uiHLFolderBrowser As New FolderBrowserDialog

	'Control Events
	Private Sub TabpageHLPaint(sender As Object, e As PaintEventArgs) Handles tabpageHL.Paint
		e.Graphics.DrawLine(SystemPens.WindowFrame, 0, Me.textboxHLCloseTimeOut.Bottom + 8, Me.tabpageHL.Width - 4, Me.textboxHLCloseTimeOut.Bottom + 8)
	End Sub
	Private Sub CMlistviewHLOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmlvHL.Opening
		Me.cmiHLMoveTop.Enabled = False
		Me.cmiHLMoveUp.Enabled = False
		Me.cmiHLMoveDown.Enabled = False
		Me.cmiHLMoveBottom.Enabled = False
		If Me.lvHL.SelectedItems.Count = 0 Then
			Me.cmiHLNew.Text = "New (Insert Last)"
			Me.cmiHLEdit.Enabled = False
			Me.cmiHLCopy.Enabled = False
			Me.cmiHLDelete.Enabled = False
		Else
			If CInt(Me.lvHL.SelectedItems(0).Tag) > HLFindFirstIndex(My.App.HLData(CInt(Me.lvHL.SelectedItems(0).Tag)).Group, CInt(Me.lvHL.SelectedItems(0).Tag)) Then
				Me.cmiHLMoveTop.Enabled = True
				Me.cmiHLMoveUp.Enabled = True
			End If
			If CInt(Me.lvHL.SelectedItems(0).Tag) < HLFindLastIndex(My.App.HLData(CInt(Me.lvHL.SelectedItems(0).Tag)).Group, CInt(Me.lvHL.SelectedItems(0).Tag)) Then
				Me.cmiHLMoveDown.Enabled = True
				Me.cmiHLMoveBottom.Enabled = True
			End If
			Me.cmiHLNew.Text = "New In " + IIf(String.IsNullOrEmpty(My.App.HLData(CInt(Me.lvHL.SelectedItems(0).Tag)).Group), "Main Menu", My.App.HLData(CInt(Me.lvHL.SelectedItems(0).Tag)).Group).ToString + " (Insert Above)"
			Me.cmiHLEdit.Enabled = True
			Me.cmiHLCopy.Enabled = True
			Me.cmiHLDelete.Enabled = True
		End If
	End Sub
	Private Sub CMIHLMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		Dim senderCMI As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
		Select Case e.Button
			Case MouseButtons.Left : HLStartLink(My.App.HLData.Item(CInt(senderCMI.Tag)))
			Case MouseButtons.Right
				cmHLItem.Items.Clear()
				Dim cms As ToolStripSeparator
				Dim cmi As New ToolStripMenuItem(My.App.HLData(CInt(senderCMI.Tag)).Name, HLGetIcon(My.App.HLData(CInt(senderCMI.Tag))))
				AddHandler cmi.MouseUp, AddressOf CMIHLItemMouseUp
				cmi.Tag = senderCMI.Tag
				cmHLItem.Items.Add(cmi)
				cms = New ToolStripSeparator
				cmHLItem.Items.Add(cms)
				cmi = New ToolStripMenuItem("ReStart", My.Resources.Resources.imageGoReStart) 'DirectCast(My.App.AppResources.GetObject("imageGoReStart"), Image))
				AddHandler cmi.MouseUp, AddressOf CMIHLItemReStartMouseUp
				cmi.Tag = senderCMI.Tag
				cmHLItem.Items.Add(cmi)
				cmi = New ToolStripMenuItem("Close", My.Resources.Resources.imageClose) 'DirectCast(My.App.AppResources.GetObject("imageClose"), Image))
				AddHandler cmi.MouseUp, AddressOf CMIHLItemCloseMouseUp
				cmi.Tag = senderCMI.Tag
				cmHLItem.Items.Add(cmi)
				cms = New ToolStripSeparator
				cmHLItem.Items.Add(cms)
				cmi = New ToolStripMenuItem("Edit", My.Resources.Resources.imageEdit) 'DirectCast(My.App.AppResources.GetObject("imageEdit"), Image))
				AddHandler cmi.MouseUp, AddressOf CMIHLItemEditMouseUp
				cmi.Tag = senderCMI.Tag
				cmHLItem.Items.Add(cmi)
				cmHLItem.Show(MousePosition)
		End Select
		senderCMI = Nothing
	End Sub
	Private Sub CMIHLGroupMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		Dim senderCMI As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
		Select Case e.Button
			Case MouseButtons.Left
				If (My.Computer.Keyboard.CtrlKeyDown Or senderCMI.Owner Is Me.cmHLItem) AndAlso Not My.App.HLGroupMode = My.App.HLMode.NoAction Then
					If Me.cmHLTray.Visible Then Me.cmHLTray.Close()
					If Me.cmWST.Visible Then Me.cmWST.Close()

					Select Case My.App.HLGroupMode
						Case My.App.HLMode.Start : HLStartGroup(senderCMI.Tag.ToString)
						Case My.App.HLMode.ReStart : HLReStartGroup(senderCMI.Tag.ToString)
						Case My.App.HLMode.StartAndClose : HLStartAndCloseGroup(senderCMI.Tag.ToString)
						Case My.App.HLMode.Close : HLCloseGroup(senderCMI.Tag.ToString)
					End Select
				End If
			Case MouseButtons.Right
				cmHLItem.Items.Clear()
				Dim cmi As ToolStripMenuItem
				cmi = New ToolStripMenuItem(senderCMI.Tag.ToString, My.Resources.Resources.imageHLGroup) 'DirectCast(My.App.AppResources.GetObject("imageHLGroup"), Image))
				AddHandler cmi.MouseUp, AddressOf CMIHLGroupMouseUp
				cmi.Tag = senderCMI.Tag
				cmHLItem.Items.Add(cmi)
				Dim cms As New ToolStripSeparator
				cmHLItem.Items.Add(cms)
				cmi = New ToolStripMenuItem("Start All", My.Resources.Resources.imageGoStart) 'DirectCast(My.App.AppResources.GetObject("imageGoStart"), Image))
				AddHandler cmi.MouseUp, AddressOf CMIHLStartAllMouseUp
				cmi.Tag = senderCMI.Tag
				cmHLItem.Items.Add(cmi)
				cmi = New ToolStripMenuItem("ReStart All", My.Resources.Resources.imageGoReStart) 'DirectCast(My.App.AppResources.GetObject("imageGoReStart"), Image))
				AddHandler cmi.MouseUp, AddressOf CMIHLReStartAllMouseUp
				cmi.Tag = senderCMI.Tag
				cmHLItem.Items.Add(cmi)
				cmi = New ToolStripMenuItem("Close All", My.Resources.Resources.imageClose) 'DirectCast(My.App.AppResources.GetObject("imageClose"), Image))
				AddHandler cmi.MouseUp, AddressOf CMIHLCloseAllMouseUp
				cmi.Tag = senderCMI.Tag
				cmHLItem.Items.Add(cmi)
				cmHLItem.Show(MousePosition)
		End Select
		senderCMI = Nothing
	End Sub
	Private Sub CMIHLStartAllMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		If e.Button = MouseButtons.Left Then HLStartGroup(CType(sender, ToolStripMenuItem).Tag.ToString)
	End Sub
	Private Sub CMIHLReStartAllMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		If e.Button = MouseButtons.Left Then HLReStartGroup(CType(sender, ToolStripMenuItem).Tag.ToString)
	End Sub
	Private Sub CMIHLCloseAllMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		If e.Button = MouseButtons.Left Then HLCloseGroup(CType(sender, ToolStripMenuItem).Tag.ToString)
	End Sub
	Private Sub CMIHLRefreshMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		If e.Button = MouseButtons.Left Then ShowHL()
	End Sub
	Private Sub CMIHLSettingsMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		If e.Button = MouseButtons.Left Then SelectTab(Me.tabpageHL, True)
	End Sub
	Private Sub CMIHLTrayCloseMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		If e.Button = MouseButtons.Left Then
			My.App.WSTShowHLTray = False
			ShowTools()
			ShowSettings(My.App.Tools.WorkSpaceTools)
		End If
	End Sub
	Private Sub CMIHLItemMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		If e.Button = MouseButtons.Left Then HLStartLink(My.App.HLData.Item(DirectCast(CType(sender, ToolStripMenuItem).Tag, Integer)))
	End Sub
	Private Sub CMIHLItemEditMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		If e.Button = MouseButtons.Left Then
			ShowSettings(My.App.Tools.HotLinks)
			SelectTab(Me.tabpageHL, True)
			HLEditMode = HLEditModes.Edit
			HLEditIndex = DirectCast(CType(sender, ToolStripMenuItem).Tag, Integer)
			HLEdit()
		End If
	End Sub
	Private Sub CMIHLItemReStartMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		If e.Button = MouseButtons.Left Then
			HLCloseLink(My.App.HLData.Item(DirectCast(CType(sender, ToolStripMenuItem).Tag, Integer)))
			My.App.AppSleep(1)
			HLStartLink(My.App.HLData.Item(DirectCast(CType(sender, ToolStripMenuItem).Tag, Integer)))
		End If
	End Sub
	Private Sub CMIHLItemCloseMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
		If e.Button = MouseButtons.Left Then HLCloseLink(My.App.HLData.Item(DirectCast(CType(sender, ToolStripMenuItem).Tag, Integer)))
	End Sub
	Private Sub CMIHLMoveMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiHLMoveUp.MouseUp, cmiHLMoveTop.MouseUp, cmiHLMoveDown.MouseUp, cmiHLMoveBottom.MouseUp
		If e.Button = MouseButtons.Left Then
			HLScrollIndex = Me.lvHL.SelectedIndices.Item(0)

			Dim link As My.App.HLItemType = My.App.HLData.Item(CInt(Me.lvHL.SelectedItems.Item(0).Tag))
			My.App.HLData.RemoveAt(CInt(Me.lvHL.SelectedItems.Item(0).Tag))
			Select Case CType(sender, ToolStripMenuItem).Name
				Case Me.cmiHLMoveTop.Name : My.App.HLData.Insert(HLFindFirstIndex(link.Group, CInt(Me.lvHL.SelectedItems(0).Tag)), link)
				Case Me.cmiHLMoveUp.Name : My.App.HLData.Insert(CInt(Me.lvHL.SelectedItems.Item(0).Tag) - 1, link)
				Case Me.cmiHLMoveDown.Name : My.App.HLData.Insert(CInt(Me.lvHL.SelectedItems.Item(0).Tag) + 1, link)
				Case Me.cmiHLMoveBottom.Name : My.App.HLData.Insert(HLFindLastIndex(link.Group, CInt(Me.lvHL.SelectedItems(0).Tag)) + 1, link)
			End Select
			ShowHL()
			ShowSettings(My.App.Tools.HotLinks)
		End If
	End Sub
	Private Sub CMIHLNewMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiHLNew.MouseUp
		If e.Button = MouseButtons.Left Then HLNew()
	End Sub
	Private Sub CMIHLEditMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiHLEdit.MouseUp
		If e.Button = MouseButtons.Left Then
			HLScrollIndex = Me.lvHL.SelectedIndices.Item(0)
			HLEditMode = HLEditModes.Edit
			HLEditIndex = CInt(Me.lvHL.SelectedItems.Item(0).Tag)
			HLEdit()
		End If
	End Sub
	Private Sub CMIHLCopyMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiHLCopy.MouseUp
		If e.Button = MouseButtons.Left And Me.lvHL.SelectedIndices.Count > 0 Then
			Dim link As My.App.HLItemType = My.App.HLData(CInt(Me.lvHL.SelectedItems.Item(0).Tag))
			If link.Type = My.App.HLType.Group Then
				Dim linklist As Collections.Generic.List(Of My.App.HLItemType) = HLGenerateGroupList(link.Name)

				'Rename & Copy Link
				HLEditName = link.Name
				Dim increment As Integer = 1
				Do
					increment += 1
					link.Name = HLEditName + increment.ToString
				Loop While HLDuplicateGroupExists(link.Name)
				My.App.HLData.Insert(CInt(Me.lvHL.SelectedItems.Item(0).Tag) + 1, link)

				'ReGroup & Copy All Group Links @ End Of HotLinks
				For Each grouplink As My.App.HLItemType In linklist
					grouplink.Group = link.Name
					My.App.HLData.Insert(My.App.HLData.Count, grouplink)
				Next

			Else : My.App.HLData.Insert(CInt(Me.lvHL.SelectedItems.Item(0).Tag) + 1, link)
			End If
			Me.ShowSettings(My.App.Tools.HotLinks)
			ShowHL()
		End If
	End Sub
	Private Sub CMIHLDeleteMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmiHLDelete.MouseUp
		If e.Button = MouseButtons.Left Then
			HLScrollIndex = Me.lvHL.SelectedIndices.Item(0)
			Dim removelist As New Collections.Generic.List(Of Integer) From {CInt(Me.lvHL.SelectedItems.Item(0).Tag)}
			If My.App.HLData.Item(CInt(Me.lvHL.SelectedItems.Item(0).Tag)).Type = My.App.HLType.Group Then HLGenerateRemoveList(My.App.HLData.Item(CInt(Me.lvHL.SelectedItems.Item(0).Tag)).Name, removelist)
			removelist.Sort()
			removelist.Reverse()
			For Each index As Integer In removelist : My.App.HLData.RemoveAt(index) : Next
			ShowHL()
			ShowSettings(My.App.Tools.HotLinks)
		End If
	End Sub
	Private Sub BtnHLSelectLinkClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHLSelectLink.Click
		If Not String.IsNullOrEmpty(Me.textboxHLLink.Text) Then Me.uiHLOpenFile.InitialDirectory = Me.textboxHLLink.Text
		Dim r As DialogResult = Me.uiHLOpenFile.ShowDialog(Me)
		If r = System.Windows.Forms.DialogResult.OK And Not Me.uiHLOpenFile.FileName = "" Then : Me.textboxHLLink.Text = Me.uiHLOpenFile.FileName
		ElseIf Not r = System.Windows.Forms.DialogResult.Cancel Then : Me.textboxHLLink.Text = ""
		End If
		Me.textboxHLLink.Select(Me.textboxHLLink.Text.Length, 0)
		Me.textboxHLLink.Focus()
	End Sub
	Private Sub BtnHLSelectWorkingDirectoryClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHLSelectWorkingDirectory.Click
		If Not String.IsNullOrEmpty(Me.textboxHLWorkingDirectory.Text) Then Me.uiHLFolderBrowser.SelectedPath = Me.textboxHLWorkingDirectory.Text
		Dim r As DialogResult = Me.uiHLFolderBrowser.ShowDialog(Me)
		If r = System.Windows.Forms.DialogResult.OK And Not Me.uiHLFolderBrowser.SelectedPath = "" Then : Me.textboxHLWorkingDirectory.Text = Me.uiHLFolderBrowser.SelectedPath
		ElseIf Not r = System.Windows.Forms.DialogResult.Cancel Then : Me.textboxHLWorkingDirectory.Text = ""
		End If
		Me.textboxHLWorkingDirectory.Select(Me.textboxHLWorkingDirectory.Text.Length, 0)
		Me.textboxHLWorkingDirectory.Focus()
	End Sub
	Private Sub BtnHLSetClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHLSet.Click
		Dim link As My.App.HLItemType = HLGenerateNewLink()

		If String.IsNullOrEmpty(link.Name) And Not link.Type = My.App.HLType.Group And Not link.Type = My.App.HLType.Separator Then
			Me.textboxHLName.Text = "**ENTER_LINK_NAME**"
			My.App.ShowBalloon(My.App.Tools.HotLinks, "Please Enter A Link NaMe...", My.App.BalloonDelay.Short)
		ElseIf link.Type = My.App.HLType.Group And HLDuplicateGroupExists(link.Name) Then : My.App.ShowBalloon(My.App.Tools.HotLinks, "Duplicate Group Name", My.App.BalloonDelay.Short)
		Else
			Select Case HLEditMode
				Case HLEditModes.NewAtIndex : My.App.HLData.Insert(HLEditIndex, link)
				Case HLEditModes.NewInGroup
					Dim indexMax As Integer = My.App.HLData.Count - 1
					For indexCounter As Integer = 0 To My.App.HLData.Count - 1 : If My.App.HLData.Item(indexCounter).Group = link.Group Then indexMax = indexCounter
					Next
					My.App.HLData.Insert(indexMax + 1, link)
				Case HLEditModes.Edit
					If link.Type = My.App.HLType.Group And Not link.Name = My.App.HLData(HLEditIndex).Name Then 'If group type, change all members of group
						For index As Integer = 0 To My.App.HLData.Count - 1
							Dim updatelink As My.App.HLItemType = My.App.HLData(index)
							If updatelink.Group = My.App.HLData(HLEditIndex).Name Then
								My.App.HLData.RemoveAt(index)
								updatelink.Group = link.Name
								My.App.HLData.Insert(index, updatelink)
							End If
						Next
					End If
					If Me.comboboxHLGroup.SelectedIndex = HLEditGroupIndex Then 'If group is the same
						My.App.HLData.RemoveAt(HLEditIndex)
						My.App.HLData.Insert(HLEditIndex, link)
					Else 'If group has changed
						My.App.HLData.RemoveAt(HLEditIndex)
						Dim indexMax As Integer = My.App.HLData.Count - 1
						For indexCounter As Integer = 0 To My.App.HLData.Count - 1 : If My.App.HLData.Item(indexCounter).Group = link.Group Then indexMax = indexCounter
						Next
						My.App.HLData.Insert(indexMax + 1, link)
					End If
			End Select
			ShowSettings(My.App.Tools.HotLinks)
			ShowHL()
		End If
	End Sub
	Private Sub BtnHLCancelClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHLCancel.Click
		ShowSettings(My.App.Tools.HotLinks)
	End Sub
	Private Sub BtnHLTestClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHLTest.Click
		Dim link As My.App.HLItemType = HLGenerateNewLink()
		Me.btnHLTest.Image = HLGetIcon(link)
		HLStartLink(link)
	End Sub
	Private Sub CheckboxHLShowMenuIconsClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxHLShowMenuIcons.Click
		My.App.HLShowMenuIcons = Not My.App.HLShowMenuIcons
		ShowHL()
	End Sub
	Private Sub CheckboxHLShowToolTipsClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxHLShowToolTips.Click
		My.App.HLShowToolTips = Not My.App.HLShowToolTips
		ShowHL()
	End Sub
	Private Sub CheckboxHLDisabledClick(ByVal sender As Object, ByVal e As EventArgs) Handles checkboxHLDisabled.Click
		If Me.checkboxHLDisabled.Checked And Not Me.checkboxHLHideInMenu.Checked Then Me.checkboxHLHideInMenu.Checked = True
	End Sub
	Private Sub ComboboxHLStartUpModeSelectionChangeCommitted(sender As Object, e As EventArgs) Handles comboboxHLStartUpMode.SelectionChangeCommitted
		My.App.HLStartUpMode = CType(Me.comboboxHLStartUpMode.SelectedIndex, My.App.HLMode)
	End Sub
	Private Sub ComboboxHLGroupModeSelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs) Handles comboboxHLGroupMode.SelectionChangeCommitted
		My.App.HLGroupMode = CType(Me.comboboxHLGroupMode.SelectedIndex, My.App.HLMode)
	End Sub
	Private Sub ComboboxHLHotKeyModeSelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs) Handles comboboxHLHotKeyMode.SelectionChangeCommitted
		My.App.HLHotKeyMode = CType(Me.comboboxHLHotKeyMode.SelectedIndex, My.App.HLMode)
	End Sub
	Private Sub ComboboxHLPriorityDrawItem(sender As Object, e As DrawItemEventArgs) Handles comboboxHLPriority.DrawItem
		If e.Index < 0 Then 'The system sometimes calls this method with an index of -1. This produces an error if not handled.
			e.DrawBackground()
			e.DrawFocusRectangle()
		Else
			Dim brush As SolidBrush
			Dim font As Font
			If Me.comboboxHLPriority.Enabled Then
				Me.comboboxHLPriority.ResetForeColor()
				Me.comboboxHLPriority.ResetBackColor()
			Else
				Me.comboboxHLPriority.ForeColor = SystemColors.GrayText
				Me.comboboxHLPriority.BackColor = SystemColors.Control
			End If
			e.DrawBackground()
			e.DrawFocusRectangle()

			If e.Index = 0 Then
				brush = New SolidBrush(Color.Firebrick)
				font = New Font(Me.comboboxHLPriority.Font, FontStyle.Italic)
			Else
				brush = New SolidBrush(Me.comboboxHLPriority.ForeColor)
				font = New Font(Me.comboboxHLPriority.Font, FontStyle.Regular)
			End If
			e.Graphics.DrawString(Me.comboboxHLPriority.Items(e.Index).ToString, font, brush, New PointF(e.Bounds.X - 1, e.Bounds.Y + 1))
		End If
	End Sub
	Private Sub ComboboxHLTypeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboboxHLType.SelectedIndexChanged
		HLUpdateEditType()
	End Sub
	Private Sub TextboxHLLoadTimeOutValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textboxHLLoadTimeOut.Validating
		Dim senderTXBX As TextBox = CType(sender, TextBox)
		If Int(Val(senderTXBX.Text)) < 1 Then senderTXBX.Text = "1"
		If Int(Val(senderTXBX.Text)) > 120 Then senderTXBX.Text = "120"
	End Sub
	Private Sub TextboxHLLoadTimeOutValidated(ByVal sender As Object, ByVal e As EventArgs) Handles textboxHLLoadTimeOut.Validated
		My.App.HLLoadTimeOut = CByte(Val(Me.textboxHLLoadTimeOut.Text))
		Me.textboxHLLoadTimeOut.SelectAll()
	End Sub
	Private Sub TextboxHLCloseTimeOutValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textboxHLCloseTimeOut.Validating
		Dim senderTXBX As TextBox = CType(sender, TextBox)
		If Int(Val(senderTXBX.Text)) < 1 Then senderTXBX.Text = "1"
		If Int(Val(senderTXBX.Text)) > 120 Then senderTXBX.Text = "120"
	End Sub
	Private Sub TextboxHLCloseTimeOutValidated(ByVal sender As Object, ByVal e As EventArgs) Handles textboxHLCloseTimeOut.Validated
		My.App.HLCloseTimeOut = CByte(Val(Me.textboxHLCloseTimeOut.Text))
		Me.textboxHLCloseTimeOut.SelectAll()
	End Sub
	Private Sub TextboxHLStartUpDelayValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textboxHLStartUpDelay.Validating
		Dim senderTXBX As TextBox = CType(sender, TextBox)
		If Int(Val(senderTXBX.Text)) < 5 Then senderTXBX.Text = "5"
		If Int(Val(senderTXBX.Text)) > 300 Then senderTXBX.Text = "300"
	End Sub
	Private Sub TextboxHLStartUpDelayValidated(ByVal sender As Object, ByVal e As EventArgs) Handles textboxHLStartUpDelay.Validated
		My.App.HLStartUpDelay = CShort(Val(Me.textboxHLStartUpDelay.Text))
		Me.textboxHLStartUpDelay.SelectAll()
	End Sub
	Private Sub TextboxHLUseAlternateStartTimeOutValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textboxHLUseAlternateStartTimeOut.Validating
		Dim senderTXBX As TextBox = CType(sender, TextBox)
		If Int(Val(senderTXBX.Text)) < 0 Or String.IsNullOrEmpty(senderTXBX.Text) Then senderTXBX.Text = "0"
		If Int(Val(senderTXBX.Text)) > 120 Then senderTXBX.Text = "120"
	End Sub
	Private Sub TextboxHLUseAlternateStartTimeOutValidated(ByVal sender As Object, ByVal e As EventArgs) Handles textboxHLUseAlternateStartTimeOut.Validated
		If CType(sender, TextBox).Text = "0" Then : Me.checkboxHLUseAlternateStartMethod.Checked = False
		Else : Me.checkboxHLUseAlternateStartMethod.Checked = True
		End If
		Me.textboxHLUseAlternateStartTimeOut.SelectAll()
	End Sub

	'Handlers
	Private Sub TimerHLStartUpTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerHLStartUp.Tick
		If (Not WLStartUp Or My.App.HLStartUpDelay < My.App.WLStartUpDelay) And Not BackgroundworkerWL.IsBusy And Not InUseApp() Then
			Me.TimerHLStartUp.Stop()
			UpdateWSTCancelState()

			Select Case My.App.HLStartUpMode
				Case My.App.HLMode.Start : HLStartGroup("StartUp")
				Case My.App.HLMode.ReStart : HLReStartGroup("StartUp")
			End Select
			My.App.WriteToLog(My.App.Tools.HotLinks, "HotLinks StartUp Executed")
		End If
		If TimerHLStartUp.Enabled Then Me.TimerHLStartUp.Interval = My.App.HLStartUpDelay * 100
	End Sub

	'Procedures
	Private Sub ShowHL()
		If My.App.WSTShowHLMenu Then
			Me.cmHLMenu.Items.Clear()
			Me.cmHLMenu.ShowImageMargin = My.App.HLShowMenuIcons
			For Each t As ToolStripItem In HLGenerateMenuItems("") : Me.cmHLMenu.Items.Add(t)
			Next
		End If
		If My.App.WSTShowHLTray Then
			Me.cmHLTray.Items.Clear()
			Me.cmHLTray.ShowImageMargin = My.App.HLShowMenuIcons
			For Each t As ToolStripItem In HLGenerateMenuItems("") : Me.cmHLTray.Items.Add(t)
			Next
			Me.cmHLTray.Items.Add(New ToolStripSeparator)
			Dim mi As New ToolStripMenuItem("Refresh")
			If My.App.HLShowMenuIcons Then mi.Image = My.Resources.Resources.imageSwap 'DirectCast(My.App.AppResources.GetObject("imageSwap"), Image)
			AddHandler mi.MouseUp, AddressOf CMIHLRefreshMouseUp
			Me.cmHLTray.Items.Add(mi)
			mi = New ToolStripMenuItem("Settings")
			If My.App.HLShowMenuIcons Then mi.Image = My.Resources.Resources.imageSettings 'DirectCast(My.App.AppResources.GetObject("imageSettings"), Image)
			AddHandler mi.MouseUp, AddressOf CMIHLSettingsMouseUp
			Me.cmHLTray.Items.Add(mi)
			Me.cmHLTray.Items.Add(New ToolStripSeparator)
			mi = New ToolStripMenuItem("Close HotLinks Tray")
			If My.App.HLShowMenuIcons Then mi.Image = My.Resources.Resources.imageClose 'DirectCast(My.App.AppResources.GetObject("imageClose"), Image)
			AddHandler mi.MouseUp, AddressOf CMIHLTrayCloseMouseUp
			Me.cmHLTray.Items.Add(mi)
			mi = New ToolStripMenuItem("Exit SkyeTools") With {.ToolTipText = My.App.CloseAllToolTipText}
			If My.App.HLShowMenuIcons Then mi.Image = My.Resources.Resources.imageClose 'DirectCast(My.App.AppResources.GetObject("imageClose"), Image)
			AddHandler mi.MouseUp, AddressOf CMICloseAllMouseUp
			Me.cmHLTray.Items.Add(mi)
		End If
	End Sub
	Private Sub HLStartLink(ByRef link As My.App.HLItemType, Optional waitforinputidle As Boolean = False)
		Try
			If Not link.Disabled Then
				If Not String.IsNullOrEmpty(link.Link) Then
					If Not HLIsSingleInstance(link) Then
						If waitforinputidle Then My.App.ShowBalloon(My.App.Tools.HotLinks, "Starting " + link.Name.ToUpper, My.App.BalloonDelay.WaitForUser)
						Dim pInfo As New Diagnostics.ProcessStartInfo With {
								.FileName = link.Link,
								.Arguments = link.Arguments,
								.WorkingDirectory = link.WorkingDirectory,
								.WindowStyle = link.WindowState,
								.UseShellExecute = True}
						Dim p As Diagnostics.Process = Diagnostics.Process.Start(pInfo)
						Try : p.PriorityClass = link.Priority : Catch : End Try
						If waitforinputidle Then
							Try
								If link.UseAlternateStartMethod Then : p.WaitForExit(CInt(IIf(link.UseAlternateStartTimeOut = 0, My.App.HLLoadTimeOut, link.UseAlternateStartTimeOut)) * 1000)
								Else : p.WaitForInputIdle(My.App.HLLoadTimeOut * 1000)
								End If
							Catch : End Try
						End If
						Try : p.Dispose() : Catch : Finally : p = Nothing : End Try
					End If
				End If
			End If
		Catch ex As Exception
			My.App.WriteToLog(My.App.Tools.HotLinks, "Cannot Start '" + link.Name + "'" + " (" + link.Link + ")" + Chr(13) + ex.ToString)
			My.App.ShowMessage(My.App.Tools.HotLinks, "Cannot Start '" + link.Name + "'", ex.Message + Chr(13) + Chr(13) + link.Link, "Please Check Your Settings And Try Again")
		Finally : My.App.HideBalloon()
		End Try
	End Sub
	Private Sub HLStartLinks(ByRef links As Collections.Generic.List(Of My.App.HLItemType), Optional displayname As String = Nothing)
		For Each link As My.App.HLItemType In links : HLStartLink(link, True) : Next
		If Not String.IsNullOrEmpty(displayname) Then My.App.ShowBalloon(My.App.Tools.HotLinks, displayname.ToUpper + " Started", My.App.BalloonDelay.Short)
	End Sub
	Private Sub HLStartLinksByHotKey(key As My.App.HLHotKey)
		If My.App.WSTShowHLMenu Or My.App.WSTShowHLTray And Not My.App.HLHotKeyMode = My.App.HLMode.NoAction Then
			Dim linklist As New Collections.Generic.List(Of My.App.HLItemType)
			For Each link As My.App.HLItemType In My.App.HLData
				If link.HotKey = key Then
					If link.Type = My.App.HLType.Group Then : linklist.AddRange(HLGenerateGroupList(link.Name))
					Else : linklist.Add(link)
					End If
				End If
			Next
			If linklist.Count > 0 Then
				Select Case My.App.HLHotKeyMode
					Case My.App.HLMode.Start : HLStartLinks(linklist)
					Case My.App.HLMode.ReStart
						HLCloseLinks(linklist)
						HLStartLinks(linklist)
					Case My.App.HLMode.StartAndClose : HLStartAndCloseLinks(linklist)
					Case My.App.HLMode.Close : HLCloseLinks(linklist)
				End Select
				linklist.Clear()
			End If
		End If
	End Sub
	Private Sub HLStartAndCloseLinks(ByRef links As Collections.Generic.List(Of My.App.HLItemType))
		If links.Count > 0 Then
			Dim startlist As New Collections.Generic.List(Of My.App.HLItemType)
			Dim closelist As New Collections.Generic.List(Of String)
			Dim closelistcount As Integer
			ProcessListGenerate()

			For Each link As My.App.HLItemType In links
				closelistcount = closelist.Count
				For Each p As ProcessListType In ProcessList
					'					If p.FileNaMe.Equals(link.Link, StringComparison.CurrentCultureIgnoreCase) And Not closelist.Contains(p.ProcessName) And Not closelist.Contains("*" + p.ProcessName) Then
					If p.FileName.Equals(link.Link, StringComparison.CurrentCultureIgnoreCase) Then
						'If link.UseAlternateCloseMethod Then : closelist.Add("*" + p.ProcessName)
						'Else : closelist.Add(p.ProcessName)
						'End If
						closelist.Add(p.ProcessName)
					End If
				Next
				If Not closelist.Count > closelistcount Then startlist.Add(link)
			Next
			'My.Debug.ShowMessage(My.SkyeTools.Tools.HotLinks, "HLStartAndCloseLinks", closelist.Count.ToString)
			CloseApplications(My.App.Tools.HotLinks, closelist, My.App.HLCloseTimeOut)
			For Each link As My.App.HLItemType In startlist : HLStartLink(link, True) : Next
			startlist.Clear()
			closelist.Clear()
		End If
	End Sub
	Private Sub HLCloseLink(ByRef link As My.App.HLItemType)
		Dim list As New Collections.Generic.List(Of My.App.HLItemType) From {link}
		HLCloseLinks(list)
		list.Clear()
	End Sub
	Private Sub HLCloseLinks(ByRef links As Collections.Generic.List(Of My.App.HLItemType))
		If links.Count > 0 Then
			Dim closelist As New Collections.Generic.List(Of String)
			Dim link As My.App.HLItemType
			ProcessListGenerate()
			For index As Integer = links.Count - 1 To 0 Step -1
				link = links(index)
				For Each p As ProcessListType In ProcessList
					'Debug.Print(p.FileName)
					If p.FileName.Equals(link.Link, StringComparison.CurrentCultureIgnoreCase) And Not closelist.Contains(p.ProcessName) Then
						'If link.UseAlternateCloseMethod Then : closelist.Add("*" + p.ProcessName)
						'Else : closelist.Add(p.ProcessName)
						'End If
						closelist.Add(p.ProcessName)
					End If
				Next
			Next
			CloseApplications(My.App.Tools.HotLinks, closelist, My.App.HLCloseTimeOut)
		End If
	End Sub
	Private Sub HLStartGroup(groupname As String)
		HLStartLinks(HLGenerateGroupList(groupname), groupname)
	End Sub
	Private Sub HLReStartGroup(groupname As String)
		Dim links As Collections.Generic.List(Of My.App.HLItemType) = HLGenerateGroupList(groupname)
		HLCloseLinks(links)
		HLStartLinks(links, groupname)
		links.Clear()
		links = Nothing
	End Sub
	Private Sub HLStartAndCloseGroup(groupname As String)
		HLStartAndCloseLinks(HLGenerateGroupList(groupname))
	End Sub
	Private Sub HLCloseGroup(groupname As String)
		HLCloseLinks(HLGenerateGroupList(groupname))
	End Sub
	Private Sub HLSetSettingsTab()
		If My.App.WSTShowHLMenu Or My.App.WSTShowHLTray Then : Me.tabpageHL.Enabled = True
		Else : Me.tabpageHL.Enabled = False
		End If
	End Sub
	Private Sub HLNew()
		If Me.lvHL.SelectedItems.Count = 0 Then
			HLEditMode = HLEditModes.NewInGroup
			HLEditIndex = 0
			Me.comboboxHLGroup.Enabled = True
		Else
			HLScrollIndex = Me.lvHL.SelectedIndices.Item(0)
			HLEditMode = HLEditModes.NewAtIndex
			HLEditIndex = CInt(Me.lvHL.SelectedItems.Item(0).Tag)
			If My.App.HLData(HLEditIndex).Group = "" Then : Me.comboboxHLGroup.SelectedIndex = 0
			Else : Me.comboboxHLGroup.SelectedItem = My.App.HLData(HLEditIndex).Group
			End If
			Me.comboboxHLGroup.Enabled = False
		End If
		HLEditName = ""
		Me.lvHL.Visible = False
		Me.panelHLEdit.Visible = True
		Me.btnClose.Select()
	End Sub
	Private Sub HLEdit()
		HLEditName = My.App.HLData.Item(HLEditIndex).Name
		Me.textboxHLName.Text = My.App.HLData.Item(HLEditIndex).Name
		Me.textboxHLDescription.Text = My.App.HLData.Item(HLEditIndex).Description
		Me.textboxHLLink.Text = My.App.HLData.Item(HLEditIndex).Link
		Me.textboxHLArguments.Text = My.App.HLData.Item(HLEditIndex).Arguments
		Me.textboxHLWorkingDirectory.Text = My.App.HLData.Item(HLEditIndex).WorkingDirectory
		Me.checkboxHLSingleInstance.Checked = My.App.HLData.Item(HLEditIndex).SingleInstance
		Me.checkboxHLUseAlternateStartMethod.Checked = My.App.HLData(HLEditIndex).UseAlternateStartMethod
		Me.textboxHLUseAlternateStartTimeOut.Text = My.App.HLData(HLEditIndex).UseAlternateStartTimeOut.ToString
		'Me.checkboxHLUseAlternateCloseMethod.Checked = My.App.HLData(HLEditIndex).UseAlternateCloseMethod
		Me.checkboxHLHideInMenu.Checked = My.App.HLData(HLEditIndex).HideInMenu
		Me.checkboxHLDisabled.Checked = My.App.HLData(HLEditIndex).Disabled
		If My.App.HLData.Item(HLEditIndex).Group = "" Then : Me.comboboxHLGroup.SelectedIndex = 0
		Else : Me.comboboxHLGroup.SelectedItem = My.App.HLData.Item(HLEditIndex).Group
		End If
		HLEditGroupIndex = Me.comboboxHLGroup.SelectedIndex
		Me.comboboxHLGroup.Enabled = True
		If Not My.App.HLData.Item(HLEditIndex).Type = My.App.HLType.Group And Not My.App.HLData.Item(HLEditIndex).Type = My.App.HLType.Separator Then
			Me.comboboxHLType.Items.RemoveAt(My.App.HLType.Separator)
			Me.comboboxHLType.Items.RemoveAt(My.App.HLType.Group)
		End If
		Me.comboboxHLType.SelectedIndex = My.App.HLData(HLEditIndex).Type
		Me.comboboxHLPriority.SelectedItem = My.App.HLData(HLEditIndex).Priority.ToString
		Me.comboboxHLWindowState.SelectedItem = My.App.HLData(HLEditIndex).WindowState.ToString
		Me.comboboxHLHotKey.SelectedIndex = My.App.HLData(HLEditIndex).HotKey
		'For Each item As String In My.App.HLData.Item(HLEditIndex).CloseAppList : Me.listboxHLCloseAppList.Items.Add(item) : Next
		HLUpdateEditType()
		Me.lvHL.Visible = False
		Me.panelHLEdit.Visible = True
		Me.btnClose.Select()
	End Sub
	Private Sub HLUpdateEditType()
		Me.btnHLTest.Image = My.Resources.Resources.imageHLTest 'DirectCast(My.App.AppResources.GetObject("imageHLTest"), Image)
		If Me.comboboxHLType.Text = My.App.HLType.Group.ToString Then
			Me.textboxHLName.Enabled = True
			Me.textboxHLDescription.Enabled = True
			Me.textboxHLLink.Enabled = False
			Me.btnHLSelectLink.Enabled = False
			If HLEditMode = HLEditModes.Edit Then : Me.comboboxHLType.Enabled = False
			Else : Me.comboboxHLType.Enabled = True
			End If
			Me.textboxHLArguments.Enabled = False
			Me.checkboxHLSingleInstance.Enabled = False
			Me.checkboxHLUseAlternateStartMethod.Enabled = False
			Me.textboxHLUseAlternateStartTimeOut.Enabled = False
			Me.lblHLUseAlternateStartTimeOutA.Enabled = False
			Me.lblHLUseAlternateStartTimeOutB.Enabled = False
			'Me.checkboxHLUseAlternateCloseMethod.Enabled = False
			Me.textboxHLWorkingDirectory.Enabled = False
			Me.btnHLSelectWorkingDirectory.Enabled = False
			Me.comboboxHLWindowState.Enabled = False
			Me.comboboxHLPriority.Enabled = False
			Me.comboboxHLHotKey.Enabled = True
			Me.checkboxHLHideInMenu.Enabled = True
			Me.checkboxHLDisabled.Enabled = True
			'Me.listboxHLCloseAppList.Enabled = False
			'Me.comboboxHLCloseAppProcessList.Enabled = False
			Me.btnHLTest.Enabled = False
		ElseIf Me.comboboxHLType.Text = My.App.HLType.Separator.ToString Then
			Me.textboxHLName.Enabled = False
			Me.textboxHLDescription.Enabled = False
			Me.textboxHLLink.Enabled = False
			Me.btnHLSelectLink.Enabled = False
			If HLEditMode = HLEditModes.Edit Then : Me.comboboxHLType.Enabled = False
			Else : Me.comboboxHLType.Enabled = True
			End If
			Me.textboxHLArguments.Enabled = False
			Me.checkboxHLSingleInstance.Enabled = False
			Me.checkboxHLUseAlternateStartMethod.Enabled = False
			Me.textboxHLUseAlternateStartTimeOut.Enabled = False
			Me.lblHLUseAlternateStartTimeOutA.Enabled = False
			Me.lblHLUseAlternateStartTimeOutB.Enabled = False
			'Me.checkboxHLUseAlternateCloseMethod.Enabled = False
			Me.textboxHLWorkingDirectory.Enabled = False
			Me.btnHLSelectWorkingDirectory.Enabled = False
			Me.comboboxHLWindowState.Enabled = False
			Me.comboboxHLPriority.Enabled = False
			Me.comboboxHLHotKey.Enabled = False
			Me.checkboxHLHideInMenu.Enabled = False
			Me.checkboxHLDisabled.Enabled = False
			'Me.listboxHLCloseAppList.Enabled = False
			'Me.comboboxHLCloseAppProcessList.Enabled = False
			Me.btnHLTest.Enabled = False
		Else
			Me.textboxHLName.Enabled = True
			Me.textboxHLDescription.Enabled = True
			Me.textboxHLLink.Enabled = True
			Me.btnHLSelectLink.Enabled = True
			Me.comboboxHLType.Enabled = True
			Me.textboxHLArguments.Enabled = True
			Me.checkboxHLSingleInstance.Enabled = True
			Me.checkboxHLUseAlternateStartMethod.Enabled = True
			Me.textboxHLUseAlternateStartTimeOut.Enabled = True
			Me.lblHLUseAlternateStartTimeOutA.Enabled = True
			Me.lblHLUseAlternateStartTimeOutB.Enabled = True
			'Me.checkboxHLUseAlternateCloseMethod.Enabled = True
			Me.textboxHLWorkingDirectory.Enabled = True
			Me.btnHLSelectWorkingDirectory.Enabled = True
			Me.comboboxHLWindowState.Enabled = True
			Me.comboboxHLPriority.Enabled = True
			Me.comboboxHLHotKey.Enabled = True
			Me.checkboxHLHideInMenu.Enabled = True
			Me.checkboxHLDisabled.Enabled = True
			'Me.listboxHLCloseAppList.Enabled = True
			'Me.comboboxHLCloseAppProcessList.Enabled = True
			Me.btnHLTest.Enabled = True
		End If
	End Sub
	Private Sub HLGenerateRemoveList(ByRef groupname As String, ByRef removelist As Collections.Generic.List(Of Integer))
		For index As Integer = 0 To My.App.HLData.Count - 1
			If My.App.HLData.Item(index).Group = groupname Then
				removelist.Add(index)
				If My.App.HLData.Item(index).Type = My.App.HLType.Group Then HLGenerateRemoveList(My.App.HLData.Item(index).Name, removelist)
			End If
		Next
	End Sub
	Private Function HLGenerateMenuItems(ByRef group As String) As Collections.Generic.List(Of ToolStripItem)
		Dim list As New Collections.Generic.List(Of ToolStripItem)
		For index As Integer = 0 To My.App.HLData.Count - 1
			Dim link As My.App.HLItemType = My.App.HLData.Item(index)
			If link.Group = group And Not link.HideInMenu Then
				If link.Type = My.App.HLType.Separator Then : list.Add(New ToolStripSeparator)
				Else
					Dim cmi As New ToolStripMenuItem
					If link.Type = My.App.HLType.Group Then : cmi = HLGenerateSubMenu(link)
					Else
						If link.Name.Length > 50 Then
							cmi.Text = link.Name.Substring(0, 50)
							If My.App.HLShowToolTips Then cmi.ToolTipText = link.Name + Chr(13) + link.Link
						Else
							cmi.Text = link.Name
							If My.App.HLShowToolTips Then cmi.ToolTipText = link.Link
						End If
						If Not String.IsNullOrEmpty(link.Arguments) And My.App.HLShowToolTips Then cmi.ToolTipText += Chr(13) + link.Arguments
						If Not link.HotKey = My.App.HLHotKey.None Then
							cmi.Text += "  (" + link.HotKey.ToString + ")"
							cmi.ToolTipText = My.App.HLHotKeyToStringLong(link.HotKey) + IIf(String.IsNullOrEmpty(cmi.ToolTipText), String.Empty, Chr(13) + cmi.ToolTipText).ToString
						End If
						If Not String.IsNullOrEmpty(link.Description) Then cmi.ToolTipText = link.Description + IIf(String.IsNullOrEmpty(cmi.ToolTipText), String.Empty, Chr(13) + cmi.ToolTipText).ToString
						cmi.Tag = index
						AddHandler cmi.MouseUp, AddressOf CMIHLMouseUp
					End If
					If My.App.HLShowMenuIcons Then cmi.Image = HLGetIcon(link)
					If link.Disabled Then cmi.Enabled = False
					list.Add(cmi)
				End If
			End If
		Next
		If list.Count = 0 Then
			Dim cmi As New ToolStripMenuItem(My.App.HLEmptyText)
			If My.App.HLShowMenuIcons Then cmi.Image = Me.cmiWSTHLMenu.Image
			list.Add(cmi)
		End If
		Return list
		list.Clear()
	End Function
	Private Function HLGenerateSubMenu(ByRef link As My.App.HLItemType) As ToolStripMenuItem '
		Dim cm As New ContextMenuStrip With {.Font = New Font(Me.Font, FontStyle.Regular)}
		Dim cmi As New ToolStripMenuItem
		cm.ShowImageMargin = My.App.HLShowMenuIcons
		For Each t As ToolStripItem In HLGenerateMenuItems(link.Name) : cm.Items.Add(t)
		Next
		If Not cm.Items.Item(0).Text = My.App.HLEmptyText And cm.Items.Count > 1 Then
			cm.Items.Add(New ToolStripSeparator)
			Dim cmiClick As New ToolStripMenuItem("Start All")
			If My.App.HLShowMenuIcons Then cmiClick.Image = My.Resources.Resources.imageGoStart 'DirectCast(My.App.AppResources.GetObject("imageGoStart"), Image)
			cmiClick.Tag = link.Name
			AddHandler cmiClick.MouseUp, AddressOf CMIHLStartAllMouseUp
			cm.Items.Add(cmiClick)
			cmiClick = New ToolStripMenuItem("ReStart All")
			If My.App.HLShowMenuIcons Then cmiClick.Image = My.Resources.Resources.imageGoReStart 'DirectCast(My.App.AppResources.GetObject("imageGoReStart"), Image)
			cmiClick.Tag = link.Name
			AddHandler cmiClick.MouseUp, AddressOf CMIHLReStartAllMouseUp
			cm.Items.Add(cmiClick)
			cmiClick = New ToolStripMenuItem("Close All")
			If My.App.HLShowMenuIcons Then cmiClick.Image = My.Resources.Resources.imageClose 'DirectCast(My.App.AppResources.GetObject("imageClose"), Image)
			cmiClick.Tag = link.Name
			AddHandler cmiClick.MouseUp, AddressOf CMIHLCloseAllMouseUp
			cm.Items.Add(cmiClick)
		End If
		cmi.DropDown = cm
		cmi.Text = link.Name
		If Not link.HotKey = My.App.HLHotKey.None Then
			cmi.Text += "  (" + link.HotKey.ToString + ")"
			cmi.ToolTipText = My.App.HLHotKeyToStringLong(link.HotKey)
		End If
		If Not String.IsNullOrEmpty(link.Description) Then cmi.ToolTipText = link.Description + IIf(String.IsNullOrEmpty(cmi.ToolTipText), String.Empty, Chr(13) + cmi.ToolTipText).ToString
		cmi.Tag = link.Name
		AddHandler cmi.MouseUp, AddressOf CMIHLGroupMouseUp
		Return cmi
		cm.Dispose()
		cmi.Dispose()
	End Function
	Private Function HLGenerateGroupList(ByRef group As String) As Collections.Generic.List(Of My.App.HLItemType) '
		HLGenerateGroupList = New Collections.Generic.List(Of My.App.HLItemType)
		If HLGroupEnabled(group) Then
			For Each link As My.App.HLItemType In My.App.HLData : If String.Equals(link.Group, group, StringComparison.CurrentCultureIgnoreCase) And Not link.Type = My.App.HLType.Group And Not link.Disabled Then HLGenerateGroupList.Add(link)
			Next
		End If
	End Function
	Private Function HLGenerateNewLink() As My.App.HLItemType '
		If Me.comboboxHLType.SelectedIndex = My.App.HLType.Group Then
			Me.textboxHLLink.ResetText()
			Me.textboxHLArguments.ResetText()
			Me.checkboxHLSingleInstance.Checked = False
			Me.checkboxHLUseAlternateStartMethod.Checked = False
			Me.textboxHLUseAlternateStartTimeOut.Text = "0"
			'Me.checkboxHLUseAlternateCloseMethod.Checked = False
			Me.textboxHLWorkingDirectory.ResetText()
			Me.comboboxHLWindowState.SelectedIndex = -1
			Me.comboboxHLPriority.SelectedIndex = -1
			'Me.listboxHLCloseAppList.Items.Clear()
		ElseIf Me.comboboxHLType.SelectedIndex = My.App.HLType.Separator Then
			Me.textboxHLDescription.ResetText()
			Me.textboxHLLink.ResetText()
			Me.textboxHLArguments.ResetText()
			Me.checkboxHLSingleInstance.Checked = False
			Me.checkboxHLUseAlternateStartMethod.Checked = False
			Me.textboxHLUseAlternateStartTimeOut.Text = "0"
			'Me.checkboxHLUseAlternateCloseMethod.Checked = False
			Me.textboxHLWorkingDirectory.ResetText()
			Me.comboboxHLWindowState.SelectedIndex = -1
			Me.comboboxHLPriority.SelectedIndex = -1
			Me.comboboxHLHotKey.SelectedIndex = -1
			Me.checkboxHLHideInMenu.Checked = False
			Me.checkboxHLDisabled.Checked = False
			'Me.listboxHLCloseAppList.Items.Clear()
		End If
		If Me.comboboxHLType.SelectedIndex = My.App.HLType.Separator Then Me.textboxHLName.ResetText()
		Dim link As New My.App.HLItemType With {
			.Name = Me.textboxHLName.Text,
			.Description = Me.textboxHLDescription.Text,
			.Link = Me.textboxHLLink.Text,
			.Arguments = Me.textboxHLArguments.Text,
			.WorkingDirectory = Me.textboxHLWorkingDirectory.Text,
			.SingleInstance = Me.checkboxHLSingleInstance.Checked,
			.UseAlternateStartMethod = Me.checkboxHLUseAlternateStartMethod.Checked,
			.UseAlternateStartTimeOut = CByte(Val(Me.textboxHLUseAlternateStartTimeOut.Text)),
			.HideInMenu = Me.checkboxHLHideInMenu.Checked,
			.Disabled = Me.checkboxHLDisabled.Checked}
		Select Case Me.comboboxHLGroup.SelectedIndex
			Case -1
				Me.comboboxHLGroup.SelectedIndex = 0
				link.Group = ""
			Case 0 : link.Group = ""
			Case > 0 : link.Group = Me.comboboxHLGroup.Text
		End Select
		Select Case Me.comboboxHLType.SelectedIndex
			Case -1
				Me.comboboxHLType.SelectedIndex = 0
				link.Type = My.App.HLType.Auto
			Case > -1 : link.Type = CType(Me.comboboxHLType.SelectedIndex, My.App.HLType)
		End Select
		Select Case Me.comboboxHLPriority.SelectedIndex
			Case -1
				Me.comboboxHLPriority.SelectedIndex = 3
				link.Priority = Diagnostics.ProcessPriorityClass.Normal
			Case 0 : link.Priority = Diagnostics.ProcessPriorityClass.RealTime
			Case 1 : link.Priority = Diagnostics.ProcessPriorityClass.High
			Case 2 : link.Priority = Diagnostics.ProcessPriorityClass.AboveNormal
			Case 3 : link.Priority = Diagnostics.ProcessPriorityClass.Normal
			Case 4 : link.Priority = Diagnostics.ProcessPriorityClass.BelowNormal
			Case 5 : link.Priority = Diagnostics.ProcessPriorityClass.Idle
		End Select
		Select Case Me.comboboxHLWindowState.SelectedIndex
			Case -1
				Me.comboboxHLWindowState.SelectedIndex = 0
				link.WindowState = Diagnostics.ProcessWindowStyle.Normal
			Case 0 : link.WindowState = Diagnostics.ProcessWindowStyle.Normal
			Case 1 : link.WindowState = Diagnostics.ProcessWindowStyle.Minimized
			Case 2 : link.WindowState = Diagnostics.ProcessWindowStyle.Maximized
		End Select
		Select Case Me.comboboxHLHotKey.SelectedIndex
			Case -1
				Me.comboboxHLHotKey.SelectedIndex = 0
				link.HotKey = My.App.HLHotKey.None
			Case > -1 : link.HotKey = CType(Me.comboboxHLHotKey.SelectedIndex, My.App.HLHotKey)
		End Select
		Return link
	End Function
	Private Function HLGetIcon(ByRef link As My.App.HLItemType) As Image
		If String.IsNullOrEmpty(link.Link) And Not link.Type = My.App.HLType.Group Then : HLGetIcon = Me.cmiWSTHLMenu.Image
		Else
			Select Case link.Type
				Case My.App.HLType.Auto
					Try
						HLGetIcon = Skye.WinAPI.GetApplicationIcon(link.Link)?.ToBitmap
						If HLGetIcon Is Nothing Then HLGetIcon = My.Resources.Resources.imageHLApp
					Catch
						HLGetIcon = My.Resources.Resources.imageHLApp
						My.App.WriteToLog(My.App.Tools.HotLinks, "GetHotLinkIcon : Unable to get process info for '" + link.Name + "'. Defaults will be used.")
					End Try
				Case My.App.HLType.Group : HLGetIcon = My.Resources.Resources.imageHLGroup
				Case My.App.HLType.WebLink : HLGetIcon = My.Resources.Resources.imageHLWeb
				Case My.App.HLType.Document : HLGetIcon = My.Resources.Resources.imageHLDoc
				Case My.App.HLType.Script : HLGetIcon = My.Resources.Resources.imageHLScript
				Case Else : HLGetIcon = My.Resources.Resources.imageHLApp
			End Select
		End If
	End Function
	Private Function HLFindFirstIndex(ByRef groupname As String, ByRef sourceindex As Integer) As Integer '
		For index As Integer = 0 To My.App.HLData.Count - 1 : If My.App.HLData(index).Group = groupname Then Return index
		Next
		Return sourceindex
	End Function
	Private Function HLFindLastIndex(ByRef groupname As String, ByRef sourceindex As Integer) As Integer '
		Dim foundindex As Integer = -1
		For index As Integer = 0 To My.App.HLData.Count - 1 : If My.App.HLData(index).Group = groupname Then foundindex = index
		Next
		If foundindex = -1 Then : Return sourceindex
		Else : Return foundindex
		End If
	End Function
	Private Function HLIsSingleInstance(ByRef link As My.App.HLItemType) As Boolean '
		If link.SingleInstance Then
			Try
				ProcessListGenerate()

				For Each pitem As ProcessListType In ProcessList
					If pitem.FileName.Equals(link.Link, StringComparison.CurrentCultureIgnoreCase) Then
						Try
							Dim plist As Diagnostics.Process() = Diagnostics.Process.GetProcessesByName(pitem.ProcessName)
							For Each p As System.Diagnostics.Process In plist : Skye.WinAPI.SetForegroundWindow(p.MainWindowHandle) : Next
						Catch
						End Try
						Return True
					End If
				Next
				Return False
			Catch : Return False
			End Try
		Else : Return False
		End If
	End Function
	Private Function HLDuplicateGroupExists(ByRef groupname As String) As Boolean '
		If My.App.HLData.Count > 0 And Not HLEditName = groupname Then
			For index As Integer = 0 To My.App.HLData.Count - 1 : If My.App.HLData(index).Type = My.App.HLType.Group And String.Equals(My.App.HLData(index).Name, groupname, StringComparison.CurrentCultureIgnoreCase) Then Return True
			Next
			Return False
		Else : Return False
		End If
	End Function
	Private Function HLGroupEnabled(ByRef group As String) As Boolean '
		For Each link As My.App.HLItemType In My.App.HLData
			If link.Type = My.App.HLType.Group And String.Equals(link.Name, group, StringComparison.CurrentCultureIgnoreCase) Then
				If link.Disabled Then : Return False
				Else : Return True
				End If
			End If
		Next
		Return False
	End Function

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
			Me.tipInfo.SetToolTip(Me.btnWLRefresh, "Stopping File Search, Please Wait...")
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
		If Not InUseSettings() And Not InUseWL() And Not (Me.TimerHLStartUp.Enabled And My.App.HLStartUpDelay < My.App.WLStartUpDelay) Then
			Me.TimerWLStartUp.Stop()
			WLStartUp = False
			UpdateWSTCancelState()
			ShowWL()
		End If
		If Me.TimerWLStartUp.Enabled Then Me.TimerWLStartUp.Interval = My.App.WLStartUpDelay * 100
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
                                        Dim cm As New ContextMenuStrip With {.Font = New Font(Me.Font, FontStyle.Regular)}
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
                                    Dim cm As New ContextMenuStrip With {.Font = New Font(Me.Font, FontStyle.Regular)}
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
									If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageClose 'DirectCast(My.App.AppResources.GetObject("imageClose"), Image)
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
                                    mi.DropDown = cm
                                    AddHandler mi.MouseUp, AddressOf CMIWLMenusMouseUp
                                    traymenu.Items.Add(mi)
                                    'Menu Options
                                    cmitem = New ToolStripMenuItem("Settings")
									If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageSettings 'DirectCast(My.App.AppResources.GetObject("imageSettings"), Image)
									AddHandler cmitem.MouseUp, AddressOf CMIWLSettingsMouseUp
                                    traymenu.Items.Add(cmitem)
                                    traymenu.Items.Add(New ToolStripSeparator)
                                    cmitem = New ToolStripMenuItem("Close WinLinks Tray")
									If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageClose 'DirectCast(My.App.AppResources.GetObject("imageClose"), Image)
									AddHandler cmitem.MouseUp, AddressOf CMIWLCloseMouseUp
                                    traymenu.Items.Add(cmitem)
                                    cmitem = New ToolStripMenuItem("Exit SkyeTools")
									If My.App.WLData(CInt(trayicon.Tag)).ShowMenuIcons Then cmitem.Image = My.Resources.Resources.imageClose 'DirectCast(My.App.AppResources.GetObject("imageClose"), Image)
									cmitem.ToolTipText = My.App.CloseAllToolTipText
                                    AddHandler cmitem.MouseUp, AddressOf CMICloseAllMouseUp
                                    traymenu.Items.Add(cmitem)
                                    traymenu.Tag = trayicon.Tag
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
            If Not WLAutoRefreshUpdate Then My.App.ShowBalloon(My.App.Tools.WinLinks, "WinLinks Loaded", My.App.BalloonDelay.Medium)
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
								trayicon.ContextMenuStrip = New ContextMenuStrip
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
							Dim traymenu As New ContextMenuStrip With {.Font = New Font(Me.Font, FontStyle.Regular)}
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
		If My.App.WSTShowWLMenu Or My.App.WSTShowWLTray Then
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
				My.App.ShowMessage(My.App.Tools.WinLinks, "Cannot Start ", link.ToUpper + Chr(13) + Chr(13) + ex.Message, "Please Check Your Settings And Try Again")
				My.App.WriteToLog(My.App.Tools.WinLinks, "Unable to start " + link.ToUpper + "." + Chr(13) + ex.ToString)
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
			Me.tipInfo.SetToolTip(Me.btnWLRefresh, "Refresh ALL Data & Menus")
			Me.btnWLRefresh.Image = My.Resources.Resources.imageSwap 'DirectCast(My.App.AppResources.GetObject("imageSwap"), Image)
			Me.btnWLRefresh.Font = New Font(Me.btnWLRefresh.Font, FontStyle.Regular)
		Else
			Me.btnSettingsRestore.Enabled = False
			Me.btnWLRefresh.Text = "CANCEL"
			Me.tipInfo.SetToolTip(Me.btnWLRefresh, "Cancel File Search")
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
		Dim cm As New ContextMenuStrip With {.Font = New Font(Me.Font, FontStyle.Regular)}
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
