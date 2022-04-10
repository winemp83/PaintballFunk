using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibi.Model
{
    public class FavModel : BaseModel
    {
        private string _Name;
        private string _Anmerkungen;
        private string _PID;
        private string _CID;

        public string Name
        {
            get => _Name;
            set
            {
                if(Name != value)
                {
                    _Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }
        public string PID
        {
            get => _PID;
            set
            {
                if(PID != value)
                {
                    _PID = value;
                    RaisePropertyChanged("PID");
                }
            }
        }
        public string CID
        {
            get => _CID;
            set
            {
                if(CID != value)
                {
                    _CID = value;
                    RaisePropertyChanged("CID");
                }
            }
        }
        public string Anmerkung
        {
            get => _Anmerkungen;
            set
            {
                if(Anmerkung != value)
                {
                    _Anmerkungen = value;
                    RaisePropertyChanged("Anmerkung");
                }
            }
        }
    }
}
