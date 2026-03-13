using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionIII.Ejercicios
{
    public class Producto
    {
        private string nombre;
        private string codigo;
        private decimal precio;
        private int stock;

        public Producto(string nombre, string codigo, decimal precio, int stock)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;
            this.stock = stock;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("\nProducto: " + nombre);
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Precio: " + precio);
            Console.WriteLine("Stock: " + stock);
        }

        public void AgregarStock(int cantidad)
        {
            stock += cantidad;
            Console.WriteLine("Stock actualizado.");
        }

        public void VenderProducto(int cantidad)
        {
            if (cantidad <= stock)
            {
                stock -= cantidad;
                Console.WriteLine("Venta realizada.");
            }
            else
            {
                Console.WriteLine("Stock insuficiente.");
            }
        }
    }
}