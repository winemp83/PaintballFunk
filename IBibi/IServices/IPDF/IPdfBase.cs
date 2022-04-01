using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBibi.IServices.IPDF
{
    public interface IPdfBase
    {
        PdfWriter Writer { get; set; }
        PdfDocument Pdf { get; set; }
        Document Doc { get; set; }
    }

    public interface IPdfBase<T>
    {
        void Process(Table table, ObservableCollection<T> line);
    }
}
