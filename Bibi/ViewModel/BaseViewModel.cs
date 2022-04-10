using IBibi.IViewModel;
using System.Collections.ObjectModel;

namespace Bibi.ViewModel
{
    public abstract class BaseViewModel: IBaseViewModel
    {
        public abstract void Load();
    }

    public abstract class BaseViewModel<T> : BaseViewModel, IBibi.IViewModel.IBaseViewModel<T>
    {
        private ObservableCollection<T> _ValueList;

        public ObservableCollection<T> ValueList
        {
            get => _ValueList;
            set => _ValueList = value;
        }

        public abstract void OnDelete();
        public abstract bool CanExecute();
    }
}
