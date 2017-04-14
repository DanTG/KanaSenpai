Public Class flashcard

    'Var Declarations
    Dim intChar As Integer = 0
    Dim strAns As String = ""
    Dim intArrChar As Integer = 0
    Dim intArrRom As Integer = 0
    Dim refNum As Integer = 0

    'Constructor
    Public Sub createCard(ByVal intCharacterUnicode As Integer, ByVal strCorrectAnswer As String, _
                          ByVal intCharacterArray As Integer, ByVal intRomajiArray As Integer, ByVal ReferenceNumber As Integer)

        intChar = intCharacterUnicode
        strAns = strCorrectAnswer
        intArrChar = intCharacterArray
        intArrRom = intRomajiArray
        refNum = ReferenceNumber

    End Sub

    'Getters
    Public Function getChar() As Integer
        Return intChar
    End Function


    Public Function getAnswer() As String
        Return strAns
    End Function


    Public Function getCharArray() As Integer
        Return intArrChar
    End Function


    Public Function getRomajiArray() As Integer
        Return intArrRom
    End Function


    Public Function getRefNum() As Integer
        Return refNum
    End Function

End Class
