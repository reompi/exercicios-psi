Public Class clsSegment

    Private rectLoc As Rectangle

    Public ReadOnly Property Rect() As Rectangle

        Get

            Return rectLoc

        End Get

    End Property

    Public Property Loc() As Point

        Get

            Return rectLoc.Location

        End Get

        Set(ByVal Value As Point)

            rectLoc.Location = Value

        End Set

    End Property

    Public ReadOnly Property Size() As Size

        Get

            Return rectLoc.Size

        End Get

    End Property

    Public Sub New(ByVal pntLoc As Point, ByVal intWidth As Integer)

        rectLoc = New Rectangle(pntLoc, New Size(intWidth, intWidth))

    End Sub

    Public Function CloneSegment() As clsSegment

        Return New clsSegment(rectLoc.Location, rectLoc.Width)

    End Function

    Public Overrides Function ToString() As String

        Return Me.GetType.ToString + ": " + rectLoc.Location.ToString

    End Function

End Class
Public Class clsMovement

    Private pntLocation As Point
    Private intStep As Integer
    Private iDirection As intDirection

    Public ReadOnly Property Location() As Point

        Get

            Return pntLocation

        End Get

    End Property

    Public Property Direction() As intDirection

        Get

            Return iDirection

        End Get

        Set(ByVal Value As intDirection)

            iDirection = Value

        End Set

    End Property


    Public ReadOnly Property Increment() As Integer

        Get

            Return intStep

        End Get

    End Property

    Public Enum intDirection As Integer

        None = -1
        Left
        Down
        Right
        Up

    End Enum



    Public Sub New()

        intStep = 8

        pntLocation = New Point(0, 0)

        Direction = intDirection.Right

    End Sub

    Public Sub New(ByVal iStep As Integer, ByVal pStart As Point, ByVal dirNew As intDirection)

        iDirection = dirNew

        intStep = iStep

        pntLocation = pStart

    End Sub

    Public Function NextLoc(Optional ByVal dirNext As intDirection = intDirection.None) As Point

        Dim pntLoc As New Point(pntLocation.X, pntLocation.Y)

        If (dirNext = intDirection.None) Then dirNext = iDirection

        Select Case dirNext

            Case intDirection.Left

                pntLoc.X -= intStep

                Exit Select

            Case intDirection.Down

                pntLoc.Y += intStep

                Exit Select

            Case intDirection.Right

                pntLoc.X += intStep

                Exit Select

            Case intDirection.Up

                pntLoc.Y -= intStep

                Exit Select

        End Select

        Return pntLoc

    End Function

    Public Sub Move(Optional ByVal dirMove As intDirection = intDirection.None)

        If (dirMove = intDirection.None) Then dirMove = iDirection

        Select Case dirMove

            Case intDirection.Left

                pntLocation.X -= intStep

                Exit Select

            Case intDirection.Down

                pntLocation.Y += intStep

                Exit Select

            Case intDirection.Right

                pntLocation.X += intStep

                Exit Select

            Case intDirection.Up

                pntLocation.Y -= intStep

                Exit Select

        End Select

    End Sub

    Public Sub Move(ByVal rectBounds As Rectangle, Optional ByVal dirMove As intDirection = intDirection.None)

        Move(dirMove)

        If (pntLocation.X > rectBounds.Right) Then

            pntLocation.X = CInt(rectBounds.Left / intStep) * intStep

        ElseIf (pntLocation.X < rectBounds.Left) Then

            pntLocation.X = CInt(rectBounds.Right / intStep) * intStep

        ElseIf (pntLocation.Y > rectBounds.Bottom) Then

            pntLocation.Y = CInt(rectBounds.Top / intStep) * intStep

        ElseIf (pntLocation.Y < rectBounds.Top) Then

            pntLocation.Y = CInt(rectBounds.Bottom / intStep) * intStep

        End If

    End Sub

