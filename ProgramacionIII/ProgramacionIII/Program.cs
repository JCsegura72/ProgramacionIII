using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProgramacionIII.Ejercicios;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENU PRINCIPAL =====");
            Console.WriteLine("1. Cajero Automático");
            Console.WriteLine("2. Control de Inventario");
            Console.WriteLine("3. Calculadora de Calificaciones");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    EjecutarCajero();
                    break;

                case 2:
                    EjecutarInventario();
                    break;

                case 3:
                    EjecutarEstudiante();
                    break;
            }

        } while (opcion != 0);
    }

    // ================= CAJERO =================
    static void EjecutarCajero()
    {
        Console.Write("Ingrese titular: ");
        string titular = Console.ReadLine();

        CuentaBancaria cuenta = new CuentaBancaria(titular, 0);
        int op;

        do
        {
            Console.WriteLine("\n1. Consultar saldo");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Retirar");
            Console.WriteLine("0. Volver");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    cuenta.ConsultarSaldo();
                    break;

                case 2:
                    Console.Write("Cantidad: ");
                    decimal dep = decimal.Parse(Console.ReadLine());
                    cuenta.Depositar(dep);
                    break;

                case 3:
                    Console.Write("Cantidad: ");
                    decimal ret = decimal.Parse(Console.ReadLine());
                    cuenta.Retirar(ret);
                    break;
            }

        } while (op != 0);
    }

    // ================= INVENTARIO =================
    static void EjecutarInventario()
    {
        Console.Write("Nombre producto: ");
        string nombre = Console.ReadLine();

        Console.Write("Código: ");
        string codigo = Console.ReadLine();

        Console.Write("Precio: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        Console.Write("Stock inicial: ");
        int stock = int.Parse(Console.ReadLine());

        Producto p = new Producto(nombre, codigo, precio, stock);

        int op;
        do
        {
            Console.WriteLine("\n1. Mostrar info");
            Console.WriteLine("2. Agregar stock");
            Console.WriteLine("3. Vender");
            Console.WriteLine("0. Volver");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    p.MostrarInfo();
                    break;

                case 2:
                    Console.Write("Cantidad: ");
                    p.AgregarStock(int.Parse(Console.ReadLine()));
                    break;

                case 3:
                    Console.Write("Cantidad: ");
                    p.VenderProducto(int.Parse(Console.ReadLine()));
                    break;
            }

        } while (op != 0);
    }

    // ================= ESTUDIANTE =================
    static void EjecutarEstudiante()
    {
        Console.Write("Nombre estudiante: ");
        string nombre = Console.ReadLine();

        Console.Write("Materia: ");
        string materia = Console.ReadLine();

        double[] notas = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        Estudiante e = new Estudiante(nombre, materia, notas);

        Console.WriteLine($"Promedio: {e.CalcularPromedio()}");
        Console.WriteLine($"Estado: {e.EstadoFinal()}");
    }
}