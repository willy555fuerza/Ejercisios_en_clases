using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datosprimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            double sueldo;
            bool Casado;
           
            Console.Write("Cual es tu Nombre? : ");
            nombre = Console.ReadLine();

            Console.Write("Ingresa tu edad : ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa tu sueldo: ");
            sueldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("casado?: ");
            Casado = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Tu nombre es " + nombre + " y tu edad es " + edad);
            Console.WriteLine("Tu sueldo es " +sueldo+ " y la Consulta de casado es: " +Casado);

            Console.ReadKey();

        }
    }
}
