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
        Price = 120;
        Yield = 7;
        PriceMultiplier = 1.6f;
    }
}
