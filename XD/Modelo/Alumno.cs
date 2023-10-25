using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD.Modelo
{
    class Alumno
    {
        public string Numero_Carnet { get; set; }
        public string Nombre { get; set; }
        public double[] Notas { get; set; }

        public double Promedio { get; set; }
        public void Guardar_Datos()
        {
            this.Notas = new double[4];
            Console.Write("Ingrese el número de carnet: ");
            this.Numero_Carnet = Console.ReadLine();
            Console.Write("Ingrese el nombre: ");
            this.Nombre = Console.ReadLine();
            for (int i = 0; i < this.Notas.Length; i++)
            {
                Console.WriteLine($"Ingrese la nota {i+1}");
                Notas[i] = double.Parse(Console.ReadLine());
            }
            Calcular_Promedio();
        }
        public void Calcular_Promedio()
        {
            double Suma = 0;
            for (int i = 0; i < this.Notas.Length; i++)
            {
                Suma += Notas[i];
            }
            this.Promedio = Suma / this.Notas.Length;
        }
        public void Mostrar_Datos()
        {
            Console.WriteLine($"Numero de carnet -> {this.Numero_Carnet}");
            Console.WriteLine($"Nombre -> {this.Nombre}");
            Console.WriteLine($"Promedio -> {this.Promedio}");
            Console.WriteLine(this.Promedio < 6? "Reprobado" : "Aprobado");
            Console.WriteLine("Notas:");
            for (int i = 0; i < this.Notas.Length; i++)
            {
                Console.WriteLine($"\t {Notas[i]}");
            }
        }

    }
}
