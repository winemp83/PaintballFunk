using System.Collections.ObjectModel;
using Bibi.Model;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Bibi.Services.PDF
{
    public class PMR466Pdf : PdfBase<PMR466Model>
    {
        private static readonly Color lightgrey = new DeviceCmyk(0, 0, 0, 0.20f);

        public PMR466Pdf(ref ObservableCollection<PMR466Model> value, string fileName)
        {
            Writer = new PdfWriter(fileName+".pdf");
            Pdf = new PdfDocument(Writer);
            Doc = new Document(Pdf, PageSize.A4);
            Doc.SetMargins(20, 20, 20, 20);
            Table table = new Table(new float[] { 1, 1, 1 });
            table.SetWidth(UnitValue.CreatePercentValue(100));
            PMR466Pdf.Process(table, value);
            Doc.Add(new Paragraph("PMR466 Tabelle").SetVerticalAlignment(VerticalAlignment.MIDDLE).SetHorizontalAlignment(HorizontalAlignment.CENTER));
            Doc.Add(table);
            Doc.Close();
        }

        private static new void Process(Table table, ObservableCollection<PMR466Model> value)
        {
            Color bg;
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.COURIER);
            table.AddCell(new Cell().Add(new Paragraph("Channel").SetFontSize(9).SetBold().SetItalic().SetUnderline().SetFont(font)));
            table.AddCell(new Cell().Add(new Paragraph("Frequenz").SetFontSize(9).SetBold().SetItalic().SetUnderline().SetFont(font)));
            table.AddCell(new Cell().Add(new Paragraph("Anmerkung").SetFontSize(9).SetBold().SetItalic().SetUnderline().SetFont(font)));
            foreach (PMR466Model item in value)
            {
                bg = lightgrey;
                table.AddCell(new Cell().Add(new Paragraph(item.ID).SetFontSize(8).SetFont(font)).SetBackgroundColor(bg));
                table.AddCell(new Cell().Add(new Paragraph(item.Frequenz).SetFontSize(8).SetFont(font)));
                table.AddCell(new Cell().Add(new Paragraph(item.Anmerkung).SetFontSize(8).SetFont(font)).SetBackgroundColor(bg));
            }

        }
    }
}
