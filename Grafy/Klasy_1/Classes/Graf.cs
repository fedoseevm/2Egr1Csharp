using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_1.Classes
{
    internal class Graf
    {
        public List<Wierzcholek> Wierzcholki = new List<Wierzcholek>();

        public Graf(int iloscWierzcholkow) // Kostruktor
        {
            //while (iloscWierzcholkow-- > 0)
            //{
            //    Wierzcholki.Add(new Wierzcholek());
            //}

            for (int i = 0; i < iloscWierzcholkow; i++)
            {
                Wierzcholki.Add(new Wierzcholek());
            }
        }
        // DodajKrawedz(4, [1,2,6])
        public void DodajKrawedz(int wierzcholek, int[] polaczenia)
        {
            foreach (int item in polaczenia)
            {
                Wierzcholki[wierzcholek].DodajPolaczenie(item);
                //Wierzcholki[item].DodajPolaczenie(wierzcholek);
            }
        }
    }
}
