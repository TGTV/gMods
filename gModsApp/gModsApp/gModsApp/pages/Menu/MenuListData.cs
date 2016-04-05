using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace gModsApp.pages.Menu
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Titel = "Mods",
                Ziel = typeof(Mods)
            });

            this.Add(new MenuItem()
            {
                Titel = "News",
                Ziel = typeof(News)
            });

            this.Add(new MenuItem()
            {
                Titel = "Einstellungen",
                Ziel = typeof(Einstellungen)
            });

        }        
    }
}
