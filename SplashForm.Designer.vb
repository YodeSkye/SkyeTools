Friend Partial Class SplashForm
Inherits System.Windows.Forms.Form
		''' <summary>
		''' Designer variable used to keep track of non-visual components.
		''' </summary>
	Private components As System.ComponentModel.IContainer
		''' <summary>
		''' Disposes resources used by the form.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
		''' <summary>
		''' This method is required for Windows Forms designer support.
		''' Do not change the method contents inside the source code editor. The Forms designer might
		''' not be able to load this method if it was changed manually.
		''' </summary>
	Private Sub InitializeComponent
        Me.lblSplashText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSplashText
        '
        Me.lblSplashText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplashText.Location = New System.Drawing.Point(0, 5)
        Me.lblSplashText.Name = "lblSplashText"
        Me.lblSplashText.Size = New System.Drawing.Size(194, 29)
        Me.lblSplashText.TabIndex = 0
        Me.lblSplashText.Text = "TESTTEXT"
        Me.lblSplashText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplashForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(194, 29)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSplashText)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Private lblSplashText As System.Windows.Forms.Label
End Class