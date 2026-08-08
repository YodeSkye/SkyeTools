
Imports SkyeTools.My

Partial Friend Class Help

	' Declarations
	Private mMove As Boolean = False
	Private mOffset, mPosition As Point

	' Form Events
	Friend Sub New()
		InitializeComponent()
		'Skye.UI.ThemeManager.ApplyTheme(Me)
	End Sub
	Private Sub Help_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		App.FrmHelp?.Dispose()
		App.FrmHelp = Nothing
	End Sub
	Private Sub Help_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
		If e.Button = MouseButtons.Left And Me.WindowState = FormWindowState.Normal Then
			mMove = True
			mOffset = New Point(-e.X - SystemInformation.FrameBorderSize.Width * 2, -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height * 2)
		End If
	End Sub
	Private Sub Help_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
		If mMove Then
			mPosition = Control.MousePosition
			mPosition.Offset(mOffset.X, mOffset.Y)
			CheckMove(mPosition)
			Location = mPosition
		End If
	End Sub
	Private Sub Help_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
		mMove = False
	End Sub
	Private Sub Help_Move(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Move
		If Not mMove AndAlso Me.WindowState = FormWindowState.Normal Then CheckMove(Me.Location)
	End Sub
	Private Sub Help_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
		ChangeWindowState()
	End Sub

	' Control Events
	Private Sub TextPreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs) Handles TxtBoxPostMessage.PreviewKeyDown, RTxtBoxMessage.PreviewKeyDown
		Dim senderTXBX As TextBoxBase = CType(sender, TextBoxBase)
		Select Case e.KeyData
			Case Keys.Escape : Close()
			Case Keys.C Or Keys.Control : If senderTXBX.SelectionLength > 0 Then senderTXBX.Copy()
			Case Keys.A Or Keys.Control : senderTXBX.SelectAll()
		End Select
	End Sub
	Private Sub BtnEnter(ByVal sender As Object, ByVal e As EventArgs)
		BtnOK.Focus()
	End Sub
	Private Sub BtnCloseClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOK.Click
		Me.Close()
	End Sub

	' Procedures
	Friend Sub ChangeWindowState()
		Select Case Me.WindowState
			Case FormWindowState.Normal : Me.WindowState = FormWindowState.Maximized
			Case FormWindowState.Maximized : Me.WindowState = FormWindowState.Normal
		End Select
		Me.RTxtBoxMessage.Focus()
	End Sub
	Private Sub CheckMove(ByRef location As Point)
		Dim screen As Rectangle = System.Windows.Forms.Screen.FromControl(Me).WorkingArea
		If location.X + Width > screen.Right Then location.X = screen.Right - Width + App.AdjustScreenBoundsNormalWindow
		If location.Y + Height > screen.Bottom Then location.Y = screen.Bottom - Height + App.AdjustScreenBoundsNormalWindow
		If location.X < screen.Left Then location.X = screen.Left - App.AdjustScreenBoundsNormalWindow
		If location.Y < screen.Top Then location.Y = screen.Top
	End Sub

End Class
