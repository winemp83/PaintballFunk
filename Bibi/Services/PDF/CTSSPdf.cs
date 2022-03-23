using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibi.Model;
using iText;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Bibi.Services.PDF
{
    public class CTSSPdf : PdfBase<Model.CTSSModel>
    {
        public CTSSPdf(ref ObservableCollection<CTSSModel> value, string fileName)
        {
            Writer = new PdfWriter(fileName+".pdf");
            Pdf = new PdfDocument(Writer);
            Doc = new Document(Pdf, PageSize.A4);
            Doc.SetMargins(20, 20, 20, 20);
            Table table = new Table(new float[] {1, 1 , 1});
            table.SetWidth(UnitValue.CreatePercentValue(100));
            CTSSPdf.Process(table,value);
            Doc.Add(table);
            Doc.Close();

        }

        private static new void Process(Table table,ObservableCollection<CTSSModel> value)
        {
            table.AddCell(new Cell().Add(new Paragraph("Channel")));
            table.AddCell(new Cell().Add(new Paragraph("Ton")));
            table.AddCell(new Cell().Add(new Paragraph("Standart Channel")));
            foreach (CTSSModel item in value)
            {
                table.AddCell(new Cell().Add(new Paragraph(item.ID)));
                table.AddCell(new Cell().Add(new Paragraph(item.Ton)));
                table.AddCell(new Cell().Add(new Paragraph(item.SC)));
            }

        }
    }
}
