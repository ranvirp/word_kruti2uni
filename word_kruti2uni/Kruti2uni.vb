Imports System.Collections.Generic
'using System.Linq;
Imports System.Text

Public Class Kruti2uni
    Private array_one As String()
    Private array_two As String()

    Public Sub New()












        ' one-byte nukta varNas










        '**************************************************************************************
        ' The following two characters are to be replaced through proper checking of locations:
        '**************************************************************************************
        ' "Ô" 
        ' "र्" (reph) 
        '
        ' "×"  or "Û"
        ' "ि"  
        '**************************************************************************************


        'print implode(",",this->array_one); 
        array_one = New String() {"Q+Z", "sas", "aa", ")Z", "ZZ", "ss", "‘k", "’k", _
     "å", "ƒ", "„", "…", "†", "‡", "ˆ", "‰", "Š", "‹", _
     "¶+", "d+", "[+k", "[+", "x+", "T+", "t+", "M+", "<+", "Q+", ";+", "j+", "u+",
     "Ùk", "Ù", "ä", "–", "—", "é", "™", "=kk", "f=k", _
     "à", "á", "â", "ã", "ºz", "º", "í", "{k", "{", "=", "«", _
     "Nî", "Vî", "Bî", "Mî", "<î", "|", "K", "}", _
     "J", "Vª", "Mª", "<ªª", "Nª", "Ø", "Ý", "nzZ", "æ", "ç", "Á", "xz", "#", ":", _
     "v‚", "vks", "vkS", "vk", "v", "b±", "Ã", "bZ", "b", "m", "Å", ",s", ",", "_", _
     "ô", "d", "Dk", "D", "[k", "[", "x", "Xk", "X", "Ä", "?k", "?", "³", _
     "pkS", "p", "Pk", "P", "N", "t", "Tk", "T", ">", "÷", "¥", _
     "ê", "ë", "V", "B", "ì", "ï", "M+", "<+", "M", "<", ".k", ".", _
     "r", "Rk", "R", "Fk", "F", ")", "n", "/k", "èk", "/", "Ë", "è", "u", "Uk", "U", _
     "i", "Ik", "I", "Q", "¶", "c", "Ck", "C", "Hk", "H", "e", "Ek", "E", _
     ";", "¸", "j", "y", "Yk", "Y", "G", "o", "Ok", "O", "'k", "'", """k", """", "l", "Lk", "L", "g", _
     "È", "z",
     "Ì", "Í", "Î", "Ï", "Ñ", "Ò", "Ó", "Ô", "Ö", "Ø", "Ù", "Ük", "Ü", _
     "‚", "ks", "kS", "k", "h", "q", "w", "`", "s", "S", _
     "a", "¡", "%", "W", "•", "·", "∙", "·", "~j", "~", "\\", "+", " ः", _
     "^", "*", "Þ", "ß", "(", "¼", "½", "¿", "À", "¾", "A", "-", "&", "&", "Œ", "]", "~ ", "@"}

        array_two = New String() {"QZ+", "sa", "a", "र्द्ध", "Z", "ss", "ष", "ष", "०", "१", "२", "३", "४", "५", "६", "७", "८", "९", _
"फ़्", "क़", "ख़", "ख़्", "ग़", "ज़्", "ज़", "ड़", "ढ़", "फ़", "य़", "ऱ", "ऩ", "त्त", "त्त्", "क्त", "दृ", "कृ", "न्न", "न्न्", "=k", "f=", _
"ह्न", "ह्य", "हृ", "ह्म", "ह्र", "ह्", "द्द", "क्ष", "क्ष्", "त्र", "त्र्", _
"छ्य", "ट्य", "ठ्य", "ड्य", "ढ्य", "द्य", "ज्ञ", "द्व", _
"श्र", "ट्र", "ड्र", "ढ्र", "छ्र", "क्र", "फ्र", "र्द्र", "द्र", "प्र", "प्र", "ग्र", "रु", "रू", _
"ऑ", "ओ", "औ", "आ", "अ", "ईं", "ई", "ई", "इ", "उ", "ऊ", "ऐ", "ए", "ऋ", _
"क्क", "क", "क", "क्", "ख", "ख्", "ग", "ग", "ग्", "घ", "घ", "घ्", "ङ", _
"चै", "च", "च", "च्", "छ", "ज", "ज", "ज्", "झ", "झ्", "ञ", _
"ट्ट", "ट्ठ", "ट", "ठ", "ड्ड", "ड्ढ", "ड़", "ढ़", "ड", "ढ", "ण", "ण्", _
"त", "त", "त्", "थ", "थ्", "द्ध", "द", "ध", "ध", "ध्", "ध्", "ध्", "न", "न", "न्", _
"प", "प", "प्", "फ", "फ्", "ब", "ब", "ब्", "भ", "भ्", "म", "म", "म्", "य", "य्", "र", "ल", "ल", "ल्", "ळ", "व", "व", "व्", _
"श", "श्", "ष", "ष्", "स", "स", "स्", "ह", _
"ीं", "्र", _
"द्द", "ट्ट", "ट्ठ", "ड्ड", "कृ", "भ", "्य", "ड्ढ", "झ्", "क्र", "त्त्", "श", "श्", _
"ॉ", "ो", "ौ", "ा", "ी", "ु", "ू", "ृ", "े", "ै", _
"ं", "ँ", "ः", "ॅ", "ऽ", "ऽ", "ऽ", "ऽ", "्र", "्", "?", "़", ":", _
"‘", "’", """", """", ";", "(", ")", "{", "}", "=", "।", ".", "-", "µ", "॰", ",", "् ", "/"}

    End Sub
    Private Function Replace_Symbols(ByVal modified_substring As String) As [String]
        'substitute array_two elements in place of corresponding array_one elements
        modified_substring = modified_substring.Replace("±", "Zं")
        modified_substring = modified_substring.Replace("" + Chr(147) + "k", "श")
        modified_substring = modified_substring.Replace("" + Chr(148) + "k", "श")
        modified_substring = modified_substring.Replace("" + Chr(147), "श्")
        modified_substring = modified_substring.Replace("" + Chr(148), "श्")
        modified_substring = modified_substring.Replace("" + Chr(145) + "k", "ष")
        modified_substring = modified_substring.Replace("" + Chr(146) + "k", "ष")
        modified_substring = modified_substring.Replace("" + Chr(145), "ष्")
        modified_substring = modified_substring.Replace("" + Chr(146), "ष्")
        modified_substring = modified_substring.Replace("kW", "ॉ")
        If modified_substring <> "" Then
            ' if stringto be converted is non-blank then no need of any processing.
            For input_symbol_idx As Integer = 0 To array_one.Length - 1


                Dim idx As Integer = 0
                ' index of the symbol being searched for replacement
                While idx <> -1
                    'while-00
                    Dim x As String = array_one(input_symbol_idx)
                    Dim y As String = array_two(input_symbol_idx)

                    modified_substring = modified_substring.Replace(x, y)
                    ' MessageBox.Show(modified_substring[0]);
                    'modified_substring.i
                    'modified_substring.
                    'idx = modified_substring.IndexOf(array_one[input_symbol_idx]);

                    idx = -1
                    ' end of while-00 loop
                    ' alert(" end of while loop")
                End While
            Next
            ' end of for loop
            ' alert(" end of for loop")
            ' alert(" modified substring2 = "+modified_substring)
           
            ' at some places  ì  is  used eg  in "कर्कंधु,पूर्णांक".
            '
            '**********************************************************************************
            ' Glyp2: Æ
            ' code for replacing "f" with "ि" and correcting its position too. (moving it one position forward)
            '**********************************************************************************
            modified_substring = modified_substring.Replace("Æ", "र्f")
            ' at some places  Æ  is  used eg  in "धार्मिक".
            Dim position_of_i As Integer = modified_substring.IndexOf("f")
            Dim sublength As Integer = 0
            Dim f As String = "f"
            ' stringstream ss;
            'http://stackoverflow.com/questions/137487/-1-vs-false-vs-0
            While (position_of_i <> -1) AndAlso (position_of_i + sublength + 1 < modified_substring.Length)
                'while-02
                'print position_of_i.":".modified_substring ."<br>";

                'print position_of_i."<br>";
                position_of_i += sublength
                'print "modified_substring <br>";
                'string charecter_next_to_i;
                '="ल";

                ' string::iterator   w = modified_substring.begin() +position_of_i;
                'uint32_t nextc = utf8::next(w,modified_substring.end());
                'string charecter_next_to_i ;
                'ss<<*w;
                'ss>>charecter_next_to_i;


                ' string charecter_next_to_i = modified_substring.Substring(position_of_i+1 ,3);
                Dim charecter_next_to_i As Char = modified_substring(position_of_i + 1)

                ' string s;
                'ss<<charecter_next_to_i;
                'ss>>s;
                '  s=charecter_next_to_i;
                'string charecter_next_to_i = modified_substring[position_of_i +4];

                'string::iterator  i;

                'string charecter_next_to_i = utf8::next(&modified_substring+position_of_i+1,&modified_substring+position_of_i+2);

                '  cout<<" is character next to i \n " + "ि" + charecter_next_to_i;
                Dim charecter_to_be_replaced As String = f & charecter_next_to_i



                Dim harshi As String = "ि"
                ' harshi.insert(0,1,charecter_next_to_i);
                modified_substring = modified_substring.Replace(charecter_to_be_replaced, charecter_next_to_i & harshi)
                'print "modified_substring <br>";

                Dim x As String = modified_substring.Substring(position_of_i + 1)
                sublength = modified_substring.Length - x.Length
                ' search for i ahead of the current position.
                'print "modified_substring <br>";
                position_of_i = x.IndexOf("f")
            End While
            ' end of while-02 loop
            '**********************************************************************************
            ' Code for Glyph11 : Ø ("िं") 
            ' Code for Glyph12 : Ú ("र्िं")
            '   replace Ú with "िं"  and correcting its position too(moving it two positions forward)
            '**********************************************************************************
            modified_substring = modified_substring.Replace("Ç", "fa")


            ' at some places  Ç  is  used eg  in "किंकर".
            modified_substring = modified_substring.Replace("É", "र्fa")


            ' at some places  É  is  used eg  in "शर्मिंदा"
            position_of_i = modified_substring.IndexOf("fa")
            sublength = 0
            While position_of_i <> -1
                'while-02

                position_of_i += sublength
                Dim charecter_next_to_ip2 As Char = modified_substring(position_of_i + 2)
                Dim charecter_to_be_replaced As String = "fa" & charecter_next_to_ip2
                modified_substring = modified_substring.Replace(charecter_to_be_replaced, charecter_next_to_ip2 & "िं")
                Dim x As String = modified_substring.Substring(position_of_i + 2)
                sublength = modified_substring.Length - x.Length
                ' search for i ahead of the current position.
                position_of_i = x.IndexOf("fa")
            End While
            ' end of while-02 loop

            '**********************************************************************************
            ' End of Code for Replacing four Special glyphs
            '**********************************************************************************

            Dim position_of_wrong_ee As Integer = modified_substring.IndexOf("ि्")
            sublength = 0
            While position_of_wrong_ee <> -1
                'while-03
                position_of_wrong_ee += sublength
                Dim consonent_next_to_wrong_ee As Char = modified_substring(position_of_wrong_ee + 2)
                Dim charecter_to_be_replaced As String = "ि्" & consonent_next_to_wrong_ee
                modified_substring = modified_substring.Replace(charecter_to_be_replaced, "्" & consonent_next_to_wrong_ee & "ि")
                Dim x As String = modified_substring.Substring(position_of_wrong_ee + 2)
                sublength = modified_substring.Length - x.Length
                ' search for 'wrong ee' ahead of the current position. 
                position_of_wrong_ee = x.IndexOf("ि्")
            End While
            ' end of while-03 loop
            '**************************************
            ' 
            '**************************************
            '   alert(modified_substring);
            '**************************************

            ' Eliminating reph "Z" and putting 'half - r' at proper position for this.
            Dim set_of_matras As String = "अ आ इ ई उ ऊ ए ऐ ओ औ ा ि ी ु ू ृ े ै ो ौ ं : ँ ॅ"
            Dim position_of_R As Integer = modified_substring.IndexOf("Z")

            While position_of_R <> -1
                ' while-04
                Dim probable_position_of_half_r As Integer = position_of_R - 1
                Dim charecter_at_probable_position_of_half_r As Char = modified_substring(probable_position_of_half_r)


                ' trying to find non-maatra position left to current O (ie, half -r).

                While set_of_matras.IndexOf(charecter_at_probable_position_of_half_r) <> -1
                    ' while-05
                    probable_position_of_half_r = probable_position_of_half_r - 1

                    charecter_at_probable_position_of_half_r = modified_substring(probable_position_of_half_r)
                End While
                ' end of while-05

                Dim charecter_to_be_replaced As String = modified_substring.Substring(probable_position_of_half_r, (position_of_R - probable_position_of_half_r))
                Dim new_replacement_string As String = "र्" & charecter_to_be_replaced
                charecter_to_be_replaced = charecter_to_be_replaced & "Z"
                modified_substring = modified_substring.Replace(charecter_to_be_replaced, new_replacement_string)



                position_of_R = modified_substring.IndexOf("Z")
                ' end of while-04
            End While
        End If
        ' end of IF  statement  meant to  supress processing of  blank  string.


        Return modified_substring
    End Function
    ' end of the function  Replace_Symbols
    Public Function converter(ByVal input As String) As String
        'input=utf8_encode(input);
        'print "input <br>";
        Dim modified_substring As String
        ' cout<<input;
        '****************************************************************************************
        '  Break the long text into small bunches of max. max_text_size  characters each.
        '****************************************************************************************
        Dim text_size As Integer = input.Length
        ' string processed_text = "";  //blank
        'processed_text=utf8_encode(processed_text);
        '**********************************************
        '    alert("text size = "+text_size);
        '**********************************************

        Dim sthiti1 As Integer = 0
        Dim sthiti2 As Integer = 0
        Dim chale_chalo As Integer = 1

        Dim max_text_size As Integer = 60000

        While chale_chalo = 1
            sthiti1 = sthiti2

            If sthiti2 < (text_size - max_text_size) Then
                sthiti2 += max_text_size
                While input.Substring(sthiti2, 1) <> " "
                    sthiti2 -= 1
                End While
            Else
                sthiti2 = text_size
                chale_chalo = 0
            End If

            '   alert(" sthiti 1 = "+sthiti1); alert(" sthit 2 = "+sthiti2) 

            modified_substring = input.Substring(sthiti1, sthiti2)

            modified_substring = Replace_Symbols(modified_substring)


            '****************************************************************************************
            '  Breaking part code over
            '****************************************************************************************
            '  processed_text = processed_text.replace( /mangal/g , "DVB-TTYogeshEN " ) ;   

            Return modified_substring
        End While
        'print "Final is processed_text<br>";
        Return ""

    End Function

End Class
