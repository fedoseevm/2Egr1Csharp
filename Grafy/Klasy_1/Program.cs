using Klasy_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // W klasie graf metoda dodaj krawędź do wierzchołka
            // W klasie wierzchołek lista sąsiadów
            Graf g = new Graf(7);
            g.DodajKrawedz(0, new int[] { 2 });
            g.DodajKrawedz(1, new int[] { 3, 4 });
            g.DodajKrawedz(2, new int[] { 4 });
            g.DodajKrawedz(3, new int[] { 1, 6 });
            g.DodajKrawedz(4, new int[] { 1, 2, 6 });
            //g.DodajKrawedz(5, new int[] {  });
            g.DodajKrawedz(6, new int[] { 3, 4 });

            //for (int i = 0; i < 7; i++)
            //{
                foreach (var item in g.Wierzcholki)
                {
                    foreach (var item2 in item.Polaczenia)
                    {
                        Console.Write($" - {item2} ");
                    }
                    Console.WriteLine();
                }
                // NIE DOKOŃCZONE
            //}
        }
    }
}
