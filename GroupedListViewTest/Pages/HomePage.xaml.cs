using GroupedListViewTest.ViewModels;
using Xamarin.Forms;

namespace GroupedListViewTest.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
    }
}
