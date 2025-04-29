namespace CookieClicker;

class Program
{
    static CookieService CookieService = new CookieService();


    static void Main(string[] args)
    {
        Thread backgroundThread = new Thread(Background);
        backgroundThread.IsBackground = true;
        backgroundThread.Start();

        Console.WriteLine("Spied SPACE, lai iegūtu cepumu");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                CookieService.Cookies += 1;
            }
            
            if (keyInfo.Key == ConsoleKey.Q)
            {
                Console.WriteLine("Paldies par spēli!");
                return;
            }

            if (keyInfo.Key == ConsoleKey.D1)
            {
                CookieService.BuyItem(new Factory());
            }

            PrintMenu();
        }
    }

    static void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine($"Tagad tev ir {CookieService.Cookies} cepumi!");
        foreach (var item in CookieService.Items)
        {
            Console.WriteLine($"Tev pieder {item.Count} {item.Name}! Jauns maksā {item.Price} cepumus."); 
        }
    }

    static void Background()
    {
        while (true)
        {
            Thread.Sleep(2000);
            CookieService.AddPassiveCookies();
        }
    }
}