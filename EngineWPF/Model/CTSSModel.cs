namespace EngineWPF.Model
{
    public class CTSSModel : ModelBase
    {
        private string _C50;
        private string _C38;
        private string _Ton;

        public string C50
        {
            get => _C50;
            set => SetProperty(ref _C50, value);  
        }
        public string C38
        {
            get => _C38;
            set => SetProperty(ref _C38, value);
        }
        public string Ton
        {
            get => _Ton;
            set => SetProperty(ref _Ton, value);
        }
    }
}
