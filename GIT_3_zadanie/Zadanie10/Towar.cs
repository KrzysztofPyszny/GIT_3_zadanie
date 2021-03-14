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
    }
}
