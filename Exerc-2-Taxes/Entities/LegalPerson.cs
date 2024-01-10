using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc_2_Taxes.Entities
{
    class LegalPerson: Person
    {
        public int Employees { get; protected set; }

        public LegalPerson()
        {
        }

        public LegalPerson(string name, double annualTax, int employees)
         : base(name, annualTax)
        {
            Employees = employees;
        }

        public override double TaxesPaid()
        {
            if (Employees > 10)
            {
                return AnnualTax * 0.14;
            }
            return AnnualTax * 0.16;   
        }
    }    
}