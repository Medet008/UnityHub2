using System;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sumOddNumber = 0;
            int sumEvenNumber = 0;
            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2==1)
                    sumOddNumber += num;
                else if (num > 0 && num % 2 == 0)
                    sumEvenNumber += num; 

            }while(num != 0);
            Console.WriteLine($"сумма не четных чисел: {sumOddNumber}");
            Console.WriteLine($"сумма четных чисел : {sumEvenNumber}");
            Console.WriteLine($"Сумма всех чисел: {sumOddNumber + sumEvenNumber}");
        }
    }
}
