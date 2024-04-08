using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compozyt_3
{
    interface Employee
    {
        string Name { get; set; }
        void GetName();
        void SetName();
    }
    class Junior : Employee
    {
        public string Name { get; set; }
        public void GetName() { }
        public void SetName() { }
    }
    class Manager : Employee
    {
        public string Name { get; set; }
        public void GetName() { }
        public void SetName() { }

        List<Employee> Employees = new List<Employee>();
        public void AddJunior(Junior junior)
        {
            Employees.Add(junior);
        }
        public void RemoveJunior(string name) { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
