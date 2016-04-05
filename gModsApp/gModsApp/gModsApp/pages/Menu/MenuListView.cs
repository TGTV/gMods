using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace gModsApp.pages.Menu
{
    public class MenuListView : ListView
    {
      public MenuListView()
      {
            List<MenuItem> data = new MenuListData();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;

            var cell = new DataTemplate(typeof(MenuCell));              //Holt sich den shit aus der MenuCell
            cell.SetBinding(MenuCell.TextProperty, "Titel");

            ItemTemplate = cell;
      }  
    }
}
