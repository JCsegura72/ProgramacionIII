using System;
using System.IO;

/*
====================================================
EJERCICIO 1: Diario Personal con Bitácora
====================================================

Objetivo:
Crear un programa que permita al usuario escribir una entrada en su "diario"
y guardarla automáticamente con la fecha y hora actual.

Instrucciones:
- Solicitar al usuario que ingrese su nombre al iniciar.
- Pedir al usuario que escriba un pensamiento o actividad del día.
- Guardar el texto en un archivo llamado diario.txt.
- No sobrescribir el contenido anterior (usar File.AppendAllText).
- El formato de cada línea debe ser:
  [FECHA Y HORA] - USUARIO: MENSAJE
- Reto extra: Mostrar las últimas 3 líneas del diario antes de pedir una nueva entrada.
*/

class Program
{
    static void Main()
    {
        string archivo = "diario.txt";

        try
        {
            Console.Write("Ingrese su nombre: ");
            string usuario = Console.ReadLine();

            if (File.Exists(archivo))
            {
                string[] lineas = File.ReadAllLines(archivo);

                Console.WriteLine("\nÚltimas entradas del diario:");

                int inicio = Math.Max(0, lineas.Length - 3);

                for (int i = inicio; i < lineas.Length; i++)
                {
                    Console.WriteLine(lineas[i]);
                }
            }

            Console.Write("\nEscribe tu pensamiento o actividad del día: ");
            string mensaje = Console.ReadLine();

            string entrada = $"[{DateTime.Now}] - {usuario}: {mensaje}{Environment.NewLine}";

            File.AppendAllText(archivo, entrada);

            Console.WriteLine("Entrada guardada correctamente.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al escribir en el archivo: " + e.Message);
        }
    }
}