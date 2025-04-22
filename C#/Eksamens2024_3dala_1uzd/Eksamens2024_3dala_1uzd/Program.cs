class Program
{
    static void Main(string[] args)
    {
        Doktorats doktorats = new Doktorats();
        doktorats.IevaditVertibas();
        doktorats.IzdrukatVertibas();
    }
}
class Doktorats
{
    public string DoktorataNosaukums;
    public int DoktorataPacientuSkaits;

    public void IevaditVertibas()
    {
        Console.WriteLine("Ievadiet doktorāta nosaukumu: ");
        DoktorataNosaukums = Console.ReadLine();

        Console.WriteLine("Ievadiet pacientu skaitu: ");
        DoktorataPacientuSkaits = Convert.ToInt32(Console.ReadLine());
    }

    public void IzdrukatVertibas()
    {
        Console.WriteLine($"Doktorāts {DoktorataNosaukums} apkalpo {DoktorataPacientuSkaits} pacientus.");
    }
}