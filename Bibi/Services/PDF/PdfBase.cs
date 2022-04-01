using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Collections.ObjectModel;

namespace Bibi.Services.PDF
{
    public abstract class PdfBase
    {
        public PdfWriter Writer { get; set; }
        public PdfDocument Pdf { get; set; }
        public Document Doc { get; set; }
    }
    public abstract class PdfBase<T> : PdfBase
    {
        public void Process(Table table, ObservableCollection<T> line)
        {
            foreach (T item in line)
            {
                table.AddCell(new Cell().Add(new Paragraph(item.ToString())));
            }
        }
    }
}
