using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int WorkExp { get; set; }

        public Employee(string name, string profession, int workExp)
        {
            Name = name;
            Profession = profession;
            WorkExp = workExp;
        }
        public override string ToString()
        {
            return $"Employee: {Name}, {Profession}, {WorkExp}";
        }
    }
}
