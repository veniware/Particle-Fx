<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRender
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRender))
        Me.lblFramesRange = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.NumericUpDown()
        Me.lblRangeTo = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.NumericUpDown()
        Me.lblBanground = New System.Windows.Forms.Label()
        Me.chkMotionBlur = New System.Windows.Forms.CheckBox()
        Me.chkDrawGens = New System.Windows.Forms.CheckBox()
        Me.cmbCamera = New System.Windows.Forms.ComboBox()
        Me.lblCamera = New System.Windows.Forms.Label()
        Me.lblCameraSize = New System.Windows.Forms.Label()
        Me.lblPixelFormat = New System.Windows.Forms.Label()
        Me.cmbPixelFormat = New System.Windows.Forms.ComboBox()
        Me.chkDrawStatic = New System.Windows.Forms.CheckBox()
        Me.pnlFrames = New System.Windows.Forms.Panel()
        Me.lblNotRecommended = New System.Windows.Forms.Label()
        Me.cmbSmoothing = New System.Windows.Forms.ComboBox()
        Me.lblTotalSec = New System.Windows.Forms.Label()
        Me.txtFPS = New System.Windows.Forms.NumericUpDown()
        Me.lblSmoothing = New System.Windows.Forms.Label()
        Me.lblFPS = New System.Windows.Forms.Label()
        Me.chkSkipExisting = New System.Windows.Forms.CheckBox()
        Me.cmbImageFormat = New System.Windows.Forms.ComboBox()
        Me.lblImageFormat = New System.Windows.Forms.Label()
        Me.lblTotalFrames = New System.Windows.Forms.Label()
        Me.cmdBrowseLocation = New System.Windows.Forms.Button()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.pnlFramesTitle = New System.Windows.Forms.Panel()
        Me.pnlEnvironment = New System.Windows.Forms.Panel()
        Me.cmdSolidBG = New System.Windows.Forms.Button()
        Me.cmdImageBG = New System.Windows.Forms.Button()
        Me.txtImageBG = New System.Windows.Forms.TextBox()
        Me.optImageBG = New System.Windows.Forms.RadioButton()
        Me.optSolidBG = New System.Windows.Forms.RadioButton()
        Me.optTransparentBG = New System.Windows.Forms.RadioButton()
        Me.pnlEnvironmentTitle = New System.Windows.Forms.Panel()
        Me.pnlReact = New System.Windows.Forms.Panel()
        Me.chkReactEachOther = New System.Windows.Forms.CheckBox()
        Me.lblGForcePPF = New System.Windows.Forms.Label()
        Me.txtGForce = New System.Windows.Forms.NumericUpDown()
        Me.cmbReactor = New System.Windows.Forms.ComboBox()
        Me.lblReactor = New System.Windows.Forms.Label()
        Me.pnlReactTitle = New System.Windows.Forms.Panel()
        Me.lblGForce = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlBackScroll = New System.Windows.Forms.Panel()
        Me.pnlMainScroll = New System.Windows.Forms.Panel()
        Me.cmdScroll = New System.Windows.Forms.Panel()
        Me.cmdScrollDown = New System.Windows.Forms.PictureBox()
        Me.cmdScrollUp = New System.Windows.Forms.PictureBox()
        Me.pnlMainList = New System.Windows.Forms.Panel()
        Me.Sp3 = New System.Windows.Forms.Panel()
        Me.pnlParticles = New System.Windows.Forms.Panel()
        Me.pnlGlossiness = New System.Windows.Forms.Panel()
        Me.cmdPreviewGloss = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtGlossiness = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSpecLevel = New System.Windows.Forms.NumericUpDown()
        Me.cmdGlossColor = New System.Windows.Forms.Button()
        Me.chkGlossiness = New System.Windows.Forms.CheckBox()
        Me.optRefract = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optReflect = New System.Windows.Forms.RadioButton()
        Me.txtColorOpacity = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.optSolidColor = New System.Windows.Forms.RadioButton()
        Me.lblExitColor = New System.Windows.Forms.Label()
        Me.cmdExitColor = New System.Windows.Forms.Button()
        Me.pnlParticlesRefraction = New System.Windows.Forms.Panel()
        Me.txtRefractOpacity = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIOR = New System.Windows.Forms.NumericUpDown()
        Me.cmdIOR = New System.Windows.Forms.Button()
        Me.pnlParticlesReflection = New System.Windows.Forms.Panel()
        Me.txtReflectOpacity = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlParticlesMotionBlur = New System.Windows.Forms.Panel()
        Me.txtMotionBlurSamples = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlParticlesGlow = New System.Windows.Forms.Panel()
        Me.cmdGlowColor = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGlowOpacity = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkColor = New System.Windows.Forms.CheckBox()
        Me.pnlParticlesColor = New System.Windows.Forms.Panel()
        Me.cmdColor = New System.Windows.Forms.Button()
        Me.chkGlow = New System.Windows.Forms.CheckBox()
        Me.pnlParticlesTitle = New System.Windows.Forms.Panel()
        Me.Sp2 = New System.Windows.Forms.Panel()
        Me.Sp1 = New System.Windows.Forms.Panel()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        CType(Me.txtFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrames.SuspendLayout()
        CType(Me.txtFPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEnvironment.SuspendLayout()
        Me.pnlReact.SuspendLayout()
        CType(Me.txtGForce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.pnlBackScroll.SuspendLayout()
        Me.pnlMainScroll.SuspendLayout()
        CType(Me.cmdScrollDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdScrollUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMainList.SuspendLayout()
        Me.pnlParticles.SuspendLayout()
        Me.pnlGlossiness.SuspendLayout()
        CType(Me.txtGlossiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSpecLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtColorOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParticlesRefraction.SuspendLayout()
        CType(Me.txtRefractOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParticlesReflection.SuspendLayout()
        CType(Me.txtReflectOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParticlesMotionBlur.SuspendLayout()
        CType(Me.txtMotionBlurSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParticlesGlow.SuspendLayout()
        CType(Me.txtGlowOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParticlesColor.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFramesRange
        '
        Me.lblFramesRange.AutoSize = True
        Me.lblFramesRange.Location = New System.Drawing.Point(3, 61)
        Me.lblFramesRange.Name = "lblFramesRange"
        Me.lblFramesRange.Size = New System.Drawing.Size(79, 13)
        Me.lblFramesRange.TabIndex = 4
        Me.lblFramesRange.Text = "Frames range:"
        '
        'txtFrom
        '
        Me.txtFrom.BackColor = System.Drawing.Color.DimGray
        Me.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFrom.ForeColor = System.Drawing.Color.White
        Me.txtFrom.Location = New System.Drawing.Point(109, 59)
        Me.txtFrom.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(84, 22)
        Me.txtFrom.TabIndex = 5
        '
        'lblRangeTo
        '
        Me.lblRangeTo.AutoSize = True
        Me.lblRangeTo.Location = New System.Drawing.Point(200, 61)
        Me.lblRangeTo.Name = "lblRangeTo"
        Me.lblRangeTo.Size = New System.Drawing.Size(18, 13)
        Me.lblRangeTo.TabIndex = 6
        Me.lblRangeTo.Text = "to"
        '
        'txtTo
        '
        Me.txtTo.BackColor = System.Drawing.Color.DimGray
        Me.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTo.ForeColor = System.Drawing.Color.White
        Me.txtTo.Location = New System.Drawing.Point(226, 59)
        Me.txtTo.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(84, 22)
        Me.txtTo.TabIndex = 7
        Me.txtTo.Value = New Decimal(New Integer() {99, 0, 0, 0})
        '
        'lblBanground
        '
        Me.lblBanground.AutoSize = True
        Me.lblBanground.Location = New System.Drawing.Point(11, 28)
        Me.lblBanground.Name = "lblBanground"
        Me.lblBanground.Size = New System.Drawing.Size(73, 13)
        Me.lblBanground.TabIndex = 3
        Me.lblBanground.Text = "Background:"
        '
        'chkMotionBlur
        '
        Me.chkMotionBlur.AutoSize = True
        Me.chkMotionBlur.Location = New System.Drawing.Point(11, 100)
        Me.chkMotionBlur.Name = "chkMotionBlur"
        Me.chkMotionBlur.Size = New System.Drawing.Size(88, 17)
        Me.chkMotionBlur.TabIndex = 9
        Me.chkMotionBlur.Text = "Motion Blur"
        Me.chkMotionBlur.UseVisualStyleBackColor = True
        '
        'chkDrawGens
        '
        Me.chkDrawGens.AutoSize = True
        Me.chkDrawGens.Location = New System.Drawing.Point(11, 114)
        Me.chkDrawGens.Name = "chkDrawGens"
        Me.chkDrawGens.Size = New System.Drawing.Size(112, 17)
        Me.chkDrawGens.TabIndex = 1
        Me.chkDrawGens.Text = "Draw generators"
        Me.chkDrawGens.UseVisualStyleBackColor = True
        '
        'cmbCamera
        '
        Me.cmbCamera.BackColor = System.Drawing.Color.DimGray
        Me.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCamera.ForeColor = System.Drawing.Color.White
        Me.cmbCamera.FormattingEnabled = True
        Me.cmbCamera.Location = New System.Drawing.Point(109, 28)
        Me.cmbCamera.Name = "cmbCamera"
        Me.cmbCamera.Size = New System.Drawing.Size(205, 21)
        Me.cmbCamera.TabIndex = 2
        '
        'lblCamera
        '
        Me.lblCamera.AutoSize = True
        Me.lblCamera.Location = New System.Drawing.Point(3, 31)
        Me.lblCamera.Name = "lblCamera"
        Me.lblCamera.Size = New System.Drawing.Size(48, 13)
        Me.lblCamera.TabIndex = 1
        Me.lblCamera.Text = "Camera:"
        '
        'lblCameraSize
        '
        Me.lblCameraSize.AutoSize = True
        Me.lblCameraSize.Location = New System.Drawing.Point(353, 31)
        Me.lblCameraSize.Name = "lblCameraSize"
        Me.lblCameraSize.Size = New System.Drawing.Size(0, 13)
        Me.lblCameraSize.TabIndex = 3
        '
        'lblPixelFormat
        '
        Me.lblPixelFormat.AutoSize = True
        Me.lblPixelFormat.Location = New System.Drawing.Point(3, 126)
        Me.lblPixelFormat.Name = "lblPixelFormat"
        Me.lblPixelFormat.Size = New System.Drawing.Size(70, 13)
        Me.lblPixelFormat.TabIndex = 12
        Me.lblPixelFormat.Text = "Pixel format:"
        '
        'cmbPixelFormat
        '
        Me.cmbPixelFormat.BackColor = System.Drawing.Color.DimGray
        Me.cmbPixelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPixelFormat.ForeColor = System.Drawing.Color.White
        Me.cmbPixelFormat.FormattingEnabled = True
        Me.cmbPixelFormat.Items.AddRange(New Object() {"RGB 24 bits", "RGB 32 bits", "RGB 48 bits", "ARGB 16 bits", "ARGB 32 bits", "ARGB 64 bits", "ARGB 32 bits premultiplied", "ARGB 64 bits premultiplied"})
        Me.cmbPixelFormat.Location = New System.Drawing.Point(109, 123)
        Me.cmbPixelFormat.Name = "cmbPixelFormat"
        Me.cmbPixelFormat.Size = New System.Drawing.Size(201, 21)
        Me.cmbPixelFormat.TabIndex = 13
        '
        'chkDrawStatic
        '
        Me.chkDrawStatic.AutoSize = True
        Me.chkDrawStatic.Location = New System.Drawing.Point(11, 137)
        Me.chkDrawStatic.Name = "chkDrawStatic"
        Me.chkDrawStatic.Size = New System.Drawing.Size(83, 17)
        Me.chkDrawStatic.TabIndex = 2
        Me.chkDrawStatic.Text = "Draw static"
        Me.chkDrawStatic.UseVisualStyleBackColor = True
        '
        'pnlFrames
        '
        Me.pnlFrames.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlFrames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFrames.Controls.Add(Me.lblNotRecommended)
        Me.pnlFrames.Controls.Add(Me.cmbSmoothing)
        Me.pnlFrames.Controls.Add(Me.lblTotalSec)
        Me.pnlFrames.Controls.Add(Me.txtFPS)
        Me.pnlFrames.Controls.Add(Me.lblSmoothing)
        Me.pnlFrames.Controls.Add(Me.lblFPS)
        Me.pnlFrames.Controls.Add(Me.chkSkipExisting)
        Me.pnlFrames.Controls.Add(Me.cmbImageFormat)
        Me.pnlFrames.Controls.Add(Me.lblImageFormat)
        Me.pnlFrames.Controls.Add(Me.lblTotalFrames)
        Me.pnlFrames.Controls.Add(Me.cmdBrowseLocation)
        Me.pnlFrames.Controls.Add(Me.txtLocation)
        Me.pnlFrames.Controls.Add(Me.lblLocation)
        Me.pnlFrames.Controls.Add(Me.pnlFramesTitle)
        Me.pnlFrames.Controls.Add(Me.lblCamera)
        Me.pnlFrames.Controls.Add(Me.cmbCamera)
        Me.pnlFrames.Controls.Add(Me.lblCameraSize)
        Me.pnlFrames.Controls.Add(Me.cmbPixelFormat)
        Me.pnlFrames.Controls.Add(Me.lblPixelFormat)
        Me.pnlFrames.Controls.Add(Me.txtTo)
        Me.pnlFrames.Controls.Add(Me.lblRangeTo)
        Me.pnlFrames.Controls.Add(Me.lblFramesRange)
        Me.pnlFrames.Controls.Add(Me.txtFrom)
        Me.pnlFrames.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFrames.Location = New System.Drawing.Point(0, 0)
        Me.pnlFrames.Name = "pnlFrames"
        Me.pnlFrames.Size = New System.Drawing.Size(529, 276)
        Me.pnlFrames.TabIndex = 0
        '
        'lblNotRecommended
        '
        Me.lblNotRecommended.AutoSize = True
        Me.lblNotRecommended.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblNotRecommended.Location = New System.Drawing.Point(365, 126)
        Me.lblNotRecommended.Name = "lblNotRecommended"
        Me.lblNotRecommended.Size = New System.Drawing.Size(92, 13)
        Me.lblNotRecommended.TabIndex = 22
        Me.lblNotRecommended.Text = "not recommended"
        Me.lblNotRecommended.Visible = False
        '
        'cmbSmoothing
        '
        Me.cmbSmoothing.BackColor = System.Drawing.Color.DimGray
        Me.cmbSmoothing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSmoothing.ForeColor = System.Drawing.Color.White
        Me.cmbSmoothing.FormattingEnabled = True
        Me.cmbSmoothing.Items.AddRange(New Object() {"None", "Anti-alias", "High Speed", "High Quality"})
        Me.cmbSmoothing.Location = New System.Drawing.Point(109, 185)
        Me.cmbSmoothing.Name = "cmbSmoothing"
        Me.cmbSmoothing.Size = New System.Drawing.Size(201, 21)
        Me.cmbSmoothing.TabIndex = 17
        '
        'lblTotalSec
        '
        Me.lblTotalSec.AutoSize = True
        Me.lblTotalSec.Location = New System.Drawing.Point(365, 93)
        Me.lblTotalSec.Name = "lblTotalSec"
        Me.lblTotalSec.Size = New System.Drawing.Size(35, 13)
        Me.lblTotalSec.TabIndex = 11
        Me.lblTotalSec.Text = "4 sec."
        '
        'txtFPS
        '
        Me.txtFPS.BackColor = System.Drawing.Color.DimGray
        Me.txtFPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFPS.DecimalPlaces = 3
        Me.txtFPS.ForeColor = System.Drawing.Color.White
        Me.txtFPS.Location = New System.Drawing.Point(109, 91)
        Me.txtFPS.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.txtFPS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtFPS.Name = "txtFPS"
        Me.txtFPS.Size = New System.Drawing.Size(201, 22)
        Me.txtFPS.TabIndex = 10
        Me.txtFPS.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'lblSmoothing
        '
        Me.lblSmoothing.AutoSize = True
        Me.lblSmoothing.Location = New System.Drawing.Point(3, 188)
        Me.lblSmoothing.Name = "lblSmoothing"
        Me.lblSmoothing.Size = New System.Drawing.Size(67, 13)
        Me.lblSmoothing.TabIndex = 16
        Me.lblSmoothing.Text = "Smoothing:"
        '
        'lblFPS
        '
        Me.lblFPS.AutoSize = True
        Me.lblFPS.Location = New System.Drawing.Point(3, 93)
        Me.lblFPS.Name = "lblFPS"
        Me.lblFPS.Size = New System.Drawing.Size(28, 13)
        Me.lblFPS.TabIndex = 9
        Me.lblFPS.Text = "FPS:"
        '
        'chkSkipExisting
        '
        Me.chkSkipExisting.AutoSize = True
        Me.chkSkipExisting.Location = New System.Drawing.Point(6, 252)
        Me.chkSkipExisting.Name = "chkSkipExisting"
        Me.chkSkipExisting.Size = New System.Drawing.Size(128, 17)
        Me.chkSkipExisting.TabIndex = 21
        Me.chkSkipExisting.Text = "Skip existing frames"
        Me.chkSkipExisting.UseVisualStyleBackColor = True
        '
        'cmbImageFormat
        '
        Me.cmbImageFormat.BackColor = System.Drawing.Color.DimGray
        Me.cmbImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbImageFormat.ForeColor = System.Drawing.Color.White
        Me.cmbImageFormat.FormattingEnabled = True
        Me.cmbImageFormat.Items.AddRange(New Object() {"PNG - Portable Network Graphics", "TIFF - Tagged Image File Format", "DIB - Device Independent Bitmap", "JPEG - Joint Photographic Experts Group", "GIF - Graphics Interchange Format"})
        Me.cmbImageFormat.Location = New System.Drawing.Point(109, 154)
        Me.cmbImageFormat.Name = "cmbImageFormat"
        Me.cmbImageFormat.Size = New System.Drawing.Size(201, 21)
        Me.cmbImageFormat.TabIndex = 15
        '
        'lblImageFormat
        '
        Me.lblImageFormat.AutoSize = True
        Me.lblImageFormat.Location = New System.Drawing.Point(3, 157)
        Me.lblImageFormat.Name = "lblImageFormat"
        Me.lblImageFormat.Size = New System.Drawing.Size(78, 13)
        Me.lblImageFormat.TabIndex = 14
        Me.lblImageFormat.Text = "Image format:"
        '
        'lblTotalFrames
        '
        Me.lblTotalFrames.AutoSize = True
        Me.lblTotalFrames.Location = New System.Drawing.Point(365, 61)
        Me.lblTotalFrames.Name = "lblTotalFrames"
        Me.lblTotalFrames.Size = New System.Drawing.Size(62, 13)
        Me.lblTotalFrames.TabIndex = 8
        Me.lblTotalFrames.Text = "100 frames"
        '
        'cmdBrowseLocation
        '
        Me.cmdBrowseLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdBrowseLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdBrowseLocation.Location = New System.Drawing.Point(492, 216)
        Me.cmdBrowseLocation.Name = "cmdBrowseLocation"
        Me.cmdBrowseLocation.Size = New System.Drawing.Size(30, 22)
        Me.cmdBrowseLocation.TabIndex = 20
        Me.cmdBrowseLocation.Text = "..."
        Me.cmdBrowseLocation.UseVisualStyleBackColor = False
        '
        'txtLocation
        '
        Me.txtLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.txtLocation.BackColor = System.Drawing.Color.DimGray
        Me.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLocation.Location = New System.Drawing.Point(109, 216)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(379, 22)
        Me.txtLocation.TabIndex = 19
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(3, 218)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(54, 13)
        Me.lblLocation.TabIndex = 18
        Me.lblLocation.Text = "Location:"
        '
        'pnlFramesTitle
        '
        Me.pnlFramesTitle.BackgroundImage = Global.ParticleFX.My.Resources.Resources.MainMenuLow
        Me.pnlFramesTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlFramesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFramesTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlFramesTitle.Name = "pnlFramesTitle"
        Me.pnlFramesTitle.Size = New System.Drawing.Size(527, 20)
        Me.pnlFramesTitle.TabIndex = 0
        '
        'pnlEnvironment
        '
        Me.pnlEnvironment.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlEnvironment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEnvironment.Controls.Add(Me.cmdSolidBG)
        Me.pnlEnvironment.Controls.Add(Me.cmdImageBG)
        Me.pnlEnvironment.Controls.Add(Me.txtImageBG)
        Me.pnlEnvironment.Controls.Add(Me.optImageBG)
        Me.pnlEnvironment.Controls.Add(Me.optSolidBG)
        Me.pnlEnvironment.Controls.Add(Me.optTransparentBG)
        Me.pnlEnvironment.Controls.Add(Me.lblBanground)
        Me.pnlEnvironment.Controls.Add(Me.pnlEnvironmentTitle)
        Me.pnlEnvironment.Controls.Add(Me.chkDrawGens)
        Me.pnlEnvironment.Controls.Add(Me.chkDrawStatic)
        Me.pnlEnvironment.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEnvironment.Location = New System.Drawing.Point(0, 280)
        Me.pnlEnvironment.Name = "pnlEnvironment"
        Me.pnlEnvironment.Size = New System.Drawing.Size(529, 161)
        Me.pnlEnvironment.TabIndex = 1
        '
        'cmdSolidBG
        '
        Me.cmdSolidBG.BackColor = System.Drawing.Color.White
        Me.cmdSolidBG.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSolidBG.Location = New System.Drawing.Point(180, 53)
        Me.cmdSolidBG.Name = "cmdSolidBG"
        Me.cmdSolidBG.Size = New System.Drawing.Size(32, 22)
        Me.cmdSolidBG.TabIndex = 23
        Me.cmdSolidBG.UseVisualStyleBackColor = False
        Me.cmdSolidBG.Visible = False
        '
        'cmdImageBG
        '
        Me.cmdImageBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdImageBG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdImageBG.Location = New System.Drawing.Point(492, 80)
        Me.cmdImageBG.Name = "cmdImageBG"
        Me.cmdImageBG.Size = New System.Drawing.Size(30, 22)
        Me.cmdImageBG.TabIndex = 22
        Me.cmdImageBG.Text = "..."
        Me.cmdImageBG.UseVisualStyleBackColor = False
        Me.cmdImageBG.Visible = False
        '
        'txtImageBG
        '
        Me.txtImageBG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtImageBG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtImageBG.BackColor = System.Drawing.Color.DimGray
        Me.txtImageBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImageBG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtImageBG.Location = New System.Drawing.Point(180, 80)
        Me.txtImageBG.Name = "txtImageBG"
        Me.txtImageBG.Size = New System.Drawing.Size(308, 22)
        Me.txtImageBG.TabIndex = 21
        Me.txtImageBG.Visible = False
        '
        'optImageBG
        '
        Me.optImageBG.AutoSize = True
        Me.optImageBG.Location = New System.Drawing.Point(90, 80)
        Me.optImageBG.Name = "optImageBG"
        Me.optImageBG.Size = New System.Drawing.Size(77, 17)
        Me.optImageBG.TabIndex = 8
        Me.optImageBG.Text = "File image"
        Me.optImageBG.UseVisualStyleBackColor = True
        '
        'optSolidBG
        '
        Me.optSolidBG.AutoSize = True
        Me.optSolidBG.Location = New System.Drawing.Point(90, 53)
        Me.optSolidBG.Name = "optSolidBG"
        Me.optSolidBG.Size = New System.Drawing.Size(82, 17)
        Me.optSolidBG.TabIndex = 7
        Me.optSolidBG.Text = "Solid Color"
        Me.optSolidBG.UseVisualStyleBackColor = True
        '
        'optTransparentBG
        '
        Me.optTransparentBG.AutoSize = True
        Me.optTransparentBG.Checked = True
        Me.optTransparentBG.Location = New System.Drawing.Point(90, 26)
        Me.optTransparentBG.Name = "optTransparentBG"
        Me.optTransparentBG.Size = New System.Drawing.Size(86, 17)
        Me.optTransparentBG.TabIndex = 6
        Me.optTransparentBG.TabStop = True
        Me.optTransparentBG.Text = "Transparent"
        Me.optTransparentBG.UseVisualStyleBackColor = True
        '
        'pnlEnvironmentTitle
        '
        Me.pnlEnvironmentTitle.BackgroundImage = CType(resources.GetObject("pnlEnvironmentTitle.BackgroundImage"), System.Drawing.Image)
        Me.pnlEnvironmentTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlEnvironmentTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEnvironmentTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlEnvironmentTitle.Name = "pnlEnvironmentTitle"
        Me.pnlEnvironmentTitle.Size = New System.Drawing.Size(527, 20)
        Me.pnlEnvironmentTitle.TabIndex = 0
        '
        'pnlReact
        '
        Me.pnlReact.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlReact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlReact.Controls.Add(Me.chkReactEachOther)
        Me.pnlReact.Controls.Add(Me.lblGForcePPF)
        Me.pnlReact.Controls.Add(Me.txtGForce)
        Me.pnlReact.Controls.Add(Me.cmbReactor)
        Me.pnlReact.Controls.Add(Me.lblReactor)
        Me.pnlReact.Controls.Add(Me.pnlReactTitle)
        Me.pnlReact.Controls.Add(Me.lblGForce)
        Me.pnlReact.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReact.Location = New System.Drawing.Point(0, 679)
        Me.pnlReact.Name = "pnlReact"
        Me.pnlReact.Size = New System.Drawing.Size(529, 111)
        Me.pnlReact.TabIndex = 23
        '
        'chkReactEachOther
        '
        Me.chkReactEachOther.AutoSize = True
        Me.chkReactEachOther.Checked = True
        Me.chkReactEachOther.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReactEachOther.Location = New System.Drawing.Point(11, 84)
        Me.chkReactEachOther.Name = "chkReactEachOther"
        Me.chkReactEachOther.Size = New System.Drawing.Size(154, 17)
        Me.chkReactEachOther.TabIndex = 34
        Me.chkReactEachOther.Text = "Particles react each other"
        Me.chkReactEachOther.UseVisualStyleBackColor = True
        '
        'lblGForcePPF
        '
        Me.lblGForcePPF.AutoSize = True
        Me.lblGForcePPF.Location = New System.Drawing.Point(224, 57)
        Me.lblGForcePPF.Name = "lblGForcePPF"
        Me.lblGForcePPF.Size = New System.Drawing.Size(69, 13)
        Me.lblGForcePPF.TabIndex = 33
        Me.lblGForcePPF.Text = "pixels/frame"
        '
        'txtGForce
        '
        Me.txtGForce.BackColor = System.Drawing.Color.DimGray
        Me.txtGForce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGForce.DecimalPlaces = 3
        Me.txtGForce.ForeColor = System.Drawing.Color.White
        Me.txtGForce.Location = New System.Drawing.Point(109, 55)
        Me.txtGForce.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.txtGForce.Name = "txtGForce"
        Me.txtGForce.Size = New System.Drawing.Size(109, 22)
        Me.txtGForce.TabIndex = 32
        Me.txtGForce.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'cmbReactor
        '
        Me.cmbReactor.BackColor = System.Drawing.Color.DimGray
        Me.cmbReactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReactor.ForeColor = System.Drawing.Color.White
        Me.cmbReactor.FormattingEnabled = True
        Me.cmbReactor.Items.AddRange(New Object() {"Reactor 0.2b", "Reactor 1.0", "Space Reactor"})
        Me.cmbReactor.Location = New System.Drawing.Point(109, 28)
        Me.cmbReactor.Name = "cmbReactor"
        Me.cmbReactor.Size = New System.Drawing.Size(109, 21)
        Me.cmbReactor.TabIndex = 30
        '
        'lblReactor
        '
        Me.lblReactor.AutoSize = True
        Me.lblReactor.Location = New System.Drawing.Point(8, 31)
        Me.lblReactor.Name = "lblReactor"
        Me.lblReactor.Size = New System.Drawing.Size(88, 13)
        Me.lblReactor.TabIndex = 29
        Me.lblReactor.Text = "Reactor Engine:"
        '
        'pnlReactTitle
        '
        Me.pnlReactTitle.BackgroundImage = CType(resources.GetObject("pnlReactTitle.BackgroundImage"), System.Drawing.Image)
        Me.pnlReactTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlReactTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReactTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlReactTitle.Name = "pnlReactTitle"
        Me.pnlReactTitle.Size = New System.Drawing.Size(527, 20)
        Me.pnlReactTitle.TabIndex = 20
        '
        'lblGForce
        '
        Me.lblGForce.AutoSize = True
        Me.lblGForce.Location = New System.Drawing.Point(8, 57)
        Me.lblGForce.Name = "lblGForce"
        Me.lblGForce.Size = New System.Drawing.Size(50, 13)
        Me.lblGForce.TabIndex = 27
        Me.lblGForce.Text = "G-Force:"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.pnlBackScroll)
        Me.pnlMain.Controls.Add(Me.pnlMainList)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(547, 844)
        Me.pnlMain.TabIndex = 24
        '
        'pnlBackScroll
        '
        Me.pnlBackScroll.Controls.Add(Me.pnlMainScroll)
        Me.pnlBackScroll.Controls.Add(Me.cmdScrollDown)
        Me.pnlBackScroll.Controls.Add(Me.cmdScrollUp)
        Me.pnlBackScroll.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBackScroll.Location = New System.Drawing.Point(529, 0)
        Me.pnlBackScroll.Name = "pnlBackScroll"
        Me.pnlBackScroll.Size = New System.Drawing.Size(18, 844)
        Me.pnlBackScroll.TabIndex = 26
        '
        'pnlMainScroll
        '
        Me.pnlMainScroll.BackgroundImage = Global.ParticleFX.My.Resources.Resources.ScrollBG
        Me.pnlMainScroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMainScroll.Controls.Add(Me.cmdScroll)
        Me.pnlMainScroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainScroll.Location = New System.Drawing.Point(0, 18)
        Me.pnlMainScroll.Name = "pnlMainScroll"
        Me.pnlMainScroll.Size = New System.Drawing.Size(18, 808)
        Me.pnlMainScroll.TabIndex = 24
        '
        'cmdScroll
        '
        Me.cmdScroll.BackgroundImage = Global.ParticleFX.My.Resources.Resources.Scroll
        Me.cmdScroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdScroll.Location = New System.Drawing.Point(0, 0)
        Me.cmdScroll.Name = "cmdScroll"
        Me.cmdScroll.Size = New System.Drawing.Size(18, 40)
        Me.cmdScroll.TabIndex = 1
        '
        'cmdScrollDown
        '
        Me.cmdScrollDown.BackgroundImage = CType(resources.GetObject("cmdScrollDown.BackgroundImage"), System.Drawing.Image)
        Me.cmdScrollDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdScrollDown.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdScrollDown.Image = Global.ParticleFX.My.Resources.Resources.ScrollDown
        Me.cmdScrollDown.Location = New System.Drawing.Point(0, 826)
        Me.cmdScrollDown.Name = "cmdScrollDown"
        Me.cmdScrollDown.Size = New System.Drawing.Size(18, 18)
        Me.cmdScrollDown.TabIndex = 4
        Me.cmdScrollDown.TabStop = False
        '
        'cmdScrollUp
        '
        Me.cmdScrollUp.BackgroundImage = Global.ParticleFX.My.Resources.Resources.ScrollBG
        Me.cmdScrollUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdScrollUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdScrollUp.Image = Global.ParticleFX.My.Resources.Resources.ScrollUp
        Me.cmdScrollUp.Location = New System.Drawing.Point(0, 0)
        Me.cmdScrollUp.Name = "cmdScrollUp"
        Me.cmdScrollUp.Size = New System.Drawing.Size(18, 18)
        Me.cmdScrollUp.TabIndex = 3
        Me.cmdScrollUp.TabStop = False
        '
        'pnlMainList
        '
        Me.pnlMainList.Controls.Add(Me.pnlReact)
        Me.pnlMainList.Controls.Add(Me.Sp3)
        Me.pnlMainList.Controls.Add(Me.pnlParticles)
        Me.pnlMainList.Controls.Add(Me.Sp2)
        Me.pnlMainList.Controls.Add(Me.pnlEnvironment)
        Me.pnlMainList.Controls.Add(Me.Sp1)
        Me.pnlMainList.Controls.Add(Me.pnlFrames)
        Me.pnlMainList.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainList.Name = "pnlMainList"
        Me.pnlMainList.Size = New System.Drawing.Size(529, 838)
        Me.pnlMainList.TabIndex = 25
        '
        'Sp3
        '
        Me.Sp3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Sp3.Location = New System.Drawing.Point(0, 675)
        Me.Sp3.Name = "Sp3"
        Me.Sp3.Size = New System.Drawing.Size(529, 4)
        Me.Sp3.TabIndex = 27
        '
        'pnlParticles
        '
        Me.pnlParticles.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlParticles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlParticles.Controls.Add(Me.pnlGlossiness)
        Me.pnlParticles.Controls.Add(Me.chkGlossiness)
        Me.pnlParticles.Controls.Add(Me.optRefract)
        Me.pnlParticles.Controls.Add(Me.Label4)
        Me.pnlParticles.Controls.Add(Me.optReflect)
        Me.pnlParticles.Controls.Add(Me.txtColorOpacity)
        Me.pnlParticles.Controls.Add(Me.Label7)
        Me.pnlParticles.Controls.Add(Me.optSolidColor)
        Me.pnlParticles.Controls.Add(Me.lblExitColor)
        Me.pnlParticles.Controls.Add(Me.cmdExitColor)
        Me.pnlParticles.Controls.Add(Me.pnlParticlesRefraction)
        Me.pnlParticles.Controls.Add(Me.pnlParticlesReflection)
        Me.pnlParticles.Controls.Add(Me.pnlParticlesMotionBlur)
        Me.pnlParticles.Controls.Add(Me.pnlParticlesGlow)
        Me.pnlParticles.Controls.Add(Me.chkColor)
        Me.pnlParticles.Controls.Add(Me.pnlParticlesColor)
        Me.pnlParticles.Controls.Add(Me.chkGlow)
        Me.pnlParticles.Controls.Add(Me.pnlParticlesTitle)
        Me.pnlParticles.Controls.Add(Me.chkMotionBlur)
        Me.pnlParticles.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlParticles.Location = New System.Drawing.Point(0, 445)
        Me.pnlParticles.Name = "pnlParticles"
        Me.pnlParticles.Size = New System.Drawing.Size(529, 230)
        Me.pnlParticles.TabIndex = 2
        '
        'pnlGlossiness
        '
        Me.pnlGlossiness.Controls.Add(Me.cmdPreviewGloss)
        Me.pnlGlossiness.Controls.Add(Me.Label13)
        Me.pnlGlossiness.Controls.Add(Me.txtGlossiness)
        Me.pnlGlossiness.Controls.Add(Me.Label14)
        Me.pnlGlossiness.Controls.Add(Me.Label11)
        Me.pnlGlossiness.Controls.Add(Me.txtSpecLevel)
        Me.pnlGlossiness.Controls.Add(Me.cmdGlossColor)
        Me.pnlGlossiness.Enabled = False
        Me.pnlGlossiness.Location = New System.Drawing.Point(116, 50)
        Me.pnlGlossiness.Name = "pnlGlossiness"
        Me.pnlGlossiness.Size = New System.Drawing.Size(406, 22)
        Me.pnlGlossiness.TabIndex = 6
        '
        'cmdPreviewGloss
        '
        Me.cmdPreviewGloss.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPreviewGloss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdPreviewGloss.Location = New System.Drawing.Point(350, 0)
        Me.cmdPreviewGloss.Name = "cmdPreviewGloss"
        Me.cmdPreviewGloss.Size = New System.Drawing.Size(56, 22)
        Me.cmdPreviewGloss.TabIndex = 55
        Me.cmdPreviewGloss.Text = "More"
        Me.cmdPreviewGloss.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(192, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Glossiness:"
        '
        'txtGlossiness
        '
        Me.txtGlossiness.BackColor = System.Drawing.Color.DimGray
        Me.txtGlossiness.ForeColor = System.Drawing.Color.White
        Me.txtGlossiness.Location = New System.Drawing.Point(258, 0)
        Me.txtGlossiness.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtGlossiness.Name = "txtGlossiness"
        Me.txtGlossiness.Size = New System.Drawing.Size(47, 22)
        Me.txtGlossiness.TabIndex = 9
        Me.txtGlossiness.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(306, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(54, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Spec. Level:"
        '
        'txtSpecLevel
        '
        Me.txtSpecLevel.BackColor = System.Drawing.Color.DimGray
        Me.txtSpecLevel.ForeColor = System.Drawing.Color.White
        Me.txtSpecLevel.Location = New System.Drawing.Point(121, 0)
        Me.txtSpecLevel.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.txtSpecLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtSpecLevel.Name = "txtSpecLevel"
        Me.txtSpecLevel.Size = New System.Drawing.Size(52, 22)
        Me.txtSpecLevel.TabIndex = 6
        Me.txtSpecLevel.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'cmdGlossColor
        '
        Me.cmdGlossColor.BackColor = System.Drawing.Color.White
        Me.cmdGlossColor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGlossColor.Location = New System.Drawing.Point(12, 0)
        Me.cmdGlossColor.Name = "cmdGlossColor"
        Me.cmdGlossColor.Size = New System.Drawing.Size(32, 22)
        Me.cmdGlossColor.TabIndex = 1
        Me.cmdGlossColor.UseVisualStyleBackColor = False
        '
        'chkGlossiness
        '
        Me.chkGlossiness.AutoSize = True
        Me.chkGlossiness.Location = New System.Drawing.Point(11, 52)
        Me.chkGlossiness.Name = "chkGlossiness"
        Me.chkGlossiness.Size = New System.Drawing.Size(110, 17)
        Me.chkGlossiness.TabIndex = 5
        Me.chkGlossiness.Text = "Spec. Highlights"
        Me.chkGlossiness.UseVisualStyleBackColor = True
        '
        'optRefract
        '
        Me.optRefract.AutoSize = True
        Me.optRefract.Location = New System.Drawing.Point(11, 178)
        Me.optRefract.Name = "optRefract"
        Me.optRefract.Size = New System.Drawing.Size(61, 17)
        Me.optRefract.TabIndex = 14
        Me.optRefract.Text = "Refract"
        Me.optRefract.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Opacity:"
        '
        'optReflect
        '
        Me.optReflect.AutoSize = True
        Me.optReflect.Location = New System.Drawing.Point(11, 153)
        Me.optReflect.Name = "optReflect"
        Me.optReflect.Size = New System.Drawing.Size(61, 17)
        Me.optReflect.TabIndex = 12
        Me.optReflect.Text = "Refrect"
        Me.optReflect.UseVisualStyleBackColor = True
        '
        'txtColorOpacity
        '
        Me.txtColorOpacity.BackColor = System.Drawing.Color.DimGray
        Me.txtColorOpacity.ForeColor = System.Drawing.Color.White
        Me.txtColorOpacity.Location = New System.Drawing.Point(237, 26)
        Me.txtColorOpacity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtColorOpacity.Name = "txtColorOpacity"
        Me.txtColorOpacity.Size = New System.Drawing.Size(52, 22)
        Me.txtColorOpacity.TabIndex = 3
        Me.txtColorOpacity.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(289, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "%"
        '
        'optSolidColor
        '
        Me.optSolidColor.AutoSize = True
        Me.optSolidColor.Checked = True
        Me.optSolidColor.Location = New System.Drawing.Point(11, 130)
        Me.optSolidColor.Name = "optSolidColor"
        Me.optSolidColor.Size = New System.Drawing.Size(82, 17)
        Me.optSolidColor.TabIndex = 11
        Me.optSolidColor.TabStop = True
        Me.optSolidColor.Text = "Solid Color"
        Me.optSolidColor.UseVisualStyleBackColor = True
        '
        'lblExitColor
        '
        Me.lblExitColor.AutoSize = True
        Me.lblExitColor.Enabled = False
        Me.lblExitColor.Location = New System.Drawing.Point(27, 203)
        Me.lblExitColor.Name = "lblExitColor"
        Me.lblExitColor.Size = New System.Drawing.Size(57, 13)
        Me.lblExitColor.TabIndex = 16
        Me.lblExitColor.Text = "Exit color:"
        '
        'cmdExitColor
        '
        Me.cmdExitColor.BackColor = System.Drawing.Color.Black
        Me.cmdExitColor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExitColor.Enabled = False
        Me.cmdExitColor.Location = New System.Drawing.Point(128, 201)
        Me.cmdExitColor.Name = "cmdExitColor"
        Me.cmdExitColor.Size = New System.Drawing.Size(32, 22)
        Me.cmdExitColor.TabIndex = 17
        Me.cmdExitColor.UseVisualStyleBackColor = False
        '
        'pnlParticlesRefraction
        '
        Me.pnlParticlesRefraction.Controls.Add(Me.txtRefractOpacity)
        Me.pnlParticlesRefraction.Controls.Add(Me.Label2)
        Me.pnlParticlesRefraction.Controls.Add(Me.Label3)
        Me.pnlParticlesRefraction.Controls.Add(Me.Label9)
        Me.pnlParticlesRefraction.Controls.Add(Me.txtIOR)
        Me.pnlParticlesRefraction.Controls.Add(Me.cmdIOR)
        Me.pnlParticlesRefraction.Enabled = False
        Me.pnlParticlesRefraction.Location = New System.Drawing.Point(116, 177)
        Me.pnlParticlesRefraction.Name = "pnlParticlesRefraction"
        Me.pnlParticlesRefraction.Size = New System.Drawing.Size(406, 22)
        Me.pnlParticlesRefraction.TabIndex = 15
        '
        'txtRefractOpacity
        '
        Me.txtRefractOpacity.BackColor = System.Drawing.Color.DimGray
        Me.txtRefractOpacity.ForeColor = System.Drawing.Color.White
        Me.txtRefractOpacity.Location = New System.Drawing.Point(121, 0)
        Me.txtRefractOpacity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtRefractOpacity.Name = "txtRefractOpacity"
        Me.txtRefractOpacity.Size = New System.Drawing.Size(52, 22)
        Me.txtRefractOpacity.TabIndex = 49
        Me.txtRefractOpacity.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Opacity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(227, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "IOR:"
        '
        'txtIOR
        '
        Me.txtIOR.BackColor = System.Drawing.Color.DimGray
        Me.txtIOR.DecimalPlaces = 5
        Me.txtIOR.ForeColor = System.Drawing.Color.White
        Me.txtIOR.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txtIOR.Location = New System.Drawing.Point(258, 0)
        Me.txtIOR.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txtIOR.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txtIOR.Name = "txtIOR"
        Me.txtIOR.Size = New System.Drawing.Size(62, 22)
        Me.txtIOR.TabIndex = 53
        Me.txtIOR.Value = New Decimal(New Integer() {14, 0, 0, 65536})
        '
        'cmdIOR
        '
        Me.cmdIOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdIOR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdIOR.Location = New System.Drawing.Point(322, 0)
        Me.cmdIOR.Name = "cmdIOR"
        Me.cmdIOR.Size = New System.Drawing.Size(30, 22)
        Me.cmdIOR.TabIndex = 54
        Me.cmdIOR.Text = "..."
        Me.cmdIOR.UseVisualStyleBackColor = False
        '
        'pnlParticlesReflection
        '
        Me.pnlParticlesReflection.Controls.Add(Me.txtReflectOpacity)
        Me.pnlParticlesReflection.Controls.Add(Me.Label1)
        Me.pnlParticlesReflection.Controls.Add(Me.Label8)
        Me.pnlParticlesReflection.Enabled = False
        Me.pnlParticlesReflection.Location = New System.Drawing.Point(116, 152)
        Me.pnlParticlesReflection.Name = "pnlParticlesReflection"
        Me.pnlParticlesReflection.Size = New System.Drawing.Size(406, 22)
        Me.pnlParticlesReflection.TabIndex = 13
        '
        'txtReflectOpacity
        '
        Me.txtReflectOpacity.BackColor = System.Drawing.Color.DimGray
        Me.txtReflectOpacity.ForeColor = System.Drawing.Color.White
        Me.txtReflectOpacity.Location = New System.Drawing.Point(121, 0)
        Me.txtReflectOpacity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtReflectOpacity.Name = "txtReflectOpacity"
        Me.txtReflectOpacity.Size = New System.Drawing.Size(52, 22)
        Me.txtReflectOpacity.TabIndex = 46
        Me.txtReflectOpacity.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Opacity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(173, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "%"
        '
        'pnlParticlesMotionBlur
        '
        Me.pnlParticlesMotionBlur.Controls.Add(Me.txtMotionBlurSamples)
        Me.pnlParticlesMotionBlur.Controls.Add(Me.Label10)
        Me.pnlParticlesMotionBlur.Enabled = False
        Me.pnlParticlesMotionBlur.Location = New System.Drawing.Point(116, 98)
        Me.pnlParticlesMotionBlur.Name = "pnlParticlesMotionBlur"
        Me.pnlParticlesMotionBlur.Size = New System.Drawing.Size(406, 22)
        Me.pnlParticlesMotionBlur.TabIndex = 10
        '
        'txtMotionBlurSamples
        '
        Me.txtMotionBlurSamples.BackColor = System.Drawing.Color.DimGray
        Me.txtMotionBlurSamples.ForeColor = System.Drawing.Color.White
        Me.txtMotionBlurSamples.Location = New System.Drawing.Point(121, 0)
        Me.txtMotionBlurSamples.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.txtMotionBlurSamples.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtMotionBlurSamples.Name = "txtMotionBlurSamples"
        Me.txtMotionBlurSamples.Size = New System.Drawing.Size(52, 22)
        Me.txtMotionBlurSamples.TabIndex = 42
        Me.txtMotionBlurSamples.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(67, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Samples:"
        '
        'pnlParticlesGlow
        '
        Me.pnlParticlesGlow.Controls.Add(Me.cmdGlowColor)
        Me.pnlParticlesGlow.Controls.Add(Me.Label5)
        Me.pnlParticlesGlow.Controls.Add(Me.txtGlowOpacity)
        Me.pnlParticlesGlow.Controls.Add(Me.Label6)
        Me.pnlParticlesGlow.Enabled = False
        Me.pnlParticlesGlow.Location = New System.Drawing.Point(116, 74)
        Me.pnlParticlesGlow.Name = "pnlParticlesGlow"
        Me.pnlParticlesGlow.Size = New System.Drawing.Size(406, 22)
        Me.pnlParticlesGlow.TabIndex = 8
        '
        'cmdGlowColor
        '
        Me.cmdGlowColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdGlowColor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGlowColor.Location = New System.Drawing.Point(12, 1)
        Me.cmdGlowColor.Name = "cmdGlowColor"
        Me.cmdGlowColor.Size = New System.Drawing.Size(32, 22)
        Me.cmdGlowColor.TabIndex = 6
        Me.cmdGlowColor.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Opacity:"
        '
        'txtGlowOpacity
        '
        Me.txtGlowOpacity.BackColor = System.Drawing.Color.DimGray
        Me.txtGlowOpacity.ForeColor = System.Drawing.Color.White
        Me.txtGlowOpacity.Location = New System.Drawing.Point(121, 0)
        Me.txtGlowOpacity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtGlowOpacity.Name = "txtGlowOpacity"
        Me.txtGlowOpacity.Size = New System.Drawing.Size(52, 22)
        Me.txtGlowOpacity.TabIndex = 8
        Me.txtGlowOpacity.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(173, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "%"
        '
        'chkColor
        '
        Me.chkColor.AutoSize = True
        Me.chkColor.Location = New System.Drawing.Point(11, 29)
        Me.chkColor.Name = "chkColor"
        Me.chkColor.Size = New System.Drawing.Size(89, 17)
        Me.chkColor.TabIndex = 0
        Me.chkColor.Text = "Global color"
        Me.chkColor.UseVisualStyleBackColor = True
        '
        'pnlParticlesColor
        '
        Me.pnlParticlesColor.Controls.Add(Me.cmdColor)
        Me.pnlParticlesColor.Enabled = False
        Me.pnlParticlesColor.Location = New System.Drawing.Point(116, 24)
        Me.pnlParticlesColor.Name = "pnlParticlesColor"
        Me.pnlParticlesColor.Size = New System.Drawing.Size(42, 24)
        Me.pnlParticlesColor.TabIndex = 1
        '
        'cmdColor
        '
        Me.cmdColor.BackColor = System.Drawing.Color.Blue
        Me.cmdColor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdColor.Location = New System.Drawing.Point(12, 1)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.Size = New System.Drawing.Size(32, 22)
        Me.cmdColor.TabIndex = 0
        Me.cmdColor.UseVisualStyleBackColor = False
        '
        'chkGlow
        '
        Me.chkGlow.AutoSize = True
        Me.chkGlow.Location = New System.Drawing.Point(11, 76)
        Me.chkGlow.Name = "chkGlow"
        Me.chkGlow.Size = New System.Drawing.Size(53, 17)
        Me.chkGlow.TabIndex = 7
        Me.chkGlow.Text = "Glow"
        Me.chkGlow.UseVisualStyleBackColor = True
        '
        'pnlParticlesTitle
        '
        Me.pnlParticlesTitle.BackgroundImage = CType(resources.GetObject("pnlParticlesTitle.BackgroundImage"), System.Drawing.Image)
        Me.pnlParticlesTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlParticlesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlParticlesTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlParticlesTitle.Name = "pnlParticlesTitle"
        Me.pnlParticlesTitle.Size = New System.Drawing.Size(527, 20)
        Me.pnlParticlesTitle.TabIndex = 0
        '
        'Sp2
        '
        Me.Sp2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Sp2.Location = New System.Drawing.Point(0, 441)
        Me.Sp2.Name = "Sp2"
        Me.Sp2.Size = New System.Drawing.Size(529, 4)
        Me.Sp2.TabIndex = 24
        '
        'Sp1
        '
        Me.Sp1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Sp1.Location = New System.Drawing.Point(0, 276)
        Me.Sp1.Name = "Sp1"
        Me.Sp1.Size = New System.Drawing.Size(529, 4)
        Me.Sp1.TabIndex = 25
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.pnlButtons.Controls.Add(Me.cmdApply)
        Me.pnlButtons.Controls.Add(Me.cmdCancel)
        Me.pnlButtons.Controls.Add(Me.cmdOK)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(0, 844)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(547, 38)
        Me.pnlButtons.TabIndex = 25
        '
        'cmdApply
        '
        Me.cmdApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdApply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdApply.Location = New System.Drawing.Point(317, 3)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 23)
        Me.cmdApply.TabIndex = 2
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdCancel.Location = New System.Drawing.Point(236, 3)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdOK.Location = New System.Drawing.Point(155, 3)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'frmRender
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(547, 882)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlButtons)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRender"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Render setup"
        CType(Me.txtFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrames.ResumeLayout(False)
        Me.pnlFrames.PerformLayout()
        CType(Me.txtFPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEnvironment.ResumeLayout(False)
        Me.pnlEnvironment.PerformLayout()
        Me.pnlReact.ResumeLayout(False)
        Me.pnlReact.PerformLayout()
        CType(Me.txtGForce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlBackScroll.ResumeLayout(False)
        Me.pnlMainScroll.ResumeLayout(False)
        CType(Me.cmdScrollDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdScrollUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMainList.ResumeLayout(False)
        Me.pnlParticles.ResumeLayout(False)
        Me.pnlParticles.PerformLayout()
        Me.pnlGlossiness.ResumeLayout(False)
        Me.pnlGlossiness.PerformLayout()
        CType(Me.txtGlossiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSpecLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtColorOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlParticlesRefraction.ResumeLayout(False)
        Me.pnlParticlesRefraction.PerformLayout()
        CType(Me.txtRefractOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlParticlesReflection.ResumeLayout(False)
        Me.pnlParticlesReflection.PerformLayout()
        CType(Me.txtReflectOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlParticlesMotionBlur.ResumeLayout(False)
        Me.pnlParticlesMotionBlur.PerformLayout()
        CType(Me.txtMotionBlurSamples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlParticlesGlow.ResumeLayout(False)
        Me.pnlParticlesGlow.PerformLayout()
        CType(Me.txtGlowOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlParticlesColor.ResumeLayout(False)
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFramesRange As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRangeTo As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblBanground As System.Windows.Forms.Label
    Friend WithEvents chkMotionBlur As System.Windows.Forms.CheckBox
    Friend WithEvents chkDrawGens As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCamera As System.Windows.Forms.ComboBox
    Friend WithEvents lblCamera As System.Windows.Forms.Label
    Friend WithEvents lblCameraSize As System.Windows.Forms.Label
    Friend WithEvents lblPixelFormat As System.Windows.Forms.Label
    Friend WithEvents cmbPixelFormat As System.Windows.Forms.ComboBox
    Friend WithEvents chkDrawStatic As System.Windows.Forms.CheckBox
    Friend WithEvents pnlFrames As System.Windows.Forms.Panel
    Friend WithEvents pnlFramesTitle As System.Windows.Forms.Panel
    Friend WithEvents pnlEnvironment As System.Windows.Forms.Panel
    Friend WithEvents pnlEnvironmentTitle As System.Windows.Forms.Panel
    Friend WithEvents pnlReact As System.Windows.Forms.Panel
    Friend WithEvents pnlReactTitle As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlMainList As System.Windows.Forms.Panel
    Friend WithEvents pnlMainScroll As System.Windows.Forms.Panel
    Friend WithEvents cmdScroll As System.Windows.Forms.Panel
    Friend WithEvents Sp2 As System.Windows.Forms.Panel
    Friend WithEvents Sp1 As System.Windows.Forms.Panel
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents cmdBrowseLocation As System.Windows.Forms.Button
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalFrames As System.Windows.Forms.Label
    Friend WithEvents cmbImageFormat As System.Windows.Forms.ComboBox
    Friend WithEvents lblImageFormat As System.Windows.Forms.Label
    Friend WithEvents chkSkipExisting As System.Windows.Forms.CheckBox
    Friend WithEvents txtFPS As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblFPS As System.Windows.Forms.Label
    Friend WithEvents lblTotalSec As System.Windows.Forms.Label
    Friend WithEvents cmbSmoothing As System.Windows.Forms.ComboBox
    Friend WithEvents lblSmoothing As System.Windows.Forms.Label
    Friend WithEvents pnlParticles As System.Windows.Forms.Panel
    Friend WithEvents pnlParticlesTitle As System.Windows.Forms.Panel
    Friend WithEvents Sp3 As System.Windows.Forms.Panel
    Friend WithEvents pnlBackScroll As System.Windows.Forms.Panel
    Friend WithEvents cmdScrollDown As System.Windows.Forms.PictureBox
    Friend WithEvents cmdScrollUp As System.Windows.Forms.PictureBox
    Friend WithEvents chkGlow As System.Windows.Forms.CheckBox
    Friend WithEvents cmdColor As System.Windows.Forms.Button
    Friend WithEvents cmdGlowColor As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGlowOpacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtColorOpacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMotionBlurSamples As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents optSolidBG As System.Windows.Forms.RadioButton
    Friend WithEvents optTransparentBG As System.Windows.Forms.RadioButton
    Friend WithEvents cmdSolidBG As System.Windows.Forms.Button
    Friend WithEvents cmdImageBG As System.Windows.Forms.Button
    Friend WithEvents txtImageBG As System.Windows.Forms.TextBox
    Friend WithEvents optImageBG As System.Windows.Forms.RadioButton
    Friend WithEvents lblNotRecommended As System.Windows.Forms.Label
    Friend WithEvents lblGForce As System.Windows.Forms.Label
    Friend WithEvents lblReactor As System.Windows.Forms.Label
    Friend WithEvents cmbReactor As System.Windows.Forms.ComboBox
    Friend WithEvents txtGForce As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblGForcePPF As System.Windows.Forms.Label
    Friend WithEvents txtRefractOpacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReflectOpacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdIOR As System.Windows.Forms.Button
    Friend WithEvents txtIOR As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkColor As System.Windows.Forms.CheckBox
    Friend WithEvents pnlParticlesColor As System.Windows.Forms.Panel
    Friend WithEvents pnlParticlesGlow As System.Windows.Forms.Panel
    Friend WithEvents pnlParticlesRefraction As System.Windows.Forms.Panel
    Friend WithEvents pnlParticlesReflection As System.Windows.Forms.Panel
    Friend WithEvents pnlParticlesMotionBlur As System.Windows.Forms.Panel
    Friend WithEvents lblExitColor As System.Windows.Forms.Label
    Friend WithEvents cmdExitColor As System.Windows.Forms.Button
    Friend WithEvents optRefract As System.Windows.Forms.RadioButton
    Friend WithEvents optReflect As System.Windows.Forms.RadioButton
    Friend WithEvents optSolidColor As System.Windows.Forms.RadioButton
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents chkReactEachOther As System.Windows.Forms.CheckBox
    Friend WithEvents pnlGlossiness As System.Windows.Forms.Panel
    Friend WithEvents chkGlossiness As System.Windows.Forms.CheckBox
    Friend WithEvents cmdGlossColor As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtGlossiness As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSpecLevel As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdPreviewGloss As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
End Class
