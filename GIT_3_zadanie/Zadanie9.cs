using System;
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
        public static int rInt(int min, int max)
        {
            /* Zwraca losową liczbę typu Int */
            return (new Random()).Next(min, max + 1);
        }
        public static Karta[] shuffle(Karta[] deck)
        {
            /* Zwraca potasowaną tablicę obiektów Karta */
            for (int i = 0; i < deck.Length; i++)
            {
                Karta temp = deck[i];
                int rand = rInt(0, (deck.Length - 1));
                deck[i] = deck[rand];
                deck[rand] = temp;
            }
            return deck;
        }
        public static int[] shuffle(int[] deck)
        {
            /* Zwraca potasowaną tablicę wartościa typu Int */
            for (int i = 0; i < deck.Length; i++)
            {
                int temp = deck[i];
                int rand = rInt(0, (deck.Length - 1));
                deck[i] = deck[rand];
                deck[rand] = temp;
            }
            return deck;
        }
    }
}
