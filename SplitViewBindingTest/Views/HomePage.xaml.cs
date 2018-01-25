using SplitViewBindingTest.ViewModels;
using Windows.UI.Xaml.Controls;

namespace SplitViewBindingTest.Views
{
    public sealed partial class HomePage : Page
    {
        HomePageViewModel myHomeVM { get; set; }

        public HomePage()
        {
            this.InitializeComponent();
            ViewModelLocator myVML = new ViewModelLocator();

            myHomeVM = myVML.HomeVM;
        }
    }
}
