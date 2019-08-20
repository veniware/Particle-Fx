Public Class frmPreview

    Public FPS As Short

    Dim TimerList As New List(Of List(Of Particle))
    Dim TimeWidth As Integer '= 100
    Dim TimePoint As Integer = 0

    Dim Reactor As Byte

    Dim Zoom As Decimal = 1
    Dim OffSet As Point
    Dim PreOffSet As Point

    Dim MousePositionX As Integer
    Dim MousePositionY As Integer

    Private Sub frmPreview_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If tLoadAnimation IsNot Nothing Then
            If tLoadAnimation.IsAlive Then
                If MessageBox("Animation is loading." & System.Environment.NewLine & "Do you want to cancel the animation prosess and close this window?", "Close", 3, 1) = Windows.Forms.DialogResult.Yes Then
                    If tLoadAnimation.IsAlive Then tLoadAnimation.Abort()
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub frmPreview_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If tLoadAnimation IsNot Nothing Then If tLoadAnimation.IsAlive Then tLoadAnimation.Abort()
    End Sub

    Dim tLoadAnimation As Threading.Thread = New Threading.Thread(AddressOf LoadAnimation)
    Public Sub New(ByVal TW As Integer, ByVal R As Byte)
        TimeWidth = TW
        Reactor = R

        InitializeComponent()
        pnlBottom.Height = 32

        LoadTimerLine()

        Control.CheckForIllegalCrossThreadCalls = False

        tLoadAnimation.Priority = Threading.ThreadPriority.Highest
        tLoadAnimation.Start()

        Me.Show()
        cmdTimerPoint.Focus()
    End Sub

    Sub LoadTimerLine()
        For i As Integer = Sprays.Count - 1 To 0 Step -1
            Dim l As New TimeLineItem(Sprays(i).name, TimeWidth, Sprays(i).startGen, Sprays(i).stopGen, Sprays(i).Color)
            pnlTimerList.Controls.Add(l.pnlItem)
        Next

        For i As Integer = Rains.Count - 1 To 0 Step -1
            Dim l As New TimeLineItem(Rains(i).name, TimeWidth, Rains(i).startGen, Rains(i).stopGen, Rains(i).Color)
            pnlTimerList.Controls.Add(l.pnlItem)
        Next

        For i As Integer = Points.Count - 1 To 0 Step -1
            Dim l As New TimeLineItem(Points(i).name, TimeWidth, Points(i).startGen, Points(i).stopGen, Points(i).Color)
            pnlTimerList.Controls.Add(l.pnlItem)
        Next

        For i As Integer = Bitmaps.Count - 1 To 0 Step -1
            Dim l As New TimeLineItem(Bitmaps(i).name, TimeWidth, Bitmaps(i).startGen, Bitmaps(i).startGen + 1, Color.Blue)
            pnlTimerList.Controls.Add(l.pnlItem)
        Next
    End Sub

    Sub LoadAnimation()

        Dim Prog As New Panel
        Prog.BackColor = Color.FromArgb(200, 200, 200)
        Prog.Location = New Point(0, 22)
        Prog.Size = New Size(1, 8)
        pnlTimerLine.Controls.Add(Prog)
        Prog.BringToFront()

        Dim temp As New List(Of Particle)

        Dim cam As New Camera
        cam.x = 0
        cam.y = 0
        cam.Widht = pnlFrame.Width
        cam.Height = pnlFrame.Height

        Engine.WavesBalancer()
        Engine.BuildWarp()

        For i As Integer = 0 To TimeWidth

            Engine.GenerateParticles(temp, i)
            Engine.ExpiryParticles(temp)
            Select Case Reactor
                Case 0 : Engine.Reactor0_2(temp)
                Case 1 : Engine.Reactor1_0(temp)
                Case 2 : Engine.SpaceReactor1_0(temp)
            End Select

            Dim clone As New List(Of Particle)
            For p As Integer = 0 To temp.Count - 1
                clone.Add(temp(p))
            Next
            TimerList.Add(clone)

            Prog.Width = i * pnlTimerLine.Width \ TimeWidth
        Next

        pnlTimerLine.Controls.Remove(Prog)
        Prog.Dispose()

        RenderFrame()
    End Sub

    Sub RenderFrame()
        If TimePoint >= TimerList.Count Then Exit Sub

        Dim cam As New Camera
        cam.x = 0
        cam.y = 0
        cam.Widht = pnlFrame.Width
        cam.Height = pnlFrame.Height
        pnlFrame.BackgroundImage = Engine.QuickRender(TimerList(TimePoint), cam, Zoom, OffSet)
        txtParticlesCounter.Text = TimerList(TimePoint).Count & "p"
    End Sub

    Sub PlayAnime()
        tmrPlayer.Start()
        cmdPlay.BackgroundImage = My.Resources.Pause
    End Sub

    Sub StopAnime()
        tmrPlayer.Stop()
        cmdPlay.BackgroundImage = My.Resources.Play
        cmdTimerPoint.Left = pnlTimerLine.Width * TimePoint \ TimeWidth - 10
        txtFPS.Text = ""
    End Sub

    Sub FinalPreview()
        If Zoom <> 1 Then Zoom = 1
        RenderFrame()

        Dim frmR As New frmRender
        frmR.pnlFrames.Height = 20
        frmR.pnlEnvironment.Height = frmR.EnvironmentH
        frmR.pnlParticles.Height = frmR.ParticlesH
        frmR.pnlReact.Height = 20
        frmR.ResizeMainList()
        frmR.pnlFrames.Enabled = False
        frmR.pnlReact.Enabled = False

        frmR.cmdOK.Text = "Preview"

        If frmR.ShowDialog = DialogResult.OK Then

            Dim cam As New Camera
            cam.x = -OffSet.X
            cam.y = -OffSet.Y
            cam.Widht = pnlFrame.Width
            cam.Height = pnlFrame.Height

            Engine.BuildGlossiness()

            Dim FinalPreview As Image = Renderer(TimerList(TimePoint), cam, Imaging.PixelFormat.Format24bppRgb, Drawing2D.SmoothingMode.AntiAlias)

            Dim frmShow As New Form
            frmShow.Text = "Final preview: " & TimePoint
            frmShow.Icon = frmMain.Icon
            frmShow.BackColor = Me.BackColor
            frmShow.ClientSize = New Size(FinalPreview.Width / 2, FinalPreview.Height / 2)
            frmShow.BackgroundImageLayout = ImageLayout.Zoom
            frmShow.BackgroundImage = FinalPreview
            frmShow.Show()
        End If

    End Sub


    Private Sub pnlFrame_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlFrame.Resize
        If TimerList.Count - 1 = TimeWidth Then RenderFrame()
    End Sub

    Sub RefreshTimerLine()
        Dim TM As Image = New Bitmap(pnlTimerLine.Width, pnlTimerLine.Height, Imaging.PixelFormat.Format24bppRgb)

        Using G As Graphics = Graphics.FromImage(TM)

            Dim b As New Drawing.TextureBrush(My.Resources.BlackBar)
            b.ScaleTransform(1, TM.Height / My.Resources.BlackBar.Height)

            G.FillRectangle(b, 0, 0, TM.Width, TM.Height)

            Dim s As Decimal = pnlTimerLine.Width / TimeWidth
            If s = 0 Then s = 8
            Do Until (s >= 8)
                s *= 2
            Loop

            For d As Decimal = 0 To pnlTimerLine.Width - 1 Step s
                If Not d = 0 Then
                    If d Mod s * 10 = 0 Then
                        G.DrawLine(New Pen(Brushes.Silver, 2), d - 1, 17, d - 1, 30)
                        G.DrawString(Math.Round(d * TimeWidth / pnlTimerLine.Width, 1), Me.Font, Brushes.Silver, d, 10, frmMain.StringFormatCenterHor)
                    Else
                        G.DrawLine(New Pen(Brushes.Gray, 2), d - 1, 22, d - 1, 30)
                    End If
                End If
            Next

        End Using

        pnlTimerLine.BackgroundImage = TM
    End Sub


    Private Sub pnlTimerLine_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlTimerLine.Resize
        RefreshTimerLine()
        cmdTimerPoint.Left = pnlTimerLine.Width * TimePoint \ TimeWidth - 10
    End Sub

    Dim TimerLineHeight As Integer
    Private Sub pnlResize_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlResize.MouseDown
        MousePositionY = Windows.Forms.Cursor.Position.Y
        TimerLineHeight = pnlBottom.Height
    End Sub
    Private Sub pnlResize_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlResize.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim h As Integer = TimerLineHeight - (Windows.Forms.Cursor.Position.Y - MousePositionY)
            If h > 320 Then h = 320
            If h < 32 Then h = 32
            pnlBottom.Height = h
        End If
    End Sub


    Dim preTimePoint As Integer
    Private Sub cmdTimerPoint_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdTimerPoint.MouseDown
        MousePositionX = Windows.Forms.Cursor.Position.X
        preTimePoint = cmdTimerPoint.Left
    End Sub
    Private Sub cmdTimerPoint_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdTimerPoint.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim x As Integer = Windows.Forms.Cursor.Position.X - MousePositionX + preTimePoint
            If x < -10 Then x = -10
            If x > pnlTimerLine.Width - 10 Then x = pnlTimerLine.Width - 10
            cmdTimerPoint.Left = x

            TimePoint = TimeWidth * (x + 10) \ pnlTimerLine.Width

            RenderFrame()
        End If
    End Sub

    Private Sub pnlFrame_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlFrame.MouseDown
        MousePositionX = Windows.Forms.Cursor.Position.X
        MousePositionY = Windows.Forms.Cursor.Position.Y
        PreOffSet = OffSet
    End Sub
    Private Sub pnlFrame_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlFrame.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Middle Then
            OffSet = New Point(Windows.Forms.Cursor.Position.X - MousePositionX + PreOffSet.X, Windows.Forms.Cursor.Position.Y - MousePositionY + PreOffSet.Y)
            RenderFrame()
        End If
    End Sub

    Private Sub cmdPreFrame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPreFrame.Click
        If TimePoint > 0 Then
            TimePoint -= 1
            cmdTimerPoint.Left = pnlTimerLine.Width * TimePoint \ TimeWidth - 10
            RenderFrame()
        End If
    End Sub
    Private Sub cmdNextFrame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNextFrame.Click
        If TimePoint < TimeWidth Then
            TimePoint += 1
            cmdTimerPoint.Left = pnlTimerLine.Width * TimePoint \ TimeWidth - 10
            RenderFrame()
        End If
    End Sub

    Private Sub cmdTimerPoint_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdTimerPoint.MouseWheel
        If e.Delta > 0 Then
            If TimePoint < TimeWidth Then TimePoint += 1
        Else
            If TimePoint > 0 Then TimePoint -= 1
        End If
        cmdTimerPoint.Left = pnlTimerLine.Width * TimePoint \ TimeWidth - 10
        RenderFrame()
    End Sub
    Private Sub cmdTimerPoint_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdTimerPoint.MouseClick
        cmdTimerPoint.Focus()
    End Sub

    Private Sub pnlTimerLine_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTimerLine.MouseClick
        Dim preTime As Integer = TimePoint

        cmdTimerPoint.Focus()

        Dim x As Integer = e.X - 10
        If x < -10 Then x = -10
        If x > pnlTimerLine.Width - 10 Then x = pnlTimerLine.Width - 10
        cmdTimerPoint.Left = x

        TimePoint = TimeWidth * (x + 10) \ pnlTimerLine.Width

        If TimePoint <> preTime Then RenderFrame()
    End Sub

    Dim TimerLineRefreshCount As Byte = 0
    Dim preShotTime As Long
    Dim RefreshCounter As Byte = 0
    Private Sub tmrPlayer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayer.Tick
        If TimePoint < TimeWidth Then
            TimePoint += 1

            TimerLineRefreshCount += 1
            If TimerLineRefreshCount > 2 Then
                cmdTimerPoint.Left = pnlTimerLine.Width * TimePoint \ TimeWidth - 10
                TimerLineRefreshCount = 0
            End If

            RenderFrame()

            If RefreshCounter > 5 Then
                Dim x As Long = Now.Ticks - preShotTime
                txtFPS.Text = (10000000 \ x) & " fps"
                RefreshCounter = 0
            End If
            RefreshCounter += 1
            preShotTime = Now.Ticks
        Else
            StopAnime()
        End If
    End Sub

    Private Sub cmdPlay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPlay.Click
        If TimePoint = TimeWidth Then TimePoint = 0

        preShotTime = Now.Ticks

        If tmrPlayer.Enabled Then
            StopAnime()
        Else
            PlayAnime()
        End If
    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomInToolStripMenuItem.Click
        If Zoom > 0.0625 Then
            Zoom /= 2
            RenderFrame()
        End If
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomOutToolStripMenuItem.Click
        If Zoom < 4 Then
            Zoom *= 2
            RenderFrame()
        End If
    End Sub

    Private Sub ResetZoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetZoomToolStripMenuItem.Click
        If Zoom <> 1 Then Zoom = 1
        RenderFrame()
    End Sub

    Private Sub ResetOffsetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetOffsetToolStripMenuItem.Click
        OffSet = New Point(0, 0)
        RenderFrame()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        cmdPlay_Click(sender, e)
    End Sub

    Private Sub NextFrameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextFrameToolStripMenuItem.Click
        cmdNextFrame_Click(sender, e)
    End Sub
    Private Sub PreviousFrameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousFrameToolStripMenuItem.Click
        cmdPreFrame_Click(sender, e)
    End Sub

    Private Sub FrameRateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrameRateToolStripMenuItem.Click
        ValueDialog("Frames Rate", FPS, 1, 120)
        tmrPlayer.Interval = 1000 \ FPS
    End Sub

    Private Sub FinalPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalPreviewToolStripMenuItem.Click
        FinalPreview()
    End Sub

