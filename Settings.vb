
Imports System.ComponentModel
Imports System.IO
Imports Skye.UI
Imports SkyeTools.My

Partial Friend Class Settings

    ' Declarations
    Private mMove As Boolean = False
    Private mOffset, mPosition As Point
    Private nonNumberEntered As Boolean
    Private suppressPageSelection As Boolean = False

    ' Form Events
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case Skye.WinAPI.WM_SYSCOMMAND
                Select Case CInt(m.WParam)
                    Case Skye.WinAPI.SC_CLOSE
                        App.HideSettings()
                    Case Else
                        MyBase.WndProc(m)
                End Select
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub
    Friend Sub New()

        ' Initialize Locals
        InitializeComponent()

        ' Initialize Form
        Text = "Settings For " + My.Application.Info.Title + "  v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
        ILPageSelector.Images.Add(My.Resources.Resources.imageApp)
        'ILPageSelector.Images.Add(My.Resources.Resources.ImageImage48)
        'ILPageSelector.Images.Add(My.Resources.Resources.ImageVideo48)
        LVPageSelector.Items.Add(New ListViewItem("App", 0))
        'LVPageSelector.Items.Add(New ListViewItem("Pics", 1))
        'LVPageSelector.Items.Add(New ListViewItem("Vids", 2))
        LVPageSelector.Items(0).Selected = True

    End Sub
    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ShowSettings()
        ShowSave()
    End Sub
    Private Sub Settings_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
#If DEBUG Then
        BtnErrorTest.Visible = True
