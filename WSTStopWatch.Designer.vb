Friend Partial Class WSTStopWatch
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
        Me.labelStopWatch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelStopWatch
        '
        Me.labelStopWatch.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStopWatch.Location = New System.Drawing.Point(-3, -1)
        Me.labelStopWatch.Name = "labelStopWatch"
        Me.labelStopWatch.Size = New System.Drawing.Size(173, 39)
        Me.labelStopWatch.TabIndex = 0
        Me.labelStopWatch.Text = "00:00:00.000"
        Me.labelStopWatch.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'WSTStopWatch
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(173, 38)
        Me.ControlBox = False
        Me.Controls.Add(Me.labelStopWatch)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WSTStopWatch"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents labelStopWatch As System.Windows.Forms.Label
End Class