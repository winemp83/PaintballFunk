using Bibi.Model;
using Bibi.Services.DB;
using Bibi.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bibi.ViewModel
{
    public class FavViewModel : BaseViewModel<FavModel>
    {
        private readonly FavDatabase _db;
        private FavModel _Value;

        public FavModel Value
        {
            get => _Value;
            set => _Value = value;
        }

        public FavViewModel() {
            _db = new FavDatabase
            {
                DBName = "Paintball.db",
                Args = new Dictionary<string, object>()
            };
            Load();
        }

        public override bool CanExecute()
        {
            return Value != null;
        }

        public override void Load()
        {
            Value = new FavModel();
            ValueList = new ObservableCollection<FavModel>();
            ValueList = _db.Get();
        }

        public override void OnDelete()
        {
            _db.Delete(Value);
            Load();
        }

        public void Insert()
        {
            _db.Add(Value);
            Load();
        }

        public void Update()
        {
            _db.Update(Value);
            Load();
        }
    }
}
