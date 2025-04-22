class Program
{
    static void Main(string[] args)
    {
        SakumskolasSkolotajs sakumskolasSkolotajs1 = new SakumskolasSkolotajs();
        sakumskolasSkolotajs1.IevaditDatus();
        sakumskolasSkolotajs1.DefinetTipaNosaukumu();
        sakumskolasSkolotajs1.IzdrukatDatus();

        VidusskolasSkolotajs vidusskolasSkolotajs1 = new VidusskolasSkolotajs();
        vidusskolasSkolotajs1.IevaditDatus();
        vidusskolasSkolotajs1.DefinetTipaNosaukumu();
        vidusskolasSkolotajs1.IzdrukatDatus();
    }
}

class Skolotajs
{
    public int StunduSkaitsNedela;
    public int SkolotajaTips;
    public string Uzvards;
    public string Klase;

    public string TipaNosaukums;

    public void DefinetTipaNosaukumu()
    {
        if (SkolotajaTips == 1)
        {
            TipaNosaukums = "Sākumskolas";
        }
        if (SkolotajaTips == 3)
        {
            TipaNosaukums = "Vidusskolas";
        }
    }
}

class SakumskolasSkolotajs : Skolotajs
{
    new public int SkolotajaTips = 1;

    public void IevaditDatus()
    {
        Console.WriteLine("Ievadiet sākumskolas skolotāja uzvārdu:");
        Uzvards = Console.ReadLine();

        Console.WriteLine("Ievadiet skolotāja klasi:");
        Klase = Console.ReadLine();

        Console.WriteLine("Ievadiet skolotāja stundu skaitu:");
        StunduSkaitsNedela = Convert.ToInt32(Console.ReadLine());
    }

    public void IzdrukatDatus()
    {
        Console.WriteLine($"{TipaNosaukums} (tips - {SkolotajaTips}) skolotājs {Uzvards} māca {StunduSkaitsNedela} stundas {Klase}. klasē.");
    }
}

class VidusskolasSkolotajs : Skolotajs
{
    public new int SkolotajaTips = 3;

    public string PirmaPrieksmetaNosaukums;
    public int PirmaPrieksmetaStundas;
    public string OtraPrieksmetaNosaukums;
    public int OtraPrieksmetaStundas;
    public int AbuPrieksmetuStunduKopskaitsNedela;


    public void IevaditDatus()
    {
        Console.WriteLine("Ievadiet vidusskolas skolotāja uzvārdu:");
        Uzvards = Console.ReadLine();

        Console.WriteLine("Ievadiet pirmo pasniegto priekšmetu:");
        PirmaPrieksmetaNosaukums = Console.ReadLine();

        Console.WriteLine("Ievadiet pirmā priekšmeta stundu skaitu:");
        PirmaPrieksmetaStundas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ievadiet otro pasniegto priekšmetu:");
        OtraPrieksmetaNosaukums = Console.ReadLine();

        Console.WriteLine("Ievadiet otrā priekšmeta stundu skaitu:");
        OtraPrieksmetaStundas = Convert.ToInt32(Console.ReadLine());
    }

    public void AprekinatStundas()
    {
        AbuPrieksmetuStunduKopskaitsNedela = PirmaPrieksmetaStundas + OtraPrieksmetaStundas;
    }

    public void IzdrukatDatus()
    {
        Console.WriteLine($"{TipaNosaukums} (tips - {SkolotajaTips}) skolotājs {Uzvards} māca šādus priekšmetus: {PirmaPrieksmetaNosaukums} un {OtraPrieksmetaNosaukums}, kopā {AbuPrieksmetuStunduKopskaitsNedela} stundas.");
    }
}