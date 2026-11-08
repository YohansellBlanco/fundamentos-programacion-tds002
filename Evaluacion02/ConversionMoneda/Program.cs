namespace ConversorMoneda;

class Program
{
    static void Main(string[] args)
    {
        const double TASA_USD = 60.89;

        //Pedir al usuario
        Console.Write("Pesos: ");
        double cantpesos = double.Parse(Console.ReadLine()!);

        double conversdolar = (cantpesos / TASA_USD);

        Console.WriteLine($"{cantpesos} en convertidos a dolares son: {conversdolar}");
    }
}