Friend Partial Class WSTClock
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
        components = New ComponentModel.Container()
        lblClock = New Label()
        cmWSTClockSize = New ContextMenuStrip(components)
        cmiWSTClockSmall = New ToolStripMenuItem()
        cmiWSTClockMedium = New ToolStripMenuItem()
        cmiWSTClockLarge = New ToolStripMenuItem()
        cmWSTClockSize.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblClock
        ' 
        lblClock.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblClock.ContextMenuStrip = cmWSTClockSize
        lblClock.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblClock.Location = New Point(0, -4)
        lblClock.Name = "lblClock"
        lblClock.Size = New Size(148, 38)
        lblClock.TabIndex = 0
        lblClock.Text = "10:00:01"
        lblClock.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmWSTClockSize
        ' 
        cmWSTClockSize.Items.AddRange(New ToolStripItem() {cmiWSTClockSmall, cmiWSTClockMedium, cmiWSTClockLarge})
        cmWSTClockSize.Name = "cmWSTClockSize"
        cmWSTClockSize.Size = New Size(181, 92)
        ' 
        ' cmiWSTClockSmall
        ' 
        cmiWSTClockSmall.Image = My.Resources.Resources.ImageSize16
        cmiWSTClockSmall.Name = "cmiWSTClockSmall"
        cmiWSTClockSmall.Size = New Size(180, 22)
        cmiWSTClockSmall.Text = "Small"
        ' 
        ' cmiWSTClockMedium
        ' 
        cmiWSTClockMedium.Image = My.Resources.Resources.ImageSize16
        cmiWSTClockMedium.Name = "cmiWSTClockMedium"
        cmiWSTClockMedium.Size = New Size(180, 22)
        cmiWSTClockMedium.Text = "Medium"
        ' 
        ' cmiWSTClockLarge
        ' 
        cmiWSTClockLarge.Image = My.Resources.Resources.ImageSize16
        cmiWSTClockLarge.Name = "cmiWSTClockLarge"
        cmiWSTClockLarge.Size = New Size(180, 22)
        cmiWSTClockLarge.Text = "Large"
        ' 
        ' WSTClock
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        AutoValidate = AutoValidate.EnableAllowFocusChange
        ClientSize = New Size(146, 40)
        ControlBox = False
        Controls.Add(lblClock)
        Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "WSTClock"
        ShowIcon = False
        ShowInTaskbar = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.Manual
        TopMost = True
        cmWSTClockSize.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblClock As Label
    Friend WithEvents cmWSTClockSize As ContextMenuStrip
    Friend WithEvents cmiWSTClockSmall As ToolStripMenuItem
    Friend WithEvents cmiWSTClockMedium As ToolStripMenuItem
    Friend WithEvents cmiWSTClockLarge As ToolStripMenuItem
End Class