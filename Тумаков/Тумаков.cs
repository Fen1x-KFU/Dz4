using System;
using System.Security.Cryptography;

namespace Tumakov
{
    public class Program
    {
        static void StartTask(string n)
        {
            Console.WriteLine($"Задание {n}");
        }

        static int Task51()
        {
            StartTask("5.1");

            Console.WriteLine("Введите 2 числа для сравнения!");

            int number11 = int.Parse(Console.ReadLine());
            int number21 = int.Parse(Console.ReadLine());

            int maxNumber = Math.Max(number11, number21);

            return maxNumber;
        }

        static void Reference(ref int number12, ref int number22)
        {
            int znach = number12;
            number12 = number22;
            number22 = znach;
        }
        static void Task52()
        {
            StartTask("5.2");

            Console.WriteLine("Введите значение a:");
            Console.WriteLine("Введите значение b:");

            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());

            Reference(ref a1, ref b1);

            Console.WriteLine($"Поменяем a и b местами и получим, что a = {a1}, b = {b1}");
        }

        static bool Task53(int number, out long result)
        {
            StartTask("5.3");

            Console.WriteLine("Введите номер факториала!");
            number = int.Parse(Console.ReadLine());
            
            result = 1;
            try
            {
                checked
                {
                    for (int i = 1; i <= number; i++)
                    {
                        result *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        static void Main()
        {

            Console.WriteLine($"Максимальное из этих чисел: {Task51()}");
            Task52();
            int num = 0;
            long factorialResult;
            bool success = Task53(num, out factorialResult);
            Console.WriteLine(success);
        }
    }
}