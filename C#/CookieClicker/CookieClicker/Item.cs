using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker;

abstract class Item
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Count { get; set; }
    public int Yield { get; set; }
    public float PriceMultiplier { get; set; }

    public virtual int GetIncome()
    {
        return Count * Yield;
    }

    public void Buy(ref int cookies)
    {
        if (cookies > Price)
        {
            cookies -= Price;
            Count++;

            Price = (int) (Price * PriceMultiplier);
        }
    }
}