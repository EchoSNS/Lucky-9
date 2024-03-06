<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.userFirstCardPic = New System.Windows.Forms.PictureBox()
        Me.userSecondCardPic = New System.Windows.Forms.PictureBox()
        Me.userThirdCardPic = New System.Windows.Forms.PictureBox()
        Me.playButton = New System.Windows.Forms.Button()
        Me.showDealButton = New System.Windows.Forms.Button()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.userFirstCardLabel = New System.Windows.Forms.Label()
        Me.userSecondCardLabel = New System.Windows.Forms.Label()
        Me.userThirdCardLabel = New System.Windows.Forms.Label()
        Me.userScoreLabel = New System.Windows.Forms.Label()
        Me.userWinLabel = New System.Windows.Forms.Label()
        Me.userLoseLabel = New System.Windows.Forms.Label()
        Me.showDeckButton = New System.Windows.Forms.Button()
        Me.aiThirdCardLabel = New System.Windows.Forms.Label()
        Me.aiSecondCardLabel = New System.Windows.Forms.Label()
        Me.aiFirstCardLabel = New System.Windows.Forms.Label()
        Me.aiThirdCardPic = New System.Windows.Forms.PictureBox()
        Me.aiSecondCardPic = New System.Windows.Forms.PictureBox()
        Me.aiFirstCardPic = New System.Windows.Forms.PictureBox()
        Me.aiLabel = New System.Windows.Forms.Label()
        Me.aiLoseLabel = New System.Windows.Forms.Label()
        Me.aiWinLabel = New System.Windows.Forms.Label()
        Me.aiScoreLabel = New System.Windows.Forms.Label()
        Me.ai2ScoreLabel = New System.Windows.Forms.Label()
        Me.ai2LoseLabel = New System.Windows.Forms.Label()
        Me.ai2WinLabel = New System.Windows.Forms.Label()
        Me.ai2Label = New System.Windows.Forms.Label()
        Me.ai2ThirdCardLabel = New System.Windows.Forms.Label()
        Me.ai2SecondCardLabel = New System.Windows.Forms.Label()
        Me.ai2FirstCardLabel = New System.Windows.Forms.Label()
        Me.ai2ThirdCardPic = New System.Windows.Forms.PictureBox()
        Me.ai2SecondCardPic = New System.Windows.Forms.PictureBox()
        Me.ai2FirstCardPic = New System.Windows.Forms.PictureBox()
        Me.playedCardsComboBox = New System.Windows.Forms.ComboBox()
        Me.playedCardsLabel = New System.Windows.Forms.Label()
        CType(Me.userFirstCardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userSecondCardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userThirdCardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aiThirdCardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aiSecondCardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aiFirstCardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ai2ThirdCardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ai2SecondCardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ai2FirstCardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userFirstCardPic
        '
        Me.userFirstCardPic.Location = New System.Drawing.Point(199, 436)
        Me.userFirstCardPic.Name = "userFirstCardPic"
        Me.userFirstCardPic.Size = New System.Drawing.Size(100, 122)
        Me.userFirstCardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.userFirstCardPic.TabIndex = 3
        Me.userFirstCardPic.TabStop = False
        '
        'userSecondCardPic
        '
        Me.userSecondCardPic.Location = New System.Drawing.Point(321, 436)
        Me.userSecondCardPic.Name = "userSecondCardPic"
        Me.userSecondCardPic.Size = New System.Drawing.Size(100, 122)
        Me.userSecondCardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.userSecondCardPic.TabIndex = 4
        Me.userSecondCardPic.TabStop = False
        '
        'userThirdCardPic
        '
        Me.userThirdCardPic.Location = New System.Drawing.Point(444, 436)
        Me.userThirdCardPic.Name = "userThirdCardPic"
        Me.userThirdCardPic.Size = New System.Drawing.Size(100, 122)
        Me.userThirdCardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.userThirdCardPic.TabIndex = 5
        Me.userThirdCardPic.TabStop = False
        '
        'playButton
        '
        Me.playButton.Font = New System.Drawing.Font("Maplestory OTF", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.playButton.Location = New System.Drawing.Point(54, 449)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(93, 37)
        Me.playButton.TabIndex = 6
        Me.playButton.Text = "Play"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'showDealButton
        '
        Me.showDealButton.Font = New System.Drawing.Font("Maplestory OTF", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.showDealButton.Location = New System.Drawing.Point(54, 506)
        Me.showDealButton.Name = "showDealButton"
        Me.showDealButton.Size = New System.Drawing.Size(93, 37)
        Me.showDealButton.TabIndex = 7
        Me.showDealButton.Text = "Show Deal"
        Me.showDealButton.UseVisualStyleBackColor = True
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.userLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.userLabel.Location = New System.Drawing.Point(292, 390)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(151, 25)
        Me.userLabel.TabIndex = 8
        Me.userLabel.Text = "Human Player"
        '
        'userFirstCardLabel
        '
        Me.userFirstCardLabel.AutoSize = True
        Me.userFirstCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.userFirstCardLabel.Font = New System.Drawing.Font("Maplestory OTF", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.userFirstCardLabel.Location = New System.Drawing.Point(201, 568)
        Me.userFirstCardLabel.Name = "userFirstCardLabel"
        Me.userFirstCardLabel.Size = New System.Drawing.Size(2, 16)
        Me.userFirstCardLabel.TabIndex = 9
        '
        'userSecondCardLabel
        '
        Me.userSecondCardLabel.AutoSize = True
        Me.userSecondCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.userSecondCardLabel.Font = New System.Drawing.Font("Maplestory OTF", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.userSecondCardLabel.Location = New System.Drawing.Point(326, 568)
        Me.userSecondCardLabel.Name = "userSecondCardLabel"
        Me.userSecondCardLabel.Size = New System.Drawing.Size(2, 16)
        Me.userSecondCardLabel.TabIndex = 10
        '
        'userThirdCardLabel
        '
        Me.userThirdCardLabel.AutoSize = True
        Me.userThirdCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.userThirdCardLabel.Font = New System.Drawing.Font("Maplestory OTF", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.userThirdCardLabel.Location = New System.Drawing.Point(447, 568)
        Me.userThirdCardLabel.Name = "userThirdCardLabel"
        Me.userThirdCardLabel.Size = New System.Drawing.Size(2, 16)
        Me.userThirdCardLabel.TabIndex = 11
        '
        'userScoreLabel
        '
        Me.userScoreLabel.AutoSize = True
        Me.userScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.userScoreLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.userScoreLabel.Location = New System.Drawing.Point(321, 344)
        Me.userScoreLabel.Name = "userScoreLabel"
        Me.userScoreLabel.Size = New System.Drawing.Size(96, 25)
        Me.userScoreLabel.TabIndex = 12
        Me.userScoreLabel.Text = "Score: 0"
        '
        'userWinLabel
        '
        Me.userWinLabel.AutoSize = True
        Me.userWinLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.userWinLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.userWinLabel.Location = New System.Drawing.Point(550, 470)
        Me.userWinLabel.Name = "userWinLabel"
        Me.userWinLabel.Size = New System.Drawing.Size(73, 25)
        Me.userWinLabel.TabIndex = 13
        Me.userWinLabel.Text = "Win: 0"
        '
        'userLoseLabel
        '
        Me.userLoseLabel.AutoSize = True
        Me.userLoseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.userLoseLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.userLoseLabel.Location = New System.Drawing.Point(550, 506)
        Me.userLoseLabel.Name = "userLoseLabel"
        Me.userLoseLabel.Size = New System.Drawing.Size(85, 25)
        Me.userLoseLabel.TabIndex = 14
        Me.userLoseLabel.Text = "Lose: 0"
        '
        'showDeckButton
        '
        Me.showDeckButton.Font = New System.Drawing.Font("Maplestory OTF", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.showDeckButton.Location = New System.Drawing.Point(682, 482)
        Me.showDeckButton.Name = "showDeckButton"
        Me.showDeckButton.Size = New System.Drawing.Size(93, 37)
        Me.showDeckButton.TabIndex = 15
        Me.showDeckButton.Text = "Show Deck"
        Me.showDeckButton.UseVisualStyleBackColor = True
        '
        'aiThirdCardLabel
        '
        Me.aiThirdCardLabel.AutoSize = True
        Me.aiThirdCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.aiThirdCardLabel.Font = New System.Drawing.Font("Maplestory OTF", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.aiThirdCardLabel.Location = New System.Drawing.Point(676, 256)
        Me.aiThirdCardLabel.Name = "aiThirdCardLabel"
        Me.aiThirdCardLabel.Size = New System.Drawing.Size(2, 16)
        Me.aiThirdCardLabel.TabIndex = 21
        '
        'aiSecondCardLabel
        '
        Me.aiSecondCardLabel.AutoSize = True
        Me.aiSecondCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.aiSecondCardLabel.Font = New System.Drawing.Font("Maplestory OTF", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.aiSecondCardLabel.Location = New System.Drawing.Point(555, 256)
        Me.aiSecondCardLabel.Name = "aiSecondCardLabel"
        Me.aiSecondCardLabel.Size = New System.Drawing.Size(2, 16)
        Me.aiSecondCardLabel.TabIndex = 20
        '
        'aiFirstCardLabel
        '
        Me.aiFirstCardLabel.AutoSize = True
        Me.aiFirstCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.aiFirstCardLabel.Font = New System.Drawing.Font("Maplestory OTF", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.aiFirstCardLabel.Location = New System.Drawing.Point(430, 256)
        Me.aiFirstCardLabel.Name = "aiFirstCardLabel"
        Me.aiFirstCardLabel.Size = New System.Drawing.Size(2, 16)
        Me.aiFirstCardLabel.TabIndex = 19
        '
        'aiThirdCardPic
        '
        Me.aiThirdCardPic.Location = New System.Drawing.Point(673, 124)
        Me.aiThirdCardPic.Name = "aiThirdCardPic"
        Me.aiThirdCardPic.Size = New System.Drawing.Size(100, 122)
        Me.aiThirdCardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.aiThirdCardPic.TabIndex = 18
        Me.aiThirdCardPic.TabStop = False
        '
        'aiSecondCardPic
        '
        Me.aiSecondCardPic.Location = New System.Drawing.Point(550, 124)
        Me.aiSecondCardPic.Name = "aiSecondCardPic"
        Me.aiSecondCardPic.Size = New System.Drawing.Size(100, 122)
        Me.aiSecondCardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.aiSecondCardPic.TabIndex = 17
        Me.aiSecondCardPic.TabStop = False
        '
        'aiFirstCardPic
        '
        Me.aiFirstCardPic.Location = New System.Drawing.Point(428, 124)
        Me.aiFirstCardPic.Name = "aiFirstCardPic"
        Me.aiFirstCardPic.Size = New System.Drawing.Size(100, 122)
        Me.aiFirstCardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.aiFirstCardPic.TabIndex = 16
        Me.aiFirstCardPic.TabStop = False
        '
        'aiLabel
        '
        Me.aiLabel.AutoSize = True
        Me.aiLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.aiLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.aiLabel.Location = New System.Drawing.Point(544, 79)
        Me.aiLabel.Name = "aiLabel"
        Me.aiLabel.Size = New System.Drawing.Size(121, 25)
        Me.aiLabel.TabIndex = 22
        Me.aiLabel.Text = "AI Player 1"
        '
        'aiLoseLabel
        '
        Me.aiLoseLabel.AutoSize = True
        Me.aiLoseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.aiLoseLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.aiLoseLabel.Location = New System.Drawing.Point(682, 79)
        Me.aiLoseLabel.Name = "aiLoseLabel"
        Me.aiLoseLabel.Size = New System.Drawing.Size(85, 25)
        Me.aiLoseLabel.TabIndex = 24
        Me.aiLoseLabel.Text = "Lose: 0"
        '
        'aiWinLabel
        '
        Me.aiWinLabel.AutoSize = True
        Me.aiWinLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.aiWinLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.aiWinLabel.Location = New System.Drawing.Point(447, 79)
        Me.aiWinLabel.Name = "aiWinLabel"
        Me.aiWinLabel.Size = New System.Drawing.Size(73, 25)
        Me.aiWinLabel.TabIndex = 23
        Me.aiWinLabel.Text = "Win: 0"
        '
        'aiScoreLabel
        '
        Me.aiScoreLabel.AutoSize = True
        Me.aiScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.aiScoreLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.aiScoreLabel.Location = New System.Drawing.Point(555, 293)
        Me.aiScoreLabel.Name = "aiScoreLabel"
        Me.aiScoreLabel.Size = New System.Drawing.Size(96, 25)
        Me.aiScoreLabel.TabIndex = 25
        Me.aiScoreLabel.Text = "Score: 0"
        '
        'ai2ScoreLabel
        '
        Me.ai2ScoreLabel.AutoSize = True
        Me.ai2ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ai2ScoreLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ai2ScoreLabel.Location = New System.Drawing.Point(150, 293)
        Me.ai2ScoreLabel.Name = "ai2ScoreLabel"
        Me.ai2ScoreLabel.Size = New System.Drawing.Size(96, 25)
        Me.ai2ScoreLabel.TabIndex = 35
        Me.ai2ScoreLabel.Text = "Score: 0"
        '
        'ai2LoseLabel
        '
        Me.ai2LoseLabel.AutoSize = True
        Me.ai2LoseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ai2LoseLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ai2LoseLabel.Location = New System.Drawing.Point(277, 79)
        Me.ai2LoseLabel.Name = "ai2LoseLabel"
        Me.ai2LoseLabel.Size = New System.Drawing.Size(85, 25)
        Me.ai2LoseLabel.TabIndex = 34
        Me.ai2LoseLabel.Text = "Lose: 0"
        '
        'ai2WinLabel
        '
        Me.ai2WinLabel.AutoSize = True
        Me.ai2WinLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ai2WinLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ai2WinLabel.Location = New System.Drawing.Point(42, 79)
        Me.ai2WinLabel.Name = "ai2WinLabel"
        Me.ai2WinLabel.Size = New System.Drawing.Size(73, 25)
        Me.ai2WinLabel.TabIndex = 33
        Me.ai2WinLabel.Text = "Win: 0"
        '
        'ai2Label
        '
        Me.ai2Label.AutoSize = True
        Me.ai2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ai2Label.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ai2Label.Location = New System.Drawing.Point(139, 79)
        Me.ai2Label.Name = "ai2Label"
        Me.ai2Label.Size = New System.Drawing.Size(121, 25)
        Me.ai2Label.TabIndex = 32
        Me.ai2Label.Text = "AI Player 1"
        '
        'ai2ThirdCardLabel
        '
        Me.ai2ThirdCardLabel.AutoSize = True
        Me.ai2ThirdCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ai2ThirdCardLabel.Font = New System.Drawing.Font("Maplestory OTF", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ai2ThirdCardLabel.Location = New System.Drawing.Point(271, 256)
        Me.ai2ThirdCardLabel.Name = "ai2ThirdCardLabel"
        Me.ai2ThirdCardLabel.Size = New System.Drawing.Size(2, 16)
        Me.ai2ThirdCardLabel.TabIndex = 31
        '
        'ai2SecondCardLabel
        '
        Me.ai2SecondCardLabel.AutoSize = True
        Me.ai2SecondCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ai2SecondCardLabel.Font = New System.Drawing.Font("Maplestory OTF", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ai2SecondCardLabel.Location = New System.Drawing.Point(150, 256)
        Me.ai2SecondCardLabel.Name = "ai2SecondCardLabel"
        Me.ai2SecondCardLabel.Size = New System.Drawing.Size(2, 16)
        Me.ai2SecondCardLabel.TabIndex = 30
        '
        'ai2FirstCardLabel
        '
        Me.ai2FirstCardLabel.AutoSize = True
        Me.ai2FirstCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ai2FirstCardLabel.Font = New System.Drawing.Font("Maplestory OTF", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ai2FirstCardLabel.Location = New System.Drawing.Point(25, 256)
        Me.ai2FirstCardLabel.Name = "ai2FirstCardLabel"
        Me.ai2FirstCardLabel.Size = New System.Drawing.Size(2, 16)
        Me.ai2FirstCardLabel.TabIndex = 29
        '
        'ai2ThirdCardPic
        '
        Me.ai2ThirdCardPic.ErrorImage = Nothing
        Me.ai2ThirdCardPic.Location = New System.Drawing.Point(268, 124)
        Me.ai2ThirdCardPic.Name = "ai2ThirdCardPic"
        Me.ai2ThirdCardPic.Size = New System.Drawing.Size(100, 122)
        Me.ai2ThirdCardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ai2ThirdCardPic.TabIndex = 28
        Me.ai2ThirdCardPic.TabStop = False
        '
        'ai2SecondCardPic
        '
        Me.ai2SecondCardPic.Location = New System.Drawing.Point(145, 124)
        Me.ai2SecondCardPic.Name = "ai2SecondCardPic"
        Me.ai2SecondCardPic.Size = New System.Drawing.Size(100, 122)
        Me.ai2SecondCardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ai2SecondCardPic.TabIndex = 27
        Me.ai2SecondCardPic.TabStop = False
        '
        'ai2FirstCardPic
        '
        Me.ai2FirstCardPic.Location = New System.Drawing.Point(23, 124)
        Me.ai2FirstCardPic.Name = "ai2FirstCardPic"
        Me.ai2FirstCardPic.Size = New System.Drawing.Size(100, 122)
        Me.ai2FirstCardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ai2FirstCardPic.TabIndex = 26
        Me.ai2FirstCardPic.TabStop = False
        '
        'playedCardsComboBox
        '
        Me.playedCardsComboBox.FormattingEnabled = True
        Me.playedCardsComboBox.Location = New System.Drawing.Point(256, 41)
        Me.playedCardsComboBox.Name = "playedCardsComboBox"
        Me.playedCardsComboBox.Size = New System.Drawing.Size(329, 23)
        Me.playedCardsComboBox.TabIndex = 36
        '
        'playedCardsLabel
        '
        Me.playedCardsLabel.AutoSize = True
        Me.playedCardsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.playedCardsLabel.Font = New System.Drawing.Font("Maplestory OTF", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.playedCardsLabel.Location = New System.Drawing.Point(352, 13)
        Me.playedCardsLabel.Name = "playedCardsLabel"
        Me.playedCardsLabel.Size = New System.Drawing.Size(147, 25)
        Me.playedCardsLabel.TabIndex = 37
        Me.playedCardsLabel.Text = "Played Cards"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 599)
        Me.Controls.Add(Me.playedCardsLabel)
        Me.Controls.Add(Me.playedCardsComboBox)
        Me.Controls.Add(Me.ai2ScoreLabel)
        Me.Controls.Add(Me.ai2LoseLabel)
        Me.Controls.Add(Me.ai2WinLabel)
        Me.Controls.Add(Me.ai2Label)
        Me.Controls.Add(Me.ai2ThirdCardLabel)
        Me.Controls.Add(Me.ai2SecondCardLabel)
        Me.Controls.Add(Me.ai2FirstCardLabel)
        Me.Controls.Add(Me.ai2ThirdCardPic)
        Me.Controls.Add(Me.ai2SecondCardPic)
        Me.Controls.Add(Me.ai2FirstCardPic)
        Me.Controls.Add(Me.aiScoreLabel)
        Me.Controls.Add(Me.aiLoseLabel)
        Me.Controls.Add(Me.aiWinLabel)
        Me.Controls.Add(Me.aiLabel)
        Me.Controls.Add(Me.aiThirdCardLabel)
        Me.Controls.Add(Me.aiSecondCardLabel)
        Me.Controls.Add(Me.aiFirstCardLabel)
        Me.Controls.Add(Me.aiThirdCardPic)
        Me.Controls.Add(Me.aiSecondCardPic)
        Me.Controls.Add(Me.aiFirstCardPic)
        Me.Controls.Add(Me.showDeckButton)
        Me.Controls.Add(Me.userLoseLabel)
        Me.Controls.Add(Me.userWinLabel)
        Me.Controls.Add(Me.userScoreLabel)
        Me.Controls.Add(Me.userThirdCardLabel)
        Me.Controls.Add(Me.userSecondCardLabel)
        Me.Controls.Add(Me.userFirstCardLabel)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.showDealButton)
        Me.Controls.Add(Me.playButton)
        Me.Controls.Add(Me.userThirdCardPic)
        Me.Controls.Add(Me.userSecondCardPic)
        Me.Controls.Add(Me.userFirstCardPic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lucky 9"
        CType(Me.userFirstCardPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userSecondCardPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userThirdCardPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aiThirdCardPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aiSecondCardPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aiFirstCardPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ai2ThirdCardPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ai2SecondCardPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ai2FirstCardPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents userFirstCardPic As PictureBox
    Friend WithEvents userSecondCardPic As PictureBox
    Friend WithEvents userThirdCardPic As PictureBox
    Friend WithEvents playButton As Button
    Friend WithEvents showDealButton As Button
    Friend WithEvents userLabel As Label
    Friend WithEvents userFirstCardLabel As Label
    Friend WithEvents userSecondCardLabel As Label
    Friend WithEvents userThirdCardLabel As Label
    Friend WithEvents userScoreLabel As Label
    Friend WithEvents userWinLabel As Label
    Friend WithEvents userLoseLabel As Label
    Friend WithEvents showDeckButton As Button
    Friend WithEvents aiThirdCardLabel As Label
    Friend WithEvents aiSecondCardLabel As Label
    Friend WithEvents aiFirstCardLabel As Label
    Friend WithEvents aiThirdCardPic As PictureBox
    Friend WithEvents aiSecondCardPic As PictureBox
    Friend WithEvents aiFirstCardPic As PictureBox
    Friend WithEvents aiLabel As Label
    Friend WithEvents aiLoseLabel As Label
    Friend WithEvents aiWinLabel As Label
    Friend WithEvents aiScoreLabel As Label
    Friend WithEvents ai2ScoreLabel As Label
    Friend WithEvents ai2LoseLabel As Label
    Friend WithEvents ai2WinLabel As Label
    Friend WithEvents ai2Label As Label
    Friend WithEvents ai2ThirdCardLabel As Label
    Friend WithEvents ai2SecondCardLabel As Label
    Friend WithEvents ai2FirstCardLabel As Label
    Friend WithEvents ai2ThirdCardPic As PictureBox
    Friend WithEvents ai2SecondCardPic As PictureBox
    Friend WithEvents ai2FirstCardPic As PictureBox
    Friend WithEvents playedCardsComboBox As ComboBox
    Friend WithEvents playedCardsLabel As Label
End Class
