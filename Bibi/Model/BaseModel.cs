using System.ComponentModel;
using IBibi.IModel;
namespace Bibi.Model
{
    public class BaseModel : IBaseModel
    {
        private string _Id;

        public string ID
        {
            get => _Id;
            set
            {
                if(ID != value)
                {
                    _Id = value;
                    RaisePropertyChanged("ID");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
