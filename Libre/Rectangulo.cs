using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libre
{
    public class Rectangulo
    {
        public int Area()
        {
            int area = 0, total = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\tIngresa El Area Del Rectangulo en Numero = ");
            area = int.Parse(Console.ReadLine());
            total = area * (2 * area);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tEl Area Del Rectangulo es = " + total);
            return 1;
        }
        public int Perimetro()
        {
            int peri = 0, total = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\tIngresa El Perimetro Del Rectangulo en Numero = ");
            peri = int.Parse(Console.ReadLine());
            total = peri * peri + (peri * 2) + (peri * 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tEl valor del perimetro del rectangulo es = " + total);
            return 1;
        }
    }
}
