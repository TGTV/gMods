using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//Loginauswahl

namespace gModsApp
{
    class start : MasterDetailPage
    {

        public start()
        { 
            
            Label header = new Label
            {

                Text = "gMods",

                HorizontalOptions = LayoutOptions.Center
            };

            Button buttonan = new Button
            {
                Text = "Anmelden",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Button buttonreg = new Button
            {
                Text = "Registrieren",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            //Anzeige

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
                        buttonan,
                        buttonreg,
                    }
                }
            };
          


        }
    }
}
