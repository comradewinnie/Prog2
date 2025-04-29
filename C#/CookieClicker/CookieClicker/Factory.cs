using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker;

class Factory : Item
{
    public Factory()
    {
        Name = "Factory";
        Price = 1200;
        Yield = 70;
        PriceMultiplier = 1.6f;
    }
}
