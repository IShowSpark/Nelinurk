using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a, c;
            Console.Write("Введите длину: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту: ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a != 0 && c == 0)
            {
                Nelinurk N = new Nelinurk(a, c);
                string tuup = N.Tuup;
                N.Vastus();
            }
            else if (a != 0 && c != 0)
            {
                Nelinurk N = new Nelinurk(a, c);
                string tuup = N.Tuup;
                N.Vastus();
            }
            else
            {
                Console.WriteLine("[!] Фигуры не существует");
            }
            Console.ReadKey();
        }
    }
}