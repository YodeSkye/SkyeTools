
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Skye.UI
Imports SkyeTools.My

Public Class Clock
    Implements IDisposable

#Region "Fields & Properties"

    Private Shared ClassRegistered As Boolean = False
    Private Shared ReadOnly ClassName As String = "SkyeNativeClockClass"

    Private hWnd As IntPtr = IntPtr.Zero
    Private ReadOnly wndProcDelegateInstance As Skye.WinAPI.UTypedWndProcDelegate

    Private Const TIMER_CLOCK_ID As Integer = 1001
    Private Const TIMER_TOPMOST_ID As Integer = 1002

    Private currentSizeMode As App.ClockSize = App.WSTClockSize
    Private contextMenu As ContextMenuStrip
    Private cmiSmall, cmiMedium, cmiLarge As ToolStripMenuItem

    Private isDragging As Boolean = False
    Private dragStartPoint As Skye.WinAPI.POINT
    Private windowStartPos As Skye.WinAPI.POINT

    Private _isVisible As Boolean = False
    Public ReadOnly Property IsVisible As Boolean
        Get
            Return _isVisible
        End Get
    End Property

    Public ReadOnly Property Handle As IntPtr
        Get
            Return hWnd
        End Get
    End Property
#End Region

    Public Sub New()
        ' Bind delegate to prevent GC collection
        wndProcDelegateInstance = AddressOf WindowProc
        RegisterWindowClass()
        InitializeContextMenu()

        ' Theme Listener
        AddHandler Skye.UI.ThemeManager.ThemeChanged, AddressOf OnThemeChanged
    End Sub

#Region "Window Lifetime & Class Registration"
    Private Sub RegisterWindowClass()
        If ClassRegistered Then Exit Sub

        Dim wcx As New Skye.WinAPI.WNDCLASSEX()
        wcx.cbSize = CType(Marshal.SizeOf(wcx), UInteger)
        wcx.style = 0
        wcx.lpfnWndProc = Marshal.GetFunctionPointerForDelegate(wndProcDelegateInstance)
        wcx.cbClsExtra = 0
        wcx.cbWndExtra = 0
        wcx.hInstance = Marshal.GetHINSTANCE(GetType(Clock).Module)
        wcx.hIcon = IntPtr.Zero
        wcx.hCursor = Skye.WinAPI.LoadCursor(IntPtr.Zero, Skye.WinAPI.IDC_ARROW)
        wcx.hbrBackground = IntPtr.Zero
        wcx.lpszMenuName = Nothing
        wcx.lpszClassName = ClassName
        wcx.hIconSm = IntPtr.Zero

        If Skye.WinAPI.RegisterClassEx(wcx) <> 0 Then
            ClassRegistered = True
        End If
    End Sub

    Public Sub Show()
        If hWnd = IntPtr.Zero Then CreateNativeWindow()

        ApplySizeMode(App.WSTClockSize)

        Dim pos As Point = App.WSTClockLocation
        Dim dims As Size = GetSizeForMode(currentSizeMode)

        If pos = Point.Empty Then
            Dim screenArea As Rectangle = Screen.PrimaryScreen.WorkingArea
            pos = New Point(screenArea.Right - dims.Width - 20, screenArea.Top + 20)
            App.WSTClockLocation = pos
        Else
            ClampToScreen(pos.X, pos.Y, dims.Width, dims.Height)
        End If

        ' Apply Position, Size, TopMost Z-Order, and Show in ONE call:
        Skye.WinAPI.SetWindowPos(
            hWnd,
            Skye.WinAPI.HWND_TOPMOST,
            pos.X,
            pos.Y,
            dims.Width,
            dims.Height,
            Skye.WinAPI.SWP_NOACTIVATE Or Skye.WinAPI.SWP_SHOWWINDOW
        )

        ' Start Native Timers
        Skye.WinAPI.SetTimer(hWnd, CType(TIMER_CLOCK_ID, IntPtr), 200, IntPtr.Zero)
        Skye.WinAPI.SetTimer(hWnd, CType(TIMER_TOPMOST_ID, IntPtr), 5000, IntPtr.Zero)

        _isVisible = True
        Redraw()
    End Sub

    Public Sub Hide()
        If hWnd = IntPtr.Zero Then Exit Sub

        Skye.WinAPI.KillTimer(hWnd, CType(TIMER_CLOCK_ID, IntPtr))
        Skye.WinAPI.KillTimer(hWnd, CType(TIMER_TOPMOST_ID, IntPtr))

        Skye.WinAPI.ShowWindow(hWnd, Skye.WinAPI.SW_HIDE)
        _isVisible = False
    End Sub

    Private Sub CreateNativeWindow()
        If hWnd <> IntPtr.Zero Then Exit Sub

        Dim exStyle As Integer = Skye.WinAPI.WS_EX_TOPMOST Or Skye.WinAPI.WS_EX_TOOLWINDOW Or Skye.WinAPI.WS_EX_NOACTIVATE Or Skye.WinAPI.WS_EX_LAYERED
        Dim style As Integer = Skye.WinAPI.WS_POPUP

        hWnd = Skye.WinAPI.CreateWindowEx(exStyle, ClassName, String.Empty, style, 0, 0, 146, 40, IntPtr.Zero, IntPtr.Zero, Marshal.GetHINSTANCE(GetType(Clock).Module), IntPtr.Zero)

        If hWnd = IntPtr.Zero Then
            Throw New Exception("Native Clock window creation failed.")
        End If

        Skye.WinAPI.SetLayeredWindowAttributes(hWnd, 0, 255, Skye.WinAPI.LWA_ALPHA)
        Skye.WinAPI.HideFormInTaskSwitcher(hWnd)
        ApplyDwmAttributes()
    End Sub

    Private Sub ApplyDwmAttributes()
        Dim HResult As Integer
        Dim cornerPref As Integer = Skye.WinAPI.DWMWCP_ROUND
        HResult = Skye.WinAPI.DwmSetWindowAttribute(hWnd, Skye.WinAPI.DWMWA_WINDOW_CORNER_PREFERENCE, cornerPref, 4)

        Dim isDark As Integer
        If Skye.UI.ThemeManager.CurrentTheme Is Skye.UI.SkyeThemes.Dark Then
            isDark = 1
        Else
            isDark = 0
        End If
        HResult = Skye.WinAPI.DwmSetWindowAttribute(hWnd, Skye.WinAPI.DWMWA_USE_IMMERSIVE_DARK_MODE, isDark, 4)
    End Sub
