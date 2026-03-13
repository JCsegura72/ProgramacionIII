using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionIII.Ejercicios
{
    public class CuentaBancaria
    {
        private string titular;
        private decimal saldo;

        public CuentaBancaria(string titular, decimal saldoInicial)
        {
            this.titular = titular;
            saldo = saldoInicial;
        }

        public void Depositar(decimal cantidad)
        {
            saldo += cantidad;
            Console.WriteLine("Depósito realizado.");
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
                Console.WriteLine("Retiro exitoso.");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes.");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo actual: " + saldo);
        }
    }
}
