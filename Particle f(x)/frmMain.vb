Public Class frmMain
    Public Zoom As Decimal = 1
    Public OffSet As Point = New Point(0, 0)
    Public PreOffSet As Point

    Public Frame As Image

    Public PointsCount As Integer = 1
    Public SpraysCount As Integer = 1
    Public RainsCount As Integer = 1
    Public RandomsCount As Integer = 1
    Public BitmapsCount As Integer = 1
    Public ExpirysCount As Integer = 1
    Public WindsCount As Integer = 1
    Public ExpantCount As Integer = 1
    Public BlackHoleCount As Integer = 1
    Public FanCount As Integer = 1
    Public WhirlpoolCount As Integer = 1
    Public CamerasCount As Integer = 1

    Public StringFormatCenterHor As New StringFormat
    Public StringFormatCenterVer As New StringFormat
    Public StringFormatCenterBot As New StringFormat
    Public StringFormatRight As New StringFormat
    Public StringFormatLeftCenter As New StringFormat
    Public StringFormatCenterAll As New StringFormat

    Public WithEvents txtName As New ctrStringBox
    Public WithEvents txtX As New ctrValueBox
    Public WithEvents txtY As New ctrValueBox
    Public WithEvents txtX2 As New ctrValueBox
    Public WithEvents txtY2 As New ctrValueBox
    Public WithEvents txtWidth As New ctrValueBox
    Public WithEvents txtHeight As New ctrValueBox
    Public WithEvents txtSlope As New ctrValueBox
    Public WithEvents txtNoice As New ctrValueBox
    Public WithEvents txtR As New ctrValueBox
    Public WithEvents txtF0 As New ctrValueBox
    Public WithEvents txtPPF As New ctrValueBox
    Public WithEvents txtStart As New ctrValueBox
    Public WithEvents txtStop As New ctrValueBox
    Public WithEvents txtLife As New ctrValueBox
    Public WithEvents txtBitmap As New ctrStringBox

    Public WithEvents frmGhost As New Form
    Sub frmGhost_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles frmGhost.Paint
        e.Graphics.DrawString(frmGhost.Text, Me.Font, Brushes.White, New Rectangle(0, 0, frmGhost.Width, frmGhost.Height), StringFormatCenterHor)
    End Sub

    Sub txtName_ValueChanged() Handles txtName.ValueChanged
        ChangeVals(False)
    End Sub
    Sub txtX_ValueChanged() Handles txtX.ValueChanged
        ChangeVals()
    End Sub
    Sub txtY_ValueChanged() Handles txtY.ValueChanged
        ChangeVals()
    End Sub
    Sub txtX2_ValueChanged() Handles txtX2.ValueChanged
        ChangeVals()
    End Sub
    Sub txtY2_ValueChanged() Handles txtY2.ValueChanged
        ChangeVals()
    End Sub
    Sub txtWidth_ValueChanged() Handles txtWidth.ValueChanged
        ChangeVals()
    End Sub
    Sub txtHeight_ValueChanged() Handles txtHeight.ValueChanged
        ChangeVals()
    End Sub
    Sub txtSlope_ValueChanged() Handles txtSlope.ValueChanged
        ChangeVals()
    End Sub
    Sub txtNoice_ValueChanged() Handles txtNoice.ValueChanged
        ChangeVals()
    End Sub
    Sub txtR_ValueChanged() Handles txtR.ValueChanged
        ChangeVals()
    End Sub
    Sub txtF0_ValueChanged() Handles txtF0.ValueChanged
        ChangeVals(False)
    End Sub
    Sub txtPPF_ValueChanged() Handles txtPPF.ValueChanged
        ChangeVals(False)
    End Sub
    Sub txtStart_ValueChanged() Handles txtStart.ValueChanged
        If Not txtStart.Focused Then Exit Sub
        If txtStop.Value < txtStart.Value + 1 Then txtStop.Value = txtStart.Value + 1
        txtStop.Refresh()
        ChangeVals(False)
    End Sub
    Sub txtStop_ValueChanged() Handles txtStop.ValueChanged
        If Not txtStop.Focused Then Exit Sub
        If txtStart.Value > txtStop.Value - 1 Then txtStart.Value = txtStop.Value - 1
        txtStart.Refresh()
        ChangeVals(False)
    End Sub
    Sub txtLife_ValueChanged() Handles txtLife.ValueChanged
        ChangeVals(False)
    End Sub
    Sub cmdColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColor.Click
        Dim frmColor As New ColorDialog
        frmColor.Color = cmdColor.BackColor
        If frmColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            cmdColor.BackColor = frmColor.Color
            ChangeVals(False)
        End If
    End Sub
    Sub txtBitmap_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBitmap.DoubleClick
        Dim frmBitmap As New OpenFileDialog
        frmBitmap.Filter = "All Images|*.bmp;*.dib;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.tiff;*.png|" & _
                "Portable Network Graphics (*.png)|*.png|" & _
                "Tagged Image File Format (*.tif;*.tiff)|*.tif;*.tiff|" & _
                "Device Independent Bitmap|*.bmp;*.dib|" & _
                "Joint Photographic Experts Group (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|" & _
                "Graphics Interchange Format (*.gif)|*.gif|" & _
                "All Files (*.*)|*.*"

        If frmBitmap.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtBitmap.Value = frmBitmap.FileName
            txtBitmap.Refresh()
            ChangeVals(False)
        End If
        frmBitmap.Dispose()
    End Sub

    Public Sub New()

        Control.CheckForIllegalCrossThreadCalls = False

        StringFormatCenterHor.Alignment = StringAlignment.Center
        StringFormatCenterHor.LineAlignment = StringAlignment.Center

        StringFormatCenterVer.Alignment = StringAlignment.Center
        StringFormatCenterVer.LineAlignment = StringAlignment.Center
        StringFormatCenterVer.FormatFlags = StringFormatFlags.DirectionVertical

        StringFormatCenterBot.Alignment = StringAlignment.Center
        StringFormatCenterBot.LineAlignment = StringAlignment.Far

        StringFormatRight.Alignment = StringAlignment.Far

        StringFormatLeftCenter.Alignment = StringAlignment.Near
        StringFormatLeftCenter.LineAlignment = StringAlignment.Center

        StringFormatCenterAll.Alignment = StringAlignment.Center
        StringFormatCenterAll.LineAlignment = StringAlignment.Center

        frmGhost.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmGhost.BackColor = Color.DimGray
        'frmGhost.BackgroundImage = My.Resources.SrollButtonBG
        'frmGhost.BackgroundImageLayout = ImageLayout.Stretch
        'frmGhost.Opacity = 0.5
        frmGhost.TopMost = True
        frmGhost.ShowIcon = False
        frmGhost.ShowInTaskbar = False
        'frmGhost.Size = New Size(32, 32)

        InitializeComponent()
        BuildParametrsBoxes()
        LoadGens()

        lstTools.BackColor = Color.FromArgb(87, 87, 87)

        lstParameters.pnlMainList.Padding = New Padding(4)
        lstParameters.AddControl(lstObjects)
        lstParameters.AddControl(pnlParameters)
        pnlParameters.AutoSize = True

        'Loading Settings
        pnlShortcutsBar.Visible = My.Settings.ShowShortcutsBar
        ShortcutsBarToolStripMenuItem.Checked = My.Settings.ShowShortcutsBar

        pnlRulerH.Visible = My.Settings.ShowRuler
        pnlRulerV.Visible = My.Settings.ShowRuler
        RulerToolStripMenuItem.Checked = My.Settings.ShowRuler
    End Sub

    Sub BuildParametrsBoxes()
        txtName.tmrChangeVals.Enabled = True
        txtName.Location = New Point(60, 3)
        pnlName.Controls.Add(txtName)

        txtX.tmrChangeVals.Enabled = True
        txtX.Location = New Point(60, 0)
        pnlX.Controls.Add(txtX)

        txtY.tmrChangeVals.Enabled = True
        txtY.Location = New Point(60, 0)
        pnlY.Controls.Add(txtY)

        txtX2.tmrChangeVals.Enabled = True
        txtX2.Location = New Point(60, 0)
        pnlX2.Controls.Add(txtX2)

        txtY2.tmrChangeVals.Enabled = True
        txtY2.Location = New Point(60, 0)
        pnlY2.Controls.Add(txtY2)

        txtWidth.Max = 4096
        txtWidth.Min = 1
        txtWidth.tmrChangeVals.Enabled = True
        txtWidth.Location = New Point(60, 0)
        pnlWidth.Controls.Add(txtWidth)

        txtHeight.Max = 2304
        txtHeight.Min = 1
        txtHeight.tmrChangeVals.Enabled = True
        txtHeight.Location = New Point(60, 0)
        pnlHeight.Controls.Add(txtHeight)

        txtSlope.Max = 359
        txtSlope.Min = 0
        txtSlope.tmrChangeVals.Enabled = True
        txtSlope.Location = New Point(60, 0)
        pnlSlope.Controls.Add(txtSlope)

        txtNoice.Min = MinNoice
        txtNoice.Max = MaxNoice
        txtNoice.tmrChangeVals.Enabled = True
        txtNoice.Location = New Point(60, 0)
        pnlNoice.Controls.Add(txtNoice)

        txtR.Min = MinR
        txtR.Max = MaxR
        txtR.tmrChangeVals.Enabled = True
        txtR.Location = New Point(60, 0)
        pnlR.Controls.Add(txtR)

        txtF0.Min = MinF
        txtF0.Max = MaxF
        txtF0.DecimalPlaces = 3
        txtF0.tmrChangeVals.Enabled = True
        txtF0.Location = New Point(60, 0)
        pnlF0.Controls.Add(txtF0)

        txtPPF.Min = MinPPF
        txtPPF.Max = MaxPPF
        txtPPF.tmrChangeVals.Enabled = True
        txtPPF.Location = New Point(60, 0)
        pnlPPF.Controls.Add(txtPPF)

        txtStart.Min = 0
        txtStart.tmrChangeVals.Enabled = True
        txtStart.Location = New Point(60, 0)
        pnlStart.Controls.Add(txtStart)

        txtStop.Min = 1
        txtStop.tmrChangeVals.Enabled = True
        txtStop.Location = New Point(60, 0)
        pnlStop.Controls.Add(txtStop)

        txtLife.Min = 1
        txtLife.tmrChangeVals.Enabled = True
        txtLife.Location = New Point(60, 0)
        pnlLife.Controls.Add(txtLife)

        txtBitmap.isReadOnly = True
        txtBitmap.isPathName = True
        txtBitmap.tmrChangeVals.Enabled = True
        txtBitmap.Location = New Point(60, 3)
        pnlBitmap.Controls.Add(txtBitmap)
    End Sub

    Sub LoadGens()
        lstTools.pnlMainList.Hide()

        lstTools.ClearItems()

        'lstTools.AddLabel("Generators:")
        lstTools.AddItem("Point generator", Color.Blue)
        lstTools.AddItem("Rain generator", Color.Blue)
        lstTools.AddItem("Spray generator", Color.Blue)
        lstTools.AddItem("Random generator", Color.Blue)
        lstTools.AddItem("Bitmap generator", Color.Blue)
        lstTools.AddSeparator()
        lstTools.AddItem("Expiry point", Color.Red)

        lstTools.pnlMainList.Show()
    End Sub
    Sub LoadForces()
        lstTools.pnlMainList.Hide()

        lstTools.ClearItems()

        'lstTools.AddLabel("Forces:")
        lstTools.AddItem("Wind", Color.Cyan)
        lstTools.AddItem("Expant", Color.Cyan)
        lstTools.AddItem("Black hole", Color.Cyan)
        lstTools.AddItem("Fan", Color.Cyan)
        lstTools.AddItem("Whirlpool", Color.Cyan)
        'lstTools.AddItem("Antigravity", Color.Cyan)

        lstTools.pnlMainList.Show()
    End Sub
    Sub LoadDraws()
        lstTools.pnlMainList.Hide()

        lstTools.ClearItems()

        'lstTools.AddLabel("Graphics:")
        lstTools.AddItem("Line", Color.Green)
        'lstTools.AddItem("Curve", Color.Green)
        'lstTools.AddItem("Closed curve", Color.Green)
        lstTools.AddItem("Rectangle", Color.Green)
        lstTools.AddItem("Ellipse", Color.Green)
        'lstTools.AddItem("Pie", Color.Green)
        'lstTools.AddItem("Polygon", Color.Green)
        lstTools.AddItem("Draw", Color.Green)
        'lstTools.AddItem("Eraser", Color.Green)
        lstTools.AddItem("Templates", Color.Green)

        lstTools.pnlMainList.Show()
    End Sub
    Sub LoadCams()
        lstTools.pnlMainList.Hide()

        lstTools.ClearItems()

        'lstTools.AddLabel("Cameras:")
        lstTools.AddItem("VGA", Color.Yellow, "640x480")
        lstTools.AddItem("SVGA", Color.Yellow, "800x600")
        lstTools.AddItem("XGA", Color.Yellow, "1024x768")
        lstTools.AddItem("XGA+", Color.Yellow, "1152x864")
        lstTools.AddItem("WXGA", Color.Yellow, "1280x768")
        lstTools.AddItem("WXGA", Color.Yellow, "1280x800")
        lstTools.AddItem("SXGA", Color.Yellow, "1280x960")
        lstTools.AddItem("SXGA", Color.Yellow, "1280x1024")
        lstTools.AddItem("WSXGA", Color.Yellow, "1440x900")
        lstTools.AddItem("WSXGA+", Color.Yellow, "1680x1050")
        lstTools.AddItem("UXGA", Color.Yellow, "1600x1200")
        lstTools.AddItem("WUXGA", Color.Yellow, "1920x1200")
        lstTools.AddItem("HD-480", Color.Yellow, "720x480")
        lstTools.AddItem("HD-576", Color.Yellow, "720x576")
        lstTools.AddItem("HD-720", Color.Yellow, "1280×720")
        lstTools.AddItem("HD-1080", Color.Yellow, "1920x1080")
        lstTools.AddItem("4K", Color.Yellow, "4096x2160")

        lstTools.pnlMainList.Show()
    End Sub

    Sub ClearListObject()
        If MessageBox("Are you sure you want to clear the scene?", "Clear", 3) = DialogResult.Yes Then
            lstObjects.SelectedIndex = -1

            lstObjects.Items.Clear()
            lstObjectsBG.Clear()
            Engine.Points.Clear()
            Engine.Rains.Clear()
            Engine.Sprays.Clear()
            Engine.Randoms.Clear()
            Engine.Bitmaps.Clear()
            Engine.Expirys.Clear()
            Engine.Winds.Clear()
            Engine.Expants.Clear()
            Engine.BlackHoles.Clear()
            Engine.Fans.Clear()
            Engine.Whirlpools.Clear()
            Engine.Cameras.Clear()

            RefreshFrame()
        End If
    End Sub
    Sub DeleteListObject()
        If lstObjects.SelectedIndex = -1 Then Exit Sub

        Dim SelTemp As Integer = lstObjects.SelectedIndex

        Select Case lstObjectsBG(lstObjects.SelectedIndex).Type
            Case 1 'expiry
                For i As Integer = 0 To Engine.Expirys.Count - 1
                    If Engine.Expirys(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.Expirys.RemoveAt(i)
                        Exit For
                    End If
                Next

            Case 2 'point
                For i As Integer = 0 To Engine.Points.Count - 1
                    If Engine.Points(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.Points.RemoveAt(i)
                        Exit For
                    End If
                Next

            Case 3 'rain
                For i As Integer = 0 To Engine.Rains.Count - 1
                    If Engine.Rains(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.Rains.RemoveAt(i)
                        Exit For
                    End If
                Next

            Case 4 'spray
                For i As Integer = 0 To Engine.Sprays.Count - 1
                    If Engine.Sprays(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.Sprays.RemoveAt(i)
                        Exit For
                    End If
                Next

            Case 10 'random
                For i As Integer = 0 To Engine.Randoms.Count - 1
                    If Engine.Randoms(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.Randoms.RemoveAt(i)
                        Exit For
                    End If
                Next

            Case 32 'bitmap
                For i As Integer = 0 To Engine.Bitmaps.Count - 1
                    If Engine.Bitmaps(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.Bitmaps.RemoveAt(i)
                        Exit For
                    End If
                Next

            Case 100 'wind
                For i As Integer = 0 To Engine.Winds.Count - 1
                    If Engine.Winds(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.Winds.RemoveAt(i)
                        Exit For
                    End If
                Next

            Case 101 'expart
                For i As Integer = 0 To Engine.Expants.Count - 1
                    If Engine.Expants(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.Expants.RemoveAt(i)
                        Exit For
                    End If
                Next

            Case 102 'black hole
                For i As Integer = 0 To Engine.BlackHoles.Count - 1
                    If Engine.BlackHoles(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.BlackHoles.RemoveAt(i)
                        Exit For
                    End If
                Next

            Case 103 'fan
                For i As Integer = 0 To Engine.Fans.Count - 1
                    If Engine.Fans(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.Fans.RemoveAt(i)
                        Exit For
                    End If
                Next

            Case 104 'whirlpool
                For i As Integer = 0 To Engine.Whirlpools.Count - 1
                    If Engine.Whirlpools(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.Whirlpools.RemoveAt(i)
                        Exit For
                    End If
                Next

            Case 255 'cam
                For i As Integer = 0 To Engine.Cameras.Count - 1
                    If Engine.Cameras(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        Engine.Cameras.RemoveAt(i)
                        Exit For
                    End If
                Next


        End Select

        lstObjectsBG.RemoveAt(lstObjects.SelectedIndex)
        lstObjects.Items.RemoveAt(lstObjects.SelectedIndex)

        If lstObjects.Items.Count > SelTemp Then
            lstObjects.SelectedIndex = SelTemp
        ElseIf lstObjects.Items.Count > SelTemp - 1 Then
            lstObjects.SelectedIndex = SelTemp - 1
        End If

        RefreshFrame()
    End Sub
    Sub RefreshListObject()
        Dim SelTemp As Integer = lstObjects.SelectedIndex

        lstObjects.Items.Clear()
        lstObjectsBG.Clear()

        For Each G As Engine.PointGen In Engine.Points
            Dim newItem As New Engine.ObjectItem
            newItem.Name = G.name
            newItem.Type = 2
            newItem.ID = G.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(G.name)
        Next

        For Each G As Engine.RainGen In Engine.Rains
            Dim newItem As New Engine.ObjectItem
            newItem.Name = G.name
            newItem.Type = 3
            newItem.ID = G.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(G.name)
        Next

        For Each G As Engine.SprayGen In Engine.Sprays
            Dim newItem As New Engine.ObjectItem
            newItem.Name = G.name
            newItem.Type = 4
            newItem.ID = G.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(G.name)
        Next

        For Each G As Engine.RandomGen In Engine.Randoms
            Dim newItem As New Engine.ObjectItem
            newItem.Name = G.name
            newItem.Type = 10
            newItem.ID = G.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(G.name)
        Next

        For Each G As Engine.BitmapGen In Engine.Bitmaps
            Dim newItem As New Engine.ObjectItem
            newItem.Name = G.name
            newItem.Type = 32
            newItem.ID = G.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(G.name)
        Next

        For Each F As Engine.Wind In Engine.Winds
            Dim newItem As New Engine.ObjectItem
            newItem.Name = F.name
            newItem.Type = 100
            newItem.ID = F.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(F.name)
        Next

        For Each F As Engine.Expant In Engine.Expants
            Dim newItem As New Engine.ObjectItem
            newItem.Name = F.name
            newItem.Type = 101
            newItem.ID = F.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(F.name)
        Next

        For Each F As Engine.BlackHole In Engine.BlackHoles
            Dim newItem As New Engine.ObjectItem
            newItem.Name = F.name
            newItem.Type = 102
            newItem.ID = F.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(F.name)
        Next

        For Each F As Engine.Fan In Engine.Fans
            Dim newItem As New Engine.ObjectItem
            newItem.Name = F.name
            newItem.Type = 103
            newItem.ID = F.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(F.name)
        Next

        For Each f As Engine.Whirlpool In Engine.Whirlpools
            Dim newItem As New Engine.ObjectItem
            newItem.Name = f.name
            newItem.Type = 104
            newItem.ID = f.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(f.name)
        Next

        For Each E As Engine.Expiry In Engine.Expirys
            Dim newItem As New Engine.ObjectItem
            newItem.Name = E.name
            newItem.Type = 1
            newItem.ID = E.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(E.name)
        Next

        For Each G As Engine.Camera In Engine.Cameras
            Dim newItem As New Engine.ObjectItem
            newItem.Name = G.name
            newItem.Type = 255
            newItem.ID = G.ID

            lstObjectsBG.Add(newItem)
            lstObjects.Items.Add(G.name)
        Next

        If lstObjects.Items.Count > SelTemp Then lstObjects.SelectedIndex = SelTemp

        RefreshFrame()
    End Sub

    Sub RefreshFrame()
        Frame = New Bitmap(pnlMain.Width, pnlMain.Height, Imaging.PixelFormat.Format24bppRgb)

        Using Gr As Graphics = Graphics.FromImage(Frame), mx As New Drawing2D.Matrix(Zoom, 0, 0, Zoom, OffSet.X, OffSet.Y)
            Gr.Clear(pnlMain.BackColor)

            If Engine.StaticMap IsNot Nothing Then Gr.DrawImage(Engine.StaticMap, OffSet.X, OffSet.Y, Engine.StaticMap.Width, Engine.StaticMap.Height)

            For Each E As Engine.Expiry In Engine.Expirys
                DrawExpiry(Gr, mx, E.y, Frame.Width)
            Next

            For Each F As Engine.Wind In Engine.Winds
                DrawWind(Gr, mx, F.x, F.y, F.Widht, F.Height)
            Next
            For Each F As Engine.Expant In Engine.Expants
                DrawExpant(Gr, mx, F.x, F.y, F.R)
            Next
            For Each F As Engine.BlackHole In Engine.BlackHoles
                DrawBlackHole(Gr, mx, F.x, F.y, F.R)
            Next
            For Each F As Engine.Fan In Engine.Fans
                DrawFan(Gr, mx, F.x, F.y, F.R)
            Next
            For Each F As Engine.Whirlpool In Engine.Whirlpools
                DrawWhirlpool(Gr, mx, F.x, F.y, F.R)
            Next

            For Each G As Engine.PointGen In Engine.Points
                DrawPoint(Gr, mx, G.x, G.y, G.Noice)
            Next
            For Each G As Engine.RainGen In Engine.Rains
                DrawRain(Gr, mx, G.x, G.y, G.Widht)
            Next
            For Each G As Engine.SprayGen In Engine.Sprays
                DrawSpary(Gr, mx, G.x, G.y, G.Slope, G.Noice)
            Next
            For Each G As Engine.RandomGen In Engine.Randoms
                DrawBitmap(Gr, mx, G.x, G.y, G.Widht, G.Height)
            Next
            For Each G As Engine.BitmapGen In Engine.Bitmaps
                DrawBitmap(Gr, mx, G.x, G.y, G.Widht, G.Height)
            Next

            'if you add a new gen, don't forget to add it on rendering function

            For Each C As Engine.Camera In Engine.Cameras
                DrawCam(Gr, mx, C.x, C.y, C.Widht, C.Height)
            Next

            pnlMain.Refresh()
        End Using
    End Sub
    Sub RefreshNavigator()
        Dim Thumpnail As New Bitmap(pnlNavigator.Width, pnlNavigator.Height, Imaging.PixelFormat.Format24bppRgb)

        Using Gr As Graphics = Graphics.FromImage(Thumpnail)
            Gr.Clear(pnlNavigator.BackColor)

            If Engine.StaticMap IsNot Nothing Then Gr.DrawImage(Engine.StaticMap, OffSet.X * pnlNavigator.Height \ WORKPLACE.Height, OffSet.Y * pnlNavigator.Height \ WORKPLACE.Height, Engine.StaticMap.Width * pnlNavigator.Height \ WORKPLACE.Height, Engine.StaticMap.Height * pnlNavigator.Height \ WORKPLACE.Height)


            For Each E As Engine.Expiry In Engine.Expirys
                Gr.DrawLine(Pens.Red, 0, E.y * pnlNavigator.Height \ WORKPLACE.Height, pnlNavigator.Width, E.y * pnlNavigator.Height \ WORKPLACE.Height)
            Next

            For Each F As Engine.Wind In Engine.Winds
                Gr.DrawRectangle(Pens.Cyan, F.x * pnlNavigator.Width \ WORKPLACE.Width, F.y * pnlNavigator.Height \ WORKPLACE.Height, F.Widht * pnlNavigator.Width \ WORKPLACE.Width, F.Height * pnlNavigator.Height \ WORKPLACE.Height)
            Next
            For Each F As Engine.Expant In Engine.Expants
                Gr.DrawEllipse(Pens.Cyan, F.x * pnlNavigator.Width \ WORKPLACE.Width, F.y * pnlNavigator.Height \ WORKPLACE.Height, F.R * 2 * pnlNavigator.Width \ WORKPLACE.Width, F.R * 2 * pnlNavigator.Height \ WORKPLACE.Height)
            Next
            For Each F As Engine.BlackHole In Engine.BlackHoles
                Gr.DrawEllipse(Pens.Cyan, F.x * pnlNavigator.Width \ WORKPLACE.Width, F.y * pnlNavigator.Height \ WORKPLACE.Height, F.R * 2 * pnlNavigator.Width \ WORKPLACE.Width, F.R * 2 * pnlNavigator.Height \ WORKPLACE.Height)
            Next
            For Each F As Engine.Fan In Engine.Fans
                Gr.DrawEllipse(Pens.Cyan, F.x * pnlNavigator.Width \ WORKPLACE.Width, F.y * pnlNavigator.Height \ WORKPLACE.Height, F.R * 2 * pnlNavigator.Width \ WORKPLACE.Width, F.R * 2 * pnlNavigator.Height \ WORKPLACE.Height)
            Next
            For Each F As Engine.Whirlpool In Engine.Whirlpools
                Gr.DrawEllipse(Pens.Cyan, F.x * pnlNavigator.Width \ WORKPLACE.Width, F.y * pnlNavigator.Height \ WORKPLACE.Height, F.R * 2 * pnlNavigator.Width \ WORKPLACE.Width, F.R * 2 * pnlNavigator.Height \ WORKPLACE.Height)
            Next

            For Each G As Engine.PointGen In Engine.Points
                Gr.DrawRectangle(Pens.Blue, G.x * pnlNavigator.Width \ WORKPLACE.Width, G.y * pnlNavigator.Height \ WORKPLACE.Height, 1, 1)
            Next
            For Each G As Engine.RainGen In Engine.Rains
                Gr.DrawLine(Pens.Blue, G.x * pnlNavigator.Width \ WORKPLACE.Width, G.y * pnlNavigator.Height \ WORKPLACE.Height, (G.x + G.Widht) * pnlNavigator.Width \ WORKPLACE.Width, G.y * pnlNavigator.Height \ WORKPLACE.Height)
            Next
            For Each G As Engine.SprayGen In Engine.Sprays
                Gr.DrawRectangle(Pens.Blue, G.x * pnlNavigator.Width \ WORKPLACE.Width, G.y * pnlNavigator.Height \ WORKPLACE.Height, 1, 1)
            Next
            For Each G As Engine.RandomGen In Engine.Randoms
                Gr.DrawRectangle(Pens.Blue, G.x * pnlNavigator.Width \ WORKPLACE.Width, G.y * pnlNavigator.Height \ WORKPLACE.Height, G.Widht * pnlNavigator.Width \ WORKPLACE.Width, G.Height * pnlNavigator.Height \ WORKPLACE.Height)
            Next
            For Each G As Engine.BitmapGen In Engine.Bitmaps
                Gr.DrawRectangle(Pens.Blue, G.x * pnlNavigator.Width \ WORKPLACE.Width, G.y * pnlNavigator.Height \ WORKPLACE.Height, G.Widht * pnlNavigator.Width \ WORKPLACE.Width, G.Height * pnlNavigator.Height \ WORKPLACE.Height)
            Next

            For Each C As Engine.Camera In Engine.Cameras
                Gr.DrawRectangle(Pens.Yellow, C.x * pnlNavigator.Width \ WORKPLACE.Width, C.y * pnlNavigator.Height \ WORKPLACE.Height, C.Widht * pnlNavigator.Width \ WORKPLACE.Width, C.Height * pnlNavigator.Height \ WORKPLACE.Height)
            Next

            pnlNavigator.BackgroundImage = Thumpnail
        End Using
    End Sub

    Public Sub ChangeVals(Optional ByVal RefreshTheFrame As Boolean = True)
        If lstObjects.SelectedIndex = -1 Then Exit Sub

        Select Case lstObjectsBG(lstObjects.SelectedIndex).Type
            Case 1 'expiry
                For i As Integer = 0 To Engine.Expirys.Count - 1
                    If Engine.Expirys(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newExpiry As New Engine.Expiry
                        newExpiry.name = txtName.Value
                        newExpiry.ID = Expirys(i).ID
                        newExpiry.y = txtY.Value
                        Engine.Expirys(i) = newExpiry

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 1
                        newItem.ID = Engine.Expirys(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

            Case 2 'point
                For i As Integer = 0 To Engine.Points.Count - 1
                    If Engine.Points(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newPointGen As New Engine.PointGen
                        newPointGen.name = txtName.Value
                        newPointGen.ID = Points(i).ID
                        newPointGen.x = txtX.Value
                        newPointGen.y = txtY.Value
                        newPointGen.Noice = txtNoice.Value
                        newPointGen.R = txtR.Value
                        newPointGen.startGen = txtStart.Value
                        newPointGen.stopGen = txtStop.Value
                        newPointGen.ppf = txtPPF.Value
                        newPointGen.Life = txtLife.Value
                        newPointGen.Color = cmdColor.BackColor

                        newPointGen.wNoice = txtNoice.WaveControl
                        newPointGen.wR = txtR.WaveControl
                        newPointGen.wPPF = txtPPF.WaveControl

                        Points(i) = newPointGen

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 2
                        newItem.ID = Engine.Points(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

            Case 3 'rain
                For i As Integer = 0 To Engine.Rains.Count - 1
                    If Engine.Rains(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newRainGen As New Engine.RainGen
                        newRainGen.name = txtName.Value
                        newRainGen.ID = Rains(i).ID
                        newRainGen.x = txtX.Value
                        newRainGen.y = txtY.Value
                        newRainGen.Widht = txtWidth.Value
                        newRainGen.F0 = txtF0.Value
                        newRainGen.Noice = txtNoice.Value
                        newRainGen.R = txtR.Value
                        newRainGen.startGen = txtStart.Value
                        newRainGen.stopGen = txtStop.Value
                        newRainGen.ppf = txtPPF.Value
                        newRainGen.Life = txtLife.Value
                        newRainGen.Color = cmdColor.BackColor

                        newRainGen.wF0 = txtF0.WaveControl
                        newRainGen.wNoice = txtNoice.WaveControl
                        newRainGen.wR = txtR.WaveControl
                        newRainGen.wPPF = txtPPF.WaveControl

                        Engine.Rains(i) = newRainGen

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 3
                        newItem.ID = Engine.Rains(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

            Case 4 'spray
                For i As Integer = 0 To Engine.Sprays.Count - 1
                    If Engine.Sprays(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newSprayGen As New Engine.SprayGen
                        newSprayGen.name = txtName.Value
                        newSprayGen.ID = Sprays(i).ID
                        newSprayGen.x = txtX.Value
                        newSprayGen.y = txtY.Value
                        newSprayGen.Slope = txtSlope.Value
                        newSprayGen.F0 = txtF0.Value
                        newSprayGen.Noice = txtNoice.Value
                        newSprayGen.R = txtR.Value
                        newSprayGen.startGen = txtStart.Value
                        newSprayGen.stopGen = txtStop.Value
                        newSprayGen.ppf = txtPPF.Value
                        newSprayGen.Life = txtLife.Value
                        newSprayGen.Color = cmdColor.BackColor

                        newSprayGen.wF0 = txtF0.WaveControl
                        newSprayGen.wNoice = txtNoice.WaveControl
                        newSprayGen.wR = txtR.WaveControl
                        newSprayGen.wPPF = txtPPF.WaveControl

                        Engine.Sprays(i) = newSprayGen

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 4
                        newItem.ID = Sprays(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

            Case 10 'random
                For i As Integer = 0 To Engine.Randoms.Count - 1
                    If Engine.Randoms(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newRandom As New Engine.RandomGen
                        newRandom.name = txtName.Value
                        newRandom.ID = Randoms(i).ID
                        newRandom.x = txtX.Value
                        newRandom.y = txtY.Value
                        newRandom.Widht = txtWidth.Value
                        newRandom.Height = txtHeight.Value
                        newRandom.R = txtR.Value
                        newRandom.startGen = txtStart.Value
                        newRandom.stopGen = txtStop.Value
                        newRandom.ppf = txtPPF.Value
                        newRandom.Life = txtLife.Value
                        newRandom.Color = cmdColor.BackColor
                        Engine.Randoms(i) = newRandom

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 32
                        newItem.ID = Bitmaps(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

            Case 32 'bitmap
                For i As Integer = 0 To Engine.Bitmaps.Count - 1
                    If Engine.Bitmaps(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newBitmap As New Engine.BitmapGen
                        newBitmap.name = txtName.Value
                        newBitmap.ID = Bitmaps(i).ID
                        newBitmap.x = txtX.Value
                        newBitmap.y = txtY.Value
                        newBitmap.Widht = txtWidth.Value
                        newBitmap.Height = txtHeight.Value
                        newBitmap.R = txtR.Value
                        newBitmap.startGen = txtStart.Value
                        newBitmap.Life = txtLife.Value
                        newBitmap.BitmapPath = txtBitmap.Value
                        Engine.Bitmaps(i) = newBitmap

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 32
                        newItem.ID = Bitmaps(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

            Case 100 'wind
                For i As Integer = 0 To Engine.Winds.Count - 1
                    If Engine.Winds(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newWind As New Engine.Wind
                        newWind.name = txtName.Value
                        newWind.ID = Winds(i).ID
                        newWind.x = txtX.Value
                        newWind.y = txtY.Value
                        newWind.Widht = txtWidth.Value
                        newWind.Height = txtHeight.Value
                        newWind.F = txtF0.Value

                        Engine.Winds(i) = newWind

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 100
                        newItem.ID = Winds(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

            Case 101 ' expant
                For i As Integer = 0 To Engine.Expants.Count - 1
                    If Engine.Expants(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newExpant As New Engine.Expant
                        newExpant.name = txtName.Value
                        newExpant.ID = Expants(i).ID
                        newExpant.x = txtX.Value
                        newExpant.y = txtY.Value
                        newExpant.R = txtR.Value
                        newExpant.F = txtF0.Value
                        Engine.Expants(i) = newExpant

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 101
                        newItem.ID = Expants(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

            Case 102 ' black hole
                For i As Integer = 0 To Engine.BlackHoles.Count - 1
                    If Engine.BlackHoles(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newBlackHole As New Engine.BlackHole
                        newBlackHole.name = txtName.Value
                        newBlackHole.ID = BlackHoles(i).ID
                        newBlackHole.x = txtX.Value
                        newBlackHole.y = txtY.Value
                        newBlackHole.R = txtR.Value
                        newBlackHole.F = txtF0.Value
                        Engine.BlackHoles(i) = newBlackHole

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 102
                        newItem.ID = BlackHoles(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

            Case 103 'fan
                For i As Integer = 0 To Engine.Fans.Count - 1
                    If Engine.Fans(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newFan As New Engine.Fan
                        newFan.name = txtName.Value
                        newFan.ID = Fans(i).ID
                        newFan.x = txtX.Value
                        newFan.y = txtY.Value
                        newFan.R = txtR.Value
                        newFan.F = txtF0.Value
                        Engine.Fans(i) = newFan

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 103
                        newItem.ID = Fans(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

            Case 104 'whirlpool
                For i As Integer = 0 To Engine.Whirlpools.Count - 1
                    If Engine.Whirlpools(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newWhirlpool As New Engine.Whirlpool
                        newWhirlpool.name = txtName.Value
                        newWhirlpool.ID = Whirlpools(i).ID
                        newWhirlpool.x = txtX.Value
                        newWhirlpool.y = txtY.Value
                        newWhirlpool.R = txtR.Value
                        newWhirlpool.F = txtF0.Value
                        Engine.Whirlpools(i) = newWhirlpool

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 104
                        newItem.ID = Whirlpools(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

            Case 255 'cams
                For i As Integer = 0 To Engine.Cameras.Count - 1
                    If Engine.Cameras(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then

                        Dim newCam As New Engine.Camera
                        newCam.name = txtName.Value
                        newCam.ID = Cameras(i).ID
                        newCam.x = txtX.Value
                        newCam.y = txtY.Value
                        newCam.Widht = txtWidth.Value
                        newCam.Height = txtHeight.Value
                        Engine.Cameras(i) = newCam

                        If lstObjects.SelectedItem.ToString = txtName.Value Then GoTo done

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = txtName.Value
                        newItem.Type = 255
                        newItem.ID = Cameras(i).ID
                        lstObjectsBG(lstObjects.SelectedIndex) = newItem

                        GoTo Done
                    End If
                Next

        End Select

Done:
        If Not lstObjects.Items(lstObjects.SelectedIndex) = txtName.Value Then lstObjects.Items(lstObjects.SelectedIndex) = txtName.Value
        If RefreshTheFrame Then RefreshFrame()
    End Sub

    Sub SelectObject(ByVal e As Point)
        For Each F As Engine.Wind In Engine.Winds
            If e.X > F.x And e.X < F.x + F.Widht And e.Y > F.y And e.Y < F.y + F.Height Then

                For i As Integer = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = F.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next
        For Each F As Engine.Expant In Engine.Expants
            If Math.Sqrt((e.X - F.x - F.R) ^ 2 + (e.Y - F.y - F.R) ^ 2) < F.R Then

                For i As Integer = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = F.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next
        For Each F As Engine.BlackHole In Engine.BlackHoles
            If Math.Sqrt((e.X - F.x - F.R) ^ 2 + (e.Y - F.y - F.R) ^ 2) < F.R Then

                For i As Integer = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = F.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next
        For Each F As Engine.Fan In Engine.Fans
            If Math.Sqrt((e.X - F.x - F.R) ^ 2 + (e.Y - F.y - F.R) ^ 2) < F.R Then

                For i As Integer = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = F.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next
        For Each F As Engine.Whirlpool In Engine.Whirlpools
            If Math.Sqrt((e.X - F.x - F.R) ^ 2 + (e.Y - F.y - F.R) ^ 2) < F.R Then

                For i As Integer = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = F.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next

        For Each G As Engine.PointGen In Engine.Points
            If Math.Sqrt((e.X - G.x) ^ 2 + (e.Y - G.y) ^ 2) < G.Noice Then

                For i As Integer = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = G.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next
        For Each G As Engine.RainGen In Engine.Rains
            If e.X > G.x And e.X < G.x + G.Widht And e.Y > G.y - 2 And e.Y < G.y + 6 Then

                For i As Integer = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = G.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next
        For Each G As Engine.SprayGen In Engine.Sprays
            If Math.Sqrt((e.X - G.x) ^ 2 + (e.Y - G.y) ^ 2) < 16 Then

                For i As Integer = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = G.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next
        For Each G As Engine.RandomGen In Engine.Randoms
            If e.X > G.x And e.X < G.x + G.Widht And e.Y > G.y And e.Y < G.y + G.Height Then

                For i As Integer = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = G.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next
        For Each G As Engine.BitmapGen In Engine.Bitmaps
            If e.X > G.x And e.X < G.x + G.Widht And e.Y > G.y And e.Y < G.y + G.Height Then

                For i As Integer = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = G.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next

        For Each C As Engine.Camera In Engine.Cameras
            If e.X > C.x And e.X < C.x + C.Widht And e.Y > C.y And e.Y < C.y + C.Height Then

                For i As Integer = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = C.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next

        For Each Ex As Engine.Expiry In Engine.Expirys
            If e.Y > Ex.y - 3 And e.Y < Ex.y + 3 Then

                For i = 0 To lstObjectsBG.Count - 1
                    If lstObjectsBG(i).ID = Ex.ID Then
                        If lstObjects.SelectedIndex <> i Then
                            lstObjects.SelectedIndex = i
                            Exit Sub
                        End If
                    End If
                Next

            End If
        Next

        lstObjects.SelectedIndex = -1
    End Sub

    Private Sub cmdLoadGens_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLoadGens.Click
        cmdLoadGens.BackgroundImage = My.Resources.FatTab1
        cmdLoadForces.BackgroundImage = My.Resources.FatTab0
        cmdLoadDraws.BackgroundImage = My.Resources.FatTab0
        cmdLoadCams.BackgroundImage = My.Resources.FatTab0
        LoadGens()
        lstTools.Select()
    End Sub
    Private Sub cmdLoadForces_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLoadForces.Click
        cmdLoadGens.BackgroundImage = My.Resources.FatTab0
        cmdLoadForces.BackgroundImage = My.Resources.FatTab1
        cmdLoadDraws.BackgroundImage = My.Resources.FatTab0
        cmdLoadCams.BackgroundImage = My.Resources.FatTab0
        LoadForces()
        lstTools.Select()
    End Sub
    Private Sub cmdLoadDraws_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLoadDraws.Click
        cmdLoadGens.BackgroundImage = My.Resources.FatTab0
        cmdLoadForces.BackgroundImage = My.Resources.FatTab0
        cmdLoadDraws.BackgroundImage = My.Resources.FatTab1
        cmdLoadCams.BackgroundImage = My.Resources.FatTab0
        LoadDraws()
        lstTools.Select()
    End Sub
    Private Sub cmdLoadCams_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLoadCams.Click
        cmdLoadGens.BackgroundImage = My.Resources.FatTab0
        cmdLoadForces.BackgroundImage = My.Resources.FatTab0
        cmdLoadDraws.BackgroundImage = My.Resources.FatTab0
        cmdLoadCams.BackgroundImage = My.Resources.FatTab1
        LoadCams()
        lstTools.Select()
    End Sub

    Private Sub cmdLoadGens_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles cmdLoadGens.Paint
        e.Graphics.DrawImage(My.Resources.GensMenu, 6, 4, 28, 28)
    End Sub
    Private Sub cmdLoadForces_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles cmdLoadForces.Paint
        e.Graphics.DrawImage(My.Resources.ForceMenu, 6, 4, 28, 28)
    End Sub
    Private Sub cmdLoadDraws_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles cmdLoadDraws.Paint
        e.Graphics.DrawImage(My.Resources.DrawMenu, 6, 4, 28, 28)
    End Sub
    Private Sub cmdLoadCams_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles cmdLoadCams.Paint
        e.Graphics.DrawImage(My.Resources.CamsMenu, 6, 4, 28, 28)
    End Sub

    Private Sub frmMain_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        RefreshFrame()
    End Sub

    Private Sub pnlSide_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlSide.Resize
        lstTools.Height = pnlSide.Height \ 3.5
    End Sub

    Private Sub pnlRulerH_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlRulerH.Paint
        For i As Integer = 0 To pnlRulerH.Width Step 25
            If i Mod 100 = 0 Then
                If i <> 0 Then e.Graphics.DrawString(Math.Round((i - OffSet.X), 1), Me.Font, Brushes.Black, i, 8, StringFormatCenterHor)
            ElseIf i Mod 50 = 0 Then
                e.Graphics.FillRectangle(Brushes.Black, i, 5, 1, 6)
            Else 'If i Mod 25 = 0 Then
                e.Graphics.FillRectangle(Brushes.Gray, i, 6, 1, 4)
            End If
        Next
    End Sub
    Private Sub pnlRulerV_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlRulerV.Paint
        For i As Integer = 0 To pnlRulerV.Height Step 25
            If i Mod 100 = 0 Then
                If i <> 0 Then e.Graphics.DrawString(Math.Round((i - OffSet.Y), 1), Me.Font, Brushes.Black, 8, i, StringFormatCenterVer)
            ElseIf i Mod 50 = 0 Then
                e.Graphics.FillRectangle(Brushes.Black, 5, i, 6, 1)
            Else 'If i Mod 25 = 0 Then
                e.Graphics.FillRectangle(Brushes.Gray, 6, i, 4, 1)
            End If
        Next
    End Sub

    Private Sub lstObjects_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles lstObjects.DrawItem
        If e.Index = -1 Then Exit Sub

        If e.Index Mod 2 = 0 Then
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(140, 140, 140)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        Else
            e.Graphics.FillRectangle(New SolidBrush(Color.Gray), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        End If

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(160, 160, 160)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        End If

        e.Graphics.DrawString(lstObjectsBG(e.Index).Name, Me.Font, New SolidBrush(Color.FromArgb(255, 255, 255)), e.Bounds.X + 18, e.Bounds.Y)

        Select Case lstObjectsBG(e.Index).Type
            Case 0 'static
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(128, Color.Green)), e.Bounds.X + 2, e.Bounds.Y + 1, 14, 14)

            Case 1 'expiry point
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(128, Color.Red)), e.Bounds.X + 2, e.Bounds.Y + 1, 14, 14)

            Case 2, 3, 4, 10, 32 'gen
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(128, Color.Blue)), e.Bounds.X + 2, e.Bounds.Y + 1, 14, 14)

            Case 100, 101, 102, 103, 104 'force
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(128, Color.Cyan)), e.Bounds.X + 2, e.Bounds.Y + 1, 14, 14)

            Case 255 'camera
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(128, Color.Yellow)), e.Bounds.X + 2, e.Bounds.Y + 1, 14, 14)

        End Select

    End Sub

    Private Sub lstObjects_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstObjects.SelectedIndexChanged
        pnlParameters.Hide()

        pnlName.Hide()
        pnlX.Hide()
        pnlY.Hide()
        pnlX2.Hide()
        pnlY2.Hide()
        pnlWidth.Hide()
        pnlHeight.Hide()
        pnlSlope.Hide()
        pnlNoice.Hide()
        pnlR.Hide()
        pnlF0.Hide()
        pnlPPF.Hide()
        pnlStart.Hide()
        pnlStop.Hide()
        pnlLife.Hide()
        pnlColor.Hide()
        pnlBitmap.Hide()

        txtX.WaveControl = Nothing
        txtY.WaveControl = Nothing
        txtX2.WaveControl = Nothing
        txtWidth.WaveControl = Nothing
        txtHeight.WaveControl = Nothing
        txtSlope.WaveControl = Nothing
        txtNoice.WaveControl = Nothing
        txtR.WaveControl = Nothing
        txtF0.WaveControl = Nothing
        txtPPF.WaveControl = Nothing
        txtStart.WaveControl = Nothing
        txtStop.WaveControl = Nothing
        txtLife.WaveControl = Nothing

        txtX.isLinkable = False
        txtY.isLinkable = False
        txtX2.isLinkable = False
        txtWidth.isLinkable = False
        txtHeight.isLinkable = False
        txtSlope.isLinkable = False
        txtNoice.isLinkable = False
        txtR.isLinkable = False
        txtF0.isLinkable = False
        txtPPF.isLinkable = False
        txtStart.isLinkable = False
        txtStop.isLinkable = False
        txtLife.isLinkable = False

        If lstObjects.SelectedIndex = -1 Then Exit Sub

        Select Case lstObjectsBG(lstObjects.SelectedIndex).Type

            Case 1 'expiry
                For i As Integer = 0 To Engine.Expirys.Count - 1
                    If Engine.Expirys(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.Expirys(i).name)
                        txtY.SetValue(Engine.Expirys(i).y)
                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlY.Show()

            Case 2 'point
                For i As Integer = 0 To Engine.Points.Count - 1
                    If Engine.Points(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.Points(i).name)
                        txtX.SetValue(Engine.Points(i).x)
                        txtY.SetValue(Engine.Points(i).y)
                        txtNoice.SetValue(Engine.Points(i).Noice)
                        txtR.SetValue(Engine.Points(i).R)
                        txtStart.SetValue(Engine.Points(i).startGen)
                        txtStop.SetValue(Engine.Points(i).stopGen)
                        txtPPF.SetValue(Engine.Points(i).ppf)
                        txtLife.SetValue(Engine.Points(i).Life)
                        cmdColor.BackColor = Engine.Points(i).Color

                        txtNoice.isLinkable = True
                        txtPPF.isLinkable = True
                        txtR.isLinkable = True

                        txtNoice.WaveControl = Engine.Points(i).wNoice
                        txtPPF.WaveControl = Engine.Points(i).wPPF
                        txtR.WaveControl = Engine.Points(i).wR

                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlX.Show()
                pnlY.Show()
                pnlNoice.Show()
                pnlR.Show()
                pnlPPF.Show()
                pnlStart.Show()
                pnlStop.Show()
                pnlLife.Show()
                pnlColor.Show()

            Case 3 'rain
                For i As Integer = 0 To Engine.Rains.Count - 1
                    If Engine.Rains(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.Rains(i).name)
                        txtX.SetValue(Engine.Rains(i).x)
                        txtY.SetValue(Engine.Rains(i).y)
                        txtWidth.SetValue(Engine.Rains(i).Widht)
                        txtF0.SetValue(Engine.Rains(i).F0)
                        txtNoice.SetValue(Engine.Rains(i).Noice)
                        txtR.SetValue(Engine.Rains(i).R)
                        txtStart.SetValue(Engine.Rains(i).startGen)
                        txtStop.SetValue(Engine.Rains(i).stopGen)
                        txtPPF.SetValue(Engine.Rains(i).ppf)
                        txtLife.SetValue(Engine.Rains(i).Life)
                        cmdColor.BackColor = Engine.Rains(i).Color

                        txtF0.isLinkable = True
                        txtNoice.isLinkable = True
                        txtR.isLinkable = True
                        txtPPF.isLinkable = True

                        txtF0.WaveControl = Engine.Rains(i).wF0
                        txtNoice.WaveControl = Engine.Rains(i).wNoice
                        txtR.WaveControl = Engine.Rains(i).wR
                        txtPPF.WaveControl = Engine.Rains(i).wPPF

                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlX.Show()
                pnlY.Show()
                pnlWidth.Show()
                pnlNoice.Show()
                pnlR.Show()
                pnlF0.Show()
                pnlPPF.Show()
                pnlStart.Show()
                pnlStop.Show()
                pnlLife.Show()
                pnlColor.Show()

            Case 4 'spray
                For i As Integer = 0 To Engine.Sprays.Count - 1
                    If Engine.Sprays(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.Sprays(i).name)
                        txtX.SetValue(Engine.Sprays(i).x)
                        txtY.SetValue(Engine.Sprays(i).y)
                        txtSlope.SetValue(Engine.Sprays(i).Slope)
                        txtF0.SetValue(Engine.Sprays(i).F0)
                        txtNoice.SetValue(Engine.Sprays(i).Noice)
                        txtR.SetValue(Engine.Sprays(i).R)
                        txtStart.SetValue(Engine.Sprays(i).startGen)
                        txtStop.SetValue(Engine.Sprays(i).stopGen)
                        txtPPF.SetValue(Engine.Sprays(i).ppf)
                        txtLife.SetValue(Engine.Sprays(i).Life)
                        cmdColor.BackColor = Engine.Sprays(i).Color

                        txtF0.isLinkable = True
                        txtNoice.isLinkable = True
                        txtR.isLinkable = True
                        txtPPF.isLinkable = True

                        txtF0.WaveControl = Engine.Sprays(i).wF0
                        txtNoice.WaveControl = Engine.Sprays(i).wNoice
                        txtR.WaveControl = Engine.Sprays(i).wR
                        txtPPF.WaveControl = Engine.Sprays(i).wPPF

                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlX.Show()
                pnlY.Show()
                pnlSlope.Show()
                pnlNoice.Show()
                pnlR.Show()
                pnlF0.Show()
                pnlPPF.Show()
                pnlStart.Show()
                pnlStop.Show()
                pnlLife.Show()
                pnlColor.Show()

            Case 10 'random
                For i As Integer = 0 To Engine.Randoms.Count - 1
                    If Engine.Randoms(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.Randoms(i).name)
                        txtX.SetValue(Engine.Randoms(i).x)
                        txtY.SetValue(Engine.Randoms(i).y)
                        txtWidth.SetValue(Engine.Randoms(i).Widht)
                        txtHeight.SetValue(Engine.Randoms(i).Height)
                        txtR.SetValue(Engine.Randoms(i).R)
                        txtStart.SetValue(Engine.Randoms(i).startGen)
                        txtStop.SetValue(Engine.Randoms(i).stopGen)
                        txtPPF.SetValue(Engine.Randoms(i).ppf)
                        txtLife.SetValue(Engine.Randoms(i).Life)
                        cmdColor.BackColor = Engine.Randoms(i).Color
                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlX.Show()
                pnlY.Show()
                pnlWidth.Show()
                pnlHeight.Show()
                pnlR.Show()
                pnlStart.Show()
                pnlStop.Show()
                pnlPPF.Show()
                pnlLife.Show()
                pnlColor.Show()

            Case 32 'bitmap
                For i As Integer = 0 To Engine.Bitmaps.Count - 1
                    If Engine.Bitmaps(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.Bitmaps(i).name)
                        txtX.SetValue(Engine.Bitmaps(i).x)
                        txtY.SetValue(Engine.Bitmaps(i).y)
                        txtWidth.SetValue(Engine.Bitmaps(i).Widht)
                        txtHeight.SetValue(Engine.Bitmaps(i).Height)
                        txtR.SetValue(Engine.Bitmaps(i).R)
                        txtStart.SetValue(Engine.Bitmaps(i).startGen)
                        txtLife.SetValue(Engine.Bitmaps(i).Life)
                        txtBitmap.SetValue(Engine.Bitmaps(i).BitmapPath)
                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlX.Show()
                pnlY.Show()
                pnlWidth.Show()
                pnlHeight.Show()
                pnlR.Show()
                pnlStart.Show()
                pnlLife.Show()
                pnlBitmap.Show()

            Case 100 'wind
                For i As Integer = 0 To Engine.Winds.Count - 1
                    If Engine.Winds(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.Winds(i).name)
                        txtX.SetValue(Engine.Winds(i).x)
                        txtY.SetValue(Engine.Winds(i).y)
                        txtWidth.SetValue(Engine.Winds(i).Widht)
                        txtHeight.SetValue(Engine.Winds(i).Height)
                        txtF0.SetValue(Engine.Winds(i).F)
                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlX.Show()
                pnlY.Show()
                pnlWidth.Show()
                pnlHeight.Show()
                pnlF0.Show()

            Case 101 'expant
                For i As Integer = 0 To Engine.Expants.Count - 1
                    If Engine.Expants(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.Expants(i).name)
                        txtX.SetValue(Engine.Expants(i).x)
                        txtY.SetValue(Engine.Expants(i).y)
                        txtR.SetValue(Engine.Expants(i).R)
                        txtF0.SetValue(Engine.Expants(i).F)
                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlX.Show()
                pnlY.Show()
                pnlR.Show()
                pnlF0.Show()

            Case 102 'black hole
                For i As Integer = 0 To Engine.BlackHoles.Count - 1
                    If Engine.BlackHoles(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.BlackHoles(i).name)
                        txtX.SetValue(Engine.BlackHoles(i).x)
                        txtY.SetValue(Engine.BlackHoles(i).y)
                        txtR.SetValue(Engine.BlackHoles(i).R)
                        txtF0.SetValue(Engine.BlackHoles(i).F)
                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlX.Show()
                pnlY.Show()
                pnlR.Show()
                pnlF0.Show()

            Case 103 'fan
                For i As Integer = 0 To Engine.Fans.Count - 1
                    If Engine.Fans(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.Fans(i).name)
                        txtX.SetValue(Engine.Fans(i).x)
                        txtY.SetValue(Engine.Fans(i).y)
                        txtR.SetValue(Engine.Fans(i).R)
                        txtF0.SetValue(Engine.Fans(i).F)
                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlX.Show()
                pnlY.Show()
                pnlR.Show()
                pnlF0.Show()

            Case 104 'whirlpool
                For i As Integer = 0 To Engine.Whirlpools.Count - 1
                    If Engine.Whirlpools(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.Whirlpools(i).name)
                        txtX.SetValue(Engine.Whirlpools(i).x)
                        txtY.SetValue(Engine.Whirlpools(i).y)
                        txtR.SetValue(Engine.Whirlpools(i).R)
                        txtF0.SetValue(Engine.Whirlpools(i).F)
                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlX.Show()
                pnlY.Show()
                pnlR.Show()
                pnlF0.Show()

            Case 255 'cam
                For i As Integer = 0 To Engine.Cameras.Count - 1
                    If Engine.Cameras(i).ID = lstObjectsBG(lstObjects.SelectedIndex).ID Then
                        txtName.SetValue(Engine.Cameras(i).name)
                        txtX.SetValue(Engine.Cameras(i).x)
                        txtY.SetValue(Engine.Cameras(i).y)
                        txtWidth.SetValue(Engine.Cameras(i).Widht)
                        txtHeight.SetValue(Engine.Cameras(i).Height)
                        Exit For
                    End If
                Next

                pnlName.Show()
                pnlX.Show()
                pnlY.Show()
                pnlWidth.Show()
                pnlHeight.Show()

        End Select

        'sort:
        pnlBitmap.SendToBack()
        pnlColor.SendToBack()
        pnlLife.SendToBack()
        pnlStop.SendToBack()
        pnlStart.SendToBack()
        pnlPPF.SendToBack()
        pnlF0.SendToBack()
        pnlR.SendToBack()
        pnlNoice.SendToBack()
        pnlSlope.SendToBack()
        pnlHeight.SendToBack()
        pnlWidth.SendToBack()
        pnlY2.SendToBack()
        pnlX2.SendToBack()
        pnlY.SendToBack()
        pnlX.SendToBack()
        pnlName.SendToBack()

        pnlParameters.Height = 0
        For i As Integer = 0 To pnlParameters.Controls.Count - 1
            pnlParameters.Height += pnlParameters.Controls(i).Height
        Next

        pnlParameters.Show()

        lstParameters.ResetMainList()
    End Sub


    Private Sub pnlMain_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlMain.Paint
        If Frame IsNot Nothing Then e.Graphics.DrawImage(Frame, 0, 0, Frame.Width, Frame.Height)
    End Sub

    Private Sub pnlMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlMain.Resize
        pnlNavigator.Location = New Point(pnlMain.Width - pnlNavigator.Width - 8, 8)
    End Sub

    Private Sub Render_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenderToolStripMenuItem1.Click

        If Engine.Cameras.Count = 0 Then
            MessageBox("There is no cameras in the scene", "No cameras", 1, 1)
            Exit Sub
        End If

        Dim frmR As New frmRender
        frmR.cmdOK.Text = "Render"
        frmR.pnlFrames.Height = frmR.FramesH
        frmR.pnlEnvironment.Height = frmR.EnvironmentH
        frmR.pnlParticles.Height = frmR.ParticlesH
        frmR.pnlReact.Height = frmR.ReactH
        frmR.ResizeMainList()

        If frmR.ShowDialog = DialogResult.OK Then
            Dim FinalRender As New frmRendering
            FinalRender.ShowDialog()
        End If

    End Sub

    Private Sub FramesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FramesToolStripMenuItem.Click
        Dim frmR As New frmRender
        frmR.pnlFrames.Height = frmR.FramesH
        frmR.pnlEnvironment.Height = 20
        frmR.pnlParticles.Height = 20
        frmR.pnlReact.Height = 20
        frmR.ResizeMainList()
        frmR.ShowDialog()
    End Sub
    Private Sub EnvironmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnvironmentToolStripMenuItem.Click
        Dim frmR As New frmRender
        frmR.pnlFrames.Height = 20
        frmR.pnlEnvironment.Height = frmR.EnvironmentH
        frmR.pnlParticles.Height = 20
        frmR.pnlReact.Height = 20
        frmR.ResizeMainList()
        frmR.ShowDialog()
    End Sub
    Private Sub ParticlesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParticlesToolStripMenuItem.Click
        Dim frmR As New frmRender
        frmR.pnlFrames.Height = 20
        frmR.pnlEnvironment.Height = 20
        frmR.pnlParticles.Height = frmR.ParticlesH
        frmR.pnlReact.Height = 20
        frmR.ResizeMainList()
        frmR.ShowDialog()
    End Sub
    Private Sub ReactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReactToolStripMenuItem.Click
        Dim frmR As New frmRender
        frmR.pnlFrames.Height = 20
        frmR.pnlEnvironment.Height = 20
        frmR.pnlParticles.Height = 20
        frmR.pnlReact.Height = frmR.ReactH
        frmR.ResizeMainList()
        frmR.ShowDialog()
    End Sub

    Private Sub PreviewAnimationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewAnimationToolStripMenuItem.Click
        Dim frmPrePre As New Form
        frmPrePre.Text = "Preview animation"
        frmPrePre.Icon = Me.Icon
        frmPrePre.ShowIcon = False
        frmPrePre.ShowInTaskbar = False
        frmPrePre.BackColor = Color.FromArgb(64, 64, 64)
        frmPrePre.ForeColor = Color.FromArgb(224, 224, 224)
        frmPrePre.Font = Me.Font
        frmPrePre.StartPosition = FormStartPosition.CenterParent
        frmPrePre.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        frmPrePre.ClientSize = New Size(300, 120)
        frmPrePre.MinimizeBox = False
        frmPrePre.MaximizeBox = False

        Dim lbl1 As New Label
        lbl1.AutoSize = True
        lbl1.Text = "Frames range:"

        Dim lbl2 As New Label
        lbl2.AutoSize = True
        lbl2.Text = " to "

        Dim txtFrom As New NumericUpDown
        txtFrom.Value = 0
        txtFrom.Enabled = False
        txtFrom.Width = 84
        txtFrom.BackColor = Color.DimGray
        txtFrom.ForeColor = Color.White

        Dim txtTo As New NumericUpDown
        txtTo.Value = 0
        txtTo.Minimum = 1
        txtTo.Maximum = 65535
        txtTo.Width = 84
        txtTo.Value = _FrameRangeTo
        txtTo.BackColor = Color.DimGray
        txtTo.ForeColor = Color.White

        Dim cmdOK As New Button
        cmdOK.Text = "OK"
        cmdOK.DialogResult = Windows.Forms.DialogResult.OK
        cmdOK.BackColor = Color.FromArgb(224, 244, 244)
        cmdOK.ForeColor = Color.FromArgb(32, 32, 32)

        Dim cmdCancel As New Button
        cmdCancel.Text = "Cancel"
        cmdCancel.DialogResult = Windows.Forms.DialogResult.Cancel
        cmdCancel.BackColor = Color.FromArgb(224, 244, 244)
        cmdCancel.ForeColor = Color.FromArgb(32, 32, 32)

        Dim lbl3 As New Label
        lbl3.AutoSize = True
        lbl3.Text = "Reactor Engine:"

        Dim cmbReactor As New ComboBox
        cmbReactor.Items.Add("Reactor 0.2b")
        cmbReactor.Items.Add("Reactor 1.0")
        cmbReactor.Items.Add("Space Reactor")
        cmbReactor.SelectedIndex = _ReactorIndex
        cmbReactor.DropDownStyle = ComboBoxStyle.DropDownList
        cmbReactor.BackColor = Color.DimGray
        cmbReactor.ForeColor = Color.White

        lbl1.Location = New Point(8, 16)
        txtFrom.Location = New Point(lbl1.Left + 90, 12)
        lbl2.Location = New Point(txtFrom.Left + txtFrom.Width, 16)
        txtTo.Location = New Point(lbl2.Left + 24, 12)

        lbl3.Location = New Point(8, 48)
        cmbReactor.Location = New Point(lbl3.Left + 90, 44)

        cmdOK.Location = New Point((frmPrePre.ClientSize.Width - cmdOK.Width - cmdCancel.Width - 8) \ 2, frmPrePre.ClientSize.Height - cmdOK.Height - 8)
        cmdCancel.Location = New Point(cmdOK.Left + cmdOK.Width + 8, frmPrePre.ClientSize.Height - cmdCancel.Height - 8)

        frmPrePre.Controls.Add(lbl1)
        frmPrePre.Controls.Add(lbl2)
        frmPrePre.Controls.Add(txtFrom)
        frmPrePre.Controls.Add(txtTo)
        frmPrePre.Controls.Add(lbl3)
        frmPrePre.Controls.Add(cmbReactor)
        frmPrePre.Controls.Add(cmdOK)
        frmPrePre.Controls.Add(cmdCancel)

        frmPrePre.AcceptButton = cmdOK
        frmPrePre.CancelButton = cmdCancel

        If frmPrePre.ShowDialog = Windows.Forms.DialogResult.OK Then
            _FrameRangeTo = txtTo.Value
            Dim frmPreviewAnim As New frmPreview(txtTo.Value, cmbReactor.SelectedIndex)
            frmPreviewAnim.Icon = Me.Icon
            frmPreviewAnim.Show()
            frmPreviewAnim.FPS = _FPS
        End If
        frmPrePre.Dispose()
    End Sub

    Dim mPosition As Point = New Point(0, 0)
    Private Sub pnlMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMain.MouseDown
        mPosition = Windows.Forms.Cursor.Position
        PreOffSet = OffSet

        If e.Button = Windows.Forms.MouseButtons.Middle Then
            RefreshNavigator()
            pnlNavigator.Show()

        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            'select
            SelectObject(New Point(e.X - OffSet.X, e.Y - OffSet.Y))
        End If

    End Sub
    Private Sub pnlMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMain.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Middle Then
            Dim x, y As Integer
            x = Windows.Forms.Cursor.Position.X - mPosition.X + PreOffSet.X
            y = Windows.Forms.Cursor.Position.Y - mPosition.Y + PreOffSet.Y
            If x > 0 Then x = 0
            If y > 0 Then y = 0

            If OffSet.X = x And OffSet.Y = y Then Exit Sub

            OffSet = New Point(x, y)
            RefreshFrame()
            pnlNavigator.Refresh()
            pnlRulerH.Refresh()
            pnlRulerV.Refresh()

            If System.Windows.Forms.Cursor.Position.X = 0 Then
                System.Windows.Forms.Cursor.Position = New Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 2, System.Windows.Forms.Cursor.Position.Y)
                mPosition = New Point(mPosition.X + Screen.PrimaryScreen.Bounds.Width, mPosition.Y)
            ElseIf System.Windows.Forms.Cursor.Position.X = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - 1 Then
                System.Windows.Forms.Cursor.Position = New Point(1, System.Windows.Forms.Cursor.Position.Y)
                mPosition = New Point(mPosition.X - Screen.PrimaryScreen.Bounds.Width, mPosition.Y)
            End If

            If System.Windows.Forms.Cursor.Position.Y = 0 Then
                System.Windows.Forms.Cursor.Position = New Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 2)
                mPosition = New Point(mPosition.X, mPosition.Y + Screen.PrimaryScreen.Bounds.Height)
            ElseIf System.Windows.Forms.Cursor.Position.Y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 1 Then
                System.Windows.Forms.Cursor.Position = New Point(System.Windows.Forms.Cursor.Position.X, 1)
                mPosition = New Point(mPosition.X, mPosition.Y - Screen.PrimaryScreen.Bounds.Height)
            End If

        End If
    End Sub
    Private Sub pnlMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMain.MouseUp
        pnlNavigator.Hide()
        pnlMain.Focus()
    End Sub
    Private Sub pnlNavigator_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlNavigator.Paint
        e.Graphics.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(128, 255, 0, 0))), _
                                 Math.Abs(OffSet.X) * pnlNavigator.Width \ WORKPLACE.Width, _
                                 Math.Abs(OffSet.Y) * pnlNavigator.Height \ WORKPLACE.Height, _
                                 pnlMain.Width * pnlNavigator.Width \ WORKPLACE.Width, _
                                 pnlMain.Height * pnlNavigator.Height \ WORKPLACE.Height)
    End Sub

    Private Sub ResetOffsetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetOffsetToolStripMenuItem.Click
        If Not (OffSet.X = 0 And OffSet.Y = 0) Then
            OffSet = New Point(0, 0)
            RefreshFrame()
            pnlRulerH.Refresh()
            pnlRulerV.Refresh()
        End If
    End Sub

    Private Sub tmrRamInfo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRamInfo.Tick
        Dim PhP As Integer = 0
        Dim ViP As Integer = 0

        Dim p As Diagnostics.Process = Diagnostics.Process.GetCurrentProcess

        PhP = pnlPhRam.Width * p.PrivateMemorySize64 \ My.Computer.Info.TotalPhysicalMemory
        ViP = pnlViRam.Width * p.VirtualMemorySize64 \ My.Computer.Info.TotalVirtualMemory

        p.Dispose()

        pnlRamPhP.Width = PhP
        pnlRamViP.Width = ViP

        pnlRamPhT.Width = pnlPhRam.Width * (My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) \ My.Computer.Info.TotalPhysicalMemory - PhP
        pnlRamViT.Width = pnlViRam.Width * (My.Computer.Info.TotalVirtualMemory - My.Computer.Info.AvailableVirtualMemory) \ My.Computer.Info.TotalVirtualMemory - ViP
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem.Click
        RefreshListObject()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteListObject()
    End Sub
    Private Sub ClearToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem1.Click
        ClearListObject()
    End Sub

    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        Dim frmImage As New OpenFileDialog
        frmImage.Filter = "All Images|*.bmp;*.dib;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.tiff;*.png|" & _
                        "Portable Network Graphics (*.png)|*.png|" & _
                        "Tagged Image File Format (*.tif;*.tiff)|*.tif;*.tiff|" & _
                        "Device Independent Bitmap|*.bmp;*.dib|" & _
                        "Joint Photographic Experts Group (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|" & _
                        "Graphics Interchange Format (*.gif)|*.gif|" & _
                        "All Files (*.*)|*.*"

        If frmImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            Engine.StaticMap = Image.FromFile(frmImage.FileName)
            RefreshFrame()
        End If
        frmImage.Dispose()
    End Sub
    Private Sub SaveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem1.Click
        If Engine.StaticMap Is Nothing Then Exit Sub

        Dim frmImage As New SaveFileDialog
        frmImage.Filter = "Portable Network Graphics (*.png)|*.png"

        If frmImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            Engine.StaticMap.Save(frmImage.FileName, Imaging.ImageFormat.Png)
        End If
        frmImage.Dispose()
    End Sub
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        If Engine.StaticMap Is Nothing Then Exit Sub

        Engine.StaticMap = Nothing
        RefreshFrame()
    End Sub

    Private Sub LoadToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem2.Click

    End Sub
    Private Sub SaveToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem3.Click

    End Sub
    Private Sub ClearToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem4.Click

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshFrame()
    End Sub
    Private Sub ShortcutsBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShortcutsBarToolStripMenuItem.Click
        My.Settings.ShowShortcutsBar = Not My.Settings.ShowShortcutsBar
        My.Settings.Save()

        pnlShortcutsBar.Visible = My.Settings.ShowShortcutsBar
        ShortcutsBarToolStripMenuItem.Checked = My.Settings.ShowShortcutsBar
    End Sub
    Private Sub RulerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RulerToolStripMenuItem.Click
        My.Settings.ShowRuler = Not My.Settings.ShowRuler
        My.Settings.Save()

        pnlRulerH.Visible = My.Settings.ShowRuler
        pnlRulerV.Visible = My.Settings.ShowRuler
        RulerToolStripMenuItem.Checked = My.Settings.ShowRuler
    End Sub

    Private Sub WarpMapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarpMapToolStripMenuItem.Click

        If Winds.Count = 0 And _
           Expants.Count = 0 And _
           BlackHoles.Count = 0 And _
           Fans.Count = 0 And _
           Whirlpools.Count = 0 Then

            MessageBox("There is no forces in the scene", "No forces", 1, 1)
            Exit Sub
        End If

        BuildWarp()
        Dim FinalPreview As Image = Engine.RenderWarpMap

        Dim frmShow As New Form
        frmShow.Text = "Warp map"
        frmShow.Icon = Me.Icon
        frmShow.BackColor = Me.BackColor
        frmShow.ClientSize = New Size(FinalPreview.Width / 2, FinalPreview.Height / 2)
        frmShow.BackgroundImageLayout = ImageLayout.Zoom
        frmShow.BackgroundImage = FinalPreview
        frmShow.Show()
    End Sub
    Private Sub WaveformsEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaveformsEditorToolStripMenuItem.Click
        frmWaveformsEditor.Icon = Me.Icon
        frmWaveformsEditor.Show()
        frmWaveformsEditor.Select()
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        RefreshToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub ResetOffsetToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetOffsetToolStripMenuItem1.Click
        ResetOffsetToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub SelectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectToolStripMenuItem.Click

    End Sub
    Private Sub MoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToolStripMenuItem.Click

    End Sub
    Private Sub ScaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScaleToolStripMenuItem.Click

    End Sub
    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        DeleteToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub ClearToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem2.Click
        ClearToolStripMenuItem1_Click(sender, e)
    End Sub

    Private Sub LanguageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LanguageToolStripMenuItem.Click
        Dim frmTransl As New Form
        frmTransl.Text = "Language"
        frmTransl.Icon = Me.Icon
        frmTransl.ShowIcon = False
        frmTransl.ShowInTaskbar = False
        frmTransl.BackColor = Color.FromArgb(64, 64, 64)
        frmTransl.ForeColor = Color.FromArgb(224, 224, 224)
        frmTransl.Font = Me.Font
        frmTransl.StartPosition = FormStartPosition.CenterParent
        frmTransl.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        frmTransl.ClientSize = New Size(360, 88)
        frmTransl.MinimizeBox = False
        frmTransl.MaximizeBox = False

        Dim cmbFrom As New ComboBox
        cmbFrom.Items.AddRange(New Object() {"[Autodetect]", "English", "Albanian", "Arabic", "Bulgarian", "Catalan", "Chinese", "Croatian", "Czech", "Danish", "Dutch", "Estonian", "Filipino", "Finnish", "French", "Galician", "German", "Greek", "Hebrew", "Hindi", "Hungarian", "Indonesian", "Italian", "Japanese", "Korean", "Latvian", "Lithuanian", "Maltese", "Norwegian", "Persian", "Polish", "Portuguese", "Romanian", "Russian", "Serbian", "Slovak", "Slovenian", "Spanish", "Swedish", "Thai", "Turkish", "Ukrainian", "Vietnamese"})
        cmbFrom.SelectedIndex = 0
        cmbFrom.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFrom.BackColor = Color.DimGray
        cmbFrom.ForeColor = Color.White
        cmbFrom.Location = New Point(24, 16)

        Dim cmbTo As New ComboBox
        cmbTo.Items.AddRange(New Object() {"English", "Albanian", "Arabic", "Bulgarian", "Catalan", "Chinese", "Croatian", "Czech", "Danish", "Dutch", "Estonian", "Filipino", "Finnish", "French", "Galician", "German", "Greek", "Hebrew", "Hindi", "Hungarian", "Indonesian", "Italian", "Japanese", "Korean", "Latvian", "Lithuanian", "Maltese", "Norwegian", "Persian", "Polish", "Portuguese", "Romanian", "Russian", "Serbian", "Slovak", "Slovenian", "Spanish", "Swedish", "Thai", "Turkish", "Ukrainian", "Vietnamese"})
        cmbTo.SelectedIndex = 0
        cmbTo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTo.BackColor = Color.DimGray
        cmbTo.ForeColor = Color.White
        cmbTo.Location = New Point(150, 16)

        Dim cmdOK As New Button
        cmdOK.Text = "OK"
        cmdOK.DialogResult = Windows.Forms.DialogResult.OK
        cmdOK.BackColor = Color.FromArgb(224, 244, 244)
        cmdOK.ForeColor = Color.FromArgb(32, 32, 32)

        Dim cmdCancel As New Button
        cmdCancel.Text = "Cancel"
        cmdCancel.DialogResult = Windows.Forms.DialogResult.Cancel
        cmdCancel.BackColor = Color.FromArgb(224, 244, 244)
        cmdCancel.ForeColor = Color.FromArgb(32, 32, 32)

        cmdOK.Location = New Point((frmTransl.ClientSize.Width - cmdOK.Width - cmdCancel.Width - 8) \ 2, frmTransl.ClientSize.Height - cmdOK.Height - 8)
        cmdCancel.Location = New Point(cmdOK.Left + cmdOK.Width + 8, frmTransl.ClientSize.Height - cmdCancel.Height - 8)

        frmTransl.Controls.Add(cmbFrom)
        frmTransl.Controls.Add(cmbTo)
        frmTransl.Controls.Add(cmdOK)
        frmTransl.Controls.Add(cmdCancel)

        frmTransl.AcceptButton = cmdOK
        frmTransl.CancelButton = cmdCancel

        cmbFrom.Enabled = False

        If frmTransl.ShowDialog = Windows.Forms.DialogResult.OK Then
            If tTranslate.IsAlive Then

            Else
                tTranslate = New Threading.Thread(AddressOf TranslateUI)
                tTranslate.Start(Lang2LangPair(cmbFrom.Text) & "|" & Lang2LangPair(cmbTo.Text))
            End If
        End If
    End Sub

    Dim tTranslate As Threading.Thread = New Threading.Thread(AddressOf TranslateUI)

    Sub TranslateUI(ByVal langpair As String, Optional ByVal ctr As Control = Nothing)
        Try

            If ctr Is Nothing Then
                For Each c As Control In Me.Controls
                    If Microsoft.VisualBasic.Right(c.Name, 2) = "_t" Then c.Text = GoogleTranslate(c.Text, langpair)
                    TranslateUI(langpair, c)
                Next

                For i As Integer = 0 To mnuMain.Items.Count - 1
                    mnuMain.Items(i).Text = GoogleTranslate(mnuMain.Items(i).Text, langpair)
                Next

                For i As Integer = 0 To Me.FileToolStripMenuItem.DropDownItems.Count - 1
                    FileToolStripMenuItem.DropDownItems(i).Text = GoogleTranslate(FileToolStripMenuItem.DropDownItems(i).Text, langpair)
                Next

                For i As Integer = 0 To Me.ViewToolStripMenuItem.DropDownItems.Count - 1
                    ViewToolStripMenuItem.DropDownItems(i).Text = GoogleTranslate(ViewToolStripMenuItem.DropDownItems(i).Text, langpair)
                Next

                For i As Integer = 0 To Me.ToolsToolStripMenuItem.DropDownItems.Count - 1
                    ToolsToolStripMenuItem.DropDownItems(i).Text = GoogleTranslate(ToolsToolStripMenuItem.DropDownItems(i).Text, langpair)
                Next

                For i As Integer = 0 To Me.RenderToolStripMenuItem.DropDownItems.Count - 1
                    RenderToolStripMenuItem.DropDownItems(i).Text = GoogleTranslate(RenderToolStripMenuItem.DropDownItems(i).Text, langpair)
                Next

                For i As Integer = 0 To Me.HelpToolStripMenuItem.DropDownItems.Count - 1
                    HelpToolStripMenuItem.DropDownItems(i).Text = GoogleTranslate(HelpToolStripMenuItem.DropDownItems(i).Text, langpair)
                Next

            Else
                For Each c As Control In ctr.Controls
                    If Microsoft.VisualBasic.Right(c.Name, 2) = "_t" Then c.Text = GoogleTranslate(c.Text, langpair)
                    TranslateUI(langpair, c)
                Next
            End If

        Catch ex As Exception
            tTranslate.Abort()
        End Try

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        If OSVer > 5 Then

            Dim frmAbout As New frmAeroDialog(1, 480, 320)
            frmAbout.Icon = Me.Icon
            frmAbout.Text = "About"
            frmAbout.ControlBox = True

            Dim Frame As Image = New Bitmap(480, 320, Imaging.PixelFormat.Format32bppArgb)
            Dim G As Graphics = Graphics.FromImage(Frame)
            G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

            G.DrawImage(My.Resources.AboutBox400, 0, 0, 480, 320)

            Dim rec As New Rectangle(220, 75, 200, 100)
            Dim Text As String = "Particle f(x)" & System.Environment.NewLine & _
                           "version " & Application.ProductVersion & System.Environment.NewLine & _
                           "© 2010 Venix freeware." & System.Environment.NewLine & _
                           "All rights reserved."

            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(64, 32, 23, 32)), New Rectangle(rec.X - 1, rec.Y - 1, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(64, 32, 23, 32)), New Rectangle(rec.X, rec.Y - 1, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(64, 32, 23, 32)), New Rectangle(rec.X + 1, rec.Y - 1, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(96, 32, 23, 32)), New Rectangle(rec.X + 1, rec.Y, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(128, 32, 23, 32)), New Rectangle(rec.X + 1, rec.Y + 1, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(96, 32, 23, 32)), New Rectangle(rec.X, rec.Y + 1, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(64, 32, 23, 32)), New Rectangle(rec.X - 1, rec.Y + 1, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(64, 32, 23, 32)), New Rectangle(rec.X - 1, rec.Y, rec.Width, rec.Height), StringFormatLeftCenter)

            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X - 2, rec.Y - 2, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X, rec.Y - 2, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X + 2, rec.Y - 2, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X + 2, rec.Y, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X + 2, rec.Y + 2, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X, rec.Y + 2, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X - 2, rec.Y + 2, rec.Width, rec.Height), StringFormatLeftCenter)
            G.DrawString(Text, New Font("Arial", 12), New SolidBrush(Color.FromArgb(32, 32, 23, 32)), New Rectangle(rec.X - 2, rec.Y, rec.Width, rec.Height), StringFormatLeftCenter)

            G.DrawString(Text, New Font("Arial", 12), Brushes.White, rec, StringFormatLeftCenter)

            frmAbout.BackgroundImage = Frame

            frmAbout.cmdOK.Location = New Point((frmAbout.ClientSize.Width - frmAbout.cmdOK.Width) \ 2, frmAbout.ClientSize.Height - frmAbout.cmdOK.Height - 8)

            frmAbout.ShowDialog()
            frmAbout.Dispose()

        Else

            Dim frmAbout As New Form
            frmAbout.ClientSize = New Size(480, 320)
            frmAbout.Icon = Me.Icon
            frmAbout.Text = "About"
            frmAbout.ShowIcon = False
            frmAbout.ShowInTaskbar = False
            frmAbout.StartPosition = FormStartPosition.CenterParent
            frmAbout.MinimizeBox = False
            frmAbout.MaximizeBox = False
            frmAbout.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            frmAbout.BackColor = Color.FromArgb(32, 32, 32)
            frmAbout.ForeColor = Color.White
            frmAbout.BackgroundImage = My.Resources.AboutBox400

            Dim lblAbout As New Label
            lblAbout.Size = New Size(200, 100)
            lblAbout.Location = New Point(220, 75)
            lblAbout.TextAlign = ContentAlignment.MiddleLeft
            lblAbout.Font = New Font("Arial", 12)

            lblAbout.Text = "Particle f(x)" & System.Environment.NewLine & _
                           "version " & Application.ProductVersion & System.Environment.NewLine & _
                           "© 2010 Venix freeware." & System.Environment.NewLine & _
                           "All rights reserved."

            Dim cmdOK As New Button
            cmdOK.Text = "OK"
            cmdOK.DialogResult = Windows.Forms.DialogResult.OK
            cmdOK.BackColor = Color.FromArgb(224, 244, 244)
            cmdOK.ForeColor = Color.FromArgb(32, 32, 32)
            cmdOK.Location = New Point((frmAbout.ClientSize.Width - cmdOK.Width) \ 2, frmAbout.ClientSize.Height - cmdOK.Height - 8)

            frmAbout.Controls.Add(lblAbout)
            frmAbout.Controls.Add(cmdOK)

            frmAbout.AcceptButton = cmdOK
            frmAbout.CancelButton = cmdOK

            frmAbout.ShowDialog()
            frmAbout.Dispose()

        End If
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        tTranslate.Abort()
    End Sub

End Class

'0:   static

'1:   expiry point

'2:   point gen
'3:   rain gen
'4:   spray gen
'10:  random gen
'32:  bitmap gen

'100: Wind
'101: Expanter
'102: Black hole
'103: Fan
'104: Whirlpool
'105: Antigravity

'150: Line
'151: Curve
'152: Closed curve
'153: Rectangle
'154: Ellipse
'155: Pie
'156: Polygon
'157: Free draw
'158: Eraser
'159: Templates

'255: camera


'to update if you add new object:
'                                  counter -main
'                                  Draw function -engien
'                                  create event -objectList
'                                  ClearListObject
'                                  ChangeVals
'                                  lstObjects_SelectedIndexChanged
'                                  DeleteListObject
'                                  RefreshListObject
'                                  RefreshFrame
'                                  RefreshNavigator
'                                  SelectObject
