using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SplitViewBindingTest.Interfaces;
using SplitViewBindingTest.Services;

namespace SplitViewBindingTest.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<INavigationService, NavigationService>();

            SimpleIoc.Default.Register<HomePageViewModel>();
            SimpleIoc.Default.Register<OtherPageViewModel>();
            SimpleIoc.Default.Register<SplitViewPageViewModel>();

        }

        public HomePageViewModel HomeVM => ServiceLocator.Current.GetInstance<HomePageViewModel>();
        public OtherPageViewModel OtherVM => ServiceLocator.Current.GetInstance<OtherPageViewModel>();
        public SplitViewPageViewModel SplitVM => ServiceLocator.Current.GetInstance<SplitViewPageViewModel>();
    }
}
