const double conversionAkilogramos = 0.453592;

// Ingresar datos
    Console.Write("Ingrese el peso el libras: ");
    double pesoEnLibras = double.Parse(Console.ReadLine()!);

    Console.Write("Ingrese la temperatura en °F:");
    double fahrenheit = double.Parse(Console.ReadLine()!);

// Conversion
    double pesoEnKilogramos = pesoEnLibras * conversionAkilogramos;
    double celsius = (fahrenheit - 32) * 5 / 9;

// Mostrar resultados
    Console.WriteLine($"Libras: {pesoEnLibras} - Peso en Kilogramos: {pesoEnKilogramos:F2} kg");
    Console.WriteLine($"Fahrenheit: {fahrenheit} - Celsius: {celsius:F2} °C");