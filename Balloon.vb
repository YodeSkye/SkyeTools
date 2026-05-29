
Partial Friend Class Balloon

	'Form Events
	Friend Sub New()
		'Initialize Form
		Me.InitializeComponent()
		Skye.WinAPI.HideFormInTaskSwitcher(Me.Handle)
	End Sub
	Private Sub FrmClick(ByVal sender As Object, ByVal e As EventArgs) Handles picboxIcon.Click, MyBase.Click, lblTitle.Click, lblText.Click
		If Me.lblTitle.Text = My.App.ToolToString(My.App.Tools.AlarmChime) Then : My.App.FrmMain.ACAlarmCancel()
		Else : My.App.HideBalloon()
		End If
	End Sub

End Class
