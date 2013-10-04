Imports Microsoft.Office.Interop
Imports System.Reflection
Imports System.IO



Module Module1

    Sub Main()
        Dim kr As Kruti2uni
        kr = New Kruti2uni()
        Dim out As String
        out = kr.converter(" fo'ks""k")
        'Console.OutputEncoding = Text.Encoding.Unicode
        '   PdfWaterMark.AddPDFWatermark("C:\Users\acer\Desktop\GO\VIJAY.pdf", "C:\Users\acer\Desktop\GO\VIJAY_watermark.pdf", "d:/watermarkimages.jpg")
        Dim fs As FileStream
        fs = New FileStream("C:\Users\acer\Desktop\GO\VIJAY.pdf", FileMode.Open)
        out = PdfExtractText.getText(fs)
        out = kr.converter(out)
        Console.WriteLine(out)
    End Sub

End Module
