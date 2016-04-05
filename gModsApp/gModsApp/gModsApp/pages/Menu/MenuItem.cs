using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace gModsApp.pages.Menu
{
    public class MenuItem
    {
        public string Titel { get; set; }

        public Type Ziel { get; set; }
    }
}