#Else
#End If
        LVPageSelector.Focus()
        Skye.UI.ThemeManager.RegisterComponent(TipInfoEX)
        Skye.UI.ThemeManager.ApplyTheme(Me)
    End Sub
    Private Sub Settings_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, PanelApp.MouseDown, PanelWST.MouseDown, PanelSS.MouseDown, PanelActions.MouseDown
        If e.Button = MouseButtons.Left AndAlso WindowState = FormWindowState.Normal Then
            mMove = True
            Dim ctrl As Control = DirectCast(sender, Control)
            If TypeOf ctrl Is Panel Then
                mOffset = New Point(-e.X - 4 - ctrl.Left - SystemInformation.FrameBorderSize.Width, -e.Y - 4 - ctrl.Top - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight)
            Else
                mOffset = New Point(-e.X - SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight)
            End If
        End If
    End Sub
    Private Sub Settings_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, PanelApp.MouseMove, PanelWST.MouseMove, PanelSS.MouseMove, PanelActions.MouseMove
        If mMove Then
            mPosition = MousePosition
            mPosition.Offset(mOffset.X, mOffset.Y)
            CheckMove(mPosition)
            Location = mPosition
        End If
    End Sub
    Private Sub Settings_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, PanelApp.MouseUp, PanelWST.MouseUp, PanelSS.MouseUp, PanelActions.MouseUp
        mMove = False
    End Sub
    Private Sub Settings_Move(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Move
        If Not mMove AndAlso Me.WindowState = FormWindowState.Normal Then CheckMove(Me.Location)
    End Sub

    ' Control Events
    Private Sub PanelPage_Paint(sender As Object, e As PaintEventArgs) Handles PanelApp.Paint, PanelWST.Paint, PanelSS.Paint
        Dim pagePanel As Panel = DirectCast(sender, Panel)
        Using p As New Pen(Color.FromArgb(100, 100, 100))
            e.Graphics.DrawLine(p, 0, 0, 0, pagePanel.Height)
        End Using
    End Sub
    Private Sub PanelActions_Paint(sender As Object, e As PaintEventArgs) Handles PanelActions.Paint
        Using p As New Pen(Color.FromArgb(60, 60, 60), 2.0F)
            e.Graphics.DrawLine(p, 0, 0, PanelActions.Width, 0)
        End Using
    End Sub
    Private Sub LVPageSelector_MouseDown(sender As Object, e As MouseEventArgs) Handles LVPageSelector.MouseDown
        ' Find the item under the mouse
        suppressPageSelection = True
        Dim info As ListViewHitTestInfo = LVPageSelector.HitTest(e.Location)
        Dim item As ListViewItem = info.Item
        If item Is Nothing Then Return

        ' Ensure it becomes selected (for visual feedback)
        item.Selected = True
        Dim selectedSource As String = item.Text

        Select Case e.Clicks
            Case 1
                SetPage(selectedSource)
            Case 2
        End Select
        suppressPageSelection = False
    End Sub
    Private Sub LVPageSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVPageSelector.SelectedIndexChanged
        If suppressPageSelection OrElse LVPageSelector.SelectedItems.Count = 0 Then Return
        Dim selectedSource As String = LVPageSelector.SelectedItems(0).Text
        SetPage(LVPageSelector.SelectedItems(0).Text)
    End Sub
    Private Sub BtnInfoMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles BtnHelp.MouseUp
        If e.X >= 0 And e.X <= CType(sender, Button).Width And e.Y >= 0 And e.Y <= CType(sender, Button).Height Then
            Select Case e.Button
                Case MouseButtons.Left : My.App.ShowHelp(False)
                Case MouseButtons.Right : My.App.ShowHelp(True)
            End Select
        End If
    End Sub
    Private Sub BtnLogMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles BtnLog.MouseUp
        If e.X >= 0 And e.X <= CType(sender, Button).Width And e.Y >= 0 And e.Y <= CType(sender, Button).Height Then
            Select Case e.Button
                Case MouseButtons.Left : App.ShowLog(False)
                Case MouseButtons.Right : App.ShowLog(True)
            End Select
            If App.ErrorAlert Then App.ClearErrorAlert()
        End If
    End Sub
    Private Sub BtnCloseClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClose.Click
        App.HideSettings()
    End Sub
    Private Sub BtnErrorTestMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles BtnErrorTest.MouseUp
        If e.X >= 0 And e.X <= CType(sender, Button).Width And e.Y >= 0 And e.Y <= CType(sender, Button).Height Then
            Select Case e.Button
                Case MouseButtons.Left
                    App.SetErrorAlert()
                    MessageBox.Show(Me, "Just Checking, DO NOT PANIC!!", "Test Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    App.WriteToLog(App.Tools.SkyeTools, "Test Error - DO NOT PANIC!!")
                Case MouseButtons.Right
                    App.SetErrorAlert()
                    App.WriteToLog(App.Tools.SkyeTools, "Test Exception - DO NOT PANIC!!")
                    Throw New Exception("Test Exception - DO NOT PANIC!!")
            End Select
        End If
    End Sub
    Private Sub BtnSaveSettingsClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSaveSettings.Click
        My.App.SaveSettings()
        App.NeedsSaved = False
        ShowSave()
        'HideForm()
    End Sub
    Private Sub BtnRestoreSettingsClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRestoreSettings.Click
        RestoreSettings()
    End Sub

    ' Methods
    Private Sub SetPage(page As String)
        PanelApp.Enabled = False
        PanelWST.Enabled = False
        PanelSS.Enabled = False
        Select Case page
            Case "App"
                PanelApp.Enabled = True
                PanelApp.BringToFront()
            Case "Pics"
                PanelWST.Enabled = True
                PanelWST.BringToFront()
            Case "Vids"
                PanelSS.Enabled = True
                PanelSS.BringToFront()
        End Select
    End Sub
    Private Sub ShowSettings()

        UpdateSettings()
    End Sub
    Friend Sub UpdateSettings() 'Settings that can change on other forms

    End Sub
    Friend Sub RestoreSettings()
        My.App.GetSettings()
        ShowSettings()
        Dim selectedTheme As Skye.UI.SkyeTheme = If(App.ThemeAuto, Skye.UI.ThemeManager.DetectWindowsTheme(), App.Theme)
        Skye.UI.ThemeManager.SetTheme(selectedTheme)
        App.NeedsSaved = False
        ShowSave()
    End Sub
    Friend Sub ShowSave()
        If App.NeedsSaved Then
            BtnSaveSettings.BackColor = Color.Red
            TipInfoEX.SetText(BtnSaveSettings, "Settings Need Saved")
        Else
            BtnSaveSettings.BackColor = Skye.UI.ThemeManager.CurrentTheme.ButtonBack
            TipInfoEX.SetText(BtnSaveSettings, "Save All Settings")
        End If
    End Sub
    Private Sub SetThemesList()
        If App.ThemeAuto Then
            'CoBoxTheme.Enabled = False
        Else
            'CoBoxTheme.Enabled = True
        End If
    End Sub
    Private Sub CheckMove(ByRef location As Point)
        Dim screen As Rectangle = System.Windows.Forms.Screen.FromControl(Me).WorkingArea
        If location.X + Width > screen.Right Then location.X = screen.Right - Width + App.AdjustScreenBoundsNormalWindow
        If location.Y + Height > screen.Bottom Then location.Y = screen.Bottom - Height + App.AdjustScreenBoundsNormalWindow
        If location.X < screen.Left Then location.X = screen.Left - App.AdjustScreenBoundsNormalWindow
        If location.Y < screen.Top Then location.Y = screen.Top
    End Sub

End Class
