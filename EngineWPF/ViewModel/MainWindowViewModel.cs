using EngineWPF.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineWPF.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly CTSSViewModel cTSSViewModel = new CTSSViewModel();
        private readonly PMR466ViewModel pMR466ViewModel = new PMR466ViewModel();
        private ViewModelBase _CurrentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _CurrentViewModel;
            set => SetProperty(ref _CurrentViewModel, value);
        }

        public MainWindowViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
        }

        public MyICommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {
            CurrentViewModel =destination switch
            {
                "ctss" => cTSSViewModel,
                _ => pMR466ViewModel,
            };
        }
    }
}
