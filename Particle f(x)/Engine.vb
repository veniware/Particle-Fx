Module Engine

    Public _CameraIndex As Short = -1
    Public _FrameRangeFrom As Integer = 0
    Public _FrameRangeTo As Integer = 99
    Public _FPS As Double = 25
    Public _PixelFormat As Imaging.PixelFormat = Imaging.PixelFormat.Format32bppArgb
    Public _ImageFormat As Imaging.ImageFormat = Imaging.ImageFormat.Png
    Public _ImageFormatIndex As Byte = 0
    Public _Smoothing As Drawing2D.SmoothingMode = 1
    Public _ExportPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop.ToString
    Public _SkipExistingFrames As Boolean = False

    Public _BGTransparent As Boolean = True
    Public _BGSolid As Boolean = False
    Public _BGFile As Boolean = False
    Public _BGColor As Color = Color.White
    Public _BGFilePath As String
    Public _DrawGens As Boolean = False
    Public _DrawStatic As Boolean = False

    Public _GlobalColor As Boolean = False
    Public _GlobalColorValue As Color = Color.Blue
    Public _GlobalColorOpacity As Byte = 50
    Public _SpecHighlights As Boolean = False
    Public _GlossColor As Color = Color.White
    Public _SpecLevel As Byte = 100
    Public _Glossiness As Byte = 50
    Public _SpecHighlightsX As Integer = 30
    Public _SpecHighlightsY As Integer = 30
    Public _Glow As Boolean = False
    Public _GlowColor As Color = Color.FromArgb(192, 192, 255)
    Public _GlowOpacity As Byte = 50
    Public _MotionBlur As Boolean = False
    Public _MotionBlurSamples As Byte = 12
    Public _ParticlesSolidColor As Boolean = True
    Public _ParticleReflect As Boolean = False
    Public _ParticleReflectOpacity As Byte = 100
    Public _ParticleRefract As Boolean = False
    Public _ParticleRefractOpacity As Byte = 100
    Public _ParticleRefractIOR As Decimal = 1.4
    Public _ParticleExitColor As Color = Color.Black

    Public _ReactorIndex As Byte = 1
    Public _G As Double = 3
    Public _ParticlesReactEachOther As Boolean = False

    Public Structure Particle
        Dim R As Short
        Dim x As Double
        Dim y As Double
        Dim x0 As Double
        Dim y0 As Double
        Dim Fx As Double
        Dim Fy As Double
        Dim Life As Integer
        Dim Color As Color
    End Structure

    Public Structure PointGen
        Dim name As String
        Dim ID As Long
        Dim x As Integer
        Dim y As Integer
        Dim Noice As Byte
        Dim R As Byte
        Dim startGen As Integer
        Dim stopGen As Integer
        Dim ppf As Short
        Dim Life As Integer
        Dim Color As Color

        Dim wNoice As ctrWaveform
        Dim wR As ctrWaveform
        Dim wPPF As ctrWaveform
    End Structure

    Public Structure SprayGen
        Dim name As String
        Dim ID As Long
        Dim x As Integer
        Dim y As Integer
        Dim Slope As Short '0-359
        Dim F0 As Double
        Dim Noice As Byte
        Dim R As Byte
        Dim startGen As Integer
        Dim stopGen As Integer
        Dim ppf As Short
        Dim Life As Integer
        Dim Color As Color

        Dim wF0 As ctrWaveform
        Dim wNoice As ctrWaveform
        Dim wR As ctrWaveform
        Dim wPPF As ctrWaveform
    End Structure

    Public Structure RainGen
        Dim name As String
        Dim ID As Long
        Dim x As Integer
        Dim y As Integer
        Dim Widht As Integer
        Dim F0 As Double
        Dim Noice As Byte
        Dim R As Byte
        Dim startGen As Integer
        Dim stopGen As Integer
        Dim ppf As Short
        Dim Life As Integer
        Dim Color As Color

        Dim wF0 As ctrWaveform
        Dim wNoice As ctrWaveform
        Dim wR As ctrWaveform
        Dim wPPF As ctrWaveform
    End Structure

    Public Structure RandomGen
        Dim name As String
        Dim ID As Long
        Dim x As Integer
        Dim y As Integer
        Dim Widht As Integer
        Dim Height As Integer
        Dim R As Byte
        Dim startGen As Integer
        Dim stopGen As Integer
        Dim ppf As Short
        Dim Life As Integer
        Dim Color As Color

        Dim wR As ctrWaveform
        Dim wPPF As ctrWaveform
    End Structure

    Public Structure BitmapGen
        Dim name As String
        Dim ID As Long
        Dim x As Integer
        Dim y As Integer
        Dim Widht As Integer
        Dim Height As Integer
        Dim R As Byte
        Dim startGen As Integer
        Dim Life As Integer
        Dim BitmapPath As String
    End Structure

    Public Structure Camera
        Dim name As String
        Dim ID As Long
        Dim x As Integer
        Dim y As Integer
        Dim Widht As Integer
        Dim Height As Integer
    End Structure

    Public Structure Wind
        Dim name As String
        Dim ID As Long
        Dim x As Integer
        Dim y As Integer
        Dim Widht As Integer
        Dim Height As Integer
        Dim F As Decimal
    End Structure

    Public Structure Expant
        Dim name As String
        Dim ID As Long
        Dim x As Integer
        Dim y As Integer
        Dim R As Integer
        Dim F As Decimal
    End Structure

    Public Structure BlackHole
        Dim name As String
        Dim ID As Long
        Dim x As Integer
        Dim y As Integer
        Dim R As Integer
        Dim F As Decimal
    End Structure

    Public Structure Fan
        Dim name As String
        Dim ID As Long
        Dim x As Integer
        Dim y As Integer
        Dim R As Integer
        Dim F As Decimal
    End Structure

    Public Structure Whirlpool
        Dim name As String
        Dim ID As Long
        Dim x As Integer
        Dim y As Integer
        Dim R As Integer
        Dim F As Decimal
    End Structure

    Public Structure Expiry
        Dim name As String
        Dim ID As String
        Dim y As Integer
    End Structure

    Public Structure ObjectItem
        Dim Name As String
        Dim ID As Long
        Dim Type As Byte
    End Structure

    Public Waveforms As New List(Of ctrWaveform)

    Public lstObjectsBG As New List(Of ObjectItem)

    'Public Particles As New List(Of Particle)

    Public Points As New List(Of PointGen)
    Public Rains As New List(Of RainGen)
    Public Sprays As New List(Of SprayGen)
    Public Randoms As New List(Of RandomGen)
    Public Bitmaps As New List(Of BitmapGen)

    Public Expirys As New List(Of Expiry)

    Public Winds As New List(Of Wind)
    Public Expants As New List(Of Expant)
    Public BlackHoles As New List(Of BlackHole)
    Public Fans As New List(Of Fan)
    Public Whirlpools As New List(Of Whirlpool)

    Public WarpWidth As Integer = 1
    Public WarpHeight As Integer = 1
    Public WarpX(,) As Double
    Public WarpY(,) As Double
    Public RedZone(,) As Boolean

    Public Cameras As New List(Of Camera)

    Public StaticMap As Image

    'Public FramesCounter As Integer

    Public Function RenderWarpMap() As Image
        Dim maxabs As Long = 1
        For i As Integer = 0 To WarpWidth - 1
            For j As Integer = 0 To WarpHeight - 1
                If maxabs < Math.Abs(WarpX(i, j)) Then maxabs = Math.Abs(WarpX(i, j))
                If maxabs < Math.Abs(WarpY(i, j)) Then maxabs = Math.Abs(WarpY(i, j))
            Next
        Next

        Dim map As New Bitmap(WarpWidth, WarpHeight, Imaging.PixelFormat.Format24bppRgb)
        Dim G As Graphics = Graphics.FromImage(map)
        G.Clear(Color.FromArgb(128, 128, 128))
        G.Dispose()

        maxabs += 1

        For i As Integer = 0 To map.Width - 1
            For j As Integer = 0 To map.Height - 1
                If RedZone(i, j) Then
                    map.SetPixel(i, j, Color.Red)
                Else
                    map.SetPixel(i, j, Color.FromArgb(128, 128 + 127 * WarpX(i, j) \ maxabs, 128 + 127 * WarpY(i, j) \ maxabs))
                End If
            Next
        Next

        Return map

    End Function

    Function ForceXAt(ByVal P As Point) As Integer
        If P.X > WarpWidth Or P.X < 0 Or P.Y > WarpHeight Or P.Y < 0 Then
            Return 0
        Else
            Return WarpX(P.X, P.Y)
        End If
    End Function
    Function ForceYAt(ByVal P As Point) As Integer
        If P.X > WarpWidth Or P.X < 0 Or P.Y > WarpHeight Or P.Y < 0 Then
            Return 0
        Else
            Return WarpY(P.X, P.Y)
        End If
    End Function
    Function RedAt(ByVal P As Point) As Boolean
        If P.X > WarpWidth Or P.X < 0 Or P.Y > WarpHeight Or P.Y < 0 Then
            Return False
        Else
            Return RedZone(P.X, P.Y)
        End If
    End Function

    Public Sub BuildWarp()

        Dim maxWidth, maxHeight As Integer
        maxWidth = 1
        maxHeight = 1
        For Each F As Engine.Wind In Engine.Winds
            If maxWidth < F.x + F.Widht Then maxWidth = F.x + F.Widht
            If maxHeight < F.y + F.Height Then maxHeight = F.y + F.Height
        Next
        For Each F As Engine.Expant In Engine.Expants
            If maxWidth < F.x + F.R * 2 Then maxWidth = F.x + F.R * 2
            If maxHeight < F.y + F.R * 2 Then maxHeight = F.y + F.R * 2
        Next
        For Each F As Engine.BlackHole In Engine.BlackHoles
            If maxWidth < F.x + F.R * 2 Then maxWidth = F.x + F.R * 2
            If maxHeight < F.y + F.R * 2 Then maxHeight = F.y + F.R * 2
        Next
        For Each F As Engine.Fan In Engine.Fans
            If maxWidth < F.x + F.R * 2 Then maxWidth = F.x + F.R * 2
            If maxHeight < F.y + F.R * 2 Then maxHeight = F.y + F.R * 2
        Next
        For Each F As Engine.Whirlpool In Engine.Whirlpools
            If maxWidth < F.x + F.R * 2 Then maxWidth = F.x + F.R * 2
            If maxHeight < F.y + F.R * 2 Then maxHeight = F.y + F.R * 2
        Next


        WarpWidth = maxWidth + 12
        WarpHeight = maxHeight + 12
        Dim newWarpX(WarpWidth, WarpHeight) As Double
        Dim newWarpY(WarpWidth, WarpHeight) As Double
        Dim newRedZone(WarpWidth, WarpHeight) As Boolean


        For Each F As Engine.Wind In Engine.Winds
            Dim fx As Integer = F.x
            Dim tx As Integer = F.x + F.Widht
            Dim fy As Integer = F.y
            Dim ty As Integer = F.y + F.Height

            If fx < 0 Then fx = 0
            If fy < 0 Then fy = 0

            For i As Integer = fx To tx
                For j As Integer = fy To ty
                    newWarpX(i, j) += F.F
                Next
            Next
        Next

        For Each F As Engine.Expant In Engine.Expants
            Dim fx As Integer = F.x
            Dim tx As Integer = F.x + F.R * 2
            Dim fy As Integer = F.y
            Dim ty As Integer = F.y + F.R * 2

            If fx < 0 Then fx = 0
            If fy < 0 Then fy = 0

            For i As Integer = fx To tx
                For j As Integer = fy To ty

                    Dim aX As Integer = i - fx - F.R
                    Dim aY As Integer = j - fy - F.R
                    Dim pith As Integer = Math.Sqrt(aX ^ 2 + aY ^ 2)
                    If pith < F.R Then
                        newWarpX(i, j) += ((F.R - pith) * aX * F.F) / (F.R * 10)
                        newWarpY(i, j) += ((F.R - pith) * aY * F.F) / (F.R * 10)
                    End If

                Next
            Next
        Next

        For Each F As Engine.BlackHole In Engine.BlackHoles
            Dim fx As Integer = F.x
            Dim tx As Integer = F.x + F.R * 2
            Dim fy As Integer = F.y
            Dim ty As Integer = F.y + F.R * 2

            If fx < 0 Then fx = 0
            If fy < 0 Then fy = 0

            For i As Integer = fx To tx
                For j As Integer = fy To ty

                    Dim aX As Integer = i - fx - F.R
                    Dim aY As Integer = j - fy - F.R
                    Dim pith As Integer = Math.Sqrt(aX ^ 2 + aY ^ 2)
                    If pith < F.R Then
                        newWarpX(i, j) -= ((F.R - pith) * aX * F.F) / (F.R * 10)
                        newWarpY(i, j) -= ((F.R - pith) * aY * F.F) / (F.R * 10)
                        If pith < F.R \ 8 Then newRedZone(i, j) = True
                    End If

                Next
            Next
        Next

        For Each F As Engine.Fan In Engine.Fans
            Dim fx As Integer = F.x
            Dim tx As Integer = F.x + F.R * 2
            Dim fy As Integer = F.y
            Dim ty As Integer = F.y + F.R * 2

            If fx < 0 Then fx = 0
            If fy < 0 Then fy = 0

            For i As Integer = fx To tx
                For j As Integer = fy To ty

                    Dim aX As Integer = i - fx - F.R
                    Dim aY As Integer = j - fy - F.R
                    Dim pith As Integer = Math.Sqrt(aX ^ 2 + aY ^ 2)
                    If pith < F.R Then
                        newWarpX(i, j) -= ((F.R - pith) * aY * F.F) / (F.R * 10)
                        newWarpY(i, j) += ((F.R - pith) * aX * F.F) / (F.R * 10)
                    End If

                Next
            Next
        Next

        For Each F As Engine.Whirlpool In Engine.Whirlpools
            Dim fx As Integer = F.x
            Dim tx As Integer = F.x + F.R * 2
            Dim fy As Integer = F.y
            Dim ty As Integer = F.y + F.R * 2

            If fx < 0 Then fx = 0
            If fy < 0 Then fy = 0

            For i As Integer = fx To tx
                For j As Integer = fy To ty

                    Dim aX As Integer = i - fx - F.R
                    Dim aY As Integer = j - fy - F.R
                    Dim pith As Integer = Math.Sqrt(aX ^ 2 + aY ^ 2)
                    If pith < F.R Then
                        newWarpX(i, j) -= (((F.R - pith) * aX * F.F) / (F.R * 10) + ((F.R - pith) * aY * F.F) / (F.R * 10)) / 2
                        newWarpY(i, j) -= (((F.R - pith) * aY * F.F) / (F.R * 10) - ((F.R - pith) * aX * F.F) / (F.R * 10)) / 2
                        If pith < F.R \ 8 Then newRedZone(i, j) = True
                    End If

                Next
            Next
        Next

        WarpX = newWarpX
        WarpY = newWarpY
        RedZone = newRedZone
    End Sub

    Sub WavesBalancer()
        For i As Integer = 0 To Waveforms.Count - 1
            If Waveforms(i).Waveform.Count = 0 Then Continue For
            Do While Waveforms(i).Waveform.Count < _FrameRangeTo
                Waveforms(i).Waveform.Add(Waveforms(i).Waveform(Waveforms(i).Waveform.Count - 1))
                Waveforms(i).RefreshThump()
            Loop
        Next
    End Sub

    Dim GlossinessMap As Bitmap
    Sub BuildGlossiness()
        GlossinessMap = New Bitmap(200, 200, Imaging.PixelFormat.Format32bppArgb)

        Dim R As Integer = GlossinessMap.Width \ 2

        For i As Integer = -R To R - 1
            For j = -R To R - 1

                Dim V As Decimal = (R - Math.Sqrt((i - _SpecHighlightsX) ^ 2 + (j + _SpecHighlightsY) ^ 2)) / R
                Dim S As Decimal = R - Math.Sqrt(i ^ 2 + j ^ 2)

                If V > 0 And S > 0 Then
                    If S > 1 Then S = 1

                    V *= _SpecLevel / 100
                    If V > 1 Then V = 1
                    V *= _Glossiness / 100

                    Dim c As Byte = V * S * 255
                    GlossinessMap.SetPixel(i + R, j + R, Color.FromArgb(c, _GlossColor.R, _GlossColor.G, _GlossColor.B))
                End If

            Next
        Next
    End Sub

    Sub GenerateParticles(ByRef p As List(Of Particle), ByVal FrameIndex As Integer)

        For i As Integer = 0 To Points.Count - 1
            If FrameIndex < Points(i).startGen Or FrameIndex > Points(i).stopGen Then Continue For

            Dim Noice As Integer
            Dim R As Integer
            Dim PPF As Integer

            If Points(i).wNoice Is Nothing Then Noice = Points(i).Noice Else Noice = Points(i).wNoice.Waveform(FrameIndex)
            If Points(i).wR Is Nothing Then R = Points(i).R Else R = Points(i).wR.Waveform(FrameIndex)
            If Points(i).wPPF Is Nothing Then PPF = Points(i).ppf Else PPF = Points(i).wPPF.Waveform(FrameIndex)

            If Noice < MinNoice Then Noice = MinNoice Else If Noice > MaxNoice Then Noice = MaxNoice
            If R < MinR Then R = MinR Else If R > MaxR Then R = MaxR
            If PPF < MinPPF Then PPF = MinPPF Else If PPF > MaxPPF Then PPF = MaxPPF

            For c As Integer = 1 To PPF
                Dim n As New Particle
                n.R = R
                n.x = Points(i).x + Math.Cos(Rnd() * 360 / 57.29577951) * Noice
                n.y = Points(i).y + Math.Sin(Rnd() * 360 / 57.29577951) * Noice
                n.x0 = n.x
                n.y0 = n.y
                n.Fx = 0
                n.Fy = 0
                n.Life = Points(i).Life
                n.Color = Points(i).Color

                p.Add(n)
            Next
        Next

        For i As Integer = 0 To Rains.Count - 1
            If FrameIndex < Rains(i).startGen Or FrameIndex > Rains(i).stopGen Then Continue For

            Dim F As Integer
            Dim Noice As Integer
            Dim R As Integer
            Dim PPF As Integer

            If Rains(i).wF0 Is Nothing Then F = Rains(i).F0 Else F = Rains(i).wF0.Waveform(FrameIndex)
            If Rains(i).wNoice Is Nothing Then Noice = Rains(i).Noice Else Noice = Rains(i).wNoice.Waveform(FrameIndex)
            If Rains(i).wR Is Nothing Then R = Rains(i).R Else R = Rains(i).wR.Waveform(FrameIndex)
            If Rains(i).wPPF Is Nothing Then PPF = Rains(i).ppf Else PPF = Rains(i).wPPF.Waveform(FrameIndex)

            If F < MinF Then F = MinF Else If F > MaxF Then F = MaxF
            If Noice < MinNoice Then Noice = MinNoice Else If Noice > MaxNoice Then Noice = MaxNoice
            If R < MinR Then R = MinR Else If R > MaxR Then R = MaxR
            If PPF < MinPPF Then PPF = MinPPF Else If PPF > MaxPPF Then PPF = MaxPPF

            For c As Integer = 1 To PPF
                Dim n As New Particle
                n.R = R
                n.x = Rains(i).x + Rains(i).Widht * Rnd()
                n.y = Rains(i).y
                n.x0 = n.x
                n.y0 = n.y
                n.Fx = Noice * Rnd() / 10
                n.Fy = F * Rnd()
                n.Life = Rains(i).Life
                n.Color = Rains(i).Color

                p.Add(n)
            Next
        Next

        For i As Integer = 0 To Sprays.Count - 1
            If FrameIndex < Sprays(i).startGen Or FrameIndex > Sprays(i).stopGen Then Continue For

            Dim F As Integer
            Dim Noice As Integer
            Dim R As Integer
            Dim PPF As Integer

            If Sprays(i).wF0 Is Nothing Then F = Sprays(i).F0 Else F = Sprays(i).wF0.Waveform(FrameIndex)
            If Sprays(i).wNoice Is Nothing Then Noice = Sprays(i).Noice Else Noice = Sprays(i).wNoice.Waveform(FrameIndex)
            If Sprays(i).wR Is Nothing Then R = Sprays(i).R Else R = Sprays(i).wR.Waveform(FrameIndex)
            If Sprays(i).wPPF Is Nothing Then PPF = Sprays(i).ppf Else PPF = Sprays(i).wPPF.Waveform(FrameIndex)

            If F < MinF Then F = MinF Else If F > MaxF Then F = MaxF
            If Noice < MinNoice Then Noice = MinNoice Else If Noice > MaxNoice Then Noice = MaxNoice
            If R < MinR Then R = MinR Else If R > MaxR Then R = MaxR
            If PPF < MinPPF Then PPF = MinPPF Else If PPF > MaxPPF Then PPF = MaxPPF

            For c As Integer = 1 To PPF
                Dim n As New Particle
                n.R = R
                n.x = Sprays(i).x
                n.y = Sprays(i).y
                n.x0 = n.x
                n.y0 = n.y
                n.Fx = Math.Cos((Sprays(i).Slope - (Sprays(i).Noice / 2) + Noice * Rnd()) / 57.29577951) * F
                n.Fy = Math.Sin((Sprays(i).Slope - (Sprays(i).Noice / 2) + Noice * Rnd()) / 57.29577951) * F
                n.Life = Sprays(i).Life
                n.Color = Sprays(i).Color

                p.Add(n)
            Next
        Next

        For i As Integer = 0 To Randoms.Count - 1
            If FrameIndex < Randoms(i).startGen Or FrameIndex > Randoms(i).stopGen Then Continue For

            For j As Integer = 1 To Randoms(i).ppf
                Dim n As New Particle
                n.R = Randoms(i).R
                n.x = Randoms(i).x + Randoms(i).Widht * Rnd()
                n.y = Randoms(i).y + Randoms(i).Height * Rnd()
                n.x0 = n.x
                n.y0 = n.y
                n.Fx = 0
                n.Fy = 0
                n.Life = Randoms(i).Life
                n.Color = Randoms(i).Color

                p.Add(n)
            Next

        Next

        For i As Integer = 0 To Bitmaps.Count - 1
            If Bitmaps(i).startGen = FrameIndex Then

                Dim BitmapFile As New Bitmap(Bitmaps(i).BitmapPath)

                For x As Integer = 0 To Bitmaps(i).Widht - Bitmaps(i).R Step Bitmaps(i).R
                    For y As Integer = 0 To Bitmaps(i).Height - Bitmaps(i).R Step Bitmaps(i).R

                        Dim c As Color = BitmapFile.GetPixel(x * BitmapFile.Width \ Bitmaps(i).Widht, y * BitmapFile.Height \ Bitmaps(i).Height)

                        If c.A > 32 Then
                            Dim n As New Particle
                            n.R = Bitmaps(i).R
                            n.x = Bitmaps(i).x + x
                            n.y = Bitmaps(i).y + y
                            n.x0 = n.x
                            n.y0 = n.y
                            n.Fx = 0
                            n.Fy = 0
                            n.Life = Bitmaps(i).Life
                            n.Color = c

                            p.Add(n)
                        End If

                    Next
                Next

                BitmapFile.Dispose()

            End If
        Next

    End Sub

    Sub ExpiryParticles(ByRef p As List(Of Particle))
        If Not Expirys.Count = 0 Then

            Dim minExpiry As Integer = Expirys(0).y
            For e As Integer = 1 To Expirys.Count - 1
                If Expirys(e).y < minExpiry Then minExpiry = Expirys(e).y
            Next

            Dim j As Integer = 0
            While (j < p.Count)
                If (p(j).y > minExpiry) Then
                    p.RemoveAt(j)
                Else
                    j += 1
                End If
            End While

        End If

        Dim i As Integer = 0
        While (i < p.Count)
            If (p(i).Life < 0) Or RedAt(New Point(p(i).x, p(i).y)) Then
                p.RemoveAt(i)
            Else
                i += 1
            End If
        End While

    End Sub


    Public Sub Reactor0_2(ByRef p As List(Of Particle))
        For i As Integer = 0 To p.Count - 1
            Dim n As New Particle
            n.x = p(i).x + p(i).Fx
            n.y = p(i).y + p(i).Fy
            n.x0 = p(i).x
            n.y0 = p(i).y
            n.Fx = p(i).Fx + ForceXAt(New Point(p(i).x, p(i).y))
            n.Fy = p(i).Fy + ForceYAt(New Point(p(i).x, p(i).y)) + _G
            n.R = p(i).R
            n.Life = p(i).Life - 1
            n.Color = p(i).Color
            p(i) = n
        Next
    End Sub

    Public Sub Reactor1_0(ByRef p As List(Of Particle))

        Using Holded As New Bitmap(WORKPLACE.Width, WORKPLACE.Height, Imaging.PixelFormat.Format32bppArgb), Gr As Graphics = Graphics.FromImage(Holded)
            If StaticMap IsNot Nothing Then Gr.DrawImage(StaticMap, 0, 0, StaticMap.Width, StaticMap.Height)

            For i As Integer = 0 To p.Count - 1

                Dim Fx As Integer = p(i).Fx
                Dim Fy As Integer = p(i).Fy

                If StaticMap IsNot Nothing Then

                    Dim px, py As Integer
                    px = p(i).x + Fx
                    py = p(i).y + Fy

                    If (px > -1) And (px < Holded.Width) And _
                       (py > -1) And (py < Holded.Height) Then
                        Do Until (Holded.GetPixel(px, py).A < 64) Or (Fx < 1 And Fy < 1)
                            Fx /= 2
                            Fy /= 2
                        Loop
                    End If

                    If Math.Sqrt(Fy ^ 2 + Fy ^ 2) < 2 Then
                        For xo As Integer = 1 To p(i).R
                            For yo As Integer = 0 To p(i).R \ 2

                                If (p(i).x + Fx + xo < Holded.Width) And (p(i).x + Fx - xo > -1) And _
                                   (p(i).y + Fy + yo < Holded.Height) And (p(i).y + Fy - yo > -1) Then

                                    If (Holded.GetPixel(p(i).x + Fx + xo, p(i).y + Fy + yo).A > 128) And (Holded.GetPixel(p(i).x + Fx - xo, p(i).y + Fy + yo).A < 128) Then
                                        Fx -= 4
                                        GoTo Done
                                    End If
                                    If (Holded.GetPixel(p(i).x + Fx + xo, p(i).y + Fy + yo).A < 128) And (Holded.GetPixel(p(i).x + Fx - xo, p(i).y + Fy + yo).A > 128) Then
                                        Fx += 4
                                        GoTo Done
                                    End If

                                End If

                            Next
                        Next
