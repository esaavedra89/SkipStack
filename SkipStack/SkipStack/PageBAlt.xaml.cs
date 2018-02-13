using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkipStack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageBAlt : ContentPage
    {
        public PageBAlt()
        {
            InitializeComponent();
            Button button = new Button
            {
                Text = "Vamos a Pagina C",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new PageC());
            };

            Title = "Pagina B Alt";
            Content = button;
        }
    }
}