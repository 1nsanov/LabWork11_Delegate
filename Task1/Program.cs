using System;

namespace Task1
{
    class Program
    {
        private delegate int CountDelegate(int n);
        static void Main(string[] args)
        {
            var deleg = new CountDelegate(Count);

            Console.WriteLine(deleg(13423));
            Console.WriteLine(deleg(1432));
            Console.WriteLine(deleg(67764645));

            Console.ReadLine();
        }

        private static int Count(int n)
        {
            var count = 0;
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            return count;
        }
    }
}
