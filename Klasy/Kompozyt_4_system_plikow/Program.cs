using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt_4_system_plikow
{
    internal class Program
    {
        abstract class Wierzcholek
        {
            public string Nazwa;
            public abstract void Wyswietl();
        }
        class Plik : Wierzcholek
        {
            public Plik(string name)
            {
                Nazwa = name;
            }
            public override void Wyswietl()  // Metoda wyświetlająca pliki
            {
                Console.WriteLine("----" + Nazwa);
            }
        }

        class Katalog : Wierzcholek
        {
            List<Wierzcholek> Wierzcholki = new List<Wierzcholek>();
            public Katalog(string name)
            {
                Nazwa = name;
            }
            public void Dodaj(Wierzcholek w)
            {
                Wierzcholki.Add(w);
            }
            public override void Wyswietl()
            {
                Console.WriteLine(Nazwa);
                foreach (var item in Wierzcholki)
                {
                    //Console.WriteLine("--");
                    item.Wyswietl();
                }
            }
        }

        static void Main(string[] args)
        {
            Katalog dysk = new Katalog("Dysk");
            Katalog zdjecia = new Katalog("Zdjęcia");
            Katalog prace = new Katalog("Prace");
            Katalog rozne = new Katalog("Różne");
            dysk.Dodaj(zdjecia);
            dysk.Dodaj(prace);
            dysk.Dodaj(rozne);

            Plik f1 = new Plik("foto1");
            Plik f2 = new Plik("foto2");
            Plik f3 = new Plik("foto3");
            zdjecia.Dodaj(f1);
            zdjecia.Dodaj(f2);
            zdjecia.Dodaj(f3);
            dysk.Wyswietl();
        }
    }
}
