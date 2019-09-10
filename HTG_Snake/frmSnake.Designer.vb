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
        Me.lblscoreText = New System.Windows.Forms.Label()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toppanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.picGame.Location = New System.Drawing.Point(0, 326)
        Me.picGame.Name = "picGame"
        Me.picGame.Size = New System.Drawing.Size(768, 808)
        Me.picGame.TabIndex = 7
        Me.picGame.TabStop = False
        '
        'toppanel
        '
        Me.toppanel.BackColor = System.Drawing.Color.Black
        Me.toppanel.Controls.Add(Me.lblscoreText)
        Me.toppanel.Controls.Add(Me.lblscore)
        Me.toppanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.toppanel.Location = New System.Drawing.Point(0, 0)
        Me.toppanel.Name = "toppanel"
        Me.toppanel.Size = New System.Drawing.Size(591, 46)
        Me.toppanel.TabIndex = 9
        '
        'lblscoreText
        '
        Me.lblscoreText.Font = New System.Drawing.Font("a_BosaNova", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblscoreText.ForeColor = System.Drawing.Color.White
        Me.lblscoreText.Location = New System.Drawing.Point(13, 3)
        Me.lblscoreText.Name = "lblscoreText"
        Me.lblscoreText.Size = New System.Drawing.Size(76, 41)
        Me.lblscoreText.TabIndex = 1
        Me.lblscoreText.Text = "Очки:"
        Me.lblscoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblscore
        '
        Me.lblscore.Font = New System.Drawing.Font("a_BosaNova", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblscore.ForeColor = System.Drawing.Color.White
        Me.lblscore.Location = New System.Drawing.Point(81, 0)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(66, 41)
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
        Me.Timer1.Interval = 1100
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(77, 340)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(596, 629)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5800
        '
        'frmSnake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.HTG_Snake.My.Resources.Resources.фон
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(768, 1080)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.toppanel)
        Me.Controls.Add(Me.picGame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSnake"
        Me.Text = "HTG_Snake"
        CType(Me.picGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toppanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents picGame As System.Windows.Forms.PictureBox
    Friend WithEvents toppanel As Panel
    Friend WithEvents lblscoreText As Label
    Friend WithEvents lblscore As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer2 As Timer
End Class
