<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRendering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRendering))
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblPreparing = New System.Windows.Forms.Label()
        Me.lblReacting = New System.Windows.Forms.Label()
        Me.lblRendering = New System.Windows.Forms.Label()
        Me.lblReactMsg = New System.Windows.Forms.Label()
        Me.lblRenderMsg = New System.Windows.Forms.Label()
        Me.prgPrepare = New System.Windows.Forms.ProgressBar()
        Me.prgReact = New System.Windows.Forms.ProgressBar()
        Me.prgRender = New System.Windows.Forms.ProgressBar()
        Me.picReact = New System.Windows.Forms.Panel()
        Me.picRender = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmdCancel.Location = New System.Drawing.Point(219, 71)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'lblPreparing
        '
        Me.lblPreparing.Location = New System.Drawing.Point(12, 11)
        Me.lblPreparing.Name = "lblPreparing"
        Me.lblPreparing.Size = New System.Drawing.Size(71, 16)
        Me.lblPreparing.TabIndex = 0
        Me.lblPreparing.Text = "Preparing:"
        Me.lblPreparing.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblReacting
        '
        Me.lblReacting.Location = New System.Drawing.Point(12, 30)
        Me.lblReacting.Name = "lblReacting"
        Me.lblReacting.Size = New System.Drawing.Size(71, 16)
        Me.lblReacting.TabIndex = 3
        Me.lblReacting.Text = "Reacting:"
        Me.lblReacting.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRendering
        '
        Me.lblRendering.Location = New System.Drawing.Point(12, 49)
        Me.lblRendering.Name = "lblRendering"
        Me.lblRendering.Size = New System.Drawing.Size(71, 16)
        Me.lblRendering.TabIndex = 5
        Me.lblRendering.Text = "Rendering:"
        Me.lblRendering.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblReactMsg
        '
        Me.lblReactMsg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblReactMsg.Location = New System.Drawing.Point(431, 30)
        Me.lblReactMsg.Name = "lblReactMsg"
        Me.lblReactMsg.Size = New System.Drawing.Size(79, 13)
        Me.lblReactMsg.TabIndex = 7
        Me.lblReactMsg.Text = "..."
        '
        'lblRenderMsg
        '
        Me.lblRenderMsg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblRenderMsg.Location = New System.Drawing.Point(431, 49)
        Me.lblRenderMsg.Name = "lblRenderMsg"
        Me.lblRenderMsg.Size = New System.Drawing.Size(79, 13)
        Me.lblRenderMsg.TabIndex = 8
        Me.lblRenderMsg.Text = "..."
        '
        'prgPrepare
        '
        Me.prgPrepare.Location = New System.Drawing.Point(89, 11)
        Me.prgPrepare.Name = "prgPrepare"
        Me.prgPrepare.Size = New System.Drawing.Size(320, 16)
        Me.prgPrepare.TabIndex = 9
        '
        'prgReact
        '
        Me.prgReact.Location = New System.Drawing.Point(89, 30)
        Me.prgReact.Name = "prgReact"
        Me.prgReact.Size = New System.Drawing.Size(320, 16)
        Me.prgReact.TabIndex = 10
        '
        'prgRender
        '
        Me.prgRender.Location = New System.Drawing.Point(89, 49)
        Me.prgRender.Name = "prgRender"
        Me.prgRender.Size = New System.Drawing.Size(320, 16)
        Me.prgRender.TabIndex = 11
        '
        'picReact
        '
        Me.picReact.BackgroundImage = CType(resources.GetObject("picReact.BackgroundImage"), System.Drawing.Image)
        Me.picReact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picReact.Location = New System.Drawing.Point(411, 30)
        Me.picReact.Name = "picReact"
        Me.picReact.Size = New System.Drawing.Size(16, 16)
        Me.picReact.TabIndex = 12
        '
        'picRender
        '
        Me.picRender.BackgroundImage = CType(resources.GetObject("picRender.BackgroundImage"), System.Drawing.Image)
        Me.picRender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picRender.Location = New System.Drawing.Point(411, 49)
        Me.picRender.Name = "picRender"
        Me.picRender.Size = New System.Drawing.Size(16, 16)
        Me.picRender.TabIndex = 13
        '
        'frmRendering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(513, 106)
        Me.Controls.Add(Me.picRender)
        Me.Controls.Add(Me.picReact)
        Me.Controls.Add(Me.prgRender)
        Me.Controls.Add(Me.prgReact)
        Me.Controls.Add(Me.prgPrepare)
        Me.Controls.Add(Me.lblRenderMsg)
        Me.Controls.Add(Me.lblReactMsg)
        Me.Controls.Add(Me.lblRendering)
        Me.Controls.Add(Me.lblReacting)
        Me.Controls.Add(Me.lblPreparing)
        Me.Controls.Add(Me.cmdCancel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRendering"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rendering"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lblPreparing As System.Windows.Forms.Label
    Friend WithEvents lblReacting As System.Windows.Forms.Label
    Friend WithEvents lblRendering As System.Windows.Forms.Label
    Friend WithEvents lblReactMsg As System.Windows.Forms.Label
    Friend WithEvents lblRenderMsg As System.Windows.Forms.Label
    Friend WithEvents prgPrepare As System.Windows.Forms.ProgressBar
    Friend WithEvents prgReact As System.Windows.Forms.ProgressBar
    Friend WithEvents prgRender As System.Windows.Forms.ProgressBar
    Friend WithEvents picReact As System.Windows.Forms.Panel
    Friend WithEvents picRender As System.Windows.Forms.Panel
End Class
