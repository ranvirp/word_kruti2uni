Imports Microsoft.Office.Interop
Imports System.Reflection
Imports System.IO



Module Module1

    Sub Main()
        Dim kr As Kruti2uni
        kr = New Kruti2uni()
        Dim out As String
        out = kr.converter("ch0ih0,y0 jk'ku dkMZ")
        'Console.OutputEncoding = Text.Encoding.Unicode
        PdfWaterMark.AddPDFWatermark("d:/dtest1.pdf", "d:/test_watermark.pdf", "d:/watermarkimages.jpg")
        Dim fs As FileStream
        fs = New FileStream("d:/dtest1.pdf", FileMode.Open)
        out = PdfExtractText.getText(fs)
        out = kr.converter(out)
        Console.WriteLine(out)
    End Sub

End Module
