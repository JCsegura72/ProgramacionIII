using System;

class Program
{
    static void Main()
    {
        // Perfil de Usuario Gamer:
        // Crea un programa que pida al usuario su Nickname, nivel de experiencia (1-100)
        // y si tiene suscripción Premium (booleano). Al final, muestra un mensaje
        // personalizado que le dé la bienvenida a su nivel correspondiente.

        Console.Write("Ingrese su Nickname: ");
        string nickname = Console.ReadLine();

        Console.Write("Ingrese su nivel de experiencia (1-100): ");
        int nivel = int.Parse(Console.ReadLine());

        Console.Write("¿Tiene suscripción Premium? (true/false): ");
        bool premium = bool.Parse(Console.ReadLine());

        string tipoUsuario;

        if (premium)
        {
            tipoUsuario = "Jugador Premium";
        }
        else
        {
            tipoUsuario = "Jugador Estándar";
        }

        Console.WriteLine("Bienvenido " + nickname +
                          ", nivel " + nivel +
                          ". Tipo de usuario: " + tipoUsuario);
    }
}