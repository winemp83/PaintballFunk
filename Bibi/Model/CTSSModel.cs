using IBibi.IModel;

namespace Bibi.Model
{
    public class CTSSModel : BaseModel
    {
        private string _Ton; // Ton in Hz
        private string _SC; // Standart Channel

        public string Ton
        {
            get => _Ton;
            set
            {
                if(Ton != value)
                {
                    _Ton = value;
                    RaisePropertyChanged("Ton");
                }
            }
        }
        public string SC
        {
            get => _SC;
            set
            {
                if(SC != value)
                {
                    _SC = value;
                    RaisePropertyChanged("SC");
                }
            }
        }

        public override string ToString()
        {
            return "Channel : "+ID+" | Ton : "+Ton+" | StandartChannel : "+SC;
        }
    }
}
