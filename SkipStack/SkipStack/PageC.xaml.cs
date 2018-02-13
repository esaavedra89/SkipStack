
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkipStack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageC : ContentPage
    {
        public PageC()
        {
            InitializeComponent();
            Button button = new Button
            {
                Text = "Vamos a Pagina D",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new PageD());
            };

            Title = "Pagina C";
            Content = button;
        }
    }
}