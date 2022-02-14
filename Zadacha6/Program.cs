using System;


namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число диапазоне от одонго до определенных чисел ");
            int amountNumber = 0;
            int num = GetNum();
            DateTime dateTimeStart = DateTime.Now;

            for (int i = 1; i<num; i++)
            {
                if(GetChekNumber(i))
                {
                    amountNumber++;
                }
            }

            Console.WriteLine("vremia raboti program");
            Console.WriteLine(DateTime.Now - dateTimeStart);
            Console.WriteLine($"заданном дипазоне содержатся хороших чисел: {amountNumber}");
            Console.ReadKey();
        }

        static int GetNum()
        {
            while (true)
            {
                bool number = int.TryParse(Console.ReadLine(), out int num);
                if (!number)
                {
                    Console.WriteLine("ввeден неверно требуется ввести число занова");
                }
                else
                {
                    return num;
                }
            }
        }

        static bool GetChekNumber(int number)
        {
            string s = Convert.ToString(number);
            int sum = 0;
            for(int i = 0; i < s.Length; i++)
            {
                sum += s[i] - '0';
               
            }
            if (number % sum == 0)

                return true;

            else
                return false;
        }
    }
}
