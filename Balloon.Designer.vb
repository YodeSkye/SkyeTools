Friend Partial Class Balloon
Inherits System.Windows.Forms.Form
	Private components As System.ComponentModel.IContainer
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	Private Sub InitializeComponent
        Me.picboxIcon = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        CType(Me.picboxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picboxIcon
        '
        Me.picboxIcon.Location = New System.Drawing.Point(6, 6)
        Me.picboxIcon.Name = "picboxIcon"
        Me.picboxIcon.Size = New System.Drawing.Size(16, 16)
        Me.picboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxIcon.TabIndex = 1
        Me.picboxIcon.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(24, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(32, 17)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Title"
        Me.lblTitle.UseMnemonic = False
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblText.Location = New System.Drawing.Point(4, 32)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(36, 20)
        Me.lblText.TabIndex = 3
        Me.lblText.Text = "Text"
        Me.lblText.UseMnemonic = False
        '
        'Balloon
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(120, 26)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picboxIcon)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Balloon"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 2, 6)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        CType(Me.picboxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lblText As System.Windows.Forms.Label
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents picboxIcon As System.Windows.Forms.PictureBox
End Class