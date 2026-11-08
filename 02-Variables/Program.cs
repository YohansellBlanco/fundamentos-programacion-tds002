namespace _02_Variables;

class Program
{
    static void Main(string[] args)
    {
        string nombre;
        int edad;
        double estatura;
        const int ANIO_ACTUAL = 2026;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine()!;

        Console.Write("Ingrese su edad: ");
        edad = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese su estatura: ");
        estatura = double.Parse(Console.ReadLine()!);

        int anioNacimiento = ANIO_ACTUAL - edad;

        Console.Write("\n---Datos Personales---\n");
        Console.Write($"Nombre: {nombre}\n");
        Console.Write($"Edad: {edad}\n");
        Console.Write($"Estatura: {estatura}\n");
        Console.Write($"Ano de nacimiento: {anioNacimiento}\n");
    }
}
