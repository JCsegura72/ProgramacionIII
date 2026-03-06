using System;

class Program
{
    static void Main()
    {
        // Calculadora de Propina Solidaria:
        // Pide el total de una cuenta en un restaurante.
        // Pregunta qué porcentaje de propina desea dejar (10%, 15% o 20%).
        // Si el total con propina supera los $100.000,
        // muestra un mensaje agradeciendo su generosidad.

        Console.Write("Ingrese el total de la cuenta: ");
        double total = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el porcentaje de propina (10, 15, 20): ");
        int porcentaje = int.Parse(Console.ReadLine());

        double propina = total * porcentaje / 100;
        double totalFinal = total + propina;

        Console.WriteLine("Total con propina: " + totalFinal);

        if (totalFinal > 100000)
        {
            Console.WriteLine("¡Gracias por su generosidad!");
        }
    }
}