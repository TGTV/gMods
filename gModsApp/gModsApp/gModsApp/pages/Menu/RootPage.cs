using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace gModsApp.pages.Menu
{
    public class RootPage : MasterDetailPage
    {

        MenuPage menuPage;

        public RootPage()
        {
            menuPage = new MenuPage();

            menuPage.Menu.ItemSelected +=
                (sender, e) => NavigatTo(e.SelectedItem as MenuItem);

            Master = menuPage;

            Detail = new NavigationPage(new start());

        }

        async void NavigatTo(MenuItem menu)
        {
            if (menu == null)
                return;

            Page displayPage = (Page)Activator.CreateInstance(menu.Ziel);

            try
            {
                Detail = new NavigationPage(displayPage);
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("ERROR", "Error:" +ex.Message, "OK");
            }

            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }
}
