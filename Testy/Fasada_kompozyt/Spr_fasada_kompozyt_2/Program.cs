using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spr_fasada_kompozyt_2
{
    enum TypPrzystanku
    {
        Zwykly,
        Przesiadkowy,
        NaZadanie,
        Koncowy
    }

    internal class Program
    {
        abstract class Przystanek
        {
            public string Name;
            public TypPrzystanku Typ;
            public Biletomat biletomat;
            public Przystanek(string name)
            {
                Name = name;
            }
            public void Show()
            {
                Console.WriteLine(Name);
            }
        }
        class PunktCentralny : Przystanek
        {
            public PunktCentralny(string name) : base(name)
            {
                Typ = TypPrzystanku.Przesiadkowy;
            }
        }
        class Petla : Przystanek
        {
            public Petla(string name) : base(name)
            {
                Typ = TypPrzystanku.Koncowy;
            }

            public void AddBiletomat()
            {

            }
        }
        class Biletomat
        {

        }
        class ListaAutobusow
        {
            public List<string> listaAutobus;
            public void Add(string przystanek)
            {
                listaAutobus.Add(przystanek);
            }
            public void Remove(string przystanek)
            {
                listaAutobus.Remove(przystanek);
            }
            public void Show()
            {
                foreach (var autobus in listaAutobus)
                    Console.WriteLine(autobus);
            }
        }

        static void Main(string[] args)
        {
            Przystanek pc = new PunktCentralny("Punkt Centralny");

        }
    }
}
