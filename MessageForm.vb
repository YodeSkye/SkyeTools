
Partial Friend Class MessageForm

	'Declarations
	Private rtbCM As New Skye.UI.RichTextBoxContextMenu
	Private txbxCM As New Skye.UI.TextBoxContextMenu
	Private mMove As Boolean = False
	Private mOffset, mPosition As Point

	'Form Events
	Friend Sub New()
        Me.InitializeComponent()
        rtbMessage.ContextMenuStrip = rtbCM
        tbPostMessage.ContextMenuStrip = txbxCM
    End Sub
	Private Sub FrmPaint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
		e.Graphics.DrawLine(SystemPens.WindowFrame, Me.rtbMessage.Left, Me.rtbMessage.Bottom, Me.rtbMessage.Right, Me.rtbMessage.Bottom)
	End Sub
	Private Sub FrmPreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs) Handles btnClose.PreviewKeyDown
		Select Case e.KeyData
			Case Keys.Escape : Me.Close()
		End Select
	End Sub
	Private Sub FrmMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

	End Sub
	Private Sub FrmMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
		If mMove Then
			mPosition = Control.MousePosition
			mPosition.Offset(mOffset.X, mOffset.Y)
			CheckMove(mPosition)
			Location = mPosition
		End If
	End Sub
	Private Sub FrmMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
		mMove = False
	End Sub
	Private Sub FrmMove(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Move
		If Not mMove AndAlso Me.WindowState = FormWindowState.Normal Then CheckMove(Me.Location)
	End Sub

	'Control Events
	Private Sub RtbMessagePreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles rtbMessage.PreviewKeyDown
		Select Case e.KeyData
			Case Keys.Escape : Me.Close()
			Case Else : Me.rtbCM.ShortcutKeys(DirectCast(sender, RichTextBox), e)
		End Select
	End Sub
	Private Sub TxbxPostMessagePreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles tbPostMessage.PreviewKeyDown
		Select Case e.KeyData
			Case Keys.Escape : Me.Close()
			Case Else : Me.txbxCM.ShortcutKeys(DirectCast(sender, TextBox), e)
		End Select
	End Sub
	Private Sub BtnCloseClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	'Procedures
	Private Sub CheckMove(ByRef location As Point)
		If location.X + Me.Width > My.Computer.Screen.WorkingArea.Right Then location.X = My.Computer.Screen.WorkingArea.Right - Me.Width
		If location.Y + Me.Height > My.Computer.Screen.WorkingArea.Bottom Then location.Y = My.Computer.Screen.WorkingArea.Bottom - Me.Height
		If location.X < My.Computer.Screen.WorkingArea.Left Then location.X = My.Computer.Screen.WorkingArea.Left
		If location.Y < My.Computer.Screen.WorkingArea.Top Then location.Y = My.Computer.Screen.WorkingArea.Top
	End Sub

End Class