End Class
Public Class clsSnake

    Private Const intMaxLength As Integer = 1024
    Private Const intDefaultLength As Integer = 4
    Private Const intDefaultWidth As Integer = 8

    Private qSegments As Queue
    Private intWidth As Integer

    Public Property NumberOfSegments() As clsSegment()

        Get

            Dim cSegments(qSegments.Count - 1) As clsSegment

            qSegments.CopyTo(cSegments, 0)

            Return cSegments

        End Get

        Set(value As clsSegment())

        End Set

    End Property

    Public Property Head() As clsSegment

        Get

            Return DirectCast(qSegments.Peek, clsSegment).CloneSegment

        End Get

        Set(value As clsSegment)

        End Set

    End Property

    Private Sub InitializeSnake(ByVal pntLoc As Point, ByVal iWidth As Integer, ByVal iLength As Integer)

        intWidth = iWidth

        Dim pLoc As Point = pntLoc

        Dim i As Integer

        For i = 1 To iLength

            Eat(pLoc)

            pLoc.X -= intWidth

        Next

    End Sub

    Public Sub New()

        MyBase.New()

        InitializeSnake(New Point(intDefaultLength * intDefaultWidth, 0), intDefaultWidth, intDefaultLength)

    End Sub

    Public Sub New(ByVal pntStart As Point, ByVal iWidth As Integer, ByVal iLength As Integer)

        MyBase.New()

        InitializeSnake(pntStart, iWidth, iLength)

    End Sub

    Public Sub Eat(ByVal pntLoc As Point)

        Dim cHead As New clsSegment(pntLoc, intWidth)

        If (qSegments Is Nothing) Then

            qSegments = New Queue(intMaxLength)

        ElseIf (qSegments.Count = intMaxLength) Then

            Move(pntLoc)

            Exit Sub

        End If

        qSegments.Enqueue(cHead)

    End Sub

    Public Sub Clear()

        qSegments.Clear()

    End Sub

    Public Sub Move(ByVal pntLoc As Point)

        Dim cHead As New clsSegment(pntLoc, intWidth)

        qSegments.Enqueue(cHead)

        qSegments.Dequeue()

    End Sub


    Public Function FoodPlacedOnSnake(ByVal pntLoc As Point) As Boolean

        Dim ieSegments As IEnumerator = qSegments.GetEnumerator

        While ieSegments.MoveNext

            If DirectCast(ieSegments.Current, clsSegment).Rect.Contains(pntLoc) Then Return True

        End While

    End Function

End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSnake
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.picGame = New System.Windows.Forms.PictureBox()
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrGame
        '
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.BackColor = System.Drawing.Color.MediumPurple
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(38, 176)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(433, 56)
        Me.lblMessage.TabIndex = 8
        Me.lblMessage.Text = "Press Enter to Start"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picGame
        '
        Me.picGame.BackColor = System.Drawing.Color.MediumPurple
        Me.picGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picGame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picGame.Location = New System.Drawing.Point(0, 0)
        Me.picGame.Name = "picGame"
        Me.picGame.Size = New System.Drawing.Size(517, 416)
        Me.picGame.TabIndex = 7
        Me.picGame.TabStop = False
        '
        'frmSnake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 416)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picGame)
        Me.Name = "frmSnake"
        Me.Text = "HTG_Snake"
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents picGame As System.Windows.Forms.PictureBox

