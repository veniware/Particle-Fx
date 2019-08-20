<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrValueBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrChangeVals = New System.Windows.Forms.Timer(Me.components)
        Me.EditWaveformToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ContextMenuStrip1.BackgroundImage = Global.ParticleFX.My.Resources.Resources.BlackBar
        Me.ContextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.EditWaveformToolStripMenuItem, Me.ToolStripMenuItem1, Me.LinkToolStripMenuItem, Me.UnlinkToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(151, 98)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit value"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'LinkToolStripMenuItem
        '
        Me.LinkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LinkToolStripMenuItem.Image = Global.ParticleFX.My.Resources.Resources.icoLink
        Me.LinkToolStripMenuItem.Name = "LinkToolStripMenuItem"
        Me.LinkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LinkToolStripMenuItem.Text = "Link"
        '
        'UnlinkToolStripMenuItem
        '
        Me.UnlinkToolStripMenuItem.Enabled = False
        Me.UnlinkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UnlinkToolStripMenuItem.Name = "UnlinkToolStripMenuItem"
        Me.UnlinkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UnlinkToolStripMenuItem.Text = "Unlink"
        '
        'tmrChangeVals
        '
        Me.tmrChangeVals.Interval = 750
        '
        'EditWaveformToolStripMenuItem
        '
        Me.EditWaveformToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EditWaveformToolStripMenuItem.Name = "EditWaveformToolStripMenuItem"
        Me.EditWaveformToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditWaveformToolStripMenuItem.Text = "Edit waveform"
        '
        'ctrValueBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Name = "ctrValueBox"
        Me.Size = New System.Drawing.Size(84, 16)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnlinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrChangeVals As System.Windows.Forms.Timer
    Friend WithEvents EditWaveformToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
