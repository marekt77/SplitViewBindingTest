using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SplitViewBindingTest.Interfaces;
using SplitViewBindingTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SplitViewBindingTest.ViewModels
{
    public class OtherPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public OtherPageViewModel(INavigationService navService)
        {
            _navigationService = navService;
        }

        private ICommand _HomePageCommand;
        public ICommand HomePageCommand
        {
            get
            {
                return _HomePageCommand ??
                    new RelayCommand(() =>
                    {
                        _navigationService.Navigate(typeof(HomePage));
                    });
            }
        }

        private ICommand _SplitViewPageCommand;
        public ICommand SplitViewPageCommand
        {
            get
            {
                return _SplitViewPageCommand ??
                    new RelayCommand(() =>
                    {
                        _navigationService.Navigate(typeof(SplitViewPage));
                    });
            }
        }
    }
}
