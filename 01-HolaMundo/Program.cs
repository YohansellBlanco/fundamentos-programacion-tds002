
namespace _01_HolaMundo;

class Program
{
    static void Main(string[] args)
    {
        // Datos personales
        string nombre = "Yohansell Blanco";
        string carrera = "Ciberseguridad";
        string institucion = "ITLA";
        string correo = "tu_correo@ejemplo.com";

        // Mostrar tarjeta de presentación
        Console.WriteLine("==================================");
        Console.WriteLine("       TARJETA DE PRESENTACION");
        Console.WriteLine("==================================");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Carrera: {carrera}");
        Console.WriteLine($"Institucion: {institucion}");
        Console.WriteLine($"Correo: {correo}");
        Console.WriteLine("==================================");
        Console.WriteLine("       Gracias por visitar");
        Console.WriteLine("==================================");
    }
}
