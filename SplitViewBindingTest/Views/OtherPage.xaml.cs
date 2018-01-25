using SplitViewBindingTest.ViewModels;
using Windows.UI.Xaml.Controls;

namespace SplitViewBindingTest.Views
{
    public sealed partial class OtherPage : Page
    {
        OtherPageViewModel OtherVM { get; set; }

        public OtherPage()
        {
            this.InitializeComponent();
            ViewModelLocator myVML = new ViewModelLocator();

            OtherVM = myVML.OtherVM;
        }
    }
}
