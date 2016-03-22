using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace gModsApp
{
    class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            Label header = new Label
            {
                Text = "Mods",
                HorizontalOptions = LayoutOptions.Center
            };

            string[] testdaten =
            {
                "1",
                "2",
                "3"
            };

            ListView list = new ListView
            {
                ItemsSource = testdaten
            };
            this.Detail = new NavigationPage();
            this.Master = new ContentPage
            {
                Title = header.Text,
                Content = new StackLayout
                {
                    Spacing = 10,
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        header,
                        list
                    }
                }
            };

        }
    }
}