Done:
                    End If

                End If

                Dim n As New Particle
                n.x = p(i).x + Fx
                n.y = p(i).y + Fy
                n.x0 = p(i).x
                n.y0 = p(i).y
                n.Fx = Fx + ForceXAt(New Point(p(i).x, p(i).y))
                n.Fy = Fy + ForceYAt(New Point(p(i).x, p(i).y)) + _G
                n.R = p(i).R
                n.Life = p(i).Life - 1
                n.Color = p(i).Color
                p(i) = n

                If _ParticlesReactEachOther Then Gr.FillEllipse(New SolidBrush(Color.FromArgb(64, 0, 0, 255)), CType(p(i).x - p(i).R, Integer), CType(p(i).y, Integer), p(i).R * 2, p(i).R * 2)

            Next

        End Using

    End Sub

    Public Sub SpaceReactor1_0(ByRef p As List(Of Particle))
        For i As Integer = 0 To p.Count - 1

            Dim n As New Particle
            n.x = p(i).x + p(i).Fx
            n.y = p(i).y + p(i).Fy
            n.x0 = p(i).x
            n.y0 = p(i).y
            n.R = p(i).R
            n.Life = p(i).Life - 1
            n.Color = p(i).Color

            Dim Fx As Double = p(i).Fx
            Dim Fy As Double = p(i).Fy

            For j As Integer = 0 To p.Count - 1

                Dim FxD As Double = (p(j).x - p(i).x)
                If FxD <> 0 Then
                    Fx += p(i).R * p(j).R / FxD '^ 2 '*C
                End If

                Dim FyD As Double = (p(j).y - p(i).y)
                If FyD <> 0 Then
                    Fy += p(i).R * p(j).R / FyD '^ 2 '*C
                End If

            Next

            n.Fx = Fx
            n.Fy = Fy

            p(i) = n
        Next
    End Sub


    Public Function Renderer(ByVal ParticlesList As List(Of Particle), _
                             ByVal Cam As Camera, _
                             ByVal pxlFormat As Imaging.PixelFormat, _
                             ByVal imgSmoothing As Drawing2D.SmoothingMode) As Image

        Using newFrame As Bitmap = New Bitmap(Cam.Widht, Cam.Height, pxlFormat), Gr As Graphics = Graphics.FromImage(newFrame)
            Gr.SmoothingMode = imgSmoothing

            If _BGTransparent Then
                Gr.Clear(Color.Transparent)

            ElseIf _BGSolid Then
                Gr.Clear(_BGColor)

            ElseIf _BGFile Then
                Gr.Clear(Color.White)
                Gr.DrawImage(Image.FromFile(_BGFilePath), 0, 0, Cam.Widht, Cam.Height)
            End If

            If _DrawStatic Then If Engine.StaticMap IsNot Nothing Then Gr.DrawImage(Engine.StaticMap, 0, 0, StaticMap.Width, StaticMap.Height)

            For Each p As Engine.Particle In ParticlesList

                Dim r As New Rectangle(p.x - p.R - Cam.x, p.y - p.R - Cam.y, p.R * 2, p.R * 2)

                Dim pColor As Color
                If _GlobalColor Then
                    pColor = Color.FromArgb(_GlobalColorOpacity * 2.55, _GlobalColorValue)
                Else
                    pColor = Color.FromArgb(_GlobalColorOpacity * 2.55, p.Color)
                End If

                Dim Reflection As New Bitmap(p.R * 2, p.R * 2, Imaging.PixelFormat.Format32bppArgb)

                If _ParticlesSolidColor Then 'solid
                    Gr.FillEllipse(New SolidBrush(pColor), r)

                ElseIf _ParticleReflect Then 'reflect
                    For x As Integer = -p.R + 1 To p.R - 1
                        For y As Integer = -p.R + 1 To p.R - 1

                            Dim Smooth As Decimal = p.R - Math.Sqrt(x ^ 2 + y ^ 2)

                            If Smooth > 0 Then
                                If Smooth > 1 Then Smooth = 1

                                Dim px As Integer = p.x + x + Math.Tan((x * 85 / p.R) / 180 * Math.PI) * p.R '^ 3
                                Dim py As Integer = p.y + y + Math.Tan((y * 85 / p.R) / 180 * Math.PI) * p.R '^ 3

                                If px > -1 And px < newFrame.Width And _
                                   py > -1 And py < newFrame.Height Then
                                    Dim pix As Color = newFrame.GetPixel(px, py)
                                    Reflection.SetPixel(x + p.R, y + p.R, Color.FromArgb(_ParticleReflectOpacity * 2.55 * Smooth, pix.R / 255 * pColor.R, pix.G / 255 * pColor.G, pix.B / 255 * pColor.B))
                                Else
