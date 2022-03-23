using System.Collections.ObjectModel;

namespace Bibi.ViewModel
{
    public abstract class BaseViewModel
    {
        public abstract void Load();
    }

    public abstract class BaseViewModel<T> : BaseViewModel
    {
        private T _Value;
        private ObservableCollection<T> _ValueList;

        public T Value
        {
            get => _Value;
            set => _Value = value;
        }
        public ObservableCollection<T> ValueList
        {
            get => _ValueList;
            set => _ValueList = value;
        }

        public void Add(T value)
        {
            ValueList.Add(value);
        }
        public void Delete(T value)
        {
            ValueList.Remove(value);
        }        
    }
}
