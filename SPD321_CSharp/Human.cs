using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{
    internal class Human
    {
        protected int age;

        public int Id { get; set; }

        public string Name { get; set; }

        public Human(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //public virtual void Print()
        //{
        //    Console.WriteLine($"{Id} {Name}");
        //}

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }


    /*sealed*/
    abstract class Employee : Human
    {
        new int age;

        public int Salary { get; set; }

        public Employee(int id, string name, int salary) : base(id, name)
        {
            Salary = salary;
        }

        //public override void Print()
        //{
        //    base.age = 0;
        //    Console.WriteLine($"{Id} {Name} {Salary}");

        //}

        public override string ToString()
        {
            return base.ToString() + $" {Salary}";
        }

        public abstract void WhoAmI();
    }


    class Director : Employee, IWork
    {
        int PersonalCount;

        public Director(int id, string name, int salary, int pc):base(id, name, salary)
        {
            PersonalCount = pc;
        }

        public bool IsWorking => true;

        //public override void Print()
        //{
        //    base.age = 0;
        //    Console.WriteLine($"{Id} {Name} {Salary} {PersonalCount}");

        //}

        public override string ToString()
        {
            return base.ToString() + $" {PersonalCount}";
        }

        public override void WhoAmI()
        {
            Console.WriteLine("I`m Director");
        }

        public void Work()
        {
            Console.WriteLine("Я керую людьми");
        }
    }


    class Buhgalter : Employee, IWork
    {
        int experience;

        public Buhgalter(int id, string name, int salary, int ex) : base(id, name, salary)
        {
            experience = ex;
        }

        public bool IsWorking => false;

        //public override void Print()
        //{
        //    base.age = 0;
        //    Console.WriteLine($"{Id} {Name} {Salary} {experience}");

        //}

        public override string ToString()
        {
            return base.ToString() + $" {experience}";
        }

        public override void WhoAmI()
        {
            Console.WriteLine("I`m Buhgalter");
        }

        public void Work()
        {
            Console.WriteLine("Я рахую гроші");
        }
    }

    class CleaningManager : Employee, IWork
    {
        int area;

        public CleaningManager(int id, string name, int salary, int a) : base(id, name, salary)
        {
            area = a;
        }

        public bool IsWorking => true;

        //public override void Print()
        //{
        //    base.Print();
        //}

        public override string ToString()
        {
            return base.ToString() + $" {area}";
        }

        public override void WhoAmI()
        {
            Console.WriteLine("I`m CleaningManager");
        }

        public void Work()
        {
            Console.WriteLine("Я прибираю приміщення");
        }


        //public override void Print()
        //{
        //    base.age = 0;
        //    Console.WriteLine($"{Id} {Name} {Salary} {area}");

        //}
    }

}
