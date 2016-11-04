Imports System.Text.RegularExpressions 'imports the System.Text class into this module
Module Access_Module
    Dim OpenFile As String = Nothing
    Dim ASCIIOutput As String
    Dim ConsASCBin As Boolean
    Function ASCIItoBin(ByVal ASCIIstr As String)
        Dim Output As String = Nothing
        If ASCIIstr <> Nothing Then
            For Each Character As Char In ASCIIstr
                Output = Output & Dec_To_Bin(Asc(Character)) & " "
                'progress value calculation
                Dim x, l As Integer
                l = Len(Output) / 8
                x = l / Len(ASCIIstr) * 100
                If l <= Len(ASCIIstr) Then
                    ASCII_Main.ProgBar.Value = x
                End If
            Next
            ASCII_Main.ProgBar.Value = 100
        End If
        Return Output
    End Function
    Function Dec_To_Bin(ByVal StrText As String)
        Dim Output As String = Nothing
        Dim from As Int32
        If IsNumeric(StrText) Then
            from = StrText
            Dim n As Int16
            Do
                n = from Mod 2
                Output = n & Output
                from \= 2
            Loop Until from = 0
        End If
        If Len(Output) < 8 Then Output = Output.PadLeft(8, "0")
        Return Output
    End Function
    Function Bin_To_Dec(ByVal Bin As String)
        Dim dec As Double = Nothing
        Dim length As Integer = Len(Bin)
        Dim temp As Integer = Nothing
        Dim x As Integer = Nothing
        For x = 1 To length
            temp = Val(Mid(Bin, length, 1))
            length = length - 1
            If temp <> "0" Then
                dec += (2 ^ (x - 1))
            End If
        Next
        Return dec
    End Function
    Function BinToASCII(ByVal BinStr As String)
        Dim PurBinary As String = Nothing
        Dim Output As String = Nothing
        For Each Bit As Char In BinStr
            If Bit <> " " Then
                PurBinary = PurBinary & Bit
            End If
        Next
        Dim Binary(Len(PurBinary)) As String
        Dim Bytes(Len(PurBinary)) As String
        Dim i = 0
        For Each Item As Char In PurBinary
            Binary(i) = Item
            i = i + 1
        Next
        Dim BytesIX As Integer = 0
        Dim BinCheck As Boolean = False
        If Len(PurBinary) Mod 8 = Nothing Then
            BinCheck = True
            For Each Byt As Char In Binary
                If Len(Bytes(BytesIX)) <> 8 Then
                    Bytes(BytesIX) = Bytes(BytesIX) & Byt
                Else
                    BytesIX = BytesIX + 1
                    Bytes(BytesIX) = Bytes(BytesIX) & Byt
                End If
            Next
            For Each Bytes_ In Bytes
                Output = Output & Chr(Bin_To_Dec(Bytes_))
                Dim x, l As Integer
                l = Len(Output) * 8
                x = l / Len(PurBinary) * 100
                If l <= Len(PurBinary) Then
                    ASCII_Main.ProgBar.Value = x
                End If
            Next
            ASCII_Main.ProgBar.Value = 100
        Else
            MsgBox("Whether the Binary string is missing some or contains extra bits or it contains ASCII Characters. Please check the binary value(s) then try again.", vbCritical + vbOKOnly, "Binary Dealer - Bytes not constant")
        End If
        Return Output
    End Function
       Function IsASCII(ByVal str As String, Optional BinaryPattern As Boolean = False) As Boolean 'define a regular character check function
        Dim pattern As String
        pattern = "[A-Za-z2-9!@#$%^&*;:'|?<>~`/\.,{}+_=" & """" & "]"
        Dim match As Match = Regex.Match(str, pattern) 'check if one of the items in the pattern match with one if the string.
        If match.Success Then
            Return True 'if match found then the string contain a non-character value
        End If
        Return False 'return true if no match found
    End Function
    Private Sub BinaryToASCII(ByVal Str As String, Optional StartIndex As Integer = 1)
        Dim ASCII(122) As String
        Dim BINASCII(122) As String
        BINASCII(0) = "00000000"
        BINASCII(1) = "00000001"
        BINASCII(2) = "00000010"
        BINASCII(3) = "00000011"
        BINASCII(4) = "00000100"
        BINASCII(5) = "00000101"
        BINASCII(6) = "00000110"
        BINASCII(7) = "00000111"
        BINASCII(8) = "00001000"
        BINASCII(9) = "00001001"
        BINASCII(10) = "00001010"
        BINASCII(11) = "00001011"
        BINASCII(12) = "00001100"
        BINASCII(13) = "00001101"
        BINASCII(14) = "00001110"
        BINASCII(15) = "00001111"
        BINASCII(16) = "00010000"
        BINASCII(17) = "00010001"
        BINASCII(18) = "00010010"
        BINASCII(19) = "00010011"
        BINASCII(20) = "00010100"
        BINASCII(21) = "00010101"
        BINASCII(22) = "00010110"
        BINASCII(23) = "00010111"
        BINASCII(24) = "00011000"
        BINASCII(25) = "00011001"
        BINASCII(26) = "00011010"
        BINASCII(27) = "00011011"
        BINASCII(28) = "00011100"
        BINASCII(29) = "00011101"
        BINASCII(30) = "00011110"
        BINASCII(32) = "00100000"
        BINASCII(33) = "00100001"
        BINASCII(34) = "00100010"
        BINASCII(35) = "00100011"
        BINASCII(36) = "00100100"
        BINASCII(37) = "00100101"
        BINASCII(38) = "00100110"
        BINASCII(39) = "00100111"
        BINASCII(40) = "00101000"
        BINASCII(41) = "00101001"
        BINASCII(42) = "00101010"
        BINASCII(43) = "00101011"
        BINASCII(44) = "00101100"
        BINASCII(45) = "00101101"
        BINASCII(46) = "00101110"
        BINASCII(47) = "00101111"
        BINASCII(48) = "00110000"
        BINASCII(49) = "00110001"
        BINASCII(50) = "00110010"
        BINASCII(51) = "00110011"
        BINASCII(52) = "00110100"
        BINASCII(53) = "00110101"
        BINASCII(54) = "00110110"
        BINASCII(55) = "00110111"
        BINASCII(56) = "00111000"
        BINASCII(57) = "00111001"
        BINASCII(58) = "00111010"
        BINASCII(59) = "00111011"
        BINASCII(60) = "00111100"
        BINASCII(61) = "00111101"
        BINASCII(62) = "00111110"
        BINASCII(63) = "00111111"
        BINASCII(64) = "01000000"
        BINASCII(65) = "01000001"
        BINASCII(66) = "01000010"
        BINASCII(67) = "01000011"
        BINASCII(68) = "01000100"
        BINASCII(69) = "01000101"
        BINASCII(70) = "01000110"
        BINASCII(71) = "01000111"
        BINASCII(72) = "01001000"
        BINASCII(73) = "01001001"
        BINASCII(74) = "01001010"
        BINASCII(75) = "01001011"
        BINASCII(76) = "01001100"
        BINASCII(77) = "01001101"
        BINASCII(78) = "01001110"
        BINASCII(79) = "01001111"
        BINASCII(80) = "01010000"
        BINASCII(81) = "01010001"
        BINASCII(82) = "01010010"
        BINASCII(83) = "01010011"
        BINASCII(84) = "01010100"
        BINASCII(85) = "01010101"
        BINASCII(86) = "01010110"
        BINASCII(87) = "01010111"
        BINASCII(88) = "01011000"
        BINASCII(89) = "01011001"
        BINASCII(90) = "01011010"
        BINASCII(91) = "01011011"
        BINASCII(92) = "01011100"
        BINASCII(93) = "01011101"
        BINASCII(94) = "01011110"
        BINASCII(95) = "01011111"
        BINASCII(96) = "00111111"
        BINASCII(97) = "01100001"
        BINASCII(98) = "01100010"
        BINASCII(99) = "01100011"
        BINASCII(100) = "01100100"
        BINASCII(101) = "01100101"
        BINASCII(102) = "01100110"
        BINASCII(103) = "01100111"
        BINASCII(104) = "01101000"
        BINASCII(105) = "01101001"
        BINASCII(106) = "01101010"
        BINASCII(107) = "01101011"
        BINASCII(108) = "01101100"
        BINASCII(109) = "01101101"
        BINASCII(110) = "01101110"
        BINASCII(111) = "01101111"
        BINASCII(112) = "01110000"
        BINASCII(113) = "01110001"
        BINASCII(114) = "01110010"
        BINASCII(115) = "01110011"
        BINASCII(116) = "01110100"
        BINASCII(117) = "01110101"
        BINASCII(118) = "01110110"
        BINASCII(119) = "01110111"
        BINASCII(120) = "01111000"
        BINASCII(121) = "01111001"
        BINASCII(122) = "01111010"

        ASCII(32) = " "
        ASCII(33) = "!"
        ASCII(34) = """"
        ASCII(35) = "#"
        ASCII(36) = "$"
        ASCII(37) = "%"
        ASCII(38) = "&"
        ASCII(39) = "'"
        ASCII(40) = "("
        ASCII(41) = ")"
        ASCII(42) = "*"
        ASCII(43) = "+"
        ASCII(44) = ","
        ASCII(45) = "-"
        ASCII(46) = "."
        ASCII(47) = "/"
        ASCII(48) = "0"
        ASCII(49) = "1"
        ASCII(50) = "2"
        ASCII(51) = "3"
        ASCII(52) = "4"
        ASCII(53) = "5"
        ASCII(54) = "6"
        ASCII(55) = "7"
        ASCII(56) = "8"
        ASCII(57) = "9"
        ASCII(58) = ":"
        ASCII(59) = ";"
        ASCII(60) = "<"
        ASCII(61) = "="
        ASCII(62) = ">"
        ASCII(63) = "?"
        ASCII(64) = "@"

        ASCII(65) = "A"
        ASCII(66) = "B"
        ASCII(67) = "C"
        ASCII(68) = "D"
        ASCII(69) = "E"
        ASCII(70) = "F"
        ASCII(71) = "G"
        ASCII(72) = "H"
        ASCII(73) = "I"
        ASCII(74) = "J"
        ASCII(75) = "K"
        ASCII(76) = "L"
        ASCII(77) = "M"
        ASCII(78) = "N"
        ASCII(79) = "O"
        ASCII(80) = "P"
        ASCII(81) = "Q"
        ASCII(82) = "R"
        ASCII(83) = "S"
        ASCII(84) = "T"
        ASCII(85) = "U"
        ASCII(86) = "V"
        ASCII(87) = "W"
        ASCII(88) = "X"
        ASCII(89) = "Y"
        ASCII(90) = "Z"

        ASCII(91) = "["
        ASCII(92) = "\"
        ASCII(93) = "]"
        ASCII(94) = "^"
        ASCII(95) = "_"
        ASCII(96) = "`"

        ASCII(97) = "a"
        ASCII(98) = "b"
        ASCII(99) = "c"
        ASCII(100) = "d"
        ASCII(101) = "e"
        ASCII(102) = "f"
        ASCII(103) = "g"
        ASCII(104) = "h"
        ASCII(105) = "i"
        ASCII(106) = "j"
        ASCII(107) = "k"
        ASCII(108) = "l"
        ASCII(109) = "m"
        ASCII(110) = "n"
        ASCII(111) = "o"
        ASCII(112) = "p"
        ASCII(113) = "q"
        ASCII(114) = "r"
        ASCII(115) = "s"
        ASCII(116) = "t"
        ASCII(117) = "u"
        ASCII(118) = "v"
        ASCII(119) = "w"
        ASCII(120) = "x"
        ASCII(121) = "y"
        ASCII(122) = "z"

        Dim StrText As String = Nothing
        Dim OutLine As String = Nothing
        Dim OutInvalid = Nothing
        Dim index = StartIndex
        Dim i = 0
        Dim OutText As String = Nothing
        'If RecursiveSpaceRemover <> False Then
        For Each Character As Char In Str
            If Character <> " " Then
                StrText = StrText & Character
            End If
        Next
        'End If
        'Dim msg = Nothing
        'If Len(StrText) / 8 > 225 Then
        'msg = MsgBox("The file contains more than 225 bytes of ASCII Characters. In order to optimize the conversion speed, we need to split the file into chunks. Cancel if you want to split the file manually.", vbExclamation + vbOKCancel, "Binary Dealer - File too large")
        'End If
        'If msg = vbOK Then
        i = 0
        Dim CharArray(Len(StrText)) As String
        For Each Character As Char In Mid(StrText, index)
            CharArray(i) = Character
            i = i + 1
        Next
        i = 0

        Do Until Len(OutLine) = 8
            OutLine = OutLine & CharArray(i)
            i = i + 1
        Loop

        i = 0

        While Not BINASCII(i) = OutLine And 122 > i
            i = i + 1
        End While
        OutText = ASCII(i)
        ASCIIOutput = ASCIIOutput & OutText
        'progress value calculation
        Dim x, l As Integer
        l = Len(ASCIIOutput) * 8
        x = l / Len(StrText) * 100
        If l <= Len(StrText) Then
            ASCII_Main.ProgBar.Value = x
        End If
        If index + 8 >= Len(StrText) Then
            ASCII_Main.ProgBar.Value = 100
            ASCII_Main.RTBOutput.Text = ASCIIOutput
            ASCIIOutput = Nothing
        Else : BinaryToASCII(StrText, StartIndex:=index + 8)
        End If
        ' Else
        'Exit Sub
        'End If
    End Sub
    Sub Obsolete_ASCIItoBinary(ByVal Str As String, ByVal strLenght As Integer)
        Dim ASCII(122) As String
        Dim OutText As String = Nothing
        Dim OutInvalid As String = Nothing
        ASCII(0) = "00000000"
        ASCII(1) = "00000001"
        ASCII(2) = "00000010"
        ASCII(3) = "00000011"
        ASCII(4) = "00000100"
        ASCII(5) = "00000101"
        ASCII(6) = "00000110"
        ASCII(7) = "00000111"
        ASCII(8) = "00001000"
        ASCII(9) = "00001001"
        ASCII(10) = "00001010"
        ASCII(11) = "00001011"
        ASCII(12) = "00001100"
        ASCII(13) = "00001101"
        ASCII(14) = "00001110"
        ASCII(15) = "00001111"
        ASCII(16) = "00010000"
        ASCII(17) = "00010001"
        ASCII(18) = "00010010"
        ASCII(19) = "00010011"
        ASCII(20) = "00010100"
        ASCII(21) = "00010101"
        ASCII(22) = "00010110"
        ASCII(23) = "00010111"
        ASCII(24) = "00011000"
        ASCII(25) = "00011001"
        ASCII(26) = "00011010"
        ASCII(27) = "00011011"
        ASCII(28) = "00011100"
        ASCII(29) = "00011101"
        ASCII(30) = "00011110"
        ASCII(32) = "00100000"
        ASCII(33) = "00100001"
        ASCII(34) = "00100010"
        ASCII(35) = "00100011"
        ASCII(36) = "00100100"
        ASCII(37) = "00100101"
        ASCII(38) = "00100110"
        ASCII(39) = "00100111"
        ASCII(40) = "00101000"
        ASCII(41) = "00101001"
        ASCII(42) = "00101010"
        ASCII(43) = "00101011"
        ASCII(44) = "00101100"
        ASCII(45) = "00101101"
        ASCII(46) = "00101110"
        ASCII(47) = "00101111"
        ASCII(48) = "00110000"
        ASCII(49) = "00110001"
        ASCII(50) = "00110010"
        ASCII(51) = "00110011"
        ASCII(52) = "00110100"
        ASCII(53) = "00110101"
        ASCII(54) = "00110110"
        ASCII(55) = "00110111"
        ASCII(56) = "00111000"
        ASCII(57) = "00111001"
        ASCII(58) = "00111010"
        ASCII(59) = "00111011"
        ASCII(60) = "00111100"
        ASCII(61) = "00111101"
        ASCII(62) = "00111110"
        ASCII(63) = "00111111"
        ASCII(64) = "01000000"
        ASCII(65) = "01000001"
        ASCII(66) = "01000010"
        ASCII(67) = "01000011"
        ASCII(68) = "01000100"
        ASCII(69) = "01000101"
        ASCII(70) = "01000110"
        ASCII(71) = "01000111"
        ASCII(72) = "01001000"
        ASCII(73) = "01001001"
        ASCII(74) = "01001010"
        ASCII(75) = "01001011"
        ASCII(76) = "01001100"
        ASCII(77) = "01001101"
        ASCII(78) = "01001110"
        ASCII(79) = "01001111"
        ASCII(80) = "01010000"
        ASCII(81) = "01010001"
        ASCII(82) = "01010010"
        ASCII(83) = "01010011"
        ASCII(84) = "01010100"
        ASCII(85) = "01010101"
        ASCII(86) = "01010110"
        ASCII(87) = "01010111"
        ASCII(88) = "01011000"
        ASCII(89) = "01011001"
        ASCII(90) = "01011010"
        ASCII(91) = "01011011"
        ASCII(92) = "01011100"
        ASCII(93) = "01011101"
        ASCII(94) = "01011110"
        ASCII(95) = "01011111"
        ASCII(96) = "00111111"
        ASCII(97) = "01100001"
        ASCII(98) = "01100010"
        ASCII(99) = "01100011"
        ASCII(100) = "01100100"
        ASCII(101) = "01100101"
        ASCII(102) = "01100110"
        ASCII(103) = "01100111"
        ASCII(104) = "01101000"
        ASCII(105) = "01101001"
        ASCII(106) = "01101010"
        ASCII(107) = "01101011"
        ASCII(108) = "01101100"
        ASCII(109) = "01101101"
        ASCII(110) = "01101110"
        ASCII(111) = "01101111"
        ASCII(112) = "01110000"
        ASCII(113) = "01110001"
        ASCII(114) = "01110010"
        ASCII(115) = "01110011"
        ASCII(116) = "01110100"
        ASCII(117) = "01110101"
        ASCII(118) = "01110110"
        ASCII(119) = "01110111"
        ASCII(120) = "01111000"
        ASCII(121) = "01111001"
        ASCII(122) = "01111010"

        Dim StrText As String = Str
        If StrText <> Nothing Then
            For Each Character As Char In StrText
                If Asc(Character) <= 122 Then
                    If Character <> " " Then
                        OutText = OutText & ASCII(Asc(Character)) & " "
                    Else : OutText = OutText & ASCII(32) & " "
                    End If
                Else : OutInvalid = OutInvalid & Character & " "
                End If
                'progress value calculation
                Dim x, l As Integer
                l = Len(OutText) / 8
                x = l / strLenght * 100
                If l <= strLenght Then
                    ASCII_Main.ProgBar.Value = x
                End If
            Next
            ASCII_Main.RTBOutput.Text = OutText
            ASCII_Main.ProgBar.Value = 100
            If OutInvalid <> Nothing Then
                MsgBox("The binary equivalent of the following ASCII characters could not be calculated." & vbNewLine & vbNewLine & """" & OutInvalid & """", vbInformation)
            End If
        End If
    End Sub
End Module
