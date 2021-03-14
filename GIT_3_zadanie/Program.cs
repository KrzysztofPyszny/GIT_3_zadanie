using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_3_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadania programowanie współbieżne i rozproszone.test");

            int wybor;
            do
            {
                Console.WriteLine("\nWybierz zadanie 9 tasowanie obiektów wpisując: 9,\n" +
                    "lub zadanie 10 sortowanie tablicy obiektow wpisując: 10,\n" +
                    "aby wyjść z programu wpisz: 0\n");
                wybor = int.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 9:
                        Console.WriteLine(Tresc.zad9);
                        break;
                    case 10:
                        Console.WriteLine(Tresc.zad10);
                        PrzykladoweSortowanie.SorotwaniePrzyklad();
                        break;
                }
            } while (wybor != 0);
        }
    }
}
