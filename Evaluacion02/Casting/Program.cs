namespace Casting;

class Program
{
    static void Main(string[] args)
    {
    // Pedir numero al usuario
        Console.Write("Introduce un numero decimal: ");
        double numdecimal = double.Parse(Console.ReadLine()!);

    // Casting explicito
        int intExplicito = (int)numdecimal;

    // Casting implicito
        int numEntero = 10;
        double doubleImplicito = numEntero;

    // Mostrar
        Console.WriteLine($"Casting Explicito\n\nDecimal: {numdecimal} - Entero: {intExplicito}\n");
        Console.WriteLine($"Casting Implicito\n\nDecimal: {numEntero} = Entero: {doubleImplicito}");
    }
}
