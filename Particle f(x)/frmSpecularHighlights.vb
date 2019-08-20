Public Class frmSpecularHighlights

    Public WithEvents txtSpecLevel As New ctrValueBox
    Public WithEvents txtGlossiness As New ctrValueBox
    Public WithEvents txtX As New ctrValueBox
    Public WithEvents txtY As New ctrValueBox

    Sub New()
        InitializeComponent()

        txtSpecLevel.tmrChangeVals.Start()
        txtSpecLevel.Min = 1
        txtSpecLevel.Max = 200
        txtSpecLevel.Location = New Point(96, lblSpecLv.Top)

        txtGlossiness.tmrChangeVals.Start()
        txtGlossiness.Min = 1
        txtGlossiness.Max = 100
        txtGlossiness.Location = New Point(96, lblGloss.Top)

        txtX.tmrChangeVals.Start()
        txtX.Min = -100
        txtX.Max = 100
        txtX.Location = New Point(96, lblX.Top)

        txtY.tmrChangeVals.Start()
        txtY.Min = -100
        txtY.Max = 100
        txtY.Location = New Point(96, lblY.Top)

        Me.Controls.Add(txtSpecLevel)
        Me.Controls.Add(txtGlossiness)
        Me.Controls.Add(txtX)
        Me.Controls.Add(txtY)

        LoadPreview()
    End Sub

    Sub txtSpecLevel_ValueChanged() Handles txtSpecLevel.ValueChanged
        LoadPreview()
    End Sub
    Sub txtGlossiness_ValueChanged() Handles txtGlossiness.ValueChanged
        LoadPreview()
    End Sub
    Sub txtX_ValueChanged() Handles txtX.ValueChanged
        LoadPreview()
    End Sub
    Sub txtY_ValueChanged() Handles txtY.ValueChanged
        LoadPreview()
    End Sub

    Dim GlobalThead As Threading.Thread
    Sub LoadPreview()
        If GlobalThead IsNot Nothing Then GlobalThead.Abort()
        GlobalThead = New Threading.Thread(AddressOf DoPreview)
        GlobalThead.Start()
    End Sub

    Sub DoPreview()
        Dim R As Integer = pnlPreview.Width \ 2

        Dim Preview As New Bitmap(pnlPreview.Width, pnlPreview.Height, Imaging.PixelFormat.Format32bppArgb)

        For i As Integer = -R To R - 1
            For j = -R To R - 1

                Dim V As Decimal = (R - Math.Sqrt((i - txtX.Value) ^ 2 + (j + txtY.Value) ^ 2)) / R
                Dim S As Decimal = R - Math.Sqrt(i ^ 2 + j ^ 2)

                If V > 0 And S > 0 Then
                    If S > 1 Then S = 1

                    V *= txtSpecLevel.Value / 100
                    If V > 1 Then V = 1
                    V *= txtGlossiness.Value / 100

                    Dim c As Byte = V * S * 255
                    Preview.SetPixel(i + R, j + R, Color.FromArgb(c, _GlossColor.R, _GlossColor.G, _GlossColor.B))

                End If

            Next
        Next

        pnlPreview.BackgroundImage = Preview
    End Sub
End Class