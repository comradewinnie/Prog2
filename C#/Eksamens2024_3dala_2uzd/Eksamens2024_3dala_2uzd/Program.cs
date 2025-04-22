class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        SakumskolasSkolotajs sakumskolasSkolotajs1 = new SakumskolasSkolotajs();
        sakumskolasSkolotajs1.IevaditDatus();;
        sakumskolasSkolotajs1.IzdrukatDatus();

        VidusskolasSkolotajs vidusskolasSkolotajs1 = new VidusskolasSkolotajs();
        vidusskolasSkolotajs1.IevaditDatus();
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
}

class SakumskolasSkolotajs : Skolotajs
{
    public SakumskolasSkolotajs() // создаём конструктор, чтобы установить только для SkolotajaTips и TipaNosaukums значение по умолчанию
    {
        SkolotajaTips = 1;
        TipaNosaukums = "Sākumskolas";
    }

    public void IevaditDatus()
    {
        Console.Write("Ievadiet sākumskolas skolotāja uzvārdu: ");
        Uzvards = Console.ReadLine();

        Console.Write("Ievadiet skolotāja klasi: ");
        Klase = Console.ReadLine();

        Console.Write("Ievadiet skolotāja stundu skaitu: ");
        StunduSkaitsNedela = Convert.ToInt32(Console.ReadLine());
    }

    public void IzdrukatDatus()
    {
        Console.WriteLine($"{TipaNosaukums} (tips - {SkolotajaTips}) skolotājs {Uzvards} māca {StunduSkaitsNedela} stundas {Klase}. klasē.");
    }
}

class VidusskolasSkolotajs : Skolotajs
{

    public string PirmaPrieksmetaNosaukums;
    public int PirmaPrieksmetaStundas;
    public string OtraPrieksmetaNosaukums;
    public int OtraPrieksmetaStundas;
    public int AbuPrieksmetuStunduKopskaitsNedela;

    public VidusskolasSkolotajs() // создаём конструктор, чтобы установить только для SkolotajaTips и TipaNosaukums значение по умолчанию
    {
        SkolotajaTips = 3;
        TipaNosaukums = "Vidusskolas";
    }

    public void IevaditDatus()
    {
        Console.Write("Ievadiet vidusskolas skolotāja uzvārdu: ");
        Uzvards = Console.ReadLine();

        Console.Write("Ievadiet pirmo pasniegto priekšmetu: ");
        PirmaPrieksmetaNosaukums = Console.ReadLine();

        Console.Write("Ievadiet pirmā priekšmeta stundu skaitu: ");
        PirmaPrieksmetaStundas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ievadiet otro pasniegto priekšmetu: ");
        OtraPrieksmetaNosaukums = Console.ReadLine();

        Console.Write("Ievadiet otrā priekšmeta stundu skaitu: ");
        OtraPrieksmetaStundas = Convert.ToInt32(Console.ReadLine());

        AprekinatStundas();
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