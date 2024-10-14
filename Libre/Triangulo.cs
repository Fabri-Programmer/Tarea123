using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libre
{
   public class Triangulo
   {
        public void Area()
        {
            int altura= 0, base1=0, total=0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\tIngresa La Altura del Triangulo en numero = ");
            altura = int.Parse(Console.ReadLine());
            Console.Write("\n\tIngresa La Base en numero = ");
            base1 = int.Parse(Console.ReadLine());
            total = base1 * altura / 2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tEl valor de tu Area es = " + total);

        }
        public void Perimetro()
        {
            int total=0, peri=0;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\tIngresa el Perimetro del Triangulo en numero = ");
            peri = int.Parse(Console.ReadLine());
            total = peri + peri + peri;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n\tEL VALOR DE TU PERIMETRO ES = " + total);
        }
   }
}
