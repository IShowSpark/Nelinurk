using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    public class Nelinurk
    {

        double pikk;
        double kõrgus;
        double laius;
        bool asd;
        string status;
        int[] tuup = new int[4];
        private double a;
        private double c;

        public Nelinurk() { }
        public Nelinurk(double Pikk, double Laius, double Kõrgus)
        {
            pikk = Pikk;
            laius = Laius;
            kõrgus = Kõrgus;
        }

        public Nelinurk(double a, double c)
        {
            this.a = a;
            this.c = c;
        }

        public string Tuup
        {
            get
            {
                int asd1 = 0;
                for (int i = 0; i < tuup.Length; i++)
                {
                    if (tuup[i] == 90)
                    {
                        asd1++;
                    }
                }
                if (pikk == laius && kõrgus == 0)
                {
                    status = "Квадрат";
                }
                else if (pikk != laius && asd1 == 4)
                {
                    status = "Прямоугольник";
                }
                return status;
            }

        }
        public bool figura1
        {
            get
            {
                int summ = 0;
                for (int i = 0; i < tuup.Length; i++)
                {
                    summ += tuup[i];

                }
                if (summ != 360)
                {
                    asd = true;
                }
                else
                {
                    asd = false;
                }
                return asd;
            }

        }
        public double Pindala()
        {
            double pindala;
            pindala = pikk * laius;
            return pindala;
        }
        public double Ombermotot()
        {
            double ombermotot;
            ombermotot = (pikk + laius) * 2;
            return ombermotot;
        }
        public void Vastus()
        {
            if (asd == false)
            {
                Console.WriteLine($"Это {status}");
                Console.WriteLine($"S = {Pindala()}\nP = {Ombermotot()}");
            }
            else
            {
                Console.WriteLine("[!] Такой фигуры не существует");
            }
        }
    }
}

