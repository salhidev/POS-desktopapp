Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf


Public Class Form1
    Dim ds As New DataSet
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cn As New SqlConnection("SERVER=ABOUDAHAB-PC; INITIAL CATALOG=IN5_CAISSE;integrated security=true")
        cn.Open()
        Dim da As New SqlDataAdapter("select * from caissier", cn)
        da.Fill(ds, "caissier")
        DataGridView1.DataSource = ds.Tables("caissier")
      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim doc As New Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35)
        Try
            Dim pdfFilePath As String = Directory.GetCurrentDirectory & "\myPdf.pdf"
            Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(pdfFilePath, FileMode.Create))

            doc.Open()

            Dim font8 As Font = FontFactory.GetFont("ARIAL", 7)

            Dim paragraph As New Paragraph("Liste des Caissier")
            paragraph.Alignment = 1

            Dim dt As DataTable = ds.Tables("caissier")

            If dt IsNot Nothing Then
                Dim PdfTable As New PdfPTable(dt.Columns.Count)

                Dim pdfpcell As PdfPCell = Nothing

                For column As Integer = 0 To dt.Columns.Count - 1

                    pdfpcell = New PdfPCell(New Phrase(New Chunk(dt.Columns(column).ColumnName, font8)))
                    pdfpcell.BackgroundColor = BaseColor.GRAY
                    pdfpcell.BorderWidth = 1

                    PdfTable.AddCell(pdfpcell)

                Next

                For rows As Integer = 0 To dt.Rows.Count - 1
                    For column As Integer = 0 To dt.Columns.Count - 1

                        pdfpcell = New PdfPCell(New Phrase(New Chunk(dt.Rows(rows)(column).ToString(), font8)))
                        PdfTable.AddCell(pdfpcell)
                    Next
                Next
                PdfTable.SpacingBefore = 15.0F
                doc.Add(paragraph)
                doc.Add(PdfTable)

                Process.Start(Directory.GetCurrentDirectory & "\myPdf.pdf")

            End If

        Catch docex As DocumentException
        Catch ioex As IOException
        Catch ex As Exception
        Finally
            doc.Close()

        End Try

    End Sub
End Class
