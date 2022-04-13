namespace EngineWPF.Model
{
    public class PMR466Model : ModelBase
    {
        private string _Channel;
        private string _Frequenz;
        private string _Description;

        public string Channel
        {
            get => _Channel;
            set => SetProperty(ref _Channel, value);
        }
        public string Frequenz
        {
            get => _Frequenz;
            set => SetProperty(ref _Frequenz, value);
        }
        public string Anmerkung
        {
            get => _Description;
            set => SetProperty(ref _Description, value);
        }
    }
}