ExitColor:                          Reflection.SetPixel(x + p.R, y + p.R, Color.FromArgb(_ParticleReflectOpacity * 2.55 * Smooth, _ParticleExitColor))
                                End If
                            End If

                        Next
                    Next

                ElseIf _ParticleRefract Then 'refract

                End If

                'motion blur
                If _MotionBlur Then
                    For b As Integer = 1 To _MotionBlurSamples
                        Gr.FillEllipse(New SolidBrush(Color.FromArgb((b / _MotionBlurSamples) * 32 * p.Color.A \ 255, pColor)), CType((p.x0 * ((_MotionBlurSamples - b) / _MotionBlurSamples) + p.x * (b / _MotionBlurSamples) - p.R), Integer) - Cam.x, CType((p.y0 * ((_MotionBlurSamples - b) / _MotionBlurSamples) + p.y * (b / _MotionBlurSamples) - p.R), Integer) - Cam.y, p.R * 2, p.R * 2)
                    Next
                End If

                'glow
                If _Glow Then
                    Dim gPath As New Drawing2D.GraphicsPath
                    gPath.AddEllipse(r)
                    gPath.AddEllipse(r.X - 5, r.Y - 5, r.Width + 10, r.Height + 10)
                    Dim B As Drawing2D.PathGradientBrush = New Drawing2D.PathGradientBrush(gPath)
                    B.SurroundColors = New Color() {Color.Transparent}
                    B.CenterColor = Color.FromArgb(_GlowOpacity * 2.55, _GlowColor)
                    Gr.FillPath(B, gPath)
                End If

                Gr.DrawImage(Reflection, r)
                Reflection.Dispose()

                If _SpecHighlights Then If GlossinessMap IsNot Nothing Then Gr.DrawImage(GlossinessMap, r)

            Next

            If _DrawGens Then

                Using mx As New Drawing2D.Matrix(1, 0, 0, 1, 0, 0)
                    For Each G As Engine.PointGen In Engine.Points
                        DrawPoint(Gr, mx, G.x - Cam.x, G.y - Cam.y, G.Noice)
                    Next
                    For Each G As Engine.RainGen In Engine.Rains
                        DrawRain(Gr, mx, G.x - Cam.x, G.y - Cam.y, G.Widht)
                    Next
                    For Each G As Engine.SprayGen In Engine.Sprays
                        DrawSpary(Gr, mx, G.x - Cam.x, G.y - Cam.y, G.Slope, G.Noice)
                    Next
                    For Each G As Engine.RandomGen In Engine.Randoms
                        DrawBitmap(Gr, mx, G.x - Cam.x, G.y - Cam.y, G.Widht, G.Height)
                    Next
                    For Each G As Engine.BitmapGen In Engine.Bitmaps
                        DrawBitmap(Gr, mx, G.x - Cam.x, G.y - Cam.y, G.Widht, G.Height)
                    Next
                End Using
            End If

            Return newFrame.Clone

        End Using
    End Function

    Public Function QuickRender(ByVal ParticlesList As List(Of Particle), ByVal Cam As Camera, ByVal Zoom As Decimal, ByVal OffSet As Point) As Image
        Using newFrame As Bitmap = New Bitmap(Cam.Widht, Cam.Height, Imaging.PixelFormat.Format24bppRgb), Gr As Graphics = Graphics.FromImage(newFrame)
            Gr.Clear(Color.Gray)

            For i As Integer = 0 To ParticlesList.Count - 1
                Gr.FillEllipse(New SolidBrush(Color.FromArgb(128, ParticlesList(i).Color)), CType((ParticlesList(i).x - ParticlesList(i).R) / Zoom, Integer) + OffSet.X, CType((ParticlesList(i).y - ParticlesList(i).R) / Zoom, Integer) + OffSet.Y, CType((ParticlesList(i).R * 2) / Zoom, Integer), CType((ParticlesList(i).R * 2) / Zoom, Integer))
                'Gr.DrawLine(Pens.Blue, CType((ParticlesList(i).x) / Zoom, Integer) + OffSet.X, CType((ParticlesList(i).y) / Zoom, Integer) + OffSet.Y, CType((ParticlesList(i).x0) / Zoom, Integer) + OffSet.X, CType((ParticlesList(i).y0) / Zoom, Integer) + OffSet.Y)
            Next

            Return newFrame.Clone
        End Using
    End Function

    Public Sub DrawPoint(ByVal G As Graphics, ByVal mx As Drawing2D.Matrix, ByVal x As Integer, ByVal y As Integer, ByVal Noice As Byte)
        G.Transform = mx
        G.DrawLine(New Pen(Color.Blue, 2), x - 3, y, x + 3, y)
        G.DrawLine(New Pen(Color.Blue, 2), x, y - 3, x, y + 3)
        G.FillEllipse(New SolidBrush(Color.FromArgb(24, 0, 0, 255)), x - Noice, y - Noice, Noice * 2, Noice * 2)
    End Sub
    Public Sub DrawRain(ByVal G As Graphics, ByVal mx As Drawing2D.Matrix, ByVal x As Integer, ByVal y As Integer, ByVal Width As Integer)
        G.Transform = mx
        G.FillRectangle(Brushes.Blue, x, y, Width, 2)
        G.FillRectangle(Brushes.Blue, x, y + 2, 2, 3)
        G.FillRectangle(Brushes.Blue, x + Width - 2, y + 2, 2, 3)
    End Sub
    Public Sub DrawSpary(ByVal G As Graphics, ByVal mx As Drawing2D.Matrix, ByVal x As Integer, ByVal y As Integer, ByVal Slope As Integer, ByVal Noice As Byte)
        G.Transform = mx
        Dim n As Integer = Noice
        If n < 30 Then n = 30
        G.DrawLine(New Pen(Color.FromArgb(0, 0, 255), 2), x - 3, y, x + 3, y)
        G.DrawLine(New Pen(Color.FromArgb(0, 0, 255), 2), x, y - 3, x, y + 3)
        G.FillPie(New SolidBrush(Color.FromArgb(24, 0, 0, 255)), x - 32, y - 32, 64, 64, Slope - n \ 2, n)
    End Sub
    Public Sub DrawExpiry(ByVal G As Graphics, ByVal mx As Drawing2D.Matrix, ByVal y As Integer, ByVal Width As Integer)
        G.Transform = mx
        Dim p As New Pen(New SolidBrush(Color.Red), 2)
        p.DashStyle = Drawing2D.DashStyle.Dot
        G.DrawLine(p, -mx.OffsetX, y, Width - mx.OffsetX, y)
    End Sub
    Public Sub DrawBitmap(ByVal G As Graphics, ByVal mx As Drawing2D.Matrix, ByVal x As Integer, ByVal y As Integer, ByVal Widht As Integer, ByVal Height As Integer)
        G.Transform = mx
        G.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(0, 0, 255)), 2), x, y, Widht, Height)
    End Sub
    Public Sub DrawCam(ByVal G As Graphics, ByVal mx As Drawing2D.Matrix, ByVal x As Integer, ByVal y As Integer, ByVal Widht As Integer, ByVal Height As Integer)
        G.Transform = mx
        Dim p As New Pen(New SolidBrush(Color.FromArgb(255, 255, 0)), 2)
        p.DashStyle = Drawing2D.DashStyle.Dash
        G.DrawRectangle(p, x, y, Widht, Height)
    End Sub
    Public Sub DrawWind(ByVal G As Graphics, ByVal mx As Drawing2D.Matrix, ByVal x As Integer, ByVal y As Integer, ByVal Widht As Integer, ByVal Height As Integer)
        G.Transform = mx
        Dim p As New Pen(New SolidBrush(Color.FromArgb(0, 255, 255)), 2)
        p.DashStyle = Drawing2D.DashStyle.Dot

        G.DrawRectangle(p, x, y, Widht, Height)

        For i As Integer = 1 To 3
            G.DrawCurve(p, _
                        {New Point(x + Widht \ 6, y + i * Height \ 4), _
                         New Point(x + 2 * Widht \ 6, y + i * Height \ 4 - Height \ 12), _
                         New Point(x + Widht \ 2, y + i * Height \ 4), _
                         New Point(x + 4 * Widht \ 6, y + i * Height \ 4 - Height \ 12), _
                         New Point(x + 5 * Widht \ 6, y + i * Height \ 4)}, _
                         0.6)
        Next

    End Sub
    Public Sub DrawExpant(ByVal G As Graphics, ByVal mx As Drawing2D.Matrix, ByVal x As Integer, ByVal y As Integer, ByVal R As Integer)
        G.Transform = mx
        Dim p As New Pen(New SolidBrush(Color.FromArgb(0, 255, 255)), 2)
        p.DashStyle = Drawing2D.DashStyle.Dot

        G.DrawEllipse(p, x, y, R * 2, R * 2)

        G.DrawLine(p, x + R - R \ 8, y + R - R \ 8, x + R - R \ 2, y + R - R \ 2)
        G.DrawLine(p, x + R - R \ 8, y + R + R \ 8, x + R - R \ 2, y + R + R \ 2)
        G.DrawLine(p, x + R + R \ 8, y + R - R \ 8, x + R + R \ 2, y + R - R \ 2)
        G.DrawLine(p, x + R + R \ 8, y + R + R \ 8, x + R + R \ 2, y + R + R \ 2)

        G.DrawLine(p, x + R - R \ 2, y + R - R \ 5, x + R - R \ 2, y + R - R \ 2)
        G.DrawLine(p, x + R - R \ 5, y + R - R \ 2, x + R - R \ 2, y + R - R \ 2)

        G.DrawLine(p, x + R - R \ 2, y + R + R \ 5, x + R - R \ 2, y + R + R \ 2)
        G.DrawLine(p, x + R - R \ 5, y + R + R \ 2, x + R - R \ 2, y + R + R \ 2)

        G.DrawLine(p, x + R + R \ 2, y + R - R \ 5, x + R + R \ 2, y + R - R \ 2)
        G.DrawLine(p, x + R + R \ 5, y + R - R \ 2, x + R + R \ 2, y + R - R \ 2)

        G.DrawLine(p, x + R + R \ 2, y + R + R \ 5, x + R + R \ 2, y + R + R \ 2)
        G.DrawLine(p, x + R + R \ 5, y + R + R \ 2, x + R + R \ 2, y + R + R \ 2)
    End Sub
    Public Sub DrawBlackHole(ByVal G As Graphics, ByVal mx As Drawing2D.Matrix, ByVal x As Integer, ByVal y As Integer, ByVal R As Integer)
        G.Transform = mx
        Dim p As New Pen(New SolidBrush(Color.FromArgb(0, 255, 255)), 2)
        p.DashStyle = Drawing2D.DashStyle.Dot

        G.DrawEllipse(p, x, y, R * 2, R * 2)

        G.DrawLine(p, x + R - R \ 8, y + R - R \ 8, x + R - R \ 2, y + R - R \ 2)
        G.DrawLine(p, x + R - R \ 8, y + R + R \ 8, x + R - R \ 2, y + R + R \ 2)
        G.DrawLine(p, x + R + R \ 8, y + R - R \ 8, x + R + R \ 2, y + R - R \ 2)
        G.DrawLine(p, x + R + R \ 8, y + R + R \ 8, x + R + R \ 2, y + R + R \ 2)

        G.DrawLine(p, x + R - R \ 2, y + R - R \ 5, x + R - R \ 8, y + R - R \ 8)
        G.DrawLine(p, x + R - R \ 5, y + R - R \ 2, x + R - R \ 8, y + R - R \ 8)

        G.DrawLine(p, x + R - R \ 2, y + R + R \ 5, x + R - R \ 8, y + R + R \ 8)
        G.DrawLine(p, x + R - R \ 5, y + R + R \ 2, x + R - R \ 8, y + R + R \ 8)

        G.DrawLine(p, x + R + R \ 2, y + R - R \ 5, x + R + R \ 8, y + R - R \ 8)
        G.DrawLine(p, x + R + R \ 5, y + R - R \ 2, x + R + R \ 8, y + R - R \ 8)

        G.DrawLine(p, x + R + R \ 2, y + R + R \ 5, x + R + R \ 8, y + R + R \ 8)
        G.DrawLine(p, x + R + R \ 5, y + R + R \ 2, x + R + R \ 8, y + R + R \ 8)

        p.Brush = Brushes.Red
        G.DrawEllipse(p, x + R - R \ 16, y + R - R \ 16, R \ 8, R \ 8)
    End Sub
    Public Sub DrawFan(ByVal G As Graphics, ByVal mx As Drawing2D.Matrix, ByVal x As Integer, ByVal y As Integer, ByVal R As Integer)
        G.Transform = mx
        Dim p As New Pen(New SolidBrush(Color.FromArgb(0, 255, 255)), 2)
        p.DashStyle = Drawing2D.DashStyle.Dot

        G.DrawEllipse(p, x, y, R * 2, R * 2)

        For i As Short = 0 To 240 Step 120
            G.DrawPolygon(p, {New Point(x + R, y + R), _
                              New Point(x + R + Math.Sin(i \ 180 / Math.PI) * (R * 9 / 10), y + R + Math.Cos(i \ 180 / Math.PI) * (R * 9 / 10)), _
                              New Point(x + R + Math.Sin((i + 60) \ 180 / Math.PI) * (R * 9 / 10), y + R + Math.Cos((i + 60) \ 180 / Math.PI) * (R * 9 / 10))})
        Next
    End Sub
    Public Sub DrawWhirlpool(ByVal G As Graphics, ByVal mx As Drawing2D.Matrix, ByVal x As Integer, ByVal y As Integer, ByVal R As Integer)
        G.Transform = mx
        Dim p As New Pen(New SolidBrush(Color.FromArgb(0, 255, 255)), 2)
        p.DashStyle = Drawing2D.DashStyle.Dot

        G.DrawEllipse(p, x, y, R * 2, R * 2)

        For i As Short = 0 To 359 Step 60
            G.DrawCurve(p, {New Point(x + R + Math.Sin(i / ANGLECONVERT) * (R / 10), y + R + Math.Cos(i / ANGLECONVERT) * (R / 10)), _
                            New Point(x + R + Math.Sin((i + 30) / ANGLECONVERT) * (R / 2), y + R + Math.Cos((i + 30) / ANGLECONVERT) * (R / 2)), _
                            New Point(x + R + Math.Sin((i + 60) / ANGLECONVERT) * (R * 9 / 10), y + R + Math.Cos((i + 60) / ANGLECONVERT) * (R * 9 / 10))}, _
                            0.8)
        Next

        p.Brush = Brushes.Red
        G.DrawEllipse(p, x + R - R \ 16, y + R - R \ 16, R \ 8, R \ 8)
    End Sub

End Module