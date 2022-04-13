using System.Collections.ObjectModel;
using EngineWPF.Model;

namespace EngineWPF.ViewModel
{
    public class ViewModelBase: ModelBase
    {
         
    }
    public class ViewModelBase<T> : ViewModelBase
    {
        private T _Value;
        private ObservableCollection<T> _ValueList;

        public T Value
        {
            get => _Value;
            set => SetProperty(ref _Value, value);
        }

        public ObservableCollection<T> Values
        {
            get => _ValueList;
            set => SetProperty(ref _ValueList, value);
        }
    }
}
