using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BPFunk.Views
{
    public partial class AboutPage : ContentView
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://aka.ms/xamarin-quickstart");
        }
    }
}