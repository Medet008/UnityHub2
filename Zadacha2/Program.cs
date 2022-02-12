using System;

namespace Zadacha2
{
    internal class Program
    {
        static int Result(int a)
        {   
           
            int i = 0;
            
            while (a > 0) 
            {
                Console.WriteLine(a);
                i++;
                a /= 10;              
            }
           
            Console.WriteLine($"каличество из цифра из числа = {i}");
            return 0; 

        }
        static void Main(string[] args)
        {
            Result(555);
        }
    }
}
