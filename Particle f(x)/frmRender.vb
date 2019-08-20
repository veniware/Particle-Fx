Public Class frmRender

    Public Sub New()
        InitializeComponent()
        Me.Height = 640
        ResizeMainList()

        FramesH = pnlFrames.Height
        EnvironmentH = pnlEnvironment.Height
        ParticlesH = pnlParticles.Height
        ReactH = pnlReact.Height

        Dim Selected As Integer = cmbCamera.SelectedIndex
        If Engine.Cameras.Count > 0 Then
            For Each cam As Engine.Camera In Engine.Cameras
                cmbCamera.Items.Add(cam.name)
            Next
            cmbCamera.SelectedIndex = 0
        End If
        If (Not Selected > cmbCamera.Items.Count) And Selected > -1 Then cmbCamera.SelectedIndex = Selected

        'cmbCamera.SelectedIndex = _CameraIndex
        txtFrom.Value = _FrameRangeFrom
        txtTo.Value = _FrameRangeTo
        txtFPS.Value = _FPS
        Select Case _PixelFormat
            'Case Imaging.PixelFormat.Format24bppRgb : cmbPixelFormat.SelectedIndex = 0
            Case Imaging.PixelFormat.Format32bppRgb : cmbPixelFormat.SelectedIndex = 1
            Case Imaging.PixelFormat.Format48bppRgb : cmbPixelFormat.SelectedIndex = 2
            Case Imaging.PixelFormat.Format16bppArgb1555 : cmbPixelFormat.SelectedIndex = 3
            Case Imaging.PixelFormat.Format32bppArgb : cmbPixelFormat.SelectedIndex = 4
            Case Imaging.PixelFormat.Format64bppArgb : cmbPixelFormat.SelectedIndex = 5
            Case Imaging.PixelFormat.Format32bppPArgb : cmbPixelFormat.SelectedIndex = 6
            Case Imaging.PixelFormat.Format64bppPArgb : cmbPixelFormat.SelectedIndex = 7
            Case Else : cmbPixelFormat.SelectedIndex = 0
        End Select
        cmbImageFormat.SelectedIndex = _ImageFormatIndex
        Select Case _Smoothing
            Case Drawing2D.SmoothingMode.AntiAlias : cmbSmoothing.SelectedIndex = 1
            Case Drawing2D.SmoothingMode.HighSpeed : cmbSmoothing.SelectedIndex = 2
            Case Drawing2D.SmoothingMode.HighSpeed : cmbSmoothing.SelectedIndex = 3
            Case Drawing2D.SmoothingMode.None : cmbSmoothing.SelectedIndex = 0
        End Select

        txtLocation.Text = _ExportPath
        chkSkipExisting.Checked = _SkipExistingFrames

        optTransparentBG.Checked = _BGTransparent
        optSolidBG.Checked = _BGSolid
        optImageBG.Checked = _BGFile
        cmdSolidBG.BackColor = _BGColor
        txtImageBG.Text = _BGFilePath
        chkDrawGens.Checked = _DrawGens
        chkDrawStatic.Checked = _DrawStatic

        chkColor.Checked = _GlobalColor
        cmdColor.BackColor = _GlobalColorValue
        txtColorOpacity.Value = _GlobalColorOpacity
        chkGlossiness.Checked = _SpecHighlights
        cmdGlossColor.BackColor = _GlossColor
        txtSpecLevel.Value = _SpecLevel
        txtGlossiness.Value = _Glossiness
        '_SpecHighlightsX
        '_SpecHighlightsY
        chkGlow.Checked = _Glow
        cmdGlowColor.BackColor = _GlowColor
        txtGlowOpacity.Value = _GlowOpacity
        chkMotionBlur.Checked = _MotionBlur
        txtMotionBlurSamples.Value = _MotionBlurSamples
        optSolidColor.Checked = _ParticlesSolidColor
        optReflect.Checked = _ParticleReflect
        txtReflectOpacity.Value = _ParticleReflectOpacity
        optRefract.Checked = _ParticleRefract
        txtRefractOpacity.Value = _ParticleRefractOpacity
        txtIOR.Value = _ParticleRefractIOR
        cmdExitColor.BackColor = _ParticleExitColor

        cmbReactor.SelectedIndex = _ReactorIndex
        txtGForce.Value = _G
        chkReactEachOther.Checked = _ParticlesReactEachOther

    End Sub

    Private Sub ScrollList(Optional ByVal Value As Short = 0)
        Dim Y As Integer = cmdScroll.Top + Value
        If Y < 0 Then Y = 0
        If Y > pnlMainScroll.Height - cmdScroll.Height Then Y = pnlMainScroll.Height - cmdScroll.Height
        cmdScroll.Top = Y

        If pnlMainList.Height > pnlMain.Height Then
            pnlMainList.Top = (-pnlMainList.Height + pnlMain.Height) * (cmdScroll.Top / (pnlMainScroll.Height - cmdScroll.Height))
        Else
            pnlMainList.Top = 0
        End If
    End Sub

    Public Sub ResizeMainList()
        Dim h As Integer = 0
        For i As Integer = 0 To pnlMainList.Controls.Count - 1
            h += pnlMainList.Controls(i).Height
        Next
        pnlMainList.Height = h

        If pnlMainList.Height > pnlMain.Height Then
            pnlMainList.Top = (-pnlMainList.Height + pnlMain.Height) * (cmdScroll.Top / (pnlMainScroll.Height - cmdScroll.Height))
        Else
            pnlMainList.Top = 0
            cmdScroll.Top = 0
        End If
    End Sub

    Private Sub cmdScrollUp_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdScrollUp.MouseEnter
        cmdScrollUp.BackgroundImage = My.Resources.SrollButtonBG
    End Sub
    Private Sub cmdScrollUp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdScrollUp.MouseLeave
        cmdScrollUp.BackgroundImage = My.Resources.ScrollBG
    End Sub

    Private Sub cmdScrollDown_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdScrollDown.MouseEnter
        cmdScrollDown.BackgroundImage = My.Resources.SrollButtonBG
    End Sub
    Private Sub cmdScrollDown_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdScrollDown.MouseLeave
        cmdScrollDown.BackgroundImage = My.Resources.ScrollBG
    End Sub

    Dim MouseY As Integer
    Private Sub cmdScroll_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdScroll.MouseDown
        cmdScroll.Focus()
        MouseY = System.Windows.Forms.Cursor.Position.Y - cmdScroll.Top
    End Sub
    Private Sub cmdScroll_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdScroll.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim Y As Integer = System.Windows.Forms.Cursor.Position.Y - MouseY
            If Y < 0 Then Y = 0
            If Y > pnlMainScroll.Height - cmdScroll.Height Then Y = pnlMainScroll.Height - cmdScroll.Height
            cmdScroll.Top = Y

            If pnlMainList.Height > pnlMain.Height Then
                pnlMainList.Top = (-pnlMainList.Height + pnlMain.Height) * (cmdScroll.Top / (pnlMainScroll.Height - cmdScroll.Height))
            Else
                pnlMainList.Top = 0
            End If
        End If
    End Sub

    Private Sub cmdScroll_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdScroll.MouseWheel
        ScrollList(-e.Delta \ 3)
    End Sub
    Private Sub cmdScrollUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScrollUp.Click
        ScrollList(-pnlMainScroll.Height \ 10)
    End Sub
    Private Sub cmdScrollDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScrollDown.Click
        ScrollList(+pnlMainScroll.Height \ 10)
    End Sub

    Dim ScrollLight As Boolean
    Private Sub cmdScroll_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdScroll.MouseEnter
        ScrollLight = True
        cmdScroll.Refresh()
    End Sub
    Private Sub cmdScroll_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdScroll.MouseLeave
        ScrollLight = False
        cmdScroll.Refresh()
    End Sub
    Private Sub cmdScroll_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles cmdScroll.Paint
        If ScrollLight Then e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(32, 255, 255, 255)), 2, 2, cmdScroll.Width - 4, cmdScroll.Height - 4)
    End Sub

    Public FramesH As Integer
    Public EnvironmentH As Integer
    Public ParticlesH As Integer
    Public ReactH As Integer

    Private Sub pnlFramesTitle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlFramesTitle.DoubleClick
        If pnlFrames.Height = 20 Then
            pnlFrames.Height = FramesH
        Else
            FramesH = pnlFrames.Height
            pnlFrames.Height = 20
        End If
        ResizeMainList()
    End Sub
    Private Sub pnlEnvironmentTitle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlEnvironmentTitle.DoubleClick
        If pnlEnvironment.Height = 20 Then
            pnlEnvironment.Height = EnvironmentH
        Else
            EnvironmentH = pnlEnvironment.Height
            pnlEnvironment.Height = 20
        End If
        ResizeMainList()
    End Sub
    Private Sub pnlParticlesTitle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlParticlesTitle.DoubleClick
        If pnlParticles.Height = 20 Then
            pnlParticles.Height = ParticlesH
        Else
            ParticlesH = pnlParticles.Height
            pnlParticles.Height = 20
        End If
        ResizeMainList()
    End Sub
    Private Sub pnlReactTitle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlReactTitle.DoubleClick
        If pnlReact.Height = 20 Then
            pnlReact.Height = ReactH
        Else
            ReactH = pnlReact.Height
            pnlReact.Height = 20
        End If
        ResizeMainList()
    End Sub

    Private Sub pnlFramesTitle_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlFramesTitle.Paint
        e.Graphics.DrawString("Freams", Me.Font, New SolidBrush(Me.ForeColor), 2, 2)
    End Sub
    Private Sub pnlEnvironmentTitle_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlEnvironmentTitle.Paint
        e.Graphics.DrawString("Environment", Me.Font, New SolidBrush(Me.ForeColor), 2, 2)
    End Sub
    Private Sub pnlParticlesTitle_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlParticlesTitle.Paint
        e.Graphics.DrawString("Particles", Me.Font, New SolidBrush(Me.ForeColor), 2, 2)
    End Sub
    Private Sub pnlReactTitle_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlReactTitle.Paint
        e.Graphics.DrawString("Reacting", Me.Font, New SolidBrush(Me.ForeColor), 2, 2)
    End Sub

    Private Sub cmbCamera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCamera.SelectedIndexChanged
        If cmbCamera.SelectedIndex = -1 Then
            lblCameraSize.Text = Nothing
        Else
            lblCameraSize.Text = Engine.Cameras(cmbCamera.SelectedIndex).Widht & " x " & Engine.Cameras(cmbCamera.SelectedIndex).Height
        End If
    End Sub

    Private Sub txtFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFrom.ValueChanged
        If Not txtFrom.Focused Then Exit Sub

        If txtTo.Value < txtFrom.Value Then txtTo.Value = txtFrom.Value

        Dim total As Integer = txtTo.Value - txtFrom.Value + 1
        If total = 1 Then
            lblTotalFrames.Text = txtTo.Value - txtFrom.Value + 1 & " frame"
        Else
            lblTotalFrames.Text = txtTo.Value - txtFrom.Value + 1 & " frames"
        End If

        lblTotalSec.Text = Math.Round((txtTo.Value - txtFrom.Value + 1) / txtFPS.Value, 2) & " sec."
    End Sub
    Private Sub txtTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTo.ValueChanged
        If Not txtTo.Focused Then Exit Sub

        If txtFrom.Value > txtTo.Value Then txtFrom.Value = txtTo.Value

        Dim total As Integer = txtTo.Value - txtFrom.Value + 1
        If total = 1 Then
            lblTotalFrames.Text = txtTo.Value - txtFrom.Value + 1 & " frame"
        Else
            lblTotalFrames.Text = txtTo.Value - txtFrom.Value + 1 & " frames"
        End If

        lblTotalSec.Text = Math.Round((txtTo.Value - txtFrom.Value + 1) / txtFPS.Value, 2) & " sec."
    End Sub

    Private Sub txtFPS_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFPS.ValueChanged
        lblTotalSec.Text = Math.Round((txtTo.Value - txtFrom.Value + 1) / txtFPS.Value, 2) & " sec."
    End Sub

    Private Sub cmbPixelFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPixelFormat.SelectedIndexChanged
        If cmbPixelFormat.SelectedIndex < 3 Then
            lblNotRecommended.Show()
        Else
            lblNotRecommended.Hide()
        End If
    End Sub

    Private Sub cmdBrowseLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseLocation.Click
        Dim frmFolder As New FolderBrowserDialog
        frmFolder.SelectedPath = txtLocation.Text
        If frmFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLocation.Text = frmFolder.SelectedPath
        End If
    End Sub
    Private Sub cmdColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdColor.Click
        Dim frmColor As New ColorDialog
        frmColor.Color = cmdColor.BackColor
        If frmColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            cmdColor.BackColor = frmColor.Color
        End If
    End Sub
    Private Sub cmdGlowColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGlowColor.Click
        Dim frmColor As New ColorDialog
        frmColor.Color = cmdGlowColor.BackColor
        If frmColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            cmdGlowColor.BackColor = frmColor.Color
        End If
    End Sub
    Private Sub cmdExitColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExitColor.Click
        Dim frmColor As New ColorDialog
        frmColor.Color = cmdExitColor.BackColor
        If frmColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            cmdExitColor.BackColor = frmColor.Color
        End If
    End Sub

    Private Sub optSolidBG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSolidBG.CheckedChanged
        cmdSolidBG.Visible = optSolidBG.Checked
    End Sub
    Private Sub optImageBG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optImageBG.CheckedChanged
        txtImageBG.Visible = optImageBG.Checked
        cmdImageBG.Visible = optImageBG.Checked

        If optImageBG.Checked And _BGFilePath = Nothing Then cmdImageBG_Click(sender, e)
    End Sub

    Private Sub cmdSolidBG_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSolidBG.Click
        Dim frmColor As New ColorDialog
        frmColor.Color = cmdSolidBG.BackColor
        If frmColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            cmdSolidBG.BackColor = frmColor.Color
        End If
    End Sub

    Private Sub cmdGlossColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGlossColor.Click
        Dim frmColor As New ColorDialog
        frmColor.Color = cmdGlossColor.BackColor
        If frmColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            cmdGlossColor.BackColor = frmColor.Color
        End If
    End Sub

    Private Sub cmdImageBG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImageBG.Click
        Dim frmImage As New OpenFileDialog
        frmImage.FileName = txtImageBG.Text
        frmImage.Filter = "All Images|*.bmp;*.dib;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.tiff;*.png|" & _
                        "Portable Network Graphics (*.png)|*.png|" & _
                        "Tagged Image File Format (*.tif;*.tiff)|*.tif;*.tiff|" & _
                        "Device Independent Bitmap|*.bmp;*.dib|" & _
                        "Joint Photographic Experts Group (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|" & _
                        "Graphics Interchange Format (*.gif)|*.gif|" & _
                        "All Files (*.*)|*.*"

        If frmImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtImageBG.Text = frmImage.FileName
        End If
        frmImage.Dispose()
    End Sub

    Private Sub cmdPreviewGloss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreviewGloss.Click
        Dim frmPreview As New frmSpecularHighlights
        frmPreview.txtGlossiness.SetValue(txtGlossiness.Value)
        frmPreview.txtSpecLevel.SetValue(txtSpecLevel.Value)
        frmPreview.txtX.SetValue(_SpecHighlightsX)
        frmPreview.txtY.SetValue(_SpecHighlightsY)
        If frmPreview.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtGlossiness.Value = frmPreview.txtGlossiness.Value
            txtSpecLevel.Value = frmPreview.txtSpecLevel.Value
            _SpecHighlightsX = frmPreview.txtX.Value
            _SpecHighlightsY = frmPreview.txtY.Value
        End If
    End Sub

    Private Sub cmdIOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIOR.Click
        Dim frmIOR As New frmIORdb
        frmIOR.Icon = Me.Icon
        If frmIOR.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtIOR.Value = frmIOR.db(frmIOR.lstView.SelectedIndex).index
        End If
        frmIOR.Dispose()
    End Sub

    Private Sub chkColor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkColor.CheckedChanged
        pnlParticlesColor.Enabled = chkColor.Checked
    End Sub
    Private Sub chkGlossiness_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGlossiness.CheckedChanged
        pnlGlossiness.Enabled = chkGlossiness.Checked
    End Sub
    Private Sub chkGlow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGlow.CheckedChanged
        pnlParticlesGlow.Enabled = chkGlow.Checked
    End Sub
    Private Sub chkMotionBlur_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMotionBlur.CheckedChanged
        pnlParticlesMotionBlur.Enabled = chkMotionBlur.Checked
    End Sub
    Private Sub optReflect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optReflect.CheckedChanged
        pnlParticlesReflection.Enabled = optReflect.Checked
        If optSolidColor.Checked Then
            lblExitColor.Enabled = False
            cmdExitColor.Enabled = False
        Else
            lblExitColor.Enabled = True
            cmdExitColor.Enabled = True
        End If
    End Sub
    Private Sub optRefract_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optRefract.CheckedChanged
        pnlParticlesRefraction.Enabled = optRefract.Checked
        If optSolidColor.Checked Then
            lblExitColor.Enabled = False
            cmdExitColor.Enabled = False
        Else
            lblExitColor.Enabled = True
            cmdExitColor.Enabled = True
        End If
    End Sub

    Private Sub cmbReactor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReactor.SelectedIndexChanged
        If cmbReactor.SelectedIndex = 1 Then
            chkReactEachOther.Enabled = True
        Else
            chkReactEachOther.Enabled = False
        End If
    End Sub

    Private Sub txtGForce_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGForce.ValueChanged
        Engine._G = txtGForce.Value
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If Apply() Then Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        Apply()
    End Sub

    Function Apply() As Boolean
        If txtLocation.Text = "" Then
            MessageBox("Export location can't be nothing", "No expor location")
            Return False
        End If

        _CameraIndex = cmbCamera.SelectedIndex
        _FrameRangeFrom = txtFrom.Value
        _FrameRangeTo = txtTo.Value
        _FPS = txtFPS.Value
        Select Case cmbPixelFormat.SelectedIndex
            'Case 0 : _PixelFormat = Imaging.PixelFormat.Format24bppRgb
            Case 1 : _PixelFormat = Imaging.PixelFormat.Format32bppRgb
            Case 2 : _PixelFormat = Imaging.PixelFormat.Format48bppRgb
            Case 3 : _PixelFormat = Imaging.PixelFormat.Format16bppArgb1555
            Case 4 : _PixelFormat = Imaging.PixelFormat.Format32bppArgb
            Case 5 : _PixelFormat = Imaging.PixelFormat.Format64bppArgb
            Case 6 : _PixelFormat = Imaging.PixelFormat.Format32bppPArgb
            Case 7 : _PixelFormat = Imaging.PixelFormat.Format64bppPArgb
            Case Else : _PixelFormat = Imaging.PixelFormat.Format24bppRgb
        End Select
        Select Case cmbImageFormat.SelectedIndex
            'Case 0: imgFormat = Imaging.ImageFormat.Png
            Case 1 : _ImageFormat = Imaging.ImageFormat.Tiff
            Case 2 : _ImageFormat = Imaging.ImageFormat.Bmp
            Case 3 : _ImageFormat = Imaging.ImageFormat.Jpeg
            Case 4 : _ImageFormat = Imaging.ImageFormat.Gif
            Case Else : _ImageFormat = Imaging.ImageFormat.Png
        End Select
        _ImageFormatIndex = cmbImageFormat.SelectedIndex
        Select Case cmbSmoothing.SelectedIndex
            'Case 0 : Smoothing = Drawing2D.SmoothingMode.None
            Case 1 : _Smoothing = Drawing2D.SmoothingMode.AntiAlias
            Case 2 : _Smoothing = Drawing2D.SmoothingMode.HighSpeed
            Case 3 : _Smoothing = Drawing2D.SmoothingMode.HighQuality
            Case Else : _Smoothing = Drawing2D.SmoothingMode.None
        End Select
        _ExportPath = txtLocation.Text
        _SkipExistingFrames = chkSkipExisting.Checked

        _BGTransparent = optTransparentBG.Checked
        _BGSolid = optSolidBG.Checked
        _BGFile = optImageBG.Checked
        _BGColor = cmdSolidBG.BackColor
        _BGFilePath = txtImageBG.Text
        _DrawGens = chkDrawGens.Checked
        _DrawStatic = chkDrawStatic.Checked

        _GlobalColor = chkColor.Checked
        _GlobalColorValue = cmdColor.BackColor
        _GlobalColorOpacity = txtColorOpacity.Value
        _SpecHighlights = chkGlossiness.Checked
        _GlossColor = cmdGlossColor.BackColor
        _SpecLevel = txtSpecLevel.Value
        _Glossiness = txtGlossiness.Value
        '_SpecHighlightsX
        '_SpecHighlightsY
        _Glow = chkGlow.Checked
        _GlowColor = cmdGlowColor.BackColor
        _GlowOpacity = txtGlowOpacity.Value
        _MotionBlur = chkMotionBlur.Checked
        _MotionBlurSamples = txtMotionBlurSamples.Value
        _ParticlesSolidColor = optSolidColor.Checked
        _ParticleReflect = optReflect.Checked
        _ParticleReflectOpacity = txtReflectOpacity.Value
        _ParticleRefract = optRefract.Checked
        _ParticleRefractOpacity = txtRefractOpacity.Value
        _ParticleRefractIOR = txtIOR.Value
        _ParticleExitColor = cmdExitColor.BackColor

        _ReactorIndex = cmbReactor.SelectedIndex
        _G = txtGForce.Value
        _ParticlesReactEachOther = chkReactEachOther.Checked

        Return True
    End Function
End Class