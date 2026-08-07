
Imports System.Text.Json
Imports System.Text.Json.Serialization
Imports Skye.Common

Namespace My

	Friend Module App

#Region "HotClicks (HC)"

		'Declarations
		Friend Enum HCAction 'MUST KEEP SAME ORDER AS HCGenerateHotClickActionList SUB
			NoAction
			Menu
			WLNew
			WLEdit
			WLOpenRoot
			WLRefresh
			WSTLockWorkSpace
			WSTScreenSaverActivate
			WSTScreenSaverDisable
			WSTClock
			ShowSettings
			ShowSettingsHC
			ShowSettingsHK
			ShowSettingsWST
			ShowSettingsWL
			ShowSettingsWSTSS
			ShowSettingsAC
		End Enum
		Friend Structure HCActionType
			Dim Name As HCAction
			Dim Description As String
			Sub New(action As HCAction, text As String)
				Name = action
				Description = text
			End Sub
		End Structure
		Private Sub HCGenerateActionList() 'MUST KEEP SAME ORDER AS HCAction ENUM
			HCActions.Clear()
			HCActions.Add(New HCActionType(HCAction.NoAction, "No Action"))
			HCActions.Add(New HCActionType(HCAction.Menu, "Context Menu"))
			HCActions.Add(New HCActionType(HCAction.WLNew, "New WinLink"))
			HCActions.Add(New HCActionType(HCAction.WLEdit, "Edit WinLink"))
			HCActions.Add(New HCActionType(HCAction.WLOpenRoot, "Open WinLink Root Folder"))
			HCActions.Add(New HCActionType(HCAction.WLRefresh, "Refresh WinLink"))
			HCActions.Add(New HCActionType(HCAction.WSTLockWorkSpace, "Lock WorkSpace"))
			HCActions.Add(New HCActionType(HCAction.WSTScreenSaverActivate, "Activate Screen Saver"))
			HCActions.Add(New HCActionType(HCAction.WSTScreenSaverDisable, "Enable/Disable Screen Saver"))
			HCActions.Add(New HCActionType(HCAction.WSTClock, "Toggle Clock"))
			HCActions.Add(New HCActionType(HCAction.ShowSettings, "Show Settings Window (Last Page)"))
			HCActions.Add(New HCActionType(HCAction.ShowSettingsHC, "Show HotClick Settings"))
			HCActions.Add(New HCActionType(HCAction.ShowSettingsHK, "Show HotKey Settings"))
			HCActions.Add(New HCActionType(HCAction.ShowSettingsWST, "Show WorkSpace Tool Settings"))
			HCActions.Add(New HCActionType(HCAction.ShowSettingsWL, "Show WinLink Settings"))
			HCActions.Add(New HCActionType(HCAction.ShowSettingsWSTSS, "Show Screen Saver Settings"))
			HCActions.Add(New HCActionType(HCAction.ShowSettingsAC, "Show Alarm & Chime Settings"))
		End Sub

		'Saved Settings
		Friend HCActions As New Collections.Generic.List(Of HCActionType)
		Friend HCWSTLeft, HCWSTDouble, HCWSTMiddle, HCWSTRight As HCAction
		Friend HCWSTScreenSaverLeft, HCWSTScreenSaverDouble, HCWSTScreenSaverMiddle, HCWSTScreenSaverRight As HCAction
		Friend HCWLLeft, HCWLDouble, HCWLMiddle, HCWLRight As HCAction
		Friend HCCBLeft, HCCBDouble, HCCBMiddle, HCCBRight As HCAction

#End Region
#Region "HotKeys (HK)"

		'Declarations
		Friend Structure HKType
			Dim Description As String
			Dim WinID As Integer
			Dim Key As Keys
			Dim KeyCode As Byte
			Dim KeyMod As Byte
		End Structure
		Friend Sub HKGenerateKeyList()
			HKKeys.Clear()
			HKKeys.Add(HKWSTLockWorkSpace)
			HKKeys.Add(HKWSTScreenSaver)
			HKKeys.Add(HKWSTClock)
			HKKeys.Add(HKWSTTaskManager)
			HKKeys.Add(HKWSTCommandPrompt)
			HKKeys.Add(HKWL)
		End Sub

		'Saved Settings
		Friend HKWSTLockWorkSpace As New HKType
		Friend HKWSTScreenSaver As New HKType
		Friend HKWSTClock As New HKType
		Friend HKWSTTaskManager As New HKType
		Friend HKWSTCommandPrompt As New HKType
		Friend HKWL As New HKType
		Friend HKKeys As New Collections.Generic.List(Of HKType)
		Friend HKEnabled As Boolean

#End Region

#Region "WorkSpace Tools (WST)"

		' Saved Settings
		Friend WSTLoadOnOSStartup As Boolean
		Friend WSTLoadOnOSStartupPath As FileType
		Friend WSTEnabled As Boolean
		Friend WSTShowTaskManager As Boolean
		Friend WSTTaskManager As FileType
		Friend WSTShowCommandPrompt As Boolean
		Friend WSTCommandPrompt As FileType
		Friend WSTShowClock As Boolean
		Friend WSTClockLocation As Point
		Friend WSTClockSize As ClockSize
		Friend WSTShowLockWorkSpace As Boolean
		Friend WSTShowLogOff As Boolean
		Friend WSTShowSleep As Boolean
		Friend WSTShowHibernate As Boolean
		Friend WSTShowReStart As Boolean
		Friend WSTShowShutDown As Boolean
		Friend WSTShowHelp As Boolean
		Friend WSTShowLog As Boolean

		' Declarations
		Friend Enum ClockSize
			Small
			Medium
			Large
		End Enum
		Friend Const WSTName As String = "WorkSpace Tools"
		Friend ReadOnly WSTLoadOnOSStartupPathDefault As New FileType(String.Empty, String.Empty)
		Friend ReadOnly WSTTaskManagerDefault As New FileType(System.Environment.GetEnvironmentVariable("windir").ToString + "\system32\taskmgr.exe", Nothing) 'C:\WINDOWS\system32\taskmgr.exe
		Friend ReadOnly WSTCommandPromptDefault As New FileType(System.Environment.GetEnvironmentVariable("windir").ToString + "\system32\cmd.exe", "/K CD /D %USERPROFILE%") 'C:\WINDOWS\system32\cmd.exe /K CD /D %USERPROFILE%"
		Friend Structure FileType
			Dim Path As String
			Dim Arguments As String
			Sub New(path As String, args As String)
				Me.Path = path
				If String.IsNullOrEmpty(args) Then : Me.Arguments = String.Empty
				Else : Me.Arguments = args
				End If
			End Sub
			Overrides Function ToString() As String
				If String.IsNullOrEmpty(Me.Arguments) Then : Return Me.Path
				Else : Return Me.Path + " (" + Me.Arguments + ")"
				End If
			End Function
		End Structure

#End Region
#Region "ScreenSaver (SS)"

		' Saved Settings
		Friend WSTSSToolEnabled As Boolean
		Friend WSTSSStartUp As WSTSSStartUpMode
		Friend WSTSSEnableOnActivate As Boolean
		Friend WSTShowSSIcon As Boolean
		Friend WSTShowSSActivate As Boolean
		Friend WSTShowSSEnabled As Boolean

		' Declarations
		Friend Enum WSTSSStartUpMode
			Enabled
			Disabled
		End Enum

#End Region
#Region "Alarm & Chime (AC)"
		Friend WSTShowAC As Boolean

		Friend Enum ACChimeType '*If you change this, modify GetSettings!
			Simple      'One Chime
			Extended    'Four Chimes
			HourTick    'x Chimes Based On Hour
			Forever 'Until User Intervenes
		End Enum
		Friend ACChime As Byte()

		Friend ACAlarmTime As TimeSpan
		Friend ACAlarmRecurring As Boolean
		Friend ACAlarmChimePath As String 'Full File Path to .WAV file, or Empty String for Default Chime
		Friend ACAlarmChimeType As ACChimeType 'Simple, Extended, Forever
		Friend ACTopHourChimeEnabled As Boolean
		Friend ACTopHourChimePath As String 'Full File Path to .WAV file, or Empty String for Default Chime
		Friend ACTopHourChimeType As ACChimeType 'Simple, Extended, HourTick
		Friend ACOffHourChimePath As String 'Full File Path to .WAV file, or Empty String for Default Chime
		Friend ACTopHourBeforeChimeEnabled As Boolean
		Friend ACTopHourAfterChimeEnabled As Boolean
		Friend ACFirstQuarterHourChimeEnabled As Boolean
		Friend ACFirstQuarterHourBeforeChimeEnabled As Boolean
		Friend ACFirstQuarterHourAfterChimeEnabled As Boolean
		Friend ACBottomHourChimeEnabled As Boolean
		Friend ACBottomHourBeforeChimeEnabled As Boolean
		Friend ACBottomHourAfterChimeEnabled As Boolean
		Friend ACThirdQuarterHourChimeEnabled As Boolean
		Friend ACThirdQuarterHourBeforeChimeEnabled As Boolean
		Friend ACThirdQuarterHourAfterChimeEnabled As Boolean
