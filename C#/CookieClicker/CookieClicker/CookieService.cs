using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker;
class CookieService
{
    public List<Item> Items = new List<Item>();
    public int Cookies = 0;

    public CookieService()
    {
        Items.Add(new Factory());
    }

    public void BuyItem(Item item)
    {
        var itemToBuy = Items.FirstOrDefault(x => x.Name == item.Name);
        if (itemToBuy != null)
        {
            itemToBuy.Buy(ref Cookies);
        }
    }

    public void AddPassiveCookies()
    {
        foreach (var item in Items)
        {
            Cookies += item.GetIncome();
        }
    }
}