using EngineWPF.Model;
using System.Collections.ObjectModel;


namespace EngineWPF.ViewModel
{
    public class CTSSViewModel : ViewModelBase<CTSSModel>
    {
        public CTSSViewModel()
        {
            Load();
        }

        private void Load() {
            Value = new CTSSModel();
            Values = new ObservableCollection<CTSSModel>
            {
                new CTSSModel
                {
                    ID = "1",
                    C50 = "1",
                    C38 = "1",
                    Ton = "67,0"
                },
                new CTSSModel
                {
                    ID = "2",
                    C50 = "2",
                    C38 = "0",
                    Ton = "69,3"
                },
                new CTSSModel
                {
                    ID = "3",
                    C50 = "3",
                    C38 = "2",
                    Ton = "71,9"
                }
            };
        }
    }
}
