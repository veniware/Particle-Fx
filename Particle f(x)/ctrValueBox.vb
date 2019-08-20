Public Class ctrValueBox

    Public Event ValueChanged()

    Public isLinkable As Boolean = False

    Public WaveControl As ctrWaveform = Nothing

    Public Max As Long = 65535
    Public Min As Long = -65536
    Public Value As Double = 0
    Public DecimalPlaces As Byte = 0
    Public Change As Single = 1

    Dim BlackPen As Pen = New Pen(Color.FromArgb(96, 0, 0, 0))

    Dim sel, unsel As Image
    Public Sub New()
        InitializeComponent()

        Dim G As Graphics

        sel = New Bitmap(Me.Width, Me.Height, Imaging.PixelFormat.Format24bppRgb)
        G = Graphics.FromImage(sel)
        G.DrawImage(My.Resources.WaveformBG, 0, 0, sel.Width, sel.Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(24, 255, 255, 255)), 0, 0, sel.Width, sel.Height)
        G.DrawLine(BlackPen, sel.Width - 21, 1, sel.Width - 21, sel.Height - 2)
        G.DrawLine(New Pen(Color.FromArgb(128, 128, 128, 128)), sel.Width - 20, 2, sel.Width - 20, sel.Height - 3)

        unsel = New Bitmap(Me.Width, Me.Height, Imaging.PixelFormat.Format24bppRgb)
        G = Graphics.FromImage(unsel)
        G.DrawImage(My.Resources.WaveformBG, 0, 0, sel.Width, sel.Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(24, 0, 0, 0)), 0, 0, unsel.Width, unsel.Height)
        G.DrawLine(BlackPen, sel.Width - 21, 1, sel.Width - 21, sel.Height - 2)
        G.DrawLine(New Pen(Color.FromArgb(128, 128, 128, 128)), sel.Width - 20, 2, sel.Width - 20, sel.Height - 3)

        G.Dispose()

        Me.BackgroundImage = unsel
    End Sub

    Sub Type()
        If ValueDialog("Edit value", Value, Min, Max, DecimalPlaces) = DialogResult.OK Then
            value2 = Value
            Unlink()
            RaiseEvent ValueChanged()
        End If
    End Sub

    Sub Link()
        Dim frmList As New frmWaveformsList
        frmList.max = Max
        frmList.min = Min
        If frmList.ShowDialog = DialogResult.OK Then
            WaveControl = Engine.Waveforms(frmList.lstWaveforms.SelectedIndex)
            Me.Refresh()
            UnlinkToolStripMenuItem.Enabled = True
            RaiseEvent ValueChanged()
        End If
    End Sub

    Sub Unlink()
        WaveControl = Nothing
        Me.Refresh()
        UnlinkToolStripMenuItem.Enabled = False
        RaiseEvent ValueChanged()
    End Sub

    Public Sub SetValue(ByVal v As Double)
        Value = v
        value2 = v
        Me.Refresh()
    End Sub

    Private Sub ctrValueBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.BackgroundImage = sel
    End Sub
    Private Sub ctrValueBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.BackgroundImage = unsel
    End Sub

    Private Sub ctrValueBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If WaveControl Is Nothing Then

            Dim Text As String = Math.Round(Value, DecimalPlaces)

            If Me.Focused Then
                e.Graphics.DrawString(Text, Me.Font, Brushes.White, New Rectangle(2, 0, Me.Width - 20, Me.Height), frmMain.StringFormatLeftCenter)
            Else
                e.Graphics.DrawString(Text, Me.Font, Brushes.Gainsboro, New Rectangle(2, 0, Me.Width - 20, Me.Height), frmMain.StringFormatLeftCenter)
            End If

            Dim off As Byte = (Math.Abs(Value) Mod 16) \ 4

            For i As Integer = 0 To 16 Step 4
                Dim a As Short = Math.Abs(8 - Math.Abs((i - off + 4) - 8)) * 23
                e.Graphics.DrawLine(BlackPen, Me.Width - 16, i - off, Me.Width - 6, i - off)
                e.Graphics.DrawLine(New Pen(Color.FromArgb(a, 128, 128, 128)), Me.Width - 16, i - off + 1, Me.Width - 6, i - off + 1)
            Next

        Else

            If Me.Focused Then
                e.Graphics.DrawString(WaveControl.Title, Me.Font, Brushes.White, New Rectangle(2, 0, Me.Width - 20, Me.Height), frmMain.StringFormatLeftCenter)
            Else
                e.Graphics.DrawString(WaveControl.Title, Me.Font, Brushes.Gainsboro, New Rectangle(2, 0, Me.Width - 20, Me.Height), frmMain.StringFormatLeftCenter)
            End If

            e.Graphics.DrawImage(My.Resources.icoLink, Me.Width - 16, 2, 12, 12)

        End If
    End Sub

    Dim cY As Integer
    Private Sub ctrValueBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        cY = e.Y
    End Sub
    Private Sub ctrValueBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If WaveControl IsNot Nothing Then Exit Sub

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim Y As Double = Value

            If e.Y > cY + 3 Then

                If e.Y > cY + 5 Then
                    Y -= Change * 5
                Else
                    Y -= Change
                End If
                cY = e.Y
                If Y < Min Then Y = Min

            ElseIf e.Y < cY - 3 Then

                If e.Y < cY - 5 Then
                    Y += Change * 5
                Else
                    Y += Change
                End If
                cY = e.Y
                If Y > Max Then Y = Max

            End If

            If Not Value = Y Then
                Value = Y
                Me.Refresh()
            End If

            If System.Windows.Forms.Cursor.Position.Y = 0 Then
                System.Windows.Forms.Cursor.Position = New Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 2)
            ElseIf System.Windows.Forms.Cursor.Position.Y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 1 Then
                System.Windows.Forms.Cursor.Position = New Point(System.Windows.Forms.Cursor.Position.X, 1)
            End If

        End If
    End Sub

    Private Sub ctrValueBox_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If WaveControl IsNot Nothing Then Exit Sub

        Dim Y As Double = Value

        If e.Delta < 0 Then
            Y -= Change
            cY = e.Y
            If Y < Min Then Y = Min
        ElseIf e.Delta > 0 Then
            Y += Change
            cY = e.Y
            If Y > Max Then Y = Max
        End If

        If Not Value = Y Then
            Value = Y
            Me.Refresh()
        End If
    End Sub

    Private Sub ctrValueBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then 'enter
            If WaveControl Is Nothing Then
                Type()
            Else
                If WaveControl IsNot Nothing Then WaveControl.Edit()
            End If

        ElseIf Asc(e.KeyChar) = 8 Then 'backspace
            If WaveControl IsNot Nothing Then Exit Sub

            If Value.ToString.Length > 0 Then Value = Math.Round(Val(Microsoft.VisualBasic.Left(Value, Value.ToString.Length - 1)), DecimalPlaces)
            If Value < Min Then Value = Min
            If Value > Max Then Value = Max
            Me.Refresh()

        ElseIf Asc(e.KeyChar) = 45 Then '-
            If WaveControl IsNot Nothing Then Exit Sub

            Value *= -1
            If Value < Min Then Value = Min
            If Value > Max Then Value = Max
            Me.Refresh()

        ElseIf Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58 Then
            If WaveControl IsNot Nothing Then Exit Sub

            Value = Math.Round(Val(Value & e.KeyChar), DecimalPlaces)
            If Value < Min Then Value = Min
            If Value > Max Then Value = Max
            Me.Refresh()
        End If
    End Sub

    Private Sub ctrValueBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        If WaveControl Is Nothing Then
            Type()
        Else
            If WaveControl IsNot Nothing Then WaveControl.Edit()
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Type()
    End Sub

    Private Sub EditWaveformToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditWaveformToolStripMenuItem.Click
        If WaveControl IsNot Nothing Then WaveControl.Edit()
    End Sub

    Private Sub LinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkToolStripMenuItem.Click
        Link()
    End Sub
    Private Sub UnlinkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnlinkToolStripMenuItem.Click
        Unlink()
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If isLinkable Then
            LinkToolStripMenuItem.Enabled = True
            UnlinkToolStripMenuItem.Enabled = True
        Else
            LinkToolStripMenuItem.Enabled = False
            UnlinkToolStripMenuItem.Enabled = False
        End If

        If WaveControl Is Nothing Then
            EditWaveformToolStripMenuItem.Enabled = False
        Else
            EditWaveformToolStripMenuItem.Enabled = True
        End If
    End Sub

    Dim value2 As Double = 0
    Private Sub tmrChangeVals_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChangeVals.Tick
        If value2 <> Value Then
            value2 = Value
            RaiseEvent ValueChanged()
        End If
    End Sub

End Class
