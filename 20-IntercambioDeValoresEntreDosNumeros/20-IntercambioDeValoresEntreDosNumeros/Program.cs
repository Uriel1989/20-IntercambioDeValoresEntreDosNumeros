using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_IntercambioDeValoresEntreDosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, auxiliar;

            Console.WriteLine("Ingrese los  valores de la primera y segunda variable: ");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            auxiliar = num1;
            num1 = num2;
            num2 = auxiliar;

            Console.WriteLine("El nuevo valor de la primera variable es: " + num1);
            Console.WriteLine("El nuevo valor de la segunda variable es: " + num2);

            auxiliar = num2;
            num2 = num1;
            num1 = auxiliar;

            Console.WriteLine("El valor original de la primera variable es: " + num1);
            Console.WriteLine("El valor original de la segunda variable es: " + num2);
            Console.ReadKey();
        }
    }
}
