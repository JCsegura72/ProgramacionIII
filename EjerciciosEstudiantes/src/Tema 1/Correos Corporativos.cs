using System;

class Program
{
    static void Main()
    {
        // Generador de Correos Corporativos:
        // Pide al usuario su nombre y apellido.
        // El programa debe generar un correo con el formato:
        // nombre.apellido@empresa.com (todo en minúsculas).

        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine().ToLower();

        Console.Write("Ingrese su apellido: ");
        string apellido = Console.ReadLine().ToLower();

        string correo = nombre + "." + apellido + "@empresa.com";

        Console.WriteLine("Correo generado: " + correo);
    }
}