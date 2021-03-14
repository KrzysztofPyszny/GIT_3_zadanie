using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_3_zadanie
{
    class PrzykladoweSortowanie
    {
        public static void SorotwaniePrzyklad()
        {
            Towar[] towary = {
                new Towar("DL-2111-M1", "Długopis", 6.5),
                new Towar("OL-2134-M1", "Ołówek", 2.5),
                new Towar("BL-4123-M2", "Blok rysunkowy", 3.5)
            };
            Console.WriteLine("Towary przed sortowaniem:");
            Towar.Wypisz(towary);
            Towar[] sortedTowary = Towar.PosortujTowary<Towar[], Towar.delegacja_porownanie_cen>
                (towary, Towar.comparePrice);
            Console.WriteLine("Towary po sortowaniu:");
            Towar.Wypisz(towary);
        }
    }
}
