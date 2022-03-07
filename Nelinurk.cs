using System;
using System.Collections.Generic;
using System.Text;

namespace Nelinurk
{
    class Nelinurk
    {
        int tuup;
        double kõrgus;
        int perimeeter;
        int pindala;
        double laius;
        public Nelinurk() {}
        public Nelinurk(int Kõrgus, int Laius)
        {
            kõrgus = Kõrgus;
            laius = Laius;
        }
        public int number()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Sisestage nurk {i + 1}: ");
                tuup = int.Parse(Console.ReadLine());
            }
            return tuup;
        }
        public int Pindala()
        {
            pindala = (int)(kõrgus * laius);
            return pindala;
        }
        public int Perimeeter()
        {
            perimeeter = (int)((kõrgus + laius) * 2);
            return perimeeter;
        }
        public void Vastus()
        {
            Console.WriteLine($"S = {pindala}");
            Console.WriteLine($"P = {perimeeter}");
        }
    }
}
