using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_3_zadanie
{
    class Towar
    {
        public string symbol;
        public string nazwa;
        public double cena;
        public Towar(string symbol, string nazwa, double cena)
        {
            this.symbol = symbol;
            this.nazwa = nazwa;
            this.cena = cena;
        }
        public static void Wypisz(Towar[] towary)
        {
            foreach (var item in towary)
            {
                Console.WriteLine("{0,-15} {1,-20} {2,-10}",
                    item.symbol, item.nazwa, item.cena);
            }
        }

        public delegate bool delegacja_porownanie_cen(Towar x1, Towar x2);
        public static bool comparePrice(Towar x1, Towar x2)
        {
            if (x1.cena > x2.cena)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Towar[] PosortujTowary<T, X>(Towar[] towary, delegacja_porownanie_cen comparer)
        {
            Towar temp;
            for (int j = 0; j <= towary.Length - 2; j++)
            {
                for (int i = 0; i <= towary.Length - 2; i++)
                {
                    if (towary[i].cena > towary[i + 1].cena)
                    {
                        temp = towary[i + 1];
                        towary[i + 1] = towary[i];
                        towary[i] = temp;
                    }
                }
            }
            return towary;
        }
    }
}
