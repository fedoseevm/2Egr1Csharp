using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada_2
{
    class WashingMachine
    {
        Client Client;
        Washing Washing;
        Rinsing Rinsing;
        Spinning Spinning;
        public void startWashing()
        {

        }
        public void AddTasks(Washing w, Rinsing r, Spinning s)
        {
            Washing = w;
            Rinsing = r;
            Spinning = s;
        }
    }
    class Client
    {
        WashingMachine WashingMachine;
        public void pierz(WashingMachine wm)
        {
            WashingMachine = wm;
        }
    }
    class Washing
    {
        public void wash() { }
    }
    class Rinsing
    {
        public void rince() { }
    }
    class Spinning
    {
        public void spin() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
