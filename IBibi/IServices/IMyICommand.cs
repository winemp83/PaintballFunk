using System.Windows.Input;

namespace IBibi.IServices
{
    internal interface IMyICommand : ICommand
    {
        bool RaiseCanExecuteChanged();

    }
}
