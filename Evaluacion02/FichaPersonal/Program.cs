namespace FichaPersonal;

class Program
{
    static void Main(string[] args)
    {
        string nombre;
        int edad;
        double estatura;
        bool trabaja;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine()!;

        Console.Write("Ingrese su edad: ");
        edad = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese su estatura: ");
        estatura = double.Parse(Console.ReadLine()!);

        Console.Write("Trabaja? (true / false)");
        trabaja = bool.Parse(Console.ReadLine()!);
        int aniocumplir30 = 2026 + (30 - edad);

        //Mostrar ficha personal
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Estatura: {estatura}");
        Console.WriteLine($"Trabaja: {trabaja}");
        Console.WriteLine($"Anio en el que va a cumplir los 30 anos: {aniocumplir30}");
    }
}