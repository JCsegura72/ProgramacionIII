using System;
using System.IO;

/*
====================================================
EJERCICIO 3: Creador de Estructura de Proyectos
====================================================

Objetivo:
Automatizar la creación de carpetas y archivos iniciales
para un proyecto imaginario.

Instrucciones:
1. Solicitar al usuario el "Nombre del Proyecto".
2. Crear una carpeta principal con ese nombre usando
   Directory.CreateDirectory.
3. Dentro de esa carpeta crear tres subcarpetas:
   - documentos
   - imagenes
   - codigo
4. Pedir al usuario una breve descripción del proyecto.
5. Crear un archivo llamado readme.txt dentro de la carpeta
   documentos usando Path.Combine.
6. Guardar la descripción en ese archivo.
7. Mostrar en consola la ruta absoluta del proyecto
   usando Path.GetFullPath.
*/

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nombre del proyecto: ");
            string nombreProyecto = Console.ReadLine();

            Directory.CreateDirectory(nombreProyecto);

            string carpetaDocumentos = Path.Combine(nombreProyecto, "documentos");
            string carpetaImagenes = Path.Combine(nombreProyecto, "imagenes");
            string carpetaCodigo = Path.Combine(nombreProyecto, "codigo");

            Directory.CreateDirectory(carpetaDocumentos);
            Directory.CreateDirectory(carpetaImagenes);
            Directory.CreateDirectory(carpetaCodigo);

            Console.Write("Descripción del proyecto: ");
            string descripcion = Console.ReadLine();

            string archivoReadme = Path.Combine(carpetaDocumentos, "readme.txt");

            File.WriteAllText(archivoReadme, descripcion);

            string rutaAbsoluta = Path.GetFullPath(nombreProyecto);

            Console.WriteLine("\nProyecto creado correctamente.");
            Console.WriteLine("Ruta del proyecto:");
            Console.WriteLine(rutaAbsoluta);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al crear el proyecto: " + e.Message);
        }
    }
}