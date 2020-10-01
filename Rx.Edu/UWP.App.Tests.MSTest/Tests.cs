using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using UWP.App.ViewModels;

namespace UWP.App.Tests.MSTest
{
    // TODO WTS: Add appropriate tests
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        // TODO WTS: Add tests for functionality you add to MainViewModel.
        [TestMethod]
        public void TestMainViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new MainViewModel();
            Assert.IsNotNull(vm);
        }

        // TODO WTS: Add tests for functionality you add to TreeViewViewModel.
        [TestMethod]
        public void TestTreeViewViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new TreeViewViewModel();
            Assert.IsNotNull(vm);
        }
    }
}
