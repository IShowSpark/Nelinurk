using System;

namespace Nelinurk
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Sisesta a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta b");
            b = int.Parse(Console.ReadLine());

            Nelinurk N = new Nelinurk(a, b);
            N.Vastus();
            Console.ReadKey();



            Console.ReadKey();
        }
    }
}