End Class

Public Class TimeLineItem
    Public MaxWidth, StartGen, StopGen As Integer

    Public pnlItem As New Panel
    Dim lblTitle As New Label
    Dim WithEvents pnlTime As New Panel

    Dim Color As Color = Drawing.Color.Blue

    Sub pnlTime_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlTime.Paint
        e.Graphics.DrawLine(New Pen(Color, 8), pnlTime.Width * StartGen \ MaxWidth, 8, pnlTime.Width * StopGen \ MaxWidth, 8)
    End Sub

    Public Sub New(ByVal Title As String, ByVal MaxWidth As Integer, ByVal StartGen As Integer, ByVal StopGen As Integer, ByVal Color As Color)
        pnlItem.Dock = DockStyle.Top
        pnlItem.Height = 16
        pnlItem.BackgroundImageLayout = ImageLayout.Stretch
        'pnlItem.BackgroundImage = My.Resources.ItemBG

        lblTitle.AutoSize = False
        lblTitle.Width = 126
        lblTitle.Text = Title
        lblTitle.Dock = DockStyle.Left
        lblTitle.Padding = New Padding(8, 2, 2, 2)
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        lblTitle.BackgroundImageLayout = ImageLayout.Stretch
        lblTitle.BackgroundImage = My.Resources.ItemBG
        'lblTitle.BackColor = Color.Transparent

        pnlTime.Dock = DockStyle.Fill
        pnlTime.BackgroundImage = My.Resources.ItemBG
        pnlTime.BackgroundImageLayout = ImageLayout.Stretch

        Dim S1, S2 As New Panel
        S1.Dock = DockStyle.Left
        S2.Dock = DockStyle.Left
        S1.Width = 1
        S2.Width = 1
        S1.BackColor = Color.FromArgb(64, 64, 64)
        S2.BackColor = Color.FromArgb(128, 128, 128)

        pnlItem.Controls.Add(pnlTime)
        pnlItem.Controls.Add(S2)
        pnlItem.Controls.Add(S1)
        pnlItem.Controls.Add(lblTitle)

        Me.MaxWidth = MaxWidth
        Me.StartGen = StartGen
        Me.StopGen = StopGen
        Me.Color = Color
    End Sub

End Class