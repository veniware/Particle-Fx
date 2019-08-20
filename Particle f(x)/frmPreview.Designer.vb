<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlTimerList = New System.Windows.Forms.Panel()
        Me.pnlTimerLineBG = New System.Windows.Forms.Panel()
        Me.pnlTimerLine = New System.Windows.Forms.Panel()
        Me.cmdTimerPoint = New System.Windows.Forms.Panel()
        Me.S2 = New System.Windows.Forms.Panel()
        Me.S1 = New System.Windows.Forms.Panel()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.cmdNextFrame = New System.Windows.Forms.Panel()
        Me.cmdPreFrame = New System.Windows.Forms.Panel()
        Me.cmdPlay = New System.Windows.Forms.Panel()
        Me.tmrPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFrame = New System.Windows.Forms.Panel()
        Me.pnlResize = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetOffsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NextFrameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousFrameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FrameRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtFPS = New System.Windows.Forms.ToolStripTextBox()
        Me.txtParticlesCounter = New System.Windows.Forms.ToolStripTextBox()
        Me.RenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBottom.SuspendLayout()
        Me.pnlTimerLineBG.SuspendLayout()
        Me.pnlTimerLine.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.pnlFrame.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.DimGray
        Me.pnlBottom.Controls.Add(Me.pnlTimerList)
        Me.pnlBottom.Controls.Add(Me.pnlTimerLineBG)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 482)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1264, 200)
        Me.pnlBottom.TabIndex = 0
        '
        'pnlTimerList
        '
        Me.pnlTimerList.AutoScroll = True
        Me.pnlTimerList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTimerList.Location = New System.Drawing.Point(0, 32)
        Me.pnlTimerList.Name = "pnlTimerList"
        Me.pnlTimerList.Size = New System.Drawing.Size(1264, 168)
        Me.pnlTimerList.TabIndex = 1
        '
        'pnlTimerLineBG
        '
        Me.pnlTimerLineBG.BackgroundImage = Global.ParticleFX.My.Resources.Resources.BlackBar
        Me.pnlTimerLineBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTimerLineBG.Controls.Add(Me.pnlTimerLine)
        Me.pnlTimerLineBG.Controls.Add(Me.S2)
        Me.pnlTimerLineBG.Controls.Add(Me.S1)
        Me.pnlTimerLineBG.Controls.Add(Me.pnlControls)
        Me.pnlTimerLineBG.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTimerLineBG.Location = New System.Drawing.Point(0, 0)
        Me.pnlTimerLineBG.Name = "pnlTimerLineBG"
        Me.pnlTimerLineBG.Size = New System.Drawing.Size(1264, 32)
        Me.pnlTimerLineBG.TabIndex = 0
        '
        'pnlTimerLine
        '
        Me.pnlTimerLine.Controls.Add(Me.cmdTimerPoint)
        Me.pnlTimerLine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTimerLine.Location = New System.Drawing.Point(128, 0)
        Me.pnlTimerLine.Name = "pnlTimerLine"
        Me.pnlTimerLine.Size = New System.Drawing.Size(1136, 32)
        Me.pnlTimerLine.TabIndex = 3
        '
        'cmdTimerPoint
        '
        Me.cmdTimerPoint.BackColor = System.Drawing.Color.Transparent
        Me.cmdTimerPoint.BackgroundImage = Global.ParticleFX.My.Resources.Resources.TimePoint
        Me.cmdTimerPoint.Location = New System.Drawing.Point(-10, 16)
        Me.cmdTimerPoint.Name = "cmdTimerPoint"
        Me.cmdTimerPoint.Size = New System.Drawing.Size(20, 13)
        Me.cmdTimerPoint.TabIndex = 0
        '
        'S2
        '
        Me.S2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.S2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S2.Dock = System.Windows.Forms.DockStyle.Left
        Me.S2.Location = New System.Drawing.Point(127, 0)
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(1, 32)
        Me.S2.TabIndex = 2
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.S1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.S1.Dock = System.Windows.Forms.DockStyle.Left
        Me.S1.Location = New System.Drawing.Point(126, 0)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(1, 32)
        Me.S1.TabIndex = 1
        '
        'pnlControls
        '
        Me.pnlControls.BackgroundImage = Global.ParticleFX.My.Resources.Resources.BlackBar
        Me.pnlControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlControls.Controls.Add(Me.cmdNextFrame)
        Me.pnlControls.Controls.Add(Me.cmdPreFrame)
        Me.pnlControls.Controls.Add(Me.cmdPlay)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(126, 32)
        Me.pnlControls.TabIndex = 0
        '
        'cmdNextFrame
        '
        Me.cmdNextFrame.BackColor = System.Drawing.Color.Transparent
        Me.cmdNextFrame.BackgroundImage = Global.ParticleFX.My.Resources.Resources.NextFrame
        Me.cmdNextFrame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNextFrame.Location = New System.Drawing.Point(84, 6)
        Me.cmdNextFrame.Name = "cmdNextFrame"
        Me.cmdNextFrame.Size = New System.Drawing.Size(20, 20)
        Me.cmdNextFrame.TabIndex = 4
        '
        'cmdPreFrame
        '
        Me.cmdPreFrame.BackColor = System.Drawing.Color.Transparent
        Me.cmdPreFrame.BackgroundImage = Global.ParticleFX.My.Resources.Resources.PreFrame
        Me.cmdPreFrame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPreFrame.Location = New System.Drawing.Point(61, 6)
        Me.cmdPreFrame.Name = "cmdPreFrame"
        Me.cmdPreFrame.Size = New System.Drawing.Size(20, 20)
        Me.cmdPreFrame.TabIndex = 5
        '
        'cmdPlay
        '
        Me.cmdPlay.BackColor = System.Drawing.Color.Transparent
        Me.cmdPlay.BackgroundImage = Global.ParticleFX.My.Resources.Resources.Play
        Me.cmdPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPlay.Location = New System.Drawing.Point(23, 6)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(20, 20)
        Me.cmdPlay.TabIndex = 3
        '
        'tmrPlayer
        '
        Me.tmrPlayer.Interval = 33
        '
        'pnlFrame
        '
        Me.pnlFrame.BackColor = System.Drawing.Color.Gray
        Me.pnlFrame.Controls.Add(Me.pnlResize)
        Me.pnlFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrame.Location = New System.Drawing.Point(0, 24)
        Me.pnlFrame.Name = "pnlFrame"
        Me.pnlFrame.Size = New System.Drawing.Size(1264, 458)
        Me.pnlFrame.TabIndex = 1
        '
        'pnlResize
        '
        Me.pnlResize.BackgroundImage = Global.ParticleFX.My.Resources.Resources.BlackBar
        Me.pnlResize.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.pnlResize.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlResize.Location = New System.Drawing.Point(0, 454)
        Me.pnlResize.Name = "pnlResize"
        Me.pnlResize.Size = New System.Drawing.Size(1264, 4)
        Me.pnlResize.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DimGray
        Me.MenuStrip1.BackgroundImage = Global.ParticleFX.My.Resources.Resources.MainMenuhigh
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.ControlToolStripMenuItem, Me.txtFPS, Me.txtParticlesCounter, Me.RenderToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 2, 4, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomInToolStripMenuItem, Me.ZoomOutToolStripMenuItem, Me.ResetZoomToolStripMenuItem, Me.ToolStripMenuItem2, Me.ResetOffsetToolStripMenuItem})
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ZoomInToolStripMenuItem
        '
        Me.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        Me.ZoomInToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus), System.Windows.Forms.Keys)
        Me.ZoomInToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ZoomInToolStripMenuItem.Text = "Zoom in"
        '
        'ZoomOutToolStripMenuItem
        '
        Me.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        Me.ZoomOutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.OemMinus), System.Windows.Forms.Keys)
        Me.ZoomOutToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ZoomOutToolStripMenuItem.Text = "Zoom out"
        '
        'ResetZoomToolStripMenuItem
        '
        Me.ResetZoomToolStripMenuItem.Name = "ResetZoomToolStripMenuItem"
        Me.ResetZoomToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.ResetZoomToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ResetZoomToolStripMenuItem.Text = "Reset zoom"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(217, 6)
        '
        'ResetOffsetToolStripMenuItem
        '
        Me.ResetOffsetToolStripMenuItem.Name = "ResetOffsetToolStripMenuItem"
        Me.ResetOffsetToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ResetOffsetToolStripMenuItem.Text = "Reset offset"
        '
        'ControlToolStripMenuItem
        '
        Me.ControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.ToolStripMenuItem1, Me.NextFrameToolStripMenuItem, Me.PreviousFrameToolStripMenuItem, Me.ToolStripMenuItem3, Me.FrameRateToolStripMenuItem})
        Me.ControlToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ControlToolStripMenuItem.Name = "ControlToolStripMenuItem"
        Me.ControlToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ControlToolStripMenuItem.Text = "Control"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Space), System.Windows.Forms.Keys)
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.PlayToolStripMenuItem.Text = "Play/Pause"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(200, 6)
        '
        'NextFrameToolStripMenuItem
        '
        Me.NextFrameToolStripMenuItem.Name = "NextFrameToolStripMenuItem"
        Me.NextFrameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.NextFrameToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.NextFrameToolStripMenuItem.Text = "Next frame"
        '
        'PreviousFrameToolStripMenuItem
        '
        Me.PreviousFrameToolStripMenuItem.Name = "PreviousFrameToolStripMenuItem"
        Me.PreviousFrameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.PreviousFrameToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.PreviousFrameToolStripMenuItem.Text = "Previous frame"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(200, 6)
        '
        'FrameRateToolStripMenuItem
        '
        Me.FrameRateToolStripMenuItem.Name = "FrameRateToolStripMenuItem"
        Me.FrameRateToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.FrameRateToolStripMenuItem.Text = "Frames rate"
        '
        'txtFPS
        '
        Me.txtFPS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtFPS.BackColor = System.Drawing.Color.DimGray
        Me.txtFPS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFPS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFPS.Name = "txtFPS"
        Me.txtFPS.ReadOnly = True
        Me.txtFPS.Size = New System.Drawing.Size(75, 20)
        Me.txtFPS.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtParticlesCounter
        '
        Me.txtParticlesCounter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtParticlesCounter.BackColor = System.Drawing.Color.DimGray
        Me.txtParticlesCounter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtParticlesCounter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtParticlesCounter.Name = "txtParticlesCounter"
        Me.txtParticlesCounter.ReadOnly = True
        Me.txtParticlesCounter.Size = New System.Drawing.Size(75, 20)
        Me.txtParticlesCounter.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RenderToolStripMenuItem
        '
        Me.RenderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinalPreviewToolStripMenuItem})
        Me.RenderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RenderToolStripMenuItem.Name = "RenderToolStripMenuItem"
        Me.RenderToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.RenderToolStripMenuItem.Text = "Render"
        '
        'FinalPreviewToolStripMenuItem
        '
        Me.FinalPreviewToolStripMenuItem.Name = "FinalPreviewToolStripMenuItem"
        Me.FinalPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.FinalPreviewToolStripMenuItem.Text = "Final preview"
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.pnlFrame)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(720, 480)
        Me.Name = "frmPreview"
        Me.Text = "Preview animation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlTimerLineBG.ResumeLayout(False)
        Me.pnlTimerLine.ResumeLayout(False)
        Me.pnlControls.ResumeLayout(False)
        Me.pnlFrame.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlFrame As System.Windows.Forms.Panel
    Friend WithEvents pnlResize As System.Windows.Forms.Panel
    Friend WithEvents pnlTimerLineBG As System.Windows.Forms.Panel
    Friend WithEvents pnlTimerLine As System.Windows.Forms.Panel
    Friend WithEvents cmdTimerPoint As System.Windows.Forms.Panel
    Friend WithEvents S2 As System.Windows.Forms.Panel
    Friend WithEvents S1 As System.Windows.Forms.Panel
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents cmdNextFrame As System.Windows.Forms.Panel
    Friend WithEvents cmdPreFrame As System.Windows.Forms.Panel
    Friend WithEvents cmdPlay As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents tmrPlayer As System.Windows.Forms.Timer
    Friend WithEvents pnlTimerList As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NextFrameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviousFrameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetOffsetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtFPS As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FrameRateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtParticlesCounter As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
