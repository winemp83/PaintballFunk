using System;
using System.Collections.ObjectModel;
using Bibi.Model;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Bibi.Services.PDF
{
    public class CTSSPdf : PdfBase<Model.CTSSModel>
    {
        private static readonly Color lightgrey = new DeviceCmyk(0, 0, 0, 0.20f);
        private static readonly Color lightred = new DeviceCmyk(0, 0.58f, 0.41f, 0);

        public CTSSPdf(ref ObservableCollection<CTSSModel> value, string fileName)
        {
            Writer = new PdfWriter(fileName+".pdf");
            Pdf = new PdfDocument(Writer);
            Doc = new Document(Pdf, PageSize.A4);
            Doc.SetMargins(20, 20, 20, 20);
            Table table = new Table(new float[] {1, 1 , 1});
            table.SetWidth(UnitValue.CreatePercentValue(100));
            CTSSPdf.Process(table,value);
            Doc.Add(new Paragraph("CTSS Tabelle").SetVerticalAlignment(VerticalAlignment.MIDDLE).SetHorizontalAlignment(HorizontalAlignment.CENTER));
            Doc.Add(table);
            Doc.Close();
        }

        private static new void Process(Table table,ObservableCollection<CTSSModel> value)
        {
            Color bg;
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.COURIER);
            table.AddCell(new Cell().Add(new Paragraph("Channel").SetFontSize(9).SetBold().SetItalic().SetUnderline().SetFont(font)));
            table.AddCell(new Cell().Add(new Paragraph("Ton").SetFontSize(9).SetBold().SetItalic().SetUnderline().SetFont(font)));
            table.AddCell(new Cell().Add(new Paragraph("Standart Channel").SetFontSize(9).SetBold().SetItalic().SetUnderline().SetFont(font)));
            foreach (CTSSModel item in value)
            {
                if (item.SC.Equals("0"))
                {
                    bg = lightred;
                }
                else
                {
                    bg = lightgrey;
                }
                table.AddCell(new Cell().Add(new Paragraph(item.ID).SetFontSize(8).SetFont(font)).SetBackgroundColor(bg));
                table.AddCell(new Cell().Add(new Paragraph(item.Ton).SetFontSize(8).SetFont(font)));
                table.AddCell(new Cell().Add(new Paragraph(item.SC).SetFontSize(8).SetFont(font)).SetBackgroundColor(bg));
            }

        }

        public static void CreatePDF(string fileOne, string fileTwo)
        {
            string document1 = AppDomain.CurrentDomain.BaseDirectory + fileOne + ".pdf";
            string document2 = AppDomain.CurrentDomain.BaseDirectory + fileTwo + ".pdf";
            string target = AppDomain.CurrentDomain.BaseDirectory + "CTSSFinal.pdf";
            PdfDocument pdf = new PdfDocument(new PdfWriter(target));
            PdfMerger merger = new PdfMerger(pdf);

            //Add pages from the first document
            PdfDocument firstSourcePdf = new PdfDocument(new PdfReader(document1));
            merger.Merge(firstSourcePdf, 1, firstSourcePdf.GetNumberOfPages());

            //Add pages from the second pdf document
            PdfDocument secondSourcePdf = new PdfDocument(new PdfReader(document2));
            merger.Merge(secondSourcePdf, 1, secondSourcePdf.GetNumberOfPages());

            firstSourcePdf.Close();
            secondSourcePdf.Close();
            pdf.Close();

        }
    }
}
