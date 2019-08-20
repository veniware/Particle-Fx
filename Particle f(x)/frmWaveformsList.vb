Public Class frmWaveformsList

    Public max, min As Long

    Public Sub New()
        InitializeComponent()
        LoadDB()
    End Sub

    Sub LoadDB()
        lstWaveforms.Items.Clear()
        For i As Integer = 0 To Engine.Waveforms.Count - 1
            lstWaveforms.Items.Add(Engine.Waveforms(i).Title)
        Next
    End Sub

    Private Sub lstWaveforms_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles lstWaveforms.DrawItem
        If e.Index = -1 Then Exit Sub

        If e.Index Mod 2 = 0 Then
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(140, 140, 140)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        Else
            e.Graphics.FillRectangle(New SolidBrush(Color.Gray), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        End If

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(160, 160, 160)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        End If

        e.Graphics.DrawString(lstWaveforms.Items(e.Index).ToString, Me.Font, New SolidBrush(Color.White), e.Bounds.X + 18, e.Bounds.Y)
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(128, Engine.Waveforms(e.Index).Color)), e.Bounds.X + 2, e.Bounds.Y + 1, 14, 14)
    End Sub

    Private Sub lstWaveforms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWaveforms.SelectedIndexChanged
        pnlThump.BackgroundImage = Engine.Waveforms(lstWaveforms.SelectedIndex).Thump

        If lstWaveforms.SelectedIndex = -1 Then
            cmdOK.Enabled = False
        Else
            cmdOK.Enabled = True
        End If

        lblMax.Text = "Max: " & Engine.Waveforms(lstWaveforms.SelectedIndex).max
        lblMin.Text = "Min: " & Engine.Waveforms(lstWaveforms.SelectedIndex).min
        lblAve.Text = "Average: " & Engine.Waveforms(lstWaveforms.SelectedIndex).average
        lblLen.Text = "Lenght: " & Engine.Waveforms(lstWaveforms.SelectedIndex).Waveform.Count

        If Not (max = 0 And min = 0) Then

            If Engine.Waveforms(lstWaveforms.SelectedIndex).max > max Then
                lblMax.ForeColor = Color.Red
                lblMax.Text &= " > " & max
            Else
                lblMax.ForeColor = Me.ForeColor
            End If

            If Engine.Waveforms(lstWaveforms.SelectedIndex).min < min Then
                lblMin.ForeColor = Color.Red
                lblMin.Text &= " < " & min
            Else
                lblMin.ForeColor = Me.ForeColor
            End If

        End If
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Done()
    End Sub

    Private Sub lstWaveforms_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstWaveforms.DoubleClick
        If lstWaveforms.SelectedIndex > -1 Then Done()
    End Sub

    Sub Done()
        If Engine.Waveforms(lstWaveforms.SelectedIndex).Waveform.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox("This waveform if empty", "Empty waveform")
        End If
    End Sub
End Class