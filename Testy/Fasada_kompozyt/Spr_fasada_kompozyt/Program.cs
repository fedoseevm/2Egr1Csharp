using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spr_fasada_kompozyt
{
    internal class Program
    {
        class Zadanie { }
        class Narzedzie { }
        interface Robotny
        {
            string Robota { get; set; }

            void planuj();
            void dzialaj(Zadanie z);

        }
        class Rekin : Robotny
        {
            public string Robota { get; set; }
            private string imie;
            private string nazwisko;
            public void planuj() { }
            public void dzialaj(Zadanie z) { }
            protected void dobierzNarzedzie(Narzedzie n) { }
        }
        class Leszcz : Robotny
        {
            public string Robota { get; set; }
            private string imie;
            private string odmiana;
            public void planuj() { }
            public void dzialaj(Zadanie z) { }
            protected void wymyslajWymowki() { }
            private void czekaj() { }
            public void Udawaj() { }
        }
        class Gracz : Robotny
        {
            public string Robota { get; set; }
            private string imie;
            private int poziom;
            public void planuj() { }
            public void dzialaj(Zadanie z) { }
            protected void ideGrac() { }
            private void jem() { }
            private bool wydalam()
            {
                return true;
            }
            protected char znowIdeGrac()
            {
                return 'k';
            }
        }
        class Klasa
        {
            public string numerKlasy;
            protected List<Robotny> ListaRobotnych;
            public Robotny robotny;
            public void SetRobotny(Robotny r)
            {
                robotny = r;
            }
            public void dodajDoListy(Robotny r)
            {
                ListaRobotnych.Add(r);
            }
        }
        class Szkola
        {
            private string kraj;
            public Szkola() { }
            // Niestety konstruktor Szkola bez parametrów musi być publiczny, ponieważ klasa Teknikum musi jakoś uzyskać do niej dostęp
            public void stworzSzkole(string k)
            {
                kraj = k;
            }
        }
        class Teknikum : Szkola
        {
            private string nazwa;
            public string podajNazwe()
            {
                return Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
