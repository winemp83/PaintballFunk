namespace Bibi.Model
{
    public class PMR466Model :BaseModel
    {
        private string _Freq; // Frequenz 
        private string _Anme; // Anmerkungen

        public string Frequenz
        {
            get => _Freq;
            set
            {
                if(Frequenz != value)
                {
                    _Freq = value;
                    RaisePropertyChanged("Frequenz");
                }
            }
        }
        public string Anmerkung
        {
            get => _Anme;
            set
            {
                if (Anmerkung != value)
                {
                    _Anme = value;
                    RaisePropertyChanged("Anmerkung");
                }
            }
        }

        public override string ToString()
        {
            return "Channel : "+ID+" | Frequenz : "+Frequenz+" | Anmerkung : "+Anmerkung;
        }
    }
}
