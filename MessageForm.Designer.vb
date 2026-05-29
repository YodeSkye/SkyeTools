Friend Partial Class MessageForm
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
        Me.components = New System.ComponentModel.Container()
        Me.rtbMessage = New System.Windows.Forms.RichTextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tbPostMessage = New System.Windows.Forms.TextBox()
        Me.tipInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'rtbMessage
        '
        Me.rtbMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbMessage.AutoWordSelection = True
        Me.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbMessage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbMessage.HideSelection = False
        Me.rtbMessage.Location = New System.Drawing.Point(0, 0)
        Me.rtbMessage.Name = "rtbMessage"
        Me.rtbMessage.ReadOnly = True
        Me.rtbMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbMessage.ShortcutsEnabled = False
        Me.rtbMessage.Size = New System.Drawing.Size(434, 136)
        Me.rtbMessage.TabIndex = 0
        Me.rtbMessage.TabStop = False
        Me.rtbMessage.Text = "MESSAGE"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Navy
        Me.btnClose.Image = My.Resources.Resources.imageClose
        Me.btnClose.Location = New System.Drawing.Point(89, 166)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(256, 34)
        Me.btnClose.TabIndex = 1
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tipInfo.SetToolTip(Me.btnClose, "Close Window")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tbPostMessage
        '
        Me.tbPostMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPostMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPostMessage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPostMessage.Location = New System.Drawing.Point(12, 142)
        Me.tbPostMessage.Name = "tbPostMessage"
        Me.tbPostMessage.ReadOnly = True
        Me.tbPostMessage.ShortcutsEnabled = False
        Me.tbPostMessage.Size = New System.Drawing.Size(410, 18)
        Me.tbPostMessage.TabIndex = 0
        Me.tbPostMessage.TabStop = False
        Me.tbPostMessage.Text = "POSTMESSAGE"
        Me.tbPostMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tipInfo
        '
        Me.tipInfo.AutomaticDelay = 250
        Me.tipInfo.AutoPopDelay = 10000
        Me.tipInfo.InitialDelay = 250
        Me.tipInfo.ReshowDelay = 50
        '
        'MessageForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(434, 212)
        Me.Controls.Add(Me.rtbMessage)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tbPostMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageForm"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TITLE"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tipInfo As System.Windows.Forms.ToolTip
    Public WithEvents tbPostMessage As System.Windows.Forms.TextBox
    Public WithEvents btnClose As System.Windows.Forms.Button
    Public WithEvents rtbMessage As System.Windows.Forms.RichTextBox
End Class