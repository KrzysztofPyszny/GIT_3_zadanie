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
            Console.WriteLine("Zadania programowanie współbieżne i rozproszone.\n");

            int wybor;
            do
            {
                Console.WriteLine("Wybierz zadanie 9 tasowanie obiektów wpisując: 9,\n" +
                    "lub zadanie 10 sortowanie tablicy obiektow wpisując: 10,\n" +
                    "aby wyjść z programu wpisz: 0");
                wybor = int.Parse(Console.ReadLine());
            } while (wybor != 0);
        }
    }
}
