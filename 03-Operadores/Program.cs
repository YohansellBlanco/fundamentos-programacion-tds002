// Variables
using System.Security.Cryptography;

int num1;
    int num2;

// Pedir al usuario
    Console.Write("Introzca el primer numero: ");
    num1 = int.Parse(Console.ReadLine()!);
    Console.Write("Introduzca el segundo numero: ");
    num2 = int.Parse(Console.ReadLine()!);

//Operatoria
    double suma = num1 + num2;
    double resta = num1 - num2;
    double producto = num1 * num2;
    double divisionReal = (double)num1 / num2;
    int divisionEntera = num1 / num2;
    double residuo = num1 % num2;
    bool esPar = num1 % 2 == 0;


// Mostrar resultados
    Console.WriteLine($"Suma: {suma}");
    Console.WriteLine($"Resta: {resta}");
    Console.WriteLine($"Producto: {producto}");
    Console.WriteLine($"Division Real: {divisionReal}");
    Console.WriteLine($"Division Entera: {divisionEntera}");
    Console.WriteLine($"Residuo: {residuo}");
    Console.WriteLine($"Par? {esPar}");