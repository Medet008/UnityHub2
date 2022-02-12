using System;

namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login = "root";
            string password = "GeekBrains";
            int count = 0;
            do
            {  
                    Console.WriteLine("введите логи");
                    string logChek = Console.ReadLine();
                    Console.WriteLine("введите пароль");
                    string passChek = Console.ReadLine();
                    if (login == logChek && password == passChek)
                    {
                        Console.WriteLine("Добро пожаловать!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        ++count;
                    Console.WriteLine("не вверно ввели пароль или логин");
                    }
                    if(count == 3)
                    {
                        Console.WriteLine("Аккоунт заблокирован обратитесь к администратору");
                    }
            }while(count < 3);
           
        }
    }
}
