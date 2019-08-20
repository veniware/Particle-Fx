Public Class frmWaveformEditor

    Public Waveform As New List(Of Double)

    Public max As Long
    Public min As Long
    Public average As Long

    Public Sub New(Optional ByVal WF As List(Of Double) = Nothing)
        InitializeComponent()

        cmbSkip.SelectedIndex = 2
        cmbRender.SelectedIndex = 1
        cmbQuality.SelectedIndex = 0
        cmbFunction.SelectedIndex = 0

        txtRange.Value = _FrameRangeTo

        If WF IsNot Nothing Then
            If WF.Count > 1 Then txtRange.Value = WF.Count - 1
            Waveform = WF
            FindLimits()
            RenderGraph()
        End If
    End Sub

    Sub RenderGraph()
        Dim Graph As Image = New Bitmap(pnlFrame.Width, pnlFrame.Height, Imaging.PixelFormat.Format24bppRgb)
        Dim G As Graphics = Graphics.FromImage(Graph)
        G.Clear(pnlFrame.BackColor)

        G.FillRectangle(Brushes.Black, 0, Graph.Height \ 2, Graph.Width, 1)

        If Waveform.Count = 0 Then Exit Sub

        If cmbQuality.SelectedIndex Then G.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim Skip As Short = Val(cmbSkip.SelectedItem) + 1

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
            CONVE = Graph.Height / M / 2
        End If

        Select Case cmbRender.SelectedIndex

            Case 0
                For t As Integer = 0 To Waveform.Count - 1 Step Skip
                    G.FillEllipse(Brushes.Black, t * Graph.Width \ Waveform.Count - 1, CType(Waveform(t) * CONVE, Long) + Graph.Height \ 2 - 1, 3, 3)
                Next

            Case 1
                For t As Integer = Skip To Waveform.Count - 1 Step Skip
                    G.DrawLine(New Pen(Brushes.Black, 2), (t - Skip) * Graph.Width \ Waveform.Count, CType(Waveform(t - Skip) * CONVE, Long) + Graph.Height \ 2, t * Graph.Width \ Waveform.Count, CType(Waveform(t) * CONVE, Long) + Graph.Height \ 2)
                Next

            Case 2
                If Waveform.Count / Skip < 2 Then Exit Select
                Dim Points(Waveform.Count / Skip) As Point
                For t As Integer = 0 To Waveform.Count - 1 Step Skip
                    Points(t / Skip) = New Point(t * Graph.Width \ Waveform.Count, CType(Waveform(t) * CONVE, Long) + Graph.Height \ 2)
                Next

                If Points(Points.Length - 1) = Nothing Then Points(Points.Length - 1) = Points(Points.Length - 2)

                G.DrawCurve(New Pen(Brushes.Black, 2), Points, 0.5)

        End Select

        Graph.RotateFlip(RotateFlipType.RotateNoneFlipY)

        G.DrawString(0, Me.Font, Brushes.Blue, Graph.Width - 4, Graph.Height \ 2 - 16, frmMain.StringFormatRight)
        G.DrawString(M, Me.Font, Brushes.Blue, Graph.Width - 4, 4, frmMain.StringFormatRight)
        G.DrawString(-M, Me.Font, Brushes.Blue, Graph.Width - 4, Graph.Height - 20, frmMain.StringFormatRight)

        pnlFrame.BackgroundImage = Graph
    End Sub

    Sub Apply()
        Waveform.Clear()

        Select Case cmbFunction.SelectedItem.ToString

            Case "General equation"
                For t As Integer = 0 To txtRange.Value
                    Waveform.Add(txt1.Value * t + txt2.Value)
                Next
                FindLimits()

            Case "Quadratic equation"
                For t As Integer = 0 To txtRange.Value
                    Waveform.Add(txt1.Value * t ^ 2 + txt2.Value * t + txt3.Value)
                Next
                FindLimits()

            Case "Tertiary equation"
                For t As Integer = 0 To txtRange.Value
                    Waveform.Add(txt1.Value * t ^ 3 + txt2.Value * t ^ 2 + txt3.Value * t + txt4.Value)
                Next
                FindLimits()

            Case "Square root"
                For t As Integer = 0 To txtRange.Value
                    Waveform.Add(Math.Sqrt(txt1.Value * t + txt2.Value) * txt3.Value + txt4.Value)
                Next
                FindLimits()

            Case "Sine"
                For t As Integer = 0 To txtRange.Value
                    Waveform.Add(Math.Sin((txt1.Value * t + txt2.Value) / ANGLECONVERT) * txt3.Value + txt4.Value)
                Next
                FindLimits()

            Case "Cosine"
                For t As Integer = 0 To txtRange.Value
                    Waveform.Add(Math.Cos((txt1.Value * t + txt2.Value) / ANGLECONVERT) * txt3.Value + txt4.Value)
                Next
                FindLimits()

            Case "Random"
                Dim ran As New Random(System.DateTime.Now.Millisecond)
                For t As Integer = 0 To txtRange.Value
                    Dim mi, ma, te As Double

                    mi = txt1.Value * 100
                    ma = txt2.Value * 100

                    If mi > ma Then
                        te = mi
                        mi = ma
                        ma = te
                    End If

                    Waveform.Add(CType(ran.Next(mi, ma), Double) / 100)
                Next
                FindLimits()

        End Select

        RenderGraph()
    End Sub

    Sub FindLimits()
        min = 0
        max = 0

        If Waveform.Count > 0 Then

            max = Waveform(0)
            min = Waveform(0)
            For i As Integer = 1 To Waveform.Count - 1
                If max < Waveform(i) Then max = Waveform(i)
                If min > Waveform(i) Then min = Waveform(i)
            Next

            If Waveform.Count > 1000 Then
                Dim a(Waveform.Count \ 10) As Long
                For i As Integer = 0 To Waveform.Count - 1
                    a(i \ (a.Length - 1)) = 0
                Next
                For i As Integer = 0 To Waveform.Count - 1
                    a(i \ (a.Length - 1)) += Waveform(i)
                Next
                Dim a2 As Double = 0
                For i As Short = 0 To a.Length - 1 - 1
                    a2 += a(i) / 10
                Next
                average = a2

            Else

                Dim a As Long = 0
                For i As Integer = 0 To Waveform.Count - 1
                    a += Waveform(i)
                Next
                average = a / Waveform.Count

            End If


        End If
    End Sub

    Private Sub cmbSkip_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSkip.SelectedIndexChanged
        RenderGraph()
    End Sub
    Private Sub cmbRender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRender.SelectedIndexChanged
        RenderGraph()
    End Sub
    Private Sub cmbQuality_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbQuality.SelectedIndexChanged
        RenderGraph()
    End Sub
    Private Sub frmWaveformEditor_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        RenderGraph()
    End Sub
    '101 : Adder
    '102 : Subtractor

    Private Sub cmbFunction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFunction.SelectedIndexChanged
        lbl1.Text = "a: "
        lbl2.Text = "b: "

        Select Case cmbFunction.SelectedItem.ToString


            Case "General equation"
                lblFormula.Text = "Formula: at + b"
                txt1.Enabled = True
                txt2.Enabled = True
                txt3.Enabled = False
                txt4.Enabled = False
                txt1.Value = 1
                txt2.Value = 0
                txt3.Value = 0
                txt4.Value = 0

            Case "Quadratic equation"
                lblFormula.Text = "Formula: at^2 + bt + c"
                txt1.Enabled = True
                txt2.Enabled = True
                txt3.Enabled = True
                txt4.Enabled = False
                txt1.Value = 1
                txt2.Value = 0
                txt3.Value = 0
                txt4.Value = 0

            Case "Tertiary equation"
                lblFormula.Text = "Formula: at^3 + bt^2 + ct + d"
                txt1.Enabled = True
                txt2.Enabled = True
                txt3.Enabled = True
                txt4.Enabled = True
                txt1.Value = 1
                txt2.Value = 0
                txt3.Value = 0
                txt4.Value = 0

            Case "Square root"
                lblFormula.Text = "Formula: sqrt(at + b)*c + d"
                txt1.Enabled = True
                txt2.Enabled = True
                txt3.Enabled = True
                txt4.Enabled = True
                txt1.Value = 1
                txt2.Value = 0
                txt3.Value = 1
                txt4.Value = 0

            Case "Sine"
                lblFormula.Text = "Formula: sin(at + b)*c + d"
                txt1.Enabled = True
                txt2.Enabled = True
                txt3.Enabled = True
                txt4.Enabled = True
                txt1.Value = 1
                txt2.Value = 0
                txt3.Value = 1
                txt4.Value = 0

            Case "Cosine"
                lblFormula.Text = "Formula: cos(at + b)*c + d"
                txt1.Enabled = True
                txt2.Enabled = True
                txt3.Enabled = True
                txt4.Enabled = True
                txt1.Value = 1
                txt2.Value = 0
                txt3.Value = 1
                txt4.Value = 0

            Case "Random"
                lblFormula.Text = ""
                txt1.Enabled = True
                txt2.Enabled = True
                txt3.Enabled = False
                txt4.Enabled = False
                txt1.Value = 0
                txt2.Value = 10
                txt3.Value = 0
                txt4.Value = 0
                lbl1.Text = "min: "
                lbl2.Text = "max: "

        End Select
    End Sub

    Private Sub cmdApply2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply2.Click
        Apply()
    End Sub
    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        Apply()
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        'Apply()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cmdAbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbs.Click
        For i As Integer = 0 To Waveform.Count - 1
            Waveform(i) = Math.Abs(Waveform(i))
        Next
        RenderGraph()
    End Sub
    Private Sub cmdOpposite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpposite.Click
        For i As Integer = 0 To Waveform.Count - 1
            Waveform(i) = Waveform(i) * -1
        Next
        RenderGraph()
    End Sub
    Private Sub cmdSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSqrt.Click
        For i As Integer = 0 To Waveform.Count - 1
            If Waveform(i) > 0 Then
                Waveform(i) = Math.Sqrt(Waveform(i))
            End If
        Next
        FindLimits()
        RenderGraph()
    End Sub
    Private Sub cmDerivative_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmDerivative.Click
        For i As Integer = Waveform.Count - 1 To 1 Step -1
            Waveform(i) = (Waveform(i - 1) - Waveform(i)) / -1
        Next
        FindLimits()
        RenderGraph()
    End Sub
End Class