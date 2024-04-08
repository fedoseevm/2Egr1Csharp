using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada_3
{
    interface Car   // Nie można implementować
    {
        void build();
    }
    class Chevrolet : Car
    {
        public void build() { }
    }
    class BMW : Car
    {
        public void build() { }
    }
    class Renault : Car
    {
        public void build() { }
    }
    class FacadeForCar
    {
        private Car chevrolet;
        private Car bmw;
        private Car renault;

        public FacadeForCar()
        {

        }
        public void buildChevrolet() { }
        public void buildBMW() { }
        public void buildRenault() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
