using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBibi.IViewModel
{
    public interface IBaseViewModel
    {
        void Load();
    }
    public interface IBaseViewModel<T>
    {
        ObservableCollection<T> ValueList { get; set; }
        void OnDelete();
        bool CanExecute();
    }
}
