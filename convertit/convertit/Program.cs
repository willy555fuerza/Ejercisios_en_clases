using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            String c = "";
            int[] vec = new int[10];
            Console.Write("Tamaño de numero:");
            5n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sus numero");
            for (int i = 0; i < n; i++)
            {
                vec[i] = int.Parse(Console.ReadLine());

            }
            c = vec[1].ToString()+ vec[0].ToString();

            Console.WriteLine("El elemento volteado es:" + c);
            Console.ReadKey();
        }
        
    }
    
}
