using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada_1
{
    class User { }
    class Aktywnosc
    {
        private string Typ;
        public string Czas;
    }
    class Adress
    {
        public string Ulica;
        public int Kod;
        public string Miasto;
    }
    class Pracownik : User
    {
        private string Stanowisko;
        public int Wyplata;
        Aktywnosc Aktywnosc;
        Adress Adres;

        public void setAktywnosc(Aktywnosc aktywnosc)
        {
            Aktywnosc = aktywnosc;
        }
        public void ADodajJakisTamAdres(Adress adres)
        {
            Adres = adres;
        }

        public void UstawParametry()
        {
            Adress a = new Adress();
            a.Miasto = "Poznan";
            this.Adres = a;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
