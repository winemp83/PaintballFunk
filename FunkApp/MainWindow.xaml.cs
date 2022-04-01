using FunkApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FunkApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CTSSViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            Bibi.ViewModel.CTSSViewModel cTSSViewModelObject = new Bibi.ViewModel.CTSSViewModel();
            CTSSViewControl.DataContext = cTSSViewModelObject;
        }

        private void PMR466ViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            Bibi.ViewModel.PMR466ViewModel cTSSViewModelObject = new Bibi.ViewModel.PMR466ViewModel();
            PMR466ViewControl.DataContext = cTSSViewModelObject;
        }
    }
}
