using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingresar_digito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, b, digito;
            digito = 0;
            String rr,numeroA = "";
            Console.Write("DIGITA UNA CANTIDAD NUMERICA DECIMAL:");
            numero = int.Parse(Console.ReadLine());

            Console.Write("DIGITA LA BASE A CONVERTIR:");
            b = int.Parse(Console.ReadLine());
            while(numero > 0)
            {
                digito = numero % b;
                if((b == 16) && (digito >= 10))
                {
                    rr = "";
                    switch(digito)
                    {
                        case 10:
                            rr = "A";
                            break;
                        case 11:
                            rr = "B";
                            break;
                        case 12:
                            rr = "C";
                            break;
                        case 13:
                            rr = "D";
                            break;
                        case 14:
                            rr = "E";
                            break;
                        case 15:
                            rr = "F";
                            break;
                    }
                    numeroA = rr + numeroA;
                }
                else
                {
                    numeroA = digito.ToString() + numeroA;
                }
                    numero = numero / b;
            }
            Console.WriteLine("BASE:" + b + "-->" + numeroA);
            Console.ReadKey();
        }
    }
}
