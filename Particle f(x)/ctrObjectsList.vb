Public Class ctrObjectsList

    Sub ResetScroll()
        cmdScroll.Top = 0

        If pnlMainList.Height > Me.Height Then
            pnlMainList.Top = (-pnlMainList.Height + Me.Height) * (cmdScroll.Top / (pnlScroll.Height - cmdScroll.Height))
        Else
            pnlMainList.Top = 0
        End If
    End Sub

    Public Sub ResetMainList()
        ResetScroll()
        Dim TotalHeight As Integer = 0
        For i As Integer = 0 To pnlMainList.Controls.Count - 1
            If pnlMainList.Controls(i).Visible Then TotalHeight += pnlMainList.Controls(i).Height
        Next
        pnlMainList.Height = TotalHeight
        ScrollList()
    End Sub

    Public Sub AddItem(ByVal Title As String, ByVal Color As Color, Optional ByVal Definition As String = Nothing)
        Dim newItem As New ObjectItem
        newItem.Title = Title
        newItem.Color = Color
        newItem.Definition = Definition
        'pnlMainList.Height += newItem.ctrToolsItem.Height
        pnlMainList.Controls.Add(newItem.ctrToolsItem)
        newItem.ctrToolsItem.BringToFront()
        ScrollList()
    End Sub

    Public Sub AddControl(ByVal c As Control)
        c.Dock = DockStyle.Top
        pnlMainList.Controls.Add(c)
        c.BringToFront()
        ScrollList()
    End Sub

    Public Sub AddLabel(ByVal Label As String)
        Dim lblLabel As New Label
        lblLabel.Text = Label
        lblLabel.Font = New System.Drawing.Font("Segoe", 9, System.Drawing.FontStyle.Regular)
        lblLabel.BackColor = Color.DimGray
        lblLabel.Height = 16
        'pnlMainList.Height += 16
        lblLabel.Dock = DockStyle.Top
        pnlMainList.Controls.Add(lblLabel)
        lblLabel.BringToFront()
        ScrollList()
    End Sub

    Public Sub AddSeparator()
        Dim pnlSeparator As New Panel
        pnlSeparator.Height = 8
        'pnlMainList.Height += pnlSeparator.Height
        pnlSeparator.BackColor = Color.FromArgb(87, 87, 87)
        pnlSeparator.Dock = DockStyle.Top
        pnlMainList.Controls.Add(pnlSeparator)
        pnlSeparator.BringToFront()
        ScrollList()
    End Sub

    Public Sub ClearItems()
        ResetScroll()
        Do Until pnlMainList.Controls.Count = 0
            pnlMainList.Controls(0).Dispose()
        Loop
        pnlMainList.Height = 0
        ScrollList()
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

    Dim MouseY As Integer
    Private Sub cmdScroll_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdScroll.MouseDown
        Me.Focus()
        MouseY = System.Windows.Forms.Cursor.Position.Y - cmdScroll.Top
    End Sub
    Private Sub cmdScroll_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdScroll.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim Y As Integer = System.Windows.Forms.Cursor.Position.Y - MouseY
            If Y < 0 Then Y = 0
            If Y > pnlScroll.Height - cmdScroll.Height Then Y = pnlScroll.Height - cmdScroll.Height
            cmdScroll.Top = Y

            If pnlMainList.Height > Me.Height Then
                pnlMainList.Top = (-pnlMainList.Height + Me.Height) * (cmdScroll.Top / (pnlScroll.Height - cmdScroll.Height))
            Else
                pnlMainList.Top = 0
            End If
        End If
    End Sub

    Private Sub ctrObjectsList_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        ScrollList(-e.Delta \ 3)
    End Sub
    Private Sub cmdScrollUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScrollUp.Click
        ScrollList(-pnlMainScroll.Height \ 10)
    End Sub
    Private Sub cmdScrollDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScrollDown.Click
        ScrollList(+pnlMainScroll.Height \ 10)
    End Sub

    Public Sub ScrollList(Optional ByVal Value As Short = 0)
        If pnlScroll.Height - cmdScroll.Height <= 0 Then Exit Sub

        Dim y As Integer = cmdScroll.Top + Value
        If y < 0 Then y = 0
        If y > pnlScroll.Height - cmdScroll.Height Then y = pnlScroll.Height - cmdScroll.Height
        cmdScroll.Top = y

        If pnlMainList.Height > Me.Height Then
            pnlMainList.Top = (-pnlMainList.Height + Me.Height) * (cmdScroll.Top / (pnlScroll.Height - cmdScroll.Height))

            cmdScrollUp.Show()
            cmdScrollDown.Show()
            cmdScroll.Show()
        Else
            'pnlMainList.Top = 0

            cmdScrollUp.Hide()
            cmdScrollDown.Hide()
            cmdScroll.Hide()
        End If
    End Sub

    Private Sub ctrObjectsList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ScrollList()
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

    Private Sub pnlScroll_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlScroll.MouseDown
        Me.Select()
    End Sub
