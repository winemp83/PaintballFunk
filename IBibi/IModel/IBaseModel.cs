using System.ComponentModel;

namespace IBibi.IModel
{
    public interface IBaseModel : INotifyPropertyChanged
    {
        string ID { get; set; }
    }
}
