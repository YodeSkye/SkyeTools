
Imports SkyeTools.My

Partial Friend Class WSTClock

	'Declarations
	Private mMove As Boolean = False
	Private mOffset, mStartLocation As Point
	Private WithEvents TimerClock As New Timer
	Private WithEvents TimerTopMost As New Timer

	'Form Events
	Friend Sub New()

		'Initialize Locals
		Me.TimerClock.Interval = 200
		Me.TimerTopMost.Interval = 5000

		'Initialize Form
		Me.InitializeComponent()
		Skye.WinAPI.HideFormInTaskSwitcher(Me.Handle)
		Me.Location = My.App.WSTClockLocation
		SetClockSizeCheckedState()

	End Sub
	Private Sub FrmVisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.VisibleChanged
		If Me.Visible Then
			ShowCurrentTime()
			TimerClock.Start()
			TimerTopMost.Start()
		Else
			TimerClock.Stop()
			TimerTopMost.Stop()
		End If
	End Sub
	Private Sub FrmMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, lblClock.MouseDown
		If e.Button = MouseButtons.Left Then
			mMove = True
			mStartLocation = Me.Location
			mOffset = New Point(-e.X, -e.Y + 4)
		End If
	End Sub
	Private Sub FrmMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, lblClock.MouseMove
		If mMove Then
			Dim mPosition As Point = Control.MousePosition
			mPosition.Offset(mOffset.X, mOffset.Y)
			Location = mPosition
		End If
	End Sub
	Private Sub FrmMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, lblClock.MouseUp
		If mMove Then
			mMove = False
			If mStartLocation = Me.Location Then : My.App.FrmMain.WSTShowClock()
			Else : My.App.WSTClockLocation = Me.Location
			End If
		End If
	End Sub
	Private Sub FrmMove(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Move
		CheckMove()
	End Sub

	'Control Events
	Private Sub CMIWSTClockSmall_Click(sender As Object, e As EventArgs) Handles cmiWSTClockSmall.Click
		App.WSTClockSize = App.ClockSize.Small
		FrmMain.SizeClock()
		SetClockSizeCheckedState()
	End Sub
	Private Sub CMIWSTClockMedium_Click(sender As Object, e As EventArgs) Handles cmiWSTClockMedium.Click
		App.WSTClockSize = App.ClockSize.Medium
		FrmMain.SizeClock()
		SetClockSizeCheckedState()
	End Sub
	Private Sub CMIWSTClockLarge_Click(sender As Object, e As EventArgs) Handles cmiWSTClockLarge.Click
		App.WSTClockSize = App.ClockSize.Large
		FrmMain.SizeClock()
		SetClockSizeCheckedState()
	End Sub

	'Handlers
	Private Sub TimerClockTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerClock.Tick
		ShowCurrentTime()
	End Sub
	Private Sub TimerTopMostTick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerTopMost.Tick
		Debug.Print("timerTopMostTick")
		If Not My.App.FrmMain.InUseApp Then Me.TopMost = True
	End Sub

	'Procedures
	Private Sub ShowCurrentTime()
		Me.lblClock.Text = New Date(My.Computer.Clock.LocalTime.TimeOfDay.Ticks).ToString("HH:mm:ss")
	End Sub
	Private Sub SetClockSizeCheckedState()
		cmiWSTClockSmall.Checked = False
		cmiWSTClockMedium.Checked = False
		cmiWSTClockLarge.Checked = False
		Select Case App.WSTClockSize
			Case App.ClockSize.Small
				cmiWSTClockSmall.Checked = True
			Case App.ClockSize.Medium
				cmiWSTClockMedium.Checked = True
			Case App.ClockSize.Large
				cmiWSTClockLarge.Checked = True
		End Select
	End Sub
	Friend Sub CheckMove()
		If Me.Right > My.Computer.Screen.Bounds.Width Then
			Me.Left = My.Computer.Screen.Bounds.Width - Me.Width
			My.App.WSTClockLocation = Me.Location
		End If
		If Me.Bottom > My.Computer.Screen.Bounds.Height Then
			Me.Top = My.Computer.Screen.Bounds.Height - Me.Height
			My.App.WSTClockLocation = Me.Location
		End If
		If Me.Left < 0 Then
			Me.Left = 0
			My.App.WSTClockLocation = Me.Location
		End If
		If Me.Top < 0 Then
			Me.Top = 0
			My.App.WSTClockLocation = Me.Location
		End If
	End Sub

End Class
