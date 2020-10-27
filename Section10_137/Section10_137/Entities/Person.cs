using System;
using System.Collections.Generic;
using System.Text;

namespace Section10_137.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double Income { get; set; }

        protected Person()
        {
        }

        protected Person(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Tax();
    }
}
