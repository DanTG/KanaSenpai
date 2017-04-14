Module modMain

    'Arrays
    Dim arrKana() As Array = New Array(8) {modDat.intBasHir, modDat.intHirVar, modDat.intAllHir, _
                                           modDat.intBasKat, modDat.intKatVar, modDat.intAllKat, _
                                           modDat.strBasRom, modDat.strRomVar, modDat.strAllRom}

    Dim cards() As flashcard = New flashcard() {}
    Dim wrongCards() As flashcard = New flashcard(0) {}
    Dim lastCard As flashcard = New flashcard

    'Private Vars
    Dim intScore As Integer = 0
    Dim intWrong As Integer = 0
    Dim curCard As Integer = 0
    Dim answer As Boolean = True

    'Public Vars
    Public count As Integer = 0
    Public intCharType As Integer = 0
    Public intMaxWrong As Integer = 0
    Public intMaxCorrect As Integer = 0
    Public reviewStatus As Boolean = False


    'Populates cards array with correct kana cards
    Public Sub createCards()

        Dim size As Integer = 0
        Dim mix As Integer = 0
        Dim temp As flashcard = New flashcard
        Dim ran As Random = New Random

        'Sets the display array to the incorrect answers from previous game if on review cycle
        If reviewStatus = True Then

            size = wrongCards.GetUpperBound(0)
            Array.Resize(cards, size + 1)

            For i As Integer = 0 To size

                cards(i) = New flashcard
                cards(i).createCard(wrongCards(i).getChar, wrongCards(i).getAnswer, _
                                    wrongCards(i).getCharArray, wrongCards(i).getRomajiArray, i)

            Next


        Else

            'Sets the cards array to the correct dimension for kana type
            size = arrKana(intCharType).GetUpperBound(0)
            Array.Resize(cards, size + 1)

            'Populates cards array with correct kana cards
            For i As Integer = 0 To size
                cards(i) = New flashcard
                cards(i).createCard(CInt(arrKana(intCharType).GetValue(i)), strAllRom(i), intCharType, (intCharType \ 3) + 6, i)
            Next

            'Puts cards in random order
            For i As Integer = size To 0 Step -1
                mix = ran.Next(0, size)
                temp = cards(mix)
                cards(mix) = cards(i)
                cards(i) = temp
            Next

        End If


    End Sub

    'Sets values from settings manu
    Public Sub getSettings(ByVal CharacterType As Integer, ByVal MaximumCorrect As Integer, ByVal MaximumWrong As Integer)

        intCharType = CharacterType
        intMaxCorrect = MaximumCorrect
        intMaxWrong = MaximumWrong
        Array.Resize(wrongCards, intMaxWrong)

    End Sub

    'Checks answer and ends game when cards are finished
    Public Sub checkAns(ByVal ans As String)

        Dim input As String = ans

        'Checks given answer againsed correct answer
        If input = cards(curCard).getAnswer Then
            answer = True
            intScore += 1
        Else
            answer = False
            wrongAns()
        End If

        'Ends game when review is complete and dissables review button on options menu
        If reviewStatus = True And curCard = cards.GetUpperBound(0) Then
            frmSettings.btnReview.Enabled = False
            gameOver()
        End If

        'Incraments card counter and creates new cards when game is over
        If curCard < cards.GetUpperBound(0) Then
            curCard += 1
        Else
            createCards()
        End If

    End Sub

    'Tracks incorrect answers
    Private Sub wrongAns()

        intWrong += 1
        wrongCards(intWrong - 1) = cards(curCard)

    End Sub

    'Updates main frame displayed information
    Public Sub update()

        Dim status As String = "Correct"
        Dim winLose As String = ""

        'Displays win or loss message at end of game
        If intScore = intMaxCorrect Or intWrong = intMaxWrong Then

            If intScore = intMaxCorrect Then
                winLose = "You Win!"
            Else
                winLose = "You Lose :("
            End If

            frmSettings.lblSettingsTitle.Text = winLose
            gameOver()
            frmMain.lblLast.Text = ""

        Else 'Updates main form display information

            frmMain.lblScore.Text = "Current Score: " & intScore
            frmMain.lblWrong.Text = "Incorrect: " & intWrong
            frmMain.lblLast.Text = "Last Character: " & ChrW(lastCard.getChar) & " " & lastCard.getAnswer
            frmMain.lblChar.Text = ChrW(cards(curCard).getChar)

            'Creates a new label displaying an incorrect answer
            If answer = False Then
                Dim newWrong As Label = New Label
                newWrong.Text = ChrW(wrongCards(intWrong - 1).getChar)
                newWrong.Font = New Font("sans serif", 18)
                newWrong.Width = 35
                newWrong.Height = 35
                frmMain.flpWrongHist.Controls.Add(newWrong)
                status = "Incorrect"
            End If

            'Clears the main frame and displays last character
            frmMain.tbInput.Clear()
            frmMain.lblLast.Text = "Last Character: " & ChrW(lastCard.getChar) & " " & lastCard.getAnswer & " " & status
            lastCard = cards(curCard)

        End If



    End Sub

    'Clears main frame display information
    Private Sub clearFrmMain()

        frmMain.lblScore.Text = ""
        frmMain.lblWrong.Text = ""
        frmMain.lblLast.Text = ""
        frmMain.lblChar.Text = ""
        frmMain.tbInput.Clear()
        frmMain.flpWrongHist.Controls.Clear()

    End Sub

    'Clears frame and resets values for new game and displays settings menu
    Public Sub gameOver()

        clearFrmMain()
        intScore = 0
        intWrong = 0
        curCard = 0
        answer = True
        reviewStatus = False
        frmSettings.ShowDialog()
        frmSettings.btnStart.Focus()

    End Sub

End Module
