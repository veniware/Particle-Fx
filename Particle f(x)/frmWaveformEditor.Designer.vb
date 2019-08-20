<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWaveformEditor
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbQuality = New System.Windows.Forms.ComboBox()
        Me.cmbRender = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSkip = New System.Windows.Forms.ComboBox()
        Me.pnlButtom = New System.Windows.Forms.Panel()
        Me.cmdOpposite = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdApply2 = New System.Windows.Forms.Button()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt4 = New System.Windows.Forms.NumericUpDown()
        Me.txt3 = New System.Windows.Forms.NumericUpDown()
        Me.txt2 = New System.Windows.Forms.NumericUpDown()
        Me.txt1 = New System.Windows.Forms.NumericUpDown()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.cmbFunction = New System.Windows.Forms.ComboBox()
        Me.cmdAbs = New System.Windows.Forms.Button()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.txtRange = New System.Windows.Forms.NumericUpDown()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdSqrt = New System.Windows.Forms.Button()
        Me.pnlFrame = New System.Windows.Forms.Panel()
        Me.cmDerivative = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.pnlButtom.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        CType(Me.txtRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.BackgroundImage = Global.ParticleFX.My.Resources.Resources.MainMenuhigh
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1280, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'pnlTop
        '
        Me.pnlTop.BackgroundImage = Global.ParticleFX.My.Resources.Resources.MainMenuLow
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTop.Controls.Add(Me.Label3)
        Me.pnlTop.Controls.Add(Me.cmbQuality)
        Me.pnlTop.Controls.Add(Me.cmbRender)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Controls.Add(Me.cmbSkip)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 24)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1280, 27)
        Me.pnlTop.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(413, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quality:"
        '
        'cmbQuality
        '
        Me.cmbQuality.BackColor = System.Drawing.Color.DimGray
        Me.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuality.ForeColor = System.Drawing.Color.White
        Me.cmbQuality.FormattingEnabled = True
        Me.cmbQuality.Items.AddRange(New Object() {"None", "Anti-alias"})
        Me.cmbQuality.Location = New System.Drawing.Point(466, 3)
        Me.cmbQuality.Name = "cmbQuality"
        Me.cmbQuality.Size = New System.Drawing.Size(92, 21)
        Me.cmbQuality.TabIndex = 5
        '
        'cmbRender
        '
        Me.cmbRender.BackColor = System.Drawing.Color.DimGray
        Me.cmbRender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRender.ForeColor = System.Drawing.Color.White
        Me.cmbRender.FormattingEnabled = True
        Me.cmbRender.Items.AddRange(New Object() {"Points", "Lines", "Curves"})
        Me.cmbRender.Location = New System.Drawing.Point(291, 3)
        Me.cmbRender.Name = "cmbRender"
        Me.cmbRender.Size = New System.Drawing.Size(92, 21)
        Me.cmbRender.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(206, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Render mode:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Points skip:"
        '
        'cmbSkip
        '
        Me.cmbSkip.BackColor = System.Drawing.Color.DimGray
        Me.cmbSkip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSkip.ForeColor = System.Drawing.Color.White
        Me.cmbSkip.FormattingEnabled = True
        Me.cmbSkip.Items.AddRange(New Object() {"None", "1", "2", "4", "8", "12", "16", "24", "32", "48", "64", "128", "256"})
        Me.cmbSkip.Location = New System.Drawing.Point(84, 3)
        Me.cmbSkip.Name = "cmbSkip"
        Me.cmbSkip.Size = New System.Drawing.Size(92, 21)
        Me.cmbSkip.TabIndex = 1
        '
        'pnlButtom
        '
        Me.pnlButtom.Controls.Add(Me.cmDerivative)
        Me.pnlButtom.Controls.Add(Me.cmdOpposite)
        Me.pnlButtom.Controls.Add(Me.Panel1)
        Me.pnlButtom.Controls.Add(Me.cmdAbs)
        Me.pnlButtom.Controls.Add(Me.pnlButtons)
        Me.pnlButtom.Controls.Add(Me.cmdSqrt)
        Me.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtom.Location = New System.Drawing.Point(0, 570)
        Me.pnlButtom.Name = "pnlButtom"
        Me.pnlButtom.Size = New System.Drawing.Size(1280, 150)
        Me.pnlButtom.TabIndex = 3
        '
        'cmdOpposite
        '
        Me.cmdOpposite.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdOpposite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdOpposite.Location = New System.Drawing.Point(288, 52)
        Me.cmdOpposite.Name = "cmdOpposite"
        Me.cmdOpposite.Size = New System.Drawing.Size(95, 40)
        Me.cmdOpposite.TabIndex = 2
        Me.cmdOpposite.Text = "Opposite"
        Me.cmdOpposite.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdApply2)
        Me.Panel1.Controls.Add(Me.lbl4)
        Me.Panel1.Controls.Add(Me.lbl3)
        Me.Panel1.Controls.Add(Me.lbl2)
        Me.Panel1.Controls.Add(Me.lbl1)
        Me.Panel1.Controls.Add(Me.txt4)
        Me.Panel1.Controls.Add(Me.txt3)
        Me.Panel1.Controls.Add(Me.txt2)
        Me.Panel1.Controls.Add(Me.txt1)
        Me.Panel1.Controls.Add(Me.lblFormula)
        Me.Panel1.Controls.Add(Me.cmbFunction)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 144)
        Me.Panel1.TabIndex = 0
        '
        'cmdApply2
        '
        Me.cmdApply2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdApply2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdApply2.Location = New System.Drawing.Point(193, 114)
        Me.cmdApply2.Name = "cmdApply2"
        Me.cmdApply2.Size = New System.Drawing.Size(54, 27)
        Me.cmdApply2.TabIndex = 10
        Me.cmdApply2.Text = "Apply"
        Me.cmdApply2.UseVisualStyleBackColor = False
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(3, 118)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(17, 13)
        Me.lbl4.TabIndex = 8
        Me.lbl4.Text = "d:"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(3, 94)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(15, 13)
        Me.lbl3.TabIndex = 6
        Me.lbl3.Text = "c:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(3, 70)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(17, 13)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "b:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(3, 46)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(16, 13)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "a:"
        '
        'txt4
        '
        Me.txt4.BackColor = System.Drawing.Color.DimGray
        Me.txt4.DecimalPlaces = 3
        Me.txt4.ForeColor = System.Drawing.Color.White
        Me.txt4.Location = New System.Drawing.Point(54, 116)
        Me.txt4.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.txt4.Minimum = New Decimal(New Integer() {65536, 0, 0, -2147483648})
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(120, 22)
        Me.txt4.TabIndex = 9
        '
        'txt3
        '
        Me.txt3.BackColor = System.Drawing.Color.DimGray
        Me.txt3.DecimalPlaces = 3
        Me.txt3.ForeColor = System.Drawing.Color.White
        Me.txt3.Location = New System.Drawing.Point(54, 92)
        Me.txt3.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.txt3.Minimum = New Decimal(New Integer() {65536, 0, 0, -2147483648})
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(120, 22)
        Me.txt3.TabIndex = 7
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.Color.DimGray
        Me.txt2.DecimalPlaces = 3
        Me.txt2.ForeColor = System.Drawing.Color.White
        Me.txt2.Location = New System.Drawing.Point(54, 68)
        Me.txt2.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.txt2.Minimum = New Decimal(New Integer() {65536, 0, 0, -2147483648})
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(120, 22)
        Me.txt2.TabIndex = 5
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.Color.DimGray
        Me.txt1.DecimalPlaces = 3
        Me.txt1.ForeColor = System.Drawing.Color.White
        Me.txt1.Location = New System.Drawing.Point(54, 44)
        Me.txt1.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.txt1.Minimum = New Decimal(New Integer() {65536, 0, 0, -2147483648})
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(120, 22)
        Me.txt1.TabIndex = 3
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Location = New System.Drawing.Point(3, 24)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(55, 13)
        Me.lblFormula.TabIndex = 1
        Me.lblFormula.Text = "Formula: "
        '
        'cmbFunction
        '
        Me.cmbFunction.BackColor = System.Drawing.Color.DimGray
        Me.cmbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFunction.ForeColor = System.Drawing.Color.White
        Me.cmbFunction.FormattingEnabled = True
        Me.cmbFunction.Items.AddRange(New Object() {"General equation", "Quadratic equation", "Tertiary equation", "Square root", "Sine", "Cosine", "Random"})
        Me.cmbFunction.Location = New System.Drawing.Point(0, 0)
        Me.cmbFunction.Name = "cmbFunction"
        Me.cmbFunction.Size = New System.Drawing.Size(250, 21)
        Me.cmbFunction.TabIndex = 0
        '
        'cmdAbs
        '
        Me.cmdAbs.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdAbs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdAbs.Location = New System.Drawing.Point(288, 6)
        Me.cmdAbs.Name = "cmdAbs"
        Me.cmdAbs.Size = New System.Drawing.Size(95, 40)
        Me.cmdAbs.TabIndex = 1
        Me.cmdAbs.Text = "Absolute value"
        Me.cmdAbs.UseVisualStyleBackColor = False
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.txtRange)
        Me.pnlButtons.Controls.Add(Me.cmdApply)
        Me.pnlButtons.Controls.Add(Me.lblRange)
        Me.pnlButtons.Controls.Add(Me.cmdOK)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlButtons.Location = New System.Drawing.Point(1107, 0)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(173, 150)
        Me.pnlButtons.TabIndex = 4
        '
        'txtRange
        '
        Me.txtRange.BackColor = System.Drawing.Color.DimGray
        Me.txtRange.ForeColor = System.Drawing.Color.White
        Me.txtRange.Location = New System.Drawing.Point(86, 6)
        Me.txtRange.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.txtRange.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txtRange.Name = "txtRange"
        Me.txtRange.Size = New System.Drawing.Size(75, 22)
        Me.txtRange.TabIndex = 1
        Me.txtRange.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'cmdApply
        '
        Me.cmdApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdApply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdApply.Location = New System.Drawing.Point(86, 111)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 27)
        Me.cmdApply.TabIndex = 3
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = False
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(37, 8)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(43, 13)
        Me.lblRange.TabIndex = 0
        Me.lblRange.Text = "Range:"
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdOK.Location = New System.Drawing.Point(5, 111)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 27)
        Me.cmdOK.TabIndex = 2
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'cmdSqrt
        '
        Me.cmdSqrt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdSqrt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdSqrt.Location = New System.Drawing.Point(288, 98)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(95, 40)
        Me.cmdSqrt.TabIndex = 3
        Me.cmdSqrt.Text = "Square root"
        Me.cmdSqrt.UseVisualStyleBackColor = False
        '
        'pnlFrame
        '
        Me.pnlFrame.BackColor = System.Drawing.Color.Gray
        Me.pnlFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFrame.Location = New System.Drawing.Point(0, 51)
        Me.pnlFrame.Name = "pnlFrame"
        Me.pnlFrame.Size = New System.Drawing.Size(1280, 519)
        Me.pnlFrame.TabIndex = 2
        '
        'cmDerivative
        '
        Me.cmDerivative.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmDerivative.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmDerivative.Location = New System.Drawing.Point(389, 6)
        Me.cmDerivative.Name = "cmDerivative"
        Me.cmDerivative.Size = New System.Drawing.Size(95, 40)
        Me.cmDerivative.TabIndex = 5
        Me.cmDerivative.Text = "Derivative"
        Me.cmDerivative.UseVisualStyleBackColor = False
        '
        'frmWaveformEditor
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.pnlFrame)
        Me.Controls.Add(Me.pnlButtom)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(720, 480)
        Me.Name = "frmWaveformEditor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Waveform editor"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlButtom.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlButtons.PerformLayout()
        CType(Me.txtRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbQuality As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbRender As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSkip As System.Windows.Forms.ComboBox
    Friend WithEvents pnlButtom As System.Windows.Forms.Panel
    Friend WithEvents pnlFrame As System.Windows.Forms.Panel
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmbFunction As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdAbs As System.Windows.Forms.Button
    Friend WithEvents cmdOpposite As System.Windows.Forms.Button
    Friend WithEvents cmdSqrt As System.Windows.Forms.Button
    Friend WithEvents lblFormula As System.Windows.Forms.Label
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents txt4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtRange As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRange As System.Windows.Forms.Label
    Friend WithEvents cmdApply2 As System.Windows.Forms.Button
    Friend WithEvents cmDerivative As System.Windows.Forms.Button
End Class
