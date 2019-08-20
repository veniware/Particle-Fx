<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.lstObjects = New System.Windows.Forms.ListBox()
        Me.mnuObjects = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstParameters = New ParticleFX.ctrObjectsList()
        Me.pnlToolsSubLists = New System.Windows.Forms.Panel()
        Me.cmdLoadCams = New System.Windows.Forms.Panel()
        Me.cmdLoadDraws = New System.Windows.Forms.Panel()
        Me.cmdLoadForces = New System.Windows.Forms.Panel()
        Me.cmdLoadGens = New System.Windows.Forms.Panel()
        Me.pnlScroll2B = New System.Windows.Forms.Panel()
        Me.lstTools = New ParticleFX.ctrObjectsList()
        Me.pnlParameters = New System.Windows.Forms.Panel()
        Me.pnlBitmap = New System.Windows.Forms.Panel()
        Me.lblBitmap_t = New System.Windows.Forms.Label()
        Me.pnlColor = New System.Windows.Forms.Panel()
        Me.cmdColor = New System.Windows.Forms.Button()
        Me.lblColor_t = New System.Windows.Forms.Label()
        Me.pnlLife = New System.Windows.Forms.Panel()
        Me.lblLife_t = New System.Windows.Forms.Label()
        Me.pnlStop = New System.Windows.Forms.Panel()
        Me.lblStop_t = New System.Windows.Forms.Label()
        Me.pnlStart = New System.Windows.Forms.Panel()
        Me.lblStart_t = New System.Windows.Forms.Label()
        Me.pnlPPF = New System.Windows.Forms.Panel()
        Me.lblppf = New System.Windows.Forms.Label()
        Me.pnlF0 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblF0_t = New System.Windows.Forms.Label()
        Me.pnlR = New System.Windows.Forms.Panel()
        Me.lblR = New System.Windows.Forms.Label()
        Me.pnlNoice = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNoice_t = New System.Windows.Forms.Label()
        Me.pnlSlope = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSlope_t = New System.Windows.Forms.Label()
        Me.pnlHeight = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblHeight_t = New System.Windows.Forms.Label()
        Me.pnlWidth = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblWidth_t = New System.Windows.Forms.Label()
        Me.pnlY2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblY2 = New System.Windows.Forms.Label()
        Me.pnlX2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblX2 = New System.Windows.Forms.Label()
        Me.pnlY = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbly = New System.Windows.Forms.Label()
        Me.pnlX = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblx = New System.Windows.Forms.Label()
        Me.pnlName = New System.Windows.Forms.Panel()
        Me.lblName_t = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.mnuMainFrame = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetOffsetToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlNavigator = New System.Windows.Forms.Panel()
        Me.pnlRulerV = New System.Windows.Forms.Panel()
        Me.pnlRulerH = New System.Windows.Forms.Panel()
        Me.pnlCent = New System.Windows.Forms.Panel()
        Me.TipsInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrRamInfo = New System.Windows.Forms.Timer(Me.components)
        Me.pnlShortcutsBar = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlRamInfo = New System.Windows.Forms.Panel()
        Me.lblRamVi = New System.Windows.Forms.Label()
        Me.lblRamPh = New System.Windows.Forms.Label()
        Me.pnlViRam = New System.Windows.Forms.Panel()
        Me.pnlRamViT = New System.Windows.Forms.Panel()
        Me.pnlRamViP = New System.Windows.Forms.Panel()
        Me.pnlPhRam = New System.Windows.Forms.Panel()
        Me.pnlRamPhT = New System.Windows.Forms.Panel()
        Me.pnlRamPhP = New System.Windows.Forms.Panel()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetOffsetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShortcutsBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaticToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpaceWarpsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreviewAnimationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WaveformsEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarpMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FramesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvironmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParticlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlSide.SuspendLayout()
        Me.mnuObjects.SuspendLayout()
        Me.pnlToolsSubLists.SuspendLayout()
        Me.pnlParameters.SuspendLayout()
        Me.pnlBitmap.SuspendLayout()
        Me.pnlColor.SuspendLayout()
        Me.pnlLife.SuspendLayout()
        Me.pnlStop.SuspendLayout()
        Me.pnlStart.SuspendLayout()
        Me.pnlPPF.SuspendLayout()
        Me.pnlF0.SuspendLayout()
        Me.pnlR.SuspendLayout()
        Me.pnlNoice.SuspendLayout()
        Me.pnlSlope.SuspendLayout()
        Me.pnlHeight.SuspendLayout()
        Me.pnlWidth.SuspendLayout()
        Me.pnlY2.SuspendLayout()
        Me.pnlX2.SuspendLayout()
        Me.pnlY.SuspendLayout()
        Me.pnlX.SuspendLayout()
        Me.pnlName.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.mnuMainFrame.SuspendLayout()
        Me.pnlRulerH.SuspendLayout()
        Me.pnlShortcutsBar.SuspendLayout()
        Me.pnlRamInfo.SuspendLayout()
        Me.pnlViRam.SuspendLayout()
        Me.pnlPhRam.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(347, 175)
        '
        'pnlSide
        '
        Me.pnlSide.Controls.Add(Me.lstObjects)
        Me.pnlSide.Controls.Add(Me.lstParameters)
        Me.pnlSide.Controls.Add(Me.pnlToolsSubLists)
        Me.pnlSide.Controls.Add(Me.lstTools)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.Location = New System.Drawing.Point(0, 64)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(200, 618)
        Me.pnlSide.TabIndex = 3
        '
        'lstObjects
        '
        Me.lstObjects.BackColor = System.Drawing.Color.Gray
        Me.lstObjects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstObjects.ContextMenuStrip = Me.mnuObjects
        Me.lstObjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.lstObjects.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lstObjects.FormattingEnabled = True
        Me.lstObjects.ItemHeight = 16
        Me.lstObjects.Location = New System.Drawing.Point(4, 140)
        Me.lstObjects.Name = "lstObjects"
        Me.lstObjects.Size = New System.Drawing.Size(175, 225)
        Me.lstObjects.TabIndex = 3
        '
        'mnuObjects
        '
        Me.mnuObjects.BackColor = System.Drawing.Color.Gray
        Me.mnuObjects.BackgroundImage = Global.ParticleFX.My.Resources.Resources.BlackBar
        Me.mnuObjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mnuObjects.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem, Me.ToolStripMenuItem6, Me.DeleteToolStripMenuItem, Me.ClearToolStripMenuItem1})
        Me.mnuObjects.Name = "mnuObjects"
        Me.mnuObjects.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuObjects.Size = New System.Drawing.Size(132, 76)
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ReloadToolStripMenuItem.Image = Global.ParticleFX.My.Resources.Resources.icoRefresh
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.Gray
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(128, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DeleteToolStripMenuItem.Image = Global.ParticleFX.My.Resources.Resources.icoDelete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'lstParameters
        '
        Me.lstParameters.BackColor = System.Drawing.Color.DimGray
        Me.lstParameters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstParameters.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstParameters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lstParameters.Location = New System.Drawing.Point(0, 134)
        Me.lstParameters.Name = "lstParameters"
        Me.lstParameters.Size = New System.Drawing.Size(200, 484)
        Me.lstParameters.TabIndex = 1
        '
        'pnlToolsSubLists
        '
        Me.pnlToolsSubLists.BackColor = System.Drawing.Color.DimGray
        Me.pnlToolsSubLists.Controls.Add(Me.cmdLoadCams)
        Me.pnlToolsSubLists.Controls.Add(Me.cmdLoadDraws)
        Me.pnlToolsSubLists.Controls.Add(Me.cmdLoadForces)
        Me.pnlToolsSubLists.Controls.Add(Me.cmdLoadGens)
        Me.pnlToolsSubLists.Controls.Add(Me.pnlScroll2B)
        Me.pnlToolsSubLists.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolsSubLists.Location = New System.Drawing.Point(0, 98)
        Me.pnlToolsSubLists.Name = "pnlToolsSubLists"
        Me.pnlToolsSubLists.Size = New System.Drawing.Size(200, 36)
        Me.pnlToolsSubLists.TabIndex = 4
        '
        'cmdLoadCams
        '
        Me.cmdLoadCams.BackgroundImage = Global.ParticleFX.My.Resources.Resources.FatTab0
        Me.cmdLoadCams.Location = New System.Drawing.Point(139, 0)
        Me.cmdLoadCams.Name = "cmdLoadCams"
        Me.cmdLoadCams.Size = New System.Drawing.Size(40, 36)
        Me.cmdLoadCams.TabIndex = 3
        Me.TipsInfo.SetToolTip(Me.cmdLoadCams, "Cameras")
        '
        'cmdLoadDraws
        '
        Me.cmdLoadDraws.BackgroundImage = Global.ParticleFX.My.Resources.Resources.FatTab0
        Me.cmdLoadDraws.Location = New System.Drawing.Point(94, 0)
        Me.cmdLoadDraws.Name = "cmdLoadDraws"
        Me.cmdLoadDraws.Size = New System.Drawing.Size(40, 36)
        Me.cmdLoadDraws.TabIndex = 4
        Me.TipsInfo.SetToolTip(Me.cmdLoadDraws, "Draw static")
        '
        'cmdLoadForces
        '
        Me.cmdLoadForces.BackgroundImage = Global.ParticleFX.My.Resources.Resources.FatTab0
        Me.cmdLoadForces.Location = New System.Drawing.Point(49, 0)
        Me.cmdLoadForces.Name = "cmdLoadForces"
        Me.cmdLoadForces.Size = New System.Drawing.Size(40, 36)
        Me.cmdLoadForces.TabIndex = 3
        Me.TipsInfo.SetToolTip(Me.cmdLoadForces, "Space warps")
        '
        'cmdLoadGens
        '
        Me.cmdLoadGens.BackgroundImage = Global.ParticleFX.My.Resources.Resources.FatTab1
        Me.cmdLoadGens.Location = New System.Drawing.Point(4, 0)
        Me.cmdLoadGens.Name = "cmdLoadGens"
        Me.cmdLoadGens.Size = New System.Drawing.Size(40, 36)
        Me.cmdLoadGens.TabIndex = 2
        Me.TipsInfo.SetToolTip(Me.cmdLoadGens, "Generators")
        '
        'pnlScroll2B
        '
        Me.pnlScroll2B.BackgroundImage = Global.ParticleFX.My.Resources.Resources.ScrollBG
        Me.pnlScroll2B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlScroll2B.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlScroll2B.Location = New System.Drawing.Point(182, 0)
        Me.pnlScroll2B.Name = "pnlScroll2B"
        Me.pnlScroll2B.Size = New System.Drawing.Size(18, 36)
        Me.pnlScroll2B.TabIndex = 1
        '
        'lstTools
        '
        Me.lstTools.BackColor = System.Drawing.Color.DimGray
        Me.lstTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstTools.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTools.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lstTools.Location = New System.Drawing.Point(0, 0)
        Me.lstTools.Name = "lstTools"
        Me.lstTools.Size = New System.Drawing.Size(200, 98)
        Me.lstTools.TabIndex = 0
        '
        'pnlParameters
        '
        Me.pnlParameters.BackColor = System.Drawing.Color.DimGray
        Me.pnlParameters.Controls.Add(Me.pnlBitmap)
        Me.pnlParameters.Controls.Add(Me.pnlColor)
        Me.pnlParameters.Controls.Add(Me.pnlLife)
        Me.pnlParameters.Controls.Add(Me.pnlStop)
        Me.pnlParameters.Controls.Add(Me.pnlStart)
        Me.pnlParameters.Controls.Add(Me.pnlPPF)
        Me.pnlParameters.Controls.Add(Me.pnlF0)
        Me.pnlParameters.Controls.Add(Me.pnlR)
        Me.pnlParameters.Controls.Add(Me.pnlNoice)
        Me.pnlParameters.Controls.Add(Me.pnlSlope)
        Me.pnlParameters.Controls.Add(Me.pnlHeight)
        Me.pnlParameters.Controls.Add(Me.pnlWidth)
        Me.pnlParameters.Controls.Add(Me.pnlY2)
        Me.pnlParameters.Controls.Add(Me.pnlX2)
        Me.pnlParameters.Controls.Add(Me.pnlY)
        Me.pnlParameters.Controls.Add(Me.pnlX)
        Me.pnlParameters.Controls.Add(Me.pnlName)
        Me.pnlParameters.Location = New System.Drawing.Point(6, 3)
        Me.pnlParameters.Name = "pnlParameters"
        Me.pnlParameters.Size = New System.Drawing.Size(175, 352)
        Me.pnlParameters.TabIndex = 0
        '
        'pnlBitmap
        '
        Me.pnlBitmap.Controls.Add(Me.lblBitmap_t)
        Me.pnlBitmap.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBitmap.Location = New System.Drawing.Point(0, 324)
        Me.pnlBitmap.Name = "pnlBitmap"
        Me.pnlBitmap.Size = New System.Drawing.Size(175, 20)
        Me.pnlBitmap.TabIndex = 16
        Me.pnlBitmap.Visible = False
        '
        'lblBitmap_t
        '
        Me.lblBitmap_t.BackColor = System.Drawing.Color.DimGray
        Me.lblBitmap_t.Location = New System.Drawing.Point(3, 2)
        Me.lblBitmap_t.Name = "lblBitmap_t"
        Me.lblBitmap_t.Size = New System.Drawing.Size(52, 13)
        Me.lblBitmap_t.TabIndex = 0
        Me.lblBitmap_t.Text = "Bitmap:"
        Me.lblBitmap_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlColor
        '
        Me.pnlColor.Controls.Add(Me.cmdColor)
        Me.pnlColor.Controls.Add(Me.lblColor_t)
        Me.pnlColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlColor.Location = New System.Drawing.Point(0, 304)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Size = New System.Drawing.Size(175, 20)
        Me.pnlColor.TabIndex = 15
        Me.pnlColor.Visible = False
        '
        'cmdColor
        '
        Me.cmdColor.BackColor = System.Drawing.Color.Blue
        Me.cmdColor.Location = New System.Drawing.Point(61, 1)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.Size = New System.Drawing.Size(84, 18)
        Me.cmdColor.TabIndex = 1
        Me.cmdColor.UseVisualStyleBackColor = False
        '
        'lblColor_t
        '
        Me.lblColor_t.BackColor = System.Drawing.Color.DimGray
        Me.lblColor_t.Location = New System.Drawing.Point(2, 2)
        Me.lblColor_t.Name = "lblColor_t"
        Me.lblColor_t.Size = New System.Drawing.Size(52, 13)
        Me.lblColor_t.TabIndex = 0
        Me.lblColor_t.Text = "Color:"
        Me.lblColor_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlLife
        '
        Me.pnlLife.Controls.Add(Me.lblLife_t)
        Me.pnlLife.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLife.Location = New System.Drawing.Point(0, 284)
        Me.pnlLife.Name = "pnlLife"
        Me.pnlLife.Size = New System.Drawing.Size(175, 20)
        Me.pnlLife.TabIndex = 14
        Me.pnlLife.Visible = False
        '
        'lblLife_t
        '
        Me.lblLife_t.BackColor = System.Drawing.Color.DimGray
        Me.lblLife_t.Location = New System.Drawing.Point(2, 0)
        Me.lblLife_t.Name = "lblLife_t"
        Me.lblLife_t.Size = New System.Drawing.Size(52, 13)
        Me.lblLife_t.TabIndex = 0
        Me.lblLife_t.Text = "Life:"
        Me.lblLife_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlStop
        '
        Me.pnlStop.Controls.Add(Me.lblStop_t)
        Me.pnlStop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStop.Location = New System.Drawing.Point(0, 264)
        Me.pnlStop.Name = "pnlStop"
        Me.pnlStop.Size = New System.Drawing.Size(175, 20)
        Me.pnlStop.TabIndex = 13
        Me.pnlStop.Visible = False
        '
        'lblStop_t
        '
        Me.lblStop_t.BackColor = System.Drawing.Color.DimGray
        Me.lblStop_t.Location = New System.Drawing.Point(2, 0)
        Me.lblStop_t.Name = "lblStop_t"
        Me.lblStop_t.Size = New System.Drawing.Size(52, 13)
        Me.lblStop_t.TabIndex = 0
        Me.lblStop_t.Text = "Stop:"
        Me.lblStop_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlStart
        '
        Me.pnlStart.Controls.Add(Me.lblStart_t)
        Me.pnlStart.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStart.Location = New System.Drawing.Point(0, 244)
        Me.pnlStart.Name = "pnlStart"
        Me.pnlStart.Size = New System.Drawing.Size(175, 20)
        Me.pnlStart.TabIndex = 12
        Me.pnlStart.Visible = False
        '
        'lblStart_t
        '
        Me.lblStart_t.BackColor = System.Drawing.Color.DimGray
        Me.lblStart_t.Location = New System.Drawing.Point(2, 0)
        Me.lblStart_t.Name = "lblStart_t"
        Me.lblStart_t.Size = New System.Drawing.Size(52, 13)
        Me.lblStart_t.TabIndex = 0
        Me.lblStart_t.Text = "Start:"
        Me.lblStart_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlPPF
        '
        Me.pnlPPF.Controls.Add(Me.lblppf)
        Me.pnlPPF.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPPF.Location = New System.Drawing.Point(0, 224)
        Me.pnlPPF.Name = "pnlPPF"
        Me.pnlPPF.Size = New System.Drawing.Size(175, 20)
        Me.pnlPPF.TabIndex = 11
        Me.pnlPPF.Visible = False
        '
        'lblppf
        '
        Me.lblppf.BackColor = System.Drawing.Color.DimGray
        Me.lblppf.Location = New System.Drawing.Point(2, 0)
        Me.lblppf.Name = "lblppf"
        Me.lblppf.Size = New System.Drawing.Size(52, 13)
        Me.lblppf.TabIndex = 0
        Me.lblppf.Text = "PPF:"
        Me.lblppf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlF0
        '
        Me.pnlF0.Controls.Add(Me.Label8)
        Me.pnlF0.Controls.Add(Me.lblF0_t)
        Me.pnlF0.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlF0.Location = New System.Drawing.Point(0, 204)
        Me.pnlF0.Name = "pnlF0"
        Me.pnlF0.Size = New System.Drawing.Size(175, 20)
        Me.pnlF0.TabIndex = 10
        Me.pnlF0.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label8.Location = New System.Drawing.Point(145, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "p/f"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblF0_t
        '
        Me.lblF0_t.BackColor = System.Drawing.Color.DimGray
        Me.lblF0_t.Location = New System.Drawing.Point(2, 0)
        Me.lblF0_t.Name = "lblF0_t"
        Me.lblF0_t.Size = New System.Drawing.Size(52, 13)
        Me.lblF0_t.TabIndex = 0
        Me.lblF0_t.Text = "Velocity:"
        Me.lblF0_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlR
        '
        Me.pnlR.Controls.Add(Me.lblR)
        Me.pnlR.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlR.Location = New System.Drawing.Point(0, 184)
        Me.pnlR.Name = "pnlR"
        Me.pnlR.Size = New System.Drawing.Size(175, 20)
        Me.pnlR.TabIndex = 9
        Me.pnlR.Visible = False
        '
        'lblR
        '
        Me.lblR.BackColor = System.Drawing.Color.DimGray
        Me.lblR.Location = New System.Drawing.Point(2, 0)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(52, 13)
        Me.lblR.TabIndex = 0
        Me.lblR.Text = "R:"
        Me.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlNoice
        '
        Me.pnlNoice.Controls.Add(Me.Label9)
        Me.pnlNoice.Controls.Add(Me.lblNoice_t)
        Me.pnlNoice.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNoice.Location = New System.Drawing.Point(0, 164)
        Me.pnlNoice.Name = "pnlNoice"
        Me.pnlNoice.Size = New System.Drawing.Size(175, 20)
        Me.pnlNoice.TabIndex = 8
        Me.pnlNoice.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label9.Location = New System.Drawing.Point(145, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "%"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoice_t
        '
        Me.lblNoice_t.BackColor = System.Drawing.Color.DimGray
        Me.lblNoice_t.Location = New System.Drawing.Point(2, 0)
        Me.lblNoice_t.Name = "lblNoice_t"
        Me.lblNoice_t.Size = New System.Drawing.Size(52, 13)
        Me.lblNoice_t.TabIndex = 0
        Me.lblNoice_t.Text = "Noice:"
        Me.lblNoice_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlSlope
        '
        Me.pnlSlope.Controls.Add(Me.Label7)
        Me.pnlSlope.Controls.Add(Me.lblSlope_t)
        Me.pnlSlope.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSlope.Location = New System.Drawing.Point(0, 144)
        Me.pnlSlope.Name = "pnlSlope"
        Me.pnlSlope.Size = New System.Drawing.Size(175, 20)
        Me.pnlSlope.TabIndex = 7
        Me.pnlSlope.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(145, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "°"
        '
        'lblSlope_t
        '
        Me.lblSlope_t.BackColor = System.Drawing.Color.DimGray
        Me.lblSlope_t.Location = New System.Drawing.Point(2, 0)
        Me.lblSlope_t.Name = "lblSlope_t"
        Me.lblSlope_t.Size = New System.Drawing.Size(52, 13)
        Me.lblSlope_t.TabIndex = 0
        Me.lblSlope_t.Text = "Slope:"
        Me.lblSlope_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlHeight
        '
        Me.pnlHeight.Controls.Add(Me.Label6)
        Me.pnlHeight.Controls.Add(Me.lblHeight_t)
        Me.pnlHeight.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeight.Location = New System.Drawing.Point(0, 124)
        Me.pnlHeight.Name = "pnlHeight"
        Me.pnlHeight.Size = New System.Drawing.Size(175, 20)
        Me.pnlHeight.TabIndex = 6
        Me.pnlHeight.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.Location = New System.Drawing.Point(145, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "pixels"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHeight_t
        '
        Me.lblHeight_t.BackColor = System.Drawing.Color.DimGray
        Me.lblHeight_t.Location = New System.Drawing.Point(2, 0)
        Me.lblHeight_t.Name = "lblHeight_t"
        Me.lblHeight_t.Size = New System.Drawing.Size(52, 13)
        Me.lblHeight_t.TabIndex = 0
        Me.lblHeight_t.Text = "Height:"
        Me.lblHeight_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlWidth
        '
        Me.pnlWidth.Controls.Add(Me.Label5)
        Me.pnlWidth.Controls.Add(Me.lblWidth_t)
        Me.pnlWidth.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlWidth.Location = New System.Drawing.Point(0, 104)
        Me.pnlWidth.Name = "pnlWidth"
        Me.pnlWidth.Size = New System.Drawing.Size(175, 20)
        Me.pnlWidth.TabIndex = 5
        Me.pnlWidth.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label5.Location = New System.Drawing.Point(145, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "pixels"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWidth_t
        '
        Me.lblWidth_t.BackColor = System.Drawing.Color.DimGray
        Me.lblWidth_t.Location = New System.Drawing.Point(2, 0)
        Me.lblWidth_t.Name = "lblWidth_t"
        Me.lblWidth_t.Size = New System.Drawing.Size(52, 13)
        Me.lblWidth_t.TabIndex = 0
        Me.lblWidth_t.Text = "Width:"
        Me.lblWidth_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlY2
        '
        Me.pnlY2.Controls.Add(Me.Label4)
        Me.pnlY2.Controls.Add(Me.lblY2)
        Me.pnlY2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlY2.Location = New System.Drawing.Point(0, 84)
        Me.pnlY2.Name = "pnlY2"
        Me.pnlY2.Size = New System.Drawing.Size(175, 20)
        Me.pnlY2.TabIndex = 4
        Me.pnlY2.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "pixels"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblY2
        '
        Me.lblY2.BackColor = System.Drawing.Color.DimGray
        Me.lblY2.Location = New System.Drawing.Point(2, 0)
        Me.lblY2.Name = "lblY2"
        Me.lblY2.Size = New System.Drawing.Size(52, 13)
        Me.lblY2.TabIndex = 1
        Me.lblY2.Text = "y':"
        Me.lblY2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlX2
        '
        Me.pnlX2.Controls.Add(Me.Label3)
        Me.pnlX2.Controls.Add(Me.lblX2)
        Me.pnlX2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlX2.Location = New System.Drawing.Point(0, 64)
        Me.pnlX2.Name = "pnlX2"
        Me.pnlX2.Size = New System.Drawing.Size(175, 20)
        Me.pnlX2.TabIndex = 3
        Me.pnlX2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "pixels"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblX2
        '
        Me.lblX2.BackColor = System.Drawing.Color.DimGray
        Me.lblX2.Location = New System.Drawing.Point(2, 0)
        Me.lblX2.Name = "lblX2"
        Me.lblX2.Size = New System.Drawing.Size(52, 13)
        Me.lblX2.TabIndex = 0
        Me.lblX2.Text = "x':"
        Me.lblX2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlY
        '
        Me.pnlY.Controls.Add(Me.Label2)
        Me.pnlY.Controls.Add(Me.lbly)
        Me.pnlY.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlY.Location = New System.Drawing.Point(0, 44)
        Me.pnlY.Name = "pnlY"
        Me.pnlY.Size = New System.Drawing.Size(175, 20)
        Me.pnlY.TabIndex = 2
        Me.pnlY.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "pixels"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbly
        '
        Me.lbly.BackColor = System.Drawing.Color.DimGray
        Me.lbly.Location = New System.Drawing.Point(2, 0)
        Me.lbly.Name = "lbly"
        Me.lbly.Size = New System.Drawing.Size(52, 13)
        Me.lbly.TabIndex = 0
        Me.lbly.Text = "y:"
        Me.lbly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlX
        '
        Me.pnlX.Controls.Add(Me.Label1)
        Me.pnlX.Controls.Add(Me.lblx)
        Me.pnlX.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlX.Location = New System.Drawing.Point(0, 24)
        Me.pnlX.Name = "pnlX"
        Me.pnlX.Size = New System.Drawing.Size(175, 20)
        Me.pnlX.TabIndex = 1
        Me.pnlX.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "pixels"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblx
        '
        Me.lblx.BackColor = System.Drawing.Color.DimGray
        Me.lblx.Location = New System.Drawing.Point(3, 0)
        Me.lblx.Name = "lblx"
        Me.lblx.Size = New System.Drawing.Size(52, 13)
        Me.lblx.TabIndex = 0
        Me.lblx.Text = "x:"
        Me.lblx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlName
        '
        Me.pnlName.Controls.Add(Me.lblName_t)
        Me.pnlName.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlName.Location = New System.Drawing.Point(0, 0)
        Me.pnlName.Name = "pnlName"
        Me.pnlName.Size = New System.Drawing.Size(175, 24)
        Me.pnlName.TabIndex = 0
        Me.pnlName.Visible = False
        '
        'lblName_t
        '
        Me.lblName_t.BackColor = System.Drawing.Color.DimGray
        Me.lblName_t.Location = New System.Drawing.Point(3, 4)
        Me.lblName_t.Name = "lblName_t"
        Me.lblName_t.Size = New System.Drawing.Size(52, 13)
        Me.lblName_t.TabIndex = 0
        Me.lblName_t.Text = "Label:"
        Me.lblName_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlMain
        '
        Me.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlMain.ContextMenuStrip = Me.mnuMainFrame
        Me.pnlMain.Controls.Add(Me.pnlNavigator)
        Me.pnlMain.Controls.Add(Me.pnlParameters)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(200, 64)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1048, 602)
        Me.pnlMain.TabIndex = 5
        '
        'mnuMainFrame
        '
        Me.mnuMainFrame.BackColor = System.Drawing.Color.Gray
        Me.mnuMainFrame.BackgroundImage = Global.ParticleFX.My.Resources.Resources.BlackBar
        Me.mnuMainFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mnuMainFrame.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem1, Me.ToolStripMenuItem7, Me.ResetOffsetToolStripMenuItem1, Me.ToolStripMenuItem8, Me.SelectToolStripMenuItem, Me.MoveToolStripMenuItem, Me.ScaleToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.ToolStripMenuItem9, Me.ClearToolStripMenuItem2})
        Me.mnuMainFrame.Name = "mnuMainFrame"
        Me.mnuMainFrame.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuMainFrame.Size = New System.Drawing.Size(146, 176)
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RefreshToolStripMenuItem1.Image = Global.ParticleFX.My.Resources.Resources.icoRefresh
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(142, 6)
        '
        'ResetOffsetToolStripMenuItem1
        '
        Me.ResetOffsetToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ResetOffsetToolStripMenuItem1.Name = "ResetOffsetToolStripMenuItem1"
        Me.ResetOffsetToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ResetOffsetToolStripMenuItem1.Text = "Reset offset"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(142, 6)
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SelectToolStripMenuItem.Image = Global.ParticleFX.My.Resources.Resources.icoSelect
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SelectToolStripMenuItem.Text = "Select"
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MoveToolStripMenuItem.Image = Global.ParticleFX.My.Resources.Resources.icoMove
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        Me.MoveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MoveToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.MoveToolStripMenuItem.Text = "Move"
        '
        'ScaleToolStripMenuItem
        '
        Me.ScaleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ScaleToolStripMenuItem.Image = Global.ParticleFX.My.Resources.Resources.icoScale
        Me.ScaleToolStripMenuItem.Name = "ScaleToolStripMenuItem"
        Me.ScaleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ScaleToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ScaleToolStripMenuItem.Text = "Scale"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DeleteToolStripMenuItem1.Image = Global.ParticleFX.My.Resources.Resources.icoDelete
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(142, 6)
        '
        'ClearToolStripMenuItem2
        '
        Me.ClearToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClearToolStripMenuItem2.Name = "ClearToolStripMenuItem2"
        Me.ClearToolStripMenuItem2.Size = New System.Drawing.Size(145, 22)
        Me.ClearToolStripMenuItem2.Text = "Clear"
        '
        'pnlNavigator
        '
        Me.pnlNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.pnlNavigator.Location = New System.Drawing.Point(842, 6)
        Me.pnlNavigator.Name = "pnlNavigator"
        Me.pnlNavigator.Size = New System.Drawing.Size(200, 100)
        Me.pnlNavigator.TabIndex = 1
        Me.pnlNavigator.Visible = False
        '
        'pnlRulerV
        '
        Me.pnlRulerV.BackColor = System.Drawing.Color.Silver
        Me.pnlRulerV.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRulerV.Location = New System.Drawing.Point(1248, 64)
        Me.pnlRulerV.Name = "pnlRulerV"
        Me.pnlRulerV.Size = New System.Drawing.Size(16, 602)
        Me.pnlRulerV.TabIndex = 6
        '
        'pnlRulerH
        '
        Me.pnlRulerH.BackColor = System.Drawing.Color.Silver
        Me.pnlRulerH.Controls.Add(Me.pnlCent)
        Me.pnlRulerH.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRulerH.Location = New System.Drawing.Point(200, 666)
        Me.pnlRulerH.Name = "pnlRulerH"
        Me.pnlRulerH.Size = New System.Drawing.Size(1064, 16)
        Me.pnlRulerH.TabIndex = 7
        '
        'pnlCent
        '
        Me.pnlCent.BackColor = System.Drawing.Color.Gray
        Me.pnlCent.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlCent.Location = New System.Drawing.Point(1048, 0)
        Me.pnlCent.Name = "pnlCent"
        Me.pnlCent.Size = New System.Drawing.Size(16, 16)
        Me.pnlCent.TabIndex = 2
        '
        'TipsInfo
        '
        Me.TipsInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TipsInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        '
        'tmrRamInfo
        '
        Me.tmrRamInfo.Enabled = True
        Me.tmrRamInfo.Interval = 1250
        '
        'pnlShortcutsBar
        '
        Me.pnlShortcutsBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlShortcutsBar.BackgroundImage = Global.ParticleFX.My.Resources.Resources.MainMenuLow
        Me.pnlShortcutsBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlShortcutsBar.Controls.Add(Me.Panel3)
        Me.pnlShortcutsBar.Controls.Add(Me.Panel2)
        Me.pnlShortcutsBar.Controls.Add(Me.Panel1)
        Me.pnlShortcutsBar.Controls.Add(Me.pnlRamInfo)
        Me.pnlShortcutsBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlShortcutsBar.Location = New System.Drawing.Point(0, 24)
        Me.pnlShortcutsBar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlShortcutsBar.Name = "pnlShortcutsBar"
        Me.pnlShortcutsBar.Size = New System.Drawing.Size(1264, 40)
        Me.pnlShortcutsBar.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.ParticleFX.My.Resources.Resources.icoScale
        Me.Panel3.Location = New System.Drawing.Point(88, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(32, 32)
        Me.Panel3.TabIndex = 3
        Me.Panel3.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.ParticleFX.My.Resources.Resources.icoMove
        Me.Panel2.Location = New System.Drawing.Point(50, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(32, 32)
        Me.Panel2.TabIndex = 3
        Me.Panel2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.ParticleFX.My.Resources.Resources.icoSelect
        Me.Panel1.Location = New System.Drawing.Point(12, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(32, 32)
        Me.Panel1.TabIndex = 2
        '
        'pnlRamInfo
        '
        Me.pnlRamInfo.BackgroundImage = Global.ParticleFX.My.Resources.Resources.MainMenuLow
        Me.pnlRamInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlRamInfo.Controls.Add(Me.lblRamVi)
        Me.pnlRamInfo.Controls.Add(Me.lblRamPh)
        Me.pnlRamInfo.Controls.Add(Me.pnlViRam)
        Me.pnlRamInfo.Controls.Add(Me.pnlPhRam)
        Me.pnlRamInfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRamInfo.Location = New System.Drawing.Point(1159, 0)
        Me.pnlRamInfo.Name = "pnlRamInfo"
        Me.pnlRamInfo.Size = New System.Drawing.Size(105, 40)
        Me.pnlRamInfo.TabIndex = 1
        '
        'lblRamVi
        '
        Me.lblRamVi.AutoSize = True
        Me.lblRamVi.BackColor = System.Drawing.Color.Transparent
        Me.lblRamVi.Location = New System.Drawing.Point(3, 21)
        Me.lblRamVi.Name = "lblRamVi"
        Me.lblRamVi.Size = New System.Drawing.Size(17, 13)
        Me.lblRamVi.TabIndex = 3
        Me.lblRamVi.Text = "V:"
        '
        'lblRamPh
        '
        Me.lblRamPh.AutoSize = True
        Me.lblRamPh.BackColor = System.Drawing.Color.Transparent
        Me.lblRamPh.Location = New System.Drawing.Point(3, 3)
        Me.lblRamPh.Name = "lblRamPh"
        Me.lblRamPh.Size = New System.Drawing.Size(16, 13)
        Me.lblRamPh.TabIndex = 2
        Me.lblRamPh.Text = "P:"
        '
        'pnlViRam
        '
        Me.pnlViRam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlViRam.Controls.Add(Me.pnlRamViT)
        Me.pnlViRam.Controls.Add(Me.pnlRamViP)
        Me.pnlViRam.Location = New System.Drawing.Point(25, 23)
        Me.pnlViRam.Name = "pnlViRam"
        Me.pnlViRam.Size = New System.Drawing.Size(72, 12)
        Me.pnlViRam.TabIndex = 1
        '
        'pnlRamViT
        '
        Me.pnlRamViT.BackColor = System.Drawing.Color.Gray
        Me.pnlRamViT.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRamViT.Location = New System.Drawing.Point(2, 0)
        Me.pnlRamViT.Name = "pnlRamViT"
        Me.pnlRamViT.Size = New System.Drawing.Size(2, 10)
        Me.pnlRamViT.TabIndex = 3
        '
        'pnlRamViP
        '
        Me.pnlRamViP.BackColor = System.Drawing.Color.Silver
        Me.pnlRamViP.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRamViP.Location = New System.Drawing.Point(0, 0)
        Me.pnlRamViP.Name = "pnlRamViP"
        Me.pnlRamViP.Size = New System.Drawing.Size(2, 10)
        Me.pnlRamViP.TabIndex = 2
        '
        'pnlPhRam
        '
        Me.pnlPhRam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPhRam.Controls.Add(Me.pnlRamPhT)
        Me.pnlPhRam.Controls.Add(Me.pnlRamPhP)
        Me.pnlPhRam.Location = New System.Drawing.Point(25, 5)
        Me.pnlPhRam.Name = "pnlPhRam"
        Me.pnlPhRam.Size = New System.Drawing.Size(72, 12)
        Me.pnlPhRam.TabIndex = 0
        '
        'pnlRamPhT
        '
        Me.pnlRamPhT.BackColor = System.Drawing.Color.Gray
        Me.pnlRamPhT.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRamPhT.Location = New System.Drawing.Point(2, 0)
        Me.pnlRamPhT.Name = "pnlRamPhT"
        Me.pnlRamPhT.Size = New System.Drawing.Size(2, 10)
        Me.pnlRamPhT.TabIndex = 1
        '
        'pnlRamPhP
        '
        Me.pnlRamPhP.BackColor = System.Drawing.Color.Silver
        Me.pnlRamPhP.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRamPhP.Location = New System.Drawing.Point(0, 0)
        Me.pnlRamPhP.Name = "pnlRamPhP"
        Me.pnlRamPhP.Size = New System.Drawing.Size(2, 10)
        Me.pnlRamPhP.TabIndex = 0
        '
        'mnuMain
        '
        Me.mnuMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mnuMain.BackgroundImage = Global.ParticleFX.My.Resources.Resources.MainMenuhigh
        Me.mnuMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.RenderToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1264, 24)
        Me.mnuMain.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.NewToolStripMenuItem.Text = "New project"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.OpenToolStripMenuItem.Text = "Open project"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SaveToolStripMenuItem.Text = "Save project"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ToolStripMenuItem3, Me.ZoomInToolStripMenuItem, Me.ZoomOutToolStripMenuItem, Me.ResetZoomToolStripMenuItem, Me.ToolStripMenuItem4, Me.ResetOffsetToolStripMenuItem, Me.ToolStripMenuItem5, Me.ShortcutsBarToolStripMenuItem, Me.RulerToolStripMenuItem})
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(217, 6)
        '
        'ZoomInToolStripMenuItem
        '
        Me.ZoomInToolStripMenuItem.Enabled = False
        Me.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        Me.ZoomInToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus), System.Windows.Forms.Keys)
        Me.ZoomInToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ZoomInToolStripMenuItem.Text = "Zoom in"
        '
        'ZoomOutToolStripMenuItem
        '
        Me.ZoomOutToolStripMenuItem.Enabled = False
        Me.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        Me.ZoomOutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.OemMinus), System.Windows.Forms.Keys)
        Me.ZoomOutToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ZoomOutToolStripMenuItem.Text = "Zoom out"
        '
        'ResetZoomToolStripMenuItem
        '
        Me.ResetZoomToolStripMenuItem.Enabled = False
        Me.ResetZoomToolStripMenuItem.Name = "ResetZoomToolStripMenuItem"
        Me.ResetZoomToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.ResetZoomToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ResetZoomToolStripMenuItem.Text = "Reset zoom"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(217, 6)
        '
        'ResetOffsetToolStripMenuItem
        '
        Me.ResetOffsetToolStripMenuItem.Name = "ResetOffsetToolStripMenuItem"
        Me.ResetOffsetToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ResetOffsetToolStripMenuItem.Text = "Reset offset"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(217, 6)
        '
        'ShortcutsBarToolStripMenuItem
        '
        Me.ShortcutsBarToolStripMenuItem.Checked = True
        Me.ShortcutsBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShortcutsBarToolStripMenuItem.Name = "ShortcutsBarToolStripMenuItem"
        Me.ShortcutsBarToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ShortcutsBarToolStripMenuItem.Text = "Shortcuts Bar"
        '
        'RulerToolStripMenuItem
        '
        Me.RulerToolStripMenuItem.Checked = True
        Me.RulerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RulerToolStripMenuItem.Name = "RulerToolStripMenuItem"
        Me.RulerToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.RulerToolStripMenuItem.Text = "Ruler"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaticToolStripMenuItem1, Me.SpaceWarpsToolStripMenuItem, Me.ToolStripMenuItem10, Me.PreviewAnimationToolStripMenuItem, Me.WaveformsEditorToolStripMenuItem, Me.WarpMapToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'StaticToolStripMenuItem1
        '
        Me.StaticToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.SaveToolStripMenuItem1, Me.ClearToolStripMenuItem})
        Me.StaticToolStripMenuItem1.Name = "StaticToolStripMenuItem1"
        Me.StaticToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.StaticToolStripMenuItem1.Text = "Static"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(101, 22)
        Me.SaveToolStripMenuItem1.Text = "Save"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'SpaceWarpsToolStripMenuItem
        '
        Me.SpaceWarpsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem2, Me.SaveToolStripMenuItem3, Me.ClearToolStripMenuItem4})
        Me.SpaceWarpsToolStripMenuItem.Name = "SpaceWarpsToolStripMenuItem"
        Me.SpaceWarpsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SpaceWarpsToolStripMenuItem.Text = "Space warps"
        '
        'LoadToolStripMenuItem2
        '
        Me.LoadToolStripMenuItem2.Name = "LoadToolStripMenuItem2"
        Me.LoadToolStripMenuItem2.Size = New System.Drawing.Size(101, 22)
        Me.LoadToolStripMenuItem2.Text = "Load"
        '
        'SaveToolStripMenuItem3
        '
        Me.SaveToolStripMenuItem3.Name = "SaveToolStripMenuItem3"
        Me.SaveToolStripMenuItem3.Size = New System.Drawing.Size(101, 22)
        Me.SaveToolStripMenuItem3.Text = "Save"
        '
        'ClearToolStripMenuItem4
        '
        Me.ClearToolStripMenuItem4.Name = "ClearToolStripMenuItem4"
        Me.ClearToolStripMenuItem4.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem4.Text = "Clear"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(169, 6)
        '
        'PreviewAnimationToolStripMenuItem
        '
        Me.PreviewAnimationToolStripMenuItem.Name = "PreviewAnimationToolStripMenuItem"
        Me.PreviewAnimationToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PreviewAnimationToolStripMenuItem.Text = "Preview animation"
        '
        'WaveformsEditorToolStripMenuItem
        '
        Me.WaveformsEditorToolStripMenuItem.Name = "WaveformsEditorToolStripMenuItem"
        Me.WaveformsEditorToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.WaveformsEditorToolStripMenuItem.Text = "Waveforms editor"
        '
        'WarpMapToolStripMenuItem
        '
        Me.WarpMapToolStripMenuItem.Name = "WarpMapToolStripMenuItem"
        Me.WarpMapToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.WarpMapToolStripMenuItem.Text = "Warp map"
        '
        'RenderToolStripMenuItem
        '
        Me.RenderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenderToolStripMenuItem1, Me.ToolStripMenuItem2, Me.FramesToolStripMenuItem, Me.EnvironmentToolStripMenuItem, Me.ParticlesToolStripMenuItem, Me.ReactToolStripMenuItem})
        Me.RenderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RenderToolStripMenuItem.Name = "RenderToolStripMenuItem"
        Me.RenderToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.RenderToolStripMenuItem.Text = "Render"
        '
        'RenderToolStripMenuItem1
        '
        Me.RenderToolStripMenuItem1.Name = "RenderToolStripMenuItem1"
        Me.RenderToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.RenderToolStripMenuItem1.Text = "Render setup"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(139, 6)
        '
        'FramesToolStripMenuItem
        '
        Me.FramesToolStripMenuItem.Name = "FramesToolStripMenuItem"
        Me.FramesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.FramesToolStripMenuItem.Text = "Frames"
        '
        'EnvironmentToolStripMenuItem
        '
        Me.EnvironmentToolStripMenuItem.Name = "EnvironmentToolStripMenuItem"
        Me.EnvironmentToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.EnvironmentToolStripMenuItem.Text = "Environment"
        '
        'ParticlesToolStripMenuItem
        '
        Me.ParticlesToolStripMenuItem.Name = "ParticlesToolStripMenuItem"
        Me.ParticlesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ParticlesToolStripMenuItem.Text = "Particles"
        '
        'ReactToolStripMenuItem
        '
        Me.ReactToolStripMenuItem.Name = "ReactToolStripMenuItem"
        Me.ReactToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ReactToolStripMenuItem.Text = "React"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LanguageToolStripMenuItem, Me.ToolStripMenuItem11, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.LanguageToolStripMenuItem.Text = "Language"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(123, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlRulerV)
        Me.Controls.Add(Me.pnlRulerH)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.pnlShortcutsBar)
        Me.Controls.Add(Me.mnuMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.MinimumSize = New System.Drawing.Size(720, 480)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Particle f(x)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSide.ResumeLayout(False)
        Me.mnuObjects.ResumeLayout(False)
        Me.pnlToolsSubLists.ResumeLayout(False)
        Me.pnlParameters.ResumeLayout(False)
        Me.pnlBitmap.ResumeLayout(False)
        Me.pnlColor.ResumeLayout(False)
        Me.pnlLife.ResumeLayout(False)
        Me.pnlStop.ResumeLayout(False)
        Me.pnlStart.ResumeLayout(False)
        Me.pnlPPF.ResumeLayout(False)
        Me.pnlF0.ResumeLayout(False)
        Me.pnlR.ResumeLayout(False)
        Me.pnlNoice.ResumeLayout(False)
        Me.pnlSlope.ResumeLayout(False)
        Me.pnlSlope.PerformLayout()
        Me.pnlHeight.ResumeLayout(False)
        Me.pnlWidth.ResumeLayout(False)
        Me.pnlY2.ResumeLayout(False)
        Me.pnlX2.ResumeLayout(False)
        Me.pnlY.ResumeLayout(False)
        Me.pnlX.ResumeLayout(False)
        Me.pnlName.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.mnuMainFrame.ResumeLayout(False)
        Me.pnlRulerH.ResumeLayout(False)
        Me.pnlShortcutsBar.ResumeLayout(False)
        Me.pnlRamInfo.ResumeLayout(False)
        Me.pnlRamInfo.PerformLayout()
        Me.pnlViRam.ResumeLayout(False)
        Me.pnlPhRam.ResumeLayout(False)
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents lstTools As ParticleFX.ctrObjectsList
    Friend WithEvents pnlSide As System.Windows.Forms.Panel
    Friend WithEvents lstParameters As ParticleFX.ctrObjectsList
    Friend WithEvents lstObjects As System.Windows.Forms.ListBox
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlRulerV As System.Windows.Forms.Panel
    Friend WithEvents pnlRulerH As System.Windows.Forms.Panel
    Friend WithEvents pnlCent As System.Windows.Forms.Panel
    Friend WithEvents pnlParameters As System.Windows.Forms.Panel
    Friend WithEvents lblName_t As System.Windows.Forms.Label
    Friend WithEvents lblHeight_t As System.Windows.Forms.Label
    Friend WithEvents lblWidth_t As System.Windows.Forms.Label
    Friend WithEvents lbly As System.Windows.Forms.Label
    Friend WithEvents lblx As System.Windows.Forms.Label
    Friend WithEvents lblSlope_t As System.Windows.Forms.Label
    Friend WithEvents lblppf As System.Windows.Forms.Label
    Friend WithEvents lblNoice_t As System.Windows.Forms.Label
    Friend WithEvents lblF0_t As System.Windows.Forms.Label
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents pnlShortcutsBar As System.Windows.Forms.Panel
    Friend WithEvents pnlPPF As System.Windows.Forms.Panel
    Friend WithEvents pnlNoice As System.Windows.Forms.Panel
    Friend WithEvents pnlF0 As System.Windows.Forms.Panel
    Friend WithEvents pnlSlope As System.Windows.Forms.Panel
    Friend WithEvents pnlHeight As System.Windows.Forms.Panel
    Friend WithEvents pnlWidth As System.Windows.Forms.Panel
    Friend WithEvents pnlY As System.Windows.Forms.Panel
    Friend WithEvents pnlX As System.Windows.Forms.Panel
    Friend WithEvents pnlName As System.Windows.Forms.Panel
    Friend WithEvents pnlY2 As System.Windows.Forms.Panel
    Friend WithEvents lblY2 As System.Windows.Forms.Label
    Friend WithEvents pnlX2 As System.Windows.Forms.Panel
    Friend WithEvents lblX2 As System.Windows.Forms.Label
    Friend WithEvents pnlStop As System.Windows.Forms.Panel
    Friend WithEvents lblStop_t As System.Windows.Forms.Label
    Friend WithEvents pnlStart As System.Windows.Forms.Panel
    Friend WithEvents lblStart_t As System.Windows.Forms.Label
    Friend WithEvents RenderToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EnvironmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnlLife As System.Windows.Forms.Panel
    Friend WithEvents lblLife_t As System.Windows.Forms.Label
    Friend WithEvents FramesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParticlesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShortcutsBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RulerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlR As System.Windows.Forms.Panel
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents pnlColor As System.Windows.Forms.Panel
    Friend WithEvents lblColor_t As System.Windows.Forms.Label
    Friend WithEvents cmdColor As System.Windows.Forms.Button
    Friend WithEvents pnlBitmap As System.Windows.Forms.Panel
    Friend WithEvents lblBitmap_t As System.Windows.Forms.Label
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlToolsSubLists As System.Windows.Forms.Panel
    Friend WithEvents pnlScroll2B As System.Windows.Forms.Panel
    Friend WithEvents cmdLoadGens As System.Windows.Forms.Panel
    Friend WithEvents cmdLoadCams As System.Windows.Forms.Panel
    Friend WithEvents cmdLoadDraws As System.Windows.Forms.Panel
    Friend WithEvents cmdLoadForces As System.Windows.Forms.Panel
    Friend WithEvents TipsInfo As System.Windows.Forms.ToolTip
    Friend WithEvents ResetZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetOffsetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlRamInfo As System.Windows.Forms.Panel
    Friend WithEvents pnlViRam As System.Windows.Forms.Panel
    Friend WithEvents pnlPhRam As System.Windows.Forms.Panel
    Friend WithEvents lblRamVi As System.Windows.Forms.Label
    Friend WithEvents lblRamPh As System.Windows.Forms.Label
    Friend WithEvents tmrRamInfo As System.Windows.Forms.Timer
    Friend WithEvents pnlRamPhT As System.Windows.Forms.Panel
    Friend WithEvents pnlRamPhP As System.Windows.Forms.Panel
    Friend WithEvents pnlRamViT As System.Windows.Forms.Panel
    Friend WithEvents pnlRamViP As System.Windows.Forms.Panel
    Friend WithEvents pnlNavigator As System.Windows.Forms.Panel
    Friend WithEvents mnuObjects As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mnuMainFrame As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetOffsetToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaticToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpaceWarpsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WaveformsEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WarpMapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewAnimationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator

End Class