#End Region
#Region "WinLinks (WL)"

		'Saved Settings
		Friend WSTShowWLMenu As Boolean
		Friend WSTShowWLTray As Boolean
		Friend WLData As New Collections.Generic.List(Of WLItemType)
		Friend WLShowFilePathToolTips As Boolean
		Friend WLShowFileInfoToolTips As Boolean
		Friend WLShowFolderPathToolTips As Boolean
		Friend WLMaxLinksPerFolder As Byte '1-100
		Friend WLStartUpDelay As Short 'Range 5-300, Default = 10, 0 = Disable Delay (Load Immediately)
		Friend WLAutoRefresh As Boolean
		Friend WLAutoRefreshInterval As Byte '1 - 90 minutes, Default = 5, Check For Changes Every x Minutes
		Friend WLAutoRefreshIdleInterval As Byte '20-240 seconds, Default = 30, Refresh Only When Folder Idle For x Seconds

		'Declarations
		Friend Const WLEmptyText As String = "< No Items >"
		Friend Enum WLFolderMode
			NoFolders
			ShowAsLink
			ShowAsLinkMenu
			ShowAsMenu
			FoldersOnly
		End Enum
		Friend Enum WLFolderPlacement
			Top
			Bottom
			Merged
		End Enum
		Friend Enum WLYMFMMode
			Files
			FilesWithSubFolders
			Folders
		End Enum
		Public Class WLItemType
			Public Property Root As String = String.Empty
			Public Property Name As String = String.Empty
			Public Property Sort As SortOrder = SortOrder.Ascending
			Public Property FolderMode As WLFolderMode = WLFolderMode.ShowAsMenu
			Public Property FolderPlacement As WLFolderPlacement = WLFolderPlacement.Top
			Public Property UseDefaultIcon As Boolean = False
			Public Property ShowInMenu As Boolean = True
			Public Property ShowInTray As Boolean = True
			Public Property ShowNoMenu As Boolean = False
			Public Property ShowMenuIcons As Boolean = True

			<JsonIgnore>
			Public Property RefreshData As Boolean = True
			<JsonIgnore>
			Public Property RefreshMenu As Boolean = True

			Public Sub New()
			End Sub
			Public Sub New(path As String)
				Me.Root = path
			End Sub
		End Class

#End Region

		' Declarations
		Friend Enum NotifyInterval
			[Short]
			[Medium]
			[Long]
		End Enum
		Friend Enum NotifyIntervalFormat
			MilliSeconds
			Seconds
		End Enum
		Friend Function NotifyDelay(interval As NotifyInterval, format As NotifyIntervalFormat) As UInt16 '
			Select Case interval
				Case NotifyInterval.Short
					Select Case format
						Case NotifyIntervalFormat.MilliSeconds : Return 4000
						Case NotifyIntervalFormat.Seconds : Return 4
					End Select
				Case NotifyInterval.Medium
					Select Case format
						Case NotifyIntervalFormat.MilliSeconds : Return 10000
						Case NotifyIntervalFormat.Seconds : Return 10
					End Select
				Case NotifyInterval.Long
					Select Case format
						Case NotifyIntervalFormat.MilliSeconds : Return 20000
						Case NotifyIntervalFormat.Seconds : Return 20
					End Select
			End Select
			Return 0
		End Function
		Friend Enum BalloonDelay
			[Short]
			[Medium]
			[Long]
			WaitForUser
			WaitForEver
		End Enum
		Friend Enum FormatFileSizeUnits
			Auto
			Bytes
			KiloBytes
			MegaBytes
			GigaBytes
		End Enum
		Friend Enum Tools 'Modify ToolToImage capacity, ToolToString, & MainForm.New when changing this Enum
			SkyeTools
			HotClicks
			HotKeys
			WorkSpaceTools
			ScreenSaver
			Clock
			AlarmChime
			WinLinks
		End Enum
		Friend ToolToImage(7) As Image
		Friend Function ToolToString(tool As Tools) As String '
			Select Case tool
				Case Tools.SkyeTools : Return "SkyeTools"
				Case Tools.WorkSpaceTools : Return "WorkSpace Tools"
				Case Tools.ScreenSaver : Return "Screen Saver"
				Case Tools.AlarmChime : Return "Alarm / Chime"
				Case Else : Return tool.ToString
			End Select
		End Function
		Friend Enum TrayTools
			WorkSpaceTools
			ScreenSaver
			HotLinks
			WinLinks
			OnlineAlerter
		End Enum
		Friend Function GetEnumMembers(ByRef enummember As System.Enum) As Collections.Generic.List(Of String)
			Dim list As New Collections.Generic.List(Of String)
			Dim names() As String = System.Enum.GetNames(enummember.GetType)
			For Each s As String In names : list.Add(s)
			Next
			Return list
		End Function
		Friend Const UseAlternateStartMethodToolTipText As String = "Will start the Application and wait the specified TimeOut before starting the next Application." _
				+ vbCr + "This will allow an Application to fully load before starting the next one, to avoid causing traffic jams like Windows does!"
		Friend Const UseAlternateCloseMethodToolTipText As String = "Will try to close the Application using the Standard Windows Close Method." _
				+ vbCr + "Try this if the Primary Method fails to properly close the Application." _
				+ vbCr + "Both methods will Force Kill the Application when the TimeOut is reached."
		Friend Const CloseAllToolTipText As String = "RightClick = ReStart SkyeTools" + vbCr + "CtrlRightClick = ReStart In Current Context"
		Friend ReadOnly AdjustScreenBoundsNormalWindow As Byte = 8 ' The number of pixels to adjust the screen bounds for normal windows.
		Friend ReadOnly AdjustScreenBoundsDialogWindow As Byte = 10 ' The number of pixels to adjust the screen bounds for dialog windows.
		Friend AppIsClosing As Boolean = False
		Friend ReadOnly MenuFont As New Font("Segoe UI", 12, FontStyle.Regular) ' The font used for context menus.
		Friend FrmMain As MainForm
		Friend FrmLog As Log
		Friend FrmBalloon As Balloon
		Friend FrmInfo As InfoForm
		Friend Function FrmInfoVisible() As Boolean
			If FrmInfo IsNot Nothing Then
				Return FrmInfo.Visible
			End If
			Return False
		End Function
		Friend FrmMessage As MessageForm
		Friend Function FrmMessageVisible() As Boolean
			If FrmMessage IsNot Nothing Then
				Return FrmMessage.Visible
			End If
			Return False
		End Function
#If DEBUG Then
		Private ReadOnly RegPath As String = "Software\\" + My.Application.Info.ProductName + "DEV" 'RegPath is the path to the registry key where application settings are stored.
#Else
        Private ReadOnly RegPath As String = "Software\\" + My.Application.Info.ProductName 'RegPath is the path to the registry key where application settings are stored.
#End If
		Private RegKey As Microsoft.Win32.RegistryKey
		Private RegSubKey As Microsoft.Win32.RegistryKey
		Private RegItemKey As Microsoft.Win32.RegistryKey
		Private BalloonHideEnabled As Boolean
		Private WithEvents TimerBalloon As New Timer

		' Methods
		Friend Sub Initialize()
#If DEBUG Then
			Dim baseName As String = My.Application.Info.ProductName & "DEV"
#Else
			Dim baseName As String = My.Application.Info.ProductName
#End If
			Skye.Common.Log.Initialize(baseName)
			Skye.Common.RegistryHelper.BaseKey = System.IO.Path.Combine("Software", baseName)
			WriteToLog(My.App.Tools.SkyeTools, My.Application.Info.ProductName + " Started...")
			System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance) 'Allows use of Windows-1252 character encoding, needed for clipboard text manipulation functions & TextboxContextMenu in Skye Library.
			Debug.Print("OnStartup, Alternate Start? " + My.Application.AlternateStart.ToString)
			GetSettings()
#If DEBUG Then
			GetSettingsDebug()
