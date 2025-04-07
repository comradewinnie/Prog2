using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Kubs kubg = new Kubs(10, "zaļa");
        Kubs kubr = new Kubs(1, "sarkana");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"kubg krāsa: {kubg.KrasasNosaukums}.");
        Console.WriteLine($"kubg tilpums: {kubg.AprekinatTilpumu()} cm^2.");
        Console.WriteLine($"kubr malas garums: {kubr.MalasGarums} cm.");
        Console.WriteLine($"kubg malas garums: {kubg.MalasGarums} cm.");
        kubr.Dispose();
        if (kubr == null)
        {
            Console.WriteLine("kubr ir izdzēsts!");
        }
    }
}

public class Kubs : IDisposable
{
    public int MalasGarums;
    public string KrasasNosaukums;

    public Kubs(int malasGarums, string krasasNosaukums)
    {
        if (malasGarums >= 2 || malasGarums <= 10)
        {
            MalasGarums = malasGarums;
        }
        else
        {
            Console.WriteLine("Malas garumam jābūt no 2 līdz 10 cm ieskaitot!");
            Console.WriteLine("Malas garums tika iestatīts uz 2 cm.");
            MalasGarums = 2;
        }

            KrasasNosaukums = krasasNosaukums;
    }

    public int AprekinatTilpumu()
    {
        return MalasGarums * MalasGarums;
    }

    public void Dispose()
    {
        Console.WriteLine("Objekts tika izdzēsts!");
        Console.WriteLine($"Izdzēstā objekta krāsa: {this.KrasasNosaukums}.");
        GC.SuppressFinalize(this);
    }
}