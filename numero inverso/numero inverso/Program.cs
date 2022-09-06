using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_inverso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int n, r, ni;

            //Solicitar el valor de entrada
            Console.WriteLine("Escribe un numero de 5 cifras: ");
            n = int.Parse(Console.ReadLine());

            //Proceso
            r = n % 10;
            n = n / 10;
            ni = r * 10;

            r = n % 10;
            n = n / 10;
            ni = (ni + r) * 10;

            r = n % 10;
            n = n / 10;
            ni = (ni + r) * 10;

            r = n % 10;
            n = n / 10;
            ni = (ni + r) * 10;

            ni = ni + n;

            //salida
            Console.WriteLine("Numero inverso: " + ni);
            Console.ReadKey();
        }
    }
}
