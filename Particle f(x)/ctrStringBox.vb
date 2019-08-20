Public Class ctrStringBox

    Public Event ValueChanged()

    Public Value As String
    Public isReadOnly As Boolean = False
    Public isPathName As Boolean = False

    Dim sel, unsel As Image
    Public Sub New()
        InitializeComponent()

        Dim G As Graphics

        sel = New Bitmap(Me.Width, Me.Height, Imaging.PixelFormat.Format24bppRgb)
        G = Graphics.FromImage(sel)
        G.DrawImage(My.Resources.WaveformBG, 0, 0, sel.Width, sel.Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(24, 255, 255, 255)), 0, 0, sel.Width, sel.Height)

        unsel = New Bitmap(Me.Width, Me.Height, Imaging.PixelFormat.Format24bppRgb)
        G = Graphics.FromImage(unsel)
        G.DrawImage(My.Resources.WaveformBG, 0, 0, sel.Width, sel.Height)
        G.FillRectangle(New SolidBrush(Color.FromArgb(24, 0, 0, 0)), 0, 0, unsel.Width, unsel.Height)

        G.Dispose()

        Me.BackgroundImage = unsel
    End Sub

    Sub Type()
        If isReadOnly Then Exit Sub

        If StringDialog("Edit value", Value) = DialogResult.OK Then
            Value2 = Value
            Me.Refresh()
            RaiseEvent ValueChanged()
        End If
    End Sub

    Public Sub SetValue(ByVal v As String)
        Value = v
        Value2 = v
        Me.Refresh()
    End Sub

    Private Sub ctrValueBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.BackgroundImage = sel
    End Sub
    Private Sub ctrValueBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.BackgroundImage = unsel
    End Sub

    Private Sub ctrValueBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim v As String = Value
        If isPathName And v IsNot Nothing Then
            Dim f As New IO.FileInfo(v)
            v = f.Name
        End If

        If Me.Focused Then
            e.Graphics.DrawString(v, Me.Font, Brushes.White, New Rectangle(2, 0, Me.Width, Me.Height), frmMain.StringFormatLeftCenter)
        Else
            e.Graphics.DrawString(v, Me.Font, Brushes.Gainsboro, New Rectangle(2, 0, Me.Width, Me.Height), frmMain.StringFormatLeftCenter)
        End If
    End Sub

    Private Sub ctrValueBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If isReadOnly Then Exit Sub

        If Asc(e.KeyChar) = 13 Then 'enter
            Type()

        ElseIf Asc(e.KeyChar) = 8 Then 'backspace
            If Value.Length > 0 Then Value = Microsoft.VisualBasic.Left(Value, Value.Length - 1)
            Me.Refresh()

        ElseIf Asc(e.KeyChar) > 31 Then
            Value &= e.KeyChar
            Me.Refresh()

        End If
    End Sub

    Private Sub ctrValueBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Type()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Type()
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If isReadOnly Then ContextMenuStrip1.Enabled = False
    End Sub

    Dim Value2 As String
    Private Sub tmrChangeVals_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChangeVals.Tick
        If Not Value2 = Value Then
            Value2 = Value
            RaiseEvent ValueChanged()
        End If
    End Sub
End Class
