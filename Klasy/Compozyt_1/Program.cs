using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compozyt_1
{
    interface Component
    {
        void operation();
    }
    class Leaf : Component
    {
        public void operation() { }
    }
    class Composite : Component
    {
        List<Composite> composites = new List<Composite>();
        public void operation() { }
        public void add(Composite comp) 
        {
            composites.Add(comp);
        }
        public void remove() { }
        public void GetChild()
        {

        }
        public void SetComponent()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
