using System;
using System.IO;


/*
====================================================
EJERCICIO 2: Gestor de Contactos Simple (Formato CSV)
====================================================

Objetivo:
Guardar una pequeña agenda de contactos utilizando un archivo CSV.

Instrucciones:
- Crear una clase Contacto con las propiedades:
  Nombre, Telefono y Correo.
- Solicitar estos tres datos al usuario.
- Implementar un método ToCSV() que devuelva los datos separados por ";".
- Guardar el contacto en un archivo contactos.csv.
- Antes de guardar, normalizar el correo usando Trim() y ToLower().
- Preguntar al usuario si desea listar contactos.
- Si responde sí, leer el archivo y mostrar los datos usando Split(';').
*/

class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }

    public string ToCSV()
    {
        return $"{Nombre};{Telefono};{Correo}";
    }
}

class Program
{
    static void Main()
    {
        string archivo = "contactos.csv";

        try
        {
            Contacto c = new Contacto();

            Console.Write("Nombre: ");
            c.Nombre = Console.ReadLine();

            Console.Write("Teléfono: ");
            c.Telefono = Console.ReadLine();

            Console.Write("Correo: ");
            c.Correo = Console.ReadLine().Trim().ToLower();

            File.AppendAllText(archivo, c.ToCSV() + Environment.NewLine);

            Console.WriteLine("Contacto guardado.");

            Console.Write("\n¿Desea listar contactos? (si/no): ");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "si")
            {
                if (File.Exists(archivo))
                {
                    string[] lineas = File.ReadAllLines(archivo);

                    Console.WriteLine("\nAGENDA DE CONTACTOS");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Nombre\t\tTelefono\tCorreo");

                    foreach (string linea in lineas)
                    {
                        string[] datos = linea.Split(';');

                        Console.WriteLine($"{datos[0]}\t\t{datos[1]}\t{datos[2]}");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}