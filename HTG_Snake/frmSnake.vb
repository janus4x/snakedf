Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmSnake

    Public u, d, l, r, playstartsound As Boolean
    <Serializable>
    Structure Score_table
        Dim Score As Integer
        Dim Name As String
        Dim Phone As String
    End Structure
    Public i As Integer = 239
    Public arr(5) As Score_table 'массив хранения строк с введенными данными
    Public scoremasscounter As Byte = 0 'счетчик для массива введенных ников/телефонов
    Private Const intGrow As Integer = 3
    Private Const intWidth As Integer = 15

    Private cSnake As clsSnake
    Private cMovement As clsMovement

    Private blnMoving As Boolean = False
    Private blnExpanding As Boolean = False

    Private rectFood As Rectangle

    Private intScore As Integer

    Public Sub SpeedUP()
        If tmrGame.Interval > 25 Then
            tmrGame.Interval = tmrGame.Interval - 5
        End If
    End Sub
    Public Sub SpeedDOWN()
        If tmrGame.Interval < 80 Then
            tmrGame.Interval = tmrGame.Interval + 5
        End If
    End Sub

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
        tmrGame.Stop()
        tmrTIME.Stop()
        i = 239
        My.Computer.Audio.Play(Application.StartupPath & "\Sounds\gameover.wav", AudioPlayMode.Background)
        writenickname() 'процедура записи никнейма и телефона
    End Sub
    Private Sub writenickname()


        txtnick.Visible = True
        txtnick.Select()
        lblnick.Visible = True
        txtphone.Visible = True
        lblphone.Visible = True
        txtscoretable.Visible = True
        txtpositionscore.Visible = True



    End Sub
    Private Sub txtnick_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnick.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtphone.Select()

        End If
    End Sub

    Private Sub txtphone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtphone.KeyDown
        '-----------------------------------------------------------------------------------------------------------------------------------
        'сделать проверку валидности ввода данных, только цифры
        '-----------------------------------------------------------------------------------------------------------------------------------
        If e.KeyCode = Keys.Enter Then
            Writescoretable() 'сортировка и вывод таблицы результатов после ввода телефона

        End If
    End Sub
    Private Sub Writescoretable()
        Dim arr2 As Score_table()
        Using fstream As FileStream = File.OpenRead("test.dat")
            Dim bf As New BinaryFormatter
            arr2 = bf.Deserialize(fstream)
        End Using
        Dim player_result(0) As Score_table
        player_result(0).Name = txtnick.Text
        player_result(0).Score = lblscore.Text
        player_result(0).Phone = txtphone.Text
        '----------------------------------------------------------------------------------------------------------------------------------
        'нужно сделать сортировку массива arr(scoremasscounter).Score и выводить из него только 3 верхних максимальных значений
        '----------------------------------------------------------------------------------------------------------------------------------
        Dim x As Integer = 0
        For x = 0 To 4
            If arr2(x).Score < player_result(0).Score Then
                If x = 4 Then
                    arr2(5) = arr2(4)
                    arr2(x).Name = txtnick.Text
                    arr2(x).Score = lblscore.Text
                    arr2(x).Phone = txtphone.Text
                    Using fstream As FileStream = File.Create("test.dat")
                        Dim bf As New BinaryFormatter
                        bf.Serialize(fstream, arr2)
                    End Using
                    x = 5
                End If
                If x = 3 Then
                    arr2(5) = arr2(4)
                    arr2(4) = arr2(3)
                    arr2(x).Name = txtnick.Text
                    arr2(x).Score = lblscore.Text
                    arr2(x).Phone = txtphone.Text
                    Using fstream As FileStream = File.Create("test.dat")
                        Dim bf As New BinaryFormatter
                        bf.Serialize(fstream, arr2)
                    End Using
                    x = 5
                End If
                If x = 2 Then
                    arr2(5) = arr2(4)
                    arr2(4) = arr2(3)
                    arr2(3) = arr2(2)
                    arr2(x).Name = txtnick.Text
                    arr2(x).Score = lblscore.Text
                    arr2(x).Phone = txtphone.Text
                    Using fstream As FileStream = File.Create("test.dat")
                        Dim bf As New BinaryFormatter
                        bf.Serialize(fstream, arr2)
                    End Using
                    x = 5
                End If
                If x = 1 Then
                    arr2(5) = arr2(4)
                    arr2(4) = arr2(3)
                    arr2(3) = arr2(2)
                    arr2(2) = arr2(1)
                    arr2(x).Name = txtnick.Text
                    arr2(x).Score = lblscore.Text
                    arr2(x).Phone = txtphone.Text
                    Using fstream As FileStream = File.Create("test.dat")
                        Dim bf As New BinaryFormatter
                        bf.Serialize(fstream, arr2)
                    End Using
                    x = 5
                End If
                If x = 0 Then
                    arr2(5) = arr2(4)
                    arr2(4) = arr2(3)
                    arr2(3) = arr2(2)
                    arr2(2) = arr2(1)
                    arr2(1) = arr2(0)
                    arr2(0).Name = txtnick.Text
                    arr2(0).Score = lblscore.Text
                    arr2(0).Phone = txtphone.Text
                    x = 5
                    Using fstream As FileStream = File.Create("test.dat")
                        Dim bf As New BinaryFormatter
                        bf.Serialize(fstream, arr2)
                    End Using
                End If
            End If
        Next
        '===================================================================================================================================
        'в файл пишем все введенные пользователями строки
        '===================================================================================================================================

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


            My.Computer.Audio.Play(Application.StartupPath & "\Sounds\eat.wav", AudioPlayMode.Background)
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
        ' PictureBox2.Visible = False
        lblMessage.Visible = False

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtphone.Mask = "###########"
        playstartsound = True
        r = True
        Initialize()
        Dim player_result(5) As Score_table
        Dim x As Integer = 0
        Dim arr2 As Score_table()
        Using fstream As FileStream = File.OpenRead("test.dat")
            Dim bf As New BinaryFormatter
            arr2 = bf.Deserialize(fstream)
        End Using
        lblTopName.Text = arr2(0).Name + "=>" + arr2(0).Score.ToString()
        For x = 0 To 4
            txtpositionscore.Text = txtpositionscore.Text + arr2(x).Name + " " + arr2(x).Score.ToString() + vbNewLine
        Next x
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

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lbltop.Click

    End Sub

    Private Sub tmrTIME_Tick(sender As Object, e As EventArgs) Handles tmrTIME.Tick

        i -= 1
        lblTimeGame.Text = i.ToString
        If i = 0 Then
            Die()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lblphone.Click

    End Sub

    Private Sub txtscoretable_TextChanged(sender As Object, e As EventArgs) Handles txtscoretable.TextChanged

    End Sub

    Private Sub txtnick_TextChanged(sender As Object, e As EventArgs) Handles txtnick.TextChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If playstartsound = True Then
            My.Computer.Audio.Play(Application.StartupPath & "\Sounds\start.wav", AudioPlayMode.Background)
        End If

    End Sub

    Private Sub txtphone_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        Select Case e.KeyCode

            Case Keys.Enter

                HideMessage()
                playstartsound = False
                Timer2.Enabled = False
                tmrTIME.Enabled = True


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
        If e.KeyValue = 107 Then
            SpeedUP()
        End If
        If e.KeyValue = 109 Then
            SpeedDOWN()
        End If

    End Sub

    Private Sub lblscore_Click(sender As Object, e As EventArgs) Handles lblscore.Click

    End Sub

    Private Sub PicGame_Click(sender As Object, e As EventArgs) Handles picGame.Click

    End Sub


End Class
