using Libre;
using System.Formats.Asn1;

Triangulo t = new Triangulo();
Rectangulo r = new Rectangulo();
Cuadrado c = new Cuadrado();
Trapecio tp = new Trapecio();

string r1;
int respuesta;
string r2;
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("\n\tTe gustaria ingresar para calcular Areas y perimetros (Si) o (No) = ");
    r2 = Console.ReadLine();
    Console.Clear();
    do
    {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tTRIANGULO (1)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tCUADRADO (2)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tRECTANGULO (3)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tTRAPECIO (4)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\tQue calculo te gustaria realizar indica con numero = ");
            respuesta = int.Parse(Console.ReadLine());
        Console.Clear();
            if (respuesta == 1)
            {
                string respuesta1;
                Console.Write("\n\tQue calculo quieres hacer (Area) o (Perimetro) = ");
                respuesta1 = Console.ReadLine();
                if (respuesta1 == "area")
                {
                    t.Area();
                }
                
                else if (respuesta1 == "perimetro")
                {
                    t.Perimetro();
                }
               
            }
            if (respuesta == 2)
            {
                string respuesta1;
                Console.Write("\n\tQue calculo quieres hacer (Area) o (Perimetro) = ");
                respuesta1 = Console.ReadLine();
                if (respuesta1 == "area")
                {
                    c.Area();
                }
                else if (respuesta1 == "perimetro")
                {
                    c.Perimetro();
                }

            }
            if (respuesta == 3)
            {
                string respuesta1;
                Console.Write("\n\tQue calculo quieres hacer (Area) o (Perimetro) = ");
                respuesta1 = Console.ReadLine();
                if (respuesta1 == "area")
                {
                    r.Area();
                }
                else if (respuesta1 == "perimetro")
                {
                    r.Perimetro();
                }
            }
            if (respuesta == 4)
            {
                string respuesta1;
                Console.Write("\n\tQue calculo quieres hacer (Area) o (Perimetro) = ");
                respuesta1 = Console.ReadLine();
                if (respuesta1 == "area")
                {
                    tp.Area(0, 0, 0);
                }
                else if (respuesta1 == "perimetro")
                {
                    tp.Perimetro();
                }
            }
    } while (respuesta <= 0 || respuesta > 4);

} while (r2 == "si");
     

   



