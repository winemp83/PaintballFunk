using Bibi.Model;
using Bibi.Services.DB;
using Bibi.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bibi.ViewModel
{
    public class PMR466ViewModel : BaseViewModel<PMR466Model>
    {
        private readonly PMR466Database _db;
        private PMR466Model _Value;

        public MyICommand DeleteCommand { get; set; }

        public PMR466Model Value
        {
            get => _Value;
            set
            {
                _Value = value;
                //DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public PMR466ViewModel()
        {
            _db = new PMR466Database
            {
                DBName = "Paintball.db",
                Args = new Dictionary<string, object>()
            };
            Load();
            DeleteCommand = new MyICommand(OnDelete, CanExecute);
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
            _ = new Services.PDF.PMR466Pdf(ref result, "PMR466");
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
