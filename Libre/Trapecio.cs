using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libre
{
    public class Trapecio
    {
        public int Area(int area , int peri1, int total)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\tIngresa El Valor 1 Del Area Del Trapecio en Numeros = ");
            area = int.Parse(Console.ReadLine());
            Console.Write("\n\tIngresa El Valor 2 Del Area Del Trapecio en Numeros = ");
            peri1 = int.Parse(Console.ReadLine());
            total = (area + peri1) / 2 * 4;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tEl Area total Del Trapecio es = " + total);
            return 1;
        }

        public int Perimetro(int peri =0 , int peri1 = 0, int peri2= 0, int total = 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\tIngresa El Valor 1 Del Perimetro Del Trapecio en Numeros = ");
            peri = int.Parse(Console.ReadLine());
            Console.Write("\n\tIngresa El Valor 2 Del Perimetro Del Trapecio en Numeros = ");
            peri1 = int.Parse(Console.ReadLine());
            Console.Write("\n\tIngresa El Valor 3 Del Perimetro Del Trapecio en Numeros = ");
            peri2 = int.Parse(Console.ReadLine());
            total = peri + peri1 + peri2 + peri2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tEl Perimetro total Del Trapecio es = " + total);
            return 1;
        }
    }
}
