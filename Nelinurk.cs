using System;
using System.Collections.Generic;
using System.Text;

namespace Nelinurk
{
    class Nelinurk
    {
        string tüüp;
        int status;
        double kõrgus;
        double laius;
        public Nelinurk() {}
        public Nelinurk(double Kõrgus,double Laius)
        {
            kõrgus = Kõrgus;
            laius = Laius;
        }
        public string Tüüp
        {
            get
            {
                if (kõrgus==laius || status!=90)
                {
                    tüüp = "Romb";
                }
                else if (kõrgus==laius || status == 90)
                {
                    tüüp = "Ruut";
                }
                else
                {
                    tüüp = "ristkülik";
                }
                return tüüp;
            }
        }
        public int Status
        {
            get { return status; }
            set { }
        }
        public double Pindala()
        {
            double S;
            S = kõrgus * laius;
            return Pindala;
        }
        public double Perimeeter()
        {
            double P;
            P = (kõrgus + laius) * 2;
            return Perimeeter;
        }
        public void Vastus()
        {
            Console.WriteLine($"S = {Pindala}");
            Console.WriteLine($"P = {Perimeeter}");
        }
    }
}
