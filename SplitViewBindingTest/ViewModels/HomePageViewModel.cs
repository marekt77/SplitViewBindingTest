using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SplitViewBindingTest.Interfaces;
using SplitViewBindingTest.Views;
using System.Windows.Input;

namespace SplitViewBindingTest.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        
        public HomePageViewModel(INavigationService navService)
        {
            _navigationService = navService;
        }

        private ICommand _OtherPageCommand;
        public ICommand OtherPageCommand
        {
            get
            {
                return _OtherPageCommand ??
                    new RelayCommand(() =>
                    {
                        _navigationService.Navigate(typeof(OtherPage));
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
