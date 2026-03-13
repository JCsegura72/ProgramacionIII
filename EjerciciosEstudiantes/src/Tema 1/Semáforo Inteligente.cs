using System;

class Program
{
    static void Main()
    {
        // Simulador de Semáforo Inteligente:
        // Pide al usuario que ingrese el color actual del semáforo
        // (Verde, Amarillo, Rojo).
        // Si es verde, imprime "Sigue adelante".
        // Si es amarillo, "Prepárate para frenar".
        // Si es rojo, "¡Detente!".

        Console.Write("Ingrese el color del semáforo: ");
        string color = Console.ReadLine().ToLower();

        if (color == "verde")
        {
            Console.WriteLine("Sigue adelante");
        }
        else if (color == "amarillo")
        {
            Console.WriteLine("Prepárate para frenar");
        }
        else if (color == "rojo")
        {
            Console.WriteLine("¡Detente!");
        }
        else
        {
            Console.WriteLine("Color no válido");
        }
    }
}