﻿using System.Windows.Controls;

using MahApps.Metro.Controls;

using Wpf.App.Contracts.Views;
using Wpf.App.ViewModels;

namespace Wpf.App.Views
{
    public partial class ShellWindow : MetroWindow, IShellWindow
    {
        public ShellWindow(ShellViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        public Frame GetNavigationFrame()
            => shellFrame;

        public void ShowWindow()
            => Show();

        public void CloseWindow()
            => Close();
    }
}
