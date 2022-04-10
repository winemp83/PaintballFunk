using Bibi.Model;
using System.Collections.ObjectModel;
using Bibi.Services.DB;
using System.Collections.Generic;
using Bibi.Services;
using IBibi.IViewModel;
using IBibi.IModel;

namespace Bibi.ViewModel
{
    public class CTSSViewModel : BaseViewModel<CTSSModel>
    {
        private readonly CTSSDatabase _db;
        private CTSSModel _Value;

        public CTSSModel Value
        {
            get => _Value;
            set
            {
                _Value = value;
                //DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public MyICommand DeleteCommand { get; set; }

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
            Value = null;
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
            _ = new ObservableCollection<CTSSModel>();
            ObservableCollection<CTSSModel> result = CTSS38();
            _ = new Services.PDF.CTSSPdf(ref result, "CTSS38");
        }
        public void CreatePDFCTSS()
        {
            ObservableCollection<CTSSModel> result = ValueList;
            _ = new Services.PDF.CTSSPdf(ref result, "CTSS");
        }
        public void CreatePDF()
        {
            Services.PDF.CTSSPdf.CreatePDF("CTSS", "CTSS38");
        }

        public override void OnDelete()
        {
            ValueList.Remove(Value);
            Value = null;
        }

        public override bool CanExecute()
        {
            return Value != null;
        }
    }
}
