using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrician e1 = new Electrician();
            e1.Print();
            Console.WriteLine("=========================================");
            Electrician e2 = new Electrician("David Jones", 17000);
            e2.Print();
            Console.WriteLine("=========================================");
            Electrician e3 = new Electrician("Maria Doe", 30000, null);
            e3.Print();

        }
    }
    class Worker
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Worker()
        {
            
        }
        public Worker(int mistos)
        {
            Salary = mistos * 50 / 100;
        }
        public void Print()
        {
            Console.WriteLine($"{Name, -15} {Salary, -10}");
        }

    }
    class Electrician : Worker
    {
        public Electrician() :base()
        {
            Name = "Unknown";
            Salary = 0;
        }
        public Electrician(string name, int salary) :base()
        {
            Salary = salary;
            Name = name;
        }
        public Electrician(string name, int salary, string smthng) :base(salary)
        {
            Name = name;
        }
    }

}
