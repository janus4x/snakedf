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
        Me.toppanel = New System.Windows.Forms.Panel()
        Me.lblTimeGame = New System.Windows.Forms.Label()
        Me.lbltimetxt = New System.Windows.Forms.Label()
        Me.lblTopScore = New System.Windows.Forms.Label()
        Me.lblTopName = New System.Windows.Forms.Label()
        Me.lbltop = New System.Windows.Forms.Label()
        Me.lblscoreText = New System.Windows.Forms.Label()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTIME = New System.Windows.Forms.Timer(Me.components)
        Me.txtnick = New System.Windows.Forms.TextBox()
        Me.lblnick = New System.Windows.Forms.Label()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.txtscoretable = New System.Windows.Forms.TextBox()
        Me.txtpositionscore = New System.Windows.Forms.TextBox()
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toppanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrGame
        '
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.BackColor = System.Drawing.Color.Black
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblMessage.Location = New System.Drawing.Point(44, 933)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(684, 56)
        Me.lblMessage.TabIndex = 8
        Me.lblMessage.Text = "Нажми Enter для страта"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picGame
        '
        Me.picGame.BackColor = System.Drawing.Color.Black
        Me.picGame.Location = New System.Drawing.Point(-12, 326)
        Me.picGame.Name = "picGame"
        Me.picGame.Size = New System.Drawing.Size(768, 808)
        Me.picGame.TabIndex = 7
        Me.picGame.TabStop = False
        '
        'toppanel
        '
        Me.toppanel.BackColor = System.Drawing.Color.Black
        Me.toppanel.Controls.Add(Me.lblTimeGame)
        Me.toppanel.Controls.Add(Me.lbltimetxt)
        Me.toppanel.Controls.Add(Me.lblTopScore)
        Me.toppanel.Controls.Add(Me.lblTopName)
        Me.toppanel.Controls.Add(Me.lbltop)
        Me.toppanel.Controls.Add(Me.lblscoreText)
        Me.toppanel.Controls.Add(Me.lblscore)
        Me.toppanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.toppanel.Location = New System.Drawing.Point(0, 0)
        Me.toppanel.Name = "toppanel"
        Me.toppanel.Size = New System.Drawing.Size(768, 46)
        Me.toppanel.TabIndex = 9
        '
        'lblTimeGame
        '
        Me.lblTimeGame.Font = New System.Drawing.Font("a_BosaNova", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTimeGame.ForeColor = System.Drawing.Color.White
        Me.lblTimeGame.Location = New System.Drawing.Point(679, 3)
        Me.lblTimeGame.Name = "lblTimeGame"
        Me.lblTimeGame.Size = New System.Drawing.Size(91, 41)
        Me.lblTimeGame.TabIndex = 15
        Me.lblTimeGame.Text = "239"
        Me.lblTimeGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltimetxt
        '
        Me.lbltimetxt.Font = New System.Drawing.Font("a_BosaNova", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbltimetxt.ForeColor = System.Drawing.Color.White
        Me.lbltimetxt.Location = New System.Drawing.Point(597, 3)
        Me.lbltimetxt.Name = "lbltimetxt"
        Me.lbltimetxt.Size = New System.Drawing.Size(76, 41)
        Me.lbltimetxt.TabIndex = 12
        Me.lbltimetxt.Text = "Время:"
        Me.lbltimetxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopScore
        '
        Me.lblTopScore.Font = New System.Drawing.Font("a_BosaNova", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTopScore.ForeColor = System.Drawing.Color.White
        Me.lblTopScore.Location = New System.Drawing.Point(500, 3)
        Me.lblTopScore.Name = "lblTopScore"
        Me.lblTopScore.Size = New System.Drawing.Size(91, 41)
        Me.lblTopScore.TabIndex = 14
        Me.lblTopScore.Text = "0"
        Me.lblTopScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopName
        '
        Me.lblTopName.Font = New System.Drawing.Font("a_BosaNova", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTopName.ForeColor = System.Drawing.Color.White
        Me.lblTopName.Location = New System.Drawing.Point(302, 3)
        Me.lblTopName.Name = "lblTopName"
        Me.lblTopName.Size = New System.Drawing.Size(206, 41)
        Me.lblTopName.TabIndex = 13
        Me.lblTopName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltop
        '
        Me.lbltop.Font = New System.Drawing.Font("a_BosaNova", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbltop.ForeColor = System.Drawing.Color.White
        Me.lbltop.Location = New System.Drawing.Point(227, 3)
        Me.lbltop.Name = "lbltop"
        Me.lbltop.Size = New System.Drawing.Size(76, 41)
        Me.lbltop.TabIndex = 12
        Me.lbltop.Text = "Лидер:"
        Me.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblscoreText
        '
        Me.lblscoreText.Font = New System.Drawing.Font("a_BosaNova", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblscoreText.ForeColor = System.Drawing.Color.White
        Me.lblscoreText.Location = New System.Drawing.Point(13, 3)
        Me.lblscoreText.Name = "lblscoreText"
        Me.lblscoreText.Size = New System.Drawing.Size(122, 41)
        Me.lblscoreText.TabIndex = 1
        Me.lblscoreText.Text = "Ваши очки:"
        Me.lblscoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblscore
        '
        Me.lblscore.Font = New System.Drawing.Font("a_BosaNova", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblscore.ForeColor = System.Drawing.Color.White
        Me.lblscore.Location = New System.Drawing.Point(114, 3)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(91, 41)
        Me.lblscore.TabIndex = 0
        Me.lblscore.Text = "0"
        Me.lblscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BackgroundImage = Global.HTG_Snake.My.Resources.Resources.змейка
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(306, 511)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 247)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5800
        '
        'tmrTIME
        '
        Me.tmrTIME.Interval = 1000
        '
        'txtnick
        '
        Me.txtnick.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnick.Font = New System.Drawing.Font("a_OldTyper", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtnick.Location = New System.Drawing.Point(231, 823)
        Me.txtnick.MaxLength = 15
        Me.txtnick.Name = "txtnick"
        Me.txtnick.Size = New System.Drawing.Size(294, 24)
        Me.txtnick.TabIndex = 11
        Me.txtnick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnick.Visible = False
        '
        'lblnick
        '
        Me.lblnick.AutoSize = True
        Me.lblnick.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblnick.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblnick.Location = New System.Drawing.Point(273, 796)
        Me.lblnick.Name = "lblnick"
        Me.lblnick.Size = New System.Drawing.Size(210, 24)
        Me.lblnick.TabIndex = 12
        Me.lblnick.Text = "Введите ваш никнейм"
        Me.lblnick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblnick.Visible = False
        '
        'txtphone
        '
        Me.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtphone.Font = New System.Drawing.Font("a_OldTyper", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtphone.Location = New System.Drawing.Point(231, 878)
        Me.txtphone.MaxLength = 15
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(294, 24)
        Me.txtphone.TabIndex = 13
        Me.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtphone.Visible = False
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblphone.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblphone.Location = New System.Drawing.Point(290, 850)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(178, 24)
        Me.lblphone.TabIndex = 14
        Me.lblphone.Text = "И номер телефона"
        Me.lblphone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblphone.Visible = False
        '
        'txtscoretable
        '
        Me.txtscoretable.BackColor = System.Drawing.Color.Black
        Me.txtscoretable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtscoretable.Font = New System.Drawing.Font("Quake Cyr", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtscoretable.ForeColor = System.Drawing.Color.Orange
        Me.txtscoretable.Location = New System.Drawing.Point(86, 330)
        Me.txtscoretable.Multiline = True
        Me.txtscoretable.Name = "txtscoretable"
        Me.txtscoretable.Size = New System.Drawing.Size(600, 600)
        Me.txtscoretable.TabIndex = 15
        Me.txtscoretable.Text = "Таблица лидеров -----------------------------------"
        Me.txtscoretable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtscoretable.Visible = False
        '
        'txtpositionscore
        '
        Me.txtpositionscore.BackColor = System.Drawing.Color.Black
        Me.txtpositionscore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpositionscore.Font = New System.Drawing.Font("Quake Cyr", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtpositionscore.ForeColor = System.Drawing.Color.Orange
        Me.txtpositionscore.Location = New System.Drawing.Point(156, 422)
        Me.txtpositionscore.Multiline = True
        Me.txtpositionscore.Name = "txtpositionscore"
        Me.txtpositionscore.Size = New System.Drawing.Size(36, 352)
        Me.txtpositionscore.TabIndex = 16
        Me.txtpositionscore.Text = "1. 2. 3. 4. 5."
        Me.txtpositionscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpositionscore.Visible = False
        '
        'frmSnake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.HTG_Snake.My.Resources.Resources.фон
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(768, 1080)
        Me.Controls.Add(Me.txtpositionscore)
        Me.Controls.Add(Me.lblphone)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.lblnick)
        Me.Controls.Add(Me.txtnick)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.toppanel)
        Me.Controls.Add(Me.txtscoretable)
        Me.Controls.Add(Me.picGame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSnake"
        Me.Text = "HTG_Snake"
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toppanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents picGame As System.Windows.Forms.PictureBox
    Friend WithEvents toppanel As Panel
    Friend WithEvents lblscoreText As Label
    Friend WithEvents lblscore As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lbltop As Label
    Friend WithEvents lblTopScore As Label
    Friend WithEvents lblTopName As Label
    Friend WithEvents lblTimeGame As Label
    Friend WithEvents lbltimetxt As Label
    Friend WithEvents tmrTIME As Timer
    Friend WithEvents txtnick As TextBox
    Friend WithEvents lblnick As Label
    Friend WithEvents txtphone As TextBox
    Friend WithEvents lblphone As Label
    Friend WithEvents txtscoretable As TextBox
    Friend WithEvents txtpositionscore As TextBox
End Class
