
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkipStack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageD : ContentPage
    {
        public PageD()
        {
            InitializeComponent();
            // Create Button to go directly to PageA.
            Button homeButton = new Button
            {
                Text = "Vamos directo a Home",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            homeButton.Clicked += async (sender, args) =>
            {
                //regresa directo a PageA y limpia la pila de navegacion
                await Navigation.PopToRootAsync();
            };
            // Create Button to swap pages.
            Button swapButton = new Button
            {
                Text = "Swap B and Alt B",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            swapButton.Clicked += async (sender, args) =>
            {
                //accede a la pila de navegacion
                IReadOnlyList<Page> navStack = Navigation.NavigationStack;

                Page pageC = navStack[navStack.Count - 2];
                Page existingPageB = navStack[navStack.Count - 3];
                
                bool isOriginal = existingPageB is PageB;
                Page newPageB = isOriginal ? (Page)new PageBAlt() : new PageB();

                // Swap the pages.
                //removemos la PageB existente e insertamos la nueva PageB antes de C
                Navigation.RemovePage(existingPageB);
                Navigation.InsertPageBefore(newPageB, pageC);
                // Finished: Disable the Button.
                swapButton.IsEnabled = false;
            };

            Title = "Pagina D";
            Content = new StackLayout
            {
                Children =
                {
                    homeButton,
                    swapButton
                }

            };
        }
    }
}