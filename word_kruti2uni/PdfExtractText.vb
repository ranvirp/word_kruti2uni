Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Public Class PdfExtractText
    Public Shared Function getText(ByVal pdfSource As System.IO.FileStream) As String
        Dim text As New System.Text.StringBuilder
        Dim pdfReader As New PdfReader(pdfSource)
        Try
            For page As Integer = 1 To pdfReader.NumberOfPages
                Dim strategy As New SimpleTextExtractionStrategy
                Dim currentText As String
                currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy)
                text.Append(System.Environment.NewLine)
                currentText = System.Text.Encoding.UTF8.GetString(System.Text.ASCIIEncoding.Convert(System.Text.Encoding.Default, System.Text.Encoding.UTF8, System.Text.Encoding.Default.GetBytes(currentText)))
                text.Append(currentText)
            Next
            getText = text.ToString()


        Catch ex As Exception
            Throw ex
            getText = ""
        End Try
    End Function
End Class
