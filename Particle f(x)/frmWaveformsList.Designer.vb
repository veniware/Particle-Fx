<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWaveformsList
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
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblLen = New System.Windows.Forms.Label()
        Me.lblAve = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.pnlThump = New System.Windows.Forms.Panel()
        Me.lstWaveforms = New System.Windows.Forms.ListBox()
        Me.pnlButtons.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.cmdCancel)
        Me.pnlButtons.Controls.Add(Me.cmdOK)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(12, 412)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(450, 40)
        Me.pnlButtons.TabIndex = 2
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdCancel.Location = New System.Drawing.Point(235, 5)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdOK.Enabled = False
        Me.cmdOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdOK.Location = New System.Drawing.Point(154, 5)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'pnlInfo
        '
        Me.pnlInfo.Controls.Add(Me.lblMin)
        Me.pnlInfo.Controls.Add(Me.lblLen)
        Me.pnlInfo.Controls.Add(Me.lblAve)
        Me.pnlInfo.Controls.Add(Me.lblMax)
        Me.pnlInfo.Controls.Add(Me.pnlThump)
        Me.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInfo.Location = New System.Drawing.Point(12, 348)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(450, 64)
        Me.pnlInfo.TabIndex = 1
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(159, 18)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(33, 13)
        Me.lblMin.TabIndex = 4
        Me.lblMin.Text = "Min: "
        '
        'lblLen
        '
        Me.lblLen.AutoSize = True
        Me.lblLen.Location = New System.Drawing.Point(159, 46)
        Me.lblLen.Name = "lblLen"
        Me.lblLen.Size = New System.Drawing.Size(46, 13)
        Me.lblLen.TabIndex = 3
        Me.lblLen.Text = "Length:"
        '
        'lblAve
        '
        Me.lblAve.AutoSize = True
        Me.lblAve.Location = New System.Drawing.Point(159, 32)
        Me.lblAve.Name = "lblAve"
        Me.lblAve.Size = New System.Drawing.Size(51, 13)
        Me.lblAve.TabIndex = 2
        Me.lblAve.Text = "Average:"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(159, 4)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(34, 13)
        Me.lblMax.TabIndex = 1
        Me.lblMax.Text = "Max: "
        '
        'pnlThump
        '
        Me.pnlThump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlThump.Location = New System.Drawing.Point(3, 2)
        Me.pnlThump.Name = "pnlThump"
        Me.pnlThump.Size = New System.Drawing.Size(150, 60)
        Me.pnlThump.TabIndex = 0
        '
        'lstWaveforms
        '
        Me.lstWaveforms.BackColor = System.Drawing.Color.Gray
        Me.lstWaveforms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstWaveforms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstWaveforms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.lstWaveforms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lstWaveforms.FormattingEnabled = True
        Me.lstWaveforms.ItemHeight = 16
        Me.lstWaveforms.Location = New System.Drawing.Point(12, 12)
        Me.lstWaveforms.Name = "lstWaveforms"
        Me.lstWaveforms.Size = New System.Drawing.Size(450, 336)
        Me.lstWaveforms.TabIndex = 0
        '
        'frmWaveformsList
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(474, 452)
        Me.Controls.Add(Me.lstWaveforms)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.pnlButtons)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 480)
        Me.Name = "frmWaveformsList"
        Me.Padding = New System.Windows.Forms.Padding(12, 12, 12, 0)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Waveforms list"
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents lstWaveforms As System.Windows.Forms.ListBox
    Friend WithEvents pnlThump As System.Windows.Forms.Panel
    Friend WithEvents lblLen As System.Windows.Forms.Label
    Friend WithEvents lblAve As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
End Class
