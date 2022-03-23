using Bibi.Model;
using Bibi.Services.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibi.ViewModel
{
    public class PMR466ViewModel : BaseViewModel<Model.PMR466Model>
    {
        private readonly PMR466Database _db;

        public PMR466ViewModel()
        {
            _db = new PMR466Database
            {
                DBName = "Paintball.db",
                Args = new Dictionary<string, object>()
            };
            Load();
        }
        public override void Load()
        {
            Value = new PMR466Model();
            ValueList = new ObservableCollection<PMR466Model>();
            ValueList = _db.Get();
        }
        public void CreatePDF()
        {
            ObservableCollection<PMR466Model> result = ValueList;
            Services.PDF.PMR466Pdf pdf = new Services.PDF.PMR466Pdf(ref result, "PMR466");
        }
    }
}
