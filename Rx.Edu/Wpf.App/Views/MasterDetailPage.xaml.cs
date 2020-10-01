using System.Windows.Controls;

using Wpf.App.ViewModels;

namespace Wpf.App.Views
{
    public partial class MasterDetailPage : Page
    {
        public MasterDetailPage(MasterDetailViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
