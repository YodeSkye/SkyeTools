Friend Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        RTxtBoxMessage = New RichTextBox()
        BtnOK = New Button()
        TxtBoxPostMessage = New TextBox()
        SuspendLayout()
        ' 
        ' RTxtBoxMessage
        ' 
        RTxtBoxMessage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RTxtBoxMessage.AutoWordSelection = True
        RTxtBoxMessage.BorderStyle = BorderStyle.None
        RTxtBoxMessage.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RTxtBoxMessage.HideSelection = False
        RTxtBoxMessage.Location = New Point(0, 0)
        RTxtBoxMessage.Margin = New Padding(0)
        RTxtBoxMessage.Name = "RTxtBoxMessage"
        RTxtBoxMessage.ReadOnly = True
        RTxtBoxMessage.ShortcutsEnabled = False
        RTxtBoxMessage.ShowSelectionMargin = True
        RTxtBoxMessage.Size = New Size(584, 288)
        RTxtBoxMessage.TabIndex = 0
        RTxtBoxMessage.Text = "MESSAGE"
        ' 
        ' BtnOK
        ' 
        BtnOK.Anchor = AnchorStyles.Bottom
        BtnOK.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnOK.ForeColor = Color.Navy
        BtnOK.Image = My.Resources.Resources.ImageOK
        BtnOK.Location = New Point(258, 326)
        BtnOK.Name = "BtnOK"
        BtnOK.Size = New Size(64, 64)
        BtnOK.TabIndex = 1
        BtnOK.TextAlign = ContentAlignment.MiddleRight
        BtnOK.UseVisualStyleBackColor = True
        ' 
        ' TxtBoxPostMessage
        ' 
        TxtBoxPostMessage.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TxtBoxPostMessage.BorderStyle = BorderStyle.None
        TxtBoxPostMessage.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtBoxPostMessage.Location = New Point(11, 297)
        TxtBoxPostMessage.Name = "TxtBoxPostMessage"
        TxtBoxPostMessage.ReadOnly = True
        TxtBoxPostMessage.ShortcutsEnabled = False
        TxtBoxPostMessage.Size = New Size(560, 22)
        TxtBoxPostMessage.TabIndex = 0
        TxtBoxPostMessage.TabStop = False
        TxtBoxPostMessage.Text = "POSTMESSAGE"
        TxtBoxPostMessage.TextAlign = HorizontalAlignment.Center
        ' 
        ' Help
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoValidate = AutoValidate.Disable
        ClientSize = New Size(584, 402)
        Controls.Add(RTxtBoxMessage)
        Controls.Add(BtnOK)
        Controls.Add(TxtBoxPostMessage)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MinimumSize = New Size(450, 300)
        Name = "Help"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "Help & About"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Public WithEvents TxtBoxPostMessage As System.Windows.Forms.TextBox
    Public WithEvents BtnOK As System.Windows.Forms.Button
    Public WithEvents RTxtBoxMessage As System.Windows.Forms.RichTextBox
End Class