End Class
Public Class frmSnake


    Private Const intGrow As Integer = 3
    Private Const intWidth As Integer = 8

    Private cSnake As clsSnake
    Private cMovement As clsMovement

    Private blnMoving As Boolean = False
    Private blnExpanding As Boolean = False

    Private rectFood As Rectangle

    Private intScore As Integer

    Public Sub Feed()

        Dim pntFood As Point

        Do

            pntFood = Randomize()

            If Not (cSnake Is Nothing) Then

                If Not cSnake.FoodPlacedOnSnake(pntFood) Then Exit Do

            Else

                Exit Do

            End If

        Loop

        rectFood.Location = pntFood

    End Sub

    Private Sub Die()

        DisplayMessage("Press Enter to play or Escape to quit.")

        Initialize()

    End Sub


    Private Sub Initialize()

        intScore = 0

        rectFood = New Rectangle(0, 0, intWidth, intWidth)

        Feed()

        Dim pntStart As New Point(CInt(picGame.ClientSize.Width / 2 / intWidth + 0.5) * intWidth, CInt(picGame.ClientSize.Height / 2 / intWidth + 0.5) * intWidth)

        cSnake = New clsSnake(pntStart, intWidth, 1)

        cMovement = New clsMovement(intWidth, cSnake.Head.Loc, clsMovement.intDirection.Right)

        blnExpanding = True

    End Sub

    Private Sub UpdateUI()

        Static iGrow As Integer = intGrow

        Static intAddSeg As Integer

        If Not blnMoving Then Exit Sub

        cMovement.Move(picGame.ClientRectangle)


        If cSnake.FoodPlacedOnSnake(cMovement.Location) Then

            iGrow = 0
            intAddSeg = 0

            Die()

            Return


        ElseIf rectFood.Contains(cMovement.Location) Then

            iGrow += intGrow

            blnExpanding = True

            Feed()

            intScore += 5

            Text = "Score: " + intScore.ToString

        End If

        If blnExpanding Then

            If iGrow < intGrow Then iGrow = intGrow

            If intAddSeg >= iGrow Then

                blnExpanding = False

                intAddSeg = 0
                iGrow = 0

                cSnake.Move(cMovement.Location)

            Else

                cSnake.Eat(cMovement.Location)

                intAddSeg += 1

            End If

        Else

            cSnake.Move(cMovement.Location)

        End If

    End Sub

    Private Sub DisplayMessage(ByVal strMsg As String)

        lblMessage.Text = strMsg
        lblMessage.Visible = True
        blnMoving = False

        tmrGame.Enabled = False

    End Sub

    Public Function Randomize() As Point

        Dim rnd As New Random(Now.Second)

        Dim intScreenWidth As Integer = ((ClientRectangle.Width \ intWidth) - 2) * intWidth
        Dim intScreenHeight As Integer = ((ClientRectangle.Height \ intWidth) - 2) * intWidth

        Dim intX As Integer = rnd.Next(0, intScreenWidth)
        Dim intY As Integer = rnd.Next(0, intScreenHeight)

        intX = (intX \ intWidth) * intWidth
        intY = (intY \ intWidth) * intWidth

        Return New Point(intX, intY)

    End Function

    Private Sub HideMessage()

        Me.Text = "Score: " + intScore.ToString

        lblMessage.Visible = False
        blnMoving = True
        tmrGame.Enabled = True

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Initialize()

    End Sub

    Private Sub picGame_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picGame.Paint

        If Not blnMoving Then

            e.Graphics.Clear(picGame.BackColor)

            Exit Sub

        End If

        e.Graphics.FillEllipse(Brushes.White, rectFood)

        Dim segCurrent As clsSegment


        For Each segCurrent In cSnake.NumberOfSegments

            e.Graphics.FillRectangle(Brushes.White, segCurrent.Rect)

        Next

    End Sub

    Private Sub tmrGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGame.Tick

        UpdateUI()

        picGame.Invalidate()

    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        Select Case e.KeyCode

            Case Keys.Enter

                HideMessage()

            Case Keys.Escape

                If blnMoving Then

                    DisplayMessage("Press Enter to continue or Escape to quit.")

                Else

                    Me.Close()

                End If

        End Select

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode

            Case Keys.Right

                cMovement.Direction = clsMovement.intDirection.Right

            Case Keys.Down

                cMovement.Direction = clsMovement.intDirection.Down

            Case Keys.Left

                cMovement.Direction = clsMovement.intDirection.Left

            Case Keys.Up

                cMovement.Direction = clsMovement.intDirection.Up

        End Select

    End Sub

End Class