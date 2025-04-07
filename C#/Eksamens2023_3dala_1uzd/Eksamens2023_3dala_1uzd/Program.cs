using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car("Audi", "A4", Convert.ToDateTime("10.01.2013"), 1800, "BG");
        car1.PrintCar();
    }
}

public class Car
{
    string Brand;
    string Model;
    DateTime RegistrationDate;
    double FullWeight;
    string FuelType;

    public Car(string brand, string model, DateTime registrationDate, double fullWeight, string fuelType)
    {
        Brand = brand;
        Model = model;
        RegistrationDate = registrationDate;
        FullWeight = fullWeight;
        FuelType = fuelType;
    }
    public void PrintCar()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Informācija par auto:");
        Console.WriteLine($"Zīmols: {Brand}");
        Console.WriteLine($"Modelis: {Model}");
        Console.WriteLine($"Reģistrācijas datums: {RegistrationDate:d}");
        Console.WriteLine($"Pilna masa: {FullWeight}");
        Console.WriteLine($"Degvielas veids: {FuelType}");

    }
}