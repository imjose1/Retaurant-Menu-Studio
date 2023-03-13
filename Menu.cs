using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retaurant_Menu_Studio
{
    public class Menu
    {
        public List<MenuItems> Items; { get; set; }
        DateTime Adate; { get; set; }

        public Menu(List<MenuItems> items, DateTime adate)
        {
            Items = items;
            Adate = adate;
        }

        

     
    }
}
