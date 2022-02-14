using System;

namespace Zadacha5
{
    internal class Program
    {

        static double GetMass()
        {
           double mass = double.Parse(Console.ReadLine());  
            return mass;
        }
        static double GetRost()
        {
            double rost = double.Parse(Console.ReadLine());
            return rost;
        }
        static void Main(string[] args)
            {
              Console.WriteLine("введите ваш рост");
            double rost = GetRost() / 100; 
              Console.WriteLine("введите ваш вес");
              double mass = GetMass();
              double rostMass = mass / (rost * rost);

            double massIndexMax = 24.99;
            double massIndexMin = 18.5;

            double indexMax;
            double indexMin; 
            double result;
             
               if(rostMass > massIndexMax)
            {
                indexMax = massIndexMax * (rost * rost);
                result = Math.Abs(mass - indexMax);
                Console.WriteLine($"ваш индекс масса тела состовляет {rostMass:F2}");
                Console.WriteLine($"вам необхадимо скинуть вес {result:F2}");
            } else if (rostMass < massIndexMin)
            {
                indexMin= massIndexMin * (rost * rost);
                result = Math.Abs(mass - indexMin);
                Console.WriteLine($"ваш индекс масса тела состовляет {rostMass:F2}");
                Console.WriteLine($"вам необхадимо набрать вес {rostMass:F2}");
            }
            else
            {
                Console.WriteLine($"ваш индекс масса тела состовляет {rostMass:F2}");
                Console.WriteLine("ваш вес норм");
            }
            
        }
    }
}
