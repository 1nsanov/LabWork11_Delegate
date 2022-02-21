using System;

namespace Task2
{
    class Program
    {
        private delegate bool Operation(int x, int y);
        static void Main(string[] args)
        {
            var deleg = new Operation((x, y) => Math.Abs(x) % Math.Abs(y) == 0);

            Console.WriteLine(deleg(10, 5));
            Console.WriteLine(deleg(24, 6));
            Console.WriteLine(deleg(30, 4));

            Console.ReadLine();
        }
    }
}
