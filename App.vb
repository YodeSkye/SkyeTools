
Imports System.Text.Json
Imports System.Text.Json.Serialization
Imports Skye.Common
Imports Skye.UI

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
			HKKeys.Add(HKWL)
		End Sub

		'Saved Settings
		Friend HKWSTLockWorkSpace As New HKType
		Friend HKWSTScreenSaver As New HKType
		Friend HKWSTClock As New HKType
		Friend HKWL As New HKType
		Friend HKKeys As New Collections.Generic.List(Of HKType)
		Friend HKEnabled As Boolean

#End Region

#Region "WorkSpace Tools (WST)"

		' Saved Settings
		Friend WSTLoadOnOSStartup As Boolean
		Friend WSTLoadOnOSStartupPath As FileType
		Friend WSTEnabled As Boolean
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
		Friend Theme As Skye.UI.SkyeTheme
		Friend ThemeAuto As Boolean

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

        ' DECLARATIONS
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
		Friend FrmHelp As Help
		Friend FrmLog As Log
		Friend FrmBalloon As Balloon
		Private BalloonHideEnabled As Boolean
		Private WithEvents TimerBalloon As New Timer

		' HANDLERS
		Private Sub OnThemeChanged(sender As Object, e As EventArgs)
			For Each f As Form In Application.OpenForms
				ThemeManager.ApplyTheme(f)
			Next
		End Sub

		' METHODS
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
			Dim selectedTheme As Skye.UI.SkyeTheme = If(ThemeAuto, Skye.UI.ThemeManager.DetectWindowsTheme(), Theme)
			Skye.UI.ThemeManager.CurrentTheme = selectedTheme
			AddHandler Skye.UI.ThemeManager.ThemeChanged, AddressOf OnThemeChanged
		End Sub
		Friend Sub Finalize()
			WriteToLog(My.App.Tools.SkyeTools, "..." + My.Application.Info.ProductName + " Closed")
		End Sub
		Friend Sub SetLoadOnOSStartup()
			Dim RegKey As Microsoft.Win32.RegistryKey = Nothing
			Try
				RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run\", True)
				If WSTLoadOnOSStartup And Not String.IsNullOrEmpty(WSTLoadOnOSStartupPath.Path) Then
					RegKey.SetValue("SkyeTools", IIf(String.IsNullOrEmpty(WSTLoadOnOSStartupPath.Arguments), WSTLoadOnOSStartupPath.Path, WSTLoadOnOSStartupPath.Path + " " + WSTLoadOnOSStartupPath.Arguments).ToString, Microsoft.Win32.RegistryValueKind.String)
				Else
					RegKey.DeleteValue("SkyeTools", False)
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
		Friend Sub ShowMessage(tool As Tools, title As String, message As String, Optional icon As Icon = Nothing)
			Dim t As New Skye.UI.ToastOptions With {
				   .Title = title,
				   .Message = message,
				   .Icon = icon,
				   .Duration = 6000,
				   .MessageFont = MenuFont,
				   .BackColor = Skye.UI.ThemeManager.CurrentTheme.TooltipBack,
				   .ForeColor = Skye.UI.ThemeManager.CurrentTheme.TooltipFore,
				   .BorderColor = Skye.UI.ThemeManager.CurrentTheme.TooltipBorder
			   }
			Skye.UI.Toast.ShowToast(t)
			WriteToLog(tool, title & " --> " & message)
		End Sub
		Friend Sub ShowHelp(Optional showmaximized As Boolean = False)
			Dim logtext As String = "HotKeys -- If the title Of a HotKey On the Settings Page Is grayed out, but HotKeys are enabled, this means that the feature Is Not active And the HotKey will Not Function even though it can be Set. Activate the feature And the HotKey will Function normally."
			logtext += Chr(13) + Chr(13) + "HotKeys -- The InfoTip Of the HotKey Header will display which HotLinks are assigned To that HotKey."
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
			logtext += Chr(13) + Chr(13) + "SkyeTools -- Holding the ShiftKey down while the app is starting will put the app into 'Alternate Start Mode'. This means that HotLinks & WinLinks will not AutoLoad on StartUp. You may, however, manually Refresh WinLinks from the WinLinks Settings page."
			logtext += Chr(13) + "When starting the App in 'Alternate Start Mode', the text on the Splash Screen will be red."
			logtext += Chr(13) + Chr(13) + "SkyeTools -- The option to 'ReStart In Current Context' means that the App will ReStart with the same CommandLine parameters as when it was started."
			logtext += Chr(13) + Chr(13) + "CommandLine -- Parameters may be used in any order or combination unless otherwise noted."
			logtext += Chr(13) + "/ALTSTART -- Puts the App into 'Alternate Start Mode'"
			logtext += Chr(13) + "/DELAYEDSTART:xx -- Delays the start of the app for xx seconds. The minimum and default is 2 seconds. The maximum is 300 seconds(5 minutes). The Splash Screen will be displayed during this time."
			If FrmHelp Is Nothing Then
				FrmHelp = New Help With {
					.Text = My.Application.Info.Title + " Help & About",
					.Icon = My.Resources.Resources.iconInfo
				}
				FrmHelp.RTxtBoxMessage.Clear()
				FrmHelp.RTxtBoxMessage.AppendText(logtext)
				FrmHelp.RTxtBoxMessage.Select(0, 0)
				FrmHelp.TxtBoxPostMessage.Text = "v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
				FrmHelp.Show()
			Else
				FrmHelp.BringToFront()
				FrmHelp.Focus()
			End If
			If showmaximized Then FrmHelp.WindowState = FormWindowState.Maximized
			FrmHelp.BtnOK.Select()
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
		<Diagnostics.ConditionalAttribute("DEBUG")> Private Sub GetSettingsDebug()
			HKEnabled = False
			GetSettingsDebugHK()
			'WorkSpace Tools (WST)
			'WSTLoadOnOSStartup = True
			'WSTLoadOnOSStartupPath = New FileType("C:\Tools\YMTag.exe", "test args")
			WSTEnabled = True
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

		' Settings
		Friend Sub GetSettings()
			Dim starttime As TimeSpan = DateTime.Now.TimeOfDay

			GetSettingsHC()
			GetSettingsHK()
			GetSettingsWST()
			GetSettingsAC()
			GetSettingsWL()

			HCGenerateActionList()
			HKGenerateKeyList()
			Skye.Common.Log.Write("Settings Loaded (" & Skye.Common.GenerateLogTime(starttime, DateTime.Now.TimeOfDay, True) & ")")
		End Sub
		Private Sub GetSettingsHC()

			' WST Actions
			HCWSTLeft = RegistryHelper.GetEnum("HCWSTLeft", HCAction.NoAction)
			HCWSTDouble = RegistryHelper.GetEnum("HCWSTDouble", HCAction.NoAction)
			HCWSTMiddle = RegistryHelper.GetEnum("HCWSTMiddle", HCAction.NoAction)
			HCWSTRight = RegistryHelper.GetEnum("HCWSTRight", HCAction.Menu)

			' WinLink Actions
			HCWLLeft = RegistryHelper.GetEnum("HCWLLeft", HCAction.NoAction)
			HCWLDouble = RegistryHelper.GetEnum("HCWLDouble", HCAction.NoAction)
			HCWLMiddle = RegistryHelper.GetEnum("HCWLMiddle", HCAction.NoAction)
			HCWLRight = HCAction.Menu ' Hardcoded default/constant

			' ScreenSaver Actions
			HCWSTScreenSaverLeft = RegistryHelper.GetEnum("HCWSTScreenSaverLeft", HCAction.NoAction)
			HCWSTScreenSaverDouble = RegistryHelper.GetEnum("HCWSTScreenSaverDouble", HCAction.NoAction)
			HCWSTScreenSaverMiddle = RegistryHelper.GetEnum("HCWSTScreenSaverMiddle", HCAction.NoAction)
			HCWSTScreenSaverRight = RegistryHelper.GetEnum("HCWSTScreenSaverRight", HCAction.Menu)

		End Sub
		Private Sub GetSettingsHK()

			HKEnabled = RegistryHelper.GetBool("HKEnabled", True)

			' Load hotkeys with descriptions, IDs, and defaults
			GetHK(HKWSTLockWorkSpace, "HKWSTLockWorkSpace", "Lock WorkSpace", 1, CType(262163, Keys), 19, 2)
			GetHK(HKWSTScreenSaver, "HKWSTScreenSaver", "Activate Screen Saver", 2, Keys.Pause, 19, 0)
			GetHK(HKWSTClock, "HKWSTClock", "Clock", 4, Keys.F8, 119, 0)
			GetHK(HKWL, "HKWL", "Open WinLink Root Folder", 15, Keys.None, 0, 0)

		End Sub
		Private Sub GetHK(ByRef hotkey As HKType, keyPrefix As String, desc As String, winId As Integer, defaultKey As Keys, defaultCode As Byte, defaultMod As Byte)

			hotkey.Description = desc
			hotkey.WinID = winId

			' Read values safely using RegistryHelper
			Dim rawKey As Integer = RegistryHelper.GetInt($"{keyPrefix}Key", CInt(defaultKey))
			hotkey.Key = If(rawKey >= 0, CType(rawKey, Keys), defaultKey)
			Dim rawCode As Integer = RegistryHelper.GetInt($"{keyPrefix}KeyCode", CInt(defaultCode))
			hotkey.KeyCode = CByte(Math.Clamp(rawCode, Byte.MinValue, Byte.MaxValue))
			Dim rawMod As Integer = RegistryHelper.GetInt($"{keyPrefix}KeyMod", CInt(defaultMod))
			hotkey.KeyMod = CByte(Math.Clamp(rawMod, Byte.MinValue, Byte.MaxValue))

		End Sub
		Private Sub GetSettingsWST()

			' Startup & Feature Flags
			WSTLoadOnOSStartup = RegistryHelper.GetBool("WSTLoadOnOSStartup", False)
			WSTLoadOnOSStartupPath = New FileType(
				RegistryHelper.GetString("WSTLoadOnOSStartupPath", WSTLoadOnOSStartupPathDefault.Path),
				RegistryHelper.GetString("WSTLoadOnOSStartupArgs", WSTLoadOnOSStartupPathDefault.Arguments)
			)
			WSTEnabled = RegistryHelper.GetBool("WSTEnabled", True)

			' Screensaver Tool Options
			WSTSSToolEnabled = RegistryHelper.GetBool("WSTSSToolEnabled", False)
			WSTSSEnableOnActivate = RegistryHelper.GetBool("WSTSSEnableOnActivate", True)
			WSTShowSSIcon = RegistryHelper.GetBool("WSTShowSSIcon", True)
			WSTShowSSActivate = RegistryHelper.GetBool("WSTShowSSActivate", True)
			WSTShowSSEnabled = RegistryHelper.GetBool("WSTShowSSEnabled", True)
			If Not [Enum].TryParse(RegistryHelper.GetString("WSTSSStartUp", "Enabled"), True, WSTSSStartUp) Then
				WSTSSStartUp = WSTSSStartUpMode.Enabled
			End If

			' Clock Options
			WSTShowClock = RegistryHelper.GetBool("WSTShowClock", False)
			WSTClockLocation.X = RegistryHelper.GetInt("WSTClockLocationX", 0)
			WSTClockLocation.Y = RegistryHelper.GetInt("WSTClockLocationY", 0)
			If Not [Enum].TryParse(RegistryHelper.GetString("WSTClockSize", "Medium"), True, WSTClockSize) Then
				WSTClockSize = ClockSize.Medium
			End If

			' Menu / UI Toggles
			WSTShowLockWorkSpace = RegistryHelper.GetBool("WSTShowLockWorkSpace", True)
			WSTShowLogOff = RegistryHelper.GetBool("WSTShowLogOff", True)
			WSTShowSleep = RegistryHelper.GetBool("WSTShowSleep", True)
			WSTShowHibernate = RegistryHelper.GetBool("WSTShowHibernate", True)
			WSTShowReStart = RegistryHelper.GetBool("WSTShowReStart", True)
			WSTShowShutDown = RegistryHelper.GetBool("WSTShowShutDown", True)
			WSTShowHelp = RegistryHelper.GetBool("WSTShowHelp", True)
			WSTShowLog = RegistryHelper.GetBool("WSTShowLog", True)
			WSTShowAC = RegistryHelper.GetBool("WSTShowAC", True)
			WSTShowWLMenu = RegistryHelper.GetBool("WSTShowWLMenu", False)
			WSTShowWLTray = RegistryHelper.GetBool("WSTShowWLTray", False)

			' Theme
			Dim themeName As String = Skye.Common.RegistryHelper.GetString("Theme", "Light")
			Theme = Skye.UI.SkyeThemes.GetTheme(themeName)
			ThemeAuto = Skye.Common.RegistryHelper.GetBool("ThemeAuto", True)

		End Sub
		Private Sub GetSettingsAC()

			' TimeSpan parsing with safe fallback
			Dim rawTime = RegistryHelper.GetString("ACAlarmTime", "00:00")
			If Not TimeSpan.TryParse(rawTime, ACAlarmTime) Then
				ACAlarmTime = TimeSpan.Zero
			End If

			' Booleans
			ACAlarmRecurring = RegistryHelper.GetBool("ACAlarmRecurring", False)
			ACTopHourChimeEnabled = RegistryHelper.GetBool("ACTopHourChimeEnabled", True)
			ACTopHourBeforeChimeEnabled = RegistryHelper.GetBool("ACTopHourBeforeChimeEnabled", False)
			ACTopHourAfterChimeEnabled = RegistryHelper.GetBool("ACTopHourAfterChimeEnabled", False)
			ACFirstQuarterHourChimeEnabled = RegistryHelper.GetBool("ACFirstQuarterHourChimeEnabled", False)
			ACFirstQuarterHourBeforeChimeEnabled = RegistryHelper.GetBool("ACFirstQuarterHourBeforeChimeEnabled", False)
			ACFirstQuarterHourAfterChimeEnabled = RegistryHelper.GetBool("ACFirstQuarterHourAfterChimeEnabled", False)
			ACBottomHourChimeEnabled = RegistryHelper.GetBool("ACBottomHourChimeEnabled", True)
			ACBottomHourBeforeChimeEnabled = RegistryHelper.GetBool("ACBottomHourBeforeChimeEnabled", False)
			ACBottomHourAfterChimeEnabled = RegistryHelper.GetBool("ACBottomHourAfterChimeEnabled", False)
			ACThirdQuarterHourChimeEnabled = RegistryHelper.GetBool("ACThirdQuarterHourChimeEnabled", False)
			ACThirdQuarterHourBeforeChimeEnabled = RegistryHelper.GetBool("ACThirdQuarterHourBeforeChimeEnabled", False)
			ACThirdQuarterHourAfterChimeEnabled = RegistryHelper.GetBool("ACThirdQuarterHourAfterChimeEnabled", False)

			' Strings
			ACAlarmChimePath = RegistryHelper.GetString("ACAlarmChimePath", "")
			ACTopHourChimePath = RegistryHelper.GetString("ACTopHourChimePath", "")
			ACOffHourChimePath = RegistryHelper.GetString("ACOffHourChimePath", "")

			' Enums
			If Not [Enum].TryParse(RegistryHelper.GetString("ACAlarmChimeType", "Simple"), ACAlarmChimeType) Then
				ACAlarmChimeType = ACChimeType.Simple
			End If
			If Not [Enum].TryParse(RegistryHelper.GetString("ACTopHourChimeType", "Extended"), ACTopHourChimeType) Then
				ACTopHourChimeType = ACChimeType.Extended
			End If

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
			Dim json = RegistryHelper.GetString("WLData", "[]")
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

		Friend Sub SaveSettings()
			Dim starttime As TimeSpan = DateTime.Now.TimeOfDay

			SaveSettingsHC()
			SaveSettingsHK()
			SaveSettingsWST()
			SaveSettingsAC()
			SaveSettingsWL()

			Skye.Common.Log.Write("Settings Saved (" & Skye.Common.GenerateLogTime(starttime, DateTime.Now.TimeOfDay, True) & ")")
		End Sub
		Friend Sub SaveSettingsHC()

			' WST Actions
			RegistryHelper.SetString("HCWSTLeft", HCWSTLeft.ToString())
			RegistryHelper.SetString("HCWSTDouble", HCWSTDouble.ToString())
			RegistryHelper.SetString("HCWSTMiddle", HCWSTMiddle.ToString())
			RegistryHelper.SetString("HCWSTRight", HCWSTRight.ToString())

			' WinLink Actions
			RegistryHelper.SetString("HCWLLeft", HCWLLeft.ToString())
			RegistryHelper.SetString("HCWLDouble", HCWLDouble.ToString())
			RegistryHelper.SetString("HCWLMiddle", HCWLMiddle.ToString())

			' ScreenSaver Actions
			RegistryHelper.SetString("HCWSTScreenSaverLeft", HCWSTScreenSaverLeft.ToString())
			RegistryHelper.SetString("HCWSTScreenSaverDouble", HCWSTScreenSaverDouble.ToString())
			RegistryHelper.SetString("HCWSTScreenSaverMiddle", HCWSTScreenSaverMiddle.ToString())
			RegistryHelper.SetString("HCWSTScreenSaverRight", HCWSTScreenSaverRight.ToString())

		End Sub
		Friend Sub SaveSettingsHK()

			RegistryHelper.SetBool("HKEnabled", HKEnabled)

			SaveHK(HKWSTLockWorkSpace, "HKWSTLockWorkSpace")
			SaveHK(HKWSTScreenSaver, "HKWSTScreenSaver")
			SaveHK(HKWSTClock, "HKWSTClock")
			SaveHK(HKWL, "HKWL")

		End Sub
		Private Sub SaveHK(ByVal hotkey As HKType, keyPrefix As String)
			RegistryHelper.SetInt($"{keyPrefix}Key", CInt(hotkey.Key))
			RegistryHelper.SetInt($"{keyPrefix}KeyCode", CInt(hotkey.KeyCode))
			RegistryHelper.SetInt($"{keyPrefix}KeyMod", CInt(hotkey.KeyMod))
		End Sub
		Friend Sub SaveSettingsWST()

			' Startup & Feature Flags
			RegistryHelper.SetBool("WSTLoadOnOSStartup", WSTLoadOnOSStartup)
			RegistryHelper.SetString("WSTLoadOnOSStartupPath", WSTLoadOnOSStartupPath.Path)
			RegistryHelper.SetString("WSTLoadOnOSStartupArgs", WSTLoadOnOSStartupPath.Arguments)
			RegistryHelper.SetBool("WSTEnabled", WSTEnabled)

			' Screensaver Tool Options
			RegistryHelper.SetBool("WSTSSToolEnabled", WSTSSToolEnabled)
			RegistryHelper.SetString("WSTSSStartUp", WSTSSStartUp.ToString())
			RegistryHelper.SetBool("WSTSSEnableOnActivate", WSTSSEnableOnActivate)
			RegistryHelper.SetBool("WSTShowSSIcon", WSTShowSSIcon)
			RegistryHelper.SetBool("WSTShowSSActivate", WSTShowSSActivate)
			RegistryHelper.SetBool("WSTShowSSEnabled", WSTShowSSEnabled)

			' Clock Options
			RegistryHelper.SetBool("WSTShowClock", WSTShowClock)
			RegistryHelper.SetInt("WSTClockLocationX", WSTClockLocation.X)
			RegistryHelper.SetInt("WSTClockLocationY", WSTClockLocation.Y)
			RegistryHelper.SetString("WSTClockSize", WSTClockSize.ToString())

			' Menu / UI Toggles
			RegistryHelper.SetBool("WSTShowLockWorkSpace", WSTShowLockWorkSpace)
			RegistryHelper.SetBool("WSTShowLogOff", WSTShowLogOff)
			RegistryHelper.SetBool("WSTShowSleep", WSTShowSleep)
			RegistryHelper.SetBool("WSTShowHibernate", WSTShowHibernate)
			RegistryHelper.SetBool("WSTShowReStart", WSTShowReStart)
			RegistryHelper.SetBool("WSTShowShutDown", WSTShowShutDown)
			RegistryHelper.SetBool("WSTShowHelp", WSTShowHelp)
			RegistryHelper.SetBool("WSTShowLog", WSTShowLog)
			RegistryHelper.SetBool("WSTShowAC", WSTShowAC)
			RegistryHelper.SetBool("WSTShowWLMenu", WSTShowWLMenu)
			RegistryHelper.SetBool("WSTShowWLTray", WSTShowWLTray)

			' Theme
			Skye.Common.RegistryHelper.SetString("Theme", Theme.Name)
			Skye.Common.RegistryHelper.SetBool("ThemeAuto", ThemeAuto)

		End Sub
		Private Sub SaveSettingsAC()

			' Clean TimeSpan formatting (hh:mm or hh:mm:ss depending on needs)
			RegistryHelper.SetString("ACAlarmTime", ACAlarmTime.ToString("hh\:mm"))

			' Booleans
			RegistryHelper.SetBool("ACAlarmRecurring", ACAlarmRecurring)
			RegistryHelper.SetBool("ACTopHourChimeEnabled", ACTopHourChimeEnabled)
			RegistryHelper.SetBool("ACTopHourBeforeChimeEnabled", ACTopHourBeforeChimeEnabled)
			RegistryHelper.SetBool("ACTopHourAfterChimeEnabled", ACTopHourAfterChimeEnabled)
			RegistryHelper.SetBool("ACFirstQuarterHourChimeEnabled", ACFirstQuarterHourChimeEnabled)
			RegistryHelper.SetBool("ACFirstQuarterHourBeforeChimeEnabled", ACFirstQuarterHourBeforeChimeEnabled)
			RegistryHelper.SetBool("ACFirstQuarterHourAfterChimeEnabled", ACFirstQuarterHourAfterChimeEnabled)
			RegistryHelper.SetBool("ACBottomHourChimeEnabled", ACBottomHourChimeEnabled)
			RegistryHelper.SetBool("ACBottomHourBeforeChimeEnabled", ACBottomHourBeforeChimeEnabled)
			RegistryHelper.SetBool("ACBottomHourAfterChimeEnabled", ACBottomHourAfterChimeEnabled)
			RegistryHelper.SetBool("ACThirdQuarterHourChimeEnabled", ACThirdQuarterHourChimeEnabled)
			RegistryHelper.SetBool("ACThirdQuarterHourBeforeChimeEnabled", ACThirdQuarterHourBeforeChimeEnabled)
			RegistryHelper.SetBool("ACThirdQuarterHourAfterChimeEnabled", ACThirdQuarterHourAfterChimeEnabled)

			' Strings
			RegistryHelper.SetString("ACAlarmChimePath", ACAlarmChimePath)
			RegistryHelper.SetString("ACTopHourChimePath", ACTopHourChimePath)
			RegistryHelper.SetString("ACOffHourChimePath", ACOffHourChimePath)

			' Enums
			RegistryHelper.SetString("ACAlarmChimeType", ACAlarmChimeType.ToString())
			RegistryHelper.SetString("ACTopHourChimeType", ACTopHourChimeType.ToString())

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

	End Module

End Namespace