#End If
			FrmMain = New MainForm
		End Sub
		Friend Sub Finalize()
			WriteToLog(My.App.Tools.SkyeTools, "..." + My.Application.Info.ProductName + " Closed")
		End Sub
		Friend Sub GetSettings()
			RegKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegPath)

			GetSettingsHC()
			GetSettingsHK()
			GetSettingsWST()
			GetSettingsAC()
			GetSettingsWL()

			RegKey.Close()
			HCGenerateActionList()
			HKGenerateKeyList()
		End Sub
		Friend Sub SaveSettings()
			RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegPath, True)

			SaveSettingsHC()
			SaveSettingsHK()
			SaveSettingsWST()
			SaveSettingsAC()
			SaveSettingsWL()

			RegKey.Flush()
			RegKey.Close()
		End Sub
		Friend Sub SetLoadOnOSStartup()
			Try
				RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run\", True)
				If WSTLoadOnOSStartup And Not String.IsNullOrEmpty(WSTLoadOnOSStartupPath.Path) Then : RegKey.SetValue("SkyeTools", IIf(String.IsNullOrEmpty(WSTLoadOnOSStartupPath.Arguments), WSTLoadOnOSStartupPath.Path, WSTLoadOnOSStartupPath.Path + " " + WSTLoadOnOSStartupPath.Arguments).ToString, Microsoft.Win32.RegistryValueKind.String)
				Else : RegKey.DeleteValue("SkyeTools", False)
				End If
			Catch
				WriteToLog(Tools.SkyeTools, "Error Setting AutoLoad Options To Windows Registry")
			Finally
				If RegKey IsNot Nothing Then RegKey.Close()
			End Try
		End Sub
		Friend Sub SetBalloon()
			Try
				FrmBalloon?.Close()
				FrmBalloon?.Dispose()
				FrmBalloon = Nothing
			Catch
			Finally : FrmBalloon = New Balloon
			End Try
		End Sub
		Friend Sub ShowBalloon(tool As Tools, text As String, delay As BalloonDelay)
			Try
				BalloonHideEnabled = True
				HideBalloon()
				FrmBalloon.picboxIcon.Image = ToolToImage(tool)
				FrmBalloon.lblTitle.Text = ToolToString(tool)
				FrmBalloon.lblText.Text = text
				FrmBalloon.Left = My.Computer.Screen.WorkingArea.Right - FrmBalloon.Width - 25
				FrmBalloon.Top = My.Computer.Screen.WorkingArea.Top + 25
				FrmBalloon.Visible = True
				FrmBalloon.Refresh()

				Select Case delay
					Case BalloonDelay.Short : TimerBalloon.Interval = NotifyDelay(NotifyInterval.Short, NotifyIntervalFormat.MilliSeconds)
					Case BalloonDelay.Medium : TimerBalloon.Interval = NotifyDelay(NotifyInterval.Medium, NotifyIntervalFormat.MilliSeconds)
					Case BalloonDelay.Long : TimerBalloon.Interval = NotifyDelay(NotifyInterval.Long, NotifyIntervalFormat.MilliSeconds)
					Case BalloonDelay.WaitForUser : TimerBalloon.Interval = 1
					Case BalloonDelay.WaitForEver
						TimerBalloon.Interval = 1
						BalloonHideEnabled = False
				End Select
				If TimerBalloon.Interval > 1 Then TimerBalloon.Start()
			Catch ex As Exception : WriteToLog(Tools.SkyeTools, "ShowBalloon Managed Error" + Chr(13) + ex.ToString)
			End Try
		End Sub
		Friend Sub HideBalloon()
			On Error Resume Next
			If FrmBalloon.Visible And BalloonHideEnabled Then
				TimerBalloon.Stop()
				FrmBalloon.Hide()
			End If
		End Sub
		Friend Sub ShowInfo(tool As Tools, title As String, message As String, postmessage As String, Optional icon As Icon = Nothing, Optional wordwrap As Boolean = False, Optional scrolltotop As Boolean = True, Optional showmaximized As Boolean = False)
			Try
				If FrmInfoVisible() Then FrmInfo.Close()
				FrmInfo = New InfoForm
				If icon Is Nothing Then : FrmInfo.Icon = Resources.Resources.iconApp 'DirectCast(AppResources.GetObject("iconApp"), Icon)
				Else : FrmInfo.Icon = icon
				End If
				FrmInfo.Text = tool.ToString + " " + title
				FrmInfo.rtbMessage.ResetText()
				FrmInfo.rtbMessage.AppendText(message)
				If scrolltotop Then FrmInfo.rtbMessage.Select(0, 0)
				If wordwrap Then FrmInfo.rtbMessage.WordWrap = True
				FrmInfo.tbPostMessage.Text = postmessage
				If title = "Log" Then
					Dim lines As Integer = 0
					If FrmInfo.rtbMessage.Lines(0).Length > 0 Then lines = FrmInfo.rtbMessage.GetLineFromCharIndex(FrmInfo.rtbMessage.Text.Length)
					If lines > 0 Then
						FrmInfo.tbPostMessage.Text += "  (" + lines.ToString + IIf(lines > 1, " Lines", " Line").ToString + ")"
						FrmInfo.btnDeleteLog.Visible = True
					End If
					FrmInfo.btnRefreshLog.Visible = True
				End If
				FrmInfo.btnClose.Select()
				FrmInfo.Show()
				If showmaximized Then FrmInfo.ChangeWindowState()
				FrmInfo.rtbMessage.Focus()
			Catch ex As Exception : WriteToLog(Tools.SkyeTools, "ShowInfo Managed Error" + Chr(13) + ex.ToString)
			End Try
		End Sub
		Friend Sub ShowMessage(tool As Tools, title As String, message As String, postmessage As String, Optional icon As Icon = Nothing)
			Try
				FrmMessage = New MessageForm
				If icon Is Nothing Then
					Select Case tool
						Case Tools.SkyeTools : FrmMessage.Icon = Resources.Resources.iconApp 'DirectCast(AppResources.GetObject("iconApp"), Icon)
						Case Else : FrmMessage.Icon = Resources.Resources.iconApp 'DirectCast(AppResources.GetObject("iconApp"), Icon)
					End Select
				Else : FrmMessage.Icon = icon
				End If
				FrmMessage.Text = tool.ToString + " " + title
				FrmMessage.rtbMessage.ResetText()
				FrmMessage.rtbMessage.AppendText(message)
				FrmMessage.rtbMessage.SelectAll()
				FrmMessage.rtbMessage.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center
				FrmMessage.rtbMessage.Select(0, 0)
				FrmMessage.rtbMessage.ClearUndo()
				FrmMessage.tbPostMessage.Text = postmessage
				FrmMessage.btnClose.Select()
				FrmMessage.ShowDialog()
			Catch ex As Exception : WriteToLog(Tools.SkyeTools, "ShowMessage Managed Error" + Chr(13) + ex.ToString)
			End Try
		End Sub
		Friend Sub ShowHelp(Optional showmaximized As Boolean = False)
			Dim logtext As String = "HotKeys -- If the title of a HotKey on the Settings Page is grayed out, but HotKeys are enabled, this means that the feature is not active and the HotKey will not function even though it can be set. Activate the feature and the HotKey will function normally."
			logtext += Chr(13) + Chr(13) + "HotKeys -- The InfoTip of the HotKey Header will display which HotLinks are assigned to that HotKey."
			logtext += Chr(13) + Chr(13) + "HotKeys -- The 'Open WinLink Root Folder' HotKey will open the last WinLink folder. This folder is also used as the AutoRefresh folder."
			logtext += Chr(13) + Chr(13) + "WorkSpace Tools -- Disabling the ScreenSaver does not affect any Windoze settings, it merely activates a 'keep alive' function for the App that will prevent Windoze from going idle relative to display and power functions. Activating the Screen Saver from the HotKey will not enable the Screen Saver even if the 'Enable On Activate' option is set. This is so the HotKey can be used for emergency purposes and not interfere with normal WorkSpace functioning."
			logtext += Chr(13) + Chr(13) + "WinLinks -- AutoRefresh will refresh the last WinLink folder."
			logtext += Chr(13) + Chr(13) + "WinLinks -- AutoRefresh will not engage if No Menu Items is selected for the last WinLink."
			logtext += Chr(13) + Chr(13) + "WinLinks -- AutoRefresh, StartUp, & Online Alerter Refresh WinLinks Action will not execute if the Settings Window is in use or any WinLink menus are active."
			logtext += Chr(13) + Chr(13) + "WinLinks -- Folder Modes -- No Folders means that only root files will be shown. Show As Link means root files & folders will be shown. Show As Link Menu means root files, folders, & subfolders will be shown. Show As Menu means all files, folders, & subfolders will be shown. Folders Only means only folders & subfolders will be shown."
			logtext += Chr(13) + Chr(13) + "WinLinks -- While WinLinks are refreshing, the SkyeTools Process Priority is set to Normal, and reset to High when complete. Also, if a WinLink is being edited on the Settings Page when the refresh starts, the edit will be cancelled to avoid conflicts while WinLinks are refreshing."
			logtext += Chr(13) + Chr(13) + "WinLinks -- The HotClick Refresh WinLink is meant to be used with WinLinks Tray Icons. If used with one of the other Tray Icons, it will refresh the last WinLink."
			logtext += Chr(13) + Chr(13) + "Alarm & Chime -- When the Alarm is set to chime Forever, it will chime a maximum of 255 times, or until cancelled."
			logtext += Chr(13) + Chr(13) + "Alarm & Chime -- When the Alarm is set to chime Forever, a text alert will be displayed in the WorkSpace Tools menu. This can be cleared by clicking 'Cancel Alarm', by clicking the bolded 'Alarm / Chime' menu item, or by closing the Balloon."
			logtext += Chr(13) + Chr(13) + "SkyeTools -- Use Alternate Close Method means that another method will be used to close the application. This is useful when the normal method does not work properly and application errors occur."
			logtext += Chr(13) + Chr(13) + "SkyeTools -- Holding the ShiftKey down while the app is starting will put the app into 'Alternate Start Mode'. This means that HotLinks & WinLinks will not AutoLoad on StartUp. You may, however, manually Refresh WinLinks from the WinLinks Settings page."
			logtext += Chr(13) + "When starting the App in 'Alternate Start Mode', the text on the Splash Screen will be red."
			logtext += Chr(13) + Chr(13) + "SkyeTools -- The option to 'ReStart In Current Context' means that the App will ReStart with the same CommandLine parameters as when it was started."
			logtext += Chr(13) + Chr(13) + "CommandLine -- Parameters may be used in any order or combination unless otherwise noted."
			logtext += Chr(13) + "/ALTSTART -- Puts the App into 'Alternate Start Mode'"
			logtext += Chr(13) + "/DELAYEDSTART:xx -- Delays the start of the app for xx seconds. The minimum and default is 2 seconds. The maximum is 300 seconds(5 minutes). The Splash Screen will be displayed during this time."
			If showmaximized Or (FrmInfoVisible() AndAlso FrmInfo.WindowState = FormWindowState.Maximized) Then
				ShowInfo(My.App.Tools.SkyeTools, "Help & About", logtext, "v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString, Resources.Resources.iconInfo, True, True, True)
			Else
				ShowInfo(My.App.Tools.SkyeTools, "Help & About", logtext, "v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString, Resources.Resources.iconInfo, True, True, False)
			End If
		End Sub
		Friend Sub ShowLog(Optional showmaximized As Boolean = False)
			If FrmLog Is Nothing Then
				FrmLog = New Log
				FrmLog.LogViewer.Tip.Font = MenuFont
				FrmLog.Show()
			Else
				FrmLog.BringToFront()
				FrmLog.Focus()
			End If
			If showmaximized Then FrmLog.WindowState = FormWindowState.Maximized
			FrmLog.BTNOK.Select()
		End Sub
		Friend Sub WriteToLog(tool As Tools, text As String)
			Dim logentry As String = $"{tool} --> {text}"
			Skye.Common.Log.Write(logentry)
			Debug.Print("WriteToLog: " & logentry)
		End Sub
		Friend Sub StartFile(file As FileType)
			Try
				If String.IsNullOrEmpty(file.Arguments) Then : Diagnostics.Process.Start(file.Path)
				Else : Diagnostics.Process.Start(file.Path, file.Arguments)
				End If
			Catch ex As Exception
				My.App.WriteToLog(My.App.Tools.WorkSpaceTools, "Cannot Start '" + file.Path + "'" + Chr(13) + ex.ToString)
				My.App.ShowMessage(My.App.Tools.WorkSpaceTools, "Cannot Start '" + file.Path + "'", ex.Message, "Please Check Your Settings And Try Again")
			End Try
		End Sub
		''' <summary>
		''' Checks whether the Mouse Pointer is within the bounds of the Control. Useful for MouseUp Control Events so a user can 'wander' off the control, while holding the button down, without the event triggering.
		''' </summary>
		''' <param name="control">A reference to a Control.</param>
		''' <param name="mouseposition">A reference to the current Mouse Position.</param>
		''' <returns>True if 'mouseposition' is within the bounds of 'control'; otherwise False.</returns>
		Friend Function MouseInBounds(ByRef control As Control, ByRef mouseposition As Point) As Boolean
			If mouseposition.X >= 0 AndAlso mouseposition.X <= control.Width AndAlso mouseposition.Y >= 0 AndAlso mouseposition.Y <= control.Height Then Return True
			Return False
		End Function
		''' <summary>
		''' Replaces one ampersand with x ampersands for controls that interpret ampersands as HotKeys. For ContextMenus, x=2. For TrayIcons, x=3. To Replace With "+", x=0. For No Change, x=1.
		''' </summary>
		Friend Function FixAmpersand(source As String, x As Integer) As String '
			Try
				Select Case x
					Case 0 : Return source
					Case 1 : Return source.Replace("&", "+")
					Case 2 : Return source.Replace("&", "&&")
					Case 3 : Return source.Replace("&", "&&&")
					Case Else : Return source
				End Select
			Catch : Return source
			End Try
		End Function
		Private Sub TimerBalloonTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerBalloon.Tick
			HideBalloon()
		End Sub
		Private Sub UpgradeLegacyWLSettings()
			' Check if legacy "WL" subkey exists under BaseKey
			Dim legacySubKey = $"{RegistryHelper.BaseKey}\WL"
			Using key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(legacySubKey, False)
				If key Is Nothing Then Return ' No legacy settings to migrate
			End Using
			Dim legacyLinks As New List(Of WLItemType)()

			' Read old format
			Using wlKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(legacySubKey, False)
				For Each subKeyName In wlKey.GetSubKeyNames()
					Using itemKey = wlKey.OpenSubKey(subKeyName)
						If itemKey Is Nothing Then Continue For

						Dim rootPath = itemKey.GetValue("", "").ToString()
						If String.IsNullOrEmpty(rootPath) Then Continue For
						Dim link As New WLItemType(rootPath) With {
							.Name = itemKey.GetValue("Name", "").ToString(),
							.UseDefaultIcon = itemKey.GetValue("UseDefaultIcon", "False").ToString() = "True",
							.ShowInMenu = itemKey.GetValue("ShowInMenu", "True").ToString() <> "False",
							.ShowInTray = itemKey.GetValue("ShowInTray", "True").ToString() <> "False",
							.ShowNoMenu = itemKey.GetValue("ShowNoMenu", "False").ToString() = "True",
							.ShowMenuIcons = itemKey.GetValue("ShowMenuIcons", "True").ToString() <> "False"
						}
						Dim result As Boolean
						result = [Enum].TryParse(itemKey.GetValue("Sort", "Ascending").ToString(), link.Sort)
						result = [Enum].TryParse(itemKey.GetValue("FolderMode", "NoFolders").ToString(), link.FolderMode)
						result = [Enum].TryParse(itemKey.GetValue("FolderPlacement", "Top").ToString(), link.FolderPlacement)

						legacyLinks.Add(link)
					End Using
				Next
			End Using

			' Save in new JSON format
			Dim json = JsonSerializer.Serialize(legacyLinks)
			RegistryHelper.SetString("WLData", json)

			' Remove legacy registry tree
			'Using baseKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegistryHelper.BaseKey, True)
			'	baseKey?.DeleteSubKeyTree("WL", False)
			'End Using

		End Sub
		Private Sub GetSettingsHC()
			Dim TypeHCAction As Type = GetType(HCAction)
			Try : HCWSTLeft = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCWSTLeft", "NoAction").ToString), HCAction)
			Catch : HCWSTLeft = HCAction.NoAction
			End Try
			Try : HCWSTDouble = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCWSTDouble", "NoAction").ToString), HCAction)
			Catch : HCWSTDouble = HCAction.NoAction
			End Try
			Try : HCWSTMiddle = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCWSTMiddle", "NoAction").ToString), HCAction)
			Catch : HCWSTMiddle = HCAction.NoAction
			End Try
			Try : HCWSTRight = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCWSTRight", "Menu").ToString), HCAction)
			Catch : HCWSTRight = HCAction.Menu
			End Try
			Try : HCWLLeft = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCWLLeft", "NoAction").ToString), HCAction)
			Catch : HCWLLeft = HCAction.NoAction
			End Try
			Try : HCWLDouble = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCWLDouble", "NoAction").ToString), HCAction)
			Catch : HCWLDouble = HCAction.NoAction
			End Try
			Try : HCWLMiddle = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCWLMiddle", "NoAction").ToString), HCAction)
			Catch : HCWLMiddle = HCAction.NoAction
			End Try
			HCWLRight = HCAction.Menu
			Try : HCCBLeft = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCCBLeft", "NoAction").ToString), HCAction)
			Catch : HCCBLeft = HCAction.NoAction
			End Try
			Try : HCCBDouble = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCCBDouble", "NoAction").ToString), HCAction)
			Catch : HCCBDouble = HCAction.NoAction
			End Try
			Try : HCCBMiddle = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCCBMiddle", "NoAction").ToString), HCAction)
			Catch : HCCBMiddle = HCAction.NoAction
			End Try
			Try : HCCBRight = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCCBRight", "Menu").ToString), HCAction)
			Catch : HCCBRight = HCAction.Menu
			End Try
			Try : HCWSTScreenSaverLeft = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCWSTScreenSaverLeft", "NoAction").ToString), HCAction)
			Catch : HCWSTScreenSaverLeft = HCAction.NoAction
			End Try
			Try : HCWSTScreenSaverDouble = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCWSTScreenSaverDouble", "NoAction").ToString), HCAction)
			Catch : HCWSTScreenSaverDouble = HCAction.NoAction
			End Try
			Try : HCWSTScreenSaverMiddle = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCWSTScreenSaverMiddle", "NoAction").ToString), HCAction)
			Catch : HCWSTScreenSaverMiddle = HCAction.NoAction
			End Try
			Try : HCWSTScreenSaverRight = DirectCast(HCAction.Parse(TypeHCAction, RegKey.GetValue("HCWSTScreenSaverRight", "Menu").ToString), HCAction)
			Catch : HCWSTScreenSaverRight = HCAction.Menu
			End Try
		End Sub
		Private Sub GetSettingsHK()
			Select Case RegKey.GetValue("HKEnabled", "True").ToString
				Case "False", "0" : HKEnabled = False
				Case Else : HKEnabled = True
			End Select
			HKWSTLockWorkSpace.Description = "Lock WorkSpace"
			HKWSTLockWorkSpace.WinID = 1
			Try
				HKWSTLockWorkSpace.Key = CType(Val(RegKey.GetValue("HKWSTLockWorkSpaceKey", "131075")), Keys) 'Pause, Ctrl
				If HKWSTLockWorkSpace.Key < 0 Or HKWSTLockWorkSpace.Key > Integer.MaxValue Then HKWSTLockWorkSpace.Key = CType(262163, Keys)
			Catch
				HKWSTLockWorkSpace.Key = CType(262163, Keys)
			End Try
			Try
				HKWSTLockWorkSpace.KeyCode = CByte(Val(RegKey.GetValue("HKWSTLockWorkSpaceKeyCode", "19"))) 'Pause, Ctrl
				If HKWSTLockWorkSpace.KeyCode < Byte.MinValue Or HKWSTLockWorkSpace.KeyCode > Byte.MaxValue Then HKWSTLockWorkSpace.KeyCode = 19
			Catch
				HKWSTLockWorkSpace.KeyCode = 19
			End Try
			Try
				HKWSTLockWorkSpace.KeyMod = CByte(Val(RegKey.GetValue("HKWSTLockWorkSpaceKeyMod", "2"))) 'Pause, Ctrl
				If HKWSTLockWorkSpace.KeyMod < Byte.MinValue Or HKWSTLockWorkSpace.KeyMod > Byte.MaxValue Then HKWSTLockWorkSpace.KeyMod = 1
			Catch
				HKWSTLockWorkSpace.KeyMod = 2
			End Try
			HKWSTScreenSaver.Description = "Activate Screen Saver"
			HKWSTScreenSaver.WinID = 2
			Try
				HKWSTScreenSaver.Key = CType(Val(RegKey.GetValue("HKWSTScreenSaverKey", "19")), Keys) 'Pause/Break 'PrintScreen = 44
				If HKWSTScreenSaver.Key < 0 Or HKWSTScreenSaver.Key > Integer.MaxValue Then HKWSTScreenSaver.Key = CType(19, Keys)
			Catch
				HKWSTScreenSaver.Key = CType(19, Keys)
			End Try
			Try
				HKWSTScreenSaver.KeyCode = CByte(Val(RegKey.GetValue("HKWSTScreenSaverKeyCode", "19"))) 'Pause/Break
				If HKWSTScreenSaver.KeyCode < Byte.MinValue Or HKWSTScreenSaver.KeyCode > Byte.MaxValue Then HKWSTScreenSaver.KeyCode = 19
			Catch
				HKWSTScreenSaver.KeyCode = 19
			End Try
			Try
				HKWSTScreenSaver.KeyMod = CByte(Val(RegKey.GetValue("HKWSTScreenSaverKeyMod", "0"))) 'Pause/Break
				If HKWSTScreenSaver.KeyMod < Byte.MinValue Or HKWSTScreenSaver.KeyMod > Byte.MaxValue Then HKWSTScreenSaver.KeyMod = 0
			Catch
				HKWSTScreenSaver.KeyMod = 0
			End Try
			HKWSTClock.Description = "Clock"
			HKWSTClock.WinID = 4
			Try
				HKWSTClock.Key = CType(Val(RegKey.GetValue("HKWSTClockKey", "119")), Keys) 'F8
				If HKWSTClock.Key < 0 Or HKWSTClock.Key > Integer.MaxValue Then HKWSTClock.Key = CType(119, Keys)
			Catch
				HKWSTClock.Key = CType(119, Keys)
			End Try
			Try
				HKWSTClock.KeyCode = CByte(Val(RegKey.GetValue("HKWSTClockKeyCode", "119"))) 'F8
				If HKWSTClock.KeyCode < Byte.MinValue Or HKWSTClock.KeyCode > Byte.MaxValue Then HKWSTClock.KeyCode = 119
			Catch
				HKWSTClock.KeyCode = 119
			End Try
			Try
				HKWSTClock.KeyMod = CByte(Val(RegKey.GetValue("HKWSTClockKeyMod", "0"))) 'F8
				If HKWSTClock.KeyMod < Byte.MinValue Or HKWSTClock.KeyMod > Byte.MaxValue Then HKWSTClock.KeyMod = 0
			Catch
				HKWSTClock.KeyMod = 0
			End Try
			HKWSTTaskManager.Description = "Task Manager"
			HKWSTTaskManager.WinID = 5
			Try
				HKWSTTaskManager.Key = CType(Val(RegKey.GetValue("HKWSTTaskManagerKey", "0")), Keys)
				If HKWSTTaskManager.Key < 0 Or HKWSTTaskManager.Key > Integer.MaxValue Then HKWSTTaskManager.Key = 0
			Catch
				HKWSTTaskManager.Key = 0
			End Try
			Try
				HKWSTTaskManager.KeyCode = CByte(Val(RegKey.GetValue("HKWSTTaskManagerKeyCode", "0")))
				If HKWSTTaskManager.KeyCode < Byte.MinValue Or HKWSTTaskManager.KeyCode > Byte.MaxValue Then HKWSTTaskManager.KeyCode = 0
			Catch
				HKWSTTaskManager.KeyCode = 0
			End Try
			Try
				HKWSTTaskManager.KeyMod = CByte(Val(RegKey.GetValue("HKWSTTaskManagerKeyMod", "0")))
				If HKWSTTaskManager.KeyMod < Byte.MinValue Or HKWSTTaskManager.KeyMod > Byte.MaxValue Then HKWSTTaskManager.KeyMod = 0
			Catch
				HKWSTTaskManager.KeyMod = 0
			End Try
			HKWSTCommandPrompt.Description = "Command Prompt"
			HKWSTCommandPrompt.WinID = 6
			Try
				HKWSTCommandPrompt.Key = CType(Val(RegKey.GetValue("HKWSTCommandPromptKey", "0")), Keys)
				If HKWSTCommandPrompt.Key < 0 Or HKWSTCommandPrompt.Key > Integer.MaxValue Then HKWSTCommandPrompt.Key = 0
			Catch
				HKWSTCommandPrompt.Key = 0
			End Try
			Try
				HKWSTCommandPrompt.KeyCode = CByte(Val(RegKey.GetValue("HKWSTCommandPromptKeyCode", "0")))
				If HKWSTCommandPrompt.KeyCode < Byte.MinValue Or HKWSTCommandPrompt.KeyCode > Byte.MaxValue Then HKWSTCommandPrompt.KeyCode = 0
			Catch
				HKWSTCommandPrompt.KeyCode = 0
			End Try
			Try
				HKWSTCommandPrompt.KeyMod = CByte(Val(RegKey.GetValue("HKWSTCommandPromptKeyMod", "0")))
				If HKWSTCommandPrompt.KeyMod < Byte.MinValue Or HKWSTCommandPrompt.KeyMod > Byte.MaxValue Then HKWSTCommandPrompt.KeyMod = 0
			Catch
				HKWSTCommandPrompt.KeyMod = 0
			End Try
			HKWL.Description = "Open WinLink Root Folder"
			HKWL.WinID = 15
			Try
				HKWL.Key = CType(Val(RegKey.GetValue("HKWLKey", "0")), Keys)
				If HKWL.Key < 0 Or HKWL.Key > Integer.MaxValue Then HKWL.Key = 0
			Catch
				HKWL.Key = 0
			End Try
			Try
				HKWL.KeyCode = CByte(Val(RegKey.GetValue("HKWLKeyCode", "0")))
				If HKWL.KeyCode < Byte.MinValue Or HKWL.KeyCode > Byte.MaxValue Then HKWL.KeyCode = 0
			Catch
				HKWL.KeyCode = 0
			End Try
			Try
				HKWL.KeyMod = CByte(Val(RegKey.GetValue("HKWLKeyMod", "0")))
				If HKWL.KeyMod < Byte.MinValue Or HKWL.KeyMod > Byte.MaxValue Then HKWL.KeyMod = 0
			Catch
				HKWL.KeyMod = 0
			End Try
		End Sub
		Private Sub GetSettingsWST()
			Select Case RegKey.GetValue("WSTLoadOnOSStartup", "False").ToString
				Case "True", "1" : WSTLoadOnOSStartup = True
				Case Else : WSTLoadOnOSStartup = False
			End Select
			WSTLoadOnOSStartupPath = New FileType(RegKey.GetValue("WSTLoadOnOSStartupPath", WSTLoadOnOSStartupPathDefault.Path).ToString, RegKey.GetValue("WSTLoadOnOSStartupArgs", WSTLoadOnOSStartupPathDefault.Arguments).ToString)
			Select Case RegKey.GetValue("WSTEnabled", "True").ToString
				Case "False", "0" : WSTEnabled = False
				Case Else : WSTEnabled = True
			End Select
			Select Case RegKey.GetValue("WSTShowTaskManager", "True").ToString
				Case "False", "0" : WSTShowTaskManager = False
				Case Else : WSTShowTaskManager = True
			End Select
			WSTTaskManager = New FileType(RegKey.GetValue("WSTTaskManagerPath", WSTTaskManagerDefault.Path).ToString, RegKey.GetValue("WSTTaskManagerArgs", WSTTaskManagerDefault.Arguments).ToString)
			Select Case RegKey.GetValue("WSTShowCommandPrompt", "True").ToString
				Case "False", "0" : WSTShowCommandPrompt = False
				Case Else : WSTShowCommandPrompt = True
			End Select
			WSTCommandPrompt = New FileType(RegKey.GetValue("WSTCommandPromptPath", WSTCommandPromptDefault.Path).ToString, RegKey.GetValue("WSTCommandPromptArgs", WSTCommandPromptDefault.Arguments).ToString)
			Select Case RegKey.GetValue("WSTSSToolEnabled", "False").ToString
				Case "True", "1" : WSTSSToolEnabled = True
				Case Else : WSTSSToolEnabled = False
			End Select
			Dim rawValueWSTSSStartUpMode As String = RegKey.GetValue("WSTSSStartUp", "Enabled").ToString()
			Dim parsedWSTSSStartUpMode As WSTSSStartUpMode
			If [Enum].TryParse(rawValueWSTSSStartUpMode, True, parsedWSTSSStartUpMode) Then
				WSTSSStartUp = parsedWSTSSStartUpMode
			Else
				WSTSSStartUp = WSTSSStartUpMode.Enabled
			End If
			Select Case RegKey.GetValue("WSTSSEnableOnActivate", "True").ToString
				Case "False", "0" : WSTSSEnableOnActivate = False
				Case Else : WSTSSEnableOnActivate = True
			End Select
			Select Case RegKey.GetValue("WSTShowSSIcon", "True").ToString
				Case "False", "0" : WSTShowSSIcon = False
				Case Else : WSTShowSSIcon = True
			End Select
			Select Case RegKey.GetValue("WSTShowSSActivate", "True").ToString
				Case "False", "0" : WSTShowSSActivate = False
				Case Else : WSTShowSSActivate = True
			End Select
			Select Case RegKey.GetValue("WSTShowSSEnabled", "True").ToString
				Case "False", "0" : WSTShowSSEnabled = False
				Case Else : WSTShowSSEnabled = True
			End Select
			Select Case RegKey.GetValue("WSTShowClock", "False").ToString
				Case "True", "1" : WSTShowClock = True
				Case Else : WSTShowClock = False
			End Select
			WSTClockLocation.X = CInt(Val(RegKey.GetValue("WSTClockLocationX", "0")))
			WSTClockLocation.Y = CInt(Val(RegKey.GetValue("WSTClockLocationY", "0")))
			Dim rawValueWSTClockSize As String = RegKey.GetValue("WSTClockSize", "Medium").ToString()
			Dim parsedWSTClockSize As ClockSize
			If [Enum].TryParse(rawValueWSTClockSize, True, parsedWSTClockSize) Then
				WSTClockSize = parsedWSTClockSize
			Else
				WSTClockSize = ClockSize.Medium
			End If
			Select Case RegKey.GetValue("WSTShowLockWorkSpace", "True").ToString
				Case "False", "0" : WSTShowLockWorkSpace = False
				Case Else : WSTShowLockWorkSpace = True
			End Select
			Select Case RegKey.GetValue("WSTShowLogOff", "True").ToString
				Case "False", "0" : WSTShowLogOff = False
				Case Else : WSTShowLogOff = True
			End Select
			Select Case RegKey.GetValue("WSTShowSleep", "True").ToString
				Case "False", "0" : WSTShowSleep = False
				Case Else : WSTShowSleep = True
			End Select
			Select Case RegKey.GetValue("WSTShowHibernate", "True").ToString
				Case "False", "0" : WSTShowHibernate = False
				Case Else : WSTShowHibernate = True
			End Select
			Select Case RegKey.GetValue("WSTShowReStart", "True").ToString
				Case "False", "0" : WSTShowReStart = False
				Case Else : WSTShowReStart = True
			End Select
			Select Case RegKey.GetValue("WSTShowShutDown", "True").ToString
				Case "False", "0" : WSTShowShutDown = False
				Case Else : WSTShowShutDown = True
			End Select
			Select Case RegKey.GetValue("WSTShowHelp", "True").ToString
				Case "False", "0" : WSTShowHelp = False
				Case Else : WSTShowHelp = True
			End Select
			Select Case RegKey.GetValue("WSTShowLog", "True").ToString
				Case "False", "0" : WSTShowLog = False
				Case Else : WSTShowLog = True
			End Select
			Select Case RegKey.GetValue("WSTShowAC", "True").ToString
				Case "False", "0" : WSTShowAC = False
				Case Else : WSTShowAC = True
			End Select
			Select Case RegKey.GetValue("WSTShowWLMenu", "False").ToString
				Case "True", "1" : WSTShowWLMenu = True
				Case Else : WSTShowWLMenu = False
			End Select
			Select Case RegKey.GetValue("WSTShowWLTray", "False").ToString
				Case "True", "1" : WSTShowWLTray = True
				Case Else : WSTShowWLTray = False
			End Select
		End Sub
		Private Sub GetSettingsAC()
			Dim rawValue As String = RegKey.GetValue("ACAlarmTime", "00:00").ToString()
			Dim parsed As TimeSpan
			If TimeSpan.TryParse(rawValue, parsed) Then
				ACAlarmTime = parsed
			Else ' fallback if parsing fails
				ACAlarmTime = TimeSpan.Zero
			End If
			Select Case RegKey.GetValue("ACAlarmRecurring", "False").ToString
				Case "False", "0" : ACAlarmRecurring = False
				Case Else : ACAlarmRecurring = True
			End Select
			ACAlarmChimePath = RegKey.GetValue("ACAlarmChimePath", "").ToString
			Select Case RegKey.GetValue("ACAlarmChimeType", "Simple").ToString
				Case "Extended" : ACAlarmChimeType = ACChimeType.Extended
				Case "Forever" : ACAlarmChimeType = ACChimeType.Forever
				Case Else : ACAlarmChimeType = ACChimeType.Simple
			End Select
			Select Case RegKey.GetValue("ACTopHourChimeEnabled", "True").ToString
				Case "False", "0" : ACTopHourChimeEnabled = False
				Case Else : ACTopHourChimeEnabled = True
			End Select
			ACTopHourChimePath = RegKey.GetValue("ACTopHourChimePath", "").ToString
			Select Case RegKey.GetValue("ACTopHourChimeType", "Extended").ToString
				Case "Simple" : ACTopHourChimeType = ACChimeType.Simple
				Case "Extended" : ACTopHourChimeType = ACChimeType.Extended
				Case "HourTick" : ACTopHourChimeType = ACChimeType.HourTick
				Case Else : ACTopHourChimeType = ACChimeType.Extended
			End Select
			ACOffHourChimePath = RegKey.GetValue("ACOffHourChimePath", "").ToString
			Select Case RegKey.GetValue("ACTopHourBeforeChimeEnabled", "False").ToString
				Case "False", "0" : ACTopHourBeforeChimeEnabled = False
				Case Else : ACTopHourBeforeChimeEnabled = True
			End Select
			Select Case RegKey.GetValue("ACTopHourAfterChimeEnabled", "False").ToString
				Case "False", "0" : ACTopHourAfterChimeEnabled = False
				Case Else : ACTopHourAfterChimeEnabled = True
			End Select
			Select Case RegKey.GetValue("ACFirstQuarterHourChimeEnabled", "False").ToString
				Case "False", "0" : ACFirstQuarterHourChimeEnabled = False
				Case Else : ACFirstQuarterHourChimeEnabled = True
			End Select
			Select Case RegKey.GetValue("ACFirstQuarterHourBeforeChimeEnabled", "False").ToString
				Case "True", "1" : ACFirstQuarterHourBeforeChimeEnabled = True
				Case Else : ACFirstQuarterHourBeforeChimeEnabled = False
			End Select
			Select Case RegKey.GetValue("ACFirstQuarterHourAfterChimeEnabled", "False").ToString
				Case "True", "1" : ACFirstQuarterHourAfterChimeEnabled = True
				Case Else : ACFirstQuarterHourAfterChimeEnabled = False
			End Select
			Select Case RegKey.GetValue("ACBottomHourChimeEnabled", "True").ToString
				Case "False", "0" : ACBottomHourChimeEnabled = False
				Case Else : ACBottomHourChimeEnabled = True
			End Select
			Select Case RegKey.GetValue("ACBottomHourBeforeChimeEnabled", "False").ToString
				Case "True", "1" : ACBottomHourBeforeChimeEnabled = True
				Case Else : ACBottomHourBeforeChimeEnabled = False
			End Select
			Select Case RegKey.GetValue("ACBottomHourAfterChimeEnabled", "False").ToString
				Case "True", "1" : ACBottomHourAfterChimeEnabled = True
				Case Else : ACBottomHourAfterChimeEnabled = False
			End Select
			Select Case RegKey.GetValue("ACThirdQuarterHourChimeEnabled", "False").ToString
				Case "True", "1" : ACThirdQuarterHourChimeEnabled = True
				Case Else : ACThirdQuarterHourChimeEnabled = False
			End Select
			Select Case RegKey.GetValue("ACThirdQuarterHourBeforeChimeEnabled", "False").ToString
				Case "True", "1" : ACThirdQuarterHourBeforeChimeEnabled = True
				Case Else : ACThirdQuarterHourBeforeChimeEnabled = False
			End Select
			Select Case RegKey.GetValue("ACThirdQuarterHourAfterChimeEnabled", "False").ToString
				Case "True", "1" : ACThirdQuarterHourAfterChimeEnabled = True
				Case Else : ACThirdQuarterHourAfterChimeEnabled = False
			End Select
		End Sub
		Private Sub GetSettingsWL()
			UpgradeLegacyWLSettings()

			WLShowFilePathToolTips = RegistryHelper.GetBool("WLShowFilePathToolTips", False)
			WLShowFileInfoToolTips = RegistryHelper.GetBool("WLShowFileInfoToolTips", False)
			WLShowFolderPathToolTips = RegistryHelper.GetBool("WLShowFolderPathToolTips", False)
			WLMaxLinksPerFolder = CByte(Math.Clamp(RegistryHelper.GetInt("WLMaxLinksPerFolder", 30), 1, 100))
			WLStartUpDelay = CShort(Math.Clamp(RegistryHelper.GetInt("WLStartUpDelay", 10), 0, 300))
			WLAutoRefresh = RegistryHelper.GetBool("WLAutoRefresh", False)
			WLAutoRefreshInterval = CByte(Math.Clamp(RegistryHelper.GetInt("WLAutoRefreshInterval", 5), 1, 90))
			WLAutoRefreshIdleInterval = CByte(Math.Clamp(RegistryHelper.GetInt("WLAutoRefreshIdleInterval", 30), 20, 240))
			Dim json = RegistryHelper.GetString("WLDataJson", "[]")
			Try
				WLData = JsonSerializer.Deserialize(Of List(Of WLItemType))(json)
			Catch
				WLData = New List(Of WLItemType)()
			End Try

			' Set runtime flags
			For i As Integer = 0 To WLData.Count - 1
				Dim item = WLData(i)
				item.RefreshData = True
				item.RefreshMenu = True
				WLData(i) = item
			Next

		End Sub
		'Private Sub GetSettingsWL()
		'	Select Case RegKey.GetValue("WLShowFilePathToolTips", "False").ToString
		'		Case "True", "1" : WLShowFilePathToolTips = True
		'		Case Else : WLShowFilePathToolTips = False
		'	End Select
		'	Select Case RegKey.GetValue("WLShowFileInfoToolTips", "False").ToString
		'		Case "True", "1" : WLShowFileInfoToolTips = True
		'		Case Else : WLShowFileInfoToolTips = False
		'	End Select
		'	Select Case RegKey.GetValue("WLShowFolderPathToolTips", "False").ToString
		'		Case "True", "1" : WLShowFolderPathToolTips = True
		'		Case Else : WLShowFolderPathToolTips = False
		'	End Select
		'	Try
		'		WLMaxLinksPerFolder = CByte(Val(RegKey.GetValue("WLMaxLinksPerFolder", "30")))
		'		If WLMaxLinksPerFolder < 1 Or WLMaxLinksPerFolder > 100 Then WLMaxLinksPerFolder = 30
		'	Catch : WLMaxLinksPerFolder = 30
		'	End Try
		'	Try
		'		WLStartUpDelay = CShort(Val(RegKey.GetValue("WLStartUpDelay", "10")))
		'		If (WLStartUpDelay < 5 Or WLStartUpDelay > 300) And WLStartUpDelay <> 0 Then WLStartUpDelay = 10
		'	Catch
		'		WLStartUpDelay = 10
		'	End Try
		'	Select Case RegKey.GetValue("WLAutoRefresh", "False").ToString
		'		Case "True", "1" : WLAutoRefresh = True
		'		Case Else : WLAutoRefresh = False
		'	End Select
		'	Try
		'		WLAutoRefreshInterval = CByte(Val(RegKey.GetValue("WLAutoRefreshInterval", "5")))
		'		If WLAutoRefreshInterval < 1 Or WLAutoRefreshInterval > 90 Then WLAutoRefreshInterval = 5
		'	Catch : WLAutoRefreshInterval = 5
		'	End Try
		'	Try
		'		WLAutoRefreshIdleInterval = CByte(Val(RegKey.GetValue("WLAutoRefreshIdleInterval", "30")))
		'		If WLAutoRefreshIdleInterval < 20 Or WLAutoRefreshIdleInterval > 240 Then WLAutoRefreshIdleInterval = 30
		'	Catch : WLAutoRefreshIdleInterval = 30
		'	End Try
		'	WLData.Clear()
		'	RegSubKey = RegKey.CreateSubKey("WL")
		'	Dim WLSortOrderType As Type = GetType(SortOrder)
		'	Dim WLFolderModeType As Type = GetType(WLFolderMode)
		'	Dim WLFolderPlacementType As Type = GetType(WLFolderPlacement)
		'	For index As Integer = 1 To RegSubKey.SubKeyCount
		'		RegItemKey = RegSubKey.OpenSubKey("Link" + (index).ToString.Trim, True)
		'		Dim link As New WLItemType With {
		'			.Root = RegItemKey.GetValue("", "").ToString}
		'		If Not String.IsNullOrEmpty(link.Root) Then
		'			link.Name = RegItemKey.GetValue("Name", "").ToString
		'			Try : link.Sort = DirectCast(SortOrder.Parse(WLSortOrderType, RegItemKey.GetValue("Sort", "Ascending").ToString), SortOrder)
		'			Catch : link.Sort = SortOrder.Ascending
		'			End Try
		'			Try : link.FolderMode = DirectCast(WLFolderMode.Parse(WLFolderModeType, RegItemKey.GetValue("FolderMode", "NoFolders").ToString), WLFolderMode)
		'			Catch : link.FolderMode = WLFolderMode.NoFolders
		'			End Try
		'			Try : link.FolderPlacement = DirectCast(WLFolderPlacement.Parse(WLFolderPlacementType, RegItemKey.GetValue("FolderPlacement", "Top").ToString), WLFolderPlacement)
		'			Catch : link.FolderPlacement = WLFolderPlacement.Top
		'			End Try
		'			Select Case RegItemKey.GetValue("UseDefaultIcon", "False").ToString
		'				Case "True", "1" : link.UseDefaultIcon = True
		'				Case Else : link.UseDefaultIcon = False
		'			End Select
		'			Select Case RegItemKey.GetValue("ShowInMenu", "True").ToString
		'				Case "False", "0" : link.ShowInMenu = False
		'				Case Else : link.ShowInMenu = True
		'			End Select
		'			Select Case RegItemKey.GetValue("ShowInTray", "True").ToString
		'				Case "False", "0" : link.ShowInTray = False
		'				Case Else : link.ShowInTray = True
		'			End Select
		'			Select Case RegItemKey.GetValue("ShowNoMenu", "False").ToString
		'				Case "True", "1" : link.ShowNoMenu = True
		'				Case Else : link.ShowNoMenu = False
		'			End Select
		'			Select Case RegItemKey.GetValue("ShowMenuIcons", "True").ToString
		'				Case "False", "0" : link.ShowMenuIcons = False
		'				Case Else : link.ShowMenuIcons = True
		'			End Select
		'			link.RefreshData = True
		'			link.RefreshMenu = True
		'			WLData.Add(link)
		'		End If
		'		RegItemKey.Close()
		'	Next
		'	RegSubKey.Close()
		'End Sub
		Private Sub SaveSettingsHC()
			RegKey.SetValue("HCWSTLeft", HCWSTLeft.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCWSTDouble", HCWSTDouble.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCWSTMiddle", HCWSTMiddle.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCWSTRight", HCWSTRight.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCWLLeft", HCWLLeft.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCWLDouble", HCWLDouble.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCWLMiddle", HCWLMiddle.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCCBLeft", HCCBLeft.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCCBDouble", HCCBDouble.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCCBMiddle", HCCBMiddle.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCCBRight", HCCBRight.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCWSTScreenSaverLeft", HCWSTScreenSaverLeft.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCWSTScreenSaverDouble", HCWSTScreenSaverDouble.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCWSTScreenSaverMiddle", HCWSTScreenSaverMiddle.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HCWSTScreenSaverRight", HCWSTScreenSaverRight.ToString, Microsoft.Win32.RegistryValueKind.String)
		End Sub
		Private Sub SaveSettingsHK()
			RegKey.SetValue("HKEnabled", HKEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTLockWorkSpaceKey", Val(HKWSTLockWorkSpace.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTLockWorkSpaceKeyCode", HKWSTLockWorkSpace.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTLockWorkSpaceKeyMod", HKWSTLockWorkSpace.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTScreenSaverKey", Val(HKWSTScreenSaver.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTScreenSaverKeyCode", HKWSTScreenSaver.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTScreenSaverKeyMod", HKWSTScreenSaver.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTClockKey", Val(HKWSTClock.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTClockKeyCode", HKWSTClock.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTClockKeyMod", HKWSTClock.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTTaskManagerKey", Val(HKWSTTaskManager.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTTaskManagerKeyCode", HKWSTTaskManager.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTTaskManagerKeyMod", HKWSTTaskManager.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTCommandPromptKey", Val(HKWSTCommandPrompt.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTCommandPromptKeyCode", HKWSTCommandPrompt.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWSTCommandPromptKeyMod", HKWSTCommandPrompt.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWLKey", Val(HKWL.Key).ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWLKeyCode", HKWL.KeyCode.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("HKWLKeyMod", HKWL.KeyMod.ToString, Microsoft.Win32.RegistryValueKind.String)
		End Sub
		Friend Sub SaveSettingsWST()
			RegKey.SetValue("WSTLoadOnOSStartup", WSTLoadOnOSStartup.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTLoadOnOSStartupPath", WSTLoadOnOSStartupPath.Path, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTLoadOnOSStartupArgs", WSTLoadOnOSStartupPath.Arguments, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTEnabled", WSTEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowTaskManager", WSTShowTaskManager.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTTaskManagerPath", WSTTaskManager.Path, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTTaskManagerArgs", WSTTaskManager.Arguments, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowCommandPrompt", WSTShowCommandPrompt.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTCommandPromptPath", WSTCommandPrompt.Path, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTCommandPromptArgs", WSTCommandPrompt.Arguments, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTSSToolEnabled", WSTSSToolEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTSSStartUp", WSTSSStartUp.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTSSEnableOnActivate", WSTSSEnableOnActivate.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowSSIcon", WSTShowSSIcon.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowSSActivate", WSTShowSSActivate.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowSSEnabled", WSTShowSSEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowClock", WSTShowClock.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTClockLocationX", WSTClockLocation.X.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTClockLocationY", WSTClockLocation.Y.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTClockSize", WSTClockSize.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowLockWorkSpace", WSTShowLockWorkSpace.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowLogOff", WSTShowLogOff.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowSleep", WSTShowSleep.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowHibernate", WSTShowHibernate.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowReStart", WSTShowReStart.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowShutDown", WSTShowShutDown.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowHelp", WSTShowHelp.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowLog", WSTShowLog.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowAC", WSTShowAC.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowWLMenu", WSTShowWLMenu.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("WSTShowWLTray", WSTShowWLTray.ToString, Microsoft.Win32.RegistryValueKind.String)
		End Sub
		Private Sub SaveSettingsAC()
			RegKey.SetValue("ACAlarmTime", ACAlarmTime.ToString().Substring(0, My.App.ACAlarmTime.ToString().Length - 3), Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACAlarmRecurring", ACAlarmRecurring.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACAlarmChimePath", ACAlarmChimePath, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACAlarmChimeType", ACAlarmChimeType.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACTopHourChimeEnabled", ACTopHourChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACTopHourChimePath", ACTopHourChimePath, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACTopHourChimeType", ACTopHourChimeType.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACOffHourChimePath", ACOffHourChimePath, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACTopHourBeforeChimeEnabled", ACTopHourBeforeChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACTopHourAfterChimeEnabled", ACTopHourAfterChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACFirstQuarterHourChimeEnabled", ACFirstQuarterHourChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACFirstQuarterHourBeforeChimeEnabled", ACFirstQuarterHourBeforeChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACFirstQuarterHourAfterChimeEnabled", ACFirstQuarterHourAfterChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACBottomHourChimeEnabled", ACBottomHourChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACBottomHourBeforeChimeEnabled", ACBottomHourBeforeChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACBottomHourAfterChimeEnabled", ACBottomHourAfterChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACThirdQuarterHourChimeEnabled", ACThirdQuarterHourChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACThirdQuarterHourBeforeChimeEnabled", ACThirdQuarterHourBeforeChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
			RegKey.SetValue("ACThirdQuarterHourAfterChimeEnabled", ACThirdQuarterHourAfterChimeEnabled.ToString, Microsoft.Win32.RegistryValueKind.String)
		End Sub
		Private Sub SaveSettingsWL()
			RegistryHelper.SetBool("WLShowFilePathToolTips", WLShowFilePathToolTips)
			RegistryHelper.SetBool("WLShowFileInfoToolTips", WLShowFileInfoToolTips)
			RegistryHelper.SetBool("WLShowFolderPathToolTips", WLShowFolderPathToolTips)
			RegistryHelper.SetInt("WLMaxLinksPerFolder", WLMaxLinksPerFolder)
			RegistryHelper.SetInt("WLStartUpDelay", WLStartUpDelay)
			RegistryHelper.SetBool("WLAutoRefresh", WLAutoRefresh)
			RegistryHelper.SetInt("WLAutoRefreshInterval", WLAutoRefreshInterval)
			RegistryHelper.SetInt("WLAutoRefreshIdleInterval", WLAutoRefreshIdleInterval)
			Dim json = JsonSerializer.Serialize(WLData)
			RegistryHelper.SetString("WLData", json)
		End Sub
		'Private Sub SaveSettingsWL()
		'	RegKey.SetValue("WLShowFilePathToolTips", WLShowFilePathToolTips.ToString, Microsoft.Win32.RegistryValueKind.String)
		'	RegKey.SetValue("WLShowFileInfoToolTips", WLShowFileInfoToolTips.ToString, Microsoft.Win32.RegistryValueKind.String)
		'	RegKey.SetValue("WLShowFolderPathToolTips", WLShowFolderPathToolTips.ToString, Microsoft.Win32.RegistryValueKind.String)
		'	RegKey.SetValue("WLMaxLinksPerFolder", WLMaxLinksPerFolder.ToString, Microsoft.Win32.RegistryValueKind.String)
		'	RegKey.SetValue("WLStartUpDelay", WLStartUpDelay.ToString, Microsoft.Win32.RegistryValueKind.String)
		'	RegKey.SetValue("WLAutoRefresh", WLAutoRefresh.ToString, Microsoft.Win32.RegistryValueKind.String)
		'	RegKey.SetValue("WLAutoRefreshInterval", WLAutoRefreshInterval.ToString, Microsoft.Win32.RegistryValueKind.String)
		'	RegKey.SetValue("WLAutoRefreshIdleInterval", WLAutoRefreshIdleInterval.ToString, Microsoft.Win32.RegistryValueKind.String)
		'	RegSubKey = RegKey.OpenSubKey("WL", True)
		'	For Each s As String In RegSubKey.GetSubKeyNames : RegSubKey.DeleteSubKeyTree(s) : Next
		'	If WLData.Count > 0 Then
		'		For index As Integer = 0 To WLData.Count - 1
		'			RegItemKey = RegSubKey.CreateSubKey("Link" + (index + 1).ToString.Trim)
		'			RegItemKey.SetValue("", WLData(index).Root, Microsoft.Win32.RegistryValueKind.String)
		'			RegItemKey.SetValue("Name", WLData(index).Name, Microsoft.Win32.RegistryValueKind.String)
		'			RegItemKey.SetValue("Sort", WLData(index).Sort.ToString, Microsoft.Win32.RegistryValueKind.String)
		'			RegItemKey.SetValue("FolderMode", WLData(index).FolderMode.ToString, Microsoft.Win32.RegistryValueKind.String)
		'			RegItemKey.SetValue("FolderPlacement", WLData(index).FolderPlacement.ToString, Microsoft.Win32.RegistryValueKind.String)
		'			RegItemKey.SetValue("UseDefaultIcon", WLData(index).UseDefaultIcon.ToString, Microsoft.Win32.RegistryValueKind.String)
		'			RegItemKey.SetValue("ShowInMenu", WLData(index).ShowInMenu.ToString, Microsoft.Win32.RegistryValueKind.String)
		'			RegItemKey.SetValue("ShowInTray", WLData(index).ShowInTray.ToString, Microsoft.Win32.RegistryValueKind.String)
		'			RegItemKey.SetValue("ShowNoMenu", WLData(index).ShowNoMenu.ToString, Microsoft.Win32.RegistryValueKind.String)
		'			RegItemKey.SetValue("ShowMenuIcons", WLData(index).ShowMenuIcons.ToString, Microsoft.Win32.RegistryValueKind.String)
		'			RegItemKey.Close()
		'		Next
		'	End If
		'	RegSubKey.Close()
		'End Sub
		<Diagnostics.ConditionalAttribute("DEBUG")> Private Sub GetSettingsDebug()
			HKEnabled = False
			GetSettingsDebugHK()
			'WorkSpace Tools (WST)
			'WSTLoadOnOSStartup = True
			'WSTLoadOnOSStartupPath = New FileType("C:\Tools\YMTag.exe", "test args")
			WSTEnabled = True
			WSTShowTaskManager = False
			WSTShowCommandPrompt = False
			WSTShowClock = True
			'WSTClockSize = ClockSize.Medium
			WSTShowLockWorkSpace = False
			WSTShowLogOff = False
			WSTShowSleep = False
			WSTShowHibernate = False
			WSTShowReStart = False
			WSTShowShutDown = False
			WSTShowHelp = True
			WSTShowLog = True
			'ScreenSaver (SS)
			WSTSSToolEnabled = True
			WSTSSStartUp = WSTSSStartUpMode.Enabled
			WSTSSEnableOnActivate = False
			WSTShowSSIcon = True
			WSTShowSSActivate = True
			WSTShowSSEnabled = True
			'Alarm & Chime (AC)
			WSTShowAC = False
			ACAlarmRecurring = False
			'WinLinks (WL)
			WSTShowWLMenu = True
			WSTShowWLTray = True
			WLStartUpDelay = 0 '0 = Disable Delay, Load Immediately
			'GetSettingsDebugWL()
		End Sub
		<Diagnostics.ConditionalAttribute("DEBUG")> Private Sub GetSettingsDebugHK()
			If HKEnabled Then
				'HotKeyRefreshWorkSpace.HotKey = Keys.R
				'HotKeyRefreshWorkSpace.HotKeyCode = 82
				'HotKeyRefreshWorkSpace.HotKeyMod = 0
				'HotKeyWinLinks.HotKey = Keys.W
				'HotKeyWinLinks.HotKeyCode = 87
				'HotKeyWinLinks.HotKeyMod = 0
			End If
		End Sub
		<Diagnostics.ConditionalAttribute("DEBUG")> Private Sub GetSettingsDebugWL()

			WLData.Clear()
			WLAutoRefresh = True
			WLAutoRefreshInterval = 1
			WLAutoRefreshIdleInterval = 20

			Dim link As WLItemType

			link = New WLItemType("C:\Users\YodeS\Review") With {
				.Name = "bla & bla",
				.ShowMenuIcons = True,
				.RefreshData = True,
				.RefreshMenu = True}
			WLData.Add(link)

			link = New WLItemType("C:\Users\YodeS\Dev") With {
				.FolderMode = WLFolderMode.FoldersOnly,
				.FolderPlacement = WLFolderPlacement.Merged,
				.ShowMenuIcons = True,
				.RefreshData = True,
				.RefreshMenu = True}
			WLData.Add(link)

			link = New WLItemType("C:\Users\YodeS\Dev\TESTDATA") With {
				.RefreshData = True,
				.RefreshMenu = True}
			WLData.Add(link)

		End Sub

	End Module

End Namespace
