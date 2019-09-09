Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmSnake
    Public u, d, l, r As Boolean
    <Serializable>
    Structure Score_table
        Dim Score As Integer
        Dim Name As String
        Dim Phone As String
    End Structure

    Private Const intGrow As Integer = 3
    Private Const intWidth As Integer = 15

    Private cSnake As clsSnake
    Private cMovement As clsMovement

    Private blnMoving As Boolean = False
    Private blnExpanding As Boolean = False

    Private rectFood As Rectangle

    Private intScore As Integer
    Private Declare Function sndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" _
(ByVal lpszName As String, ByVal dwFlags As Long) As Long
    Const SND_SYNC = &H0

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
        Dim arr(10) As Score_table
        arr(0).Name = "Max" : arr(0).Score = intScore : arr(0).Phone = "test"
        Using fstream As FileStream = File.Create("test.dat")
            Dim bf As New BinaryFormatter
            bf.Serialize(fstream, arr)
        End Using
        frmEndGame.Show()
        tmrGame.Stop()

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

            Text = intScore.ToString
            lblscore.Text = Text


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

        '       Dim intScreenWidth As Integer = ((ClientRectangle.Width \ intWidth) - 2) * intWidth
        '        Dim intScreenHeight As Integer = ((ClientRectangle.Height \ intWidth) - 2) * intWidth
        Dim intScreenWidth As Integer = ((PictureBox1.Width \ intWidth) + 1) * intWidth
        Dim intScreenHeight As Integer = ((PictureBox1.Height \ intWidth) - 1) * intWidth

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
        Timer1.Enabled = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        lblMessage.Visible = False

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r = True
        Initialize()
        Me.FormBorderStyle = FormBorderStyle.None


    End Sub

    Private Sub picGame_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picGame.Paint

        If Not blnMoving Then

            e.Graphics.Clear(picGame.BackColor)

            Exit Sub

        End If

        e.Graphics.FillEllipse(Brushes.DarkOrange, rectFood)

        Dim segCurrent As clsSegment


        For Each segCurrent In cSnake.NumberOfSegments

            e.Graphics.FillRectangle(Brushes.DarkOrange, segCurrent.Rect)

        Next

    End Sub

    Private Sub tmrGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGame.Tick

        UpdateUI()
        picGame.Invalidate()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblscoreText.Click

    End Sub

    Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Visible = False Then
            PictureBox1.Visible = True
            lblMessage.Text = "ЖАМКАЙ СТАРТ"
        Else
            PictureBox1.Visible = False

            lblMessage.Text = ""
        End If

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

                If l = True Then
                    Exit Sub
                Else
                    cMovement.Direction = clsMovement.intDirection.Right
                    r = True
                    u = False
                    d = False
                    l = False
                End If
            Case Keys.Down
                If u = True Then
                    Exit Sub
                Else
                    cMovement.Direction = clsMovement.intDirection.Down
                    d = True
                    u = False
                    r = False
                    l = False
                End If
            Case Keys.Left
                If r = True Then
                    Exit Sub
                Else
                    cMovement.Direction = clsMovement.intDirection.Left
                    l = True
                    r = False
                    d = False
                    u = False
                End If
            Case Keys.Up

                If d = True Then
                    Exit Sub
                Else
                    cMovement.Direction = clsMovement.intDirection.Up
                    u = True
                    r = False
                    d = False
                    l = False
                End If
        End Select


    End Sub

    Private Sub PicGame_Click(sender As Object, e As EventArgs) Handles picGame.Click

    End Sub
End Class
