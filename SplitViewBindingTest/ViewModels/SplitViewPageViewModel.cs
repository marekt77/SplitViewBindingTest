using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SplitViewBindingTest.Interfaces;
using SplitViewBindingTest.Views;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace SplitViewBindingTest.ViewModels
{
    public class SplitViewPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public SplitViewPageViewModel(INavigationService navService)
        {
            _navigationService = navService;
            PanelPage = new Views.PanelPage();
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

        private Page _PanelPage;
        public Page PanelPage
        {
            get
            {
                return _PanelPage;
            }
            set
            {
                _PanelPage = value;
                RaisePropertyChanged("PanelPage");
            }
        }
    }
}
