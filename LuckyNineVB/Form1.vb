Imports System.CodeDom.Compiler
Imports System.Text.RegularExpressions
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim cardsList As New List(Of String)({"C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10",
                                "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10",
                                "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10",
                                "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H10"})

    Dim usedCardsList As New List(Of String)
    Dim onHandCardsList As New List(Of String)
    Dim shuffledCardsList As New List(Of String)

    Dim userScore As Integer = 0
    Dim aiScore As Integer = 0
    Dim ai2Score As Integer = 0

    Dim userWin As Integer = 0
    Dim userLose As Integer = 0
    Dim aiWin As Integer = 0
    Dim aiLose As Integer = 0
    Dim ai2Win As Integer = 0
    Dim ai2Lose As Integer = 0

    Dim numOfMatches As Integer = 0

    Dim currentCountCard As Integer = 0

    Private rnd As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shuffledCardsList.AddRange(cardsList)
        shuffleDeck(shuffledCardsList)
    End Sub

    Public Sub shuffleDeck(items As List(Of String))
        Dim j As Int32
        Dim temp As String

        For n As Int32 = items.Count - 1 To 0 Step -1
            j = rnd.Next(0, n + 1)
            ' Swap them.
            temp = items(n)
            items(n) = items(j)
            items(j) = temp
        Next n
    End Sub

    Public Function drawCard() As String
        Dim temp = shuffledCardsList(0)
        onHandCardsList.Add(shuffledCardsList(0))
        shuffledCardsList.Remove(temp)
        Return temp
    End Function

    Public Sub resetLabels()
        userThirdCardLabel.Text = ""
        aiThirdCardLabel.Text = ""
        ai2ThirdCardLabel.Text = ""

        aiScoreLabel.Text = "Score: "
        ai2ScoreLabel.Text = "Score: "
        userScoreLabel.Text = "Score: "
    End Sub

    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        If (playButton.Text = "Play") Then
            resetLabels()
            If (shuffledCardsList.Count < 9) Then
                shuffledCardsList.Clear()
                shuffledCardsList.AddRange(cardsList)
                shuffleDeck(shuffledCardsList)
            End If

            userThirdCardLabel.Visible = False
            userThirdCardPic.Visible = False

            'Draw 2 Cards For User
            userFirstCardLabel.Text = drawCard()
            userFirstCardPic.Image = My.Resources.ResourceManager.GetObject(userFirstCardLabel.Text)

            userSecondCardLabel.Text = drawCard()
            userSecondCardPic.Image = My.Resources.ResourceManager.GetObject(userSecondCardLabel.Text)

            userScore = Integer.Parse(userFirstCardLabel.Text.Substring(1)) + Integer.Parse(userSecondCardLabel.Text.Substring(1))

            'Draw 2 Cards for the AI 1
            aiFirstCardLabel.Visible = False
            aiSecondCardLabel.Visible = False
            aiThirdCardLabel.Visible = False

            aiFirstCardLabel.Text = drawCard()
            aiFirstCardPic.Image = My.Resources.ResourceManager.GetObject("Default")

            aiSecondCardLabel.Text = drawCard()
            aiSecondCardPic.Image = My.Resources.ResourceManager.GetObject("Default")

            aiScore = Integer.Parse(aiFirstCardLabel.Text.Substring(1)) + Integer.Parse(aiSecondCardLabel.Text.Substring(1))

            aiThirdCardPic.Visible = False
            If (aiScore Mod 10 < 7) Then
                aiThirdCardPic.Visible = True
                aiThirdCardLabel.Text = drawCard()

                aiThirdCardPic.Image = My.Resources.ResourceManager.GetObject("Default")

                aiScore += Integer.Parse(aiThirdCardLabel.Text.Substring(1))
            End If


            'Draw 2 Cards for the AI 2
            ai2FirstCardLabel.Visible = False
            ai2SecondCardLabel.Visible = False
            ai2ThirdCardLabel.Visible = False

            ai2FirstCardLabel.Text = drawCard()
            ai2FirstCardPic.Image = My.Resources.ResourceManager.GetObject("Default")

            ai2SecondCardLabel.Text = drawCard()
            ai2SecondCardPic.Image = My.Resources.ResourceManager.GetObject("Default")

            ai2Score = Integer.Parse(ai2FirstCardLabel.Text.Substring(1)) + Integer.Parse(ai2SecondCardLabel.Text.Substring(1))

            ai2ThirdCardPic.Visible = False
            If (ai2Score Mod 10 < 7) Then
                ai2ThirdCardPic.Visible = True
                ai2ThirdCardLabel.Text = drawCard()
                ai2ThirdCardPic.Image = My.Resources.ResourceManager.GetObject("Default")

                ai2Score += Integer.Parse(ai2ThirdCardLabel.Text.Substring(1))
            End If

            playButton.Text = "Draw"
            showDealButton.Enabled = True

        ElseIf (playButton.Text = "Draw") Then
            userThirdCardLabel.Visible = True
            userThirdCardPic.Visible = True

            userThirdCardLabel.Text = drawCard()
            userThirdCardPic.Image = My.Resources.ResourceManager.GetObject(userThirdCardLabel.Text)

            userScore += Integer.Parse(userThirdCardLabel.Text.Substring(1))
            playButton.Enabled = False
        End If
    End Sub

    Private Sub showDealButton_Click(sender As Object, e As EventArgs) Handles showDealButton.Click
        aiFirstCardLabel.Visible = True
        aiSecondCardLabel.Visible = True
        aiThirdCardLabel.Visible = True

        ai2FirstCardLabel.Visible = True
        ai2SecondCardLabel.Visible = True
        ai2ThirdCardLabel.Visible = True

        aiThirdCardPic.Visible = True
        ai2ThirdCardPic.Visible = True

        aiFirstCardPic.Image = My.Resources.ResourceManager.GetObject(aiFirstCardLabel.Text)
        aiSecondCardPic.Image = My.Resources.ResourceManager.GetObject(aiSecondCardLabel.Text)

        ai2FirstCardPic.Image = My.Resources.ResourceManager.GetObject(ai2FirstCardLabel.Text)
        ai2SecondCardPic.Image = My.Resources.ResourceManager.GetObject(ai2SecondCardLabel.Text)

        Try
            aiThirdCardPic.Image = My.Resources.ResourceManager.GetObject(aiThirdCardLabel.Text)
        Catch ex As Exception
        End Try

        Try
            ai2ThirdCardPic.Image = My.Resources.ResourceManager.GetObject(ai2ThirdCardLabel.Text)
        Catch ex As Exception
            ai2ThirdCardPic.Visible = False
        End Try

        numOfMatches += 1
        aiScore = aiScore Mod 10
        aiScoreLabel.Text = "Score: " + aiScore.ToString

        ai2Score = ai2Score Mod 10
        ai2ScoreLabel.Text = "Score: " + ai2Score.ToString

        userScore = userScore Mod 10
        userScoreLabel.Text = "Score: " + userScore.ToString

        If (userScore > aiScore And userScore > ai2Score) Then
            userWin += 1
            aiLose += 1
            ai2Lose += 1
        ElseIf (aiScore > userScore And aiScore > ai2Score) Then
            aiWin += 1
            userLose += 1
            ai2Lose += 1
        ElseIf (ai2Score > userScore And ai2Score > aiScore) Then
            ai2Win += 1
            userLose += 1
            aiLose += 1
        End If

        'update score
        userWinLabel.Text = "Win: " + userWin.ToString
        userLoseLabel.Text = "Lose: " + userLose.ToString

        aiWinLabel.Text = "Win: " + aiWin.ToString
        aiLoseLabel.Text = "Lose: " + aiLose.ToString

        ai2WinLabel.Text = "Win: " + ai2Win.ToString
        ai2LoseLabel.Text = "Lose: " + ai2Lose.ToString

        'enable play button and set the text to "Play"
        playButton.Enabled = True
        playButton.Text = "Play"
        showDealButton.Enabled = False

        'Update the played cards
        For Each card As String In onHandCardsList.ToList
            usedCardsList.Add(card)
            onHandCardsList.Remove(card)
        Next
        For counterCard As Integer = currentCountCard To usedCardsList.Count - 1
            playedCardsComboBox.Items.Add("Match " + numOfMatches.ToString + ": " + usedCardsList(counterCard).Substring(1) + If(usedCardsList(counterCard).Substring(0, 1) = "C", " Of Clubs", If(usedCardsList(counterCard).Substring(0, 1) = "S", " Of Spades", If(usedCardsList(counterCard).Substring(0, 1) = "H", " Of Hearts", " Of Diamonds"))))
            currentCountCard += 1
        Next
    End Sub

    Private Sub showDeckButton_Click(sender As Object, e As EventArgs) Handles showDeckButton.Click
        Dim formDeck As New Form()
        formDeck.Text = "Unplayed Cards" + "(" + shuffledCardsList.Count.ToString + ")"
        'formDeck.Size = New Size(300, 400)

        ' Add a ListBox to the form to display the unplayed cards
        Dim lbCards As New ListBox()
        lbCards.Dock = DockStyle.Fill
        formDeck.Controls.Add(lbCards)

        ' Populate the ListBox with the unplayed cards
        For Each card As String In shuffledCardsList
            lbCards.Items.Add(card.Substring(1) + If(card.Substring(0, 1) = "C", " Of Clubs", If(card.Substring(0, 1) = "S", " Of Spades", If(card.Substring(0, 1) = "H", " Of Hearts", " Of Diamonds"))))
        Next

        ' Show the form
        formDeck.ShowDialog()
    End Sub
End Class
