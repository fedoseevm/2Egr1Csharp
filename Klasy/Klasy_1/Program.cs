using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_1
{
    class K1
    {
        // Pole
        protected int Weight;  // Pole z modyfikatorem dostepu protected jest dostepna tylko w tej funkcji i funkcjach dziedziczonych (K2 : K1)
        private string Name;
        private int Age;
        private int Height;

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public int GetHeight()
        {
            return Height;
        }
    }

    class Zamowienia    // Fasada 
    {
        private Klient Klient;
        private List<Produkt> Produkt;
        private Dostawa Dostawa;

        public void SetKlient(Klient klient)    // Agregacja
        {
            this.Klient = klient;
        }
        public void SetProdukt(Produkt produkt) // Agregacja
        {
            this.Produkt.Add(produkt);
        }
        public void DodajDostawe(Dostawa dostawa)   // Asocjacja
        {
            this.Dostawa = dostawa;
        }
    }
    class Klient { }
    class Produkt { }
    class Dostawa { }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
