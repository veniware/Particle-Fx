Public Class ctrDynamicButton
    Public Label As String
    Public Icon As Image

    Public Event ClickOrEnterOrAnything()
    Public Event ESC()

    Private Sub ctrDynamicButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        RaiseEvent ClickOrEnterOrAnything()
    End Sub
    Private Sub ctrDynamicButton_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Enter
            RaiseEvent ClickOrEnterOrAnything()

        ElseIf Asc(e.KeyChar) = 27 Then 'Esc
            RaiseEvent ESC()

        End If
    End Sub

    Dim sel, unsel As Image
    Public Sub New()
        InitializeComponent()

        Dim G As Graphics

        sel = New Bitmap(Me.Width, Me.Height, Imaging.PixelFormat.Format24bppRgb)
        G = Graphics.FromImage(sel)
        G.DrawImage(My.Resources.WaveformBG, 0, 0, sel.Width, sel.Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(16, 255, 255, 255)), 0, 0, sel.Width, sel.Height)

        unsel = New Bitmap(Me.Width, Me.Height, Imaging.PixelFormat.Format24bppRgb)
        G = Graphics.FromImage(unsel)
        G.DrawImage(My.Resources.WaveformBG, 0, 0, sel.Width, sel.Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(24, 0, 0, 0)), 0, 0, unsel.Width, unsel.Height)

        G.Dispose()

        Me.BackgroundImage = unsel
    End Sub

    Private Sub ctrDynamicButton_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.BackgroundImage = sel
    End Sub
    Private Sub ctrDynamicButton_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.BackgroundImage = unsel
    End Sub

    Private Sub ctrDynamicButton_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawString(Label, Me.Font, Brushes.Black, New Rectangle(1, 1, Me.Width - 4, Me.Height - 4), frmMain.StringFormatCenterBot)
        e.Graphics.DrawString(Label, Me.Font, Brushes.White, New Rectangle(0, 0, Me.Width - 4, Me.Height - 4), frmMain.StringFormatCenterBot)
        'e.Graphics.DrawImage(My.Resources.icoMove, 0, 0, 32, 32)
    End Sub
End Class