#End Region

#Region "WndProc Message Loop"
    Private Function WindowProc(hWnd As IntPtr, msg As Skye.WinAPI.UType, wParam As IntPtr, lParam As IntPtr) As IntPtr
        Select Case msg
            Case Skye.WinAPI.UType.WM_ERASEBKGND
                ' Return TRUE (1) to prevent Windows from erasing the background and causing flicker
                Return New IntPtr(1)

            Case Skye.WinAPI.UType.WM_PAINT
                DrawClockContent()
                Return IntPtr.Zero

            Case Skye.WinAPI.UType.WM_TIMER
                Dim timerId As Integer = wParam.ToInt32()
                If timerId = TIMER_CLOCK_ID Then
                    Redraw()
                ElseIf timerId = TIMER_TOPMOST_ID Then
                    Skye.WinAPI.SetWindowPos(hWnd, Skye.WinAPI.HWND_TOPMOST, 0, 0, 0, 0, Skye.WinAPI.SWP_NOMOVE Or Skye.WinAPI.SWP_NOSIZE Or Skye.WinAPI.SWP_NOACTIVATE)
                End If
                Return IntPtr.Zero

            Case Skye.WinAPI.UType.WM_LBUTTONDOWN
                isDragging = True
                Skye.WinAPI.SetCapture(hWnd)

                Skye.WinAPI.GetCursorPos(dragStartPoint)
                Dim rc As Skye.WinAPI.RECT
                If Skye.WinAPI.GetWindowRect(hWnd, rc) Then
                    windowStartPos.X = rc.Left
                    windowStartPos.Y = rc.Top
                    ' Save current valid position immediately
                    My.App.WSTClockLocation = New Point(rc.Left, rc.Top)
                End If
                Return IntPtr.Zero

            Case Skye.WinAPI.UType.WM_MOUSEMOVE
                If isDragging Then
                    Dim currentMouse As Skye.WinAPI.POINT
                    Skye.WinAPI.GetCursorPos(currentMouse)
                    Dim deltaX As Integer = currentMouse.X - dragStartPoint.X
                    Dim deltaY As Integer = currentMouse.Y - dragStartPoint.Y

                    Dim newX As Integer = windowStartPos.X + deltaX
                    Dim newY As Integer = windowStartPos.Y + deltaY

                    Dim dims As Size = GetSizeForMode(currentSizeMode)
                    ClampToScreen(newX, newY, dims.Width, dims.Height)

                    Skye.WinAPI.MoveWindow(hWnd, newX, newY, dims.Width, dims.Height, True)

                    ' Update settings continuously while moving
                    My.App.WSTClockLocation = New Point(newX, newY)
                End If
                Return IntPtr.Zero

            Case Skye.WinAPI.UType.WM_LBUTTONUP
                If isDragging Then
                    isDragging = False
                    Skye.WinAPI.ReleaseCapture()

                    Dim currentMouse As Skye.WinAPI.POINT
                    Skye.WinAPI.GetCursorPos(currentMouse)

                    ' Check if it was a static click (no drag movement)
                    If currentMouse.X = dragStartPoint.X AndAlso currentMouse.Y = dragStartPoint.Y Then
                        My.App.ShowClock()
                    End If
                End If
                Return IntPtr.Zero

            Case Skye.WinAPI.UType.WM_RBUTTONUP
                Dim pt As Skye.WinAPI.POINT
                Skye.WinAPI.GetCursorPos(pt)
                contextMenu.Show(pt.X, pt.Y)
                Return IntPtr.Zero

            Case Skye.WinAPI.UType.WM_DESTROY
                Skye.WinAPI.KillTimer(hWnd, CType(TIMER_CLOCK_ID, IntPtr))
                Skye.WinAPI.KillTimer(hWnd, CType(TIMER_TOPMOST_ID, IntPtr))
                Return IntPtr.Zero
        End Select

        Return Skye.WinAPI.DefWindowProc(hWnd, msg, wParam, lParam)
    End Function
