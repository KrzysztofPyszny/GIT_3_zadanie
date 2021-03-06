using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_3_zadanie
{
    class Zadanie9
    {
        public static Random rand = new Random();
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
            Random r = Zadanie9.rand;
            return (new Karta(tabKolor[r.Next(0, tabKolor.Length)], tabNazwa[r.Next(0, tabNazwa.Length)]));
        }
        public static int rInt(int min, int max)
        {
            /* Zwraca losową liczbę typu Int */
            return Zadanie9.rand.Next(min, max + 1);
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
        public static void showMeDeck(Karta[] deck)
        {
            /* Wersja pokazująca karty */
            Action<Karta> localShuffle = x => Console.WriteLine("Kolor: {0} Nazwa: {1}", x.kolorKarty, x.nazwaKarty);
            Array.ForEach(deck, localShuffle);
        }
        public static void showMeDeck(int[] deck)
        {
            /* Wersja pokazująca Int-y */
            Action<int> localShuffle = x => Console.WriteLine(" {0} ", x);
            Array.ForEach(deck, localShuffle);
        }
        public static void Execute() {
            /* po 10 Randomowych Elementów w każdej tablicy */
            int[] tabInt = new int[] { rInt(0, 9), rInt(0, 9), rInt(0, 9), rInt(0, 9), rInt(0, 9), rInt(0, 9), rInt(0, 9), rInt(0, 9), rInt(0, 9), rInt(0, 9) };
            Karta[] tabKar = new Karta[] { createKarta(), createKarta(), createKarta(), createKarta(), createKarta(), createKarta(), createKarta(), createKarta(), createKarta(), createKarta() };
            /* Pokazanie zawartości Talii przed tasowaniem */
            Console.WriteLine("Przed Tasowaniem:");
            showMeDeck(tabKar);
            showMeDeck(tabInt);
            /* Tasowanie wygenerowanych tablic */
            shuffle(tabKar);
            shuffle(tabInt);
            /* Pokazanie zawartości Talii po tasowaniu*/
            Console.WriteLine("Po Tasowaniu");
            showMeDeck(tabKar);
            showMeDeck(tabInt);
        }
    }
}
