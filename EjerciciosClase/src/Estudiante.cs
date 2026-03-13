using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionIII.Ejercicios
{
    public class Estudiante
    {
        private string nombre;
        private string materia;
        private double[] notas;

        public Estudiante(string nombre, string materia, double[] notas)
        {
            this.nombre = nombre;
            this.materia = materia;
            this.notas = notas;
        }

        public double CalcularPromedio()
        {
            double suma = 0;

            foreach (double nota in notas)
            {
                suma += nota;
            }

            return suma / notas.Length;
        }

        public string EstadoFinal()
        {
            if (CalcularPromedio() >= 3.0)
                return "Aprobado";
            else
                return "Reprobado";
        }
    }
}