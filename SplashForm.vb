
Partial Friend Class SplashForm

	'Form Events
	Friend Sub New()
		'Initialize Form
		Me.InitializeComponent()
		Me.lblSplashText.Text = "Starting " + My.Application.Info.ProductName + "..."
		If My.Application.AlternateStart Then Me.lblSplashText.ForeColor = Color.Firebrick
		Me.Left = My.Computer.Screen.WorkingArea.Right - Me.Width - 25
		Me.Top = My.Computer.Screen.WorkingArea.Top + 25
	End Sub
	Private Sub SplashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Skye.WinAPI.HideFormInTaskSwitcher(Me.Handle)
	End Sub

End Class