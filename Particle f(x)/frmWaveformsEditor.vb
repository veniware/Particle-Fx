Public Class frmWaveformsEditor

    Public Sub New()
        InitializeComponent()
        For i As Integer = 0 To Engine.Waveforms.Count - 1
            Me.pnlMain.Controls.Add(Engine.Waveforms(i))
        Next
    End Sub

    Sub AddNewWaveForm()
        Dim Title As String = "waveform"
        If StringDialog("Title", Title) = DialogResult.OK Then
            Dim r As New Random
            AddWaveform(Title, Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)))
        End If
    End Sub

    Sub Clear()
        If Not MessageBox("Are you sure you want to remove all waveforms?", "Clear", 3) = DialogResult.Yes Then Exit Sub

        Dim i As Integer
        Do Until Engine.Waveforms.Count = 0
            Engine.Waveforms.Remove(Engine.Waveforms(i))
        Loop
        Do Until pnlMain.Controls.Count = 0
            pnlMain.Controls(i).Dispose()
        Loop
    End Sub

    Sub Grid()
        pnlMain.AutoScroll = False
        For Each Tool As Control In pnlMain.Controls
            Dim P As Point = New Point(Math.Round(Tool.Left / 166) * 166 + 16, Math.Round(Tool.Top / 91) * 91 + 16)

research:
            For Each Finded As Control In pnlMain.Controls
                If Finded.Location = P And (Not Finded.GetHashCode = Tool.GetHashCode) Then
                    If P.Y < pnlMain.Height - 150 Then
                        P = New Point(P.X, P.Y + 91)
                    Else
                        P = New Point(P.X + 166, 16)
                    End If

                    GoTo research
                End If
            Next

            Tool.Location = P
        Next

        pnlMain.AutoScroll = True
        pnlMain.Refresh()
    End Sub

    Sub Cascade()
        SortPoint = New Point(8, 8)
        For i As Integer = 0 To Engine.Waveforms.Count - 1
            Engine.Waveforms(i).Location = SortPoint
            Engine.Waveforms(i).BringToFront()

            If SortPoint.Y > 360 Then
                SortPoint = New Point(SortPoint.X + 16, 8)
            Else
                SortPoint = New Point(SortPoint.X + 8, SortPoint.Y + 16)
            End If
        Next
    End Sub

    Sub Find()
        Dim Keyword As String = Nothing
        If StringDialog("Find", Keyword) = Windows.Forms.DialogResult.OK Then

            For i As Integer = 0 To Engine.Waveforms.Count - 1
                If InStr(Engine.Waveforms(i).Title.ToLower, Keyword.ToLower) > 0 Then
                    Engine.Waveforms(i).Focus()
                    Engine.Waveforms(i).BringToFront()
                    Exit For
                End If
            Next

        End If
    End Sub

    Private Sub frmWaveformsEditor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        pnlMain.Controls.Clear()
    End Sub

    Dim SortPoint As Point = New Point(8, 8)
    Public Sub AddWaveform(ByVal title As String, Optional ByVal color As Color = Nothing)
        Dim newWaveform As New ctrWaveform
        newWaveform.Title = title
        newWaveform.Color = color
        newWaveform.ID = Now.Ticks
        newWaveform.Location = SortPoint

        Engine.Waveforms.Add(newWaveform)
        Me.pnlMain.Controls.Add(newWaveform)

        newWaveform.BringToFront()

        If SortPoint.Y > 360 Then
            SortPoint = New Point(SortPoint.X + 16, 8)
        Else
            SortPoint = New Point(SortPoint.X + 8, SortPoint.Y + 16)
        End If
    End Sub

    Private Sub AddWaveformToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddWaveformToolStripMenuItem.Click
        AddNewWaveForm()
    End Sub
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Clear()
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        pnlMain.Refresh()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Find()
    End Sub

    Private Sub GridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridToolStripMenuItem.Click
        Grid()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Cascade()
    End Sub
End Class