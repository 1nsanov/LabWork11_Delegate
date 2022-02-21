using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        private static Random rnd = new Random();
        private delegate bool Logic(int n);
        private delegate void FuncDelegate(List<int> list);
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var list = new List<int>();
            for (int i = 0; i < rnd.Next(5, 10); i++)
            {
                list.Add(rnd.Next(-20, 20));
            }


            var Print = new FuncDelegate(l => l.ForEach((x) => Console.Write(x + "\t")));
            var Count = new FuncDelegate(l => Console.WriteLine($"Кол-во = {l.Count}"));

            Console.WriteLine("Все элементы");
            Print(list);
            Console.WriteLine();
            Count(list);

            Console.WriteLine("Четные");
            var even = new Logic(n => n % 2 == 0);
            Print(list.Where(x => even(x)).ToList());
            Console.WriteLine();

            Console.WriteLine("Отрицательные, кратны 3");
            var subNeg = new Logic(n => n < 0 && n % 3 == 0);
            Count(list.Where(x => subNeg(x)).ToList());

            Console.ReadLine();
        }
    }
}