#End Region

#Region "Rendering & Layout"
    Private Sub Redraw()
        If hWnd <> IntPtr.Zero AndAlso _isVisible Then
            Skye.WinAPI.InvalidateRect(hWnd, IntPtr.Zero, False)
        End If
    End Sub

    Private Sub DrawClockContent()
        Dim rc As Skye.WinAPI.RECT
        If Not Skye.WinAPI.GetClientRect(hWnd, rc) Then Exit Sub

        Dim w As Integer = rc.Right - rc.Left
        Dim h As Integer = rc.Bottom - rc.Top
        If w <= 0 OrElse h <= 0 Then Exit Sub

        Dim ps As New Skye.WinAPI.PAINTSTRUCT()
        Dim hDC As IntPtr = Skye.WinAPI.BeginPaint(hWnd, ps)
        If hDC = IntPtr.Zero Then Exit Sub

        ' 1. Create off-screen buffer image
        Using bmp As New Bitmap(w, h)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.SmoothingMode = SmoothingMode.AntiAlias
                g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

                ' Inside DrawClockContent, where you set up colors:
                Dim backColor As Color = Skye.UI.ThemeManager.CurrentTheme.TextBack
                Dim textColor As Color = Skye.UI.ThemeManager.CurrentTheme.TextFore
                Dim borderColor As Color = Skye.UI.ThemeManager.CurrentTheme.BorderColor
                Dim borderWidth As Single = 4.0F   ' Try 2.0F or 3.0F (looks crisp without needing 6px)
                Dim cornerRadius As Single = 8.0F  ' Matches Windows 11 default corner curvature
                ' Offset rect by half the pen width so strokes don't get clipped
                Dim inset As Single = borderWidth / 2.0F
                Dim drawRect As New RectangleF(inset, inset, w - borderWidth - 1, h - borderWidth - 1)

                Using roundPath As GraphicsPath = CreateRoundedRect(drawRect, cornerRadius)
                    ' 1. Fill background
                    Using bgBrush As New SolidBrush(backColor)
                        g.FillPath(bgBrush, roundPath)
                    End Using

                    ' 2. Draw smooth rounded border
                    Using borderPen As New Pen(borderColor, borderWidth)
                        g.DrawPath(borderPen, roundPath)
                    End Using
                End Using

                ' Draw time text
                Dim timeStr As String = DateTime.Now.ToString("HH:mm:ss")
                Dim fontSize As Single = GetFontSizeForMode(currentSizeMode)

                Using clockFont As New Font("Segoe UI", fontSize, FontStyle.Bold, GraphicsUnit.Pixel)
                    Using textBrush As New SolidBrush(textColor)
                        Dim sf As New StringFormat() With {
                            .Alignment = StringAlignment.Center,
                            .LineAlignment = StringAlignment.Center
                        }
                        g.DrawString(timeStr, clockFont, textBrush, New RectangleF(0, 0, w, h), sf)
                    End Using
                End Using
            End Using

            ' 2. Blit finished image onto screen HDC in one pass
            Using screenGraphics As Graphics = Graphics.FromHdc(hDC)
                screenGraphics.DrawImage(bmp, 0, 0)
            End Using
        End Using

        Skye.WinAPI.EndPaint(hWnd, ps)
    End Sub

    Private Function CreateRoundedRect(rect As RectangleF, radius As Single) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d As Single = radius * 2.0F

        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Shared Function GetSizeForMode(mode As ClockSize) As Size
        Select Case mode
            Case ClockSize.Small : Return New Size(110, 29)
            Case ClockSize.Medium : Return New Size(152, 40)
            Case ClockSize.Large : Return New Size(244, 67)
            Case Else : Return New Size(152, 40)
        End Select
    End Function

    Private Shared Function GetFontSizeForMode(mode As ClockSize) As Single
        Select Case mode
            Case ClockSize.Small : Return 24.0F
            Case ClockSize.Medium : Return 34.0F
            Case ClockSize.Large : Return 52.0F
            Case Else : Return 34.0F
        End Select
    End Function

    Private Sub ApplySizeMode(mode As ClockSize)
        currentSizeMode = mode
        UpdateContextMenuChecks()

        If hWnd <> IntPtr.Zero AndAlso _isVisible Then
            Dim dims As Size = GetSizeForMode(mode)
            Dim rc As Skye.WinAPI.RECT
            Skye.WinAPI.GetWindowRect(hWnd, rc)

            Dim x As Integer = rc.Left
            Dim y As Integer = rc.Top
            ClampToScreen(x, y, dims.Width, dims.Height)

            Skye.WinAPI.MoveWindow(hWnd, x, y, dims.Width, dims.Height, True)
            App.WSTClockLocation = New Point(x, y)
            Redraw()
        End If
    End Sub

    Private Shared Sub ClampToScreen(ByRef x As Integer, ByRef y As Integer, ByVal width As Integer, ByVal height As Integer)
        ' Get active screen bounds (or primary screen)
        Dim screenBounds As Rectangle = Screen.FromPoint(New Point(x, y)).WorkingArea

        ' Clamp X (Left / Right boundaries)
        If x < screenBounds.Left Then
            x = screenBounds.Left
        ElseIf x + width > screenBounds.Right Then
            x = screenBounds.Right - width
        End If

        ' Clamp Y (Top / Bottom boundaries)
        If y < screenBounds.Top Then
            y = screenBounds.Top
        ElseIf y + height > screenBounds.Bottom Then
            y = screenBounds.Bottom - height
        End If
    End Sub

