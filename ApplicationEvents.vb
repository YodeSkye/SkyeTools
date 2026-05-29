
Imports System.Diagnostics

Namespace My

	Partial Friend Class MyApplication

		'App Declarations
		Friend CurrentProcess As Diagnostics.Process = Diagnostics.Process.GetCurrentProcess
		Friend AlternateStart As Boolean = False
		Private DelayedStart As Integer = 2000

		'App Events
		Public Sub New()
			MyBase.New(ApplicationServices.AuthenticationMode.Windows)
			CurrentProcess.PriorityClass = Diagnostics.ProcessPriorityClass.AboveNormal
			If My.Computer.Keyboard.ShiftKeyDown Then AlternateStart = True
			Me.IsSingleInstance = True
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = False
			Me.ShutdownStyle = ApplicationServices.ShutdownMode.AfterMainFormCloses
		End Sub
		Protected Overrides Sub OnCreateSplashScreen()
#If DEBUG Then
#Else
			ProcessCommandLine(My.Application.CommandLineArgs)
			My.Application.MinimumSplashScreenDisplayTime = DelayedStart
			Me.SplashScreen = New SplashForm
#End If
		End Sub
		Protected Overrides Function OnStartup(e As ApplicationServices.StartupEventArgs) As Boolean
			If e.Cancel Then : Return False
			Else
				My.App.Initialize()
				Return True
			End If
		End Function
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = My.App.FrmMain
		End Sub

		'App Procedures
		Protected Sub ProcessCommandLine(ByRef commandline As Collections.ObjectModel.ReadOnlyCollection(Of String))
			If commandline.Count = 0 Then
				Debug.Print("ProcessCommandLine: No CommandLine Arguments")
			Else
				For Each command As String In commandline
					Debug.Print("ProcessCommandLine: Command: " + command)
					If Not String.IsNullOrEmpty(command) Then
						Dim commands As String() = command.Split(New Char() {CChar(":")}, StringSplitOptions.RemoveEmptyEntries)
						Select Case commands.Length
							Case 1
								Select Case commands(0).ToUpper
									Case "/ALTSTART"
										AlternateStart = True
									Case Else
										Debug.Print("ProcessCommandLine: Command: " + command + " = Invalid Command")
								End Select
							Case 2
#If DEBUG Then
								For Each s As String In commands
									Debug.Print("ProcessCommandLine: Command: " + command + " : " + s)
								Next
#End If
								Select Case commands(0).ToUpper
									Case "/DELAYEDSTART"
										DelayedStart = CInt(Val(commands(1))) * 1000
										If DelayedStart < 2000 Then : DelayedStart = 2000
										ElseIf DelayedStart > 300000 Then : DelayedStart = 300000
										End If
									Case Else
										Debug.Print("ProcessCommandLine: Command: " + command + " = Invalid Command")
								End Select
							Case Else
								Debug.Print("ProcessCommandLine: Command: " + command + " = Invalid Command")
						End Select
						commands = Nothing
					End If
					command = Nothing
				Next
			End If
		End Sub

	End Class

End Namespace
