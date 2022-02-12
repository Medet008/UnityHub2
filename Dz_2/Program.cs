using System;

namespace Dz_2
{
    internal class Program
    {
        static double MinResult(double a, double b, double c)
        {
           
            double min;
            if (a < b && a < c)
            {
                min = a;
                Console.WriteLine(min);
                return min;
            }
            else if (b < a && b < c)
            {
                min = b;
                Console.WriteLine(min);
                return min;
            }
            else if (c < a && c < b)
            {
                min = c;
                Console.WriteLine(min);
                return min;
            }
            else
            {
                Console.WriteLine("vi veli odinakovoe chislo");
                return 0;
            }

        }
        static void Main(string[] args)
        { 
           
            int a, b, c;
            string res;
            Console.WriteLine("vvedite Pervoe chisl");
            res = Console.ReadLine();
            a = int.Parse(res);
            Console.WriteLine("vvedite vtoroe chislo");
            res = Console.ReadLine();
            b = int.Parse(res);
            Console.WriteLine("vvedite treti chislo");
            res = Console.ReadLine();
            c = int.Parse(res);

            MinResult(a, b, c);

        }
    }
}
