

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkipStack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageA : ContentPage
    {
        public PageA()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PageB());
        }

        /*private void Button_Clicked_1(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new XamlClockPage());
        }*/
    }
}