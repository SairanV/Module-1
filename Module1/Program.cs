using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.
namespace Module1
{
    internal class Program
    {
        //1 задание
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше ФИО:");
            string fio = Console.ReadLine();
            string greeting = "Приветствую тебя - " + fio;
            Console.WriteLine(greeting);
        }
        */


        //2 заданаие
        static void Main()
        {
            Console.WriteLine("Введите несколько чисел через пробел:");
            string input = Console.ReadLine();

            string[] numberStrings = input.Split(' ');
            int sum = 0;

            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i], out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine($"Ошибка: '{numberStrings[i]}' не является числом и будет проигнорировано.");
                }
            }

            Console.WriteLine($"Сумма введенных чисел: {sum}");
        }
    }
}