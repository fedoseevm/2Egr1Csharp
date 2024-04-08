using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compozyt_2
{
    abstract class Graphic
    {
        public abstract void draw();
    }
    class Line : Graphic
    {
        public override void draw() { }
    }
    class Rectangle : Graphic
    {
        public override void draw() { }
    }
    class Text : Graphic
    {
        public override void draw() { }
    }
    class Picture : Graphic
    {
        List<Graphic> list = new List<Graphic>();
        public override void draw() { }
        public void Add(Graphic g)
        {
            list.Add(g);
        }
        public void Remove(Graphic g) { }
        public void GetChild(int i) { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
