using EngineWPF.Model;
using EngineWPF.Service;
using System.Collections.ObjectModel;

namespace EngineWPF.ViewModel
{
    public class PMR466ViewModel : ViewModelBase<PMR466Model>
    {
        private MyICommand AddCommand;
        private MyICommand EditCommand;

        public PMR466ViewModel()
        {
            Load();
        }

        private void Load()
        {
            AddCommand = new MyICommand(OnSave);
            EditCommand = new MyICommand(OnEdit, CanEdit);

            Value = new PMR466Model();

            Values = new ObservableCollection<PMR466Model>
            {
                new PMR466Model
                {
                    ID = "1",
                    Channel = "1",
                    Frequenz = "446,00625",
                    Anmerkung = "Bei Dreikanal-PMR-Funken Channel 1"
                },
                new PMR466Model
                {
                    ID = "2",
                    Channel = "2",
                    Frequenz = "446,01875",
                    Anmerkung = "Wanderer, Bergsteiger und Geocaching-Kanal"
                },
                new PMR466Model
                {
                    ID = "3",
                    Channel = "3",
                    Frequenz = "446,03125",
                    Anmerkung = "PMR Prepper-Kanal"
                }
            };
        }
        private void OnSave() { 
        
        }
        private void OnEdit() {

        }
        private bool CanEdit() {
            if (Value != null && string.IsNullOrEmpty(Value.ID))
                return true;
            return false;
        }
    }
}
