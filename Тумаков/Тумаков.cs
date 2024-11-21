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

        //static int Task51()
        //{
        //    StartTask("5.1");

        //    Console.WriteLine("Введите 2 числа для сравнения!");

        //    int number1 = int.Parse(Console.ReadLine());
        //    int number2 = int.Parse(Console.ReadLine());

        //    int maxNumber = Math.Max(number1, number2);

        //    return maxNumber;
        //}
        public class Peremen
        {
            // Добавим свойства для хранения значений a и b
            public int a { get; set; }
            public int b { get; set; }

            // Конструктор класса для чтения значений a и b при создании объекта
            public Peremen()
            {
                a = int.Parse(Console.ReadLine());

                b = int.Parse(Console.ReadLine());
            }
        }
        static void Task52(Peremen peremen)
        {
            StartTask("5.2");

            Console.WriteLine("Введите значение a:");
            Console.WriteLine("Введите значение b:");

            int a52;
            int b52;

            a52 = peremen.b;
            b52 = peremen.a;

            Console.WriteLine(a52);6
            Console.WriteLine(b52);
        }

        //static void Task53()
        //{
        //    StartTask("5.3");


        //}
        static void Main()
        {

            //Console.WriteLine($"Максимальное из этих чисел: {Task51()}");
            Peremen peremen = new Peremen();
            Task52(peremen);
            //Task53();
        }
    }
}