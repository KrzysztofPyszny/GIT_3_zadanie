﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_3_zadanie
{
    class Zadanie9
    {
        public class Karta
        {
            public string kolorKarty;
            public string nazwaKarty;
            public Karta(string kolorKarty, string nazwaKarty)
            {
                this.kolorKarty = kolorKarty;
                this.nazwaKarty = nazwaKarty;
            }
        }
        public static Karta createKarta()
        {
            /* Zwraca Karte z losowymi wartościami parametrów */
            string[] tabKolor = new string[] { "trefl", "pik", "karo", "kier" };
            string[] tabNazwa = new string[] { "walet", "dama", "król", "as", "dwójka", "trójka", "czwórka", "piątka", "szóstka", "siódemka", "ósemka", "dziewiątka", "dziesiątka" };
            Random r = new Random();
            return (new Karta(tabKolor[r.Next(0, tabKolor.Length)], tabNazwa[r.Next(0, tabNazwa.Length)]));
        }
    }
}