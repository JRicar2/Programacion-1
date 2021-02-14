using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangulo1 = new Rectangle();
            rectangulo1.basis = 3;
            rectangulo1.height = 7;

            //rectangulo1.Grow(10);

            Console.WriteLine("Area y Perimetro del Rectangulo 1: ");
            Console.WriteLine("Area: "+rectangulo1.Area()+"m²");
            Console.WriteLine("Perimetro: "+rectangulo1.Perimeter()+"m");
            Console.WriteLine(" ");

            Rectangle rectangulo2 = new Rectangle();
            rectangulo2.basis = 1.5;
            rectangulo2.height = 4;

            Console.WriteLine("Area y Perimetro del Rectangulo 2: ");
            Console.WriteLine("Area: " + rectangulo2.Area() + "m²");
            Console.WriteLine("Perimetro: " + rectangulo2.Perimeter() + "m");
            Console.WriteLine(" ");

            Console.Write("Parametro Comparar: ");
            Console.WriteLine(rectangulo1.Compare(rectangulo2));

            Console.ReadKey();
        }
    }
}
