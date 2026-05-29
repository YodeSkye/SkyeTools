
Imports System.Diagnostics

Partial Friend Class WSTStopWatch

	'Declarations
	Private mMove As Boolean = False
	Private mOffset, mStartLocation As Point
	Private WithEvents TimerTopMost As New Timer

	'Form Events
	Friend Sub New()
		'Initialize Globals
		'Initialize Locals
		Me.TimerTopMost.Interval = 5000
		'Initialize Form
		Me.InitializeComponent()
		Skye.WinAPI.HideFormInTaskSwitcher(Me.Handle)
		Me.Location = My.App.WSTStopWatchLocation
	End Sub
	Private Sub FrmVisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.VisibleChanged
		Debug.Print("frmVisibleChanged")
		If Me.Visible Then : TimerTopMost.Start()
		Else : TimerTopMost.Stop()
		End If
	End Sub
	Private Sub FrmMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, labelStopWatch.MouseDown
		mMove = True
		mStartLocation = Me.Location
		'mOffset = New Point(-e.X - SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height)
		mOffset = New Point(-e.X, -e.Y)
	End Sub
	Private Sub FrmMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, labelStopWatch.MouseMove
		If mMove AndAlso e.Button = MouseButtons.Left Then
			Dim mPosition As Point = Control.MousePosition
			mPosition.Offset(mOffset.X + 3, mOffset.Y + 1)
			Location = mPosition
		End If
	End Sub
	Private Sub FrmMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, labelStopWatch.MouseUp
		If mMove Then
			mMove = False
			If mStartLocation = Me.Location Then
				Select Case e.Button
					Case MouseButtons.Left : My.App.FrmMain.WSTToggleStopWatch()
					Case MouseButtons.Right : If My.App.MouseInBounds(Me, New Point(e.X, e.Y)) Then My.App.FrmMain.WSTStopWatchToggleWindow()
				End Select
			Else : My.App.WSTStopWatchLocation = Me.Location
			End If
		End If
	End Sub
	Private Sub FrmMove(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Move
		If Me.Right > My.Computer.Screen.Bounds.Right Then
			Me.Left = My.Computer.Screen.Bounds.Right - Me.Width
			'mMove = False
			My.App.WSTStopWatchLocation = Me.Location
		End If
		If Me.Bottom > My.Computer.Screen.Bounds.Bottom Then
			Me.Top = My.Computer.Screen.Bounds.Bottom - Me.Height
			'mMove = False
			My.App.WSTStopWatchLocation = Me.Location
		End If
		If Me.Left < 0 Then
			Me.Left = 0
			'mMove = False
			My.App.WSTStopWatchLocation = Me.Location
		End If
		If Me.Top < 0 Then
			Me.Top = 0
			'mMove = False
			My.App.WSTStopWatchLocation = Me.Location
		End If
	End Sub

	'Handlers
	Private Sub TimerTopMostTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerTopMost.Tick
		Debug.Print("TimerTopMostTick")
		If Not My.App.FrmMain.InUseApp Then Me.TopMost = True
	End Sub

End Class
