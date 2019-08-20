Public Class ctrWaveform
    Public ID As Long
    Public Title As String = "Waveform"
    Public Color As Color = Drawing.Color.Black

    Public Waveform As New List(Of Double)

    Public max As Long
    Public min As Long
    Public average As Long

    Public Thump As Image

    Public Sub New(Optional ByVal WF As List(Of Double) = Nothing)
        InitializeComponent()

        Dim BGround As New Bitmap(Me.Width, Me.Height, Imaging.PixelFormat.Format24bppRgb)
        Dim G As Graphics = Graphics.FromImage(BGround)
        G.DrawImage(My.Resources.WaveformBG, 0, 0, Me.Width, Me.Height)
        Me.BackgroundImage = BGround

        If WF IsNot Nothing Then
            For i As Integer = 0 To WF.Count - 1
                Waveform.Add(WF(i))
            Next
            RefreshThump()
            Me.Refresh()
        End If
    End Sub

    Public Sub RefreshThump()
        If Waveform.Count = 0 Then Exit Sub

        Thump = New Bitmap(Me.Width - 4, Me.Height - 20, Imaging.PixelFormat.Format32bppArgb)
        Dim G As Graphics = Graphics.FromImage(Thump)

        G.FillRectangle(New SolidBrush(Color.FromArgb(128, 255, 255, 255)), 0, Thump.Height \ 2, Thump.Width, 1)

        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        Dim Skip As Short
        If Waveform.Count < Thump.Width Then
            Skip = 1
        Else
            Skip = Waveform.Count \ Thump.Width
        End If

        Dim CONVE As Double
        Dim M As Long
        If max = 0 And min = 0 Then
            M = 1
            CONVE = 1
        Else
            If Math.Abs(max) > Math.Abs(min) Then
                M = Math.Abs(max)
            Else
                M = Math.Abs(min)
            End If
            CONVE = Thump.Height / M / 2
        End If

        Dim Points(Waveform.Count / Skip) As Point
        For t As Integer = 0 To Waveform.Count - 1 Step Skip
            Points(t / Skip) = New Point(t * Thump.Width \ Waveform.Count, CType(Waveform(t) * CONVE, Long) + Thump.Height \ 2)
        Next
        If Points(Points.Length - 1) = Nothing Then Points(Points.Length - 1) = Points(Points.Length - 2)

        G.DrawLines(New Pen(Brushes.White, 1.5), Points)

        Thump.RotateFlip(RotateFlipType.RotateNoneFlipY)
    End Sub


    Public Sub Edit()
        Dim frmEdit As New frmWaveformEditor(Waveform)
        frmEdit.Icon = frmMain.Icon
        frmEdit.Text = Title & " - Waveform editor"

        frmEdit.ShowDialog()

        Waveform = frmEdit.Waveform
        max = frmEdit.max
        min = frmEdit.min
        average = frmEdit.average

        RefreshThump()
        Me.Refresh()
    End Sub

    Dim MP, PP As New Point
    Private Sub ctrWaveform_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.BringToFront()

        MP = Cursor.Position
        PP = Me.Location
    End Sub
    Private Sub ctrWaveform_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim P As Point = New Point(PP.X + (System.Windows.Forms.Cursor.Position.X - MP.X), PP.Y + (System.Windows.Forms.Cursor.Position.Y - MP.Y))
            If P.X < 0 Then P.X = 0
            If P.Y < 0 Then P.Y = 0
            Me.Location = P
        End If
    End Sub

    Private Sub ctrWaveform_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If Me.Focused Then
            Dim p As Pen = New Pen(Color.FromArgb(128, 255, 255, 255), 1)
            p.DashStyle = Drawing2D.DashStyle.Dash
            e.Graphics.DrawRectangle(p, 1, 1, Me.Width - 3, Me.Height - 3)
        End If
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(64, Color)), 0, 0, Me.Width, 14)
        e.Graphics.DrawString(Title, Me.Font, New SolidBrush(Me.ForeColor), New Rectangle(0, 1, Me.Width, 14), frmMain.StringFormatCenterHor)

        If Thump IsNot Nothing Then e.Graphics.DrawImage(Thump, 2, 16, Thump.Width, Thump.Height)
    End Sub


    Private Sub ctrWaveform_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.Refresh()
    End Sub
    Private Sub ctrWaveform_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Refresh()
    End Sub

    Private Sub TitleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleToolStripMenuItem.Click
        If StringDialog("Title", Title) = DialogResult.OK Then
            Me.Refresh()
        End If
    End Sub
    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Dim frmColor As New ColorDialog
        frmColor.FullOpen = True
        frmColor.Color = Color
        If frmColor.ShowDialog = DialogResult.OK Then
            Color = frmColor.Color
            Me.Refresh()
        End If
    End Sub
    Private Sub DuplicateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuplicateToolStripMenuItem.Click
        Dim newWaveform As New ctrWaveform(Waveform)
        newWaveform.Title = Me.Title & " - clone"
        newWaveform.Color = Me.Color
        newWaveform.max = Me.max
        newWaveform.min = Me.min
        newWaveform.average = Me.average
        newWaveform.Thump = Me.Thump.Clone
        newWaveform.ID = Now.Ticks
        newWaveform.Location = New Point(Me.Location.X + 20, Me.Location.Y + 20)

        Engine.Waveforms.Add(newWaveform)
        frmWaveformsEditor.pnlMain.Controls.Add(newWaveform)
        newWaveform.BringToFront()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox("Are you sure you want to delete " & Me.Title & "?", "Delete", 3) = DialogResult.Yes Then
            Engine.Waveforms.Remove(Me)
            Me.Dispose()
        End If
    End Sub

    Private Sub ctrWaveform_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Edit()
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Edit()
    End Sub
End Class