#End Region

#Region "Theme & Context Menu"
    Private Sub InitializeContextMenu()
        contextMenu = New ContextMenuStrip With {
            .Font = MenuFont,
            .Renderer = New Skye.UI.SkyeMenuRenderer
        }
        cmiSmall = New ToolStripMenuItem("Small", My.Resources.Resources.ImageSize16, AddressOf OnSizeClicked) With {.Tag = ClockSize.Small}
        cmiMedium = New ToolStripMenuItem("Medium", My.Resources.Resources.ImageSize16, AddressOf OnSizeClicked) With {.Tag = ClockSize.Medium}
        cmiLarge = New ToolStripMenuItem("Large", My.Resources.Resources.ImageSize16, AddressOf OnSizeClicked) With {.Tag = ClockSize.Large}
        contextMenu.Items.AddRange(New ToolStripItem() {cmiSmall, cmiMedium, cmiLarge})
    End Sub

    Private Sub OnSizeClicked(sender As Object, e As EventArgs)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing AndAlso TypeOf item.Tag Is ClockSize Then
            Dim selectedSize As ClockSize = CType(item.Tag, ClockSize)
            App.WSTClockSize = selectedSize
            ApplySizeMode(selectedSize)
        End If
    End Sub

    Private Sub UpdateContextMenuChecks()
        cmiSmall.Checked = (currentSizeMode = ClockSize.Small)
        cmiMedium.Checked = (currentSizeMode = ClockSize.Medium)
        cmiLarge.Checked = (currentSizeMode = ClockSize.Large)
    End Sub

    Private Sub OnThemeChanged(sender As Object, e As EventArgs)
        If hWnd <> IntPtr.Zero Then
            ApplyDwmAttributes()
            Redraw()
        End If
    End Sub
#End Region

#Region "IDisposable Support"
    Private isDisposed As Boolean = False

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not isDisposed Then
            If disposing Then
                ' Managed resources cleanup (if any)
                RemoveHandler Skye.UI.ThemeManager.ThemeChanged, AddressOf OnThemeChanged
            End If

            ' Unmanaged resources cleanup (Native Win32 HWND)
            If hWnd <> IntPtr.Zero Then
                Skye.WinAPI.DestroyWindow(hWnd)
                hWnd = IntPtr.Zero
            End If

            isDisposed = True
        End If
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Call the cleanup logic
        Dispose(True)

        ' Informs the GC that the object was cleaned up manually
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
