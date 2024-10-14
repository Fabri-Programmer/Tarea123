using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libre
{
    public class Cuadrado
    {
        public void Area(int area = 0, int total = 0)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\tIngresa El Area en Numero = ");
            area = int.Parse(Console.ReadLine());
            total = area * area;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tEl Area del cuadrado es = " + total);
        }
        public void Perimetro(int area = 0, int peri= 0,int total=0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\tIngresa El Perimetro en Numero = ");
            peri = int.Parse(Console.ReadLine());
            total = peri + peri + peri + peri;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tEl Perimetro del cuadrado es = " + total);
        }
    }
}
