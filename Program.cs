using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_passwordProtectedProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "54321";
            string userInput;

            for (int i = 0; i < tryCount; i++)
            {
                Console.WriteLine("Введите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Секретное слово: ПАРОЛЬ.");
                    break;
                }
                else
                {
                    Console.WriteLine("Не верный пароль. Осталось попыток - " + (tryCount - i - 1) + " шт!!!!.");
                }
            }
        }
    }
}
