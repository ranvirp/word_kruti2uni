Imports System.IO 'Working With Files
Imports System.Text 'Working With Text
'iTextSharp Libraries
Imports iTextSharp.text 'Core PDF Text Functionalities
Imports iTextSharp.text.pdf 'PDF Content
Imports iTextSharp.text.pdf.parser 'Content Parser

Public Class PdfWaterMark
 
    Public Shared Sub AddPDFWatermark(ByVal strSource As String, ByVal strDest As String, ByVal imgSource As String)

        Dim pdfFileReader As PdfReader = Nothing 'Read File
        Dim psStamp As PdfStamper = Nothing 'PDF Stamper Object
        Dim imgWaterMark As Image = Nothing 'Watermark Image

        Dim pcbContent As PdfContentByte = Nothing 'Read PDF Content
        Dim rctRect As Rectangle = Nothing 'Create New Rectangle To Host Image

        Dim sngX, sngY As Single 'Page Dimensions

        Dim intPageCount As Integer = 0 'Page Count

        Try
            pdfFileReader = New PdfReader(strSource) 'Read File

            rctRect = pdfFileReader.GetPageSizeWithRotation(1) 'Store Page Size

            psStamp = New PdfStamper(pdfFileReader, New System.IO.FileStream(strDest, FileMode.Create)) 'Create new Stamper Object

            imgWaterMark = Image.GetInstance(imgSource) 'Get Image To Be Used For The Watermark

            If imgWaterMark.Width > rctRect.Width OrElse imgWaterMark.Height > rctRect.Height Then 'Make Sure Image Can Fit On Page

                imgWaterMark.ScaleToFit(rctRect.Width, rctRect.Height)
                sngX = (rctRect.Width - imgWaterMark.ScaledWidth) / 2
                sngY = (rctRect.Height - imgWaterMark.ScaledHeight) / 2

            Else 'Put In Center Of Page

                sngX = (rctRect.Width - imgWaterMark.Width) / 2
                sngY = (rctRect.Height - imgWaterMark.Height) / 2

            End If

            imgWaterMark.SetAbsolutePosition(sngX, sngY)

            intPageCount = pdfFileReader.NumberOfPages() 'Apply To All Pages

            For i As Integer = 1 To intPageCount
                pcbContent = psStamp.GetUnderContent(i)
                pcbContent.AddImage(imgWaterMark)
            Next

            psStamp.Close()
            pdfFileReader.Close()

        Catch ex As Exception

            Throw ex 'Something Went Wrong

        End Try

    End Sub
End Class
