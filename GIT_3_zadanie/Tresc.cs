using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_3_zadanie
{
    class Tresc
    {
        public static string zad9 = "Napisz program z metodą generyczną służącą do tasowania tablicy obiektów.\n" +
                "Tasowanie (mieszanie) jest operacją odwrotną względem sortowania,\n" +
                "polega na losowej zamianie miejscami elementów danej kolekcji.\n" +
                "Przetestuj metodę na dwóch tablicach, jednej typu int, a drugiej typu Karta.\n" +
                "Zdefiniuj klasę Karta zawierającą dwa pola o odpowiednich typach: kolorKarty\n" +
                "(trefl, pik, karo, kier) oraz nazwaKarty (np. walet, dama, król, as, dwójka, trójka, czwórka, itd.).\n" +
                "Możesz wykorzystać prosty algorytm znany pod nazwą Fisher–Yates shuffle.\n" +
                "W programie użyj metody Array.ForEach(T[], Action<T>) w celu wyświetlenia zawartości\n" +
                "tablicy przed tasowaniem i po tasowaniu.Metoda ta dla podanej tablicy typu T wykonuje\n" +
                "akcję zdefiniowaną poprzez delegata Action<T>.Do definicji akcji użyj wyrażenia lambda.\n";

        public static string zad10 = "Napisz program z metodą generyczną służącą do sortowania tablicy obiektów\n" +
            "dla dowolnej klasy(np.klasy Towar).Sortowanie wykonaj samodzielnie, stosując algorytm\n" +
            "sortowania bąbelkowego.Zdefiniuj delegat wskazujący na metodę służącą do porównywania\n" +
            "obiektów(według wybranego pola klasy lub jej właściwości).\n";
    }
}