End Class

Public Class ObjectItem

    Public Title As String
    Public Definition As String
    Public Color As Color
    Public WithEvents ctrToolsItem As New Panel

    Public Sub New()
        ctrToolsItem.Height = 24
        ctrToolsItem.BackColor = Color.DimGray
        ctrToolsItem.BackgroundImage = My.Resources.BlackBar
        ctrToolsItem.BackgroundImageLayout = ImageLayout.Stretch
        ctrToolsItem.Dock = DockStyle.Top
    End Sub

    Private Sub ctrToolsItem_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ctrToolsItem.Paint
        If Light Then e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(32, Color)), 1, 1, ctrToolsItem.Width - 2, ctrToolsItem.Height - 2)
        e.Graphics.DrawString(Title, New Font("Segoe", 9, FontStyle.Regular), Brushes.LightGray, 1, 4)
        e.Graphics.DrawString(Definition, New Font("Segoe", 9, FontStyle.Italic), Brushes.DarkGray, ctrToolsItem.Width - 4, 4, frmMain.StringFormatRight)
    End Sub

    Dim Light As Boolean = False
    Private Sub ctrToolsItem_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctrToolsItem.MouseEnter
        Light = True
        ctrToolsItem.Refresh()
    End Sub
    Private Sub ctrToolsItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctrToolsItem.MouseLeave
        Light = False
        ctrToolsItem.Refresh()
    End Sub

    Private Sub ctrToolsItem_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ctrToolsItem.MouseDown
        ctrToolsItem.Select()
        If e.Button = MouseButtons.Left Then
            frmMain.frmGhost.Text = Title
            frmMain.frmGhost.Show()
            frmMain.Select()
            frmMain.frmGhost.Size = New Size(150, 24)
        End If
    End Sub

    Private Sub ctrToolsItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ctrToolsItem.MouseMove
        If e.Button = MouseButtons.Left Then
            If e.X - frmMain.lstTools.Width < 0 Then
                Dim o As Decimal = 0.666 + (e.X - frmMain.lstTools.Width) / 64
                If o < 0.08 Then o = 0.08
                frmMain.frmGhost.Opacity = o
            Else
                frmMain.frmGhost.Opacity = 0.666
            End If

            frmMain.frmGhost.Location = New Point(System.Windows.Forms.Cursor.Position.X + 16, System.Windows.Forms.Cursor.Position.Y + 16)

        End If
    End Sub

    Private Sub ctrToolsItem_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ctrToolsItem.MouseUp
        frmMain.frmGhost.Hide()

        If e.Button = MouseButtons.Left Then
            If Not e.X - frmMain.lstTools.Width < 0 Then

                Dim Gr As Graphics
                If frmMain.Frame Is Nothing Then
                    frmMain.Frame = New Bitmap(frmMain.pnlMain.Width, frmMain.pnlMain.Height, Imaging.PixelFormat.Format24bppRgb)
                    Gr = Graphics.FromImage(frmMain.Frame)
                    Gr.FillRectangle(New SolidBrush(frmMain.pnlMain.BackColor), 0, 0, frmMain.Frame.Width, frmMain.Frame.Height)
                End If

                Gr = Graphics.FromImage(frmMain.Frame)

                Select Case Me.Color

                    Case Color.Blue 'Generators
                        Select Case Title
                            Case "Point generator"
                                Dim newPointGen As New Engine.PointGen
                                newPointGen.name = "point " & frmMain.PointsCount
                                newPointGen.ID = Now.Ticks
                                newPointGen.x = e.X - frmMain.pnlSide.Width - frmMain.OffSet.X
                                newPointGen.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                                newPointGen.Noice = 5
                                newPointGen.R = 9
                                newPointGen.ppf = 10
                                newPointGen.startGen = 0
                                newPointGen.stopGen = 99
                                newPointGen.Life = 100
                                newPointGen.Color = Color.FromArgb(0, 0, 255)
                                Engine.Points.Add(newPointGen)

                                Dim newItem As New Engine.ObjectItem
                                newItem.Name = "point " & frmMain.PointsCount
                                newItem.Type = 2
                                newItem.ID = newPointGen.ID

                                lstObjectsBG.Add(newItem)
                                frmMain.lstObjects.Items.Add("point " & frmMain.PointsCount)

                                DrawPoint(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newPointGen.x + frmMain.OffSet.X, newPointGen.y + frmMain.OffSet.Y, newPointGen.Noice)
                                DrawPoint(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newPointGen.x, newPointGen.y, newPointGen.Noice)

                                frmMain.PointsCount += 1

                            Case "Rain generator"
                                Dim newRainGen As New Engine.RainGen
                                newRainGen.name = "rain " & frmMain.RainsCount
                                newRainGen.ID = Now.Ticks
                                newRainGen.x = e.X - frmMain.pnlSide.Width - frmMain.OffSet.X
                                newRainGen.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                                newRainGen.Widht = 300
                                newRainGen.f0 = 0
                                newRainGen.Noice = 5
                                newRainGen.R = 9
                                newRainGen.ppf = 10
                                newRainGen.startGen = 0
                                newRainGen.stopGen = 99
                                newRainGen.Life = 100
                                newRainGen.Color = Color.FromArgb(0, 0, 255)
                                Engine.Rains.Add(newRainGen)

                                Dim newItem As New Engine.ObjectItem
                                newItem.Name = "rain " & frmMain.RainsCount
                                newItem.Type = 3
                                newItem.ID = newRainGen.ID

                                lstObjectsBG.Add(newItem)
                                frmMain.lstObjects.Items.Add("rain " & frmMain.RainsCount)

                                DrawRain(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newRainGen.x + frmMain.OffSet.X, newRainGen.y + frmMain.OffSet.Y, newRainGen.Widht)
                                DrawRain(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newRainGen.x, newRainGen.y, newRainGen.Widht)

                                frmMain.RainsCount += 1

                            Case "Spray generator"
                                Dim newSprayGen As New Engine.SprayGen
                                newSprayGen.name = "spray " & frmMain.SpraysCount
                                newSprayGen.ID = Now.Ticks
                                newSprayGen.x = e.X - frmMain.pnlSide.Width - frmMain.OffSet.X
                                newSprayGen.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                                newSprayGen.Slope = 270
                                newSprayGen.f0 = 10
                                newSprayGen.Noice = 45
                                newSprayGen.R = 9
                                newSprayGen.ppf = 10
                                newSprayGen.startGen = 0
                                newSprayGen.stopGen = 99
                                newSprayGen.Life = 100
                                newSprayGen.Color = Color.FromArgb(0, 0, 255)
                                Engine.Sprays.Add(newSprayGen)

                                Dim newItem As New Engine.ObjectItem
                                newItem.Name = "spray " & frmMain.SpraysCount
                                newItem.Type = 4
                                newItem.ID = newSprayGen.ID

                                lstObjectsBG.Add(newItem)
                                frmMain.lstObjects.Items.Add("spray " & frmMain.SpraysCount)

                                DrawSpary(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newSprayGen.x + frmMain.OffSet.X, newSprayGen.y + frmMain.OffSet.Y, newSprayGen.Slope, newSprayGen.Noice)
                                DrawSpary(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newSprayGen.x, newSprayGen.y, newSprayGen.Slope, newSprayGen.Noice)

                                frmMain.SpraysCount += 1

                            Case "Random generator"
                                Dim newRandom As New Engine.RandomGen
                                newRandom.name = "random " & frmMain.RandomsCount
                                newRandom.ID = Now.Ticks
                                newRandom.x = e.X - frmMain.pnlSide.Width - frmMain.OffSet.X
                                newRandom.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                                newRandom.Widht = 400
                                newRandom.Height = 400
                                newRandom.R = 9
                                newRandom.startGen = 0
                                newRandom.stopGen = 10
                                newRandom.ppf = 10
                                newRandom.Life = 100
                                newRandom.Color = Color.FromArgb(0, 0, 255)
                                Engine.Randoms.Add(newRandom)

                                Dim newItem As New Engine.ObjectItem
                                newItem.Name = newRandom.name
                                newItem.Type = 10
                                newItem.ID = newRandom.ID

                                lstObjectsBG.Add(newItem)
                                frmMain.lstObjects.Items.Add(newRandom.name)

                                DrawBitmap(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newRandom.x + frmMain.OffSet.X, newRandom.y + frmMain.OffSet.Y, newRandom.Widht, newRandom.Height)
                                DrawBitmap(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newRandom.x, newRandom.y, newRandom.Widht, newRandom.Height)

                                frmMain.BitmapsCount += 1

                            Case "Bitmap generator"
                                Dim newBitmap As New Engine.BitmapGen
                                newBitmap.name = "bitmap " & frmMain.BitmapsCount
                                newBitmap.ID = Now.Ticks
                                newBitmap.x = e.X - frmMain.pnlSide.Width - frmMain.OffSet.X
                                newBitmap.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                                newBitmap.Widht = 640
                                newBitmap.Height = 480
                                newBitmap.R = 9
                                newBitmap.startGen = 0
                                newBitmap.Life = 100
                                Engine.Bitmaps.Add(newBitmap)

                                Dim newItem As New Engine.ObjectItem
                                newItem.Name = "bitmap " & frmMain.BitmapsCount
                                newItem.Type = 32
                                newItem.ID = newBitmap.ID

                                lstObjectsBG.Add(newItem)
                                frmMain.lstObjects.Items.Add("bitmap " & frmMain.BitmapsCount)

                                DrawBitmap(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newBitmap.x + frmMain.OffSet.X, newBitmap.y + frmMain.OffSet.Y, newBitmap.Widht, newBitmap.Height)
                                DrawBitmap(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newBitmap.x, newBitmap.y, newBitmap.Widht, newBitmap.Height)

                                frmMain.BitmapsCount += 1
                        End Select

                    Case Color.Red 'Expiry
                        Dim newExpiry As New Engine.Expiry
                        newExpiry.name = "expiry " & frmMain.ExpirysCount
                        newExpiry.ID = Now.Ticks
                        newExpiry.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                        Engine.Expirys.Add(newExpiry)

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = "expiry " & frmMain.ExpirysCount
                        newItem.Type = 1
                        newItem.ID = newExpiry.ID
                        lstObjectsBG.Add(newItem)

                        frmMain.lstObjects.Items.Add("expiry " & frmMain.ExpirysCount)

                        DrawExpiry(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newExpiry.y + frmMain.OffSet.Y, frmMain.Frame.Width)
                        DrawExpiry(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, frmMain.OffSet.X, frmMain.OffSet.Y), newExpiry.y, frmMain.Frame.Width)

                        frmMain.ExpirysCount += 1


                    Case Color.Cyan 'Space warps
                        Select Case Title
                            Case "Wind"
                                Dim newWind As New Engine.Wind
                                newWind.name = "wind " & frmMain.WindsCount
                                newWind.ID = Now.Ticks
                                newWind.x = e.X - frmMain.pnlSide.Width - frmMain.OffSet.X
                                newWind.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                                newWind.Widht = 200
                                newWind.Height = 200
                                newWind.F = 3
                                Engine.Winds.Add(newWind)

                                Dim newItem As New Engine.ObjectItem
                                newItem.Name = newWind.name
                                newItem.ID = newWind.ID
                                newItem.Type = 100
                                lstObjectsBG.Add(newItem)

                                frmMain.lstObjects.Items.Add(newWind.name)

                                DrawWind(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newWind.x + frmMain.OffSet.X, newWind.y + frmMain.OffSet.Y, newWind.Widht, newWind.Height)
                                DrawWind(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newWind.x, newWind.y, newWind.Widht, newWind.Height)

                                frmMain.WindsCount += 1

                            Case "Expant"
                                Dim newExpant As New Engine.Expant
                                newExpant.name = "expant " & frmMain.ExpantCount
                                newExpant.ID = Now.Ticks
                                newExpant.x = e.X - frmMain.pnlSide.Width - frmMain.OffSet.X
                                newExpant.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                                newExpant.R = 100
                                newExpant.F = 3
                                Engine.Expants.Add(newExpant)

                                Dim newItem As New Engine.ObjectItem
                                newItem.Name = newExpant.name
                                newItem.ID = newExpant.ID
                                newItem.Type = 101
                                lstObjectsBG.Add(newItem)

                                frmMain.lstObjects.Items.Add(newExpant.name)

                                DrawExpant(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newExpant.x + frmMain.OffSet.X, newExpant.y + frmMain.OffSet.Y, newExpant.R)
                                DrawExpant(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newExpant.x, newExpant.y, newExpant.R)

                                frmMain.ExpantCount += 1

                            Case "Black hole"
                                Dim newBlackHole As New Engine.BlackHole
                                newBlackHole.name = "black hole " & frmMain.BlackHoleCount
                                newBlackHole.ID = Now.Ticks
                                newBlackHole.x = e.X - frmMain.pnlSide.Width - frmMain.OffSet.X
                                newBlackHole.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                                newBlackHole.R = 100
                                newBlackHole.F = 3
                                Engine.BlackHoles.Add(newBlackHole)

                                Dim newItem As New Engine.ObjectItem
                                newItem.Name = newBlackHole.name
                                newItem.ID = newBlackHole.ID
                                newItem.Type = 102
                                lstObjectsBG.Add(newItem)

                                frmMain.lstObjects.Items.Add(newBlackHole.name)

                                DrawBlackHole(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newBlackHole.x + frmMain.OffSet.X, newBlackHole.y + frmMain.OffSet.Y, newBlackHole.R)
                                DrawBlackHole(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newBlackHole.x, newBlackHole.y, newBlackHole.R)

                                frmMain.BlackHoleCount += 1

                            Case "Fan"
                                Dim newFan As New Engine.Fan
                                newFan.name = "fan " & frmMain.FanCount
                                newFan.ID = Now.Ticks
                                newFan.x = e.X - frmMain.pnlSide.Width - frmMain.OffSet.X
                                newFan.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                                newFan.R = 100
                                newFan.F = 3
                                Engine.fans.Add(newFan)

                                Dim newItem As New Engine.ObjectItem
                                newItem.Name = newFan.name
                                newItem.ID = newFan.ID
                                newItem.Type = 103
                                lstObjectsBG.Add(newItem)

                                frmMain.lstObjects.Items.Add(newFan.name)

                                DrawFan(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newFan.x + frmMain.OffSet.X, newFan.y + frmMain.OffSet.Y, newFan.R)
                                DrawFan(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newFan.x, newFan.y, newFan.R)

                                frmMain.FanCount += 1

                            Case "Whirlpool"
                                Dim newWhirlpool As New Engine.Whirlpool
                                newWhirlpool.name = "whirlpool " & frmMain.WhirlpoolCount
                                newWhirlpool.ID = Now.Ticks
                                newWhirlpool.x = e.X - frmMain.pnlSide.Width - frmMain.OffSet.X
                                newWhirlpool.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                                newWhirlpool.R = 100
                                newWhirlpool.F = 3
                                Engine.Whirlpools.Add(newWhirlpool)

                                Dim newItem As New Engine.ObjectItem
                                newItem.Name = newWhirlpool.name
                                newItem.ID = newWhirlpool.ID
                                newItem.Type = 104
                                lstObjectsBG.Add(newItem)

                                frmMain.lstObjects.Items.Add(newWhirlpool.name)

                                DrawWhirlpool(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newWhirlpool.x + frmMain.OffSet.X, newWhirlpool.y + frmMain.OffSet.Y, newWhirlpool.R)
                                DrawWhirlpool(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newWhirlpool.x, newWhirlpool.y, newWhirlpool.R)

                                frmMain.WhirlpoolCount += 1

                        End Select


                    Case Color.Green 'Static

                    Case Color.Yellow 'Cams
                        Dim newCam As New Engine.Camera
                        newCam.name = "camera " & frmMain.CamerasCount
                        newCam.ID = Now.Ticks
                        newCam.x = e.X - frmMain.pnlSide.Width - frmMain.OffSet.X
                        newCam.y = e.Y + ctrToolsItem.Top + frmMain.lstTools.pnlMainList.Top - frmMain.OffSet.Y
                        newCam.Widht = 640
                        newCam.Height = 480
                        If Me.Definition IsNot Nothing Then
                            Dim xpos As Integer = InStr(Me.Definition.ToLower, "x")
                            If xpos > 0 Then
                                newCam.Widht = Val(Microsoft.VisualBasic.Left(Me.Definition, xpos))
                                newCam.Height = Val(Microsoft.VisualBasic.Right(Me.Definition, Me.Definition.Length - xpos))
                            End If
                        End If
                        Engine.Cameras.Add(newCam)

                        Dim newItem As New Engine.ObjectItem
                        newItem.Name = "camera " & frmMain.CamerasCount
                        newItem.Type = 255
                        newItem.ID = newCam.ID

                        lstObjectsBG.Add(newItem)
                        frmMain.lstObjects.Items.Add("camera " & frmMain.CamerasCount)

                        DrawCam(frmMain.pnlMain.CreateGraphics, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newCam.x + frmMain.OffSet.X, newCam.y + frmMain.OffSet.Y, newCam.Widht, newCam.Height)
                        DrawCam(Gr, New Drawing2D.Matrix(frmMain.Zoom, 0, 0, frmMain.Zoom, 0, 0), newCam.x, newCam.y, newCam.Widht, newCam.Height)

                        frmMain.CamerasCount += 1
                End Select

                Gr.Dispose()

            End If
        End If
    End Sub
End Class