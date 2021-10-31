using System;

namespace Treygol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину катета прямоугольного треугольниик для его построения:");
            int m = Convert.ToInt32(Console.ReadLine());
            int a = 2;
            int b = 1;
            string xx = "";
            string yy = " ";
            string zz = "*";
            string hh = "*";
            string gg;
            Console.WriteLine("*");

            do
            {
                a += 1;
                Console.WriteLine($"*{xx}*");
                xx += yy;
            } while (a < m);

            while (b !=m)
            {
                zz +=hh;
                b += 1;
            }
            Console.WriteLine(zz);
        }
    }
}
