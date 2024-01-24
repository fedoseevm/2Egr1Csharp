using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_1.Classes
{
    internal class Wierzcholek
    {
        public int id;

        public List<int> Polaczenia = new List<int>();

        public void DodajPolaczenie(int wierzcholek)
        {
            Polaczenia.Add(wierzcholek);
        }
    }
}
