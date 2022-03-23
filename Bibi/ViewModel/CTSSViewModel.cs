using Bibi.Model;
using System.Collections.ObjectModel;
using Bibi.Services.DB;
using System.Collections.Generic;

namespace Bibi.ViewModel
{
    public class CTSSViewModel : BaseViewModel<CTSSModel>
    {
        private readonly CTSSDatabase _db;
        public CTSSViewModel()
        {
            _db = new CTSSDatabase
            {
                DBName = "Paintball.db",
                Args = new Dictionary<string, object>()
            };
            Load();
        }

        public override void Load()
        {
            Value = new CTSSModel();
            ValueList = new ObservableCollection<CTSSModel>();
            ValueList = _db.Get();
        }

        public ObservableCollection<CTSSModel> CTSS38()
        {
            ObservableCollection<CTSSModel> result = new ObservableCollection<CTSSModel>();
            foreach(CTSSModel model in ValueList)
            {
                if(!model.SC.Equals("0"))
                    result.Add(model);
            }
            return result;
        }
        public void CreatePDFCTSS38()
        {
            ObservableCollection<CTSSModel> result = new ObservableCollection<CTSSModel>();
            result = CTSS38();
            Services.PDF.CTSSPdf pdf = new Services.PDF.CTSSPdf(ref result, "CTSS38");
        }
        public void CreatePDFCTSS()
        {
            ObservableCollection<CTSSModel> result = ValueList;
            Services.PDF.CTSSPdf pdf = new Services.PDF.CTSSPdf(ref result, "CTSS");
        }
    }
}
