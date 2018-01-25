using SplitViewBindingTest.ViewModels;
using Windows.UI.Xaml.Controls;

namespace SplitViewBindingTest.Views
{
    public sealed partial class SplitViewPage : Page
    {
        SplitViewPageViewModel mySplitVM { get; set; }

        public SplitViewPage()
        {
            this.InitializeComponent();
            ViewModelLocator myVML = new ViewModelLocator();

            mySplitVM = myVML.SplitVM;
        }
    }
}
