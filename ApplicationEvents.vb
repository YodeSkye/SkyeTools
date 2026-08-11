
Imports System.Diagnostics

Namespace My

	Partial Friend Class MyApplication

		'App Declarations
		Friend CurrentProcess As Diagnostics.Process = Diagnostics.Process.GetCurrentProcess
		Friend AlternateStart As Boolean = False

		'App Events
		Public Sub New()
			MyBase.New(ApplicationServices.AuthenticationMode.Windows)
			Try
				CurrentProcess.PriorityClass = Diagnostics.ProcessPriorityClass.AboveNormal
			Catch
			End Try
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
			If commandline.Count > 0 Then
				For Each command As String In commandline
					If Not String.IsNullOrWhiteSpace(command) AndAlso command.ToUpper = "/ALTSTART" Then AlternateStart = True
				Next
			End If
		End Sub

	End Class

End Namespace
