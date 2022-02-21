using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            // К Заданию 2
            Func<int, int, bool> deleg = (x, y) => Math.Abs(x) % Math.Abs(y) == 0;

            Console.WriteLine(deleg(10, 5));
            Console.WriteLine(deleg(24, 6));
            Console.WriteLine(deleg(30, 4));

            // К Заданию 3
            Console.ForegroundColor = ConsoleColor.Green;

            var list = new List<int>();
            for (int i = 0; i < rnd.Next(5, 10); i++)
            {
                list.Add(rnd.Next(-20, 20));
            }


            Action<List<int>> Print = l => l.ForEach((x) => Console.Write(x + "\t"));
            Action<List<int>> Count = l => Console.WriteLine($"Кол-во = {l.Count}");

            Console.WriteLine("Все элементы");
            Print(list);
            Console.WriteLine();
            Count(list);

            Console.WriteLine("Четные");
            Predicate<int> even = n => n % 2 == 0;
            Print(list.Where(x => even(x)).ToList());
            Console.WriteLine();

            Console.WriteLine("Отрицательные, кратны 3");
            Predicate<int> subNeg = n => n < 0 && n % 3 == 0;
            Count(list.Where(x => subNeg(x)).ToList());

            Console.ReadLine();
        }
    }
}
