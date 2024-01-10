using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc_2_Taxes.Entities
{
    abstract class Person
    {
        public string Name { get; protected set; }
        public double AnnualTax { get; protected set; }

        public Person ()
        {
        }

        public Person (string name, double annualtax)
        {
            Name = name;
            AnnualTax = annualtax;
        }


        public abstract double TaxesPaid();
    }
}