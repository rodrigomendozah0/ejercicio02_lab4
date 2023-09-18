using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exponente = 2;
            int base1 = 5;
            int resultado = 1;

            for (int i = 0; i < exponente; i++)
            {
                resultado = resultado * base1;
            }

            Console.WriteLine("El resultado de la potencia es: " + resultado);
            Console.ReadKey();
        }
    }
}
