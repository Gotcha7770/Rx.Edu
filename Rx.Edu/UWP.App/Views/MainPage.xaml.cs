using System;

using UWP.App.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWP.App.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
