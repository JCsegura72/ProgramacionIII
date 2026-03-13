using System;

class Program
{
    static void Main()
    {
        // Control de Aforo en Eventos:
        // Una discoteca tiene un aforo máximo de 50 personas.
        // Crea un programa que pregunte cuántas personas quieren entrar.
        // Si hay cupo, dales la bienvenida; si no,
        // indícales cuántas personas deben salir para que ellos puedan entrar.

        int aforoMaximo = 50;

        Console.Write("¿Cuántas personas quieren entrar?: ");
        int personas = int.Parse(Console.ReadLine());

        if (personas <= aforoMaximo)
        {
            Console.WriteLine("Bienvenidos, pueden entrar.");
        }
        else
        {
            int exceso = personas - aforoMaximo;
            Console.WriteLine("Deben salir " + exceso + " personas para que puedan entrar.");
        }
    }
}