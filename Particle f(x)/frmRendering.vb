Public Class frmRendering

    Dim FramesList As New List(Of List(Of Particle))

    Dim thrReact As Threading.Thread = New Threading.Thread(AddressOf React)
    Dim thrRender As Threading.Thread = New Threading.Thread(AddressOf Render)

    Dim myTo As Integer = _FrameRangeTo

    Dim ReactCounter As Integer
    Dim RenderCounter As Integer

    Dim filExtension As String

    Private Sub frmRendering_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If thrReact.IsAlive Then thrReact.Abort()
        If thrRender.IsAlive Then thrRender.Abort()
    End Sub

    Public Sub New()
        InitializeComponent()
        Prepare()
    End Sub

    Sub Prepare()

        prgPrepare.Maximum = 5
        prgReact.Maximum = myTo
        prgRender.Maximum = myTo

        lblReactMsg.Text = "0 / " & myTo
        lblRenderMsg.Text = "0 / " & myTo

        Select Case _ImageFormatIndex
            Case 1 : filExtension = ".tiff"
            Case 2 : filExtension = ".bmp"
            Case 3 : filExtension = ".jpeg"
            Case 4 : filExtension = ".gif"
            Case Else : filExtension = ".png"
        End Select

        prgPrepare.Value = 1

        Engine.WavesBalancer()
        Engine.BuildWarp()
        Engine.BuildGlossiness()
        prgPrepare.Value = 3

        thrReact.Priority = Threading.ThreadPriority.Highest
        thrReact.Start()

        thrRender.Priority = Threading.ThreadPriority.Highest
        thrRender.Start()

        prgPrepare.Value = 5
    End Sub

    Sub React()
        Dim temp As New List(Of Particle)

        For ReactCounter = 0 To myTo

            Engine.GenerateParticles(temp, ReactCounter)
            Engine.ExpiryParticles(temp)

            Select Case _ReactorIndex
                Case 0 : Engine.Reactor0_2(temp)
                Case 1 : Engine.Reactor1_0(temp)
                Case 2 : Engine.SpaceReactor1_0(temp)
            End Select

            Dim clone As New List(Of Particle)
            For p As Integer = 0 To temp.Count - 1
                clone.Add(temp(p))
            Next
            FramesList.Add(clone)

            lblReactMsg.Text = ReactCounter & " / " & myTo
            prgReact.Value = ReactCounter
        Next

    End Sub

    Sub Render()
        For RenderCounter = _FrameRangeFrom To myTo

redo:       If ReactCounter > RenderCounter Then
                picRender.BackgroundImage = My.Resources.Play

                Dim File As New IO.FileInfo(_ExportPath & "\" & Count2String(RenderCounter) & filExtension)
                If File.Exists Then
                    If Not _SkipExistingFrames Then Renderer(FramesList(RenderCounter), Engine.Cameras(_CameraIndex), _PixelFormat, _Smoothing).Save(File.FullName, _ImageFormat)
                Else
                    Renderer(FramesList(RenderCounter), Engine.Cameras(_CameraIndex), _PixelFormat, _Smoothing).Save(File.FullName, _ImageFormat)
                End If

            Else
                picRender.BackgroundImage = My.Resources.Pause
                Threading.Thread.Sleep(3000)
                GoTo redo
            End If

            lblRenderMsg.Text = RenderCounter & " / " & myTo
            prgRender.Value = RenderCounter
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub
End Class
