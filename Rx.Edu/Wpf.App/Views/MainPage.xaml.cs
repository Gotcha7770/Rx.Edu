using System.Windows.Controls;

using Wpf.App.ViewModels;

namespace Wpf.App.Views
{
    public partial class MainPage : Page
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
